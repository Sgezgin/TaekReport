using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprKlinikArastirmaBasvuruFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprKlinikArastirmaBasvuruFormu(object  o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
        }

    }
}
