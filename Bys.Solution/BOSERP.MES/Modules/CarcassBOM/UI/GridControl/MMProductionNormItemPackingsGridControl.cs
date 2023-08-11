using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class MMProductionNormItemPackingsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionNormItemPackingList;
            this.DataSource = bds;
        }


        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();


            string[] colList = new string[] { "Selected"
                                            ,   "MMProductionNormItemSortOrderString"
                                            ,   "MMProductionNormItemNo"
                                            ,   "MMProductionNormItemProductName"
                                            ,   "MMProductionNormItemPackingQuantity"
                                            ,   "MMProductionNormItemQuantity"
                                            ,   "MMProductionNormItemPackQuantity"
                                            ,   "MMProductionNormItemProductHeight"
                                            ,   "MMProductionNormItemProductLength"
                                            ,   "MMProductionNormItemProductWidth"
                                            //,   "ICProductPackageNo"
            };

            ReLocationColumn(colList, gridview);


            GridColumn col = gridview.Columns["Selected"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["MMProductionNormItemPackingQuantity"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemPackingQuantity", "n", gridview);
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["MMProductionNormItemPackQuantity"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemPackQuantity", "n", gridview);
            }
            col = gridview.Columns["MMProductionNormItemQuantity"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemQuantity", "n2", gridview);
            }
            col = gridview.Columns["MMProductionNormItemProductHeight"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemProductHeight", "n2", gridview);
            }
            col = gridview.Columns["MMProductionNormItemProductLength"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemProductLength", "n2", gridview);
            }
            col = gridview.Columns["MMProductionNormItemProductWidth"];
            if (col != null)
            {
                SetFormat("MMProductionNormItemProductWidth", "n2", gridview);
            }
            col = gridview.Columns["FK_MMSemiProductID"];
            if (col != null)
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã code", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                col.ColumnEdit = repositoryItemLookUpEdit;
                col.Caption = "Thuộc chi tiết";
                col.MinWidth = 150;
            }
            gridview.RowCellStyle += new RowCellStyleEventHandler(gridview_RowCellStyle);
            gridview.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridview.CellValueChanging += Gridview_CellValueChanging;
            return gridview;
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        private void Gridview_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            GridView gridView = (GridView)sender;
            //if (gridView.ActiveEditor.EditValue == gridView.ActiveEditor.OldEditValue) return;
            MMProductionNormItemPackingsInfo item = (MMProductionNormItemPackingsInfo)gridView.GetFocusedRow();

            if (item != null && e.Column.FieldName == "Selected")
            {

                ((CarcassBOMModule)Screen.Module).CalculateVolumnSelectedItem(item);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((CarcassBOMModule)Screen.Module).GetSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        private void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }

        void gridview_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)sender;

            MMProductionNormItemPackingsInfo item = (MMProductionNormItemPackingsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                if (item.Selected)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                }
                else
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                }
                if (e.Column.FieldName == "MMProductionNormItemPackingQuantity" && item.IsError)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                }
            }

        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;

            MMProductionNormItemPackingsInfo item = (MMProductionNormItemPackingsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                item.IsError = false;
                if (item != null && e.Column.FieldName == "Selected")
                {
                    bool value = false;
                    if (e.Value != null)
                        bool.TryParse(e.Value.ToString(), out value);

                    ICProductPackagesInfo selectPack = ((CarcassBOMModule)Screen.Module).GetSelectedPackNo();
                    if (selectPack == null && value)
                    {
                        BOSApp.ShowMessage("Vui lòng chọn kiện!");
                        item.Selected = false;
                        return;
                    }
                    if (selectPack != null && selectPack.ICProductPackageID == 0 && value)
                    {
                        BOSApp.ShowMessage("Vui lòng lưu kiện trước khi thêm chi tiết!");
                        item.Selected = false;
                        return;
                    }
                    if (value && !((CarcassBOMModule)Screen.Module).CheckQtySamePackType(item))
                    {
                        item.Selected = false;
                        return;
                    }
                    item.FK_ICProductPackageID = selectPack == null ? 0 : selectPack.ICProductPackageID;
                    ((CarcassBOMModule)Screen.Module).ChangePackageNo(item, item.Selected);


                }
                else if (e.Column.FieldName == "MMProductionNormItemPackingQuantity")
                {
                    if (item.MMProductionNormItemPackingQuantity > item.MMProductionNormItemQuantity)
                    {
                        BOSApp.ShowMessage("Số lượng đóng gói lớn hơn SL định mức");
                        item.MMProductionNormItemPackingQuantity = (decimal)gridView.ActiveEditor.OldEditValue;
                    }
                    if (!((CarcassBOMModule)Screen.Module).CheckQtySamePackType(item))
                        item.MMProductionNormItemPackingQuantity = (decimal)gridView.ActiveEditor.OldEditValue;

                    if (item.MMProductionNormItemPackingQuantity <= 0)
                    {
                        BOSApp.ShowMessage("Số lượng chi tiết phải lớn hơn 0!");
                        item.MMProductionNormItemPackingQuantity = (decimal)gridView.ActiveEditor.OldEditValue;
                    }
                }
            }
        }

        public string[] columnArr;
        public void ReLocationColumn(string[] columns, GridView gridView)
        {
            columnArr = columns;
            InitDefaultGridColumnsVisibleIndex(gridView);
        }
        protected override void InitDefaultGridColumnsVisibleIndex(GridView gridView)
        {
            if (columnArr != null && columnArr.Length > 0)
            {
                foreach (GridColumn columnedit1 in gridView.Columns)
                {
                    columnedit1.Visible = false;
                }
                GridColumn columnedit;
                int index = 1;
                foreach (string column in columnArr)
                {
                    columnedit = gridView.Columns[column];
                    if (columnedit != null)
                    {
                        columnedit.AppearanceCell.Options.UseBackColor = true;
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                }

                gridView.BestFitColumns();
            }
        }
    }
}
