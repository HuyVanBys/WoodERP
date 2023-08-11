using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AllocationProposal.UI
{
	/// <summary>
	/// Summary description for SMAPL100
	/// </summary>
	partial class SMAPL100
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
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMAllocationPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToMMAllocationProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromMMAllocationProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMAllocationProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMAllocationPlanSearchGridControls = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemSearchResultGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMAllocationPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMAllocationProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMAllocationProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMAllocationProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMAllocationProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMAllocationProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanSearchGridControls)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(273, 96);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 371;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Đơn hàng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(30, 96);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, true);
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 372;
            this.fld_lblLabel10.Tag = "SI";
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMAllocationPlans";
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
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(341, 93);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDesc", "Ghi chú")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 361;
            this.fld_lkeFK_ARSaleOrderID.Tag = "SC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(98, 93);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên KH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "ĐT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerTaxNumber", "MST"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerWebsite", "Website")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARCustomerID, true);
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 362;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // fld_dgcFK_MMBatchProductID
            // 
            this.fld_dgcFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_dgcFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_dgcFK_MMBatchProductID.BOSComment = null;
            this.fld_dgcFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.BOSDataSource = "MMAllocationProposals";
            this.fld_dgcFK_MMBatchProductID.BOSDescription = null;
            this.fld_dgcFK_MMBatchProductID.BOSError = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_dgcFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_dgcFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_dgcFK_MMBatchProductID.BOSSelectType = null;
            this.fld_dgcFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_dgcFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_dgcFK_MMBatchProductID.Location = new System.Drawing.Point(341, 67);
            this.fld_dgcFK_MMBatchProductID.Name = "fld_dgcFK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dgcFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_dgcFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductName", "Tên")});
            this.fld_dgcFK_MMBatchProductID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_dgcFK_MMBatchProductID.Properties.NullText = "";
            this.fld_dgcFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dgcFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Screen = null;
            this.fld_dgcFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_dgcFK_MMBatchProductID.TabIndex = 360;
            this.fld_dgcFK_MMBatchProductID.Tag = "SC";
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
            this.bosLabel5.Location = new System.Drawing.Point(273, 70);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(34, 13);
            this.bosLabel5.TabIndex = 370;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Mã LSX";
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
            this.bosLabel4.Location = new System.Drawing.Point(30, 70);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 369;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(98, 67);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 358;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeMMAllocationPlanStatus
            // 
            this.fld_lkeMMAllocationPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeMMAllocationPlanStatus.BOSAllowDummy = false;
            this.fld_lkeMMAllocationPlanStatus.BOSComment = "";
            this.fld_lkeMMAllocationPlanStatus.BOSDataMember = "MMAllocationPlanStatus";
            this.fld_lkeMMAllocationPlanStatus.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeMMAllocationPlanStatus.BOSDescription = null;
            this.fld_lkeMMAllocationPlanStatus.BOSError = null;
            this.fld_lkeMMAllocationPlanStatus.BOSFieldGroup = "";
            this.fld_lkeMMAllocationPlanStatus.BOSFieldParent = "";
            this.fld_lkeMMAllocationPlanStatus.BOSFieldRelation = "";
            this.fld_lkeMMAllocationPlanStatus.BOSPrivilege = "";
            this.fld_lkeMMAllocationPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMAllocationPlanStatus.BOSSelectType = "";
            this.fld_lkeMMAllocationPlanStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMAllocationPlanStatus.CurrentDisplayText = "";
            this.fld_lkeMMAllocationPlanStatus.Location = new System.Drawing.Point(341, 41);
            this.fld_lkeMMAllocationPlanStatus.Name = "fld_lkeMMAllocationPlanStatus";
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMAllocationPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMAllocationPlanStatus.Properties.ColumnName = null;
            this.fld_lkeMMAllocationPlanStatus.Properties.NullText = "";
            this.fld_lkeMMAllocationPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMAllocationPlanStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMAllocationPlanStatus, true);
            this.fld_lkeMMAllocationPlanStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMAllocationPlanStatus.TabIndex = 359;
            this.fld_lkeMMAllocationPlanStatus.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(273, 44);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 368;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteSearchToMMAllocationProposalDate
            // 
            this.fld_dteSearchToMMAllocationProposalDate.BOSComment = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSDataMember = "AllocationPlanDateTo";
            this.fld_dteSearchToMMAllocationProposalDate.BOSDataSource = "MMAllocationPlans";
            this.fld_dteSearchToMMAllocationProposalDate.BOSDescription = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSError = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSPrivilege = null;
            this.fld_dteSearchToMMAllocationProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMAllocationProposalDate.EditValue = null;
            this.fld_dteSearchToMMAllocationProposalDate.Location = new System.Drawing.Point(341, 119);
            this.fld_dteSearchToMMAllocationProposalDate.Name = "fld_dteSearchToMMAllocationProposalDate";
            this.fld_dteSearchToMMAllocationProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMAllocationProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMAllocationProposalDate.Screen = null;
            this.fld_dteSearchToMMAllocationProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMAllocationProposalDate.TabIndex = 364;
            this.fld_dteSearchToMMAllocationProposalDate.Tag = "SC";
            // 
            // fld_dteSearchFromMMAllocationProposalDate
            // 
            this.fld_dteSearchFromMMAllocationProposalDate.BOSComment = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSDataMember = "AllocationPlanDateFrom";
            this.fld_dteSearchFromMMAllocationProposalDate.BOSDataSource = "MMAllocationPlans";
            this.fld_dteSearchFromMMAllocationProposalDate.BOSDescription = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSError = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSFieldGroup = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSPrivilege = null;
            this.fld_dteSearchFromMMAllocationProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMAllocationProposalDate.EditValue = null;
            this.fld_dteSearchFromMMAllocationProposalDate.Location = new System.Drawing.Point(98, 119);
            this.fld_dteSearchFromMMAllocationProposalDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromMMAllocationProposalDate.Name = "fld_dteSearchFromMMAllocationProposalDate";
            this.fld_dteSearchFromMMAllocationProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMAllocationProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMAllocationProposalDate.Screen = null;
            this.fld_dteSearchFromMMAllocationProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMAllocationProposalDate.TabIndex = 363;
            this.fld_dteSearchFromMMAllocationProposalDate.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(30, 44);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 365;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(273, 122);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 366;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(30, 122);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 367;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_txtMMAllocationProposalNo
            // 
            this.fld_txtMMAllocationProposalNo.BOSComment = "";
            this.fld_txtMMAllocationProposalNo.BOSDataMember = "MMAllocationPlanNo";
            this.fld_txtMMAllocationProposalNo.BOSDataSource = "MMAllocationPlans";
            this.fld_txtMMAllocationProposalNo.BOSDescription = null;
            this.fld_txtMMAllocationProposalNo.BOSError = null;
            this.fld_txtMMAllocationProposalNo.BOSFieldGroup = "";
            this.fld_txtMMAllocationProposalNo.BOSFieldRelation = "";
            this.fld_txtMMAllocationProposalNo.BOSPrivilege = "";
            this.fld_txtMMAllocationProposalNo.BOSPropertyName = "Text";
            this.fld_txtMMAllocationProposalNo.EditValue = "";
            this.fld_txtMMAllocationProposalNo.Location = new System.Drawing.Point(98, 41);
            this.fld_txtMMAllocationProposalNo.Name = "fld_txtMMAllocationProposalNo";
            this.fld_txtMMAllocationProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMAllocationProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMAllocationProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMAllocationProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMAllocationProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMAllocationProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMAllocationProposalNo.Screen = null;
            this.fld_txtMMAllocationProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMAllocationProposalNo.TabIndex = 357;
            this.fld_txtMMAllocationProposalNo.Tag = "SC";
            // 
            // fld_dgcMMAllocationPlanSearchGridControls
            // 
            this.fld_dgcMMAllocationPlanSearchGridControls.AllowDrop = true;
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSComment = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSDataMember = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSDataSource = "MMAllocationPlans";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSDescription = null;
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSError = null;
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSFieldGroup = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSFieldRelation = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSGridType = null;
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSPrivilege = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.BOSPropertyName = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.CommodityType = "";
            this.fld_dgcMMAllocationPlanSearchGridControls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMAllocationPlanSearchGridControls.Location = new System.Drawing.Point(12, 162);
            this.fld_dgcMMAllocationPlanSearchGridControls.Name = "fld_dgcMMAllocationPlanSearchGridControls";
            this.fld_dgcMMAllocationPlanSearchGridControls.PrintReport = false;
            this.fld_dgcMMAllocationPlanSearchGridControls.Screen = null;
            this.fld_dgcMMAllocationPlanSearchGridControls.Size = new System.Drawing.Size(872, 401);
            this.fld_dgcMMAllocationPlanSearchGridControls.TabIndex = 374;
            this.fld_dgcMMAllocationPlanSearchGridControls.Tag = "SR";
            // 
            // SMAPL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.Controls.Add(this.fld_dgcMMAllocationPlanSearchGridControls);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_dgcFK_MMBatchProductID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeMMAllocationPlanStatus);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteSearchToMMAllocationProposalDate);
            this.Controls.Add(this.fld_dteSearchFromMMAllocationProposalDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMAllocationProposalNo);
            this.Name = "SMAPL100";
            this.Text = "Tìm Kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMAllocationProposalNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMAllocationProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToMMAllocationProposalDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMAllocationPlanStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dgcFK_MMBatchProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMAllocationPlanSearchGridControls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMAllocationPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMAllocationProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMAllocationProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMAllocationProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMAllocationProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMAllocationProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanSearchGridControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_dgcFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMAllocationPlanStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMAllocationProposalDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromMMAllocationProposalDate;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMAllocationProposalNo;
        private IContainer components;
        private AllocationProposal.MMAllocationPlanItemSearchResultGridControl fld_dgcMMAllocationPlanSearchGridControls;
    }
}
