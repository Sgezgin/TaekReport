using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class BUTCEFORMU
    {
        public string TITCKKODU { get; set; }
        public string PROTOKOLKODU { get; set; }
        public string GONULLUODEMELERI { get; set; }
        public int BKARASTIRMACI { get; set; }
        public int BKFINANSKURULUS { get; set; }
        public int BKHIBEDESTEK { get; set; }
        public string BKACIKLAMA { get; set; }
        public string FINANSPLANI { get; set; }
        public double AYIRILANBUTCE { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        public string DESTEKLEYICI { get; set; }
        public string DESTEKLEYICIADRES { get; set; }
        public string DESTEKLEYICITELEFON { get; set; }
        public string DESTEKLEYICIEPOSTA { get; set; }
        public string YASALTEMSILCI { get; set; }
        public string YASALTEMSILCIADRES { get; set; }
        public string YASALTEMSILCITELEFON { get; set; }
        public string YASALTEMSILCIEPOSTA { get; set; }
        public string SORUMLU { get; set; }
        public DateTime? IMZATARIH { get; set; }

    }

}
