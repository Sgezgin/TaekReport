using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class SIGORTABELGELERI
    {
        public string SIGORTABELGELERIGUID { get; set; }
        public string KAEKID { get; set; }

        public string ARASTIRMAGUID { get; set; }
        public string SIGORTATIPI { get; set; }
        public string KULLANICI { get; set; }
        public string DURUMU { get; set; }
        public string EKLEMETARIH { get; set; }

        public string ACIKLAMA { get; set; }
        public string BASLAMATARIH { get; set; }
        public string BITISTARIH { get; set; }
        public string TANZIMTARIHI { get; set; }
        public string POLICENO { get; set; }
        public string VERSION { get; set; }

        public string BELGEADI { get; set; }
        public string BELGEYOLU { get; set; }
        public string BELGETURU { get; set; }
    }
}
