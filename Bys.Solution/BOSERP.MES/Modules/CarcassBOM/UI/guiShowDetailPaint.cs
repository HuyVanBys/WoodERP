using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class guiShowDetailPaint : BOSERPScreen
    {
        #region Public Properties
        public List<MMProductionNormItemPaintDetailsInfo> ItemPaintDetailsList { get; set; }

        #endregion

        public guiShowDetailPaint(List<MMProductionNormItemPaintDetailsInfo> itemPaintDetailsList)
        {
            InitializeComponent();
            ItemPaintDetailsList = new BOSList<MMProductionNormItemPaintDetailsInfo>();
            ItemPaintDetailsList = itemPaintDetailsList;
        }

        private void guiProductionNormProcessInfos_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcMMProductionNormItemPaintDetailsGridControl.InitGridControlDataSource(ItemPaintDetailsList);
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

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
