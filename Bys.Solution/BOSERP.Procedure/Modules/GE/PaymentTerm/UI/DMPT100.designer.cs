using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentTerm.UI
{
	/// <summary>
	/// Summary description for DMPT100
	/// </summary>
	partial class DMPT100
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.fld_txtGEPaymentTermName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtGEPaymentTermNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lbPaymentTermNo = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermName = new BOSComponent.BOSLabel(this.components);
            this.fld_chkGEPaymentTermActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcPaymentTermItem = new BOSERP.Modules.PaymentTerm.GEPaymentTermItemGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkGEPaymentTermActiveCheck.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPaymentTermItem)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtGEPaymentTermName
            // 
            this.fld_txtGEPaymentTermName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermName.BOSDataMember = "GEPaymentTermName";
            this.fld_txtGEPaymentTermName.BOSDataSource = "GEPaymentTerms";
            this.fld_txtGEPaymentTermName.BOSDescription = null;
            this.fld_txtGEPaymentTermName.BOSError = null;
            this.fld_txtGEPaymentTermName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermName.BOSPropertyName = "Text";
            this.fld_txtGEPaymentTermName.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermName.Location = new System.Drawing.Point(69, 42);
            this.fld_txtGEPaymentTermName.Name = "fld_txtGEPaymentTermName";
            this.fld_txtGEPaymentTermName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEPaymentTermName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEPaymentTermName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEPaymentTermName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEPaymentTermName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEPaymentTermName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEPaymentTermName.Screen = null;
            this.fld_txtGEPaymentTermName.Size = new System.Drawing.Size(382, 20);
            this.fld_txtGEPaymentTermName.TabIndex = 1;
            this.fld_txtGEPaymentTermName.Tag = "DC";
            // 
            // fld_txtGEPaymentTermNo
            // 
            this.fld_txtGEPaymentTermNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermNo.BOSDataMember = "GEPaymentTermNo";
            this.fld_txtGEPaymentTermNo.BOSDataSource = "GEPaymentTerms";
            this.fld_txtGEPaymentTermNo.BOSDescription = null;
            this.fld_txtGEPaymentTermNo.BOSError = null;
            this.fld_txtGEPaymentTermNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermNo.BOSPropertyName = "Text";
            this.fld_txtGEPaymentTermNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEPaymentTermNo.Location = new System.Drawing.Point(69, 16);
            this.fld_txtGEPaymentTermNo.Name = "fld_txtGEPaymentTermNo";
            this.fld_txtGEPaymentTermNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEPaymentTermNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEPaymentTermNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEPaymentTermNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEPaymentTermNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEPaymentTermNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEPaymentTermNo.Screen = null;
            this.fld_txtGEPaymentTermNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtGEPaymentTermNo.TabIndex = 0;
            this.fld_txtGEPaymentTermNo.Tag = "DC";
            // 
            // fld_lbPaymentTermNo
            // 
            this.fld_lbPaymentTermNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermNo.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSDescription = null;
            this.fld_lbPaymentTermNo.BOSError = null;
            this.fld_lbPaymentTermNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.Location = new System.Drawing.Point(14, 19);
            this.fld_lbPaymentTermNo.Name = "fld_lbPaymentTermNo";
            this.fld_lbPaymentTermNo.Screen = null;
            this.fld_lbPaymentTermNo.Size = new System.Drawing.Size(43, 13);
            this.fld_lbPaymentTermNo.TabIndex = 29;
            this.fld_lbPaymentTermNo.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermNo.Text = "Mã ĐKTT";
            // 
            // fld_lbPaymentTermName
            // 
            this.fld_lbPaymentTermName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTermName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbPaymentTermName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermName.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseFont = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSDescription = null;
            this.fld_lbPaymentTermName.BOSError = null;
            this.fld_lbPaymentTermName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.Location = new System.Drawing.Point(14, 45);
            this.fld_lbPaymentTermName.Name = "fld_lbPaymentTermName";
            this.fld_lbPaymentTermName.Screen = null;
            this.fld_lbPaymentTermName.Size = new System.Drawing.Size(51, 13);
            this.fld_lbPaymentTermName.TabIndex = 25;
            this.fld_lbPaymentTermName.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lbPaymentTermName.Text = "Tên ĐKTT";
            // 
            // fld_chkGEPaymentTermActiveCheck
            // 
            this.fld_chkGEPaymentTermActiveCheck.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_chkGEPaymentTermActiveCheck.BOSDataMember = "GEPaymentTermActiveCheck";
            this.fld_chkGEPaymentTermActiveCheck.BOSDataSource = "GEPaymentTerms";
            this.fld_chkGEPaymentTermActiveCheck.BOSDescription = null;
            this.fld_chkGEPaymentTermActiveCheck.BOSError = null;
            this.fld_chkGEPaymentTermActiveCheck.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_chkGEPaymentTermActiveCheck.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_chkGEPaymentTermActiveCheck.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_chkGEPaymentTermActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkGEPaymentTermActiveCheck.Location = new System.Drawing.Point(67, 68);
            this.fld_chkGEPaymentTermActiveCheck.Name = "fld_chkGEPaymentTermActiveCheck";
            this.fld_chkGEPaymentTermActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkGEPaymentTermActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkGEPaymentTermActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkGEPaymentTermActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkGEPaymentTermActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkGEPaymentTermActiveCheck.Screen = null;
            this.fld_chkGEPaymentTermActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkGEPaymentTermActiveCheck.TabIndex = 4;
            this.fld_chkGEPaymentTermActiveCheck.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_txtGEPaymentTermNo);
            this.bosPanel1.Controls.Add(this.fld_txtGEPaymentTermName);
            this.bosPanel1.Controls.Add(this.fld_chkGEPaymentTermActiveCheck);
            this.bosPanel1.Controls.Add(this.fld_lbPaymentTermName);
            this.bosPanel1.Controls.Add(this.fld_lbPaymentTermNo);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(621, 446);
            this.bosPanel1.TabIndex = 534;
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(0, 93);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(621, 350);
            this.fld_tabReceiptItems.TabIndex = 10;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_dgcPaymentTermItem);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(614, 321);
            this.fld_tabPageReceiptItems.Text = "Cấu hình điều khoản thanh toán";
            // 
            // fld_dgcPaymentTermItem
            // 
            this.fld_dgcPaymentTermItem.BOSComment = null;
            this.fld_dgcPaymentTermItem.BOSDataMember = null;
            this.fld_dgcPaymentTermItem.BOSDataSource = "GEPaymentTermItems";
            this.fld_dgcPaymentTermItem.BOSDescription = null;
            this.fld_dgcPaymentTermItem.BOSError = null;
            this.fld_dgcPaymentTermItem.BOSFieldGroup = null;
            this.fld_dgcPaymentTermItem.BOSFieldRelation = null;
            this.fld_dgcPaymentTermItem.BOSGridType = null;
            this.fld_dgcPaymentTermItem.BOSPrivilege = null;
            this.fld_dgcPaymentTermItem.BOSPropertyName = null;
            this.fld_dgcPaymentTermItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcPaymentTermItem.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcPaymentTermItem.MenuManager = this.screenToolbar;
            this.fld_dgcPaymentTermItem.Name = "fld_dgcPaymentTermItem";
            this.fld_dgcPaymentTermItem.PrintReport = false;
            this.fld_dgcPaymentTermItem.Screen = null;
            this.fld_dgcPaymentTermItem.Size = new System.Drawing.Size(614, 321);
            this.fld_dgcPaymentTermItem.TabIndex = 1;
            // 
            // DMPT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(621, 446);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPT100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEPaymentTermNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkGEPaymentTermActiveCheck.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPaymentTermItem)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtGEPaymentTermName;
        private BOSComponent.BOSTextBox fld_txtGEPaymentTermNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermName;
        private BOSComponent.BOSCheckEdit fld_chkGEPaymentTermActiveCheck;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private BOSERP.Modules.PaymentTerm.GEPaymentTermItemGridControl fld_dgcPaymentTermItem;
	}
}
