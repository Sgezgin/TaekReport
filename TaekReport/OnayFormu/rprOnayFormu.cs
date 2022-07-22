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
        public rprOnayFormu(OnayFormuModel form)
        {
            InitializeComponent();
            chbARastirmaFrm.Checked = true;

            lblArastirmaAdi.Text = form.ArastirmaAdi;
            lblSorumluArastirmaci.Text = form.SorumluAtastirmaci;
            lblYardimciArastirmaci.Text = form.YardimciArastirmaci;
        }

    }
}
