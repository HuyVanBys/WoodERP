namespace BOSERP.Modules.Report
{
    partial class RP108
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP108));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMBatchProducts = new BOSERP.Modules.Report.RP108MMBatchProductsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosLabel11);
            this.panelControl1.Controls.Add(this.fld_lkeMMProductionNormID);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(870, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(12, 12);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(70, 13);
            this.bosLabel11.TabIndex = 359;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.Text = "Bảng định mức";
            // 
            // fld_lkeMMProductionNormID
            // 
            this.fld_lkeMMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormID.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSDataMember = "MMProductionNormID";
            this.fld_lkeMMProductionNormID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormID.BOSDescription = null;
            this.fld_lkeMMProductionNormID.BOSError = null;
            this.fld_lkeMMProductionNormID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.Location = new System.Drawing.Point(88, 9);
            this.fld_lkeMMProductionNormID.Name = "fld_lkeMMProductionNormID";
            this.fld_lkeMMProductionNormID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Mã BDM")});
            this.fld_lkeMMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeMMProductionNormID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMProductionNormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeMMProductionNormID.Screen = null;
            this.fld_lkeMMProductionNormID.Size = new System.Drawing.Size(164, 20);
            this.fld_lkeMMProductionNormID.TabIndex = 360;
            this.fld_lkeMMProductionNormID.Tag = "DC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(267, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(97, 27);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(782, 483);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lbl_FromdateTodate
            // 
            this.fld_lbl_FromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lbl_FromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lbl_FromdateTodate.BOSComment = null;
            this.fld_lbl_FromdateTodate.BOSDataMember = null;
            this.fld_lbl_FromdateTodate.BOSDataSource = null;
            this.fld_lbl_FromdateTodate.BOSDescription = null;
            this.fld_lbl_FromdateTodate.BOSError = null;
            this.fld_lbl_FromdateTodate.BOSFieldGroup = null;
            this.fld_lbl_FromdateTodate.BOSFieldRelation = null;
            this.fld_lbl_FromdateTodate.BOSPrivilege = null;
            this.fld_lbl_FromdateTodate.BOSPropertyName = null;
            this.fld_lbl_FromdateTodate.Location = new System.Drawing.Point(382, 168);
            this.fld_lbl_FromdateTodate.Name = "fld_lbl_FromdateTodate";
            this.fld_lbl_FromdateTodate.Screen = null;
            this.fld_lbl_FromdateTodate.Size = new System.Drawing.Size(0, 16);
            this.fld_lbl_FromdateTodate.TabIndex = 11;
            // 
            // fld_btnExcel
            // 
            this.fld_btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExcel.BOSComment = null;
            this.fld_btnExcel.BOSDataMember = null;
            this.fld_btnExcel.BOSDataSource = null;
            this.fld_btnExcel.BOSDescription = null;
            this.fld_btnExcel.BOSError = null;
            this.fld_btnExcel.BOSFieldGroup = null;
            this.fld_btnExcel.BOSFieldRelation = null;
            this.fld_btnExcel.BOSPrivilege = null;
            this.fld_btnExcel.BOSPropertyName = null;
            this.fld_btnExcel.Location = new System.Drawing.Point(701, 483);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExcel.TabIndex = 1;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // fld_dgcMMBatchProducts
            // 
            this.fld_dgcMMBatchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBatchProducts.BOSComment = null;
            this.fld_dgcMMBatchProducts.BOSDataMember = null;
            this.fld_dgcMMBatchProducts.BOSDataSource = "MMBatchProducts";
            this.fld_dgcMMBatchProducts.BOSDescription = null;
            this.fld_dgcMMBatchProducts.BOSError = null;
            this.fld_dgcMMBatchProducts.BOSFieldGroup = null;
            this.fld_dgcMMBatchProducts.BOSFieldRelation = null;
            this.fld_dgcMMBatchProducts.BOSGridType = null;
            this.fld_dgcMMBatchProducts.BOSPrivilege = null;
            this.fld_dgcMMBatchProducts.BOSPropertyName = null;
            this.fld_dgcMMBatchProducts.Location = new System.Drawing.Point(0, 53);
            this.fld_dgcMMBatchProducts.MenuManager = this.screenToolbar;
            this.fld_dgcMMBatchProducts.Name = "fld_dgcMMBatchProducts";
            this.fld_dgcMMBatchProducts.PrintReport = false;
            this.fld_dgcMMBatchProducts.Screen = null;
            this.fld_dgcMMBatchProducts.Size = new System.Drawing.Size(870, 424);
            this.fld_dgcMMBatchProducts.TabIndex = 12;
            // 
            // RP108
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 522);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcMMBatchProducts);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_lbl_FromdateTodate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP108";
            this.Tag = "SS";
            this.Text = "Danh sách lệnh sản xuất theo bảng định mức";
            this.Load += new System.EventHandler(this.RP002_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_btnExcel, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMBatchProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
       // private RP108MMBatchProductsGridControl fld_dgcARSaleForecastsRP3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lbl_FromdateTodate;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormID;
        private RP108MMBatchProductsGridControl fld_dgcMMBatchProducts;
    }
}