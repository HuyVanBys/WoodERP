namespace BOSERP.Modules.ACDocumentType
{
    partial class guiDocumentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiDocumentType));
            this.fld_txtACDocumentTypeDesc = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentTypeDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACDocumentTypeDesc
            // 
            this.fld_txtACDocumentTypeDesc.BOSComment = null;
            this.fld_txtACDocumentTypeDesc.BOSDataMember = null;
            this.fld_txtACDocumentTypeDesc.BOSDataSource = null;
            this.fld_txtACDocumentTypeDesc.BOSDescription = null;
            this.fld_txtACDocumentTypeDesc.BOSError = null;
            this.fld_txtACDocumentTypeDesc.BOSFieldGroup = null;
            this.fld_txtACDocumentTypeDesc.BOSFieldRelation = null;
            this.fld_txtACDocumentTypeDesc.BOSPrivilege = null;
            this.fld_txtACDocumentTypeDesc.BOSPropertyName = null;
            this.fld_txtACDocumentTypeDesc.Location = new System.Drawing.Point(94, 12);
            this.fld_txtACDocumentTypeDesc.Name = "fld_txtACDocumentTypeDesc";
            this.fld_txtACDocumentTypeDesc.Screen = null;
            this.fld_txtACDocumentTypeDesc.Size = new System.Drawing.Size(229, 20);
            this.fld_txtACDocumentTypeDesc.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(4, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(84, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "Tên loại chứng từ";
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
            this.fld_btnSave.Location = new System.Drawing.Point(167, 48);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(248, 48);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiDocumentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 87);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_txtACDocumentTypeDesc);
            this.Controls.Add(this.bosLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiDocumentType";
            this.ScreenHelper.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa loại chứng từ";
            this.Load += new System.EventHandler(this.guiDocumentType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentTypeDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSTextBox fld_txtACDocumentTypeDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}