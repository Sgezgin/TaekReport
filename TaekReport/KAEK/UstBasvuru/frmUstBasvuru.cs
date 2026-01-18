using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models;

namespace TaekReport.KAEK.UstBasvuru
{
    public partial class frmUstBasvuru : DevExpress.XtraReports.UI.XtraReport
    {
        public frmUstBasvuru(object obj)
        {
            InitializeComponent();
            objectDataSource1.DataSource = obj;
           
        }

    }
}
