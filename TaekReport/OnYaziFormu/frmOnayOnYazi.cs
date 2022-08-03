using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.OnYaziFormu
{
    public partial class frmOnayOnYazi : DevExpress.XtraReports.UI.XtraReport
    {
        public frmOnayOnYazi(string sorumlu,string yardimci,string arastirmaAdi,string destekleyici)
        {
            InitializeComponent();
            lblArastirmaAdi.Text = "Kurulumuza başvurusunu yaptığınız " + sorumlu + " sorumlu araştırmacı , " + yardimci +
                 " yardımcı araştırmacı olduğu '" + arastirmaAdi + "' konulu araştırmanız Tıbbi Araştırmalar Etik Kurulu tarafından onaylanmıştır. " +
                 " Onay kararı ekte sunulmaktadır.";
            if (!string.IsNullOrEmpty(destekleyici))
            {
                lblRaporTur.Text = "Başvuru dosyası kapsamında, araştırma giderlerinin " + destekleyici + " tarafından karşılanacağına ilişkin sunulmuş bulunan belge doğrultusunda, araştırmanızın desteklendiğine dair belgenin alınmasından sonra çalışmaya başlanması ve süreç içinde bu belgenin Kurulumuza iletilmesi gerekmektedir.";
            }
            else
            {
                lblRaporTur.Visible = false;
            }
        }

    }
}
