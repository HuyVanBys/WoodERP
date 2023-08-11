using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledDeliveryPlan
{
    public class ARCanceledDeliveryPlanItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            CanceledDeliveryPlanEntities entity = (CanceledDeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CanceledDeliveryPlanItemsList;
            this.DataSource = bds;
        }

        public enum CanceledDeliveryPlanItemsColumnName
        {
            ARCanceledDeliveryPlanItemQty,
            ARCanceledDeliveryPlanItemComment,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ACObjectName";
            column.Caption = CommonLocalizedResources.ACObjectName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCanceledDeliveryPlanItemWoodQty";
            column.Caption = CommonLocalizedResources.WoodQtyText;
            column.OptionsColumn.AllowEdit = true;
            FormatNumbericColumn(column, true, "n5");
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            new CanceledDeliveryPlanItemsColumnName[]
            {
                CanceledDeliveryPlanItemsColumnName.ARCanceledDeliveryPlanItemQty,
                CanceledDeliveryPlanItemsColumnName.ARCanceledDeliveryPlanItemComment,
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
            //if(e.Column.FieldName == DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty.ToString())
            //    ((DeliveryPlanModule)Screen.Module).CheckDeliveryPlanItemProductQty();
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            CanceledDeliveryPlanEntities entity = (CanceledDeliveryPlanEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ARCanceledDeliveryPlanItemsInfo objCanceledDeliveryPlanItemsInfo = entity.CanceledDeliveryPlanItemsList[entity.CanceledDeliveryPlanItemsList.CurrentIndex];
            if (objCanceledDeliveryPlanItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == CanceledDeliveryPlanItemsColumnName.ARCanceledDeliveryPlanItemQty.ToString())
                {
                    if (e.Value != null)
                    {
                        decimal canceledDeliveryPlanItemQty = Convert.ToDecimal(e.Value);
                        if (canceledDeliveryPlanItemQty > objCanceledDeliveryPlanItemsInfo.ARCanceledDeliveryPlanItemTotalQty)
                        {
                            e.ErrorText = CanceledDeliveryPlanLocalizedResources.ErrorQty + objCanceledDeliveryPlanItemsInfo.ARCanceledDeliveryPlanItemTotalQty.ToString("n3");
                            e.Valid = false;
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
                ((CanceledDeliveryPlanModule)Screen.Module).DeleteItemFromCanceledDeliveryPlanItemsList();
            }
        }
    }
}
