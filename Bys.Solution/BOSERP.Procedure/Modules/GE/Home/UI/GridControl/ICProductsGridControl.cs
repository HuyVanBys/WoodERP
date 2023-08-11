using BOSComponent;
using BOSERP.Modules.Home.UI;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace BOSERP.Modules.Home
{
    public partial class ICProductsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.ProductList.SetEndCurrentEdit();
            return;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column = new GridColumn();
            column.Caption = "Hồ sơ sản phẩm";
            column.FieldName = "ProductProfiles";
            //column.OptionsColumn.AllowEdit = false;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = "Hồ sơ sản phẩm";
            SerialNo.Click += new EventHandler(ProductProfiles_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lệnh sản xuất";
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng sản phẩm";
            column.FieldName = "MMBatchProductItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }


        private void ProductProfiles_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objProductsInfo != null)
                {
                    Image imgs = null;
                    List<ICProductProfilesInfo> list = new List<ICProductProfilesInfo>();
                    ICProductProfilesController objProductProfilesController = new ICProductProfilesController();
                    list = objProductProfilesController.GetListObjectByProductID(objProductsInfo.ICProductID);
                    if (objProductsInfo.ICProductPicture != null)
                    {
                        imgs = (Bitmap)((new ImageConverter()).ConvertFrom(objProductsInfo.ICProductPicture));
                    }
                    ShowPicture guidShowPicture = new ShowPicture(imgs, list);
                    DMHM107 screen = Screen as DMHM107;
                    guidShowPicture.Module = screen.Module;
                    guidShowPicture.ShowDialog();

                }
            }

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 1;

            }
            if (gridView.Columns["ICProductName"] != null)
            {
                gridView.Columns["ICProductName"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductName"].Visible = true;
                gridView.Columns["ICProductName"].VisibleIndex = 2;

            }
            if (gridView.Columns["ICProductDesc"] != null)
            {
                gridView.Columns["ICProductDesc"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductDesc"].Visible = true;
                gridView.Columns["ICProductDesc"].VisibleIndex = 3;

            }
            if (gridView.Columns["FK_ICDepartmentID"] != null)
            {
                gridView.Columns["FK_ICDepartmentID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_ICDepartmentID"].Visible = true;
                gridView.Columns["FK_ICDepartmentID"].VisibleIndex = 4;
            }
            if (gridView.Columns["FK_ICProductGroupID"] != null)
            {
                gridView.Columns["FK_ICProductGroupID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_ICProductGroupID"].Visible = true;
                gridView.Columns["FK_ICProductGroupID"].VisibleIndex = 5;
            }
            if (gridView.Columns["FK_APSupplierID"] != null)
            {
                gridView.Columns["FK_APSupplierID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_APSupplierID"].Visible = true;
                gridView.Columns["FK_APSupplierID"].VisibleIndex = 6;
            }
            if (gridView.Columns["FK_ICProductBasicUnitID"] != null)
            {
                gridView.Columns["FK_ICProductBasicUnitID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_ICProductBasicUnitID"].Visible = true;
                gridView.Columns["FK_ICProductBasicUnitID"].VisibleIndex = 7;
            }
            if (gridView.Columns["ICProductSupplierNumber"] != null)
            {
                gridView.Columns["ICProductSupplierNumber"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductSupplierNumber"].Visible = true;
                gridView.Columns["ICProductSupplierNumber"].VisibleIndex = 8;
            }
            if (gridView.Columns["ICProductNoOfOldSys"] != null)
            {
                gridView.Columns["ICProductNoOfOldSys"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNoOfOldSys"].Visible = true;
                gridView.Columns["ICProductNoOfOldSys"].VisibleIndex = 9;
            }
            if (gridView.Columns["MMBatchProductNo"] != null)
            {
                gridView.Columns["MMBatchProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["MMBatchProductNo"].Visible = true;
                gridView.Columns["MMBatchProductNo"].VisibleIndex = 10;
            }
            if (gridView.Columns["MMBatchProductItemProductQty"] != null)
            {
                gridView.Columns["MMBatchProductItemProductQty"].OptionsColumn.AllowEdit = false;
                gridView.Columns["MMBatchProductItemProductQty"].Visible = true;
                gridView.Columns["MMBatchProductItemProductQty"].VisibleIndex = 11;
            }
            if (gridView.Columns["ARCustomerName"] != null)
            {
                gridView.Columns["ARCustomerName"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ARCustomerName"].Visible = true;
                gridView.Columns["ARCustomerName"].VisibleIndex = 12;
            }
            if (gridView.Columns["ProductProfiles"] != null)
            {
                gridView.Columns["ProductProfiles"].Visible = true;
                gridView.Columns["ProductProfiles"].VisibleIndex = 13;
            }
            return gridView;
        }

    }
}
