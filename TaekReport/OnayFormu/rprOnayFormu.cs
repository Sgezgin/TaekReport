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


            lblArastirmaAdi.Text = form.ArastirmaAdi;
            lblSorumluArastirmaci.Text = form.SorumluAtastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
            lblKararNum.Text = "Karar Nu: " + form.DosyaNo;
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
        }

        private void chkiliskiEvet_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
           
            //chkiliskiEvet.Text = "Evet";
            //if (chkiliskiEvet.Text == "1")
            //    chkiliskiEvet.Checked = true;
            //else
            //    chkiliskiEvet.Checked = false;

     

        }
    }
}
