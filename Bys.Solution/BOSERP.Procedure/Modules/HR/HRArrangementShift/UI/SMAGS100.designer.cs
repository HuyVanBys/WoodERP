using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRArrangementShift.UI
{
	/// <summary>
	/// Summary description for SMAGS100
	/// </summary>
	partial class SMAGS100
	{
		private BOSComponent.BOSTextBox fld_txtHRArrangementShiftNo;
		private BOSComponent.BOSTextBox fld_txtHRArrangementShiftName;
		private BOSComponent.BOSDateEdit fld_dteHRArrangementShiftDateFrom;
		private BOSSearchResultsGridControl fld_dgcHRArrangementShift;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTimeSheet;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;


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
            this.fld_txtHRArrangementShiftNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRArrangementShiftName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRArrangementShiftDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcHRArrangementShift = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRTimeSheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRArrangementShiftDateTo = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRArrangementShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRArrangementShiftNo
            // 
            this.fld_txtHRArrangementShiftNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftNo.BOSDataMember = "HRArrangementShiftNo";
            this.fld_txtHRArrangementShiftNo.BOSDataSource = "HRArrangementShifts";
            this.fld_txtHRArrangementShiftNo.BOSDescription = null;
            this.fld_txtHRArrangementShiftNo.BOSError = null;
            this.fld_txtHRArrangementShiftNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftNo.BOSPropertyName = "Text";
            this.fld_txtHRArrangementShiftNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftNo.Location = new System.Drawing.Point(130, 27);
            this.fld_txtHRArrangementShiftNo.Name = "fld_txtHRArrangementShiftNo";
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRArrangementShiftNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRArrangementShiftNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRArrangementShiftNo.Screen = null;
            this.fld_txtHRArrangementShiftNo.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRArrangementShiftNo.TabIndex = 0;
            this.fld_txtHRArrangementShiftNo.Tag = "SC";
            // 
            // fld_txtHRArrangementShiftName
            // 
            this.fld_txtHRArrangementShiftName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftName.BOSDataMember = "HRArrangementShiftName";
            this.fld_txtHRArrangementShiftName.BOSDataSource = "HRArrangementShifts";
            this.fld_txtHRArrangementShiftName.BOSDescription = null;
            this.fld_txtHRArrangementShiftName.BOSError = null;
            this.fld_txtHRArrangementShiftName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftName.BOSPropertyName = "Text";
            this.fld_txtHRArrangementShiftName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRArrangementShiftName.Location = new System.Drawing.Point(130, 51);
            this.fld_txtHRArrangementShiftName.Name = "fld_txtHRArrangementShiftName";
            this.fld_txtHRArrangementShiftName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRArrangementShiftName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRArrangementShiftName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRArrangementShiftName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRArrangementShiftName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRArrangementShiftName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRArrangementShiftName.Screen = null;
            this.fld_txtHRArrangementShiftName.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRArrangementShiftName.TabIndex = 1;
            this.fld_txtHRArrangementShiftName.Tag = "SC";
            // 
            // fld_dteHRArrangementShiftDateFrom
            // 
            this.fld_dteHRArrangementShiftDateFrom.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateFrom.BOSDataMember = "HRArrangementShiftFromDate";
            this.fld_dteHRArrangementShiftDateFrom.BOSDataSource = "HRArrangementShifts";
            this.fld_dteHRArrangementShiftDateFrom.BOSDescription = null;
            this.fld_dteHRArrangementShiftDateFrom.BOSError = null;
            this.fld_dteHRArrangementShiftDateFrom.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateFrom.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateFrom.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHRArrangementShiftDateFrom.EditValue = null;
            this.fld_dteHRArrangementShiftDateFrom.Location = new System.Drawing.Point(130, 103);
            this.fld_dteHRArrangementShiftDateFrom.Name = "fld_dteHRArrangementShiftDateFrom";
            this.fld_dteHRArrangementShiftDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRArrangementShiftDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRArrangementShiftDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRArrangementShiftDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRArrangementShiftDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRArrangementShiftDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRArrangementShiftDateFrom.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRArrangementShiftDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftDateFrom.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRArrangementShiftDateFrom.Screen = null;
            this.fld_dteHRArrangementShiftDateFrom.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRArrangementShiftDateFrom.TabIndex = 4;
            this.fld_dteHRArrangementShiftDateFrom.Tag = "SC";
            // 
            // fld_dgcHRArrangementShift
            // 
            this.fld_dgcHRArrangementShift.AllowDrop = true;
            this.fld_dgcHRArrangementShift.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.BOSDataSource = "HRArrangementShifts";
            this.fld_dgcHRArrangementShift.BOSDescription = null;
            this.fld_dgcHRArrangementShift.BOSError = null;
            this.fld_dgcHRArrangementShift.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.BOSGridType = null;
            this.fld_dgcHRArrangementShift.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRArrangementShift.CommodityType = "";
            this.fld_dgcHRArrangementShift.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRArrangementShift.Location = new System.Drawing.Point(15, 187);
            this.fld_dgcHRArrangementShift.MainView = this.fld_dgvHRTimeSheet;
            this.fld_dgcHRArrangementShift.Name = "fld_dgcHRArrangementShift";
            this.fld_dgcHRArrangementShift.PrintReport = false;
            this.fld_dgcHRArrangementShift.Screen = null;
            this.fld_dgcHRArrangementShift.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRArrangementShift.TabIndex = 6;
            this.fld_dgcHRArrangementShift.Tag = "SR";
            this.fld_dgcHRArrangementShift.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTimeSheet});
            // 
            // fld_dgvHRTimeSheet
            // 
            this.fld_dgvHRTimeSheet.GridControl = this.fld_dgcHRArrangementShift;
            this.fld_dgvHRTimeSheet.Name = "fld_dgvHRTimeSheet";
            this.fld_dgvHRTimeSheet.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.Location = new System.Drawing.Point(31, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 10;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.Location = new System.Drawing.Point(31, 54);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 11;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên chừng từ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(31, 106);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 12;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(31, 80);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 88;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRArrangementShifts";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(130, 77);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Location = new System.Drawing.Point(382, 106);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 12;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteHRArrangementShiftDateTo
            // 
            this.fld_dteHRArrangementShiftDateTo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateTo.BOSDataMember = "HRArrangementShiftToDate";
            this.fld_dteHRArrangementShiftDateTo.BOSDataSource = "HRArrangementShifts";
            this.fld_dteHRArrangementShiftDateTo.BOSDescription = null;
            this.fld_dteHRArrangementShiftDateTo.BOSError = null;
            this.fld_dteHRArrangementShiftDateTo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateTo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateTo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRArrangementShiftDateTo.BOSPropertyName = "EditValue";
            this.fld_dteHRArrangementShiftDateTo.EditValue = null;
            this.fld_dteHRArrangementShiftDateTo.Location = new System.Drawing.Point(473, 103);
            this.fld_dteHRArrangementShiftDateTo.Name = "fld_dteHRArrangementShiftDateTo";
            this.fld_dteHRArrangementShiftDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRArrangementShiftDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRArrangementShiftDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRArrangementShiftDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRArrangementShiftDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRArrangementShiftDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRArrangementShiftDateTo.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRArrangementShiftDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftDateTo.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRArrangementShiftDateTo.Screen = null;
            this.fld_dteHRArrangementShiftDateTo.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRArrangementShiftDateTo.TabIndex = 5;
            this.fld_dteHRArrangementShiftDateTo.Tag = "SC";
            // 
            // SMAGS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_txtHRArrangementShiftNo);
            this.Controls.Add(this.fld_txtHRArrangementShiftName);
            this.Controls.Add(this.fld_dteHRArrangementShiftDateTo);
            this.Controls.Add(this.fld_dteHRArrangementShiftDateFrom);
            this.Controls.Add(this.fld_dgcHRArrangementShift);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Name = "SMAGS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRArrangementShift, 0);
            this.Controls.SetChildIndex(this.fld_dteHRArrangementShiftDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteHRArrangementShiftDateTo, 0);
            this.Controls.SetChildIndex(this.fld_txtHRArrangementShiftName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRArrangementShiftNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRArrangementShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftDateTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHRArrangementShiftDateTo;
	}
}
