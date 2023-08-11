using BOSLib;
using BOSLib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Procedure.Modules.AD.ImportData
{
    public class CheckShipmentAffterCompleteReceiptControler : BaseBusinessController
    {
        public CheckShipmentAffterCompleteReceiptControler()
        {
            dal = new DALBaseProvider("CheckShipmentAffterCompleteReceipt", typeof(CheckShipmentAffterCompleteReceiptInfo));
        }
        public List<CheckShipmentAffterCompleteReceiptInfo> GetDataErrorAndPrevProductionCost(string storeName, int timeOutValue, params object[] paramValues)
        {

            DataSet ds = dal.GetTimeOutDataSet(storeName, timeOutValue, paramValues);
            return (List<CheckShipmentAffterCompleteReceiptInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<CheckShipmentAffterCompleteReceiptInfo> list = new List<CheckShipmentAffterCompleteReceiptInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    CheckShipmentAffterCompleteReceiptInfo objInfo = (CheckShipmentAffterCompleteReceiptInfo)GetObjectFromDataRow(row);
                    list.Add(objInfo);
                }
            }
            ds.Dispose();
            return list;
        }
    }
}
