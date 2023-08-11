﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARInvoiceItemComponents
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARInvoiceItemComponentsController
    //Created Date:Tuesday, October 25, 2011
    //-----------------------------------------------------------

    public class ARInvoiceItemComponentsController : BaseBusinessController
    {
        public ARInvoiceItemComponentsController()
        {
            dal = new DALBaseProvider("ARInvoiceItemComponents", typeof(ARInvoiceItemComponentsInfo));
        }

        /// <summary>
        /// Get invoice item component list by invoice item id
        /// </summary>
        /// <param name="invoiceItemID">ID of invoice item</param>
        /// <returns>List of invoice item component</returns>
        public List<ARInvoiceItemComponentsInfo> GetInvoiceItemComponentListByInvoiceItemID(int invoiceItemID)
        {
            DataSet ds = dal.GetDataSet("ARInvoiceItemComponents_GetInvoiceItemComponentListByInvoiceItemID", invoiceItemID);
            List<ARInvoiceItemComponentsInfo> components = new List<ARInvoiceItemComponentsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARInvoiceItemComponentsInfo objInvoiceItemComponentInfo = (ARInvoiceItemComponentsInfo)GetObjectFromDataRow(row);
                    components.Add(objInvoiceItemComponentInfo);
                }
            }
            return components;
        }
    }
    #endregion
}