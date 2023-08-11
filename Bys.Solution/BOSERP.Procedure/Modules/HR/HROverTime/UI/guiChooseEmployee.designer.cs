using BOSERP.Modules.HROverTime;
namespace BOSERP.Modules.HROverTime
{
    partial class guiChooseEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseEmployee));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_medEmployeeNo = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medEmployeeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(501, 189);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(582, 189);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_medEmployeeNo
            // 
            this.fld_medEmployeeNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSDescription = null;
            this.fld_medEmployeeNo.BOSError = null;
            this.fld_medEmployeeNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.BOSPropertyName = "Text";
            this.fld_medEmployeeNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medEmployeeNo.Location = new System.Drawing.Point(12, 37);
            this.fld_medEmployeeNo.Name = "fld_medEmployeeNo";
            this.fld_medEmployeeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medEmployeeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medEmployeeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medEmployeeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medEmployeeNo.Screen = null;
            this.fld_medEmployeeNo.Size = new System.Drawing.Size(645, 146);
            this.fld_medEmployeeNo.TabIndex = 19;
            this.fld_medEmployeeNo.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Location = new System.Drawing.Point(12, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(200, 13);
            this.bosLabel7.TabIndex = 20;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "(*) Mã chấm công cách nhau bằng dấu (,)";
            // 
            // guiChooseEmployee
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 228);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_medEmployeeNo);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mã chấm công nhân viên";
            this.Load += new System.EventHandler(this.guiChooseEmployee_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_medEmployeeNo, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medEmployeeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSMemoEdit fld_medEmployeeNo;
        private BOSComponent.BOSLabel bosLabel7;
    }
}