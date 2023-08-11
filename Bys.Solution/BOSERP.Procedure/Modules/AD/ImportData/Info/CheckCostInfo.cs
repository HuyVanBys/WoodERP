using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOSLib;

namespace BOSERP.Procedure.Modules.AD.ImportData
{
    public class CheckCostInfo : BusinessObject
    {
        public CheckCostInfo()
        {
        }
        #region Variables
       
        #endregion

        #region Public properties
       
        
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public string MMBatchProductItemProductSerial { get; set; }
        public string MMBatchProductItemSOName { get; set; }
        public decimal TTSXTK { get; set; }
        public decimal MMBatchProductItemProductQty { get; set; }
        public decimal Tongchiphi { get; set; }
        public decimal TongPhanBo { get; set; }
        public string ICShipmentNo { get; set; }
        public string MMBatchProductNo { get; set; }
        public string MMProductionCostCalculationNo { get; set; }
        public int ICProductID { get; set; }
        public int FK_MMBatchProductID { get; set; }
        public int FK_MMOperationID { get; set; }
        public string MMProductionCostCalculationNoUpdate { get; set; }
        public decimal TongchiphiTranfer { get; set; }
        public decimal MMProductionCostCalculationPriceReceiptQty { get; set; }
        public decimal MMProductionCostCalculationUnitCost { get; set; }
        public decimal MMProductionCostCalculationTotalCost { get; set; }
        public bool IsTransfer { get; set; }

        #endregion
    }
}
