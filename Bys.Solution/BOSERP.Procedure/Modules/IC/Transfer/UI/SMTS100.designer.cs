using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Transfer.UI
{
	/// <summary>
	/// Summary description for SMTS100
	/// </summary>
	partial class SMTS100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel111;
		private BOSComponent.BOSDateEdit fld_dteSearchToICTransferDate;
		private BOSComponent.BOSTextBox fld_txtICTransferNo1;
		private BOSSearchResultsGridControl fld_dgcICTransfer;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICTransfer;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICTransferDate;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID;
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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToICTransferDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICTransferNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcICTransfer = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICTransfer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromICTransferDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICFromStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICTransferType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICTransferReference = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICTransferDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICTransferDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICTransferDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICTransferDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(38, 168);
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
            this.fld_lblLabel111.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSDescription = null;
            this.fld_lblLabel111.BOSError = null;
            this.fld_lblLabel111.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel111.BOSPropertyName = null;
            this.fld_lblLabel111.Location = new System.Drawing.Point(284, 168);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel111.TabIndex = 29;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến ngày";
            // 
            // fld_dteSearchToICTransferDate
            // 
            this.fld_dteSearchToICTransferDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICTransferDate.BOSDataMember = "TransferDateTo";
            this.fld_dteSearchToICTransferDate.BOSDataSource = "ICTransfers";
            this.fld_dteSearchToICTransferDate.BOSDescription = null;
            this.fld_dteSearchToICTransferDate.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICTransferDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICTransferDate.BOSFieldRelation = null;
            this.fld_dteSearchToICTransferDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICTransferDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICTransferDate.EditValue = null;
            this.fld_dteSearchToICTransferDate.Location = new System.Drawing.Point(351, 165);
            this.fld_dteSearchToICTransferDate.Name = "fld_dteSearchToICTransferDate";
            this.fld_dteSearchToICTransferDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICTransferDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICTransferDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICTransferDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICTransferDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICTransferDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICTransferDate.Screen = null;
            this.fld_dteSearchToICTransferDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchToICTransferDate.TabIndex = 8;
            this.fld_dteSearchToICTransferDate.Tag = "SC";
            // 
            // fld_txtICTransferNo1
            // 
            this.fld_txtICTransferNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferNo1.BOSDataMember = "ICTransferNo";
            this.fld_txtICTransferNo1.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferNo1.BOSDescription = null;
            this.fld_txtICTransferNo1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferNo1.BOSPropertyName = "Text";
            this.fld_txtICTransferNo1.Location = new System.Drawing.Point(120, 9);
            this.fld_txtICTransferNo1.Name = "fld_txtICTransferNo1";
            this.fld_txtICTransferNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTransferNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTransferNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTransferNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTransferNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTransferNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTransferNo1.Screen = null;
            this.fld_txtICTransferNo1.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICTransferNo1.TabIndex = 0;
            this.fld_txtICTransferNo1.Tag = "SC";
            // 
            // fld_dgcICTransfer
            // 
            this.fld_dgcICTransfer.AllowDrop = true;
            this.fld_dgcICTransfer.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICTransfer.BOSDataMember = null;
            this.fld_dgcICTransfer.BOSDataSource = "ICTransfers";
            this.fld_dgcICTransfer.BOSDescription = null;
            this.fld_dgcICTransfer.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICTransfer.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICTransfer.BOSFieldRelation = null;
            this.fld_dgcICTransfer.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICTransfer.BOSPropertyName = null;
            this.fld_dgcICTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransfer.Location = new System.Drawing.Point(38, 217);
            this.fld_dgcICTransfer.MainView = this.fld_dgvICTransfer;
            this.fld_dgcICTransfer.Name = "fld_dgcICTransfer";
            this.fld_dgcICTransfer.Screen = null;
            this.fld_dgcICTransfer.Size = new System.Drawing.Size(576, 355);
            this.fld_dgcICTransfer.TabIndex = 8;
            this.fld_dgcICTransfer.Tag = "SR";
            this.fld_dgcICTransfer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICTransfer});
            // 
            // fld_dgvICTransfer
            // 
            this.fld_dgvICTransfer.GridControl = this.fld_dgcICTransfer;
            this.fld_dgvICTransfer.Name = "fld_dgvICTransfer";
            this.fld_dgvICTransfer.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromICTransferDate
            // 
            this.fld_dteSearchFromICTransferDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICTransferDate.BOSDataMember = "TransferDateFrom";
            this.fld_dteSearchFromICTransferDate.BOSDataSource = "ICTransfers";
            this.fld_dteSearchFromICTransferDate.BOSDescription = null;
            this.fld_dteSearchFromICTransferDate.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICTransferDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICTransferDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICTransferDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICTransferDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICTransferDate.EditValue = null;
            this.fld_dteSearchFromICTransferDate.Location = new System.Drawing.Point(120, 165);
            this.fld_dteSearchFromICTransferDate.Name = "fld_dteSearchFromICTransferDate";
            this.fld_dteSearchFromICTransferDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICTransferDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICTransferDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICTransferDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICTransferDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICTransferDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICTransferDate.Screen = null;
            this.fld_dteSearchFromICTransferDate.Size = new System.Drawing.Size(140, 20);
            this.fld_dteSearchFromICTransferDate.TabIndex = 7;
            this.fld_dteSearchFromICTransferDate.Tag = "SC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(284, 142);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 81;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Đến kho";
            // 
            // fld_lkeFK_ICFromStockID
            // 
            this.fld_lkeFK_ICFromStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID.BOSAllowDummy = true;
            this.fld_lkeFK_ICFromStockID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICFromStockID.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.Location = new System.Drawing.Point(120, 139);
            this.fld_lkeFK_ICFromStockID.Name = "fld_lkeFK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICFromStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICFromStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID.Screen = null;
            this.fld_lkeFK_ICFromStockID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_ICFromStockID.TabIndex = 5;
            this.fld_lkeFK_ICFromStockID.Tag = "SC";
            // 
            // fld_lkeFK_ICToStockID
            // 
            this.fld_lkeFK_ICToStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID.BOSAllowDummy = true;
            this.fld_lkeFK_ICToStockID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_ICToStockID.BOSDescription = null;
            this.fld_lkeFK_ICToStockID.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.Location = new System.Drawing.Point(351, 139);
            this.fld_lkeFK_ICToStockID.Name = "fld_lkeFK_ICToStockID";
            this.fld_lkeFK_ICToStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICToStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICToStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID.Screen = null;
            this.fld_lkeFK_ICToStockID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_ICToStockID.TabIndex = 6;
            this.fld_lkeFK_ICToStockID.Tag = "SC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(38, 142);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel1.TabIndex = 95;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Từ kho";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(38, 89);
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
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICTransfers";
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(120, 87);
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(38, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(66, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Loại chứng từ";
            // 
            // fld_lkeICTransferType
            // 
            this.fld_lkeICTransferType.BOSAllowAddNew = false;
            this.fld_lkeICTransferType.BOSAllowDummy = true;
            this.fld_lkeICTransferType.BOSComment = null;
            this.fld_lkeICTransferType.BOSDataMember = "ICTransferType";
            this.fld_lkeICTransferType.BOSDataSource = "ICTransfers";
            this.fld_lkeICTransferType.BOSDescription = null;
            this.fld_lkeICTransferType.BOSError = null;
            this.fld_lkeICTransferType.BOSFieldGroup = null;
            this.fld_lkeICTransferType.BOSFieldParent = null;
            this.fld_lkeICTransferType.BOSFieldRelation = null;
            this.fld_lkeICTransferType.BOSPrivilege = null;
            this.fld_lkeICTransferType.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferType.BOSSelectType = null;
            this.fld_lkeICTransferType.BOSSelectTypeValue = null;
            this.fld_lkeICTransferType.CurrentDisplayText = null;
            this.fld_lkeICTransferType.Location = new System.Drawing.Point(120, 61);
            this.fld_lkeICTransferType.Name = "fld_lkeICTransferType";
            this.fld_lkeICTransferType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICTransferType.Screen = null;
            this.fld_lkeICTransferType.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeICTransferType.TabIndex = 2;
            this.fld_lkeICTransferType.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(38, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(67, 13);
            this.bosLabel2.TabIndex = 95;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Số tham chiếu";
            // 
            // fld_txtICTransferReference
            // 
            this.fld_txtICTransferReference.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferReference.BOSDataMember = "ICTransferReference";
            this.fld_txtICTransferReference.BOSDataSource = "ICTransfers";
            this.fld_txtICTransferReference.BOSDescription = null;
            this.fld_txtICTransferReference.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferReference.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferReference.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferReference.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTransferReference.BOSPropertyName = "Text";
            this.fld_txtICTransferReference.Location = new System.Drawing.Point(120, 35);
            this.fld_txtICTransferReference.Name = "fld_txtICTransferReference";
            this.fld_txtICTransferReference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTransferReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTransferReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTransferReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTransferReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTransferReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTransferReference.Screen = null;
            this.fld_txtICTransferReference.Size = new System.Drawing.Size(140, 20);
            this.fld_txtICTransferReference.TabIndex = 1;
            this.fld_txtICTransferReference.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(38, 116);
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
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICTransfers";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(120, 113);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMTS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(679, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lkeICTransferType);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_txtICTransferReference);
            this.Controls.Add(this.fld_txtICTransferNo1);
            this.Controls.Add(this.fld_dgcICTransfer);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchToICTransferDate);
            this.Controls.Add(this.fld_dteSearchFromICTransferDate);
            this.Controls.Add(this.fld_lkeFK_ICFromStockID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_lkeFK_ICToStockID);
            this.Name = "SMTS100";
            this.Text = "Tim kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_ICToStockID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICFromStockID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICTransferDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICTransferDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICTransfer, 0);
            this.Controls.SetChildIndex(this.fld_txtICTransferNo1, 0);
            this.Controls.SetChildIndex(this.fld_txtICTransferReference, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeICTransferType, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICTransferDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICTransferDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICTransferDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICTransferDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICTransferType;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICTransferReference;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
