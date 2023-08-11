using BOSCommon;
using BOSComponent;
using BOSERP.Modules.CarcassBOM.UI;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ICProductCarcasssGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CarrcassList;
            this.DataSource = bds;
        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Tạo bản sao";
            column.FieldName = "CopyBOMVersion";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Tạo bản sao";
            rep1.LinkColor = Color.Blue;
            rep1.Click += new EventHandler(CopyBOM_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Load từ Excel";
            column.FieldName = "ImportBOM";
            RepositoryItemHyperLinkEdit repImport = new RepositoryItemHyperLinkEdit();
            repImport.NullText = "Load từ Excel";
            repImport.LinkColor = Color.Blue;
            repImport.Click += new EventHandler(ImportBOM_Click);
            column.ColumnEdit = repImport;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả BĐM";
            column.FieldName = "MMProductionNormDesc";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Người tạo BĐM";
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Ngày tạo BĐM";
            column.FieldName = "MMProductionNormCreatedDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tạo BOM trắng";
            column.FieldName = "CreateNewBOM";
            RepositoryItemHyperLinkEdit repCreateBOM = new RepositoryItemHyperLinkEdit();
            repCreateBOM.NullText = "Tạo BOM trắng";
            repCreateBOM.LinkColor = Color.Blue;
            repCreateBOM.Click += new EventHandler(CreateNewBOM_Click);
            column.ColumnEdit = repCreateBOM;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng m3 tinh";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMProductionNormBlock";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng DT sơn (M2)";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMProductionNormTotalPaint";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ProductionNormStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM BTP";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "CarcassWoodStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM QTSX";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ColorWoodStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM Hardware";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ColorHardwareStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM Sơn";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ColorPaintStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM PLDG";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ColorPackingMaterialStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái ĐM VTK";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "CarcassPackingMaterialStatus";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void CreateNewBOM_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICProductsForViewIMES item = (ICProductsForViewIMES)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            ICProductsForViewIMES itemClone = (ICProductsForViewIMES)item.Clone();
            ICProductsInfo iCProducts = new ICProductsInfo();
            BOSUtil.CopyViewObject(itemClone, iCProducts);
            bool isImportXls = false;
            if (((CarcassBOMModule)Screen.Module).IsValidBOM(iCProducts))
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn tạo BOM mới từ Excel không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel)
                    return;

                else if (rs == DialogResult.Yes)
                    isImportXls = true;
            }
            iCProducts.MMProductionNormID = 0;
            iCProducts.MMBatchProductNo = string.Empty;
            iCProducts.MMProductionNormDesc = string.Empty;
            if (isImportXls)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                int index = entity.CarrcassList.IndexOf(item);
                bool isSuccess = ((CarcassBOMModule)Screen.Module).ImportProductionNorm(itemClone, iCProducts, false);
                if (!isSuccess)
                    return;

                entity.CarrcassList.Insert(index + 1, itemClone);
                this.RefreshDataSource();
            }
            else
            {
                ((CarcassBOMModule)Screen.Module).CreateNewTab(iCProducts);
                ((CarcassBOMModule)Screen.Module).ShowPackageNo(true);
            }
        }

        private void ImportBOM_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICProductsForViewIMES item = (ICProductsForViewIMES)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            ICProductsInfo iCProducts = new ICProductsInfo();
            BOSUtil.CopyViewObject(item, iCProducts);
            ((CarcassBOMModule)Screen.Module).ImportProductionNorm(item, iCProducts);
            this.RefreshDataSource();
        }

        private void CopyBOM_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICProductsForViewIMES item = (ICProductsForViewIMES)gridView.GetRow(gridView.FocusedRowHandle);
            ICProductsInfo iCProducts = new ICProductsInfo();
            BOSUtil.CopyViewObject(item, iCProducts);
            bool isSuccess = ((CarcassBOMModule)Screen.Module).CopyBOMVersion(iCProducts);
            if (!isSuccess)
                return;

            ((DMCCB100)Screen).SearchCarcassList();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            gridview.DoubleClick += new System.EventHandler(gridview_DoubleClick);
            gridview.Click += new System.EventHandler(gridview_Click);
            gridview.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridview_CustomColumnDisplayText);
            gridview.OptionsView.ShowAutoFilterRow = true;
            GridColumn column = gridview.Columns["FK_ICProductCarcassID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridview;
        }

        private void gridview_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductCarcassID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", matchCodeID, "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "MMProductionNormCreatedDate")
            {
                if (e.Value != null)
                {
                    if (((DateTime)e.Value).Year == 9999 || ((DateTime)e.Value).Year == 0001)
                        e.DisplayText = "";
                }
                else e.DisplayText = "";
            }
        }

        void gridview_Click(object sender, System.EventArgs e)
        {
            GridView gridview = (GridView)sender;
            ICProductsForViewIMES carcass = (ICProductsForViewIMES)gridview.GetFocusedRow();
            if (carcass != null)
            {
                ICProductsInfo iCProducts = new ICProductsInfo();
                BOSUtil.CopyViewObject(carcass, iCProducts);
                ((CarcassBOMModule)Screen.Module).ProductCarcassNo = carcass.ICProductNo;
                if (((CarcassBOMModule)Screen.Module).ViewShowType == "BatchProduct")
                    ((CarcassBOMModule)Screen.Module).ShowBatchProductByProduct(carcass.ICProductID);
                else if (((CarcassBOMModule)Screen.Module).ViewShowType == "ShowPicture")
                    ((CarcassBOMModule)Screen.Module).ShowPictureByProduct(iCProducts);
            }
        }

        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            GridView gridview = (GridView)sender;
            ICProductsForViewIMES carcass = (ICProductsForViewIMES)gridview.GetFocusedRow();
            if (carcass != null)
            {
                ICProductsInfo iCProducts = new ICProductsInfo();
                BOSUtil.CopyViewObject(carcass, iCProducts);
                ((CarcassBOMModule)Screen.Module).CreateNewTab(iCProducts);
                ((CarcassBOMModule)Screen.Module).ShowPackageNo(true);
            }
        }

        public Color GetColorByStatus(ICProductsForViewIMES product, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Color c = new Color();
            if (product == null)
                return Color.White;

            if (product.MMProductionNormStatus == ProductionNormStatus.Canceled.ToString())
                c = Color.LightGray;
            else if (product.MMProductionNormStatus == ProductionNormStatus.Approved.ToString())
                c = Color.PaleTurquoise;
            else if (product.MMProductionNormStatus != ProductionNormStatus.Approved.ToString() && product.MMProductionNormID > 0)
                c = Color.LightGoldenrodYellow;
            else
                c = Color.White;

            return c;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            GridView gridview = (GridView)sender;
            ICProductsForViewIMES carcass = (ICProductsForViewIMES)gridview.GetRow(e.RowHandle);
            if (carcass != null)
            {
                e.Appearance.BackColor = GetColorByStatus(carcass, e);
            }
        }


    }
}
