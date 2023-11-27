using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.ToplantiGundemi
{
    public partial class rprToplantiGundemi : DevExpress.XtraReports.UI.XtraReport
    {
        public rprToplantiGundemi(ToplantiGundemiModel model)
        {
            InitializeComponent();
        }

    }
}
