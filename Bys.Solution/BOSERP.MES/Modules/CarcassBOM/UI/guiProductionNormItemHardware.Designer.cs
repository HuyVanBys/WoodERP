namespace BOSERP.Modules.CarcassBOM
{
    partial class guiProductionNormItemHardware
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
            this.fld_btnSave = new BOSComponent.BOSButton();
            this.fld_btnCancel = new BOSComponent.BOSButton();
            this.fld_dgcProductionNormItemHardware = new BOSERP.Modules.CarcassBOM.ProductionNormItemHardwareDetailsGridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblHardwareQty = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemHardware)).BeginInit();
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
            this.fld_btnSave.Location = new System.Drawing.Point(742, 560);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(823, 560);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcProductionNormItemHardware
            // 
            this.fld_dgcProductionNormItemHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionNormItemHardware.BOSComment = null;
            this.fld_dgcProductionNormItemHardware.BOSDataMember = null;
            this.fld_dgcProductionNormItemHardware.BOSDataSource = "MMProductionNormItemHardwares";
            this.fld_dgcProductionNormItemHardware.BOSDescription = null;
            this.fld_dgcProductionNormItemHardware.BOSError = null;
            this.fld_dgcProductionNormItemHardware.BOSFieldGroup = null;
            this.fld_dgcProductionNormItemHardware.BOSFieldRelation = null;
            this.fld_dgcProductionNormItemHardware.BOSGridType = null;
            this.fld_dgcProductionNormItemHardware.BOSPrivilege = null;
            this.fld_dgcProductionNormItemHardware.BOSPropertyName = null;
            this.fld_dgcProductionNormItemHardware.CommodityType = "";
            this.fld_dgcProductionNormItemHardware.Location = new System.Drawing.Point(2, 37);
            this.fld_dgcProductionNormItemHardware.MenuManager = this.screenToolbar;
            this.fld_dgcProductionNormItemHardware.Name = "fld_dgcProductionNormItemHardware";
            this.fld_dgcProductionNormItemHardware.PrintReport = false;
            this.fld_dgcProductionNormItemHardware.Screen = null;
            this.fld_dgcProductionNormItemHardware.Size = new System.Drawing.Size(896, 517);
            this.fld_dgcProductionNormItemHardware.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tổng SL định mức:";
            // 
            // fld_lblHardwareQty
            // 
            this.fld_lblHardwareQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblHardwareQty.Appearance.Options.UseFont = true;
            this.fld_lblHardwareQty.Location = new System.Drawing.Point(107, 4);
            this.fld_lblHardwareQty.Name = "fld_lblHardwareQty";
            this.fld_lblHardwareQty.Size = new System.Drawing.Size(0, 13);
            this.fld_lblHardwareQty.TabIndex = 8;
            // 
            // guiProductionNormItemHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(900, 594);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblHardwareQty);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_dgcProductionNormItemHardware);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Name = "guiProductionNormItemHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết hardware";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductionNormItemHardware, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lblHardwareQty, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemHardware)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private ProductionNormItemHardwareDetailsGridControl fld_dgcProductionNormItemHardware;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl fld_lblHardwareQty;
    }
}