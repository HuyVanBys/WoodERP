namespace BOSERP.Modules.Product
{
    partial class guiAttributeInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAttributeInput));
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtICProductAttributeValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeICProductAttributeID = new BOSComponent.BOSLookupEdit(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtICProductAttributeNo = new DevExpress.XtraEditors.TextEdit();
            this.fld_lblICProductAttributeAbbreviation = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtICProductAttributeAbbreviation = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeAbbreviation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            resources.ApplyResources(this.fld_btnOK, "fld_btnOK");
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.fld_btnCancel, "fld_btnCancel");
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_lblFirstName
            // 
            resources.ApplyResources(this.fld_lblFirstName, "fld_lblFirstName");
            this.fld_lblFirstName.Name = "fld_lblFirstName";
            // 
            // fld_txtICProductAttributeValue
            // 
            resources.ApplyResources(this.fld_txtICProductAttributeValue, "fld_txtICProductAttributeValue");
            this.fld_txtICProductAttributeValue.Name = "fld_txtICProductAttributeValue";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // fld_lkeICProductAttributeID
            // 
            this.fld_lkeICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeICProductAttributeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductAttributeID.BOSDescription = null;
            this.fld_lkeICProductAttributeID.BOSError = null;
            this.fld_lkeICProductAttributeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductAttributeID.BOSSelectTypeValue = "HO";
            this.fld_lkeICProductAttributeID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeICProductAttributeID, "fld_lkeICProductAttributeID");
            this.fld_lkeICProductAttributeID.Name = "fld_lkeICProductAttributeID";
            this.fld_lkeICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICProductAttributeID.Properties.Buttons"))))});
            this.fld_lkeICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeICProductAttributeID.Properties.Columns"), resources.GetString("fld_lkeICProductAttributeID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeICProductAttributeID.Properties.Columns2"), resources.GetString("fld_lkeICProductAttributeID.Properties.Columns3"))});
            this.fld_lkeICProductAttributeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductAttributeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.Screen = null;
            this.fld_lkeICProductAttributeID.Tag = "DC";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // fld_txtICProductAttributeNo
            // 
            resources.ApplyResources(this.fld_txtICProductAttributeNo, "fld_txtICProductAttributeNo");
            this.fld_txtICProductAttributeNo.Name = "fld_txtICProductAttributeNo";
            // 
            // fld_lblICProductAttributeAbbreviation
            // 
            resources.ApplyResources(this.fld_lblICProductAttributeAbbreviation, "fld_lblICProductAttributeAbbreviation");
            this.fld_lblICProductAttributeAbbreviation.Name = "fld_lblICProductAttributeAbbreviation";
            // 
            // fld_txtICProductAttributeAbbreviation
            // 
            resources.ApplyResources(this.fld_txtICProductAttributeAbbreviation, "fld_txtICProductAttributeAbbreviation");
            this.fld_txtICProductAttributeAbbreviation.Name = "fld_txtICProductAttributeAbbreviation";
            // 
            // guiAttributeInput
            // 
            this.AcceptButton = this.fld_btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.Controls.Add(this.fld_lkeICProductAttributeID);
            this.Controls.Add(this.fld_txtICProductAttributeNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_txtICProductAttributeAbbreviation);
            this.Controls.Add(this.fld_lblICProductAttributeAbbreviation);
            this.Controls.Add(this.fld_txtICProductAttributeValue);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_lblFirstName);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAttributeInput";
            this.Load += new System.EventHandler(this.guiAttributeInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeAbbreviation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.LabelControl fld_lblFirstName;
        public DevExpress.XtraEditors.TextEdit fld_txtICProductAttributeValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit fld_txtICProductAttributeNo;
        private DevExpress.XtraEditors.LabelControl fld_lblICProductAttributeAbbreviation;
        public DevExpress.XtraEditors.TextEdit fld_txtICProductAttributeAbbreviation;
    }
}