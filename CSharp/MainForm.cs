using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.GS1;

namespace SimpleBarcodeReaderDemo
{
    public partial class MainForm : Form
    {
        
        #region Fields

        string _formText = "VintaSoft Simple Barcode Reader Demo v" + Vintasoft.Barcode.BarcodeGlobalSettings.ProductVersion;

        BarcodeReader _reader = new BarcodeReader();
        
        SelectImageFrameForm _selectImageFrameForm = new SelectImageFrameForm();
        
        SelectPdfPageForm _selectPdfPageForm = new SelectPdfPageForm();
                
        Image _image;

        #endregion



        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Text = _formText;

            try
            {
                // try change OpenDialog.InitialDirectory to  ..\..\..\Images directory
                string workDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName);
                workDir = Path.GetDirectoryName(workDir);
                workDir = Path.GetDirectoryName(workDir);
                workDir = Path.GetDirectoryName(workDir);
                workDir = Path.Combine(workDir, "Images");
                if (Directory.Exists(workDir))
                {
                    openFileDialog.InitialDirectory = workDir;
                }
                else
                {
                    workDir = Path.GetDirectoryName(workDir);
                    workDir = Path.GetDirectoryName(workDir);
                    workDir = Path.Combine(workDir, "Images");
                    if (Directory.Exists(workDir))
                        openFileDialog.InitialDirectory = workDir;
                }
            }
            catch
            {
            }

            _reader.Settings.SearchQRModel1Barcodes = true;
            _reader.Settings.ScanDirection = ScanDirection.Horizontal | ScanDirection.Vertical;
            _reader.Settings.ScanBarcodeTypes = BarcodeType.Code39 | BarcodeType.Code128;
            _reader.Progress += new EventHandler<BarcodeReaderProgressEventArgs>(reader_Progress);

