namespace BOSERP.Modules.SaleOrderForOther
{
    partial class guiDiffPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiDiffPrice));
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_txtARSaleOrderTotalDiffPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderSODiffPricePercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderSODiffPriceAmount = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalDiffPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSODiffPricePercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSODiffPriceAmount.Properties)).BeginInit();
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(78, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Tổng chênh lệch";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 45);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(85, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Người mua hưởng";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(87, 90);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
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
            this.fld_btnCancel.Location = new System.Drawing.Point(168, 90);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_txtARSaleOrderTotalDiffPrice
            // 
            this.fld_txtARSaleOrderTotalDiffPrice.BOSComment = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSDataMember = "ARSaleOrderTotalDiffPrice";
            this.fld_txtARSaleOrderTotalDiffPrice.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalDiffPrice.BOSDescription = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSError = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSFieldGroup = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSFieldRelation = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSPrivilege = null;
            this.fld_txtARSaleOrderTotalDiffPrice.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderTotalDiffPrice.EditValue = "0.00";
            this.fld_txtARSaleOrderTotalDiffPrice.Location = new System.Drawing.Point(145, 9);
            this.fld_txtARSaleOrderTotalDiffPrice.Name = "fld_txtARSaleOrderTotalDiffPrice";
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Mask.EditMask = "n0";
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalDiffPrice.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalDiffPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalDiffPrice.Screen = null;
            this.fld_txtARSaleOrderTotalDiffPrice.Size = new System.Drawing.Size(159, 20);
            this.fld_txtARSaleOrderTotalDiffPrice.TabIndex = 0;
            this.fld_txtARSaleOrderTotalDiffPrice.Tag = "DC";
            // 
            // fld_txtARSaleOrderSODiffPricePercent
            // 
            this.fld_txtARSaleOrderSODiffPricePercent.BOSComment = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSDataMember = "ARSaleOrderSODiffPricePercent";
            this.fld_txtARSaleOrderSODiffPricePercent.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSODiffPricePercent.BOSDescription = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSError = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSPrivilege = null;
            this.fld_txtARSaleOrderSODiffPricePercent.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSODiffPricePercent.EditValue = "0.00";
            this.fld_txtARSaleOrderSODiffPricePercent.Location = new System.Drawing.Point(145, 42);
            this.fld_txtARSaleOrderSODiffPricePercent.Name = "fld_txtARSaleOrderSODiffPricePercent";
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderSODiffPricePercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSODiffPricePercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSODiffPricePercent.Screen = null;
            this.fld_txtARSaleOrderSODiffPricePercent.Size = new System.Drawing.Size(62, 20);
            this.fld_txtARSaleOrderSODiffPricePercent.TabIndex = 1;
            this.fld_txtARSaleOrderSODiffPricePercent.Tag = "DC";
            this.fld_txtARSaleOrderSODiffPricePercent.Validated += new System.EventHandler(this.fld_txtARSaleOrderSODiffPricePercent_Validated);
            // 
            // fld_txtARSaleOrderSODiffPriceAmount
            // 
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSComment = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSDataMember = "ARSaleOrderSODiffPriceAmount";
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSDescription = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSError = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSPrivilege = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSODiffPriceAmount.EditValue = "0.00";
            this.fld_txtARSaleOrderSODiffPriceAmount.Location = new System.Drawing.Point(213, 42);
            this.fld_txtARSaleOrderSODiffPriceAmount.Name = "fld_txtARSaleOrderSODiffPriceAmount";
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderSODiffPriceAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSODiffPriceAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSODiffPriceAmount.Screen = null;
            this.fld_txtARSaleOrderSODiffPriceAmount.Size = new System.Drawing.Size(91, 20);
            this.fld_txtARSaleOrderSODiffPriceAmount.TabIndex = 2;
            this.fld_txtARSaleOrderSODiffPriceAmount.Tag = "DC";
            this.fld_txtARSaleOrderSODiffPriceAmount.Validated += new System.EventHandler(this.fld_txtARSaleOrderSODiffPriceAmount_Validated);
            // 
            // guiDiffPrice
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(333, 129);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtARSaleOrderSODiffPriceAmount);
            this.Controls.Add(this.fld_txtARSaleOrderSODiffPricePercent);
            this.Controls.Add(this.fld_txtARSaleOrderTotalDiffPrice);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiDiffPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kê giá";
            this.Load += new System.EventHandler(this.guiDiffPrice_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleOrderTotalDiffPrice, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleOrderSODiffPricePercent, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleOrderSODiffPriceAmount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalDiffPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSODiffPricePercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSODiffPriceAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalDiffPrice;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSODiffPricePercent;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSODiffPriceAmount;
    }
}