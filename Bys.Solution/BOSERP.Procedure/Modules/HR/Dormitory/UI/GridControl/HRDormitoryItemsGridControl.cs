using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Dormitory
{
    public class HRDormitoryItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            DormitoryEntities entity = (DormitoryEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DormitoryItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            if (gridView.Columns["HRDormitoryItemProductQty"] != null)
            {
                gridView.Columns["HRDormitoryItemProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["HRDormitoryItemProductDesc"] != null)
            {
                gridView.Columns["HRDormitoryItemProductDesc"].OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã dụng cụ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên dụng cụ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemLookUpEdit_EditValueChanged);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Visible = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((DormitoryModule)Screen.Module).DeleteItemFromDormitoryItemsList();
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetEquipmentByProductType(ProductType.Equipment.ToString());
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objProductsInfoList;
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int productID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    string productNo = objProductsController.GetObjectNoByID(productID);
                    if (productNo != null)
                    {
                        e.DisplayText = productNo;
                    }
                }
            }
        }

        protected void repositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            GridView gridView = (GridView)MainView;
            ICProductsController objProductsController = new ICProductsController();
            HRDormitoryItemsInfo objDormitoryItemsInfo = (HRDormitoryItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue && objDormitoryItemsInfo != null)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID((int)lke.EditValue);
                if (objProductsInfo != null)
                {
                    objDormitoryItemsInfo.HRDormitoryItemProductName = objProductsInfo.ICProductName;
                    objDormitoryItemsInfo.HRDormitoryItemProductPicture = objProductsInfo.ICProductPicture;
                }
            }
        }
    }
}
