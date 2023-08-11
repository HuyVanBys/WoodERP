namespace BOSERP.Modules.Template
{
    partial class guiAddNewPhase<T>
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
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medPMPhaseTypeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtPMPhaseTypeName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMPhaseTypeNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMPhaseTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "PMPhaseTypes";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(292, 12);
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
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 1;
            this.fld_lkeFK_PMProjectTypeID.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(62, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Mã giai đoạn";
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
            this.fld_btnClose.Location = new System.Drawing.Point(400, 114);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 5;
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
            this.fld_btnApply.Location = new System.Drawing.Point(311, 114);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Thêm";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(66, 13);
            this.bosLabel1.TabIndex = 129;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Tên giai đoạn";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(12, 66);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 130;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Mô tả";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(236, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(50, 13);
            this.bosLabel5.TabIndex = 132;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Loại dự án";
            // 
            // fld_medPMPhaseTypeDesc
            // 
            this.fld_medPMPhaseTypeDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medPMPhaseTypeDesc.BOSDataMember = "PMPhaseTypeDesc";
            this.fld_medPMPhaseTypeDesc.BOSDataSource = "PMPhaseTypes";
            this.fld_medPMPhaseTypeDesc.BOSDescription = null;
            this.fld_medPMPhaseTypeDesc.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medPMPhaseTypeDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medPMPhaseTypeDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medPMPhaseTypeDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medPMPhaseTypeDesc.BOSPropertyName = "Text";
            this.fld_medPMPhaseTypeDesc.Location = new System.Drawing.Point(84, 63);
            this.fld_medPMPhaseTypeDesc.Name = "fld_medPMPhaseTypeDesc";
            this.fld_medPMPhaseTypeDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medPMPhaseTypeDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medPMPhaseTypeDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medPMPhaseTypeDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medPMPhaseTypeDesc.Screen = null;
            this.fld_medPMPhaseTypeDesc.Size = new System.Drawing.Size(399, 39);
            this.fld_medPMPhaseTypeDesc.TabIndex = 3;
            this.fld_medPMPhaseTypeDesc.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_txtPMPhaseTypeName
            // 
            this.fld_txtPMPhaseTypeName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeName.BOSDataMember = "PMPhaseTypeName";
            this.fld_txtPMPhaseTypeName.BOSDataSource = "PMPhaseTypes";
            this.fld_txtPMPhaseTypeName.BOSDescription = null;
            this.fld_txtPMPhaseTypeName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeName.BOSPropertyName = "Text";
            this.fld_txtPMPhaseTypeName.Location = new System.Drawing.Point(84, 38);
            this.fld_txtPMPhaseTypeName.Name = "fld_txtPMPhaseTypeName";
            this.fld_txtPMPhaseTypeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMPhaseTypeName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMPhaseTypeName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMPhaseTypeName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMPhaseTypeName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMPhaseTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMPhaseTypeName.Screen = null;
            this.fld_txtPMPhaseTypeName.Size = new System.Drawing.Size(398, 20);
            this.fld_txtPMPhaseTypeName.TabIndex = 2;
            this.fld_txtPMPhaseTypeName.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_txtPMPhaseTypeNo
            // 
            this.fld_txtPMPhaseTypeNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeNo.BOSDataMember = "PMPhaseTypeNo";
            this.fld_txtPMPhaseTypeNo.BOSDataSource = "PMPhaseTypes";
            this.fld_txtPMPhaseTypeNo.BOSDescription = null;
            this.fld_txtPMPhaseTypeNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMPhaseTypeNo.BOSPropertyName = "Text";
            this.fld_txtPMPhaseTypeNo.Location = new System.Drawing.Point(84, 12);
            this.fld_txtPMPhaseTypeNo.Name = "fld_txtPMPhaseTypeNo";
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMPhaseTypeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMPhaseTypeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMPhaseTypeNo.Screen = null;
            this.fld_txtPMPhaseTypeNo.Size = new System.Drawing.Size(146, 20);
            this.fld_txtPMPhaseTypeNo.TabIndex = 0;
            this.fld_txtPMPhaseTypeNo.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // guiAddNewPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(494, 153);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtPMPhaseTypeNo);
            this.Controls.Add(this.fld_txtPMPhaseTypeName);
            this.Controls.Add(this.fld_medPMPhaseTypeDesc);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.Name = "guiAddNewPhase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới giai đoạn";
            this.Load += new System.EventHandler(this.guiAddPhase_Load);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_medPMPhaseTypeDesc, 0);
            this.Controls.SetChildIndex(this.fld_txtPMPhaseTypeName, 0);
            this.Controls.SetChildIndex(this.fld_txtPMPhaseTypeNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMPhaseTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSMemoEdit fld_medPMPhaseTypeDesc;
        private BOSComponent.BOSTextBox fld_txtPMPhaseTypeName;
        private BOSComponent.BOSTextBox fld_txtPMPhaseTypeNo;
    }
}