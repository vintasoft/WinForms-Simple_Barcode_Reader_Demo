using System.ComponentModel;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that allows to change the ReaderSettings.ScanInterval parameter.
    /// </summary>
    public class ScanIntervalEditorControl : ParameterEditorControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanIntervalEditorControl"/> class.
        /// </summary>
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
