using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRefundDirect.UI
{
	/// <summary>
	/// Summary description for SMARD100
	/// </summary>
	partial class SMARD100
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.fld_dgcHRAdvanceRefund = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAdvanceRefundNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAdvanceRefundNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRAdvanceRefund
            // 
            this.fld_dgcHRAdvanceRefund.BOSComment = null;
            this.fld_dgcHRAdvanceRefund.BOSDataMember = null;
            this.fld_dgcHRAdvanceRefund.BOSDataSource = "HRAdvanceRefunds";
            this.fld_dgcHRAdvanceRefund.BOSDescription = null;
            this.fld_dgcHRAdvanceRefund.BOSError = null;
            this.fld_dgcHRAdvanceRefund.BOSFieldGroup = null;
            this.fld_dgcHRAdvanceRefund.BOSFieldRelation = null;
            this.fld_dgcHRAdvanceRefund.BOSPrivilege = null;
            this.fld_dgcHRAdvanceRefund.BOSPropertyName = null;
            this.fld_dgcHRAdvanceRefund.Location = new System.Drawing.Point(68, 109);
            this.fld_dgcHRAdvanceRefund.MenuManager = this.screenToolbar;
            this.fld_dgcHRAdvanceRefund.Name = "fld_dgcHRAdvanceRefund";
            this.fld_dgcHRAdvanceRefund.Screen = null;
            this.fld_dgcHRAdvanceRefund.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRAdvanceRefund.TabIndex = 15;
            this.fld_dgcHRAdvanceRefund.Tag = "SR";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(24, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtACAdvanceRefundNo1
            // 
            this.fld_txtACAdvanceRefundNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtACAdvanceRefundNo1.BOSDataMember = "HRAdvanceRefundNo";
            this.fld_txtACAdvanceRefundNo1.BOSDataSource = "HRAdvanceRefunds";
            this.fld_txtACAdvanceRefundNo1.BOSDescription = null;
            this.fld_txtACAdvanceRefundNo1.BOSError = null;
            this.fld_txtACAdvanceRefundNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtACAdvanceRefundNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtACAdvanceRefundNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtACAdvanceRefundNo1.BOSPropertyName = "Text";
            this.fld_txtACAdvanceRefundNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtACAdvanceRefundNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACAdvanceRefundNo1.Name = "fld_txtACAdvanceRefundNo1";
            this.fld_txtACAdvanceRefundNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAdvanceRefundNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAdvanceRefundNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAdvanceRefundNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAdvanceRefundNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAdvanceRefundNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAdvanceRefundNo1.Screen = null;
            this.fld_txtACAdvanceRefundNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAdvanceRefundNo1.TabIndex = 11;
            this.fld_txtACAdvanceRefundNo1.Tag = "SC";
            // 
            // SMARD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRAdvanceRefund);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACAdvanceRefundNo1);
            this.Name = "SMARD100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACAdvanceRefundNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRAdvanceRefund, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRefund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAdvanceRefundNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcHRAdvanceRefund;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACAdvanceRefundNo1;
        private IContainer components;
	}
}
