﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARCustomerPaymentDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCustomerPaymentDetailsController
    //Created Date:Tuesday, January 17, 2012
    //-----------------------------------------------------------

    public class ARCustomerPaymentDetailsController : BaseBusinessController
    {
        public ARCustomerPaymentDetailsController()
        {
            dal = new DALBaseProvider("ARCustomerPaymentDetails", typeof(ARCustomerPaymentDetailsInfo));
        }

        /// <summary>
        /// Get payment details of an invoice
        /// </summary>
        /// <param name="invoiceID">Invoice id</param>
        /// <returns>Payment details</returns>
        public List<ARCustomerPaymentDetailsInfo> GetPaymentDetailsByInvoiceID(int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARCustomerPaymentDetails_GetPaymentDetailsByInvoiceID", invoiceID);
            List<ARCustomerPaymentDetailsInfo> paymentDetails = new List<ARCustomerPaymentDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARCustomerPaymentDetailsInfo)GetObjectFromDataRow(row);
                    paymentDetails.Add(objCustomerPaymentDetailsInfo);
                }
            }
            return paymentDetails;
        }

        /// <summary>
        /// Get default payment details including all payment methods
        /// </summary>
        /// <returns>List of payment details</returns>
        public List<ARCustomerPaymentDetailsInfo> GetDefaultPaymentDetails()
        {
            List<ARCustomerPaymentDetailsInfo> result = new List<ARCustomerPaymentDetailsInfo>();
            ADConfigValuesController objADConfigValuesController = new ADConfigValuesController();
            DataSet ds = objADConfigValuesController.GetADConfigValuesByGroup(ADConfigValueUtility.ADConfigValuePaymentMethod);
            foreach (DataRow configRow in ds.Tables[0].Rows)
            {
                ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objADConfigValuesController.GetObjectFromDataRow(configRow);
                if (objConfigValuesInfo.IsActive)
                {
                    ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = new ARCustomerPaymentDetailsInfo();
                    objCustomerPaymentDetailsInfo.ARPaymentMethodCombo = objConfigValuesInfo.ADConfigKeyValue;
                    objCustomerPaymentDetailsInfo.ARPaymentMethodDisplayText = objConfigValuesInfo.ADConfigText;
                    result.Add(objCustomerPaymentDetailsInfo);
                }
            }
            return result;
        }

        /// <summary>
        /// Delete all relative data of a payment, including payment details, payments by currencies
        /// and paid documents
        /// </summary>
        /// <param name="customerPaymentID">Customer payment id</param>
        public void DeleteByCustomerPaymentID(int customerPaymentID)
        {
            dal.ExecuteStoredProcedure("ARCustomerPaymentDetails_DeleteByCustomerPaymentID", customerPaymentID);
        }

        /// <summary>
        /// Get all details of a payment
        /// </summary>
        /// <param name="customerPaymentID">Payment id</param>
        /// <returns>List of payment details</returns>
        public List<ARCustomerPaymentDetailsInfo> GetDetailsByPaymentID(int customerPaymentID)
        {
            DataSet ds = dal.GetDataSet("ARCustomerPaymentDetails_GetDetailsByPaymentID", customerPaymentID);
            return (List<ARCustomerPaymentDetailsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARCustomerPaymentDetailsInfo> paymentDetails = new List<ARCustomerPaymentDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARCustomerPaymentDetailsInfo)GetObjectFromDataRow(row);
                    paymentDetails.Add(objCustomerPaymentDetailsInfo);
                }
            }
            ds.Dispose();
            return paymentDetails;
        }

        /// <summary>
        /// Get customer payment detail by customer payment detail information
        /// </summary>
        /// <returns>List of payment details</returns>
        public List<ARCustomerPaymentDetailsInfo> GetCustomerPaymentDetailByCustomerPaymentDetailInfo(string customerPaymentDetailInfo)
        {
            DataSet ds = dal.GetDataSet("ARCustomerPaymentDetails_GetCustomerPaymentDetailByCustomerPaymentDetailInfo", customerPaymentDetailInfo);
            return (List<ARCustomerPaymentDetailsInfo>)GetListFromDataSet(ds);
        }


    }
    #endregion
}