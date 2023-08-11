using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBPOperationDepartments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBPOperationDepartmentsController
    //Created Date:Saturday, December 15, 2018
    //-----------------------------------------------------------

    public class MMBPOperationDepartmentsController : BaseBusinessController
    {
        public MMBPOperationDepartmentsController()
        {
            dal = new DALBaseProvider("MMBPOperationDepartments", typeof(MMBPOperationDepartmentsInfo));
        }
        public List<MMBPOperationDepartmentsInfo> GetMMBPOperationDepartmentByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBPOperationDepartments_GetMMBPOperationDepartmentByBatchProductID", batchProductID);
            return (List<MMBPOperationDepartmentsInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBPOperationDepartmentsInfo> itemsList = new List<MMBPOperationDepartmentsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBPOperationDepartmentsInfo objitemsInfo = (MMBPOperationDepartmentsInfo)GetObjectFromDataRow(row);
                    itemsList.Add(objitemsInfo);
                }
            }
            ds.Dispose();
            return itemsList;
        }

        public List<MMBPOperationDepartmentsInfo> GetByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBPOperationDepartments_GetByBatchProductID", batchProductID);
            return (List<MMBPOperationDepartmentsInfo>)GetListFromDataSet(ds);
        }

    }
    #endregion
}