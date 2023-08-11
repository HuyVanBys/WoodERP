using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CancelPurchaseOrder.UI
{
	/// <summary>
	/// Summary description for DMCPO100
	/// </summary>
	partial class DMCPO100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCPO100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medAPCancelPurchaseOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medAPCancelPurchaseOrderComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeAPCancelPurchaseOrderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPCancelPurchaseOrderItems = new BOSERP.Modules.CancelPurchaseOrder.APCancelPurchaseOrderItemsGridControl();
            this.fld_dgvARCancelVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteAPCancelPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPCancelPurchaseOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseOrderDesc.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseOrderComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment);
            this.bosPanel1.Controls.Add(this.fld_medAPCancelPurchaseOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lkeAPCancelPurchaseOrderStatus);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_txtAPPurchaseOrderNo);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteAPPurchaseOrderDate);
            this.bosPanel1.Controls.Add(this.fld_dteAPCancelPurchaseOrderDate);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_txtAPCancelPurchaseOrderNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel19, "bosLabel19");
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Tag = "";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Tag = "";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            resources.ApplyResources(this.fld_lkeACObjectAccessKey, "fld_lkeACObjectAccessKey");
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Buttons"))))});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns"), resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns3"))), resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns4"), ((bool)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns9"), resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns10"))});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = resources.GetString("fld_lkeACObjectAccessKey.Properties.NullText");
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            this.fld_lkeACObjectAccessKey.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACObjectAccessKey_CloseUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            this.bosLabel4.Tag = "";
            // 
            // fld_lkeAPCancelPurchaseOrderCancelFromDepartment
            // 
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSAllowAddNew = false;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSAllowDummy = false;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSComment = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSDataMember = "APCancelPurchaseOrderCancelFromDepartment";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSDescription = null;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSError = null;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSFieldGroup = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSFieldParent = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSFieldRelation = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSPrivilege = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSPropertyName = "EditValue";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSSelectType = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.BOSSelectTypeValue = "";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment, "fld_lkeAPCancelPurchaseOrderCancelFromDepartment");
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Name = "fld_lkeAPCancelPurchaseOrderCancelFromDepartment";
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.Buttons"))))});
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.ColumnName = null;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.NullText = resources.GetString("fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.NullText");
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment, ((bool)(resources.GetObject("fld_lkeAPCancelPurchaseOrderCancelFromDepartment.ShowHelp"))));
            this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Tag = "DC";
            // 
            // fld_medAPCancelPurchaseOrderDesc
            // 
            this.fld_medAPCancelPurchaseOrderDesc.BOSComment = "";
            this.fld_medAPCancelPurchaseOrderDesc.BOSDataMember = "APCancelPurchaseOrderDesc";
            this.fld_medAPCancelPurchaseOrderDesc.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_medAPCancelPurchaseOrderDesc.BOSDescription = null;
            this.fld_medAPCancelPurchaseOrderDesc.BOSError = null;
            this.fld_medAPCancelPurchaseOrderDesc.BOSFieldGroup = "";
            this.fld_medAPCancelPurchaseOrderDesc.BOSFieldRelation = "";
            this.fld_medAPCancelPurchaseOrderDesc.BOSPrivilege = "";
            this.fld_medAPCancelPurchaseOrderDesc.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_medAPCancelPurchaseOrderDesc, "fld_medAPCancelPurchaseOrderDesc");
            this.fld_medAPCancelPurchaseOrderDesc.Name = "fld_medAPCancelPurchaseOrderDesc";
            this.fld_medAPCancelPurchaseOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPCancelPurchaseOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPCancelPurchaseOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPCancelPurchaseOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPCancelPurchaseOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAPCancelPurchaseOrderDesc, ((bool)(resources.GetObject("fld_medAPCancelPurchaseOrderDesc.ShowHelp"))));
            this.fld_medAPCancelPurchaseOrderDesc.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel17, "bosLabel17");
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, ((bool)(resources.GetObject("bosLabel17.ShowHelp"))));
            this.bosLabel17.Tag = "";
            // 
            // bosLine1
            // 
            resources.ApplyResources(this.bosLine1, "bosLine1");
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medAPCancelPurchaseOrderComment);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_medAPCancelPurchaseOrderComment
            // 
            this.fld_medAPCancelPurchaseOrderComment.BOSComment = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSDataMember = "APCancelPurchaseOrderComment";
            this.fld_medAPCancelPurchaseOrderComment.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_medAPCancelPurchaseOrderComment.BOSDescription = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSError = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSFieldGroup = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSFieldRelation = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSPrivilege = null;
            this.fld_medAPCancelPurchaseOrderComment.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_medAPCancelPurchaseOrderComment, "fld_medAPCancelPurchaseOrderComment");
            this.fld_medAPCancelPurchaseOrderComment.Name = "fld_medAPCancelPurchaseOrderComment";
            this.fld_medAPCancelPurchaseOrderComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPCancelPurchaseOrderComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPCancelPurchaseOrderComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPCancelPurchaseOrderComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPCancelPurchaseOrderComment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAPCancelPurchaseOrderComment, ((bool)(resources.GetObject("fld_medAPCancelPurchaseOrderComment.ShowHelp"))));
            this.fld_medAPCancelPurchaseOrderComment.Tag = "DC";
            // 
            // fld_lkeAPCancelPurchaseOrderStatus
            // 
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSAllowAddNew = false;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSAllowDummy = false;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSComment = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSDataMember = "APCancelPurchaseOrderStatus";
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSDescription = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSError = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSFieldGroup = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSFieldParent = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSFieldRelation = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSPrivilege = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSSelectType = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeAPCancelPurchaseOrderStatus, "fld_lkeAPCancelPurchaseOrderStatus");
            this.fld_lkeAPCancelPurchaseOrderStatus.Name = "fld_lkeAPCancelPurchaseOrderStatus";
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeAPCancelPurchaseOrderStatus.Properties.Buttons"))))});
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.ColumnName = null;
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.NullText = resources.GetString("fld_lkeAPCancelPurchaseOrderStatus.Properties.NullText");
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.ReadOnly = true;
            this.fld_lkeAPCancelPurchaseOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPCancelPurchaseOrderStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPCancelPurchaseOrderStatus, ((bool)(resources.GetObject("fld_lkeAPCancelPurchaseOrderStatus.ShowHelp"))));
            this.fld_lkeAPCancelPurchaseOrderStatus.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GECurrencyID, "fld_lkeFK_GECurrencyID");
            this.fld_lkeFK_GECurrencyID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GECurrencyID.Properties.Buttons"))))});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns"), resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns1"))});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = resources.GetString("fld_lkeFK_GECurrencyID.Properties.NullText");
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECurrencyID, ((bool)(resources.GetObject("fld_lkeFK_GECurrencyID.ShowHelp"))));
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel10, "fld_lblLabel10");
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, ((bool)(resources.GetObject("fld_lblLabel10.ShowHelp"))));
            // 
            // fld_txtAPPurchaseOrderNo
            // 
            this.fld_txtAPPurchaseOrderNo.BOSComment = null;
            this.fld_txtAPPurchaseOrderNo.BOSDataMember = "APCancelPurchaseOrderReference";
            this.fld_txtAPPurchaseOrderNo.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_txtAPPurchaseOrderNo.BOSDescription = null;
            this.fld_txtAPPurchaseOrderNo.BOSError = null;
            this.fld_txtAPPurchaseOrderNo.BOSFieldGroup = null;
            this.fld_txtAPPurchaseOrderNo.BOSFieldRelation = null;
            this.fld_txtAPPurchaseOrderNo.BOSPrivilege = null;
            this.fld_txtAPPurchaseOrderNo.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtAPPurchaseOrderNo, "fld_txtAPPurchaseOrderNo");
            this.fld_txtAPPurchaseOrderNo.MenuManager = this.screenToolbar;
            this.fld_txtAPPurchaseOrderNo.Name = "fld_txtAPPurchaseOrderNo";
            this.fld_txtAPPurchaseOrderNo.Properties.ReadOnly = true;
            this.fld_txtAPPurchaseOrderNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPPurchaseOrderNo, ((bool)(resources.GetObject("fld_txtAPPurchaseOrderNo.ShowHelp"))));
            this.fld_txtAPPurchaseOrderNo.Tag = "DC";
            // 
            // fld_grcGroupControl3
            // 
            resources.ApplyResources(this.fld_grcGroupControl3, "fld_grcGroupControl3");
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcAPCancelPurchaseOrderItems);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl3, ((bool)(resources.GetObject("fld_grcGroupControl3.ShowHelp"))));
            // 
            // fld_dgcAPCancelPurchaseOrderItems
            // 
            this.fld_dgcAPCancelPurchaseOrderItems.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcAPCancelPurchaseOrderItems, "fld_dgcAPCancelPurchaseOrderItems");
            this.fld_dgcAPCancelPurchaseOrderItems.BOSComment = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSDataMember = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSDataSource = "APCancelPurchaseOrderItems";
            this.fld_dgcAPCancelPurchaseOrderItems.BOSDescription = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSError = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSFieldGroup = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSFieldRelation = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSGridType = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSPrivilege = null;
            this.fld_dgcAPCancelPurchaseOrderItems.BOSPropertyName = null;
            this.fld_dgcAPCancelPurchaseOrderItems.CommodityType = "";
            this.fld_dgcAPCancelPurchaseOrderItems.MainView = this.fld_dgvARCancelVoucher;
            this.fld_dgcAPCancelPurchaseOrderItems.Name = "fld_dgcAPCancelPurchaseOrderItems";
            this.fld_dgcAPCancelPurchaseOrderItems.PrintReport = false;
            this.fld_dgcAPCancelPurchaseOrderItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcAPCancelPurchaseOrderItems, ((bool)(resources.GetObject("fld_dgcAPCancelPurchaseOrderItems.ShowHelp"))));
            this.fld_dgcAPCancelPurchaseOrderItems.Tag = "DC";
            this.fld_dgcAPCancelPurchaseOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCancelVoucher});
            // 
            // fld_dgvARCancelVoucher
            // 
            this.fld_dgvARCancelVoucher.GridControl = this.fld_dgcAPCancelPurchaseOrderItems;
            this.fld_dgvARCancelVoucher.Name = "fld_dgvARCancelVoucher";
            this.fld_dgvARCancelVoucher.PaintStyleName = "Office2003";
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
            resources.ApplyResources(this.bosLabel7, "bosLabel7");
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, ((bool)(resources.GetObject("bosLabel7.ShowHelp"))));
            // 
            // fld_dteAPPurchaseOrderDate
            // 
            this.fld_dteAPPurchaseOrderDate.BOSComment = null;
            this.fld_dteAPPurchaseOrderDate.BOSDataMember = "APCancelPurchaseOrderDate";
            this.fld_dteAPPurchaseOrderDate.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_dteAPPurchaseOrderDate.BOSDescription = null;
            this.fld_dteAPPurchaseOrderDate.BOSError = null;
            this.fld_dteAPPurchaseOrderDate.BOSFieldGroup = null;
            this.fld_dteAPPurchaseOrderDate.BOSFieldRelation = null;
            this.fld_dteAPPurchaseOrderDate.BOSPrivilege = null;
            this.fld_dteAPPurchaseOrderDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteAPPurchaseOrderDate, "fld_dteAPPurchaseOrderDate");
            this.fld_dteAPPurchaseOrderDate.Name = "fld_dteAPPurchaseOrderDate";
            this.fld_dteAPPurchaseOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_dteAPPurchaseOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteAPPurchaseOrderDate.Properties.Buttons"))))});
            this.fld_dteAPPurchaseOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseOrderDate.Properties.ReadOnly = true;
            this.fld_dteAPPurchaseOrderDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPPurchaseOrderDate, ((bool)(resources.GetObject("fld_dteAPPurchaseOrderDate.ShowHelp"))));
            this.fld_dteAPPurchaseOrderDate.Tag = "DC";
            // 
            // fld_dteAPCancelPurchaseOrderDate
            // 
            this.fld_dteAPCancelPurchaseOrderDate.BOSComment = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSDataMember = "APCancelPurchaseOrderDate";
            this.fld_dteAPCancelPurchaseOrderDate.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_dteAPCancelPurchaseOrderDate.BOSDescription = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSError = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSFieldGroup = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSFieldRelation = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSPrivilege = null;
            this.fld_dteAPCancelPurchaseOrderDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteAPCancelPurchaseOrderDate, "fld_dteAPCancelPurchaseOrderDate");
            this.fld_dteAPCancelPurchaseOrderDate.Name = "fld_dteAPCancelPurchaseOrderDate";
            this.fld_dteAPCancelPurchaseOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPCancelPurchaseOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPCancelPurchaseOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPCancelPurchaseOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPCancelPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteAPCancelPurchaseOrderDate.Properties.Buttons"))))});
            this.fld_dteAPCancelPurchaseOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPCancelPurchaseOrderDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPCancelPurchaseOrderDate, ((bool)(resources.GetObject("fld_dteAPCancelPurchaseOrderDate.ShowHelp"))));
            this.fld_dteAPCancelPurchaseOrderDate.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "APCancelPurchaseOrderContractNo";
            this.bosTextBox1.BOSDataSource = "APCancelPurchaseOrders";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.bosTextBox1, "bosTextBox1");
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, ((bool)(resources.GetObject("bosTextBox1.ShowHelp"))));
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_txtAPCancelPurchaseOrderNo
            // 
            this.fld_txtAPCancelPurchaseOrderNo.BOSComment = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSDataMember = "APCancelPurchaseOrderNo";
            this.fld_txtAPCancelPurchaseOrderNo.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_txtAPCancelPurchaseOrderNo.BOSDescription = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSError = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSFieldGroup = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSFieldRelation = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSPrivilege = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtAPCancelPurchaseOrderNo, "fld_txtAPCancelPurchaseOrderNo");
            this.fld_txtAPCancelPurchaseOrderNo.MenuManager = this.screenToolbar;
            this.fld_txtAPCancelPurchaseOrderNo.Name = "fld_txtAPCancelPurchaseOrderNo";
            this.fld_txtAPCancelPurchaseOrderNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPCancelPurchaseOrderNo, ((bool)(resources.GetObject("fld_txtAPCancelPurchaseOrderNo.ShowHelp"))));
            this.fld_txtAPCancelPurchaseOrderNo.Tag = "DC";
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
            resources.ApplyResources(this.fld_lblLabel26, "fld_lblLabel26");
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel26, ((bool)(resources.GetObject("fld_lblLabel26.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "MMBatchProductSOName";
            this.bosTextBox2.BOSDataSource = "APCancelPurchaseOrders";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.bosTextBox2, "bosTextBox2");
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Tag = "DC";
            // 
            // DMCPO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCPO100.IconOptions.Icon")));
            this.Name = "DMCPO100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseOrderCancelFromDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseOrderDesc.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPCancelPurchaseOrderComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPCancelPurchaseOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medAPCancelPurchaseOrderComment;
        private BOSComponent.BOSLookupEdit fld_lkeAPCancelPurchaseOrderStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSERP.Modules.CancelPurchaseOrder.APCancelPurchaseOrderItemsGridControl fld_dgcAPCancelPurchaseOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCancelVoucher;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseOrderDate;
        private BOSComponent.BOSDateEdit fld_dteAPCancelPurchaseOrderDate;
        private BOSComponent.BOSTextBox fld_txtAPCancelPurchaseOrderNo;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSMemoEdit fld_medAPCancelPurchaseOrderDesc;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeAPCancelPurchaseOrderCancelFromDepartment;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox bosTextBox2;
    }
}
