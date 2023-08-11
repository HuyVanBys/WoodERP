using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiProposalApprovals : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<APProposalApprovalsInfo> ProposalApprovals { get; set; }
        #endregion

        public guiProposalApprovals(List<APProposalApprovalsInfo> proposalApprovals)
        {
            InitializeComponent();
            ProposalApprovals = proposalApprovals;
        }

        private void guiAllocationPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            gridControl1.DataSource = ProposalApprovals;
            //fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(ProposalApprovals);
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cardView1_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e)
        {
            CardView view = sender as CardView;
            APProposalApprovalsInfo item = (APProposalApprovalsInfo)view.GetRow(e.RowHandle);
            if (item == null)
                return;
            
            Brush backBrush, foreBrush;
            switch (item.APProposalApprovalAction)
            {
                case "Approve":
                    backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.Green, Color.LimeGreen, LinearGradientMode.ForwardDiagonal);
                    foreBrush = Brushes.Black;
                    break;
                case "Refuse":
                    backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.Red, Color.PaleVioletRed, LinearGradientMode.ForwardDiagonal);
                    foreBrush = Brushes.Black;
                    break;
                case "Recheck":
                    backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.Yellow, Color.LightYellow, LinearGradientMode.ForwardDiagonal);
                    foreBrush = Brushes.Black;
                    break;
                default:
                    backBrush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, LinearGradientMode.ForwardDiagonal);
                    foreBrush = Brushes.Black;
                    break;
            }
            Rectangle r = e.Bounds;
            r.Inflate(1, 0);
            e.Cache.FillRectangle(backBrush, r);
            string caption = BOSApp.GetDisplayTextFromConfigValue("ProposalApprovalAction", item.APProposalApprovalAction);
            e.Appearance.DrawString(e.Cache, caption, r, foreBrush);
            e.Handled = true;

        }
    }
}
