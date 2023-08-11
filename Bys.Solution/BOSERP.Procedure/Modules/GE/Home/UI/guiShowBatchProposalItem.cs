using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.Home
{
    public partial class guiShowBatchProposalItem : BOSERPScreen
    {
        #region Variables
        public BOSList<MMProposalItemsInfo> BatchProposalItemList { get; set; }

        #endregion
        public guiShowBatchProposalItem(List<MMProposalItemsInfo> batchProposalItemList)
        {
            InitializeComponent();
            BatchProposalItemList = new BOSList<MMProposalItemsInfo>(TableName.MMProposalItemsTableName);
            BatchProposalItemList.Invalidate(batchProposalItemList);
        }

        private void guiShowCollectionComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcBatchProposalItemsGridControl.InvalidateDataSource(BatchProposalItemList);
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}