using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class TCUstBasvuruModel
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public TIBBICIHAZBASVURUFORMU TIBBICIHAZBASVURUFORMU { get; set; }
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; }

        public string ArastirmaninSekli { get; set; }
        public string BasvurununSekli { get; set; }
        public string ArastirmaAdi { get; set; }
        public string EtikKurulIlkOnay { get; set; }
        public string ArastirmaKodu { get; set; }
        public string DestekleyiciAdi { get; set; }
        public string YasalTemsilciAdi { get; set; }
        public string KoordinatorAdi { get; set; }
        public string KoordinatorMerkez { get; set; }
        public string MerkezIsimleri { get; set; }
        public string GenelOzet { get; set; }

        public string BasvuruSahibi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}