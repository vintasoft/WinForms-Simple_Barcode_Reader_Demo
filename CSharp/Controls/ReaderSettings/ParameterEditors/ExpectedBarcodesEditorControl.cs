namespace BarcodeDemo
{
    /// <summary>
    /// Represents an editor control of ReaderSettings.ExpectedBarcodes parameter.
    /// </summary>
    public class ExpectedBarcodesEditorControl : ParameterEditorControl
    {
        
        #region Constructors

        public ExpectedBarcodesEditorControl()
        {
            Minimum = 1;
            Maximum = 72;
            Value = 1;
            Title = "Expected barcodes";
            TickFrequency = 2;
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
                return BarcodeReaderSettings.ExpectedBarcodes;
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.ExpectedBarcodes = value;
            }
        }

        #endregion

    }
}
