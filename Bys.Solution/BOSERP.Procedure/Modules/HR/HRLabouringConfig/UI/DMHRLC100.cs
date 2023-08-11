using System;

namespace BOSERP.Modules.HRLabouringConfig.UI
{
    /// <summary>
    /// Summary description for DMHRLC100
    /// </summary>
    public partial class DMHRLC100 : BOSERPScreen
    {

        public DMHRLC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_dteHRLabouringConfigFromDate_EditValueChanged(object sender, EventArgs e)
        {
            // ((HRLabouringConfigModule)Module).ChangeLabouringConfigDate();
        }

        private void fld_dteHRLabouringConfigFromDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!((HRLabouringConfigModule)Module).Toolbar.IsNullOrNoneAction())
            {
                ((HRLabouringConfigModule)Module).ChangeLabouringConfigDate(Convert.ToDateTime(e.NewValue));
                fld_dteHRLabouringConfigFromDate.DateTime = Convert.ToDateTime(e.NewValue);
            }
        }
    }
}
