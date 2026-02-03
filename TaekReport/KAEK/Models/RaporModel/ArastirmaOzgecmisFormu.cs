using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models.RaporModel
{
    public class ArastirmaOzgecmisFormu
    {
        public BASVURUFORMU BASVURUFORMU { get; set; }
        public ARASTIRMAEKIBI listArastirmaEkibi { get; set; }
        public List<ARASTIRMAEGITIM> listArastirmaEgitim { get; set; }
        public List<ARASTIRMAISTECRUBE> listArastirmaIsTecrube { get; set; }
        public List<ARASTIRMASERTIFIKA> listArastirmaSertifika { get; set; }
        public List<ARASTIRMAGOREVALINANKLINIK> listArastirmaGorevAlinanKlinik { get; set; }
        public KLINIKARASTIRMALARBASVURUFORMU KlinikFormu { get; set; }
    }
}
