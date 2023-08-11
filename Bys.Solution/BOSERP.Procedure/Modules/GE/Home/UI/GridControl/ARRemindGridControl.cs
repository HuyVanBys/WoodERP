using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class ARRemindGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RemindsList;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARCustomerID")
            {
                if (e.Value != null)
                {
                    int customerID = int.Parse(e.Value.ToString());
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objARCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                    if (objARCustomersInfo != null)
                    {
                        e.DisplayText = objARCustomersInfo.ARCustomerName;
                    }
                    else
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.RemindsList.SetEndCurrentEdit();
            return;
        }
    }
}
