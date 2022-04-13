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
        public byte[] OlurFormu(OLURFORMU form)
        {
            byte[] resultReport = null;

            try
            {
                OlurFormu.rprOlurFormu rpr = new OlurFormu.rprOlurFormu(form);
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
    }
}
