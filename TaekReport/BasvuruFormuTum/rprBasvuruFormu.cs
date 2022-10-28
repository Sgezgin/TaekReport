﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TaekReport.BasvuruFormuTum
{
    public partial class rprBasvuruFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprBasvuruFormu(string arastirma,string sorumlu,string basvuruno)
        {
            InitializeComponent();
            string arastmaedit = " isimli araştırma başvurusu dosyası kapsamında, aşağıda özellikleri belirtilmiş olan belgelerin tarafınızdan değerlendirilmesi/ onaylanması için gereğini bilgilerinize arz ederim.";
            lblArastirmaADi.Text = arastirma + arastmaedit;
            lblBasvuruNo.Text = "Başvuru No : " + basvuruno;
            lblSorumlu.Text = sorumlu;
            lblSorumlu2.Text = sorumlu;

           // lblArastirmaAdi2.Text = arastirma;
        }

    }
}
