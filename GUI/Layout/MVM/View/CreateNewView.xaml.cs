using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Layout.Core;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Layout.MVM.ViewModel;
using System.Runtime.InteropServices;



namespace Layout.MVM.View
{
    /// <summary>
    /// Interaction logic for CreateNewView.xaml
    /// </summary>
    public partial class CreateNewView : UserControl
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }

        }
        

        private List<(string, string, WindowRectClass, string)> appsList = new List<(string, string, WindowRectClass, string)>();
        public CreateNewView()
        {
            InitializeComponent();
            DataContext = this;

            var button = new Button();
            
           // display file names in list box, but store file locations seperataly in list (only list should be saved to file)


            
        }
        private void SaveLayoutButton_Click(object sender, RoutedEventArgs e)
        {

            string input = this.LayoutNameInput.Text;

            if ( (input.Trim() == "") || (this.CheckIfLayoutNameExists(input)))
            {
                return;
            }

            if (appsList.Count != 0)
            {
                LayoutPreset newPreset = new LayoutPreset(input, appsList);

                SaveSystem.SavePreset(newPreset);

                // Once layout saved, program should exit create new screen and enter the new layout in the stack panel list

                ((MainWindow)System.Windows.Application.Current.MainWindow).CreateNewLayoutSection(newPreset);

                ((MainWindow)System.Windows.Application.Current.MainWindow).HomeButton.Command.Execute(this);
            }

        }

        private void SelectFilesButton_Click(object sender, RoutedEventArgs e)
        {
            //string fileName = "";

            System.IO.Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select files to be opened";
            openFileDialog1.InitialDirectory = @"C:\";

            if (openFileDialog1.ShowDialog() == true)
            {
                //for (int i = 0; i < openFileDialog1.)
                //fileName = openFileDialog1.FileName;

                foreach (string file in openFileDialog1.FileNames)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                int indx = file.LastIndexOf(@"\");

                                if (indx != -1)
                                {
                                    string fileName = file.Substring(indx+1);

                                    (string, string, WindowRectClass, string) app;

                                    this.ListOfFiles.Items.Add(fileName);

                                    app.Item1 = fileName;
                                    app.Item2 = file;
                                    app.Item3 = null;
                                    app.Item4 = null;

                                    appsList.Add(app);

                                }



                                
                                //this.ListOfFiles.Items.Add(file);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        continue;
                    }
                }
            }
            else
            {
                return;
            }

            //this.listBox1.Items.Add(fileName);


            

        }

        private bool CheckIfLayoutNameExists(string name)
        {
            // Return true if layout name exists
            
            List<LayoutPreset> list = SaveSystem.LoadPresets();

            if (list != null)
            {
                foreach (LayoutPreset layout in list)
                {

                    if (layout.GetPresetName().Equals(name))
                    {
                        return true;
                    }
                }
            }


            return false;
        }

        private void ListOfFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelectApplicationsButton_Click(object sender, RoutedEventArgs e)
        {

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                //Console.WriteLine(mo["Name"]);
            }


        }

        private void RemoveSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            appsList.RemoveAt(this.ListOfFiles.SelectedIndex);
            this.ListOfFiles.Items.Remove(this.ListOfFiles.SelectedItem);

            
        }

        private void CaptureDesktopButton_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            List<string> ignoredApps = new List<string>();

            (string, string, WindowRectClass, string) app;

            ignoredApps.Add("Layout");
            ignoredApps.Add("Application Frame Host");

            foreach (Process process in processes)
            {

                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {

                    string name = process.MainModule.FileVersionInfo.FileDescription;
                    

                    if (!String.IsNullOrWhiteSpace(name))
                    {
                        if (name.Substring(name.Length-4) == ".exe")
                        {
                            name = name.Substring(0, name.Length - 4);
                        }


                        if (!ignoredApps.Contains(name))
                        {
                            this.ListOfFiles.Items.Add(name);

                            IntPtr ptr = process.MainWindowHandle;
                            Rect rect = new Rect();
                            GetWindowRect(ptr, ref rect);

                            

                            WindowRectClass appWindow = new WindowRectClass(rect.Left, rect.Top, rect.Right, rect.Bottom);

                            app.Item1 = name;
                            app.Item2 = process.MainModule.FileVersionInfo.FileName;
                            app.Item3 = appWindow;
                            app.Item4 = process.ProcessName;

                            appsList.Add(app);


                        }


                    }
                   
                }
            }


        }
    }
}
