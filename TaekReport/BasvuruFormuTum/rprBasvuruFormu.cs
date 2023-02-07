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
            lblDosyaNo.Text = "Dosya No : " + reportData.DosyaNo;
            lblSorumlu.Text = sorumlu;
            lblSorumlu2.Text = sorumlu;

            lblTarih.Text = reportData.IletmeTarih;

            lblDestekleyici.Text = reportData.Destekleyici;
            lblToplamButce.Text = reportData.ToplamButce;

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



            lblE4.Text = reportData.ArastirmaYontemi.E4;
            lblE5.Text = reportData.ArastirmaYontemi.E5;
            lblE6.Text = reportData.ArastirmaYontemi.E6;
            lblE7.Text = reportData.ArastirmaYontemi.E7;
            lblE8.Text = reportData.ArastirmaYontemi.E8;
            lblE9.Text = reportData.ArastirmaYontemi.E9;
            lblE10.Text = reportData.ArastirmaYontemi.E10;
            lblE11.Text = reportData.ArastirmaYontemi.E11;
            lblE12.Text = reportData.ArastirmaYontemi.E12;
            lblE13.Text = reportData.ArastirmaYontemi.E13;
            lblE14.Text = reportData.ArastirmaYontemi.E14;
            lblE15.Text = reportData.ArastirmaYontemi.E15;

            

       

            if (string.IsNullOrEmpty(reportData.ArsivTaahhutnameTarih))
                bandArsivKullanim.Visible = false;
            else
            {
                llbArsivTarih.Text = reportData.ArsivTaahhutnameTarih;
                lblarsivSorumluAdSoyad.Text = reportData.SorumluAdiSoyadi;
                lblArsivMetin.Text = reportData.ArastirmaAdi + " " + "isimli araştırma için arşivden alınacak ve tekrar kullanılacak olan materyalin her türlü istismarının önlenmesi için gereken dikkat ve özenin gösterileceğini taahhüt ederim. ";
            }


            if (string.IsNullOrEmpty(reportData.VeriKullanimTaahhutname.EklemeTarih))
                bandVeriKullanim.Visible = false;
            else
            {
                lblVeriKullanimTarih.Text = reportData.VeriKullanimTaahhutname.EklemeTarih;
                lblVeriKullanimSorumlu.Text = sorumlu;
                lblVeriKullanimtitle.Text = arastirma + "  başlıklı araştırma için "+ reportData.VeriKullanimTaahhutname.AnabilimDali +
                     "  anabilim/bilim/bilim dalına/dallarına ait verilerin kullanımı ile ilgili";


                veriCheck1Text.Text = reportData.VeriKullanimTaahhutname.AnabilimDali +
                    "  Anabilim /Bilim dalının/dallarının çalışmaya yönelik olarak bilgilendirildiğini ve/veya ";
                veriCheck2Text.Text = "İzinsiz veri kullanımından doğacak anlaşmazlıklardan sorumlu olduğumu taahhüt ederim. Yalnızca restrospektif çalışmalar için geçerlidir.";

                if (reportData.VeriKullanimTaahhutname.Secim1 == 1)
                    veriCheck1.Checked = true;
                if(reportData.VeriKullanimTaahhutname.Secim2 == 1)
                    veriCheck2.Checked = true;

            }



 
        }

    }
}
