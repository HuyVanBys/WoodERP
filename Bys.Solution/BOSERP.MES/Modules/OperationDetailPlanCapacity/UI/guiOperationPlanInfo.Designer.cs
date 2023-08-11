namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    partial class guiOperationPlanInfo
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(133, 39);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "OK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            this.fld_btnOK.Enter += new System.EventHandler(this.fld_btnOK_Enter);
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
            this.fld_btnClose.Location = new System.Drawing.Point(214, 39);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(27, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 85;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = true;
            this.fld_lkeMMOperationID.BOSComment = null;
            this.fld_lkeMMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = null;
            this.fld_lkeMMOperationID.BOSFieldParent = null;
            this.fld_lkeMMOperationID.BOSFieldRelation = null;
            this.fld_lkeMMOperationID.BOSPrivilege = null;
            this.fld_lkeMMOperationID.BOSPropertyName = null;
            this.fld_lkeMMOperationID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationID.CurrentDisplayText = null;
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(94, 11);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeMMOperationID.TabIndex = 2;
            this.fld_lkeMMOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeMMOperationID_QueryPopUp);
            // 
            // guiOperationPlanInfo
            // 
            this.AcceptButton = this.fld_btnOK;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(326, 78);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeMMOperationID);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiOperationPlanInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cần ghi nhận năng xuất";
            this.Load += new System.EventHandler(this.guiOperationPlanInfo_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMOperationID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
    }
}