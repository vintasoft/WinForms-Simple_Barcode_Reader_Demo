using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Vintasoft.Barcode;
using Vintasoft.Barcode.SymbologySubsets.RoyalMailMailmark;
using Vintasoft.Barcode.SymbologySubsets;
using Vintasoft.Barcode.SymbologySubsets.GS1;
using Vintasoft.Barcode.SymbologySubsets.XFACompressed;

namespace BarcodeDemo
{
    /// <summary>
    /// Editor control of ReaderSettings.ScanBarcodeTypes property.
    /// </summary>
    public partial class BarcodeTypesReaderSettingsControl : ReaderSettingsEditorControl
    {

        #region Fields

        bool _enableSetSettings = true;

        #endregion



        #region Constructors

        public BarcodeTypesReaderSettingsControl()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        bool _showUnknownLinearSettings = true;
        [DefaultValue(true)]
        public bool ShowUnknownLinearSettings
        {
            get
            {
                return _showUnknownLinearSettings;
            }
            set
            {
                _showUnknownLinearSettings = value;
                if (value)
                    linearTabControl.TabPages.Add(unknownLinearTabPage);
                else
                    linearTabControl.TabPages.Remove(unknownLinearTabPage);
            }
        }
      
        bool _highlightOptionalChecksumBarcodes = false;
        [DefaultValue(false)]
        public bool HighlightOptionalChecksumBarcodes
        {
            get
            {
                return _highlightOptionalChecksumBarcodes;
            }
            set
            {
                _highlightOptionalChecksumBarcodes = value;
                Color foreColor;
                if (value)
                    foreColor = Color.Red;
                else
                    foreColor = Color.Black;
                barcodeI25CheckBox.ForeColor = foreColor;
                barcodeS25CheckBox.ForeColor = foreColor;
                barcodeCode39CheckBox.ForeColor = foreColor;
                barcodeMatrix2of5CheckBox.ForeColor = foreColor;
            }
        }

        #endregion



        #region Methods

        private void barcodeTypesAllOrClear_Click(object sender, EventArgs e)
        {
            _enableSetSettings = false;
            ControlCollection controls = ((TabPage)((Button)sender).Parent).Controls;
            bool value = false;
            foreach (Control c in controls)
                if (c is CheckBox)
                {
                    value = !(c as CheckBox).Checked;
                    break;
                }
            foreach (Control c in controls)
                if (c is CheckBox)
                    (c as CheckBox).Checked = value;
            _enableSetSettings = true;
            SetSettings();
        }

        private void barcodeTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void unknownLinearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetSettings();
        }


