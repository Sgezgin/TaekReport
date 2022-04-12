using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.OlurFormu
{
    public partial class rprOlurFormu2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rprOlurFormu2(OLURFORMU form)
        {
            InitializeComponent();
            lblCaslimaninAdi.Text = form.CALISMANINADI;
            lblCalismaAmaci.Text = form.CALISMANINAMACI;
        }

    }
}
