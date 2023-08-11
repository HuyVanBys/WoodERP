using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HROverTime.UI
{
	/// <summary>
	/// Summary description for DMHROT100
	/// </summary>
	partial class DMHROT100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSButton fld_btnAddEmployee;
        private HREmployeeOTsGridControl fld_dgcHREmployeeOTs;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeOTs;
		private BOSComponent.BOSTextBox fld_txtHROverTimeNo1;
		private BOSComponent.BOSTextBox fld_txtHROverTimeName1;
        private BOSComponent.BOSDateEdit fld_dteHROverTimeFromDate1;
		private BOSComponent.BOSMemoEdit fld_medHROverTimeDesc;
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
            this.fld_lkeHROverTimeStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHROverTimeDateEnd = new BOSComponent.BOSDateEdit(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtHROverTimeToDate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHROverTimeFromDate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHROverTimeFactor = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHROverTimeNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHROverTimeName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHROverTimeFromDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHROverTimeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddEmployeeByListCard = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeOTs = new BOSERP.Modules.HROverTime.HREmployeeOTsGridControl();
            this.fld_dgvHREmployeeOTs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHROverTimeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeDateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHROverTimeFromDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHROverTimeFromDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHROverTimeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeOTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHROverTimeStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeDateEnd);
            this.fld_grcGroupControl.Controls.Add(this.bosCheckEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeToDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeFromDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeFactor);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHROverTimeName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHROverTimeFromDate1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHROverTimeDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(899, 131);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeHROverTimeStatus
            // 
            this.fld_lkeHROverTimeStatus.BOSAllowAddNew = false;
            this.fld_lkeHROverTimeStatus.BOSAllowDummy = true;
            this.fld_lkeHROverTimeStatus.BOSComment = null;
            this.fld_lkeHROverTimeStatus.BOSDataMember = "HROverTimeStatus";
            this.fld_lkeHROverTimeStatus.BOSDataSource = "HROverTimes";
            this.fld_lkeHROverTimeStatus.BOSDescription = null;
            this.fld_lkeHROverTimeStatus.BOSError = null;
            this.fld_lkeHROverTimeStatus.BOSFieldGroup = null;
            this.fld_lkeHROverTimeStatus.BOSFieldParent = null;
            this.fld_lkeHROverTimeStatus.BOSFieldRelation = null;
            this.fld_lkeHROverTimeStatus.BOSPrivilege = null;
            this.fld_lkeHROverTimeStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHROverTimeStatus.BOSSelectType = null;
            this.fld_lkeHROverTimeStatus.BOSSelectTypeValue = null;
            this.fld_lkeHROverTimeStatus.CurrentDisplayText = null;
            this.fld_lkeHROverTimeStatus.Location = new System.Drawing.Point(88, 106);
            this.fld_lkeHROverTimeStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHROverTimeStatus.Name = "fld_lkeHROverTimeStatus";
            this.fld_lkeHROverTimeStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHROverTimeStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHROverTimeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHROverTimeStatus.Properties.ColumnName = null;
            this.fld_lkeHROverTimeStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHROverTimeStatus.Properties.ReadOnly = true;
            this.fld_lkeHROverTimeStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHROverTimeStatus.Screen = null;
            this.fld_lkeHROverTimeStatus.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeHROverTimeStatus.TabIndex = 111;
            this.fld_lkeHROverTimeStatus.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 109);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 112;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_txtHROverTimeDateEnd
            // 
            this.fld_txtHROverTimeDateEnd.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeDateEnd.BOSDataMember = "HROverTimeDateEnd";
            this.fld_txtHROverTimeDateEnd.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeDateEnd.BOSDescription = null;
            this.fld_txtHROverTimeDateEnd.BOSError = null;
            this.fld_txtHROverTimeDateEnd.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeDateEnd.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeDateEnd.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeDateEnd.BOSPropertyName = "EditValue";
            this.fld_txtHROverTimeDateEnd.EditValue = null;
            this.fld_txtHROverTimeDateEnd.Location = new System.Drawing.Point(364, 53);
            this.fld_txtHROverTimeDateEnd.Name = "fld_txtHROverTimeDateEnd";
            this.fld_txtHROverTimeDateEnd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeDateEnd.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeDateEnd.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeDateEnd.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_txtHROverTimeDateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_txtHROverTimeDateEnd.Screen = null;
            this.fld_txtHROverTimeDateEnd.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHROverTimeDateEnd.TabIndex = 4;
            this.fld_txtHROverTimeDateEnd.Tag = "DC";
            this.fld_txtHROverTimeDateEnd.Validated += new System.EventHandler(this.fld_txtHROverTimeDateEnd_Validated);
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = "HROverTimeHaveMeal";
            this.bosCheckEdit1.BOSDataSource = "HROverTimes";
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = "EditValue";
            this.bosCheckEdit1.Location = new System.Drawing.Point(568, 53);
            this.bosCheckEdit1.MenuManager = this.screenToolbar;
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Có cơm";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(61, 19);
            this.bosCheckEdit1.TabIndex = 6;
            this.bosCheckEdit1.Tag = "DC";
            this.bosCheckEdit1.Visible = false;
            // 
            // fld_txtHROverTimeToDate
            // 
            this.fld_txtHROverTimeToDate.BOSComment = null;
            this.fld_txtHROverTimeToDate.BOSDataMember = "HROverTimeToDate";
            this.fld_txtHROverTimeToDate.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeToDate.BOSDescription = null;
            this.fld_txtHROverTimeToDate.BOSError = null;
            this.fld_txtHROverTimeToDate.BOSFieldGroup = null;
            this.fld_txtHROverTimeToDate.BOSFieldRelation = null;
            this.fld_txtHROverTimeToDate.BOSPrivilege = null;
            this.fld_txtHROverTimeToDate.BOSPropertyName = "EditValue";
            this.fld_txtHROverTimeToDate.Location = new System.Drawing.Point(495, 53);
            this.fld_txtHROverTimeToDate.Name = "fld_txtHROverTimeToDate";
            this.fld_txtHROverTimeToDate.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHROverTimeToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHROverTimeToDate.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHROverTimeToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHROverTimeToDate.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHROverTimeToDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHROverTimeToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeToDate.Properties.NullText = "00:00";
            this.fld_txtHROverTimeToDate.Screen = null;
            this.fld_txtHROverTimeToDate.Size = new System.Drawing.Size(45, 20);
            this.fld_txtHROverTimeToDate.TabIndex = 5;
            this.fld_txtHROverTimeToDate.Tag = "DC";
            this.fld_txtHROverTimeToDate.Validated += new System.EventHandler(this.fld_txtHROverTimeToDate_Validated);
            // 
            // fld_txtHROverTimeFromDate
            // 
            this.fld_txtHROverTimeFromDate.BOSComment = null;
            this.fld_txtHROverTimeFromDate.BOSDataMember = "HROverTimeFromDate";
            this.fld_txtHROverTimeFromDate.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeFromDate.BOSDescription = null;
            this.fld_txtHROverTimeFromDate.BOSError = null;
            this.fld_txtHROverTimeFromDate.BOSFieldGroup = null;
            this.fld_txtHROverTimeFromDate.BOSFieldRelation = null;
            this.fld_txtHROverTimeFromDate.BOSPrivilege = null;
            this.fld_txtHROverTimeFromDate.BOSPropertyName = "EditValue";
            this.fld_txtHROverTimeFromDate.Location = new System.Drawing.Point(219, 54);
            this.fld_txtHROverTimeFromDate.MenuManager = this.screenToolbar;
            this.fld_txtHROverTimeFromDate.Name = "fld_txtHROverTimeFromDate";
            this.fld_txtHROverTimeFromDate.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHROverTimeFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHROverTimeFromDate.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHROverTimeFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHROverTimeFromDate.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHROverTimeFromDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHROverTimeFromDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeFromDate.Properties.NullText = "00:00";
            this.fld_txtHROverTimeFromDate.Screen = null;
            this.fld_txtHROverTimeFromDate.Size = new System.Drawing.Size(55, 20);
            this.fld_txtHROverTimeFromDate.TabIndex = 3;
            this.fld_txtHROverTimeFromDate.Tag = "DC";
            this.fld_txtHROverTimeFromDate.Validated += new System.EventHandler(this.fld_txtHROverTimeFromDate_Validated);
            // 
            // fld_txtHROverTimeFactor
            // 
            this.fld_txtHROverTimeFactor.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHROverTimeFactor.BOSDataMember = "HROverTimeFactor";
            this.fld_txtHROverTimeFactor.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeFactor.BOSDescription = null;
            this.fld_txtHROverTimeFactor.BOSError = null;
            this.fld_txtHROverTimeFactor.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHROverTimeFactor.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHROverTimeFactor.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHROverTimeFactor.BOSPropertyName = "Text";
            this.fld_txtHROverTimeFactor.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHROverTimeFactor.Location = new System.Drawing.Point(88, 80);
            this.fld_txtHROverTimeFactor.Name = "fld_txtHROverTimeFactor";
            this.fld_txtHROverTimeFactor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeFactor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeFactor.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeFactor.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeFactor.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtHROverTimeFactor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtHROverTimeFactor.Properties.EditFormat.FormatString = "n2";
            this.fld_txtHROverTimeFactor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtHROverTimeFactor.Properties.Mask.EditMask = "n2";
            this.fld_txtHROverTimeFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHROverTimeFactor.Properties.Mask.PlaceHolder = '0';
            this.fld_txtHROverTimeFactor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeFactor.Properties.MaxLength = 2;
            this.fld_txtHROverTimeFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHROverTimeFactor.Screen = null;
            this.fld_txtHROverTimeFactor.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHROverTimeFactor.TabIndex = 7;
            this.fld_txtHROverTimeFactor.Tag = "DC";
            this.fld_txtHROverTimeFactor.Validated += new System.EventHandler(this.fld_txtHROverTimeFactor_Validated);
            // 
            // fld_txtHROverTimeNo1
            // 
            this.fld_txtHROverTimeNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo1.BOSDataMember = "HROverTimeNo";
            this.fld_txtHROverTimeNo1.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeNo1.BOSDescription = null;
            this.fld_txtHROverTimeNo1.BOSError = null;
            this.fld_txtHROverTimeNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo1.BOSPropertyName = "Text";
            this.fld_txtHROverTimeNo1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeNo1.Location = new System.Drawing.Point(88, 28);
            this.fld_txtHROverTimeNo1.Name = "fld_txtHROverTimeNo1";
            this.fld_txtHROverTimeNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHROverTimeNo1.Screen = null;
            this.fld_txtHROverTimeNo1.Size = new System.Drawing.Size(186, 20);
            this.fld_txtHROverTimeNo1.TabIndex = 0;
            this.fld_txtHROverTimeNo1.Tag = "DC";
            // 
            // fld_txtHROverTimeName1
            // 
            this.fld_txtHROverTimeName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName1.BOSDataMember = "HROverTimeName";
            this.fld_txtHROverTimeName1.BOSDataSource = "HROverTimes";
            this.fld_txtHROverTimeName1.BOSDescription = null;
            this.fld_txtHROverTimeName1.BOSError = null;
            this.fld_txtHROverTimeName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName1.BOSPropertyName = "Text";
            this.fld_txtHROverTimeName1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHROverTimeName1.Location = new System.Drawing.Point(364, 28);
            this.fld_txtHROverTimeName1.Name = "fld_txtHROverTimeName1";
            this.fld_txtHROverTimeName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHROverTimeName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHROverTimeName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHROverTimeName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHROverTimeName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHROverTimeName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHROverTimeName1.Screen = null;
            this.fld_txtHROverTimeName1.Size = new System.Drawing.Size(265, 20);
            this.fld_txtHROverTimeName1.TabIndex = 1;
            this.fld_txtHROverTimeName1.Tag = "DC";
            // 
            // fld_dteHROverTimeFromDate1
            // 
            this.fld_dteHROverTimeFromDate1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHROverTimeFromDate1.BOSDataMember = "HROverTimeDate";
            this.fld_dteHROverTimeFromDate1.BOSDataSource = "HROverTimes";
            this.fld_dteHROverTimeFromDate1.BOSDescription = null;
            this.fld_dteHROverTimeFromDate1.BOSError = null;
            this.fld_dteHROverTimeFromDate1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHROverTimeFromDate1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHROverTimeFromDate1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHROverTimeFromDate1.BOSPropertyName = "EditValue";
            this.fld_dteHROverTimeFromDate1.EditValue = null;
            this.fld_dteHROverTimeFromDate1.Location = new System.Drawing.Point(88, 54);
            this.fld_dteHROverTimeFromDate1.Name = "fld_dteHROverTimeFromDate1";
            this.fld_dteHROverTimeFromDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHROverTimeFromDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHROverTimeFromDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHROverTimeFromDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHROverTimeFromDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHROverTimeFromDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHROverTimeFromDate1.Screen = null;
            this.fld_dteHROverTimeFromDate1.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHROverTimeFromDate1.TabIndex = 2;
            this.fld_dteHROverTimeFromDate1.Tag = "DC";
            this.fld_dteHROverTimeFromDate1.Validated += new System.EventHandler(this.fld_dteHROverTimeFromDate1_Validated);
            // 
            // fld_medHROverTimeDesc
            // 
            this.fld_medHROverTimeDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHROverTimeDesc.BOSDataMember = "HROverTimeDesc";
            this.fld_medHROverTimeDesc.BOSDataSource = "HROverTimes";
            this.fld_medHROverTimeDesc.BOSDescription = null;
            this.fld_medHROverTimeDesc.BOSError = null;
            this.fld_medHROverTimeDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHROverTimeDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHROverTimeDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHROverTimeDesc.BOSPropertyName = "Text";
            this.fld_medHROverTimeDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHROverTimeDesc.Location = new System.Drawing.Point(364, 80);
            this.fld_medHROverTimeDesc.Name = "fld_medHROverTimeDesc";
            this.fld_medHROverTimeDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHROverTimeDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHROverTimeDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHROverTimeDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHROverTimeDesc.Screen = null;
            this.fld_medHROverTimeDesc.Size = new System.Drawing.Size(265, 41);
            this.fld_medHROverTimeDesc.TabIndex = 8;
            this.fld_medHROverTimeDesc.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(288, 57);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Đến ngày";
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
            this.fld_lblLabel4.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel4.TabIndex = 13;
            this.fld_lblLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Text = "Mã danh sách";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(288, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel5.TabIndex = 14;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Tên danh sách";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 57);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 15;
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 83);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(70, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Hệ số giờ công";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(288, 83);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 17;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Diễn giải";
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployeeByListCard);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeOTs);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 137);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(899, 457);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_btnAddEmployeeByListCard
            // 
            this.fld_btnAddEmployeeByListCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployeeByListCard.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployeeByListCard.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployeeByListCard.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSDescription = null;
            this.fld_btnAddEmployeeByListCard.BOSError = null;
            this.fld_btnAddEmployeeByListCard.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.Location = new System.Drawing.Point(112, 424);
            this.fld_btnAddEmployeeByListCard.Name = "fld_btnAddEmployeeByListCard";
            this.fld_btnAddEmployeeByListCard.Screen = null;
            this.fld_btnAddEmployeeByListCard.Size = new System.Drawing.Size(180, 27);
            this.fld_btnAddEmployeeByListCard.TabIndex = 2;
            this.fld_btnAddEmployeeByListCard.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployeeByListCard.Text = "Thêm NV theo DS Mã nhân viên";
            this.fld_btnAddEmployeeByListCard.Click += new System.EventHandler(this.fld_btnAddEmployeeByListCard_Click);
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
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(4, 425);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(97, 27);
            this.fld_btnAddEmployee.TabIndex = 1;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_dgcHREmployeeOTs
            // 
            this.fld_dgcHREmployeeOTs.AllowDrop = true;
            this.fld_dgcHREmployeeOTs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeOTs.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.BOSDataSource = "HREmployeeOTs";
            this.fld_dgcHREmployeeOTs.BOSDescription = null;
            this.fld_dgcHREmployeeOTs.BOSError = null;
            this.fld_dgcHREmployeeOTs.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.BOSGridType = null;
            this.fld_dgcHREmployeeOTs.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeeOTs.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeOTs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeOTs.Location = new System.Drawing.Point(1, 22);
            this.fld_dgcHREmployeeOTs.MainView = this.fld_dgvHREmployeeOTs;
            this.fld_dgcHREmployeeOTs.Name = "fld_dgcHREmployeeOTs";
            this.fld_dgcHREmployeeOTs.PrintReport = false;
            this.fld_dgcHREmployeeOTs.Screen = null;
            this.fld_dgcHREmployeeOTs.Size = new System.Drawing.Size(897, 396);
            this.fld_dgcHREmployeeOTs.TabIndex = 0;
            this.fld_dgcHREmployeeOTs.Tag = "DC";
            this.fld_dgcHREmployeeOTs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeOTs});
            // 
            // fld_dgvHREmployeeOTs
            // 
            this.fld_dgvHREmployeeOTs.GridControl = this.fld_dgcHREmployeeOTs;
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(899, 594);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHROT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(899, 594);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHROT100";
            this.Text = "Thông tin tăng ca";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHROverTimeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeDateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHROverTimeName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHROverTimeFromDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHROverTimeFromDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHROverTimeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeOTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtHROverTimeFromDate;
        private BOSComponent.BOSTextBox fld_txtHROverTimeToDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
        private BOSComponent.BOSDateEdit fld_txtHROverTimeDateEnd;
        private BOSComponent.BOSButton fld_btnAddEmployeeByListCard;
        private BOSComponent.BOSTextBox fld_txtHROverTimeFactor;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHROverTimeStatus;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
