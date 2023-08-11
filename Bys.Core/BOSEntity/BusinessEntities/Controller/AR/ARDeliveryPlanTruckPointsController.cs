﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARDeliveryPlanTruckPoints
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDeliveryPlanTruckPointsController
    //Created Date:Friday, March 23, 2018
    //-----------------------------------------------------------

    public class ARDeliveryPlanTruckPointsController : BaseBusinessController
    {
        public ARDeliveryPlanTruckPointsController()
        {
            dal = new DALBaseProvider("ARDeliveryPlanTruckPoints", typeof(ARDeliveryPlanTruckPointsInfo));
        }

        public List<ARDeliveryPlanTruckPointsInfo> GetDeliveryPlanTruckPointsByDeliveryPlanID(int deliveryPlanID)
        {
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPoints = new List<ARDeliveryPlanTruckPointsInfo>();
            DataSet results = dal.GetDataSet("ARDeliveryPlanTruckPoints_GetDeliveryPlanTruckPointsByDeliveryPlanID", deliveryPlanID);

            if (results.Tables.Count > 0)
            {
                foreach (DataRow row in results.Tables[0].Rows)
                {
                    ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = (ARDeliveryPlanTruckPointsInfo)GetObjectFromDataRow(row);
                    deliveryPlanTruckPoints.Add(objDeliveryPlanTruckPointsInfo);
                }
            }
            return deliveryPlanTruckPoints;
        }

        public List<ARDeliveryPlanTruckPointsInfo> GetDeliveryPlanTruckPointsByDate(DateTime? dateFrom, DateTime? dateTo)
        {
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPoints = new List<ARDeliveryPlanTruckPointsInfo>();
            DataSet results = dal.GetDataSet("ARDeliveryPlanTruckPoints_GetDeliveryPlanTruckPointsByDate", dateFrom, dateTo);
            if (results.Tables.Count > 0)
            {
                foreach (DataRow row in results.Tables[0].Rows)
                {
                    ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = (ARDeliveryPlanTruckPointsInfo)GetObjectFromDataRow(row);
                    deliveryPlanTruckPoints.Add(objDeliveryPlanTruckPointsInfo);
                }
            }
            return deliveryPlanTruckPoints;
        }

        public void DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID(int deliveryPlanTruckID)
        {
            dal.ExecuteStoredProcedure("ARDeliveryPlanTruckPoints_DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID", deliveryPlanTruckID);
        }

        public void UpdateDeliveryPlanTruckPointsIsCanceledSaleOrder(int deliveryPlanID)
        {
            dal.ExecuteStoredProcedure("ARDeliveryPlanTruckPoints_UpdateDeliveryPlanTruckPointsIsCanceledSaleOrder", deliveryPlanID);
        }
    }
    #endregion
}