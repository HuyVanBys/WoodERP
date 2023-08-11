using System.ComponentModel;

namespace BOSERP.Modules.KPI.UI
{
    /// <summary>
    /// Summary description for DMUCC100
    /// </summary>
    public partial class DMKPI100 : BOSERPScreen
    {

        public DMKPI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_ccbeHRDerpartment_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_ccbeHRDerpartment.Properties.DataSource = ((KPIModule)Module).GetDerpartmentDatasource();
            fld_ccbeHRDerpartment.Properties.DisplayMember = "HRDepartmentName";
            fld_ccbeHRDerpartment.Properties.ValueMember = "HRDepartmentID";
        }

        private void fld_ccbeHRDerpartment_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_ccbeHRDerpartment.EditValue != e.Value)
            {
                ((KPIModule)Module).ChangeMoreDerpartment(e.Value.ToString());
            }
        }
    }
}
