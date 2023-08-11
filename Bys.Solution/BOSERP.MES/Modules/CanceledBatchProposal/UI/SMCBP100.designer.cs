using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CanceledBatchProposal.UI
{
	/// <summary>
	/// Summary description for SMBP100
	/// </summary>
    partial class SMCBP100
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
            this.fld_txtMMCanceledProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMCanceledProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lkeFK_HREmpoyeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMCanceledProposalName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMCanceledProposalSaleOrderNos = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMCanceledProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMCanceledProposalBatchStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMCanceledProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCanceledProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalSaleOrderNos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalBatchStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(25, 43);
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
            this.fld_lblLabel2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(25, 69);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 26;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // fld_txtMMCanceledProposalNo
            // 
            this.fld_txtMMCanceledProposalNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSDataMember = "MMCanceledProposalNo";
            this.fld_txtMMCanceledProposalNo.BOSDataSource = "MMCanceledProposals";
            this.fld_txtMMCanceledProposalNo.BOSDescription = null;
            this.fld_txtMMCanceledProposalNo.BOSError = null;
            this.fld_txtMMCanceledProposalNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSPropertyName = "Text";
            this.fld_txtMMCanceledProposalNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.Location = new System.Drawing.Point(93, 40);
            this.fld_txtMMCanceledProposalNo.Name = "fld_txtMMCanceledProposalNo";
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMCanceledProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMCanceledProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMCanceledProposalNo.Screen = null;
            this.fld_txtMMCanceledProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMCanceledProposalNo.TabIndex = 2;
            this.fld_txtMMCanceledProposalNo.Tag = "SC";
            // 
            // fld_dgcMMCanceledProposals
            // 
            this.fld_dgcMMCanceledProposals.AllowDrop = true;
            this.fld_dgcMMCanceledProposals.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.BOSDataSource = "MMCanceledProposals";
            this.fld_dgcMMCanceledProposals.BOSDescription = null;
            this.fld_dgcMMCanceledProposals.BOSError = null;
            this.fld_dgcMMCanceledProposals.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMCanceledProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMCanceledProposals.Location = new System.Drawing.Point(25, 160);
            this.fld_dgcMMCanceledProposals.Name = "fld_dgcMMCanceledProposals";
            this.fld_dgcMMCanceledProposals.Screen = null;
            this.fld_dgcMMCanceledProposals.Size = new System.Drawing.Size(561, 272);
            this.fld_dgcMMCanceledProposals.TabIndex = 8;
            this.fld_dgcMMCanceledProposals.Tag = "SR";
            // 
            // fld_lkeFK_HREmpoyeeID
            // 
            this.fld_lkeFK_HREmpoyeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmpoyeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmpoyeeID.BOSComment = null;
            this.fld_lkeFK_HREmpoyeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.BOSDataSource = "MMCanceledProposals";
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
            this.fld_lkeFK_HREmpoyeeID.Location = new System.Drawing.Point(93, 66);
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
            this.fld_lkeFK_HREmpoyeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmpoyeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmpoyeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmpoyeeID, true);
            this.fld_lkeFK_HREmpoyeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmpoyeeID.TabIndex = 4;
            this.fld_lkeFK_HREmpoyeeID.Tag = "SC";
            // 
            // fld_txtMMCanceledProposalName
            // 
            this.fld_txtMMCanceledProposalName.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalName.BOSDataMember = "MMCanceledProposalName";
            this.fld_txtMMCanceledProposalName.BOSDataSource = "MMCanceledProposals";
            this.fld_txtMMCanceledProposalName.BOSDescription = null;
            this.fld_txtMMCanceledProposalName.BOSError = null;
            this.fld_txtMMCanceledProposalName.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalName.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalName.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalName.BOSPropertyName = "Text";
            this.fld_txtMMCanceledProposalName.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalName.Location = new System.Drawing.Point(93, 14);
            this.fld_txtMMCanceledProposalName.Name = "fld_txtMMCanceledProposalName";
            this.fld_txtMMCanceledProposalName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMCanceledProposalName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMCanceledProposalName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMCanceledProposalName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMCanceledProposalName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMCanceledProposalName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMCanceledProposalName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMCanceledProposalName, true);
            this.fld_txtMMCanceledProposalName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMCanceledProposalName.TabIndex = 0;
            this.fld_txtMMCanceledProposalName.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(25, 17);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(58, 13);
            this.bosLabel3.TabIndex = 347;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tên đề nghị";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(25, 95);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 26;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đơn hàng";
            // 
            // fld_txtMMCanceledProposalSaleOrderNos
            // 
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSDataMember = "MMCanceledProposalSaleOrderNos";
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSDataSource = "MMCanceledProposals";
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSDescription = null;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSError = null;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalSaleOrderNos.BOSPropertyName = "Text";
            this.fld_txtMMCanceledProposalSaleOrderNos.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMCanceledProposalSaleOrderNos.Location = new System.Drawing.Point(93, 92);
            this.fld_txtMMCanceledProposalSaleOrderNos.Name = "fld_txtMMCanceledProposalSaleOrderNos";
            this.fld_txtMMCanceledProposalSaleOrderNos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMCanceledProposalSaleOrderNos.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMCanceledProposalSaleOrderNos.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMCanceledProposalSaleOrderNos.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMCanceledProposalSaleOrderNos.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMCanceledProposalSaleOrderNos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMCanceledProposalSaleOrderNos.Screen = null;
            this.fld_txtMMCanceledProposalSaleOrderNos.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMCanceledProposalSaleOrderNos.TabIndex = 6;
            this.fld_txtMMCanceledProposalSaleOrderNos.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(275, 17);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 349;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMCanceledProposalItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = null;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(352, 14);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSupplierNumber", "Mã sản phẩm NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICproductBarCode", "Mã lô hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 1;
            this.fld_lkeFK_ICProductID.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(275, 69);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 354;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Loại đề nghị";
            // 
            // fld_lkeMMCanceledProposalType
            // 
            this.fld_lkeMMCanceledProposalType.BOSAllowAddNew = false;
            this.fld_lkeMMCanceledProposalType.BOSAllowDummy = false;
            this.fld_lkeMMCanceledProposalType.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSDataMember = "MMCanceledProposalType";
            this.fld_lkeMMCanceledProposalType.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeMMCanceledProposalType.BOSDescription = null;
            this.fld_lkeMMCanceledProposalType.BOSError = null;
            this.fld_lkeMMCanceledProposalType.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeMMCanceledProposalType.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.CurrentDisplayText = null;
            this.fld_lkeMMCanceledProposalType.Location = new System.Drawing.Point(352, 66);
            this.fld_lkeMMCanceledProposalType.Name = "fld_lkeMMCanceledProposalType";
            this.fld_lkeMMCanceledProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMCanceledProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMCanceledProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMCanceledProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMCanceledProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMCanceledProposalType.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalType.Properties.PopupWidth = 40;
            this.fld_lkeMMCanceledProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMCanceledProposalType.Screen = null;
            this.fld_lkeMMCanceledProposalType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMCanceledProposalType.TabIndex = 5;
            this.fld_lkeMMCanceledProposalType.Tag = "SC";
            // 
            // fld_lkeMMCanceledProposalBatchStatus
            // 
            this.fld_lkeMMCanceledProposalBatchStatus.BOSAllowAddNew = false;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSAllowDummy = false;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDataMember = "MMCanceledProposalBatchStatus";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDescription = null;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSError = null;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.CurrentDisplayText = null;
            this.fld_lkeMMCanceledProposalBatchStatus.Location = new System.Drawing.Point(352, 92);
            this.fld_lkeMMCanceledProposalBatchStatus.Name = "fld_lkeMMCanceledProposalBatchStatus";
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMCanceledProposalBatchStatus.Screen = null;
            this.fld_lkeMMCanceledProposalBatchStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMCanceledProposalBatchStatus.TabIndex = 7;
            this.fld_lkeMMCanceledProposalBatchStatus.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(275, 95);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 352;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Trạng thái";
            // 
            // fld_dteMMCanceledProposalDate
            // 
            this.fld_dteMMCanceledProposalDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSDataMember = "MMCanceledProposalDate";
            this.fld_dteMMCanceledProposalDate.BOSDataSource = "MMCanceledProposals";
            this.fld_dteMMCanceledProposalDate.BOSDescription = null;
            this.fld_dteMMCanceledProposalDate.BOSError = null;
            this.fld_dteMMCanceledProposalDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteMMCanceledProposalDate.EditValue = null;
            this.fld_dteMMCanceledProposalDate.Location = new System.Drawing.Point(352, 40);
            this.fld_dteMMCanceledProposalDate.Name = "fld_dteMMCanceledProposalDate";
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMCanceledProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMCanceledProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMCanceledProposalDate, true);
            this.fld_dteMMCanceledProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMCanceledProposalDate.TabIndex = 3;
            this.fld_dteMMCanceledProposalDate.Tag = "SC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel12.Location = new System.Drawing.Point(275, 43);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, true);
            this.fld_lblLabel12.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel12.TabIndex = 355;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Ngày đề nghị";
            // 
            // SMCBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(604, 567);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeMMCanceledProposalType);
            this.Controls.Add(this.fld_lkeMMCanceledProposalBatchStatus);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_dteMMCanceledProposalDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_ICProductID);
            this.Controls.Add(this.fld_txtMMCanceledProposalName);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HREmpoyeeID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtMMCanceledProposalSaleOrderNos);
            this.Controls.Add(this.fld_txtMMCanceledProposalNo);
            this.Controls.Add(this.fld_dgcMMCanceledProposals);
            this.Name = "SMCBP100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMCanceledProposals, 0);
            this.Controls.SetChildIndex(this.fld_txtMMCanceledProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_txtMMCanceledProposalSaleOrderNos, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmpoyeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtMMCanceledProposalName, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteMMCanceledProposalDate, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMCanceledProposalBatchStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMCanceledProposalType, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCanceledProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalSaleOrderNos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalBatchStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtMMCanceledProposalNo;
        private BOSSearchResultsGridControl fld_dgcMMCanceledProposals;        
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmpoyeeID;
        private BOSComponent.BOSTextBox fld_txtMMCanceledProposalName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMCanceledProposalSaleOrderNos;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeMMCanceledProposalType;
        private BOSComponent.BOSLookupEdit fld_lkeMMCanceledProposalBatchStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteMMCanceledProposalDate;
        private BOSComponent.BOSLabel fld_lblLabel12;
	}
}
