namespace BarcodeDemo
{
    partial class ScanDirectionEditorControl
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.directionRB_LTCheckBox = new System.Windows.Forms.CheckBox();
            this.directionLB_RTCheckBox = new System.Windows.Forms.CheckBox();
            this.directionRT_LBCheckBox = new System.Windows.Forms.CheckBox();
            this.directionLT_RBCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directionAngle45CheckBox = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.directionTBCheckBox = new System.Windows.Forms.CheckBox();
            this.directionRLCheckBox = new System.Windows.Forms.CheckBox();
            this.directionBTCheckBox = new System.Windows.Forms.CheckBox();
            this.directionLRCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.directionRB_LTCheckBox);
            this.GroupBox2.Controls.Add(this.directionLB_RTCheckBox);
            this.GroupBox2.Controls.Add(this.directionRT_LBCheckBox);
            this.GroupBox2.Controls.Add(this.directionLT_RBCheckBox);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.directionAngle45CheckBox);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.directionTBCheckBox);
            this.GroupBox2.Controls.Add(this.directionRLCheckBox);
            this.GroupBox2.Controls.Add(this.directionBTCheckBox);
            this.GroupBox2.Controls.Add(this.directionLRCheckBox);
            this.GroupBox2.Controls.Add(this.label6);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(255, 100);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Scan Direction";
            // 
            // directionRB_LTCheckBox
            // 
            this.directionRB_LTCheckBox.Enabled = false;
            this.directionRB_LTCheckBox.Location = new System.Drawing.Point(138, 61);
            this.directionRB_LTCheckBox.Name = "directionRB_LTCheckBox";
            this.directionRB_LTCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionRB_LTCheckBox.TabIndex = 14;
            // 
            // directionLB_RTCheckBox
            // 
            this.directionLB_RTCheckBox.Enabled = false;
            this.directionLB_RTCheckBox.Location = new System.Drawing.Point(106, 61);
            this.directionLB_RTCheckBox.Name = "directionLB_RTCheckBox";
            this.directionLB_RTCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionLB_RTCheckBox.TabIndex = 13;
            // 
            // directionRT_LBCheckBox
            // 
            this.directionRT_LBCheckBox.Enabled = false;
            this.directionRT_LBCheckBox.Location = new System.Drawing.Point(138, 29);
            this.directionRT_LBCheckBox.Name = "directionRT_LBCheckBox";
            this.directionRT_LBCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionRT_LBCheckBox.TabIndex = 12;
            // 
            // directionLT_RBCheckBox
            // 
            this.directionLT_RBCheckBox.Enabled = false;
            this.directionLT_RBCheckBox.Location = new System.Drawing.Point(106, 29);
            this.directionLT_RBCheckBox.Name = "directionLT_RBCheckBox";
            this.directionLT_RBCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionLT_RBCheckBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "45°/135°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // directionAngle45CheckBox
            // 
            this.directionAngle45CheckBox.Location = new System.Drawing.Point(6, 19);
            this.directionAngle45CheckBox.Name = "directionAngle45CheckBox";
            this.directionAngle45CheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionAngle45CheckBox.TabIndex = 9;
            this.directionAngle45CheckBox.CheckedChanged += new System.EventHandler(this.direction_CheckedChanged);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(36, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Left to right";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(160, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Right to left";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(96, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Top to bottom";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // directionTBCheckBox
            // 
            this.directionTBCheckBox.Checked = true;
            this.directionTBCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directionTBCheckBox.Location = new System.Drawing.Point(122, 24);
            this.directionTBCheckBox.Name = "directionTBCheckBox";
            this.directionTBCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionTBCheckBox.TabIndex = 4;
            this.directionTBCheckBox.CheckedChanged += new System.EventHandler(this.direction_CheckedChanged);
            // 
            // directionRLCheckBox
            // 
            this.directionRLCheckBox.Checked = true;
            this.directionRLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directionRLCheckBox.Location = new System.Drawing.Point(144, 45);
            this.directionRLCheckBox.Name = "directionRLCheckBox";
            this.directionRLCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionRLCheckBox.TabIndex = 3;
            this.directionRLCheckBox.CheckedChanged += new System.EventHandler(this.direction_CheckedChanged);
            // 
            // directionBTCheckBox
            // 
            this.directionBTCheckBox.Checked = true;
            this.directionBTCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directionBTCheckBox.Location = new System.Drawing.Point(122, 67);
            this.directionBTCheckBox.Name = "directionBTCheckBox";
            this.directionBTCheckBox.Size = new System.Drawing.Size(16, 14);
            this.directionBTCheckBox.TabIndex = 2;
            this.directionBTCheckBox.CheckedChanged += new System.EventHandler(this.direction_CheckedChanged);
            // 
            // directionLRCheckBox
            // 
            this.directionLRCheckBox.Checked = true;
            this.directionLRCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directionLRCheckBox.Location = new System.Drawing.Point(100, 45);
            this.directionLRCheckBox.Name = "directionLRCheckBox";
            this.directionLRCheckBox.Size = new System.Drawing.Size(16, 16);
            this.directionLRCheckBox.TabIndex = 0;
            this.directionLRCheckBox.CheckedChanged += new System.EventHandler(this.direction_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(94, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bottom to top";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScanDirectionEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox2);
            this.Name = "ScanDirectionEditorControl";
            this.Size = new System.Drawing.Size(255, 100);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.CheckBox directionRB_LTCheckBox;
        internal System.Windows.Forms.CheckBox directionLB_RTCheckBox;
        internal System.Windows.Forms.CheckBox directionRT_LBCheckBox;
        internal System.Windows.Forms.CheckBox directionLT_RBCheckBox;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox directionAngle45CheckBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.CheckBox directionTBCheckBox;
        internal System.Windows.Forms.CheckBox directionRLCheckBox;
        internal System.Windows.Forms.CheckBox directionBTCheckBox;
        internal System.Windows.Forms.CheckBox directionLRCheckBox;
        internal System.Windows.Forms.Label label6;
    }
}