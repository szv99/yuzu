using System;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.Win32;

namespace yuzu
{
    public partial class Priority : MetroSetForm
    {
        public Priority()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey W332 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
            W332.SetValue("Win32PrioritySeparation", "40", RegistryValueKind.DWord);
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            RegistryKey W332 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
            W332.SetValue("Win32PrioritySeparation", "37", RegistryValueKind.DWord);
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            RegistryKey W332 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
            W332.SetValue("Win32PrioritySeparation", "22", RegistryValueKind.DWord);
            MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}