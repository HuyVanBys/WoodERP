using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WorkProduct.UI
{
	/// <summary>
	/// Summary description for DMHC100
	/// </summary>
    partial class DMWKP100
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountDiscountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountCostPriceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueInternalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductWorkGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductWorkType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductLockedPurchaseOrder = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductFixedNorm = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductChargeCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabProductWorkItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTasks = new BOSERP.Modules.WorkProduct.ICProductTasksGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddTask = new BOSComponent.BOSButton(this.components);
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductWorkItem = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductWorkMaterialItems = new BOSERP.Modules.WorkProduct.ICProductWorkMaterialItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductWorkItem1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductWorkAssetItems = new BOSERP.Modules.WorkProduct.ICProductWorkAssetItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductWorkGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductWorkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductFixedNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductChargeCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).BeginInit();
            this.fld_tabProductWorkItem.SuspendLayout();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkMaterialItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.fld_tabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkAssetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.splitContainerControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(937, 730);
            this.bosPanel1.TabIndex = 335;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_tabProductWorkItem);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.ScreenHelper.SetShowHelp(this.splitContainerControl1, true);
            this.splitContainerControl1.Size = new System.Drawing.Size(937, 730);
            this.splitContainerControl1.SplitterPosition = 460;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 334);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(931, 111);
            this.bosGroupControl1.TabIndex = 4;
            this.bosGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosGroupControl1.Text = "Tài khoản";
            // 
            // fld_lkeFK_ICProductTypeAccountConfigID
            // 
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataMember = "FK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(110, 31);
            this.fld_lkeFK_ICProductTypeAccountConfigID.Name = "fld_lkeFK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.DisplayMember = "ICProductTypeAccountConfigName";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ValueMember = "ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 344;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductTypeAccountConfigID_CloseUp);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(16, 34);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(75, 13);
            this.bosLabel6.TabIndex = 345;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Text = "Nhóm tài khoản";
            // 
            // fld_lkeFK_ACAccountDiscountID
            // 
            this.fld_lkeFK_ACAccountDiscountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountDiscountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountDiscountID.BOSComment = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSDataMember = "FK_ACAccountDiscountID";
            this.fld_lkeFK_ACAccountDiscountID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountDiscountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSError = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountDiscountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountDiscountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(599, 83);
            this.fld_lkeFK_ACAccountDiscountID.Name = "fld_lkeFK_ACAccountDiscountID";
            this.fld_lkeFK_ACAccountDiscountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountDiscountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountDiscountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountDiscountID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountDiscountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountDiscountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountDiscountID.Screen = null;
            this.fld_lkeFK_ACAccountDiscountID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_ACAccountDiscountID.TabIndex = 5;
            this.fld_lkeFK_ACAccountDiscountID.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.Location = new System.Drawing.Point(526, 86);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 341;
            this.bosLabel17.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel17.Text = "TK Chiết Khấu";
            // 
            // fld_lkeFK_ACAccountSaleReturnID
            // 
            this.fld_lkeFK_ACAccountSaleReturnID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSComment = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDataMember = "FK_ACAccountSaleReturnID";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDescription = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSError = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountSaleReturnID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(366, 83);
            this.fld_lkeFK_ACAccountSaleReturnID.Name = "fld_lkeFK_ACAccountSaleReturnID";
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountSaleReturnID.Screen = null;
            this.fld_lkeFK_ACAccountSaleReturnID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountSaleReturnID.TabIndex = 4;
            this.fld_lkeFK_ACAccountSaleReturnID.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.Location = new System.Drawing.Point(264, 86);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(90, 13);
            this.bosLabel16.TabIndex = 340;
            this.bosLabel16.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel16.Text = "TK hàng bán trả lại";
            // 
            // fld_lkeFK_ACAccountRevenueID
            // 
            this.fld_lkeFK_ACAccountRevenueID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountRevenueID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountRevenueID.BOSComment = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSDataMember = "FK_ACAccountRevenueID";
            this.fld_lkeFK_ACAccountRevenueID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountRevenueID.BOSDescription = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSError = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountRevenueID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountRevenueID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(110, 83);
            this.fld_lkeFK_ACAccountRevenueID.Name = "fld_lkeFK_ACAccountRevenueID";
            this.fld_lkeFK_ACAccountRevenueID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountRevenueID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountRevenueID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountRevenueID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountRevenueID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountRevenueID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountRevenueID.Screen = null;
            this.fld_lkeFK_ACAccountRevenueID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountRevenueID.TabIndex = 3;
            this.fld_lkeFK_ACAccountRevenueID.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.Location = new System.Drawing.Point(16, 86);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(64, 13);
            this.bosLabel15.TabIndex = 338;
            this.bosLabel15.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel15.Text = "TK doanh thu";
            // 
            // fld_lkeFK_ACAccountCostPriceID
            // 
            this.fld_lkeFK_ACAccountCostPriceID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountCostPriceID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountCostPriceID.BOSComment = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSDataMember = "FK_ACAccountCostPriceID";
            this.fld_lkeFK_ACAccountCostPriceID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountCostPriceID.BOSDescription = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSError = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountCostPriceID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountCostPriceID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(599, 57);
            this.fld_lkeFK_ACAccountCostPriceID.Name = "fld_lkeFK_ACAccountCostPriceID";
            this.fld_lkeFK_ACAccountCostPriceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountCostPriceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountCostPriceID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountCostPriceID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountCostPriceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountCostPriceID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountCostPriceID.Screen = null;
            this.fld_lkeFK_ACAccountCostPriceID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_ACAccountCostPriceID.TabIndex = 2;
            this.fld_lkeFK_ACAccountCostPriceID.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.Location = new System.Drawing.Point(526, 60);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(50, 13);
            this.bosLabel14.TabIndex = 335;
            this.bosLabel14.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel14.Text = "TK giá vốn";
            // 
            // fld_lkeFK_ACAccountRevenueInternalID
            // 
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSComment = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDataMember = "FK_ACAccountRevenueInternalID";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDescription = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSError = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(366, 57);
            this.fld_lkeFK_ACAccountRevenueInternalID.Name = "fld_lkeFK_ACAccountRevenueInternalID";
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountRevenueInternalID.Screen = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountRevenueInternalID.TabIndex = 1;
            this.fld_lkeFK_ACAccountRevenueInternalID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.Location = new System.Drawing.Point(264, 60);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(96, 13);
            this.bosLabel13.TabIndex = 334;
            this.bosLabel13.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.Text = "TK doanh thu nội bộ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACAccountID";
            this.bosLookupEdit1.BOSDataSource = "ICProducts";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(110, 57);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.bosLookupEdit1.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(125, 20);
            this.bosLookupEdit1.TabIndex = 0;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(17, 60);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 332;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "TK Tồn kho";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICProductWorkGroupID);
            this.bosGroupControl2.Controls.Add(this.bosLabel1);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductWorkType);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Location = new System.Drawing.Point(496, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(438, 76);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thực hiện";
            // 
            // fld_lkeFK_ICProductWorkGroupID
            // 
            this.fld_lkeFK_ICProductWorkGroupID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductWorkGroupID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductWorkGroupID.BOSComment = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSDataMember = "FK_ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductWorkGroupID.BOSDescription = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSError = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductWorkGroupID.BOSSelectType = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductWorkGroupID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductWorkGroupID.Location = new System.Drawing.Point(110, 51);
            this.fld_lkeFK_ICProductWorkGroupID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductWorkGroupID.Name = "fld_lkeFK_ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductWorkGroupName", "Tên nhóm công việc")});
            this.fld_lkeFK_ICProductWorkGroupID.Properties.DisplayMember = "ICProductWorkGroupName";
            this.fld_lkeFK_ICProductWorkGroupID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.ValueMember = "ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductWorkGroupID, true);
            this.fld_lkeFK_ICProductWorkGroupID.Size = new System.Drawing.Size(272, 20);
            this.fld_lkeFK_ICProductWorkGroupID.TabIndex = 349;
            this.fld_lkeFK_ICProductWorkGroupID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(14, 54);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(75, 13);
            this.bosLabel1.TabIndex = 350;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Nhóm công việc";
            // 
            // fld_lkeICProductWorkType
            // 
            this.fld_lkeICProductWorkType.BOSAllowAddNew = false;
            this.fld_lkeICProductWorkType.BOSAllowDummy = false;
            this.fld_lkeICProductWorkType.BOSComment = null;
            this.fld_lkeICProductWorkType.BOSDataMember = "ICProductWorkType";
            this.fld_lkeICProductWorkType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductWorkType.BOSDescription = null;
            this.fld_lkeICProductWorkType.BOSError = null;
            this.fld_lkeICProductWorkType.BOSFieldGroup = null;
            this.fld_lkeICProductWorkType.BOSFieldParent = null;
            this.fld_lkeICProductWorkType.BOSFieldRelation = null;
            this.fld_lkeICProductWorkType.BOSPrivilege = null;
            this.fld_lkeICProductWorkType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductWorkType.BOSSelectType = null;
            this.fld_lkeICProductWorkType.BOSSelectTypeValue = null;
            this.fld_lkeICProductWorkType.CurrentDisplayText = null;
            this.fld_lkeICProductWorkType.Location = new System.Drawing.Point(110, 25);
            this.fld_lkeICProductWorkType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductWorkType.Name = "fld_lkeICProductWorkType";
            this.fld_lkeICProductWorkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductWorkType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductWorkType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductWorkType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductWorkType, true);
            this.fld_lkeICProductWorkType.Size = new System.Drawing.Size(272, 20);
            this.fld_lkeICProductWorkType.TabIndex = 0;
            this.fld_lkeICProductWorkType.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.Location = new System.Drawing.Point(14, 28);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(90, 13);
            this.bosLabel9.TabIndex = 337;
            this.bosLabel9.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.Text = "Loại hình thực hiện";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel17);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductLockedPurchaseOrder);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductFixedNorm);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductChargeCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkSetDefaultDesc);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel21);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel28);
            this.fld_grcGroupControl5.Controls.Add(this.fld_pteICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_medICProductDesc);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNo);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(480, 325);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = false;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "ICProductType";
            this.fld_lkeICProductType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductType.BOSDescription = null;
            this.fld_lkeICProductType.BOSError = null;
            this.fld_lkeICProductType.BOSFieldGroup = null;
            this.fld_lkeICProductType.BOSFieldParent = null;
            this.fld_lkeICProductType.BOSFieldRelation = null;
            this.fld_lkeICProductType.BOSPrivilege = null;
            this.fld_lkeICProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductType.CurrentDisplayText = null;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(110, 144);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductType, true);
            this.fld_lkeICProductType.Size = new System.Drawing.Size(212, 20);
            this.fld_lkeICProductType.TabIndex = 4;
            this.fld_lkeICProductType.Tag = "DC";
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(9, 147);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel17, true);
            this.fld_lblLabel17.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel17.TabIndex = 345;
            this.fld_lblLabel17.Text = "Loại";
            // 
            // fld_chkICProductLockedPurchaseOrder
            // 
            this.fld_chkICProductLockedPurchaseOrder.BOSComment = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSDataMember = "ICProductLockedPurchaseOrder";
            this.fld_chkICProductLockedPurchaseOrder.BOSDataSource = "ICProducts";
            this.fld_chkICProductLockedPurchaseOrder.BOSDescription = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSError = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldGroup = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldRelation = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPrivilege = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPropertyName = "EditValue";
            this.fld_chkICProductLockedPurchaseOrder.Location = new System.Drawing.Point(108, 297);
            this.fld_chkICProductLockedPurchaseOrder.MenuManager = this.screenToolbar;
            this.fld_chkICProductLockedPurchaseOrder.Name = "fld_chkICProductLockedPurchaseOrder";
            this.fld_chkICProductLockedPurchaseOrder.Properties.Caption = "Khóa mua hàng";
            this.fld_chkICProductLockedPurchaseOrder.Screen = null;
            this.fld_chkICProductLockedPurchaseOrder.Size = new System.Drawing.Size(104, 19);
            this.fld_chkICProductLockedPurchaseOrder.TabIndex = 11;
            this.fld_chkICProductLockedPurchaseOrder.Tag = "DC";
            // 
            // fld_chkICProductFixedNorm
            // 
            this.fld_chkICProductFixedNorm.BOSComment = null;
            this.fld_chkICProductFixedNorm.BOSDataMember = "ICProductFixedNorm";
            this.fld_chkICProductFixedNorm.BOSDataSource = "ICProducts";
            this.fld_chkICProductFixedNorm.BOSDescription = null;
            this.fld_chkICProductFixedNorm.BOSError = null;
            this.fld_chkICProductFixedNorm.BOSFieldGroup = null;
            this.fld_chkICProductFixedNorm.BOSFieldRelation = null;
            this.fld_chkICProductFixedNorm.BOSPrivilege = null;
            this.fld_chkICProductFixedNorm.BOSPropertyName = "EditValue";
            this.fld_chkICProductFixedNorm.Location = new System.Drawing.Point(108, 273);
            this.fld_chkICProductFixedNorm.MenuManager = this.screenToolbar;
            this.fld_chkICProductFixedNorm.Name = "fld_chkICProductFixedNorm";
            this.fld_chkICProductFixedNorm.Properties.Caption = "Định mức cố định";
            this.fld_chkICProductFixedNorm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductFixedNorm, true);
            this.fld_chkICProductFixedNorm.Size = new System.Drawing.Size(107, 19);
            this.fld_chkICProductFixedNorm.TabIndex = 9;
            this.fld_chkICProductFixedNorm.Tag = "DC";
            // 
            // fld_chkICProductChargeCheck
            // 
            this.fld_chkICProductChargeCheck.BOSComment = null;
            this.fld_chkICProductChargeCheck.BOSDataMember = "ICProductChargeCheck";
            this.fld_chkICProductChargeCheck.BOSDataSource = "ICProducts";
            this.fld_chkICProductChargeCheck.BOSDescription = null;
            this.fld_chkICProductChargeCheck.BOSError = null;
            this.fld_chkICProductChargeCheck.BOSFieldGroup = null;
            this.fld_chkICProductChargeCheck.BOSFieldRelation = null;
            this.fld_chkICProductChargeCheck.BOSPrivilege = null;
            this.fld_chkICProductChargeCheck.BOSPropertyName = "EditValue";
            this.fld_chkICProductChargeCheck.Location = new System.Drawing.Point(241, 272);
            this.fld_chkICProductChargeCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductChargeCheck.Name = "fld_chkICProductChargeCheck";
            this.fld_chkICProductChargeCheck.Properties.Caption = "Tính phí";
            this.fld_chkICProductChargeCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductChargeCheck, true);
            this.fld_chkICProductChargeCheck.Size = new System.Drawing.Size(81, 19);
            this.fld_chkICProductChargeCheck.TabIndex = 10;
            this.fld_chkICProductChargeCheck.Tag = "DC";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountID.BOSError = null;
            this.fld_lkeFK_ACAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(110, 246);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(212, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 8;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.Location = new System.Drawing.Point(8, 249);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 343;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.Text = "Tài khoản";
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "ICProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "ICProducts";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(110, 170);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedFK_ICProductGroupID, true);
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(212, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 5;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(110, 196);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã nhà cung cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên nhà cung cấp")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_APSupplierID, true);
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(212, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 6;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(110, 222);
            this.fld_lnkOpenSupplier.MenuManager = this.screenToolbar;
            this.fld_lnkOpenSupplier.Name = "fld_lnkOpenSupplier";
            this.fld_lnkOpenSupplier.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkOpenSupplier, true);
            this.fld_lnkOpenSupplier.Size = new System.Drawing.Size(155, 18);
            this.fld_lnkOpenSupplier.TabIndex = 7;
            this.fld_lnkOpenSupplier.TabStop = false;
            this.fld_lnkOpenSupplier.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkOpenSupplier_OpenLink);
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductName.BOSDataMember = "ICProductName";
            this.fld_txtICProductName.BOSDataSource = "ICProducts";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = null;
            this.fld_txtICProductName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductName.Location = new System.Drawing.Point(110, 51);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductName, true);
            this.fld_txtICProductName.Size = new System.Drawing.Size(352, 20);
            this.fld_txtICProductName.TabIndex = 1;
            this.fld_txtICProductName.Tag = "DC";
            // 
            // fld_chkICProductActiveCheck
            // 
            this.fld_chkICProductActiveCheck.BOSComment = null;
            this.fld_chkICProductActiveCheck.BOSDataMember = "ICProductActiveCheck";
            this.fld_chkICProductActiveCheck.BOSDataSource = "ICProducts";
            this.fld_chkICProductActiveCheck.BOSDescription = null;
            this.fld_chkICProductActiveCheck.BOSError = null;
            this.fld_chkICProductActiveCheck.BOSFieldGroup = null;
            this.fld_chkICProductActiveCheck.BOSFieldRelation = null;
            this.fld_chkICProductActiveCheck.BOSPrivilege = null;
            this.fld_chkICProductActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(241, 297);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductActiveCheck, true);
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkICProductActiveCheck.TabIndex = 12;
            this.fld_chkICProductActiveCheck.Tag = "DC";
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(110, 120);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkSetDefaultDesc, true);
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 3;
            this.fld_lnkSetDefaultDesc.TabStop = false;
            this.fld_lnkSetDefaultDesc.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkSetDefaultDesc_OpenLink);
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.Location = new System.Drawing.Point(9, 28);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel15.TabIndex = 7;
            this.fld_lblLabel15.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel15.Text = "Mã công việc";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(8, 54);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(69, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Tên công việc";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseFont = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.Location = new System.Drawing.Point(9, 79);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel21, true);
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 13;
            this.fld_lblLabel21.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel21.Text = "Mô tả";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.Location = new System.Drawing.Point(9, 173);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 20;
            this.fld_lblLabel28.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel28.Text = "Nhóm hàng";
            // 
            // fld_pteICProductPicture
            // 
            this.fld_pteICProductPicture.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteICProductPicture.BOSDataMember = "ICProductPicture";
            this.fld_pteICProductPicture.BOSDataSource = "ICProducts";
            this.fld_pteICProductPicture.BOSDescription = null;
            this.fld_pteICProductPicture.BOSError = null;
            this.fld_pteICProductPicture.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteICProductPicture.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteICProductPicture.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteICProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICProductPicture.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteICProductPicture.Location = new System.Drawing.Point(337, 144);
            this.fld_pteICProductPicture.Name = "fld_pteICProductPicture";
            this.fld_pteICProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.fld_pteICProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteICProductPicture, true);
            this.fld_pteICProductPicture.Size = new System.Drawing.Size(125, 119);
            this.fld_pteICProductPicture.TabIndex = 13;
            this.fld_pteICProductPicture.Tag = "DC";
            // 
            // fld_medICProductDesc
            // 
            this.fld_medICProductDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICProductDesc.BOSDataMember = "ICProductDesc";
            this.fld_medICProductDesc.BOSDataSource = "ICProducts";
            this.fld_medICProductDesc.BOSDescription = null;
            this.fld_medICProductDesc.BOSError = null;
            this.fld_medICProductDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICProductDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICProductDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICProductDesc.BOSPropertyName = "Text";
            this.fld_medICProductDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICProductDesc.Location = new System.Drawing.Point(110, 77);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICProductDesc, true);
            this.fld_medICProductDesc.Size = new System.Drawing.Size(352, 37);
            this.fld_medICProductDesc.TabIndex = 2;
            this.fld_medICProductDesc.Tag = "DC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(9, 199);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel1, true);
            this.fld_lblLabel1.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel1.TabIndex = 271;
            this.fld_lblLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Text = "Nhà cung cấp";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = null;
            this.fld_txtICProductNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.Location = new System.Drawing.Point(110, 25);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNo, true);
            this.fld_txtICProductNo.Size = new System.Drawing.Size(352, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl1.Controls.Add(this.bosTextBox4);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl1.Controls.Add(this.bosTextBox3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl1.Controls.Add(this.bosTextBox2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEVATID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductPrice01);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductSupplierPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(496, 85);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl1, true);
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(438, 243);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Đơn vị tính && Giá";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.Location = new System.Drawing.Point(14, 133);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(83, 13);
            this.bosLabel12.TabIndex = 348;
            this.bosLabel12.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.Text = "Giá MMTB,CCDC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox4.BOSDataMember = "ICProductEquipmentUnitPrice";
            this.bosTextBox4.BOSDataSource = "ICProducts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.EditValue = "0.00";
            this.bosTextBox4.Location = new System.Drawing.Point(110, 130);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.EditMask = "n";
            this.bosTextBox4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox4, true);
            this.bosTextBox4.Size = new System.Drawing.Size(112, 20);
            this.bosTextBox4.TabIndex = 6;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.Location = new System.Drawing.Point(14, 107);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(46, 13);
            this.bosLabel11.TabIndex = 346;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.Text = "Giá vật tư";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSDataMember = "ICProductMaterialUnitPrice";
            this.bosTextBox3.BOSDataSource = "ICProducts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.EditValue = "0.00";
            this.bosTextBox3.Location = new System.Drawing.Point(110, 104);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.EditMask = "n";
            this.bosTextBox3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, true);
            this.bosTextBox3.Size = new System.Drawing.Size(112, 20);
            this.bosTextBox3.TabIndex = 5;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.Location = new System.Drawing.Point(14, 81);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(70, 13);
            this.bosLabel10.TabIndex = 344;
            this.bosLabel10.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.Text = "Giá nhân công";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSDataMember = "ICProductWorkUnitPrice";
            this.bosTextBox2.BOSDataSource = "ICProducts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "0.00";
            this.bosTextBox2.Location = new System.Drawing.Point(110, 78);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.EditMask = "n";
            this.bosTextBox2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(112, 20);
            this.bosTextBox2.TabIndex = 4;
            this.bosTextBox2.Tag = "DC";
            // 
            // fld_lkeFK_GEVATID
            // 
            this.fld_lkeFK_GEVATID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEVATID.BOSAllowDummy = true;
            this.fld_lkeFK_GEVATID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSDataMember = "FK_GEVATID";
            this.fld_lkeFK_GEVATID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_GEVATID.BOSDescription = null;
            this.fld_lkeFK_GEVATID.BOSError = null;
            this.fld_lkeFK_GEVATID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEVATID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.CurrentDisplayText = null;
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(110, 156);
            this.fld_lkeFK_GEVATID.Name = "fld_lkeFK_GEVATID";
            this.fld_lkeFK_GEVATID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEVATID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEVATID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATName", "Thuế")});
            this.fld_lkeFK_GEVATID.Properties.DisplayMember = "GEVATPercentValue";
            this.fld_lkeFK_GEVATID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GEVATID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEVATID.Properties.ValueMember = "GEVATID";
            this.fld_lkeFK_GEVATID.Screen = null;
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(112, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 7;
            this.fld_lkeFK_GEVATID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Location = new System.Drawing.Point(14, 159);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(25, 13);
            this.bosLabel7.TabIndex = 342;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "Thuế";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.BOSComment = null;
            this.fld_lblLabel16.BOSDataMember = null;
            this.fld_lblLabel16.BOSDataSource = null;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = null;
            this.fld_lblLabel16.BOSFieldRelation = null;
            this.fld_lblLabel16.BOSPrivilege = null;
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(14, 185);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel16, true);
            this.fld_lblLabel16.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel16.TabIndex = 341;
            this.fld_lblLabel16.Text = "ĐVT";
            // 
            // fld_lkeFK_ICProductBasicUnitID
            // 
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSComment = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataMember = "FK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDescription = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSError = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectType = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductBasicUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(110, 182);
            this.fld_lkeFK_ICProductBasicUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Tên đơn vị")});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductBasicUnitID, true);
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(112, 20);
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 8;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.Location = new System.Drawing.Point(14, 52);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel14, true);
            this.fld_lblLabel14.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel14.TabIndex = 266;
            this.fld_lblLabel14.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.Text = "Giá mua";
            // 
            // fld_txtICProductPrice01
            // 
            this.fld_txtICProductPrice01.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductPrice01.BOSDataMember = "ICProductPrice01";
            this.fld_txtICProductPrice01.BOSDataSource = "ICProducts";
            this.fld_txtICProductPrice01.BOSDescription = null;
            this.fld_txtICProductPrice01.BOSError = null;
            this.fld_txtICProductPrice01.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductPrice01.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductPrice01.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductPrice01.BOSPropertyName = "Text";
            this.fld_txtICProductPrice01.EditValue = "0.00";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(110, 26);
            this.fld_txtICProductPrice01.Name = "fld_txtICProductPrice01";
            this.fld_txtICProductPrice01.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductPrice01.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductPrice01.Properties.Mask.EditMask = "n";
            this.fld_txtICProductPrice01.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductPrice01.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductPrice01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductPrice01.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductPrice01, true);
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(112, 20);
            this.fld_txtICProductPrice01.TabIndex = 0;
            this.fld_txtICProductPrice01.Tag = "DC";
            // 
            // fld_txtICProductSupplierPrice
            // 
            this.fld_txtICProductSupplierPrice.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierPrice.BOSDataMember = "ICProductSupplierPrice";
            this.fld_txtICProductSupplierPrice.BOSDataSource = "ICProducts";
            this.fld_txtICProductSupplierPrice.BOSDescription = null;
            this.fld_txtICProductSupplierPrice.BOSError = null;
            this.fld_txtICProductSupplierPrice.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierPrice.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierPrice.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductSupplierPrice.BOSPropertyName = "Text";
            this.fld_txtICProductSupplierPrice.EditValue = "0.00";
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(110, 52);
            this.fld_txtICProductSupplierPrice.Name = "fld_txtICProductSupplierPrice";
            this.fld_txtICProductSupplierPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Mask.EditMask = "n";
            this.fld_txtICProductSupplierPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductSupplierPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierPrice.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductSupplierPrice, true);
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(112, 20);
            this.fld_txtICProductSupplierPrice.TabIndex = 2;
            this.fld_txtICProductSupplierPrice.Tag = "DC";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseFont = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.Location = new System.Drawing.Point(14, 26);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel23, true);
            this.fld_lblLabel23.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel23.TabIndex = 325;
            this.fld_lblLabel23.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel23.Text = "Giá bán";
            // 
            // fld_tabProductWorkItem
            // 
            this.fld_tabProductWorkItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductWorkItem.BOSComment = null;
            this.fld_tabProductWorkItem.BOSDataMember = null;
            this.fld_tabProductWorkItem.BOSDataSource = null;
            this.fld_tabProductWorkItem.BOSDescription = null;
            this.fld_tabProductWorkItem.BOSError = null;
            this.fld_tabProductWorkItem.BOSFieldGroup = null;
            this.fld_tabProductWorkItem.BOSFieldRelation = null;
            this.fld_tabProductWorkItem.BOSPrivilege = null;
            this.fld_tabProductWorkItem.BOSPropertyName = null;
            this.fld_tabProductWorkItem.Location = new System.Drawing.Point(3, 5);
            this.fld_tabProductWorkItem.Name = "fld_tabProductWorkItem";
            this.fld_tabProductWorkItem.Screen = null;
            this.fld_tabProductWorkItem.SelectedTabPage = this.fld_tabTask;
            this.fld_tabProductWorkItem.Size = new System.Drawing.Size(924, 247);
            this.fld_tabProductWorkItem.TabIndex = 27;
            this.fld_tabProductWorkItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabTask,
            this.fld_tabMaterial,
            this.fld_tabAsset});
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcICProductTasks);
            this.fld_tabTask.Controls.Add(this.fld_btnAddTask);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(917, 218);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_dgcICProductTasks
            // 
            this.fld_dgcICProductTasks.AllowDrop = true;
            this.fld_dgcICProductTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductTasks.BOSComment = null;
            this.fld_dgcICProductTasks.BOSDataMember = null;
            this.fld_dgcICProductTasks.BOSDataSource = "ICProductTasks";
            this.fld_dgcICProductTasks.BOSDescription = null;
            this.fld_dgcICProductTasks.BOSError = null;
            this.fld_dgcICProductTasks.BOSFieldGroup = null;
            this.fld_dgcICProductTasks.BOSFieldRelation = null;
            this.fld_dgcICProductTasks.BOSGridType = null;
            this.fld_dgcICProductTasks.BOSPrivilege = null;
            this.fld_dgcICProductTasks.BOSPropertyName = null;
            this.fld_dgcICProductTasks.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductTasks.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcICProductTasks.MainView = this.gridView2;
            this.fld_dgcICProductTasks.Name = "fld_dgcICProductTasks";
            this.fld_dgcICProductTasks.PrintReport = false;
            this.fld_dgcICProductTasks.Screen = null;
            this.fld_dgcICProductTasks.Size = new System.Drawing.Size(911, 179);
            this.fld_dgcICProductTasks.TabIndex = 1;
            this.fld_dgcICProductTasks.Tag = "DC";
            this.fld_dgcICProductTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcICProductTasks;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_btnAddTask
            // 
            this.fld_btnAddTask.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddTask.Appearance.Options.UseForeColor = true;
            this.fld_btnAddTask.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddTask.BOSDataMember = null;
            this.fld_btnAddTask.BOSDataSource = null;
            this.fld_btnAddTask.BOSDescription = null;
            this.fld_btnAddTask.BOSError = null;
            this.fld_btnAddTask.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddTask.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddTask.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddTask.BOSPropertyName = null;
            this.fld_btnAddTask.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddTask.Name = "fld_btnAddTask";
            this.fld_btnAddTask.Screen = null;
            this.fld_btnAddTask.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddTask.TabIndex = 0;
            this.fld_btnAddTask.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddTask.Text = "Thêm task";
            this.fld_btnAddTask.Click += new System.EventHandler(this.fld_btnAddTask_Click);
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_btnAddProductWorkItem);
            this.fld_tabMaterial.Controls.Add(this.fld_dgcICProductWorkMaterialItems);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(917, 218);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_btnAddProductWorkItem
            // 
            this.fld_btnAddProductWorkItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWorkItem.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWorkItem.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem.BOSDataMember = null;
            this.fld_btnAddProductWorkItem.BOSDataSource = null;
            this.fld_btnAddProductWorkItem.BOSDescription = null;
            this.fld_btnAddProductWorkItem.BOSError = null;
            this.fld_btnAddProductWorkItem.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem.BOSPropertyName = null;
            this.fld_btnAddProductWorkItem.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddProductWorkItem.Name = "fld_btnAddProductWorkItem";
            this.fld_btnAddProductWorkItem.Screen = null;
            this.fld_btnAddProductWorkItem.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductWorkItem.TabIndex = 9;
            this.fld_btnAddProductWorkItem.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem.Text = "Thêm vật tư";
            this.fld_btnAddProductWorkItem.Click += new System.EventHandler(this.fld_btnAddProductWorkItem_Click);
            // 
            // fld_dgcICProductWorkMaterialItems
            // 
            this.fld_dgcICProductWorkMaterialItems.AllowDrop = true;
            this.fld_dgcICProductWorkMaterialItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductWorkMaterialItems.BOSComment = null;
            this.fld_dgcICProductWorkMaterialItems.BOSDataMember = null;
            this.fld_dgcICProductWorkMaterialItems.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcICProductWorkMaterialItems.BOSDescription = null;
            this.fld_dgcICProductWorkMaterialItems.BOSError = null;
            this.fld_dgcICProductWorkMaterialItems.BOSFieldGroup = null;
            this.fld_dgcICProductWorkMaterialItems.BOSFieldRelation = null;
            this.fld_dgcICProductWorkMaterialItems.BOSGridType = null;
            this.fld_dgcICProductWorkMaterialItems.BOSPrivilege = null;
            this.fld_dgcICProductWorkMaterialItems.BOSPropertyName = null;
            this.fld_dgcICProductWorkMaterialItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductWorkMaterialItems.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductWorkMaterialItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcICProductWorkMaterialItems.Name = "fld_dgcICProductWorkMaterialItems";
            this.fld_dgcICProductWorkMaterialItems.PrintReport = false;
            this.fld_dgcICProductWorkMaterialItems.Screen = null;
            this.fld_dgcICProductWorkMaterialItems.Size = new System.Drawing.Size(911, 179);
            this.fld_dgcICProductWorkMaterialItems.TabIndex = 1;
            this.fld_dgcICProductWorkMaterialItems.Tag = "DC";
            this.fld_dgcICProductWorkMaterialItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcICProductWorkMaterialItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_tabAsset
            // 
            this.fld_tabAsset.Controls.Add(this.fld_btnAddProductWorkItem1);
            this.fld_tabAsset.Controls.Add(this.fld_dgcICProductWorkAssetItems);
            this.fld_tabAsset.Name = "fld_tabAsset";
            this.fld_tabAsset.Size = new System.Drawing.Size(917, 218);
            this.fld_tabAsset.Text = "Danh sách máy móc thiết bị";
            // 
            // fld_btnAddProductWorkItem1
            // 
            this.fld_btnAddProductWorkItem1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWorkItem1.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWorkItem1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem1.BOSDataMember = null;
            this.fld_btnAddProductWorkItem1.BOSDataSource = null;
            this.fld_btnAddProductWorkItem1.BOSDescription = null;
            this.fld_btnAddProductWorkItem1.BOSError = null;
            this.fld_btnAddProductWorkItem1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem1.BOSPropertyName = null;
            this.fld_btnAddProductWorkItem1.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddProductWorkItem1.Name = "fld_btnAddProductWorkItem1";
            this.fld_btnAddProductWorkItem1.Screen = null;
            this.fld_btnAddProductWorkItem1.Size = new System.Drawing.Size(139, 27);
            this.fld_btnAddProductWorkItem1.TabIndex = 11;
            this.fld_btnAddProductWorkItem1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddProductWorkItem1.Text = "Thêm máy móc, thiết bị";
            this.fld_btnAddProductWorkItem1.Click += new System.EventHandler(this.fld_btnAddProductWorkItem1_Click);
            // 
            // fld_dgcICProductWorkAssetItems
            // 
            this.fld_dgcICProductWorkAssetItems.AllowDrop = true;
            this.fld_dgcICProductWorkAssetItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductWorkAssetItems.BOSComment = null;
            this.fld_dgcICProductWorkAssetItems.BOSDataMember = null;
            this.fld_dgcICProductWorkAssetItems.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcICProductWorkAssetItems.BOSDescription = null;
            this.fld_dgcICProductWorkAssetItems.BOSError = null;
            this.fld_dgcICProductWorkAssetItems.BOSFieldGroup = null;
            this.fld_dgcICProductWorkAssetItems.BOSFieldRelation = null;
            this.fld_dgcICProductWorkAssetItems.BOSGridType = null;
            this.fld_dgcICProductWorkAssetItems.BOSPrivilege = null;
            this.fld_dgcICProductWorkAssetItems.BOSPropertyName = null;
            this.fld_dgcICProductWorkAssetItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductWorkAssetItems.Location = new System.Drawing.Point(3, 35);
            this.fld_dgcICProductWorkAssetItems.MainView = this.gridView1;
            this.fld_dgcICProductWorkAssetItems.Name = "fld_dgcICProductWorkAssetItems";
            this.fld_dgcICProductWorkAssetItems.PrintReport = false;
            this.fld_dgcICProductWorkAssetItems.Screen = null;
            this.fld_dgcICProductWorkAssetItems.Size = new System.Drawing.Size(911, 179);
            this.fld_dgcICProductWorkAssetItems.TabIndex = 10;
            this.fld_dgcICProductWorkAssetItems.Tag = "DC";
            this.fld_dgcICProductWorkAssetItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICProductWorkAssetItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseFont = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.Location = new System.Drawing.Point(363, 414);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 334;
            this.fld_lblLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // DMWKP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(937, 730);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "DMWKP100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMWKP100_Load);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductWorkGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductWorkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductFixedNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductChargeCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).EndInit();
            this.fld_tabProductWorkItem.ResumeLayout(false);
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkMaterialItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.fld_tabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkAssetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSPictureEdit fld_pteICProductPicture;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEVATID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierPrice;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSTabControl fld_tabProductWorkItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private BOSERP.Modules.WorkProduct.ICProductWorkMaterialItemsGridControl fld_dgcICProductWorkMaterialItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private DevExpress.XtraTab.XtraTabPage fld_tabAsset;
        private BOSComponent.BOSButton fld_btnAddProductWorkItem;
        private BOSComponent.BOSButton fld_btnAddProductWorkItem1;
        private ICProductWorkAssetItemsGridControl fld_dgcICProductWorkAssetItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeICProductWorkType;
        private BOSComponent.BOSLabel bosLabel9;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private BOSComponent.BOSButton fld_btnAddTask;
        private ICProductTasksGridControl fld_dgcICProductTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSCheckEdit fld_chkICProductChargeCheck;
        private BOSComponent.BOSCheckEdit fld_chkICProductFixedNorm;
        private BOSComponent.BOSCheckEdit fld_chkICProductLockedPurchaseOrder;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountDiscountID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleReturnID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountCostPriceID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueInternalID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductWorkGroupID;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
