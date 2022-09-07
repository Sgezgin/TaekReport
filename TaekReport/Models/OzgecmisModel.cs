using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class OzgecmisModel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Unvan { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Tckn { get; set; }
        public string Email { get; set; }
        public string DogumTarihi { get; set; }
        public List<string> EgitimBilgileri { get; set; }
        public List<string> IsTecrubeleri { get; set; }
        public List<string> KlinikArastirmalar { get; set; }
    }

    
}
