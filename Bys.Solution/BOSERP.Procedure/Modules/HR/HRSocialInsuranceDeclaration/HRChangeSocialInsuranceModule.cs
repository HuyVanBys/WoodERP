using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration
{
    public class HRSocialInsuranceDeclarationModule : BaseTransactionModule
    {
        #region Constants
        /// <summary>
        /// The employee time sheet gird control name
        /// </summary>
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string SocialInsuranceDeclarationItemsGridControlName = "fld_dgcHRSocialInsuranceDeclarationItems";
        public const string TabControlName = "TabControl1";

        public DevExpress.XtraTab.XtraTabControl TabControlEdit;
        #endregion
        #region Public Properties
        #endregion

        public HRSocialInsuranceDeclarationModule()
        {
            Name = "HRSocialInsuranceDeclaration";
            CurrentModuleEntity = new HRSocialInsuranceDeclarationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            TabControlEdit = (DevExpress.XtraTab.XtraTabControl)Controls[HRSocialInsuranceDeclarationModule.TabControlName];
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRSocialInsuranceDeclarationsController objSocialInsuranceDeclarationsController = new HRSocialInsuranceDeclarationsController();
            HRSocialInsuranceDeclarationsInfo searchObject = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();

            ds = objSocialInsuranceDeclarationsController.GetSocialInsuranceDeclarationList(searchObject.HRSocialInsuranceDeclarationNo,
                                                            searchObject.HRSocialInsuranceDeclarationName,
                                                            searchObject.HRSocialInsuranceDeclarationType,
                                                            searchObject.HRSocialInsuranceDeclarationDateFrom,
                                                            searchObject.HRSocialInsuranceDeclarationDateTo);
            return ds;
        }

        public override void InvalidateToolbar()
        {
            HRSocialInsuranceDeclarationsInfo timeSheet = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (timeSheet.HRSocialInsuranceDeclarationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);

                if (timeSheet.HRSocialInsuranceDeclarationStatus == TimeSheetStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            CheckVisiblePage();
        }

        public void CheckVisiblePage()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;

            XtraTabPage tabPage = TabControlEdit.TabPages[0];
            XtraTabPage tabPage2 = TabControlEdit.TabPages[1];
            XtraTabPage tabPage3 = TabControlEdit.TabPages[2];

            if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
            {
                tabPage.PageVisible = false;
                tabPage2.PageVisible = true;
                tabPage3.PageVisible = false;
            }
            else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Arrears.ToString())
            {
                tabPage.PageVisible = false;
                tabPage2.PageVisible = false;
                tabPage3.PageVisible = true;
            }
            else
            {
                tabPage.PageVisible = true;
                tabPage2.PageVisible = false;
                tabPage3.PageVisible = false;
            }
        }

        public void ActionNewIncrease()
        {
            ActionNew();
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            mainObject.HRSocialInsuranceDeclarationType = SocialInsuranceDeclarationType.Increase.ToString();
            CheckVisiblePage();
        }

        public void ActionNewReduction()
        {
            ActionNew();
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            mainObject.HRSocialInsuranceDeclarationType = SocialInsuranceDeclarationType.Reduction.ToString();
            CheckVisiblePage();
        }

        public void ActionNewArrears()
        {
            ActionNew();
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            mainObject.HRSocialInsuranceDeclarationType = SocialInsuranceDeclarationType.Arrears.ToString();
            CheckVisiblePage();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            if (entity.SocialInsuranceDeclarationItemList != null)
            {
                entity.SocialInsuranceDeclarationItemList.Clear();
            }
        }

        public override int ActionSave()
        {
            return base.ActionSave();
        }

        public void AddEmployeeToItem()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.MainObject;
            try
            {
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    guiEmployee.SelectedEmployeeList.ForEach(o =>
                    {
                        if (!entity.SocialInsuranceDeclarationItemList.Exists(x => x.FK_HREmployeeID == o.HREmployeeID))
                        {
                            HRSocialInsuranceDeclarationItemsInfo objSocialInsuranceDeclarationItemsInfo = entity.GenerateSocialInsuranceDeclarationItem(o, mainObject);
                            entity.SocialInsuranceDeclarationItemList.Add(objSocialInsuranceDeclarationItemsInfo);
                        }
                    });
                    if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Increase.ToString())
                    {
                        entity.IncreaseSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                        entity.IncreaseSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                    }
                    else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
                    {
                        entity.ReductionSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                        entity.ReductionSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                    }
                    else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Arrears.ToString())
                    {
                        entity.ArrearsSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                        entity.ArrearsSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            catch (Exception e) { }
        }

        public void AddItem(List<HREmployeesInfo> list)
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.MainObject;
            if (list.Count() > 0)
            {
                list.ForEach(o =>
                {
                    if (!entity.SocialInsuranceDeclarationItemList.Exists(x => x.FK_HREmployeeID == o.HREmployeeID))
                    {
                        HRSocialInsuranceDeclarationItemsInfo objSocialInsuranceDeclarationItemsInfo = entity.GenerateSocialInsuranceDeclarationItem(o, mainObject);
                        entity.SocialInsuranceDeclarationItemList.Add(objSocialInsuranceDeclarationItemsInfo);
                    }
                });
                if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Increase.ToString())
                {
                    entity.IncreaseSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                    entity.IncreaseSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                }
                else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
                {
                    entity.ReductionSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                    entity.ReductionSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                }
                else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Arrears.ToString())
                {
                    entity.ArrearsSocialInsuranceDeclarationItemList.Invalidate(entity.SocialInsuranceDeclarationItemList);
                    entity.ArrearsSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
                }
            }
        }

        public void RemoveSocialInsuranceDeclarationItemFromList()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.SocialInsuranceDeclarationItemList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.SocialInsuranceDeclarationItemList.RemoveAt(index);
                entity.IncreaseSocialInsuranceDeclarationItemList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void RemoveReductionSocialInsuranceDeclarationItemFromList()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.ReductionSocialInsuranceDeclarationItemList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.SocialInsuranceDeclarationItemList.RemoveAt(index);
                entity.ReductionSocialInsuranceDeclarationItemList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void RemoveArrearsSocialInsuranceDeclarationItemFromList()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.ArrearsSocialInsuranceDeclarationItemList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.SocialInsuranceDeclarationItemList.RemoveAt(index);
                entity.ArrearsSocialInsuranceDeclarationItemList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void UpdateTyLeDong(HRSocialInsuranceDeclarationItemsInfo objSocialInsuranceDeclarationItemsInfo)
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();

            objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong = 0;

            ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
            ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();
            if (objInsurrancesInfo != null)
            {
                string[] paramNumbers = objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemObject.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < paramNumbers.Length; j++)
                {
                    if (!string.IsNullOrEmpty(paramNumbers[j].Trim()))
                    {
                        objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("SocialInsuranceDeclarationItemObject", paramNumbers[j].Trim());
                        if (objConfigValuesInfo != null)
                        {
                            if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHTN.ToString())
                            {
                                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong +=
                                    objInsurrancesInfo.HRInsurranceOutOfWorkInsPercent + objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentDN;
                            }
                            //else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHTNLĐ.ToString())
                            //{
                            //    objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong +=
                            //        objInsurrancesInfo.HRInsurranceIndustrialAccidentPercent + objInsurrancesInfo.HRInsurranceIndustrialAccidentPercentDN;
                            //}
                            else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHXH.ToString())
                            {
                                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong +=
                                    objInsurrancesInfo.HRInsurranceSocialInsPercent + objInsurrancesInfo.HRInsurranceSocialInsPercentDN;
                            }
                            else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHYT.ToString())
                            {
                                objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong +=
                                    objInsurrancesInfo.HRInsurranceHealthInsPercent + objInsurrancesInfo.HRInsurranceHealthInsPercentDN;
                            }
                            //else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BNN.ToString())
                            //{
                            //    objSocialInsuranceDeclarationItemsInfo.HRSocialInsuranceDeclarationItemTyLeDong +=
                            //        objInsurrancesInfo.HRInsurranceIndustrialDiseasePercent + objInsurrancesInfo.HRInsurranceIndustrialDiseasePercentDN;
                            //}
                        }
                    }
                }
            }

            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Increase.ToString())
            {
                entity.SocialInsuranceDeclarationItemList.Invalidate(entity.IncreaseSocialInsuranceDeclarationItemList);
                entity.IncreaseSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
            }
            else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Reduction.ToString())
            {
                entity.SocialInsuranceDeclarationItemList.Invalidate(entity.ReductionSocialInsuranceDeclarationItemList);
                entity.ReductionSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
            }
            else if (mainObject.HRSocialInsuranceDeclarationType == SocialInsuranceDeclarationType.Arrears.ToString())
            {
                entity.SocialInsuranceDeclarationItemList.Invalidate(entity.ArrearsSocialInsuranceDeclarationItemList);
                entity.ArrearsSocialInsuranceDeclarationItemList.GridControl.RefreshDataSource();
            }
        }

        public void Approve()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo mainObject = (HRSocialInsuranceDeclarationsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.HRSocialInsuranceDeclarationStatus = SocialInsuranceDeclarationStatus.Approved.ToString();
            entity.UpdateMainObject();

            if (entity.SocialInsuranceDeclarationItemList.Count > 0)
            {
                ADInsurrancePlansController objInsurrancePlansController = new ADInsurrancePlansController();
                ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
                ADInsurrancesInfo objInsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();

                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();

                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                entity.SocialInsuranceDeclarationItemList.ForEach(o =>
                {
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetEmployeeByID(o.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        ADInsurrancePlansInfo objInsurrancePlansInfo = (ADInsurrancePlansInfo)objInsurrancePlansController.GetObjectByID(o.FK_ADInsurrancePlanID);
                        if (objInsurrancePlansInfo != null && objInsurrancePlansInfo.ADInsurrancePlanIsUnCheckBHXH)
                        {
                            objEmployeesInfo.HREmployeeHaveInsurrance = false;
                        }
                        else
                        {
                            objEmployeesInfo.HREmployeeHaveInsurrance = true;
                        }

                        if (objInsurrancesInfo != null)
                        {
                            string[] paramNumbers = o.HRSocialInsuranceDeclarationItemObject.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < paramNumbers.Length; j++)
                            {
                                if (!string.IsNullOrEmpty(paramNumbers[j].Trim()))
                                {
                                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("SocialInsuranceDeclarationItemObject", paramNumbers[j].Trim());
                                    if (objConfigValuesInfo != null)
                                    {
                                        if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHTN.ToString())
                                        {
                                            //objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercentDN = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercentDN;
                                            objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent = objInsurrancesInfo.HRInsurranceOutOfWorkInsPercent;
                                        }
                                        //else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHTNLĐ.ToString())
                                        //{
                                        //    objEmployeesInfo.HREmployeeIndustrialAccidentPercent = objInsurrancesInfo.HRInsurranceIndustrialAccidentPercent;
                                        //    objEmployeesInfo.HREmployeeIndustrialAccidentPercentDN = objInsurrancesInfo.HRInsurranceIndustrialAccidentPercentDN;
                                        //}
                                        else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHXH.ToString())
                                        {
                                            objEmployeesInfo.HREmployeeSocialInsPaymentPercent = objInsurrancesInfo.HRInsurranceSocialInsPercent;
                                            //objEmployeesInfo.HREmployeeSocialInsPaymentPercentDN = objInsurrancesInfo.HRInsurranceSocialInsPercentDN;
                                        }
                                        else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BHYT.ToString())
                                        {
                                            objEmployeesInfo.HREmployeeHealthInsPaymentPercent = objInsurrancesInfo.HRInsurranceHealthInsPercent;
                                            //objEmployeesInfo.HREmployeeHealthInsPaymentPercentDN = objInsurrancesInfo.HRInsurranceHealthInsPercentDN;
                                        }
                                        //else if (objConfigValuesInfo.ADConfigKeyValue == SocialInsuranceDeclarationItemObject.BNN.ToString())
                                        //{
                                        //    objEmployeesInfo.HREmployeeIndustrialDiseasePercent = objInsurrancesInfo.HRInsurranceIndustrialDiseasePercent;
                                        //    objEmployeesInfo.HREmployeeIndustrialDiseasePercentDN = objInsurrancesInfo.HRInsurranceIndustrialDiseasePercentDN;
                                        //}
                                    }
                                }
                            }
                        }
                        objEmployeesInfo.HREmployeeContractSlrAmt = o.HRSocialInsuranceDeclarationItemMucLuongBHXH;
                        //objEmployeesInfo.HREmployeeSocialInsPaymentAmount = objEmployeesInfo.HREmployeeSocialInsPaymentPercent * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeHealthInsPaymentAmount = objEmployeesInfo.HREmployeeHealthInsPaymentPercent * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeOutOfWorkInsPaymentAmount = objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeSocialInsPaymentAmountDN = objEmployeesInfo.HREmployeeSocialInsPaymentPercentDN * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeHealthInsPaymentAmountDN = objEmployeesInfo.HREmployeeHealthInsPaymentPercentDN * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeOutOfWorkInsPaymentAmountDN = objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercentDN * objEmployeesInfo.HREmployeeContractSlrAmt / 100;

                        //objEmployeesInfo.HREmployeeIndustrialAccidentAmount = objEmployeesInfo.HREmployeeIndustrialAccidentPercent * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeIndustrialDiseaseAmount = objEmployeesInfo.HREmployeeIndustrialDiseasePercent * objEmployeesInfo.HREmployeeContractSlrAmt / 100;

                        //objEmployeesInfo.HREmployeeIndustrialDiseaseAmountDN = objEmployeesInfo.HREmployeeIndustrialDiseasePercentDN * objEmployeesInfo.HREmployeeContractSlrAmt / 100;
                        //objEmployeesInfo.HREmployeeIndustrialAccidentAmountDN = objEmployeesInfo.HREmployeeIndustrialAccidentPercentDN * objEmployeesInfo.HREmployeeContractSlrAmt / 100;

                        //objEmployeesInfo.HREmployeeInsPaymentTotalAmount = objEmployeesInfo.HREmployeeSocialInsPaymentAmount
                        //                                                    + objEmployeesInfo.HREmployeeHealthInsPaymentAmount
                        //                                                    + objEmployeesInfo.HREmployeeOutOfWorkInsPaymentAmount
                        //                                                    + objEmployeesInfo.HREmployeeIndustrialAccidentAmount
                        //                                                    + objEmployeesInfo.HREmployeeIndustrialDiseaseAmount;
                        //objEmployeesInfo.HREmployeeInsPaymentTotalAmountDN = objEmployeesInfo.HREmployeeSocialInsPaymentAmountDN
                        //                                                    + objEmployeesInfo.HREmployeeHealthInsPaymentAmountDN
                        //                                                    + objEmployeesInfo.HREmployeeOutOfWorkInsPaymentAmountDN
                        //                                                    + objEmployeesInfo.HREmployeeIndustrialDiseaseAmountDN
                        //                                                    + objEmployeesInfo.HREmployeeIndustrialAccidentAmountDN;
                        objEmployeesController.UpdateObject(objEmployeesInfo);
                    }
                });
            }

            MessageBox.Show("Cập nhật nhân viên đã hoàn tất!",
                                                            CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            InvalidateToolbar();
        }

        public override void CallFunctionFromAnotherProject(IList selected, string ActionType)
        {
            base.CallFunctionFromAnotherProject(selected, ActionType);
            if (ActionType == SocialInsuranceDeclarationType.Increase.ToString())
            {
                ActionNewIncrease();
            }
            else if (ActionType == SocialInsuranceDeclarationType.Reduction.ToString())
            {
                ActionNewReduction();
            }
            List<HREmployeesInfo> list = (List<HREmployeesInfo>)selected;
            AddItem(list);
        }
    }
}
