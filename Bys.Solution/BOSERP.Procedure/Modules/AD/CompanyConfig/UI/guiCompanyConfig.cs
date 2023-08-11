using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data;


namespace BOSERP.Modules.CompanyConfig
{
    /// <summary>
    /// Summary description for guiCompanyConfig.
    /// </summary>
    public class guiCompanyConfig : BOSERPScreen
    {
        private DevExpress.XtraGrid.GridControl fld_dgcCompanyConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView dgcCompanyConfigView;
        private IContainer components;

        public static DataSet glbdsCompanyConfigValues = new DataSet();
        private DevExpress.XtraGrid.Columns.GridColumn A1CompanyConfigID;
        private DevExpress.XtraGrid.Columns.GridColumn A1CompanyConfigKey;
        private DevExpress.XtraGrid.Columns.GridColumn A1CompanyConfigLabel;
        private DevExpress.XtraGrid.Columns.GridColumn A1CompanyConfigValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;

        public static readonly String A1CompanyConfigValueTable = "A1CompanyConfigValues";
        private DevExpress.XtraGrid.Columns.GridColumn ADUserGroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repUserGroupComboBox;

        DataSet dsA1CompanyConfigs = new DataSet();
        private SimpleButton fld_btnSave;
 
        public guiCompanyConfig()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            AddCompanyConfigToGrid(fld_dgcCompanyConfig);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.fld_dgcCompanyConfig = new DevExpress.XtraGrid.GridControl();
            this.dgcCompanyConfigView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.A1CompanyConfigID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A1CompanyConfigKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A1CompanyConfigLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.A1CompanyConfigValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADUserGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUserGroupComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fld_btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCompanyConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCompanyConfigView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUserGroupComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcCompanyConfig
            // 
            this.fld_dgcCompanyConfig.EmbeddedNavigator.Name = "";
            this.fld_dgcCompanyConfig.Location = new System.Drawing.Point(15, 15);
            this.fld_dgcCompanyConfig.MainView = this.dgcCompanyConfigView;
            this.fld_dgcCompanyConfig.Name = "fld_dgcCompanyConfig";
            this.fld_dgcCompanyConfig.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit,
            this.repUserGroupComboBox});
            this.fld_dgcCompanyConfig.Size = new System.Drawing.Size(830, 500);
            this.fld_dgcCompanyConfig.TabIndex = 0;
            this.fld_dgcCompanyConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgcCompanyConfigView});
            // 
            // dgcCompanyConfigView
            // 
            this.dgcCompanyConfigView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.A1CompanyConfigID,
            this.A1CompanyConfigKey,
            this.A1CompanyConfigLabel,
            this.A1CompanyConfigValue,
            this.ADUserGroupID});
            this.dgcCompanyConfigView.GridControl = this.fld_dgcCompanyConfig;
            this.dgcCompanyConfigView.Name = "dgcCompanyConfigView";
            this.dgcCompanyConfigView.OptionsBehavior.AllowIncrementalSearch = true;
            this.dgcCompanyConfigView.OptionsBehavior.AutoExpandAllGroups = true;
            this.dgcCompanyConfigView.OptionsCustomization.AllowColumnMoving = false;
            this.dgcCompanyConfigView.OptionsCustomization.AllowRowSizing = true;
            this.dgcCompanyConfigView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.dgcCompanyConfigView.OptionsLayout.Columns.AddNewColumns = false;
            this.dgcCompanyConfigView.OptionsLayout.Columns.RemoveOldColumns = false;
            this.dgcCompanyConfigView.OptionsView.ShowGroupedColumns = true;
            this.dgcCompanyConfigView.OptionsView.ShowGroupPanel = false;
            // 
            // A1CompanyConfigID
            // 
            this.A1CompanyConfigID.Caption = "A1CompanyConfigID";
            this.A1CompanyConfigID.FieldName = "A1CompanyConfigID";
            this.A1CompanyConfigID.Name = "A1CompanyConfigID";
            // 
            // A1CompanyConfigKey
            // 
            this.A1CompanyConfigKey.Caption = "Key";
            this.A1CompanyConfigKey.FieldName = "A1CompanyConfigKey";
            this.A1CompanyConfigKey.Name = "A1CompanyConfigKey";
            this.A1CompanyConfigKey.OptionsColumn.AllowEdit = false;
            this.A1CompanyConfigKey.Visible = true;
            this.A1CompanyConfigKey.VisibleIndex = 0;
            // 
            // A1CompanyConfigLabel
            // 
            this.A1CompanyConfigLabel.Caption = "Label";
            this.A1CompanyConfigLabel.ColumnEdit = this.repositoryItemTextEdit;
            this.A1CompanyConfigLabel.FieldName = "A1CompanyConfigLabel";
            this.A1CompanyConfigLabel.Name = "A1CompanyConfigLabel";
            this.A1CompanyConfigLabel.Visible = true;
            this.A1CompanyConfigLabel.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.MaxLength = 40;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            // 
            // A1CompanyConfigValue
            // 
            this.A1CompanyConfigValue.Caption = "Value";
            this.A1CompanyConfigValue.ColumnEdit = this.repositoryItemTextEdit;
            this.A1CompanyConfigValue.FieldName = "A1CompanyConfigValue";
            this.A1CompanyConfigValue.Name = "A1CompanyConfigValue";
            this.A1CompanyConfigValue.Visible = true;
            this.A1CompanyConfigValue.VisibleIndex = 2;
            // 
            // ADUserGroupID
            // 
            this.ADUserGroupID.Caption = "ADUserGroupID";
            this.ADUserGroupID.ColumnEdit = this.repUserGroupComboBox;
            this.ADUserGroupID.FieldName = "ADUserGroupID";
            this.ADUserGroupID.Name = "ADUserGroupID";
            this.ADUserGroupID.OptionsColumn.AllowEdit = false;
            // 
            // repUserGroupComboBox
            // 
            this.repUserGroupComboBox.AutoHeight = false;
            this.repUserGroupComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUserGroupComboBox.Items.AddRange(new object[] {
            "111",
            "222",
            "3333"});
            this.repUserGroupComboBox.Mask.BeepOnError = true;
            this.repUserGroupComboBox.Name = "repUserGroupComboBox";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Location = new System.Drawing.Point(765, 518);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Size = new System.Drawing.Size(75, 23);
            this.fld_btnSave.TabIndex = 6;
            this.fld_btnSave.Text = "Speichern";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiCompanyConfig
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(852, 573);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_dgcCompanyConfig);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "guiCompanyConfig";
            this.Text = "Einstellungen";
            this.Controls.SetChildIndex(this.fld_dgcCompanyConfig, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCompanyConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCompanyConfigView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUserGroupComboBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void AddCompanyConfigToGrid(DevExpress.XtraGrid.GridControl gridControl)
        {
            A1CompanyConfigsController objCompanyConfigsController = new A1CompanyConfigsController();
            dsA1CompanyConfigs = objCompanyConfigsController.GetAllObjects();
            gridControl.DataSource = dsA1CompanyConfigs.Tables[0];
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            A1CompanyConfigsController objA1CompanyConfigsController = new A1CompanyConfigsController();
            foreach (DataRow rowA1CompanyConfig in dsA1CompanyConfigs.Tables[0].Rows)
            {
                A1CompanyConfigsInfo objA1CompanyConfigsInfo = (A1CompanyConfigsInfo)objA1CompanyConfigsController.GetObjectFromDataRow(rowA1CompanyConfig);
                if (objA1CompanyConfigsInfo != null)
                {
                    if (objA1CompanyConfigsController.IsExist(objA1CompanyConfigsInfo.A1CompanyConfigID))
                    {
                        objA1CompanyConfigsController.UpdateObject(objA1CompanyConfigsInfo);
                    }
                    else
                    {
                        objA1CompanyConfigsController.CreateObject(objA1CompanyConfigsInfo);
                    }
                }
            }

            A1CompanyConfigUtility.CompanyConfigInit();
            MessageBox.Show("Gespeichert", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }

     }
}

