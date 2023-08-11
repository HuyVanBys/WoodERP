using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.EInvoiceConfig
{
    public partial class ACEInvoicePaymentMethodsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EInvoiceConfigEntities entity = (EInvoiceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACEInvoicePaymentMethodsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ACEInvoicePaymentMethodNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
                repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repMruEdit.NullText = string.Empty;
                repMruEdit.Items.Clear();
                List<object> dataList = new List<object>();
                List<ADConfigValuesInfo> ConfigValuesList = ((EInvoiceConfigModule)Screen.Module).GetConfigDatasource("PaymentMethod");

                foreach (ADConfigValuesInfo item in ConfigValuesList)
                {
                    object objResult = item.ADConfigKeyValue;
                    dataList.Add(objResult);
                }
                repMruEdit.Items.AddRange(dataList);
                column.ColumnEdit = repMruEdit;

            }
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((EInvoiceConfigModule)Screen.Module).RemoveSelectedEInvoicePaymentMethodsList();
                }
            }
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "ACEInvoicePaymentMethodNo" && e.Value != null)
            {
                ACEInvoicePaymentMethodsInfo obj = (ACEInvoicePaymentMethodsInfo)gridView.GetFocusedRow();

                ((EInvoiceConfigModule)Screen.Module).ChangePaymentMethod(obj, e.Value.ToString());
            }
        }

    }
}
