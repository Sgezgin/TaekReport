using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.BilgilendirmeFormu
{
    public partial class rprBilgilendirmeFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprBilgilendirmeFormu(BilgilendirmeFormModel model)
        {
            InitializeComponent();
            string ekbelgeler = "";
            lblSorumlu.Text = model.Sorumlu;
            lblEkBilgiler.Text = model.EkBilgiler;

  
            lblSorumlu2.Text = model.Sorumlu;
            lblKurumAnabilimDali.Text = model.KurumAnabilimDali;
            lblTelEposta.Text = model.TelEposta;
            lblArastirmaAdi.Text = model.ArastirmaAdi;
            lblKararNum.Text = model.KararNumarasi;


            int sayac = 1;
            foreach (var item in model.EkBelgelerList)
            {
                ekbelgeler += sayac + " - " + item.EklenenBelge + Environment.NewLine;
                sayac++;
            }
            lblEklenenbelgeler.Text = ekbelgeler;
        }

    }
}
