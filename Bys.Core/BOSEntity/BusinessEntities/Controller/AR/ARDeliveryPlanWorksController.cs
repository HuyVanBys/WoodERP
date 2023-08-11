﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARDeliveryPlanWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDeliveryPlanWorksController
    //Created Date:19 Tháng Ba 2018
    //-----------------------------------------------------------

    public class ARDeliveryPlanWorksController : BaseBusinessController
    {
        public ARDeliveryPlanWorksController()
        {
            dal = new DALBaseProvider("ARDeliveryPlanWorks", typeof(ARDeliveryPlanWorksInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARDeliveryPlanWorksInfo> deliveryPlanWorks = new List<ARDeliveryPlanWorksInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo = (ARDeliveryPlanWorksInfo)GetObjectFromDataRow(row);
                    deliveryPlanWorks.Add(objDeliveryPlanWorksInfo);
                }
            }
            ds.Dispose();
            return deliveryPlanWorks;
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksByDeliveryPlanID(int deliveryPlanID)
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksByDeliveryPlanID", deliveryPlanID);

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksByDeliveryPlanIDAndDeliveryPlanWorkType(int deliveryPlanID, string deliveryPlanWorkProductType)
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksByDeliveryPlanIDAndDeliveryPlanWorkType", deliveryPlanID, deliveryPlanWorkProductType);

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorkAssetsForAllocationItems()
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorkAssetsForAllocationItems");

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksForTransferConstructionItems()
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksForTransferConstructionItems");

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksForTransferAdditionalItems()
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksForTransferAdditionalItems");

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorkAssetByDeliveryPlanID(int deliveryPlanID)
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorkAssetByDeliveryPlanID", deliveryPlanID);

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksByDeliveryPlanIDs(string deliveryPlanIDs)
        {
            DataSet results = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksByDeliveryPlanIDs", deliveryPlanIDs);
            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(results);
        }

        public List<ARDeliveryPlanWorksInfo> GetDeliveryPlanWorksByDeliveryPlanIDAndDeliveryPlanWorkTypeNotInICShipmentItems(int deliveryPlanID, string deliveryPlanWorkProductType)
        {
            DataSet ds = dal.GetDataSet("ARDeliveryPlanWorks_GetDeliveryPlanWorksByDeliveryPlanIDAndDeliveryPlanWorkTypeNotInICShipmentItems", deliveryPlanID, deliveryPlanWorkProductType);

            return (List<ARDeliveryPlanWorksInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}