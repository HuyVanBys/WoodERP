using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EndingAllocationDeclaration.UI
{
	/// <summary>
	/// Summary description for SMEAD100
	/// </summary>
	partial class SMEAD100
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
            this.fld_dgcACEndingAllocationDeclarations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACEndingAllocationDeclarationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEndingAllocationDeclarationMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEndingAllocationDeclarationType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACEndingAllocationDeclarations
            // 
            this.fld_dgcACEndingAllocationDeclarations.BOSComment = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSDataMember = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_dgcACEndingAllocationDeclarations.BOSDescription = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSError = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSFieldGroup = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSFieldRelation = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSPrivilege = null;
            this.fld_dgcACEndingAllocationDeclarations.BOSPropertyName = null;
            this.fld_dgcACEndingAllocationDeclarations.Location = new System.Drawing.Point(24, 87);
            this.fld_dgcACEndingAllocationDeclarations.MenuManager = this.screenToolbar;
            this.fld_dgcACEndingAllocationDeclarations.Name = "fld_dgcACEndingAllocationDeclarations";
            this.fld_dgcACEndingAllocationDeclarations.Screen = null;
            this.fld_dgcACEndingAllocationDeclarations.Size = new System.Drawing.Size(432, 174);
            this.fld_dgcACEndingAllocationDeclarations.TabIndex = 15;
            this.fld_dgcACEndingAllocationDeclarations.Tag = "SR";
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
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã phân bổ";
            // 
            // fld_txtACEndingAllocationDeclarationNo1
            // 
            this.fld_txtACEndingAllocationDeclarationNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSDataMember = "ACEndingAllocationDeclarationNo";
            this.fld_txtACEndingAllocationDeclarationNo1.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_txtACEndingAllocationDeclarationNo1.BOSDescription = null;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSError = null;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo1.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationDeclarationNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACEndingAllocationDeclarationNo1.Name = "fld_txtACEndingAllocationDeclarationNo1";
            this.fld_txtACEndingAllocationDeclarationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationDeclarationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationDeclarationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationDeclarationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationDeclarationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationDeclarationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationDeclarationNo1.Screen = null;
            this.fld_txtACEndingAllocationDeclarationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationDeclarationNo1.TabIndex = 11;
            this.fld_txtACEndingAllocationDeclarationNo1.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(25, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 590;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tiêu thức";
            // 
            // fld_lkeACEndingAllocationDeclarationMethod
            // 
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSAllowAddNew = false;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSAllowDummy = false;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSComment = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDataMember = "ACEndingAllocationDeclarationMethod";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDescription = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSError = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldGroup = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldParent = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldRelation = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSPrivilege = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSPropertyName = "EditValue";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.CurrentDisplayText = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.Location = new System.Drawing.Point(109, 61);
            this.fld_lkeACEndingAllocationDeclarationMethod.Name = "fld_lkeACEndingAllocationDeclarationMethod";
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEndingAllocationDeclarationMethod.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACEndingAllocationDeclarationMethod, true);
            this.fld_lkeACEndingAllocationDeclarationMethod.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEndingAllocationDeclarationMethod.TabIndex = 589;
            this.fld_lkeACEndingAllocationDeclarationMethod.Tag = "SC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(25, 38);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(62, 13);
            this.bosLabel17.TabIndex = 588;
            this.bosLabel17.Tag = "SI";
            this.bosLabel17.Text = "Kiểu phân bổ";
            // 
            // fld_lkeACEndingAllocationDeclarationType
            // 
            this.fld_lkeACEndingAllocationDeclarationType.BOSAllowAddNew = false;
            this.fld_lkeACEndingAllocationDeclarationType.BOSAllowDummy = false;
            this.fld_lkeACEndingAllocationDeclarationType.BOSComment = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSDataMember = "ACEndingAllocationDeclarationType";
            this.fld_lkeACEndingAllocationDeclarationType.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_lkeACEndingAllocationDeclarationType.BOSDescription = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSError = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldGroup = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldParent = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldRelation = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSPrivilege = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSPropertyName = "EditValue";
            this.fld_lkeACEndingAllocationDeclarationType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.CurrentDisplayText = null;
            this.fld_lkeACEndingAllocationDeclarationType.Location = new System.Drawing.Point(109, 35);
            this.fld_lkeACEndingAllocationDeclarationType.Name = "fld_lkeACEndingAllocationDeclarationType";
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEndingAllocationDeclarationType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEndingAllocationDeclarationType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACEndingAllocationDeclarationType, true);
            this.fld_lkeACEndingAllocationDeclarationType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEndingAllocationDeclarationType.TabIndex = 587;
            this.fld_lkeACEndingAllocationDeclarationType.Tag = "SC";
            // 
            // SMEAD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(565, 279);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeACEndingAllocationDeclarationMethod);
            this.Controls.Add(this.bosLabel17);
            this.Controls.Add(this.fld_lkeACEndingAllocationDeclarationType);
            this.Controls.Add(this.fld_dgcACEndingAllocationDeclarations);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACEndingAllocationDeclarationNo1);
            this.Name = "SMEAD100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACEndingAllocationDeclarationNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcACEndingAllocationDeclarations, 0);
            this.Controls.SetChildIndex(this.fld_lkeACEndingAllocationDeclarationType, 0);
            this.Controls.SetChildIndex(this.bosLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeACEndingAllocationDeclarationMethod, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACEndingAllocationDeclarations;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationDeclarationNo1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeACEndingAllocationDeclarationMethod;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeACEndingAllocationDeclarationType;
	}
}
