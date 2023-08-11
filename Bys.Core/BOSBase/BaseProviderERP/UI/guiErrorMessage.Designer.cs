namespace BOSERP
{
    partial class guiErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiErrorMessage));
            this.fld_dgcErrors = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colErrorControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcErrors
            // 
            this.fld_dgcErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcErrors.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcErrors.LookAndFeel.SkinName = "Office 2007 Blue";
            this.fld_dgcErrors.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.fld_dgcErrors.MainView = this.fld_dgvErrors;
            this.fld_dgcErrors.Name = "fld_dgcErrors";
            this.fld_dgcErrors.Size = new System.Drawing.Size(606, 363);
            this.fld_dgcErrors.TabIndex = 6;
            this.fld_dgcErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvErrors});
            this.fld_dgcErrors.DoubleClick += new System.EventHandler(this.fld_dgcErrors_DoubleClick);
            // 
            // fld_dgvErrors
            // 
            this.fld_dgvErrors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colErrorControl,
            this.colErrorMessage,
            this.colPosition});
            this.fld_dgvErrors.GridControl = this.fld_dgcErrors;
            this.fld_dgvErrors.Name = "fld_dgvErrors";
            this.fld_dgvErrors.OptionsBehavior.Editable = false;
            this.fld_dgvErrors.OptionsCustomization.AllowColumnMoving = false;
            this.fld_dgvErrors.OptionsCustomization.AllowFilter = false;
            this.fld_dgvErrors.OptionsCustomization.AllowGroup = false;
            this.fld_dgvErrors.OptionsCustomization.AllowSort = false;
            this.fld_dgvErrors.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_dgvErrors.OptionsView.ColumnAutoWidth = false;
            this.fld_dgvErrors.OptionsView.ShowGroupPanel = false;
            // 
            // colErrorControl
            // 
            this.colErrorControl.Caption = "Control";
            this.colErrorControl.FieldName = "Control";
            this.colErrorControl.Name = "colErrorControl";
            // 
            // colErrorMessage
            // 
            this.colErrorMessage.Caption = "Mô tả";
            this.colErrorMessage.FieldName = "Message";
            this.colErrorMessage.Name = "colErrorMessage";
            this.colErrorMessage.Visible = true;
            this.colErrorMessage.VisibleIndex = 0;
            this.colErrorMessage.Width = 585;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "Position";
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(519, 379);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2007 Blue";
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 27);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Đồng ý";
            this.simpleButton1.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // guiErrorMessage
            // 
            this.AcceptButton = this.simpleButton1;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton1;
            this.ClientSize = new System.Drawing.Size(606, 414);
            this.ControlBox = true;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fld_dgcErrors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lỗi";
            this.Load += new System.EventHandler(this.guiErrorMessage_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.guiErrorMessage_FormClosed);
            this.Controls.SetChildIndex(this.fld_dgcErrors, 0);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl fld_dgcErrors;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvErrors;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorControl;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}