using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeeTransmit.UI
{
	/// <summary>
	/// Summary description for DMHET100
	/// </summary>
    partial class DMHET100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSButton fld_btnAddEmployee;
        private HREmployeeTransmitItemsGridControl fld_dgcHREmployeeTransmitItems;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeOTs;
		private BOSComponent.BOSTextBox fld_txtEmployeeTransmitNo1;
		private BOSComponent.BOSTextBox fld_txtEmployeeTransmitName1;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeTransmitFromDate;
		private BOSComponent.BOSMemoEdit fld_medEmployeeTransmitDesc;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel8;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtEmployeeTransmitNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtEmployeeTransmitName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medEmployeeTransmitDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteHREmployeeTransmitToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHREmployeeTransmitDateEnd = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTransmitDateStart = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHREmployeeTransmitFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeTransmitItems = new BOSERP.Modules.EmployeeTransmit.HREmployeeTransmitItemsGridControl();
            this.fld_dgvHREmployeeOTs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRLevelID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtEmployeeTransmitNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtEmployeeTransmitName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medEmployeeTransmitDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTransmitItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl.Controls.Add(this.fld_Lablel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeAPInvoiceInStatus);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtEmployeeTransmitNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtEmployeeTransmitName1);
            this.fld_grcGroupControl.Controls.Add(this.bosDateEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medEmployeeTransmitDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(1, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(501, 135);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.Location = new System.Drawing.Point(268, 57);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 6;
            this.fld_Lablel2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lkeAPInvoiceInStatus
            // 
            this.fld_lkeAPInvoiceInStatus.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInStatus.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInStatus.BOSComment = null;
            this.fld_lkeAPInvoiceInStatus.BOSDataMember = "HREmployeeTransmitStatus";
            this.fld_lkeAPInvoiceInStatus.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeAPInvoiceInStatus.BOSDescription = null;
            this.fld_lkeAPInvoiceInStatus.BOSError = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldGroup = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldParent = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldRelation = null;
            this.fld_lkeAPInvoiceInStatus.BOSPrivilege = null;
            this.fld_lkeAPInvoiceInStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInStatus.BOSSelectType = null;
            this.fld_lkeAPInvoiceInStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPInvoiceInStatus.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInStatus.Location = new System.Drawing.Point(344, 54);
            this.fld_lkeAPInvoiceInStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPInvoiceInStatus.Name = "fld_lkeAPInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInStatus.Properties.ColumnName = null;
            this.fld_lkeAPInvoiceInStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPInvoiceInStatus.Properties.ReadOnly = true;
            this.fld_lkeAPInvoiceInStatus.Screen = null;
            this.fld_lkeAPInvoiceInStatus.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeAPInvoiceInStatus.TabIndex = 7;
            this.fld_lkeAPInvoiceInStatus.Tag = "DC";
            // 
            // fld_txtEmployeeTransmitNo1
            // 
            this.fld_txtEmployeeTransmitNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitNo1.BOSDataMember = "HREmployeeTransmitNo";
            this.fld_txtEmployeeTransmitNo1.BOSDataSource = "HREmployeeTransmits";
            this.fld_txtEmployeeTransmitNo1.BOSDescription = null;
            this.fld_txtEmployeeTransmitNo1.BOSError = null;
            this.fld_txtEmployeeTransmitNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitNo1.BOSPropertyName = "Text";
            this.fld_txtEmployeeTransmitNo1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitNo1.Location = new System.Drawing.Point(95, 28);
            this.fld_txtEmployeeTransmitNo1.Name = "fld_txtEmployeeTransmitNo1";
            this.fld_txtEmployeeTransmitNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtEmployeeTransmitNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtEmployeeTransmitNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtEmployeeTransmitNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtEmployeeTransmitNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtEmployeeTransmitNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtEmployeeTransmitNo1.Screen = null;
            this.fld_txtEmployeeTransmitNo1.Size = new System.Drawing.Size(148, 20);
            this.fld_txtEmployeeTransmitNo1.TabIndex = 1;
            this.fld_txtEmployeeTransmitNo1.Tag = "DC";
            // 
            // fld_txtEmployeeTransmitName1
            // 
            this.fld_txtEmployeeTransmitName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitName1.BOSDataMember = "HREmployeeTransmitName";
            this.fld_txtEmployeeTransmitName1.BOSDataSource = "HREmployeeTransmits";
            this.fld_txtEmployeeTransmitName1.BOSDescription = null;
            this.fld_txtEmployeeTransmitName1.BOSError = null;
            this.fld_txtEmployeeTransmitName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitName1.BOSPropertyName = "Text";
            this.fld_txtEmployeeTransmitName1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtEmployeeTransmitName1.Location = new System.Drawing.Point(344, 28);
            this.fld_txtEmployeeTransmitName1.Name = "fld_txtEmployeeTransmitName1";
            this.fld_txtEmployeeTransmitName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtEmployeeTransmitName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtEmployeeTransmitName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtEmployeeTransmitName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtEmployeeTransmitName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtEmployeeTransmitName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtEmployeeTransmitName1.Screen = null;
            this.fld_txtEmployeeTransmitName1.Size = new System.Drawing.Size(148, 20);
            this.fld_txtEmployeeTransmitName1.TabIndex = 3;
            this.fld_txtEmployeeTransmitName1.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSDataMember = "HREmployeeTransmitDate";
            this.bosDateEdit1.BOSDataSource = "HREmployeeTransmits";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(95, 54);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(148, 20);
            this.bosDateEdit1.TabIndex = 5;
            this.bosDateEdit1.Tag = "DC";
            // 
            // fld_medEmployeeTransmitDesc
            // 
            this.fld_medEmployeeTransmitDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medEmployeeTransmitDesc.BOSDataMember = "HREmployeeTransmitDesc";
            this.fld_medEmployeeTransmitDesc.BOSDataSource = "HREmployeeTransmits";
            this.fld_medEmployeeTransmitDesc.BOSDescription = null;
            this.fld_medEmployeeTransmitDesc.BOSError = null;
            this.fld_medEmployeeTransmitDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medEmployeeTransmitDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medEmployeeTransmitDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medEmployeeTransmitDesc.BOSPropertyName = "Text";
            this.fld_medEmployeeTransmitDesc.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medEmployeeTransmitDesc.Location = new System.Drawing.Point(95, 80);
            this.fld_medEmployeeTransmitDesc.Name = "fld_medEmployeeTransmitDesc";
            this.fld_medEmployeeTransmitDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medEmployeeTransmitDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medEmployeeTransmitDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medEmployeeTransmitDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medEmployeeTransmitDesc.Screen = null;
            this.fld_medEmployeeTransmitDesc.Size = new System.Drawing.Size(397, 44);
            this.fld_medEmployeeTransmitDesc.TabIndex = 9;
            this.fld_medEmployeeTransmitDesc.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 31);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(268, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel5.TabIndex = 2;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Tên chứng từ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Location = new System.Drawing.Point(12, 57);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 83);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 8;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Diễn giải";
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = true;
            this.bosLookupEdit4.BOSComment = null;
            this.bosLookupEdit4.BOSDataMember = "FK_MMWorkShopID";
            this.bosLookupEdit4.BOSDataSource = "HREmployeeTransmits";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = null;
            this.bosLookupEdit4.BOSFieldParent = null;
            this.bosLookupEdit4.BOSFieldRelation = null;
            this.bosLookupEdit4.BOSPrivilege = null;
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = null;
            this.bosLookupEdit4.BOSSelectTypeValue = null;
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(361, 80);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.bosLookupEdit4.Properties.DisplayMember = "MMWorkShopName";
            this.bosLookupEdit4.Properties.ValueMember = "MMWorkShopID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(148, 20);
            this.bosLookupEdit4.TabIndex = 5;
            this.bosLookupEdit4.Tag = "DC";
            this.bosLookupEdit4.Visible = false;
            this.bosLookupEdit4.Validated += new System.EventHandler(this.bosLookupEdit4_Validated);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.Location = new System.Drawing.Point(288, 83);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 2;
            this.bosLabel17.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.Text = "Xưởng";
            this.bosLabel17.Visible = false;
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID1.BOSComment = null;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(108, 28);
            this.fld_lkeFK_BRBranchID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_BRBranchID1, true);
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 0;
            this.fld_lkeFK_BRBranchID1.Tag = "DC";
            this.fld_lkeFK_BRBranchID1.Validated += new System.EventHandler(this.fld_lkeFK_BRBranchID1_Validated);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(8, 31);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(361, 54);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupItemID, true);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_Validated);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(109, 54);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomDesc", "Mô tả")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 2;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID.Validated += new System.EventHandler(this.fld_lkeFFK_HRDepartmentRoomID_Validated);
            this.fld_lkeFK_HRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFFK_HRDepartmentRoomID_QueryPopUp);
            // 
            // fld_dteHREmployeeTransmitToDate
            // 
            this.fld_dteHREmployeeTransmitToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitToDate.BOSDataMember = "HREmployeeTransmitToDate";
            this.fld_dteHREmployeeTransmitToDate.BOSDataSource = "HREmployeeTransmits";
            this.fld_dteHREmployeeTransmitToDate.BOSDescription = null;
            this.fld_dteHREmployeeTransmitToDate.BOSError = null;
            this.fld_dteHREmployeeTransmitToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeTransmitToDate.EditValue = null;
            this.fld_dteHREmployeeTransmitToDate.Location = new System.Drawing.Point(361, 106);
            this.fld_dteHREmployeeTransmitToDate.Name = "fld_dteHREmployeeTransmitToDate";
            this.fld_dteHREmployeeTransmitToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeTransmitToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeTransmitToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeTransmitToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeTransmitToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeTransmitToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeTransmitToDate.Screen = null;
            this.fld_dteHREmployeeTransmitToDate.Size = new System.Drawing.Size(103, 20);
            this.fld_dteHREmployeeTransmitToDate.TabIndex = 8;
            this.fld_dteHREmployeeTransmitToDate.Tag = "DC";
            this.fld_dteHREmployeeTransmitToDate.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_txtEmployeeTransmitDateEnd_Closed);
            this.fld_dteHREmployeeTransmitToDate.Validated += new System.EventHandler(this.fld_dteHREmployeeTransmitToDate_Validated);
            // 
            // fld_txtHREmployeeTransmitDateEnd
            // 
            this.fld_txtHREmployeeTransmitDateEnd.BOSComment = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSDataMember = "HREmployeeTransmitDateEnd";
            this.fld_txtHREmployeeTransmitDateEnd.BOSDataSource = "HREmployeeTransmits";
            this.fld_txtHREmployeeTransmitDateEnd.BOSDescription = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSError = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSFieldGroup = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSFieldRelation = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSPrivilege = null;
            this.fld_txtHREmployeeTransmitDateEnd.BOSPropertyName = "EditValue";
            this.fld_txtHREmployeeTransmitDateEnd.Location = new System.Drawing.Point(470, 106);
            this.fld_txtHREmployeeTransmitDateEnd.Name = "fld_txtHREmployeeTransmitDateEnd";
            this.fld_txtHREmployeeTransmitDateEnd.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeeTransmitDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeTransmitDateEnd.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeeTransmitDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeTransmitDateEnd.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHREmployeeTransmitDateEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHREmployeeTransmitDateEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTransmitDateEnd.Properties.NullText = "00:00";
            this.fld_txtHREmployeeTransmitDateEnd.Screen = null;
            this.fld_txtHREmployeeTransmitDateEnd.Size = new System.Drawing.Size(39, 20);
            this.fld_txtHREmployeeTransmitDateEnd.TabIndex = 9;
            this.fld_txtHREmployeeTransmitDateEnd.Tag = "DC";
            this.fld_txtHREmployeeTransmitDateEnd.Validated += new System.EventHandler(this.fld_txtEmployeeTransmitToDate_Validated);
            // 
            // fld_txtHREmployeeTransmitDateStart
            // 
            this.fld_txtHREmployeeTransmitDateStart.BOSComment = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSDataMember = "HREmployeeTransmitDateStart";
            this.fld_txtHREmployeeTransmitDateStart.BOSDataSource = "HREmployeeTransmits";
            this.fld_txtHREmployeeTransmitDateStart.BOSDescription = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSError = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSFieldGroup = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSFieldRelation = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSPrivilege = null;
            this.fld_txtHREmployeeTransmitDateStart.BOSPropertyName = "EditValue";
            this.fld_txtHREmployeeTransmitDateStart.Location = new System.Drawing.Point(217, 106);
            this.fld_txtHREmployeeTransmitDateStart.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeeTransmitDateStart.Name = "fld_txtHREmployeeTransmitDateStart";
            this.fld_txtHREmployeeTransmitDateStart.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeeTransmitDateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeTransmitDateStart.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeeTransmitDateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeTransmitDateStart.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHREmployeeTransmitDateStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHREmployeeTransmitDateStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeTransmitDateStart.Properties.NullText = "00:00";
            this.fld_txtHREmployeeTransmitDateStart.Screen = null;
            this.fld_txtHREmployeeTransmitDateStart.Size = new System.Drawing.Size(40, 20);
            this.fld_txtHREmployeeTransmitDateStart.TabIndex = 7;
            this.fld_txtHREmployeeTransmitDateStart.Tag = "DC";
            this.fld_txtHREmployeeTransmitDateStart.Validated += new System.EventHandler(this.fld_txtEmployeeTransmitFromDate_Validated);
            // 
            // fld_dteHREmployeeTransmitFromDate
            // 
            this.fld_dteHREmployeeTransmitFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitFromDate.BOSDataMember = "HREmployeeTransmitFromDate";
            this.fld_dteHREmployeeTransmitFromDate.BOSDataSource = "HREmployeeTransmits";
            this.fld_dteHREmployeeTransmitFromDate.BOSDescription = null;
            this.fld_dteHREmployeeTransmitFromDate.BOSError = null;
            this.fld_dteHREmployeeTransmitFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeeTransmitFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeTransmitFromDate.EditValue = null;
            this.fld_dteHREmployeeTransmitFromDate.Location = new System.Drawing.Point(108, 106);
            this.fld_dteHREmployeeTransmitFromDate.Name = "fld_dteHREmployeeTransmitFromDate";
            this.fld_dteHREmployeeTransmitFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeTransmitFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeTransmitFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeTransmitFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeTransmitFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeTransmitFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeTransmitFromDate.Screen = null;
            this.fld_dteHREmployeeTransmitFromDate.Size = new System.Drawing.Size(103, 20);
            this.fld_dteHREmployeeTransmitFromDate.TabIndex = 6;
            this.fld_dteHREmployeeTransmitFromDate.Tag = "DC";
            this.fld_dteHREmployeeTransmitFromDate.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_dteEmployeeTransmitFromDate1_Closed);
            this.fld_dteHREmployeeTransmitFromDate.Validated += new System.EventHandler(this.fld_dteHREmployeeTransmitFromDate_Validated);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Location = new System.Drawing.Point(288, 109);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(288, 57);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(60, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Text = "Tổ tiếp nhận";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(8, 109);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 12;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Từ ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(8, 57);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(39, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Bộ phận";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeTransmitItems);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 144);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(1030, 441);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(4, 409);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(97, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_dgcHREmployeeTransmitItems
            // 
            this.fld_dgcHREmployeeTransmitItems.AllowDrop = true;
            this.fld_dgcHREmployeeTransmitItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeTransmitItems.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeTransmitItems.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeTransmitItems.BOSDataSource = "HREmployeeTransmitItems";
            this.fld_dgcHREmployeeTransmitItems.BOSDescription = null;
            this.fld_dgcHREmployeeTransmitItems.BOSError = null;
            this.fld_dgcHREmployeeTransmitItems.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeTransmitItems.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeTransmitItems.BOSGridType = null;
            this.fld_dgcHREmployeeTransmitItems.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeTransmitItems.BOSPropertyName = "EditValue";
            this.fld_dgcHREmployeeTransmitItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeTransmitItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeTransmitItems.Location = new System.Drawing.Point(1, 22);
            this.fld_dgcHREmployeeTransmitItems.Name = "fld_dgcHREmployeeTransmitItems";
            this.fld_dgcHREmployeeTransmitItems.PrintReport = false;
            this.fld_dgcHREmployeeTransmitItems.Screen = null;
            this.fld_dgcHREmployeeTransmitItems.Size = new System.Drawing.Size(1028, 380);
            this.fld_dgcHREmployeeTransmitItems.TabIndex = 1;
            this.fld_dgcHREmployeeTransmitItems.Tag = "DC";
            this.fld_dgcHREmployeeTransmitItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeOTs});
            // 
            // fld_dgvHREmployeeOTs
            // 
            this.fld_dgvHREmployeeOTs.GridControl = this.fld_dgcHREmployeeTransmitItems;
            this.fld_dgvHREmployeeOTs.Name = "fld_dgvHREmployeeOTs";
            this.fld_dgvHREmployeeOTs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1030, 585);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit4);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_dteHREmployeeTransmitToDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTransmitDateEnd);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRLevelID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeTransmitDateStart);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_dteHREmployeeTransmitFromDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Location = new System.Drawing.Point(508, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(519, 135);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosGroupControl1.Text = "Bộ phận tiếp nhận";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(288, 31);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(51, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(361, 28);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 1;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentID_Validated);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.Location = new System.Drawing.Point(8, 83);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(39, 13);
            this.bosLabel6.TabIndex = 10;
            this.bosLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel6.Text = "Cấp bậc";
            // 
            // fld_lkeFK_HRLevelID
            // 
            this.fld_lkeFK_HRLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_HRLevelID.BOSComment = null;
            this.fld_lkeFK_HRLevelID.BOSDataMember = "FK_HRLevelID";
            this.fld_lkeFK_HRLevelID.BOSDataSource = "HREmployeeTransmits";
            this.fld_lkeFK_HRLevelID.BOSDescription = null;
            this.fld_lkeFK_HRLevelID.BOSError = null;
            this.fld_lkeFK_HRLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_HRLevelID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_HRLevelID.BOSPrivilege = null;
            this.fld_lkeFK_HRLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRLevelID.BOSSelectType = null;
            this.fld_lkeFK_HRLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_HRLevelID.Location = new System.Drawing.Point(109, 80);
            this.fld_lkeFK_HRLevelID.Name = "fld_lkeFK_HRLevelID";
            this.fld_lkeFK_HRLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_HRLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRLevelNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRLevelName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRLevelDesc", "Mô tả")});
            this.fld_lkeFK_HRLevelID.Properties.DisplayMember = "HRLevelName";
            this.fld_lkeFK_HRLevelID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRLevelID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRLevelID.Properties.ValueMember = "HRLevelID";
            this.fld_lkeFK_HRLevelID.Screen = null;
            this.fld_lkeFK_HRLevelID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_HRLevelID.TabIndex = 4;
            this.fld_lkeFK_HRLevelID.Tag = "DC";
            this.fld_lkeFK_HRLevelID.Validated += new System.EventHandler(this.fld_lkeFK_HRLevelID_Validated);
            // 
            // DMHET100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1030, 585);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHET100";
            this.Text = "Thông tin thuyên chuyển";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtEmployeeTransmitNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtEmployeeTransmitName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medEmployeeTransmitDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTransmitDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeTransmitFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTransmitItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTransmitDateStart;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTransmitDateEnd;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeTransmitToDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRLevelID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
	}
}
