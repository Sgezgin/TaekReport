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
            this.lblTup = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLab = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarihSaat = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdiSoyadi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTup,
            this.lblLab,
            this.lblTarihSaat,
            this.lblAdiSoyadi,
            this.xrBarCode1});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 295F;
            this.TopMargin.Name = "TopMargin";
            // 
            // lblTup
            // 
            this.lblTup.Dpi = 254F;
            this.lblTup.Font = new System.Drawing.Font("Arial", 8F);
            this.lblTup.LocationFloat = new DevExpress.Utils.PointFloat(42.99995F, 248.4395F);
            this.lblTup.Multiline = true;
            this.lblTup.Name = "lblTup";
            this.lblTup.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTup.SizeF = new System.Drawing.SizeF(457.0001F, 35.07443F);
            this.lblTup.StylePriority.UseFont = false;
            this.lblTup.Text = "Tüp Bilgisi";
            // 
            // lblLab
            // 
            this.lblLab.Dpi = 254F;
            this.lblLab.Font = new System.Drawing.Font("Arial", 8F);
            this.lblLab.LocationFloat = new DevExpress.Utils.PointFloat(42.99995F, 209.3342F);
            this.lblLab.Multiline = true;
            this.lblLab.Name = "lblLab";
            this.lblLab.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblLab.SizeF = new System.Drawing.SizeF(457.0001F, 35.07445F);
            this.lblLab.StylePriority.UseFont = false;
            this.lblLab.Text = "Lab.Bilgisi";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Dpi = 254F;
            this.lblTarihSaat.Font = new System.Drawing.Font("Arial", 8F);
            this.lblTarihSaat.LocationFloat = new DevExpress.Utils.PointFloat(42.99995F, 172.0564F);
            this.lblTarihSaat.Multiline = true;
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarihSaat.SizeF = new System.Drawing.SizeF(457.0001F, 35.07445F);
            this.lblTarihSaat.StylePriority.UseFont = false;
            this.lblTarihSaat.Text = "18.05.2022 12.16";
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.Dpi = 254F;
            this.lblAdiSoyadi.Font = new System.Drawing.Font("Arial", 8F);
            this.lblAdiSoyadi.LocationFloat = new DevExpress.Utils.PointFloat(42.99995F, 136.9819F);
            this.lblAdiSoyadi.Multiline = true;
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAdiSoyadi.SizeF = new System.Drawing.SizeF(457.0001F, 35.07443F);
            this.lblAdiSoyadi.StylePriority.UseFont = false;
            this.lblAdiSoyadi.Text = "Süleyman Suphi Gezgin";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.Dpi = 254F;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(33.99986F, 7.882796F);
            this.xrBarCode1.Module = 4F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(397.6043F, 115.645F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 0F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // rprTupBarkod
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 295, 0);
            this.PageHeight = 300;
            this.PageWidth = 500;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
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
