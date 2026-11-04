using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.GozlemselIlac
{
    public partial class rprGozlemselCalismalarBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprGozlemselCalismalarBasvuruForm()
        {
            InitializeComponent();
            InitReportCustomDesign();
        }

        public rprGozlemselCalismalarBasvuruForm(List<GozlemselCalismalarBasvuruFormu> o)
        {
            InitializeComponent();
            InitReportCustomDesign();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }

        private void InitReportCustomDesign()
        {
            BuildPageHeader(this.PageHeader);
            BuildCalismaOzeti(this.Detail);
            BuildArastirmaMerkezleriDetay(this.ArastirmaMerkezleriDetay);
            BuildDigerBilgilerDetay(this.DigerBilgilerDetay);
            BuildArastirmaEkibiBands(this.ArastirmaEkibiGroupHeader, this.ArastirmaEkibiDetay);
            BuildDegerlendirmeCizelgesiDetay(this.DegerlendirmeCizelgesiDetay);
            BuildEtikKurulDetay(this.EtikKurulDetay);
            BuildReportFooter(this.ReportFooter);
        }

        #region Helper Creators
        private static XRTableCell CreateCell(string text, double weight, Font font, TextAlignment align, PaddingInfo pad, Color bg, Color fg, BorderSide borders)
        {
            XRTableCell c = new XRTableCell();
            c.Text = text;
            c.Weight = weight;
            c.Font = font;
            c.TextAlignment = align;
            c.Padding = pad;
            c.BackColor = bg;
            c.ForeColor = fg;
            c.Borders = borders;
            c.BorderColor = Color.Black;
            c.BorderWidth = 1F;
            c.Multiline = true;
            return c;
        }

        private static XRTableCell CreateBoundCell(string bindingExpr, double weight, Font font, TextAlignment align, PaddingInfo pad, Color bg, Color fg, BorderSide borders)
        {
            XRTableCell c = CreateCell("", weight, font, align, pad, bg, fg, borders);
            if (!string.IsNullOrEmpty(bindingExpr))
            {
                c.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", bindingExpr));
            }
            return c;
        }

        private static XRTable CreateSectionHeaderTable(string title)
        {
            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 28F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            XRTableRow r = new XRTableRow { Weight = 1D };
            XRTableCell c = CreateCell(title, 1D, new Font("Arial", 11F, FontStyle.Bold), TextAlignment.MiddleLeft, new PaddingInfo(6, 6, 2, 2, 100F), Color.Black, Color.White, BorderSide.All);
            r.Cells.Add(c);
            tbl.Rows.Add(r);
            return tbl;
        }
        #endregion

        #region Builders
        private static void BuildPageHeader(PageHeaderBand band)
        {
            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 75F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);

            // Row 1: Title
            XRTableRow r1 = new XRTableRow { Weight = 1.2D };
            XRTableCell cTitle = CreateCell("GÖZLEMSEL ÇALIŞMALAR BAŞVURU FORMU", 1D, new Font("Arial", 11F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(4, 4, 4, 4, 100F), Color.Transparent, Color.Black, BorderSide.All);
            r1.Cells.Add(cTitle);

            // Row 2: Headers
            XRTableRow r2 = new XRTableRow { Weight = 0.9D };
            r2.Cells.Add(CreateCell("Doküman No", 0.18D, new Font("Arial", 9F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateCell("İlk Yayın Tarihi", 0.20D, new Font("Arial", 9F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateCell("Revizyon Tarihi", 0.20D, new Font("Arial", 9F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateCell("Revizyon No", 0.18D, new Font("Arial", 9F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateCell("Sayfa", 0.24D, new Font("Arial", 9F, FontStyle.Bold), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));

            // Row 3: Values
            XRTableRow r3 = new XRTableRow { Weight = 0.9D };
            r3.Cells.Add(CreateCell("KAD-FR-02", 0.18D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("01.12.2019", 0.20D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("01.01.2021", 0.20D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("01", 0.18D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All));

            XRTableCell cPage = CreateCell("", 0.24D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleCenter, new PaddingInfo(2, 2, 2, 2, 100F), Color.Transparent, Color.Black, BorderSide.All);
            XRPageInfo pageInfo = new XRPageInfo();
            pageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal;
            pageInfo.Format = "{0} / {1}";
            pageInfo.TextAlignment = TextAlignment.MiddleCenter;
            pageInfo.SizeF = new SizeF(150F, 22F);
            pageInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            cPage.Controls.Add(pageInfo);
            r3.Cells.Add(cPage);

            tbl.Rows.AddRange(new XRTableRow[] { r1, r2, r3 });
            band.Controls.Add(tbl);
        }

        private static void BuildCalismaOzeti(DetailBand band)
        {
            band.Controls.Add(CreateSectionHeaderTable("ÇALIŞMA ÖZETİ"));

            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 850F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40F);

            Font fBold = new Font("Arial", 9F, FontStyle.Bold);
            Font fReg = new Font("Arial", 9F, FontStyle.Regular);
            Font fSubBold = new Font("Arial", 8.5F, FontStyle.Bold);
            Color clrRed = Color.FromArgb(192, 0, 0);
            PaddingInfo pad = new PaddingInfo(5, 5, 4, 4, 100F);

            // 1. Destekleyici
            XRTableRow r1 = new XRTableRow { Weight = 1D };
            r1.Cells.Add(CreateCell("Destekleyici", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r1.Cells.Add(CreateBoundCell("[BASVURUFORMU].[DESTEKLEYICI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 2. Yasal temsilci
            XRTableRow r2 = new XRTableRow { Weight = 1D };
            r2.Cells.Add(CreateCell("Yasal temsilci", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateBoundCell("[BASVURUFORMU].[YASALTEMSILCI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 3. Çalışmanın açık adı
            XRTableRow r3 = new XRTableRow { Weight = 1D };
            r3.Cells.Add(CreateCell("Çalışmanın açık adı", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMAACIKADI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 4. Protokol kodu
            XRTableRow r4 = new XRTableRow { Weight = 1D };
            r4.Cells.Add(CreateCell("Protokol kodu", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r4.Cells.Add(CreateBoundCell("[BASVURUFORMU].[PROTOKOLKODU]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 5. Çalışmanın statüsü
            XRTableRow r5 = new XRTableRow { Weight = 1.2D };
            r5.Cells.Add(CreateCell("Çalışmanın statüsü", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r5.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMASTATUSU] + Iif(IsNullOrEmpty([GozlemselFormu].[ARASTIRMASTATUSUACIKLAMA]), '', '\n' + [GozlemselFormu].[ARASTIRMASTATUSUACIKLAMA])", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 6. Araştırılan tıbbi durum veya hastalık
            XRTableRow r6 = new XRTableRow { Weight = 1D };
            r6.Cells.Add(CreateCell("Araştırılan tıbbi durum veya hastalık", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r6.Cells.Add(CreateBoundCell("[GozlemselFormu].[TIBBIDURUMVEHASTALIK]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 7. Araştırılan etkin madde
            XRTableRow r7 = new XRTableRow { Weight = 1D };
            r7.Cells.Add(CreateCell("Araştırılan etkin madde", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r7.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRILANETKINMADDE]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 8. Çalışmanın amacı
            XRTableRow r8 = new XRTableRow { Weight = 1.2D };
            r8.Cells.Add(CreateCell("Çalışmanın amacı", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r8.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMAAMACI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 9. Gönüllü grubu
            XRTableRow r9 = new XRTableRow { Weight = 1.1D };
            r9.Cells.Add(CreateCell("Gönüllü grubu", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r9.Cells.Add(CreateBoundCell("[GozlemselFormu].[GONULLUGRUBU]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 10. Gönüllü yaş aralığı
            XRTableRow r10 = new XRTableRow { Weight = 1D };
            r10.Cells.Add(CreateCell("Gönüllü yaş aralığı", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r10.Cells.Add(CreateBoundCell("[GozlemselFormu].[GONULLUYASARALIGI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 11. Gönüllü sayısı - Toplam
            XRTableRow r11 = new XRTableRow { Weight = 1D };
            r11.Cells.Add(CreateCell("Gönüllü sayısı", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r11.Cells.Add(CreateCell("Toplam", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r11.Cells.Add(CreateBoundCell("[GozlemselFormu].[GONULLUSAYI]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 12. Gönüllü sayısı - Türkiye
            XRTableRow r12 = new XRTableRow { Weight = 1D };
            r12.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r12.Cells.Add(CreateCell("Türkiye", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r12.Cells.Add(CreateBoundCell("[GozlemselFormu].[GONULLUSAYITR]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 13. Dahil edilme kriterleri
            XRTableRow r13 = new XRTableRow { Weight = 1.2D };
            r13.Cells.Add(CreateCell("Dahil edilme kriterleri", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r13.Cells.Add(CreateBoundCell("[GozlemselFormu].[DAHILEDILMEKRITERLERI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 14. Dahil edilmeme kriterleri
            XRTableRow r14 = new XRTableRow { Weight = 1.2D };
            r14.Cells.Add(CreateCell("Dahil edilmeme kriterleri", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r14.Cells.Add(CreateBoundCell("[GozlemselFormu].[DAHILEDILMEMEKRITERLERI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 15. Çalışma süresi - Toplam
            XRTableRow r15 = new XRTableRow { Weight = 1D };
            r15.Cells.Add(CreateCell("Çalışma süresi", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r15.Cells.Add(CreateCell("Toplam", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r15.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMASURESITOPLAM]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 16. Çalışma süresi - Türkiye
            XRTableRow r16 = new XRTableRow { Weight = 1D };
            r16.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r16.Cells.Add(CreateCell("Türkiye", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r16.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMASURETR]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 17. Gönüllü Alımı Başlangıç
            XRTableRow r17 = new XRTableRow { Weight = 1D };
            r17.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r17.Cells.Add(CreateCell("Gönüllü Alımı Başlangıç\n(Çalışmanın başlangıcı)", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r17.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMAGONULLUBASLAMA]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 18. Gönüllü Alımı Bitiş
            XRTableRow r18 = new XRTableRow { Weight = 1D };
            r18.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r18.Cells.Add(CreateCell("Gönüllü Alımı Bitiş", 0.22D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r18.Cells.Add(CreateBoundCell("[GozlemselFormu].[ARASTIRMAGONULLUBITIS]", 0.53D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 19. Gönüllülerin takip süresi
            XRTableRow r19 = new XRTableRow { Weight = 1D };
            r19.Cells.Add(CreateCell("Gönüllülerin takip süresi", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r19.Cells.Add(CreateBoundCell("[GozlemselFormu].[GONULLUTAKIPSURESI]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 20. İstatiksel Analiz
            XRTableRow r20 = new XRTableRow { Weight = 1.2D };
            r20.Cells.Add(CreateCell("İstatiksel Analiz", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r20.Cells.Add(CreateBoundCell("[GozlemselFormu].[ISTATIKSELANALIZ]", 0.75D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 21. Koordinatör - Merkez
            XRTableRow r21 = new XRTableRow { Weight = 1D };
            r21.Cells.Add(CreateCell("Koordinatör", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r21.Cells.Add(CreateCell("Koordinatör merkez", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r21.Cells.Add(CreateBoundCell("[BASVURUFORMU].[KURUMANABILIMDALI]", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 22. Koordinatör - Katılımcı hekim
            XRTableRow r22 = new XRTableRow { Weight = 1D };
            r22.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r22.Cells.Add(CreateCell("Koordinatör (tek merkezli çalışmalarda katılımcı hekim)", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r22.Cells.Add(CreateBoundCell("[GozlemselFormu].[KORDINATOR]", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 23. Koordinatör - İletişim
            XRTableRow r23 = new XRTableRow { Weight = 1D };
            r23.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r23.Cells.Add(CreateCell("İletişim", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r23.Cells.Add(CreateBoundCell("[Telefon] + Iif(IsNullOrEmpty([Email]), '', ' / ' + [Email])", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 24. İdari Sorumlu - Adı soyadı
            XRTableRow r24 = new XRTableRow { Weight = 1D };
            r24.Cells.Add(CreateCell("İdari Sorumlu\n(varsa)", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r24.Cells.Add(CreateCell("Adı soyadı", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r24.Cells.Add(CreateBoundCell("[BASVURUFORMU].[IDARISORUMLU]", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 25. İdari Sorumlu - Görev yeri
            XRTableRow r25 = new XRTableRow { Weight = 1D };
            r25.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r25.Cells.Add(CreateCell("Görev yeri", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r25.Cells.Add(CreateBoundCell("[BASVURUFORMU].[IDARISORUMLUGOREVYERI]", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 26. İdari Sorumlu - İletişim
            XRTableRow r26 = new XRTableRow { Weight = 1D };
            r26.Cells.Add(CreateCell("", 0.25D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r26.Cells.Add(CreateCell("İletişim", 0.35D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r26.Cells.Add(CreateBoundCell("[BASVURUFORMU].[IDARISORUMLUILETISIM]", 0.40D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 27. Çalışma merkezleri Header
            XRTableRow r27 = new XRTableRow { Weight = 1D };
            r27.Cells.Add(CreateCell("Çalışma merkezleri", 1D, new Font("Arial", 9.5F, FontStyle.Bold), TextAlignment.MiddleCenter, pad, Color.FromArgb(222, 234, 246), Color.Black, BorderSide.All));

            // 28. Merkez tablosu kolon başlıkları
            XRTableRow r28 = new XRTableRow { Weight = 1D };
            r28.Cells.Add(CreateCell("No", 0.08D, fSubBold, TextAlignment.MiddleCenter, pad, Color.Transparent, clrRed, BorderSide.All));
            r28.Cells.Add(CreateCell("Merkez Adı", 0.46D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));
            r28.Cells.Add(CreateCell("Katılımcı hekim (Uzmanlık Alanı) (Telefon)", 0.46D, fSubBold, TextAlignment.MiddleLeft, pad, Color.Transparent, clrRed, BorderSide.All));

            tbl.Rows.AddRange(new XRTableRow[] {
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28
            });
            band.Controls.Add(tbl);
        }

        private static void BuildArastirmaMerkezleriDetay(DetailBand band)
        {
            band.HeightF = 25F;
            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 25F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);

            XRTableRow r = new XRTableRow { Weight = 1D };
            Font fReg = new Font("Arial", 9F, FontStyle.Regular);
            PaddingInfo pad = new PaddingInfo(4, 4, 3, 3, 100F);

            // Col 0: RecordNumber
            XRTableCell cNo = CreateCell("", 0.08D, fReg, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All);
            XRSummary sum = new XRSummary { Func = SummaryFunc.RecordNumber, Running = SummaryRunning.Report };
            cNo.Summary = sum;
            cNo.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[ID]"));
            r.Cells.Add(cNo);

            // Col 1: Merkez Adı
            r.Cells.Add(CreateBoundCell("[MERKEZGUID]", 0.46D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // Col 2: Hekim + Uzmanlık + Telefon
            r.Cells.Add(CreateBoundCell("[UNVANGUID] + ' ' + [ADI] + ' ' + [SOYADI] + Iif(IsNullOrEmpty([UZMANLIKALANI]), '', ' (' + [UZMANLIKALANI] + ')') + Iif(IsNullOrEmpty([TELEFON]), '', ' (' + [TELEFON] + ')')", 0.46D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            tbl.Rows.Add(r);
            band.Controls.Add(tbl);
        }

        private static void BuildDigerBilgilerDetay(DetailBand band)
        {
            band.HeightF = 420F;
            band.Controls.Add(CreateSectionHeaderTable("DİĞER BİLGİLER"));

            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 380F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40F);

            Font fTitle = new Font("Arial", 9F, FontStyle.Bold);
            Font fReg = new Font("Arial", 9F, FontStyle.Regular);
            Font fDesc = new Font("Arial", 8.5F, FontStyle.Italic);
            PaddingInfo pad = new PaddingInfo(5, 5, 4, 4, 100F);

            void AddDigerRow(string title, string desc, string expr)
            {
                XRTableRow r = new XRTableRow { Weight = 1D };
                XRTableCell c = CreateCell("", 1D, fReg, TextAlignment.TopLeft, pad, Color.Transparent, Color.Black, BorderSide.All);

                XRLabel lblTitle = new XRLabel { Text = title, Font = fTitle, ForeColor = Color.Black, LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F), SizeF = new SizeF(790F, 18F) };
                XRLabel lblDesc = new XRLabel { Text = desc, Font = fDesc, ForeColor = Color.FromArgb(80, 80, 80), LocationFloat = new DevExpress.Utils.PointFloat(0F, 18F), SizeF = new SizeF(790F, 32F), Multiline = true };
                XRLabel lblVal = new XRLabel { Font = fReg, ForeColor = Color.Black, LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F), SizeF = new SizeF(790F, 22F), Multiline = true };
                lblVal.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", expr));

                c.Controls.AddRange(new XRControl[] { lblTitle, lblDesc, lblVal });
                r.Cells.Add(c);
                tbl.Rows.Add(r);
            }

            AddDigerRow(
                "Hassas popülasyon/İncinebilir Grup (Vulnerable subjects)",
                "Çalışmaya kısıtlılar, çocuklar, gebeler, lohusalar ve emziren kadınlar, yoğun bakımdaki ve bilinci kapalı kişiler ile şahsen olur veremeyecek kişiler veya etkilenebilir özneler gibi hassas bir popülasyon dahil edilecekse, çalışmanın bu popülasyonda yapılmasına dair gerekçeyi ve seçilen bu popülasyonda bilgilendirilmiş gönüllü olur formu almak, gizlilik esasını korumak ve bu gruba yönelik alınacak tedbirleri açıklayınız",
                "[GozlemselFormu].[HASSASPOPULASYON]"
            );

            AddDigerRow(
                "Gizlilik",
                "Gönüllülere ait kimlik bilgileri/kişisel tanımlayıcı bilgiler toplanacak veya bunlara erişim sağlanacak (sağlık kayıtları, biyometrik kimlik tanımlayıcılar, ses kayıtları, görüntüler gibi) ise bunları açıklayınız. Gönüllülere ait kimlik bilgilerine/kişisel tanımlayıcı bilgilere kimlerin erişim hakkı olacağını ve yetkisi olmayan kişilerin kimlik tanımlayıcı verilere erişimini engellemek için alınan önlemleri açıklayınız.",
                "[GozlemselFormu].[GIZLILIK]"
            );

            AddDigerRow(
                "Gönüllülere ödeme",
                "Gönüllülerin çalışmaya iştiraki ile ortaya çıkacak masraflar (yol, konaklama ve yemek giderleri gibi) için ödeme yapılacak ise açıklayınız (miktarı, ödemenin nasıl gerçekleştirileceği vb.)",
                "[GozlemselFormu].[GONULLULEREODEME]"
            );

            AddDigerRow(
                "Çalışma / gönüllü dokümanları (additional documentation and recruitment procedure)",
                "Çalışmada kullanılacak doküman ve materyallerin kullanım amaçlarını açıklayınız (anket, görüşme, odak grup taslağı, günlükler, hasta kartları vb.). Gönüllülerin çalışmaya dâhil edilmesinde kullanılacak araçları açıklayınız (poster, broşür, hekim sevk mektubu vb.)",
                "[GozlemselFormu].[ARASTIRMADOKUMANLARI]"
            );

            AddDigerRow(
                "Bağımsız veri izleme komitesi",
                "Çalışmada bağımsız veri izleme komitesi varsa komitenin yapısını ve iletişim bilgilerini belirtiniz.",
                "[GozlemselFormu].[BAGIMSIZVERIIZLEMEKOMITESI]"
            );

            AddDigerRow(
                "Tesis / laboratuvar",
                "Çalışmanın gerçekleştirilmesinde kullanılacak olan merkezi teknik tesisler, temel değerlendirme kriterlerinin ölçümü veya değerlendirilmesinin merkezileştirildiği laboratuvar veya diğer teknik tesisleri açıklayınız. Kurum/kuruluşun adı, temasa geçilecek kişinin adı soyadı ve iletişim bilgilerini belirtiniz.",
                "[GozlemselFormu].[TESISLABORATUVAR]"
            );

            AddDigerRow(
                "Görev devri",
                "Destekleyici, çalışmaya ait temel görev veya işlerinden herhangi birini başka bir kurum/kuruluşa veya üçüncü taraflara devretmiş ise devredilen görevi açıklayınız. Kurum/kuruluşun adı, temasa geçilecek kişinin adı soyadı ve iletişim bilgilerini belirtiniz.",
                "[GozlemselFormu].[GOREVDEVRI]"
            );

            AddDigerRow(
                "Diğer sağlık otoritelerine başvuru",
                "Çalışma uluslararası bir araştırma ise aynı başvurunun sunulduğu diğer sağlık otoritelerinin bir listesini belirtiniz. Çalışmanın onaylandığı başka ülkeler var ise bu ülkeleri belirtiniz. Diğer ülkelerde uygulanacak protokol ve çalışmaya dair diğer hususlar ile ülkemizde uygulanacak protokol ve çalışmaya dair diğer hususlar arasında farklılıklar varsa gerekçeleri ile belirtiniz.",
                "[GozlemselFormu].[DIGERSAGLIKOTORITELERI]"
            );

            band.Controls.Add(tbl);
        }

        private static void BuildArastirmaEkibiBands(GroupHeaderBand gh, DetailBand detail)
        {
            // GroupHeaderBand
            gh.HeightF = 175F;
            gh.GroupFields.AddRange(new GroupField[] {
                new GroupField("MERKEZGUID", XRColumnSortOrder.Ascending)
            });

            gh.Controls.Add(CreateSectionHeaderTable("ÇALIŞMA EKİBİ LİSTESİ"));

            XRLabel lblNotes = new XRLabel();
            lblNotes.Text = "• Her merkez için ayrı olacak şekilde bir çalışma merkezinde yer alan tüm çalışma ekibi üyeleri yazılmalıdır.\n" +
                            "• Görevi: Katılımcı Hekim, Yardımcı Hekim, Veri Giriş Destek Görevlisi, Monitör ve diğer araştırma ekibi üyelerinin görevleri belirtilmelidir.\n" +
                            "• Unvan: Prof. Dr. ; Doç. Dr. ; Dr. Öğr. Üyesi ; Uzm. Dr. ; Dr. ; Doktora (Ph.D.) ; Yüksek Lisans vb. şekilde belirtilmelidir.\n" +
                            "• Eğitim: Tıp (Uzmanlık Alanı), Tıp, Eczacı, Hemşire, Biyolog vb. şekilde belirtilmelidir.";
            lblNotes.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblNotes.ForeColor = Color.FromArgb(70, 70, 70);
            lblNotes.SizeF = new SizeF(802F, 48F);
            lblNotes.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42F);
            gh.Controls.Add(lblNotes);

            XRTable tblHeader = new XRTable();
            tblHeader.SizeF = new SizeF(802F, 75F);
            tblHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95F);
            Color clrHeaderBg = Color.FromArgb(217, 226, 243);
            Font fBold = new Font("Arial", 9F, FontStyle.Bold);
            PaddingInfo pad = new PaddingInfo(4, 4, 3, 3, 100F);

            // Row 1: Merkez Adı
            XRTableRow r1 = new XRTableRow { Weight = 1D };
            r1.Cells.Add(CreateCell("Merkez Adı", 0.22D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r1.Cells.Add(CreateBoundCell("[MERKEZGUID]", 0.78D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // Row 2: Adres
            XRTableRow r2 = new XRTableRow { Weight = 1D };
            r2.Cells.Add(CreateCell("Adres", 0.22D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateBoundCell("[ISADRESI]", 0.78D, new Font("Arial", 9F, FontStyle.Regular), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // Row 3: Kolonlar
            XRTableRow r3 = new XRTableRow { Weight = 1D };
            r3.Cells.Add(CreateCell("Görevi", 0.22D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("Adı Soyadı", 0.26D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("Unvan", 0.16D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("Eğitim", 0.22D, fBold, TextAlignment.MiddleLeft, pad, clrHeaderBg, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("İKU (GCP) Eğitimi\n(var/yok)", 0.14D, fBold, TextAlignment.MiddleCenter, pad, clrHeaderBg, Color.Black, BorderSide.All));

            tblHeader.Rows.AddRange(new XRTableRow[] { r1, r2, r3 });
            gh.Controls.Add(tblHeader);

            // Detail Band
            detail.HeightF = 25F;
            XRTable tblRow = new XRTable();
            tblRow.SizeF = new SizeF(802F, 25F);
            tblRow.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);

            XRTableRow rd = new XRTableRow { Weight = 1D };
            Font fReg = new Font("Arial", 9F, FontStyle.Regular);
            rd.Cells.Add(CreateBoundCell("[GOREVI]", 0.22D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            rd.Cells.Add(CreateBoundCell("[ADI] + ' ' + [SOYADI]", 0.26D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            rd.Cells.Add(CreateBoundCell("[UNVANGUID]", 0.16D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            rd.Cells.Add(CreateBoundCell("[EGITIMI]", 0.22D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            rd.Cells.Add(CreateBoundCell("[EGITIMIGCP]", 0.14D, fReg, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All));

            tblRow.Rows.Add(rd);
            detail.Controls.Add(tblRow);
        }

        private static void BuildDegerlendirmeCizelgesiDetay(DetailBand band)
        {
            band.HeightF = 350F;
            band.Controls.Add(CreateSectionHeaderTable("DEĞERLENDİRME ÇİZELGESİ (Schedule of Assessments)"));

            XRLabel lblSub = new XRLabel();
            lblSub.Text = "Çalışmada yapılacak olan değerlendirmeleri aşağıdaki örnek tablo gibi çizelgeleyiniz";
            lblSub.Font = new Font("Arial", 9F, FontStyle.Italic);
            lblSub.ForeColor = Color.FromArgb(80, 80, 80);
            lblSub.SizeF = new SizeF(802F, 20F);
            lblSub.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40F);
            band.Controls.Add(lblSub);

            // Örnek Tablo
            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 280F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 65F);

            Color clrNavHeader = Color.FromArgb(0, 51, 102);
            Font fNav = new Font("Arial", 8F, FontStyle.Bold);
            Font fCell = new Font("Arial", 8F, FontStyle.Regular);
            PaddingInfo pad = new PaddingInfo(3, 3, 2, 2, 100F);

            XRTableRow rHead = new XRTableRow { Weight = 1.2D };
            rHead.Cells.Add(CreateCell("Değerlendirme", 0.26D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 0 (G0)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 1 (G1)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 2 (H6)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 3 (H12)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 4 (H18)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 5 (H24)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Vizit 6 (H30)", 0.09D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            rHead.Cells.Add(CreateCell("Takip Vizitleri\n(3 ayda bir)", 0.11D, fNav, TextAlignment.MiddleCenter, pad, clrNavHeader, Color.White, BorderSide.All));
            tbl.Rows.Add(rHead);

            string[,] rows = new string[,] {
                { "Bilgilendirilmiş Gönüllü Olur Formu", "X", "", "", "", "", "", "", "" },
                { "Demografik bilgiler", "", "X", "", "", "", "", "", "X" },
                { "Tıbbi öykü", "", "X", "", "", "", "", "", "" },
                { "Karaciğer fonksiyon testi", "", "X", "X", "X", "X", "X", "X", "X" },
                { "Mevcut tedaviler (ilaçlar)", "", "X", "X", "X", "X", "X", "X", "" },
                { "Biyokimya", "", "X", "", "X", "", "X", "", "X" },
                { "Hematoloji", "", "X", "", "X", "", "X", "", "X" },
                { "İdrar analizi", "", "X", "", "X", "", "X", "", "X" },
                { "Yaşamsal bulgular", "", "X", "X", "X", "X", "X", "X", "X" },
                { "Dahil etme/hariç bırakma kriterleri", "X", "", "", "", "", "", "", "" },
                { "Gebelik testi (serum / idrar)", "", "X", "", "", "", "", "X", "X" }
            };

            for (int i = 0; i < rows.GetLength(0); i++)
            {
                XRTableRow r = new XRTableRow { Weight = 0.85D };
                r.Cells.Add(CreateCell(rows[i, 0], 0.26D, fCell, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
                for (int j = 1; j <= 8; j++)
                {
                    r.Cells.Add(CreateCell(rows[i, j], j == 8 ? 0.11D : 0.09D, fNav, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All));
                }
                tbl.Rows.Add(r);
            }

            band.Controls.Add(tbl);
        }

        private static void BuildEtikKurulDetay(DetailBand band)
        {
            band.HeightF = 380F;
            band.Controls.Add(CreateSectionHeaderTable("ETİK KURUL BİLGİLERİ"));

            XRTable tbl = new XRTable();
            tbl.SizeF = new SizeF(802F, 340F);
            tbl.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40F);

            Font fBold = new Font("Arial", 9F, FontStyle.Bold);
            Font fReg = new Font("Arial", 9F, FontStyle.Regular);
            Font fRed = new Font("Arial", 8F, FontStyle.Italic);
            Color clrRed = Color.FromArgb(192, 0, 0);
            PaddingInfo pad = new PaddingInfo(4, 4, 3, 3, 100F);

            // 1. Red kararı Checkbox + Açıklama
            XRTableRow r1 = new XRTableRow { Weight = 1.3D };
            XRTableCell cRedChk = CreateCell("", 0.06D, fBold, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All);
            XRCheckBox chkRed = new XRCheckBox { SizeF = new SizeF(18F, 18F), LocationFloat = new DevExpress.Utils.PointFloat(12F, 10F), GlyphAlignment = DevExpress.Utils.HorzAlignment.Center };
            chkRed.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "CheckBoxState", "Iif([GozlemselFormu].[ETIKKURULRED] == 1, 'Checked', 'Unchecked')"));
            cRedChk.Controls.Add(chkRed);
            r1.Cells.Add(cRedChk);

            XRTableCell cRedText = CreateCell("Çalışmaya etik kurul tarafından daha önce verilmiş red kararı var\n" +
                                              "Etik kurul kararının aslı veya aslı gibidir onaylı örneğini başvuru dosyasına ekleyiniz. Etik kurul karar formunun aslı gibidir onayı etik kurul başkanı veya etik kurul sekretaryası tarafından yapılmalıdır.",
                                              0.94D, fBold, TextAlignment.TopLeft, pad, Color.Transparent, Color.Black, BorderSide.All);
            r1.Cells.Add(cRedText);

            // 2. Red - Etik Kurulun Adı
            XRTableRow r2 = new XRTableRow { Weight = 0.9D };
            r2.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateCell("Etik kurulun adı", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r2.Cells.Add(CreateBoundCell("[GozlemselFormu].[REDETIKKURULADI]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 3. Red - Karar tarihi
            XRTableRow r3 = new XRTableRow { Weight = 0.9D };
            r3.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateCell("Karar tarihi", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r3.Cells.Add(CreateBoundCell("[GozlemselFormu].[REDETIKKARARTARIH]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 4. Red - Karar no
            XRTableRow r4 = new XRTableRow { Weight = 0.9D };
            r4.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r4.Cells.Add(CreateCell("Karar no", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r4.Cells.Add(CreateBoundCell("[GozlemselFormu].[REDETIKARARNO]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 5. TİTCK Notu (Gri satır)
            XRTableRow r5 = new XRTableRow { Weight = 0.9D };
            XRTableCell cTitck = CreateCell("Bu bölüm, Türkiye İlaç ve Tıbbi Cihaz Kurumu’na başvuru yapılırken doldurulmalıdır.", 1D, fRed, TextAlignment.MiddleLeft, pad, Color.FromArgb(242, 242, 242), clrRed, BorderSide.All);
            r5.Cells.Add(cTitck);

            // 6. Başvuru yapıldı Checkbox + Başlık
            XRTableRow r6 = new XRTableRow { Weight = 1.1D };
            XRTableCell cBasvuruChk = CreateCell("", 0.06D, fBold, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All);
            XRCheckBox chkBasvuru = new XRCheckBox { SizeF = new SizeF(18F, 18F), LocationFloat = new DevExpress.Utils.PointFloat(12F, 8F), GlyphAlignment = DevExpress.Utils.HorzAlignment.Center };
            chkBasvuru.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "CheckBoxState", "Iif([GozlemselFormu].[ETIKKURULBASVURU] == 1, 'Checked', 'Unchecked')"));
            cBasvuruChk.Controls.Add(chkBasvuru);
            r6.Cells.Add(cBasvuruChk);

            r6.Cells.Add(CreateCell("Çalışma onayı için etik kurul başvurusu yapıldı", 0.94D, fBold, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 7. Başvuru - Etik Kurulun Adı
            XRTableRow r7 = new XRTableRow { Weight = 0.9D };
            r7.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r7.Cells.Add(CreateCell("Etik kurulun adı", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r7.Cells.Add(CreateBoundCell("[GozlemselFormu].[ETIKKURULADI]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 8. Başvuru - Başvuru tarihi
            XRTableRow r8 = new XRTableRow { Weight = 0.9D };
            r8.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r8.Cells.Add(CreateCell("Başvuru tarihi", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r8.Cells.Add(CreateBoundCell("[GozlemselFormu].[ETIKKURULBASVURUTARIH]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 9. Onay var Checkbox + Açıklama
            XRTableRow r9 = new XRTableRow { Weight = 1.3D };
            XRTableCell cOnayChk = CreateCell("", 0.06D, fBold, TextAlignment.MiddleCenter, pad, Color.Transparent, Color.Black, BorderSide.All);
            XRCheckBox chkOnay = new XRCheckBox { SizeF = new SizeF(18F, 18F), LocationFloat = new DevExpress.Utils.PointFloat(12F, 10F), GlyphAlignment = DevExpress.Utils.HorzAlignment.Center };
            chkOnay.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "CheckBoxState", "Iif([GozlemselFormu].[ETIKKURULONAY] == 1, 'Checked', 'Unchecked')"));
            cOnayChk.Controls.Add(chkOnay);
            r9.Cells.Add(cOnayChk);

            r9.Cells.Add(CreateCell("Çalışmaya ait etik kurul onayı var\n" +
                                    "Etik kurul kararının aslı veya aslı gibidir onaylı örneğini başvuru dosyasına ekleyiniz. Etik kurul karar formunun aslı gibidir onayı etik kurul başkanı veya etik kurul sekretaryası tarafından yapılmalıdır.",
                                    0.94D, fBold, TextAlignment.TopLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 10. Onay - Etik Kurulun Adı
            XRTableRow r10 = new XRTableRow { Weight = 0.9D };
            r10.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r10.Cells.Add(CreateCell("Etik kurulun adı", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r10.Cells.Add(CreateBoundCell("[GozlemselFormu].[ETIKKURULADI]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 11. Onay - Karar tarihi
            XRTableRow r11 = new XRTableRow { Weight = 0.9D };
            r11.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r11.Cells.Add(CreateCell("Karar tarihi", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r11.Cells.Add(CreateBoundCell("[GozlemselFormu].[ETIKKURULKARARTARIH]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // 12. Onay - Karar no
            XRTableRow r12 = new XRTableRow { Weight = 0.9D };
            r12.Cells.Add(CreateCell("", 0.06D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r12.Cells.Add(CreateCell("Karar no", 0.24D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));
            r12.Cells.Add(CreateBoundCell("[GozlemselFormu].[ETIKKURULARARNO]", 0.70D, fReg, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            tbl.Rows.AddRange(new XRTableRow[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 });
            band.Controls.Add(tbl);
        }

        private static void BuildReportFooter(ReportFooterBand band)
        {
            band.HeightF = 720F;
            float topY = 10F;

            // 1. İLGİLİ BELGELER
            XRTable tBelgelerHead = CreateSectionHeaderTable("İLGİLİ BELGELER");
            tBelgelerHead.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);
            band.Controls.Add(tBelgelerHead);
            topY += 32F;

            XRTable tBelgeler = new XRTable();
            tBelgeler.SizeF = new SizeF(802F, 190F);
            tBelgeler.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);
            PaddingInfo pad = new PaddingInfo(6, 6, 4, 4, 100F);

            XRTableRow rb1 = new XRTableRow { Weight = 1.4D };
            rb1.Cells.Add(CreateCell("Belgeler, Başvuru Kılavuzu (KAD-KLVZ-02) ve Etik Kurul Başvuru Kılavuzu (KAD-KALVZ-03) “İlk Başvuru Dosyasında Bulunması Gereken Belgeler” bölümlerinde belirtilen gerekliliklere uygun şekilde hazırlanır. Bu bölümde belirtilen belgeler sırası ile başvuru dosyasına eklenmelidir. İlgili mevzuat gereği başvuru ücreti yatırılması gereken başvurular için söz konusu ücretin yatırılması gerekmektedir. Eksik bilgi ve belge içeren başvurular değerlendirmeye alınmayacaktır.", 1D, new Font("Arial", 8.5F, FontStyle.Italic), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.FromArgb(192, 0, 0), BorderSide.All));

            XRTableRow rb2 = new XRTableRow { Weight = 3.6D };
            rb2.Cells.Add(CreateCell(
                "• Çalışma protokolü\n" +
                "• Protokol imza sayfası (çok merkezli araştırmalarda koordinatör, tek merkezli araştırmalarda sorumlu araştırmacı tarafından imzalanmış)\n" +
                "• Bilgilendirilmiş gönüllü olur formu (BGOF)\n" +
                "• Olgu rapor formu (ORF)\n" +
                "• Araştırma bütçe formu\n" +
                "• Özgeçmişler (katılımcı hekimlere ait)\n" +
                "• Yetkilendirme belgeleri (geçerli ise) (noter veya yeminli tercümandan onaylı Türkçe tercümeleri ile birlikte)\n" +
                "• Çalışma ekibi dokümanları (geçerli ise) (bilgilendirme metinleri, doktor mektupları gibi sadece araştırma ekibinin kullandığı veya araştırma ekibini bilgilendirmede kullanılan tüm dokümanlar)\n" +
                "• Gönüllü dokümanları (geçerli ise) (hasta kartı, hasta günlüğü, anket, bilgilendirme metinleri, poster, broşür, gönüllülere verilecek olan materyaller için kullanım amaçlarını açıklayan bilgi dokümanları gibi)\n" +
                "• Etik kurul kararı (aslı veya aslı gibidir onaylı örneği)\n" +
                "• Çalışmada hakkında bilgi toplanan etkin maddeyi içeren tüm müstahzarların listesi\n" +
                "• Çalışma akademik amaçlı ise; çalışmanın akademik amaçlı olduğuna dair başvuru sahibi dışında yetkili bir kişi tarafından onaylanan ıslak imzalı belge",
                1D, new Font("Arial", 8.5F, FontStyle.Regular), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All
            ));
            tBelgeler.Rows.AddRange(new XRTableRow[] { rb1, rb2 });
            band.Controls.Add(tBelgeler);
            topY += 195F;

            // 2. FİZİKİ OLARAK SUNULMASI GEREKEN BELGELER
            XRTable tFizikiHead = CreateSectionHeaderTable("FİZİKİ OLARAK SUNULMASI GEREKEN BELGELER");
            tFizikiHead.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);
            band.Controls.Add(tFizikiHead);
            topY += 32F;

            XRTable tFiziki = new XRTable();
            tFiziki.SizeF = new SizeF(802F, 120F);
            tFiziki.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);

            XRTableRow rf1 = new XRTableRow { Weight = 1.2D };
            rf1.Cells.Add(CreateCell("Bu bölüm sadece Türkiye İlaç ve Tıbbi Cihaz Kurumu’na başvuru yapılırken geçerlidir. Kurumun Elektronik Başvuru Sisteminde kullanıcı olan tüm ilgililer başvurularını sistem üzerinden yapmak zorundadır. Fiziksel olarak sunulması gerekmeyen belgeler sadece Elektronik Başvuru Sistemi üzerinden sunulur. Fiziksel olarak sunulması gereken belgelerin taranmış halleri Elektronik Başvuru Sistemi üzerinden; asılları ise Kurumun evrak birimine teslim edilerek sunulur. Kurumun Elektronik Başvuru Sisteminde kullanıcı olmayan gerçek kişiler tarafından yapılan başvurularda tüm belgeler fiziki olarak sunulmalıdır.", 1D, new Font("Arial", 8F, FontStyle.Italic), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.FromArgb(192, 0, 0), BorderSide.All));

            XRTableRow rf2 = new XRTableRow { Weight = 0.8D };
            rf2.Cells.Add(CreateCell("Aşağıda belirtilen belgelerin ıslak imzalı hallerinin fiziksel olarak ya da tercihen elektronik imzalı olarak sunulması gerekmektedir:\n• Etik kurul kararı", 1D, new Font("Arial", 8.5F, FontStyle.Regular), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            XRTableRow rf3 = new XRTableRow { Weight = 1.2D };
            rf3.Cells.Add(CreateCell("Aşağıda belirtilen belgelerin elektronik imzalı olarak elektronik başvuru sistemi üzerinden sunulması esastır. Ancak bu belgelerin elektronik imzalı olarak sunulamaması durumunda ıslak imzalı halleri fiziksel olarak sunulabilir:\n• Araştırma bütçe formu    • Yetkilendirme belgesi    • Özgeçmiş    • Protokol imza sayfası    • Çalışmanın akademik amaçlı olduğuna dair belge", 1D, new Font("Arial", 8.5F, FontStyle.Regular), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            tFiziki.Rows.AddRange(new XRTableRow[] { rf1, rf2, rf3 });
            band.Controls.Add(tFiziki);
            topY += 125F;

            // 3. BAŞVURU SAHİBİNİN İMZASI
            XRTable tImzaHead = CreateSectionHeaderTable("BAŞVURU SAHİBİNİN İMZASI");
            tImzaHead.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);
            band.Controls.Add(tImzaHead);
            topY += 32F;

            XRTable tImza = new XRTable();
            tImza.SizeF = new SizeF(802F, 280F);
            tImza.LocationFloat = new DevExpress.Utils.PointFloat(0F, topY);

            XRTableRow ri1 = new XRTableRow { Weight = 0.6D };
            ri1.Cells.Add(CreateCell("Bu başvuru formu elektronik olarak imzalanmalıdır. Elektronik imza sahibi olmayan gerçek kişilerin başvuru formunu ıslak imzalı olarak göndermeleri gerekmektedir.", 1D, new Font("Arial", 8.5F, FontStyle.Italic), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.FromArgb(192, 0, 0), BorderSide.All));

            XRTableRow ri2 = new XRTableRow { Weight = 3.2D };
            ri2.Cells.Add(CreateCell(
                "İşbu başvuru formuyla;\n" +
                "• Başvuru dosyasına eklenen tüm dokümanların aslı ile birebir aynı olduğunu,\n" +
                "• Başvuruda sağlanan bilgilerin doğru olduğunu,\n" +
                "• Çalışmanın protokole, ilgili mevzuata, güncel Helsinki Bildirgesi ve iyi klinik uygulamaları ilkelerine uygun olarak gerçekleştirileceğini,\n" +
                "• Çalışma ekibinin araştırma hakkında bilgilendirildiğini,\n" +
                "• Önerilen gözlemsel çalışmanın gerçekleştirilebilir nitelikte olduğunu,\n" +
                "• Çalışma başvurusunun ilgili Yönetmelik kapsamında kurulan etik kurullardan, aynı anda birden fazlasına yapılmadığını,\n" +
                "• Çalışmaya ait ilerlemenin asgari yıllık olarak (yıllık bildirim formu ile) bildirileceğini,\n" +
                "• Periyodik güvenlilik raporlarının mevzuatta belirtilen sürelere uygun şekilde sunulacağını,\n" +
                "• Kişisel verilerin gizliliğine riayet edilmek kaydıyla araştırmanın kamuya açık bir veri tabanına kaydedildiğini,\n" +
                "• Çalışmaya ait bilgilerin ve çalışma sonuçlarının Kurumun belirlediği şartlar dâhilinde ticari sır ve kişisel verilerin gizliliğine riayet edilmek kaydıyla Kurum tarafından kamuya açık bir veri tabanında yayımlanmasını,\n" +
                "• Çalışma sona erdikten sonra (uluslararası bir çalışma ise, bütün ülkelerde), 1 (bir) yıllık azami süre içerisinde sonuç raporu özetinin bir kopyasını sunulacağını kabul ve taahhüt ederim.",
                1D, new Font("Arial", 8F, FontStyle.Regular), TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All
            ));

            Color clrLblBg = Color.FromArgb(242, 242, 242);
            Font fLbl = new Font("Arial", 9F, FontStyle.Bold);
            Font fVal = new Font("Arial", 9F, FontStyle.Regular);

            // Adı soyadı
            XRTableRow ri3 = new XRTableRow { Weight = 0.8D };
            ri3.Cells.Add(CreateCell("Adı soyadı", 0.32D, fLbl, TextAlignment.MiddleLeft, pad, clrLblBg, Color.Black, BorderSide.All));
            ri3.Cells.Add(CreateBoundCell("[AdiSoyadi]", 0.68D, fVal, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // Telefon numarası
            XRTableRow ri4 = new XRTableRow { Weight = 0.8D };
            ri4.Cells.Add(CreateCell("Telefon numarası", 0.32D, fLbl, TextAlignment.MiddleLeft, pad, clrLblBg, Color.Black, BorderSide.All));
            ri4.Cells.Add(CreateBoundCell("[Telefon]", 0.68D, fVal, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // E-posta adresi
            XRTableRow ri5 = new XRTableRow { Weight = 0.8D };
            ri5.Cells.Add(CreateCell("E-posta adresi", 0.32D, fLbl, TextAlignment.MiddleLeft, pad, clrLblBg, Color.Black, BorderSide.All));
            ri5.Cells.Add(CreateBoundCell("[Email]", 0.68D, fVal, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            // Tarih
            XRTableRow ri6 = new XRTableRow { Weight = 0.8D };
            ri6.Cells.Add(CreateCell("Tarih (gün/ay/yıl olarak)", 0.32D, fLbl, TextAlignment.MiddleLeft, pad, clrLblBg, Color.Black, BorderSide.All));
            XRTableCell cDate = CreateBoundCell("[Tarih]", 0.68D, fVal, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All);
            cDate.TextFormatString = "{0:dd.MM.yyyy}";
            ri6.Cells.Add(cDate);

            // İmza
            XRTableRow ri7 = new XRTableRow { Weight = 1.2D };
            ri7.Cells.Add(CreateCell("İmza", 0.32D, fLbl, TextAlignment.MiddleLeft, pad, clrLblBg, Color.Black, BorderSide.All));
            ri7.Cells.Add(CreateCell("", 0.68D, fVal, TextAlignment.MiddleLeft, pad, Color.Transparent, Color.Black, BorderSide.All));

            tImza.Rows.AddRange(new XRTableRow[] { ri1, ri2, ri3, ri4, ri5, ri6, ri7 });
            band.Controls.Add(tImza);
        }
        #endregion
    }
}
