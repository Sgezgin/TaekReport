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
        public string DosyaNo { get; set; }
        public string SorumluAdiSoyadi { get; set; }
        public string BavuruNo { get; set; }
        public string ArsivTaahhutnameTarih { get; set; }
        public string Destekleyici { get; set; }
        public string ToplamButce { get; set; }
        public string IletmeTarih { get; set; }
        public List<BasvuruFormEkipList> BasvuruFormEkipList { get; set; }
        public List<ArastirmaEkipList> ArastirmaEkipList { get; set; }
        public BasvuruBilgi BasvuruBilgi { get; set; }
        public ArastirmaYontemi ArastirmaYontemi { get; set; }
        public List<string> GuncelKaynakListesi { get; set; }
        public EtikIlkelerList EtikIlkelerList { get; set; }
        public List<OLURFORMU> OlurFormList { get; set; }
        public List<OzgecmisModel> OzgecmisModelList { get; set; }
        public VeriKullanimTaahhutname VeriKullanimTaahhutname { get; set; }
        public List<CokMerkezliArastirmaciList> CokMerkezliArastirmaciList { get; set; }
        public SorumluBilgi SorumluBilgi { get; set; }
    }

    public class CokMerkezliArastirmaciList
    {
        public string AdiSoyadi { get; set; }
        public string MerkezAdi { get; set; }
    }
    public class VeriKullanimTaahhutname
    {
        public string EklemeTarih { get; set; }
        public string AnabilimDali { get; set; }
        public int Secim1 { get; set; } = 0;
        public int Secim2 { get; set; } = 0;
    }

    public class EtikIlkelerList
    {
        public string G1 { get; set; }
        public string G2 { get; set; }
        public string G3 { get; set; }
        public string G4 { get; set; }
        public string G5 { get; set; }
        public string G6 { get; set; }
        public string G7 { get; set; }
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
        public string YabanciDil { get; set; }
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
