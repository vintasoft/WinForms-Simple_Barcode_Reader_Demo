namespace BarcodeDemo
{
    partial class ParameterEditorControl
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
            this.valueGroupBox = new System.Windows.Forms.GroupBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueTrackBar = new System.Windows.Forms.TrackBar();
            this.valueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // valueGroupBox
            // 
            this.valueGroupBox.Controls.Add(this.valueLabel);
            this.valueGroupBox.Controls.Add(this.valueTrackBar);
            this.valueGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueGroupBox.Location = new System.Drawing.Point(0, 0);
            this.valueGroupBox.Name = "valueGroupBox";
            this.valueGroupBox.Size = new System.Drawing.Size(190, 81);
            this.valueGroupBox.TabIndex = 24;
            this.valueGroupBox.TabStop = false;
            // 
            // valueLabel
            // 
            this.valueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.valueLabel.Location = new System.Drawing.Point(3, 16);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(184, 16);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "5";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueTrackBar
            // 
            this.valueTrackBar.AutoSize = false;
            this.valueTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.valueTrackBar.Location = new System.Drawing.Point(3, 40);
            this.valueTrackBar.Maximum = 20;
            this.valueTrackBar.Minimum = 1;
            this.valueTrackBar.Name = "valueTrackBar";
            this.valueTrackBar.Size = new System.Drawing.Size(184, 38);
            this.valueTrackBar.TabIndex = 0;
            this.valueTrackBar.Value = 5;
            this.valueTrackBar.ValueChanged += new System.EventHandler(this.valueTrackBar_ValueChanged);
            // 
            // ParameterEditorControl
            // 
            this.Controls.Add(this.valueGroupBox);
            this.Name = "ParameterEditorControl";
            this.Size = new System.Drawing.Size(190, 81);
            this.valueGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox valueGroupBox;
        internal System.Windows.Forms.Label valueLabel;
        internal System.Windows.Forms.TrackBar valueTrackBar;
    }
}