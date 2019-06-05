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
    public partial class PromptEdit : Form
    {
        public string Id { get { return textBoxEdit_ID.Text; } set { textBoxEdit_ID.Text = value; } }
        public int Meta { get { return (int)numericUpDown_Meta.Value; } set { numericUpDown_Meta.Value = value; } }
        public int Chance { get { return (int)numericUpDown_Chance.Value; } set { numericUpDown_Chance.Value = value; } }
        public int MinAmt { get { return (int)numericUpDown_Min.Value; } set { numericUpDown_Min.Value = value; } }
        public int MaxAmt { get { return (int)numericUpDown_Max.Value; } set { numericUpDown_Max.Value = value; } }

        public PromptEdit(LootEntry entryToDisplay)
        {
            InitializeComponent();
            if (entryToDisplay.Type == "ITEM")
            {
                // TODO: Simplify setting and getting text from boxes - perhaps by using mapping or config - too advanced ATM
                textBoxOriginal_ID.Text      = Id = entryToDisplay.GetID();                         // ID
                textBoxOriginal_Meta.Text    = (Meta = entryToDisplay.GetMeta()).ToString();        // Meta
                textBoxOriginal_Chance.Text  = (Chance = entryToDisplay.GetChance()).ToString();    // % Chance
                textBoxOriginal_Min.Text     = (MinAmt = entryToDisplay.GetMinAmt()).ToString();    // Min amt
                textBoxOriginal_Max.Text     = (MaxAmt = entryToDisplay.GetMaxAmt()).ToString();    // Max amt
            }
            else
            {
                textBoxEdit_ID.Text = textBoxOriginal_ID.Text = entryToDisplay.GetID();
                textBoxOriginal_Meta.Text = (Meta = entryToDisplay.GetMeta()).ToString();           // Meta
                numericUpDown_Chance.Enabled = false;
                numericUpDown_Min.Enabled = false;
                numericUpDown_Max.Enabled = false;
            }
        }

        public LootEntry GetEntry()
        {
            LootEntry entry;
            if (numericUpDown_Chance.Text == "")
            {
                entry = new LootEntry(Id, Meta);
            }
            else
            {
                entry = new LootEntry(Id, Meta, Chance, MinAmt, MaxAmt);
            }
            return entry;
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderUpDown = sender as NumericUpDown;
            //Console.WriteLine(senderUpDown.Value);
        }

        private void EditBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderTextBox = sender as TextBox;
            string senderName = senderTextBox.Name;
            if (senderName == "textBoxEdit_ID" || senderName == "numericUpDown_Meta")
            {
                if (senderTextBox.Text == "")
                    buttonDone.Enabled = false;
                else
                    buttonDone.Enabled = true;
            }
            else if (senderName == "numericUpDown_Chance" || senderName == "numericUpDown_Min" || senderName == "numericUpDown_Max")
            {
                //if (numericUpDown_Chance.Text == "" && numericUpDown_Min.Value == "" && numericUpDown_Max.Value == "")
                //    buttonDone.Enabled = true; // Last 3 text boxes are empty, thus meaning it is a chestgenhook
                //else if (numericUpDown_Chance.Text != "" && numericUpDown_Min.Value != "" && numericUpDown_Max.Value != "")
                //    buttonDone.Enabled = true; // Last 3 text boxes are NOT empty, thus meaning it is an item
                //else
                //    buttonDone.Enabled = false; // Last 3 text boxes must be full or empty, not a combination.
            }
        }
    }
}
