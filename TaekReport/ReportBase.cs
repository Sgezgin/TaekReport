using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaekReport.Models;


namespace TaekReport
{
    public class ReportBase
    {
        public byte[] OlurFormu(OLURFORMU form,string sorumluAdiSoyadi="",string tel="",string gorevyeri = "")
        {
            byte[] resultReport = null;

            try
            {
                OlurFormu.rprOlurFormu rpr = new OlurFormu.rprOlurFormu(form,sorumluAdiSoyadi,tel, gorevyeri);
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



        public byte[] OnayOnYaziFrm(string sorumlu, string yardimci,string arastirma,string destekleyici)
        {
            byte[] resultReport = null;

            try
            {
                OnYaziFormu.frmOnayOnYazi rpr = new OnYaziFormu.frmOnayOnYazi(sorumlu,yardimci,arastirma, destekleyici);
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
                        item.AdiSoyadi,
                        item.Uzamanlik,
                        item.Kurum,
                        item.Cinsiyet,
                        item.Katilim,
                        item.Iliski,
                        item.Mazeret
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
