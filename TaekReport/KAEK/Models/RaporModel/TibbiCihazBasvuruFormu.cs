using System;
using System.Collections.Generic;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class TibbiCihazBasvuruFormu
    {
        public TIBBICIHAZBASVURUFORMU TibbiCihazFormu { get; set; } = new TIBBICIHAZBASVURUFORMU();
        public BASVURUFORMU BASVURUFORMU { get; set; } = new BASVURUFORMU();
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; } = new List<ARASTIRMAEKIBI>();

        // Başvuru Sahibi / İletişim Bilgileri (Kullanıcı Tablosundan)
        public string BasvuruSahibi { get; set; } = "";
        public string BasvuruSahibiUnvan { get; set; } = "";
        public string Telefon { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime? Tarih { get; set; }
        public string TarihFormatli { get; set; } = "";

        // Sorumlu Araştırmacı / Koordinatör Bilgileri (Araştırma Ekibinden veya Kullanıcıdan)
        public string KoordinatorAdiSoyadi { get; set; } = "";
        public string KoordinatorUnvan { get; set; } = "";
        public string KoordinatorUzmanlik { get; set; } = "";
        public string KoordinatorGorevYeri { get; set; } = "";
        public string KoordinatorGorevYeriAdres { get; set; } = "";
        public string KoordinatorTelefon { get; set; } = "";
        public string KoordinatorEposta { get; set; } = "";

        // Sabitlerden Metin Karşılıkları Çözümlenmiş Alanlar (Rapor için)
        public string KlinikArastirmaTipiMetin { get; set; } = "";
        public string BasvuruTipiMetin { get; set; } = "";
        public string GelistirmeEvresiMetin { get; set; } = "";
        public string ArastirmaTanimiMetin { get; set; } = "";
        public string TasarimMetodolojisiMetin { get; set; } = "";
        public string TedaviAlaniMetin { get; set; } = "";
        public string GonulluCinsiyetMetin { get; set; } = "";
        public string GonulluGrubuMetin { get; set; } = "";
        public string YasAraligiMetin { get; set; } = "";
        public string CihazKullanimAmaciMetin { get; set; } = "";
        public string CihazTipiMetin { get; set; } = "";
        public string CihazSinifiMetin { get; set; } = "";
        public string SiniflandirmaKuraliMetin { get; set; } = "";
        public string ButunlesikParcaMetin { get; set; } = "";
        public string CeKapsamiMetin { get; set; } = "";
        public string KarsilastirmaTuruMetin { get; set; } = "";
        public string KarsilastirmaCihazSinifMetin { get; set; } = "";
        public string KarsilastirmaCihazKuralMetin { get; set; } = "";
        public string KarsilastirmaButunlesikMetin { get; set; } = "";
        public string EtikKurulKararMetin { get; set; } = "";
        public string SponsorStatuMetin { get; set; } = "";

        // Rapor İçin Önceden Biçimlendirilmiş Düz Metin Alanları (Tasarımcının hata vermemesi için)
        public string RprSponsorIlceSehirUlke { get; set; } = "";
        public string RprSponsorIletisim { get; set; } = "";
        public string RprSponsorIrtibat { get; set; } = "";
        public string RprYasalTemsilciVarMi { get; set; } = "";
        public string RprYasalTemsilciIlceSehirUlke { get; set; } = "";
        public string RprYasalTemsilciIletisim { get; set; } = "";
        public string RprYasalTemsilciIrtibat { get; set; } = "";
        public string RprIrtibatKisiSecim { get; set; } = "";
        public string RprDigerIrtibatKisiDetay { get; set; } = "";
        public string RprBasvuruTipiVeCivId { get; set; } = "";
        public string RprCipVersiyonVeTarih { get; set; } = "";
        public string RprUzmanHeyeteDanisilmi { get; set; } = "";
        public string RprArastirmaTanimiDetay { get; set; } = "";
        public string RprTasarimMetodolojisiDetay { get; set; } = "";
        public string RprSemasiHtml { get; set; } = "";
        public string RprGonulluSayisiDetay { get; set; } = "";
        public string RprArastirmaSuresiDetay { get; set; } = "";
        public string RprTedaviAlaniDetay { get; set; } = "";
        public string RprIvdBirlikteDetay { get; set; } = "";
        public string RprIlacBirlikteDetay { get; set; } = "";
        public string RprKoordinatorUnvanAd { get; set; } = "";
        public string RprKoordinatorIletisim { get; set; } = "";
        public string RprCihazKullanimAmaciDetay { get; set; } = "";
        public string RprCihazTipiDetay { get; set; } = "";
        public string RprCihazSinifVeKurali { get; set; } = "";
        public string RprTibbiMaddeDetay { get; set; } = "";
        public string RprBiyolojikMateryalDetay { get; set; } = "";
        public string RprCeDurumuDetay { get; set; } = "";
        public string RprUtsVeKureselNo { get; set; } = "";
        public string RprCihazAdlariVeModel { get; set; } = "";
        public string RprOncekiArastirmaDetay { get; set; } = "";
        public string RprBilimselGorusDetay { get; set; } = "";
        public string RprImalatciAdresDetay { get; set; } = "";
        public string RprImalatciIletisimDetay { get; set; } = "";
        public string RprYetkiliTemsilciDetay { get; set; } = "";
        public string RprKarsilastirmaVarMi { get; set; } = "";
        public string RprKarsilastirmaTuruDetay { get; set; } = "";
        public string RprKarsilastirmaCihazDurumu { get; set; } = "";
        public string RprKarsilastirmaCihazDetay { get; set; } = "";
        public string RprEtikKurulKararDetay { get; set; } = "";
        public string RprEtikKurulAdresDetay { get; set; } = "";
        public string RprBasvuruSahibiUnvanAd { get; set; } = "";
        public string RprBasvuruSahibiIletisim { get; set; } = "";
    }
}
