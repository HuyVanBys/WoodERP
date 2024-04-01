using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.PaintProcesses.UI
{
	/// <summary>
	/// Summary description for DMPP100
	/// </summary>
	partial class DMPP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPP100));
            this.fld_lkeFK_ICProductAttributeHTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APSupperID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_txtMMPaintProcessesNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICProductAttributeColorID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMPaintProcessesPaintName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_txtMMPaintProcessesTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMPaintProcessesDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_trlMMPaintProcessesItems = new BOSERP.Modules.PaintProcesses.PaintProcessesItemsTreeListControl();
            this.fld_btnAddGroup = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMPaintProcessesItemGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblProductionNormItemGroup = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkMMPaintProcessesIsActive = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeHTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupperID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeColorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesPaintName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMPaintProcessesDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMPaintProcessesItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesItemGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMPaintProcessesIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_ICProductAttributeHTID
            // 
            this.fld_lkeFK_ICProductAttributeHTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeHTID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeHTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSDataMember = "FK_ICProductAttributeHTID";
            this.fld_lkeFK_ICProductAttributeHTID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeFK_ICProductAttributeHTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeHTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeHTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeHTID.BOSSelectTypeValue = "HTType";
            this.fld_lkeFK_ICProductAttributeHTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeHTID.Location = new System.Drawing.Point(606, 74);
            this.fld_lkeFK_ICProductAttributeHTID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductAttributeHTID.Name = "fld_lkeFK_ICProductAttributeHTID";
            this.fld_lkeFK_ICProductAttributeHTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeHTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeHTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã hoàn thiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên hoàn thiện")});
            this.fld_lkeFK_ICProductAttributeHTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeHTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeHTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeHTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeHTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeHTID, true);
            this.fld_lkeFK_ICProductAttributeHTID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_ICProductAttributeHTID.TabIndex = 35;
            this.fld_lkeFK_ICProductAttributeHTID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(532, 77);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 34;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Hoàn thiện";
            // 
            // fld_lkeFK_APSupperID
            // 
            this.fld_lkeFK_APSupperID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupperID.BOSAllowDummy = false;
            this.fld_lkeFK_APSupperID.BOSComment = null;
            this.fld_lkeFK_APSupperID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupperID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeFK_APSupperID.BOSDescription = null;
            this.fld_lkeFK_APSupperID.BOSError = null;
            this.fld_lkeFK_APSupperID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupperID.BOSFieldParent = null;
            this.fld_lkeFK_APSupperID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupperID.BOSPrivilege = null;
            this.fld_lkeFK_APSupperID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupperID.BOSSelectType = "";
            this.fld_lkeFK_APSupperID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupperID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupperID.Location = new System.Drawing.Point(86, 47);
            this.fld_lkeFK_APSupperID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupperID.Name = "fld_lkeFK_APSupperID";
            this.fld_lkeFK_APSupperID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupperID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupperID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã Công Ty"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên Công Ty")});
            this.fld_lkeFK_APSupperID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupperID.Properties.NullText = "";
            this.fld_lkeFK_APSupperID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupperID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupperID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_APSupperID, true);
            this.fld_lkeFK_APSupperID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_APSupperID.TabIndex = 33;
            this.fld_lkeFK_APSupperID.Tag = "DC";
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "MMPaintProcessesProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "MMPaintProcessess";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(345, 47);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_bedFK_ICProductGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedFK_ICProductGroupID, true);
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(156, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 27;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_txtMMPaintProcessesNo
            // 
            this.fld_txtMMPaintProcessesNo.BOSComment = "";
            this.fld_txtMMPaintProcessesNo.BOSDataMember = "MMPaintProcessesNo";
            this.fld_txtMMPaintProcessesNo.BOSDataSource = "MMPaintProcessess";
            this.fld_txtMMPaintProcessesNo.BOSDescription = null;
            this.fld_txtMMPaintProcessesNo.BOSError = null;
            this.fld_txtMMPaintProcessesNo.BOSFieldGroup = "";
            this.fld_txtMMPaintProcessesNo.BOSFieldRelation = "";
            this.fld_txtMMPaintProcessesNo.BOSPrivilege = "";
            this.fld_txtMMPaintProcessesNo.BOSPropertyName = "Text";
            this.fld_txtMMPaintProcessesNo.EditValue = "";
            this.fld_txtMMPaintProcessesNo.Location = new System.Drawing.Point(86, 21);
            this.fld_txtMMPaintProcessesNo.Name = "fld_txtMMPaintProcessesNo";
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPaintProcessesNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPaintProcessesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPaintProcessesNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPaintProcessesNo, true);
            this.fld_txtMMPaintProcessesNo.Size = new System.Drawing.Size(157, 20);
            this.fld_txtMMPaintProcessesNo.TabIndex = 20;
            this.fld_txtMMPaintProcessesNo.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeColorID
            // 
            this.fld_lkeFK_ICProductAttributeColorID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeColorID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeColorID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSDataMember = "FK_ICProductAttributeColorID";
            this.fld_lkeFK_ICProductAttributeColorID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeFK_ICProductAttributeColorID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeColorID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeColorID.BOSSelectTypeValue = "COLOR";
            this.fld_lkeFK_ICProductAttributeColorID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeColorID.Location = new System.Drawing.Point(345, 21);
            this.fld_lkeFK_ICProductAttributeColorID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductAttributeColorID.Name = "fld_lkeFK_ICProductAttributeColorID";
            this.fld_lkeFK_ICProductAttributeColorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeColorID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeColorID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Hệ sơn")});
            this.fld_lkeFK_ICProductAttributeColorID.Properties.DisplayMember = "ICProductAttributeNo";
            this.fld_lkeFK_ICProductAttributeColorID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeColorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeColorID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeColorID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeColorID, true);
            this.fld_lkeFK_ICProductAttributeColorID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_ICProductAttributeColorID.TabIndex = 22;
            this.fld_lkeFK_ICProductAttributeColorID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeColorID.Validated += new System.EventHandler(this.fld_lkeFK_ICProductAttributeColorID_Validated);
            // 
            // fld_txtMMPaintProcessesPaintName
            // 
            this.fld_txtMMPaintProcessesPaintName.BOSComment = "";
            this.fld_txtMMPaintProcessesPaintName.BOSDataMember = "MMPaintProcessesPaintName";
            this.fld_txtMMPaintProcessesPaintName.BOSDataSource = "MMPaintProcessess";
            this.fld_txtMMPaintProcessesPaintName.BOSDescription = null;
            this.fld_txtMMPaintProcessesPaintName.BOSError = null;
            this.fld_txtMMPaintProcessesPaintName.BOSFieldGroup = "";
            this.fld_txtMMPaintProcessesPaintName.BOSFieldRelation = "";
            this.fld_txtMMPaintProcessesPaintName.BOSPrivilege = "";
            this.fld_txtMMPaintProcessesPaintName.BOSPropertyName = "Text";
            this.fld_txtMMPaintProcessesPaintName.EditValue = "";
            this.fld_txtMMPaintProcessesPaintName.Enabled = false;
            this.fld_txtMMPaintProcessesPaintName.Location = new System.Drawing.Point(606, 21);
            this.fld_txtMMPaintProcessesPaintName.Name = "fld_txtMMPaintProcessesPaintName";
            this.fld_txtMMPaintProcessesPaintName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMPaintProcessesPaintName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPaintProcessesPaintName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPaintProcessesPaintName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPaintProcessesPaintName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPaintProcessesPaintName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPaintProcessesPaintName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPaintProcessesPaintName, true);
            this.fld_txtMMPaintProcessesPaintName.Size = new System.Drawing.Size(157, 20);
            this.fld_txtMMPaintProcessesPaintName.TabIndex = 24;
            this.fld_txtMMPaintProcessesPaintName.Tag = "DC";
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(86, 133);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkSetDefaultDesc, true);
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 32;
            this.fld_lnkSetDefaultDesc.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkSetDefaultDesc_OpenLink);
            // 
            // fld_txtMMPaintProcessesTotalAmount
            // 
            this.fld_txtMMPaintProcessesTotalAmount.BOSComment = "";
            this.fld_txtMMPaintProcessesTotalAmount.BOSDataMember = "MMPaintProcessesTotalAmount";
            this.fld_txtMMPaintProcessesTotalAmount.BOSDataSource = "MMPaintProcessess";
            this.fld_txtMMPaintProcessesTotalAmount.BOSDescription = null;
            this.fld_txtMMPaintProcessesTotalAmount.BOSError = null;
            this.fld_txtMMPaintProcessesTotalAmount.BOSFieldGroup = "";
            this.fld_txtMMPaintProcessesTotalAmount.BOSFieldRelation = "";
            this.fld_txtMMPaintProcessesTotalAmount.BOSPrivilege = "";
            this.fld_txtMMPaintProcessesTotalAmount.BOSPropertyName = "Text";
            this.fld_txtMMPaintProcessesTotalAmount.EditValue = "";
            this.fld_txtMMPaintProcessesTotalAmount.Location = new System.Drawing.Point(835, 48);
            this.fld_txtMMPaintProcessesTotalAmount.Name = "fld_txtMMPaintProcessesTotalAmount";
            this.fld_txtMMPaintProcessesTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMPaintProcessesTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPaintProcessesTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPaintProcessesTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPaintProcessesTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPaintProcessesTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPaintProcessesTotalAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPaintProcessesTotalAmount, true);
            this.fld_txtMMPaintProcessesTotalAmount.Size = new System.Drawing.Size(157, 20);
            this.fld_txtMMPaintProcessesTotalAmount.TabIndex = 29;
            this.fld_txtMMPaintProcessesTotalAmount.Tag = "DC";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.BOSComment = null;
            this.fld_lblLabel17.BOSDataMember = null;
            this.fld_lblLabel17.BOSDataSource = null;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = null;
            this.fld_lblLabel17.BOSFieldRelation = null;
            this.fld_lblLabel17.BOSPrivilege = null;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(15, 76);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel17, true);
            this.fld_lblLabel17.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Text = "Mô tả";
            // 
            // fld_medMMPaintProcessesDesc
            // 
            this.fld_medMMPaintProcessesDesc.BOSComment = "";
            this.fld_medMMPaintProcessesDesc.BOSDataMember = "MMPaintProcessesDesc";
            this.fld_medMMPaintProcessesDesc.BOSDataSource = "MMPaintProcessess";
            this.fld_medMMPaintProcessesDesc.BOSDescription = null;
            this.fld_medMMPaintProcessesDesc.BOSError = null;
            this.fld_medMMPaintProcessesDesc.BOSFieldGroup = "";
            this.fld_medMMPaintProcessesDesc.BOSFieldRelation = "";
            this.fld_medMMPaintProcessesDesc.BOSPrivilege = "";
            this.fld_medMMPaintProcessesDesc.BOSPropertyName = "Text";
            this.fld_medMMPaintProcessesDesc.EditValue = "";
            this.fld_medMMPaintProcessesDesc.Location = new System.Drawing.Point(86, 73);
            this.fld_medMMPaintProcessesDesc.Name = "fld_medMMPaintProcessesDesc";
            this.fld_medMMPaintProcessesDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMPaintProcessesDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMPaintProcessesDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMPaintProcessesDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMPaintProcessesDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMPaintProcessesDesc, true);
            this.fld_medMMPaintProcessesDesc.Size = new System.Drawing.Size(415, 54);
            this.fld_medMMPaintProcessesDesc.TabIndex = 31;
            this.fld_medMMPaintProcessesDesc.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "ICProductNo";
            this.bosLabel4.BOSDataSource = "ICProducts";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(781, 50);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(35, 13);
            this.bosLabel4.TabIndex = 28;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Giá/m2";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = "";
            this.fld_lblLabel28.Location = new System.Drawing.Point(277, 50);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
            this.fld_lblLabel28.Size = new System.Drawing.Size(34, 13);
            this.fld_lblLabel28.TabIndex = 26;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Hệ sơn";
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
            this.bosLabel3.BOSDataMember = "ICProductNo";
            this.bosLabel3.BOSDataSource = "ICProducts";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(532, 24);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(41, 13);
            this.bosLabel3.TabIndex = 23;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Màu sơn";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
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
            this.bosLabel2.Location = new System.Drawing.Point(15, 50);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(44, 13);
            this.bosLabel2.TabIndex = 25;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên NCC";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = "";
            this.fld_lblLabel15.Location = new System.Drawing.Point(15, 24);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel15.TabIndex = 19;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã qui trình";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
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
            this.bosLabel1.Location = new System.Drawing.Point(277, 24);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(38, 13);
            this.bosLabel1.TabIndex = 21;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã màu";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.fld_trlMMPaintProcessesItems);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddGroup);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeMMPaintProcessesItemGroup);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblProductionNormItemGroup);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(5, 156);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(1098, 489);
            this.fld_grcGroupControl5.TabIndex = 36;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Chi tiết";
            // 
            // fld_trlMMPaintProcessesItems
            // 
            this.fld_trlMMPaintProcessesItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMPaintProcessesItems.BOSComment = null;
            this.fld_trlMMPaintProcessesItems.BOSDataMember = null;
            this.fld_trlMMPaintProcessesItems.BOSDataSource = "MMPaintProcessesItems";
            this.fld_trlMMPaintProcessesItems.BOSDescription = null;
            this.fld_trlMMPaintProcessesItems.BOSDisplayOption = false;
            this.fld_trlMMPaintProcessesItems.BOSDisplayRoot = false;
            this.fld_trlMMPaintProcessesItems.BOSError = null;
            this.fld_trlMMPaintProcessesItems.BOSFieldGroup = null;
            this.fld_trlMMPaintProcessesItems.BOSFieldRelation = null;
            this.fld_trlMMPaintProcessesItems.BOSPrivilege = null;
            this.fld_trlMMPaintProcessesItems.BOSPropertyName = null;
            this.fld_trlMMPaintProcessesItems.Location = new System.Drawing.Point(6, 58);
            this.fld_trlMMPaintProcessesItems.Name = "fld_trlMMPaintProcessesItems";
            this.fld_trlMMPaintProcessesItems.Screen = null;
            this.fld_trlMMPaintProcessesItems.Size = new System.Drawing.Size(1087, 423);
            this.fld_trlMMPaintProcessesItems.TabIndex = 87;
            this.fld_trlMMPaintProcessesItems.Tag = "SR";
            this.fld_trlMMPaintProcessesItems.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMPaintProcessesItems_CellValueChanged);
            this.fld_trlMMPaintProcessesItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMPaintProcessesItems_KeyUp);
            // 
            // fld_btnAddGroup
            // 
            this.fld_btnAddGroup.BOSComment = null;
            this.fld_btnAddGroup.BOSDataMember = null;
            this.fld_btnAddGroup.BOSDataSource = null;
            this.fld_btnAddGroup.BOSDescription = null;
            this.fld_btnAddGroup.BOSError = null;
            this.fld_btnAddGroup.BOSFieldGroup = null;
            this.fld_btnAddGroup.BOSFieldRelation = null;
            this.fld_btnAddGroup.BOSPrivilege = null;
            this.fld_btnAddGroup.BOSPropertyName = null;
            this.fld_btnAddGroup.Location = new System.Drawing.Point(746, 25);
            this.fld_btnAddGroup.Name = "fld_btnAddGroup";
            this.fld_btnAddGroup.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddGroup, true);
            this.fld_btnAddGroup.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAddGroup.TabIndex = 86;
            this.fld_btnAddGroup.Text = "Thêm nhóm";
            this.fld_btnAddGroup.Click += new System.EventHandler(this.fld_btnAddGroup_Click);
            // 
            // fld_lkeMMPaintProcessesItemGroup
            // 
            this.fld_lkeMMPaintProcessesItemGroup.BOSAllowAddNew = false;
            this.fld_lkeMMPaintProcessesItemGroup.BOSAllowDummy = true;
            this.fld_lkeMMPaintProcessesItemGroup.BOSComment = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSDataMember = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSDataSource = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSDescription = null;
            this.fld_lkeMMPaintProcessesItemGroup.BOSError = null;
            this.fld_lkeMMPaintProcessesItemGroup.BOSFieldGroup = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSFieldParent = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSFieldRelation = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSPrivilege = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSPropertyName = "EditValue";
            this.fld_lkeMMPaintProcessesItemGroup.BOSSelectType = "";
            this.fld_lkeMMPaintProcessesItemGroup.BOSSelectTypeValue = "";
            this.fld_lkeMMPaintProcessesItemGroup.CurrentDisplayText = null;
            this.fld_lkeMMPaintProcessesItemGroup.Location = new System.Drawing.Point(570, 25);
            this.fld_lkeMMPaintProcessesItemGroup.Name = "fld_lkeMMPaintProcessesItemGroup";
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPaintProcessesItemGroup.Properties.ColumnName = null;
            this.fld_lkeMMPaintProcessesItemGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesItemGroupName", "Tên nhóm")});
            this.fld_lkeMMPaintProcessesItemGroup.Properties.DisplayMember = "MMPaintProcessesItemGroupName";
            this.fld_lkeMMPaintProcessesItemGroup.Properties.NullText = "";
            this.fld_lkeMMPaintProcessesItemGroup.Properties.PopupWidth = 40;
            this.fld_lkeMMPaintProcessesItemGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMPaintProcessesItemGroup.Properties.ValueMember = "MMPaintProcessesItemID";
            this.fld_lkeMMPaintProcessesItemGroup.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMPaintProcessesItemGroup, true);
            this.fld_lkeMMPaintProcessesItemGroup.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeMMPaintProcessesItemGroup.TabIndex = 84;
            this.fld_lkeMMPaintProcessesItemGroup.Tag = "DC";
            this.fld_lkeMMPaintProcessesItemGroup.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeMMPaintProcessesItemGroup_QueryPopUp);
            this.fld_lkeMMPaintProcessesItemGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMPaintProcessesItemGroup_KeyUp);
            // 
            // fld_lblProductionNormItemGroup
            // 
            this.fld_lblProductionNormItemGroup.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblProductionNormItemGroup.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblProductionNormItemGroup.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblProductionNormItemGroup.Appearance.Options.UseBackColor = true;
            this.fld_lblProductionNormItemGroup.Appearance.Options.UseFont = true;
            this.fld_lblProductionNormItemGroup.Appearance.Options.UseForeColor = true;
            this.fld_lblProductionNormItemGroup.BOSComment = "";
            this.fld_lblProductionNormItemGroup.BOSDataMember = "";
            this.fld_lblProductionNormItemGroup.BOSDataSource = "";
            this.fld_lblProductionNormItemGroup.BOSDescription = null;
            this.fld_lblProductionNormItemGroup.BOSError = null;
            this.fld_lblProductionNormItemGroup.BOSFieldGroup = "";
            this.fld_lblProductionNormItemGroup.BOSFieldRelation = "";
            this.fld_lblProductionNormItemGroup.BOSPrivilege = "";
            this.fld_lblProductionNormItemGroup.BOSPropertyName = null;
            this.fld_lblProductionNormItemGroup.Location = new System.Drawing.Point(491, 28);
            this.fld_lblProductionNormItemGroup.Name = "fld_lblProductionNormItemGroup";
            this.fld_lblProductionNormItemGroup.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblProductionNormItemGroup, true);
            this.fld_lblProductionNormItemGroup.Size = new System.Drawing.Size(60, 13);
            this.fld_lblProductionNormItemGroup.TabIndex = 85;
            this.fld_lblProductionNormItemGroup.Tag = "";
            this.fld_lblProductionNormItemGroup.Text = "Thuộc nhóm";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseFont = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(9, 28);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(19, 13);
            this.bosLabel21.TabIndex = 83;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Sơn";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMPaintProcessesItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "IngredientPaint";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(44, 25);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã VT sơn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên VTS"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, true);
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(420, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 82;
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ARCustomerID";
            this.bosLookupEdit1.BOSDataSource = "MMPaintProcessess";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(606, 100);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.bosLookupEdit1.Properties.DisplayMember = "ARCustomerName";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ARCustomerID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(157, 20);
            this.bosLookupEdit1.TabIndex = 38;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(532, 103);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(58, 13);
            this.bosLabel6.TabIndex = 37;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Khách hàng";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.bosLookupEdit3);
            this.panel1.Controls.Add(this.bosLabel8);
            this.panel1.Controls.Add(this.fld_chkMMPaintProcessesIsActive);
            this.panel1.Controls.Add(this.fld_lblLabel15);
            this.panel1.Controls.Add(this.fld_grcGroupControl5);
            this.panel1.Controls.Add(this.bosLookupEdit1);
            this.panel1.Controls.Add(this.bosLabel1);
            this.panel1.Controls.Add(this.bosLabel6);
            this.panel1.Controls.Add(this.bosLabel2);
            this.panel1.Controls.Add(this.bosLabel3);
            this.panel1.Controls.Add(this.bosLookupEdit2);
            this.panel1.Controls.Add(this.fld_lkeFK_ICProductAttributeHTID);
            this.panel1.Controls.Add(this.bosLabel7);
            this.panel1.Controls.Add(this.fld_lblLabel28);
            this.panel1.Controls.Add(this.bosLabel5);
            this.panel1.Controls.Add(this.bosLabel4);
            this.panel1.Controls.Add(this.fld_lkeFK_APSupperID);
            this.panel1.Controls.Add(this.fld_medMMPaintProcessesDesc);
            this.panel1.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.panel1.Controls.Add(this.fld_lblLabel17);
            this.panel1.Controls.Add(this.fld_txtMMPaintProcessesNo);
            this.panel1.Controls.Add(this.fld_txtMMPaintProcessesTotalAmount);
            this.panel1.Controls.Add(this.fld_lkeFK_ICProductAttributeColorID);
            this.panel1.Controls.Add(this.fld_lnkSetDefaultDesc);
            this.panel1.Controls.Add(this.fld_txtMMPaintProcessesPaintName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(1106, 657);
            this.panel1.TabIndex = 39;
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMPaintProcessesStatus";
            this.bosLookupEdit3.BOSDataSource = "MMPaintProcessess";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = "";
            this.bosLookupEdit3.BOSSelectTypeValue = "";
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Enabled = false;
            this.bosLookupEdit3.Location = new System.Drawing.Point(835, 74);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(157, 20);
            this.bosLookupEdit3.TabIndex = 41;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(781, 77);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 40;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tình trạng";
            // 
            // fld_chkMMPaintProcessesIsActive
            // 
            this.fld_chkMMPaintProcessesIsActive.BOSComment = null;
            this.fld_chkMMPaintProcessesIsActive.BOSDataMember = "MMPaintProcessesIsActive";
            this.fld_chkMMPaintProcessesIsActive.BOSDataSource = "MMPaintProcessess";
            this.fld_chkMMPaintProcessesIsActive.BOSDescription = null;
            this.fld_chkMMPaintProcessesIsActive.BOSError = null;
            this.fld_chkMMPaintProcessesIsActive.BOSFieldGroup = null;
            this.fld_chkMMPaintProcessesIsActive.BOSFieldRelation = null;
            this.fld_chkMMPaintProcessesIsActive.BOSPrivilege = null;
            this.fld_chkMMPaintProcessesIsActive.BOSPropertyName = "EditValue";
            this.fld_chkMMPaintProcessesIsActive.Location = new System.Drawing.Point(819, 17);
            this.fld_chkMMPaintProcessesIsActive.MenuManager = this.screenToolbar;
            this.fld_chkMMPaintProcessesIsActive.Name = "fld_chkMMPaintProcessesIsActive";
            this.fld_chkMMPaintProcessesIsActive.Properties.Caption = "Hoạt động";
            this.fld_chkMMPaintProcessesIsActive.Screen = null;
            this.fld_chkMMPaintProcessesIsActive.Size = new System.Drawing.Size(104, 20);
            this.fld_chkMMPaintProcessesIsActive.TabIndex = 39;
            this.fld_chkMMPaintProcessesIsActive.Tag = "DC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "MMPaintProcessesGroupName";
            this.bosLookupEdit2.BOSDataSource = "MMPaintProcessess";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(606, 47);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(157, 20);
            this.bosLookupEdit2.TabIndex = 35;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(532, 50);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(20, 13);
            this.bosLabel7.TabIndex = 34;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Loại";
            // 
            // DMPP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1106, 657);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPP100.IconOptions.Icon")));
            this.Name = "DMPP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeHTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupperID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeColorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesPaintName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMPaintProcessesDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMPaintProcessesItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesItemGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMPaintProcessesIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeHTID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupperID;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtMMPaintProcessesNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeColorID;
        private BOSComponent.BOSTextBox fld_txtMMPaintProcessesPaintName;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSTextBox fld_txtMMPaintProcessesTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSMemoEdit fld_medMMPaintProcessesDesc;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSButton fld_btnAddGroup;
        private BOSComponent.BOSLookupEdit fld_lkeMMPaintProcessesItemGroup;
        private BOSComponent.BOSLabel fld_lblProductionNormItemGroup;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSERP.Modules.PaintProcesses.PaintProcessesItemsTreeListControl fld_trlMMPaintProcessesItems;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel6;
        private ImageList imageList1;
        private BOSPanel panel1;
        private BOSCheckEdit fld_chkMMPaintProcessesIsActive;
        private BOSLookupEdit bosLookupEdit2;
        private BOSLabel bosLabel7;
        private BOSLookupEdit bosLookupEdit3;
        private BOSLabel bosLabel8;
    }
}
