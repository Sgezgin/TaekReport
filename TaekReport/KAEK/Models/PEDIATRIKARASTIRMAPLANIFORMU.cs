using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
 
    public class PEDIATRIKARASTIRMAPLANIFORMU
    {
        public string PEDIATRIKPLANGUID { get; set; }
        public string KOPYAPEDIATRIKPLANGUID { get; set; }
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        public string KULLANICI { get; set; }

        public string EKLEMETARIH { get; set; }
        public string DURUMU { get; set; }
        public string PEDIAURUNGENELBILGI { get; set; }
        public string PEDIRISKSINIF { get; set; }
        public string FARMAKOKINETIKOZELLIK { get; set; }
        public string URUNDEGERLENDIRME { get; set; }
        public string RISKPLAN { get; set; }
        public string URUNRUHSAT { get; set; }
        public string DOKUMANTARIHI { get; set; }
        public string DOKUMANVERSIYON { get; set; }
        public string OZETBILGI { get; set; }
        public string TASARIMI { get; set; }
    }

}
