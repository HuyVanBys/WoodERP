using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRReward.UI
{
	/// <summary>
	/// Summary description for DMHRRW100
	/// </summary>
	partial class DMHRRW100
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
            this.fld_grcEmployeeReward = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnDelete = new BOSComponent.BOSButton(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeRewards = new BOSERP.Modules.HRReward.HREmployeeRewardGridControl();
            this.fld_dgvHREmployeeRewards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblHRRewardFromDate = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRewardNo2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRewardName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRRewardDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRRewardFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRRewardToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRRewardOption = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRRewardType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRRewardValue = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcEmployeeReward)).BeginInit();
            this.fld_grcEmployeeReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeRewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeRewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRewardDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRewardOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRewardType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardValue.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcEmployeeReward);
            this.bosPanel1.Controls.Add(this.fld_lblHRRewardFromDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRRewardNo2);
            this.bosPanel1.Controls.Add(this.fld_txtHRRewardName1);
            this.bosPanel1.Controls.Add(this.fld_medHRRewardDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRRewardFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteHRRewardToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRRewardOption);
            this.bosPanel1.Controls.Add(this.fld_lkeHRRewardType);
            this.bosPanel1.Controls.Add(this.fld_txtHRRewardValue);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(868, 574);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_grcEmployeeReward
            // 
            this.fld_grcEmployeeReward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcEmployeeReward.BOSComment = null;
            this.fld_grcEmployeeReward.BOSDataMember = null;
            this.fld_grcEmployeeReward.BOSDataSource = null;
            this.fld_grcEmployeeReward.BOSDescription = null;
            this.fld_grcEmployeeReward.BOSError = null;
            this.fld_grcEmployeeReward.BOSFieldGroup = null;
            this.fld_grcEmployeeReward.BOSFieldRelation = null;
            this.fld_grcEmployeeReward.BOSPrivilege = null;
            this.fld_grcEmployeeReward.BOSPropertyName = null;
            this.fld_grcEmployeeReward.Controls.Add(this.fld_btnDelete);
            this.fld_grcEmployeeReward.Controls.Add(this.fld_btnAdd);
            this.fld_grcEmployeeReward.Controls.Add(this.fld_dgcHREmployeeRewards);
            this.fld_grcEmployeeReward.Location = new System.Drawing.Point(0, 162);
            this.fld_grcEmployeeReward.Name = "fld_grcEmployeeReward";
            this.fld_grcEmployeeReward.Screen = null;
            this.fld_grcEmployeeReward.Size = new System.Drawing.Size(868, 412);
            this.fld_grcEmployeeReward.TabIndex = 34;
            this.fld_grcEmployeeReward.Text = "Danh sách nhân viên được thưởng";
            // 
            // fld_btnDelete
            // 
            this.fld_btnDelete.BOSComment = null;
            this.fld_btnDelete.BOSDataMember = null;
            this.fld_btnDelete.BOSDataSource = null;
            this.fld_btnDelete.BOSDescription = null;
            this.fld_btnDelete.BOSError = null;
            this.fld_btnDelete.BOSFieldGroup = null;
            this.fld_btnDelete.BOSFieldRelation = null;
            this.fld_btnDelete.BOSPrivilege = null;
            this.fld_btnDelete.BOSPropertyName = null;
            this.fld_btnDelete.Location = new System.Drawing.Point(106, 26);
            this.fld_btnDelete.Name = "fld_btnDelete";
            this.fld_btnDelete.Screen = null;
            this.fld_btnDelete.Size = new System.Drawing.Size(87, 27);
            this.fld_btnDelete.TabIndex = 1;
            this.fld_btnDelete.Text = "Xóa nhân viên";
            this.fld_btnDelete.Click += new System.EventHandler(this.fld_btnDelete_Click);
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.BOSComment = null;
            this.fld_btnAdd.BOSDataMember = null;
            this.fld_btnAdd.BOSDataSource = null;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = null;
            this.fld_btnAdd.BOSFieldRelation = null;
            this.fld_btnAdd.BOSPrivilege = null;
            this.fld_btnAdd.BOSPropertyName = null;
            this.fld_btnAdd.Location = new System.Drawing.Point(13, 26);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(87, 27);
            this.fld_btnAdd.TabIndex = 0;
            this.fld_btnAdd.Text = "Thêm nhân viên";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_dgcHREmployeeRewards
            // 
            this.fld_dgcHREmployeeRewards.AllowDrop = true;
            this.fld_dgcHREmployeeRewards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeRewards.BOSComment = "";
            this.fld_dgcHREmployeeRewards.BOSDataMember = "";
            this.fld_dgcHREmployeeRewards.BOSDataSource = "HREmployeeRewards";
            this.fld_dgcHREmployeeRewards.BOSDescription = null;
            this.fld_dgcHREmployeeRewards.BOSError = null;
            this.fld_dgcHREmployeeRewards.BOSFieldGroup = "";
            this.fld_dgcHREmployeeRewards.BOSFieldRelation = "";
            this.fld_dgcHREmployeeRewards.BOSGridType = null;
            this.fld_dgcHREmployeeRewards.BOSPrivilege = "";
            this.fld_dgcHREmployeeRewards.BOSPropertyName = "";
            this.fld_dgcHREmployeeRewards.CommodityType = "";
            this.fld_dgcHREmployeeRewards.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeRewards.Location = new System.Drawing.Point(0, 59);
            this.fld_dgcHREmployeeRewards.MainView = this.fld_dgvHREmployeeRewards;
            this.fld_dgcHREmployeeRewards.Name = "fld_dgcHREmployeeRewards";
            this.fld_dgcHREmployeeRewards.PrintReport = false;
            this.fld_dgcHREmployeeRewards.Screen = null;
            this.fld_dgcHREmployeeRewards.Size = new System.Drawing.Size(868, 353);
            this.fld_dgcHREmployeeRewards.TabIndex = 2;
            this.fld_dgcHREmployeeRewards.Tag = "DC";
            this.fld_dgcHREmployeeRewards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeRewards});
            // 
            // fld_dgvHREmployeeRewards
            // 
            this.fld_dgvHREmployeeRewards.GridControl = this.fld_dgcHREmployeeRewards;
            this.fld_dgvHREmployeeRewards.Name = "fld_dgvHREmployeeRewards";
            this.fld_dgvHREmployeeRewards.PaintStyleName = "Office2003";
            // 
            // fld_lblHRRewardFromDate
            // 
            this.fld_lblHRRewardFromDate.BOSComment = null;
            this.fld_lblHRRewardFromDate.BOSDataMember = null;
            this.fld_lblHRRewardFromDate.BOSDataSource = null;
            this.fld_lblHRRewardFromDate.BOSDescription = null;
            this.fld_lblHRRewardFromDate.BOSError = null;
            this.fld_lblHRRewardFromDate.BOSFieldGroup = null;
            this.fld_lblHRRewardFromDate.BOSFieldRelation = null;
            this.fld_lblHRRewardFromDate.BOSPrivilege = null;
            this.fld_lblHRRewardFromDate.BOSPropertyName = null;
            this.fld_lblHRRewardFromDate.Location = new System.Drawing.Point(7, 78);
            this.fld_lblHRRewardFromDate.Name = "fld_lblHRRewardFromDate";
            this.fld_lblHRRewardFromDate.Screen = null;
            this.fld_lblHRRewardFromDate.Size = new System.Drawing.Size(72, 13);
            this.fld_lblHRRewardFromDate.TabIndex = 33;
            this.fld_lblHRRewardFromDate.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(7, 11);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel2.TabIndex = 19;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã khen thưởng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(346, 107);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(83, 13);
            this.bosLabel1.TabIndex = 20;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Loại khen thưởng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(403, 10);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(26, 13);
            this.fld_lblLabel3.TabIndex = 20;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Lý do";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(7, 47);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 21;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(387, 82);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel6.TabIndex = 22;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Kỳ lương";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(7, 107);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel7.TabIndex = 23;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Hình thức";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(7, 133);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(34, 13);
            this.fld_lblLabel8.TabIndex = 24;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Chi tiết";
            // 
            // fld_txtHRRewardNo2
            // 
            this.fld_txtHRRewardNo2.BOSComment = "";
            this.fld_txtHRRewardNo2.BOSDataMember = "HRRewardNo";
            this.fld_txtHRRewardNo2.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardNo2.BOSDescription = null;
            this.fld_txtHRRewardNo2.BOSError = null;
            this.fld_txtHRRewardNo2.BOSFieldGroup = "";
            this.fld_txtHRRewardNo2.BOSFieldRelation = "";
            this.fld_txtHRRewardNo2.BOSPrivilege = "";
            this.fld_txtHRRewardNo2.BOSPropertyName = "Text";
            this.fld_txtHRRewardNo2.EditValue = "";
            this.fld_txtHRRewardNo2.Location = new System.Drawing.Point(91, 8);
            this.fld_txtHRRewardNo2.Name = "fld_txtHRRewardNo2";
            this.fld_txtHRRewardNo2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardNo2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardNo2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardNo2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardNo2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardNo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardNo2.Screen = null;
            this.fld_txtHRRewardNo2.Size = new System.Drawing.Size(237, 20);
            this.fld_txtHRRewardNo2.TabIndex = 1;
            this.fld_txtHRRewardNo2.Tag = "DC";
            // 
            // fld_txtHRRewardName1
            // 
            this.fld_txtHRRewardName1.BOSComment = "";
            this.fld_txtHRRewardName1.BOSDataMember = "HRRewardName";
            this.fld_txtHRRewardName1.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardName1.BOSDescription = null;
            this.fld_txtHRRewardName1.BOSError = null;
            this.fld_txtHRRewardName1.BOSFieldGroup = "";
            this.fld_txtHRRewardName1.BOSFieldRelation = "";
            this.fld_txtHRRewardName1.BOSPrivilege = "";
            this.fld_txtHRRewardName1.BOSPropertyName = "Text";
            this.fld_txtHRRewardName1.EditValue = "";
            this.fld_txtHRRewardName1.Location = new System.Drawing.Point(451, 7);
            this.fld_txtHRRewardName1.Name = "fld_txtHRRewardName1";
            this.fld_txtHRRewardName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardName1.Screen = null;
            this.fld_txtHRRewardName1.Size = new System.Drawing.Size(235, 20);
            this.fld_txtHRRewardName1.TabIndex = 2;
            this.fld_txtHRRewardName1.Tag = "DC";
            // 
            // fld_medHRRewardDesc
            // 
            this.fld_medHRRewardDesc.BOSComment = "";
            this.fld_medHRRewardDesc.BOSDataMember = "HRRewardDesc";
            this.fld_medHRRewardDesc.BOSDataSource = "HRRewards";
            this.fld_medHRRewardDesc.BOSDescription = null;
            this.fld_medHRRewardDesc.BOSError = null;
            this.fld_medHRRewardDesc.BOSFieldGroup = "";
            this.fld_medHRRewardDesc.BOSFieldRelation = "";
            this.fld_medHRRewardDesc.BOSPrivilege = "";
            this.fld_medHRRewardDesc.BOSPropertyName = "Text";
            this.fld_medHRRewardDesc.EditValue = "";
            this.fld_medHRRewardDesc.Location = new System.Drawing.Point(91, 33);
            this.fld_medHRRewardDesc.Name = "fld_medHRRewardDesc";
            this.fld_medHRRewardDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRewardDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRewardDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRewardDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRewardDesc.Screen = null;
            this.fld_medHRRewardDesc.Size = new System.Drawing.Size(595, 40);
            this.fld_medHRRewardDesc.TabIndex = 3;
            this.fld_medHRRewardDesc.Tag = "DC";
            // 
            // fld_dteHRRewardFromDate
            // 
            this.fld_dteHRRewardFromDate.BOSComment = "";
            this.fld_dteHRRewardFromDate.BOSDataMember = "HRRewardFromDate";
            this.fld_dteHRRewardFromDate.BOSDataSource = "HRRewards";
            this.fld_dteHRRewardFromDate.BOSDescription = null;
            this.fld_dteHRRewardFromDate.BOSError = null;
            this.fld_dteHRRewardFromDate.BOSFieldGroup = "";
            this.fld_dteHRRewardFromDate.BOSFieldRelation = "";
            this.fld_dteHRRewardFromDate.BOSPrivilege = "";
            this.fld_dteHRRewardFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRewardFromDate.EditValue = null;
            this.fld_dteHRRewardFromDate.Location = new System.Drawing.Point(91, 79);
            this.fld_dteHRRewardFromDate.Name = "fld_dteHRRewardFromDate";
            this.fld_dteHRRewardFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRewardFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRewardFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRewardFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRewardFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRewardFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRewardFromDate.Screen = null;
            this.fld_dteHRRewardFromDate.Size = new System.Drawing.Size(237, 20);
            this.fld_dteHRRewardFromDate.TabIndex = 4;
            this.fld_dteHRRewardFromDate.Tag = "DC";
            // 
            // fld_dteHRRewardToDate
            // 
            this.fld_dteHRRewardToDate.BOSComment = "";
            this.fld_dteHRRewardToDate.BOSDataMember = "HRRewardToDate";
            this.fld_dteHRRewardToDate.BOSDataSource = "HRRewards";
            this.fld_dteHRRewardToDate.BOSDescription = null;
            this.fld_dteHRRewardToDate.BOSError = null;
            this.fld_dteHRRewardToDate.BOSFieldGroup = "";
            this.fld_dteHRRewardToDate.BOSFieldRelation = "";
            this.fld_dteHRRewardToDate.BOSPrivilege = "";
            this.fld_dteHRRewardToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRewardToDate.EditValue = null;
            this.fld_dteHRRewardToDate.Location = new System.Drawing.Point(451, 80);
            this.fld_dteHRRewardToDate.Name = "fld_dteHRRewardToDate";
            this.fld_dteHRRewardToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRewardToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRewardToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRewardToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRewardToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRewardToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRewardToDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRRewardToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRRewardToDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRRewardToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRRewardToDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRRewardToDate.Screen = null;
            this.fld_dteHRRewardToDate.Size = new System.Drawing.Size(235, 20);
            this.fld_dteHRRewardToDate.TabIndex = 5;
            this.fld_dteHRRewardToDate.Tag = "DC";
            // 
            // fld_lkeHRRewardOption
            // 
            this.fld_lkeHRRewardOption.BOSAllowAddNew = false;
            this.fld_lkeHRRewardOption.BOSAllowDummy = false;
            this.fld_lkeHRRewardOption.BOSComment = "";
            this.fld_lkeHRRewardOption.BOSDataMember = "HRRewardOption";
            this.fld_lkeHRRewardOption.BOSDataSource = "HRRewards";
            this.fld_lkeHRRewardOption.BOSDescription = null;
            this.fld_lkeHRRewardOption.BOSError = null;
            this.fld_lkeHRRewardOption.BOSFieldGroup = "";
            this.fld_lkeHRRewardOption.BOSFieldParent = "";
            this.fld_lkeHRRewardOption.BOSFieldRelation = "";
            this.fld_lkeHRRewardOption.BOSPrivilege = "";
            this.fld_lkeHRRewardOption.BOSPropertyName = "EditValue";
            this.fld_lkeHRRewardOption.BOSSelectType = "";
            this.fld_lkeHRRewardOption.BOSSelectTypeValue = "";
            this.fld_lkeHRRewardOption.CurrentDisplayText = null;
            this.fld_lkeHRRewardOption.Location = new System.Drawing.Point(451, 104);
            this.fld_lkeHRRewardOption.Name = "fld_lkeHRRewardOption";
            this.fld_lkeHRRewardOption.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRRewardOption.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRRewardOption.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRRewardOption.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRRewardOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRRewardOption.Properties.ColumnName = null;
            this.fld_lkeHRRewardOption.Properties.DisplayMember = "HRRewardOption";
            this.fld_lkeHRRewardOption.Properties.NullText = "";
            this.fld_lkeHRRewardOption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRRewardOption.Properties.ValueMember = "HRRewardOption";
            this.fld_lkeHRRewardOption.Screen = null;
            this.fld_lkeHRRewardOption.Size = new System.Drawing.Size(235, 20);
            this.fld_lkeHRRewardOption.TabIndex = 7;
            this.fld_lkeHRRewardOption.Tag = "DC";
            this.fld_lkeHRRewardOption.Validated += new System.EventHandler(this.fld_lkeHRRewardType_Validated);
            // 
            // fld_lkeHRRewardType
            // 
            this.fld_lkeHRRewardType.BOSAllowAddNew = false;
            this.fld_lkeHRRewardType.BOSAllowDummy = false;
            this.fld_lkeHRRewardType.BOSComment = "";
            this.fld_lkeHRRewardType.BOSDataMember = "HRRewardType";
            this.fld_lkeHRRewardType.BOSDataSource = "HRRewards";
            this.fld_lkeHRRewardType.BOSDescription = null;
            this.fld_lkeHRRewardType.BOSError = null;
            this.fld_lkeHRRewardType.BOSFieldGroup = "";
            this.fld_lkeHRRewardType.BOSFieldParent = "";
            this.fld_lkeHRRewardType.BOSFieldRelation = "";
            this.fld_lkeHRRewardType.BOSPrivilege = "";
            this.fld_lkeHRRewardType.BOSPropertyName = "EditValue";
            this.fld_lkeHRRewardType.BOSSelectType = "";
            this.fld_lkeHRRewardType.BOSSelectTypeValue = "";
            this.fld_lkeHRRewardType.CurrentDisplayText = null;
            this.fld_lkeHRRewardType.Location = new System.Drawing.Point(91, 104);
            this.fld_lkeHRRewardType.Name = "fld_lkeHRRewardType";
            this.fld_lkeHRRewardType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRRewardType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRRewardType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRRewardType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRRewardType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRRewardType.Properties.ColumnName = null;
            this.fld_lkeHRRewardType.Properties.DisplayMember = "HRRewardType";
            this.fld_lkeHRRewardType.Properties.NullText = "";
            this.fld_lkeHRRewardType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRRewardType.Properties.ValueMember = "HRRewardType";
            this.fld_lkeHRRewardType.Screen = null;
            this.fld_lkeHRRewardType.Size = new System.Drawing.Size(237, 20);
            this.fld_lkeHRRewardType.TabIndex = 6;
            this.fld_lkeHRRewardType.Tag = "DC";
            this.fld_lkeHRRewardType.Validated += new System.EventHandler(this.fld_lkeHRRewardType_Validated);
            // 
            // fld_txtHRRewardValue
            // 
            this.fld_txtHRRewardValue.BOSComment = "";
            this.fld_txtHRRewardValue.BOSDataMember = "HRRewardValue";
            this.fld_txtHRRewardValue.BOSDataSource = "HRRewards";
            this.fld_txtHRRewardValue.BOSDescription = null;
            this.fld_txtHRRewardValue.BOSError = null;
            this.fld_txtHRRewardValue.BOSFieldGroup = "";
            this.fld_txtHRRewardValue.BOSFieldRelation = "";
            this.fld_txtHRRewardValue.BOSPrivilege = "";
            this.fld_txtHRRewardValue.BOSPropertyName = "Text";
            this.fld_txtHRRewardValue.EditValue = "";
            this.fld_txtHRRewardValue.Location = new System.Drawing.Point(91, 130);
            this.fld_txtHRRewardValue.Name = "fld_txtHRRewardValue";
            this.fld_txtHRRewardValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRewardValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRewardValue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRewardValue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRewardValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRewardValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRewardValue.Screen = null;
            this.fld_txtHRRewardValue.Size = new System.Drawing.Size(595, 20);
            this.fld_txtHRRewardValue.TabIndex = 8;
            this.fld_txtHRRewardValue.Tag = "DC";
            this.fld_txtHRRewardValue.Validated += new System.EventHandler(this.fld_txtHRRewardValue_Validated);
            // 
            // DMHRRW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRRW100";
            this.Text = "Chi tiết khen thưởng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcEmployeeReward)).EndInit();
            this.fld_grcEmployeeReward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeRewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeRewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardNo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRewardDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRewardToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRewardOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRewardType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRewardValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcEmployeeReward;
        private BOSComponent.BOSButton fld_btnDelete;
        private BOSComponent.BOSButton fld_btnAdd;
        private HREmployeeRewardGridControl fld_dgcHREmployeeRewards;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeRewards;
        private BOSComponent.BOSLabel fld_lblHRRewardFromDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtHRRewardNo2;
        private BOSComponent.BOSTextBox fld_txtHRRewardName1;
        private BOSComponent.BOSMemoEdit fld_medHRRewardDesc;
        private BOSComponent.BOSDateEdit fld_dteHRRewardFromDate;
        private BOSComponent.BOSDateEdit fld_dteHRRewardToDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRRewardType;
        private BOSComponent.BOSTextBox fld_txtHRRewardValue;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRRewardOption;
	}
}
