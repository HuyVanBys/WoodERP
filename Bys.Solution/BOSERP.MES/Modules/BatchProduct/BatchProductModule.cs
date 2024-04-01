using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.BatchProduct.Localization;
using BOSERP.Modules.BatchProduct.UI;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BOSERP.Modules.BatchProduct
{
    public class BatchProductModule : BaseTransactionModule
    {
        #region Constants

        private const string fld_tabSemiProductName = "fld_tabSemiProduct";
        private const string fld_tabHardwareName = "fld_tabHardware";
        private const string fld_tabGeneralMaterial = "fld_tbGeneralMaterial";
        private const string fld_tabPaintName = "fld_tabPaint";
        private const string fld_tabPackagingName = "fld_tabPackaging";
        public const string TabControlName = "fld_tabProductionNorm";
        public const string BatchProductItemGridControlName = "fld_dgcMMBatchProductItems";
        public const string BPOperationDepartmentName = "fld_dgcMMBPOperationDepartments";
        public const string SumGoM3ControlName = "fld_lkeSumGoM3";
        public BOSLookupEdit ProductionPlanningIDLookupEdit;
        #endregion Constants

        #region Private Properties


        #endregion Private Properties

        #region public properties
        public BOSTabControl TabControl = null;
        public bool HaveFocusWood = false;
        public bool HaveFocusPackaging = false;
        public bool HaveFocusHardware = false;
        public bool HaveFocusGeneralMaterial = false;
        public bool HaveFocusPaint = false;
        public bool releaseTime = false;
        public MMBatchProductItemsGridControl BatchProductItemGridControl;
        public GridControl BPOperationDepartmentGridControl;
        public TextEdit SumGoM3Control;
        #endregion

        public DataTable OperationDataTable;
        List<int> OperationIDList;
        public List<BRBranchsInfo> BranchList;
        #region Public methods

        public BatchProductModule()
        {
            Name = ModuleName.BatchProduct;
            CurrentModuleEntity = new BatchProductEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            EnableToolbar();

            TabControl = (BOSTabControl)Controls[TabControlName];
            BatchProductItemGridControl = (MMBatchProductItemsGridControl)Controls[BatchProductItemGridControlName];
            BPOperationDepartmentGridControl = (GridControl)Controls[BPOperationDepartmentName];
            ProductionPlanningIDLookupEdit = (BOSLookupEdit)Controls["fld_lkeFK_ARProductionPlanningID"];
            SumGoM3Control = (TextEdit)Controls[SumGoM3ControlName];
            BOSApp.InvalidateProductList();
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

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo searchObject = (MMBatchProductsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objBatchProductsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objBatchProductsController.GetBatchProductForBatchProductOfBranchList(searchObject.MMBatchProductNo
                                                                                               , searchObject.FK_HREmployeeID
                                                                                               , objObjectsInfo.ACObjectID
                                                                                               , objObjectsInfo.ACObjectType
                                                                                               , searchObject.FK_ARSaleOrderID
                                                                                               , searchObject.FK_MMWorkShopID
                                                                                               , searchObject.MMBatchProductStatus
                                                                                               , searchObject.BatchProductDateFrom
                                                                                               , searchObject.BatchProductDateTo
                                                                                               , BranchList);
                }
            }
            else
            {
                ds = objBatchProductsController.GetBatchProductForBranch(searchObject.MMBatchProductNo
                                                                         , searchObject.FK_HREmployeeID
                                                                         , objObjectsInfo.ACObjectID
                                                                         , objObjectsInfo.ACObjectType
                                                                         , searchObject.FK_ARSaleOrderID
                                                                         , searchObject.FK_MMWorkShopID
                                                                         , searchObject.MMBatchProductStatus
                                                                         , searchObject.BatchProductDateFrom
                                                                         , searchObject.BatchProductDateTo
                                                                         , searchObject.FK_BRBranchID);
            }
            return ds;
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            EnableToolbar();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACObjectAccessKey = string.Format("{0};{1}", mainObject.FK_ACObjectID, mainObject.MMObjectType);
            HaveFocusHardware = false;
            HaveFocusGeneralMaterial = false;
            HaveFocusPackaging = false;
            HaveFocusPaint = false;
            HaveFocusWood = false;
            DisplayLabelText(mainObject);
            entity.UpdateMainObjectBindingSource();

            if (entity.ProductionNormItemHardwareList != null && entity.ProductionNormItemHardwareList.Count > 0)
            {
                entity.ProductionNormItemHardwareList.Clear();
                entity.RefreshTreeView(entity.ProductionNormItemHardwareList);
            }
            if (entity.ProductionNormItemGeneralMaterialList != null && entity.ProductionNormItemGeneralMaterialList.Count > 0)
            {
                entity.ProductionNormItemGeneralMaterialList.Clear();
                entity.RefreshTreeView(entity.ProductionNormItemGeneralMaterialList);
            }
            if (entity.ProductionNormItemPackagingList != null && entity.ProductionNormItemPackagingList.Count > 0)
            {
                entity.ProductionNormItemPackagingList.Clear();
                entity.RefreshTreeView(entity.ProductionNormItemPackagingList);
            }
            if (entity.ProductionNormItemPaintList != null && entity.ProductionNormItemPaintList.Count > 0)
            {
                entity.ProductionNormItemPaintList.Clear();
                entity.RefreshTreeView(entity.ProductionNormItemPaintList);
            }
            if (entity.BatchProductProductionNormItemList != null && entity.BatchProductProductionNormItemList.Count > 0)
            {
                entity.BatchProductProductionNormItemList.Clear();
                entity.RefreshTreeView(entity.BatchProductProductionNormItemList);
            }

            if (TabControl != null)
            {
                RefreshTreeView(TabControl.SelectedTabPage.Name);
            }
        }

        public override void ActivateScreen(string screenNumber, bool isRefeshDataControl = false)
        {
            isRefeshDataControl = true;
            base.ActivateScreen(screenNumber, isRefeshDataControl);
        }
        public bool CheckDuplicateBOM()
        {
            bool result = true;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            entity.BatchProductItemList.ForEach(b =>
            {
                List<MMBatchProductItemsInfo> countExit = entity.BatchProductItemList.Where(o => o.FK_MMProductionNormID == b.FK_MMProductionNormID
                                                            && o.FK_ICProductID != b.FK_ICProductID
                                                            && b.FK_MMProductionNormID > 0
                                                            ).ToList();
                if (countExit.Count() > 0) result = false;
                return;
            });
            if (!result)
            {
                MessageBox.Show("Danh sách bảng định mức đang chọn bị trùng, vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public override int ActionSave()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)entity.MainObject;
            entity.BatchProductItemList.EndCurrentEdit();

            if (mainobject.FK_MMWorkShopID == 0)
            {
                MessageBox.Show("Vui lòng chọn Xưởng để sản xuất lệnh này!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (!IsValidWorkShop())
                return 0;

            if (!CheckDuplicateBOM())
                return 0;
            CheckDeliveryDate(mainobject.MMBatchProductDeliveryDate, true);
            if (!CheckSORemainQuantity(null)) return 0;
            RoundQty();
            return base.ActionSave();
        }

        public bool IsValidWorkShop()
        {
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (mainobject.FK_MMWorkShopID == 0)
            {
                MessageBox.Show("Vui lòng chọn Xưởng để sản xuất lệnh này!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool IsExistProductionNorm()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)entity.MainObject;
            int countBOM = entity.BatchProductItemList.Where(o => o.FK_MMProductionNormID == 0).Count();
            if (countBOM == 0)
                return true;

            MessageBox.Show("Vui lòng xác định Bảng định mức cho tất cả sản phẩm", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            return false;
        }

        public void RoundQty()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemPaintList != null && entity.ProductionNormItemPaintList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
                {
                    item.MMBatchProductProductionNormItemQuantity = Math.Round(item.MMBatchProductProductionNormItemQuantity, 5, MidpointRounding.AwayFromZero);
                    if (item.SubList != null && item.SubList.Count > 0)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo in item.SubList)
                        {
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity, 5, MidpointRounding.AwayFromZero);
                        }
                    }

                }
            }
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            }
        }

        public void EnableToolbar()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            string status = objBatchProductsInfo.MMBatchProductStatus;

            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProduct", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductWood", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductHW", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPaint", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPackaging", false);
            ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductGeneralMaterial", false);

            ParentScreen.SetEnableOfToolbarButton("ValidateBatchProduct", false);
            ParentScreen.SetEnableOfToolbarButton("ValidateWood", false);
            ParentScreen.SetEnableOfToolbarButton("ValidateHardware", false);
            ParentScreen.SetEnableOfToolbarButton("ValidatePaint", false);
            ParentScreen.SetEnableOfToolbarButton("ValidatePackaging", false);
            ParentScreen.SetEnableOfToolbarButton("ValidateGeneralMaterial", false);

            ParentScreen.SetEnableOfToolbarButton("ExportTemplateCNC", false);
            ParentScreen.SetEnableOfToolbarButton("CloseBatchProduct", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);

            if (status == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateBatchProduct", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProduct", false);
            }

            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateWood", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductWood", false);
            }
            else if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateWood", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductWood", true);
            }

            if (objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateHardware", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductHW", false);
            }
            else if (objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateHardware", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductHW", true);
            }

            if (objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidatePaint", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPaint", false);
            }
            else if (objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidatePaint", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPaint", true);
            }

            if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidatePackaging", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPackaging", false);
            }
            else if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidatePackaging", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductPackaging", true);
            }

            if (objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateGeneralMaterial", true);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductGeneralMaterial", false);
            }
            else if (objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateGeneralMaterial", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProductGeneralMaterial", true);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.New.ToString()
                || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.New.ToString()
                || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.New.ToString()
                || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.New.ToString()
                || objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateBatchProduct", true);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Verified.ToString()
                || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Verified.ToString()
                || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString()
                || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString()
                || objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProduct", true);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Verified.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ValidateBatchProduct", false);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString()
                && objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Approved.ToString()
                && objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Approved.ToString()
                && objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Approved.ToString()
                && objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProduct", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Approved.ToString()
                || objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Closed.ToString()
                || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Closed.ToString()
                || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Closed.ToString()
                || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Closed.ToString()
                || objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Closed.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("CloseBatchProduct", true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            }
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("ExportTemplateCNC", true);
            }
            if (status == BatchProductStatus.Closed.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("CloseBatchProduct", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ValidateBatchProduct", false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchProduct", false);
            }
        }

        public void UpdateProposalBatchStatus()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            //Update Proposal batch status
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            MMProposalsController objProposalsController = new MMProposalsController();
            MMProposalsInfo objProposalsInfo = new MMProposalsInfo();
            List<MMProposalItemsInfo> ProposalItemList = null;
            if (objBatchProductsInfo.FK_MMProposalID > 0)
            {
                DataSet ds = objProposalItemsController.GetAllDataByForeignColumn("FK_MMProposalID", objBatchProductsInfo.FK_MMProposalID);
                if (ds != null && ds.Tables.Count > 0)
                {
                    ProposalItemList = (List<MMProposalItemsInfo>)objProposalItemsController.GetListFromDataSet(ds);
                }

                bool isFullBatchProduct = true;
                bool isFullBatchProductApproved = true;
                bool isFullBatchProductCanceled = true;
                bool isFullBatchProductCompleted = true;
                foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                {
                    //Update Proposal item
                    if (ProposalItemList != null && ProposalItemList.Count > 0)
                    {
                        foreach (MMProposalItemsInfo ProposalItem in ProposalItemList)
                        {

                            if (item.FK_MMProposalItemID == ProposalItem.MMProposalItemID)
                            {
                                if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.New.ToString())
                                    ProposalItem.MMProposalItemStatus = BatchProposalItemStatus.InProcess.ToString();
                                else if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Approved.ToString()
                                    || objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString()
                                    || objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Approved.ToString()
                                    || objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Approved.ToString()
                                    || objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Approved.ToString()
                                    | objBatchProductsInfo.MMBatchProductOperationStatus == BatchProductStatus.Approved.ToString())
                                {
                                    ProposalItem.MMProposalItemStatus = BatchProposalItemStatus.Completed.ToString();
                                    //ProposalItem.MMProposalItemProductLotNo = item.MMBatchProductItemProductSerial;

                                }
                                else if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Canceled.ToString())
                                {
                                    ProposalItem.MMProposalItemStatus = BatchProposalItemStatus.New.ToString();
                                }
                                else if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Complete.ToString())
                                {
                                    ProposalItem.MMProposalItemStatus = BatchProposalItemStatus.Completed.ToString();
                                }

                                objProposalItemsController.UpdateObject(ProposalItem);
                                //UpdateInvoiceItemStatusAndLotNo(item.MMBatchProductItemProductSerial, item.MMBatchProductItemProductDesc, ProposalItem.FK_ARInvoiceItemID);
                            }
                        }
                    }
                }

                foreach (MMProposalItemsInfo ProposalItem in ProposalItemList)
                {
                    if (ProposalItem.MMProposalItemStatus != BatchProposalItemStatus.InProcess.ToString())
                    {
                        isFullBatchProduct = false;
                    }
                    if (ProposalItem.MMProposalItemStatus != BatchProposalItemStatus.Processed.ToString())
                    {
                        isFullBatchProductApproved = false;
                    }
                    if (ProposalItem.MMProposalItemStatus != BatchProposalItemStatus.Cancel.ToString())
                    {
                        isFullBatchProductCanceled = false;
                    }
                    if (ProposalItem.MMProposalItemStatus != BatchProposalItemStatus.Completed.ToString())
                    {
                        isFullBatchProductCompleted = false;
                    }
                }
                objProposalsInfo = (MMProposalsInfo)objProposalsController.GetObjectByID(objBatchProductsInfo.FK_MMProposalID);

                if (objProposalsInfo != null)
                {
                    if (isFullBatchProduct)
                    {
                        //Change status to InProcess
                        objProposalsInfo.MMProposalBatchStatus = BatchProposalStatus.InProcess.ToString();
                    }
                    if (isFullBatchProductApproved)
                        //Change status to Proposed
                        objProposalsInfo.MMProposalBatchStatus = BatchProposalStatus.Processed.ToString();
                    if (isFullBatchProductCompleted)
                        //Change status to Proposed
                        objProposalsInfo.MMProposalBatchStatus = BatchProposalStatus.Completed.ToString();
                    if (isFullBatchProductCanceled)
                        //Change status to Proposed
                        objProposalsInfo.MMProposalBatchStatus = BatchProposalStatus.Canceled.ToString();
                    if (isFullBatchProduct || isFullBatchProductApproved || isFullBatchProductCompleted || isFullBatchProductCanceled)
                        objProposalsController.UpdateObject(objProposalsInfo);
                }

            }
        }

        /// <summary>
        /// Add item to purchase BatchProduct item list
        /// </summary>
        public void AddItemToBatchProductItemsList(int productID, decimal productQty, DateTime deliveryDate, MMProposalItemsInfo objProposalItemsInfo)
        {
            int productCheck = 0;

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)entity.ModuleObjects[TableName.MMBatchProductItemsTableName];
            ICProductsController objProductController = new ICProductsController();
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            if (productID > 0)
            {
                productCheck = productID;
            }

            else
            {
                productCheck = item.FK_ICProductID;
            }
            if (productCheck > 0)
            {
                ICProductsInfo objProductInfo = BOSApp.GetProductFromCurrentProductList(productCheck);

                entity.SetValuesAfterValidateProduct(productCheck, item);
                item.FK_MMProductionNormID = 0;
                item.FK_ARSaleOrderID = objProposalItemsInfo.FK_ARSaleOrderID;
                item.MMBatchProductItemPONo = objProposalItemsInfo.MMProposalItemPONo;
                item.MMBatchProductItemDeliveryDate = objProposalItemsInfo.MMProposalItemDeliveryDate;
                if (objProposalItemsInfo != null && objProposalItemsInfo.FK_MMProductionNormID > 0)
                    item.FK_MMProductionNormID = objProposalItemsInfo.FK_MMProductionNormID;
                else
                {
                    List<MMProductionNormsInfo> ProductionNormList = objProductionNormsController.GetProductionNormByListID(productCheck.ToString());
                    if (ProductionNormList != null && ProductionNormList.Count > 0)
                        item.FK_MMProductionNormID = ProductionNormList[0].MMProductionNormID;
                }

                if (objProductInfo != null)
                {
                    item.MMBatchProductItemProductNo = objProductInfo.ICProductNo;
                    item.MMBatchProductItemProductName = objProductInfo.ICProductName;
                    item.MMBatchProductItemProductLength = objProductInfo.ICProductLength;
                    item.MMBatchProductItemProductWidth = objProductInfo.ICProductWidth;
                    item.MMBatchProductItemProductHeight = objProductInfo.ICProductHeight;
                    item.MMBatchProductItemStatus = BatchProductStatus.New.ToString();
                    item.FK_ICProductAttributeColorID = objProductInfo.FK_ICProductAttributeColorID;
                    item.FK_ICProductAttributeHTTypeID = objProductInfo.FK_ICProductAttributeFinishingID;
                    item.FK_ICProductAttributeWoodTypeID = objProductInfo.FK_ICProductAttributeWoodTypeID;
                    item.FK_ICMeasureUnitID = objProductInfo.FK_ICProductBasicUnitID;
                    if (productQty > 0)
                    {
                        item.MMBatchProductItemProductQty = productQty;
                        item.MMBatchProductItemProductDeliveryDate = deliveryDate;
                    }
                    else
                        item.MMBatchProductItemProductQty = 1;

                    item.MMBatchProductItemRemainQty = item.MMBatchProductItemProductQty;
                }
                if (objProposalItemsInfo.MMProposalItemID > 0)
                {

                    item.MMBatchProductItemProductLength = objProposalItemsInfo.MMProposalItemProductLength;
                    item.MMBatchProductItemProductWidth = objProposalItemsInfo.MMProposalItemProductWidth;
                    item.MMBatchProductItemProductHeight = objProposalItemsInfo.MMProposalItemProductHeight;

                    item.MMBatchProductItemIsNewProduct = objProposalItemsInfo.MMProposalItemIsNewProduct;
                    item.MMBatchProductItemIsJoinComponent = objProposalItemsInfo.MMProposalItemIsJoinComponent;
                    item.MMBatchProductItemHardwareRemark = objProposalItemsInfo.MMProposalItemHardwareRemark;
                    item.MMBatchProductItemPackagingRequimentType = objProposalItemsInfo.MMProposalItemPackagingRequimentType;
                    item.MMBatchProductItemLabelCorlor = objProposalItemsInfo.MMProposalItemLabelCorlor;
                    item.MMBatchProductItemProductCard = objProposalItemsInfo.MMProposalItemProductCard;
                    item.MMBatchProductItemProductLabel = objProposalItemsInfo.MMProposalItemProductLabel;
                    item.MMBatchProductItemProductHDLR = objProposalItemsInfo.MMProposalItemProductHDLR;
                    item.MMBatchProductItemProductHDSD = objProposalItemsInfo.MMProposalItemProductHDSD;
                    item.MMBatchProductItemProductBarcode = objProposalItemsInfo.MMProposalItemProductBarcode;
                    item.MMBatchProductItemProductWarranty = objProposalItemsInfo.MMProposalItemProductWarranty;
                    item.MMBatchProductItemDesc = objProposalItemsInfo.MMProposalItemComment;
                    item.FK_ARSaleOrderItemID = objProposalItemsInfo.FK_ARSaleOrderItemID;
                    item.FK_ARSaleOrderID = objProposalItemsInfo.FK_ARSaleOrderID;
                    item.FK_MMProposalItemID = objProposalItemsInfo.MMProposalItemID;
                    item.FK_MMProposalID = objProposalItemsInfo.FK_MMProposalID;
                    item.MMBatchProductItemRemainQty = item.MMBatchProductItemProductQty;
                    item.MMBatchProductItemDeliveryDate = objProposalItemsInfo.MMProposalItemDeliveryDate;
                    item.FK_ICProductAttributeQualityID = objProposalItemsInfo.FK_ICProductAttributeQualityID;
                    item.FK_ICProductAttributeHTTypeID = objProposalItemsInfo.FK_ICProductAttributeHTTypeID;

                    item.MMBatchProductItemPONo = objProposalItemsInfo.MMProposalItemPONo;

                    // Hoàn thiện
                    item.MMBatchProductItemHTID = objProposalItemsInfo.MMProposalItemHTID;
                    item.MMBatchProductItemHTText = objProposalItemsInfo.MMProposalItemProductAttributeHTType;
                    //Màu sơn
                    item.MMBatchProductItemColorID = objProposalItemsInfo.MMProposalItemColorID;
                    item.MMBatchProductItemColorText = objProposalItemsInfo.MMProposalItemProductAttributeColor;
                    //Loại gỗ
                    item.MMBatchProductItemWoodTypeID = objProposalItemsInfo.MMProposalItemWoodTypeID;
                    item.MMBatchProductItemWoodTypeText = objProposalItemsInfo.MMProposalItemWoodTypeText;

                }
                else
                {
                    item.MMBatchProductItemIsNewProduct = false;
                    item.MMBatchProductItemIsJoinComponent = false;
                    item.MMBatchProductItemLabelCorlor = false;
                    item.MMBatchProductItemProductCard = false;
                    item.MMBatchProductItemProductLabel = false;
                    item.MMBatchProductItemProductHDLR = false;
                    item.MMBatchProductItemProductHDSD = false;
                    item.MMBatchProductItemProductBarcode = false;
                    item.MMBatchProductItemProductWarranty = false;
                    // Hoàn thiện
                    item.MMBatchProductItemHTID = objProductInfo.ICProductAttributeFinishing;
                    item.MMBatchProductItemHTText = objProductInfo.ICProductAttributeFinishingText;
                    //Màu sơn
                    item.MMBatchProductItemColorID = objProductInfo.ICProductColorAttribute;
                    item.MMBatchProductItemColorText = GetAttributeText(objProductInfo.ICProductColorAttribute);
                    //Loại gỗ
                    item.MMBatchProductItemWoodTypeID = objProductInfo.ICProductWoodTypeAttribute;
                    item.MMBatchProductItemWoodTypeText = GetAttributeText(objProductInfo.ICProductWoodTypeAttribute);
                    item.MMBatchProductItemProductDeliveryDate = objBatchProductsInfo.MMBatchProductDeliveryDate;
                }
                item.MMBatchProductItemNeededTime = deliveryDate;
                if (entity.BatchProductItemList != null)
                    item.MMBatchProductItemPeriod = entity.BatchProductItemList.Count + 1;
                else
                    item.MMBatchProductItemPeriod = 1;
                entity.BatchProductItemList.AddObjectToList();
            }
        }

        public void AddSOItemToBatchItemsList(int productID, decimal productQty, DateTime deliveryDate, ARSaleOrderItemsInfo objProposalItemsInfo)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)entity.ModuleObjects[TableName.MMBatchProductItemsTableName];
            if (productID > 0)
            {

                ICProductsInfo objProductInfo = BOSApp.GetProductFromCurrentProductList(productID);

                entity.SetValuesAfterValidateProduct(productID, item);
                item.FK_MMProductionNormID = 0;
                item.FK_ARSaleOrderID = objProposalItemsInfo.FK_ARSaleOrderID;
                item.FK_ARSaleOrderItemID = objProposalItemsInfo.ARSaleOrderItemID;
                item.MMBatchProductItemPONo = objProposalItemsInfo.ARSaleOrderPONo;
                item.FK_MMProductionNormID = objProposalItemsInfo.FK_MMProductionNormID;
                // Hoàn thiện_aRSaleOrderItemWoodTypeText
                item.MMBatchProductItemHTID = objProposalItemsInfo.ARSaleOrderItemHTID;
                item.MMBatchProductItemHTText = objProposalItemsInfo.ARSaleOrderItemHTText;
                //Màu sơn
                item.MMBatchProductItemColorID = objProposalItemsInfo.ARSaleOrderItemColorID;
                item.MMBatchProductItemColorText = objProposalItemsInfo.ARSaleOrderItemColorText;
                //Loại gỗ
                item.MMBatchProductItemWoodTypeID = objProposalItemsInfo.ARSaleOrderItemWoodTypeID;
                item.MMBatchProductItemWoodTypeText = objProposalItemsInfo.ARSaleOrderItemWoodTypeText;
                item.MMBatchProductItemProductLength = objProposalItemsInfo.ARSaleOrderItemLength;
                item.MMBatchProductItemProductWidth = objProposalItemsInfo.ARSaleOrderItemWidth;
                item.MMBatchProductItemProductHeight = objProposalItemsInfo.ARSaleOrderItemHeight;
                item.MMBatchProductItemProductDesc = objProposalItemsInfo.ARSaleOrderItemProductDesc;
                if (objProductInfo != null)
                {
                    item.MMBatchProductItemProductNo = objProductInfo.ICProductNo;
                    item.MMBatchProductItemProductName = objProductInfo.ICProductName;

                    item.MMBatchProductItemStatus = BatchProductStatus.New.ToString();
                    item.FK_ICProductAttributeColorID = objProductInfo.FK_ICProductAttributeColorID;
                    item.FK_ICProductAttributeHTTypeID = objProductInfo.FK_ICProductAttributeFinishingID;
                    item.FK_ICProductAttributeWoodTypeID = objProductInfo.FK_ICProductAttributeWoodTypeID;
                    item.FK_ICMeasureUnitID = objProductInfo.FK_ICProductBasicUnitID;
                    if (productQty > 0)
                    {
                        item.MMBatchProductItemProductQty = productQty;
                        item.MMBatchProductItemProductDeliveryDate = deliveryDate;
                    }
                    else
                        item.MMBatchProductItemProductQty = 1;
                    item.MMBatchProductItemRemainQty = item.MMBatchProductItemProductQty;
                }
                item.MMBatchProductItemIsNewProduct = false;
                item.MMBatchProductItemIsJoinComponent = false;
                item.MMBatchProductItemLabelCorlor = false;
                item.MMBatchProductItemProductCard = false;
                item.MMBatchProductItemProductLabel = false;
                item.MMBatchProductItemProductHDLR = false;
                item.MMBatchProductItemProductHDSD = false;
                item.MMBatchProductItemProductBarcode = false;
                item.MMBatchProductItemProductWarranty = false;
                item.MMBatchProductItemNeededTime = deliveryDate;
                item.MMBatchProductItemDeliveryDate = deliveryDate;
                if (entity.BatchProductItemList != null)
                    item.MMBatchProductItemPeriod = entity.BatchProductItemList.Count + 1;
                else
                    item.MMBatchProductItemPeriod = 1;
                entity.BatchProductItemList.AddObjectToList();
            }
        }
        public bool CheckSORemainQuantity(MMBatchProductItemsInfo itemcheck)
        {
            bool result = true;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<string> soItemListID = new List<string>();
            List<ARSaleOrderItemsInfo> listSOItems = new List<ARSaleOrderItemsInfo>();
            if (itemcheck != null && itemcheck.FK_ARSaleOrderItemID > 0)
            {
                soItemListID.Add(itemcheck.FK_ARSaleOrderItemID.ToString());
            }
            else
            {
                soItemListID = entity.BatchProductItemList.Where(o => o.FK_ARSaleOrderItemID > 0 && o.FK_ARProductionPlanningItemID == 0 && o.FK_MMProposalItemID == 0)
                    .Select(b => b.FK_ARSaleOrderItemID.ToString()).Distinct().ToList();
            }
            if (soItemListID != null && soItemListID.Count > 0)
            {
                listSOItems = objSaleOrderItemsController.GetShipmentProposalByListSOItemID(objBatchProductsInfo.MMBatchProductID, string.Join(",", soItemListID.ToArray()));
            }
            if (listSOItems != null && listSOItems.Count > 0)
            {
                string mess = string.Empty;
                foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                {
                    if (itemcheck == null || (itemcheck != null && itemcheck.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID))
                    {
                        decimal soiRemainQty = listSOItems.Where(l => l.ARSaleOrderItemID == item.FK_ARSaleOrderItemID)
                            .Sum(o => o.ARSaleOrderItemRemainedQty);
                        decimal piQty = listSOItems.Where(l => l.ARSaleOrderItemID == item.FK_ARSaleOrderItemID)
                            .Sum(o => o.ARSaleOrderItemProductQty);
                        decimal thisBatchedQty = entity.BatchProductItemList.Where(p => p.FK_ARSaleOrderItemID == item.FK_ARSaleOrderItemID)
                            .Sum(o => o.MMBatchProductItemProductQty);
                        if (Math.Round(thisBatchedQty, 4) > Math.Round(soiRemainQty, 4))
                        {
                            item.IsError = true;
                            mess += Environment.NewLine + string.Join(",", listSOItems.Where(l => l.ARSaleOrderItemID == item.FK_ARSaleOrderItemID)
                                    .Select(l => l.ARSaleOrderNo).Distinct().ToArray())
                                    + " Mã hàng: " + item.MMBatchProductItemProductNo
                                    + Environment.NewLine + "SL PI: " + piQty + " -  SL còn lại: " + soiRemainQty;
                            result = false;
                        }
                    }
                }
                if (mess != string.Empty)
                {
                    MessageBox.Show("Số lượng lớn hơn có thể làm LSX"
                         + mess
                         , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return result;
        }
        public void AddProductionPlanningItemToBatchProductItemsList(int productID, decimal productQty, DateTime deliveryDate, ARProductionPlanningItemsInfo objProductionPlanningItemsInfo)
        {
            int productCheck = 0;

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)entity.ModuleObjects[TableName.MMBatchProductItemsTableName];
            ICProductsController objProductController = new ICProductsController();
            ARSaleOrderItemsController objSaleOrderItemController = new ARSaleOrderItemsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            if (productID > 0)
            {
                productCheck = productID;
            }

            else
            {
                productCheck = item.FK_ICProductID;
            }
            if (productCheck > 0)
            {
                ICProductsInfo objProductInfo = (ICProductsInfo)objProductController.GetObjectByID(productCheck);
                ARSaleOrderItemsInfo objSaleOrderItemInfo = (ARSaleOrderItemsInfo)objSaleOrderItemController.GetObjectByID(objProductionPlanningItemsInfo.FK_ARSaleOrderItemID);
                ARSaleOrdersInfo objSaleOrderInfo = new ARSaleOrdersInfo();
                if (objProductionPlanningItemsInfo.FK_ARSaleOrderID > 0)
                {
                    objSaleOrderInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProductionPlanningItemsInfo.FK_ARSaleOrderID);
                    if (objSaleOrderInfo != null)
                    {
                        objBatchProductsInfo.FK_ACObjectID = objSaleOrderInfo.FK_ACObjectID;
                        objBatchProductsInfo.MMObjectType = objSaleOrderInfo.ARObjectType;
                        objBatchProductsInfo.ACObjectAccessKey = string.Format("{0};{1}", objBatchProductsInfo.FK_ACObjectID, objBatchProductsInfo.MMObjectType);
                    }
                }

                entity.SetValuesAfterValidateProduct(productCheck, item);
                item.FK_MMProductionNormID = 0;
                item.FK_ARSaleOrderID = objProductionPlanningItemsInfo.FK_ARSaleOrderID;
                item.MMBatchProductItemPONo = objProductionPlanningItemsInfo.ARProductionPlanningItemPONo;
                item.FK_MMProductionNormID = objProductionPlanningItemsInfo.FK_MMProductionNormID;
                if (objProductInfo != null)
                {
                    item.MMBatchProductItemProductNo = objProductInfo.ICProductNo;
                    item.MMBatchProductItemProductName = objProductInfo.ICProductName;
                    item.MMBatchProductItemProductLength = objProductInfo.ICProductLength;
                    item.MMBatchProductItemProductWidth = objProductInfo.ICProductWidth;
                    item.MMBatchProductItemProductHeight = objProductInfo.ICProductHeight;
                    item.MMBatchProductItemStatus = BatchProductStatus.New.ToString();
                    item.FK_ICProductAttributeColorID = objProductInfo.FK_ICProductAttributeColorID;
                    item.FK_ICProductAttributeHTTypeID = objProductInfo.FK_ICProductAttributeFinishingID;
                    item.FK_ICProductAttributeWoodTypeID = objProductInfo.FK_ICProductAttributeWoodTypeID;
                    item.FK_ICMeasureUnitID = objProductInfo.FK_ICProductBasicUnitID;
                    if (productQty > 0)
                    {
                        item.MMBatchProductItemProductQty = productQty;
                        item.MMBatchProductItemProductDeliveryDate = deliveryDate;
                    }
                    else
                        item.MMBatchProductItemProductQty = 1;
                    item.MMBatchProductItemRemainQty = item.MMBatchProductItemProductQty;
                }
                if (objProductionPlanningItemsInfo.ARProductionPlanningItemID > 0)
                {
                    if (objSaleOrderItemInfo != null)
                    {
                        item.MMBatchProductItemDesc = objSaleOrderItemInfo.ARSaleOrderItemComment;
                        item.FK_ARProductionPlanningID = objProductionPlanningItemsInfo.FK_ARProductionPlanningID;
                        item.FK_ARProductionPlanningItemID = objProductionPlanningItemsInfo.ARProductionPlanningItemID;
                        item.FK_ARSaleOrderItemID = objSaleOrderItemInfo.ARSaleOrderItemID;
                        item.MMBatchProductItemRemainQty = item.MMBatchProductItemProductQty;
                        item.MMBatchProductItemDeliveryDate = objSaleOrderItemInfo.ARSaleOrderItemDeliveryDate;
                        item.FK_ICProductAttributeQualityID = objSaleOrderItemInfo.FK_ICProductAttributeQualityID;
                        item.MMBatchProductItemPONo = objSaleOrderItemInfo.ARSaleOrderItemPONo;
                        item.FK_ARSaleOrderID = objSaleOrderItemInfo.FK_ARSaleOrderID;
                        // Hoàn thiện
                        item.MMBatchProductItemHTID = objSaleOrderItemInfo.ARSaleOrderItemHTID;
                        item.MMBatchProductItemHTText = objSaleOrderItemInfo.ARSaleOrderItemHTText;
                        //Màu sơn
                        item.MMBatchProductItemColorID = objSaleOrderItemInfo.ARSaleOrderItemColorID;
                        item.MMBatchProductItemColorText = objSaleOrderItemInfo.ARSaleOrderItemColorText;
                        //Loại gỗ
                        item.MMBatchProductItemWoodTypeID = objSaleOrderItemInfo.ARSaleOrderItemWoodTypeID;
                        item.MMBatchProductItemWoodTypeText = objSaleOrderItemInfo.ARSaleOrderItemWoodTypeText;
                    }
                    else
                    {
                        item.FK_ARProductionPlanningID = objProductionPlanningItemsInfo.FK_ARProductionPlanningID;
                        item.FK_ARProductionPlanningItemID = objProductionPlanningItemsInfo.ARProductionPlanningItemID;
                    }
                    item.MMBatchProductItemPONo = objBatchProductsInfo.MMBatchProductPONo;
                }
                else
                {
                    item.MMBatchProductItemIsNewProduct = false;
                    item.MMBatchProductItemIsJoinComponent = false;
                    item.MMBatchProductItemLabelCorlor = false;
                    item.MMBatchProductItemProductCard = false;
                    item.MMBatchProductItemProductLabel = false;
                    item.MMBatchProductItemProductHDLR = false;
                    item.MMBatchProductItemProductHDSD = false;
                    item.MMBatchProductItemProductBarcode = false;
                    item.MMBatchProductItemProductWarranty = false;

                    // Hoàn thiện
                    item.MMBatchProductItemHTID = objProductInfo.ICProductAttributeFinishing;
                    item.MMBatchProductItemHTText = objProductInfo.ICProductAttributeFinishingText;
                    //Màu sơn
                    item.MMBatchProductItemColorID = objProductInfo.ICProductColorAttribute;
                    item.MMBatchProductItemColorText = GetAttributeText(objProductInfo.ICProductColorAttribute);
                    //Loại gỗ
                    item.MMBatchProductItemWoodTypeID = objProductInfo.ICProductWoodTypeAttribute;
                    item.MMBatchProductItemWoodTypeText = GetAttributeText(objProductInfo.ICProductWoodTypeAttribute);

                }
                int rangeDate = 0;
                string range = ADConfigValueUtility.GetConfigTextByGroupAndValue("BatchProductNeededTime", "RangeDate");
                rangeDate = int.Parse(range != string.Empty ? range : "0");

                item.MMBatchProductItemNeededTime = deliveryDate.AddDays(-rangeDate);
                if (entity.BatchProductItemList != null)
                    item.MMBatchProductItemPeriod = entity.BatchProductItemList.Count + 1;
                else
                    item.MMBatchProductItemPeriod = 1;
                entity.BatchProductItemList.AddObjectToList();
            }
        }

        public string GetAttributeText(string ids)
        {
            string result = string.Empty;

            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

            if (!string.IsNullOrEmpty(ids))
            {
                string[] colors = ids.Split(',');
                if (colors != null && colors.Length > 0)
                {
                    foreach (string id in colors)
                    {
                        DataRow row = BOSApp.GetObjectFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(id.Trim()));
                        if (row != null)
                        {
                            ICProductAttributesInfo attribute = (ICProductAttributesInfo)objProductAttributesController.GetObjectFromDataRow(row);
                            if (attribute != null)
                            {
                                if (!string.IsNullOrEmpty(result))
                                {
                                    result += ", " + attribute.ICProductAttributeValue;
                                }
                                else
                                {
                                    result += attribute.ICProductAttributeValue;
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Delete item from BatchProduct item list
        /// </summary>
        public void DeleteItemFromBatchProductItemList()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (objBatchProductsInfo.FK_ARProductionPlanningID > 0) return;
            entity.BatchProductItemList.RemoveSelectedRowObjectFromList();

        }

        /// <summary>
        /// Called when user changes the item from the item list
        /// </summary>
        public void ChangeItemFromBatchProductItemList()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            entity.SetProductCostByProductUnitCost();
            entity.BatchProductItemList.ChangeObjectFromList();
        }

        public void ChooseItemFromSaleOrder()
        {
            if (Toolbar.IsNullOrNoneAction()) return;

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.BatchProductItemList.Any(b => b.FK_ARProductionPlanningItemID > 0 || b.FK_MMProposalItemID > 0))
            {
                MessageBox.Show("Chi tiết lệnh SX lấy từ KHGH hoặc ĐNSX, không thể chọn thêm từ P/I!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            using (guiChooseARSaleOrderItem gui = new guiChooseARSaleOrderItem())
            {
                gui.Module = this;
                if (gui.ShowDialog() == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> BatchProductItemsList = new List<MMBatchProductItemsInfo>();
                    var selectedSaleOrderItems = gui.ARSaleOrderItemList.Where(x => x.Selected).ToList();
                    foreach (ARSaleOrderItemsInfo item in selectedSaleOrderItems)
                    {
                        AddSOItemToBatchItemsList(item.FK_ICProductID, item.ARSaleOrderItemProductQty, item.ARSaleOrderItemDeliveryDate, item);
                        if (!objBatchProductsInfo.MMBatchProductSaleOrderNo.Contains(item.ARSaleOrderNo))
                        {
                            objBatchProductsInfo.MMBatchProductSaleOrderNo = objBatchProductsInfo.MMBatchProductSaleOrderNo == string.Empty ? item.ARSaleOrderNo : ("," + item.ARSaleOrderNo);
                        }
                        if (!objBatchProductsInfo.MMBatchProductPONo.Contains(item.ARSaleOrderPONo))
                        {
                            objBatchProductsInfo.MMBatchProductPONo = objBatchProductsInfo.MMBatchProductPONo == string.Empty ? item.ARSaleOrderPONo : ("," + item.ARSaleOrderPONo);
                        }
                    }
                    DateTime minDeliveryDate = objBatchProductsInfo.MMBatchProductDeliveryDate;

                    objBatchProductsInfo.MMBatchProductDeliveryDate = selectedSaleOrderItems.Max(o => o.ARSaleOrderItemDeliveryDate);
                    objBatchProductsInfo.MMBatchProductType = selectedSaleOrderItems[0].ARSaleOrderType;
                    objBatchProductsInfo.FK_ARCustomerID = selectedSaleOrderItems[0].FK_ARCustomerID;
                    if (minDeliveryDate.Date != DateTime.MinValue.Date && minDeliveryDate.Date != DateTime.MaxValue.Date)
                    {
                        objBatchProductsInfo.MMBatchProductDeliveryDate = new[] { minDeliveryDate.Date, objBatchProductsInfo.MMBatchProductDeliveryDate.Date }.Max();
                    }
                    entity.BatchProductItemList.GridControl?.RefreshDataSource();
                    entity.BatchProductItemList.GridView.ExpandAllGroups();
                    BOSDisposeUtility.DisposeAll(gui.ARSaleOrderItemList, 0, GCCollectionMode.Forced);
                }
                else
                    ActionCancel();
            }
        }
        public void ActionNewFromSaleOrder()
        {
            ActionNew();

        }
        public void ActionNewFromProposal()
        {
            ActionNew();
            ShowProposal();
            //AllowEditGridView();
        }
        public override void ActionNew()
        {
            base.ActionNew();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            objBatchProductsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductDate = DateTime.Now;
            objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.New.ToString();

            HaveFocusHardware = false;
            HaveFocusGeneralMaterial = false;
            HaveFocusPackaging = false;
            HaveFocusPaint = false;
            HaveFocusWood = false;
            if (entity.ProductionNormItemHardwareList != null && entity.ProductionNormItemHardwareList.Count > 0)
            {
                entity.ProductionNormItemHardwareList.Clear();
            }
            if (entity.ProductionNormItemGeneralMaterialList != null && entity.ProductionNormItemGeneralMaterialList.Count > 0)
            {
                entity.ProductionNormItemGeneralMaterialList.Clear();
            }
            if (entity.ProductionNormItemPackagingList != null && entity.ProductionNormItemPackagingList.Count > 0)
            {
                entity.ProductionNormItemPackagingList.Clear();
            }
            if (entity.ProductionNormItemPaintList != null && entity.ProductionNormItemPaintList.Count > 0)
            {
                entity.ProductionNormItemPaintList.Clear();
            }
            if (entity.BatchProductProductionNormItemList != null && entity.BatchProductProductionNormItemList.Count > 0)
            {
                entity.BatchProductProductionNormItemList.Clear();
            }
            // EnableToolbar();
            ParentScreen.SetEnableOfToolbarButton(BatchProductConst.ValidateBatchProduct, false);

            ParentScreen.SetEnableOfToolbarButton(BatchProductConst.ApproveBatchProduct, false);

        }

        /// <summary>
        /// Show batch Sale Order
        /// </summary>
        public void ShowProposal()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            MMProposalsController objProposalsController = new MMProposalsController();
            MMProposalsInfo objProposalsInfo = new MMProposalsInfo();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            List<MMProposalItemsInfo> ProposalItemAvailableList = objProposalItemsController.GetProposalItemsAvailableToBatch();

            guiFind<MMProposalItemsInfo> guiFind = new guiFind<MMProposalItemsInfo>(TableName.MMProposalItemsTableName,
                                                                                            ProposalItemAvailableList,
                                                                                            this,
                                                                                            true,
                                                                                            true,
                                                                                            new string[] { "MMProposalNo" },
                                                                                            new string[] { "ARSaleOrderNo", "ACObjectName", "MMProposalPONo", "MMProposalDate", "MMProposalType", "HREmployeeName", "MMProposalDesc" });
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                bool setMainObject = false;


                List<MMProposalItemsInfo> ProposalItemList = (List<MMProposalItemsInfo>)guiFind.SelectedObjects;
                int propoaslID = guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0 ? guiFind.SelectedObjects[0].FK_MMProposalID : 0;
                objProposalsInfo = (MMProposalsInfo)objProposalsController.GetObjectByID(propoaslID);
                if (objProposalsInfo != null)
                {
                    objBatchProductsInfo.FK_ICProductAttributeTTMTID = guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0 ? guiFind.SelectedObjects[0].FK_ICProductAttributeTTMTID : 0;
                }
                foreach (MMProposalItemsInfo item in ProposalItemList)
                {
                    int ProposalID = item.FK_MMProposalID;
                    if (!setMainObject)
                    {
                        objBatchProductsInfo.FK_ARCustomerID = objProposalsInfo.FK_ARCustomerID;
                        objBatchProductsInfo.FK_MMProposalID = objProposalsInfo.MMProposalID;
                        objBatchProductsInfo.MMBatchProductPONo = objProposalsInfo.MMProposalPONo;
                        objBatchProductsInfo.FK_ACObjectID = objProposalsInfo.FK_ACObjectID;
                        objBatchProductsInfo.MMObjectType = objProposalsInfo.MMObjectType;
                        objBatchProductsInfo.ACObjectAccessKey = string.Format("{0};{1}", objBatchProductsInfo.FK_ACObjectID, objBatchProductsInfo.MMObjectType);
                        ARSaleOrdersController objSaleOrderController = new ARSaleOrdersController();
                        ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
                        objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrderController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                        if (objSaleOrdersInfo != null)
                        {
                            objBatchProductsInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                            objBatchProductsInfo.MMBatchProductDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryDate;
                            objBatchProductsInfo.MMBatchProductSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                        }
                        else
                        {
                            objBatchProductsInfo.MMBatchProductDeliveryDate = objProposalsInfo.MMProposalSaleOrderDeliveryDate;
                        }
                        objBatchProductsInfo.MMBatchProductDate = DateTime.Now;
                        objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.New.ToString();
                        objBatchProductsInfo.MMPriority = objProposalsInfo.MMPriority;
                        objBatchProductsInfo.MMBatchProductType = objProposalsInfo.MMProposalType;

                        setMainObject = true;
                    }
                    AddItemToBatchProductItemsList(item.FK_ICProductID, item.MMProposalItemProductQty, item.MMProposalItemDeliveryDate, item);

                }
                entity.BatchProductItemList.GridControl?.RefreshDataSource();
                entity.BatchProductItemList.GridView.ExpandAllGroups();
            }
            else
                ActionCancel();
        }

        public void ActionNewFromProductionPlanning()
        {
            ActionNew();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)entity.MainObject;
            ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
            guiChooseProductionPlanningItem guiFind = new guiChooseProductionPlanningItem();
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARProductionPlanningItemsInfo> productionPlanningItemList = guiFind.SelectedObjects;
            List<MMBatchProductItemsInfo> batchProductItemList = new List<MMBatchProductItemsInfo>();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            int rangeDate = 0;
            string range = ADConfigValueUtility.GetConfigTextByGroupAndValue("BatchProductNeededTime", "RangeDate");
            rangeDate = int.Parse(range != string.Empty ? range : "0");
            ARProductionPlanningItemsInfo objProductionPlanningItemsInfo = productionPlanningItemList.FirstOrDefault();
            if (objProductionPlanningItemsInfo != null)
            {
                mainobject.FK_MMWorkShopID = objProductionPlanningItemsInfo.FK_MMWorkShopID;
                mainobject.MMBatchProductFromDate = objProductionPlanningItemsInfo.ARProductionPlanningFromDate;
                mainobject.MMBatchProductToDate = objProductionPlanningItemsInfo.ARProductionPlanningToDate;
                mainobject.MMBatchProductResourceType = objProductionPlanningItemsInfo.ARProductionPlanningSources == "Process" ? BatchProductResourceType.Manafacturing.ToString() : objProductionPlanningItemsInfo.ARProductionPlanningSources;
                mainobject.FK_ICProductAttributeTTMTID = objProductionPlanningItemsInfo.FK_ICProductAttributeTTMTID;
                mainobject.FK_ARProductionPlanningID = objProductionPlanningItemsInfo.FK_ARProductionPlanningID;
                mainobject.MMBatchProductSaleType = objProductionPlanningItemsInfo.ARProductionPlanningSaleType;
                mainobject.MMBatchProductSOName = objProductionPlanningItemsInfo.ARProductionPlanningSaleOrderName;
            }
            mainobject.MMBatchProductType = objProductionPlanningItemsInfo.ARProductionPlanningType;
            if (string.IsNullOrWhiteSpace(mainobject.MMBatchProductType))
            {
                objProductionPlanningItemsInfo = productionPlanningItemList.FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.ARSaleOrderType));
                mainobject.MMBatchProductType = objProductionPlanningItemsInfo != null ? objProductionPlanningItemsInfo.ARSaleOrderType : string.Empty;
            }
            mainobject.MMBatchProductMultiCustomer = string.Join(",", productionPlanningItemList.Select(p => p.ACObjectName).Distinct().ToArray());
            mainobject.MMBatchProductSOName = string.Join(",", productionPlanningItemList.Select(p => p.ARProductionPlanningItemSaleOrderName).Distinct().ToArray());
            mainobject.MMBatchProductDesc = string.Join(",", productionPlanningItemList.Select(p => p.ARSaleOrderNo).Distinct().ToArray());
            productionPlanningItemList.ForEach(o =>
            {
                objBatchProductItemsInfo = ToBatchProductItems(o, rangeDate);
                batchProductItemList.Add(objBatchProductItemsInfo);
            });
            entity.BatchProductItemList.Invalidate(batchProductItemList);
        }

        public MMBatchProductItemsInfo ToBatchProductItems(ARProductionPlanningItemsInfo item, int rangeDate)
        {
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            ICProductsController objProductsController = new ICProductsController();
            if (objProductsInfo == null)
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);   
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            BOSUtil.CopyObject(objProductsInfo, objBatchProductItemsInfo);
            objBatchProductItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objBatchProductItemsInfo.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
            objBatchProductItemsInfo.MMBatchProductItemProductName = objProductsInfo.ICProductName;
            objBatchProductItemsInfo.ICProductName2 = item.ICProductName2;
            objBatchProductItemsInfo.ICProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
            objBatchProductItemsInfo.MMBatchProductItemProductDesc = objProductsInfo.ICProductDesc;
            objBatchProductItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objBatchProductItemsInfo.FK_ARSaleOrderItemID = item.FK_ARSaleOrderItemID;
            objBatchProductItemsInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
            objBatchProductItemsInfo.FK_PMProjectID = item.FK_PMProjectID;
            objBatchProductItemsInfo.FK_ACObjectID = item.FK_ACObjectID;
            objBatchProductItemsInfo.ARObjectType = item.ARObjectType;
            objBatchProductItemsInfo.FK_ARProductionPlanningID = item.FK_ARProductionPlanningID;
            objBatchProductItemsInfo.FK_ARProductionPlanningItemID = item.ARProductionPlanningItemID;
            objBatchProductItemsInfo.MMBatchProductItemProductQty = item.ARProductionPlanningItemProductQty;
            objBatchProductItemsInfo.MMBatchProductItemRemainQty = item.ARProductionPlanningItemProductQty;
            objBatchProductItemsInfo.MMBatchProductItemProductLength = item.ARProductionPlanningItemLength;
            objBatchProductItemsInfo.MMBatchProductItemProductWidth = item.ARProductionPlanningItemWidth;
            objBatchProductItemsInfo.MMBatchProductItemProductHeight = item.ARProductionPlanningItemHeight;
            objBatchProductItemsInfo.MMBatchProductItemPONo = item.ARProductionPlanningItemPONo;
            if (item.ARProductionPlanningItemLength == 0 || item.ARProductionPlanningItemWidth == 0)
            {
                objBatchProductItemsInfo.MMBatchProductItemProductLength = objProductsInfo.ICProductLength;
                objBatchProductItemsInfo.MMBatchProductItemProductWidth = objProductsInfo.ICProductWidth;
                objBatchProductItemsInfo.MMBatchProductItemProductHeight = objProductsInfo.ICProductHeight;
            }
            objBatchProductItemsInfo.MMBatchProductItemResourceType = item.ARProductionPlanningItemSources == "Process" ? BatchProductResourceType.Manafacturing.ToString() : item.ARProductionPlanningItemSources;
            objBatchProductItemsInfo.MMBatchProductItemNeededTime = item.ARProductionPlanningItemOSSDeliveryDate;
            objBatchProductItemsInfo.MMBatchProductItemDeliveryDate = item.ARProductionPlanningItemDeliveryDate;
            objBatchProductItemsInfo.MMBatchProductItemProductDeliveryDate = item.ARProductionPlanningItemDeliveryDate.AddDays(-rangeDate);
            objBatchProductItemsInfo.FK_MMProductionNormID = item.FK_MMProductionNormID;
            objBatchProductItemsInfo.ACObjectName = item.ACObjectName;
            objBatchProductItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
            objBatchProductItemsInfo.MMBatchProductItemProductCard = item.ARProductionPlanningItemIsProductCard;
            objBatchProductItemsInfo.MMBatchProductItemProductHDLR = item.ARProductionPlanningItemIsProductHDLR;
            objBatchProductItemsInfo.MMBatchProductItemProductHDSD = item.ARProductionPlanningItemIsProductHDSD;
            objBatchProductItemsInfo.MMBatchProductItemProductWarranty = item.ARProductionPlanningItemIsProductWarranty;
            objBatchProductItemsInfo.MMBatchProductItemIsNewProduct = item.ARProductionPlanningItemIsNewProduct;
            objBatchProductItemsInfo.MMBatchProductItemIsJoinComponent = item.ARProductionPlanningItemIsJoinComponent;
            objBatchProductItemsInfo.MMBatchProductItemLabelCorlor = item.ARProductionPlanningItemIsLabelCorlor;
            objBatchProductItemsInfo.MMBatchProductItemProductLabel = item.ARProductionPlanningItemIsProductLabel;
            objBatchProductItemsInfo.MMBatchProductItemProductBarcode = item.ARProductionPlanningItemIsProductBarcode;
            objBatchProductItemsInfo.MMBatchProductItemHardwareRemark = item.ARProductionPlanningItemHardwareRemark;
            objBatchProductItemsInfo.MMBatchProductItemPackagingRequimentType = item.ARProductionPlanningItemPackagingRequimentType;
            objBatchProductItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
            objBatchProductItemsInfo.FK_ICProductAttributeHTTypeID = item.FK_ICProductAttributeHTTypeID;
            objBatchProductItemsInfo.MMBatchProductItemHTID = item.ARSaleOrderItemHTID;
            objBatchProductItemsInfo.MMBatchProductItemHTText = item.ARSaleOrderItemHTText;
            objBatchProductItemsInfo.MMBatchProductItemGeneralMaterialRemark = item.ARProductionPlanningItemGeneralMaterialRemark;
            objBatchProductItemsInfo.MMBatchProductItemSemiProductRemark = item.ARProductionPlanningItemSemiProductRemark;
            objBatchProductItemsInfo.MMBatchProductItemProductRemark = item.ARProductionPlanningItemProductRemark;
            objBatchProductItemsInfo.MMBatchProductItemWoodRemark = item.ARProductionPlanningItemWoodRemark;
            objBatchProductItemsInfo.MMBatchProductItemPaintRemark = item.ARProductionPlanningItemPaintRemark;
            objBatchProductItemsInfo.MMBatchProductItemPackagingRemark = item.ARProductionPlanningItemPackagingRemark;
            objBatchProductItemsInfo.MMBatchProductItemSOName = item.ARProductionPlanningItemSaleOrderName;

            return objBatchProductItemsInfo;
        }

        public void ShowProductionPlanning()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
            ARProductionPlanningsController objProductionPlanningsController = new ARProductionPlanningsController();
            ARProductionPlanningsInfo objProductionPlanningsInfo = new ARProductionPlanningsInfo();
            ARProductionPlanningItemsInfo objProductionPlanningItemsInfo = new ARProductionPlanningItemsInfo();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            ProductionPlanningIDLookupEdit.Properties.DataSource = objProductionPlanningsController.GetAllObjectList();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<ARProductionPlanningsInfo> ProductionPlanningsList =
                objProductionPlanningsController.GetProductionPlanningForBatchProduct();
            guiFind<ARProductionPlanningsInfo> guiFind = new guiFind<ARProductionPlanningsInfo>(TableName.ARProductionPlanningsTableName,
                                                                                            ProductionPlanningsList,
                                                                                            this,
                                                                                            false,
                                                                                            true,
                                                                                            new string[] { "ARProductionPlanningNo" });

            string[] columnArr = new string[] { "ACObjectName"
                    ,   "ARProductionPlanningName"
                    ,   "FK_MMWorkShopID"
                    ,   "ARProductionPlanningDate"
                    ,   "ARProductionPlanningFromDate"
                    ,   "ARProductionPlanningToDate"
                };

            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                objProductionPlanningsInfo = (ARProductionPlanningsInfo)guiFind.SelectedObjects[0];
                objBatchProductsInfo.FK_ARProductionPlanningID = objProductionPlanningsInfo.ARProductionPlanningID;
                objBatchProductsInfo.FK_MMWorkShopID = objProductionPlanningsInfo.FK_MMWorkShopID;
                objBatchProductsInfo.FK_ARProductionPlanningID = objProductionPlanningsInfo.ARProductionPlanningID;
                objBatchProductsInfo.MMBatchProductFromDate = objProductionPlanningsInfo.ARProductionPlanningFromDate;
                objBatchProductsInfo.MMBatchProductToDate = objProductionPlanningsInfo.ARProductionPlanningToDate;
                if (objProductionPlanningsInfo.ARProductionPlanningSources == "Process")
                    objBatchProductsInfo.MMBatchProductResourceType = BatchProductResourceType.Manafacturing.ToString();
                else if (objProductionPlanningsInfo.ARProductionPlanningSources == "OutSourcing")
                    objBatchProductsInfo.MMBatchProductResourceType = BatchProductResourceType.OutSourcing.ToString();

                objBatchProductsInfo.MMBatchProductDate = DateTime.Now;
                objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.New.ToString();

                List<ARProductionPlanningItemsInfo> ProductionPlanningItemList = objProductionPlanningItemsController.GetProductionPlanningItemsByProductionPlanningID(objProductionPlanningsInfo.ARProductionPlanningID);
                foreach (ARProductionPlanningItemsInfo item in ProductionPlanningItemList)
                {
                    if (item.ARProductionPlanningItemDeliveryDate.Date > objBatchProductsInfo.MMBatchProductDeliveryDate.Date)
                        objBatchProductsInfo.MMBatchProductDeliveryDate = item.ARProductionPlanningItemDeliveryDate;
                    AddProductionPlanningItemToBatchProductItemsList(item.FK_ICProductID, item.ARProductionPlanningItemProductQty, item.ARProductionPlanningItemDeliveryDate, item);

                }
                entity.BatchProductItemList.GridControl?.RefreshDataSource();
                entity.BatchProductItemList.GridView.ExpandAllGroups();
                ChangeObject(objBatchProductsInfo.ACObjectAccessKey);
            }
            else
                ActionCancel();
        }

        public bool CheckProductionNormStatus(string approvedType)
        {
            bool result = true;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
            {

                if (item.FK_MMProductionNormID == 0)
                {
                    result = false;
                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ThereIsNotProductProductionNorm, item.MMBatchProductItemDesc), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                else
                {
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        switch (approvedType)
                        {
                            case "Wood":
                                if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Approved.ToString())
                                {
                                    result = true;
                                    break;
                                }
                                else
                                {
                                    result = false;
                                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ThereIsNotProductProductionNormApproved, item.MMBatchProductItemProductDesc, "Nguyên liệu"), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            case "HW":
                                if (objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Approved.ToString())
                                {
                                    result = true;
                                    break;
                                }
                                else
                                {
                                    result = false;
                                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ThereIsNotProductProductionNormApproved, item.MMBatchProductItemProductDesc, "Hardware"), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            case "Packaging":
                                if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Approved.ToString())
                                {
                                    result = true;
                                    break;
                                }
                                else
                                {
                                    result = false;
                                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ThereIsNotProductProductionNormApproved, item.MMBatchProductItemProductDesc, "PLDG"), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            case "Paint":
                                if (objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.Approved.ToString())
                                {
                                    result = true;
                                    break;
                                }
                                else
                                {
                                    result = false;
                                    MessageBox.Show(string.Format(BatchProductLocalizedResources.ThereIsNotProductProductionNormApproved, item.MMBatchProductItemProductDesc, "Sơn"), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    else
                    {
                        result = false;
                        MessageBox.Show(string.Format("Không tìm thấy bảng định mức này!", item.MMBatchProductItemProductDesc), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return result;
                    }
                    if (!result)
                        return result;
                }
            }

            return result;
        }

        public bool IsValidBatchProductWoodStatus(string strStatus)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;

            if (mainObject.MMBatchProductWoodStatus == strStatus || mainObject.MMBatchProductWoodStatus == BatchProductStatus.Approved.ToString())
                return true;

            string strStatusText = strStatus == BatchProductStatus.Approved.ToString() ? "duyệt" : "kiểm tra";
            MessageBox.Show(string.Format("Bạn chưa {0} định mức bán thành phẩm. Vui lòng kiểm tra lại!", strStatusText), BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void ValidateHW()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                if (!CheckDuplicateBOM()) return;
                if (!IsValidWorkShop())
                    return;

                if (!IsExistProductionNorm())
                    return;

                if (!HaveFocusHardware)
                {
                    InvalidateTreeView(fld_tabHardwareName, false);
                }
                if (IsValidBatchProductItem() && IsValidBatchProductWoodStatus(BatchProductStatus.Verified.ToString()))
                {
                    ValidateBatchProductHW();
                    if (entity.ValidateBatchProduct())
                    {
                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            item.MMBatchProductItemStatus = BatchProductStatus.Verified.ToString();
                        }
                        UpdateProposalBatchStatus();
                        entity.UpdateMainObjectBindingSource();
                        EnableToolbar();
                    }
                }
            }
        }
        public void ValidateWood()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                if (!CheckDuplicateBOM()) return;
                if (!IsValidWorkShop())
                    return;

                if (!IsExistProductionNorm())
                    return;

                if (!HaveFocusWood)
                {
                    InvalidateTreeView(fld_tabSemiProductName, false);
                }

                if (IsValidBatchProductItem())
                {

                    ValidateBatchProductWood();
                    if (entity.ValidateBatchProduct())
                    {

                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            item.MMBatchProductItemStatus = BatchProductStatus.Verified.ToString();
                        }
                        UpdateProposalBatchStatus();
                        entity.BatchProductItemList.SaveItemObjects();
                        entity.BatchProductItemList.GridControl?.RefreshDataSource();
                        EnableToolbar();


                    }
                }
                ActionCancel();
            }
        }
        public void ValidatePaint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (!CheckDuplicateBOM()) return;
                if (!IsValidWorkShop())
                    return;

                if (!IsExistProductionNorm())
                    return;

                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                if (!HaveFocusPaint)
                {
                    InvalidateTreeView(fld_tabPaintName, false);
                }

                if (IsValidBatchProductItem() && IsValidBatchProductWoodStatus(BatchProductStatus.Verified.ToString()))
                {

                    ValidateBatchProductPaint();
                    if (entity.ValidateBatchProduct())
                    {

                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            item.MMBatchProductItemStatus = BatchProductStatus.Verified.ToString();
                        }
                        UpdateProposalBatchStatus();

                        EnableToolbar();


                    }
                }
                //  ActionCancel();
            }
        }
        public void ValidatePackaging()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                if (!CheckDuplicateBOM()) return;
                if (!IsValidWorkShop())
                    return;

                if (!IsExistProductionNorm())
                    return;

                if (!HaveFocusPackaging)
                {
                    InvalidateTreeView(fld_tabPackagingName, false);
                }

                if (IsValidBatchProductItem() && IsValidBatchProductWoodStatus(BatchProductStatus.Verified.ToString()))
                {

                    ValidateBatchProductPackaging();
                    if (entity.ValidateBatchProduct())
                    {

                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            item.MMBatchProductItemStatus = BatchProductStatus.Verified.ToString();
                        }
                        UpdateProposalBatchStatus();
                        EnableToolbar();


                    }
                }
                ActionCancel();
            }
        }
        public bool IsValidBatchProductItem()
        {
            bool isValid = true;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
            {
                if (item.FK_MMProductionNormID == 0)
                {
                    isValid = false;
                    break;
                }
            }
            if (!isValid)
            {
                MessageBox.Show(BatchProductLocalizedResources.NotLeftBlankBOMMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isValid;
        }

        #region Update Change BOM
        public void ViewBOMChange(MMBatchProductItemsInfo item, bool isChangeBOM)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (!objBatchProductsInfo.MMBatchProductStatus.Equals(Status.Approved.ToString()) &&
                !objBatchProductsInfo.MMBatchProductWoodStatus.Equals(Status.Approved.ToString()))
            {
                BOSApp.ShowMessage("Trạng thái lệnh sản xuất không phù hợp!");
                return;
            }
            List<string> TypeList = new List<string>();
            if (TabControl != null)
            {
                foreach (XtraTabPage page in TabControl.TabPages)
                {
                    if (page.Name == "fld_tabSemiProduct" && page.PageVisible)
                        TypeList.Add(ProductType.SemiProduct.ToString());
                    else if (page.Name == "fld_tabHardware" && page.PageVisible)
                        TypeList.Add(ProductType.Hardware.ToString());
                    else if (page.Name == "fld_tabPaint" && page.PageVisible)
                        TypeList.Add(ProductType.IngredientPaint.ToString());
                    else if (page.Name == "fld_tabPackaging" && page.PageVisible)
                        TypeList.Add(ProductType.IngredientPackaging.ToString());
                    else if (page.Name == "fld_tbGeneralMaterial" && page.PageVisible)
                        TypeList.Add(ProductType.GeneralMaterial.ToString());

                }
            }
            guiChangeToNeedMerge guiChange = new guiChangeToNeedMerge();
            guiChange.SelectBatchProductItemList.Add(item);
            guiChange.Module = this;
            guiChange.TypeList = TypeList;
            guiChange.isChangeBOM = isChangeBOM;
            if (guiChange.ShowDialog() == DialogResult.OK)
            {
                //Do Nothing
            }
            if (guiChange.IsMerge)
                Invalidate(objBatchProductsInfo.MMBatchProductID);

        }
        #endregion

        public void GenerateBatchProductProductionNormItems(List<MMBatchProductProductionNormItemsInfo> collection, string productType,
                                                                MMBatchProductProductionNormItemsController controller)
        {
            if (collection != null)
            {
                List<MMBatchProductProductionNormItemsInfo> parentBPPNItems;
                if (controller == null)
                    controller = new MMBatchProductProductionNormItemsController();
                foreach (MMBatchProductProductionNormItemsInfo item in collection)
                {
                    controller.InsertBatchProductProductionNormItem(item.MMBatchProductProductionNormItemID, productType, BOSApp.CurrentUser);
                    parentBPPNItems = controller.GetBPPNParentItems(item.MMBatchProductProductionNormItemID);
                    GenerateBatchProductProductionNormItems(parentBPPNItems, productType, controller);
                }
            }
        }

        public string GetBatchProductStatus(string type)
        {
            string status = string.Empty;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (type == ProductType.SemiProduct.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductWoodStatus;
            }
            if (type == ProductType.Hardware.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductHWStatus;
            }
            if (type == ProductType.IngredientPackaging.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductPackagingStatus;
            }
            if (type == ProductType.IngredientPaint.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductPaintStatus;
            }
            if (type == ProductType.Product.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductStatus;
            }
            if (type == ProductType.GeneralMaterial.ToString())
            {
                status = objBatchProductsInfo.MMBatchProductGeneralMaterialStatus;
            }
            return status;
        }

        public bool IsValidProductionNormStatus(string group)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;

            MMBatchProductItemsController bpiCtrl = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> bpiList = new List<MMBatchProductItemsInfo>();
            bpiList = bpiCtrl.CheckProductionNormStatusToBringToBatchProductNotUseCarcass(objBatchProductsInfo.MMBatchProductID, group);
            string errorMessages = string.Empty;
            string strCanceldBOM = string.Empty;
            string strNoApproved = string.Empty;
            switch (group)
            {
                case "SemiProduct":
                    strCanceldBOM = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus == Status.Canceled.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    strNoApproved = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus != Status.Canceled.ToString() && o.WoodStatus != Status.Approved.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    break;
                case "Hardware":
                    strCanceldBOM = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus == Status.Canceled.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    strNoApproved = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus != Status.Canceled.ToString() && o.HardwareStatus != Status.Approved.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    break;
                case "IngredientPaint":
                    strCanceldBOM = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus == Status.Canceled.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    strNoApproved = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus != Status.Canceled.ToString() && o.IngredientPaintStatus != Status.Approved.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    break;
                case "IngredientPackaging":
                    strCanceldBOM = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus == Status.Canceled.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    strNoApproved = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus != Status.Canceled.ToString() && o.IngredientPackagingStatus != Status.Approved.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    break;
                case "GeneralMaterial":
                    strCanceldBOM = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus == Status.Canceled.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    strNoApproved = string.Join(",", bpiList.Where(o => o.MMProductionNormStatus != Status.Canceled.ToString() && o.GeneralMaterialStatus != Status.Approved.ToString()).Select(o => o.MMProductionNormNo).ToArray());
                    break;
            }
            if (!string.IsNullOrWhiteSpace(strCanceldBOM))
            {
                errorMessages = string.Format("Bảng định mức {0} đã ngưng sử dụng.", strCanceldBOM);
                errorMessages += Environment.NewLine;
            }
            if (!string.IsNullOrWhiteSpace(strNoApproved))
            {
                errorMessages += string.Format("Bảng định mức {0} chưa duyệt {1}", strNoApproved, GetDisplay(group));
                errorMessages += Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(errorMessages))
                return true;

            errorMessages += "Vui lòng kiểm tra lại!";
            MessageBox.Show(errorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public string GetDisplay(string group)
        {
            string display = BOSApp.GetDisplayTextFromConfigValue("BatchProductProductionNormItemGroup", group);
            return string.IsNullOrWhiteSpace(display) ? group : display;
        }
        /// <summary>
        /// Approve all items of the BatchProduct
        /// </summary>
        public void ValidateBatchProductWood()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                if (objBatchProductsInfo.MMBatchProductWoodStatus != BatchProductStatus.Approved.ToString())
                {
                    if (!CheckDuplicateBOM()) return;
                    if (!IsValidProductionNormStatus(ProductType.SemiProduct.ToString()))
                    {
                        return;
                    }

                    BOSProgressBar.Start("Đang cập nhật ĐM Bán thành phẩm");
                    BOSTreeList ProductionNormItemList = new BOSTreeList();
                    ProductionNormItemList.InitBOSList(entity,
                                                       null,
                                                       TableName.MMProductionNormItemsTableName,
                                                       BOSTreeList.cstRelationNone);
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    MMBatchProductProductionNormItemMeterialsController objBatchProductProductionNormItemMeterialsController = new MMBatchProductProductionNormItemMeterialsController();
                    //entity.BatchProductProductionNormItemList.Invalidate(objBatchProductProductionNormItemsController.GetItemBySomeConditions(objBatchProductsInfo.MMBatchProductID, ProductType.SemiProduct.ToString(), true));
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    try
                    {
                        objBatchProductProductionNormItemsController
                            .InsertSemiProductByBatchProductID(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                        objBatchProductProductionNormItemMeterialsController.
                            CreateByBatchProductID(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);

                        objBatchProductProductionNormItemMeterialsController.
                            CreateCarcassProcessByBatchProductID(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                        BOSProgressBar.Close();
                    }
                    catch (Exception err)
                    {
                        BOSProgressBar.Close();
                        MessageBox.Show("Có lổi xãy ra khi cập nhập! Vui lòng liên hệ để được hổ trợ." + err.Message
                                            , MESLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                entity.SetPropertyChangeEventLock(false);
                InvalidateTreeView(fld_tabSemiProductName, true);
                entity.RefreshTreeView(entity.BatchProductProductionNormItemList);
                objBatchProductsInfo.MMBatchProductOperationStatus = BatchProductStatus.New.ToString();
                if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.New.ToString())
                {
                    objBatchProductsInfo.MMBatchProductWoodStatus = BatchProductStatus.Verified.ToString();
                    objBatchProductsInfo.FK_HREmployeeIDValidated = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    entity.UpdateMainObject();
                }
                entity.UpdateMainObjectBindingSource();
                EnableToolbar();
                entity.SetPropertyChangeEventLock(true);
            }
        }

        public void ValidateOperation()
        {
            if (!(Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                MessageBox.Show("Vui lòng lưu lệnh sàn xuất trước khi cập nhật", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            MMProductionNormItemOperationsController objProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
            MMBatchProductItemOperationsController objBatchProductItemOperationsController = new MMBatchProductItemOperationsController();
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();

            string errorMess = string.Empty;
            if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.New.ToString())
            {
                MessageBox.Show("Không tồn tại định mức nguyên liệu trong LSX"
                , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (objBatchProductsInfo.MMBatchProductOperationStatus != BatchProductStatus.Approved.ToString())
            {
                foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                {
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo == null || objProductionNormsInfo.MMProductionNormOperationStatus != ProductionNormOperationStatus.Approved.ToString())
                    {
                        if (string.IsNullOrEmpty(errorMess))
                        {
                            errorMess = item.MMBatchProductItemProductNo + " - " + item.MMBatchProductItemProductDesc;
                        }
                        else
                        {
                            errorMess += Environment.NewLine + item.MMBatchProductItemProductNo + " - " + item.MMBatchProductItemProductDesc;
                        }

                        if (objProductionNormsInfo != null)
                        {
                            errorMess += " - " + objProductionNormsInfo.MMProductionNormNo;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(errorMess))
                {
                    MessageBox.Show("Các sản phẩm sau chưa có hoặc chưa duyệt ĐM công đoạn: "
                        + Environment.NewLine + errorMess, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BOSProgressBar.Start("Đang cập nhật ĐM Công đoạn");

                foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                {
                    if (!IsExistOperation(item.FK_MMProductionNormID, item.MMBatchProductItemID))
                    {
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null && objProductionNormsInfo.MMProductionNormOperationStatus == ProductionNormOperationStatus.Approved.ToString())
                        {
                            //Inset Operation and Operation process
                            objBatchProductItemOperationsController.InsertItemFromProductionNormItemOperation(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                            objBatchProductItemOperationInfosController.InsertItemFromProductionNormOperationProcess(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                        }
                    }
                    else
                    {
                        //Delete Operation and Operation process
                        objBatchProductItemOperationsController.DeleteBatchProductItemOperation(item.FK_MMProductionNormID, item.MMBatchProductItemID, BOSApp.CurrentUsersInfo.ADUserName);
                        //Inset Operation and Operation process
                        objBatchProductItemOperationsController.InsertItemFromProductionNormItemOperation(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                        objBatchProductItemOperationInfosController.InsertItemFromProductionNormOperationProcess(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                }
                BOSProgressBar.Close();

            }
        }

        public bool IsExistOperation(int productionNormID, int batchProductItemID)
        {
            bool isExist = false;

            MMBatchProductItemOperationsController objBatchProductItemOperationsController = new MMBatchProductItemOperationsController();
            List<MMBatchProductItemOperationsInfo> currentBatchProductItemsList
                = objBatchProductItemOperationsController.GetBatchProductItemOperationByBatchProductItemIDAndPromotionID(batchProductItemID, productionNormID);
            if (currentBatchProductItemsList != null && currentBatchProductItemsList.Count > 0)
            {
                isExist = true;

            }

            return isExist;
        }

        public void UpdateReferences(MMBatchProductItemsInfo objBatchProductItemInfo)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objBatchProductItemInfo.FK_ARSaleOrderID);
            ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
            if (objSaleOrdersInfo != null)
            {
                if (objSaleOrdersInfo.ARSaleOrderBatchStatus != SaleOrderBatchStatus.Producing.ToString())
                {
                    objSaleOrdersInfo.ARSaleOrderBatchStatus = SaleOrderBatchStatus.Producing.ToString();
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                }
            }
            if (objBatchProductItemInfo.FK_ARProductionPlanningItemID > 0)
            {
                ARProductionPlanningItemsInfo objProductionPlanningItemsInfo = (ARProductionPlanningItemsInfo)objProductionPlanningItemsController.GetObjectByID(objBatchProductItemInfo.FK_ARProductionPlanningItemID);
                if (objProductionPlanningItemsInfo != null)
                {
                    objProductionPlanningItemsInfo.ARProductionPlanningItemProductSerial = objBatchProductItemInfo.MMBatchProductItemProductSerial;
                    objProductionPlanningItemsController.UpdateObject(objProductionPlanningItemsInfo);
                }
            }
        }

        public bool CheckValidProductDesc(string productType)
        {
            bool isValid = true;
            /*
               Kiểm tra nếu có vật tư khác mô tả với master data => Cancel
            */
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();


            string message = string.Empty;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            int countBDM = 1;
            message = "Các mã vật tư sau có mô tả khác mô tả với dữ liệu nguồn:";
            List<int> productionNormIdList = new List<int>();
            foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
            {
                bool isExist = objProductionNormItemsController.IsExistProductBOM(objBatchProductsInfo.MMBatchProductID,
                                                                                item.MMBatchProductItemID,
                                                                                ProductType.Hardware.ToString());
                if (!isExist)
                {
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null && objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Approved.ToString())
                    {
                        if (!productionNormIdList.Contains(objProductionNormsInfo.MMProductionNormID))
                        {
                            productionNormIdList.Add(objProductionNormsInfo.MMProductionNormID);
                            List<MMProductionNormItemsInfo> invalidList = objProductionNormItemsController.GetDescInValidListByProductTypeAndProductionNormID(objProductionNormsInfo.MMProductionNormID, productType);
                            if (invalidList != null && invalidList.Count > 0)
                            {

                                message += Environment.NewLine;
                                message += countBDM + ") " + objProductionNormsInfo.MMProductionNormNo;
                                countBDM++;
                                foreach (MMProductionNormItemsInfo pitem in invalidList)
                                {
                                    message += Environment.NewLine;
                                    message += "- " + pitem.MMProductionNormItemNo + " : " + pitem.MMProductionNormItemProductDesc;

                                }


                                isValid = false;
                            }
                        }
                    }
                }
            }
            if (!isValid)
            {
                MessageBox.Show(message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isValid;
        }

        public void ValidateBatchProductHW()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (CheckValidProductDesc(ProductType.Hardware.ToString()))
                {
                    if (!CheckDuplicateBOM()) return;
                    BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    if (objBatchProductsInfo.MMBatchProductHWStatus != BatchProductStatus.Approved.ToString())
                    {
                        if (!IsValidProductionNormStatus(ProductType.Hardware.ToString()))
                        {
                            return;
                        }

                        MMBatchProductItemsController batchProductItemController = new MMBatchProductItemsController();
                        MMBatchProductProductionNormItemsController batchProductProductionNormItemController = new MMBatchProductProductionNormItemsController();
                        List<MMBatchProductProductionNormItemsInfo> collection = new List<MMBatchProductProductionNormItemsInfo>();
                        List<MMBatchProductProductionNormItemsInfo> rootCollection = new List<MMBatchProductProductionNormItemsInfo>();
                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            bool isExist = batchProductItemController.ProductionNormValidation(objBatchProductsInfo.MMBatchProductID,
                                                                                        item.MMBatchProductItemID,
                                                                                        item.FK_MMProductionNormID,
                                                                                        ProductType.Hardware.ToString());
                            if (isExist)
                            {
                                //batchProductProductionNormItemController.InsertBatchProductProductionNormItemRootNode(item.MMBatchProductItemID, ProductType.Hardware.ToString(), BOSApp.CurrentUser);
                                batchProductProductionNormItemController.InsertBatchProductProductionNormItemRootNodeCarcass(item.MMBatchProductItemID, ProductType.Hardware.ToString(), BOSApp.CurrentUser);

                                rootCollection = batchProductProductionNormItemController.GetBPPNParentItemsRootNode(item.MMBatchProductItemID, ProductType.Hardware.ToString());
                                if (rootCollection != null && rootCollection.Count > 0)
                                {
                                    collection.AddRange(rootCollection);
                                }
                            }
                            item.MMBatchProductItemHardwareStatus = true;

                        }
                        GenerateBatchProductProductionNormItems(collection, ProductType.Hardware.ToString(), batchProductProductionNormItemController);
                        MMBatchProductProductionNormItemHardwaresController objHardwareDetailControler = new MMBatchProductProductionNormItemHardwaresController();
                        objHardwareDetailControler.DeleteHardwareDetail(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUser);
                        objHardwareDetailControler.InsertHardwareDetail(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUser);
                    }

                    entity.SetPropertyChangeEventLock(false);

                    InvalidateTreeView(fld_tabHardwareName, true);
                    entity.RefreshTreeView(entity.ProductionNormItemHardwareList);

                    if (objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.New.ToString())
                    {
                        objBatchProductsInfo.MMBatchProductHWStatus = BatchProductStatus.Verified.ToString();
                        objBatchProductsInfo.FK_HREmployeeIDValidated = BOSApp.CurrentUsersInfo.FK_HREmployeeID;

                        entity.UpdateMainObject();
                    }
                    EnableToolbar();
                    entity.SetPropertyChangeEventLock(true);
                }
            }
        }

        public void ValidateGeneralMaterial()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                if (objBatchProductsInfo.MMBatchProductGeneralMaterialStatus != BatchProductStatus.Approved.ToString())
                {
                    if (!CheckDuplicateBOM()) return;
                    if (!IsValidWorkShop())
                        return;

                    if (!IsExistProductionNorm())
                        return;

                    if (!IsValidProductionNormStatus(ProductType.GeneralMaterial.ToString()) || !IsValidBatchProductWoodStatus(BatchProductStatus.Verified.ToString()))
                        return;

                    MMBatchProductItemsController batchProductItemController = new MMBatchProductItemsController();
                    MMBatchProductProductionNormItemsController batchProductProductionNormItemController = new MMBatchProductProductionNormItemsController();
                    List<MMBatchProductProductionNormItemsInfo> collection = new List<MMBatchProductProductionNormItemsInfo>();
                    List<MMBatchProductProductionNormItemsInfo> rootCollection = new List<MMBatchProductProductionNormItemsInfo>();

                    foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                    {
                        bool isExist = batchProductItemController.ProductionNormValidation(objBatchProductsInfo.MMBatchProductID,
                                                                                    item.MMBatchProductItemID,
                                                                                    item.FK_MMProductionNormID,
                                                                                    ProductType.GeneralMaterial.ToString());
                        if (isExist)
                        {
                            //batchProductProductionNormItemController.InsertBatchProductProductionNormItemRootNode(item.MMBatchProductItemID, ProductType.Hardware.ToString(), BOSApp.CurrentUser);
                            batchProductProductionNormItemController.InsertBatchProductProductionNormItemRootNodeCarcass(item.MMBatchProductItemID, ProductType.GeneralMaterial.ToString(), BOSApp.CurrentUser);

                            rootCollection = batchProductProductionNormItemController.GetBPPNParentItemsRootNode(item.MMBatchProductItemID, ProductType.GeneralMaterial.ToString());
                            if (rootCollection != null && rootCollection.Count > 0)
                            {
                                collection.AddRange(rootCollection);
                            }
                        }
                        item.MMBatchProductItemHardwareStatus = true;

                    }
                    GenerateBatchProductProductionNormItems(collection, ProductType.GeneralMaterial.ToString(), batchProductProductionNormItemController);
                    entity.SetPropertyChangeEventLock(false);
                    InvalidateTreeView(fld_tabGeneralMaterial, true);
                    entity.RefreshTreeView(entity.ProductionNormItemGeneralMaterialList);
                    if (objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.New.ToString())
                    {
                        objBatchProductsInfo.MMBatchProductGeneralMaterialStatus = BatchProductStatus.Verified.ToString();

                        entity.UpdateMainObject();
                    }
                    entity.SetPropertyChangeEventLock(true);
                    EnableToolbar();
                }
            }
        }

        public void UpdateBatchProductPackaging()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;

                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString())
                {

                    ValidateBatchProductPackaging();
                }
            }
        }

        public void ValidateBatchProductPackaging()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                if (objBatchProductsInfo.MMBatchProductPackagingStatus != BatchProductStatus.Approved.ToString())
                {
                    if (!CheckDuplicateBOM()) return;
                    if (!IsValidProductionNormStatus(ProductType.IngredientPackaging.ToString()))
                    {
                        return;
                    }

                    MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    DataSet ds;
                    BOSTreeList ProductionNormItemList = new BOSTreeList();
                    ProductionNormItemList.InitBOSList(entity,
                                                null,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);

                    BOSDbUtil dbUtil = new BOSDbUtil();
                    List<MMBatchProductProductionNormItemsInfo> collection = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.SemiProduct.ToString());
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    MMBatchProductItemsController bpiController = new MMBatchProductItemsController();

                    foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                    {
                        bool isExist = objProductionNormItemsController.IsExistProductBOM(objBatchProductsInfo.MMBatchProductID,
                                                                                             item.MMBatchProductItemID,
                                                                                             ProductType.IngredientPackaging.ToString());
                        ds = objProductionNormItemsController.GetParentOjects(item.FK_MMProductionNormID, ProductType.IngredientPackaging.ToString());
                        ProductionNormItemList.Invalidate(ds);
                        ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                        bool isValidate = objBatchProductProductionNormItemsController.GetExitBatchProductProductionNormItems(item.MMBatchProductItemID,
                                                                                                                   ProductType.IngredientPackaging.ToString());
                        int approveID = 0;
                        if (!isExist && !isValidate)
                        {
                            approveID = InsertProductProductionNormItemPackaging(item, ProductionNormItemList, collection);

                        }
                        else
                        {
                            if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString())
                            {
                                objBatchProductProductionNormItemsController.DeleteBatchProductProductionNormItem(item.FK_MMBatchProductID, item.MMBatchProductItemID, BOSApp.CurrentUsersInfo.ADUserName, ProductType.IngredientPackaging.ToString());
                                approveID = InsertProductProductionNormItemPackaging(item, ProductionNormItemList, collection);

                            }
                        }

                        if (approveID > 0)
                        {
                            entity.SetPropertyChangeEventLock(false);
                            item.FK_MMProductionNormApproveLogIDPackaging = approveID;
                            entity.SetPropertyChangeEventLock(true);
                            bpiController.UpdatePackagingApproveLogID(item.MMBatchProductItemID, approveID);
                        }

                    }
                }
                entity.SetPropertyChangeEventLock(false);
                InvalidateTreeView(fld_tabPackagingName, true);
                entity.RefreshTreeView(entity.ProductionNormItemPackagingList);

                if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.New.ToString())
                {
                    objBatchProductsInfo.MMBatchProductPackagingStatus = BatchProductStatus.Verified.ToString();
                    objBatchProductsInfo.FK_HREmployeeIDValidated = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    entity.UpdateMainObject();
                }
                entity.SetPropertyChangeEventLock(true);
                EnableToolbar();
            }
        }
        public int InsertProductProductionNormItemPackaging(MMBatchProductItemsInfo item, BOSTreeList ProductionNormItemList, List<MMBatchProductProductionNormItemsInfo> semiList)
        {
            int approveID = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            DateTime currentDate = GetServerDate();
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            int roundDec = 6;
            foreach (MMProductionNormItemsInfo objItem in ProductionNormItemList)
            {
                #region Parent item


                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objItem, obj);
                DataRow row = BOSApp.GetObjectFromCatche("ICMeasureUnits", "ICMeasureUnitID", objItem.FK_ICMeasureUnitID);
                ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectFromDataRow(row);
                obj.AACreatedDate = currentDate;
                obj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                obj.MMBatchProductProductionNormItemProductDesc = objItem.MMProductionNormItemProductDesc;
                obj.MMBatchProductProductionNormItemComment = objItem.MMProductionNormItemComment;
                obj.MMBatchProductProductionNormItemProductOverallDimensionHeight = objItem.MMProductionNormItemProductOverallDimensionHeight;
                obj.MMBatchProductProductionNormItemProductOverallDimensionWidth = objItem.MMProductionNormItemProductOverallDimensionWidth;
                obj.MMBatchProductProductionNormItemProductOverallDimensionLength = objItem.MMProductionNormItemProductOverallDimensionLength;
                obj.MMBatchProductProductionNormItemProductInsideDimensionHeight = objItem.MMProductionNormItemProductInsideDimensionHeight;
                obj.MMBatchProductProductionNormItemProductInsideDimensionWidth = objItem.MMProductionNormItemProductInsideDimensionWidth;
                obj.MMBatchProductProductionNormItemProductInsideDimensionLength = objItem.MMProductionNormItemProductInsideDimensionLength;
                obj.MMBatchProductProductionNormItemPackagingGW = objItem.MMProductionNormItemPackagingGW;
                obj.MMBatchProductProductionNormItemPackagingNW = objItem.MMProductionNormItemPackagingNW;
                obj.FK_ICProductAttributeSpecialityID = objItem.FK_ICProductAttributeSpecialityID;
                if (objMeasureUnitsInfo != null) roundDec = objMeasureUnitsInfo.ICMeasureUnitRoundNumInBatchProduct;
                obj.MMBatchProductProductionNormItemQuantity = Math.Round( obj.MMBatchProductProductionNormItemQuantity * item.MMBatchProductItemProductQty, roundDec, MidpointRounding.AwayFromZero);
                obj.MMBatchProductProductionNormItemQuantityPerOne = objItem.MMProductionNormItemQuantity;
                obj.MMBatchProductProductionNormItemTotalQuantity *= item.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemProductName = objItem.MMProductionNormItemProductName;
                obj.MMBatchProductProductionNormItemProductSupplierNumber = objItem.MMProductionNormItemProductSupplierNumber;

                obj.FK_MMProductionNormItemID = objItem.MMProductionNormItemID;
                obj.FK_MMBatchProductItemID = item.MMBatchProductItemID;
                obj.FK_ICProductForBatchID = item.FK_ICProductID;
                obj.FK_MMBatchProductID = item.FK_MMBatchProductID;
                if (semiList != null)
                {
                    MMBatchProductProductionNormItemsInfo objParent = semiList.Where(o => o.FK_MMBatchProductItemID == item.MMBatchProductItemID
                                                                                       && o.FK_MMProductionNormItemID == objItem.FK_MMSemiProductID
                                                                                       && o.MMBatchProductProductionNormItemGroup == "SemiProduct"
                    ).FirstOrDefault();
                    obj.FK_MMBPSemiProductID = objParent != null ? objParent.MMBatchProductProductionNormItemID : 0;
                }
                obj.MMBatchProductProductionNormItemNeededTime = objBatchProductsInfo.MMBatchProductFromDate;
                obj.FK_MMProductionNormApproveLogID = objItem.ApproveLogID;
                approveID = objItem.ApproveLogID;
                objBatchProductProductionNormItemsController.CreateObject(obj);
                #endregion
                #region SubList child item
                if (obj.MMBatchProductProductionNormItemID > 0)
                {
                    objBatchProductProductionNormItemsController.InsertBatchProductProductionNormItemPackaging(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID
                        , BOSApp.CurrentUsersInfo.ADUserName, item.MMBatchProductItemProductQty
                        , obj.MMBatchProductProductionNormItemID, obj.FK_MMProductionNormItemID
                        , item.FK_ICProductID, item.MMBatchProductItemProductSerial, objBatchProductsInfo.MMBatchProductFromDate);
                }
                #endregion
            }
            return approveID;
        }
        /// <summary>
        /// Approve all items of the BatchProduct
        /// </summary>
        public void ValidateBatchProductPaint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (CheckValidProductDesc(ProductType.IngredientPaint.ToString()))
                {
                    BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;

                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    if (objBatchProductsInfo.MMBatchProductPaintStatus != BatchProductStatus.Approved.ToString())
                    {
                        if (!CheckDuplicateBOM()) return;
                        if (!IsValidProductionNormStatus(ProductType.IngredientPaint.ToString()))
                        {
                            return;
                        }

                        MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();

                        BOSTreeList ProductionNormItemList = new BOSTreeList();
                        ProductionNormItemList.InitBOSList(entity,
                                                    null,
                                                    TableName.MMProductionNormItemsTableName,
                                                    BOSTreeList.cstRelationNone);

                        MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                        #region Insert
                        foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                        {
                            bool isExist = objProductionNormItemsController.IsExistProductBOM(objBatchProductsInfo.MMBatchProductID,
                                                                                            item.MMBatchProductItemID,
                                                                                            ProductType.IngredientPaint.ToString());
                            if (!isExist)
                            {

                                objBatchProductProductionNormItemsController.InsertBatchProductProductionNormItemPaint(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName,
                                        item.MMBatchProductItemProductQty, item.FK_ICProductID, item.MMBatchProductItemProductSerial, objBatchProductsInfo.MMBatchProductFromDate);

                            }
                            else
                            {
                                if (objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString())
                                {
                                    objBatchProductProductionNormItemsController.DeleteBatchProductProductionNormItem(item.FK_MMBatchProductID, item.MMBatchProductItemID, BOSApp.CurrentUsersInfo.ADUserName, ProductType.IngredientPaint.ToString());
                                    objBatchProductProductionNormItemsController.InsertBatchProductProductionNormItemPaint(item.FK_MMProductionNormID, item.MMBatchProductItemID, item.FK_MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName,
                                        item.MMBatchProductItemProductQty, item.FK_ICProductID, item.MMBatchProductItemProductSerial, objBatchProductsInfo.MMBatchProductFromDate);
                                }

                            }
                            #endregion

                        }
                        //MMBatchProductProductionNormItemMeterialsController objBatchProductProductionNormItemMeterialsController = new MMBatchProductProductionNormItemMeterialsController();
                        //objBatchProductProductionNormItemMeterialsController.
                        //    CreateCarcassProcessByBatchProductID(objBatchProductsInfo.MMBatchProductID, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                    entity.SetPropertyChangeEventLock(false);
                    InvalidateTreeView(fld_tabPaintName, true);
                    entity.RefreshTreeView(entity.ProductionNormItemPaintList);
                    if (objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.New.ToString())
                    {
                        objBatchProductsInfo.MMBatchProductPaintStatus = BatchProductStatus.Verified.ToString();
                        entity.UpdateMainObject();
                    }
                    entity.SetPropertyChangeEventLock(true);
                    EnableToolbar();
                }
            }
        }

        public override void ActionPrint()
        {
            base.ActionPrint();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (Toolbar.IsEditAction() || Toolbar.IsNewAction())
            {
                return;
            }
            if (!HaveFocusWood)
            {
                InvalidateTreeView(fld_tabSemiProductName, false);
            }
            if (!HaveFocusPaint)
            {
                InvalidateTreeView(fld_tabPaintName, false);
            }
            if (!HaveFocusPackaging)
            {
                InvalidateTreeView(fld_tabPackagingName, false);
            }
            if (!HaveFocusHardware)
            {
                InvalidateTreeView(fld_tabHardwareName, false);
            }
            BOSReport.RPBatchProduct report = new BOSReport.RPBatchProduct();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ICProductsController objProductsController = new ICProductsController();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMLinesController objLineController = new MMLinesController();
            MMOperationsController objOperationController = new MMOperationsController();
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            MMProductionNormsInfo objProductionNormsInfo = new MMProductionNormsInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = new ARCustomersInfo();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
                objBatchProductsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;

            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeHWApprove);
            if (objEmployeesInfo != null)
                objBatchProductsInfo.HREmployeeNameApproved = objEmployeesInfo.HREmployeeName;

            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
            if (objEmployeesInfo != null)
                objBatchProductsInfo.HREmployeeNameValidated = objEmployeesInfo.HREmployeeName;

            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();

            objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("BatchProductStatus", objBatchProductsInfo.MMBatchProductStatus);
            if (objConfigValuesInfo != null)
            {
                objBatchProductsInfo.MMBatchProductStatusText = objConfigValuesInfo.ADConfigText;
            }

            if (objBatchProductsInfo.FK_ARCustomerID > 0)
            {
                objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objBatchProductsInfo.FK_ARCustomerID);
                if (objCustomersInfo != null)
                {
                    objBatchProductsInfo.ARCustomerNo = objCustomersInfo.ARCustomerNo;
                    objBatchProductsInfo.ARCustomerName = objCustomersInfo.ARCustomerName;
                }
            }
            if (objBatchProductsInfo.FK_ARSaleOrderID > 0)
            {
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objBatchProductsInfo.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    objBatchProductsInfo.MMBatchProductSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                }
            }
            List<MMBatchProductItemsInfo> BatchProductItemList = new List<MMBatchProductItemsInfo>();

            BatchProductItemList = (List<MMBatchProductItemsInfo>)entity.BatchProductItemList.Clone();

            MMLinesInfo objLinesInfo = new MMLinesInfo();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();

            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrThue"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyTaxNumber;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachihoadon"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrDiachinhamay"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrWebsite"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyWebsite;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrEmail"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyEmail;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCellphone"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyCellPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrCompanyphone"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyPhone;
                }
            }

            report.bindingSource1.DataSource = objBatchProductsInfo;
            report.bindingSource2.DataSource = BatchProductItemList;
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }
        #endregion
        #region Operation

        public void InitOperationDataRow(List<MMBatchProductItemOperationsInfo> operationList)
        {
            if (OperationDataTable == null)
            {
                OperationDataTable = new DataTable();
            }

            OperationDataTable.Rows.Clear();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            MMProductionNormsInfo objProductionNormsInfo;
            List<MMProductionNormItemsInfo> productionNormItemList = new List<MMProductionNormItemsInfo>();
            if (!HaveFocusWood)
            {
                InvalidateTreeView(fld_tabSemiProductName, false);
            }
            foreach (MMBatchProductProductionNormItemsInfo mainItem in entity.BatchProductProductionNormItemList)
            {
                string ProductSerial = string.Empty;
                objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(mainItem.FK_MMBatchProductItemID);
                if (objBatchProductItemsInfo != null && objBatchProductItemsInfo.FK_MMProductionNormID > 0)
                {
                    ProductSerial = objBatchProductItemsInfo.MMBatchProductItemProductSerial;
                }
                #region Add product for receipt opertion has product
                if (mainItem.MMBatchProductProductionNormItemGroup == "Product")
                {
                    if (mainItem.FK_MMProductionNormID == 0)
                    {
                        if (mainItem.FK_MMBatchProductItemID > 0)
                        {
                            if (objBatchProductItemsInfo != null && objBatchProductItemsInfo.FK_MMProductionNormID > 0)
                            {
                                mainItem.FK_MMProductionNormID = objBatchProductItemsInfo.FK_MMProductionNormID;
                            }
                        }
                    }
                    objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(mainItem.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        DataRow rowParent = OperationDataTable.NewRow();
                        rowParent["MMProductionNormNo"] = objProductionNormsInfo.MMProductionNormNo;
                        rowParent["MMBatchProductItemProductSerial"] = ProductSerial;
                        rowParent["MMProductionNormItemNo"] = mainItem.MMBatchProductProductionNormItemNo;
                        rowParent["FK_MMProductionNormItemID"] = mainItem.FK_MMProductionNormItemID;
                        rowParent["FK_MMBatchProductProductionNormItemID"] = mainItem.MMBatchProductProductionNormItemID;
                        rowParent["FK_MMProductionNormID"] = mainItem.FK_MMProductionNormID;
                        rowParent["MMProductionNormItemProductName"] = mainItem.MMBatchProductProductionNormItemProductName;
                        rowParent["FK_ICProductID"] = mainItem.FK_ICProductID;
                        rowParent["MMProductionNormItemProductWoodType"] = mainItem.MMBatchProductProductionNormItemProductWoodType;
                        rowParent["FK_MMBatchProductID"] = objBatchProductsInfo.MMBatchProductID;
                        rowParent["FK_MMBatchProductItemID"] = mainItem.FK_MMBatchProductItemID;
                        OperationDataTable.Rows.Add(rowParent);
                    }
                }
                #endregion

                foreach (MMBatchProductProductionNormItemsInfo batchProductProductionNormItemsInfo in mainItem.SubList)
                {

                    objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(batchProductProductionNormItemsInfo.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        DataRow row = OperationDataTable.NewRow();
                        row["MMProductionNormNo"] = objProductionNormsInfo.MMProductionNormNo;
                        row["MMBatchProductItemProductSerial"] = ProductSerial;
                        row["MMProductionNormItemNo"] = batchProductProductionNormItemsInfo.MMBatchProductProductionNormItemNo;
                        row["FK_MMProductionNormItemID"] = batchProductProductionNormItemsInfo.FK_MMProductionNormItemID;
                        row["FK_MMBatchProductProductionNormItemID"] = batchProductProductionNormItemsInfo.MMBatchProductProductionNormItemID;
                        row["FK_MMProductionNormID"] = batchProductProductionNormItemsInfo.FK_MMProductionNormID;
                        row["MMProductionNormItemProductName"] = batchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductName;
                        row["FK_ICProductID"] = batchProductProductionNormItemsInfo.FK_ICProductID;
                        row["MMProductionNormItemProductWoodType"] = batchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductWoodType;
                        row["FK_MMBatchProductID"] = objBatchProductsInfo.MMBatchProductID;
                        row["FK_MMBatchProductItemID"] = batchProductProductionNormItemsInfo.FK_MMBatchProductItemID;
                        OperationDataTable.Rows.Add(row);

                        if (batchProductProductionNormItemsInfo.SubList != null && batchProductProductionNormItemsInfo.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo item in batchProductProductionNormItemsInfo.SubList)
                            {
                                DataRow subRow = OperationDataTable.NewRow();
                                subRow["MMProductionNormNo"] = objProductionNormsInfo.MMProductionNormNo;
                                subRow["MMBatchProductItemProductSerial"] = ProductSerial;
                                subRow["MMProductionNormItemNo"] = item.MMBatchProductProductionNormItemNo;
                                subRow["FK_MMProductionNormItemID"] = item.FK_MMProductionNormItemID;
                                subRow["FK_MMBatchProductProductionNormItemID"] = item.MMBatchProductProductionNormItemID;
                                subRow["FK_MMProductionNormID"] = batchProductProductionNormItemsInfo.FK_MMProductionNormID;
                                subRow["MMProductionNormItemProductName"] = item.MMBatchProductProductionNormItemProductName;
                                subRow["FK_ICProductID"] = item.FK_ICProductID;
                                subRow["MMProductionNormItemProductWoodType"] = item.MMBatchProductProductionNormItemProductWoodType;
                                subRow["FK_MMBatchProductID"] = objBatchProductsInfo.MMBatchProductID;
                                subRow["FK_MMBatchProductItemID"] = item.FK_MMBatchProductItemID;
                                OperationDataTable.Rows.Add(subRow);
                            }
                        }
                    }
                }
            }

            foreach (DataRow row in OperationDataTable.Rows)
            {
                foreach (int id in OperationIDList)
                {
                    if (row[id.ToString()] != null)
                    {
                        row[id.ToString()] = "N";
                    }
                }
                int icproductID = 0;
                int batchProductItemID = 0;
                if (int.TryParse(row["FK_MMBatchProductItemID"].ToString(), out batchProductItemID))
                {
                    if (int.TryParse(row["FK_ICProductID"].ToString(), out icproductID))
                    {
                        for (int i = 0; i < operationList.Count; i++)
                        {
                            if (operationList[i].FK_ICProductID == icproductID
                                && operationList[i].FK_MMBatchProductItemID == batchProductItemID)
                            {
                                if (OperationDataTable.Columns.Contains(operationList[i].FK_MMOperationID.ToString()) && OperationDataTable.Columns[operationList[i].FK_MMOperationID.ToString()] != null)
                                {
                                    if (row[operationList[i].FK_MMOperationID.ToString()] != null)
                                    {
                                        row[operationList[i].FK_MMOperationID.ToString()] = "Y";
                                    }
                                }
                                // operationList.RemoveAt(i--);
                            }

                        }
                    }
                }
            }
        }

        public void GenerateGridBandAndColumnByOperation(MMOperationsInfo objOperationsInfo, MMOperationsController objOperationsController, GridBand gridBand, BandedGridView banded)
        {
            List<MMOperationsInfo> operationChildList = objOperationsController.GetAllOperationsByParentID(objOperationsInfo.MMOperationID);

            if (operationChildList != null && operationChildList.Count > 0)
            {
                foreach (MMOperationsInfo item in operationChildList)
                {
                    List<MMOperationsInfo> operationSubChildList = objOperationsController.GetAllOperationsByParentID(item.MMOperationID);
                    if (operationSubChildList != null && operationSubChildList.Count > 0)
                    {
                        GridBand gridBandChild = new GridBand();
                        gridBandChild.Caption = item.MMOperationName;
                        gridBand.Children.Add(gridBandChild);
                        GenerateGridBandAndColumnByOperation(item, objOperationsController, gridBandChild, banded);
                    }
                    else
                    {
                        CreateBandedColumnOperation(item.MMOperationName, item.MMOperationID.ToString(), true, true, gridBand, banded);
                        OperationDataTable.Columns.Add(item.MMOperationID.ToString());
                    }
                }
            }
            CreateBandedColumnOperation(objOperationsInfo.MMOperationName, objOperationsInfo.MMOperationID.ToString(), true, true, gridBand, banded);
            OperationDataTable.Columns.Add(objOperationsInfo.MMOperationID.ToString());
        }

        public void CreateBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.Fixed = FixedStyle.Left;
            column.MinWidth = 100;
            if (fieldName == "MMBatchProductItemProductSerial")
            {
                column.Group();
            }
            banded.Columns.Add(column);
        }

        public void CreateBandedColumnOperation(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            if (ownerBand != null)
            {
                column.OwnerBand = ownerBand;
            }
            column.MinWidth = 100;
            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectnew = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            column.ColumnEdit = selectnew;
            selectnew.NullText = "";
            selectnew.ValueChecked = "Y";
            selectnew.ValueUnchecked = "N";
            selectnew.ValueGrayed = "-";
            banded.Columns.Add(column);

            int id = 0;
            if (int.TryParse(fieldName, out id))
            {
                OperationIDList.Add(id);
            }
        }

        public BandedGridView GenerateBandedGridView()
        {
            OperationIDList = new List<int>();

            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = false;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;



            OperationDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            banded.Bands.Add(generalBand);
            generalBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;


            //CreateBandedColumn("BĐM", "MMProductionNormNo", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormNo");

            CreateBandedColumn("Mã lô SX", "MMBatchProductItemProductSerial", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMBatchProductItemProductSerial");

            //Mã chi tiết
            CreateBandedColumn("Mã chi tiết", "MMProductionNormItemNo", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemNo");
            OperationDataTable.Columns.Add("FK_MMProductionNormItemID");
            OperationDataTable.Columns.Add("FK_MMBatchProductProductionNormItemID");
            OperationDataTable.Columns.Add("FK_MMProductionNormID");
            //Tên chi tiết
            CreateBandedColumn("Tên chi tiết", "MMProductionNormItemProductName", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemProductName");

            OperationDataTable.Columns.Add("FK_ICProductID");
            //Loại gỗ
            //CreateBandedColumn("Loại gỗ", "MMProductionNormItemProductWoodType", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemProductWoodType");
            //Batch Product Info
            OperationDataTable.Columns.Add("FK_MMBatchProductItemID");
            OperationDataTable.Columns.Add("FK_MMBatchProductID");
            OperationDataTable.Columns.Add("FK_MMBatchProductItemOperationID");
            //Routing ticket 
            CreateReposityBandedColumn("Chi tiết", "MMProductionNormItemRoutingTicket", true, false, generalBand, banded);
            #endregion

            #region Công đoạn
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationList = objOperationsController.GetAllOperationsByParentID(0);
            if (operationList != null && operationList.Count > 0)
            {

                foreach (MMOperationsInfo objOperationsInfo in operationList)
                {
                    List<MMOperationsInfo> operationChildList = objOperationsController.GetAllOperationsByParentID(objOperationsInfo.MMOperationID);
                    if (operationChildList != null && operationChildList.Count > 0)
                    {
                        GridBand gridBand = new GridBand();
                        gridBand.Caption = objOperationsInfo.MMOperationName;
                        banded.Bands.Add(gridBand);
                        GenerateGridBandAndColumnByOperation(objOperationsInfo, objOperationsController, gridBand, banded);
                    }
                    else
                    {
                        GridBand otherBand = new GridBand();
                        otherBand.Caption = objOperationsInfo.MMOperationName;
                        banded.Bands.Add(otherBand);
                        GenerateGridBandAndColumnByOperation(objOperationsInfo, objOperationsController, otherBand, banded);
                    }
                }
            }


            #endregion
            // banded.BestFitColumns();
            banded.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(banded_RowCellStyle);
            banded.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(banded_CellValueChanged);
            banded.RowCellClick += new RowCellClickEventHandler(banded_RowCellClick);
            return banded;
        }
        public void CreateReposityBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;

            column.OwnerBand = ownerBand;
            column.Fixed = FixedStyle.Left;
            RepositoryItemHyperLinkEdit ViewDetail = new RepositoryItemHyperLinkEdit();
            ViewDetail.NullText = ProductionNormLocalizeResources.ViewRouting;
            column.ColumnEdit = ViewDetail;
            column.OptionsColumn.AllowEdit = false;
            column.MinWidth = 75;
            banded.Columns.Add(column);
        }
        void banded_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionNormItemRoutingTicket")
            {
                ViewDetail_Click(sender);
            }
        }
        public void ViewDetail_Click(object sender)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            BandedGridView view = sender as BandedGridView;
            if (view.FocusedRowHandle >= 0)
            {
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                if (row != null)
                {
                    if (row["FK_MMBatchProductProductionNormItemID"] != null)
                    {
                        int FK_MMBatchProductProductionNormItemID = 0;
                        if (int.TryParse(row["FK_MMBatchProductProductionNormItemID"].ToString(), out FK_MMBatchProductProductionNormItemID))
                        {
                            MMBatchProductItemOperationInfosInfo objProductionNormItemOperationsInfo = new MMBatchProductItemOperationInfosInfo();
                            foreach (MMBatchProductProductionNormItemsInfo itemProductionNorm in entity.BatchProductProductionNormItemList)
                            {
                                if (itemProductionNorm.MMBatchProductProductionNormItemID == FK_MMBatchProductProductionNormItemID)
                                {
                                    objProductionNormItemOperationsInfo.FK_MMBatchProductProductionNormItemID = itemProductionNorm.MMBatchProductProductionNormItemID;
                                    objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = itemProductionNorm.FK_MMProductionNormItemID;
                                    break;
                                }
                                if (itemProductionNorm.SubList != null)
                                {
                                    foreach (MMBatchProductProductionNormItemsInfo item in itemProductionNorm.SubList)
                                    {
                                        if (item.MMBatchProductProductionNormItemID == FK_MMBatchProductProductionNormItemID)
                                        {
                                            objProductionNormItemOperationsInfo.FK_MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemID;
                                            objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = item.FK_MMProductionNormItemID;
                                            break;
                                        }
                                        if (item.SubList != null)
                                        {
                                            foreach (MMBatchProductProductionNormItemsInfo itemsub in item.SubList)
                                            {
                                                if (itemsub.MMBatchProductProductionNormItemID == FK_MMBatchProductProductionNormItemID)
                                                {
                                                    objProductionNormItemOperationsInfo.FK_MMBatchProductProductionNormItemID = itemsub.MMBatchProductProductionNormItemID;
                                                    objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = itemsub.FK_MMProductionNormItemID;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }


                            if (objProductionNormItemOperationsInfo != null && objProductionNormItemOperationsInfo.FK_MMBatchProductProductionNormItemID > 0)
                            {
                                if (Toolbar.IsNullOrNoneAction())
                                {
                                    List<MMBatchProductItemOperationInfosInfo> listOperation = objBatchProductItemOperationInfosController.GetOperationProcesssByBatchProductProductionNormItem(
                                        objProductionNormItemOperationsInfo.FK_MMBatchProductProductionNormItemID);
                                    guiProductionNormOperationProcessInfos guiForm = new guiProductionNormOperationProcessInfos(objProductionNormItemOperationsInfo, listOperation);
                                    guiForm.Text = "Quy trình sản xuất chi tiết";
                                    guiForm.Module = this;
                                    guiForm.ShowDialog();
                                }
                                else
                                    MessageBox.Show(ProductionNormLocalizeResources.PleaseSaveOperationBeforeUpdateDetail, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
        }
        void banded_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductOperationStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();
            }
        }
        void banded_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            BandedGridView View = sender as BandedGridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMProductionNormItemNo")
                {
                    string itemNo = e.CellValue.ToString();
                    foreach (DataRow row in OperationDataTable.Rows)
                    {
                        if (row["MMProductionNormItemNo"] != null)
                        {
                            if (row["MMProductionNormItemNo"].ToString() == itemNo)
                            {
                                int productID = 0;
                                if (row["FK_ICProductID"] != null)
                                {
                                    if (int.TryParse(row["FK_ICProductID"].ToString(), out productID))
                                    {

                                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                                        if (objProductsInfo != null && objProductsInfo.HasComponent)
                                        {
                                            //e.Appearance.ParentAppearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                                            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                                            break;
                                        }
                                        else
                                        {
                                            List<ICProductItemsInfo> objProductItemList = (List<ICProductItemsInfo>)objProductItemsController.GetProductItemByChildID(productID);
                                            if (objProductItemList != null && objProductItemList.Count > 0)
                                            {

                                                int batchProductItemID = 0;
                                                if (row["FK_MMBatchProductItemID"] != null)
                                                {
                                                    if (int.TryParse(row["FK_MMBatchProductItemID"].ToString(), out batchProductItemID))
                                                    {
                                                        MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(batchProductItemID);
                                                        if (objBatchProductItemsInfo != null && objBatchProductItemsInfo.FK_MMProductionNormID > 0)
                                                        {
                                                            if (objProductItemList[0].FK_ICProductItemParentID == objBatchProductItemsInfo.FK_ICProductID)
                                                            {
                                                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                                                                break;
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion
        public DataTable GetFormulaTable()
        {
            MMFormulasController objFormulasController = new MMFormulasController();
            DataSet ds = objFormulasController.GetFormulaData();
            DataTable dt = new DataTable();
            if (ds != null)
                dt = ds.Tables[0];
            return dt;
        }

        #region Summary
        public decimal GetSumProductionNormItemQty()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemQuantity;
                    }
                }
            }
            return result;
        }
        public decimal GetSumProductionNormItemBlocks()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemWoodBlocks;
                    }
                }
            }
            return Math.Round(result, 5);
        }
        public decimal GetSumProductionNormItemWoodConsumable()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        if (itemChild.SubList != null && itemChild.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo itemCChild in itemChild.SubList)
                            {
                                result += itemCChild.MMBatchProductProductionNormItemTotalWoodConsumable;
                            }
                        }
                        else
                        {
                            result += itemChild.MMBatchProductProductionNormItemTotalWoodConsumable;
                        }

                    }
                }
            }
            return Math.Round(result, 5);
        }

        public decimal GetSumProductionNormItemMDFBlock()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemMDFBlocks;
                    }
                }
            }
            return Math.Round(result, 5);
        }
        public decimal GetSumProductionNormItemPaintA()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemPaintA;
                    }
                }
            }
            return Math.Round(result, 4);
        }
        public decimal GetSumProductionNormItemPaintB()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemPaintB;
                    }
                }
            }
            return Math.Round(result, 4);
        }
        public decimal GetSumProductionNormItemVeneer()
        {
            decimal result = 0;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMBatchProductProductionNormItemVeneer;
                    }
                }
            }
            return Math.Round(result, 5);
        }
        #endregion

        public void ApproveBatchProductPaint()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (!CheckDuplicateBOM()) return;
            if (!IsValidWorkShop())
                return;

            if (!IsValidBatchProductWoodStatus(BatchProductStatus.Approved.ToString()))
                return;

            entity.ApprovePaint();
            EnableToolbar();
        }

        public void ApproveBatchProductHW()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (!CheckDuplicateBOM()) return;
            if (!IsValidWorkShop())
                return;

            if (!IsValidBatchProductWoodStatus(BatchProductStatus.Approved.ToString()))
                return;

            entity.ApproveHW();
            EnableToolbar();
        }

        public void ApproveBatchProductGeneralMaterial()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (!CheckDuplicateBOM()) return;
            if (!IsValidWorkShop())
                return;

            if (!IsValidBatchProductWoodStatus(BatchProductStatus.Approved.ToString()))
                return;

            entity.ApproveGeneralMaterial();
            EnableToolbar();
        }

        public void ApproveBatchProductPackaging()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (!CheckDuplicateBOM()) return;
            if (!IsValidWorkShop())
                return;

            if (!IsValidBatchProductWoodStatus(BatchProductStatus.Approved.ToString()))
                return;

            entity.ApprovePackaging();
            EnableToolbar();
        }

        public void ApproveBatchProductWood()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (!CheckDuplicateBOM()) return;
            if (!IsValidWorkShop())
                return;

            entity.SetPropertyChangeEventLock(false);
            entity.ApproveWood();
            if (objBatchProductsInfo.FK_ARProductionPlanningID > 0)
            {
                foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
                {
                    UpdateReferences(item);
                }
            }
            entity.SetPropertyChangeEventLock(true);
            EnableToolbar();
        }

        public bool CheckExitsProductionPlanning(int roductionPlanningID)
        {
            bool result = true;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            if (objBatchProductsInfo.MMBatchProductID == 0)
            {
                DataSet ds = objBatchProductsController.GetAllDataByForeignColumn("FK_ARProductionPlanningID", roductionPlanningID);
                List<MMBatchProductsInfo> listExit = (List<MMBatchProductsInfo>)objBatchProductsController.GetListFromDataSet(ds);
                if (listExit != null && listExit.Count > 0)
                {
                    MMBatchProductsInfo itemExit = listExit.Where(x => x.MMBatchProductID != objBatchProductsInfo.MMBatchProductID).FirstOrDefault();
                    if (itemExit != null && itemExit.MMBatchProductID > 0)
                    {
                        MessageBox.Show(string.Format("Kế hoạch giao hàng đã tạo lệnh SX {0}", itemExit.MMBatchProductNo),
                                             MESLocalizedResources.MessageBoxDefaultCaption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        result = false;
                    }
                }
            }
            return result;
        }

        public void ApproveBatchProductOperation()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.CheckCanApproveOperation())
            {
                entity.ApproveOperation();
                ActionCancel();
                EnableToolbar();
            }
        }

        public void EditBatchProducProductionNormItemWood()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductWoodStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();

                MMBatchProductProductionNormItemsInfo objCurrentItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
                if (objCurrentItemsInfo != null)
                {
                    CalculateProductionNormItemWoodType(objCurrentItemsInfo);

                    entity.BatchProductProductionNormItemList.TreeListControl.RefreshDataSource();
                    entity.BatchProductProductionNormItemList.TreeListControl.ExpandAll();
                    entity.BatchProductProductionNormItemList.TreeListControl.BestFitColumns();
                }
            }
        }

        #region Export & Print
        public void ExportSemiProduct()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchproductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusWood)
                    {
                        InvalidateTreeView(fld_tabSemiProductName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeWoodApprove);

                    foreach (MMBatchProductItemsInfo item in batchproductItemList)
                    {
                        SetGeneralItemInfo(item);
                        //set ARCustomerName
                        if (string.IsNullOrEmpty(item.ARCustomerName))
                            item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormDepreciationRate = objProductionNormsInfo.MMProductionNormDepreciationRate;
                        }
                        //set MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }

                        List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetSemiProductByBatchProductItemID(item.FK_MMBatchProductID, item.MMBatchProductItemID);
                        if (MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                            parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                            if (parentList != null)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                                {
                                    if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                    }
                                    item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                    List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList
                                        .Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                                    
                                    if (childList != null)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                        {
                                            item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                            GetNode(childNode, MMBatchProductProductionNormItemsSemiProductList, item);
                                        }
                                    }
                                }
                            }
                        }
                        //objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                            {
                                ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                                if (objAttributesInfo != null)
                                {
                                    Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                                }

                                if (item.MMBatchProductProductionNormItemsSemiProductList.Any(o => o.MMBatchProductProductionNormItemParentID == Item.MMBatchProductProductionNormItemID))
                                    Item.HasComponent = true;
                                else
                                    Item.HasComponent = false;
                            }
                        }

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                            item.ARCustomerName = item.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault().ARCustomerName;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                    string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                    bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                    bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                    if (isHappy)
                    {
                        RPBatchProductExcelSemiProductHP report = new RPBatchProductExcelSemiProductHP(productionNormItemTotalQty);
                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();

                        batchproductItemList.ForEach(o =>
                        {
                            if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                            {
                                //o.MMBatchProductProductionNormItemsSemiProductList = o.MMBatchProductProductionNormItemsSemiProductList.OrderBy(i => i.ICProductCode).ToList();
                                o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                {
                                    Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                    mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mItem != null)
                                    {
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                        x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                        x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                        x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                        x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                        x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                    }
                                    mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mProcesssItem != null)
                                    {
                                        x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                    }
                                });
                            }
                        });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else if (isBKV)
                    {
                        RPBatchProductExcelSemiProductBKV report = new RPBatchProductExcelSemiProductBKV(productionNormItemTotalQty);
                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();
                        ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                        ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

                        batchproductItemList.ForEach(o =>
                        {
                            if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                            {
                                //o.MMBatchProductProductionNormItemsSemiProductList = o.MMBatchProductProductionNormItemsSemiProductList.OrderBy(i => i.ICProductCode).ToList();
                                o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                {
                                    Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                    mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mItem != null)
                                    {
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                        x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                        x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                        x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                        x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                        x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        ICProductsForViewInfo objProductsForViewInfo = BOSApp.CurrentProductList.Where(y => y.ICProductID == mItem.FK_ICProductID).FirstOrDefault();
                                        if (objProductsForViewInfo != null)
                                        {
                                            x.MMBatchProductProductionNormItemMeterialNo = objProductsForViewInfo.ICProductNo;
                                            x.MMBatchProductProductionNormItemMeterialDesc = mItem.MMBatchProductProductionNormItemMeterialDesc;

                                            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(mItem.FK_ICMeasureUnitID);
                                            if (objMeasureUnitsInfo != null)
                                            {
                                                x.MMBatchProductProductionNormItemMeterialMeasureUnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                                            }
                                        }
                                    }
                                    mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mProcesssItem != null)
                                    {
                                        x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                    }
                                });
                            }
                        });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else
                    {
                        RPBatchProductExcelSemiProduct report = new RPBatchProductExcelSemiProduct(productionNormItemTotalQty);
                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();
                        ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                        ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();

                        string stisTH = ADConfigValueUtility.GetConfigTextByGroupAndValue("ProjectTH", "true");
                        bool isTH = bool.Parse(stisTH != string.Empty ? stisTH : "false");
                        if (isTH)
                        {
                            batchproductItemList.ForEach(o =>
                            {
                                if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                                {
                                    //o.MMBatchProductProductionNormItemsSemiProductList = o.MMBatchProductProductionNormItemsSemiProductList.OrderBy(i => i.ICProductCode).ToList();
                                    o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                    {
                                        x.MMBatchProductProductionNormItemBlockPerOne = x.MMBatchProductProductionNormItemBlockPerOne * x.MMBatchProductProductionNormItemQuantityPerOne;
                                        x.MMBatchProductProductionNormItemWoodBlocks = x.MMBatchProductProductionNormItemWoodBlocks * x.MMBatchProductProductionNormItemQuantityPerOne;
                                    });
                                }
                            });
                        }

                        batchproductItemList.ForEach(o =>
                            {
                                if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                                {
                                    //o.MMBatchProductProductionNormItemsSemiProductList = o.MMBatchProductProductionNormItemsSemiProductList.OrderBy(i => i.ICProductCode).ToList();
                                    o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                    {
                                        Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                        mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                        if (mItem != null)
                                        {
                                            x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                            x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                            x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                            x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                            x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                            x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                            x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                            x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                            x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                            ICProductsForViewInfo objProductsForViewInfo = BOSApp.CurrentProductList.Where(y => y.ICProductID == mItem.FK_ICProductID).FirstOrDefault();
                                            if (objProductsForViewInfo != null)
                                            {
                                                x.MMBatchProductProductionNormItemMeterialNo = objProductsForViewInfo.ICProductNo;
                                                x.MMBatchProductProductionNormItemMeterialDesc = mItem.MMBatchProductProductionNormItemMeterialDesc;

                                                objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(mItem.FK_ICMeasureUnitID);
                                                if (objMeasureUnitsInfo != null)
                                                {
                                                    x.MMBatchProductProductionNormItemMeterialMeasureUnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                                                }
                                            }
                                        }
                                        mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                        if (mProcesssItem != null)
                                        {
                                            x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                        }
                                    });
                                }
                            });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void ExportSemiProductM2()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchproductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusWood)
                    {
                        InvalidateTreeView(fld_tabSemiProductName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeWoodApprove);

                    foreach (MMBatchProductItemsInfo item in batchproductItemList)
                    {
                        SetGeneralItemInfo(item);
                        //set ARCustomerName
                        if (string.IsNullOrEmpty(item.ARCustomerName))
                            item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormDepreciationRate = objProductionNormsInfo.MMProductionNormDepreciationRate;
                        }
                        //set MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }

                        List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetSemiProductByBatchProductItemID(item.FK_MMBatchProductID, item.MMBatchProductItemID);
                        if (MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                            parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemParentNo).ToList();
                            if (parentList != null)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                                {
                                    if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                    }
                                    item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                    List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
                                    if (childList != null)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                        {
                                            item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                            GetNode(childNode, MMBatchProductProductionNormItemsSemiProductList, item);
                                        }
                                    }
                                }
                            }
                        }
                        //objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                            {
                                ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                                if (objAttributesInfo != null)
                                {
                                    Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                                }

                                if (item.MMBatchProductProductionNormItemsSemiProductList.Any(o => o.MMBatchProductProductionNormItemParentID == Item.MMBatchProductProductionNormItemID))
                                    Item.HasComponent = true;
                                else
                                    Item.HasComponent = false;
                            }
                        }

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                            item.ARCustomerName = item.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault().ARCustomerName;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                    string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                    bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                    bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                    if (isHappy)
                    {
                        RPBatchProductExcelSemiProductM2HP report = new RPBatchProductExcelSemiProductM2HP(productionNormItemTotalQty);

                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();

                        batchproductItemList.ForEach(o =>
                        {
                            if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                            {
                                o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                {
                                    Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                    mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mItem != null)
                                    {
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                        x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                        x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                        x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                        x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                        x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                    }
                                    mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mProcesssItem != null)
                                    {
                                        x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                    }
                                });
                            }
                        });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else if (isBKV)
                    {
                        RPBatchProductExcelSemiProductM2BKV report = new RPBatchProductExcelSemiProductM2BKV(productionNormItemTotalQty);

                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();

                        batchproductItemList.ForEach(o =>
                        {
                            if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                            {
                                o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                {
                                    Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                    mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mItem != null)
                                    {
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                        x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                        x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                        x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                        x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                        x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                    }
                                    mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mProcesssItem != null)
                                    {
                                        x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                    }
                                });
                            }
                        });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else
                    {
                        RPBatchProductExcelSemiProductM2 report = new RPBatchProductExcelSemiProductM2(productionNormItemTotalQty);

                        MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                        MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                        MMOperationsController objOperationsController = new MMOperationsController();
                        MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                        MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                        MMProcesssController objProcesssController = new MMProcesssController();

                        batchproductItemList.ForEach(o =>
                        {
                            if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                            {
                                o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                                {
                                    Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                    mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mItem != null)
                                    {
                                        x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                        x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                        x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                        x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                        x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                        x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                        x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                        x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                    }
                                    mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                    if (mProcesssItem != null)
                                    {
                                        x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                    }
                                });
                            }
                        });

                        report.bindingSource8.DataSource = batchproductItemList;
                        //enablereport
                        EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        //Get Child Note to print Report
        public void GetNode(MMBatchProductProductionNormItemsInfo parentNode, List<MMBatchProductProductionNormItemsInfo> originNode, MMBatchProductItemsInfo orginItem)
        {
            if (parentNode == null)
            {
                return;
            }

            List<MMBatchProductProductionNormItemsInfo> childList = originNode.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
            childList = childList.OrderBy(p => p.MMBatchProductProductionNormItemParentOrderName).ToList();
            if (childList != null)
            {
                foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                {
                    orginItem.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                    List<MMBatchProductProductionNormItemsInfo> grandChild = originNode.Where(p => p.MMBatchProductProductionNormItemParentID == childNode.MMBatchProductProductionNormItemID).ToList();
                    foreach (MMBatchProductProductionNormItemsInfo item in grandChild)
                    {
                        orginItem.MMBatchProductProductionNormItemsSemiProductList.Add(item);
                        GetNode(item, originNode, orginItem);
                    }
                }
            }
        }

        public void ExportHardware()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusHardware)
                    {
                        InvalidateTreeView(fld_tabHardwareName, false);
                    }

                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ICProductsController objProductsController = new ICProductsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeHWApprove);

                    //get total item Qty      
                    foreach (MMBatchProductItemsInfo item in batchProductItemList)
                    {
                        SetGeneralItemInfo(item);
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                        }
                        //MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                            //item.ICProductPicture = objProductsInfo.ICProductPicture;
                        }
                        List<MMBatchProductProductionNormItemsInfo> lstHW = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.Hardware.ToString(), item.MMBatchProductItemID);
                        item.MMBatchProductProductionNormItemsHardwareList = lstHW.Where(o => o.MMBatchProductProductionNormItemQuantity > 0).OrderByDescending(x=> x.MMBatchProductProductionNormItemSortOrder).ToList();
                        
                        item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        SetHWQuantity(item.MMBatchProductProductionNormItemsHardwareList, item.MMBatchProductItemProductQty);

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                    string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                    bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                    bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                    if (isHappy)
                    {
                        RPBatchProductHardwareExcelHP report = new RPBatchProductHardwareExcelHP(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.Hardware.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else if(isBKV)
                    {
                        RPBatchProductHardwareExcelBKV report = new RPBatchProductHardwareExcelBKV(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.Hardware.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else
                    {
                        RPBatchProductHardwareExcel report = new RPBatchProductHardwareExcel(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.Hardware.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }    
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void ExportPaint()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchProductIngredientPaintList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusPaint)
                    {
                        InvalidateTreeView(fld_tabPaintName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeePaintApprove);
                    foreach (MMBatchProductItemsInfo item in batchProductIngredientPaintList)
                    {
                        SetGeneralItemInfo(item);
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormTotalPaint = objProductionNormsInfo.MMProductionNormTotalPaint;
                        }
                        //MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }
                        MMPaintProcessesItemsController objPaintProcessesItmesController = new MMPaintProcessesItemsController();
                        item.MMBatchProductProductionNormItemsIngredientPaintList = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPaint.ToString(), item.MMBatchProductItemID);
                        item.MMBatchProductProductionNormItemsIngredientPaintList = item.MMBatchProductProductionNormItemsIngredientPaintList.Where(o=> o.FK_ICProductID > 0).ToList();
                        item.MMBatchProductProductionNormItemsIngredientPaintList.ForEach(o =>
                        {
                            MMPaintProcessesItemsInfo objPaintProcessesItemsInfo = (MMPaintProcessesItemsInfo)objPaintProcessesItmesController.GetObjectByID(o.FK_APSupplierID);
                        });
                        SetPaintQuantity(item.MMBatchProductProductionNormItemsIngredientPaintList, item.MMBatchProductItemProductQty);

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                    }
                    //get total item Qty
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                    string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                    bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                    bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                    if (isHappy)
                    {
                        RPBatchProductPaintExcelHP report = new RPBatchProductPaintExcelHP(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductIngredientPaintList;
                        EnableReportDetail(report, BatchProductGroup.IngredientPaint.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else if (isBKV)
                    {
                        RPBatchProductPaintExcelBKV report = new RPBatchProductPaintExcelBKV(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductIngredientPaintList;
                        EnableReportDetail(report, BatchProductGroup.IngredientPaint.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else
                    {
                        RPBatchProductPaintExcel report = new RPBatchProductPaintExcel(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductIngredientPaintList;
                        EnableReportDetail(report, BatchProductGroup.IngredientPaint.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void ExportPackaging()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                if (!HaveFocusPackaging)
                {
                    InvalidateTreeView(fld_tabPackagingName, false);
                }
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                ICProductsController objProductsController = new ICProductsController();
                MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> List = new List<MMBatchProductProductionNormItemsInfo>();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeePackagingApprove);

                foreach (MMBatchProductItemsInfo item in batchProductItemList)
                {
                    SetGeneralItemInfo(item);
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                        item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                        item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                        item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                    }
                    //MMProductionNormType
                    if (objProductionNormsInfo != null)
                    {
                        ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                        if (objConfigValuesInfo != null)
                        {
                            item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                        }
                    }
                    
                    //set MMBatchProductItemProductNo
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                        //item.ICProductPicture = objProductsInfo.ICProductPicture;
                        if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                            item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                    }
                    List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsIngredientPackagingList = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPackaging.ToString(), item.MMBatchProductItemID);
                    if (MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == 0).ToList();
                        parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                        if (parentList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                            {
                                if (item.MMBatchProductProductionNormItemsIngredientPackagingList == null)
                                {
                                    item.MMBatchProductProductionNormItemsIngredientPackagingList = new List<MMBatchProductProductionNormItemsInfo>();
                                }
                                item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(parentNode);
                                List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
                                childList = childList.OrderByDescending(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                                if (childList != null)
                                {
                                    foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                    {
                                        item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(childNode);
                                    }
                                }
                            }
                        }
                    }
                    //item.MMBatchProductProductionNormItemsIngredientPackagingList = List;
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        SetPackagingQuantity(item.MMBatchProductProductionNormItemsIngredientPackagingList, item.MMBatchProductItemProductQty);
                    }
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsIngredientPackagingList)
                        {
                            if (!(Item.MMBatchProductProductionNormItemProductOverallDimensionWidth == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionLength == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductOverallDimension = Math.Round(Item.MMBatchProductProductionNormItemProductOverallDimensionWidth, 0) + "x"
                                    + Math.Round(Item.MMBatchProductProductionNormItemProductOverallDimensionLength, 0) + "x"
                                    + Math.Round(Item.MMBatchProductProductionNormItemProductOverallDimensionHeight, 0);

                            }
                            if (!(Item.MMBatchProductProductionNormItemProductInsideDimensionWidth == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionLength == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductInsideDimension = Math.Round(Item.MMBatchProductProductionNormItemProductInsideDimensionWidth, 0) + "x"
                                + Math.Round(Item.MMBatchProductProductionNormItemProductInsideDimensionLength, 0) + "x"
                                + Math.Round(Item.MMBatchProductProductionNormItemProductInsideDimensionHeight, 0);
                            }
                        }
                    }

                    item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                    item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                    item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                    item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                if (isHappy)
                {
                    RPBatchProductExcelPackingHP report = new RPBatchProductExcelPackingHP(productionNormItemTotalQty);
                    report.bindingSource8.DataSource = batchProductItemList;
                    EnableReportDetail(report, BatchProductGroup.IngredientPackaging.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else if (isBKV)
                {
                    RPBatchProductExcelPackingBKV report = new RPBatchProductExcelPackingBKV(productionNormItemTotalQty);
                    report.bindingSource8.DataSource = batchProductItemList;
                    EnableReportDetail(report, BatchProductGroup.IngredientPackaging.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else
                {
                    RPBatchProductExcelPacking report = new RPBatchProductExcelPacking(productionNormItemTotalQty);
                    report.bindingSource8.DataSource = batchProductItemList;
                    EnableReportDetail(report, BatchProductGroup.IngredientPackaging.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public void ExportGeneralMaterial()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusGeneralMaterial)
                    {
                        InvalidateTreeView(fld_tabGeneralMaterial, false);
                    }

                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ICProductsController objProductsController = new ICProductsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeGeneralMaterialApprove);

                    //get total item Qty      
                    foreach (MMBatchProductItemsInfo item in batchProductItemList)
                    {
                        SetGeneralItemInfo(item);
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                        }
                        //MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                            //item.ICProductPicture = objProductsInfo.ICProductPicture;
                        }
                        List<MMBatchProductProductionNormItemsInfo> lstGM = objBatchProductProductionNormItemsController.GetBatchProductProductionNormItemByBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.GeneralMaterial.ToString(), item.MMBatchProductItemID);
                        item.MMBatchProductItemMeterialList = lstGM.Where(o => o.MMBatchProductProductionNormItemQuantity > 0).ToList();

                        item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        SetGeneralMaterialQuantity(item.MMBatchProductItemMeterialList, item.MMBatchProductItemProductQty);

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    string stisHappy = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormHappy", "true");
                    string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                    bool isHappy = bool.Parse(stisHappy != string.Empty ? stisHappy : "false");
                    bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                    if (isHappy)
                    {
                        RPBatchProductGeneralMaterialExcelHP report = new RPBatchProductGeneralMaterialExcelHP(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.GeneralMaterial.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else if (isBKV)
                    {
                        RPBatchProductGeneralMaterialExcelBKV report = new RPBatchProductGeneralMaterialExcelBKV(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.GeneralMaterial.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                    else
                    {
                        RPBatchProductGeneralMaterialExcel report = new RPBatchProductGeneralMaterialExcel(productionNormItemTotalQty);
                        report.bindingSource8.DataSource = batchProductItemList;
                        EnableReportDetail(report, BatchProductGroup.GeneralMaterial.ToString());
                        guiReportPreview viewer = new guiReportPreview(report);
                        viewer.Show();
                        ActionCancel();
                    }
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void PrintSemiProduct()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
                MMBatchProductProductionNormItemsController bpptnController = new MMBatchProductProductionNormItemsController();
                MMBatchProductItemsController bpicontroller = new MMBatchProductItemsController();
                List<MMBatchProductItemsInfo> batchProductItemList = new List<MMBatchProductItemsInfo>();
                List<MMBatchProductItemsInfo> ItemBybatchProductIDList = bpicontroller.GetitemisCarcassByBatchProductID(mainObject.MMBatchProductID);
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            ItemBybatchProductIDList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> selectItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    selectItemList = new List<MMBatchProductItemsInfo>(selectItemList.OrderBy(p => p.MMBatchProductItemProductSerial));
                    //selectItemList.ForEach(a =>
                    //{
                    //    MMBatchProductItemsInfo item = ItemBybatchProductIDList.FirstOrDefault(b => b.MMBatchProductItemID == a.MMBatchProductItemID);
                    //    if (item != null)
                    //    {
                    //        selectItemHaveCarcassList.Add(item);
                    //    }
                    //});
                    //List<MMBatchProductItemsInfo> group = selectItemHaveCarcassList.GroupBy(a => new { a.FK_ICProductCarcassID })
                    //                                            .Select(b => new MMBatchProductItemsInfo
                    //                                            {
                    //                                                FK_ICProductCarcassID = b.Key.FK_ICProductCarcassID,
                    //                                                MMBatchProductItemProductQty = b.Sum(c => c.MMBatchProductItemProductQty)
                    //                                            }).ToList();
                    foreach (MMBatchProductItemsInfo item in selectItemList)
                    {
                        List<MMBatchProductItemsInfo> objitemList = selectItemList.Where(a => a.FK_ICProductID == item.FK_ICProductID).ToList();
                        if (objitemList != null && objitemList.Count() > 0)
                        {
                            item.ICProductNo = item.MMBatchProductItemProductNo;
                            item.ICProductPicture = objitemList[0].ICProductPicture;
                            item.ICProductDesc = item.MMBatchProductItemProductDesc;
                            item.MMBatchProductNo = item.MMBatchProductItemPONo;
                            item.MMBatchProductFromDate = mainObject.MMBatchProductFromDate;
                            item.MMBatchProductToDate = mainObject.MMBatchProductToDate;
                            item.MMBatchProductDate = mainObject.MMBatchProductDate;
                            item.MMBatchProductDesc = mainObject.MMBatchProductDesc;
                            //item.HREmployeeName = mainObject.HREmployeeName;
                            //item.HREmployeeNameApproved = mainObject.HREmployeeNameApproved;
                            //item.HREmployeeNameValidated = mainObject.HREmployeeNameValidated;
                            //item.ARCustomerName = mainObject.MMBatchProductMultiCustomer;
                            item.ICProductQC = item.MMBatchProductItemProductLength.ToString("N0")
                                                + "x" + item.MMBatchProductItemProductWidth.ToString("N0")
                                                + "x" + item.MMBatchProductItemProductHeight.ToString("N0");
                        }
                        batchProductItemList.Add(item);
                    }
                    batchProductItemList.ForEach(a =>
                        {
                            List<MMBatchProductProductionNormItemsInfo> SemiProductList = bpptnController.GetPrintSemiListByBatchProductItemID(a.MMBatchProductItemID);
                            if (SemiProductList.Count() > 0)
                            {
                                List<MMBatchProductProductionNormItemsInfo> Parent = SemiProductList.Where(s => s.ProductLevel == 1).ToList();
                                int stt = 1;

                                Parent.ForEach(b =>
                                {
                                    b.STT = stt;
                                    stt++;
                                    List<MMBatchProductProductionNormItemsInfo> child = SemiProductList.Where(c => c.MMBatchProductProductionNormItemParentID == b.MMBatchProductProductionNormItemID)
                                    .OrderBy(o => o.MMBatchProductProductionNormItemParentOrderName).ToList();
                                    child.ForEach(c =>
                                    {
                                        c.STT = stt;
                                        stt++;
                                    });

                                });

                            }

                            a.MMBatchProductProductionNormItemsSemiProductList = SemiProductList.OrderBy(s => s.STT).ToList();

                            if (a.MMBatchProductProductionNormItemsSemiProductList != null && a.MMBatchProductProductionNormItemsSemiProductList.Count > 0)
                            {
                                List<MMBatchProductProductionNormItemsInfo> NlList = a.MMBatchProductProductionNormItemsSemiProductList.Where(b => b.MMBatchProductProductionNormItemMeterialHeigth > 0).ToList();
                                if (NlList != null && NlList.Count() > 0)
                                {
                                    a.MMBatchProductItemMeterialList = NlList.GroupBy(b => new { b.MMBatchProductProductionNormItemMeterialHeigth })
                                                                                .Select(c => new MMBatchProductProductionNormItemsInfo
                                                                                {
                                                                                    MMBatchProductProductionNormItemMeterialHeigth = c.Key.MMBatchProductProductionNormItemMeterialHeigth,
                                                                                    Blocks = c.Sum(d => d.MMBatchProductProductionNormItemMeterialDepreciationQty),
                                                                                    TotalBlock = c.Sum(d => d.MMBatchProductProductionNormItemMeterialDepreciationQty)
                                                                                }).ToList();
                                }
                            }
                        });
                    RP_BatchProductSemiProduct report = new RP_BatchProductSemiProduct();
                    report.MMBatchProductItems.DataSource = batchProductItemList;
                    report.AddDynamicColumn();
                    guiReportPreview view = new guiReportPreview(report, string.Empty, true);
                    view.Show();
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void PrintHardware()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    batchProductItemList = new List<MMBatchProductItemsInfo>(batchProductItemList.OrderBy(p => p.MMBatchProductItemProductSerial));
                    if (!HaveFocusHardware)
                    {
                        InvalidateTreeView(fld_tabHardwareName, false);
                    }

                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ICProductsController objProductsController = new ICProductsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    //get total item Qty      
                    foreach (MMBatchProductItemsInfo item in batchProductItemList)
                    {
                        SetGeneralItemInfo(item);
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                        }
                        //MMProductionNormType
                        ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                        if (objConfigValuesInfo != null)
                        {
                            item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                        }
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                        }
                        item.MMBatchProductProductionNormItemsHardwareList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.Hardware.ToString(), item.MMBatchProductItemID);
                        SetHWQuantity(item.MMBatchProductProductionNormItemsHardwareList, item.MMBatchProductItemProductQty);
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    RPBatchProducts report = new RPBatchProducts(productionNormItemTotalQty);
                    report.bindingSource8.DataSource = batchProductItemList;
                    EnableReportDetail(report, BatchProductGroup.Hardware.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void PrintPaintAll()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;

                MMBatchProductProductionNormItemsController pniController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> itemList = pniController.GetItemForPaintByBatchProductID(objBatchProductsInfo.MMBatchProductID);

                ARCustomersController cusController = new ARCustomersController();
                ARCustomersInfo cus = (ARCustomersInfo)cusController.GetObjectByID(objBatchProductsInfo.FK_ARCustomerID);
                string customerName = string.Empty;
                if (cus != null)
                {
                    customerName = cus.ARCustomerName;
                }

                string lsx = objBatchProductsInfo.MMBatchProductNo;


                decimal totalPaint = entity.BatchProductItemList.Sum(t => t.MMBatchProductitemTotalPaint);

                RPBatchProduct_AllPaint report = new RPBatchProduct_AllPaint(totalPaint, customerName, lsx);
                report.DataSource = itemList;
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        public void PrintPaint()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchProductIngredientPaintList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    batchProductIngredientPaintList = new List<MMBatchProductItemsInfo>(batchProductIngredientPaintList.OrderBy(p => p.MMBatchProductItemProductSerial));
                    if (!HaveFocusPaint)
                    {
                        InvalidateTreeView(fld_tabPaintName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    foreach (MMBatchProductItemsInfo batchProductItemsInfo in batchProductIngredientPaintList)
                    {
                        batchProductItemsInfo.MauSon = string.Empty;
                        List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductColorAttributeValueByICProductID(batchProductItemsInfo.FK_ICProductID);
                        foreach (ICProductAttributesInfo item in productAttributeList)
                        {
                            //--------------ColerValuesList----------------------//
                            if (!string.IsNullOrEmpty(batchProductItemsInfo.MauSon)
                                && !(batchProductItemsInfo.MauSon.Contains(item.ICProductAttributeValue)))
                            {
                                batchProductItemsInfo.MauSon += ", ";
                            }
                            if (!(batchProductItemsInfo.MauSon.Contains(item.ICProductAttributeValue)))
                            {
                                batchProductItemsInfo.MauSon += item.ICProductAttributeValue;
                            }
                            //--------------ColerValuesList----------------------//
                        }
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(batchProductItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            batchProductItemsInfo.Mamauson = objProductsInfo.ICProductPaintNoOfManufacture;
                            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeColorID);
                            if (objProductAttributesInfo != null)
                            {
                                //--------------ColerValuesList----------------------//
                                if (!string.IsNullOrEmpty(batchProductItemsInfo.MauSon)
                                    && !(batchProductItemsInfo.MauSon.Contains(objProductAttributesInfo.ICProductAttributeValue)))
                                {
                                    batchProductItemsInfo.MauSon += ", ";
                                }
                                if (!(batchProductItemsInfo.MauSon.Contains(objProductAttributesInfo.ICProductAttributeValue)))
                                {
                                    batchProductItemsInfo.MauSon += objProductAttributesInfo.ICProductAttributeValue;
                                }
                                //--------------ColerValuesList----------------------//
                            }
                        }
                    }
                    foreach (MMBatchProductItemsInfo item in batchProductIngredientPaintList)
                    {
                        SetGeneralItemInfo(item);
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                        }
                        //MMProductionNormType
                        ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                        if (objConfigValuesInfo != null)
                        {
                            item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                        }
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                        }
                        item.MMBatchProductProductionNormItemsIngredientPaintList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPaint.ToString(), item.MMBatchProductItemID);
                        SetPaintQuantity(item.MMBatchProductProductionNormItemsIngredientPaintList, item.MMBatchProductItemProductQty);
                    }
                    //get total item Qty        
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    RPBatchProducts report = new RPBatchProducts(productionNormItemTotalQty);
                    report.bindingSource8.DataSource = batchProductIngredientPaintList;
                    EnableReportDetail(report, BatchProductGroup.IngredientPaint.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void PrintPackaging()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                batchProductItemList = new List<MMBatchProductItemsInfo>(batchProductItemList.OrderBy(p => p.MMBatchProductItemProductSerial));
                if (!HaveFocusPackaging)
                {
                    InvalidateTreeView(fld_tabPackagingName, false);
                }
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                ICProductsController objProductsController = new ICProductsController();
                MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> List = new List<MMBatchProductProductionNormItemsInfo>();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                foreach (MMBatchProductItemsInfo item in batchProductItemList)
                {
                    SetGeneralItemInfo(item);
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                        item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                        item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                        item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                    }
                    //MMProductionNormType
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                    {
                        item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    }
                    //set MMBatchProductItemProductNo
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                    }
                    List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsIngredientPackagingList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPackaging.ToString(), item.MMBatchProductItemID);
                    if (MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == 0).ToList();
                        parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                        if (parentList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                            {
                                if (item.MMBatchProductProductionNormItemsIngredientPackagingList == null)
                                {
                                    item.MMBatchProductProductionNormItemsIngredientPackagingList = new List<MMBatchProductProductionNormItemsInfo>();
                                }
                                item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(parentNode);
                                List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
                                childList = childList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                                if (childList != null)
                                {
                                    foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                    {
                                        item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(childNode);
                                    }
                                }
                            }
                        }
                    }
                    //item.MMBatchProductProductionNormItemsIngredientPackagingList = List;
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        SetPackagingQuantity(item.MMBatchProductProductionNormItemsIngredientPackagingList, item.MMBatchProductItemProductQty);
                    }
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsIngredientPackagingList)
                        {
                            if (!(Item.MMBatchProductProductionNormItemProductOverallDimensionWidth == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionLength == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductOverallDimension = Item.MMBatchProductProductionNormItemProductOverallDimensionWidth + "x"
                                    + Item.MMBatchProductProductionNormItemProductOverallDimensionLength + "x"
                                    + Item.MMBatchProductProductionNormItemProductOverallDimensionHeight;

                            }
                            if (!(Item.MMBatchProductProductionNormItemProductInsideDimensionWidth == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionLength == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductInsideDimension = Item.MMBatchProductProductionNormItemProductInsideDimensionWidth + "x"
                                + Item.MMBatchProductProductionNormItemProductInsideDimensionLength + "x"
                                + Item.MMBatchProductProductionNormItemProductInsideDimensionHeight;
                            }
                        }
                    }
                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPBatchProducts report = new RPBatchProducts(productionNormItemTotalQty);
                report.bindingSource8.DataSource = batchProductItemList;
                EnableReportDetail(report, BatchProductGroup.IngredientPackaging.ToString());
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                ActionCancel();
            }
            else
            {
                ActionCancel();
            }
        }

        public void PrintAll()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                batchProductItemList = new List<MMBatchProductItemsInfo>(batchProductItemList.OrderBy(p => p.MMBatchProductItemProductSerial));
                if (!HaveFocusWood)
                {
                    InvalidateTreeView(fld_tabSemiProductName, false);
                }
                if (!HaveFocusPaint)
                {
                    InvalidateTreeView(fld_tabPaintName, false);
                }
                if (!HaveFocusPackaging)
                {
                    InvalidateTreeView(fld_tabPackagingName, false);
                }
                if (!HaveFocusHardware)
                {
                    InvalidateTreeView(fld_tabHardwareName, false);
                }
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                ICProductsController objProductsController = new ICProductsController();
                MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                List<MMBatchProductProductionNormItemsInfo> semiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                List<MMBatchProductProductionNormItemsInfo> ingredientPackagingList = new List<MMBatchProductProductionNormItemsInfo>();
                foreach (MMBatchProductItemsInfo item in batchProductItemList)
                {
                    SetGeneralItemInfo(item);
                    item.MauSon = string.Empty;
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                        item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                        item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                        item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                    }
                    //MMProductionNormType
                    if (objProductionNormsInfo != null)
                    {
                        ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                        if (objConfigValuesInfo != null)
                        {
                            item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                        }
                    }
                    //set MMBatchProductItemProductNo

                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                        item.Mamauson = objProductsInfo.ICProductPaintNoOfManufacture;
                        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeColorID);
                        if (objProductAttributesInfo != null)
                        {
                            //--------------ColerValuesList----------------------//
                            if (!string.IsNullOrEmpty(item.MauSon)
                                && !(item.MauSon.Contains(objProductAttributesInfo.ICProductAttributeValue)))
                            {
                                item.MauSon += ", ";
                            }
                            if (!(item.MauSon.Contains(objProductAttributesInfo.ICProductAttributeValue)))
                            {
                                item.MauSon += objProductAttributesInfo.ICProductAttributeValue;
                            }
                            //--------------ColerValuesList----------------------//
                        }
                    }
                    //set Mau Son
                    List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductColorAttributeValueByICProductID(item.FK_ICProductID);
                    foreach (ICProductAttributesInfo items in productAttributeList)
                    {
                        //--------------ColerValuesList----------------------//
                        if (!string.IsNullOrEmpty(item.MauSon)
                            && !(item.MauSon.Contains(items.ICProductAttributeValue)))
                        {
                            item.MauSon += ", ";
                        }
                        if (!(item.MauSon.Contains(items.ICProductAttributeValue)))
                        {
                            item.MauSon += items.ICProductAttributeValue;
                        }
                        //--------------ColerValuesList----------------------//
                    }
                    //
                    List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                    if (MMBatchProductProductionNormItemsSemiProductList != null)
                    {
                        List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                        parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                        if (parentList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                            {
                                if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                {
                                    item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                }
                                item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
                                childList = childList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                                if (childList != null)
                                {
                                    foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                    }
                                }
                            }
                        }
                    }
                    //item.MMBatchProductProductionNormItemsSemiProductList = semiProductList;
                    if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                        {
                            ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                            if (objAttributesInfo != null)
                            {
                                Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                            }
                        }
                    }

                    item.MMBatchProductProductionNormItemsHardwareList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.Hardware.ToString(), item.MMBatchProductItemID);
                    SetHWQuantity(item.MMBatchProductProductionNormItemsHardwareList, item.MMBatchProductItemProductQty);
                    item.MMBatchProductProductionNormItemsIngredientPaintList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPaint.ToString(), item.MMBatchProductItemID);
                    SetPaintQuantity(item.MMBatchProductProductionNormItemsIngredientPaintList, item.MMBatchProductItemProductQty);
                    List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsIngredientPackagingList = objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.IngredientPackaging.ToString(), item.MMBatchProductItemID);
                    if (MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == 0).ToList();
                        parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                        if (parentList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                            {
                                if (item.MMBatchProductProductionNormItemsIngredientPackagingList == null)
                                {
                                    item.MMBatchProductProductionNormItemsIngredientPackagingList = new List<MMBatchProductProductionNormItemsInfo>();
                                }
                                item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(parentNode);
                                List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsIngredientPackagingList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();
                                childList = childList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                                if (childList != null)
                                {
                                    foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                    {
                                        item.MMBatchProductProductionNormItemsIngredientPackagingList.Add(childNode);
                                    }
                                }
                            }
                        }
                    }
                    //item.MMBatchProductProductionNormItemsIngredientPackagingList = ingredientPackagingList;
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        SetPackagingQuantity(item.MMBatchProductProductionNormItemsIngredientPackagingList, item.MMBatchProductItemProductQty);
                    }
                    if (item.MMBatchProductProductionNormItemsIngredientPackagingList != null)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsIngredientPackagingList)
                        {
                            if (!(Item.MMBatchProductProductionNormItemProductOverallDimensionWidth == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionLength == 0
                              && Item.MMBatchProductProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductOverallDimension = Item.MMBatchProductProductionNormItemProductOverallDimensionWidth + "x"
                                    + Item.MMBatchProductProductionNormItemProductOverallDimensionLength + "x"
                                    + Item.MMBatchProductProductionNormItemProductOverallDimensionHeight;

                            }
                            if (!(Item.MMBatchProductProductionNormItemProductInsideDimensionWidth == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionLength == 0
                                && Item.MMBatchProductProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                Item.MMBatchProductProductionNormItemProductInsideDimension = Item.MMBatchProductProductionNormItemProductInsideDimensionWidth + "x"
                                + Item.MMBatchProductProductionNormItemProductInsideDimensionLength + "x"
                                + Item.MMBatchProductProductionNormItemProductInsideDimensionHeight;
                            }
                        }
                    }
                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPBatchProducts report = new RPBatchProducts(productionNormItemTotalQty);
                report.bindingSource8.DataSource = batchProductItemList;
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                ActionCancel();
            }
            else
            {
                ActionCancel();
            }
        }

        public void PrintBatchProduct()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProductEntities entity = CurrentModuleEntity as BatchProductEntities;
                MMBatchProductsInfo mainObject = entity.MainObject as MMBatchProductsInfo;
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                String[] copies = { MESLocalizedResources.Contact1, MESLocalizedResources.Contact2, MESLocalizedResources.Contact3 };
                PrintDialog printDialog = new PrintDialog();
                printDialog.PrinterSettings.Copies = 1;
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < printDialog.PrinterSettings.Copies; i++)
                    {
                        RP_BatchProduct report = new RP_BatchProduct();
                        InitInvoiceReport(report);
                        XtraReportHelper.PrintToPrinter(report, printDialog.PrinterSettings.PrinterName);
                    }
                    mainObject.MMBatchProductDatePrint += 1;
                    objBatchProductsController.UpdateObject(mainObject);
                    releaseTime = false;
                }
            }
        }

        public void PrintViewBatchProduct()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
                bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
                if (isBKV)
                {
                    RP_BatchProductBKV report = new RP_BatchProductBKV();
                    InitInvoiceReport(report);
                    guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
                    reviewer.Show();
                }
                else
                {
                    RP_BatchProduct report = new RP_BatchProduct();
                    InitInvoiceReport(report);
                    guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
                    reviewer.Show();
                }
            }
        }

        public void InitInvoiceReport(XtraReport report)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<MMBatchProductItemsInfo> batchproductItemList = objBatchProductItemsController.GetBatchProductItemListByBatchProductID(objBatchProductsInfo.MMBatchProductID);
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrlblDate"];
            if (label != null)
            {
                label.Text = "Ngày " + objBatchProductsInfo.MMBatchProductDate.ToString("dd")
                             + " tháng " + objBatchProductsInfo.MMBatchProductDate.ToString("MM")
                             + " năm " + objBatchProductsInfo.MMBatchProductDate.ToString("yyyy");
            }
            if (BOSApp.CurrentCompanyInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyAddressLine3"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyInfo"];
                if (label != null)
                {
                    label.Text = string.Format("ĐT: {0} | Email: {1} | Website: {2}", BOSApp.CurrentCompanyInfo.CSCompanyPhone
                    , BOSApp.CurrentCompanyInfo.CSCompanyEmail, BOSApp.CurrentCompanyInfo.CSCompanyWebsite);

                }
            }
            batchproductItemList = new List<MMBatchProductItemsInfo>(batchproductItemList.OrderBy(p => p.MMBatchProductItemProductSerial));
            foreach (MMBatchProductItemsInfo item in batchproductItemList)
            {
                List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributeValueByICProductID(item.FK_ICProductID);
                foreach (ICProductAttributesInfo productAttribute in productAttributeList)
                {
                    if (string.IsNullOrEmpty(item.ICProductAttributeWoodType))
                    {
                        item.ICProductAttributeWoodType = productAttribute.ICProductAttributeValue;
                    }

                    if (!string.IsNullOrEmpty(item.ICProductAttributeWoodType) && !(item.ICProductAttributeWoodType.Contains(productAttribute.ICProductAttributeValue)))
                    {
                        item.ICProductAttributeWoodType += ", " + productAttribute.ICProductAttributeValue;
                    }
                }
                if (!string.IsNullOrEmpty(item.ICProductImageFile))
                    item.ICProductImageFile = item.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
            }
            report.DataSource = batchproductItemList;
            CSCompanysController objCompanysController = new CSCompanysController();
            BRBranchsController objBranchsController = new BRBranchsController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
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
            string stisBKV = ADConfigValueUtility.GetConfigTextByGroupAndValue("IsPrintProductionNormBKV", "true");
            bool isBKV = bool.Parse(stisBKV != string.Empty ? stisBKV : "false");
            if (isBKV)
            {
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabelSignature5"];
                if (label != null)
                {
                    label.Text = "Giám đốc sản xuất";
                }
            }
            else
            {
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabelSignature5"];
                if (label != null)
                {
                    label.Text = "Kiểm soát";
                }
            }    
        }

        public void PrintDeliverySemiProduct()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchproductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusWood)
                    {
                        InvalidateTreeView(fld_tabSemiProductName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeWoodApprove);

                    foreach (MMBatchProductItemsInfo item in batchproductItemList)
                    {
                        SetGeneralItemInfo(item);
                        //set ARCustomerName
                        if (string.IsNullOrEmpty(item.ARCustomerName))
                            item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormDepreciationRate = objProductionNormsInfo.MMProductionNormDepreciationRate;
                        }
                        //set MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }    
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }

                        List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetSemiProductByBatchProductItemID(item.FK_MMBatchProductID, item.MMBatchProductItemID);
                        if (MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                            parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemParentNo).ToList();
                            if (parentList != null)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                                {
                                    if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                    }
                                    item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                    List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();

                                    if (childList != null)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                        {
                                            item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                            GetNode(childNode, MMBatchProductProductionNormItemsSemiProductList, item);
                                        }
                                    }
                                }
                            }
                        }
                        //objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                            {
                                ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                                if (objAttributesInfo != null)
                                {
                                    Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                                }

                                if (item.MMBatchProductProductionNormItemsSemiProductList.Any(o => o.MMBatchProductProductionNormItemParentID == Item.MMBatchProductProductionNormItemID))
                                    Item.HasComponent = true;
                                else
                                    Item.HasComponent = false;
                            }
                        }

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                            item.ARCustomerName = item.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault().ARCustomerName;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                    RPBatchProductDeliverySemiProduct report = new RPBatchProductDeliverySemiProduct(productionNormItemTotalQty);

                    batchproductItemList.ForEach(o =>
                    {
                        if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x => Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2));
                        }
                    });

                    report.bindingSource8.DataSource = batchproductItemList;
                    //enablereport
                    EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void PrintOperation()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                RP_Operation report = new RP_Operation();
                InitPrintOperation(report);
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }

        public void PrintDeliveryNote()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                RP_DeliveryNote report = new RP_DeliveryNote();
                InitPrintOperation(report);
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }
        public void InitPrintOperation(XtraReport report)
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchproductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusWood)
                    {
                        InvalidateTreeView(fld_tabSemiProductName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeWoodApprove);

                    foreach (MMBatchProductItemsInfo item in batchproductItemList)
                    {
                        SetGeneralItemInfo(item);
                        //set ARCustomerName
                        if (string.IsNullOrEmpty(item.ARCustomerName))
                            item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormDepreciationRate = objProductionNormsInfo.MMProductionNormDepreciationRate;
                        }
                        //set MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }
                        
                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }

                        List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetSemiProductByBatchProductItemID(item.FK_MMBatchProductID, item.MMBatchProductItemID);
                        if (MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                            parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemParentNo).ToList();
                            if (parentList != null)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                                {
                                    if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                    }
                                    item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                    List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).ToList();

                                    if (childList != null)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                        {
                                            item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                            GetNode(childNode, MMBatchProductProductionNormItemsSemiProductList, item);
                                        }
                                    }
                                }
                            }
                        }
                        //objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                            {
                                Item.MMBatchProductProductionNormItemOverallSize = String.Format("{0} x {1} x {2}",
                                                                                                            Math.Round(Item.MMBatchProductProductionNormItemProductLength, 0),
                                                                                                            Math.Round(Item.MMBatchProductProductionNormItemProductWidth, 0),
                                                                                                            Math.Round(Item.MMBatchProductProductionNormItemProductHeight, 0));
                                ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                                if (objAttributesInfo != null)
                                {
                                    Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                                }

                                if (item.MMBatchProductProductionNormItemsSemiProductList.Any(o => o.MMBatchProductProductionNormItemParentID == Item.MMBatchProductProductionNormItemID))
                                    Item.HasComponent = true;
                                else
                                    Item.HasComponent = false;
                                Item.MMBatchProductItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                                ICProductsInfo objProductSemiProduct = (ICProductsInfo)objProductsController.GetObjectByID(Item.FK_ICProductID);
                                if (objProductSemiProduct != null)
                                {
                                    Item.ICProductImageFile = objProductSemiProduct.ICProductImageFile;
                                }
                                Item.MMBatchProductNo = item.MMBatchProductNo;
                            }
                        }

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                            item.ARCustomerName = item.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault().ARCustomerName;
                    }

                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();

                    batchproductItemList.ForEach(o =>
                    {
                        if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x => Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2));
                        }
                    });

                    if (BOSApp.CurrentCompanyInfo != null)
                    {
                        XRLabel label = (XRLabel)report.Bands[BandKind.DetailReport].Controls["Detail1"].Controls["xr_lblCSCompanyName"];
                        if (label != null)
                        {
                            label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                        }

                        label = (XRLabel)report.Bands[BandKind.DetailReport].Controls["Detail1"].Controls["xr_lblCSCompanyAddressLine3"];
                        if (label != null)
                        {
                            label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
                        }

                        label = (XRLabel)report.Bands[BandKind.DetailReport].Controls["Detail1"].Controls["xr_lblCSCompanyInfo"];
                        if (label != null)
                        {
                            label.Text = string.Format("ĐT: {0} | Email: {1} | Website: {2}", BOSApp.CurrentCompanyInfo.CSCompanyPhone
                            , BOSApp.CurrentCompanyInfo.CSCompanyEmail, BOSApp.CurrentCompanyInfo.CSCompanyWebsite);

                        }
                        label = (XRLabel)report.Bands[BandKind.DetailReport].Controls["Detail1"].Controls["xr_lblCSCompanyDeliveryAddressLine"];
                        if (label != null)
                        {
                            label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine3;
                        }    
                    }
                    report.DataSource = batchproductItemList;
                    //enablereport
                    //EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        public void SemiProductBOM()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                guiFind<MMBatchProductItemsInfo> guiFind = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                            entity.BatchProductItemList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
                guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {
                    List<MMBatchProductItemsInfo> batchproductItemList = (List<MMBatchProductItemsInfo>)guiFind.SelectedObjects;
                    if (!HaveFocusWood)
                    {
                        InvalidateTreeView(fld_tabSemiProductName, false);
                    }
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                    MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ICProductsController objProductsController = new ICProductsController();
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeID);
                    HREmployeesInfo objEmployeeValidate = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeIDValidated);
                    HREmployeesInfo objEmployeeApprove = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBatchProductsInfo.FK_HREmployeeWoodApprove);

                    foreach (MMBatchProductItemsInfo item in batchproductItemList)
                    {
                        SetGeneralItemInfo(item);
                        //set ARCustomerName
                        if (string.IsNullOrEmpty(item.ARCustomerName))
                            item.ARCustomerName = objBatchProductsInfo.MMBatchProductMultiCustomer;
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(item.FK_MMProductionNormID);
                        if (objProductionNormsInfo != null)
                        {
                            item.MMProductionNormNo = objProductionNormsInfo.MMProductionNormNo;
                            item.MMProductionNormOverallSize = objProductionNormsInfo.MMProductionNormOverallSize;
                            item.MMProductionNormPromulgateDate = objProductionNormsInfo.MMProductionNormPromulgateDate;
                            item.MMProductionNormVersion = objProductionNormsInfo.MMProductionNormVersion;
                            item.MMProductionNormDepreciationRate = objProductionNormsInfo.MMProductionNormDepreciationRate;
                        }
                        if (item.FK_ARProductionPlanningID > 0)
                        {
                            ARProductionPlanningsController objProductionPlanningsController = new ARProductionPlanningsController();
                            ARProductionPlanningsInfo objProductionPlanningsInfo = new ARProductionPlanningsInfo();
                            objProductionPlanningsInfo = (ARProductionPlanningsInfo) objProductionPlanningsController.GetObjectByID(item.FK_ARProductionPlanningID);
                            if (objProductionPlanningsInfo != null) 
                            {
                                if (objProductionPlanningsInfo.ARProductionPlanningDesc != null && objProductionPlanningsInfo.ARProductionPlanningDesc.Length > 0) 
                                {
                                    MemoryStream RTFStream = new MemoryStream(objProductionPlanningsInfo.ARProductionPlanningDesc);
                                    BOSComponent.BOSRichEditControl rictextEditControl = new BOSComponent.BOSRichEditControl();
                                    rictextEditControl.LoadDocument(RTFStream, DocumentFormat.Rtf);
                                    item.ARProductionPlanningComment = String.IsNullOrEmpty(objProductionPlanningsInfo.ARProductionPlanningComment) ? rictextEditControl.Text
                                        : (objProductionPlanningsInfo.ARProductionPlanningComment + Environment.NewLine + rictextEditControl.Text);
                                }
                                else
                                    item.ARProductionPlanningComment = String.IsNullOrEmpty(objProductionPlanningsInfo.ARProductionPlanningComment) ? "" : (objProductionPlanningsInfo.ARProductionPlanningComment);
                                item.ARProductionPlanningToDate = objProductionPlanningsInfo.ARProductionPlanningToDate;
                            }
                        }    
                        //set MMProductionNormType
                        if (objProductionNormsInfo != null)
                        {
                            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                            if (objConfigValuesInfo != null)
                            {
                                item.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                            }
                        }

                        //set MMBatchProductItemProductNo
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            if (!string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
                                item.ICProductImageFile = objProductsInfo.ICProductImageFile.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
                        }

                        List<MMBatchProductProductionNormItemsInfo> MMBatchProductProductionNormItemsSemiProductList = objBatchProductProductionNormItemsController.GetSemiProductByBatchProductItemID(item.FK_MMBatchProductID, item.MMBatchProductItemID);
                        if (MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            List<MMBatchProductProductionNormItemsInfo> parentList = MMBatchProductProductionNormItemsSemiProductList.Where(p => p.ParentOfParentID == 0).ToList();
                            parentList = parentList.OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();
                            if (parentList != null)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo parentNode in parentList)
                                {
                                    if (item.FK_ARProductionPlanningItemID > 0)
                                    {
                                        ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
                                        ARProductionPlanningItemsInfo objProductionPlanningItemsInfo = new ARProductionPlanningItemsInfo();
                                        objProductionPlanningItemsInfo = (ARProductionPlanningItemsInfo)objProductionPlanningItemsController.GetObjectByID(item.FK_ARProductionPlanningItemID);
                                        if (objProductionPlanningItemsInfo != null)
                                        {
                                            parentNode.ARProductionPlanningItemProductRemark = objProductionPlanningItemsInfo.ARProductionPlanningItemProductRemark;
                                        }
                                    }

                                    if (item.MMBatchProductProductionNormItemsSemiProductList == null)
                                    {
                                        item.MMBatchProductProductionNormItemsSemiProductList = new List<MMBatchProductProductionNormItemsInfo>();
                                    }
                                    item.MMBatchProductProductionNormItemsSemiProductList.Add(parentNode);
                                    List<MMBatchProductProductionNormItemsInfo> childList = MMBatchProductProductionNormItemsSemiProductList
                                        .Where(p => p.MMBatchProductProductionNormItemParentID == parentNode.MMBatchProductProductionNormItemID).OrderBy(p => p.MMBatchProductProductionNormItemSortOrder).ToList();

                                    if (childList != null)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo childNode in childList)
                                        {
                                            item.MMBatchProductProductionNormItemsSemiProductList.Add(childNode);
                                            GetNode(childNode, MMBatchProductProductionNormItemsSemiProductList, item);
                                        }
                                    }
                                }
                            }
                        }
                        //objBatchProductProductionNormItemsController.GetMMBatchProductProductionNormItemByMMBatchProductItemID(item.FK_MMBatchProductID, BatchProductGroup.SemiProduct.ToString(), item.MMBatchProductItemID);
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo Item in item.MMBatchProductProductionNormItemsSemiProductList)
                            {
                                ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Item.FK_ICProductAttributeSpecialityID);
                                if (objAttributesInfo != null)
                                {
                                    Item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                                }

                                if (item.MMBatchProductProductionNormItemsSemiProductList.Any(o => o.MMBatchProductProductionNormItemParentID == Item.MMBatchProductProductionNormItemID))
                                    Item.HasComponent = true;
                                else
                                    Item.HasComponent = false;
                            }
                        }

                        item.HREmployeeName = objEmployee != null ? objEmployee.HREmployeeName : string.Empty;
                        item.HREmployeeNameValidated = objEmployeeValidate != null ? objEmployeeValidate.HREmployeeName : string.Empty;
                        item.HREmployeeNameApproved = objEmployeeApprove != null ? objEmployeeApprove.HREmployeeName : string.Empty;
                        item.MMBatchProductDesc = objBatchProductsInfo.MMBatchProductDesc;
                        if (item.MMBatchProductProductionNormItemsSemiProductList != null)
                            item.ARCustomerName = item.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault().ARCustomerName;
                    }
                    decimal productionNormItemTotalQty = GetSumProductionNormItemQty();

                    RPBatchProductSemiProductBOM report = new RPBatchProductSemiProductBOM(productionNormItemTotalQty);
                    MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
                    MMBatchProductProductionNormItemMeterialsInfo mItem = new MMBatchProductProductionNormItemMeterialsInfo();
                    MMOperationsController objOperationsController = new MMOperationsController();
                    MMBatchProductProductionNormItemProcesssController mProcesssCtrl = new MMBatchProductProductionNormItemProcesssController();
                    MMBatchProductProductionNormItemProcesssInfo mProcesssItem = new MMBatchProductProductionNormItemProcesssInfo();
                    MMProcesssController objProcesssController = new MMProcesssController();

                    batchproductItemList.ForEach(o =>
                    {
                        if (o.MMBatchProductProductionNormItemsSemiProductList != null)
                        {
                            //o.MMBatchProductProductionNormItemsSemiProductList = o.MMBatchProductProductionNormItemsSemiProductList.OrderBy(i => i.ICProductCode).ToList();
                            
                            o.MMBatchProductProductionNormItemsSemiProductList.ForEach(x =>
                            {
                                MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
                                Math.Round(x.MMBatchProductProductionNormItemDepreciationRate, 2);
                                mItem = mCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                if (mItem != null)
                                {
                                    x.MMBatchProductProductionNormItemMeterialHeigth = mItem.MMBatchProductProductionNormItemMeterialHeigth;
                                    x.MMBatchProductProductionNormItemMeterialLength = mItem.MMBatchProductProductionNormItemMeterialLength;
                                    x.MMBatchProductProductionNormItemMeterialWidth = mItem.MMBatchProductProductionNormItemMeterialWidth;
                                    x.MMBatchProductProductionNormItemMeterialQty = mItem.MMBatchProductProductionNormItemMeterialQty;
                                    x.MMBatchProductProductionNormItemMeterialDepreciationQty = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty;
                                    x.MMBatchProductProductionNormItemMeterialWoodBlockNorm = mItem.MMBatchProductProductionNormItemMeterialQty / x.MMBatchProductItemProductQty;    //SLNL/SP
                                    x.MMBatchProductProductionNormItemMeterialWoodBlocks = mItem.MMBatchProductProductionNormItemMeterialDepreciationQty / x.MMBatchProductItemProductQty;       //SL/KL NL tiêu hao/SP
                                    x.MMOperationName = objOperationsController.GetObjectNameByID(mItem.FK_MMOperationID);
                                    
                                }
                                MMBatchProductItemOutSourcingsInfo objBatchProductItemOutSourcingsInfo = entity.BatchProductItemOutSourcingList.Where(y => y.FK_MMBatchProductProductionNormItemID == x.MMBatchProductProductionNormItemID 
                                && y.MMBatchProductItemOutSourcingStatus == "Approved" && y.MMBatchProductItemOutSourcingResourceType == "Inventory").FirstOrDefault();
                                if (objBatchProductItemOutSourcingsInfo != null)
                                {
                                    x.MMBatchProductItemOutSourcingProductQty = objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingProductQty;
                                    x.MMBatchProductProductionNormItemNeedMakeQty = (x.MMBatchProductProductionNormItemQuantity *(decimal)( 1.02) - (x.MMBatchProductItemOutSourcingProductQty == null ? 0 : x.MMBatchProductItemOutSourcingProductQty));
                                }
                                else
                                {
                                    objBatchProductItemOutSourcingsInfo = entity.BatchProductItemOutSourcingList.Where(y => y.FK_MMBatchProductProductionNormItemID == x.MMBatchProductProductionNormItemParentID 
                                    && y.MMBatchProductItemOutSourcingStatus == "Approved" && y.MMBatchProductItemOutSourcingResourceType == "Inventory").FirstOrDefault();
                                    if (objBatchProductItemOutSourcingsInfo != null)
                                        x.MMBatchProductProductionNormItemNeedMakeQty = x.MMBatchProductProductionNormItemQuantity * (decimal)(1.02)
                                            - (objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingProductQty * x.MMBatchProductProductionNormItemQuantityPerOne);
                                    else x.MMBatchProductProductionNormItemNeedMakeQty = x.MMBatchProductProductionNormItemQuantity * (decimal)(1.02);
                                }
                                mProcesssItem = mProcesssCtrl.GetByItemID(x.MMBatchProductProductionNormItemID).FirstOrDefault();
                                if (mProcesssItem != null)
                                {
                                    x.MMBatchProductProductionNormPaintProcess = objProcesssController.GetObjectNameByID(mProcesssItem.FK_MMProcessID);
                                }
                            });
                        }
                    });

                    report.bindingSource8.DataSource = batchproductItemList;
                    //enablereport
                    EnableReportDetail(report, BatchProductGroup.SemiProduct.ToString());
                    guiReportPreview viewer = new guiReportPreview(report);
                    viewer.Show();
                    ActionCancel();
                }
                else
                {
                    ActionCancel();
                }
            }
        }

        static string BytesToStringConverted(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        #endregion

        public void SetGeneralItemInfo(MMBatchProductItemsInfo item)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;

            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objBatchProductsInfo.FK_ARCustomerID);
            if (objCustomersInfo != null)
            {
                item.ARCustomerName = objCustomersInfo.ARCustomerName;
            }
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                item.ICProductNo = objProductsInfo.ICProductNo;
            }

            item.MMBatchProductNo = objBatchProductsInfo.MMBatchProductNo;
            item.MMBatchProductPrintDate = DateTime.Now;

            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objBatchProductsInfo.FK_ICProductAttributeTTMTID);
            if (objProductAttributesInfo != null)
            {
                item.MMBatchProductItemTTMT = objProductAttributesInfo.ICProductAttributeValue;
            }

        }
        public void SetHWQuantity(List<MMBatchProductProductionNormItemsInfo> harwadeList, decimal quantity)
        {
            if (quantity > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in harwadeList)
                {
                    item.MMBatchProductProductionNormItemQuantityPerOne = item.MMBatchProductProductionNormItemQuantity / quantity;
                }
            }
        }

        public void SetPaintQuantity(List<MMBatchProductProductionNormItemsInfo> paintList, decimal quantity)
        {
            if (quantity > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in paintList)
                {
                    item.MMBatchProductProductionNormItemQuantityPerOne = item.MMBatchProductProductionNormItemQuantity / quantity;

                }
            }
        }

        public void SetPackagingQuantity(List<MMBatchProductProductionNormItemsInfo> packagingList, decimal quantity)
        {
            if (quantity > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in packagingList)
                {
                    item.MMBatchProductProductionNormItemQuantityPerOne = item.MMBatchProductProductionNormItemQuantity / quantity;

                }
            }
        }

        public void SetGeneralMaterialQuantity(List<MMBatchProductProductionNormItemsInfo> generalMaterialList, decimal quantity)
        {
            if (quantity > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in generalMaterialList)
                {
                    item.MMBatchProductProductionNormItemQuantityPerOne = item.MMBatchProductProductionNormItemQuantity / quantity;

                }
            }
        }

        public List<MMBatchProductProductionNormItemsInfo> GetListFromProductionNormItemTreeList(BOSTreeList ProductionNormItemList)
        {
            List<MMBatchProductProductionNormItemsInfo> productionNormItemsList = new List<MMBatchProductProductionNormItemsInfo>();
            foreach (MMBatchProductProductionNormItemsInfo item in ProductionNormItemList)
            {
                productionNormItemsList.Add(item);
                if (item.MMBatchProductProductionNormItemIsComponent && item.SubList != null)
                {
                    item.MMBatchProductProductionNormItemParentOrderName = item.MMBatchProductProductionNormItemProductName;
                    foreach (MMBatchProductProductionNormItemsInfo itemChild in item.SubList)
                    {
                        productionNormItemsList.Add(itemChild);
                    }
                }
            }
            return productionNormItemsList;
        }
        /// <summary>
        /// Enable report detail
        /// </summary>
        /// <param name="report">report</param>
        /// <param name="productType">productType</param>
        public void EnableReportDetail(XtraReport report, string productType)
        {
            if (report.Bands[ProductType.SemiProduct.ToString()] != null)
                report.Bands[ProductType.SemiProduct.ToString()].Visible = false;
            if (report.Bands[ProductType.Hardware.ToString()] != null)
                report.Bands[ProductType.Hardware.ToString()].Visible = false;
            if (report.Bands[ProductType.IngredientPackaging.ToString()] != null)
                report.Bands[ProductType.IngredientPackaging.ToString()].Visible = false;
            if (report.Bands[ProductType.IngredientPaint.ToString()] != null)
                report.Bands[ProductType.IngredientPaint.ToString()].Visible = false;
            if (report.Bands[ProductType.GeneralMaterial.ToString()] != null)
                report.Bands[ProductType.GeneralMaterial.ToString()].Visible = false;
            XRLabel pageHeader = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblPageHeader"];

            if (productType == ProductType.SemiProduct.ToString())
            {
                report.Bands[ProductType.SemiProduct.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = BatchProductLocalizedResources.SemiProductReportText;
            }
            else if (productType == ProductType.Hardware.ToString())
            {
                report.Bands[ProductType.Hardware.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = BatchProductLocalizedResources.HardwareReportText;
            }
            else if (productType == ProductType.IngredientPackaging.ToString())
            {
                if (report.Bands[ProductType.IngredientPackaging.ToString()] != null)
                    report.Bands[ProductType.IngredientPackaging.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = BatchProductLocalizedResources.PackagingReportText;
            }
            else if (productType == ProductType.IngredientPaint.ToString())
            {
                report.Bands[ProductType.IngredientPaint.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = BatchProductLocalizedResources.PaintReportText;
            }
            else if (productType == ProductType.GeneralMaterial.ToString())
            {
                report.Bands[ProductType.GeneralMaterial.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = BatchProductLocalizedResources.GeneralMaterialReportText;
            }
            else
            {
                report.Bands[ProductType.SemiProduct.ToString()].Visible = true;
                report.Bands[ProductType.Hardware.ToString()].Visible = true;
                report.Bands[ProductType.IngredientPackaging.ToString()].Visible = true;
                report.Bands[ProductType.IngredientPaint.ToString()].Visible = true;
            }

            if (BOSApp.CurrentCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyAddressLine3"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyInfo"];
                if (label != null)
                {
                    label.Text = string.Format("ĐT: {0} | Email: {1} | Website: {2}", BOSApp.CurrentCompanyInfo.CSCompanyPhone
                    , BOSApp.CurrentCompanyInfo.CSCompanyEmail, BOSApp.CurrentCompanyInfo.CSCompanyWebsite);

                }
                if (report.Bands[BandKind.GroupHeader] != null)
                {
                    label = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblCSCompanyName"];
                    if (label != null)
                    {
                        label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                    }

                    label = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblCSCompanyAddressLine3"];
                    if (label != null)
                    {
                        label.Text = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
                    }

                    label = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblCSCompanyInfo"];
                    if (label != null)
                    {
                        label.Text = string.Format("ĐT: {0} | Email: {1} | Website: {2}", BOSApp.CurrentCompanyInfo.CSCompanyPhone
                        , BOSApp.CurrentCompanyInfo.CSCompanyEmail, BOSApp.CurrentCompanyInfo.CSCompanyWebsite);
                    }
                }
            }
        }
        public void UpdateResource(MMBatchProductProductionNormItemsInfo bpPnitem, string type)
        {
            if (bpPnitem != null)
            {
                bpPnitem.MMBatchProductProductionNormItemResourceType = type;
                if (bpPnitem.SubList != null)
                {
                    foreach (MMBatchProductProductionNormItemsInfo item in bpPnitem.SubList)
                    {
                        UpdateResource(item, type);
                    }
                }
            }
        }
        public void EditBatchProducProductionNormItemWoodResourceType()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductWoodStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();


                MMBatchProductProductionNormItemsInfo objCurrentItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
                if (objCurrentItemsInfo != null)
                {
                    if (objCurrentItemsInfo.MMBatchProductProductionNormItemResourceType != BatchProductProductionNormItemResourceType.Manafacturing.ToString())
                    {
                        UpdateResource(objCurrentItemsInfo, objCurrentItemsInfo.MMBatchProductProductionNormItemResourceType);
                        entity.BatchProductProductionNormItemList.TreeListControl.RefreshDataSource();
                        entity.BatchProductProductionNormItemList.TreeListControl.ExpandAll();
                        entity.BatchProductProductionNormItemList.TreeListControl.BestFitColumns();
                    }
                }
            }
        }
        public void EditBatchProducProductionNormItemHW()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductHWStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();
            }
        }
        public void EditBatchProducProductionNormItemPaint()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductPaintStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();
            }
        }
        public void EditBatchProducProductionNormItemPackaging()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.MMBatchProductPackagingStatus != BatchProductStatus.Approved.ToString())
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();
            }
        }

        public void CalculateProductionNormItemWoodType(MMBatchProductProductionNormItemsInfo item)
        {
            #region Controller
            ICProductsController objProductsController = new ICProductsController();
            //Công thức khối tinh, m2, m3
            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();

            MMFormulaConfigurationsController objFormulasController = new MMFormulaConfigurationsController();
            #endregion


            #region Khối tinh - MMProductionNormItemWoodBlocks
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = objProductionNormItemConfigsController.GetProductionNormItemConfigByWoodTypeID(objProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
                if (objProductionNormItemConfigsInfo != null)
                {

                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                    {
                        item.MMBatchProductProductionNormItemWoodBlocks = (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductWidth * item.MMBatchProductProductionNormItemProductHeight * item.MMBatchProductProductionNormItemQuantity) / 1000000000;
                        item.MMBatchProductProductionNormItemBlocks = item.MMBatchProductProductionNormItemWoodBlocks;
                    }

                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                    {
                        item.MMBatchProductProductionNormItemMDFBlocks = (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductWidth * item.MMBatchProductProductionNormItemProductHeight * item.MMBatchProductProductionNormItemQuantity) / 1000000000;
                        item.MMBatchProductProductionNormItemBlocks = item.MMBatchProductProductionNormItemMDFBlocks;
                    }

                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                    {
                        item.MMBatchProductProductionNormItemPlywood = (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductWidth * item.MMBatchProductProductionNormItemQuantity) / 1000000;
                        item.MMBatchProductProductionNormItemBlocks = 0;
                    }

                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                    {
                        item.MMBatchProductProductionNormItemVeneer = (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductWidth * item.MMBatchProductProductionNormItemQuantity) / 1000000;
                        item.MMBatchProductProductionNormItemBlocks = 0;
                    }
                }
            }
            #endregion

            #region SP (M2)
            item.MMBatchProductProductionNormItemAcreage = item.MMBatchProductProductionNormItemQuantity * (2 * (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductWidth) + 2 * (item.MMBatchProductProductionNormItemProductLength * item.MMBatchProductProductionNormItemProductHeight) + 2 * (item.MMBatchProductProductionNormItemProductHeight * item.MMBatchProductProductionNormItemProductWidth)) / 1000000;
            #endregion

            #region MMProductionNormItemTotalWoodConsumable - KL tiêu hao
            item.MMBatchProductProductionNormItemTotalWoodConsumable = item.MMBatchProductProductionNormItemWoodBlocks * item.MMBatchProductProductionNormItemDepreciationRate;
            #endregion

            #region DT Sơn A (M2) - MMProductionNormItemPaintA

            MMFormulaConfigurationsInfo objFormulasInfo = new MMFormulaConfigurationsInfo();
            decimal surFace = CalSurFace(item);
            decimal longEdge = CalLongEdge(item);
            decimal shortEdge = CalShortEdge(item);
            objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintA);
            if (objFormulasInfo != null)
            {
                item.MMBatchProductProductionNormItemPaintA = (item.MMBatchProductProductionNormItemQuantity
                    * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                    + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                    + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / 1000000;
            }
            #endregion

            #region DT Sơn B (M2) - MMProductionNormItemPaintB
            objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintB);
            if (objFormulasInfo != null)
            {
                item.MMBatchProductProductionNormItemPaintB = (item.MMBatchProductProductionNormItemQuantity
                    * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                    + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                    + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / 1000000;
            }
            #endregion


            if (item.SubList != null && item.SubList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo subItem in item.SubList)
                {
                    #region Khối tinh - MMProductionNormItemWoodBlocks
                    ICProductsInfo objSubProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(subItem.FK_ICProductID);
                    if (objSubProductsInfo != null)
                    {
                        MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = objProductionNormItemConfigsController.GetProductionNormItemConfigByWoodTypeID(objSubProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
                        if (objProductionNormItemConfigsInfo != null)
                        {

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                            {
                                subItem.MMBatchProductProductionNormItemWoodBlocks = (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductWidth * subItem.MMBatchProductProductionNormItemProductHeight * subItem.MMBatchProductProductionNormItemQuantity) / 1000000000;
                                subItem.MMBatchProductProductionNormItemBlocks = subItem.MMBatchProductProductionNormItemWoodBlocks;
                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                            {
                                subItem.MMBatchProductProductionNormItemMDFBlocks = (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductWidth * subItem.MMBatchProductProductionNormItemProductHeight * subItem.MMBatchProductProductionNormItemQuantity) / 1000000000;
                                subItem.MMBatchProductProductionNormItemBlocks = subItem.MMBatchProductProductionNormItemMDFBlocks;
                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                            {
                                subItem.MMBatchProductProductionNormItemPlywood = (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductWidth * subItem.MMBatchProductProductionNormItemQuantity) / 1000000;
                                subItem.MMBatchProductProductionNormItemBlocks = 0;
                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                            {
                                subItem.MMBatchProductProductionNormItemVeneer = (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductWidth * subItem.MMBatchProductProductionNormItemQuantity) / 1000000;
                                subItem.MMBatchProductProductionNormItemBlocks = 0;
                            }
                        }
                    }
                    #endregion

                    #region SP (M2)
                    subItem.MMBatchProductProductionNormItemAcreage = subItem.MMBatchProductProductionNormItemQuantity * (2 * (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductWidth) + 2 * (subItem.MMBatchProductProductionNormItemProductLength * subItem.MMBatchProductProductionNormItemProductHeight) + 2 * (subItem.MMBatchProductProductionNormItemProductHeight * subItem.MMBatchProductProductionNormItemProductWidth)) / 1000000;
                    #endregion

                    #region MMProductionNormItemTotalWoodConsumable - KL gỗ tiêu hao
                    subItem.MMBatchProductProductionNormItemTotalWoodConsumable = subItem.MMBatchProductProductionNormItemWoodBlocks * subItem.MMBatchProductProductionNormItemDepreciationRate;
                    #endregion



                    decimal surFaceSub = CalSurFace(subItem);
                    decimal longEdgeSub = CalLongEdge(subItem);
                    decimal shortEdgeSub = CalShortEdge(subItem);

                    #region DT Sơn A (M2) - MMProductionNormItemPaintA
                    objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintA);
                    if (objFormulasInfo != null)
                    {
                        subItem.MMBatchProductProductionNormItemPaintA = (subItem.MMBatchProductProductionNormItemQuantity
                            * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                            + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                            + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / 1000000;
                    }

                    #endregion

                    #region DT Sơn B (M2) - MMProductionNormItemPaintB
                    objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintB);
                    if (objFormulasInfo != null)
                    {
                        subItem.MMBatchProductProductionNormItemPaintB = (subItem.MMBatchProductProductionNormItemQuantity
                            * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                            + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                            + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / 1000000;
                    }
                    #endregion


                }
            }
        }
        public decimal CalSurFace(MMBatchProductProductionNormItemsInfo item)
        {
            return item.MMBatchProductProductionNormItemProductWidth * item.MMBatchProductProductionNormItemProductLength;
        }
        public decimal CalLongEdge(MMBatchProductProductionNormItemsInfo item)
        {
            return item.MMBatchProductProductionNormItemProductHeight * item.MMBatchProductProductionNormItemProductLength;
        }
        public decimal CalShortEdge(MMBatchProductProductionNormItemsInfo item)
        {
            return item.MMBatchProductProductionNormItemProductHeight * item.MMBatchProductProductionNormItemProductWidth;
        }

        public bool CheckDeliveryDate(DateTime date, bool isCheck)
        {
            bool isValid = true;
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
                ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                if (!isCheck)
                {
                    objBatchProductsInfo.MMBatchProductDeliveryDate = date;
                    if (BOSApp.ShowMessageYesNo("Bạn có muốn thay đổi ngày giao cho tất cả chi tiết không?") == DialogResult.Yes)
                    {
                        entity.BatchProductItemList.ForEach(b => b.MMBatchProductItemDeliveryDate = date);
                        entity.BatchProductItemList.GridControl?.RefreshDataSource();
                    }
                }
                else
                {
                    List<string> soiID = entity.BatchProductItemList.Where(o => o.FK_ARSaleOrderItemID > 0).Select(b => b.FK_ARSaleOrderItemID.ToString()).Distinct().ToList();
                    if (soiID != null && soiID.Count > 0)
                    {
                        List<ARSaleOrderItemsInfo> SaleOrderList = objSaleOrderItemsController.GetSOItemsListByListID(string.Join(",", soiID.ToArray()));
                        if (SaleOrderList != null && SaleOrderList.Count > 0)
                        {
                            DateTime maxDeliveryDate = SaleOrderList.Max(o => o.ARSaleOrderItemDeliveryDate);
                            if (objBatchProductsInfo.MMBatchProductDeliveryDate.Date < maxDeliveryDate.Date)
                            {
                                MessageBox.Show(BatchProductLocalizedResources.DeliveryDateMessage,
                                                MESLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                isValid = false;
                            }
                        }
                        objBatchProductsInfo.MMBatchProductSaleOrderNo = string.Join(",", SaleOrderList.Select(o => o.ARSaleOrderNo).Distinct().ToArray());
                        objBatchProductsInfo.MMBatchProductPONo = string.Join(",", SaleOrderList.Select(o => o.ARSaleOrderItemPONo).Distinct().ToArray());
                    }
                }
            }
            return isValid;
        }
        public void RefreshWood()
        {
            RefreshTreeView(fld_tabSemiProductName);
        }
        public void RefreshHardware()
        {
            RefreshTreeView(fld_tabHardwareName);
        }
        public void RefreshPackaging()
        {
            RefreshTreeView(fld_tabPackagingName);
        }
        public void RefreshPaint()
        {
            RefreshTreeView(fld_tabPaintName);
        }
        public void RefreshTreeView(string tabName)
        {
            EnableToolbar();
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (tabName == fld_tabSemiProductName)
            {
                InvalidateTreeView(tabName, false);
                entity.RefreshTreeView(entity.BatchProductProductionNormItemList);
            }
            if (tabName == fld_tabHardwareName)
            {
                InvalidateTreeView(tabName, false);
                entity.RefreshTreeView(entity.ProductionNormItemHardwareList);
            }
            if (tabName == fld_tabPaintName)
            {
                InvalidateTreeView(tabName, false);
                entity.RefreshTreeView(entity.ProductionNormItemPaintList);
            }
            if (tabName == fld_tabPackagingName)
            {
                InvalidateTreeView(tabName, false);
                entity.RefreshTreeView(entity.ProductionNormItemPackagingList);
            }
            if (tabName == fld_tabGeneralMaterial)
            {
                InvalidateTreeView(tabName, false);
                entity.RefreshTreeView(entity.ProductionNormItemGeneralMaterialList);
            }

        }

        public void InvalidateTreeView(string tabName, bool refreshBindingSource)
        {
            BOSProgressBar.Start("Đang tải dữ liệu");
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductProductionNormItemsController obj = new MMBatchProductProductionNormItemsController();
            if (tabName == fld_tabSemiProductName)
            {
                if (!HaveFocusWood || refreshBindingSource)
                {
                    HaveFocusWood = true;
                    List<MMBatchProductProductionNormItemsInfo> collection = obj.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.SemiProduct.ToString());
                    collection = collection.Where(o => o.MMBatchProductProductionNormItemType != "OverBOM").OrderBy(x => x.MMBatchProductProductionNormItemParentNo).ThenBy(x=> x.MMBatchProductProductionNormItemParentOrderName).ToList();
                    entity.BatchProductProductionNormItemList.Invalidate(collection, 0);
                    //entity.InvalidateListHaveParent(entity.BatchProductProductionNormItemList);
                    if (SumGoM3Control != null)
                    {
                        SumGoM3Control.EditValue = collection.Where(o => o.MMBatchProductProductionNormItemGroup == ProductType.SemiProduct.ToString()).Where(o => o.FK_ICProductID != o.FK_ICProductForBatchID ).Sum(o => o.MMBatchProductProductionNormItemBlocks);
                    }
                }
            }
            else if (tabName == fld_tabHardwareName)
            {
                if (!HaveFocusHardware || refreshBindingSource)
                {
                    HaveFocusHardware = true;
                    List<MMBatchProductProductionNormItemsInfo> collection = obj.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.Hardware.ToString());
                    collection = collection.Where(o => o.MMBatchProductProductionNormItemType != "OverBOM").OrderBy(x=> x.MMBatchProductProductionNormItemSortOrder).ToList();
                    entity.ProductionNormItemHardwareList.Invalidate(collection, 0);
                    GroupBatchProductProductionNormItem(entity.ProductionNormItemHardwareList, ProductType.Hardware.ToString());
                }
            }
            else if (tabName == fld_tabPaintName)
            {
                if (!HaveFocusPaint || refreshBindingSource)
                {
                    HaveFocusPaint = true;
                    List<MMBatchProductProductionNormItemsInfo> collection = obj.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.IngredientPaint.ToString());
                    collection = collection.Where(o => o.MMBatchProductProductionNormItemType != "OverBOM").ToList();
                    entity.ProductionNormItemPaintList.Invalidate(collection, 0);
                    GroupBatchProductProductionNormItem(entity.ProductionNormItemPaintList, ProductType.IngredientPaint.ToString());
                }
            }
            else if (tabName == fld_tabPackagingName)
            {
                if (!HaveFocusPackaging || refreshBindingSource)
                {
                    HaveFocusPackaging = true;

                    List<MMBatchProductProductionNormItemsInfo> collection = obj.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.IngredientPackaging.ToString());
                    collection = collection.Where(o => o.MMBatchProductProductionNormItemType != "OverBOM").OrderByDescending(x => x.MMBatchProductProductionNormItemSortOrder).ToList();
                    entity.ProductionNormItemPackagingList.Invalidate(collection, 0);
                    GroupBatchProductProductionNormItem(entity.ProductionNormItemPackagingList, ProductType.IngredientPackaging.ToString());
                }
            }
            else if (tabName == fld_tabGeneralMaterial)
            {
                if (!HaveFocusGeneralMaterial || refreshBindingSource)
                {
                    HaveFocusGeneralMaterial = true;
                    List<MMBatchProductProductionNormItemsInfo> collection = obj.GetBatchProductProductionNormItemsByBatchProductIDAndProductGroup(objBatchProductsInfo.MMBatchProductID, ProductType.GeneralMaterial.ToString());
                    collection = collection.Where(o => o.MMBatchProductProductionNormItemType != "OverBOM").ToList();
                    entity.ProductionNormItemGeneralMaterialList.Invalidate(collection, 0);
                    GroupBatchProductProductionNormItem(entity.ProductionNormItemGeneralMaterialList, ProductType.GeneralMaterial.ToString());
                }
            }
            BOSProgressBar.Close();
        }

        public void ChangeResourceType(string resourceType)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;

            objBatchProductsInfo.MMBatchProductResourceType = resourceType;
            foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
            {
                item.MMBatchProductItemResourceType = objBatchProductsInfo.MMBatchProductResourceType;

                if (entity.BatchProductProductionNormItemList != null && entity.BatchProductProductionNormItemList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo objParent in entity.BatchProductProductionNormItemList)
                    {
                        if (objParent.FK_MMBatchProductItemID == item.MMBatchProductItemID)
                        {
                            objParent.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;

                            if (objParent.SubList != null && objParent.SubList.Count > 0)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo objChild in objParent.SubList)
                                {
                                    objChild.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;
                                    if (objChild.SubList != null && objChild.SubList.Count > 0)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo obj in objChild.SubList)
                                        {
                                            obj.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    entity.BatchProductProductionNormItemList.TreeListControl.RefreshDataSource();
                }

                entity.BatchProductItemList.GridControl?.RefreshDataSource();
            }

        }

        public void ChangeResourceTypeForProductionNormItem(string resourceType)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            foreach (MMBatchProductItemsInfo item in entity.BatchProductItemList)
            {
                if (entity.BatchProductProductionNormItemList != null && entity.BatchProductProductionNormItemList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo objParent in entity.BatchProductProductionNormItemList)
                    {
                        if (objParent.FK_MMBatchProductItemID == item.MMBatchProductItemID)
                        {
                            objParent.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;

                            if (objParent.SubList != null && objParent.SubList.Count > 0)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo objChild in objParent.SubList)
                                {
                                    objChild.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;
                                    if (objChild.SubList != null && objChild.SubList.Count > 0)
                                    {
                                        foreach (MMBatchProductProductionNormItemsInfo obj in objChild.SubList)
                                        {
                                            obj.MMBatchProductProductionNormItemResourceType = item.MMBatchProductItemResourceType;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    entity.BatchProductProductionNormItemList.TreeListControl.RefreshDataSource();
                }
            }
        }
        public bool CanApprove(string productType)
        {
            bool canApprove = true;

            MMBatchProductItemsController batchProductItemsController = new MMBatchProductItemsController();

            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;

            canApprove = batchProductItemsController.CheckInvalidBatchProductItem(mainObject.MMBatchProductID, productType);

            if (!canApprove)
            {
                MessageBox.Show(BatchProductLocalizedResources.MissBOMMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return canApprove;

        }

        public void RebuildTreeList(BOSTreeList treeList, MMBatchProductItemsInfo batchproductItem)
        {
            if (treeList != null && batchproductItem != null)
            {
                MMBatchProductProductionNormItemsInfo parent = new MMBatchProductProductionNormItemsInfo();
                parent.MMBatchProductProductionNormItemNo = batchproductItem.ICProductNo;
                parent.MMBatchProductProductionNormItemProductName = batchproductItem.MMBatchProductItemProductName;
                parent.MMBatchProductProductionNormItemQuantity = batchproductItem.MMBatchProductItemProductQty;
                parent.SubList = new BOSTreeList();
                int count = treeList.Count;
                for (int index = count - 1; index >= 0; index--)
                {
                    MMBatchProductProductionNormItemsInfo subItem = treeList[index] as MMBatchProductProductionNormItemsInfo;
                    if (subItem.FK_MMBatchProductItemID == batchproductItem.MMBatchProductItemID)
                    {
                        parent.SubList.Add(subItem);
                        treeList.RemoveAt(index);
                    }
                }
                treeList.Add(parent);
            }
        }

        public void GroupBatchProductProductionNormItem(BOSTreeList BatchProductProductionNormItemListGroup, string productGroup)
        {
            BatchProductEntities entity = CurrentModuleEntity as BatchProductEntities;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            ICProductsController objProductsController = new ICProductsController();
            List<int> productIDList = new List<int>();
            List<MMBatchProductProductionNormItemsInfo> rootNodes = new List<MMBatchProductProductionNormItemsInfo>();

            foreach (MMBatchProductItemsInfo bpItem in entity.BatchProductItemList)
            {
                if (productGroup == ProductType.Hardware.ToString())
                //&& bpItem.MMBatchProductItemHardwareStatus)
                {
                    if (BatchProductProductionNormItemListGroup != null
                        && BatchProductProductionNormItemListGroup.Any())
                    {
                        RebuildTreeList(BatchProductProductionNormItemListGroup, bpItem);
                    }
                }
                else if (productGroup == ProductType.IngredientPaint.ToString())
                //&& bpItem.MMBatchProductItemPaintStatus)
                {
                    if (BatchProductProductionNormItemListGroup != null
                         && BatchProductProductionNormItemListGroup.Any())
                    {
                        RebuildTreeList(BatchProductProductionNormItemListGroup, bpItem);
                    }
                }
                else if (productGroup == ProductType.IngredientPackaging.ToString())
                //&& bpItem.MMBatchProductItemPackagingStatus)
                {
                    if (BatchProductProductionNormItemListGroup != null
                         && BatchProductProductionNormItemListGroup.Any())
                    {
                        RebuildTreeList(BatchProductProductionNormItemListGroup, bpItem);
                    }
                }
                else if (productGroup == ProductType.GeneralMaterial.ToString())
                {
                    if (BatchProductProductionNormItemListGroup != null
                          && BatchProductProductionNormItemListGroup.Any())
                    {
                        RebuildTreeList(BatchProductProductionNormItemListGroup, bpItem);
                    }
                }
            }
        }

        public void AllowEditGridView(bool isTrue)
        {
            isTrue = false;
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (objBatchProductsInfo.FK_ARProductionPlanningID > 0)
            {
                MessageBox.Show("Invalid input", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                isTrue = true;
            }
            else
                BatchProductItemGridControl.Columns["MMBatchProductItemProductQty"].OptionsColumn.AllowEdit = true;
        }
        #region Print Routing
        public void PrintViewRoutingSemiProduct()
        {
            //RoutingSemiProduct(ProductType.SemiProduct.ToString());
            RoutingSemiProductNew(ProductType.SemiProduct.ToString());
        }
        public void PrintViewRoutingComponent()
        {
            //RoutingSemiProduct("Component");
        }
        public void PrintViewRoutingProduct()
        {
            //RoutingSemiProduct(ProductType.Product.ToString());
        }
        public void RoutingSemiProductNew(string type)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            ICProductsController objProductsController = new ICProductsController();
            if (mainObject.MMBatchProductStatus != BatchProductStatus.Approved.ToString())
            {
                MessageBox.Show("Vui lòng duyệt lệnh sản xuất trước!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MMBatchProductProductionNormItemsController objBPPNICon = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> objBPPNIList = new List<MMBatchProductProductionNormItemsInfo>();
            objBPPNIList = objBPPNICon.GetListForInRouting(type, mainObject.MMBatchProductID);
            guiFind<MMBatchProductProductionNormItemsInfo> gui = new guiFind<MMBatchProductProductionNormItemsInfo>(TableName.MMBatchProductProductionNormItemsTableName, objBPPNIList, this, true);
            if (gui.ShowDialog() == DialogResult.OK)
            {
                MMBatchProductProductionNormItemProcesssController objProcessCOnrtroller = new MMBatchProductProductionNormItemProcesssController();
                MMBatchProductProductionNormItemMeterialsController objMaterialController = new MMBatchProductProductionNormItemMeterialsController();
                gui.SelectedObjects = GroupProductionNormItem(gui.SelectedObjects.ToList());
                foreach (MMBatchProductProductionNormItemsInfo item in gui.SelectedObjects)
                {
                    item.KTTinh = string.Format("{0}x{1}x{2}", item.MMBatchProductProductionNormItemProductLength.ToString("n0")
                                                           , item.MMBatchProductProductionNormItemProductWidth.ToString("n0")
                                                           , item.MMBatchProductProductionNormItemProductHeight.ToString("n0"));

                    if (item.ICProductPicture != null)
                    {
                        MemoryStream stream = new MemoryStream(item.ICProductPicture);
                        item.ProductImage = System.Drawing.Bitmap.FromStream(stream);
                    }
                    item.ProductItemImage = GetImageForSemiProduct(item);
                    item.ProductBarcodeImage = BOSERP.Utilities.Code128Rendering.MakeBarcodeLargeImage(item.MMBatchProductProductionNormItemBarcode, 1, false);
                    item.ProcessList = new List<MMBatchProductProductionNormItemProcesssInfo>();
                    //item.ProcessList.AddRange(objProcessCOnrtroller.GetListByBatProductProductionNormItemID(item.MMBatchProductProductionNormItemID));
                    //item.MaterialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
                    //item.MaterialList.AddRange(objMaterialController.GetListByBatchProductProductionNormItemID(item.MMBatchProductProductionNormItemID));
                }
                BatchProductRoutingNew report = new BatchProductRoutingNew();
                report.MMBatchProductProductionNormItems.DataSource = gui.SelectedObjects;
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }
        public List<ImageWithName> CurrentImageList;
        public class ImageWithName
        {
            public Image Img { get; set; }
            public string ImgName { get; set; }
            public string ImgPath { get; set; }

            public ImageWithName(Image img, string imgName, string imgPath)
            {
                Img = img;
                ImgName = imgName;
                ImgPath = imgPath;
            }
        }
        public Image GetImageForSemiProduct(MMBatchProductProductionNormItemsInfo objBPPNIInfo)
        {
            CurrentImageList = new List<ImageWithName>();
            List<Image> imgList = new List<Image>();
            List<string> fileName = BOSApp.GetFilesInFtpDirectory(ImageFolderType.TechnicalDrawing.ToString(), objBPPNIInfo.ProductForBatchNo, imgList);
            if (fileName != null)
            {
                ImageWithName imgWN;
                for (int i = 0; i < fileName.Count; i++)
                {
                    imgWN = new ImageWithName(imgList[i], fileName[i], string.Empty);
                    CurrentImageList.Add(imgWN);
                }
            }
            ImageWithName iwn = CurrentImageList.FirstOrDefault(t => t.ImgName == objBPPNIInfo.ProductImageName);
            Image img = null;
            if (iwn != null)
            {
                img = iwn.Img;
            }
            else
            {
                foreach (ImageWithName item in CurrentImageList)
                {
                    string[] nameSplit = item.ImgName.Split('.');
                    if (nameSplit != null)
                    {
                        string name = string.Empty;

                        for (int i = 0; i < nameSplit.Length - 1; i++)
                        {
                            name += nameSplit[i];
                        }

                        if (name == objBPPNIInfo.ICProductCode)
                        {
                            img = item.Img;
                            break;
                        }
                    }
                }
            }
            return img;

        }
        public List<MMBatchProductProductionNormItemsInfo> GroupProductionNormItem(List<MMBatchProductProductionNormItemsInfo> dataList)
        {
            List<MMBatchProductProductionNormItemsInfo> filterList = new List<MMBatchProductProductionNormItemsInfo>();

            foreach (MMBatchProductProductionNormItemsInfo item in dataList)
            {
                MMBatchProductProductionNormItemsInfo obj = filterList.Where(i => i.FK_ICProductID == item.FK_ICProductID
                                                                                 && i.ProductForBatchNo == item.ProductForBatchNo).FirstOrDefault();
                if (obj != null)
                {
                    obj.MMBatchProductItemProductQty += item.MMBatchProductItemProductQty;
                    obj.MMBatchProductProductionNormItemQuantity += item.MMBatchProductProductionNormItemQuantity;
                }
                else
                    filterList.Add(item);
            }
            return filterList;
        }

        public void RoutingSemiProduct(string type)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            ICProductsController objProductsController = new ICProductsController();
            if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Approved.ToString() ||
                objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Complete.ToString() ||
                objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Incomplete.ToString())
            {

                List<MMBatchProductItemOperationInfosInfo> listToPrint = new List<MMBatchProductItemOperationInfosInfo>();
                listToPrint = objBatchProductItemOperationInfosController.GetItemBySomeConditions(objBatchProductsInfo.MMBatchProductID, ProductType.SemiProduct.ToString(), true);
                if (listToPrint != null)
                {
                    if (type == ProductType.SemiProduct.ToString())
                        listToPrint = listToPrint.Where(x => x.MMBatchProductProductionNormItemIsComponent == false).ToList();
                    else if (type == ProductType.Product.ToString())
                        listToPrint = listToPrint.Where(x => x.MMBatchProductProductionNormItemGroup == ProductType.Product.ToString()).ToList();
                    else
                        listToPrint = listToPrint.Where(x => x.MMBatchProductProductionNormItemIsComponent == true
                            && x.MMBatchProductProductionNormItemGroup != ProductType.Product.ToString()).ToList();
                }

                guiChooseProductionNormOperationProcessInfos printOperation = new guiChooseProductionNormOperationProcessInfos(listToPrint);
                printOperation.Module = this;
                if (printOperation.ShowDialog() == DialogResult.OK)
                {
                    BatchProductRouting report = new BatchProductRouting();
                    List<MMBatchProductItemOperationInfosInfo> selectedList = printOperation.ProductionNormProcessInfoListSelected;
                    if (selectedList != null)
                    {
                        List<MMBatchProductItemOperationInfosInfo> processPrintList = new List<MMBatchProductItemOperationInfosInfo>();

                        foreach (MMBatchProductItemOperationInfosInfo item in selectedList)
                        {
                            ICProductsInfo objProductsInfo = new ICProductsInfo();
                            MMBatchProductItemsInfo objBatchProductItemsInfo = entity.BatchProductItemList.Where(x => x.MMBatchProductItemID == item.FK_MMBatchProductItemID).FirstOrDefault();
                            List<MMBatchProductItemOperationInfosInfo> processList = objBatchProductItemOperationInfosController.GetDataOperationProcesssByBarcode(item.FK_MMBatchProductProductionNormItemID
                                , item.FK_MMBatchProductItemID, item.FK_ICProductID, item.FK_MMProductionNormItemID);

                            if (item.MMOperationDetailPlanOperationBarCode == null || item.MMOperationDetailPlanOperationBarCode == string.Empty)
                            {
                                MessageBox.Show("Vui lòng duyệt lệnh sản xuất trước!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            item.MMOperationDetailPlanItemChildImage = BOSERP.Utilities.Code128Rendering.MakeBarcodeLargeImage(item.MMOperationDetailPlanOperationBarCode, 1, false);
                            if (objBatchProductItemsInfo != null)
                                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objBatchProductItemsInfo.FK_ICProductID);
                            if (type == ProductType.SemiProduct.ToString())
                            {
                                item.MMOperationDetailPlanItemChildQuyCach = item.MMBatchProductProductionNormItemProductHeight.ToString("N") + "x" +
                                                                                item.MMBatchProductProductionNormItemProductWidth.ToString("N") + "x" +
                                                                                item.MMBatchProductProductionNormItemProductLength.ToString("N");
                            }
                            else if (type == ProductType.Product.ToString())
                            {
                                if (objBatchProductItemsInfo != null)
                                    item.MMOperationDetailPlanItemChildQuyCach = objBatchProductItemsInfo.MMBatchProductItemProductHeight.ToString("N") + "x" +
                                                                                                        objBatchProductItemsInfo.MMBatchProductItemProductWidth.ToString("N") + "x" +
                                                                                                        objBatchProductItemsInfo.MMBatchProductItemProductLength.ToString("N");
                            }
                            else
                            {
                                item.MMOperationDetailPlanItemChildQuyCach = "";
                            }
                            item.MMOperationDetailPlanItemChildProductForBatchNo = item.ICProductNo;
                            item.MMOperationDetailPlanItemChildParentProductName = item.ICProductName;
                            item.MMOperationDetailPlanItemChildProductNo = item.MMBatchProductProductionNormItemNo;
                            item.MMOperationDetailPlanItemChildProductName = item.MMBatchProductProductionNormItemProductName;
                            item.MMOperationDetailPlanItemChildID = item.FK_MMBatchProductProductionNormItemID.ToString();
                            if (objProductsInfo != null && objProductsInfo.ICProductPicture != null)
                            {
                                MemoryStream stream = new MemoryStream(objProductsInfo.ICProductPicture);
                                item.MMOperationDetailPlanItemProductImage = System.Drawing.Bitmap.FromStream(stream);

                            }
                            if (processList != null && processList.Count > 0)
                            {
                                foreach (MMBatchProductItemOperationInfosInfo itemProcess in processList)
                                {
                                    itemProcess.MMOperationDetailPlanItemChildImage = item.MMOperationDetailPlanItemChildImage;
                                    itemProcess.MMOperationDetailPlanItemProductImage = item.MMOperationDetailPlanItemProductImage;
                                    itemProcess.MMOperationDetailPlanItemChildProductForBatchNo = item.ICProductNo;
                                    itemProcess.MMOperationDetailPlanItemChildParentProductName = item.ICProductName;
                                    itemProcess.MMOperationDetailPlanItemChildProductNo = item.MMBatchProductProductionNormItemNo;
                                    itemProcess.MMOperationDetailPlanItemChildProductName = item.MMOperationDetailPlanItemChildProductName;
                                    itemProcess.MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                                    itemProcess.MMOperationDetailPlanItemChildQuyCach = item.MMOperationDetailPlanItemChildQuyCach;
                                    itemProcess.MMOperationDetailPlanItemChildProductWoodType = item.MMOperationDetailPlanItemChildProductWoodType;
                                    itemProcess.MMOperationDetailPlanItemChildProductQty = item.MMOperationDetailPlanItemChildProductQty;
                                    itemProcess.MMOperationDetailPlanItemChildPIProductQty = item.MMOperationDetailPlanItemChildPIProductQty;
                                    itemProcess.MMOperationDetailPlanItemChildPlanProductQty = item.MMBatchProductProductionNormItemQuantity;
                                    itemProcess.MMOperationDetailPlanItemChildSaleOrdeNo = item.MMOperationDetailPlanItemChildSaleOrdeNo;
                                    itemProcess.MMBatchProductNo = objBatchProductsInfo.MMBatchProductNo;
                                }
                                processPrintList.AddRange(processList);

                            }
                        }
                        report.DataSource = processPrintList;
                        guiReportPreview reviewer = new guiReportPreview(report);
                        reviewer.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng duyệt lệnh sản xuất trước!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion


        #region Hardware detail
        public void ShowProductionNormItemHardwareDetail(MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            entity.batchProductProductionNormItemHardwareDetailList.Clear();

            if (objBatchProductProductionNormItemsInfo.FK_MMProductionNormItemID == 0) return;

            ICProductsController objProductsController = new ICProductsController();
            if (objBatchProductProductionNormItemsInfo != null)
            {

                MMBatchProductProductionNormItemHardwaresController objBatchProductProductionNormItemHardwaresController = new MMBatchProductProductionNormItemHardwaresController();
                List<MMBatchProductProductionNormItemHardwaresInfo> BatchProductProductionNormItemHardwaresInfoList = objBatchProductProductionNormItemHardwaresController.GetBatchProductProductionNormItemHardwareByForeign(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemID);

                if (BatchProductProductionNormItemHardwaresInfoList != null && BatchProductProductionNormItemHardwaresInfoList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemHardwaresInfo objBatchProductProductionNormItemHardwaresInfo in BatchProductProductionNormItemHardwaresInfoList)
                    {
                        entity.batchProductProductionNormItemHardwareDetailList.Add(objBatchProductProductionNormItemHardwaresInfo);
                    }
                }
                guiProductionNormItemHardware guiForm = new guiProductionNormItemHardware(entity.batchProductProductionNormItemHardwareDetailList);
                guiForm.Module = this;
                guiForm.ShowDialog();
            }
        }
        #endregion

        public void ShowItemMaterial(MMBatchProductProductionNormItemsInfo bppni)
        {
            MMBatchProductProductionNormItemMeterialsController mCtrl = new MMBatchProductProductionNormItemMeterialsController();
            List<MMBatchProductProductionNormItemMeterialsInfo> mList = mCtrl.GetByItemID(bppni.MMBatchProductProductionNormItemID);

            List<MMBatchProductProductionNormItemsInfo> bppniList = new List<MMBatchProductProductionNormItemsInfo>();
            bppniList.Add(bppni);

            guiBPProductionNormItemMeterials guiShowMaterial = new guiBPProductionNormItemMeterials(mList, bppniList);
            guiShowMaterial.Module = this;
            guiShowMaterial.ShowDialog();

        }

        public void ShowItemProcess(MMBatchProductProductionNormItemsInfo bppni)
        {
            MMBatchProductProductionNormItemProcesssController mCtrl = new MMBatchProductProductionNormItemProcesssController();
            List<MMBatchProductProductionNormItemProcesssInfo> mList = mCtrl.GetByItemID(bppni.MMBatchProductProductionNormItemID);

            List<MMBatchProductProductionNormItemsInfo> bppniList = new List<MMBatchProductProductionNormItemsInfo>();
            bppniList.Add(bppni);

            guiBPProductionNormItemProcesss guiShowProcess = new guiBPProductionNormItemProcesss(mList, bppniList);
            guiShowProcess.Module = this;
            guiShowProcess.ShowDialog();

        }
        internal void ChangeObject(string objectAccessKey)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            mainobject.ACObjectAccessKey = string.Empty;
            mainobject.FK_ACObjectID = 0;
            mainobject.MMObjectType = string.Empty;
            if (objObjectsInfo != null)
            {
                mainobject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainobject.MMObjectType = objObjectsInfo.ACObjectType;
                mainobject.ACObjectAccessKey = objectAccessKey;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeAttributeTTMT(int ttmtID)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            mainobject.FK_ICProductAttributeTTMTID = ttmtID;
            DialogResult rs = MessageBox.Show(BatchProductLocalizedResources.ChangeChangeAttributeTTMTMessages, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.BatchProductItemList.ForEach(o =>
            {
                o.FK_ICProductAttributeTTMTID = mainobject.FK_ICProductAttributeTTMTID;
            });
            entity.BatchProductItemList.GridControl?.RefreshDataSource();
        }

        public List<MMBatchProductProductionNormItemsInfo> GetBPSemiProductDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            List<MMBatchProductProductionNormItemsInfo> semiProductList = new List<MMBatchProductProductionNormItemsInfo>();
            entity.BatchProductProductionNormItemList.ConvertToList(semiProductList);
            semiProductList.Insert(0, new MMBatchProductProductionNormItemsInfo());
            return semiProductList;
        }

        public string GetBPSemiProductDisplayDisplayText(int bpProductionNormItemID)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            List<MMBatchProductProductionNormItemsInfo> semiProductList = new List<MMBatchProductProductionNormItemsInfo>();
            entity.BatchProductProductionNormItemList.ConvertToList(semiProductList);
            if (!semiProductList?.Any() ?? true)
            {
                InvalidateTreeView(fld_tabSemiProductName, false);
                entity.BatchProductProductionNormItemList.ConvertToList(semiProductList);
            }
            List<MMBatchProductProductionNormItemsInfo> packProductList = new List<MMBatchProductProductionNormItemsInfo>();
            string bpSemiProductName = string.Empty;
            entity.ProductionNormItemPackagingList.ConvertToList(packProductList);
            if (packProductList != null)
            {
                MMBatchProductProductionNormItemsInfo packItem = packProductList.Where(o => o.FK_MMBPSemiProductID == bpProductionNormItemID).FirstOrDefault();
                bpSemiProductName = packItem != null ? packItem.MMBPSemiProductName : string.Empty;
            }
            if (string.IsNullOrEmpty(bpSemiProductName))
                bpSemiProductName = semiProductList.Where(o => o.MMBatchProductProductionNormItemID == bpProductionNormItemID).Select(o => o.MMBatchProductProductionNormItemProductName).FirstOrDefault();
            return bpSemiProductName == null ? string.Empty : bpSemiProductName;
        }

        public void AddProductOutSouring()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            MMBatchProductProductionNormItemsController objPnisController = new MMBatchProductProductionNormItemsController();
            if (!entity.SemiProductStructure.Any())
            {
                DataSet ds = objPnisController.GetSemiProductStructure(mainobject.MMBatchProductID);
                List<TreeStructure> treeStructures = new List<TreeStructure>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        TreeStructure treeItem = (TreeStructure)SqlDatabaseHelper.GetObjectFromDataRow(row, typeof(TreeStructure));
                        treeStructures.Add(treeItem);
                    }
                }
                entity.SemiProductStructure.AddRange(treeStructures);
            }
            List<MMBatchProductProductionNormItemsInfo> bpPniList = objPnisController.GetItemForBatchProductOutsourcing(mainobject.MMBatchProductID);
            List<MMBatchProductItemOutSourcingsInfo> itemOutSourcingList = new List<MMBatchProductItemOutSourcingsInfo>();
            MMBatchProductItemOutSourcingsInfo objBatchProductItemOutSourcingsInfo = new MMBatchProductItemOutSourcingsInfo();

            bpPniList.ForEach(o =>
            {
                objBatchProductItemOutSourcingsInfo = ToBatchProductItemOutSourcings(o);
                itemOutSourcingList.Add(objBatchProductItemOutSourcingsInfo);
            });

            guiChooseBPItemOutSourcing guiFind = new guiChooseBPItemOutSourcing(itemOutSourcingList);
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            itemOutSourcingList = guiFind.SelectedObjects;
            entity.BatchProductItemOutSourcingList.AddRange(itemOutSourcingList);
            if (entity.BatchProductItemOutSourcingList.GridControl != null)
            {
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public bool IsAllowCreateOutsourcing(int batchProductID)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (mainobject.MMBatchProductWoodStatus != BatchProductStatus.Approved.ToString())
            {
                MessageBox.Show("Bán thành phẩm chưa duyệt. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            //bool isAllow = objBatchProductsController.IsAllowCreateOutsourcing(batchProductID);
            //if (!isAllow)
            //{
            //    MessageBox.Show("Đã có kế hoạch sử dụng hoặc kế hoạch mua hàng cho LSX này. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            return true;
        }

        public MMBatchProductItemOutSourcingsInfo ToBatchProductItemOutSourcings(MMBatchProductProductionNormItemsInfo item)
        {
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsForViewInfo();

            return new MMBatchProductItemOutSourcingsInfo()
            {
                FK_MMBatchProductID = item.FK_MMBatchProductID,
                FK_ICProductID = item.FK_ICProductID,
                FK_MMBatchProductItemID = item.FK_MMBatchProductItemID,
                FK_MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemID,
                MMBatchProductItemOutSourcingProductNo = objProductsInfo.ICProductNo,
                MMBatchProductItemOutSourcingProductName = objProductsInfo.ICProductName,
                MMBatchProductItemOutSourcingProductDesc = objProductsInfo.ICProductDesc,
                MMBatchProductItemOutSourcingGroup = item.MMBatchProductProductionNormItemGroup,
                MMBatchProductItemOutSourcingProductQty = item.MMBatchProductProductionNormItemQuantity,
                 ICProductName2 = item.ICProductName2,
                ICProductNoOfOldSys = item.MMBatchProductItemProductNoOfOldSys
            };
        }

        public void SaveOutSouringList()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (mainobject.MMBatchProductID == 0)
            {
                MessageBox.Show("Vui lòng lưu lệnh sản xuất trước!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsValidOutSourcingQty())
                return;

            try
            {
                entity.BatchProductItemOutSourcingList.SaveItemObjects();
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<MMOperationsInfo> GetOperationDataSourceOfSemiProduct(string group, int bpItemID, int bpPNItemID, string resourceType)
        {
            //if (resourceType != BatchProductProductionNormItemResourceType.OutSourcing.ToString())
            //    return new List<MMOperationsInfo>();

            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationByBPPNItemID(group, bpItemID, bpPNItemID);
            return operationsList;
        }

        public void DeleteItemOutSourcing()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.BatchProductItemOutSourcingList.CurrentIndex < 0)
                return;

            MMBatchProductItemOutSourcingsInfo item = entity.BatchProductItemOutSourcingList[entity.BatchProductItemOutSourcingList.CurrentIndex];
            if (item == null)
                return;

            if (item.MMBatchProductItemOutSourcingStatus != BatchProductItemOutSourcingStatus.New.ToString())
            {
                MessageBox.Show("Kế hoạch đã duyệt không thể xóa. Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.BatchProductItemOutSourcingList.Remove(item);
            if (entity.BatchProductItemOutSourcingList.GridControl != null)
            {
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public void ApproveOutSouringItems()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (entity.BatchProductItemOutSourcingList == null)
                return;

            if (!IsValidOutSourcingQty())
                return;

            if (!IsValidSavedItems())
                return;

            MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus != BatchProductItemOutSourcingStatus.New.ToString())
                        continue;

                    item.MMBatchProductItemOutSourcingStatus = BatchProductItemOutSourcingStatus.Approved.ToString();
                    objBatchProductItemOutSourcingsController.UpdateObject(item);
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public void UnApproveOutSouringItems()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (entity.BatchProductItemOutSourcingList == null)
                return;

            if (!IsValidSavedItems())
                return;

            if (!IsAllowCancelItems())
                return;

            MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus != BatchProductItemOutSourcingStatus.Approved.ToString())
                        continue;

                    item.MMBatchProductItemOutSourcingStatus = BatchProductItemOutSourcingStatus.New.ToString();
                    objBatchProductItemOutSourcingsController.UpdateObject(item);
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public bool IsAllowCancelItems()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            string messageError = string.Empty;

            MMBatchProductItemOutSourcingsController objOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            List<int> outsourcingRef = entity.BatchProductItemOutSourcingList.Select(o => o.MMBatchProductItemOutSourcingID).ToList();
            List<MMBatchProductItemOutSourcingsInfo> outsourcingList = objOutSourcingsController.GetItemUsedQty(string.Join(",", outsourcingRef.Select(o => o.ToString()).ToArray()));

            decimal remainQty = 0;
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    remainQty = outsourcingList.Where(o => o.MMBatchProductItemOutSourcingID == item.MMBatchProductItemOutSourcingID).Min(o => o.MMBatchProductItemOutSourcingRemainQty);

                    if (remainQty == item.MMBatchProductItemOutSourcingProductQty)
                        continue;

                    messageError += string.Format("BTP/TP {0} đã được sử dụng ở chứng từ khác.", item.MMBatchProductItemOutSourcingProductName);
                    messageError += Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(messageError))
                    return true;

                messageError += Environment.NewLine;
                messageError += "Vui lòng kiểm tra lại!";
                MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool IsValidSavedItems()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            string messageError = string.Empty;
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingID != 0)
                        continue;

                    messageError += string.Format("BTP/TP {0} chưa lưu.", item.MMBatchProductItemOutSourcingProductName);
                    messageError += Environment.NewLine;

                    if (!string.IsNullOrWhiteSpace(item.MMBatchProductItemOutSourcingResourceType))
                        continue;

                    messageError += string.Format("BTP/TP {0} chưa được xác định nguồn.", item.MMBatchProductItemOutSourcingProductName);
                    messageError += Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(messageError))
                    return true;

                messageError += Environment.NewLine;
                messageError += "Vui lòng kiểm tra lại!";
                MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void UpdateOutSouringItemNeedDate()
        {
            DateEdit dte = (DateEdit)Controls["fld_dteOutSourcingDate"];
            if (dte == null)
                return;

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus == BatchProductItemOutSourcingStatus.Approved.ToString())
                        continue;

                    item.MMBatchProductItemOutSourcingNeedDate = dte.DateTime;
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public void UpdateOutSouringItemResourceType()
        {
            BOSLookupEdit lke = (BOSLookupEdit)Controls["fld_lkeBatchProductItemOutSourcingResourceType"];
            if (lke == null)
                return;

            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus == BatchProductItemOutSourcingStatus.Approved.ToString())
                        continue;

                    item.MMBatchProductItemOutSourcingResourceType = lke.EditValue == null ? string.Empty : lke.EditValue.ToString();
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public void ActionCloseBatchProduct()
        {

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn Dừng toàn bộ lệnh sản xuất này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            Invalidate(Toolbar.CurrentObjectID);
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = objBatchProductsController.CheckIsAllowCloseBatchProduct(mainObject.MMBatchProductID);
            string errorMessages = string.Empty;
            if (objBatchProductsInfo.IsExistOperationDetailPlan && mainObject.MMBatchProductWoodStatus != BatchProductStatus.Closed.ToString())
            {
                errorMessages += "Đã có KHSXCT cho LSX này.";
                errorMessages += Environment.NewLine;
            }
            if (objBatchProductsInfo.IsExistBatchProductShedule && (mainObject.MMBatchProductHWStatus != BatchProductStatus.Closed.ToString()
              || mainObject.MMBatchProductPackagingStatus != BatchProductStatus.Closed.ToString()
              || mainObject.MMBatchProductPaintStatus != BatchProductStatus.Closed.ToString()
              || mainObject.MMBatchProductPackagingStatus != BatchProductStatus.Closed.ToString()
              || mainObject.MMBatchProductGeneralMaterialStatus != BatchProductStatus.Closed.ToString())
              )
            {
                errorMessages += "Đã có Kế hoạch sử dụng cho LSX này.";
                errorMessages += Environment.NewLine;
            }
            if (!string.IsNullOrWhiteSpace(errorMessages))
            {
                errorMessages += "Vui lòng kiểm tra lại!";
                MessageBox.Show(errorMessages, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.SetPropertyChangeEventLock(false);
            mainObject.MMBatchProductStatus = BatchProductStatus.Closed.ToString();
            mainObject.MMBatchProductWoodStatus = BatchProductStatus.Closed.ToString();
            mainObject.MMBatchProductHWStatus = BatchProductStatus.Closed.ToString();
            mainObject.MMBatchProductPackagingStatus = BatchProductStatus.Closed.ToString();
            mainObject.MMBatchProductPaintStatus = BatchProductStatus.Closed.ToString();
            mainObject.MMBatchProductGeneralMaterialStatus = BatchProductStatus.Closed.ToString();
            mainObject.FK_ADUserIDClosed = BOSApp.CurrentUsersInfo.ADUserID;
            mainObject.MMBatchProductClosedDate = BOSApp.GetCurrentServerDate();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            EnableToolbar();
        }

        public void CloseBatchProductOutSourcing()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            if (entity.BatchProductItemOutSourcingList == null)
                return;

            if (!IsValidSavedItems())
                return;

            if (!IsValidCloseItems())
                return;

            MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus == BatchProductItemOutSourcingStatus.Close.ToString())
                        continue;

                    item.MMBatchProductItemOutSourcingStatus = BatchProductItemOutSourcingStatus.Close.ToString();
                    objBatchProductItemOutSourcingsController.UpdateObject(item);
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
        }

        public bool IsValidCloseItems()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn dừng kế hoạch TP/BTP này?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return false;

            List<int> batchProductOutsourcingRef = new List<int>();
            MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            if (entity.BatchProductItemOutSourcingList.GridControl != null && entity.BatchProductItemOutSourcingList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                int[] rowSelected = gridView.GetSelectedRows();
                foreach (int i in rowSelected)
                {
                    MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(i);
                    if (item == null || i < 0)
                        continue;

                    if (item.MMBatchProductItemOutSourcingStatus == BatchProductItemOutSourcingStatus.Close.ToString())
                        continue;

                    batchProductOutsourcingRef.Add(item.MMBatchProductItemOutSourcingID);
                }
                entity.BatchProductItemOutSourcingList.GridControl?.RefreshDataSource();
            }
            MMBatchProductMessagesController objBatchProductMessagesController = new MMBatchProductMessagesController();
            List<MMBatchProductMessagesInfo> messagesList = objBatchProductMessagesController.ValidateCloseBatchProductOutSourcing(mainObject.MMBatchProductID, string.Join(",", batchProductOutsourcingRef.ToArray()));
            if (messagesList.Count(o => o.MMProductionStatus != "OK") == 0)
            {
                return true;
            }
            BOSProgressBar.Close();
            guiShowBatchProductMessage guiMessage = new guiShowBatchProductMessage(messagesList);
            guiMessage.Module = this;
            guiMessage.BatchProductID = mainObject.MMBatchProductID;
            guiMessage.MMProductionType = "OutSourcing";
            guiMessage.ShowDialog();
            return false;
        }

        public void CopyItemOutsourcingToNewRow()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;

            if (!IsAllowCreateOutsourcing(mainObject.MMBatchProductID))
                return;

            BOSList<MMBatchProductItemOutSourcingsInfo> itemList = entity.BatchProductItemOutSourcingList;
            MMBatchProductItemOutSourcingsInfo objBatchProductItemOutSourcingsInfo = new MMBatchProductItemOutSourcingsInfo();
            MMBatchProductItemOutSourcingsInfo itemClone = new MMBatchProductItemOutSourcingsInfo();
            if (itemList.GridControl != null && itemList.GridControl.MainView != null)
            {
                GridView gridView = (GridView)entity.BatchProductItemOutSourcingList.GridControl.MainView;
                objBatchProductItemOutSourcingsInfo = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objBatchProductItemOutSourcingsInfo == null)
                    return;
                if (objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingStatus == BatchProductItemOutSourcingStatus.Close.ToString())
                    return;

                itemClone = (MMBatchProductItemOutSourcingsInfo)objBatchProductItemOutSourcingsInfo.Clone();
                itemClone.MMBatchProductItemOutSourcingID = 0;
                itemClone.MMBatchProductItemOutSourcingStatus = BatchProductItemOutSourcingStatus.New.ToString();
                List<MMBatchProductItemOutSourcingsInfo> checkList = new List<MMBatchProductItemOutSourcingsInfo>();
                checkList.Add(itemClone);
                bool isValid = IsValidOutSourcingQty(checkList);
                if (!isValid)
                    return;

                itemList.Add(itemClone);
                itemList.GridControl?.RefreshDataSource();
            }
        }

        public bool IsValidOutSourcingQty(MMBatchProductItemOutSourcingsInfo objOutsourcingsInfo, string fieldName, bool isExtenalItem)
        {
            string oldOperation = objOutsourcingsInfo.MMBatchProductItemOutSourcingOperation;
            if (fieldName == "MMBatchProductItemOutSourcingResourceType")
            {
                objOutsourcingsInfo.MMBatchProductItemOutSourcingOperation = string.Empty;
            }
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            MMBatchProductItemOutSourcingsController controller = new MMBatchProductItemOutSourcingsController();
            List<MMBatchProductProductionNormItemsInfo> bpPniList = new List<MMBatchProductProductionNormItemsInfo>();
            MMBatchProductProductionNormItemsController objBpptnromItemController = new MMBatchProductProductionNormItemsController();
            bpPniList = objBpptnromItemController.GetListNormQtyRemainBySomeCriteria(mainObject.MMBatchProductID);

            List<MMBatchProductItemOutSourcingsInfo> compareList = new List<MMBatchProductItemOutSourcingsInfo>();
            List<MMBatchProductItemOutSourcingsInfo> mergeList = entity.BatchProductItemOutSourcingList.Select(o => (MMBatchProductItemOutSourcingsInfo)o.Clone()).ToList();
            if (isExtenalItem)
            {
                mergeList.Add(objOutsourcingsInfo);
            }
            List<int> pniIDs = mergeList.Select(o => o.FK_MMBatchProductProductionNormItemID).Distinct().ToList();
            Dictionary<int, List<int>> operationCompere = new Dictionary<int, List<int>>();
            MMBatchProductItemOutSourcingsInfo tempItem = new MMBatchProductItemOutSourcingsInfo();
            mergeList.ForEach(o =>
            {
                o.VirtualId = Guid.NewGuid();
                if (string.IsNullOrWhiteSpace(o.MMBatchProductItemOutSourcingOperation))
                {
                    compareList.Add((MMBatchProductItemOutSourcingsInfo)o.Clone());
                }
                else
                {
                    List<int> operationRef = o.MMBatchProductItemOutSourcingOperation.Split(',').Select(i => Int32.Parse(i)).ToList();
                    operationRef.ForEach(oper =>
                    {
                        tempItem = (MMBatchProductItemOutSourcingsInfo)o.Clone();
                        tempItem.FK_MMOperationID = oper;
                        compareList.Add(tempItem);
                    });
                }
            });
            List<MMBatchProductProductionNormItemsInfo> remainList = CalRemainQtyWithOutSourcing(bpPniList, compareList);
            List<string> messageList = new List<string>();
            string messageError = string.Empty;
            List<MMBatchProductProductionNormItemsInfo> checkList;
            MMBatchProductProductionNormItemsInfo defaultItemsInfo;
            decimal remainQty = 0;
            decimal sameItemQty = 0;
            compareList.ForEach(item =>
            {
                checkList = remainList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID && (item.FK_MMOperationID == 0 || item.FK_MMOperationID == o.FK_MMOperationID)).ToList();
                if (checkList.Count() == 0)
                    return;

                remainQty = checkList.DefaultIfEmpty().Min(o => o == null ? 0 : o.MMBatchProductProductionNormItemRemainQty);
                defaultItemsInfo = checkList.Where(o => o.MMBatchProductProductionNormItemRemainQty == remainQty).FirstOrDefault();
                if (defaultItemsInfo == null)
                    defaultItemsInfo = checkList.FirstOrDefault();

                sameItemQty = compareList.Where(si => si.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                    && (si.FK_MMOperationID == item.FK_MMOperationID || si.FK_MMOperationID == 0)
                                                    && si.VirtualId != item.VirtualId).Sum(o => o.MMBatchProductItemOutSourcingProductQty);

                if (item.FK_MMOperationID == 0 && remainQty - sameItemQty - item.MMBatchProductItemOutSourcingProductQty < 0)
                {
                    messageError = string.Format("Sản phẩm [{0}] có SL định mức {1}, SL có thể kế hoạch: {2}", item.MMBatchProductItemOutSourcingProductName, defaultItemsInfo.MMBatchProductProductionNormItemQuantity, remainQty);
                    messageList.Add(messageError);
                    return;
                }
                checkList.ForEach(o =>
                {
                    if (o.MMBatchProductProductionNormItemRemainQty - sameItemQty - item.MMBatchProductItemOutSourcingProductQty >= 0)
                        return;

                    if (remainQty < 0)
                    {
                        remainQty = defaultItemsInfo.MMBatchProductProductionNormItemQuantity - o.MMBatchProductProductionNormItemRemainQty;
                        if (remainQty < 0 || o.MMBatchProductProductionNormItemRemainQty < 0)
                            remainQty = 0;
                    }
                    messageError = string.Format("Sản phẩm [{0}], công đoạn {1} có SL định mức {2}, SL có thể kế hoạch: {3}", o.MMBatchProductProductionNormItemProductName, BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", item.FK_MMOperationID, "MMOperationName"), o.MMBatchProductProductionNormItemQuantity, remainQty);
                    messageList.Add(messageError);
                    return;
                });
            });
            if (messageList.Count() == 0)
                return true;

            messageError = string.Join(Environment.NewLine, messageList.Distinct().ToArray());
            messageError += Environment.NewLine;
            messageError += "Vui lòng kiểm tra lại!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            objOutsourcingsInfo.MMBatchProductItemOutSourcingOperation = oldOperation;
            return false;
        }

        public bool IsValidOutSourcingQty(List<MMBatchProductItemOutSourcingsInfo> externalList = null)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
            List<MMBatchProductProductionNormItemsInfo> bpPniList = new List<MMBatchProductProductionNormItemsInfo>();
            MMBatchProductProductionNormItemsController objBpptnromItemController = new MMBatchProductProductionNormItemsController();
            bpPniList = objBpptnromItemController.GetListNormQtyRemainBySomeCriteria(mainObject.MMBatchProductID);
            List<MMBatchProductItemOutSourcingsInfo> mergeList = entity.BatchProductItemOutSourcingList.Select(o => (MMBatchProductItemOutSourcingsInfo)o.Clone()).ToList();
            if (externalList != null)
            {
                mergeList.AddRange(externalList);
            }
            List<int> pniIDs = mergeList.Select(o => o.FK_MMBatchProductProductionNormItemID).Distinct().ToList();
            Dictionary<int, List<int>> operationCompere = new Dictionary<int, List<int>>();
            List<MMBatchProductItemOutSourcingsInfo> compareList = new List<MMBatchProductItemOutSourcingsInfo>();
            MMBatchProductItemOutSourcingsInfo tempItem = new MMBatchProductItemOutSourcingsInfo();
            mergeList.ForEach(o =>
            {
                o.VirtualId = Guid.NewGuid();
                if (string.IsNullOrWhiteSpace(o.MMBatchProductItemOutSourcingOperation))
                {
                    compareList.Add((MMBatchProductItemOutSourcingsInfo)o.Clone());
                }
                else
                {
                    List<int> operationRef = o.MMBatchProductItemOutSourcingOperation.Split(',').Select(i => Int32.Parse(i)).ToList();
                    operationRef.ForEach(oper =>
                    {
                        tempItem = (MMBatchProductItemOutSourcingsInfo)o.Clone();
                        tempItem.FK_MMOperationID = oper;
                        compareList.Add(tempItem);
                    });
                }
            });
            List<MMBatchProductProductionNormItemsInfo> remainList = CalRemainQtyWithOutSourcing(bpPniList, compareList);
            List<string> messageList = new List<string>();
            string messageError = string.Empty;
            List<MMBatchProductProductionNormItemsInfo> checkList;
            MMBatchProductProductionNormItemsInfo defaultItemsInfo;
            decimal remainQty = 0;
            decimal sameItemQty = 0;
            compareList.ForEach(item =>
            {
                checkList = remainList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID && (item.FK_MMOperationID == 0 || item.FK_MMOperationID == o.FK_MMOperationID)).ToList();
                if (checkList.Count() == 0)
                    return;

                defaultItemsInfo = checkList.FirstOrDefault();
                remainQty = checkList.DefaultIfEmpty().Min(o => o == null ? 0 : o.MMBatchProductProductionNormItemRemainQty);
                sameItemQty = compareList.Where(si => si.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                    && (si.FK_MMOperationID == item.FK_MMOperationID || si.FK_MMOperationID == 0)
                                                    && si.VirtualId != item.VirtualId).Sum(o => o.MMBatchProductItemOutSourcingProductQty);
                if (item.FK_MMOperationID == 0 && remainQty - sameItemQty - item.MMBatchProductItemOutSourcingProductQty < 0)
                {
                    //remainQty = remainQty < 0 ? 0 : remainQty;
                    messageError = string.Format("Sản phẩm [{0}] có SL định mức {1}, SL có thể kế hoạch: {2}", item.MMBatchProductItemOutSourcingProductName, defaultItemsInfo.MMBatchProductProductionNormItemQuantity, remainQty);
                    messageList.Add(messageError);
                    return;
                }
                checkList.ForEach(o =>
                {
                    if (o.MMBatchProductProductionNormItemRemainQty - sameItemQty - item.MMBatchProductItemOutSourcingProductQty >= 0)
                        return;

                    remainQty = remainQty < 0 ? 0 : remainQty;
                    messageError = string.Format("Sản phẩm [{0}], công đoạn {1} có SL định mức {2}, SL có thể kế hoạch: {3}", o.MMBatchProductProductionNormItemProductName, BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", item.FK_MMOperationID, "MMOperationName"), o.MMBatchProductProductionNormItemQuantity, remainQty);
                    messageList.Add(messageError);
                    return;
                });
            });
            if (messageList.Count() == 0)
                return true;

            messageError = string.Join(Environment.NewLine, messageList.Distinct().ToArray()) + " Vui lòng kiểm tra lại!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public List<MMBatchProductProductionNormItemsInfo> CalRemainQtyWithOutSourcing(List<MMBatchProductProductionNormItemsInfo> bpPniList, List<MMBatchProductItemOutSourcingsInfo> mergeList)
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainobject = (MMBatchProductsInfo)CurrentModuleEntity.MainObject;
            MMBatchProductProductionNormItemsController objPnisController = new MMBatchProductProductionNormItemsController();

            decimal outSourcingQty = 0;
            decimal inventoryStockQtyOfParent = 0;
            decimal remainQty = 0;
            List<int> outSourcingRef = mergeList.Select(o => o.FK_MMBatchProductProductionNormItemID).ToList();
            if (!entity.SemiProductStructure.Any())
            {
                DataSet ds = objPnisController.GetSemiProductStructure(mainobject.MMBatchProductID);
                List<TreeStructure> treeStructures = new List<TreeStructure>();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        TreeStructure treeItem = (TreeStructure)SqlDatabaseHelper.GetObjectFromDataRow(row, typeof(TreeStructure));
                        treeStructures.Add(treeItem);
                    }
                }
                entity.SemiProductStructure.AddRange(treeStructures);
            }
            List<TreeStructure> currentStructure = entity.SemiProductStructure.Where(o => outSourcingRef.Contains(o.ID) || outSourcingRef.Contains(o.ParentID)).ToList();
            List<int> compareList = currentStructure.Select(o => o.ID).ToList();
            List<MMBatchProductProductionNormItemsInfo> remainItemList = bpPniList.Where(o => compareList.Contains(o.MMBatchProductProductionNormItemID)).ToList();
            remainItemList.ForEach(o => o.VirtualId = Guid.NewGuid());
            List<int> parenList = new List<int>();
            remainItemList.ForEach(o =>
            {
                remainQty = o.MMBatchProductProductionNormItemQuantity - o.MMBatchProductProductionNormItemUsedQty;
                parenList = currentStructure.Where(tr => tr.ID == o.MMBatchProductProductionNormItemID).Select(tr => tr.ParentID).ToList();
                inventoryStockQtyOfParent = CalOutSourcingQtyOfParent(remainItemList.Where(os => parenList.Contains(o.MMBatchProductProductionNormItemID)).ToList(), mergeList, o.MMBatchProductProductionNormItemQuantity);
                remainQty = remainQty - inventoryStockQtyOfParent;
                o.MMBatchProductProductionNormItemRemainQty = remainQty;
            });
            return remainItemList;
        }

        public decimal CalOutSourcingQtyOfParent(List<MMBatchProductProductionNormItemsInfo> bpPniList, List<MMBatchProductItemOutSourcingsInfo> mergeList, decimal qty)
        {
            decimal rateWithParent = 0;
            decimal inventoryStockQtyOfParent = 0;
            List<decimal> outsourcingOfParent = new List<decimal>();
            bpPniList.ForEach(o =>
            {
                if (o.MMBatchProductProductionNormItemQuantity == 0)
                    rateWithParent = 0;
                else
                    rateWithParent = qty / o.MMBatchProductProductionNormItemQuantity;

                inventoryStockQtyOfParent = mergeList.Where(os => os.MMBatchProductItemOutSourcingResourceType == BatchProductItemOutSourcingResourceType.Inventory.ToString() && os.FK_MMBatchProductProductionNormItemID == o.MMBatchProductProductionNormItemID && (o.FK_MMOperationID == os.FK_MMOperationID || os.FK_MMOperationID == 0))
                                                     .Sum(os => os.MMBatchProductItemOutSourcingProductQty);

                inventoryStockQtyOfParent = inventoryStockQtyOfParent * rateWithParent;
                outsourcingOfParent.Add(inventoryStockQtyOfParent);
            });
            return outsourcingOfParent.DefaultIfEmpty().Max();
        }

        public bool IsParent(int[][] pniIDs, int childID, int parenID)
        {
            if (childID == parenID)
                return false;

            while (childID != parenID && childID != 0)
            {
                childID = pniIDs.Where(o => o[0] == childID).Select(o => o[1]).FirstOrDefault();
            }
            if (childID == parenID)
                return true;

            return false;
        }

        public void ExportTemplateCNC()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
            MMBatchProductProductionNormItemsController bpPnisController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> bpPniList = bpPnisController.GetItemForExport(mainObject.MMBatchProductID);

            object misValue = System.Reflection.Missing.Value;
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add(misValue);
            Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelWorkBook.ActiveSheet;
            excelWorkSheet.Name = mainObject.MMBatchProductNo;
            InitTeamplateHeader(excelWorkSheet);
            int numRow = 2;
            MMFormulaConfigurationsController objFormulaConfigurationsController = new MMFormulaConfigurationsController();
            List<MMFormulaConfigurationsInfo> formulaList = objFormulaConfigurationsController.GetFormulaConfigByFormulaType("AddMaterial");
            bpPniList.ForEach(o =>
            {
                (excelWorkSheet.get_Range("B" + numRow, "B" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemNo;
                (excelWorkSheet.get_Range("C" + numRow, "C" + numRow) as Excel.Range).Value2 = o.MMProductWoodTypeName;
                (excelWorkSheet.get_Range("D" + numRow, "D" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemProductLength;
                (excelWorkSheet.get_Range("E" + numRow, "E" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemProductWidth;
                (excelWorkSheet.get_Range("F" + numRow, "F" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemQuantity;
                (excelWorkSheet.get_Range("I" + numRow, "I" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemIsGrain ? "Y" : "N";
                (excelWorkSheet.get_Range("J" + numRow, "J" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemProductName;
                (excelWorkSheet.get_Range("K" + numRow, "K" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemProductHeight;
                (excelWorkSheet.get_Range("N" + numRow, "N" + numRow) as Excel.Range).Value2 = o.MMFormulaName;
                (excelWorkSheet.get_Range("O" + numRow, "O" + numRow) as Excel.Range).Value2 = o.MMBatchProductProductionNormItemComment;
                (excelWorkSheet.get_Range("Q" + numRow, "Q" + numRow) as Excel.Range).Value2 = GetOverSize(formulaList, o.MMFormulaRef, o.MMBatchProductProductionNormItemProductLength, o.MMBatchProductProductionNormItemProductWidth, o.MMBatchProductProductionNormItemProductHeight);
                (excelWorkSheet.get_Range("Y" + numRow, "Y" + numRow) as Excel.Range).Value2 = o.ICProductFBName;
                numRow++;
            });
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Excel Files| *.xls; *.xlsx;";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = mainObject.MMBatchProductNo + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            if (saveDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                excelWorkBook.Close(true, misValue, misValue);
                excelApp.Quit();
                ReleaseObject(excelWorkSheet);
                ReleaseObject(excelWorkBook);
                ReleaseObject(excelApp);
                return;
            }
            string fullFileName = saveDialog.FileName;
            excelWorkBook.SaveAs(fullFileName);
            excelWorkBook.Saved = true;

            excelWorkBook.Close(true, misValue, misValue);
            excelApp.Quit();
            ReleaseObject(excelWorkSheet);
            ReleaseObject(excelWorkBook);
            ReleaseObject(excelApp);
            System.Diagnostics.Process.Start(fullFileName);
        }

        public string GetOverSize(List<MMFormulaConfigurationsInfo> formulaList, string formulaRef, decimal length, decimal width, decimal height)
        {
            List<int> formularList = formulaRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            MMFormulaConfigurationsInfo objFormulaConfigurationsInfo = new MMFormulaConfigurationsInfo();

            List<MMFormulaConfigurationsInfo> configList = formulaList.Where(o => formularList.Contains(o.FK_MMFormulaID)).ToList();
            length += configList.DefaultIfEmpty().Max(o => o == null ? 0 : o.MMFormulaConfigurationShortEdgeQty);
            width += configList.DefaultIfEmpty().Max(o => o == null ? 0 : o.MMFormulaConfigurationLongEdgeQty);

            string result = string.Empty;
            result = ((length != 0 && (length % (int)length == 0)) ? length.ToString("n0") : length.ToString("n2"));
            result += "x" + ((width != 0 && (width % (int)width == 0)) ? width.ToString("n0") : width.ToString("n2"));
            result += "x" + ((height != 0 && (height % (int)height == 0)) ? height.ToString("n0") : height.ToString("n2"));
            return result;
        }

        public void InitTeamplateHeader(Excel.Worksheet excelWorkSheet)
        {
            int numRow = 1;
            (excelWorkSheet.get_Range("B" + numRow, "B" + numRow) as Excel.Range).Value2 = "Mã BTP";
            (excelWorkSheet.get_Range("C" + numRow, "C" + numRow) as Excel.Range).Value2 = "Nguyên liệu gỗ";
            (excelWorkSheet.get_Range("D" + numRow, "D" + numRow) as Excel.Range).Value2 = "Dài";
            (excelWorkSheet.get_Range("E" + numRow, "E" + numRow) as Excel.Range).Value2 = "Rộng";
            (excelWorkSheet.get_Range("F" + numRow, "F" + numRow) as Excel.Range).Value2 = "Số lượng BTP";
            (excelWorkSheet.get_Range("I" + numRow, "I" + numRow) as Excel.Range).Value2 = "Vân ván";
            (excelWorkSheet.get_Range("J" + numRow, "J" + numRow) as Excel.Range).Value2 = "Tên BTP";
            (excelWorkSheet.get_Range("K" + numRow, "K" + numRow) as Excel.Range).Value2 = "Dày";
            (excelWorkSheet.get_Range("N" + numRow, "N" + numRow) as Excel.Range).Value2 = "Ghi chú CT dán chỉ";
            (excelWorkSheet.get_Range("O" + numRow, "O" + numRow) as Excel.Range).Value2 = "Ghi chú sau dán chỉ";
            (excelWorkSheet.get_Range("Q" + numRow, "Q" + numRow) as Excel.Range).Value2 = "KTHT";
            (excelWorkSheet.get_Range("Y" + numRow, "Y" + numRow) as Excel.Range).Value2 = "Tên Thành phẩm";
            excelWorkSheet.Range["A1", "Y1"].Font.Bold = true;
            excelWorkSheet.Range["A1", "Y1"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            excelWorkSheet.Range["A1", "Y1"].Borders.Weight = Excel.XlBorderWeight.xlThin;
            excelWorkSheet.Range["A1", "Y1"].Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            excelWorkSheet.Range["A1", "Y1"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public override void ActionDelete()
        {
            base.ActionDelete();
        }

        public void ActionReNewBatchProduct()
        {
            BatchProductEntities entity = (BatchProductEntities)CurrentModuleEntity;
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)entity.MainObject;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn mở LSX này không", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            bool isAllowReNew = objBatchProductsController.CheckAllowReNewBatchProduct(mainObject.MMBatchProductID);
            if (!isAllowReNew)
            {
                MessageBox.Show("LSX đã tồn tại KHSD hoặc KHSXCT hoặc Nhập kho Bán thành phẩm/Thành phẩm. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objBatchProductsController.DeleteBatchProduct(mainObject.MMBatchProductID, BOSApp.CurrentUser, true);
            Invalidate(mainObject.MMBatchProductID);
        }
    }
}

