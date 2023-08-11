using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    #region TransferPlanModule
    public class TransferPlanModule : BaseTransactionModule
    {
        #region Constant for Estimate

        public const string ARDeliveryPlanItemsGridControlName = "fld_dgcARDeliveryPlanItemsGridControl";

        public const string ARDeliveryPlanTrucksGridControlName = "fld_dgcARDeliveryPlanTrucksGridControl";

        public const string ARDeliveryPlanTruckPointsGridControlName = "fld_dgcARDeliveryPlanTruckPointsGridControl";

        public const string PMTaskSumarysGridControlName = "fld_dgcPMTasksGridControl";

        public const string AddNewButtonControlName = "fld_btnAddProduct";

        #endregion

        #region Public properties

        public ARDeliveryPlanItemsGridControl ARDeliveryPlanItemsGridControl { get; set; }

        public ARDeliveryPlanTrucksGridControl ARDeliveryPlanTrucksGridControl { get; set; }

        public ARDeliveryPlanTruckPointsGridControl ARDeliveryPlanTruckPointsGridControl { get; set; }

        public BOSButton AddNewButtonControl { get; set; }
        #endregion

        public TransferPlanModule()
        {
            Name = ModuleName.TransferPlan;
            CurrentModuleEntity = new TransferPlanEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ARDeliveryPlanItemsGridControl = (ARDeliveryPlanItemsGridControl)Controls[ARDeliveryPlanItemsGridControlName];
            ARDeliveryPlanTrucksGridControl = (ARDeliveryPlanTrucksGridControl)Controls[ARDeliveryPlanTrucksGridControlName];
            ARDeliveryPlanTruckPointsGridControl = (ARDeliveryPlanTruckPointsGridControl)Controls[ARDeliveryPlanTruckPointsGridControlName];
            AddNewButtonControl = (BOSButton)Controls[AddNewButtonControlName];
        }

        public void NewFromSaleReturn()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            entity.SetDefaultModuleObjectsList();
            List<ARSaleReturnItemsInfo> results = ShowFindSaleReturn();
            if (results.Count == 0)
            {
                base.ActionCancel();
                return;
            }
            base.ActionNew();
            AddNewButtonControl.Enabled = true;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            mainObject.ARDeliveryPlanBeginDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanEndDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanFromType = DeliveryPlanFromType.SaleReturn.ToString();

            entity.DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();
            entity.GenarateDeliveryPlanItems(results);
            entity.UpdateMainObjectBindingSource();
            ARDeliveryPlanItemsGridControl.HiddenObjectProperty(mainObject.ARDeliveryPlanFromType);
            ARDeliveryPlanItemsGridControl.RefreshDataSource();
        }

        public void NewFromTransferStock()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            entity.SetDefaultModuleObjectsList();
            List<ICTransferItemsInfo> results = ShowFindTransfer();
            if (results.Count == 0)
            {
                base.ActionCancel();
                return;
            }
            base.ActionNew();
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            mainObject.ARDeliveryPlanBeginDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanEndDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanFromType = DeliveryPlanFromType.Tranfer.ToString();
            entity.DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();

            entity.GenarateDeliveryPlanItems(results);
            entity.UpdateMainObjectBindingSource();
            ARDeliveryPlanItemsGridControl.HiddenObjectProperty(mainObject.ARDeliveryPlanFromType);
            ARDeliveryPlanItemsGridControl.RefreshDataSource();
        }

        public void ActionComplete()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            mainObject.ARDeliveryPlanStatus = DeliveryPlanStatus.Completed.ToString();
            entity.UpdateMainObject();
            entity.ARDeliveryPlanItemsList.SaveItemObjects();
            base.ActionComplete();
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton("Validate", false);
            ARDeliveryPlanItemsGridControl.Enabled = true;
            if (mainObject.ARDeliveryPlanID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton("Validate", true);
                if (mainObject.ARDeliveryPlanStatus == ConfigSalesTargetStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    AddNewButtonControl.Enabled = true;
                }
                else if (mainObject.ARDeliveryPlanStatus == DeliveryPlanStatus.Verified.ToString()
                    || mainObject.ARDeliveryPlanStatus == DeliveryPlanStatus.Shipmented.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Validate", false);
                    AddNewButtonControl.Enabled = false;
                    ARDeliveryPlanItemsGridControl.Enabled = false;
                }
                else if (mainObject.ARDeliveryPlanStatus == DeliveryPlanStatus.Completed.ToString()
                    || mainObject.ARDeliveryPlanStatus == DeliveryPlanStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Validate", false);
                    AddNewButtonControl.Enabled = false;
                }
            }
        }

        public void AddDeliveryPlanTrucksList()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> products = new List<ICProductsInfo>();
            products = objProductsController.GetProductByProductType(ProductType.Car.ToString());
            products = products.Where(o => !entity.ARDeliveryPlanTrucksList.Select(s => s.FK_ICProductID).Contains(o.ICProductID)).ToList();

            guiFind<ICProductsInfo> guiFind = new guiFind<ICProductsInfo>(TableName.ICProductsTableName, products, this, true, true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            List<ICProductsInfo> results = guiFind.SelectedObjects.ToList();
            results.ForEach(o => entity.ARDeliveryPlanTrucksList.Add(entity.ToARDeliveryPlanTrucksInfo(o)));
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.FK_HRDepartmentID = 5;
                o.FK_HRDepartmentRoomID = 12;
            });
            ARDeliveryPlanTrucksGridControl.RefreshDataSource();
        }

        public void AddProduct()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;
            if (objDeliveryPlansInfo.ARDeliveryPlanFromType == DeliveryPlanFromType.SaleReturn.ToString())
            {
                List<ARSaleReturnItemsInfo> saleReturnItems = ShowFindSaleReturn();
                if (saleReturnItems.Count == 0)
                    return;
                entity.GenarateDeliveryPlanItems(saleReturnItems);
            }
            else
            {
                List<ICTransferItemsInfo> transferItems = ShowFindTransfer();
                if (transferItems.Count == 0)
                    return;
                entity.GenarateDeliveryPlanItems(transferItems);
            }
            ARDeliveryPlanItemsGridControl.RefreshDataSource();
        }

        private List<ARSaleReturnItemsInfo> ShowFindSaleReturn()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            guiFindSaleReturn guiFindSaleReturn = new guiFindSaleReturn(entity.ARDeliveryPlanItemsList);
            guiFindSaleReturn.Module = this;
            guiFindSaleReturn.ShowDialog();
            if (guiFindSaleReturn.DialogResult != DialogResult.OK)
                return new List<ARSaleReturnItemsInfo>();
            return guiFindSaleReturn.SelectedObjects;
        }

        private List<ICTransferItemsInfo> ShowFindTransfer()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            guiFindTransfer guiFindTransfer = new guiFindTransfer(entity.ARDeliveryPlanItemsList);
            guiFindTransfer.Module = this;
            guiFindTransfer.ShowDialog();
            if (guiFindTransfer.DialogResult != DialogResult.OK)
                return new List<ICTransferItemsInfo>();
            return guiFindTransfer.SelectedObjects;
        }

        public void AttributionItemTruck()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;
            if (entity.ARDeliveryPlanTrucksList.Count <= 0)
            {
                return;
            }
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    if (o.DeliveryPlanTruckItemsList == null)
                    {
                        o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                        o.DeliveryPlanTruckItemsList.Invalidate(entity.DeliveryPlanTruckItemsList.Where(x => x.FK_ICProductTruckID == o.FK_ICProductID).ToList());
                    }
                });

            guiAttributionItemToTruck guiAttributionItemToTruck = new guiAttributionItemToTruck(entity.ARDeliveryPlanItemsList, entity.ARDeliveryPlanTrucksList);
            guiAttributionItemToTruck.Module = this;
            guiAttributionItemToTruck.ShowDialog();
            if (guiAttributionItemToTruck.DialogResult != DialogResult.OK)
                return;
            entity.DeliveryPlanTruckItemsList.Clear();
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    entity.DeliveryPlanTruckItemsList = entity.DeliveryPlanTruckItemsList.Union(o.DeliveryPlanTruckItemsList).ToList();
                });

            entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    decimal TotalM3 = o.DeliveryPlanTruckItemsList.Sum(de => (entity.ARDeliveryPlanItemsList.Where(a => a.FK_ICProductID == de.FK_ICProductID).Sum
                                   (a => a.ARDeliveryPlanItemProductHeight * a.ARDeliveryPlanItemProductLength * a.ARDeliveryPlanItemProductWidth)) * de.ARDeliveryPlanTruckItemDeliveryQty / 1000000000);

                    if (TotalM3 > o.ARDeliveryPlanTruckGrossTon)
                    {
                        if (MessageBox.Show(DeliveryPlanLocalizedResources.ConfirmCapacityAttributionItemToTruck, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                            return;
                    }
                });
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    o.ARDeliveryPlanTruckTotalQty = o.DeliveryPlanTruckItemsList.Sum(x => x.ARDeliveryPlanTruckItemDeliveryQty);
                    o.ARDeliveryPlanTruckTotalM3 = o.DeliveryPlanTruckItemsList.Sum(x => (x.ARDeliveryPlanTruckItemProductHeight * x.ARDeliveryPlanTruckItemProductWidth * x.ARDeliveryPlanTruckItemProductLength) * x.ARDeliveryPlanTruckItemDeliveryQty / 1000000000); // mm3 => m3
                    entity.GenarateDeliveryPlanTruckPoints(o.DeliveryPlanTruckItemsList.ToList(), o);
                });
            entity.UpdateDeliveryPlanTruckPoint();
            objDeliveryPlansInfo.ARDeliveryPlanTotalTruck = entity.ARDeliveryPlanTrucksList.Count();
            objDeliveryPlansInfo.ARDeliveryPlanTotalM3 = entity.ARDeliveryPlanTrucksList.Sum(o => o.ARDeliveryPlanTruckTotalM3);
            entity.UpdateMainObjectBindingSource();
            ARDeliveryPlanTrucksGridControl.RefreshDataSource();
            ARDeliveryPlanTruckPointsGridControl.RefreshDataSource();
        }

        public override int ActionSave()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;
            string deliveryPlanStauts = objDeliveryPlansInfo.ARDeliveryPlanStatus;
            if (entity.ARDeliveryPlanTrucksList.Where(o => o.ARDeliveryPlanTruckTotalQty == 0).Count() > 0)
            {
                MessageBox.Show(DeliveryPlanLocalizedResources.CheckAttributionItemToTruck, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (entity.ARDeliveryPlanTrucksList.Where(o => o.FK_HREmployeeID == 0).Count() > 0)
            {
                MessageBox.Show(DeliveryPlanLocalizedResources.CheckDriverItemToTruck, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();

            if (deliveryPlanStauts == DeliveryPlanStatus.Verified.ToString())
            {
                bool isValidated = entity.Validate();
                if (isValidated)
                    InvalidateToolbar();
            }
        }

        public void CheckDeliveryPlanItemProductQty()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = (ARDeliveryPlanItemsInfo)entity.ARDeliveryPlanItemsList[entity.ARDeliveryPlanItemsList.CurrentIndex];

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID);
            if (objSaleOrderItemsInfo == null)
                return;
            if (objDeliveryPlansInfo.ARDeliveryPlanType == DeliveryPlanType.Week.ToString())
            {
                if (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty > (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty - objSaleOrderItemsInfo.ARSaleOrderItemPlanQty))
                {
                    MessageBox.Show(DeliveryPlanLocalizedResources.CheckeliveryPlanItemProductQty, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID > 0
                        ? (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty)
                        : (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty - objSaleOrderItemsInfo.ARSaleOrderItemPlanQty);
                }
            }
            if (objDeliveryPlansInfo.ARDeliveryPlanType == DeliveryPlanType.Day.ToString())
            {
                ARDeliveryPlanItemsInfo objDeliveryPlanItemParentInfo = (ARDeliveryPlanItemsInfo)objDeliveryPlanItemsController.GetObjectByID(objDeliveryPlanItemsInfo.ARDeliveryPlanItemReferenceID);
                List<ARDeliveryPlanItemsInfo> deliveryPlanItemsList = objDeliveryPlanItemsController.GetAllDeliveryPlanItemsByDeliveryPlanItemReferenceID(objDeliveryPlanItemsInfo.ARDeliveryPlanItemReferenceID);
                if (objDeliveryPlanItemParentInfo == null && deliveryPlanItemsList == null)
                    return;
                decimal sumDeliveryPlanItemQty = deliveryPlanItemsList.Where(o => o.ARDeliveryPlanItemID != objDeliveryPlanItemsInfo.ARDeliveryPlanItemID || o.ARDeliveryPlanItemID == 0)
                                                                      .Select(o => o.ARDeliveryPlanItemProductQty)
                                                                      .Sum();
                if (objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty > objDeliveryPlanItemParentInfo.ARDeliveryPlanItemProductQty - sumDeliveryPlanItemQty)
                {
                    MessageBox.Show(DeliveryPlanLocalizedResources.DeliveryPlanQtyReaterThanDeliveryPlanItemWeekQty, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty = objDeliveryPlanItemParentInfo.ARDeliveryPlanItemProductQty - sumDeliveryPlanItemQty;
                }
            }
        }

        public void ShowDeliveryPlanTruckPointItems()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = (ARDeliveryPlanTruckPointsInfo)entity.DeliveryPlanTruckPointsList[entity.DeliveryPlanTruckPointsList.CurrentIndex];
            if (objDeliveryPlanTruckPointsInfo == null)
                return;

            List<ARDeliveryPlanTruckItemsInfo> items = entity.DeliveryPlanTruckItemsList.Where(o => o.ARDeliveryPlanTruckItemAddress == objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress
                                                                                                    && o.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID).ToList();
            guiFind<ARDeliveryPlanTruckItemsInfo> guiFind = new guiFind<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName, items, this, false, true);
            guiFind.ShowDialog();
        }

        public void DeleteTruckFromDeliveryPlanTrucksList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
                if (entity.ARDeliveryPlanTrucksList.CurrentIndex < 0)
                    return;

                ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)entity.ARDeliveryPlanTrucksList[entity.ARDeliveryPlanTrucksList.CurrentIndex];
                if (objDeliveryPlanTrucksInfo == null)
                    return;

                entity.DeliveryPlanTruckItemsList = entity.DeliveryPlanTruckItemsList.Where(o => o.FK_ICProductTruckID != objDeliveryPlanTrucksInfo.FK_ICProductID).ToList();
                entity.DeliveryPlanTruckPointsList.Invalidate(entity.DeliveryPlanTruckPointsList.Where(o => o.FK_ICProductTruckID != objDeliveryPlanTrucksInfo.FK_ICProductID).ToList());

                entity.ARDeliveryPlanTrucksList.RemoveSelectedRowObjectFromList();
            }

        }

        public void DeleteItemFromDeliveryPlanItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
                if (entity.ARDeliveryPlanItemsList.CurrentIndex < 0)
                    return;

                ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = (ARDeliveryPlanItemsInfo)entity.ARDeliveryPlanItemsList[entity.ARDeliveryPlanItemsList.CurrentIndex];
                if (objDeliveryPlanItemsInfo == null)
                    return;

                entity.DeliveryPlanTruckItemsList = entity.DeliveryPlanTruckItemsList.Where(o => o.FK_ARSaleOrderItemID != objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID).ToList();
                entity.ARDeliveryPlanTrucksList.ForEach(o =>
                    {
                        if (o.DeliveryPlanTruckItemsList != null && o.DeliveryPlanTruckItemsList.Count > 0)
                            o.DeliveryPlanTruckItemsList.Invalidate(o.DeliveryPlanTruckItemsList.Where(x => x.FK_ARSaleOrderItemID != objDeliveryPlanItemsInfo.FK_ARSaleOrderItemID).ToList());
                        o.ARDeliveryPlanTruckTotalQty = o.DeliveryPlanTruckItemsList.Sum(x => x.ARDeliveryPlanTruckItemDeliveryQty);
                        o.ARDeliveryPlanTruckTotalM3 = o.DeliveryPlanTruckItemsList.Sum(x => (x.ARDeliveryPlanTruckItemProductHeight * x.ARDeliveryPlanTruckItemProductWidth * x.ARDeliveryPlanTruckItemProductLength) * x.ARDeliveryPlanTruckItemDeliveryQty / 1000000000);
                    });

                entity.ARDeliveryPlanItemsList.RemoveSelectedRowObjectFromList();
                if (!(entity.ARDeliveryPlanItemsList.Any(o => o.ARDeliveryPlanItemAddress == objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress)))
                {
                    entity.DeliveryPlanTruckPointsList.Invalidate(entity.DeliveryPlanTruckPointsList.Where(o => o.ARDeliveryPlanTruckPointAddress != objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress).ToList());
                    entity.ARDeliveryPlanTrucksList.ForEach(o =>
                    {
                        if (o.DeliveryPlanTruckPointsList != null && o.DeliveryPlanTruckPointsList.Count > 0)
                            o.DeliveryPlanTruckPointsList.Invalidate(o.DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckPointAddress != objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress).ToList());
                    });
                }
            }
        }

        public void ShowTruckItem()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)entity.ARDeliveryPlanTrucksList[entity.ARDeliveryPlanTrucksList.CurrentIndex];
            if (objDeliveryPlanTrucksInfo == null)
                return;

            if (objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList == null)
            {
                objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.Invalidate(entity.DeliveryPlanTruckItemsList.Where(o => o.FK_ICProductTruckID == objDeliveryPlanTrucksInfo.FK_ICProductID).ToList());
            }
            guiFind<ARDeliveryPlanTruckItemsInfo> guiFind = new guiFind<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName, objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList, this, false, true);
            guiFind.ShowDialog();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo searchObject = (ARDeliveryPlansInfo)entity.SearchObject;
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            DataSet ds;
            ds = objDeliveryPlansController.GetAllTransferPlanDataSet(searchObject.ARDeliveryPlanNo,
                                                                      searchObject.ARDeliveryPlanName,
                                                                      searchObject.FK_HREmployeeID,
                                                                      searchObject.ARDeliveryPlanBeginDateFrom,
                                                                      searchObject.ARDeliveryPlanBeginDateTo,
                                                                      searchObject.ARDeliveryPlanEndDateFrom,
                                                                      searchObject.ARDeliveryPlanEndDateTo);
            return ds;
        }

        public void ChangeTruckDriver()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = (ARDeliveryPlanTrucksInfo)entity.ARDeliveryPlanTrucksList[entity.ARDeliveryPlanTrucksList.CurrentIndex];
            if (objDeliveryPlanTrucksInfo == null)
                return;
            string employeeName = objEmployeesController.GetObjectNameByID(objDeliveryPlanTrucksInfo.FK_HREmployeeID);
            if (String.IsNullOrEmpty(employeeName))
                return;
            objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckDriver = employeeName;
            entity.DeliveryPlanTruckPointsList.Where(o => o.FK_ICProductTruckID == objDeliveryPlanTrucksInfo.FK_ICProductID).All(o =>
                {
                    o.ARDeliveryPlanTruckPointEmployeeDeliveryName = employeeName;
                    return true;
                });
            entity.DeliveryPlanTruckPointsList.GridControl.RefreshDataSource();
        }

        public void InitRPSummaryDeliveryPlanDayReport(RPSummaryDeliveryPlanDay report)
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)entity.MainObject;
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItemList = objDeliveryPlanItemsController.GetAllDeliveryPlanItemForReportByDeliveryPlanID(mainObject.ARDeliveryPlanID);
            List<int> arrSaleOrderID = deliveryPlanItemList.Select(o => o.FK_ARSaleOrderID).Distinct().ToList();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItemPrintList = new List<ARDeliveryPlanItemsInfo>();
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = new ARDeliveryPlanItemsInfo();
            arrSaleOrderID.ForEach(o =>
            {
                objDeliveryPlanItemsInfo = ToDeliveryPlanItemPrintList(deliveryPlanItemList.Where(o1 => o1.FK_ARSaleOrderID == o).ToList(), o);
                deliveryPlanItemPrintList.Add(objDeliveryPlanItemsInfo);
            });
            report.bsDeliveryPlanItems.DataSource = deliveryPlanItemPrintList;
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDeliveryDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, mainObject.ARDeliveryPlanBeginDate.ToString("dd/MM/yyyy"));
                if (mainObject.ARDeliveryPlanType == DeliveryPlanType.Week.ToString())
                {
                    label.Text = string.Format(@"KẾ HOẠCH GIAO HÀNG TUẦN TỪ NGÀY {0} ĐẾN NGÀY {1}", mainObject.ARDeliveryPlanBeginDate.ToString("dd/MM/yyyy"), mainObject.ARDeliveryPlanEndDate.ToString("dd/MM/yyyy"));
                }
            }
        }

        public ARDeliveryPlanItemsInfo ToDeliveryPlanItemPrintList(List<ARDeliveryPlanItemsInfo> deliveryPlanItemList, int saleOrderID)
        {
            ARDeliveryPlanItemsInfo objDeliveryPlanItemFirstInfo = deliveryPlanItemList.FirstOrDefault();
            if (objDeliveryPlanItemFirstInfo == null)
                objDeliveryPlanItemFirstInfo = new ARDeliveryPlanItemsInfo();
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = new ARDeliveryPlanItemsInfo();
            objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress = objDeliveryPlanItemFirstInfo.ARDeliveryPlanItemAddress;
            objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate = objDeliveryPlanItemFirstInfo.ARDeliveryPlanItemDeliveryDate;
            objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand = string.Join("; ", deliveryPlanItemList.Select(o => o.ARDeliveryPlanItemCommand).Distinct().ToArray());
            objDeliveryPlanItemsInfo.HREmployeeName = objDeliveryPlanItemFirstInfo.HREmployeeName;
            objDeliveryPlanItemsInfo.ACObjectName = objDeliveryPlanItemFirstInfo.ACObjectName;
            objDeliveryPlanItemsInfo.ARSaleOrderNo = objDeliveryPlanItemFirstInfo.ARSaleOrderNo;
            objDeliveryPlanItemsInfo.ARDeliveryPlanDate = objDeliveryPlanItemFirstInfo.ARDeliveryPlanDate;
            objDeliveryPlanItemsInfo.HRProductSummaryCaptionReport = objDeliveryPlanItemFirstInfo.HRProductSummaryCaptionReport;
            objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryActualDate = objDeliveryPlanItemFirstInfo.ARDeliveryPlanItemDeliveryActualDate;
            if (objDeliveryPlanItemFirstInfo.FK_ARProposalID == 0 || string.IsNullOrEmpty(objDeliveryPlanItemsInfo.HRProductSummaryCaptionReport))
            {
                objDeliveryPlanItemsInfo.HRProductSummaryCaptionReport = string.Join(" + ", deliveryPlanItemList.Where(o => o.FK_ARSaleOrderID == saleOrderID).Select(o => o.ARDeliveryPlanItemProductName).ToArray());
            }
            return objDeliveryPlanItemsInfo;
        }

        public void ChangeDeliveryPlanTruckDeliveryEmployee(string deliveryPlanTruckDeliveryEmployeeIDs)
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            if (entity.ARDeliveryPlanTrucksList.CurrentIndex < 0)
                return;
            ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo = entity.ARDeliveryPlanTrucksList[entity.ARDeliveryPlanTrucksList.CurrentIndex];
            objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckDeliveryEmployee = deliveryPlanTruckDeliveryEmployeeIDs;
        }

        public bool CheckDeliveryPlanTruckPointEstimatedHour(ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo, DateTime deliveryPlanTruckPointEstimatedHour)
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPoints = entity.DeliveryPlanTruckPointsList.Where(o => o.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID).ToList();

            if (deliveryPlanTruckPoints.Any(o => o.ARDeliveryPlanTruckPointEstimatedHour.TimeOfDay == deliveryPlanTruckPointEstimatedHour.TimeOfDay))
                return false;
            return true;
        }

        public void AttributionForTruck()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;
            if (entity.ARDeliveryPlanTrucksList.Count <= 0)
            {
                return;
            }
            if (objDeliveryPlansInfo.ARDeliveryPlanFromType == DeliveryPlanFromType.SaleReturn.ToString())
            {
                List<int> saleReturnIDs = entity.ARDeliveryPlanItemsList.Select(o => o.FK_ARSaleReturnID).Distinct().ToList();
                entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    o.SaleReturnIDsList = new List<int>();
                    if (o.DeliveryPlanTruckItemsList == null)
                    {
                        o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                        o.DeliveryPlanTruckItemsList.Invalidate(entity.DeliveryPlanTruckItemsList.Where(x => x.FK_ICProductTruckID == o.FK_ICProductID).ToList());
                    }
                    o.SaleReturnIDsList = o.DeliveryPlanTruckItemsList.Select(x => x.FK_ARSaleReturnID).Distinct().ToList();

                });

                List<ARSaleReturnsInfo> saleReturns = new List<ARSaleReturnsInfo>();
                ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
                ACObjectsController objObjectsController = new ACObjectsController();

                saleReturnIDs.ForEach(o =>
                {
                    ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)objSaleReturnsController.GetObjectByID(o);
                    if (objSaleReturnsInfo != null)
                    {
                        ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objSaleReturnsInfo.FK_ACObjectID, objSaleReturnsInfo.ARObjectType);
                        objSaleReturnsInfo.ACObjectName = objObjectsInfo != null ? objObjectsInfo.ACObjectName : string.Empty;
                        saleReturns.Add(objSaleReturnsInfo);
                    }
                });

                guiSaleReturnToTruck guiSaleReturnToTruck = new guiSaleReturnToTruck(saleReturns, entity.ARDeliveryPlanTrucksList);
                guiSaleReturnToTruck.Module = this;
                guiSaleReturnToTruck.ShowDialog();
                if (guiSaleReturnToTruck.DialogResult != DialogResult.OK)
                    return;
                entity.ARDeliveryPlanTrucksList.ForEach(o =>
                    {
                        o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                        if (o.SaleReturnIDsList == null)
                            o.SaleReturnIDsList = new List<int>();
                        o.SaleReturnIDsList.ForEach(x =>
                            {
                                List<ARDeliveryPlanItemsInfo> deliveryPlanItems = entity.ARDeliveryPlanItemsList.Where(i => i.FK_ARSaleReturnID == x).ToList();
                                if (deliveryPlanItems != null)
                                {
                                    deliveryPlanItems.ForEach(s => o.DeliveryPlanTruckItemsList.Add(ToDeliveryPlanTruckItemsInfo(s, o)));
                                }
                            });
                    });
            }
            else
            {
                List<int> transferIDs = entity.ARDeliveryPlanItemsList.Select(o => o.FK_ICTransferID).Distinct().ToList();
                entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    o.TransferIDsList = new List<int>();
                    if (o.DeliveryPlanTruckItemsList == null)
                    {
                        o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                        o.DeliveryPlanTruckItemsList.Invalidate(entity.DeliveryPlanTruckItemsList.Where(x => x.FK_ICProductTruckID == o.FK_ICProductID).ToList());
                    }
                    o.TransferIDsList = o.DeliveryPlanTruckItemsList.Select(x => x.FK_ICTransferID).Distinct().ToList();

                });

                List<ICTransfersInfo> transfers = new List<ICTransfersInfo>();
                ICTransfersController objTransfersController = new ICTransfersController();
                ACObjectsController objObjectsController = new ACObjectsController();

                transferIDs.ForEach(o =>
                {
                    ICTransfersInfo objTransfersInfo = (ICTransfersInfo)objTransfersController.GetObjectByID(o);
                    if (objTransfersInfo != null)
                    {
                        transfers.Add(objTransfersInfo);
                    }
                });

                guiTransferToTruck guiTransferToTruck = new guiTransferToTruck(transfers, entity.ARDeliveryPlanTrucksList);
                guiTransferToTruck.Module = this;
                guiTransferToTruck.ShowDialog();
                if (guiTransferToTruck.DialogResult != DialogResult.OK)
                    return;
                entity.ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                    if (o.TransferIDsList == null)
                        o.TransferIDsList = new List<int>();
                    o.TransferIDsList.ForEach(x =>
                {
                    List<ARDeliveryPlanItemsInfo> deliveryPlanItems = entity.ARDeliveryPlanItemsList.Where(i => i.FK_ICTransferID == x).ToList();
                    if (deliveryPlanItems != null)
                    {
                        deliveryPlanItems.ForEach(s => o.DeliveryPlanTruckItemsList.Add(ToDeliveryPlanTruckItemsInfo(s, o)));
                    }
                });
                });
            }

            entity.DeliveryPlanTruckItemsList.Clear();
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
            {
                entity.DeliveryPlanTruckItemsList = entity.DeliveryPlanTruckItemsList.Union(o.DeliveryPlanTruckItemsList).ToList();
            });

            entity.ARDeliveryPlanTrucksList.ForEach(o =>
            {
                decimal TotalM3 = o.DeliveryPlanTruckItemsList.Sum(de => (entity.ARDeliveryPlanItemsList.Where(a => a.FK_ICProductID == de.FK_ICProductID).Sum
                               (a => a.ARDeliveryPlanItemProductHeight * a.ARDeliveryPlanItemProductLength * a.ARDeliveryPlanItemProductWidth)) * de.ARDeliveryPlanTruckItemDeliveryQty / 1000000000);

                if (TotalM3 > o.ARDeliveryPlanTruckGrossTon)
                {
                    if (MessageBox.Show(DeliveryPlanLocalizedResources.ConfirmCapacityAttributionItemToTruck, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                        return;
                }
            });
            entity.ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.ARDeliveryPlanTruckTotalQty = o.DeliveryPlanTruckItemsList.Sum(x => x.ARDeliveryPlanTruckItemDeliveryQty);
                o.ARDeliveryPlanTruckTotalM3 = o.DeliveryPlanTruckItemsList.Sum(x => (x.ARDeliveryPlanTruckItemProductHeight * x.ARDeliveryPlanTruckItemProductWidth * x.ARDeliveryPlanTruckItemProductLength) * x.ARDeliveryPlanTruckItemDeliveryQty / 1000000000); // mm3 => m3
                entity.GenarateDeliveryPlanTruckPoints(o.DeliveryPlanTruckItemsList.ToList(), o);
            });
            entity.UpdateDeliveryPlanTruckPoint();
            objDeliveryPlansInfo.ARDeliveryPlanTotalTruck = entity.ARDeliveryPlanTrucksList.Count();
            objDeliveryPlansInfo.ARDeliveryPlanTotalM3 = entity.ARDeliveryPlanTrucksList.Sum(o => o.ARDeliveryPlanTruckTotalM3);
            entity.UpdateMainObjectBindingSource();
            ARDeliveryPlanTrucksGridControl.RefreshDataSource();
            ARDeliveryPlanTruckPointsGridControl.RefreshDataSource();
        }

        public ARDeliveryPlanTruckItemsInfo ToDeliveryPlanTruckItemsInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo, ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            return new ARDeliveryPlanTruckItemsInfo()
            {
                ARDeliveryPlanTruckItemDeliveryQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty,
                FK_ARSaleReturnID = objDeliveryPlanItemsInfo.FK_ARSaleReturnID,
                FK_ICTransferID = objDeliveryPlanItemsInfo.FK_ICTransferID,
                FK_ARSaleReturnItemID = objDeliveryPlanItemsInfo.FK_ARSaleReturnItemID,
                FK_ICTransferItemID = objDeliveryPlanItemsInfo.FK_ICTransferItemID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                ARDeliveryPlanTruckItemProductNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductNo,
                ARDeliveryPlanTruckItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ARDeliveryPlanTruckItemAddress = objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress,
                ARDeliveryPlanTruckItemProductWidth = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductWidth,
                ARDeliveryPlanTruckItemProductHeight = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductHeight,
                ARDeliveryPlanTruckItemProductLength = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductLength,
                FK_ARDeliveryPlanTruckID = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckID,
                FK_ICProductTruckID = objDeliveryPlanTrucksInfo.FK_ICProductID,
            };
        }

        public void ChangeDeliveryPlanBeginDate()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)CurrentModuleEntity.MainObject;
            entity.ARDeliveryPlanItemsList.ForEach(o =>
                {
                    o.ARDeliveryPlanItemDeliveryActualDate = mainObject.ARDeliveryPlanBeginDate;
                });
            entity.ARDeliveryPlanItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeObjectItem()
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = (ARDeliveryPlanItemsInfo)entity.ARDeliveryPlanItemsList[entity.ARDeliveryPlanItemsList.CurrentIndex];
            objDeliveryPlanItemsInfo.ACObjectAccessKey = objDeliveryPlanItemsInfo.ACObjectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objDeliveryPlanItemsInfo.ACObjectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objDeliveryPlanItemsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objDeliveryPlanItemsInfo.ARObjectType = objObjectsInfo.ACObjectType;
                objDeliveryPlanItemsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                entity.ARDeliveryPlanItemsList.GridControl.RefreshDataSource();
            }
        }

        public void ActionValidate()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
                bool isValidated = entity.Validate();
                if (isValidated)
                    InvalidateToolbar();
            }
        }

        public override void ActionPrint()
        {

            if (Toolbar.CurrentObjectID <= 0)
                return;
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)entity.MainObject;
            RPTransferPlan report = new RPTransferPlan();
            InitTransferPlanReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, null, true);
            reviewer.Show();
        }

        public void InitTransferPlanReport(RPTransferPlan report)
        {
            TransferPlanEntities entity = (TransferPlanEntities)CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)entity.MainObject;
            report.bsDeliveryPlanItems.DataSource = entity.ARDeliveryPlanItemsList;
            XRLabel labelDateFromTo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDateFromTo"];
            if (labelDateFromTo != null)
            {
                labelDateFromTo.Text = string.Format(labelDateFromTo.Text,
                                            mainObject.ARDeliveryPlanBeginDate.Day,
                                            mainObject.ARDeliveryPlanBeginDate.Month,
                                            mainObject.ARDeliveryPlanEndDate.Day,
                                            mainObject.ARDeliveryPlanEndDate.Month,
                                            mainObject.ARDeliveryPlanEndDate.Year);
            }

            XRLabel labelEmployee = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEmployee"];
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID);
            if (labelEmployee != null && objEmployeesInfo != null)
            {
                labelEmployee.Text = string.Format(labelEmployee.Text, objEmployeesInfo.HREmployeeName);
            }
        }

        public override void Invalidate(int iObjectID)
        {
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(iObjectID);
            ARDeliveryPlanItemsGridControl.HiddenObjectProperty(objDeliveryPlansInfo.ARDeliveryPlanFromType);
            ARDeliveryPlanItemsGridControl.RefreshDataSource();
            base.Invalidate(iObjectID);
        }
    }
    #endregion
}