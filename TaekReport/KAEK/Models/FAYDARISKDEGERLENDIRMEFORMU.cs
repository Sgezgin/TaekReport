using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
 
    public class FAYDARISKDEGERLENDIRMEFORMU
    {
        public string FAYDARISKFORMUGUID { get; set; }
        public string KOPYAFAYDARISKFORMUGUID { get; set; }
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        public string KULLANICI { get; set; }

        public string EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }
        public string ARASTIRILANTIBBIHASTALIK { get; set; }
        public string ARASURUNBILGI { get; set; }
        public string ARASRISKSINIF { get; set; }
        public string ARASDEGERLENDIRME { get; set; }
        public string RISKPLAN { get; set; }
        public string ARASURUNRUHSATLI { get; set; }
        public string ARASOZETBILGI { get; set; }
        public string ARASTASARIM { get; set; }
        public string GONULLU { get; set; }
        public string GONULLUDOKUMANIDESTEKLEYICI { get; set; }
        public string ILGILIDOKUMANTARIHI { get; set; }
        public string ILGILIDOKUMANVERSION { get; set; }
        public string DIL { get; set; }
        public string UYGUN { get; set; }
        public string UYGUNDEGIL { get; set; }
    }

}
