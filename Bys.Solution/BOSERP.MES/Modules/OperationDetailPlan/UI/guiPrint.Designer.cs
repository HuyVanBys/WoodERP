namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPrint));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_lkePrintJobTicketType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrintJobTicketType.Properties)).BeginInit();
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
            this.fld_btnOK.Location = new System.Drawing.Point(316, 58);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "OK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(397, 58);
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
            // fld_lkePrintJobTicketType
            // 
            this.fld_lkePrintJobTicketType.BOSAllowAddNew = false;
            this.fld_lkePrintJobTicketType.BOSAllowDummy = true;
            this.fld_lkePrintJobTicketType.BOSComment = null;
            this.fld_lkePrintJobTicketType.BOSDataMember = "";
            this.fld_lkePrintJobTicketType.BOSDataSource = "";
            this.fld_lkePrintJobTicketType.BOSDescription = null;
            this.fld_lkePrintJobTicketType.BOSError = null;
            this.fld_lkePrintJobTicketType.BOSFieldGroup = null;
            this.fld_lkePrintJobTicketType.BOSFieldParent = null;
            this.fld_lkePrintJobTicketType.BOSFieldRelation = null;
            this.fld_lkePrintJobTicketType.BOSPrivilege = null;
            this.fld_lkePrintJobTicketType.BOSPropertyName = null;
            this.fld_lkePrintJobTicketType.BOSSelectType = null;
            this.fld_lkePrintJobTicketType.BOSSelectTypeValue = null;
            this.fld_lkePrintJobTicketType.CurrentDisplayText = null;
            this.fld_lkePrintJobTicketType.Location = new System.Drawing.Point(136, 12);
            this.fld_lkePrintJobTicketType.MenuManager = this.screenToolbar;
            this.fld_lkePrintJobTicketType.Name = "fld_lkePrintJobTicketType";
            this.fld_lkePrintJobTicketType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePrintJobTicketType.Properties.ColumnName = null;
            this.fld_lkePrintJobTicketType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkePrintJobTicketType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkePrintJobTicketType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkePrintJobTicketType.Screen = null;
            this.fld_lkePrintJobTicketType.Size = new System.Drawing.Size(156, 20);
            this.fld_lkePrintJobTicketType.TabIndex = 557;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(23, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(79, 13);
            this.bosLabel1.TabIndex = 558;
            this.bosLabel1.Text = "Chọn mẫu cần in";
            // 
            // guiPrint
            // 
            this.AcceptButton = this.fld_btnOK;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(483, 97);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkePrintJobTicketType);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiPrint.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ kế hoạch chi tiết";
            this.Load += new System.EventHandler(this.guiPrintFilter_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_lkePrintJobTicketType, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrintJobTicketType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSLookupEdit fld_lkePrintJobTicketType;
        private BOSComponent.BOSLabel bosLabel1;
    }
}