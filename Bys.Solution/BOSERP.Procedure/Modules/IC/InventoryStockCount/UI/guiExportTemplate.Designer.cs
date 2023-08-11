namespace BOSERP.Modules.InventoryStockCount
{
    partial class guiExportTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiExportTemplate));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportTeamplate = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_FK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_dteICInventoryStockCountDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(219, 114);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnExportTeamplate
            // 
            this.fld_btnExportTeamplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportTeamplate.BOSComment = null;
            this.fld_btnExportTeamplate.BOSDataMember = null;
            this.fld_btnExportTeamplate.BOSDataSource = null;
            this.fld_btnExportTeamplate.BOSDescription = null;
            this.fld_btnExportTeamplate.BOSError = null;
            this.fld_btnExportTeamplate.BOSFieldGroup = null;
            this.fld_btnExportTeamplate.BOSFieldRelation = null;
            this.fld_btnExportTeamplate.BOSPrivilege = null;
            this.fld_btnExportTeamplate.BOSPropertyName = null;
            this.fld_btnExportTeamplate.Location = new System.Drawing.Point(119, 114);
            this.fld_btnExportTeamplate.Name = "fld_btnExportTeamplate";
            this.fld_btnExportTeamplate.Screen = null;
            this.fld_btnExportTeamplate.Size = new System.Drawing.Size(94, 27);
            this.fld_btnExportTeamplate.TabIndex = 0;
            this.fld_btnExportTeamplate.Text = "Xuất mẫu Import";
            this.fld_btnExportTeamplate.Click += new System.EventHandler(this.fld_btnExportTeamplate_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(16, 27);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Kho";
            // 
            // fld_FK_ICStockID
            // 
            this.fld_FK_ICStockID.BOSAllowAddNew = false;
            this.fld_FK_ICStockID.BOSAllowDummy = false;
            this.fld_FK_ICStockID.BOSComment = null;
            this.fld_FK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_FK_ICStockID.BOSDataSource = "ICShipments";
            this.fld_FK_ICStockID.BOSDescription = null;
            this.fld_FK_ICStockID.BOSError = null;
            this.fld_FK_ICStockID.BOSFieldGroup = null;
            this.fld_FK_ICStockID.BOSFieldParent = "";
            this.fld_FK_ICStockID.BOSFieldRelation = null;
            this.fld_FK_ICStockID.BOSPrivilege = null;
            this.fld_FK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_FK_ICStockID.BOSSelectType = null;
            this.fld_FK_ICStockID.BOSSelectTypeValue = null;
            this.fld_FK_ICStockID.CurrentDisplayText = null;
            this.fld_FK_ICStockID.Location = new System.Drawing.Point(88, 23);
            this.fld_FK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_FK_ICStockID.Name = "fld_FK_ICStockID";
            this.fld_FK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_FK_ICStockID.Properties.ColumnName = null;
            this.fld_FK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockID", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_FK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_FK_ICStockID.Properties.NullText = "";
            this.fld_FK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_FK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_FK_ICStockID.Screen = null;
            this.fld_FK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_FK_ICStockID.TabIndex = 0;
            this.fld_FK_ICStockID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(13, 53);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(69, 13);
            this.bosLabel6.TabIndex = 8;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Ngày kiểm kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fld_dteICInventoryStockCountDate);
            this.groupBox1.Controls.Add(this.fld_FK_ICStockID);
            this.groupBox1.Controls.Add(this.bosLabel6);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin truy vấn";
            // 
            // fld_dteICInventoryStockCountDate
            // 
            this.fld_dteICInventoryStockCountDate.EditValue = null;
            this.fld_dteICInventoryStockCountDate.Location = new System.Drawing.Point(88, 49);
            this.fld_dteICInventoryStockCountDate.MenuManager = this.screenToolbar;
            this.fld_dteICInventoryStockCountDate.Name = "fld_dteICInventoryStockCountDate";
            this.fld_dteICInventoryStockCountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICInventoryStockCountDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICInventoryStockCountDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // guiExportTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 150);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnExportTeamplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiExportTemplate.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiExportTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất mẫu Import";
            this.Load += new System.EventHandler(this.guiPrintInventoryPackageBarcode_Load);
            this.Controls.SetChildIndex(this.fld_btnExportTeamplate, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExportTeamplate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_FK_ICStockID;
        private BOSComponent.BOSLabel bosLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit fld_dteICInventoryStockCountDate;
        private System.Windows.Forms.Label label1;
    }
}