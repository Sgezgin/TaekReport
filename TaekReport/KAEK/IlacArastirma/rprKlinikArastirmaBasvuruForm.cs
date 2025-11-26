using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprKlinikArastirmaBasvuruForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rprKlinikArastirmaBasvuruForm(List<KlinikArastirmaBasvuruFormu> o)
        {
            InitializeComponent(); InitializeComponent();
            objectDataSource1.DataSource = o; 
        }

    }
}
