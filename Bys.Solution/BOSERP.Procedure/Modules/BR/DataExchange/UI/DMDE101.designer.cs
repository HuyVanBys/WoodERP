using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DataExchange.UI
{
    /// <summary>
    /// Summary description for DMDE101
    /// </summary>
    partial class DMDE101
    {
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSComponent.BOSButton fld_btnTransferInventoryToCentre;
        private BOSComponent.BOSButton fld_btnTransferSaleDataToCentre;
        private BOSComponent.BOSButton fld_btnTransferCustomerToCentre;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLabel fld_lblLabel11;


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
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnTransferInventoryToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferAccountInitDataToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferStaffToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferAccountingDataToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferPurchaseDataToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferSaleDataToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferCustomerToCentre = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRegionalPostingHistory = new BOSERP.Modules.DataExchange.RegionalPostingHistoryGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnUpdateRegionalPostingHistory = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRegionalPostingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = null;
            this.fld_grcGroupControl2.BOSDataSource = null;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = null;
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = null;
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferInventoryToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferAccountInitDataToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferStaffToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferAccountingDataToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferPurchaseDataToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferSaleDataToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnTransferCustomerToCentre);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel9);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel10);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(7, 7);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(546, 390);
            this.fld_grcGroupControl2.TabIndex = 4;
            this.fld_grcGroupControl2.Text = "Chuyển từ chi nhánh đến trung tâm";
            // 
            // fld_btnTransferInventoryToCentre
            // 
            this.fld_btnTransferInventoryToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferInventoryToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferInventoryToCentre.BOSComment = "";
            this.fld_btnTransferInventoryToCentre.BOSDataMember = null;
            this.fld_btnTransferInventoryToCentre.BOSDataSource = null;
            this.fld_btnTransferInventoryToCentre.BOSDescription = null;
            this.fld_btnTransferInventoryToCentre.BOSError = null;
            this.fld_btnTransferInventoryToCentre.BOSFieldGroup = "";
            this.fld_btnTransferInventoryToCentre.BOSFieldRelation = "";
            this.fld_btnTransferInventoryToCentre.BOSPrivilege = "";
            this.fld_btnTransferInventoryToCentre.BOSPropertyName = null;
            this.fld_btnTransferInventoryToCentre.Enabled = false;
            this.fld_btnTransferInventoryToCentre.Location = new System.Drawing.Point(22, 109);
            this.fld_btnTransferInventoryToCentre.Name = "fld_btnTransferInventoryToCentre";
            this.fld_btnTransferInventoryToCentre.Screen = null;
            this.fld_btnTransferInventoryToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferInventoryToCentre.TabIndex = 2;
            this.fld_btnTransferInventoryToCentre.Tag = "";
            this.fld_btnTransferInventoryToCentre.Text = "Hàng tồn kho";
            this.fld_btnTransferInventoryToCentre.Click += new System.EventHandler(this.fld_btnTransferInventoryToCentre_Click);
            // 
            // fld_btnTransferAccountInitDataToCentre
            // 
            this.fld_btnTransferAccountInitDataToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferAccountInitDataToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferAccountInitDataToCentre.BOSComment = "";
            this.fld_btnTransferAccountInitDataToCentre.BOSDataMember = null;
            this.fld_btnTransferAccountInitDataToCentre.BOSDataSource = null;
            this.fld_btnTransferAccountInitDataToCentre.BOSDescription = null;
            this.fld_btnTransferAccountInitDataToCentre.BOSError = null;
            this.fld_btnTransferAccountInitDataToCentre.BOSFieldGroup = "";
            this.fld_btnTransferAccountInitDataToCentre.BOSFieldRelation = "";
            this.fld_btnTransferAccountInitDataToCentre.BOSPrivilege = "";
            this.fld_btnTransferAccountInitDataToCentre.BOSPropertyName = null;
            this.fld_btnTransferAccountInitDataToCentre.Location = new System.Drawing.Point(22, 296);
            this.fld_btnTransferAccountInitDataToCentre.Name = "fld_btnTransferAccountInitDataToCentre";
            this.fld_btnTransferAccountInitDataToCentre.Screen = null;
            this.fld_btnTransferAccountInitDataToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferAccountInitDataToCentre.TabIndex = 6;
            this.fld_btnTransferAccountInitDataToCentre.Tag = "";
            this.fld_btnTransferAccountInitDataToCentre.Text = "Số dư ban đầu";
            this.fld_btnTransferAccountInitDataToCentre.Click += new System.EventHandler(this.fld_btnTransferAccountInitDataToCentre_Click);
            // 
            // fld_btnTransferStaffToCentre
            // 
            this.fld_btnTransferStaffToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferStaffToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferStaffToCentre.BOSComment = "";
            this.fld_btnTransferStaffToCentre.BOSDataMember = null;
            this.fld_btnTransferStaffToCentre.BOSDataSource = null;
            this.fld_btnTransferStaffToCentre.BOSDescription = null;
            this.fld_btnTransferStaffToCentre.BOSError = null;
            this.fld_btnTransferStaffToCentre.BOSFieldGroup = "";
            this.fld_btnTransferStaffToCentre.BOSFieldRelation = "";
            this.fld_btnTransferStaffToCentre.BOSPrivilege = "";
            this.fld_btnTransferStaffToCentre.BOSPropertyName = null;
            this.fld_btnTransferStaffToCentre.Location = new System.Drawing.Point(22, 344);
            this.fld_btnTransferStaffToCentre.Name = "fld_btnTransferStaffToCentre";
            this.fld_btnTransferStaffToCentre.Screen = null;
            this.fld_btnTransferStaffToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferStaffToCentre.TabIndex = 6;
            this.fld_btnTransferStaffToCentre.Tag = "";
            this.fld_btnTransferStaffToCentre.Text = "Nhân sự";
            this.fld_btnTransferStaffToCentre.Click += new System.EventHandler(this.fld_btnTransferStaffToCentre_Click);
            // 
            // fld_btnTransferAccountingDataToCentre
            // 
            this.fld_btnTransferAccountingDataToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferAccountingDataToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferAccountingDataToCentre.BOSComment = "";
            this.fld_btnTransferAccountingDataToCentre.BOSDataMember = null;
            this.fld_btnTransferAccountingDataToCentre.BOSDataSource = null;
            this.fld_btnTransferAccountingDataToCentre.BOSDescription = null;
            this.fld_btnTransferAccountingDataToCentre.BOSError = null;
            this.fld_btnTransferAccountingDataToCentre.BOSFieldGroup = "";
            this.fld_btnTransferAccountingDataToCentre.BOSFieldRelation = "";
            this.fld_btnTransferAccountingDataToCentre.BOSPrivilege = "";
            this.fld_btnTransferAccountingDataToCentre.BOSPropertyName = null;
            this.fld_btnTransferAccountingDataToCentre.Enabled = false;
            this.fld_btnTransferAccountingDataToCentre.Location = new System.Drawing.Point(22, 246);
            this.fld_btnTransferAccountingDataToCentre.Name = "fld_btnTransferAccountingDataToCentre";
            this.fld_btnTransferAccountingDataToCentre.Screen = null;
            this.fld_btnTransferAccountingDataToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferAccountingDataToCentre.TabIndex = 5;
            this.fld_btnTransferAccountingDataToCentre.Tag = "";
            this.fld_btnTransferAccountingDataToCentre.Text = "Kế toán";
            this.fld_btnTransferAccountingDataToCentre.Click += new System.EventHandler(this.fld_btnTransferAccountingDataToCentre_Click);
            // 
            // fld_btnTransferPurchaseDataToCentre
            // 
            this.fld_btnTransferPurchaseDataToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferPurchaseDataToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferPurchaseDataToCentre.BOSComment = "";
            this.fld_btnTransferPurchaseDataToCentre.BOSDataMember = null;
            this.fld_btnTransferPurchaseDataToCentre.BOSDataSource = null;
            this.fld_btnTransferPurchaseDataToCentre.BOSDescription = null;
            this.fld_btnTransferPurchaseDataToCentre.BOSError = null;
            this.fld_btnTransferPurchaseDataToCentre.BOSFieldGroup = "";
            this.fld_btnTransferPurchaseDataToCentre.BOSFieldRelation = "";
            this.fld_btnTransferPurchaseDataToCentre.BOSPrivilege = "";
            this.fld_btnTransferPurchaseDataToCentre.BOSPropertyName = null;
            this.fld_btnTransferPurchaseDataToCentre.Enabled = false;
            this.fld_btnTransferPurchaseDataToCentre.Location = new System.Drawing.Point(22, 199);
            this.fld_btnTransferPurchaseDataToCentre.Name = "fld_btnTransferPurchaseDataToCentre";
            this.fld_btnTransferPurchaseDataToCentre.Screen = null;
            this.fld_btnTransferPurchaseDataToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferPurchaseDataToCentre.TabIndex = 4;
            this.fld_btnTransferPurchaseDataToCentre.Tag = "";
            this.fld_btnTransferPurchaseDataToCentre.Text = "Mua hàng";
            this.fld_btnTransferPurchaseDataToCentre.Click += new System.EventHandler(this.fld_btnTransferPurchaseDataToCentre_Click);
            // 
            // fld_btnTransferSaleDataToCentre
            // 
            this.fld_btnTransferSaleDataToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferSaleDataToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferSaleDataToCentre.BOSComment = "";
            this.fld_btnTransferSaleDataToCentre.BOSDataMember = null;
            this.fld_btnTransferSaleDataToCentre.BOSDataSource = null;
            this.fld_btnTransferSaleDataToCentre.BOSDescription = null;
            this.fld_btnTransferSaleDataToCentre.BOSError = null;
            this.fld_btnTransferSaleDataToCentre.BOSFieldGroup = "";
            this.fld_btnTransferSaleDataToCentre.BOSFieldRelation = "";
            this.fld_btnTransferSaleDataToCentre.BOSPrivilege = "";
            this.fld_btnTransferSaleDataToCentre.BOSPropertyName = null;
            this.fld_btnTransferSaleDataToCentre.Enabled = false;
            this.fld_btnTransferSaleDataToCentre.Location = new System.Drawing.Point(22, 153);
            this.fld_btnTransferSaleDataToCentre.Name = "fld_btnTransferSaleDataToCentre";
            this.fld_btnTransferSaleDataToCentre.Screen = null;
            this.fld_btnTransferSaleDataToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferSaleDataToCentre.TabIndex = 3;
            this.fld_btnTransferSaleDataToCentre.Tag = "";
            this.fld_btnTransferSaleDataToCentre.Text = "Bán hàng";
            this.fld_btnTransferSaleDataToCentre.Click += new System.EventHandler(this.fld_btnTransferSaleDataToCentre_Click);
            // 
            // fld_btnTransferCustomerToCentre
            // 
            this.fld_btnTransferCustomerToCentre.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferCustomerToCentre.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferCustomerToCentre.BOSComment = "";
            this.fld_btnTransferCustomerToCentre.BOSDataMember = null;
            this.fld_btnTransferCustomerToCentre.BOSDataSource = null;
            this.fld_btnTransferCustomerToCentre.BOSDescription = null;
            this.fld_btnTransferCustomerToCentre.BOSError = null;
            this.fld_btnTransferCustomerToCentre.BOSFieldGroup = "";
            this.fld_btnTransferCustomerToCentre.BOSFieldRelation = "";
            this.fld_btnTransferCustomerToCentre.BOSPrivilege = "";
            this.fld_btnTransferCustomerToCentre.BOSPropertyName = null;
            this.fld_btnTransferCustomerToCentre.Location = new System.Drawing.Point(22, 65);
            this.fld_btnTransferCustomerToCentre.Name = "fld_btnTransferCustomerToCentre";
            this.fld_btnTransferCustomerToCentre.Screen = null;
            this.fld_btnTransferCustomerToCentre.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferCustomerToCentre.TabIndex = 1;
            this.fld_btnTransferCustomerToCentre.Tag = "";
            this.fld_btnTransferCustomerToCentre.Text = "Khách hàng";
            this.fld_btnTransferCustomerToCentre.Click += new System.EventHandler(this.fld_btnTransferCustomerToCentre_Click);
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(17, 38);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(188, 13);
            this.fld_lblLabel8.TabIndex = 8;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Chọn loại dữ liệu mà bạn muốn chuyển:";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(170, 115);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(149, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Bao gồm tồn kho của chi nhánh";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(170, 71);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(369, 13);
            this.fld_lblLabel10.TabIndex = 10;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Bao gồm khách hàng, phiếu quà tặng phát sinh sau lần chuyển đổi cuối cùng.";
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(170, 303);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(113, 13);
            this.bosLabel4.TabIndex = 11;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Bao gồm số dư ban đầu";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
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
            this.bosLabel3.Location = new System.Drawing.Point(170, 350);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(305, 13);
            this.bosLabel3.TabIndex = 11;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Bao gồm dữ liệu nhân sự phát sinh sau lần chuyển đổi cuối cùng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(170, 252);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(302, 13);
            this.bosLabel2.TabIndex = 11;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Bao gồm dữ liệu kế toán phát sinh sau lần chuyển đổi cuối cùng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(170, 206);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(313, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Bao gồm dữ liệu mua hàng phát sinh sau lần chuyển đổi cuối cùng";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(170, 159);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(311, 13);
            this.fld_lblLabel11.TabIndex = 11;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Bao gồm dữ liệu bán hàng phát sinh sau lần chuyển đổi cuối cùng";
            // 
            // fld_dgcRegionalPostingHistory
            // 
            this.fld_dgcRegionalPostingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRegionalPostingHistory.BOSComment = null;
            this.fld_dgcRegionalPostingHistory.BOSDataMember = null;
            this.fld_dgcRegionalPostingHistory.BOSDataSource = "BRPostingHistorys";
            this.fld_dgcRegionalPostingHistory.BOSDescription = null;
            this.fld_dgcRegionalPostingHistory.BOSError = null;
            this.fld_dgcRegionalPostingHistory.BOSFieldGroup = null;
            this.fld_dgcRegionalPostingHistory.BOSFieldRelation = null;
            this.fld_dgcRegionalPostingHistory.BOSGridType = null;
            this.fld_dgcRegionalPostingHistory.BOSPrivilege = null;
            this.fld_dgcRegionalPostingHistory.BOSPropertyName = null;
            this.fld_dgcRegionalPostingHistory.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcRegionalPostingHistory.MenuManager = this.screenToolbar;
            this.fld_dgcRegionalPostingHistory.Name = "fld_dgcRegionalPostingHistory";
            this.fld_dgcRegionalPostingHistory.Screen = null;
            this.fld_dgcRegionalPostingHistory.Size = new System.Drawing.Size(517, 330);
            this.fld_dgcRegionalPostingHistory.TabIndex = 6;
            this.fld_dgcRegionalPostingHistory.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_btnUpdateRegionalPostingHistory);
            this.bosGroupControl1.Controls.Add(this.fld_dgcRegionalPostingHistory);
            this.bosGroupControl1.Location = new System.Drawing.Point(559, 7);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(521, 390);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Text = "Lịch sử chuyển đổi";            
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1088, 405);
            this.bosPanel1.TabIndex = 12;
            // 
            // fld_btnUpdateRegionalPostingHistory
            // 
            this.fld_btnUpdateRegionalPostingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdateRegionalPostingHistory.BOSComment = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSDataMember = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSDataSource = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSDescription = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSError = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSFieldGroup = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSFieldRelation = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSPrivilege = null;
            this.fld_btnUpdateRegionalPostingHistory.BOSPropertyName = null;
            this.fld_btnUpdateRegionalPostingHistory.Location = new System.Drawing.Point(432, 358);
            this.fld_btnUpdateRegionalPostingHistory.Name = "fld_btnUpdateRegionalPostingHistory";
            this.fld_btnUpdateRegionalPostingHistory.Screen = null;
            this.fld_btnUpdateRegionalPostingHistory.Size = new System.Drawing.Size(84, 27);
            this.fld_btnUpdateRegionalPostingHistory.TabIndex = 7;
            this.fld_btnUpdateRegionalPostingHistory.Text = "Cập nhật";
            this.fld_btnUpdateRegionalPostingHistory.Click += new System.EventHandler(this.fld_btnUpdateRegionalPostingHistory_Click);
            // 
            // DMDE101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1088, 405);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDE101";
            this.Text = "Chuyển đổi dữ liệu (tại chi nhánh)";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            this.fld_grcGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRegionalPostingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSButton fld_btnTransferAccountingDataToCentre;
        private BOSComponent.BOSButton fld_btnTransferPurchaseDataToCentre;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnTransferStaffToCentre;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnTransferAccountInitDataToCentre;
        private BOSComponent.BOSLabel bosLabel4;
        private RegionalPostingHistoryGridControl fld_dgcRegionalPostingHistory;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnUpdateRegionalPostingHistory;
    }
}
