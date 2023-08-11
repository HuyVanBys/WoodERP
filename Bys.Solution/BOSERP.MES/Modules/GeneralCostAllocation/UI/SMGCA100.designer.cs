using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.GeneralCostAllocation.UI
{
	/// <summary>
	/// Summary description for SMGCA100
	/// </summary>
	partial class SMGCA100
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
            this.fld_dgcMMProductionCostGeneralCostAllocations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostGeneralCostAllocationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACCreditAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACDebitAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMProductionCostFactorID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostGeneralCostAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCreditAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFactorID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMProductionCostGeneralCostAllocations
            // 
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSComment = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSDataMember = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSDescription = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSError = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSPrivilege = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.BOSPropertyName = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.Location = new System.Drawing.Point(24, 113);
            this.fld_dgcMMProductionCostGeneralCostAllocations.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionCostGeneralCostAllocations.Name = "fld_dgcMMProductionCostGeneralCostAllocations";
            this.fld_dgcMMProductionCostGeneralCostAllocations.Screen = null;
            this.fld_dgcMMProductionCostGeneralCostAllocations.Size = new System.Drawing.Size(432, 148);
            this.fld_dgcMMProductionCostGeneralCostAllocations.TabIndex = 4;
            this.fld_dgcMMProductionCostGeneralCostAllocations.Tag = "SR";
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
            // fld_txtMMProductionCostGeneralCostAllocationNo1
            // 
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSDataMember = "MMProductionCostGeneralCostAllocationNo";
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSDescription = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSError = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Name = "fld_txtMMProductionCostGeneralCostAllocationNo1";
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Screen = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.TabIndex = 0;
            this.fld_txtMMProductionCostGeneralCostAllocationNo1.Tag = "SC";
            // 
            // fld_lkeFK_ACCreditAccountID
            // 
            this.fld_lkeFK_ACCreditAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCreditAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACCreditAccountID.BOSComment = null;
            this.fld_lkeFK_ACCreditAccountID.BOSDataMember = "FK_ACCreditAccountID";
            this.fld_lkeFK_ACCreditAccountID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_ACCreditAccountID.BOSDescription = null;
            this.fld_lkeFK_ACCreditAccountID.BOSError = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACCreditAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACCreditAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACCreditAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACCreditAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACCreditAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACCreditAccountID.Location = new System.Drawing.Point(109, 61);
            this.fld_lkeFK_ACCreditAccountID.Name = "fld_lkeFK_ACCreditAccountID";
            this.fld_lkeFK_ACCreditAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCreditAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACCreditAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACCreditAccountID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ACCreditAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACCreditAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACCreditAccountID.Screen = null;
            this.fld_lkeFK_ACCreditAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACCreditAccountID.TabIndex = 2;
            this.fld_lkeFK_ACCreditAccountID.Tag = "SC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.Location = new System.Drawing.Point(25, 64);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(60, 13);
            this.bosLabel7.TabIndex = 340;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Tài khoản có";
            // 
            // fld_lkeFK_ACDebitAccountID
            // 
            this.fld_lkeFK_ACDebitAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDebitAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACDebitAccountID.BOSComment = null;
            this.fld_lkeFK_ACDebitAccountID.BOSDataMember = "FK_ACDebitAccountID";
            this.fld_lkeFK_ACDebitAccountID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_ACDebitAccountID.BOSDescription = null;
            this.fld_lkeFK_ACDebitAccountID.BOSError = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACDebitAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACDebitAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACDebitAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACDebitAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACDebitAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACDebitAccountID.Location = new System.Drawing.Point(109, 35);
            this.fld_lkeFK_ACDebitAccountID.Name = "fld_lkeFK_ACDebitAccountID";
            this.fld_lkeFK_ACDebitAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDebitAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACDebitAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACDebitAccountID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ACDebitAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDebitAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACDebitAccountID.Screen = null;
            this.fld_lkeFK_ACDebitAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACDebitAccountID.TabIndex = 1;
            this.fld_lkeFK_ACDebitAccountID.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(25, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(61, 13);
            this.bosLabel4.TabIndex = 338;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tài khoản nợ";
            // 
            // fld_lkeFK_MMProductionCostFactorID
            // 
            this.fld_lkeFK_MMProductionCostFactorID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionCostFactorID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionCostFactorID.BOSComment = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSDataMember = "FK_MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_MMProductionCostFactorID.BOSDescription = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSError = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionCostFactorID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionCostFactorID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionCostFactorID.Location = new System.Drawing.Point(109, 87);
            this.fld_lkeFK_MMProductionCostFactorID.Name = "fld_lkeFK_MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionCostFactorID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorNo", "Mã yếu tố"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố")});
            this.fld_lkeFK_MMProductionCostFactorID.Properties.DisplayMember = "MMProductionCostFactorName";
            this.fld_lkeFK_MMProductionCostFactorID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMProductionCostFactorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionCostFactorID.Properties.ValueMember = "MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.Screen = null;
            this.fld_lkeFK_MMProductionCostFactorID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMProductionCostFactorID.TabIndex = 3;
            this.fld_lkeFK_MMProductionCostFactorID.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.Location = new System.Drawing.Point(25, 90);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(31, 13);
            this.bosLabel8.TabIndex = 342;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Yếu tố";
            // 
            // SMGCA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(471, 279);
            this.Controls.Add(this.fld_lkeFK_MMProductionCostFactorID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_lkeFK_ACCreditAccountID);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeFK_ACDebitAccountID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dgcMMProductionCostGeneralCostAllocations);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMProductionCostGeneralCostAllocationNo1);
            this.Name = "SMGCA100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMProductionCostGeneralCostAllocationNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMProductionCostGeneralCostAllocations, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACDebitAccountID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACCreditAccountID, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMProductionCostFactorID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostGeneralCostAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCreditAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFactorID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMProductionCostGeneralCostAllocations;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostGeneralCostAllocationNo1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCreditAccountID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDebitAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionCostFactorID;
        private BOSComponent.BOSLabel bosLabel8;
	}
}
