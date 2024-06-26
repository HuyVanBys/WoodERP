namespace BOSERP.Modules.Project
{
    partial class guiAddWork<T>
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
            this.fld_btnAddPhaseType = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductWorkGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductWorksGridControl = new BOSERP.Modules.Project.ProductWorksGridControl();
            this.fld_txtFind = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductWorkGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorksGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnAddPhaseType
            // 
            this.fld_btnAddPhaseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddPhaseType.BOSComment = null;
            this.fld_btnAddPhaseType.BOSDataMember = null;
            this.fld_btnAddPhaseType.BOSDataSource = null;
            this.fld_btnAddPhaseType.BOSDescription = null;
            this.fld_btnAddPhaseType.BOSError = null;
            this.fld_btnAddPhaseType.BOSFieldGroup = null;
            this.fld_btnAddPhaseType.BOSFieldRelation = null;
            this.fld_btnAddPhaseType.BOSPrivilege = null;
            this.fld_btnAddPhaseType.BOSPropertyName = null;
            this.fld_btnAddPhaseType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnAddPhaseType.Location = new System.Drawing.Point(811, 12);
            this.fld_btnAddPhaseType.Name = "fld_btnAddPhaseType";
            this.fld_btnAddPhaseType.Screen = null;
            this.fld_btnAddPhaseType.Size = new System.Drawing.Size(115, 39);
            this.fld_btnAddPhaseType.TabIndex = 1;
            this.fld_btnAddPhaseType.Text = "Thêm mới công việc";
            this.fld_btnAddPhaseType.Visible = false;
            // 
            // fld_lkeFK_ICProductWorkGroupID
            // 
            this.fld_lkeFK_ICProductWorkGroupID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductWorkGroupID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductWorkGroupID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSDataMember = "FK_ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductWorkGroupID.BOSDescription = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSError = null;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductWorkGroupID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductWorkGroupID.Location = new System.Drawing.Point(12, 31);
            this.fld_lkeFK_ICProductWorkGroupID.Name = "fld_lkeFK_ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductWorkGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductWorkGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductWorkGroupName", 300, "Tên nhóm")});
            this.fld_lkeFK_ICProductWorkGroupID.Properties.DisplayMember = "ICProductWorkGroupName";
            this.fld_lkeFK_ICProductWorkGroupID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductWorkGroupID.Properties.ValueMember = "ICProductWorkGroupID";
            this.fld_lkeFK_ICProductWorkGroupID.Screen = null;
            this.fld_lkeFK_ICProductWorkGroupID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_ICProductWorkGroupID.TabIndex = 127;
            this.fld_lkeFK_ICProductWorkGroupID.Tag = "DC";
            this.fld_lkeFK_ICProductWorkGroupID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductWorkGroupID_KeyUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(78, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Nhóm công việc";
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
            this.fld_btnClose.Location = new System.Drawing.Point(843, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
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
            this.fld_btnApply.Location = new System.Drawing.Point(754, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductWorksGridControl
            // 
            this.fld_dgcProductWorksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductWorksGridControl.BOSComment = null;
            this.fld_dgcProductWorksGridControl.BOSDataMember = null;
            this.fld_dgcProductWorksGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcProductWorksGridControl.BOSDescription = null;
            this.fld_dgcProductWorksGridControl.BOSError = null;
            this.fld_dgcProductWorksGridControl.BOSFieldGroup = null;
            this.fld_dgcProductWorksGridControl.BOSFieldRelation = null;
            this.fld_dgcProductWorksGridControl.BOSGridType = null;
            this.fld_dgcProductWorksGridControl.BOSPrivilege = null;
            this.fld_dgcProductWorksGridControl.BOSPropertyName = null;
            this.fld_dgcProductWorksGridControl.Location = new System.Drawing.Point(12, 80);
            this.fld_dgcProductWorksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductWorksGridControl.Name = "fld_dgcProductWorksGridControl";
            this.fld_dgcProductWorksGridControl.PrintReport = false;
            this.fld_dgcProductWorksGridControl.Screen = null;
            this.fld_dgcProductWorksGridControl.Size = new System.Drawing.Size(914, 458);
            this.fld_dgcProductWorksGridControl.TabIndex = 129;
            this.fld_dgcProductWorksGridControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_txtFind
            // 
            this.fld_txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtFind.BOSComment = null;
            this.fld_txtFind.BOSDataMember = null;
            this.fld_txtFind.BOSDataSource = null;
            this.fld_txtFind.BOSDescription = null;
            this.fld_txtFind.BOSError = null;
            this.fld_txtFind.BOSFieldGroup = null;
            this.fld_txtFind.BOSFieldRelation = null;
            this.fld_txtFind.BOSPrivilege = null;
            this.fld_txtFind.BOSPropertyName = null;
            this.fld_txtFind.EditValue = "Nhập vào từ khóa tìm kiếm";
            this.fld_txtFind.Location = new System.Drawing.Point(217, 31);
            this.fld_txtFind.MenuManager = this.screenToolbar;
            this.fld_txtFind.Name = "fld_txtFind";
            this.fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtFind.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFind.Screen = null;
            this.fld_txtFind.Size = new System.Drawing.Size(588, 20);
            this.fld_txtFind.TabIndex = 130;
            this.fld_txtFind.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_txtFind_EditValueChanging);
            this.fld_txtFind.Leave += new System.EventHandler(this.fld_txtFind_Leave);
            this.fld_txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtFind_KeyUp);
            this.fld_txtFind.Click += new System.EventHandler(this.fld_txtFind_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(217, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(186, 13);
            this.bosLabel1.TabIndex = 131;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Tìm kiếm theo mã, tên, mô tả công việc";
            // 
            // guiAddWork
            // 
            this.AcceptButton = this.fld_btnAddPhaseType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtFind);
            this.Controls.Add(this.fld_dgcProductWorksGridControl);
            this.Controls.Add(this.fld_lkeFK_ICProductWorkGroupID);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_btnAddPhaseType);
            this.Name = "guiAddWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách công việc";
            this.Load += new System.EventHandler(this.guiAddWork_Load);
            this.Controls.SetChildIndex(this.fld_btnAddPhaseType, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductWorkGroupID, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductWorksGridControl, 0);
            this.Controls.SetChildIndex(this.fld_txtFind, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductWorkGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorksGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnAddPhaseType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductWorkGroupID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ProductWorksGridControl fld_dgcProductWorksGridControl;
        private BOSComponent.BOSTextBox fld_txtFind;
        private BOSComponent.BOSLabel bosLabel1;
    }
}