using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class ArastirmaProtokolFormu
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }
        public ARASTIRMAPROTOKOLFORMU listArastirmaProtokolFormu { get; set; }
        public KLINIKARASTIRMALARBASVURUFORMU KLINIKARASTIRMALARBASVURUFORMU { get; set; }
    }
}
