using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Vintasoft.Barcode;

namespace SimpleBarcodeReaderDemo
{
    public partial class SelectPdfPageForm : Form
    {

        #region Fields

        string _labelText;
        bool _selected;

        #endregion



        #region Constructors

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
            ArrayList images = new ArrayList();
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
                return (Image)images[0];

            // merge images
            int padding = 5;
            int heigth = 0;
            int width = 0;
            int n = images.Count;
            for (int i = 0; i < n; i++)
            {
                Image current = (Image)images[i];
                if (width < current.Width)
                    width = current.Width;
                heigth += current.Height;
            }
            width += 3;
            heigth += (n + 1) * padding;
            Bitmap result = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(result);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, width, heigth));
            int dy = 1;
            for (int i = 0; i < n; i++)
            {
                Image current = (Image)images[i];
                g.DrawImageUnscaled(current, new Point(1, dy));
                dy += current.Height + padding;
                current.Dispose();
            }
            g.Dispose();

            return result;
        }

        public Image SelectImage(string pdfFileName)
        {
            PdfImageViewer viewer;
            try
            {
                viewer = new PdfImageViewer(pdfFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                pages.Items.Clear();
                for (int i = 0; i < viewer.PageCount; i++)
                {
                    int k = viewer.GetImageNames(i).Length;
                    if (k > 0)
                        pages.Items.Add(i + 1);
                }
                if (pages.Items.Count == 0)
                {
                    MessageBox.Show("Images in PDF file are not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                pages.SelectedIndex = 0;

                if (pages.Items.Count == 1)
                {
                    return GetImageFromPage(viewer, 0);
                }

                label1.Text = string.Format(_labelText, pages.Items.Count);

                _selected = false;
                ShowDialog();
                if (_selected)
                {
                    Image result = GetImageFromPage(viewer, (int)pages.SelectedItem - 1);
                    return result;
                }

                return null;
            }
            finally
            {
                viewer.Dispose();
            }
        }

        #endregion

    }
}