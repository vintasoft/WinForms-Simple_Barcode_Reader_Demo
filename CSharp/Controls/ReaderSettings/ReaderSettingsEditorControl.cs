using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// Represents a base class of barcode reader settings editor.
    /// </summary>
    public class ReaderSettingsEditorControl: UserControl
    {

        #region Properties

        ReaderSettings _barcodeReaderSettings = new ReaderSettings();
        /// <summary>
        /// Gets or sets a barcode reader settings.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]       
        public ReaderSettings BarcodeReaderSettings
        {
            get
            {
                return _barcodeReaderSettings;
            }
            set
            {
                _barcodeReaderSettings = value;
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        public void SetBarcodeReaderSettings(ReaderSettings settings)
        {
            _barcodeReaderSettings = settings;
            OnBarcodeReaderSettingsChanged(EventArgs.Empty);
        }

        public virtual void UpdateUI()
        {
        }

        protected virtual void OnBarcodeReaderSettingsChanged(EventArgs e)
        {
            UpdateUI();
        }

        #endregion

    }
}
