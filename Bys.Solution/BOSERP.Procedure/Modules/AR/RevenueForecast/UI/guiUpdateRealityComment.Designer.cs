namespace BOSERP.Modules.RevenueForecast
{
    partial class guiUpdateRealityComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiUpdateRealityComment));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_medARRevenueForecastItemRealComment = new BOSComponent.BOSMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARRevenueForecastItemRealComment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_btnClose.Location = new System.Drawing.Point(476, 121);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 29);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(373, 121);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 29);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_medARRevenueForecastItemRealComment
            // 
            this.fld_medARRevenueForecastItemRealComment.BOSComment = "";
            this.fld_medARRevenueForecastItemRealComment.BOSDataMember = "ICProductPackagingDetail";
            this.fld_medARRevenueForecastItemRealComment.BOSDataSource = "ICProducts";
            this.fld_medARRevenueForecastItemRealComment.BOSDescription = null;
            this.fld_medARRevenueForecastItemRealComment.BOSError = null;
            this.fld_medARRevenueForecastItemRealComment.BOSFieldGroup = "";
            this.fld_medARRevenueForecastItemRealComment.BOSFieldRelation = "";
            this.fld_medARRevenueForecastItemRealComment.BOSPrivilege = "";
            this.fld_medARRevenueForecastItemRealComment.BOSPropertyName = "Text";
            this.fld_medARRevenueForecastItemRealComment.EditValue = "";
            this.fld_medARRevenueForecastItemRealComment.Location = new System.Drawing.Point(3, 0);
            this.fld_medARRevenueForecastItemRealComment.Name = "fld_medARRevenueForecastItemRealComment";
            this.fld_medARRevenueForecastItemRealComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARRevenueForecastItemRealComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARRevenueForecastItemRealComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARRevenueForecastItemRealComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARRevenueForecastItemRealComment.Screen = null;
            this.fld_medARRevenueForecastItemRealComment.Size = new System.Drawing.Size(565, 108);
            this.fld_medARRevenueForecastItemRealComment.TabIndex = 476;
            this.fld_medARRevenueForecastItemRealComment.Tag = "DC";
            // 
            // guiUpdateRealityComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(571, 162);
            this.ControlBox = true;
            this.Controls.Add(this.fld_medARRevenueForecastItemRealComment);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiUpdateRealityComment.IconOptions.Icon")));
            this.Name = "guiUpdateRealityComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi chú thực tế";
            this.Load += new System.EventHandler(this.guiAddPhase_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_medARRevenueForecastItemRealComment, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARRevenueForecastItemRealComment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSMemoEdit fld_medARRevenueForecastItemRealComment;
    }
}