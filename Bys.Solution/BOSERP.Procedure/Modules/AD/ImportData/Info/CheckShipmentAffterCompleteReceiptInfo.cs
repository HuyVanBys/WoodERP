using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOSLib;

namespace BOSERP.Procedure.Modules.AD.ImportData
{
    public class CheckShipmentAffterCompleteReceiptInfo : BusinessObject
    {
        public CheckShipmentAffterCompleteReceiptInfo()
        {
        }
        #region Variables
       
        #endregion

        #region Public properties
       
        public int CheckShipmentAffterCompleteReceiptID { get; set; }
        //public string ICProductNo { get; set; }
        //public string ICProductName { get; set; }
        public string MMBatchProductItemProductSerial { get; set; }
        public string MMBatchProductItemSOName { get; set; }
        //public decimal TTSXTK { get; set; }
        //public decimal MMBatchProductItemProductQty { get; set; }
        //public decimal Tongchiphi { get; set; }
        //public decimal TongPhanBo { get; set; }
        public string ICShipmentNo { get; set; }
        //public string MMBatchProductNo { get; set; }
        //public string MMProductionCostCalculationNo { get; set; }
        public int ICProductForBatchID { get; set; }
        public int FK_MMBatchProductID { get; set; }
        public int FK_MMBatchProductItemID { get; set; }
        public int FK_MMOperationID { get; set; }
        public DateTime ICShipmentDate { get; set; }
        public DateTime ICReceiptDate { get; set; }
        public string ICShipmentDesc { get; set; }
        public string ICImportAndExportReasonName { get; set; }
        public int FK_ICProductID { get; set; }
        public decimal MMBatchProductProductionNormItemQuantity { get; set; }
        public decimal ICReceiptItemProductQty { get; set; }
        public int FK_ICImportAndExportReasonID { get; set; }
        public string ICShipmentTypeCombo { get; set; }
        public decimal ICShipmentItemExchangeTotalCost { get; set; }

        #endregion
    }
}
