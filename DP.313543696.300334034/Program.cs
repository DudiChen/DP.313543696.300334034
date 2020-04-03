using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DP._313543696._300334034
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWin());
        }
    }
}
