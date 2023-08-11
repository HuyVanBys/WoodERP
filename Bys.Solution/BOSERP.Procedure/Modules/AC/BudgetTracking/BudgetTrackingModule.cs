using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.BudgetTracking
{
    class BudgetTrackingModule : BaseModuleERP
    {
        #region Constant

        public const string ToolbarButtonSaveBalance = "SaveBalance";
        #endregion

        #region Public properties
        #endregion

        public BudgetTrackingModule()
        {
            Name = "BudgetTracking";
            CurrentModuleEntity = new BudgetTrackingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ActionNew();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public void GetData(int brBranchID, DateTime budgetTrackingFromYear, DateTime budgetTrackingToMonth)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            BudgetTrackingEntities entity = (BudgetTrackingEntities)CurrentModuleEntity;
            entity.BudgetTrackingItemsList.Clear();
            ADTargetReportBudgetsController objTargetReportBudgetsController = new ADTargetReportBudgetsController();
            List<ADTargetReportBudgetsInfo> TargetReportBudgetsList = objTargetReportBudgetsController.GetAllTargetReportBudgetsListForBudgetTracking(brBranchID);
            ADTargetReportBudgetsInfo objTargetReportBudgetsInfo = new ADTargetReportBudgetsInfo();
            ACCostBudgetsController objCostBudgetsController = new ACCostBudgetsController();
            ACRevenueBudgetsController objRevenueBudgetsController = new ACRevenueBudgetsController();
            ACCostBudgetDetailsController objCostBudgetDetailsController = new ACCostBudgetDetailsController();
            ACRevenueBudgetDetailsController objRevenueBudgetDetailsController = new ACRevenueBudgetDetailsController();
            List<ACCostBudgetsInfo> CostBudgetsList = objCostBudgetsController.GetAllCostBudgetsListForBudgetTracking(budgetTrackingFromYear, budgetTrackingToMonth);
            List<ACRevenueBudgetsInfo> RevenueBudgetsList = objRevenueBudgetsController.GetAllRevenueBudgetsListForBudgetTracking(budgetTrackingFromYear, budgetTrackingToMonth);
            ACActualCostBudgetDetailsController objActualCostBudgetDetailsController = new ACActualCostBudgetDetailsController();
            ACActualCostBudgetsController objActualCostBudgetsController = new ACActualCostBudgetsController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACActualCostBudgetsInfo> ActualCostBudgetsList = objActualCostBudgetsController.GetAllCostBudgetDetailsListForBudgetTracking(budgetTrackingFromYear, budgetTrackingToMonth);

            TargetReportBudgetsList.ForEach(o =>
            {
                if (o == null)
                    return;
                ACBudgetTrackingItemsInfo objBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
                if (o.ADTargetReportBudgetType != "Formula")
                    objBudgetTrackingItemsInfo = ToBudgetTrackingItems(o);
                if (objBudgetTrackingItemsInfo.ADTargetReportBudgetType == "GetByKMCP")
                {
                    CostBudgetsList.ForEach(x =>
                    {
                        // mang thèn ngân sách chi phí lên
                        if (x.ACCostBudgetMonthDate == 1)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1;
                        }
                        else if (x.ACCostBudgetMonthDate == 2)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2;
                        }
                        else if (x.ACCostBudgetMonthDate == 3)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3;
                        }
                        else if (x.ACCostBudgetMonthDate == 4)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4;
                        }
                        else if (x.ACCostBudgetMonthDate == 5)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5;
                        }
                        else if (x.ACCostBudgetMonthDate == 6)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6;
                        }
                        else if (x.ACCostBudgetMonthDate == 7)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7;
                        }
                        else if (x.ACCostBudgetMonthDate == 8)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8;
                        }
                        else if (x.ACCostBudgetMonthDate == 9)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9;
                        }
                        else if (x.ACCostBudgetMonthDate == 10)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10;
                        }
                        else if (x.ACCostBudgetMonthDate == 11)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11;
                        }
                        else if (x.ACCostBudgetMonthDate == 12)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12 += objCostBudgetDetailsController.GetTotalCostBudgetDetailAmountBySomeCriteria(x.ACCostBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12;
                        }
                    });

                    ActualCostBudgetsList.ForEach(e =>
                    {
                        // chỉnh lại lấy theo tháng
                        if (e.ACActualCostBudgetDate.Month == 1)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent1 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 2)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent2 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 3)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent3 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 4)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent4 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 5)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent5 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 6)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent6 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 7)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent7 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 8)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent8 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 9)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent9 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 10)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent10 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 11)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent11 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                        else if (e.ACActualCostBudgetDate.Month == 12)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 - objActualCostBudgetDetailsController.GetTotalActualCostBudgetDetailBySomeCriteria(e.ACActualCostBudgetID, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent12 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;
                            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == 0)
                                ;
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
                                else
                                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
                            }
                            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                            {
                                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
                                else
                                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
                            }
                        }
                    });
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;

                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12;
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount - objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount;
                    if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount != 0)
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingPercent = (objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount / objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount) * 100;
                }
                else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetType == "GetByMainBook")
                {
                    RevenueBudgetsList.ForEach(x =>
                    {
                        if (x.ACRevenueBudgetMonthDate == 1)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 2)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 3)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 4)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 5)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 6)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 7)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 8)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 9)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 10)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 11)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11;
                        }
                        else if (x.ACRevenueBudgetMonthDate == 12)
                        {
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Entry", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Addition", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12 += objRevenueBudgetDetailsController.GetTotalRevenueBudgetDetailAmountBySomeCriteria(x.ACRevenueBudgetID, "Adjust", brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 += objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12;
                        }
                    });
                    if (budgetTrackingToMonth.Month > 1)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent1 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                                objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                                objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 2)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent2 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                                objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                                objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 3)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent3 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                                objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                                objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 4)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent4 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                                objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                                objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 5)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent5 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                                objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                                objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 6)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent6 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                                objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                                objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 7)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent7 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                                objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                                objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 8)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent8 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                                objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                                objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 9)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent9 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                                objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                                objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 10)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent10 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                                objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                                objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 11)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent11 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                                objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                                objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
                        }
                    }
                    if (budgetTrackingToMonth.Month > 12)
                    {
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 - objDocumentsController.GetTotalDocumentAmountForBudgetTrackingBySomeCriteria(budgetTrackingFromYear, budgetTrackingToMonth, brBranchID, objBudgetTrackingItemsInfo.FK_ACDebitAccountID, objBudgetTrackingItemsInfo.FK_ACCreditAccountID);
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 != 0)
                            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent12 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;
                        if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == 0)
                            ;
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                                objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
                            else
                                objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
                        }
                        else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
                        {
                            if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                                objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
                            else
                                objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
                        }
                    }

                    // tính phần tổng phía sau
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;

                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12;
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount - objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount;
                    if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount != 0)
                        objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingPercent = (objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount / objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount) * 100;
                }

                // thêm item lên lưới
                if (objBudgetTrackingItemsInfo != null && !string.IsNullOrEmpty(objBudgetTrackingItemsInfo.ACBudgetTrackingItemNo))
                    entity.BudgetTrackingItemsList.Add(objBudgetTrackingItemsInfo);

                if (o.ADTargetReportBudgetType == "Formula")
                {
                    ACBudgetTrackingItemsInfo objFirstBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
                    ACBudgetTrackingItemsInfo objSecondBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
                    ACBudgetTrackingItemsInfo objTotalBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
                    int positionOperator = -1;
                    string[] strTargetNoList = o.ADTargetReportBudgetFormula.Split(new Char[] { '+', '-' });
                    List<char> strTargetOperatorList = new List<char>();
                    bool isFormulaStartWithOperator = false;
                    if (strTargetNoList != null && strTargetNoList.Count() > 0)
                    {
                        foreach (char chrOperator in o.ADTargetReportBudgetFormula)
                        {
                            if (chrOperator == '+' || chrOperator == '-')
                            {
                                strTargetOperatorList.Add(chrOperator);
                            }
                        }
                        for (int i = 0; i < o.ADTargetReportBudgetFormula.Length; i++)
                        {
                            if (o.ADTargetReportBudgetFormula[i] == '+' || o.ADTargetReportBudgetFormula[i] == '-')
                            {
                                strTargetOperatorList.Add(o.ADTargetReportBudgetFormula[i]);
                                if (i == 0)
                                    isFormulaStartWithOperator = true;
                            }
                        }
                    }
                    // đã có danh sách các no và ds + -
                    // get no đầu k lm gì và get no 2 + - vô (* int -1 or 1)

                    for (int i = 0; i < strTargetNoList.Length; i++)
                    {
                        if (i == 0)
                        {
                            entity.BudgetTrackingItemsList.ForEach(x =>
                            {
                                if (x.ACBudgetTrackingItemNo == strTargetNoList[i])
                                {
                                    objFirstBudgetTrackingItemsInfo = x;
                                    if (isFormulaStartWithOperator == true)
                                    {
                                        objTotalBudgetTrackingItemsInfo = ToTotalBudgetTrackingItems(x, null, strTargetOperatorList[++positionOperator], '+', o.ADTargetReportBudgetProfitType);
                                        isFormulaStartWithOperator = false;
                                    }
                                    else
                                        objTotalBudgetTrackingItemsInfo = ToTotalBudgetTrackingItems(x, null, '+', '+', o.ADTargetReportBudgetProfitType);
                                    //isFormulaStartWithOperator = false;
                                    // test cac test case xem  có thể gặp lỗi không
                                }
                            });
                        }
                        else if (i > 0)
                        {
                            objFirstBudgetTrackingItemsInfo = objTotalBudgetTrackingItemsInfo;
                            entity.BudgetTrackingItemsList.ForEach(x =>
                            {
                                if (x.ACBudgetTrackingItemNo == strTargetNoList[i])
                                {
                                    objSecondBudgetTrackingItemsInfo = x;
                                }
                            });
                            objTotalBudgetTrackingItemsInfo = ToTotalBudgetTrackingItems(objTotalBudgetTrackingItemsInfo, objSecondBudgetTrackingItemsInfo, '+', strTargetOperatorList[++positionOperator], o.ADTargetReportBudgetProfitType);
                        }
                        // gán các giá trị chung
                        objTotalBudgetTrackingItemsInfo.ACBudgetTrackingItemNo = o.ADTargetReportBudgetNo;
                        objTotalBudgetTrackingItemsInfo.ACBudgetTrackingItemName = o.ADTargetReportBudgetName;
                        objTotalBudgetTrackingItemsInfo.ADTargetReportBudgetType = o.ADTargetReportBudgetType;
                        objTotalBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = o.ADTargetReportBudgetProfitType;
                    }
                    entity.BudgetTrackingItemsList.Add(objTotalBudgetTrackingItemsInfo);
                }
            });
            entity.BudgetTrackingItemsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }

        public ACBudgetTrackingItemsInfo ToBudgetTrackingItems(ADTargetReportBudgetsInfo objTargetReportBudgetsInfo)
        {
            ACBudgetTrackingItemsInfo objBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
            if (objTargetReportBudgetsInfo == null)
                return null;
            if (objTargetReportBudgetsInfo.ADTargetReportBudgetType == "Formula")
                return null;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemNo = objTargetReportBudgetsInfo.ADTargetReportBudgetNo;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemName = objTargetReportBudgetsInfo.ADTargetReportBudgetName;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetType = objTargetReportBudgetsInfo.ADTargetReportBudgetType;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = objTargetReportBudgetsInfo.ADTargetReportBudgetProfitType;
            objBudgetTrackingItemsInfo.FK_ACDebitAccountID = objTargetReportBudgetsInfo.FK_ACDebitAccountID;
            objBudgetTrackingItemsInfo.FK_ACCreditAccountID = objTargetReportBudgetsInfo.FK_ACCreditAccountID;

            return objBudgetTrackingItemsInfo;
        }
        public ACBudgetTrackingItemsInfo ToTotalBudgetTrackingItems(ACBudgetTrackingItemsInfo objFirstBudgetTrackingItemsInfo, ACBudgetTrackingItemsInfo objSecondBudgetTrackingItemsInfo, char chrFirstTargetOperator, char chrSecondTargetOperator, string strTargetReportBudgetProfitType)
        {
            ACBudgetTrackingItemsInfo objBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();
            // tinh ra tong dua tren cong thuc
            int operatorValue1 = GetOperatorValue(chrFirstTargetOperator);
            int operatorValue2 = GetOperatorValue(chrSecondTargetOperator);

            if (objSecondBudgetTrackingItemsInfo == null)
                objSecondBudgetTrackingItemsInfo = new ACBudgetTrackingItemsInfo();

            // bat dau sum
            // t1
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount1 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount1 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount1 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent1 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1) > 0)
                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A1BudgetTrackingItemEvaluateType = "Good";
            }

            // t2
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount2 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount2 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount2 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent2 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2) > 0)
                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A2BudgetTrackingItemEvaluateType = "Good";
            }

            // t3
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount3 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount3 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount3 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent3 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3) > 0)
                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A3BudgetTrackingItemEvaluateType = "Good";
            }

            // t4
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount4 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount4 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount4 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent4 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4) > 0)
                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A4BudgetTrackingItemEvaluateType = "Good";
            }

            // t5
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount5 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount5 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount5 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent5 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5) > 0)
                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A5BudgetTrackingItemEvaluateType = "Good";
            }

            // t6
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount6 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount6 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount6 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent6 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6) > 0)
                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A6BudgetTrackingItemEvaluateType = "Good";
            }

            // t7
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount7 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount7 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount7 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent7 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7) > 0)
                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A7BudgetTrackingItemEvaluateType = "Good";
            }

            // t8
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount8 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount8 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount8 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent8 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8) > 0)
                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A8BudgetTrackingItemEvaluateType = "Good";
            }

            // t9
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount9 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount9 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount9 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent9 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9) > 0)
                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.A9BudgetTrackingItemEvaluateType = "Good";
            }

            // t10
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount10 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount10 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount10 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent10 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10) > 0)
                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.AABudgetTrackingItemEvaluateType = "Good";
            }

            // t11
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount11 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount11 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount11 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent11 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11) > 0)
                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.ABBudgetTrackingItemEvaluateType = "Good";
            }

            // t12
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthEntryAmount12 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdditionAmount12 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthAdjustAmount12 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 * operatorValue2;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 = objFirstBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 * operatorValue1 + objSecondBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 * operatorValue2;

            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPercent12 = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 / objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;
            objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType = strTargetReportBudgetProfitType;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12 && objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 == 0)
                ;
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Revenue")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
                else
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
            }
            else if (objBudgetTrackingItemsInfo.ADTargetReportBudgetProfitType == "Cost")
            {
                if ((objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12 - objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12) > 0)
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Bad";
                else
                    objBudgetTrackingItemsInfo.ACBudgetTrackingItemEvaluateType = "Good";
            }

            objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount3
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount6
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount9
                                                                                        + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthTotalAmount12;

            objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount1 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount2 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount3
                                                                                + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount4 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount5 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount6
                                                                                + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount7 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount8 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount9
                                                                                + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount10 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount11 + objBudgetTrackingItemsInfo.ACBudgetTrackingItemMonthPerformAmount12;
            objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount = objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount - objBudgetTrackingItemsInfo.ACBudgetTrackingItemTotalBudgetAmount;
            if (objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount != 0)
                objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingPercent = (objBudgetTrackingItemsInfo.ACBudgetTrackingItemImplementingAmount / objBudgetTrackingItemsInfo.ACBudgetTrackingItemGeneralAccumulationAmount) * 100;
            return objBudgetTrackingItemsInfo;
        }
        public int GetOperatorValue(char chrTargetOperator)
        {
            if (chrTargetOperator == '+')
                return 1;
            else
                return -1;
        }
    }
}
