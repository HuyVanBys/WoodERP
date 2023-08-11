using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DormitoryCost.UI
{
	/// <summary>
    /// Summary description for DMRD100
	/// </summary>
    partial class DMDMC100
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
            this.fld_txtHRDormitoryCostUnitPriceElectricity = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRDormitoryCostDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRDormitoryCostName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRRegisterDormitoryToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHRRegisterDormitoryDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRRegisterDormitoryFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDormitoryCostNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRDormitoryCostItems = new BOSERP.Modules.DormitoryCost.HRDormitoryCostItemsGridControl();
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtHRDormitoryCostUnitPriceWater = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostUnitPriceElectricity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryCostDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryCostDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRegisterDormitoryDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryCostItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostUnitPriceWater.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = "HRDormitoryCosts";
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryCostUnitPriceWater);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryCostUnitPriceElectricity);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteHRDormitoryCostDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryCostName);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteHRRegisterDormitoryToDate);
            this.bosPanel1.Controls.Add(this.fld_medHRRegisterDormitoryDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRRegisterDormitoryFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRDormitoryCostNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(926, 431);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_txtHRDormitoryCostUnitPriceElectricity
            // 
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSComment = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSDataMember = "HRDormitoryCostUnitPriceElectricity";
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSDataSource = "HRDormitoryCosts";
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSDescription = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSError = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSFieldGroup = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSFieldRelation = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSPrivilege = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Location = new System.Drawing.Point(657, 38);
            this.fld_txtHRDormitoryCostUnitPriceElectricity.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Name = "fld_txtHRDormitoryCostUnitPriceElectricity";
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Screen = null;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Size = new System.Drawing.Size(142, 20);
            this.fld_txtHRDormitoryCostUnitPriceElectricity.TabIndex = 97;
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Tag = "DC";
            this.fld_txtHRDormitoryCostUnitPriceElectricity.Validated += new System.EventHandler(this.fld_txtHRDormitoryCostUnitPriceElectricity_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(569, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(60, 13);
            this.bosLabel2.TabIndex = 96;
            this.bosLabel2.Text = "Đơn giá điện";
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
            this.bosLabel4.Location = new System.Drawing.Point(569, 17);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 95;
            this.bosLabel4.Text = "Ngày chứng từ";
            // 
            // fld_dteHRDormitoryCostDate
            // 
            this.fld_dteHRDormitoryCostDate.BOSComment = null;
            this.fld_dteHRDormitoryCostDate.BOSDataMember = "HRDormitoryCostDate";
            this.fld_dteHRDormitoryCostDate.BOSDataSource = "HRDormitoryCosts";
            this.fld_dteHRDormitoryCostDate.BOSDescription = null;
            this.fld_dteHRDormitoryCostDate.BOSError = null;
            this.fld_dteHRDormitoryCostDate.BOSFieldGroup = null;
            this.fld_dteHRDormitoryCostDate.BOSFieldRelation = null;
            this.fld_dteHRDormitoryCostDate.BOSPrivilege = null;
            this.fld_dteHRDormitoryCostDate.BOSPropertyName = "EditValue";
            this.fld_dteHRDormitoryCostDate.EditValue = null;
            this.fld_dteHRDormitoryCostDate.Location = new System.Drawing.Point(657, 12);
            this.fld_dteHRDormitoryCostDate.Name = "fld_dteHRDormitoryCostDate";
            this.fld_dteHRDormitoryCostDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRDormitoryCostDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRDormitoryCostDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRDormitoryCostDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRDormitoryCostDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRDormitoryCostDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRDormitoryCostDate.Screen = null;
            this.fld_dteHRDormitoryCostDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteHRDormitoryCostDate.TabIndex = 94;
            this.fld_dteHRDormitoryCostDate.Tag = "DC";
            // 
            // fld_txtHRDormitoryCostName
            // 
            this.fld_txtHRDormitoryCostName.BOSComment = null;
            this.fld_txtHRDormitoryCostName.BOSDataMember = "HRDormitoryCostName";
            this.fld_txtHRDormitoryCostName.BOSDataSource = "HRDormitoryCosts";
            this.fld_txtHRDormitoryCostName.BOSDescription = null;
            this.fld_txtHRDormitoryCostName.BOSError = null;
            this.fld_txtHRDormitoryCostName.BOSFieldGroup = null;
            this.fld_txtHRDormitoryCostName.BOSFieldRelation = null;
            this.fld_txtHRDormitoryCostName.BOSPrivilege = null;
            this.fld_txtHRDormitoryCostName.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryCostName.Location = new System.Drawing.Point(371, 12);
            this.fld_txtHRDormitoryCostName.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryCostName.Name = "fld_txtHRDormitoryCostName";
            this.fld_txtHRDormitoryCostName.Screen = null;
            this.fld_txtHRDormitoryCostName.Size = new System.Drawing.Size(142, 20);
            this.fld_txtHRDormitoryCostName.TabIndex = 93;
            this.fld_txtHRDormitoryCostName.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(283, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(65, 13);
            this.bosLabel6.TabIndex = 92;
            this.bosLabel6.Text = "Tên chứng từ";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = "";
            this.fld_btnAddEmployee.BOSDataMember = "";
            this.fld_btnAddEmployee.BOSDataSource = "";
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = "";
            this.fld_btnAddEmployee.BOSFieldRelation = "";
            this.fld_btnAddEmployee.BOSPrivilege = "";
            this.fld_btnAddEmployee.BOSPropertyName = "";
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(12, 395);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 88;
            this.fld_btnAddEmployee.Tag = "";
            this.fld_btnAddEmployee.Text = "Thêm phòng trọ";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(283, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 87;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_dteHRRegisterDormitoryToDate
            // 
            this.fld_dteHRRegisterDormitoryToDate.BOSComment = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSDataMember = "HRDormitoryCostToDate";
            this.fld_dteHRRegisterDormitoryToDate.BOSDataSource = "HRDormitoryCosts";
            this.fld_dteHRRegisterDormitoryToDate.BOSDescription = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSError = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSFieldGroup = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSFieldRelation = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSPrivilege = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRegisterDormitoryToDate.EditValue = null;
            this.fld_dteHRRegisterDormitoryToDate.Location = new System.Drawing.Point(371, 36);
            this.fld_dteHRRegisterDormitoryToDate.Name = "fld_dteHRRegisterDormitoryToDate";
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRegisterDormitoryToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRegisterDormitoryToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRegisterDormitoryToDate.Screen = null;
            this.fld_dteHRRegisterDormitoryToDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteHRRegisterDormitoryToDate.TabIndex = 86;
            this.fld_dteHRRegisterDormitoryToDate.Tag = "DC";
            // 
            // fld_medHRRegisterDormitoryDesc
            // 
            this.fld_medHRRegisterDormitoryDesc.BOSComment = "";
            this.fld_medHRRegisterDormitoryDesc.BOSDataMember = "HRDormitoryCostDesc";
            this.fld_medHRRegisterDormitoryDesc.BOSDataSource = "HRDormitoryCosts";
            this.fld_medHRRegisterDormitoryDesc.BOSDescription = null;
            this.fld_medHRRegisterDormitoryDesc.BOSError = null;
            this.fld_medHRRegisterDormitoryDesc.BOSFieldGroup = "";
            this.fld_medHRRegisterDormitoryDesc.BOSFieldRelation = "";
            this.fld_medHRRegisterDormitoryDesc.BOSPrivilege = "";
            this.fld_medHRRegisterDormitoryDesc.BOSPropertyName = "EditValue";
            this.fld_medHRRegisterDormitoryDesc.EditValue = "";
            this.fld_medHRRegisterDormitoryDesc.Location = new System.Drawing.Point(103, 62);
            this.fld_medHRRegisterDormitoryDesc.Name = "fld_medHRRegisterDormitoryDesc";
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRegisterDormitoryDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRRegisterDormitoryDesc, true);
            this.fld_medHRRegisterDormitoryDesc.Size = new System.Drawing.Size(410, 40);
            this.fld_medHRRegisterDormitoryDesc.TabIndex = 82;
            this.fld_medHRRegisterDormitoryDesc.Tag = "DC";
            // 
            // fld_dteHRRegisterDormitoryFromDate
            // 
            this.fld_dteHRRegisterDormitoryFromDate.BOSComment = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSDataMember = "HRDormitoryCostFromDate";
            this.fld_dteHRRegisterDormitoryFromDate.BOSDataSource = "HRDormitoryCosts";
            this.fld_dteHRRegisterDormitoryFromDate.BOSDescription = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSError = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSFieldGroup = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSFieldRelation = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSPrivilege = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRegisterDormitoryFromDate.EditValue = null;
            this.fld_dteHRRegisterDormitoryFromDate.Location = new System.Drawing.Point(103, 36);
            this.fld_dteHRRegisterDormitoryFromDate.Name = "fld_dteHRRegisterDormitoryFromDate";
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRegisterDormitoryFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRegisterDormitoryFromDate.Screen = null;
            this.fld_dteHRRegisterDormitoryFromDate.Size = new System.Drawing.Size(129, 20);
            this.fld_dteHRRegisterDormitoryFromDate.TabIndex = 81;
            this.fld_dteHRRegisterDormitoryFromDate.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(27, 65);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 79;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel3.Location = new System.Drawing.Point(27, 39);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 73;
            this.bosLabel3.Text = "Từ ngày";
            // 
            // fld_txtHRDormitoryCostNo
            // 
            this.fld_txtHRDormitoryCostNo.BOSComment = null;
            this.fld_txtHRDormitoryCostNo.BOSDataMember = "HRDormitoryCostNo";
            this.fld_txtHRDormitoryCostNo.BOSDataSource = "HRDormitoryCosts";
            this.fld_txtHRDormitoryCostNo.BOSDescription = null;
            this.fld_txtHRDormitoryCostNo.BOSError = null;
            this.fld_txtHRDormitoryCostNo.BOSFieldGroup = null;
            this.fld_txtHRDormitoryCostNo.BOSFieldRelation = null;
            this.fld_txtHRDormitoryCostNo.BOSPrivilege = null;
            this.fld_txtHRDormitoryCostNo.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryCostNo.Location = new System.Drawing.Point(103, 10);
            this.fld_txtHRDormitoryCostNo.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryCostNo.Name = "fld_txtHRDormitoryCostNo";
            this.fld_txtHRDormitoryCostNo.Screen = null;
            this.fld_txtHRDormitoryCostNo.Size = new System.Drawing.Size(129, 20);
            this.fld_txtHRDormitoryCostNo.TabIndex = 70;
            this.fld_txtHRDormitoryCostNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(27, 13);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 69;
            this.bosLabel7.Text = "Mã chứng từ";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 124);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(920, 265);
            this.bosTabControl1.TabIndex = 68;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRDormitoryCostItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(914, 237);
            this.xtraTabPage1.Text = "Danh sách phòng trọ";
            // 
            // fld_dgcHRDormitoryCostItems
            // 
            this.fld_dgcHRDormitoryCostItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRDormitoryCostItems.BOSComment = null;
            this.fld_dgcHRDormitoryCostItems.BOSDataMember = null;
            this.fld_dgcHRDormitoryCostItems.BOSDataSource = "HRDormitoryCostItems";
            this.fld_dgcHRDormitoryCostItems.BOSDescription = null;
            this.fld_dgcHRDormitoryCostItems.BOSError = null;
            this.fld_dgcHRDormitoryCostItems.BOSFieldGroup = null;
            this.fld_dgcHRDormitoryCostItems.BOSFieldRelation = null;
            this.fld_dgcHRDormitoryCostItems.BOSGridType = null;
            this.fld_dgcHRDormitoryCostItems.BOSPrivilege = null;
            this.fld_dgcHRDormitoryCostItems.BOSPropertyName = null;
            this.fld_dgcHRDormitoryCostItems.CommodityType = "";
            this.fld_dgcHRDormitoryCostItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHRDormitoryCostItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRDormitoryCostItems.Name = "fld_dgcHRDormitoryCostItems";
            this.fld_dgcHRDormitoryCostItems.PrintReport = false;
            this.fld_dgcHRDormitoryCostItems.Screen = null;
            this.fld_dgcHRDormitoryCostItems.Size = new System.Drawing.Size(907, 231);
            this.fld_dgcHRDormitoryCostItems.TabIndex = 3;
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
            this.fld_pteARSaleOrderItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleOrderItemProductPicture.FileName = null;
            this.fld_pteARSaleOrderItemProductPicture.FilePath = null;
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
            this.fld_lkeFK_ICProductAttributeID.Properties.ColumnName = null;
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
            this.fld_dgcARSaleOrderItems.CommodityType = "";
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
            // fld_txtHRDormitoryCostUnitPriceWater
            // 
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSComment = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSDataMember = "HRDormitoryCostUnitPriceWater";
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSDataSource = "HRDormitoryCosts";
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSDescription = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSError = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSFieldGroup = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSFieldRelation = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSPrivilege = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.BOSPropertyName = "EditValue";
            this.fld_txtHRDormitoryCostUnitPriceWater.Location = new System.Drawing.Point(657, 64);
            this.fld_txtHRDormitoryCostUnitPriceWater.MenuManager = this.screenToolbar;
            this.fld_txtHRDormitoryCostUnitPriceWater.Name = "fld_txtHRDormitoryCostUnitPriceWater";
            this.fld_txtHRDormitoryCostUnitPriceWater.Screen = null;
            this.fld_txtHRDormitoryCostUnitPriceWater.Size = new System.Drawing.Size(142, 20);
            this.fld_txtHRDormitoryCostUnitPriceWater.TabIndex = 99;
            this.fld_txtHRDormitoryCostUnitPriceWater.Tag = "DC";
            this.fld_txtHRDormitoryCostUnitPriceWater.Validated += new System.EventHandler(this.Fld_txtHRDormitoryCostUnitPriceWater_Validated);
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(569, 67);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(64, 13);
            this.bosLabel8.TabIndex = 98;
            this.bosLabel8.Text = "Đơn giá nước";
            // 
            // DMDMC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(926, 431);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDMC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostUnitPriceElectricity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryCostDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRDormitoryCostDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRegisterDormitoryDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitoryCostItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryCostUnitPriceWater.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryCostNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteHRRegisterDormitoryFromDate;
        private BOSComponent.BOSMemoEdit fld_medHRRegisterDormitoryDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteHRRegisterDormitoryToDate;
        private HRDormitoryCostItemsGridControl fld_dgcHRDormitoryCostItems;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryCostUnitPriceElectricity;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteHRDormitoryCostDate;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryCostName;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryCostUnitPriceWater;
        private BOSComponent.BOSLabel bosLabel8;
    }
}
