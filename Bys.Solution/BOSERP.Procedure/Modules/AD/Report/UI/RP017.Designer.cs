namespace BOSERP.Modules.Report
{
    partial class RP017
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToAPReturnSupplierDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromAPReturnSupplierDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPRP017ReturnSuppliers = new BOSERP.Modules.Report.APRP017ReturnSuppliersGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP017ReturnSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToAPReturnSupplierDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromAPReturnSupplierDate);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel3);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1068, 63);
            this.panelControl1.TabIndex = 6;
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "APReturnSuppliers";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = null;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = null;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = null;
            this.fld_lkeFK_APSupplierID.BOSSelectType = null;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = "";
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(94, 35);
            this.fld_lkeFK_APSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierNo";
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 3;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(482, 6);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 23);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dteSearchToAPReturnSupplierDate
            // 
            this.fld_dteSearchToAPReturnSupplierDate.BOSComment = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSDataMember = "APReturnSupplierDate";
            this.fld_dteSearchToAPReturnSupplierDate.BOSDataSource = "APReturnSuppliers";
            this.fld_dteSearchToAPReturnSupplierDate.BOSDescription = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSError = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSPrivilege = null;
            this.fld_dteSearchToAPReturnSupplierDate.BOSPropertyName = null;
            this.fld_dteSearchToAPReturnSupplierDate.EditValue = null;
            this.fld_dteSearchToAPReturnSupplierDate.Location = new System.Drawing.Point(294, 9);
            this.fld_dteSearchToAPReturnSupplierDate.Name = "fld_dteSearchToAPReturnSupplierDate";
            this.fld_dteSearchToAPReturnSupplierDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPReturnSupplierDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPReturnSupplierDate.Screen = null;
            this.fld_dteSearchToAPReturnSupplierDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToAPReturnSupplierDate.TabIndex = 2;
            this.fld_dteSearchToAPReturnSupplierDate.Tag = "SC";
            // 
            // fld_dteSearchFromAPReturnSupplierDate
            // 
            this.fld_dteSearchFromAPReturnSupplierDate.BOSComment = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSDataMember = "APReturnSupplierDate";
            this.fld_dteSearchFromAPReturnSupplierDate.BOSDataSource = "APReturnSuppliers";
            this.fld_dteSearchFromAPReturnSupplierDate.BOSDescription = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSError = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPReturnSupplierDate.BOSPropertyName = null;
            this.fld_dteSearchFromAPReturnSupplierDate.EditValue = null;
            this.fld_dteSearchFromAPReturnSupplierDate.Location = new System.Drawing.Point(94, 9);
            this.fld_dteSearchFromAPReturnSupplierDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPReturnSupplierDate.Name = "fld_dteSearchFromAPReturnSupplierDate";
            this.fld_dteSearchFromAPReturnSupplierDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPReturnSupplierDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPReturnSupplierDate.Screen = null;
            this.fld_dteSearchFromAPReturnSupplierDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromAPReturnSupplierDate.TabIndex = 1;
            this.fld_dteSearchFromAPReturnSupplierDate.Tag = "SC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(256, 12);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 8;
            this.BOSLabel2.Text = "Đến";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(12, 38);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(65, 13);
            this.BOSLabel3.TabIndex = 8;
            this.BOSLabel3.Text = "Nhà cung cấp";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(12, 12);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 8;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(404, 82);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(268, 19);
            this.fld_lblTitle.TabIndex = 8;
            this.fld_lblTitle.Text = "Danh sách trả hàng nhà cung cấp";
            // 
            // fld_dgcAPRP017ReturnSuppliers
            // 
            this.fld_dgcAPRP017ReturnSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPRP017ReturnSuppliers.BOSComment = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSDataMember = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSDataSource = "APReturnSuppliers";
            this.fld_dgcAPRP017ReturnSuppliers.BOSDescription = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSError = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSFieldGroup = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSFieldRelation = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSGridType = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSPrivilege = null;
            this.fld_dgcAPRP017ReturnSuppliers.BOSPropertyName = null;
            this.fld_dgcAPRP017ReturnSuppliers.Location = new System.Drawing.Point(12, 120);
            this.fld_dgcAPRP017ReturnSuppliers.MenuManager = this.screenToolbar;
            this.fld_dgcAPRP017ReturnSuppliers.Name = "fld_dgcAPRP017ReturnSuppliers";
            this.fld_dgcAPRP017ReturnSuppliers.Screen = null;
            this.fld_dgcAPRP017ReturnSuppliers.Size = new System.Drawing.Size(1025, 490);
            this.fld_dgcAPRP017ReturnSuppliers.TabIndex = 9;
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
            this.fld_btnClose.Location = new System.Drawing.Point(981, 645);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 23);
            this.fld_btnClose.TabIndex = 7;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnExcel.Location = new System.Drawing.Point(890, 645);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnExcel.TabIndex = 6;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // RP017
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 682);
            this.Controls.Add(this.fld_dgcAPRP017ReturnSuppliers);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Name = "RP017";
            this.Tag = "SS";
            this.Text = "Danh sách trả hàng NCC";
            this.Load += new System.EventHandler(this.RP017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPReturnSupplierDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPReturnSupplierDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP017ReturnSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPReturnSupplierDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPReturnSupplierDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel fld_lblTitle;
        private APRP017ReturnSuppliersGridControl fld_dgcAPRP017ReturnSuppliers;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExcel;
    }
}