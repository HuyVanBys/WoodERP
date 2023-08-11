using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Location
{
    public partial class guiAddLocation : BOSERPScreen
    {
        public guiAddLocation()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnAddLocation_Click(object sender, EventArgs e)
        {
            if (!((LocationModule)Module).CheckForValidLocation())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void guiAddLocation_Load(object sender, EventArgs e)
        {
            fld_txtGELocationName.Screen = this;
            fld_txtGELocationName.InitializeControl();
            fld_txtGELocationAbbreviation.Screen = this;
            fld_txtGELocationAbbreviation.InitializeControl();
            fld_medGELocationDesc.Screen = this;
            fld_medGELocationDesc.InitializeControl();
        }
    }
}
