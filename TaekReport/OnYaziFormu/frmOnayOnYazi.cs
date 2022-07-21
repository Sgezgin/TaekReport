using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.OnYaziFormu
{
    public partial class frmOnayOnYazi : DevExpress.XtraReports.UI.XtraReport
    {
        public frmOnayOnYazi(string arastirmaAdi,string tur)
        {
            InitializeComponent();
            lblArastirmaAdi.Text = "Kurulumuza başvurusunu yaptığınız '"+ arastirmaAdi + "' konulu araştırmanıza ilişkin Kurulumuz onay kararı ekte sunulmaktadır." ;
        }

    }
}
