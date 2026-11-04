namespace TaekReport.KAEK.GozlemselIlac
{
    partial class rprGozlemselCalismalarBasvuruForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);

            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ArastirmaMerkezleri = new DevExpress.XtraReports.UI.DetailReportBand();
            this.ArastirmaMerkezleriDetay = new DevExpress.XtraReports.UI.DetailBand();
            this.DigerBilgiler = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DigerBilgilerDetay = new DevExpress.XtraReports.UI.DetailBand();
            this.ArastirmaEkibi = new DevExpress.XtraReports.UI.DetailReportBand();
            this.ArastirmaEkibiGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ArastirmaEkibiDetay = new DevExpress.XtraReports.UI.DetailBand();
            this.DegerlendirmeCizelgesi = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DegerlendirmeCizelgesiDetay = new DevExpress.XtraReports.UI.DetailBand();
            this.EtikKurul = new DevExpress.XtraReports.UI.DetailReportBand();
            this.EtikKurulDetay = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();

            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(TaekReport.KAEK.Models.RaporModel.GozlemselCalismalarBasvuruFormu);
            this.objectDataSource1.Name = "objectDataSource1";

            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";

            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";

            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 75F;
            this.PageHeader.Name = "PageHeader";

            // 
            // Detail (Çalışma Özeti)
            // 
            this.Detail.HeightF = 1000F;
            this.Detail.Name = "Detail";

            // 
            // ArastirmaMerkezleri (Çalışma Merkezleri Listesi)
            // 
            this.ArastirmaMerkezleri.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.ArastirmaMerkezleriDetay
            });
            this.ArastirmaMerkezleri.DataMember = "listArastirmaEkibi";
            this.ArastirmaMerkezleri.DataSource = this.objectDataSource1;
            this.ArastirmaMerkezleri.Level = 0;
            this.ArastirmaMerkezleri.Name = "ArastirmaMerkezleri";

            // 
            // DigerBilgiler
            // 
            this.DigerBilgiler.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.DigerBilgilerDetay
            });
            this.DigerBilgiler.Level = 1;
            this.DigerBilgiler.Name = "DigerBilgiler";

            // 
            // ArastirmaEkibi (Çalışma Ekibi Listesi)
            // 
            this.ArastirmaEkibi.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.ArastirmaEkibiGroupHeader,
                this.ArastirmaEkibiDetay
            });
            this.ArastirmaEkibi.DataMember = "listArastirmaEkibi";
            this.ArastirmaEkibi.DataSource = this.objectDataSource1;
            this.ArastirmaEkibi.Level = 2;
            this.ArastirmaEkibi.Name = "ArastirmaEkibi";

            // 
            // DegerlendirmeCizelgesi
            // 
            this.DegerlendirmeCizelgesi.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.DegerlendirmeCizelgesiDetay
            });
            this.DegerlendirmeCizelgesi.Level = 3;
            this.DegerlendirmeCizelgesi.Name = "DegerlendirmeCizelgesi";

            // 
            // EtikKurul
            // 
            this.EtikKurul.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.EtikKurulDetay
            });
            this.EtikKurul.Level = 4;
            this.EtikKurul.Name = "EtikKurul";

            // 
            // ReportFooter (İlgili Belgeler + Fiziki Belgeler + İmza)
            // 
            this.ReportFooter.HeightF = 600F;
            this.ReportFooter.Name = "ReportFooter";

            // 
            // Report settings
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                this.TopMargin,
                this.BottomMargin,
                this.PageHeader,
                this.Detail,
                this.ArastirmaMerkezleri,
                this.DigerBilgiler,
                this.ArastirmaEkibi,
                this.DegerlendirmeCizelgesi,
                this.EtikKurul,
                this.ReportFooter
            });
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
                this.objectDataSource1
            });
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 20, 25);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "20.2";

            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

        #endregion

        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.DetailReportBand ArastirmaMerkezleri;
        private DevExpress.XtraReports.UI.DetailBand ArastirmaMerkezleriDetay;
        private DevExpress.XtraReports.UI.DetailReportBand DigerBilgiler;
        private DevExpress.XtraReports.UI.DetailBand DigerBilgilerDetay;
        private DevExpress.XtraReports.UI.DetailReportBand ArastirmaEkibi;
        private DevExpress.XtraReports.UI.GroupHeaderBand ArastirmaEkibiGroupHeader;
        private DevExpress.XtraReports.UI.DetailBand ArastirmaEkibiDetay;
        private DevExpress.XtraReports.UI.DetailReportBand DegerlendirmeCizelgesi;
        private DevExpress.XtraReports.UI.DetailBand DegerlendirmeCizelgesiDetay;
        private DevExpress.XtraReports.UI.DetailReportBand EtikKurul;
        private DevExpress.XtraReports.UI.DetailBand EtikKurulDetay;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    }
}
