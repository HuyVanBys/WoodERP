using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RecruitmentNeed.UI
{
	/// <summary>
	/// Summary description for DMRN100
	/// </summary>
	partial class DMRN100
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
            this.fld_txtHRRecruitmentNeedNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRKPIFormEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteHRRecruitmentNeedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRRecruitmentNeedItems = new BOSERP.Modules.RecruitmentNeed.HRRecruitmentNeedItemsGridControl();
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRRecruitmentNeedDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRecruitmentNeedName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHRRecruitmentNeedStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentNeedNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIFormEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentNeedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentNeedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentNeedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRecruitmentNeedDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentNeedName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRecruitmentNeedStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRRecruitmentNeedNo
            // 
            this.fld_txtHRRecruitmentNeedNo.BOSComment = null;
            this.fld_txtHRRecruitmentNeedNo.BOSDataMember = "HRRecruitmentNeedNo";
            this.fld_txtHRRecruitmentNeedNo.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_txtHRRecruitmentNeedNo.BOSDescription = null;
            this.fld_txtHRRecruitmentNeedNo.BOSError = null;
            this.fld_txtHRRecruitmentNeedNo.BOSFieldGroup = null;
            this.fld_txtHRRecruitmentNeedNo.BOSFieldRelation = null;
            this.fld_txtHRRecruitmentNeedNo.BOSPrivilege = null;
            this.fld_txtHRRecruitmentNeedNo.BOSPropertyName = "EditValue";
            this.fld_txtHRRecruitmentNeedNo.Location = new System.Drawing.Point(220, 11);
            this.fld_txtHRRecruitmentNeedNo.MenuManager = this.screenToolbar;
            this.fld_txtHRRecruitmentNeedNo.Name = "fld_txtHRRecruitmentNeedNo";
            this.fld_txtHRRecruitmentNeedNo.Screen = null;
            this.fld_txtHRRecruitmentNeedNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRRecruitmentNeedNo.TabIndex = 0;
            this.fld_txtHRRecruitmentNeedNo.Tag = "DC";
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
            // fld_pteHRKPIFormEmployeePicture
            // 
            this.fld_pteHRKPIFormEmployeePicture.BOSComment = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSDataMember = "HRKPIFormEmployeePicture";
            this.fld_pteHRKPIFormEmployeePicture.BOSDataSource = "HRKPIForms";
            this.fld_pteHRKPIFormEmployeePicture.BOSDescription = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSError = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRKPIFormEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRKPIFormEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteHRKPIFormEmployeePicture.FileName = null;
            this.fld_pteHRKPIFormEmployeePicture.FilePath = null;
            this.fld_pteHRKPIFormEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteHRKPIFormEmployeePicture.Name = "fld_pteHRKPIFormEmployeePicture";
            this.fld_pteHRKPIFormEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRKPIFormEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRKPIFormEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRKPIFormEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRKPIFormEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRKPIFormEmployeePicture.Screen = null;
            this.fld_pteHRKPIFormEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRKPIFormEmployeePicture.TabIndex = 76;
            this.fld_pteHRKPIFormEmployeePicture.Tag = "DC";
            // 
            // fld_dteHRRecruitmentNeedDate
            // 
            this.fld_dteHRRecruitmentNeedDate.BOSComment = null;
            this.fld_dteHRRecruitmentNeedDate.BOSDataMember = "HRRecruitmentNeedDate";
            this.fld_dteHRRecruitmentNeedDate.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_dteHRRecruitmentNeedDate.BOSDescription = null;
            this.fld_dteHRRecruitmentNeedDate.BOSError = null;
            this.fld_dteHRRecruitmentNeedDate.BOSFieldGroup = null;
            this.fld_dteHRRecruitmentNeedDate.BOSFieldRelation = null;
            this.fld_dteHRRecruitmentNeedDate.BOSPrivilege = null;
            this.fld_dteHRRecruitmentNeedDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRecruitmentNeedDate.EditValue = null;
            this.fld_dteHRRecruitmentNeedDate.Location = new System.Drawing.Point(788, 10);
            this.fld_dteHRRecruitmentNeedDate.Name = "fld_dteHRRecruitmentNeedDate";
            this.fld_dteHRRecruitmentNeedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRecruitmentNeedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRecruitmentNeedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRecruitmentNeedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRecruitmentNeedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRecruitmentNeedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRecruitmentNeedDate.Screen = null;
            this.fld_dteHRRecruitmentNeedDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRRecruitmentNeedDate.TabIndex = 2;
            this.fld_dteHRRecruitmentNeedDate.Tag = "DC";
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRRecruitmentNeedItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(2, 132);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(966, 352);
            this.fld_grcGroupControl3.TabIndex = 8;
            this.fld_grcGroupControl3.Text = "Danh sách";
            // 
            // fld_dgcHRRecruitmentNeedItems
            // 
            this.fld_dgcHRRecruitmentNeedItems.AllowDrop = true;
            this.fld_dgcHRRecruitmentNeedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRRecruitmentNeedItems.BOSComment = "";
            this.fld_dgcHRRecruitmentNeedItems.BOSDataMember = "";
            this.fld_dgcHRRecruitmentNeedItems.BOSDataSource = "HRRecruitmentNeedItems";
            this.fld_dgcHRRecruitmentNeedItems.BOSDescription = null;
            this.fld_dgcHRRecruitmentNeedItems.BOSError = null;
            this.fld_dgcHRRecruitmentNeedItems.BOSFieldGroup = "";
            this.fld_dgcHRRecruitmentNeedItems.BOSFieldRelation = "";
            this.fld_dgcHRRecruitmentNeedItems.BOSGridType = null;
            this.fld_dgcHRRecruitmentNeedItems.BOSPrivilege = "";
            this.fld_dgcHRRecruitmentNeedItems.BOSPropertyName = "";
            this.fld_dgcHRRecruitmentNeedItems.CommodityType = "";
            this.fld_dgcHRRecruitmentNeedItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRecruitmentNeedItems.Location = new System.Drawing.Point(1, 25);
            this.fld_dgcHRRecruitmentNeedItems.MainView = this.fld_dgvHRKPIFormItems;
            this.fld_dgcHRRecruitmentNeedItems.Name = "fld_dgcHRRecruitmentNeedItems";
            this.fld_dgcHRRecruitmentNeedItems.PrintReport = false;
            this.fld_dgcHRRecruitmentNeedItems.Screen = null;
            this.fld_dgcHRRecruitmentNeedItems.Size = new System.Drawing.Size(960, 327);
            this.fld_dgcHRRecruitmentNeedItems.TabIndex = 12;
            this.fld_dgcHRRecruitmentNeedItems.Tag = "DC";
            this.fld_dgcHRRecruitmentNeedItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRKPIFormItems});
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.GridControl = this.fld_dgcHRRecruitmentNeedItems;
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRKPIForms";
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
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HRRecruitmentNeeds";
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
            this.bosPanel1.Controls.Add(this.fld_medHRRecruitmentNeedDesc);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRRecruitmentNeedName);
            this.bosPanel1.Controls.Add(this.fld_lkeHRRecruitmentNeedStatus);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.fld_pteHRKPIFormEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteHRRecruitmentNeedDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRRecruitmentNeedNo);
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
            // fld_medHRRecruitmentNeedDesc
            // 
            this.fld_medHRRecruitmentNeedDesc.BOSComment = "";
            this.fld_medHRRecruitmentNeedDesc.BOSDataMember = "HRRecruitmentNeedDesc";
            this.fld_medHRRecruitmentNeedDesc.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_medHRRecruitmentNeedDesc.BOSDescription = null;
            this.fld_medHRRecruitmentNeedDesc.BOSError = null;
            this.fld_medHRRecruitmentNeedDesc.BOSFieldGroup = "";
            this.fld_medHRRecruitmentNeedDesc.BOSFieldRelation = "";
            this.fld_medHRRecruitmentNeedDesc.BOSPrivilege = "";
            this.fld_medHRRecruitmentNeedDesc.BOSPropertyName = "Text";
            this.fld_medHRRecruitmentNeedDesc.EditValue = "";
            this.fld_medHRRecruitmentNeedDesc.Location = new System.Drawing.Point(220, 63);
            this.fld_medHRRecruitmentNeedDesc.Name = "fld_medHRRecruitmentNeedDesc";
            this.fld_medHRRecruitmentNeedDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRecruitmentNeedDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRecruitmentNeedDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRecruitmentNeedDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRecruitmentNeedDesc.Screen = null;
            this.fld_medHRRecruitmentNeedDesc.Size = new System.Drawing.Size(443, 59);
            this.fld_medHRRecruitmentNeedDesc.TabIndex = 6;
            this.fld_medHRRecruitmentNeedDesc.Tag = "DC";
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
            // fld_txtHRRecruitmentNeedName
            // 
            this.fld_txtHRRecruitmentNeedName.BOSComment = null;
            this.fld_txtHRRecruitmentNeedName.BOSDataMember = "HRRecruitmentNeedName";
            this.fld_txtHRRecruitmentNeedName.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_txtHRRecruitmentNeedName.BOSDescription = null;
            this.fld_txtHRRecruitmentNeedName.BOSError = null;
            this.fld_txtHRRecruitmentNeedName.BOSFieldGroup = null;
            this.fld_txtHRRecruitmentNeedName.BOSFieldRelation = null;
            this.fld_txtHRRecruitmentNeedName.BOSPrivilege = null;
            this.fld_txtHRRecruitmentNeedName.BOSPropertyName = "EditValue";
            this.fld_txtHRRecruitmentNeedName.Location = new System.Drawing.Point(510, 11);
            this.fld_txtHRRecruitmentNeedName.MenuManager = this.screenToolbar;
            this.fld_txtHRRecruitmentNeedName.Name = "fld_txtHRRecruitmentNeedName";
            this.fld_txtHRRecruitmentNeedName.Screen = null;
            this.fld_txtHRRecruitmentNeedName.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRRecruitmentNeedName.TabIndex = 1;
            this.fld_txtHRRecruitmentNeedName.Tag = "DC";
            // 
            // fld_lkeHRRecruitmentNeedStatus
            // 
            this.fld_lkeHRRecruitmentNeedStatus.BOSAllowAddNew = false;
            this.fld_lkeHRRecruitmentNeedStatus.BOSAllowDummy = true;
            this.fld_lkeHRRecruitmentNeedStatus.BOSComment = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSDataMember = "HRRecruitmentNeedStatus";
            this.fld_lkeHRRecruitmentNeedStatus.BOSDataSource = "HRRecruitmentNeeds";
            this.fld_lkeHRRecruitmentNeedStatus.BOSDescription = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSError = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSFieldGroup = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSFieldParent = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSFieldRelation = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSPrivilege = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRRecruitmentNeedStatus.BOSSelectType = null;
            this.fld_lkeHRRecruitmentNeedStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRRecruitmentNeedStatus.CurrentDisplayText = null;
            this.fld_lkeHRRecruitmentNeedStatus.Location = new System.Drawing.Point(788, 62);
            this.fld_lkeHRRecruitmentNeedStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRRecruitmentNeedStatus.Name = "fld_lkeHRRecruitmentNeedStatus";
            this.fld_lkeHRRecruitmentNeedStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeHRRecruitmentNeedStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRRecruitmentNeedStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRRecruitmentNeedStatus.Properties.ColumnName = null;
            this.fld_lkeHRRecruitmentNeedStatus.Properties.NullText = "";
            this.fld_lkeHRRecruitmentNeedStatus.Properties.ReadOnly = true;
            this.fld_lkeHRRecruitmentNeedStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRRecruitmentNeedStatus.Screen = null;
            this.fld_lkeHRRecruitmentNeedStatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeHRRecruitmentNeedStatus.TabIndex = 7;
            this.fld_lkeHRRecruitmentNeedStatus.Tag = "DC";
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
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HRRecruitmentNeeds";
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
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRRecruitmentNeeds";
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
            // DMRN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(971, 487);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRN100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentNeedNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIFormEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentNeedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRecruitmentNeedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentNeedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRecruitmentNeedDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentNeedName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRecruitmentNeedStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRRecruitmentNeedNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteHRKPIFormEmployeePicture;
        private BOSComponent.BOSDateEdit fld_dteHRRecruitmentNeedDate;
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
        private BOSComponent.BOSLookupEdit fld_lkeHRRecruitmentNeedStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtHRRecruitmentNeedName;
        private BOSComponent.BOSMemoEdit fld_medHRRecruitmentNeedDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private HRRecruitmentNeedItemsGridControl fld_dgcHRRecruitmentNeedItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
	}
}
