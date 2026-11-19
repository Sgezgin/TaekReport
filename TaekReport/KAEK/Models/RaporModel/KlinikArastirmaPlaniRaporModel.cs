using System;
using System.Collections.Generic;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class CipRaporMaddeItem
    {
        public int MaddeNo { get; set; }
        public string MaddeNoFormatted => MaddeNo + ".";
        public string MaddeBaslik { get; set; } = "";
        public string AltMaddeler { get; set; } = "";
        public bool HasAltMaddeler => !string.IsNullOrWhiteSpace(AltMaddeler);
        public string Yanit { get; set; } = "";
        public bool HasYanit => !string.IsNullOrWhiteSpace(Yanit);
    }

    public class KlinikArastirmaPlaniRaporModel
    {
        public string ARASTIRMAGUID { get; set; } = "";
        public string ArastirmaAdi { get; set; } = "";
        public string ProtokolKodu { get; set; } = "";
        public string SorumluArastirmaci { get; set; } = "";
        public string Sponsor { get; set; } = "";
        public string Tarih { get; set; } = "";

        public List<CipRaporMaddeItem> Maddeler { get; set; } = new List<CipRaporMaddeItem>();

        public string CipOzetiHtml { get; set; } = "";
        public bool HasCipOzeti => !string.IsNullOrWhiteSpace(CipOzetiHtml);
    }
}

