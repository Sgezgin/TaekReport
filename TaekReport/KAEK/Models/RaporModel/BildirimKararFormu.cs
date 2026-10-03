using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class BildirimKararFormu
	{
		public string BASKAN { get; set; }
		public string BASKANUNVAN { get; set; }
		public BASVURUFORMU BASVURUFORMU { get; set; }
		public KLINIKARASTIRMALARBASVURUFORMU KlinikFormu { get; set; }
		public ARASTIRMADOSYALARI ARASTIRMADOSYALARI { get; set; }
        public List<ARASTIRMABILDIRIMLERI> ARASTIRMABILDIRIMLERI { get; set; }
    }
}
