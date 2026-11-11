using System;
using System.Collections.Generic;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class TCArastirmaButceFormModel
    {
        public TCARASTIRMABUTCEFORMU ButceFormu { get; set; } = new TCARASTIRMABUTCEFORMU();
        public BASVURUFORMU BASVURUFORMU { get; set; } = new BASVURUFORMU();
        public TIBBICIHAZBASVURUFORMU TibbiCihazFormu { get; set; } = new TIBBICIHAZBASVURUFORMU();
        public List<ARASTIRMAEKIBI> listArastirmaEkibi { get; set; } = new List<ARASTIRMAEKIBI>();

        // Form 8.docx Görüntüleme Alanları (GUID İçermeyen, Çözümlenmiş Başlıklar)
        public string ArastirmaAdi { get; set; } = "";
        public string KoordinatorAdiSoyadi { get; set; } = "";
        public string KoordinatorMerkezAdi { get; set; } = "";
        public string DestekleyiciBilgisi { get; set; } = "";
        public string YasalTemsilciBilgisi { get; set; } = "";

        // Bütçe Kaynağı
        public string ButceKaynagiDestekleyiciChecked { get; set; } = "[  ]";
        public string DestekleyiciAciklama { get; set; } = "";

        public string ButceKaynagiFonlarChecked { get; set; } = "[  ]";
        public string FonlarAciklama { get; set; } = "";

        public string ButceKaynagiDigerChecked { get; set; } = "[  ]";
        public string DigerAciklama { get; set; } = "";

        // Ödeme ve Bütçe
        public string GonulluOdeme { get; set; } = "";
        public string ArastirmaButcesi { get; set; } = "";

        // İmza Yetkilisi / Beyan
        public string ImzaYetkilisiAdSoyad { get; set; } = "";
        public string ImzaYetkilisiTelefon { get; set; } = "";
        public string ImzaYetkilisiEposta { get; set; } = "";
        public string Tarih { get; set; } = "";
    }
}