        /// <summary>
        /// Updates the UI.
        /// </summary>
        public override void UpdateUI()
        {
            _enableSetSettings = false;

            // barcode types
            BarcodeType scanBarcodeTypes = BarcodeReaderSettings.ScanBarcodeTypes;
            barcodeCode11CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Code11) != 0;
            barcodeMSICheckBox.Checked = (scanBarcodeTypes & BarcodeType.MSI) != 0;
            barcodeCode39CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Code39) != 0;
            barcodeCode93CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Code93) != 0;
            barcodeCode128CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Code128) != 0;
            barcodeCode16KCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Code16K) != 0;
            barcodeCodabarCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Codabar) != 0;
            barcodeEAN13CheckBox.Checked = (scanBarcodeTypes & BarcodeType.EAN13) != 0;
            barcodeEAN8CheckBox.Checked = (scanBarcodeTypes & BarcodeType.EAN8) != 0;
            barcodePlus5CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Plus5) != 0;
            barcodePlus2CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Plus2) != 0;
            barcodeI25CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Interleaved2of5) != 0;
            barcodeS25CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Standard2of5) != 0;
            barcodeIata2of5CheckBox.Checked = (scanBarcodeTypes & BarcodeType.IATA2of5) != 0;
            barcodeMatrix2of5CheckBox.Checked = (scanBarcodeTypes & BarcodeType.Matrix2of5) != 0;
            barcodeUPCACheckBox.Checked = (scanBarcodeTypes & BarcodeType.UPCA) != 0;
            barcodeUPCECheckBox.Checked = (scanBarcodeTypes & BarcodeType.UPCE) != 0;
            barcodeAustraliaPostCheckBox.Checked = (scanBarcodeTypes & BarcodeType.AustralianPost) != 0;
            barcodeTelepenCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Telepen) != 0;
            barcodePlanetCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Planet) != 0;
            barcodeIntelligentMailCheckBox.Checked = (scanBarcodeTypes & BarcodeType.IntelligentMail) != 0;
            barcodePostnetCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Postnet) != 0;
            barcodeRoyalMailCheckBox.Checked = (scanBarcodeTypes & BarcodeType.RoyalMail) != 0;
            barcodeDutchKIXCheckBox.Checked = (scanBarcodeTypes & BarcodeType.DutchKIX) != 0;
            barcodePatchCodeCheckBox.Checked = (scanBarcodeTypes & BarcodeType.PatchCode) != 0;
            barcodePDF417CheckBox.Checked = ((scanBarcodeTypes & BarcodeType.PDF417) != 0) || ((scanBarcodeTypes & BarcodeType.PDF417Compact) != 0);
            barcodeMicroPDF417CheckBox.Checked = (scanBarcodeTypes & BarcodeType.MicroPDF417) != 0;
            barcodeDataMatrixCheckBox.Checked = (scanBarcodeTypes & BarcodeType.DataMatrix) != 0;
            barcodeQRCheckBox.Checked = (scanBarcodeTypes & BarcodeType.QR) != 0;
            barcodeMicroQRCheckBox.Checked = (scanBarcodeTypes & BarcodeType.MicroQR) != 0;
            barcodeMaxicodeCheckBox.Checked = (scanBarcodeTypes & BarcodeType.MaxiCode) != 0;
            barcodeRSS14CheckBox.Checked = (scanBarcodeTypes & BarcodeType.RSS14) != 0;
            barcodeRSSLimitedCheckBox.Checked = (scanBarcodeTypes & BarcodeType.RSSLimited) != 0;
            barcodeRSSExpandedCheckBox.Checked = (scanBarcodeTypes & BarcodeType.RSSExpanded) != 0;
            barcodeRSS14StackedCheckBox.Checked = (scanBarcodeTypes & BarcodeType.RSS14Stacked) != 0;
            barcodeRSSExpandedStackedCheckBox.Checked = (scanBarcodeTypes & BarcodeType.RSSExpandedStacked) != 0;
            barcodeAztecCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Aztec) != 0;
            barcodePharmacodeCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Pharmacode) != 0;
            barcodeUnknownLinearCheckBox.Checked = (scanBarcodeTypes & BarcodeType.UnknownLinear) != 0;
            barcodeMailmark4CCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Mailmark4StateC) != 0;
            barcodeMailmark4LCheckBox.Checked = (scanBarcodeTypes & BarcodeType.Mailmark4StateL) != 0;
            barcodeHanXinCodeCheckBox.Checked = (scanBarcodeTypes & BarcodeType.HanXinCode) != 0;

            // barcode subsets
            barcodeGs1_128CheckBox.Checked = false;
            barcodeGs1DataBarCheckBox.Checked = false;
            barcodeGs1DataBarExpandedCheckBox.Checked = false;
            barcodeGs1DataBarExpandedStackedCheckBox.Checked = false;
            barcodeGs1DataBarLimitedCheckBox.Checked = false;
            barcodeGs1DataBarStackedCheckBox.Checked = false;
            barcodeGs1QRCheckbox.Checked = false;
            barcodeGs1DataMatrixCheckBox.Checked = false;
            barcodeGs1AztecCheckBox.Checked = false;
            barcodeMailmarkCmdmType7CheckBox.Checked = false;
            barcodeMailmarkCmdmType9CheckBox.Checked = false;
            barcodeMailmarkCmdmType29CheckBox.Checked = false;
            foreach (BarcodeSymbologySubset subset in BarcodeReaderSettings.ScanBarcodeSubsets)
            {
                if (subset is GS1_128BarcodeSymbology)
                    barcodeGs1_128CheckBox.Checked = true;
                if (subset is GS1DataBarBarcodeSymbology)
                    barcodeGs1DataBarCheckBox.Checked = true;
                if (subset is GS1DataBarExpandedBarcodeSymbology)
                    barcodeGs1DataBarExpandedCheckBox.Checked = true;
                if (subset is GS1DataBarExpandedStackedBarcodeSymbology)
                    barcodeGs1DataBarExpandedStackedCheckBox.Checked = true;
                if (subset is GS1DataBarLimitedBarcodeSymbology)
                    barcodeGs1DataBarLimitedCheckBox.Checked = true;
                if (subset is GS1DataBarStackedBarcodeSymbology)
                    barcodeGs1DataBarStackedCheckBox.Checked = true;
                if (subset is GS1QRBarcodeSymbology)
                    barcodeGs1QRCheckbox.Checked = true;
                if (subset is GS1DataMatrixBarcodeSymbology)
                    barcodeGs1DataMatrixCheckBox.Checked = true;
                if (subset is GS1AztecBarcodeSymbology)
                    barcodeGs1AztecCheckBox.Checked = true;
                if (subset is MailmarkCmdmType7BarcodeSymbology)
                    barcodeMailmarkCmdmType7CheckBox.Checked = true;
                if (subset is MailmarkCmdmType9BarcodeSymbology)
                    barcodeMailmarkCmdmType9CheckBox.Checked = true;
                if (subset is MailmarkCmdmType29BarcodeSymbology)
                    barcodeMailmarkCmdmType29CheckBox.Checked = true;
                if (subset is Code32BarcodeSymbology)
                    barcodeCode32CheckBox.Checked = true;
                if (subset is VinSymbology)
                    barcodeVinCheckBox.Checked = true;
                if (subset is PznBarcodeSymbology)
                    barcodePznCheckBox.Checked = true;
                if (subset is Code39ExtendedBarcodeSymbology)
                    barcodeCode39ExtendedCheckBox.Checked = true;
                if (subset is OpcBarcodeSymbology)
                    barcodeOpcCheckBox.Checked = true;
                if (subset is Itf14BarcodeSymbology)
                    barcodeItf14CheckBox.Checked = true;
                if (subset is DeutschePostIdentcodeBarcodeSymbology)
                    barcodeDeutschePostIdentcodeCheckBox.Checked = true;
                if (subset is DeutschePostLeitcodeBarcodeSymbology)
                    barcodeDeutschePostLeitcodeCheckBox.Checked = true;
                if (subset is Sscc18BarcodeSymbology)
                    barcodeSscc18CheckBox.Checked = true;
                if (subset is Jan13BarcodeSymbology)
                    barcodeJan13CheckBox.Checked = true;
                if (subset is Jan8BarcodeSymbology)
                    barcodeJan8CheckBox.Checked = true;
                if (subset is Jan13Plus5BarcodeSymbology)
                {
                    barcodeJan13CheckBox.Checked = true;
                    barcodePlus5CheckBox.Checked = true;
                }
                if (subset is Jan13Plus2BarcodeSymbology)
                {
                    barcodeJan13CheckBox.Checked = true;
                    barcodePlus2CheckBox.Checked = true;
                }
                if (subset is Jan8BarcodeSymbology)
                    barcodeJan8CheckBox.Checked = true;
                if (subset is Jan8Plus5BarcodeSymbology)
                {
                    barcodeJan8CheckBox.Checked = true;
                    barcodePlus5CheckBox.Checked = true;
                }
                if (subset is Jan8Plus2BarcodeSymbology)
                {
                    barcodeJan8CheckBox.Checked = true;
                    barcodePlus2CheckBox.Checked = true;
                }
                if (subset is IsbnBarcodeSymbology)
                    barcodeIsbnCheckBox.Checked = true;
                if (subset is IsbnPlus2BarcodeSymbology)
                {
                    barcodeIsbnCheckBox.Checked = true;
                    barcodePlus2CheckBox.Checked = true;
                }
                if (subset is IsbnPlus5BarcodeSymbology)
                {
                    barcodeIsbnCheckBox.Checked = true;
                    barcodePlus5CheckBox.Checked = true;
                }
                if (subset is IsmnBarcodeSymbology)
                    barcodeIsmnCheckBox.Checked = true;
                if (subset is IsmnPlus2BarcodeSymbology)
                {
                    barcodeIsmnCheckBox.Checked = true;
                    barcodePlus2CheckBox.Checked = true;
                }
                if (subset is IsmnPlus5BarcodeSymbology)
                {
                    barcodeIsmnCheckBox.Checked = true;
                    barcodePlus5CheckBox.Checked = true;
                }
                if (subset is IssnBarcodeSymbology)
                    barcodeIssnCheckBox.Checked = true;
                if (subset is IssnPlus2BarcodeSymbology)
                {
                    barcodeIssnCheckBox.Checked = true;
                    barcodePlus2CheckBox.Checked = true;
                }
                if (subset is IssnPlus5BarcodeSymbology)
                {
                    barcodeIssnCheckBox.Checked = true;
                    barcodePlus5CheckBox.Checked = true;
                }
                if (subset is SwissPostParcelBarcodeSymbology)
                    barcodeSwissPostParcelCheckBox.Checked = true;
                if (subset is PpnBarcodeSymbology)
                    barcodePpnCheckBox.Checked = true;
                if (subset is EanVelocityBarcodeSymbology)
                    barcodeEanVelocityCheckBox.Checked = true;
                if (subset is NumlyNumberBarcodeSymbology)
                    barcodeNumlyNumberCheckBox.Checked = true;
                if (subset is FedExGround96BarcodeSymbology)
                    barcodeFedExGround96CheckBox.Checked = true;
                if (subset is VicsBolBarcodeSymbology)
                    barcodeVicsBolCheckBox.Checked = true;
                if (subset is VicsScacProBarcodeSymbology)
                    barcodeVicsScacProCheckBox.Checked = true;
                if (subset is DhlAwbBarcodeSymbology)
                    barcodeDhlAwbCheckBox.Checked = true;
                if (subset is XFACompressedAztecBarcodeSymbology)
                    barcodeXFACompressedAztecCheckBox.Checked = true;
                if (subset is XFACompressedDataMatrixBarcodeSymbology)
                    barcodeXFACompressedDataMatrixCheckBox.Checked = true;
                if (subset is XFACompressedPDF417BarcodeSymbology)
                    barcodeXFACompressedPDF417CheckBox.Checked = true;
                if (subset is XFACompressedQRCodeBarcodeSymbology)
                    barcodeXFACompressedQRCheckBox.Checked = true;
            }

            unknownLinearMaxBarsNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMaxBars;
            unknownLinearMinBarsNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMinBars;
            unknownLinearMaxBarWideNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMaxBarWide;
            unknownLinearMinScanlinesNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMinScanlines;

            _enableSetSettings = true;
        }

        private void SetSettings()
        {
            if (!_enableSetSettings)
                return;

            BarcodeType scanBarcodeTypes = BarcodeType.None;
            if (barcodeCode11CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Code11;
            if (barcodeMSICheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.MSI;
            if (barcodeCode39CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Code39;
            if (barcodeCode93CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Code93;
            if (barcodeCode128CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Code128;
            if (barcodeCode16KCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Code16K;
            if (barcodeCodabarCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Codabar;
            if (barcodeEAN13CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.EAN13;
            if (barcodeEAN8CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.EAN8;
            if (barcodePlus5CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Plus5;
            if (barcodePlus2CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Plus2;
            if (barcodeI25CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Interleaved2of5;
            if (barcodeS25CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Standard2of5;
            if (barcodeIata2of5CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.IATA2of5;
            if (barcodeMatrix2of5CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Matrix2of5;
            if (barcodeUPCACheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.UPCA;
            if (barcodeUPCECheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.UPCE;
            if (barcodeTelepenCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Telepen;
            if (barcodeUnknownLinearCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.UnknownLinear;
            if (barcodePlanetCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Planet;
            if (barcodeIntelligentMailCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.IntelligentMail;
            if (barcodePostnetCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Postnet;
            if (barcodeRoyalMailCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RoyalMail;
            if (barcodeDutchKIXCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.DutchKIX;
            if (barcodePatchCodeCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.PatchCode;
            if (barcodePharmacodeCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Pharmacode;
            if (barcodePDF417CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.PDF417 | BarcodeType.PDF417Compact;
            if (barcodeMicroPDF417CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.MicroPDF417;
            if (barcodeDataMatrixCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.DataMatrix;
            if (barcodeQRCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.QR;
            if (barcodeMicroQRCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.MicroQR;
            if (barcodeMaxicodeCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.MaxiCode;
            if (barcodeRSS14CheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSS14;
            if (barcodeRSSLimitedCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSSLimited;
            if (barcodeRSSExpandedCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSSExpanded;
            if (barcodeRSSExpandedStackedCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSSExpandedStacked;
            if (barcodeRSS14StackedCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSS14Stacked;
            if (barcodeAztecCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Aztec;
            if (barcodeRSS14StackedCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.RSS14Stacked;
            if (barcodeAustraliaPostCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.AustralianPost;
            if (barcodeMailmark4CCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Mailmark4StateC;
            if (barcodeMailmark4LCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.Mailmark4StateL;
            if (barcodeHanXinCodeCheckBox.Checked)
                scanBarcodeTypes |= BarcodeType.HanXinCode;

            BarcodeReaderSettings.ScanBarcodeTypes = scanBarcodeTypes;

            BarcodeReaderSettings.ScanBarcodeSubsets.Clear();
            if (barcodeGs1_128CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1_128);
            if (barcodeGs1DataBarCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBar);
            if (barcodeGs1DataBarExpandedCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpanded);
            if (barcodeGs1DataBarExpandedStackedCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked);
            if (barcodeGs1DataBarLimitedCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarLimited);
            if (barcodeGs1DataBarStackedCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarStacked);
            if (barcodeGs1QRCheckbox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1QR);
            if (barcodeGs1DataMatrixCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataMatrix);
            if (barcodeGs1AztecCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1Aztec);
            if (barcodeMailmarkCmdmType7CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType7);
            if (barcodeMailmarkCmdmType9CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType9);
            if (barcodeMailmarkCmdmType29CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType29);
            if (barcodeCode32CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code32);
            if (barcodeVinCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VIN);
            if (barcodePznCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PZN);
            if (barcodeCode39ExtendedCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code39Extended);
            if (barcodeOpcCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.OPC);
            if (barcodeItf14CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ITF14);
            if (barcodeDeutschePostIdentcodeCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostIdentcode);
            if (barcodeDeutschePostLeitcodeCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostLeitcode);
            if (barcodeSscc18CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SSCC18);
            if (barcodeJan13CheckBox.Checked)
            {
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13);
                if ((scanBarcodeTypes & BarcodeType.Plus5) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus5);
                if ((scanBarcodeTypes & BarcodeType.Plus2) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus2);
            }
            if (barcodeJan8CheckBox.Checked)
            {
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8);
                if ((scanBarcodeTypes & BarcodeType.Plus5) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus5);
                if ((scanBarcodeTypes & BarcodeType.Plus2) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus2);
            }
            if (barcodeIsbnCheckBox.Checked)
            {
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBN);
                if ((scanBarcodeTypes & BarcodeType.Plus5) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus5);
                if ((scanBarcodeTypes & BarcodeType.Plus2) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus2);
            }
            if (barcodeIsmnCheckBox.Checked)
            {
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMN);
                if ((scanBarcodeTypes & BarcodeType.Plus5) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus5);
                if ((scanBarcodeTypes & BarcodeType.Plus2) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus2);
            }
            if (barcodeIssnCheckBox.Checked)
            {
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSN);
                if ((scanBarcodeTypes & BarcodeType.Plus5) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus5);
                if ((scanBarcodeTypes & BarcodeType.Plus2) != 0)
                    BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus2);
            }
            if (barcodeSwissPostParcelCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SwissPostParcel);
            if (barcodePpnCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PPN);
            if (barcodeEanVelocityCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.EANVelocity);
            if (barcodeNumlyNumberCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.NumlyNumber);
            if (barcodeFedExGround96CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.FedExGround96);
            if (barcodeVicsBolCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsBol);
            if (barcodeVicsScacProCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsScacPro);
            if (barcodeDhlAwbCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DhlAwb);
            if (barcodeXFACompressedAztecCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedAztec);
            if (barcodeXFACompressedDataMatrixCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix);
            if (barcodeXFACompressedPDF417CheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedPDF417);
            if (barcodeXFACompressedQRCheckBox.Checked)
                BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedQRCode);

            BarcodeReaderSettings.UnknownLinearMaxBars = (int)unknownLinearMaxBarsNumericUpDown.Value;
            BarcodeReaderSettings.UnknownLinearMinBars = (int)unknownLinearMinBarsNumericUpDown.Value;
            BarcodeReaderSettings.UnknownLinearMaxBarWide = (int)unknownLinearMaxBarWideNumericUpDown.Value;
            BarcodeReaderSettings.UnknownLinearMinScanlines = (int)unknownLinearMinScanlinesNumericUpDown.Value;


            OnSettingsChanged();
        }

        private void OnSettingsChanged()
        {
            if (SettingsChanged != null)
                SettingsChanged(this, EventArgs.Empty);
        }

        #endregion



        #region Events

        public event EventHandler SettingsChanged;

        #endregion

      
    }
}
