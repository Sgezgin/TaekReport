using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class GundemDetayList
    {
        public int SiraNo { get; set; }
        public string DosyaNo { get; set; }
        public string ArastirmaAdi { get; set; }
        public string Destekleyici { get; set; }
        public string ArastirmaTipi { get; set; }
        public List<Arastirmaci> SorumluArastirmaci { get; set; }
        public List<Arastirmaci> YardimciArastirmaci { get; set; }
    }
}
