using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class ARASTIRMADOSYALARI
    {
        public string ARASTIRMAGUID { get; set; }
        public string KOYPAARASTIRMAGUID { get; set; }
        public string KAEKGUID { get; set; }

        public string ARASTIRMATIPI { get; set; }
        public string ARASTIRMAADI { get; set; }
        public string IMAGE { get; set; }

        public string EKLEYENKULLANICI { get; set; }
        public string EKLEMETARIH { get; set; }

        public string DURUMU { get; set; }
        public string SILINDI { get; set; }
        public string SILINDITARIH { get; set; }
        public string SEKRETER { get; set; }
        public string SEKRETERONAY { get; set; }
        public string SEKRETERONAYTARIH { get; set; }
        public string SEKRETERNOT { get; set; }
        public string ILETMETARIH { get; set; }


        public string REDACIKLAMA { get; set; }
        public string KARARONAY { get; set; }
        public string KARARONAYTARIH { get; set; }
        public string KARARONAYKULLANICI { get; set; }
        public string KARARACK { get; set; }
        public string TOPLANTITARIH { get; set; }
        public string DOSYANO { get; set; }

        public string OYTURU { get; set; }
        public string ONKARAR { get; set; }

        public string DURUMKULLANICI { get; set; }
        public string DURUMTARIHI { get; set; }
        public string MINORDUZELTME { get; set; }

        public string DEGISIKLIK { get; set; }
        public string DEGISIKLIKACIKLAMA { get; set; }
        public string DEGISIKLIKSIRA { get; set; }
        public string DEGISIKLIKTARIH { get; set; }
    }
}
