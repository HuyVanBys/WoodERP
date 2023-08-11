namespace BOSERP.Modules.CompanyConfig
{
    partial class guiConfigFiscalYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.fld_txtFiscalYear = new DevExpress.XtraEditors.TextEdit();
            this.fld_dgcGEFiscalPeriods = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvGEFiscalPeriods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGEFiscalPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGEFiscalPeriodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemGEFiscalPeriodNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGEFiscalPeriodDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemGEFiscalPeriodDateFrom = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGEFiscalPeriodDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemGEFiscalPeriodDateTo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGEFiscalPeriodStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemGEFiscalPeriodStatus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fld_btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFiscalYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEFiscalPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEFiscalPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateFrom.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateTo.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiscal Year";
            // 
            // fld_txtFiscalYear
            // 
            this.fld_txtFiscalYear.Location = new System.Drawing.Point(97, 31);
            this.fld_txtFiscalYear.Name = "fld_txtFiscalYear";
            this.fld_txtFiscalYear.Properties.Mask.EditMask = "d4";
            this.fld_txtFiscalYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtFiscalYear.Size = new System.Drawing.Size(100, 20);
            this.fld_txtFiscalYear.TabIndex = 7;
            this.fld_txtFiscalYear.Validated += new System.EventHandler(this.textEdit1_Validated);
            this.fld_txtFiscalYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyUp);
            // 
            // fld_dgcGEFiscalPeriods
            // 
            this.fld_dgcGEFiscalPeriods.EmbeddedNavigator.Name = "";
            this.fld_dgcGEFiscalPeriods.Location = new System.Drawing.Point(36, 69);
            this.fld_dgcGEFiscalPeriods.MainView = this.fld_dgvGEFiscalPeriods;
            this.fld_dgcGEFiscalPeriods.Name = "fld_dgcGEFiscalPeriods";
            this.fld_dgcGEFiscalPeriods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemGEFiscalPeriodNo,
            this.repItemGEFiscalPeriodDateFrom,
            this.repItemGEFiscalPeriodDateTo,
            this.repItemGEFiscalPeriodStatus});
            this.fld_dgcGEFiscalPeriods.Size = new System.Drawing.Size(700, 363);
            this.fld_dgcGEFiscalPeriods.TabIndex = 8;
            this.fld_dgcGEFiscalPeriods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEFiscalPeriods});
            // 
            // fld_dgvGEFiscalPeriods
            // 
            this.fld_dgvGEFiscalPeriods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGEFiscalPeriodID,
            this.colGEFiscalPeriodNo,
            this.colGEFiscalPeriodDateFrom,
            this.colGEFiscalPeriodDateTo,
            this.colGEFiscalPeriodStatus});
            this.fld_dgvGEFiscalPeriods.GridControl = this.fld_dgcGEFiscalPeriods;
            this.fld_dgvGEFiscalPeriods.Name = "fld_dgvGEFiscalPeriods";
            this.fld_dgvGEFiscalPeriods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.fld_dgvGEFiscalPeriods_FocusedRowChanged);
            this.fld_dgvGEFiscalPeriods.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.fld_dgvGEFiscalPeriods_ValidateRow);
            // 
            // colGEFiscalPeriodID
            // 
            this.colGEFiscalPeriodID.Caption = "ID";
            this.colGEFiscalPeriodID.FieldName = "GEFiscalPeriodID";
            this.colGEFiscalPeriodID.Name = "colGEFiscalPeriodID";
            // 
            // colGEFiscalPeriodNo
            // 
            this.colGEFiscalPeriodNo.Caption = "Fiscal Periods";
            this.colGEFiscalPeriodNo.ColumnEdit = this.repItemGEFiscalPeriodNo;
            this.colGEFiscalPeriodNo.FieldName = "GEFiscalPeriodNo";
            this.colGEFiscalPeriodNo.Name = "colGEFiscalPeriodNo";
            this.colGEFiscalPeriodNo.Visible = true;
            this.colGEFiscalPeriodNo.VisibleIndex = 0;
            // 
            // repItemGEFiscalPeriodNo
            // 
            this.repItemGEFiscalPeriodNo.AutoHeight = false;
            this.repItemGEFiscalPeriodNo.Name = "repItemGEFiscalPeriodNo";
            // 
            // colGEFiscalPeriodDateFrom
            // 
            this.colGEFiscalPeriodDateFrom.Caption = "Date From";
            this.colGEFiscalPeriodDateFrom.ColumnEdit = this.repItemGEFiscalPeriodDateFrom;
            this.colGEFiscalPeriodDateFrom.FieldName = "GEFiscalPeriodDateFrom";
            this.colGEFiscalPeriodDateFrom.Name = "colGEFiscalPeriodDateFrom";
            this.colGEFiscalPeriodDateFrom.Visible = true;
            this.colGEFiscalPeriodDateFrom.VisibleIndex = 1;
            // 
            // repItemGEFiscalPeriodDateFrom
            // 
            this.repItemGEFiscalPeriodDateFrom.AutoHeight = false;
            this.repItemGEFiscalPeriodDateFrom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemGEFiscalPeriodDateFrom.Name = "repItemGEFiscalPeriodDateFrom";
            this.repItemGEFiscalPeriodDateFrom.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colGEFiscalPeriodDateTo
            // 
            this.colGEFiscalPeriodDateTo.Caption = "Date To";
            this.colGEFiscalPeriodDateTo.ColumnEdit = this.repItemGEFiscalPeriodDateTo;
            this.colGEFiscalPeriodDateTo.FieldName = "GEFiscalPeriodDateTo";
            this.colGEFiscalPeriodDateTo.Name = "colGEFiscalPeriodDateTo";
            this.colGEFiscalPeriodDateTo.Visible = true;
            this.colGEFiscalPeriodDateTo.VisibleIndex = 2;
            // 
            // repItemGEFiscalPeriodDateTo
            // 
            this.repItemGEFiscalPeriodDateTo.AutoHeight = false;
            this.repItemGEFiscalPeriodDateTo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemGEFiscalPeriodDateTo.Name = "repItemGEFiscalPeriodDateTo";
            this.repItemGEFiscalPeriodDateTo.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colGEFiscalPeriodStatus
            // 
            this.colGEFiscalPeriodStatus.Caption = "Status";
            this.colGEFiscalPeriodStatus.ColumnEdit = this.repItemGEFiscalPeriodStatus;
            this.colGEFiscalPeriodStatus.FieldName = "GEFiscalPeriodStatus";
            this.colGEFiscalPeriodStatus.Name = "colGEFiscalPeriodStatus";
            this.colGEFiscalPeriodStatus.Visible = true;
            this.colGEFiscalPeriodStatus.VisibleIndex = 3;
            // 
            // repItemGEFiscalPeriodStatus
            // 
            this.repItemGEFiscalPeriodStatus.AutoHeight = false;
            this.repItemGEFiscalPeriodStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemGEFiscalPeriodStatus.Name = "repItemGEFiscalPeriodStatus";
            this.repItemGEFiscalPeriodStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // fld_btnNew
            // 
            this.fld_btnNew.Location = new System.Drawing.Point(561, 438);
            this.fld_btnNew.Name = "fld_btnNew";
            this.fld_btnNew.Size = new System.Drawing.Size(83, 20);
            this.fld_btnNew.TabIndex = 9;
            this.fld_btnNew.Text = "&New";
            this.fld_btnNew.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Location = new System.Drawing.Point(650, 438);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Size = new System.Drawing.Size(83, 20);
            this.fld_btnSave.TabIndex = 10;
            this.fld_btnSave.Text = "&Save";
            this.fld_btnSave.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // guiConfigFiscalYear
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 524);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_btnNew);
            this.Controls.Add(this.fld_dgcGEFiscalPeriods);
            this.Controls.Add(this.fld_txtFiscalYear);
            this.Controls.Add(this.label1);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "guiConfigFiscalYear";
            this.Text = "Config Fiscal Year";
            this.Load += new System.EventHandler(this.guiConfigFiscalYear_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.fld_txtFiscalYear, 0);
            this.Controls.SetChildIndex(this.fld_dgcGEFiscalPeriods, 0);
            this.Controls.SetChildIndex(this.fld_btnNew, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFiscalYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEFiscalPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEFiscalPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateFrom.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateTo.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemGEFiscalPeriodStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit fld_txtFiscalYear;
        private DevExpress.XtraGrid.GridControl fld_dgcGEFiscalPeriods;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEFiscalPeriods;
        private DevExpress.XtraGrid.Columns.GridColumn colGEFiscalPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colGEFiscalPeriodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGEFiscalPeriodDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colGEFiscalPeriodDateTo;
        private DevExpress.XtraGrid.Columns.GridColumn colGEFiscalPeriodStatus;
        private DevExpress.XtraEditors.SimpleButton fld_btnNew;
        private DevExpress.XtraEditors.SimpleButton fld_btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemGEFiscalPeriodNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repItemGEFiscalPeriodDateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repItemGEFiscalPeriodDateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repItemGEFiscalPeriodStatus;
    }
}