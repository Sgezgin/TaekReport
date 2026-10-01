using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.OnayFormu
{
    public partial class rprOnayFormu : DevExpress.XtraReports.UI.XtraReport
    {
        OnayFormuModel frData = new OnayFormuModel();
        public rprOnayFormu(OnayFormuModel form)
        {
            InitializeComponent();
            frData = form;

            lblFooterBaskan.Text = "Etik Kurul Başkanı "+Environment.NewLine + form.Baskan;
            lblFooterBaslanTckn.Text = form.BaskanTckn;



            if (string.IsNullOrWhiteSpace(form.DogrulamaUrl))
            {
                qrDogrulama.Visible = false;
                labelPageFooterText.Visible = false;
            }
            else
            {
                qrDogrulama.Text = form.DogrulamaUrl;

                // Karekod adresinden sitenin kök adresini al (https://alanadi) ve elle doğrulama sayfasına çevir
                string site = form.DogrulamaUrl;
                try { site = new Uri(form.DogrulamaUrl).GetLeftPart(UriPartial.Authority) + "/dogrula"; } catch { }

                labelPageFooterText.Text = "Belgeyi doğrulamak için karekodu okutunuz veya " + site + " adresine " +
                    "Başvuru No: " + form.BasvuruNo + " ve Doğrulama Kodu: " + form.DogrulamaKodu + " bilgilerini giriniz.";
            }

            lblArastirmaAdi.Text = form.ArastirmaAdi;
            lblSorumluArastirmaci.Text = form.SorumluAtastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
            lblKararNum.Text = "Karar No: " + form.DosyaNo;
            lblTarih.Text = "Tarih: " + form.ToplantiTarihi;
            lblBaskan.Text = form.Baskan;
            lblArastirmaciAdres.Text = form.KoordinatorMerkez;
            lblDestekleyici.Text = form.Destekleyici;
            lblArastirmaTipi.Text = form.ArastirmaTipi;
            lblKararMetni.Text = "Yukarıda başvuru bilgileri verilen araştırma başvuru dosyası ve ilgili belgeler " +
                "araştırmanın gerekçe, amaç, yaklaşım ve yöntemleri dikkate alınarak Kurulumuzca incelenmiş, araştırma" +
                " giderlerinin gönüllüye ve/veya bağlı bulunduğu sosyal güvenlik kurumuna ödetilmediği koşullarda araştırmaya" +
                " başlanmasının etik açıdan uygun bulunduğuna toplantıya katılan etik kurul üyelerince "+
                 form.KararOyTuru +
                " ile karar verilmiştir.";
            if (form.BilgilendirmeNot.Length > 0)
                lblKararMetni.Text = form.BilgilendirmeNot;

     
        }

        private void chkiliskiEvet_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
           
            //chkiliskiEvet.Text = "Evet";
            //if (chkiliskiEvet.Text == "1")
            //    chkiliskiEvet.Checked = true;
            //else
            //    chkiliskiEvet.Checked = false;

     

        }

        private void rprOnayFormu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           

        }
    }
}
