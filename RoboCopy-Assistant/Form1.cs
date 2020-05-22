using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCopy_Assistant
{
    public partial class Form1 : Form
    {

        public String roboArguments = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void srcBrowseButton_Click(object sender, EventArgs e)
        {
            if (srcBrowser.ShowDialog() == DialogResult.OK)
            {
                srcTextBox.Text = srcBrowser.SelectedPath;
            }
        }

        private void destBrowseButton_Click(object sender, EventArgs e)
        {
            if (destBrowser.ShowDialog() == DialogResult.OK)
            {
                destTextBox.Text = destBrowser.SelectedPath;
            }
        }

        private void logBrowseButton_Click(object sender, EventArgs e)
        {
            if (logBrowser.ShowDialog() == DialogResult.OK)
            {
                logTextBox.Text = logBrowser.SelectedPath;
            }
        }

        private void roboStringButton_Click(object sender, EventArgs e)
        {
            roboArguments = "";
            roboArguments += srcTextBox.Text;
            roboArguments += " " + destTextBox.Text;
            if (excludeNTCheckBox.Checked)
            {
                roboArguments += " /XF NTUSER.DAT";
            }
            if (recursiveCheckBox.Checked && !recursiveWithEmptyCheckBox.Checked && !mirrorCheckBox.Checked)
            {
                roboArguments += " /S";
            }
            if (recursiveWithEmptyCheckBox.Checked && !mirrorCheckBox.Checked)
            {
                roboArguments += " /E";
            }
            if (purgeCheckBox.Checked && !mirrorCheckBox.Checked)
            {
                roboArguments += " /PURGE";
            }
            if (mirrorCheckBox.Checked)
            {
                roboArguments += " /MIR";
            }
            if (moveCheckBox.Checked && !mirrorCheckBox.Checked && !purgeCheckBox.Checked)
            {
                roboArguments += " /MOVE";
            }
            if (monCheckBox.Checked)
            {
                roboArguments += " /MON:" + monValTextBox.Text;
            }
            if (motCheckBox.Checked)
            {
                roboArguments += " /MOT:" + motValTextBox.Text;
            }

            if (!logTextBox.Text.Equals("")) {
                if (logAppendCheckBox.Checked)
                {
                    roboArguments += " /LOG+:\"" + logTextBox.Text + "\\robolog.log\"";
                }
                else
                {
                    roboArguments += " /LOG:\"" + logTextBox.Text + "\\robolog.log\"";
                }
            }
            roboString.Text = roboArguments;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            String roboToExecute = "robocopy " + roboArguments;
            String serviceCreateString = "create " + serviceNameTextBox.Text + " binPath=C:\\srvany.exe start=auto";
            String regKeyString = "ADD HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + serviceNameTextBox.Text + "\\parameters /v Application /t REG_SZ /d \"" + roboToExecute + "\"";

            /*
            String path = "svc-and-reg.bat";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(serviceCreateString);
                    sw.WriteLine();
                    sw.WriteLine(regKeyString);
                }
            }
            */
            
            
            
            
            ProcessStartInfo serviceCreate = new ProcessStartInfo("sc",serviceCreateString);
            ProcessStartInfo regEntry = new ProcessStartInfo("REG",regKeyString);
            serviceCreate.UseShellExecute = true;
            serviceCreate.Verb = "runas";
            regEntry.UseShellExecute = true;
            regEntry.Verb = "runas";

            Process.Start(serviceCreate).WaitForExit();
            Process.Start(regEntry);
            
        }
    }
}
