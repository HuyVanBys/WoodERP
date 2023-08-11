using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.StopAllocationEquipment.UI
{
	/// <summary>
	/// Summary description for SMNPB100
	/// </summary>
	partial class SMNPB100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtACStopAllocationEquipmentNo;


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
            this.fld_txtACStopAllocationEquipmentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACStopAllocationEquipmentStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACStopAllocationEquipmentFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACStopAllocationEquipments = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACStopAllocationEquipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtACStopAllocationEquipmentNo
            // 
            this.fld_txtACStopAllocationEquipmentNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopAllocationEquipmentNo.BOSDataMember = "ACStopAllocationEquipmentNo";
            this.fld_txtACStopAllocationEquipmentNo.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_txtACStopAllocationEquipmentNo.BOSDescription = null;
            this.fld_txtACStopAllocationEquipmentNo.BOSError = null;
            this.fld_txtACStopAllocationEquipmentNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopAllocationEquipmentNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopAllocationEquipmentNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopAllocationEquipmentNo.BOSPropertyName = "Text";
            this.fld_txtACStopAllocationEquipmentNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACStopAllocationEquipmentNo.Location = new System.Drawing.Point(166, 27);
            this.fld_txtACStopAllocationEquipmentNo.Name = "fld_txtACStopAllocationEquipmentNo";
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACStopAllocationEquipmentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACStopAllocationEquipmentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACStopAllocationEquipmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACStopAllocationEquipmentNo.Screen = null;
            this.fld_txtACStopAllocationEquipmentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACStopAllocationEquipmentNo.TabIndex = 0;
            this.fld_txtACStopAllocationEquipmentNo.Tag = "SC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.Location = new System.Drawing.Point(34, 134);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Từ ngày";
            // 
            // fld_dteACStopAllocationEquipmentStartDate
            // 
            this.fld_dteACStopAllocationEquipmentStartDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSDataMember = "ACStopAllocationEquipmentStartDate";
            this.fld_dteACStopAllocationEquipmentStartDate.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_dteACStopAllocationEquipmentStartDate.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSError = null;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentStartDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentStartDate.EditValue = null;
            this.fld_dteACStopAllocationEquipmentStartDate.Location = new System.Drawing.Point(166, 131);
            this.fld_dteACStopAllocationEquipmentStartDate.Name = "fld_dteACStopAllocationEquipmentStartDate";
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentStartDate.Screen = null;
            this.fld_dteACStopAllocationEquipmentStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACStopAllocationEquipmentStartDate.TabIndex = 4;
            this.fld_dteACStopAllocationEquipmentStartDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Location = new System.Drawing.Point(34, 160);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteACStopAllocationEquipmentFinishedDate
            // 
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSDataMember = "ACStopAllocationEquipmentFinishedDate";
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSDescription = null;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSError = null;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACStopAllocationEquipmentFinishedDate.BOSPropertyName = "EditValue";
            this.fld_dteACStopAllocationEquipmentFinishedDate.EditValue = null;
            this.fld_dteACStopAllocationEquipmentFinishedDate.Location = new System.Drawing.Point(166, 157);
            this.fld_dteACStopAllocationEquipmentFinishedDate.Name = "fld_dteACStopAllocationEquipmentFinishedDate";
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACStopAllocationEquipmentFinishedDate.Screen = null;
            this.fld_dteACStopAllocationEquipmentFinishedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACStopAllocationEquipmentFinishedDate.TabIndex = 5;
            this.fld_dteACStopAllocationEquipmentFinishedDate.Tag = "SC";
            // 
            // fld_dgcACStopAllocationEquipments
            // 
            this.fld_dgcACStopAllocationEquipments.BOSComment = null;
            this.fld_dgcACStopAllocationEquipments.BOSDataMember = null;
            this.fld_dgcACStopAllocationEquipments.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_dgcACStopAllocationEquipments.BOSDescription = null;
            this.fld_dgcACStopAllocationEquipments.BOSError = null;
            this.fld_dgcACStopAllocationEquipments.BOSFieldGroup = null;
            this.fld_dgcACStopAllocationEquipments.BOSFieldRelation = null;
            this.fld_dgcACStopAllocationEquipments.BOSPrivilege = null;
            this.fld_dgcACStopAllocationEquipments.BOSPropertyName = null;
            this.fld_dgcACStopAllocationEquipments.Location = new System.Drawing.Point(34, 209);
            this.fld_dgcACStopAllocationEquipments.MenuManager = this.screenToolbar;
            this.fld_dgcACStopAllocationEquipments.Name = "fld_dgcACStopAllocationEquipments";
            this.fld_dgcACStopAllocationEquipments.Screen = null;
            this.fld_dgcACStopAllocationEquipments.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACStopAllocationEquipments.TabIndex = 11;
            this.fld_dgcACStopAllocationEquipments.Tag = "SR";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Location = new System.Drawing.Point(34, 82);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 24;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã định danh";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel12.Location = new System.Drawing.Point(34, 56);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(45, 13);
            this.bosLabel12.TabIndex = 23;
            this.bosLabel12.Tag = "SI";
            this.bosLabel12.Text = "Mã CCDC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Location = new System.Drawing.Point(34, 108);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 26;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(166, 105);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ICProductID";
            this.bosLookupEdit1.BOSDataSource = "ACStopAllocationEquipments";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(166, 53);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã CCDC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên CCDC")});
            this.bosLookupEdit1.Properties.DisplayMember = "ICProductNo";
            this.bosLookupEdit1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ICProductID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 1;
            this.bosLookupEdit1.Tag = "SC";
            // 
            // fld_lkeFK_ICProductIdentifiedEquipmentID
            // 
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSComment = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDataMember = "FK_ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDataSource = "ACStopAllocationEquipments";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSDescription = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSError = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSSelectType = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Location = new System.Drawing.Point(166, 79);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Name = "fld_lkeFK_ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Screen = null;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.TabIndex = 2;
            this.fld_lkeFK_ICProductIdentifiedEquipmentID.Tag = "SC";
            // 
            // SMNPB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(599, 567);
            this.Controls.Add(this.fld_lkeFK_ICProductIdentifiedEquipmentID);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel12);
            this.Controls.Add(this.fld_dgcACStopAllocationEquipments);
            this.Controls.Add(this.fld_dteACStopAllocationEquipmentFinishedDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteACStopAllocationEquipmentStartDate);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtACStopAllocationEquipmentNo);
            this.Name = "SMNPB100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACStopAllocationEquipmentNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteACStopAllocationEquipmentStartDate, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteACStopAllocationEquipmentFinishedDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcACStopAllocationEquipments, 0);
            this.Controls.SetChildIndex(this.bosLabel12, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductIdentifiedEquipmentID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACStopAllocationEquipmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACStopAllocationEquipmentFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACStopAllocationEquipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductIdentifiedEquipmentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACStopAllocationEquipmentStartDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACStopAllocationEquipmentFinishedDate;
        private BOSSearchResultsGridControl fld_dgcACStopAllocationEquipments;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductIdentifiedEquipmentID;
	}
}
