using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AllocationEquipment.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMAE100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARAllocationEmployeePicture;


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
            this.fld_pteARAllocationEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARAllocationDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAllocationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARAllocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_PMProjectID123 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDriverEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARAllocationExpediencyQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRProposedEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARAllocationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARAllocationItemsGridControl = new BOSERP.Modules.AllocationEquipment.ARAllocationItemsGridControl();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAllocationName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARAllocationEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAllocationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAllocationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDriverEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationExpediencyQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProposedEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAllocationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAllocationItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationName.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARAllocations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.PurchaseOrderLocalizedResources.a;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.PurchaseOrderLocalizedResources.a, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteARAllocationEmployeePicture
            // 
            this.fld_pteARAllocationEmployeePicture.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_pteARAllocationEmployeePicture.BOSDataMember = "ARAllocationEmployeePicture";
            this.fld_pteARAllocationEmployeePicture.BOSDataSource = "ARAllocations";
            this.fld_pteARAllocationEmployeePicture.BOSDescription = null;
            this.fld_pteARAllocationEmployeePicture.BOSError = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_pteARAllocationEmployeePicture.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_pteARAllocationEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARAllocationEmployeePicture.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_pteARAllocationEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARAllocationEmployeePicture.FileName = null;
            this.fld_pteARAllocationEmployeePicture.FilePath = null;
            this.fld_pteARAllocationEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARAllocationEmployeePicture.Name = "fld_pteARAllocationEmployeePicture";
            this.fld_pteARAllocationEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARAllocationEmployeePicture.Screen = null;
            this.fld_pteARAllocationEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARAllocationEmployeePicture.TabIndex = 0;
            this.fld_pteARAllocationEmployeePicture.Tag = "DC";
            // 
            // fld_dteARAllocationDate
            // 
            this.fld_dteARAllocationDate.BOSComment = null;
            this.fld_dteARAllocationDate.BOSDataMember = "ARAllocationDate";
            this.fld_dteARAllocationDate.BOSDataSource = "ARAllocations";
            this.fld_dteARAllocationDate.BOSDescription = null;
            this.fld_dteARAllocationDate.BOSError = null;
            this.fld_dteARAllocationDate.BOSFieldGroup = null;
            this.fld_dteARAllocationDate.BOSFieldRelation = null;
            this.fld_dteARAllocationDate.BOSPrivilege = null;
            this.fld_dteARAllocationDate.BOSPropertyName = "EditValue";
            this.fld_dteARAllocationDate.EditValue = null;
            this.fld_dteARAllocationDate.Location = new System.Drawing.Point(218, 64);
            this.fld_dteARAllocationDate.MenuManager = this.screenToolbar;
            this.fld_dteARAllocationDate.Name = "fld_dteARAllocationDate";
            this.fld_dteARAllocationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARAllocationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARAllocationDate.Screen = null;
            this.fld_dteARAllocationDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARAllocationDate.TabIndex = 4;
            this.fld_dteARAllocationDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(136, 67);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.BOSLabel1.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(136, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARAllocationNo
            // 
            this.fld_txtARAllocationNo.BOSComment = null;
            this.fld_txtARAllocationNo.BOSDataMember = "ARAllocationNo";
            this.fld_txtARAllocationNo.BOSDataSource = "ARAllocations";
            this.fld_txtARAllocationNo.BOSDescription = null;
            this.fld_txtARAllocationNo.BOSError = null;
            this.fld_txtARAllocationNo.BOSFieldGroup = null;
            this.fld_txtARAllocationNo.BOSFieldRelation = null;
            this.fld_txtARAllocationNo.BOSPrivilege = null;
            this.fld_txtARAllocationNo.BOSPropertyName = "EditValue";
            this.fld_txtARAllocationNo.Location = new System.Drawing.Point(218, 12);
            this.fld_txtARAllocationNo.MenuManager = this.screenToolbar;
            this.fld_txtARAllocationNo.Name = "fld_txtARAllocationNo";
            this.fld_txtARAllocationNo.Screen = null;
            this.fld_txtARAllocationNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARAllocationNo.TabIndex = 0;
            this.fld_txtARAllocationNo.Tag = "DC";
            // 
            // fld_medARAllocationDesc
            // 
            this.fld_medARAllocationDesc.BOSComment = null;
            this.fld_medARAllocationDesc.BOSDataMember = "ARAllocationDesc";
            this.fld_medARAllocationDesc.BOSDataSource = "ARAllocations";
            this.fld_medARAllocationDesc.BOSDescription = null;
            this.fld_medARAllocationDesc.BOSError = null;
            this.fld_medARAllocationDesc.BOSFieldGroup = null;
            this.fld_medARAllocationDesc.BOSFieldRelation = null;
            this.fld_medARAllocationDesc.BOSPrivilege = null;
            this.fld_medARAllocationDesc.BOSPropertyName = "EditValue";
            this.fld_medARAllocationDesc.Location = new System.Drawing.Point(218, 116);
            this.fld_medARAllocationDesc.MenuManager = this.screenToolbar;
            this.fld_medARAllocationDesc.Name = "fld_medARAllocationDesc";
            this.fld_medARAllocationDesc.Screen = null;
            this.fld_medARAllocationDesc.Size = new System.Drawing.Size(431, 33);
            this.fld_medARAllocationDesc.TabIndex = 8;
            this.fld_medARAllocationDesc.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID123);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDriverEmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtARAllocationExpediencyQty);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRProposedEmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeARAllocationStatus);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtARAllocationName);
            this.bosPanel1.Controls.Add(this.fld_medARAllocationDesc);
            this.bosPanel1.Controls.Add(this.fld_pteARAllocationEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARAllocationNo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteARAllocationDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(664, 502);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_PMProjectID123
            // 
            this.fld_lkeFK_PMProjectID123.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID123.BOSAllowDummy = false;
            this.fld_lkeFK_PMProjectID123.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID123.BOSDataSource = "ARAllocations";
            this.fld_lkeFK_PMProjectID123.BOSDescription = null;
            this.fld_lkeFK_PMProjectID123.BOSError = null;
            this.fld_lkeFK_PMProjectID123.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID123.BOSSelectType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.BOSSelectTypeValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID123.Location = new System.Drawing.Point(478, 38);
            this.fld_lkeFK_PMProjectID123.Name = "fld_lkeFK_PMProjectID123";
            this.fld_lkeFK_PMProjectID123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID123.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID123.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID123.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID123.Properties.DisplayMember = "PMProjectName";
            this.fld_lkeFK_PMProjectID123.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_PMProjectID123.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID123.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID123.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID123.Screen = null;
            this.fld_lkeFK_PMProjectID123.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_PMProjectID123.TabIndex = 638;
            this.fld_lkeFK_PMProjectID123.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(417, 41);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 637;
            this.bosLabel7.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel7.Text = "Mã dự án";
            // 
            // fld_lkeFK_HRDriverEmployeeID
            // 
            this.fld_lkeFK_HRDriverEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDriverEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDriverEmployeeID.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSDataMember = "FK_HRDriverEmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.BOSDataSource = "ARAllocations";
            this.fld_lkeFK_HRDriverEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRDriverEmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDriverEmployeeID.BOSSelectType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.BOSSelectTypeValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.CurrentDisplayText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.Location = new System.Drawing.Point(478, 90);
            this.fld_lkeFK_HRDriverEmployeeID.Name = "fld_lkeFK_HRDriverEmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDriverEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.PurchaseOrderLocalizedResources.a, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRDriverEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRDriverEmployeeID.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.Screen = null;
            this.fld_lkeFK_HRDriverEmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRDriverEmployeeID.TabIndex = 7;
            this.fld_lkeFK_HRDriverEmployeeID.Tag = "DC";
            // 
            // fld_txtARAllocationExpediencyQty
            // 
            this.fld_txtARAllocationExpediencyQty.BOSComment = null;
            this.fld_txtARAllocationExpediencyQty.BOSDataMember = "ARAllocationExpediencyQty";
            this.fld_txtARAllocationExpediencyQty.BOSDataSource = "ARAllocations";
            this.fld_txtARAllocationExpediencyQty.BOSDescription = null;
            this.fld_txtARAllocationExpediencyQty.BOSError = null;
            this.fld_txtARAllocationExpediencyQty.BOSFieldGroup = null;
            this.fld_txtARAllocationExpediencyQty.BOSFieldRelation = null;
            this.fld_txtARAllocationExpediencyQty.BOSPrivilege = null;
            this.fld_txtARAllocationExpediencyQty.BOSPropertyName = "EditValue";
            this.fld_txtARAllocationExpediencyQty.Location = new System.Drawing.Point(218, 90);
            this.fld_txtARAllocationExpediencyQty.MenuManager = this.screenToolbar;
            this.fld_txtARAllocationExpediencyQty.Name = "fld_txtARAllocationExpediencyQty";
            this.fld_txtARAllocationExpediencyQty.Screen = null;
            this.fld_txtARAllocationExpediencyQty.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARAllocationExpediencyQty.TabIndex = 6;
            this.fld_txtARAllocationExpediencyQty.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(417, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 424;
            this.bosLabel6.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel6.Text = "Tài xế";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(136, 97);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(73, 13);
            this.bosLabel5.TabIndex = 423;
            this.bosLabel5.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel5.Text = "Số phương tiện";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(417, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(55, 13);
            this.bosLabel4.TabIndex = 422;
            this.bosLabel4.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel4.Text = "Người nhận";
            // 
            // fld_lkeFK_HRProposedEmployeeID
            // 
            this.fld_lkeFK_HRProposedEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRProposedEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRProposedEmployeeID.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSDataMember = "FK_HRProposedEmployeeID";
            this.fld_lkeFK_HRProposedEmployeeID.BOSDataSource = "ARAllocations";
            this.fld_lkeFK_HRProposedEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRProposedEmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HRProposedEmployeeID.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRProposedEmployeeID.BOSSelectType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.BOSSelectTypeValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.CurrentDisplayText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.Location = new System.Drawing.Point(478, 12);
            this.fld_lkeFK_HRProposedEmployeeID.Name = "fld_lkeFK_HRProposedEmployeeID";
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRProposedEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.PurchaseOrderLocalizedResources.a, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRProposedEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRProposedEmployeeID.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRProposedEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRProposedEmployeeID.Screen = null;
            this.fld_lkeFK_HRProposedEmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRProposedEmployeeID.TabIndex = 1;
            this.fld_lkeFK_HRProposedEmployeeID.Tag = "DC";
            // 
            // fld_lkeARAllocationStatus
            // 
            this.fld_lkeARAllocationStatus.BOSAllowAddNew = false;
            this.fld_lkeARAllocationStatus.BOSAllowDummy = false;
            this.fld_lkeARAllocationStatus.BOSComment = null;
            this.fld_lkeARAllocationStatus.BOSDataMember = "ARAllocationStatus";
            this.fld_lkeARAllocationStatus.BOSDataSource = "ARAllocations";
            this.fld_lkeARAllocationStatus.BOSDescription = null;
            this.fld_lkeARAllocationStatus.BOSError = null;
            this.fld_lkeARAllocationStatus.BOSFieldGroup = null;
            this.fld_lkeARAllocationStatus.BOSFieldParent = null;
            this.fld_lkeARAllocationStatus.BOSFieldRelation = null;
            this.fld_lkeARAllocationStatus.BOSPrivilege = null;
            this.fld_lkeARAllocationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARAllocationStatus.BOSSelectType = null;
            this.fld_lkeARAllocationStatus.BOSSelectTypeValue = null;
            this.fld_lkeARAllocationStatus.CurrentDisplayText = null;
            this.fld_lkeARAllocationStatus.Location = new System.Drawing.Point(478, 64);
            this.fld_lkeARAllocationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARAllocationStatus.Name = "fld_lkeARAllocationStatus";
            this.fld_lkeARAllocationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARAllocationStatus.Properties.ColumnName = null;
            this.fld_lkeARAllocationStatus.Properties.ReadOnly = true;
            this.fld_lkeARAllocationStatus.Screen = null;
            this.fld_lkeARAllocationStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARAllocationStatus.TabIndex = 5;
            this.fld_lkeARAllocationStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 170);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(648, 320);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xtraTabPage1.Controls.Add(this.bosLabel8);
            this.xtraTabPage1.Controls.Add(this.fld_dgcARAllocationItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(641, 291);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARAllocationItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Equipment;MMTB;VVP";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(95, 7);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã CCDC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên CCDC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(543, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 639;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp_1);
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
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
            this.bosLabel8.Location = new System.Drawing.Point(6, 10);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(80, 13);
            this.bosLabel8.TabIndex = 3;
            this.bosLabel8.Text = "Công cụ dụng cụ";
            // 
            // fld_dgcARAllocationItemsGridControl
            // 
            this.fld_dgcARAllocationItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARAllocationItemsGridControl.BOSComment = null;
            this.fld_dgcARAllocationItemsGridControl.BOSDataMember = null;
            this.fld_dgcARAllocationItemsGridControl.BOSDataSource = "ARAllocationItems";
            this.fld_dgcARAllocationItemsGridControl.BOSDescription = null;
            this.fld_dgcARAllocationItemsGridControl.BOSError = null;
            this.fld_dgcARAllocationItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARAllocationItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARAllocationItemsGridControl.BOSGridType = null;
            this.fld_dgcARAllocationItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARAllocationItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARAllocationItemsGridControl.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcARAllocationItemsGridControl.Location = new System.Drawing.Point(6, 37);
            this.fld_dgcARAllocationItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARAllocationItemsGridControl.Name = "fld_dgcARAllocationItemsGridControl";
            this.fld_dgcARAllocationItemsGridControl.PrintReport = false;
            this.fld_dgcARAllocationItemsGridControl.Screen = null;
            this.fld_dgcARAllocationItemsGridControl.Size = new System.Drawing.Size(632, 251);
            this.fld_dgcARAllocationItemsGridControl.TabIndex = 0;
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(136, 41);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 417;
            this.fld_lblLabel3.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtARAllocationName
            // 
            this.fld_txtARAllocationName.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtARAllocationName.BOSDataMember = "ARAllocationName";
            this.fld_txtARAllocationName.BOSDataSource = "ARAllocations";
            this.fld_txtARAllocationName.BOSDescription = null;
            this.fld_txtARAllocationName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtARAllocationName.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtARAllocationName.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtARAllocationName.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtARAllocationName.BOSPropertyName = "Text";
            this.fld_txtARAllocationName.Location = new System.Drawing.Point(218, 38);
            this.fld_txtARAllocationName.Name = "fld_txtARAllocationName";
            this.fld_txtARAllocationName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAllocationName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAllocationName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAllocationName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAllocationName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAllocationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAllocationName.Screen = null;
            this.fld_txtARAllocationName.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARAllocationName.TabIndex = 2;
            this.fld_txtARAllocationName.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(136, 119);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(27, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel9.Text = "Mô tả";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(417, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
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
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcACDocumentEntrys.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
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
            // DMAE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(664, 502);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARAllocationEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAllocationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAllocationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDriverEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationExpediencyQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProposedEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAllocationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAllocationItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAllocationName.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARAllocationDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARAllocationNo;
        private BOSComponent.BOSMemoEdit fld_medARAllocationDesc;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARAllocationName;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARAllocationItemsGridControl fld_dgcARAllocationItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARAllocationStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRProposedEmployeeID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARAllocationExpediencyQty;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDriverEmployeeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID123;
        private ItemLookupEdit fld_lkeFK_ICProductID;
	}
}
