﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACBalanceAmountArisingDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACBalanceAmountArisingDetailsController
    //Created Date:Tuesday, March 11, 2014
    //-----------------------------------------------------------

    public class ACBalanceAmountArisingDetailsController : BaseBusinessController
    {
        public ACBalanceAmountArisingDetailsController()
        {
            dal = new DALBaseProvider("ACBalanceAmountArisingDetails", typeof(ACBalanceAmountArisingDetailsInfo));
        }

        #region End
        public decimal GetEndValueBalanceAmountArisingDetails_N(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndValueBalanceAmountArisingDetails_N", balanceAmountArisingID, accountNo));
        }
        public decimal GetEndValueBalanceAmountArisingDetails_C(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndValueBalanceAmountArisingDetails_C", balanceAmountArisingID, accountNo));
        }
        public decimal GetEndValueBalanceAmountArisingDetails_NC(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndValueBalanceAmountArisingDetails_NC", balanceAmountArisingID, accountNo));
        }
        public decimal GetEndValueBalanceAmountArisingDetails_CN(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndValueBalanceAmountArisingDetails_CN", balanceAmountArisingID, accountNo));
        }
        //TKChinh Add
        public decimal GetStartDebitBalanceAmountArisingDetails_N(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartDebitBalanceAmountArisingDetails_N", balanceAmountArisingID, accountNo));
        }
        public decimal GetEndDebitBalanceAmountArisingDetails_N(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndDebitBalanceAmountArisingDetails_N", balanceAmountArisingID, accountNo));
        }
        public decimal GetStartCreditBalanceAmountArisingDetails_C(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartCreditBalanceAmountArisingDetails_C", balanceAmountArisingID, accountNo));
        }
        public decimal GetEndCreditBalanceAmountArisingDetails_C(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetEndCreditBalanceAmountArisingDetails_C", balanceAmountArisingID, accountNo));
        }

        //TKChinh End
        #endregion End
        #region Start
        public decimal GetStartValueBalanceAmountArisingDetails_N(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartValueBalanceAmountArisingDetails_N", balanceAmountArisingID, accountNo));
        }
        public decimal GetStartValueBalanceAmountArisingDetails_C(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartValueBalanceAmountArisingDetails_C", balanceAmountArisingID, accountNo));
        }
        public decimal GetStartValueBalanceAmountArisingDetails_NC(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartValueBalanceAmountArisingDetails_NC", balanceAmountArisingID, accountNo));
        }
        public decimal GetStartValueBalanceAmountArisingDetails_CN(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetStartValueBalanceAmountArisingDetails_CN", balanceAmountArisingID, accountNo));
        }

        public decimal GetValueBalanceAmountArisingDetails(int balanceAmountArisingID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBalanceAmountArisingDetails_GetValueBalanceAmountArisingDetails", balanceAmountArisingID, accountNo));
        }
        #endregion Start

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACBalanceAmountArisingDetailsInfo> list = new List<ACBalanceAmountArisingDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACBalanceAmountArisingDetailsInfo obj = (ACBalanceAmountArisingDetailsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<ACBalanceAmountArisingDetailsInfo> GetBalanceAmountArisingDetailDebitAndCreditBalanceByFromDate(DateTime? fromDate)
        {
            DataSet ds = dal.GetDataSet("ACBalanceAmountArisingDetails_GetBalanceAmountArisingDetailDebitAndCreditBalanceByFromDate", fromDate);
            return (List<ACBalanceAmountArisingDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<ACBalanceAmountArisingDetailsInfo> GetBalanceAmountArisingDetailsNew(DateTime? fromDate, DateTime? toDate, int branchID)
        {
            DataSet ds = dal.GetDataSet("ACBalanceAmountArisingDetails_GetBalanceAmountArisingDetailsNew", fromDate, toDate, branchID);
            List<ACBalanceAmountArisingDetailsInfo> BalanceAmountArisingItemList = new List<ACBalanceAmountArisingDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACBalanceAmountArisingDetailsInfo obj = (ACBalanceAmountArisingDetailsInfo)GetObjectFromDataRow(row);
                    BalanceAmountArisingItemList.Add(obj);
                }
            }
            return BalanceAmountArisingItemList;
        }

        public List<ACBalanceAmountArisingDetailsInfo> GetBalanceAmountArisingDetailCDPS(DateTime? fromDate, DateTime? toDate, string acountID, int branchID)
        {
            DataSet ds = dal.GetDataSet("ACBalanceAmountArisingDetails_GetBalanceAmountArisingDetailCDPS", fromDate, toDate, acountID, branchID);
            List<ACBalanceAmountArisingDetailsInfo> BalanceAmountArisingItemList = new List<ACBalanceAmountArisingDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACBalanceAmountArisingDetailsInfo obj = (ACBalanceAmountArisingDetailsInfo)GetObjectFromDataRow(row);
                    BalanceAmountArisingItemList.Add(obj);
                }
            }
            return BalanceAmountArisingItemList;
        }

    }
    #endregion
}