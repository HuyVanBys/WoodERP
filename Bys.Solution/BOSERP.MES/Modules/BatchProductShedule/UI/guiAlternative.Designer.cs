namespace BOSERP.Modules.BatchProductShedule
{
    partial class guiAlternative
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductsGridControl = new BOSERP.Modules.BatchProductShedule.ICAlternativeMaterialsGridControl();
            this.fld_blnInfo = new BOSComponent.BOSLine(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHeigth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).BeginInit();
            this.fld_blnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHeigth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(893, 554);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(804, 554);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Lưu";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProductsGridControl
            // 
            this.fld_dgcProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductsGridControl.BOSComment = null;
            this.fld_dgcProductsGridControl.BOSDataMember = null;
            this.fld_dgcProductsGridControl.BOSDataSource = "ICProductAlternatives";
            this.fld_dgcProductsGridControl.BOSDescription = null;
            this.fld_dgcProductsGridControl.BOSError = null;
            this.fld_dgcProductsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductsGridControl.BOSGridType = null;
            this.fld_dgcProductsGridControl.BOSPrivilege = null;
            this.fld_dgcProductsGridControl.BOSPropertyName = null;
            this.fld_dgcProductsGridControl.CommodityType = "";
            this.fld_dgcProductsGridControl.IsAlterOverConfigMaterial = false;
            this.fld_dgcProductsGridControl.Location = new System.Drawing.Point(-1, 78);
            this.fld_dgcProductsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductsGridControl.Name = "fld_dgcProductsGridControl";
            this.fld_dgcProductsGridControl.PrintReport = false;
            this.fld_dgcProductsGridControl.Screen = null;
            this.fld_dgcProductsGridControl.Size = new System.Drawing.Size(990, 470);
            this.fld_dgcProductsGridControl.SourceAlternative = null;
            this.fld_dgcProductsGridControl.TabIndex = 2;
            this.fld_dgcProductsGridControl.Tag = "";
            // 
            // fld_blnInfo
            // 
            this.fld_blnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_blnInfo.BOSComment = null;
            this.fld_blnInfo.BOSDataMember = null;
            this.fld_blnInfo.BOSDataSource = null;
            this.fld_blnInfo.BOSDescription = null;
            this.fld_blnInfo.BOSError = null;
            this.fld_blnInfo.BOSFieldGroup = null;
            this.fld_blnInfo.BOSFieldRelation = null;
            this.fld_blnInfo.BOSPrivilege = null;
            this.fld_blnInfo.BOSPropertyName = null;
            this.fld_blnInfo.Controls.Add(this.bosLabel5);
            this.fld_blnInfo.Controls.Add(this.bosLabel1);
            this.fld_blnInfo.Controls.Add(this.bosLabel3);
            this.fld_blnInfo.Controls.Add(this.bosLabel4);
            this.fld_blnInfo.Controls.Add(this.fld_txtLength);
            this.fld_blnInfo.Controls.Add(this.fld_txtWidth);
            this.fld_blnInfo.Controls.Add(this.fld_txtQty);
            this.fld_blnInfo.Controls.Add(this.fld_txtHeigth);
            this.fld_blnInfo.Controls.Add(this.fld_txtProductName);
            this.fld_blnInfo.Controls.Add(this.bosLabel2);
            this.fld_blnInfo.Controls.Add(this.fld_txtProductNo);
            this.fld_blnInfo.Controls.Add(this.bosLabel7);
            this.fld_blnInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_blnInfo.Location = new System.Drawing.Point(-1, 0);
            this.fld_blnInfo.Name = "fld_blnInfo";
            this.fld_blnInfo.Screen = null;
            this.fld_blnInfo.Size = new System.Drawing.Size(990, 72);
            this.fld_blnInfo.TabIndex = 129;
            this.fld_blnInfo.TabStop = false;
            this.fld_blnInfo.Text = "Thông tin chung";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(11, 46);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(46, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Dày (mm)";
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
            this.bosLabel1.Location = new System.Drawing.Point(11, 20);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã BTP";
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
            this.bosLabel3.Location = new System.Drawing.Point(490, 46);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(42, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Text = "Dài (mm)";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(490, 20);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(63, 13);
            this.bosLabel4.TabIndex = 8;
            this.bosLabel4.Text = "Số lượng BTP";
            // 
            // fld_txtLength
            // 
            this.fld_txtLength.BOSComment = null;
            this.fld_txtLength.BOSDataMember = "";
            this.fld_txtLength.BOSDataSource = "";
            this.fld_txtLength.BOSDescription = null;
            this.fld_txtLength.BOSError = null;
            this.fld_txtLength.BOSFieldGroup = null;
            this.fld_txtLength.BOSFieldRelation = null;
            this.fld_txtLength.BOSPrivilege = null;
            this.fld_txtLength.BOSPropertyName = "EditValue";
            this.fld_txtLength.Location = new System.Drawing.Point(559, 43);
            this.fld_txtLength.Name = "fld_txtLength";
            this.fld_txtLength.Properties.ReadOnly = true;
            this.fld_txtLength.Screen = null;
            this.fld_txtLength.Size = new System.Drawing.Size(152, 20);
            this.fld_txtLength.TabIndex = 0;
            this.fld_txtLength.Tag = "DC";
            // 
            // fld_txtWidth
            // 
            this.fld_txtWidth.BOSComment = null;
            this.fld_txtWidth.BOSDataMember = "";
            this.fld_txtWidth.BOSDataSource = "";
            this.fld_txtWidth.BOSDescription = null;
            this.fld_txtWidth.BOSError = null;
            this.fld_txtWidth.BOSFieldGroup = null;
            this.fld_txtWidth.BOSFieldRelation = null;
            this.fld_txtWidth.BOSPrivilege = null;
            this.fld_txtWidth.BOSPropertyName = "EditValue";
            this.fld_txtWidth.Location = new System.Drawing.Point(310, 43);
            this.fld_txtWidth.Name = "fld_txtWidth";
            this.fld_txtWidth.Properties.ReadOnly = true;
            this.fld_txtWidth.Screen = null;
            this.fld_txtWidth.Size = new System.Drawing.Size(152, 20);
            this.fld_txtWidth.TabIndex = 0;
            this.fld_txtWidth.Tag = "DC";
            // 
            // fld_txtQty
            // 
            this.fld_txtQty.BOSComment = null;
            this.fld_txtQty.BOSDataMember = "";
            this.fld_txtQty.BOSDataSource = "";
            this.fld_txtQty.BOSDescription = null;
            this.fld_txtQty.BOSError = null;
            this.fld_txtQty.BOSFieldGroup = null;
            this.fld_txtQty.BOSFieldRelation = null;
            this.fld_txtQty.BOSPrivilege = null;
            this.fld_txtQty.BOSPropertyName = "EditValue";
            this.fld_txtQty.Location = new System.Drawing.Point(559, 17);
            this.fld_txtQty.Name = "fld_txtQty";
            this.fld_txtQty.Properties.ReadOnly = true;
            this.fld_txtQty.Screen = null;
            this.fld_txtQty.Size = new System.Drawing.Size(152, 20);
            this.fld_txtQty.TabIndex = 0;
            this.fld_txtQty.Tag = "DC";
            // 
            // fld_txtHeigth
            // 
            this.fld_txtHeigth.BOSComment = null;
            this.fld_txtHeigth.BOSDataMember = "";
            this.fld_txtHeigth.BOSDataSource = "";
            this.fld_txtHeigth.BOSDescription = null;
            this.fld_txtHeigth.BOSError = null;
            this.fld_txtHeigth.BOSFieldGroup = null;
            this.fld_txtHeigth.BOSFieldRelation = null;
            this.fld_txtHeigth.BOSPrivilege = null;
            this.fld_txtHeigth.BOSPropertyName = "EditValue";
            this.fld_txtHeigth.Location = new System.Drawing.Point(66, 43);
            this.fld_txtHeigth.Name = "fld_txtHeigth";
            this.fld_txtHeigth.Properties.ReadOnly = true;
            this.fld_txtHeigth.Screen = null;
            this.fld_txtHeigth.Size = new System.Drawing.Size(152, 20);
            this.fld_txtHeigth.TabIndex = 0;
            this.fld_txtHeigth.Tag = "DC";
            // 
            // fld_txtProductName
            // 
            this.fld_txtProductName.BOSComment = null;
            this.fld_txtProductName.BOSDataMember = "";
            this.fld_txtProductName.BOSDataSource = "";
            this.fld_txtProductName.BOSDescription = null;
            this.fld_txtProductName.BOSError = null;
            this.fld_txtProductName.BOSFieldGroup = null;
            this.fld_txtProductName.BOSFieldRelation = null;
            this.fld_txtProductName.BOSPrivilege = null;
            this.fld_txtProductName.BOSPropertyName = "EditValue";
            this.fld_txtProductName.Location = new System.Drawing.Point(310, 17);
            this.fld_txtProductName.Name = "fld_txtProductName";
            this.fld_txtProductName.Properties.ReadOnly = true;
            this.fld_txtProductName.Screen = null;
            this.fld_txtProductName.Size = new System.Drawing.Size(152, 20);
            this.fld_txtProductName.TabIndex = 0;
            this.fld_txtProductName.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(244, 46);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 4;
            this.bosLabel2.Text = "Rộng (mm)";
            // 
            // fld_txtProductNo
            // 
            this.fld_txtProductNo.BOSComment = null;
            this.fld_txtProductNo.BOSDataMember = "";
            this.fld_txtProductNo.BOSDataSource = "";
            this.fld_txtProductNo.BOSDescription = null;
            this.fld_txtProductNo.BOSError = null;
            this.fld_txtProductNo.BOSFieldGroup = null;
            this.fld_txtProductNo.BOSFieldRelation = null;
            this.fld_txtProductNo.BOSPrivilege = null;
            this.fld_txtProductNo.BOSPropertyName = "EditValue";
            this.fld_txtProductNo.Location = new System.Drawing.Point(66, 17);
            this.fld_txtProductNo.MenuManager = this.screenToolbar;
            this.fld_txtProductNo.Name = "fld_txtProductNo";
            this.fld_txtProductNo.Properties.ReadOnly = true;
            this.fld_txtProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtProductNo, true);
            this.fld_txtProductNo.Size = new System.Drawing.Size(152, 20);
            this.fld_txtProductNo.TabIndex = 0;
            this.fld_txtProductNo.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(244, 20);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(39, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Tên BTP";
            // 
            // guiAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(988, 589);
            this.ControlBox = true;
            this.Controls.Add(this.fld_blnInfo);
            this.Controls.Add(this.fld_dgcProductsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAlternative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm có thể thay";
            this.Load += new System.EventHandler(this.guiAlternative_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcProductsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_blnInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductsGridControl)).EndInit();
            this.fld_blnInfo.ResumeLayout(false);
            this.fld_blnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHeigth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSERP.Modules.BatchProductShedule.ICAlternativeMaterialsGridControl fld_dgcProductsGridControl;
        private BOSComponent.BOSLine fld_blnInfo;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtLength;
        private BOSComponent.BOSTextBox fld_txtWidth;
        private BOSComponent.BOSTextBox fld_txtQty;
        private BOSComponent.BOSTextBox fld_txtHeigth;
        private BOSComponent.BOSTextBox fld_txtProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtProductNo;
        private BOSComponent.BOSLabel bosLabel7;
    }
}