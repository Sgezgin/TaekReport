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
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.txtTelefon = new DevExpress.XtraReports.UI.XRLabel();
            this.txtEposta = new DevExpress.XtraReports.UI.XRLabel();
            this.txtGorevYeri = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDogumTarihi = new DevExpress.XtraReports.UI.XRLabel();
            this.txtAdiSoyadi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblYabanciDil = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35.41667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 21.875F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtTelefon,
            this.txtEposta,
            this.txtGorevYeri,
            this.txtDogumTarihi,
            this.txtAdiSoyadi,
            this.xrLabel78,
            this.xrLabel77,
            this.xrLabel76,
            this.xrLabel75,
            this.xrLabel74,
            this.xrLabel73,
            this.xrLabel72,
            this.xrLabel71,
            this.xrLabel70,
            this.xrLabel69,
            this.lblAdi,
            this.xrLabel94,
            this.xrLabel93,
            this.lblYabanciDil});
            this.Detail.HeightF = 256.25F;
            this.Detail.Name = "Detail";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(TaekReport.Models.OzgecmisModel);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // txtTelefon
            // 
            this.txtTelefon.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Telefon]")});
            this.txtTelefon.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 180.6712F);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTelefon.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // txtEposta
            // 
            this.txtEposta.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.txtEposta.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 160.7129F);
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtEposta.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // txtGorevYeri
            // 
            this.txtGorevYeri.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GorevYeri]")});
            this.txtGorevYeri.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 142.0879F);
            this.txtGorevYeri.Multiline = true;
            this.txtGorevYeri.Name = "txtGorevYeri";
            this.txtGorevYeri.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtGorevYeri.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 105.2627F);
            this.txtDogumTarihi.Multiline = true;
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtDogumTarihi.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Adi]")});
            this.txtAdiSoyadi.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 85.6794F);
            this.txtAdiSoyadi.Multiline = true;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtAdiSoyadi.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // xrLabel78
            // 
            this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(23.37494F, 180.4629F);
            this.xrLabel78.Multiline = true;
            this.xrLabel78.Name = "xrLabel78";
            this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel78.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.xrLabel78.Text = "Telefon";
            // 
            // xrLabel77
            // 
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(196.2919F, 180.4629F);
            this.xrLabel77.Multiline = true;
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel77.Text = ":";
            // 
            // xrLabel76
            // 
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(196.2919F, 160.8795F);
            this.xrLabel76.Multiline = true;
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel76.Text = ":";
            // 
            // xrLabel75
            // 
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(23.37494F, 160.8795F);
            this.xrLabel75.Multiline = true;
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.xrLabel75.Text = "E-Posta Adresi";
            // 
            // xrLabel74
            // 
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(196.2919F, 141.9212F);
            this.xrLabel74.Multiline = true;
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel74.Text = ":";
            // 
            // xrLabel73
            // 
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(23.37494F, 141.9212F);
            this.xrLabel73.Multiline = true;
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.xrLabel73.Text = "Görev Yeri";
            // 
            // xrLabel72
            // 
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(23.37494F, 105.2627F);
            this.xrLabel72.Multiline = true;
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.xrLabel72.Text = "Doğum Tarihi";
            // 
            // xrLabel71
            // 
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(196.2916F, 105.2627F);
            this.xrLabel71.Multiline = true;
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel71.Text = ":";
            // 
            // xrLabel70
            // 
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(196.2916F, 85.6794F);
            this.xrLabel70.Multiline = true;
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel70.Text = ":";
            // 
            // xrLabel69
            // 
            this.xrLabel69.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(23.37496F, 49.09603F);
            this.xrLabel69.Multiline = true;
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(690.625F, 23F);
            this.xrLabel69.StylePriority.UseFont = false;
            this.xrLabel69.Text = "A. KİŞİSEL BİLGİLER";
            // 
            // lblAdi
            // 
            this.lblAdi.LocationFloat = new DevExpress.Utils.PointFloat(23.37494F, 85.6794F);
            this.lblAdi.Multiline = true;
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAdi.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.lblAdi.Text = "Adı Soyadı";
            // 
            // xrLabel94
            // 
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(196.2916F, 123.0544F);
            this.xrLabel94.Multiline = true;
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(11.45833F, 17.79165F);
            this.xrLabel94.Text = ":";
            // 
            // xrLabel93
            // 
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(23.37496F, 123.0544F);
            this.xrLabel93.Multiline = true;
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(172.9167F, 17.79165F);
            this.xrLabel93.Text = "Yabanci Dil Bilgisi :";
            // 
            // lblYabanciDil
            // 
            this.lblYabanciDil.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YabanciDil]")});
            this.lblYabanciDil.LocationFloat = new DevExpress.Utils.PointFloat(207.7499F, 123.0544F);
            this.lblYabanciDil.Multiline = true;
            this.lblYabanciDil.Name = "lblYabanciDil";
            this.lblYabanciDil.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblYabanciDil.SizeF = new System.Drawing.SizeF(506.25F, 17.79165F);
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1});
            this.DetailReport.DataMember = "EgitimBilgileriList";
            this.DetailReport.DataSource = this.objectDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel79,
            this.xrLabel83,
            this.xrLabel84});
            this.Detail1.HeightF = 73.95834F;
            this.Detail1.Name = "Detail1";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader2});
            this.DetailReport1.DataMember = "IsTecrubleriList";
            this.DetailReport1.DataSource = this.objectDataSource1;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel82,
            this.xrLabel85});
            this.Detail2.HeightF = 54.16667F;
            this.Detail2.Name = "Detail2";
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3,
            this.GroupHeader3});
            this.DetailReport2.DataMember = "KlinikArastirmalarList";
            this.DetailReport2.DataSource = this.objectDataSource1;
            this.DetailReport2.Level = 2;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel89,
            this.xrLabel92});
            this.Detail3.HeightF = 47.91667F;
            this.Detail3.Name = "Detail3";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel80});
            this.GroupHeader1.HeightF = 42.70833F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel86});
            this.GroupHeader2.HeightF = 44.79167F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel87});
            this.GroupHeader3.HeightF = 38.54167F;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // xrLabel80
            // 
            this.xrLabel80.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(21.89382F, 9.999974F);
            this.xrLabel80.Multiline = true;
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(690.625F, 23F);
            this.xrLabel80.StylePriority.UseFont = false;
            this.xrLabel80.Text = "B. EĞİTİM BİLGİLERİ";
            // 
            // xrLabel79
            // 
            this.xrLabel79.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Donem]")});
            this.xrLabel79.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 0F);
            this.xrLabel79.Multiline = true;
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(178.1044F, 23F);
            this.xrLabel79.StylePriority.UseFont = false;
            this.xrLabel79.StylePriority.UseTextAlignment = false;
            this.xrLabel79.Text = "xrLabel79";
            this.xrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel83
            // 
            this.xrLabel83.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Uzmanlik]")});
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 17.99978F);
            this.xrLabel83.Multiline = true;
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(684.3541F, 23F);
            this.xrLabel83.StylePriority.UseTextAlignment = false;
            this.xrLabel83.Text = "xrLabel83";
            this.xrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel84
            // 
            this.xrLabel84.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Aciklama]")});
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 41.12498F);
            this.xrLabel84.Multiline = true;
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(684.3541F, 23F);
            this.xrLabel84.StylePriority.UseTextAlignment = false;
            this.xrLabel84.Text = "xrLabel84";
            this.xrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel86
            // 
            this.xrLabel86.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(21.89382F, 10.67385F);
            this.xrLabel86.Multiline = true;
            this.xrLabel86.Name = "xrLabel86";
            this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel86.SizeF = new System.Drawing.SizeF(690.625F, 23F);
            this.xrLabel86.StylePriority.UseFont = false;
            this.xrLabel86.Text = "C. İŞ TECRÜBESİNE AİT BİLGİLER";
            // 
            // xrLabel82
            // 
            this.xrLabel82.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Donem]")});
            this.xrLabel82.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 5.00018F);
            this.xrLabel82.Multiline = true;
            this.xrLabel82.Name = "xrLabel82";
            this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel82.SizeF = new System.Drawing.SizeF(178.1041F, 23F);
            this.xrLabel82.StylePriority.UseFont = false;
            this.xrLabel82.Text = "xrLabel82";
            // 
            // xrLabel85
            // 
            this.xrLabel85.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KurumKurulus]")});
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 26.00026F);
            this.xrLabel85.Multiline = true;
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(684.3541F, 23F);
            this.xrLabel85.Text = "xrLabel85";
            // 
            // xrLabel87
            // 
            this.xrLabel87.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(21.89382F, 7.67385F);
            this.xrLabel87.Multiline = true;
            this.xrLabel87.Name = "xrLabel87";
            this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel87.SizeF = new System.Drawing.SizeF(690.625F, 23F);
            this.xrLabel87.StylePriority.UseFont = false;
            this.xrLabel87.Text = "D. KLİNİK ARAŞTIRMALARLA İLGİLİ GENEL BİLGİLER";
            // 
            // xrLabel89
            // 
            this.xrLabel89.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Yil]")});
            this.xrLabel89.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 3.0001F);
            this.xrLabel89.Multiline = true;
            this.xrLabel89.Name = "xrLabel89";
            this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel89.SizeF = new System.Drawing.SizeF(178.1041F, 23F);
            this.xrLabel89.StylePriority.UseFont = false;
            this.xrLabel89.Text = "xrLabel89";
            // 
            // xrLabel92
            // 
            this.xrLabel92.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KurumKurulus]")});
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(29.64579F, 22.00018F);
            this.xrLabel92.Multiline = true;
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(682.873F, 23F);
            this.xrLabel92.Text = "xrLabel92";
            // 
            // rprOzgecmis
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(49, 75, 35, 22);
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRLabel txtTelefon;
        private DevExpress.XtraReports.UI.XRLabel txtEposta;
        private DevExpress.XtraReports.UI.XRLabel txtGorevYeri;
        private DevExpress.XtraReports.UI.XRLabel txtDogumTarihi;
        private DevExpress.XtraReports.UI.XRLabel txtAdiSoyadi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel78;
        private DevExpress.XtraReports.UI.XRLabel xrLabel77;
        private DevExpress.XtraReports.UI.XRLabel xrLabel76;
        private DevExpress.XtraReports.UI.XRLabel xrLabel75;
        private DevExpress.XtraReports.UI.XRLabel xrLabel74;
        private DevExpress.XtraReports.UI.XRLabel xrLabel73;
        private DevExpress.XtraReports.UI.XRLabel xrLabel72;
        private DevExpress.XtraReports.UI.XRLabel xrLabel71;
        private DevExpress.XtraReports.UI.XRLabel xrLabel70;
        private DevExpress.XtraReports.UI.XRLabel xrLabel69;
        private DevExpress.XtraReports.UI.XRLabel lblAdi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel94;
        private DevExpress.XtraReports.UI.XRLabel xrLabel93;
        private DevExpress.XtraReports.UI.XRLabel lblYabanciDil;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel80;
        private DevExpress.XtraReports.UI.XRLabel xrLabel79;
        private DevExpress.XtraReports.UI.XRLabel xrLabel83;
        private DevExpress.XtraReports.UI.XRLabel xrLabel84;
        private DevExpress.XtraReports.UI.XRLabel xrLabel86;
        private DevExpress.XtraReports.UI.XRLabel xrLabel82;
        private DevExpress.XtraReports.UI.XRLabel xrLabel85;
        private DevExpress.XtraReports.UI.XRLabel xrLabel87;
        private DevExpress.XtraReports.UI.XRLabel xrLabel89;
        private DevExpress.XtraReports.UI.XRLabel xrLabel92;
    }
}
