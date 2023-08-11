using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class ICAlternativeMaterialsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public MMAllocationPlanItemsInfo SourceAlternative { get; set; }
        public bool IsAlterOverConfigMaterial { get; set; }
        public override void InitGridControlDataSource()
        {
            guiAlternative guiAdd = (guiAlternative)this.Screen;
            BindingSource bds = new BindingSource();
            bds.DataSource = guiAdd.SelectedObjects;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "SL kế hoạch";
            column.FieldName = "ICProductAlternativeNormQty";
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL thay thế";
            column.FieldName = "ICProductAlternativeProductQty";
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL còn lại";
            column.FieldName = "ICProductAlternativeRemainQty";
            column.Visible = true;
            gridView.Columns.Add(column);

            if (IsAlterOverConfigMaterial)
            {
                column = new GridColumn();
                column.Caption = "Tỉ lệ tiêu hao";
                column.FieldName = "ICProductAlternativeDepreciationRate";
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.Caption = "SL bán thành phẩm";
                column.FieldName = "ICProductAlternativeSemiProductQty";
                FormatNumbericColumn(column, true, "n2");
                column.Visible = true;
                gridView.Columns.Add(column);
            }

            column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (IsAlterOverConfigMaterial)
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["ICProductAlternativeQty"];
            if (column != null)
                FormatNumbericColumn(column, true, "n2");
            column = gridView.Columns["ICProductAlternativeNormQty"];
            if (column != null)
                FormatNumbericColumn(column, false, (IsAlterOverConfigMaterial ? "n4" : "n2"));
            column = gridView.Columns["ICProductAlternativeCountProductQty"];
            if (column != null)
                FormatNumbericColumn(column, true, "n2");
            column = gridView.Columns["ICProductAlternativeProductQty"];
            if (column != null)
                FormatNumbericColumn(column, !IsAlterOverConfigMaterial, (IsAlterOverConfigMaterial ? "n4" : "n2"));

            column = gridView.Columns["ICProductAlternativeRemainQty"];
            if (column != null)
                FormatNumbericColumn(column, false, (IsAlterOverConfigMaterial ? "n4" : "n2"));
            if (IsAlterOverConfigMaterial)
            {
                //IsAlterOverConfigMaterial: cho phep thay đổi nguyên liệu khác cấu hình
                column = gridView.Columns["FK_ICProductAlternativeChildID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = IsAlterOverConfigMaterial;
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit semeiLookUpEdit = new RepositoryItemBOSLookupEdit();
                    semeiLookUpEdit.DisplayMember = "ICProductNo";
                    semeiLookUpEdit.ValueMember = "ICProductID";
                    semeiLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                    semeiLookUpEdit.SearchMode = SearchMode.AutoFilter;
                    semeiLookUpEdit.NullText = string.Empty;
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã", 100));
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên", 200));
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả", 200));
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductHeight", "Dày", 50));
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductWidth", "Rộng", 50));
                    semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductLength", "Dài", 50));
                    guiAlternative gui = (guiAlternative)this.Screen;
                    if (gui != null) semeiLookUpEdit.DataSource = gui.GetMaterialByMaterialDepart();
                    semeiLookUpEdit.PopupWidth = 750;
                    column.ColumnEdit = semeiLookUpEdit;
                }
                column = gridView.Columns["FK_ICProductAttributeQualityID"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
                column = gridView.Columns["FK_ICMeasureUnitID"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
                column = gridView.Columns["ICProductAlternativeCountProductQty"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
                column = gridView.Columns["ICProductHeight"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
                column = gridView.Columns["ICProductWidth"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
                column = gridView.Columns["ICProductLength"];
                if (column != null) column.OptionsColumn.AllowEdit = true;
            }
            else
            {
                column = gridView.Columns["ICProductAlternativeCountProductQty"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
            }
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.InitNewRow += Gridview_InitNewRow;
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }
        private void Gridview_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            ICProductAlternativesInfo product = (ICProductAlternativesInfo)gridView.GetFocusedRow();
            if (product == null)
                return;

            guiAlternative gui = (guiAlternative)this.Screen;
            if (gui != null)
            {
                product.ICProductAlternativeNormQty = gui.SourceAlternativeObj.MMAllocationPlanItemQty;
                product.ICProductAlternativeProductQty = gui.SourceAlternativeObj.MMAllocationPlanItemQty;
                product.ICProductAlternativeCountProductQty = gui.SourceAlternativeObj.MMAllocationPlanItemBPQty;
                product.ICProductAlternativeDepreciationRate = gui.SourceAlternativeObj.MMAllocationPlanItemDepreciationRate;
                product.ICProductAlternativeSemiProductQty = gui.SourceAlternativeObj.MMAllocationPlanItemBPQty;
                product.ICProductAlternativeQty = 1;
                if(product.FK_ICProductAlternativeChildID > 0)
                {
                    ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(product.FK_ICProductAlternativeChildID);
                    if (found != null)
                    {
                        product.ICProductAlternativeName = found.ICProductName;
                        product.ICProductAlternativeDesc = found.ICProductDesc;
                        product.ICProductHeight = found.ICProductHeight;
                        product.ICProductWidth = found.ICProductWidth;
                        product.ICProductLength = found.ICProductLength;
                        product.FK_ICMeasureUnitID = found.FK_ICProductBasicUnitID;
                    }
                }
            }
        }
        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductAlternativesInfo item = (ICProductAlternativesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item == null)
                    return;
                if (e.Column.FieldName == "Selected")
                {

                    guiAlternative guiAdd = (guiAlternative)this.Screen;
                    guiAdd.SelectedObjects.ForEach(o =>
                    {

                        if (o.FK_ICProductAlternativeChildID != item.FK_ICProductAlternativeChildID)
                        {
                            o.Selected = false;
                        }
                    });
                    this.RefreshDataSource();
                }
            }

        }

        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)gridView.GetFocusedRow();
            if (item == null)
                return;
            guiAlternative guiAdd = (guiAlternative)this.Screen;
            if (IsAlterOverConfigMaterial)
            {
                if (e.Column.FieldName == "FK_ICProductAlternativeChildID")
                {
                    List<ICProductAlternativesInfo> exits = guiAdd.SelectedObjects.Where(o => o.FK_ICProductAlternativeChildID == item.FK_ICProductAlternativeChildID).ToList();
                    if (exits != null && exits.Count > 1)
                    {
                        BOSApp.ShowMessage("Mã thay thế đã tồn tại trong danh sách");
                        item.FK_ICProductAlternativeChildID = 0;
                    }
                    else
                    {
                        ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductAlternativeChildID);
                        if (found != null)
                        {
                            item.ICProductAlternativeName = found.ICProductName;
                            item.ICProductAlternativeDesc = found.ICProductDesc;
                            item.ICProductHeight = found.ICProductHeight;
                            item.ICProductWidth = found.ICProductWidth;
                            item.ICProductLength = found.ICProductLength;
                            item.FK_ICMeasureUnitID = found.FK_ICProductBasicUnitID;
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductAlternativeChildID" ||
                    e.Column.FieldName == "ICProductHeight" ||
                    e.Column.FieldName == "ICProductWidth" ||
                    e.Column.FieldName == "ICProductLength" ||
                    e.Column.FieldName == "ICProductAlternativeCountProductQty")
                {
                    guiAdd.CalculateDetailInfo(item, true, SourceAlternative);
                    if (item.ICProductAlternativeProductQty > item.ICProductAlternativeNormQty && item.ICProductAlternativeNormQty > 0)
                    {
                        item.ICProductAlternativeQty = Math.Round(item.ICProductAlternativeProductQty / item.ICProductAlternativeNormQty, 5, MidpointRounding.AwayFromZero);
                    }
                    item.ICProductAlternativeRemainQty = item.ICProductAlternativeNormQty - item.ICProductAlternativeProductQty;
                }
            }
            if (e.Column.FieldName == "ICProductAlternativeProductQty" && !IsAlterOverConfigMaterial)
            {
                decimal oldItemQty = gridView.ActiveEditor.OldEditValue == null ? 0 : decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                if (item.ICProductAlternativeProductQty < 0)
                {
                    BOSApp.ShowMessage("Số lượng thay thế không thể nhỏ hơn 0.");
                    item.ICProductAlternativeProductQty = oldItemQty;
                    return;
                }
                if (item.ICProductAlternativeProductQty > item.ICProductAlternativeNormQty)
                {
                    BOSApp.ShowMessage("Số lượng thay thế không thể lớn hơn SL kế hoạch.");
                    item.ICProductAlternativeProductQty = oldItemQty;
                    return;
                }
                item.ICProductAlternativeRemainQty = item.ICProductAlternativeNormQty - item.ICProductAlternativeProductQty;
            }
            else if (e.Column.FieldName == "Selected")
            {
                guiAdd.SelectedObjects.ForEach(o =>
                {
                    if (o.FK_ICProductAlternativeChildID != item.FK_ICProductAlternativeChildID)
                    {
                        o.Selected = false;
                    }
                });
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ICProductAlternativeQty" || e.Column.FieldName == "ICProductAlternativeProductQty")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    e.Appearance.BackColor2 = Color.PaleTurquoise;
                }
            }
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                if (productID > 0)
                {
                    int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                    int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                    ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
                }
            }
        }

    }
}
