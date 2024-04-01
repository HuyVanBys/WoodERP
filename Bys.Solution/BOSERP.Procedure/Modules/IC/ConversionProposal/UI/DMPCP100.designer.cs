using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConversionProposal.UI
{
	/// <summary>
	/// Summary description for DMTS100
	/// </summary>
	partial class DMPCP100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteICConversionProposalEmployeePicture;
        private BOSComponent.BOSLabel fld_Lablel2;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSMemoEdit fld_medICConversionProposalDesc;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPCP100));
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteICConversionProposalEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICConversionProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteICConversionProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICConversionProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICConversionProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_medICConversionProposalEmployeeRecever = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabConversionProposalItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICConversionProposalItems = new BOSERP.Modules.ConversionProposal.ICConversionProposalItemsGridControl();
            this.fld_dgvICTransferItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabVMProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICConversionProposalItemVMs = new BOSERP.Modules.ConversionProposal.ICConversionProposalItemVMsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnShowInventoryStock = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICConversionProposalEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICConversionProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICConversionProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICConversionProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICConversionProposalStatus.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICConversionProposalEmployeeRecever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabConversionProposalItems)).BeginInit();
            this.fld_tabConversionProposalItems.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransferItems)).BeginInit();
            this.fld_tabVMProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposalItemVMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICConversionProposalItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = "";
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(74, 11);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "Barcode", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 50;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1063, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryCloseUp);
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = "";
            this.fld_Lablel.BOSDataMember = "";
            this.fld_Lablel.BOSDataSource = "";
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = "";
            this.fld_Lablel.BOSFieldRelation = "";
            this.fld_Lablel.BOSPrivilege = "";
            this.fld_Lablel.BOSPropertyName = null;
            this.fld_Lablel.Location = new System.Drawing.Point(10, 14);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 390;
            this.fld_Lablel.Tag = "";
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 106);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_pteICConversionProposalEmployeePicture
            // 
            this.fld_pteICConversionProposalEmployeePicture.BOSComment = "";
            this.fld_pteICConversionProposalEmployeePicture.BOSDataMember = "ICConversionProposalEmployeePicture";
            this.fld_pteICConversionProposalEmployeePicture.BOSDataSource = "ICConversionProposals";
            this.fld_pteICConversionProposalEmployeePicture.BOSDescription = null;
            this.fld_pteICConversionProposalEmployeePicture.BOSError = "";
            this.fld_pteICConversionProposalEmployeePicture.BOSFieldGroup = "";
            this.fld_pteICConversionProposalEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICConversionProposalEmployeePicture.BOSPrivilege = "";
            this.fld_pteICConversionProposalEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICConversionProposalEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICConversionProposalEmployeePicture.FileName = null;
            this.fld_pteICConversionProposalEmployeePicture.FilePath = null;
            this.fld_pteICConversionProposalEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICConversionProposalEmployeePicture.Name = "fld_pteICConversionProposalEmployeePicture";
            this.fld_pteICConversionProposalEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICConversionProposalEmployeePicture.Screen = null;
            this.fld_pteICConversionProposalEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICConversionProposalEmployeePicture.TabIndex = 0;
            this.fld_pteICConversionProposalEmployeePicture.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "";
            this.fld_Lablel2.BOSDataMember = "";
            this.fld_Lablel2.BOSDataSource = "";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "";
            this.fld_Lablel2.BOSFieldRelation = "";
            this.fld_Lablel2.BOSPrivilege = "";
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(654, 15);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(654, 41);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(18, 13);
            this.fld_lblLabel7.TabIndex = 481;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Kho";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(714, 38);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 6;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
            // 
            // fld_medICConversionProposalDesc
            // 
            this.fld_medICConversionProposalDesc.BOSComment = "";
            this.fld_medICConversionProposalDesc.BOSDataMember = "ICConversionProposalDesc";
            this.fld_medICConversionProposalDesc.BOSDataSource = "ICConversionProposals";
            this.fld_medICConversionProposalDesc.BOSDescription = null;
            this.fld_medICConversionProposalDesc.BOSError = "";
            this.fld_medICConversionProposalDesc.BOSFieldGroup = "";
            this.fld_medICConversionProposalDesc.BOSFieldRelation = "";
            this.fld_medICConversionProposalDesc.BOSPrivilege = "";
            this.fld_medICConversionProposalDesc.BOSPropertyName = "Text";
            this.fld_medICConversionProposalDesc.Location = new System.Drawing.Point(201, 82);
            this.fld_medICConversionProposalDesc.Name = "fld_medICConversionProposalDesc";
            this.fld_medICConversionProposalDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICConversionProposalDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICConversionProposalDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICConversionProposalDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICConversionProposalDesc.Screen = null;
            this.fld_medICConversionProposalDesc.Size = new System.Drawing.Size(418, 44);
            this.fld_medICConversionProposalDesc.TabIndex = 5;
            this.fld_medICConversionProposalDesc.Tag = "DC";
            // 
            // fld_dteICConversionProposalDate
            // 
            this.fld_dteICConversionProposalDate.BOSComment = null;
            this.fld_dteICConversionProposalDate.BOSDataMember = "ICConversionProposalDate";
            this.fld_dteICConversionProposalDate.BOSDataSource = "ICConversionProposals";
            this.fld_dteICConversionProposalDate.BOSDescription = null;
            this.fld_dteICConversionProposalDate.BOSError = null;
            this.fld_dteICConversionProposalDate.BOSFieldGroup = null;
            this.fld_dteICConversionProposalDate.BOSFieldRelation = null;
            this.fld_dteICConversionProposalDate.BOSPrivilege = null;
            this.fld_dteICConversionProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteICConversionProposalDate.EditValue = null;
            this.fld_dteICConversionProposalDate.Location = new System.Drawing.Point(469, 12);
            this.fld_dteICConversionProposalDate.MenuManager = this.screenToolbar;
            this.fld_dteICConversionProposalDate.Name = "fld_dteICConversionProposalDate";
            this.fld_dteICConversionProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICConversionProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICConversionProposalDate.Screen = null;
            this.fld_dteICConversionProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICConversionProposalDate.TabIndex = 3;
            this.fld_dteICConversionProposalDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(384, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 496;
            this.BOSLabel1.Text = "Ngày chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(127, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 498;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtICConversionProposalNo
            // 
            this.fld_txtICConversionProposalNo.BOSComment = null;
            this.fld_txtICConversionProposalNo.BOSDataMember = "ICConversionProposalNo";
            this.fld_txtICConversionProposalNo.BOSDataSource = "ICConversionProposals";
            this.fld_txtICConversionProposalNo.BOSDescription = null;
            this.fld_txtICConversionProposalNo.BOSError = null;
            this.fld_txtICConversionProposalNo.BOSFieldGroup = null;
            this.fld_txtICConversionProposalNo.BOSFieldRelation = null;
            this.fld_txtICConversionProposalNo.BOSPrivilege = null;
            this.fld_txtICConversionProposalNo.BOSPropertyName = "EditValue";
            this.fld_txtICConversionProposalNo.Location = new System.Drawing.Point(201, 12);
            this.fld_txtICConversionProposalNo.MenuManager = this.screenToolbar;
            this.fld_txtICConversionProposalNo.Name = "fld_txtICConversionProposalNo";
            this.fld_txtICConversionProposalNo.Screen = null;
            this.fld_txtICConversionProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICConversionProposalNo.TabIndex = 2;
            this.fld_txtICConversionProposalNo.Tag = "DC";
            // 
            // fld_lkeICConversionProposalStatus
            // 
            this.fld_lkeICConversionProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeICConversionProposalStatus.BOSAllowDummy = false;
            this.fld_lkeICConversionProposalStatus.BOSComment = "";
            this.fld_lkeICConversionProposalStatus.BOSDataMember = "ICConversionProposalStatus";
            this.fld_lkeICConversionProposalStatus.BOSDataSource = "ICConversionProposals";
            this.fld_lkeICConversionProposalStatus.BOSDescription = null;
            this.fld_lkeICConversionProposalStatus.BOSError = "";
            this.fld_lkeICConversionProposalStatus.BOSFieldGroup = "";
            this.fld_lkeICConversionProposalStatus.BOSFieldParent = "";
            this.fld_lkeICConversionProposalStatus.BOSFieldRelation = "";
            this.fld_lkeICConversionProposalStatus.BOSPrivilege = "";
            this.fld_lkeICConversionProposalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICConversionProposalStatus.BOSSelectType = "";
            this.fld_lkeICConversionProposalStatus.BOSSelectTypeValue = "";
            this.fld_lkeICConversionProposalStatus.CurrentDisplayText = "";
            this.fld_lkeICConversionProposalStatus.Location = new System.Drawing.Point(714, 12);
            this.fld_lkeICConversionProposalStatus.Name = "fld_lkeICConversionProposalStatus";
            this.fld_lkeICConversionProposalStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICConversionProposalStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICConversionProposalStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICConversionProposalStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICConversionProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICConversionProposalStatus.Properties.ColumnName = null;
            this.fld_lkeICConversionProposalStatus.Properties.NullText = "";
            this.fld_lkeICConversionProposalStatus.Properties.PopupWidth = 40;
            this.fld_lkeICConversionProposalStatus.Properties.ReadOnly = true;
            this.fld_lkeICConversionProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICConversionProposalStatus.Screen = null;
            this.fld_lkeICConversionProposalStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICConversionProposalStatus.TabIndex = 7;
            this.fld_lkeICConversionProposalStatus.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMLineID);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_medICConversionProposalEmployeeRecever);
            this.bosPanel1.Controls.Add(this.fld_tabConversionProposalItems);
            this.bosPanel1.Controls.Add(this.fld_btnShowInventoryStock);
            this.bosPanel1.Controls.Add(this.fld_medICConversionProposalDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICConversionProposalEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtICConversionProposalNo);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeICConversionProposalStatus);
            this.bosPanel1.Controls.Add(this.fld_dteICConversionProposalDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1153, 626);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_medICConversionProposalEmployeeRecever
            // 
            this.fld_medICConversionProposalEmployeeRecever.BOSComment = "";
            this.fld_medICConversionProposalEmployeeRecever.BOSDataMember = "ICConversionProposalEmployeeRecever";
            this.fld_medICConversionProposalEmployeeRecever.BOSDataSource = "ICConversionProposals";
            this.fld_medICConversionProposalEmployeeRecever.BOSDescription = null;
            this.fld_medICConversionProposalEmployeeRecever.BOSError = "";
            this.fld_medICConversionProposalEmployeeRecever.BOSFieldGroup = "";
            this.fld_medICConversionProposalEmployeeRecever.BOSFieldRelation = "";
            this.fld_medICConversionProposalEmployeeRecever.BOSPrivilege = "";
            this.fld_medICConversionProposalEmployeeRecever.BOSPropertyName = "Text";
            this.fld_medICConversionProposalEmployeeRecever.Location = new System.Drawing.Point(201, 38);
            this.fld_medICConversionProposalEmployeeRecever.Name = "fld_medICConversionProposalEmployeeRecever";
            this.fld_medICConversionProposalEmployeeRecever.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICConversionProposalEmployeeRecever.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICConversionProposalEmployeeRecever.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICConversionProposalEmployeeRecever.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICConversionProposalEmployeeRecever.Screen = null;
            this.fld_medICConversionProposalEmployeeRecever.Size = new System.Drawing.Size(418, 38);
            this.fld_medICConversionProposalEmployeeRecever.TabIndex = 4;
            this.fld_medICConversionProposalEmployeeRecever.Tag = "DC";
            // 
            // fld_tabConversionProposalItems
            // 
            this.fld_tabConversionProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabConversionProposalItems.BOSComment = null;
            this.fld_tabConversionProposalItems.BOSDataMember = null;
            this.fld_tabConversionProposalItems.BOSDataSource = null;
            this.fld_tabConversionProposalItems.BOSDescription = null;
            this.fld_tabConversionProposalItems.BOSError = null;
            this.fld_tabConversionProposalItems.BOSFieldGroup = null;
            this.fld_tabConversionProposalItems.BOSFieldRelation = null;
            this.fld_tabConversionProposalItems.BOSPrivilege = null;
            this.fld_tabConversionProposalItems.BOSPropertyName = null;
            this.fld_tabConversionProposalItems.Location = new System.Drawing.Point(3, 132);
            this.fld_tabConversionProposalItems.Name = "fld_tabConversionProposalItems";
            this.fld_tabConversionProposalItems.Screen = null;
            this.fld_tabConversionProposalItems.SelectedTabPage = this.fld_tabProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabConversionProposalItems, true);
            this.fld_tabConversionProposalItems.Size = new System.Drawing.Size(1147, 491);
            this.fld_tabConversionProposalItems.TabIndex = 9;
            this.fld_tabConversionProposalItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabVMProduct,
            this.fld_tabProduct});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_dgcICConversionProposalItems);
            this.fld_tabProduct.Controls.Add(this.fld_Lablel);
            this.fld_tabProduct.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabProduct, true);
            this.fld_tabProduct.Size = new System.Drawing.Size(1145, 466);
            this.fld_tabProduct.Text = "Danh sách chi tiết";
            // 
            // fld_dgcICConversionProposalItems
            // 
            this.fld_dgcICConversionProposalItems.AllowDrop = true;
            this.fld_dgcICConversionProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICConversionProposalItems.BOSComment = "";
            this.fld_dgcICConversionProposalItems.BOSDataMember = null;
            this.fld_dgcICConversionProposalItems.BOSDataSource = "ICConversionProposalItems";
            this.fld_dgcICConversionProposalItems.BOSDescription = null;
            this.fld_dgcICConversionProposalItems.BOSError = "";
            this.fld_dgcICConversionProposalItems.BOSFieldGroup = "";
            this.fld_dgcICConversionProposalItems.BOSFieldRelation = null;
            this.fld_dgcICConversionProposalItems.BOSGridType = null;
            this.fld_dgcICConversionProposalItems.BOSPrivilege = "";
            this.fld_dgcICConversionProposalItems.BOSPropertyName = null;
            this.fld_dgcICConversionProposalItems.CommodityType = "";
            this.fld_dgcICConversionProposalItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICConversionProposalItems.Location = new System.Drawing.Point(7, 37);
            this.fld_dgcICConversionProposalItems.MainView = this.fld_dgvICTransferItems;
            this.fld_dgcICConversionProposalItems.Name = "fld_dgcICConversionProposalItems";
            this.fld_dgcICConversionProposalItems.PrintReport = false;
            this.fld_dgcICConversionProposalItems.Screen = null;
            this.fld_dgcICConversionProposalItems.Size = new System.Drawing.Size(1130, 425);
            this.fld_dgcICConversionProposalItems.TabIndex = 1;
            this.fld_dgcICConversionProposalItems.Tag = "DC";
            this.fld_dgcICConversionProposalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICTransferItems});
            // 
            // fld_dgvICTransferItems
            // 
            this.fld_dgvICTransferItems.GridControl = this.fld_dgcICConversionProposalItems;
            this.fld_dgvICTransferItems.Name = "fld_dgvICTransferItems";
            this.fld_dgvICTransferItems.PaintStyleName = "Office2003";
            // 
            // fld_tabVMProduct
            // 
            this.fld_tabVMProduct.Controls.Add(this.fld_dgcICConversionProposalItemVMs);
            this.fld_tabVMProduct.Name = "fld_tabVMProduct";
            this.fld_tabVMProduct.Size = new System.Drawing.Size(952, 459);
            this.fld_tabVMProduct.Text = "Danh sách tổng chi tiết";
            // 
            // fld_dgcICConversionProposalItemVMs
            // 
            this.fld_dgcICConversionProposalItemVMs.AllowDrop = true;
            this.fld_dgcICConversionProposalItemVMs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICConversionProposalItemVMs.BOSComment = "";
            this.fld_dgcICConversionProposalItemVMs.BOSDataMember = null;
            this.fld_dgcICConversionProposalItemVMs.BOSDataSource = "ICConversionProposalItemVMs";
            this.fld_dgcICConversionProposalItemVMs.BOSDescription = null;
            this.fld_dgcICConversionProposalItemVMs.BOSError = "";
            this.fld_dgcICConversionProposalItemVMs.BOSFieldGroup = "";
            this.fld_dgcICConversionProposalItemVMs.BOSFieldRelation = null;
            this.fld_dgcICConversionProposalItemVMs.BOSGridType = null;
            this.fld_dgcICConversionProposalItemVMs.BOSPrivilege = "";
            this.fld_dgcICConversionProposalItemVMs.BOSPropertyName = null;
            this.fld_dgcICConversionProposalItemVMs.CommodityType = "";
            this.fld_dgcICConversionProposalItemVMs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICConversionProposalItemVMs.Location = new System.Drawing.Point(8, 3);
            this.fld_dgcICConversionProposalItemVMs.MainView = this.gridView1;
            this.fld_dgcICConversionProposalItemVMs.Name = "fld_dgcICConversionProposalItemVMs";
            this.fld_dgcICConversionProposalItemVMs.PrintReport = false;
            this.fld_dgcICConversionProposalItemVMs.Screen = null;
            this.fld_dgcICConversionProposalItemVMs.Size = new System.Drawing.Size(937, 436);
            this.fld_dgcICConversionProposalItemVMs.TabIndex = 2;
            this.fld_dgcICConversionProposalItemVMs.Tag = "DC";
            this.fld_dgcICConversionProposalItemVMs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICConversionProposalItemVMs;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_btnShowInventoryStock
            // 
            this.fld_btnShowInventoryStock.BOSComment = null;
            this.fld_btnShowInventoryStock.BOSDataMember = null;
            this.fld_btnShowInventoryStock.BOSDataSource = null;
            this.fld_btnShowInventoryStock.BOSDescription = null;
            this.fld_btnShowInventoryStock.BOSError = null;
            this.fld_btnShowInventoryStock.BOSFieldGroup = null;
            this.fld_btnShowInventoryStock.BOSFieldRelation = null;
            this.fld_btnShowInventoryStock.BOSPrivilege = null;
            this.fld_btnShowInventoryStock.BOSPropertyName = null;
            this.fld_btnShowInventoryStock.Location = new System.Drawing.Point(714, 64);
            this.fld_btnShowInventoryStock.Name = "fld_btnShowInventoryStock";
            this.fld_btnShowInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowInventoryStock, true);
            this.fld_btnShowInventoryStock.Size = new System.Drawing.Size(150, 25);
            this.fld_btnShowInventoryStock.TabIndex = 8;
            this.fld_btnShowInventoryStock.Text = "Tồn kho";
            this.fld_btnShowInventoryStock.Click += new System.EventHandler(this.fld_btnShowInventoryStock_Click);
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
            this.bosLabel4.Location = new System.Drawing.Point(127, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(55, 13);
            this.bosLabel4.TabIndex = 478;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Người nhận";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(127, 84);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(40, 13);
            this.bosLabel7.TabIndex = 478;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Diễn giải";
            // 
            // fld_lkeHRDepartmentRoomGroupItemID
            // 
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldGroup = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldParent = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldRelation = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPrivilege = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectType = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectTypeValue = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.CurrentDisplayText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(970, 64);
            this.fld_lkeHRDepartmentRoomGroupItemID.Name = "fld_lkeHRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.NullText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeHRDepartmentRoomGroupItemID.TabIndex = 501;
            this.fld_lkeHRDepartmentRoomGroupItemID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(904, 93);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(52, 13);
            this.bosLabel3.TabIndex = 506;
            this.bosLabel3.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = "";
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = "";
            this.fld_lkeFK_MMOperationID.BOSFieldParent = "";
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = "";
            this.fld_lkeFK_MMOperationID.BOSPrivilege = "";
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = "";
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(970, 90);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMOperationID, true);
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 502;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(904, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(12, 13);
            this.bosLabel12.TabIndex = 505;
            this.bosLabel12.Text = "Tổ";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(970, 12);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 499;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = true;
            this.fld_lkeFK_MMLineID.BOSComment = "";
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "ICConversionProposals";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = "";
            this.fld_lkeFK_MMLineID.BOSFieldParent = "";
            this.fld_lkeFK_MMLineID.BOSFieldRelation = "";
            this.fld_lkeFK_MMLineID.BOSPrivilege = "";
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = "";
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMLineID.CurrentDisplayText = "";
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(970, 38);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = "";
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 500;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(904, 15);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 503;
            this.bosLabel21.Text = "Xưởng";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(904, 41);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(37, 13);
            this.bosLabel20.TabIndex = 504;
            this.bosLabel20.Text = "Chuyền";
            // 
            // DMPCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1153, 626);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPCP100.IconOptions.Icon")));
            this.Name = "DMPCP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICConversionProposalEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICConversionProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICConversionProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICConversionProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICConversionProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICConversionProposalStatus.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICConversionProposalEmployeeRecever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabConversionProposalItems)).EndInit();
            this.fld_tabConversionProposalItems.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            this.fld_tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICTransferItems)).EndInit();
            this.fld_tabVMProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConversionProposalItemVMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteICConversionProposalDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICConversionProposalNo;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel fld_Lablel;
        private BOSComponent.BOSLookupEdit fld_lkeICConversionProposalStatus;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnShowInventoryStock;
        private BOSComponent.BOSTabControl fld_tabConversionProposalItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabProduct;
        private ICConversionProposalItemsGridControl fld_dgcICConversionProposalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICTransferItems;
        private BOSComponent.BOSMemoEdit fld_medICConversionProposalEmployeeRecever;
        private DevExpress.XtraTab.XtraTabPage fld_tabVMProduct;
        private ICConversionProposalItemVMsGridControl fld_dgcICConversionProposalItemVMs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel20;
    }
}
