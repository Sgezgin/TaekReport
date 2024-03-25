using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class OnayFormuModel
    {
        public string ArastirmaAdi { get; set; }
        public string SorumluAtastirmaci { get; set; }
        public string YardimciArastirmaci { get; set; }
        public string KoordinatorMerkez { get; set; }
        public string Destekleyici { get; set; }
        public string ArastirmaTipi { get; set; }
        public string KararOyTuru { get; set; }
        public string Baskan { get; set; }
        public string BaskanTckn { get; set; }
        public string DosyaNo { get; set; }
        public string ToplantiTarihi { get; set; }
        public string BilgilendirmeNot { get; set; }
        public List<EtikKurulUyeler> EtikKurulUyeleri { get; set; }
    }

    public class EtikKurulUyeler
    {
        public string AdiSoyadi { get; set; }
        public string TcKimlikNo { get; set; }
        public string Uzamanlik { get; set; }
        public string Kurum { get; set; }
        public string Cinsiyet { get; set; }
        public string Iliski { get; set; }
        public string Katilim { get; set; }
        public string Mazeret { get; set; }
        public string UyeUnvan { get; set; }
        public int SiraNo { get; set; }

    }
}
