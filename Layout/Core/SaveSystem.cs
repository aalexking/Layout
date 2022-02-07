using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Layout.Core
{
    public static class SaveSystem
    {

        //private var filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);


        public static void SavePreset(LayoutPreset preset, bool append = true, LayoutPreset oldPreset = null)
        {

            var filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var completePath = filePath + @"\Layout";

            var file = completePath + @"\presets.json";

            if (!File.Exists(file))
            
                System.IO.Directory.CreateDirectory(completePath);

            

            string json = JsonConvert.SerializeObject(preset);

            if (append)
            {

                TextWriter tsw = new StreamWriter(file, true);

                //File.AppendAllText(filePath, json);
                tsw.WriteLine(json);
                tsw.Close();

            }
            else
            {
                int lineNumber = 0;
                string[] fileContents = File.ReadAllLines(file);

                while (fileContents[lineNumber] != null)
                {

                    LayoutPreset currentPreset = JsonConvert.DeserializeObject<LayoutPreset>(fileContents[lineNumber]);
                    //LayoutPreset currentPreset = null;

                    if (currentPreset.presetName == oldPreset.presetName)
                    {

                        fileContents[lineNumber] = json;
                        File.WriteAllLines(file, fileContents);
                        break;
                    }

                    lineNumber++;
                }
            }


        }

        
        // Returns a list of all layout presets stored in file
        public static List<LayoutPreset> LoadPresets()
        {
            var filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var completePath = filePath + @"\Layout";

            var file = completePath + @"\presets.json";

            if (File.Exists(file))
            {

                File.WriteAllLines(file, File.ReadAllLines(file).Where(l => !string.IsNullOrWhiteSpace(l)));


                //string l = File.Read



                List<LayoutPreset> list = new List<LayoutPreset>();
                StreamReader jFile = new StreamReader(file);

                string line;

                while ((line = jFile.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (line != "")
                    
                        list.Add(JsonConvert.DeserializeObject<LayoutPreset>(line));

                 

                }

                jFile.Close();
                return list;
                
            }
            else
            
                return null;
            
            
        }
        
        public static void DeletePreset(LayoutPreset preset)
        {
            var filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var completePath = filePath + @"\Layout";

            var file = completePath + @"\presets.json";

            int lineNumber = 0;
            string[] fileContents = File.ReadAllLines(file);

            while (fileContents[lineNumber] != null)
            {

                LayoutPreset currentPreset = JsonConvert.DeserializeObject<LayoutPreset>(fileContents[lineNumber]);
                //LayoutPreset currentPreset = null;

                if (currentPreset.presetName == preset.presetName)
                {

                    fileContents[lineNumber] = null;
                    File.WriteAllLines(file, fileContents);
                    break;
                }

                lineNumber++;
            }
        }

        private static void SanitiseFile(string file)
        {

            string line;

            int lineNumber = 0;
            string[] fileContents = File.ReadAllLines(file);

            while ((line = fileContents[lineNumber]) != null)
            {

                //LayoutPreset currentPreset = JsonConvert.DeserializeObject<LayoutPreset>(fileContents[lineNumber]);

                line = line.Trim();

                if (line == "")
                {

                    fileContents[lineNumber] = "";


                    File.WriteAllLines(file, fileContents);
                    break;
                }

                lineNumber++;
            }

        }

        public static void RemovePreset()
        {

        }



    }
}
