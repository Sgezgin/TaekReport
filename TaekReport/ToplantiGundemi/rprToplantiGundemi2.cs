using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.ToplantiGundemi
{
    public partial class rprToplantiGundemi2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rprToplantiGundemi2(string toplantiTarih)
        {
            InitializeComponent();
            txtToplantiTarihi.Text = "Toplantı Tarihi : " +toplantiTarih;
            txtToplantiSaati.Text =  "Toplantı Saati  : " ;
        }

    }
}
