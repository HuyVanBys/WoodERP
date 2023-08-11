using BOSLib;
using System;
namespace BOSERP
{
    public class ARCreditNoteImportsInfo : BusinessObject
    {
        public string ARCreditNoteImportNo { get; set; }

        public string ARCreditNoteImportDesc { get; set; }

        public decimal ARCreditNoteImportTotalAmount { get; set; }

        public decimal ARCreditNoteImportConditionAmount { get; set; }

        public DateTime ARCreditNoteImportDate { get; set; }

        public DateTime ARCreditNoteImportExpiryDate { get; set; }

        public string ARCreditNoteImportType { get; set; }

        public bool IsCreated { get; set; }
    }
}
