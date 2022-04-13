using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using TaekReport.Models;


namespace TaekReport.OlurFormu
{
   
    public partial class rprOlurFormu : DevExpress.XtraReports.UI.XtraReport
    {

        public rprOlurFormu(OLURFORMU form = null)
        {
            InitializeComponent();

            lblCalismaninAdi.Text = form.CALISMANINADI;
            lblCalismaAmaci.Text = form.CALISMANINAMACI;
            lblUygulama.Text = form.UYGULAMA;
            lblFTAOlasilik.Text = form.FTAOLASILIK;
            lblZaman.Text = form.ZAMAN;

            lblTahminiGonulluSayisi.Text = form.TAHMINIGONULLUSAYI.ToString();
            lblMateryalAnaliz.Text = form.MATERYALANALIZ;
            lblBeklenen.Text = form.BEKLENENLER;
            lblYararlar.Text = form.YARARLAR;
            lblSonaErdirmeDurumlari.Text = form.SONAERDIRMEDURUMLARI;
            lblZararlar.Text = form.ZARARLAR;
            lblKatilmazIse.Text = form.KATILMAZISE;
            lblAlternatifYontemler.Text = form.ALTERNATIFYONTEMLER;
            lblUcretOdenecekmi.Text = form.UCRETODENECEKMI;
            lblBilgilerinGizliligi.Text = form.BILGILERINGIZLILIGI;
            lblKisiUcretOdeyecekmi.Text = form.KISIUCRETODEYECEKMI;


          //  calismasorumlusu bilgileri
            lblCalismaSorumlusuAdiSoyadi.Text = "Bilgi gelicek";
            lblCalismaSorumluTelefon.Text = "dd";
            lblCalismaSorumluGorevYeri.Text = "ddd";
            lblGonulluAdiSoyadi.Text = "";
            lblGonulluAdres.Text = "";
            lblGonulluTelefon.Text = "";
            lblGonulluTarih.Text = "";
            lblGonulluImza.Text = "";

         //   Vasi Bilgileri
            lblVasiAdiSoyadi.Text = "";
            lblVasiAdres.Text = "";
            lblVasiTelefon.Text = "";
            lblVasiTarih.Text = "";
            lblVasiImza.Text = "";

           // Arastirmacinin bilgileri
            lblArastirmaciAdiSoyadi.Text = "";
            lblArastirmaciAdres.Text = "";
            lblArastirmaciTelefon.Text = "";
            lblArastirmaciTarih.Text = "";
            lblArastirmaciImza.Text = "";

        }


    }
}
