using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU102
    /// </summary>
    partial class DMCU102
    {
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSButton fld_btnFilter1;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLine fld_Line3;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private ARInvoicePaymentDetailsGridControl fld_dgcARInvoicePaymentDetailsGridControl;
        private AROwingInvoicesGridControl fld_dgcAROwingInvoicesGridControl;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo;


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
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFilter1 = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARInvoicePaymentDetailsGridControl = new BOSERP.Modules.Customer.ARInvoicePaymentDetailsGridControl();
            this.fld_dgcAROwingInvoicesGridControl = new BOSERP.Modules.Customer.AROwingInvoicesGridControl();
            this.fld_txtARInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcCustomerPayments = new BOSERP.Modules.Customer.CustomerPaymentGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoicePaymentDetailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAROwingInvoicesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dteSearchFromARInvoiceDate
            // 
            this.fld_dteSearchFromARInvoiceDate.BOSComment = "";
            this.fld_dteSearchFromARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchFromARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchFromARInvoiceDate.BOSError = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARInvoiceDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARInvoiceDate.BOSPrivilege = "";
            this.fld_dteSearchFromARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARInvoiceDate.EditValue = null;
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(84, 8);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 0;
            this.fld_dteSearchFromARInvoiceDate.Tag = "DC";
            // 
            // fld_dteSearchToARInvoiceDate
            // 
            this.fld_dteSearchToARInvoiceDate.BOSComment = "";
            this.fld_dteSearchToARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchToARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchToARInvoiceDate.BOSError = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldGroup = "";
            this.fld_dteSearchToARInvoiceDate.BOSFieldRelation = "";
            this.fld_dteSearchToARInvoiceDate.BOSPrivilege = "";
            this.fld_dteSearchToARInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARInvoiceDate.EditValue = null;
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(283, 8);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 1;
            this.fld_dteSearchToARInvoiceDate.Tag = "DC";
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = "";
            this.fld_lblLabel20.BOSDataMember = "";
            this.fld_lblLabel20.BOSDataSource = "";
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = "";
            this.fld_lblLabel20.BOSFieldRelation = "";
            this.fld_lblLabel20.BOSPrivilege = "";
            this.fld_lblLabel20.BOSPropertyName = "";
            this.fld_lblLabel20.Location = new System.Drawing.Point(12, 11);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 6;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = "";
            this.fld_lblLabel22.Location = new System.Drawing.Point(244, 11);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 7;
            this.fld_lblLabel22.Tag = "";
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_btnFilter1
            // 
            this.fld_btnFilter1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnFilter1.Appearance.Options.UseForeColor = true;
            this.fld_btnFilter1.BOSComment = "";
            this.fld_btnFilter1.BOSDataMember = "";
            this.fld_btnFilter1.BOSDataSource = "";
            this.fld_btnFilter1.BOSDescription = null;
            this.fld_btnFilter1.BOSError = null;
            this.fld_btnFilter1.BOSFieldGroup = "";
            this.fld_btnFilter1.BOSFieldRelation = "";
            this.fld_btnFilter1.BOSPrivilege = "";
            this.fld_btnFilter1.BOSPropertyName = "";
            this.fld_btnFilter1.Location = new System.Drawing.Point(442, 5);
            this.fld_btnFilter1.Name = "fld_btnFilter1";
            this.fld_btnFilter1.Screen = null;
            this.fld_btnFilter1.Size = new System.Drawing.Size(75, 27);
            this.fld_btnFilter1.TabIndex = 3;
            this.fld_btnFilter1.Tag = "";
            this.fld_btnFilter1.Text = "Tìm kiếm";
            this.fld_btnFilter1.Click += new System.EventHandler(this.fld_btnFilter_Click);
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(12, 40);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel26.TabIndex = 11;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Mã hóa đơn";
            // 
            // fld_Line3
            // 
            this.fld_Line3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Line3.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.BOSComment = "";
            this.fld_Line3.BOSDataMember = "";
            this.fld_Line3.BOSDataSource = "";
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = "";
            this.fld_Line3.BOSFieldRelation = "";
            this.fld_Line3.BOSPrivilege = "";
            this.fld_Line3.BOSPropertyName = "";
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(110, 279);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(759, 10);
            this.fld_Line3.TabIndex = 14;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Tag = "";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(9, 276);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(105, 13);
            this.fld_lblLabel27.TabIndex = 15;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Chi tiết thanh toán";
            // 
            // fld_dgcARInvoicePaymentDetailsGridControl
            // 
            this.fld_dgcARInvoicePaymentDetailsGridControl.AllowDrop = true;
            this.fld_dgcARInvoicePaymentDetailsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSComment = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSDataMember = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSDataSource = "ARDocumentPayments";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSDescription = null;
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSError = null;
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSFieldGroup = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSFieldRelation = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSGridType = null;
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSPrivilege = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.BOSPropertyName = "";
            this.fld_dgcARInvoicePaymentDetailsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoicePaymentDetailsGridControl.Location = new System.Drawing.Point(7, 299);
            this.fld_dgcARInvoicePaymentDetailsGridControl.Name = "fld_dgcARInvoicePaymentDetailsGridControl";
            this.fld_dgcARInvoicePaymentDetailsGridControl.Screen = null;
            this.fld_dgcARInvoicePaymentDetailsGridControl.Size = new System.Drawing.Size(858, 175);
            this.fld_dgcARInvoicePaymentDetailsGridControl.TabIndex = 12;
            this.fld_dgcARInvoicePaymentDetailsGridControl.Tag = "DC";
            // 
            // fld_dgcAROwingInvoicesGridControl
            // 
            this.fld_dgcAROwingInvoicesGridControl.AllowDrop = true;
            this.fld_dgcAROwingInvoicesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAROwingInvoicesGridControl.BOSComment = "";
            this.fld_dgcAROwingInvoicesGridControl.BOSDataMember = "";
            this.fld_dgcAROwingInvoicesGridControl.BOSDataSource = "ARInvoices";
            this.fld_dgcAROwingInvoicesGridControl.BOSDescription = null;
            this.fld_dgcAROwingInvoicesGridControl.BOSError = null;
            this.fld_dgcAROwingInvoicesGridControl.BOSFieldGroup = "";
            this.fld_dgcAROwingInvoicesGridControl.BOSFieldRelation = "";
            this.fld_dgcAROwingInvoicesGridControl.BOSGridType = null;
            this.fld_dgcAROwingInvoicesGridControl.BOSPrivilege = "";
            this.fld_dgcAROwingInvoicesGridControl.BOSPropertyName = "";
            this.fld_dgcAROwingInvoicesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAROwingInvoicesGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcAROwingInvoicesGridControl.Name = "fld_dgcAROwingInvoicesGridControl";
            this.fld_dgcAROwingInvoicesGridControl.Screen = null;
            this.fld_dgcAROwingInvoicesGridControl.Size = new System.Drawing.Size(866, 261);
            this.fld_dgcAROwingInvoicesGridControl.TabIndex = 9;
            this.fld_dgcAROwingInvoicesGridControl.Tag = "DC";
            // 
            // fld_txtARInvoiceNo
            // 
            this.fld_txtARInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceNo.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo.BOSDataSource = "ARInvoices";
            this.fld_txtARInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceNo.BOSPropertyName = "Text";
            this.fld_txtARInvoiceNo.EditValue = "";
            this.fld_txtARInvoiceNo.Location = new System.Drawing.Point(84, 37);
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceNo.Screen = null;
            this.fld_txtARInvoiceNo.Size = new System.Drawing.Size(130, 20);
            this.fld_txtARInvoiceNo.TabIndex = 2;
            this.fld_txtARInvoiceNo.Tag = "DC";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_lblLabel20);
            this.panelControl2.Controls.Add(this.fld_txtARInvoiceNo);
            this.panelControl2.Controls.Add(this.fld_btnFilter1);
            this.panelControl2.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl2.Controls.Add(this.fld_lblLabel26);
            this.panelControl2.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl2.Controls.Add(this.fld_lblLabel22);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(882, 73);
            this.panelControl2.TabIndex = 20;
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
            this.bosPanel1.Size = new System.Drawing.Size(882, 589);
            this.bosPanel1.TabIndex = 21;
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 79);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(876, 507);
            this.bosTabControl1.TabIndex = 21;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcAROwingInvoicesGridControl);
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel27);
            this.xtraTabPage1.Controls.Add(this.fld_Line3);
            this.xtraTabPage1.Controls.Add(this.fld_dgcARInvoicePaymentDetailsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(869, 478);
            this.xtraTabPage1.Text = "Chi tiết hóa đơn";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcCustomerPayments);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(869, 478);
            this.xtraTabPage2.Text = "Chi tiết thanh toán";
            // 
            // fld_dgcCustomerPayments
            // 
            this.fld_dgcCustomerPayments.BOSComment = null;
            this.fld_dgcCustomerPayments.BOSDataMember = null;
            this.fld_dgcCustomerPayments.BOSDataSource = "ARCustomerPayments";
            this.fld_dgcCustomerPayments.BOSDescription = null;
            this.fld_dgcCustomerPayments.BOSError = null;
            this.fld_dgcCustomerPayments.BOSFieldGroup = null;
            this.fld_dgcCustomerPayments.BOSFieldRelation = null;
            this.fld_dgcCustomerPayments.BOSGridType = null;
            this.fld_dgcCustomerPayments.BOSPrivilege = null;
            this.fld_dgcCustomerPayments.BOSPropertyName = null;
            this.fld_dgcCustomerPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCustomerPayments.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcCustomerPayments.MenuManager = this.screenToolbar;
            this.fld_dgcCustomerPayments.Name = "fld_dgcCustomerPayments";
            this.fld_dgcCustomerPayments.Screen = null;
            this.fld_dgcCustomerPayments.Size = new System.Drawing.Size(869, 478);
            this.fld_dgcCustomerPayments.TabIndex = 0;
            // 
            // DMCU102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(882, 589);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCU102";
            this.Text = "Quản lý công nợ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoicePaymentDetailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAROwingInvoicesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPayments)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private CustomerPaymentGridControl fld_dgcCustomerPayments;
    }
}
