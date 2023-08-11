using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.JobTicket.UI
{
	/// <summary>
	/// Summary description for SMJT100
	/// </summary>
	partial class SMJT100
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
            this.fld_txtMMJobTicketNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMJobTickets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMJobTickets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMJobTicketName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToMMJobTicketFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromMMJobTicketFromDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMJobTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMJobTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMJobTicketFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMJobTicketFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMJobTicketFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMJobTicketFromDate.Properties)).BeginInit();
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
            this.fld_lblLabel.Location = new System.Drawing.Point(41, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 366;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtMMJobTicketNo
            // 
            this.fld_txtMMJobTicketNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMJobTicketNo.BOSDataMember = "MMJobTicketNo";
            this.fld_txtMMJobTicketNo.BOSDataSource = "MMJobTickets";
            this.fld_txtMMJobTicketNo.BOSDescription = null;
            this.fld_txtMMJobTicketNo.BOSError = null;
            this.fld_txtMMJobTicketNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMJobTicketNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMJobTicketNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMJobTicketNo.BOSPropertyName = "Text";
            this.fld_txtMMJobTicketNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMJobTicketNo.Location = new System.Drawing.Point(135, 12);
            this.fld_txtMMJobTicketNo.Name = "fld_txtMMJobTicketNo";
            this.fld_txtMMJobTicketNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMJobTicketNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMJobTicketNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMJobTicketNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMJobTicketNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMJobTicketNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMJobTicketNo.Screen = null;
            this.fld_txtMMJobTicketNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMJobTicketNo.TabIndex = 357;
            this.fld_txtMMJobTicketNo.Tag = "SC";
            // 
            // fld_dgcMMJobTickets
            // 
            this.fld_dgcMMJobTickets.AllowDrop = true;
            this.fld_dgcMMJobTickets.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.BOSDataSource = "MMJobTickets";
            this.fld_dgcMMJobTickets.BOSDescription = null;
            this.fld_dgcMMJobTickets.BOSError = null;
            this.fld_dgcMMJobTickets.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.BOSGridType = null;
            this.fld_dgcMMJobTickets.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTickets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMJobTickets.Location = new System.Drawing.Point(41, 212);
            this.fld_dgcMMJobTickets.MainView = this.fld_dgvMMJobTickets;
            this.fld_dgcMMJobTickets.Name = "fld_dgcMMJobTickets";
            this.fld_dgcMMJobTickets.PrintReport = false;
            this.fld_dgcMMJobTickets.Screen = null;
            this.fld_dgcMMJobTickets.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMJobTickets.TabIndex = 365;
            this.fld_dgcMMJobTickets.Tag = "SR";
            this.fld_dgcMMJobTickets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMJobTickets});
            // 
            // fld_dgvMMJobTickets
            // 
            this.fld_dgvMMJobTickets.GridControl = this.fld_dgcMMJobTickets;
            this.fld_dgvMMJobTickets.Name = "fld_dgvMMJobTickets";
            this.fld_dgvMMJobTickets.PaintStyleName = "Office2003";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(41, 119);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(12, 13);
            this.bosLabel12.TabIndex = 379;
            this.bosLabel12.Tag = "SI";
            this.bosLabel12.Text = "Tổ";
            // 
            // lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = false;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "MMJobTickets";
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(135, 116);
            this.lkeFK_HRDepartmentRoomGroupItemID.Name = "lkeFK_HRDepartmentRoomGroupItemID";
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tên")});
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(171, 20);
            this.lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 375;
            this.lkeFK_HRDepartmentRoomGroupItemID.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(41, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(37, 13);
            this.bosLabel8.TabIndex = 378;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Chuyền";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(41, 67);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(31, 13);
            this.bosLabel10.TabIndex = 377;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Xưởng";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = false;
            this.fld_lkeFK_MMLineID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMJobTickets";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(135, 90);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 374;
            this.fld_lkeFK_MMLineID.Tag = "SC";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = false;
            this.fld_lkeFK_MMWorkShopID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMJobTickets";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(135, 64);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 373;
            this.fld_lkeFK_MMWorkShopID.Tag = "SC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(41, 145);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(52, 13);
            this.bosLabel11.TabIndex = 380;
            this.bosLabel11.Tag = "SI";
            this.bosLabel11.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMJobTickets";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "True";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(135, 142);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 376;
            this.fld_lkeFK_MMOperationID.Tag = "SC";
            // 
            // fld_txtMMJobTicketName
            // 
            this.fld_txtMMJobTicketName.BOSComment = null;
            this.fld_txtMMJobTicketName.BOSDataMember = "MMJobTicketName";
            this.fld_txtMMJobTicketName.BOSDataSource = "MMJobTickets";
            this.fld_txtMMJobTicketName.BOSDescription = null;
            this.fld_txtMMJobTicketName.BOSError = null;
            this.fld_txtMMJobTicketName.BOSFieldGroup = null;
            this.fld_txtMMJobTicketName.BOSFieldRelation = null;
            this.fld_txtMMJobTicketName.BOSPrivilege = null;
            this.fld_txtMMJobTicketName.BOSPropertyName = "EditValue";
            this.fld_txtMMJobTicketName.Location = new System.Drawing.Point(135, 38);
            this.fld_txtMMJobTicketName.Name = "fld_txtMMJobTicketName";
            this.fld_txtMMJobTicketName.Screen = null;
            this.fld_txtMMJobTicketName.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMJobTicketName.TabIndex = 367;
            this.fld_txtMMJobTicketName.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(41, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 371;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tên chứng từ";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(347, 171);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 372;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(41, 171);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(61, 13);
            this.bosLabel9.TabIndex = 370;
            this.bosLabel9.Tag = "SI";
            this.bosLabel9.Text = "Thực hiện từ";
            // 
            // fld_dteSearchToMMJobTicketFromDate
            // 
            this.fld_dteSearchToMMJobTicketFromDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMJobTicketFromDate.BOSDataMember = "MMJobTicketToDate";
            this.fld_dteSearchToMMJobTicketFromDate.BOSDataSource = "MMJobTickets";
            this.fld_dteSearchToMMJobTicketFromDate.BOSDescription = null;
            this.fld_dteSearchToMMJobTicketFromDate.BOSError = null;
            this.fld_dteSearchToMMJobTicketFromDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMJobTicketFromDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMJobTicketFromDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMJobTicketFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMJobTicketFromDate.EditValue = null;
            this.fld_dteSearchToMMJobTicketFromDate.Location = new System.Drawing.Point(416, 168);
            this.fld_dteSearchToMMJobTicketFromDate.Name = "fld_dteSearchToMMJobTicketFromDate";
            this.fld_dteSearchToMMJobTicketFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToMMJobTicketFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToMMJobTicketFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToMMJobTicketFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToMMJobTicketFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMJobTicketFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMJobTicketFromDate.Screen = null;
            this.fld_dteSearchToMMJobTicketFromDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteSearchToMMJobTicketFromDate.TabIndex = 368;
            this.fld_dteSearchToMMJobTicketFromDate.Tag = "SC";
            // 
            // fld_dteSearchFromMMJobTicketFromDate
            // 
            this.fld_dteSearchFromMMJobTicketFromDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSDataMember = "MMJobTicketFromDate";
            this.fld_dteSearchFromMMJobTicketFromDate.BOSDataSource = "MMJobTickets";
            this.fld_dteSearchFromMMJobTicketFromDate.BOSDescription = null;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSError = null;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMJobTicketFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMJobTicketFromDate.EditValue = null;
            this.fld_dteSearchFromMMJobTicketFromDate.Location = new System.Drawing.Point(135, 168);
            this.fld_dteSearchFromMMJobTicketFromDate.Name = "fld_dteSearchFromMMJobTicketFromDate";
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMJobTicketFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMJobTicketFromDate.Screen = null;
            this.fld_dteSearchFromMMJobTicketFromDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteSearchFromMMJobTicketFromDate.TabIndex = 369;
            this.fld_dteSearchFromMMJobTicketFromDate.Tag = "SC";
            // 
            // SMJT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(608, 502);
            this.Controls.Add(this.bosLabel12);
            this.Controls.Add(this.lkeFK_HRDepartmentRoomGroupItemID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_lkeFK_MMLineID);
            this.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.Controls.Add(this.fld_txtMMJobTicketName);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.fld_dteSearchToMMJobTicketFromDate);
            this.Controls.Add(this.fld_dteSearchFromMMJobTicketFromDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtMMJobTicketNo);
            this.Controls.Add(this.fld_dgcMMJobTickets);
            this.Name = "SMJT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMJobTickets, 0);
            this.Controls.SetChildIndex(this.fld_txtMMJobTicketNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMJobTicketFromDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToMMJobTicketFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtMMJobTicketName, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMOperationID, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMWorkShopID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMLineID, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.lkeFK_HRDepartmentRoomGroupItemID, 0);
            this.Controls.SetChildIndex(this.bosLabel12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMJobTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMJobTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMJobTicketFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMJobTicketFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMJobTicketFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMJobTicketFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtMMJobTicketNo;
        private BOSSearchResultsGridControl fld_dgcMMJobTickets;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMJobTickets;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSTextBox fld_txtMMJobTicketName;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMJobTicketFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromMMJobTicketFromDate;
	}
}
