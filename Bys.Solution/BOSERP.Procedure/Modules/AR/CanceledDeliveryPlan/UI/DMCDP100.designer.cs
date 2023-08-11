using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CanceledDeliveryPlan.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMCDP100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARCanceledDeliveryPlanEmployeePicture;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCDP100));
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARCanceledDeliveryPlanEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARCanceledDeliveryPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCanceledDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARAllocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel98 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACCostCenterID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARSaleContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel85 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDeliveryPlanType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARDeliveryPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCanceledDeliveryPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl = new BOSERP.Modules.CanceledDeliveryPlan.ARCanceledDeliveryPlanItemsGridControl();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCanceledDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCanceledDeliveryPlanEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCanceledDeliveryPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCanceledDeliveryPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCanceledDeliveryPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCanceledDeliveryPlanItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanName.Properties)).BeginInit();
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
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCanceledDeliveryPlans";
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
            // fld_pteARCanceledDeliveryPlanEmployeePicture
            // 
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSComment = "";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSDataMember = "ARCanceledDeliveryPlanEmployeePicture";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSDescription = null;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSError = "";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSPrivilege = "";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.FileName = null;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.FilePath = null;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Name = "fld_pteARCanceledDeliveryPlanEmployeePicture";
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Screen = null;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.TabIndex = 0;
            this.fld_pteARCanceledDeliveryPlanEmployeePicture.Tag = "DC";
            // 
            // fld_dteARCanceledDeliveryPlanDate
            // 
            this.fld_dteARCanceledDeliveryPlanDate.BOSComment = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSDataMember = "ARCanceledDeliveryPlanDate";
            this.fld_dteARCanceledDeliveryPlanDate.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_dteARCanceledDeliveryPlanDate.BOSDescription = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSError = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSFieldGroup = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSFieldRelation = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSPrivilege = null;
            this.fld_dteARCanceledDeliveryPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteARCanceledDeliveryPlanDate.EditValue = null;
            this.fld_dteARCanceledDeliveryPlanDate.Location = new System.Drawing.Point(478, 38);
            this.fld_dteARCanceledDeliveryPlanDate.MenuManager = this.screenToolbar;
            this.fld_dteARCanceledDeliveryPlanDate.Name = "fld_dteARCanceledDeliveryPlanDate";
            this.fld_dteARCanceledDeliveryPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCanceledDeliveryPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCanceledDeliveryPlanDate.Screen = null;
            this.fld_dteARCanceledDeliveryPlanDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARCanceledDeliveryPlanDate.TabIndex = 4;
            this.fld_dteARCanceledDeliveryPlanDate.Tag = "DC";
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
            this.BOSLabel1.Location = new System.Drawing.Point(400, 41);
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
            // fld_txtARCanceledDeliveryPlanNo
            // 
            this.fld_txtARCanceledDeliveryPlanNo.BOSComment = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSDataMember = "ARCanceledDeliveryPlanNo";
            this.fld_txtARCanceledDeliveryPlanNo.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_txtARCanceledDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSError = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSFieldGroup = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSFieldRelation = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSPrivilege = null;
            this.fld_txtARCanceledDeliveryPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtARCanceledDeliveryPlanNo.Location = new System.Drawing.Point(218, 12);
            this.fld_txtARCanceledDeliveryPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtARCanceledDeliveryPlanNo.Name = "fld_txtARCanceledDeliveryPlanNo";
            this.fld_txtARCanceledDeliveryPlanNo.Screen = null;
            this.fld_txtARCanceledDeliveryPlanNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARCanceledDeliveryPlanNo.TabIndex = 0;
            this.fld_txtARCanceledDeliveryPlanNo.Tag = "DC";
            // 
            // fld_medARAllocationDesc
            // 
            this.fld_medARAllocationDesc.BOSComment = null;
            this.fld_medARAllocationDesc.BOSDataMember = "ARCanceledDeliveryPlanDesc";
            this.fld_medARAllocationDesc.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_medARAllocationDesc.BOSDescription = null;
            this.fld_medARAllocationDesc.BOSError = null;
            this.fld_medARAllocationDesc.BOSFieldGroup = null;
            this.fld_medARAllocationDesc.BOSFieldRelation = null;
            this.fld_medARAllocationDesc.BOSPrivilege = null;
            this.fld_medARAllocationDesc.BOSPropertyName = "EditValue";
            this.fld_medARAllocationDesc.Location = new System.Drawing.Point(218, 90);
            this.fld_medARAllocationDesc.MenuManager = this.screenToolbar;
            this.fld_medARAllocationDesc.Name = "fld_medARAllocationDesc";
            this.fld_medARAllocationDesc.Screen = null;
            this.fld_medARAllocationDesc.Size = new System.Drawing.Size(431, 43);
            this.fld_medARAllocationDesc.TabIndex = 9;
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
            this.bosPanel1.Controls.Add(this.bosLabel98);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACCostCenterID);
            this.bosPanel1.Controls.Add(this.bosLabel38);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleContractID);
            this.bosPanel1.Controls.Add(this.bosLabel85);
            this.bosPanel1.Controls.Add(this.fld_lkeARDeliveryPlanType);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARDeliveryPlanID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeARCanceledDeliveryPlanStatus);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtARCanceledDeliveryPlanName);
            this.bosPanel1.Controls.Add(this.fld_medARAllocationDesc);
            this.bosPanel1.Controls.Add(this.fld_pteARCanceledDeliveryPlanEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARCanceledDeliveryPlanNo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteARCanceledDeliveryPlanDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(922, 468);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel98
            // 
            this.bosLabel98.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel98.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel98.Appearance.Options.UseBackColor = true;
            this.bosLabel98.Appearance.Options.UseForeColor = true;
            this.bosLabel98.BOSComment = "";
            this.bosLabel98.BOSDataMember = "";
            this.bosLabel98.BOSDataSource = "";
            this.bosLabel98.BOSDescription = null;
            this.bosLabel98.BOSError = null;
            this.bosLabel98.BOSFieldGroup = "";
            this.bosLabel98.BOSFieldRelation = "";
            this.bosLabel98.BOSPrivilege = "";
            this.bosLabel98.BOSPropertyName = null;
            this.bosLabel98.Location = new System.Drawing.Point(663, 68);
            this.bosLabel98.Name = "bosLabel98";
            this.bosLabel98.Screen = null;
            this.bosLabel98.Size = new System.Drawing.Size(45, 13);
            this.bosLabel98.TabIndex = 719;
            this.bosLabel98.Tag = "";
            this.bosLabel98.Text = "TT chi phí";
            this.bosLabel98.Visible = false;
            // 
            // fld_lkeFK_ACCostCenterID
            // 
            this.fld_lkeFK_ACCostCenterID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCostCenterID.BOSAllowDummy = false;
            this.fld_lkeFK_ACCostCenterID.BOSComment = null;
            this.fld_lkeFK_ACCostCenterID.BOSDataMember = "FK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.BOSDataSource = "ARCanceledDeliveryPlans";
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
            this.fld_lkeFK_ACCostCenterID.Location = new System.Drawing.Point(729, 65);
            this.fld_lkeFK_ACCostCenterID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACCostCenterID.Name = "fld_lkeFK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCostCenterID.Properties.ColumnName = null;
            this.fld_lkeFK_ACCostCenterID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterName", "Trung tâm chi phí")});
            this.fld_lkeFK_ACCostCenterID.Properties.DisplayMember = "ACCostCenterName";
            this.fld_lkeFK_ACCostCenterID.Properties.NullText = "";
            this.fld_lkeFK_ACCostCenterID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACCostCenterID.Properties.ValueMember = "ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACCostCenterID, true);
            this.fld_lkeFK_ACCostCenterID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACCostCenterID.TabIndex = 8;
            this.fld_lkeFK_ACCostCenterID.Tag = "DC";
            this.fld_lkeFK_ACCostCenterID.Visible = false;
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.Options.UseBackColor = true;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = "";
            this.bosLabel38.BOSDataMember = "";
            this.bosLabel38.BOSDataSource = "";
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = "";
            this.bosLabel38.BOSFieldRelation = "";
            this.bosLabel38.BOSPrivilege = "";
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.Location = new System.Drawing.Point(663, 15);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(29, 13);
            this.bosLabel38.TabIndex = 718;
            this.bosLabel38.Tag = "";
            this.bosLabel38.Text = "Dự án";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = null;
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = null;
            this.fld_lkeFK_PMProjectID.BOSFieldParent = null;
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = null;
            this.fld_lkeFK_PMProjectID.BOSPrivilege = null;
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(729, 12);
            this.fld_lkeFK_PMProjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã d? án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên d? án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectDesc", "Mô t?")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_PMProjectID, true);
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 6;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // fld_lkeFK_ARSaleContractID
            // 
            this.fld_lkeFK_ARSaleContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleContractID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleContractID.BOSComment = "";
            this.fld_lkeFK_ARSaleContractID.BOSDataMember = "FK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeFK_ARSaleContractID.BOSDescription = null;
            this.fld_lkeFK_ARSaleContractID.BOSError = null;
            this.fld_lkeFK_ARSaleContractID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldParent = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleContractID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleContractID.BOSSelectType = "";
            this.fld_lkeFK_ARSaleContractID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARSaleContractID.CurrentDisplayText = "";
            this.fld_lkeFK_ARSaleContractID.Location = new System.Drawing.Point(729, 39);
            this.fld_lkeFK_ARSaleContractID.Name = "fld_lkeFK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleContractID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractName", "Tên hợp đồng")});
            this.fld_lkeFK_ARSaleContractID.Properties.DisplayMember = "ARSaleContractNo";
            this.fld_lkeFK_ARSaleContractID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleContractID.Properties.ValueMember = "ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Screen = null;
            this.fld_lkeFK_ARSaleContractID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleContractID.TabIndex = 7;
            this.fld_lkeFK_ARSaleContractID.Tag = "DC";
            // 
            // bosLabel85
            // 
            this.bosLabel85.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.Options.UseBackColor = true;
            this.bosLabel85.Appearance.Options.UseForeColor = true;
            this.bosLabel85.BOSComment = null;
            this.bosLabel85.BOSDataMember = null;
            this.bosLabel85.BOSDataSource = null;
            this.bosLabel85.BOSDescription = null;
            this.bosLabel85.BOSError = null;
            this.bosLabel85.BOSFieldGroup = null;
            this.bosLabel85.BOSFieldRelation = null;
            this.bosLabel85.BOSPrivilege = null;
            this.bosLabel85.BOSPropertyName = null;
            this.bosLabel85.Location = new System.Drawing.Point(663, 42);
            this.bosLabel85.Name = "bosLabel85";
            this.bosLabel85.Screen = null;
            this.bosLabel85.Size = new System.Drawing.Size(60, 13);
            this.bosLabel85.TabIndex = 717;
            this.bosLabel85.Text = "Số hợp đồng";
            // 
            // fld_lkeARDeliveryPlanType
            // 
            this.fld_lkeARDeliveryPlanType.BOSAllowAddNew = false;
            this.fld_lkeARDeliveryPlanType.BOSAllowDummy = true;
            this.fld_lkeARDeliveryPlanType.BOSComment = "";
            this.fld_lkeARDeliveryPlanType.BOSDataMember = "ARCanceledDeliveryPlanType";
            this.fld_lkeARDeliveryPlanType.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeARDeliveryPlanType.BOSDescription = null;
            this.fld_lkeARDeliveryPlanType.BOSError = null;
            this.fld_lkeARDeliveryPlanType.BOSFieldGroup = "";
            this.fld_lkeARDeliveryPlanType.BOSFieldParent = "";
            this.fld_lkeARDeliveryPlanType.BOSFieldRelation = "";
            this.fld_lkeARDeliveryPlanType.BOSPrivilege = "";
            this.fld_lkeARDeliveryPlanType.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanType.BOSSelectType = "";
            this.fld_lkeARDeliveryPlanType.BOSSelectTypeValue = "";
            this.fld_lkeARDeliveryPlanType.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanType.Location = new System.Drawing.Point(478, 64);
            this.fld_lkeARDeliveryPlanType.Name = "fld_lkeARDeliveryPlanType";
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanType.Properties.ColumnName = null;
            this.fld_lkeARDeliveryPlanType.Properties.NullText = "";
            this.fld_lkeARDeliveryPlanType.Properties.PopupWidth = 40;
            this.fld_lkeARDeliveryPlanType.Properties.ReadOnly = true;
            this.fld_lkeARDeliveryPlanType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDeliveryPlanType.Screen = null;
            this.fld_lkeARDeliveryPlanType.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARDeliveryPlanType.TabIndex = 5;
            this.fld_lkeARDeliveryPlanType.Tag = "DC";
            this.fld_lkeARDeliveryPlanType.Visible = false;
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(400, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(57, 13);
            this.bosLabel5.TabIndex = 424;
            this.bosLabel5.Text = "Loại đề nghị";
            this.bosLabel5.Visible = false;
            // 
            // fld_lkeFK_ARDeliveryPlanID
            // 
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowDummy = true;
            this.fld_lkeFK_ARDeliveryPlanID.BOSComment = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataMember = "FK_ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDescription = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSError = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldGroup = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldParent = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldRelation = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSPrivilege = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectType = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARDeliveryPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_ARDeliveryPlanID.Location = new System.Drawing.Point(218, 64);
            this.fld_lkeFK_ARDeliveryPlanID.Name = "fld_lkeFK_ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ColumnName = null;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.DisplayMember = "ARDeliveryPlanNo";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.NullText = "";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ReadOnly = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ValueMember = "ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Screen = null;
            this.fld_lkeFK_ARDeliveryPlanID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ARDeliveryPlanID.TabIndex = 2;
            this.fld_lkeFK_ARDeliveryPlanID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(136, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(27, 13);
            this.bosLabel4.TabIndex = 421;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "ĐNXK";
            // 
            // fld_lkeARCanceledDeliveryPlanStatus
            // 
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSAllowDummy = false;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSComment = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSDataMember = "ARCanceledDeliveryPlanStatus";
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSDescription = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSError = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSFieldGroup = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSFieldParent = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSFieldRelation = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSPrivilege = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSSelectType = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.BOSSelectTypeValue = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.CurrentDisplayText = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.Location = new System.Drawing.Point(478, 12);
            this.fld_lkeARCanceledDeliveryPlanStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARCanceledDeliveryPlanStatus.Name = "fld_lkeARCanceledDeliveryPlanStatus";
            this.fld_lkeARCanceledDeliveryPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCanceledDeliveryPlanStatus.Properties.ColumnName = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.Properties.ReadOnly = true;
            this.fld_lkeARCanceledDeliveryPlanStatus.Screen = null;
            this.fld_lkeARCanceledDeliveryPlanStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARCanceledDeliveryPlanStatus.TabIndex = 3;
            this.fld_lkeARCanceledDeliveryPlanStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 139);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(906, 317);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARCanceledDeliveryPlanItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(904, 292);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcARCanceledDeliveryPlanItemsGridControl
            // 
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSComment = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSDataMember = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSDataSource = "ARCanceledDeliveryPlanItems";
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSDescription = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSError = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSGridType = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.CommodityType = "";
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.Name = "fld_dgcARCanceledDeliveryPlanItemsGridControl";
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.PrintReport = false;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.Screen = null;
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.Size = new System.Drawing.Size(895, 286);
            this.fld_dgcARCanceledDeliveryPlanItemsGridControl.TabIndex = 0;
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
            // fld_txtARCanceledDeliveryPlanName
            // 
            this.fld_txtARCanceledDeliveryPlanName.BOSComment = "";
            this.fld_txtARCanceledDeliveryPlanName.BOSDataMember = "ARCanceledDeliveryPlanName";
            this.fld_txtARCanceledDeliveryPlanName.BOSDataSource = "ARCanceledDeliveryPlans";
            this.fld_txtARCanceledDeliveryPlanName.BOSDescription = null;
            this.fld_txtARCanceledDeliveryPlanName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtARCanceledDeliveryPlanName.BOSFieldGroup = "";
            this.fld_txtARCanceledDeliveryPlanName.BOSFieldRelation = "";
            this.fld_txtARCanceledDeliveryPlanName.BOSPrivilege = "";
            this.fld_txtARCanceledDeliveryPlanName.BOSPropertyName = "Text";
            this.fld_txtARCanceledDeliveryPlanName.Location = new System.Drawing.Point(218, 38);
            this.fld_txtARCanceledDeliveryPlanName.Name = "fld_txtARCanceledDeliveryPlanName";
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCanceledDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCanceledDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCanceledDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCanceledDeliveryPlanName.Screen = null;
            this.fld_txtARCanceledDeliveryPlanName.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARCanceledDeliveryPlanName.TabIndex = 1;
            this.fld_txtARCanceledDeliveryPlanName.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(136, 93);
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
            this.bosLabel3.Location = new System.Drawing.Point(400, 15);
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
            // DMCDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(922, 468);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCDP100.IconOptions.Icon")));
            this.Name = "DMCDP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCanceledDeliveryPlanEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCanceledDeliveryPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCanceledDeliveryPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCanceledDeliveryPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCanceledDeliveryPlanItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCanceledDeliveryPlanName.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARCanceledDeliveryPlanDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARCanceledDeliveryPlanNo;
        private BOSComponent.BOSMemoEdit fld_medARAllocationDesc;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARCanceledDeliveryPlanName;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARCanceledDeliveryPlanItemsGridControl fld_dgcARCanceledDeliveryPlanItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARCanceledDeliveryPlanStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARDeliveryPlanID;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanType;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel98;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCostCenterID;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleContractID;
        private BOSComponent.BOSLabel bosLabel85;
	}
}
