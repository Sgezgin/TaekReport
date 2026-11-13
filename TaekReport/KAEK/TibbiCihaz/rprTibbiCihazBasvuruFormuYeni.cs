using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprTibbiCihazBasvuruFormuYeni : DevExpress.XtraReports.UI.XtraReport
    {
        public rprTibbiCihazBasvuruFormuYeni()
        {
            InitializeComponent();
        }

        public rprTibbiCihazBasvuruFormuYeni(List<TibbiCihazBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}
