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
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Layout.MVM.ViewModel;
using System.Runtime.InteropServices;

namespace Layout.MVM.View
{
    /// <summary>
    /// Interaction logic for LayoutView.xaml
    /// </summary>
    public partial class LayoutView : UserControl
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


        private string oldLayoutName = "";
        private List<(string, string, WindowRectClass, string)> oldApps = new List<(string, string, WindowRectClass, string)>();
        private List<(string, string, WindowRectClass, string)> newApps = new List<(string, string, WindowRectClass, string)>();

        public LayoutView()
        {
            InitializeComponent();

            // Get current layout info and append to text, buttons and list box
            
            InsertAllValues();


        }

        public void InsertAllValues()
        {
            // Insert values to list box, and input box
            List<LayoutPreset> presets = SaveSystem.LoadPresets();

            string selectedLayout = "";
            /*
            foreach (FrameworkElement element in ((MainWindow)System.Windows.Application.Current.MainWindow).LayoutList.Children)
            {
                // (test.Name);

                if (element is RadioButton)
                

                    if (((RadioButton)element).IsChecked == true)
                    {
                        selectedLayout = ((RadioButton)element).Content.ToString();
                        oldLayoutName = selectedLayout;
                        break;
                    }


                

            }
            */
            this.LayoutNameInput.Text = selectedLayout;

            List<(string, string, WindowRectClass, string)> apps = new List<(string, string, WindowRectClass, string)>();

            foreach (LayoutPreset layout in presets)
            {
                if (layout.GetPresetName().Equals(selectedLayout))
                {
                    apps = layout.GetApps();
                    oldApps = apps;
                    newApps = apps;

                    apps.ForEach(app => this.ListOfFiles.Items.Add(app.Item1));

                    /*
                    foreach ((string, string, WindowRectClass, string) app in apps)
                    {
                        this.ListOfFiles.Items.Add(app.Item1);
                    }
                    */
                    break;
                }
            }







        }

        private void SelectFilesButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select files to be opened";
            openFileDialog1.InitialDirectory = @"C:\";

            if (openFileDialog1.ShowDialog() == true)
            {
                //for (int i = 0; i < openFileDialog1.)

                openFileDialog1.FileNames.ToList().ForEach(file =>
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
                                    string fileName = file.Substring(indx + 1);

                                    (string, string, WindowRectClass, string) app = (null, null, null, null);

                                    this.ListOfFiles.Items.Add(fileName);

                                    app.Item1 = fileName;
                                    app.Item2 = file;

                                    newApps.Add(app);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                });

            }
            else
            
                return;
            
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
                        if (name.Substring(name.Length - 4) == ".exe")
                        
                            name = name.Substring(0, name.Length - 4);
                        


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

                            newApps.Add(app);


                        }


                    }

                }
            }
        }

        private void RemoveSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            newApps.RemoveAt(this.ListOfFiles.SelectedIndex);
            this.ListOfFiles.Items.Remove(this.ListOfFiles.SelectedItem);
        }

        private void SaveLayoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Perform similar functions to create new save layout, except should append to file, not write to file

            string input = this.LayoutNameInput.Text;

            

            if ((input.Trim() == "") || (this.CheckIfLayoutNameExists(input, true)))
               
                return;
            

            if (newApps.Count != 0)
            {
                SaveSystem.SavePreset(new LayoutPreset(input, newApps), false, new LayoutPreset(oldLayoutName, oldApps));

                // Once layout saved, program should exit create new screen and enter the new layout in the stack panel list

                //((MainWindow)System.Windows.Application.Current.MainWindow).UpdateExistingLayout(input, oldLayoutName);

                //((MainWindow)System.Windows.Application.Current.MainWindow).HomeButton.Command.Execute(this);

                //((MainWindow)System.Windows.Application.Current.MainWindow).AssignAllButtonCommands();
            }

        }

        private bool CheckIfLayoutNameExists(string name, bool overwrite)
        {
            // Return true if layout name exists

            List<LayoutPreset> list = SaveSystem.LoadPresets();
            // (list.Count);

            int selectedPosition = -1;

            if (overwrite)
            {
                selectedPosition = 0;
                /*
                foreach (FrameworkElement element in ((MainWindow)System.Windows.Application.Current.MainWindow).LayoutList.Children)
                {
                    // (test.Name);

                    if (element is RadioButton)
                    

                        if (((RadioButton)element).IsChecked == true)
                        

                            break;

                        

                    

                    selectedPosition++;

                }
                */
            }





            int currentPosition = 0;

            foreach (LayoutPreset layout in list)
            {

                // (layout.GetPresetName());

                if (layout.GetPresetName().Equals(name))
                {

                    if (currentPosition.Equals(selectedPosition))
                    
                        return false;
                    

                    return true;
                }

                currentPosition++;
            }

            return false;
        }

        private void ListOfFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeleteLayoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Insert values to list box, and input box
            List<LayoutPreset> presets = SaveSystem.LoadPresets();
            /*
            foreach (FrameworkElement element in ((MainWindow)System.Windows.Application.Current.MainWindow).LayoutList.Children)
            {
                // (test.Name);

                if (element is RadioButton)
                {

                    if (((RadioButton)element).IsChecked == true)
                    {
                        // Remove button from list
                        ((MainWindow)System.Windows.Application.Current.MainWindow).LayoutList.Children.Remove(element);

                        presets.ForEach(preset =>
                        {
                            if (preset.GetPresetName().Equals(((RadioButton)element).Content))
                          
                                SaveSystem.DeletePreset(preset);
                        });

                        ((MainWindow)System.Windows.Application.Current.MainWindow).EditLayoutButton.Command.Execute(this);

                        break;
                    }


                }

            }
            */

        }

        private void SaveLayoutAsButton_Click(object sender, RoutedEventArgs e)
        {
            string input = this.LayoutNameInput.Text;

            if ((input.Trim() == "") || (this.CheckIfLayoutNameExists(input, false)))
            
                return;
            

            if (newApps.Count != 0)
            {
                LayoutPreset newPreset = new LayoutPreset(input, newApps);

                SaveSystem.SavePreset(newPreset);

                // Once layout saved, program should exit create new screen and enter the new layout in the stack panel list

                //((MainWindow)System.Windows.Application.Current.MainWindow).CreateNewLayoutSection(newPreset);

                //((MainWindow)System.Windows.Application.Current.MainWindow).HomeButton.Command.Execute(this);

                //((MainWindow)System.Windows.Application.Current.MainWindow).AssignAllButtonCommands();


            }

        }
    }
}
