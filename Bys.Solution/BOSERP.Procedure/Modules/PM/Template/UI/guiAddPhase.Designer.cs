namespace BOSERP.Modules.Template
{
    partial class guiAddPhase<T>
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
            this.fld_btnAddNewPhaseType = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPhaseTypesGridControl = new BOSERP.Modules.Template.PhaseTypesGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPhaseTypesGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnAddNewPhaseType
            // 
            this.fld_btnAddNewPhaseType.AllowFocus = false;
            this.fld_btnAddNewPhaseType.BOSComment = null;
            this.fld_btnAddNewPhaseType.BOSDataMember = null;
            this.fld_btnAddNewPhaseType.BOSDataSource = null;
            this.fld_btnAddNewPhaseType.BOSDescription = null;
            this.fld_btnAddNewPhaseType.BOSError = null;
            this.fld_btnAddNewPhaseType.BOSFieldGroup = null;
            this.fld_btnAddNewPhaseType.BOSFieldRelation = null;
            this.fld_btnAddNewPhaseType.BOSPrivilege = null;
            this.fld_btnAddNewPhaseType.BOSPropertyName = null;
            this.fld_btnAddNewPhaseType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnAddNewPhaseType.Location = new System.Drawing.Point(678, 12);
            this.fld_btnAddNewPhaseType.Name = "fld_btnAddNewPhaseType";
            this.fld_btnAddNewPhaseType.Screen = null;
            this.fld_btnAddNewPhaseType.Size = new System.Drawing.Size(109, 27);
            this.fld_btnAddNewPhaseType.TabIndex = 1;
            this.fld_btnAddNewPhaseType.Text = "Thêm mới giai đoạn";
            this.fld_btnAddNewPhaseType.Click += new System.EventHandler(this.fld_btnAddNewPhaseType_Click);
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "PMPhaseTypes";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(68, 16);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 0;
            this.fld_lkeFK_PMProjectTypeID.Tag = "DC";
            this.fld_lkeFK_PMProjectTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_PMProjectTypeID_KeyUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 19);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(50, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.Text = "Loại dự án";
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
            this.fld_btnClose.TabIndex = 4;
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
            // fld_dgcPhaseTypesGridControl
            // 
            this.fld_dgcPhaseTypesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPhaseTypesGridControl.BOSComment = null;
            this.fld_dgcPhaseTypesGridControl.BOSDataMember = null;
            this.fld_dgcPhaseTypesGridControl.BOSDataSource = "PMPhaseTypes";
            this.fld_dgcPhaseTypesGridControl.BOSDescription = null;
            this.fld_dgcPhaseTypesGridControl.BOSError = null;
            this.fld_dgcPhaseTypesGridControl.BOSFieldGroup = null;
            this.fld_dgcPhaseTypesGridControl.BOSFieldRelation = null;
            this.fld_dgcPhaseTypesGridControl.BOSGridType = null;
            this.fld_dgcPhaseTypesGridControl.BOSPrivilege = null;
            this.fld_dgcPhaseTypesGridControl.BOSPropertyName = null;
            this.fld_dgcPhaseTypesGridControl.Location = new System.Drawing.Point(12, 45);
            this.fld_dgcPhaseTypesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPhaseTypesGridControl.Name = "fld_dgcPhaseTypesGridControl";
            this.fld_dgcPhaseTypesGridControl.PrintReport = false;
            this.fld_dgcPhaseTypesGridControl.Screen = null;
            this.fld_dgcPhaseTypesGridControl.Size = new System.Drawing.Size(775, 493);
            this.fld_dgcPhaseTypesGridControl.TabIndex = 2;
            this.fld_dgcPhaseTypesGridControl.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // guiAddPhase
            // 
            this.AcceptButton = this.fld_btnAddNewPhaseType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(799, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcPhaseTypesGridControl);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_btnAddNewPhaseType);
            this.Name = "guiAddPhase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách giai đoạn";
            this.Load += new System.EventHandler(this.guiAddPhase_Load);
            this.Controls.SetChildIndex(this.fld_btnAddNewPhaseType, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID, 0);
            this.Controls.SetChildIndex(this.fld_dgcPhaseTypesGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPhaseTypesGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnAddNewPhaseType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private PhaseTypesGridControl fld_dgcPhaseTypesGridControl;
    }
}