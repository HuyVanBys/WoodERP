using BOSComponent;
namespace BOSERP.Modules.Report
{
    partial class RPTHNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPTHNS));
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_dteToMonth = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromMonth = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARNormFeeConfigItems = new BOSComponent.BOSGridControl(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(532, 15);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(78, 28);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosButton2);
            this.bosPanel1.Controls.Add(this.fld_dteToMonth);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteFromMonth);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1237, 679);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(700, 15);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(78, 28);
            this.bosButton2.TabIndex = 406;
            this.bosButton2.Text = "In";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // fld_dteToMonth
            // 
            this.fld_dteToMonth.BOSComment = null;
            this.fld_dteToMonth.BOSDataMember = null;
            this.fld_dteToMonth.BOSDataSource = null;
            this.fld_dteToMonth.BOSDescription = null;
            this.fld_dteToMonth.BOSError = null;
            this.fld_dteToMonth.BOSFieldGroup = null;
            this.fld_dteToMonth.BOSFieldRelation = null;
            this.fld_dteToMonth.BOSPrivilege = null;
            this.fld_dteToMonth.BOSPropertyName = null;
            this.fld_dteToMonth.EditValue = null;
            this.fld_dteToMonth.Location = new System.Drawing.Point(367, 19);
            this.fld_dteToMonth.MenuManager = this.screenToolbar;
            this.fld_dteToMonth.Name = "fld_dteToMonth";
            this.fld_dteToMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteToMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteToMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteToMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToMonth.Screen = null;
            this.fld_dteToMonth.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToMonth.TabIndex = 1;
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
            this.bosLabel2.Location = new System.Drawing.Point(282, 22);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 392;
            this.bosLabel2.Text = "Đến tháng";
            // 
            // fld_dteFromMonth
            // 
            this.fld_dteFromMonth.BOSComment = null;
            this.fld_dteFromMonth.BOSDataMember = null;
            this.fld_dteFromMonth.BOSDataSource = null;
            this.fld_dteFromMonth.BOSDescription = null;
            this.fld_dteFromMonth.BOSError = null;
            this.fld_dteFromMonth.BOSFieldGroup = null;
            this.fld_dteFromMonth.BOSFieldRelation = null;
            this.fld_dteFromMonth.BOSPrivilege = null;
            this.fld_dteFromMonth.BOSPropertyName = null;
            this.fld_dteFromMonth.EditValue = null;
            this.fld_dteFromMonth.Location = new System.Drawing.Point(92, 19);
            this.fld_dteFromMonth.MenuManager = this.screenToolbar;
            this.fld_dteFromMonth.Name = "fld_dteFromMonth";
            this.fld_dteFromMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteFromMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteFromMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteFromMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromMonth.Screen = null;
            this.fld_dteFromMonth.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromMonth.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 22);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(44, 13);
            this.bosLabel1.TabIndex = 390;
            this.bosLabel1.Text = "Từ tháng";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(616, 15);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(78, 28);
            this.bosButton1.TabIndex = 8;
            this.bosButton1.Text = "Xuất excel";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click_1);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_dgcARNormFeeConfigItems);
            this.bosLine1.Location = new System.Drawing.Point(3, 49);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1231, 630);
            this.bosLine1.TabIndex = 377;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Chi tiết    ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(49, 17);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(383, 27);
            this.bosLabel3.TabIndex = 35;
            this.bosLabel3.Text = "BÁO CÁO THỰC HIỆN NGÂN SÁCH";
            // 
            // fld_dgcARNormFeeConfigItems
            // 
            this.fld_dgcARNormFeeConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARNormFeeConfigItems.BOSComment = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataMember = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataSource = "APInvoiceIns";
            this.fld_dgcARNormFeeConfigItems.BOSDescription = null;
            this.fld_dgcARNormFeeConfigItems.BOSError = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldGroup = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldRelation = null;
            this.fld_dgcARNormFeeConfigItems.BOSGridType = null;
            this.fld_dgcARNormFeeConfigItems.BOSPrivilege = null;
            this.fld_dgcARNormFeeConfigItems.BOSPropertyName = null;
            this.fld_dgcARNormFeeConfigItems.Location = new System.Drawing.Point(0, 50);
            this.fld_dgcARNormFeeConfigItems.MenuManager = this.screenToolbar;
            this.fld_dgcARNormFeeConfigItems.Name = "fld_dgcARNormFeeConfigItems";
            this.fld_dgcARNormFeeConfigItems.PrintReport = false;
            this.fld_dgcARNormFeeConfigItems.Screen = null;
            this.fld_dgcARNormFeeConfigItems.Size = new System.Drawing.Size(1228, 577);
            this.fld_dgcARNormFeeConfigItems.TabIndex = 16;
            // 
            // RPTHNS
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 679);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPTHNS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "BÁO CÁO THỰC HIỆN NGÂN SÁCH";
            this.Load += new System.EventHandler(this.RPTHNS_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnApply;
        private BOSPanel bosPanel1;
        private BOSLine bosLine1;
        private BOSGridControl fld_dgcARNormFeeConfigItems;
        private BOSLabel bosLabel3;
        private BOSButton bosButton1;
        private BOSDateEdit fld_dteToMonth;
        private BOSLabel bosLabel2;
        private BOSDateEdit fld_dteFromMonth;
        private BOSLabel bosLabel1;
        private BOSButton bosButton2;
    }
}