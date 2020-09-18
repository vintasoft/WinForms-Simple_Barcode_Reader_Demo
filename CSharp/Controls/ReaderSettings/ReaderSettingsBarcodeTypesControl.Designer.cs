namespace BarcodeDemo
{
    partial class ReaderSettingsBarcodeTypesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.availableBarcodesGroupBox = new System.Windows.Forms.GroupBox();
            this.addAllToScanBarcodeTypeListButton = new System.Windows.Forms.Button();
            this.addSelectedToScanBarcodeTypeListButton = new System.Windows.Forms.Button();
            this.barcodeGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.availableBarcodeTypesListBox = new System.Windows.Forms.ListBox();
            this.scanBarcodesGroupBox = new System.Windows.Forms.GroupBox();
            this.scanBarcodeTypesListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedFromScanBarcodeTypeListButton = new System.Windows.Forms.Button();
            this.removeAllBarcodeTypeListButton = new System.Windows.Forms.Button();
            this.availableBarcodesGroupBox.SuspendLayout();
            this.scanBarcodesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableBarcodesGroupBox
            // 
            this.availableBarcodesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableBarcodesGroupBox.Controls.Add(this.addAllToScanBarcodeTypeListButton);
            this.availableBarcodesGroupBox.Controls.Add(this.addSelectedToScanBarcodeTypeListButton);
            this.availableBarcodesGroupBox.Controls.Add(this.barcodeGroupsComboBox);
            this.availableBarcodesGroupBox.Controls.Add(this.availableBarcodeTypesListBox);
            this.availableBarcodesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.availableBarcodesGroupBox.Name = "availableBarcodesGroupBox";
            this.availableBarcodesGroupBox.Size = new System.Drawing.Size(256, 243);
            this.availableBarcodesGroupBox.TabIndex = 0;
            this.availableBarcodesGroupBox.TabStop = false;
            this.availableBarcodesGroupBox.Text = "Supported barcode types";
            // 
            // addAllToScanBarcodeTypeListButton
            // 
            this.addAllToScanBarcodeTypeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAllToScanBarcodeTypeListButton.Location = new System.Drawing.Point(150, 212);
            this.addAllToScanBarcodeTypeListButton.Name = "addAllToScanBarcodeTypeListButton";
            this.addAllToScanBarcodeTypeListButton.Size = new System.Drawing.Size(100, 23);
            this.addAllToScanBarcodeTypeListButton.TabIndex = 4;
            this.addAllToScanBarcodeTypeListButton.Text = "Add All =>";
            this.addAllToScanBarcodeTypeListButton.UseVisualStyleBackColor = true;
            this.addAllToScanBarcodeTypeListButton.Click += new System.EventHandler(this.addAllToScanBarcodeTypeListButton_Click);
            // 
            // addSelectedToScanBarcodeTypeListButton
            // 
            this.addSelectedToScanBarcodeTypeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSelectedToScanBarcodeTypeListButton.Location = new System.Drawing.Point(5, 212);
            this.addSelectedToScanBarcodeTypeListButton.Name = "addSelectedToScanBarcodeTypeListButton";
            this.addSelectedToScanBarcodeTypeListButton.Size = new System.Drawing.Size(100, 23);
            this.addSelectedToScanBarcodeTypeListButton.TabIndex = 3;
            this.addSelectedToScanBarcodeTypeListButton.Text = "Add Selected =>";
            this.addSelectedToScanBarcodeTypeListButton.UseVisualStyleBackColor = true;
            this.addSelectedToScanBarcodeTypeListButton.Click += new System.EventHandler(this.addSelectedToScanBarcodeTypeListButton_Click);
            // 
            // barcodeGroupsComboBox
            // 
            this.barcodeGroupsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeGroupsComboBox.FormattingEnabled = true;
            this.barcodeGroupsComboBox.Items.AddRange(new object[] {
            "All",
            "1D",
            "2D",
            "Postal 2/4",
            "EAN, UPC",
            "GS1",
            "RSS",
            "Composite",
            "Subsets",
            "With Checksum"});
            this.barcodeGroupsComboBox.Location = new System.Drawing.Point(6, 19);
            this.barcodeGroupsComboBox.Name = "barcodeGroupsComboBox";
            this.barcodeGroupsComboBox.Size = new System.Drawing.Size(244, 21);
            this.barcodeGroupsComboBox.TabIndex = 2;
            this.barcodeGroupsComboBox.TextChanged += new System.EventHandler(this.barcodeGroupsComboBox_TextChanged);
            // 
            // availableBarcodeTypesListBox
            // 
            this.availableBarcodeTypesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableBarcodeTypesListBox.FormattingEnabled = true;
            this.availableBarcodeTypesListBox.Location = new System.Drawing.Point(6, 45);
            this.availableBarcodeTypesListBox.Name = "availableBarcodeTypesListBox";
            this.availableBarcodeTypesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.availableBarcodeTypesListBox.Size = new System.Drawing.Size(244, 160);
            this.availableBarcodeTypesListBox.TabIndex = 1;
            this.availableBarcodeTypesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.availableBarcodeTypesListBox_MouseDoubleClick);
            // 
            // scanBarcodesGroupBox
            // 
            this.scanBarcodesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanBarcodesGroupBox.Controls.Add(this.scanBarcodeTypesListBox);
            this.scanBarcodesGroupBox.Controls.Add(this.removeSelectedFromScanBarcodeTypeListButton);
            this.scanBarcodesGroupBox.Controls.Add(this.removeAllBarcodeTypeListButton);
            this.scanBarcodesGroupBox.Location = new System.Drawing.Point(260, 0);
            this.scanBarcodesGroupBox.Name = "scanBarcodesGroupBox";
            this.scanBarcodesGroupBox.Size = new System.Drawing.Size(243, 243);
            this.scanBarcodesGroupBox.TabIndex = 1;
            this.scanBarcodesGroupBox.TabStop = false;
            this.scanBarcodesGroupBox.Text = "Barcode types for recognition";
            // 
            // scanBarcodeTypesListBox
            // 
            this.scanBarcodeTypesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanBarcodeTypesListBox.FormattingEnabled = true;
            this.scanBarcodeTypesListBox.Location = new System.Drawing.Point(6, 19);
            this.scanBarcodeTypesListBox.Name = "scanBarcodeTypesListBox";
            this.scanBarcodeTypesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.scanBarcodeTypesListBox.Size = new System.Drawing.Size(231, 186);
            this.scanBarcodeTypesListBox.TabIndex = 0;
            this.scanBarcodeTypesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scanBarcodeTypesListBox_MouseDoubleClick);
            // 
            // removeSelectedFromScanBarcodeTypeListButton
            // 
            this.removeSelectedFromScanBarcodeTypeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSelectedFromScanBarcodeTypeListButton.Location = new System.Drawing.Point(5, 212);
            this.removeSelectedFromScanBarcodeTypeListButton.Name = "removeSelectedFromScanBarcodeTypeListButton";
            this.removeSelectedFromScanBarcodeTypeListButton.Size = new System.Drawing.Size(93, 23);
            this.removeSelectedFromScanBarcodeTypeListButton.TabIndex = 5;
            this.removeSelectedFromScanBarcodeTypeListButton.Text = "Remove";
            this.removeSelectedFromScanBarcodeTypeListButton.UseVisualStyleBackColor = true;
            this.removeSelectedFromScanBarcodeTypeListButton.Click += new System.EventHandler(this.removeSelectedFromScanBarcodeTypeListButton_Click);
            // 
            // clearScanBarcodeTypeListButton
            // 
            this.removeAllBarcodeTypeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAllBarcodeTypeListButton.Location = new System.Drawing.Point(145, 212);
            this.removeAllBarcodeTypeListButton.Name = "removeAllButton";
            this.removeAllBarcodeTypeListButton.Size = new System.Drawing.Size(93, 23);
            this.removeAllBarcodeTypeListButton.TabIndex = 4;
            this.removeAllBarcodeTypeListButton.Text = "Clear";
            this.removeAllBarcodeTypeListButton.UseVisualStyleBackColor = true;
            this.removeAllBarcodeTypeListButton.Click += new System.EventHandler(this.removeAllBarcodeTypeListButton_Click);
            // 
            // ReaderSettingsBarcodeTypesControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scanBarcodesGroupBox);
            this.Controls.Add(this.availableBarcodesGroupBox);
            this.Name = "ReaderSettingsBarcodeTypesControl";
            this.Size = new System.Drawing.Size(503, 243);
            this.availableBarcodesGroupBox.ResumeLayout(false);
            this.scanBarcodesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox availableBarcodesGroupBox;
        private System.Windows.Forms.Button addAllToScanBarcodeTypeListButton;
        private System.Windows.Forms.Button addSelectedToScanBarcodeTypeListButton;
        private System.Windows.Forms.ComboBox barcodeGroupsComboBox;
        private System.Windows.Forms.ListBox availableBarcodeTypesListBox;
        private System.Windows.Forms.GroupBox scanBarcodesGroupBox;
        private System.Windows.Forms.Button removeSelectedFromScanBarcodeTypeListButton;
        private System.Windows.Forms.Button removeAllBarcodeTypeListButton;
        private System.Windows.Forms.ListBox scanBarcodeTypesListBox;
    }
}