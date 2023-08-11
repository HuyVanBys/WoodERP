using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EndingAllocation.UI
{
	/// <summary>
	/// Summary description for SMEA100
	/// </summary>
	partial class SMEA100
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
            this.fld_dgcACEndingAllocations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACEndingAllocationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACEndingAllocationDeclarationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACEndingAllocations
            // 
            this.fld_dgcACEndingAllocations.BOSComment = null;
            this.fld_dgcACEndingAllocations.BOSDataMember = null;
            this.fld_dgcACEndingAllocations.BOSDataSource = "ACEndingAllocations";
            this.fld_dgcACEndingAllocations.BOSDescription = null;
            this.fld_dgcACEndingAllocations.BOSError = null;
            this.fld_dgcACEndingAllocations.BOSFieldGroup = null;
            this.fld_dgcACEndingAllocations.BOSFieldRelation = null;
            this.fld_dgcACEndingAllocations.BOSPrivilege = null;
            this.fld_dgcACEndingAllocations.BOSPropertyName = null;
            this.fld_dgcACEndingAllocations.Location = new System.Drawing.Point(24, 61);
            this.fld_dgcACEndingAllocations.MenuManager = this.screenToolbar;
            this.fld_dgcACEndingAllocations.Name = "fld_dgcACEndingAllocations";
            this.fld_dgcACEndingAllocations.Screen = null;
            this.fld_dgcACEndingAllocations.Size = new System.Drawing.Size(432, 200);
            this.fld_dgcACEndingAllocations.TabIndex = 15;
            this.fld_dgcACEndingAllocations.Tag = "SR";
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
            // fld_txtACEndingAllocationNo1
            // 
            this.fld_txtACEndingAllocationNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACEndingAllocationNo1.BOSDataMember = "ACEndingAllocationNo";
            this.fld_txtACEndingAllocationNo1.BOSDataSource = "ACEndingAllocations";
            this.fld_txtACEndingAllocationNo1.BOSDescription = null;
            this.fld_txtACEndingAllocationNo1.BOSError = null;
            this.fld_txtACEndingAllocationNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACEndingAllocationNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACEndingAllocationNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACEndingAllocationNo1.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACEndingAllocationNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACEndingAllocationNo1.Name = "fld_txtACEndingAllocationNo1";
            this.fld_txtACEndingAllocationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationNo1.Screen = null;
            this.fld_txtACEndingAllocationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationNo1.TabIndex = 11;
            this.fld_txtACEndingAllocationNo1.Tag = "SC";
            // 
            // fld_lkeFK_ACEndingAllocationDeclarationID
            // 
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSComment = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDataMember = "FK_ACEndingAllocationDeclarationID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDataSource = "ACEndingAllocations";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSDescription = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSError = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldGroup = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldParent = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSFieldRelation = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSPrivilege = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSSelectType = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.CurrentDisplayText = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Location = new System.Drawing.Point(109, 35);
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Name = "fld_lkeFK_ACEndingAllocationDeclarationID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Screen = null;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACEndingAllocationDeclarationID.TabIndex = 599;
            this.fld_lkeFK_ACEndingAllocationDeclarationID.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(25, 38);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 600;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Mã phân bổ";
            // 
            // SMEA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(565, 279);
            this.Controls.Add(this.fld_lkeFK_ACEndingAllocationDeclarationID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_dgcACEndingAllocations);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACEndingAllocationNo1);
            this.Name = "SMEA100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACEndingAllocationNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcACEndingAllocations, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACEndingAllocationDeclarationID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEndingAllocationDeclarationID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACEndingAllocations;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationNo1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEndingAllocationDeclarationID;
        private BOSComponent.BOSLabel bosLabel5;
	}
}
