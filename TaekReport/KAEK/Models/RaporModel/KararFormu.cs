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
        public string listArastirmaEkibi { get; set; }
        public KLINIKARASTIRMALARBASVURUFORMU KlinikFormu { get; set; }
        public BASVURUKARAR BasvuruKararFormu { get; set; }
        public ARASTIRMAPROTOKOLFORMU ArastirmaProtokolFormu { get; set; }
        public List<DOSYABILGILERI> listBGOF { get; set; }
        public List<DOSYABILGILERI> listArastirmaciBrosuru { get; set; }
        public List<DOSYABILGILERI> listArastirmaUrunDosyasi { get; set; }
        public List<DOSYABILGILERI> listOlguRaporFormu { get; set; }
        public List<DOSYABILGILERI> listAraAnalizVeriIzleme { get; set; }
        public List<SIGORTABELGELERI> listSigortaBelgeleri { get; set; }
        public List<DOSYABILGILERI> listMonitor { get; set; }
        public List<DOSYABILGILERI> listUygunlukDegerlendirilenBelgeler{ get; set; }
        public List<DOSYABILGILERI> listGonulluDokumanlari { get; set; }
        public List<DOSYABILGILERI> listDigerDokumanlar { get; set; }
        public List<DOSYABILGILERI> listArastirmayaIliskinDegerlendirme { get; set; }
        public List<BASVURUETIKKURULUYE> listEtikKurulUyeleri { get; set; }
    }
}