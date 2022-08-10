using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.YenidenBasvuruFormu
{
    public partial class rprYenidenBasvuru : DevExpress.XtraReports.UI.XtraReport
    {
        public rprYenidenBasvuru(YetkisizlikFormModel form)
        {
            InitializeComponent();
            lblKararNo.Text = "Karar Nu: " + form.KararNo;
            lblArastirmaAdi.Text = "'" + form.ArastirmaAdi +
                "' başlıklı araştırmanız Tıbbi Araştırmalar Etik Kurulunun (TAEK) " +
                form.ToplantiTarih +
                " tarihli toplantısında yeniden değerlendirilmiştir. ";
        }

    }
}
