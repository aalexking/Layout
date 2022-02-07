using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout
{
    [System.Serializable]
    public class LayoutPreset
    {

        public string presetName;  // Name of preset

        public List<string> apps = new List<string>(); // List stores applications connected to preset


        public LayoutPreset(string name, List<string> list)
        {
            this.presetName = name;
            this.apps = list;
        }


        // Sets name of preset
        public void SetPresetName(string newName)
        {
            this.presetName = newName;
        }

        // Returns name of preset
        public string GetPresetName()
        {
            return presetName;
        }

        // Removes item from list
        public void RemoveFromList(string item)
        {
            // Only removes first occurnace of item
            if (this.apps.Remove(item))
            {
                // Item removed
            }
            else
            {
                // Item not in list
            }
        }

        // Adds item to list
        public void AddToList(string item)
        {
            this.apps.Add(item);
        }

        // Overrides existing list with new list
        public void SetList(List<string> list)
        {
            this.apps = list;
        }

        // Returns the list
        public List<string> GetApps()
        {
            return apps;
        }
    }
}
