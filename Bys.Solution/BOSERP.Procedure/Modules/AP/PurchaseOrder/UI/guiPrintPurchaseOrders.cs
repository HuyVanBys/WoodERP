using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class guiPrintViewPurchaseOrders : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
      //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        public string purchaseOrderType;
        public guiPrintViewPurchaseOrders()
        {
            InitializeComponent();
        }

        private void guiPrintPurchaseOrders_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            InitializeControls(Controls);
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PurchaseOrderList.Clear();
            entity.PurchaseOrderList.InitBOSListGridControl(fld_dgcAPPurchaseOrders);
            GridView gridView = (GridView)fld_dgcAPPurchaseOrders.MainView;
            //gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
        }
        //private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{

        //}
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
        public void GetDataSearch()
        {
            int supplierID = 0;
            supplierID = Convert.ToInt32(fld_lkeAPSupplierID123.EditValue);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            //List<APPurchaseOrdersInfo> purchaseOrderList = new List<APPurchaseOrdersInfo>();
            DataSet ds;
            if (purchaseOrderType == PurchaseOrderType.OutSourcing.ToString())
            {
                ds = objPurchaseOrdersController.GetPurchaseOrderListByTypeInOutSourcing(supplierID, searchFromDate, searchToDate, PurchaseOrderType.OutSourcing.ToString());
            }
            else
            {
                ds = objPurchaseOrdersController.GetPurchaseOrderListByTypeNotInOutSourcing(supplierID, searchFromDate, searchToDate, PurchaseOrderType.OutSourcing.ToString());
            }
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PurchaseOrderList.Invalidate(ds);
            entity.PurchaseOrderList.GridControl.RefreshDataSource();

        }

        private void fld_btnPrint_Click_1(object sender, EventArgs e)
        {
            if (purchaseOrderType == PurchaseOrderType.Material.ToString())
            {
                RPPurchaseOrderMaterials report = new RPPurchaseOrderMaterials();
                if (InitPurchaseOrderReport(report))
                {
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
            }
            else if (purchaseOrderType == PurchaseOrderType.OutSourcing.ToString())
            {

                RPPurchaseOrderOutsourcings report = new RPPurchaseOrderOutsourcings();
                if (InitPurchaseOrderOutsourcingReport(report))
                {
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
            }
        }
        private bool InitPurchaseOrderReport(RPPurchaseOrderMaterials report)
        {
            int supplierID = 0;
            supplierID = Convert.ToInt32(fld_lkeAPSupplierID123.EditValue);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderForViews> purchaseOrderList = new List<APPurchaseOrderForViews>();
            MMBatchProductsInfo objBatchProductsIn = new MMBatchProductsInfo();
            APPurchaseOrderForViews objPurchaseOrdersInfo;
            List<APPurchaseOrderItemForViews> purchaseOrderItemLists = new List<APPurchaseOrderItemForViews>();
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;

            List<APPurchaseOrdersInfo> List = entity.PurchaseOrderList.Where(po => po.Selected == true).ToList();
            if (List != null)
            {
                List.ForEach(p =>
                {
                    objPurchaseOrdersInfo = new APPurchaseOrderForViews();
                    BOSUtil.CopyObject(p, objPurchaseOrdersInfo);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                });
            }


            APPurchaseOrderForViews mainObject = new APPurchaseOrderForViews();
            APPurchaseOrdersInfo main = (APPurchaseOrdersInfo)entity.MainObject;
            BOSUtil.CopyObject(main, mainObject);
            if (purchaseOrderList.Count > 0)
            {
                objPurchaseOrdersInfo = (APPurchaseOrderForViews)purchaseOrderList.FirstOrDefault().Clone();
            }
            else
            {
                objPurchaseOrdersInfo = null;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADReportsController objReportsController = new ADReportsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            string purchaseOrderNoList = string.Empty;
            string purchaseOrderNo = string.Empty;
            string batchProductNo = string.Empty;
            string purchaseOrderdate = string.Empty;
            string purchaseOrderComment = string.Empty;
            string purchaseOrderDateDelivery = string.Empty;
            string purchaseOrderAddDelivery = string.Empty;
            string quantityDetail = string.Empty;
            APSupplierContactsController objSupplierContactsController = new APSupplierContactsController();
            if (objPurchaseOrdersInfo != null)
            {
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = 0;
                List<APPurchaseOrderForViews> KTSupplier = purchaseOrderList.Where(po => po.FK_APSupplierID != objPurchaseOrdersInfo.FK_APSupplierID).ToList();
                if (KTSupplier.Count >= 1)
                {
                    MessageBox.Show("Bạn phải chọn cùng 1 nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objPurchaseOrdersInfo.FK_APSupplierID);
                GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();
                List<ADConfigValuesInfo> objConfigValuesList = new List<ADConfigValuesInfo>();
                ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                // ADReportsController objReportsController = new ADReportsController();
                GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
                GEDistrictsController objDistrictsController = new GEDistrictsController();
                if (objSuppliersInfo != null)
                {

                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)objDistrictsController.GetObjectByID(objSuppliersInfo.FK_GEDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objSuppliersInfo.FK_GEStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objStateProvincesInfo.GEStateProvinceName;
                    }

                    objPurchaseOrdersInfo.APSupplierName = objSuppliersInfo.APSupplierName;
                    objPurchaseOrdersInfo.APSupplierContactAddressLine3 = objSuppliersInfo.APSupplierContactAddressLine1;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactPhone1 = objSuppliersInfo.APSupplierContactPhone;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactFax = objSuppliersInfo.APSupplierContactFax;
                    //objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(objSuppliersInfo.FK_GEPaymentTermID);
                    //if (objPaymentTermsInfo != null)
                    //{
                    //    objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                    //}

                    objConfigValuesInfo = (ADConfigValuesInfo)objReportsController.GetObjectByADConfigKeyGroupAndKeyValues("PaymentMethod", objSuppliersInfo.APPaymentMethodCombo);
                    if (objConfigValuesInfo != null)
                    {
                        objPurchaseOrdersInfo.ADConfigText = objConfigValuesInfo.ADConfigText;
                    }

                }
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    objPurchaseOrdersInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                }
                foreach (APPurchaseOrderForViews item in purchaseOrderList)
                {
                    if (!string.IsNullOrEmpty(purchaseOrderNoList))
                        purchaseOrderNoList += ", ";
                    purchaseOrderNoList += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderNo))
                        purchaseOrderNo += "; ";
                    purchaseOrderNo += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderdate) && !purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                        purchaseOrderdate += "; ";
                    if (!purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                    {
                        purchaseOrderdate += (string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate));
                    }
                    if (!string.IsNullOrEmpty(purchaseOrderComment) && !purchaseOrderComment.Contains(item.APPurchaseOrderComment))
                        purchaseOrderComment += "; ";
                    if (!purchaseOrderComment.Contains(item.APPurchaseOrderComment) && item.APPurchaseOrderComment != string.Empty)
                    {
                        purchaseOrderComment += item.APPurchaseOrderComment;
                    }
                    if (string.IsNullOrEmpty(objPurchaseOrdersInfo.purchaseOrderDateDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")) && !objPurchaseOrdersInfo.purchaseOrderDateDelivery.Contains(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery += "; " + item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    //if (string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    //{
                    //    objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    //}
                    if (string.IsNullOrEmpty(purchaseOrderAddDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery = item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = purchaseOrderAddDelivery;
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3) && !purchaseOrderAddDelivery.Contains(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery += "; " + item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 += purchaseOrderAddDelivery;
                    }

                    objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    if (objPaymentTermsInfo != null)
                    {
                        if (string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                        }
                        if (!string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName) && !objPurchaseOrdersInfo.GEPaymentTermName.Contains(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName += ";" + objPaymentTermsInfo.GEPaymentTermName;
                        }
                    }
                    objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost += item.APPurchaseOrderSubTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderTotalCost += item.APPurchaseOrderTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderShippingFees += item.APPurchaseOrderShippingFees;
                    objPurchaseOrdersInfo.APPurchaseOrderTaxAmount += item.APPurchaseOrderTaxAmount;
                }
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                List<MMBatchProductsInfo> batchProductsList = objBatchProductsController.GetBatchProductNoBypurchaseOrderNoList(purchaseOrderNoList);
                if (batchProductsList != null && batchProductsList.Count > 0)
                {
                    foreach (MMBatchProductsInfo item in batchProductsList)
                    {
                        if (!string.IsNullOrEmpty(batchProductNo))
                            batchProductNo += "; ";
                        batchProductNo += item.MMBatchProductNo;
                    }
                }
                List<APPurchaseOrderItemForViews> purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByPurchaseOrderNoList(purchaseOrderNoList);
                decimal QuantityPerOnePO = 0;
                foreach (APPurchaseOrderItemForViews purchaseOrderItem in purchaseOrderItemList)
                {
                    //TKChinh [Add] Quantity Details Per One PurchaseOrder
                    quantityDetail = string.Empty;
                    foreach (APPurchaseOrderForViews item in purchaseOrderList)
                    {
                        QuantityPerOnePO = objPurchaseOrderItemsController.GetQuantityPerOnePurchaseOrder(item.APPurchaseOrderID,
                                                                                                            purchaseOrderItem.FK_ICProductID,
                                                                                                            purchaseOrderItem.FK_ICModelID,
                                                                                                            purchaseOrderItem.FK_GECountryID,
                                                                                                            purchaseOrderItem.FK_ICModelDetailID,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemProductUnitCost,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemComment,
                                                                                                            purchaseOrderItem.FK_ICMeasureUnitID,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemProductDesc);
                        if (QuantityPerOnePO > 0)
                        {
                            if (!string.IsNullOrEmpty(quantityDetail))
                            {
                                quantityDetail += "; ";
                            }
                            if (purchaseOrderItem.APPurchaseOrderItemProductType == PurchasePlanType.IngredientPaint.ToString())
                            {
                                quantityDetail += item.APPurchaseOrderNo + "(" + QuantityPerOnePO.ToString("n2") + ")";
                            }
                            else
                            {
                                quantityDetail += item.APPurchaseOrderNo + "(" + QuantityPerOnePO.ToString("n0") + ")";
                            }
                        }
                    }
                    purchaseOrderItem.QuantityDetail = quantityDetail;
                    //TKChinh [End]
                    purchaseOrderItemLists.Add(purchaseOrderItem);

                }
                objPurchaseOrdersInfo.APPurchaseOrderNo = purchaseOrderNo;
                objPurchaseOrdersInfo.APPurchaseOrderComment = purchaseOrderComment;
                //objPurchaseOrdersInfo.purchaseOrderDateDelivery = purchaseOrderDateDelivery;
                //objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = purchaseOrderAddDelivery;
                if (!string.IsNullOrEmpty(batchProductNo))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBatchProduct"];
                    if (label != null)
                    {
                        label.Text = batchProductNo;
                    }
                }
                if (!string.IsNullOrEmpty(purchaseOrderdate))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["lblDate"];
                    if (label != null)
                    {
                        label.Text = purchaseOrderdate;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            List<APPurchaseOrderItemForViews> listItem = purchaseOrderItemLists;
            foreach (APPurchaseOrderItemForViews item in listItem)
            {
                if (item.APPurchaseOrderItemProductType == PurchasePlanType.IngredientPaint.ToString())
                {
                    item.APPurchaseOrderQtyStr = item.APPurchaseOrderItemProductQty.ToString("n2");
                }
                else
                {
                    item.APPurchaseOrderQtyStr = item.APPurchaseOrderItemProductQty.ToString("n0");
                }
            }
            objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = listItem.Sum(p => p.APPurchaseOrderItemTotalCost);
            objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(((objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderShippingFees) * objPurchaseOrdersInfo.APPurchaseOrderTaxPercent) / 100, 0);
            objPurchaseOrdersInfo.APPurchaseOrderTotalCost = objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderTaxAmount + objPurchaseOrdersInfo.APPurchaseOrderShippingFees;

            if (objPurchaseOrdersInfo.FK_GECurrencyID == GECurrencyID.VND)
            {
                listItem.ForEach(o => o.APPurchaseOrderItemTotalCost = Math.Round(o.APPurchaseOrderItemTotalCost, 0));
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost, 0);
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderShippingFees, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTaxAmount, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTotalCost, 0);
            }

            report.bindingSource2.DataSource = listItem;
            report.bindingSource1.DataSource = objPurchaseOrdersInfo;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchTaxNumber"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }
            }

            return true;
        }
        private bool InitPurchaseOrderOutsourcingReport(RPPurchaseOrderOutsourcings report)
        {
            int supplierID = 0;
            supplierID = Convert.ToInt32(fld_lkeAPSupplierID123.EditValue);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderForViews> purchaseOrderList = new List<APPurchaseOrderForViews>();
            MMBatchProductsInfo objBatchProductsIn = new MMBatchProductsInfo();
            List<APPurchaseOrderItemForViews> purchaseOrderItemLists = new List<APPurchaseOrderItemForViews>();
            APPurchaseOrderForViews objPurchaseOrdersInfo;
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<APPurchaseOrdersInfo> List = entity.PurchaseOrderList.Where(po => po.Selected == true).ToList();
            if (List != null)
            {
                List.ForEach(p =>
                {
                    objPurchaseOrdersInfo = new APPurchaseOrderForViews();
                    BOSUtil.CopyObject(p, objPurchaseOrdersInfo);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                });
            }
            APPurchaseOrderForViews mainObject = new APPurchaseOrderForViews();
            APPurchaseOrdersInfo main = (APPurchaseOrdersInfo)entity.MainObject;
            BOSUtil.CopyObject(main, mainObject);
            if (purchaseOrderList.Count > 0)
            {
                objPurchaseOrdersInfo = (APPurchaseOrderForViews)purchaseOrderList.FirstOrDefault().Clone();
            }
            else
            {
                objPurchaseOrdersInfo = null;
            }
            ADReportsController objReportsController = new ADReportsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
            GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();
            List<ADConfigValuesInfo> objConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            GEDistrictsController objDistrictsController = new GEDistrictsController();
            string purchaseOrderNoList = string.Empty;
            string purchaseOrderNo = string.Empty;
            string batchProductNo = string.Empty;
            string purchaseOrderdate = string.Empty;
            string purchaseOrderComment = string.Empty;
            string purchaseOrderDateDelivery = string.Empty;
            string purchaseOrderAddDelivery = string.Empty;
            string quantityDetail = string.Empty;
            APSupplierContactsController objSupplierContactsController = new APSupplierContactsController();
            if (objPurchaseOrdersInfo != null)
            {
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = 0;
                List<APPurchaseOrderForViews> KTSupplier = purchaseOrderList.Where(po => po.FK_APSupplierID != objPurchaseOrdersInfo.FK_APSupplierID).ToList();
                if (KTSupplier.Count >= 1)
                {
                    MessageBox.Show("Bạn phải chọn cùng 1 nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objPurchaseOrdersInfo.FK_APSupplierID);
                if (objSuppliersInfo != null)
                {
                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)objDistrictsController.GetObjectByID(objSuppliersInfo.FK_GEDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objSuppliersInfo.FK_GEStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objStateProvincesInfo.GEStateProvinceName;
                    }

                    objPurchaseOrdersInfo.APSupplierName = objSuppliersInfo.APSupplierName;
                    objPurchaseOrdersInfo.APSupplierContactAddressLine3 = objSuppliersInfo.APSupplierContactAddressLine1;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactPhone1 = objSuppliersInfo.APSupplierContactPhone;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactFax = objSuppliersInfo.APSupplierContactFax;
                    objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(objSuppliersInfo.FK_GEPaymentTermID);
                    if (objPaymentTermsInfo != null)
                    {
                        objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                    }

                    objConfigValuesInfo = (ADConfigValuesInfo)objReportsController.GetObjectByADConfigKeyGroupAndKeyValues("PaymentMethod", objSuppliersInfo.APPaymentMethodCombo);
                    if (objConfigValuesInfo != null)
                    {
                        objPurchaseOrdersInfo.ADConfigText = objConfigValuesInfo.ADConfigText;
                    }

                }
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    objPurchaseOrdersInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                }
                foreach (APPurchaseOrderForViews item in purchaseOrderList)
                {
                    if (!string.IsNullOrEmpty(purchaseOrderNoList))
                        purchaseOrderNoList += ", ";
                    purchaseOrderNoList += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderNo))
                        purchaseOrderNo += "; ";
                    purchaseOrderNo += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderdate) && !purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                        purchaseOrderdate += "; ";
                    if (!purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                    {
                        purchaseOrderdate += (string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate));
                    }
                    if (!string.IsNullOrEmpty(purchaseOrderComment) && !purchaseOrderComment.Contains(item.APPurchaseOrderComment))
                        purchaseOrderComment += "; ";
                    if (!purchaseOrderComment.Contains(item.APPurchaseOrderComment) && item.APPurchaseOrderComment != string.Empty)
                    {
                        purchaseOrderComment += item.APPurchaseOrderComment;
                    }

                    //if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")) && !purchaseOrderDateDelivery.Contains(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    //{
                    //    purchaseOrderDateDelivery += item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy") + "; ";
                    //    objPurchaseOrdersInfo.purchaseOrderDateDelivery += purchaseOrderDateDelivery;
                    //}

                    //if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3) && !purchaseOrderDateDelivery.Contains(item.APPurchaseOrderDeliveryAddressLine3))
                    //{
                    //    purchaseOrderAddDelivery += item.APPurchaseOrderDeliveryAddressLine3 + "; ";
                    //    objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 += purchaseOrderAddDelivery;
                    //}

                    if (string.IsNullOrEmpty(objPurchaseOrdersInfo.purchaseOrderDateDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")) && !objPurchaseOrdersInfo.purchaseOrderDateDelivery.Contains(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery += "; " + item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    //if (string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    //{
                    //    objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    //}
                    if (string.IsNullOrEmpty(purchaseOrderAddDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery = item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = purchaseOrderAddDelivery;
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3) && !purchaseOrderAddDelivery.Contains(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery += "; " + item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 += purchaseOrderAddDelivery;
                    }


                    objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    if (objPaymentTermsInfo != null)
                    {
                        if (string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                        }
                        if (!string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName) && !objPurchaseOrdersInfo.GEPaymentTermName.Contains(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName += ";" + objPaymentTermsInfo.GEPaymentTermName;
                        }
                    }
                    objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost += item.APPurchaseOrderSubTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderTotalCost += item.APPurchaseOrderTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderShippingFees += item.APPurchaseOrderShippingFees;
                    objPurchaseOrdersInfo.APPurchaseOrderTaxAmount += item.APPurchaseOrderTaxAmount;
                }
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                List<MMBatchProductsInfo> batchProductsList = objBatchProductsController.GetBatchProductNoBypurchaseOrderNoList(purchaseOrderNoList);
                if (batchProductsList != null && batchProductsList.Count > 0)
                {
                    foreach (MMBatchProductsInfo item in batchProductsList)
                    {
                        if (!string.IsNullOrEmpty(batchProductNo))
                            batchProductNo += "; ";
                        batchProductNo += item.MMBatchProductNo;
                    }
                }
                List<APPurchaseOrderItemForViews> purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByPurchaseOrderOutsourcingNoList(purchaseOrderNoList);
                decimal QuantityPerOnePO = 0;
                foreach (APPurchaseOrderItemForViews purchaseOrderItem in purchaseOrderItemList)
                {
                    //TKChinh [Add] Quantity Details Per One PurchaseOrder
                    quantityDetail = string.Empty;
                    foreach (APPurchaseOrderForViews item in purchaseOrderList)
                    {
                        QuantityPerOnePO = objPurchaseOrderItemsController.GetQuantityPerOnePurchaseOrderOutSourcing(item.APPurchaseOrderID,
                                                                                                           purchaseOrderItem.FK_ICProductID,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemProductDesc,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemProductLenght,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemProductWidth,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemProductHeight,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemProductUnitCost,
                                                                                                           purchaseOrderItem.APPurchaseOrderItemComment,
                                                                                                           purchaseOrderItem.FK_ICMeasureUnitID);



                        if (QuantityPerOnePO > 0)
                        {
                            if (!string.IsNullOrEmpty(quantityDetail))
                            {
                                quantityDetail += "; ";
                            }
                            quantityDetail += item.APPurchaseOrderNo + "(" + string.Format("{0:n0}", QuantityPerOnePO) + ")";
                        }
                    }
                    purchaseOrderItem.QuantityDetail = quantityDetail;
                    //TKChinh [End]
                    purchaseOrderItemLists.Add(purchaseOrderItem);
                }
                objPurchaseOrdersInfo.APPurchaseOrderNo = purchaseOrderNo;
                objPurchaseOrdersInfo.APPurchaseOrderComment = purchaseOrderComment;
                if (!string.IsNullOrEmpty(batchProductNo))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBatchProduct"];
                    if (label != null)
                    {
                        label.Text = batchProductNo;
                    }
                }
                if (!string.IsNullOrEmpty(purchaseOrderdate))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrPurchaseOrderDate"];
                    if (label != null)
                    {
                        label.Text = purchaseOrderdate;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = purchaseOrderItemLists.Sum(p => p.APPurchaseOrderItemTotalCost);
            objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(((objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderShippingFees) * objPurchaseOrdersInfo.APPurchaseOrderTaxPercent) / 100, 0);
            objPurchaseOrdersInfo.APPurchaseOrderTotalCost = objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderTaxAmount + objPurchaseOrdersInfo.APPurchaseOrderShippingFees;

            if (objPurchaseOrdersInfo.FK_GECurrencyID == GECurrencyID.VND)
            {
                purchaseOrderItemLists.ForEach(o => o.APPurchaseOrderItemTotalCost = Math.Round(o.APPurchaseOrderItemTotalCost, 0));
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost, 0);
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderShippingFees, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTaxAmount, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTotalCost, 0);
            }

            report.bindingSource2.DataSource = purchaseOrderItemLists;
            report.bindingSource1.DataSource = objPurchaseOrdersInfo;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchTaxNumber"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }
            }

            return true;
        }

        private void fld_btnPrintDoc_Click(object sender, EventArgs e)
        {
            if (purchaseOrderType == PurchaseOrderType.Material.ToString())
            {
                RPPurchaseOrderMaterialsA4 report = new RPPurchaseOrderMaterialsA4();
                if (InitPurchaseOrderA4Report(report))
                {
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
            }
            //else if (purchaseOrderType == PurchaseOrderType.OutSourcing.ToString())
            //{

            //    RPPurchaseOrderOutsourcings report = new RPPurchaseOrderOutsourcings();
            //    if (InitPurchaseOrderOutsourcingReport(report))
            //    {
            //        guiReportPreview reviewer = new guiReportPreview(report);
            //        reviewer.Show();
            //    }
            //}
        }
        private bool InitPurchaseOrderA4Report(RPPurchaseOrderMaterialsA4 report)
        {
            int supplierID = 0;
            supplierID = Convert.ToInt32(fld_lkeAPSupplierID123.EditValue);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderForViews> purchaseOrderList = new List<APPurchaseOrderForViews>();
            MMBatchProductsInfo objBatchProductsIn = new MMBatchProductsInfo();
            APPurchaseOrderForViews objPurchaseOrdersInfo;
            List<APPurchaseOrderItemForViews> purchaseOrderItemLists = new List<APPurchaseOrderItemForViews>();
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<APPurchaseOrdersInfo> List = entity.PurchaseOrderList.Where(po => po.Selected == true).ToList();
            if (List != null)
            {
                List.ForEach(p =>
                {
                    objPurchaseOrdersInfo = new APPurchaseOrderForViews();
                    BOSUtil.CopyObject(p, objPurchaseOrdersInfo);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                });
            }

            APPurchaseOrderForViews mainObject = new APPurchaseOrderForViews();
            APPurchaseOrdersInfo main = (APPurchaseOrdersInfo)entity.MainObject;
            BOSUtil.CopyObject(main, mainObject);
            if (purchaseOrderList.Count > 0)
            {
                objPurchaseOrdersInfo = (APPurchaseOrderForViews)purchaseOrderList.FirstOrDefault().Clone();
            }
            else
            {
                objPurchaseOrdersInfo = null;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADReportsController objReportsController = new ADReportsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            string purchaseOrderNoList = string.Empty;
            string purchaseOrderNo = string.Empty;
            string batchProductNo = string.Empty;
            string purchaseOrderdate = string.Empty;
            string purchaseOrderComment = string.Empty;
            string purchaseOrderDateDelivery = string.Empty;
            string purchaseOrderAddDelivery = string.Empty;
            string quantityDetail = string.Empty;
            APSupplierContactsController objSupplierContactsController = new APSupplierContactsController();
            if (objPurchaseOrdersInfo != null)
            {
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = 0;
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = 0;
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = 0;
                List<APPurchaseOrderForViews> KTSupplier = purchaseOrderList.Where(po => po.FK_APSupplierID != objPurchaseOrdersInfo.FK_APSupplierID).ToList();
                if (KTSupplier.Count >= 1)
                {
                    MessageBox.Show("Bạn phải chọn cùng 1 nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objPurchaseOrdersInfo.FK_APSupplierID);
                GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();
                List<ADConfigValuesInfo> objConfigValuesList = new List<ADConfigValuesInfo>();
                ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
                GEDistrictsController objDistrictsController = new GEDistrictsController();
                // ADReportsController objReportsController = new ADReportsController();
                if (objSuppliersInfo != null)
                {

                    GEDistrictsInfo objDistrictsInfo = (GEDistrictsInfo)objDistrictsController.GetObjectByID(objSuppliersInfo.FK_GEDistrictID);
                    if (objDistrictsInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objDistrictsInfo.GEDistrictName;
                    }
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objSuppliersInfo.FK_GEStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        objSuppliersInfo.APSupplierContactAddressLine1 += ", " + objStateProvincesInfo.GEStateProvinceName;
                    }

                    objPurchaseOrdersInfo.APSupplierName = objSuppliersInfo.APSupplierName;
                    objPurchaseOrdersInfo.APSupplierContactAddressLine3 = objSuppliersInfo.APSupplierContactAddressLine1;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactPhone1 = objSuppliersInfo.APSupplierContactPhone;
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceContactFax = objSuppliersInfo.APSupplierContactFax;
                    //objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(objSuppliersInfo.FK_GEPaymentTermID);
                    //if (objPaymentTermsInfo != null)
                    //{
                    //    objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                    //}

                    objConfigValuesInfo = (ADConfigValuesInfo)objReportsController.GetObjectByADConfigKeyGroupAndKeyValues("PaymentMethod", objSuppliersInfo.APPaymentMethodCombo);
                    if (objConfigValuesInfo != null)
                    {
                        objPurchaseOrdersInfo.ADConfigText = objConfigValuesInfo.ADConfigText;
                    }

                }
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    objPurchaseOrdersInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                }
                foreach (APPurchaseOrderForViews item in purchaseOrderList)
                {
                    if (!string.IsNullOrEmpty(purchaseOrderNoList))
                        purchaseOrderNoList += ", ";
                    purchaseOrderNoList += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderNo))
                        purchaseOrderNo += "; ";
                    purchaseOrderNo += item.APPurchaseOrderNo;
                    if (!string.IsNullOrEmpty(purchaseOrderdate) && !purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                        purchaseOrderdate += "; ";
                    if (!purchaseOrderdate.Contains(string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate)))
                    {
                        purchaseOrderdate += (string.Format("{0:dd/MM/yyyy}", item.APPurchaseOrderDate));
                    }
                    if (!string.IsNullOrEmpty(purchaseOrderComment) && !purchaseOrderComment.Contains(item.APPurchaseOrderComment))
                        purchaseOrderComment += "; ";
                    if (!purchaseOrderComment.Contains(item.APPurchaseOrderComment) && item.APPurchaseOrderComment != string.Empty)
                    {
                        purchaseOrderComment += item.APPurchaseOrderComment;
                    }
                    if (string.IsNullOrEmpty(objPurchaseOrdersInfo.purchaseOrderDateDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")) && !objPurchaseOrdersInfo.purchaseOrderDateDelivery.Contains(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    {
                        objPurchaseOrdersInfo.purchaseOrderDateDelivery += "; " + item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    }
                    //if (string.IsNullOrEmpty(item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy")))
                    //{
                    //    objPurchaseOrdersInfo.purchaseOrderDateDelivery = item.APPurchaseOrderDeliveryDate.ToString("dd-MM-yyyy");
                    //}
                    if (string.IsNullOrEmpty(purchaseOrderAddDelivery) && !string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery = item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = purchaseOrderAddDelivery;
                    }
                    if (!string.IsNullOrEmpty(item.APPurchaseOrderDeliveryAddressLine3) && !purchaseOrderAddDelivery.Contains(item.APPurchaseOrderDeliveryAddressLine3))
                    {
                        purchaseOrderAddDelivery += "; " + item.APPurchaseOrderDeliveryAddressLine3;
                        objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 += purchaseOrderAddDelivery;
                    }

                    objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    if (objPaymentTermsInfo != null)
                    {
                        if (string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName = objPaymentTermsInfo.GEPaymentTermName;
                        }
                        if (!string.IsNullOrEmpty(objPurchaseOrdersInfo.GEPaymentTermName) && !objPurchaseOrdersInfo.GEPaymentTermName.Contains(objPurchaseOrdersInfo.GEPaymentTermName))
                        {
                            objPurchaseOrdersInfo.GEPaymentTermName += ";" + objPaymentTermsInfo.GEPaymentTermName;
                        }
                    }
                    objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost += item.APPurchaseOrderSubTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderTotalCost += item.APPurchaseOrderTotalCost;
                    objPurchaseOrdersInfo.APPurchaseOrderShippingFees += item.APPurchaseOrderShippingFees;
                    objPurchaseOrdersInfo.APPurchaseOrderTaxAmount += item.APPurchaseOrderTaxAmount;
                }
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                List<MMBatchProductsInfo> batchProductsList = objBatchProductsController.GetBatchProductNoBypurchaseOrderNoList(purchaseOrderNoList);
                if (batchProductsList != null && batchProductsList.Count > 0)
                {
                    foreach (MMBatchProductsInfo item in batchProductsList)
                    {
                        if (!string.IsNullOrEmpty(batchProductNo))
                            batchProductNo += "; ";
                        batchProductNo += item.MMBatchProductNo;
                    }
                }
                List<APPurchaseOrderItemForViews> purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByPurchaseOrderNoList(purchaseOrderNoList);
                decimal QuantityPerOnePO = 0;
                foreach (APPurchaseOrderItemForViews purchaseOrderItem in purchaseOrderItemList)
                {
                    //TKChinh [Add] Quantity Details Per One PurchaseOrder
                    quantityDetail = string.Empty;
                    foreach (APPurchaseOrdersInfo item in purchaseOrderList)
                    {
                        QuantityPerOnePO = objPurchaseOrderItemsController.GetQuantityPerOnePurchaseOrder(item.APPurchaseOrderID,
                                                                                                            purchaseOrderItem.FK_ICProductID,
                                                                                                            purchaseOrderItem.FK_ICModelID,
                                                                                                            purchaseOrderItem.FK_GECountryID,
                                                                                                            purchaseOrderItem.FK_ICModelDetailID,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemProductUnitCost,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemComment,
                                                                                                            purchaseOrderItem.FK_ICMeasureUnitID,
                                                                                                            purchaseOrderItem.APPurchaseOrderItemProductDesc);
                        if (QuantityPerOnePO > 0)
                        {
                            if (!string.IsNullOrEmpty(quantityDetail))
                            {
                                quantityDetail += "; ";
                            }
                            if (purchaseOrderItem.APPurchaseOrderItemProductType == PurchasePlanType.IngredientPaint.ToString())
                            {
                                quantityDetail += item.APPurchaseOrderNo + "(" + QuantityPerOnePO.ToString("n2") + ")";
                            }
                            else
                            {
                                quantityDetail += item.APPurchaseOrderNo + "(" + QuantityPerOnePO.ToString("n0") + ")";
                            }
                        }
                    }
                    purchaseOrderItem.QuantityDetail = quantityDetail;
                    //TKChinh [End]
                    purchaseOrderItemLists.Add(purchaseOrderItem);

                }
                objPurchaseOrdersInfo.APPurchaseOrderNo = purchaseOrderNo;
                objPurchaseOrdersInfo.APPurchaseOrderComment = purchaseOrderComment;
                //objPurchaseOrdersInfo.purchaseOrderDateDelivery = purchaseOrderDateDelivery;
                //objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = purchaseOrderAddDelivery;
                if (!string.IsNullOrEmpty(batchProductNo))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBatchProduct"];
                    if (label != null)
                    {
                        label.Text = batchProductNo;
                    }
                }
                if (!string.IsNullOrEmpty(purchaseOrderdate))
                {
                    XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrPurchaseOrderDate"];
                    if (label != null)
                    {
                        label.Text = purchaseOrderdate;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            List<APPurchaseOrderItemForViews> listItem = purchaseOrderItemLists;
            foreach (APPurchaseOrderItemForViews item in listItem)
            {
                if (item.APPurchaseOrderItemProductType == PurchasePlanType.IngredientPaint.ToString())
                {
                    item.APPurchaseOrderQtyStr = item.APPurchaseOrderItemProductQty.ToString("n2");
                }
                else
                {
                    item.APPurchaseOrderQtyStr = item.APPurchaseOrderItemProductQty.ToString("n0");
                }
            }
            objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = listItem.Sum(p => p.APPurchaseOrderItemTotalCost);
            objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(((objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderShippingFees) * objPurchaseOrdersInfo.APPurchaseOrderTaxPercent) / 100, 0);
            objPurchaseOrdersInfo.APPurchaseOrderTotalCost = objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost + objPurchaseOrdersInfo.APPurchaseOrderTaxAmount + objPurchaseOrdersInfo.APPurchaseOrderShippingFees;

            if (objPurchaseOrdersInfo.FK_GECurrencyID == GECurrencyID.VND)
            {
                listItem.ForEach(o => o.APPurchaseOrderItemTotalCost = Math.Round(o.APPurchaseOrderItemTotalCost, 0));
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost, 0);
                objPurchaseOrdersInfo.APPurchaseOrderShippingFees = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderShippingFees, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTaxAmount, 0);
                objPurchaseOrdersInfo.APPurchaseOrderTotalCost = Math.Round(objPurchaseOrdersInfo.APPurchaseOrderTotalCost, 0);
            }
            report.bindingSource2.DataSource = listItem;
            report.bindingSource1.DataSource = objPurchaseOrdersInfo;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
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
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchTaxNumber"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
                }
                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCSCompanyName"];
                if (label != null)
                {
                    label.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }
            }

            return true;
        }
    }
}
