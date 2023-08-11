using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;

namespace BOSERP.MES.Modules.Line
{
    public partial class OperationsGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            LineEntities entity = (LineEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationList;
            this.DataSource = bds;
        }
    }
}
