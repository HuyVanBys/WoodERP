using BOSCommon.Enums;
using BOSLib;
using BOSLib.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSERP
{
    public class IPInventoryStockCountsController : BaseBusinessController
    {
        public IPInventoryStockCountsController()
        {
            dal = new DALBaseProvider("IPInventoryStockCountsInfo", typeof(IPInventoryStockCountsInfo));
        }

        public List<IPInventoryStockCountsInfo> GetInventoryForStockCount(DateTime inventoryDate, int stockId)
        {
            DynamicParameters dynmParams = new DynamicParameters();
            dynmParams.Add("@FK_BRBranchID", null, DbType.Int32, ParameterDirection.Input);
            dynmParams.Add("@FK_ICStockID", stockId, DbType.Int32, ParameterDirection.Input);
            dynmParams.Add("@FK_ICProductGroupID", null, DbType.Int32, ParameterDirection.Input);
            dynmParams.Add("@FK_ICDepartmentID", null, DbType.Int32, ParameterDirection.Input);
            dynmParams.Add("@InventoryStockCountType", InventoryStockCountType.Package.ToString(), DbType.String, ParameterDirection.Input);
            dynmParams.Add("@ToDate", inventoryDate, DbType.DateTime, ParameterDirection.Input);
            var results = SqlDatabaseHelper.Connection.ExecuteReader("ICInventoryStockCountItems_GetICInventoryStockCountItemsActiveInStockAndDepartment", dynmParams, commandType: CommandType.StoredProcedure);
            return results.ConvertToList<IPInventoryStockCountsInfo>().ToList();
        }
    }
}
