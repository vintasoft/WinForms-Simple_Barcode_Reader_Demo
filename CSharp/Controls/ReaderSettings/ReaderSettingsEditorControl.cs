using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A base class for controls that allow to change the barcode reader settings.
    /// </summary>
    public class ReaderSettingsEditorControl : UserControl
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
        }

        #endregion



        #region Methods

        /// <summary>
        /// Sets the barcode reader settings.
        /// </summary>
        /// <param name="settings">The reader settings.</param>
        public void SetBarcodeReaderSettings(ReaderSettings settings)
        {
            _barcodeReaderSettings = settings;
            OnBarcodeReaderSettingsChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        public virtual void UpdateUI()
        {
        }

        /// <summary>
        /// Called when barcode reader settings changed.
        /// </summary>
        protected virtual void OnBarcodeReaderSettingsChanged(EventArgs e)
        {
            UpdateUI();
        }

        #endregion

    }
}
