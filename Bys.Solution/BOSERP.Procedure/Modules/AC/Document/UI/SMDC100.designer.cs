using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Document.UI
{
	/// <summary>
	/// Summary description for SMDC100
	/// </summary>
	partial class SMDC100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BaseDocumentGridControl fld_dgcACDocument;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocument;
        private BOSComponent.BOSTextBox fld_txtACDocumentNo;


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
            this.fld_dgcACDocument = new BOSERP.BaseDocumentGridControl();
            this.fld_dgvACDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACDocumentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_Lablel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACDocumentTypeID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDocumentTypeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(23, 23);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 0;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_dgcACDocument
            // 
            this.fld_dgcACDocument.AllowDrop = true;
            this.fld_dgcACDocument.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.BOSDataSource = "ACDocuments";
            this.fld_dgcACDocument.BOSDescription = null;
            this.fld_dgcACDocument.BOSError = null;
            this.fld_dgcACDocument.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocument.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocument.Location = new System.Drawing.Point(16, 175);
            this.fld_dgcACDocument.MainView = this.fld_dgvACDocument;
            this.fld_dgcACDocument.Name = "fld_dgcACDocument";
            this.fld_dgcACDocument.Screen = null;
            this.fld_dgcACDocument.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACDocument.TabIndex = 6;
            this.fld_dgcACDocument.Tag = "SR";
            this.fld_dgcACDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocument});
            // 
            // fld_dgvACDocument
            // 
            this.fld_dgvACDocument.GridControl = this.fld_dgcACDocument;
            this.fld_dgvACDocument.Name = "fld_dgvACDocument";
            this.fld_dgvACDocument.PaintStyleName = "Office2003";
            // 
            // fld_txtACDocumentNo
            // 
            this.fld_txtACDocumentNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACDocumentNo.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo.BOSDescription = null;
            this.fld_txtACDocumentNo.BOSError = null;
            this.fld_txtACDocumentNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACDocumentNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACDocumentNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACDocumentNo.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACDocumentNo.Location = new System.Drawing.Point(145, 20);
            this.fld_txtACDocumentNo.Name = "fld_txtACDocumentNo";
            this.fld_txtACDocumentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo.Screen = null;
            this.fld_txtACDocumentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo.TabIndex = 0;
            this.fld_txtACDocumentNo.Tag = "SC";
            // 
            // fld_Lablel4
            // 
            this.fld_Lablel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.Options.UseBackColor = true;
            this.fld_Lablel4.Appearance.Options.UseForeColor = true;
            this.fld_Lablel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDescription = null;
            this.fld_Lablel4.BOSError = null;
            this.fld_Lablel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.Location = new System.Drawing.Point(23, 152);
            this.fld_Lablel4.Name = "fld_Lablel4";
            this.fld_Lablel4.Screen = null;
            this.fld_Lablel4.Size = new System.Drawing.Size(86, 13);
            this.fld_Lablel4.TabIndex = 2;
            this.fld_Lablel4.Tag = "SI";
            this.fld_Lablel4.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.Location = new System.Drawing.Point(322, 152);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(23, 13);
            this.fld_lblLabel17.TabIndex = 4;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ";
            // 
            // fld_dteSearchFromACDocumentDate
            // 
            this.fld_dteSearchFromACDocumentDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACDocumentDate.BOSDataMember = "DocumentDateFrom";
            this.fld_dteSearchFromACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteSearchFromACDocumentDate.BOSDescription = null;
            this.fld_dteSearchFromACDocumentDate.BOSError = null;
            this.fld_dteSearchFromACDocumentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACDocumentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACDocumentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromACDocumentDate.EditValue = null;
            this.fld_dteSearchFromACDocumentDate.Location = new System.Drawing.Point(145, 149);
            this.fld_dteSearchFromACDocumentDate.Name = "fld_dteSearchFromACDocumentDate";
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromACDocumentDate.Screen = null;
            this.fld_dteSearchFromACDocumentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromACDocumentDate.TabIndex = 4;
            this.fld_dteSearchFromACDocumentDate.Tag = "SC";
            // 
            // fld_dteSearchToACDocumentDate
            // 
            this.fld_dteSearchToACDocumentDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACDocumentDate.BOSDataMember = "DocumentDateTo";
            this.fld_dteSearchToACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteSearchToACDocumentDate.BOSDescription = null;
            this.fld_dteSearchToACDocumentDate.BOSError = null;
            this.fld_dteSearchToACDocumentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACDocumentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACDocumentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToACDocumentDate.EditValue = null;
            this.fld_dteSearchToACDocumentDate.Location = new System.Drawing.Point(361, 149);
            this.fld_dteSearchToACDocumentDate.Name = "fld_dteSearchToACDocumentDate";
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToACDocumentDate.Screen = null;
            this.fld_dteSearchToACDocumentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToACDocumentDate.TabIndex = 5;
            this.fld_dteSearchToACDocumentDate.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(23, 75);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(145, 72);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(145, 97);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(23, 126);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(145, 123);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(23, 100);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Nhân viên";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Location = new System.Drawing.Point(23, 49);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(66, 13);
            this.bosLabel4.TabIndex = 19;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Loại chứng từ";
            // 
            // fld_lkeFK_ACDocumentTypeID
            // 
            this.fld_lkeFK_ACDocumentTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDocumentTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ACDocumentTypeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSDataMember = "FK_ACDocumentTypeID";
            this.fld_lkeFK_ACDocumentTypeID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACDocumentTypeID.BOSDescription = null;
            this.fld_lkeFK_ACDocumentTypeID.BOSError = null;
            this.fld_lkeFK_ACDocumentTypeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACDocumentTypeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ACDocumentTypeID.Location = new System.Drawing.Point(145, 46);
            this.fld_lkeFK_ACDocumentTypeID.Name = "fld_lkeFK_ACDocumentTypeID";
            this.fld_lkeFK_ACDocumentTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACDocumentTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACDocumentTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACDocumentTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACDocumentTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDocumentTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACDocumentTypeDesc", "Loại chứng từ")});
            this.fld_lkeFK_ACDocumentTypeID.Properties.DisplayMember = "ACDocumentTypeDesc";
            this.fld_lkeFK_ACDocumentTypeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDocumentTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACDocumentTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDocumentTypeID.Properties.ValueMember = "ACDocumentTypeID";
            this.fld_lkeFK_ACDocumentTypeID.Screen = null;
            this.fld_lkeFK_ACDocumentTypeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACDocumentTypeID.TabIndex = 20;
            this.fld_lkeFK_ACDocumentTypeID.Tag = "SC";
            // 
            // SMDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_ACDocumentTypeID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_Lablel4);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchFromACDocumentDate);
            this.Controls.Add(this.fld_dteSearchToACDocumentDate);
            this.Controls.Add(this.fld_dgcACDocument);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtACDocumentNo);
            this.Name = "SMDC100";
            this.Tag = "SC";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACDocumentNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcACDocument, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToACDocumentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromACDocumentDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_Lablel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACDocumentTypeID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDocumentTypeID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_Lablel4;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchFromACDocumentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToACDocumentDate;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDocumentTypeID;
	}
}
