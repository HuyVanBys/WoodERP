using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public class ARDeliveryPlanWorksGridControl : ItemGridControl
    {
        public enum DeliveryPlanWorkColumn
        {
            ARDeliveryPlanWorkProductNo,
            ARDeliveryPlanWorkProductName,
            ARDeliveryPlanWorkProductDesc,
            FK_ARSaleOrderID,
            ACObjectName,
        };

        public enum SaleOrderColumn
        {
            ARSaleOrderID,
            ARSaleOrderNo,
        };

        public override void InitGridControlDataSource()
        {
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryPlanWorksList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductNoCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductNo.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductNameCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductName.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductDescCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductDesc.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            if (gridView.Columns[DeliveryPlanWorkColumn.FK_ARSaleOrderID.ToString()] != null)
            {
                column = gridView.Columns[DeliveryPlanWorkColumn.FK_ARSaleOrderID.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.ValueMember = SaleOrderColumn.ARSaleOrderID.ToString();
                repositoryItemLookUpEdit.DisplayMember = SaleOrderColumn.ARSaleOrderNo.ToString();
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = SaleOrderColumn.ARSaleOrderNo.ToString();
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemSaleOrderLookupEdit_QueryPopUp);
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemSaleOrderLookupEdit_EditValueChanged);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            new DeliveryPlanWorkColumn[]
            {
                DeliveryPlanWorkColumn.FK_ARSaleOrderID,
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
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
                ((DeliveryPlanModule)Screen.Module).DeleteItemFromDeliveryPlanWorksList();
            }
        }
        private void repositoryItemSaleOrderLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrders = new List<ARSaleOrdersInfo>();
            entity.ARDeliveryPlanItemsList.Select(o => o.FK_ARSaleOrderID).Distinct().All(o =>
            {
                saleOrders.Add((ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(o));
                return true;
            });
            lookUpEdit.Properties.DataSource = saleOrders;
        }

        private void repositoryItemSaleOrderLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARDeliveryPlanWorksInfo objDeliveryPlanWorksInfo = (ARDeliveryPlanWorksInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (lke.OldEditValue != lke.EditValue)
            {
                objDeliveryPlanWorksInfo.ACObjectName = entity.ARDeliveryPlanItemsList.FirstOrDefault(o => o.FK_ARSaleOrderID == Convert.ToInt32(lke.EditValue)).ACObjectName;
            }
        }

        private void repositoryItemObjectNameLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            entity.ARDeliveryPlanItemsList.Select(o => o.FK_ARSaleOrderID).Distinct().All(o =>
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(o);
                if (objSaleOrdersInfo != null)
                {
                    objects.Add(objObjectsController.GetObjectByIDAndType(objSaleOrdersInfo.FK_ACObjectID, objSaleOrdersInfo.ARObjectType));
                }
                return true;
            });
            lookUpEdit.Properties.DataSource = objects;
        }
    }
}
