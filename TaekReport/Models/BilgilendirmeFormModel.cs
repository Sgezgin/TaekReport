using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class BilgilendirmeFormModel
    {
        public string Sorumlu { get; set; }
        public string ArastirmaAdi { get; set; }
        public string KararNumarasi { get; set; }
        public string TelEposta { get; set; }
        public string KurumAnabilimDali { get; set; }
        public string EkBilgiler { get; set; }
        public List<BilgilendirmeList> BilgilendirmeList { get; set; }
        public List<EkBelgelerList> EkBelgelerList { get; set; }
    }

    public class BilgilendirmeList
    {
        public int No { get; set; }
        public string Degisiklik { get; set; }
        public string Aciklama { get; set; }
    }
    
    public class EkBelgelerList
    {
        public string EklenenBelge { get; set; }
    }
}
