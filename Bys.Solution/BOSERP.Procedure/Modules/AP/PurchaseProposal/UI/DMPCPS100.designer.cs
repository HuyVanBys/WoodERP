using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseProposal.UI
{
	/// <summary>
	/// Summary description for DMPCPS100
	/// </summary>
	partial class DMPCPS100
    {


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPCPS100));
            this.fld_dteAPProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medAPProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPPurchaseProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APPurchasingStaffID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPProposalReasonType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_btnChooseIngredients = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateInventoryStock = new BOSComponent.BOSButton(this.components);
            this.fld_linkViewApproval = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.fld_lkeFK_ARSaleContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tabProposalItems = new BOSComponent.BOSTabControl(this.components);
            this.xrTabOtherItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPProposalItems = new BOSERP.Modules.PurchaseProposal.APProposalItemsGridControl();
            this.fld_pteAPProposalItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPProposalItemTotals = new BOSERP.Modules.PurchaseProposal.APProposalItemTotalsGridControl();
            this.bosPictureEdit2 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID1 = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeAPProposalAPTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medAPProposalComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteAPProposalEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeAPPurchaseProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPProposalNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchasingStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalReasonType.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProposalItems)).BeginInit();
            this.fld_tabProposalItems.SuspendLayout();
            this.xrTabOtherItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPProposalItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalItemTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalAPTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPProposalComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPProposalEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseProposalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dteAPProposalDate
            // 
            this.fld_dteAPProposalDate.BOSComment = "";
            this.fld_dteAPProposalDate.BOSDataMember = "APProposalDate";
            this.fld_dteAPProposalDate.BOSDataSource = "APProposals";
            this.fld_dteAPProposalDate.BOSDescription = null;
            this.fld_dteAPProposalDate.BOSError = null;
            this.fld_dteAPProposalDate.BOSFieldGroup = "";
            this.fld_dteAPProposalDate.BOSFieldRelation = "";
            this.fld_dteAPProposalDate.BOSPrivilege = "";
            this.fld_dteAPProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteAPProposalDate.EditValue = null;
            this.fld_dteAPProposalDate.Location = new System.Drawing.Point(469, 9);
            this.fld_dteAPProposalDate.Name = "fld_dteAPProposalDate";
            this.fld_dteAPProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPProposalDate.Screen = null;
            this.fld_dteAPProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPProposalDate.TabIndex = 3;
            this.fld_dteAPProposalDate.Tag = "DC";
            // 
            // fld_medAPProposalDesc
            // 
            this.fld_medAPProposalDesc.BOSComment = null;
            this.fld_medAPProposalDesc.BOSDataMember = "APProposalDesc";
            this.fld_medAPProposalDesc.BOSDataSource = "APProposals";
            this.fld_medAPProposalDesc.BOSDescription = null;
            this.fld_medAPProposalDesc.BOSError = null;
            this.fld_medAPProposalDesc.BOSFieldGroup = null;
            this.fld_medAPProposalDesc.BOSFieldRelation = null;
            this.fld_medAPProposalDesc.BOSPrivilege = null;
            this.fld_medAPProposalDesc.BOSPropertyName = "EditValue";
            this.fld_medAPProposalDesc.Location = new System.Drawing.Point(206, 87);
            this.fld_medAPProposalDesc.MenuManager = this.screenToolbar;
            this.fld_medAPProposalDesc.Name = "fld_medAPProposalDesc";
            this.fld_medAPProposalDesc.Screen = null;
            this.fld_medAPProposalDesc.Size = new System.Drawing.Size(413, 46);
            this.fld_medAPProposalDesc.TabIndex = 14;
            this.fld_medAPProposalDesc.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APProposals";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = "";
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(206, 35);
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
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 6;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            this.fld_lkeFK_BRBranchID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_BRBranchID_CloseUp);
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(8, 115);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeAPPurchaseProposalType
            // 
            this.fld_lkeAPPurchaseProposalType.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseProposalType.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseProposalType.BOSComment = "";
            this.fld_lkeAPPurchaseProposalType.BOSDataMember = "APPurchaseProposalType";
            this.fld_lkeAPPurchaseProposalType.BOSDataSource = "APProposals";
            this.fld_lkeAPPurchaseProposalType.BOSDescription = null;
            this.fld_lkeAPPurchaseProposalType.BOSError = null;
            this.fld_lkeAPPurchaseProposalType.BOSFieldGroup = "";
            this.fld_lkeAPPurchaseProposalType.BOSFieldParent = "";
            this.fld_lkeAPPurchaseProposalType.BOSFieldRelation = "";
            this.fld_lkeAPPurchaseProposalType.BOSPrivilege = "";
            this.fld_lkeAPPurchaseProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseProposalType.BOSSelectType = "";
            this.fld_lkeAPPurchaseProposalType.BOSSelectTypeValue = "";
            this.fld_lkeAPPurchaseProposalType.CurrentDisplayText = "";
            this.fld_lkeAPPurchaseProposalType.Location = new System.Drawing.Point(469, 35);
            this.fld_lkeAPPurchaseProposalType.Name = "fld_lkeAPPurchaseProposalType";
            this.fld_lkeAPPurchaseProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseProposalType.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseProposalType.Properties.NullText = "";
            this.fld_lkeAPPurchaseProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseProposalType.Screen = null;
            this.fld_lkeAPPurchaseProposalType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseProposalType.TabIndex = 7;
            this.fld_lkeAPPurchaseProposalType.Tag = "DC";
            this.fld_lkeAPPurchaseProposalType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPPurchaseProposalType_CloseUp);
            // 
            // fld_txtAPProposalNo
            // 
            this.fld_txtAPProposalNo.BOSComment = null;
            this.fld_txtAPProposalNo.BOSDataMember = "APProposalNo";
            this.fld_txtAPProposalNo.BOSDataSource = "APProposals";
            this.fld_txtAPProposalNo.BOSDescription = null;
            this.fld_txtAPProposalNo.BOSError = null;
            this.fld_txtAPProposalNo.BOSFieldGroup = null;
            this.fld_txtAPProposalNo.BOSFieldRelation = null;
            this.fld_txtAPProposalNo.BOSPrivilege = null;
            this.fld_txtAPProposalNo.BOSPropertyName = "EditValue";
            this.fld_txtAPProposalNo.Location = new System.Drawing.Point(206, 9);
            this.fld_txtAPProposalNo.MenuManager = this.screenToolbar;
            this.fld_txtAPProposalNo.Name = "fld_txtAPProposalNo";
            this.fld_txtAPProposalNo.Screen = null;
            this.fld_txtAPProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPProposalNo.TabIndex = 2;
            this.fld_txtAPProposalNo.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(372, 39);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(57, 13);
            this.bosLabel8.TabIndex = 6;
            this.bosLabel8.Text = "Loại đề nghị";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(372, 13);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(130, 39);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Text = "Chi nhánh";
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
            this.bosLabel1.Location = new System.Drawing.Point(130, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APPurchasingStaffID);
            this.bosPanel1.Controls.Add(this.fld_lkeAPProposalReasonType);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleContractID);
            this.bosPanel1.Controls.Add(this.fld_tabProposalItems);
            this.bosPanel1.Controls.Add(this.bosDateEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosLookupEdit3);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_lkeAPProposalAPTypeCombo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_medAPProposalDesc);
            this.bosPanel1.Controls.Add(this.fld_dteAPProposalDate);
            this.bosPanel1.Controls.Add(this.fld_pteAPProposalEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPurchaseProposalStatus);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPurchaseProposalType);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtAPProposalNo);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1170, 712);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(910, 66);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(78, 13);
            this.bosLabel23.TabIndex = 649;
            this.bosLabel23.Text = "Người mua hàng";
            // 
            // fld_lkeFK_APPurchasingStaffID
            // 
            this.fld_lkeFK_APPurchasingStaffID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchasingStaffID.BOSAllowDummy = false;
            this.fld_lkeFK_APPurchasingStaffID.BOSComment = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSDataMember = "FK_APPurchasingStaffID";
            this.fld_lkeFK_APPurchasingStaffID.BOSDataSource = "APProposals";
            this.fld_lkeFK_APPurchasingStaffID.BOSDescription = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSError = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldGroup = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldParent = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSFieldRelation = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSPrivilege = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchasingStaffID.BOSSelectType = null;
            this.fld_lkeFK_APPurchasingStaffID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APPurchasingStaffID.CurrentDisplayText = null;
            this.fld_lkeFK_APPurchasingStaffID.Location = new System.Drawing.Point(993, 63);
            this.fld_lkeFK_APPurchasingStaffID.Name = "fld_lkeFK_APPurchasingStaffID";
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchasingStaffID.Properties.ColumnName = null;
            this.fld_lkeFK_APPurchasingStaffID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_APPurchasingStaffID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_APPurchasingStaffID.Properties.NullText = "";
            this.fld_lkeFK_APPurchasingStaffID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchasingStaffID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_APPurchasingStaffID.Screen = null;
            this.fld_lkeFK_APPurchasingStaffID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APPurchasingStaffID.TabIndex = 648;
            this.fld_lkeFK_APPurchasingStaffID.Tag = "DC";
            // 
            // fld_lkeAPProposalReasonType
            // 
            this.fld_lkeAPProposalReasonType.BOSAllowAddNew = false;
            this.fld_lkeAPProposalReasonType.BOSAllowDummy = false;
            this.fld_lkeAPProposalReasonType.BOSComment = "";
            this.fld_lkeAPProposalReasonType.BOSDataMember = "APProposalReasonType";
            this.fld_lkeAPProposalReasonType.BOSDataSource = "APProposals";
            this.fld_lkeAPProposalReasonType.BOSDescription = null;
            this.fld_lkeAPProposalReasonType.BOSError = null;
            this.fld_lkeAPProposalReasonType.BOSFieldGroup = "";
            this.fld_lkeAPProposalReasonType.BOSFieldParent = "";
            this.fld_lkeAPProposalReasonType.BOSFieldRelation = "";
            this.fld_lkeAPProposalReasonType.BOSPrivilege = "";
            this.fld_lkeAPProposalReasonType.BOSPropertyName = "EditValue";
            this.fld_lkeAPProposalReasonType.BOSSelectType = "";
            this.fld_lkeAPProposalReasonType.BOSSelectTypeValue = "";
            this.fld_lkeAPProposalReasonType.CurrentDisplayText = "";
            this.fld_lkeAPProposalReasonType.Location = new System.Drawing.Point(993, 36);
            this.fld_lkeAPProposalReasonType.Name = "fld_lkeAPProposalReasonType";
            this.fld_lkeAPProposalReasonType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPProposalReasonType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPProposalReasonType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPProposalReasonType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPProposalReasonType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPProposalReasonType.Properties.ColumnName = null;
            this.fld_lkeAPProposalReasonType.Properties.NullText = "";
            this.fld_lkeAPProposalReasonType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPProposalReasonType.Screen = null;
            this.fld_lkeAPProposalReasonType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPProposalReasonType.TabIndex = 9;
            this.fld_lkeAPProposalReasonType.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(910, 40);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(64, 13);
            this.bosLabel14.TabIndex = 602;
            this.bosLabel14.Text = "Lý do đề nghị";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_btnChooseIngredients);
            this.groupBox1.Controls.Add(this.fld_btnUpdateInventoryStock);
            this.groupBox1.Controls.Add(this.fld_linkViewApproval);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(910, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // fld_btnChooseIngredients
            // 
            this.fld_btnChooseIngredients.BOSComment = null;
            this.fld_btnChooseIngredients.BOSDataMember = null;
            this.fld_btnChooseIngredients.BOSDataSource = null;
            this.fld_btnChooseIngredients.BOSDescription = null;
            this.fld_btnChooseIngredients.BOSError = null;
            this.fld_btnChooseIngredients.BOSFieldGroup = null;
            this.fld_btnChooseIngredients.BOSFieldRelation = null;
            this.fld_btnChooseIngredients.BOSPrivilege = null;
            this.fld_btnChooseIngredients.BOSPropertyName = null;
            this.fld_btnChooseIngredients.Location = new System.Drawing.Point(8, 20);
            this.fld_btnChooseIngredients.Name = "fld_btnChooseIngredients";
            this.fld_btnChooseIngredients.Screen = null;
            this.fld_btnChooseIngredients.Size = new System.Drawing.Size(104, 22);
            this.fld_btnChooseIngredients.TabIndex = 0;
            this.fld_btnChooseIngredients.Text = "Chọn nguyên liệu";
            this.fld_btnChooseIngredients.Click += new System.EventHandler(this.fld_btnChooseIngredients_Click);
            // 
            // fld_btnUpdateInventoryStock
            // 
            this.fld_btnUpdateInventoryStock.BOSComment = null;
            this.fld_btnUpdateInventoryStock.BOSDataMember = null;
            this.fld_btnUpdateInventoryStock.BOSDataSource = null;
            this.fld_btnUpdateInventoryStock.BOSDescription = null;
            this.fld_btnUpdateInventoryStock.BOSError = null;
            this.fld_btnUpdateInventoryStock.BOSFieldGroup = null;
            this.fld_btnUpdateInventoryStock.BOSFieldRelation = null;
            this.fld_btnUpdateInventoryStock.BOSPrivilege = null;
            this.fld_btnUpdateInventoryStock.BOSPropertyName = null;
            this.fld_btnUpdateInventoryStock.Location = new System.Drawing.Point(118, 20);
            this.fld_btnUpdateInventoryStock.Name = "fld_btnUpdateInventoryStock";
            this.fld_btnUpdateInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateInventoryStock, true);
            this.fld_btnUpdateInventoryStock.Size = new System.Drawing.Size(104, 22);
            this.fld_btnUpdateInventoryStock.TabIndex = 1;
            this.fld_btnUpdateInventoryStock.Text = "Xem tồn kho";
            this.fld_btnUpdateInventoryStock.Click += new System.EventHandler(this.fld_btnUpdateInventoryStock_Click);
            // 
            // fld_linkViewApproval
            // 
            this.fld_linkViewApproval.Location = new System.Drawing.Point(51, 48);
            this.fld_linkViewApproval.Name = "fld_linkViewApproval";
            this.fld_linkViewApproval.Size = new System.Drawing.Size(118, 13);
            this.fld_linkViewApproval.TabIndex = 2;
            this.fld_linkViewApproval.Text = "Xem thông tin phê duyệt";
            this.fld_linkViewApproval.Click += new System.EventHandler(this.fld_linkViewApproval_Click);
            // 
            // fld_lkeFK_ARSaleContractID
            // 
            this.fld_lkeFK_ARSaleContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleContractID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleContractID.BOSComment = "";
            this.fld_lkeFK_ARSaleContractID.BOSDataMember = "FK_APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.BOSDataSource = "APProposals";
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
            this.fld_lkeFK_ARSaleContractID.Location = new System.Drawing.Point(206, 138);
            this.fld_lkeFK_ARSaleContractID.Name = "fld_lkeFK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleContractID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractName", "Tên hợp đồng")});
            this.fld_lkeFK_ARSaleContractID.Properties.DisplayMember = "APPurchaseContractNo";
            this.fld_lkeFK_ARSaleContractID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleContractID.Properties.ValueMember = "APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.Screen = null;
            this.fld_lkeFK_ARSaleContractID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleContractID.TabIndex = 13;
            this.fld_lkeFK_ARSaleContractID.Tag = "DC";
            // 
            // fld_tabProposalItems
            // 
            this.fld_tabProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProposalItems.BOSComment = null;
            this.fld_tabProposalItems.BOSDataMember = null;
            this.fld_tabProposalItems.BOSDataSource = null;
            this.fld_tabProposalItems.BOSDescription = null;
            this.fld_tabProposalItems.BOSError = null;
            this.fld_tabProposalItems.BOSFieldGroup = null;
            this.fld_tabProposalItems.BOSFieldRelation = null;
            this.fld_tabProposalItems.BOSPrivilege = null;
            this.fld_tabProposalItems.BOSPropertyName = null;
            this.fld_tabProposalItems.Location = new System.Drawing.Point(6, 166);
            this.fld_tabProposalItems.Name = "fld_tabProposalItems";
            this.fld_tabProposalItems.Screen = null;
            this.fld_tabProposalItems.SelectedTabPage = this.xrTabOtherItems;
            this.fld_tabProposalItems.Size = new System.Drawing.Size(1161, 457);
            this.fld_tabProposalItems.TabIndex = 18;
            this.fld_tabProposalItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xrTabOtherItems,
            this.xtraTabPage1});
            // 
            // xrTabOtherItems
            // 
            this.xrTabOtherItems.Controls.Add(this.fld_dgcAPProposalItems);
            this.xrTabOtherItems.Controls.Add(this.fld_pteAPProposalItemProductPicture);
            this.xrTabOtherItems.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.xrTabOtherItems.Controls.Add(this.bosLabel15);
            this.xrTabOtherItems.Name = "xrTabOtherItems";
            this.xrTabOtherItems.Size = new System.Drawing.Size(1159, 432);
            this.xrTabOtherItems.Text = "Danh sách chi tiết";
            // 
            // fld_dgcAPProposalItems
            // 
            this.fld_dgcAPProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPProposalItems.BOSComment = null;
            this.fld_dgcAPProposalItems.BOSDataMember = null;
            this.fld_dgcAPProposalItems.BOSDataSource = "APProposalItems";
            this.fld_dgcAPProposalItems.BOSDescription = null;
            this.fld_dgcAPProposalItems.BOSError = null;
            this.fld_dgcAPProposalItems.BOSFieldGroup = null;
            this.fld_dgcAPProposalItems.BOSFieldRelation = null;
            this.fld_dgcAPProposalItems.BOSGridType = null;
            this.fld_dgcAPProposalItems.BOSPrivilege = null;
            this.fld_dgcAPProposalItems.BOSPropertyName = null;
            this.fld_dgcAPProposalItems.CommodityType = "";
            this.fld_dgcAPProposalItems.Location = new System.Drawing.Point(10, 33);
            this.fld_dgcAPProposalItems.MenuManager = this.screenToolbar;
            this.fld_dgcAPProposalItems.Name = "fld_dgcAPProposalItems";
            this.fld_dgcAPProposalItems.PrintReport = false;
            this.fld_dgcAPProposalItems.Screen = null;
            this.fld_dgcAPProposalItems.Size = new System.Drawing.Size(1019, 392);
            this.fld_dgcAPProposalItems.TabIndex = 1;
            // 
            // fld_pteAPProposalItemProductPicture
            // 
            this.fld_pteAPProposalItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPProposalItemProductPicture.BOSComment = null;
            this.fld_pteAPProposalItemProductPicture.BOSDataMember = "APProposalItemProductPicture";
            this.fld_pteAPProposalItemProductPicture.BOSDataSource = "APProposalItems";
            this.fld_pteAPProposalItemProductPicture.BOSDescription = null;
            this.fld_pteAPProposalItemProductPicture.BOSError = null;
            this.fld_pteAPProposalItemProductPicture.BOSFieldGroup = null;
            this.fld_pteAPProposalItemProductPicture.BOSFieldRelation = null;
            this.fld_pteAPProposalItemProductPicture.BOSPrivilege = null;
            this.fld_pteAPProposalItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPProposalItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPProposalItemProductPicture.FileName = null;
            this.fld_pteAPProposalItemProductPicture.FilePath = null;
            this.fld_pteAPProposalItemProductPicture.Location = new System.Drawing.Point(1035, 7);
            this.fld_pteAPProposalItemProductPicture.Name = "fld_pteAPProposalItemProductPicture";
            this.fld_pteAPProposalItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPProposalItemProductPicture.Screen = null;
            this.fld_pteAPProposalItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteAPProposalItemProductPicture.TabIndex = 2;
            this.fld_pteAPProposalItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "APProposalItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(63, 7);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(966, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(10, 11);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(47, 13);
            this.bosLabel15.TabIndex = 29;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Sản phẩm";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPProposalItemTotals);
            this.xtraTabPage1.Controls.Add(this.bosPictureEdit2);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductAttributeID1);
            this.xtraTabPage1.Controls.Add(this.bosLabel16);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.PageVisible = false;
            this.xtraTabPage1.Size = new System.Drawing.Size(1145, 425);
            this.xtraTabPage1.Text = "Danh sách tổng";
            // 
            // fld_dgcAPProposalItemTotals
            // 
            this.fld_dgcAPProposalItemTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPProposalItemTotals.BOSComment = null;
            this.fld_dgcAPProposalItemTotals.BOSDataMember = null;
            this.fld_dgcAPProposalItemTotals.BOSDataSource = "APProposalItemTotals";
            this.fld_dgcAPProposalItemTotals.BOSDescription = null;
            this.fld_dgcAPProposalItemTotals.BOSError = null;
            this.fld_dgcAPProposalItemTotals.BOSFieldGroup = null;
            this.fld_dgcAPProposalItemTotals.BOSFieldRelation = null;
            this.fld_dgcAPProposalItemTotals.BOSGridType = null;
            this.fld_dgcAPProposalItemTotals.BOSPrivilege = null;
            this.fld_dgcAPProposalItemTotals.BOSPropertyName = null;
            this.fld_dgcAPProposalItemTotals.CommodityType = "";
            this.fld_dgcAPProposalItemTotals.Location = new System.Drawing.Point(10, 32);
            this.fld_dgcAPProposalItemTotals.MenuManager = this.screenToolbar;
            this.fld_dgcAPProposalItemTotals.Name = "fld_dgcAPProposalItemTotals";
            this.fld_dgcAPProposalItemTotals.PrintReport = false;
            this.fld_dgcAPProposalItemTotals.Screen = null;
            this.fld_dgcAPProposalItemTotals.Size = new System.Drawing.Size(1005, 385);
            this.fld_dgcAPProposalItemTotals.TabIndex = 34;
            // 
            // bosPictureEdit2
            // 
            this.bosPictureEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPictureEdit2.BOSComment = null;
            this.bosPictureEdit2.BOSDataMember = "APProposalItemProductPicture";
            this.bosPictureEdit2.BOSDataSource = "APProposalItems";
            this.bosPictureEdit2.BOSDescription = null;
            this.bosPictureEdit2.BOSError = null;
            this.bosPictureEdit2.BOSFieldGroup = null;
            this.bosPictureEdit2.BOSFieldRelation = null;
            this.bosPictureEdit2.BOSPrivilege = null;
            this.bosPictureEdit2.BOSPropertyName = "EditValue";
            this.bosPictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit2.FileName = null;
            this.bosPictureEdit2.FilePath = null;
            this.bosPictureEdit2.Location = new System.Drawing.Point(1021, 7);
            this.bosPictureEdit2.Name = "bosPictureEdit2";
            this.bosPictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit2.Screen = null;
            this.bosPictureEdit2.Size = new System.Drawing.Size(120, 120);
            this.bosPictureEdit2.TabIndex = 33;
            this.bosPictureEdit2.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID1
            // 
            this.fld_lkeFK_ICProductAttributeID1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID1.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID1.BOSDataSource = "APProposalItemTotals";
            this.fld_lkeFK_ICProductAttributeID1.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID1.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID1.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID1.Location = new System.Drawing.Point(63, 7);
            this.fld_lkeFK_ICProductAttributeID1.Name = "fld_lkeFK_ICProductAttributeID1";
            this.fld_lkeFK_ICProductAttributeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductAttributeID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID1.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductAttributeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID1.Screen = null;
            this.fld_lkeFK_ICProductAttributeID1.Size = new System.Drawing.Size(952, 20);
            this.fld_lkeFK_ICProductAttributeID1.TabIndex = 32;
            this.fld_lkeFK_ICProductAttributeID1.Tag = "DC";
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
            this.bosLabel16.Location = new System.Drawing.Point(10, 11);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(47, 13);
            this.bosLabel16.TabIndex = 31;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Sản phẩm";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = "";
            this.bosDateEdit2.BOSDataMember = "APProposalNeedToTime";
            this.bosDateEdit2.BOSDataSource = "APProposals";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = "";
            this.bosDateEdit2.BOSFieldRelation = "";
            this.bosDateEdit2.BOSPrivilege = "";
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(721, 113);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 16;
            this.bosDateEdit2.Tag = "DC";
            this.bosDateEdit2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosDateEdit2_CloseUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(638, 115);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 589;
            this.bosLabel13.Text = "Đến ngày";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(123, 143);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(60, 13);
            this.bosLabel19.TabIndex = 583;
            this.bosLabel19.Text = "Số hợp đồng";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "APProposalProposedEmployeeID";
            this.bosLookupEdit3.BOSDataSource = "APProposals";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(721, 61);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bô phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.bosLookupEdit3.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit3, true);
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 12;
            this.bosLookupEdit3.Tag = "DC";
            this.bosLookupEdit3.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit3_QueryPopUp);
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
            this.bosLabel12.Location = new System.Drawing.Point(638, 65);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(55, 13);
            this.bosLabel12.TabIndex = 36;
            this.bosLabel12.Text = "Người nhận";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = "";
            this.bosDateEdit1.BOSDataMember = "APProposalNeedTime";
            this.bosDateEdit1.BOSDataSource = "APProposals";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = "";
            this.bosDateEdit1.BOSFieldRelation = "";
            this.bosDateEdit1.BOSPrivilege = "";
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(721, 87);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 15;
            this.bosDateEdit1.Tag = "DC";
            this.bosDateEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosDateEdit1_CloseUp);
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(638, 91);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 34;
            this.bosLabel11.Text = "Từ ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(910, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(69, 13);
            this.bosLabel2.TabIndex = 32;
            this.bosLabel2.Text = "Mã tham chiếu";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "APProposalReference";
            this.bosTextBox1.BOSDataSource = "APProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(993, 10);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 5;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeAPProposalAPTypeCombo
            // 
            this.fld_lkeAPProposalAPTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPProposalAPTypeCombo.BOSAllowDummy = false;
            this.fld_lkeAPProposalAPTypeCombo.BOSComment = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSDataMember = "APProposalAPTypeCombo";
            this.fld_lkeAPProposalAPTypeCombo.BOSDataSource = "APProposals";
            this.fld_lkeAPProposalAPTypeCombo.BOSDescription = null;
            this.fld_lkeAPProposalAPTypeCombo.BOSError = null;
            this.fld_lkeAPProposalAPTypeCombo.BOSFieldGroup = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSFieldParent = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSFieldRelation = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSPrivilege = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPProposalAPTypeCombo.BOSSelectType = "";
            this.fld_lkeAPProposalAPTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPProposalAPTypeCombo.CurrentDisplayText = "";
            this.fld_lkeAPProposalAPTypeCombo.Location = new System.Drawing.Point(469, 61);
            this.fld_lkeAPProposalAPTypeCombo.Name = "fld_lkeAPProposalAPTypeCombo";
            this.fld_lkeAPProposalAPTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPProposalAPTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPProposalAPTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPProposalAPTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPProposalAPTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPProposalAPTypeCombo.Properties.ColumnName = null;
            this.fld_lkeAPProposalAPTypeCombo.Properties.NullText = "";
            this.fld_lkeAPProposalAPTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPProposalAPTypeCombo.Screen = null;
            this.fld_lkeAPProposalAPTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPProposalAPTypeCombo.TabIndex = 11;
            this.fld_lkeAPProposalAPTypeCombo.Tag = "DC";
            this.fld_lkeAPProposalAPTypeCombo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeAPProposalAPTypeCombo_CloseUp_1);
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(372, 65);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(67, 13);
            this.bosLabel9.TabIndex = 29;
            this.bosLabel9.Text = "Loại hàng hóa";
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
            this.bosLabel10.Location = new System.Drawing.Point(638, 13);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(51, 13);
            this.bosLabel10.TabIndex = 27;
            this.bosLabel10.Text = "Phòng ban";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(638, 39);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(39, 13);
            this.bosLabel6.TabIndex = 28;
            this.bosLabel6.Text = "Bộ phận";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "APProposals";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = "";
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(721, 9);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "APProposals";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(721, 35);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = "";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 8;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medAPProposalComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(4, 629);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(317, 74);
            this.bosLine1.TabIndex = 9;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medAPProposalComment
            // 
            this.fld_medAPProposalComment.BOSComment = null;
            this.fld_medAPProposalComment.BOSDataMember = "APProposalComment";
            this.fld_medAPProposalComment.BOSDataSource = "APProposals";
            this.fld_medAPProposalComment.BOSDescription = null;
            this.fld_medAPProposalComment.BOSError = null;
            this.fld_medAPProposalComment.BOSFieldGroup = null;
            this.fld_medAPProposalComment.BOSFieldRelation = null;
            this.fld_medAPProposalComment.BOSPrivilege = null;
            this.fld_medAPProposalComment.BOSPropertyName = "Text";
            this.fld_medAPProposalComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_medAPProposalComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medAPProposalComment.MenuManager = this.screenToolbar;
            this.fld_medAPProposalComment.Name = "fld_medAPProposalComment";
            this.fld_medAPProposalComment.Screen = null;
            this.fld_medAPProposalComment.Size = new System.Drawing.Size(311, 51);
            this.fld_medAPProposalComment.TabIndex = 0;
            this.fld_medAPProposalComment.Tag = "DC";
            // 
            // fld_pteAPProposalEmployeePicture
            // 
            this.fld_pteAPProposalEmployeePicture.BOSComment = null;
            this.fld_pteAPProposalEmployeePicture.BOSDataMember = "APProposalEmployeePicture";
            this.fld_pteAPProposalEmployeePicture.BOSDataSource = "APProposals";
            this.fld_pteAPProposalEmployeePicture.BOSDescription = null;
            this.fld_pteAPProposalEmployeePicture.BOSError = null;
            this.fld_pteAPProposalEmployeePicture.BOSFieldGroup = null;
            this.fld_pteAPProposalEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPProposalEmployeePicture.BOSPrivilege = null;
            this.fld_pteAPProposalEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPProposalEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPProposalEmployeePicture.FileName = null;
            this.fld_pteAPProposalEmployeePicture.FilePath = null;
            this.fld_pteAPProposalEmployeePicture.Location = new System.Drawing.Point(8, 11);
            this.fld_pteAPProposalEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteAPProposalEmployeePicture.Name = "fld_pteAPProposalEmployeePicture";
            this.fld_pteAPProposalEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPProposalEmployeePicture.Screen = null;
            this.fld_pteAPProposalEmployeePicture.Size = new System.Drawing.Size(100, 100);
            this.fld_pteAPProposalEmployeePicture.TabIndex = 0;
            this.fld_pteAPProposalEmployeePicture.Tag = "DC";
            // 
            // fld_lkeAPPurchaseProposalStatus
            // 
            this.fld_lkeAPPurchaseProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseProposalStatus.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseProposalStatus.BOSComment = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSDataMember = "APPurchaseProposalStatus";
            this.fld_lkeAPPurchaseProposalStatus.BOSDataSource = "APProposals";
            this.fld_lkeAPPurchaseProposalStatus.BOSDescription = null;
            this.fld_lkeAPPurchaseProposalStatus.BOSError = null;
            this.fld_lkeAPPurchaseProposalStatus.BOSFieldGroup = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSFieldParent = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSFieldRelation = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSPrivilege = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseProposalStatus.BOSSelectType = "";
            this.fld_lkeAPPurchaseProposalStatus.BOSSelectTypeValue = "";
            this.fld_lkeAPPurchaseProposalStatus.CurrentDisplayText = "";
            this.fld_lkeAPPurchaseProposalStatus.Location = new System.Drawing.Point(206, 61);
            this.fld_lkeAPPurchaseProposalStatus.Name = "fld_lkeAPPurchaseProposalStatus";
            this.fld_lkeAPPurchaseProposalStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPPurchaseProposalStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseProposalStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseProposalStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseProposalStatus.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseProposalStatus.Properties.NullText = "";
            this.fld_lkeAPPurchaseProposalStatus.Properties.ReadOnly = true;
            this.fld_lkeAPPurchaseProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseProposalStatus.Screen = null;
            this.fld_lkeAPPurchaseProposalStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseProposalStatus.TabIndex = 10;
            this.fld_lkeAPPurchaseProposalStatus.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(130, 89);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(130, 65);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "MMBatchProductSOName";
            this.bosTextBox2.BOSDataSource = "APProposals";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(721, 139);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 5;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(638, 144);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(64, 13);
            this.bosLabel17.TabIndex = 32;
            this.bosLabel17.Text = "Mã ĐH nội bộ";
            // 
            // DMPCPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1170, 712);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPCPS100.IconOptions.Icon")));
            this.Name = "DMPCPS100";
            this.Text = "Phiếu đề nghị mua hàng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPProposalNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchasingStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalReasonType.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProposalItems)).EndInit();
            this.fld_tabProposalItems.ResumeLayout(false);
            this.xrTabOtherItems.ResumeLayout(false);
            this.xrTabOtherItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPProposalItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalItemTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalAPTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPProposalComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPProposalEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseProposalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSMemoEdit fld_medAPProposalDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseProposalType;
        private BOSComponent.BOSTextBox fld_txtAPProposalNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSDateEdit fld_dteAPProposalDate;
        private BOSComponent.BOSPictureEdit fld_pteAPProposalEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseProposalStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medAPProposalComment;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeAPProposalAPTypeCombo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTabControl fld_tabProposalItems;
        private DevExpress.XtraTab.XtraTabPage xrTabOtherItems;
        private APProposalItemsGridControl fld_dgcAPProposalItems;
        private BOSComponent.BOSPictureEdit fld_pteAPProposalItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel15;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private APProposalItemTotalsGridControl fld_dgcAPProposalItemTotals;
        private BOSComponent.BOSPictureEdit bosPictureEdit2;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID1;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleContractID;
        private GroupBox groupBox1;
        private BOSComponent.BOSButton fld_btnChooseIngredients;
        private BOSComponent.BOSButton fld_btnUpdateInventoryStock;
        private DevExpress.XtraEditors.HyperlinkLabelControl fld_linkViewApproval;
        private BOSComponent.BOSLookupEdit fld_lkeAPProposalReasonType;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchasingStaffID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox bosTextBox2;
    }
}
