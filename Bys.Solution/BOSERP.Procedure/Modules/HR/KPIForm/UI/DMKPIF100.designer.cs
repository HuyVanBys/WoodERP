using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIForm.UI
{
	/// <summary>
	/// Summary description for DMKPIF100
	/// </summary>
	partial class DMKPIF100
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
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPIFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRKPIFormDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnShowKPI = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRKPIFormItems = new BOSERP.Modules.KPIForm.HRKPIFormItemsGridControl();
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRKPIFormName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPIFormTotalWeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIFormDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIFormDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormName.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormTotalWeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(12, 41);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_txtHRKPIFormNo
            // 
            this.fld_txtHRKPIFormNo.BOSComment = null;
            this.fld_txtHRKPIFormNo.BOSDataMember = "HRKPIFormNo";
            this.fld_txtHRKPIFormNo.BOSDataSource = "HRKPIForms";
            this.fld_txtHRKPIFormNo.BOSDescription = null;
            this.fld_txtHRKPIFormNo.BOSError = null;
            this.fld_txtHRKPIFormNo.BOSFieldGroup = null;
            this.fld_txtHRKPIFormNo.BOSFieldRelation = null;
            this.fld_txtHRKPIFormNo.BOSPrivilege = null;
            this.fld_txtHRKPIFormNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIFormNo.Location = new System.Drawing.Point(110, 12);
            this.fld_txtHRKPIFormNo.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIFormNo.Name = "fld_txtHRKPIFormNo";
            this.fld_txtHRKPIFormNo.Screen = null;
            this.fld_txtHRKPIFormNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRKPIFormNo.TabIndex = 0;
            this.fld_txtHRKPIFormNo.Tag = "DC";
            // 
            // fld_dteHRKPIFormDate
            // 
            this.fld_dteHRKPIFormDate.BOSComment = null;
            this.fld_dteHRKPIFormDate.BOSDataMember = "HRKPIFormDate";
            this.fld_dteHRKPIFormDate.BOSDataSource = "HRKPIForms";
            this.fld_dteHRKPIFormDate.BOSDescription = null;
            this.fld_dteHRKPIFormDate.BOSError = null;
            this.fld_dteHRKPIFormDate.BOSFieldGroup = null;
            this.fld_dteHRKPIFormDate.BOSFieldRelation = null;
            this.fld_dteHRKPIFormDate.BOSPrivilege = null;
            this.fld_dteHRKPIFormDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIFormDate.EditValue = null;
            this.fld_dteHRKPIFormDate.Location = new System.Drawing.Point(110, 38);
            this.fld_dteHRKPIFormDate.Name = "fld_dteHRKPIFormDate";
            this.fld_dteHRKPIFormDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRKPIFormDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIFormDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIFormDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIFormDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIFormDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIFormDate.Screen = null;
            this.fld_dteHRKPIFormDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIFormDate.TabIndex = 3;
            this.fld_dteHRKPIFormDate.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = null;
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = null;
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = null;
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_btnShowKPI);
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRKPIFormItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 64);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(1051, 406);
            this.fld_grcGroupControl3.TabIndex = 5;
            this.fld_grcGroupControl3.Text = "Danh sách KPI";
            // 
            // fld_btnShowKPI
            // 
            this.fld_btnShowKPI.BOSComment = null;
            this.fld_btnShowKPI.BOSDataMember = null;
            this.fld_btnShowKPI.BOSDataSource = null;
            this.fld_btnShowKPI.BOSDescription = null;
            this.fld_btnShowKPI.BOSError = null;
            this.fld_btnShowKPI.BOSFieldGroup = null;
            this.fld_btnShowKPI.BOSFieldRelation = null;
            this.fld_btnShowKPI.BOSPrivilege = null;
            this.fld_btnShowKPI.BOSPropertyName = null;
            this.fld_btnShowKPI.Location = new System.Drawing.Point(10, 25);
            this.fld_btnShowKPI.Name = "fld_btnShowKPI";
            this.fld_btnShowKPI.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowKPI, true);
            this.fld_btnShowKPI.Size = new System.Drawing.Size(99, 27);
            this.fld_btnShowKPI.TabIndex = 0;
            this.fld_btnShowKPI.Tag = "ShowKPI";
            this.fld_btnShowKPI.Text = "Chọn KPI";
            this.fld_btnShowKPI.Click += new System.EventHandler(this.fld_btnShowKPI_Click);
            // 
            // fld_dgcHRKPIFormItems
            // 
            this.fld_dgcHRKPIFormItems.AllowDrop = true;
            this.fld_dgcHRKPIFormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIFormItems.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.BOSDataSource = "HRKPIFormItems";
            this.fld_dgcHRKPIFormItems.BOSDescription = null;
            this.fld_dgcHRKPIFormItems.BOSError = null;
            this.fld_dgcHRKPIFormItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.BOSGridType = null;
            this.fld_dgcHRKPIFormItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIFormItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIFormItems.Location = new System.Drawing.Point(2, 58);
            this.fld_dgcHRKPIFormItems.MainView = this.fld_dgvHRKPIFormItems;
            this.fld_dgcHRKPIFormItems.Name = "fld_dgcHRKPIFormItems";
            this.fld_dgcHRKPIFormItems.PrintReport = false;
            this.fld_dgcHRKPIFormItems.Screen = null;
            this.fld_dgcHRKPIFormItems.Size = new System.Drawing.Size(1047, 346);
            this.fld_dgcHRKPIFormItems.TabIndex = 1;
            this.fld_dgcHRKPIFormItems.Tag = "DC";
            this.fld_dgcHRKPIFormItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRKPIFormItems});
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.GridControl = this.fld_dgcHRKPIFormItems;
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(290, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 107;
            this.bosLabel6.Text = "Tình trạng";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "HRKPIFormStatus";
            this.bosLookupEdit1.BOSDataSource = "HRKPIForms";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(387, 38);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(153, 20);
            this.bosLookupEdit1.TabIndex = 4;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_txtHRKPIFormName
            // 
            this.fld_txtHRKPIFormName.BOSComment = null;
            this.fld_txtHRKPIFormName.BOSDataMember = "HRKPIFormName";
            this.fld_txtHRKPIFormName.BOSDataSource = "HRKPIForms";
            this.fld_txtHRKPIFormName.BOSDescription = null;
            this.fld_txtHRKPIFormName.BOSError = null;
            this.fld_txtHRKPIFormName.BOSFieldGroup = null;
            this.fld_txtHRKPIFormName.BOSFieldRelation = null;
            this.fld_txtHRKPIFormName.BOSPrivilege = null;
            this.fld_txtHRKPIFormName.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIFormName.Location = new System.Drawing.Point(387, 12);
            this.fld_txtHRKPIFormName.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIFormName.Name = "fld_txtHRKPIFormName";
            this.fld_txtHRKPIFormName.Screen = null;
            this.fld_txtHRKPIFormName.Size = new System.Drawing.Size(322, 20);
            this.fld_txtHRKPIFormName.TabIndex = 1;
            this.fld_txtHRKPIFormName.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(290, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(65, 13);
            this.bosLabel8.TabIndex = 113;
            this.bosLabel8.Text = "Tên chứng từ";
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
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIFormTotalWeight);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIFormName);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_dteHRKPIFormDate);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIFormNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1057, 473);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(891, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(152, 13);
            this.bosLabel3.TabIndex = 117;
            this.bosLabel3.Text = "Tổng trọng số phải bằng 100 %";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(768, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(71, 13);
            this.bosLabel1.TabIndex = 115;
            this.bosLabel1.Text = "Tổng trọng số:";
            // 
            // fld_txtHRKPIFormTotalWeight
            // 
            this.fld_txtHRKPIFormTotalWeight.BOSComment = null;
            this.fld_txtHRKPIFormTotalWeight.BOSDataMember = "HRKPIFormTotalWeight";
            this.fld_txtHRKPIFormTotalWeight.BOSDataSource = "HRKPIForms";
            this.fld_txtHRKPIFormTotalWeight.BOSDescription = null;
            this.fld_txtHRKPIFormTotalWeight.BOSError = null;
            this.fld_txtHRKPIFormTotalWeight.BOSFieldGroup = null;
            this.fld_txtHRKPIFormTotalWeight.BOSFieldRelation = null;
            this.fld_txtHRKPIFormTotalWeight.BOSPrivilege = null;
            this.fld_txtHRKPIFormTotalWeight.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIFormTotalWeight.Location = new System.Drawing.Point(845, 38);
            this.fld_txtHRKPIFormTotalWeight.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIFormTotalWeight.Name = "fld_txtHRKPIFormTotalWeight";
            this.fld_txtHRKPIFormTotalWeight.Properties.ReadOnly = true;
            this.fld_txtHRKPIFormTotalWeight.Screen = null;
            this.fld_txtHRKPIFormTotalWeight.Size = new System.Drawing.Size(23, 20);
            this.fld_txtHRKPIFormTotalWeight.TabIndex = 118;
            this.fld_txtHRKPIFormTotalWeight.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(874, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(11, 13);
            this.bosLabel2.TabIndex = 119;
            this.bosLabel2.Text = "%";
            // 
            // DMKPIF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1057, 473);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMKPIF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIFormDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIFormDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormName.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIFormTotalWeight.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSTextBox fld_txtHRKPIFormNo;
        private BOSComponent.BOSDateEdit fld_dteHRKPIFormDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSButton fld_btnShowKPI;
        private HRKPIFormItemsGridControl fld_dgcHRKPIFormItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSTextBox fld_txtHRKPIFormName;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHRKPIFormTotalWeight;
	}
}
