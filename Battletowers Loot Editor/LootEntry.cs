using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattletowersLootEditor
{
    public class LootEntry
    {
        // Instance variables if I remember right
        public string Type { get; set; }
        private string ID;
        private int meta, chance, amtMin, amtMax;

        // Constructors
        public LootEntry(string ID, int meta, int chance, int minAmt, int maxAmt)
        {
            this.Type = "ITEM";
            this.ID = ID;
            this.meta = meta;
            this.chance = chance;
            this.amtMin = minAmt;
            this.amtMax = maxAmt;
        }

        public LootEntry(string ID, int meta)
        {
            this.Type = "CHESTGENHOOK";
            this.ID = ID;
            this.meta = meta;
        }

        /// <summary>
        /// Takes a single string in either the format "itemid-meta-chance-minAmt-maxAmt" or "ChestGenHook:file/path:meta" and parses it into the parameters for a LootEntry
        /// </summary>
        /// <param name="input"></param>
        public LootEntry(string input)
        {
            if (input.StartsWith("ChestGenHook")) // It's a chestgenhook
            {
                this.Type = "CHESTGENHOOK";
                string[] splitInput = input.Split(':');

                this.ID = splitInput[0]+":"+splitInput[1];
                this.meta = int.Parse(splitInput[2]);
            }
            else // It's not a chestgenhook
            {
                this.Type = "ITEM";
                string[] splitInput = input.Split('-');

                this.ID = splitInput[0];
                this.meta = int.Parse(splitInput[1]);
                this.chance = int.Parse(splitInput[2]);
                this.amtMin = int.Parse(splitInput[3]);
                this.amtMax = int.Parse(splitInput[4]);
            }
        }

        /// <summary>
        /// Returns a single string of the LootEntry's parameters in a Battletowers.cfg friendly format
        /// </summary>
        /// <returns></returns>
        public string GetConfigEntry()
        {
            if (this.Type == "ITEM")
            {
                return string.Format("{0}-{1}-{2}-{3}-{4};", this.ID, this.meta, this.chance, this.amtMin, this.amtMax);
            }
            else
            {
                return string.Format("{0}:{1};", this.ID, this.meta);
            }
        }

        public ListViewItem ToListItem()
        {
            if (this.Type == "ITEM") // It's an Item entry
            {
                ListViewItem lvItem = new ListViewItem(this.ID);
                string[] subItems = { this.meta.ToString(), this.chance.ToString(), this.amtMin.ToString(), this.amtMax.ToString() };
                lvItem.SubItems.AddRange(subItems);
                return lvItem;
            }
            else // It's a ChestGenHook entry
            {
                ListViewItem lvItem = new ListViewItem(this.ID);
                lvItem.SubItems.Add(this.meta.ToString());
                return lvItem;
            }
        }

        // TODO: Maybe replace with get; set; - couldn't get it to work atm.
        public string GetID() { return this.ID; }
        public int GetMeta() { return this.meta; }
        public int GetChance() { return this.chance; }
        public int GetMinAmt() { return this.amtMin; }
        public int GetMaxAmt() { return this.amtMax; }
    }
}
