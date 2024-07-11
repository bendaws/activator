using PastebinAPI;
using System.Net;

namespace activator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string needUpdate = new WebClient().DownloadString("https://pastebin.com/raw/4syXnW8w");

            if (needUpdate == null | needUpdate == "")
            {
                MessageBox.Show(
                    "MSActivate could not check for security updates online.",
                    "Security Updates Paused",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );

                ApplicationConfiguration.Initialize();
                Application.Run(new MainWindow());
            } else if (needUpdate == "no")
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainWindow());
            } else
            {
                DialogResult upgradeMsg = MessageBox.Show(
                    "MSActivate has a security update avaliable for your version. If you are running that version, you can skip." +
                    "If not, please download it from MSActivate's GitHub page.",
                    "Security Update Avaliable",
                    MessageBoxButtons.CancelTryContinue,
                    MessageBoxIcon.Exclamation
                );

                if (upgradeMsg == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (upgradeMsg == DialogResult.TryAgain)
                {
                    Application.Exit();
                }
                else if (upgradeMsg == DialogResult.Continue)
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainWindow());
                }
            }
        }
    }
}