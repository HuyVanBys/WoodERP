using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CancelPurchaseProposal.UI
{
	/// <summary>
	/// Summary description for DMCPCPS100
	/// </summary>
	partial class DMCPCPS100
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCPCPS100));
            this.fld_dteAPCancelPurchaseProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPCancelPurchaseProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPCancelPurchaseProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcAPCancelPurchaseProposalItems = new BOSERP.Modules.CancelPurchaseProposal.APCancelPurchaseProposalItemsGridControl();
            this.fld_dgvAPCancelPurchaseProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeAPCancelPurchaseProposalReasonType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPCancelPurchaseProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medAPCancelPurchaseProposalComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medAPCancelPurchaseProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteAPCancelPurchaseProposalEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposalItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalReasonType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseProposalComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalEmployeePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dteAPCancelPurchaseProposalDate
            // 
            this.fld_dteAPCancelPurchaseProposalDate.BOSComment = "";
            this.fld_dteAPCancelPurchaseProposalDate.BOSDataMember = "APCancelPurchaseProposalDate";
            this.fld_dteAPCancelPurchaseProposalDate.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_dteAPCancelPurchaseProposalDate.BOSDescription = null;
            this.fld_dteAPCancelPurchaseProposalDate.BOSError = null;
            this.fld_dteAPCancelPurchaseProposalDate.BOSFieldGroup = "";
            this.fld_dteAPCancelPurchaseProposalDate.BOSFieldRelation = "";
            this.fld_dteAPCancelPurchaseProposalDate.BOSPrivilege = "";
            this.fld_dteAPCancelPurchaseProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteAPCancelPurchaseProposalDate.EditValue = null;
            this.fld_dteAPCancelPurchaseProposalDate.Location = new System.Drawing.Point(489, 12);
            this.fld_dteAPCancelPurchaseProposalDate.Name = "fld_dteAPCancelPurchaseProposalDate";
            this.fld_dteAPCancelPurchaseProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPCancelPurchaseProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPCancelPurchaseProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPCancelPurchaseProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPCancelPurchaseProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPCancelPurchaseProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPCancelPurchaseProposalDate.Screen = null;
            this.fld_dteAPCancelPurchaseProposalDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteAPCancelPurchaseProposalDate.TabIndex = 3;
            this.fld_dteAPCancelPurchaseProposalDate.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APCancelPurchaseProposals";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(206, 38);
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
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 5;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            this.fld_lkeFK_BRBranchID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_BRBranchID_CloseUp);
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APCancelPurchaseProposals";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 111);
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
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(107, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeAPCancelPurchaseProposalType
            // 
            this.fld_lkeAPCancelPurchaseProposalType.BOSAllowAddNew = false;
            this.fld_lkeAPCancelPurchaseProposalType.BOSAllowDummy = false;
            this.fld_lkeAPCancelPurchaseProposalType.BOSComment = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSDataMember = "APCancelPurchaseProposalType";
            this.fld_lkeAPCancelPurchaseProposalType.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_lkeAPCancelPurchaseProposalType.BOSDescription = null;
            this.fld_lkeAPCancelPurchaseProposalType.BOSError = null;
            this.fld_lkeAPCancelPurchaseProposalType.BOSFieldGroup = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSFieldParent = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSFieldRelation = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSPrivilege = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeAPCancelPurchaseProposalType.BOSSelectType = "";
            this.fld_lkeAPCancelPurchaseProposalType.BOSSelectTypeValue = "";
            this.fld_lkeAPCancelPurchaseProposalType.CurrentDisplayText = "";
            this.fld_lkeAPCancelPurchaseProposalType.Location = new System.Drawing.Point(489, 38);
            this.fld_lkeAPCancelPurchaseProposalType.Name = "fld_lkeAPCancelPurchaseProposalType";
            this.fld_lkeAPCancelPurchaseProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPCancelPurchaseProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPCancelPurchaseProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPCancelPurchaseProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPCancelPurchaseProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPCancelPurchaseProposalType.Properties.ColumnName = null;
            this.fld_lkeAPCancelPurchaseProposalType.Properties.NullText = "";
            this.fld_lkeAPCancelPurchaseProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPCancelPurchaseProposalType.Screen = null;
            this.fld_lkeAPCancelPurchaseProposalType.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeAPCancelPurchaseProposalType.TabIndex = 6;
            this.fld_lkeAPCancelPurchaseProposalType.Tag = "DC";
            this.fld_lkeAPCancelPurchaseProposalType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPCancelPurchaseProposalType_CloseUp);
            // 
            // fld_txtAPCancelPurchaseProposalNo
            // 
            this.fld_txtAPCancelPurchaseProposalNo.BOSComment = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSDataMember = "APCancelPurchaseProposalNo";
            this.fld_txtAPCancelPurchaseProposalNo.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_txtAPCancelPurchaseProposalNo.BOSDescription = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSError = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSFieldGroup = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSFieldRelation = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSPrivilege = null;
            this.fld_txtAPCancelPurchaseProposalNo.BOSPropertyName = "EditValue";
            this.fld_txtAPCancelPurchaseProposalNo.Location = new System.Drawing.Point(206, 12);
            this.fld_txtAPCancelPurchaseProposalNo.MenuManager = this.screenToolbar;
            this.fld_txtAPCancelPurchaseProposalNo.Name = "fld_txtAPCancelPurchaseProposalNo";
            this.fld_txtAPCancelPurchaseProposalNo.Screen = null;
            this.fld_txtAPCancelPurchaseProposalNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtAPCancelPurchaseProposalNo.TabIndex = 2;
            this.fld_txtAPCancelPurchaseProposalNo.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(405, 41);
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
            this.bosLabel7.Location = new System.Drawing.Point(405, 15);
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
            this.bosLabel4.Location = new System.Drawing.Point(130, 41);
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
            this.bosLabel1.Location = new System.Drawing.Point(130, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_pteAPCancelPurchaseProposalItemProductPicture);
            this.bosGroupControl2.Controls.Add(this.fld_dgcAPCancelPurchaseProposalItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 153);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(991, 319);
            this.bosGroupControl2.TabIndex = 12;
            this.bosGroupControl2.Text = "Danh sách sản phẩm";
            // 
            // fld_pteAPCancelPurchaseProposalItemProductPicture
            // 
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSComment = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDataMember = "APCancelPurchaseProposalItemProductPicture";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDataSource = "APCancelPurchaseProposalItems";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDescription = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSError = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSFieldGroup = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSFieldRelation = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSPrivilege = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.FileName = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.FilePath = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Location = new System.Drawing.Point(851, 25);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Name = "fld_pteAPCancelPurchaseProposalItemProductPicture";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Screen = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Size = new System.Drawing.Size(135, 130);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.TabIndex = 2;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Tag = "DC";
            // 
            // fld_dgcAPCancelPurchaseProposalItems
            // 
            this.fld_dgcAPCancelPurchaseProposalItems.AllowDrop = true;
            this.fld_dgcAPCancelPurchaseProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPCancelPurchaseProposalItems.BOSComment = "";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSDataMember = "";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSDataSource = "APCancelPurchaseProposalItems";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSDescription = null;
            this.fld_dgcAPCancelPurchaseProposalItems.BOSError = null;
            this.fld_dgcAPCancelPurchaseProposalItems.BOSFieldGroup = "Accept";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSFieldRelation = "";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSGridType = null;
            this.fld_dgcAPCancelPurchaseProposalItems.BOSPrivilege = "";
            this.fld_dgcAPCancelPurchaseProposalItems.BOSPropertyName = null;
            this.fld_dgcAPCancelPurchaseProposalItems.CommodityType = "";
            this.fld_dgcAPCancelPurchaseProposalItems.Font = new System.Drawing.Font("Arial", 8.25F);
            gridLevelNode1.RelationName = "Level1";
            this.fld_dgcAPCancelPurchaseProposalItems.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.fld_dgcAPCancelPurchaseProposalItems.Location = new System.Drawing.Point(9, 25);
            this.fld_dgcAPCancelPurchaseProposalItems.MainView = this.fld_dgvAPCancelPurchaseProposalItems;
            this.fld_dgcAPCancelPurchaseProposalItems.Name = "fld_dgcAPCancelPurchaseProposalItems";
            this.fld_dgcAPCancelPurchaseProposalItems.PrintReport = false;
            this.fld_dgcAPCancelPurchaseProposalItems.Screen = null;
            this.fld_dgcAPCancelPurchaseProposalItems.Size = new System.Drawing.Size(836, 283);
            this.fld_dgcAPCancelPurchaseProposalItems.TabIndex = 1;
            this.fld_dgcAPCancelPurchaseProposalItems.Tag = "DC";
            this.fld_dgcAPCancelPurchaseProposalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPCancelPurchaseProposalItems});
            // 
            // fld_dgvAPCancelPurchaseProposalItems
            // 
            this.fld_dgvAPCancelPurchaseProposalItems.GridControl = this.fld_dgcAPCancelPurchaseProposalItems;
            this.fld_dgvAPCancelPurchaseProposalItems.Name = "fld_dgvAPCancelPurchaseProposalItems";
            this.fld_dgvAPCancelPurchaseProposalItems.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_lkeAPCancelPurchaseProposalReasonType);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosMemoEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeAPCancelPurchaseProposalStatus);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_medAPCancelPurchaseProposalDesc);
            this.bosPanel1.Controls.Add(this.fld_dteAPCancelPurchaseProposalDate);
            this.bosPanel1.Controls.Add(this.fld_pteAPCancelPurchaseProposalEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeAPCancelPurchaseProposalType);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtAPCancelPurchaseProposalNo);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(997, 609);
            this.bosPanel1.TabIndex = 8;
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
            this.bosLabel17.Location = new System.Drawing.Point(679, 127);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(94, 13);
            this.bosLabel17.TabIndex = 653;
            this.bosLabel17.Text = "Mã đơn hàng nội bộ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "MMBatchProductSOName";
            this.bosTextBox1.BOSDataSource = "APCancelPurchaseProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Enabled = false;
            this.bosTextBox1.Location = new System.Drawing.Point(781, 124);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(154, 20);
            this.bosTextBox1.TabIndex = 652;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeAPCancelPurchaseProposalReasonType
            // 
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSAllowAddNew = false;
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSAllowDummy = false;
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSComment = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSDataMember = "APCancelPurchaseProposalReasonType";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSDescription = null;
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSError = null;
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSFieldGroup = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSFieldParent = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSFieldRelation = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSPrivilege = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSPropertyName = "EditValue";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSSelectType = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.BOSSelectTypeValue = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.CurrentDisplayText = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.Location = new System.Drawing.Point(781, 64);
            this.fld_lkeAPCancelPurchaseProposalReasonType.Name = "fld_lkeAPCancelPurchaseProposalReasonType";
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.ColumnName = null;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.NullText = "";
            this.fld_lkeAPCancelPurchaseProposalReasonType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Screen = null;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeAPCancelPurchaseProposalReasonType.TabIndex = 587;
            this.fld_lkeAPCancelPurchaseProposalReasonType.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(679, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 588;
            this.bosLabel2.Text = "Lý do hủy";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = null;
            this.bosMemoEdit1.BOSDataMember = "APCancelPurchaseProposalReference";
            this.bosMemoEdit1.BOSDataSource = "APCancelPurchaseProposals";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = null;
            this.bosMemoEdit1.BOSFieldRelation = null;
            this.bosMemoEdit1.BOSPrivilege = null;
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.Location = new System.Drawing.Point(781, 90);
            this.bosMemoEdit1.MenuManager = this.screenToolbar;
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(154, 28);
            this.bosMemoEdit1.TabIndex = 586;
            this.bosMemoEdit1.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(679, 92);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(52, 13);
            this.bosLabel9.TabIndex = 585;
            this.bosLabel9.Text = "Mã đề nghị";
            // 
            // fld_lkeAPCancelPurchaseProposalStatus
            // 
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSAllowDummy = false;
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSComment = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSDataMember = "APCancelPurchaseProposalStatus";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSDescription = null;
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSError = null;
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSFieldGroup = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSFieldParent = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSFieldRelation = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSPrivilege = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSSelectType = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.BOSSelectTypeValue = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.CurrentDisplayText = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.Location = new System.Drawing.Point(206, 64);
            this.fld_lkeAPCancelPurchaseProposalStatus.Name = "fld_lkeAPCancelPurchaseProposalStatus";
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.ColumnName = null;
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.NullText = "";
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.ReadOnly = true;
            this.fld_lkeAPCancelPurchaseProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPCancelPurchaseProposalStatus.Screen = null;
            this.fld_lkeAPCancelPurchaseProposalStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeAPCancelPurchaseProposalStatus.TabIndex = 8;
            this.fld_lkeAPCancelPurchaseProposalStatus.Tag = "DC";
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
            this.bosLabel19.Location = new System.Drawing.Point(679, 41);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(60, 13);
            this.bosLabel19.TabIndex = 583;
            this.bosLabel19.Text = "Số hợp đồng";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "APCancelPurchaseProposalPONo";
            this.bosTextBox2.BOSDataSource = "APCancelPurchaseProposals";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(781, 38);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(154, 20);
            this.bosTextBox2.TabIndex = 10;
            this.bosTextBox2.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(405, 67);
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
            this.bosLabel6.Location = new System.Drawing.Point(679, 15);
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
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "APCancelPurchaseProposals";
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
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(489, 64);
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
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 9;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = "";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "APCancelPurchaseProposals";
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
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(781, 12);
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
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 4;
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
            this.bosLine1.Controls.Add(this.fld_medAPCancelPurchaseProposalComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 478);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(317, 119);
            this.bosLine1.TabIndex = 13;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medAPCancelPurchaseProposalComment
            // 
            this.fld_medAPCancelPurchaseProposalComment.BOSComment = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSDataMember = "APCancelPurchaseProposalComment";
            this.fld_medAPCancelPurchaseProposalComment.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_medAPCancelPurchaseProposalComment.BOSDescription = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSError = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSFieldGroup = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSFieldRelation = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSPrivilege = null;
            this.fld_medAPCancelPurchaseProposalComment.BOSPropertyName = "Text";
            this.fld_medAPCancelPurchaseProposalComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_medAPCancelPurchaseProposalComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medAPCancelPurchaseProposalComment.MenuManager = this.screenToolbar;
            this.fld_medAPCancelPurchaseProposalComment.Name = "fld_medAPCancelPurchaseProposalComment";
            this.fld_medAPCancelPurchaseProposalComment.Screen = null;
            this.fld_medAPCancelPurchaseProposalComment.Size = new System.Drawing.Size(311, 96);
            this.fld_medAPCancelPurchaseProposalComment.TabIndex = 0;
            this.fld_medAPCancelPurchaseProposalComment.Tag = "DC";
            // 
            // fld_medAPCancelPurchaseProposalDesc
            // 
            this.fld_medAPCancelPurchaseProposalDesc.BOSComment = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSDataMember = "APCancelPurchaseProposalDesc";
            this.fld_medAPCancelPurchaseProposalDesc.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_medAPCancelPurchaseProposalDesc.BOSDescription = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSError = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSFieldGroup = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSFieldRelation = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSPrivilege = null;
            this.fld_medAPCancelPurchaseProposalDesc.BOSPropertyName = "EditValue";
            this.fld_medAPCancelPurchaseProposalDesc.Location = new System.Drawing.Point(206, 90);
            this.fld_medAPCancelPurchaseProposalDesc.MenuManager = this.screenToolbar;
            this.fld_medAPCancelPurchaseProposalDesc.Name = "fld_medAPCancelPurchaseProposalDesc";
            this.fld_medAPCancelPurchaseProposalDesc.Screen = null;
            this.fld_medAPCancelPurchaseProposalDesc.Size = new System.Drawing.Size(454, 54);
            this.fld_medAPCancelPurchaseProposalDesc.TabIndex = 12;
            this.fld_medAPCancelPurchaseProposalDesc.Tag = "DC";
            // 
            // fld_pteAPCancelPurchaseProposalEmployeePicture
            // 
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSComment = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSDataMember = "APCancelPurchaseProposalEmployeePicture";
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSDataSource = "APCancelPurchaseProposals";
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSDescription = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSError = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSFieldGroup = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSPrivilege = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.FileName = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.FilePath = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Name = "fld_pteAPCancelPurchaseProposalEmployeePicture";
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Screen = null;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Size = new System.Drawing.Size(107, 102);
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.TabIndex = 0;
            this.fld_pteAPCancelPurchaseProposalEmployeePicture.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(130, 93);
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
            this.bosLabel3.Location = new System.Drawing.Point(130, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // DMCPCPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(997, 609);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCPCPS100.IconOptions.Icon")));
            this.Name = "DMCPCPS100";
            this.Text = "Phiếu hủy đề nghị mua hàng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposalItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalReasonType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseProposalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseProposalComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalEmployeePicture.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeAPCancelPurchaseProposalType;
        private BOSComponent.BOSTextBox fld_txtAPCancelPurchaseProposalNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPictureEdit fld_pteAPCancelPurchaseProposalItemProductPicture;
        private APCancelPurchaseProposalItemsGridControl fld_dgcAPCancelPurchaseProposalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPCancelPurchaseProposalItems;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSDateEdit fld_dteAPCancelPurchaseProposalDate;
        private BOSComponent.BOSPictureEdit fld_pteAPCancelPurchaseProposalEmployeePicture;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medAPCancelPurchaseProposalComment;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit fld_lkeAPCancelPurchaseProposalStatus;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSMemoEdit fld_medAPCancelPurchaseProposalDesc;
        private BOSComponent.BOSLookupEdit fld_lkeAPCancelPurchaseProposalReasonType;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox bosTextBox1;
    }
}
