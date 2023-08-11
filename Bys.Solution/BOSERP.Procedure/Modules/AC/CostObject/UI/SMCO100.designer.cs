using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostObject.UI
{
	/// <summary>
	/// Summary description for SMCO100
	/// </summary>
	partial class SMCO100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtACCostObjectNo;
        private BOSComponent.BOSTextBox fld_txtACCostObjectName;


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
            this.fld_txtACCostObjectNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACCostObjectName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcCostObjects = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCostObjects)).BeginInit();
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
            this.fld_lblLabel.Location = new System.Drawing.Point(26, 27);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(63, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã đối tượng";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(26, 54);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên đối tượng";
            // 
            // fld_txtACCostObjectNo
            // 
            this.fld_txtACCostObjectNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectNo.BOSDataMember = "ACCostObjectNo";
            this.fld_txtACCostObjectNo.BOSDataSource = "ACCostObjects";
            this.fld_txtACCostObjectNo.BOSDescription = null;
            this.fld_txtACCostObjectNo.BOSError = null;
            this.fld_txtACCostObjectNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectNo.BOSPropertyName = "Text";
            this.fld_txtACCostObjectNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectNo.Location = new System.Drawing.Point(128, 25);
            this.fld_txtACCostObjectNo.Name = "fld_txtACCostObjectNo";
            this.fld_txtACCostObjectNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostObjectNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostObjectNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostObjectNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostObjectNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostObjectNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostObjectNo.Screen = null;
            this.fld_txtACCostObjectNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostObjectNo.TabIndex = 0;
            this.fld_txtACCostObjectNo.Tag = "SC";
            // 
            // fld_txtACCostObjectName
            // 
            this.fld_txtACCostObjectName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectName.BOSDataMember = "ACCostObjectName";
            this.fld_txtACCostObjectName.BOSDataSource = "ACCostObjects";
            this.fld_txtACCostObjectName.BOSDescription = null;
            this.fld_txtACCostObjectName.BOSError = null;
            this.fld_txtACCostObjectName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectName.BOSPropertyName = "Text";
            this.fld_txtACCostObjectName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACCostObjectName.Location = new System.Drawing.Point(128, 51);
            this.fld_txtACCostObjectName.Name = "fld_txtACCostObjectName";
            this.fld_txtACCostObjectName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostObjectName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostObjectName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostObjectName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostObjectName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostObjectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostObjectName.Screen = null;
            this.fld_txtACCostObjectName.Size = new System.Drawing.Size(326, 20);
            this.fld_txtACCostObjectName.TabIndex = 1;
            this.fld_txtACCostObjectName.Tag = "SC";
            // 
            // fld_dgcCostObjects
            // 
            this.fld_dgcCostObjects.BOSComment = null;
            this.fld_dgcCostObjects.BOSDataMember = null;
            this.fld_dgcCostObjects.BOSDataSource = "ACCostObjects";
            this.fld_dgcCostObjects.BOSDescription = null;
            this.fld_dgcCostObjects.BOSError = null;
            this.fld_dgcCostObjects.BOSFieldGroup = null;
            this.fld_dgcCostObjects.BOSFieldRelation = null;
            this.fld_dgcCostObjects.BOSPrivilege = null;
            this.fld_dgcCostObjects.BOSPropertyName = null;
            this.fld_dgcCostObjects.Location = new System.Drawing.Point(26, 152);
            this.fld_dgcCostObjects.MenuManager = this.screenToolbar;
            this.fld_dgcCostObjects.Name = "fld_dgcCostObjects";
            this.fld_dgcCostObjects.Screen = null;
            this.fld_dgcCostObjects.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcCostObjects.TabIndex = 8;
            this.fld_dgcCostObjects.Tag = "SR";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(26, 80);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 22;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACCostObjects";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(128, 77);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMCO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcCostObjects);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtACCostObjectNo);
            this.Controls.Add(this.fld_txtACCostObjectName);
            this.Controls.Add(this.fld_lblLabel1);
            this.Name = "SMCO100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtACCostObjectName, 0);
            this.Controls.SetChildIndex(this.fld_txtACCostObjectNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcCostObjects, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCostObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcCostObjects;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
