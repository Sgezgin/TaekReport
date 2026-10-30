using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class TIBBICIHAZBASVURUFORMU
    {
        
        public string TBBASVURUGUID { get; set; } = string.Empty;
        
        public string KAEKID { get; set; }
        
        public string ARASTIRMAGUID { get; set; }
        
        public string KULLANICI { get; set; }
        public string EKLEMETARIH { get; set; }
        
        public string DURUMU { get; set; }

        // Bolum 1: Sponsor/Destekleyici
        
        public string SPONSORADI { get; set; }
        
        public string SPONSORADRES { get; set; }
        
        public string SPONSORILCE { get; set; }
        
        public string SPONSORSEHIR { get; set; }
        
        public string SPONSORULKE { get; set; }
        
        public string SPONSORTEL { get; set; }
        
        public string SPONSOREMAIL { get; set; }

        
        public string SPONSORIRTIBATKISIAD { get; set; }
        
        public string SPONSORIRTIBATKISITEL { get; set; }
        
        public string SPONSORIRTIBATKISIEMAIL { get; set; }

        public string YASALTEMSILCIVARMI { get; set; } // 1: Evet, 0: Hayır

        
        public string YASALTEMSILCIAD { get; set; }
        
        public string YASALTEMSILCIADRES { get; set; }
        
        public string YASALTEMSILCIILCE { get; set; }
        
        public string YASALTEMSILCISEHIR { get; set; }
        
        public string YASALTEMSILCIULKE { get; set; }
        
        public string YASALTEMSILCITEL { get; set; }
        
        public string YASALTEMSILCIEMAIL { get; set; }

        
        public string YASALTEMSILCIIRTIBATKISIAD { get; set; }
        
        public string YASALTEMSILCIIRTIBATKISITEL { get; set; }
        
        public string YASALTEMSILCIIRTIBATKISIEMAIL { get; set; }
        
        public string IRTIBATKISISECIM { get; set; } // 1: Sponsor, 2: Yasal temsilci, 3: Diger

        
        public string DIGERIRTIBATKISIAD { get; set; }
        
        public string DIGERIRTIBATKISIADRES { get; set; }
        
        public string DIGERIRTIBATKISIILCE { get; set; }
        
        public string DIGERIRTIBATKISISEHIR { get; set; }
        
        public string DIGERIRTIBATKISIULKE { get; set; }
        
        public string DIGERIRTIBATKISITEL { get; set; }
        
        public string DIGERIRTIBATKISIEMAIL { get; set; }

        
        public string KLINIKARASTIRMATIPI { get; set; }
        
        public string BASVURUTIPI { get; set; }
        
        public string CIVID { get; set; }

        
        public string KATILIMCIULKELER_IC { get; set; }
        
        public string KATILIMCIULKELER_DIS { get; set; }

        
        public string CIPKODU { get; set; }
        
        public string CIPVERSIYONU { get; set; }
        public string CIPTARIHI { get; set; }

        
        public string TAMBASLIK { get; set; }
        
        public string KISABASLIK { get; set; }
        
        public string MESLEKTENOLMAYANBASLIK { get; set; }

        // Bolum 2: Aciklama
        public string UZMANHEYETEDANISILMI { get; set; }
        
        public string ARASTIRMATANIMI { get; set; }
        public string INSANUZERINDEILKMI { get; set; }

        
        public string TASARIMMETODOLOJISI { get; set; }
        
        public string TASARIMMETODOLOJISIDIGER { get; set; }

        
        public string GELISTIRMEEVRESI { get; set; }

        
        public string BIRINCILAMAC { get; set; }
        
        public string IKINCILAMAC { get; set; }
        
        public string DIGERAMAC { get; set; }
        
        public string BIRINCILSONLANIM { get; set; }
        
        public string IKINCILSONLANIM { get; set; }
        
        public string DIGERSONLANIM { get; set; }
        
        public string GENELOZET { get; set; }

        
        public string GONULLUSAYISITR { get; set; }
        
        public string GONULLUSAYISIAVRUPA { get; set; }
        
        public string GONULLUSAYISIASYA { get; set; }
        
        public string GONULLUSAYISIAFRIKA { get; set; }
        
        public string GONULLUSAYISIKAMERIKA { get; set; }
        
        public string GONULLUSAYISIGAMERIKA { get; set; }
        
        public string GONULLUSAYISIOKYANUSYA { get; set; }
        
        public string GONULLUSAYISITOPLAM { get; set; }

        public string TAHMINIBASLANGIC { get; set; }
        public string TAHMINIBITIS { get; set; }

        public string HASTALIKLAILGILIMI { get; set; }
        public string NADIRHASTALIKMI { get; set; }
        
        public string TEDAVIALANI { get; set; }
        
        public string CINSIYET { get; set; }
        
        public string DAHILEDILMEKRITER { get; set; }
        
        public string HARICILMEKRITER { get; set; }
        
        public string PLANLANANGONULLUGRUBU { get; set; }
        
        public string PLANLANANGONULLUGRUBUDIGER { get; set; }
        
        public string YASARALIGI { get; set; }
        
        public string CihazINVITROBIRLIKTEMI { get; set; }
        
        public string INVITROPERFORMANSNO { get; set; }
        
        public string CihazBESERIBIRLIKTEMI { get; set; }
        
        public string BESERIKLINIKNO { get; set; }

        
        public string KOORDINATORAD { get; set; }
        
        public string KOORDINATORADRES { get; set; }
        
        public string KOORDINATORILCE { get; set; }
        
        public string KOORDINATORSEHIR { get; set; }
        
        public string KOORDINATORULKE { get; set; }
        
        public string KOORDINATORTEL { get; set; }
        
        public string KOORDINATOREMAIL { get; set; }
        
        public string KOORDINATORUZMANLIK { get; set; }
        
        public string KOORDINATORGOREVYERI { get; set; }
        
        public string KOORDINATORGOREVYERIADRES { get; set; }

        // Bolum 3: Cihazlar
        
        public string CIHAZKULLANIMAMACI { get; set; }
        
        public string CIHAZTIPI { get; set; }
        public string INVAZIVMI { get; set; }
        
        public string EMDNKODU { get; set; }
        
        public string CIHAZTICARIAD { get; set; }
        
        public string CIHAZMODEL { get; set; }
        
        public string CIHAZADI { get; set; }
        
        public string EMDNWEBLINK { get; set; }
        
        public string CIHAZSINIFI { get; set; }
        
        public string SINIFLANDIRMAKURALI { get; set; }
        
        public string CIHAZTANIMI { get; set; }
        
        public string CIHAZAMACI { get; set; }
        public string TIBBIMADDEICERIYORMU { get; set; }
        
        public string TIBBIMADDEADLARI { get; set; }
        
        public string BUTUNLESIKPARCA { get; set; }

        public string UTSKAYITLIMI { get; set; }
        
        public string UTSKURESELNO { get; set; }
        public string CEISARETILIMI { get; set; }
        
        public string CEISARETKAPSAMI { get; set; }
        public string ILAVEPROSEDURINVAZIVMI { get; set; }
        
        public string ILAVEPROSEDURACIKLAMA { get; set; }
        
        public string ONAYLANMISKURULUSNO { get; set; }
        
        public string ONAYLANMISKURULUSAD { get; set; }

        public string ONCEKIABARASTIRMASIVARMI { get; set; }
        
        public string ONCEKIREFERANSNO { get; set; }

        public string ULUSALBILIMSELFIKIRVARMI { get; set; }
        
        public string BILIMSELFIKIRATIFI { get; set; }

        public string IMALATCI_SPONSOR_AYNIMI { get; set; }
        
        public string IMALATCIAD { get; set; }
        
        public string IMALATCIADRES { get; set; }
        
        public string IMALATCIILCE { get; set; }
        
        public string IMALATCISEHIR { get; set; }
        
        public string IMALATCIULKE { get; set; }
        
        public string IMALATCITEL { get; set; }
        
        public string IMALATCIEMAIL { get; set; }

        
        public string IMALATCIIRTIBATKISIAD { get; set; }
        
        public string IMALATCIIRTIBATKISITEL { get; set; }
        
        public string IMALATCIIRTIBATKISIEMAIL { get; set; }

        
        public string YETKILITEMSILCIAD { get; set; }
        public string YETKILITEMSILCIADRES { get; set; }
        
        public string YETKILITEMSILCIILCE { get; set; }
        
        public string YETKILITEMSILCISEHIR { get; set; }
        
        public string YETKILITEMSILCIULKE { get; set; }
        public string YETKILITEMSILCITEL { get; set; }
        
        public string YETKILITEMSILCIEMAIL { get; set; }

        
        public string YETKILITEMSILCIIRTIBATKISIAD { get; set; }
        public string YETKILITEMSILCIIRTIBATKISITEL { get; set; }
        
        public string YETKILITEMSILCIIRTIBAT_EMAIL { get; set; }
        
        public string KARSILASTIRMAVARMI { get; set; }
        
        public string KARSILASTIRMATURU { get; set; }
        
        public string KARSILASTIRMACIHAZ_DURUMU { get; set; }

        public string KARSILASTIRMACIHAZ_CEVARMI { get; set; }
        public string KARSILASTIRMACIHAZ_CEKAPSAMIMI { get; set; }
        public string KARSILASTIRMACIHAZ_UTSVARMI { get; set; }
        
        public string KARSILASTIRMACIHAZ_KURESELNO { get; set; }

        
        public string KARSILASTIRMACIHAZ_JENERIKAD { get; set; }
        
        public string KARSILASTIRMACIHAZ_TICARIAD { get; set; }
        
        public string KARSILASTIRMACIHAZ_MODEL { get; set; }
        
        public string KARSILASTIRMACIHAZ_AD { get; set; }
        
        public string KARSILASTIRMACIHAZ_WEBLINK { get; set; }
        
        public string KARSILASTIRMACIHAZ_SINIF { get; set; }
        
        public string KARSILASTIRMACIHAZ_KURAL { get; set; }
        
        public string KARSILASTIRMACIHAZ_TANIM { get; set; }
        
        public string KARSILASTIRMACIHAZ_AMAC { get; set; }
        public string KARSICIHAZ_TIBBIMADDEVARMI { get; set; }
        
        public string KARSICIHAZ_TIBBIMADDEADLARI { get; set; }
        
        public string KARSILASTIRMACIHAZ_BUTUNLESIK { get; set; }

        
        public string IVDPERFORMANSNO { get; set; }
        
        public string BESERIURUNTANIMLAMANO { get; set; }

        // Bolum 5: Ulusal Bilgi
        public string ARASTIRMAMERKEZBILGISI { get; set; }
        
        public string ETIKKURULKARARI { get; set; }
        
        public string ETIKKURULKARARNO { get; set; }
        public string ETIKKURULKARARTARIHI { get; set; }
        public string ETIKKURULADI { get; set; }
        public string ETIKKURULADRES { get; set; }
        
        public string ETIKKURULILCE { get; set; }
        
        public string ETIKKURULSEHIR { get; set; }
        
        public string ETIKKURULULKE { get; set; }
        public string ETIKKURULTEL { get; set; }
        
        public string ETIKKURULEMAIL { get; set; }

        public string SPONSORSTATU { get; set; }
        public string PLANLANANGONULLUSAYISI { get; set; }
        
        public string DIGERSAGLIKOTORITELERI_HTML { get; set; }
        public string DIGERSAGLIKOTORITELERI { get; set; }
    
    public string DEGERLENDIRMESEMASI_HTML { get; set; }
    public string DEGERLENDIRMESEMASI { get; set; }

    public string UYGUN { get; set; }
    public string RAPORTORUYGUN { get; set; }
    public string IADEACIKLAMA { get; set; }


}
}
