using System;

namespace TaekReport.KAEK.Models
{
    public class TCARASTIRMABUTCEFORMU
    {
        public string TCARASBUTCEFORMUGUID { get; set; } = string.Empty;
        public string ARASBUTCEFORMUGUID { get; set; } = string.Empty;
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        public string KULLANICI { get; set; }
        public DateTime? EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }

        public int? ARASTIRMACININKENDISI { get; set; } // Destekleyici (1/0)
        public string BUTCEACIKLAMA { get; set; } // Destekleyici Açıklaması

        public int? FINANSEEDENKURUM { get; set; } // Araştırma Fonları (1/0)
        public string BUTCEONAYLANMAMAACIKLAMA { get; set; } // Araştırma Fonları Açıklaması

        public int? HIBEDESTEKSAGLAYANKURUM { get; set; } // Diğer (1/0)
        public string TITCKKODU { get; set; } // Diğer Açıklaması

        public string GONULLUODEME { get; set; }
        public string ARASTIRMABUTCESI { get; set; }

        public string ADSOYAD { get; set; }
        public string TELEFON { get; set; }
        public string EPOSTA { get; set; }
        public string TARIH { get; set; }

        public long? UYGUN { get; set; }
        public bool? BELGEUYGUNLUK { get; set; }
        public long? RAPORTORUYGUN { get; set; }
        public string IADEACIKLAMA { get; set; }
    }
}

