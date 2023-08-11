using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class HREmployeeMissingRecordsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeMissingRecordList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.EmployeeMissingRecordList.SetEndCurrentEdit();
            return;
        }
    }
}
