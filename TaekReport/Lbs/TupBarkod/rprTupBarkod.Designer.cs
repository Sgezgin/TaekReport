namespace TaekReport.Lbs.TupBarkod
{
    partial class rprTupBarkod
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.lblAdiSoyadi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarihSaat = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLab = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTup = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 9F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTup,
            this.lblLab,
            this.lblTarihSaat,
            this.lblAdiSoyadi,
            this.xrBarCode1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 299.8611F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Dpi = 254F;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(6.000064F, 7.34723F);
            this.xrBarCode1.Module = 5.08F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(508F, 130.5278F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.Dpi = 254F;
            this.lblAdiSoyadi.Font = new System.Drawing.Font("Arial", 8F);
            this.lblAdiSoyadi.LocationFloat = new DevExpress.Utils.PointFloat(6.000165F, 151.3292F);
            this.lblAdiSoyadi.Multiline = true;
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblAdiSoyadi.SizeF = new System.Drawing.SizeF(507.9998F, 35.07443F);
            this.lblAdiSoyadi.StylePriority.UseFont = false;
            this.lblAdiSoyadi.Text = "Süleyman Suphi Gezgin";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Dpi = 254F;
            this.lblTarihSaat.Font = new System.Drawing.Font("Arial", 8F);
            this.lblTarihSaat.LocationFloat = new DevExpress.Utils.PointFloat(6F, 186.4036F);
            this.lblTarihSaat.Multiline = true;
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarihSaat.SizeF = new System.Drawing.SizeF(507.9998F, 35.07443F);
            this.lblTarihSaat.StylePriority.UseFont = false;
            this.lblTarihSaat.Text = "18.05.2022 12.16";
            // 
            // lblLab
            // 
            this.lblLab.Dpi = 254F;
            this.lblLab.Font = new System.Drawing.Font("Arial", 8F);
            this.lblLab.LocationFloat = new DevExpress.Utils.PointFloat(6.000064F, 225.6814F);
            this.lblLab.Multiline = true;
            this.lblLab.Name = "lblLab";
            this.lblLab.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblLab.SizeF = new System.Drawing.SizeF(507.9998F, 35.07443F);
            this.lblLab.StylePriority.UseFont = false;
            this.lblLab.Text = "Lab.Bilgisi";
            // 
            // lblTup
            // 
            this.lblTup.Dpi = 254F;
            this.lblTup.Font = new System.Drawing.Font("Arial", 8F);
            this.lblTup.LocationFloat = new DevExpress.Utils.PointFloat(6.000064F, 264.7867F);
            this.lblTup.Multiline = true;
            this.lblTup.Name = "lblTup";
            this.lblTup.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTup.SizeF = new System.Drawing.SizeF(507.9998F, 35.07443F);
            this.lblTup.StylePriority.UseFont = false;
            this.lblTup.Text = "Tüp Bilgisi";
            // 
            // rprTupBarkod
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 1579, 0, 9);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 18;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 12F;
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel lblAdiSoyadi;
        private DevExpress.XtraReports.UI.XRLabel lblTup;
        private DevExpress.XtraReports.UI.XRLabel lblLab;
        private DevExpress.XtraReports.UI.XRLabel lblTarihSaat;
    }
}
