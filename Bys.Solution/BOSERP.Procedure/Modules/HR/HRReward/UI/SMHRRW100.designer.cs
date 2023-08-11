using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRReward.UI
{
	/// <summary>
	/// Summary description for SMHRRW100
	/// </summary>
	partial class SMHRRW100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtHRRewardNo;
		private BOSComponent.BOSTextBox fld_txtHRRewardNo1;
		private BOSComponent.BOSTextBox fld_txtHRRewardName;
		private BOSSearchResultsGridControl fld_dgcHRReward;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRReward;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRewardNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRewardNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRewardName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcHRReward = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRReward = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(88, 74);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã khen thưởng";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(88, 100);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(90, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Lý do khen thưởng";
            // 
            // fld_txtHRRewardNo
            // 
            this.fld_txtHRRewardNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo.BOSDataMember = "HRRewardNo";
            this.fld_txtHRRewardNo.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardNo.BOSDescription = null;
            this.fld_txtHRRewardNo.BOSError = null;
            this.fld_txtHRRewardNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo.BOSPropertyName = "Text";
            this.fld_txtHRRewardNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo.Location = new System.Drawing.Point(1070, 117);
            this.fld_txtHRRewardNo.Name = "fld_txtHRRewardNo";
            this.fld_txtHRRewardNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardNo.Screen = null;
            this.fld_txtHRRewardNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRRewardNo.TabIndex = 6;
            this.fld_txtHRRewardNo.Tag = "SC";
            // 
            // fld_txtHRRewardNo1
            // 
            this.fld_txtHRRewardNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo1.BOSDataMember = "HRRewardNo";
            this.fld_txtHRRewardNo1.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardNo1.BOSDescription = null;
            this.fld_txtHRRewardNo1.BOSError = null;
            this.fld_txtHRRewardNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo1.BOSPropertyName = "Text";
            this.fld_txtHRRewardNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardNo1.Location = new System.Drawing.Point(194, 71);
            this.fld_txtHRRewardNo1.Name = "fld_txtHRRewardNo1";
            this.fld_txtHRRewardNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardNo1.Screen = null;
            this.fld_txtHRRewardNo1.Size = new System.Drawing.Size(181, 20);
            this.fld_txtHRRewardNo1.TabIndex = 0;
            this.fld_txtHRRewardNo1.Tag = "SC";
            // 
            // fld_txtHRRewardName
            // 
            this.fld_txtHRRewardName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardName.BOSDataMember = "HRRewardName";
            this.fld_txtHRRewardName.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardName.BOSDescription = null;
            this.fld_txtHRRewardName.BOSError = null;
            this.fld_txtHRRewardName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardName.BOSPropertyName = "Text";
            this.fld_txtHRRewardName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRRewardName.Location = new System.Drawing.Point(194, 97);
            this.fld_txtHRRewardName.Name = "fld_txtHRRewardName";
            this.fld_txtHRRewardName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardName.Screen = null;
            this.fld_txtHRRewardName.Size = new System.Drawing.Size(181, 20);
            this.fld_txtHRRewardName.TabIndex = 1;
            this.fld_txtHRRewardName.Tag = "SC";
            // 
            // fld_dgcHRReward
            // 
            this.fld_dgcHRReward.AllowDrop = true;
            this.fld_dgcHRReward.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.BOSDataSource = "HRRewards";
            this.fld_dgcHRReward.BOSDescription = null;
            this.fld_dgcHRReward.BOSError = null;
            this.fld_dgcHRReward.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRReward.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRReward.Location = new System.Drawing.Point(78, 157);
            this.fld_dgcHRReward.MainView = this.fld_dgvHRReward;
            this.fld_dgcHRReward.Name = "fld_dgcHRReward";
            this.fld_dgcHRReward.Screen = null;
            this.fld_dgcHRReward.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRReward.TabIndex = 3;
            this.fld_dgcHRReward.Tag = "SR";
            this.fld_dgcHRReward.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRReward});
            // 
            // fld_dgvHRReward
            // 
            this.fld_dgvHRReward.GridControl = this.fld_dgcHRReward;
            this.fld_dgvHRReward.Name = "fld_dgvHRReward";
            this.fld_dgvHRReward.PaintStyleName = "Office2003";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(88, 126);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRRewards";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(194, 123);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(181, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMHRRW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtHRRewardNo);
            this.Controls.Add(this.fld_dgcHRReward);
            this.Controls.Add(this.fld_txtHRRewardName);
            this.Controls.Add(this.fld_txtHRRewardNo1);
            this.Name = "SMHRRW100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRRewardNo1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRRewardName, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRReward, 0);
            this.Controls.SetChildIndex(this.fld_txtHRRewardNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
