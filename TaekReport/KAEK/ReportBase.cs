using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaekReport.KAEK.Models;

namespace TaekReport.KAEK
{
    public class ReportBase
    {
        public byte[] UstBasvuruFrm(UstBasvuruModel form)
        {
            byte[] resultReport = null;
            try
            {
                KAEK.UstBasvuru.frmUstBasvuru rpr = new KAEK.UstBasvuru.frmUstBasvuru(form);                
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
