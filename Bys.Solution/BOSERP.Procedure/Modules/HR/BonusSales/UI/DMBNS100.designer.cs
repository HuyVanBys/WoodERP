using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BonusSales.UI
{
	/// <summary>
	/// Summary description for DMBNS100
	/// </summary>
	partial class DMBNS100
    {
        private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSDateEdit fld_dteHRBonusSaleDate1;
		private BOSComponent.BOSTextBox fld_txtHRBonusSaleNo1;
		private BOSComponent.BOSTextBox fld_txtHRBonusSaleName1;
        private BOSComponent.BOSMemoEdit fld_medHRBonusSaleDesc;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePayRolls;


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
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRBonusSaleDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRBonusSaleNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRBonusSaleName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRBonusSaleDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgvHREmployeePayRolls = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRBonusSaleItems = new BOSERP.Modules.BonusSales.HRBonusSaleItemsGridControl();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRBonusSaleToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRBonusSaleFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRBonusSaleStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRTimeSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRBonusSaleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBonusSaleItems)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBonusSaleStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = string.Empty;
            this.fld_lblLabel9.BOSDataMember = string.Empty;
            this.fld_lblLabel9.BOSDataSource = string.Empty;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = string.Empty;
            this.fld_lblLabel9.BOSFieldRelation = string.Empty;
            this.fld_lblLabel9.BOSPrivilege = string.Empty;
            this.fld_lblLabel9.BOSPropertyName = string.Empty;
            this.fld_lblLabel9.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = string.Empty;
            this.fld_lblLabel9.Text = "Tháng";
            // 
            // fld_dteHRBonusSaleDate1
            // 
            this.fld_dteHRBonusSaleDate1.BOSComment = string.Empty;
            this.fld_dteHRBonusSaleDate1.BOSDataMember = "HRBonusSaleDate";
            this.fld_dteHRBonusSaleDate1.BOSDataSource = "HRBonusSales";
            this.fld_dteHRBonusSaleDate1.BOSDescription = null;
            this.fld_dteHRBonusSaleDate1.BOSError = null;
            this.fld_dteHRBonusSaleDate1.BOSFieldGroup = string.Empty;
            this.fld_dteHRBonusSaleDate1.BOSFieldRelation = string.Empty;
            this.fld_dteHRBonusSaleDate1.BOSPrivilege = string.Empty;
            this.fld_dteHRBonusSaleDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRBonusSaleDate1.EditValue = null;
            this.fld_dteHRBonusSaleDate1.Location = new System.Drawing.Point(203, 35);
            this.fld_dteHRBonusSaleDate1.Name = "fld_dteHRBonusSaleDate1";
            this.fld_dteHRBonusSaleDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRBonusSaleDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRBonusSaleDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRBonusSaleDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRBonusSaleDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRBonusSaleDate1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRBonusSaleDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleDate1.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRBonusSaleDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleDate1.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRBonusSaleDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRBonusSaleDate1.Screen = null;
            this.fld_dteHRBonusSaleDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRBonusSaleDate1.TabIndex = 2;
            this.fld_dteHRBonusSaleDate1.Tag = "DC";
            this.fld_dteHRBonusSaleDate1.Validated += new System.EventHandler(this.fld_dteHRBonusSaleDate1_Validated);
            // 
            // fld_txtHRBonusSaleNo1
            // 
            this.fld_txtHRBonusSaleNo1.BOSComment = string.Empty;
            this.fld_txtHRBonusSaleNo1.BOSDataMember = "HRBonusSaleNo";
            this.fld_txtHRBonusSaleNo1.BOSDataSource = "HRBonusSales";
            this.fld_txtHRBonusSaleNo1.BOSDescription = null;
            this.fld_txtHRBonusSaleNo1.BOSError = null;
            this.fld_txtHRBonusSaleNo1.BOSFieldGroup = string.Empty;
            this.fld_txtHRBonusSaleNo1.BOSFieldRelation = string.Empty;
            this.fld_txtHRBonusSaleNo1.BOSPrivilege = string.Empty;
            this.fld_txtHRBonusSaleNo1.BOSPropertyName = "Text";
            this.fld_txtHRBonusSaleNo1.EditValue = string.Empty;
            this.fld_txtHRBonusSaleNo1.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRBonusSaleNo1.Name = "fld_txtHRBonusSaleNo1";
            this.fld_txtHRBonusSaleNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBonusSaleNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBonusSaleNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBonusSaleNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBonusSaleNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBonusSaleNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBonusSaleNo1.Screen = null;
            this.fld_txtHRBonusSaleNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRBonusSaleNo1.TabIndex = 0;
            this.fld_txtHRBonusSaleNo1.Tag = "DC";
            // 
            // fld_txtHRBonusSaleName1
            // 
            this.fld_txtHRBonusSaleName1.BOSComment = string.Empty;
            this.fld_txtHRBonusSaleName1.BOSDataMember = "HRBonusSaleName";
            this.fld_txtHRBonusSaleName1.BOSDataSource = "HRBonusSales";
            this.fld_txtHRBonusSaleName1.BOSDescription = null;
            this.fld_txtHRBonusSaleName1.BOSError = null;
            this.fld_txtHRBonusSaleName1.BOSFieldGroup = string.Empty;
            this.fld_txtHRBonusSaleName1.BOSFieldRelation = string.Empty;
            this.fld_txtHRBonusSaleName1.BOSPrivilege = string.Empty;
            this.fld_txtHRBonusSaleName1.BOSPropertyName = "Text";
            this.fld_txtHRBonusSaleName1.EditValue = string.Empty;
            this.fld_txtHRBonusSaleName1.Location = new System.Drawing.Point(471, 9);
            this.fld_txtHRBonusSaleName1.Name = "fld_txtHRBonusSaleName1";
            this.fld_txtHRBonusSaleName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBonusSaleName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBonusSaleName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBonusSaleName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBonusSaleName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBonusSaleName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBonusSaleName1.Screen = null;
            this.fld_txtHRBonusSaleName1.Size = new System.Drawing.Size(387, 20);
            this.fld_txtHRBonusSaleName1.TabIndex = 1;
            this.fld_txtHRBonusSaleName1.Tag = "DC";
            // 
            // fld_medHRBonusSaleDesc
            // 
            this.fld_medHRBonusSaleDesc.BOSComment = string.Empty;
            this.fld_medHRBonusSaleDesc.BOSDataMember = "HRBonusSaleDesc";
            this.fld_medHRBonusSaleDesc.BOSDataSource = "HRBonusSales";
            this.fld_medHRBonusSaleDesc.BOSDescription = null;
            this.fld_medHRBonusSaleDesc.BOSError = null;
            this.fld_medHRBonusSaleDesc.BOSFieldGroup = string.Empty;
            this.fld_medHRBonusSaleDesc.BOSFieldRelation = string.Empty;
            this.fld_medHRBonusSaleDesc.BOSPrivilege = string.Empty;
            this.fld_medHRBonusSaleDesc.BOSPropertyName = "Text";
            this.fld_medHRBonusSaleDesc.EditValue = string.Empty;
            this.fld_medHRBonusSaleDesc.Location = new System.Drawing.Point(203, 87);
            this.fld_medHRBonusSaleDesc.Name = "fld_medHRBonusSaleDesc";
            this.fld_medHRBonusSaleDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRBonusSaleDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRBonusSaleDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRBonusSaleDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRBonusSaleDesc.Screen = null;
            this.fld_medHRBonusSaleDesc.Size = new System.Drawing.Size(655, 38);
            this.fld_medHRBonusSaleDesc.TabIndex = 5;
            this.fld_medHRBonusSaleDesc.Tag = "DC";
            // 
            // fld_dgvHREmployeePayRolls
            // 
            this.fld_dgvHREmployeePayRolls.Name = "fld_dgvHREmployeePayRolls";
            this.fld_dgvHREmployeePayRolls.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(934, 711);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = string.Empty;
            this.fld_grcGroupControl1.BOSDataMember = string.Empty;
            this.fld_grcGroupControl1.BOSDataSource = string.Empty;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl1.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl1.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl1.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRBonusSaleItems);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(3, 140);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(928, 568);
            this.fld_grcGroupControl1.TabIndex = 19;
            this.fld_grcGroupControl1.Tag = string.Empty;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHRBonusSaleItems
            // 
            this.fld_dgcHRBonusSaleItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRBonusSaleItems.BOSComment = null;
            this.fld_dgcHRBonusSaleItems.BOSDataMember = null;
            this.fld_dgcHRBonusSaleItems.BOSDataSource = "HRBonusSaleItems";
            this.fld_dgcHRBonusSaleItems.BOSDescription = null;
            this.fld_dgcHRBonusSaleItems.BOSError = null;
            this.fld_dgcHRBonusSaleItems.BOSFieldGroup = null;
            this.fld_dgcHRBonusSaleItems.BOSFieldRelation = null;
            this.fld_dgcHRBonusSaleItems.BOSGridType = null;
            this.fld_dgcHRBonusSaleItems.BOSPrivilege = null;
            this.fld_dgcHRBonusSaleItems.BOSPropertyName = null;
            this.fld_dgcHRBonusSaleItems.GridViewMain = null;
            this.fld_dgcHRBonusSaleItems.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRBonusSaleItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRBonusSaleItems.Name = "fld_dgcHRBonusSaleItems";
            this.fld_dgcHRBonusSaleItems.PrintReport = false;
            this.fld_dgcHRBonusSaleItems.Screen = null;
            this.fld_dgcHRBonusSaleItems.Size = new System.Drawing.Size(918, 501);
            this.fld_dgcHRBonusSaleItems.TabIndex = 1;
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = string.Empty;
            this.fld_btnAddEmployee.BOSDataMember = string.Empty;
            this.fld_btnAddEmployee.BOSDataSource = string.Empty;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = string.Empty;
            this.fld_btnAddEmployee.BOSFieldRelation = string.Empty;
            this.fld_btnAddEmployee.BOSPrivilege = string.Empty;
            this.fld_btnAddEmployee.BOSPropertyName = string.Empty;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(5, 532);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = string.Empty;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_dteHRBonusSaleToDate);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.fld_dteHRBonusSaleFromDate);
            this.bosPanel2.Controls.Add(this.fld_lkeHRBonusSaleStatus);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel9);
            this.bosPanel2.Controls.Add(this.fld_medHRBonusSaleDesc);
            this.bosPanel2.Controls.Add(this.fld_txtHRBonusSaleNo1);
            this.bosPanel2.Controls.Add(this.fld_dteHRBonusSaleDate1);
            this.bosPanel2.Controls.Add(this.fld_txtHRBonusSaleName1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(934, 134);
            this.bosPanel2.TabIndex = 18;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = string.Empty;
            this.bosLabel1.Location = new System.Drawing.Point(637, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 24;
            this.bosLabel1.Tag = string.Empty;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_dteHRBonusSaleToDate
            // 
            this.fld_dteHRBonusSaleToDate.BOSComment = string.Empty;
            this.fld_dteHRBonusSaleToDate.BOSDataMember = "HRBonusSaleToDate";
            this.fld_dteHRBonusSaleToDate.BOSDataSource = "HRBonusSales";
            this.fld_dteHRBonusSaleToDate.BOSDescription = null;
            this.fld_dteHRBonusSaleToDate.BOSError = null;
            this.fld_dteHRBonusSaleToDate.BOSFieldGroup = string.Empty;
            this.fld_dteHRBonusSaleToDate.BOSFieldRelation = string.Empty;
            this.fld_dteHRBonusSaleToDate.BOSPrivilege = string.Empty;
            this.fld_dteHRBonusSaleToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRBonusSaleToDate.EditValue = null;
            this.fld_dteHRBonusSaleToDate.Location = new System.Drawing.Point(708, 35);
            this.fld_dteHRBonusSaleToDate.Name = "fld_dteHRBonusSaleToDate";
            this.fld_dteHRBonusSaleToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRBonusSaleToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRBonusSaleToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRBonusSaleToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRBonusSaleToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRBonusSaleToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRBonusSaleToDate.Screen = null;
            this.fld_dteHRBonusSaleToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRBonusSaleToDate.TabIndex = 23;
            this.fld_dteHRBonusSaleToDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = string.Empty;
            this.bosLabel4.BOSDataMember = string.Empty;
            this.bosLabel4.BOSDataSource = string.Empty;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = string.Empty;
            this.bosLabel4.BOSFieldRelation = string.Empty;
            this.bosLabel4.BOSPrivilege = string.Empty;
            this.bosLabel4.BOSPropertyName = string.Empty;
            this.bosLabel4.Location = new System.Drawing.Point(375, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 22;
            this.bosLabel4.Tag = string.Empty;
            this.bosLabel4.Text = "Từ ngày";
            // 
            // fld_dteHRBonusSaleFromDate
            // 
            this.fld_dteHRBonusSaleFromDate.BOSComment = string.Empty;
            this.fld_dteHRBonusSaleFromDate.BOSDataMember = "HRBonusSaleFromDate";
            this.fld_dteHRBonusSaleFromDate.BOSDataSource = "HRBonusSales";
            this.fld_dteHRBonusSaleFromDate.BOSDescription = null;
            this.fld_dteHRBonusSaleFromDate.BOSError = null;
            this.fld_dteHRBonusSaleFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteHRBonusSaleFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteHRBonusSaleFromDate.BOSPrivilege = string.Empty;
            this.fld_dteHRBonusSaleFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRBonusSaleFromDate.EditValue = null;
            this.fld_dteHRBonusSaleFromDate.Location = new System.Drawing.Point(471, 35);
            this.fld_dteHRBonusSaleFromDate.Name = "fld_dteHRBonusSaleFromDate";
            this.fld_dteHRBonusSaleFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRBonusSaleFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRBonusSaleFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRBonusSaleFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRBonusSaleFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRBonusSaleFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRBonusSaleFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRBonusSaleFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRBonusSaleFromDate.Screen = null;
            this.fld_dteHRBonusSaleFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRBonusSaleFromDate.TabIndex = 21;
            this.fld_dteHRBonusSaleFromDate.Tag = "DC";
            // 
            // fld_lkeHRBonusSaleStatus
            // 
            this.fld_lkeHRBonusSaleStatus.BOSAllowAddNew = false;
            this.fld_lkeHRBonusSaleStatus.BOSAllowDummy = false;
            this.fld_lkeHRBonusSaleStatus.BOSComment = null;
            this.fld_lkeHRBonusSaleStatus.BOSDataMember = "HRBonusSaleStatus";
            this.fld_lkeHRBonusSaleStatus.BOSDataSource = "HRBonusSales";
            this.fld_lkeHRBonusSaleStatus.BOSDescription = null;
            this.fld_lkeHRBonusSaleStatus.BOSError = null;
            this.fld_lkeHRBonusSaleStatus.BOSFieldGroup = null;
            this.fld_lkeHRBonusSaleStatus.BOSFieldParent = null;
            this.fld_lkeHRBonusSaleStatus.BOSFieldRelation = null;
            this.fld_lkeHRBonusSaleStatus.BOSPrivilege = null;
            this.fld_lkeHRBonusSaleStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRBonusSaleStatus.BOSSelectType = null;
            this.fld_lkeHRBonusSaleStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRBonusSaleStatus.CurrentDisplayText = null;
            this.fld_lkeHRBonusSaleStatus.Location = new System.Drawing.Point(203, 61);
            this.fld_lkeHRBonusSaleStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRBonusSaleStatus.Name = "fld_lkeHRBonusSaleStatus";
            this.fld_lkeHRBonusSaleStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRBonusSaleStatus.Properties.ReadOnly = true;
            this.fld_lkeHRBonusSaleStatus.Screen = null;
            this.fld_lkeHRBonusSaleStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRBonusSaleStatus.TabIndex = 4;
            this.fld_lkeHRBonusSaleStatus.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRBonusSales";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteHRTimeSheetEmployeePicture
            // 
            this.fld_pteHRTimeSheetEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataMember = "HRPayRollEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataSource = "HRPayRolls";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetEmployeePicture.Name = "fld_pteHRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRTimeSheetEmployeePicture.TabIndex = 7;
            this.fld_pteHRTimeSheetEmployeePicture.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = string.Empty;
            this.bosLabel2.Location = new System.Drawing.Point(120, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(49, 13);
            this.bosLabel2.TabIndex = 5;
            this.bosLabel2.Tag = string.Empty;
            this.bosLabel2.Text = "Tình trạng";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = string.Empty;
            this.fld_lblLabel2.BOSDataMember = string.Empty;
            this.fld_lblLabel2.BOSDataSource = string.Empty;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = string.Empty;
            this.fld_lblLabel2.BOSFieldRelation = string.Empty;
            this.fld_lblLabel2.BOSPrivilege = string.Empty;
            this.fld_lblLabel2.BOSPropertyName = string.Empty;
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = string.Empty;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = string.Empty;
            this.fld_lblLabel4.BOSDataMember = string.Empty;
            this.fld_lblLabel4.BOSDataSource = string.Empty;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = string.Empty;
            this.fld_lblLabel4.BOSFieldRelation = string.Empty;
            this.fld_lblLabel4.BOSPrivilege = string.Empty;
            this.fld_lblLabel4.BOSPropertyName = string.Empty;
            this.fld_lblLabel4.Location = new System.Drawing.Point(375, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = string.Empty;
            this.fld_lblLabel4.Text = "Tên chứng từ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = string.Empty;
            this.bosLabel3.Location = new System.Drawing.Point(120, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMBNS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBNS100";
            this.Text = "Thông tin bảng lương";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBonusSaleName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRBonusSaleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBonusSaleItems)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRBonusSaleFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBonusSaleStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetEmployeePicture;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeHRBonusSaleStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteHRBonusSaleToDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteHRBonusSaleFromDate;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HRBonusSaleItemsGridControl fld_dgcHRBonusSaleItems;
	}
}
