using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaekReport.BasvuruFormuTum;
using TaekReport.Models;


namespace TaekReport
{
    public class ReportBase
    {
        public byte[] OlurFormu(OLURFORMU form, string sorumluAdiSoyadi = "", string tel = "", string gorevyeri = "")
        {
            byte[] resultReport = null;

            try
            {
                OlurFormu.rprOlurFormu rpr = new OlurFormu.rprOlurFormu(form, sorumluAdiSoyadi, tel, gorevyeri);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }


        public byte[] ButceFormu(BUTCEFORMU form)
        {
            //sdfsd
            byte[] resultReport = null;

            try
            {
                ArastirmaButceFormu.rprArastirmaButce1 rpr = new ArastirmaButceFormu.rprArastirmaButce1(form);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }


        public byte[] OzgecmisFormu(OzgecmisModel form)
        {
            byte[] resultReport = null;

            try
            {
                List<OzgecmisModel> ozgecmisList = new List<OzgecmisModel>();
                Ozgecmis.rprOzgecmis rpr = new Ozgecmis.rprOzgecmis();
                ozgecmisList.Add(form);
                rpr.DataSource = ozgecmisList;
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }

        public byte[] OnayOnYaziFrm(string sorumlu, string yardimci, string arastirma, string destekleyici, string format = "pdf")
        {
            byte[] resultReport = null;

            try
            {
                OnYaziFormu.frmOnayOnYazi rpr = new OnYaziFormu.frmOnayOnYazi(sorumlu, yardimci, arastirma, destekleyici);
                using (MemoryStream ms = new MemoryStream())
                {
                    if (format == "docx")
                        rpr.ExportToDocx(ms);
                    else
                        rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }
        public byte[] OnayFrm(OnayFormuModel form)
        {
            byte[] resultReport = null;

            try
            {
                OnayFormu.rprOnayFormu rpr = new OnayFormu.rprOnayFormu(form);

                OnayFormu.dsOnayFormu.dtOnayFormuDataTable dt = new OnayFormu.dsOnayFormu.dtOnayFormuDataTable();

                foreach (EtikKurulUyeler item in form.EtikKurulUyeleri)
                {
                    dt.AdddtOnayFormuRow(
                        item.AdiSoyadi + Environment.NewLine + item.UyeUnvan,
                        item.Uzamanlik,
                        item.Kurum,
                        item.Cinsiyet,
                        item.Katilim,
                        item.Iliski,
                        item.Mazeret,
                        item.UyeUnvan,
                        item.SiraNo,
                          item.TcKimlikNo = item.TcKimlikNo
                        );
                }
                rpr.DataSource = dt;

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }


        public byte[] DegerlendirmeFrmDoc(Degerlendirme form)
        {
            byte[] resultReport = null;

            try
            {
                DegerlendirmeFormu.rprDegerlendirmeFormu rpr = new DegerlendirmeFormu.rprDegerlendirmeFormu(form);
                DegerlendirmeFormu.dsDegerlendirmeFormu ds = new DegerlendirmeFormu.dsDegerlendirmeFormu();
                DegerlendirmeFormu.dsDegerlendirmeFormu.dtDegerlendirmeFormuDataTable dt = new DegerlendirmeFormu.dsDegerlendirmeFormu.dtDegerlendirmeFormuDataTable();

                foreach (DegerlendirmeDetay item in form.DegerlendirmeDetay)
                {
                    //ds.dtDegerlendirmeFormu.AdddtDegerlendirmeFormuRow(
                    //    item.Hakem,
                    //    item.Tarih,
                    //    item.Kod,
                    //    item.Aciklama
                    //    );

                    dt.AdddtDegerlendirmeFormuRow(
                        item.Hakem,
                        item.Tarih,
                        item.Kod,
                        item.Aciklama
                        );
                }
                rpr.DataSource = dt;
                using (MemoryStream ms = new MemoryStream())
                {
                    //rpr.ExportToPdf(ms);
                    rpr.ExportToDocx(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }


        public byte[] DegerlendirmeFrm(Degerlendirme form)
        {
            byte[] resultReport = null;

            try
            {
                DegerlendirmeFormu.rprDegerlendirmeFormu rpr = new DegerlendirmeFormu.rprDegerlendirmeFormu(form);
                DegerlendirmeFormu.dsDegerlendirmeFormu ds = new DegerlendirmeFormu.dsDegerlendirmeFormu();
                DegerlendirmeFormu.dsDegerlendirmeFormu.dtDegerlendirmeFormuDataTable dt = new DegerlendirmeFormu.dsDegerlendirmeFormu.dtDegerlendirmeFormuDataTable();

                foreach (DegerlendirmeDetay item in form.DegerlendirmeDetay)
                {
                    //ds.dtDegerlendirmeFormu.AdddtDegerlendirmeFormuRow(
                    //    item.Hakem,
                    //    item.Tarih,
                    //    item.Kod,
                    //    item.Aciklama
                    //    );

                    dt.AdddtDegerlendirmeFormuRow(
                        item.Hakem,
                        item.Tarih,
                        item.Kod,
                        item.Aciklama
                        );
                }
                rpr.DataSource = dt;
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }
        public byte[] YetkisizlikFrm(YetkisizlikFormModel form)
        {
            byte[] resultReport = null;

            try
            {
                YetkisizlikFormu.rprYetkisizlik rpr = new YetkisizlikFormu.rprYetkisizlik(form);

                YetkisizlikFormu.dsYetkisizlik ds = new YetkisizlikFormu.dsYetkisizlik();
                YetkisizlikFormu.dsYetkisizlik.dtYetkisizlikDataTable dt = new YetkisizlikFormu.dsYetkisizlik.dtYetkisizlikDataTable();

                foreach (string item in form.Kararlar)
                {
                    ds.dtYetkisizlik.AdddtYetkisizlikRow(
                            item.ToString()
                   );
                }
                rpr.DataSource = ds;

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }
        public byte[] YenidenBavuruFrm(YetkisizlikFormModel form)
        {
            byte[] resultReport = null;

            try
            {
                YenidenBasvuruFormu.rprYenidenBasvuru rpr = new YenidenBasvuruFormu.rprYenidenBasvuru(form);

                YenidenBasvuruFormu.dsYenidenBasvuru ds = new YenidenBasvuruFormu.dsYenidenBasvuru();
                YenidenBasvuruFormu.dsYenidenBasvuru.dtYenidenBasvuruDataTable dt = new YenidenBasvuruFormu.dsYenidenBasvuru.dtYenidenBasvuruDataTable();

                foreach (string item in form.Kararlar)
                {
                    ds.dtYenidenBasvuru.AdddtYenidenBasvuruRow(
                            item.ToString()
                   );
                }
                rpr.DataSource = ds;

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }
        public byte[] DuzeltmeFrm(YetkisizlikFormModel form)
        {
            byte[] resultReport = null;

            try
            {
                DuzeltmeFormu.rprDuzeltmeFormu rpr = new DuzeltmeFormu.rprDuzeltmeFormu(form);

                DuzeltmeFormu.dsDuzeltmeFormu ds = new DuzeltmeFormu.dsDuzeltmeFormu();
                DuzeltmeFormu.dsDuzeltmeFormu.dtDuzeltmeFormuDataTable dt = new DuzeltmeFormu.dsDuzeltmeFormu.dtDuzeltmeFormuDataTable();

                foreach (string item in form.Kararlar)
                {
                    ds.dtDuzeltmeFormu.AdddtDuzeltmeFormuRow(
                            item.ToString()
                   );
                }
                rpr.DataSource = ds;

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }
        public byte[] BasvuruFrm(BasvuruFormModel form)
        {
            byte[] resultReport = null;

            try
            {

                BasvuruFormu.rprBasvuruFormu rpr = new BasvuruFormu.rprBasvuruFormu(form.ArastirmaAdi, form.SorumluAdiSoyadi, form.BavuruNo, form.IletmeTarih, form.DosyaNo);

                BasvuruFormu.dsBasvuruFormu ds = new BasvuruFormu.dsBasvuruFormu();
                BasvuruFormu.dsBasvuruFormu.dtBasvuruFormDataTable dt = new BasvuruFormu.dsBasvuruFormu.dtBasvuruFormDataTable();



                foreach (var item in form.BasvuruFormEkipList)
                {
                    // ds.dtBasvuruForm.AdddtBasvuruFormRow(
                    //   item.Unvan,
                    //   item.Adi,
                    //   item.Soyadi,
                    //   item.Sorumluluk,
                    //   item.Imza
                    //);

                    dt.Rows.Add(
                         item.Unvan,
                       item.Adi,
                       item.Soyadi,
                       item.Sorumluluk,
                       item.Imza
                        );

                }
                rpr.DataSource = dt;

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }

        public byte[] BasvuruFrmTum(BasvuruFormModel form)
        {
            byte[] resultReport = null;

            try
            {

                BasvuruFormuTum.rprBasvuruFormu rpr = new BasvuruFormuTum.rprBasvuruFormu(form.ArastirmaAdi, form.SorumluAdiSoyadi, form.BavuruNo, form);


                List<BasvuruFormObj> reportData = new List<BasvuruFormObj>();
                BasvuruFormObj basvuruFormObj = new BasvuruFormObj();


                List<ArastirmaEkipList> aratirmaEkipList = new List<ArastirmaEkipList>();

                foreach (var item in form.ArastirmaEkipList)
                {
                    string arastirmaciTipi = "Yardımcı Araştırmacı ";
                    if (item.Sorumlu)
                        arastirmaciTipi = "Sorumlu Araştırmacı";


                    aratirmaEkipList.Add(new ArastirmaEkipList()
                    {

                        AdiSoyadi = item.AdiSoyadi,
                        Eposta = item.Eposta,
                        IsAdresi = item.IsAdresi,
                        ArastirmaciTuru = arastirmaciTipi,
                        TelefonNumarasi = item.TelefonNumarasi,
                        Unvani = item.Unvani,
                        UzmanlikAlani = item.UzmanlikAlani
                    });

                }


                basvuruFormObj.SorumluBilgi = form.SorumluBilgi;
                basvuruFormObj.CokMerkezliArastirmaciList = form.CokMerkezliArastirmaciList;
                basvuruFormObj.OzgecmisList = form.OzgecmisModelList;
                basvuruFormObj.OlurFormList = form.OlurFormList;
                basvuruFormObj.ArastirmaEkipList = aratirmaEkipList;
                basvuruFormObj.BasvuruFormEkipList = form.BasvuruFormEkipList;
                reportData.Add(basvuruFormObj);
                rpr.DataSource = reportData;


                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }



        public byte[] DuzeltmeBasvuruFrm(DuzeltmeBasvuruFormModel form)
        {
            byte[] resultReport = null;
            try
            {
                DuzeltmeBasvuruFormu.rprDuzeltmeBasvuruFormu rpr = new DuzeltmeBasvuruFormu.rprDuzeltmeBasvuruFormu(form);
                rpr.DataSource = form.DegisikliList;
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }



        public byte[] BasvuruBilgilendirmeFrm(BilgilendirmeFormModel form)
        {
            byte[] resultReport = null;
            try
            {
                BilgilendirmeFormu.rprBilgilendirmeFormu rpr = new BilgilendirmeFormu.rprBilgilendirmeFormu(form);
                rpr.DataSource = form.BilgilendirmeList;
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }


        public byte[] ToplantiGundemiFrm(ToplantiGundemiModel form)
        {
            byte[] resultReport = null;
            try
            {
                ToplantiGundemi.rprToplantiGundemi rpr = new ToplantiGundemi.rprToplantiGundemi(form);
                rpr.DataSource = form.GundemDetayList;
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }

        public byte[] ToplantiGundemiFrm2(ToplantiGundemiModel form, bool landscape)
        {
            byte[] resultReport = null;
            try
            {
                List<ToplantiGundemi2> rprModel = new List<ToplantiGundemi2>();
                XtraReport rpr = new XtraReport();
                if (landscape)
                    rpr = new ToplantiGundemi.rprToplantiGundemiYatay(form.ToplantiTarihi.ToShortDateString());
                else
                    rpr = new ToplantiGundemi.rprToplantiGundemi2(form.ToplantiTarihi.ToShortDateString());

                foreach (var item in form.GundemDetayList)
                {
                    int sirano = 0;

                    if (item.DosyaNo.Contains('/'))
                    {
                        string[] dosyaNoSplit = item.DosyaNo.Split('/');
                        if (dosyaNoSplit[1] != null)
                            sirano = Convert.ToInt32(dosyaNoSplit[1]);
                    }
                    else
                        sirano = 99;

                    string destekleyici = (!string.IsNullOrEmpty(item.Destekleyici) ? item.Destekleyici : "Yoktur");
                    destekleyici += " / " + item.ArastirmaTipi;

                    string yardimci = "", sorumlu = "";

                    foreach (var itemSorumlu in item.SorumluArastirmaci)
                    {
                        sorumlu += itemSorumlu.ArastirmaciAdi + Environment.NewLine + itemSorumlu.Bolumu;
                    }

                    foreach (var itemYardimci in item.YardimciArastirmaci)
                    {
                        yardimci += itemYardimci.ArastirmaciAdi + " ";
                    }

                    rprModel.Add(new ToplantiGundemi2()
                    {
                        ArastirmaAdi = item.ArastirmaAdi,
                        DestekleyiciArastirmaTipi = destekleyici,
                        Sorumlu = sorumlu,
                        Yardimci = yardimci,
                        DosyaNo = item.DosyaNo,
                        SiraNo = sirano,
                        BasvuruTuru = item.BaşvuruTuru,
                        BaşvuruTuruOrder = item.BaşvuruTuruOrder

                    });
                }

                rpr.DataSource = rprModel.OrderBy(x => x.SiraNo);

                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }

        public byte[] TupBarkod(TUPBARKOD form)
        {
            byte[] resultReport = null;

            try
            {
                Lbs.TupBarkod.rprTupBarkod rpr = new Lbs.TupBarkod.rprTupBarkod(form);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.ExportToPdf(ms);
                    resultReport = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultReport;
        }

        //test



        //public byte[] Butce2Formu(BUTCEFORMU form)
        //{
        //    byte[] resultReport = null;

        //    try
        //    {
        //        ArastirmaButceFormu.rprArastirmaButce2 rpr = new ArastirmaButceFormu.rprArastirmaButce2(form);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            rpr.ExportToPdf(ms);
        //            resultReport = ms.ToArray();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return resultReport;
        //}

    }
}
