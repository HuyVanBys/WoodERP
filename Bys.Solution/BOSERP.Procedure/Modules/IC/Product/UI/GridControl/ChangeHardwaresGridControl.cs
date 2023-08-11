using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ChangeHardwaresGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = false;
            gridView.CellValueChanging += new CellValueChangedEventHandler(gridView_CellValueChanging);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Vật tư thay thế";
            column.FieldName = "FK_ICProductAlternativeID";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            //#region Repo data
            //column.OptionsColumn.AllowEdit = true;
            //RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
            //repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
            //repositoryItemLookUpEdit.ValueMember = "ICProductID";
            //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
            //repositoryItemLookUpEdit.NullText = string.Empty;
            //DevExpress.XtraGrid.Columns.GridColumn col = new GridColumn();
            //col.FieldName = "ICProductNo";
            //col.Caption = "Mã sản phẩm";
            //col.VisibleIndex = 0;
            //repositoryItemLookUpEdit.View.Columns.Add(col);
            //col = new GridColumn();
            //col.FieldName = "ICProductDesc";
            //col.Caption = "Mô tả";
            //col.VisibleIndex = 1;
            //repositoryItemLookUpEdit.View.Columns.Add(col);
            //col = new GridColumn();
            //col.FieldName = "ICProductNoOfOldSys";
            //col.Caption = "Mã hệ thống cũ";
            //col.VisibleIndex = 2;
            //repositoryItemLookUpEdit.View.Columns.Add(col);
            //col = new GridColumn();
            //col.FieldName = "ICProductAttribute";
            //col.Caption = "Đặc tính";
            //col.VisibleIndex = 3;
            //repositoryItemLookUpEdit.View.Columns.Add(col);

            //ICProductsController objPDController = new ICProductsController();
            //List<ICProductsInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Hardware.ToString()).ToList();
            //dataList.Insert(0, new ICProductsInfo());
            //repositoryItemLookUpEdit.DataSource = dataList;

            //column.ColumnEdit = repositoryItemLookUpEdit;
            //column.OptionsColumn.AllowEdit = true;
            //#endregion

            gridView.Columns.Add(column);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID" || e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    int ProductID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", ProductID, "ICProductNo");
                }
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "FK_ICProductAlternativeID")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMProductionNormItemsInfo obj = (MMProductionNormItemsInfo)gridView.GetRow(e.RowHandle);
                            if (obj.IsError)
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        void gridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "FK_ICProductAlternativeID")
                {
                    MMProductionNormItemsInfo obj = (MMProductionNormItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null) obj.IsError = false;
                }
            }
        }
    }
}
