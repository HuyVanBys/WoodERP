using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiChooseBOM : BOSERPScreen
    {
        List<MMProductionNormsInfo> ProductionNormList { get; set; }

        public MMProductionNormsInfo ProductionNormsInfo { get; set; }

        public guiChooseBOM(List<MMProductionNormsInfo> productionNormList)
        {
            InitializeComponent();
            ProductionNormList = productionNormList;
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

        private void guiChooseBOM_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeFK_MMProductionNormID.Properties.DataSource = ProductionNormList;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            int productionNormID = 0;
            productionNormID = fld_lkeFK_MMProductionNormID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_MMProductionNormID.EditValue.ToString());

            if (productionNormID == 0)
            {
                MessageBox.Show("Bạn chưa chọn bảng định mức. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProductionNormsInfo = (MMProductionNormsInfo)fld_lkeFK_MMProductionNormID.GetSelectedDataRow();
            DialogResult = DialogResult.OK;
        }
    }
}
