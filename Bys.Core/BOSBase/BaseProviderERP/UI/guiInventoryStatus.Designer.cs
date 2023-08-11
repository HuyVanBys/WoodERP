using BOSComponent;

namespace BOSERP
{
    partial class guiInventoryStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiInventoryStatus));
            this.fld_lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.fld_dgcInventoryStatus = new BOSERP.InventoryStatusGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblStatus
            // 
            this.fld_lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblStatus.Appearance.Options.UseFont = true;
            this.fld_lblStatus.Location = new System.Drawing.Point(14, 21);
            this.fld_lblStatus.Name = "fld_lblStatus";
            this.fld_lblStatus.Size = new System.Drawing.Size(543, 13);
            this.fld_lblStatus.TabIndex = 0;
            this.fld_lblStatus.Text = "Vui lòng xem xét tình trạng tồn kho sau, nếu không đủ số lượng trong kho bạn khôn" +
                "g thể tiếp tục";
            // 
            // fld_dgcInventoryStatus
            // 
            this.fld_dgcInventoryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcInventoryStatus.BOSComment = null;
            this.fld_dgcInventoryStatus.BOSDataMember = null;
            this.fld_dgcInventoryStatus.BOSDataSource = "ICProducts";
            this.fld_dgcInventoryStatus.BOSDescription = null;
            this.fld_dgcInventoryStatus.BOSError = null;
            this.fld_dgcInventoryStatus.BOSFieldGroup = null;
            this.fld_dgcInventoryStatus.BOSFieldRelation = null;
            this.fld_dgcInventoryStatus.BOSGridType = null;
            this.fld_dgcInventoryStatus.BOSPrivilege = null;
            this.fld_dgcInventoryStatus.BOSPropertyName = null;
            this.fld_dgcInventoryStatus.Location = new System.Drawing.Point(15, 44);
            this.fld_dgcInventoryStatus.MainView = this.gridView1;
            this.fld_dgcInventoryStatus.Name = "fld_dgcInventoryStatus";
            this.fld_dgcInventoryStatus.Screen = null;
            this.fld_dgcInventoryStatus.Size = new System.Drawing.Size(767, 345);
            this.fld_dgcInventoryStatus.TabIndex = 1;
            this.fld_dgcInventoryStatus.Tag = "DC";
            this.fld_dgcInventoryStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcInventoryStatus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(707, 415);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(84, 30);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Đóng";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Location = new System.Drawing.Point(3, 395);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(788, 10);
            this.bosLine1.TabIndex = 6;
            this.bosLine1.TabStop = false;
            // 
            // guiInventoryStatus
            // 
            this.AcceptButton = this.fld_btnCancel;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(795, 451);
            this.ControlBox = true;
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_dgcInventoryStatus);
            this.Controls.Add(this.fld_lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiInventoryStatus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tình trạng tồn kho";
            this.Load += new System.EventHandler(this.guiInventoryStatus_Load);
            this.Controls.SetChildIndex(this.fld_lblStatus, 0);
            this.Controls.SetChildIndex(this.fld_dgcInventoryStatus, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.bosLine1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl fld_lblStatus;
        private InventoryStatusGridControl fld_dgcInventoryStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private BOSComponent.BOSLine bosLine1;
    }
}