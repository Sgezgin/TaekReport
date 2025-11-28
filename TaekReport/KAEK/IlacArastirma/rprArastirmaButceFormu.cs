using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;
using System.Collections.Generic;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprArastirmaButceFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprArastirmaButceFormu(List<ArastirmaButceFormModel> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
        }

    }
}
