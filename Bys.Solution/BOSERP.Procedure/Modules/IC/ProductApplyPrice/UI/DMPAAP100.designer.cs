using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductApplyPrice.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMPAAP100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARProductApplyPriceEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARProductApplyPriceDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARProductApplyPriceNo;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ICProductApplyPriceItemsGridControl fld_dgcICProductApplyPriceItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARProductApplyPriceStatus;
        private BOSComponent.BOSDateEdit fld_dteARProductApplyPriceEndDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medARProductApplyPriceDesc;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel9;

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
            this.fld_pteARProductApplyPriceEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARProductApplyPriceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProductApplyPriceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARProductApplyPriceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARProductApplyPriceEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARProductApplyPriceStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnImportFromExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductApplyPriceItemsGridControl = new BOSERP.Modules.ProductApplyPrice.ICProductApplyPriceItemsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProductApplyPriceEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductApplyPriceNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARProductApplyPriceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductApplyPriceStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductApplyPriceItemsGridControl)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARProductApplyPrices";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = string.Empty;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 128);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = string.Empty;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(106, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteARProductApplyPriceEmployeePicture
            // 
            this.fld_pteARProductApplyPriceEmployeePicture.BOSComment = string.Empty;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSDataMember = "ARProductApplyPriceEmployeePicture";
            this.fld_pteARProductApplyPriceEmployeePicture.BOSDataSource = "ARProductApplyPrices";
            this.fld_pteARProductApplyPriceEmployeePicture.BOSDescription = null;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSError = string.Empty;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSFieldGroup = string.Empty;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSPrivilege = string.Empty;
            this.fld_pteARProductApplyPriceEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARProductApplyPriceEmployeePicture.Location = new System.Drawing.Point(5, 25);
            this.fld_pteARProductApplyPriceEmployeePicture.Name = "fld_pteARProductApplyPriceEmployeePicture";
            this.fld_pteARProductApplyPriceEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARProductApplyPriceEmployeePicture.Screen = null;
            this.fld_pteARProductApplyPriceEmployeePicture.Size = new System.Drawing.Size(106, 97);
            this.fld_pteARProductApplyPriceEmployeePicture.TabIndex = 0;
            this.fld_pteARProductApplyPriceEmployeePicture.Tag = "DC";
            // 
            // fld_dteARProductApplyPriceDate
            // 
            this.fld_dteARProductApplyPriceDate.BOSComment = null;
            this.fld_dteARProductApplyPriceDate.BOSDataMember = "ICProductApplyPriceDate";
            this.fld_dteARProductApplyPriceDate.BOSDataSource = "ICProductApplyPrices";
            this.fld_dteARProductApplyPriceDate.BOSDescription = null;
            this.fld_dteARProductApplyPriceDate.BOSError = null;
            this.fld_dteARProductApplyPriceDate.BOSFieldGroup = null;
            this.fld_dteARProductApplyPriceDate.BOSFieldRelation = null;
            this.fld_dteARProductApplyPriceDate.BOSPrivilege = null;
            this.fld_dteARProductApplyPriceDate.BOSPropertyName = "EditValue";
            this.fld_dteARProductApplyPriceDate.EditValue = null;
            this.fld_dteARProductApplyPriceDate.Location = new System.Drawing.Point(503, 25);
            this.fld_dteARProductApplyPriceDate.MenuManager = this.screenToolbar;
            this.fld_dteARProductApplyPriceDate.Name = "fld_dteARProductApplyPriceDate";
            this.fld_dteARProductApplyPriceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProductApplyPriceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProductApplyPriceDate.Screen = null;
            this.fld_dteARProductApplyPriceDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARProductApplyPriceDate.TabIndex = 1;
            this.fld_dteARProductApplyPriceDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = string.Empty;
            this.BOSLabel1.BOSDataMember = string.Empty;
            this.BOSLabel1.BOSDataSource = string.Empty;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = string.Empty;
            this.BOSLabel1.BOSFieldRelation = string.Empty;
            this.BOSLabel1.BOSPrivilege = string.Empty;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(426, 28);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = string.Empty;
            this.BOSLabel1.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(147, 28);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = string.Empty;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARProductApplyPriceNo
            // 
            this.fld_txtARProductApplyPriceNo.BOSComment = null;
            this.fld_txtARProductApplyPriceNo.BOSDataMember = "ICProductApplyPriceNo";
            this.fld_txtARProductApplyPriceNo.BOSDataSource = "ICProductApplyPrices";
            this.fld_txtARProductApplyPriceNo.BOSDescription = null;
            this.fld_txtARProductApplyPriceNo.BOSError = null;
            this.fld_txtARProductApplyPriceNo.BOSFieldGroup = null;
            this.fld_txtARProductApplyPriceNo.BOSFieldRelation = null;
            this.fld_txtARProductApplyPriceNo.BOSPrivilege = null;
            this.fld_txtARProductApplyPriceNo.BOSPropertyName = "EditValue";
            this.fld_txtARProductApplyPriceNo.Location = new System.Drawing.Point(229, 25);
            this.fld_txtARProductApplyPriceNo.MenuManager = this.screenToolbar;
            this.fld_txtARProductApplyPriceNo.Name = "fld_txtARProductApplyPriceNo";
            this.fld_txtARProductApplyPriceNo.Screen = null;
            this.fld_txtARProductApplyPriceNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARProductApplyPriceNo.TabIndex = 0;
            this.fld_txtARProductApplyPriceNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1025, 603);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.fld_medARProductApplyPriceDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_txtARProductApplyPriceNo);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosGroupControl1.Controls.Add(this.fld_pteARProductApplyPriceEmployeePicture);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_dteARProductApplyPriceDate);
            this.bosGroupControl1.Controls.Add(this.fld_dteARProductApplyPriceEndDate);
            this.bosGroupControl1.Controls.Add(this.BOSLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARProductApplyPriceStatus);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1018, 161);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = string.Empty;
            this.bosLabel4.BOSDataMember = string.Empty;
            this.bosLabel4.BOSDataSource = string.Empty;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = string.Empty;
            this.bosLabel4.BOSFieldRelation = string.Empty;
            this.bosLabel4.BOSPrivilege = string.Empty;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(147, 80);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(51, 13);
            this.bosLabel4.TabIndex = 436;
            this.bosLabel4.Tag = string.Empty;
            this.bosLabel4.Text = "Loại áp giá";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ICProductApplyPriceType";
            this.bosLookupEdit1.BOSDataSource = "ICProductApplyPrices";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(229, 77);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(171, 20);
            this.bosLookupEdit1.TabIndex = 4;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICProductApplyPriceName";
            this.bosTextBox1.BOSDataSource = "ICProductApplyPrices";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(229, 51);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(171, 20);
            this.bosTextBox1.TabIndex = 2;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = string.Empty;
            this.bosLabel9.BOSDataMember = string.Empty;
            this.bosLabel9.BOSDataSource = string.Empty;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = string.Empty;
            this.bosLabel9.BOSFieldRelation = string.Empty;
            this.bosLabel9.BOSPrivilege = string.Empty;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(147, 54);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(65, 13);
            this.bosLabel9.TabIndex = 434;
            this.bosLabel9.Tag = string.Empty;
            this.bosLabel9.Text = "Tên chứng từ";
            // 
            // fld_medARProductApplyPriceDesc
            // 
            this.fld_medARProductApplyPriceDesc.BOSComment = string.Empty;
            this.fld_medARProductApplyPriceDesc.BOSDataMember = "ICProductApplyPriceDesc";
            this.fld_medARProductApplyPriceDesc.BOSDataSource = "ICProductApplyPrices";
            this.fld_medARProductApplyPriceDesc.BOSDescription = null;
            this.fld_medARProductApplyPriceDesc.BOSError = null;
            this.fld_medARProductApplyPriceDesc.BOSFieldGroup = string.Empty;
            this.fld_medARProductApplyPriceDesc.BOSFieldRelation = string.Empty;
            this.fld_medARProductApplyPriceDesc.BOSPrivilege = string.Empty;
            this.fld_medARProductApplyPriceDesc.BOSPropertyName = "EditValue";
            this.fld_medARProductApplyPriceDesc.EditValue = string.Empty;
            this.fld_medARProductApplyPriceDesc.Location = new System.Drawing.Point(229, 103);
            this.fld_medARProductApplyPriceDesc.Name = "fld_medARProductApplyPriceDesc";
            this.fld_medARProductApplyPriceDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARProductApplyPriceDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARProductApplyPriceDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARProductApplyPriceDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARProductApplyPriceDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARProductApplyPriceDesc, true);
            this.fld_medARProductApplyPriceDesc.Size = new System.Drawing.Size(445, 45);
            this.fld_medARProductApplyPriceDesc.TabIndex = 6;
            this.fld_medARProductApplyPriceDesc.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = string.Empty;
            this.bosLabel6.BOSDataMember = string.Empty;
            this.bosLabel6.BOSDataSource = string.Empty;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = string.Empty;
            this.bosLabel6.BOSFieldRelation = string.Empty;
            this.bosLabel6.BOSPrivilege = string.Empty;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(147, 109);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(27, 13);
            this.bosLabel6.TabIndex = 428;
            this.bosLabel6.Tag = string.Empty;
            this.bosLabel6.Text = "Mô tả";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(426, 80);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_dteARProductApplyPriceEndDate
            // 
            this.fld_dteARProductApplyPriceEndDate.BOSComment = null;
            this.fld_dteARProductApplyPriceEndDate.BOSDataMember = "ICProductApplyPriceEndDate";
            this.fld_dteARProductApplyPriceEndDate.BOSDataSource = "ICProductApplyPrices";
            this.fld_dteARProductApplyPriceEndDate.BOSDescription = null;
            this.fld_dteARProductApplyPriceEndDate.BOSError = null;
            this.fld_dteARProductApplyPriceEndDate.BOSFieldGroup = null;
            this.fld_dteARProductApplyPriceEndDate.BOSFieldRelation = null;
            this.fld_dteARProductApplyPriceEndDate.BOSPrivilege = null;
            this.fld_dteARProductApplyPriceEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARProductApplyPriceEndDate.EditValue = null;
            this.fld_dteARProductApplyPriceEndDate.Location = new System.Drawing.Point(503, 51);
            this.fld_dteARProductApplyPriceEndDate.MenuManager = this.screenToolbar;
            this.fld_dteARProductApplyPriceEndDate.Name = "fld_dteARProductApplyPriceEndDate";
            this.fld_dteARProductApplyPriceEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProductApplyPriceEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProductApplyPriceEndDate.Screen = null;
            this.fld_dteARProductApplyPriceEndDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARProductApplyPriceEndDate.TabIndex = 3;
            this.fld_dteARProductApplyPriceEndDate.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = string.Empty;
            this.bosLabel5.BOSDataMember = string.Empty;
            this.bosLabel5.BOSDataSource = string.Empty;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = string.Empty;
            this.bosLabel5.BOSFieldRelation = string.Empty;
            this.bosLabel5.BOSPrivilege = string.Empty;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(426, 54);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(65, 13);
            this.bosLabel5.TabIndex = 423;
            this.bosLabel5.Tag = string.Empty;
            this.bosLabel5.Text = "Ngày hết hạn";
            // 
            // fld_lkeARProductApplyPriceStatus
            // 
            this.fld_lkeARProductApplyPriceStatus.BOSAllowAddNew = false;
            this.fld_lkeARProductApplyPriceStatus.BOSAllowDummy = false;
            this.fld_lkeARProductApplyPriceStatus.BOSComment = null;
            this.fld_lkeARProductApplyPriceStatus.BOSDataMember = "ICProductApplyPriceStatus";
            this.fld_lkeARProductApplyPriceStatus.BOSDataSource = "ICProductApplyPrices";
            this.fld_lkeARProductApplyPriceStatus.BOSDescription = null;
            this.fld_lkeARProductApplyPriceStatus.BOSError = null;
            this.fld_lkeARProductApplyPriceStatus.BOSFieldGroup = null;
            this.fld_lkeARProductApplyPriceStatus.BOSFieldParent = null;
            this.fld_lkeARProductApplyPriceStatus.BOSFieldRelation = null;
            this.fld_lkeARProductApplyPriceStatus.BOSPrivilege = null;
            this.fld_lkeARProductApplyPriceStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARProductApplyPriceStatus.BOSSelectType = null;
            this.fld_lkeARProductApplyPriceStatus.BOSSelectTypeValue = null;
            this.fld_lkeARProductApplyPriceStatus.CurrentDisplayText = null;
            this.fld_lkeARProductApplyPriceStatus.Location = new System.Drawing.Point(503, 77);
            this.fld_lkeARProductApplyPriceStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARProductApplyPriceStatus.Name = "fld_lkeARProductApplyPriceStatus";
            this.fld_lkeARProductApplyPriceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProductApplyPriceStatus.Properties.ReadOnly = true;
            this.fld_lkeARProductApplyPriceStatus.Screen = null;
            this.fld_lkeARProductApplyPriceStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARProductApplyPriceStatus.TabIndex = 5;
            this.fld_lkeARProductApplyPriceStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 170);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1018, 430);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnImportFromExcel);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProduct);
            this.xtraTabPage1.Controls.Add(this.fld_dgcICProductApplyPriceItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1011, 401);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_btnImportFromExcel
            // 
            this.fld_btnImportFromExcel.BOSComment = null;
            this.fld_btnImportFromExcel.BOSDataMember = null;
            this.fld_btnImportFromExcel.BOSDataSource = null;
            this.fld_btnImportFromExcel.BOSDescription = null;
            this.fld_btnImportFromExcel.BOSError = null;
            this.fld_btnImportFromExcel.BOSFieldGroup = null;
            this.fld_btnImportFromExcel.BOSFieldRelation = null;
            this.fld_btnImportFromExcel.BOSPrivilege = null;
            this.fld_btnImportFromExcel.BOSPropertyName = null;
            this.fld_btnImportFromExcel.Location = new System.Drawing.Point(115, 3);
            this.fld_btnImportFromExcel.Name = "fld_btnImportFromExcel";
            this.fld_btnImportFromExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnImportFromExcel, true);
            this.fld_btnImportFromExcel.Size = new System.Drawing.Size(130, 27);
            this.fld_btnImportFromExcel.TabIndex = 3;
            this.fld_btnImportFromExcel.Text = "Load từ Excel";
            this.fld_btnImportFromExcel.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = string.Empty;
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = string.Empty;
            this.fld_btnAddProduct.BOSFieldRelation = string.Empty;
            this.fld_btnAddProduct.BOSPrivilege = string.Empty;
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(6, 3);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProduct.TabIndex = 1;
            this.fld_btnAddProduct.Tag = string.Empty;
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // fld_dgcICProductApplyPriceItemsGridControl
            // 
            this.fld_dgcICProductApplyPriceItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSComment = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSDataMember = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSDataSource = "ICProductApplyPriceItems";
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSDescription = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSError = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSGridType = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSPrivilege = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcICProductApplyPriceItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductApplyPriceItemsGridControl.Name = "fld_dgcICProductApplyPriceItemsGridControl";
            this.fld_dgcICProductApplyPriceItemsGridControl.PrintReport = false;
            this.fld_dgcICProductApplyPriceItemsGridControl.Screen = null;
            this.fld_dgcICProductApplyPriceItemsGridControl.Size = new System.Drawing.Size(1005, 362);
            this.fld_dgcICProductApplyPriceItemsGridControl.TabIndex = 0;
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
            this.fld_dgcACDocumentEntrys.BOSComment = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataMember = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = string.Empty;
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
            // DMPAAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1025, 603);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPAAP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProductApplyPriceEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductApplyPriceNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARProductApplyPriceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductApplyPriceEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductApplyPriceStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductApplyPriceItemsGridControl)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSButton fld_btnImportFromExcel;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;

        
	}
}
