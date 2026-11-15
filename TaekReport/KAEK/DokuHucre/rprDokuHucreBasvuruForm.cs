using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.DokuHucre
{
    public partial class rprDokuHucreBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprDokuHucreBasvuruForm()
        {
            InitializeComponent();
        }

        public rprDokuHucreBasvuruForm(List<DokuHucreBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}
