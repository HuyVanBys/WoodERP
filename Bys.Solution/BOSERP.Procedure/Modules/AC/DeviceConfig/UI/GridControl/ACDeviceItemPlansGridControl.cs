using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Linq;

namespace BOSERP.Modules.DeviceConfig
{
    public class ACDeviceItemPlansGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACDeviceItemPlansList;
            this.DataSource = bds;
        }

       
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            gridView.Columns["FK_ICProductID"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_ACDeviceItemID"] != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACDeviceItemNo";
                repositoryItemLookUpEdit.ValueMember = "ACDeviceItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACDeviceItemNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACDeviceItemName", "Tên"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                gridView.Columns["FK_ACDeviceItemID"].ColumnEdit = repositoryItemLookUpEdit;
                gridView.Columns["FK_ACDeviceItemID"].OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACDeviceItemID")
            {
                DeviceConfigEntities entity = (DeviceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                if (e.Value != null)
                {
                    int decviceItemID = int.Parse(e.Value.ToString());
                    ACDeviceItemsInfo obj = entity.ACDeviceItemsList.Where(i => i.ACDeviceItemID == decviceItemID).FirstOrDefault();
                    if (obj != null)
                    {
                        e.DisplayText = obj.ACDeviceItemName;
                    }
                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DeviceConfigEntities entity = (DeviceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            lookUpEdit.Properties.DataSource = entity.ACDeviceItemsList;//.Where(i => i.ACDeviceItemID > 0).ToList(); 
        }
        
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((DeviceConfigModule)Screen.Module).RemoveSelectedItemPlansList();
                }
            }
        }
       


    }
}
