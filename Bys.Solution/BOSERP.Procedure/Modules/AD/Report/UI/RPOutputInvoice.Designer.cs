namespace BOSERP.Modules.Report
{
    partial class RPOutputInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPOutputInvoice));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosPanel3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(543, 135);
            this.panelControl1.TabIndex = 0;
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosLabel3);
            this.bosPanel3.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.bosPanel3.Controls.Add(this.BOSLabel1);
            this.bosPanel3.Controls.Add(this.BOSLabel2);
            this.bosPanel3.Controls.Add(this.fld_btnApply);
            this.bosPanel3.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel3.Location = new System.Drawing.Point(2, 2);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(539, 131);
            this.bosPanel3.TabIndex = 19;
            // 
            // fld_dteSearchFromARInvoiceDate
            // 
            this.fld_dteSearchFromARInvoiceDate.BOSComment = null;
            this.fld_dteSearchFromARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchFromARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchFromARInvoiceDate.BOSError = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchFromARInvoiceDate.EditValue = null;
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(114, 51);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 0;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(50, 54);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 8;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(299, 54);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(47, 13);
            this.BOSLabel2.TabIndex = 10;
            this.BOSLabel2.Text = "Đến ngày";
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
            this.fld_btnApply.Location = new System.Drawing.Point(429, 86);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 2;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dteSearchToARInvoiceDate
            // 
            this.fld_dteSearchToARInvoiceDate.BOSComment = null;
            this.fld_dteSearchToARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchToARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchToARInvoiceDate.BOSError = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchToARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchToARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchToARInvoiceDate.EditValue = null;
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(368, 51);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 1;
            this.fld_dteSearchToARInvoiceDate.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.bosLabel3.Location = new System.Drawing.Point(25, 23);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(73, 16);
            this.bosLabel3.TabIndex = 12;
            this.bosLabel3.Text = "Chọn ngày:";
            // 
            // RPOutputInvoice
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 135);
            this.ControlBox = true;
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPOutputInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách hóa đơn, chứng từ hàng hóa, dịch vụ bán ra";
            this.Load += new System.EventHandler(this.RPOutputInvoice_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSLabel bosLabel3;      
    }
}