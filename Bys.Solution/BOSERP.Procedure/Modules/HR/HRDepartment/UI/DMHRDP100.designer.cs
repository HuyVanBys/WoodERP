using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRDepartment.UI
{
	/// <summary>
	/// Summary description for DMHRDP100
	/// </summary>
	partial class DMHRDP100
	{
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSTextBox fld_txtHRDepartmentNo1;
		private BOSComponent.BOSTextBox fld_txtHRDepartmentName1;
        private BOSComponent.BOSMemoEdit fld_medHRDepartmentDesc;
        private HRDepartmentRoomsGridControl fld_dgcHRDepartmentRooms;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRDepartmentRooms;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMHRDP100));
            this.fld_lblLabel2 = new BOSComponent.BOSLabel();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel();
            this.fld_lblLabel5 = new BOSComponent.BOSLabel();
            this.fld_txtHRDepartmentNo1 = new BOSComponent.BOSTextBox();
            this.fld_txtHRDepartmentName1 = new BOSComponent.BOSTextBox();
            this.fld_medHRDepartmentDesc = new BOSComponent.BOSMemoEdit();
            this.fld_dgcHRDepartmentRooms = new BOSERP.Modules.HRDepartment.HRDepartmentRoomsGridControl();
            this.fld_dgvHRDepartmentRooms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl();
            this.fld_txtHRDepartmentTotalEmployee = new BOSComponent.BOSTextBox();
            this.bosLabel1 = new BOSComponent.BOSLabel();
            this.fld_lblLabel10 = new BOSComponent.BOSLabel();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl();
            this.bosPanel1 = new BOSComponent.BOSPanel();
            this.fld_chkIsBatch = new BOSComponent.BOSCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartmentRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentTotalEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBatch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = null;
            this.fld_lblLabel2.BOSDataMember = null;
            this.fld_lblLabel2.BOSDataSource = null;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = null;
            this.fld_lblLabel2.BOSFieldRelation = null;
            this.fld_lblLabel2.BOSPrivilege = null;
            this.fld_lblLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel2, "fld_lblLabel2");
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel2, ((bool)(resources.GetObject("fld_lblLabel2.ShowHelp"))));
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = null;
            this.fld_lblLabel3.BOSDataMember = null;
            this.fld_lblLabel3.BOSDataSource = null;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = null;
            this.fld_lblLabel3.BOSFieldRelation = null;
            this.fld_lblLabel3.BOSPrivilege = null;
            this.fld_lblLabel3.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel3, "fld_lblLabel3");
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel3, ((bool)(resources.GetObject("fld_lblLabel3.ShowHelp"))));
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
            resources.ApplyResources(this.fld_lblLabel5, "fld_lblLabel5");
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel5, ((bool)(resources.GetObject("fld_lblLabel5.ShowHelp"))));
            // 
            // fld_txtHRDepartmentNo1
            // 
            this.fld_txtHRDepartmentNo1.BOSComment = null;
            this.fld_txtHRDepartmentNo1.BOSDataMember = "HRDepartmentNo";
            this.fld_txtHRDepartmentNo1.BOSDataSource = "HRDepartments";
            this.fld_txtHRDepartmentNo1.BOSDescription = null;
            this.fld_txtHRDepartmentNo1.BOSError = null;
            this.fld_txtHRDepartmentNo1.BOSFieldGroup = null;
            this.fld_txtHRDepartmentNo1.BOSFieldRelation = null;
            this.fld_txtHRDepartmentNo1.BOSPrivilege = null;
            this.fld_txtHRDepartmentNo1.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtHRDepartmentNo1, "fld_txtHRDepartmentNo1");
            this.fld_txtHRDepartmentNo1.Name = "fld_txtHRDepartmentNo1";
            this.fld_txtHRDepartmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentNo1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRDepartmentNo1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRDepartmentNo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRDepartmentNo1, ((bool)(resources.GetObject("fld_txtHRDepartmentNo1.ShowHelp"))));
            this.fld_txtHRDepartmentNo1.Tag = "DC";
            // 
            // fld_txtHRDepartmentName1
            // 
            this.fld_txtHRDepartmentName1.BOSComment = null;
            this.fld_txtHRDepartmentName1.BOSDataMember = "HRDepartmentName";
            this.fld_txtHRDepartmentName1.BOSDataSource = "HRDepartments";
            this.fld_txtHRDepartmentName1.BOSDescription = null;
            this.fld_txtHRDepartmentName1.BOSError = null;
            this.fld_txtHRDepartmentName1.BOSFieldGroup = null;
            this.fld_txtHRDepartmentName1.BOSFieldRelation = null;
            this.fld_txtHRDepartmentName1.BOSPrivilege = null;
            this.fld_txtHRDepartmentName1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRDepartmentName1, "fld_txtHRDepartmentName1");
            this.fld_txtHRDepartmentName1.Name = "fld_txtHRDepartmentName1";
            this.fld_txtHRDepartmentName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentName1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRDepartmentName1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRDepartmentName1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRDepartmentName1, ((bool)(resources.GetObject("fld_txtHRDepartmentName1.ShowHelp"))));
            this.fld_txtHRDepartmentName1.Tag = "DC";
            // 
            // fld_medHRDepartmentDesc
            // 
            this.fld_medHRDepartmentDesc.BOSComment = null;
            this.fld_medHRDepartmentDesc.BOSDataMember = "HRDepartmentDesc";
            this.fld_medHRDepartmentDesc.BOSDataSource = "HRDepartments";
            this.fld_medHRDepartmentDesc.BOSDescription = null;
            this.fld_medHRDepartmentDesc.BOSError = null;
            this.fld_medHRDepartmentDesc.BOSFieldGroup = null;
            this.fld_medHRDepartmentDesc.BOSFieldRelation = null;
            this.fld_medHRDepartmentDesc.BOSPrivilege = null;
            this.fld_medHRDepartmentDesc.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_medHRDepartmentDesc, "fld_medHRDepartmentDesc");
            this.fld_medHRDepartmentDesc.Name = "fld_medHRDepartmentDesc";
            this.fld_medHRDepartmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRDepartmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRDepartmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRDepartmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRDepartmentDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRDepartmentDesc, ((bool)(resources.GetObject("fld_medHRDepartmentDesc.ShowHelp"))));
            this.fld_medHRDepartmentDesc.Tag = "DC";
            // 
            // fld_dgcHRDepartmentRooms
            // 
            this.fld_dgcHRDepartmentRooms.AllowDrop = true;
            this.fld_dgcHRDepartmentRooms.BOSComment = null;
            this.fld_dgcHRDepartmentRooms.BOSDataMember = null;
            this.fld_dgcHRDepartmentRooms.BOSDataSource = "HRDepartmentRooms";
            this.fld_dgcHRDepartmentRooms.BOSDescription = null;
            this.fld_dgcHRDepartmentRooms.BOSError = null;
            this.fld_dgcHRDepartmentRooms.BOSFieldGroup = null;
            this.fld_dgcHRDepartmentRooms.BOSFieldRelation = null;
            this.fld_dgcHRDepartmentRooms.BOSGridType = null;
            this.fld_dgcHRDepartmentRooms.BOSPrivilege = null;
            this.fld_dgcHRDepartmentRooms.BOSPropertyName = null;
            this.fld_dgcHRDepartmentRooms.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRDepartmentRooms, "fld_dgcHRDepartmentRooms");
            this.fld_dgcHRDepartmentRooms.MainView = this.fld_dgvHRDepartmentRooms;
            this.fld_dgcHRDepartmentRooms.Name = "fld_dgcHRDepartmentRooms";
            this.fld_dgcHRDepartmentRooms.PrintReport = false;
            this.fld_dgcHRDepartmentRooms.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRDepartmentRooms, ((bool)(resources.GetObject("fld_dgcHRDepartmentRooms.ShowHelp"))));
            this.fld_dgcHRDepartmentRooms.Tag = "DC";
            this.fld_dgcHRDepartmentRooms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRDepartmentRooms});
            // 
            // fld_dgvHRDepartmentRooms
            // 
            this.fld_dgvHRDepartmentRooms.GridControl = this.fld_dgcHRDepartmentRooms;
            this.fld_dgvHRDepartmentRooms.Name = "fld_dgvHRDepartmentRooms";
            this.fld_dgvHRDepartmentRooms.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            resources.ApplyResources(this.bosGroupControl1, "bosGroupControl1");
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_chkIsBatch);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRDepartmentTotalEmployee);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel10);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosGroupControl1.Controls.Add(this.fld_medHRDepartmentDesc);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRDepartmentName1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRDepartmentNo1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, ((bool)(resources.GetObject("bosGroupControl1.ShowHelp"))));
            // 
            // fld_txtHRDepartmentTotalEmployee
            // 
            this.fld_txtHRDepartmentTotalEmployee.BOSComment = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSDataMember = "HRDepartmentTotalEmployee";
            this.fld_txtHRDepartmentTotalEmployee.BOSDataSource = "HRDepartments";
            this.fld_txtHRDepartmentTotalEmployee.BOSDescription = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSError = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSFieldGroup = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSFieldRelation = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSPrivilege = null;
            this.fld_txtHRDepartmentTotalEmployee.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRDepartmentTotalEmployee, "fld_txtHRDepartmentTotalEmployee");
            this.fld_txtHRDepartmentTotalEmployee.Name = "fld_txtHRDepartmentTotalEmployee";
            this.fld_txtHRDepartmentTotalEmployee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentTotalEmployee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentTotalEmployee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentTotalEmployee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentTotalEmployee.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRDepartmentTotalEmployee.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRDepartmentTotalEmployee.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRDepartmentTotalEmployee, ((bool)(resources.GetObject("fld_txtHRDepartmentTotalEmployee.ShowHelp"))));
            this.fld_txtHRDepartmentTotalEmployee.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
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
            resources.ApplyResources(this.fld_lblLabel10, "fld_lblLabel10");
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, ((bool)(resources.GetObject("fld_lblLabel10.ShowHelp"))));
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRDepartments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_BRBranchID, "fld_lkeFK_BRBranchID");
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_BRBranchID.Properties.Buttons"))))});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns2"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns3"))});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = resources.GetString("fld_lkeFK_BRBranchID.Properties.NullText");
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_BRBranchID, ((bool)(resources.GetObject("fld_lkeFK_BRBranchID.ShowHelp"))));
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            resources.ApplyResources(this.bosGroupControl2, "bosGroupControl2");
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcHRDepartmentRooms);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, ((bool)(resources.GetObject("bosGroupControl2.ShowHelp"))));
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
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // fld_chkIsBatch
            // 
            this.fld_chkIsBatch.BOSComment = null;
            this.fld_chkIsBatch.BOSDataMember = "HRDepartmentIsBatch";
            this.fld_chkIsBatch.BOSDataSource = "HRDepartments";
            this.fld_chkIsBatch.BOSDescription = null;
            this.fld_chkIsBatch.BOSError = null;
            this.fld_chkIsBatch.BOSFieldGroup = null;
            this.fld_chkIsBatch.BOSFieldRelation = null;
            this.fld_chkIsBatch.BOSPrivilege = null;
            this.fld_chkIsBatch.BOSPropertyName = null;
            resources.ApplyResources(this.fld_chkIsBatch, "fld_chkIsBatch");
            this.fld_chkIsBatch.MenuManager = this.screenToolbar;
            this.fld_chkIsBatch.Name = "fld_chkIsBatch";
            this.fld_chkIsBatch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("fld_chkSelectAllPlan.Properties.Appearance.Font")));
            this.fld_chkIsBatch.Properties.Appearance.Options.UseFont = true;
            this.fld_chkIsBatch.Properties.Caption = resources.GetString("fld_chkSelectAllPlan.Properties.Caption");
            this.fld_chkIsBatch.Screen = null;
            // 
            // DMHRDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRDP100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartmentRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentTotalEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBatch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentTotalEmployee;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSCheckEdit fld_chkIsBatch;
    }
}
