using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activator
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            customKMS_value.Enabled = customKMS.Checked;
        }

        private void startActivation_Click(object sender, EventArgs e)
        {
            var productKey = kms_KEY_VALUE.Text;

            string strCmdLine =
                "/c slmgr /skms kms8.msguides.com" +
                "slmgr /ipk " + productKey +
                "slmgr /ato";

            if (fullActivation.Checked)
            {

                Process SetServer = new Process();
                SetServer.StartInfo.FileName = "CMD.exe";
                SetServer.StartInfo.Arguments = "/c slmgr /skms kms8.msguides.com";
                SetServer.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SetServer.Start();
                SetServer.WaitForExit();

                Process SetKey = new Process();
                SetKey.StartInfo.FileName = "CMD.exe";
                SetKey.StartInfo.Arguments = "/c slmgr /ipk " + productKey;
                SetKey.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SetKey.Start();
                SetKey.WaitForExit();

                Process Activate = new Process();
                Activate.StartInfo.FileName = "CMD.exe";
                Activate.StartInfo.Arguments = "/c slmgr /ato";
                Activate.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Activate.Start();
                Activate.WaitForExit();
            }

            if (limitedActivation.Checked)
            {

                Process SetServer = new Process();
                SetServer.StartInfo.FileName = "CMD.exe";
                SetServer.StartInfo.Arguments = "/c slmgr /skms kms8.msguides.com";
                SetServer.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SetServer.Start();
                SetServer.WaitForExit();

                Process SetKey = new Process();
                SetKey.StartInfo.FileName = "CMD.exe";
                SetKey.StartInfo.Arguments = "/c slmgr /ipk " + productKey;
                SetKey.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                SetKey.Start();
                SetKey.WaitForExit();
            }

            MessageBox.Show(
                    "Activation has completed and you now need to restart your computer. If there was an error, you may have selected the incorrect edition.",
                    "Activation Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            );

            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            kms_KEY_VALUE.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
        }

        private void ProBtn_Click(object sender, EventArgs e)
        {
            kms_KEY_VALUE.Text = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
        }

        private void EnterpriseBtn_Click(object sender, EventArgs e)
        {
            kms_KEY_VALUE.Text = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
        }

        private void fullActivation_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
