using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class ARASTIRMABUTCEFORMU
    {
        public string ARASBUTCEFORMUGUID { get; set; }
        public string KOPYAARASBUTCEFORMUGUID { get; set; }
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        
        public string KULLANICI { get; set; }

        public string EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }
        public string TITCKKODU { get; set; }
        public string GONULLUODEME { get; set; }
        public string ARASTIRMACININKENDISI { get; set; }
        public string FINANSEEDENKURUM { get; set; }
        public string HIBEDESTEKSAGLAYANKURUM { get; set; }
        public string BUTCEACIKLAMA { get; set; }
        public string BUTCEONAYLANMAMAACIKLAMA { get; set; }

        public string ARASTIRMABUTCESI { get; set; }
    }
}
