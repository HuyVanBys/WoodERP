namespace BOSERP
{
    partial class guiProductGroupTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiProductGroupTree));
            this.fld_trlICProductGroups = new BOSComponent.BOSTreeListControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeDepartments = new DevExpress.XtraEditors.LookUpEdit();
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeDepartments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_trlICProductGroups
            // 
            this.fld_trlICProductGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlICProductGroups.BOSComment = null;
            this.fld_trlICProductGroups.BOSDataMember = null;
            this.fld_trlICProductGroups.BOSDataSource = null;
            this.fld_trlICProductGroups.BOSDescription = null;
            this.fld_trlICProductGroups.BOSDisplayOption = false;
            this.fld_trlICProductGroups.BOSDisplayRoot = false;
            this.fld_trlICProductGroups.BOSError = null;
            this.fld_trlICProductGroups.BOSFieldGroup = null;
            this.fld_trlICProductGroups.BOSFieldRelation = null;
            this.fld_trlICProductGroups.BOSPrivilege = null;
            this.fld_trlICProductGroups.BOSPropertyName = null;
            this.fld_trlICProductGroups.Location = new System.Drawing.Point(15, 106);
            this.fld_trlICProductGroups.Name = "fld_trlICProductGroups";
            this.fld_trlICProductGroups.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlICProductGroups.OptionsView.ShowColumns = false;
            this.fld_trlICProductGroups.OptionsView.ShowIndicator = false;
            this.fld_trlICProductGroups.Screen = null;
            this.fld_trlICProductGroups.Size = new System.Drawing.Size(531, 368);
            this.fld_trlICProductGroups.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chọn nhóm hàng thuộc ngành hàng trên";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(465, 480);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(81, 31);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(378, 480);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(81, 31);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ngành hàng";
            // 
            // fld_lkeDepartments
            // 
            this.fld_lkeDepartments.Location = new System.Drawing.Point(97, 9);
            this.fld_lkeDepartments.Name = "fld_lkeDepartments";
            this.fld_lkeDepartments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeDepartments.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Tên ngành hàng")});
            this.fld_lkeDepartments.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeDepartments.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeDepartments.Size = new System.Drawing.Size(197, 20);
            this.fld_lkeDepartments.TabIndex = 4;
            this.fld_lkeDepartments.EditValueChanged += new System.EventHandler(this.fld_lkeDepartments_EditValueChanged);
            // 
            // fld_lkeICProductGroupID
            // 
            this.fld_lkeICProductGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeICProductGroupID.BOSAllowDummy = false;
            this.fld_lkeICProductGroupID.BOSComment = null;
            this.fld_lkeICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroupID.BOSDescription = null;
            this.fld_lkeICProductGroupID.BOSError = null;
            this.fld_lkeICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeICProductGroupID.BOSFieldParent = null;
            this.fld_lkeICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeICProductGroupID.BOSPrivilege = null;
            this.fld_lkeICProductGroupID.BOSPropertyName = null;
            this.fld_lkeICProductGroupID.BOSSelectType = null;
            this.fld_lkeICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroupID.CurrentDisplayText = null;
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(15, 84);
            this.fld_lkeICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.ColumnName = null;
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên nhóm")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.NullText = "";
            this.fld_lkeICProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(531, 20);
            this.fld_lkeICProductGroupID.TabIndex = 1;
            this.fld_lkeICProductGroupID.Tag = "";
            this.fld_lkeICProductGroupID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeICProductGroupID_QueryPopUp);
            this.fld_lkeICProductGroupID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductGroupID_CloseUp);
            // 
            // guiProductGroupTree
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 523);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeICProductGroupID);
            this.Controls.Add(this.fld_lkeDepartments);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fld_trlICProductGroups);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiProductGroupTree.IconOptions.Icon")));
            this.Name = "guiProductGroupTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn nhóm hàng";
            this.Load += new System.EventHandler(this.guiProductGroupTree_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_trlICProductGroups, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lkeDepartments, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductGroupID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeDepartments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        public BOSComponent.BOSTreeListControl fld_trlICProductGroups;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit fld_lkeDepartments;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
    }
}