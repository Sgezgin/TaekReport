using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.ToplantiGundemi
{
    public partial class rprToplantiGundemiYatay : DevExpress.XtraReports.UI.XtraReport
    {
        public rprToplantiGundemiYatay(string toplantiTarih)
        {
            InitializeComponent();
            txtToplantiTarihi.Text = "Toplantı Tarihi : " +toplantiTarih;
            txtToplantiSaati.Text =  "Toplantı Saati  : " ;
        }

    }
}
