using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Layout
{
 
    public partial class HomePage : Form
    {

        //private List<LayoutPreset> apps = SaveSystem.LoadPresets();

        public HomePage()
        {
            InitializeComponent();

            this.selectLayoutBox.Items.Insert(0, " -- Select Item -- ");
            this.selectLayoutBox.SelectedIndex = 0;

        }

        public void LoadLayoutList()
        {
            this.selectLayoutBox.Items.Clear();
            List<LayoutPreset> apps = SaveSystem.LoadPresets();

            if (apps != null)
            {
                for (int i = 0; i < apps.Count; i++)
                {
                    this.selectLayoutBox.Items.Add(apps[i].GetPresetName());
                }
            }

            this.selectLayoutBox.Items.Add("Create New Layout");
        }

        private void CleanSpace_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    //process.Kill();
                    Console.WriteLine($"Killed process: {process.MainWindowTitle}");
                }
            }
        }

        private void SelectLayoutButton_Click(object sender, EventArgs e)
        {

            string selectedOption;

            if (this.selectLayoutBox.SelectedItem != null)
            {
                selectedOption = this.selectLayoutBox.SelectedItem.ToString();
            }
            else
            {
                Console.WriteLine("Invalid Option.");
                return;
            }
            

            if (selectedOption == "Create New Layout")
            {
                CreateNewLayout();
            }
            else
            {
                List<LayoutPreset> apps = SaveSystem.LoadPresets();

                int count = apps.Count();

                for (int i = 0; i < count; i++)
                {
                    if (selectedOption == apps[i].GetPresetName())
                    {
                        OpenApplications(i);
                        break;
                    }

                }
            }

        }

        private void CreateNewLayout()
        {
            // Open new layout form
            
            NewLayout newLayout = new NewLayout();
            newLayout.Show();

        }

        private void OpenApplications(int itemIndex)
        {
            List<LayoutPreset> apps = SaveSystem.LoadPresets();

            LayoutPreset preset = apps[itemIndex];

            for (int i = 0; i < preset.GetApps().Count; i++)
            {
                Process.Start(@"" + preset.GetApps()[i]);
            }

        }

        private void EditLayoutButton_Click(object sender, EventArgs e)
        {
            List<LayoutPreset> apps = SaveSystem.LoadPresets();

            EditLayout editLayout = new EditLayout(apps[this.selectLayoutBox.SelectedIndex]);
            editLayout.Show();
        }

        private void SelectLayoutBox_DropDown(object sender, EventArgs e)
        {
            //Console.WriteLine("Opened");
            LoadLayoutList();
        }

        private void SelectLayoutBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Console.WriteLine("testing");


            if (this.selectLayoutBox.Text == "")
            {
                this.selectLayoutBox.Text = " -- Select Item -- ";
            }


            if (this.selectLayoutBox.SelectedItem.ToString() == "Create New Layout")
            {
                this.editLayoutButton.Enabled = false;
            }
            else
            {
                this.editLayoutButton.Enabled = true;
            }
        }

        private void SelectLayoutBox_TextChanged(object sender, EventArgs e)
        {
            if (this.selectLayoutBox.Text == "")
            {

            }
        }
    }
}
