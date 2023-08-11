namespace BOSERP.Modules.ReceiptCD
{
    partial class guiAddLumber
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
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_txtICReceiptCDQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptCDQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.Location = new System.Drawing.Point(12, 53);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.Text = "OK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(196, 53);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_txtICReceiptCDQty
            // 
            this.fld_txtICReceiptCDQty.BOSComment = null;
            this.fld_txtICReceiptCDQty.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptCDQty.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptCDQty.BOSDescription = null;
            this.fld_txtICReceiptCDQty.BOSError = null;
            this.fld_txtICReceiptCDQty.BOSFieldGroup = null;
            this.fld_txtICReceiptCDQty.BOSFieldRelation = null;
            this.fld_txtICReceiptCDQty.BOSPrivilege = null;
            this.fld_txtICReceiptCDQty.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptCDQty.Location = new System.Drawing.Point(98, 12);
            this.fld_txtICReceiptCDQty.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptCDQty.Name = "fld_txtICReceiptCDQty";
            this.fld_txtICReceiptCDQty.Screen = null;
            this.fld_txtICReceiptCDQty.Size = new System.Drawing.Size(173, 20);
            this.fld_txtICReceiptCDQty.TabIndex = 1;
            this.fld_txtICReceiptCDQty.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(69, 13);
            this.bosLabel3.TabIndex = 20;
            this.bosLabel3.Text = "Số lượng dòng";
            // 
            // guiAddLumber
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(285, 101);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtICReceiptCDQty);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddLumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình gỗ phách";
            this.Load += new System.EventHandler(this.guiChooseDate_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptCDQty, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptCDQty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSTextBox fld_txtICReceiptCDQty;
        private BOSComponent.BOSLabel bosLabel3;
    }
}