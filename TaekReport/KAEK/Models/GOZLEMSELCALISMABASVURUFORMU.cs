using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class GOZLEMSELCALISMABASVURUFORMU
    {
        public string GOZLEMSELCALISGUID { get; set; }
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        public string KULLANICI { get; set; }
        public string EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }

        // --- GENEL BİLGİLER ---
        public string ARASTIRMAACIKADI { get; set; }
        public string ARASTIRMASTATUSU { get; set; }
        public string ARASTIRMASTATUSUACIKLAMA { get; set; }
        public string TIBBIDURUMVEHASTALIK { get; set; }
        public string ARASTIRILANETKINMADDE { get; set; }
        public string ARASTIRMAAMACI { get; set; }
        public string GONULLUGRUBU { get; set; }
        public string GONULLUYASARALIGI { get; set; }
        public string GONULLUSAYI { get; set; }
        public string GONULLUSAYITR { get; set; }
        public string DAHILEDILMEKRITERLERI { get; set; }
        public string DAHILEDILMEMEKRITERLERI { get; set; }
        public string ARASTIRMASURESITOPLAM { get; set; }
        public string ARASTIRMASURETR { get; set; }
        public string ARASTIRMAGONULLUBASLAMA { get; set; }
        public string ARASTIRMAGONULLUBITIS { get; set; }
        public string GONULLUTAKIPSURESI { get; set; }
        public string ISTATIKSELANALIZ { get; set; }
        public string KORDINATOR { get; set; }

        // --- DİĞER BİLGİLER ---
        public string HASSASPOPULASYON { get; set; }
        public string GIZLILIK { get; set; }
        public string GONULLULEREODEME { get; set; }
        public string ARASTIRMADOKUMANLARI { get; set; }
        public string BAGIMSIZVERIIZLEMEKOMITESI { get; set; }
        public string TESISLABORATUVAR { get; set; }
        public string GOREVDEVRI { get; set; }
        public string DIGERSAGLIKOTORITELERI { get; set; }

        // --- DEĞERLENDİRME ÇİZELGESİ ---
        public string DEGERLENDIRMESEMASI { get; set; }

        // --- ETİK KURUL BİLGİLERİ ---
        public int? ETIKKURULRED { get; set; }
        public string REDETIKKURULADI { get; set; }
        public string REDETIKKARARTARIH { get; set; }
        public string REDETIKARARNO { get; set; }

        public int? ETIKKURULBASVURU { get; set; }
        public string ETIKKURULADI { get; set; }
        public string ETIKKURULBASVURUTARIH { get; set; }

        public int? ETIKKURULONAY { get; set; }
        public string ETIKKURULKARARTARIH { get; set; }
        public string ETIKKURULARARNO { get; set; }
    }
}

