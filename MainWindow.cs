using System.ComponentModel;
using System.Diagnostics;

namespace activator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseEdition editionWindow = new ChooseEdition();
            editionWindow.ShowDialog();

            var checkedButton = editionWindow.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            var productKey = "";

            if (checkedButton != null)
            {
                if (checkedButton.Name == "home11")
                {
                    productKey = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (checkedButton.Name == "pro11")
                {
                    productKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (checkedButton.Name == "enterprise11")
                {
                    productKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }

                if (checkedButton.Name == "home10")
                {
                    productKey = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                }
                if (checkedButton.Name == "pro10")
                {
                    productKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                if (checkedButton.Name == "enterprise10")
                {
                    productKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
            }
            else
            {
                MessageBox.Show(
                    "No edition was selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Application.Exit();
            }

            string strCmdLine =
                "/c slmgr /skms kms8.msguides.com" +
                "slmgr /ipk " + productKey +
                "slmgr /ato";

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

            MessageBox.Show(
                    "Activation has completed and you now need to restart your computer. If there was an error, you may have selected the incorrect edition.",
                    "Activation Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            );

            Application.Exit();
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            Advanced newAdv = new Advanced();
            newAdv.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsBtn_Click(object sender, EventArgs e)
        {
            Advanced windows = new Advanced();
            windows.Show();
        }

        private void officeBtn_Click(object sender, EventArgs e)
        {
            Office office = new Office();
            office.Show();
        }
    }
}
