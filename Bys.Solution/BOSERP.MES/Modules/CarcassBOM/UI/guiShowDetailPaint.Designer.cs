namespace BOSERP.Modules.CarcassBOM
{
    partial class guiShowDetailPaint
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
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl = new BOSERP.Modules.CarcassBOM.MMProductionNormItemPaintDetailsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemPaintDetailsGridControl)).BeginInit();
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
            this.fld_btnCancel.Location = new System.Drawing.Point(810, 576);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(96, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Thoát";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcMMProductionNormItemPaintDetailsGridControl
            // 
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSComment = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSDataMember = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSDataSource = "MMProductionNormItemPaintDetails";
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSDescription = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSError = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSGridType = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.CommodityType = "";
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.Name = "fld_dgcMMProductionNormItemPaintDetailsGridControl";
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.PrintReport = false;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.Screen = null;
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.Size = new System.Drawing.Size(894, 558);
            this.fld_dgcMMProductionNormItemPaintDetailsGridControl.TabIndex = 6;
            // 
            // guiShowDetailPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(918, 615);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcMMProductionNormItemPaintDetailsGridControl);
            this.Controls.Add(this.fld_btnCancel);
            this.Name = "guiShowDetailPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết sơn";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMProductionNormItemPaintDetailsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemPaintDetailsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnCancel;
        private MMProductionNormItemPaintDetailsGridControl fld_dgcMMProductionNormItemPaintDetailsGridControl;
    }
}