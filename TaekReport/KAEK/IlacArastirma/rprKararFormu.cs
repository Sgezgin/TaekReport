using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.Utils;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprKararFormu : DevExpress.XtraReports.UI.XtraReport
    {

        public rprKararFormu(List<KararFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;

            // Karar için ıslak imzalı nüsha (KARARISLAKIMZA) yüklenmişse "ETİK KURUL ÜYELERİ" ve "YEDEK ÜYELER" bölümleri basılmaz;
            // imzaların bulunduğu yerde yüklenen belge (PDF / JPG / PNG) gösterilir. Okunabilir belge yoksa üyeler normal basılır.
            var model = (o != null && o.Count > 0) ? o[0] : null;
            if (model != null)
            {
                model.listIslakImzaBelgeleri = OkunabilirIslakImzaBelgeleri(model.listIslakImzaBelgeleri);
                if (model.listIslakImzaBelgeleri.Count > 0)
                {
                    xrTableRow62.Visible = false;   // "ETİK KURUL ÜYELERİ" başlığı
                    xrTableRow63.Visible = false;   // "ASİL ÜYELER:" satırı
                    DetailReport5.Visible = false;  // asıl üye satırları ve sütun başlıkları (Unvanı/Adı/Soyadı ... İmza)
                    DetailReport.Visible = false;   // "YEDEK ÜYELER" başlığı, sütun başlıkları ve yedek üye satırları
                    IslakImzaBelgeBandiEkle();
                }
            }
        }

        private static List<KARARISLAKIMZABELGE> OkunabilirIslakImzaBelgeleri(List<KARARISLAKIMZABELGE> belgeler)
        {
            var sonuc = new List<KARARISLAKIMZABELGE>();
            if (belgeler == null) return sonuc;

            foreach (var b in belgeler)
            {
                if (b == null || b.BELGE == null || b.BELGE.Length == 0) continue;

                if (PdfIcerigiMi(b.BELGE))
                {
                    b.PdfMi = true;
                    sonuc.Add(b);
                    continue;
                }

                try
                {
                    using (var ms = new MemoryStream(b.BELGE))
                    using (Image.FromStream(ms, false, true)) { }   
                    b.PdfMi = false;
                    sonuc.Add(b);
                }
                catch (Exception)
                {
                }
            }
            return sonuc;
        }

        private static bool PdfIcerigiMi(byte[] veri)
        {
            int n = Math.Min(1024, veri.Length);
            return Encoding.ASCII.GetString(veri, 0, n).IndexOf("%PDF-", StringComparison.Ordinal) >= 0;
        }

        private void IslakImzaBelgeBandiEkle()
        {
            float genislik = PageWidth - Margins.Left - Margins.Right;
            float yukseklik = PageHeight - Margins.Top - Margins.Bottom - PageFooter.HeightF - 12F;
            float pdfGenislik = Math.Min(genislik, yukseklik / 1.4142F);   // A4 oranı: yükseklik sayfaya sığsın

            var resim = new XRPictureBox
            {
                Name = "xrIslakImzaResim",
                BoundsF = new RectangleF(0F, 0F, genislik, yukseklik),
                Sizing = ImageSizeMode.ZoomImage,
                ImageAlignment = ImageAlignment.TopCenter
            };
            resim.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Image", "Iif([PdfMi], Null, [BELGE])"));
            resim.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Visible", "Not [PdfMi]"));

            var pdf = new XRPdfContent
            {
                Name = "xrIslakImzaPdf",
                BoundsF = new RectangleF((genislik - pdfGenislik) / 2F, 0F, pdfGenislik, yukseklik)
            };
            pdf.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Source", "Iif([PdfMi], [BELGE], Null)"));
            pdf.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Visible", "[PdfMi]"));

            var detay = new DetailBand
            {
                Name = "IslakImzaDetay",
                HeightF = yukseklik,
                PageBreak = PageBreak.BeforeBand
            };
            detay.Controls.AddRange(new XRControl[] { resim, pdf });

            var bant = new DetailReportBand
            {
                Name = "IslakImzaBelgeleri",
                DataMember = "listIslakImzaBelgeleri",
                Level = 1
            };
            bant.Bands.Add(detay);
            DetailReport4.Bands.Add(bant);
        }

    }
}
