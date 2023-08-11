using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.BusinessResult
{
    class BusinessResultModule : BaseModuleERP
    {
        #region Constant
        #endregion
        #region Public properties
        #endregion

        public BusinessResultModule()
        {
            Name = "BusinessResult";
            CurrentModuleEntity = new BusinessResultEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public override int ActionSave()
        {
            return base.ActionSave();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            BusinessResultEntities entity = (BusinessResultEntities)CurrentModuleEntity;
            ACBusinessResultsInfo mainObject = (ACBusinessResultsInfo)entity.MainObject;
            mainObject.ACBusinessResultFromDate = BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate());
            mainObject.ACBusinessResultToDate = BOSApp.GetPeriodEndDate(BOSApp.GetCurrentServerDate());
            mainObject.ACBusinessResultOpeningFromDate = BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate());
            mainObject.ACBusinessResultOpeningToDate = BOSApp.GetPeriodEndDate(BOSApp.GetCurrentServerDate());
        }

        public void GetData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            BusinessResultEntities entity = (BusinessResultEntities)CurrentModuleEntity;
            ACBusinessResultsInfo mainObject = (ACBusinessResultsInfo)entity.MainObject;
            entity.ACBusinessResultDetailsList.Clear();
            ACBusinessResultDetailsController controller = new ACBusinessResultDetailsController();
            List<ACBusinessResultDetailsInfo> businessResultDetails = controller.GetBusinessResultDetails(mainObject.ACBusinessResultFromDate
                                                                                  , mainObject.ACBusinessResultToDate
                                                                                  , mainObject.ACBusinessResultOpeningFromDate
                                                                                  , mainObject.ACBusinessResultOpeningToDate
                                                                                  , mainObject.FK_BRBranchID
                                                                                  , mainObject.FK_BRBranchCentralID);
            entity.ACBusinessResultDetailsList.Invalidate(businessResultDetails);

            //DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            //DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));

            //ACAccountsController objAccountsController = new ACAccountsController();
            //ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();

            //BusinessResultEntities entity = (BusinessResultEntities)CurrentModuleEntity;
            //ACBalanceAmountArisingDetailsController objBalanceAmountArisingDetailsController = new ACBalanceAmountArisingDetailsController();
            //ACBalanceAmountArisingsController objBalanceAmountArisingsController = new ACBalanceAmountArisingsController();
            ////ACBalanceAmountArisingsInfo objBalanceAmountArisingsInfo = (ACBalanceAmountArisingsInfo)objBalanceAmountArisingsController.GetBalanceAmountArisings(fromDate, toDate);
            //entity.ACBusinessResultDetailsList.Clear();
            //ACBusinessResultsInfo mainObject = (ACBusinessResultsInfo)entity.MainObject;

            //List<ACBalanceAmountArisingDetailsInfo> ListBalanceAmountArising = objBalanceAmountArisingDetailsController.GetBalanceAmountArisingDetailsNew(fromDate, toDate, mainObject.FK_BRBranchID);
            //List<ACBalanceAmountArisingDetailsInfo> ListBalanceAmountArisingPre = objBalanceAmountArisingDetailsController.GetBalanceAmountArisingDetailsNew(prevPeriodStartDate, prevPeriodEndDate, mainObject.FK_BRBranchID);

            //GEAccountingFormulaItemsController objAccountingFormulaItemsController = new GEAccountingFormulaItemsController();
            //List<GEAccountingFormulaItemsInfo> ListItem = objAccountingFormulaItemsController.GetObjectForReport("Báo cáo kết quả hoạt động kinh doanh");
            //List<GEAccountingFormulaItemsInfo> ListParent = new List<GEAccountingFormulaItemsInfo>();
            //List<GEAccountingFormulaItemsInfo> ListView = new List<GEAccountingFormulaItemsInfo>();
            //List<GEAccountingFormulaItemsInfo> List = new List<GEAccountingFormulaItemsInfo>();

            //ACIncomeStatementsInfo incomeStatement = new ACIncomeStatementsInfo();

            //ACBusinessResultsController objBusinessResultsController = new ACBusinessResultsController();
            //ACBusinessResultDetailsController objBusinessResultDetailsController = new ACBusinessResultDetailsController();
            //ACBusinessResultsInfo objBusinessResultsInfo = new ACBusinessResultsInfo();
            //objBusinessResultsInfo = (ACBusinessResultsInfo)objBusinessResultsController.GetBusinessResults(prevPeriodStartDate, prevPeriodEndDate);

            //ACBusinessResultDetailsInfo obj;
            //foreach (GEAccountingFormulaItemsInfo item in ListItem)
            //{
            //    if (!string.IsNullOrEmpty(item.GEAccountingFormulaItemCategory) && item.GEAccountingFormulaItemShowPrint)
            //    {
            //        obj = new ACBusinessResultDetailsInfo();
            //        obj.ACBusinessResultDetailAcountName = item.GEAccountingFormulaItemCategory;
            //        obj.ACBusinessResultDetailAcountNumber = item.GEAccountingFormulaItemNumber.ToString();
            //        entity.ACBusinessResultDetailsList.Add(obj);
            //    }
            //}  

            //if (ListItem != null && ListItem.Count > 0)
            //{
            //    foreach (GEAccountingFormulaItemsInfo objAccountingFormulaItemsInfo in ListItem)
            //    {
            //        if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit))
            //        {
            //            string[] debitAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountDebit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);

            //            if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
            //            {
            //                objAccountingFormulaItemsInfo.StartYearBalance = 0;
            //                objAccountingFormulaItemsInfo.EndYearBalance = 0;
            //                for (int i = 0; i < debitAccount.Length; i++)
            //                {
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArising)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == debitAccount[i])
            //                        {
            //                            //objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            objAccountingFormulaItemsInfo.EndYearBalance -= item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArisingPre)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == debitAccount[i])
            //                        {
            //                            objAccountingFormulaItemsInfo.StartYearBalance -= item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            //objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }
            //                }
            //                foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //                {
            //                    if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == objAccountingFormulaItemsInfo.GEAccountingFormulaItemNumber)
            //                    {
            //                        item.ACBusinessResultDetailStartPeriodBalance = objAccountingFormulaItemsInfo.StartYearBalance; //kỳ trước
            //                        item.ACBusinessResultDetailEndPeriodBalance = objAccountingFormulaItemsInfo.EndYearBalance;    //kỳ này
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                objAccountingFormulaItemsInfo.StartYearBalance = 0;
            //                objAccountingFormulaItemsInfo.EndYearBalance = 0;
            //                for (int i = 0; i < debitAccount.Length; i++)
            //                {
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArising)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == debitAccount[i])
            //                        {
            //                            //objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArisingPre)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == debitAccount[i])
            //                        {
            //                            objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            //objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }
            //                }
            //                foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //                {
            //                    if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == objAccountingFormulaItemsInfo.GEAccountingFormulaItemNumber)
            //                    {
            //                        item.ACBusinessResultDetailStartPeriodBalance = objAccountingFormulaItemsInfo.StartYearBalance; //kỳ trước
            //                        item.ACBusinessResultDetailEndPeriodBalance = objAccountingFormulaItemsInfo.EndYearBalance;    //kỳ này
            //                        break;
            //                    }
            //                }

            //            }
            //        }
            //        if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit))
            //        {
            //            string[] creditAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountCredit.Split(new string[] { ",", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);

            //            if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
            //            {
            //                objAccountingFormulaItemsInfo.StartYearBalance = 0;
            //                objAccountingFormulaItemsInfo.EndYearBalance = 0;
            //                for (int i = 0; i < creditAccount.Length; i++)
            //                {
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArising)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == creditAccount[i])
            //                        {
            //                            //objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            objAccountingFormulaItemsInfo.EndYearBalance -= item.ACBalanceAmountArisingDetailPeriodCreditBalance;
            //                        }
            //                    }
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArisingPre)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == creditAccount[i])
            //                        {
            //                            objAccountingFormulaItemsInfo.StartYearBalance -= item.ACBalanceAmountArisingDetailPeriodCreditBalance;
            //                            //objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }
            //                }

            //                foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //                {
            //                    if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == objAccountingFormulaItemsInfo.GEAccountingFormulaItemNumber)
            //                    {
            //                        item.ACBusinessResultDetailStartPeriodBalance = objAccountingFormulaItemsInfo.StartYearBalance; //kỳ trước
            //                        item.ACBusinessResultDetailEndPeriodBalance = objAccountingFormulaItemsInfo.EndYearBalance;    //kỳ này
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                objAccountingFormulaItemsInfo.StartYearBalance = 0;
            //                objAccountingFormulaItemsInfo.EndYearBalance = 0;
            //                for (int i = 0; i < creditAccount.Length; i++)
            //                {
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArising)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == creditAccount[i])
            //                        {
            //                            //objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                            objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodCreditBalance;
            //                        }
            //                    }
            //                    foreach (ACBalanceAmountArisingDetailsInfo item in ListBalanceAmountArisingPre)
            //                    {
            //                        if (item.ACBalanceAmountArisingDetailAcountNumber == creditAccount[i])
            //                        {
            //                            objAccountingFormulaItemsInfo.StartYearBalance += item.ACBalanceAmountArisingDetailPeriodCreditBalance;
            //                            //objAccountingFormulaItemsInfo.EndYearBalance += item.ACBalanceAmountArisingDetailPeriodDebitBalance;
            //                        }
            //                    }    
            //                }

            //                foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //                {
            //                    if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == objAccountingFormulaItemsInfo.GEAccountingFormulaItemNumber)
            //                    {
            //                        item.ACBusinessResultDetailStartPeriodBalance = objAccountingFormulaItemsInfo.StartYearBalance; //kỳ trước
            //                        item.ACBusinessResultDetailEndPeriodBalance = objAccountingFormulaItemsInfo.EndYearBalance;    //kỳ này
            //                        break;
            //                    }
            //                }

            //            }
            //        }
            //        if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemFormula))
            //        {
            //            //string[] accountFomula = objAccountingFormulaItemsInfo.GEAccountingFormulaItemFormula.Split(new string[] { "+", "-", " " }, StringSplitOptions.RemoveEmptyEntries);                       
            //            char[] calculationAccount = objAccountingFormulaItemsInfo.GEAccountingFormulaItemFormula.ToCharArray();
            //            string[] fomulaAccount = new string[(calculationAccount.Length + (calculationAccount.Length -1))];
            //            int j = 0;
            //            for (int i = 0; i < calculationAccount.Length; i++)
            //            {
            //                if (calculationAccount[i].Equals('+') || calculationAccount[i].Equals('-'))
            //                {
            //                    j++;
            //                    fomulaAccount[j] = calculationAccount[i] + "";
            //                    j++;
            //                }
            //                else
            //                {
            //                    fomulaAccount[j] = fomulaAccount[j] + calculationAccount[i];
            //                }
            //            }
            //            objAccountingFormulaItemsInfo.StartYearBalance = 0;
            //            objAccountingFormulaItemsInfo.EndYearBalance = 0;
            //            int nhan = 1;
            //            for (int i = 0; i < fomulaAccount.Length; i++)
            //            {
            //                string chuoi = fomulaAccount[i];
            //                if (chuoi != null)
            //                {
            //                    int temp = 0;

            //                    if (chuoi.Equals("+"))
            //                    {
            //                        nhan = 1;
            //                        continue;
            //                    }
            //                    if (chuoi.Equals("-"))
            //                    {
            //                        nhan = -1;
            //                        continue;
            //                    }
            //                    foreach (GEAccountingFormulaItemsInfo itemList in ListItem)
            //                    {
            //                        if (itemList.GEAccountingFormulaItemAccountNo == chuoi)
            //                        {
            //                            temp = itemList.GEAccountingFormulaItemNumber;
            //                            break;
            //                        }
            //                    }

            //                    foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //                    {
            //                        if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == temp)
            //                        {
            //                            objAccountingFormulaItemsInfo.StartYearBalance += (nhan * item.ACBusinessResultDetailStartPeriodBalance);
            //                            objAccountingFormulaItemsInfo.EndYearBalance += (nhan * item.ACBusinessResultDetailEndPeriodBalance);
            //                            break;
            //                        }
            //                    }
            //                }  
            //            }
            //            foreach (ACBusinessResultDetailsInfo item in entity.ACBusinessResultDetailsList)
            //            {
            //                if (Convert.ToInt32(item.ACBusinessResultDetailAcountNumber) == objAccountingFormulaItemsInfo.GEAccountingFormulaItemNumber)
            //                {
            //                    item.ACBusinessResultDetailStartPeriodBalance = objAccountingFormulaItemsInfo.StartYearBalance; //kỳ trước
            //                    item.ACBusinessResultDetailEndPeriodBalance = objAccountingFormulaItemsInfo.EndYearBalance;    //kỳ này
            //                    //item.ACBusinessResultDetailAcountNumber = objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccountNo;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            entity.ACBusinessResultDetailsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }
    }
}