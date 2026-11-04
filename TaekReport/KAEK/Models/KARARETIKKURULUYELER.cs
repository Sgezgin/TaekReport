using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class KARARETIKKURULUYELER
    {
        
        public string ID { get; set; } = "";
        public string UNVANADSOYAD { get; set; } = "";
        public string UZMANLIK { get; set; } = "";
        public string ZORUNLU { get; set; } = "";
        private string _kurumDisi = "H"; // Varsayılan değer

        public string KURUMDISI
        {
            get
            {
                return _kurumDisi == "H" ? "Evet" : "Hayır";
            }
            set
            {
                // Gelen değer "Evet" ise "H", değilse "E" olarak kaydeder
                bool isEvet = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
                _kurumDisi = isEvet ? "H" : "E";
            }
        }
        public string ILISKI { get; set; } = "";
        public string KATILIM { get; set; } = "";
        public string IMZA { get; set; } = "";

    }
}
