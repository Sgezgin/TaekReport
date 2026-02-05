using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class DuzeltmeAciklamaRaporu
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public ARASTIRMADOSYALARI ARASTIRMADOSYALARI { get; set; }
        public  List<HAKEMDUZELTMEDETAY> ListGorus { get; set; }


    }
}
