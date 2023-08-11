using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RecruitmentPlan.UI
{
	/// <summary>
	/// Summary description for DMRMP100
	/// </summary>
	partial class DMRMP100
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
            this.fld_txtHRRecruitmentPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRRecruitmentPlanEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteHRRecruitmentPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRRecruitmentPlanItems = new BOSERP.Modules.RecruitmentPlan.HRRecruitmentPlanItemsGridControl();
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRRecruitmentPlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRecruitmentPlanName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHRRecruitmentPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRecruitmentPlanEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentPlanItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRecruitmentPlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRecruitmentPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRRecruitmentPlanNo
            // 
            this.fld_txtHRRecruitmentPlanNo.BOSComment = null;
            this.fld_txtHRRecruitmentPlanNo.BOSDataMember = "HRRecruitmentPlanNo";
            this.fld_txtHRRecruitmentPlanNo.BOSDataSource = "HRRecruitmentPlans";
            this.fld_txtHRRecruitmentPlanNo.BOSDescription = null;
            this.fld_txtHRRecruitmentPlanNo.BOSError = null;
            this.fld_txtHRRecruitmentPlanNo.BOSFieldGroup = null;
            this.fld_txtHRRecruitmentPlanNo.BOSFieldRelation = null;
            this.fld_txtHRRecruitmentPlanNo.BOSPrivilege = null;
            this.fld_txtHRRecruitmentPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtHRRecruitmentPlanNo.Location = new System.Drawing.Point(220, 11);
            this.fld_txtHRRecruitmentPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtHRRecruitmentPlanNo.Name = "fld_txtHRRecruitmentPlanNo";
            this.fld_txtHRRecruitmentPlanNo.Screen = null;
            this.fld_txtHRRecruitmentPlanNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRRecruitmentPlanNo.TabIndex = 0;
            this.fld_txtHRRecruitmentPlanNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(133, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_pteHRRecruitmentPlanEmployeePicture
            // 
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSComment = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSDataMember = "HRRecruitmentPlanEmployeePicture";
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSDataSource = "HRRecruitmentPlans";
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSDescription = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSError = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRRecruitmentPlanEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteHRRecruitmentPlanEmployeePicture.FileName = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.FilePath = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteHRRecruitmentPlanEmployeePicture.Name = "fld_pteHRRecruitmentPlanEmployeePicture";
            this.fld_pteHRRecruitmentPlanEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRRecruitmentPlanEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRRecruitmentPlanEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Screen = null;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRRecruitmentPlanEmployeePicture.TabIndex = 76;
            this.fld_pteHRRecruitmentPlanEmployeePicture.Tag = "DC";
            // 
            // fld_dteHRRecruitmentPlanDate
            // 
            this.fld_dteHRRecruitmentPlanDate.BOSComment = null;
            this.fld_dteHRRecruitmentPlanDate.BOSDataMember = "HRRecruitmentPlanDate";
            this.fld_dteHRRecruitmentPlanDate.BOSDataSource = "HRRecruitmentPlans";
            this.fld_dteHRRecruitmentPlanDate.BOSDescription = null;
            this.fld_dteHRRecruitmentPlanDate.BOSError = null;
            this.fld_dteHRRecruitmentPlanDate.BOSFieldGroup = null;
            this.fld_dteHRRecruitmentPlanDate.BOSFieldRelation = null;
            this.fld_dteHRRecruitmentPlanDate.BOSPrivilege = null;
            this.fld_dteHRRecruitmentPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRecruitmentPlanDate.EditValue = null;
            this.fld_dteHRRecruitmentPlanDate.Location = new System.Drawing.Point(788, 10);
            this.fld_dteHRRecruitmentPlanDate.Name = "fld_dteHRRecruitmentPlanDate";
            this.fld_dteHRRecruitmentPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRecruitmentPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRecruitmentPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRecruitmentPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRecruitmentPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRecruitmentPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRecruitmentPlanDate.Screen = null;
            this.fld_dteHRRecruitmentPlanDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRRecruitmentPlanDate.TabIndex = 2;
            this.fld_dteHRRecruitmentPlanDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(692, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = null;
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = null;
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = null;
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRRecruitmentPlanItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(2, 132);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(966, 352);
            this.fld_grcGroupControl3.TabIndex = 8;
            this.fld_grcGroupControl3.Text = "Danh sách";
            // 
            // fld_dgcHRRecruitmentPlanItems
            // 
            this.fld_dgcHRRecruitmentPlanItems.AllowDrop = true;
            this.fld_dgcHRRecruitmentPlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRRecruitmentPlanItems.BOSComment = "";
            this.fld_dgcHRRecruitmentPlanItems.BOSDataMember = "";
            this.fld_dgcHRRecruitmentPlanItems.BOSDataSource = "HRRecruitmentPlanItems";
            this.fld_dgcHRRecruitmentPlanItems.BOSDescription = null;
            this.fld_dgcHRRecruitmentPlanItems.BOSError = null;
            this.fld_dgcHRRecruitmentPlanItems.BOSFieldGroup = "";
            this.fld_dgcHRRecruitmentPlanItems.BOSFieldRelation = "";
            this.fld_dgcHRRecruitmentPlanItems.BOSGridType = null;
            this.fld_dgcHRRecruitmentPlanItems.BOSPrivilege = "";
            this.fld_dgcHRRecruitmentPlanItems.BOSPropertyName = "";
            this.fld_dgcHRRecruitmentPlanItems.CommodityType = "";
            this.fld_dgcHRRecruitmentPlanItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRecruitmentPlanItems.Location = new System.Drawing.Point(1, 25);
            this.fld_dgcHRRecruitmentPlanItems.MainView = this.fld_dgvHRKPIFormItems;
            this.fld_dgcHRRecruitmentPlanItems.Name = "fld_dgcHRRecruitmentPlanItems";
            this.fld_dgcHRRecruitmentPlanItems.PrintReport = false;
            this.fld_dgcHRRecruitmentPlanItems.Screen = null;
            this.fld_dgcHRRecruitmentPlanItems.Size = new System.Drawing.Size(960, 327);
            this.fld_dgcHRRecruitmentPlanItems.TabIndex = 12;
            this.fld_dgcHRRecruitmentPlanItems.Tag = "DC";
            this.fld_dgcHRRecruitmentPlanItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRKPIFormItems});
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.GridControl = this.fld_dgcHRRecruitmentPlanItems;
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRRecruitmentPlans";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 106);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 8;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HRRecruitmentPlans";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(788, 36);
            this.fld_lkeFK_HRDepartmentRoomID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 5;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(692, 39);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Bộ phận";
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
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_medHRRecruitmentPlanDesc);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRRecruitmentPlanName);
            this.bosPanel1.Controls.Add(this.fld_lkeHRRecruitmentPlanStatus);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.fld_pteHRRecruitmentPlanEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteHRRecruitmentPlanDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRRecruitmentPlanNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(971, 487);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(133, 69);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(27, 13);
            this.bosLabel1.TabIndex = 115;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mô tả";
            // 
            // fld_medHRRecruitmentPlanDesc
            // 
            this.fld_medHRRecruitmentPlanDesc.BOSComment = "";
            this.fld_medHRRecruitmentPlanDesc.BOSDataMember = "HRRecruitmentPlanDesc";
            this.fld_medHRRecruitmentPlanDesc.BOSDataSource = "HRRecruitmentPlans";
            this.fld_medHRRecruitmentPlanDesc.BOSDescription = null;
            this.fld_medHRRecruitmentPlanDesc.BOSError = null;
            this.fld_medHRRecruitmentPlanDesc.BOSFieldGroup = "";
            this.fld_medHRRecruitmentPlanDesc.BOSFieldRelation = "";
            this.fld_medHRRecruitmentPlanDesc.BOSPrivilege = "";
            this.fld_medHRRecruitmentPlanDesc.BOSPropertyName = "Text";
            this.fld_medHRRecruitmentPlanDesc.EditValue = "";
            this.fld_medHRRecruitmentPlanDesc.Location = new System.Drawing.Point(220, 63);
            this.fld_medHRRecruitmentPlanDesc.Name = "fld_medHRRecruitmentPlanDesc";
            this.fld_medHRRecruitmentPlanDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRecruitmentPlanDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRecruitmentPlanDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRecruitmentPlanDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRecruitmentPlanDesc.Screen = null;
            this.fld_medHRRecruitmentPlanDesc.Size = new System.Drawing.Size(443, 59);
            this.fld_medHRRecruitmentPlanDesc.TabIndex = 6;
            this.fld_medHRRecruitmentPlanDesc.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(414, 14);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(65, 13);
            this.bosLabel8.TabIndex = 113;
            this.bosLabel8.Text = "Tên chứng từ";
            // 
            // fld_txtHRRecruitmentPlanName
            // 
            this.fld_txtHRRecruitmentPlanName.BOSComment = null;
            this.fld_txtHRRecruitmentPlanName.BOSDataMember = "HRRecruitmentPlanName";
            this.fld_txtHRRecruitmentPlanName.BOSDataSource = "HRRecruitmentPlans";
            this.fld_txtHRRecruitmentPlanName.BOSDescription = null;
            this.fld_txtHRRecruitmentPlanName.BOSError = null;
            this.fld_txtHRRecruitmentPlanName.BOSFieldGroup = null;
            this.fld_txtHRRecruitmentPlanName.BOSFieldRelation = null;
            this.fld_txtHRRecruitmentPlanName.BOSPrivilege = null;
            this.fld_txtHRRecruitmentPlanName.BOSPropertyName = "EditValue";
            this.fld_txtHRRecruitmentPlanName.Location = new System.Drawing.Point(510, 11);
            this.fld_txtHRRecruitmentPlanName.MenuManager = this.screenToolbar;
            this.fld_txtHRRecruitmentPlanName.Name = "fld_txtHRRecruitmentPlanName";
            this.fld_txtHRRecruitmentPlanName.Screen = null;
            this.fld_txtHRRecruitmentPlanName.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRRecruitmentPlanName.TabIndex = 1;
            this.fld_txtHRRecruitmentPlanName.Tag = "DC";
            // 
            // fld_lkeHRRecruitmentPlanStatus
            // 
            this.fld_lkeHRRecruitmentPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeHRRecruitmentPlanStatus.BOSAllowDummy = true;
            this.fld_lkeHRRecruitmentPlanStatus.BOSComment = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSDataMember = "HRRecruitmentPlanStatus";
            this.fld_lkeHRRecruitmentPlanStatus.BOSDataSource = "HRRecruitmentPlans";
            this.fld_lkeHRRecruitmentPlanStatus.BOSDescription = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSError = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSFieldGroup = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSFieldParent = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSFieldRelation = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSPrivilege = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRRecruitmentPlanStatus.BOSSelectType = null;
            this.fld_lkeHRRecruitmentPlanStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRRecruitmentPlanStatus.CurrentDisplayText = null;
            this.fld_lkeHRRecruitmentPlanStatus.Location = new System.Drawing.Point(788, 62);
            this.fld_lkeHRRecruitmentPlanStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRRecruitmentPlanStatus.Name = "fld_lkeHRRecruitmentPlanStatus";
            this.fld_lkeHRRecruitmentPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRRecruitmentPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRRecruitmentPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRRecruitmentPlanStatus.Properties.ColumnName = null;
            this.fld_lkeHRRecruitmentPlanStatus.Properties.NullText = "";
            this.fld_lkeHRRecruitmentPlanStatus.Properties.ReadOnly = true;
            this.fld_lkeHRRecruitmentPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRRecruitmentPlanStatus.Screen = null;
            this.fld_lkeHRRecruitmentPlanStatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeHRRecruitmentPlanStatus.TabIndex = 7;
            this.fld_lkeHRRecruitmentPlanStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(692, 65);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 107;
            this.bosLabel6.Text = "Tình trạng";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HRRecruitmentPlans";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(510, 37);
            this.fld_lkeFK_HRDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_HRDepartmentID_CloseUp);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(133, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 106;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRRecruitmentPlans";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(220, 37);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            this.fld_lkeFK_BRBranchID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_BRBranchID_CloseUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(414, 40);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(51, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Text = "Phòng ban";
            // 
            // DMRMP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(971, 487);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRMP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRecruitmentPlanEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentPlanItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRecruitmentPlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRecruitmentPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRRecruitmentPlanNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteHRRecruitmentPlanEmployeePicture;
        private BOSComponent.BOSDateEdit fld_dteHRRecruitmentPlanDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeHRRecruitmentPlanStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtHRRecruitmentPlanName;
        private BOSComponent.BOSMemoEdit fld_medHRRecruitmentPlanDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private HRRecruitmentPlanItemsGridControl fld_dgcHRRecruitmentPlanItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
	}
}
