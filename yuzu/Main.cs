using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.Win32;

namespace yuzuu
{
    public partial class Main : MetroSetForm
    {
        public Main()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string TelemetryCommand =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/x3hL37Gi'))";
            var Telemetry = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Telemetry == DialogResult.OK)
            {
                Process tlm11 = new Process();
                tlm11.StartInfo.FileName = "cmd.exe";
                tlm11.StartInfo.Arguments = "/C " + TelemetryCommand;
                tlm11.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                tlm11.StartInfo.CreateNoWindow = true;
                tlm11.Start();
                tlm11.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            {

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MouseFix =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/UcVsANiZ'))";
            var MouseFixx = MessageBox.Show("This might change your mouse settings to 6/11.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (MouseFixx == DialogResult.OK)
            {
                Process ms1 = new Process();
                ms1.StartInfo.FileName = "cmd.exe";
                ms1.StartInfo.Arguments = "/C " + MouseFix;
                ms1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ms1.StartInfo.CreateNoWindow = true;
                ms1.Start();
                ms1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string telemetria =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/JY4wUZW7'))";
            var telemetriabox = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (telemetriabox == DialogResult.OK)
            {
                Process tlm1 = new Process();
                tlm1.StartInfo.FileName = "cmd.exe";
                tlm1.StartInfo.Arguments = "/C " + telemetria;
                tlm1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                tlm1.StartInfo.CreateNoWindow = true;
                tlm1.Start();
                tlm1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string network =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/UCN4CRKk'))";
            var networkbox = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (networkbox == DialogResult.OK)
            {
                Process net1 = new Process();
                net1.StartInfo.FileName = "cmd.exe";
                net1.StartInfo.Arguments = "/C " + network;
                net1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                net1.StartInfo.CreateNoWindow = true;
                net1.Start();
                net1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string visual =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/Ui9Fjfja'))";
            var visualbox = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (visualbox == DialogResult.OK)
            {
                Process vis1 = new Process();
                vis1.StartInfo.FileName = "cmd.exe";
                vis1.StartInfo.Arguments = "/C " + visual;
                vis1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                vis1.StartInfo.CreateNoWindow = true;
                vis1.Start();
                vis1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string amd =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/BpSridSG'))";
            var visualbox = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (visualbox == DialogResult.OK)
            {
                Process nv1 = new Process();
                nv1.StartInfo.FileName = "cmd.exe";
                nv1.StartInfo.Arguments = "/C " + amd;
                nv1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                nv1.StartInfo.CreateNoWindow = true;
                nv1.Start();
                nv1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string nv =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/qLW16FD3'))";
            var visualbox = MessageBox.Show("Please create a Restore Point before Processing.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (visualbox == DialogResult.OK)
            {
                Process amd1 = new Process();
                amd1.StartInfo.FileName = "cmd.exe";
                amd1.StartInfo.Arguments = "/C " + nv;
                amd1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                amd1.StartInfo.CreateNoWindow = true;
                amd1.Start();
                amd1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string msi =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/cr4GnwTM'))";
            var visualbox = MessageBox.Show("This might destroy your OS. Please create a Restore Point.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (visualbox == DialogResult.OK)
            {
                Process msi1 = new Process();
                msi1.StartInfo.FileName = "cmd.exe";
                msi1.StartInfo.Arguments = "/C " + msi;
                msi1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                msi1.StartInfo.CreateNoWindow = true;
                msi1.Start();
                msi1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string restore =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/WPz9CePR'))";
            var visualbox = MessageBox.Show("Click OK To process and wait until CMD window closes or Done pops out", "Information", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (visualbox == DialogResult.OK)
            {
                Process restore1 = new Process();
                restore1.StartInfo.FileName = "cmd.exe";
                restore1.StartInfo.Arguments = restore;
                restore1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                restore1.StartInfo.CreateNoWindow = true;
                restore1.Start();
                restore1.WaitForExit();
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string restore =
                "PowerShell -nop -c iex ((New-Object System.Net.WebClient).DownloadString('https://pastebin.com/raw/ZrKk5mgz'))";
            var visualbox = MessageBox.Show("Please create a Restore Point before Processing.", "Information",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (visualbox == DialogResult.OK)
            {
                Process process = Process.Start("cmd.exe", "/q /c" + restore);
                while (!process.HasExited && process.Responding)
                {
                    Thread.Sleep(100);

                }

                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistryKey System =
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
            if (MessageBox.Show("Click OK To process...", "Information", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button29_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "This Tweak is experimental. It will remove all Windows Apps, and many needed services.",
                "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Process restore1 = new Process();
                restore1.StartInfo.FileName = "cmd.exe";
                restore1.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\SystemApps" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SystemApps" +
                                               "\" " + "/GRANT Administrators:(F)";
                restore1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                restore1.StartInfo.CreateNoWindow = true;
                restore1.Start();
                restore1.WaitForExit();

                Process takeown2 = new Process();
                takeown2.StartInfo.FileName = "cmd.exe";
                takeown2.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"ProgramData\Packages" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) + @"ProgramData\Packages" +
                                               "\" " + "/GRANT Administrators:(F)";
                takeown2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown2.StartInfo.CreateNoWindow = true;
                takeown2.Start();
                takeown2.WaitForExit();

                Process takeown3 = new Process();
                takeown3.StartInfo.FileName = "cmd.exe";
                takeown3.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" +
                                               Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" +
                                               "\" " + "/A & ICACLS " + "\"" +
                                               Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" +
                                               "\" " + "/GRANT Administrators:(F)";
                takeown3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown3.StartInfo.CreateNoWindow = true;
                takeown3.Start();
                takeown3.WaitForExit();

                Process takeown4 = new Process();
                takeown4.StartInfo.FileName = "cmd.exe";
                takeown4.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Program Files\WindowsApps" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Program Files\WindowsApps" + "\" " + "/GRANT Administrators:(F)";
                takeown4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown4.StartInfo.CreateNoWindow = true;
                takeown4.Start();
                takeown4.WaitForExit();

                Process takeown5 = new Process();
                takeown5.StartInfo.FileName = "cmd.exe";
                takeown5.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Program Files (x86)\Microsoft" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Program Files (x86)\Microsoft" + "\" " + "/GRANT Administrators:(F)";
                takeown5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown5.StartInfo.CreateNoWindow = true;
                takeown5.Start();
                takeown5.WaitForExit();

                Process takeown6 = new Process();
                takeown6.StartInfo.FileName = "cmd.exe";
                takeown6.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" +
                                               Environment.GetEnvironmentVariable("LocalAppData") +
                                               @"\Microsoft\WindowsApps" + "\" " + "/A & ICACLS " + "\"" +
                                               Environment.GetEnvironmentVariable("LocalAppData") +
                                               @"\Microsoft\WindowsApps" + "\" " + "/GRANT Administrators:(F)";
                takeown6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown6.StartInfo.CreateNoWindow = true;
                takeown6.Start();
                takeown6.WaitForExit();

                Process takeown7 = new Process();
                takeown7.StartInfo.FileName = "cmd.exe";
                takeown7.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) + @"Windows" + "\" " +
                                               "/GRANT Administrators:(F)";
                takeown7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown7.StartInfo.CreateNoWindow = true;
                takeown7.Start();
                takeown7.WaitForExit();

                Process takeown8 = new Process();
                takeown8.StartInfo.FileName = "cmd.exe";
                takeown8.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\System32" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32" +
                                               "\" " + "/GRANT Administrators:(F)";
                takeown8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown8.StartInfo.CreateNoWindow = true;
                takeown8.Start();
                takeown8.WaitForExit();

                Process takeown9 = new Process();
                takeown9.StartInfo.FileName = "cmd.exe";
                takeown9.StartInfo.Arguments = "/C TAKEOWN /F " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\SysWOW64" + "\" " + "/A & ICACLS " + "\"" +
                                               Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64" +
                                               "\" " + "/GRANT Administrators:(F)";
                takeown9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                takeown9.StartInfo.CreateNoWindow = true;
                takeown9.Start();
                takeown9.WaitForExit();

                DebloatTimer_Tick(sender, e);
                DebloatTimer.Enabled = true;

                try
                {
                    Process uninstallonedrive = new Process();
                    uninstallonedrive.StartInfo.FileName = @"C:\Windows\SysWOW64\OneDriveSetup.exe";
                    uninstallonedrive.StartInfo.Arguments = "/uninstall";
                    uninstallonedrive.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    uninstallonedrive.StartInfo.CreateNoWindow = true;
                    uninstallonedrive.Start();
                    uninstallonedrive.WaitForExit();
                }
                catch
                {
                }

                Process helppane = new Process();
                helppane.StartInfo.FileName = "cmd.exe";
                helppane.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\helpPane.exe" + "\"";
                helppane.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                helppane.StartInfo.CreateNoWindow = true;
                helppane.Start();
                helppane.WaitForExit();

                Process backgroundtaskhost1 = new Process();
                backgroundtaskhost1.StartInfo.FileName = "cmd.exe";
                backgroundtaskhost1.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                          Path.GetPathRoot(Environment.SystemDirectory) +
                                                          @"Windows\System32\backgroundtaskhost.exe" + "\"";
                backgroundtaskhost1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                backgroundtaskhost1.StartInfo.CreateNoWindow = true;
                backgroundtaskhost1.Start();
                backgroundtaskhost1.WaitForExit();

                Process EaseOfAccessDialog1 = new Process();
                EaseOfAccessDialog1.StartInfo.FileName = "cmd.exe";
                EaseOfAccessDialog1.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                          Path.GetPathRoot(Environment.SystemDirectory) +
                                                          @"Windows\System32\EaseOfAccessDialog.exe" + "\"";
                EaseOfAccessDialog1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                EaseOfAccessDialog1.StartInfo.CreateNoWindow = true;
                EaseOfAccessDialog1.Start();
                EaseOfAccessDialog1.WaitForExit();

                Process RuntimeBroker = new Process();
                RuntimeBroker.StartInfo.FileName = "cmd.exe";
                RuntimeBroker.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                    Path.GetPathRoot(Environment.SystemDirectory) +
                                                    @"Windows\System32\RuntimeBroker.exe" + "\"";
                RuntimeBroker.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                RuntimeBroker.StartInfo.CreateNoWindow = true;
                RuntimeBroker.Start();
                RuntimeBroker.WaitForExit();

                Process WSClient1 = new Process();
                WSClient1.StartInfo.FileName = "cmd.exe";
                WSClient1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                @"Windows\System32\WSClient.dll" + "\"";
                WSClient1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSClient1.StartInfo.CreateNoWindow = true;
                WSClient1.Start();
                WSClient1.WaitForExit();

                Process WSCollect = new Process();
                WSCollect.StartInfo.FileName = "cmd.exe";
                WSCollect.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                @"Windows\System32\WSCollect.exe" + "\"";
                WSCollect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSCollect.StartInfo.CreateNoWindow = true;
                WSCollect.Start();
                WSCollect.WaitForExit();

                Process gamebarpresencewriter1 = new Process();
                gamebarpresencewriter1.StartInfo.FileName = "cmd.exe";
                gamebarpresencewriter1.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                             Path.GetPathRoot(Environment.SystemDirectory) +
                                                             @"Windows\System32\gamebarpresencewriter.exe" + "\"";
                gamebarpresencewriter1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamebarpresencewriter1.StartInfo.CreateNoWindow = true;
                gamebarpresencewriter1.Start();
                gamebarpresencewriter1.WaitForExit();

                Process gamepanel1 = new Process();
                gamepanel1.StartInfo.FileName = "cmd.exe";
                gamepanel1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                 @"Windows\System32\gamepanel.exe" + "\"";
                gamepanel1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamepanel1.StartInfo.CreateNoWindow = true;
                gamepanel1.Start();
                gamepanel1.WaitForExit();

                Process magnify1 = new Process();
                magnify1.StartInfo.FileName = "cmd.exe";
                magnify1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\System32\magnify.exe" + "\"";
                magnify1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                magnify1.StartInfo.CreateNoWindow = true;
                magnify1.Start();
                magnify1.WaitForExit();

                Process mblctr = new Process();
                mblctr.StartInfo.FileName = "cmd.exe";
                mblctr.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                             @"Windows\System32\mblctr.exe" + "\"";
                mblctr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mblctr.StartInfo.CreateNoWindow = true;
                mblctr.Start();
                mblctr.WaitForExit();

                Process sdiagnhost = new Process();
                sdiagnhost.StartInfo.FileName = "cmd.exe";
                sdiagnhost.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                 @"Windows\System32\sdiagnhost.exe" + "\"";
                sdiagnhost.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                sdiagnhost.StartInfo.CreateNoWindow = true;
                sdiagnhost.Start();
                sdiagnhost.WaitForExit();

                Process mobsync1 = new Process();
                mobsync1.StartInfo.FileName = "cmd.exe";
                mobsync1.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\System32\mobsync.exe" + "\"";
                mobsync1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mobsync1.StartInfo.CreateNoWindow = true;
                mobsync1.Start();
                mobsync1.WaitForExit();

                Process msdt = new Process();
                msdt.StartInfo.FileName = "cmd.exe";
                msdt.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                           @"Windows\System32\msdt.exe" + "\"";
                msdt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                msdt.StartInfo.CreateNoWindow = true;
                msdt.Start();
                msdt.WaitForExit();

                Process narrator = new Process();
                narrator.StartInfo.FileName = "cmd.exe";
                narrator.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\System32\narrator.exe" + "\"";
                narrator.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                narrator.StartInfo.CreateNoWindow = true;
                narrator.Start();
                narrator.WaitForExit();

                Process osk = new Process();
                osk.StartInfo.FileName = "cmd.exe";
                osk.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                          @"Windows\System32\osk.exe" + "\"";
                osk.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                osk.StartInfo.CreateNoWindow = true;
                osk.Start();
                osk.WaitForExit();

                Process smartscreen = new Process();
                smartscreen.StartInfo.FileName = "cmd.exe";
                smartscreen.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                  @"Windows\System32\smartscreen.exe" + "\"";
                smartscreen.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                smartscreen.StartInfo.CreateNoWindow = true;
                smartscreen.Start();
                smartscreen.WaitForExit();

                Process backgroundtaskhost2 = new Process();
                backgroundtaskhost2.StartInfo.FileName = "cmd.exe";
                backgroundtaskhost2.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                          Path.GetPathRoot(Environment.SystemDirectory) +
                                                          @"Windows\SysWOW64\backgroundtaskhost.exe" + "\"";
                backgroundtaskhost2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                backgroundtaskhost2.StartInfo.CreateNoWindow = true;
                backgroundtaskhost2.Start();
                backgroundtaskhost2.WaitForExit();

                Process EaseOfAccessDialog2 = new Process();
                EaseOfAccessDialog2.StartInfo.FileName = "cmd.exe";
                EaseOfAccessDialog2.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                          Path.GetPathRoot(Environment.SystemDirectory) +
                                                          @"Windows\SysWOW64\EaseOfAccessDialog.exe" + "\"";
                EaseOfAccessDialog2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                EaseOfAccessDialog2.StartInfo.CreateNoWindow = true;
                EaseOfAccessDialog2.Start();
                EaseOfAccessDialog2.WaitForExit();

                Process WSClient2 = new Process();
                WSClient2.StartInfo.FileName = "cmd.exe";
                WSClient2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                @"Windows\SysWOW64\WSClient.dll" + "\"";
                WSClient2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WSClient2.StartInfo.CreateNoWindow = true;
                WSClient2.Start();
                WSClient2.WaitForExit();

                Process gamebarpresencewriter2 = new Process();
                gamebarpresencewriter2.StartInfo.FileName = "cmd.exe";
                gamebarpresencewriter2.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                             Path.GetPathRoot(Environment.SystemDirectory) +
                                                             @"Windows\SysWOW64\gamebarpresencewriter.exe" + "\"";
                gamebarpresencewriter2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamebarpresencewriter2.StartInfo.CreateNoWindow = true;
                gamebarpresencewriter2.Start();
                gamebarpresencewriter2.WaitForExit();

                Process gamepanel2 = new Process();
                gamepanel2.StartInfo.FileName = "cmd.exe";
                gamepanel2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                 @"Windows\SysWOW64\gamepanel.exe" + "\"";
                gamepanel2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                gamepanel2.StartInfo.CreateNoWindow = true;
                gamepanel2.Start();
                gamepanel2.WaitForExit();

                Process magnify2 = new Process();
                magnify2.StartInfo.FileName = "cmd.exe";
                magnify2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\SysWOW64\magnify.exe" + "\"";
                magnify2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                magnify2.StartInfo.CreateNoWindow = true;
                magnify2.Start();
                magnify2.WaitForExit();

                Process mobsync2 = new Process();
                mobsync2.StartInfo.FileName = "cmd.exe";
                mobsync2.StartInfo.Arguments = @"/C DEL /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                               @"Windows\SysWOW64\mobsync.exe" + "\"";
                mobsync2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mobsync2.StartInfo.CreateNoWindow = true;
                mobsync2.Start();
                mobsync2.WaitForExit();

                Process flashPlayerCPLApp = new Process();
                flashPlayerCPLApp.StartInfo.FileName = "cmd.exe";
                flashPlayerCPLApp.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                        Path.GetPathRoot(Environment.SystemDirectory) +
                                                        @"Windows\SysWOW64\flashPlayerCPLApp.cpl" + "\"";
                flashPlayerCPLApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flashPlayerCPLApp.StartInfo.CreateNoWindow = true;
                flashPlayerCPLApp.Start();
                flashPlayerCPLApp.WaitForExit();

                Process flashPlayerApp = new Process();
                flashPlayerApp.StartInfo.FileName = "cmd.exe";
                flashPlayerApp.StartInfo.Arguments = @"/C DEL /Q " + "\"" +
                                                     Path.GetPathRoot(Environment.SystemDirectory) +
                                                     @"Windows\SysWOW64\flashPlayerApp.exe" + "\"";
                flashPlayerApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flashPlayerApp.StartInfo.CreateNoWindow = true;
                flashPlayerApp.Start();
                flashPlayerApp.WaitForExit();

                Process SystemApps = new Process();
                SystemApps.StartInfo.FileName = "cmd.exe";
                SystemApps.StartInfo.Arguments = @"/C RD /S /Q " + "\"" +
                                                 Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SystemApps" +
                                                 "\"";
                SystemApps.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SystemApps.StartInfo.CreateNoWindow = true;
                SystemApps.Start();
                SystemApps.WaitForExit();

                Process Packages1 = new Process();
                Packages1.StartInfo.FileName = "cmd.exe";
                Packages1.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                @"ProgramData\Packages" + "\"";
                Packages1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Packages1.StartInfo.CreateNoWindow = true;
                Packages1.Start();
                Packages1.WaitForExit();

                Process Packages2 = new Process();
                Packages2.StartInfo.FileName = "cmd.exe";
                Packages2.StartInfo.Arguments = @"/C RD /S /Q " + "\"" +
                                                Environment.GetEnvironmentVariable("LocalAppData") + @"\Packages" +
                                                "\"";
                Packages2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Packages2.StartInfo.CreateNoWindow = true;
                Packages2.Start();
                Packages2.WaitForExit();

                Process WindowsApps1 = new Process();
                WindowsApps1.StartInfo.FileName = "cmd.exe";
                WindowsApps1.StartInfo.Arguments = @"/C RD /S /Q " + "\"" +
                                                   Path.GetPathRoot(Environment.SystemDirectory) +
                                                   @"Program Files\WindowsApps" + "\"";
                WindowsApps1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WindowsApps1.StartInfo.CreateNoWindow = true;
                WindowsApps1.Start();
                WindowsApps1.WaitForExit();

                Process Microsoft = new Process();
                Microsoft.StartInfo.FileName = "cmd.exe";
                Microsoft.StartInfo.Arguments = @"/C RD /S /Q " + "\"" + Path.GetPathRoot(Environment.SystemDirectory) +
                                                @"Program Files (x86)\Microsoft" + "\"";
                Microsoft.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Microsoft.StartInfo.CreateNoWindow = true;
                Microsoft.Start();
                Microsoft.WaitForExit();

            }
        }

        private void DebloatTimer_Tick(object sender, EventArgs e)
        {
            List<string> x = new List<string>(new string[]
            {
                "OneDrive",
                "TextInputHost",
                "SkypeApp",
                "SkypeBackgroundHost",
                "Spotify",
                "msedge",
                "PeopleApp",
                "smartscreen",
                "HelpPane",
                "backgroundTaskHost",
                "EaseOfAccessDialog",
                "RuntimeBroker",
                "WSCollect",
                "GameBarPresenceWriter",
                "GamePanel",
                "Magnify",
                "mblctr",
                "sdiagnhost",
                "mobsync",
                "msdt",
                "Narrator",
                "osk",
                "flashPlayerApp"
            });

            foreach (Process p in Process.GetProcesses())
            {
                if (x.Contains(p.ProcessName.ToUpper()))
                {
                    p.Kill();
                }
            }
        }

        void KillApp()
        {
            this.Close();
            Application.Exit();
        }


        private void button25_Click(object sender, EventArgs e)
        {
            yuzu.Services aa = new yuzu.Services();
            aa.Show();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            yuzu.Priority bb = new yuzu.Priority();
            bb.Show();
        }

        private void metroSetSetToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}


