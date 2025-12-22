using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;
using System.Collections.Generic;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprRaportorDegerlendirmeFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprRaportorDegerlendirmeFormu(List<RaportorDegerlendirmeFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
        }
        
    }
}
