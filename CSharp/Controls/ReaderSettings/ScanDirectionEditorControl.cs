using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that allows to chnage the barcode scan direction for barcode reader.
    /// </summary>
    public partial class ScanDirectionEditorControl : ReaderSettingsEditorControl
    {

        #region Fields

        /// <summary>
        /// Indicates that the barcode reader settings can be changed.
        /// </summary>
        bool _enableSetSettings = true;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanDirectionEditorControl"/> class.
        /// </summary>
        public ScanDirectionEditorControl()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Updates the "Direction 45/135" controls.
        /// </summary>
        private void UpdateDirection45()
        {
            bool direction45 = directionAngle45CheckBox.Checked;
            directionLB_RTCheckBox.Visible = direction45;
            directionLT_RBCheckBox.Visible = direction45;
            directionRB_LTCheckBox.Visible = direction45;
            directionRT_LBCheckBox.Visible = direction45;
            if (directionAngle45CheckBox.Checked)
            {
                directionLT_RBCheckBox.Checked = directionLRCheckBox.Checked || directionTBCheckBox.Checked;
                directionRT_LBCheckBox.Checked = directionTBCheckBox.Checked || directionRLCheckBox.Checked;
                directionLB_RTCheckBox.Checked = directionLRCheckBox.Checked || directionBTCheckBox.Checked;
                directionRB_LTCheckBox.Checked = directionBTCheckBox.Checked || directionRLCheckBox.Checked;
            }
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        public override void UpdateUI()
        {
            _enableSetSettings = false;

            ScanDirection scanDirection = BarcodeReaderSettings.ScanDirection;
            directionLRCheckBox.Checked = (scanDirection & ScanDirection.LeftToRight) != 0;
            directionRLCheckBox.Checked = (scanDirection & ScanDirection.RightToLeft) != 0;
            directionTBCheckBox.Checked = (scanDirection & ScanDirection.TopToBottom) != 0;
            directionBTCheckBox.Checked = (scanDirection & ScanDirection.BottomToTop) != 0;

            directionAngle45CheckBox.Checked = (scanDirection & ScanDirection.Angle45and135) != 0;
            UpdateDirection45();

            _enableSetSettings = true;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the Direction control.
        /// </summary>
        private void direction_CheckedChanged(object sender, EventArgs e)
        {
            SetDirection();
        }

        /// <summary>
        /// Sets the scan direction of reader settings.
        /// </summary>
        private void SetDirection()
        {
            if (!_enableSetSettings)
                return;

            _enableSetSettings = false;

            UpdateDirection45();

            ScanDirection scanDirection = ScanDirection.None;
            if (directionLRCheckBox.Checked)
                scanDirection |= ScanDirection.LeftToRight;
            if (directionRLCheckBox.Checked)
                scanDirection |= ScanDirection.RightToLeft;
            if (directionTBCheckBox.Checked)
                scanDirection |= ScanDirection.TopToBottom;
            if (directionBTCheckBox.Checked)
                scanDirection |= ScanDirection.BottomToTop;
            if (directionAngle45CheckBox.Checked)
                scanDirection |= ScanDirection.Angle45and135;

            BarcodeReaderSettings.ScanDirection = scanDirection;

            _enableSetSettings = true;
        }

        #endregion

    }
}
