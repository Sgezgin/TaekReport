using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaekReport.KAEK.Models.RaporModel;

namespace TaekReport.KAEK
{
    public class ReportBase
    {
        public byte[] UstBasvuruFrm(List<UstBasvuruModel> form)
        {
            byte[] resultReport = null;
            try
            {
                KAEK.IlacArastirma.rprUstBasvuruForm rpr = new KAEK.IlacArastirma.rprUstBasvuruForm(form);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = form;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }

        public byte[] ArastirmaProtokolFormu(List<ArastirmaProtokolFormu> list)
        {
            byte[] resultReport = null;
            try
            {
                IlacArastirma.rprArastirmaProtokolFormu rpr = new IlacArastirma.rprArastirmaProtokolFormu(list);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = list;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }

        public byte[] KlinikArastirmaBasvuruForm(List<KlinikArastirmaBasvuruFormu> list)
        {
            byte[] resultReport = null;
            try
            {
                IlacArastirma.rprKlinikArastirmaBasvuruForm rpr = new IlacArastirma.rprKlinikArastirmaBasvuruForm(list);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = list;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }

        public byte[] FaydaRiskDegerlendirmeForm(List<FaydaRiskDegerlendirmeFormu> list)
        {
            byte[] resultReport = null;
            try
            {
                IlacArastirma.rprFaydaRiskDegerlendirmeForm rpr = new IlacArastirma.rprFaydaRiskDegerlendirmeForm(list);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = list;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }

        public byte[] PediatrikArastirmaPlaniForm(List<PediatrikArastirmaPlaniFormu> list)
        {
            byte[] resultReport = null;
            try
            {
                IlacArastirma.rprPediatrikArastirmaPlaniForm rpr = new IlacArastirma.rprPediatrikArastirmaPlaniForm(list);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = list;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }

        public byte[] ArastirmaButceForm(List<ArastirmaButceFormModel> list)
        {
            byte[] resultReport = null;
            try
            {
                IlacArastirma.rprArastirmaButceFormu rpr = new IlacArastirma.rprArastirmaButceFormu(list);
                using (MemoryStream ms = new MemoryStream())
                {
                    rpr.DataSource = list;
                    rpr.ExportToPdf(ms);

                    resultReport = ms.ToArray();
                }
            }
            catch (Exception ex)
            {

                var data = ex.Message;
            }

            return resultReport;
        }
    }
}
