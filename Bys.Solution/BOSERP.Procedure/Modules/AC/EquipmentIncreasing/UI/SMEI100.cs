using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentIncreasing.UI
{
    /// <summary>
    /// Summary description for SMEI100
    /// </summary>
    public partial class SMEI100 : BOSERPScreen
    {

        public SMEI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        public override void BindingDataControl(Control ctrl)
        {
            if (ctrl.Name == "fld_lkeHRDepartmentRoomID")
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
