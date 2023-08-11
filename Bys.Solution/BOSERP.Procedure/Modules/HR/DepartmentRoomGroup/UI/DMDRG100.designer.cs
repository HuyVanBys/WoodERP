using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DepartmentRoomGroup.UI
{
	/// <summary>
	/// Summary description for DMDRG100
	/// </summary>
	partial class DMDRG100
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
            this.fld_medHRDepartmentRoomGroupDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtHRDepartmentRoomGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDepartmentRoomGroupName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcHRDepartmentRoomGroupItems = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRDepartmentRoomGroupItems = new BOSERP.Modules.DepartmentRoomGroup.HRDepartmentRoomGroupItemsGridControl();
            this.RLKEWorkingShift = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID2 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentRoomGroupDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcHRDepartmentRoomGroupItems)).BeginInit();
            this.fld_grcHRDepartmentRoomGroupItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_medHRDepartmentRoomGroupDesc
            // 
            this.fld_medHRDepartmentRoomGroupDesc.BOSComment = "";
            this.fld_medHRDepartmentRoomGroupDesc.BOSDataMember = "HRDepartmentRoomGroupDesc";
            this.fld_medHRDepartmentRoomGroupDesc.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_medHRDepartmentRoomGroupDesc.BOSDescription = null;
            this.fld_medHRDepartmentRoomGroupDesc.BOSError = null;
            this.fld_medHRDepartmentRoomGroupDesc.BOSFieldGroup = "";
            this.fld_medHRDepartmentRoomGroupDesc.BOSFieldRelation = "";
            this.fld_medHRDepartmentRoomGroupDesc.BOSPrivilege = "";
            this.fld_medHRDepartmentRoomGroupDesc.BOSPropertyName = "Text";
            this.fld_medHRDepartmentRoomGroupDesc.EditValue = "";
            this.fld_medHRDepartmentRoomGroupDesc.Location = new System.Drawing.Point(92, 87);
            this.fld_medHRDepartmentRoomGroupDesc.Name = "fld_medHRDepartmentRoomGroupDesc";
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRDepartmentRoomGroupDesc.Screen = null;
            this.fld_medHRDepartmentRoomGroupDesc.Size = new System.Drawing.Size(438, 57);
            this.fld_medHRDepartmentRoomGroupDesc.TabIndex = 5;
            this.fld_medHRDepartmentRoomGroupDesc.Tag = "DC";
            // 
            // fld_txtHRDepartmentRoomGroupNo
            // 
            this.fld_txtHRDepartmentRoomGroupNo.BOSComment = "";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataMember = "HRDepartmentRoomGroupNo";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldGroup = "";
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldRelation = "";
            this.fld_txtHRDepartmentRoomGroupNo.BOSPrivilege = "";
            this.fld_txtHRDepartmentRoomGroupNo.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupNo.EditValue = "";
            this.fld_txtHRDepartmentRoomGroupNo.Location = new System.Drawing.Point(92, 9);
            this.fld_txtHRDepartmentRoomGroupNo.Name = "fld_txtHRDepartmentRoomGroupNo";
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDepartmentRoomGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDepartmentRoomGroupNo.Screen = null;
            this.fld_txtHRDepartmentRoomGroupNo.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRDepartmentRoomGroupNo.TabIndex = 0;
            this.fld_txtHRDepartmentRoomGroupNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Tag = "DC";
            this.bosLabel7.Text = "Mã chứng từ";
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
            this.bosLabel11.Location = new System.Drawing.Point(12, 90);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 94;
            this.bosLabel11.Tag = "DC";
            this.bosLabel11.Text = "Diễn giải";
            // 
            // fld_txtHRDepartmentRoomGroupName
            // 
            this.fld_txtHRDepartmentRoomGroupName.BOSComment = "";
            this.fld_txtHRDepartmentRoomGroupName.BOSDataMember = "HRDepartmentRoomGroupName";
            this.fld_txtHRDepartmentRoomGroupName.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_txtHRDepartmentRoomGroupName.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldGroup = "";
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldRelation = "";
            this.fld_txtHRDepartmentRoomGroupName.BOSPrivilege = "";
            this.fld_txtHRDepartmentRoomGroupName.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupName.EditValue = "";
            this.fld_txtHRDepartmentRoomGroupName.Location = new System.Drawing.Point(365, 9);
            this.fld_txtHRDepartmentRoomGroupName.Name = "fld_txtHRDepartmentRoomGroupName";
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentRoomGroupName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDepartmentRoomGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDepartmentRoomGroupName.Screen = null;
            this.fld_txtHRDepartmentRoomGroupName.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRDepartmentRoomGroupName.TabIndex = 1;
            this.fld_txtHRDepartmentRoomGroupName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(285, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 100;
            this.bosLabel1.Tag = "DC";
            this.bosLabel1.Text = "Tên chứng từ";
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
            this.bosLabel9.Location = new System.Drawing.Point(285, 38);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(51, 13);
            this.bosLabel9.TabIndex = 92;
            this.bosLabel9.Tag = "DC";
            this.bosLabel9.Text = "Phòng ban";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 92;
            this.bosLabel2.Tag = "DC";
            this.bosLabel2.Text = "Bộ phận";
            // 
            // fld_grcHRDepartmentRoomGroupItems
            // 
            this.fld_grcHRDepartmentRoomGroupItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcHRDepartmentRoomGroupItems.BOSComment = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSDataMember = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSDataSource = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSDescription = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSError = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSFieldGroup = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSFieldRelation = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSPrivilege = null;
            this.fld_grcHRDepartmentRoomGroupItems.BOSPropertyName = null;
            this.fld_grcHRDepartmentRoomGroupItems.Controls.Add(this.fld_dgcHRDepartmentRoomGroupItems);
            this.fld_grcHRDepartmentRoomGroupItems.Location = new System.Drawing.Point(3, 150);
            this.fld_grcHRDepartmentRoomGroupItems.Name = "fld_grcHRDepartmentRoomGroupItems";
            this.fld_grcHRDepartmentRoomGroupItems.Screen = null;
            this.fld_grcHRDepartmentRoomGroupItems.Size = new System.Drawing.Size(748, 395);
            this.fld_grcHRDepartmentRoomGroupItems.TabIndex = 6;
            this.fld_grcHRDepartmentRoomGroupItems.Text = "Danh sách tổ";
            // 
            // fld_dgcHRDepartmentRoomGroupItems
            // 
            this.fld_dgcHRDepartmentRoomGroupItems.BOSComment = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSDataMember = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSDataSource = "HRDepartmentRoomGroupItems";
            this.fld_dgcHRDepartmentRoomGroupItems.BOSDescription = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSError = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSFieldGroup = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSFieldRelation = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSGridType = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSPrivilege = null;
            this.fld_dgcHRDepartmentRoomGroupItems.BOSPropertyName = null;
            this.fld_dgcHRDepartmentRoomGroupItems.CommodityType = "";
            this.fld_dgcHRDepartmentRoomGroupItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRDepartmentRoomGroupItems.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcHRDepartmentRoomGroupItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRDepartmentRoomGroupItems.Name = "fld_dgcHRDepartmentRoomGroupItems";
            this.fld_dgcHRDepartmentRoomGroupItems.PrintReport = false;
            this.fld_dgcHRDepartmentRoomGroupItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RLKEWorkingShift});
            this.fld_dgcHRDepartmentRoomGroupItems.Screen = null;
            this.fld_dgcHRDepartmentRoomGroupItems.Size = new System.Drawing.Size(744, 373);
            this.fld_dgcHRDepartmentRoomGroupItems.TabIndex = 0;
            // 
            // RLKEWorkingShift
            // 
            this.RLKEWorkingShift.AutoHeight = false;
            this.RLKEWorkingShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RLKEWorkingShift.DisplayMember = "HRWorkingShiftName";
            this.RLKEWorkingShift.Name = "RLKEWorkingShift";
            this.RLKEWorkingShift.ValueMember = "HRWorkingShiftID";
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
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID2);
            this.bosPanel1.Controls.Add(this.fld_grcHRDepartmentRoomGroupItems);
            this.bosPanel1.Controls.Add(this.fld_txtHRDepartmentRoomGroupName);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_medHRDepartmentRoomGroupDesc);
            this.bosPanel1.Controls.Add(this.fld_txtHRDepartmentRoomGroupNo);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(758, 547);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = null;
            this.fld_lblLabel5.BOSDataMember = null;
            this.fld_lblLabel5.BOSDataSource = null;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = null;
            this.fld_lblLabel5.BOSFieldRelation = null;
            this.fld_lblLabel5.BOSPrivilege = null;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(12, 38);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 110;
            this.fld_lblLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID2
            // 
            this.fld_lkeFK_BRBranchID2.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID2.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID2.BOSComment = null;
            this.fld_lkeFK_BRBranchID2.BOSDataMember = "FK_BRBranchID2";
            this.fld_lkeFK_BRBranchID2.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_lkeFK_BRBranchID2.BOSDescription = null;
            this.fld_lkeFK_BRBranchID2.BOSError = null;
            this.fld_lkeFK_BRBranchID2.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID2.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID2.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID2.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID2.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID2.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID2.Location = new System.Drawing.Point(92, 35);
            this.fld_lkeFK_BRBranchID2.Name = "fld_lkeFK_BRBranchID2";
            this.fld_lkeFK_BRBranchID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID2.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID2.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID2.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID2.Screen = null;
            this.fld_lkeFK_BRBranchID2.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_BRBranchID2.TabIndex = 2;
            this.fld_lkeFK_BRBranchID2.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentRoomID2
            // 
            this.fld_lkeFK_HRDepartmentRoomID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID2.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID2.Location = new System.Drawing.Point(92, 61);
            this.fld_lkeFK_HRDepartmentRoomID2.Name = "fld_lkeFK_HRDepartmentRoomID2";
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID2, true);
            this.fld_lkeFK_HRDepartmentRoomID2.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HRDepartmentRoomID2.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomID2.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID2_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentID2
            // 
            this.fld_lkeFK_HRDepartmentID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID2.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID2.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID2.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID2.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_lkeFK_HRDepartmentID2.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID2.BOSError = null;
            this.fld_lkeFK_HRDepartmentID2.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID2.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentID2.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID2.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID2.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID2.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID2.Location = new System.Drawing.Point(365, 35);
            this.fld_lkeFK_HRDepartmentID2.Name = "fld_lkeFK_HRDepartmentID2";
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID2.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentID2.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID2.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID2.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID2, true);
            this.fld_lkeFK_HRDepartmentID2.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HRDepartmentID2.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentID2.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentID2_QueryPopUp);
            this.fld_lkeFK_HRDepartmentID2.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentID2_Validated);
            // 
            // DMDRG100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(758, 547);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDRG100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMDRG100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentRoomGroupDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcHRDepartmentRoomGroupItems)).EndInit();
            this.fld_grcHRDepartmentRoomGroupItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSMemoEdit fld_medHRDepartmentRoomGroupDesc;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel11;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSGroupControl fld_grcHRDepartmentRoomGroupItems;
        private BOSERP.Modules.DepartmentRoomGroup.HRDepartmentRoomGroupItemsGridControl fld_dgcHRDepartmentRoomGroupItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RLKEWorkingShift;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID2;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID2;
	}
}
