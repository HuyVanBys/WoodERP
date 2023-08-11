using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMSS105
	/// </summary>
	partial class DMSS105
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnTMNV = new BOSComponent.BOSButton(this.components);
            this.bosButton5 = new BOSComponent.BOSButton(this.components);
            this.fld_btnTBTN = new BOSComponent.BOSButton(this.components);
            this.fld_btnHDHV = new BOSComponent.BOSButton(this.components);
            this.bosButton4 = new BOSComponent.BOSButton(this.components);
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeContracts = new BOSERP.Modules.SellStaff.HREmployeeContractsGridControl();
            this.fld_dgvHREmployeeContracts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContractAllowances = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContractExtraSalary = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContractSalaryFactor = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContractCV = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox10 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeHoursPerDay = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit4 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeContractDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFK_BRBranchIDToWork = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit6 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeContractSigner = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeContractType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeContractStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractAllowances.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractExtraSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractSalaryFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHoursPerDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeContractDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeContractDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_BRBranchIDToWork.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractSigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractStatus.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_btnTMNV);
            this.bosPanel1.Controls.Add(this.bosButton5);
            this.bosPanel1.Controls.Add(this.fld_btnTBTN);
            this.bosPanel1.Controls.Add(this.fld_btnHDHV);
            this.bosPanel1.Controls.Add(this.bosButton4);
            this.bosPanel1.Controls.Add(this.bosButton3);
            this.bosPanel1.Controls.Add(this.bosButton2);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(868, 665);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnTMNV
            // 
            this.fld_btnTMNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnTMNV.BOSComment = null;
            this.fld_btnTMNV.BOSDataMember = null;
            this.fld_btnTMNV.BOSDataSource = null;
            this.fld_btnTMNV.BOSDescription = null;
            this.fld_btnTMNV.BOSError = null;
            this.fld_btnTMNV.BOSFieldGroup = null;
            this.fld_btnTMNV.BOSFieldRelation = null;
            this.fld_btnTMNV.BOSPrivilege = null;
            this.fld_btnTMNV.BOSPropertyName = null;
            this.fld_btnTMNV.Location = new System.Drawing.Point(355, 279);
            this.fld_btnTMNV.Name = "fld_btnTMNV";
            this.fld_btnTMNV.Screen = null;
            this.fld_btnTMNV.Size = new System.Drawing.Size(97, 27);
            this.fld_btnTMNV.TabIndex = 3;
            this.fld_btnTMNV.Text = "Thư mời nhận việc";
            this.fld_btnTMNV.Click += new System.EventHandler(this.fld_btnTMNV_Click);
            // 
            // bosButton5
            // 
            this.bosButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton5.BOSComment = null;
            this.bosButton5.BOSDataMember = null;
            this.bosButton5.BOSDataSource = null;
            this.bosButton5.BOSDescription = null;
            this.bosButton5.BOSError = null;
            this.bosButton5.BOSFieldGroup = null;
            this.bosButton5.BOSFieldRelation = null;
            this.bosButton5.BOSPrivilege = null;
            this.bosButton5.BOSPropertyName = null;
            this.bosButton5.Location = new System.Drawing.Point(539, 279);
            this.bosButton5.Name = "bosButton5";
            this.bosButton5.Screen = null;
            this.bosButton5.Size = new System.Drawing.Size(75, 27);
            this.bosButton5.TabIndex = 5;
            this.bosButton5.Text = "Tạo mới";
            this.bosButton5.Click += new System.EventHandler(this.bosButton5_Click);
            // 
            // fld_btnTBTN
            // 
            this.fld_btnTBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnTBTN.BOSComment = null;
            this.fld_btnTBTN.BOSDataMember = null;
            this.fld_btnTBTN.BOSDataSource = null;
            this.fld_btnTBTN.BOSDescription = null;
            this.fld_btnTBTN.BOSError = null;
            this.fld_btnTBTN.BOSFieldGroup = null;
            this.fld_btnTBTN.BOSFieldRelation = null;
            this.fld_btnTBTN.BOSPrivilege = null;
            this.fld_btnTBTN.BOSPropertyName = null;
            this.fld_btnTBTN.Location = new System.Drawing.Point(458, 279);
            this.fld_btnTBTN.Name = "fld_btnTBTN";
            this.fld_btnTBTN.Screen = null;
            this.fld_btnTBTN.Size = new System.Drawing.Size(75, 27);
            this.fld_btnTBTN.TabIndex = 4;
            this.fld_btnTBTN.Text = "TB Thu nhập";
            this.fld_btnTBTN.Click += new System.EventHandler(this.fld_btnTBTN_Click);
            // 
            // fld_btnHDHV
            // 
            this.fld_btnHDHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnHDHV.BOSComment = null;
            this.fld_btnHDHV.BOSDataMember = null;
            this.fld_btnHDHV.BOSDataSource = null;
            this.fld_btnHDHV.BOSDescription = null;
            this.fld_btnHDHV.BOSError = null;
            this.fld_btnHDHV.BOSFieldGroup = null;
            this.fld_btnHDHV.BOSFieldRelation = null;
            this.fld_btnHDHV.BOSPrivilege = null;
            this.fld_btnHDHV.BOSPropertyName = null;
            this.fld_btnHDHV.Location = new System.Drawing.Point(185, 279);
            this.fld_btnHDHV.Name = "fld_btnHDHV";
            this.fld_btnHDHV.Screen = null;
            this.fld_btnHDHV.Size = new System.Drawing.Size(83, 27);
            this.fld_btnHDHV.TabIndex = 1;
            this.fld_btnHDHV.Text = "In HĐ học việc";
            this.fld_btnHDHV.Click += new System.EventHandler(this.fld_btnHDHV_Click);
            // 
            // bosButton4
            // 
            this.bosButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton4.BOSComment = null;
            this.bosButton4.BOSDataMember = null;
            this.bosButton4.BOSDataSource = null;
            this.bosButton4.BOSDescription = null;
            this.bosButton4.BOSError = null;
            this.bosButton4.BOSFieldGroup = null;
            this.bosButton4.BOSFieldRelation = null;
            this.bosButton4.BOSPrivilege = null;
            this.bosButton4.BOSPropertyName = null;
            this.bosButton4.Location = new System.Drawing.Point(274, 279);
            this.bosButton4.Name = "bosButton4";
            this.bosButton4.Screen = null;
            this.bosButton4.Size = new System.Drawing.Size(75, 27);
            this.bosButton4.TabIndex = 2;
            this.bosButton4.Text = "In Hợp đồng";
            this.bosButton4.Click += new System.EventHandler(this.bosButton4_Click);
            // 
            // bosButton3
            // 
            this.bosButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton3.BOSComment = null;
            this.bosButton3.BOSDataMember = null;
            this.bosButton3.BOSDataSource = null;
            this.bosButton3.BOSDescription = null;
            this.bosButton3.BOSError = null;
            this.bosButton3.BOSFieldGroup = null;
            this.bosButton3.BOSFieldRelation = null;
            this.bosButton3.BOSPrivilege = null;
            this.bosButton3.BOSPropertyName = null;
            this.bosButton3.Location = new System.Drawing.Point(620, 279);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(75, 27);
            this.bosButton3.TabIndex = 6;
            this.bosButton3.Text = "Thêm";
            this.bosButton3.Click += new System.EventHandler(this.bosButton3_Click);
            // 
            // bosButton2
            // 
            this.bosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(782, 279);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(75, 27);
            this.bosButton2.TabIndex = 8;
            this.bosButton2.Text = "Xóa";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(701, 279);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 7;
            this.bosButton1.Text = "Sửa";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeContracts);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 312);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(862, 350);
            this.bosGroupControl2.TabIndex = 9;
            this.bosGroupControl2.Text = "Danh sách hợp đồng";
            // 
            // fld_dgcHREmployeeContracts
            // 
            this.fld_dgcHREmployeeContracts.AllowDrop = true;
            this.fld_dgcHREmployeeContracts.BOSComment = "";
            this.fld_dgcHREmployeeContracts.BOSDataMember = "";
            this.fld_dgcHREmployeeContracts.BOSDataSource = "HREmployeeContracts";
            this.fld_dgcHREmployeeContracts.BOSDescription = null;
            this.fld_dgcHREmployeeContracts.BOSError = null;
            this.fld_dgcHREmployeeContracts.BOSFieldGroup = "";
            this.fld_dgcHREmployeeContracts.BOSFieldRelation = "";
            this.fld_dgcHREmployeeContracts.BOSGridType = null;
            this.fld_dgcHREmployeeContracts.BOSPrivilege = "";
            this.fld_dgcHREmployeeContracts.BOSPropertyName = "";
            this.fld_dgcHREmployeeContracts.CommodityType = "";
            this.fld_dgcHREmployeeContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeContracts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeContracts.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcHREmployeeContracts.MainView = this.fld_dgvHREmployeeContracts;
            this.fld_dgcHREmployeeContracts.Name = "fld_dgcHREmployeeContracts";
            this.fld_dgcHREmployeeContracts.PrintReport = false;
            this.fld_dgcHREmployeeContracts.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeContracts, true);
            this.fld_dgcHREmployeeContracts.Size = new System.Drawing.Size(858, 328);
            this.fld_dgcHREmployeeContracts.TabIndex = 0;
            this.fld_dgcHREmployeeContracts.Tag = "DC";
            this.fld_dgcHREmployeeContracts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeContracts});
            // 
            // fld_dgvHREmployeeContracts
            // 
            this.fld_dgvHREmployeeContracts.GridControl = this.fld_dgcHREmployeeContracts;
            this.fld_dgvHREmployeeContracts.Name = "fld_dgvHREmployeeContracts";
            this.fld_dgvHREmployeeContracts.PaintStyleName = "Office2003";
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeContractStatus);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContractAllowances);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContractSalaryFactor);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLabel24);
            this.bosGroupControl1.Controls.Add(this.bosLabel22);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRLevelID);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel23);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosGroupControl1.Controls.Add(this.bosTextBox5);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContractExtraSalary);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContractCV);
            this.bosGroupControl1.Controls.Add(this.bosTextBox7);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.bosTextBox6);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.bosTextBox10);
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.bosTextBox9);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosTextBox4);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeHoursPerDay);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit4);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_dteHREmployeeContractDateFrom);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel21);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_txtFK_BRBranchIDToWork);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit6);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeContractSigner);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeContractType);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(862, 270);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin hợp đồng";
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(20, 135);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(27, 13);
            this.bosLabel22.TabIndex = 62;
            this.bosLabel22.Text = "Nhóm";
            // 
            // fld_lkeFK_HRLevelID
            // 
            this.fld_lkeFK_HRLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRLevelID.BOSAllowDummy = false;
            this.fld_lkeFK_HRLevelID.BOSComment = null;
            this.fld_lkeFK_HRLevelID.BOSDataMember = "FK_HRLevelID";
            this.fld_lkeFK_HRLevelID.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeFK_HRLevelID.BOSDescription = null;
            this.fld_lkeFK_HRLevelID.BOSError = null;
            this.fld_lkeFK_HRLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_HRLevelID.BOSFieldParent = null;
            this.fld_lkeFK_HRLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_HRLevelID.BOSPrivilege = null;
            this.fld_lkeFK_HRLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRLevelID.BOSSelectType = null;
            this.fld_lkeFK_HRLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_HRLevelID.Location = new System.Drawing.Point(395, 132);
            this.fld_lkeFK_HRLevelID.Name = "fld_lkeFK_HRLevelID";
            this.fld_lkeFK_HRLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_HRLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRLevelName", "Cấp bậc")});
            this.fld_lkeFK_HRLevelID.Properties.DisplayMember = "HRLevelName";
            this.fld_lkeFK_HRLevelID.Properties.ValueMember = "HRLevelID";
            this.fld_lkeFK_HRLevelID.Screen = null;
            this.fld_lkeFK_HRLevelID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRLevelID.TabIndex = 13;
            this.fld_lkeFK_HRLevelID.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(301, 135);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(39, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Cấp bậc";
            // 
            // bosLabel23
            // 
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(572, 109);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(12, 13);
            this.bosLabel23.TabIndex = 61;
            this.bosLabel23.Text = "Tổ";
            // 
            // fld_lkeFK_HRDepartmentRoomGroupTeamItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Location = new System.Drawing.Point(115, 132);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupTeamItemName", "Nhóm")});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.TabIndex = 12;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(675, 106);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 11;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_EditValueChanged);
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "HREmployeeContractNo";
            this.bosTextBox5.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Enabled = false;
            this.bosTextBox5.Location = new System.Drawing.Point(114, 28);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 0;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(20, 31);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(62, 13);
            this.bosLabel15.TabIndex = 60;
            this.bosLabel15.Text = "Mã hợp đồng";
            // 
            // fld_txtHREmployeeContractAllowances
            // 
            this.fld_txtHREmployeeContractAllowances.BOSComment = null;
            this.fld_txtHREmployeeContractAllowances.BOSDataMember = "HREmployeeContractAllowances";
            this.fld_txtHREmployeeContractAllowances.BOSDataSource = "HREmployeeContracts";
            this.fld_txtHREmployeeContractAllowances.BOSDescription = null;
            this.fld_txtHREmployeeContractAllowances.BOSError = null;
            this.fld_txtHREmployeeContractAllowances.BOSFieldGroup = null;
            this.fld_txtHREmployeeContractAllowances.BOSFieldRelation = null;
            this.fld_txtHREmployeeContractAllowances.BOSPrivilege = null;
            this.fld_txtHREmployeeContractAllowances.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContractAllowances.Location = new System.Drawing.Point(395, 210);
            this.fld_txtHREmployeeContractAllowances.Name = "fld_txtHREmployeeContractAllowances";
            this.fld_txtHREmployeeContractAllowances.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContractAllowances.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContractAllowances.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContractAllowances.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContractAllowances.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContractAllowances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContractAllowances.Screen = null;
            this.fld_txtHREmployeeContractAllowances.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContractAllowances.TabIndex = 22;
            this.fld_txtHREmployeeContractAllowances.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(301, 213);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(38, 13);
            this.bosLabel9.TabIndex = 60;
            this.bosLabel9.Text = "Phụ cấp";
            // 
            // fld_txtHREmployeeContractExtraSalary
            // 
            this.fld_txtHREmployeeContractExtraSalary.BOSComment = "";
            this.fld_txtHREmployeeContractExtraSalary.BOSDataMember = "HREmployeeContractExtraSalary";
            this.fld_txtHREmployeeContractExtraSalary.BOSDataSource = "HREmployeeContracts";
            this.fld_txtHREmployeeContractExtraSalary.BOSDescription = null;
            this.fld_txtHREmployeeContractExtraSalary.BOSError = null;
            this.fld_txtHREmployeeContractExtraSalary.BOSFieldGroup = null;
            this.fld_txtHREmployeeContractExtraSalary.BOSFieldRelation = null;
            this.fld_txtHREmployeeContractExtraSalary.BOSPrivilege = null;
            this.fld_txtHREmployeeContractExtraSalary.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContractExtraSalary.Location = new System.Drawing.Point(395, 80);
            this.fld_txtHREmployeeContractExtraSalary.Name = "fld_txtHREmployeeContractExtraSalary";
            this.fld_txtHREmployeeContractExtraSalary.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContractExtraSalary.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContractExtraSalary.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContractExtraSalary.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContractExtraSalary.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContractExtraSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContractExtraSalary.Screen = null;
            this.fld_txtHREmployeeContractExtraSalary.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContractExtraSalary.TabIndex = 7;
            this.fld_txtHREmployeeContractExtraSalary.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(301, 83);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(50, 13);
            this.bosLabel8.TabIndex = 60;
            this.bosLabel8.Text = "Mức lương";
            // 
            // fld_txtHREmployeeContractSalaryFactor
            // 
            this.fld_txtHREmployeeContractSalaryFactor.BOSComment = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSDataMember = "HREmployeeContractSalaryFactor";
            this.fld_txtHREmployeeContractSalaryFactor.BOSDataSource = "HREmployeeContracts";
            this.fld_txtHREmployeeContractSalaryFactor.BOSDescription = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSError = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSFieldGroup = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSFieldRelation = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSPrivilege = null;
            this.fld_txtHREmployeeContractSalaryFactor.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContractSalaryFactor.Location = new System.Drawing.Point(675, 80);
            this.fld_txtHREmployeeContractSalaryFactor.Name = "fld_txtHREmployeeContractSalaryFactor";
            this.fld_txtHREmployeeContractSalaryFactor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContractSalaryFactor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContractSalaryFactor.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContractSalaryFactor.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContractSalaryFactor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContractSalaryFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContractSalaryFactor.Screen = null;
            this.fld_txtHREmployeeContractSalaryFactor.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContractSalaryFactor.TabIndex = 8;
            this.fld_txtHREmployeeContractSalaryFactor.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(572, 83);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(27, 13);
            this.bosLabel7.TabIndex = 60;
            this.bosLabel7.Text = "Hệ số";
            // 
            // fld_txtHREmployeeContractCV
            // 
            this.fld_txtHREmployeeContractCV.BOSComment = null;
            this.fld_txtHREmployeeContractCV.BOSDataMember = "HREmployeeContractCV";
            this.fld_txtHREmployeeContractCV.BOSDataSource = "HREmployeeContracts";
            this.fld_txtHREmployeeContractCV.BOSDescription = null;
            this.fld_txtHREmployeeContractCV.BOSError = null;
            this.fld_txtHREmployeeContractCV.BOSFieldGroup = null;
            this.fld_txtHREmployeeContractCV.BOSFieldRelation = null;
            this.fld_txtHREmployeeContractCV.BOSPrivilege = null;
            this.fld_txtHREmployeeContractCV.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContractCV.Location = new System.Drawing.Point(395, 158);
            this.fld_txtHREmployeeContractCV.Name = "fld_txtHREmployeeContractCV";
            this.fld_txtHREmployeeContractCV.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContractCV.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContractCV.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContractCV.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContractCV.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContractCV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContractCV.Screen = null;
            this.fld_txtHREmployeeContractCV.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContractCV.TabIndex = 16;
            this.fld_txtHREmployeeContractCV.Tag = "DC";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = null;
            this.bosTextBox7.BOSDataMember = "HREmployeeContractCD";
            this.bosTextBox7.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = null;
            this.bosTextBox7.BOSFieldRelation = null;
            this.bosTextBox7.BOSPrivilege = null;
            this.bosTextBox7.BOSPropertyName = "Text";
            this.bosTextBox7.Location = new System.Drawing.Point(675, 132);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox7.TabIndex = 14;
            this.bosTextBox7.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(301, 161);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(40, 13);
            this.bosLabel18.TabIndex = 60;
            this.bosLabel18.Text = "Chức vụ";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "HREmployeeContractCVPL";
            this.bosTextBox6.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.Location = new System.Drawing.Point(115, 158);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox6.TabIndex = 15;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(572, 135);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 60;
            this.bosLabel17.Text = "C.danh c.môn";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(20, 161);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(89, 13);
            this.bosLabel16.TabIndex = 60;
            this.bosLabel16.Text = "Công việc phải làm";
            // 
            // bosTextBox10
            // 
            this.bosTextBox10.BOSComment = null;
            this.bosTextBox10.BOSDataMember = "HREmployeeContractTTK";
            this.bosTextBox10.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox10.BOSDescription = null;
            this.bosTextBox10.BOSError = null;
            this.bosTextBox10.BOSFieldGroup = null;
            this.bosTextBox10.BOSFieldRelation = null;
            this.bosTextBox10.BOSPrivilege = null;
            this.bosTextBox10.BOSPropertyName = "Text";
            this.bosTextBox10.Location = new System.Drawing.Point(114, 210);
            this.bosTextBox10.Name = "bosTextBox10";
            this.bosTextBox10.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox10.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox10.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox10.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox10.Screen = null;
            this.bosTextBox10.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox10.TabIndex = 21;
            this.bosTextBox10.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(20, 213);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(80, 13);
            this.bosLabel20.TabIndex = 60;
            this.bosLabel20.Text = "Thỏa thuận khác";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = null;
            this.bosTextBox9.BOSDataMember = "HREmployeeContractDC";
            this.bosTextBox9.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = null;
            this.bosTextBox9.BOSFieldRelation = null;
            this.bosTextBox9.BOSPrivilege = null;
            this.bosTextBox9.BOSPropertyName = "Text";
            this.bosTextBox9.Location = new System.Drawing.Point(675, 184);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox9.TabIndex = 20;
            this.bosTextBox9.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(572, 187);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(84, 13);
            this.bosLabel19.TabIndex = 60;
            this.bosLabel19.Text = "Dụng cụ cấp phát";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "HREmployeeContractRemark";
            this.bosTextBox4.BOSDataSource = "HREmployeeContracts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Location = new System.Drawing.Point(115, 236);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(431, 20);
            this.bosTextBox4.TabIndex = 23;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(20, 239);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(35, 13);
            this.bosLabel13.TabIndex = 60;
            this.bosLabel13.Text = "Ghi chú";
            // 
            // fld_txtHREmployeeHoursPerDay
            // 
            this.fld_txtHREmployeeHoursPerDay.BOSComment = null;
            this.fld_txtHREmployeeHoursPerDay.BOSDataMember = "HREmployeeContractSalary";
            this.fld_txtHREmployeeHoursPerDay.BOSDataSource = "HREmployeeContracts";
            this.fld_txtHREmployeeHoursPerDay.BOSDescription = null;
            this.fld_txtHREmployeeHoursPerDay.BOSError = null;
            this.fld_txtHREmployeeHoursPerDay.BOSFieldGroup = null;
            this.fld_txtHREmployeeHoursPerDay.BOSFieldRelation = null;
            this.fld_txtHREmployeeHoursPerDay.BOSPrivilege = null;
            this.fld_txtHREmployeeHoursPerDay.BOSPropertyName = "Text";
            this.fld_txtHREmployeeHoursPerDay.Location = new System.Drawing.Point(115, 80);
            this.fld_txtHREmployeeHoursPerDay.Name = "fld_txtHREmployeeHoursPerDay";
            this.fld_txtHREmployeeHoursPerDay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeHoursPerDay.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeHoursPerDay.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeHoursPerDay.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeHoursPerDay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeHoursPerDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeHoursPerDay.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeHoursPerDay, true);
            this.fld_txtHREmployeeHoursPerDay.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeHoursPerDay.TabIndex = 6;
            this.fld_txtHREmployeeHoursPerDay.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(20, 83);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(71, 13);
            this.bosLabel6.TabIndex = 60;
            this.bosLabel6.Text = "Lương căn bản";
            // 
            // bosDateEdit4
            // 
            this.bosDateEdit4.BOSComment = null;
            this.bosDateEdit4.BOSDataMember = "HREmployeeContractSignDate";
            this.bosDateEdit4.BOSDataSource = "HREmployeeContracts";
            this.bosDateEdit4.BOSDescription = null;
            this.bosDateEdit4.BOSError = null;
            this.bosDateEdit4.BOSFieldGroup = null;
            this.bosDateEdit4.BOSFieldRelation = null;
            this.bosDateEdit4.BOSPrivilege = null;
            this.bosDateEdit4.BOSPropertyName = "EditValue";
            this.bosDateEdit4.EditValue = null;
            this.bosDateEdit4.Location = new System.Drawing.Point(395, 184);
            this.bosDateEdit4.Name = "bosDateEdit4";
            this.bosDateEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit4.Screen = null;
            this.bosDateEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit4.TabIndex = 19;
            this.bosDateEdit4.Tag = "DC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "HREmployeeContractDateTo";
            this.bosDateEdit2.BOSDataSource = "HREmployeeContracts";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(395, 54);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 4;
            this.bosDateEdit2.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(301, 187);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(39, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Ngày ký";
            // 
            // fld_dteHREmployeeContractDateFrom
            // 
            this.fld_dteHREmployeeContractDateFrom.BOSComment = "";
            this.fld_dteHREmployeeContractDateFrom.BOSDataMember = "HREmployeeContractDateFrom";
            this.fld_dteHREmployeeContractDateFrom.BOSDataSource = "HREmployeeContracts";
            this.fld_dteHREmployeeContractDateFrom.BOSDescription = null;
            this.fld_dteHREmployeeContractDateFrom.BOSError = null;
            this.fld_dteHREmployeeContractDateFrom.BOSFieldGroup = null;
            this.fld_dteHREmployeeContractDateFrom.BOSFieldRelation = null;
            this.fld_dteHREmployeeContractDateFrom.BOSPrivilege = null;
            this.fld_dteHREmployeeContractDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeContractDateFrom.EditValue = null;
            this.fld_dteHREmployeeContractDateFrom.Location = new System.Drawing.Point(114, 54);
            this.fld_dteHREmployeeContractDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteHREmployeeContractDateFrom.Name = "fld_dteHREmployeeContractDateFrom";
            this.fld_dteHREmployeeContractDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeContractDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeContractDateFrom.Screen = null;
            this.fld_dteHREmployeeContractDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREmployeeContractDateFrom.TabIndex = 3;
            this.fld_dteHREmployeeContractDateFrom.Tag = "DC";
            this.fld_dteHREmployeeContractDateFrom.Validated += new System.EventHandler(this.fld_dteHREmployeeContractDateFrom_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(301, 57);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Đến ngày";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(572, 161);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(82, 13);
            this.bosLabel21.TabIndex = 0;
            this.bosLabel21.Text = "Địa điểm làm việc";
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
            this.bosLabel12.Location = new System.Drawing.Point(301, 109);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 0;
            this.bosLabel12.Text = "Bộ phận";
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
            this.bosLabel11.Location = new System.Drawing.Point(20, 109);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(51, 13);
            this.bosLabel11.TabIndex = 0;
            this.bosLabel11.Text = "Phòng ban";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(572, 57);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(71, 13);
            this.bosLabel14.TabIndex = 0;
            this.bosLabel14.Text = "Khấu trừ BHXH";
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
            this.bosLabel4.Location = new System.Drawing.Point(20, 187);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(42, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Người ký";
            // 
            // fld_txtFK_BRBranchIDToWork
            // 
            this.fld_txtFK_BRBranchIDToWork.BOSAllowAddNew = false;
            this.fld_txtFK_BRBranchIDToWork.BOSAllowDummy = false;
            this.fld_txtFK_BRBranchIDToWork.BOSComment = null;
            this.fld_txtFK_BRBranchIDToWork.BOSDataMember = "FK_BRBranchIDToWork";
            this.fld_txtFK_BRBranchIDToWork.BOSDataSource = "HREmployeeContracts";
            this.fld_txtFK_BRBranchIDToWork.BOSDescription = null;
            this.fld_txtFK_BRBranchIDToWork.BOSError = null;
            this.fld_txtFK_BRBranchIDToWork.BOSFieldGroup = null;
            this.fld_txtFK_BRBranchIDToWork.BOSFieldParent = null;
            this.fld_txtFK_BRBranchIDToWork.BOSFieldRelation = null;
            this.fld_txtFK_BRBranchIDToWork.BOSPrivilege = null;
            this.fld_txtFK_BRBranchIDToWork.BOSPropertyName = "EditValue";
            this.fld_txtFK_BRBranchIDToWork.BOSSelectType = null;
            this.fld_txtFK_BRBranchIDToWork.BOSSelectTypeValue = null;
            this.fld_txtFK_BRBranchIDToWork.CurrentDisplayText = null;
            this.fld_txtFK_BRBranchIDToWork.Location = new System.Drawing.Point(675, 158);
            this.fld_txtFK_BRBranchIDToWork.Name = "fld_txtFK_BRBranchIDToWork";
            this.fld_txtFK_BRBranchIDToWork.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_txtFK_BRBranchIDToWork.Properties.ColumnName = null;
            this.fld_txtFK_BRBranchIDToWork.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_txtFK_BRBranchIDToWork.Properties.DisplayMember = "BRBranchName";
            this.fld_txtFK_BRBranchIDToWork.Properties.ValueMember = "BRBranchID";
            this.fld_txtFK_BRBranchIDToWork.Screen = null;
            this.fld_txtFK_BRBranchIDToWork.Size = new System.Drawing.Size(150, 20);
            this.fld_txtFK_BRBranchIDToWork.TabIndex = 17;
            this.fld_txtFK_BRBranchIDToWork.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployeeContracts";
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
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(114, 106);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 9;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentID_EditValueChanged);
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HREmployeeContracts";
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
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(395, 106);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 10;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID_QueryPopUp);
            this.fld_lkeFK_HRDepartmentRoomID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomID_EditValueChanged);
            // 
            // bosLookupEdit6
            // 
            this.bosLookupEdit6.BOSAllowAddNew = false;
            this.bosLookupEdit6.BOSAllowDummy = false;
            this.bosLookupEdit6.BOSComment = null;
            this.bosLookupEdit6.BOSDataMember = "HREmployeeContractDeductionType";
            this.bosLookupEdit6.BOSDataSource = "HREmployeeContracts";
            this.bosLookupEdit6.BOSDescription = null;
            this.bosLookupEdit6.BOSError = null;
            this.bosLookupEdit6.BOSFieldGroup = null;
            this.bosLookupEdit6.BOSFieldParent = null;
            this.bosLookupEdit6.BOSFieldRelation = null;
            this.bosLookupEdit6.BOSPrivilege = null;
            this.bosLookupEdit6.BOSPropertyName = "EditValue";
            this.bosLookupEdit6.BOSSelectType = null;
            this.bosLookupEdit6.BOSSelectTypeValue = null;
            this.bosLookupEdit6.CurrentDisplayText = null;
            this.bosLookupEdit6.Location = new System.Drawing.Point(675, 54);
            this.bosLookupEdit6.Name = "bosLookupEdit6";
            this.bosLookupEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit6.Properties.ColumnName = null;
            this.bosLookupEdit6.Screen = null;
            this.bosLookupEdit6.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit6.TabIndex = 5;
            this.bosLookupEdit6.Tag = "DC";
            // 
            // fld_lkeHREmployeeContractSigner
            // 
            this.fld_lkeHREmployeeContractSigner.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeContractSigner.BOSAllowDummy = false;
            this.fld_lkeHREmployeeContractSigner.BOSComment = null;
            this.fld_lkeHREmployeeContractSigner.BOSDataMember = "HREmployeeContractSigner";
            this.fld_lkeHREmployeeContractSigner.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeHREmployeeContractSigner.BOSDescription = null;
            this.fld_lkeHREmployeeContractSigner.BOSError = null;
            this.fld_lkeHREmployeeContractSigner.BOSFieldGroup = null;
            this.fld_lkeHREmployeeContractSigner.BOSFieldParent = null;
            this.fld_lkeHREmployeeContractSigner.BOSFieldRelation = null;
            this.fld_lkeHREmployeeContractSigner.BOSPrivilege = null;
            this.fld_lkeHREmployeeContractSigner.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeContractSigner.BOSSelectType = null;
            this.fld_lkeHREmployeeContractSigner.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeContractSigner.CurrentDisplayText = null;
            this.fld_lkeHREmployeeContractSigner.Location = new System.Drawing.Point(115, 184);
            this.fld_lkeHREmployeeContractSigner.Name = "fld_lkeHREmployeeContractSigner";
            this.fld_lkeHREmployeeContractSigner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeContractSigner.Properties.ColumnName = null;
            this.fld_lkeHREmployeeContractSigner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeContractSigner.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeContractSigner.Properties.ReadOnly = true;
            this.fld_lkeHREmployeeContractSigner.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeContractSigner.Screen = null;
            this.fld_lkeHREmployeeContractSigner.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeContractSigner.TabIndex = 18;
            this.fld_lkeHREmployeeContractSigner.Tag = "DC";
            // 
            // fld_lkeHREmployeeContractType
            // 
            this.fld_lkeHREmployeeContractType.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeContractType.BOSAllowDummy = false;
            this.fld_lkeHREmployeeContractType.BOSComment = null;
            this.fld_lkeHREmployeeContractType.BOSDataMember = "HREmployeeContractType";
            this.fld_lkeHREmployeeContractType.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeHREmployeeContractType.BOSDescription = null;
            this.fld_lkeHREmployeeContractType.BOSError = null;
            this.fld_lkeHREmployeeContractType.BOSFieldGroup = null;
            this.fld_lkeHREmployeeContractType.BOSFieldParent = null;
            this.fld_lkeHREmployeeContractType.BOSFieldRelation = null;
            this.fld_lkeHREmployeeContractType.BOSPrivilege = null;
            this.fld_lkeHREmployeeContractType.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeContractType.BOSSelectType = null;
            this.fld_lkeHREmployeeContractType.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeContractType.CurrentDisplayText = null;
            this.fld_lkeHREmployeeContractType.Location = new System.Drawing.Point(395, 28);
            this.fld_lkeHREmployeeContractType.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeContractType.Name = "fld_lkeHREmployeeContractType";
            this.fld_lkeHREmployeeContractType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeContractType.Properties.ColumnName = null;
            this.fld_lkeHREmployeeContractType.Screen = null;
            this.fld_lkeHREmployeeContractType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeContractType.TabIndex = 1;
            this.fld_lkeHREmployeeContractType.Tag = "DC";
            this.fld_lkeHREmployeeContractType.Validated += new System.EventHandler(this.fld_lkeHREmployeeContractType_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(20, 57);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Từ ngày";
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
            this.bosLabel1.Location = new System.Drawing.Point(301, 31);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(67, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Loại hợp đồng";
            // 
            // fld_lkeHREmployeeContractStatus
            // 
            this.fld_lkeHREmployeeContractStatus.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeContractStatus.BOSAllowDummy = false;
            this.fld_lkeHREmployeeContractStatus.BOSComment = null;
            this.fld_lkeHREmployeeContractStatus.BOSDataMember = "HREmployeeContractStatus";
            this.fld_lkeHREmployeeContractStatus.BOSDataSource = "HREmployeeContracts";
            this.fld_lkeHREmployeeContractStatus.BOSDescription = null;
            this.fld_lkeHREmployeeContractStatus.BOSError = null;
            this.fld_lkeHREmployeeContractStatus.BOSFieldGroup = null;
            this.fld_lkeHREmployeeContractStatus.BOSFieldParent = null;
            this.fld_lkeHREmployeeContractStatus.BOSFieldRelation = null;
            this.fld_lkeHREmployeeContractStatus.BOSPrivilege = null;
            this.fld_lkeHREmployeeContractStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeContractStatus.BOSSelectType = null;
            this.fld_lkeHREmployeeContractStatus.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeContractStatus.CurrentDisplayText = null;
            this.fld_lkeHREmployeeContractStatus.Location = new System.Drawing.Point(675, 28);
            this.fld_lkeHREmployeeContractStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeContractStatus.Name = "fld_lkeHREmployeeContractStatus";
            this.fld_lkeHREmployeeContractStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeContractStatus.Properties.ColumnName = null;
            this.fld_lkeHREmployeeContractStatus.Screen = null;
            this.fld_lkeHREmployeeContractStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeContractStatus.TabIndex = 2;
            this.fld_lkeHREmployeeContractStatus.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(572, 31);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(97, 13);
            this.bosLabel24.TabIndex = 63;
            this.bosLabel24.Text = "Trạng thái hợp đồng";
            // 
            // DMSS105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 665);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSS105";
            this.Text = "Thông tin hợp đồng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractAllowances.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractExtraSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractSalaryFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHoursPerDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeContractDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeContractDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_BRBranchIDToWork.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractSigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContractStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeContractType;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeContractDateFrom;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit bosDateEdit4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeContractSigner;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSTextBox fld_txtHREmployeeHoursPerDay;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContractExtraSalary;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContractSalaryFactor;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContractAllowances;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRLevelID;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSButton bosButton3;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private HREmployeeContractsGridControl fld_dgcHREmployeeContracts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeContracts;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit bosLookupEdit6;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSButton bosButton4;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContractCV;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox10;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_txtFK_BRBranchIDToWork;
        private BOSComponent.BOSButton fld_btnTBTN;
        private BOSComponent.BOSButton fld_btnHDHV;
        private BOSComponent.BOSButton bosButton5;
        private BOSComponent.BOSButton fld_btnTMNV;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupTeamItemID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeContractStatus;
        private BOSComponent.BOSLabel bosLabel24;
    }
}
