﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARSOItemComponents
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSOItemComponentsController
    //Created Date:Friday, October 21, 2011
    //-----------------------------------------------------------

    public class ARSOItemComponentsController : BaseBusinessController
    {
        public ARSOItemComponentsController()
        {
            dal = new DALBaseProvider("ARSOItemComponents", typeof(ARSOItemComponentsInfo));
        }

        /// <summary>
        /// Get sale order item component list by sale order item id
        /// </summary>
        /// <param name="saleOrderItemID">ID of sale order item</param>
        /// <returns>Sale order item component list</returns>
        public List<ARSOItemComponentsInfo> GetSOItemComponentListBySOItemID(int saleOrderItemID)
        {
            DataSet ds = dal.GetDataSet("ARSOItemComponents_GetSOItemComponentListBySOItemID", saleOrderItemID);
            List<ARSOItemComponentsInfo> components = new List<ARSOItemComponentsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOItemComponentsInfo objSOItemComponentInfo = (ARSOItemComponentsInfo)GetObjectFromDataRow(row);
                    components.Add(objSOItemComponentInfo);
                }
            }
            return components;
        }

        /// <summary>
        /// Update shipped quantity of a component
        /// </summary>
        /// <param name="componentID">Component id</param>
        /// <param name="shippedQty">Updated shipped quantity</param>
        public void UpdateShippedQty(int componentID, decimal shippedQty)
        {
            dal.ExecuteStoredProcedure("ARSOItemComponents_UpdateShippedQty", componentID, shippedQty);
        }
    }
    #endregion
}