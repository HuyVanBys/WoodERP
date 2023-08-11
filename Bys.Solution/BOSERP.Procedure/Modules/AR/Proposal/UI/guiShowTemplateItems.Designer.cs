namespace BOSERP.Modules.Proposal
{
    partial class guiShowTemplateItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowTemplateItems));
            this.label1 = new System.Windows.Forms.Label();
            this.fld_trlTemplateItems = new BOSComponent.BOSTreeListControl(this.components);
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vui lòng chọn hạng mục thuộc bảng định mức mẫu";
            // 
            // fld_trlTemplateItems
            // 
            this.fld_trlTemplateItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlTemplateItems.BOSComment = null;
            this.fld_trlTemplateItems.BOSDataMember = null;
            this.fld_trlTemplateItems.BOSDataSource = null;
            this.fld_trlTemplateItems.BOSDescription = null;
            this.fld_trlTemplateItems.BOSDisplayOption = false;
            this.fld_trlTemplateItems.BOSDisplayRoot = false;
            this.fld_trlTemplateItems.BOSError = null;
            this.fld_trlTemplateItems.BOSFieldGroup = null;
            this.fld_trlTemplateItems.BOSFieldRelation = null;
            this.fld_trlTemplateItems.BOSPrivilege = null;
            this.fld_trlTemplateItems.BOSPropertyName = null;
            this.fld_trlTemplateItems.Location = new System.Drawing.Point(12, 25);
            this.fld_trlTemplateItems.Name = "fld_trlTemplateItems";
            this.fld_trlTemplateItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlTemplateItems.OptionsView.ShowColumns = false;
            this.fld_trlTemplateItems.OptionsView.ShowIndicator = false;
            this.fld_trlTemplateItems.Screen = null;
            this.fld_trlTemplateItems.Size = new System.Drawing.Size(489, 519);
            this.fld_trlTemplateItems.TabIndex = 15;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(420, 550);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(81, 31);
            this.fld_btnCancel.TabIndex = 12;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.Fld_btnCancel_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(333, 550);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(81, 31);
            this.fld_btnOK.TabIndex = 11;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.Fld_btnOK_Click);
            // 
            // guiShowTemplateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 588);
            this.ControlBox = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fld_trlTemplateItems);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiShowTemplateItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn hạng mục";
            this.Load += new System.EventHandler(this.guiTemplateItems_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_trlTemplateItems, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlTemplateItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public BOSComponent.BOSTreeListControl fld_trlTemplateItems;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
    }
}