using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.InVitro
{
    public partial class rprInVitroBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprInVitroBasvuruForm()
        {
            InitializeComponent();
        }

        public rprInVitroBasvuruForm(List<InVitroBasvuruFormu> o)
        {
            InitializeComponent();
            if (objectDataSource1 != null)
                objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}
