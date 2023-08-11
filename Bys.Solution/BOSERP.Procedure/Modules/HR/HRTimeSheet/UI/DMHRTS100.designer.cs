using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTimeSheet.UI
{
	/// <summary>
	/// Summary description for DMHRTS100
	/// </summary>
	partial class DMHRTS100
    {
		private BOSComponent.BOSTextBox fld_txtHRTimeSheetNo1;
		private BOSComponent.BOSTextBox fld_txtHRTimeSheetName1;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetDate1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSButton fld_btnAddEmployee;
        private HREmployeeTimeSheetsGridControl fld_dgcHREmployeeTimeSheets;


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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.fld_txtHRTimeSheetNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRTimeSheetName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRTimeSheetDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeTimeSheets = new BOSERP.Modules.HRTimeSheet.HREmployeeTimeSheetsGridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeHRTimeSheetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRTimeSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTimeSheetType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddFromFile = new BOSComponent.BOSButton(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTimeSheets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRTimeSheetNo1
            // 
            this.fld_txtHRTimeSheetNo1.BOSComment = "";
            this.fld_txtHRTimeSheetNo1.BOSDataMember = "HRTimeSheetNo";
            this.fld_txtHRTimeSheetNo1.BOSDataSource = "HRTimeSheets";
            this.fld_txtHRTimeSheetNo1.BOSDescription = null;
            this.fld_txtHRTimeSheetNo1.BOSError = null;
            this.fld_txtHRTimeSheetNo1.BOSFieldGroup = "";
            this.fld_txtHRTimeSheetNo1.BOSFieldRelation = "";
            this.fld_txtHRTimeSheetNo1.BOSPrivilege = "";
            this.fld_txtHRTimeSheetNo1.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetNo1.EditValue = "";
            this.fld_txtHRTimeSheetNo1.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRTimeSheetNo1.Name = "fld_txtHRTimeSheetNo1";
            this.fld_txtHRTimeSheetNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetNo1.Screen = null;
            this.fld_txtHRTimeSheetNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRTimeSheetNo1.TabIndex = 0;
            this.fld_txtHRTimeSheetNo1.Tag = "DC";
            // 
            // fld_txtHRTimeSheetName1
            // 
            this.fld_txtHRTimeSheetName1.BOSComment = "";
            this.fld_txtHRTimeSheetName1.BOSDataMember = "HRTimeSheetName";
            this.fld_txtHRTimeSheetName1.BOSDataSource = "HRTimeSheets";
            this.fld_txtHRTimeSheetName1.BOSDescription = null;
            this.fld_txtHRTimeSheetName1.BOSError = null;
            this.fld_txtHRTimeSheetName1.BOSFieldGroup = "";
            this.fld_txtHRTimeSheetName1.BOSFieldRelation = "";
            this.fld_txtHRTimeSheetName1.BOSPrivilege = "";
            this.fld_txtHRTimeSheetName1.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetName1.EditValue = "";
            this.fld_txtHRTimeSheetName1.Location = new System.Drawing.Point(203, 35);
            this.fld_txtHRTimeSheetName1.Name = "fld_txtHRTimeSheetName1";
            this.fld_txtHRTimeSheetName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetName1.Screen = null;
            this.fld_txtHRTimeSheetName1.Size = new System.Drawing.Size(551, 20);
            this.fld_txtHRTimeSheetName1.TabIndex = 2;
            this.fld_txtHRTimeSheetName1.Tag = "DC";
            // 
            // fld_dteHRTimeSheetDate1
            // 
            this.fld_dteHRTimeSheetDate1.BOSComment = "";
            this.fld_dteHRTimeSheetDate1.BOSDataMember = "HRTimeSheetDate";
            this.fld_dteHRTimeSheetDate1.BOSDataSource = "HRTimeSheets";
            this.fld_dteHRTimeSheetDate1.BOSDescription = null;
            this.fld_dteHRTimeSheetDate1.BOSError = null;
            this.fld_dteHRTimeSheetDate1.BOSFieldGroup = "";
            this.fld_dteHRTimeSheetDate1.BOSFieldRelation = "";
            this.fld_dteHRTimeSheetDate1.BOSPrivilege = "";
            this.fld_dteHRTimeSheetDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetDate1.EditValue = null;
            this.fld_dteHRTimeSheetDate1.Location = new System.Drawing.Point(203, 61);
            this.fld_dteHRTimeSheetDate1.Name = "fld_dteHRTimeSheetDate1";
            this.fld_dteHRTimeSheetDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetDate1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetDate1.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetDate1.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRTimeSheetDate1.Screen = null;
            this.fld_dteHRTimeSheetDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTimeSheetDate1.TabIndex = 3;
            this.fld_dteHRTimeSheetDate1.Tag = "DC";
            this.fld_dteHRTimeSheetDate1.Validated += new System.EventHandler(this.fld_dteHRTimeSheetDate1_Validated_1);
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
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeTimeSheets);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(6, 163);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(971, 552);
            this.fld_grcGroupControl1.TabIndex = 13;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHREmployeeTimeSheets
            // 
            this.fld_dgcHREmployeeTimeSheets.AllowDrop = true;
            this.fld_dgcHREmployeeTimeSheets.BOSComment = "";
            this.fld_dgcHREmployeeTimeSheets.BOSDataMember = "";
            this.fld_dgcHREmployeeTimeSheets.BOSDataSource = "HREmployeeTimeSheets";
            this.fld_dgcHREmployeeTimeSheets.BOSDescription = null;
            this.fld_dgcHREmployeeTimeSheets.BOSError = null;
            this.fld_dgcHREmployeeTimeSheets.BOSFieldGroup = "";
            this.fld_dgcHREmployeeTimeSheets.BOSFieldRelation = "";
            this.fld_dgcHREmployeeTimeSheets.BOSGridType = null;
            this.fld_dgcHREmployeeTimeSheets.BOSPrivilege = "";
            this.fld_dgcHREmployeeTimeSheets.BOSPropertyName = "";
            this.fld_dgcHREmployeeTimeSheets.CommodityType = "";
            this.fld_dgcHREmployeeTimeSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeTimeSheets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeTimeSheets.GridViewMain = null;
            gridLevelNode1.RelationName = "Level1";
            this.fld_dgcHREmployeeTimeSheets.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.fld_dgcHREmployeeTimeSheets.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcHREmployeeTimeSheets.Name = "fld_dgcHREmployeeTimeSheets";
            this.fld_dgcHREmployeeTimeSheets.OTFactorlist = null;
            this.fld_dgcHREmployeeTimeSheets.PrintReport = false;
            this.fld_dgcHREmployeeTimeSheets.RowHandle = 0;
            this.fld_dgcHREmployeeTimeSheets.Screen = null;
            this.fld_dgcHREmployeeTimeSheets.Size = new System.Drawing.Size(967, 530);
            this.fld_dgcHREmployeeTimeSheets.TabIndex = 0;
            this.fld_dgcHREmployeeTimeSheets.Tag = "";
            this.fld_dgcHREmployeeTimeSheets.ToolTipText = null;
            this.fld_dgcHREmployeeTimeSheets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.GridControl = this.fld_dgcHREmployeeTimeSheets;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = "";
            this.fld_btnAddEmployee.BOSDataMember = "";
            this.fld_btnAddEmployee.BOSDataSource = "";
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = "";
            this.fld_btnAddEmployee.BOSFieldRelation = "";
            this.fld_btnAddEmployee.BOSPrivilege = "";
            this.fld_btnAddEmployee.BOSPropertyName = "";
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(6, 717);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 15;
            this.fld_btnAddEmployee.Tag = "";
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosPanel1.Controls.Add(this.fld_btnExportExcel);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.fld_btnAddFromFile);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(982, 748);
            this.bosPanel1.TabIndex = 17;
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
            this.bosPanel2.Controls.Add(this.fld_lkeHRTimeSheetStatus);
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.bosDateEdit2);
            this.bosPanel2.Controls.Add(this.bosDateEdit1);
            this.bosPanel2.Controls.Add(this.fld_dteHRTimeSheetDate1);
            this.bosPanel2.Controls.Add(this.fld_txtHRTimeSheetName1);
            this.bosPanel2.Controls.Add(this.fld_txtHRTimeSheetNo1);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_lkeHRTimeSheetType);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(982, 157);
            this.bosPanel2.TabIndex = 17;
            // 
            // fld_lkeHRTimeSheetStatus
            // 
            this.fld_lkeHRTimeSheetStatus.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetStatus.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetStatus.BOSComment = null;
            this.fld_lkeHRTimeSheetStatus.BOSDataMember = "HRTimeSheetStatus";
            this.fld_lkeHRTimeSheetStatus.BOSDataSource = "HRTimeSheets";
            this.fld_lkeHRTimeSheetStatus.BOSDescription = null;
            this.fld_lkeHRTimeSheetStatus.BOSError = null;
            this.fld_lkeHRTimeSheetStatus.BOSFieldGroup = null;
            this.fld_lkeHRTimeSheetStatus.BOSFieldParent = null;
            this.fld_lkeHRTimeSheetStatus.BOSFieldRelation = null;
            this.fld_lkeHRTimeSheetStatus.BOSPrivilege = null;
            this.fld_lkeHRTimeSheetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetStatus.BOSSelectType = null;
            this.fld_lkeHRTimeSheetStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRTimeSheetStatus.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetStatus.Location = new System.Drawing.Point(604, 61);
            this.fld_lkeHRTimeSheetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRTimeSheetStatus.Name = "fld_lkeHRTimeSheetStatus";
            this.fld_lkeHRTimeSheetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetStatus.Properties.ColumnName = null;
            this.fld_lkeHRTimeSheetStatus.Properties.ReadOnly = true;
            this.fld_lkeHRTimeSheetStatus.Screen = null;
            this.fld_lkeHRTimeSheetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTimeSheetStatus.TabIndex = 4;
            this.fld_lkeHRTimeSheetStatus.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "HRTimeSheetDesc";
            this.bosMemoEdit1.BOSDataSource = "HRTimeSheets";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(203, 113);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(551, 35);
            this.bosMemoEdit1.TabIndex = 7;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = "";
            this.bosDateEdit2.BOSDataMember = "HRTimeSheetToDate";
            this.bosDateEdit2.BOSDataSource = "HRTimeSheets";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = "";
            this.bosDateEdit2.BOSFieldRelation = "";
            this.bosDateEdit2.BOSPrivilege = "";
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(604, 87);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bosDateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit2.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.bosDateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit2.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 6;
            this.bosDateEdit2.Tag = "DC";
            this.bosDateEdit2.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.bosDateEdit2_EditValueChanging);
            this.bosDateEdit2.Validated += new System.EventHandler(this.fld_dteHRTimeSheetDate1_Validated);
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = "";
            this.bosDateEdit1.BOSDataMember = "HRTimeSheetFromDate";
            this.bosDateEdit1.BOSDataSource = "HRTimeSheets";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = "";
            this.bosDateEdit1.BOSFieldRelation = "";
            this.bosDateEdit1.BOSPrivilege = "";
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(203, 87);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.bosDateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.bosDateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bosDateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 5;
            this.bosDateEdit1.Tag = "DC";
            this.bosDateEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.bosDateEdit1_EditValueChanging);
            this.bosDateEdit1.Validated += new System.EventHandler(this.fld_dteHRTimeSheetDate1_Validated);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(519, 90);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 5;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRTimeSheets";
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
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(120, 90);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 5;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_pteHRTimeSheetEmployeePicture
            // 
            this.fld_pteHRTimeSheetEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataMember = "HRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataSource = "HRTimeSheets";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteHRTimeSheetEmployeePicture.FileName = null;
            this.fld_pteHRTimeSheetEmployeePicture.FilePath = null;
            this.fld_pteHRTimeSheetEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetEmployeePicture.Name = "fld_pteHRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRTimeSheetEmployeePicture.TabIndex = 0;
            this.fld_pteHRTimeSheetEmployeePicture.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(120, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(30, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tháng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(519, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tình trạng";
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
            this.bosLabel2.Location = new System.Drawing.Point(519, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại bảng công";
            // 
            // fld_lkeHRTimeSheetType
            // 
            this.fld_lkeHRTimeSheetType.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetType.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetType.BOSComment = "";
            this.fld_lkeHRTimeSheetType.BOSDataMember = "HRTimeSheetType";
            this.fld_lkeHRTimeSheetType.BOSDataSource = "HRTimeSheets";
            this.fld_lkeHRTimeSheetType.BOSDescription = null;
            this.fld_lkeHRTimeSheetType.BOSError = null;
            this.fld_lkeHRTimeSheetType.BOSFieldGroup = "NonEditable";
            this.fld_lkeHRTimeSheetType.BOSFieldParent = "";
            this.fld_lkeHRTimeSheetType.BOSFieldRelation = "";
            this.fld_lkeHRTimeSheetType.BOSPrivilege = "";
            this.fld_lkeHRTimeSheetType.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetType.BOSSelectType = "";
            this.fld_lkeHRTimeSheetType.BOSSelectTypeValue = "";
            this.fld_lkeHRTimeSheetType.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetType.Location = new System.Drawing.Point(604, 9);
            this.fld_lkeHRTimeSheetType.Name = "fld_lkeHRTimeSheetType";
            this.fld_lkeHRTimeSheetType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRTimeSheetType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRTimeSheetType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRTimeSheetType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRTimeSheetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetType.Properties.ColumnName = null;
            this.fld_lkeHRTimeSheetType.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeHRTimeSheetType.Properties.NullText = "";
            this.fld_lkeHRTimeSheetType.Properties.PopupWidth = 40;
            this.fld_lkeHRTimeSheetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRTimeSheetType.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeHRTimeSheetType.Screen = null;
            this.fld_lkeHRTimeSheetType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTimeSheetType.TabIndex = 1;
            this.fld_lkeHRTimeSheetType.Tag = "DC";
            this.fld_lkeHRTimeSheetType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRTimeSheetType_CloseUp);
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã bảng công";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Tên bảng công";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(120, 113);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_btnAddFromFile
            // 
            this.fld_btnAddFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddFromFile.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddFromFile.Appearance.Options.UseForeColor = true;
            this.fld_btnAddFromFile.BOSComment = "";
            this.fld_btnAddFromFile.BOSDataMember = "";
            this.fld_btnAddFromFile.BOSDataSource = "";
            this.fld_btnAddFromFile.BOSDescription = null;
            this.fld_btnAddFromFile.BOSError = null;
            this.fld_btnAddFromFile.BOSFieldGroup = "";
            this.fld_btnAddFromFile.BOSFieldRelation = "";
            this.fld_btnAddFromFile.BOSPrivilege = "";
            this.fld_btnAddFromFile.BOSPropertyName = "";
            this.fld_btnAddFromFile.Location = new System.Drawing.Point(112, 717);
            this.fld_btnAddFromFile.Name = "fld_btnAddFromFile";
            this.fld_btnAddFromFile.Screen = null;
            this.fld_btnAddFromFile.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddFromFile.TabIndex = 15;
            this.fld_btnAddFromFile.Tag = "";
            this.fld_btnAddFromFile.Text = "Thêm từ file";
            this.fld_btnAddFromFile.Click += new System.EventHandler(this.fld_btnAddFromFile_Click);
            // 
            // fld_btnExportExcel
            // 
            this.fld_btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnExportExcel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnExportExcel.Appearance.Options.UseForeColor = true;
            this.fld_btnExportExcel.BOSComment = "";
            this.fld_btnExportExcel.BOSDataMember = "";
            this.fld_btnExportExcel.BOSDataSource = "";
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = "";
            this.fld_btnExportExcel.BOSFieldRelation = "";
            this.fld_btnExportExcel.BOSPrivilege = "";
            this.fld_btnExportExcel.BOSPropertyName = "";
            this.fld_btnExportExcel.Location = new System.Drawing.Point(218, 717);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(100, 27);
            this.fld_btnExportExcel.TabIndex = 18;
            this.fld_btnExportExcel.Tag = "";
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // DMHRTS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(982, 748);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTS100";
            this.Text = "Quản lý chấm công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTimeSheets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetType;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSButton fld_btnAddFromFile;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private ToolTip toolTip1;
        private BOSComponent.BOSButton fld_btnExportExcel;
    }
}
