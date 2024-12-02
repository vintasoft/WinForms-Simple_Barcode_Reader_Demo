using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A base class for controls that allow to change a single parameter.
    /// </summary>
    public partial class ParameterEditorControl : ReaderSettingsEditorControl
    {

        #region Fields

        /// <summary>
        /// Indicates that value can be set.
        /// </summary>
        bool _setValueEnabled = true;

        #endregion



        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterEditorControl"/> class.
        /// </summary>
        public ParameterEditorControl()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a title.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get
            {
                return valueGroupBox.Text;
            }
            set
            {
                valueGroupBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets a minimum value.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Minimum
        {
            get
            {
                return valueTrackBar.Minimum; 
            }
            set
            {
                valueTrackBar.Minimum = value;
            }
        }

        /// <summary>
        /// Gets or sets a maximum value.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get
            {
                return valueTrackBar.Maximum;
            }
            set
            {
                valueTrackBar.Maximum = value;
            }
        }

        /// <summary>
        /// Gets or sets a property value.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual int Value
        {
            get
            {
                return valueTrackBar.Value;
            }
            set
            {
                valueTrackBar.Value = Math.Max(Minimum, Math.Min(Maximum, value));
            }
        }

        /// <summary>
        /// Gets or sets a value of TrackBar.TickFrequency property.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int TickFrequency
        {
            get
            {
                return valueTrackBar.TickFrequency;
            }
            set
            {
                valueTrackBar.TickFrequency = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns the value as a string.
        /// </summary>
        public virtual string GetValueAsString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Called when value is changed.
        /// </summary>
        protected virtual void OnValueChanged()
        {
            Value = valueTrackBar.Value;
            valueLabel.Text = GetValueAsString();
            if(ValueChanged!=null)
                ValueChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Called when the barcode reader settings is changed.
        /// </summary>
        protected override void OnBarcodeReaderSettingsChanged(EventArgs e)
        {
            base.OnBarcodeReaderSettingsChanged(e);
            OnValueChanged();
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        public override void UpdateUI()
        {
            _setValueEnabled = false;            
            valueTrackBar.Value = Value;
            valueLabel.Text = GetValueAsString();
            _setValueEnabled = true;
        }

        /// <summary>
        /// Handles the ValueChanged event of the valueTrackBar control.
        /// </summary>
        private void valueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (_setValueEnabled)
                OnValueChanged();
        }

        #endregion



        #region Events

        /// <summary>
        /// Occurs when parameter value is changed.
        /// </summary>
        public event EventHandler ValueChanged;

        #endregion

    }
}
