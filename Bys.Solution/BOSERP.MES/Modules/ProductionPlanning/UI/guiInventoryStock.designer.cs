namespace BOSERP.Modules.ProductionPlanning
{
    partial class guiInventoryStock
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dgcICProductGridControl = new BOSERP.Modules.ProductionPlanning.guiInventoryStockGridControl();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductGridControl)).BeginInit();
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
            this.fld_btnCancel.Location = new System.Drawing.Point(763, 10);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Thoát";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_btnCancel);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel2.Location = new System.Drawing.Point(0, 528);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(881, 50);
            this.bosPanel2.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.fld_dgcICProductGridControl);
            this.panelControl1.Location = new System.Drawing.Point(0, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(881, 530);
            this.panelControl1.TabIndex = 8;
            // 
            // fld_dgcICProductGridControl
            // 
            this.fld_dgcICProductGridControl.BOSComment = null;
            this.fld_dgcICProductGridControl.BOSDataMember = null;
            this.fld_dgcICProductGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcICProductGridControl.BOSDescription = null;
            this.fld_dgcICProductGridControl.BOSError = null;
            this.fld_dgcICProductGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductGridControl.BOSGridType = null;
            this.fld_dgcICProductGridControl.BOSPrivilege = null;
            this.fld_dgcICProductGridControl.BOSPropertyName = null;
            this.fld_dgcICProductGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductGridControl.Location = new System.Drawing.Point(2, 2);
            this.fld_dgcICProductGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductGridControl.Name = "fld_dgcICProductGridControl";
            this.fld_dgcICProductGridControl.PrintReport = false;
            this.fld_dgcICProductGridControl.Screen = null;
            this.fld_dgcICProductGridControl.Size = new System.Drawing.Size(877, 526);
            this.fld_dgcICProductGridControl.StockList = null;
            this.fld_dgcICProductGridControl.TabIndex = 9;
            // 
            // guiInventoryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(881, 578);
            this.ControlBox = true;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.bosPanel2);
            this.Name = "guiInventoryStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tồn kho sản phẩm";
            this.Load += new System.EventHandler(this.guiMMProductionNormItems_Load);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSPanel bosPanel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private guiInventoryStockGridControl fld_dgcICProductGridControl;
    }
}