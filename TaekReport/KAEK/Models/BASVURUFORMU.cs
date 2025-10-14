using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class BASVURUFORMU
    {
     
        public string BASVURUFORMUGUID { get; set; }

        public string KAEKID { get; set; }

        public string ARASTIRMAGUID { get; set; }

        public string KULLANICI { get; set; }
        public string KULLANICIFIRMA { get; set; }
        //8 TİP ONU TITAR
        public string ARASTIRMATURU { get; set; }
        public string ARASTIRMAPROTOKOLKODU { get; set; }
        public string ARASTIRMAADI { get; set; }
        public string SORUMLUARASTIRMACI { get; set; }
        public string KURUMANABILIMDALI { get; set; }
        public string ARASTIRMANITELIGIFAZ { get; set; }

        public string DESTEKLEYICI { get; set; }
        public string DESTEKLEYICI2 { get; set; }
        public string DESTEKLEYICITEMSILCI { get; set; }
        public string ARASTIRMASURESI { get; set; }
        public string GONULLUYASARALIGI { get; set; }
    }
}
