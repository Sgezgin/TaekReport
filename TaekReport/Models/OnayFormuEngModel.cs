using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.Models
{
    public class OnayFormuEngModel
    {
        // "On November 30th 2023, ..." cümlesindeki toplantı tarihi
        public string ReviewDate { get; set; }
        public string ProtocolTitle { get; set; }
        public string ProtocolType { get; set; }
        // Protocol Number/Code: başvuru dosya numarası
        public string ProtocolNumber { get; set; }
        // Investigator Name/Title: "Assoc. Prof. Dr. Ad SOYAD"
        public string Investigator { get; set; }
        public string Institution { get; set; }
        // The study was: Approved / Conditionally approved / Deferred pending further information / Rejected
        public string Decision { get; set; } = "Approved";
        public string Chairman { get; set; }
        public string ChairmanTitle { get; set; } = "Chairman";
        // E-imza metninin yerleştirileceği yeri bulmak için imza uygulaması bu metni belgede arar
        public string ChairmanTckn { get; set; }
        // Approval date of Ethics Committee (gg/aa/yyyy)
        public string ApprovalDate { get; set; }
    }
}
