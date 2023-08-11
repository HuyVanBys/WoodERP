using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Dormitory.UI
{
	/// <summary>
	/// Summary description for DMAS100
	/// </summary>
	partial class DMDMT100
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
            this.fld_txtHRDormitoryCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRDormitoryAcreage = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRDormitoryDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRDormitoryDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDormitoryName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDormitoryNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRDormitoryItems = new BOSERP.Modules.Dormitory.HRDormitoryItemsGridControl();
            this.fld_pteHRDormitoryItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_pteHRDormitoryEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryAcreage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDormitoryDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRDormitoryItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRDormitoryEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryCapacity);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryAcreage);
            this.bosPanel1.Controls.Add(this.fld_medHRDormitoryDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRDormitoryDate);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel35);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryName);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_pteHRDormitoryEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(920, 424);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_txtHRDormitoryCapacity
            // 
            this.fld_txtHRDormitoryCapacity.BOSComment = null;
            this.fld_txtHRDormitoryCapacity.BOSDataMember = "HRDormitoryCapacity";
            this.fld_txtHRDormitoryCapacity.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryCapacity.BOSDescription = null;
            this.fld_txtHRDormitoryCapacity.BOSError = null;
            this.fld_txtHRDormitoryCapacity.BOSFieldGroup = null;
            this.fld_txtHRDormitoryCapacity.BOSFieldRelation = null;
            this.fld_txtHRDormitoryCapacity.BOSPrivilege = null;
            this.fld_txtHRDormitoryCapacity.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryCapacity.Location = new System.Drawing.Point(273, 116);
            this.fld_txtHRDormitoryCapacity.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryCapacity.Name = "fld_txtHRDormitoryCapacity";
            this.fld_txtHRDormitoryCapacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRDormitoryCapacity.Screen = null;
            this.fld_txtHRDormitoryCapacity.Size = new System.Drawing.Size(197, 20);
            this.fld_txtHRDormitoryCapacity.TabIndex = 84;
            this.fld_txtHRDormitoryCapacity.Tag = "DC";
            // 
            // fld_txtHRDormitoryAcreage
            // 
            this.fld_txtHRDormitoryAcreage.BOSComment = null;
            this.fld_txtHRDormitoryAcreage.BOSDataMember = "HRDormitoryAcreage";
            this.fld_txtHRDormitoryAcreage.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryAcreage.BOSDescription = null;
            this.fld_txtHRDormitoryAcreage.BOSError = null;
            this.fld_txtHRDormitoryAcreage.BOSFieldGroup = null;
            this.fld_txtHRDormitoryAcreage.BOSFieldRelation = null;
            this.fld_txtHRDormitoryAcreage.BOSPrivilege = null;
            this.fld_txtHRDormitoryAcreage.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryAcreage.Location = new System.Drawing.Point(273, 90);
            this.fld_txtHRDormitoryAcreage.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryAcreage.Name = "fld_txtHRDormitoryAcreage";
            this.fld_txtHRDormitoryAcreage.Properties.Mask.EditMask = "n";
            this.fld_txtHRDormitoryAcreage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRDormitoryAcreage.Screen = null;
            this.fld_txtHRDormitoryAcreage.Size = new System.Drawing.Size(197, 20);
            this.fld_txtHRDormitoryAcreage.TabIndex = 83;
            this.fld_txtHRDormitoryAcreage.Tag = "DC";
            // 
            // fld_medHRDormitoryDesc
            // 
            this.fld_medHRDormitoryDesc.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_medHRDormitoryDesc.BOSDataMember = "HRDormitoryDesc";
            this.fld_medHRDormitoryDesc.BOSDataSource = "HRDormitorys";
            this.fld_medHRDormitoryDesc.BOSDescription = null;
            this.fld_medHRDormitoryDesc.BOSError = null;
            this.fld_medHRDormitoryDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_medHRDormitoryDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_medHRDormitoryDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_medHRDormitoryDesc.BOSPropertyName = "EditValue";
            this.fld_medHRDormitoryDesc.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_medHRDormitoryDesc.Location = new System.Drawing.Point(556, 13);
            this.fld_medHRDormitoryDesc.Name = "fld_medHRDormitoryDesc";
            this.fld_medHRDormitoryDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRDormitoryDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRDormitoryDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRDormitoryDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRDormitoryDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRDormitoryDesc, true);
            this.fld_medHRDormitoryDesc.Size = new System.Drawing.Size(211, 123);
            this.fld_medHRDormitoryDesc.TabIndex = 82;
            this.fld_medHRDormitoryDesc.Tag = "DC";
            // 
            // fld_dteHRDormitoryDate
            // 
            this.fld_dteHRDormitoryDate.BOSComment = null;
            this.fld_dteHRDormitoryDate.BOSDataMember = "HRDormitoryDate";
            this.fld_dteHRDormitoryDate.BOSDataSource = "HRDormitorys";
            this.fld_dteHRDormitoryDate.BOSDescription = null;
            this.fld_dteHRDormitoryDate.BOSError = null;
            this.fld_dteHRDormitoryDate.BOSFieldGroup = null;
            this.fld_dteHRDormitoryDate.BOSFieldRelation = null;
            this.fld_dteHRDormitoryDate.BOSPrivilege = null;
            this.fld_dteHRDormitoryDate.BOSPropertyName = "EditValue";
            this.fld_dteHRDormitoryDate.EditValue = null;
            this.fld_dteHRDormitoryDate.Location = new System.Drawing.Point(273, 64);
            this.fld_dteHRDormitoryDate.Name = "fld_dteHRDormitoryDate";
            this.fld_dteHRDormitoryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRDormitoryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRDormitoryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRDormitoryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRDormitoryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRDormitoryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRDormitoryDate.Screen = null;
            this.fld_dteHRDormitoryDate.Size = new System.Drawing.Size(197, 20);
            this.fld_dteHRDormitoryDate.TabIndex = 81;
            this.fld_dteHRDormitoryDate.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(508, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 79;
            this.bosLabel5.Text = "Mô tả";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(185, 119);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(80, 13);
            this.bosLabel4.TabIndex = 78;
            this.bosLabel4.Text = "Sức chứa(người)";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(185, 95);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(63, 13);
            this.bosLabel35.TabIndex = 76;
            this.bosLabel35.Text = "Diện tích(M2)";
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
            this.bosLabel3.Location = new System.Drawing.Point(185, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(44, 13);
            this.bosLabel3.TabIndex = 73;
            this.bosLabel3.Text = "Ngày tạo";
            // 
            // fld_txtHRDormitoryName
            // 
            this.fld_txtHRDormitoryName.BOSComment = null;
            this.fld_txtHRDormitoryName.BOSDataMember = "HRDormitoryName";
            this.fld_txtHRDormitoryName.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryName.BOSDescription = null;
            this.fld_txtHRDormitoryName.BOSError = null;
            this.fld_txtHRDormitoryName.BOSFieldGroup = null;
            this.fld_txtHRDormitoryName.BOSFieldRelation = null;
            this.fld_txtHRDormitoryName.BOSPrivilege = null;
            this.fld_txtHRDormitoryName.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryName.Location = new System.Drawing.Point(273, 38);
            this.fld_txtHRDormitoryName.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryName.Name = "fld_txtHRDormitoryName";
            this.fld_txtHRDormitoryName.Screen = null;
            this.fld_txtHRDormitoryName.Size = new System.Drawing.Size(197, 20);
            this.fld_txtHRDormitoryName.TabIndex = 72;
            this.fld_txtHRDormitoryName.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(185, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 71;
            this.bosLabel2.Text = "Tên phòng";
            // 
            // fld_txtHRDormitoryNo
            // 
            this.fld_txtHRDormitoryNo.BOSComment = null;
            this.fld_txtHRDormitoryNo.BOSDataMember = "HRDormitoryNo";
            this.fld_txtHRDormitoryNo.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryNo.BOSDescription = null;
            this.fld_txtHRDormitoryNo.BOSError = null;
            this.fld_txtHRDormitoryNo.BOSFieldGroup = null;
            this.fld_txtHRDormitoryNo.BOSFieldRelation = null;
            this.fld_txtHRDormitoryNo.BOSPrivilege = null;
            this.fld_txtHRDormitoryNo.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryNo.Location = new System.Drawing.Point(273, 12);
            this.fld_txtHRDormitoryNo.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryNo.Name = "fld_txtHRDormitoryNo";
            this.fld_txtHRDormitoryNo.Screen = null;
            this.fld_txtHRDormitoryNo.Size = new System.Drawing.Size(197, 20);
            this.fld_txtHRDormitoryNo.TabIndex = 70;
            this.fld_txtHRDormitoryNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(185, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(47, 13);
            this.bosLabel7.TabIndex = 69;
            this.bosLabel7.Text = "Mã phòng";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(12, 159);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(896, 253);
            this.bosTabControl1.TabIndex = 68;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRDormitoryItems);
            this.xtraTabPage1.Controls.Add(this.fld_pteHRDormitoryItemProductPicture);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(889, 224);
            this.xtraTabPage1.Text = "Dụng cụ có sẵn";
            // 
            // fld_dgcHRDormitoryItems
            // 
            this.fld_dgcHRDormitoryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRDormitoryItems.BOSComment = null;
            this.fld_dgcHRDormitoryItems.BOSDataMember = null;
            this.fld_dgcHRDormitoryItems.BOSDataSource = "HRDormitoryItems";
            this.fld_dgcHRDormitoryItems.BOSDescription = null;
            this.fld_dgcHRDormitoryItems.BOSError = null;
            this.fld_dgcHRDormitoryItems.BOSFieldGroup = null;
            this.fld_dgcHRDormitoryItems.BOSFieldRelation = null;
            this.fld_dgcHRDormitoryItems.BOSGridType = null;
            this.fld_dgcHRDormitoryItems.BOSPrivilege = null;
            this.fld_dgcHRDormitoryItems.BOSPropertyName = null;
            this.fld_dgcHRDormitoryItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHRDormitoryItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRDormitoryItems.Name = "fld_dgcHRDormitoryItems";
            this.fld_dgcHRDormitoryItems.PrintReport = false;
            this.fld_dgcHRDormitoryItems.Screen = null;
            this.fld_dgcHRDormitoryItems.Size = new System.Drawing.Size(736, 218);
            this.fld_dgcHRDormitoryItems.TabIndex = 58;
            // 
            // fld_pteHRDormitoryItemProductPicture
            // 
            this.fld_pteHRDormitoryItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteHRDormitoryItemProductPicture.BOSComment = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSDataMember = "HRDormitoryItemProductPicture";
            this.fld_pteHRDormitoryItemProductPicture.BOSDataSource = "HRDormitoryItems";
            this.fld_pteHRDormitoryItemProductPicture.BOSDescription = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSError = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSFieldGroup = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSFieldRelation = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSPrivilege = null;
            this.fld_pteHRDormitoryItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteHRDormitoryItemProductPicture.Location = new System.Drawing.Point(744, 3);
            this.fld_pteHRDormitoryItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteHRDormitoryItemProductPicture.Name = "fld_pteHRDormitoryItemProductPicture";
            this.fld_pteHRDormitoryItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRDormitoryItemProductPicture.Screen = null;
            this.fld_pteHRDormitoryItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteHRDormitoryItemProductPicture.TabIndex = 2;
            this.fld_pteHRDormitoryItemProductPicture.Tag = "DC";
            // 
            // fld_pteHRDormitoryEmployeePicture
            // 
            this.fld_pteHRDormitoryEmployeePicture.BOSComment = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSDataMember = "HRDormitoryEmployeePicture";
            this.fld_pteHRDormitoryEmployeePicture.BOSDataSource = "HRDormitorys";
            this.fld_pteHRDormitoryEmployeePicture.BOSDescription = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSError = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRDormitoryEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRDormitoryEmployeePicture.Location = new System.Drawing.Point(12, 12);
            this.fld_pteHRDormitoryEmployeePicture.Name = "fld_pteHRDormitoryEmployeePicture";
            this.fld_pteHRDormitoryEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRDormitoryEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRDormitoryEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRDormitoryEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRDormitoryEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRDormitoryEmployeePicture.Screen = null;
            this.fld_pteHRDormitoryEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRDormitoryEmployeePicture.TabIndex = 7;
            this.fld_pteHRDormitoryEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "HRDormitorys";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(12, 114);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 8;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(11, 6);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_pteARSaleOrderItemProductPicture
            // 
            this.fld_pteARSaleOrderItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARSaleOrderItemProductPicture.BOSComment = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSDataMember = "ARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.BOSDataSource = "ARSaleOrderItems";
            this.fld_pteARSaleOrderItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSError = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderItemProductPicture.Location = new System.Drawing.Point(1015, 3);
            this.fld_pteARSaleOrderItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARSaleOrderItemProductPicture.Name = "fld_pteARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderItemProductPicture.Screen = null;
            this.fld_pteARSaleOrderItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARSaleOrderItemProductPicture.TabIndex = 2;
            this.fld_pteARSaleOrderItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARSaleOrderItems";
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
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(64, 3);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(946, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            // 
            // fld_dgcARSaleOrderItems
            // 
            this.fld_dgcARSaleOrderItems.AllowDrop = true;
            this.fld_dgcARSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItems.BOSComment = null;
            this.fld_dgcARSaleOrderItems.BOSDataMember = null;
            this.fld_dgcARSaleOrderItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.BOSDescription = null;
            this.fld_dgcARSaleOrderItems.BOSError = null;
            this.fld_dgcARSaleOrderItems.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItems.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItems.BOSGridType = null;
            this.fld_dgcARSaleOrderItems.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItems.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(3, 29);
            this.fld_dgcARSaleOrderItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(1007, 153);
            this.fld_dgcARSaleOrderItems.TabIndex = 1;
            this.fld_dgcARSaleOrderItems.Tag = "DC";
            this.fld_dgcARSaleOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARSaleOrderItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // DMDMT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(920, 424);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDMT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryAcreage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDormitoryDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRDormitoryItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRDormitoryEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteHRDormitoryEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSPictureEdit fld_pteHRDormitoryItemProductPicture;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSDateEdit fld_dteHRDormitoryDate;
        private BOSComponent.BOSMemoEdit fld_medHRDormitoryDesc;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryAcreage;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryCapacity;
        private HRDormitoryItemsGridControl fld_dgcHRDormitoryItems;
	}
}
