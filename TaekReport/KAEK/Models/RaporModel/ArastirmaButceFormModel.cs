using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class ArastirmaButceFormModel
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }
        public KLINIKARASTIRMALARBASVURUFORMU KlinikFormu { get; set; }
        public ARASTIRMABUTCEFORMU listArastirmaButceFormu { get; set; }
    }
}
