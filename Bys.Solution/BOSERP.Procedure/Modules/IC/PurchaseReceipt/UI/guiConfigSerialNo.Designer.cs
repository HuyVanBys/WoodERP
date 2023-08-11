namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiConfigSerialNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiConfigSerialNo));
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSerialPrefix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtSerialNoStart = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtRowNumber = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerialPrefix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerialNoStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtRowNumber.Properties)).BeginInit();
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 22);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(33, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Tiền tố";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 48);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Text = "Số bắt đầu";
            // 
            // fld_txtSerialPrefix
            // 
            this.fld_txtSerialPrefix.BOSComment = null;
            this.fld_txtSerialPrefix.BOSDataMember = "ICReceiptPrefix";
            this.fld_txtSerialPrefix.BOSDataSource = "ICReceipts";
            this.fld_txtSerialPrefix.BOSDescription = null;
            this.fld_txtSerialPrefix.BOSError = null;
            this.fld_txtSerialPrefix.BOSFieldGroup = null;
            this.fld_txtSerialPrefix.BOSFieldRelation = null;
            this.fld_txtSerialPrefix.BOSPrivilege = null;
            this.fld_txtSerialPrefix.BOSPropertyName = "Text";
            this.fld_txtSerialPrefix.Location = new System.Drawing.Point(92, 19);
            this.fld_txtSerialPrefix.MenuManager = this.screenToolbar;
            this.fld_txtSerialPrefix.Name = "fld_txtSerialPrefix";
            this.fld_txtSerialPrefix.Screen = null;
            this.fld_txtSerialPrefix.Size = new System.Drawing.Size(196, 20);
            this.fld_txtSerialPrefix.TabIndex = 1;
            this.fld_txtSerialPrefix.Tag = "DC";
            // 
            // fld_txtSerialNoStart
            // 
            this.fld_txtSerialNoStart.BOSComment = null;
            this.fld_txtSerialNoStart.BOSDataMember = "ICReceiptSerialNoStart";
            this.fld_txtSerialNoStart.BOSDataSource = "ICReceipts";
            this.fld_txtSerialNoStart.BOSDescription = null;
            this.fld_txtSerialNoStart.BOSError = null;
            this.fld_txtSerialNoStart.BOSFieldGroup = null;
            this.fld_txtSerialNoStart.BOSFieldRelation = null;
            this.fld_txtSerialNoStart.BOSPrivilege = null;
            this.fld_txtSerialNoStart.BOSPropertyName = "Text";
            this.fld_txtSerialNoStart.Location = new System.Drawing.Point(92, 45);
            this.fld_txtSerialNoStart.Name = "fld_txtSerialNoStart";
            this.fld_txtSerialNoStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fld_txtSerialNoStart.Screen = null;
            this.fld_txtSerialNoStart.Size = new System.Drawing.Size(196, 20);
            this.fld_txtSerialNoStart.TabIndex = 3;
            this.fld_txtSerialNoStart.Tag = "DC";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = "";
            this.fld_btnOK.BOSDataSource = "";
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = "";
            this.fld_btnOK.Location = new System.Drawing.Point(96, 116);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 6;
            this.fld_btnOK.Tag = "";
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
            this.fld_btnCancel.Location = new System.Drawing.Point(204, 116);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 74);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(69, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Text = "Số lượng dòng";
            // 
            // fld_txtRowNumber
            // 
            this.fld_txtRowNumber.BOSComment = null;
            this.fld_txtRowNumber.BOSDataMember = "";
            this.fld_txtRowNumber.BOSDataSource = "";
            this.fld_txtRowNumber.BOSDescription = null;
            this.fld_txtRowNumber.BOSError = null;
            this.fld_txtRowNumber.BOSFieldGroup = null;
            this.fld_txtRowNumber.BOSFieldRelation = null;
            this.fld_txtRowNumber.BOSPrivilege = null;
            this.fld_txtRowNumber.BOSPropertyName = "Text";
            this.fld_txtRowNumber.Location = new System.Drawing.Point(92, 71);
            this.fld_txtRowNumber.Name = "fld_txtRowNumber";
            this.fld_txtRowNumber.Properties.DisplayFormat.FormatString = "N";
            this.fld_txtRowNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtRowNumber.Properties.EditFormat.FormatString = "N";
            this.fld_txtRowNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtRowNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fld_txtRowNumber.Screen = null;
            this.fld_txtRowNumber.Size = new System.Drawing.Size(196, 20);
            this.fld_txtRowNumber.TabIndex = 5;
            this.fld_txtRowNumber.Tag = "DC";
            // 
            // guiConfigSerialNo
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(361, 183);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_txtRowNumber);
            this.Controls.Add(this.fld_txtSerialNoStart);
            this.Controls.Add(this.fld_txtSerialPrefix);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiConfigSerialNo.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiConfigSerialNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thiết lập Số Serial";
            this.Load += new System.EventHandler(this.guiCommission_Load);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtSerialPrefix, 0);
            this.Controls.SetChildIndex(this.fld_txtSerialNoStart, 0);
            this.Controls.SetChildIndex(this.fld_txtRowNumber, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerialPrefix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerialNoStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtRowNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtSerialPrefix;
        private BOSComponent.BOSTextBox fld_txtSerialNoStart;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtRowNumber;
    }
}