using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class Degerlendirme
    {
        public string SorumluArastirmaci { get; set; }
        public string YardimciArastirmacilar { get; set; }
        public string ArastirmaAdi { get; set; }
        public string Nitelik { get; set; }
        public string GonulluSayisi { get; set; }
        public string Amac { get; set; }
        public string Destekleyici { get; set; }
        public string Sure { get; set; }
        public string Butce { get; set; }
        public string DosyaNo { get; set; }
        public string ToplantiTarihi { get; set; }
        public List<DegerlendirmeDetay> DegerlendirmeDetay { get; set; }
    }

    public class DegerlendirmeDetay
    {
        public string Hakem { get; set; }
        public string Aciklama { get; set; }
        public string Kod { get; set; }
        public string Tarih { get; set; }
    }
}
