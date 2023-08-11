using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TransferProposal.UI
{
	/// <summary>
	/// Summary description for DMTP100
	/// </summary>
	partial class DMTP100
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
            this.fld_dteICTransferProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICTransferProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcICTransferProposalItems = new BOSERP.Modules.TransferProposal.ICTransferProposaltemsGridControl();
            this.fld_dgvAPCancelPurchaseProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICFromStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICToStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICTransferProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICTransferProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteICTransferProposalEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteValidDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposalItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferProposalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTransferProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferProposalEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteValidDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteValidDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dteICTransferProposalDate
            // 
            this.fld_dteICTransferProposalDate.BOSComment = "";
            this.fld_dteICTransferProposalDate.BOSDataMember = "ICTransferProposalDate";
            this.fld_dteICTransferProposalDate.BOSDataSource = "ICTransferProposals";
            this.fld_dteICTransferProposalDate.BOSDescription = null;
            this.fld_dteICTransferProposalDate.BOSError = null;
            this.fld_dteICTransferProposalDate.BOSFieldGroup = "";
            this.fld_dteICTransferProposalDate.BOSFieldRelation = "";
            this.fld_dteICTransferProposalDate.BOSPrivilege = "";
            this.fld_dteICTransferProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteICTransferProposalDate.EditValue = null;
            this.fld_dteICTransferProposalDate.Location = new System.Drawing.Point(430, 12);
            this.fld_dteICTransferProposalDate.Name = "fld_dteICTransferProposalDate";
            this.fld_dteICTransferProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICTransferProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICTransferProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICTransferProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICTransferProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferProposalDate.Screen = null;
            this.fld_dteICTransferProposalDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteICTransferProposalDate.TabIndex = 3;
            this.fld_dteICTransferProposalDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICTransferProposals";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(6, 111);
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
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(104, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_txtICTransferProposalNo
            // 
            this.fld_txtICTransferProposalNo.BOSComment = null;
            this.fld_txtICTransferProposalNo.BOSDataMember = "ICTransferProposalNo";
            this.fld_txtICTransferProposalNo.BOSDataSource = "ICTransferProposals";
            this.fld_txtICTransferProposalNo.BOSDescription = null;
            this.fld_txtICTransferProposalNo.BOSError = null;
            this.fld_txtICTransferProposalNo.BOSFieldGroup = null;
            this.fld_txtICTransferProposalNo.BOSFieldRelation = null;
            this.fld_txtICTransferProposalNo.BOSPrivilege = null;
            this.fld_txtICTransferProposalNo.BOSPropertyName = "EditValue";
            this.fld_txtICTransferProposalNo.Location = new System.Drawing.Point(206, 12);
            this.fld_txtICTransferProposalNo.MenuManager = this.screenToolbar;
            this.fld_txtICTransferProposalNo.Name = "fld_txtICTransferProposalNo";
            this.fld_txtICTransferProposalNo.Screen = null;
            this.fld_txtICTransferProposalNo.Size = new System.Drawing.Size(130, 20);
            this.fld_txtICTransferProposalNo.TabIndex = 2;
            this.fld_txtICTransferProposalNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(352, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Ngày chứng từ";
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
            this.bosGroupControl2.Controls.Add(this.fld_Lablel);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl2.Controls.Add(this.fld_pteAPCancelPurchaseProposalItemProductPicture);
            this.bosGroupControl2.Controls.Add(this.fld_dgcICTransferProposalItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(6, 148);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(993, 440);
            this.bosGroupControl2.TabIndex = 12;
            this.bosGroupControl2.Text = "Danh sách sản phẩm";
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
            this.fld_Lablel.Location = new System.Drawing.Point(9, 30);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 392;
            this.fld_Lablel.Tag = "";
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICTransferProposalItems";
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
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(76, 28);
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
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(908, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 391;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_pteAPCancelPurchaseProposalItemProductPicture
            // 
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSComment = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDataMember = "ICTransferProposalItemProductPicture";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDataSource = "ICTransferProposalItems";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSDescription = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSError = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSFieldGroup = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSFieldRelation = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSPrivilege = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.FileName = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.FilePath = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Location = new System.Drawing.Point(867, 57);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Name = "fld_pteAPCancelPurchaseProposalItemProductPicture";
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Screen = null;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.TabIndex = 2;
            this.fld_pteAPCancelPurchaseProposalItemProductPicture.Tag = "DC";
            // 
            // fld_dgcICTransferProposalItems
            // 
            this.fld_dgcICTransferProposalItems.AllowDrop = true;
            this.fld_dgcICTransferProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferProposalItems.BOSComment = "";
            this.fld_dgcICTransferProposalItems.BOSDataMember = "";
            this.fld_dgcICTransferProposalItems.BOSDataSource = "ICTransferProposalItems";
            this.fld_dgcICTransferProposalItems.BOSDescription = null;
            this.fld_dgcICTransferProposalItems.BOSError = null;
            this.fld_dgcICTransferProposalItems.BOSFieldGroup = "Accept";
            this.fld_dgcICTransferProposalItems.BOSFieldRelation = "";
            this.fld_dgcICTransferProposalItems.BOSGridType = null;
            this.fld_dgcICTransferProposalItems.BOSPrivilege = "";
            this.fld_dgcICTransferProposalItems.BOSPropertyName = null;
            this.fld_dgcICTransferProposalItems.CommodityType = "";
            this.fld_dgcICTransferProposalItems.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcICTransferProposalItems.Location = new System.Drawing.Point(9, 57);
            this.fld_dgcICTransferProposalItems.MainView = this.fld_dgvAPCancelPurchaseProposalItems;
            this.fld_dgcICTransferProposalItems.Name = "fld_dgcICTransferProposalItems";
            this.fld_dgcICTransferProposalItems.PrintReport = false;
            this.fld_dgcICTransferProposalItems.Screen = null;
            this.fld_dgcICTransferProposalItems.Size = new System.Drawing.Size(852, 378);
            this.fld_dgcICTransferProposalItems.TabIndex = 1;
            this.fld_dgcICTransferProposalItems.Tag = "DC";
            this.fld_dgcICTransferProposalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPCancelPurchaseProposalItems});
            // 
            // fld_dgvAPCancelPurchaseProposalItems
            // 
            this.fld_dgvAPCancelPurchaseProposalItems.GridControl = this.fld_dgcICTransferProposalItems;
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
            this.bosPanel1.Controls.Add(this.fld_dteValidDate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICFromStockID1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICToStockID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeICTransferProposalStatus);
            this.bosPanel1.Controls.Add(this.fld_medICTransferProposalDesc);
            this.bosPanel1.Controls.Add(this.fld_dteICTransferProposalDate);
            this.bosPanel1.Controls.Add(this.fld_pteICTransferProposalEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtICTransferProposalNo);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1002, 588);
            this.bosPanel1.TabIndex = 8;
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
            this.bosLabel2.Location = new System.Drawing.Point(130, 40);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(65, 13);
            this.bosLabel2.TabIndex = 487;
            this.bosLabel2.Text = "Tên chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICTransferProposalName";
            this.bosTextBox1.BOSDataSource = "ICTransferProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(206, 37);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(354, 20);
            this.bosTextBox1.TabIndex = 488;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeFK_ICFromStockID1
            // 
            this.fld_lkeFK_ICFromStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICFromStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICFromStockID1.BOSComment = "";
            this.fld_lkeFK_ICFromStockID1.BOSDataMember = "FK_ICFromStockID";
            this.fld_lkeFK_ICFromStockID1.BOSDataSource = "ICTransferProposals";
            this.fld_lkeFK_ICFromStockID1.BOSDescription = null;
            this.fld_lkeFK_ICFromStockID1.BOSError = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldParent = "";
            this.fld_lkeFK_ICFromStockID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICFromStockID1.BOSPrivilege = "";
            this.fld_lkeFK_ICFromStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICFromStockID1.BOSSelectType = "";
            this.fld_lkeFK_ICFromStockID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICFromStockID1.CurrentDisplayText = "";
            this.fld_lkeFK_ICFromStockID1.Location = new System.Drawing.Point(206, 63);
            this.fld_lkeFK_ICFromStockID1.Name = "fld_lkeFK_ICFromStockID1";
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICFromStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICFromStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICFromStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICFromStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICFromStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICFromStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICFromStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICFromStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICFromStockID1.Screen = null;
            this.fld_lkeFK_ICFromStockID1.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ICFromStockID1.TabIndex = 483;
            this.fld_lkeFK_ICFromStockID1.Tag = "DC";
            this.fld_lkeFK_ICFromStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICFromStockID1_CloseUp);
            // 
            // fld_lkeFK_ICToStockID
            // 
            this.fld_lkeFK_ICToStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICToStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICToStockID.BOSComment = "";
            this.fld_lkeFK_ICToStockID.BOSDataMember = "FK_ICToStockID";
            this.fld_lkeFK_ICToStockID.BOSDataSource = "ICTransferProposals";
            this.fld_lkeFK_ICToStockID.BOSDescription = null;
            this.fld_lkeFK_ICToStockID.BOSError = "";
            this.fld_lkeFK_ICToStockID.BOSFieldGroup = "";
            this.fld_lkeFK_ICToStockID.BOSFieldParent = "";
            this.fld_lkeFK_ICToStockID.BOSFieldRelation = "";
            this.fld_lkeFK_ICToStockID.BOSPrivilege = "";
            this.fld_lkeFK_ICToStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICToStockID.BOSSelectType = "";
            this.fld_lkeFK_ICToStockID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICToStockID.CurrentDisplayText = "";
            this.fld_lkeFK_ICToStockID.Location = new System.Drawing.Point(430, 63);
            this.fld_lkeFK_ICToStockID.Name = "fld_lkeFK_ICToStockID";
            this.fld_lkeFK_ICToStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICToStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICToStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICToStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho ", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICToStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICToStockID.Properties.NullText = "";
            this.fld_lkeFK_ICToStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICToStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICToStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICToStockID.Screen = null;
            this.fld_lkeFK_ICToStockID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ICToStockID.TabIndex = 484;
            this.fld_lkeFK_ICToStockID.Tag = "DC";
            this.fld_lkeFK_ICToStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICToStockID_CloseUp);
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(352, 65);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 486;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Đến kho";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(130, 66);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel7.TabIndex = 485;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Từ kho";
            // 
            // fld_lkeICTransferProposalStatus
            // 
            this.fld_lkeICTransferProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeICTransferProposalStatus.BOSAllowDummy = false;
            this.fld_lkeICTransferProposalStatus.BOSComment = "";
            this.fld_lkeICTransferProposalStatus.BOSDataMember = "ICTransferProposalStatus";
            this.fld_lkeICTransferProposalStatus.BOSDataSource = "ICTransferProposals";
            this.fld_lkeICTransferProposalStatus.BOSDescription = null;
            this.fld_lkeICTransferProposalStatus.BOSError = null;
            this.fld_lkeICTransferProposalStatus.BOSFieldGroup = "";
            this.fld_lkeICTransferProposalStatus.BOSFieldParent = "";
            this.fld_lkeICTransferProposalStatus.BOSFieldRelation = "";
            this.fld_lkeICTransferProposalStatus.BOSPrivilege = "";
            this.fld_lkeICTransferProposalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICTransferProposalStatus.BOSSelectType = "";
            this.fld_lkeICTransferProposalStatus.BOSSelectTypeValue = "";
            this.fld_lkeICTransferProposalStatus.CurrentDisplayText = "";
            this.fld_lkeICTransferProposalStatus.Location = new System.Drawing.Point(645, 37);
            this.fld_lkeICTransferProposalStatus.Name = "fld_lkeICTransferProposalStatus";
            this.fld_lkeICTransferProposalStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICTransferProposalStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICTransferProposalStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICTransferProposalStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICTransferProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICTransferProposalStatus.Properties.ColumnName = null;
            this.fld_lkeICTransferProposalStatus.Properties.NullText = "";
            this.fld_lkeICTransferProposalStatus.Properties.ReadOnly = true;
            this.fld_lkeICTransferProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICTransferProposalStatus.Screen = null;
            this.fld_lkeICTransferProposalStatus.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeICTransferProposalStatus.TabIndex = 8;
            this.fld_lkeICTransferProposalStatus.Tag = "DC";
            // 
            // fld_medICTransferProposalDesc
            // 
            this.fld_medICTransferProposalDesc.BOSComment = null;
            this.fld_medICTransferProposalDesc.BOSDataMember = "ICTransferProposalDesc";
            this.fld_medICTransferProposalDesc.BOSDataSource = "ICTransferProposals";
            this.fld_medICTransferProposalDesc.BOSDescription = null;
            this.fld_medICTransferProposalDesc.BOSError = null;
            this.fld_medICTransferProposalDesc.BOSFieldGroup = null;
            this.fld_medICTransferProposalDesc.BOSFieldRelation = null;
            this.fld_medICTransferProposalDesc.BOSPrivilege = null;
            this.fld_medICTransferProposalDesc.BOSPropertyName = "EditValue";
            this.fld_medICTransferProposalDesc.Location = new System.Drawing.Point(206, 90);
            this.fld_medICTransferProposalDesc.MenuManager = this.screenToolbar;
            this.fld_medICTransferProposalDesc.Name = "fld_medICTransferProposalDesc";
            this.fld_medICTransferProposalDesc.Screen = null;
            this.fld_medICTransferProposalDesc.Size = new System.Drawing.Size(354, 44);
            this.fld_medICTransferProposalDesc.TabIndex = 12;
            this.fld_medICTransferProposalDesc.Tag = "DC";
            // 
            // fld_pteICTransferProposalEmployeePicture
            // 
            this.fld_pteICTransferProposalEmployeePicture.BOSComment = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSDataMember = "ICTransferProposalEmployeePicture";
            this.fld_pteICTransferProposalEmployeePicture.BOSDataSource = "ICTransferProposals";
            this.fld_pteICTransferProposalEmployeePicture.BOSDescription = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSError = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSPrivilege = null;
            this.fld_pteICTransferProposalEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICTransferProposalEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICTransferProposalEmployeePicture.FileName = null;
            this.fld_pteICTransferProposalEmployeePicture.FilePath = null;
            this.fld_pteICTransferProposalEmployeePicture.Location = new System.Drawing.Point(6, 3);
            this.fld_pteICTransferProposalEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICTransferProposalEmployeePicture.Name = "fld_pteICTransferProposalEmployeePicture";
            this.fld_pteICTransferProposalEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICTransferProposalEmployeePicture.Screen = null;
            this.fld_pteICTransferProposalEmployeePicture.Size = new System.Drawing.Size(104, 102);
            this.fld_pteICTransferProposalEmployeePicture.TabIndex = 0;
            this.fld_pteICTransferProposalEmployeePicture.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(583, 40);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteValidDate
            // 
            this.fld_dteValidDate.BOSComment = "";
            this.fld_dteValidDate.BOSDataMember = "ICTransferProposalValidDate";
            this.fld_dteValidDate.BOSDataSource = "ICTransferProposals";
            this.fld_dteValidDate.BOSDescription = null;
            this.fld_dteValidDate.BOSError = null;
            this.fld_dteValidDate.BOSFieldGroup = "";
            this.fld_dteValidDate.BOSFieldRelation = "";
            this.fld_dteValidDate.BOSPrivilege = "";
            this.fld_dteValidDate.BOSPropertyName = "EditValue";
            this.fld_dteValidDate.EditValue = null;
            this.fld_dteValidDate.Location = new System.Drawing.Point(645, 12);
            this.fld_dteValidDate.Name = "fld_dteValidDate";
            this.fld_dteValidDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteValidDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteValidDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteValidDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteValidDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteValidDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteValidDate.Screen = null;
            this.fld_dteValidDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteValidDate.TabIndex = 489;
            this.fld_dteValidDate.Tag = "DC";
            this.fld_dteValidDate.Validated += new System.EventHandler(this.fld_dteValidDate_Validated);
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
            this.bosLabel4.Location = new System.Drawing.Point(583, 14);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 490;
            this.bosLabel4.Text = "Ngày cần";
            // 
            // DMTP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1002, 588);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMTP100";
            this.Text = "Đề nghị chuyển kho";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPCancelPurchaseProposalItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPCancelPurchaseProposalItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICFromStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICToStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICTransferProposalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTransferProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICTransferProposalEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteValidDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteValidDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSTextBox fld_txtICTransferProposalNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPictureEdit fld_pteAPCancelPurchaseProposalItemProductPicture;
        private ICTransferProposaltemsGridControl fld_dgcICTransferProposalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPCancelPurchaseProposalItems;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSDateEdit fld_dteICTransferProposalDate;
        private BOSComponent.BOSPictureEdit fld_pteICTransferProposalEmployeePicture;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeICTransferProposalStatus;
        private BOSComponent.BOSMemoEdit fld_medICTransferProposalDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICFromStockID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICToStockID;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel fld_Lablel;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSDateEdit fld_dteValidDate;
        private BOSComponent.BOSLabel bosLabel4;
    }
}
