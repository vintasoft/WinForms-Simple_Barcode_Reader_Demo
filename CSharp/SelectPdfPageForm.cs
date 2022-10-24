using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vintasoft.Barcode;
using Vintasoft.Imaging;

namespace SimpleBarcodeReaderDemo
{
    /// <summary>
    /// A form that allows to select page from PDF document.
    /// </summary>
    public partial class SelectPdfPageForm : Form
    {

        #region Fields

        string _labelText;
        bool _selected;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectPdfPageForm"/> class.
        /// </summary>
        public SelectPdfPageForm()
        {
            InitializeComponent();
            _labelText = label1.Text;
        }

        #endregion



        #region Methods

        private void FormPdfPageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _selected = true;
            Close();
        }


        private Image GetImageFromPage(PdfImageViewer viewer, int pageIndex)
        {
            string[] names = viewer.GetImageNames(pageIndex);
            List<VintasoftBitmap> images = new List<VintasoftBitmap>();
            for (int i = 0; i < names.Length; i++)
            {
                try
                {
                    images.Add(viewer.GetImage(pageIndex, names[i]));
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Image '{0}': {1}", names[i], e.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (images.Count == 0)
                return null;
            if (images.Count == 1)
                return GdiConverter.Convert(images[0], true);

            // merge images
            int padding = 5;
            int heigth = 0;
            int width = 0;
            int n = images.Count;
            for (int i = 0; i < n; i++)
            {
                VintasoftBitmap current = images[i];
                if (width < current.Width)
                    width = current.Width;
                heigth += current.Height;
            }
            width += 3;
            heigth += (n + 1) * padding;

            Bitmap result = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, width, heigth));
                int y = 1;
                for (int i = 0; i < n; i++)
                {
                    using (Bitmap current = GdiConverter.Convert(images[i], true))
                    {
                        g.DrawImageUnscaled(current, new Point(1, y));
                        y += current.Height + padding;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Shows a dialog that allows to select PDF page.
        /// </summary>
        /// <param name="pdfFileName">The filename of PDF document.</param>
        public Image SelectImage(string pdfFileName)
        {
            PdfImageViewer pdfImageViewer;
            try
            {
                pdfImageViewer = new PdfImageViewer(pdfFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                pages.Items.Clear();

                for (int i = 0; i < pdfImageViewer.PageCount; i++)
                {
                    int k = pdfImageViewer.GetImageNames(i).Length;
                    if (k > 0)
                        pages.Items.Add(i + 1);
                }
                if (pages.Items.Count == 0)
                {
                    MessageBox.Show("PDF document does not contain images.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                pages.SelectedIndex = 0;

                if (pages.Items.Count == 1)
                {
                    return GetImageFromPage(pdfImageViewer, 0);
                }

                label1.Text = string.Format(_labelText, pages.Items.Count);

                _selected = false;
                ShowDialog();
                if (_selected)
                {
                    return GetImageFromPage(pdfImageViewer, (int)pages.SelectedItem - 1);
                }

                return null;
            }
            finally
            {
                pdfImageViewer.Dispose();
            }
        }

        #endregion

    }
}