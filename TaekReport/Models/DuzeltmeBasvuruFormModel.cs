using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class DuzeltmeBasvuruFormModel
    {
        public string Sorumlu { get; set; }
        public string KurumAnabilimDali { get; set; }
        public string TelEposta { get; set; }
        public string ArastirmaAdi { get; set; }
        public string KararNumarasi { get; set; }
        public string EkBilgiler { get; set; }
        public List<DegisikliList> DegisikliList { get; set; }
    }
    public class DegisikliList
    {
        public int No { get; set; }
        public string Degisiklik { get; set; }
        public string Aciklama { get; set; }
    }
}
