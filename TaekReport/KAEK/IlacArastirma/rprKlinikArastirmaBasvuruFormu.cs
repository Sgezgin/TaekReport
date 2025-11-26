using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprKlinikArastirmaBasvuruFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprKlinikArastirmaBasvuruFormu(List<KlinikArastirmaBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource2.DataSource = o;
        }

    }
}
