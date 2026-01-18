using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class KararFormu
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }
        public KLINIKARASTIRMALARBASVURUFORMU KlinikFormu { get; set; }
        public BASVURUKARAR BasvuruKararFormu { get; set; }
        public List<DOSYABILGILERI> listUygunlukDegerlendirilenBelgeler{ get; set; }
        public List<DOSYABILGILERI> listGonulluDokumanlari { get; set; }
        public List<DOSYABILGILERI> listDigerDokumanlar { get; set; }
        public List<DOSYABILGILERI> listArastirmayaIliskinDegerlendirme { get; set; }
        public List<BASVURUETIKKURULUYE> listEtikKurulUyeleri { get; set; }
    }
}