using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.TibbiCihaz
{
    public partial class rprTibbiCihazBasvuruFormuYeni : DevExpress.XtraReports.UI.XtraReport
    {
        public static readonly Dictionary<string, string> SiniflandirmaKurallari = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "SKR001", "Kural 1 - İnvaziv olmayan cihazlar ve hiçbir kural uygulanamaz" },
            { "SKR002", "Kural 2 - Kanın, vücut sıvılarının, hücrelerin veya dokuların, sıvıların veya gazların tatbik edilmesi veya infüze edilmesi için aktarılması veya muhafazası" },
            { "SKR003", "Kural 3 - Vücuda implante edilmesi veya tatbik edilmesi amaçlanan insan doku veya hücrelerinin, kanın, diğer vücut sıvılarının ya da başka sıvıların modifikasyonu" },
            { "SKR004", "Kural 4 - Hasarlı deri veya hasarlı mukoz membranla temas eden invaziv olmayan cihazlar" },
            { "SKR005", "Kural 5 - Cerrahi invaziv cihazlar hariç olmak üzere, vücut açıklıklarına ilişkin invaziv cihazlar" },
            { "SKR006", "Kural 6 - Geçici kullanımı amaçlanan cerrahi invaziv cihazlar (< 60 dakika)" },
            { "SKR007", "Kural 7 - Geçici kullanımı amaçlanan cerrahi invaziv cihazlar (> 60 dakika, < 30 gün)" },
            { "SKR008", "Kural 8 - İmplante edilebilir cihazlar ve uzun süreli cerrahi invaziv cihazlar (> 30 gün)" },
            { "SKR009", "Kural 9 - Enerji vermesi veya enerji değişimi yapması amaçlanan aktif terapötik cihazlar" },
            { "SKR010", "Kural 10 - Tanılama ve izlemeye yönelik tasarlanan aktif cihazlar" },
            { "SKR011", "Kural 11 - Tanılama veya terapötik amaçlı kararlar almak için kullanılan bilgileri sağlayan yazılımlar" },
            { "SKR012", "Kural 12 - Tıbbi ürünleri, vücut sıvılarını veya diğer maddeleri vücuda tatbik etme ve/veya vücuttan uzaklaştırma amaçlı aktif cihazlar" },
            { "SKR013", "Kural 13 - Diğer aktif cihazların tümü" },
            { "SKR014", "Kural 14 - Ayrı olarak kullanıldığında tıbbi ürün olarak kabul edilebilen bir maddeyi bütünleşik bir parça olarak ihtiva eden cihazlar" },
            { "SKR015", "Kural 15 - Doğum kontrolü veya cinsel yolla bulaşan hastalıkların bulaşmasının önlenmesi için kullanılan cihazlar" },
            { "SKR016", "Kural 16 - Kontak lensleri dezenfekte etme, sterilize etme, temizleme, durulama cihazları veya nemlendirme" },
            { "SKR017", "Kural 17 - X-ışınıyla oluşturulan tanısal görüntüleri kaydetmesi amaçlanan cihazlar" },
            { "SKR018", "Kural 18 - İnsan veya hayvan kaynaklı dokular veya hücreler ya da bunların türevleri kullanılarak imal edilen cihazlar" },
            { "SKR019", "Kural 19 - Nanomateryal ihtiva eden veya nanomateryalden oluşan cihazlar" }
        };

        public static readonly Dictionary<string, string> KullanimAmaclari = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "CKA001", "Yaralanma veya sakatlığın hafifletilmesi" },
            { "CKA002", "Hastalığın hafifletilmesi" },
            { "CKA003", "Yaralanma veya sakatlığın kompense edilmesi" },
            { "CKA004", "Gebeliğin önlenmesine veya desteklenmesine yönelik cihazlar" },
            { "CKA005", "Yaralanma veya sakatlığın tanısı" },
            { "CKA006", "Hastalığın tanısı" },
            { "CKA007", "Anatominin veya fizyolojik ya da patolojik bir süreç veyahut durumun araştırılması" },
            { "CKA008", "Yaralanma veya sakatlığın izlenmesi" },
            { "CKA009", "Hastalığın izlenmesi" },
            { "CKA010", "Tıbbi amacı olmayan ancak TCY Ek XVI'da listelenen cihaz grubuna ait olan bir cihaz" },
            { "CKA011", "Hastalığın tahmini" },
            { "CKA012", "Hastalığın önlenmesi" },
            { "CKA013", "Cihazların temizliği, dezenfeksiyonu veya sterilizasyonu için özel olarak tasarlanan ürünleri" },
            { "CKA014", "Hastalığın prognozu" },
            { "CKA015", "Organ, kan ve doku bağışları dâhil olmak üzere, insan vücudundan elde edilen örneklerin in vitro tetkiki vasıtasıyla bilgi sağlanması" },
            { "CKA016", "Anatominin ya da bir fizyolojik yahut patolojik sürecin veya durumun; araştırılması, ikame edilmesi veya modifikasyonu" },
            { "CKA017", "Yaralanma veya sakatlığın tedavisi" },
            { "CKA018", "Hastalığın tedavisi" }
        };

        public static readonly Dictionary<string, string> TedaviAlanlari = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "TDA001", "Dolaşım sistemi: kardiyovasküler/lenfatik" },
            { "TDA002", "Endokrinoloji ve diyabet" },
            { "TDA003", "Gastroenteroloji & hepatoloji" },
            { "TDA004", "Genel ve plastik cerrahi" },
            { "TDA005", "Diş hekimliği" },
            { "TDA006", "Nefroloji & üroloji" },
            { "TDA007", "Nöroloji" },
            { "TDA008", "Doğurganlık dâhil obstetrik & jinekoloji" },
            { "TDA009", "Oftalmoloji" },
            { "TDA010", "Ortopedi, travmatoloji, rehabilitasyon" },
            { "TDA011", "Solunum, anesteziyoloji, yoğun bakım" },
            { "TDA012", "Diğer" }
        };

        public static readonly Dictionary<string, string> CihazSiniflari = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "CSN001", "Sınıf I" },
            { "CSN002", "Sınıf II A" },
            { "CSN003", "Sınıf II B" },
            { "CSN004", "Sınıf III" }
        };

        public rprTibbiCihazBasvuruFormuYeni()
        {
            InitializeComponent();
            InitMultiSelectFields();
        }

        public rprTibbiCihazBasvuruFormuYeni(List<TibbiCihazBasvuruFormu> o)
        {
            InitializeComponent();
            objectDataSource1.DataSource = o;
            this.DataSource = o;
            InitMultiSelectFields();
        }

        private void InitMultiSelectFields()
        {
            HideUnselectedLabels();
            ConfigureContainers();
            ConfigureKoordinatorSection();
            AttachBeforePrintEvents();
        }

        private void HideUnselectedLabels()
        {
            XRLabel[] allChildLabels = {
                // SINIFLANDIRMAKURALI (lbl476 - lbl494)
                lbl476, lbl477, lbl478, lbl479, lbl480, lbl481, lbl482, lbl483, lbl484,
                lbl485, lbl486, lbl487, lbl488, lbl489, lbl490, lbl491, lbl492, lbl493, lbl494,
                // KARSILASTIRMACIHAZ_KURAL (lbl711 - lbl729)
                lbl711, lbl712, lbl713, lbl714, lbl715, lbl716, lbl717, lbl718, lbl719,
                lbl720, lbl721, lbl722, lbl723, lbl724, lbl725, lbl726, lbl727, lbl728, lbl729,
                // CIHAZKULLANIMAMACI (lbl402 - lbl419)
                lbl402, lbl403, lbl404, lbl405, lbl406, lbl407, lbl408, lbl409, lbl410,
                lbl411, lbl412, lbl413, lbl414, lbl415, lbl416, lbl417, lbl418, lbl419,
                // TEDAVIALANI (lbl293 - lbl304)
                lbl293, lbl294, lbl295, lbl296, lbl297, lbl298, lbl299, lbl300, lbl301, lbl302, lbl303, lbl304,
                // CIHAZSINIFI (lbl469 - lbl472)
                lbl469, lbl470, lbl471, lbl472,
                // KARSILASTIRMACIHAZ_SINIF (lbl705 - lbl708)
                lbl705, lbl706, lbl707, lbl708
            };

            foreach (var l in allChildLabels)
            {
                if (l != null)
                {
                    l.Visible = false;
                    l.ExpressionBindings.Clear();
                    l.Text = string.Empty;
                }
            }
        }

        private void ConfigureContainers()
        {
            XRLabel[] containers = { lbl475, lbl710, lbl401, lbl292, lbl468, lbl704 };
            foreach (var c in containers)
            {
                if (c == null) continue;
                c.ExpressionBindings.Clear();
                c.Borders = DevExpress.XtraPrinting.BorderSide.All;
                c.BorderWidth = 1F;
                c.BorderColor = Color.FromArgb(110, 110, 110);
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
                c.Font = new Font("Arial", 9F, FontStyle.Regular);
                c.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 4, 4, 100F);
                c.Multiline = true;
                c.WordWrap = true;
                c.CanGrow = true;
                c.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            }
        }

        private void AttachBeforePrintEvents()
        {
            if (lbl475 != null)
            {
                lbl475.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    lbl475.Text = FormatSelected(data?.TibbiCihazFormu?.SINIFLANDIRMAKURALI, data?.SiniflandirmaKuraliMetin, SiniflandirmaKurallari);
                };
            }

            if (lbl710 != null)
            {
                lbl710.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    lbl710.Text = FormatSelected(data?.TibbiCihazFormu?.KARSILASTIRMACIHAZ_KURAL, data?.KarsilastirmaCihazKuralMetin, SiniflandirmaKurallari);
                };
            }

            if (lbl401 != null)
            {
                lbl401.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    lbl401.Text = FormatSelected(data?.TibbiCihazFormu?.CIHAZKULLANIMAMACI, data?.CihazKullanimAmaciMetin, KullanimAmaclari);
                };
            }

            if (lbl292 != null)
            {
                lbl292.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    string formatted = FormatSelected(data?.TibbiCihazFormu?.TEDAVIALANI, data?.TedaviAlaniMetin, TedaviAlanlari);
                    lbl292.Text = formatted;
                    AdjustTedaviAlaniLayout(formatted);
                };
            }

            if (lbl468 != null)
            {
                lbl468.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    lbl468.Text = FormatSelected(data?.TibbiCihazFormu?.CIHAZSINIFI, data?.CihazSinifiMetin, CihazSiniflari);
                };
            }

            if (lbl704 != null)
            {
                lbl704.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    lbl704.Text = FormatSelected(data?.TibbiCihazFormu?.KARSILASTIRMACIHAZ_SINIF, data?.KarsilastirmaCihazSinifMetin, CihazSiniflari);
                };
            }

            if (lbl826 != null)
            {
                lbl826.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    var val = data?.TibbiCihazFormu?.PLANLANANGONULLUSAYISI;
                    if (string.IsNullOrWhiteSpace(val))
                        val = data?.TibbiCihazFormu?.GONULLUSAYISITOPLAM ?? "-";
                    lbl826.Text = val;
                };
            }

            // 2.11 Koordinatör Adı ve Telefonunu Başvuru Üst Yazı veya modelden bağla
            if (lbl379 != null)
            {
                lbl379.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    var val = !string.IsNullOrWhiteSpace(data?.TibbiCihazFormu?.KOORDINATORAD)
                        ? data.TibbiCihazFormu.KOORDINATORAD
                        : (!string.IsNullOrWhiteSpace(data?.KoordinatorAdiSoyadi)
                            ? data.KoordinatorAdiSoyadi
                            : (data?.BASVURUFORMU?.SORUMLUARASTIRMACI ?? ""));
                    if (!string.IsNullOrWhiteSpace(val))
                    {
                        lbl379.Text = val;
                    }
                };
            }

            if (lbl389 != null)
            {
                lbl389.BeforePrint += (s, e) =>
                {
                    var data = GetCurrentFormData();
                    var val = !string.IsNullOrWhiteSpace(data?.TibbiCihazFormu?.KOORDINATORTEL)
                        ? data.TibbiCihazFormu.KOORDINATORTEL
                        : (!string.IsNullOrWhiteSpace(data?.KoordinatorTelefon)
                            ? data.KoordinatorTelefon
                            : (data?.BASVURUFORMU?.SORUMLUARASTIRMACITEL ?? ""));
                    if (!string.IsNullOrWhiteSpace(val))
                    {
                        lbl389.Text = val;
                    }
                };
            }
        }

        private void ConfigureKoordinatorSection()
        {
            // 2.11 Koordinatör/Sorumlu Araştırmacı:
            // Sadece Adı Soyadı ve Telefon numarası gösterilecek.
            // Gizlenecek alanlar: Adres, İlçe, Şehir, Ülke, Email, Uzmanlık Alanı, Görev Yeri, Görev Yeri Adresi ve çizgiler
            XRControl[] hiddenControls = {
                lbl380, lbl381, // Adresi
                lbl382, lbl383, // İlçe
                lbl384, lbl385, // Şehir
                lbl386, lbl387, // Ülke
                lbl390, lbl391, // Email
                lbl392, lbl393, // Uzmanlık Alanı
                lbl394, lbl395, // Görev Yeri
                lbl396, lbl397, // Görev Yeri Adresi
                ln374, ln375, ln376, ln377 // Kullanılmayan iç ayraç çizgileri
            };

            foreach (var ctrl in hiddenControls)
            {
                if (ctrl != null)
                {
                    ctrl.Visible = false;
                }
            }

            // Telefon alanını 2. satır olarak Adı Soyadı (ln373) altına hizala
            if (lbl388 != null)
            {
                lbl388.LocationFloat = new DevExpress.Utils.PointFloat(104.45F, 506F);
                lbl388.SizeF = new System.Drawing.SizeF(120F, 25F);
                lbl388.Visible = true;
            }
            if (lbl389 != null)
            {
                lbl389.LocationFloat = new DevExpress.Utils.PointFloat(228F, 502F);
                lbl389.SizeF = new System.Drawing.SizeF(505F, 33F);
                lbl389.Visible = true;
            }

            // Dış çerçeveyi (lbl372) Adı Soyadı ve Telefon satırlarına göre yeniden boyutlandır
            if (lbl372 != null)
            {
                lbl372.SizeF = new System.Drawing.SizeF(634.25F, 96F);
            }

            // dd10 bandının yüksekliğini ayarla
            if (dd10 != null)
            {
                dd10.HeightF = 560F;
            }
        }

        private TibbiCihazBasvuruFormu GetCurrentFormData()
        {
            var row = GetCurrentRow() as TibbiCihazBasvuruFormu;
            if (row != null) return row;

            var list = DataSource as List<TibbiCihazBasvuruFormu>;
            if (list != null && list.Count > 0) return list[0];

            var odsList = objectDataSource1?.DataSource as List<TibbiCihazBasvuruFormu>;
            if (odsList != null && odsList.Count > 0) return odsList[0];

            return null;
        }

        public static string FormatSelected(string rawValue, string resolvedMetin, Dictionary<string, string> dict)
        {
            if (string.IsNullOrWhiteSpace(rawValue) && string.IsNullOrWhiteSpace(resolvedMetin))
                return "-";

            var selectedItems = new List<string>();
            string combinedInput = ((rawValue ?? "") + " " + (resolvedMetin ?? "")).Trim();

            // Extract extra text for "Diğer" (e.g. "Diğer: xxx", "TDA012: xxx", "Diğer (xxx)")
            string otherExtra = "";
            var colonMatch = System.Text.RegularExpressions.Regex.Match(combinedInput, @"(?:TDA012|SKR\d+|CKA\d+|CSN\d+|Diğer|Diger)[^:]*:\s*([^,;\r\n]+)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (colonMatch.Success)
            {
                otherExtra = colonMatch.Groups[1].Value.Trim();
            }
            else
            {
                var parenMatch = System.Text.RegularExpressions.Regex.Match(combinedInput, @"(?:Diğer|Diger)\s*\(([^)]+)\)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (parenMatch.Success)
                {
                    otherExtra = parenMatch.Groups[1].Value.Trim();
                }
            }

            // 1. Check direct dictionary keys in rawValue (e.g. TDA001, SKR001, CKA005)
            bool foundKeys = false;
            if (dict != null && !string.IsNullOrWhiteSpace(rawValue))
            {
                foreach (var kvp in dict)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(rawValue, @"\b" + System.Text.RegularExpressions.Regex.Escape(kvp.Key) + @"\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        foundKeys = true;
                        string desc = kvp.Value;
                        if (kvp.Value.IndexOf("Diğer", StringComparison.OrdinalIgnoreCase) >= 0 && !string.IsNullOrWhiteSpace(otherExtra))
                        {
                            desc = "Diğer (" + otherExtra + ")";
                        }
                        if (!selectedItems.Contains(desc))
                            selectedItems.Add(desc);
                    }
                }
            }

            // 2. If no keys matched (or to ensure full phrase matching), match against dictionary values from longest to shortest
            if (!foundKeys && dict != null)
            {
                var sortedKvp = dict.OrderByDescending(x => x.Value.Length).ToList();
                string textToSearch = combinedInput;

                foreach (var kvp in sortedKvp)
                {
                    var val = kvp.Value;
                    bool isMatch = false;

                    if (val.IndexOf("travmatoloji", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (textToSearch.IndexOf("travmatoloji", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            textToSearch.IndexOf("travmaloji", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            textToSearch.IndexOf("Ortopedi", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            isMatch = true;
                        }
                    }
                    else if (val.IndexOf("Diğer", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (textToSearch.IndexOf("Diğer", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            textToSearch.IndexOf("Diger", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            isMatch = true;
                        }
                    }
                    else
                    {
                        if (textToSearch.IndexOf(val, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            isMatch = true;
                        }
                    }

                    if (isMatch)
                    {
                        string desc = val;
                        if (val.IndexOf("Diğer", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            desc = !string.IsNullOrWhiteSpace(otherExtra) ? "Diğer (" + otherExtra + ")" : "Diğer";
                        }
                        if (!selectedItems.Contains(desc))
                            selectedItems.Add(desc);
                    }
                }
            }

            // 3. Remove accidental partial splits:
            // If "Ortopedi, travmatoloji, rehabilitasyon" exists, remove any single "Ortopedi", "travmatoloji", "travmaloji", "rehabilitasyon"
            if (selectedItems.Any(x => x.StartsWith("Ortopedi", StringComparison.OrdinalIgnoreCase)))
            {
                selectedItems.RemoveAll(x => x.Equals("Ortopedi", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("travmatoloji", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("travmaloji", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("rehabilitasyon", StringComparison.OrdinalIgnoreCase));
            }

            // If "Diğer (...)" exists, remove bare "Diğer" or "Diğer Tedavi Alanı"
            if (selectedItems.Any(x => x.StartsWith("Diğer (", StringComparison.OrdinalIgnoreCase)))
            {
                selectedItems.RemoveAll(x => x.Equals("Diğer", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("Diğer Tedavi Alanı", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("Diğer Metodoloji", StringComparison.OrdinalIgnoreCase) ||
                                             x.Equals("Diğer Grup", StringComparison.OrdinalIgnoreCase));
            }

            if (selectedItems.Count == 0)
            {
                var cleanFallback = !string.IsNullOrWhiteSpace(resolvedMetin) ? resolvedMetin.Trim() : (rawValue ?? "").Trim();
                return !string.IsNullOrWhiteSpace(cleanFallback) ? cleanFallback : "-";
            }

            if (selectedItems.Count == 1)
                return selectedItems[0];

            return string.Join(Environment.NewLine, selectedItems.Select(x => "• " + x));
        }
    }
}
