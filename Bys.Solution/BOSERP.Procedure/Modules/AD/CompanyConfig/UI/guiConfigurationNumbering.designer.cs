namespace BOSERP.Modules.CompanyConfig
{
    partial class guiConfigurationNumbering
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
            this.fld_dgcNumbering = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvNumbering = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGENumberingID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGENumberingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookupModuleName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repItemLookupModus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGENumberingLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemNumberingLength = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGENumberingStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemNumberingStart = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBoxNumberingModus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colGENumberingPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcNumbering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvNumbering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookupModuleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookupModus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNumberingLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNumberingStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxNumberingModus)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcNumbering
            // 
            this.fld_dgcNumbering.EmbeddedNavigator.Name = "";
            this.fld_dgcNumbering.Location = new System.Drawing.Point(15, 15);
            this.fld_dgcNumbering.MainView = this.fld_dgvNumbering;
            this.fld_dgcNumbering.Name = "fld_dgcNumbering";
            this.fld_dgcNumbering.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxNumberingModus,
            this.repositoryItemNumberingLength,
            this.repositoryItemNumberingStart,
            this.repItemLookupModus,
            this.repItemLookupModuleName});
            this.fld_dgcNumbering.Size = new System.Drawing.Size(830, 500);
            this.fld_dgcNumbering.TabIndex = 4;
            this.fld_dgcNumbering.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvNumbering});
            // 
            // fld_dgvNumbering
            // 
            this.fld_dgvNumbering.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGENumberingID,
            this.colGENumberingName,
            this.colGENumberingPrefix,
            this.colGENumberingLength,
            this.colGENumberingStart});
            this.fld_dgvNumbering.GridControl = this.fld_dgcNumbering;
            this.fld_dgvNumbering.Name = "fld_dgvNumbering";
            this.fld_dgvNumbering.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_dgvNumbering.OptionsView.ColumnAutoWidth = false;
            this.fld_dgvNumbering.OptionsView.ShowGroupPanel = false;
            this.fld_dgvNumbering.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.fld_dgvNumbering_InitNewRow);
            this.fld_dgvNumbering.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.fld_dgvNumbering_ValidateRow);
            // 
            // colGENumberingID
            // 
            this.colGENumberingID.Caption = "GENumberingID";
            this.colGENumberingID.FieldName = "GENumberingID";
            this.colGENumberingID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colGENumberingID.Name = "colGENumberingID";
            // 
            // colGENumberingName
            // 
            this.colGENumberingName.Caption = "Module";
            this.colGENumberingName.ColumnEdit = this.repItemLookupModuleName;
            this.colGENumberingName.FieldName = "GENumberingName";
            this.colGENumberingName.Name = "colGENumberingName";
            this.colGENumberingName.OptionsColumn.AllowEdit = false;
            this.colGENumberingName.Visible = true;
            this.colGENumberingName.VisibleIndex = 0;
            this.colGENumberingName.Width = 179;
            // 
            // repItemLookupModuleName
            // 
            this.repItemLookupModuleName.AutoHeight = false;
            this.repItemLookupModuleName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookupModuleName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repItemLookupModuleName.Name = "repItemLookupModuleName";
            // 
            // repItemLookupModus
            // 
            this.repItemLookupModus.AutoHeight = false;
            this.repItemLookupModus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookupModus.Name = "repItemLookupModus";
            // 
            // colGENumberingLength
            // 
            this.colGENumberingLength.Caption = "Length";
            this.colGENumberingLength.ColumnEdit = this.repositoryItemNumberingLength;
            this.colGENumberingLength.FieldName = "GENumberingLength";
            this.colGENumberingLength.Name = "colGENumberingLength";
            this.colGENumberingLength.OptionsColumn.AllowEdit = false;
            this.colGENumberingLength.Visible = true;
            this.colGENumberingLength.VisibleIndex = 2;
            this.colGENumberingLength.Width = 139;
            // 
            // repositoryItemNumberingLength
            // 
            this.repositoryItemNumberingLength.AutoHeight = false;
            this.repositoryItemNumberingLength.Mask.EditMask = "\\d";
            this.repositoryItemNumberingLength.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemNumberingLength.Name = "repositoryItemNumberingLength";
            // 
            // colGENumberingStart
            // 
            this.colGENumberingStart.Caption = "Start";
            this.colGENumberingStart.ColumnEdit = this.repositoryItemNumberingStart;
            this.colGENumberingStart.FieldName = "GENumberingStart";
            this.colGENumberingStart.Name = "colGENumberingStart";
            this.colGENumberingStart.Visible = true;
            this.colGENumberingStart.VisibleIndex = 3;
            this.colGENumberingStart.Width = 131;
            // 
            // repositoryItemNumberingStart
            // 
            this.repositoryItemNumberingStart.AutoHeight = false;
            this.repositoryItemNumberingStart.Mask.EditMask = "f0";
            this.repositoryItemNumberingStart.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemNumberingStart.Name = "repositoryItemNumberingStart";
            // 
            // repositoryItemComboBoxNumberingModus
            // 
            this.repositoryItemComboBoxNumberingModus.AutoHeight = false;
            this.repositoryItemComboBoxNumberingModus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxNumberingModus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.repositoryItemComboBoxNumberingModus.Name = "repositoryItemComboBoxNumberingModus";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(770, 521);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 20);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "&Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colGENumberingPrefix
            // 
            this.colGENumberingPrefix.Caption = "Prefix";
            this.colGENumberingPrefix.FieldName = "GENumberingPrefix";
            this.colGENumberingPrefix.Name = "colGENumberingPrefix";
            this.colGENumberingPrefix.Visible = true;
            this.colGENumberingPrefix.VisibleIndex = 1;
            this.colGENumberingPrefix.Width = 153;
            // 
            // guiConfigurationNumbering
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 573);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fld_dgcNumbering);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "guiConfigurationNumbering";
            this.Text = "Numbering";
            this.Load += new System.EventHandler(this.guiConfigurationNumbering_Load);
            this.Controls.SetChildIndex(this.fld_dgcNumbering, 0);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcNumbering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvNumbering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookupModuleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookupModus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNumberingLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNumberingStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxNumberingModus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl fld_dgcNumbering;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvNumbering;
        private DevExpress.XtraGrid.Columns.GridColumn colGENumberingID;
        private DevExpress.XtraGrid.Columns.GridColumn colGENumberingName;
        private DevExpress.XtraGrid.Columns.GridColumn colGENumberingLength;
        private DevExpress.XtraGrid.Columns.GridColumn colGENumberingStart;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxNumberingModus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemNumberingLength;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemNumberingStart;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookupModus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookupModuleName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colGENumberingPrefix;

    }
}