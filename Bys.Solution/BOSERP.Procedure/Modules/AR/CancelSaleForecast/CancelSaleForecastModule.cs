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

namespace BOSERP.Modules.CancelSaleForecast
{
    public class CancelSaleForecastModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ProductPicturePictureBoxName = "fld_pteARCancelSaleForecastItemProductPicture";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        private BOSPictureEdit ProductPicturePictureBox;
        #endregion

        #region Constructor
        public CancelSaleForecastModule()
        {
            Name = "CancelSaleForecast";
            CurrentModuleEntity = new CancelSaleForecastEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
        }
        #endregion

        #region Methods
        public override void ActionNew()
        {
            base.ActionNew();

            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ARSaleOrdersInfo> saleOrderList = objSaleOrdersController.GetSaleOrdersForCanceling();
            List<ARSaleForecastsInfo> saleForecastList = objSaleForecastsController.GetSaleForecastsForCancelingByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                    ModuleName.SaleForecast,
                                                                                                                    ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            guiFind<ARSaleForecastsInfo> guiFind = new guiFind<ARSaleForecastsInfo>(TableName.ARSaleForecastsTableName, saleForecastList, this);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                int saleForecastID = Convert.ToInt32(guiFind.Tag.ToString());
                ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByID(saleForecastID);
                if (objSaleForecastsInfo != null)
                {
                    //Generate cancel voucher from sale order
                    GenerateCancelSaleForecastFromSaleForecast(objSaleForecastsInfo);

                    //Generate cancel voucher item from sale
                    GenerateCancelSaleForecastItemFromSaleForecast(objSaleForecastsInfo);

                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();

        }

        public override int ActionSave()
        {
            int cancelSaleForecastID = base.ActionSave();
            if (cancelSaleForecastID > 0)
            {
                CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
                entity.CancelSaleForecastItemList.BackupList.Clear();
                foreach (ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo in entity.CancelSaleForecastItemList)
                {
                    entity.CancelSaleForecastItemList.BackupList.Add((ARCancelSaleForecastItemsInfo)objCancelSaleForecastItemsInfo.Clone());
                }
            }
            return cancelSaleForecastID;
        }

        public override bool ActionComplete()
        {
            bool isCompleted = base.ActionComplete();
            if (isCompleted)
            {
                CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
                entity.ComponentCancelSaleForecastItemList.BackupList.Clear();
                foreach (ARCancelSaleForecastItemsInfo item in entity.ComponentCancelSaleForecastItemList)
                {
                    entity.ComponentCancelSaleForecastItemList.BackupList.Add((ARCancelSaleForecastItemsInfo)item.Clone());
                }
            }

            return isCompleted;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPCancelVoucher report = new RPCancelVoucher();
                InitCancelSaleForecastReport(report);
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }
        private void InitCancelSaleForecastReport(XtraReport report)
        {
            ARCancelSaleForecastsController objCancelSaleForecastsController = new ARCancelSaleForecastsController();
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetCancelSaleForecastItemByCacelSaleForecastID(Toolbar.CurrentObjectID);
            if (ds.Tables.Count > 0)
            {
                ARCancelSaleForecastItemsController objCancelSaleForecastItemsController = new ARCancelSaleForecastItemsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = (ARCancelSaleForecastItemsInfo)objCancelSaleForecastItemsController.GetObjectFromDataRow(row);
                    objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemComment = string.Empty;
                    if (objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductDiscount > 0)
                    {
                        objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelSaleForecastLocalizedResources.Discount,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductDiscount,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    if (objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductTaxPercent > 0)
                    {
                        objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemComment += string.Format(" {0}: {1}%;",
                                                                                            CancelSaleForecastLocalizedResources.VAT,
                                                                                            BOSUtil.GetNumberDisplayFormat(
                                                                                                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductTaxPercent,
                                                                                                                FormatGroupAttribute.cstFormatGroupPercent));
                    }
                    row["ARCancelSaleForecastItemComment"] = objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemComment;

                    objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductDesc += string.Format(" {0} / {1}", objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductSerialNo, objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductSupplierNo);
                    row["ARCancelSaleForecastItemProductDesc"] = objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductDesc;
                }
            }
            report.DataSource = ds;
            report.DataMember = BOSCommon.Constants.Report.DevCancelSaleForecastReportName;
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
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)objCancelSaleForecastsController.GetObjectByID(Toolbar.CurrentObjectID);
            if (objCancelSaleForecastsInfo.ARCancelSaleForecastDiscountFix == 0)
            {
                XRPanel discountPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlDiscount"];
                if (discountPanel != null)
                {
                    discountPanel.Visible = false;
                }
            }

            if (objCancelSaleForecastsInfo.ARCancelSaleForecastTaxAmount == 0)
            {
                XRPanel taxPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlVAT"];
                if (taxPanel != null)
                {
                    taxPanel.Visible = false;
                }
            }
        }
        public void DeleteItemFromCancelSaleForecastItemList()
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            entity.CancelSaleForecastItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        #endregion Methods

        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            ARCancelSaleForecastsController cancelSaleForecastController = new ARCancelSaleForecastsController();
            ARCancelSaleForecastsInfo searchObject = (ARCancelSaleForecastsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = cancelSaleForecastController.GetCancelSaleForecastsBySomeCriteria(
                                                                        searchObject.ARCancelSaleForecastNo,
                                                                        searchObject.FK_ARSaleForecastID,
                                                                        searchObject.FK_ARCustomerID,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.FK_BRBranchID,
                                                                        searchObject.ARCancelSaleForecastDateFrom,
                                                                        searchObject.ARCancelSaleForecastDateTo);


            return ds;
        }

        public void GenerateCancelSaleForecastFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo)
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            ARCancelSaleForecastsInfo objOldCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)entity.MainObject.Clone();
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)entity.MainObject;
            BOSUtil.CopyObject(objSaleForecastsInfo, objCancelSaleForecastsInfo);
            objCancelSaleForecastsInfo.FK_ARSaleForecastID = objSaleForecastsInfo.ARSaleForecastID;

            //Restore some its own properties
            objCancelSaleForecastsInfo.FK_BRBranchID = objOldCancelSaleForecastsInfo.FK_BRBranchID;
            objCancelSaleForecastsInfo.FK_HREmployeeID = objOldCancelSaleForecastsInfo.FK_HREmployeeID;
            objCancelSaleForecastsInfo.ARCancelSaleForecastNo = objOldCancelSaleForecastsInfo.ARCancelSaleForecastNo;
            objCancelSaleForecastsInfo.ARCancelSaleForecastDate = objOldCancelSaleForecastsInfo.ARCancelSaleForecastDate;
            objCancelSaleForecastsInfo.ARCancelSaleForecastDesc = objOldCancelSaleForecastsInfo.ARCancelSaleForecastDesc;
            objCancelSaleForecastsInfo.ARCancelSaleForecastEmployeePicture = objOldCancelSaleForecastsInfo.ARCancelSaleForecastEmployeePicture;
            objCancelSaleForecastsInfo.ARCancelSaleForecastType = objOldCancelSaleForecastsInfo.ARCancelSaleForecastType;
            objCancelSaleForecastsInfo.ARCancelSaleForecastStatus = objOldCancelSaleForecastsInfo.ARCancelSaleForecastStatus;
            entity.UpdateMainObjectBindingSource();
        }

        public void GenerateCancelSaleForecastItemFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo)
        {

            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            DataSet ds = objSaleForecastItemsController.GetAllDataByForeignColumn("FK_ARSaleForecastID", objSaleForecastsInfo.ARSaleForecastID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ARSaleForecastItemsInfo objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectFromDataRow(dr);
                    decimal canceledQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty - objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty - objSaleForecastItemsInfo.ARSaleForecastItemCanceledQty;
                    if (canceledQty > 0)
                    {
                        ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = new ARCancelSaleForecastItemsInfo();
                        BOSUtil.CopyObject(objSaleForecastItemsInfo, objCancelSaleForecastItemsInfo);
                        objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty;
                        objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty = objSaleForecastItemsInfo.ARSaleForecastItemCanceledQty;
                        objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty = canceledQty;
                        objCancelSaleForecastItemsInfo.FK_ARSaleForecastID = objSaleForecastsInfo.ARSaleForecastID;
                        objCancelSaleForecastItemsInfo.FK_ARSaleForecastItemID = objSaleForecastItemsInfo.ARSaleForecastItemID;

                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleForecastItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                            {
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty, 4, MidpointRounding.AwayFromZero);
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty, 4, MidpointRounding.AwayFromZero);
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty, 4, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty, 2, MidpointRounding.AwayFromZero);
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty, 2, MidpointRounding.AwayFromZero);
                                objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty = Math.Round(objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty, 2, MidpointRounding.AwayFromZero);
                            }
                            objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                            objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                        }
                        //Set sale order stock
                        ICStocksController objStockController = new ICStocksController();
                        ICStocksInfo objStocksInfo = null;
                        if (objSaleForecastsInfo.FK_BRBranchID > 0)
                        {
                            objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), objSaleForecastsInfo.FK_BRBranchID);
                        }
                        else
                        {
                            objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                        }
                        if (objStocksInfo != null)
                        {
                            objCancelSaleForecastItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                        }

                        entity.CancelSaleForecastItemList.Add(objCancelSaleForecastItemsInfo);
                    }
                }
                entity.CancelSaleForecastItemList.GridControl.RefreshDataSource();
            }
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
            }
        }
        public bool IsValidCanceledQty(decimal canceledQty)
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = (ARCancelSaleForecastItemsInfo)CurrentModuleEntity.ModuleObjects[TableName.ARCancelSaleForecastItemsTableName];
            ARCancelSaleForecastItemsInfo objOldCancelSaleForecastItemsInfo = entity.CancelSaleForecastItemList.BackupList.Where(i => i.ARCancelSaleForecastItemID == objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemID).FirstOrDefault();
            decimal oldCanceledQty = 0;
            if (objOldCancelSaleForecastItemsInfo != null)
            {
                oldCanceledQty = objOldCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty;
                oldCanceledQty = Math.Round(oldCanceledQty, 4, MidpointRounding.AwayFromZero);
            }

            if (canceledQty > objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemSaleForecastQty - (objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty - oldCanceledQty))
            {
                return false;
            }
            return true;
        }

        public override void InvalidateToolbar()
        {
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)CurrentModuleEntity.MainObject;
            if (objCancelSaleForecastsInfo.ARCancelSaleForecastID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objCancelSaleForecastsInfo.ARCancelSaleForecastStatus == CancelSaleForecastStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }

                if (objCancelSaleForecastsInfo.ARCancelSaleForecastStatus == CancelSaleForecastStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }

            base.InvalidateToolbar();
        }
        public void ChangeItemFromCancelVoucherItemList()
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = (ARCancelSaleForecastItemsInfo)entity.ModuleObjects[TableName.ARCancelSaleForecastItemsTableName];
            entity.SetProductPriceByProductUnitPrice();
            entity.CancelSaleForecastItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
            ARCancelSaleForecastsInfo mainObject = (ARCancelSaleForecastsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARCancelSaleForecastItemsInfo item in entity.CancelSaleForecastItemList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            entity.UpdateTotalAmount();
            entity.CancelSaleForecastItemList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
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