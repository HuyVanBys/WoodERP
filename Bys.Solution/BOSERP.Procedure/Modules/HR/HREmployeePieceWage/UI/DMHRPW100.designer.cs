using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREmployeePieceWage.UI
{
	/// <summary>
	/// Summary description for DMHRPW100
	/// </summary>
	partial class DMHRPW100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSButton fld_btnAddEmployee;
        private HREmployeePieceWageItemsGridControl fld_dgcHREmployeePieceWageItems;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePieceWageItems;
		private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageNo1;
		private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageName1;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePieceWageFromDate1;
		private BOSComponent.BOSMemoEdit fld_medHREmployeePieceWageDesc;
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
            this.fld_lkeAPPurchaseOrderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRProductPieceWageID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeePieceWageFromDate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWagePlanProductTotalQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageProductUnitPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageRealProductTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageRealProductTotalQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWageName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeePieceWageFromDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHREmployeePieceWageDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeePieceWageItems = new BOSERP.Modules.HREmployeePieceWage.HREmployeePieceWageItemsGridControl();
            this.fld_dgvHREmployeePieceWageItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProductPieceWageID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageProductUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWageFromDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWageFromDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePieceWageDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePieceWageItems)).BeginInit();
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
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeAPPurchaseOrderStatus);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRProductPieceWageID);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageFromDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWagePlanProductTotalQty);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageProductUnitPrice);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageRealProductTotalAmount);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageRealProductTotalQty);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeePieceWageName1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeePieceWageFromDate1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHREmployeePieceWageDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(858, 158);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeAPPurchaseOrderStatus
            // 
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseOrderStatus.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSDataMember = "HREmployeePieceWageStatus";
            this.fld_lkeAPPurchaseOrderStatus.BOSDataSource = "HREmployeePieceWages";
            this.fld_lkeAPPurchaseOrderStatus.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSError = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.CurrentDisplayText = null;
            this.fld_lkeAPPurchaseOrderStatus.Location = new System.Drawing.Point(674, 106);
            this.fld_lkeAPPurchaseOrderStatus.Name = "fld_lkeAPPurchaseOrderStatus";
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderStatus.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.Properties.ReadOnly = true;
            this.fld_lkeAPPurchaseOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderStatus.Screen = null;
            this.fld_lkeAPPurchaseOrderStatus.Size = new System.Drawing.Size(163, 20);
            this.fld_lkeAPPurchaseOrderStatus.TabIndex = 20;
            this.fld_lkeAPPurchaseOrderStatus.Tag = "DC";
            // 
            // fld_lkeFK_HRProductPieceWageID
            // 
            this.fld_lkeFK_HRProductPieceWageID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRProductPieceWageID.BOSAllowDummy = true;
            this.fld_lkeFK_HRProductPieceWageID.BOSComment = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSDataMember = "FK_HRProductPieceWageID";
            this.fld_lkeFK_HRProductPieceWageID.BOSDataSource = "HREmployeePieceWages";
            this.fld_lkeFK_HRProductPieceWageID.BOSDescription = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSError = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSFieldGroup = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProductPieceWageID.BOSFieldRelation = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSPrivilege = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRProductPieceWageID.BOSSelectType = null;
            this.fld_lkeFK_HRProductPieceWageID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRProductPieceWageID.CurrentDisplayText = null;
            this.fld_lkeFK_HRProductPieceWageID.Location = new System.Drawing.Point(84, 80);
            this.fld_lkeFK_HRProductPieceWageID.Name = "fld_lkeFK_HRProductPieceWageID";
            this.fld_lkeFK_HRProductPieceWageID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRProductPieceWageID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRProductPieceWageID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRProductPieceWageID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRProductPieceWageID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRProductPieceWageID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRProductPieceWageNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRProductPieceWageName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRProductPieceWageProductUnitPrice", "Đơn giá"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRProductPieceWageDesc", "Diễn giải")});
            this.fld_lkeFK_HRProductPieceWageID.Properties.DisplayMember = "HRProductPieceWageName";
            this.fld_lkeFK_HRProductPieceWageID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_HRProductPieceWageID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRProductPieceWageID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRProductPieceWageID.Properties.ValueMember = "HRProductPieceWageID";
            this.fld_lkeFK_HRProductPieceWageID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRProductPieceWageID, true);
            this.fld_lkeFK_HRProductPieceWageID.Size = new System.Drawing.Size(163, 20);
            this.fld_lkeFK_HRProductPieceWageID.TabIndex = 13;
            this.fld_lkeFK_HRProductPieceWageID.Tag = "DC";
            this.fld_lkeFK_HRProductPieceWageID.Validated += new System.EventHandler(this.fld_lkeFK_HRProductPieceWageID_Validated);
            // 
            // fld_txtHREmployeePieceWageFromDate
            // 
            this.fld_txtHREmployeePieceWageFromDate.BOSComment = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSDataMember = "HREmployeePieceWageFromDate";
            this.fld_txtHREmployeePieceWageFromDate.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageFromDate.BOSDescription = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSError = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSFieldGroup = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSFieldRelation = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSPrivilege = null;
            this.fld_txtHREmployeePieceWageFromDate.BOSPropertyName = "EditValue";
            this.fld_txtHREmployeePieceWageFromDate.Location = new System.Drawing.Point(395, 54);
            this.fld_txtHREmployeePieceWageFromDate.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeePieceWageFromDate.Name = "fld_txtHREmployeePieceWageFromDate";
            this.fld_txtHREmployeePieceWageFromDate.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeePieceWageFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeePieceWageFromDate.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHREmployeePieceWageFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeePieceWageFromDate.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHREmployeePieceWageFromDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHREmployeePieceWageFromDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageFromDate.Properties.NullText = "00:00";
            this.fld_txtHREmployeePieceWageFromDate.Screen = null;
            this.fld_txtHREmployeePieceWageFromDate.Size = new System.Drawing.Size(55, 20);
            this.fld_txtHREmployeePieceWageFromDate.TabIndex = 9;
            this.fld_txtHREmployeePieceWageFromDate.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWagePlanProductTotalQty
            // 
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSDataMember = "HREmployeePieceWagePlanProductTotalQty";
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSDescription = null;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSError = null;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Location = new System.Drawing.Point(674, 28);
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Name = "fld_txtHREmployeePieceWagePlanProductTotalQty";
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Screen = null;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.TabIndex = 5;
            this.fld_txtHREmployeePieceWagePlanProductTotalQty.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWageNo1
            // 
            this.fld_txtHREmployeePieceWageNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo1.BOSDataMember = "HREmployeePieceWageNo";
            this.fld_txtHREmployeePieceWageNo1.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageNo1.BOSDescription = null;
            this.fld_txtHREmployeePieceWageNo1.BOSError = null;
            this.fld_txtHREmployeePieceWageNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageNo1.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageNo1.Location = new System.Drawing.Point(84, 28);
            this.fld_txtHREmployeePieceWageNo1.Name = "fld_txtHREmployeePieceWageNo1";
            this.fld_txtHREmployeePieceWageNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageNo1.Screen = null;
            this.fld_txtHREmployeePieceWageNo1.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWageNo1.TabIndex = 1;
            this.fld_txtHREmployeePieceWageNo1.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWageProductUnitPrice
            // 
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSDataMember = "HREmployeePieceWageProductUnitPrice";
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSDescription = null;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSError = null;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageProductUnitPrice.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageProductUnitPrice.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Location = new System.Drawing.Point(395, 80);
            this.fld_txtHREmployeePieceWageProductUnitPrice.Name = "fld_txtHREmployeePieceWageProductUnitPrice";
            this.fld_txtHREmployeePieceWageProductUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageProductUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageProductUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageProductUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Screen = null;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWageProductUnitPrice.TabIndex = 15;
            this.fld_txtHREmployeePieceWageProductUnitPrice.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWageRealProductTotalAmount
            // 
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSDataMember = "HREmployeePieceWageRealProductTotalAmount";
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSDescription = null;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSError = null;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Location = new System.Drawing.Point(674, 80);
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Name = "fld_txtHREmployeePieceWageRealProductTotalAmount";
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Screen = null;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.TabIndex = 17;
            this.fld_txtHREmployeePieceWageRealProductTotalAmount.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWageRealProductTotalQty
            // 
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSDataMember = "HREmployeePieceWageRealProductTotalQty";
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSDescription = null;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSError = null;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageRealProductTotalQty.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Location = new System.Drawing.Point(674, 54);
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Name = "fld_txtHREmployeePieceWageRealProductTotalQty";
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Screen = null;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWageRealProductTotalQty.TabIndex = 11;
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Tag = "DC";
            this.fld_txtHREmployeePieceWageRealProductTotalQty.Validated += new System.EventHandler(this.fld_txtHREmployeePieceWageRealProductTotalQty_Validated);
            // 
            // fld_txtHREmployeePieceWageName1
            // 
            this.fld_txtHREmployeePieceWageName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName1.BOSDataMember = "HREmployeePieceWageName";
            this.fld_txtHREmployeePieceWageName1.BOSDataSource = "HREmployeePieceWages";
            this.fld_txtHREmployeePieceWageName1.BOSDescription = null;
            this.fld_txtHREmployeePieceWageName1.BOSError = null;
            this.fld_txtHREmployeePieceWageName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeePieceWageName1.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWageName1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHREmployeePieceWageName1.Location = new System.Drawing.Point(395, 28);
            this.fld_txtHREmployeePieceWageName1.Name = "fld_txtHREmployeePieceWageName1";
            this.fld_txtHREmployeePieceWageName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWageName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWageName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWageName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWageName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWageName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWageName1.Screen = null;
            this.fld_txtHREmployeePieceWageName1.Size = new System.Drawing.Size(163, 20);
            this.fld_txtHREmployeePieceWageName1.TabIndex = 3;
            this.fld_txtHREmployeePieceWageName1.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 83);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Text = "Công việc";
            // 
            // fld_dteHREmployeePieceWageFromDate1
            // 
            this.fld_dteHREmployeePieceWageFromDate1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeePieceWageFromDate1.BOSDataMember = "HREmployeePieceWageDate";
            this.fld_dteHREmployeePieceWageFromDate1.BOSDataSource = "HREmployeePieceWages";
            this.fld_dteHREmployeePieceWageFromDate1.BOSDescription = null;
            this.fld_dteHREmployeePieceWageFromDate1.BOSError = null;
            this.fld_dteHREmployeePieceWageFromDate1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeePieceWageFromDate1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeePieceWageFromDate1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHREmployeePieceWageFromDate1.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePieceWageFromDate1.EditValue = null;
            this.fld_dteHREmployeePieceWageFromDate1.Location = new System.Drawing.Point(84, 54);
            this.fld_dteHREmployeePieceWageFromDate1.Name = "fld_dteHREmployeePieceWageFromDate1";
            this.fld_dteHREmployeePieceWageFromDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePieceWageFromDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePieceWageFromDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePieceWageFromDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePieceWageFromDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePieceWageFromDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePieceWageFromDate1.Screen = null;
            this.fld_dteHREmployeePieceWageFromDate1.Size = new System.Drawing.Size(163, 20);
            this.fld_dteHREmployeePieceWageFromDate1.TabIndex = 7;
            this.fld_dteHREmployeePieceWageFromDate1.Tag = "DC";
            this.fld_dteHREmployeePieceWageFromDate1.Validated += new System.EventHandler(this.fld_dteHREmployeePieceWageFromDate1_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(596, 31);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(57, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "SL kế hoạch";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.Location = new System.Drawing.Point(288, 83);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(37, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.Text = "Đơn giá";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.Location = new System.Drawing.Point(596, 106);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(49, 13);
            this.bosLabel7.TabIndex = 16;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.Text = "Tình trạng";
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
            this.bosLabel6.Location = new System.Drawing.Point(596, 83);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(51, 13);
            this.bosLabel6.TabIndex = 16;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Thành tiền";
            // 
            // fld_medHREmployeePieceWageDesc
            // 
            this.fld_medHREmployeePieceWageDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHREmployeePieceWageDesc.BOSDataMember = "HREmployeePieceWageDesc";
            this.fld_medHREmployeePieceWageDesc.BOSDataSource = "HREmployeePieceWages";
            this.fld_medHREmployeePieceWageDesc.BOSDescription = null;
            this.fld_medHREmployeePieceWageDesc.BOSError = null;
            this.fld_medHREmployeePieceWageDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHREmployeePieceWageDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHREmployeePieceWageDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHREmployeePieceWageDesc.BOSPropertyName = "Text";
            this.fld_medHREmployeePieceWageDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medHREmployeePieceWageDesc.Location = new System.Drawing.Point(84, 106);
            this.fld_medHREmployeePieceWageDesc.Name = "fld_medHREmployeePieceWageDesc";
            this.fld_medHREmployeePieceWageDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREmployeePieceWageDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREmployeePieceWageDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREmployeePieceWageDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREmployeePieceWageDesc.Screen = null;
            this.fld_medHREmployeePieceWageDesc.Size = new System.Drawing.Size(474, 41);
            this.fld_medHREmployeePieceWageDesc.TabIndex = 19;
            this.fld_medHREmployeePieceWageDesc.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(596, 57);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(49, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "SL thực tế";
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
            this.fld_lblLabel4.TabIndex = 0;
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
            this.fld_lblLabel5.TabIndex = 2;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Tên danh sách";
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
            this.bosLabel1.Location = new System.Drawing.Point(288, 57);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(92, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Giờ tính công tối đa";
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
            this.fld_lblLabel6.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Ngày";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 109);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 18;
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeePieceWageItems);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 164);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(858, 430);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Text = "Danh sách nhân viên";
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
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(4, 398);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(97, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_dgcHREmployeePieceWageItems
            // 
            this.fld_dgcHREmployeePieceWageItems.AllowDrop = true;
            this.fld_dgcHREmployeePieceWageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePieceWageItems.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.BOSDataSource = "HREmployeePieceWageItems";
            this.fld_dgcHREmployeePieceWageItems.BOSDescription = null;
            this.fld_dgcHREmployeePieceWageItems.BOSError = null;
            this.fld_dgcHREmployeePieceWageItems.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.BOSGridType = null;
            this.fld_dgcHREmployeePieceWageItems.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployeePieceWageItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePieceWageItems.Location = new System.Drawing.Point(1, 22);
            this.fld_dgcHREmployeePieceWageItems.MainView = this.fld_dgvHREmployeePieceWageItems;
            this.fld_dgcHREmployeePieceWageItems.Name = "fld_dgcHREmployeePieceWageItems";
            this.fld_dgcHREmployeePieceWageItems.PrintReport = false;
            this.fld_dgcHREmployeePieceWageItems.Screen = null;
            this.fld_dgcHREmployeePieceWageItems.Size = new System.Drawing.Size(856, 369);
            this.fld_dgcHREmployeePieceWageItems.TabIndex = 0;
            this.fld_dgcHREmployeePieceWageItems.Tag = "DC";
            this.fld_dgcHREmployeePieceWageItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeePieceWageItems});
            // 
            // fld_dgvHREmployeePieceWageItems
            // 
            this.fld_dgvHREmployeePieceWageItems.GridControl = this.fld_dgcHREmployeePieceWageItems;
            this.fld_dgvHREmployeePieceWageItems.Name = "fld_dgvHREmployeePieceWageItems";
            this.fld_dgvHREmployeePieceWageItems.PaintStyleName = "Office2003";
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
            this.bosPanel1.Size = new System.Drawing.Size(858, 594);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHRPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(858, 594);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRPW100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProductPieceWageID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWagePlanProductTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageProductUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageRealProductTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageRealProductTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWageName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWageFromDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWageFromDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePieceWageDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePieceWageItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageFromDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWagePlanProductTotalQty;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageProductUnitPrice;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageRealProductTotalQty;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWageRealProductTotalAmount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRProductPieceWageID;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderStatus;
        private BOSComponent.BOSLabel bosLabel7;
	}
}
