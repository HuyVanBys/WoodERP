using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public class ICReceiptItemContsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemContList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)sender;
            ICReceiptItemContsInfo item = (ICReceiptItemContsInfo)gridView.GetFocusedRow();
            ((PurchaseReceiptModule)Screen.Module).UpdateTotalAmountForDSConts(item);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseReceiptModule)Screen.Module).DeleteItemFromReceiptItemContsList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_GEContainerID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit containerRepo = new RepositoryItemLookUpEdit();
                containerRepo.DisplayMember = "GEContainerName";
                containerRepo.ValueMember = "GEContainerID";
                containerRepo.NullText = string.Empty;
                containerRepo.Columns.Add(new LookUpColumnInfo("GEContainerNo", "Mã "));
                containerRepo.Columns.Add(new LookUpColumnInfo("GEContainerName", "Loại cont"));
                containerRepo.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpContainer_QueryPopUp);
                column.ColumnEdit = containerRepo;
            }
            column = gridView.Columns["ICReceiptItemContQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void rpContainer_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)MainView;
            GEContainersController objContainersController = new GEContainersController();
            List<GEContainersInfo> containersList = objContainersController.GetAllObject();
            if (containersList != null && containersList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = containersList;
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_GEContainerID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.GEContainersTableName, "GEContainerID", id, "GEContainerName");
                }
                else
                    e.DisplayText = "";
            }
        }
        //private void GridView_DoubleClick(object sender, EventArgs e)
        //{
        //    ShowInventory();
        //}

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
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}
