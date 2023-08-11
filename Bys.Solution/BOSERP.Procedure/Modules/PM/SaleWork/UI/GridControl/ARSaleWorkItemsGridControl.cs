using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleWork
{
    public class ARSaleWorkItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleWorkEntities entity = (SaleWorkEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleWorkItemsList;
            this.DataSource = bds;
        }

        public enum SaleWorkItemsColumnName
        {
            PMSaleWorkItemDate,
            PMSaleWorkItemCommand,
            PMSaleWorkItemActualDate,
            FK_HREmployeeID,
            PMSaleWorkItemComponent,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new GridColumn();
            column.Caption = SaleOrderLocalizedResources.SOItemComponent;
            column.FieldName = SaleWorkItemsColumnName.PMSaleWorkItemComponent.ToString();
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = SaleOrderLocalizedResources.ItemComponentList;
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);

            AccObjectLookupEdit objectLookupEdit = new AccObjectLookupEdit();
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((SaleWorkModule)Screen.Module).ShowItemComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            new SaleWorkItemsColumnName[]
            {
                SaleWorkItemsColumnName.PMSaleWorkItemDate,
                SaleWorkItemsColumnName.PMSaleWorkItemCommand,
                SaleWorkItemsColumnName.PMSaleWorkItemActualDate,
                SaleWorkItemsColumnName.FK_HREmployeeID,
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            if (gridView.Columns["ACObjectAccessKey"] != null)
            {
                gridView.Columns["ACObjectAccessKey"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactPhone", "Điện thoại"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddress", "Địa chỉ"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemACObject_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                gridView.Columns["ACObjectAccessKey"].ColumnEdit = repositoryItemLookUpEdit;
                gridView.Columns["ACObjectAccessKey"].MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ACObjectAccessKey")
            {
                if (e.Value != null)
                {
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(e.Value.ToString());
                    objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                    if (objObjectsInfo != null)
                        e.DisplayText = objObjectsInfo.ACObjectName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        void repositoryItemACObject_QueryPopUp(object sender, EventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objectList = objObjectsController.GetAllObjects();
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            objectList.Insert(0, objObjectsInfo);
            lookUpEdit.Properties.DataSource = objectList;
            lookUpEdit.Properties.DisplayMember = "ACObjectName";
            lookUpEdit.Properties.ValueMember = "ACObjectAccessKey";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            SaleWorkEntities entity = (SaleWorkEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (e.Column.FieldName == SaleWorkItemsColumnName.FK_HREmployeeID.ToString())
                ((SaleWorkModule)Screen.Module).UpdateEmployeeForComponent();

            if (entity.SaleWorkItemsList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    PMSaleWorkItemsInfo item = (PMSaleWorkItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (e.Column.FieldName == "ACObjectAccessKey")
                    {
                        ACObjectsController objObjectsController = new ACObjectsController();
                        ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(gridView.EditingValue.ToString());
                        objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                        if (objObjectsInfo != null)
                        {
                            item.FK_ACObjectID = objObjectsInfo.ACObjectID;
                            item.PMObjectType = objObjectsInfo.ACObjectType;
                            item.ACObjectName = objObjectsInfo.ACObjectName;
                            item.ACObjectAccessKey = item.FK_ACObjectID + ";" + item.PMObjectType;
                        }
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleWorkModule)Screen.Module).DeleteItemFromSaleWorkItemsList();
            }
        }
    }
}
