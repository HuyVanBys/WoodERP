using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder.UI
{
    /// <summary>
    /// Summary description for SMPO100
    /// </summary>
    public partial class SMPO100 : BOSERPScreen
    {

        public SMPO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        public override void BindingDataControl(Control ctrl)
        {
            if (ctrl.Name == "fld_lkeGELocationID")
            {
                BOSLookupEdit lke = (BOSLookupEdit)ctrl;
                ctrl.DataBindings.Add(new Binding(lke.BOSPropertyName,
                                                ((BaseModuleERP)Module).CurrentModuleEntity.SearchObject,
                                                lke.BOSDataMember,
                                                true,
                                                DataSourceUpdateMode.OnPropertyChanged));
            }
            else
            {
                base.BindingDataControl(ctrl);
            }
        }
    }
}
