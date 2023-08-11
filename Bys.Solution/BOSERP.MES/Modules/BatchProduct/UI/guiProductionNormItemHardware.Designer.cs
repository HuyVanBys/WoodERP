namespace BOSERP.Modules.BatchProduct
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
            this.components = new System.ComponentModel.Container();
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcBatchProductProductionNormItemHardware = new BOSERP.Modules.BatchProduct.BatchProductItemHardwareDetailsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductProductionNormItemHardware)).BeginInit();
            this.SuspendLayout();
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
            // fld_dgcBatchProductProductionNormItemHardware
            // 
            this.fld_dgcBatchProductProductionNormItemHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBatchProductProductionNormItemHardware.BOSComment = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSDataMember = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSDataSource = "MMBatchProductProductionNormItemHardwares";
            this.fld_dgcBatchProductProductionNormItemHardware.BOSDescription = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSError = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSFieldGroup = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSFieldRelation = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSGridType = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSPrivilege = null;
            this.fld_dgcBatchProductProductionNormItemHardware.BOSPropertyName = null;
            this.fld_dgcBatchProductProductionNormItemHardware.Location = new System.Drawing.Point(2, 12);
            this.fld_dgcBatchProductProductionNormItemHardware.MenuManager = this.screenToolbar;
            this.fld_dgcBatchProductProductionNormItemHardware.Name = "fld_dgcBatchProductProductionNormItemHardware";
            this.fld_dgcBatchProductProductionNormItemHardware.PrintReport = false;
            this.fld_dgcBatchProductProductionNormItemHardware.Screen = null;
            this.fld_dgcBatchProductProductionNormItemHardware.Size = new System.Drawing.Size(890, 535);
            this.fld_dgcBatchProductProductionNormItemHardware.TabIndex = 6;
            // 
            // guiProductionNormItemHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(894, 587);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcBatchProductProductionNormItemHardware);
            this.Controls.Add(this.fld_btnCancel);
            this.Name = "guiProductionNormItemHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết hardware";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcBatchProductProductionNormItemHardware, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductProductionNormItemHardware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnCancel;
        private BatchProductItemHardwareDetailsGridControl fld_dgcBatchProductProductionNormItemHardware;
    }
}