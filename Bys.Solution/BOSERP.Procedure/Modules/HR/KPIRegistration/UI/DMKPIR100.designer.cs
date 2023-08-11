using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIRegistration.UI
{
	/// <summary>
	/// Summary description for DMKPIR100
	/// </summary>
	partial class DMKPIR100
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
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPIRegistrationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRKPIRegistrationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRKPIRegistrationEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtHRKPIRegistrationTotalAmountBonus = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHRKPIRegistrationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_dteHRKPIRegistrationFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRKPIRegistrationEndMonth = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRKPIRegistrationMonth = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRKPIRegistrationStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPIRegistrationName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnChangeKPIForm = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_HRKPIFormID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRKPIRegistrationItemTargets = new BOSERP.Modules.KPIRegistration.HRKPIRegistrationItemTargetsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeKPIRegistrationItems = new BOSERP.Modules.KPIRegistration.HREmployeeKPIRegistrationItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRKPIRegistrationItems = new BOSERP.Modules.KPIRegistration.HRKPIRegistrationItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIRegistrationEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationTotalAmountBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRKPIRegistrationStatus.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationEndMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationEndMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRKPIFormID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrationItemTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeKPIRegistrationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(133, 41);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_txtHRKPIRegistrationNo
            // 
            this.fld_txtHRKPIRegistrationNo.BOSComment = null;
            this.fld_txtHRKPIRegistrationNo.BOSDataMember = "HRKPIRegistrationNo";
            this.fld_txtHRKPIRegistrationNo.BOSDataSource = "HRKPIRegistrations";
            this.fld_txtHRKPIRegistrationNo.BOSDescription = null;
            this.fld_txtHRKPIRegistrationNo.BOSError = null;
            this.fld_txtHRKPIRegistrationNo.BOSFieldGroup = null;
            this.fld_txtHRKPIRegistrationNo.BOSFieldRelation = null;
            this.fld_txtHRKPIRegistrationNo.BOSPrivilege = null;
            this.fld_txtHRKPIRegistrationNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIRegistrationNo.Location = new System.Drawing.Point(212, 11);
            this.fld_txtHRKPIRegistrationNo.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIRegistrationNo.Name = "fld_txtHRKPIRegistrationNo";
            this.fld_txtHRKPIRegistrationNo.Screen = null;
            this.fld_txtHRKPIRegistrationNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRKPIRegistrationNo.TabIndex = 0;
            this.fld_txtHRKPIRegistrationNo.Tag = "DC";
            // 
            // fld_dteHRKPIRegistrationDate
            // 
            this.fld_dteHRKPIRegistrationDate.BOSComment = null;
            this.fld_dteHRKPIRegistrationDate.BOSDataMember = "HRKPIRegistrationDate";
            this.fld_dteHRKPIRegistrationDate.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteHRKPIRegistrationDate.BOSDescription = null;
            this.fld_dteHRKPIRegistrationDate.BOSError = null;
            this.fld_dteHRKPIRegistrationDate.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationDate.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationDate.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIRegistrationDate.EditValue = null;
            this.fld_dteHRKPIRegistrationDate.Location = new System.Drawing.Point(212, 38);
            this.fld_dteHRKPIRegistrationDate.Name = "fld_dteHRKPIRegistrationDate";
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIRegistrationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationDate.Screen = null;
            this.fld_dteHRKPIRegistrationDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIRegistrationDate.TabIndex = 2;
            this.fld_dteHRKPIRegistrationDate.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(133, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRKPIRegistrations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(9, 77);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(92, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 8;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(412, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(77, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Tiền thưởng KPI";
            // 
            // fld_pteHRKPIRegistrationEmployeePicture
            // 
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSComment = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSDataMember = "HRKPIRegistrationEmployeePicture";
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSDataSource = "HRKPIRegistrations";
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSDescription = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSError = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRKPIRegistrationEmployeePicture.Location = new System.Drawing.Point(9, 3);
            this.fld_pteHRKPIRegistrationEmployeePicture.Name = "fld_pteHRKPIRegistrationEmployeePicture";
            this.fld_pteHRKPIRegistrationEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRKPIRegistrationEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRKPIRegistrationEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRKPIRegistrationEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRKPIRegistrationEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRKPIRegistrationEmployeePicture.Screen = null;
            this.fld_pteHRKPIRegistrationEmployeePicture.Size = new System.Drawing.Size(92, 72);
            this.fld_pteHRKPIRegistrationEmployeePicture.TabIndex = 76;
            this.fld_pteHRKPIRegistrationEmployeePicture.Tag = "DC";
            // 
            // fld_txtHRKPIRegistrationTotalAmountBonus
            // 
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSComment = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSDataMember = "HRKPIRegistrationTotalAmountBonus";
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSDataSource = "HRKPIRegistrations";
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSDescription = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSError = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSFieldGroup = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSFieldRelation = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSPrivilege = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Location = new System.Drawing.Point(534, 37);
            this.fld_txtHRKPIRegistrationTotalAmountBonus.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Name = "fld_txtHRKPIRegistrationTotalAmountBonus";
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Screen = null;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Size = new System.Drawing.Size(204, 20);
            this.fld_txtHRKPIRegistrationTotalAmountBonus.TabIndex = 4;
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Tag = "DC";
            this.fld_txtHRKPIRegistrationTotalAmountBonus.Validated += new System.EventHandler(this.fld_txtHRKPIRegistrationTotalAmountBonus_Validated);
            // 
            // fld_lkeHRKPIRegistrationStatus
            // 
            this.fld_lkeHRKPIRegistrationStatus.BOSAllowAddNew = false;
            this.fld_lkeHRKPIRegistrationStatus.BOSAllowDummy = true;
            this.fld_lkeHRKPIRegistrationStatus.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSDataMember = "HRKPIRegistrationStatus";
            this.fld_lkeHRKPIRegistrationStatus.BOSDataSource = "HRKPIRegistrations";
            this.fld_lkeHRKPIRegistrationStatus.BOSDescription = null;
            this.fld_lkeHRKPIRegistrationStatus.BOSError = null;
            this.fld_lkeHRKPIRegistrationStatus.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRKPIRegistrationStatus.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.CurrentDisplayText = null;
            this.fld_lkeHRKPIRegistrationStatus.Location = new System.Drawing.Point(211, 64);
            this.fld_lkeHRKPIRegistrationStatus.Name = "fld_lkeHRKPIRegistrationStatus";
            this.fld_lkeHRKPIRegistrationStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRKPIRegistrationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRKPIRegistrationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRKPIRegistrationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRKPIRegistrationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRKPIRegistrationStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRKPIRegistrationStatus.Properties.PopupWidth = 40;
            this.fld_lkeHRKPIRegistrationStatus.Properties.ReadOnly = true;
            this.fld_lkeHRKPIRegistrationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRKPIRegistrationStatus.Screen = null;
            this.fld_lkeHRKPIRegistrationStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeHRKPIRegistrationStatus.TabIndex = 5;
            this.fld_lkeHRKPIRegistrationStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.Location = new System.Drawing.Point(133, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 108;
            this.bosLabel6.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_dteHRKPIRegistrationFinishedDate);
            this.groupBox1.Controls.Add(this.fld_dteHRKPIRegistrationEndMonth);
            this.groupBox1.Controls.Add(this.fld_dteHRKPIRegistrationMonth);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_dteHRKPIRegistrationStartDate);
            this.groupBox1.Controls.Add(this.bosLabel4);
            this.groupBox1.Location = new System.Drawing.Point(793, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian áp dụng";
            // 
            // fld_dteHRKPIRegistrationFinishedDate
            // 
            this.fld_dteHRKPIRegistrationFinishedDate.BOSComment = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSDataMember = "HRKPIRegistrationFinishedDate";
            this.fld_dteHRKPIRegistrationFinishedDate.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteHRKPIRegistrationFinishedDate.BOSDescription = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSError = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationFinishedDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIRegistrationFinishedDate.EditValue = null;
            this.fld_dteHRKPIRegistrationFinishedDate.Location = new System.Drawing.Point(238, 43);
            this.fld_dteHRKPIRegistrationFinishedDate.Name = "fld_dteHRKPIRegistrationFinishedDate";
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.ReadOnly = true;
            this.fld_dteHRKPIRegistrationFinishedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationFinishedDate.Screen = null;
            this.fld_dteHRKPIRegistrationFinishedDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIRegistrationFinishedDate.TabIndex = 1;
            this.fld_dteHRKPIRegistrationFinishedDate.Tag = "DC";
            // 
            // fld_dteHRKPIRegistrationEndMonth
            // 
            this.fld_dteHRKPIRegistrationEndMonth.BOSComment = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSDataMember = "HRKPIRegistrationEndMonth";
            this.fld_dteHRKPIRegistrationEndMonth.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteHRKPIRegistrationEndMonth.BOSDescription = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSError = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationEndMonth.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIRegistrationEndMonth.EditValue = null;
            this.fld_dteHRKPIRegistrationEndMonth.Location = new System.Drawing.Point(79, 43);
            this.fld_dteHRKPIRegistrationEndMonth.Name = "fld_dteHRKPIRegistrationEndMonth";
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIRegistrationEndMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRKPIRegistrationEndMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRKPIRegistrationEndMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRKPIRegistrationEndMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRKPIRegistrationEndMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRKPIRegistrationEndMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationEndMonth.Screen = null;
            this.fld_dteHRKPIRegistrationEndMonth.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIRegistrationEndMonth.TabIndex = 9;
            this.fld_dteHRKPIRegistrationEndMonth.Tag = "DC";
            this.fld_dteHRKPIRegistrationEndMonth.Validated += new System.EventHandler(this.fld_dteHRKPIRegistrationEndMonth_Validated);
            // 
            // fld_dteHRKPIRegistrationMonth
            // 
            this.fld_dteHRKPIRegistrationMonth.BOSComment = null;
            this.fld_dteHRKPIRegistrationMonth.BOSDataMember = "HRKPIRegistrationMonth";
            this.fld_dteHRKPIRegistrationMonth.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteHRKPIRegistrationMonth.BOSDescription = null;
            this.fld_dteHRKPIRegistrationMonth.BOSError = null;
            this.fld_dteHRKPIRegistrationMonth.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationMonth.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationMonth.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationMonth.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIRegistrationMonth.EditValue = null;
            this.fld_dteHRKPIRegistrationMonth.Location = new System.Drawing.Point(79, 17);
            this.fld_dteHRKPIRegistrationMonth.Name = "fld_dteHRKPIRegistrationMonth";
            this.fld_dteHRKPIRegistrationMonth.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_dteHRKPIRegistrationMonth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationMonth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationMonth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIRegistrationMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRKPIRegistrationMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRKPIRegistrationMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRKPIRegistrationMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRKPIRegistrationMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRKPIRegistrationMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationMonth.Screen = null;
            this.fld_dteHRKPIRegistrationMonth.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIRegistrationMonth.TabIndex = 8;
            this.fld_dteHRKPIRegistrationMonth.Tag = "DC";
            this.fld_dteHRKPIRegistrationMonth.Validated += new System.EventHandler(this.fld_dteHRKPIRegistrationMonth_Validated);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(6, 46);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteHRKPIRegistrationStartDate
            // 
            this.fld_dteHRKPIRegistrationStartDate.BOSComment = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSDataMember = "HRKPIRegistrationStartDate";
            this.fld_dteHRKPIRegistrationStartDate.BOSDataSource = "HRKPIRegistrations";
            this.fld_dteHRKPIRegistrationStartDate.BOSDescription = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSError = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSFieldGroup = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSFieldRelation = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSPrivilege = null;
            this.fld_dteHRKPIRegistrationStartDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIRegistrationStartDate.EditValue = null;
            this.fld_dteHRKPIRegistrationStartDate.Location = new System.Drawing.Point(238, 17);
            this.fld_dteHRKPIRegistrationStartDate.Name = "fld_dteHRKPIRegistrationStartDate";
            this.fld_dteHRKPIRegistrationStartDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteHRKPIRegistrationStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIRegistrationStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIRegistrationStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIRegistrationStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIRegistrationStartDate.Properties.ReadOnly = true;
            this.fld_dteHRKPIRegistrationStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIRegistrationStartDate.Screen = null;
            this.fld_dteHRKPIRegistrationStartDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIRegistrationStartDate.TabIndex = 0;
            this.fld_dteHRKPIRegistrationStartDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(6, 20);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Text = "Từ ngày";
            // 
            // fld_txtHRKPIRegistrationName
            // 
            this.fld_txtHRKPIRegistrationName.BOSComment = null;
            this.fld_txtHRKPIRegistrationName.BOSDataMember = "HRKPIRegistrationName";
            this.fld_txtHRKPIRegistrationName.BOSDataSource = "HRKPIRegistrations";
            this.fld_txtHRKPIRegistrationName.BOSDescription = null;
            this.fld_txtHRKPIRegistrationName.BOSError = null;
            this.fld_txtHRKPIRegistrationName.BOSFieldGroup = null;
            this.fld_txtHRKPIRegistrationName.BOSFieldRelation = null;
            this.fld_txtHRKPIRegistrationName.BOSPrivilege = null;
            this.fld_txtHRKPIRegistrationName.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIRegistrationName.Location = new System.Drawing.Point(534, 11);
            this.fld_txtHRKPIRegistrationName.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIRegistrationName.Name = "fld_txtHRKPIRegistrationName";
            this.fld_txtHRKPIRegistrationName.Screen = null;
            this.fld_txtHRKPIRegistrationName.Size = new System.Drawing.Size(204, 20);
            this.fld_txtHRKPIRegistrationName.TabIndex = 1;
            this.fld_txtHRKPIRegistrationName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(412, 14);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 111;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel8.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(412, 66);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(62, 13);
            this.bosLabel8.TabIndex = 113;
            this.bosLabel8.Text = "Biểu mẫu KPI";
            // 
            // fld_btnChangeKPIForm
            // 
            this.fld_btnChangeKPIForm.BOSComment = null;
            this.fld_btnChangeKPIForm.BOSDataMember = null;
            this.fld_btnChangeKPIForm.BOSDataSource = null;
            this.fld_btnChangeKPIForm.BOSDescription = null;
            this.fld_btnChangeKPIForm.BOSError = null;
            this.fld_btnChangeKPIForm.BOSFieldGroup = null;
            this.fld_btnChangeKPIForm.BOSFieldRelation = null;
            this.fld_btnChangeKPIForm.BOSPrivilege = null;
            this.fld_btnChangeKPIForm.BOSPropertyName = null;
            this.fld_btnChangeKPIForm.Location = new System.Drawing.Point(683, 62);
            this.fld_btnChangeKPIForm.Name = "fld_btnChangeKPIForm";
            this.fld_btnChangeKPIForm.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChangeKPIForm, true);
            this.fld_btnChangeKPIForm.Size = new System.Drawing.Size(55, 21);
            this.fld_btnChangeKPIForm.TabIndex = 7;
            this.fld_btnChangeKPIForm.Tag = "ShowKPIRegists";
            this.fld_btnChangeKPIForm.Text = "Thay đổi";
            this.fld_btnChangeKPIForm.Click += new System.EventHandler(this.fld_btnChangeKPIForm_Click);
            // 
            // fld_lkeFK_HRKPIFormID
            // 
            this.fld_lkeFK_HRKPIFormID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRKPIFormID.BOSAllowDummy = false;
            this.fld_lkeFK_HRKPIFormID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSDataMember = "FK_HRKPIFormID";
            this.fld_lkeFK_HRKPIFormID.BOSDataSource = "HRKPIRegistrations";
            this.fld_lkeFK_HRKPIFormID.BOSDescription = null;
            this.fld_lkeFK_HRKPIFormID.BOSError = null;
            this.fld_lkeFK_HRKPIFormID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRKPIFormID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.Location = new System.Drawing.Point(534, 63);
            this.fld_lkeFK_HRKPIFormID.Name = "fld_lkeFK_HRKPIFormID";
            this.fld_lkeFK_HRKPIFormID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRKPIFormID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRKPIFormID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRKPIFormID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRKPIFormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRKPIFormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRKPIFormNo", "Mã biểu mẫu", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRKPIFormName", "Name")});
            this.fld_lkeFK_HRKPIFormID.Properties.DisplayMember = "HRKPIFormName";
            this.fld_lkeFK_HRKPIFormID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRKPIFormID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRKPIFormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRKPIFormID.Properties.ValueMember = "HRKPIFormID";
            this.fld_lkeFK_HRKPIFormID.Screen = null;
            this.fld_lkeFK_HRKPIFormID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_HRKPIFormID.TabIndex = 6;
            this.fld_lkeFK_HRKPIFormID.Tag = "DC";
            this.fld_lkeFK_HRKPIFormID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRKPIFormID_QueryPopUp);
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
            this.bosPanel1.Controls.Add(this.splitter1);
            this.bosPanel1.Controls.Add(this.splitContainer1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRKPIFormID);
            this.bosPanel1.Controls.Add(this.fld_btnChangeKPIForm);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIRegistrationName);
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeHRKPIRegistrationStatus);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIRegistrationTotalAmountBonus);
            this.bosPanel1.Controls.Add(this.fld_pteHRKPIRegistrationEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteHRKPIRegistrationDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIRegistrationNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1366, 749);
            this.bosPanel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 749);
            this.splitter1.TabIndex = 115;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 103);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainer1.Panel1.Controls.Add(this.bosGroupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fld_grcGroupControl3);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 643);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 114;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl2.Appearance.Options.UseBackColor = true;
            this.bosGroupControl2.Appearance.Options.UseForeColor = true;
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcHRKPIRegistrationItemTargets);
            this.bosGroupControl2.Location = new System.Drawing.Point(9, 384);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(512, 256);
            this.bosGroupControl2.TabIndex = 9;
            this.bosGroupControl2.Text = "Tổng hợp tiêu chí";
            // 
            // fld_dgcHRKPIRegistrationItemTargets
            // 
            this.fld_dgcHRKPIRegistrationItemTargets.AllowDrop = true;
            this.fld_dgcHRKPIRegistrationItemTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIRegistrationItemTargets.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSDataSource = "HRKPIRegistrationItemTargets";
            this.fld_dgcHRKPIRegistrationItemTargets.BOSDescription = null;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSError = null;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSGridType = null;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItemTargets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIRegistrationItemTargets.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRKPIRegistrationItemTargets.MainView = this.gridView3;
            this.fld_dgcHRKPIRegistrationItemTargets.Name = "fld_dgcHRKPIRegistrationItemTargets";
            this.fld_dgcHRKPIRegistrationItemTargets.PrintReport = false;
            this.fld_dgcHRKPIRegistrationItemTargets.Screen = null;
            this.fld_dgcHRKPIRegistrationItemTargets.Size = new System.Drawing.Size(502, 231);
            this.fld_dgcHRKPIRegistrationItemTargets.TabIndex = 12;
            this.fld_dgcHRKPIRegistrationItemTargets.Tag = "DC";
            this.fld_dgcHRKPIRegistrationItemTargets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcHRKPIRegistrationItemTargets;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcHREmployeeKPIRegistrationItems);
            this.bosGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.bosGroupControl1.Location = new System.Drawing.Point(9, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(512, 375);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Danh sách nhân viên";
            // 
            // fld_dgcHREmployeeKPIRegistrationItems
            // 
            this.fld_dgcHREmployeeKPIRegistrationItems.AllowDrop = true;
            this.fld_dgcHREmployeeKPIRegistrationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSDataSource = "HREmployeeKPIRegistrationItems";
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSDescription = null;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSError = null;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSGridType = null;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeKPIRegistrationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeKPIRegistrationItems.Location = new System.Drawing.Point(5, 60);
            this.fld_dgcHREmployeeKPIRegistrationItems.MainView = this.gridView2;
            this.fld_dgcHREmployeeKPIRegistrationItems.Name = "fld_dgcHREmployeeKPIRegistrationItems";
            this.fld_dgcHREmployeeKPIRegistrationItems.PrintReport = false;
            this.fld_dgcHREmployeeKPIRegistrationItems.Screen = null;
            this.fld_dgcHREmployeeKPIRegistrationItems.Size = new System.Drawing.Size(502, 310);
            this.fld_dgcHREmployeeKPIRegistrationItems.TabIndex = 12;
            this.fld_dgcHREmployeeKPIRegistrationItems.Tag = "DC";
            this.fld_dgcHREmployeeKPIRegistrationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHREmployeeKPIRegistrationItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.BOSComment = null;
            this.fld_btnAddEmployee.BOSDataMember = null;
            this.fld_btnAddEmployee.BOSDataSource = null;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = null;
            this.fld_btnAddEmployee.BOSFieldRelation = null;
            this.fld_btnAddEmployee.BOSPrivilege = null;
            this.fld_btnAddEmployee.BOSPropertyName = null;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(10, 25);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddEmployee, true);
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(99, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = "ShowKPIRegists";
            this.fld_btnAddEmployee.Text = "Chọn nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRKPIRegistrationItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(818, 637);
            this.fld_grcGroupControl3.TabIndex = 9;
            this.fld_grcGroupControl3.Text = "Danh sách KPI";
            // 
            // fld_dgcHRKPIRegistrationItems
            // 
            this.fld_dgcHRKPIRegistrationItems.AllowDrop = true;
            this.fld_dgcHRKPIRegistrationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIRegistrationItems.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.BOSDataSource = "HRKPIRegistrationItems";
            this.fld_dgcHRKPIRegistrationItems.BOSDescription = null;
            this.fld_dgcHRKPIRegistrationItems.BOSError = null;
            this.fld_dgcHRKPIRegistrationItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.BOSGridType = null;
            this.fld_dgcHRKPIRegistrationItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIRegistrationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIRegistrationItems.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRKPIRegistrationItems.MainView = this.gridView1;
            this.fld_dgcHRKPIRegistrationItems.Name = "fld_dgcHRKPIRegistrationItems";
            this.fld_dgcHRKPIRegistrationItems.PrintReport = false;
            this.fld_dgcHRKPIRegistrationItems.Screen = null;
            this.fld_dgcHRKPIRegistrationItems.Size = new System.Drawing.Size(808, 612);
            this.fld_dgcHRKPIRegistrationItems.TabIndex = 12;
            this.fld_dgcHRKPIRegistrationItems.Tag = "DC";
            this.fld_dgcHRKPIRegistrationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHRKPIRegistrationItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMKPIR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMKPIR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIRegistrationEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationTotalAmountBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRKPIRegistrationStatus.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationEndMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationEndMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIRegistrationStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIRegistrationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRKPIFormID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrationItemTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeKPIRegistrationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIRegistrationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSTextBox fld_txtHRKPIRegistrationNo;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSPictureEdit fld_pteHRKPIRegistrationEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtHRKPIRegistrationTotalAmountBonus;
        private BOSComponent.BOSLookupEdit fld_lkeHRKPIRegistrationStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationStartDate;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationFinishedDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIRegistrationName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSButton fld_btnChangeKPIForm;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRKPIFormID;
        private BOSComponent.BOSPanel bosPanel1;
        private SplitContainer splitContainer1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private HREmployeeKPIRegistrationItemsGridControl fld_dgcHREmployeeKPIRegistrationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private HRKPIRegistrationItemsGridControl fld_dgcHRKPIRegistrationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Splitter splitter1;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationMonth;
        private BOSComponent.BOSDateEdit fld_dteHRKPIRegistrationEndMonth;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private HRKPIRegistrationItemTargetsGridControl fld_dgcHRKPIRegistrationItemTargets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}
