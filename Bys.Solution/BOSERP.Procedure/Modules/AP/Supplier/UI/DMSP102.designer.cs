using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Supplier.UI
{
    /// <summary>
    /// Summary description for DMSP102
    /// </summary>
    partial class DMSP102
    {
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSDateEdit fld_dteOwingDateFrom;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSDateEdit fld_dteOwingDateTo;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInNo;
        private APOwingInvoicesGridControl fld_dgcOwingInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLine fld_Line2;
        private APInvoicePaymentDetailsGridControl fld_dgcInvoicePaymentDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;


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
            this.fld_dteOwingDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteOwingDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcInvoicePaymentDetails = new BOSERP.Modules.Supplier.APInvoicePaymentDetailsGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcOwingInvoices = new BOSERP.Modules.Supplier.APOwingInvoicesGridControl();
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnOwingFilter = new BOSComponent.BOSButton(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_txtAPInvoiceInSupplierReference = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcOwingByCurrency = new BOSERP.Modules.Supplier.OwingByCurrencyGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSupplierPayments = new BOSERP.Modules.Supplier.SupplierPaymentsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInvoicePaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcOwingInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierReference.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcOwingByCurrency)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSupplierPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = "";
            this.fld_lblLabel26.BOSDataMember = "";
            this.fld_lblLabel26.BOSDataSource = "";
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = "";
            this.fld_lblLabel26.BOSFieldRelation = "";
            this.fld_lblLabel26.BOSPrivilege = "";
            this.fld_lblLabel26.BOSPropertyName = "";
            this.fld_lblLabel26.Location = new System.Drawing.Point(10, 11);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel26.TabIndex = 4;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Từ ngày";
            // 
            // fld_dteOwingDateFrom
            // 
            this.fld_dteOwingDateFrom.BOSComment = "";
            this.fld_dteOwingDateFrom.BOSDataMember = "";
            this.fld_dteOwingDateFrom.BOSDataSource = "";
            this.fld_dteOwingDateFrom.BOSDescription = null;
            this.fld_dteOwingDateFrom.BOSError = null;
            this.fld_dteOwingDateFrom.BOSFieldGroup = "";
            this.fld_dteOwingDateFrom.BOSFieldRelation = "";
            this.fld_dteOwingDateFrom.BOSPrivilege = "";
            this.fld_dteOwingDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteOwingDateFrom.EditValue = null;
            this.fld_dteOwingDateFrom.Location = new System.Drawing.Point(110, 9);
            this.fld_dteOwingDateFrom.Name = "fld_dteOwingDateFrom";
            this.fld_dteOwingDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteOwingDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteOwingDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteOwingDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteOwingDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteOwingDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteOwingDateFrom.Screen = null;
            this.fld_dteOwingDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteOwingDateFrom.TabIndex = 0;
            this.fld_dteOwingDateFrom.Tag = "DC";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = "";
            this.fld_lblLabel27.Location = new System.Drawing.Point(258, 11);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel27.TabIndex = 6;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Đến";
            // 
            // fld_dteOwingDateTo
            // 
            this.fld_dteOwingDateTo.BOSComment = "";
            this.fld_dteOwingDateTo.BOSDataMember = "";
            this.fld_dteOwingDateTo.BOSDataSource = "";
            this.fld_dteOwingDateTo.BOSDescription = null;
            this.fld_dteOwingDateTo.BOSError = null;
            this.fld_dteOwingDateTo.BOSFieldGroup = "";
            this.fld_dteOwingDateTo.BOSFieldRelation = "";
            this.fld_dteOwingDateTo.BOSPrivilege = "";
            this.fld_dteOwingDateTo.BOSPropertyName = "EditValue";
            this.fld_dteOwingDateTo.EditValue = null;
            this.fld_dteOwingDateTo.Location = new System.Drawing.Point(337, 9);
            this.fld_dteOwingDateTo.Name = "fld_dteOwingDateTo";
            this.fld_dteOwingDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteOwingDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteOwingDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteOwingDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteOwingDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteOwingDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteOwingDateTo.Screen = null;
            this.fld_dteOwingDateTo.Size = new System.Drawing.Size(125, 20);
            this.fld_dteOwingDateTo.TabIndex = 2;
            this.fld_dteOwingDateTo.Tag = "DC";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = "";
            this.fld_lblLabel28.Location = new System.Drawing.Point(258, 39);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel28.TabIndex = 8;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Mã hóa đơn";
            // 
            // fld_txtAPInvoiceInNo
            // 
            this.fld_txtAPInvoiceInNo.BOSComment = "";
            this.fld_txtAPInvoiceInNo.BOSDataMember = "";
            this.fld_txtAPInvoiceInNo.BOSDataSource = "";
            this.fld_txtAPInvoiceInNo.BOSDescription = null;
            this.fld_txtAPInvoiceInNo.BOSError = null;
            this.fld_txtAPInvoiceInNo.BOSFieldGroup = "";
            this.fld_txtAPInvoiceInNo.BOSFieldRelation = "";
            this.fld_txtAPInvoiceInNo.BOSPrivilege = "";
            this.fld_txtAPInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtAPInvoiceInNo.EditValue = "";
            this.fld_txtAPInvoiceInNo.Location = new System.Drawing.Point(337, 35);
            this.fld_txtAPInvoiceInNo.Name = "fld_txtAPInvoiceInNo";
            this.fld_txtAPInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPInvoiceInNo.Screen = null;
            this.fld_txtAPInvoiceInNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPInvoiceInNo.TabIndex = 5;
            this.fld_txtAPInvoiceInNo.Tag = "DC";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseFont = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "";
            this.fld_lblLabel29.BOSDataSource = "";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = "";
            this.fld_lblLabel29.Location = new System.Drawing.Point(7, 348);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(105, 13);
            this.fld_lblLabel29.TabIndex = 12;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "Chi tiết thanh toán";
            // 
            // fld_Line2
            // 
            this.fld_Line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Line2.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line2.BOSComment = "";
            this.fld_Line2.BOSDataMember = "";
            this.fld_Line2.BOSDataSource = "";
            this.fld_Line2.BOSDescription = null;
            this.fld_Line2.BOSError = null;
            this.fld_Line2.BOSFieldGroup = "";
            this.fld_Line2.BOSFieldRelation = "";
            this.fld_Line2.BOSPrivilege = "";
            this.fld_Line2.BOSPropertyName = "";
            this.fld_Line2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line2.Location = new System.Drawing.Point(104, 351);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(865, 10);
            this.fld_Line2.TabIndex = 13;
            this.fld_Line2.TabStop = false;
            this.fld_Line2.Tag = "";
            // 
            // fld_dgcInvoicePaymentDetails
            // 
            this.fld_dgcInvoicePaymentDetails.AllowDrop = true;
            this.fld_dgcInvoicePaymentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcInvoicePaymentDetails.BOSComment = "";
            this.fld_dgcInvoicePaymentDetails.BOSDataMember = "";
            this.fld_dgcInvoicePaymentDetails.BOSDataSource = "APDocumentPayments";
            this.fld_dgcInvoicePaymentDetails.BOSDescription = null;
            this.fld_dgcInvoicePaymentDetails.BOSError = null;
            this.fld_dgcInvoicePaymentDetails.BOSFieldGroup = "";
            this.fld_dgcInvoicePaymentDetails.BOSFieldRelation = "";
            this.fld_dgcInvoicePaymentDetails.BOSGridType = null;
            this.fld_dgcInvoicePaymentDetails.BOSPrivilege = "";
            this.fld_dgcInvoicePaymentDetails.BOSPropertyName = "";
            this.fld_dgcInvoicePaymentDetails.CommodityType = "";
            this.fld_dgcInvoicePaymentDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcInvoicePaymentDetails.Location = new System.Drawing.Point(7, 367);
            this.fld_dgcInvoicePaymentDetails.MainView = this.fld_dgvGridControl1;
            this.fld_dgcInvoicePaymentDetails.Name = "fld_dgcInvoicePaymentDetails";
            this.fld_dgcInvoicePaymentDetails.PrintReport = false;
            this.fld_dgcInvoicePaymentDetails.Screen = null;
            this.fld_dgcInvoicePaymentDetails.Size = new System.Drawing.Size(961, 221);
            this.fld_dgcInvoicePaymentDetails.TabIndex = 14;
            this.fld_dgcInvoicePaymentDetails.Tag = "DC";
            this.fld_dgcInvoicePaymentDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcInvoicePaymentDetails;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // fld_dgcOwingInvoices
            // 
            this.fld_dgcOwingInvoices.AllowDrop = true;
            this.fld_dgcOwingInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcOwingInvoices.BOSComment = "";
            this.fld_dgcOwingInvoices.BOSDataMember = "";
            this.fld_dgcOwingInvoices.BOSDataSource = "APInvoiceIns";
            this.fld_dgcOwingInvoices.BOSDescription = null;
            this.fld_dgcOwingInvoices.BOSError = null;
            this.fld_dgcOwingInvoices.BOSFieldGroup = "";
            this.fld_dgcOwingInvoices.BOSFieldRelation = "";
            this.fld_dgcOwingInvoices.BOSGridType = null;
            this.fld_dgcOwingInvoices.BOSPrivilege = "";
            this.fld_dgcOwingInvoices.BOSPropertyName = "";
            this.fld_dgcOwingInvoices.CommodityType = "";
            this.fld_dgcOwingInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcOwingInvoices.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcOwingInvoices.MainView = this.fld_dgvGridControl;
            this.fld_dgcOwingInvoices.Name = "fld_dgcOwingInvoices";
            this.fld_dgcOwingInvoices.PrintReport = false;
            this.fld_dgcOwingInvoices.Screen = null;
            this.fld_dgcOwingInvoices.Size = new System.Drawing.Size(965, 339);
            this.fld_dgcOwingInvoices.TabIndex = 11;
            this.fld_dgcOwingInvoices.Tag = "DC";
            this.fld_dgcOwingInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcOwingInvoices;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_btnOwingFilter
            // 
            this.fld_btnOwingFilter.BOSComment = null;
            this.fld_btnOwingFilter.BOSDataMember = null;
            this.fld_btnOwingFilter.BOSDataSource = null;
            this.fld_btnOwingFilter.BOSDescription = null;
            this.fld_btnOwingFilter.BOSError = null;
            this.fld_btnOwingFilter.BOSFieldGroup = null;
            this.fld_btnOwingFilter.BOSFieldRelation = null;
            this.fld_btnOwingFilter.BOSPrivilege = null;
            this.fld_btnOwingFilter.BOSPropertyName = null;
            this.fld_btnOwingFilter.Location = new System.Drawing.Point(517, 5);
            this.fld_btnOwingFilter.Name = "fld_btnOwingFilter";
            this.fld_btnOwingFilter.Screen = null;
            this.fld_btnOwingFilter.Size = new System.Drawing.Size(81, 27);
            this.fld_btnOwingFilter.TabIndex = 3;
            this.fld_btnOwingFilter.Text = "Tìm kiếm";
            this.fld_btnOwingFilter.Click += new System.EventHandler(this.fld_btnOwingFilter_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_txtAPInvoiceInSupplierReference);
            this.panelControl2.Controls.Add(this.fld_lblLabel30);
            this.panelControl2.Controls.Add(this.fld_lblLabel26);
            this.panelControl2.Controls.Add(this.fld_btnOwingFilter);
            this.panelControl2.Controls.Add(this.fld_dteOwingDateFrom);
            this.panelControl2.Controls.Add(this.fld_txtAPInvoiceInNo);
            this.panelControl2.Controls.Add(this.fld_dteOwingDateTo);
            this.panelControl2.Controls.Add(this.fld_lblLabel28);
            this.panelControl2.Controls.Add(this.fld_lblLabel27);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(979, 70);
            this.panelControl2.TabIndex = 13;
            // 
            // fld_txtAPInvoiceInSupplierReference
            // 
            this.fld_txtAPInvoiceInSupplierReference.BOSComment = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSDataMember = "";
            this.fld_txtAPInvoiceInSupplierReference.BOSDataSource = "";
            this.fld_txtAPInvoiceInSupplierReference.BOSDescription = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSError = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSFieldGroup = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSFieldRelation = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSPrivilege = null;
            this.fld_txtAPInvoiceInSupplierReference.BOSPropertyName = null;
            this.fld_txtAPInvoiceInSupplierReference.Location = new System.Drawing.Point(110, 35);
            this.fld_txtAPInvoiceInSupplierReference.MenuManager = this.screenToolbar;
            this.fld_txtAPInvoiceInSupplierReference.Name = "fld_txtAPInvoiceInSupplierReference";
            this.fld_txtAPInvoiceInSupplierReference.Screen = null;
            this.fld_txtAPInvoiceInSupplierReference.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPInvoiceInSupplierReference.TabIndex = 4;
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.BOSComment = null;
            this.fld_lblLabel30.BOSDataMember = null;
            this.fld_lblLabel30.BOSDataSource = null;
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = null;
            this.fld_lblLabel30.BOSFieldRelation = null;
            this.fld_lblLabel30.BOSPrivilege = null;
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(10, 39);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.fld_lblLabel30.Size = new System.Drawing.Size(80, 13);
            this.fld_lblLabel30.TabIndex = 12;
            this.fld_lblLabel30.Text = "Mã hóa đơn NCC";
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(979, 704);
            this.bosPanel1.TabIndex = 15;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 70);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.bosTabControl1.Size = new System.Drawing.Size(979, 634);
            this.bosTabControl1.TabIndex = 14;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcOwingByCurrency);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(973, 606);
            this.xtraTabPage3.Text = "Thông tin công nợ";
            // 
            // fld_dgcOwingByCurrency
            // 
            this.fld_dgcOwingByCurrency.BOSComment = null;
            this.fld_dgcOwingByCurrency.BOSDataMember = null;
            this.fld_dgcOwingByCurrency.BOSDataSource = "OwingDetails";
            this.fld_dgcOwingByCurrency.BOSDescription = null;
            this.fld_dgcOwingByCurrency.BOSError = null;
            this.fld_dgcOwingByCurrency.BOSFieldGroup = null;
            this.fld_dgcOwingByCurrency.BOSFieldRelation = null;
            this.fld_dgcOwingByCurrency.BOSGridType = null;
            this.fld_dgcOwingByCurrency.BOSPrivilege = null;
            this.fld_dgcOwingByCurrency.BOSPropertyName = null;
            this.fld_dgcOwingByCurrency.CommodityType = "";
            this.fld_dgcOwingByCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcOwingByCurrency.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcOwingByCurrency.MenuManager = this.screenToolbar;
            this.fld_dgcOwingByCurrency.Name = "fld_dgcOwingByCurrency";
            this.fld_dgcOwingByCurrency.PrintReport = false;
            this.fld_dgcOwingByCurrency.Screen = null;
            this.fld_dgcOwingByCurrency.Size = new System.Drawing.Size(973, 606);
            this.fld_dgcOwingByCurrency.TabIndex = 1;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPanel2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(973, 606);
            this.xtraTabPage1.Text = "Chi tiết hóa đơn";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lblLabel29);
            this.bosPanel2.Controls.Add(this.fld_dgcOwingInvoices);
            this.bosPanel2.Controls.Add(this.fld_Line2);
            this.bosPanel2.Controls.Add(this.fld_dgcInvoicePaymentDetails);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(973, 606);
            this.bosPanel2.TabIndex = 11;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcSupplierPayments);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(973, 606);
            this.xtraTabPage2.Text = "Chi tiết thanh toán";
            // 
            // fld_dgcSupplierPayments
            // 
            this.fld_dgcSupplierPayments.BOSComment = null;
            this.fld_dgcSupplierPayments.BOSDataMember = null;
            this.fld_dgcSupplierPayments.BOSDataSource = "APSupplierPayments";
            this.fld_dgcSupplierPayments.BOSDescription = null;
            this.fld_dgcSupplierPayments.BOSError = null;
            this.fld_dgcSupplierPayments.BOSFieldGroup = null;
            this.fld_dgcSupplierPayments.BOSFieldRelation = null;
            this.fld_dgcSupplierPayments.BOSGridType = null;
            this.fld_dgcSupplierPayments.BOSPrivilege = null;
            this.fld_dgcSupplierPayments.BOSPropertyName = null;
            this.fld_dgcSupplierPayments.CommodityType = "";
            this.fld_dgcSupplierPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcSupplierPayments.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcSupplierPayments.MenuManager = this.screenToolbar;
            this.fld_dgcSupplierPayments.Name = "fld_dgcSupplierPayments";
            this.fld_dgcSupplierPayments.PrintReport = false;
            this.fld_dgcSupplierPayments.Screen = null;
            this.fld_dgcSupplierPayments.Size = new System.Drawing.Size(973, 606);
            this.fld_dgcSupplierPayments.TabIndex = 0;
            // 
            // DMSP102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(979, 704);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSP102";
            this.Text = "Quản lý công nợ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOwingDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInvoicePaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcOwingInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPInvoiceInSupplierReference.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcOwingByCurrency)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSupplierPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSButton fld_btnOwingFilter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSTextBox fld_txtAPInvoiceInSupplierReference;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSPanel bosPanel2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private OwingByCurrencyGridControl fld_dgcOwingByCurrency;
        private SupplierPaymentsGridControl fld_dgcSupplierPayments;
    }
}
