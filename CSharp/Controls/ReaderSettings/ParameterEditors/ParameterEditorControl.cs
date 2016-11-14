using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// Represents a base class of a parameter editor.
    /// </summary>
    public partial class ParameterEditorControl : ReaderSettingsEditorControl
    {

        #region Fields

        bool _setValueEnabled = false;

        #endregion



        #region Constructor

        public ParameterEditorControl()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a title.
        /// </summary>
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
        public virtual int Value
        {
            get
            {
                return valueTrackBar.Value;
            }
            set
            {
                valueTrackBar.Value = value;                
            }
        }

        /// <summary>
        /// Gets or sets a value of TrackBar.TickFrequency property.
        /// </summary>
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

        public virtual string GetValueAsString()
        {
            return Value.ToString();
        }

        protected virtual void OnValueChanged()
        {
            Value = valueTrackBar.Value;
            valueLabel.Text = GetValueAsString();
            if(ValueChanged!=null)
                ValueChanged(this, EventArgs.Empty);
        }

        public override void UpdateUI()
        {
            _setValueEnabled = false;
            valueTrackBar.Value = Value;
            valueLabel.Text = GetValueAsString();
            _setValueEnabled = true;
        }

        private void valueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (_setValueEnabled)
                OnValueChanged();
        }

        #endregion



        #region Events

        public event EventHandler ValueChanged;

        #endregion

    }
}
