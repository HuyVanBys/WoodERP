namespace BOSERP.Modules.ACDocumentType
{
    partial class guiCreateEntryType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCreateEntryType));
            this.fld_txtACEntryTypeDesc = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCreate = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEntryTypeDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACEntryTypeDesc
            // 
            this.fld_txtACEntryTypeDesc.BOSComment = null;
            this.fld_txtACEntryTypeDesc.BOSDataMember = null;
            this.fld_txtACEntryTypeDesc.BOSDataSource = null;
            this.fld_txtACEntryTypeDesc.BOSDescription = null;
            this.fld_txtACEntryTypeDesc.BOSError = null;
            this.fld_txtACEntryTypeDesc.BOSFieldGroup = null;
            this.fld_txtACEntryTypeDesc.BOSFieldRelation = null;
            this.fld_txtACEntryTypeDesc.BOSPrivilege = null;
            this.fld_txtACEntryTypeDesc.BOSPropertyName = null;
            this.fld_txtACEntryTypeDesc.Location = new System.Drawing.Point(94, 12);
            this.fld_txtACEntryTypeDesc.Name = "fld_txtACEntryTypeDesc";
            this.fld_txtACEntryTypeDesc.Screen = null;
            this.fld_txtACEntryTypeDesc.Size = new System.Drawing.Size(229, 20);
            this.fld_txtACEntryTypeDesc.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(62, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "Tên bút toán";
            // 
            // fld_btnCreate
            // 
            this.fld_btnCreate.BOSComment = null;
            this.fld_btnCreate.BOSDataMember = null;
            this.fld_btnCreate.BOSDataSource = null;
            this.fld_btnCreate.BOSDescription = null;
            this.fld_btnCreate.BOSError = null;
            this.fld_btnCreate.BOSFieldGroup = null;
            this.fld_btnCreate.BOSFieldRelation = null;
            this.fld_btnCreate.BOSPrivilege = null;
            this.fld_btnCreate.BOSPropertyName = null;
            this.fld_btnCreate.Location = new System.Drawing.Point(167, 48);
            this.fld_btnCreate.Name = "fld_btnCreate";
            this.fld_btnCreate.Screen = null;
            this.fld_btnCreate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCreate.TabIndex = 2;
            this.fld_btnCreate.Text = "Tạo";
            this.fld_btnCreate.Click += new System.EventHandler(this.fld_btnCreate_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(248, 48);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiCreateEntryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 87);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnCreate);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACEntryTypeDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiCreateEntryType";
            this.ScreenHelper.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo bút toán";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEntryTypeDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSTextBox fld_txtACEntryTypeDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnCreate;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}