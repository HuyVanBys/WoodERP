namespace BOSERP.Modules.BatchProduct.UI
{
    partial class guiProductionNormOperationProcessInfos
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
            this.fld_dgcBatchProductItemOperationInfos = new BOSERP.ProductionNormOperationProcessInfosGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductItemOperationInfos)).BeginInit();
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
            // fld_dgcBatchProductItemOperationInfos
            // 
            this.fld_dgcBatchProductItemOperationInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcBatchProductItemOperationInfos.BOSComment = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSDataMember = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSDataSource = "MMBatchProductItemOperationInfos";
            this.fld_dgcBatchProductItemOperationInfos.BOSDescription = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSError = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSFieldGroup = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSFieldRelation = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSGridType = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSPrivilege = null;
            this.fld_dgcBatchProductItemOperationInfos.BOSPropertyName = null;
            this.fld_dgcBatchProductItemOperationInfos.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcBatchProductItemOperationInfos.MenuManager = this.screenToolbar;
            this.fld_dgcBatchProductItemOperationInfos.Name = "fld_dgcBatchProductItemOperationInfos";
            this.fld_dgcBatchProductItemOperationInfos.PrintReport = false;
            this.fld_dgcBatchProductItemOperationInfos.Screen = null;
            this.fld_dgcBatchProductItemOperationInfos.Size = new System.Drawing.Size(889, 544);
            this.fld_dgcBatchProductItemOperationInfos.TabIndex = 1;
            // 
            // guiProductionNormOperationProcessInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(894, 587);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcBatchProductItemOperationInfos);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Name = "guiProductionNormOperationProcessInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy trình sản xuất chi tiết";
            this.Load += new System.EventHandler(this.guiProductionNormOperationProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcBatchProductItemOperationInfos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductItemOperationInfos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private ProductionNormOperationProcessInfosGridControl fld_dgcBatchProductItemOperationInfos;
    }
}