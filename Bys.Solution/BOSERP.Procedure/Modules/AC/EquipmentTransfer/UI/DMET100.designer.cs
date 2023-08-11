using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EquipmentTransfer.UI
{
	/// <summary>
	/// Summary description for DMET100
	/// </summary>
	partial class DMET100
	{
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtACDocumentNo1;
		private BOSComponent.BOSDateEdit fld_dteACDocumentDate2;
		private BOSComponent.BOSMemoEdit fld_medACDocumentDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;


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
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACDocumentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medACDocumentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteACDocumentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcEquipmentTransferItems = new BOSERP.Modules.EquipmentTransfer.EquipmentTransferItemGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEquipmentTransferItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(118, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 4;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã chứng từ";
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
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(410, 15);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 5;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Ngày chứng từ";
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
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(118, 41);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_txtACDocumentNo1
            // 
            this.fld_txtACDocumentNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo1.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo1.BOSDescription = null;
            this.fld_txtACDocumentNo1.BOSError = null;
            this.fld_txtACDocumentNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.Location = new System.Drawing.Point(201, 12);
            this.fld_txtACDocumentNo1.Name = "fld_txtACDocumentNo1";
            this.fld_txtACDocumentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo1.Screen = null;
            this.fld_txtACDocumentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo1.TabIndex = 0;
            this.fld_txtACDocumentNo1.Tag = "DC";
            // 
            // fld_dteACDocumentDate2
            // 
            this.fld_dteACDocumentDate2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate2.BOSDataMember = "ACDocumentDate";
            this.fld_dteACDocumentDate2.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentDate2.BOSDescription = null;
            this.fld_dteACDocumentDate2.BOSError = null;
            this.fld_dteACDocumentDate2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate2.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentDate2.EditValue = null;
            this.fld_dteACDocumentDate2.Location = new System.Drawing.Point(500, 12);
            this.fld_dteACDocumentDate2.Name = "fld_dteACDocumentDate2";
            this.fld_dteACDocumentDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentDate2.Screen = null;
            this.fld_dteACDocumentDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentDate2.TabIndex = 1;
            this.fld_dteACDocumentDate2.Tag = "DC";
            // 
            // fld_medACDocumentDesc
            // 
            this.fld_medACDocumentDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSDataMember = "ACDocumentDesc";
            this.fld_medACDocumentDesc.BOSDataSource = "ACDocuments";
            this.fld_medACDocumentDesc.BOSDescription = null;
            this.fld_medACDocumentDesc.BOSError = null;
            this.fld_medACDocumentDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSPropertyName = "Text";
            this.fld_medACDocumentDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.Location = new System.Drawing.Point(201, 38);
            this.fld_medACDocumentDesc.Name = "fld_medACDocumentDesc";
            this.fld_medACDocumentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACDocumentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACDocumentDesc.Screen = null;
            this.fld_medACDocumentDesc.Size = new System.Drawing.Size(620, 44);
            this.fld_medACDocumentDesc.TabIndex = 2;
            this.fld_medACDocumentDesc.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 102);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 10;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteACDocumentEmployeePicture
            // 
            this.fld_pteACDocumentEmployeePicture.BOSComment = null;
            this.fld_pteACDocumentEmployeePicture.BOSDataMember = "ACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.BOSDataSource = "ACDocuments";
            this.fld_pteACDocumentEmployeePicture.BOSDescription = null;
            this.fld_pteACDocumentEmployeePicture.BOSError = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACDocumentEmployeePicture.BOSPrivilege = null;
            this.fld_pteACDocumentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACDocumentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteACDocumentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACDocumentEmployeePicture.Name = "fld_pteACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACDocumentEmployeePicture.Screen = null;
            this.fld_pteACDocumentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACDocumentEmployeePicture.TabIndex = 11;
            this.fld_pteACDocumentEmployeePicture.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl1.Controls.Add(this.fld_dgcEquipmentTransferItems);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 128);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(858, 369);
            this.bosGroupControl1.TabIndex = 3;
            this.bosGroupControl1.Text = "Danh sách CCDC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ACEquipmentTransferItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductUsingMethod";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "SpecificEquipment";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(64, 34);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(789, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_dgcEquipmentTransferItems
            // 
            this.fld_dgcEquipmentTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcEquipmentTransferItems.BOSComment = null;
            this.fld_dgcEquipmentTransferItems.BOSDataMember = null;
            this.fld_dgcEquipmentTransferItems.BOSDataSource = "ACEquipmentTransferItems";
            this.fld_dgcEquipmentTransferItems.BOSDescription = null;
            this.fld_dgcEquipmentTransferItems.BOSError = null;
            this.fld_dgcEquipmentTransferItems.BOSFieldGroup = null;
            this.fld_dgcEquipmentTransferItems.BOSFieldRelation = null;
            this.fld_dgcEquipmentTransferItems.BOSGridType = null;
            this.fld_dgcEquipmentTransferItems.BOSPrivilege = null;
            this.fld_dgcEquipmentTransferItems.BOSPropertyName = null;
            this.fld_dgcEquipmentTransferItems.Location = new System.Drawing.Point(5, 65);
            this.fld_dgcEquipmentTransferItems.MenuManager = this.screenToolbar;
            this.fld_dgcEquipmentTransferItems.Name = "fld_dgcEquipmentTransferItems";
            this.fld_dgcEquipmentTransferItems.PrintReport = false;
            this.fld_dgcEquipmentTransferItems.Screen = null;
            this.fld_dgcEquipmentTransferItems.Size = new System.Drawing.Size(848, 299);
            this.fld_dgcEquipmentTransferItems.TabIndex = 1;
            this.fld_dgcEquipmentTransferItems.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(19, 37);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "CCDC";
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
            this.bosPanel1.Controls.Add(this.fld_pteACDocumentEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_medACDocumentDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentDate2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentNo1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 505);
            this.bosPanel1.TabIndex = 0;
            // 
            // DMET100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 505);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMET100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEquipmentTransferItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteACDocumentEmployeePicture;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private EquipmentTransferItemGridControl fld_dgcEquipmentTransferItems;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
