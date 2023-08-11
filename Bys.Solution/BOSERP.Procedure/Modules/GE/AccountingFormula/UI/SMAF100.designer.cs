using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AccountingFormula.UI
{
	/// <summary>
	/// Summary description for SMCL100
	/// </summary>
	partial class SMAF100
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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARSaleOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteGEAccountingFormulaDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtGEAccountingFormulaNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEAccountingFormulaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(9, 15);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 94;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(9, 67);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel14.TabIndex = 100;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ";
            // 
            // fld_dgcARSaleOrder
            // 
            this.fld_dgcARSaleOrder.AllowDrop = true;
            this.fld_dgcARSaleOrder.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARSaleOrder.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARSaleOrder.BOSDataSource = "GEAccountingFormulas";
            this.fld_dgcARSaleOrder.BOSDescription = null;
            this.fld_dgcARSaleOrder.BOSError = null;
            this.fld_dgcARSaleOrder.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARSaleOrder.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARSaleOrder.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARSaleOrder.BOSPropertyName = null;
            this.fld_dgcARSaleOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrder.Location = new System.Drawing.Point(9, 101);
            this.fld_dgcARSaleOrder.MainView = this.fld_dgvGridControl;
            this.fld_dgcARSaleOrder.Name = "fld_dgcARSaleOrder";
            this.fld_dgcARSaleOrder.Screen = null;
            this.fld_dgcARSaleOrder.Size = new System.Drawing.Size(417, 254);
            this.fld_dgcARSaleOrder.TabIndex = 101;
            this.fld_dgcARSaleOrder.Tag = "SR";
            this.fld_dgcARSaleOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARSaleOrder;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteGEAccountingFormulaDate
            // 
            this.fld_dteGEAccountingFormulaDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteGEAccountingFormulaDate.BOSDataMember = "GEAccountingFormulaDate";
            this.fld_dteGEAccountingFormulaDate.BOSDataSource = "GEAccountingFormulas";
            this.fld_dteGEAccountingFormulaDate.BOSDescription = null;
            this.fld_dteGEAccountingFormulaDate.BOSError = null;
            this.fld_dteGEAccountingFormulaDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteGEAccountingFormulaDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteGEAccountingFormulaDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteGEAccountingFormulaDate.BOSPropertyName = "EditValue";
            this.fld_dteGEAccountingFormulaDate.EditValue = null;
            this.fld_dteGEAccountingFormulaDate.Location = new System.Drawing.Point(124, 64);
            this.fld_dteGEAccountingFormulaDate.Name = "fld_dteGEAccountingFormulaDate";
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteGEAccountingFormulaDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteGEAccountingFormulaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteGEAccountingFormulaDate.Screen = null;
            this.fld_dteGEAccountingFormulaDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteGEAccountingFormulaDate.TabIndex = 95;
            this.fld_dteGEAccountingFormulaDate.Tag = "SC";
            // 
            // fld_txtGEAccountingFormulaNo
            // 
            this.fld_txtGEAccountingFormulaNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEAccountingFormulaNo.BOSDataMember = "GEAccountingFormulaNo";
            this.fld_txtGEAccountingFormulaNo.BOSDataSource = "GEAccountingFormulas";
            this.fld_txtGEAccountingFormulaNo.BOSDescription = null;
            this.fld_txtGEAccountingFormulaNo.BOSError = null;
            this.fld_txtGEAccountingFormulaNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEAccountingFormulaNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEAccountingFormulaNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEAccountingFormulaNo.BOSPropertyName = "EditValue";
            this.fld_txtGEAccountingFormulaNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtGEAccountingFormulaNo.Location = new System.Drawing.Point(124, 12);
            this.fld_txtGEAccountingFormulaNo.Name = "fld_txtGEAccountingFormulaNo";
            this.fld_txtGEAccountingFormulaNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEAccountingFormulaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEAccountingFormulaNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEAccountingFormulaNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEAccountingFormulaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEAccountingFormulaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEAccountingFormulaNo.Screen = null;
            this.fld_txtGEAccountingFormulaNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtGEAccountingFormulaNo.TabIndex = 89;
            this.fld_txtGEAccountingFormulaNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(9, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 103;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSDataMember = "GEAccountingFormulaName";
            this.bosTextBox1.BOSDataSource = "GEAccountingFormulas";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.Location = new System.Drawing.Point(124, 38);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 102;
            this.bosTextBox1.Tag = "SC";
            // 
            // SMAF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(517, 411);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dgcARSaleOrder);
            this.Controls.Add(this.fld_dteGEAccountingFormulaDate);
            this.Controls.Add(this.fld_txtGEAccountingFormulaNo);
            this.Name = "SMAF100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtGEAccountingFormulaNo, 0);
            this.Controls.SetChildIndex(this.fld_dteGEAccountingFormulaDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrder, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteGEAccountingFormulaDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEAccountingFormulaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSSearchResultsGridControl fld_dgcARSaleOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteGEAccountingFormulaDate;
        private BOSComponent.BOSTextBox fld_txtGEAccountingFormulaNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox1;
	}
}
