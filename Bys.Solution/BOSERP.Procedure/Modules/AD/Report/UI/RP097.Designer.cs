namespace BOSERP.Modules.Report
{
    partial class RP097
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP097));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleForecastNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblFrom = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleForecastsRP = new BOSERP.Modules.Report.RP097SaleForecastsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastsRP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.bosLabel11);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.fld_txtARSaleForecastNo);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.fld_lblFrom);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1092, 95);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(89, 38);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(164, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 360;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(12, 45);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(56, 13);
            this.bosLabel11.TabIndex = 359;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Khách hàng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(328, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 358;
            this.bosLabel2.Text = "Số SF";
            // 
            // fld_txtARSaleForecastNo
            // 
            this.fld_txtARSaleForecastNo.BOSComment = null;
            this.fld_txtARSaleForecastNo.BOSDataMember = "ARSaleForecastNo";
            this.fld_txtARSaleForecastNo.BOSDataSource = "ARSaleForecasts";
            this.fld_txtARSaleForecastNo.BOSDescription = null;
            this.fld_txtARSaleForecastNo.BOSError = null;
            this.fld_txtARSaleForecastNo.BOSFieldGroup = null;
            this.fld_txtARSaleForecastNo.BOSFieldRelation = null;
            this.fld_txtARSaleForecastNo.BOSPrivilege = null;
            this.fld_txtARSaleForecastNo.BOSPropertyName = "Text";
            this.fld_txtARSaleForecastNo.Location = new System.Drawing.Point(393, 38);
            this.fld_txtARSaleForecastNo.MenuManager = this.screenToolbar;
            this.fld_txtARSaleForecastNo.Name = "fld_txtARSaleForecastNo";
            this.fld_txtARSaleForecastNo.Screen = null;
            this.fld_txtARSaleForecastNo.Size = new System.Drawing.Size(156, 20);
            this.fld_txtARSaleForecastNo.TabIndex = 357;
            this.fld_txtARSaleForecastNo.Tag = "DC";
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
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(393, 9);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(156, 20);
            this.fld_dteSearchToDate.TabIndex = 6;
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
            this.bosLabel9.Location = new System.Drawing.Point(328, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(20, 13);
            this.bosLabel9.TabIndex = 353;
            this.bosLabel9.Text = "Đến";
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
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(89, 9);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(164, 20);
            this.fld_dteSearchFromDate.TabIndex = 5;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_lblFrom
            // 
            this.fld_lblFrom.BOSComment = null;
            this.fld_lblFrom.BOSDataMember = null;
            this.fld_lblFrom.BOSDataSource = null;
            this.fld_lblFrom.BOSDescription = null;
            this.fld_lblFrom.BOSError = null;
            this.fld_lblFrom.BOSFieldGroup = null;
            this.fld_lblFrom.BOSFieldRelation = null;
            this.fld_lblFrom.BOSPrivilege = null;
            this.fld_lblFrom.BOSPropertyName = null;
            this.fld_lblFrom.Location = new System.Drawing.Point(12, 12);
            this.fld_lblFrom.Name = "fld_lblFrom";
            this.fld_lblFrom.Screen = null;
            this.fld_lblFrom.Size = new System.Drawing.Size(40, 13);
            this.fld_lblFrom.TabIndex = 11;
            this.fld_lblFrom.Text = "Từ ngày";
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
            this.fld_btnApply.Location = new System.Drawing.Point(650, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(97, 27);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.fld_lblTitle.Location = new System.Drawing.Point(365, 123);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(291, 19);
            this.fld_lblTitle.TabIndex = 8;
            this.fld_lblTitle.Text = "BÁO CÁO KINH DOANH TỔNG QUÁT";
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
            this.fld_btnClose.Location = new System.Drawing.Point(1004, 703);
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
            this.fld_btnExcel.Location = new System.Drawing.Point(923, 703);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExcel.TabIndex = 1;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // fld_dgcARSaleForecastsRP
            // 
            this.fld_dgcARSaleForecastsRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleForecastsRP.BOSComment = null;
            this.fld_dgcARSaleForecastsRP.BOSDataMember = null;
            this.fld_dgcARSaleForecastsRP.BOSDataSource = "ARSaleForecasts";
            this.fld_dgcARSaleForecastsRP.BOSDescription = null;
            this.fld_dgcARSaleForecastsRP.BOSError = null;
            this.fld_dgcARSaleForecastsRP.BOSFieldGroup = null;
            this.fld_dgcARSaleForecastsRP.BOSFieldRelation = null;
            this.fld_dgcARSaleForecastsRP.BOSGridType = null;
            this.fld_dgcARSaleForecastsRP.BOSPrivilege = null;
            this.fld_dgcARSaleForecastsRP.BOSPropertyName = null;
            this.fld_dgcARSaleForecastsRP.CommodityType = "";
            this.fld_dgcARSaleForecastsRP.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcARSaleForecastsRP.Location = new System.Drawing.Point(-2, 168);
            this.fld_dgcARSaleForecastsRP.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleForecastsRP.Name = "fld_dgcARSaleForecastsRP";
            this.fld_dgcARSaleForecastsRP.PrintReport = false;
            this.fld_dgcARSaleForecastsRP.Screen = null;
            this.fld_dgcARSaleForecastsRP.Size = new System.Drawing.Size(1094, 529);
            this.fld_dgcARSaleForecastsRP.TabIndex = 12;
            // 
            // RP097
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 742);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARSaleForecastsRP);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_lbl_FromdateTodate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP097";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Báo cáo kinh doanh tổng quát";
            this.Load += new System.EventHandler(this.RP002_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_btnExcel, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleForecastsRP, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleForecastNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastsRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel fld_lblTitle;
        private RP097SaleForecastsGridControl fld_dgcARSaleForecastsRP3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblFrom;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel fld_lbl_FromdateTodate;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSTextBox fld_txtARSaleForecastNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel11;
        private RP097SaleForecastsGridControl fld_dgcARSaleForecastsRP;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
    }
}