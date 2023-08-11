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

namespace BOSERP.Modules.CancelVoucher
{
    public class CancelVoucherModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ARCancelVoucherItemsGridControlName = "fld_dgcARCancelVoucherItems";
        public const string ProductPicturePictureBoxName = "fld_pteARCancelVoucherItemProductPicture";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        private BOSPictureEdit ProductPicturePictureBox;
        public ARCancelVoucherItemsGridControl ARCancelVoucherItemsGridcontrol { get; set; }
        #endregion

        #region Constructor
        public CancelVoucherModule()
        {
            Name = "CancelVoucher";
            CurrentModuleEntity = new CancelVoucherEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CancelVoucherModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            ARCancelVoucherItemsGridcontrol = (ARCancelVoucherItemsGridControl)Controls[ARCancelVoucherItemsGridControlName];
            StartGettingInventoryThread();
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARCancelVouchersInfo searchObject = (ARCancelVouchersInfo)CurrentModuleEntity.SearchObject;
            ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objCancelVouchersController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objCancelVouchersController.GetCancelVoucherListDatasetByListOfBranchID(
                                                                searchObject.ARCancelVoucherNo,
                                                                searchObject.ARSaleOrderNo,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.CancelVoucherDateFrom,
                                                                searchObject.CancelVoucherDateTo,
                                                                BranchList);
                }
            }
            else
            {
                ds = objCancelVouchersController.GetCancelVoucherListDataset(
                                                                searchObject.ARCancelVoucherNo,
                                                                searchObject.ARSaleOrderNo,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.CancelVoucherDateFrom,
                                                                searchObject.CancelVoucherDateTo,
                                                                searchObject.FK_BRBranchID);
            }

            return ds;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
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

        #region Methods
        public override void ActionNew()
        {
            base.ActionNew();
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saleOrderItemList = new List<ARSaleOrderItemsInfo>();
            guiChooseSaleOrderItems guiFind = new guiChooseSaleOrderItems();
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARSaleOrderItemsInfo> saleOrderItems = (List<ARSaleOrderItemsInfo>)guiFind.SelectedObjects;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(saleOrderItems.FirstOrDefault().FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                //Generate cancel voucher from sale order
                GenerateCancelVoucherFromSaleOrder(objSaleOrdersInfo);

                //Generate cancel voucher item from sale
                GenerateCancelVoucherItemFromSaleOrder(objSaleOrdersInfo, saleOrderItems);

                entity.InvalidateSaleOrderPaymentTimesList();
                UpdateTotalAmount();
                ARCancelVoucherItemsGridcontrol.LoadGridViewByProductType(mainObject.ARCancelVoucherID);
            }
        }

        public override bool ActionComplete()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;
            ARCancelVoucherItemsInfo cancelVoucherItem;
            for (int i = 0; i < entity.CancelVoucherItemList.Count; i++)
            {
                cancelVoucherItem = entity.CancelVoucherItemList[i];
                if (!CheckValidQty(i, entity.CancelVoucherItemList[i].ARCancelVoucherItemProductQty))
                {
                    return false;
                }
            }

            bool isCompleted = base.ActionComplete();
            if (isCompleted)
            {
                entity.CancelVoucherItemList.BackupList.Clear();
                foreach (ARCancelVoucherItemsInfo objCancelVoucherItemsInfo in entity.CancelVoucherItemList)
                {
                    entity.CancelVoucherItemList.BackupList.Add((ARCancelVoucherItemsInfo)objCancelVoucherItemsInfo.Clone());
                }
            }
            return isCompleted;
        }

        public override void InvalidateToolbar()
        {
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)CurrentModuleEntity.MainObject;
            if (objCancelVouchersInfo.ARCancelVoucherID > 0)
            {
                if (objCancelVouchersInfo.ARCancelVoucherStatus == CancelVoucherStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }
            base.InvalidateToolbar();
        }

        public override int ActionSave()
        {
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrWhiteSpace(mainObject.ARCancelVoucherDesc))
            {
                MessageBox.Show("Vui lòng nhập Ghi chú trước khi lưu!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            if (string.IsNullOrWhiteSpace(mainObject.ARCancelVoucherReason))
            {
                MessageBox.Show("Vui lòng chọn Lý do hủy trước khi lưu!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            return base.ActionSave();
        }
        /// <summary>
        ///  Change item from cancel voucher item list
        /// </summary>
        public void ChangeItemFromCancelVoucherItemList()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVoucherItemsInfo objCancelVoucherItemsInfo = (ARCancelVoucherItemsInfo)entity.ModuleObjects[TableName.ARCancelVoucherItemsTableName];
            entity.SetProductPriceByProductUnitPrice();
            entity.CancelVoucherItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Delete item from cancel voucher item list
        /// </summary>
        public void DeleteItemFromCancelVoucherItemList()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            entity.CancelVoucherItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void DeleteItemFromCancelVoucherItemCostList()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            entity.CancelVoucherItemCostList.RemoveSelectedRowObjectFromList();
            entity.CancelVoucherItemCostList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Update the total amounts of the cancel voucher
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Init cancel voucher report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        private void InitCancelVoucherReport(XtraReport report)
        {
            ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetCancelVoucherItemByCacelVoucherID(Toolbar.CurrentObjectID);
            if (ds.Tables.Count > 0)
            {
                ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCancelVoucherItemsInfo objCancelVoucherItemsInfo = (ARCancelVoucherItemsInfo)objCancelVoucherItemsController.GetObjectFromDataRow(row);
                    objCancelVoucherItemsInfo.ARCancelVoucherItemComment = string.Empty;
                    if (objCancelVoucherItemsInfo.ARCancelVoucherItemProductDiscount > 0)
                    {
                        objCancelVoucherItemsInfo.ARCancelVoucherItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelVoucherLocalizedResources.Discount,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelVoucherItemsInfo.ARCancelVoucherItemProductDiscount,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    if (objCancelVoucherItemsInfo.ARCancelVoucherItemProductTaxPercent > 0)
                    {
                        objCancelVoucherItemsInfo.ARCancelVoucherItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelVoucherLocalizedResources.VAT,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelVoucherItemsInfo.ARCancelVoucherItemProductTaxPercent,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    row["ARCancelVoucherItemComment"] = objCancelVoucherItemsInfo.ARCancelVoucherItemComment;

                    objCancelVoucherItemsInfo.ARCancelVoucherItemProductDesc += string.Format(" {0} / {1}", objCancelVoucherItemsInfo.ARCancelVoucherItemProductSerialNo, objCancelVoucherItemsInfo.ARCancelVoucherItemProductSupplierNo);
                    row["ARCancelVoucherItemProductDesc"] = objCancelVoucherItemsInfo.ARCancelVoucherItemProductDesc;
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
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)objCancelVouchersController.GetObjectByID(Toolbar.CurrentObjectID);
            if (objCancelVouchersInfo.ARCancelVoucherDiscountFix == 0)
            {
                XRPanel discountPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlDiscount"];
                if (discountPanel != null)
                {
                    discountPanel.Visible = false;
                }
            }

            if (objCancelVouchersInfo.ARCancelVoucherTaxAmount == 0)
            {
                XRPanel taxPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlVAT"];
                if (taxPanel != null)
                {
                    taxPanel.Visible = false;
                }
            }
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
        public void GenerateCancelVoucherFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo objOldCancelVouchersInfo = (ARCancelVouchersInfo)entity.MainObject.Clone();
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)entity.MainObject;
            BOSUtil.CopyObject(objSaleOrdersInfo, objCancelVouchersInfo);
            objCancelVouchersInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
            objCancelVouchersInfo.ARObjectType = objSaleOrdersInfo.ARObjectType;
            objCancelVouchersInfo.FK_ACObjectID = objSaleOrdersInfo.FK_ACObjectID;
            objCancelVouchersInfo.ACObjectAccessKey = objSaleOrdersInfo.FK_ACObjectID + ";" + objSaleOrdersInfo.ARObjectType;
            objCancelVouchersInfo.FK_PMProjectID = objSaleOrdersInfo.FK_PMProjectID;
            objCancelVouchersInfo.FK_ARSaleContractID = objSaleOrdersInfo.FK_ARSaleContractID;
            objCancelVouchersInfo.FK_ACCostCenterID = objSaleOrdersInfo.FK_ACCostCenterID;
            objCancelVouchersInfo.ARCancelVoucherType = objSaleOrdersInfo.ARSaleOrderProductType;
            objCancelVouchersInfo.ARCancelVoucherProject = objSaleOrdersInfo.ARSaleOrderProject;
            objCancelVouchersInfo.ARCancelVoucherSaleContract = objSaleOrdersInfo.ARSaleOrderSaleContract;

            //Restore some its own properties
            objCancelVouchersInfo.FK_BRBranchID = objOldCancelVouchersInfo.FK_BRBranchID;
            objCancelVouchersInfo.FK_HREmployeeID = objOldCancelVouchersInfo.FK_HREmployeeID;
            objCancelVouchersInfo.ARCancelVoucherNo = objOldCancelVouchersInfo.ARCancelVoucherNo;
            objCancelVouchersInfo.ARCancelVoucherDate = objOldCancelVouchersInfo.ARCancelVoucherDate;
            objCancelVouchersInfo.ARCancelVoucherDesc = objOldCancelVouchersInfo.ARCancelVoucherDesc;
            objCancelVouchersInfo.ARCancelVoucherEmployeePicture = objOldCancelVouchersInfo.ARCancelVoucherEmployeePicture;
            objCancelVouchersInfo.ARCancelVoucherStatus = objOldCancelVouchersInfo.ARCancelVoucherStatus;
            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Generate cancel voucher item from sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Info of sale order</param>
        public void GenerateCancelVoucherItemFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo, List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;

            ARSaleOrderItemWorksController objSaleOrderItemWorksController = new ARSaleOrderItemWorksController();
            List<ARSaleOrderItemWorksInfo> saleOrderItemCostList = new List<ARSaleOrderItemWorksInfo>();

            List<ARCancelVoucherItemCostsInfo> cancelVoucherItemCostList = new List<ARCancelVoucherItemCostsInfo>();
            List<ARCancelVoucherItemCostsInfo> cancelVoucherItemCostSubList = new List<ARCancelVoucherItemCostsInfo>();

            if (saleOrderItems == null && saleOrderItems.Count() > 0)
                return;

            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in saleOrderItems)
            {
                ARCancelVoucherItemsInfo objCancelVoucherItemsInfo = new ARCancelVoucherItemsInfo();
                BOSUtil.CopyObject(objSaleOrderItemsInfo, objCancelVoucherItemsInfo);
                objCancelVoucherItemsInfo.ARCancelVoucherItemOrderedQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                objCancelVoucherItemsInfo.ARCancelVoucherItemTotalQty = objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty;
                objCancelVoucherItemsInfo.ARCancelVoucherItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty;
                objCancelVoucherItemsInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                objCancelVoucherItemsInfo.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;

                objCancelVoucherItemsInfo.ARCancelVoucherItemOrderedQty = objCancelVoucherItemsInfo.ARCancelVoucherItemOrderedQty;
                objCancelVoucherItemsInfo.ARCancelVoucherItemTotalQty = objCancelVoucherItemsInfo.ARCancelVoucherItemTotalQty;
                objCancelVoucherItemsInfo.ARCancelVoucherItemProductQty = objCancelVoucherItemsInfo.ARCancelVoucherItemProductQty;

                //Set sale order stock
                ICStocksController objStockController = new ICStocksController();
                ICStocksInfo objStocksInfo = null;
                if (objSaleOrdersInfo.FK_BRBranchID > 0)
                {
                    objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), objSaleOrdersInfo.FK_BRBranchID);
                }
                else
                {
                    objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                }
                if (objStocksInfo != null)
                {
                    objCancelVoucherItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                }
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objCancelVoucherItemsInfo.ARCancelVoucherItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                    objCancelVoucherItemsInfo.ARCancelVoucherItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                }

                saleOrderItemCostList = objSaleOrderItemWorksController.GetSaleOrderItemWorksBySaleOrderItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                cancelVoucherItemCostSubList = ToVoucherItemCostListFromSaleOrderItemCostList(saleOrderItemCostList);
                if (cancelVoucherItemCostSubList.Count() > 0)
                    cancelVoucherItemCostList.AddRange(cancelVoucherItemCostSubList);

                entity.SetProductPriceByProductUnitPrice(objCancelVoucherItemsInfo);
                entity.CancelVoucherItemList.Add(objCancelVoucherItemsInfo);
            }
            entity.CancelVoucherItemCostList.Invalidate(cancelVoucherItemCostList);

            entity.CancelVoucherItemList.GridControl.RefreshDataSource();
            entity.CancelVoucherItemCostList.GridControl.RefreshDataSource();
        }

        public List<ARCancelVoucherItemCostsInfo> ToVoucherItemCostListFromSaleOrderItemCostList(List<ARSaleOrderItemWorksInfo> saleOrderItemCostList)
        {
            List<ARCancelVoucherItemCostsInfo> cancelVoucherItemCostList = new List<ARCancelVoucherItemCostsInfo>();
            ARCancelVoucherItemCostsInfo objCancelVoucherItemCostsInfo = new ARCancelVoucherItemCostsInfo();
            saleOrderItemCostList.ForEach(o =>
            {
                objCancelVoucherItemCostsInfo = new ARCancelVoucherItemCostsInfo();
                objCancelVoucherItemCostsInfo = ToCancelVoucherItemCostFromSaleOrderItemCost(o);
                cancelVoucherItemCostList.Add(objCancelVoucherItemCostsInfo);
            });
            return cancelVoucherItemCostList;
        }

        public ARCancelVoucherItemCostsInfo ToCancelVoucherItemCostFromSaleOrderItemCost(ARSaleOrderItemWorksInfo objSaleOrderItemWorksInfo)
        {
            return new ARCancelVoucherItemCostsInfo()
            {
                FK_ARSaleOrderID = objSaleOrderItemWorksInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemWorkID = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkID,
                FK_ICDepartmentID = objSaleOrderItemWorksInfo.FK_ICDepartmentID,
                FK_ICMeasureUnitID = objSaleOrderItemWorksInfo.FK_ICMeasureUnitID,
                FK_ICProductID = objSaleOrderItemWorksInfo.FK_ICProductID,
                FK_ICProductGroupID = objSaleOrderItemWorksInfo.FK_ICProductGroupID,
                ARCancelVoucherItemCostProductNo = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductNo,
                ARCancelVoucherItemCostProductName = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductName,
                ARCancelVoucherItemCostProductDesc = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductDesc,
                ARCancelVoucherItemCostProductQty = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductQty,
                ARCancelVoucherItemCostProductCanceledQty = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkCancelQty,
                ARCancelVoucherItemCostProductCancelQty = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductQty - objSaleOrderItemWorksInfo.ARSaleOrderItemWorkCancelQty,
                ARCancelVoucherItemCostProductType = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductType,
                ARCancelVoucherItemCostProductUnitPrice = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductUnitPrice,
                ARCancelVoucherItemCostComment = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkComment,
                ARCancelVoucherItemCostSubTotalAmount = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkSubTotalAmount,
                ARCancelVoucherItemCostDiscountPercent = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkDiscountPerCent,
                ARCancelVoucherItemCostDiscountAmount = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkDiscountAmount,
                ARCancelVoucherItemCostTotalAmount = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkTotalAmount,
                ARCancelVoucherItemCostIsCharge = objSaleOrderItemWorksInfo.ARSaleOrderItemWorkProductChargeCheck
            };
        }
        #endregion

        /// <summary>
        /// Check whether the canceled quantity is valid
        /// </summary>
        /// <param name="canceledQty">Canceled quantity</param>
        /// <returns>True if the canceled quantity is valid, otherwise false</returns>
        public bool IsValidCanceledQty(decimal canceledQty)
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVoucherItemsInfo objCancelVoucherItemsInfo = (ARCancelVoucherItemsInfo)CurrentModuleEntity.ModuleObjects[TableName.ARCancelVoucherItemsTableName];
            ARCancelVoucherItemsInfo objOldCancelVoucherItemsInfo = entity.CancelVoucherItemList.BackupList.Where(i => i.ARCancelVoucherItemID == objCancelVoucherItemsInfo.ARCancelVoucherItemID).FirstOrDefault();
            decimal oldCanceledQty = 0;
            if (objOldCancelVoucherItemsInfo != null)
            {
                oldCanceledQty = objOldCancelVoucherItemsInfo.ARCancelVoucherItemProductQty;
                oldCanceledQty = Math.Round(oldCanceledQty, 4, MidpointRounding.AwayFromZero);
            }

            if (canceledQty > objCancelVoucherItemsInfo.ARCancelVoucherItemOrderedQty - (objCancelVoucherItemsInfo.ARCancelVoucherItemTotalQty - oldCanceledQty))
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
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo objCancelVoucherInfo = (ARCancelVouchersInfo)entity.MainObject;
            if (objCancelVoucherInfo.ARCancelVoucherSubTotalAmount > 0)
                objCancelVoucherInfo.ARCancelVoucherDiscountPerCent = objCancelVoucherInfo.ARCancelVoucherDiscountFix / objCancelVoucherInfo.ARCancelVoucherSubTotalAmount * 100;
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
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo objCancelVoucherInfo = (ARCancelVouchersInfo)entity.MainObject;
            if (objCancelVoucherInfo.ARCancelVoucherSubTotalAmount - objCancelVoucherInfo.ARCancelVoucherDiscountFix > 0)
                objCancelVoucherInfo.ARCancelVoucherTaxPercent = objCancelVoucherInfo.ARCancelVoucherTaxAmount /
                                                                (objCancelVoucherInfo.ARCancelVoucherSubTotalAmount - objCancelVoucherInfo.ARCancelVoucherDiscountFix) * 100;
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

        public bool CheckValidQty(int index, decimal qty)
        {
            bool isValid = true;
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARSaleOrderItemsController saleOrderItemsController = new ARSaleOrderItemsController();
            if (index <= entity.CancelVoucherItemList.Count)
            {
                ARCancelVoucherItemsInfo item = entity.CancelVoucherItemList[index];
                if (item != null)
                {
                    List<ARSaleOrderItemsInfo> saleOrderItemsList = saleOrderItemsController.GetSaleOrderItemForCheckingCancelVoucherValidQty(item.FK_ARSaleOrderItemID, item.ARCancelVoucherItemID);
                    decimal remainQty = 0;
                    if (saleOrderItemsList != null && saleOrderItemsList.Count > 0)
                    {
                        remainQty = saleOrderItemsList.Sum(i => i.ARSaleOrderItemRemainedQty);
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
                            remainQty = Math.Round(remainQty, 3, MidpointRounding.AwayFromZero);
                            qty = Math.Round(qty, 3, MidpointRounding.AwayFromZero);
                        }
                    }

                    if (qty > remainQty)
                    {
                        MessageBox.Show(item.ARCancelVoucherItemProductDesc + " có số lượng hủy không hợp lệ. Số lượng có thể hủy: " + remainQty, "#message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        isValid = false;
                    }
                }

            }

            return isValid;
        }
        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARCancelVoucherItemsInfo item in entity.CancelVoucherItemList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            entity.UpdateTotalAmount();
            entity.CancelVoucherItemList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string objectAccessKey)
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)CurrentModuleEntity.MainObject;
            objCancelVouchersInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)

                objCancelVouchersInfo.ACObjectName = objObjectsInfo.ACObjectName;
            if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                objCancelVouchersInfo.FK_ARCustomerID = objObjectsInfo.ACObjectID;
        }

        public string GetAttributeText(string productAttributeRefence)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributeByProductAttributeReferenceByCharater(productAttributeRefence, ",");
            if (productAttributeList == null)
                productAttributeList = new List<ICProductAttributesInfo>();
            return string.Join(", ", productAttributeList.Select(o => o.ICProductAttributeNo).ToArray());
        }

        public void ShowChooseItemWork()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainobject = (ARCancelVouchersInfo)CurrentModuleEntity.MainObject;
            List<string> saleOrderWorkRefList = entity.CancelVoucherItemCostList.Select(o => o.FK_ARSaleOrderItemWorkID.ToString()).Distinct().ToList();
            ARSaleOrderItemWorksController objSaleOrderItemWorksController = new ARSaleOrderItemWorksController();
            List<ARSaleOrderItemWorksInfo> saleOrderItemWorkList = objSaleOrderItemWorksController.GetSaleOrderItemWorkBySaleOrderID(mainobject.FK_ARSaleOrderID, string.Join(",", saleOrderWorkRefList.ToArray()));

            guiChooseSaleOrderItemWorks guiFind = new guiChooseSaleOrderItemWorks(saleOrderItemWorkList);
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            saleOrderItemWorkList = guiFind.SelectedObjects;
            ARCancelVoucherItemCostsInfo objCancelVoucherItemCostsInfo = new ARCancelVoucherItemCostsInfo();
            List<ARCancelVoucherItemCostsInfo> cancelVoucherItemCostList = new List<ARCancelVoucherItemCostsInfo>();
            saleOrderItemWorkList.ForEach(o =>
            {
                objCancelVoucherItemCostsInfo = new ARCancelVoucherItemCostsInfo();
                objCancelVoucherItemCostsInfo = ToCancelVoucherItemCostFromSaleOrderItemCost(o);
                cancelVoucherItemCostList.Add(objCancelVoucherItemCostsInfo);
            });
            entity.CancelVoucherItemCostList.AddRange(cancelVoucherItemCostList);
            entity.CancelVoucherItemCostList.GridControl.RefreshDataSource();
        }

        public bool CheckValidCostQty(ARCancelVoucherItemCostsInfo objCancelVoucherItemCostsInfo)
        {
            bool isValid = true;
            if (objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductCancelQty > objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductQty - objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductCanceledQty)
            {
                MessageBox.Show(string.Format(CancelVoucherLocalizedResources.ErrorQtyMessage, (objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductQty - objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductCanceledQty).ToString("n3"))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }

        public void ChangeItemCostTotalAmount()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVoucherItemCostsInfo objCancelVoucherItemCostsInfo = entity.CancelVoucherItemCostList[entity.CancelVoucherItemCostList.CurrentIndex];
            if (objCancelVoucherItemCostsInfo == null)
                return;
            decimal totalPrice = objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductCancelQty * objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostProductUnitPrice;
            objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostDiscountAmount = totalPrice * objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostDiscountPercent;
            objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostTotalAmount = totalPrice - objCancelVoucherItemCostsInfo.ARCancelVoucherItemCostDiscountAmount;
            entity.CancelVoucherItemCostList.GridControl.RefreshDataSource();
        }

        public List<PMProjectsInfo> GetProjectByObjectID()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(mainObject.ACObjectAccessKey);
            if (objObjectsInfo == null)
                return null;
            PMProjectsController objProjectsController = new PMProjectsController();
            return objProjectsController.GetAllProjectForLookupByAcobjectIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
        }

        public List<ARSaleContractsInfo> GetSaleContractByObjectIDAnProjectID()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(mainObject.ACObjectAccessKey);
            if (objObjectsInfo == null)
                return null;

            ARSaleContractsController controller = new ARSaleContractsController();
            return controller.GetSaleContractByObjectIDAnProjectID(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, mainObject.FK_PMProjectID);
        }

        public override void ModuleAfterCompleted()
        {
            CancelVoucherEntities entity = (CancelVoucherEntities)CurrentModuleEntity;
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.ARCancelVoucherID, ModulePostingType.Allocation, ModulePostingType.SaleOrder, ModulePostingType.InvoiceTrans);
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ARCancelVoucherItemsGridcontrol.LoadGridViewByProductType(iObjectID);
        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }
    }
}
