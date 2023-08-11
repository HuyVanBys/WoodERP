﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APBillOfLadings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APBillOfLadingsController
    //Created Date:Thursday, January 11, 2018
    //-----------------------------------------------------------

    public class APBillOfLadingsController : BaseBusinessController
    {
        public APBillOfLadingsController()
        {
            dal = new DALBaseProvider("APBillOfLadings", typeof(APBillOfLadingsInfo));

        }

        public APBillOfLadingsInfo GetBOLByReferenceNo(string refNo)
        {
            DataSet ds = dal.GetDataSet("APBillOfLadings_GetBOLByReferenceNo", refNo);
            List<APBillOfLadingsInfo> invoices = new List<APBillOfLadingsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APBillOfLadingsInfo objInvoiceInsInfo = (APBillOfLadingsInfo)GetObjectFromDataRow(row);
                    return objInvoiceInsInfo;
                }
            }
            return null;


        }

        public List<APBillOfLadingsInfo> GetContractNoForExportExcel(int objectID, string objectName)
        {
            DataSet ds = dal.GetDataSet("APBillOfLadings_GetContractNoForExportExcel", objectID, objectName);
            List<APBillOfLadingsInfo> invoices = new List<APBillOfLadingsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APBillOfLadingsInfo objInvoiceInsInfo = (APBillOfLadingsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoiceInsInfo);

                }
            }
            return invoices;


        }

        public List<APBillOfLadingsInfo> GetObjectsForPaymentVoucher(int branchID)
        {
            DataSet ds = dal.GetDataSet("APBillOfLadings_GetObjectsForPaymentVoucher", branchID);
            return (List<APBillOfLadingsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APBillOfLadingsInfo> billOfLadingsList = new List<APBillOfLadingsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)GetObjectFromDataRow(row);
                    billOfLadingsList.Add(objBillOfLadingsInfo);
                }
            }
            ds.Dispose();
            return billOfLadingsList;
        }

    }
    #endregion
}