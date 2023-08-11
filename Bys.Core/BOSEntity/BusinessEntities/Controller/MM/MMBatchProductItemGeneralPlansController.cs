using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBatchProductItemGeneralPlans
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductItemGeneralPlansController
    //Created Date:Saturday, April 06, 2019
    //-----------------------------------------------------------

    public class MMBatchProductItemGeneralPlansController : BaseBusinessController
    {
        public MMBatchProductItemGeneralPlansController()
        {
            dal = new DALBaseProvider("MMBatchProductItemGeneralPlans", typeof(MMBatchProductItemGeneralPlansInfo));
        }
        public List<MMBatchProductItemGeneralPlansInfo> GetGeneralPlanByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetGeneralPlanByBatchProductID", batchProductID);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBatchProductItemGeneralPlansInfo> products = new List<MMBatchProductItemGeneralPlansInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemGeneralPlansInfo objProductsInfo = (MMBatchProductItemGeneralPlansInfo)GetObjectFromDataRow(row);
                    products.Add(objProductsInfo);
                }
            }
            ds.Dispose();
            return products;
        }

        public List<MMBatchProductItemGeneralPlansInfo> GetByDateAndOperationExceptBatchProductItem(DateTime getDate, int operationID, int batchProductItemID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetByDateAndOperationExceptBatchProductItem", getDate, operationID, batchProductItemID);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }
        public List<MMBatchProductItemGeneralPlansInfo> GetByDateAndDepartmentExceptBatchProduct(DateTime getDate, int departmentID, int batchProductID, string productGroupType)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetByDateAndDepartmentExceptBatchProduct", getDate, departmentID, batchProductID, productGroupType);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }
        public List<MMBatchProductItemGeneralPlansInfo> GetSwitchingByDateAndDepartmentExceptBatchProduct(DateTime getDate, int departmentID, int batchProductID, string productGroupType)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetSwitchingByDateAndDepartmentExceptBatchProduct", getDate, departmentID, batchProductID, productGroupType);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }
        public List<MMBatchProductItemGeneralPlansInfo> GetByDateAndDepartmentAndOperationExceptBatchProduct(DateTime getDate, int departmentID, int batchProductID, int operationID, string productGroupType)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetByDateAndDepartmentAndOperationExceptBatchProduct", getDate, departmentID, batchProductID, operationID, productGroupType);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }

        public List<MMBatchProductItemGeneralPlansInfo> GetSwitchingByDateAndDepartmentAndOperationExceptBatchProduct(DateTime getDate, int departmentID, int batchProductID, int operationID, string productGroupType)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemGeneralPlans_GetSwitchingByDateAndDepartmentAndOperationExceptBatchProduct", getDate, departmentID, batchProductID, operationID, productGroupType);
            return (List<MMBatchProductItemGeneralPlansInfo>)GetListFromDataSet(ds);

        }

        public decimal GetPlanByDepartmentAndTypeAndDateExceptBatchProductID(int departmentID, string type, DateTime date, int batchProductID)
        {
            Object obj = dal.GetSingleValue("MMBatchProductItemGeneralPlans_GetPlanByDepartmentAndTypeAndDateExceptBatchProductID", departmentID, type, date, batchProductID);
            decimal Debt = 0;
            if (obj != null)
                decimal.TryParse(obj.ToString(), out Debt);

            return Debt;
        }


    }
    #endregion
}