using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.DuzeltmeFormu
{
    public partial class rprDuzeltmeFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprDuzeltmeFormu(Duzeltme form)
        {
            InitializeComponent();

            lblArastirmaAdi.Text = "'" + form.ArastirmaAdi + "' " + " araştırmanız Tıbbi Araştırmalar Etik Kurulunun (TAEK) " +
                form.ToplantiTarih + " tarihli toplantısında yeniden değerlendirilmiştir ";

        }

    }
}
