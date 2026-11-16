using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.InVitro
{
    public partial class rprInvitroFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprInvitroFormu()
        {
            InitializeComponent();
        }

        public rprInvitroFormu(List<InVitroBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
        }
    }
}
