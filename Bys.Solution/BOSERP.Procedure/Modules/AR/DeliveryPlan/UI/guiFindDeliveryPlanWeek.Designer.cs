namespace BOSERP.Modules.DeliveryPlan
{
    partial class guiFindDeliveryPlanWeek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanItemFindsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanItemFindsGridControl();
            this.fld_dteARSaleOrderDeliveryDateForm = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanItemFindsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 20);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(99, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Chọn ngày kế hoạch";
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(802, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 10;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(713, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcARDeliveryPlanItemFindsGridControl
            // 
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSDataSource = "ARDeliveryPlanItems";
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Location = new System.Drawing.Point(12, 52);
            this.fld_dgcARDeliveryPlanItemFindsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Name = "fld_dgcARDeliveryPlanItemFindsGridControl";
            this.fld_dgcARDeliveryPlanItemFindsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Size = new System.Drawing.Size(873, 486);
            this.fld_dgcARDeliveryPlanItemFindsGridControl.TabIndex = 8;
            this.fld_dgcARDeliveryPlanItemFindsGridControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_dteARSaleOrderDeliveryDateForm
            // 
            this.fld_dteARSaleOrderDeliveryDateForm.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDateForm.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Location = new System.Drawing.Point(117, 17);
            this.fld_dteARSaleOrderDeliveryDateForm.Name = "fld_dteARSaleOrderDeliveryDateForm";
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDateForm.Screen = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Size = new System.Drawing.Size(129, 20);
            this.fld_dteARSaleOrderDeliveryDateForm.TabIndex = 0;
            this.fld_dteARSaleOrderDeliveryDateForm.Tag = "DC";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Location = new System.Drawing.Point(252, 12);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(137, 27);
            this.fld_btnFind.TabIndex = 7;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkSelectedAll.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkSelectedAll.BOSDescription = null;
            this.fld_chkSelectedAll.BOSError = null;
            this.fld_chkSelectedAll.BOSFieldGroup = null;
            this.fld_chkSelectedAll.BOSFieldRelation = null;
            this.fld_chkSelectedAll.BOSPrivilege = null;
            this.fld_chkSelectedAll.BOSPropertyName = "EditValue";
            this.fld_chkSelectedAll.Location = new System.Drawing.Point(12, 542);
            this.fld_chkSelectedAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectedAll.Name = "fld_chkSelectedAll";
            this.fld_chkSelectedAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectedAll.Screen = null;
            this.fld_chkSelectedAll.Size = new System.Drawing.Size(118, 19);
            this.fld_chkSelectedAll.TabIndex = 142;
            this.fld_chkSelectedAll.Tag = "DC";
            this.fld_chkSelectedAll.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_chkSelectedAll_EditValueChanging);
            // 
            // guiFindDeliveryPlanWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_dgcARDeliveryPlanItemFindsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDateForm);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_btnFind);
            this.Name = "guiFindDeliveryPlanWeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDeliveryDateForm, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARDeliveryPlanItemFindsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanItemFindsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ARDeliveryPlanItemFindsGridControl fld_dgcARDeliveryPlanItemFindsGridControl;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDateForm;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
    }
}