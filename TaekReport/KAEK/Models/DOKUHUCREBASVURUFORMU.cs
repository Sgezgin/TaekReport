using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class DOKUHUCREBASVURUFORMU
    {
        public string DOKUHUCREFORMUGUID { get; set; } = string.Empty;
        public string KAEKID { get; set; }
        public string ARASTIRMAGUID { get; set; }
        public string KULLANICI { get; set; }
        public DateTime? EKLEMETARIH { get; set; }
        public DateTime? GUNCELLEMETARIH { get; set; }
        public string DURUMU { get; set; }

        public long? UYGUN { get; set; }
        public long? RAPORTORUYGUN { get; set; }
        public string IADEACIKLAMA { get; set; }

        // Section 0: Talep Durumu / Gerekçe
        public string TALEP_GEREKCESI { get; set; }

        // Section 1: Hasta Grubunun Tıbbi Durumu veya Hastalık
        public string TESHIS { get; set; }
        public string TESHIS_TARIHI { get; set; }
        public string TIBBI_DURUM { get; set; }
        public string KLINIK_OZET { get; set; }
        public string LABORATUAR_OZETI { get; set; }
        public string ALDIGI_TEDAVILER_CEVAPLAR { get; set; }
        public string TEDAVI_ALANI { get; set; }

        // Section 2: Uygulamanın Amacı
        public string TEMEL_AMAC { get; set; }
        public string IKINCIL_AMACLAR { get; set; }
        public int? ALT_CALISMA_VAR_MI { get; set; }
        public string ALT_CALISMA_DETAY { get; set; }

        // Section 3: Uygulanacak Ürünün Tanımı
        public string URUN_ADI { get; set; }
        public string FARMASOTIK_FORM { get; set; }
        public string TEDAVI_SURESI { get; set; }
        public string UYGULANACAK_DOZ { get; set; }
        public string UYGULAMA_YOLU { get; set; }
        public int? INSANDA_ILK_KEZ_MI { get; set; }
        public int? RISK_FAKTORLERI_VAR_MI { get; set; }
        public string RISK_FAKTORLERI_DETAY { get; set; }
        public string DENENMIS_URUN_OZETI { get; set; }
        public string ETKI_MEKANIZMASI { get; set; }

        // Section 4: Biyolojik / Biyoteknolojik Tıbbi Ürünler
        public string BIYO_URUN_TURU { get; set; }
        public int? BIYO_ASI_MI { get; set; }
        public int? BIYO_GMO_MU { get; set; }
        public int? BIYO_PLAZMA_TUREVLI_MI { get; set; }
        public string BIYO_DIGER_DETAY { get; set; }

        // Section 5: Hücre Terapisi Tıbbi Ürünleri
        public int? HUCRE_KOKEN_OTOLOG { get; set; }
        public int? HUCRE_KOKEN_ALLOJENIK { get; set; }
        public int? HUCRE_KOKEN_KSENOJENIK { get; set; }
        public string HUCRE_KOKEN_TUR_DETAY { get; set; }
        public int? HUCRE_TUR_KOK_HUCRE { get; set; }
        public string HUCRE_TUR_KOK_HUCRE_DETAY { get; set; }
        public int? HUCRE_TUR_AYRISTIRILMIS { get; set; }
        public string HUCRE_TUR_AYRISTIRILMIS_DETAY { get; set; }
        public string HUCRE_TUR_DIGER_DETAY { get; set; }

        // Section 6: Gen Terapisi Tıbbi Ürünleri
        public int? GEN_IN_VIVO { get; set; }
        public int? GEN_EX_VIVO { get; set; }
        public int? GEN_NUKLEIK_ASIT { get; set; }
        public int? GEN_SALT_NAKED { get; set; }
        public int? GEN_KOMPLEKS { get; set; }
        public int? GEN_VIRAL_VEKTOR { get; set; }
        public string GEN_VIRAL_VEKTOR_DETAY { get; set; }
        public string GEN_TRANSFER_DIGER_DETAY { get; set; }
        public int? GEN_DEGISTIRILMIS_HUCRELER { get; set; }
        public int? GEN_HUCRE_OTOLOG { get; set; }
        public int? GEN_HUCRE_ALLOJENIK { get; set; }
        public int? GEN_HUCRE_KSENOJENIK { get; set; }
        public string GEN_HUCRE_KOKEN_DETAY { get; set; }
        public string GEN_HUCRE_DIGER_DETAY { get; set; }
        public string GEN_TERAPISI_YENI_YONLER { get; set; }

        // Section 7: Kriterler ve Tetkikler
        public string BASLAMA_KRITERLERI { get; set; }
        public string SONLANDIRMA_KRITERLERI { get; set; }
        public string UYGULAMA_ESNASINDA_TETKIKLER { get; set; }
        public string UYGULAMA_SONRASI_TETKIKLER { get; set; }

        // Section 8: Uygulama Merkezi ve Veri İzleme Komitesi
        public int? MERKEZ_TEK_MI { get; set; }
        public int? MERKEZ_COK_MU { get; set; }
        public int? VERI_IZLEME_KOMITESI_VAR_MI { get; set; }
        public string VERI_IZLEME_KOMITESI_DETAY { get; set; }

        // Section 9: Personel Bilgileri
        public string SORUMLU_HEKIM_ADSOYAD { get; set; }
        public string SORUMLU_HEKIM_UNVAN { get; set; }
        public string SORUMLU_HEKIM_UZMANLIK { get; set; }
        public string SORUMLU_HEKIM_ADRES { get; set; }
        public string SORUMLU_HEKIM_EPOSTA { get; set; }
        public string SORUMLU_HEKIM_TELEFON { get; set; }
        public string SORUMLU_HEKIM_TCKIMLIK { get; set; }
        public string SORUMLU_HEKIM_GOREVI { get; set; }

        public string UYGULAYICI_HEKIM_ADSOYAD { get; set; }
        public string UYGULAYICI_HEKIM_UNVAN { get; set; }
        public string UYGULAYICI_HEKIM_UZMANLIK { get; set; }
        public string UYGULAYICI_HEKIM_ADRES { get; set; }
        public string UYGULAYICI_HEKIM_EPOSTA { get; set; }
        public string UYGULAYICI_HEKIM_TELEFON { get; set; }
        public string UYGULAYICI_HEKIM_TCKIMLIK { get; set; }
        public string UYGULAYICI_HEKIM_GOREVI { get; set; }

        public string URUN_SORUMLU_ADSOYAD { get; set; }
        public string URUN_SORUMLU_UNVAN { get; set; }
        public string URUN_SORUMLU_UZMANLIK { get; set; }
        public string URUN_SORUMLU_ADRES { get; set; }
        public string URUN_SORUMLU_RUHSATNO { get; set; }
        public string URUN_SORUMLU_EPOSTA { get; set; }
        public string URUN_SORUMLU_TELEFON { get; set; }
        public string URUN_SORUMLU_TCKIMLIK { get; set; }

        public string EKIP_DIGER_ADSOYAD { get; set; }
        public string EKIP_DIGER_UNVAN { get; set; }
        public string EKIP_DIGER_UZMANLIK { get; set; }
        public string EKIP_DIGER_ADRES { get; set; }
        public string EKIP_DIGER_EPOSTA { get; set; }
        public string EKIP_DIGER_TELEFON { get; set; }
        public string EKIP_DIGER_TCKIMLIK { get; set; }
        public string EKIP_DIGER_GOREVI { get; set; }

        // Section 10: Taahhütname
        public int? TAAHHUT_ONAY { get; set; }
        public string TAAHHUT_ADSOYAD { get; set; }
        public string TAAHHUT_TARIH { get; set; }
    }
}

