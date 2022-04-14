using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.ArastirmaButceFormu
{
    public partial class rprArastirmaButce1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rprArastirmaButce1(BUTCEFORMU form)
        {
            InitializeComponent();

            lblTitckKodu.Text = form.TITCKKODU;
            lblProtokolKodu.Text = form.PROTOKOLKODU;
            lblGonulluOdeme.Text = form.GONULLUODEMELERI;
            lblBKAciklama1.Text = form.BKACIKLAMA; 
            lblArastirmaAdi.Text = "";

            


        }

    }
}
