using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class BasvuruFormModel
    {
        public string ArastirmaAdi { get; set; }
        public string SorumluAdiSoyadi { get; set; }
        public string BavuruNo { get; set; }
        public List<BasvuruFormEkipList> BasvuruFormEkipList { get; set; }
        public List<ArastirmaEkipList> ArastirmaEkipList { get; set; }
        public BasvuruBilgi BasvuruBilgi { get; set; }
    }

    public class BasvuruFormEkipList
    {
        public string Unvan { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sorumluluk { get; set; }
        public string Imza { get; set; }
    }

    public class ArastirmaEkipList
    {
        public string AdiSoyadi { get; set; }
        public string Unvani { get; set; }
        public string UzmanlikAlani { get; set; }
        public string IsAdresi { get; set; }
        public string Eposta { get; set; }
        public string TelefonNumarasi { get; set; }
        public string ArastirmaciTuru { get; set; }
        public bool Sorumlu { get; set; }
    }
    
    public class BasvuruBilgi
    {
        public string ArastirmaTarih { get; set; }
        public string ArastirmaAdi { get; set; }
        public string ArastirmaOzeti { get; set; }
        public string GirisGerekce { get; set; }
        public string ArastirmaninAmaci { get; set; }
        public string ArastirmaHipotez { get; set; }
    }

    public class ArastirmaYontemi
    {
        public string ArastirmaSuresi { get; set; }
        public string ArastirmaYapilacakYer { get; set; }
        public string ArastirmaTipi { get; set; }
        public string E4 { get; set; }
        public string E5 { get; set; }
        public string E6 { get; set; }
        public string E7 { get; set; }
        public string E8 { get; set; }
        public string E9 { get; set; }
        public string E10 { get; set; }
        public string E11 { get; set; }
        public string E12 { get; set; }
        public string E13 { get; set; }
        public string E14 { get; set; }
        public string E15 { get; set; }
    }


}
