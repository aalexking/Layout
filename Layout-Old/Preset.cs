using System;

namespace Layout
{
    public class Preset
    {

        private string presetName;




	    public Preset(string name)
	    {
            this.presetName = name;
	    }



        public void setPresetName(string newName)
        {
            this.presetName = newName;
        }

        public string getPresetName()
        {
            return presetName;
        }


    }
}


