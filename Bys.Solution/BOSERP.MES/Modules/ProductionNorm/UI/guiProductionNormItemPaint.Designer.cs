namespace BOSERP.MES.Modules.ProductionNorm
{
    partial class guiProductionNormItemPaint
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
            this.fld_dgcProductionNormItemPaint = new BOSERP.MES.Modules.ProductionNorm.ProductionNormItemPaintDetailsGridControl();
            this.lblProductDesc = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtMMProductionNormItemAcreage = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormItemAcreage.Properties)).BeginInit();
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
            // fld_dgcProductionNormItemPaint
            // 
            this.fld_dgcProductionNormItemPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionNormItemPaint.BOSComment = null;
            this.fld_dgcProductionNormItemPaint.BOSDataMember = null;
            this.fld_dgcProductionNormItemPaint.BOSDataSource = "MMProductionNormItemPaints";
            this.fld_dgcProductionNormItemPaint.BOSDescription = null;
            this.fld_dgcProductionNormItemPaint.BOSError = null;
            this.fld_dgcProductionNormItemPaint.BOSFieldGroup = null;
            this.fld_dgcProductionNormItemPaint.BOSFieldRelation = null;
            this.fld_dgcProductionNormItemPaint.BOSGridType = null;
            this.fld_dgcProductionNormItemPaint.BOSPrivilege = null;
            this.fld_dgcProductionNormItemPaint.BOSPropertyName = null;
            this.fld_dgcProductionNormItemPaint.Location = new System.Drawing.Point(2, 35);
            this.fld_dgcProductionNormItemPaint.MenuManager = this.screenToolbar;
            this.fld_dgcProductionNormItemPaint.Name = "fld_dgcProductionNormItemPaint";
            this.fld_dgcProductionNormItemPaint.PrintReport = false;
            this.fld_dgcProductionNormItemPaint.Screen = null;
            this.fld_dgcProductionNormItemPaint.Size = new System.Drawing.Size(890, 512);
            this.fld_dgcProductionNormItemPaint.TabIndex = 6;
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProductDesc.Appearance.Options.UseFont = true;
            this.lblProductDesc.Location = new System.Drawing.Point(12, 12);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(127, 13);
            this.lblProductDesc.TabIndex = 7;
            this.lblProductDesc.Text = "Tổng diện tích chi tiết: ";
            // 
            // fld_txtMMProductionNormItemAcreage
            // 
            this.fld_txtMMProductionNormItemAcreage.BOSComment = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSDataMember = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSDataSource = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSDescription = null;
            this.fld_txtMMProductionNormItemAcreage.BOSError = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSFieldGroup = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSFieldRelation = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSPrivilege = string.Empty;
            this.fld_txtMMProductionNormItemAcreage.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormItemAcreage.Location = new System.Drawing.Point(277, 9);
            this.fld_txtMMProductionNormItemAcreage.Name = "fld_txtMMProductionNormItemAcreage";
            this.fld_txtMMProductionNormItemAcreage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormItemAcreage.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormItemAcreage.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormItemAcreage.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormItemAcreage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormItemAcreage.Properties.ReadOnly = true;
            this.fld_txtMMProductionNormItemAcreage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormItemAcreage.Screen = null;
            this.fld_txtMMProductionNormItemAcreage.Size = new System.Drawing.Size(154, 20);
            this.fld_txtMMProductionNormItemAcreage.TabIndex = 12;
            this.fld_txtMMProductionNormItemAcreage.Tag = "DC";
            // 
            // guiProductionNormItemPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(894, 587);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtMMProductionNormItemAcreage);
            this.Controls.Add(this.lblProductDesc);
            this.Controls.Add(this.fld_dgcProductionNormItemPaint);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Name = "guiProductionNormItemPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết Paint";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductionNormItemPaint, 0);
            this.Controls.SetChildIndex(this.lblProductDesc, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProductionNormItemAcreage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormItemAcreage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private ProductionNormItemPaintDetailsGridControl fld_dgcProductionNormItemPaint;
        private DevExpress.XtraEditors.LabelControl lblProductDesc;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormItemAcreage;
    }
}