using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class YetkisizlikFormModel
    {
        public string KararNo { get; set; }
        public string ArastirmaAdi { get; set; }
        public string ToplantiTarih { get; set; }
        public List<string> Kararlar { get; set; }

    }
    
}
