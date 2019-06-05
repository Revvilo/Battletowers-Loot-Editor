using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BattletowersLootEditor
{
    public class LootTable
    {
        public List<LootEntry>[] entryList { get; } = new List<LootEntry>[10];

        public LootTable() { }

        public LootTable(string filePath)
        {
            string[] inConfig = File.ReadAllLines(filePath);
            LoadLootFromConfig(inConfig);
        }


        /// <summary>
        /// Gets list of loot at specified floor number (1 to 10)
        /// </summary>
        /// <param name="floorNumber"></param>
        /// <returns>LootEntry array</returns>
        public List<LootEntry> GetFloorLoot(int floorNumber)
        {
            return this.entryList[floorNumber];
        }


        public void SaveLootToConfig(string path)
        {
            // TODO: Come up with a better word for of "header" - I know there is one, but my brain is off with the eggrolls
            // Init the array of output lines with their "headers" for lack of a better word
            string[] outputLines = {
                "    S:\"Floor 1\"=",
                "    S:\"Floor 2\"=",
                "    S:\"Floor 3\"=",
                "    S:\"Floor 4\"=",
                "    S:\"Floor 5\"=",
                "    S:\"Floor 6\"=",
                "    S:\"Floor 7\"=",
                "    S:\"Floor 8\"=",
                "    S:\"Floor 9\"=",
                "    S:\"Top Floor\"="
            };

            // Processes the current LootTable into config-file-friendly lines and stores them in string[] outputLines
            // TODO: Would be interested to see if there are possible optimisations to 
            for (int i = 0; i < 10; i++) // Loops through each floor
            {
                List<LootEntry> currentFloor = entryList[i];
                foreach (LootEntry lootEntry in currentFloor)
                {
                    outputLines[i] = outputLines[i] + lootEntry.GetConfigEntry();
                }
                outputLines[i] = outputLines[i].TrimEnd(';'); // TODO: Avoiding trailing semicolon might be improvable
            }

            // Reads the destination config into an array of strings and compares each line to check which ones need to be overwritten with the ones that need to be saved
            string[] configLines = File.ReadAllLines(path);
            for (int i = 0; i < configLines.Length; i++) // Foreach line in dest. config
            {
                foreach (string outputLine in outputLines) // Forech line in output config
                {
                    // This is a hacky-ish way of matching the lines in the config with the lines that need to be saved, in order to overwrite-
                    // the correct lines with the "output" ones. - It's sketchy and situation specific, but man is it CLEAN. WOOOOOO
                    // TODO: Optimise line matching
                    if (configLines[i].StartsWith(outputLine.Substring(0, 16)))
                    {
                        Console.WriteLine(string.Format("Output Line:\t{0}\nMatched:\t\t{1}\n", outputLine, configLines[i]));
                        configLines[i] = outputLine;
                    }
                }
            }
            File.WriteAllLines(path, configLines);
        }


        public void AddEntry(int floorNumber, LootEntry entry)
        {
            entryList[floorNumber].Add(entry);
        }

        public void RemoveEntry(int floorNumber, int entryIndex)
        {
            entryList[floorNumber].RemoveAt(entryIndex);
        }


        public void UpdateEntry(LootEntry changedEntry, int floorNum, int entryNum)
        {
            entryList[floorNum][entryNum] = changedEntry;
        }


        /// <summary>
        /// Nudges the entry up or down the list of loot entries. Along with the floor number to operate on (1-10) and the index of the item to move, use true for up and false for down.
        /// </summary>
        /// <param name="floorIndex">0 based index of the current floor (0 to 9)</param>
        /// <param name="up">true for up, false for down</param>
        public void NudgeEntry(int floorIndex, int indexToMove, bool up)
        {
            bool down = !up;

            Console.WriteLine(string.Format("Nudging entry {0}, on floor {1} {2}", indexToMove, floorIndex+1, up ? "upward" : "downward"));
            if ( (up && indexToMove == 0) || (down && indexToMove+1 == entryList[floorIndex].Count) )
            {
                Console.WriteLine("OutOfBounds check succeeded - returning");
                return;
            }
            else
            {
                Console.WriteLine(string.Format("OutOfBounds check failed - details:\n" +
                    "\tup? : {0}\n" +
                    "\tindexToMove : {1}\n" +
                    "\tAmount of loot at current floor : {2}\n" +
                    "\t(down && indexToMove == entryList[floorIndex].Count) : {3}\n" +
                    "\t(up && indexToMove == 0) : {4}\n" +
                    "\t(up && indexToMove == 0) || (down && indexToMove == entryList[floorIndex].Count) : {5}",
                    up, indexToMove, entryList[floorIndex].Count, (down && indexToMove == entryList[floorIndex].Count), (up && indexToMove == 0), (up && indexToMove == 0) || (down && indexToMove == entryList[floorIndex].Count))
                );
            }
            LootEntry item = entryList[floorIndex][indexToMove];
            entryList[floorIndex].RemoveAt(indexToMove);
            entryList[floorIndex].Insert(indexToMove + (up ? -1 : 1), item);
        }


        /// <summary>
        /// Filters an array of strings down to just lines where the per-floor loot tables are configured, returning them in a list of strings
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        private List<string> CropConfig(string[] config)
        {
            // "Crops" the config down to just the range of lines that contain the loot tables
            List<string> output = new List<string>();
            foreach (string line in config)
            {
                // Narrows down the lines to just the ones we want
                if (line.StartsWith("    S:") && (line.ToLower().Contains("floor")) && !(line.StartsWith("    S:\"Item Generations per Floor\"=")))
                {
                    output.Add(line.Substring(line.IndexOf('=') + 1));
                }
            }

            return output;
        }


        private void LoadLootFromConfig(string[] inConfig)
        {
            Console.WriteLine("Begin loading loot into LootTable...");

            // "Crops" config down to just the lines where the loot tables are stored
            //   Also removes the beginnings of the lines that notate the config parameters
            List<string> croppedConfig = CropConfig(inConfig);

            // Loops through each line (aka floor) in cropped config.
            for (int i = 0; i < croppedConfig.Count(); i++)
            {
                Console.Write("\tOperating on floor "+(i+1));
                string currentLine = croppedConfig[i];

                entryList[i] = new List<LootEntry>();

                if (currentLine == "") { Console.WriteLine(" - 0 entries added. (empty)"); continue; }

                // Takes the line which now only includes the loot entries and splits it to the semicolon, creating an array of the loot entries for that floor.
                string[] currentFloorLoot = currentLine.Split(';');

                // Loops through each loot entry for the current floor
                for (int entryIndex = 0; entryIndex < currentFloorLoot.Length; entryIndex++)
                {
                    entryList[i].Add(new LootEntry(currentFloorLoot[entryIndex]));
                }
                Console.WriteLine(string.Format(" - {0} {1} added.", entryList[i].Count, entryList[i].Count > 1 ? "entries" : "entry"));
            }

            Console.WriteLine("Complete.\n");
        }
    }
}
