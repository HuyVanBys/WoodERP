namespace BOSERP.Modules.SaleOrder
{
    partial class guiAddTask<T>
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICTasksGridControl = new BOSERP.Modules.SaleOrder.ICTasksGridControl();
            this.fld_txtFind = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTasksGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(843, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(754, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcICTasksGridControl
            // 
            this.fld_dgcICTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTasksGridControl.BOSComment = null;
            this.fld_dgcICTasksGridControl.BOSDataMember = null;
            this.fld_dgcICTasksGridControl.BOSDataSource = "ICTasks";
            this.fld_dgcICTasksGridControl.BOSDescription = null;
            this.fld_dgcICTasksGridControl.BOSError = null;
            this.fld_dgcICTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcICTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcICTasksGridControl.BOSGridType = null;
            this.fld_dgcICTasksGridControl.BOSPrivilege = null;
            this.fld_dgcICTasksGridControl.BOSPropertyName = null;
            this.fld_dgcICTasksGridControl.Location = new System.Drawing.Point(12, 45);
            this.fld_dgcICTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICTasksGridControl.Name = "fld_dgcICTasksGridControl";
            this.fld_dgcICTasksGridControl.PrintReport = false;
            this.fld_dgcICTasksGridControl.Screen = null;
            this.fld_dgcICTasksGridControl.Size = new System.Drawing.Size(914, 493);
            this.fld_dgcICTasksGridControl.TabIndex = 2;
            this.fld_dgcICTasksGridControl.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // fld_txtFind
            // 
            this.fld_txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtFind.BOSComment = null;
            this.fld_txtFind.BOSDataMember = null;
            this.fld_txtFind.BOSDataSource = null;
            this.fld_txtFind.BOSDescription = null;
            this.fld_txtFind.BOSError = null;
            this.fld_txtFind.BOSFieldGroup = null;
            this.fld_txtFind.BOSFieldRelation = null;
            this.fld_txtFind.BOSPrivilege = null;
            this.fld_txtFind.BOSPropertyName = null;
            this.fld_txtFind.EditValue = "Nhập vào từ khóa";
            this.fld_txtFind.Location = new System.Drawing.Point(12, 13);
            this.fld_txtFind.MenuManager = this.screenToolbar;
            this.fld_txtFind.Name = "fld_txtFind";
            this.fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtFind.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFind.Screen = null;
            this.fld_txtFind.Size = new System.Drawing.Size(844, 20);
            this.fld_txtFind.TabIndex = 0;
            this.fld_txtFind.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_txtFind_EditValueChanging);
            this.fld_txtFind.Leave += new System.EventHandler(this.fld_txtFind_Leave);
            this.fld_txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtFind_KeyUp);
            this.fld_txtFind.Click += new System.EventHandler(this.fld_txtFind_Click);
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Image = global::BOSERP.Procedure.Properties.Resources.View;
            this.fld_btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(862, 10);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(64, 27);
            this.fld_btnFind.TabIndex = 1;
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // guiAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtFind);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_dgcICTasksGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách task";
            this.Load += new System.EventHandler(this.guiAddTask_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICTasksGridControl, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_txtFind, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTasksGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ICTasksGridControl fld_dgcICTasksGridControl;
        private BOSComponent.BOSTextBox fld_txtFind;
        private BOSComponent.BOSButton fld_btnFind;
    }
}