using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryAdjustment.UI
{
	/// <summary>
	/// Summary description for DMQA100
	/// </summary>
	partial class DMICA100
	{
		private BOSComponent.BOSPictureEdit fld_pteICAdjustmentEmployeePicture;
		private BOSComponent.BOSLabel fld_lblDate;
		private BOSComponent.BOSDateEdit fld_dteICAdjustmentDate;
		private BOSComponent.BOSLabel fld_lblStatus;
		private BOSComponent.BOSTextBox fld_txtICAdjustmentStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSMemoEdit fld_medICAdjustmentReason;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSLabel fld_lblOldQty;		
        private ICAdjustmentItemsGridControl fld_dgcICAdjustmentItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICAdjustmentItems;
		private BOSComponent.BOSTextBox fld_txtICAdjustmentOldQty;
		private BOSComponent.BOSLabel fld_lblDiffQty;
		private BOSComponent.BOSLabel fld_lblNewQty;
		private BOSComponent.BOSTextBox fld_txtICAdjustmentQty;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSTextBox fld_txtICAdjustmentDiffTotalCost;
        private BOSComponent.BOSTextBox fld_txtICAdjustmentDiffQty;


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
            this.fld_pteICAdjustmentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblDate = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICAdjustmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblStatus = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAdjustmentStatus = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICAdjustmentReason = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICAdjustmentItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICAdjustmentItems = new BOSERP.Modules.InventoryAdjustment.ICAdjustmentItemsGridControl();
            this.fld_dgvICAdjustmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblOldQty = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAdjustmentOldQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblDiffQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblNewQty = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAdjustmentQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAdjustmentDiffTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICAdjustmentDiffQty = new BOSComponent.BOSTextBox(this.components);
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_FK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAdjustmentNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICAdjustmentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAdjustmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAdjustmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICAdjustmentReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICAdjustmentItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAdjustmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICAdjustmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentOldQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentDiffTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentDiffQty.Properties)).BeginInit();
            this.BOSLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pteICAdjustmentEmployeePicture
            // 
            this.fld_pteICAdjustmentEmployeePicture.BOSComment = "";
            this.fld_pteICAdjustmentEmployeePicture.BOSDataMember = "ICAdjustmentEmployeePicture";
            this.fld_pteICAdjustmentEmployeePicture.BOSDataSource = "ICAdjustments";
            this.fld_pteICAdjustmentEmployeePicture.BOSDescription = null;
            this.fld_pteICAdjustmentEmployeePicture.BOSError = "";
            this.fld_pteICAdjustmentEmployeePicture.BOSFieldGroup = "";
            this.fld_pteICAdjustmentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICAdjustmentEmployeePicture.BOSPrivilege = "";
            this.fld_pteICAdjustmentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICAdjustmentEmployeePicture.Location = new System.Drawing.Point(2, 3);
            this.fld_pteICAdjustmentEmployeePicture.Name = "fld_pteICAdjustmentEmployeePicture";
            this.fld_pteICAdjustmentEmployeePicture.Screen = null;
            this.fld_pteICAdjustmentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICAdjustmentEmployeePicture.TabIndex = 4;
            this.fld_pteICAdjustmentEmployeePicture.Tag = "DC";
            // 
            // fld_lblDate
            // 
            this.fld_lblDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblDate.Appearance.Options.UseBackColor = true;
            this.fld_lblDate.Appearance.Options.UseForeColor = true;
            this.fld_lblDate.BOSComment = "";
            this.fld_lblDate.BOSDataMember = "";
            this.fld_lblDate.BOSDataSource = "";
            this.fld_lblDate.BOSDescription = null;
            this.fld_lblDate.BOSError = null;
            this.fld_lblDate.BOSFieldGroup = "";
            this.fld_lblDate.BOSFieldRelation = "";
            this.fld_lblDate.BOSPrivilege = "";
            this.fld_lblDate.BOSPropertyName = null;
            this.fld_lblDate.Location = new System.Drawing.Point(133, 63);
            this.fld_lblDate.Name = "fld_lblDate";
            this.fld_lblDate.Screen = null;
            this.fld_lblDate.Size = new System.Drawing.Size(25, 13);
            this.fld_lblDate.TabIndex = 5;
            this.fld_lblDate.Tag = "";
            this.fld_lblDate.Text = "Ngày";
            // 
            // fld_dteICAdjustmentDate
            // 
            this.fld_dteICAdjustmentDate.BOSComment = "";
            this.fld_dteICAdjustmentDate.BOSDataMember = "ICAdjustmentDate";
            this.fld_dteICAdjustmentDate.BOSDataSource = "ICAdjustments";
            this.fld_dteICAdjustmentDate.BOSDescription = null;
            this.fld_dteICAdjustmentDate.BOSError = "";
            this.fld_dteICAdjustmentDate.BOSFieldGroup = "";
            this.fld_dteICAdjustmentDate.BOSFieldRelation = null;
            this.fld_dteICAdjustmentDate.BOSPrivilege = "";
            this.fld_dteICAdjustmentDate.BOSPropertyName = "EditValue";
            this.fld_dteICAdjustmentDate.EditValue = null;
            this.fld_dteICAdjustmentDate.Location = new System.Drawing.Point(187, 60);
            this.fld_dteICAdjustmentDate.Name = "fld_dteICAdjustmentDate";
            this.fld_dteICAdjustmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICAdjustmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICAdjustmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICAdjustmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICAdjustmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICAdjustmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICAdjustmentDate.Screen = null;
            this.fld_dteICAdjustmentDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteICAdjustmentDate.TabIndex = 6;
            this.fld_dteICAdjustmentDate.Tag = "DC";
            // 
            // fld_lblStatus
            // 
            this.fld_lblStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblStatus.Appearance.Options.UseBackColor = true;
            this.fld_lblStatus.Appearance.Options.UseForeColor = true;
            this.fld_lblStatus.BOSComment = "";
            this.fld_lblStatus.BOSDataMember = "";
            this.fld_lblStatus.BOSDataSource = "";
            this.fld_lblStatus.BOSDescription = null;
            this.fld_lblStatus.BOSError = null;
            this.fld_lblStatus.BOSFieldGroup = "";
            this.fld_lblStatus.BOSFieldRelation = "";
            this.fld_lblStatus.BOSPrivilege = "";
            this.fld_lblStatus.BOSPropertyName = null;
            this.fld_lblStatus.Location = new System.Drawing.Point(377, 12);
            this.fld_lblStatus.Name = "fld_lblStatus";
            this.fld_lblStatus.Screen = null;
            this.fld_lblStatus.Size = new System.Drawing.Size(49, 13);
            this.fld_lblStatus.TabIndex = 7;
            this.fld_lblStatus.Tag = "";
            this.fld_lblStatus.Text = "Tình trạng";
            // 
            // fld_txtICAdjustmentStatus
            // 
            this.fld_txtICAdjustmentStatus.BOSComment = "";
            this.fld_txtICAdjustmentStatus.BOSDataMember = "ICAdjustmentStatus";
            this.fld_txtICAdjustmentStatus.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentStatus.BOSDescription = null;
            this.fld_txtICAdjustmentStatus.BOSError = "";
            this.fld_txtICAdjustmentStatus.BOSFieldGroup = "";
            this.fld_txtICAdjustmentStatus.BOSFieldRelation = "";
            this.fld_txtICAdjustmentStatus.BOSPrivilege = "";
            this.fld_txtICAdjustmentStatus.BOSPropertyName = "Text";
            this.fld_txtICAdjustmentStatus.Location = new System.Drawing.Point(434, 9);
            this.fld_txtICAdjustmentStatus.Name = "fld_txtICAdjustmentStatus";
            this.fld_txtICAdjustmentStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICAdjustmentStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentStatus.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentStatus.Properties.ReadOnly = true;
            this.fld_txtICAdjustmentStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentStatus.Screen = null;
            this.fld_txtICAdjustmentStatus.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICAdjustmentStatus.TabIndex = 8;
            this.fld_txtICAdjustmentStatus.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICAdjustments";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(2, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 9;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_medICAdjustmentReason
            // 
            this.fld_medICAdjustmentReason.BOSComment = "";
            this.fld_medICAdjustmentReason.BOSDataMember = "ICAdjustmentReason";
            this.fld_medICAdjustmentReason.BOSDataSource = "ICAdjustments";
            this.fld_medICAdjustmentReason.BOSDescription = null;
            this.fld_medICAdjustmentReason.BOSError = "";
            this.fld_medICAdjustmentReason.BOSFieldGroup = "";
            this.fld_medICAdjustmentReason.BOSFieldRelation = "";
            this.fld_medICAdjustmentReason.BOSPrivilege = "";
            this.fld_medICAdjustmentReason.BOSPropertyName = "Text";
            this.fld_medICAdjustmentReason.Location = new System.Drawing.Point(6, 18);
            this.fld_medICAdjustmentReason.Name = "fld_medICAdjustmentReason";
            this.fld_medICAdjustmentReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICAdjustmentReason.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICAdjustmentReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICAdjustmentReason.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICAdjustmentReason.Screen = null;
            this.fld_medICAdjustmentReason.Size = new System.Drawing.Size(402, 100);
            this.fld_medICAdjustmentReason.TabIndex = 11;
            this.fld_medICAdjustmentReason.Tag = "DC";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeICAdjustmentItemProductPicture);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_grcGroupControl.Controls.Add(this.BOSLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcICAdjustmentItems);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(2, 134);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1122, 285);
            this.fld_grcGroupControl.TabIndex = 12;
            this.fld_grcGroupControl.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeICAdjustmentItemProductPicture
            // 
            this.fld_lkeICAdjustmentItemProductPicture.BOSComment = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSDataMember = "ICAdjustmentItemProductPicture";
            this.fld_lkeICAdjustmentItemProductPicture.BOSDataSource = "ICAdjustmentItems";
            this.fld_lkeICAdjustmentItemProductPicture.BOSDescription = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSError = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSFieldGroup = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSFieldRelation = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSPrivilege = null;
            this.fld_lkeICAdjustmentItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_lkeICAdjustmentItemProductPicture.Location = new System.Drawing.Point(986, 25);
            this.fld_lkeICAdjustmentItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_lkeICAdjustmentItemProductPicture.Name = "fld_lkeICAdjustmentItemProductPicture";
            this.fld_lkeICAdjustmentItemProductPicture.Screen = null;
            this.fld_lkeICAdjustmentItemProductPicture.Size = new System.Drawing.Size(131, 131);
            this.fld_lkeICAdjustmentItemProductPicture.TabIndex = 3;
            this.fld_lkeICAdjustmentItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ICAdjustmentItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = null;
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(63, 30);
            this.fld_lkeFK_ICProductAttributeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(917, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 2;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
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
            this.BOSLabel1.Location = new System.Drawing.Point(10, 33);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(47, 13);
            this.BOSLabel1.TabIndex = 1;
            this.BOSLabel1.Text = "Sản phẩm";
            // 
            // fld_dgcICAdjustmentItems
            // 
            this.fld_dgcICAdjustmentItems.BOSComment = null;
            this.fld_dgcICAdjustmentItems.BOSDataMember = null;
            this.fld_dgcICAdjustmentItems.BOSDataSource = "ICAdjustmentItems";
            this.fld_dgcICAdjustmentItems.BOSDescription = null;
            this.fld_dgcICAdjustmentItems.BOSError = null;
            this.fld_dgcICAdjustmentItems.BOSFieldGroup = null;
            this.fld_dgcICAdjustmentItems.BOSFieldRelation = null;
            this.fld_dgcICAdjustmentItems.BOSGridType = null;
            this.fld_dgcICAdjustmentItems.BOSPrivilege = null;
            this.fld_dgcICAdjustmentItems.BOSPropertyName = null;
            this.fld_dgcICAdjustmentItems.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcICAdjustmentItems.MainView = this.fld_dgvICAdjustmentItems;
            this.fld_dgcICAdjustmentItems.Name = "fld_dgcICAdjustmentItems";
            this.fld_dgcICAdjustmentItems.Screen = null;
            this.fld_dgcICAdjustmentItems.Size = new System.Drawing.Size(975, 222);
            this.fld_dgcICAdjustmentItems.TabIndex = 0;
            this.fld_dgcICAdjustmentItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICAdjustmentItems});
            // 
            // fld_dgvICAdjustmentItems
            // 
            this.fld_dgvICAdjustmentItems.GridControl = this.fld_dgcICAdjustmentItems;
            this.fld_dgvICAdjustmentItems.Name = "fld_dgvICAdjustmentItems";
            this.fld_dgvICAdjustmentItems.PaintStyleName = "Office2003";
            // 
            // fld_lblOldQty
            // 
            this.fld_lblOldQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblOldQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblOldQty.Appearance.Options.UseBackColor = true;
            this.fld_lblOldQty.Appearance.Options.UseForeColor = true;
            this.fld_lblOldQty.BOSComment = "";
            this.fld_lblOldQty.BOSDataMember = "";
            this.fld_lblOldQty.BOSDataSource = "";
            this.fld_lblOldQty.BOSDescription = null;
            this.fld_lblOldQty.BOSError = null;
            this.fld_lblOldQty.BOSFieldGroup = "";
            this.fld_lblOldQty.BOSFieldRelation = "";
            this.fld_lblOldQty.BOSPrivilege = "";
            this.fld_lblOldQty.BOSPropertyName = null;
            this.fld_lblOldQty.Location = new System.Drawing.Point(720, 440);
            this.fld_lblOldQty.Name = "fld_lblOldQty";
            this.fld_lblOldQty.Screen = null;
            this.fld_lblOldQty.Size = new System.Drawing.Size(56, 13);
            this.fld_lblOldQty.TabIndex = 15;
            this.fld_lblOldQty.Tag = "";
            this.fld_lblOldQty.Text = "Số lượng cũ";
            // 
            // fld_txtICAdjustmentOldQty
            // 
            this.fld_txtICAdjustmentOldQty.BOSComment = "";
            this.fld_txtICAdjustmentOldQty.BOSDataMember = "ICAdjustmentOldQty";
            this.fld_txtICAdjustmentOldQty.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentOldQty.BOSDescription = null;
            this.fld_txtICAdjustmentOldQty.BOSError = "";
            this.fld_txtICAdjustmentOldQty.BOSFieldGroup = "";
            this.fld_txtICAdjustmentOldQty.BOSFieldRelation = "";
            this.fld_txtICAdjustmentOldQty.BOSPrivilege = "";
            this.fld_txtICAdjustmentOldQty.BOSPropertyName = "Text";
            this.fld_txtICAdjustmentOldQty.Location = new System.Drawing.Point(785, 437);
            this.fld_txtICAdjustmentOldQty.Name = "fld_txtICAdjustmentOldQty";
            this.fld_txtICAdjustmentOldQty.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICAdjustmentOldQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentOldQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentOldQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentOldQty.Properties.Mask.EditMask = "n";
            this.fld_txtICAdjustmentOldQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICAdjustmentOldQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentOldQty.Properties.ReadOnly = true;
            this.fld_txtICAdjustmentOldQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentOldQty.Screen = null;
            this.fld_txtICAdjustmentOldQty.Size = new System.Drawing.Size(100, 20);
            this.fld_txtICAdjustmentOldQty.TabIndex = 17;
            this.fld_txtICAdjustmentOldQty.Tag = "DC";
            // 
            // fld_lblDiffQty
            // 
            this.fld_lblDiffQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblDiffQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblDiffQty.Appearance.Options.UseBackColor = true;
            this.fld_lblDiffQty.Appearance.Options.UseForeColor = true;
            this.fld_lblDiffQty.BOSComment = "";
            this.fld_lblDiffQty.BOSDataMember = "";
            this.fld_lblDiffQty.BOSDataSource = "";
            this.fld_lblDiffQty.BOSDescription = null;
            this.fld_lblDiffQty.BOSError = null;
            this.fld_lblDiffQty.BOSFieldGroup = "";
            this.fld_lblDiffQty.BOSFieldRelation = "";
            this.fld_lblDiffQty.BOSPrivilege = "";
            this.fld_lblDiffQty.BOSPropertyName = null;
            this.fld_lblDiffQty.Location = new System.Drawing.Point(930, 440);
            this.fld_lblDiffQty.Name = "fld_lblDiffQty";
            this.fld_lblDiffQty.Screen = null;
            this.fld_lblDiffQty.Size = new System.Drawing.Size(88, 13);
            this.fld_lblDiffQty.TabIndex = 18;
            this.fld_lblDiffQty.Tag = "";
            this.fld_lblDiffQty.Text = "Số lượng khác biệt";
            // 
            // fld_lblNewQty
            // 
            this.fld_lblNewQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblNewQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblNewQty.Appearance.Options.UseBackColor = true;
            this.fld_lblNewQty.Appearance.Options.UseForeColor = true;
            this.fld_lblNewQty.BOSComment = "";
            this.fld_lblNewQty.BOSDataMember = "";
            this.fld_lblNewQty.BOSDataSource = "";
            this.fld_lblNewQty.BOSDescription = null;
            this.fld_lblNewQty.BOSError = null;
            this.fld_lblNewQty.BOSFieldGroup = "";
            this.fld_lblNewQty.BOSFieldRelation = "";
            this.fld_lblNewQty.BOSPrivilege = "";
            this.fld_lblNewQty.BOSPropertyName = null;
            this.fld_lblNewQty.Location = new System.Drawing.Point(720, 466);
            this.fld_lblNewQty.Name = "fld_lblNewQty";
            this.fld_lblNewQty.Screen = null;
            this.fld_lblNewQty.Size = new System.Drawing.Size(61, 13);
            this.fld_lblNewQty.TabIndex = 19;
            this.fld_lblNewQty.Tag = "";
            this.fld_lblNewQty.Text = "Số lượng mới";
            // 
            // fld_txtICAdjustmentQty
            // 
            this.fld_txtICAdjustmentQty.BOSComment = "";
            this.fld_txtICAdjustmentQty.BOSDataMember = "ICAdjustmentQty";
            this.fld_txtICAdjustmentQty.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentQty.BOSDescription = null;
            this.fld_txtICAdjustmentQty.BOSError = "";
            this.fld_txtICAdjustmentQty.BOSFieldGroup = "";
            this.fld_txtICAdjustmentQty.BOSFieldRelation = "";
            this.fld_txtICAdjustmentQty.BOSPrivilege = "";
            this.fld_txtICAdjustmentQty.BOSPropertyName = "Text";
            this.fld_txtICAdjustmentQty.Location = new System.Drawing.Point(785, 463);
            this.fld_txtICAdjustmentQty.Name = "fld_txtICAdjustmentQty";
            this.fld_txtICAdjustmentQty.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICAdjustmentQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentQty.Properties.Mask.EditMask = "n";
            this.fld_txtICAdjustmentQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICAdjustmentQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentQty.Properties.ReadOnly = true;
            this.fld_txtICAdjustmentQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentQty.Screen = null;
            this.fld_txtICAdjustmentQty.Size = new System.Drawing.Size(100, 20);
            this.fld_txtICAdjustmentQty.TabIndex = 20;
            this.fld_txtICAdjustmentQty.Tag = "DC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(934, 466);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel.TabIndex = 21;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Giá mua khác biệt";
            // 
            // fld_txtICAdjustmentDiffTotalCost
            // 
            this.fld_txtICAdjustmentDiffTotalCost.BOSComment = "";
            this.fld_txtICAdjustmentDiffTotalCost.BOSDataMember = "ICAdjustmentDiffTotalCost";
            this.fld_txtICAdjustmentDiffTotalCost.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentDiffTotalCost.BOSDescription = null;
            this.fld_txtICAdjustmentDiffTotalCost.BOSError = "";
            this.fld_txtICAdjustmentDiffTotalCost.BOSFieldGroup = "";
            this.fld_txtICAdjustmentDiffTotalCost.BOSFieldRelation = "";
            this.fld_txtICAdjustmentDiffTotalCost.BOSPrivilege = "";
            this.fld_txtICAdjustmentDiffTotalCost.BOSPropertyName = "Text";
            this.fld_txtICAdjustmentDiffTotalCost.Location = new System.Drawing.Point(1024, 463);
            this.fld_txtICAdjustmentDiffTotalCost.Name = "fld_txtICAdjustmentDiffTotalCost";
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICAdjustmentDiffTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentDiffTotalCost.Properties.ReadOnly = true;
            this.fld_txtICAdjustmentDiffTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentDiffTotalCost.Screen = null;
            this.fld_txtICAdjustmentDiffTotalCost.Size = new System.Drawing.Size(100, 20);
            this.fld_txtICAdjustmentDiffTotalCost.TabIndex = 22;
            this.fld_txtICAdjustmentDiffTotalCost.Tag = "DC";
            // 
            // fld_txtICAdjustmentDiffQty
            // 
            this.fld_txtICAdjustmentDiffQty.BOSComment = "";
            this.fld_txtICAdjustmentDiffQty.BOSDataMember = "ICAdjustmentDiffQty";
            this.fld_txtICAdjustmentDiffQty.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentDiffQty.BOSDescription = null;
            this.fld_txtICAdjustmentDiffQty.BOSError = "";
            this.fld_txtICAdjustmentDiffQty.BOSFieldGroup = "";
            this.fld_txtICAdjustmentDiffQty.BOSFieldRelation = "";
            this.fld_txtICAdjustmentDiffQty.BOSPrivilege = "";
            this.fld_txtICAdjustmentDiffQty.BOSPropertyName = "Text";
            this.fld_txtICAdjustmentDiffQty.Enabled = false;
            this.fld_txtICAdjustmentDiffQty.Location = new System.Drawing.Point(1024, 437);
            this.fld_txtICAdjustmentDiffQty.Name = "fld_txtICAdjustmentDiffQty";
            this.fld_txtICAdjustmentDiffQty.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICAdjustmentDiffQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentDiffQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentDiffQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentDiffQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentDiffQty.Properties.ReadOnly = true;
            this.fld_txtICAdjustmentDiffQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentDiffQty.Screen = null;
            this.fld_txtICAdjustmentDiffQty.Size = new System.Drawing.Size(100, 20);
            this.fld_txtICAdjustmentDiffQty.TabIndex = 23;
            this.fld_txtICAdjustmentDiffQty.Tag = "DC";
            // 
            // BOSLine1
            // 
            this.BOSLine1.BOSComment = null;
            this.BOSLine1.BOSDataMember = null;
            this.BOSLine1.BOSDataSource = null;
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = null;
            this.BOSLine1.BOSFieldRelation = null;
            this.BOSLine1.BOSPrivilege = null;
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Controls.Add(this.fld_medICAdjustmentReason);
            this.BOSLine1.Location = new System.Drawing.Point(2, 429);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(414, 126);
            this.BOSLine1.TabIndex = 24;
            this.BOSLine1.TabStop = false;
            this.BOSLine1.Text = "Lý do";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel2.Appearance.Options.UseBackColor = true;
            this.BOSLabel2.Appearance.Options.UseForeColor = true;
            this.BOSLabel2.BOSComment = "";
            this.BOSLabel2.BOSDataMember = "";
            this.BOSLabel2.BOSDataSource = "";
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = "";
            this.BOSLabel2.BOSFieldRelation = "";
            this.BOSLabel2.BOSPrivilege = "";
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(133, 38);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(18, 13);
            this.BOSLabel2.TabIndex = 5;
            this.BOSLabel2.Tag = "";
            this.BOSLabel2.Text = "Kho";
            // 
            // fld_FK_ICStockID
            // 
            this.fld_FK_ICStockID.BOSAllowAddNew = false;
            this.fld_FK_ICStockID.BOSAllowDummy = false;
            this.fld_FK_ICStockID.BOSComment = null;
            this.fld_FK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_FK_ICStockID.BOSDataSource = "ICAdjustments";
            this.fld_FK_ICStockID.BOSDescription = null;
            this.fld_FK_ICStockID.BOSError = null;
            this.fld_FK_ICStockID.BOSFieldGroup = null;
            this.fld_FK_ICStockID.BOSFieldParent = null;
            this.fld_FK_ICStockID.BOSFieldRelation = null;
            this.fld_FK_ICStockID.BOSPrivilege = null;
            this.fld_FK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_FK_ICStockID.BOSSelectType = null;
            this.fld_FK_ICStockID.BOSSelectTypeValue = null;
            this.fld_FK_ICStockID.CurrentDisplayText = null;
            this.fld_FK_ICStockID.Location = new System.Drawing.Point(187, 35);
            this.fld_FK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_FK_ICStockID.Name = "fld_FK_ICStockID";
            this.fld_FK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_FK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_FK_ICStockID.Properties.NullText = "";
            this.fld_FK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_FK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_FK_ICStockID.Screen = null;
            this.fld_FK_ICStockID.Size = new System.Drawing.Size(125, 20);
            this.fld_FK_ICStockID.TabIndex = 25;
            this.fld_FK_ICStockID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(133, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(14, 13);
            this.bosLabel3.TabIndex = 26;
            this.bosLabel3.Text = "Mã";
            // 
            // fld_txtICAdjustmentNo1
            // 
            this.fld_txtICAdjustmentNo1.BOSComment = null;
            this.fld_txtICAdjustmentNo1.BOSDataMember = "ICAdjustmentNo";
            this.fld_txtICAdjustmentNo1.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentNo1.BOSDescription = null;
            this.fld_txtICAdjustmentNo1.BOSError = null;
            this.fld_txtICAdjustmentNo1.BOSFieldGroup = null;
            this.fld_txtICAdjustmentNo1.BOSFieldRelation = null;
            this.fld_txtICAdjustmentNo1.BOSPrivilege = null;
            this.fld_txtICAdjustmentNo1.BOSPropertyName = "EditValue";
            this.fld_txtICAdjustmentNo1.Location = new System.Drawing.Point(187, 9);
            this.fld_txtICAdjustmentNo1.MenuManager = this.screenToolbar;
            this.fld_txtICAdjustmentNo1.Name = "fld_txtICAdjustmentNo1";
            this.fld_txtICAdjustmentNo1.Screen = null;
            this.fld_txtICAdjustmentNo1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICAdjustmentNo1.TabIndex = 27;
            this.fld_txtICAdjustmentNo1.Tag = "DC";
            // 
            // DMICA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1136, 567);
            this.Controls.Add(this.fld_txtICAdjustmentNo1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_FK_ICStockID);
            this.Controls.Add(this.BOSLine1);
            this.Controls.Add(this.fld_pteICAdjustmentEmployeePicture);
            this.Controls.Add(this.BOSLabel2);
            this.Controls.Add(this.fld_lblDate);
            this.Controls.Add(this.fld_dteICAdjustmentDate);
            this.Controls.Add(this.fld_lblStatus);
            this.Controls.Add(this.fld_txtICAdjustmentStatus);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_txtICAdjustmentOldQty);
            this.Controls.Add(this.fld_lblDiffQty);
            this.Controls.Add(this.fld_lblOldQty);
            this.Controls.Add(this.fld_txtICAdjustmentDiffTotalCost);
            this.Controls.Add(this.fld_lblNewQty);
            this.Controls.Add(this.fld_txtICAdjustmentQty);
            this.Controls.Add(this.fld_txtICAdjustmentDiffQty);
            this.Controls.Add(this.fld_lblLabel);
            this.Name = "DMICA100";
            this.Text = "Thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICAdjustmentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAdjustmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAdjustmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICAdjustmentReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICAdjustmentItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAdjustmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICAdjustmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentOldQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentDiffTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentDiffQty.Properties)).EndInit();
            this.BOSLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSPictureEdit fld_lkeICAdjustmentItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLookupEdit fld_FK_ICStockID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICAdjustmentNo1;
	}
}
