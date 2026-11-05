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
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        
        public string KULLANICI { get; set; }

        public string EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }
        public string TITCKKODU { get; set; }
        public string GONULLUODEME { get; set; }
        public bool ARASTIRMACININKENDISI2 { get; set; } = true;
        public bool ARASTIRMACININKENDISI { get; set; }
        public bool FINANSEEDENKURUM { get; set; }
        public bool HIBEDESTEKSAGLAYANKURUM { get; set; }
        public string BUTCEACIKLAMA { get; set; }
        public string BUTCEONAYLANMAMAACIKLAMA { get; set; }

        public string ARASTIRMABUTCESI { get; set; }
        public string ADSOYAD { get; set; }
        public string TELEFON { get; set; }
        public string EPOSTA { get; set; }
        public string ADSOYAD2 { get; set; }
        public string TELEFON2 { get; set; }
        public string EPOSTA2 { get; set; }
        public string TARIH { get; set; }
        public bool UYGUN { get; set; }
        public bool UYGUNDEGIL
        {
            get
            {
                return !UYGUN;
            }
            set
            {
                UYGUN = !value;
            }
        }
        public string BELGEUYGUNLUK { get; set; } // Karar aşaması belge kontrolü: true=uygun, false=uygun değil, null=karar verilmedi
        public string RAPORTORUYGUN { get; set; }
        public string IADEACIKLAMA { get; set; }

        public string BELGEYOLU { get; set; }
        public string BELGEADI { get; set; }
    }
}
