using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.OnYaziFormu
{
    public partial class frmOnayOnYazi : DevExpress.XtraReports.UI.XtraReport
    {
        public frmOnayOnYazi(string arastirmaAdi,string destekleyici)
        {
            InitializeComponent();
            lblArastirmaAdi.Text = "Kurulumuza başvurusunu yaptığınız '"+ arastirmaAdi + "' konulu araştırmanıza ilişkin Kurulumuz onay kararı ekte sunulmaktadır." ;
            if (!string.IsNullOrEmpty(destekleyici))
            {
                if(destekleyici == "TÜBİTAK")
                {
                    lblRaporTur.Text = "Başvuru dosyası kapsamında, araştırma giderlerinin TÜBİTAK tarafından karşılanacağına ilişkin sunulmuş bulunan belge doğrultusunda, araştırmanızın desteklendiğine dair belgenin alınmasından sonra çalışmaya başlanması ve süreç içinde bu belgenin Kurulumuza iletilmesi gerekmektedir.";
                }
                else if (destekleyici == "BAP")
                {
                    lblRaporTur.Text = "Başvuru dosyası kapsamında, araştırma giderlerinin Bilimsel Araştırma Proje Fonu (BAP) tarafından karşılanacağına ilişkin sunulmuş bulunan belge doğrultusunda, araştırmanızın desteklendiğine dair belgenin alınmasından sonra çalışmaya başlanması ve süreç içinde bu belgenin Kurulumuza iletilmesi gerekmektedir";
                }
            }
            else
            {
                lblRaporTur.Visible = false;
            }
        }

    }
}
