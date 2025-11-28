using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    class FaydaRiskDegerlendirmeFormu
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }
        public FAYDARISKDEGERLENDIRMEFORMU listFaydaRiskDegerlendirmeFormu { get; set; }
    }
}
