using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace Layout
{
    public partial class CaptureState : Form
    {
        public CaptureState()
        {
            InitializeComponent();
            Console.WriteLine("test");
            LoadCurrentApplications();
        }

        private void LoadCurrentApplications()
        {
            /*
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine("Name: " + mo["Name"]);
                this.listBox1.Items.Add(mo["Name"]);
            }
            */

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {

                Console.WriteLine("Test1");

                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    Console.WriteLine($"Process: {process.ProcessName}, ID: {process.Id}, Main Module - Name: {process.MainModule.ModuleName}, Main Module - filename: {process.MainModule.FileName}");
                    //this.listBox1.Items.Add(process.MainModule.ModuleName);
                }
            }
        }

        private void CaptureState_Load(object sender, EventArgs e)
        {

        }

        private void CaptureState_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RemoveApplicationButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Remove(this.listBox1.SelectedItem);
        }

        private void AddApplicationsButton_Click(object sender, EventArgs e)
        {

            // Add items to list box in new layout form




            this.Hide();
        }

        public List<string> GetApplications()
        {

            List<string> list = new List<string>();

            foreach (string item in this.listBox1.Items)
            {
                list.Add(item);
            }

            return list;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
