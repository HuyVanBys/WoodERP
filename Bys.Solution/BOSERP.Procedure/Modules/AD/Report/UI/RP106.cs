using BOSCommon.Constants;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP106 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        BOSTreeList BatchProductTreeList;
        const string GroupTypeGroup = "Group";
        const string GroupTypeDetail = "Detail";

        public RP106()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

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



        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>


        private void RP106_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
            InitTreeListColumn();
            InitGridViewAllocationPlanItemWood();
            InitGridViewAllocationPlanItems();
            InitGridViewAllocationProposalWoodItems();
            InitGridViewAllocationProposalItems();
            InitGridViewShipmentItems();
        }
        //[NKVung]  [Issue Format Colum] [START]
        public void InitGridViewAllocationPlanItemWood()
        {
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItemWood.MainView;
            GridColumn column = gridView.Columns["MMAllocationPlanItemQty"];
            if (column.FieldName == "MMAllocationPlanItemQty")
            {
                column.Caption = "Khối lượng";
                SetFormat("MMAllocationPlanItemQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemBPQty"];
            if (column.FieldName == "MMAllocationPlanItemBPQty")
            {
                column.Caption = "Khối lượng theo ĐVT định mức";
                SetFormat("MMAllocationPlanItemBPQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemInventoryStock"];
            if (column.FieldName == "MMAllocationPlanItemInventoryStock")
            {
                column.Caption = "KL tồn kho thời điểm";
                SetFormat("MMAllocationPlanItemInventoryStock", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemSaleOrderQty"];
            if (column.FieldName == "MMAllocationPlanItemSaleOrderQty")
            {
                SetFormat("MMAllocationPlanItemSaleOrderQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemProposedQty"];
            if (column.FieldName == "MMAllocationPlanItemProposedQty")
            {
                column.Caption = "Khối lượng đã đề nghị";
                SetFormat("MMAllocationPlanItemProposedQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemCanceledQty"];
            if (column.FieldName == "MMAllocationPlanItemCanceledQty")
            {
                column.Caption = "Khối lượng hủy";
                SetFormat("MMAllocationPlanItemCanceledQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemBPProductionNormItemQty"];
            if (column.FieldName == "MMAllocationPlanItemBPProductionNormItemQty")
            {
                column.Caption = "Khối lượng ĐM";
                SetFormat("MMAllocationPlanItemBPProductionNormItemQty", "n4", gridView);
            }
        }
        public void InitGridViewAllocationPlanItems()
        {
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItems.MainView;
            GridColumn column = gridView.Columns["MMAllocationPlanItemQty"];
            if (column.FieldName == "MMAllocationPlanItemQty")
            {
                SetFormat("MMAllocationPlanItemQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemBPQty"];
            if (column.FieldName == "MMAllocationPlanItemBPQty")
            {
                SetFormat("MMAllocationPlanItemBPQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemInventoryStock"];
            if (column.FieldName == "MMAllocationPlanItemInventoryStock")
            {
                SetFormat("MMAllocationPlanItemInventoryStock", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemProposedQty"];
            if (column.FieldName == "MMAllocationPlanItemProposedQty")
            {
                SetFormat("MMAllocationPlanItemProposedQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemCanceledQty"];
            if (column.FieldName == "MMAllocationPlanItemCanceledQty")
            {
                SetFormat("MMAllocationPlanItemCanceledQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemSaleOrderQty"];
            if (column.FieldName == "MMAllocationPlanItemSaleOrderQty")
            {
                column.Caption = "Số lượng đặt bán";
                SetFormat("MMAllocationPlanItemSaleOrderQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationPlanItemBPProductionNormItemQty"];
            if (column.FieldName == "MMAllocationPlanItemBPProductionNormItemQty")
            {
                SetFormat("MMAllocationPlanItemBPProductionNormItemQty", "n3", gridView);
            }
        }
        public void InitGridViewAllocationProposalWoodItems()
        {
            GridView gridView = (GridView)fld_dgcMMAllocationProposalWoodItems.MainView;
            GridColumn column = gridView.Columns["MMAllocationProposalProductQtyRemain"];
            if (gridView.Columns["MMAllocationProposalProductQtyRemain"] != null)
            {
                gridView.Columns["MMAllocationProposalProductQtyRemain"].Caption = "SL Còn lại";
                SetFormat("MMAllocationProposalProductQtyRemain", "n4", gridView);

            }
            column = gridView.Columns["MMAllocationProposalItemCanceledQty"];
            if (gridView.Columns["MMAllocationProposalItemCanceledQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemCanceledQty"].Caption = "SL Hủy";
                SetFormat("MMAllocationProposalItemCanceledQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemShippedQty"];
            if (gridView.Columns["MMAllocationProposalItemShippedQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemShippedQty"].Caption = "Khối lượng đã xuất kho";
                SetFormat("MMAllocationProposalItemShippedQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"];
            if (gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"].Caption = "Khối lượng định mức";
                SetFormat("MMAllocationProposalItemBPProductionNormItemQty", "n4", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemQty"];
            if (gridView.Columns["MMAllocationProposalItemQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemQty"].Caption = "Khối lượng";
                SetFormat("MMAllocationProposalItemQty", "n4", gridView);
            }

            if (gridView.Columns["MMAllocationPlanItemQty"] != null)
            {
                gridView.Columns["MMAllocationPlanItemQty"].Caption = "Khối lượng KHSD";
                SetFormat("MMAllocationPlanItemQty", "n4", gridView);
            }
        }
        public void InitGridViewAllocationProposalItems()
        {
            GridView gridView = (GridView)fld_dgcMMAllocationProposalItems.MainView;
            GridColumn column = gridView.Columns["MMAllocationProposalProductQtyRemain"];
            if (gridView.Columns["MMAllocationProposalProductQtyRemain"] != null)
            {
                gridView.Columns["MMAllocationProposalProductQtyRemain"].Caption = "Số lượng còn lại";
                SetFormat("MMAllocationProposalProductQtyRemain", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemCanceledQty"];
            if (gridView.Columns["MMAllocationProposalItemCanceledQty"] != null)
            {
                SetFormat("MMAllocationProposalItemCanceledQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemShippedQty"];
            if (gridView.Columns["MMAllocationProposalItemShippedQty"] != null)
            {
                SetFormat("MMAllocationProposalItemShippedQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"];
            if (gridView.Columns["MMAllocationProposalItemBPProductionNormItemQty"] != null)
            {
                SetFormat("MMAllocationProposalItemBPProductionNormItemQty", "n3", gridView);
            }
            column = gridView.Columns["MMAllocationProposalItemQty"];
            if (gridView.Columns["MMAllocationProposalItemQty"] != null)
            {
                SetFormat("MMAllocationProposalItemQty", "n3", gridView);
            }
        }
        public void InitGridViewShipmentItems()
        {
            GridView gridView = (GridView)fld_dgcICShipmentItems.MainView;
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                SetFormat("ICShipmentItemProductQty", "n3", gridView);
            }
            //
            gridView = (GridView)fld_dgcICShipmentItemWood.MainView;
            column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                SetFormat("ICShipmentItemProductQty", "n4", gridView);
                column.Caption = BatchShipmentFreshLumberLocalizedResources.ICShipmentItemProductQty;
            }
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        //[NKVung]  [Issue Format Colum] [END]
        public void InitTreeListColumn()
        {
            fld_trlMMBatchProductItems.Columns.Clear();
            AddTreeListColumns("MMBatchProductItemProductNo");
            AddTreeListColumns("MMBatchProductItemProductName");
            AddTreeListColumns("MMBatchProductItemProductDesc");
            AddTreeListColumns("MMBatchProductItemProductSerial");
            AddTreeListColumns("MMBatchProductItemDesc");
            AddTreeListColumns("MMBatchProductItemProductQty");
            AddTreeListColumns("FK_MMProductionNormID");

        }
        public void AddTreeListColumns(string fieldName)
        {
            // fld_trlMMBatchProductItems.BeginUpdate();
            TreeListColumn column = fld_trlMMBatchProductItems.Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            column.FieldName = fieldName;
            fld_trlMMBatchProductItems.OptionsView.AutoWidth = false;

            if (fieldName == "MMBatchProductItemProductNo")
            {
                column.Caption = "Mã đối tượng";
            }

            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.MMBatchProductItemsTableName);
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                    }
                }
            }

            //fld_trlMMBatchProductItems.EndUpdate();
            //fld_trlMMBatchProductItems.Update();
        }
        public void GetDataSearch()
        {
            BOSProgressBar.Start("Đang tải dữ liệu");
            int supplierID = 0;
            if (fld_lkeARCustomerID.EditValue != null)
            {
                int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out supplierID);
            }
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int saleOrderID = 0;
            if (fld_lkeARSaleOrderID.EditValue != null)
            {
                int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out saleOrderID);
            }

            string batchProductNo = fld_lkeMMBatchProductNo.Text;

            ADReportsController objReportsController = new ADReportsController();
            List<MMBatchProductsInfo> batchproductList = objReportsController.GetAllMMBatchproduct(supplierID, searchFromDate, searchToDate, saleOrderID, batchProductNo);
            BatchProductTreeList = new BOSTreeList();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            ICProductsController objProductsController = new ICProductsController();
            if (batchproductList != null && batchproductList.Count > 0)
            {
                List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsList = new List<MMWoodPlanItemDetailsInfo>();
                List<MMAllocationPlanItemsInfo> objAllocationPlanItemWoodsList = new List<MMAllocationPlanItemsInfo>();
                List<MMAllocationPlanItemsInfo> objAllocationPlanItemsList = new List<MMAllocationPlanItemsInfo>();
                List<MMAllocationProposalItemsInfo> objAllocationProposalItemWoodList = new List<MMAllocationProposalItemsInfo>();
                List<MMAllocationProposalItemsInfo> objAllocationProposalItemList = new List<MMAllocationProposalItemsInfo>();
                List<ICShipmentItemsInfo> objShipmentItemWoodList = new List<ICShipmentItemsInfo>();
                List<ICShipmentItemsInfo> objShipmentItemList = new List<ICShipmentItemsInfo>();
                foreach (MMBatchProductsInfo batchProduct in batchproductList)
                {
                    //Lệnh sản xuất
                    MMBatchProductItemsInfo objBatchProductsInfo = new MMBatchProductItemsInfo();
                    objBatchProductsInfo.MMBatchProductItemProductNo = batchProduct.MMBatchProductNo;
                    objBatchProductsInfo.FK_MMBatchProductID = batchProduct.MMBatchProductID;
                    objBatchProductsInfo.MMProductionNormType = GroupTypeGroup;
                    //Thành phẩm
                    objBatchProductsInfo.SubList = new BOSTreeList();
                    List<MMBatchProductItemsInfo> objBatchProductItemList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(batchProduct.MMBatchProductID);
                    if (objBatchProductItemList != null && objBatchProductItemList.Count > 0)
                    {
                        foreach (MMBatchProductItemsInfo item in objBatchProductItemList)
                        {
                            item.MMProductionNormType = GroupTypeDetail;
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                item.MMBatchProductItemProductNo = objProductsInfo.ICProductNo;
                            }
                            objBatchProductsInfo.SubList.Add(item);
                        }
                    }
                    BatchProductTreeList.Add(objBatchProductsInfo);

                    if (batchProduct != null)
                    {

                        #region Kế hoạch sử dụng (Gỗ)
                        MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
                        objAllocationPlanItemWoodsList = objAllocationPlanItemsController.GetAllocationPlanItemWoodForReport(batchProduct.MMBatchProductID);
                        #endregion Kế hoạch sử dụng (Gỗ)

                        #region Lệnh cấp phát (Gỗ)
                        objAllocationProposalItemWoodList = GetAllocationProposalItemWoodDatasource(batchProduct.MMBatchProductID);
                        #endregion

                        #region Xuất kho (Gỗ)
                        objShipmentItemWoodList = GetShipmentItemWoodDatasource(batchProduct.MMBatchProductID);
                        #endregion
                        //#region BatchProduct
                        //if (objBatchProductItemsInfo.MMProductionNormType == GroupTypeGroup)
                        //{
                        //    if (objBatchProductItemsInfo.SubList != null && objBatchProductItemsInfo.SubList.Count > 0)
                        //    {
                        //        foreach (MMBatchProductItemsInfo item in objBatchProductItemsInfo.SubList)
                        //        {
                        //            #region Hoạch định chi tiết gỗ
                        //            List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsListSub = GetWoodPlanDetailDatasource(item.MMBatchProductItemID);
                        //            objWoodPlanItemDetailsList.AddRange(objWoodPlanItemDetailsListSub);
                        //            #endregion Hoạch định chi tiết gỗ

                        //            #region Kế hoạch sử dụng NPL
                        //            List<MMAllocationPlanItemsInfo> objAllocationPlanItemsListSub = GetAllocationPlanItemDataSource(item.MMBatchProductItemID);
                        //            objAllocationPlanItemsList.AddRange(objAllocationPlanItemsListSub);
                        //            #endregion

                        //            #region Lệnh cấp phát NPL
                        //            List<MMAllocationProposalItemsInfo> objAllocationProposalItemListSub = GetAllocationProposalItemDatasource(item.MMBatchProductItemID);
                        //            objAllocationProposalItemList.AddRange(objAllocationProposalItemListSub);
                        //            #endregion

                        //            #region Xuất kho NPL
                        //            List<ICShipmentItemsInfo> objShipmentItemListSub = GetShipmentItemDatasource(item.MMBatchProductItemID);
                        //            objShipmentItemList.AddRange(objShipmentItemListSub);
                        //            #endregion
                        //        }

                        //    }
                        //}
                        //#endregion
                        //#region BatchProductItem
                        //else
                        //{
                        #region Hoạch định chi tiết gỗ
                        List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsListSub = GetWoodPlanDetailDatasource(batchProduct.MMBatchProductID);
                        objWoodPlanItemDetailsList.AddRange(objWoodPlanItemDetailsListSub);
                        //objWoodPlanItemDetailsList = objWoodPlanItemDetailsListSub;
                        #endregion Hoạch định chi tiết gỗ

                        #region Kế hoạch sử dụng NPL
                        List<MMAllocationPlanItemsInfo> objAllocationPlanItemsListSub = GetAllocationPlanItemDataSource(batchProduct.MMBatchProductID);
                        objAllocationPlanItemsList.AddRange(objAllocationPlanItemsListSub);
                        //objAllocationPlanItemsList = objAllocationPlanItemsListSub;
                        #endregion

                        #region Lệnh cấp phát NPL
                        List<MMAllocationProposalItemsInfo> objAllocationProposalItemListSub = GetAllocationProposalItemDatasource(batchProduct.MMBatchProductID);
                        objAllocationProposalItemList.AddRange(objAllocationProposalItemListSub);
                        //objAllocationProposalItemList = objAllocationProposalItemListSub;
                        #endregion

                        #region Xuất kho NPL
                        List<ICShipmentItemsInfo> objShipmentItemListSub = GetShipmentItemDatasource(batchProduct.MMBatchProductID);
                        objShipmentItemList.AddRange(objShipmentItemListSub);
                        //objShipmentItemList = objShipmentItemListSub;
                        #endregion
                        //}
                        //#endregion


                    }
                }
                fld_dgcMMWoodPlanItemDetails.DataSource = objWoodPlanItemDetailsList;
                fld_dgcMMWoodPlanItemDetails.RefreshDataSource();

                fld_dgcMMAllocationPlanItemWood.DataSource = objAllocationPlanItemWoodsList;
                fld_dgcMMAllocationPlanItemWood.RefreshDataSource();

                fld_dgcMMAllocationPlanItems.DataSource = objAllocationPlanItemsList;
                fld_dgcMMAllocationPlanItems.RefreshDataSource();

                fld_dgcMMAllocationProposalWoodItems.DataSource = objAllocationProposalItemWoodList;
                fld_dgcMMAllocationProposalWoodItems.RefreshDataSource();

                fld_dgcMMAllocationProposalItems.DataSource = objAllocationProposalItemList;
                fld_dgcMMAllocationProposalWoodItems.RefreshDataSource();

                fld_dgcICShipmentItemWood.DataSource = objShipmentItemWoodList;
                fld_dgcICShipmentItemWood.RefreshDataSource();

                fld_dgcICShipmentItems.DataSource = objShipmentItemList;
                fld_dgcICShipmentItems.RefreshDataSource();
            }

            fld_trlMMBatchProductItems.DataSource = BatchProductTreeList;
            fld_trlMMBatchProductItems.RefreshDataSource();
            fld_trlMMBatchProductItems.ForceInitialize();

            fld_trlMMBatchProductItems.ExpandAll();
            fld_trlMMBatchProductItems.BestFitColumns();

            BOSProgressBar.Close();

        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        private void fld_trlMMBatchProductItems_InvalidNodeException(object sender, DevExpress.XtraTreeList.InvalidNodeExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void fld_trlMMBatchProductItems_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.CellValue != null)
            {
                decimal cellValue = 0;

                if (decimal.TryParse(e.CellValue.ToString(), out cellValue))
                {
                    if (cellValue == 0)
                    {
                        e.CellText = "";
                    }

                }

                if (e.Column.FieldName == "FK_MMProductionNormID")
                {
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(int.Parse(e.CellValue.ToString()));
                    if (objProductionNormsInfo != null)
                    {
                        e.CellText = objProductionNormsInfo.MMProductionNormNo;
                    }
                }


            }
        }

        private void fld_trlMMBatchProductItems_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
                objBatchProductItemsInfo = (MMBatchProductItemsInfo)tree.GetDataRecordByNode(e.Node);

                if (objBatchProductItemsInfo != null && objBatchProductItemsInfo.MMProductionNormType == GroupTypeGroup)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        //private void fld_trlMMBatchProductItems_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    TreeList tree = sender as TreeList;
        //    if (e.Node != null)
        //    {
        //        MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
        //        objBatchProductItemsInfo = (MMBatchProductItemsInfo)tree.GetDataRecordByNode(e.Node);

        //        if (objBatchProductItemsInfo != null)
        //        {
        //            List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsList = new List<MMWoodPlanItemDetailsInfo>();
        //            List<MMAllocationPlanItemsInfo> objAllocationPlanItemWoodsList = new List<MMAllocationPlanItemsInfo>();
        //            List<MMAllocationPlanItemsInfo> objAllocationPlanItemsList = new List<MMAllocationPlanItemsInfo>();
        //            List<MMAllocationProposalItemsInfo> objAllocationProposalItemWoodList = new List<MMAllocationProposalItemsInfo>();
        //            List<MMAllocationProposalItemsInfo> objAllocationProposalItemList = new List<MMAllocationProposalItemsInfo>();
        //            List<ICShipmentItemsInfo> objShipmentItemWoodList = new List<ICShipmentItemsInfo>();
        //            List<ICShipmentItemsInfo> objShipmentItemList = new List<ICShipmentItemsInfo>();
        //            #region Kế hoạch sử dụng (Gỗ)
        //            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
        //            objAllocationPlanItemWoodsList = objAllocationPlanItemsController.GetAllocationPlanItemWoodForReport(objBatchProductItemsInfo.FK_MMBatchProductID);
        //            #endregion Kế hoạch sử dụng (Gỗ)

        //            #region Lệnh cấp phát (Gỗ)
        //            objAllocationProposalItemWoodList = GetAllocationProposalItemWoodDatasource(objBatchProductItemsInfo.FK_MMBatchProductID);
        //            #endregion

        //            #region Xuất kho (Gỗ)
        //            objShipmentItemWoodList = GetShipmentItemWoodDatasource(objBatchProductItemsInfo.FK_MMBatchProductID);
        //            #endregion
        //            #region BatchProduct
        //            if (objBatchProductItemsInfo.MMProductionNormType == GroupTypeGroup)
        //            {
        //                if (objBatchProductItemsInfo.SubList != null && objBatchProductItemsInfo.SubList.Count > 0)
        //                {
        //                    foreach (MMBatchProductItemsInfo item in objBatchProductItemsInfo.SubList)
        //                    {
        //                        #region Hoạch định chi tiết gỗ
        //                        List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsListSub = GetWoodPlanDetailDatasource(item.MMBatchProductItemID);
        //                        objWoodPlanItemDetailsList.AddRange(objWoodPlanItemDetailsListSub);
        //                        #endregion Hoạch định chi tiết gỗ

        //                        #region Kế hoạch sử dụng NPL
        //                        List<MMAllocationPlanItemsInfo> objAllocationPlanItemsListSub = GetAllocationPlanItemDataSource(item.MMBatchProductItemID);
        //                        objAllocationPlanItemsList.AddRange(objAllocationPlanItemsListSub);
        //                        #endregion

        //                        #region Lệnh cấp phát NPL
        //                        List<MMAllocationProposalItemsInfo> objAllocationProposalItemListSub = GetAllocationProposalItemDatasource(item.MMBatchProductItemID);
        //                        objAllocationProposalItemList.AddRange(objAllocationProposalItemListSub);
        //                        #endregion

        //                        #region Xuất kho NPL
        //                        List<ICShipmentItemsInfo> objShipmentItemListSub = GetShipmentItemDatasource(item.MMBatchProductItemID);
        //                        objShipmentItemList.AddRange(objShipmentItemListSub);
        //                        #endregion
        //                    }

        //                }
        //            }
        //            #endregion
        //            #region BatchProductItem
        //            else
        //            {
        //                #region Hoạch định chi tiết gỗ
        //                List<MMWoodPlanItemDetailsInfo> objWoodPlanItemDetailsListSub = GetWoodPlanDetailDatasource(objBatchProductItemsInfo.MMBatchProductItemID);
        //                objWoodPlanItemDetailsList = objWoodPlanItemDetailsListSub;
        //                #endregion Hoạch định chi tiết gỗ

        //                #region Kế hoạch sử dụng NPL
        //                List<MMAllocationPlanItemsInfo> objAllocationPlanItemsListSub = GetAllocationPlanItemDataSource(objBatchProductItemsInfo.MMBatchProductItemID);
        //                objAllocationPlanItemsList = objAllocationPlanItemsListSub;
        //                #endregion

        //                #region Lệnh cấp phát NPL
        //                List<MMAllocationProposalItemsInfo> objAllocationProposalItemListSub = GetAllocationProposalItemDatasource(objBatchProductItemsInfo.MMBatchProductItemID);
        //                objAllocationProposalItemList = objAllocationProposalItemListSub;
        //                #endregion

        //                #region Xuất kho NPL
        //                List<ICShipmentItemsInfo> objShipmentItemListSub = GetShipmentItemDatasource(objBatchProductItemsInfo.MMBatchProductItemID);
        //                objShipmentItemList = objShipmentItemListSub;
        //                #endregion
        //            }
        //            #endregion

        //            fld_dgcMMWoodPlanItemDetails.DataSource = objWoodPlanItemDetailsList;
        //            fld_dgcMMWoodPlanItemDetails.RefreshDataSource();

        //            fld_dgcMMAllocationPlanItemWood.DataSource = objAllocationPlanItemWoodsList;
        //            fld_dgcMMAllocationPlanItemWood.RefreshDataSource();

        //            fld_dgcMMAllocationPlanItems.DataSource = objAllocationPlanItemsList;
        //            fld_dgcMMAllocationPlanItems.RefreshDataSource();

        //            fld_dgcMMAllocationProposalWoodItems.DataSource = objAllocationProposalItemWoodList;
        //            fld_dgcMMAllocationProposalWoodItems.RefreshDataSource();

        //            fld_dgcMMAllocationProposalItems.DataSource = objAllocationProposalItemList;
        //            fld_dgcMMAllocationProposalWoodItems.RefreshDataSource();

        //            fld_dgcICShipmentItemWood.DataSource = objShipmentItemWoodList;
        //            fld_dgcICShipmentItemWood.RefreshDataSource();

        //            fld_dgcICShipmentItems.DataSource = objShipmentItemList;
        //            fld_dgcICShipmentItems.RefreshDataSource();
        //        }
        //    }
        //}

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanDetailDatasource(int batchProductID)
        {
            List<MMWoodPlanItemDetailsInfo> objResultList = new List<MMWoodPlanItemDetailsInfo>();

            MMWoodPlanItemDetailsController objWoodPlanItemDetailsController = new MMWoodPlanItemDetailsController();

            objResultList = objWoodPlanItemDetailsController.GetWoodPlanItemDetailForReport(batchProductID);
            return objResultList;
        }

        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemDataSource(int batchProductID)
        {
            List<MMAllocationPlanItemsInfo> objResultList = new List<MMAllocationPlanItemsInfo>();
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            #region Other
            List<MMAllocationPlanItemsInfo> objAllocationPlanItemsList = objAllocationPlanItemsController.GetAllocationPlanItemForReport(batchProductID);

            List<int> productIDs = new List<int>();

            foreach (MMAllocationPlanItemsInfo item in objAllocationPlanItemsList)
            {
                if (!productIDs.Contains(item.FK_ICProductID))
                {
                    productIDs.Add(item.FK_ICProductID);
                }
            }

            foreach (int productID in productIDs)
            {
                MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
                List<MMAllocationPlanItemsInfo> filterList = objAllocationPlanItemsList.Where(i => i.FK_ICProductID == productID).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    objAllocationPlanItemsInfo = filterList.FirstOrDefault();
                    objAllocationPlanItemsInfo.MMAllocationPlanItemQty = filterList.Sum(i => i.MMAllocationPlanItemQty);
                    objAllocationPlanItemsInfo.MMAllocationPlanItemProposedQty = filterList.Sum(i => i.MMAllocationPlanItemProposedQty);
                    objAllocationPlanItemsInfo.MMAllocationPlanItemCanceledQty = filterList.Sum(i => i.MMAllocationPlanItemCanceledQty);
                    objResultList.Add(objAllocationPlanItemsInfo);
                }
            }
            #endregion

            #region PLDG
            List<MMAllocationPlanItemsInfo> objAllocationPlanItemsIngredientPackagingList = objAllocationPlanItemsController.GetAllocationPlanIngredientPackagingItemForReport(batchProductID);
            List<string> dictionary = new List<string>();
            foreach (MMAllocationPlanItemsInfo item in objAllocationPlanItemsIngredientPackagingList)
            {

                string key = item.FK_ICProductID + "-" + item.MMAllocationPlanItemProductDesc;
                if (!dictionary.Contains(key))
                {
                    dictionary.Add(key);
                }


            }
            foreach (string key in dictionary)
            {
                string[] splitKey = key.Split('-');
                int productID = int.Parse(splitKey[0]);
                string productDesc = splitKey[1];
                MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
                List<MMAllocationPlanItemsInfo> filterList = objAllocationPlanItemsIngredientPackagingList.Where(i => i.FK_ICProductID == productID && i.MMAllocationPlanItemProductDesc == productDesc).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    objAllocationPlanItemsInfo = filterList.FirstOrDefault();
                    objAllocationPlanItemsInfo.MMAllocationPlanItemQty = filterList.Sum(i => i.MMAllocationPlanItemQty);
                    objAllocationPlanItemsInfo.MMAllocationPlanItemProposedQty = filterList.Sum(i => i.MMAllocationPlanItemProposedQty);
                    objAllocationPlanItemsInfo.MMAllocationPlanItemCanceledQty = filterList.Sum(i => i.MMAllocationPlanItemCanceledQty);
                }
                objResultList.Add(objAllocationPlanItemsInfo);

            }
            #endregion

            return objResultList;
        }

        public List<MMAllocationProposalItemsInfo> GetAllocationProposalItemWoodDatasource(int batchProductID)
        {

            List<MMAllocationProposalItemsInfo> objResultList = new List<MMAllocationProposalItemsInfo>();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsList = objAllocationProposalItemsController.GetAllocationProposalWoodItemForReport(batchProductID);
            MMWoodPlanItemDetailsController objWoodPlanItemDetailsController = new MMWoodPlanItemDetailsController();
            List<MMWoodPlanItemDetailsInfo> WoodPlanItemDetailsList = objWoodPlanItemDetailsController.GetWoodPlanItemDetailByBatchProductID(batchProductID);
            List<string> dictionary = new List<string>();
            foreach (MMAllocationProposalItemsInfo item in objAllocationProposalItemsList)
            {
                string key = item.FK_ICProductID + "-" + item.MMAllocationProposalItemHeight;
                if (!dictionary.Contains(key))
                {
                    dictionary.Add(key);
                }
            }

            foreach (string key in dictionary)
            {
                string[] keySplit = key.Split('-');
                int productID = int.Parse(keySplit[0]);
                decimal height = decimal.Parse(keySplit[1]);
                List<MMAllocationProposalItemsInfo> filterList = objAllocationProposalItemsList.Where(i => i.FK_ICProductID == productID && i.MMAllocationProposalItemHeight == height).ToList();
                List<MMWoodPlanItemDetailsInfo> tempList = WoodPlanItemDetailsList.Where(i => i.FK_ICProductID == productID && i.MMWoodPlanItemDetailProductDryHeight == height).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    MMAllocationProposalItemsInfo item = filterList.FirstOrDefault();
                    item.MMAllocationProposalItemHeight = height;
                    item.MMAllocationProposalItemWidth = 0;
                    item.MMAllocationProposalItemLength = 0;
                    item.MMAllocationProposalItemWidthMin = filterList.Min(i => i.MMAllocationProposalItemWidth);
                    item.MMAllocationProposalItemWidthMax = filterList.Max(i => i.MMAllocationProposalItemWidth);
                    item.MMAllocationProposalItemLengthMin = filterList.Min(i => i.MMAllocationProposalItemLength);
                    item.MMAllocationProposalItemLengthMax = filterList.Max(i => i.MMAllocationProposalItemLength);
                    item.MMAllocationProposalItemQty = filterList.Sum(i => i.MMAllocationProposalItemQty);
                    item.MMAllocationProposalItemWoodQty = filterList.Sum(i => i.MMAllocationProposalItemWoodQty);
                    item.MMAllocationProposalItemShippedQty = filterList.Sum(i => i.MMAllocationProposalItemShippedQty);
                    //item.MMAllocationProposalItemBPProductionNormItemQty = filterList.Sum(i => i.MMAllocationProposalItemBPProductionNormItemQty);
                    item.MMAllocationProposalItemBPProductionNormItemQty = tempList.Sum(i => i.MMWoodPlanItemDetailProductDryBlocks);
                    item.MMAllocationProposalProductQtyRemain = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty;
                    objResultList.Add(item);
                }
            }


            return objResultList;
        }

        public List<MMAllocationProposalItemsInfo> GetAllocationProposalItemDatasource(int batchProductID)
        {

            List<MMAllocationProposalItemsInfo> objResultList = new List<MMAllocationProposalItemsInfo>();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            #region Packaging
            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsList = objAllocationProposalItemsController.GetAllocationProposalPackagingItemForReport(batchProductID);

            List<string> dictionary = new List<string>();
            foreach (MMAllocationProposalItemsInfo item in objAllocationProposalItemsList)
            {
                string key = item.FK_ICProductID + "-" + item.MMAllocationProposalItemProductDesc;
                if (!dictionary.Contains(key))
                {
                    dictionary.Add(key);
                }
            }

            foreach (string key in dictionary)
            {
                string[] keySplit = key.Split('-');
                int productID = int.Parse(keySplit[0]);
                string productDesc = keySplit[1];
                List<MMAllocationProposalItemsInfo> filterList = objAllocationProposalItemsList.Where(i => i.FK_ICProductID == productID && i.MMAllocationProposalItemProductDesc == productDesc).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    MMAllocationProposalItemsInfo item = filterList.FirstOrDefault();
                    item.MMAllocationProposalItemQty = filterList.Sum(i => i.MMAllocationProposalItemQty);
                    item.MMAllocationProposalItemWoodQty = filterList.Sum(i => i.MMAllocationProposalItemWoodQty);
                    item.MMAllocationProposalItemBPProductionNormItemQty = filterList.Sum(i => i.MMAllocationProposalItemBPProductionNormItemQty);
                    item.MMAllocationProposalItemShippedQty = filterList.Sum(i => i.MMAllocationProposalItemShippedQty);
                    item.MMAllocationProposalItemRemainQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty;
                    objResultList.Add(item);
                }
            }
            #endregion
            #region Other
            List<MMAllocationProposalItemsInfo> objAllocationPlanItemsList = objAllocationProposalItemsController.GetAllocationProposalItemForReport(batchProductID);

            List<int> productIDs = new List<int>();

            foreach (MMAllocationProposalItemsInfo item in objAllocationPlanItemsList)
            {
                if (!productIDs.Contains(item.FK_ICProductID))
                {
                    productIDs.Add(item.FK_ICProductID);
                }
            }

            foreach (int productID in productIDs)
            {
                MMAllocationProposalItemsInfo item = new MMAllocationProposalItemsInfo();
                List<MMAllocationProposalItemsInfo> filterList = objAllocationPlanItemsList.Where(i => i.FK_ICProductID == productID).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    item = filterList.FirstOrDefault();
                    item.MMAllocationProposalItemQty = filterList.Sum(i => i.MMAllocationProposalItemQty);
                    item.MMAllocationProposalItemWoodQty = filterList.Sum(i => i.MMAllocationProposalItemWoodQty);
                    item.MMAllocationProposalItemBPProductionNormItemQty = filterList.Sum(i => i.MMAllocationProposalItemBPProductionNormItemQty);
                    item.MMAllocationProposalItemShippedQty = filterList.Sum(i => i.MMAllocationProposalItemShippedQty);
                    item.MMAllocationProposalItemRemainQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty;
                    objResultList.Add(item);
                }
            }
            #endregion
            return objResultList;
        }


        public List<ICShipmentItemsInfo> GetShipmentItemWoodDatasource(int batchProductID)
        {
            ICShipmentItemsController objShipmnetItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> objResultList = new List<ICShipmentItemsInfo>();
            List<ICShipmentItemsInfo> objShipmentItemsList = objShipmnetItemsController.GetShipmentWoodItemForReport(batchProductID);
            List<string> dictionary = new List<string>();

            foreach (ICShipmentItemsInfo item in objShipmentItemsList)
            {
                string key = item.FK_ICProductID + "-" + item.ICShipmentItemHeight;
                if (!dictionary.Contains(key))
                {
                    dictionary.Add(key);
                }
            }

            foreach (string key in dictionary)
            {
                string[] keySplit = key.Split('-');
                int productID = int.Parse(keySplit[0]);
                decimal height = decimal.Parse(keySplit[1]);
                List<ICShipmentItemsInfo> filterList = objShipmentItemsList.Where(i => i.FK_ICProductID == productID && i.ICShipmentItemHeight == height).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    ICShipmentItemsInfo item = filterList.FirstOrDefault();
                    item.ICShipmentItemHeight = height;
                    item.ICShipmentItemWidth = 0;
                    item.ICShipmentItemLength = 0;
                    item.ICShipmentItemWidthMin = filterList.Min(i => i.ICShipmentItemWidth);
                    item.ICShipmentItemWidthMax = filterList.Max(i => i.ICShipmentItemWidth);
                    item.ICShipmentItemLengthMin = filterList.Min(i => i.ICShipmentItemLength);
                    item.ICShipmentItemLengthMax = filterList.Max(i => i.ICShipmentItemLength);
                    item.ICShipmentItemProductQty = filterList.Sum(i => i.ICShipmentItemProductQty);
                    item.ICShipmentItemWoodQty = filterList.Sum(i => i.ICShipmentItemWoodQty);

                    objResultList.Add(item);
                }
            }

            return objResultList;
        }

        public List<ICShipmentItemsInfo> GetShipmentItemDatasource(int batchProductID)
        {

            List<ICShipmentItemsInfo> objResultList = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            #region Packaging
            List<ICShipmentItemsInfo> objShipmentItemsList = objShipmentItemsController.GetShipmentPackagingItemForReport(batchProductID);

            List<string> dictionary = new List<string>();
            foreach (ICShipmentItemsInfo item in objShipmentItemsList)
            {
                string key = item.FK_ICProductID + "-" + item.ICShipmentItemProductDesc;
                if (!dictionary.Contains(key))
                {
                    dictionary.Add(key);
                }
            }

            foreach (string key in dictionary)
            {
                string[] keySplit = key.Split('-');
                int productID = int.Parse(keySplit[0]);
                string productDesc = keySplit[1];
                List<ICShipmentItemsInfo> filterList = objShipmentItemsList.Where(i => i.FK_ICProductID == productID && i.ICShipmentItemProductDesc == productDesc).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    ICShipmentItemsInfo item = filterList.FirstOrDefault();
                    item.ICShipmentItemProductQty = filterList.Sum(i => i.ICShipmentItemProductQty);
                    item.ICShipmentItemWoodQty = filterList.Sum(i => i.ICShipmentItemWoodQty);
                    objResultList.Add(item);
                }
            }
            #endregion
            #region Other
            List<ICShipmentItemsInfo> objAllocationPlanItemsList = objShipmentItemsController.GetShipmentItemForReport(batchProductID);

            List<int> productIDs = new List<int>();

            foreach (ICShipmentItemsInfo item in objAllocationPlanItemsList)
            {
                if (!productIDs.Contains(item.FK_ICProductID))
                {
                    productIDs.Add(item.FK_ICProductID);
                }
            }

            foreach (int productID in productIDs)
            {
                ICShipmentItemsInfo item = new ICShipmentItemsInfo();
                List<ICShipmentItemsInfo> filterList = objAllocationPlanItemsList.Where(i => i.FK_ICProductID == productID).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    item = filterList.FirstOrDefault();
                    item.ICShipmentItemProductQty = filterList.Sum(i => i.ICShipmentItemProductQty);
                    item.ICShipmentItemWoodQty = filterList.Sum(i => i.ICShipmentItemWoodQty);
                    objResultList.Add(item);
                }
            }
            #endregion
            return objResultList;
        }



    }
}
