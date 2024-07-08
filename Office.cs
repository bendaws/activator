using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activator
{
    public partial class Office : Form
    {
        public Office()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customKMS_CheckedChanged(object sender, EventArgs e)
        {
            customKMS_value.Enabled = customKMS.Checked;
        }

        private void homeStu2021Btn_Click(object sender, EventArgs e)
        {
            kms_KEY_VALUE.Text = "FXYTK-NJJ8C-GB6DW-3DYQT-6F7TH";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult output = OfficeInstall.ShowDialog();
            if (output == DialogResult.OK)
            {
                installDir.Text = OfficeInstall.SelectedPath;
            }
        }

        private void proPlus2021Btn_Click(object sender, EventArgs e)
        {
            kms_KEY_VALUE.Text = "FXYTK-NJJ8C-GB6DW-3DYQT-6F7TH";
        }

        private void startActivation_Click(object sender, EventArgs e)
        {
            string ProductKey = kms_KEY_VALUE.Text;
            string InstallDirc = installDir.Text;

            string batFileName = InstallDirc + @"\" + Guid.NewGuid() + ".bat";

            using (StreamWriter batFile = new StreamWriter(batFileName))
            {
                batFile.WriteLine($"cd /d " + InstallDirc);
                batFile.WriteLine($"for /f %x in ('dir /b ..\\root\\Licenses16\\ProPlus2021VL_KMS*.xrm-ms') do cscript ospp.vbs /inslic:\"..\\root\\Licenses16\\%x\"");
                batFile.WriteLine($"cscript ospp.vbs /setprt:1688");
                batFile.WriteLine($"cscript ospp.vbs /unpkey:6F7TH >nul");
                batFile.WriteLine($"cscript ospp.vbs /inpkey:FXYTK-NJJ8C-GB6DW-3DYQT-6F7TH");
                batFile.WriteLine($"cscript ospp.vbs /sethst:107.175.77.7");
                batFile.WriteLine($"cscript ospp.vbs /act");
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + batFileName);
            processStartInfo.UseShellExecute = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;

            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();
            p.WaitForExit();

            File.Delete(batFileName);

            MessageBox.Show(
                    "Activation has completed and you now need to restart your computer. If there was an error, you may have selected the incorrect edition.",
                    "Activation Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            );
        }
    }
}