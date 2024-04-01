using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.UpdatePosition
{
    public partial class UpdatePositionItemsGridControl : ItemGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            UpdatePositionEntities entity = (UpdatePositionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.UpdatePositionItemList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column =  gridView.Columns["FK_ICStockID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["FK_MMWSPositionID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["FK_MMRangePositionID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["FK_MMRowPositionID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;

            column = gridView.Columns["MMUpdatePositionItemDesc"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((UpdatePositionModule)Screen.Module).DeleteItemFromList();
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            MMPositionsController objPositionsController = new MMPositionsController();
            List<MMPositionsInfo> listPositions = (List<MMPositionsInfo>)objPositionsController.GetAllPositionList();
            GridColumn column = new GridColumn();
            column.Caption = "Xưởng";
            column.FieldName = "FK_MMWSPositionID";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemLookUpEdit repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "MMPositionNo";
            repo.ValueMember = "MMPositionID";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("MMPositionNo", "Mã xưởng"));
            repo.Columns.Add(new LookUpColumnInfo("MMPositionName", "Mô tả"));
            repo.DataSource = listPositions.Where(o => o.MMPositionType == PositionType.Line.ToString());
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dãy";
            column.FieldName = "FK_MMRangePositionID";
            column.OptionsColumn.AllowEdit = true;

            repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "MMPositionNo";
            repo.ValueMember = "MMPositionID";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("MMPositionNo", "Mã dãy"));
            repo.Columns.Add(new LookUpColumnInfo("MMPositionName", "Mô tả"));
            repo.DataSource = listPositions.Where(o => o.MMPositionType == PositionType.Range.ToString());
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dây";
            column.FieldName = "FK_MMRowPositionID";
            column.OptionsColumn.AllowEdit = true;

            repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "MMPositionNo";
            repo.ValueMember = "MMPositionID";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("MMPositionNo", "Mã dãy"));
            repo.Columns.Add(new LookUpColumnInfo("MMPositionName", "Mô tả"));
            repo.DataSource = listPositions.Where(o => o.MMPositionType == PositionType.Wire.ToString());
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Vị trí hiện tại";
            column.FieldName = "FK_MMDiagramPositionOldID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = MESLocalizedResources.AddProcessInfo;
            //column.FieldName = "AddProcessInfo";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 3;

            //RepositoryItemHyperLinkEdit AddProcessInfo = new RepositoryItemHyperLinkEdit();
            //AddProcessInfo.NullText = MESLocalizedResources.AddProcessInfo;
            //AddProcessInfo.Click += new EventHandler(AddProcessInfo_Click);
            //column.ColumnEdit = AddProcessInfo;
            //gridView.Columns.Add(column);

        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            MMUpdatePositionItemsInfo item = (MMUpdatePositionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Column.FieldName == "FK_ICProductID")
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    item.MMUpdatePositionItemProductName = objProductsInfo.ICProductName;
                }
            }
            if (e.Column.FieldName == "FK_ICProductSerieID")
            {
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
                if (objProductSeriesInfo != null)
                {
                    item.MMUpdatePositionItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    item.MMUpdatePositionItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.MMUpdatePositionItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                }
            }
            if (e.Column.FieldName == "FK_MMWSPositionID" || e.Column.FieldName == "FK_MMRangePositionID" || e.Column.FieldName == "FK_MMRowPositionID")
            {
                MMPositionsController objPositionsController = new MMPositionsController();
                MMPositionsInfo objWSPositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(item.FK_MMWSPositionID);
                MMPositionsInfo objRangePositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(item.FK_MMRangePositionID);
                MMPositionsInfo objRowPositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(item.FK_MMRowPositionID);

                item.MMUpdatePositionItemPositionName = String.Format("{0} - {1} - {2}",
                                                                    objWSPositionsInfo != null ? objWSPositionsInfo.MMPositionNo : string.Empty,
                                                                    objRangePositionsInfo != null ? objRangePositionsInfo.MMPositionNo : string.Empty,
                                                                    objRowPositionsInfo != null ? objRowPositionsInfo.MMPositionNo : string.Empty);
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductSerieID")
            {
                if (e.Value != null)
                {
                    int productSerieID = 0;
                        int.TryParse(e.Value.ToString(),out productSerieID);
                    if (productSerieID == 0)
                    {
                        e.DisplayText = String.Empty;
                        return;
                    }
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    ICProductSeriesInfo productSeries = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(productSerieID);
                    if (productSeries != null)
                    {
                        e.DisplayText = productSeries.ICProductSerieNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_MMDiagramPositionOldID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMDiagramPositions", "MMDiagramPositionID", int.Parse(e.Value.ToString()), "MMDiagramPositionName");
                }
                
            }    
        }
        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (e.FocusedRowHandle < 0)
                return;
            MMUpdatePositionItemsInfo item = (MMUpdatePositionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (gridView.FocusedColumn != null && gridView.FocusedColumn.FieldName.Contains("FK_ICProductSerieID"))
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                    if (objProductsInfo == null)
                        return;
                    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                    RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
                    rep.ValueMember = "ICProductSerieNo";
                    rep.DisplayMember = "ICProductSerieNo";
                    rep.NullText = String.Empty;
                    rep.TextEditStyle = TextEditStyles.Standard;
                    rep.SearchMode = SearchMode.AutoFilter;

                    LookUpColumnInfo colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICProductSerieNo";
                    AAColumnAliasInfo columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieNo").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Mã lô/ kiện";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);

                    colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICInventoryStockQuantity";
                    columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICInventoryStockQuantity").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Số lượng/ khối lượng";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);

                    colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICInventoryStockWoodQuantity";
                    columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICInventoryStockWoodQuantity").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Số thanh/ tấm";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);

                    colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICProductSerieProductHeight";
                    columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductHeight").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Dày";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);


                    colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICProductSerieProductWidth";
                    columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductWidth").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Rộng";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);


                    colLKE = new LookUpColumnInfo();
                    colLKE.FieldName = "ICProductSerieProductLength";
                    columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AAColumnAliasName == "ICProductSerieProductLength").FirstOrDefault();
                    colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : "Dài";
                    colLKE.Width = 100;
                    rep.Columns.Add(colLKE);

                    if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()
                        || objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
                    {
                        List<ICProductSeriesInfo> series = objProductSeriesController.GetSeriesByProductIDAndStockID(item.FK_ICProductID, item.FK_ICStockID, string.Empty, DateTime.Now);
                        if (series.Count > 0)
                        {
                            series.Insert(0, new ICProductSeriesInfo());
                        }

                        //foreach (ICProductSeriesInfo serie in series)
                        //{
                        //    //rep.Items.Add(serie.ICProductSerieNo);
                        //}
                        rep.DataSource = series;
                    }
                    rep.BestFitMode = BestFitMode.BestFitResizePopup;
                    rep.BestFit();

                    gridView.FocusedColumn.ColumnEdit = rep;
                }
                else
                {
                    GridColumn column = gridView.Columns["FK_ICProductSerieID"];
                    if (column != null)
                    {
                        column.ColumnEdit = null;
                    }
                }
            }    
        }
    }
}
