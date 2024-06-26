using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductTemplate.UI
{
	/// <summary>
    /// Summary description for DMPDT100
	/// </summary>
    partial class DMPDT100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_btnTemplateAddChild = new BOSComponent.BOSButton(this.components);
            this.fld_btnProductTemplateAddParent = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductTemplateConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlProductTemplateItemTreeListControl = new BOSERP.Modules.ProductTemplate.ICProductTemplateItemsTreeListControl();
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductTemplateStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductTemplateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medICProductTemplateDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductTemplateName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTemplateConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductTemplateItemTreeListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTemplateStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductTemplateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductTemplateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductTemplateDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductTemplateStatus);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICProductTemplateDate);
            this.bosPanel1.Controls.Add(this.fld_medICProductTemplateDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtICProductTemplateName);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtICProductTemplateNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(742, 482);
            this.bosPanel1.TabIndex = 29;
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICProductTemplates";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(211, 39);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductActiveCheckText", "Hoạt động"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 526;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 140);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(736, 339);
            this.xtraTabControl1.TabIndex = 525;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(729, 310);
            this.xtraTabPage2.Text = "Danh sách thuộc tính";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_btnTemplateAddChild);
            this.panel1.Controls.Add(this.fld_btnProductTemplateAddParent);
            this.panel1.Controls.Add(this.fld_lkeFK_ICProductTemplateConfigID);
            this.panel1.Controls.Add(this.bosLabel6);
            this.panel1.Controls.Add(this.fld_trlProductTemplateItemTreeListControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 310);
            this.panel1.TabIndex = 525;
            // 
            // fld_btnTemplateAddChild
            // 
            this.fld_btnTemplateAddChild.BOSComment = null;
            this.fld_btnTemplateAddChild.BOSDataMember = null;
            this.fld_btnTemplateAddChild.BOSDataSource = null;
            this.fld_btnTemplateAddChild.BOSDescription = null;
            this.fld_btnTemplateAddChild.BOSError = null;
            this.fld_btnTemplateAddChild.BOSFieldGroup = null;
            this.fld_btnTemplateAddChild.BOSFieldRelation = null;
            this.fld_btnTemplateAddChild.BOSPrivilege = null;
            this.fld_btnTemplateAddChild.BOSPropertyName = null;
            this.fld_btnTemplateAddChild.Location = new System.Drawing.Point(494, 9);
            this.fld_btnTemplateAddChild.Name = "fld_btnTemplateAddChild";
            this.fld_btnTemplateAddChild.Screen = null;
            this.fld_btnTemplateAddChild.Size = new System.Drawing.Size(81, 27);
            this.fld_btnTemplateAddChild.TabIndex = 2;
            this.fld_btnTemplateAddChild.Text = "Thêm con";
            this.fld_btnTemplateAddChild.Click += new System.EventHandler(this.fld_btnTemplateAddChild_Click);
            // 
            // fld_btnProductTemplateAddParent
            // 
            this.fld_btnProductTemplateAddParent.BOSComment = null;
            this.fld_btnProductTemplateAddParent.BOSDataMember = null;
            this.fld_btnProductTemplateAddParent.BOSDataSource = null;
            this.fld_btnProductTemplateAddParent.BOSDescription = null;
            this.fld_btnProductTemplateAddParent.BOSError = null;
            this.fld_btnProductTemplateAddParent.BOSFieldGroup = null;
            this.fld_btnProductTemplateAddParent.BOSFieldRelation = null;
            this.fld_btnProductTemplateAddParent.BOSPrivilege = null;
            this.fld_btnProductTemplateAddParent.BOSPropertyName = null;
            this.fld_btnProductTemplateAddParent.Location = new System.Drawing.Point(407, 9);
            this.fld_btnProductTemplateAddParent.Name = "fld_btnProductTemplateAddParent";
            this.fld_btnProductTemplateAddParent.Screen = null;
            this.fld_btnProductTemplateAddParent.Size = new System.Drawing.Size(81, 27);
            this.fld_btnProductTemplateAddParent.TabIndex = 1;
            this.fld_btnProductTemplateAddParent.Text = "Thêm cha";
            this.fld_btnProductTemplateAddParent.Click += new System.EventHandler(this.fld_btnProductTemplateAddParent_Click);
            // 
            // fld_lkeFK_ICProductTemplateConfigID
            // 
            this.fld_lkeFK_ICProductTemplateConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSComment = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSDataMember = "FK_ICProductTemplateConfigID";
            this.fld_lkeFK_ICProductTemplateConfigID.BOSDataSource = "ICProductTemplateItems";
            this.fld_lkeFK_ICProductTemplateConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSError = "";
            this.fld_lkeFK_ICProductTemplateConfigID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductTemplateConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductTemplateConfigID.BOSSelectType = "ICProductTemplateConfigRootType";
            this.fld_lkeFK_ICProductTemplateConfigID.BOSSelectTypeValue = "Official";
            this.fld_lkeFK_ICProductTemplateConfigID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductTemplateConfigID.Location = new System.Drawing.Point(70, 13);
            this.fld_lkeFK_ICProductTemplateConfigID.Name = "fld_lkeFK_ICProductTemplateConfigID";
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTemplateConfigNo", "Mã thuộc tính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTemplateConfigName", "Tên thuộc tính")});
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.DisplayMember = "ICProductTemplateConfigName";
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.NullText = "";
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductTemplateConfigID.Properties.ValueMember = "ICProductTemplateConfigID";
            this.fld_lkeFK_ICProductTemplateConfigID.Screen = null;
            this.fld_lkeFK_ICProductTemplateConfigID.Size = new System.Drawing.Size(327, 20);
            this.fld_lkeFK_ICProductTemplateConfigID.TabIndex = 0;
            this.fld_lkeFK_ICProductTemplateConfigID.Tag = "DC";
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(7, 16);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(53, 13);
            this.bosLabel6.TabIndex = 525;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Thuộc tính";
            // 
            // fld_trlProductTemplateItemTreeListControl
            // 
            this.fld_trlProductTemplateItemTreeListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlProductTemplateItemTreeListControl.BOSComment = "";
            this.fld_trlProductTemplateItemTreeListControl.BOSDataMember = null;
            this.fld_trlProductTemplateItemTreeListControl.BOSDataSource = "ICProductTemplateItems";
            this.fld_trlProductTemplateItemTreeListControl.BOSDescription = null;
            this.fld_trlProductTemplateItemTreeListControl.BOSDisplayOption = false;
            this.fld_trlProductTemplateItemTreeListControl.BOSDisplayRoot = true;
            this.fld_trlProductTemplateItemTreeListControl.BOSError = "";
            this.fld_trlProductTemplateItemTreeListControl.BOSFieldGroup = "";
            this.fld_trlProductTemplateItemTreeListControl.BOSFieldRelation = null;
            this.fld_trlProductTemplateItemTreeListControl.BOSPrivilege = "";
            this.fld_trlProductTemplateItemTreeListControl.BOSPropertyName = null;
            this.fld_trlProductTemplateItemTreeListControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlProductTemplateItemTreeListControl.Location = new System.Drawing.Point(5, 45);
            this.fld_trlProductTemplateItemTreeListControl.Name = "fld_trlProductTemplateItemTreeListControl";
            this.fld_trlProductTemplateItemTreeListControl.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlProductTemplateItemTreeListControl.Screen = null;
            this.fld_trlProductTemplateItemTreeListControl.Size = new System.Drawing.Size(721, 262);
            this.fld_trlProductTemplateItemTreeListControl.TabIndex = 524;
            this.fld_trlProductTemplateItemTreeListControl.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(353, 42);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 523;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lkeICProductTemplateStatus
            // 
            this.fld_lkeICProductTemplateStatus.BOSAllowAddNew = false;
            this.fld_lkeICProductTemplateStatus.BOSAllowDummy = false;
            this.fld_lkeICProductTemplateStatus.BOSComment = null;
            this.fld_lkeICProductTemplateStatus.BOSDataMember = "ICProductTemplateStatus";
            this.fld_lkeICProductTemplateStatus.BOSDataSource = "ICProductTemplates";
            this.fld_lkeICProductTemplateStatus.BOSDescription = null;
            this.fld_lkeICProductTemplateStatus.BOSError = null;
            this.fld_lkeICProductTemplateStatus.BOSFieldGroup = null;
            this.fld_lkeICProductTemplateStatus.BOSFieldParent = null;
            this.fld_lkeICProductTemplateStatus.BOSFieldRelation = null;
            this.fld_lkeICProductTemplateStatus.BOSPrivilege = null;
            this.fld_lkeICProductTemplateStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICProductTemplateStatus.BOSSelectType = null;
            this.fld_lkeICProductTemplateStatus.BOSSelectTypeValue = null;
            this.fld_lkeICProductTemplateStatus.CurrentDisplayText = null;
            this.fld_lkeICProductTemplateStatus.Location = new System.Drawing.Point(446, 39);
            this.fld_lkeICProductTemplateStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICProductTemplateStatus.Name = "fld_lkeICProductTemplateStatus";
            this.fld_lkeICProductTemplateStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductTemplateStatus.Properties.ReadOnly = true;
            this.fld_lkeICProductTemplateStatus.Screen = null;
            this.fld_lkeICProductTemplateStatus.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeICProductTemplateStatus.TabIndex = 3;
            this.fld_lkeICProductTemplateStatus.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(127, 42);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(59, 13);
            this.bosLabel5.TabIndex = 520;
            this.bosLabel5.Text = "Thành phẩm";
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
            this.bosLabel4.Location = new System.Drawing.Point(353, 17);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 519;
            this.bosLabel4.Text = "Ngày chứng từ";
            // 
            // fld_dteICProductTemplateDate
            // 
            this.fld_dteICProductTemplateDate.BOSComment = null;
            this.fld_dteICProductTemplateDate.BOSDataMember = "ICProductTemplateDate";
            this.fld_dteICProductTemplateDate.BOSDataSource = "ICProductTemplates";
            this.fld_dteICProductTemplateDate.BOSDescription = null;
            this.fld_dteICProductTemplateDate.BOSError = null;
            this.fld_dteICProductTemplateDate.BOSFieldGroup = null;
            this.fld_dteICProductTemplateDate.BOSFieldRelation = null;
            this.fld_dteICProductTemplateDate.BOSPrivilege = null;
            this.fld_dteICProductTemplateDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductTemplateDate.EditValue = null;
            this.fld_dteICProductTemplateDate.Location = new System.Drawing.Point(446, 13);
            this.fld_dteICProductTemplateDate.MenuManager = this.screenToolbar;
            this.fld_dteICProductTemplateDate.Name = "fld_dteICProductTemplateDate";
            this.fld_dteICProductTemplateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductTemplateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductTemplateDate.Screen = null;
            this.fld_dteICProductTemplateDate.Size = new System.Drawing.Size(128, 20);
            this.fld_dteICProductTemplateDate.TabIndex = 1;
            this.fld_dteICProductTemplateDate.Tag = "DC";
            // 
            // fld_medICProductTemplateDesc
            // 
            this.fld_medICProductTemplateDesc.BOSComment = null;
            this.fld_medICProductTemplateDesc.BOSDataMember = "ICProductTemplateDesc";
            this.fld_medICProductTemplateDesc.BOSDataSource = "ICProductTemplates";
            this.fld_medICProductTemplateDesc.BOSDescription = null;
            this.fld_medICProductTemplateDesc.BOSError = null;
            this.fld_medICProductTemplateDesc.BOSFieldGroup = null;
            this.fld_medICProductTemplateDesc.BOSFieldRelation = null;
            this.fld_medICProductTemplateDesc.BOSPrivilege = null;
            this.fld_medICProductTemplateDesc.BOSPropertyName = "Text";
            this.fld_medICProductTemplateDesc.Location = new System.Drawing.Point(211, 91);
            this.fld_medICProductTemplateDesc.Name = "fld_medICProductTemplateDesc";
            this.fld_medICProductTemplateDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductTemplateDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductTemplateDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductTemplateDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductTemplateDesc.Screen = null;
            this.fld_medICProductTemplateDesc.Size = new System.Drawing.Size(363, 40);
            this.fld_medICProductTemplateDesc.TabIndex = 5;
            this.fld_medICProductTemplateDesc.Tag = "DC";
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICProductTemplateEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICProductTemplates";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(9, 10);
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 516;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICProductTemplates";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(9, 112);
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
            this.fld_lkeFK_HREmployeeID.TabIndex = 515;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(127, 68);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 514;
            this.bosLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtICProductTemplateName
            // 
            this.fld_txtICProductTemplateName.BOSComment = null;
            this.fld_txtICProductTemplateName.BOSDataMember = "ICProductTemplateName";
            this.fld_txtICProductTemplateName.BOSDataSource = "ICProductTemplates";
            this.fld_txtICProductTemplateName.BOSDescription = null;
            this.fld_txtICProductTemplateName.BOSError = null;
            this.fld_txtICProductTemplateName.BOSFieldGroup = null;
            this.fld_txtICProductTemplateName.BOSFieldRelation = null;
            this.fld_txtICProductTemplateName.BOSPrivilege = null;
            this.fld_txtICProductTemplateName.BOSPropertyName = "EditValue";
            this.fld_txtICProductTemplateName.Location = new System.Drawing.Point(211, 65);
            this.fld_txtICProductTemplateName.MenuManager = this.screenToolbar;
            this.fld_txtICProductTemplateName.Name = "fld_txtICProductTemplateName";
            this.fld_txtICProductTemplateName.Screen = null;
            this.fld_txtICProductTemplateName.Size = new System.Drawing.Size(363, 20);
            this.fld_txtICProductTemplateName.TabIndex = 4;
            this.fld_txtICProductTemplateName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(127, 17);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 512;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(127, 93);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 512;
            this.bosLabel2.Text = "Diễn giải";
            // 
            // fld_txtICProductTemplateNo
            // 
            this.fld_txtICProductTemplateNo.BOSComment = null;
            this.fld_txtICProductTemplateNo.BOSDataMember = "ICProductTemplateNo";
            this.fld_txtICProductTemplateNo.BOSDataSource = "ICProductTemplates";
            this.fld_txtICProductTemplateNo.BOSDescription = null;
            this.fld_txtICProductTemplateNo.BOSError = null;
            this.fld_txtICProductTemplateNo.BOSFieldGroup = null;
            this.fld_txtICProductTemplateNo.BOSFieldRelation = null;
            this.fld_txtICProductTemplateNo.BOSPrivilege = null;
            this.fld_txtICProductTemplateNo.BOSPropertyName = "EditValue";
            this.fld_txtICProductTemplateNo.Location = new System.Drawing.Point(211, 13);
            this.fld_txtICProductTemplateNo.MenuManager = this.screenToolbar;
            this.fld_txtICProductTemplateNo.Name = "fld_txtICProductTemplateNo";
            this.fld_txtICProductTemplateNo.Screen = null;
            this.fld_txtICProductTemplateNo.Size = new System.Drawing.Size(128, 20);
            this.fld_txtICProductTemplateNo.TabIndex = 0;
            this.fld_txtICProductTemplateNo.Tag = "DC";
            // 
            // DMPDT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(742, 482);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPDT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTemplateConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductTemplateItemTreeListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTemplateStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductTemplateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductTemplateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductTemplateDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductTemplateName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICProductTemplateNo;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSMemoEdit fld_medICProductTemplateDesc;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteICProductTemplateDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductTemplateStatus;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSERP.Modules.ProductTemplate.ICProductTemplateItemsTreeListControl fld_trlProductTemplateItemTreeListControl;
        private Panel panel1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTemplateConfigID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSButton fld_btnTemplateAddChild;
        private BOSComponent.BOSButton fld_btnProductTemplateAddParent;
	}
}
