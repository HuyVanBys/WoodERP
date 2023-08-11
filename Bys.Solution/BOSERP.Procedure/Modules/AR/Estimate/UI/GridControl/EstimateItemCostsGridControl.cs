using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Estimate
{
    public class EstimateItemCostsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            EstimateEntities entity = (EstimateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EstimateItemCostsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            if (gridView.Columns["AREstimateItemProductName"] != null)
            {
                gridView.Columns["AREstimateItemProductName"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["AREstimateItemProductQty"] != null)
            {
                gridView.Columns["AREstimateItemProductQty"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductQty", "n2", gridView);
            }

            if (gridView.Columns["AREstimateItemProductUnitPrice"] != null)
            {
                gridView.Columns["AREstimateItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductUnitPrice", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalAmount"] != null)
            {
                gridView.Columns["AREstimateItemTotalAmount"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalAmount", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalCost"] != null)
            {
                gridView.Columns["AREstimateItemTotalCost"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalCost", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemProductDesc"] != null)
            {
                gridView.Columns["AREstimateItemProductDesc"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_APSupplierID"] != null)
            {
                gridView.Columns["FK_APSupplierID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICMeasureUnitID"] != null)
            {
                gridView.Columns["FK_ICMeasureUnitID"].OptionsColumn.AllowEdit = true;
            }

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView_InitNewRow);

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
            if (e.Column.FieldName == "AREstimateItemProductQty"
                || e.Column.FieldName == "AREstimateItemProductUnitPrice")
                ((EstimateModule)Screen.Module).ChangeEstimateItemCostQty();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EstimateModule)Screen.Module).RemoveItemFromList();
            }
        }

        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            EstimateEntities entity = (EstimateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            AREstimatesInfo mainObject = (AREstimatesInfo)entity.MainObject;
            AREstimateItemsInfo objEstimateItemsInfo = (AREstimateItemsInfo)view.GetRow(e.RowHandle);
            if (objEstimateItemsInfo != null)
            {
                objEstimateItemsInfo.AREstimateItemProductType = EstimateItemProductType.Cost.ToString();
                objEstimateItemsInfo.AREstimateItemProductQty = 1;
                if (((EstimateModule)Screen.Module).Toolbar.IsNullOrNoneAction() && mainObject.AREstimateStatus == EstimateStatus.New.ToString())
                {
                    ((EstimateModule)Screen.Module).ActionEdit();
                    entity.EstimateItemCostsList.Add(objEstimateItemsInfo);
                    entity.EstimateItemCostsList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }
        }

        protected override void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            AREstimateItemsInfo objEstimateItemsInfo = (AREstimateItemsInfo)e.Row;

            if (objEstimateItemsInfo != null)
            {
                if (string.IsNullOrEmpty(objEstimateItemsInfo.AREstimateItemProductName))
                {
                    e.ErrorText = EstimateLocalizedResources.AREstimateItemProductNameIsNullMessage;
                    e.Valid = false;
                }

            }
            base.GridView_ValidateRow(sender, e);
        }
    }
}
