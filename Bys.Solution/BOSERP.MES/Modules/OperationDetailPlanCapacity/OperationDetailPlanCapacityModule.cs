using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public class OperationDetailPlanCapacityModule : BaseModuleERP
    {
        #region Constants
        public const string NewNo = "***NEW***";
        public const string MMOperationDetailPlanCapacityItemsGridControlName = "fld_dgcMMOperationDetailPlanCapacityItems";
        public const string ProductLookupEditName = "fld_lkeICProductID";
        public const string SearchFromDateName = "fld_dteFromDate";
        public const string SearchToDateName = "fld_dteToDate";
        public const string ProductForBatchLookUpEditName = "fld_lkeICProductForBatchID";
        #endregion Constants

        #region Private Properties
        public BOSDateEdit SearchFromDateControl;
        public BOSDateEdit SearchToDateControl;
        public MMOperationDetailPlanCapacityItemsGridControl OperationDetailPlanCapacityItemsGridControl;

        public DateTime OperationDetailPlanCapacityFromdate;
        public int OperationDetailPlanCapacityOperationID;
        public string RoutType = RoutingType.ByBatchProduct.ToString();
        BOSLookupEdit ProductLookupEdit;
        BOSLookupEdit ProductForBatchLookupEdit;
        public List<MMBatchProductProductionNormItemProcesssInfo> CurrentProcessOperationList = null;
        public List<ICProductsInfo> ProductDetailPlanList = null;
        #endregion Private Properties

        #region Public methods

        public OperationDetailPlanCapacityModule()
        {
            Name = "OperationDetailPlanCapacity";
            CurrentModuleEntity = new OperationDetailPlanCapacityEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            OperationDetailPlanCapacityItemsGridControl = (MMOperationDetailPlanCapacityItemsGridControl)Controls[OperationDetailPlanCapacityModule.MMOperationDetailPlanCapacityItemsGridControlName];
            InvalidateToolbar();

            ProductLookupEdit = (BOSLookupEdit)Controls[ProductLookupEditName];

            SearchFromDateControl = (BOSDateEdit)Controls[SearchFromDateName];
            if (SearchFromDateControl != null)
            {
                SearchFromDateControl.DateTime = BOSUtil.GetMonthBeginDate();
            }

            SearchToDateControl = (BOSDateEdit)Controls[SearchToDateName];
            if (SearchToDateControl != null)
            {
                SearchToDateControl.DateTime = BOSUtil.GetMonthEndDate();
            }

            CurrentProcessOperationList = new List<MMBatchProductProductionNormItemProcesssInfo>();

            ProductForBatchLookupEdit = (BOSLookupEdit)Controls[ProductForBatchLookUpEditName];
            ProductForBatchLookupEdit.ShowPopup();
            ProductForBatchLookupEdit.ClosePopup();

            ProductDetailPlanList = new List<ICProductsInfo>();
            ProductLookupEdit.ShowPopup();
            ProductLookupEdit.ClosePopup();
        }

        public void ReloadProductLookupDataSource(int batchProductID, int operationID)
        {
            ProductDetailPlanList = new List<ICProductsInfo>();

            bool isOperationSyncProductCheck = IsOperationSyncProductCheck(operationID);

            ICProductsController pController = new ICProductsController();
            ProductDetailPlanList = pController.GetProductForCapacityByBatchProductIDAndOperationID(batchProductID, operationID, isOperationSyncProductCheck);

            if (isOperationSyncProductCheck)
            {
                List<int> parentIDList = ProductDetailPlanList.Select(t => t.FK_ICProductForBatchID).Distinct().ToList();

                List<ICProductsInfo> parentProductList = new List<ICProductsInfo>();
                ICProductsInfo product;
                ICProductsForViewInfo filterProduct;
                foreach (int parentID in parentIDList)
                {
                    filterProduct = BOSApp.CurrentProductList.FirstOrDefault(t => t.ICProductID == parentID);
                    if (filterProduct != null)
                    {
                        product = new ICProductsInfo();
                        product.ICProductID = parentID;
                        product.ICProductNo = filterProduct.ICProductNo;
                        product.ICProductDesc = filterProduct.ICProductDesc;
                        parentProductList.Add(product);
                    }
                }

                ProductForBatchLookupEdit.Properties.DataSource = parentProductList;
                ProductForBatchLookupEdit.EditValue = null;
                ProductForBatchLookupEdit.Enabled = true;


                ProductLookupEdit.Properties.DataSource = null;
                ProductLookupEdit.EditValue = null;
            }
            else
            {
                ProductForBatchLookupEdit.Properties.DataSource = null;
                ProductForBatchLookupEdit.EditValue = null;
                ProductForBatchLookupEdit.Enabled = false;

                ProductLookupEdit.Properties.DataSource = ProductDetailPlanList;
                ProductLookupEdit.EditValue = null;
            }
        }

        public void ChangeProductForBatch(int productForBatchID)
        {
            if (ProductDetailPlanList == null)
            {
                ProductDetailPlanList = new List<ICProductsInfo>();
            }

            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            productList = ProductDetailPlanList.Where(t => t.FK_ICProductForBatchID == productForBatchID).ToList();

            ProductLookupEdit.Properties.DataSource = productList;
            ProductLookupEdit.EditValue = null;

        }



        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            // loại theo dõi năng suất
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("RoutingType");
            if (ds != null && ds.Tables.Count > 0)
                RoutType = ds.Tables[0].Rows[0]["Value"].ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        public void ViewOperationDetailPlanCapacity(int FK_MMBatchProductID,
            int FK_ARSaleOrderID,
            int FK_MMOperationDetailPlanID,
            int FK_MMBatchProductItemID,
            int FK_MMWorkShopID,
            int FK_MMLineID,
            string BarcodeID,
            int FK_ICProductID,
            DateTime FromDate,
            DateTime ToDate,
            int FK_MMOperationID)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacityItemsController objCapacityItemsController = new MMOperationDetailPlanCapacityItemsController();

            List<MMOperationDetailPlanCapacityItemsInfo> ListItemCapacity = objCapacityItemsController.GetOperationDetailPlanCapacityItemBySomeCriteria(
                FK_MMBatchProductID,
                FK_ARSaleOrderID,
                FK_MMOperationDetailPlanID,
                FK_MMBatchProductItemID,
                FK_MMWorkShopID,
                FK_MMLineID,
                BarcodeID,
                FK_ICProductID,
                FromDate,
                ToDate,
                FK_MMOperationID);

            entity.OperationDetailPlanCapacityItemsList.Invalidate(ListItemCapacity);
            GridView view = entity.OperationDetailPlanCapacityItemsList.GridControl.MainView as GridView;
            view.BestFitColumns();

        }
        public void OperationDetailPlaCapacityItemValidateControl(MMOperationDetailPlanCapacityItemsInfo item)
        {
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            BOSLookupEdit SaleOrderLookupEdit = (BOSLookupEdit)Controls["fld_lkeARSaleOrderID"];
            BOSTextBox BarcodeEdit = (BOSTextBox)Controls["fld_txtBarcodeID"];
            if (SaleOrderLookupEdit != null)
                SaleOrderLookupEdit.EditValue = item.FK_ARSaleOrderID;

            if (BarcodeEdit != null)
            {
                BarcodeEdit.Text = item.MMOperationDetailPlanItemChildBarcode.ToString().PadLeft(2, '0');
            }
            BOSLookupEdit OperationDetailPlanLookupEdit = (BOSLookupEdit)Controls["fld_lkeMMOperationDetailPlanID"];
            BOSLookupEdit WorkShopLookupEdit = (BOSLookupEdit)Controls["fld_lkeFK_MMWorkShopID"];
            BOSLookupEdit LineLookupEdit = (BOSLookupEdit)Controls["fld_lkeFK_MMLineID"];
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = objOperationDetailPlansController.GetOperationDetailPlanByItemPlanID(item.FK_MMOperationDetailPlanItemID);
            if (objOperationDetailPlansInfo != null)
            {
                if (OperationDetailPlanLookupEdit != null)
                {
                    OperationDetailPlanLookupEdit.EditValue = objOperationDetailPlansInfo.MMOperationDetailPlanID;
                    item.FK_MMOperationDetailPlanID = objOperationDetailPlansInfo.MMOperationDetailPlanID;
                }
                if (WorkShopLookupEdit != null)
                    WorkShopLookupEdit.EditValue = objOperationDetailPlansInfo.FK_MMWorkShopID;
                if (LineLookupEdit != null)
                    LineLookupEdit.EditValue = objOperationDetailPlansInfo.FK_MMWorkShopID;
            }
            BOSDateEdit fromdate = (BOSDateEdit)Controls["fld_dteSearchFromDate"];
            if (fromdate != null) item.FromDate = fromdate.DateTime;
            BOSDateEdit todate = (BOSDateEdit)Controls["fld_dteSearchToDate"];
            if (todate != null) item.ToDate = todate.DateTime;
        }

        public override int ActionSave()
        {
            return base.ActionSave();
        }

        /// <summary>
        /// Delete item from OperationDetailPlanCapacity item list
        /// </summary>


        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
        }

        public void ActionNewFromDetailPlan()
        {
            if (GetPlanInfo())
                ShowBacthOperationDetailPlan();
        }

        public void ShowBacthOperationDetailPlan()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacitysInfo objOperationDetailPlanCapacitysInfo = (MMOperationDetailPlanCapacitysInfo)CurrentModuleEntity.MainObject;

            MMOperationDetailPlanItemChildsController objOperationDetailPlanItemController = new MMOperationDetailPlanItemChildsController();

            List<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemList = new List<MMOperationDetailPlanItemChildsInfo>();

            MMBatchProductProductionNormItemsController productionNormItemController = new MMBatchProductProductionNormItemsController();

            OperationDetailPlanItemList = objOperationDetailPlanItemController.GetOperationDetailPlanItemChildCapacityRemain(OperationDetailPlanCapacityOperationID);


            entity.OperationDetailPlanItemChildsList.Invalidate(OperationDetailPlanItemList);

            guiChooseOperationDetailPlanItemOperation guiChooseOperationDetailPlanItemOperation = new guiChooseOperationDetailPlanItemOperation();
            guiChooseOperationDetailPlanItemOperation.Module = this;
            guiChooseOperationDetailPlanItemOperation.ShowDialog();
            if (guiChooseOperationDetailPlanItemOperation.DialogResult == DialogResult.OK)
            {
                List<MMOperationDetailPlanItemChildsInfo> CheckList = new List<MMOperationDetailPlanItemChildsInfo>();
                List<MMOperationDetailPlanItemChildsInfo> SelectedOperationDetailPlanItemList = new List<MMOperationDetailPlanItemChildsInfo>();
                SelectedOperationDetailPlanItemList = entity.OperationDetailPlanItemChildsList.Where(e => e.Selected == true).ToList();

                #region Main Object
                #endregion

                #region Module Object
                if (SelectedOperationDetailPlanItemList != null && SelectedOperationDetailPlanItemList.Count > 0)
                {
                    entity.OperationDetailPlanCapacityItemsList.Clear();
                    foreach (MMOperationDetailPlanItemChildsInfo item in SelectedOperationDetailPlanItemList)
                    {
                        MMOperationDetailPlanCapacityItemsInfo objCapacity = new MMOperationDetailPlanCapacityItemsInfo();
                        BOSUtil.CopyObject(item, objCapacity);
                        objCapacity.MMOperationDetailPlanCapacityItemCompletedProductQty = item.MMOperationDetailPlanItemChildRemainProductQty;
                        objCapacity.FK_MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                        objCapacity.MMOperationDetailPlanItemChildBarcode = item.MMOperationDetailPlanItemChildBarcode;
                        objCapacity.MMOperationDetailPlanCapacityItemDate = DateTime.Now;
                        entity.OperationDetailPlanCapacityItemsList.Add(objCapacity);
                    }
                    entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
                }
                #endregion
            }
            else
                ActionCancel();
        }

        /// <summary>
        /// Get info for plan
        /// </summary>
        public bool GetPlanInfo()
        {
            //Default load all info 
            guiOperationPlanInfo guiOperationPlanInfo = new guiOperationPlanInfo();
            guiOperationPlanInfo.Module = this;
            guiOperationPlanInfo.ShowDialog();
            if (guiOperationPlanInfo.DialogResult == DialogResult.OK)
            {
                OperationDetailPlanCapacityOperationID = guiOperationPlanInfo.OperationDetailPlanCapacityOperationID;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Check all proposal item
        /// </summary>
        /// <param name="isChecked">Check all or not</param>
        public void CheckAllOperationDetailPlanItemOperations(bool isChecked)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            foreach (MMOperationDetailPlanItemChildsInfo objOperationDetailPlanItemsInfo in entity.OperationDetailPlanItemChildsList)
            {
                objOperationDetailPlanItemsInfo.Selected = isChecked;
            }
            entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
        }
        /// <summary>
        /// Check whether the selected proposal items is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        public bool CheckSelectedOperationDetailPlanItemOperations()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            IList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemOperations = entity.OperationDetailPlanItemChildsList.Where(OperationDetailPlanItemOperation => OperationDetailPlanItemOperation.Selected == true).ToList();
            if (OperationDetailPlanItemOperations.Count == 0)
            {
                MessageBox.Show(OperationDetailPlanCapacityLocalizedResources.ChooseBatchProductItemOperationsMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public override void ActionNew()
        {
            base.ActionNew();
        }

        /// <summary>
        /// Add items to be checked to purchase proposal item list
        /// </summary>
        public void AddCheckedItemsToOperationDetailPlanCapacityItemList(int barcode)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacityItemsInfo objOperationDetailPlanCapacitysInfo = (MMOperationDetailPlanCapacityItemsInfo)entity.ModuleObjects[TableName.MMOperationDetailPlanCapacityItemsTableName].Clone();
            entity.OperationDetailPlanCapacityItemsList.AddObjectToList();
        }
        public void SaveOperationDetailPlanCapacityList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            if (entity.OperationDetailPlanCapacityItemsList.Count > 0)
            {
                bool result = true;
                #region Kiểm tra nhập kho CD trước
                string mess = "Kiểm tra nhập kho CD trước.";
                string messError = string.Empty;
                BOSProgressBar.Start(mess);
                MMOperationsController objOperationsController = new MMOperationsController();
                List<MMOperationsInfo> operationList = objOperationsController.GetAliveOperationAndSortOrder();
                operationList = operationList.Where(o => o.MMOperationGroup == "Product").ToList();
                MMOperationDetailPlanItemChildsController objOperationDetailPlanItemChildsController = new MMOperationDetailPlanItemChildsController();
                MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
                MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();

                List<string> batchItemID = entity.OperationDetailPlanCapacityItemsList.Select(o => o.FK_MMBatchProductItemID.ToString()).Distinct().ToList();
                if (batchItemID != null)
                {
                    List<MMBatchProductItemOperationInfosInfo> listProcess = objBatchProductItemOperationInfosController.GetOperationProcesssByListBatchProductItem(string.Join(",", batchItemID.ToArray()));

                    List<MMOperationDetailPlanItemChildsInfo> ReceiptList = objOperationDetailPlanItemChildsController.GetItemOperationDetailPlanItemChildReceipt(string.Join(",", batchItemID.ToArray()));
                    List<MMBatchProductProductionNormItemsInfo> bppniList = objBPPNIsController.GetItemByBatchProductItemList(string.Join(",", batchItemID.ToArray()));

                    MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                    MMOperationsInfo objOperationsParent = new MMOperationsInfo();
                    MMOperationsInfo objOperationsPrev = new MMOperationsInfo();
                    foreach (MMOperationDetailPlanCapacityItemsInfo item in entity.OperationDetailPlanCapacityItemsList)
                    {
                        int preOperation = 0;
                        objOperationsInfo = operationList.Where(o => o.MMOperationID == item.FK_MMOperationID).FirstOrDefault();
                        if (objOperationsInfo != null && objOperationsInfo.MMOperationID > 0)
                            objOperationsParent = operationList.Where(o => o.MMOperationID == objOperationsInfo.MMOperationParentID && o.MMOperationInOutStockCheck).FirstOrDefault();
                        if (listProcess != null && operationList != null)
                        {
                            preOperation = GetPrevStockOperation(item.FK_MMOperationID, item.FK_MMBatchProductProductionNormItemID, operationList, listProcess);

                        }
                        if (ReceiptList != null && preOperation > 0)
                        {
                            objOperationsPrev = operationList.Where(o => o.MMOperationID == preOperation).FirstOrDefault();
                            if (ReceiptList != null)
                            {
                                decimal ReceiptQty = 0;
                                MMBatchProductItemOperationInfosInfo Prevprocess = listProcess.Where(x => x.FK_MMOperationID == preOperation
                                    && item.FK_MMBatchProductProductionNormItemID == x.FK_MMBatchProductProductionNormItemID).FirstOrDefault();
                                //CD trước và sau có cùng quy trình SX
                                if (Prevprocess != null && Prevprocess.FK_MMBatchProductProductionNormItemID > 0)
                                {
                                    ReceiptQty = ReceiptList.Where(r => r.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                            && r.FK_MMOperationID == preOperation
                                                                            && r.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID).Sum(r => r.SLNhap);
                                }
                                else
                                {
                                    if (bppniList != null)
                                    {
                                        List<MMBatchProductProductionNormItemsInfo> bppniListPrev
                                                = bppniList.Where(x => x.MMBatchProductProductionNormItemParentID == item.FK_MMBatchProductProductionNormItemID).ToList();

                                        if (bppniListPrev != null)
                                        {
                                            ReceiptQty = decimal.MaxValue;
                                            foreach (MMBatchProductProductionNormItemsInfo itemBppn in bppniListPrev)
                                            {
                                                itemBppn.SLNhap = ReceiptList.Where(r => r.FK_MMOperationID == preOperation
                                                                               && r.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                                               && r.FK_MMBatchProductProductionNormItemID == itemBppn.MMBatchProductProductionNormItemID).Sum(r => r.SLNhap);
                                                decimal SLDongbo = (itemBppn.SLNhap / itemBppn.MMBatchProductProductionNormItemQuantity) * item.MMOperationDetailPlanCapacityItemTotalProductQty;

                                                ReceiptQty = Math.Floor(Math.Min(SLDongbo, ReceiptQty));
                                            }
                                        }
                                    }
                                }
                                if (ReceiptQty < item.MMOperationDetailPlanCapacityItemCompletedProductQty)
                                {
                                    item.IsError = true;
                                    item.MMOperationDetailPlanCapacityItemCanReceipt = ReceiptQty;
                                    messError = "Số lượng lớn hơn số lượng có thể nhập";
                                    result = false;
                                }
                            }
                        }
                    }

                }
                BOSProgressBar.Close();
                #endregion
                if (result)
                {
                    entity.OperationDetailPlanCapacityItemsList.SaveItemCDObjects();
                    MessageBox.Show("Lưu thành công!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(messError, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
            }
        }

        public int GetPrevStockOperation(int operationID, int bppnItemID, List<MMOperationsInfo> operationList, List<MMBatchProductItemOperationInfosInfo> listProcess)
        {
            int result = 0;

            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMBatchProductItemOperationInfosInfo objBatchProductItemOperationInfosInfo =
                    listProcess.Where(p => p.FK_MMBatchProductProductionNormItemID == bppnItemID && p.FK_MMOperationID == operationID).FirstOrDefault();
            if (listProcess != null)
            {

                if (objBatchProductItemOperationInfosInfo != null)
                {
                    MMBatchProductItemOperationInfosInfo objPrevStockOperation = listProcess.Where(p => p.FK_MMBatchProductProductionNormItemID == bppnItemID
                        && p.MMOperationInOutStockCheck
                        && p.MMBatchProductItemOperationInfoPeriod < objBatchProductItemOperationInfosInfo.MMBatchProductItemOperationInfoPeriod).FirstOrDefault();

                    if (objPrevStockOperation != null && objPrevStockOperation.FK_MMOperationID > 0)
                        result = objPrevStockOperation.FK_MMOperationID;
                }
            }

            if (operationList != null && result == 0)
            {
                MMOperationsInfo objPrevOperationsInfo = new MMOperationsInfo();
                objOperationsInfo = operationList.Where(o => o.MMOperationID == operationID).FirstOrDefault();
                if (objOperationsInfo != null && objOperationsInfo.MMOperationInOutStockCheck)
                {
                    objPrevOperationsInfo = operationList.OrderByDescending(o => o.MMOperationPeriodOrder).Where(x => x.MMOperationInOutStockCheck
                        && x.MMOperationPeriodOrder < objOperationsInfo.MMOperationPeriodOrder).FirstOrDefault();
                    if (objPrevOperationsInfo != null && objPrevOperationsInfo.MMOperationID > 0)
                        result = objPrevOperationsInfo.MMOperationID;

                }
                else if (objOperationsInfo != null && !objOperationsInfo.MMOperationInOutStockCheck)
                {
                    MMOperationsInfo objParentInfo = operationList.Where(o => o.MMOperationID == objOperationsInfo.MMOperationParentID).FirstOrDefault();
                    if (objParentInfo != null && objParentInfo.MMOperationInOutStockCheck)
                    {
                        objPrevOperationsInfo = operationList.OrderByDescending(o => o.MMOperationPeriodOrder).Where(x => x.MMOperationInOutStockCheck
                        && x.MMOperationPeriodOrder < objParentInfo.MMOperationPeriodOrder).FirstOrDefault();

                        if (objPrevOperationsInfo != null)
                        {
                            result = objPrevOperationsInfo.MMOperationID;
                        }
                    }
                }
            }

            return result;
        }
        public void ChangeOperationDetailPlanCapacityList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            entity.OperationDetailPlanCapacityItemsList.ChangeObjectFromList();
        }
        public void RemoveOperationDetailPlanCapacityList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            if (entity.OperationDetailPlanCapacityItemsList.CurrentIndex > 0)
            {
                MMOperationDetailPlanCapacityItemsInfo item = entity.OperationDetailPlanCapacityItemsList[entity.OperationDetailPlanCapacityItemsList.CurrentIndex];
                if (item != null)
                {
                    DeleteItemFromOperationDetailPlanCapacityItemList(item);
                }
            }
        }
        public void ClearOperationDetailPlanCapacityList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            entity.OperationDetailPlanCapacityItemsList.Invalidate(new List<MMOperationDetailPlanCapacityItemsInfo>());
            entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
        }
        public bool OperationDetailPlaCapacityItemCellValueChanged(MMOperationDetailPlanCapacityItemsInfo objOperationDetailPlanCapacityItemsInfo)
        {
            bool result = true;

            MMOperationDetailPlanCapacityItemsController OperationDetailPlanCapacityItemsController = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> OperationDetailPlanCapacityItemList =
                OperationDetailPlanCapacityItemsController.GetItemByOperationDetailPlanItemChildIDExcludeCurrentItemID(objOperationDetailPlanCapacityItemsInfo.FK_MMOperationDetailPlanItemChildID
                                                                                                                       , objOperationDetailPlanCapacityItemsInfo.MMOperationDetailPlanCapacityItemID
                                                                                                                       , objOperationDetailPlanCapacityItemsInfo.FK_MMOperationID);

            decimal completedQty = 0;
            if (OperationDetailPlanCapacityItemList != null && OperationDetailPlanCapacityItemList.Count > 0)
            {
                completedQty = OperationDetailPlanCapacityItemList.Sum(t => t.MMOperationDetailPlanCapacityItemCompletedProductQty);
            }
            decimal canCapacityQty = objOperationDetailPlanCapacityItemsInfo.MMOperationDetailPlanCapacityItemPlanProductQty
                                    - completedQty;
            string mess = string.Empty;
            if (objOperationDetailPlanCapacityItemsInfo.MMOperationDetailPlanCapacityItemCompletedProductQty > canCapacityQty)
            {
                mess = "Số lượng đã sản xuất không được lớn hơn Số lượng đã hoạch định.";
                objOperationDetailPlanCapacityItemsInfo.IsError = false;
                result = false;

            }
            if (mess != string.Empty)
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

        /// <summary>
        /// Get config text by group and value
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public override void ActionPrint()
        {
            base.ActionPrint();
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            if (Toolbar.IsEditAction() || Toolbar.IsNewAction())
            {
                return;
            }
        }

        public List<ICProductAttributesInfo> GetProductItemAttributeTTMT()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.TTMT.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;

        }

        public List<MMBatchProductsInfo> GetBatchProductDataSource(int saleOrderID)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = new List<MMBatchProductsInfo>();
            batchProductList = objBatchProductsController.GetBySaleOrderID(saleOrderID);
            if (batchProductList != null)
                batchProductList.Insert(0, new MMBatchProductsInfo());
            return batchProductList;
        }

        public List<ICProductsInfo> GetBatchProductItemListByBatchProduct(int batchProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            productList = objProductsController.GetProductByBatchProductID(batchProductID);
            if (productList != null)
                productList.Insert(0, objProductsInfo);
            return productList;
        }
        public List<MMOperationDetailPlansInfo> GetOperationDetailPlanDataSource(int? operationID, int? BatchProductID, int? BatchProductItemID)
        {
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            DataSet OperationDetailPlanList = new DataSet();
            OperationDetailPlanList = objOperationDetailPlansController.GetOperationDetailPlanForReceiptByOperationIDAndBatchProductID(operationID,
                                                                                                                                       BatchProductID,
                                                                                                                                       BatchProductItemID);
            List<MMOperationDetailPlansInfo> OPlanList = (List<MMOperationDetailPlansInfo>)objOperationDetailPlansController.GetListFromDataSet(OperationDetailPlanList);

            OperationDetailPlanList.Dispose();
            if (OPlanList != null)
                OPlanList.Insert(0, new MMOperationDetailPlansInfo());

            return OPlanList;
        }
        public MMOperationDetailPlansInfo ChangeOperationDetailPlan(int OperationDetailPlanID)
        {
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            return (MMOperationDetailPlansInfo)objOperationDetailPlansController.GetObjectByID(OperationDetailPlanID);

        }
        public List<MMOperationDetailPlanItemChildsInfo> GetDetailPlanItemChildDataSource(int OperationDetailPlanID, int operationID, int BatchProductID, int BatchProductItemID)
        {
            MMOperationDetailPlanItemChildsController objOperationDetailPlansController = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> DetailPlanItemList = new List<MMOperationDetailPlanItemChildsInfo>();
            DetailPlanItemList = objOperationDetailPlansController.GetItemByOperationDetailPlan(OperationDetailPlanID, operationID,
                                                                                                                                       BatchProductID,
                                                                                                                                       BatchProductItemID);

            if (DetailPlanItemList != null)
                DetailPlanItemList.Insert(0, new MMOperationDetailPlanItemChildsInfo());

            return DetailPlanItemList;
        }

        public DataSet ChangeWorkShop(int workShopID)
        {
            DataSet ds = new DataSet();

            MMLinesController objLinesController = new MMLinesController();
            if (workShopID > 0)
            {
                ds = objLinesController.GetAllDataByForeignColumn("FK_MMWorkShopID", workShopID);
            }
            else
            {
                ds = objLinesController.GetAllObjects();
            }

            return ds;
        }
        public void ChangeOperation(int operation)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            if (entity.OperationDetailPlanCapacityItemsList != null)
            {
                foreach (MMOperationDetailPlanCapacityItemsInfo item in entity.OperationDetailPlanCapacityItemsList)
                {
                    item.FK_MMOperationID = operation;
                }
            }
        }
        public override void ActionDelete()
        {
            MMOperationDetailPlanCapacityItemsController objOperationDetailPlanCapacitysController = new MMOperationDetailPlanCapacityItemsController();
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacitysInfo objOperationDetailPlanCapacitysInfo = (MMOperationDetailPlanCapacitysInfo)entity.MainObject;
            if (objOperationDetailPlanCapacitysInfo.MMOperationDetailPlanCapacityID > 0)
                objOperationDetailPlanCapacitysController.DeleteByForeignColumn("FK_MMOperationDetailPlanCapacityID", objOperationDetailPlanCapacitysInfo.MMOperationDetailPlanCapacityID);
            base.ActionDelete();
        }

        public List<MMOperationsInfo> ReloadOperationLookupDataSource(int batchProductID)
        {
            MMBatchProductProductionNormItemProcesssController pCtrl
                = new MMBatchProductProductionNormItemProcesssController();

            CurrentProcessOperationList = pCtrl.GetProcessOperationByBatchProductIDForCapacity(batchProductID);

            MMOperationsController oCtrl = new MMOperationsController();
            List<MMOperationsInfo> oList = oCtrl.GetForCapacityByBatchProductID(batchProductID);

            return oList;
        }



        public void AddItemCapacity(int productID, int batchProductID, int operationID, int empGiveID, int empTakeID, int empQCID, DateTime date, decimal qty, int workShopID, int lineID, string productName, bool isBeginOperation, bool hasReceipt, bool defaultByProcess, int productForBatchID)
        {
            HREmployeesController empController = new HREmployeesController();
            HREmployeesInfo empGive = (HREmployeesInfo)empController.GetObjectByID(empGiveID);

            if (empGive == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn Người giao");
                return;
            }

            HREmployeesInfo empTake = (HREmployeesInfo)empController.GetObjectByID(empTakeID);

            if (empTake == null)
            {
                //BOSApp.ShowMessage("Vui lòng chọn Người nhận");
                //return;
            }

            if (empGive.FK_HRDepartmentRoomGroupItemID == 0)
            {
                BOSApp.ShowMessage("Vui lòng xác định Tổ của Người giao");
                return;
            }


            if (empTake != null && empTake.FK_HRDepartmentRoomGroupItemID == 0)
            {
                BOSApp.ShowMessage("Vui lòng xác định Tổ của Người nhận");
                return;
            }

            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;

            MMOperationDetailPlanCapacityItemsInfo item = new MMOperationDetailPlanCapacityItemsInfo();
            item.FK_ICProductID = productID;
            item.FK_MMBatchProductID = batchProductID;
            item.FK_MMOperationID = operationID;
            item.FK_HREmployeeGiveID = empGiveID;
            item.FK_HRDepartmentRoomGroupItemID = empGive.FK_HRDepartmentRoomGroupItemID;
            item.FK_HREmployeeTakeID = empTakeID;
            item.FK_HRToDepartmentRoomGroupItemID = (empTake == null) ? 0 : empTake.FK_HRDepartmentRoomGroupItemID;
            item.FK_HREmployeeQCID = empQCID;
            item.MMOperationDetailPlanCapacityItemDate = date;
            item.MMOperationDetailPlanCapacityItemProductQty = qty;
            item.FK_MMWorkShopID = workShopID;
            item.FK_MMLineID = lineID;
            item.MMOperationDetailPlanCapacityItemProductName = productName;
            //item.FK_MMToOperationID = toOperationID;
            if (defaultByProcess)
            {
                MMBatchProductProductionNormItemProcesssInfo process
                     = CurrentProcessOperationList.FirstOrDefault(t => t.FK_MMOperationID == operationID
                                                                    && t.FK_ICProductID == productID);
                if (process != null)
                {
                    item.MMOperationDetailPlanCapacityItemIsBeginOperation = process.MMBatchProductProductionNormItemProcessIsBeginOperation;
                    item.MMOperationDetailPlanCapacityItemHasReceipt = process.MMBatchProductProductionNormItemProcessInOutStockCheck;
                }
            }
            else
            {
                item.MMOperationDetailPlanCapacityItemIsBeginOperation = isBeginOperation;
                item.MMOperationDetailPlanCapacityItemHasReceipt = hasReceipt;
            }

            if (productForBatchID > 0)
            {
                item.FK_ICProductForBatchID = productForBatchID;
                ICProductsForViewInfo productForBatch = BOSApp.CurrentProductList.FirstOrDefault(t => t.ICProductID == productForBatchID);
                if (productForBatch != null)
                {
                    item.MMOperationDetailPlanCapacityItemParentProductDesc = productForBatch.ICProductDesc;
                    item.MMOperationDetailPlanCapacityItemParentProductName = productForBatch.ICProductName;
                }
            }

            entity.OperationDetailPlanCapacityItemsList.Add(item);
            entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
        }

        public void SearchItemCapacity(DateTime fromDate, DateTime toDate, int productID, int batchProductID, int operationID, int empGiveID, int empTakeID, int empQCID, int productForBatchID)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;

            if (entity.OperationDetailPlanCapacityItemsList.Count > 0)
            {
                DialogResult saveCheck = BOSApp.ShowMessageYesNo(string.Format("{0}{1}{2}", "Bạn có muốn lưu lại năng suất thực hiện hiện tại trước khi tìm kiếm không?", Environment.NewLine, "Việc tìm kiếm sẽ làm mất các thông tin đang chỉnh sửa (nếu có) nếu không được lưu!"));

                if (saveCheck == DialogResult.Yes)
                {
                    if (!SaveItem())
                    {
                        return;
                    }
                }
            }

            MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> capacityList = capacityCtrl.SearchItemBySomeConditions(fromDate, toDate, productID, batchProductID, operationID, empGiveID, empTakeID, empQCID, productForBatchID);

            entity.OperationDetailPlanCapacityItemsList.Invalidate(capacityList);
            entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
        }
        public void SearchJobTicketCapacity(int OperationDetailPlanItemChildID, DateTime date, int FK_HRDepartmentRoomGroupItemID)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            MMOperationDetailPlanItemChildsController planDetailController = new MMOperationDetailPlanItemChildsController();
            //Getdata
            MMOperationDetailPlanItemChildsInfo planDetailInfo = (MMOperationDetailPlanItemChildsInfo)planDetailController.GetObjectByID(OperationDetailPlanItemChildID);
            ICProductsController pController = new ICProductsController();
            List<ICProductsInfo> pList = pController.GetProductForCapacityByJobTicketDetailPlan(OperationDetailPlanItemChildID);
            List<MMOperationDetailPlanCapacityItemsInfo> DataList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            foreach (ICProductsInfo item in pList)
            {
                MMOperationDetailPlanCapacityItemsInfo objODInfo = new MMOperationDetailPlanCapacityItemsInfo();
                objODInfo.FK_ICProductID = item.ICProductID;
                objODInfo.MMOperationDetailPlanCapacityItemProductName = item.ICProductName;
                objODInfo.FK_MMLineID = item.FK_MMLineID;
                objODInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                objODInfo.FK_MMBatchProductID = planDetailInfo != null ? planDetailInfo.FK_MMBatchProductID : 0;
                objODInfo.FK_MMOperationID = planDetailInfo != null ? planDetailInfo.FK_MMOperationID : 0;
                objODInfo.MMOperationDetailPlanCapacityItemDate = date;
                objODInfo.MMOperationDetailPlanCapacityItemProductQty = 0;
                //if (fld_ckeDefaultByProcess.Checked)
                //{
                //    MMBatchProductProductionNormItemProcesssInfo process
                //         = ((OperationDetailPlanCapacityModule)Module).CurrentProcessOperationList.FirstOrDefault(t => t.FK_MMOperationID == OperationID
                //                                                        && t.FK_ICProductID == item.ICProductID);
                //    if (process != null)
                //    {
                //        objODInfo.MMOperationDetailPlanCapacityItemIsBeginOperation = process.MMBatchProductProductionNormItemProcessIsBeginOperation;
                //        objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = process.MMBatchProductProductionNormItemProcessInOutStockCheck;
                //    }
                //}
                //else
                //{
                //    objODInfo.MMOperationDetailPlanCapacityItemIsBeginOperation = fld_ckeBeginOperation.Checked;
                //    objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = fld_ckeHasReceipt.Checked;
                //}

                objODInfo.MMOperationDetailPlanCapacityItemParentProductDesc = item.ICProductParentDesc;
                objODInfo.MMOperationDetailPlanCapacityItemParentProductName = item.ICProductParentName;
                objODInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                DataList.Add(objODInfo);


            }
        }

        public string GetIDString(List<MMOperationDetailPlanCapacityItemsInfo> lst)
        {
            string idString = string.Empty;

            lst.ForEach(t =>
            {
                if (t.MMOperationDetailPlanCapacityItemID > 0)
                {
                    if (!string.IsNullOrEmpty(idString))
                    {
                        idString += ",";
                    }
                    idString += t.MMOperationDetailPlanCapacityItemID.ToString();
                }
            });

            return idString;
        }

        public List<MMOperationsInfo> GetOperationList()
        {
            MMOperationsController oCtrl = new MMOperationsController();
            List<MMOperationsInfo> operationList = oCtrl.GetAllAliveOperation();


            return operationList;
        }

        public List<int> GetDeleteIDList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;

            List<int> deleteIDList = new List<int>();

            if (entity.OperationDetailPlanCapacityItemsList.BackupList != null
                && entity.OperationDetailPlanCapacityItemsList.BackupList.Any())
            {
                List<int> currentIDList = entity.OperationDetailPlanCapacityItemsList.Select(t => t.MMOperationDetailPlanCapacityItemID).Distinct().ToList();
                List<int> backUpIDList = entity.OperationDetailPlanCapacityItemsList.BackupList.Select(t => t.MMOperationDetailPlanCapacityItemID).Distinct().ToList();


                backUpIDList.ForEach(t =>
                {
                    if (t > 0
                        && !currentIDList.Contains(t))
                    {
                        deleteIDList.Add(t);
                    }
                });
            }

            return deleteIDList;
        }

        public bool CheckCanCapacityQty()
        {
            bool isValid = true;
            MMBatchProductsController bpCtrl = new MMBatchProductsController();
            List<MMBatchProductsInfo> bpList = bpCtrl.GetAllObject();
            MMBatchProductsInfo bp;

            ICReceiptItemErrorsController errorCtrl = new ICReceiptItemErrorsController();
            List<ICReceiptItemErrorsInfo> errorList;

            ICProductItemsController productItemCtrl = new ICProductItemsController();
            List<ICProductItemsInfo> productItemList;

            List<ICProductItemsInfo> structureList;

            MMOperationsController operationCtrl = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationCtrl.GetOperationWithReference();

            MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> allItem;
            List<MMOperationDetailPlanCapacityItemsInfo> curItem;
            List<MMOperationDetailPlanCapacityItemsInfo> checkList;
            List<MMOperationDetailPlanCapacityItemsInfo> checkUnitList;
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            List<int> batchProductIDList = entity.OperationDetailPlanCapacityItemsList.Select(t => t.FK_MMBatchProductID).Distinct().ToList();

            List<int> deleteIDList = GetDeleteIDList();

            string errorMess = string.Empty;
            string getErrorMess = string.Empty;
            foreach (int batchProductID in batchProductIDList)
            {
                bp = bpList.FirstOrDefault(t => t.MMBatchProductID == batchProductID);
                if (bp != null)
                {
                    BOSProgressBar.Start(string.Format("Đang kiểm tra {0}", bp.MMBatchProductNo));

                    // Capacity database List
                    allItem = capacityCtrl.GetItemByBatchProductID(batchProductID);

                    //Current Item List
                    curItem = entity.OperationDetailPlanCapacityItemsList.Where(t => t.FK_MMBatchProductID == batchProductID).ToList();

                    //merge list total
                    checkList = GetCheckList(allItem, curItem, deleteIDList);

                    // Structure 
                    productItemList = productItemCtrl.GetItemStructureByBatchProductID(batchProductID);

                    structureList = GetStructureFromProductItemList(productItemList);

                    //convert to unit list
                    checkUnitList = GetUnitList(checkList, structureList);

                    //error List
                    errorList = errorCtrl.GetErrorByBatchProductID(batchProductID);

                    //Check Operation check begin with BPQty
                    getErrorMess = CheckOperationMarkBegin(checkList, productItemList, errorList, structureList, operationList);

                    if (!string.IsNullOrEmpty(getErrorMess))
                    {
                        errorMess = string.Format("{0} có:", bp.MMBatchProductNo);
                        errorMess += getErrorMess;
                        errorMess += string.Format("{0} Vui lòng kiểm tra lại!", Environment.NewLine);

                        BOSProgressBar.Close();
                        BOSApp.ShowMessage(errorMess);
                        isValid = false;
                        break;
                    }

                    //Check Begin Operation
                    getErrorMess = CheckBeginOperation(checkList, productItemList, errorList, structureList, operationList);

                    if (!string.IsNullOrEmpty(getErrorMess))
                    {
                        errorMess = string.Format("{0} có:", bp.MMBatchProductNo);
                        errorMess += getErrorMess;
                        errorMess += string.Format("{0} Vui lòng kiểm tra lại!", Environment.NewLine);

                        BOSProgressBar.Close();
                        BOSApp.ShowMessage(errorMess);
                        isValid = false;
                        break;
                    }
                    //Check Before

                    getErrorMess = CheckBatchProductWithOperationBefore(structureList, checkList, checkUnitList, productItemList, operationList, errorList);

                    if (!string.IsNullOrEmpty(getErrorMess))
                    {
                        errorMess = string.Format("{0} có:", bp.MMBatchProductNo);
                        errorMess += getErrorMess;
                        errorMess += string.Format("{0} Vui lòng kiểm tra lại!", Environment.NewLine);

                        BOSProgressBar.Close();
                        BOSApp.ShowMessage(errorMess);
                        isValid = false;
                        break;
                    }

                    //Check After


                }
            }


            BOSProgressBar.Close();
            return isValid;
        }





        public string CheckOperationMarkBegin(List<MMOperationDetailPlanCapacityItemsInfo> checkAllList
                                                   , List<ICProductItemsInfo> productItemList
                                                   , List<ICReceiptItemErrorsInfo> errorList
                                                   , List<ICProductItemsInfo> structureList
                                                   , List<MMOperationsInfo> operationList)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> checkList = checkAllList.Where(t => t.MMOperationDetailPlanCapacityItemIsBeginOperation).ToList();
            if (checkList == null || !checkList.Any())
            {
                return string.Empty;
            }


            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            MMOperationDetailPlanCapacityItemsInfo filterItem;

            List<ICProductItemsInfo> productStructureList;

            List<string> keyList = checkList.Select(t => t.FK_ICProductID
                                                        + "_" + t.FK_ICProductForBatchID).Distinct().ToList();


            string errorMess = string.Empty;
            keyList.ForEach(key =>
            {

                filterList = checkList.Where(t => t.FK_ICProductID
                                                + "_" + t.FK_ICProductForBatchID == key).ToList();
                if (filterList != null && filterList.Any())
                {
                    filterItem = filterList[0];
                    decimal beginOperationQty = GetQtyFromList(filterList);
                    if (beginOperationQty > 0)
                    {
                        decimal bpQty = GetQtyByProductIDAndProductForBatchID(productItemList, filterItem.FK_ICProductID, filterItem.FK_ICProductForBatchID);

                        decimal errorQty = 0;
                        decimal transferQty = 0;

                        productStructureList = ConvertToUnit(filterItem.FK_ICProductID, structureList);
                        if (productStructureList != null)
                        {
                            errorQty = GetErrorQty(filterItem.FK_ICProductForBatchID
                                                   , errorList
                                                   , productStructureList
                                                   , operationList
                                                   , filterItem.FK_MMOperationID
                                                   , true);

                            transferQty = GetErrorQty(filterItem.FK_ICProductForBatchID
                                                   , errorList
                                                   , productStructureList
                                                   , operationList
                                                   , filterItem.FK_MMOperationID
                                                   , false);
                        }

                        decimal canCapacityQty = (bpQty + errorQty - transferQty);
                        if (beginOperationQty > canCapacityQty)
                        {
                            errorMess += string.Format("{0} - [{1}] có [Số lượng] công đoạn bắt đầu không hợp lệ.{2}   Tổng số lượng hiện tại: {3} {4}   Tổng số lượng theo LSX là: {5}"
                                                        , Environment.NewLine
                                                        , filterItem.MMOperationDetailPlanCapacityItemProductName
                                                        , Environment.NewLine
                                                        , beginOperationQty.ToString("N0")
                                                        , Environment.NewLine
                                                        , canCapacityQty.ToString("N0"));

                        }
                    }

                }

            });

            return errorMess;
        }

        public List<MMOperationDetailPlanCapacityItemsInfo> GetUnitList(List<MMOperationDetailPlanCapacityItemsInfo> checkList, List<ICProductItemsInfo> structureList)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> unitList = new List<MMOperationDetailPlanCapacityItemsInfo>();

            List<ICProductItemsInfo> itemStructureList;

            MMOperationDetailPlanCapacityItemsInfo addItem;
            foreach (MMOperationDetailPlanCapacityItemsInfo item in checkList)
            {
                itemStructureList = structureList.Where(t => t.FK_ICProductItemParentID == item.FK_ICProductID).ToList();
                if (itemStructureList != null)
                {
                    itemStructureList.ForEach(t =>
                    {

                        addItem = (MMOperationDetailPlanCapacityItemsInfo)item.Clone();
                        addItem.MMOperationDetailPlanCapacityItemProductQty *= t.ICProductItemQty;
                        addItem.FK_ICProductID = t.FK_ICProductItemChildID;
                        unitList.Add(addItem);
                    });
                }
                else
                {
                    addItem = (MMOperationDetailPlanCapacityItemsInfo)item.Clone();
                    unitList.Add(addItem);
                }
            }

            return unitList;
        }

        public List<MMOperationDetailPlanCapacityItemsInfo> GetCheckList(List<MMOperationDetailPlanCapacityItemsInfo> databaseList
                                                                        , List<MMOperationDetailPlanCapacityItemsInfo> currentList
                                                                        , List<int> deleteIDList)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> checkList = new List<MMOperationDetailPlanCapacityItemsInfo>();

            checkList.AddRange(currentList);

            List<int> currentIDList = currentList.Select(t => t.MMOperationDetailPlanCapacityItemID).Distinct().ToList();

            List<MMOperationDetailPlanCapacityItemsInfo> datafilterList
                = databaseList.Where(t => !currentIDList.Contains(t.MMOperationDetailPlanCapacityItemID)
                                        && !deleteIDList.Contains(t.MMOperationDetailPlanCapacityItemID)
                                    ).ToList();

            if (datafilterList != null && datafilterList.Any())
            {
                checkList.AddRange(datafilterList);
            }

            return checkList;
        }

        public Dictionary<int, List<MMOperationDetailPlanCapacityItemsInfo>> GetDictionaryByCapacityItemList(List<MMOperationDetailPlanCapacityItemsInfo> itemList)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> filterList;

            Dictionary<int, List<MMOperationDetailPlanCapacityItemsInfo>> dictonary
                = new Dictionary<int, List<MMOperationDetailPlanCapacityItemsInfo>>();

            List<int> keyList = itemList.Select(t => t.FK_ICProductID).Distinct().ToList();

            foreach (int key in keyList)
            {
                filterList = itemList.Where(t => t.FK_ICProductID == key).ToList();
                dictonary.Add(key, filterList);
            }

            return dictonary;
        }


        public decimal GetQtyByProductIDAndProductForBatchID(List<ICProductItemsInfo> productItemList, int productID, int productForBatchID)
        {
            decimal qty = 0;

            List<ICProductItemsInfo> filterList = productItemList.Where(t => t.FK_ICProductItemChildID == productID
                                                                            && (productForBatchID == 0 || t.FK_ICProductForBatchID == productForBatchID)).ToList();

            if (filterList != null)
            {
                qty = filterList.Sum(t => t.ICProductItemTotalQty);
            }

            return qty;
        }

        public decimal GetQtyFromList(List<MMOperationDetailPlanCapacityItemsInfo> itemList)
        {
            if (itemList != null)
            {
                return itemList.Sum(t => t.MMOperationDetailPlanCapacityItemProductQty);
            }
            return 0;
        }

        public decimal GetTotalQtyOfCapacity(List<MMOperationDetailPlanCapacityItemsInfo> currentItem
                                            , List<MMOperationDetailPlanCapacityItemsInfo> dataItem
                                            , bool isCheckBeginOperation)
        {
            decimal totalQty = 0;

            List<MMOperationDetailPlanCapacityItemsInfo> dataFilter;
            List<int> capacityIDList = currentItem.Select(t => t.MMOperationDetailPlanCapacityItemID).ToList();
            if (isCheckBeginOperation)
            {
                dataFilter = currentItem.Where(t => t.MMOperationDetailPlanCapacityItemIsBeginOperation).ToList();
                totalQty += GetQtyFromList(dataFilter);

                dataFilter
                = dataItem.Where(t => !capacityIDList.Contains(t.MMOperationDetailPlanCapacityItemID) && t.MMOperationDetailPlanCapacityItemIsBeginOperation).ToList();
                totalQty += GetQtyFromList(dataFilter);
            }
            else
            {
                totalQty += GetQtyFromList(currentItem);

                dataFilter
                = dataItem.Where(t => !capacityIDList.Contains(t.MMOperationDetailPlanCapacityItemID)).ToList();
                totalQty += GetQtyFromList(dataFilter);
            }

            return totalQty;
        }

        public Dictionary<string, List<MMOperationDetailPlanCapacityItemsInfo>>
            GetDictionanyByCapacityList(List<MMOperationDetailPlanCapacityItemsInfo> checkList
                                        , bool exceptBeginOperation)
        {
            Dictionary<string, List<MMOperationDetailPlanCapacityItemsInfo>>
                dic = new Dictionary<string, List<MMOperationDetailPlanCapacityItemsInfo>>();

            List<string> keyList = checkList.Where(t => (exceptBeginOperation && !t.MMOperationDetailPlanCapacityItemIsBeginOperation)
                                                        || !exceptBeginOperation).Select(t => t.FK_ICProductID
                                                                                            + "_" + t.FK_ICProductForBatchID
                                                                                            + "_" + t.FK_HRDepartmentRoomGroupItemID
                                                                                            + "_" + t.FK_MMOperationID
                                                                                            + "_" + t.MMOperationDetailPlanCapacityItemDate.ToString("dd/MM/yyyy")).Distinct().ToList();


            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            foreach (string key in keyList)
            {
                filterList = checkList.Where(t => ((exceptBeginOperation && !t.MMOperationDetailPlanCapacityItemIsBeginOperation)
                                                        || !exceptBeginOperation)
                                                    && (t.FK_ICProductID
                                                        + "_" + t.FK_ICProductForBatchID
                                                        + "_" + t.FK_HRDepartmentRoomGroupItemID
                                                        + "_" + t.FK_MMOperationID
                                                        + "_" + t.MMOperationDetailPlanCapacityItemDate.ToString("dd/MM/yyyy")) == key).ToList();
                if (filterList != null)
                {
                    dic.Add(key, filterList);
                }
            }

            return dic;
        }

        public bool IsSameReferenceMark(int operation1, int operation2, List<MMOperationsInfo> operationList)
        {
            MMOperationsInfo oper1 = operationList.FirstOrDefault(t => t.MMOperationID == operation1);
            MMOperationsInfo oper2 = operationList.FirstOrDefault(t => t.MMOperationID == operation2);

            return (oper1.MMOperationReferenceMark == oper2.MMOperationReferenceMark);
        }

        public List<ICProductItemsInfo> ConvertToUnit(int productID, List<ICProductItemsInfo> structureList)
        {
            return structureList.Where(t => t.FK_ICProductItemParentID == productID).ToList();
        }

        public string CheckBatchProductWithOperationBefore(List<ICProductItemsInfo> structureList
                                            , List<MMOperationDetailPlanCapacityItemsInfo> checkList
                                            , List<MMOperationDetailPlanCapacityItemsInfo> checkUnitList
                                            , List<ICProductItemsInfo> productItemList
                                            , List<MMOperationsInfo> operationList
                                            , List<ICReceiptItemErrorsInfo> errorList)
        {
            string errorMess = string.Empty;
            Dictionary<string, List<MMOperationDetailPlanCapacityItemsInfo>> dic
             = GetDictionanyByCapacityList(checkList, true);

            List<int> distinctIDList;
            List<MMOperationDetailPlanCapacityItemsInfo> dicDetail;
            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            MMOperationDetailPlanCapacityItemsInfo dicDetailItem;
            List<ICProductItemsInfo> itemStructure;
            MMOperationsInfo operation;
            foreach (string key in dic.Keys)
            {
                dicDetail = dic[key];
                if (dicDetail != null && dicDetail.Any())
                {
                    dicDetailItem = dicDetail[0];

                    operation = operationList.FirstOrDefault(t => t.MMOperationID == dicDetailItem.FK_MMOperationID);

                    //convert to unit
                    itemStructure = ConvertToUnit(dicDetailItem.FK_ICProductID, structureList);


                    decimal errorQty = GetErrorQty(dicDetailItem.FK_ICProductForBatchID
                                                   , errorList
                                                   , itemStructure
                                                   , operationList
                                                   , dicDetailItem.FK_MMOperationID
                                                   , true);

                    decimal transferQty = GetErrorQty(dicDetailItem.FK_ICProductForBatchID
                                           , errorList
                                           , itemStructure
                                           , operationList
                                           , dicDetailItem.FK_MMOperationID
                                           , false);

                    List<decimal> qtyList = new List<decimal>();
                    List<decimal> qtySameGroupList = new List<decimal>();
                    List<decimal> qtySameOperationList = new List<decimal>();

                    itemStructure.ForEach(item =>
                    {

                        decimal sumQty = 0;

                        // khac to thi sum
                        filterList = checkUnitList.Where(t => //!IsSameReferenceMark(t.FK_MMOperationID, dicDetailItem.FK_MMOperationID, operationList)
                                                              //&& t.FK_MMOperationID != dicDetailItem.FK_MMOperationID &&
                                                             dicDetailItem.FK_HRDepartmentRoomGroupItemID != t.FK_HRDepartmentRoomGroupItemID
                                                            && dicDetailItem.FK_HRDepartmentRoomGroupItemID == t.FK_HRToDepartmentRoomGroupItemID
                                                            && item.FK_ICProductItemChildID == t.FK_ICProductID
                                                            && (t.FK_ICProductForBatchID == 0 || t.FK_ICProductForBatchID == dicDetailItem.FK_ICProductForBatchID)
                                                            && t.MMOperationDetailPlanCapacityItemDate.Date <= dicDetailItem.MMOperationDetailPlanCapacityItemDate.Date).ToList();

                        if (filterList != null && filterList.Any())
                        {
                            sumQty = filterList.Sum(t => t.MMOperationDetailPlanCapacityItemProductQty) / item.ICProductItemQty;
                        }

                        qtyList.Add(sumQty);

                        // cung to thi lay max theo cong doan
                        sumQty = 0;

                        filterList = checkUnitList.Where(t => IsSameReferenceMark(t.FK_MMOperationID, dicDetailItem.FK_MMOperationID, operationList)
                                                            && t.FK_MMOperationID != dicDetailItem.FK_MMOperationID
                                                            && dicDetailItem.FK_HRDepartmentRoomGroupItemID == t.FK_HRDepartmentRoomGroupItemID
                                                            && dicDetailItem.FK_HRDepartmentRoomGroupItemID == t.FK_HRToDepartmentRoomGroupItemID
                                                            && item.FK_ICProductItemChildID == t.FK_ICProductID
                                                            && (t.FK_ICProductForBatchID == 0 || t.FK_ICProductForBatchID == dicDetailItem.FK_ICProductForBatchID)
                                                            && t.MMOperationDetailPlanCapacityItemDate.Date <= dicDetailItem.MMOperationDetailPlanCapacityItemDate.Date).ToList();

                        qtySameOperationList = new List<decimal>();
                        if (filterList != null && filterList.Any())
                        {
                            distinctIDList = filterList.Select(t => t.FK_MMOperationID).Distinct().ToList();

                            foreach (int oID in distinctIDList)
                            {
                                sumQty = filterList.Where(t => t.FK_MMOperationID == oID)
                                            .Sum(t => t.MMOperationDetailPlanCapacityItemProductQty) / item.ICProductItemQty;

                                qtySameOperationList.Add(sumQty);
                            }

                        }
                        if (qtySameOperationList.Any())
                        {
                            qtySameGroupList.Add(qtySameOperationList.Min());
                        }
                        else
                        {
                            qtySameGroupList.Add(0);
                        }

                    });

                    decimal receiveCapacityDiffGroupQty = qtyList.Min();
                    decimal receiveCapacitySameGroupQty = qtySameGroupList.Max();

                    filterList = checkList.Where(t => t.FK_MMOperationID == dicDetailItem.FK_MMOperationID
                                                   && t.FK_HRDepartmentRoomGroupItemID == dicDetailItem.FK_HRDepartmentRoomGroupItemID
                                                   && t.FK_ICProductID == dicDetailItem.FK_ICProductID
                                                   && t.FK_ICProductForBatchID == dicDetailItem.FK_ICProductForBatchID
                                                   && t.MMOperationDetailPlanCapacityItemDate.Date <= dicDetailItem.MMOperationDetailPlanCapacityItemDate.Date).ToList();

                    decimal capacityQty = GetQtyFromList(filterList);

                    decimal canCapacityQty = Math.Max(receiveCapacityDiffGroupQty, receiveCapacitySameGroupQty);
                    decimal canCQty = canCapacityQty + errorQty - transferQty;

                    if (capacityQty > canCQty)
                    {
                        errorMess += string.Format("{0} - [{1}] có [Số lượng] ghi năng suất cho [{2}] không hợp lệ. {3}   Tổng số lượng có thể ghi năng suất là: {4}{5}   Tổng số lượng ghi năng suất hiện tại là: {6}"
                                                    , Environment.NewLine
                                                    , dicDetailItem.MMOperationDetailPlanCapacityItemProductName
                                                    , operation.MMOperationName
                                                    , Environment.NewLine
                                                    , canCQty.ToString("N0")
                                                    , Environment.NewLine
                                                    , capacityQty.ToString("N0"));
                    }

                }
            }

            return errorMess;
        }

        public bool IsOperationBefore(int operation1, int operation2, List<MMOperationsInfo> operationList)
        {
            MMOperationsInfo oper1 = operationList.FirstOrDefault(t => t.MMOperationID == operation1);
            MMOperationsInfo oper2 = operationList.FirstOrDefault(t => t.MMOperationID == operation2);

            return (oper1.MMOperationOrder >= oper2.MMOperationOrder);
        }

        public decimal GetErrorQty(int productForBatchID, List<ICReceiptItemErrorsInfo> errorList, List<ICProductItemsInfo> productStructure, List<MMOperationsInfo> operationList, int operationID, bool isError)
        {
            decimal qty = 0;

            List<decimal> qtyList = new List<decimal>();

            foreach (ICProductItemsInfo item in productStructure)
            {
                decimal errorQty = GetErrorQtyFromList(errorList.Where(t => (productForBatchID == 0 || t.FK_ICProductForBatchID == productForBatchID)
                                                    && t.FK_ICProductID == item.FK_ICProductID
                                                    && ((isError && t.ICReceiptItemErrorProductQty > 0)
                                                          || (!isError && t.ICReceiptItemErrorProductQty < 0))
                                                    && IsOperationBefore(operationID, t.FK_MMOperationID, operationList)));


                if (item.ICProductItemQty > 0)
                {
                    decimal qtyAdd = errorQty / item.ICProductItemQty;
                    qtyAdd = Math.Abs(qtyAdd);
                    qtyAdd = Math.Floor(qtyAdd);
                    qtyList.Add(qtyAdd);
                }
                else
                {
                    qtyList.Add(0);
                }
            }

            qty = qtyList.Min();

            return qty;
        }

        public decimal GetErrorQtyFromList(IEnumerable<ICReceiptItemErrorsInfo> filterErrorList)
        {
            if (filterErrorList != null)
            {
                return filterErrorList.Sum(t => t.ICReceiptItemErrorProductQty);
            }
            return 0;
        }

        public string CheckBeginOperation(List<MMOperationDetailPlanCapacityItemsInfo> checkList
                                            , List<ICProductItemsInfo> productItemList
                                            , List<ICReceiptItemErrorsInfo> errorList
                                            , List<ICProductItemsInfo> structureList
                                            , List<MMOperationsInfo> operationList)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            MMOperationDetailPlanCapacityItemsInfo filterItem;
            MMOperationsInfo operation;
            List<ICProductItemsInfo> productStructureList;

            List<string> keyList = checkList.Select(t => t.FK_ICProductID
                                                        + "_" + t.FK_ICProductForBatchID
                                                        + "_" + t.FK_MMOperationID).Distinct().ToList();


            string errorMess = string.Empty;
            keyList.ForEach(key =>
            {

                filterList = checkList.Where(t => t.FK_ICProductID
                                                + "_" + t.FK_ICProductForBatchID
                                                + "_" + t.FK_MMOperationID == key).ToList();
                if (filterList != null && filterList.Any())
                {
                    filterItem = filterList[0];
                    decimal beginOperationQty = GetQtyFromList(filterList);
                    operation = operationList.FirstOrDefault(t => t.MMOperationID == filterItem.FK_MMOperationID);
                    if (beginOperationQty > 0)
                    {
                        decimal bpQty = GetQtyByProductIDAndProductForBatchID(productItemList, filterItem.FK_ICProductID, filterItem.FK_ICProductForBatchID);

                        decimal errorQty = 0;
                        decimal transferQty = 0;

                        productStructureList = ConvertToUnit(filterItem.FK_ICProductID, structureList);
                        if (productStructureList != null)
                        {
                            errorQty = GetErrorQty(filterItem.FK_ICProductForBatchID
                                                   , errorList
                                                   , productStructureList
                                                   , operationList
                                                   , filterItem.FK_MMOperationID
                                                   , true);

                            transferQty = GetErrorQty(filterItem.FK_ICProductForBatchID
                                                   , errorList
                                                   , productStructureList
                                                   , operationList
                                                   , filterItem.FK_MMOperationID
                                                   , false);
                        }

                        decimal canCapacityQty = (bpQty + errorQty - transferQty);
                        if (beginOperationQty > canCapacityQty)
                        {
                            errorMess += string.Format("{0} - [{1}] có [Số lượng] công đoạn [{2}] không hợp lệ.{3}   Tổng số lượng hiện tại: {4} {5}   Tổng số lượng theo LSX là: {6}"
                                                        , Environment.NewLine
                                                        , filterItem.MMOperationDetailPlanCapacityItemProductName
                                                        , operation.MMOperationName
                                                        , Environment.NewLine
                                                        , beginOperationQty.ToString("N0")
                                                        , Environment.NewLine
                                                        , canCapacityQty.ToString("N0"));

                        }
                    }

                }

            });

            return errorMess;
        }


        public string CheckHasReceiptAndFirstOperationMatch(string batchProductNo
                                                            , List<MMOperationDetailPlanCapacityItemsInfo> allItem
                                                            , List<MMOperationDetailPlanCapacityItemsInfo> currentItem
                                                            , List<MMOperationsInfo> operationList)
        {

            List<MMOperationDetailPlanCapacityItemsInfo> mergeList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            mergeList.AddRange(allItem);
            mergeList.AddRange(currentItem);

            List<int> distinctOperationList = mergeList.Select(t => t.FK_MMOperationID).Distinct().ToList();
            List<int> HasReceiptOperationError = new List<int>();
            List<int> FirstOperationError = new List<int>();

            List<bool> filterList;
            foreach (int operationID in distinctOperationList)
            {
                filterList = mergeList.Where(t => t.FK_MMOperationID == operationID)
                                      .Select(t => t.MMOperationDetailPlanCapacityItemHasReceipt).Distinct().ToList();
                if (filterList != null && filterList.Count > 1)
                {
                    HasReceiptOperationError.Add(operationID);
                }

                filterList = mergeList.Where(t => t.FK_MMOperationID == operationID)
                                      .Select(t => t.MMOperationDetailPlanCapacityItemIsBeginOperation).Distinct().ToList();
                if (filterList != null && filterList.Count > 1)
                {
                    FirstOperationError.Add(operationID);
                }
            }

            if (HasReceiptOperationError.Count > 0
                || FirstOperationError.Count > 0)
            {
                string errorMess = string.Format("{0} có:", batchProductNo);
                errorMess += GetErrorMessFromOperationErrorList(HasReceiptOperationError, "Có nhập kho", operationList);
                errorMess += GetErrorMessFromOperationErrorList(FirstOperationError, "Công đoạn bắt đầu", operationList);

                return errorMess;
            }

            return null;
        }

        private string GetErrorMessFromOperationErrorList(List<int> errorList, string type, List<MMOperationsInfo> operationList)
        {
            string errorMess = string.Empty;
            if (errorList.Count > 0)
            {
                MMOperationsInfo operation;
                errorMess += string.Format("{0} - Loại [{1}] không khớp ở: ", Environment.NewLine, type);
                string operationError = string.Empty;
                foreach (int operationID in errorList)
                {
                    operation = operationList.FirstOrDefault(t => t.MMOperationID == operationID);
                    if (operation != null)
                    {
                        if (string.IsNullOrEmpty(operationError))
                        {
                            operationError += string.Format("[{0}]", operation.MMOperationName);
                        }
                        else
                        {
                            operationError += string.Format(", [{0}]", operation.MMOperationName);

                        }
                    }
                }
                errorMess += operationError;
            }

            return errorMess;
        }

        public ICProductItemsInfo GenerateProductItem(int childID, int parentID, decimal qty)
        {
            ICProductItemsInfo productItem = new ICProductItemsInfo();
            productItem.FK_ICProductItemChildID = childID;
            productItem.FK_ICProductItemParentID = parentID;
            productItem.ICProductItemQty = qty;
            return productItem;
        }

        public List<ICProductItemsInfo> GetStructureFromProductItemList(List<ICProductItemsInfo> productItemList)
        {
            List<ICProductItemsInfo> structureList = new List<ICProductItemsInfo>();

            List<int> distinctParent = productItemList.Select(t => t.FK_ICProductItemParentID).Distinct().ToList();

            foreach (ICProductItemsInfo item in productItemList)
            {
                if (!distinctParent.Contains(item.FK_ICProductItemChildID))
                {
                    structureList.Add(GenerateProductItem(item.FK_ICProductItemChildID
                                                           , item.FK_ICProductItemChildID
                                                           , 1));
                }
                else
                {
                    GetChildListByParentProductID(item.FK_ICProductItemChildID, item.FK_ICProductItemChildID, item.ICProductItemQty, structureList, productItemList, distinctParent);
                }
            }

            return structureList;
        }

        public void GetChildListByParentProductID(int productID, int productFindID, decimal productQty, List<ICProductItemsInfo> structureList, List<ICProductItemsInfo> productItemList, List<int> distinctParent)
        {
            foreach (ICProductItemsInfo item in productItemList)
            {
                if (item.FK_ICProductItemParentID == productFindID)
                {
                    if (!distinctParent.Contains(item.FK_ICProductItemChildID))
                    {
                        structureList.Add(GenerateProductItem(item.FK_ICProductItemChildID
                                                           , productID
                                                           , item.ICProductItemQty / productQty));
                    }
                    else
                    {
                        GetChildListByParentProductID(productID, item.FK_ICProductItemChildID, productQty, structureList, productItemList, distinctParent);
                    }
                }
            }
        }

        public bool CheckCanCapacityQtyWithTheBeforeOperation()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            List<MMOperationsInfo> operationList = GetOperationList();
            string error = string.Empty;
            MMOperationsInfo operation;
            MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            //GetCanCapacityQty
            List<MMOperationDetailPlanCapacityItemsInfo> noneFirstOperationList
                                                        = entity.OperationDetailPlanCapacityItemsList.Where(t => !t.MMOperationDetailPlanCapacityItemIsBeginOperation).ToList();

            List<string> distinctList = noneFirstOperationList.Select(t => t.FK_MMBatchProductID
                                                                                            + "_" + t.FK_MMOperationID
                                                                                            + "_" + t.FK_ICProductID
                                                                                            + "_" + t.FK_HRDepartmentRoomGroupItemID).Distinct().ToList();


            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            MMOperationDetailPlanCapacityItemsInfo defaultItem;

            foreach (string key in distinctList)
            {
                filterList = noneFirstOperationList.Where(t => (t.FK_MMBatchProductID
                                                                                            + "_" + t.FK_MMOperationID
                                                                                            + "_" + t.FK_ICProductID
                                                                                            + "_" + t.FK_HRDepartmentRoomGroupItemID) == key).ToList();

                if (filterList != null)
                {
                    defaultItem = filterList.FirstOrDefault();

                    decimal capacityQty = filterList.Sum(t => t.MMOperationDetailPlanCapacityItemProductQty);

                    string itemIDStr = GetIDString(filterList);

                    decimal canCapacityQty = capacityCtrl.GetCanCapacityQty(defaultItem.FK_MMBatchProductID
                                                                          , defaultItem.FK_MMOperationID
                                                                          , defaultItem.FK_ICProductID
                                                                          , defaultItem.FK_HRDepartmentRoomGroupItemID
                                                                          , itemIDStr);



                    if (canCapacityQty < capacityQty)
                    {
                        if (string.IsNullOrEmpty(error))
                        {
                            error += "Lưu không thành công! Vui lòng kiểm tra lại các sản phẩm sau:";
                        }

                        operation = operationList.FirstOrDefault(t => t.MMOperationID == defaultItem.FK_MMOperationID);
                        string operationName = string.Empty;
                        if (operation != null)
                        {
                            operationName = operation.MMOperationName;
                        }

                        error += string.Format("{0}- [{1}] SL có thể nhập năng suất [{2}] là [{3}]"
                                    , Environment.NewLine
                                    , defaultItem.MMOperationDetailPlanCapacityItemProductName
                                    , operationName
                                    , canCapacityQty.ToString("N0"));

                    }
                }

            }



            if (!string.IsNullOrEmpty(error))
            {
                BOSApp.ShowMessage(error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckCanCapacityQtyWithTheAfterOperation()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;

            string error = string.Empty;

            MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            //GetCanCapacityQty
            List<string> distinctList = entity.OperationDetailPlanCapacityItemsList.Select(t => t.FK_MMBatchProductID
                                                                                            + "_" + t.FK_MMOperationID
                                                                                            // + "_" + t.FK_MMToOperationID
                                                                                            + "_" + t.FK_HRToDepartmentRoomGroupItemID
                                                                                            + "_" + t.FK_ICProductID).Distinct().ToList();


            List<MMOperationDetailPlanCapacityItemsInfo> filterList;
            MMOperationDetailPlanCapacityItemsInfo defaultItem;

            foreach (string key in distinctList)
            {
                filterList = entity.OperationDetailPlanCapacityItemsList.Where(t => (t.FK_MMBatchProductID
                                                                                    + "_" + t.FK_MMOperationID
                                                                                    // + "_" + t.FK_MMToOperationID
                                                                                    + "_" + t.FK_HRToDepartmentRoomGroupItemID
                                                                                    + "_" + t.FK_ICProductID) == key).ToList();

                if (filterList != null)
                {
                    defaultItem = filterList.FirstOrDefault();

                    decimal capacityQty = filterList.Sum(t => t.MMOperationDetailPlanCapacityItemProductQty);

                    string itemIDStr = GetIDString(filterList);

                    decimal needQty = capacityCtrl.GetRemainCapacityQty(defaultItem.FK_MMBatchProductID
                                                                            , defaultItem.FK_MMOperationID
                                                                            , 0
                                                                            , defaultItem.FK_HRToDepartmentRoomGroupItemID
                                                                            , defaultItem.FK_ICProductID
                                                                            , itemIDStr);



                    if (capacityQty < needQty)
                    {
                        if (string.IsNullOrEmpty(error))
                        {
                            error += "Lưu không thành công! Vui lòng kiểm tra lại các sản phẩm sau:";
                        }

                        error += string.Format("{0}- {1} SL cần để làm công đoạn sau là {2}", Environment.NewLine, defaultItem.MMOperationDetailPlanCapacityItemProductName, needQty.ToString("N0"));

                    }
                }

            }



            if (!string.IsNullOrEmpty(error))
            {
                BOSApp.ShowMessage(error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SaveItem()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;

            if (!CheckCanCapacityQty())
            {
                return false;
            }

            //if (!CheckCanCapacityQtyWithTheAfterOperation())
            //{
            //    return false;
            //}


            entity.OperationDetailPlanCapacityItemsList.SaveItemObjects();
            BOSApp.ShowMessage("Lưu thành công");
            return true;
        }

        public void ClearList()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            List<MMOperationDetailPlanCapacityItemsInfo> capacityList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            entity.OperationDetailPlanCapacityItemsList.Invalidate(capacityList);
        }

        public void DeleteItemFromOperationDetailPlanCapacityItemList(MMOperationDetailPlanCapacityItemsInfo item)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn xóa chi tiết?") == DialogResult.Yes)
            {
                bool isDelete = true;
                // tam thoi chua check voi ngoai sau

                //if (item.MMOperationDetailPlanCapacityItemID > 0)
                //{
                //    string error = string.Empty;
                //    MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
                //    decimal needQty = capacityCtrl.GetRemainCapacityQty(item.FK_MMBatchProductID
                //                                                         , item.FK_MMOperationID
                //                                                         , 0
                //                                                         , item.FK_HRToDepartmentRoomGroupItemID
                //                                                         , item.FK_ICProductID
                //                                                         , item.MMOperationDetailPlanCapacityItemID.ToString() + ",");

                //    if (needQty > item.MMOperationDetailPlanCapacityItemProductQty)
                //    {
                //        error += "Lưu không thành công! Vui lòng kiểm tra lại các sản phẩm sau:";

                //        error += string.Format("{0}- {1} SL cần để làm công đoạn sau là {2}", Environment.NewLine, item.MMOperationDetailPlanCapacityItemProductName, needQty.ToString("N0"));
                //    }

                //    if (string.IsNullOrEmpty(error))
                //    {
                //        item.AAStatus = "Delete";
                //        capacityCtrl.UpdateObject(item);
                //    }
                //    else
                //    {
                //        isDelete = false;
                //        BOSApp.ShowMessage(error);
                //    }
                //}

                if (isDelete)
                {
                    entity.OperationDetailPlanCapacityItemsList.RemoveSelectedRowObjectFromList();
                }
            }

        }

        public void AddItemFromList(int batchProductID, int operationID, int empGiveID, int empTakeID, int empQCID, DateTime date, bool isBeginOperation, bool hasReceipt)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)CurrentModuleEntity;
            MMOperationDetailPlanCapacitysInfo mainObject = (MMOperationDetailPlanCapacitysInfo)CurrentModuleEntity.MainObject;
            guiAddItemFromList gui = new guiAddItemFromList(batchProductID, operationID, empGiveID, empTakeID, empQCID, date, isBeginOperation, hasReceipt);
            gui.Module = this;
            gui.ShowDialog();

        }

        public bool IsOperationSyncProductCheck(int operationID)
        {
            MMOperationsController operationCtrl = new MMOperationsController();
            MMOperationsInfo operation = (MMOperationsInfo)operationCtrl.GetObjectByID(operationID);

            if (operation != null)
            {
                return operation.MMOperationSyncProductCheck;
            }

            return false;
        }
    }
    #endregion Public methods
}
