using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprUstBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprUstBasvuruForm(object obj)
        {
            InitializeComponent();
            objectDataSource1.DataSource = obj;
        }

    }
}
