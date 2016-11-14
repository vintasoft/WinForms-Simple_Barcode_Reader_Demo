namespace BarcodeDemo
{
    /// <summary>
    /// Represents an editor control of ReaderSettings.ScanInterval parameter.
    /// </summary>
    public class ScanIntervalEditorControl : ParameterEditorControl
    {
        
        #region Constructors

        public ScanIntervalEditorControl()
        {
            Minimum = 1;
            Maximum = 25;
            Value = 5;
            Title = "Scan interval";
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a property value.
        /// </summary>
        public override int Value
        {
            get
            {
                return BarcodeReaderSettings.ScanInterval;
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.ScanInterval = value;
            }
        }

        #endregion

    }
}
