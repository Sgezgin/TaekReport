using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.OlurFormu
{
    public partial class rprOlurFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprOlurFormu()
        {
            InitializeComponent();
           // string a = "color:red";
          //  xrRichText2.Html = "<b><h1 style=" + a + " > Bu çalışmanın adı ne? </h1>" + "<b><p>Detay </ p ></b></b>";

            string stly = "color:red";
            txtCalismaAdi.Text= "<h1 style=" + stly + "> Bu çalışmanın adı ne? </h1>< p>Detay </ p > ";
        }

    }
}
