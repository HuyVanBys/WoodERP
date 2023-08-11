using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARSaleOrderItemWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSaleOrderItemWorksController
    //Created Date:Thursday, March 15, 2018
    //-----------------------------------------------------------

    public class ARSaleOrderItemWorksController : BaseBusinessController
    {
        public ARSaleOrderItemWorksController()
        {
            dal = new DALBaseProvider("ARSaleOrderItemWorks", typeof(ARSaleOrderItemWorksInfo));
        }

        public List<ARSaleOrderItemWorksInfo> GetItemWorksBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderItemWorks_GetSaleOrderItemWorksBySaleOrderID", saleOrderID);
            List<ARSaleOrderItemWorksInfo> itemWorks = new List<ARSaleOrderItemWorksInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ARSaleOrderItemWorksController objSaleOrderItemWorksController = new ARSaleOrderItemWorksController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSaleOrderItemWorksInfo objSaleOrderItemWorksInfo = (ARSaleOrderItemWorksInfo)objSaleOrderItemWorksController.GetObjectFromDataRow(row);
                    itemWorks.Add(objSaleOrderItemWorksInfo);
                }
            }
            return itemWorks;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARSaleOrderItemWorksInfo> saleOrderItemWorks = new List<ARSaleOrderItemWorksInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSaleOrderItemWorksInfo objSaleOrderItemWorksInfo = (ARSaleOrderItemWorksInfo)GetObjectFromDataRow(row);
                    saleOrderItemWorks.Add(objSaleOrderItemWorksInfo);
                }
            }
            ds.Dispose();
            return saleOrderItemWorks;
        }

        public List<ARSaleOrderItemWorksInfo> GetServiceItemWorksBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderItemWorks_GetSaleOrderServiceItemWorksBySaleOrderID", saleOrderID);
            return (List<ARSaleOrderItemWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARSaleOrderItemWorksInfo> GetSaleOrderItemWorksBySaleOrderItemID(int SaleOrderItemID)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderItemWorks_GetSaleOrderItemWorksBySaleOrderItemID", SaleOrderItemID);
            return (List<ARSaleOrderItemWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARSaleOrderItemWorksInfo> GetSaleOrderItemWorksForAcceptance(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderItemWorks_GetSaleOrderItemWorksForAcceptance", saleOrderID);
            return (List<ARSaleOrderItemWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARSaleOrderItemWorksInfo> GetSaleOrderItemWorkBySaleOrderID(int saleOrderID, string saleOrderWorkNotRef)
        {
            DataSet ds = dal.GetDataSet("ARSaleOrderItemWorks_GetSaleOrderItemWorkBySaleOrderID", saleOrderID, saleOrderWorkNotRef);
            return (List<ARSaleOrderItemWorksInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}