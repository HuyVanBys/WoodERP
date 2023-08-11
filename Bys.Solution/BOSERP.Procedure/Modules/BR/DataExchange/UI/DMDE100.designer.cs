using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DataExchange.UI
{
    /// <summary>
    /// Summary description for DMDE100
    /// </summary>
    partial class DMDE100
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
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_btnTransferEmployeeToBranch = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferCustomerToBranch = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferPreferencesToBranch = new BOSComponent.BOSButton(this.components);
            this.fld_btnTransferInventoryToBranch = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnTransferTransactionDataToBranch = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcBRBranchs = new BOSERP.Modules.DataExchange.BRBranchsGridControl();
            this.fld_dgvBRBranchs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnUpdateHistory = new BOSComponent.BOSButton(this.components);
            this.fld_dgcBRPostingHistorys = new BOSERP.Modules.DataExchange.BRPostingHistorysGridControl();
            this.fld_dgvBRPostingHistorys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRBranchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRBranchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRPostingHistorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRPostingHistorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(168, 121);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(194, 13);
            this.fld_lblLabel5.TabIndex = 15;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Bao gồm nhân viên và thiết lập bảo mật.";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(168, 210);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(182, 13);
            this.fld_lblLabel4.TabIndex = 14;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Bao gồm khách hàng, phiếu quà tặng.";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(168, 79);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(308, 13);
            this.fld_lblLabel3.TabIndex = 13;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Bao gồm những cấu hình về khách hàng, sản phẩm, bán hàng...";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(168, 175);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(209, 13);
            this.fld_lblLabel2.TabIndex = 12;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "thuộc tính, giá và chương trình khuyến mãi.";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(18, 36);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(188, 13);
            this.fld_lblLabel1.TabIndex = 11;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Chọn loại dữ liệu mà bạn muốn chuyển:";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(168, 154);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(313, 13);
            this.fld_lblLabel.TabIndex = 10;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Bao gồm kho, nhà cung cấp, ngành hàng, nhóm hàng, sản phẩm,";
            // 
            // fld_btnTransferEmployeeToBranch
            // 
            this.fld_btnTransferEmployeeToBranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferEmployeeToBranch.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferEmployeeToBranch.BOSComment = "";
            this.fld_btnTransferEmployeeToBranch.BOSDataMember = null;
            this.fld_btnTransferEmployeeToBranch.BOSDataSource = null;
            this.fld_btnTransferEmployeeToBranch.BOSDescription = null;
            this.fld_btnTransferEmployeeToBranch.BOSError = null;
            this.fld_btnTransferEmployeeToBranch.BOSFieldGroup = "";
            this.fld_btnTransferEmployeeToBranch.BOSFieldRelation = "";
            this.fld_btnTransferEmployeeToBranch.BOSPrivilege = "";
            this.fld_btnTransferEmployeeToBranch.BOSPropertyName = null;
            this.fld_btnTransferEmployeeToBranch.Location = new System.Drawing.Point(28, 115);
            this.fld_btnTransferEmployeeToBranch.Name = "fld_btnTransferEmployeeToBranch";
            this.fld_btnTransferEmployeeToBranch.Screen = null;
            this.fld_btnTransferEmployeeToBranch.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferEmployeeToBranch.TabIndex = 9;
            this.fld_btnTransferEmployeeToBranch.Tag = "";
            this.fld_btnTransferEmployeeToBranch.Text = "Nhân viên";
            this.fld_btnTransferEmployeeToBranch.Click += new System.EventHandler(this.fld_btnTransferEmployeeToBranch_Click);
            // 
            // fld_btnTransferCustomerToBranch
            // 
            this.fld_btnTransferCustomerToBranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferCustomerToBranch.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferCustomerToBranch.BOSComment = "";
            this.fld_btnTransferCustomerToBranch.BOSDataMember = null;
            this.fld_btnTransferCustomerToBranch.BOSDataSource = null;
            this.fld_btnTransferCustomerToBranch.BOSDescription = null;
            this.fld_btnTransferCustomerToBranch.BOSError = null;
            this.fld_btnTransferCustomerToBranch.BOSFieldGroup = "";
            this.fld_btnTransferCustomerToBranch.BOSFieldRelation = "";
            this.fld_btnTransferCustomerToBranch.BOSPrivilege = "";
            this.fld_btnTransferCustomerToBranch.BOSPropertyName = null;
            this.fld_btnTransferCustomerToBranch.Location = new System.Drawing.Point(28, 203);
            this.fld_btnTransferCustomerToBranch.Name = "fld_btnTransferCustomerToBranch";
            this.fld_btnTransferCustomerToBranch.Screen = null;
            this.fld_btnTransferCustomerToBranch.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferCustomerToBranch.TabIndex = 8;
            this.fld_btnTransferCustomerToBranch.Tag = "";
            this.fld_btnTransferCustomerToBranch.Text = "Khách hàng";
            this.fld_btnTransferCustomerToBranch.Click += new System.EventHandler(this.fld_btnTransferCustomerToBranch_Click);
            // 
            // fld_btnTransferPreferencesToBranch
            // 
            this.fld_btnTransferPreferencesToBranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferPreferencesToBranch.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferPreferencesToBranch.BOSComment = "";
            this.fld_btnTransferPreferencesToBranch.BOSDataMember = null;
            this.fld_btnTransferPreferencesToBranch.BOSDataSource = null;
            this.fld_btnTransferPreferencesToBranch.BOSDescription = null;
            this.fld_btnTransferPreferencesToBranch.BOSError = null;
            this.fld_btnTransferPreferencesToBranch.BOSFieldGroup = "";
            this.fld_btnTransferPreferencesToBranch.BOSFieldRelation = "";
            this.fld_btnTransferPreferencesToBranch.BOSPrivilege = "";
            this.fld_btnTransferPreferencesToBranch.BOSPropertyName = null;
            this.fld_btnTransferPreferencesToBranch.Location = new System.Drawing.Point(28, 72);
            this.fld_btnTransferPreferencesToBranch.Name = "fld_btnTransferPreferencesToBranch";
            this.fld_btnTransferPreferencesToBranch.Screen = null;
            this.fld_btnTransferPreferencesToBranch.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferPreferencesToBranch.TabIndex = 7;
            this.fld_btnTransferPreferencesToBranch.Tag = "";
            this.fld_btnTransferPreferencesToBranch.Text = "Cấu hình hệ thống";
            this.fld_btnTransferPreferencesToBranch.Click += new System.EventHandler(this.fld_btnTransferPreferencesToBranch_Click);
            // 
            // fld_btnTransferInventoryToBranch
            // 
            this.fld_btnTransferInventoryToBranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferInventoryToBranch.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferInventoryToBranch.BOSComment = "";
            this.fld_btnTransferInventoryToBranch.BOSDataMember = null;
            this.fld_btnTransferInventoryToBranch.BOSDataSource = null;
            this.fld_btnTransferInventoryToBranch.BOSDescription = null;
            this.fld_btnTransferInventoryToBranch.BOSError = null;
            this.fld_btnTransferInventoryToBranch.BOSFieldGroup = "";
            this.fld_btnTransferInventoryToBranch.BOSFieldRelation = "";
            this.fld_btnTransferInventoryToBranch.BOSPrivilege = "";
            this.fld_btnTransferInventoryToBranch.BOSPropertyName = null;
            this.fld_btnTransferInventoryToBranch.Location = new System.Drawing.Point(28, 158);
            this.fld_btnTransferInventoryToBranch.Name = "fld_btnTransferInventoryToBranch";
            this.fld_btnTransferInventoryToBranch.Screen = null;
            this.fld_btnTransferInventoryToBranch.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferInventoryToBranch.TabIndex = 6;
            this.fld_btnTransferInventoryToBranch.Tag = "";
            this.fld_btnTransferInventoryToBranch.Text = "Hàng tồn kho";
            this.fld_btnTransferInventoryToBranch.Click += new System.EventHandler(this.fld_btnTransferInventoryToBranch_Click);
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTransferInventoryToBranch);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTransferPreferencesToBranch);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTransferTransactionDataToBranch);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTransferCustomerToBranch);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTransferEmployeeToBranch);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(500, 594);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Text = "Chuyển từ trung tâm đến chi nhánh";
            // 
            // fld_btnTransferTransactionDataToBranch
            // 
            this.fld_btnTransferTransactionDataToBranch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTransferTransactionDataToBranch.Appearance.Options.UseForeColor = true;
            this.fld_btnTransferTransactionDataToBranch.BOSComment = "";
            this.fld_btnTransferTransactionDataToBranch.BOSDataMember = null;
            this.fld_btnTransferTransactionDataToBranch.BOSDataSource = null;
            this.fld_btnTransferTransactionDataToBranch.BOSDescription = null;
            this.fld_btnTransferTransactionDataToBranch.BOSError = null;
            this.fld_btnTransferTransactionDataToBranch.BOSFieldGroup = "";
            this.fld_btnTransferTransactionDataToBranch.BOSFieldRelation = "";
            this.fld_btnTransferTransactionDataToBranch.BOSPrivilege = "";
            this.fld_btnTransferTransactionDataToBranch.BOSPropertyName = null;
            this.fld_btnTransferTransactionDataToBranch.Enabled = false;
            this.fld_btnTransferTransactionDataToBranch.Location = new System.Drawing.Point(28, 251);
            this.fld_btnTransferTransactionDataToBranch.Name = "fld_btnTransferTransactionDataToBranch";
            this.fld_btnTransferTransactionDataToBranch.Screen = null;
            this.fld_btnTransferTransactionDataToBranch.Size = new System.Drawing.Size(125, 25);
            this.fld_btnTransferTransactionDataToBranch.TabIndex = 8;
            this.fld_btnTransferTransactionDataToBranch.Tag = "";
            this.fld_btnTransferTransactionDataToBranch.Text = "Các giao dịch";
            this.fld_btnTransferTransactionDataToBranch.Click += new System.EventHandler(this.fld_btnTransferAccountingDataToBranch_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(168, 258);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(292, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Bao gồm các giao dịch phát sinh sau lần chuyển đổi cuối cùng";
            // 
            // fld_dgcBRBranchs
            // 
            this.fld_dgcBRBranchs.AllowDrop = true;
            this.fld_dgcBRBranchs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBRBranchs.BOSComment = "";
            this.fld_dgcBRBranchs.BOSDataMember = null;
            this.fld_dgcBRBranchs.BOSDataSource = "BRBranchs";
            this.fld_dgcBRBranchs.BOSDescription = null;
            this.fld_dgcBRBranchs.BOSError = "";
            this.fld_dgcBRBranchs.BOSFieldGroup = "";
            this.fld_dgcBRBranchs.BOSFieldRelation = null;
            this.fld_dgcBRBranchs.BOSGridType = null;
            this.fld_dgcBRBranchs.BOSPrivilege = "";
            this.fld_dgcBRBranchs.BOSPropertyName = null;
            this.fld_dgcBRBranchs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcBRBranchs.Location = new System.Drawing.Point(9, 54);
            this.fld_dgcBRBranchs.MainView = this.fld_dgvBRBranchs;
            this.fld_dgcBRBranchs.Name = "fld_dgcBRBranchs";
            this.fld_dgcBRBranchs.Screen = null;
            this.fld_dgcBRBranchs.Size = new System.Drawing.Size(588, 196);
            this.fld_dgcBRBranchs.TabIndex = 18;
            this.fld_dgcBRBranchs.Tag = "DC";
            this.fld_dgcBRBranchs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvBRBranchs});
            // 
            // fld_dgvBRBranchs
            // 
            this.fld_dgvBRBranchs.GridControl = this.fld_dgcBRBranchs;
            this.fld_dgvBRBranchs.Name = "fld_dgvBRBranchs";
            this.fld_dgvBRBranchs.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(18, 32);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(187, 13);
            this.fld_lblLabel7.TabIndex = 17;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Chọn chi nhánh bạn muốn chuyển đến:";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcBRBranchs);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(508, 3);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(608, 255);
            this.fld_grcGroupControl1.TabIndex = 5;
            this.fld_grcGroupControl1.Text = "Danh sách chi nhánh";
            // 
            // fld_btnUpdateHistory
            // 
            this.fld_btnUpdateHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdateHistory.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateHistory.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateHistory.BOSComment = "";
            this.fld_btnUpdateHistory.BOSDataMember = null;
            this.fld_btnUpdateHistory.BOSDataSource = null;
            this.fld_btnUpdateHistory.BOSDescription = null;
            this.fld_btnUpdateHistory.BOSError = null;
            this.fld_btnUpdateHistory.BOSFieldGroup = "";
            this.fld_btnUpdateHistory.BOSFieldRelation = "";
            this.fld_btnUpdateHistory.BOSPrivilege = "";
            this.fld_btnUpdateHistory.BOSPropertyName = null;
            this.fld_btnUpdateHistory.Location = new System.Drawing.Point(511, 301);
            this.fld_btnUpdateHistory.Name = "fld_btnUpdateHistory";
            this.fld_btnUpdateHistory.Screen = null;
            this.fld_btnUpdateHistory.Size = new System.Drawing.Size(92, 27);
            this.fld_btnUpdateHistory.TabIndex = 21;
            this.fld_btnUpdateHistory.Tag = "";
            this.fld_btnUpdateHistory.Text = "Cập nhật";
            this.fld_btnUpdateHistory.Click += new System.EventHandler(this.fld_btnUpdateHistory_Click);
            // 
            // fld_dgcBRPostingHistorys
            // 
            this.fld_dgcBRPostingHistorys.AllowDrop = true;
            this.fld_dgcBRPostingHistorys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBRPostingHistorys.BOSComment = "";
            this.fld_dgcBRPostingHistorys.BOSDataMember = null;
            this.fld_dgcBRPostingHistorys.BOSDataSource = "BRPostingHistorys";
            this.fld_dgcBRPostingHistorys.BOSDescription = null;
            this.fld_dgcBRPostingHistorys.BOSError = "";
            this.fld_dgcBRPostingHistorys.BOSFieldGroup = "";
            this.fld_dgcBRPostingHistorys.BOSFieldRelation = null;
            this.fld_dgcBRPostingHistorys.BOSGridType = null;
            this.fld_dgcBRPostingHistorys.BOSPrivilege = "";
            this.fld_dgcBRPostingHistorys.BOSPropertyName = null;
            this.fld_dgcBRPostingHistorys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcBRPostingHistorys.Location = new System.Drawing.Point(3, 24);
            this.fld_dgcBRPostingHistorys.MainView = this.fld_dgvBRPostingHistorys;
            this.fld_dgcBRPostingHistorys.Name = "fld_dgcBRPostingHistorys";
            this.fld_dgcBRPostingHistorys.Screen = null;
            this.fld_dgcBRPostingHistorys.Size = new System.Drawing.Size(603, 271);
            this.fld_dgcBRPostingHistorys.TabIndex = 19;
            this.fld_dgcBRPostingHistorys.Tag = "DC";
            this.fld_dgcBRPostingHistorys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvBRPostingHistorys});
            // 
            // fld_dgvBRPostingHistorys
            // 
            this.fld_dgvBRPostingHistorys.GridControl = this.fld_dgcBRPostingHistorys;
            this.fld_dgvBRPostingHistorys.Name = "fld_dgvBRPostingHistorys";
            this.fld_dgvBRPostingHistorys.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.BOSComment = "";
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "";
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = "";
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcBRPostingHistorys);
            this.fld_grcGroupControl3.Controls.Add(this.fld_btnUpdateHistory);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(508, 264);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(608, 333);
            this.fld_grcGroupControl3.TabIndex = 20;
            this.fld_grcGroupControl3.Text = "Lịch sử chuyển đổi";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1119, 608);
            this.bosPanel1.TabIndex = 21;
            // 
            // DMDE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1119, 608);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDE100";
            this.Text = "Chuyển đổi dữ liệu (tại trung tâm)";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRBranchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRBranchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRPostingHistorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRPostingHistorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSButton fld_btnTransferEmployeeToBranch;
        private BOSComponent.BOSButton fld_btnTransferCustomerToBranch;
        private BOSComponent.BOSButton fld_btnTransferPreferencesToBranch;
        private BOSComponent.BOSButton fld_btnTransferInventoryToBranch;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BRBranchsGridControl fld_dgcBRBranchs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvBRBranchs;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSButton fld_btnUpdateHistory;
        private BRPostingHistorysGridControl fld_dgcBRPostingHistorys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvBRPostingHistorys;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSButton fld_btnTransferTransactionDataToBranch;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSPanel bosPanel1;
    }
}
