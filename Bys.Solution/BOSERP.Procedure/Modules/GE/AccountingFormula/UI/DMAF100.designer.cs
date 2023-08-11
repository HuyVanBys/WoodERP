using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AccountingFormula.UI
{
	/// <summary>
	/// Summary description for DMCL100
	/// </summary>
	partial class DMAF100
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
            this.fld_lkeAPInvoiceInType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteGEAccountingFormulaDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcGEAccountingFormulaItems = new BOSERP.Modules.AccountingFormula.GEAccountingFormulaItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_medGEAccountingFormulaDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtGEAccountingFormulaNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEAccountingFormulaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEAccountingFormulaDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEAccountingFormulaNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeAPInvoiceInType);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteGEAccountingFormulaDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_medGEAccountingFormulaDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtGEAccountingFormulaNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(989, 401);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lkeAPInvoiceInType
            // 
            this.fld_lkeAPInvoiceInType.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInType.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSDataMember = "GEAccountingFormulaType";
            this.fld_lkeAPInvoiceInType.BOSDataSource = "GEAccountingFormulas";
            this.fld_lkeAPInvoiceInType.BOSDescription = null;
            this.fld_lkeAPInvoiceInType.BOSError = null;
            this.fld_lkeAPInvoiceInType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInType.Location = new System.Drawing.Point(432, 38);
            this.fld_lkeAPInvoiceInType.Name = "fld_lkeAPInvoiceInType";
            this.fld_lkeAPInvoiceInType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại")});
            this.fld_lkeAPInvoiceInType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeAPInvoiceInType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInType.Properties.PopupWidth = 40;
            this.fld_lkeAPInvoiceInType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInType.Properties.ValueMember = "ADConfigValueKey";
            this.fld_lkeAPInvoiceInType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPInvoiceInType, true);
            this.fld_lkeAPInvoiceInType.Size = new System.Drawing.Size(170, 20);
            this.fld_lkeAPInvoiceInType.TabIndex = 555;
            this.fld_lkeAPInvoiceInType.Tag = "DC";
            this.fld_lkeAPInvoiceInType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeAPInvoiceInType_CloseUp);
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
            this.bosLabel2.Location = new System.Drawing.Point(339, 44);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(57, 13);
            this.bosLabel2.TabIndex = 554;
            this.bosLabel2.Text = "Báo cáo loại";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "GEAccountingFormulaName";
            this.bosTextBox1.BOSDataSource = "GEAccountingFormulas";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(125, 38);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(166, 20);
            this.bosTextBox1.TabIndex = 551;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(31, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 552;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_dteGEAccountingFormulaDate
            // 
            this.fld_dteGEAccountingFormulaDate.BOSComment = null;
            this.fld_dteGEAccountingFormulaDate.BOSDataMember = "GEAccountingFormulaDate";
            this.fld_dteGEAccountingFormulaDate.BOSDataSource = "GEAccountingFormulas";
            this.fld_dteGEAccountingFormulaDate.BOSDescription = null;
            this.fld_dteGEAccountingFormulaDate.BOSError = null;
            this.fld_dteGEAccountingFormulaDate.BOSFieldGroup = null;
            this.fld_dteGEAccountingFormulaDate.BOSFieldRelation = null;
            this.fld_dteGEAccountingFormulaDate.BOSPrivilege = null;
            this.fld_dteGEAccountingFormulaDate.BOSPropertyName = "EditValue";
            this.fld_dteGEAccountingFormulaDate.EditValue = null;
            this.fld_dteGEAccountingFormulaDate.Location = new System.Drawing.Point(432, 12);
            this.fld_dteGEAccountingFormulaDate.Name = "fld_dteGEAccountingFormulaDate";
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteGEAccountingFormulaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteGEAccountingFormulaDate.Screen = null;
            this.fld_dteGEAccountingFormulaDate.Size = new System.Drawing.Size(170, 20);
            this.fld_dteGEAccountingFormulaDate.TabIndex = 79;
            this.fld_dteGEAccountingFormulaDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(339, 18);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 80;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 112);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(983, 289);
            this.bosTabControl1.TabIndex = 26;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcGEAccountingFormulaItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(976, 260);
            this.xtraTabPage1.Text = "Cấu hình";
            // 
            // fld_dgcGEAccountingFormulaItems
            // 
            this.fld_dgcGEAccountingFormulaItems.AllowDrop = true;
            this.fld_dgcGEAccountingFormulaItems.BOSComment = null;
            this.fld_dgcGEAccountingFormulaItems.BOSDataMember = null;
            this.fld_dgcGEAccountingFormulaItems.BOSDataSource = "GEAccountingFormulaItems";
            this.fld_dgcGEAccountingFormulaItems.BOSDescription = null;
            this.fld_dgcGEAccountingFormulaItems.BOSError = null;
            this.fld_dgcGEAccountingFormulaItems.BOSFieldGroup = null;
            this.fld_dgcGEAccountingFormulaItems.BOSFieldRelation = null;
            this.fld_dgcGEAccountingFormulaItems.BOSGridType = null;
            this.fld_dgcGEAccountingFormulaItems.BOSPrivilege = null;
            this.fld_dgcGEAccountingFormulaItems.BOSPropertyName = null;
            this.fld_dgcGEAccountingFormulaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEAccountingFormulaItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcGEAccountingFormulaItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGEAccountingFormulaItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcGEAccountingFormulaItems.Name = "fld_dgcGEAccountingFormulaItems";
            this.fld_dgcGEAccountingFormulaItems.PrintReport = false;
            this.fld_dgcGEAccountingFormulaItems.Screen = null;
            this.fld_dgcGEAccountingFormulaItems.Size = new System.Drawing.Size(976, 260);
            this.fld_dgcGEAccountingFormulaItems.TabIndex = 1;
            this.fld_dgcGEAccountingFormulaItems.Tag = "DC";
            this.fld_dgcGEAccountingFormulaItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcGEAccountingFormulaItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_medGEAccountingFormulaDesc
            // 
            this.fld_medGEAccountingFormulaDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medGEAccountingFormulaDesc.BOSDataMember = "GEAccountingFormulaDesc";
            this.fld_medGEAccountingFormulaDesc.BOSDataSource = "GEAccountingFormulas";
            this.fld_medGEAccountingFormulaDesc.BOSDescription = null;
            this.fld_medGEAccountingFormulaDesc.BOSError = null;
            this.fld_medGEAccountingFormulaDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medGEAccountingFormulaDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medGEAccountingFormulaDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medGEAccountingFormulaDesc.BOSPropertyName = "EditValue";
            this.fld_medGEAccountingFormulaDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medGEAccountingFormulaDesc.Location = new System.Drawing.Point(125, 64);
            this.fld_medGEAccountingFormulaDesc.Name = "fld_medGEAccountingFormulaDesc";
            this.fld_medGEAccountingFormulaDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medGEAccountingFormulaDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medGEAccountingFormulaDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medGEAccountingFormulaDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medGEAccountingFormulaDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medGEAccountingFormulaDesc, true);
            this.fld_medGEAccountingFormulaDesc.Size = new System.Drawing.Size(477, 42);
            this.fld_medGEAccountingFormulaDesc.TabIndex = 6;
            this.fld_medGEAccountingFormulaDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(31, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_txtGEAccountingFormulaNo
            // 
            this.fld_txtGEAccountingFormulaNo.BOSComment = null;
            this.fld_txtGEAccountingFormulaNo.BOSDataMember = "GEAccountingFormulaNo";
            this.fld_txtGEAccountingFormulaNo.BOSDataSource = "GEAccountingFormulas";
            this.fld_txtGEAccountingFormulaNo.BOSDescription = null;
            this.fld_txtGEAccountingFormulaNo.BOSError = null;
            this.fld_txtGEAccountingFormulaNo.BOSFieldGroup = null;
            this.fld_txtGEAccountingFormulaNo.BOSFieldRelation = null;
            this.fld_txtGEAccountingFormulaNo.BOSPrivilege = null;
            this.fld_txtGEAccountingFormulaNo.BOSPropertyName = "EditValue";
            this.fld_txtGEAccountingFormulaNo.Location = new System.Drawing.Point(125, 12);
            this.fld_txtGEAccountingFormulaNo.MenuManager = this.screenToolbar;
            this.fld_txtGEAccountingFormulaNo.Name = "fld_txtGEAccountingFormulaNo";
            this.fld_txtGEAccountingFormulaNo.Screen = null;
            this.fld_txtGEAccountingFormulaNo.Size = new System.Drawing.Size(166, 20);
            this.fld_txtGEAccountingFormulaNo.TabIndex = 0;
            this.fld_txtGEAccountingFormulaNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(31, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // DMAF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(989, 401);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAF100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEAccountingFormulaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEAccountingFormulaDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEAccountingFormulaNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSERP.Modules.AccountingFormula.GEAccountingFormulaItemsGridControl fld_dgcGEAccountingFormulaItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSMemoEdit fld_medGEAccountingFormulaDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtGEAccountingFormulaNo;
        private BOSComponent.BOSLabel bosLabel7;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteGEAccountingFormulaDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInType;
	}
}
