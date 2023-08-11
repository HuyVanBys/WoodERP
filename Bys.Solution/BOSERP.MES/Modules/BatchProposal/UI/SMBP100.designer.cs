using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProposal.UI
{
	/// <summary>
	/// Summary description for SMBP100
	/// </summary>
	partial class SMBP100
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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lkeFK_HREmpoyeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMProposalName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMProposalBatchStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProposalDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMProposalDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalBatchStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.Location = new System.Drawing.Point(25, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel.TabIndex = 23;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã đề nghị";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(25, 93);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 26;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // fld_txtMMProposalNo
            // 
            this.fld_txtMMProposalNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalNo.BOSDataMember = "MMProposalNo";
            this.fld_txtMMProposalNo.BOSDataSource = "MMProposals";
            this.fld_txtMMProposalNo.BOSDescription = null;
            this.fld_txtMMProposalNo.BOSError = null;
            this.fld_txtMMProposalNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalNo.BOSPropertyName = "Text";
            this.fld_txtMMProposalNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalNo.Location = new System.Drawing.Point(93, 12);
            this.fld_txtMMProposalNo.Name = "fld_txtMMProposalNo";
            this.fld_txtMMProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProposalNo.Screen = null;
            this.fld_txtMMProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProposalNo.TabIndex = 0;
            this.fld_txtMMProposalNo.Tag = "SC";
            // 
            // fld_dgcMMProposals
            // 
            this.fld_dgcMMProposals.AllowDrop = true;
            this.fld_dgcMMProposals.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.BOSDataSource = "MMProposals";
            this.fld_dgcMMProposals.BOSDescription = null;
            this.fld_dgcMMProposals.BOSError = null;
            this.fld_dgcMMProposals.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProposals.Location = new System.Drawing.Point(25, 202);
            this.fld_dgcMMProposals.Name = "fld_dgcMMProposals";
            this.fld_dgcMMProposals.Screen = null;
            this.fld_dgcMMProposals.Size = new System.Drawing.Size(561, 230);
            this.fld_dgcMMProposals.TabIndex = 8;
            this.fld_dgcMMProposals.Tag = "SR";
            // 
            // fld_lkeFK_HREmpoyeeID
            // 
            this.fld_lkeFK_HREmpoyeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmpoyeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmpoyeeID.BOSComment = null;
            this.fld_lkeFK_HREmpoyeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_HREmpoyeeID.BOSDescription = null;
            this.fld_lkeFK_HREmpoyeeID.BOSError = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmpoyeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmpoyeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmpoyeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmpoyeeID.Location = new System.Drawing.Point(93, 90);
            this.fld_lkeFK_HREmpoyeeID.Name = "fld_lkeFK_HREmpoyeeID";
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmpoyeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmpoyeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmpoyeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmpoyeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmpoyeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmpoyeeID, true);
            this.fld_lkeFK_HREmpoyeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmpoyeeID.TabIndex = 6;
            this.fld_lkeFK_HREmpoyeeID.Tag = "SC";
            // 
            // fld_txtMMProposalName
            // 
            this.fld_txtMMProposalName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalName.BOSDataMember = "MMProposalName";
            this.fld_txtMMProposalName.BOSDataSource = "MMProposals";
            this.fld_txtMMProposalName.BOSDescription = null;
            this.fld_txtMMProposalName.BOSError = null;
            this.fld_txtMMProposalName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalName.BOSPropertyName = "Text";
            this.fld_txtMMProposalName.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProposalName.Location = new System.Drawing.Point(354, 12);
            this.fld_txtMMProposalName.Name = "fld_txtMMProposalName";
            this.fld_txtMMProposalName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProposalName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProposalName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProposalName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProposalName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProposalName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProposalName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProposalName, true);
            this.fld_txtMMProposalName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProposalName.TabIndex = 1;
            this.fld_txtMMProposalName.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Location = new System.Drawing.Point(271, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(58, 13);
            this.bosLabel3.TabIndex = 347;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tên đề nghị";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(25, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 354;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Loại đề nghị";
            // 
            // fld_lkeMMProposalType
            // 
            this.fld_lkeMMProposalType.BOSAllowAddNew = false;
            this.fld_lkeMMProposalType.BOSAllowDummy = false;
            this.fld_lkeMMProposalType.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSDataMember = "MMProposalType";
            this.fld_lkeMMProposalType.BOSDataSource = "MMProposals";
            this.fld_lkeMMProposalType.BOSDescription = null;
            this.fld_lkeMMProposalType.BOSError = null;
            this.fld_lkeMMProposalType.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeMMProposalType.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.CurrentDisplayText = null;
            this.fld_lkeMMProposalType.Location = new System.Drawing.Point(93, 38);
            this.fld_lkeMMProposalType.Name = "fld_lkeMMProposalType";
            this.fld_lkeMMProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProposalType.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalType.Properties.PopupWidth = 40;
            this.fld_lkeMMProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProposalType.Screen = null;
            this.fld_lkeMMProposalType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMProposalType.TabIndex = 2;
            this.fld_lkeMMProposalType.Tag = "SC";
            // 
            // fld_lkeMMProposalBatchStatus
            // 
            this.fld_lkeMMProposalBatchStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProposalBatchStatus.BOSAllowDummy = false;
            this.fld_lkeMMProposalBatchStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSDataMember = "MMProposalBatchStatus";
            this.fld_lkeMMProposalBatchStatus.BOSDataSource = "MMProposals";
            this.fld_lkeMMProposalBatchStatus.BOSDescription = null;
            this.fld_lkeMMProposalBatchStatus.BOSError = null;
            this.fld_lkeMMProposalBatchStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProposalBatchStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.CurrentDisplayText = null;
            this.fld_lkeMMProposalBatchStatus.Location = new System.Drawing.Point(354, 38);
            this.fld_lkeMMProposalBatchStatus.Name = "fld_lkeMMProposalBatchStatus";
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProposalBatchStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProposalBatchStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMProposalBatchStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProposalBatchStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProposalBatchStatus.Screen = null;
            this.fld_lkeMMProposalBatchStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMProposalBatchStatus.TabIndex = 3;
            this.fld_lkeMMProposalBatchStatus.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(271, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 352;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Trạng thái";
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
            this.bosLabel5.Location = new System.Drawing.Point(271, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 372;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Đơn hàng";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(25, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(56, 13);
            this.bosLabel7.TabIndex = 373;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = null;
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(354, 64);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 5;
            this.fld_lkeFK_ARSaleOrderID.Tag = "SC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(25, 123);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel14.TabIndex = 584;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Từ ngày";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(271, 119);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel17.TabIndex = 585;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ngày";
            // 
            // fld_dteMMProposalDateFrom
            // 
            this.fld_dteMMProposalDateFrom.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateFrom.BOSDataMember = "MMProposalDateFrom";
            this.fld_dteMMProposalDateFrom.BOSDataSource = "MMProposals";
            this.fld_dteMMProposalDateFrom.BOSDescription = null;
            this.fld_dteMMProposalDateFrom.BOSError = null;
            this.fld_dteMMProposalDateFrom.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateFrom.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateFrom.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteMMProposalDateFrom.EditValue = null;
            this.fld_dteMMProposalDateFrom.Location = new System.Drawing.Point(93, 116);
            this.fld_dteMMProposalDateFrom.Name = "fld_dteMMProposalDateFrom";
            this.fld_dteMMProposalDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProposalDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProposalDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProposalDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProposalDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProposalDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProposalDateFrom.Screen = null;
            this.fld_dteMMProposalDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProposalDateFrom.TabIndex = 7;
            this.fld_dteMMProposalDateFrom.Tag = "SC";
            // 
            // fld_dteMMProposalDateTo
            // 
            this.fld_dteMMProposalDateTo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateTo.BOSDataMember = "MMProposalDateTo";
            this.fld_dteMMProposalDateTo.BOSDataSource = "MMProposals";
            this.fld_dteMMProposalDateTo.BOSDescription = null;
            this.fld_dteMMProposalDateTo.BOSError = null;
            this.fld_dteMMProposalDateTo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateTo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateTo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProposalDateTo.BOSPropertyName = "EditValue";
            this.fld_dteMMProposalDateTo.EditValue = null;
            this.fld_dteMMProposalDateTo.Location = new System.Drawing.Point(352, 116);
            this.fld_dteMMProposalDateTo.Name = "fld_dteMMProposalDateTo";
            this.fld_dteMMProposalDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProposalDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProposalDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProposalDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProposalDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProposalDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProposalDateTo.Screen = null;
            this.fld_dteMMProposalDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProposalDateTo.TabIndex = 8;
            this.fld_dteMMProposalDateTo.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(93, 64);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 4;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // SMBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(604, 567);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteMMProposalDateFrom);
            this.Controls.Add(this.fld_dteMMProposalDateTo);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeMMProposalType);
            this.Controls.Add(this.fld_lkeMMProposalBatchStatus);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_txtMMProposalName);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HREmpoyeeID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtMMProposalNo);
            this.Controls.Add(this.fld_dgcMMProposals);
            this.Name = "SMBP100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMProposals, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmpoyeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProposalName, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMProposalBatchStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMProposalType, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProposalDateTo, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProposalDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalBatchStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtMMProposalNo;
        private BOSSearchResultsGridControl fld_dgcMMProposals;        
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmpoyeeID;
        private BOSComponent.BOSTextBox fld_txtMMProposalName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeMMProposalType;
        private BOSComponent.BOSLookupEdit fld_lkeMMProposalBatchStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteMMProposalDateFrom;
        private BOSComponent.BOSDateEdit fld_dteMMProposalDateTo;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}
