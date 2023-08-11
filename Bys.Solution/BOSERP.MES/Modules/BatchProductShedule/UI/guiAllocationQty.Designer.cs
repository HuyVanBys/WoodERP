namespace BOSERP.Modules.BatchProductShedule
{
    partial class guiAllocationQty
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeQty = new DevExpress.XtraEditors.TextEdit();
            this.fld_rdeType1 = new System.Windows.Forms.RadioButton();
            this.fld_rdeType2 = new System.Windows.Forms.RadioButton();
            this.fld_cbeRoundNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbeRoundNumber.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(204, 101);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnApply.Location = new System.Drawing.Point(115, 101);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "SL phẩn bổ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tiêu chí phân bổ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Làm tròn";
            // 
            // fld_lkeQty
            // 
            this.fld_lkeQty.Location = new System.Drawing.Point(109, 14);
            this.fld_lkeQty.MenuManager = this.screenToolbar;
            this.fld_lkeQty.Name = "fld_lkeQty";
            this.fld_lkeQty.Properties.DisplayFormat.FormatString = "n6";
            this.fld_lkeQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeQty.Properties.EditFormat.FormatString = "n6";
            this.fld_lkeQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeQty.Properties.Mask.EditMask = "n6";
            this.fld_lkeQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_lkeQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_lkeQty.Properties.NullText = "0";
            this.fld_lkeQty.Properties.NullValuePrompt = "0";
            this.fld_lkeQty.Properties.NullValuePromptShowForEmptyValue = true;
            this.fld_lkeQty.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeQty.TabIndex = 8;
            // 
            // fld_rdeType1
            // 
            this.fld_rdeType1.AutoSize = true;
            this.fld_rdeType1.Location = new System.Drawing.Point(111, 40);
            this.fld_rdeType1.Name = "fld_rdeType1";
            this.fld_rdeType1.Size = new System.Drawing.Size(87, 17);
            this.fld_rdeType1.TabIndex = 10;
            this.fld_rdeType1.TabStop = true;
            this.fld_rdeType1.Text = "Theo tỉ trọng";
            this.fld_rdeType1.UseVisualStyleBackColor = true;
            // 
            // fld_rdeType2
            // 
            this.fld_rdeType2.AutoSize = true;
            this.fld_rdeType2.Location = new System.Drawing.Point(203, 40);
            this.fld_rdeType2.Name = "fld_rdeType2";
            this.fld_rdeType2.Size = new System.Drawing.Size(83, 17);
            this.fld_rdeType2.TabIndex = 11;
            this.fld_rdeType2.TabStop = true;
            this.fld_rdeType2.Text = "Theo thứ tự";
            this.fld_rdeType2.UseVisualStyleBackColor = true;
            this.fld_rdeType2.CheckedChanged += new System.EventHandler(this.fld_rdeType2_CheckedChanged);
            // 
            // fld_cbeRoundNumber
            // 
            this.fld_cbeRoundNumber.Location = new System.Drawing.Point(109, 63);
            this.fld_cbeRoundNumber.MenuManager = this.screenToolbar;
            this.fld_cbeRoundNumber.Name = "fld_cbeRoundNumber";
            this.fld_cbeRoundNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbeRoundNumber.Properties.Items.AddRange(new object[] {
            "0 chữ số thập phân",
            "1 chữ số thập phân",
            "2 chữ số thập phân",
            "3 chữ số thập phân",
            "4 chữ số thập phân",
            "5 chữ số thập phân",
            "6 chữ số thập phân"});
            this.fld_cbeRoundNumber.Size = new System.Drawing.Size(171, 20);
            this.fld_cbeRoundNumber.TabIndex = 12;
            // 
            // guiAllocationQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(304, 133);
            this.ControlBox = true;
            this.Controls.Add(this.fld_cbeRoundNumber);
            this.Controls.Add(this.fld_rdeType2);
            this.Controls.Add(this.fld_rdeType1);
            this.Controls.Add(this.fld_lkeQty);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAllocationQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân bổ SL kế hoạch";
            this.Load += new System.EventHandler(this.guiAllocationQty_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.fld_lkeQty, 0);
            this.Controls.SetChildIndex(this.fld_rdeType1, 0);
            this.Controls.SetChildIndex(this.fld_rdeType2, 0);
            this.Controls.SetChildIndex(this.fld_cbeRoundNumber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbeRoundNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit fld_lkeQty;
        private System.Windows.Forms.RadioButton fld_rdeType1;
        private System.Windows.Forms.RadioButton fld_rdeType2;
        private DevExpress.XtraEditors.ComboBoxEdit fld_cbeRoundNumber;
    }
}