using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WorkShop.UI
{
	/// <summary>
	/// Summary description for SMWS100
	/// </summary>
	partial class SMWS100
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
            this.fld_dgcMMWorkShops = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWorkShopNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWorkShopContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWorkShopContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactRoom = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWorkShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMWorkShops
            // 
            this.fld_dgcMMWorkShops.AllowDrop = true;
            this.fld_dgcMMWorkShops.BOSComment = "";
            this.fld_dgcMMWorkShops.BOSDataMember = null;
            this.fld_dgcMMWorkShops.BOSDataSource = "MMWorkShops";
            this.fld_dgcMMWorkShops.BOSDescription = null;
            this.fld_dgcMMWorkShops.BOSError = "";
            this.fld_dgcMMWorkShops.BOSFieldGroup = "";
            this.fld_dgcMMWorkShops.BOSFieldRelation = null;
            this.fld_dgcMMWorkShops.BOSGridType = null;
            this.fld_dgcMMWorkShops.BOSPrivilege = "";
            this.fld_dgcMMWorkShops.BOSPropertyName = null;
            this.fld_dgcMMWorkShops.CommodityType = "";
            this.fld_dgcMMWorkShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMWorkShops.Location = new System.Drawing.Point(12, 146);
            this.fld_dgcMMWorkShops.Name = "fld_dgcMMWorkShops";
            this.fld_dgcMMWorkShops.PrintReport = false;
            this.fld_dgcMMWorkShops.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMWorkShops, true);
            this.fld_dgcMMWorkShops.Size = new System.Drawing.Size(866, 410);
            this.fld_dgcMMWorkShops.TabIndex = 136;
            this.fld_dgcMMWorkShops.Tag = "SR";
            this.fld_dgcMMWorkShops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMWorkShops;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(24, 58);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(51, 13);
            this.bosLabel1.TabIndex = 148;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên xưởng";
            // 
            // fld_txtMMWorkShopNo
            // 
            this.fld_txtMMWorkShopNo.BOSComment = "";
            this.fld_txtMMWorkShopNo.BOSDataMember = "MMWorkShopNo";
            this.fld_txtMMWorkShopNo.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopNo.BOSDescription = null;
            this.fld_txtMMWorkShopNo.BOSError = "";
            this.fld_txtMMWorkShopNo.BOSFieldGroup = "";
            this.fld_txtMMWorkShopNo.BOSFieldRelation = "";
            this.fld_txtMMWorkShopNo.BOSPrivilege = "";
            this.fld_txtMMWorkShopNo.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopNo.Location = new System.Drawing.Point(96, 29);
            this.fld_txtMMWorkShopNo.Name = "fld_txtMMWorkShopNo";
            this.fld_txtMMWorkShopNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopNo, true);
            this.fld_txtMMWorkShopNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopNo.TabIndex = 137;
            this.fld_txtMMWorkShopNo.Tag = "SC";
            // 
            // fld_txtMMWorkShopName
            // 
            this.fld_txtMMWorkShopName.BOSComment = "";
            this.fld_txtMMWorkShopName.BOSDataMember = "MMWorkShopName";
            this.fld_txtMMWorkShopName.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopName.BOSDescription = null;
            this.fld_txtMMWorkShopName.BOSError = "";
            this.fld_txtMMWorkShopName.BOSFieldGroup = "";
            this.fld_txtMMWorkShopName.BOSFieldRelation = "";
            this.fld_txtMMWorkShopName.BOSPrivilege = "";
            this.fld_txtMMWorkShopName.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopName.Location = new System.Drawing.Point(96, 55);
            this.fld_txtMMWorkShopName.Name = "fld_txtMMWorkShopName";
            this.fld_txtMMWorkShopName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopName, true);
            this.fld_txtMMWorkShopName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopName.TabIndex = 139;
            this.fld_txtMMWorkShopName.Tag = "SC";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseFont = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(24, 109);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, true);
            this.fld_lblLabel27.Size = new System.Drawing.Size(22, 13);
            this.fld_lblLabel27.TabIndex = 144;
            this.fld_lblLabel27.Tag = "SI";
            this.fld_lblLabel27.Text = "Tên ";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = "";
            this.fld_lblLabel38.BOSDataMember = "";
            this.fld_lblLabel38.BOSDataSource = "";
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = "";
            this.fld_lblLabel38.BOSFieldRelation = "";
            this.fld_lblLabel38.BOSPrivilege = "";
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(24, 84);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel38.TabIndex = 145;
            this.fld_lblLabel38.Tag = "SI";
            this.fld_lblLabel38.Text = "Danh xưng";
            // 
            // fld_lblLabel41
            // 
            this.fld_lblLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel41.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel41.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel41.Appearance.Options.UseFont = true;
            this.fld_lblLabel41.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel41.BOSComment = "";
            this.fld_lblLabel41.BOSDataMember = "";
            this.fld_lblLabel41.BOSDataSource = "";
            this.fld_lblLabel41.BOSDescription = null;
            this.fld_lblLabel41.BOSError = null;
            this.fld_lblLabel41.BOSFieldGroup = "";
            this.fld_lblLabel41.BOSFieldRelation = "";
            this.fld_lblLabel41.BOSPrivilege = "";
            this.fld_lblLabel41.BOSPropertyName = null;
            this.fld_lblLabel41.Location = new System.Drawing.Point(284, 109);
            this.fld_lblLabel41.Name = "fld_lblLabel41";
            this.fld_lblLabel41.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel41, true);
            this.fld_lblLabel41.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel41.TabIndex = 146;
            this.fld_lblLabel41.Tag = "SI";
            this.fld_lblLabel41.Text = "Email";
            // 
            // fld_lblLabel42
            // 
            this.fld_lblLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel42.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel42.Appearance.Options.UseFont = true;
            this.fld_lblLabel42.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel42.BOSComment = "";
            this.fld_lblLabel42.BOSDataMember = "";
            this.fld_lblLabel42.BOSDataSource = "";
            this.fld_lblLabel42.BOSDescription = null;
            this.fld_lblLabel42.BOSError = null;
            this.fld_lblLabel42.BOSFieldGroup = "";
            this.fld_lblLabel42.BOSFieldRelation = "";
            this.fld_lblLabel42.BOSPrivilege = "";
            this.fld_lblLabel42.BOSPropertyName = null;
            this.fld_lblLabel42.Location = new System.Drawing.Point(284, 84);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel42, true);
            this.fld_lblLabel42.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel42.TabIndex = 147;
            this.fld_lblLabel42.Tag = "SI";
            this.fld_lblLabel42.Text = "Điện thoại";
            // 
            // fld_txtMMWorkShopContactTitle
            // 
            this.fld_txtMMWorkShopContactTitle.BOSComment = "";
            this.fld_txtMMWorkShopContactTitle.BOSDataMember = "MMWorkShopContactTitle";
            this.fld_txtMMWorkShopContactTitle.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactTitle.BOSDescription = null;
            this.fld_txtMMWorkShopContactTitle.BOSError = "";
            this.fld_txtMMWorkShopContactTitle.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactTitle.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactTitle.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactTitle.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactTitle.Location = new System.Drawing.Point(96, 81);
            this.fld_txtMMWorkShopContactTitle.Name = "fld_txtMMWorkShopContactTitle";
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactTitle.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactTitle, true);
            this.fld_txtMMWorkShopContactTitle.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactTitle.TabIndex = 138;
            this.fld_txtMMWorkShopContactTitle.Tag = "SC";
            // 
            // fld_txtMMWorkShopContactFirstName
            // 
            this.fld_txtMMWorkShopContactFirstName.BOSComment = "";
            this.fld_txtMMWorkShopContactFirstName.BOSDataMember = "MMWorkShopContactFirstName";
            this.fld_txtMMWorkShopContactFirstName.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactFirstName.BOSDescription = null;
            this.fld_txtMMWorkShopContactFirstName.BOSError = "";
            this.fld_txtMMWorkShopContactFirstName.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactFirstName.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactFirstName.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactFirstName.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactFirstName.Location = new System.Drawing.Point(96, 106);
            this.fld_txtMMWorkShopContactFirstName.Name = "fld_txtMMWorkShopContactFirstName";
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactFirstName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactFirstName, true);
            this.fld_txtMMWorkShopContactFirstName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactFirstName.TabIndex = 140;
            this.fld_txtMMWorkShopContactFirstName.Tag = "SC";
            // 
            // fld_txtMMWorkShopContactPhone
            // 
            this.fld_txtMMWorkShopContactPhone.BOSComment = "";
            this.fld_txtMMWorkShopContactPhone.BOSDataMember = "MMWorkShopContactPhone";
            this.fld_txtMMWorkShopContactPhone.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactPhone.BOSDescription = null;
            this.fld_txtMMWorkShopContactPhone.BOSError = "";
            this.fld_txtMMWorkShopContactPhone.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactPhone.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactPhone.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactPhone.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactPhone.Location = new System.Drawing.Point(351, 81);
            this.fld_txtMMWorkShopContactPhone.Name = "fld_txtMMWorkShopContactPhone";
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactPhone, true);
            this.fld_txtMMWorkShopContactPhone.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactPhone.TabIndex = 142;
            this.fld_txtMMWorkShopContactPhone.Tag = "SC";
            // 
            // fld_txtMMWorkShopContactEmail
            // 
            this.fld_txtMMWorkShopContactEmail.BOSComment = "";
            this.fld_txtMMWorkShopContactEmail.BOSDataMember = "MMWorkShopContactEmail";
            this.fld_txtMMWorkShopContactEmail.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactEmail.BOSDescription = null;
            this.fld_txtMMWorkShopContactEmail.BOSError = "";
            this.fld_txtMMWorkShopContactEmail.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactEmail.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactEmail.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactEmail.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactEmail.Location = new System.Drawing.Point(351, 106);
            this.fld_txtMMWorkShopContactEmail.Name = "fld_txtMMWorkShopContactEmail";
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactEmail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactEmail, true);
            this.fld_txtMMWorkShopContactEmail.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactEmail.TabIndex = 143;
            this.fld_txtMMWorkShopContactEmail.Tag = "SC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(24, 32);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 149;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã xưởng";
            // 
            // fld_lblLabel32
            // 
            this.fld_lblLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel32.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel32.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel32.Appearance.Options.UseFont = true;
            this.fld_lblLabel32.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel32.BOSComment = "";
            this.fld_lblLabel32.BOSDataMember = "";
            this.fld_lblLabel32.BOSDataSource = "";
            this.fld_lblLabel32.BOSDescription = null;
            this.fld_lblLabel32.BOSError = null;
            this.fld_lblLabel32.BOSFieldGroup = "";
            this.fld_lblLabel32.BOSFieldRelation = "";
            this.fld_lblLabel32.BOSPrivilege = "";
            this.fld_lblLabel32.BOSPropertyName = null;
            this.fld_lblLabel32.Location = new System.Drawing.Point(284, 32);
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel32, true);
            this.fld_lblLabel32.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel32.TabIndex = 152;
            this.fld_lblLabel32.Tag = "SI";
            this.fld_lblLabel32.Text = "Bộ phận";
            // 
            // fld_lblLabel45
            // 
            this.fld_lblLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel45.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel45.Appearance.Options.UseFont = true;
            this.fld_lblLabel45.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel45.BOSComment = "";
            this.fld_lblLabel45.BOSDataMember = "";
            this.fld_lblLabel45.BOSDataSource = "";
            this.fld_lblLabel45.BOSDescription = null;
            this.fld_lblLabel45.BOSError = null;
            this.fld_lblLabel45.BOSFieldGroup = "";
            this.fld_lblLabel45.BOSFieldRelation = "";
            this.fld_lblLabel45.BOSPrivilege = "";
            this.fld_lblLabel45.BOSPropertyName = null;
            this.fld_lblLabel45.Location = new System.Drawing.Point(284, 58);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel45, true);
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 153;
            this.fld_lblLabel45.Tag = "SI";
            this.fld_lblLabel45.Text = "Phòng ban";
            // 
            // fld_txtMMWorkShopContactDepartment
            // 
            this.fld_txtMMWorkShopContactDepartment.BOSComment = "";
            this.fld_txtMMWorkShopContactDepartment.BOSDataMember = "MMWorkShopContactDepartment";
            this.fld_txtMMWorkShopContactDepartment.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactDepartment.BOSDescription = null;
            this.fld_txtMMWorkShopContactDepartment.BOSError = "";
            this.fld_txtMMWorkShopContactDepartment.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactDepartment.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactDepartment.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactDepartment.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactDepartment.Location = new System.Drawing.Point(351, 29);
            this.fld_txtMMWorkShopContactDepartment.Name = "fld_txtMMWorkShopContactDepartment";
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactDepartment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactDepartment, true);
            this.fld_txtMMWorkShopContactDepartment.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactDepartment.TabIndex = 150;
            this.fld_txtMMWorkShopContactDepartment.Tag = "SC";
            // 
            // fld_txtMMLineContactRoom
            // 
            this.fld_txtMMLineContactRoom.BOSComment = "";
            this.fld_txtMMLineContactRoom.BOSDataMember = "MMWorkShopContactRoom";
            this.fld_txtMMLineContactRoom.BOSDataSource = "MMWorkShops";
            this.fld_txtMMLineContactRoom.BOSDescription = null;
            this.fld_txtMMLineContactRoom.BOSError = "";
            this.fld_txtMMLineContactRoom.BOSFieldGroup = "";
            this.fld_txtMMLineContactRoom.BOSFieldRelation = "";
            this.fld_txtMMLineContactRoom.BOSPrivilege = "";
            this.fld_txtMMLineContactRoom.BOSPropertyName = "Text";
            this.fld_txtMMLineContactRoom.Location = new System.Drawing.Point(351, 55);
            this.fld_txtMMLineContactRoom.Name = "fld_txtMMLineContactRoom";
            this.fld_txtMMLineContactRoom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactRoom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactRoom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactRoom, true);
            this.fld_txtMMLineContactRoom.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactRoom.TabIndex = 151;
            this.fld_txtMMLineContactRoom.Tag = "SC";
            // 
            // SMWS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(896, 575);
            this.Controls.Add(this.fld_lblLabel32);
            this.Controls.Add(this.fld_lblLabel45);
            this.Controls.Add(this.fld_txtMMWorkShopContactDepartment);
            this.Controls.Add(this.fld_txtMMLineContactRoom);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMWorkShopNo);
            this.Controls.Add(this.fld_txtMMWorkShopName);
            this.Controls.Add(this.fld_lblLabel27);
            this.Controls.Add(this.fld_lblLabel38);
            this.Controls.Add(this.fld_lblLabel41);
            this.Controls.Add(this.fld_lblLabel42);
            this.Controls.Add(this.fld_txtMMWorkShopContactTitle);
            this.Controls.Add(this.fld_txtMMWorkShopContactFirstName);
            this.Controls.Add(this.fld_txtMMWorkShopContactPhone);
            this.Controls.Add(this.fld_txtMMWorkShopContactEmail);
            this.Controls.Add(this.fld_dgcMMWorkShops);
            this.Name = "SMWS100";
            this.Tag = "SM";
            this.Text = "Tỉm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMWorkShops, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopContactEmail, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopContactPhone, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopContactFirstName, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopContactTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel42, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel41, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel38, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel27, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopName, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactRoom, 0);
            this.Controls.SetChildIndex(this.fld_txtMMWorkShopContactDepartment, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel45, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel32, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWorkShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMWorkShops;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopNo;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopName;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactTitle;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactFirstName;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactPhone;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactEmail;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactDepartment;
        private BOSComponent.BOSTextBox fld_txtMMLineContactRoom;
    }
}
