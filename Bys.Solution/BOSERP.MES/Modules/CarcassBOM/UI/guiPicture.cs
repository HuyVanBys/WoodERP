using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class guiPicture : BOSERPScreen
    {
        #region Public Properties

        #endregion
        public void SetImage(Image image)
        {
            fld_ptbProductPicture.Image = image;
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
        public guiPicture()
        {
            InitializeComponent();
        }
        private void guiPicture_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            //SetImage(ProductImage);
        }
    }
}
