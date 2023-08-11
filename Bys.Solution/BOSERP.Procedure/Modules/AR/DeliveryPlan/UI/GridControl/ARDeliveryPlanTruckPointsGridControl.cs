using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public class ARDeliveryPlanTruckPointsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DeliveryPlanTruckPointsList;
            DataSource = bds;
            RefreshDataSource();
        }

        public enum DeliveryPlanTruckPointsColumnName
        {
            ARDeliveryPlanTruckPointNote,
            ARDeliveryPlanTruckPointEstimatedHour
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "DS sản phẩm";
            column.FieldName = "ARDeliveryPlanTruckDeliveryPlanItem";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItem = new RepositoryItemHyperLinkEdit();
            rpItem.NullText = "DS sản phẩm";
            rpItem.Click += new EventHandler(RpItem_Click);
            column.ColumnEdit = rpItem;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            new DeliveryPlanTruckPointsColumnName[]
            {
                DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointNote,
                DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour,
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            if (gridView.Columns[DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour.ToString()] != null)
            {
                GridColumn column = gridView.Columns[DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour.ToString()];
                RepositoryItemTimeEdit repositoryItemDateEdit = new RepositoryItemTimeEdit();
                repositoryItemDateEdit.AutoHeight = false;
                repositoryItemDateEdit.EditFormat.FormatString = "HH:mm";
                repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                repositoryItemDateEdit.Mask.EditMask = "HH:mm";
                repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                repositoryItemDateEdit.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered;
                repositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
                repositoryItemDateEdit.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
                repositoryItemDateEdit.EditValueChanging += new ChangingEventHandler(repositoryItemDateEdit_EditValueChanged);
                column.ColumnEdit = repositoryItemDateEdit;
                this.RepositoryItems.Add(repositoryItemDateEdit);
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

        private void repositoryItemDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }

        private void RpItem_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Screen.Module).ShowDeliveryPlanTruckPointItems();
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour.ToString())
            {
                if (e.Value != null)
                {
                    ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = (ARDeliveryPlanTruckPointsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    DateTime DeliveryPlanTruckPointEstimatedHour = Convert.ToDateTime(e.Value);
                    if (!((DeliveryPlanModule)Screen.Module).CheckDeliveryPlanTruckPointEstimatedHour(objDeliveryPlanTruckPointsInfo, DeliveryPlanTruckPointEstimatedHour))
                    {
                        e.ErrorText = DeliveryPlanLocalizedResources.ErrorDeliveryPlanTruckPointEstimatedHour; ;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}
