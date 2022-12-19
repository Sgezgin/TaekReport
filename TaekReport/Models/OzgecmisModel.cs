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
        public string YabanciDil { get; set; }
        public string GorevYeri { get; set; }
        public List<string> EgitimBilgileri { get; set; }
        public List<string> IsTecrubeleri { get; set; }
        public List<string> KlinikArastirmalar { get; set; }
        public List<EgitimBilgileriList> EgitimBilgileriList { get; set; }
        public List<IsTecrubleriList> IsTecrubleriList { get; set; }
        public List<KlinikArastirmalarList> KlinikArastirmalarList { get; set; }
    }

    public class EgitimBilgileriList
    {
        public string Donem { get; set; }
        public string BasDonem { get; set; }
        public string BitDonem { get; set; }
        public string Uzmanlik { get; set; }
        public string Aciklama { get; set; }
    }
    public class IsTecrubleriList
    {
        public string Donem { get; set; }
        public string BasDonem { get; set; }
        public string BitDonem { get; set; }
        public string KurumKurulus { get; set; }
    }
    public class KlinikArastirmalarList
    {
        public string Yil { get; set; }
        public string KurumKurulus { get; set; }
    }

    


}
