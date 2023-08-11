using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public class ARDeliveryPlanItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            TransferPlanEntities entity = (TransferPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryPlanItemsList;
            this.DataSource = bds;
        }

        public enum DeliveryPlanItemsColumnName
        {
            ARDeliveryPlanItemProductQty,
            ARDeliveryPlanItemAddress,
            ARDeliveryPlanItemDeliveryActualDate,
            ARDeliveryPlanItemCommand,
            FK_ICStockID,
            ACObjectAccessKey
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        public void HiddenObjectProperty(string deliveryPlanType)
        {
            GridColumn column = this.Columns["ACObjectName"];
            if (column == null)
                return;
            if (deliveryPlanType == DeliveryPlanFromType.Tranfer.ToString())
                column.Visible = false;
            else
                column.Visible = true;
            this.RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            ACObjectsController objObjectsController = new ACObjectsController();
            TransferPlanEntities entity = (TransferPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)entity.MainObject;

            GridColumn column = gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()];
            if (gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()] != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            new DeliveryPlanItemsColumnName[]
            {
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemAddress,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemDeliveryActualDate,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemCommand,
                DeliveryPlanItemsColumnName.FK_ICStockID,
                DeliveryPlanItemsColumnName.ACObjectAccessKey
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            column = gridView.Columns["ARDeliveryPlanItemSaleOrderNo"];
            if (column != null)
            {
                column.Caption = "Mã chứng từ";
            }

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
            if (e.Column.FieldName == DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty.ToString())
                ((TransferPlanModule)Screen.Module).CheckDeliveryPlanItemProductQty();
            if (e.Column.FieldName == DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString())
                ((TransferPlanModule)Screen.Module).ChangeObjectItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((TransferPlanModule)Screen.Module).DeleteItemFromDeliveryPlanItemsList();
            }
        }
    }
}
