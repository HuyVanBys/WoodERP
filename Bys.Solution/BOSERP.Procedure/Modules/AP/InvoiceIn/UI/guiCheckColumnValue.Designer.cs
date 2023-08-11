namespace BOSERP.Modules.InvoiceIn.UI
{
    partial class guiCheckColumnValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCheckColumnValue));
            this.fld_dgcErrorList = new BOSERP.ACDocTypeEntryAccountsGridControl();
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcErrorList)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcErrorList
            // 
            this.fld_dgcErrorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcErrorList.BOSComment = null;
            this.fld_dgcErrorList.BOSDataMember = null;
            this.fld_dgcErrorList.BOSDataSource = "";
            this.fld_dgcErrorList.BOSDescription = null;
            this.fld_dgcErrorList.BOSError = null;
            this.fld_dgcErrorList.BOSFieldGroup = null;
            this.fld_dgcErrorList.BOSFieldRelation = null;
            this.fld_dgcErrorList.BOSGridType = null;
            this.fld_dgcErrorList.BOSPrivilege = null;
            this.fld_dgcErrorList.BOSPropertyName = null;
            this.fld_dgcErrorList.Location = new System.Drawing.Point(0, 34);
            this.fld_dgcErrorList.MenuManager = this.screenToolbar;
            this.fld_dgcErrorList.Name = "fld_dgcErrorList";
            this.fld_dgcErrorList.PrintReport = false;
            this.fld_dgcErrorList.Screen = null;
            this.fld_dgcErrorList.Size = new System.Drawing.Size(612, 312);
            this.fld_dgcErrorList.TabIndex = 6;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancel.Appearance.Options.UseForeColor = true;
            this.fld_btnCancel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(531, 356);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 25);
            this.fld_btnCancel.TabIndex = 11;
            this.fld_btnCancel.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnCancel.Text = "Đồng ý";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Location = new System.Drawing.Point(12, 12);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(181, 13);
            this.bosLabel6.TabIndex = 14;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Các trường sau không được để trống:";
            // 
            // guiCheckColumnValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 390);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_dgcErrorList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiCheckColumnValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lỗi";
            this.Load += new System.EventHandler(this.guiCheckColumnValue_Load);
            this.Controls.SetChildIndex(this.fld_dgcErrorList, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcErrorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ACDocTypeEntryAccountsGridControl fld_dgcErrorList;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel bosLabel6;

    }
}