using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.GenaralLeadger;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    class ShipmentSaleOrderModule : GLShipmentModule
    {
        #region Constants

        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItems";
        public const string ShipmentItemWorkGridControlName = "fld_dgcICShipmentItemWorks";
        public const string ShipmentItemWorkItemGridControlName = "fld_dgcICShipmentItemWorkItems";
        public const string ShipmentItemWorkAssetGridControlName = "fld_dgcICShipmentItemWorkAssets";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string SaleOrderNoControlName = "fld_txtARSaleOrderNo";
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public ICShipmentItemsGridControl ShipmentItemGridControl;
        public ICShipmentItemWorksGridControl ShipmentItemWorkGridControl;
        public ICShipmentItemWorkItemsGridControl ShipmentItemWorkItemGridControl;
        public ICShipmentItemWorkAssetsGridControl ShipmentItemWorkAssetGridControl;
        public BOSTextBox SaleOrderNoControl;
        private bool IsEditAfterCompleting = false;
        #endregion

        #region Constructor
        public ShipmentSaleOrderModule()
        {
            Name = "ShipmentSaleOrder";
            CurrentModuleEntity = new ShipmentSaleOrderEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            ShipmentItemGridControl = (ICShipmentItemsGridControl)Controls[ShipmentItemGridControlName];
            ShipmentItemWorkGridControl = (ICShipmentItemWorksGridControl)Controls[ShipmentItemWorkGridControlName];
            ShipmentItemWorkItemGridControl = (ICShipmentItemWorkItemsGridControl)Controls[ShipmentItemWorkItemGridControlName];
            ShipmentItemWorkAssetGridControl = (ICShipmentItemWorkAssetsGridControl)Controls[ShipmentItemWorkAssetGridControlName];
            SaleOrderNoControl = (BOSTextBox)Controls[SaleOrderNoControlName];
            StartGettingInventoryThread();
        }
        #endregion

        public void SetReadOnlyControl(object control, bool isReadOnly)
        {
            (control as BOSLookupEdit).ReadOnly = isReadOnly;
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
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.Count() > 0 && entity.ShipmentItemList[0].FK_ARSaleOrderID > 0)
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(entity.ShipmentItemList[0].FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    objShipmentInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                }
            }
            entity.UpdateMainObjectBindingSource();

            bool isWoodType = BOSApp.IsWoodTypeDocument(objShipmentInfo.ICShipmentProductType, entity.ShipmentItemList.FirstOrDefault());

            ChangeDisplayColumnByWoodType(entity.ShipmentItemList.GridControl, isWoodType);
            objShipmentInfo.ICShipmentSOName = String.Join(", ", entity.ShipmentItemList.Where(o => !string.IsNullOrWhiteSpace(o.ICShipmentItemSOName)).Select(o => o.ICShipmentItemSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewDelivery()
        {
            base.ActionNew();
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItems = objDeliveryPlanItemsController.GetAllDeliveryPlanItemsByDeliveryPlanCompletedAndProductQtyByuser(BOSApp.CurrentUsersInfo.ADUserID);
            guiChooseDeliveryPlans guiDeliveryPlan = new guiChooseDeliveryPlans(deliveryPlanItems);
            guiDeliveryPlan.Module = this;
            if (guiDeliveryPlan.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARDeliveryPlanItemsInfo> results = (List<ARDeliveryPlanItemsInfo>)guiDeliveryPlan.SelectedObjects;
            if (results.Count == 0)
                return;

            objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = results.FirstOrDefault();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objDeliveryPlanItemsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo == null)
                objSaleOrdersInfo = new ARSaleOrdersInfo();

            objShipmentInfo.ICShipmentTypeCombo = ShipmentType.SaleShipment.ToString();
            objShipmentInfo.FK_ACObjectID = objSaleOrdersInfo.FK_ACObjectID;
            objShipmentInfo.ICObjectType = objSaleOrdersInfo.ARObjectType;
            objShipmentInfo.ACObjectAccessKey = objSaleOrdersInfo.FK_ACObjectID + ";" + objSaleOrdersInfo.ARObjectType;
            objShipmentInfo.FK_ARSellerID = objSaleOrdersInfo.FK_ARSellerID;
            //objShipmentInfo.FK_GECurrencyID = objSaleOrdersInfo.FK_GECurrencyID;
            //objShipmentInfo.ICShipmentExchangeRate = objSaleOrdersInfo.ARSaleOrderExchangeRate;
            objShipmentInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
            objShipmentInfo.ICShipmentReference = objDeliveryPlanItemsInfo.ARDeliveryPlanNo;
            objShipmentInfo.ICShipmentDeliveryDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate;
            objShipmentInfo.FK_PMProjectID = objSaleOrdersInfo.FK_PMProjectID;
            objShipmentInfo.ICShipmentIsReceiveBill = objSaleOrdersInfo.ARSaleOrderIsReceiveBill;
            objShipmentInfo.FK_ARSaleContractID = objSaleOrdersInfo.FK_ARSaleContractID;
            objShipmentInfo.FK_ACCostCenterID = objDeliveryPlanItemsInfo.FK_ACCostCenterID;
            objShipmentInfo.FK_PMTemplateID = objDeliveryPlanItemsInfo.FK_PMTemplateID;
            objShipmentInfo.FK_ARInvoiceRequestID = objSaleOrdersInfo.FK_ARInvoiceRequestID;
            objShipmentInfo.ICShipmentProductType = objSaleOrdersInfo.ARSaleOrderProductType;
            objShipmentInfo.ICShipmentProject = objSaleOrdersInfo.ARSaleOrderProject;
            objShipmentInfo.ICShipmentInvoiceRequest = objSaleOrdersInfo.ARSaleOrderInvoiceRequest;
            objShipmentInfo.ICShipmentSaleContract = objSaleOrdersInfo.ARSaleOrderSaleContract;
            objShipmentInfo.ICListOfSalesChannelType = objSaleOrdersInfo.ARListOfSalesChannelType;
            objShipmentInfo.ICShipmentContainerNumber = objDeliveryPlanItemsInfo.ARDeliveryPlanContainersNumber;
            objShipmentInfo.ICShipmentContainerSealNumber = objDeliveryPlanItemsInfo.ARDeliveryPlanSeal;
            objShipmentInfo.ICShipmentInternalSeal = objDeliveryPlanItemsInfo.ARDeliveryPlanInternalSeal;
            objShipmentInfo.ICShipmentDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanDesc;
            objShipmentInfo.ICShipmentReference = string.Join(",", results.Select(o => o.ARDeliveryPlanNo).Distinct().ToArray());
            objShipmentInfo.ICShipmentSOName = string.Join(", ", results.Where(o => !string.IsNullOrWhiteSpace(o.ARSaleOrderName)).Select(o => o.ARSaleOrderName).Distinct().ToArray());
            ChangeObject(objShipmentInfo.ACObjectAccessKey);
            entity.GenarateShipmentSaleOrder(results);
            GenerateShipmentItemComponent();
            ChangeInternalSeal();
            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList.FirstOrDefault();
            if (objShipmentItemsInfo != null)
                objShipmentInfo.FK_ICStockID = objShipmentItemsInfo.FK_ICStockID;
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            entity.ShipmentItemWorkItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
            ChangeDisplayAndDataItemListGridView();
        }

        public void ActionNewSaleOrder()
        {
            base.ActionNew();
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saaleOrderItems = objSaleOrderItemsController.GeSaleOrderItemsForShipmentSaleOrderByUser(BOSApp.CurrentUsersInfo.ADUserID);
            guiChooseSaleOrders guiSaleOrder = new guiChooseSaleOrders(saaleOrderItems);
            guiSaleOrder.Module = this;

            if (guiSaleOrder.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARSaleOrderItemsInfo> results = (List<ARSaleOrderItemsInfo>)guiSaleOrder.SelectedObjects;
            if (results.Count == 0)
                return;

            objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = results.FirstOrDefault();

            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objSaleOrderItemsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo == null)
                objSaleOrdersInfo = new ARSaleOrdersInfo();

            objShipmentInfo.ICShipmentTypeCombo = ShipmentType.SaleShipment.ToString();
            objShipmentInfo.FK_ACObjectID = objSaleOrdersInfo.FK_ACObjectID;
            objShipmentInfo.ICObjectType = objSaleOrdersInfo.ARObjectType;
            objShipmentInfo.ACObjectAccessKey = objSaleOrdersInfo.FK_ACObjectID + ";" + objSaleOrdersInfo.ARObjectType;
            objShipmentInfo.FK_ARSellerID = objSaleOrdersInfo.FK_ARSellerID;
            objShipmentInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
            objShipmentInfo.ICShipmentReference = objSaleOrdersInfo.ARSaleOrderNo;
            objShipmentInfo.ICShipmentDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryTime;
            objShipmentInfo.FK_PMProjectID = objSaleOrdersInfo.FK_PMProjectID;
            objShipmentInfo.ICShipmentIsReceiveBill = objSaleOrdersInfo.ARSaleOrderIsReceiveBill;
            objShipmentInfo.FK_ARSaleContractID = objSaleOrdersInfo.FK_ARSaleContractID;
            objShipmentInfo.FK_ACCostCenterID = objSaleOrdersInfo.FK_ACCostCenterID;
            objShipmentInfo.FK_PMTemplateID = objSaleOrdersInfo.FK_PMTemplateID;
            objShipmentInfo.FK_ARInvoiceRequestID = objSaleOrdersInfo.FK_ARInvoiceRequestID;
            objShipmentInfo.ICShipmentProductType = objSaleOrdersInfo.ARSaleOrderProductType;
            objShipmentInfo.FK_PMTemplateID = objSaleOrdersInfo.FK_PMTemplateID;
            //objShipmentInfo.FK_GECurrencyID = objSaleOrdersInfo.FK_GECurrencyID;
            //objShipmentInfo.ICShipmentExchangeRate = objSaleOrdersInfo.ARSaleOrderExchangeRate;
            objShipmentInfo.ICShipmentProject = objSaleOrdersInfo.ARSaleOrderProject;
            objShipmentInfo.ICShipmentInvoiceRequest = objSaleOrdersInfo.ARSaleOrderInvoiceRequest;
            objShipmentInfo.ICShipmentSaleContract = objSaleOrdersInfo.ARSaleOrderSaleContract;
            objShipmentInfo.ICListOfSalesChannelType = objSaleOrdersInfo.ARListOfSalesChannelType;

            ChangeObject(objShipmentInfo.ACObjectAccessKey);
            entity.GenarateShipmentSaleOrder(results);

            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList.FirstOrDefault();
            if (objShipmentItemsInfo != null)
                objShipmentInfo.FK_ICStockID = objShipmentItemsInfo.FK_ICStockID;
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            entity.ShipmentItemWorkItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
            ChangeDisplayAndDataItemListGridView();
        }

        public override void InvalidateToolbar()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objShipmentsInfo.ICShipmentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton("EditAfterCompleting", false);
                if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("EditAfterCompleting", objShipmentsInfo.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete,
                        objShipmentsInfo.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                }
                else if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
            base.InvalidateToolbar();
        }

        public override void ActionDelete()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject.Clone();
            if (objShipmentsInfo.ICShipmentID > 0)
            {
                entity.UpdateDeliveryPlanStatus(false);
                base.ActionDelete();
            }
        }
        public override int ActionSave()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICShipmentsInfo objShipmentsInfoOld = (ICShipmentsInfo)entity.MainObject.OldObject;
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            entity.ShipmentItemList.EndCurrentEdit();
            if (objShipmentsInfo.FK_ICStockID == 0)
            {
                MessageBox.Show("Vui lòng chọn kho cho chứng từ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (entity.ShipmentItemList.Count(o1 => o1.FK_ICStockID == 0) > 0)
            {
                MessageBox.Show(ShipmentSaleOrderLocalizedResources.ChooseStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (entity.ShipmentItemList.Where(o => o.FK_ARSaleOrderID > 0).Count() > 0)
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(entity.ShipmentItemList.Where(o => o.FK_ARSaleOrderID > 0).FirstOrDefault().FK_ARSaleOrderID);
                if (objSaleOrdersInfo!= null && objShipmentsInfo.ACObjectAccessKey != objSaleOrdersInfo.FK_ACObjectID + ";" + objSaleOrdersInfo.ARObjectType)
                {
                    MessageBox.Show("Khách hàng bạn chọn khác với khách hàng của chứng từ bán", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }    
            }
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            bool isWoodType = BOSApp.IsWoodTypeDocument(objShipmentsInfo.ICShipmentProductType, entity.ShipmentItemList.FirstOrDefault());

            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString()
                    && objProductsInfo.ICProductIsFollowInventoryStock)
                {
                    if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }

                    if (isWoodType && (string.IsNullOrEmpty(objShipmentItemsInfo.ICShipmentItemLotNo) || string.IsNullOrEmpty(objShipmentItemsInfo.ICShipmentItemProductSerialNo)))
                    {
                        MessageBox.Show(string.Format("Vui lòng nhập mã lô hàng/ mã kiện(mã đầu lóng) cho sản phẩm {0}", objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }

            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.EditAfterComplete.ToString())
            {
                objShipmentsInfoOld.ICShipmentDate = objShipmentsInfo.ICShipmentDate;
                objShipmentsInfo.FK_ACObjectID = objShipmentsInfoOld.FK_ACObjectID;
                return base.ActionSave();
            }
            if (!ValidatePackage())
                return 0;
            int shipmentID = base.ActionSave();

            if (shipmentID > 0)
            {
                entity.InvalidateItemComponents();
                if (IsEditAfterCompleting)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ActionComplete();
                    IsEditAfterCompleting = false;
                }
                InvalidateToolbar();
            }
            return shipmentID;
        }

        public override bool ActionComplete()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString()
                    && objProductsInfo.ICProductIsFollowInventoryStock)
                {
                    if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            foreach (ICShipmentItemsInfo item in entity.ComponentShipmentItemList)
            {
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString()
                    && objProductsInfo.ICProductIsFollowInventoryStock)
                {

                    if (item.FK_ICProductSerieID == null || item.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(ShipmentSaleOrderLocalizedResources.SerialProductsIDIsNullMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            entity.ShipmentItemList.EndCurrentEdit();
            UpdateTotalAmount();

            if (!IsEditAfterCompleting)
            {
                BOSItemsEntityList<ICShipmentItemsInfo> shipmentItemCheckList = new BOSItemsEntityList<ICShipmentItemsInfo>();
                shipmentItemCheckList.Invalidate(entity.ShipmentItemList.Where(p => p.ICShipmentItemComponentList == null || p.ICShipmentItemComponentList.Count == 0).Select(o => o.Clone()  as ICShipmentItemsInfo).ToList());
                shipmentItemCheckList.InitBOSList(
                                            entity,
                                            TableName.ICShipmentsTableName,
                                            TableName.ICShipmentItemsTableName,
                                            BOSList<ICShipmentItemsInfo>.cstRelationForeign);
                List<ICShipmentItemsInfo> shipmentItemCheckList1 = new List<ICShipmentItemsInfo>();
                foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                {
                    if (item.ICShipmentItemComponentList != null && item.ICShipmentItemComponentList.Count > 0)
                    {
                        BOSItemsEntityList<ICShipmentItemComponentsInfo> componentsList = new BOSItemsEntityList<ICShipmentItemComponentsInfo>();
                        componentsList.Invalidate(item.ICShipmentItemComponentList.Select(o => o.Clone() as ICShipmentItemComponentsInfo).ToList());
                        componentsList.InitBOSList(
                                                entity,
                                                TableName.ICShipmentItemsTableName,
                                                TableName.ICShipmentItemComponentsTableName,
                                                BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
                        if (componentsList.IsInvalidInventoryShipmentStockQty())
                        {
                            return false;
                        }
                    }
                }
                
                if (shipmentItemCheckList != null && shipmentItemCheckList.Count > 0)
                {
                    if (shipmentItemCheckList.IsInvalidInventoryShipmentStockQty())
                    {
                        return false;
                    }
                }
            }

            if (!IsEditAfterCompleting && !ValidatePackage())
                return false;
            //End Update Product Package
            if (entity.ShipmentPackageList != null && entity.ShipmentPackageList.Count > 0)
            {
                List<string> PackList = entity.ShipmentPackageList.Select(o => o.FK_ICProductPackageID.ToString()).Distinct().ToList();
                if (PackList != null && PackList.Count > 0)
                    (new ICProductPackagesController()).UpdateProductPackageStatusByID(string.Join(",", PackList.ToArray()), BOSApp.CurrentUsersInfo.ADUserName);
            }
            if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                return false;
            bool isCompleted = base.ActionComplete();
            if (isCompleted)
            {
                entity.UpdateShipedQtySaleOrderAndDeliveryPlan();
                entity.UpdateSaleOrderStatus();
                entity.UpdateDeliveryPlanStatus(true);
                entity.ComponentShipmentItemList.BackupList.Clear();
                entity.ComponentShipmentItemList.ForEach(o => entity.ComponentShipmentItemList.BackupList.Add((ICShipmentItemsInfo)o.Clone()));
            }
            return isCompleted;
        }
        public override bool ActionCancelComplete()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ICShipmentID > 0)
            {
                bool isReturnShipped = entity.ShipmentItemList.Where(o => o.ICShipmentItemQty1 > 0).Count() > 0;
                if (isReturnShipped)
                {
                    MessageBox.Show("Phiếu xuất kho này đã tạo nhập kho đổi trả. Bạn không thể huỷ hoàn tất.!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                ARInvoicesController objARContainerLoadersController = new ARInvoicesController();
                List<ARInvoicesInfo> listInvoice = objARContainerLoadersController.GetInvoicesByShipment(mainObject.ICShipmentID);
                if (listInvoice.Count() > 0)
                {
                    MessageBox.Show(ShipmentSaleOrderLocalizedResources.CancelCompleteExistsInvoice
                        + Environment.NewLine
                        + string.Join(",", listInvoice.Select(o => o.ARInvoiceNo).Distinct().ToArray())
                        , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!base.ActionCancelComplete()) return false;

            entity.UpdateShipedQtySaleOrderAndDeliveryPlan();
            entity.UpdateSaleOrderStatus();
            entity.UpdateDeliveryPlanStatus(false);

            GLHelper.UnPostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
            InvalidateToolbar();
            return true;
        }
        public void ActionEditAfterCompleting()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            bool isReturnShipped = entity.ShipmentItemList.Where(o => o.ICShipmentItemQty1 > 0).Count() > 0;
            if (isReturnShipped)
            {
                MessageBox.Show("Phiếu xuất kho này đã tạo nhập kho đổi trả. Bạn không thể sửa sau hoàn tất.!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsEditAfterCompleting = true;
                base.ActionEdit();

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objShipmentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objShipmentsController.GetShipmentSaleListAllType(searchObject.ICShipmentNo,
                                                                       BranchList,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       searchObject.FK_ICStockID,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.ICShipmentTypeCombo,
                                                                       null,
                                                                       searchObject.ShipmentDateFrom,
                                                                       searchObject.ShipmentDateTo,
                                                                       BOSApp.CurrentUsersInfo.ADUserID
                                                                       );
                }
            }
            else
            {
                ds = objShipmentsController.GetShipmentSaleListAllTypeAndUser(searchObject.ICShipmentNo,
                                                                   searchObject.FK_BRBranchID,
                                                                   objObjectsInfo.ACObjectID,
                                                                   objObjectsInfo.ACObjectType,
                                                                   searchObject.FK_ICStockID,
                                                                   searchObject.FK_HREmployeeID,
                                                                   searchObject.ICShipmentTypeCombo,
                                                                   null,
                                                                   searchObject.ShipmentDateFrom,
                                                                   searchObject.ShipmentDateTo,
                                                                   BOSApp.CurrentUsersInfo.ADUserID
                                                                   );
            }
            return ds;
        }

        public override void ResetSearchObject()
        {
            base.ResetSearchObject();

            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            searchObject.ICShipmentTypeCombo = ShipmentType.SaleShipment.ToString();
        }

        public void AddItemToShipmentItemList()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            item.ICShipmentItemContainerNumber = mainObject.ICShipmentContainerNumber;
            item.ICShipmentItemContainerSealNumber = mainObject.ICShipmentContainerSealNumber;
            item.ICShipmentItemTractorTrailerNumber = mainObject.ICShipmentTractorTrailerNumber;
            item.ICShipmentItemShipNumber = mainObject.ICShipmentShipNumber;
            item.ICShipmentItemETDDate = mainObject.ICShipmentETDDate;
            ICProductsController objProductsController = new ICProductsController();
            if (item.FK_ICProductID > 0)
            {

                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                entity.ShipmentItemList.AddObjectToList();
                UpdateTotalAmount();
            }
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
            }
        }


        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }

        public void DeleteItemFromShipmentItemWorkItemList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                entity.ShipmentItemWorkItemList.RemoveSelectedRowObjectFromList();
            }
        }

        public void ChangeObject(string objectAccessKey)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            objShipmentsInfo.ACObjectAccessKey = objectAccessKey;
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objShipmentsInfo.ICShipmentDeliveryContactName = objObjectsInfo.ACObjectName;
                if (objObjectsInfo.ACObjectType == ObjectType.Supplier.ToString())
                    objShipmentsInfo.FK_APSupplierID = objObjectsInfo.ACObjectID;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public void ChangeItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                ICShipmentsInfo shipment = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                if (entity.ShipmentItemList.CurrentIndex >= 0)
                {
                    ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                    objShipmentItemsInfo.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo.ICShipmentItemProductSerialNo, shipment.ICShipmentDate);
                }
                entity.SetProductPriceByProductUnitPrice();
                UpdateTotalAmount();
                entity.ShipmentItemList.ChangeObjectFromList();
            }
        }

        public void UpdateStockForShipmentItems(int icStockID)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo shipment = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            shipment.FK_ICStockID = icStockID;
            List<ICShipmentItemsInfo> ShipmentItemList = entity.ShipmentItemList;
            ShipmentItemList.ForEach(o =>
            {
                o.FK_ICStockID = icStockID;
                o.FK_ICProductSerieID = 0;
                o.ICShipmentItemProductSerialNo = string.Empty;
                ChangeItemComponentStock(o);
            });
            List<ICShipmentItemsInfo> ShipmentItemWorkItemList = entity.ShipmentItemWorkItemList;
            ShipmentItemWorkItemList.ForEach(o =>
            {
                o.FK_ICStockID = icStockID;
                o.FK_ICProductSerieID = 0;
                o.ICShipmentItemProductSerialNo = string.Empty;
            });
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            entity.ShipmentItemWorkItemList.GridControl.RefreshDataSource();
        }
        public void PrintStampProduct()
        {
            if (!Toolbar.IsNullOrNoneAction() && !(Toolbar.CurrentObjectID > 0))
                return;
            RPStampProducts report = new RPStampProducts();
            InitReceiptReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, null, true);
            reviewer.Show();
        }

        private void InitReceiptReport(RPStampProducts report)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            report.bsShipmentItems.DataSource = objShipmentItemController.GetAllShipmentItemForRPStampProductsByShipmentID(mainObject.ICShipmentID);
        }

        #region PrintDeliveryProduct

        public void PrintDeliveryProductA4()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID >= 0)
            {
                RPDeliveryProductA4 report = new RPDeliveryProductA4();
                InitRPDeliveryProductA4(report);
                guiReportPreview reviewer = new guiReportPreview(report, null, true);
                reviewer.Show();
            }
        }

        private void InitRPDeliveryProductA4(RPDeliveryProductA4 report)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanys"];
            if (label != null)
            {
                label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc.ToUpper();
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel36"];
                if (label != null)
                {
                    label.Text = "Điện thoại: " + objBranchsInfo.BRBranchWarrantyPhone;
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
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblToDate"];
            if (label != null)
            {
                label.Text = BOSApp.GetCurrentServerDate().ToString("dd/MM/yyyy");
            }
            ICStocksController objStocksController = new ICStocksController();
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabelKho"];
            if (label != null)
            {
                label.Text = objStocksController.GetObjectNameByID(mainObject.FK_ICStockID);
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ICObjectType);
            if (objObjectsInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectName"];
                if (label != null)
                {
                    label.Text = objObjectsInfo.ACObjectName;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectAddress"];
                if (label != null)
                {
                    label.Text = objObjectsInfo.ACObjectContactAddress;
                }
            }
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(mainObject.ARSaleOrderNo);
            if (objSaleOrdersInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectDeliveryAddress"];
                if (label != null)
                {
                    label.Text = objSaleOrdersInfo.ARSaleOrderDeliveryAddressLine3;
                }
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblInvoiceHDNumber"];
            if (label != null)
            {
                if (objSaleOrdersInfo == null)
                {
                    label.Text = "(Theo HĐ/PĐH số: 0047/17/KH)";
                }
                else
                {
                    label.Text = "(Theo HĐ/PĐH số: " + objSaleOrdersInfo.ARSaleOrderNo + ")";
                }
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblInvoiceCodeNumber"];
            if (label != null)
            {
                label.Text = "KTO-QT2-BM4";
            }
            string strIsBKV = BOSApp.GetDisplayTextFromConfigText("ProjectBKV", "true");
            bool isBKV = bool.Parse(string.IsNullOrWhiteSpace(strIsBKV) ? "false" : strIsBKV);
            if (!isBKV)
            {
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblChuKy4"];
                if (label != null)
                {
                    label.Text = "Khách hàng";
                }
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblChuKy5"];
                if (label != null)
                {
                    label.Text = @"Giám đốc
(Kế toán trưởng)";
                }
            }
            
            report.bsShipmentSaleOrder.DataSource = mainObject;

            List<ICShipmentItemsInfo> ShipmentItemsInfoListForReport = objShipmentItemController.GetAllShipmentItemForRPDeliveryProductByShipmentID(mainObject.ICShipmentID);
            ShipmentItemsInfoListForReport = ShipmentItemsInfoListForReport.OrderBy(x => x.ICDepartmentName).ToList();
            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;
            ShipmentItemsInfoListForReport.ForEach(o =>
                {
                    if (o.ICDepartmentName != oldDepartmentName)
                    {
                        o.DepartmentRowNumber = (++departmentRowNumber).ToString();
                        oldDepartmentName = o.ICDepartmentName;
                        rowNumber = 0;
                    }
                    //o.RowNumber = departmentRowNumber.ToString() + "." + (++rowNumber).ToString();
                    o.RowNumber = (++rowNumber).ToString();
                });
            report.bsShipmentSaleOrderItems.DataSource = ShipmentItemsInfoListForReport;
        }

        public void PrintDeliveryProductA5()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID >= 0)
            {
                RPDeliveryProductA5 report = new RPDeliveryProductA5();
                InitRPDeliveryProductA5(report);
                guiReportPreview reviewer = new guiReportPreview(report, null, true);
                reviewer.Show();
            }
        }

        private void InitRPDeliveryProductA5(RPDeliveryProductA5 report)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanys"];
            if (label != null)
            {
                label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc.ToUpper();
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel36"];
                if (label != null)
                {
                    label.Text = "Điện thoại: " + objBranchsInfo.BRBranchWarrantyPhone;
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
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblToDate"];
            if (label != null)
            {
                label.Text = BOSApp.GetCurrentServerDate().ToString("dd/MM/yyyy");
            }
            ICStocksController objStocksController = new ICStocksController();
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabelKho"];
            if (label != null)
            {
                label.Text = objStocksController.GetObjectNameByID(mainObject.FK_ICStockID);
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ICObjectType);
            if (objObjectsInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectName"];
                if (label != null)
                {
                    label.Text = objObjectsInfo.ACObjectName;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectAddress"];
                if (label != null)
                {
                    label.Text = objObjectsInfo.ACObjectContactAddress;
                }
            }
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(mainObject.ARSaleOrderNo);
            if (objSaleOrdersInfo != null)
            {
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectDeliveryAddress"];
                if (label != null)
                {
                    label.Text = objSaleOrdersInfo.ARSaleOrderDeliveryAddressLine3;
                }
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblInvoiceHDNumber"];
            if (label != null)
            {
                if (objSaleOrdersInfo == null)
                {
                    label.Text = "(Theo HĐ/PĐH số: 0047/17/KH)";
                }
                else
                {
                    label.Text = "(Theo HĐ/PĐH số: " + objSaleOrdersInfo.ARSaleOrderNo + ")";
                }
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblInvoiceCodeNumber"];
            if (label != null)
            {
                label.Text = "KTO-QT2-BM4";
            }
            string strIsBKV = BOSApp.GetDisplayTextFromConfigText("ProjectBKV", "true");
            bool isBKV = bool.Parse(string.IsNullOrWhiteSpace(strIsBKV) ? "false" : strIsBKV);
            if (!isBKV)
            {
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblChuKy4"];
                if (label != null)
                {
                    label.Text = "Khách hàng";
                }
                label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblChuKy5"];
                if (label != null)
                {
                    label.Text = @"Giám đốc
(Kế toán trưởng)";
                }
            }
            report.bsShipmentSaleOrder.DataSource = mainObject;

            List<ICShipmentItemsInfo> ShipmentItemsInfoListForReport = objShipmentItemController.GetAllShipmentItemForRPDeliveryProductByShipmentID(mainObject.ICShipmentID);
            ShipmentItemsInfoListForReport = ShipmentItemsInfoListForReport.OrderBy(x => x.ICDepartmentName).ToList();
            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;
            ShipmentItemsInfoListForReport.ForEach(o =>
            {
                if (o.ICDepartmentName != oldDepartmentName)
                {
                    o.DepartmentRowNumber = (++departmentRowNumber).ToString();
                    oldDepartmentName = o.ICDepartmentName;
                    rowNumber = 0;
                }
                //o.RowNumber = departmentRowNumber.ToString() + "." + (++rowNumber).ToString();
                o.RowNumber = (++rowNumber).ToString();
            });
            report.bsShipmentSaleOrderItems.DataSource = ShipmentItemsInfoListForReport;
        }

        public void PrintShipmentWoodHP()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID >= 0)
            {
                RPShipmentWoodHP report = new RPShipmentWoodHP();
                InitRPShipmentWoodHP(report);
                guiReportPreview reviewer = new guiReportPreview(report, null, true);
                reviewer.Show();
            }
        }

        public void InitRPShipmentWoodHP(RPShipmentWoodHP report)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemController = new ICShipmentItemsController();
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanys"];
            if (label != null)
            {
                label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc.ToUpper();
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
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblShipmentDate"];
            if (label != null)
            {
                label.Text = string.Format("Ngày {0} tháng {1} năm {2}", mainObject.ICShipmentDate.ToString("dd")
                                                                        , mainObject.ICShipmentDate.ToString("MM")
                                                                        , mainObject.ICShipmentDate.ToString("yyyy"));
            }
            //ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            //ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(mainObject.FK_ARSaleOrderID);
            //if (objSaleOrdersInfo != null)
            //{
            //    mainObject.ICShipmentTaxAmount = objSaleOrdersInfo.ARSaleOrderTaxAmount;
            //    mainObject.ICShipmentTotalAmount = objSaleOrdersInfo.ARSaleOrderTotalAmount;
            //}    
            report.bsShipmentSaleOrder.DataSource = mainObject;

            List<ICShipmentItemsInfo> ShipmentItemsInfoListForReport = objShipmentItemController.GetAllShipmentItemForRPShipmentWoodByShipmentID(mainObject.ICShipmentID);
            report.bsShipmentSaleOrderItems.DataSource = ShipmentItemsInfoListForReport;
        }

        #endregion

        public void CopyItemToNewRow()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                ICShipmentItemsInfo objCopyShipmentItems = (ICShipmentItemsInfo)objShipmentItemsInfo.Clone();
                objCopyShipmentItems.Id = 0;
                objCopyShipmentItems.ICShipmentItemProductQty = 0;
                objCopyShipmentItems.ICShipmentItemProductExchangeQty = 0;
                entity.ShipmentItemList.Add(objCopyShipmentItems);
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                UpdateTotalAmount();
            }
        }
        public void DeleteItemShipmentPackagesList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                entity.ShipmentPackageList.RemoveSelectedRowObjectFromList();
            }
        }
        public void ShowGuiPackage(ICShipmentPackagesInfo itemPack, ICShipmentItemsInfo obj)
        {
            if (!Toolbar.IsNullOrNoneAction() || itemPack != null)
            {
                ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                ICProductPackagesController pacCtrl = new ICProductPackagesController();

                guiAddProductPackageItems guiPack = new guiAddProductPackageItems();
                guiPack.Module = this;
                if (itemPack != null)
                {
                    guiPack.PacQty = itemPack.ICShipmentPackageQty;
                    guiPack.FK_ICProductID = itemPack.FK_ICProductID;
                    guiPack.IsView = true;
                    guiPack.PackNo = itemPack.ICShipmentPackageNo;
                }
                if (obj != null)
                {
                    guiPack.PacQty = obj.ICShipmentItemProductQty;
                    guiPack.FK_ICProductID = obj.FK_ICProductID;
                }
                guiPack.ShipmentItemList = entity.ShipmentItemList;
                // guiPack.PackNoList = entity.ShipmentPackageList.Select(o => new PackInfo { PackNo = o.ICShipmentPackageNo}).Distinct().ToList();
                if (guiPack.ShowDialog() == DialogResult.OK)
                {
                    List<ICProductPackageItemsInfo> selected = guiPack.SelectedObjects;
                    if (selected != null && selected.Count > 0)
                    {
                        List<PackInfo> result = selected.GroupBy(gr => new { gr.FK_ICProductPackageID, gr.ICProductPackageNo, gr.ICProductPackageQty, })
                            .Select(gr => new PackInfo
                            {
                                PackID = gr.Key.FK_ICProductPackageID
                            ,
                                PackNo = gr.Key.ICProductPackageNo
                            ,
                                PackQty = gr.Key.ICProductPackageQty
                            }).ToList();
                        if (result != null)
                        {
                            List<ICProductPackagesInfo> PackageList = pacCtrl.GetPackageDataByPackageIDList(string.Join(",", result.Select(o => o.PackID).Distinct().ToArray()));
                            if (PackageList != null)
                            {
                                foreach (PackInfo item in result)
                                {
                                    List<ICProductPackagesInfo> PackageFoundList = PackageList.Where(o => o.ICProductPackageID == item.PackID).ToList();
                                    if (PackageFoundList != null && PackageFoundList.Count > 0)
                                    {
                                        List<ICShipmentPackagesInfo> shipmentPackList = new List<ICShipmentPackagesInfo>();
                                        shipmentPackList = ConvertToShipmentPackList(PackageFoundList, item, objShipmentsInfo);
                                        if (shipmentPackList != null)
                                        {
                                            foreach (ICShipmentPackagesInfo PackItem in shipmentPackList)
                                            {
                                                ICShipmentPackagesInfo exitObj = entity.ShipmentPackageList.Where(p => p.FK_ICProductPackageID == PackItem.FK_ICProductPackageID).FirstOrDefault();
                                                if (exitObj != null && exitObj.FK_ICProductPackageID > 0)
                                                {
                                                    exitObj.ICShipmentPackageQty += PackItem.ICShipmentPackageQty;
                                                    exitObj.ICShipmentPackageVolumn = PackItem.ICShipmentPackageVolumn * exitObj.ICShipmentPackageQty;
                                                }
                                                else
                                                {
                                                    PackItem.ICShipmentPackageVolumn = PackItem.ICShipmentPackageVolumn * PackItem.ICShipmentPackageQty;
                                                    entity.ShipmentPackageList.Add(PackItem);
                                                }

                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
                entity.ShipmentPackageList.GridControl.RefreshDataSource();

            }
        }
        public List<ICShipmentPackagesInfo> ConvertToShipmentPackList(List<ICProductPackagesInfo> PackageList, PackInfo objPack, ICShipmentsInfo objShipmentsInfo)
        {
            List<ICShipmentPackagesInfo> pack = new List<ICShipmentPackagesInfo>();
            foreach (ICProductPackagesInfo item in PackageList)
            {
                ICShipmentPackagesInfo resultItem = new ICShipmentPackagesInfo();
                BOSUtil.CopyObject(item, resultItem);
                resultItem.ICShipmentPackageQty = objPack.PackQty;
                resultItem.FK_ICShipmentID = objShipmentsInfo.ICShipmentID;
                resultItem.FK_ICProductPackageID = objPack.PackID;
                pack.Add(resultItem);

            }
            return pack;
        }
        public bool ValidatePackage()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductPackagesController pacCtrl = new ICProductPackagesController();
            ICProductPackageItemsController pacItemCtrl = new ICProductPackageItemsController();
            bool isValid = true;
            List<string> productList = entity.ShipmentItemList.Select(o => o.FK_ICProductID.ToString()).Distinct().ToList();
            List<string> packIDList = entity.ShipmentPackageList.Select(o => o.FK_ICProductPackageID.ToString()).Distinct().ToList();
            entity.ShipmentItemList.ForEach(o => o.IsError = false);
            entity.ShipmentPackageList.ForEach(o => o.IsError = false);
            if (productList != null && productList.Count > 0)
            {
                List<ICProductPackagesInfo> PackageList = pacCtrl.GetPackageDataByProductIDList(string.Join(",", productList.ToArray()));
                List<MMProductionNormItemPackingsInfo> normItemList = (new MMProductionNormItemPackingsController()).GetNormListByPackListID(string.Join(",", packIDList.ToArray()));
                List<ICProductPackageItemsInfo> PackageItemList = pacItemCtrl.GetPackageItemsListByListPackageID(string.Join(",", packIDList.ToArray()));
                if (PackageList != null && entity.ShipmentPackageList.Count > 0)
                {
                    entity.ShipmentPackageList.ForEach(s =>
                    {
                        ICProductPackagesInfo packNormItem = PackageList.Where(p => p.FK_ICProductID == s.FK_ICProductID).FirstOrDefault();
                        if (packNormItem == null || packNormItem.ICProductPackageID == 0)
                        {
                            s.IsError = true;
                            isValid = false;
                        }
                    });
                    if (!isValid)
                    {
                        BOSApp.ShowMessage("Tồn tại kiện không thuộc sản phẩm muốn xuất kho?");
                        isValid = false;
                    }
                }

                if (PackageItemList != null && PackageItemList.Count > 0)
                {
                    string mess = string.Empty;
                    string mess1 = string.Empty;
                    List<ICShipmentItemsInfo> ErrorShipment = new List<ICShipmentItemsInfo>();
                    List<ICShipmentItemsInfo> Error1Shipment = new List<ICShipmentItemsInfo>();
                    foreach (string productID in productList)
                    {
                        List<ICShipmentItemsInfo> ShipmentItem = entity.ShipmentItemList.Where(s => s.FK_ICProductID.ToString() == productID).ToList();
                        List<ICProductPackagesInfo> productPack = PackageList.Where(p => p.FK_ICProductID.ToString() == productID).ToList();
                        if (ShipmentItem != null && productPack != null && productPack.Count > 0)
                        {
                            //lấy danh sách BOM theo kiện
                            List<int> listVersionBOM = productPack.Select(p => p.FK_MMProductionNormID).Distinct().ToList();
                            ShipmentItem.ForEach(s =>
                            {
                                s.ICShipmentItemProductPakagingQty = 0;
                            });
                            listVersionBOM.ForEach(pa =>
                           {
                               // đỗ dữ liệu kiện vào từng BOM và tính lại tỉ lệ đồng bộ / BOM
                               List<MMProductionNormItemPackingsInfo> normDetailList = normItemList.Where(o => o.FK_MMProductionNormID == pa).ToList();
                               //Lấy định mức kiện theo BOM
                               List<ICProductPackageItemsInfo> PackageNormList = PackageItemList.Where(p => p.FK_MMProductionNormID == pa).ToList();

                               PackageNormList.ForEach(pni =>
                               {
                                   //Số lượng chi tiết trong các kiện
                                   decimal PackagedInShipment = entity.ShipmentPackageList.Where(o => pni.FK_ICProductPackageID == o.FK_ICProductPackageID).Sum(o => o.ICShipmentPackageQty);
                                   pni.ICProductPackageItemQty = pni.ICProductPackageItemQty * PackagedInShipment;
                               });
                               decimal totalShipmentQty = ShipmentItem.Sum(s => s.ICShipmentItemProductQty);

                               normDetailList.ForEach(n =>
                               {
                                   List<ICProductPackageItemsInfo> PackageStructList = PackageNormList.Where(pan => pan.MMProductionNormItemID == n.FK_MMProductionNormItemSemiProductID).ToList();
                                   if (PackageStructList.Count() > 0)
                                       n.MMProductionNormItemPackQuantity = PackageStructList.Sum(pan => pan.ICProductPackageItemQty);
                                   else //Cấu trúc kiện không đồng bộ cấu trúc BOM
                                   {
                                       ICShipmentItemsInfo shipmentE = ShipmentItem.FirstOrDefault();
                                       if (!Error1Shipment.Any(s => s.FK_ICProductID.ToString() == productID))
                                           Error1Shipment.Add(shipmentE);
                                   }
                                   //Tỉ lệ đồng bộ
                                   n.MMProductionNormItemFactor = n.MMProductionNormItemPackQuantity / (n.MMProductionNormItemQuantity != 0 ? n.MMProductionNormItemQuantity : n.MMProductionNormItemQuantity);
                               });

                               decimal minShipmentQty = normDetailList.Min(d => d.MMProductionNormItemFactor);
                               ShipmentItem.ForEach(s =>
                               {
                                   if (minShipmentQty > 0)
                                   {
                                       s.ICShipmentItemProductPakagingQty += Math.Min(minShipmentQty, s.ICShipmentItemProductQty);
                                       minShipmentQty = minShipmentQty - Math.Min(minShipmentQty, s.ICShipmentItemProductPakagingQty);
                                   }
                               });
                           });
                            ShipmentItem.ForEach(si =>
                            {
                                if (si.ICShipmentItemProductPakagingQty < si.ICShipmentItemProductQty)
                                {
                                    if (!ErrorShipment.Any(s => s.FK_ICProductID.ToString() == productID))
                                        ErrorShipment.Add(si);
                                    si.IsError = true;
                                }
                            });
                        }
                    }
                    if (ErrorShipment != null && ErrorShipment.Count > 0)
                    {
                        mess = string.Join(Environment.NewLine, ErrorShipment.Select(s => s.ICShipmentItemProductDesc + ": SL đồng bộ theo kiện: " + s.ICShipmentItemProductPakagingQty.ToString()).ToArray());
                        BOSApp.ShowMessage("Số lượng chi tiết trong kiện không đồng bộ với kiện của sản phẩm" + Environment.NewLine + mess);
                        isValid = false;
                    }
                    if (Error1Shipment != null && Error1Shipment.Count > 0)
                    {
                        mess1 = string.Join(Environment.NewLine, Error1Shipment.Select(s => s.ICShipmentItemProductDesc).ToArray());
                        BOSApp.ShowMessage("Kiện đã nhập có cấu trúc không đồng bộ với kiện của sản phẩm" + Environment.NewLine + mess1);
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public bool CheckExistInShipmentItemList(int productID)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            return entity.ShipmentItemList.Where(o => o.FK_ICProductID == productID).Count() > 0;
        }

        public override void ActionCancel()
        {
            IsEditAfterCompleting = false;
            base.ActionCancel();
        }

        public decimal GetShipmentQtyIsValidFromConfig(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            ICStockConfigRatesController objStockConfigRatesController = new ICStockConfigRatesController();
            ICStockConfigRatesInfo objStockConfigRatesInfo = objStockConfigRatesController.GetStockConfigRatesByProduct(objDeliveryPlanItemsInfo.FK_ICProductID);
            if (objStockConfigRatesInfo == null)
                return objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemCancelQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty;

            if (objStockConfigRatesInfo.ICStockConfigRateIsIncrease)
                return (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemCancelQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty) * (1 + objStockConfigRatesInfo.ICStockConfigRatePercent / 100);

            if (objStockConfigRatesInfo.ICStockConfigRateIsIncrease)
                return (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemCancelQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty) * (1 - objStockConfigRatesInfo.ICStockConfigRatePercent / 100);

            return objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemCancelQty - objDeliveryPlanItemsInfo.ARDeliveryPlanItemShipmentQty;
        }

        public void ChangeProject(int projectID)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_PMProjectID = projectID;
        }

        public void ChangeItemExchangeQty(ICShipmentItemsInfo item)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductFactor * item.ICShipmentItemProductQty;
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void PrintShipmentSaleOrderTV()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            object[] arParam = new object[1];
            arParam[0] = objShipmentsInfo.ICShipmentID;
            ViewReportByTemplate("RPShipmentTV", "GetDataSourceForRPShipmentTV", arParam);
        }

        public List<ICProductsInfo> GetAllSectionProductForLookUp()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> sectionProductList = objProductsController.GetSectionProductByTemplateID(mainObject.FK_PMTemplateID);
            return sectionProductList;
        }

        public void ShowTemplateItemTree()
        {
            //ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            //ICShipmentsInfo mainobject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            //if (mainobject.FK_PMTemplateID == 0)
            //{
            //    MessageBox.Show(ProposalLocalizedResources.TemplateIsRequirer, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            //if (objShipmentItemsInfo == null)
            //    return;

            //guiShowTemplateItems guiShowTemplateItems = new guiShowTemplateItems();
            //guiShowTemplateItems.PMTemplateID = mainobject.FK_PMTemplateID;
            //guiShowTemplateItems.PMTemplateItemID = objShipmentItemsInfo.FK_PMTemplateItemID;
            //guiShowTemplateItems.PMTemplateItemProductName = objShipmentItemsInfo.PMTemplateItemProductName;
            //guiShowTemplateItems.Module = this;
            //DialogResult rs = guiShowTemplateItems.ShowDialog();
            //if (rs != DialogResult.OK)
            //    return;

            //objShipmentItemsInfo.FK_PMTemplateItemID = guiShowTemplateItems.PMTemplateItemID;
            //objShipmentItemsInfo.PMTemplateItemProductName = guiShowTemplateItems.PMTemplateItemProductName;

            //if (entity.ShipmentItemList.GridControl != null)
            //{
            //    entity.ShipmentItemList.EndCurrentEdit();
            //    entity.ShipmentItemList.GridControl.RefreshDataSource();
            //}
        }

        public void ChangeCostCenter(int costCenterID)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_ACCostCenterID = costCenterID;
            entity.ShipmentItemList.ForEach(o => o.FK_ACCostCenterID = costCenterID);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void ChangeDisplayAndDataItemListGridView()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            bool isWoodType = BOSApp.IsWoodTypeDocument(objShipmentsInfo.ICShipmentProductType, entity.ShipmentItemList.FirstOrDefault());

            ChangeDisplayColumnByWoodType(entity.ShipmentItemList.GridControl, isWoodType);
            if (!isWoodType)
                entity.ShipmentItemList.ForEach(o1 => o1.ICShipmentItemLotNo = string.Empty);
        }

        public void ChangeInputType(string type)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentProductType = type;
            entity.UpdateMainObjectBindingSource();
            ChangeDisplayAndDataItemListGridView();
        }
        
        public void ShowItemComponent()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (objShipmentItemsInfo.ICShipmentItemComponentList == null || objShipmentItemsInfo.ICShipmentItemComponentList.Count == 0)
                {
                    MessageBox.Show(SaleOrderLocalizedResources.ComponentIsNull, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                guiItemComponent<ICShipmentItemComponentsInfo> guiItemComponent = new guiItemComponent<ICShipmentItemComponentsInfo>(objShipmentItemsInfo.ICShipmentItemComponentList);
                guiItemComponent.Module = this;
                if (guiItemComponent.ShowDialog() == DialogResult.OK)
                {
                    objShipmentItemsInfo.ICShipmentItemComponentList.Clear();
                    if (guiItemComponent.ItemComponentList.Count > 0)
                    {
                        foreach (ICProductComponentsInfo objProductComponentsInfo in guiItemComponent.ItemComponentList)
                        {
                            ICShipmentItemComponentsInfo objShipmentItemComponentsInfo = new ICShipmentItemComponentsInfo();
                            objShipmentItemComponentsInfo.ICShipmentItemComponentID = objProductComponentsInfo.ItemComponentID;
                            objShipmentItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                            objShipmentItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                            objShipmentItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                            objShipmentItemComponentsInfo.FK_ICStockID = objProductComponentsInfo.FK_ICStockID;
                            objShipmentItemComponentsInfo.FK_ICProductSerieID = objProductComponentsInfo.FK_ICProductSerieID;
                            objShipmentItemComponentsInfo.ICShipmentItemComponentQty = objProductComponentsInfo.ICProductComponentQty;
                            objShipmentItemComponentsInfo.ICShipmentItemComponentProductSerialNo = objProductComponentsInfo.ICProductSerialNo;
                            objShipmentItemsInfo.ICShipmentItemComponentList.Add(objShipmentItemComponentsInfo);
                        }
                    }
                }
            }
        }
        public void GenerateShipmentItemComponent()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objShipmentItemsInfo.ICShipmentItemComponentList = null;
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo != null && objProductsInfo.HasComponent)
                {
                    objShipmentItemsInfo.ICShipmentItemComponentList = new BOSList<ICShipmentItemComponentsInfo>();
                    objShipmentItemsInfo.ICShipmentItemComponentList.InitBOSList(entity,
                                                                                  TableName.ICShipmentItemsTableName,
                                                                                  TableName.ICShipmentItemComponentsTableName,
                                                                                  BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
                    objShipmentItemsInfo.ICShipmentItemComponentList.ItemTableForeignKey = "FK_ICShipmentItemID";

                    if (objShipmentItemsInfo.Id > 0)
                    {
                        ICShipmentItemComponentsController objShipmentItemComponentsController = new ICShipmentItemComponentsController();
                        List<ICShipmentItemComponentsInfo> listComponent = objShipmentItemComponentsController.GetShipmentItemComponentListByShipmentItemID(objShipmentItemsInfo.Id);
                        objShipmentItemsInfo.ICShipmentItemComponentList.Invalidate(listComponent);
                    }
                    if (objShipmentItemsInfo.ICShipmentItemComponentList.Count == 0)
                    {
                        BOSList<ICShipmentItemComponentsInfo> defaultComponents = GetDefaultItemComponent(objShipmentItemsInfo);
                        objShipmentItemsInfo.ICShipmentItemComponentList = defaultComponents;
                    }
                }
            }
        }
        public BOSList<ICShipmentItemComponentsInfo> GetDefaultItemComponent(ICShipmentItemsInfo item)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            BOSList<ICShipmentItemComponentsInfo> listComponent = new BOSList<ICShipmentItemComponentsInfo>();
            listComponent.InitBOSList(entity,
                                        TableName.ICShipmentItemsTableName,
                                        TableName.ICShipmentItemComponentsTableName,
                                        BOSList<ICShipmentItemComponentsInfo>.cstRelationForeign);
            listComponent.ItemTableForeignKey = "FK_ICShipmentItemID";
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(item.FK_ICProductID);
            foreach (ICProductComponentsInfo objProductComponentsInfo in components)
            {
                ICShipmentItemComponentsInfo objShipmentItemComponentsInfo = new ICShipmentItemComponentsInfo();
                objShipmentItemComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                objShipmentItemComponentsInfo.ICShipmentItemComponentQty = objProductComponentsInfo.ICProductComponentQty * item.ICShipmentItemProductQty;
                objShipmentItemComponentsInfo.ICProductComponentQty = objProductComponentsInfo.ICProductComponentQty;
                objShipmentItemComponentsInfo.ICProductDesc = objProductComponentsInfo.ICProductDesc;
                objShipmentItemComponentsInfo.ICProductSupplierNo = objProductComponentsInfo.ICProductSupplierNo;
                objShipmentItemComponentsInfo.FK_ICStockID = item.FK_ICStockID;
                objShipmentItemComponentsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                objShipmentItemComponentsInfo.ICShipmentItemComponentProductSerialNo = objProductSeriesController.GetObjectNoByID(objShipmentItemComponentsInfo.FK_ICProductSerieID);
                listComponent.Add(objShipmentItemComponentsInfo);
            }
            return listComponent;
        }
        public void ChangeItemComponentStock(ICShipmentItemsInfo objShipmentItemsInfo)
        {
            if (objShipmentItemsInfo.ICShipmentItemComponentList == null || objShipmentItemsInfo.ICShipmentItemComponentList.Count == 0)
                return;
            foreach (ICShipmentItemComponentsInfo component in objShipmentItemsInfo.ICShipmentItemComponentList)
            {
                component.FK_ICStockID = objShipmentItemsInfo.FK_ICStockID;
                component.FK_ICProductSerieID = objShipmentItemsInfo.FK_ICProductSerieID;
            }
        }
        public void ChangeComponentItemQty()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (objShipmentItemsInfo.ICShipmentItemComponentList != null)
                {
                    objShipmentItemsInfo.ICShipmentItemComponentList.Clear();
                    BOSList<ICShipmentItemComponentsInfo> defaultComponents = GetDefaultItemComponent(objShipmentItemsInfo);
                    foreach (ICShipmentItemComponentsInfo objShipmentItemComponentsInfo in defaultComponents)
                    {
                        objShipmentItemComponentsInfo.ICShipmentItemComponentQty = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemComponentsInfo.ICProductComponentQty;
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemComponentsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                            {
                                objShipmentItemComponentsInfo.ICShipmentItemComponentQty = Math.Round(objShipmentItemComponentsInfo.ICShipmentItemComponentQty, 4, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                objShipmentItemComponentsInfo.ICShipmentItemComponentQty = Math.Round(objShipmentItemComponentsInfo.ICShipmentItemComponentQty, 2, MidpointRounding.AwayFromZero);
                            }
                        }
                        objShipmentItemsInfo.ICShipmentItemComponentList.Add(objShipmentItemComponentsInfo);
                    }
                }
            }
        }

        public void ChangeShipmentInfomation()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.ICShipmentItemContainerNumber = mainObject.ICShipmentContainerNumber;
                item.ICShipmentItemContainerSealNumber = mainObject.ICShipmentContainerSealNumber;
                item.ICShipmentItemTractorTrailerNumber = mainObject.ICShipmentTractorTrailerNumber;
                item.ICShipmentItemShipNumber = mainObject.ICShipmentShipNumber;
                item.ICShipmentItemETDDate = mainObject.ICShipmentETDDate;
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }    

        public void AutoSelectProductSerialNo()
        {
            if(Toolbar.IsNullOrNoneAction())
            {
                return;
            }    

            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if(entity.ShipmentItemList.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm xuất kho để gắn mã lô!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.ShipmentItemList.ForEach(o => o.ICShipmentDate = mainObject.ICShipmentDate);
            List<ICShipmentItemsInfo> listShipmentItems = entity.ShipmentItemList;
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            listShipmentItems = objShipmentItemsController.GetListInventoryStockSerialNoForShipment(listShipmentItems);
            listShipmentItems = listShipmentItems.OrderBy(o => o.ICProductSerieReceiptDate).ToList();
            ICShipmentItemsInfo shipmentItemQty = new ICShipmentItemsInfo();
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                shipmentItemQty = listShipmentItems.FirstOrDefault(o => o.FK_ICProductID == item.FK_ICProductID && o.ICShipmentItemProductExchangeQty >= item.ICShipmentItemProductExchangeQty);
                if(shipmentItemQty != null)
                {
                    item.FK_ICStockID = shipmentItemQty.FK_ICStockID;
                    item.FK_ICProductSerieID = shipmentItemQty.FK_ICProductSerieID;
                    item.ICShipmentItemProductSerialNo = shipmentItemQty.ICShipmentItemProductSerialNo;
                    item.ICShipmentItemLotNo = shipmentItemQty.ICShipmentItemLotNo;
                    shipmentItemQty.ICShipmentItemProductExchangeQty -= item.ICShipmentItemProductExchangeQty;
                    ChangeItemSerieNo(item);
                }
            }
        }

        public override void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            //if (objShipmentsInfo.FK_GECurrencyID == GECurrencyID.VND)
            {
                decimal unitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
                item.ICShipmentItemProductUnitCost = unitCost * item.ICShipmentItemProductFactor;
                item.ICShipmentItemExchangeUnitCost = unitCost ;
                entity.SetProductPriceByProductUnitPrice(item);
            }    
            
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                {
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, 5, MidpointRounding.AwayFromZero);
                }
                else
                {
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, 3, MidpointRounding.AwayFromZero);
                }
            }

            if (objShipmentsInfo.FK_GECurrencyID == GECurrencyID.VND && entity.ShipmentItemList.FirstOrDefault()?.FK_ARSaleOrderID == 0)
            {
                BOSApp.RoundByCurrency(item, objShipmentsInfo.FK_GECurrencyID);
            }
            else
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(entity.ShipmentItemList[0].FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    BOSApp.RoundByCurrency(item, objSaleOrdersInfo.FK_GECurrencyID);
                }
            }
            
            entity.ShipmentItemList.GridControl?.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void ChangeInternalSeal()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.ICShipmentItemInternalSeal = mainObject.ICShipmentInternalSeal;
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        public void PrintPackingListHP()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RP_PrintPackingListHP report = new RP_PrintPackingListHP();
                InitPrintPackingListHP(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }
        private static void InitPrintPackingListHP(XtraReport report, int sID)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)objShipmentsController.GetObjectByID(sID);
            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> dpiList = objReportsController.GetListShipmentItemsForReportPrintPackingListHPBySID(sID);
            report.DataSource = dpiList;
        }
        public void UpdatePositionItem(ICShipmentItemsInfo item)
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)CurrentModuleEntity;
            ICShipmentsInfo objICShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMUpdatePositionItemsController objUpdatePositionItemsController = new MMUpdatePositionItemsController();
            MMUpdatePositionItemsInfo objUpdatePositionItemsInfo = (MMUpdatePositionItemsInfo)objUpdatePositionItemsController.GetItemByLocationName(string.Empty, item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID);
            if (objUpdatePositionItemsInfo != null)
            {
                item.FK_MMUpdatePositionItemID = objUpdatePositionItemsInfo.MMUpdatePositionItemID;
            }
        }
    }
}