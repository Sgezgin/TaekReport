using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprArastirmaButceFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprArastirmaButceFormu()
        {
            InitializeComponent();
        }

        public rprArastirmaButceFormu(List<TCArastirmaButceFormModel> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}

