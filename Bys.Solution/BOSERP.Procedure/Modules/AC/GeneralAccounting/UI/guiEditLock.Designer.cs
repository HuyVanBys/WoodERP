namespace BOSERP.Modules.GeneralAccounting
{
    partial class guiEditLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiEditLock));
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dteADLockFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteADLockToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_chkIsLocked = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medADLockDesc = new BOSComponent.BOSMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsLocked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medADLockDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 22);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(247, 22);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(154, 129);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 6;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(235, 129);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dteADLockFromDate
            // 
            this.fld_dteADLockFromDate.BOSComment = null;
            this.fld_dteADLockFromDate.BOSDataMember = "ADLockFromDate";
            this.fld_dteADLockFromDate.BOSDataSource = "ADLocks";
            this.fld_dteADLockFromDate.BOSDescription = null;
            this.fld_dteADLockFromDate.BOSError = null;
            this.fld_dteADLockFromDate.BOSFieldGroup = null;
            this.fld_dteADLockFromDate.BOSFieldRelation = null;
            this.fld_dteADLockFromDate.BOSPrivilege = null;
            this.fld_dteADLockFromDate.BOSPropertyName = "EditValue";
            this.fld_dteADLockFromDate.EditValue = null;
            this.fld_dteADLockFromDate.Location = new System.Drawing.Point(79, 19);
            this.fld_dteADLockFromDate.Name = "fld_dteADLockFromDate";
            this.fld_dteADLockFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteADLockFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteADLockFromDate.Screen = null;
            this.fld_dteADLockFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteADLockFromDate.TabIndex = 1;
            this.fld_dteADLockFromDate.Tag = "DC";
            // 
            // fld_dteADLockToDate
            // 
            this.fld_dteADLockToDate.BOSComment = null;
            this.fld_dteADLockToDate.BOSDataMember = "ADLockToDate";
            this.fld_dteADLockToDate.BOSDataSource = "ADLocks";
            this.fld_dteADLockToDate.BOSDescription = null;
            this.fld_dteADLockToDate.BOSError = null;
            this.fld_dteADLockToDate.BOSFieldGroup = null;
            this.fld_dteADLockToDate.BOSFieldRelation = null;
            this.fld_dteADLockToDate.BOSPrivilege = null;
            this.fld_dteADLockToDate.BOSPropertyName = "EditValue";
            this.fld_dteADLockToDate.EditValue = null;
            this.fld_dteADLockToDate.Location = new System.Drawing.Point(300, 19);
            this.fld_dteADLockToDate.Name = "fld_dteADLockToDate";
            this.fld_dteADLockToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteADLockToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteADLockToDate.Screen = null;
            this.fld_dteADLockToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteADLockToDate.TabIndex = 2;
            this.fld_dteADLockToDate.Tag = "DC";
            // 
            // fld_chkIsLocked
            // 
            this.fld_chkIsLocked.BOSComment = null;
            this.fld_chkIsLocked.BOSDataMember = "IsLocked";
            this.fld_chkIsLocked.BOSDataSource = "ADLocks";
            this.fld_chkIsLocked.BOSDescription = null;
            this.fld_chkIsLocked.BOSError = null;
            this.fld_chkIsLocked.BOSFieldGroup = null;
            this.fld_chkIsLocked.BOSFieldRelation = null;
            this.fld_chkIsLocked.BOSPrivilege = null;
            this.fld_chkIsLocked.BOSPropertyName = "EditValue";
            this.fld_chkIsLocked.Location = new System.Drawing.Point(77, 97);
            this.fld_chkIsLocked.Name = "fld_chkIsLocked";
            this.fld_chkIsLocked.Properties.Caption = "Khóa";
            this.fld_chkIsLocked.Screen = null;
            this.fld_chkIsLocked.Size = new System.Drawing.Size(152, 19);
            this.fld_chkIsLocked.TabIndex = 5;
            this.fld_chkIsLocked.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 59);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_medADLockDesc
            // 
            this.fld_medADLockDesc.BOSComment = null;
            this.fld_medADLockDesc.BOSDataMember = "ADLockDesc";
            this.fld_medADLockDesc.BOSDataSource = "ADLocks";
            this.fld_medADLockDesc.BOSDescription = null;
            this.fld_medADLockDesc.BOSError = null;
            this.fld_medADLockDesc.BOSFieldGroup = null;
            this.fld_medADLockDesc.BOSFieldRelation = null;
            this.fld_medADLockDesc.BOSPrivilege = null;
            this.fld_medADLockDesc.BOSPropertyName = "Text";
            this.fld_medADLockDesc.Location = new System.Drawing.Point(79, 45);
            this.fld_medADLockDesc.MenuManager = this.screenToolbar;
            this.fld_medADLockDesc.Name = "fld_medADLockDesc";
            this.fld_medADLockDesc.Screen = null;
            this.fld_medADLockDesc.Size = new System.Drawing.Size(371, 46);
            this.fld_medADLockDesc.TabIndex = 4;
            this.fld_medADLockDesc.Tag = "DC";
            // 
            // guiEditLock
            // 
            this.AcceptButton = this.fld_btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(458, 168);
            this.ControlBox = true;
            this.Controls.Add(this.fld_medADLockDesc);
            this.Controls.Add(this.fld_dteADLockToDate);
            this.Controls.Add(this.fld_dteADLockFromDate);
            this.Controls.Add(this.fld_chkIsLocked);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiEditLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Sửa khóa";
            this.Load += new System.EventHandler(this.guiEditLock_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_chkIsLocked, 0);
            this.Controls.SetChildIndex(this.fld_dteADLockFromDate, 0);
            this.Controls.SetChildIndex(this.fld_dteADLockToDate, 0);
            this.Controls.SetChildIndex(this.fld_medADLockDesc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteADLockToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsLocked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medADLockDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSDateEdit fld_dteADLockFromDate;
        private BOSComponent.BOSDateEdit fld_dteADLockToDate;
        private BOSComponent.BOSCheckEdit fld_chkIsLocked;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medADLockDesc;
    }
}