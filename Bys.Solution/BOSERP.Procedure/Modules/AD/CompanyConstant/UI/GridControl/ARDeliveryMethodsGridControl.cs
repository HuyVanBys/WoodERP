using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ARDeliveryMethodsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryMethodsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        protected void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedARDeliveryMethods();
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARDeliveryMethodNo" || gridView.FocusedColumn.FieldName == "ARDeliveryMethodName")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullARDeliveryMethodNameOrNo;
                        e.Valid = false;
                    }
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            ARDeliveryMethodsInfo objDeliveryMethodsInfo = (ARDeliveryMethodsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objDeliveryMethodsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARDeliveryMethodIsContainerLoader")
                {
                    if (objDeliveryMethodsInfo.ARDeliveryMethodIsContainerLoader)
                    {
                        //objDeliveryMethodsInfo.ARDeliveryMethodIsDeliveryPlan = false;
                        objDeliveryMethodsInfo.ARDeliveryMethodIsSaleOrderShipment = false;
                        objDeliveryMethodsInfo.ARDeliveryMethodIsAcceptance = false;
                        //objDeliveryMethodsInfo.ARDeliveryMethodIsInvoiceAndShipment = false;
                        objDeliveryMethodsInfo.ARDeliveryMethodIsVehicleAllocation = false;
                    }
                }
                else
                {
                    if (//objDeliveryMethodsInfo.ARDeliveryMethodIsDeliveryPlan
                        objDeliveryMethodsInfo.ARDeliveryMethodIsSaleOrderShipment
                        || objDeliveryMethodsInfo.ARDeliveryMethodIsAcceptance
                        //|| objDeliveryMethodsInfo.ARDeliveryMethodIsInvoiceAndShipment
                        || objDeliveryMethodsInfo.ARDeliveryMethodIsVehicleAllocation)
                    {
                        objDeliveryMethodsInfo.ARDeliveryMethodIsContainerLoader = false;
                    }
                }
            }
        }
    }
}
