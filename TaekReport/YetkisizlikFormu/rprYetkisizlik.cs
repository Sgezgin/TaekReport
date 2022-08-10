using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.YetkisizlikFormu
{
    public partial class rprYetkisizlik : DevExpress.XtraReports.UI.XtraReport
    {
        public rprYetkisizlik(YetkisizlikFormModel form)
        {
            InitializeComponent();
            lblKararNo.Text = "Karar Nu: " + form.KararNo;
            lblArastirmaAdi.Text = "'" + form.ArastirmaAdi + 
                "' başlıklı araştırmanız Tıbbi Araştırmalar Etik Kurulunun (TAEK) "+
                form.ToplantiTarih +
                " tarihli toplantısında değerlendirilmiştir. Başvuru formunuzda ;";

        }

    }
}
