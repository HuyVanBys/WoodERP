using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.IC.TransferProposal.Localization;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferProposal
{
    public class TransferProposalModule : BaseTransactionModule
    {
        #region Constant
        public const string ProposalItemGridControlName = "fld_dgcICTransferProposalItems";

        public const string ApprovedProposalButtonTag = "Approve";

        public const string CancelApprovedProposalButtonTag = "Discard";

        public const string ProductLookupEditControlName = "fld_lkeFK_ICProductID";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID1";
        #endregion
        #region Public properties
        public List<BRBranchsInfo> BranchList;

        public BOSLookupEdit ProductLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public BOSLookupEdit SearchBranchLookupEditControl;
        #endregion
        #region Constructor
        public TransferProposalModule()
        {
            Name = ModuleName.TransferProposal;
            CurrentModuleEntity = new TransferProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            ProductLookupEditControl = (BOSLookupEdit)Controls[ProductLookupEditControlName];
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[TransferProposalModule.SearchBranchLookupEditControlName];
            ICProductsController objProductsController = new ICProductsController();
            ProductLookupEditControl.Properties.DataSource = objProductsController.GetProductsDataSourceForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
            //ProductLookupEditControl.Properties.DataSource = objProductsController.GetProductsForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);  
        }
        #endregion
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateToolbar();
        }

        public override int ActionSave()
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo mainObject = (ICTransferProposalsInfo)entity.MainObject;
            if (mainObject.FK_ICFromStockID == 0 || mainObject.FK_ICToStockID == 0)
            {
                String err = String.Format(TransferProposalLocalizedResources.MainObjectStockIsEmpty, mainObject.FK_ICFromStockID == 0 ? TransferProposalLocalizedResources.FromStock : "", mainObject.FK_ICFromStockID == 0 && mainObject.FK_ICToStockID == 0 ? "," : "", mainObject.FK_ICToStockID == 0 ? TransferProposalLocalizedResources.ToStock : "");
                MessageBox.Show(err, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            string errorMessage = string.Join(", ", entity.TransferProposalItemList.Where(o => o.FK_ICToStockID == 0 || o.FK_ICFromStockID == 0)
                                                                                   .Select(o => o.ICTransferProposalItemProductNo).ToArray());
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(string.Format(TransferProposalLocalizedResources.ProductSerialNullErrorMessage, errorMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            //errorMessage = string.Join(", ", entity.TransferProposalItemList.Where(o=>o.FK_ICToStockID == 0)
            //                                                                       .Select(o => o.ICTransferProposalItemProductNo).ToArray());
            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    MessageBox.Show(string.Format(TransferProposalLocalizedResources.ToStockIsNull, errorMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return 0;
            //}
            return base.ActionSave();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;

            if (objTransferProposalsInfo.ICTransferProposalStatus == TransferProposalStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.ApprovedProposalButtonTag, true);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.CancelApprovedProposalButtonTag, false);
            }

            if (objTransferProposalsInfo.ICTransferProposalStatus == TransferProposalStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.ApprovedProposalButtonTag, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.CancelApprovedProposalButtonTag, true);
            }

            if (objTransferProposalsInfo.ICTransferProposalStatus == TransferProposalStatus.Completed.ToString()
                || objTransferProposalsInfo.ICTransferProposalStatus == TransferProposalStatus.Transferring.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.ApprovedProposalButtonTag, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.CancelApprovedProposalButtonTag, false);
            }

            if (objTransferProposalsInfo.ICTransferProposalStatus == TransferProposalStatus.CancelApproved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.ApprovedProposalButtonTag, false);
                ParentScreen.SetEnableOfToolbarButton(TransferProposalModule.CancelApprovedProposalButtonTag, false);
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void DeleteItemFromProposalItemList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
                entity.TransferProposalItemList.RemoveSelectedRowObjectFromList();
            }
        }

        public void ActionNewFromManual()
        {
            ActionNew();
        }

        public void ActionNewFromSaleOrder()
        {
            ActionNew();
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ARSaleOrderItemsController objSaleOrdersController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saleOrderList = objSaleOrdersController.GetARSaleOrderItemsFromTransferProposal(0, string.Empty, BOSUtil.GetMonthBeginDate(), BOSApp.GetCurrentServerDate());
            guiChooseSaleOrderItems guiFind = new guiChooseSaleOrderItems(saleOrderList);
            guiFind.Module = this;
            if (guiFind.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            saleOrderList = guiFind.SelectedObjects;
            List<ICTransferProposalItemsInfo> transferProposalItemList = new List<ICTransferProposalItemsInfo>();
            ICTransferProposalItemsInfo objTransferProposalItemsInfo = new ICTransferProposalItemsInfo();
            saleOrderList.ForEach(o =>
            {
                objTransferProposalItemsInfo = ToTransferProposalItemFromSaleOrderItem(o);
                transferProposalItemList.Add(objTransferProposalItemsInfo);
            });
            entity.TransferProposalItemList.Invalidate(transferProposalItemList);
            entity.TransferProposalItemList.GridControl.RefreshDataSource();
        }



        public ICTransferProposalItemsInfo ToTransferProposalItemFromSaleOrderItem(ARSaleOrderItemsInfo objSaleOrderItemsInfo)
        {
            return new ICTransferProposalItemsInfo()
            {
                FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID,
                FK_ICDepartmentID = objSaleOrderItemsInfo.FK_ICDepartmentID,
                FK_ICProductGroupID = objSaleOrderItemsInfo.FK_ICProductGroupID,
                FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID,
                FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID,
                ICTransferProposalItemProductNo = objSaleOrderItemsInfo.ARSaleOrderItemProductNo,
                ICTransferProposalItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc,
                ICTransferProposalItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName,
                ICTransferProposalItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty,
                ICTransferProposalItemProductDiscountPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount,
                ICTransferProposalItemProductDiscountAmount = objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount,
                ICTransferProposalItemProductTaxAmount = objSaleOrderItemsInfo.ARSaleOrderItemTaxAmount,
                ICTransferProposalItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent,
                ICTransferProposalItemProductType = objSaleOrderItemsInfo.ARSaleOrderItemProductType,
                ICTransferProposalItemProductUnitCost = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitCost,
                ICTransferProposalItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice,
                FK_ICProductAttributeColorID = objSaleOrderItemsInfo.FK_ICProductAttributeColorID,
                FK_ICProductAttributeWoodTypeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID,
                ICTransferProposalItemProductColorAttribute = objSaleOrderItemsInfo.ARSaleOrderItemProductColorAttribute,
                ICTransferProposalItemProductWoodAttribute = objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID,
                ICTransferProposalItemProductHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                ICTransferProposalItemProductWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                ICTransferProposalItemProductLength = objSaleOrderItemsInfo.ARSaleOrderItemLength
            };
        }

        public string GetAttributeText(string productAttributeRefence)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributeByProductAttributeReferenceByCharater(productAttributeRefence, ",");
            if (productAttributeList == null)
                productAttributeList = new List<ICProductAttributesInfo>();
            return string.Join(", ", productAttributeList.Select(o => o.ICProductAttributeNo).ToArray());
        }

        public void AddItemToTransferProposalItemsList()
        {
            ICProductsController objProductsController = new ICProductsController();
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
            ICTransferProposalItemsInfo objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)entity.ModuleObjects[TableName.ICTransferProposalItemsTableName];
            if (objTransferProposalItemsInfo.FK_ICProductID > 0)
            {
                ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(objTransferProposalItemsInfo.FK_ICProductID);
                if (components.Count > 0)
                {
                    foreach (ICProductComponentsInfo component in components)
                    {
                        objTransferProposalItemsInfo = new ICTransferProposalItemsInfo();
                        entity.SetDefaultValuesFromProduct(component.FK_ICProductComponentChildID, objTransferProposalItemsInfo);
                        objTransferProposalItemsInfo.ICTransferProposalItemProductQty = objTransferProposalItemsInfo.ICTransferProposalItemProductQty * component.ICProductComponentQty;
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objTransferProposalItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null) objTransferProposalItemsInfo.ICTransferProposalItemProductNo = objProductsInfo.ICProductNo;
                        objTransferProposalItemsInfo.ICTransferProposalItemValidDate = objTransferProposalsInfo.ICTransferProposalValidDate;
                        entity.TransferProposalItemList.Add(objTransferProposalItemsInfo);
                    }
                    entity.TransferProposalItemList.GridControl.RefreshDataSource();
                }
                else
                {
                    entity.SetDefaultValuesFromProduct(objTransferProposalItemsInfo.FK_ICProductID);
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objTransferProposalItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null) objTransferProposalItemsInfo.ICTransferProposalItemProductNo = objProductsInfo.ICProductNo;
                    objTransferProposalItemsInfo.ICTransferProposalItemValidDate = objTransferProposalsInfo.ICTransferProposalValidDate;
                    entity.TransferProposalItemList.AddObjectToList();
                }
            }
        }

        public void ChangeSourceStock(int stockID)
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
            if (!Toolbar.IsNullOrNoneAction())
            {
                objTransferProposalsInfo.FK_ICFromStockID = stockID;
                if (entity.TransferProposalItemList.Count > 0)
                {
                    if (MessageBox.Show(TransferProposalLocalizedResources.ConfirmChangeItemSourceStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICTransferProposalItemsInfo item in entity.TransferProposalItemList)
                        {
                            item.FK_ICFromStockID = stockID;
                        }
                        entity.TransferProposalItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public void ChangeTargetStock(int stockID)
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
            if (!Toolbar.IsNullOrNoneAction())
            {
                objTransferProposalsInfo.FK_ICToStockID = stockID;
                if (entity.TransferProposalItemList.Count > 0)
                {
                    if (MessageBox.Show(TransferProposalLocalizedResources.ConfirmChangeItemTargetStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICTransferProposalItemsInfo item in entity.TransferProposalItemList)
                        {
                            item.FK_ICToStockID = stockID;
                        }
                        entity.TransferProposalItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        public List<ICProductAttributesInfo> GetProductAttributeDatasource(string group)
        {
            List<ICProductAttributesInfo> woodTypeList = new List<ICProductAttributesInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            woodTypeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(group);
            ICProductAttributesInfo objProductAttributesDummyInfo = new ICProductAttributesInfo();
            woodTypeList.Insert(0, objProductAttributesDummyInfo);
            return woodTypeList;
        }

        public void InvalidateItemSerieNo(ICTransferProposalItemsInfo objTransferProposalItemsInfo)
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            objTransferProposalItemsInfo.ICTransferProposalItemProductSerialNo = string.Empty;
            objTransferProposalItemsInfo.FK_ICProductSerieID = 0;
            entity.TransferProposalItemList.GridControl.RefreshDataSource();
        }

        public void CheckValidateSerieNo(ICTransferProposalItemsInfo objTransferProposalItemsInfo)
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(objTransferProposalItemsInfo.FK_ICProductID, objTransferProposalItemsInfo.ICTransferProposalItemProductSerialNo);
            if (objProductSeriesInfo != null || objTransferProposalItemsInfo.ICTransferProposalItemProductSerialNo == string.Empty)
            {
                objTransferProposalItemsInfo.FK_ICProductSerieID = objProductSeriesInfo == null ? 0 : objProductSeriesInfo.ICProductSerieID;
                return;
            }
            MessageBox.Show(CommonLocalizedResources.SerialNoNotExistMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            objTransferProposalItemsInfo.ICTransferProposalItemProductSerialNo = string.Empty;
            objTransferProposalItemsInfo.FK_ICProductSerieID = 0;
            entity.TransferProposalItemList.GridControl.RefreshDataSource();
        }

        public void InvalidateSerieColumn(GridColumn column, ICTransferProposalItemsInfo objTransferProposalItemsInfo)
        {
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> productSerieList = objProductSeriesController.GetSeriesByProductIDAndStockID(objTransferProposalItemsInfo.FK_ICProductID, objTransferProposalItemsInfo.FK_ICFromStockID, objTransferProposalItemsInfo.ICTransferProposalItemProductDesc, objTransferProposalsInfo.ICTransferProposalDate);
            if (productSerieList.Count > 0)
            {
                productSerieList.Insert(0, new ICProductSeriesInfo());
            }
            RepositoryItemComboBox rep = new RepositoryItemComboBox();
            foreach (ICProductSeriesInfo serie in productSerieList)
            {
                rep.Items.Add(serie.ICProductSerieNo);
            }
            column.ColumnEdit = rep;
        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
                objTransferProposalsInfo.ICTransferProposalStatus = TransferProposalStatus.Approved.ToString();
                ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
                foreach (ICTransferProposalItemsInfo item in entity.TransferProposalItemList)
                {
                    item.ICTransferProposalItemStatus = TransferProposalStatus.Approved.ToString();
                    objTransferProposalItemsController.UpdateObject(item);
                }
                entity.UpdateMainObject();
                entity.TransferProposalItemList.GridControl.RefreshDataSource();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void ActionCancelApprove()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)entity.MainObject;
                objTransferProposalsInfo.ICTransferProposalStatus = TransferProposalStatus.CancelApproved.ToString();
                ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
                foreach (ICTransferProposalItemsInfo item in entity.TransferProposalItemList)
                {
                    item.ICTransferProposalItemStatus = TransferProposalStatus.CancelApproved.ToString();
                    objTransferProposalItemsController.UpdateObject(item);
                }
                entity.UpdateMainObject();
                entity.TransferProposalItemList.GridControl.RefreshDataSource();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICTransferProposalsController objTransferProposalsController = new ICTransferProposalsController();
            ICTransferProposalsInfo searchObject = (ICTransferProposalsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objTransferProposalsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objTransferProposalsController.GetSearchDataPermission(searchObject.ICTransferProposalNo
                                                                                , string.Join(",", BranchList.Select(o => o.BRBranchID.ToString()).ToArray())
                                                                                , searchObject.FK_HREmployeeID
                                                                                , searchObject.ICTransferProposalDateFrom
                                                                                , searchObject.ICTransferProposalDateTo);
                }
            }
            else
            {
                ds = objTransferProposalsController.GetSearchDataPermission(searchObject.ICTransferProposalNo
                                                                    , searchObject.FK_BRBranchID.ToString()
                                                                    , searchObject.FK_HREmployeeID
                                                                    , searchObject.ICTransferProposalDateFrom
                                                                    , searchObject.ICTransferProposalDateTo);
            }

            return ds;
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        public void ChangeTransferProposalValiDate()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                //if (DialogResult.Yes != MessageBox.Show(TransferProposalLocalizedResources.DoYouWantToApplyToItems,
                //                            CommonLocalizedResources.MessageBoxDefaultCaption,
                //                            MessageBoxButtons.YesNo,
                //                            MessageBoxIcon.Question))
                //    return;
                TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
                ICTransferProposalsInfo mainObject = (ICTransferProposalsInfo)entity.MainObject;
                entity.TransferProposalItemList.ForEach(p => p.ICTransferProposalItemValidDate = mainObject.ICTransferProposalValidDate);
                entity.TransferProposalItemList.GridControl.RefreshDataSource();
            }
        }

        public void ActionPrintA4()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPTransferProposals report = new RPTransferProposals();
                InitRPTransferProposalsA4Report(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        private void InitRPTransferProposalsA4Report(RPTransferProposals report)
        {
            string creditNos = string.Empty;
            string debitNos = string.Empty;
            TransferProposalEntities entity = (TransferProposalEntities)CurrentModuleEntity;
            ICTransferProposalsInfo mainobject = (ICTransferProposalsInfo)entity.MainObject;
            ICTransferProposalsController objTransferProposalsController = new ICTransferProposalsController();
            ICTransferProposalsInfo objTransferProposalsInfo = objTransferProposalsController.GetTransferProposalForReportByTransferProposalID(mainobject.ICTransferProposalID);
            report.bsICTransferProposals.DataSource = objTransferProposalsInfo;
            ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
            List<ICTransferProposalItemsInfo> TransferProposalItemList = objTransferProposalItemsController.GetTransferProposalItemForReportByTransferProposalID(mainobject.ICTransferProposalID);
            report.bsICTransferProposalItems.DataSource = TransferProposalItemList;

            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo;
            foreach (ACDocumentEntrysInfo documentEntrysInfo in (BOSList<ACDocumentEntrysInfo>)entity.DocumentEntryList)
            {
                if (documentEntrysInfo.FK_ACCreditAccountID != null && documentEntrysInfo.FK_ACCreditAccountID != 0)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(documentEntrysInfo.FK_ACCreditAccountID);
                    if (objAccountsInfo != null && !string.IsNullOrEmpty(objAccountsInfo.ACAccountNo))
                    {
                        if (string.IsNullOrEmpty(creditNos)) creditNos = objAccountsInfo.ACAccountNo;
                        else creditNos = string.Format("{0}, {1}", creditNos, objAccountsInfo.ACAccountNo);
                    }
                }
                if (documentEntrysInfo.FK_ACDebitAccountID != null && documentEntrysInfo.FK_ACDebitAccountID != 0)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(documentEntrysInfo.FK_ACDebitAccountID);
                    if (objAccountsInfo != null && !string.IsNullOrEmpty(objAccountsInfo.ACAccountNo))
                    {
                        if (string.IsNullOrEmpty(debitNos)) debitNos = objAccountsInfo.ACAccountNo;
                        else debitNos = string.Format("{0}, {1}", debitNos, objAccountsInfo.ACAccountNo);
                    }
                }
            }

            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTransferToDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text
                                           , BOSApp.GetCurrentServerDate().Day
                                           , BOSApp.GetCurrentServerDate().Month
                                           , BOSApp.GetCurrentServerDate().Year);
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTransferDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text
                                           , mainobject.ICTransferProposalDate.Day
                                           , mainobject.ICTransferProposalDate.Month
                                           , mainobject.ICTransferProposalDate.Year);
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTransferNo"];
            if (label != null)
            {
                label.Text = string.Format("Số: " + mainobject.ICTransferProposalNo);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccount"];
            if (label != null)
            {
                label.Text = string.Format("Có: {0}", creditNos);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccount"];
            if (label != null)
            {
                label.Text = string.Format("Nợ: {0}", debitNos);
            }
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
                }
            }
        }
    }
}