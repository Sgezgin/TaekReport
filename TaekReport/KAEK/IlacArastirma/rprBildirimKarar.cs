using System;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
	public partial class rprBildirimKarar : DevExpress.XtraReports.UI.XtraReport
	{
		public rprBildirimKarar(List<BildirimKararFormu> a)
		{
			InitializeComponent();
			objectDataSource1.DataSource = a;
		}

	}
}
