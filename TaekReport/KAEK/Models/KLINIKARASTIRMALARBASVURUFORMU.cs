using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
 
    public class KLINIKARASTIRMALARBASVURUFORMU
    {

        public string KABASVURUGUID { get; set; }
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }

        public string KULLANICI { get; set; }

        public DateTime EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }



        public string SOZLEMELIARASTIRMAKURULUS { get; set; }
        public string YASALTEMSILCI { get; set; }
        public string NCTNUMARASI { get; set; }
        public string CTISNUMARASI { get; set; }
        public string ARASTIRMASTATUSU { get; set; }

        public string ARASTIRMANITELIGI { get; set; }

        public string TIBBIDURUMVEHASTALIK { get; set; }
        public string ARASTIRMAYONTEMI { get; set; }
        public string URETIMYERI { get; set; }
        public string KARSILASTIRMAURUNUVEYONTEMI { get; set; }
        public string URETIMYERIKARSILASTIRMA { get; set; }
        public string PLASEBO { get; set; }
        public string URETIMYERIPLASEBO { get; set; }
        public string YARDIMCIBESERITIBBIURUNTURU { get; set; }
        public string URETIMYERIYARDIMCI { get; set; }
        public string CEBELGESIOLMAYAN { get; set; }

        public string ARASTIRMAKOLLARI { get; set; }

        public string ARASTIRMAAMACI { get; set; }
        public string ARASTIRMAKAPSAM { get; set; }

        public string ARASTIRMATASARIM { get; set; }
        public string GONULLUGRUBU { get; set; }
        public string GONULLUYASARALIGI { get; set; }
        public string GONULLUSAYI { get; set; }
        public string GONULLUSAYITR { get; set; }
        public string GONULLUSAYIDAGILIM { get; set; }
        public string DAHILEDILMEKRITERLERI { get; set; }
        public string DAHILEDILMEMEKRITERLERI { get; set; }
        public string ARASTIRMASURESITOPLAM { get; set; }
        public string ARASTIRMASURETR { get; set; }
        public string ARASTIRMAGONULLUBASLAMA { get; set; }
        public string ARASTIRMAGONULLUBITIS { get; set; }
        public string SONNOKTASI { get; set; }
        public string SONUCDEGERLENDIRME { get; set; }
        public string ISTATIKSELANALIZ { get; set; }
        public string KORDINATOR { get; set; }

        public string RUHSATDURUMU { get; set; }
        public string ANALITIKMERKEZ { get; set; }
        public string TESTEDILENURUN { get; set; }
        public string REFERANSURUN { get; set; }
        public string CALISMATASARIMI { get; set; }
        public string CALISMAPERIYOTLARI { get; set; }
        public string ONCEKICALISMALAR { get; set; }
        public string COZUNURLUK { get; set; }
        public string BIYOYARARLANIM { get; set; }
        public string AUC { get; set; }
        public string CMAKS { get; set; }
        public string TMAKS { get; set; }
        public string ELIMINASYONYARIOMRU { get; set; }
        public string DAGILIMHACMI { get; set; }
        public string PROTEINLEREBAGLANMA { get; set; }
        public string YIYECEKETKISI { get; set; }
        public string METABOLIZASYON { get; set; }
        public string ATILIM { get; set; }
        public string BIRIKIM { get; set; }
        public string KANALIMSURELERI { get; set; }
        public string BIYOMUAFIYET { get; set; }
        public string ETKINMADDEDEGISKENLIK { get; set; }
        public string ANALIZIYAPILACAKMADDE { get; set; }
        public string FAYDARISKDEGERLENDIRMESI { get; set; }
        public string HASSASPOPULASYON { get; set; }
        public string GIZLILIK { get; set; }
        public string GONULLULEREODEME { get; set; }
        public string GONULLUHIZMETLERI { get; set; }
        public string ARASTIRMADOKUMANLARI { get; set; }
        public string BAGIMSIZVERIIZLEMEKOMITESI { get; set; }
        public string BIYOLOJIKMATERYALYONETIMI { get; set; }
        public string TESISLABORATUVAR { get; set; }
        public string GOREVDEVRI { get; set; }
        public string DIGERSAGLIKOTORITELERI { get; set; }

        public string ARASTIRMAYAOZGUBILGI { get; set; }
      
        public byte[] ARASTIRMATASARIMSEMASI { get; set; }
   
        

        public byte[] DEGERLENDIRMESEMASI { get; set; }


  
        public int ETIKKURULRED { get; set; }
        public string REDETIKKURULADI { get; set; }
        public DateTime REDETIKKARARTARIH { get; set; }
        public string REDETIKARARNO { get; set; }

        public int ETIKKURULBASVURU { get; set; }
        public string ETIKKURULADI { get; set; }
        public DateTime ETIKKURULBASVURUTARIH { get; set; }
        public int ETIKKURULONAY { get; set; }
        public DateTime ETIKKURULKARARTARIH { get; set; }
        public string ETIKKURULARARNO { get; set; }


    }

}
