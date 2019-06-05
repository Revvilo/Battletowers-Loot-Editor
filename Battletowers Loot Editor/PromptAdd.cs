using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattletowersLootEditor
{
    public partial class PromptAdd : Form
    {
        public string Id { get { return textBoxEdit_ID.Text; } set { textBoxEdit_ID.Text = value; } }
        public string Type { get { return radioButton_Item.Checked ? "ITEM" : "CHESTGENHOOK"; } }
        public int Meta { get { return (int)numericUpDown_Meta.Value; } set { numericUpDown_Meta.Value = value; } }
        public int Chance { get { return (int)numericUpDown_Chance.Value; } set { numericUpDown_Chance.Value = value; } }
        public int MinAmt { get { return (int)numericUpDown_Min.Value; } set { numericUpDown_Min.Value = value; } }
        public int MaxAmt { get { return (int)numericUpDown_Max.Value; } set { numericUpDown_Max.Value = value; } }


        public PromptAdd()
        {
            InitializeComponent();
        }


        public LootEntry GetEntry()
        {
            LootEntry entry;
            if (Type == "CHESTGENHOOK")
            {
                entry = new LootEntry(Id, Meta);
            }
            else
            {
                entry = new LootEntry(Id, Meta, Chance, MinAmt, MaxAmt);
            }
            return entry;
        }


        private void RadioButton_Clicked(object sender, EventArgs e)
        {
            var senderRadioButton = sender as RadioButton;
            if (senderRadioButton.Name == "radioButton_Item")
            {
                numericUpDown_Chance.Enabled = true;
                numericUpDown_Min.Enabled = true;
                numericUpDown_Max.Enabled = true;
            }
            else if (senderRadioButton.Name == "radioButton_ChestGenHook")
            {
                numericUpDown_Chance.Enabled = false;
                numericUpDown_Min.Enabled = false;
                numericUpDown_Max.Enabled = false;
            }
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