            expectedBarcodesEditor.SetBarcodeReaderSettings(_reader.Settings);
            scanIntervalEditor.SetBarcodeReaderSettings(_reader.Settings);
            scanDirectionEditor.SetBarcodeReaderSettings(_reader.Settings);
            barcodeTypesEditor.SetBarcodeReaderSettings(_reader.Settings);
        }

        #endregion



        #region Methods
        
        #region Barcode Reader

        private void reader_Progress(object sender, BarcodeReaderProgressEventArgs e)
        {
            recognitionProgressBar.Value = e.Progress;
        }

        private void buttonReadBarcodes_Click(object sender, EventArgs e)
        {
            if (_image != null)
            {
                // init settigs
                _reader.Settings.AutomaticRecognition = true;
                _reader.Settings.MinConfidence = 95;

                readerResults.Text = "Recognition...";
                readerResults.Refresh();

                // read barcodes
                IBarcodeInfo[] infos;
                try
                {
                    infos = _reader.ReadBarcodes(_image);
                }
                catch (NotImplementedException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readerResults.Text = "";
                    return;
                }


                // get results
                readerResults.Text = GetResults(infos);
                readerResults.Refresh();

                // draw barcode rectangles
                DrawBarcodeRectangles(infos);
            }
        }

        private void DrawBarcodeRectangles(IBarcodeInfo[] infos)
        {
            Bitmap bmp = (Bitmap)_image;
            if (infos.Length != 0)
            {
                bmp = new Bitmap(_image.Width, _image.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(_image, 0, 0, _image.Width, _image.Height);
                    Brush brush = Brushes.Blue;
                    Pen pen = new Pen(Color.FromArgb(192, Color.Green), 2);
                    for (int i = 0; i < infos.Length; i++)
                    {
                        IBarcodeInfo inf = infos[i];
                        g.FillPolygon(new SolidBrush(Color.FromArgb(48, pen.Color)), inf.Region.GetPoints());
                        g.DrawPolygon(pen, inf.Region.GetPoints());

                        SolidBrush br = new SolidBrush(Color.Lime);
                        if (inf.ReadingQuality < 0.75)
                        {
                            if (inf.ReadingQuality >= 0.5)
                                br.Color = Color.Yellow;
                            else
                                br.Color = Color.Red;
                        }
                        br.Color = Color.FromArgb(192, br.Color);

                        string barcodeTypeValue;
                        if (inf is BarcodeSubsetInfo)
                            barcodeTypeValue = ((BarcodeSubsetInfo)inf).BarcodeSubset.Name;
                        else
                            barcodeTypeValue = inf.BarcodeType.ToString();

                        g.FillRectangle(br, inf.Region.LeftTop.X, inf.Region.LeftTop.Y, pen.Width + 2, pen.Width + 2);
                        using (GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                        {
                            g.DrawString(string.Format("[{0}] {1}: {2}", i + 1, barcodeTypeValue, inf.Value), new Font("Courier New", 8), brush, inf.Region.LeftTop.X, inf.Region.LeftTop.Y - 20);
                        }
                    }
                }
            }
            Image tmp = readerPictureBox.Image;
            readerPictureBox.Image = bmp;
            if (tmp != _image)
                tmp.Dispose();
        }

        private string GetResults(IBarcodeInfo[] infos)
        {
            StringBuilder sb = new StringBuilder();

            if (infos.Length == 0)
            {
                sb.Append(string.Format("No barcodes found ({0} ms).", _reader.RecognizeTime.TotalMilliseconds));
            }
            else
            {
                sb.AppendLine(string.Format("Found {0} barcodes ({1} ms):", infos.Length, _reader.RecognizeTime.TotalMilliseconds));
                sb.AppendLine();
                for (int i = 0; i < infos.Length; i++)
                    sb.AppendLine(GetBarcodeInfo(i, infos[i]));
            }

            return sb.ToString();
        }       

        private string GetBarcodeInfo(int index, IBarcodeInfo info)
        {
            info.ShowNonDataFlagsInValue = true;

            string value = info.Value;
            if (info.BarcodeType == BarcodeType.UPCE)
                value += string.Format(" ({0})", (info as UPCEANInfo).UPCEValue);

            string confidence;
            if (info.Confidence == ReaderSettings.ConfidenceNotAvailable)
                confidence = "N/A";
            else
                confidence = Math.Round(info.Confidence).ToString() + "%";

            if (info is BarcodeSubsetInfo)
            {
                value = string.Format("{0}{1}Base value: {2}",
                    RemoveSpecialCharacters(value), Environment.NewLine,
                    RemoveSpecialCharacters(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value));
            }
            else
            {
                value = RemoveSpecialCharacters(value);
            }

            string barcodeTypeValue;
            if (info is BarcodeSubsetInfo)
                barcodeTypeValue = ((BarcodeSubsetInfo)info).BarcodeSubset.ToString();
            else
                barcodeTypeValue = info.BarcodeType.ToString();


            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("[{0}:{1}]", index + 1, barcodeTypeValue));
            result.AppendLine(string.Format("Value: {0}", value));
            result.AppendLine(string.Format("Confidence: {0}", confidence));
            result.AppendLine(string.Format("Reading quality: {0}", info.ReadingQuality));
            result.AppendLine(string.Format("Threshold: {0}", info.Threshold));
            result.AppendLine(string.Format("Region: {0}", info.Region));
            return result.ToString();
        }

        private string RemoveSpecialCharacters(string text)
        {
            StringBuilder sb = new StringBuilder();
            if (text != null)
                for (int i = 0; i < text.Length; i++)
                    if (text[i] >= ' ' || text[i] == '\n' || text[i] == '\r' || text[i] == '\t')
                        sb.Append(text[i]);
                    else
                        sb.Append('?');
            return sb.ToString();
        }

        #endregion


        #region Environment

        private void OpenImage(string fileName)
        {
            CloseImage();
            try
            {
                // check file to use in another process
                Stream tempStream = File.Open(fileName, FileMode.Open);
                tempStream.Dispose();

                if (Path.GetExtension(fileName).ToLower() == ".pdf")
                {
                    if (BarcodeGlobalSettings.IsDemoVersion)
                        MessageBox.Show("Evaluation version allows to extract images only from the first page of PDF document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _image = _selectPdfPageForm.SelectImage(fileName);
                }
                else
                    _image = Image.FromFile(fileName);
                if (_image == null)
                    return;
                Text = _formText + " - " + Path.GetFileName(fileName);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Image '{0}' has unsupported format.", System.IO.Path.GetFileName(fileName)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _selectImageFrameForm.SelectFrame(_image);
            readerPictureBox.Image = _image;
        }

        private void CloseImage()
        {
            if (readerPictureBox.Image != null && readerPictureBox.Image != _image)
            {
                Image tmp = readerPictureBox.Image;
                readerPictureBox.Image = null;
                tmp.Dispose();
            }
            readerPictureBox.Image = null;
            if (_image != null)
            {
                _image.Dispose();
                _image = null;
            }
            readerResults.Text = "";
            Text = _formText;
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            RunOpenDialog();
        }

        private void RunOpenDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                OpenImage(openFileDialog.FileName);
        }

        private void checkBoxZoomImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZoomImage.Checked)
            {
                readerPictureBox.Dock = DockStyle.Fill;
                readerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                readerPictureBox.Dock = DockStyle.None;
                readerPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void SimpleBarcodeReaderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                RunOpenDialog();
                e.Handled = true;
            }
        }

        #endregion

     

        #endregion

    }
}
