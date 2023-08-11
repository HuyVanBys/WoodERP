using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CalculatorProductionNormCost.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class SMCPNC100
	{
		private BOSComponent.BOSTextBox fld_txtACAssetReceiptNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSDateEdit fld_dteSearchFromACAssetReceiptDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToACAssetReceiptDate1;


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
            this.fld_txtACAssetReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromACAssetReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToACAssetReceiptDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcMMCalculatorProductionNormCosts = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACAssetReceiptNo
            // 
            this.fld_txtACAssetReceiptNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtACAssetReceiptNo.BOSDataMember = "MMCalculatorProductionNormCostNo";
            this.fld_txtACAssetReceiptNo.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_txtACAssetReceiptNo.BOSDescription = null;
            this.fld_txtACAssetReceiptNo.BOSError = null;
            this.fld_txtACAssetReceiptNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtACAssetReceiptNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtACAssetReceiptNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtACAssetReceiptNo.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtACAssetReceiptNo.Location = new System.Drawing.Point(135, 131);
            this.fld_txtACAssetReceiptNo.Name = "fld_txtACAssetReceiptNo";
            this.fld_txtACAssetReceiptNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptNo.Screen = null;
            this.fld_txtACAssetReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetReceiptNo.TabIndex = 0;
            this.fld_txtACAssetReceiptNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 134);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(37, 160);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(309, 160);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel4.TabIndex = 9;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Đến";
            // 
            // fld_dteSearchFromACAssetReceiptDate
            // 
            this.fld_dteSearchFromACAssetReceiptDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromACAssetReceiptDate.BOSDataMember = "MMCalculatorProductionNormCostDateFrom";
            this.fld_dteSearchFromACAssetReceiptDate.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_dteSearchFromACAssetReceiptDate.BOSDescription = null;
            this.fld_dteSearchFromACAssetReceiptDate.BOSError = null;
            this.fld_dteSearchFromACAssetReceiptDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromACAssetReceiptDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromACAssetReceiptDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromACAssetReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromACAssetReceiptDate.EditValue = null;
            this.fld_dteSearchFromACAssetReceiptDate.Location = new System.Drawing.Point(135, 157);
            this.fld_dteSearchFromACAssetReceiptDate.Name = "fld_dteSearchFromACAssetReceiptDate";
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromACAssetReceiptDate.Screen = null;
            this.fld_dteSearchFromACAssetReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromACAssetReceiptDate.TabIndex = 5;
            this.fld_dteSearchFromACAssetReceiptDate.Tag = "SC";
            // 
            // fld_dteSearchToACAssetReceiptDate1
            // 
            this.fld_dteSearchToACAssetReceiptDate1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToACAssetReceiptDate1.BOSDataMember = "MMCalculatorProductionNormCostDateTo";
            this.fld_dteSearchToACAssetReceiptDate1.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_dteSearchToACAssetReceiptDate1.BOSDescription = null;
            this.fld_dteSearchToACAssetReceiptDate1.BOSError = null;
            this.fld_dteSearchToACAssetReceiptDate1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToACAssetReceiptDate1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToACAssetReceiptDate1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToACAssetReceiptDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchToACAssetReceiptDate1.EditValue = null;
            this.fld_dteSearchToACAssetReceiptDate1.Location = new System.Drawing.Point(348, 157);
            this.fld_dteSearchToACAssetReceiptDate1.Name = "fld_dteSearchToACAssetReceiptDate1";
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToACAssetReceiptDate1.Screen = null;
            this.fld_dteSearchToACAssetReceiptDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToACAssetReceiptDate1.TabIndex = 6;
            this.fld_dteSearchToACAssetReceiptDate1.Tag = "SC";
            // 
            // fld_dgcMMCalculatorProductionNormCosts
            // 
            this.fld_dgcMMCalculatorProductionNormCosts.BOSComment = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSDataMember = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_dgcMMCalculatorProductionNormCosts.BOSDescription = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSError = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSFieldGroup = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSFieldRelation = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSPrivilege = null;
            this.fld_dgcMMCalculatorProductionNormCosts.BOSPropertyName = null;
            this.fld_dgcMMCalculatorProductionNormCosts.Location = new System.Drawing.Point(53, 200);
            this.fld_dgcMMCalculatorProductionNormCosts.MenuManager = this.screenToolbar;
            this.fld_dgcMMCalculatorProductionNormCosts.Name = "fld_dgcMMCalculatorProductionNormCosts";
            this.fld_dgcMMCalculatorProductionNormCosts.Screen = null;
            this.fld_dgcMMCalculatorProductionNormCosts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMCalculatorProductionNormCosts.TabIndex = 10;
            this.fld_dgcMMCalculatorProductionNormCosts.Tag = "SR";
            // 
            // SMAR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcMMCalculatorProductionNormCosts);
            this.Controls.Add(this.fld_txtACAssetReceiptNo);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchFromACAssetReceiptDate);
            this.Controls.Add(this.fld_dteSearchToACAssetReceiptDate1);
            this.Name = "SMAR100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToACAssetReceiptDate1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromACAssetReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_txtACAssetReceiptNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMCalculatorProductionNormCosts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormCosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMCalculatorProductionNormCosts;
	}
}
