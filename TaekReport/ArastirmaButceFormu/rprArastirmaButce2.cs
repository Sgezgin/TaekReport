using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.ArastirmaButceFormu
{
    public partial class rprArastirmaButce2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rprArastirmaButce2(BUTCEFORMU form)
        {
            InitializeComponent();

            lblAyrilanButce.Text = form.AYIRILANBUTCE.ToString();
            lblBKAciklama2.Text = "?";
            lblAdi.Text = "";
            lblSoyadi.Text = "";
            lblTelefon.Text = "";
            lblEposta.Text="";
            lblTarih.Text = "";
           
            

        }

    }
}
