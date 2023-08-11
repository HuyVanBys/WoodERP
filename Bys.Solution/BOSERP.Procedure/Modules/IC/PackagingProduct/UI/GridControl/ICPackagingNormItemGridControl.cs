using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PackagingProduct
{
    public partial class ICPackagingNormItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PackagingProductEntities entity = (PackagingProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICPackagingNormItemsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
                if (col.FieldName == "FK_ICMeasureUnitID" ||
                    col.FieldName == "ICPackagingNormItemProductQty" ||
                    col.FieldName == "ICPackagingNormItemComment" ||
                    col.FieldName == "FK_ICProductID")
                    col.OptionsColumn.AllowEdit = true;

            }

            //GridColumn column = gridView.Columns["FK_ICProductID"];
            //if (column != null)
            //{
            //    RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
            //    repositoryItemLookUpEdit.ValueMember = "ICProductID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    DevExpress.XtraGrid.Columns.GridColumn col = new GridColumn();
            //    col.FieldName = "ICProductNo";
            //    col.Caption = "Mã sản phẩm";
            //    col.VisibleIndex = 0;
            //    repositoryItemLookUpEdit.View.Columns.Add(col);
            //    col = new GridColumn();
            //    col.FieldName = "ICProductDesc";
            //    col.Caption = "Mô tả";
            //    col.VisibleIndex = 1;
            //    repositoryItemLookUpEdit.View.Columns.Add(col);
            //    col = new GridColumn();
            //    col.FieldName = "ICProductNoOfOldSys";
            //    col.Caption = "Mã hệ thống cũ";
            //    col.VisibleIndex = 2;
            //    repositoryItemLookUpEdit.View.Columns.Add(col);
            //    col = new GridColumn();
            //    col.FieldName = "ICProductAttribute";
            //    col.Caption = "Đặc tính";
            //    col.VisibleIndex = 3;
            //    repositoryItemLookUpEdit.View.Columns.Add(col);

            //    ICProductsController objPDController = new ICProductsController();
            //    List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Equipment.ToString()
            //        || p.ICProductType == ProductType.IngredientPackaging.ToString()
            //        || p.ICProductType == ProductType.ArtificialBoard.ToString()
            //        || p.ICProductType == ProductType.VVP.ToString()).ToList();
            //    dataList.Insert(0, new ICProductsForViewInfo());
            //    repositoryItemLookUpEdit.DataSource = dataList;

            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.OptionsColumn.AllowEdit = true;
            //}

            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNoOfOldSys", "Mã hệ thống cũ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttribute", "Đặc tính"));
                repositoryItemLookUpEdit.DataSource = GetProductForLookUpEdit();
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Product_QueryPopUp);

                column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void Product_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit == null)
                    return;

                lookUpEdit.Properties.DataSource = GetProductForLookUpEdit();
            }
        }

        private List<ICProductsForViewInfo> GetProductForLookUpEdit()
        {
            ICProductsController objPDController = new ICProductsController();
            List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Equipment.ToString()
                || p.ICProductType == ProductType.IngredientPackaging.ToString()
                || p.ICProductType == ProductType.ArtificialBoard.ToString()
                || p.ICProductType == ProductType.VVP.ToString()).ToList();
            dataList.Insert(0, new ICProductsForViewInfo());
            return dataList;
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            int productID = 0;
            if (e.Column.FieldName == "FK_ICProductID" && e.Value != null
                && int.TryParse(e.Value.ToString(), out productID))
            {
                ICPackagingNormItemsInfo item = (ICPackagingNormItemsInfo)gridView.GetFocusedRow();
                ((PackagingProductModule)Screen.Module).ChangeProductID(item, productID);
            }
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PackagingProductModule)Screen.Module).RemoveSelectedItemFromPackagingNorm();
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID" ||
                e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID" ||
                e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                if (e.Value != null)
                {
                    int assetID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", assetID, "ICProductAttributeValue");

                }
            }
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    int assetID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", assetID, "ICMeasureUnitName");

                }
            }

        }
    }
}
