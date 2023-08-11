namespace BOSERP.Modules.SaleOrder
{
    partial class guiAddSalesman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddSalesman));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSalesmans = new BOSERP.Modules.SaleOrder.ARSalesmansGridControl();
            this.fld_dgvARDocumentPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel91 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbCommissionPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSalesmans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lbCommissionPercent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(301, 237);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(382, 237);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcARSalesmans
            // 
            this.fld_dgcARSalesmans.AllowDrop = true;
            this.fld_dgcARSalesmans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSalesmans.BOSComment = "";
            this.fld_dgcARSalesmans.BOSDataMember = "";
            this.fld_dgcARSalesmans.BOSDataSource = "ARSalesmans";
            this.fld_dgcARSalesmans.BOSDescription = null;
            this.fld_dgcARSalesmans.BOSError = null;
            this.fld_dgcARSalesmans.BOSFieldGroup = "";
            this.fld_dgcARSalesmans.BOSFieldRelation = "";
            this.fld_dgcARSalesmans.BOSGridType = null;
            this.fld_dgcARSalesmans.BOSPrivilege = "";
            this.fld_dgcARSalesmans.BOSPropertyName = "";
            this.fld_dgcARSalesmans.CommodityType = "";
            this.fld_dgcARSalesmans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSalesmans.Location = new System.Drawing.Point(0, 44);
            this.fld_dgcARSalesmans.MainView = this.fld_dgvARDocumentPayments;
            this.fld_dgcARSalesmans.Name = "fld_dgcARSalesmans";
            this.fld_dgcARSalesmans.PrintReport = false;
            this.fld_dgcARSalesmans.Screen = null;
            this.fld_dgcARSalesmans.Size = new System.Drawing.Size(469, 182);
            this.fld_dgcARSalesmans.TabIndex = 6;
            this.fld_dgcARSalesmans.Tag = "DC";
            this.fld_dgcARSalesmans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARDocumentPayments});
            // 
            // fld_dgvARDocumentPayments
            // 
            this.fld_dgvARDocumentPayments.GridControl = this.fld_dgcARSalesmans;
            this.fld_dgvARDocumentPayments.Name = "fld_dgvARDocumentPayments";
            this.fld_dgvARDocumentPayments.PaintStyleName = "Office2003";
            // 
            // fld_lkeARSellerID
            // 
            this.fld_lkeARSellerID.BOSAllowAddNew = false;
            this.fld_lkeARSellerID.BOSAllowDummy = false;
            this.fld_lkeARSellerID.BOSComment = null;
            this.fld_lkeARSellerID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeARSellerID.BOSDataSource = "ARSalesmans";
            this.fld_lkeARSellerID.BOSDescription = null;
            this.fld_lkeARSellerID.BOSError = null;
            this.fld_lkeARSellerID.BOSFieldGroup = null;
            this.fld_lkeARSellerID.BOSFieldParent = null;
            this.fld_lkeARSellerID.BOSFieldRelation = null;
            this.fld_lkeARSellerID.BOSPrivilege = null;
            this.fld_lkeARSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeARSellerID.BOSSelectType = null;
            this.fld_lkeARSellerID.BOSSelectTypeValue = null;
            this.fld_lkeARSellerID.CurrentDisplayText = null;
            this.fld_lkeARSellerID.Location = new System.Drawing.Point(64, 12);
            this.fld_lkeARSellerID.Name = "fld_lkeARSellerID";
            this.fld_lkeARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSellerID.Properties.ColumnName = null;
            this.fld_lkeARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeARSellerID.Properties.NullText = "";
            this.fld_lkeARSellerID.Properties.PopupWidth = 40;
            this.fld_lkeARSellerID.Properties.ReadOnly = true;
            this.fld_lkeARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeARSellerID.Screen = null;
            this.fld_lkeARSellerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSellerID.TabIndex = 676;
            this.fld_lkeARSellerID.Tag = "DC";
            // 
            // bosLabel91
            // 
            this.bosLabel91.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel91.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel91.Appearance.Options.UseBackColor = true;
            this.bosLabel91.Appearance.Options.UseForeColor = true;
            this.bosLabel91.BOSComment = null;
            this.bosLabel91.BOSDataMember = null;
            this.bosLabel91.BOSDataSource = null;
            this.bosLabel91.BOSDescription = null;
            this.bosLabel91.BOSError = null;
            this.bosLabel91.BOSFieldGroup = null;
            this.bosLabel91.BOSFieldRelation = null;
            this.bosLabel91.BOSPrivilege = null;
            this.bosLabel91.BOSPropertyName = null;
            this.bosLabel91.Location = new System.Drawing.Point(9, 15);
            this.bosLabel91.Name = "bosLabel91";
            this.bosLabel91.Screen = null;
            this.bosLabel91.Size = new System.Drawing.Size(49, 13);
            this.bosLabel91.TabIndex = 677;
            this.bosLabel91.Text = "Người bán";
            // 
            // fld_lbCommissionPercent
            // 
            this.fld_lbCommissionPercent.BOSComment = null;
            this.fld_lbCommissionPercent.BOSDataMember = "ARSalesmanCommissionPercent";
            this.fld_lbCommissionPercent.BOSDataSource = "ARSalesmans";
            this.fld_lbCommissionPercent.BOSDescription = null;
            this.fld_lbCommissionPercent.BOSError = null;
            this.fld_lbCommissionPercent.BOSFieldGroup = null;
            this.fld_lbCommissionPercent.BOSFieldRelation = null;
            this.fld_lbCommissionPercent.BOSPrivilege = null;
            this.fld_lbCommissionPercent.BOSPropertyName = "EditValue";
            this.fld_lbCommissionPercent.Location = new System.Drawing.Point(301, 12);
            this.fld_lbCommissionPercent.Name = "fld_lbCommissionPercent";
            this.fld_lbCommissionPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbCommissionPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbCommissionPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lbCommissionPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lbCommissionPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lbCommissionPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lbCommissionPercent.Properties.Mask.EditMask = "n2";
            this.fld_lbCommissionPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_lbCommissionPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_lbCommissionPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_lbCommissionPercent.Screen = null;
            this.fld_lbCommissionPercent.Size = new System.Drawing.Size(150, 20);
            this.fld_lbCommissionPercent.TabIndex = 716;
            this.fld_lbCommissionPercent.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(240, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(57, 13);
            this.bosLabel1.TabIndex = 717;
            this.bosLabel1.Text = "%Hoa hồng";
            // 
            // guiAddSalesman
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 276);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lbCommissionPercent);
            this.Controls.Add(this.fld_lkeARSellerID);
            this.Controls.Add(this.bosLabel91);
            this.Controls.Add(this.fld_dgcARSalesmans);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiAddSalesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Người bán";
            this.Load += new System.EventHandler(this.guiChooseSupplier_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSalesmans, 0);
            this.Controls.SetChildIndex(this.bosLabel91, 0);
            this.Controls.SetChildIndex(this.fld_lkeARSellerID, 0);
            this.Controls.SetChildIndex(this.fld_lbCommissionPercent, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSalesmans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lbCommissionPercent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private ARSalesmansGridControl fld_dgcARSalesmans;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDocumentPayments;
        private BOSComponent.BOSLookupEdit fld_lkeARSellerID;
        private BOSComponent.BOSLabel bosLabel91;
        private BOSComponent.BOSTextBox fld_lbCommissionPercent;
        private BOSComponent.BOSLabel bosLabel1;
    }
}