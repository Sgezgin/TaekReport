﻿using System;
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
                OlurFormu.rprOlurFormu2 rpr = new OlurFormu.rprOlurFormu2(form);
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


        public byte[] ButceFormu(OLURFORMU form)
        {
            byte[] resultReport = null;

            try
            {
                ButceFormu.rprButceFormu rpr = new ButceFormu.rprButceFormu();
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
