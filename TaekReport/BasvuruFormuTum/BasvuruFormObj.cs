using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaekReport.Models;

namespace TaekReport.BasvuruFormuTum
{
    public class BasvuruFormObj
    {
        public List<OzgecmisModel> OzgecmisList { get; set; }
        public List<BasvuruFormEkipList> BasvuruFormEkipList { get; set; }
        public List<ArastirmaEkipList> ArastirmaEkipList { get; set; }
        public List<OLURFORMU> OlurFormList { get; set; }
        public List<CokMerkezliArastirmaciList> CokMerkezliArastirmaciList { get; set; }
        public SorumluBilgi SorumluBilgi { get; set; }



    }
    
 
}
