using System;
using System.Windows.Forms;
using Pytel_WinForm.Properties;

namespace Pytel_WinForm
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(args.Length > 0) { Settings.Default.mediaArg = args[0]; Settings.Default.Save(); }
            Application.Run(new Main(args));
        }
    }
}
