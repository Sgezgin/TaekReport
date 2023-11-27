using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class ToplantiGundemiModel
    {
        public DateTime ToplantiTarihi { get; set; }
        public string ToplantiSaati { get; set; }
        public List<GundemDetayList> GundemDetayList { get; set; }
    }


    public class Arastirmaci
    {
        public string ArastirmaciAdi { get; set; }
    }
}
