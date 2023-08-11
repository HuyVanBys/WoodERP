using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HRLabouringConfig
{
    public partial class HRLabouringConfigItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRLabouringConfigItemList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                if (col.FieldName == "HRLabouringConfigItemOverTimeRate")
                {
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "{0:n2}";
                }
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRLabouringConfigsInfo objProposalsInfo = (HRLabouringConfigsInfo)entity.MainObject;
            if (entity.HRLabouringConfigItemList.CurrentIndex >= 0)
            {

                HRLabouringConfigItemsInfo item = (HRLabouringConfigItemsInfo)entity.HRLabouringConfigItemList[entity.HRLabouringConfigItemList.CurrentIndex];
                if (e.Column.FieldName == "HRLabouringConfigItemQty" || e.Column.FieldName == "HRLabouringConfigItemOverTimeQty")
                {
                    item.HRLabouringConfigItemTotalQty = item.HRLabouringConfigItemQty + item.HRLabouringConfigItemOverTimeQty;
                    if (item.HRLabouringConfigItemQty > 0)
                        item.HRLabouringConfigItemOverTimeRate = item.HRLabouringConfigItemTotalQty / item.HRLabouringConfigItemQty;
                    else
                        item.HRLabouringConfigItemOverTimeRate = 0;

                }
                entity.HRLabouringConfigItemList.GridControl.RefreshDataSource();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRLabouringConfigModule)Screen.Module).RemoveLabouringConfigItemList();
            }
        }
    }
}
