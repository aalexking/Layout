using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Layout.Core
{

    public class LayoutPreset
    {

        public string presetName { get; set; }  // Name of preset

        public List<(string, string, WindowRectClass, string)> apps { get; set; } // List stores applications connected to preset

        /*
        public List<string> fileNames = new List<string>();
        public List<string> fileLocations = new List<string>();
        public List<int[]> windowRects = new List<int[]>();
        */
        public LayoutPreset(string name, List<(string, string, WindowRectClass, string)> list)
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
        public void RemoveFromList((string, string, WindowRectClass, string) item)
        {

        }

        // Adds item to list
        public void AddToList((string, string, WindowRectClass, string) item)
        {
            this.apps.Add(item);
        }

        // Overrides existing list with new list
        public void SetList(List<(string, string, WindowRectClass, string)> list)
        {
            this.apps = list;
        }

        // Returns the list
        public List<(string, string, WindowRectClass, string)> GetApps()
        {
            return apps;
        }
    }
}
