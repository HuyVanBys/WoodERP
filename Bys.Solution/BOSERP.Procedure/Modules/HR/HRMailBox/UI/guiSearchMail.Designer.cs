namespace BOSERP.Modules.HR.HRMailBox.UI
{
    partial class guiSearchMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiSearchMail));
            this.fld_lkeHRMailPriority100 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.fld_lblMailPriority = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSubject100 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblSubject = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDateTo100 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblDateTo = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDateFrom100 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblDateFrom = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMailPriority100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubject100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateTo100.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateTo100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateFrom100.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateFrom100.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeHRMailPriority100
            // 
            this.fld_lkeHRMailPriority100.BOSAllowAddNew = false;
            this.fld_lkeHRMailPriority100.BOSAllowDummy = false;
            this.fld_lkeHRMailPriority100.BOSComment = null;
            this.fld_lkeHRMailPriority100.BOSDataMember = "HRMailPriority";
            this.fld_lkeHRMailPriority100.BOSDataSource = "HRMails";
            this.fld_lkeHRMailPriority100.BOSDescription = null;
            this.fld_lkeHRMailPriority100.BOSError = null;
            this.fld_lkeHRMailPriority100.BOSFieldGroup = null;
            this.fld_lkeHRMailPriority100.BOSFieldParent = null;
            this.fld_lkeHRMailPriority100.BOSFieldRelation = null;
            this.fld_lkeHRMailPriority100.BOSPrivilege = null;
            this.fld_lkeHRMailPriority100.BOSPropertyName = "Edit Value";
            this.fld_lkeHRMailPriority100.BOSSelectType = null;
            this.fld_lkeHRMailPriority100.BOSSelectTypeValue = null;
            this.fld_lkeHRMailPriority100.CurrentDisplayText = null;
            this.fld_lkeHRMailPriority100.Location = new System.Drawing.Point(76, 61);
            this.fld_lkeHRMailPriority100.MenuManager = this.screenToolbar;
            this.fld_lkeHRMailPriority100.Name = "fld_lkeHRMailPriority100";
            this.fld_lkeHRMailPriority100.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fld_lkeHRMailPriority100.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMailPriority100.Properties.DisplayMember = "HRMailPriority";
            this.fld_lkeHRMailPriority100.Properties.NullText = "";
            this.fld_lkeHRMailPriority100.Properties.Tag = "";
            this.fld_lkeHRMailPriority100.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMailPriority100.Properties.ValueMember = "HRMailPriority";
            this.fld_lkeHRMailPriority100.Screen = null;
            this.fld_lkeHRMailPriority100.Size = new System.Drawing.Size(176, 20);
            this.fld_lkeHRMailPriority100.TabIndex = 78;
            this.fld_lkeHRMailPriority100.Tag = "SC";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(440, 100);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 77;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(359, 100);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 76;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // fld_lblMailPriority
            // 
            this.fld_lblMailPriority.BOSComment = null;
            this.fld_lblMailPriority.BOSDataMember = null;
            this.fld_lblMailPriority.BOSDataSource = null;
            this.fld_lblMailPriority.BOSDescription = null;
            this.fld_lblMailPriority.BOSError = null;
            this.fld_lblMailPriority.BOSFieldGroup = null;
            this.fld_lblMailPriority.BOSFieldRelation = null;
            this.fld_lblMailPriority.BOSPrivilege = null;
            this.fld_lblMailPriority.BOSPropertyName = null;
            this.fld_lblMailPriority.Location = new System.Drawing.Point(12, 68);
            this.fld_lblMailPriority.Name = "fld_lblMailPriority";
            this.fld_lblMailPriority.Screen = null;
            this.fld_lblMailPriority.Size = new System.Drawing.Size(55, 13);
            this.fld_lblMailPriority.TabIndex = 75;
            this.fld_lblMailPriority.Text = "Độ ưu tiên:";
            // 
            // fld_txtSubject100
            // 
            this.fld_txtSubject100.BOSComment = null;
            this.fld_txtSubject100.BOSDataMember = "HRMailSubject";
            this.fld_txtSubject100.BOSDataSource = "HRMails";
            this.fld_txtSubject100.BOSDescription = null;
            this.fld_txtSubject100.BOSError = null;
            this.fld_txtSubject100.BOSFieldGroup = null;
            this.fld_txtSubject100.BOSFieldRelation = null;
            this.fld_txtSubject100.BOSPrivilege = null;
            this.fld_txtSubject100.BOSPropertyName = "Text";
            this.fld_txtSubject100.Location = new System.Drawing.Point(76, 35);
            this.fld_txtSubject100.Name = "fld_txtSubject100";
            this.fld_txtSubject100.Screen = null;
            this.fld_txtSubject100.Size = new System.Drawing.Size(435, 20);
            this.fld_txtSubject100.TabIndex = 74;
            this.fld_txtSubject100.Tag = "SC";
            // 
            // fld_lblSubject
            // 
            this.fld_lblSubject.BOSComment = null;
            this.fld_lblSubject.BOSDataMember = null;
            this.fld_lblSubject.BOSDataSource = null;
            this.fld_lblSubject.BOSDescription = null;
            this.fld_lblSubject.BOSError = null;
            this.fld_lblSubject.BOSFieldGroup = null;
            this.fld_lblSubject.BOSFieldRelation = null;
            this.fld_lblSubject.BOSPrivilege = null;
            this.fld_lblSubject.BOSPropertyName = null;
            this.fld_lblSubject.Location = new System.Drawing.Point(12, 42);
            this.fld_lblSubject.Name = "fld_lblSubject";
            this.fld_lblSubject.Screen = null;
            this.fld_lblSubject.Size = new System.Drawing.Size(39, 13);
            this.fld_lblSubject.TabIndex = 73;
            this.fld_lblSubject.Text = "Tiêu đề:";
            // 
            // fld_dteSearchToDateTo100
            // 
            this.fld_dteSearchToDateTo100.BOSComment = null;
            this.fld_dteSearchToDateTo100.BOSDataMember = "HRMailDate";
            this.fld_dteSearchToDateTo100.BOSDataSource = "HRMails";
            this.fld_dteSearchToDateTo100.BOSDescription = null;
            this.fld_dteSearchToDateTo100.BOSError = null;
            this.fld_dteSearchToDateTo100.BOSFieldGroup = null;
            this.fld_dteSearchToDateTo100.BOSFieldRelation = null;
            this.fld_dteSearchToDateTo100.BOSPrivilege = null;
            this.fld_dteSearchToDateTo100.BOSPropertyName = "Edit Value";
            this.fld_dteSearchToDateTo100.EditValue = null;
            this.fld_dteSearchToDateTo100.Location = new System.Drawing.Point(347, 9);
            this.fld_dteSearchToDateTo100.Name = "fld_dteSearchToDateTo100";
            this.fld_dteSearchToDateTo100.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDateTo100.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDateTo100.Screen = null;
            this.fld_dteSearchToDateTo100.Size = new System.Drawing.Size(164, 20);
            this.fld_dteSearchToDateTo100.TabIndex = 72;
            this.fld_dteSearchToDateTo100.Tag = "SC";
            // 
            // fld_lblDateTo
            // 
            this.fld_lblDateTo.BOSComment = null;
            this.fld_lblDateTo.BOSDataMember = null;
            this.fld_lblDateTo.BOSDataSource = null;
            this.fld_lblDateTo.BOSDescription = null;
            this.fld_lblDateTo.BOSError = null;
            this.fld_lblDateTo.BOSFieldGroup = null;
            this.fld_lblDateTo.BOSFieldRelation = null;
            this.fld_lblDateTo.BOSPrivilege = null;
            this.fld_lblDateTo.BOSPropertyName = null;
            this.fld_lblDateTo.Location = new System.Drawing.Point(277, 12);
            this.fld_lblDateTo.Name = "fld_lblDateTo";
            this.fld_lblDateTo.Screen = null;
            this.fld_lblDateTo.Size = new System.Drawing.Size(51, 13);
            this.fld_lblDateTo.TabIndex = 71;
            this.fld_lblDateTo.Text = "Đến ngày:";
            // 
            // fld_dteSearchFromDateFrom100
            // 
            this.fld_dteSearchFromDateFrom100.BOSComment = null;
            this.fld_dteSearchFromDateFrom100.BOSDataMember = "HRMailDate";
            this.fld_dteSearchFromDateFrom100.BOSDataSource = "HRMails";
            this.fld_dteSearchFromDateFrom100.BOSDescription = null;
            this.fld_dteSearchFromDateFrom100.BOSError = null;
            this.fld_dteSearchFromDateFrom100.BOSFieldGroup = null;
            this.fld_dteSearchFromDateFrom100.BOSFieldRelation = null;
            this.fld_dteSearchFromDateFrom100.BOSPrivilege = null;
            this.fld_dteSearchFromDateFrom100.BOSPropertyName = "Edit Value";
            this.fld_dteSearchFromDateFrom100.EditValue = null;
            this.fld_dteSearchFromDateFrom100.Location = new System.Drawing.Point(76, 9);
            this.fld_dteSearchFromDateFrom100.Name = "fld_dteSearchFromDateFrom100";
            this.fld_dteSearchFromDateFrom100.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDateFrom100.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDateFrom100.Screen = null;
            this.fld_dteSearchFromDateFrom100.Size = new System.Drawing.Size(176, 20);
            this.fld_dteSearchFromDateFrom100.TabIndex = 70;
            this.fld_dteSearchFromDateFrom100.Tag = "SC";
            // 
            // fld_lblDateFrom
            // 
            this.fld_lblDateFrom.BOSComment = null;
            this.fld_lblDateFrom.BOSDataMember = null;
            this.fld_lblDateFrom.BOSDataSource = null;
            this.fld_lblDateFrom.BOSDescription = null;
            this.fld_lblDateFrom.BOSError = null;
            this.fld_lblDateFrom.BOSFieldGroup = null;
            this.fld_lblDateFrom.BOSFieldRelation = null;
            this.fld_lblDateFrom.BOSPrivilege = null;
            this.fld_lblDateFrom.BOSPropertyName = null;
            this.fld_lblDateFrom.Location = new System.Drawing.Point(12, 12);
            this.fld_lblDateFrom.Name = "fld_lblDateFrom";
            this.fld_lblDateFrom.Screen = null;
            this.fld_lblDateFrom.Size = new System.Drawing.Size(44, 13);
            this.fld_lblDateFrom.TabIndex = 69;
            this.fld_lblDateFrom.Text = "Từ ngày:";
            // 
            // guiSearchMail
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(523, 139);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeHRMailPriority100);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.fld_lblMailPriority);
            this.Controls.Add(this.fld_txtSubject100);
            this.Controls.Add(this.fld_lblSubject);
            this.Controls.Add(this.fld_dteSearchToDateTo100);
            this.Controls.Add(this.fld_lblDateTo);
            this.Controls.Add(this.fld_dteSearchFromDateFrom100);
            this.Controls.Add(this.fld_lblDateFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiSearchMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Text = "Tìm kiếm thư";
            this.Load += new System.EventHandler(this.guiSearchMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMailPriority100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubject100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateTo100.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDateTo100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateFrom100.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDateFrom100.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLookupEdit fld_lkeHRMailPriority100;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSLabel fld_lblMailPriority;
        private BOSComponent.BOSTextBox fld_txtSubject100;
        private BOSComponent.BOSLabel fld_lblSubject;
        private BOSComponent.BOSDateEdit fld_dteSearchToDateTo100;
        private BOSComponent.BOSLabel fld_lblDateTo;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDateFrom100;
        private BOSComponent.BOSLabel fld_lblDateFrom;

    }
}