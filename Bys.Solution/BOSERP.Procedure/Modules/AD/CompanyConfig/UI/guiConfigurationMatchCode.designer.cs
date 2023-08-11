namespace BOSERP.Modules.CompanyConfig
{
    partial class guiConfigurationMatchCode
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_lkeTableMatchCodes = new DevExpress.XtraEditors.LookUpEdit();
            this.fld_lkeModules = new DevExpress.XtraEditors.LookUpEdit();
            this.fld_lblMCodeColumns = new System.Windows.Forms.Label();
            this.fld_dgcMCodeValue = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvMCodeValue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colADMatchCodeValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_lblTables = new System.Windows.Forms.Label();
            this.fld_btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeTableMatchCodes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeModules.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMCodeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMCodeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.fld_lkeTableMatchCodes);
            this.groupControl1.Controls.Add(this.fld_lkeModules);
            this.groupControl1.Controls.Add(this.fld_lblMCodeColumns);
            this.groupControl1.Controls.Add(this.fld_dgcMCodeValue);
            this.groupControl1.Controls.Add(this.fld_lblTables);
            this.groupControl1.Location = new System.Drawing.Point(8, 9);
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(830, 459);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Optional Fields Configuration";
            // 
            // fld_lkeTableMatchCodes
            // 
            this.fld_lkeTableMatchCodes.Location = new System.Drawing.Point(382, 24);
            this.fld_lkeTableMatchCodes.Name = "fld_lkeTableMatchCodes";
            this.fld_lkeTableMatchCodes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeTableMatchCodes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.fld_lkeTableMatchCodes.Properties.NullText = "";
            this.fld_lkeTableMatchCodes.Size = new System.Drawing.Size(185, 20);
            this.fld_lkeTableMatchCodes.TabIndex = 16;
            this.fld_lkeTableMatchCodes.EditValueChanged += new System.EventHandler(this.fld_lkeTableMatchCodes_EditValueChanged);
            // 
            // fld_lkeModules
            // 
            this.fld_lkeModules.Location = new System.Drawing.Point(85, 24);
            this.fld_lkeModules.Name = "fld_lkeModules";
            this.fld_lkeModules.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeModules.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModuleDesc", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.fld_lkeModules.Properties.NullText = "";
            this.fld_lkeModules.Size = new System.Drawing.Size(185, 20);
            this.fld_lkeModules.TabIndex = 15;
            this.fld_lkeModules.EditValueChanged += new System.EventHandler(this.fld_lkeModules_EditValueChanged);
            // 
            // fld_lblMCodeColumns
            // 
            this.fld_lblMCodeColumns.AutoSize = true;
            this.fld_lblMCodeColumns.Location = new System.Drawing.Point(299, 28);
            this.fld_lblMCodeColumns.Name = "fld_lblMCodeColumns";
            this.fld_lblMCodeColumns.Size = new System.Drawing.Size(77, 13);
            this.fld_lblMCodeColumns.TabIndex = 14;
            this.fld_lblMCodeColumns.Text = "Optional Fields";
            // 
            // fld_dgcMCodeValue
            // 
            this.fld_dgcMCodeValue.EmbeddedNavigator.Name = "";
            this.fld_dgcMCodeValue.Location = new System.Drawing.Point(10, 51);
            this.fld_dgcMCodeValue.MainView = this.fld_dgvMCodeValue;
            this.fld_dgcMCodeValue.Name = "fld_dgcMCodeValue";
            this.fld_dgcMCodeValue.Size = new System.Drawing.Size(810, 399);
            this.fld_dgcMCodeValue.TabIndex = 13;
            this.fld_dgcMCodeValue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMCodeValue});
            // 
            // fld_dgvMCodeValue
            // 
            this.fld_dgvMCodeValue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colADMatchCodeValue});
            this.fld_dgvMCodeValue.GridControl = this.fld_dgcMCodeValue;
            this.fld_dgvMCodeValue.Name = "fld_dgvMCodeValue";
            this.fld_dgvMCodeValue.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.fld_dgvMCodeValue.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.fld_dgvMCodeValue_InitNewRow);
            this.fld_dgvMCodeValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fld_dgvMCodeValue_KeyDown);
            this.fld_dgvMCodeValue.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.fld_dgvMCodeValue_ValidateRow);
            // 
            // colADMatchCodeValue
            // 
            this.colADMatchCodeValue.Caption = "Value";
            this.colADMatchCodeValue.FieldName = "ADMatchCodeValue";
            this.colADMatchCodeValue.Name = "colADMatchCodeValue";
            this.colADMatchCodeValue.Visible = true;
            this.colADMatchCodeValue.VisibleIndex = 0;
            // 
            // fld_lblTables
            // 
            this.fld_lblTables.AutoSize = true;
            this.fld_lblTables.Location = new System.Drawing.Point(10, 28);
            this.fld_lblTables.Name = "fld_lblTables";
            this.fld_lblTables.Size = new System.Drawing.Size(46, 13);
            this.fld_lblTables.TabIndex = 12;
            this.fld_lblTables.Text = "Modules";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Location = new System.Drawing.Point(763, 473);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Size = new System.Drawing.Size(75, 20);
            this.fld_btnSave.TabIndex = 7;
            this.fld_btnSave.Text = "&Save";
            // 
            // guiConfigurationMatchCode
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 508);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "guiConfigurationMatchCode";
            this.Text = "Optional Fields";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeTableMatchCodes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeModules.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMCodeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMCodeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit fld_lkeTableMatchCodes;
        private DevExpress.XtraEditors.LookUpEdit fld_lkeModules;
        private System.Windows.Forms.Label fld_lblMCodeColumns;
        private DevExpress.XtraGrid.GridControl fld_dgcMCodeValue;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMCodeValue;
        private DevExpress.XtraGrid.Columns.GridColumn colADMatchCodeValue;
        private System.Windows.Forms.Label fld_lblTables;
        private DevExpress.XtraEditors.SimpleButton fld_btnSave;


    }
}