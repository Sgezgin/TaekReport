﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class ToplantiGundemi2
    {
        public int SiraNo { get; set; }
        public string DosyaNo { get; set; }
        public string ArastirmaAdi { get; set; }
        public string Sorumlu { get; set; }
        public string Yardimci { get; set; }
        public string DestekleyiciArastirmaTipi { get; set; }
        public string BasvuruTuru { get; set; }
        public int BaşvuruTuruOrder { get; set; }
    }
}
