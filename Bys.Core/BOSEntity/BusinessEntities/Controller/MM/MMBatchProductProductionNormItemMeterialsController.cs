using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBatchProductProductionNormItemMeterials
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductProductionNormItemMeterialsController
    //Created Date:Thursday, May 17, 2018
    //-----------------------------------------------------------

    public class MMBatchProductProductionNormItemMeterialsController : BaseBusinessController
    {
        public MMBatchProductProductionNormItemMeterialsController()
        {
            dal = new DALBaseProvider("MMBatchProductProductionNormItemMeterials", typeof(MMBatchProductProductionNormItemMeterialsInfo));
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetBatchProductProductionNormItemMeterialByFK_BatchProductProductionNormItemID(int batchProductProductionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_SelectByFK_MMBatchProductProductionNormItemID", batchProductProductionNormItemID);
            List<MMBatchProductProductionNormItemMeterialsInfo> BatchProductProductionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    BatchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return BatchProductProductionNormItemMeterialList;
        }
        public void InsertMeterialDetail(int batchProductID, string createdUser)
        {
            dal.ExecuteStoredProcedure("MMBatchProductProductionNormItemMeterials_InsertMeterialFromProductionNormItem", batchProductID, createdUser);
        }
        public void DeleteMeterialDetail(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMBatchProductProductionNormItemMeterials_DeleteMeterialDetail", batchProductID, updateUser);
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetBatchProductItemMeterialsForReportByBatchProductID(int batchProductID)
        {
            DataSet results = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetBatchProductItemMeterialsForReportByBatchProductID", batchProductID);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(results);
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetBatchProductItemMeterialsForReportByBPProductionNormItemRef(string BPProductionNormItemRef)
        {
            DataSet results = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetBatchProductItemMeterialsForReportByBPProductionNormItemRef", BPProductionNormItemRef);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(results);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBatchProductProductionNormItemMeterialsInfo> productionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    productionNormItemMeterialList.Add(objProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return productionNormItemMeterialList;
        }
        public void CreateBPProductionNormItemMeterialsByBatchProductID(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMProductionNormItemMeterials_CreateBPProductionNormItemMeterialsByBatchProductID", batchProductID, updateUser);
        }
        public void CreateByBatchProductID(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMBatchProductProductionNormItemMeterials_CreateByBatchProductID", batchProductID, updateUser);
        }
        public void CreateByBatchProductIDProcess(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMBatchProductProductionNormItemProcesss_CreateByBatchProductID", batchProductID, updateUser);
        }

        public void CreateCarcassProcessByBatchProductID(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMBPNItemProcesss_CarcassProcess_CreateByBatchProductID", batchProductID, updateUser);
        }

        public void CreateColorProcessByBatchProductID(int batchProductID, string updateUser)
        {
            dal.ExecuteStoredProcedure("MMBPNItemProcesss_ColorProcess_CreateByBatchProductID", batchProductID, updateUser);
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListByBatchProductProductionNormItemID(int batchProductProductionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListByBatchProductProductionNormItemID", batchProductProductionNormItemID);
            List<MMBatchProductProductionNormItemMeterialsInfo> BatchProductProductionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    BatchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return BatchProductProductionNormItemMeterialList;
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListByListBatchProductProductionNormItemID(string listbatchProductProductionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListByListBatchProductProductionNormItemID", listbatchProductProductionNormItemID);
            List<MMBatchProductProductionNormItemMeterialsInfo> BatchProductProductionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    BatchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return BatchProductProductionNormItemMeterialList;
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetByItemID(int itemID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetByItemID", itemID);
            List<MMBatchProductProductionNormItemMeterialsInfo> BatchProductProductionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    BatchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return BatchProductProductionNormItemMeterialList;
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetMeterialsByBPPNItemIDs(string BPPNItemIDs, string deliminator)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetMeterialsByBPPNItemIDs", BPPNItemIDs, deliminator);
            List<MMBatchProductProductionNormItemMeterialsInfo> BatchProductProductionNormItemMeterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductProductionNormItemMeterialsInfo objBatchProductProductionNormItemMeterialsInfo = (MMBatchProductProductionNormItemMeterialsInfo)GetObjectFromDataRow(row);
                    BatchProductProductionNormItemMeterialList.Add(objBatchProductProductionNormItemMeterialsInfo);
                }
            }
            ds.Dispose();
            return BatchProductProductionNormItemMeterialList;
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetProductForBatchProductShedule(string productGroup)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItems_GetProductForBatchProductShedule", productGroup);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListBomChangeMaterialBySomeCriteria(int fromNormID, int toBatchItemID, string type)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListBomChangeMaterialBySomeCriteria", fromNormID, toBatchItemID, type);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListBomChangeMaterialByBatchQtyAndSomeCriteria(int fromNormID, int toBatchItemID, decimal qty)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListBomChangeMaterialByBatchQtyAndSomeCriteria", fromNormID, toBatchItemID, qty);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListBomChangeOtherMaterialBySomeCriteria(int fromNormID, int toBatchItemID, string type)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListBomChangeOtherMaterialBySomeCriteria", fromNormID, toBatchItemID, type);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }
        public List<MMBatchProductProductionNormItemMeterialsInfo> GetListBomChangeOtherMaterialByBatchQtyAndSomeCriteria(int fromNormID, int toBatchItemID, decimal qty)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetListBomChangeOtherMaterialByBatchQtyAndSomeCriteria", fromNormID, toBatchItemID, qty);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }

        public List<MMBatchProductProductionNormItemMeterialsInfo> GetMaterialOverBOMByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductProductionNormItemMeterials_GetMaterialOverBOMByBatchProductID", batchProductID);
            return (List<MMBatchProductProductionNormItemMeterialsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}