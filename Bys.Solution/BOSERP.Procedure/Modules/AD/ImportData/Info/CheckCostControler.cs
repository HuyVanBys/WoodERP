using BOSLib;
using BOSLib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Procedure.Modules.AD.ImportData
{
    public class CheckCostControler : BaseBusinessController
    {
        public CheckCostControler()
        {
            dal = new DALBaseProvider("CheckCost", typeof(CheckCostInfo));
        }
        public List<CheckCostInfo> GetDataErrorAndPrevProductionCost(string storeName, int timeOutValue, params object[] paramValues)
        {

            DataSet ds = dal.GetTimeOutDataSet(storeName, timeOutValue, paramValues);
            return (List<CheckCostInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<CheckCostInfo> list = new List<CheckCostInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    CheckCostInfo objInfo = (CheckCostInfo)GetObjectFromDataRow(row);
                    list.Add(objInfo);
                }
            }
            ds.Dispose();
            return list;
        }
    }
}
