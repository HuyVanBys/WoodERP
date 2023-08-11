using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;
using System.Drawing;

using System;
using DevExpress.XtraEditors.Repository;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class PictureProductsGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);

            column = new GridColumn();
            column.Caption = ProductionNormLocalizeResources.AddImage;
            column.FieldName = "AddImage";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;
            RepositoryItemHyperLinkEdit AddImage = new RepositoryItemHyperLinkEdit();
            AddImage.NullText = ProductionNormLocalizeResources.AddImage;
            AddImage.Click += new EventHandler(AddImage_Click);
            column.ColumnEdit = AddImage;
            gridView.Columns.Add(column);
           
        }
      
        private void AddImage_Click(object sender, EventArgs e)
        {
            HyperLinkEdit linkEdit = (HyperLinkEdit)sender ;
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.SemiProductList[entity.SemiProductList.CurrentIndex].Clone();
            ((ProductionNormModule)Screen.Module).BrowseFile();
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
         
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 0;
                gridView.Columns["ICProductNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }

            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            gridView.RowClick += new RowClickEventHandler(GridView_RowClick);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = sender as GridView;
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "AddImage")
            {

                ICProductsInfo objProductsInfo = entity.SemiProductList[e.ListSourceRowIndex];
                if (objProductsInfo != null && objProductsInfo.ICProductImageFile != string.Empty)
                {
                    e.DisplayText = "Sửa ảnh";
                }
                else
                {
                    e.DisplayText = "Thêm ảnh";
                }
            }
        }

        private void GridView_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                GridView gridView = (GridView)MainView;
                if (entity.SemiProductList.CurrentIndex > 0)
                {
                    ICProductsInfo objProductsInfo = entity.SemiProductList[entity.SemiProductList.CurrentIndex];
                    if (objProductsInfo != null )
                    {
                        BOSERP.Modules.ProductionNorm.UI.guiChoosePictureProduct form = (BOSERP.Modules.ProductionNorm.UI.guiChoosePictureProduct)this.Screen;
                        if (objProductsInfo.ICProductImageFile != string.Empty)
                            form.SetPictureProduct(objProductsInfo.ICProductImageFile);
                        
                    }  
                }
            }
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool value = (bool)view.GetRowCellValue(e.RowHandle, "HasComponent");
                if (value != null && (value == true))
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }
        
    }
}
