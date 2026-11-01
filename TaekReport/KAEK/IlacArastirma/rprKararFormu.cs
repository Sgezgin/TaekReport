using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.Utils;
using System.Collections.Generic;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK.IlacArastirma
{
    public partial class rprKararFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprKararFormu()
        {
            InitializeComponent();
            SetupKararBilgileri();
        }

        public rprKararFormu(List<KararFormu> o)
        {
            InitializeComponent();
            SetupKararBilgileri();
            objectDataSource1.DataSource = o;
        }

        private void SetupKararBilgileri()
        {
            try
            {
                int idx = xrTable11.Rows.IndexOf(xrTableRow53);
                if (idx >= 0)
                {
                    xrTable11.Rows.Remove(xrTableRow53);
                    if (xrTable11.Rows.Contains(xrTableRow54)) xrTable11.Rows.Remove(xrTableRow54);
                    if (xrTable11.Rows.Contains(xrTableRow55)) xrTable11.Rows.Remove(xrTableRow55);

                    double totalWeight = 2.8258066741594217D;
                    double chkWeight = 0.1276274D;
                    double textWeight = totalWeight - chkWeight;
                    Color borderColor = Color.Red;
                    float borderWidth = 2F;

                    List<XRTableRow> newRows = new List<XRTableRow>();

                    // 1. Header: İlk Uygunluk Başvurusu:
                    XRTableRow rHeader = new XRTableRow { Weight = 1D };
                    XRTableCell cHeader = new XRTableCell
                    {
                        Weight = totalWeight,
                        Text = "İlk Uygunluk Başvurusu:",
                        Font = new Font("Arial", 9.75F, FontStyle.Bold),
                        ForeColor = Color.Black,
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(6, 6, 6, 2, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right
                    };
                    rHeader.Cells.Add(cHeader);
                    newRows.Add(rHeader);

                    // 2. Uygun (Checkbox + Title)
                    XRTableRow rUygun = new XRTableRow { Weight = 0.9D };
                    XRTableCell cUygunChk = CreateCheckCell(chkWeight, borderColor, borderWidth, BorderSide.Left, "[KARARRAPORUBILGI].[UYGUN]");
                    XRTableCell cUygunTitle = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Uygun",
                        Font = new Font("Arial", 9.5F, FontStyle.Bold),
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 2, 2, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right
                    };
                    rUygun.Cells.AddRange(new XRTableCell[] { cUygunChk, cUygunTitle });
                    newRows.Add(rUygun);

                    // 3. Uygun Description
                    XRTableRow rUygunDesc = new XRTableRow { Weight = 1.6D };
                    XRTableCell cUygunDescEmpty = CreateEmptyCell(chkWeight, borderColor, borderWidth, BorderSide.Left);
                    XRTableCell cUygunDescText = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Yukarıda bilgileri verilen başvuru dosyası ile ilgili belgeler araştırmanın/çalışmanın gerekçe, amaç, yaklaşım ve yöntemleri dikkate alınarak incelenmiş ve uygun bulunmuş olup araştırmanın/çalışmanın başvuru dosyasında belirtilen merkezlerde gerçekleştirilmesinde etik ve bilimsel sakınca bulunmadığına toplantıya katılan etik kurul üye tam sayısının salt çoğunluğu ile karar verilmiştir.",
                        Font = new Font("Arial", 9F, FontStyle.Regular),
                        Multiline = true,
                        WordWrap = true,
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 2, 5, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right
                    };
                    rUygunDesc.Cells.AddRange(new XRTableCell[] { cUygunDescEmpty, cUygunDescText });
                    newRows.Add(rUygunDesc);

                    // Maddeler A - I
                    string[] props = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
                    string[] texts = new string[]
                    {
                        "Uygun bulunan araştırmanın 27 Mayıs 2023 tarih ve 32203 sayılı Resmi Gazete’de yayımlanarak yürürlüğe giren Beşeri Tıbbi Ürünlerin Klinik Araştırmaları Hakkında Yönetmelik kapsamında yer alması nedeni ile araştırmanın başlatılabilmesi için Türkiye İlaç ve Tıbbi Cihaz Kurumu’ndan izin alınması gerekmektedir.",
                        "Uygun bulunan araştırmanın 02.06.2021 tarihli ve 31499 sayılı Resmi Gazete’de yayımlanan Tıbbi Cihaz Yönetmeliği kapsamında CE işareti taşımayan tıbbi cihaz ile yapılan Tıbbi Cihaz Klinik Araştırması olması nedeniyle araştırmanın başlatılabilmesi için etik kurul onayı alındıktan sonra Türkiye İlaç ve Tıbbi Cihaz Kurumu’ndan izin alınması.",
                        "Uygun bulunan araştırmanın/çalışmanın 02.06.2021 tarihli ve 31499 sayılı Resmi Gazete’de yayımlanan Tıbbi Cihaz Yönetmeliği kapsamında CE işareti taşıyan ve teknik dokümantasyonunda belirtilen kullanım amacına uygun olarak kullanılan tıbbi cihazla yapılan Tıbbi Cihaz Klinik Araştırması ve Tıbbi Cihazlar ile Yürütülen Piyasaya Arz Sonrası Çalışma olması nedeni ile araştırmanın/çalışmanın başlatılabilmesi için etik kurul onayı alındıktan sonra Türkiye İlaç ve Tıbbi Cihaz Kurumu’na bildirim yapılması gerekmektedir.",
                        "Uygun bulunan çalışmanın 02.06.2021 tarihli ve 31499 sayılı Resmi Gazete’de yayımlanan İn Vitro Tanı Amaçlı Tıbbi Cihaz Yönetmeliği kapsamındaki İn Vitro Tanı Amaçlı Tıbbi Cihazlar İle Yürütülen; amacı yalnızca performans değerlendirmek olan ve cerrahi prosedürler yoluyla numune alımının yapıldığı Performans Değerlendirme Çalışması, yürütülmesinde ilave girişimsel prosedürler veya gönüllüler için başka riskler bulunan Performans Değerlendirme Çalışması, test sonuçlarının hasta yönetimi kararlarını etkileyebildiği veya tedaviye yön vermek üzere kullanılabildiği Performans Değerlendirme Çalışması olması nedeni ile çalışmanın başlatılabilmesi için etik kurul onayı alındıktan sonra Türkiye İlaç ve Tıbbi Cihaz Kurumu’ndan izin alınması gerekmektedir.",
                        "Uygun bulunan çalışmanın 02.06.2021 tarihli ve 31499 sayılı Resmi Gazete’de yayımlanan İn Vitro Tanı Amaçlı Tıbbi Cihaz Yönetmeliği kapsamındaki; destek tanı cihazına ilişkin sadece artık numune kullanılarak yapılan Performans Değerlendirme Çalışması, teknik dokümantasyonunda belirtilen kullanım amacına uygun olarak kullanılan ve gönüllülerin ilave olarak girişimsel veya külfetli prosedürlere tabi tutulduğu İn-Vitro Tanı Amaçlı Tıbbi Cihazlar İle Yürütülen Piyasaya Arz Sonrası Çalışması olması nedeni ile çalışmanın başlatılabilmesi için etik kurul onayı alındıktan sonra Türkiye İlaç ve Tıbbi Cihaz Kurumu’na bildirim yapılması gerekmektedir.",
                        "Uygun bulunan 02.06.2021 tarihli ve 31499 sayılı Resmi Gazete’de yayımlanan İn Vitro Tanı Amaçlı Tıbbi Cihaz Yönetmeliği kapsamındaki İn Vitro Tanı Amaçlı Tıbbi Cihazlar ile yürütülen yukarıda yer alan çalışmalar dışında kalan Performans Değerlendirme Çalışmaları etik kurul kararı ile başlatılabilir, Türkiye İlaç ve Tıbbi Cihaz Kurumu izni veya Türkiye İlaç ve Tıbbi Cihaz Kurumu’na bildirim yapılması gerekmemektedir.",
                        "Uygun bulunan çalışmanın Sağlık Hizmetleri Genel Müdürlüğünün 5/4/2018 tarihinde yayımladığı 2018/10 sayılı Genelge kapsamında yer alan kök hücreler ile yapılan klinik araştırma olması nedeni ile araştırmanın başlatılabilmesi için Sağlık Hizmetleri Genel Müdürlüğü’nden izin alınması gerekmektedir.",
                        "Uygun bulunan beşeri tıbbi ürünlerin gözlemsel çalışması etik kurul kararı ile başlatılabilir, Bakanlık izni gerektirmemektedir.",
                        "Uygun bulunan çalışmanın 3359 sayılı Sağlık Hizmetleri Temel Kanunu Ek 10. Madde kapsamında yer alan geleneksel ve tamamlayıcı tıp uygulamalarına ilişkin araştırmalar dışındaki tedavi yöntemlerine ilişkin çalışma, özel tıbbi amaçlı gıdalarda kullanım amacına ilişkin çalışma, gıda ve takviye edici gıdalarda sağlık beyanı kullanımına ilişkin çalışma, düşük riskli bilimsel çalışma olması nedeni ile çalışmanın başlatılabilmesi için Türkiye İlaç ve Tıbbi Cihaz Kurumu’na başvuru yapılması gerekmektedir."
                    };

                    for (int i = 0; i < props.Length; i++)
                    {
                        XRTableRow rMadde = new XRTableRow { Weight = 1.3D };
                        XRTableCell cMaddeChk = CreateCheckCell(chkWeight, borderColor, borderWidth, BorderSide.Left, "[KARARRAPORUBILGI].[" + props[i] + "]");
                        XRTableCell cMaddeText = new XRTableCell
                        {
                            Weight = textWeight,
                            Text = texts[i],
                            Font = new Font("Arial", 8.5F, FontStyle.Regular),
                            Multiline = true,
                            WordWrap = true,
                            TextAlignment = TextAlignment.TopLeft,
                            Padding = new PaddingInfo(4, 6, 2, 4, 100F),
                            BorderColor = borderColor,
                            BorderWidth = borderWidth,
                            Borders = BorderSide.Right
                        };
                        rMadde.Cells.AddRange(new XRTableCell[] { cMaddeChk, cMaddeText });
                        newRows.Add(rMadde);
                    }

                    // 13. Uygun Değil (Checkbox + Title)
                    XRTableRow rUygunDegil = new XRTableRow { Weight = 0.9D };
                    XRTableCell cUygunDegilChk = CreateCheckCell(chkWeight, borderColor, borderWidth, BorderSide.Left, "[KARARRAPORUBILGI].[UYGUNDEGIL]");
                    XRTableCell cUygunDegilTitle = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Uygun Değil",
                        Font = new Font("Arial", 9.5F, FontStyle.Bold),
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 5, 2, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right
                    };
                    rUygunDegil.Cells.AddRange(new XRTableCell[] { cUygunDegilChk, cUygunDegilTitle });
                    newRows.Add(rUygunDegil);

                    // 14. Uygun Değil Description
                    XRTableRow rUygunDegilDesc = new XRTableRow { Weight = 1.2D };
                    XRTableCell cUygunDegilDescEmpty = CreateEmptyCell(chkWeight, borderColor, borderWidth, BorderSide.Left);
                    XRTableCell cUygunDegilDescText = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Yukarıda bilgileri verilen başvuru dosyası ile ilgili belgeler araştırmanın/çalışmanın gerekçe, amaç, yaklaşım ve yöntemleri dikkate alınarak incelenmiş ve araştırmanın/çalışmanın yürütülmesi uygun bulunmamıştır.",
                        Font = new Font("Arial", 9F, FontStyle.Regular),
                        Multiline = true,
                        WordWrap = true,
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 2, 4, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right
                    };
                    rUygunDegilDesc.Cells.AddRange(new XRTableCell[] { cUygunDegilDescEmpty, cUygunDegilDescText });
                    newRows.Add(rUygunDegilDesc);

                    // 15. Gerekçe / Açıklama: Title
                    XRTableRow rGerekceTitle = new XRTableRow { Weight = 0.8D };
                    XRTableCell cGerekceTitle = new XRTableCell
                    {
                        Weight = totalWeight,
                        Text = "Gerekçe / Açıklama:",
                        Font = new Font("Arial", 9F, FontStyle.Bold),
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(40, 6, 4, 2, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Left | BorderSide.Right
                    };
                    rGerekceTitle.Cells.Add(cGerekceTitle);
                    newRows.Add(rGerekceTitle);

                    // 16. Gerekçe / Açıklama Value
                    XRTableRow rGerekceVal = new XRTableRow { Weight = 1.2D };
                    XRTableCell cGerekceVal = new XRTableCell
                    {
                        Weight = totalWeight,
                        Font = new Font("Arial", 9F, FontStyle.Regular),
                        Multiline = true,
                        WordWrap = true,
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(40, 6, 2, 5, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Left | BorderSide.Right
                    };
                    cGerekceVal.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[KARARRAPORUBILGI].[ILKUYGUNLUKACIKLAMA]"));
                    rGerekceVal.Cells.Add(cGerekceVal);
                    newRows.Add(rGerekceVal);

                    // 17. Revizyon (Checkbox + Title)
                    XRTableRow rRevizyon = new XRTableRow { Weight = 0.9D };
                    XRTableCell cRevizyonChk = CreateCheckCell(chkWeight, borderColor, borderWidth, BorderSide.Left, null);
                    XRTableCell cRevizyonTitle = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Revizyon",
                        Font = new Font("Arial", 9.5F, FontStyle.Bold),
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 5, 2, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right
                    };
                    rRevizyon.Cells.AddRange(new XRTableCell[] { cRevizyonChk, cRevizyonTitle });
                    newRows.Add(rRevizyon);

                    // 18. Revizyon Description (Closes the box)
                    XRTableRow rRevizyonDesc = new XRTableRow { Weight = 1.5D };
                    XRTableCell cRevizyonDescEmpty = CreateEmptyCell(chkWeight, borderColor, borderWidth, BorderSide.Left | BorderSide.Bottom);
                    XRTableCell cRevizyonDescText = new XRTableCell
                    {
                        Weight = textWeight,
                        Text = "Yukarıda bilgileri verilen başvuru dosyası ile ilgili belgeler araştırmanın/çalışmanın gerekçe, amaç, yaklaşım ve yöntemleri dikkate alınarak incelenmiş olup aşağıda belirtilen eksiklikler tespit edilmiştir;\n\nTalep edilen revizyonları belirtiniz.",
                        Font = new Font("Arial", 9F, FontStyle.Regular),
                        Multiline = true,
                        WordWrap = true,
                        TextAlignment = TextAlignment.TopLeft,
                        Padding = new PaddingInfo(4, 6, 2, 8, 100F),
                        BorderColor = borderColor,
                        BorderWidth = borderWidth,
                        Borders = BorderSide.Right | BorderSide.Bottom
                    };
                    rRevizyonDesc.Cells.AddRange(new XRTableCell[] { cRevizyonDescEmpty, cRevizyonDescText });
                    newRows.Add(rRevizyonDesc);

                    // Insert all rows into xrTable11
                    for (int i = 0; i < newRows.Count; i++)
                    {
                        xrTable11.Rows.Insert(idx + i, newRows[i]);
                    }

                    // Move xrTable12 to SubBand to prevent any overlap
                    if (Detail5.Controls.Contains(xrTable12))
                    {
                        SubBand subBand = new SubBand
                        {
                            Name = "SubBandEtikKurulUyelerHeader",
                            HeightF = xrTable12.HeightF + 20F
                        };
                        Detail5.Controls.Remove(xrTable12);
                        xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 10F);
                        subBand.Controls.Add(xrTable12);
                        Detail5.SubBands.Add(subBand);
                        Detail5.HeightF = xrTable11.HeightF;
                    }
                }
            }
            catch { }
        }

        private XRTableCell CreateCheckCell(double weight, Color borderColor, float borderWidth, BorderSide borders, string bindingField)
        {
            XRTableCell cell = new XRTableCell
            {
                Weight = weight,
                BorderColor = borderColor,
                BorderWidth = borderWidth,
                Borders = borders,
                TextAlignment = TextAlignment.TopCenter,
                Padding = new PaddingInfo(0, 0, 0, 0, 100F)
            };
            XRCheckBox chk = new XRCheckBox
            {
                LocationFloat = new DevExpress.Utils.PointFloat(7F, 2F),
                SizeF = new System.Drawing.SizeF(20F, 20F),
                Text = "",
                GlyphOptions = { Alignment = HorzAlignment.Center, Style = GlyphStyle.StandardBox2 },
                Borders = BorderSide.None
            };
            if (!string.IsNullOrEmpty(bindingField))
            {
                chk.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "CheckBoxState", bindingField));
            }
            cell.Controls.Add(chk);
            return cell;
        }

        private XRTableCell CreateEmptyCell(double weight, Color borderColor, float borderWidth, BorderSide borders)
        {
            return new XRTableCell
            {
                Weight = weight,
                BorderColor = borderColor,
                BorderWidth = borderWidth,
                Borders = borders
            };
        }
    }
}
