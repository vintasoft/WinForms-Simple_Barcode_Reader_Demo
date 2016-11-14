using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleBarcodeReaderDemo
{
    static class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
