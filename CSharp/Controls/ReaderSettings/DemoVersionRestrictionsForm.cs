using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BarcodeDemo
{
    /// <summary>
    /// A dialog that displays information about restrictions of DEMO version of VintaSoft Barcode .NET SDK.
    /// </summary>
    public partial class DemoVersionRestrictionsForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoVersionRestrictionsForm"/> class.
        /// </summary>
        public DemoVersionRestrictionsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void documentationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("https://www.vintasoft.com/docs/vsbarcode-dotnet/Licensing-Barcode-Evaluation.html");
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void aspNetBarcodeScannerGeneratorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("https://demos.vintasoft.com/AspNetCoreBarcodeAdvancedDemo/");
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

    }
}
