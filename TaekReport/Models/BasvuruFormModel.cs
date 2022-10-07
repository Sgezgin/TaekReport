using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class BasvuruFormModel
    {
        public string ArastirmaAdi { get; set; }
        public string SorumluAdiSoyadi { get; set; }
        public string BavuruNo { get; set; }
        public List<BasvuruFormEkipList> BasvuruFormEkipList { get; set; }
    }

    public class BasvuruFormEkipList
    {
        public string Unvan { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sorumluluk { get; set; }
        public string Imza { get; set; }
    }
}
