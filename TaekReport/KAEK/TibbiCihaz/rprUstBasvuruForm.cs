using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprUstBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprUstBasvuruForm()
        {
            InitializeComponent();
        }

        public rprUstBasvuruForm(object obj)
        {
            InitializeComponent();
            objectDataSource1.DataSource = obj;
            this.DataSource = obj;
        }

        private void rprUstBasvuruForm_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}