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
                KAEK.UstBasvuru.frmUstBasvuru rpr = new KAEK.UstBasvuru.frmUstBasvuru(form);
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

    }
}
