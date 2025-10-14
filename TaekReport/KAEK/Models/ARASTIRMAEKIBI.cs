using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class ARASTIRMAEKIBI
    {

        public string ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }

        public string UNVANGUID { get; set; }
        public string MERKEZGUID { get; set; }
        public string EGITIMI { get; set; }
        public string EGITIMIGCP { get; set; }

        public string UZMANLIKALANI { get; set; }
        public string ISADRESI { get; set; }
        public string EPOSTA { get; set; }
        public string TELEFON { get; set; }
        public byte[] RESIM { get; set; }
        public string BASVURUGUID { get; set; }
        public string ARASTIRMAGUID { get; set; }

        public string ARASTIRMACITURU { get; set; }
        public int SILINDI { get; set; }
        public string SILENKULLANICI { get; set; }
        public DateTime SILMETARIHI { get; set; }
        public string GOREVI { get; set; }
        public string AVESISLINK { get; set; }
        public string ANABILIMDALI { get; set; }
        public long TCKIMLIKNO { get; set; }

        public int IMZA { get; set; }
    }
}
