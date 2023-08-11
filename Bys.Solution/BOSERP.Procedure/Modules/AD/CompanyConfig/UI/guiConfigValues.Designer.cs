namespace BOSERP.Modules.CompanyConfig
{
    partial class guiConfigValues
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
            this.fld_dgcADConfigValues = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvADConfigValues = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADConfigValueID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADConfigKeyDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemADConfigKeyDesc = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colADConfigKeyGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemADConfigKeyGroup = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colADConfigText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemADConfigText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADConfigValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADConfigValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigKeyDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigKeyGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigText)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcADConfigValues
            // 
            this.fld_dgcADConfigValues.EmbeddedNavigator.Name = "";
            this.fld_dgcADConfigValues.Location = new System.Drawing.Point(24, 12);
            this.fld_dgcADConfigValues.MainView = this.fld_dgvADConfigValues;
            this.fld_dgcADConfigValues.Name = "fld_dgcADConfigValues";
            this.fld_dgcADConfigValues.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemADConfigKeyDesc,
            this.repItemADConfigKeyGroup,
            this.repItemADConfigText});
            this.fld_dgcADConfigValues.Size = new System.Drawing.Size(873, 409);
            this.fld_dgcADConfigValues.TabIndex = 0;
            this.fld_dgcADConfigValues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADConfigValues});
            // 
            // fld_dgvADConfigValues
            // 
            this.fld_dgvADConfigValues.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADConfigValueID,
            this.colADConfigKeyDesc,
            this.colADConfigKeyGroup,
            this.colADConfigText});
            this.fld_dgvADConfigValues.GridControl = this.fld_dgcADConfigValues;
            this.fld_dgvADConfigValues.Name = "fld_dgvADConfigValues";
            this.fld_dgvADConfigValues.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.fld_dgvADConfigValues.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.fld_dgvADConfigValues_FocusedRowChanged);
            this.fld_dgvADConfigValues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_dgvADConfigValues_KeyUp);
            this.fld_dgvADConfigValues.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.fld_dgvADConfigValues_FocusedColumnChanged);
            this.fld_dgvADConfigValues.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.fld_dgvADConfigValues_InitNewRow);
            // 
            // colADConfigValueID
            // 
            this.colADConfigValueID.Caption = "ID";
            this.colADConfigValueID.FieldName = "ADConfigValueID";
            this.colADConfigValueID.Name = "colADConfigValueID";
            // 
            // colADConfigKeyDesc
            // 
            this.colADConfigKeyDesc.Caption = "Desc";
            this.colADConfigKeyDesc.ColumnEdit = this.repItemADConfigKeyDesc;
            this.colADConfigKeyDesc.FieldName = "ADConfigKeyDesc";
            this.colADConfigKeyDesc.Name = "colADConfigKeyDesc";
            this.colADConfigKeyDesc.Visible = true;
            this.colADConfigKeyDesc.VisibleIndex = 0;
            // 
            // repItemADConfigKeyDesc
            // 
            this.repItemADConfigKeyDesc.AutoHeight = false;
            this.repItemADConfigKeyDesc.Name = "repItemADConfigKeyDesc";
            // 
            // colADConfigKeyGroup
            // 
            this.colADConfigKeyGroup.Caption = "Group";
            this.colADConfigKeyGroup.ColumnEdit = this.repItemADConfigKeyGroup;
            this.colADConfigKeyGroup.FieldName = "ADConfigKeyGroup";
            this.colADConfigKeyGroup.Name = "colADConfigKeyGroup";
            this.colADConfigKeyGroup.Visible = true;
            this.colADConfigKeyGroup.VisibleIndex = 1;
            // 
            // repItemADConfigKeyGroup
            // 
            this.repItemADConfigKeyGroup.AutoHeight = false;
            this.repItemADConfigKeyGroup.Name = "repItemADConfigKeyGroup";
            // 
            // colADConfigText
            // 
            this.colADConfigText.Caption = "Text";
            this.colADConfigText.ColumnEdit = this.repItemADConfigText;
            this.colADConfigText.FieldName = "ADConfigText";
            this.colADConfigText.Name = "colADConfigText";
            this.colADConfigText.Visible = true;
            this.colADConfigText.VisibleIndex = 2;
            // 
            // repItemADConfigText
            // 
            this.repItemADConfigText.AutoHeight = false;
            this.repItemADConfigText.Name = "repItemADConfigText";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guiConfigValues
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fld_dgcADConfigValues);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "guiConfigValues";
            this.Text = "Config Values";
            this.Load += new System.EventHandler(this.guiConfigValues_Load);
            this.Controls.SetChildIndex(this.fld_dgcADConfigValues, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADConfigValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADConfigValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigKeyDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigKeyGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemADConfigText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl fld_dgcADConfigValues;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADConfigValues;
        private DevExpress.XtraGrid.Columns.GridColumn colADConfigValueID;
        private DevExpress.XtraGrid.Columns.GridColumn colADConfigKeyDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemADConfigKeyDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colADConfigKeyGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemADConfigKeyGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colADConfigText;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemADConfigText;
        private System.Windows.Forms.Button button1;
    }
}