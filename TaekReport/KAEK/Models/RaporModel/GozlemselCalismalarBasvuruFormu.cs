using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class GozlemselCalismalarBasvuruFormu
    {
        public GOZLEMSELCALISMABASVURUFORMU GozlemselFormu { get; set; }
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }
        public string AdiSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime? Tarih { get; set; }
    }
}

