namespace SimpleBarcodeReaderDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vintasoft.Barcode.ReaderSettings readerSettings1 = new Vintasoft.Barcode.ReaderSettings();
            Vintasoft.Barcode.ReaderSettings readerSettings2 = new Vintasoft.Barcode.ReaderSettings();
            Vintasoft.Barcode.ReaderSettings readerSettings3 = new Vintasoft.Barcode.ReaderSettings();
            Vintasoft.Barcode.ReaderSettings readerSettings4 = new Vintasoft.Barcode.ReaderSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlButtonsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.recognitionProgressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxZoomImage = new System.Windows.Forms.CheckBox();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.buttonReadBarcodes = new System.Windows.Forms.Button();
            this.barcodeTypesEditor = new BarcodeDemo.BarcodeTypesReaderSettingsControl();
            this.scanDirectionEditor = new BarcodeDemo.ScanDirectionEditorControl();
            this.scanIntervalEditor = new BarcodeDemo.ScanIntervalEditorControl();
            this.expectedBarcodesEditor = new BarcodeDemo.ExpectedBarcodesEditorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.readerPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.readerResults = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.controlButtonsGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.controlButtonsGroupBox1);
            this.panel1.Controls.Add(this.barcodeTypesEditor);
            this.panel1.Controls.Add(this.scanDirectionEditor);
            this.panel1.Controls.Add(this.scanIntervalEditor);
            this.panel1.Controls.Add(this.expectedBarcodesEditor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 252);
            this.panel1.TabIndex = 0;
            // 
            // controlButtonsGroupBox1
            // 
            this.controlButtonsGroupBox1.Controls.Add(this.recognitionProgressBar);
            this.controlButtonsGroupBox1.Controls.Add(this.checkBoxZoomImage);
            this.controlButtonsGroupBox1.Controls.Add(this.buttonOpenImage);
            this.controlButtonsGroupBox1.Controls.Add(this.buttonReadBarcodes);
            this.controlButtonsGroupBox1.Location = new System.Drawing.Point(8, 1);
            this.controlButtonsGroupBox1.Name = "controlButtonsGroupBox1";
            this.controlButtonsGroupBox1.Size = new System.Drawing.Size(258, 70);
            this.controlButtonsGroupBox1.TabIndex = 37;
            this.controlButtonsGroupBox1.TabStop = false;
            // 
            // recognitionProgressBar
            // 
            this.recognitionProgressBar.Location = new System.Drawing.Point(132, 47);
            this.recognitionProgressBar.Name = "recognitionProgressBar";
            this.recognitionProgressBar.Size = new System.Drawing.Size(119, 15);
            this.recognitionProgressBar.TabIndex = 36;
            // 
            // checkBoxZoomImage
            // 
            this.checkBoxZoomImage.AutoSize = true;
            this.checkBoxZoomImage.Location = new System.Drawing.Point(11, 47);
            this.checkBoxZoomImage.Name = "checkBoxZoomImage";
            this.checkBoxZoomImage.Size = new System.Drawing.Size(85, 17);
            this.checkBoxZoomImage.TabIndex = 2;
            this.checkBoxZoomImage.Text = "Zoom Image";
            this.checkBoxZoomImage.UseVisualStyleBackColor = true;
            this.checkBoxZoomImage.CheckedChanged += new System.EventHandler(this.checkBoxZoomImage_CheckedChanged);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(4, 10);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(123, 34);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open Image...";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // buttonReadBarcodes
            // 
            this.buttonReadBarcodes.Location = new System.Drawing.Point(131, 10);
            this.buttonReadBarcodes.Name = "buttonReadBarcodes";
            this.buttonReadBarcodes.Size = new System.Drawing.Size(121, 34);
            this.buttonReadBarcodes.TabIndex = 1;
            this.buttonReadBarcodes.Text = "Read Barcodes";
            this.buttonReadBarcodes.UseVisualStyleBackColor = true;
            this.buttonReadBarcodes.Click += new System.EventHandler(this.buttonReadBarcodes_Click);
            // 
            // barcodeTypesEditor
            // 
            readerSettings1.MaximalThreadsCount = 4;
            readerSettings1.MinConfidence = 95;
            readerSettings1.ScanRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            readerSettings1.VerifyBarcodeMethod = null;
            this.barcodeTypesEditor.BarcodeReaderSettings = readerSettings1;
            this.barcodeTypesEditor.Location = new System.Drawing.Point(273, 1);
            this.barcodeTypesEditor.Name = "barcodeTypesEditor";
            this.barcodeTypesEditor.ShowUnknownLinearSettings = false;
            this.barcodeTypesEditor.Size = new System.Drawing.Size(495, 245);
            this.barcodeTypesEditor.TabIndex = 35;
            // 
            // scanDirectionEditor
            // 
            readerSettings2.MaximalThreadsCount = 4;
            readerSettings2.MinConfidence = 95;
            readerSettings2.ScanRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            readerSettings2.VerifyBarcodeMethod = null;
            this.scanDirectionEditor.BarcodeReaderSettings = readerSettings2;
            this.scanDirectionEditor.Location = new System.Drawing.Point(8, 147);
            this.scanDirectionEditor.Name = "scanDirectionEditor";
            this.scanDirectionEditor.Size = new System.Drawing.Size(258, 99);
            this.scanDirectionEditor.TabIndex = 34;
            // 
            // scanIntervalEditor
            // 
            readerSettings3.MaximalThreadsCount = 4;
            readerSettings3.MinConfidence = 95;
            readerSettings3.ScanRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            readerSettings3.VerifyBarcodeMethod = null;
            this.scanIntervalEditor.BarcodeReaderSettings = readerSettings3;
            this.scanIntervalEditor.Location = new System.Drawing.Point(8, 73);
            this.scanIntervalEditor.Maximum = 25;
            this.scanIntervalEditor.Minimum = 1;
            this.scanIntervalEditor.Name = "scanIntervalEditor";
            this.scanIntervalEditor.Size = new System.Drawing.Size(127, 75);
            this.scanIntervalEditor.TabIndex = 33;
            this.scanIntervalEditor.TickFrequency = 1;
            this.scanIntervalEditor.Title = "Scan interval";
            this.scanIntervalEditor.Value = 5;
            // 
            // expectedBarcodesEditor
            // 
            readerSettings4.MaximalThreadsCount = 4;
            readerSettings4.MinConfidence = 95;
            readerSettings4.ScanRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            readerSettings4.VerifyBarcodeMethod = null;
            this.expectedBarcodesEditor.BarcodeReaderSettings = readerSettings4;
            this.expectedBarcodesEditor.Location = new System.Drawing.Point(139, 73);
            this.expectedBarcodesEditor.Maximum = 50;
            this.expectedBarcodesEditor.Minimum = 1;
            this.expectedBarcodesEditor.Name = "expectedBarcodesEditor";
            this.expectedBarcodesEditor.Size = new System.Drawing.Size(127, 75);
            this.expectedBarcodesEditor.TabIndex = 32;
            this.expectedBarcodesEditor.TickFrequency = 2;
            this.expectedBarcodesEditor.Title = "Expected barcodes";
            this.expectedBarcodesEditor.Value = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(775, 410);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.readerPictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 406);
            this.panel4.TabIndex = 1;
            // 
            // readerPictureBox
            // 
            this.readerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.readerPictureBox.Name = "readerPictureBox";
            this.readerPictureBox.Size = new System.Drawing.Size(100, 50);
            this.readerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.readerPictureBox.TabIndex = 0;
            this.readerPictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.readerResults);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(533, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(240, 406);
            this.panel3.TabIndex = 0;
            // 
            // readerResults
            // 
            this.readerResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerResults.Location = new System.Drawing.Point(2, 0);
            this.readerResults.Name = "readerResults";
            this.readerResults.ReadOnly = true;
            this.readerResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.readerResults.Size = new System.Drawing.Size(238, 406);
            this.readerResults.TabIndex = 1;
            this.readerResults.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All supported (*.pdf;*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.t" +
                "ga;*.wmf;*.emf)|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.tga;*" +
                ".wmf;*.emf;*.pdf";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimpleBarcodeReaderForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.controlButtonsGroupBox1.ResumeLayout(false);
            this.controlButtonsGroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox readerPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox readerResults;
        private System.Windows.Forms.CheckBox checkBoxZoomImage;
        private System.Windows.Forms.Button buttonReadBarcodes;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private BarcodeDemo.ExpectedBarcodesEditorControl expectedBarcodesEditor;
        private BarcodeDemo.ScanIntervalEditorControl scanIntervalEditor;
        private BarcodeDemo.ScanDirectionEditorControl scanDirectionEditor;
        private BarcodeDemo.BarcodeTypesReaderSettingsControl barcodeTypesEditor;
        private System.Windows.Forms.ProgressBar recognitionProgressBar;
        private System.Windows.Forms.GroupBox controlButtonsGroupBox1;
    }
}

