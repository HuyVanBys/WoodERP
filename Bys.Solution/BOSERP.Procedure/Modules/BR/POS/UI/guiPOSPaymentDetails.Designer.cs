namespace BOSERP.Modules.POS
{
    partial class guiPOSPaymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPOSPaymentDetails));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_dgcPayment = new BOSERP.Modules.POS.ARPOSPaymentDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.fld_btnAcceptPayment = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnSavePrint = new DevExpress.XtraEditors.SimpleButton();
            this.BOSLine2 = new BOSComponent.BOSLine(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtChangeAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtReceivingAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPaymentAmount = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtChangeAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtReceivingAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tiền thối lại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tiền nhận";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(723, 375);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(98, 27);
            this.fld_btnCancel.TabIndex = 5;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcPayment
            // 
            this.fld_dgcPayment.AllowMultiplePayment = true;
            this.fld_dgcPayment.AllowPaymentByCurrency = true;
            this.fld_dgcPayment.BOSComment = null;
            this.fld_dgcPayment.BOSDataMember = null;
            this.fld_dgcPayment.BOSDataSource = "ARPOSPaymentDetails";
            this.fld_dgcPayment.BOSDescription = null;
            this.fld_dgcPayment.BOSError = null;
            this.fld_dgcPayment.BOSFieldGroup = null;
            this.fld_dgcPayment.BOSFieldRelation = null;
            this.fld_dgcPayment.BOSGridType = null;
            this.fld_dgcPayment.BOSPrivilege = null;
            this.fld_dgcPayment.BOSPropertyName = null;
            this.fld_dgcPayment.POSPaymentDetailList = null;
            this.fld_dgcPayment.Location = new System.Drawing.Point(12, 48);
            this.fld_dgcPayment.MainView = this.gridView1;
            this.fld_dgcPayment.Name = "fld_dgcPayment";
            this.fld_dgcPayment.PaymentAmount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fld_dgcPayment.PrintReport = false;
            this.fld_dgcPayment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1});
            this.fld_dgcPayment.RequiredMethod = null;
            this.fld_dgcPayment.Screen = null;
            this.fld_dgcPayment.Size = new System.Drawing.Size(803, 211);
            this.fld_dgcPayment.TabIndex = 1;
            this.fld_dgcPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(657, 419, 216, 178);
            this.gridView1.GridControl = this.fld_dgcPayment;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Phương thức";
            this.gridColumn1.FieldName = "ARPaymentMethodDisplayText";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 172;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.Caption = "Tiền thanh toán";
            this.gridColumn2.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn2.DisplayFormat.FormatString = "n2";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "ARCustomerPaymentDetailAmount";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 227;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thông tin phụ";
            this.gridColumn3.FieldName = "ARCustomerPaymentDetailInfo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 383;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // fld_btnAcceptPayment
            // 
            this.fld_btnAcceptPayment.Location = new System.Drawing.Point(12, 265);
            this.fld_btnAcceptPayment.Name = "fld_btnAcceptPayment";
            this.fld_btnAcceptPayment.Size = new System.Drawing.Size(129, 27);
            this.fld_btnAcceptPayment.TabIndex = 2;
            this.fld_btnAcceptPayment.Tag = "Accept";
            this.fld_btnAcceptPayment.Text = "Chấp nhận thanh toán";
            this.fld_btnAcceptPayment.Click += new System.EventHandler(this.fld_btnAcceptPayment_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Enabled = false;
            this.fld_btnSave.Location = new System.Drawing.Point(614, 375);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Size = new System.Drawing.Size(103, 27);
            this.fld_btnSave.TabIndex = 4;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_btnSavePrint
            // 
            this.fld_btnSavePrint.Enabled = false;
            this.fld_btnSavePrint.Location = new System.Drawing.Point(483, 375);
            this.fld_btnSavePrint.Name = "fld_btnSavePrint";
            this.fld_btnSavePrint.Size = new System.Drawing.Size(125, 27);
            this.fld_btnSavePrint.TabIndex = 3;
            this.fld_btnSavePrint.Text = "Lưu && In";
            this.fld_btnSavePrint.Click += new System.EventHandler(this.fld_btnSavePrint_Click);
            // 
            // BOSLine2
            // 
            this.BOSLine2.BOSComment = null;
            this.BOSLine2.BOSDataMember = null;
            this.BOSLine2.BOSDataSource = null;
            this.BOSLine2.BOSDescription = null;
            this.BOSLine2.BOSError = null;
            this.BOSLine2.BOSFieldGroup = null;
            this.BOSLine2.BOSFieldRelation = null;
            this.BOSLine2.BOSPrivilege = null;
            this.BOSLine2.BOSPropertyName = null;
            this.BOSLine2.Location = new System.Drawing.Point(4, 357);
            this.BOSLine2.Name = "BOSLine2";
            this.BOSLine2.Screen = null;
            this.BOSLine2.Size = new System.Drawing.Size(819, 10);
            this.BOSLine2.TabIndex = 8;
            this.BOSLine2.TabStop = false;
            // 
            // bosPanel1
            // 
            this.bosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_txtChangeAmount);
            this.bosPanel1.Controls.Add(this.fld_txtReceivingAmount);
            this.bosPanel1.Controls.Add(this.labelControl2);
            this.bosPanel1.Controls.Add(this.labelControl1);
            this.bosPanel1.Location = new System.Drawing.Point(497, 272);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(318, 73);
            this.bosPanel1.TabIndex = 9;
            // 
            // fld_txtChangeAmount
            // 
            this.fld_txtChangeAmount.BOSComment = null;
            this.fld_txtChangeAmount.BOSDataMember = null;
            this.fld_txtChangeAmount.BOSDataSource = null;
            this.fld_txtChangeAmount.BOSDescription = null;
            this.fld_txtChangeAmount.BOSError = null;
            this.fld_txtChangeAmount.BOSFieldGroup = null;
            this.fld_txtChangeAmount.BOSFieldRelation = null;
            this.fld_txtChangeAmount.BOSPrivilege = null;
            this.fld_txtChangeAmount.BOSPropertyName = null;
            this.fld_txtChangeAmount.Location = new System.Drawing.Point(126, 39);
            this.fld_txtChangeAmount.MenuManager = this.screenToolbar;
            this.fld_txtChangeAmount.Name = "fld_txtChangeAmount";
            this.fld_txtChangeAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtChangeAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtChangeAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtChangeAmount.Properties.ReadOnly = true;
            this.fld_txtChangeAmount.Screen = null;
            this.fld_txtChangeAmount.Size = new System.Drawing.Size(173, 20);
            this.fld_txtChangeAmount.TabIndex = 3;
            // 
            // fld_txtReceivingAmount
            // 
            this.fld_txtReceivingAmount.BOSComment = null;
            this.fld_txtReceivingAmount.BOSDataMember = null;
            this.fld_txtReceivingAmount.BOSDataSource = null;
            this.fld_txtReceivingAmount.BOSDescription = null;
            this.fld_txtReceivingAmount.BOSError = null;
            this.fld_txtReceivingAmount.BOSFieldGroup = null;
            this.fld_txtReceivingAmount.BOSFieldRelation = null;
            this.fld_txtReceivingAmount.BOSPrivilege = null;
            this.fld_txtReceivingAmount.BOSPropertyName = null;
            this.fld_txtReceivingAmount.Location = new System.Drawing.Point(126, 6);
            this.fld_txtReceivingAmount.MenuManager = this.screenToolbar;
            this.fld_txtReceivingAmount.Name = "fld_txtReceivingAmount";
            this.fld_txtReceivingAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtReceivingAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtReceivingAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtReceivingAmount.Screen = null;
            this.fld_txtReceivingAmount.Size = new System.Drawing.Size(173, 20);
            this.fld_txtReceivingAmount.TabIndex = 2;
            this.fld_txtReceivingAmount.TextChanged += new System.EventHandler(this.fld_txtReceivingAmount_TextChanged);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(107, 16);
            this.bosLabel1.TabIndex = 10;
            this.bosLabel1.Text = "Tiền thanh toán:";
            // 
            // fld_lblPaymentAmount
            // 
            this.fld_lblPaymentAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblPaymentAmount.Appearance.Options.UseFont = true;
            this.fld_lblPaymentAmount.BOSComment = null;
            this.fld_lblPaymentAmount.BOSDataMember = null;
            this.fld_lblPaymentAmount.BOSDataSource = null;
            this.fld_lblPaymentAmount.BOSDescription = null;
            this.fld_lblPaymentAmount.BOSError = null;
            this.fld_lblPaymentAmount.BOSFieldGroup = null;
            this.fld_lblPaymentAmount.BOSFieldRelation = null;
            this.fld_lblPaymentAmount.BOSPrivilege = null;
            this.fld_lblPaymentAmount.BOSPropertyName = null;
            this.fld_lblPaymentAmount.Location = new System.Drawing.Point(135, 15);
            this.fld_lblPaymentAmount.Name = "fld_lblPaymentAmount";
            this.fld_lblPaymentAmount.Screen = null;
            this.fld_lblPaymentAmount.Size = new System.Drawing.Size(57, 16);
            this.fld_lblPaymentAmount.TabIndex = 11;
            this.fld_lblPaymentAmount.Text = "bosLabel2";
            // 
            // guiPOSPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(827, 408);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblPaymentAmount);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.BOSLine2);
            this.Controls.Add(this.fld_btnSavePrint);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_btnAcceptPayment);
            this.Controls.Add(this.fld_dgcPayment);
            this.Controls.Add(this.fld_btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiPOSPaymentDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết thanh toán";
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcPayment, 0);
            this.Controls.SetChildIndex(this.fld_btnAcceptPayment, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnSavePrint, 0);
            this.Controls.SetChildIndex(this.BOSLine2, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblPaymentAmount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtChangeAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtReceivingAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private ARPOSPaymentDetailsGridControl fld_dgcPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton fld_btnAcceptPayment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton fld_btnSave;
        private DevExpress.XtraEditors.SimpleButton fld_btnSavePrint;
        private BOSComponent.BOSLine BOSLine2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblPaymentAmount;
        private BOSComponent.BOSTextBox fld_txtChangeAmount;
        private BOSComponent.BOSTextBox fld_txtReceivingAmount;
    }
}