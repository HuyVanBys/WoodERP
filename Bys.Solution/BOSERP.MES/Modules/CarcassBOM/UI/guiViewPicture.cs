using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class guiViewPicture : BOSERPScreen
    {
        #region Public Properties

        #endregion

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
        public guiViewPicture()
        {
            InitializeComponent();
        }

        private void guiViewPicture_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        public bool SetImage(string strImageLink)
        {
            try
            {
                pbx_ViewPicture.Load(strImageLink);
                return true;
            }
            catch
            {
                BOSApp.ShowMessage("Link ảnh hoặc định dạng hình ảnh không hợp lệ!" + Environment.NewLine + "Vui lòng kiểm tra lại!");
                return false;
            }
        }
    }
}
