using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.ArastirmaProtokolu
{
    public partial class frmArastirmaProtokolu : DevExpress.XtraReports.UI.XtraReport
    {
        public frmArastirmaProtokolu(KlinikArastirmaBasvuruFormu o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
        }

    }
}
