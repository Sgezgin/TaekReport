using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.OnayFormu
{
    public partial class rprOnayFormu : DevExpress.XtraReports.UI.XtraReport
    {
        OnayFormuModel frData = new OnayFormuModel();
        public rprOnayFormu(OnayFormuModel form)
        {
            InitializeComponent();
            frData = form;
            chbARastirmaFrm.Checked = true;
            lblArastirmaAdi.Text = form.ArastirmaAdi;
            lblSorumluArastirmaci.Text = form.SorumluAtastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
            lblKararNum.Text = "Karar Nu: " + form.DosyaNo;
            lblTarih.Text = "Tarih: " + form.ToplantiTarihi;
            lblBaskan.Text = form.Baskan;
        }

        private void chkiliskiEvet_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
           
            chkiliskiEvet.Text = "Evet";
            if (chkiliskiEvet.Text == "1")
                chkiliskiEvet.Checked = true;
            else
                chkiliskiEvet.Checked = false;

     

        }
    }
}
