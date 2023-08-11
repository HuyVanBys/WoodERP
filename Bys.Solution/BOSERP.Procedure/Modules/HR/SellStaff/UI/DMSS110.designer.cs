using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMSS101
	/// </summary>
    partial class DMSS110
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSS110));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dteHRQuarterRewardEffectiveDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRQuarterRewardAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnDeleteContactPerson = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddContactPerson = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl8 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRQuarterRewards = new BOSERP.Modules.SellStaff.HRQuarterRewardsGridControl();
            this.fld_dgvHRQuarterRewards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRQuarterRewardEffectiveDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRQuarterRewardEffectiveDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRQuarterRewardAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl8)).BeginInit();
            this.fld_grcGroupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRQuarterRewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRQuarterRewards)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteContactPerson);
            this.bosPanel1.Controls.Add(this.fld_btnAddContactPerson);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl8);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dteHRQuarterRewardEffectiveDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRQuarterRewardAmount);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel35);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel49);
            resources.ApplyResources(this.bosGroupControl1, "bosGroupControl1");
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, ((bool)(resources.GetObject("bosGroupControl1.ShowHelp"))));
            // 
            // fld_dteHRQuarterRewardEffectiveDate
            // 
            this.fld_dteHRQuarterRewardEffectiveDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSDataMember = "HRQuarterRewardEffectiveDate";
            this.fld_dteHRQuarterRewardEffectiveDate.BOSDataSource = "HRQuarterRewards";
            this.fld_dteHRQuarterRewardEffectiveDate.BOSDescription = null;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSError = null;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRQuarterRewardEffectiveDate.BOSPropertyName = "EditValue";
            this.fld_dteHRQuarterRewardEffectiveDate.EditValue = null;
            resources.ApplyResources(this.fld_dteHRQuarterRewardEffectiveDate, "fld_dteHRQuarterRewardEffectiveDate");
            this.fld_dteHRQuarterRewardEffectiveDate.Name = "fld_dteHRQuarterRewardEffectiveDate";
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRQuarterRewardEffectiveDate.Properties.Buttons"))))});
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.Mask.EditMask = resources.GetString("fld_dteHRQuarterRewardEffectiveDate.Properties.Mask.EditMask");
            this.fld_dteHRQuarterRewardEffectiveDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRQuarterRewardEffectiveDate.Screen = null;
            this.fld_dteHRQuarterRewardEffectiveDate.Tag = "DC";
            // 
            // fld_txtHRQuarterRewardAmount
            // 
            this.fld_txtHRQuarterRewardAmount.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRQuarterRewardAmount.BOSDataMember = "HRQuarterRewardAmount";
            this.fld_txtHRQuarterRewardAmount.BOSDataSource = "HRQuarterRewards";
            this.fld_txtHRQuarterRewardAmount.BOSDescription = null;
            this.fld_txtHRQuarterRewardAmount.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRQuarterRewardAmount.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRQuarterRewardAmount.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRQuarterRewardAmount.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRQuarterRewardAmount.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRQuarterRewardAmount, "fld_txtHRQuarterRewardAmount");
            this.fld_txtHRQuarterRewardAmount.Name = "fld_txtHRQuarterRewardAmount";
            this.fld_txtHRQuarterRewardAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRQuarterRewardAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRQuarterRewardAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRQuarterRewardAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRQuarterRewardAmount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRQuarterRewardAmount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRQuarterRewardAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRQuarterRewardAmount, ((bool)(resources.GetObject("fld_txtHRQuarterRewardAmount.ShowHelp"))));
            this.fld_txtHRQuarterRewardAmount.Tag = "DC";
            // 
            // fld_lblLabel35
            // 
            this.fld_lblLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel35.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel35.Appearance.Options.UseFont = true;
            this.fld_lblLabel35.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel35.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel35.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel35, "fld_lblLabel35");
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel35, ((bool)(resources.GetObject("fld_lblLabel35.ShowHelp"))));
            this.fld_lblLabel35.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // fld_lblLabel49
            // 
            this.fld_lblLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel49.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel49.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel49.Appearance.Options.UseFont = true;
            this.fld_lblLabel49.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel49.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel49.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel49, "fld_lblLabel49");
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel49, ((bool)(resources.GetObject("fld_lblLabel49.ShowHelp"))));
            this.fld_lblLabel49.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // fld_btnDeleteContactPerson
            // 
            resources.ApplyResources(this.fld_btnDeleteContactPerson, "fld_btnDeleteContactPerson");
            this.fld_btnDeleteContactPerson.BOSComment = null;
            this.fld_btnDeleteContactPerson.BOSDataMember = null;
            this.fld_btnDeleteContactPerson.BOSDataSource = null;
            this.fld_btnDeleteContactPerson.BOSDescription = null;
            this.fld_btnDeleteContactPerson.BOSError = null;
            this.fld_btnDeleteContactPerson.BOSFieldGroup = null;
            this.fld_btnDeleteContactPerson.BOSFieldRelation = null;
            this.fld_btnDeleteContactPerson.BOSPrivilege = null;
            this.fld_btnDeleteContactPerson.BOSPropertyName = null;
            this.fld_btnDeleteContactPerson.Name = "fld_btnDeleteContactPerson";
            this.fld_btnDeleteContactPerson.Screen = null;
            this.fld_btnDeleteContactPerson.Click += new System.EventHandler(this.fld_btnDeletePersonReward_Click);
            // 
            // fld_btnAddContactPerson
            // 
            resources.ApplyResources(this.fld_btnAddContactPerson, "fld_btnAddContactPerson");
            this.fld_btnAddContactPerson.BOSComment = null;
            this.fld_btnAddContactPerson.BOSDataMember = null;
            this.fld_btnAddContactPerson.BOSDataSource = null;
            this.fld_btnAddContactPerson.BOSDescription = null;
            this.fld_btnAddContactPerson.BOSError = null;
            this.fld_btnAddContactPerson.BOSFieldGroup = null;
            this.fld_btnAddContactPerson.BOSFieldRelation = null;
            this.fld_btnAddContactPerson.BOSPrivilege = null;
            this.fld_btnAddContactPerson.BOSPropertyName = null;
            this.fld_btnAddContactPerson.Name = "fld_btnAddContactPerson";
            this.fld_btnAddContactPerson.Screen = null;
            this.fld_btnAddContactPerson.Click += new System.EventHandler(this.fld_btnAddPersonReward_Click);
            // 
            // fld_grcGroupControl8
            // 
            resources.ApplyResources(this.fld_grcGroupControl8, "fld_grcGroupControl8");
            this.fld_grcGroupControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl8.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl8.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl8.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSDescription = null;
            this.fld_grcGroupControl8.BOSError = null;
            this.fld_grcGroupControl8.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl8.Controls.Add(this.fld_dgcHRQuarterRewards);
            this.fld_grcGroupControl8.Name = "fld_grcGroupControl8";
            this.fld_grcGroupControl8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl8, ((bool)(resources.GetObject("fld_grcGroupControl8.ShowHelp"))));
            this.fld_grcGroupControl8.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_dgcHRQuarterRewards
            // 
            this.fld_dgcHRQuarterRewards.AllowDrop = true;
            this.fld_dgcHRQuarterRewards.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.BOSDataSource = "HRQuarterRewards";
            this.fld_dgcHRQuarterRewards.BOSDescription = null;
            this.fld_dgcHRQuarterRewards.BOSError = null;
            this.fld_dgcHRQuarterRewards.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.BOSGridType = null;
            this.fld_dgcHRQuarterRewards.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRQuarterRewards.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_dgcHRQuarterRewards, "fld_dgcHRQuarterRewards");
            this.fld_dgcHRQuarterRewards.MainView = this.fld_dgvHRQuarterRewards;
            this.fld_dgcHRQuarterRewards.Name = "fld_dgcHRQuarterRewards";
            this.fld_dgcHRQuarterRewards.PrintReport = false;
            this.fld_dgcHRQuarterRewards.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRQuarterRewards, ((bool)(resources.GetObject("fld_dgcHRQuarterRewards.ShowHelp"))));
            this.fld_dgcHRQuarterRewards.Tag = "DC";
            this.fld_dgcHRQuarterRewards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRQuarterRewards});
            // 
            // fld_dgvHRQuarterRewards
            // 
            this.fld_dgvHRQuarterRewards.GridControl = this.fld_dgcHRQuarterRewards;
            this.fld_dgvHRQuarterRewards.Name = "fld_dgvHRQuarterRewards";
            this.fld_dgvHRQuarterRewards.PaintStyleName = "Office2003";
            // 
            // DMSS110
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSS110";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRQuarterRewardEffectiveDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRQuarterRewardEffectiveDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRQuarterRewardAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl8)).EndInit();
            this.fld_grcGroupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRQuarterRewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRQuarterRewards)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl8;
        private HRQuarterRewardsGridControl fld_dgcHRQuarterRewards;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRQuarterRewards;
        private BOSComponent.BOSButton fld_btnAddContactPerson;
        private BOSComponent.BOSButton fld_btnDeleteContactPerson;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSTextBox fld_txtHRQuarterRewardAmount;
        private BOSComponent.BOSDateEdit fld_dteHRQuarterRewardEffectiveDate;
	}
}
