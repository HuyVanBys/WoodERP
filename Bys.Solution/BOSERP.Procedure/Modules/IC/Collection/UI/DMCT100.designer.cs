using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Collection.UI
{
	/// <summary>
    /// Summary description for DMCT100
	/// </summary>
    partial class DMCT100
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
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICCollectionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteMMProductionNormProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICCollectionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICCollectionName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICCollectionDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabProductWorkItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICCollectionItems = new BOSERP.Modules.Collection.ICCollectionItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICCollectionItemWorks = new BOSERP.Modules.Collection.ICCollectionItemWorksGridControl();
            this.fld_btnAddProductWork = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICCollectionItemMaterials = new BOSERP.Modules.Collection.ICCollectionItemMaterialsGridControl();
            this.fld_btnAddProductMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICCollectionDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICCollectionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICCollectionDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).BeginInit();
            this.fld_tabProductWorkItem.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItemWorks)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItemMaterials)).BeginInit();
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
            this.bosPanel1.Size = new System.Drawing.Size(937, 491);
            this.bosPanel1.TabIndex = 335;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_tabProductWorkItem);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.ScreenHelper.SetShowHelp(this.splitContainerControl1, true);
            this.splitContainerControl1.Size = new System.Drawing.Size(937, 491);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICCollectionDate);
            this.fld_grcGroupControl5.Controls.Add(this.fld_pteMMProductionNormProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICCollectionNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICCollectionName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_medICCollectionDesc);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(924, 172);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(427, 34);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(70, 13);
            this.bosLabel5.TabIndex = 142;
            this.bosLabel5.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.Text = "Ngày chứng từ";
            // 
            // fld_dteICCollectionDate
            // 
            this.fld_dteICCollectionDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteICCollectionDate.BOSDataMember = "ICCollectionDate";
            this.fld_dteICCollectionDate.BOSDataSource = "ICCollections";
            this.fld_dteICCollectionDate.BOSDescription = null;
            this.fld_dteICCollectionDate.BOSError = null;
            this.fld_dteICCollectionDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteICCollectionDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteICCollectionDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteICCollectionDate.BOSPropertyName = "EditValue";
            this.fld_dteICCollectionDate.EditValue = null;
            this.fld_dteICCollectionDate.Location = new System.Drawing.Point(503, 31);
            this.fld_dteICCollectionDate.Name = "fld_dteICCollectionDate";
            this.fld_dteICCollectionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICCollectionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICCollectionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICCollectionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICCollectionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICCollectionDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICCollectionDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICCollectionDate, true);
            this.fld_dteICCollectionDate.Size = new System.Drawing.Size(180, 20);
            this.fld_dteICCollectionDate.TabIndex = 1;
            this.fld_dteICCollectionDate.Tag = "DC";
            // 
            // fld_pteMMProductionNormProductPicture
            // 
            this.fld_pteMMProductionNormProductPicture.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_pteMMProductionNormProductPicture.BOSDataMember = "MMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormProductPicture.BOSDescription = null;
            this.fld_pteMMProductionNormProductPicture.BOSError = null;
            this.fld_pteMMProductionNormProductPicture.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_pteMMProductionNormProductPicture.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_pteMMProductionNormProductPicture.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_pteMMProductionNormProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormProductPicture.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_pteMMProductionNormProductPicture.Location = new System.Drawing.Point(9, 25);
            this.fld_pteMMProductionNormProductPicture.Name = "fld_pteMMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteMMProductionNormProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteMMProductionNormProductPicture, true);
            this.fld_pteMMProductionNormProductPicture.Size = new System.Drawing.Size(120, 112);
            this.fld_pteMMProductionNormProductPicture.TabIndex = 136;
            this.fld_pteMMProductionNormProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICCollections";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(10, 143);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 4;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(145, 34);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel2.TabIndex = 138;
            this.fld_lblLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.Text = "Mã bộ sưu tập";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(145, 60);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel3.TabIndex = 140;
            this.fld_lblLabel3.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel3.Text = "Tên bộ sưu tập";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(145, 86);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 141;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtICCollectionNo
            // 
            this.fld_txtICCollectionNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionNo.BOSDataMember = "ICCollectionNo";
            this.fld_txtICCollectionNo.BOSDataSource = "ICCollections";
            this.fld_txtICCollectionNo.BOSDescription = null;
            this.fld_txtICCollectionNo.BOSError = "Mã chứng từ không thể rỗng.";
            this.fld_txtICCollectionNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionNo.BOSPropertyName = "Text";
            this.fld_txtICCollectionNo.Location = new System.Drawing.Point(228, 31);
            this.fld_txtICCollectionNo.Name = "fld_txtICCollectionNo";
            this.fld_txtICCollectionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICCollectionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICCollectionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICCollectionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICCollectionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICCollectionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICCollectionNo.Screen = null;
            this.fld_txtICCollectionNo.Size = new System.Drawing.Size(180, 20);
            this.fld_txtICCollectionNo.TabIndex = 0;
            this.fld_txtICCollectionNo.Tag = "DC";
            // 
            // fld_txtICCollectionName
            // 
            this.fld_txtICCollectionName.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionName.BOSDataMember = "ICCollectionName";
            this.fld_txtICCollectionName.BOSDataSource = "ICCollections";
            this.fld_txtICCollectionName.BOSDescription = null;
            this.fld_txtICCollectionName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtICCollectionName.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionName.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionName.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtICCollectionName.BOSPropertyName = "Text";
            this.fld_txtICCollectionName.Location = new System.Drawing.Point(228, 57);
            this.fld_txtICCollectionName.Name = "fld_txtICCollectionName";
            this.fld_txtICCollectionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICCollectionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICCollectionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICCollectionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICCollectionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICCollectionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICCollectionName.Screen = null;
            this.fld_txtICCollectionName.Size = new System.Drawing.Size(455, 20);
            this.fld_txtICCollectionName.TabIndex = 2;
            this.fld_txtICCollectionName.Tag = "DC";
            // 
            // fld_medICCollectionDesc
            // 
            this.fld_medICCollectionDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medICCollectionDesc.BOSDataMember = "ICCollectionDesc";
            this.fld_medICCollectionDesc.BOSDataSource = "ICCollections";
            this.fld_medICCollectionDesc.BOSDescription = null;
            this.fld_medICCollectionDesc.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medICCollectionDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medICCollectionDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medICCollectionDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medICCollectionDesc.BOSPropertyName = "Text";
            this.fld_medICCollectionDesc.Location = new System.Drawing.Point(228, 83);
            this.fld_medICCollectionDesc.Name = "fld_medICCollectionDesc";
            this.fld_medICCollectionDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICCollectionDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICCollectionDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICCollectionDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICCollectionDesc.Screen = null;
            this.fld_medICCollectionDesc.Size = new System.Drawing.Size(455, 40);
            this.fld_medICCollectionDesc.TabIndex = 3;
            this.fld_medICCollectionDesc.Tag = "DC";
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
            this.fld_tabProductWorkItem.Location = new System.Drawing.Point(3, 10);
            this.fld_tabProductWorkItem.Name = "fld_tabProductWorkItem";
            this.fld_tabProductWorkItem.Screen = null;
            this.fld_tabProductWorkItem.SelectedTabPage = this.fld_tabProduct;
            this.fld_tabProductWorkItem.Size = new System.Drawing.Size(924, 292);
            this.fld_tabProductWorkItem.TabIndex = 0;
            this.fld_tabProductWorkItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_btnAddProduct);
            this.fld_tabProduct.Controls.Add(this.fld_dgcICCollectionItems);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.fld_tabProduct.Size = new System.Drawing.Size(917, 263);
            this.fld_tabProduct.Text = "Danh sách sản phẩm";
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProduct.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProduct.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProduct.TabIndex = 0;
            this.fld_btnAddProduct.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // fld_dgcICCollectionItems
            // 
            this.fld_dgcICCollectionItems.AllowDrop = true;
            this.fld_dgcICCollectionItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICCollectionItems.BOSComment = null;
            this.fld_dgcICCollectionItems.BOSDataMember = null;
            this.fld_dgcICCollectionItems.BOSDataSource = "ICCollectionItems";
            this.fld_dgcICCollectionItems.BOSDescription = null;
            this.fld_dgcICCollectionItems.BOSError = null;
            this.fld_dgcICCollectionItems.BOSFieldGroup = null;
            this.fld_dgcICCollectionItems.BOSFieldRelation = null;
            this.fld_dgcICCollectionItems.BOSGridType = null;
            this.fld_dgcICCollectionItems.BOSPrivilege = null;
            this.fld_dgcICCollectionItems.BOSPropertyName = null;
            this.fld_dgcICCollectionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICCollectionItems.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICCollectionItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcICCollectionItems.Name = "fld_dgcICCollectionItems";
            this.fld_dgcICCollectionItems.PrintReport = false;
            this.fld_dgcICCollectionItems.Screen = null;
            this.fld_dgcICCollectionItems.Size = new System.Drawing.Size(911, 223);
            this.fld_dgcICCollectionItems.TabIndex = 1;
            this.fld_dgcICCollectionItems.Tag = "DC";
            this.fld_dgcICCollectionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcICCollectionItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICCollectionItemWorks);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProductWork);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(917, 263);
            this.xtraTabPage1.Text = "Danh sách công việc";
            // 
            // fld_dgcICCollectionItemWorks
            // 
            this.fld_dgcICCollectionItemWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICCollectionItemWorks.BOSComment = null;
            this.fld_dgcICCollectionItemWorks.BOSDataMember = null;
            this.fld_dgcICCollectionItemWorks.BOSDataSource = "ICCollectionItems";
            this.fld_dgcICCollectionItemWorks.BOSDescription = null;
            this.fld_dgcICCollectionItemWorks.BOSError = null;
            this.fld_dgcICCollectionItemWorks.BOSFieldGroup = null;
            this.fld_dgcICCollectionItemWorks.BOSFieldRelation = null;
            this.fld_dgcICCollectionItemWorks.BOSGridType = null;
            this.fld_dgcICCollectionItemWorks.BOSPrivilege = null;
            this.fld_dgcICCollectionItemWorks.BOSPropertyName = null;
            this.fld_dgcICCollectionItemWorks.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICCollectionItemWorks.MenuManager = this.screenToolbar;
            this.fld_dgcICCollectionItemWorks.Name = "fld_dgcICCollectionItemWorks";
            this.fld_dgcICCollectionItemWorks.PrintReport = false;
            this.fld_dgcICCollectionItemWorks.Screen = null;
            this.fld_dgcICCollectionItemWorks.Size = new System.Drawing.Size(911, 223);
            this.fld_dgcICCollectionItemWorks.TabIndex = 2;
            // 
            // fld_btnAddProductWork
            // 
            this.fld_btnAddProductWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWork.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductWork.BOSDataMember = null;
            this.fld_btnAddProductWork.BOSDataSource = null;
            this.fld_btnAddProductWork.BOSDescription = null;
            this.fld_btnAddProductWork.BOSError = null;
            this.fld_btnAddProductWork.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductWork.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductWork.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductWork.BOSPropertyName = null;
            this.fld_btnAddProductWork.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddProductWork.Name = "fld_btnAddProductWork";
            this.fld_btnAddProductWork.Screen = null;
            this.fld_btnAddProductWork.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductWork.TabIndex = 1;
            this.fld_btnAddProductWork.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductWork.Text = "Thêm công việc";
            this.fld_btnAddProductWork.Click += new System.EventHandler(this.fld_btnAddProductWork_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcICCollectionItemMaterials);
            this.xtraTabPage2.Controls.Add(this.fld_btnAddProductMaterial);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(917, 263);
            this.xtraTabPage2.Text = "Danh sách vật tư";
            // 
            // fld_dgcICCollectionItemMaterials
            // 
            this.fld_dgcICCollectionItemMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICCollectionItemMaterials.BOSComment = null;
            this.fld_dgcICCollectionItemMaterials.BOSDataMember = null;
            this.fld_dgcICCollectionItemMaterials.BOSDataSource = "ICCollectionItems";
            this.fld_dgcICCollectionItemMaterials.BOSDescription = null;
            this.fld_dgcICCollectionItemMaterials.BOSError = null;
            this.fld_dgcICCollectionItemMaterials.BOSFieldGroup = null;
            this.fld_dgcICCollectionItemMaterials.BOSFieldRelation = null;
            this.fld_dgcICCollectionItemMaterials.BOSGridType = null;
            this.fld_dgcICCollectionItemMaterials.BOSPrivilege = null;
            this.fld_dgcICCollectionItemMaterials.BOSPropertyName = null;
            this.fld_dgcICCollectionItemMaterials.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICCollectionItemMaterials.MenuManager = this.screenToolbar;
            this.fld_dgcICCollectionItemMaterials.Name = "fld_dgcICCollectionItemMaterials";
            this.fld_dgcICCollectionItemMaterials.PrintReport = false;
            this.fld_dgcICCollectionItemMaterials.Screen = null;
            this.fld_dgcICCollectionItemMaterials.Size = new System.Drawing.Size(911, 223);
            this.fld_dgcICCollectionItemMaterials.TabIndex = 2;
            // 
            // fld_btnAddProductMaterial
            // 
            this.fld_btnAddProductMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductMaterial.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductMaterial.BOSDataMember = null;
            this.fld_btnAddProductMaterial.BOSDataSource = null;
            this.fld_btnAddProductMaterial.BOSDescription = null;
            this.fld_btnAddProductMaterial.BOSError = null;
            this.fld_btnAddProductMaterial.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductMaterial.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductMaterial.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductMaterial.BOSPropertyName = null;
            this.fld_btnAddProductMaterial.Location = new System.Drawing.Point(7, 4);
            this.fld_btnAddProductMaterial.Name = "fld_btnAddProductMaterial";
            this.fld_btnAddProductMaterial.Screen = null;
            this.fld_btnAddProductMaterial.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductMaterial.TabIndex = 1;
            this.fld_btnAddProductMaterial.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddProductMaterial.Text = "Thêm thêm vật tư";
            this.fld_btnAddProductMaterial.Click += new System.EventHandler(this.fld_btnAddProductMaterial_Click);
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseFont = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.Location = new System.Drawing.Point(363, 414);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 334;
            this.fld_lblLabel11.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            // 
            // DMCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(937, 491);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "DMCT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICCollectionDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICCollectionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICCollectionDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).EndInit();
            this.fld_tabProductWorkItem.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItemWorks)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollectionItemMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSTabControl fld_tabProductWorkItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabProduct;
        private BOSERP.Modules.Collection.ICCollectionItemsGridControl fld_dgcICCollectionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteICCollectionDate;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtICCollectionNo;
        private BOSComponent.BOSTextBox fld_txtICCollectionName;
        private BOSComponent.BOSMemoEdit fld_medICCollectionDesc;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnAddProductWork;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnAddProductMaterial;
        private ICCollectionItemWorksGridControl fld_dgcICCollectionItemWorks;
        private ICCollectionItemMaterialsGridControl fld_dgcICCollectionItemMaterials;
	}
}
