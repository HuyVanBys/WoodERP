using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.UI
{
	/// <summary>
	/// Summary description for DMII100
	/// </summary>
	partial class DMAIODA100
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
            this.fld_pteAPInvoiceInEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabInvoiceInItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceInItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeAssetID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems = new BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.ACAdjustIncreaseOrDecreaseAssetItemsGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.UI.ACDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtAPInvoiceInNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInExchangeRate = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).BeginInit();
            this.fld_tabInvoiceInItems.SuspendLayout();
            this.fld_tabPageInvoiceInItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pteAPInvoiceInEmployeePicture
            // 
            this.fld_pteAPInvoiceInEmployeePicture.BOSComment = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataMember = "APInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDataSource = "APInvoiceIns";
            this.fld_pteAPInvoiceInEmployeePicture.BOSDescription = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSError = null;
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldGroup = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSFieldRelation = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSPrivilege = "";
            this.fld_pteAPInvoiceInEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPInvoiceInEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPInvoiceInEmployeePicture.EditValue = "";
            this.fld_pteAPInvoiceInEmployeePicture.FileName = null;
            this.fld_pteAPInvoiceInEmployeePicture.FilePath = null;
            this.fld_pteAPInvoiceInEmployeePicture.Location = new System.Drawing.Point(12, 9);
            this.fld_pteAPInvoiceInEmployeePicture.Name = "fld_pteAPInvoiceInEmployeePicture";
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteAPInvoiceInEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPInvoiceInEmployeePicture.Screen = null;
            this.fld_pteAPInvoiceInEmployeePicture.Size = new System.Drawing.Size(116, 96);
            this.fld_pteAPInvoiceInEmployeePicture.TabIndex = 0;
            this.fld_pteAPInvoiceInEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(12, 111);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(116, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosMemoEdit1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceInItems);
            this.bosPanel1.Controls.Add(this.fld_pteAPInvoiceInEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInNo1);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_lkeAPInvoiceInType);
            this.bosPanel1.Controls.Add(this.bosDateEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtAPInvoiceInExchangeRate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(979, 593);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(139, 69);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(32, 13);
            this.bosLabel2.TabIndex = 370;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Địa chỉ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ACObjectTaxNumber";
            this.bosTextBox1.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(468, 40);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(125, 20);
            this.bosTextBox1.TabIndex = 4;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "ACObjectContactAddressLine3";
            this.bosMemoEdit1.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(226, 66);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(367, 27);
            this.bosMemoEdit1.TabIndex = 6;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(226, 40);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
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
            this.bosLabel4.Location = new System.Drawing.Point(381, 43);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 373;
            this.bosLabel4.Text = "Mã số thuế";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(139, 43);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(63, 13);
            this.fld_lblLabel7.TabIndex = 7;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Mã đối tượng";
            // 
            // fld_tabInvoiceInItems
            // 
            this.fld_tabInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabInvoiceInItems.BOSComment = null;
            this.fld_tabInvoiceInItems.BOSDataMember = null;
            this.fld_tabInvoiceInItems.BOSDataSource = null;
            this.fld_tabInvoiceInItems.BOSDescription = null;
            this.fld_tabInvoiceInItems.BOSError = null;
            this.fld_tabInvoiceInItems.BOSFieldGroup = null;
            this.fld_tabInvoiceInItems.BOSFieldRelation = null;
            this.fld_tabInvoiceInItems.BOSPrivilege = null;
            this.fld_tabInvoiceInItems.BOSPropertyName = null;
            this.fld_tabInvoiceInItems.Location = new System.Drawing.Point(3, 137);
            this.fld_tabInvoiceInItems.Name = "fld_tabInvoiceInItems";
            this.fld_tabInvoiceInItems.Screen = null;
            this.fld_tabInvoiceInItems.SelectedTabPage = this.fld_tabPageInvoiceInItems;
            this.fld_tabInvoiceInItems.Size = new System.Drawing.Size(968, 444);
            this.fld_tabInvoiceInItems.TabIndex = 10;
            this.fld_tabInvoiceInItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceInItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageInvoiceInItems
            // 
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_lkeAssetID);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.bosLabel3);
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems);
            this.fld_tabPageInvoiceInItems.Name = "fld_tabPageInvoiceInItems";
            this.fld_tabPageInvoiceInItems.Size = new System.Drawing.Size(962, 416);
            this.fld_tabPageInvoiceInItems.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeAssetID
            // 
            this.fld_lkeAssetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeAssetID.BOSAllowAddNew = false;
            this.fld_lkeAssetID.BOSAllowDummy = false;
            this.fld_lkeAssetID.BOSComment = "";
            this.fld_lkeAssetID.BOSDataMember = "FK_ACAssetID";
            this.fld_lkeAssetID.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssetItems";
            this.fld_lkeAssetID.BOSDescription = null;
            this.fld_lkeAssetID.BOSError = null;
            this.fld_lkeAssetID.BOSFieldGroup = "";
            this.fld_lkeAssetID.BOSFieldParent = "";
            this.fld_lkeAssetID.BOSFieldRelation = "";
            this.fld_lkeAssetID.BOSPrivilege = "";
            this.fld_lkeAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeAssetID.BOSSelectType = "";
            this.fld_lkeAssetID.BOSSelectTypeValue = "";
            this.fld_lkeAssetID.CurrentDisplayText = null;
            this.fld_lkeAssetID.Location = new System.Drawing.Point(48, 12);
            this.fld_lkeAssetID.Name = "fld_lkeAssetID";
            this.fld_lkeAssetID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAssetID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAssetID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAssetID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAssetID.Properties.ColumnName = null;
            this.fld_lkeAssetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã tài sản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên tài sản")});
            this.fld_lkeAssetID.Properties.DisplayMember = "ACAssetName";
            this.fld_lkeAssetID.Properties.NullText = "";
            this.fld_lkeAssetID.Properties.PopupWidth = 40;
            this.fld_lkeAssetID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeAssetID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAssetID, true);
            this.fld_lkeAssetID.Size = new System.Drawing.Size(903, 20);
            this.fld_lkeAssetID.TabIndex = 372;
            this.fld_lkeAssetID.Tag = "DC";
            this.fld_lkeAssetID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeAssetID_QueryPopUp);
            this.fld_lkeAssetID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeAssetID_KeyUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
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
            this.bosLabel3.Location = new System.Drawing.Point(7, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(35, 13);
            this.bosLabel3.TabIndex = 373;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tài sản";
            // 
            // fld_dgcACAdjustIncreaseOrDecreaseAssetItems
            // 
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSComment = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSDataMember = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssetItems";
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSDescription = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSError = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSFieldGroup = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSFieldRelation = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSGridType = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSPrivilege = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.BOSPropertyName = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.CommodityType = "";
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.Location = new System.Drawing.Point(3, 38);
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.MenuManager = this.screenToolbar;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.Name = "fld_dgcACAdjustIncreaseOrDecreaseAssetItems";
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.PrintReport = false;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.Screen = null;
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.Size = new System.Drawing.Size(948, 375);
            this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems.TabIndex = 0;
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(956, 409);
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(956, 409);
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
            // fld_txtAPInvoiceInNo1
            // 
            this.fld_txtAPInvoiceInNo1.BOSComment = "";
            this.fld_txtAPInvoiceInNo1.BOSDataMember = "ACAdjustIncreaseOrDecreaseAssetNo";
            this.fld_txtAPInvoiceInNo1.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_txtAPInvoiceInNo1.BOSDescription = null;
            this.fld_txtAPInvoiceInNo1.BOSError = null;
            this.fld_txtAPInvoiceInNo1.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInNo1.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInNo1.BOSPrivilege = "";
            this.fld_txtAPInvoiceInNo1.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInNo1.EditValue = "";
            this.fld_txtAPInvoiceInNo1.Location = new System.Drawing.Point(226, 14);
            this.fld_txtAPInvoiceInNo1.Name = "fld_txtAPInvoiceInNo1";
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInNo1.Screen = null;
            this.fld_txtAPInvoiceInNo1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPInvoiceInNo1.TabIndex = 0;
            this.fld_txtAPInvoiceInNo1.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(381, 17);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(72, 13);
            this.bosLabel27.TabIndex = 369;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Ngày chứng từ";
            // 
            // fld_lkeAPInvoiceInType
            // 
            this.fld_lkeAPInvoiceInType.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInType.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInType.BOSComment = "";
            this.fld_lkeAPInvoiceInType.BOSDataMember = "ACAdjustIncreaseOrDecreaseAssetType";
            this.fld_lkeAPInvoiceInType.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_lkeAPInvoiceInType.BOSDescription = null;
            this.fld_lkeAPInvoiceInType.BOSError = null;
            this.fld_lkeAPInvoiceInType.BOSFieldGroup = "";
            this.fld_lkeAPInvoiceInType.BOSFieldParent = "";
            this.fld_lkeAPInvoiceInType.BOSFieldRelation = "";
            this.fld_lkeAPInvoiceInType.BOSPrivilege = "";
            this.fld_lkeAPInvoiceInType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInType.BOSSelectType = "";
            this.fld_lkeAPInvoiceInType.BOSSelectTypeValue = "";
            this.fld_lkeAPInvoiceInType.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInType.Enabled = false;
            this.fld_lkeAPInvoiceInType.Location = new System.Drawing.Point(711, 14);
            this.fld_lkeAPInvoiceInType.Name = "fld_lkeAPInvoiceInType";
            this.fld_lkeAPInvoiceInType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInType.Properties.ColumnName = null;
            this.fld_lkeAPInvoiceInType.Properties.NullText = "";
            this.fld_lkeAPInvoiceInType.Properties.PopupWidth = 40;
            this.fld_lkeAPInvoiceInType.Properties.ReadOnly = true;
            this.fld_lkeAPInvoiceInType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPInvoiceInType, false);
            this.fld_lkeAPInvoiceInType.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeAPInvoiceInType.TabIndex = 2;
            this.fld_lkeAPInvoiceInType.Tag = "DC";
            this.fld_lkeAPInvoiceInType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPInvoiceInType_CloseUp);
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = "";
            this.bosDateEdit2.BOSDataMember = "ACAdjustIncreaseOrDecreaseAssetDate";
            this.bosDateEdit2.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = "";
            this.bosDateEdit2.BOSFieldRelation = "";
            this.bosDateEdit2.BOSPrivilege = "";
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(468, 14);
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
            this.bosDateEdit2.Size = new System.Drawing.Size(125, 20);
            this.bosDateEdit2.TabIndex = 1;
            this.bosDateEdit2.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
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
            this.bosLabel17.Location = new System.Drawing.Point(624, 17);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(65, 13);
            this.bosLabel17.TabIndex = 363;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Loại chứng từ";
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
            this.bosLabel10.Location = new System.Drawing.Point(624, 43);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(53, 13);
            this.bosLabel10.TabIndex = 17;
            this.bosLabel10.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(711, 40);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 5;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(139, 17);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel11.Location = new System.Drawing.Point(624, 69);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(29, 13);
            this.bosLabel11.TabIndex = 19;
            this.bosLabel11.Text = "Tỷ giá";
            // 
            // fld_txtAPInvoiceInExchangeRate
            // 
            this.fld_txtAPInvoiceInExchangeRate.BOSComment = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSDataMember = "ACAdjustIncreaseOrDecreaseAssetExchangeRate";
            this.fld_txtAPInvoiceInExchangeRate.BOSDataSource = "ACAdjustIncreaseOrDecreaseAssets";
            this.fld_txtAPInvoiceInExchangeRate.BOSDescription = null;
            this.fld_txtAPInvoiceInExchangeRate.BOSError = null;
            this.fld_txtAPInvoiceInExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSPrivilege = "";
            this.fld_txtAPInvoiceInExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInExchangeRate.EditValue = "";
            this.fld_txtAPInvoiceInExchangeRate.Location = new System.Drawing.Point(711, 66);
            this.fld_txtAPInvoiceInExchangeRate.Name = "fld_txtAPInvoiceInExchangeRate";
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInExchangeRate.Screen = null;
            this.fld_txtAPInvoiceInExchangeRate.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPInvoiceInExchangeRate.TabIndex = 7;
            this.fld_txtAPInvoiceInExchangeRate.Tag = "DC";
            // 
            // DMAIODA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(979, 593);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAIODA100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPInvoiceInEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).EndInit();
            this.fld_tabInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAdjustIncreaseOrDecreaseAssetItems)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteAPInvoiceInEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        //private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private ACDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInNo1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInType;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private ACAdjustIncreaseOrDecreaseAssetItemsGridControl fld_dgcACAdjustIncreaseOrDecreaseAssetItems;
        private BOSComponent.BOSLookupEdit fld_lkeAssetID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel4;
	}
}
