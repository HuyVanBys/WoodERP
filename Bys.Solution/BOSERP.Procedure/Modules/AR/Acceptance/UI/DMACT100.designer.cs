using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Acceptance.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMACT100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteICReturnShippingEmployeePicture;


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
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteICReturnShippingEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARAcceptanceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARAcceptanceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ARInvoiceRequestID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACCostCenterID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceTotaCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARAcceptanceTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARAcceptanceDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeARAcceptanceResult = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceReference = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeARAcceptanceStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARAcceptanceItemCosts = new BOSERP.Modules.Acceptance.ARAcceptanceItemCostGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnChooseShipmentItems = new BOSComponent.BOSButton(this.components);
            this.fld_btnShowMaterialShipment = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAcceptanceItemsGridControl = new BOSERP.Modules.Acceptance.AcceptanceItemsGridControl();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAcceptanceName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReturnShippingEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAcceptanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAcceptanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAcceptanceDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARInvoiceRequestID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTotaCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAcceptanceResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAcceptanceStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAcceptanceItemCosts)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAcceptanceItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceName.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteICReturnShippingEmployeePicture
            // 
            this.fld_pteICReturnShippingEmployeePicture.BOSComment = "";
            this.fld_pteICReturnShippingEmployeePicture.BOSDataMember = "ICReturnShippingEmployeePicture";
            this.fld_pteICReturnShippingEmployeePicture.BOSDataSource = "ICReturnShippings";
            this.fld_pteICReturnShippingEmployeePicture.BOSDescription = null;
            this.fld_pteICReturnShippingEmployeePicture.BOSError = "";
            this.fld_pteICReturnShippingEmployeePicture.BOSFieldGroup = "";
            this.fld_pteICReturnShippingEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReturnShippingEmployeePicture.BOSPrivilege = "";
            this.fld_pteICReturnShippingEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReturnShippingEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICReturnShippingEmployeePicture.FileName = null;
            this.fld_pteICReturnShippingEmployeePicture.FilePath = null;
            this.fld_pteICReturnShippingEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICReturnShippingEmployeePicture.Name = "fld_pteICReturnShippingEmployeePicture";
            this.fld_pteICReturnShippingEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReturnShippingEmployeePicture.Screen = null;
            this.fld_pteICReturnShippingEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReturnShippingEmployeePicture.TabIndex = 0;
            this.fld_pteICReturnShippingEmployeePicture.Tag = "DC";
            // 
            // fld_dteARAcceptanceDate
            // 
            this.fld_dteARAcceptanceDate.BOSComment = null;
            this.fld_dteARAcceptanceDate.BOSDataMember = "ARAcceptanceDate";
            this.fld_dteARAcceptanceDate.BOSDataSource = "ARAcceptances";
            this.fld_dteARAcceptanceDate.BOSDescription = null;
            this.fld_dteARAcceptanceDate.BOSError = null;
            this.fld_dteARAcceptanceDate.BOSFieldGroup = null;
            this.fld_dteARAcceptanceDate.BOSFieldRelation = null;
            this.fld_dteARAcceptanceDate.BOSPrivilege = null;
            this.fld_dteARAcceptanceDate.BOSPropertyName = "EditValue";
            this.fld_dteARAcceptanceDate.EditValue = null;
            this.fld_dteARAcceptanceDate.Location = new System.Drawing.Point(470, 12);
            this.fld_dteARAcceptanceDate.MenuManager = this.screenToolbar;
            this.fld_dteARAcceptanceDate.Name = "fld_dteARAcceptanceDate";
            this.fld_dteARAcceptanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARAcceptanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARAcceptanceDate.Screen = null;
            this.fld_dteARAcceptanceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARAcceptanceDate.TabIndex = 1;
            this.fld_dteARAcceptanceDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(388, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(136, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARAcceptanceNo
            // 
            this.fld_txtARAcceptanceNo.BOSComment = null;
            this.fld_txtARAcceptanceNo.BOSDataMember = "ARAcceptanceNo";
            this.fld_txtARAcceptanceNo.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceNo.BOSDescription = null;
            this.fld_txtARAcceptanceNo.BOSError = null;
            this.fld_txtARAcceptanceNo.BOSFieldGroup = null;
            this.fld_txtARAcceptanceNo.BOSFieldRelation = null;
            this.fld_txtARAcceptanceNo.BOSPrivilege = null;
            this.fld_txtARAcceptanceNo.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceNo.Location = new System.Drawing.Point(218, 12);
            this.fld_txtARAcceptanceNo.MenuManager = this.screenToolbar;
            this.fld_txtARAcceptanceNo.Name = "fld_txtARAcceptanceNo";
            this.fld_txtARAcceptanceNo.Screen = null;
            this.fld_txtARAcceptanceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARAcceptanceNo.TabIndex = 0;
            this.fld_txtARAcceptanceNo.Tag = "DC";
            // 
            // fld_medARAcceptanceDesc
            // 
            this.fld_medARAcceptanceDesc.BOSComment = null;
            this.fld_medARAcceptanceDesc.BOSDataMember = "ARAcceptanceDesc";
            this.fld_medARAcceptanceDesc.BOSDataSource = "ARAcceptances";
            this.fld_medARAcceptanceDesc.BOSDescription = null;
            this.fld_medARAcceptanceDesc.BOSError = null;
            this.fld_medARAcceptanceDesc.BOSFieldGroup = null;
            this.fld_medARAcceptanceDesc.BOSFieldRelation = null;
            this.fld_medARAcceptanceDesc.BOSPrivilege = null;
            this.fld_medARAcceptanceDesc.BOSPropertyName = "EditValue";
            this.fld_medARAcceptanceDesc.Location = new System.Drawing.Point(218, 117);
            this.fld_medARAcceptanceDesc.MenuManager = this.screenToolbar;
            this.fld_medARAcceptanceDesc.Name = "fld_medARAcceptanceDesc";
            this.fld_medARAcceptanceDesc.Screen = null;
            this.fld_medARAcceptanceDesc.Size = new System.Drawing.Size(400, 33);
            this.fld_medARAcceptanceDesc.TabIndex = 12;
            this.fld_medARAcceptanceDesc.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARInvoiceRequestID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionNormID);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACCostCenterID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceTotaCost);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lkeARAcceptanceResult);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceReference);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeARAcceptanceStatus);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceName);
            this.bosPanel1.Controls.Add(this.fld_medARAcceptanceDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICReturnShippingEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARAcceptanceNo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteARAcceptanceDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(966, 633);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ARInvoiceRequestID
            // 
            this.fld_lkeFK_ARInvoiceRequestID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARInvoiceRequestID.BOSAllowDummy = false;
            this.fld_lkeFK_ARInvoiceRequestID.BOSComment = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSDataMember = "FK_ARInvoiceRequestID";
            this.fld_lkeFK_ARInvoiceRequestID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_ARInvoiceRequestID.BOSDescription = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSError = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSFieldGroup = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSFieldParent = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSFieldRelation = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSPrivilege = null;
            this.fld_lkeFK_ARInvoiceRequestID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARInvoiceRequestID.BOSSelectType = "";
            this.fld_lkeFK_ARInvoiceRequestID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARInvoiceRequestID.CurrentDisplayText = null;
            this.fld_lkeFK_ARInvoiceRequestID.Location = new System.Drawing.Point(767, 91);
            this.fld_lkeFK_ARInvoiceRequestID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ARInvoiceRequestID.Name = "fld_lkeFK_ARInvoiceRequestID";
            this.fld_lkeFK_ARInvoiceRequestID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARInvoiceRequestID.Properties.ColumnName = null;
            this.fld_lkeFK_ARInvoiceRequestID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARInvoiceRequestText", "Yêu cầu")});
            this.fld_lkeFK_ARInvoiceRequestID.Properties.DisplayMember = "ARInvoiceRequestText";
            this.fld_lkeFK_ARInvoiceRequestID.Properties.NullText = "";
            this.fld_lkeFK_ARInvoiceRequestID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARInvoiceRequestID.Properties.ValueMember = "ARInvoiceRequestID";
            this.fld_lkeFK_ARInvoiceRequestID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARInvoiceRequestID, true);
            this.fld_lkeFK_ARInvoiceRequestID.Size = new System.Drawing.Size(158, 20);
            this.fld_lkeFK_ARInvoiceRequestID.TabIndex = 11;
            this.fld_lkeFK_ARInvoiceRequestID.Tag = "DC";
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(640, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(105, 13);
            this.bosLabel6.TabIndex = 716;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Yêu cầu xuất hóa đơn";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(640, 67);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(45, 13);
            this.bosLabel17.TabIndex = 617;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "BĐM mẫu";
            // 
            // fld_lkeFK_MMProductionNormID
            // 
            this.fld_lkeFK_MMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProductionNormID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormID.BOSDataMember = "FK_PMTemplateID";
            this.fld_lkeFK_MMProductionNormID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_MMProductionNormID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormID.BOSError = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormID.BOSSelectType = "";
            this.fld_lkeFK_MMProductionNormID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormID.Location = new System.Drawing.Point(767, 64);
            this.fld_lkeFK_MMProductionNormID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMProductionNormID.Name = "fld_lkeFK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMTemplateNo", "Mã mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMTemplateName", "Tên mẫu")});
            this.fld_lkeFK_MMProductionNormID.Properties.DisplayMember = "PMTemplateNo";
            this.fld_lkeFK_MMProductionNormID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionNormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionNormID.Properties.ValueMember = "PMTemplateID";
            this.fld_lkeFK_MMProductionNormID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMProductionNormID, true);
            this.fld_lkeFK_MMProductionNormID.Size = new System.Drawing.Size(158, 20);
            this.fld_lkeFK_MMProductionNormID.TabIndex = 8;
            this.fld_lkeFK_MMProductionNormID.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ARSaleContractID";
            this.bosLookupEdit1.BOSDataSource = "ARAcceptances";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(218, 91);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractNo", "Số hợp đồng")});
            this.bosLookupEdit1.Properties.DisplayMember = "ARSaleContractNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ARSaleContractID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 9;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(136, 93);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(60, 13);
            this.bosLabel10.TabIndex = 615;
            this.bosLabel10.Text = "Số hợp đồng";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(388, 93);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(46, 13);
            this.bosLabel16.TabIndex = 613;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "TT chi phí";
            // 
            // fld_lkeFK_ACCostCenterID
            // 
            this.fld_lkeFK_ACCostCenterID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCostCenterID.BOSAllowDummy = false;
            this.fld_lkeFK_ACCostCenterID.BOSComment = null;
            this.fld_lkeFK_ACCostCenterID.BOSDataMember = "FK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_ACCostCenterID.BOSDescription = null;
            this.fld_lkeFK_ACCostCenterID.BOSError = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldGroup = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldParent = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldRelation = null;
            this.fld_lkeFK_ACCostCenterID.BOSPrivilege = null;
            this.fld_lkeFK_ACCostCenterID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACCostCenterID.BOSSelectType = "";
            this.fld_lkeFK_ACCostCenterID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACCostCenterID.CurrentDisplayText = null;
            this.fld_lkeFK_ACCostCenterID.Location = new System.Drawing.Point(470, 91);
            this.fld_lkeFK_ACCostCenterID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACCostCenterID.Name = "fld_lkeFK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCostCenterID.Properties.ColumnName = null;
            this.fld_lkeFK_ACCostCenterID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterName", "TT Chi phí")});
            this.fld_lkeFK_ACCostCenterID.Properties.DisplayMember = "ACCostCenterName";
            this.fld_lkeFK_ACCostCenterID.Properties.NullText = "";
            this.fld_lkeFK_ACCostCenterID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACCostCenterID.Properties.ValueMember = "ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACCostCenterID, true);
            this.fld_lkeFK_ACCostCenterID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_ACCostCenterID.TabIndex = 10;
            this.fld_lkeFK_ACCostCenterID.Tag = "DC";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(470, 64);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 7;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(388, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(45, 13);
            this.bosLabel12.TabIndex = 585;
            this.bosLabel12.Text = "Mã dự án";
            // 
            // fld_txtARAcceptanceTotaCost
            // 
            this.fld_txtARAcceptanceTotaCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceTotaCost.BOSComment = "";
            this.fld_txtARAcceptanceTotaCost.BOSDataMember = "ARAcceptanceTotalCost";
            this.fld_txtARAcceptanceTotaCost.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceTotaCost.BOSDescription = null;
            this.fld_txtARAcceptanceTotaCost.BOSError = null;
            this.fld_txtARAcceptanceTotaCost.BOSFieldGroup = "";
            this.fld_txtARAcceptanceTotaCost.BOSFieldRelation = "";
            this.fld_txtARAcceptanceTotaCost.BOSPrivilege = "";
            this.fld_txtARAcceptanceTotaCost.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceTotaCost.EditValue = "0.00";
            this.fld_txtARAcceptanceTotaCost.Location = new System.Drawing.Point(779, 525);
            this.fld_txtARAcceptanceTotaCost.Name = "fld_txtARAcceptanceTotaCost";
            this.fld_txtARAcceptanceTotaCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARAcceptanceTotaCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceTotaCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceTotaCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceTotaCost.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceTotaCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceTotaCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceTotaCost.Properties.ReadOnly = true;
            this.fld_txtARAcceptanceTotaCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceTotaCost.Screen = null;
            this.fld_txtARAcceptanceTotaCost.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARAcceptanceTotaCost.TabIndex = 582;
            this.fld_txtARAcceptanceTotaCost.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(730, 528);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(33, 13);
            this.bosLabel24.TabIndex = 583;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Chi phí";
            // 
            // fld_txtARAcceptanceTotalAmount
            // 
            this.fld_txtARAcceptanceTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceTotalAmount.BOSComment = "";
            this.fld_txtARAcceptanceTotalAmount.BOSDataMember = "ARAcceptanceTotalAmount";
            this.fld_txtARAcceptanceTotalAmount.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceTotalAmount.BOSDescription = null;
            this.fld_txtARAcceptanceTotalAmount.BOSError = null;
            this.fld_txtARAcceptanceTotalAmount.BOSFieldGroup = "";
            this.fld_txtARAcceptanceTotalAmount.BOSFieldRelation = "";
            this.fld_txtARAcceptanceTotalAmount.BOSPrivilege = "";
            this.fld_txtARAcceptanceTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceTotalAmount.EditValue = "0.00";
            this.fld_txtARAcceptanceTotalAmount.Location = new System.Drawing.Point(779, 605);
            this.fld_txtARAcceptanceTotalAmount.Name = "fld_txtARAcceptanceTotalAmount";
            this.fld_txtARAcceptanceTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARAcceptanceTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARAcceptanceTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceTotalAmount.Screen = null;
            this.fld_txtARAcceptanceTotalAmount.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARAcceptanceTotalAmount.TabIndex = 573;
            this.fld_txtARAcceptanceTotalAmount.Tag = "DC";
            // 
            // fld_txtARAcceptanceTaxAmount
            // 
            this.fld_txtARAcceptanceTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceTaxAmount.BOSComment = "";
            this.fld_txtARAcceptanceTaxAmount.BOSDataMember = "ARAcceptanceTaxAmount";
            this.fld_txtARAcceptanceTaxAmount.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceTaxAmount.BOSDescription = null;
            this.fld_txtARAcceptanceTaxAmount.BOSError = null;
            this.fld_txtARAcceptanceTaxAmount.BOSFieldGroup = "";
            this.fld_txtARAcceptanceTaxAmount.BOSFieldRelation = "";
            this.fld_txtARAcceptanceTaxAmount.BOSPrivilege = "";
            this.fld_txtARAcceptanceTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceTaxAmount.EditValue = "0.00";
            this.fld_txtARAcceptanceTaxAmount.Location = new System.Drawing.Point(854, 579);
            this.fld_txtARAcceptanceTaxAmount.Name = "fld_txtARAcceptanceTaxAmount";
            this.fld_txtARAcceptanceTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceTaxAmount.Screen = null;
            this.fld_txtARAcceptanceTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARAcceptanceTaxAmount.TabIndex = 572;
            this.fld_txtARAcceptanceTaxAmount.Tag = "DC";
            this.fld_txtARAcceptanceTaxAmount.Validated += new System.EventHandler(this.fld_txtARAcceptanceTaxAmount_Validated);
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = "";
            this.fld_lblLabel47.BOSDataMember = "";
            this.fld_lblLabel47.BOSDataSource = "";
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = "";
            this.fld_lblLabel47.BOSFieldRelation = "";
            this.fld_lblLabel47.BOSPrivilege = "";
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(696, 608);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 579;
            this.fld_lblLabel47.Tag = "";
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtARAcceptanceDiscountFix
            // 
            this.fld_txtARAcceptanceDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceDiscountFix.BOSComment = "";
            this.fld_txtARAcceptanceDiscountFix.BOSDataMember = "ARAcceptanceDiscountFix";
            this.fld_txtARAcceptanceDiscountFix.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceDiscountFix.BOSDescription = null;
            this.fld_txtARAcceptanceDiscountFix.BOSError = null;
            this.fld_txtARAcceptanceDiscountFix.BOSFieldGroup = "";
            this.fld_txtARAcceptanceDiscountFix.BOSFieldRelation = "";
            this.fld_txtARAcceptanceDiscountFix.BOSPrivilege = "";
            this.fld_txtARAcceptanceDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceDiscountFix.EditValue = "0.00";
            this.fld_txtARAcceptanceDiscountFix.Location = new System.Drawing.Point(854, 552);
            this.fld_txtARAcceptanceDiscountFix.Name = "fld_txtARAcceptanceDiscountFix";
            this.fld_txtARAcceptanceDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceDiscountFix.Screen = null;
            this.fld_txtARAcceptanceDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARAcceptanceDiscountFix.TabIndex = 570;
            this.fld_txtARAcceptanceDiscountFix.Tag = "DC";
            this.fld_txtARAcceptanceDiscountFix.Validated += new System.EventHandler(this.fld_txtARAcceptanceDiscountFix_Validated);
            // 
            // fld_txtARAcceptanceDiscountPerCent
            // 
            this.fld_txtARAcceptanceDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceDiscountPerCent.BOSComment = "";
            this.fld_txtARAcceptanceDiscountPerCent.BOSDataMember = "ARAcceptanceDiscountPerCent";
            this.fld_txtARAcceptanceDiscountPerCent.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceDiscountPerCent.BOSDescription = null;
            this.fld_txtARAcceptanceDiscountPerCent.BOSError = null;
            this.fld_txtARAcceptanceDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtARAcceptanceDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARAcceptanceDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARAcceptanceDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceDiscountPerCent.EditValue = "0.00";
            this.fld_txtARAcceptanceDiscountPerCent.Location = new System.Drawing.Point(779, 552);
            this.fld_txtARAcceptanceDiscountPerCent.Name = "fld_txtARAcceptanceDiscountPerCent";
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceDiscountPerCent.Screen = null;
            this.fld_txtARAcceptanceDiscountPerCent.Size = new System.Drawing.Size(70, 20);
            this.fld_txtARAcceptanceDiscountPerCent.TabIndex = 569;
            this.fld_txtARAcceptanceDiscountPerCent.Tag = "DC";
            this.fld_txtARAcceptanceDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARAcceptanceDiscountPerCent_Validated);
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = "";
            this.fld_lblLabel46.BOSDataMember = "";
            this.fld_lblLabel46.BOSDataSource = "";
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = "";
            this.fld_lblLabel46.BOSFieldRelation = "";
            this.fld_lblLabel46.BOSPrivilege = "";
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(711, 555);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel46.TabIndex = 577;
            this.fld_lblLabel46.Tag = "";
            this.fld_lblLabel46.Text = "Chiết khấu";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(709, 582);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 581;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Thuế GTGT";
            // 
            // fld_txtARAcceptanceSubTotalAmount
            // 
            this.fld_txtARAcceptanceSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceSubTotalAmount.BOSComment = "";
            this.fld_txtARAcceptanceSubTotalAmount.BOSDataMember = "ARAcceptanceSubTotalAmount";
            this.fld_txtARAcceptanceSubTotalAmount.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceSubTotalAmount.BOSDescription = null;
            this.fld_txtARAcceptanceSubTotalAmount.BOSError = null;
            this.fld_txtARAcceptanceSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARAcceptanceSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARAcceptanceSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARAcceptanceSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceSubTotalAmount.EditValue = "0.00";
            this.fld_txtARAcceptanceSubTotalAmount.Location = new System.Drawing.Point(779, 499);
            this.fld_txtARAcceptanceSubTotalAmount.Name = "fld_txtARAcceptanceSubTotalAmount";
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARAcceptanceSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceSubTotalAmount.Screen = null;
            this.fld_txtARAcceptanceSubTotalAmount.Size = new System.Drawing.Size(175, 20);
            this.fld_txtARAcceptanceSubTotalAmount.TabIndex = 568;
            this.fld_txtARAcceptanceSubTotalAmount.Tag = "DC";
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = "";
            this.fld_lblLabel44.BOSDataMember = "";
            this.fld_lblLabel44.BOSDataSource = "";
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = "";
            this.fld_lblLabel44.BOSFieldRelation = "";
            this.fld_lblLabel44.BOSPrivilege = "";
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(712, 502);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 576;
            this.fld_lblLabel44.Tag = "";
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_txtARAcceptanceTaxPercent
            // 
            this.fld_txtARAcceptanceTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARAcceptanceTaxPercent.BOSComment = "";
            this.fld_txtARAcceptanceTaxPercent.BOSDataMember = "ARAcceptanceTaxPercent";
            this.fld_txtARAcceptanceTaxPercent.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceTaxPercent.BOSDescription = null;
            this.fld_txtARAcceptanceTaxPercent.BOSError = null;
            this.fld_txtARAcceptanceTaxPercent.BOSFieldGroup = "";
            this.fld_txtARAcceptanceTaxPercent.BOSFieldRelation = "";
            this.fld_txtARAcceptanceTaxPercent.BOSPrivilege = "";
            this.fld_txtARAcceptanceTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceTaxPercent.EditValue = "";
            this.fld_txtARAcceptanceTaxPercent.Location = new System.Drawing.Point(779, 579);
            this.fld_txtARAcceptanceTaxPercent.Name = "fld_txtARAcceptanceTaxPercent";
            this.fld_txtARAcceptanceTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARAcceptanceTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARAcceptanceTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceTaxPercent.Screen = null;
            this.fld_txtARAcceptanceTaxPercent.Size = new System.Drawing.Size(70, 20);
            this.fld_txtARAcceptanceTaxPercent.TabIndex = 571;
            this.fld_txtARAcceptanceTaxPercent.Tag = "DC";
            this.fld_txtARAcceptanceTaxPercent.Validated += new System.EventHandler(this.fld_txtARAcceptanceTaxPercent_Validated);
            // 
            // fld_lkeARAcceptanceResult
            // 
            this.fld_lkeARAcceptanceResult.BOSAllowAddNew = false;
            this.fld_lkeARAcceptanceResult.BOSAllowDummy = false;
            this.fld_lkeARAcceptanceResult.BOSComment = null;
            this.fld_lkeARAcceptanceResult.BOSDataMember = "ARAcceptanceResult";
            this.fld_lkeARAcceptanceResult.BOSDataSource = "ARAcceptances";
            this.fld_lkeARAcceptanceResult.BOSDescription = null;
            this.fld_lkeARAcceptanceResult.BOSError = null;
            this.fld_lkeARAcceptanceResult.BOSFieldGroup = null;
            this.fld_lkeARAcceptanceResult.BOSFieldParent = null;
            this.fld_lkeARAcceptanceResult.BOSFieldRelation = null;
            this.fld_lkeARAcceptanceResult.BOSPrivilege = null;
            this.fld_lkeARAcceptanceResult.BOSPropertyName = "EditValue";
            this.fld_lkeARAcceptanceResult.BOSSelectType = null;
            this.fld_lkeARAcceptanceResult.BOSSelectTypeValue = null;
            this.fld_lkeARAcceptanceResult.CurrentDisplayText = null;
            this.fld_lkeARAcceptanceResult.Location = new System.Drawing.Point(218, 64);
            this.fld_lkeARAcceptanceResult.MenuManager = this.screenToolbar;
            this.fld_lkeARAcceptanceResult.Name = "fld_lkeARAcceptanceResult";
            this.fld_lkeARAcceptanceResult.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARAcceptanceResult.Properties.ColumnName = null;
            this.fld_lkeARAcceptanceResult.Screen = null;
            this.fld_lkeARAcceptanceResult.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARAcceptanceResult.TabIndex = 6;
            this.fld_lkeARAcceptanceResult.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(136, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(37, 13);
            this.bosLabel5.TabIndex = 566;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Kết quả";
            // 
            // fld_txtARAcceptanceReference
            // 
            this.fld_txtARAcceptanceReference.BOSComment = null;
            this.fld_txtARAcceptanceReference.BOSDataMember = "ARAcceptanceReference";
            this.fld_txtARAcceptanceReference.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceReference.BOSDescription = null;
            this.fld_txtARAcceptanceReference.BOSError = null;
            this.fld_txtARAcceptanceReference.BOSFieldGroup = null;
            this.fld_txtARAcceptanceReference.BOSFieldRelation = null;
            this.fld_txtARAcceptanceReference.BOSPrivilege = null;
            this.fld_txtARAcceptanceReference.BOSPropertyName = "EditValue";
            this.fld_txtARAcceptanceReference.Location = new System.Drawing.Point(767, 38);
            this.fld_txtARAcceptanceReference.MenuManager = this.screenToolbar;
            this.fld_txtARAcceptanceReference.Name = "fld_txtARAcceptanceReference";
            this.fld_txtARAcceptanceReference.Screen = null;
            this.fld_txtARAcceptanceReference.Size = new System.Drawing.Size(158, 20);
            this.fld_txtARAcceptanceReference.TabIndex = 5;
            this.fld_txtARAcceptanceReference.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(640, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(38, 13);
            this.bosLabel4.TabIndex = 564;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mã ĐBH";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(640, 15);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 562;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARAcceptances";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(767, 12);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(158, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_lkeARAcceptanceStatus
            // 
            this.fld_lkeARAcceptanceStatus.BOSAllowAddNew = false;
            this.fld_lkeARAcceptanceStatus.BOSAllowDummy = false;
            this.fld_lkeARAcceptanceStatus.BOSComment = null;
            this.fld_lkeARAcceptanceStatus.BOSDataMember = "ARAcceptanceStatus";
            this.fld_lkeARAcceptanceStatus.BOSDataSource = "ARAcceptances";
            this.fld_lkeARAcceptanceStatus.BOSDescription = null;
            this.fld_lkeARAcceptanceStatus.BOSError = null;
            this.fld_lkeARAcceptanceStatus.BOSFieldGroup = null;
            this.fld_lkeARAcceptanceStatus.BOSFieldParent = null;
            this.fld_lkeARAcceptanceStatus.BOSFieldRelation = null;
            this.fld_lkeARAcceptanceStatus.BOSPrivilege = null;
            this.fld_lkeARAcceptanceStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARAcceptanceStatus.BOSSelectType = null;
            this.fld_lkeARAcceptanceStatus.BOSSelectTypeValue = null;
            this.fld_lkeARAcceptanceStatus.CurrentDisplayText = null;
            this.fld_lkeARAcceptanceStatus.Location = new System.Drawing.Point(470, 38);
            this.fld_lkeARAcceptanceStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARAcceptanceStatus.Name = "fld_lkeARAcceptanceStatus";
            this.fld_lkeARAcceptanceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARAcceptanceStatus.Properties.ColumnName = null;
            this.fld_lkeARAcceptanceStatus.Properties.ReadOnly = true;
            this.fld_lkeARAcceptanceStatus.Screen = null;
            this.fld_lkeARAcceptanceStatus.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeARAcceptanceStatus.TabIndex = 4;
            this.fld_lkeARAcceptanceStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 156);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(950, 337);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARAcceptanceItemCosts);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(944, 309);
            this.xtraTabPage2.Text = "Chi phí";
            // 
            // fld_dgcARAcceptanceItemCosts
            // 
            this.fld_dgcARAcceptanceItemCosts.BOSComment = null;
            this.fld_dgcARAcceptanceItemCosts.BOSDataMember = null;
            this.fld_dgcARAcceptanceItemCosts.BOSDataSource = "ARAcceptanceItemWorks";
            this.fld_dgcARAcceptanceItemCosts.BOSDescription = null;
            this.fld_dgcARAcceptanceItemCosts.BOSError = null;
            this.fld_dgcARAcceptanceItemCosts.BOSFieldGroup = null;
            this.fld_dgcARAcceptanceItemCosts.BOSFieldRelation = null;
            this.fld_dgcARAcceptanceItemCosts.BOSGridType = null;
            this.fld_dgcARAcceptanceItemCosts.BOSPrivilege = null;
            this.fld_dgcARAcceptanceItemCosts.BOSPropertyName = null;
            this.fld_dgcARAcceptanceItemCosts.CommodityType = "";
            this.fld_dgcARAcceptanceItemCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARAcceptanceItemCosts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARAcceptanceItemCosts.MenuManager = this.screenToolbar;
            this.fld_dgcARAcceptanceItemCosts.Name = "fld_dgcARAcceptanceItemCosts";
            this.fld_dgcARAcceptanceItemCosts.PrintReport = false;
            this.fld_dgcARAcceptanceItemCosts.Screen = null;
            this.fld_dgcARAcceptanceItemCosts.Size = new System.Drawing.Size(944, 309);
            this.fld_dgcARAcceptanceItemCosts.TabIndex = 2;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnChooseShipmentItems);
            this.xtraTabPage1.Controls.Add(this.fld_btnShowMaterialShipment);
            this.xtraTabPage1.Controls.Add(this.fld_dgcAcceptanceItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(944, 309);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_btnChooseShipmentItems
            // 
            this.fld_btnChooseShipmentItems.BOSComment = null;
            this.fld_btnChooseShipmentItems.BOSDataMember = null;
            this.fld_btnChooseShipmentItems.BOSDataSource = null;
            this.fld_btnChooseShipmentItems.BOSDescription = null;
            this.fld_btnChooseShipmentItems.BOSError = null;
            this.fld_btnChooseShipmentItems.BOSFieldGroup = null;
            this.fld_btnChooseShipmentItems.BOSFieldRelation = null;
            this.fld_btnChooseShipmentItems.BOSPrivilege = null;
            this.fld_btnChooseShipmentItems.BOSPropertyName = null;
            this.fld_btnChooseShipmentItems.Location = new System.Drawing.Point(129, 3);
            this.fld_btnChooseShipmentItems.Name = "fld_btnChooseShipmentItems";
            this.fld_btnChooseShipmentItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChooseShipmentItems, true);
            this.fld_btnChooseShipmentItems.Size = new System.Drawing.Size(116, 27);
            this.fld_btnChooseShipmentItems.TabIndex = 1;
            this.fld_btnChooseShipmentItems.Tag = "ShowMaterialShipment";
            this.fld_btnChooseShipmentItems.Text = "Từ xuất kho bán hàng";
            this.fld_btnChooseShipmentItems.Click += new System.EventHandler(this.fld_btnChooseShipmentItems_Click);
            // 
            // fld_btnShowMaterialShipment
            // 
            this.fld_btnShowMaterialShipment.BOSComment = null;
            this.fld_btnShowMaterialShipment.BOSDataMember = null;
            this.fld_btnShowMaterialShipment.BOSDataSource = null;
            this.fld_btnShowMaterialShipment.BOSDescription = null;
            this.fld_btnShowMaterialShipment.BOSError = null;
            this.fld_btnShowMaterialShipment.BOSFieldGroup = null;
            this.fld_btnShowMaterialShipment.BOSFieldRelation = null;
            this.fld_btnShowMaterialShipment.BOSPrivilege = null;
            this.fld_btnShowMaterialShipment.BOSPropertyName = null;
            this.fld_btnShowMaterialShipment.Location = new System.Drawing.Point(7, 3);
            this.fld_btnShowMaterialShipment.Name = "fld_btnShowMaterialShipment";
            this.fld_btnShowMaterialShipment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowMaterialShipment, true);
            this.fld_btnShowMaterialShipment.Size = new System.Drawing.Size(116, 27);
            this.fld_btnShowMaterialShipment.TabIndex = 0;
            this.fld_btnShowMaterialShipment.Tag = "ShowMaterialShipment";
            this.fld_btnShowMaterialShipment.Text = "Từ xuất kho vật tư";
            this.fld_btnShowMaterialShipment.Click += new System.EventHandler(this.fld_btnShowMaterialShipment_Click);
            // 
            // fld_dgcAcceptanceItemsGridControl
            // 
            this.fld_dgcAcceptanceItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAcceptanceItemsGridControl.BOSComment = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSDataMember = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSDataSource = "ARAcceptanceItems";
            this.fld_dgcAcceptanceItemsGridControl.BOSDescription = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSError = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSGridType = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSPrivilege = null;
            this.fld_dgcAcceptanceItemsGridControl.BOSPropertyName = null;
            this.fld_dgcAcceptanceItemsGridControl.CommodityType = "";
            this.fld_dgcAcceptanceItemsGridControl.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcAcceptanceItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAcceptanceItemsGridControl.Name = "fld_dgcAcceptanceItemsGridControl";
            this.fld_dgcAcceptanceItemsGridControl.PrintReport = false;
            this.fld_dgcAcceptanceItemsGridControl.Screen = null;
            this.fld_dgcAcceptanceItemsGridControl.Size = new System.Drawing.Size(935, 270);
            this.fld_dgcAcceptanceItemsGridControl.TabIndex = 2;
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(136, 41);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 417;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtARAcceptanceName
            // 
            this.fld_txtARAcceptanceName.BOSComment = "";
            this.fld_txtARAcceptanceName.BOSDataMember = "ARAcceptanceName";
            this.fld_txtARAcceptanceName.BOSDataSource = "ARAcceptances";
            this.fld_txtARAcceptanceName.BOSDescription = null;
            this.fld_txtARAcceptanceName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtARAcceptanceName.BOSFieldGroup = "";
            this.fld_txtARAcceptanceName.BOSFieldRelation = "";
            this.fld_txtARAcceptanceName.BOSPrivilege = "";
            this.fld_txtARAcceptanceName.BOSPropertyName = "Text";
            this.fld_txtARAcceptanceName.Location = new System.Drawing.Point(218, 38);
            this.fld_txtARAcceptanceName.Name = "fld_txtARAcceptanceName";
            this.fld_txtARAcceptanceName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAcceptanceName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAcceptanceName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAcceptanceName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAcceptanceName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAcceptanceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAcceptanceName.Screen = null;
            this.fld_txtARAcceptanceName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARAcceptanceName.TabIndex = 3;
            this.fld_txtARAcceptanceName.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(136, 120);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(27, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Mô tả";
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
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(388, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
            // 
            // DMACT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(966, 633);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReturnShippingEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAcceptanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAcceptanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAcceptanceDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARInvoiceRequestID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTotaCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAcceptanceResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAcceptanceStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAcceptanceItemCosts)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAcceptanceItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAcceptanceName.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARAcceptanceDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceNo;
        private BOSComponent.BOSMemoEdit fld_medARAcceptanceDesc;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceName;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private AcceptanceItemsGridControl fld_dgcAcceptanceItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARAcceptanceStatus;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeARAcceptanceResult;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceReference;
        private BOSComponent.BOSLabel bosLabel4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSERP.Modules.Acceptance.ARAcceptanceItemCostGridControl fld_dgcARAcceptanceItemCosts;
        private BOSComponent.BOSButton fld_btnShowMaterialShipment;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceTotaCost;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceTaxAmount;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceDiscountFix;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceDiscountPerCent;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceSubTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSTextBox fld_txtARAcceptanceTaxPercent;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSButton fld_btnChooseShipmentItems;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCostCenterID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARInvoiceRequestID;
        private BOSComponent.BOSLabel bosLabel6;
    }
}
