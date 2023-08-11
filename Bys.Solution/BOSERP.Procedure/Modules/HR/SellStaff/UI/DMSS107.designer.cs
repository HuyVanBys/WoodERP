using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMSS107
	/// </summary>
	partial class DMSS107
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
            this.fld_btnNew = new BOSComponent.BOSButton(this.components);
            this.bosButton4 = new BOSComponent.BOSButton(this.components);
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeTranfers = new BOSERP.Modules.SellStaff.HREmployeeTranfersGridControl();
            this.fld_dgvHREmployeeTranfers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHREmployeeTranferTotalSalary = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTranferSalarySocialInsurance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTranferTotalSalaryOriginal = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeReceivedID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeTranferSigner = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medHREmployeeTranferRemark = new BOSComponent.BOSMemoEdit(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferAllowances = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferExtraSalary = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferSalaryFactor = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferSalary = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomGroupItemIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRLevelIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentIDOld = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeTranferAllowanceAnother = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeTranferSignDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeTranferDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTranfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeTranfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferTotalSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceivedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTranferSigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeeTranferRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferAllowances.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferExtraSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalaryFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalary.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLevelIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentIDOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferAllowanceAnother.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferSignDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferSignDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeContractID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_btnNew);
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
            this.bosPanel1.Size = new System.Drawing.Size(988, 926);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_btnNew
            // 
            this.fld_btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnNew.BOSComment = null;
            this.fld_btnNew.BOSDataMember = null;
            this.fld_btnNew.BOSDataSource = null;
            this.fld_btnNew.BOSDescription = null;
            this.fld_btnNew.BOSError = null;
            this.fld_btnNew.BOSFieldGroup = null;
            this.fld_btnNew.BOSFieldRelation = null;
            this.fld_btnNew.BOSPrivilege = null;
            this.fld_btnNew.BOSPropertyName = null;
            this.fld_btnNew.Location = new System.Drawing.Point(658, 443);
            this.fld_btnNew.Name = "fld_btnNew";
            this.fld_btnNew.Screen = null;
            this.fld_btnNew.Size = new System.Drawing.Size(75, 27);
            this.fld_btnNew.TabIndex = 6;
            this.fld_btnNew.Text = "Tạo mới";
            this.fld_btnNew.Click += new System.EventHandler(this.fld_btnNew_Click);
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
            this.bosButton4.Location = new System.Drawing.Point(577, 443);
            this.bosButton4.Name = "bosButton4";
            this.bosButton4.Screen = null;
            this.bosButton4.Size = new System.Drawing.Size(75, 27);
            this.bosButton4.TabIndex = 1;
            this.bosButton4.Text = "In phụ lục";
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
            this.bosButton3.Location = new System.Drawing.Point(739, 443);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(75, 27);
            this.bosButton3.TabIndex = 2;
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
            this.bosButton2.Location = new System.Drawing.Point(901, 443);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(75, 27);
            this.bosButton2.TabIndex = 4;
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
            this.bosButton1.Location = new System.Drawing.Point(820, 443);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 3;
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeTranfers);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 476);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(982, 447);
            this.bosGroupControl2.TabIndex = 5;
            this.bosGroupControl2.Text = "Lịch sử thuyên chuyển";
            // 
            // fld_dgcHREmployeeTranfers
            // 
            this.fld_dgcHREmployeeTranfers.AllowDrop = true;
            this.fld_dgcHREmployeeTranfers.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.BOSDataSource = "HREmployeeTranfers";
            this.fld_dgcHREmployeeTranfers.BOSDescription = null;
            this.fld_dgcHREmployeeTranfers.BOSError = null;
            this.fld_dgcHREmployeeTranfers.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.BOSGridType = null;
            this.fld_dgcHREmployeeTranfers.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dgcHREmployeeTranfers.CommodityType = "";
            this.fld_dgcHREmployeeTranfers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeTranfers.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeTranfers.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcHREmployeeTranfers.MainView = this.fld_dgvHREmployeeTranfers;
            this.fld_dgcHREmployeeTranfers.Name = "fld_dgcHREmployeeTranfers";
            this.fld_dgcHREmployeeTranfers.PrintReport = false;
            this.fld_dgcHREmployeeTranfers.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeTranfers, true);
            this.fld_dgcHREmployeeTranfers.Size = new System.Drawing.Size(978, 425);
            this.fld_dgcHREmployeeTranfers.TabIndex = 0;
            this.fld_dgcHREmployeeTranfers.Tag = "DC";
            this.fld_dgcHREmployeeTranfers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeTranfers});
            // 
            // fld_dgvHREmployeeTranfers
            // 
            this.fld_dgvHREmployeeTranfers.GridControl = this.fld_dgcHREmployeeTranfers;
            this.fld_dgvHREmployeeTranfers.Name = "fld_dgvHREmployeeTranfers";
            this.fld_dgvHREmployeeTranfers.PaintStyleName = "Office2003";
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
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferTotalSalary);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferSalarySocialInsurance);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferTotalSalaryOriginal);
            this.bosGroupControl1.Controls.Add(this.bosLabel29);
            this.bosGroupControl1.Controls.Add(this.bosLabel28);
            this.bosGroupControl1.Controls.Add(this.bosLabel27);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal);
            this.bosGroupControl1.Controls.Add(this.bosLabel26);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeReceivedID);
            this.bosGroupControl1.Controls.Add(this.bosLabel25);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeTranferSigner);
            this.bosGroupControl1.Controls.Add(this.fld_medHREmployeeTranferRemark);
            this.bosGroupControl1.Controls.Add(this.bosTextBox5);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferAllowances);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferExtraSalary);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferSalaryFactor);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferSalary);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLine1);
            this.bosGroupControl1.Controls.Add(this.bosLine2);
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTranferAllowanceAnother);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_dteHREmployeeTranferSignDate);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_dteHREmployeeTranferDateFrom);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeContractID);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(982, 434);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin thuyên chuyển";
            // 
            // fld_txtHREmployeeTranferTotalSalary
            // 
            this.fld_txtHREmployeeTranferTotalSalary.BOSComment = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSDataMember = "HREmployeeTranferTotalSalary";
            this.fld_txtHREmployeeTranferTotalSalary.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferTotalSalary.BOSDescription = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSError = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferTotalSalary.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferTotalSalary.Location = new System.Drawing.Point(763, 88);
            this.fld_txtHREmployeeTranferTotalSalary.Name = "fld_txtHREmployeeTranferTotalSalary";
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferTotalSalary.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferTotalSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferTotalSalary.Screen = null;
            this.fld_txtHREmployeeTranferTotalSalary.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferTotalSalary.TabIndex = 8;
            this.fld_txtHREmployeeTranferTotalSalary.Tag = "DC";
            // 
            // fld_txtHREmployeeTranferSalarySocialInsurance
            // 
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSComment = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSDataMember = "HREmployeeTranferSalarySocialInsurance";
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSDescription = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSError = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Location = new System.Drawing.Point(763, 114);
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Name = "fld_txtHREmployeeTranferSalarySocialInsurance";
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Screen = null;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferSalarySocialInsurance.TabIndex = 11;
            this.fld_txtHREmployeeTranferSalarySocialInsurance.Tag = "DC";
            // 
            // fld_txtHREmployeeTranferTotalSalaryOriginal
            // 
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSComment = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSDataMember = "HREmployeeTranferTotalSalaryOriginal";
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSDescription = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSError = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Location = new System.Drawing.Point(763, 36);
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Name = "fld_txtHREmployeeTranferTotalSalaryOriginal";
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Screen = null;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.TabIndex = 2;
            this.fld_txtHREmployeeTranferTotalSalaryOriginal.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(612, 65);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(50, 13);
            this.bosLabel29.TabIndex = 77;
            this.bosLabel29.Text = "Mức lương";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(612, 91);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel28, true);
            this.bosLabel28.Size = new System.Drawing.Size(149, 13);
            this.bosLabel28.TabIndex = 76;
            this.bosLabel28.Text = "Tổng lương sau thuyên chuyển";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(612, 117);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(145, 13);
            this.bosLabel27.TabIndex = 75;
            this.bosLabel27.Text = "Mức lương sau thuyên chuyển";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(612, 39);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 74;
            this.bosLabel4.Text = "Tổng lương";
            // 
            // fld_txtHREmployeeTranferSalarySocialInsuranceOriginal
            // 
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSComment = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSDataMember = "HREmployeeTranferSalarySocialInsuranceOriginal";
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSDescription = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSError = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Location = new System.Drawing.Point(763, 62);
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Name = "fld_txtHREmployeeTranferSalarySocialInsuranceOriginal";
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Screen = null;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.TabIndex = 5;
            this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Tag = "DC";
            // 
            // bosLabel26
            // 
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(336, 65);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(76, 13);
            this.bosLabel26.TabIndex = 72;
            this.bosLabel26.Text = "Người tiếp nhận";
            // 
            // fld_lkeFK_HREmployeeReceivedID
            // 
            this.fld_lkeFK_HREmployeeReceivedID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeReceivedID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeReceivedID.BOSComment = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSDataMember = "FK_HREmployeeReceivedID";
            this.fld_lkeFK_HREmployeeReceivedID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HREmployeeReceivedID.BOSDescription = "";
            this.fld_lkeFK_HREmployeeReceivedID.BOSError = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeReceivedID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeReceivedID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeReceivedID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeReceivedID.Location = new System.Drawing.Point(418, 62);
            this.fld_lkeFK_HREmployeeReceivedID.Name = "fld_lkeFK_HREmployeeReceivedID";
            this.fld_lkeFK_HREmployeeReceivedID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeReceivedID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeReceivedID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeReceivedID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeReceivedID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeReceivedID.Screen = null;
            this.fld_lkeFK_HREmployeeReceivedID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeReceivedID.TabIndex = 4;
            this.fld_lkeFK_HREmployeeReceivedID.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(20, 65);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(72, 13);
            this.bosLabel25.TabIndex = 70;
            this.bosLabel25.Text = "Người bàn giao";
            // 
            // fld_lkeHREmployeeTranferSigner
            // 
            this.fld_lkeHREmployeeTranferSigner.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeTranferSigner.BOSAllowDummy = false;
            this.fld_lkeHREmployeeTranferSigner.BOSComment = null;
            this.fld_lkeHREmployeeTranferSigner.BOSDataMember = "HREmployeeTranferSigner";
            this.fld_lkeHREmployeeTranferSigner.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHREmployeeTranferSigner.BOSDescription = "";
            this.fld_lkeHREmployeeTranferSigner.BOSError = null;
            this.fld_lkeHREmployeeTranferSigner.BOSFieldGroup = null;
            this.fld_lkeHREmployeeTranferSigner.BOSFieldParent = null;
            this.fld_lkeHREmployeeTranferSigner.BOSFieldRelation = null;
            this.fld_lkeHREmployeeTranferSigner.BOSPrivilege = null;
            this.fld_lkeHREmployeeTranferSigner.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeTranferSigner.BOSSelectType = null;
            this.fld_lkeHREmployeeTranferSigner.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeTranferSigner.CurrentDisplayText = null;
            this.fld_lkeHREmployeeTranferSigner.Location = new System.Drawing.Point(115, 62);
            this.fld_lkeHREmployeeTranferSigner.Name = "fld_lkeHREmployeeTranferSigner";
            this.fld_lkeHREmployeeTranferSigner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeTranferSigner.Properties.ColumnName = null;
            this.fld_lkeHREmployeeTranferSigner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeTranferSigner.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeTranferSigner.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeTranferSigner.Screen = null;
            this.fld_lkeHREmployeeTranferSigner.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeTranferSigner.TabIndex = 3;
            this.fld_lkeHREmployeeTranferSigner.Tag = "DC";
            // 
            // fld_medHREmployeeTranferRemark
            // 
            this.fld_medHREmployeeTranferRemark.BOSComment = "";
            this.fld_medHREmployeeTranferRemark.BOSDataMember = "HREmployeeTranferRemark";
            this.fld_medHREmployeeTranferRemark.BOSDataSource = "HREmployeeTranfers";
            this.fld_medHREmployeeTranferRemark.BOSDescription = null;
            this.fld_medHREmployeeTranferRemark.BOSError = null;
            this.fld_medHREmployeeTranferRemark.BOSFieldGroup = "";
            this.fld_medHREmployeeTranferRemark.BOSFieldRelation = "";
            this.fld_medHREmployeeTranferRemark.BOSPrivilege = "";
            this.fld_medHREmployeeTranferRemark.BOSPropertyName = "Text";
            this.fld_medHREmployeeTranferRemark.EditValue = "";
            this.fld_medHREmployeeTranferRemark.Location = new System.Drawing.Point(115, 166);
            this.fld_medHREmployeeTranferRemark.Name = "fld_medHREmployeeTranferRemark";
            this.fld_medHREmployeeTranferRemark.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREmployeeTranferRemark.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREmployeeTranferRemark.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREmployeeTranferRemark.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREmployeeTranferRemark.Screen = null;
            this.fld_medHREmployeeTranferRemark.Size = new System.Drawing.Size(453, 77);
            this.fld_medHREmployeeTranferRemark.TabIndex = 13;
            this.fld_medHREmployeeTranferRemark.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "HREmployeeTranferNo";
            this.bosTextBox5.BOSDataSource = "HREmployeeTranfers";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Enabled = false;
            this.bosTextBox5.Location = new System.Drawing.Point(115, 36);
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
            this.bosLabel18.Location = new System.Drawing.Point(20, 39);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(89, 13);
            this.bosLabel18.TabIndex = 0;
            this.bosLabel18.Text = "Mã thuyên chuyển";
            // 
            // fld_txtHREmployeeTranferAllowances
            // 
            this.fld_txtHREmployeeTranferAllowances.BOSComment = null;
            this.fld_txtHREmployeeTranferAllowances.BOSDataMember = "HREmployeeTranferAllowances";
            this.fld_txtHREmployeeTranferAllowances.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferAllowances.BOSDescription = null;
            this.fld_txtHREmployeeTranferAllowances.BOSError = null;
            this.fld_txtHREmployeeTranferAllowances.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferAllowances.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferAllowances.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferAllowances.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferAllowances.Location = new System.Drawing.Point(418, 114);
            this.fld_txtHREmployeeTranferAllowances.Name = "fld_txtHREmployeeTranferAllowances";
            this.fld_txtHREmployeeTranferAllowances.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferAllowances.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferAllowances.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferAllowances.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferAllowances.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferAllowances.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferAllowances.Screen = null;
            this.fld_txtHREmployeeTranferAllowances.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferAllowances.TabIndex = 10;
            this.fld_txtHREmployeeTranferAllowances.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(336, 117);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(38, 13);
            this.bosLabel14.TabIndex = 67;
            this.bosLabel14.Text = "Phụ cấp";
            // 
            // fld_txtHREmployeeTranferExtraSalary
            // 
            this.fld_txtHREmployeeTranferExtraSalary.BOSComment = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSDataMember = "HREmployeeTranferExtraSalary";
            this.fld_txtHREmployeeTranferExtraSalary.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferExtraSalary.BOSDescription = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSError = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferExtraSalary.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferExtraSalary.Location = new System.Drawing.Point(686, 344);
            this.fld_txtHREmployeeTranferExtraSalary.Name = "fld_txtHREmployeeTranferExtraSalary";
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferExtraSalary.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferExtraSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferExtraSalary.Screen = null;
            this.fld_txtHREmployeeTranferExtraSalary.Size = new System.Drawing.Size(98, 20);
            this.fld_txtHREmployeeTranferExtraSalary.TabIndex = 8;
            this.fld_txtHREmployeeTranferExtraSalary.Tag = "DC";
            this.fld_txtHREmployeeTranferExtraSalary.Visible = false;
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
            this.bosLabel15.Location = new System.Drawing.Point(591, 347);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(78, 13);
            this.bosLabel15.TabIndex = 68;
            this.bosLabel15.Text = "Lương công việc";
            this.bosLabel15.Visible = false;
            // 
            // fld_txtHREmployeeTranferSalaryFactor
            // 
            this.fld_txtHREmployeeTranferSalaryFactor.BOSComment = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSDataMember = "HREmployeeTranferSalaryFactor";
            this.fld_txtHREmployeeTranferSalaryFactor.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferSalaryFactor.BOSDescription = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSError = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferSalaryFactor.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferSalaryFactor.Location = new System.Drawing.Point(115, 114);
            this.fld_txtHREmployeeTranferSalaryFactor.Name = "fld_txtHREmployeeTranferSalaryFactor";
            this.fld_txtHREmployeeTranferSalaryFactor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferSalaryFactor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferSalaryFactor.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferSalaryFactor.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferSalaryFactor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferSalaryFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferSalaryFactor.Screen = null;
            this.fld_txtHREmployeeTranferSalaryFactor.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeTranferSalaryFactor.TabIndex = 9;
            this.fld_txtHREmployeeTranferSalaryFactor.Tag = "DC";
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
            this.bosLabel16.Location = new System.Drawing.Point(20, 117);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(27, 13);
            this.bosLabel16.TabIndex = 66;
            this.bosLabel16.Text = "Hệ số";
            // 
            // fld_txtHREmployeeTranferSalary
            // 
            this.fld_txtHREmployeeTranferSalary.BOSComment = null;
            this.fld_txtHREmployeeTranferSalary.BOSDataMember = "HREmployeeTranferSalary";
            this.fld_txtHREmployeeTranferSalary.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferSalary.BOSDescription = null;
            this.fld_txtHREmployeeTranferSalary.BOSError = null;
            this.fld_txtHREmployeeTranferSalary.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferSalary.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferSalary.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferSalary.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferSalary.Location = new System.Drawing.Point(686, 318);
            this.fld_txtHREmployeeTranferSalary.Name = "fld_txtHREmployeeTranferSalary";
            this.fld_txtHREmployeeTranferSalary.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferSalary.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferSalary.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferSalary.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferSalary.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeTranferSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTranferSalary.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferSalary.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeTranferSalary, true);
            this.fld_txtHREmployeeTranferSalary.Size = new System.Drawing.Size(98, 20);
            this.fld_txtHREmployeeTranferSalary.TabIndex = 6;
            this.fld_txtHREmployeeTranferSalary.Tag = "DC";
            this.fld_txtHREmployeeTranferSalary.Visible = false;
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
            this.bosLabel17.Location = new System.Drawing.Point(591, 321);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(65, 13);
            this.bosLabel17.TabIndex = 65;
            this.bosLabel17.Text = "Lương cơ bản";
            this.bosLabel17.Visible = false;
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID);
            this.bosLine1.Controls.Add(this.bosLabel23);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosLine1.Controls.Add(this.bosLabel24);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosLine1.Controls.Add(this.bosLabel8);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HRLevelID);
            this.bosLine1.Location = new System.Drawing.Point(298, 249);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(270, 174);
            this.bosLine1.TabIndex = 15;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin hiện mới";
            // 
            // fld_lkeFK_HRDepartmentRoomGroupTeamItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDescription = "";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Location = new System.Drawing.Point(97, 121);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupTeamItemName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.TabIndex = 79;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID_QueryPopUp);
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
            this.bosLabel23.Location = new System.Drawing.Point(15, 124);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(27, 13);
            this.bosLabel23.TabIndex = 22;
            this.bosLabel23.Text = "Nhóm";
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = "";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(97, 95);
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
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 78;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID1_QueryPopUp);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp);
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
            this.bosLabel24.Location = new System.Drawing.Point(15, 98);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(12, 13);
            this.bosLabel24.TabIndex = 21;
            this.bosLabel24.Text = "Tổ";
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
            this.bosLabel6.Location = new System.Drawing.Point(15, 20);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 0;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_BRBranchID.BOSDescription = "";
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(97, 17);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 0;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(15, 72);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(39, 13);
            this.bosLabel7.TabIndex = 0;
            this.bosLabel7.Text = "Bộ phận";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = "";
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(97, 43);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 1;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_HRDepartmentID_CloseUp);
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
            this.bosLabel8.Location = new System.Drawing.Point(15, 150);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(39, 13);
            this.bosLabel8.TabIndex = 0;
            this.bosLabel8.Text = "Cấp bậc";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(97, 69);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 2;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID_QueryPopUp);
            this.fld_lkeFK_HRDepartmentRoomID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_HRDepartmentRoomID_CloseUp);
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
            this.bosLabel9.Location = new System.Drawing.Point(15, 46);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(51, 13);
            this.bosLabel9.TabIndex = 0;
            this.bosLabel9.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRLevelID
            // 
            this.fld_lkeFK_HRLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_HRLevelID.BOSComment = null;
            this.fld_lkeFK_HRLevelID.BOSDataMember = "FK_HRLevelID";
            this.fld_lkeFK_HRLevelID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HRLevelID.BOSDescription = "";
            this.fld_lkeFK_HRLevelID.BOSError = null;
            this.fld_lkeFK_HRLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_HRLevelID.BOSFieldParent = null;
            this.fld_lkeFK_HRLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_HRLevelID.BOSPrivilege = null;
            this.fld_lkeFK_HRLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRLevelID.BOSSelectType = null;
            this.fld_lkeFK_HRLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_HRLevelID.Location = new System.Drawing.Point(97, 147);
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
            this.fld_lkeFK_HRLevelID.TabIndex = 5;
            this.fld_lkeFK_HRLevelID.Tag = "DC";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld);
            this.bosLine2.Controls.Add(this.bosLabel21);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemIDOld);
            this.bosLine2.Controls.Add(this.bosLabel22);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.fld_lkeBRBranchIDOld);
            this.bosLine2.Controls.Add(this.fld_lkeHRLevelIDOld);
            this.bosLine2.Controls.Add(this.bosLabel10);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentRoomIDOld);
            this.bosLine2.Controls.Add(this.bosLabel12);
            this.bosLine2.Controls.Add(this.fld_lkeHRDepartmentIDOld);
            this.bosLine2.Controls.Add(this.bosLabel11);
            this.bosLine2.Location = new System.Drawing.Point(20, 249);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(266, 174);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thông tin hiện tại";
            // 
            // fld_lkeHRDepartmentRoomGroupTeamItemIDOld
            // 
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSComment = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemOldID";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSDescription = "";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Enabled = false;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Location = new System.Drawing.Point(97, 121);
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Name = "fld_lkeHRDepartmentRoomGroupTeamItemIDOld";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupTeamItemName", "Bộ phận")});
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.TabIndex = 81;
            this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Tag = "DC";
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
            this.bosLabel21.Location = new System.Drawing.Point(15, 124);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(27, 13);
            this.bosLabel21.TabIndex = 18;
            this.bosLabel21.Text = "Nhóm";
            // 
            // fld_lkeHRDepartmentRoomGroupItemIDOld
            // 
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSComment = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSDataMember = "FK_HRDepartmentRoomGroupItemOldID";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSDescription = "";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Enabled = false;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Location = new System.Drawing.Point(97, 95);
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Name = "fld_lkeHRDepartmentRoomGroupItemIDOld";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.TabIndex = 80;
            this.fld_lkeHRDepartmentRoomGroupItemIDOld.Tag = "DC";
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
            this.bosLabel22.Location = new System.Drawing.Point(15, 98);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(12, 13);
            this.bosLabel22.TabIndex = 17;
            this.bosLabel22.Text = "Tổ";
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 20);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchIDOld
            // 
            this.fld_lkeBRBranchIDOld.BOSAllowAddNew = false;
            this.fld_lkeBRBranchIDOld.BOSAllowDummy = false;
            this.fld_lkeBRBranchIDOld.BOSComment = null;
            this.fld_lkeBRBranchIDOld.BOSDataMember = "FK_BRBranchOldID";
            this.fld_lkeBRBranchIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeBRBranchIDOld.BOSDescription = "";
            this.fld_lkeBRBranchIDOld.BOSError = null;
            this.fld_lkeBRBranchIDOld.BOSFieldGroup = null;
            this.fld_lkeBRBranchIDOld.BOSFieldParent = null;
            this.fld_lkeBRBranchIDOld.BOSFieldRelation = null;
            this.fld_lkeBRBranchIDOld.BOSPrivilege = null;
            this.fld_lkeBRBranchIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchIDOld.BOSSelectType = null;
            this.fld_lkeBRBranchIDOld.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchIDOld.CurrentDisplayText = null;
            this.fld_lkeBRBranchIDOld.Enabled = false;
            this.fld_lkeBRBranchIDOld.Location = new System.Drawing.Point(97, 17);
            this.fld_lkeBRBranchIDOld.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchIDOld.Name = "fld_lkeBRBranchIDOld";
            this.fld_lkeBRBranchIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeBRBranchIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchIDOld.Properties.ColumnName = null;
            this.fld_lkeBRBranchIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchIDOld.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchIDOld.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchIDOld.Screen = null;
            this.fld_lkeBRBranchIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchIDOld.TabIndex = 0;
            this.fld_lkeBRBranchIDOld.Tag = "DC";
            // 
            // fld_lkeHRLevelIDOld
            // 
            this.fld_lkeHRLevelIDOld.BOSAllowAddNew = false;
            this.fld_lkeHRLevelIDOld.BOSAllowDummy = false;
            this.fld_lkeHRLevelIDOld.BOSComment = null;
            this.fld_lkeHRLevelIDOld.BOSDataMember = "FK_HRLevelOldID";
            this.fld_lkeHRLevelIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHRLevelIDOld.BOSDescription = "";
            this.fld_lkeHRLevelIDOld.BOSError = null;
            this.fld_lkeHRLevelIDOld.BOSFieldGroup = null;
            this.fld_lkeHRLevelIDOld.BOSFieldParent = null;
            this.fld_lkeHRLevelIDOld.BOSFieldRelation = null;
            this.fld_lkeHRLevelIDOld.BOSPrivilege = null;
            this.fld_lkeHRLevelIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeHRLevelIDOld.BOSSelectType = null;
            this.fld_lkeHRLevelIDOld.BOSSelectTypeValue = null;
            this.fld_lkeHRLevelIDOld.CurrentDisplayText = null;
            this.fld_lkeHRLevelIDOld.Enabled = false;
            this.fld_lkeHRLevelIDOld.Location = new System.Drawing.Point(97, 147);
            this.fld_lkeHRLevelIDOld.Name = "fld_lkeHRLevelIDOld";
            this.fld_lkeHRLevelIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRLevelIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRLevelIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRLevelIDOld.Properties.ColumnName = null;
            this.fld_lkeHRLevelIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRLevelName", "Cấp bậc")});
            this.fld_lkeHRLevelIDOld.Properties.DisplayMember = "HRLevelName";
            this.fld_lkeHRLevelIDOld.Properties.ValueMember = "HRLevelID";
            this.fld_lkeHRLevelIDOld.Screen = null;
            this.fld_lkeHRLevelIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRLevelIDOld.TabIndex = 5;
            this.fld_lkeHRLevelIDOld.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(15, 150);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(39, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Cấp bậc";
            // 
            // fld_lkeHRDepartmentRoomIDOld
            // 
            this.fld_lkeHRDepartmentRoomIDOld.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomIDOld.BOSAllowDummy = false;
            this.fld_lkeHRDepartmentRoomIDOld.BOSComment = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSDataMember = "FK_HRDepartmentRoomOldID";
            this.fld_lkeHRDepartmentRoomIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHRDepartmentRoomIDOld.BOSDescription = "";
            this.fld_lkeHRDepartmentRoomIDOld.BOSError = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomIDOld.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomIDOld.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomIDOld.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomIDOld.Enabled = false;
            this.fld_lkeHRDepartmentRoomIDOld.Location = new System.Drawing.Point(97, 69);
            this.fld_lkeHRDepartmentRoomIDOld.Name = "fld_lkeHRDepartmentRoomIDOld";
            this.fld_lkeHRDepartmentRoomIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRDepartmentRoomIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomIDOld.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeHRDepartmentRoomIDOld.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomIDOld.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomIDOld.Screen = null;
            this.fld_lkeHRDepartmentRoomIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomIDOld.TabIndex = 2;
            this.fld_lkeHRDepartmentRoomIDOld.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(15, 72);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 0;
            this.bosLabel12.Text = "Bộ phận";
            // 
            // fld_lkeHRDepartmentIDOld
            // 
            this.fld_lkeHRDepartmentIDOld.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentIDOld.BOSAllowDummy = false;
            this.fld_lkeHRDepartmentIDOld.BOSComment = null;
            this.fld_lkeHRDepartmentIDOld.BOSDataMember = "FK_HRDepartmentOldID";
            this.fld_lkeHRDepartmentIDOld.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeHRDepartmentIDOld.BOSDescription = "";
            this.fld_lkeHRDepartmentIDOld.BOSError = null;
            this.fld_lkeHRDepartmentIDOld.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentIDOld.BOSFieldParent = null;
            this.fld_lkeHRDepartmentIDOld.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentIDOld.BOSPrivilege = null;
            this.fld_lkeHRDepartmentIDOld.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentIDOld.BOSSelectType = null;
            this.fld_lkeHRDepartmentIDOld.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentIDOld.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentIDOld.Enabled = false;
            this.fld_lkeHRDepartmentIDOld.Location = new System.Drawing.Point(97, 43);
            this.fld_lkeHRDepartmentIDOld.Name = "fld_lkeHRDepartmentIDOld";
            this.fld_lkeHRDepartmentIDOld.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRDepartmentIDOld.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentIDOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentIDOld.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentIDOld.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeHRDepartmentIDOld.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentIDOld.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentIDOld.Screen = null;
            this.fld_lkeHRDepartmentIDOld.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentIDOld.TabIndex = 1;
            this.fld_lkeHRDepartmentIDOld.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(15, 46);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(51, 13);
            this.bosLabel11.TabIndex = 0;
            this.bosLabel11.Text = "Phòng ban";
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
            this.bosLabel20.Location = new System.Drawing.Point(20, 143);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(63, 13);
            this.bosLabel20.TabIndex = 60;
            this.bosLabel20.Text = "Phụ cấp khác";
            // 
            // fld_txtHREmployeeTranferAllowanceAnother
            // 
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSComment = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSDataMember = "HREmployeeTranferAllowanceAnother";
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSDataSource = "HREmployeeTranfers";
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSDescription = "";
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSError = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSFieldGroup = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSFieldRelation = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSPrivilege = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTranferAllowanceAnother.Location = new System.Drawing.Point(115, 140);
            this.fld_txtHREmployeeTranferAllowanceAnother.Name = "fld_txtHREmployeeTranferAllowanceAnother";
            this.fld_txtHREmployeeTranferAllowanceAnother.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTranferAllowanceAnother.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTranferAllowanceAnother.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTranferAllowanceAnother.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTranferAllowanceAnother.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTranferAllowanceAnother.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeTranferAllowanceAnother.Screen = null;
            this.fld_txtHREmployeeTranferAllowanceAnother.Size = new System.Drawing.Size(453, 20);
            this.fld_txtHREmployeeTranferAllowanceAnother.TabIndex = 12;
            this.fld_txtHREmployeeTranferAllowanceAnother.Tag = "DC";
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
            this.bosLabel13.Location = new System.Drawing.Point(20, 168);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(87, 13);
            this.bosLabel13.TabIndex = 60;
            this.bosLabel13.Text = "Lý do điều chuyển";
            // 
            // fld_dteHREmployeeTranferSignDate
            // 
            this.fld_dteHREmployeeTranferSignDate.BOSComment = null;
            this.fld_dteHREmployeeTranferSignDate.BOSDataMember = "HREmployeeTranferSignDate";
            this.fld_dteHREmployeeTranferSignDate.BOSDataSource = "HREmployeeTranfers";
            this.fld_dteHREmployeeTranferSignDate.BOSDescription = "";
            this.fld_dteHREmployeeTranferSignDate.BOSError = null;
            this.fld_dteHREmployeeTranferSignDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeTranferSignDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeTranferSignDate.BOSPrivilege = null;
            this.fld_dteHREmployeeTranferSignDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeTranferSignDate.EditValue = null;
            this.fld_dteHREmployeeTranferSignDate.Location = new System.Drawing.Point(418, 88);
            this.fld_dteHREmployeeTranferSignDate.Name = "fld_dteHREmployeeTranferSignDate";
            this.fld_dteHREmployeeTranferSignDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeTranferSignDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeTranferSignDate.Screen = null;
            this.fld_dteHREmployeeTranferSignDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREmployeeTranferSignDate.TabIndex = 7;
            this.fld_dteHREmployeeTranferSignDate.Tag = "DC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "HREmployeeTranferDateTo";
            this.bosDateEdit2.BOSDataSource = "HREmployeeTranfers";
            this.bosDateEdit2.BOSDescription = "";
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(648, 292);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(73, 20);
            this.bosDateEdit2.TabIndex = 6;
            this.bosDateEdit2.Tag = "DC";
            this.bosDateEdit2.Visible = false;
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
            this.bosLabel5.Location = new System.Drawing.Point(336, 91);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(39, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Ngày ký";
            // 
            // fld_dteHREmployeeTranferDateFrom
            // 
            this.fld_dteHREmployeeTranferDateFrom.BOSComment = null;
            this.fld_dteHREmployeeTranferDateFrom.BOSDataMember = "HREmployeeTranferDateFrom";
            this.fld_dteHREmployeeTranferDateFrom.BOSDataSource = "HREmployeeTranfers";
            this.fld_dteHREmployeeTranferDateFrom.BOSDescription = "";
            this.fld_dteHREmployeeTranferDateFrom.BOSError = null;
            this.fld_dteHREmployeeTranferDateFrom.BOSFieldGroup = null;
            this.fld_dteHREmployeeTranferDateFrom.BOSFieldRelation = null;
            this.fld_dteHREmployeeTranferDateFrom.BOSPrivilege = null;
            this.fld_dteHREmployeeTranferDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeTranferDateFrom.EditValue = null;
            this.fld_dteHREmployeeTranferDateFrom.Location = new System.Drawing.Point(115, 88);
            this.fld_dteHREmployeeTranferDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteHREmployeeTranferDateFrom.Name = "fld_dteHREmployeeTranferDateFrom";
            this.fld_dteHREmployeeTranferDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeTranferDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeTranferDateFrom.Screen = null;
            this.fld_dteHREmployeeTranferDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREmployeeTranferDateFrom.TabIndex = 6;
            this.fld_dteHREmployeeTranferDateFrom.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(597, 295);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Đến ngày";
            this.bosLabel3.Visible = false;
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(336, 39);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(62, 13);
            this.bosLabel19.TabIndex = 0;
            this.bosLabel19.Text = "Mã hợp đồng";
            // 
            // fld_lkeFK_HREmployeeContractID
            // 
            this.fld_lkeFK_HREmployeeContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeContractID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeContractID.BOSComment = null;
            this.fld_lkeFK_HREmployeeContractID.BOSDataMember = "FK_HREmployeeContractID";
            this.fld_lkeFK_HREmployeeContractID.BOSDataSource = "HREmployeeTranfers";
            this.fld_lkeFK_HREmployeeContractID.BOSDescription = "";
            this.fld_lkeFK_HREmployeeContractID.BOSError = null;
            this.fld_lkeFK_HREmployeeContractID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeContractID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeContractID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeContractID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeContractID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeContractID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeContractID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeContractID.Location = new System.Drawing.Point(418, 36);
            this.fld_lkeFK_HREmployeeContractID.Name = "fld_lkeFK_HREmployeeContractID";
            this.fld_lkeFK_HREmployeeContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeContractID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeContractNo", "Mã hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeContractDateFrom", "Từ ngày", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeContractDateTo", "Đến ngày", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_HREmployeeContractID.Properties.DisplayMember = "HREmployeeContractNo";
            this.fld_lkeFK_HREmployeeContractID.Properties.ValueMember = "HREmployeeContractID";
            this.fld_lkeFK_HREmployeeContractID.Screen = null;
            this.fld_lkeFK_HREmployeeContractID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeContractID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeContractID.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(20, 91);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(86, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Ngày luân chuyển";
            // 
            // DMSS107
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(988, 926);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSS107";
            this.Text = "Lịch sử thuyên chuyển";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTranfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeTranfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferTotalSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalarySocialInsurance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferTotalSalaryOriginal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalarySocialInsuranceOriginal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeReceivedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTranferSigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeeTranferRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferAllowances.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferExtraSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalaryFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferSalary.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupTeamItemIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLevelIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentIDOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTranferAllowanceAnother.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferSignDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferSignDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTranferDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeContractID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton bosButton3;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferAllowanceAnother;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeTranferSignDate;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeTranferDateFrom;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentIDOld;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomIDOld;
        private BOSComponent.BOSLookupEdit fld_lkeHRLevelIDOld;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchIDOld;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private HREmployeeTranfersGridControl fld_dgcHREmployeeTranfers;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeTranfers;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRLevelID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferAllowances;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferExtraSalary;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferSalaryFactor;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferSalary;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSButton bosButton4;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeContractID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSMemoEdit fld_medHREmployeeTranferRemark;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeReceivedID;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeTranferSigner;
        private BOSComponent.BOSButton fld_btnNew;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferTotalSalary;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferSalarySocialInsurance;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferTotalSalaryOriginal;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTranferSalarySocialInsuranceOriginal;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupTeamItemID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupTeamItemIDOld;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupItemIDOld;
    }
}
