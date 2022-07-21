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

        public byte[] DuzeltmeFrm(Duzeltme form)
        {
            byte[] resultReport = null;

            try
            {
                DuzeltmeFormu.rprDuzeltmeFormu rpr = new DuzeltmeFormu.rprDuzeltmeFormu(form);
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

        public byte[] OnayOnYaziFrm(string arastirma,string tur)
        {
            byte[] resultReport = null;

            try
            {
                OnYaziFormu.frmOnayOnYazi rpr = new OnYaziFormu.frmOnayOnYazi(arastirma, tur);
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
