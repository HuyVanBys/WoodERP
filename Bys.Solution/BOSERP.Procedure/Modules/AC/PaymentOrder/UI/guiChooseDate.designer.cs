namespace BOSERP.Modules.PaymentOrder
{
    partial class guiChooseDate
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
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
            this.bosLabel1.Size = new System.Drawing.Size(30, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Tháng";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.Location = new System.Drawing.Point(69, 57);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Tag = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(167, 57);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dteICShipmentDate
            // 
            this.fld_dteICShipmentDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSDescription = null;
            this.fld_dteICShipmentDate.BOSError = null;
            this.fld_dteICShipmentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDate.EditValue = null;
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(69, 19);
            this.fld_dteICShipmentDate.Name = "fld_dteICShipmentDate";
            this.fld_dteICShipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteICShipmentDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICShipmentDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteICShipmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate.Screen = null;
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(173, 20);
            this.fld_dteICShipmentDate.TabIndex = 1;
            this.fld_dteICShipmentDate.Tag = "DC";
            // 
            // guiChooseDate
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dteICShipmentDate);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.bosLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiChooseDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn tháng cần thanh toán";
            this.Load += new System.EventHandler(this.guiChooseDate_Load);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dteICShipmentDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
    }
}