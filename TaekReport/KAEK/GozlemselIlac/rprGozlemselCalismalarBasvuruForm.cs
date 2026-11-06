using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.GozlemselIlac
{
    public partial class rprGozlemselCalismalarBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprGozlemselCalismalarBasvuruForm()
        {
            InitializeComponent();
        }

        public rprGozlemselCalismalarBasvuruForm(List<GozlemselCalismalarBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}
