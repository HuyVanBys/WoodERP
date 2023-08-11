using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ProductTemplatesGridControl : BOSGridControl
    {
        List<ICProductsInfo> objProductsInfoList { get; set; }


        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductTemplateList;
            this.DataSource = bds;
        }

        public void LoadGrid(BaseModuleERP module, BOSScreen screen)
        {
            this.Screen = screen;
            this.Screen.Module = module;
            InitializeGridView();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();

            if (gridview.Columns["ICProductTemplateNo"] != null)
                gridview.Columns["ICProductTemplateNo"].OptionsColumn.AllowEdit = true;
            if (gridview.Columns["ICProductTemplateName"] != null)
                gridview.Columns["ICProductTemplateName"].OptionsColumn.AllowEdit = true;
            if (gridview.Columns["ICProductTemplateDesc"] != null)
                gridview.Columns["ICProductTemplateDesc"].OptionsColumn.AllowEdit = true;

            objProductsInfoList = ((ProductModule)Screen.Module).GetWoodIngredient();

            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridview.OptionsView.ShowDetailButtons = true;
            gridview.OptionsDetail.AllowExpandEmptyDetails = true;
            gridview.OptionsDetail.ShowDetailTabs = false;
            gridview.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            gridview.MasterRowGetChildList += new MasterRowGetChildListEventHandler(gridview_MasterRowGetChildList);
            gridview.MasterRowGetRelationName += new MasterRowGetRelationNameEventHandler(gridview_MasterRowGetRelationName);
            gridview.MasterRowGetRelationCount += new MasterRowGetRelationCountEventHandler(gridview_MasterRowGetRelationCount);
            gridview.MasterRowExpanded += new CustomMasterRowEventHandler(gridview_MasterRowExpanded);
            gridview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridview_FocusedRowChanged);
            ExpandAllRows(gridview);
            return gridview;
        }

        void gridview_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        void gridview_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "FK_ICProductTemplateID";
        }

        void gridview_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (gridview == null)
                return;
            ICProductTemplatesInfo productTem = (ICProductTemplatesInfo)gridview.GetRow(e.RowHandle);
            if (productTem == null)
                return;
            if (productTem.ItemList == null)
                productTem.ItemList = new BindingList<ICProductTemplateItemsInfo>();

            e.ChildList = productTem.ItemList;
        }

        void gridview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridview = (GridView)MainView;
            ExpandAllRows(gridview);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        void gridview_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView gridView = (GridView)sender;
            GridView detail = (GridView)gridView.GetDetailView(e.RowHandle, e.RelationIndex);
            if (detail == null)
                return;

            gridView.BeginUpdate();
            detail.OptionsView.ShowAutoFilterRow = false;
            detail.OptionsView.ShowFooter = true;
            detail.Columns.Clear();
            ADReportsController reportController = new ADReportsController();
            List<BOSLib.AAColumnAliasInfo> columnAlias = reportController.GetByTableNameWithNumberIntOrder("ICProductTemplateItems");

            GridColumn column;
            int visibleIndex = 0;
            columnAlias.ForEach(col =>
            {

                column = new GridColumn();
                column.Caption = col.AAColumnAliasCaption;
                column.FieldName = col.AAColumnAliasName;
                column.Visible = true;
                column.VisibleIndex = visibleIndex++;
                column.OptionsColumn.AllowEdit = true;
                detail.Columns.Add(column);

                if (column.FieldName == "FK_ICProductID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu", 300));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả", 300));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp1);
                    repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 300;
                }
                else if (column.FieldName == "FK_ICMeasureUnitID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                    repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitNo", "Mã ĐVT", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "Tên ĐVT", 300));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnit_QueryPopUp);
                    repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 150;
                }
                else if (column.FieldName == "FK_ICProductFormulaPriceConfigID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductFormulaPriceConfigName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductFormulaPriceConfigID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductFormulaPriceConfigName", "Mã công thức", 250));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repProductFormulaPriceConfig_QueryPopUp);
                    repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 150;
                }
                else if (column.FieldName == "ICProductTemplateItemLength"
                        || column.FieldName == "ICProductTemplateItemWidth"
                        || column.FieldName == "ICProductTemplateItemHeight"
                        || column.FieldName == "ICProductTemplateItemProductUnitPrice"
                        || column.FieldName == "ICProductTemplateItemTotalAmount")
                {
                    RepositoryItemTextEdit txt = new RepositoryItemTextEdit();
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txt.Mask.EditMask = "n2";
                    txt.DisplayFormat.FormatType = FormatType.Numeric;
                    txt.DisplayFormat.FormatString = "{0:n2}";
                    column.ColumnEdit = txt;
                }
                else if (column.FieldName == "ICProductTemplateItemProductQty")
                {
                    RepositoryItemTextEdit txt = new RepositoryItemTextEdit();
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txt.DisplayFormat.FormatType = FormatType.Numeric;
                    txt.DisplayFormat.FormatString = "{0:n4}";
                    txt.Mask.EditMask = "n4";
                    column.ColumnEdit = txt;
                }

            });
            detail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridview_CustomColumnDisplayText1);
            detail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(detail_CellValueChanged);
            detail.KeyUp += new KeyEventHandler(detail_KeyUp);
            detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.EndUpdate();
        }

        void detail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = (GridView)sender;
                BindingList<ICProductTemplateItemsInfo> lst = (BindingList<ICProductTemplateItemsInfo>)view.DataSource;
                ICProductTemplateItemsInfo item = (ICProductTemplateItemsInfo)view.GetFocusedRow();
                lst.Remove(item);
                view.RefreshData();
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void detail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            if (view != null)
            {
                ICProductTemplateItemsInfo item = (ICProductTemplateItemsInfo)view.GetFocusedRow();
                if (item != null)
                {
                    if (e.Column.FieldName == "FK_ICProductID")
                    {
                        ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductID);
                        if (iProduct != null)
                        {
                            ChangeIngredient(item, iProduct);
                        }
                    }
                    ((ProductModule)Screen.Module).ChangedProductTemplateItemList(item);
                }
            }
        }

        public void ChangeIngredient(ICProductTemplateItemsInfo item, ICProductsInfo iProduct)
        {
            item.ICProductTemplateItemProductNo = iProduct.ICProductNo;
            item.ICProductTemplateItemProductName = iProduct.ICProductName;
            item.ICProductTemplateItemProductDesc = iProduct.ICProductDesc;
            item.ICProductTemplateItemProductQty = 1;
            item.ICProductTemplateItemProductUnitPrice = iProduct.ICProductPrice01;
            item.FK_ICMeasureUnitID = iProduct.FK_ICProductBasicUnitID;
            item.ICProductTemplateItemHeight = iProduct.ICProductHeight;
            item.ICProductTemplateItemLength = iProduct.ICProductLength;
            item.ICProductTemplateItemWidth = iProduct.ICProductWidth;
            item.FK_ICProductFormulaPriceConfigID = iProduct.FK_ICProductFormulaPriceConfigID;
        }

        private void repositoryItemLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        private void repMeasureUnit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.ICMeasureUnitsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }


        }

        private void repProductFormulaPriceConfig_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains("ICProductFormulaPriceConfigs"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["ICProductFormulaPriceConfigs"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }
        }

        void gridview_CustomColumnDisplayText1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
                    if (iProduct != null)
                    {
                        e.DisplayText = iProduct.ICProductName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", id, "ICMeasureUnitName");
                    else
                        e.DisplayText = string.Empty;
                }
                if (e.Column.FieldName == "FK_ICProductFormulaPriceConfigID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductFormulaPriceConfigs", "ICProductFormulaPriceConfigID", id, "ICProductFormulaPriceConfigName");
                    else
                        e.DisplayText = string.Empty;
                }
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

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).DeleteProductTemplates();
            }
        }

        public void ExpandAllRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }
    }
}