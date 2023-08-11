namespace BOSERP.Modules.ProductionNorm.UI
{
    partial class guiProductionNormItemMeterials
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
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductionNormItemMeterial = new BOSERP.Modules.ProductionNorm.ProductionNormItemMeterialGridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblProductSize = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemMeterial)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnSave.Location = new System.Drawing.Point(736, 553);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(817, 553);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcProductionNormItemMeterial
            // 
            this.fld_dgcProductionNormItemMeterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionNormItemMeterial.BOSComment = null;
            this.fld_dgcProductionNormItemMeterial.BOSDataMember = null;
            this.fld_dgcProductionNormItemMeterial.BOSDataSource = "MMProductionNormItemMeterials";
            this.fld_dgcProductionNormItemMeterial.BOSDescription = null;
            this.fld_dgcProductionNormItemMeterial.BOSError = null;
            this.fld_dgcProductionNormItemMeterial.BOSFieldGroup = null;
            this.fld_dgcProductionNormItemMeterial.BOSFieldRelation = null;
            this.fld_dgcProductionNormItemMeterial.BOSGridType = null;
            this.fld_dgcProductionNormItemMeterial.BOSPrivilege = null;
            this.fld_dgcProductionNormItemMeterial.BOSPropertyName = null;
            this.fld_dgcProductionNormItemMeterial.Location = new System.Drawing.Point(2, 65);
            this.fld_dgcProductionNormItemMeterial.MenuManager = this.screenToolbar;
            this.fld_dgcProductionNormItemMeterial.Name = "fld_dgcProductionNormItemMeterial";
            this.fld_dgcProductionNormItemMeterial.PrintReport = false;
            this.fld_dgcProductionNormItemMeterial.Screen = null;
            this.fld_dgcProductionNormItemMeterial.Size = new System.Drawing.Size(890, 482);
            this.fld_dgcProductionNormItemMeterial.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Quy cách chi tiết BTP:";
            // 
            // fld_lblProductSize
            // 
            this.fld_lblProductSize.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblProductSize.Appearance.Options.UseFont = true;
            this.fld_lblProductSize.Location = new System.Drawing.Point(123, 12);
            this.fld_lblProductSize.Name = "fld_lblProductSize";
            this.fld_lblProductSize.Size = new System.Drawing.Size(0, 13);
            this.fld_lblProductSize.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(792, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "* Mặc định \"khối lượng\" là khối lượng tiêu hao của chi tiết, khối lượng sẽ được t" +
                "ính lại dựa vào quy cách dày rộng dài của ván và số lượng cấp.";
            // 
            // guiProductionNormItemMeterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(894, 587);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblProductSize);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_dgcProductionNormItemMeterial);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Name = "guiProductionNormItemMeterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nguyên liệu";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductionNormItemMeterial, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.fld_lblProductSize, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemMeterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private ProductionNormItemMeterialGridControl fld_dgcProductionNormItemMeterial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl fld_lblProductSize;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}