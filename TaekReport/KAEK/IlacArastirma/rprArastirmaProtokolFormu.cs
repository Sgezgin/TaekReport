using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;
using System.Collections.Generic;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprArastirmaProtokolFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprArastirmaProtokolFormu(List<KlinikArastirmaBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
        }

    }
}
