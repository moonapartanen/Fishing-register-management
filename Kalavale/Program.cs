using System;
using System.Windows.Forms;
using Kalavale.Forms;
using System.Threading;

namespace Kalavale
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(MainForm_UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.Run(new MainForm());
        }

        private static void MainForm_UIThreadException(object sender, ThreadExceptionEventArgs t) {
            DialogResult result = DialogResult.Cancel;
            try {
                result = MessageBox.Show(t.Exception.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch {
                Application.Exit();
            }

            if (result == DialogResult.OK)
                Application.Exit();
        }
    }
}
