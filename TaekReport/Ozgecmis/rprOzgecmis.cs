using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.Ozgecmis
{
    public partial class rprOzgecmis : DevExpress.XtraReports.UI.XtraReport
    {
        public rprOzgecmis(OzgecmisModel model)
        {
            InitializeComponent();

            lblAdi.Text = model.Adi;
            lblSoyadi.Text = model.Soyadi;
            lblAdres.Text = model.Adres;
        }

    }
}
