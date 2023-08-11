using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.CancelPurchaseOrder.Localization;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseOrder
{
    public class CancelPurchaseOrderModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string CancelPurchaseOrderItemGridControlName = "fld_dgcAPCancelPurchaseOrderItems";
        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public APCancelPurchaseOrderItemsGridControl CancelPurchaseOrderItemsGridControl;
        #endregion

        #region Constructor
        public CancelPurchaseOrderModule()
        {
            Name = "CancelPurchaseOrder";
            CurrentModuleEntity = new CancelPurchaseOrderEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CancelPurchaseOrderModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            CancelPurchaseOrderItemsGridControl = (APCancelPurchaseOrderItemsGridControl)Controls[CancelPurchaseOrderItemGridControlName];
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            StartGettingInventoryThread();
        }
        #endregion

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            APCancelPurchaseOrdersController cancelPurchaseOrderController = new APCancelPurchaseOrdersController();
            APCancelPurchaseOrdersInfo searchObject = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds = cancelPurchaseOrderController.GetCancelPurchaseOrdersBySomeCriteria(
                                                                        searchObject.APCancelPurchaseOrderNo,
                                                                        searchObject.APCancelPurchaseOrderReference,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.FK_BRBranchID,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.APCancelPurchaseOrderDateFrom,
                                                                        searchObject.APCancelPurchaseOrderDateTo);


            return ds;
        }

        //protected override DataSet GetSearchData(ref string searchQuery)
        //{            
        //    APCancelPurchaseOrdersInfo searchObject = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.SearchObject;
        //    APCancelPurchaseOrdersController objCancelVouchersController = new APCancelPurchaseOrdersController();
        //    //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

        //    //DataSet ds = objCancelVouchersController.GetCancelVoucherList(
        //    //                                                    searchObject.APCancelPurchaseOrderNo,
        //    //                                                    searchObject.ARSaleOrderNo,
        //    //                                                    searchObject.FK_ARCustomerID,
        //    //                                                    searchObject.FK_HREmployeeID,
        //    //                                                    searchObject.CancelVoucherDateFrom,
        //    //                                                    searchObject.CancelVoucherDateTo);
        //    //return ds;
        //    DataSet ds = new DataSet();
        //    if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
        //    {
        //        if (BranchList.Count == 0)
        //        {
        //            ds = objCancelVouchersController.GetDataSetByID(-1);
        //        }
        //        else
        //        {
        //            ds = objCancelVouchersController.GetCancelPurchaseOrderListDatasetByListOfBranchID(
        //                                                        searchObject.APCancelPurchaseOrderNo,
        //                                                        searchObject.APPurchaseOrderNo,
        //                                                        searchObject.FK_APSupplierID,
        //                                                        searchObject.FK_HREmployeeID,
        //                                                        searchObject.CancelPurchaseOrderDateFrom,
        //                                                        searchObject.CancelPurchaseOrderDateTo,
        //                                                        BranchList);
        //        }
        //    }
        //    else
        //    {
        //        ds = objCancelVouchersController.GetCancelPurchaseOrderListDataset(
        //                                                        searchObject.APCancelPurchaseOrderNo,
        //                                                        searchObject.APPurchaseOrderNo,
        //                                                        searchObject.FK_APSupplierID,
        //                                                        searchObject.FK_HREmployeeID,
        //                                                        searchObject.CancelPurchaseOrderDateFrom,
        //                                                        searchObject.CancelPurchaseOrderDateTo,
        //                                                        searchObject.FK_BRBranchID);
        //    }

        //    return ds;
        //    //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        //}
        ////NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #region Methods
        public override void ActionNew()
        {
            base.ActionNew();
            bool flag = true;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderItemsInfo> purchaseOrderList = objPurchaseOrderItemsController.GetListItemForCancel();
            APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = new APPurchaseOrderItemsInfo();
            guiChoosePurchaseOrderItem guiFind = new guiChoosePurchaseOrderItem(purchaseOrderList);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {

                List<APPurchaseOrderItemsInfo> selectedPurchaseOrderItems = guiFind.SelectedObjects as List<APPurchaseOrderItemsInfo>;
                objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)guiFind.SelectedObjects[0];
                if (selectedPurchaseOrderItems != null && selectedPurchaseOrderItems.Count > 0 && objPurchaseOrderItemsInfo != null)
                {
                    foreach (APPurchaseOrderItemsInfo item in selectedPurchaseOrderItems)
                    {
                        if (objPurchaseOrderItemsInfo.FK_APPurchaseOrderID != item.FK_APPurchaseOrderID)
                        {
                            MessageBox.Show(string.Format(CancelPurchaseOrderLocalizedResources.ChosePurchaseOderItemError), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
                        APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.MainObject;
                        objCancelPurchaseOrdersInfo.APCancelPurchaseOrderReference = objPurchaseOrderItemsInfo.APPurchaseOrderNo;
                        APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(objPurchaseOrderItemsInfo.APPurchaseOrderNo);
                        ChangedInputType(objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo);
                        GenerateCancelPurchaseOrderFromPurchaseOrder(selectedPurchaseOrderItems);
                        objCancelPurchaseOrdersInfo.FK_ACObjectID = objPurchaseOrdersInfo.FK_ACObjectID;
                        objCancelPurchaseOrdersInfo.APObjectType = objPurchaseOrdersInfo.APObjectType;
                        objCancelPurchaseOrdersInfo.ACObjectAccessKey = objCancelPurchaseOrdersInfo.FK_ACObjectID + ";" + objCancelPurchaseOrdersInfo.APObjectType;
                        objCancelPurchaseOrdersInfo.FK_APPurchaseContractID = objPurchaseOrdersInfo.FK_APPurchaseContractID;
                        objCancelPurchaseOrdersInfo.APCancelPurchaseOrderContractNo = objPurchaseOrdersInfo.APPurchaseOrderContractNo;
                        objCancelPurchaseOrdersInfo.MMBatchProductSOName = string.Join(", ", selectedPurchaseOrderItems.Where(o => !string.IsNullOrWhiteSpace(o.MMBatchProductSOName)).Select(o => o.MMBatchProductSOName).Distinct().ToArray());
                        entity.UpdateMainObjectBindingSource();
                    }

                    FormatCaptionOfQuantityColumnItemlist();
                }

            }
            else
                ActionCancel();

        }

        public override int ActionSave()
        {


            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo mainObject = (APCancelPurchaseOrdersInfo)entity.MainObject;
            //foreach (APCancelPurchaseOrderItemsInfo item in entity.CancelPurchaseOrderItemList)
            //{
            //    if (!IsValidCanceledQty(item))
            //    {
            //        MessageBox.Show(string.Format(CancelPurchaseOrderLocalizedResources.CanceledQtyCannotBeGreaterThanOrderedQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return 0;
            //    }
            //}           
            if (mainObject.APCancelPurchaseOrderDesc == String.Empty || mainObject.APCancelPurchaseOrderDesc == null)
            {
                MessageBox.Show(CancelPurchaseOrderLocalizedResources.Reasonscancel, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return base.ActionSave();
        }

        /// <summary>
        ///  Change item from cancel voucher item list
        /// </summary>
        public void ChangeItemFromCancelVoucherItemList()
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrderItemsInfo objCancelVoucherItemsInfo = (APCancelPurchaseOrderItemsInfo)entity.ModuleObjects[TableName.APCancelPurchaseOrderItemsTableName];
            objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductExchangeQty = objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductQty * objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductFactor;
            entity.SetProductPriceByProductUnitPrice();
            entity.CancelPurchaseOrderItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Delete item from cancel voucher item list
        /// </summary>
        public void DeleteItemFromCancelVoucherItemList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
                entity.CancelPurchaseOrderItemList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Update the total amounts of the cancel voucher
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
                //entity.UpdateTotalAmount();
            }
        }
        public void ChangedInputType(string inputType)
        {
            ICProductsController objICProductsController = new ICProductsController();
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)entity.MainObject;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            if (inputType == ProductType.Roundwood.ToString())
            {
                //productList = objICProductsController.GetProductByProductType(ProductType.Roundwood.ToString());
                CancelPurchaseOrderItemsGridControl.LoadGridViewForRoundWood(inputType);
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderType = inputType;
                entity.UpdateMainObjectBindingSource();
            }
            else if (inputType == ProductType.Lumber.ToString()
                || inputType == ProductType.Verneer.ToString()
                || inputType == ProductType.ArtificialBoard.ToString())
            {
                //productList = objICProductsController.GetProductByProductWoodType();
                CancelPurchaseOrderItemsGridControl.LoadGridViewForRoundWood(inputType);
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderType = inputType;
                entity.UpdateMainObjectBindingSource();
            }
            else if (inputType == ProductType.Product.ToString())
            {
                //productList = objICProductsController.GetDataProductForPurchase();
                CancelPurchaseOrderItemsGridControl.LoadGridViewForRoundWood(inputType);
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderType = inputType;
                entity.UpdateMainObjectBindingSource();
            }
            else
            {
                // productList = objICProductsController.GetDataProductForPurchase();
                CancelPurchaseOrderItemsGridControl.LoadGridViewForRoundWood(inputType);
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderType = inputType;
                entity.UpdateMainObjectBindingSource();
            }

        }
        /// <summary>
        /// Init cancel voucher report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        private void InitCancelVoucherReport(XtraReport report)
        {
            APCancelPurchaseOrdersController objCancelVouchersController = new APCancelPurchaseOrdersController();
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetCancelVoucherItemByCacelVoucherID(Toolbar.CurrentObjectID);
            if (ds.Tables.Count > 0)
            {
                APCancelPurchaseOrderItemsController objCancelVoucherItemsController = new APCancelPurchaseOrderItemsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APCancelPurchaseOrderItemsInfo objCancelVoucherItemsInfo = (APCancelPurchaseOrderItemsInfo)objCancelVoucherItemsController.GetObjectFromDataRow(row);
                    objCancelVoucherItemsInfo.APCancelPurchaseOrderItemComment = string.Empty;
                    if (objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductDiscount > 0)
                    {
                        objCancelVoucherItemsInfo.APCancelPurchaseOrderItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelVoucherLocalizedResources.Discount,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductDiscount,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    if (objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductTaxPercent > 0)
                    {
                        objCancelVoucherItemsInfo.APCancelPurchaseOrderItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelVoucherLocalizedResources.VAT,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductTaxPercent,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    row["APCancelPurchaseOrderItemComment"] = objCancelVoucherItemsInfo.APCancelPurchaseOrderItemComment;

                    objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductDesc += string.Format(" {0} / {1}", objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductSerialNo, objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductSupplierNo);
                    row["APCancelPurchaseOrderItemProductDesc"] = objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductDesc;
                }
            }
            report.DataSource = ds;
            report.DataMember = BOSCommon.Constants.Report.DevCancelVoucherReportName;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            APCancelPurchaseOrdersInfo objCancelVouchersInfo = new APCancelPurchaseOrdersInfo();

            //(APCancelPurchaseOrdersInfo)objCancelVouchersController.GetObjectByID(Toolbar.CurrentObjectID);
            //if (objCancelVouchersInfo.APCancelPurchaseOrderDiscountFix == 0)
            //{
            //    XRPanel discountPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlDiscount"];
            //    if (discountPanel != null)
            //    {
            //        discountPanel.Visible = false;
            //    }
            //}

            //if (objCancelVouchersInfo.APCancelPurchaseOrderTaxAmount == 0)
            //{
            //    XRPanel taxPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlVAT"];
            //    if (taxPanel != null)
            //    {
            //        taxPanel.Visible = false;
            //    }
            //}
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPCancelVoucher report = new RPCancelVoucher();
                InitCancelVoucherReport(report);
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Generate cancel voucher from sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Info of sale order</param>
        public void GenerateCancelPurchaseOrderFromPurchaseOrder(List<APPurchaseOrderItemsInfo> selectedPurchaseOrderItems)
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelVouchersInfo = (APCancelPurchaseOrdersInfo)entity.MainObject;
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStocksInfo = null;
            foreach (APPurchaseOrderItemsInfo item in selectedPurchaseOrderItems)
            {
                APCancelPurchaseOrderItemsInfo objCancelPurchaseOrderItemsInfo = new APCancelPurchaseOrderItemsInfo();
                BOSUtil.CopyObject(item, objCancelPurchaseOrderItemsInfo);
                objCancelPurchaseOrderItemsInfo.MMBatchProductSOName = item.MMBatchProductSOName;
                objCancelPurchaseOrderItemsInfo.FK_APPurchaseOrderItemID = item.APPurchaseOrderItemID;
                //
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductQty = item.APPurchaseOrderItemRemainedQty;
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemTotalQty = item.APPurchaseOrderItemRemainedQty;
                //
                //objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductQty = (item.APPurchaseOrderItemProductQty - item.APPurchaseOrderItemReceiptedQty - item.APPurchaseOrderItemProductCanceledQty);
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemWoodQty = item.APPurchaseOrderItemRemainedQty;

                if (objCancelVouchersInfo.FK_BRBranchID > 0)
                {
                    objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), objCancelVouchersInfo.FK_BRBranchID);
                }
                else
                {
                    objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                }
                if (objStocksInfo != null)
                {
                    objCancelPurchaseOrderItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                }
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductUnitPrice = item.APPurchaseOrderItemProductUnitCost;
                decimal subTotalCost = objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductUnitPrice * objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductQty;
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemDiscountAmount = subTotalCost * objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductDiscount / 100;
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemTaxAmount = (subTotalCost - objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemDiscountAmount) * objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemProductTaxPercent / 100;
                objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemTotalAmount = subTotalCost - objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemDiscountAmount + objCancelPurchaseOrderItemsInfo.APCancelPurchaseOrderItemTaxAmount;

                entity.CancelPurchaseOrderItemList.Add(objCancelPurchaseOrderItemsInfo);
                entity.CancelPurchaseOrderItemList.GridControl.RefreshDataSource();
            }




            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Generate cancel voucher item from sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Info of sale order</param>
        public void GenerateCancelPurchaseOrderItemFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            DataSet ds = objPurchaseOrderItemsController.GetAllDataByForeignColumn("FK_APPurchaseOrderID", objPurchaseOrdersInfo.APPurchaseOrderID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectFromDataRow(dr);
                    decimal canceledQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - //objPurchaseOrderItemsInfo.APPurchaseOrderItemCanceledQty - 
                        objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty;
                    if (canceledQty > 0)
                    {
                        APCancelPurchaseOrderItemsInfo objCancelVoucherItemsInfo = new APCancelPurchaseOrderItemsInfo();
                        BOSUtil.CopyObject(objPurchaseOrderItemsInfo, objCancelVoucherItemsInfo);
                        objCancelVoucherItemsInfo.APCancelPurchaseOrderItemOrderedQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty;
                        objCancelVoucherItemsInfo.APCancelPurchaseOrderItemWoodQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty;
                        objCancelVoucherItemsInfo.APCancelPurchaseOrderItemProductQty = canceledQty;
                        objCancelVoucherItemsInfo.FK_APPurchaseOrderID = objPurchaseOrdersInfo.APPurchaseOrderID;
                        objCancelVoucherItemsInfo.FK_APPurchaseOrderItemID = objPurchaseOrderItemsInfo.APPurchaseOrderItemID;

                        //Set sale order stock
                        ICStocksController objStockController = new ICStocksController();
                        ICStocksInfo objStocksInfo = null;
                        if (objPurchaseOrdersInfo.FK_BRBranchID > 0)
                        {
                            objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), objPurchaseOrdersInfo.FK_BRBranchID);
                        }
                        else
                        {
                            objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                        }
                        if (objStocksInfo != null)
                        {
                            objCancelVoucherItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                        }

                        entity.CancelPurchaseOrderItemList.Add(objCancelVoucherItemsInfo);
                    }
                }
                entity.CancelPurchaseOrderItemList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        ///// <summary>
        ///// Check whether the canceled quantity is valid
        ///// </summary>
        ///// <param name="canceledQty">Canceled quantity</param>
        ///// <returns>True if the canceled quantity is valid, otherwise false</returns>
        public bool IsValidCanceledQty(APCancelPurchaseOrderItemsInfo item, decimal qty)
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = new APPurchaseOrderItemsInfo();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemForCheckingCancelPurchaseValidQty(item.FK_APPurchaseOrderItemID, item.APCancelPurchaseOrderItemID);
            decimal remainQty = 0;
            if (purchaseOrderItemList != null && purchaseOrderItemList.Count > 0)
            {
                remainQty = purchaseOrderItemList.Sum(i => i.APPurchaseOrderItemRemainedQty);
            }
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                {

                    remainQty = Math.Round(remainQty, 4, MidpointRounding.AwayFromZero);
                    qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
                }
                else
                {

                    remainQty = Math.Round(remainQty, 2, MidpointRounding.AwayFromZero);
                    qty = Math.Round(qty, 2, MidpointRounding.AwayFromZero);
                }
            }

            if (qty > remainQty)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Called when user changes the discount percent of the cancel voucher
        /// </summary>
        public void ChangeDiscountPercent()
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user changes the discount amount of the cancel voucher
        /// </summary>
        public void ChangeDiscountAmount()
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelVoucherInfo = (APCancelPurchaseOrdersInfo)entity.MainObject;
            //if (objCancelVoucherInfo.APCancelPurchaseOrderSubTotalAmount > 0)
            //    objCancelVoucherInfo.APCancelPurchaseOrderDiscountPerCent = objCancelVoucherInfo.APCancelPurchaseOrderDiscountFix / objCancelVoucherInfo.APCancelPurchaseOrderSubTotalAmount * 100;
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user changes the tax percent of the cancel voucher
        /// </summary>
        public void ChangeTaxPercent()
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user changes the tax amount of the cancel voucher
        /// </summary>
        public void ChangeTaxAmount()
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelVoucherInfo = (APCancelPurchaseOrdersInfo)entity.MainObject;
            //if (objCancelVoucherInfo.APCancelPurchaseOrderSubTotalAmount - objCancelVoucherInfo.APCancelPurchaseOrderDiscountFix > 0)
            //    objCancelVoucherInfo.APCancelPurchaseOrderTaxPercent = objCancelVoucherInfo.APCancelPurchaseOrderTaxAmount / 
            //                                                    (objCancelVoucherInfo.APCancelPurchaseOrderSubTotalAmount - objCancelVoucherInfo.APCancelPurchaseOrderDiscountFix) * 100;
            UpdateTotalAmount();
        }

        /// <summary>
        /// No need to lock cancel voucher, the function will override the
        /// base behaviour and return false all the time
        /// </summary>
        /// <returns></returns>
        protected override bool IsTransactionLocked()
        {
            return false;
        }

        public override void InvalidateToolbar()
        {
            APCancelPurchaseOrdersInfo objReceiptsInfo = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo.APCancelPurchaseOrderID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);

                if (objReceiptsInfo.APCancelPurchaseOrderStatus == CancelPurchaseOrderStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);

                }
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.MainObject;
            objCancelPurchaseOrdersInfo.MMBatchProductSOName = string.Join(", ", entity.CancelPurchaseOrderItemList.Where(o => !string.IsNullOrWhiteSpace(o.MMBatchProductSOName)).Select(o => o.MMBatchProductSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
            CancelPurchaseOrderItemsGridControl.LoadGridViewForRoundWood(objCancelPurchaseOrdersInfo.APCancelPurchaseOrderType);
            FormatCaptionOfQuantityColumnItemlist();
        }

        public void ChangeObject(string objectAccessKey)
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)CurrentModuleEntity.MainObject;
            objCancelPurchaseOrdersInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objCancelPurchaseOrdersInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objCancelPurchaseOrdersInfo.APObjectType = objObjectsInfo.ACObjectType;
                objCancelPurchaseOrdersInfo.ACObjectName = objObjectsInfo.ACObjectName;
            }
        }

        public override bool ActionComplete()
        {
            bool isComplete = false;
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;

            APCancelPurchaseOrderItemsController objCancelPurchaseOrderItemsController = new APCancelPurchaseOrderItemsController();
            entity.CancelPurchaseOrderItemList.ForEach(o =>
            {
                decimal checkQuantity = objCancelPurchaseOrderItemsController.GetAllowCancelQty(o.FK_APPurchaseOrderItemID, o.APCancelPurchaseOrderItemID);

                if (o.APCancelPurchaseOrderItemProductQty > checkQuantity)
                {
                    MessageBox.Show(CancelPurchaseOrderLocalizedResources.ApproveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isComplete = true;
                }
            });

            string purchaseOrderIDs = string.Join(",", entity.CancelPurchaseOrderItemList.Select(o1 => o1.FK_APPurchaseOrderID.ToString()).Distinct().ToArray());
            APPOPaymentTimeInvoiceInDetailsController objPaymentsController = new APPOPaymentTimeInvoiceInDetailsController();
            List<APPOPaymentTimeInvoiceInDetailsInfo> paymentsList = objPaymentsController.GetUsedPaymentByPurchaseOrdersList(purchaseOrderIDs);
            if (paymentsList.Count() > 0)
            {
                XtraMessageBox.Show("Bạn vui lòng xóa các chứng từ ĐNTT này trước khi hoàn tất"
                                     + Environment.NewLine + "-"
                                     + string.Join(Environment.NewLine + "*", paymentsList.Select(o => o.PaymentProposalNo).ToArray())
                                    , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isComplete)
                isComplete = base.ActionComplete();
            if (isComplete)
            {
                MessageBox.Show(CancelPurchaseOrderLocalizedResources.UpdatePurchaseOrderInfoMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                //entity.CancelPurchaseOrderItemList.ForEach(o =>
                //{
                //    APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                //    APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(o.FK_APPurchaseOrderItemID);
                //    APProposalItemsController objProposalItemsController = new APProposalItemsController();
                //    APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(objPurchaseOrderItemsInfo.FK_APProposalItemID);
                //    if (objProposalItemsInfo != null)
                //    {
                //        objProposalItemsInfo.APProposalItemCanceledQty = o.APCancelPurchaseOrderItemProductQty;
                //        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                //    }
                //});
            }
            List<string> OrderListID = entity.CancelPurchaseOrderItemList.Where(p => p.FK_APPurchaseOrderID > 0).Select(p => p.FK_APPurchaseOrderID.ToString()).Distinct().ToList();
            if (OrderListID != null && OrderListID.Count > 0)
                (new APPurchaseOrdersController()).UpdateCanceledPurchaseOrderStatus(string.Join(",", OrderListID.ToArray())
                                                                     , BOSApp.CurrentUsersInfo.ADUserName);
            return isComplete;
        }

        public void FormatCaptionOfQuantityColumnItemlist()
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;

            APCancelPurchaseOrderItemsInfo objCancelPurchaseOrderItemsInfo = entity.CancelPurchaseOrderItemList.FirstOrDefault(o1 => o1.FK_APPurchaseOrderID != 0);
            if (objCancelPurchaseOrderItemsInfo != null)
            {
                APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objCancelPurchaseOrderItemsInfo.FK_APPurchaseOrderID);
                if (objPurchaseOrdersInfo != null)
                {
                    List<string> lumberGroups = new List<string>() { PurchaseOrderReceiptType.Lumber.ToString(),
                                                            PurchaseOrderReceiptType.Roundwood.ToString()};

                    if (CancelPurchaseOrderItemsGridControl != null)
                    {
                        GridView gridView = (GridView)CancelPurchaseOrderItemsGridControl.MainView;
                        if (gridView != null)
                        {
                            GridColumn qtyColumn = gridView.Columns["APCancelPurchaseOrderItemProductQty"];
                            if (lumberGroups.Contains(objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo))
                            {
                                if (qtyColumn != null)
                                {
                                    qtyColumn.Caption = "Khối lượng hủy";
                                }
                            }
                            else
                            {
                                if (qtyColumn != null)
                                {
                                    qtyColumn.Caption = "Số lượng hủy";
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
