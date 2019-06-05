using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BattletowersLootEditor
{
    public partial class FormLootEditor : Form
    {
        private LootTable lootTable;
        private string currentFile;
        private string FileDisplay { get { return textBox_PathDisplay.Text; } set { textBox_PathDisplay.Text = value; textBox_PathDisplay.SelectionStart = textBox_PathDisplay.Text.Length; textBox_PathDisplay.ScrollToCaret(); } }
        private int SelectedFloorIndex { get { return tabControlFloors.SelectedIndex; } }
        private ListView SelectedListView { get { return (ListView)tabControlFloors.SelectedTab.Controls["listView"]; } }

        public FormLootEditor()
        {
            InitializeComponent();
        }


        private void FormLootEditor_Load(object sender, EventArgs e)
        {
            // Gets all pages from the Tab Control
            TabControl.TabPageCollection pages = tabControlFloors.TabPages;

            // Adds a ListView control to each tab - I don't know if this is even in the right spot to have this
            Console.WriteLine("\nBegin generating ListViews");
            foreach (TabPage page in pages)
            {
                ListView listView = new ListView();
                listView.Name = "listView";
                listView.View = View.Details;
                listView.FullRowSelect = true;
                listView.Columns.Add("Item ID / ChestGenHook", 300);
                listView.Columns.Add("Meta", -2);
                listView.Columns.Add("% Chance", -2);
                listView.Columns.Add("Min Amt", -2);
                listView.Columns.Add("Max Amt", -2);

                listView.DoubleClick += new EventHandler(ListView_DoubleClicked);
                //listView.KeyPress += new KeyPressEventHandler(ListView_KeyPressed);
                listView.ContextMenuStrip = contextMenuStrip1;

                listView.Location = new Point(6, 6);
                listView.Size = new Size(page.Width - 12, page.Height - 12);
                listView.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
                page.Controls.Add(listView);
                Console.WriteLine("\tAdding ListView to control: " + page.Name);
            }
            Console.WriteLine("Finished generating ListViews\n");
        }


        // Executed when a dynamically generated ListView's item is double clicked
        protected void ListView_DoubleClicked(object sender, EventArgs e)
        {
            var senderListView = (ListView)sender;

            if (senderListView.Items.Count != 0)
            {
                // Horizontal axis in grid (Columns)
                int editFloorIndex = tabControlFloors.SelectedIndex;                    // Current floor
                List<LootEntry> editFloorLoot = lootTable.GetFloorLoot(editFloorIndex); // Current floor's loot

                // Vertical axis in grid (Items in columns)
                int editEntryIndex = senderListView.SelectedItems[0].Index; // Current entry index
                LootEntry editEntry = editFloorLoot[editEntryIndex];        // Current entry

                Console.WriteLine("ListView item double clicked:\n - Item index:\t" + senderListView.SelectedItems[0].Index.ToString() + "\n - Page index:\t" + tabControlFloors.SelectedIndex);


                // TODO: Comment this shit (edit dialog logic) UPPPPPPPPPPPPPPPP
                PromptEdit dialog = new PromptEdit(editEntry);

                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.Text = string.Format("Editing loot entry - Floor {0} - Entry {1}", editFloorIndex + 1, editEntryIndex + 1);

                if (dialog.ShowDialog(FormLootEditor.ActiveForm) == DialogResult.OK)
                {
                    LootEntry editedEntry;
                    if (editEntry.Type == "ITEM")
                    {
                        editedEntry = new LootEntry(dialog.Id, dialog.Meta, dialog.Chance, dialog.MinAmt, dialog.MaxAmt);
                    }
                    else
                    {
                        editedEntry = new LootEntry(dialog.Id, dialog.Meta);
                    }
                    lootTable.UpdateEntry(editedEntry, editFloorIndex, editEntryIndex);
                    PopulateLists();
                }
            }
        }


        private void AddEntry(object sender, EventArgs e)
        {
            if (currentFile is null)
            {
                MessageBox.Show(
                    "You must select a Battletowers Config with the Browse button first!",
                    "Error while parsing loot!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            PromptAdd dialog = new PromptAdd();

            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.Text = string.Format("Add Entry");

            if (dialog.ShowDialog(FormLootEditor.ActiveForm) == DialogResult.OK)
            {
                lootTable.AddEntry(SelectedFloorIndex, dialog.GetEntry());
                PopulateLists();
            }
        }


        public void PopulateLists()
        {
            Console.Write("Populating ListViews...");
            TabControl.TabPageCollection pages = tabControlFloors.TabPages; // Exposes the list of pages within the TabControl
            for (int i = 0; i < pages.Count; i++) // Loops through each page - each page represents a floor of the tower
            {
                //Console.Write("\tAdding Entries for floor " + (i+1));
                ListView pageListView = pages[i].Controls["listView"] as ListView; // Exposes the ListView control within the current "page" (AKA floor)
                pageListView.Items.Clear(); // Wipes the list as we're simply displaying the current loot table and need a clean slate.
                List<LootEntry> currentFloor = lootTable.GetFloorLoot(i); // Exposes the loot that needs to be listed for the current floor
                if (currentFloor == null) { continue; }
                foreach (var item in currentFloor)
                {
                    pageListView.Items.Add(item.ToListItem());
                }
                //Console.WriteLine(string.Format(" - Listed {0} entries.", pageListView.Items.Count));
            }
            Console.WriteLine(" Complete.\n");
        }


        private void SelectFile(string path)
        {
            this.currentFile = path;
            FileDisplay = currentFile;
            Console.WriteLine("Loading file: " + this.currentFile);
            this.lootTable = new LootTable(this.currentFile);
            PopulateLists();
        }


        private void Browse(object sender, EventArgs e)
        {
            try
            {
                // TODO: Comment browse menu logic
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Config|battletowers.cfg|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.PreviousPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                    SelectFile(ofd.FileName);
                }
            }
            catch (SystemException ex)
            {
                if (ex is FormatException) // When
                {
                    MessageBox.Show(
                        "There was an error while reading loot from the config.\n\n" +
                            "This can happen when there are parameters for an item that should be numbers, but aren't -\n" +
                            "for example item meta or spawn chance.",
                        "Error while parsing loot!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else if (ex is System.IO.FileNotFoundException) // When the input file doesn't exist
                {
                    MessageBox.Show(
                        "The config file that was selected could not be found.\n" +
                            "It may have been moved or deleted.",
                        "Config file not found!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else // When an uknown error is encountered
                {
                    MessageBox.Show(
                        "An unknown error ocurred.\n" +
                            "Please report this to the developer!\nError is as follows:\n\n" +
                            ex,
                        "Unknown error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void Browse_OpenLast(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PreviousPath == "")
            {
                MessageBox.Show(
                    "A config has not yet been opened by Battletowditor on this computer.\n" +
                    "You must open one using the browse menu first.",
                    "Whoops!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            SelectFile(Properties.Settings.Default.PreviousPath);
        }


        private void Save(object sender, EventArgs e)
        {
            try
            {
                this.lootTable.SaveLootToConfig(this.currentFile);
            }
            catch (SystemException ex)
            {
                if (ex is NullReferenceException) // When no loot is loaded
                {
                    MessageBox.Show(
                        "You haven't loaded loot from a Battletowers config file yet.\n\n" +
                            "Use the Browse button to select a file to load from.",
                        "Nothing to save!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else if (ex is FileNotFoundException) // When the output config doesn't exist
                {
                    MessageBox.Show(
                        "Selected file doesn't exist!\n" +
                            "It may have been moved or deleted.\n\n" +
                            "An existing config is required as saving only \"updates\" the lines where the loot is configured and leaves the rest intact.",
                        "Destination config missing!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else // When an uknown error is encountered
                {
                    MessageBox.Show(
                        "An unknown error ocurred.\n" +
                            "Please report this to the developer!",
                        "Unknown error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        private void Reload(object sender, EventArgs e)
        {
            if ((this.currentFile != null) && (MessageBox.Show("This will re-read the loot from the selected file - any unsaved changes made within the editor will be lost.\n\nAre you sure you want to do this?", "Reload warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
            {
                SelectFile(this.currentFile);
            }
        }


        private void MoveEntry(object sender, EventArgs e)
        {
            if (SelectedListView.Items.Count > 1) // Only execute when there's actually items in the ListView
            {
                //                   Current Floor       The first item in the selection
                lootTable.NudgeEntry(SelectedFloorIndex, SelectedListView.SelectedItems[0].Index, (sender.ToString() == "Move Up") ? true : false);
                PopulateLists();
            }
        }


        private void Delete(object sender, EventArgs e)
        {
            if (currentFile == null) { return; }
            for (int i = SelectedListView.SelectedItems.Count; i > 0; i--)
            {
                ListViewItem selectedItem = SelectedListView.SelectedItems[i - 1];
                Console.WriteLine(string.Format("Deleting entry '{0}' from floor {1} with contents '{2}'", selectedItem.Index, SelectedFloorIndex+1, lootTable.entryList[SelectedFloorIndex][selectedItem.Index].GetConfigEntry()));
                lootTable.RemoveEntry(SelectedFloorIndex, selectedItem.Index);
            }
            PopulateLists();
        }
    }
}
