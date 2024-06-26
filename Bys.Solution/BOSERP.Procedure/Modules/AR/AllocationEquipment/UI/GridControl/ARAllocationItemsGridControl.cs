using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationEquipment
{
    public class ARAllocationItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            AllocationEquipmentEntities entity = (AllocationEquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AllocationItemsList;
            this.DataSource = bds;
        }

        public enum AllocationItemsColumnName
        {
            FK_ICProductIdentifiedEquipmentID,
            FK_ACAssetID,
            ARAllocationItemQty,
            ARAllocationItemComment,
            FK_ARAllocationID,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns[AllocationItemsColumnName.FK_ACAssetID.ToString()];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAssetNo";
                repositoryItemLookUpEdit.ValueMember = "ACAssetID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetNo", "Mã tài sản"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACAsset_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns[AllocationItemsColumnName.FK_ICProductIdentifiedEquipmentID.ToString()];
            if (column != null)
            {
                ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductIdentifiedEquipmentNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductIdentifiedEquipmentID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));
                repositoryItemLookUpEdit.DataSource = objProductIdentifiedEquipmentsController.GetIdentifiedForShowIndentifyMenu();
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditProductIdentifiedEquipment_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns[AllocationItemsColumnName.FK_ARAllocationID.ToString()];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ARAllocationNo";
                repositoryItemLookUpEdit.ValueMember = "ARAllocationID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ARAllocationNo", "Mã phiếu xuất"));
                DataSet ds = BOSApp.GetLookupTableData("ARAllocations");
                if (ds != null)
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                else
                {
                    ARAllocationsController objAllocationsController = new ARAllocationsController();
                    repositoryItemLookUpEdit.DataSource = objAllocationsController.GetAllAliveObjects().Tables[0];
                }
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }


            new AllocationItemsColumnName[]
            {
                AllocationItemsColumnName.FK_ICProductIdentifiedEquipmentID,
                AllocationItemsColumnName.FK_ACAssetID,
                AllocationItemsColumnName.ARAllocationItemQty,
                AllocationItemsColumnName.ARAllocationItemComment,
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            return gridView;
        }

        public void repositoryItemLookUpEditACAsset_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> assets = new List<ACAssetsInfo>();
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARAllocationItemsInfo objllocationItemsInfo = (ARAllocationItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                assets = objAssetsController.GetAssetsByProductID(objllocationItemsInfo.FK_ICProductID);
            }
            if (assets != null)
            {
                lookUpEdit.Properties.DataSource = assets;
            }
            lookUpEdit.Properties.DisplayMember = "ACAssetNo";
            lookUpEdit.Properties.ValueMember = "ACAssetID";
        }

        public void repositoryItemLookUpEditProductIdentifiedEquipment_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            List<ICProductIdentifiedEquipmentsInfo> productIdentifiedEquipments = new List<ICProductIdentifiedEquipmentsInfo>();
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARAllocationItemsInfo objllocationItemsInfo = (ARAllocationItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                productIdentifiedEquipments = objProductIdentifiedEquipmentsController.GetProductIdentifiedEquipmentsByProductID(objllocationItemsInfo.FK_ICProductID);
            }
            if (productIdentifiedEquipments != null)
            {
                lookUpEdit.Properties.DataSource = productIdentifiedEquipments;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            lookUpEdit.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
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
            //if(e.Column.FieldName == DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty.ToString())
            //    ((DeliveryPlanModule)Screen.Module).CheckDeliveryPlanItemProductQty();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AllocationEquipmentModule)Screen.Module).DeleteItemFromAllocationItemsList();
            }
        }
    }
}
