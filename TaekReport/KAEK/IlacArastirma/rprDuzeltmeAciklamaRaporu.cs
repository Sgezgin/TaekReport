using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;
using System.Collections.Generic;
using System.Linq;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprDuzeltmeAciklamaRaporu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprDuzeltmeAciklamaRaporu()
        {
            InitializeComponent();
            BilesenleriAyarla();
        }

        public rprDuzeltmeAciklamaRaporu(List<DuzeltmeAciklamaRaporu> o)
        {
            InitializeComponent();
            if (o != null)
            {
                objectDataSource1.DataSource = o;
                this.DataSource = o;
            }
            BilesenleriAyarla();
        }

        private void BilesenleriAyarla()
        {
            this.BeforePrint += rprDuzeltmeAciklamaRaporu_BeforePrint;
            this.xrLabel1.BeforePrint += xrLabel1_BeforePrint;
            this.xrLabel2.BeforePrint += xrLabel2_BeforePrint;
            this.xrLabel3.BeforePrint += xrLabel3_BeforePrint;
            this.xrLabel4.BeforePrint += xrLabel4_BeforePrint;
            this.xrTableCell2.BeforePrint += xrTableCell2_BeforePrint;
            this.xrTableCell7.BeforePrint += xrTableCell7_BeforePrint;
        }

        private DuzeltmeAciklamaRaporu GetCurrentModel()
        {
            if (this.DataSource is List<DuzeltmeAciklamaRaporu> list && list.Any())
                return list.First();
            if (this.objectDataSource1.DataSource is List<DuzeltmeAciklamaRaporu> oList && oList.Any())
                return oList.First();
            return this.GetCurrentRow() as DuzeltmeAciklamaRaporu;
        }

        private void rprDuzeltmeAciklamaRaporu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var model = GetCurrentModel();
            if (model != null)
            {
                if (model.ListGorus == null)
                {
                    model.ListGorus = new List<TaekReport.KAEK.Models.HAKEMDUZELTMEDETAY>();
                }

                if (!model.ListGorus.Any())
                {
                    string not = !string.IsNullOrWhiteSpace(model.ARASTIRMADOSYALARI?.DEGISIKLIKACIKLAMA)
                        ? model.ARASTIRMADOSYALARI.DEGISIKLIKACIKLAMA
                        : (!string.IsNullOrWhiteSpace(model.ARASTIRMADOSYALARI?.KARARACK)
                            ? model.ARASTIRMADOSYALARI.KARARACK
                            : "Kurul tarafından bildirilen düzeltmeleri sistem üzerinden inceleyip revizyon dosyanızı tamamlayınız.");

                    model.ListGorus.Add(new TaekReport.KAEK.Models.HAKEMDUZELTMEDETAY
                    {
                        DUZELTMEACIKLAMA = "1. " + not.Trim()
                    });
                }

                this.DetailReport.DataSource = model.ListGorus;
                this.DetailReport.DataMember = "";
            }
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel1.Text = "Sayın";
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var model = GetCurrentModel();
            string kul = model?.BASVURUFORMU?.KULLANICI;
            if (string.IsNullOrWhiteSpace(kul)) kul = model?.BASVURUFORMU?.SORUMLUARASTIRMACI;
            if (!string.IsNullOrWhiteSpace(kul))
            {
                xrLabel2.Text = kul.Trim();
            }
            else
            {
                xrLabel2.Text = "Araştırmacı";
            }
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var model = GetCurrentModel();
            string dosyaNo = model?.ARASTIRMADOSYALARI?.DOSYANO;
            if (!string.IsNullOrWhiteSpace(dosyaNo))
            {
                xrTableCell2.Text = dosyaNo.Trim();
            }
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var model = GetCurrentModel();
            if (model != null)
            {
                string arastirmaAdi = !string.IsNullOrWhiteSpace(model.BASVURUFORMU?.ARASTIRMAADI)
                    ? model.BASVURUFORMU.ARASTIRMAADI.Trim()
                    : (!string.IsNullOrWhiteSpace(model.ARASTIRMADOSYALARI?.ARASTIRMAADI)
                        ? model.ARASTIRMADOSYALARI.ARASTIRMAADI.Trim()
                        : "Başvurusu yapılan");

                string toplantiTarihi = !string.IsNullOrWhiteSpace(model.ARASTIRMADOSYALARI?.TOPLANTITARIH)
                    ? model.ARASTIRMADOSYALARI.TOPLANTITARIH.Trim()
                    : DateTime.Now.ToString("dd.MM.yyyy");

                xrLabel3.AllowMarkupText = true;
                xrLabel3.Text = $"{arastirmaAdi} konulu araştırmanız Etik Kurulumuzun <b>{toplantiTarihi}</b> tarihli toplantısında değerlendirilmiş, geçerli mevzuat hükümlerine göre aşağıda bildirilen bilgi ve belgeler eksik bulunmuştur. Başvurunuza ancak bunların <b>en geç 30 iş günü içerisinde</b> tamamlanmasıyla onay verilebilecektir. Eksikliklerin tamamlanmaması durumunda başvuru geçersiz sayılacaktır. Düzenlenen belgelerin uygunluğunun takibi başvuru sahibinin sorumluluğundadır. Kurulumuz bu konuda ikinci bir yazı düzenlemeyecektir.\n\nBilginizi ve gereğini rica ederim.";
            }
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var model = GetCurrentModel();
            string baskan = model?.BASKAN?.Trim();
            if (string.IsNullOrWhiteSpace(baskan))
            {
                xrLabel4.Text = "Prof. Dr.\nEtik Kurul Başkanı";
            }
            else
            {
                xrLabel4.Text = baskan;
            }
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = DetailReport.GetCurrentRow() as TaekReport.KAEK.Models.HAKEMDUZELTMEDETAY;
            if (row != null && !string.IsNullOrWhiteSpace(row.DUZELTMEACIKLAMA))
            {
                xrTableCell7.Text = row.DUZELTMEACIKLAMA.Trim();
            }
        }
    }
}
