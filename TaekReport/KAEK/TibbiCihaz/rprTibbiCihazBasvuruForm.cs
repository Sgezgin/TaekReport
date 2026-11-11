using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprTibbiCihazBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprTibbiCihazBasvuruForm()
        {
            InitializeComponent();
        }

        public rprTibbiCihazBasvuruForm(List<TibbiCihazBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}

