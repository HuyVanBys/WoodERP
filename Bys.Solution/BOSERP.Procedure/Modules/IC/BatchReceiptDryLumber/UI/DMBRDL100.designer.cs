using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchReceiptDryLumber.UI
{
	/// <summary>
	/// Summary description for DMBRDL100
	/// </summary>
	partial class DMBRDL100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBRDL100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ICImportAndExportReasonID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcReceiptItems = new BOSERP.Modules.BatchReceiptDryLumber.ICReceiptItemsGridControl();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeMMUpdatePositionItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkChooseProspectCustomer = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_lkeMMUpdatePositionItemID);
            this.bosPanel1.Controls.Add(this.fld_lnkChooseProspectCustomer);
            this.bosPanel1.Controls.Add(this.bosLabel);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICImportAndExportReasonID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_txtReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.BOSLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(932, 565);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ICImportAndExportReasonID
            // 
            this.fld_lkeFK_ICImportAndExportReasonID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSAllowDummy = false;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSComment = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDataMember = "FK_ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSDescription = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSError = "";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldGroup = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldParent = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSFieldRelation = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSPrivilege = null;
            this.fld_lkeFK_ICImportAndExportReasonID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSSelectType = "ICImportAndExportReasonType";
            this.fld_lkeFK_ICImportAndExportReasonID.BOSSelectTypeValue = "Import";
            this.fld_lkeFK_ICImportAndExportReasonID.CurrentDisplayText = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Location = new System.Drawing.Point(626, 116);
            this.fld_lkeFK_ICImportAndExportReasonID.Name = "fld_lkeFK_ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.ColumnName = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICImportAndExportReasonName", "Lí do nhập/xuất kho điều chỉnh")});
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.DisplayMember = "ICImportAndExportReasonName";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.NullText = "";
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICImportAndExportReasonID.Properties.ValueMember = "ICImportAndExportReasonID";
            this.fld_lkeFK_ICImportAndExportReasonID.Screen = null;
            this.fld_lkeFK_ICImportAndExportReasonID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_ICImportAndExportReasonID.TabIndex = 9;
            this.fld_lkeFK_ICImportAndExportReasonID.Tag = "DC";
            this.fld_lkeFK_ICImportAndExportReasonID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICImportAndExportReasonID_CloseUp);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(539, 119);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(78, 13);
            this.bosLabel12.TabIndex = 591;
            this.bosLabel12.Text = "Lý do nhập xuất";
            // 
            // fld_txtReceiptPackNo
            // 
            this.fld_txtReceiptPackNo.BOSComment = null;
            this.fld_txtReceiptPackNo.BOSDataMember = "ICReceiptPackNo";
            this.fld_txtReceiptPackNo.BOSDataSource = "ICReceipts";
            this.fld_txtReceiptPackNo.BOSDescription = null;
            this.fld_txtReceiptPackNo.BOSError = null;
            this.fld_txtReceiptPackNo.BOSFieldGroup = null;
            this.fld_txtReceiptPackNo.BOSFieldRelation = null;
            this.fld_txtReceiptPackNo.BOSPrivilege = null;
            this.fld_txtReceiptPackNo.BOSPropertyName = "Text";
            this.fld_txtReceiptPackNo.Location = new System.Drawing.Point(626, 90);
            this.fld_txtReceiptPackNo.Name = "fld_txtReceiptPackNo";
            this.fld_txtReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtReceiptPackNo.Screen = null;
            this.fld_txtReceiptPackNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtReceiptPackNo.TabIndex = 8;
            this.fld_txtReceiptPackNo.Tag = "DC";
            this.fld_txtReceiptPackNo.Validated += new System.EventHandler(this.fld_txtICReceiptPackNo_Validated);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(539, 93);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 546;
            this.bosLabel10.Text = "Mã lô hàng";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = "";
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(626, 64);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 7;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(539, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 544;
            this.bosLabel4.Text = "Công đoạn";
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(9, 168);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.ScreenHelper.SetShowHelp(this.fld_tabReceiptItems, true);
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(922, 394);
            this.fld_tabReceiptItems.TabIndex = 8;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_dgcReceiptItems);
            this.fld_tabPageReceiptItems.Controls.Add(this.bosLabel13);
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageReceiptItems, true);
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(920, 369);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            this.fld_tabPageReceiptItems.Paint += new System.Windows.Forms.PaintEventHandler(this.fld_tabPageReceiptItems_Paint);
            // 
            // fld_dgcReceiptItems
            // 
            this.fld_dgcReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptItems.BOSComment = null;
            this.fld_dgcReceiptItems.BOSDataMember = null;
            this.fld_dgcReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcReceiptItems.BOSDescription = null;
            this.fld_dgcReceiptItems.BOSError = null;
            this.fld_dgcReceiptItems.BOSFieldGroup = null;
            this.fld_dgcReceiptItems.BOSFieldRelation = null;
            this.fld_dgcReceiptItems.BOSGridType = null;
            this.fld_dgcReceiptItems.BOSPrivilege = null;
            this.fld_dgcReceiptItems.BOSPropertyName = null;
            this.fld_dgcReceiptItems.CommodityType = "";
            this.fld_dgcReceiptItems.Location = new System.Drawing.Point(10, 36);
            this.fld_dgcReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptItems.Name = "fld_dgcReceiptItems";
            this.fld_dgcReceiptItems.PrintReport = false;
            this.fld_dgcReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcReceiptItems, true);
            this.fld_dgcReceiptItems.Size = new System.Drawing.Size(906, 330);
            this.fld_dgcReceiptItems.TabIndex = 2;
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(10, 13);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 1;
            this.bosLabel13.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID1
            // 
            this.fld_lkeFK_ICProductID1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID1.BOSComment = null;
            this.fld_lkeFK_ICProductID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID1.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID1.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = "Lumber;Verneer;ArtificialBoard;Reuse;Detail";
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID1.Location = new System.Drawing.Point(78, 10);
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID1.Properties.NullText = "";
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID1, true);
            this.fld_lkeFK_ICProductID1.Size = new System.Drawing.Size(838, 20);
            this.fld_lkeFK_ICProductID1.TabIndex = 0;
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            this.fld_lkeFK_ICProductID1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID1_KeyUp);
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageDocumentEntrys, true);
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(906, 388);
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
            this.ScreenHelper.SetShowHelp(this.fld_dgcACDocumentEntrys, true);
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(906, 388);
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
            this.bosLabel7.Location = new System.Drawing.Point(9, 41);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(26, 13);
            this.bosLabel7.TabIndex = 535;
            this.bosLabel7.Text = "TTMT";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = "";
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(626, 38);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductFromDate", "Ngày thực hiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductToDate", "Đến ngày"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductDeliveryDate", "Ngày giao")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMBatchProductID, true);
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 6;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(80, 38);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 2;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel9.Location = new System.Drawing.Point(539, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(38, 13);
            this.bosLabel9.TabIndex = 534;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Lệnh SX";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICReceiptDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(80, 64);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICReceiptDesc, true);
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(412, 46);
            this.fld_medICReceiptDesc.TabIndex = 4;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICStockID1.BOSDescription = null;
            this.fld_lkeFK_ICStockID1.BOSError = "";
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(332, 38);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICStockID1, true);
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 3;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
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
            this.bosLabel6.Location = new System.Drawing.Point(270, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(45, 13);
            this.bosLabel6.TabIndex = 508;
            this.bosLabel6.Text = "Người lập";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(539, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.BOSLabel2, true);
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 508;
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(9, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 482;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = "";
            this.fld_Lablel3.BOSDataSource = "";
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = "";
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(270, 41);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Lablel3, true);
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 482;
            this.fld_Lablel3.Text = "Kho";
            // 
            // fld_dteICReceiptDate
            // 
            this.fld_dteICReceiptDate.BOSComment = null;
            this.fld_dteICReceiptDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate.BOSDescription = null;
            this.fld_dteICReceiptDate.BOSError = null;
            this.fld_dteICReceiptDate.BOSFieldGroup = null;
            this.fld_dteICReceiptDate.BOSFieldRelation = null;
            this.fld_dteICReceiptDate.BOSPrivilege = null;
            this.fld_dteICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate.EditValue = null;
            this.fld_dteICReceiptDate.Location = new System.Drawing.Point(626, 12);
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICReceiptDate, true);
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteICReceiptDate.TabIndex = 5;
            this.fld_dteICReceiptDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(332, 12);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 510;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = null;
            this.fld_txtICReceiptNo.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = null;
            this.fld_txtICReceiptNo.BOSFieldRelation = null;
            this.fld_txtICReceiptNo.BOSPrivilege = null;
            this.fld_txtICReceiptNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(80, 12);
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptNo, true);
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtICReceiptNo.TabIndex = 0;
            this.fld_txtICReceiptNo.Tag = "DC";
            // 
            // fld_lkeMMUpdatePositionItemID
            // 
            this.fld_lkeMMUpdatePositionItemID.BOSAllowAddNew = true;
            this.fld_lkeMMUpdatePositionItemID.BOSAllowDummy = true;
            this.fld_lkeMMUpdatePositionItemID.BOSComment = "";
            this.fld_lkeMMUpdatePositionItemID.BOSDataMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.BOSDataSource = "ICReceipts";
            this.fld_lkeMMUpdatePositionItemID.BOSDescription = null;
            this.fld_lkeMMUpdatePositionItemID.BOSError = null;
            this.fld_lkeMMUpdatePositionItemID.BOSFieldGroup = "";
            this.fld_lkeMMUpdatePositionItemID.BOSFieldParent = "";
            this.fld_lkeMMUpdatePositionItemID.BOSFieldRelation = "";
            this.fld_lkeMMUpdatePositionItemID.BOSPrivilege = "";
            this.fld_lkeMMUpdatePositionItemID.BOSPropertyName = "EditValue";
            this.fld_lkeMMUpdatePositionItemID.BOSSelectType = "";
            this.fld_lkeMMUpdatePositionItemID.BOSSelectTypeValue = "";
            this.fld_lkeMMUpdatePositionItemID.CurrentDisplayText = null;
            this.fld_lkeMMUpdatePositionItemID.Location = new System.Drawing.Point(626, 142);
            this.fld_lkeMMUpdatePositionItemID.Name = "fld_lkeMMUpdatePositionItemID";
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMUpdatePositionItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMUpdatePositionItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMUpdatePositionItemID.Properties.ColumnName = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMUpdatePositionItemPositionName", "Vị trí")});
            this.fld_lkeMMUpdatePositionItemID.Properties.DisplayMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Properties.NullText = "";
            this.fld_lkeMMUpdatePositionItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMUpdatePositionItemID.Properties.ValueMember = "MMUpdatePositionItemPositionName";
            this.fld_lkeMMUpdatePositionItemID.Screen = null;
            this.fld_lkeMMUpdatePositionItemID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeMMUpdatePositionItemID.TabIndex = 663;
            this.fld_lkeMMUpdatePositionItemID.Tag = "DC";
            this.fld_lkeMMUpdatePositionItemID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMUpdatePositionItemID_CloseUp);
            // 
            // fld_lnkChooseProspectCustomer
            // 
            this.fld_lnkChooseProspectCustomer.EditValue = "Thêm mới vị trí";
            this.fld_lnkChooseProspectCustomer.Location = new System.Drawing.Point(792, 144);
            this.fld_lnkChooseProspectCustomer.Name = "fld_lnkChooseProspectCustomer";
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkChooseProspectCustomer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkChooseProspectCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkChooseProspectCustomer.Size = new System.Drawing.Size(78, 18);
            this.fld_lnkChooseProspectCustomer.TabIndex = 662;
            this.fld_lnkChooseProspectCustomer.TabStop = false;
            this.fld_lnkChooseProspectCustomer.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkChooseProspectCustomer_OpenLink);
            // 
            // bosLabel
            // 
            this.bosLabel.BOSComment = null;
            this.bosLabel.BOSDataMember = null;
            this.bosLabel.BOSDataSource = null;
            this.bosLabel.BOSDescription = null;
            this.bosLabel.BOSError = null;
            this.bosLabel.BOSFieldGroup = null;
            this.bosLabel.BOSFieldRelation = null;
            this.bosLabel.BOSPrivilege = null;
            this.bosLabel.BOSPropertyName = null;
            this.bosLabel.Location = new System.Drawing.Point(539, 145);
            this.bosLabel.Name = "bosLabel";
            this.bosLabel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel, true);
            this.bosLabel.Size = new System.Drawing.Size(21, 13);
            this.bosLabel.TabIndex = 661;
            this.bosLabel.Text = "Vị trí";
            // 
            // DMBRDL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(932, 565);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBRDL100.IconOptions.Icon")));
            this.Name = "DMBRDL100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICImportAndExportReasonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkChooseProspectCustomer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSDateEdit fld_dteICReceiptDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private BOSComponent.BOSLabel bosLabel13;
        private ItemLookupEdit fld_lkeFK_ICProductID1;
        private BOSERP.Modules.BatchReceiptDryLumber.ICReceiptItemsGridControl fld_dgcReceiptItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtReceiptPackNo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICImportAndExportReasonID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeMMUpdatePositionItemID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkChooseProspectCustomer;
        private BOSComponent.BOSLabel bosLabel;
    }
}
