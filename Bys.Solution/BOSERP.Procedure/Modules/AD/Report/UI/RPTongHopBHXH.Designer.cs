using BOSComponent;
namespace BOSERP.Modules.Report
{
    partial class RPTongHopBHXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPTongHopBHXH));
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcARNormFeeConfigItems = new BOSComponent.BOSGridControl(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(629, 6);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 28);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xuất excel";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1100, 536);
            this.bosPanel1.TabIndex = 364;
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(540, 6);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(83, 28);
            this.bosButton1.TabIndex = 378;
            this.bosButton1.Text = "Xem";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcARNormFeeConfigItems);
            this.bosLine1.Location = new System.Drawing.Point(3, 37);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1094, 499);
            this.bosLine1.TabIndex = 377;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Chi tiết    ";
            // 
            // fld_dgcARNormFeeConfigItems
            // 
            this.fld_dgcARNormFeeConfigItems.BOSComment = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataMember = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataSource = "ADReports";
            this.fld_dgcARNormFeeConfigItems.BOSDescription = null;
            this.fld_dgcARNormFeeConfigItems.BOSError = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldGroup = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldRelation = null;
            this.fld_dgcARNormFeeConfigItems.BOSGridType = null;
            this.fld_dgcARNormFeeConfigItems.BOSPrivilege = null;
            this.fld_dgcARNormFeeConfigItems.BOSPropertyName = null;
            this.fld_dgcARNormFeeConfigItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARNormFeeConfigItems.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARNormFeeConfigItems.MenuManager = this.screenToolbar;
            this.fld_dgcARNormFeeConfigItems.Name = "fld_dgcARNormFeeConfigItems";
            this.fld_dgcARNormFeeConfigItems.PrintReport = false;
            this.fld_dgcARNormFeeConfigItems.Screen = null;
            this.fld_dgcARNormFeeConfigItems.Size = new System.Drawing.Size(1088, 479);
            this.fld_dgcARNormFeeConfigItems.TabIndex = 16;
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(360, 11);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchToDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchToDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 381;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(264, 14);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(51, 13);
            this.bosLabel9.TabIndex = 382;
            this.bosLabel9.Text = "Đến tháng";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(12, 14);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(44, 13);
            this.bosLabel10.TabIndex = 379;
            this.bosLabel10.Text = "Từ tháng";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(97, 11);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 380;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // RPTongHopBHXH
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 536);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPTongHopBHXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "TỔNG HỢP DANH SÁCH THAM GIA BHXH";
            this.Load += new System.EventHandler(this.RPTongHopBHXH_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnApply;
        private BOSPanel bosPanel1;
        private BOSLine bosLine1;
        private BOSGridControl fld_dgcARNormFeeConfigItems;
        private BOSButton bosButton1;
        private BOSDateEdit fld_dteSearchToDate;
        private BOSLabel bosLabel9;
        private BOSLabel bosLabel10;
        private BOSDateEdit fld_dteSearchFromDate;
    }
}