using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimpleBarcodeReaderDemo
{
    /// <summary>
    /// A form that allows to select frame from the multipage image.
    /// </summary>
    public partial class SelectImageFrameForm : Form
    {

        #region Fields

        string _labelText;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectImageFrameForm"/> class.
        /// </summary>
        public SelectImageFrameForm()
        {
            InitializeComponent();
            _labelText = label1.Text;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows the dialog that allows to select frame.
        /// </summary>
        /// <param name="image">Image.</param>
        public void SelectFrame(Image image)
        {
            FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);
            int n = image.GetFrameCount(dimension);
            if (n == 1)
                return;
            if (frameNumber.Value > n)
                frameNumber.Value = 1;
            frameNumber.Maximum = n;
            label1.Text = string.Format(_labelText, n);
            ShowDialog();
            image.SelectActiveFrame(dimension, (int)frameNumber.Value - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        #endregion

    }
}