using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.BasvuruFormuTum
{
    public partial class rprBasvuruFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprBasvuruFormu(string arastirma,string sorumlu,string basvuruno, BasvuruFormModel reportData)
        {
            InitializeComponent();
            string arastmaedit = " isimli araştırma başvurusu dosyası kapsamında, aşağıda özellikleri belirtilmiş olan belgelerin tarafınızdan değerlendirilmesi/ onaylanması için gereğini bilgilerinize arz ederim.";
            lblArastirmaADi.Text = arastirma + arastmaedit;
            lblBasvuruNo.Text = "Başvuru No : " + basvuruno;
            lblSorumlu.Text = sorumlu;
            lblSorumlu2.Text = sorumlu;


            lblArastirmaAdiTarih.Text = reportData.BasvuruBilgi.ArastirmaAdi + " " + reportData.BasvuruBilgi.ArastirmaTarih;
            lblArastirmaOzeti.Text = reportData.BasvuruBilgi.ArastirmaOzeti;
            lblGirisGerekce.Text = reportData.BasvuruBilgi.GirisGerekce;
            lblArastirmaninAmaci.Text = reportData.BasvuruBilgi.ArastirmaninAmaci;
            lblHipotez.Text = reportData.BasvuruBilgi.ArastirmaHipotez;

            lblArastirmaninSuresi.Text = reportData.ArastirmaYontemi.ArastirmaSuresi;
            lblArastirmaYapilacakYer.Text = reportData.ArastirmaYontemi.ArastirmaYapilacakYer;
            llblArastirmaTipi.Text = reportData.ArastirmaYontemi.ArastirmaTipi;

            lblE4.Text = reportData.ArastirmaYontemi.E4;

            foreach (var item in reportData.GuncelKaynakListesi)
            {
                lblGuncelKaynakListesi.Text += Environment.NewLine + item;
            }


            lblG1.Text = reportData.EtikIlkelerList.G1;
            lblG2.Text = reportData.EtikIlkelerList.G2;
            lblG3.Text = reportData.EtikIlkelerList.G3;
            lblG4.Text = reportData.EtikIlkelerList.G4;
            lblG5.Text = reportData.EtikIlkelerList.G5;
            lblG6.Text = reportData.EtikIlkelerList.G6;
            lblG7.Text = reportData.EtikIlkelerList.G7;
 
        }

    }
}
