namespace TaekReport.Ozgecmis
{
    partial class rprOzgecmis
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSoyadi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35.41667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 45.83333F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblAdres,
            this.lblSoyadi,
            this.lblAdi});
            this.Detail.HeightF = 213.5417F;
            this.Detail.Name = "Detail";
            // 
            // lblAdi
            // 
            this.lblAdi.LocationFloat = new DevExpress.Utils.PointFloat(61.41666F, 29.12499F);
            this.lblAdi.Multiline = true;
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblAdi.SizeF = new System.Drawing.SizeF(253.125F, 23F);
            this.lblAdi.Text = "lblAdi";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.LocationFloat = new DevExpress.Utils.PointFloat(61.41666F, 83.29166F);
            this.lblSoyadi.Multiline = true;
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSoyadi.SizeF = new System.Drawing.SizeF(253.125F, 23F);
            this.lblSoyadi.Text = "xrLabel1";
            // 
            // lblAdres
            // 
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(61.41666F, 143.7083F);
            this.lblAdres.Multiline = true;
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(253.125F, 23F);
            this.lblAdres.Text = "xrLabel1";
            // 
            // rprOzgecmis
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(49, 75, 35, 46);
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblSoyadi;
        private DevExpress.XtraReports.UI.XRLabel lblAdi;
    }
}
