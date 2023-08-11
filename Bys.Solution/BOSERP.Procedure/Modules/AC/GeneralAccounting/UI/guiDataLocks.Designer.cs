namespace BOSERP.Modules.GeneralAccounting
{
    partial class guiDataLocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiDataLocks));
            this.fld_dgcLocks = new BOSERP.Modules.GeneralAccounting.DataLockGridControl();
            this.fld_btnAddLock = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcLocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcLocks
            // 
            this.fld_dgcLocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcLocks.BOSComment = null;
            this.fld_dgcLocks.BOSDataMember = null;
            this.fld_dgcLocks.BOSDataSource = "ADLocks";
            this.fld_dgcLocks.BOSDescription = null;
            this.fld_dgcLocks.BOSError = null;
            this.fld_dgcLocks.BOSFieldGroup = null;
            this.fld_dgcLocks.BOSFieldRelation = null;
            this.fld_dgcLocks.BOSGridType = null;
            this.fld_dgcLocks.BOSPrivilege = null;
            this.fld_dgcLocks.BOSPropertyName = null;
            this.fld_dgcLocks.Location = new System.Drawing.Point(0, 56);
            this.fld_dgcLocks.Name = "fld_dgcLocks";
            this.fld_dgcLocks.Screen = null;
            this.fld_dgcLocks.Size = new System.Drawing.Size(772, 401);
            this.fld_dgcLocks.TabIndex = 3;
            // 
            // fld_btnAddLock
            // 
            this.fld_btnAddLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddLock.BOSComment = null;
            this.fld_btnAddLock.BOSDataMember = null;
            this.fld_btnAddLock.BOSDataSource = null;
            this.fld_btnAddLock.BOSDescription = null;
            this.fld_btnAddLock.BOSError = null;
            this.fld_btnAddLock.BOSFieldGroup = null;
            this.fld_btnAddLock.BOSFieldRelation = null;
            this.fld_btnAddLock.BOSPrivilege = null;
            this.fld_btnAddLock.BOSPropertyName = null;
            this.fld_btnAddLock.Location = new System.Drawing.Point(587, 474);
            this.fld_btnAddLock.Name = "fld_btnAddLock";
            this.fld_btnAddLock.Screen = null;
            this.fld_btnAddLock.Size = new System.Drawing.Size(94, 27);
            this.fld_btnAddLock.TabIndex = 1;
            this.fld_btnAddLock.Text = "Thêm khóa";
            this.fld_btnAddLock.Click += new System.EventHandler(this.fld_btnAddLock_Click);
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_btnClose.Location = new System.Drawing.Point(687, 474);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_btnView);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteToDate);
            this.bosPanel1.Controls.Add(this.fld_dteFromDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(774, 55);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(233, 17);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(472, 11);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(75, 27);
            this.fld_btnView.TabIndex = 3;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 17);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = null;
            this.fld_dteToDate.BOSDataSource = null;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(296, 14);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 2;
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = null;
            this.fld_dteFromDate.BOSDataSource = null;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(67, 14);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 1;
            // 
            // guiDataLocks
            // 
            this.AcceptButton = this.fld_btnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(774, 510);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnAddLock);
            this.Controls.Add(this.fld_dgcLocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiDataLocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khóa dữ liệu";
            this.Load += new System.EventHandler(this.guiDataLocks_Load);
            this.Controls.SetChildIndex(this.fld_dgcLocks, 0);
            this.Controls.SetChildIndex(this.fld_btnAddLock, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcLocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataLockGridControl fld_dgcLocks;
        private BOSComponent.BOSButton fld_btnAddLock;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSButton fld_btnView;

    }
}