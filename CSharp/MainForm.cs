using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.SymbologySubsets;

namespace SimpleBarcodeReaderDemo
{
    /// <summary>
    /// The main form of Simple Barcode Reader Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        string _formText = "VintaSoft Simple Barcode Reader Demo v" + Vintasoft.Barcode.BarcodeGlobalSettings.ProductVersion;

        BarcodeReader _reader = new BarcodeReader();

        SelectImageFrameForm _selectImageFrameForm = new SelectImageFrameForm();

        SelectPdfPageForm _selectPdfPageForm = new SelectPdfPageForm();

        Stream _imageStream;

        Image _image;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes the <see cref="MainForm"/> class.
        /// </summary>
        static MainForm()
        {
            // register the evaluation license for VintaSoft Barcode .NET SDK
            Vintasoft.Barcode.BarcodeGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

#if NETCOREAPP
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
#endif

            // initialize Vintasoft.Barcode.Gdi assembly
            Vintasoft.Barcode.GdiAssembly.Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Text = _formText;

            try
            {
                string exampleImagesDir = GetExampleImagesDirectory();
                if (exampleImagesDir != null)
                    openFileDialog.InitialDirectory = exampleImagesDir;
            }
            catch
            {
            }

            _reader.Settings.SearchQRModel1Barcodes = true;
            _reader.Settings.ScanDirection = ScanDirection.Horizontal | ScanDirection.Vertical;
            _reader.Settings.ScanBarcodeTypes = BarcodeType.Code39 | BarcodeType.Code128;
            _reader.Progress += new EventHandler<BarcodeReaderProgressEventArgs>(barcodeReader_Progress);

            expectedBarcodesEditor.SetBarcodeReaderSettings(_reader.Settings);
            scanIntervalEditor.SetBarcodeReaderSettings(_reader.Settings);
            scanDirectionEditor.SetBarcodeReaderSettings(_reader.Settings);
            barcodeTypesEditor.SetBarcodeReaderSettings(_reader.Settings);
        }

        #endregion



        #region Methods

        #region Barcode Reader

        private void barcodeReader_Progress(object sender, BarcodeReaderProgressEventArgs e)
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
                        g.FillPolygon(new SolidBrush(Color.FromArgb(48, pen.Color)), GdiConverter.Convert(inf.Region.GetPoints()));
                        g.DrawPolygon(pen, GdiConverter.Convert(inf.Region.GetPoints()));

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
                sb.Append(string.Format("Barcodes are not found ({0} ms).", _reader.RecognizeTime.TotalMilliseconds));
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

        /// <summary>
        /// Returns the barcode value as a string.
        /// </summary>
        private string GetBarcodeInfo(int index, IBarcodeInfo info)
        {
            info.ShowNonDataFlagsInValue = true;

            string value = info.Value;

            if (info is UPCEANInfo)
            {
                if ((info.BarcodeType & BarcodeType.UPCE) != 0)
                    value += string.Format(" (UPC-E: {0})", (info as UPCEANInfo).UPCEValue);

                if ((info.BarcodeType & BarcodeType.UPCA) != 0)
                    value += string.Format(" (UPC-A: {0})", (info as UPCEANInfo).UPCAValue);
            }

            string confidence;
            if (info.Confidence == ReaderSettings.ConfidenceNotAvailable)
                confidence = "N/A";
            else
                confidence = Math.Round(info.Confidence).ToString() + "%";

            if (info is BarcodeSubsetInfo)
            {
                if (info is AamvaBarcodeInfo)
                {
                    AamvaBarcodeValue aamvaValue = ((AamvaBarcodeInfo)info).AamvaValue;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine();
                    sb.AppendLine(string.Format("Issuer identification number: {0}", aamvaValue.Header.IssuerIdentificationNumber));
                    sb.AppendLine(string.Format("File type: {0}", aamvaValue.Header.FileType));
                    sb.AppendLine(string.Format("AAMVA Version number: {0} ({1})", aamvaValue.Header.VersionLevel, (int)aamvaValue.Header.VersionLevel));
                    sb.AppendLine(string.Format("Jurisdiction Version number: {0}", aamvaValue.Header.JurisdictionVersionNumber));
                    sb.AppendLine();
                    foreach (AamvaSubfile subfile in aamvaValue.Subfiles)
                    {
                        sb.AppendLine(string.Format("[{0}] subfile:", subfile.SubfileType));
                        foreach (AamvaDataElement dataElement in subfile.DataElements)
                        {
                            if (dataElement.Identifier.VersionLevel != AamvaVersionLevel.Undefined)
                                sb.Append(string.Format("  [{0}] {1}:", dataElement.Identifier.ID, dataElement.Identifier.Description));
                            else
                                sb.Append(string.Format("  [{0}]:", dataElement.Identifier.ID));
                            sb.AppendLine(string.Format(" {0}", dataElement.Value));
                        }
                    }
                    value = sb.ToString();
                }
                else
                {
                    value = string.Format("{0}{1}Base value: {2}",
                        RemoveSpecialCharacters(value), Environment.NewLine,
                        RemoveSpecialCharacters(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value));
                }
            }
            else
            {
                value = RemoveSpecialCharacters(value);
            }

            string barcodeTypeValue;
            if (info is StructuredAppendBarcodeInfo)
            {
                barcodeTypeValue = string.Format("{0} (Reconstructed)", info.BarcodeType);
            }
            else if (info is BarcodeSubsetInfo)
            {
                BarcodeSubsetInfo subsetInfo = (BarcodeSubsetInfo)info;
                barcodeTypeValue = string.Format("{0} ({1})", subsetInfo.BarcodeSubset.Name, subsetInfo.BarcodeSubset.BarcodeType);
            }
            else
            {
                barcodeTypeValue = info.BarcodeType.ToString();
            }

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
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= ' ' || text[i] == '\n' || text[i] == '\r' || text[i] == '\t')
                        sb.Append(text[i]);
                    else
                        sb.Append('?');
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns path to "Images" directory with example barcode images.
        /// </summary>
        /// <returns>Path to "Images" directory with example barcode images.</returns>
        private string GetExampleImagesDirectory()
        {
            string binDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName);
            string exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images"))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images")))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images"))))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images")))))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            return null;
        }

        #endregion


        #region Environment

        private void OpenImage(string fileName)
        {
            CloseImage();
            try
            {
                // check file to use in another process
                using (Stream tempStream = File.OpenRead(fileName))
                {
                }

                if (Path.GetExtension(fileName).ToLower() == ".pdf")
                {
                    if (BarcodeGlobalSettings.IsDemoVersion)
                        MessageBox.Show("Evaluation version allows to extract images only from the first page of PDF document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _image = _selectPdfPageForm.SelectImage(fileName);
                }
                else
                {
                    _imageStream = File.OpenRead(fileName);
                    _image = Image.FromStream(_imageStream);
                }
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
            if (_imageStream != null)
            {
                _imageStream.Dispose();
                _imageStream = null;
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

        private void Form_KeyDown(object sender, KeyEventArgs e)
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
