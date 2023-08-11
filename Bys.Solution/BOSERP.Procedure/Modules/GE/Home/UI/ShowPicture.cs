using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class ShowPicture : BOSERPScreen
    {

        public ShowPicture()
        {
            InitializeComponent();
        }
        public ShowPicture(Image obj, List<ICProductProfilesInfo> listobject)
        {
            InitializeComponent();
            fld_pteHREmployeePicture.Image = obj;
            //fld_pteHREmployeePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            fld_dgcICProductProfiles.DataSource = listobject;
        }



        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void PrintWoodPlan_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);




        }






    }
}
