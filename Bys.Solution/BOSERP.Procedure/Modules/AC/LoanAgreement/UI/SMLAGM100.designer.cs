using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LoanAgreement.UI
{
	/// <summary>
	/// Summary description for SMLAGM100
	/// </summary>
	partial class SMLAGM100
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
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPPurchaseOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACLoanAgreementNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.Location = new System.Drawing.Point(31, 24);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(60, 13);
            this.fld_Lablel1.TabIndex = 21;
            this.fld_Lablel1.Tag = "SI";
            this.fld_Lablel1.Text = "Số hợp đồng";
            // 
            // fld_dgcAPPurchaseOrder
            // 
            this.fld_dgcAPPurchaseOrder.AllowDrop = true;
            this.fld_dgcAPPurchaseOrder.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSDataSource = "ACLoanAgreements";
            this.fld_dgcAPPurchaseOrder.BOSDescription = null;
            this.fld_dgcAPPurchaseOrder.BOSError = null;
            this.fld_dgcAPPurchaseOrder.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrder.Location = new System.Drawing.Point(31, 83);
            this.fld_dgcAPPurchaseOrder.MainView = this.fld_dgvAPPurchaseOrder;
            this.fld_dgcAPPurchaseOrder.Name = "fld_dgcAPPurchaseOrder";
            this.fld_dgcAPPurchaseOrder.Screen = null;
            this.fld_dgcAPPurchaseOrder.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPPurchaseOrder.TabIndex = 24;
            this.fld_dgcAPPurchaseOrder.Tag = "SR";
            this.fld_dgcAPPurchaseOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrder});
            // 
            // fld_dgvAPPurchaseOrder
            // 
            this.fld_dgvAPPurchaseOrder.GridControl = this.fld_dgcAPPurchaseOrder;
            this.fld_dgvAPPurchaseOrder.Name = "fld_dgvAPPurchaseOrder";
            this.fld_dgvAPPurchaseOrder.PaintStyleName = "Office2003";
            // 
            // fld_txtACLoanAgreementNo1
            // 
            this.fld_txtACLoanAgreementNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACLoanAgreementNo1.BOSDataMember = "ACLoanAgreementNo";
            this.fld_txtACLoanAgreementNo1.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementNo1.BOSDescription = null;
            this.fld_txtACLoanAgreementNo1.BOSError = null;
            this.fld_txtACLoanAgreementNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACLoanAgreementNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACLoanAgreementNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACLoanAgreementNo1.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACLoanAgreementNo1.Location = new System.Drawing.Point(113, 21);
            this.fld_txtACLoanAgreementNo1.Name = "fld_txtACLoanAgreementNo1";
            this.fld_txtACLoanAgreementNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementNo1.Screen = null;
            this.fld_txtACLoanAgreementNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementNo1.TabIndex = 15;
            this.fld_txtACLoanAgreementNo1.Tag = "SC";
            // 
            // SMLAGM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_Lablel1);
            this.Controls.Add(this.fld_dgcAPPurchaseOrder);
            this.Controls.Add(this.fld_txtACLoanAgreementNo1);
            this.Name = "SMLAGM100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementNo1, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPPurchaseOrder, 0);
            this.Controls.SetChildIndex(this.fld_Lablel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSSearchResultsGridControl fld_dgcAPPurchaseOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrder;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementNo1;
        private IContainer components;
	}
}
