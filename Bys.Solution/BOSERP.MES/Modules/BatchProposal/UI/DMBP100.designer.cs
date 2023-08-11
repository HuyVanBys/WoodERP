using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProposal.UI
{
	/// <summary>
	/// Summary description for DMBP100
	/// </summary>
	partial class DMBP100
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
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeMMProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAACreatedDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtMMProposalPONo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabWoodItems = new BOSComponent.BOSTabControl(this.components);
            this.xrTabOtherItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProposalItemsGridControl = new BOSERP.Modules.BatchProposal.MMProposalItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMPriority = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProposalBatchStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmpoyeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProposalSaleOrderDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.xrTabWoodItems = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabWoodItems)).BeginInit();
            this.fld_tabWoodItems.SuspendLayout();
            this.xrTabOtherItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposalItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalBatchStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalSaleOrderDeliveryDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(258, 15);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, true);
            this.fld_lblLabel12.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel12.TabIndex = 341;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Ngày đề nghị";
            // 
            // fld_dteMMProposalDate
            // 
            this.fld_dteMMProposalDate.BOSComment = "";
            this.fld_dteMMProposalDate.BOSDataMember = "MMProposalDate";
            this.fld_dteMMProposalDate.BOSDataSource = "MMProposals";
            this.fld_dteMMProposalDate.BOSDescription = null;
            this.fld_dteMMProposalDate.BOSError = null;
            this.fld_dteMMProposalDate.BOSFieldGroup = "";
            this.fld_dteMMProposalDate.BOSFieldRelation = "";
            this.fld_dteMMProposalDate.BOSPrivilege = "";
            this.fld_dteMMProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProposalDate.EditValue = null;
            this.fld_dteMMProposalDate.Location = new System.Drawing.Point(339, 12);
            this.fld_dteMMProposalDate.Name = "fld_dteMMProposalDate";
            this.fld_dteMMProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProposalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProposalDate, true);
            this.fld_dteMMProposalDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProposalDate.TabIndex = 1;
            this.fld_dteMMProposalDate.Tag = "DC";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = "";
            this.fld_lblLabel15.Location = new System.Drawing.Point(12, 15);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(54, 13);
            this.fld_lblLabel15.TabIndex = 338;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã đề nghị";
            // 
            // fld_txtMMProposalNo
            // 
            this.fld_txtMMProposalNo.BOSComment = "";
            this.fld_txtMMProposalNo.BOSDataMember = "MMProposalNo";
            this.fld_txtMMProposalNo.BOSDataSource = "MMProposals";
            this.fld_txtMMProposalNo.BOSDescription = null;
            this.fld_txtMMProposalNo.BOSError = null;
            this.fld_txtMMProposalNo.BOSFieldGroup = "";
            this.fld_txtMMProposalNo.BOSFieldRelation = "";
            this.fld_txtMMProposalNo.BOSPrivilege = "";
            this.fld_txtMMProposalNo.BOSPropertyName = "Text";
            this.fld_txtMMProposalNo.EditValue = "";
            this.fld_txtMMProposalNo.Location = new System.Drawing.Point(92, 12);
            this.fld_txtMMProposalNo.Name = "fld_txtMMProposalNo";
            this.fld_txtMMProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProposalNo.Properties.ReadOnly = true;
            this.fld_txtMMProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProposalNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProposalNo, true);
            this.fld_txtMMProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProposalNo.TabIndex = 0;
            this.fld_txtMMProposalNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeMMProposalType);
            this.bosPanel1.Controls.Add(this.fld_dteAACreatedDate);
            this.bosPanel1.Controls.Add(this.bosLabel41);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel1.Controls.Add(this.fld_txtMMProposalPONo);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_tabWoodItems);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medMMProposalDesc);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeMMPriority);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeMMProposalBatchStatus);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmpoyeeID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel15);
            this.bosPanel1.Controls.Add(this.fld_txtMMProposalNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lblLabel12);
            this.bosPanel1.Controls.Add(this.fld_dteMMProposalSaleOrderDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_dteMMProposalDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(920, 603);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeMMProposalType
            // 
            this.fld_lkeMMProposalType.BOSAllowAddNew = false;
            this.fld_lkeMMProposalType.BOSAllowDummy = false;
            this.fld_lkeMMProposalType.BOSComment = "";
            this.fld_lkeMMProposalType.BOSDataMember = "MMProposalType";
            this.fld_lkeMMProposalType.BOSDataSource = "MMProposals";
            this.fld_lkeMMProposalType.BOSDescription = null;
            this.fld_lkeMMProposalType.BOSError = null;
            this.fld_lkeMMProposalType.BOSFieldGroup = "";
            this.fld_lkeMMProposalType.BOSFieldParent = "";
            this.fld_lkeMMProposalType.BOSFieldRelation = "";
            this.fld_lkeMMProposalType.BOSPrivilege = "";
            this.fld_lkeMMProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeMMProposalType.BOSSelectType = "";
            this.fld_lkeMMProposalType.BOSSelectTypeValue = "";
            this.fld_lkeMMProposalType.CurrentDisplayText = null;
            this.fld_lkeMMProposalType.Location = new System.Drawing.Point(590, 38);
            this.fld_lkeMMProposalType.Name = "fld_lkeMMProposalType";
            this.fld_lkeMMProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProposalType.Properties.ColumnName = null;
            this.fld_lkeMMProposalType.Properties.NullText = "";
            this.fld_lkeMMProposalType.Properties.PopupWidth = 40;
            this.fld_lkeMMProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProposalType.Screen = null;
            this.fld_lkeMMProposalType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMProposalType.TabIndex = 5;
            this.fld_lkeMMProposalType.Tag = "DC";
            // 
            // fld_dteAACreatedDate
            // 
            this.fld_dteAACreatedDate.BOSComment = null;
            this.fld_dteAACreatedDate.BOSDataMember = "AACreatedDate";
            this.fld_dteAACreatedDate.BOSDataSource = "MMProposals";
            this.fld_dteAACreatedDate.BOSDescription = null;
            this.fld_dteAACreatedDate.BOSError = null;
            this.fld_dteAACreatedDate.BOSFieldGroup = null;
            this.fld_dteAACreatedDate.BOSFieldRelation = null;
            this.fld_dteAACreatedDate.BOSPrivilege = null;
            this.fld_dteAACreatedDate.BOSPropertyName = "EditValue";
            this.fld_dteAACreatedDate.EditValue = new System.DateTime(2018, 9, 26, 10, 48, 0, 0);
            this.fld_dteAACreatedDate.Enabled = false;
            this.fld_dteAACreatedDate.Location = new System.Drawing.Point(590, 12);
            this.fld_dteAACreatedDate.Name = "fld_dteAACreatedDate";
            this.fld_dteAACreatedDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteAACreatedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAACreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAACreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.Mask.EditMask = "g";
            this.fld_dteAACreatedDate.Properties.ReadOnly = true;
            this.fld_dteAACreatedDate.Screen = null;
            this.fld_dteAACreatedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAACreatedDate.TabIndex = 2;
            this.fld_dteAACreatedDate.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.Options.UseBackColor = true;
            this.bosLabel41.Appearance.Options.UseForeColor = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(508, 15);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(44, 13);
            this.bosLabel41.TabIndex = 588;
            this.bosLabel41.Text = "Ngày tạo";
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
            this.fld_lblLabel10.Location = new System.Drawing.Point(258, 67);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel10.TabIndex = 587;
            this.fld_lblLabel10.Text = "Đối tượng";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = null;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "MMProposals";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = null;
            this.fld_lkeACObjectAccessKey.BOSFieldParent = null;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = null;
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = null;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = null;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = null;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(339, 64);
            this.fld_lkeACObjectAccessKey.MenuManager = this.screenToolbar;
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 7;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            this.fld_lkeACObjectAccessKey.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_txtMMProposalPONo
            // 
            this.fld_txtMMProposalPONo.BOSComment = "";
            this.fld_txtMMProposalPONo.BOSDataMember = "MMProposalPONo";
            this.fld_txtMMProposalPONo.BOSDataSource = "MMProposals";
            this.fld_txtMMProposalPONo.BOSDescription = null;
            this.fld_txtMMProposalPONo.BOSError = null;
            this.fld_txtMMProposalPONo.BOSFieldGroup = "";
            this.fld_txtMMProposalPONo.BOSFieldRelation = "";
            this.fld_txtMMProposalPONo.BOSPrivilege = "";
            this.fld_txtMMProposalPONo.BOSPropertyName = "Text";
            this.fld_txtMMProposalPONo.EditValue = "";
            this.fld_txtMMProposalPONo.Location = new System.Drawing.Point(92, 90);
            this.fld_txtMMProposalPONo.Name = "fld_txtMMProposalPONo";
            this.fld_txtMMProposalPONo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMProposalPONo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProposalPONo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProposalPONo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProposalPONo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProposalPONo.Properties.ReadOnly = true;
            this.fld_txtMMProposalPONo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProposalPONo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProposalPONo, true);
            this.fld_txtMMProposalPONo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProposalPONo.TabIndex = 9;
            this.fld_txtMMProposalPONo.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(9, 93);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(35, 13);
            this.bosLabel12.TabIndex = 559;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = " Số HĐ";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = "";
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "MMOperationGroup";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "Material";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(590, 90);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Name")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 11;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(508, 93);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 557;
            this.bosLabel1.Text = "Công đoạn";
            // 
            // fld_tabWoodItems
            // 
            this.fld_tabWoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabWoodItems.BOSComment = null;
            this.fld_tabWoodItems.BOSDataMember = null;
            this.fld_tabWoodItems.BOSDataSource = null;
            this.fld_tabWoodItems.BOSDescription = null;
            this.fld_tabWoodItems.BOSError = null;
            this.fld_tabWoodItems.BOSFieldGroup = null;
            this.fld_tabWoodItems.BOSFieldRelation = null;
            this.fld_tabWoodItems.BOSPrivilege = null;
            this.fld_tabWoodItems.BOSPropertyName = null;
            this.fld_tabWoodItems.Location = new System.Drawing.Point(3, 160);
            this.fld_tabWoodItems.Name = "fld_tabWoodItems";
            this.fld_tabWoodItems.Screen = null;
            this.fld_tabWoodItems.SelectedTabPage = this.xrTabOtherItems;
            this.fld_tabWoodItems.Size = new System.Drawing.Size(914, 440);
            this.fld_tabWoodItems.TabIndex = 555;
            this.fld_tabWoodItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xrTabOtherItems});
            // 
            // xrTabOtherItems
            // 
            this.xrTabOtherItems.Controls.Add(this.fld_dgcMMProposalItemsGridControl);
            this.xrTabOtherItems.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xrTabOtherItems.Controls.Add(this.bosLabel10);
            this.xrTabOtherItems.Name = "xrTabOtherItems";
            this.xrTabOtherItems.Size = new System.Drawing.Size(908, 412);
            this.xrTabOtherItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcMMProposalItemsGridControl
            // 
            this.fld_dgcMMProposalItemsGridControl.AllowDrop = true;
            this.fld_dgcMMProposalItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProposalItemsGridControl.BOSComment = null;
            this.fld_dgcMMProposalItemsGridControl.BOSDataMember = null;
            this.fld_dgcMMProposalItemsGridControl.BOSDataSource = "MMProposalItems";
            this.fld_dgcMMProposalItemsGridControl.BOSDescription = null;
            this.fld_dgcMMProposalItemsGridControl.BOSError = null;
            this.fld_dgcMMProposalItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMProposalItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMProposalItemsGridControl.BOSGridType = null;
            this.fld_dgcMMProposalItemsGridControl.BOSPrivilege = null;
            this.fld_dgcMMProposalItemsGridControl.BOSPropertyName = null;
            this.fld_dgcMMProposalItemsGridControl.CommodityType = "";
            this.fld_dgcMMProposalItemsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProposalItemsGridControl.Location = new System.Drawing.Point(4, 30);
            this.fld_dgcMMProposalItemsGridControl.MainView = this.gridView2;
            this.fld_dgcMMProposalItemsGridControl.Name = "fld_dgcMMProposalItemsGridControl";
            this.fld_dgcMMProposalItemsGridControl.PrintReport = false;
            this.fld_dgcMMProposalItemsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProposalItemsGridControl, true);
            this.fld_dgcMMProposalItemsGridControl.Size = new System.Drawing.Size(899, 378);
            this.fld_dgcMMProposalItemsGridControl.TabIndex = 30;
            this.fld_dgcMMProposalItemsGridControl.Tag = "DC";
            this.fld_dgcMMProposalItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProposalItemsGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMProposalItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(76, 4);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductname", "Tên SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, true);
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(827, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 28;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(10, 7);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(47, 13);
            this.bosLabel10.TabIndex = 29;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSComment = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "Text";
            this.fld_lkeFK_ARSaleOrderID.EditValue = "";
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(92, 64);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.ReadOnly = true;
            this.fld_lkeFK_ARSaleOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARSaleOrderID, true);
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 6;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "ICProductNo";
            this.bosLabel9.BOSDataSource = "ICProducts";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = "";
            this.bosLabel9.Location = new System.Drawing.Point(12, 67);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(68, 13);
            this.bosLabel9.TabIndex = 488;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Đơn bán hàng";
            // 
            // fld_medMMProposalDesc
            // 
            this.fld_medMMProposalDesc.BOSComment = null;
            this.fld_medMMProposalDesc.BOSDataMember = "MMProposalDesc";
            this.fld_medMMProposalDesc.BOSDataSource = "MMProposals";
            this.fld_medMMProposalDesc.BOSDescription = null;
            this.fld_medMMProposalDesc.BOSError = null;
            this.fld_medMMProposalDesc.BOSFieldGroup = null;
            this.fld_medMMProposalDesc.BOSFieldRelation = null;
            this.fld_medMMProposalDesc.BOSPrivilege = null;
            this.fld_medMMProposalDesc.BOSPropertyName = "Text";
            this.fld_medMMProposalDesc.Location = new System.Drawing.Point(92, 116);
            this.fld_medMMProposalDesc.Name = "fld_medMMProposalDesc";
            this.fld_medMMProposalDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProposalDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProposalDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProposalDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProposalDesc.Screen = null;
            this.fld_medMMProposalDesc.Size = new System.Drawing.Size(397, 38);
            this.fld_medMMProposalDesc.TabIndex = 12;
            this.fld_medMMProposalDesc.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(12, 123);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 486;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(508, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(59, 13);
            this.bosLabel3.TabIndex = 349;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại đề nghị";
            // 
            // fld_lkeMMPriority
            // 
            this.fld_lkeMMPriority.BOSAllowAddNew = false;
            this.fld_lkeMMPriority.BOSAllowDummy = false;
            this.fld_lkeMMPriority.BOSComment = "";
            this.fld_lkeMMPriority.BOSDataMember = "MMPriority";
            this.fld_lkeMMPriority.BOSDataSource = "MMProposals";
            this.fld_lkeMMPriority.BOSDescription = null;
            this.fld_lkeMMPriority.BOSError = null;
            this.fld_lkeMMPriority.BOSFieldGroup = "";
            this.fld_lkeMMPriority.BOSFieldParent = "";
            this.fld_lkeMMPriority.BOSFieldRelation = "";
            this.fld_lkeMMPriority.BOSPrivilege = "";
            this.fld_lkeMMPriority.BOSPropertyName = "EditValue";
            this.fld_lkeMMPriority.BOSSelectType = "";
            this.fld_lkeMMPriority.BOSSelectTypeValue = "";
            this.fld_lkeMMPriority.CurrentDisplayText = null;
            this.fld_lkeMMPriority.Location = new System.Drawing.Point(590, 64);
            this.fld_lkeMMPriority.Name = "fld_lkeMMPriority";
            this.fld_lkeMMPriority.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMPriority.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMPriority.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMPriority.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPriority.Properties.ColumnName = null;
            this.fld_lkeMMPriority.Properties.NullText = "";
            this.fld_lkeMMPriority.Properties.PopupWidth = 40;
            this.fld_lkeMMPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMPriority.Screen = null;
            this.fld_lkeMMPriority.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMPriority.TabIndex = 8;
            this.fld_lkeMMPriority.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(508, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 347;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Độ ưu tiên";
            // 
            // fld_lkeMMProposalBatchStatus
            // 
            this.fld_lkeMMProposalBatchStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProposalBatchStatus.BOSAllowDummy = false;
            this.fld_lkeMMProposalBatchStatus.BOSComment = "";
            this.fld_lkeMMProposalBatchStatus.BOSDataMember = "MMProposalBatchStatus";
            this.fld_lkeMMProposalBatchStatus.BOSDataSource = "MMProposals";
            this.fld_lkeMMProposalBatchStatus.BOSDescription = null;
            this.fld_lkeMMProposalBatchStatus.BOSError = null;
            this.fld_lkeMMProposalBatchStatus.BOSFieldGroup = "";
            this.fld_lkeMMProposalBatchStatus.BOSFieldParent = "";
            this.fld_lkeMMProposalBatchStatus.BOSFieldRelation = "";
            this.fld_lkeMMProposalBatchStatus.BOSPrivilege = "";
            this.fld_lkeMMProposalBatchStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProposalBatchStatus.BOSSelectType = "";
            this.fld_lkeMMProposalBatchStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMProposalBatchStatus.CurrentDisplayText = null;
            this.fld_lkeMMProposalBatchStatus.Location = new System.Drawing.Point(339, 90);
            this.fld_lkeMMProposalBatchStatus.Name = "fld_lkeMMProposalBatchStatus";
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProposalBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProposalBatchStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProposalBatchStatus.Properties.ColumnName = null;
            this.fld_lkeMMProposalBatchStatus.Properties.NullText = "";
            this.fld_lkeMMProposalBatchStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProposalBatchStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProposalBatchStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProposalBatchStatus.Screen = null;
            this.fld_lkeMMProposalBatchStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMProposalBatchStatus.TabIndex = 10;
            this.fld_lkeMMProposalBatchStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(258, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 347;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Trạng thái";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 41);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(47, 13);
            this.bosLabel8.TabIndex = 345;
            this.bosLabel8.Text = "Người tạo";
            // 
            // fld_lkeFK_HREmpoyeeID
            // 
            this.fld_lkeFK_HREmpoyeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmpoyeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmpoyeeID.BOSComment = null;
            this.fld_lkeFK_HREmpoyeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.BOSDataSource = "MMProposals";
            this.fld_lkeFK_HREmpoyeeID.BOSDescription = null;
            this.fld_lkeFK_HREmpoyeeID.BOSError = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmpoyeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmpoyeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmpoyeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmpoyeeID.Location = new System.Drawing.Point(92, 38);
            this.fld_lkeFK_HREmpoyeeID.Name = "fld_lkeFK_HREmpoyeeID";
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmpoyeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmpoyeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmpoyeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmpoyeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmpoyeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmpoyeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmpoyeeID, true);
            this.fld_lkeFK_HREmpoyeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmpoyeeID.TabIndex = 3;
            this.fld_lkeFK_HREmpoyeeID.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(258, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(75, 13);
            this.bosLabel11.TabIndex = 341;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Ngày giao hàng";
            // 
            // fld_dteMMProposalSaleOrderDeliveryDate
            // 
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSComment = "";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSDataMember = "MMProposalSaleOrderDeliveryDate";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSDataSource = "MMProposals";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSDescription = null;
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSError = null;
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSFieldGroup = "";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSFieldRelation = "";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSPrivilege = "";
            this.fld_dteMMProposalSaleOrderDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProposalSaleOrderDeliveryDate.EditValue = null;
            this.fld_dteMMProposalSaleOrderDeliveryDate.Location = new System.Drawing.Point(339, 38);
            this.fld_dteMMProposalSaleOrderDeliveryDate.Name = "fld_dteMMProposalSaleOrderDeliveryDate";
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProposalSaleOrderDeliveryDate.Screen = null;
            this.fld_dteMMProposalSaleOrderDeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProposalSaleOrderDeliveryDate.TabIndex = 4;
            this.fld_dteMMProposalSaleOrderDeliveryDate.Tag = "DC";
            this.fld_dteMMProposalSaleOrderDeliveryDate.Validated += new System.EventHandler(this.fld_dteMMProposalSaleOrderDeliveryDate_Validated);
            // 
            // xrTabWoodItems
            // 
            this.xrTabWoodItems.Name = "xrTabWoodItems";
            this.xrTabWoodItems.Size = new System.Drawing.Size(871, 370);
            // 
            // DMBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(920, 603);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBP100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProposalPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabWoodItems)).EndInit();
            this.fld_tabWoodItems.ResumeLayout(false);
            this.xrTabOtherItems.ResumeLayout(false);
            this.xrTabOtherItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposalItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProposalBatchStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalSaleOrderDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProposalSaleOrderDeliveryDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSDateEdit fld_dteMMProposalDate;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSTextBox fld_txtMMProposalNo;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmpoyeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMProposalBatchStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMProposalDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeMMPriority;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSDateEdit fld_dteMMProposalSaleOrderDeliveryDate;
        private BOSComponent.BOSTextBox fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSTabControl fld_tabWoodItems;
        private DevExpress.XtraTab.XtraTabPage xrTabOtherItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel10;
        private MMProposalItemsGridControl fld_dgcMMProposalItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProposalPONo;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private DevExpress.XtraTab.XtraTabPage xrTabWoodItems;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSDateEdit fld_dteAACreatedDate;
        private BOSComponent.BOSLookupEdit fld_lkeMMProposalType;
    }
}
