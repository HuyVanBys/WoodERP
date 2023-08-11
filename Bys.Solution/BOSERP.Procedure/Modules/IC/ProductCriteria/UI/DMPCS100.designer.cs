using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductCriteria.UI
{
	/// <summary>
    /// Summary description for DMPCS100
	/// </summary>
    partial class DMPCS100
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
            this.fld_txtICProductCriteriaDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductCriteriaDiscountAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkICProductLockedPurchaseOrder = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaDiscountType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductCriteriaStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteICProductCriteriaEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteMMProductionNormProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductCriteriaNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductCriteriaNane = new BOSComponent.BOSTextBox(this.components);
            this.fld_tabProductWorkItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnShowProduct = new BOSComponent.BOSButton(this.components);
            this.fld_btnShowProductCollection = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductCriteriaItems = new BOSERP.Modules.ProductCriteria.ICProductCriteriaItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaDiscountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCriteriaStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).BeginInit();
            this.fld_tabProductWorkItem.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCriteriaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
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
            this.bosPanel1.Size = new System.Drawing.Size(854, 505);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(854, 505);
            this.splitContainerControl1.SplitterPosition = 195;
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
            this.fld_grcGroupControl5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductCriteriaDiscountPercent);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductCriteriaDiscountAmount);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductLockedPurchaseOrder);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICProductCriteriaDiscountType);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductCriteriaStatus);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICProductCriteriaType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICProductCriteriaEndDate);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICProductCriteriaStartDate);
            this.fld_grcGroupControl5.Controls.Add(this.fld_pteMMProductionNormProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductCriteriaNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductCriteriaNane);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(848, 187);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_txtICProductCriteriaDiscountPercent
            // 
            this.fld_txtICProductCriteriaDiscountPercent.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountPercent.BOSDataMember = "ICProductCriteriaDiscountPercent";
            this.fld_txtICProductCriteriaDiscountPercent.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaDiscountPercent.BOSDescription = null;
            this.fld_txtICProductCriteriaDiscountPercent.BOSError = null;
            this.fld_txtICProductCriteriaDiscountPercent.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountPercent.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountPercent.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaDiscountPercent.Location = new System.Drawing.Point(228, 135);
            this.fld_txtICProductCriteriaDiscountPercent.Name = "fld_txtICProductCriteriaDiscountPercent";
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.EditFormat.FormatString = "n2";
            this.fld_txtICProductCriteriaDiscountPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Mask.EditMask = null;
            this.fld_txtICProductCriteriaDiscountPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCriteriaDiscountPercent, false);
            this.fld_txtICProductCriteriaDiscountPercent.Size = new System.Drawing.Size(166, 20);
            this.fld_txtICProductCriteriaDiscountPercent.TabIndex = 159;
            this.fld_txtICProductCriteriaDiscountPercent.Tag = "DC";
            this.fld_txtICProductCriteriaDiscountPercent.Validated += new System.EventHandler(this.fld_txtICProductCriteriaDiscountPercent_Validated);
            // 
            // fld_txtICProductCriteriaDiscountAmount
            // 
            this.fld_txtICProductCriteriaDiscountAmount.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountAmount.BOSDataMember = "ICProductCriteriaDiscountAmount";
            this.fld_txtICProductCriteriaDiscountAmount.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaDiscountAmount.BOSDescription = null;
            this.fld_txtICProductCriteriaDiscountAmount.BOSError = null;
            this.fld_txtICProductCriteriaDiscountAmount.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaDiscountAmount.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaDiscountAmount.Location = new System.Drawing.Point(499, 135);
            this.fld_txtICProductCriteriaDiscountAmount.Name = "fld_txtICProductCriteriaDiscountAmount";
            this.fld_txtICProductCriteriaDiscountAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaDiscountAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaDiscountAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaDiscountAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaDiscountAmount.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtICProductCriteriaDiscountAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtICProductCriteriaDiscountAmount.Properties.Mask.EditMask = null;
            this.fld_txtICProductCriteriaDiscountAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCriteriaDiscountAmount, false);
            this.fld_txtICProductCriteriaDiscountAmount.Size = new System.Drawing.Size(166, 20);
            this.fld_txtICProductCriteriaDiscountAmount.TabIndex = 158;
            this.fld_txtICProductCriteriaDiscountAmount.Tag = "DC";
            this.fld_txtICProductCriteriaDiscountAmount.Validated += new System.EventHandler(this.fld_txtICProductCriteriaDiscountAmount_Validated);
            // 
            // fld_chkICProductLockedPurchaseOrder
            // 
            this.fld_chkICProductLockedPurchaseOrder.BOSComment = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSDataMember = "ICProductCriteriaIsIncrease";
            this.fld_chkICProductLockedPurchaseOrder.BOSDataSource = "ICProductCriterias";
            this.fld_chkICProductLockedPurchaseOrder.BOSDescription = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSError = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldGroup = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldRelation = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPrivilege = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPropertyName = "EditValue";
            this.fld_chkICProductLockedPurchaseOrder.Location = new System.Drawing.Point(226, 161);
            this.fld_chkICProductLockedPurchaseOrder.MenuManager = this.screenToolbar;
            this.fld_chkICProductLockedPurchaseOrder.Name = "fld_chkICProductLockedPurchaseOrder";
            this.fld_chkICProductLockedPurchaseOrder.Properties.Caption = "Tăng/Giảm";
            this.fld_chkICProductLockedPurchaseOrder.Screen = null;
            this.fld_chkICProductLockedPurchaseOrder.Size = new System.Drawing.Size(104, 19);
            this.fld_chkICProductLockedPurchaseOrder.TabIndex = 157;
            this.fld_chkICProductLockedPurchaseOrder.Tag = "DC";
            this.fld_chkICProductLockedPurchaseOrder.CheckedChanged += new System.EventHandler(this.fld_chkICProductLockedPurchaseOrder_CheckedChanged);
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
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(414, 112);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(0, 13);
            this.bosLabel8.TabIndex = 156;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(414, 138);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(37, 13);
            this.bosLabel7.TabIndex = 154;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "Mức giá";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
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
            this.bosLabel6.Location = new System.Drawing.Point(145, 138);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(68, 13);
            this.bosLabel6.TabIndex = 152;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Text = "Phần trăm(%)";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(145, 112);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 150;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Loại";
            // 
            // fld_dteICProductCriteriaDiscountType
            // 
            this.fld_dteICProductCriteriaDiscountType.BOSAllowAddNew = false;
            this.fld_dteICProductCriteriaDiscountType.BOSAllowDummy = false;
            this.fld_dteICProductCriteriaDiscountType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSDataMember = "ICProductCriteriaDiscountType";
            this.fld_dteICProductCriteriaDiscountType.BOSDataSource = "ICProductCriterias";
            this.fld_dteICProductCriteriaDiscountType.BOSDescription = null;
            this.fld_dteICProductCriteriaDiscountType.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaDiscountType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.CurrentDisplayText = null;
            this.fld_dteICProductCriteriaDiscountType.Location = new System.Drawing.Point(228, 109);
            this.fld_dteICProductCriteriaDiscountType.Name = "fld_dteICProductCriteriaDiscountType";
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaDiscountType.Properties.DisplayMember = "HREmployeeName";
            this.fld_dteICProductCriteriaDiscountType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaDiscountType.Properties.PopupWidth = 40;
            this.fld_dteICProductCriteriaDiscountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dteICProductCriteriaDiscountType.Properties.ValueMember = "HREmployeeID";
            this.fld_dteICProductCriteriaDiscountType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaDiscountType, true);
            this.fld_dteICProductCriteriaDiscountType.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaDiscountType.TabIndex = 149;
            this.fld_dteICProductCriteriaDiscountType.Tag = "DC";
            this.fld_dteICProductCriteriaDiscountType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dteICProductCriteriaDiscountType_CloseUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(414, 112);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 148;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Trạng thái";
            // 
            // fld_lkeICProductCriteriaStatus
            // 
            this.fld_lkeICProductCriteriaStatus.BOSAllowAddNew = false;
            this.fld_lkeICProductCriteriaStatus.BOSAllowDummy = false;
            this.fld_lkeICProductCriteriaStatus.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSDataMember = "ICProductCriteriaStatus";
            this.fld_lkeICProductCriteriaStatus.BOSDataSource = "ICProductCriterias";
            this.fld_lkeICProductCriteriaStatus.BOSDescription = null;
            this.fld_lkeICProductCriteriaStatus.BOSError = null;
            this.fld_lkeICProductCriteriaStatus.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICProductCriteriaStatus.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.CurrentDisplayText = null;
            this.fld_lkeICProductCriteriaStatus.Location = new System.Drawing.Point(499, 109);
            this.fld_lkeICProductCriteriaStatus.Name = "fld_lkeICProductCriteriaStatus";
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductCriteriaStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductCriteriaStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductCriteriaStatus.Properties.ReadOnly = true;
            this.fld_lkeICProductCriteriaStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductCriteriaStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductCriteriaStatus, true);
            this.fld_lkeICProductCriteriaStatus.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeICProductCriteriaStatus.TabIndex = 147;
            this.fld_lkeICProductCriteriaStatus.Tag = "DC";
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(414, 34);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(59, 13);
            this.bosLabel2.TabIndex = 146;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Loại tiêu chí";
            // 
            // fld_dteICProductCriteriaType
            // 
            this.fld_dteICProductCriteriaType.BOSAllowAddNew = false;
            this.fld_dteICProductCriteriaType.BOSAllowDummy = false;
            this.fld_dteICProductCriteriaType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSDataMember = "ICProductCriteriaType";
            this.fld_dteICProductCriteriaType.BOSDataSource = "ICProductCriterias";
            this.fld_dteICProductCriteriaType.BOSDescription = null;
            this.fld_dteICProductCriteriaType.BOSError = "Loại không thể để trống";
            this.fld_dteICProductCriteriaType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.CurrentDisplayText = null;
            this.fld_dteICProductCriteriaType.Location = new System.Drawing.Point(499, 31);
            this.fld_dteICProductCriteriaType.Name = "fld_dteICProductCriteriaType";
            this.fld_dteICProductCriteriaType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaType.Properties.DisplayMember = "HREmployeeName";
            this.fld_dteICProductCriteriaType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaType.Properties.PopupWidth = 40;
            this.fld_dteICProductCriteriaType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dteICProductCriteriaType.Properties.ValueMember = "HREmployeeID";
            this.fld_dteICProductCriteriaType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaType, true);
            this.fld_dteICProductCriteriaType.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaType.TabIndex = 145;
            this.fld_dteICProductCriteriaType.Tag = "DC";
            // 
            // fld_dteICProductCriteriaEndDate
            // 
            this.fld_dteICProductCriteriaEndDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaEndDate.BOSDataMember = "ICProductCriteriaEndDate";
            this.fld_dteICProductCriteriaEndDate.BOSDataSource = "ICProductCriterias";
            this.fld_dteICProductCriteriaEndDate.BOSDescription = null;
            this.fld_dteICProductCriteriaEndDate.BOSError = null;
            this.fld_dteICProductCriteriaEndDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaEndDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaEndDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaEndDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaEndDate.EditValue = null;
            this.fld_dteICProductCriteriaEndDate.Location = new System.Drawing.Point(499, 83);
            this.fld_dteICProductCriteriaEndDate.Name = "fld_dteICProductCriteriaEndDate";
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductCriteriaEndDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaEndDate, true);
            this.fld_dteICProductCriteriaEndDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaEndDate.TabIndex = 144;
            this.fld_dteICProductCriteriaEndDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(414, 86);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(67, 13);
            this.bosLabel1.TabIndex = 143;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Ngày kết thúc";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(145, 86);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(65, 13);
            this.bosLabel5.TabIndex = 142;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Ngày bắt đầu";
            // 
            // fld_dteICProductCriteriaStartDate
            // 
            this.fld_dteICProductCriteriaStartDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaStartDate.BOSDataMember = "ICProductCriteriaStartDate";
            this.fld_dteICProductCriteriaStartDate.BOSDataSource = "ICProductCriterias";
            this.fld_dteICProductCriteriaStartDate.BOSDescription = null;
            this.fld_dteICProductCriteriaStartDate.BOSError = null;
            this.fld_dteICProductCriteriaStartDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaStartDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaStartDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICProductCriteriaStartDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaStartDate.EditValue = null;
            this.fld_dteICProductCriteriaStartDate.Location = new System.Drawing.Point(228, 83);
            this.fld_dteICProductCriteriaStartDate.Name = "fld_dteICProductCriteriaStartDate";
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductCriteriaStartDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaStartDate, true);
            this.fld_dteICProductCriteriaStartDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaStartDate.TabIndex = 1;
            this.fld_dteICProductCriteriaStartDate.Tag = "DC";
            // 
            // fld_pteMMProductionNormProductPicture
            // 
            this.fld_pteMMProductionNormProductPicture.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSDataMember = "MMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormProductPicture.BOSDescription = null;
            this.fld_pteMMProductionNormProductPicture.BOSError = null;
            this.fld_pteMMProductionNormProductPicture.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormProductPicture.EditValue = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(145, 34);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 138;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(145, 60);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 140;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtICProductCriteriaNo
            // 
            this.fld_txtICProductCriteriaNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSDataMember = "ICProductCriteriaNo";
            this.fld_txtICProductCriteriaNo.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaNo.BOSDescription = null;
            this.fld_txtICProductCriteriaNo.BOSError = "Mã tiêu chí không thể rỗng.";
            this.fld_txtICProductCriteriaNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaNo.Location = new System.Drawing.Point(228, 31);
            this.fld_txtICProductCriteriaNo.Name = "fld_txtICProductCriteriaNo";
            this.fld_txtICProductCriteriaNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaNo.Screen = null;
            this.fld_txtICProductCriteriaNo.Size = new System.Drawing.Size(166, 20);
            this.fld_txtICProductCriteriaNo.TabIndex = 0;
            this.fld_txtICProductCriteriaNo.Tag = "DC";
            // 
            // fld_txtICProductCriteriaNane
            // 
            this.fld_txtICProductCriteriaNane.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNane.BOSDataMember = "ICProductCriteriaName";
            this.fld_txtICProductCriteriaNane.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaNane.BOSDescription = null;
            this.fld_txtICProductCriteriaNane.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNane.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNane.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNane.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNane.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaNane.Location = new System.Drawing.Point(228, 57);
            this.fld_txtICProductCriteriaNane.Name = "fld_txtICProductCriteriaNane";
            this.fld_txtICProductCriteriaNane.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaNane.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaNane.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaNane.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaNane.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaNane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaNane.Screen = null;
            this.fld_txtICProductCriteriaNane.Size = new System.Drawing.Size(437, 20);
            this.fld_txtICProductCriteriaNane.TabIndex = 2;
            this.fld_txtICProductCriteriaNane.Tag = "DC";
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
            this.fld_tabProductWorkItem.Size = new System.Drawing.Size(848, 282);
            this.fld_tabProductWorkItem.TabIndex = 0;
            this.fld_tabProductWorkItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_btnShowProduct);
            this.fld_tabProduct.Controls.Add(this.fld_btnShowProductCollection);
            this.fld_tabProduct.Controls.Add(this.fld_dgcICProductCriteriaItems);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.fld_tabProduct.Size = new System.Drawing.Size(841, 253);
            this.fld_tabProduct.Text = "Danh sách sản phẩm";
            // 
            // fld_btnShowProduct
            // 
            this.fld_btnShowProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnShowProduct.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProduct.BOSDataMember = null;
            this.fld_btnShowProduct.BOSDataSource = null;
            this.fld_btnShowProduct.BOSDescription = null;
            this.fld_btnShowProduct.BOSError = null;
            this.fld_btnShowProduct.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProduct.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProduct.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProduct.BOSPropertyName = null;
            this.fld_btnShowProduct.Location = new System.Drawing.Point(116, 4);
            this.fld_btnShowProduct.Name = "fld_btnShowProduct";
            this.fld_btnShowProduct.Screen = null;
            this.fld_btnShowProduct.Size = new System.Drawing.Size(103, 27);
            this.fld_btnShowProduct.TabIndex = 2;
            this.fld_btnShowProduct.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProduct.Text = "Chọn sản phẩm";
            this.fld_btnShowProduct.Click += new System.EventHandler(this.fld_btnShowProduct_Click);
            // 
            // fld_btnShowProductCollection
            // 
            this.fld_btnShowProductCollection.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowProductCollection.Appearance.Options.UseForeColor = true;
            this.fld_btnShowProductCollection.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProductCollection.BOSDataMember = null;
            this.fld_btnShowProductCollection.BOSDataSource = null;
            this.fld_btnShowProductCollection.BOSDescription = null;
            this.fld_btnShowProductCollection.BOSError = null;
            this.fld_btnShowProductCollection.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProductCollection.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProductCollection.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProductCollection.BOSPropertyName = null;
            this.fld_btnShowProductCollection.Location = new System.Drawing.Point(7, 4);
            this.fld_btnShowProductCollection.Name = "fld_btnShowProductCollection";
            this.fld_btnShowProductCollection.Screen = null;
            this.fld_btnShowProductCollection.Size = new System.Drawing.Size(103, 27);
            this.fld_btnShowProductCollection.TabIndex = 0;
            this.fld_btnShowProductCollection.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnShowProductCollection.Text = "Chọn từ bộ sưu tập";
            this.fld_btnShowProductCollection.Click += new System.EventHandler(this.fld_btnShowProductCollection_Click);
            // 
            // fld_dgcICProductCriteriaItems
            // 
            this.fld_dgcICProductCriteriaItems.AllowDrop = true;
            this.fld_dgcICProductCriteriaItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductCriteriaItems.BOSComment = null;
            this.fld_dgcICProductCriteriaItems.BOSDataMember = null;
            this.fld_dgcICProductCriteriaItems.BOSDataSource = "ICProductCriteriaItems";
            this.fld_dgcICProductCriteriaItems.BOSDescription = null;
            this.fld_dgcICProductCriteriaItems.BOSError = null;
            this.fld_dgcICProductCriteriaItems.BOSFieldGroup = null;
            this.fld_dgcICProductCriteriaItems.BOSFieldRelation = null;
            this.fld_dgcICProductCriteriaItems.BOSGridType = null;
            this.fld_dgcICProductCriteriaItems.BOSPrivilege = null;
            this.fld_dgcICProductCriteriaItems.BOSPropertyName = null;
            this.fld_dgcICProductCriteriaItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductCriteriaItems.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductCriteriaItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcICProductCriteriaItems.Name = "fld_dgcICProductCriteriaItems";
            this.fld_dgcICProductCriteriaItems.PrintReport = false;
            this.fld_dgcICProductCriteriaItems.Screen = null;
            this.fld_dgcICProductCriteriaItems.Size = new System.Drawing.Size(834, 214);
            this.fld_dgcICProductCriteriaItems.TabIndex = 1;
            this.fld_dgcICProductCriteriaItems.Tag = "DC";
            this.fld_dgcICProductCriteriaItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcICProductCriteriaItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
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
            // DMPCS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(854, 505);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "DMPCS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaDiscountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCriteriaStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).EndInit();
            this.fld_tabProductWorkItem.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCriteriaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
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
        private BOSERP.Modules.ProductCriteria.ICProductCriteriaItemsGridControl fld_dgcICProductCriteriaItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSButton fld_btnShowProductCollection;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteICProductCriteriaStartDate;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaNo;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaNane;
        private BOSComponent.BOSDateEdit fld_dteICProductCriteriaEndDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_dteICProductCriteriaType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductCriteriaStatus;
        private BOSComponent.BOSButton fld_btnShowProduct;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_dteICProductCriteriaDiscountType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSCheckEdit fld_chkICProductLockedPurchaseOrder;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaDiscountAmount;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaDiscountPercent;
	}
}
