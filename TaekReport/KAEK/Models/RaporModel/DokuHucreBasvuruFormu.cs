using System;
using System.Collections.Generic;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class DokuHucreBasvuruFormu
    {
        public DOKUHUCREBASVURUFORMU DokuHucreFormu { get; set; } = new DOKUHUCREBASVURUFORMU();
        public BASVURUFORMU BASVURUFORMU { get; set; } = new BASVURUFORMU();
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; } = new List<ARASTIRMAEKIBI>();

        // Başvuru Sahibi / İletişim Bilgileri (Kullanıcı Tablosundan)
        public string BasvuruSahibi { get; set; } = "";
        public string BasvuruSahibiUnvan { get; set; } = "";
        public string Telefon { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime? Tarih { get; set; }
        public string TarihFormatli { get; set; } = "";

        // Sorumlu Hekim / Araştırma Sorumlusu
        public string SorumluHekimAdiSoyadi { get; set; } = "";
        public string SorumluHekimUnvan { get; set; } = "";
        public string SorumluHekimUzmanlik { get; set; } = "";
        public string SorumluHekimAdres { get; set; } = "";
        public string SorumluHekimTelefon { get; set; } = "";
        public string SorumluHekimEposta { get; set; } = "";
        public string SorumluHekimTc { get; set; } = "";
        public string SorumluHekimGorev { get; set; } = "";

        // Rapor İçin Biçimlendirilmiş Alanlar
        public string RprAltCalisma { get; set; } = "";
        public string RprInsandaIlkKez { get; set; } = "";
        public string RprRiskFaktorleri { get; set; } = "";
        public string RprBiyoAsi { get; set; } = "";
        public string RprBiyoGmo { get; set; } = "";
        public string RprBiyoPlazma { get; set; } = "";
        public string RprHucreOtolog { get; set; } = "";
        public string RprHucreAllojenik { get; set; } = "";
        public string RprHucreKsenojenik { get; set; } = "";
        public string RprHucreKokHucre { get; set; } = "";
        public string RprHucreAyristirilmis { get; set; } = "";
        public string RprGenInVivo { get; set; } = "";
        public string RprGenExVivo { get; set; } = "";
        public string RprGenNukleik { get; set; } = "";
        public string RprGenSalt { get; set; } = "";
        public string RprGenKompleks { get; set; } = "";
        public string RprGenViral { get; set; } = "";
        public string RprGenDegistirilmis { get; set; } = "";
        public string RprGenHucreOtolog { get; set; } = "";
        public string RprGenHucreAllojenik { get; set; } = "";
        public string RprGenHucreKsenojenik { get; set; } = "";
        public string RprMerkezTekMi { get; set; } = "";
        public string RprMerkezCokMu { get; set; } = "";
        public string RprVeriIzlemeVarMi { get; set; } = "";

        public string RprSorumluHekimDetay { get; set; } = "";
        public string RprUygulayiciHekimDetay { get; set; } = "";
        public string RprUrunSorumluDetay { get; set; } = "";
        public string RprEkipDigerDetay { get; set; } = "";
        public string RprTaahhutBilgi { get; set; } = "";
    }
}

