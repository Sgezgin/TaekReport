using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprKlinikArastirmaPlani : DevExpress.XtraReports.UI.XtraReport
    {
        public rprKlinikArastirmaPlani()
        {
            InitializeComponent();
        }

        public rprKlinikArastirmaPlani(List<KlinikArastirmaPlaniRaporModel> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}

