using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class SuppliersGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SupplierList;
            this.DataSource = bds;
        }
    }
}
