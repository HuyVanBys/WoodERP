using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConversionProposal.UI
{
	/// <summary>
	/// Summary description for SMTS100
	/// </summary>
	partial class SMPCP100
    {
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel111;
		private BOSComponent.BOSDateEdit fld_dteSearchToICConversionProposalDate;
		private BOSComponent.BOSTextBox fld_txtICConversionProposalNo;
		private BOSSearchResultsGridControl fld_dgcICConversionProposals;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICTransfer;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICConversionProposalDate;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel fld_lblLabel1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMPCP100));
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToICConversionProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICConversionProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcICConversionProposals = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICTransfer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromICConversionProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICConversionProposalEmployeeRecever = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICConversionProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICConversionProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICConversionProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICConversionProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalEmployeeRecever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(38, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
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
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(38, 142);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel111
            // 
            this.fld_lblLabel111.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel111.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel111.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel111.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel111.BOSComment = "";
            this.fld_lblLabel111.BOSDataMember = "";
            this.fld_lblLabel111.BOSDataSource = "";
            this.fld_lblLabel111.BOSDescription = null;
            this.fld_lblLabel111.BOSError = null;
            this.fld_lblLabel111.BOSFieldGroup = "";
            this.fld_lblLabel111.BOSFieldRelation = "";
            this.fld_lblLabel111.BOSPrivilege = "";
            this.fld_lblLabel111.BOSPropertyName = null;
            this.fld_lblLabel111.Location = new System.Drawing.Point(284, 142);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel111.TabIndex = 29;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến ngày";
            // 
            // fld_dteSearchToICConversionProposalDate
            // 
            this.fld_dteSearchToICConversionProposalDate.BOSComment = "";
            this.fld_dteSearchToICConversionProposalDate.BOSDataMember = "ICConversionProposalDateTo";
            this.fld_dteSearchToICConversionProposalDate.BOSDataSource = "ICConversionProposals";
            this.fld_dteSearchToICConversionProposalDate.BOSDescription = null;
            this.fld_dteSearchToICConversionProposalDate.BOSError = "";
            this.fld_dteSearchToICConversionProposalDate.BOSFieldGroup = "";
            this.fld_dteSearchToICConversionProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchToICConversionProposalDate.BOSPrivilege = "";
            this.fld_dteSearchToICConversionProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICConversionProposalDate.EditValue = null;
            this.fld_dteSearchToICConversionProposalDate.Location = new System.Drawing.Point(351, 139);
            this.fld_dteSearchToICConversionProposalDate.Name = "fld_dteSearchToICConversionProposalDate";
            this.fld_dteSearchToICConversionProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICConversionProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICConversionProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICConversionProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICConversionProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICConversionProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICConversionProposalDate.Screen = null;
            this.fld_dteSearchToICConversionProposalDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchToICConversionProposalDate.TabIndex = 8;
            this.fld_dteSearchToICConversionProposalDate.Tag = "SC";
            // 
            // fld_txtICConversionProposalNo
            // 
            this.fld_txtICConversionProposalNo.BOSComment = "";
            this.fld_txtICConversionProposalNo.BOSDataMember = "ICConversionProposalNo";
            this.fld_txtICConversionProposalNo.BOSDataSource = "ICConversionProposals";
            this.fld_txtICConversionProposalNo.BOSDescription = null;
            this.fld_txtICConversionProposalNo.BOSError = "";
            this.fld_txtICConversionProposalNo.BOSFieldGroup = "";
            this.fld_txtICConversionProposalNo.BOSFieldRelation = "";
            this.fld_txtICConversionProposalNo.BOSPrivilege = "";
            this.fld_txtICConversionProposalNo.BOSPropertyName = "Text";
            this.fld_txtICConversionProposalNo.Location = new System.Drawing.Point(120, 9);
            this.fld_txtICConversionProposalNo.Name = "fld_txtICConversionProposalNo";
            this.fld_txtICConversionProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICConversionProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICConversionProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICConversionProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICConversionProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICConversionProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICConversionProposalNo.Screen = null;
            this.fld_txtICConversionProposalNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICConversionProposalNo.TabIndex = 0;
            this.fld_txtICConversionProposalNo.Tag = "SC";
            // 
            // fld_dgcICConversionProposals
            // 
            this.fld_dgcICConversionProposals.AllowDrop = true;
            this.fld_dgcICConversionProposals.BOSComment = "";
            this.fld_dgcICConversionProposals.BOSDataMember = null;
            this.fld_dgcICConversionProposals.BOSDataSource = "ICConversionProposals";
            this.fld_dgcICConversionProposals.BOSDescription = null;
            this.fld_dgcICConversionProposals.BOSError = "";
            this.fld_dgcICConversionProposals.BOSFieldGroup = "";
            this.fld_dgcICConversionProposals.BOSFieldRelation = null;
            this.fld_dgcICConversionProposals.BOSGridType = null;
            this.fld_dgcICConversionProposals.BOSPrivilege = "";
            this.fld_dgcICConversionProposals.BOSPropertyName = null;
            this.fld_dgcICConversionProposals.CommodityType = "";
            this.fld_dgcICConversionProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICConversionProposals.Location = new System.Drawing.Point(38, 165);
            this.fld_dgcICConversionProposals.MainView = this.fld_dgvICTransfer;
            this.fld_dgcICConversionProposals.Name = "fld_dgcICConversionProposals";
            this.fld_dgcICConversionProposals.PrintReport = false;
            this.fld_dgcICConversionProposals.Screen = null;
            this.fld_dgcICConversionProposals.Size = new System.Drawing.Size(576, 407);
            this.fld_dgcICConversionProposals.TabIndex = 8;
            this.fld_dgcICConversionProposals.Tag = "SR";
            this.fld_dgcICConversionProposals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICTransfer});
            // 
            // fld_dgvICTransfer
            // 
            this.fld_dgvICTransfer.GridControl = this.fld_dgcICConversionProposals;
            this.fld_dgvICTransfer.Name = "fld_dgvICTransfer";
            this.fld_dgvICTransfer.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromICConversionProposalDate
            // 
            this.fld_dteSearchFromICConversionProposalDate.BOSComment = "";
            this.fld_dteSearchFromICConversionProposalDate.BOSDataMember = "ICConversionProposalDateFrom";
            this.fld_dteSearchFromICConversionProposalDate.BOSDataSource = "ICConversionProposals";
            this.fld_dteSearchFromICConversionProposalDate.BOSDescription = null;
            this.fld_dteSearchFromICConversionProposalDate.BOSError = "";
            this.fld_dteSearchFromICConversionProposalDate.BOSFieldGroup = "";
            this.fld_dteSearchFromICConversionProposalDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICConversionProposalDate.BOSPrivilege = "";
            this.fld_dteSearchFromICConversionProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICConversionProposalDate.EditValue = null;
            this.fld_dteSearchFromICConversionProposalDate.Location = new System.Drawing.Point(120, 139);
            this.fld_dteSearchFromICConversionProposalDate.Name = "fld_dteSearchFromICConversionProposalDate";
            this.fld_dteSearchFromICConversionProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICConversionProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICConversionProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICConversionProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICConversionProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICConversionProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICConversionProposalDate.Screen = null;
            this.fld_dteSearchFromICConversionProposalDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchFromICConversionProposalDate.TabIndex = 7;
            this.fld_dteSearchFromICConversionProposalDate.Tag = "SC";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = true;
            this.fld_lkeFK_ICStockID.BOSComment = "";
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = "";
            this.fld_lkeFK_ICStockID.BOSFieldGroup = "";
            this.fld_lkeFK_ICStockID.BOSFieldParent = "";
            this.fld_lkeFK_ICStockID.BOSFieldRelation = "";
            this.fld_lkeFK_ICStockID.BOSPrivilege = "";
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = "";
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICStockID.CurrentDisplayText = "";
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(120, 113);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 5;
            this.fld_lkeFK_ICStockID.Tag = "SC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(38, 116);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(18, 13);
            this.fld_lblLabel1.TabIndex = 95;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Kho";
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
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(38, 64);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel6.TabIndex = 4;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(120, 61);
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(38, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(55, 13);
            this.bosLabel2.TabIndex = 95;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Người nhận";
            // 
            // fld_txtICConversionProposalEmployeeRecever
            // 
            this.fld_txtICConversionProposalEmployeeRecever.BOSComment = "";
            this.fld_txtICConversionProposalEmployeeRecever.BOSDataMember = "ICConversionProposalEmployeeRecever";
            this.fld_txtICConversionProposalEmployeeRecever.BOSDataSource = "ICConversionProposals";
            this.fld_txtICConversionProposalEmployeeRecever.BOSDescription = null;
            this.fld_txtICConversionProposalEmployeeRecever.BOSError = "";
            this.fld_txtICConversionProposalEmployeeRecever.BOSFieldGroup = "";
            this.fld_txtICConversionProposalEmployeeRecever.BOSFieldRelation = "";
            this.fld_txtICConversionProposalEmployeeRecever.BOSPrivilege = "";
            this.fld_txtICConversionProposalEmployeeRecever.BOSPropertyName = "Text";
            this.fld_txtICConversionProposalEmployeeRecever.Location = new System.Drawing.Point(120, 35);
            this.fld_txtICConversionProposalEmployeeRecever.Name = "fld_txtICConversionProposalEmployeeRecever";
            this.fld_txtICConversionProposalEmployeeRecever.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICConversionProposalEmployeeRecever.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICConversionProposalEmployeeRecever.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICConversionProposalEmployeeRecever.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICConversionProposalEmployeeRecever.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICConversionProposalEmployeeRecever.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICConversionProposalEmployeeRecever.Screen = null;
            this.fld_txtICConversionProposalEmployeeRecever.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICConversionProposalEmployeeRecever.TabIndex = 1;
            this.fld_txtICConversionProposalEmployeeRecever.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel3.Location = new System.Drawing.Point(38, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 99;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICConversionProposals";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(120, 87);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMPCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(693, 574);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_txtICConversionProposalEmployeeRecever);
            this.Controls.Add(this.fld_txtICConversionProposalNo);
            this.Controls.Add(this.fld_dgcICConversionProposals);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchToICConversionProposalDate);
            this.Controls.Add(this.fld_dteSearchFromICConversionProposalDate);
            this.Controls.Add(this.fld_lkeFK_ICStockID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMPCP100.IconOptions.Icon")));
            this.Name = "SMPCP100";
            this.Text = "Tim kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICStockID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICConversionProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICConversionProposalDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.fld_dgcICConversionProposals, 0);
            this.Controls.SetChildIndex(this.fld_txtICConversionProposalNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICConversionProposalEmployeeRecever, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICConversionProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICConversionProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICConversionProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICConversionProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalEmployeeRecever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICConversionProposalEmployeeRecever;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
