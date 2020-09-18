namespace BarcodeDemo
{
    partial class DemoVersionRestrictionsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.documentationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.androidBarcodeScannerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aspNetBarcodeScannerGeneratorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.androidBarcodeGeneratorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.Location = new System.Drawing.Point(189, 182);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "You selected barcode symbologies for recognition, which cannot be recognized due " +
    "of limitations of evaluation version of VintaSoft Barcode .NET SDK.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please read information about limitations of evaluation version here:";
            // 
            // documentationLinkLabel
            // 
            this.documentationLinkLabel.AutoSize = true;
            this.documentationLinkLabel.Location = new System.Drawing.Point(335, 52);
            this.documentationLinkLabel.Name = "documentationLinkLabel";
            this.documentationLinkLabel.Size = new System.Drawing.Size(79, 13);
            this.documentationLinkLabel.TabIndex = 4;
            this.documentationLinkLabel.TabStop = true;
            this.documentationLinkLabel.Text = "Documentation";
            this.documentationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.documentationLinkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "If you want to test SDK functionality without limitations, you can use:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "1. Free barcode scanner for Android:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "2. Free barcode generator for Android:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3. Free web barcode scanner/generator:";
            // 
            // androidBarcodeScannerLinkLabel
            // 
            this.androidBarcodeScannerLinkLabel.AutoSize = true;
            this.androidBarcodeScannerLinkLabel.Location = new System.Drawing.Point(194, 107);
            this.androidBarcodeScannerLinkLabel.Name = "androidBarcodeScannerLinkLabel";
            this.androidBarcodeScannerLinkLabel.Size = new System.Drawing.Size(136, 13);
            this.androidBarcodeScannerLinkLabel.TabIndex = 9;
            this.androidBarcodeScannerLinkLabel.TabStop = true;
            this.androidBarcodeScannerLinkLabel.Text = "VintaSoft Barcode Scanner";
            this.androidBarcodeScannerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.androidBarcodeScannerLinkLabel_LinkClicked);
            // 
            // aspNetBarcodeScannerGeneratorLinkLabel
            // 
            this.aspNetBarcodeScannerGeneratorLinkLabel.AutoSize = true;
            this.aspNetBarcodeScannerGeneratorLinkLabel.Location = new System.Drawing.Point(212, 150);
            this.aspNetBarcodeScannerGeneratorLinkLabel.Name = "aspNetBarcodeScannerGeneratorLinkLabel";
            this.aspNetBarcodeScannerGeneratorLinkLabel.Size = new System.Drawing.Size(214, 13);
            this.aspNetBarcodeScannerGeneratorLinkLabel.TabIndex = 10;
            this.aspNetBarcodeScannerGeneratorLinkLabel.TabStop = true;
            this.aspNetBarcodeScannerGeneratorLinkLabel.Text = "VintaSoft Web Barcode Scanner/Generator";
            this.aspNetBarcodeScannerGeneratorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aspNetBarcodeScannerGeneratorLinkLabel_LinkClicked);
            // 
            // androidBarcodeGeneratorLinkLabel
            // 
            this.androidBarcodeGeneratorLinkLabel.AutoSize = true;
            this.androidBarcodeGeneratorLinkLabel.Location = new System.Drawing.Point(200, 128);
            this.androidBarcodeGeneratorLinkLabel.Name = "androidBarcodeGeneratorLinkLabel";
            this.androidBarcodeGeneratorLinkLabel.Size = new System.Drawing.Size(143, 13);
            this.androidBarcodeGeneratorLinkLabel.TabIndex = 11;
            this.androidBarcodeGeneratorLinkLabel.TabStop = true;
            this.androidBarcodeGeneratorLinkLabel.Text = "VintaSoft Barcode Generator";
            this.androidBarcodeGeneratorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.androidBarcodeGeneratorLinkLabel_LinkClicked);
            // 
            // DemoVersionRestrictionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 217);
            this.Controls.Add(this.androidBarcodeGeneratorLinkLabel);
            this.Controls.Add(this.aspNetBarcodeScannerGeneratorLinkLabel);
            this.Controls.Add(this.androidBarcodeScannerLinkLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documentationLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemoVersionRestrictionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VintaSoft Barcode .NET SDK: Restrictions of DEMO version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel documentationLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel androidBarcodeScannerLinkLabel;
        private System.Windows.Forms.LinkLabel aspNetBarcodeScannerGeneratorLinkLabel;
        private System.Windows.Forms.LinkLabel androidBarcodeGeneratorLinkLabel;
    }
}