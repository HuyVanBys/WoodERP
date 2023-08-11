namespace BOSERP.Modules.Template
{
    partial class guiAddWorkGroup<T>
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
            this.fld_lkeFK_PMPhaseTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductWorkGroupsGridControl = new BOSERP.Modules.Template.ProductWorkGroupsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkGroupsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnAddPhaseType
            // 
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
            this.fld_btnAddPhaseType.Location = new System.Drawing.Point(642, 9);
            this.fld_btnAddPhaseType.Name = "fld_btnAddPhaseType";
            this.fld_btnAddPhaseType.Screen = null;
            this.fld_btnAddPhaseType.Size = new System.Drawing.Size(145, 27);
            this.fld_btnAddPhaseType.TabIndex = 1;
            this.fld_btnAddPhaseType.Text = "Thêm mới nhóm công việc";
            // 
            // fld_lkeFK_PMPhaseTypeID
            // 
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMPhaseTypeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSDataMember = "FK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.BOSDataSource = "ICProductWorkGroups";
            this.fld_lkeFK_PMPhaseTypeID.BOSDescription = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSError = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMPhaseTypeID.Location = new System.Drawing.Point(68, 16);
            this.fld_lkeFK_PMPhaseTypeID.Name = "fld_lkeFK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMPhaseTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMPhaseTypeName", 300, "Giai đoạn")});
            this.fld_lkeFK_PMPhaseTypeID.Properties.DisplayMember = "PMPhaseTypeName";
            this.fld_lkeFK_PMPhaseTypeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMPhaseTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMPhaseTypeID.Properties.ValueMember = "PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Screen = null;
            this.fld_lkeFK_PMPhaseTypeID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_PMPhaseTypeID.TabIndex = 127;
            this.fld_lkeFK_PMPhaseTypeID.Tag = "DC";
            this.fld_lkeFK_PMPhaseTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_PMPhaseTypeID_KeyUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 19);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(46, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "Giai đoạn";
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
            this.fld_btnClose.Location = new System.Drawing.Point(704, 544);
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
            this.fld_btnApply.Location = new System.Drawing.Point(615, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductWorkGroupsGridControl
            // 
            this.fld_dgcProductWorkGroupsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductWorkGroupsGridControl.BOSComment = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSDataMember = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSDataSource = "ICProductWorkGroups";
            this.fld_dgcProductWorkGroupsGridControl.BOSDescription = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSError = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSGridType = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSPrivilege = null;
            this.fld_dgcProductWorkGroupsGridControl.BOSPropertyName = null;
            this.fld_dgcProductWorkGroupsGridControl.Location = new System.Drawing.Point(12, 45);
            this.fld_dgcProductWorkGroupsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductWorkGroupsGridControl.Name = "fld_dgcProductWorkGroupsGridControl";
            this.fld_dgcProductWorkGroupsGridControl.PrintReport = false;
            this.fld_dgcProductWorkGroupsGridControl.Screen = null;
            this.fld_dgcProductWorkGroupsGridControl.Size = new System.Drawing.Size(775, 493);
            this.fld_dgcProductWorkGroupsGridControl.TabIndex = 129;
            this.fld_dgcProductWorkGroupsGridControl.Tag = global::Localization.CommonLocalizedResources.String2;
            // 
            // guiAddWorkGroup
            // 
            this.AcceptButton = this.fld_btnAddPhaseType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(799, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcProductWorkGroupsGridControl);
            this.Controls.Add(this.fld_lkeFK_PMPhaseTypeID);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_btnAddPhaseType);
            this.Name = "guiAddWorkGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách nhóm công việc";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.fld_btnAddPhaseType, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMPhaseTypeID, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductWorkGroupsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkGroupsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnAddPhaseType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMPhaseTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ProductWorkGroupsGridControl fld_dgcProductWorkGroupsGridControl;
    }
}