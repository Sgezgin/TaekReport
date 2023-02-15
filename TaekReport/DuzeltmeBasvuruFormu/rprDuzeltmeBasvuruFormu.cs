using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.DuzeltmeBasvuruFormu
{
    public partial class rprDuzeltmeBasvuruFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprDuzeltmeBasvuruFormu(DuzeltmeBasvuruFormModel model)
        {
            InitializeComponent();
            lblSorumlu.Text = model.Sorumlu;
            lblSorumlu2.Text = model.Sorumlu;
            lblKurumAnabilimDali.Text = model.KurumAnabilimDali;
            lblTelEposta.Text = model.TelEposta;
            lblArastirmaAdi.Text = model.ArastirmaAdi;
            lblKararNum.Text = model.KararNumarasi;

        }

    }
}
