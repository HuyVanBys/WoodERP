using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SalaryCalculation
{
    public class SalaryCalculationModule : BaseTransactionModule
    {
        #region Constants
        public const string SalaryCalculationDetailsGridControl = "fld_dgcSalaryCalculationDetails";
        #endregion

        #region Public properties
        public BOSLookupEdit DocumentTypeControl;
        #endregion

        #region Constructor
        public SalaryCalculationModule()
        {
            Name = "SalaryCalculation";
            CurrentModuleEntity = new SalaryCalculationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        /// <summary>
        /// Action new from payroll
        /// </summary>
        public void ActionNewFromPayroll()
        {
            ActionNew();
            SalaryCalculationEntities entity = (SalaryCalculationEntities)CurrentModuleEntity;
            HRPayRollsController objPayRollsController = new HRPayRollsController();
            List<HRPayRollsInfo> payRollList = objPayRollsController.GetPayRollsForSalaryCalculation();
            guiFind<HRPayRollsInfo> guiFind = new guiFind<HRPayRollsInfo>(TableName.HRPayRollsTableName, payRollList, null, this);
            guiFind.GridControlName = "PayRoll";
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                int payRollID = Convert.ToInt32(guiFind.Tag);
                HRPayRollsInfo objPayRollsInfo = payRollList.Where(pr => pr.HRPayRollID == payRollID).FirstOrDefault();
                if (objPayRollsInfo != null)
                {
                    ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)CurrentModuleEntity.MainObject;
                    objSalaryCalculationsInfo.ACSalaryCalculationReference = objPayRollsInfo.HRPayRollNo;
                    entity.UpdateMainObjectBindingSource();
                    GenerateSalaryCalculationDetails();
                }
            }
            else
                base.ActionCancel();
        }

        public void GenerateSalaryCalculationDetails()
        {
            SalaryCalculationEntities entity = (SalaryCalculationEntities)CurrentModuleEntity;
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)entity.MainObject;

            BOSDbUtil dbUtil = new BOSDbUtil();
            if (Toolbar.IsNullOrNoneAction())
                return;

            ACSalaryDocumentTypesController objSalaryDocumentTypesController = new ACSalaryDocumentTypesController();
            List<ACSalaryDocumentTypesInfo> defaultSalaryDocumentTypeList = objSalaryDocumentTypesController.GetAllAliveSalaryDocumentTypes();

            ACSalaryDocumentTypePayRollDetailsController objSDTPRDsController = new ACSalaryDocumentTypePayRollDetailsController();
            HREmployeePayRollsController objEmployeePayrollsController = new HREmployeePayRollsController();
            ACSalaryEntryTypesController objSalaryEntryTypesController = new ACSalaryEntryTypesController();
            ACSalaryEntryTypeDetailPartsController objSETDPsController = new ACSalaryEntryTypeDetailPartsController();

            HRPayRollsController objPayrollsController = new HRPayRollsController();
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)objPayrollsController.GetObjectByNo(objSalaryCalculationsInfo.ACSalaryCalculationReference);

            if (objPayRollsInfo == null)
                return;

            foreach (ACSalaryDocumentTypesInfo defaultSalaryDocumentType in defaultSalaryDocumentTypeList)
            {
                List<ACSalaryDocumentTypePayRollDetailsInfo> detailList = objSDTPRDsController.GetListBySalaryDocumentTypeID(defaultSalaryDocumentType.ACSalaryDocumentTypeID);
                List<HREmployeePayRollsInfo> employeePayRolls = objEmployeePayrollsController.GetEmployeePayRollListForSalaryCalculationByPayRollID(objPayRollsInfo.HRPayRollID);
                List<ACSalaryEntryTypesInfo> salaryEntryTypes = objSalaryEntryTypesController.GetListSalaryEntryTypeBySalaryDocumentTypeID(defaultSalaryDocumentType.ACSalaryDocumentTypeID);
                decimal totalDocumentAmount = 0;

                foreach (ACSalaryEntryTypesInfo salaryEntryType in salaryEntryTypes)
                {
                    if (!defaultSalaryDocumentType.ACSalaryDocumentTypeTakeEmployee)
                    {
                        List<ACSalaryEntryTypeDetailPartsInfo> listSETDPs = objSETDPsController.GetListBySalaryEntryTypeID(salaryEntryType.ACSalaryEntryTypeID);
                        List<int> departmentIDs = listSETDPs.Where(s => s.FK_HRDepartmentID > 0).Select(s => s.FK_HRDepartmentID).ToList();
                        List<int> departmentRoomIDs = listSETDPs.Where(s => s.FK_HRDepartmentRoomID > 0).Select(s => s.FK_HRDepartmentRoomID).ToList();
                        List<int> levelIDs = listSETDPs.Where(s => s.FK_HRLevelID > 0).Select(s => s.FK_HRLevelID).ToList();

                        List<HREmployeePayRollsInfo> temp = employeePayRolls.Where(s => (departmentIDs.Count() == 0 || departmentIDs.Contains(s.FK_HRDepartmentID))
                                                                                    && (departmentRoomIDs.Count() == 0 || departmentRoomIDs.Contains(s.FK_HRDepartmentRoomID))
                                                                                    && (levelIDs.Count() == 0 || levelIDs.Contains(s.FK_HRLevelID))).ToList();

                        List<HREmployeePayRollsInfo> groupedPayrolls = new List<HREmployeePayRollsInfo>();

                        foreach (ACSalaryDocumentTypePayRollDetailsInfo detail in detailList)
                        {
                            HREmployeePayRollsInfo objEmployeePayRollsInfo;
                            temp.ForEach(t =>
                            {
                                objEmployeePayRollsInfo = new HREmployeePayRollsInfo();
                                //objEmployeePayRollsInfo.FK_BRBranchID = t.FK_BRBranchID;
                                objEmployeePayRollsInfo.FK_HRDepartmentID = t.FK_HRDepartmentID;
                                objEmployeePayRollsInfo.FK_HRDepartmentRoomID = t.FK_HRDepartmentRoomID;
                                if (detail.ACSalaryDocumentTypePayRollDetailCalculateType == CalculateType.Sub)
                                {
                                    //objEmployeePayRollsInfo.DetailAmount = -Convert.ToDecimal(dbUtil.GetPropertyValue(t, detail.ACSalaryDocumentTypePayRollDetailName));
                                }
                                else
                                {
                                    //objEmployeePayRollsInfo.DetailAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(t, detail.ACSalaryDocumentTypePayRollDetailName));
                                }
                                groupedPayrolls.Add(objEmployeePayRollsInfo);
                            });
                        }

                        if (!salaryEntryType.ACSalaryEntryTypeDetailIsGroupByBranch)
                        {
                            //groupedPayrolls.ForEach(pr => pr.FK_BRBranchID = 0);
                        }
                        if (!salaryEntryType.ACSalaryEntryTypeDetailIsGroupByDepartment)
                        {
                            groupedPayrolls.ForEach(pr => pr.FK_HRDepartmentID = 0);
                        }
                        if (!salaryEntryType.ACSalaryEntryTypeDetailIsGroupByDepartmentGroup)
                        {
                            groupedPayrolls.ForEach(pr => pr.FK_HRDepartmentRoomID = 0);
                        }
                        groupedPayrolls = groupedPayrolls.GroupBy(gp => new
                        {
                            //gp.FK_BRBranchID,
                            gp.FK_HRDepartmentID,
                            gp.FK_HRDepartmentRoomID,
                        })
                                            .Select(gp =>
                                                new HREmployeePayRollsInfo()
                                                {
                                                    //FK_BRBranchID = gp.Key.FK_BRBranchID,
                                                    FK_HRDepartmentID = gp.Key.FK_HRDepartmentID,
                                                    FK_HRDepartmentRoomID = gp.Key.FK_HRDepartmentRoomID,
                                                    //DetailAmount = gp.Sum(pr => pr.DetailAmount),
                                                })
                                            .ToList();
                        foreach (HREmployeePayRollsInfo pr in groupedPayrolls)
                        {
                            ACSalaryCalculationDetailsInfo objSalaryCalculationDetailsInfo = new ACSalaryCalculationDetailsInfo();
                            objSalaryCalculationDetailsInfo.FK_ACCreditAccountID = salaryEntryType.FK_ACCreditAccountID;
                            objSalaryCalculationDetailsInfo.FK_ACDebitAccountID = salaryEntryType.FK_ACDebitAccountID;
                            objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailDesc = salaryEntryType.ACSalaryEntryTypeDesc;
                            objSalaryCalculationDetailsInfo.FK_ACSalaryEntryTypeID = salaryEntryType.ACSalaryEntryTypeID;
                            objSalaryCalculationDetailsInfo.FK_ACCostCenterID = salaryEntryType.FK_ACCostCenterID;
                            objSalaryCalculationDetailsInfo.FK_ACSegmentID = salaryEntryType.FK_ACSegmentID;
                            //objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailAmount = pr.DetailAmount;
                            //objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailExchangeAmount = pr.DetailAmount;
                            objSalaryCalculationDetailsInfo.FK_GECurrencyID = objSalaryCalculationsInfo.FK_GECurrencyID;
                            objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailExchangeRate = objSalaryCalculationsInfo.ACSalaryCalculationExchangeRate;
                            if (objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailAmount != 0)
                                entity.SalaryCalculationDetailsList.Add(objSalaryCalculationDetailsInfo);
                            //totalDocumentAmount += pr.DetailAmount;
                        }
                    }
                    else
                    {
                        List<HREmployeePayRollsInfo> groupedPayrolls = new List<HREmployeePayRollsInfo>();

                        foreach (ACSalaryDocumentTypePayRollDetailsInfo detail in detailList)
                        {
                            HREmployeePayRollsInfo objEmployeePayRollsInfo;
                            employeePayRolls.ForEach(t =>
                            {
                                objEmployeePayRollsInfo = new HREmployeePayRollsInfo();
                                objEmployeePayRollsInfo.FK_HREmployeeID = t.FK_HREmployeeID;
                                if (detail.ACSalaryDocumentTypePayRollDetailCalculateType == CalculateType.Sub)
                                {
                                    //objEmployeePayRollsInfo.DetailAmount = -Convert.ToDecimal(dbUtil.GetPropertyValue(t, detail.ACSalaryDocumentTypePayRollDetailName));
                                }
                                else
                                {
                                    //objEmployeePayRollsInfo.DetailAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(t, detail.ACSalaryDocumentTypePayRollDetailName));
                                }
                                groupedPayrolls.Add(objEmployeePayRollsInfo);
                            });
                        }

                        groupedPayrolls = groupedPayrolls.GroupBy(gp => new
                        {
                            gp.FK_HREmployeeID
                        })
                                            .Select(gp =>
                                                new HREmployeePayRollsInfo()
                                                {
                                                    FK_HREmployeeID = gp.Key.FK_HREmployeeID,
                                                    //DetailAmount = gp.Sum(pr => pr.DetailAmount),
                                                })
                                            .ToList();

                        foreach (HREmployeePayRollsInfo pr in groupedPayrolls)
                        {
                            ACSalaryCalculationDetailsInfo objSalaryCalculationDetailsInfo = new ACSalaryCalculationDetailsInfo();
                            objSalaryCalculationDetailsInfo.FK_ACCreditAccountID = salaryEntryType.FK_ACCreditAccountID;
                            objSalaryCalculationDetailsInfo.FK_ACDebitAccountID = salaryEntryType.FK_ACDebitAccountID;
                            objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailDesc = salaryEntryType.ACSalaryEntryTypeDesc;
                            objSalaryCalculationDetailsInfo.FK_ACSalaryEntryTypeID = salaryEntryType.ACSalaryEntryTypeID;
                            objSalaryCalculationDetailsInfo.FK_ACCostCenterID = salaryEntryType.FK_ACCostCenterID;
                            objSalaryCalculationDetailsInfo.FK_ACSegmentID = salaryEntryType.FK_ACSegmentID;
                            //objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailAmount = pr.DetailAmount;
                            //objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailExchangeAmount = pr.DetailAmount;
                            objSalaryCalculationDetailsInfo.FK_GECurrencyID = objSalaryCalculationsInfo.FK_GECurrencyID;
                            objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailExchangeRate = objSalaryCalculationsInfo.ACSalaryCalculationExchangeRate;
                            if (objSalaryCalculationDetailsInfo.ACSalaryCalculationDetailAmount != 0)
                                entity.SalaryCalculationDetailsList.Add(objSalaryCalculationDetailsInfo);
                            //totalDocumentAmount += pr.DetailAmount;
                        }
                    }
                }
            }
            entity.SalaryCalculationDetailsList.GridControl.RefreshDataSource();
        }

        public void RemoveSelectedSalaryCalculationDocumentEntry()
        {
            SalaryCalculationEntities entity = (SalaryCalculationEntities)CurrentModuleEntity;
            entity.SalaryCalculationDetailsList.RemoveSelectedRowObjectFromList();
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            ActionPosted();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            SalaryCalculationEntities entity = (SalaryCalculationEntities)CurrentModuleEntity;
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)entity.MainObject;
            objSalaryCalculationsInfo.ACSalaryCalculationStatus = SalaryCalculationStatus.Posted.ToString();
            objSalaryCalculationsInfo.ACSalaryCalculationPostingDate = BOSApp.GetCurrentServerDate();
            objSalaryCalculationsInfo.IsPosted = true;
            string tableName = objSalaryCalculationsInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, objSalaryCalculationsInfo.ACSalaryCalculationID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, objSalaryCalculationsInfo.ACSalaryCalculationID, ModulePostingType.Accounting);

            //Update the reference payroll if the document has been created from it
            if (!string.IsNullOrEmpty(objSalaryCalculationsInfo.ACSalaryCalculationNo))
            {
                HRPayRollsController objPayRollsController = new HRPayRollsController();
                HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)objPayRollsController.GetObjectByNo(objSalaryCalculationsInfo.ACSalaryCalculationReference);
                if (objPayRollsInfo != null)
                {
                    objPayRollsInfo.HRPayRollStatus = PayRollStatus.Posted.ToString();
                    objPayRollsController.UpdateObject(objPayRollsInfo);
                }
            }
            //Update loan of advance request
            HRAdvanceRequestItemLoanDetailsController objARILDsController = new HRAdvanceRequestItemLoanDetailsController();
            objARILDsController.UpdatePaidForAdvanceRequestItems(objSalaryCalculationsInfo.ACSalaryCalculationReference);

            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            SalaryCalculationEntities entity = (SalaryCalculationEntities)CurrentModuleEntity;
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)entity.MainObject;
            objSalaryCalculationsInfo.ACSalaryCalculationStatus = SalaryCalculationStatus.UnPosted.ToString();
            objSalaryCalculationsInfo.IsPosted = false;
            string tableName = objSalaryCalculationsInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, objSalaryCalculationsInfo.ACSalaryCalculationID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, objSalaryCalculationsInfo.ACSalaryCalculationID, ModulePostingType.Accounting);
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public override void InvalidateToolbar()
        {
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            if (objSalaryCalculationsInfo.ACSalaryCalculationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit,
                            objSalaryCalculationsInfo.ACSalaryCalculationStatus != SalaryCalculationStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            objSalaryCalculationsInfo.ACSalaryCalculationStatus != SalaryCalculationStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                            objSalaryCalculationsInfo.ACSalaryCalculationStatus == SalaryCalculationStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }
    }
}
