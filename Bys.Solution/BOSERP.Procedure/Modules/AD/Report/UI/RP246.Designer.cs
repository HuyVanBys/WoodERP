namespace BOSERP.Modules.Report
{
    partial class RP246
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP246));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARRP246ICShipmentItems = new BOSERP.Modules.Report.ARRP246ShipmentItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP246ICShipmentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICProductGroupID);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.panelControl1.Controls.Add(this.BOSLabel5);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1001, 90);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeFK_ICProductGroupID
            // 
            this.fld_lkeFK_ICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductGroupID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductGroupID.BOSComment = null;
            this.fld_lkeFK_ICProductGroupID.BOSDataMember = "FK_ICProductGroupID";
            this.fld_lkeFK_ICProductGroupID.BOSDataSource = "ICShipmentItems";
            this.fld_lkeFK_ICProductGroupID.BOSDescription = null;
            this.fld_lkeFK_ICProductGroupID.BOSError = null;
            this.fld_lkeFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductGroupID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductGroupID.BOSPropertyName = null;
            this.fld_lkeFK_ICProductGroupID.BOSSelectType = null;
            this.fld_lkeFK_ICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductGroupID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductGroupID.Location = new System.Drawing.Point(347, 35);
            this.fld_lkeFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductGroupID.Name = "fld_lkeFK_ICProductGroupID";
            this.fld_lkeFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductGroupID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên nhóm")});
            this.fld_lkeFK_ICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeFK_ICProductGroupID.Properties.NullText = "";
            this.fld_lkeFK_ICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeFK_ICProductGroupID.Screen = null;
            this.fld_lkeFK_ICProductGroupID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductGroupID.TabIndex = 102;
            this.fld_lkeFK_ICProductGroupID.Tag = "";
            // 
            // fld_lkeFK_ICDepartmentID
            // 
            this.fld_lkeFK_ICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ICDepartmentID.BOSComment = null;
            this.fld_lkeFK_ICDepartmentID.BOSDataMember = "FK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.BOSDataSource = "ICShipmentItems";
            this.fld_lkeFK_ICDepartmentID.BOSDescription = null;
            this.fld_lkeFK_ICDepartmentID.BOSError = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_ICDepartmentID.BOSPropertyName = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICDepartmentID.CurrentDisplayText = "";
            this.fld_lkeFK_ICDepartmentID.Location = new System.Drawing.Point(94, 35);
            this.fld_lkeFK_ICDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentNo", "Mã ngành hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Tên ngành hàng")});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.fld_lkeFK_ICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICDepartmentID.TabIndex = 98;
            this.fld_lkeFK_ICDepartmentID.Tag = "";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.BOSComment = null;
            this.BOSLabel5.BOSDataMember = null;
            this.BOSLabel5.BOSDataSource = null;
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = null;
            this.BOSLabel5.BOSFieldRelation = null;
            this.BOSLabel5.BOSPrivilege = null;
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(13, 38);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(58, 13);
            this.BOSLabel5.TabIndex = 100;
            this.BOSLabel5.Text = "Ngành hàng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(263, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(54, 13);
            this.bosLabel1.TabIndex = 101;
            this.bosLabel1.Text = "Nhóm hàng";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = "";
            this.fld_dteSearchToDate.BOSDataSource = "";
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(347, 9);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 9;
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
            this.bosLabel9.Location = new System.Drawing.Point(263, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = "";
            this.fld_dteSearchFromDate.BOSDataSource = "";
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(94, 9);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 8;
            this.fld_dteSearchFromDate.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(13, 12);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 10;
            this.bosLabel10.Text = "Từ ngày";
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
            this.fld_btnApply.Location = new System.Drawing.Point(568, 12);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(84, 27);
            this.fld_btnApply.TabIndex = 11;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(833, 639);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 2;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(914, 639);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcARRP246ICShipmentItems
            // 
            this.fld_dgcARRP246ICShipmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP246ICShipmentItems.BOSComment = null;
            this.fld_dgcARRP246ICShipmentItems.BOSDataMember = null;
            this.fld_dgcARRP246ICShipmentItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcARRP246ICShipmentItems.BOSDescription = null;
            this.fld_dgcARRP246ICShipmentItems.BOSError = null;
            this.fld_dgcARRP246ICShipmentItems.BOSFieldGroup = null;
            this.fld_dgcARRP246ICShipmentItems.BOSFieldRelation = null;
            this.fld_dgcARRP246ICShipmentItems.BOSGridType = null;
            this.fld_dgcARRP246ICShipmentItems.BOSPrivilege = null;
            this.fld_dgcARRP246ICShipmentItems.BOSPropertyName = null;
            this.fld_dgcARRP246ICShipmentItems.CommodityType = "";
            this.fld_dgcARRP246ICShipmentItems.Location = new System.Drawing.Point(0, 90);
            this.fld_dgcARRP246ICShipmentItems.Name = "fld_dgcARRP246ICShipmentItems";
            this.fld_dgcARRP246ICShipmentItems.PrintReport = false;
            this.fld_dgcARRP246ICShipmentItems.Screen = null;
            this.fld_dgcARRP246ICShipmentItems.Size = new System.Drawing.Size(989, 508);
            this.fld_dgcARRP246ICShipmentItems.TabIndex = 4;
            this.fld_dgcARRP246ICShipmentItems.Tag = "DC";
            // 
            // RP246
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 674);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARRP246ICShipmentItems);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RP246.IconOptions.Icon")));
            this.Name = "RP246";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết xuất theo LSX";
            this.Load += new System.EventHandler(this.RP245_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP246ICShipmentItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP246ICShipmentItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private ARRP246ShipmentItemsGridControl fld_dgcARRP246ICShipmentItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductGroupID;
    }
}