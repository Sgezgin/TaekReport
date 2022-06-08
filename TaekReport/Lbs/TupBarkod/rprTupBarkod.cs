using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;


namespace TaekReport.Lbs.TupBarkod
{
    public partial class rprTupBarkod : DevExpress.XtraReports.UI.XtraReport
    {
        public rprTupBarkod(TUPBARKOD obj)
        {
            InitializeComponent();
            xrBarCode1.Text = obj.BarkodNo;
            lblAdiSoyadi.Text = obj.AdiSoyadi;
            lblLab.Text = obj.Lab;
            lblTarihSaat.Text = obj.TarihSaat;
            lblTup.Text = obj.Tup;
        }

    }
}
