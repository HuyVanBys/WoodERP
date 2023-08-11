namespace BOSERP.Modules.ACDocumentType
{
    partial class guiEditDocumentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiEditDocumentType));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lblLabel101 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEntryTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcACDocTypeEntrys = new BOSERP.Modules.ACDocumentType.ACDocTypeEntrysGridControl();
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEntryTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntrys)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_lblLabel101);
            this.bosPanel1.Controls.Add(this.fld_lkeACEntryTypeID);
            this.bosPanel1.Controls.Add(this.fld_dgcACDocTypeEntrys);
            this.bosPanel1.Controls.Add(this.fld_btnCancel);
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(900, 544);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lblLabel101
            // 
            this.fld_lblLabel101.BOSComment = null;
            this.fld_lblLabel101.BOSDataMember = null;
            this.fld_lblLabel101.BOSDataSource = null;
            this.fld_lblLabel101.BOSDescription = null;
            this.fld_lblLabel101.BOSError = null;
            this.fld_lblLabel101.BOSFieldGroup = null;
            this.fld_lblLabel101.BOSFieldRelation = null;
            this.fld_lblLabel101.BOSPrivilege = null;
            this.fld_lblLabel101.BOSPropertyName = null;
            this.fld_lblLabel101.Location = new System.Drawing.Point(12, 19);
            this.fld_lblLabel101.Name = "fld_lblLabel101";
            this.fld_lblLabel101.Screen = null;
            this.fld_lblLabel101.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel101.TabIndex = 4;
            this.fld_lblLabel101.Text = "Bút toán";
            // 
            // fld_lkeACEntryTypeID
            // 
            this.fld_lkeACEntryTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeACEntryTypeID.BOSAllowAddNew = true;
            this.fld_lkeACEntryTypeID.BOSAllowDummy = false;
            this.fld_lkeACEntryTypeID.BOSComment = null;
            this.fld_lkeACEntryTypeID.BOSDataMember = "FK_ACEntryTypeID";
            this.fld_lkeACEntryTypeID.BOSDataSource = "ACDocTypeEntrys";
            this.fld_lkeACEntryTypeID.BOSDescription = null;
            this.fld_lkeACEntryTypeID.BOSError = null;
            this.fld_lkeACEntryTypeID.BOSFieldGroup = null;
            this.fld_lkeACEntryTypeID.BOSFieldParent = null;
            this.fld_lkeACEntryTypeID.BOSFieldRelation = null;
            this.fld_lkeACEntryTypeID.BOSPrivilege = null;
            this.fld_lkeACEntryTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeACEntryTypeID.BOSSelectType = null;
            this.fld_lkeACEntryTypeID.BOSSelectTypeValue = null;
            this.fld_lkeACEntryTypeID.CurrentDisplayText = null;
            this.fld_lkeACEntryTypeID.EditValue = "";
            this.fld_lkeACEntryTypeID.Location = new System.Drawing.Point(74, 16);
            this.fld_lkeACEntryTypeID.MenuManager = this.screenToolbar;
            this.fld_lkeACEntryTypeID.Name = "fld_lkeACEntryTypeID";
            this.fld_lkeACEntryTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEntryTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEntryTypeDesc", "Bút toán")});
            this.fld_lkeACEntryTypeID.Properties.DisplayMember = "ACEntryTypeDesc";
            this.fld_lkeACEntryTypeID.Properties.NullText = "";
            this.fld_lkeACEntryTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEntryTypeID.Properties.ValueMember = "ACEntryTypeID";
            this.fld_lkeACEntryTypeID.Screen = null;
            this.fld_lkeACEntryTypeID.Size = new System.Drawing.Size(814, 20);
            this.fld_lkeACEntryTypeID.TabIndex = 1;
            this.fld_lkeACEntryTypeID.Tag = "DC";
            this.fld_lkeACEntryTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ACEntryTypeID_KeyUp);
            // 
            // fld_dgcACDocTypeEntrys
            // 
            this.fld_dgcACDocTypeEntrys.AllowDrop = true;
            this.fld_dgcACDocTypeEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDocTypeEntrys.BOSComment = null;
            this.fld_dgcACDocTypeEntrys.BOSDataMember = null;
            this.fld_dgcACDocTypeEntrys.BOSDataSource = "ACDocTypeEntrys";
            this.fld_dgcACDocTypeEntrys.BOSDescription = null;
            this.fld_dgcACDocTypeEntrys.BOSError = null;
            this.fld_dgcACDocTypeEntrys.BOSFieldGroup = null;
            this.fld_dgcACDocTypeEntrys.BOSFieldRelation = null;
            this.fld_dgcACDocTypeEntrys.BOSGridType = null;
            this.fld_dgcACDocTypeEntrys.BOSPrivilege = null;
            this.fld_dgcACDocTypeEntrys.BOSPropertyName = null;
            this.fld_dgcACDocTypeEntrys.Location = new System.Drawing.Point(0, 46);
            this.fld_dgcACDocTypeEntrys.Name = "fld_dgcACDocTypeEntrys";
            this.fld_dgcACDocTypeEntrys.Screen = null;
            this.fld_dgcACDocTypeEntrys.Size = new System.Drawing.Size(900, 444);
            this.fld_dgcACDocTypeEntrys.TabIndex = 4;
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
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(813, 505);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(722, 505);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiEditDocumentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(900, 544);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiEditDocumentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình bút toán";
            this.Load += new System.EventHandler(this.guiEditDocumentType_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEntryTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private ACDocTypeEntrysGridControl fld_dgcACDocTypeEntrys;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLookupEdit fld_lkeACEntryTypeID;
        private BOSComponent.BOSLabel fld_lblLabel101;
    }
}