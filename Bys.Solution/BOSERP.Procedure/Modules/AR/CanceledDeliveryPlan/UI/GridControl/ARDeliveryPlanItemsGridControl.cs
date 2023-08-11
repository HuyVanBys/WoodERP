using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledDeliveryPlan
{
    public class ARDeliveryPlanItemsGridControl : ItemGridControl
    {
        public void InvalidateDataSource(List<ARDeliveryPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
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

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            ACObjectsController objObjectsController = new ACObjectsController();
            GridColumn column = null;
            if (gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()] != null)
            {
                column = gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()];
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
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemEmployeeOwnerLookupEdit_QueryPopUp);
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
            .ForEach(o => o.OptionsColumn.AllowEdit = false);

            column = new GridColumn();
            column.Caption = "Loại kế hoạch";
            column.FieldName = "ARDeliveryPlanType";
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemLookUpEdit repositoryItem = new RepositoryItemLookUpEdit();

            repositoryItem.DataSource = ADConfigValueUtility.ConfigValues.Tables["DeliveryPlanType"];
            repositoryItem.ValueMember = "Value";
            repositoryItem.DisplayMember = "Text";
            LookUpColumnInfo lookupcolumn = new LookUpColumnInfo();
            lookupcolumn.FieldName = "Text";
            lookupcolumn.Width = 100;
            repositoryItem.Columns.Add(lookupcolumn);
            repositoryItem.PopupWidth = column.Width;
            repositoryItem.ShowHeader = false;
            column.ColumnEdit = repositoryItem;

            gridView.Columns.Add(column);

            column = gridView.Columns["FK_ARDeliveryPlanID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                DataSet ds = objDeliveryPlansController.GetAllObjects();
                repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                repositoryItemLookUpEdit.DisplayMember = "ARDeliveryPlanNo";
                repositoryItemLookUpEdit.ValueMember = "ARDeliveryPlanID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Group();
            }
            column = gridView.Columns["ARDeliveryPlanItemProductQty"];
            if (column != null)
            {
                column.Caption = "SL ĐNXK";
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["ARDeliveryPlanItemPlanQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["ARDeliveryPlanItemShipmentQty"];
            if (column != null)
            {
                column.Caption = "SL hóa đơn";
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["ARDeliveryPlanItemCancelQty"];
            if (column != null)
            {
                column.Caption = "SL đã hủy";
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["ARDeliveryPlanItemDeliveryQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
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
    }
}
