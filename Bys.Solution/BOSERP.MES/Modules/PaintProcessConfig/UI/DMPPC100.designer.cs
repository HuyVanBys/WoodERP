using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaintProcessConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMPPC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPPC100));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMOperationDetailPlanName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medMMCanceledPurchasePlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMProcesssNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMPaintProcessConfigItems = new BOSERP.Modules.PaintProcessConfig.MMPaintProcessConfigItemsGridControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMCanceledPurchasePlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProcesssNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessConfigItems)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(972, 590);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(972, 590);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMOperationDetailPlanName);
            this.bosGroupControl1.Controls.Add(this.fld_medMMCanceledPurchasePlanDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMProcesssNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(966, 140);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Tag = "DC";
            this.bosGroupControl1.Text = "Thông tin chung";
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
            this.bosLabel11.Location = new System.Drawing.Point(287, 36);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(65, 13);
            this.bosLabel11.TabIndex = 2;
            this.bosLabel11.Text = "Tên chứng từ";
            // 
            // fld_txtMMOperationDetailPlanName
            // 
            this.fld_txtMMOperationDetailPlanName.BOSComment = null;
            this.fld_txtMMOperationDetailPlanName.BOSDataMember = "MMPaintProcessConfigName";
            this.fld_txtMMOperationDetailPlanName.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_txtMMOperationDetailPlanName.BOSDescription = null;
            this.fld_txtMMOperationDetailPlanName.BOSError = null;
            this.fld_txtMMOperationDetailPlanName.BOSFieldGroup = null;
            this.fld_txtMMOperationDetailPlanName.BOSFieldRelation = null;
            this.fld_txtMMOperationDetailPlanName.BOSPrivilege = null;
            this.fld_txtMMOperationDetailPlanName.BOSPropertyName = "EditValue";
            this.fld_txtMMOperationDetailPlanName.Location = new System.Drawing.Point(371, 33);
            this.fld_txtMMOperationDetailPlanName.Name = "fld_txtMMOperationDetailPlanName";
            this.fld_txtMMOperationDetailPlanName.Screen = null;
            this.fld_txtMMOperationDetailPlanName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMOperationDetailPlanName.TabIndex = 3;
            this.fld_txtMMOperationDetailPlanName.Tag = "DC";
            // 
            // fld_medMMCanceledPurchasePlanDesc
            // 
            this.fld_medMMCanceledPurchasePlanDesc.BOSComment = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSDataMember = "MMPaintProcessConfigDesc";
            this.fld_medMMCanceledPurchasePlanDesc.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_medMMCanceledPurchasePlanDesc.BOSDescription = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSError = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSFieldGroup = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSFieldRelation = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSPrivilege = null;
            this.fld_medMMCanceledPurchasePlanDesc.BOSPropertyName = "EditValue";
            this.fld_medMMCanceledPurchasePlanDesc.Location = new System.Drawing.Point(99, 59);
            this.fld_medMMCanceledPurchasePlanDesc.MenuManager = this.screenToolbar;
            this.fld_medMMCanceledPurchasePlanDesc.Name = "fld_medMMCanceledPurchasePlanDesc";
            this.fld_medMMCanceledPurchasePlanDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMCanceledPurchasePlanDesc, true);
            this.fld_medMMCanceledPurchasePlanDesc.Size = new System.Drawing.Size(422, 68);
            this.fld_medMMCanceledPurchasePlanDesc.TabIndex = 7;
            this.fld_medMMCanceledPurchasePlanDesc.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(21, 62);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel3.Location = new System.Drawing.Point(554, 62);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMPaintProcessConfigs";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(641, 59);
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
            this.fld_lkeFK_HREmployeeID.TabIndex = 9;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(554, 88);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 10;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMPaintProcessConfigStatus";
            this.bosLookupEdit3.BOSDataSource = "MMPaintProcessConfigs";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Enabled = false;
            this.bosLookupEdit3.Location = new System.Drawing.Point(641, 85);
            this.bosLookupEdit3.MenuManager = this.screenToolbar;
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 11;
            this.bosLookupEdit3.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(554, 36);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 4;
            this.bosLabel2.Text = "Ngày chứng từ";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "MMPaintProcessConfigDate";
            this.bosDateEdit1.BOSDataSource = "MMPaintProcessConfigs";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(641, 33);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 5;
            this.bosDateEdit1.Tag = "DC";
            // 
            // fld_txtMMProcesssNo
            // 
            this.fld_txtMMProcesssNo.BOSComment = null;
            this.fld_txtMMProcesssNo.BOSDataMember = "MMPaintProcessConfigNo";
            this.fld_txtMMProcesssNo.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_txtMMProcesssNo.BOSDescription = null;
            this.fld_txtMMProcesssNo.BOSError = null;
            this.fld_txtMMProcesssNo.BOSFieldGroup = null;
            this.fld_txtMMProcesssNo.BOSFieldRelation = null;
            this.fld_txtMMProcesssNo.BOSPrivilege = null;
            this.fld_txtMMProcesssNo.BOSPropertyName = "Text";
            this.fld_txtMMProcesssNo.Location = new System.Drawing.Point(99, 33);
            this.fld_txtMMProcesssNo.MenuManager = this.screenToolbar;
            this.fld_txtMMProcesssNo.Name = "fld_txtMMProcesssNo";
            this.fld_txtMMProcesssNo.Properties.ReadOnly = true;
            this.fld_txtMMProcesssNo.Screen = null;
            this.fld_txtMMProcesssNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProcesssNo.TabIndex = 1;
            this.fld_txtMMProcesssNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(21, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcMMPaintProcessConfigItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 149);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(966, 438);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin chi tiết";
            // 
            // fld_dgcMMPaintProcessConfigItems
            // 
            this.fld_dgcMMPaintProcessConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMPaintProcessConfigItems.BOSComment = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSDataMember = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSDataSource = "MMPaintProcessConfigItems";
            this.fld_dgcMMPaintProcessConfigItems.BOSDescription = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSError = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSFieldGroup = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSFieldRelation = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSGridType = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSPrivilege = null;
            this.fld_dgcMMPaintProcessConfigItems.BOSPropertyName = null;
            this.fld_dgcMMPaintProcessConfigItems.CommodityType = "";
            this.fld_dgcMMPaintProcessConfigItems.Location = new System.Drawing.Point(3, 29);
            this.fld_dgcMMPaintProcessConfigItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMPaintProcessConfigItems.Name = "fld_dgcMMPaintProcessConfigItems";
            this.fld_dgcMMPaintProcessConfigItems.PrintReport = false;
            this.fld_dgcMMPaintProcessConfigItems.Screen = null;
            this.fld_dgcMMPaintProcessConfigItems.Size = new System.Drawing.Size(961, 400);
            this.fld_dgcMMPaintProcessConfigItems.TabIndex = 1;
            this.fld_dgcMMPaintProcessConfigItems.Tag = "DC";
            // 
            // DMPPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(972, 590);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPPC100.IconOptions.Icon")));
            this.Name = "DMPPC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMCanceledPurchasePlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProcesssNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessConfigItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSTextBox fld_txtMMProcesssNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSMemoEdit fld_medMMCanceledPurchasePlanDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtMMOperationDetailPlanName;
        private BOSComponent.BOSPanel bosPanel1;
        private PaintProcessConfig.MMPaintProcessConfigItemsGridControl fld_dgcMMPaintProcessConfigItems;
    }
}
