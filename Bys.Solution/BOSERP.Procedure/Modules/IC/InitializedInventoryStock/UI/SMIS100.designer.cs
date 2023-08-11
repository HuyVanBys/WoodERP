using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InitializedInventoryStock.UI
{
	/// <summary>
	/// Summary description for SMIS100
	/// </summary>
	partial class SMIS100
    {
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductNo;

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
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSerieNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICInitializedInventoryStockToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcICInitializedInventoryStock = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICInitializedInventoryStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSerieNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInitializedInventoryStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICInitializedInventoryStock)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(46, 19);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã sản phẩm";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.Location = new System.Drawing.Point(151, 16);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "SC";
            // 
            // fld_txtICProductSerieNo
            // 
            this.fld_txtICProductSerieNo.BOSComment = null;
            this.fld_txtICProductSerieNo.BOSDataMember = "ICProductSerieNo";
            this.fld_txtICProductSerieNo.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICProductSerieNo.BOSDescription = null;
            this.fld_txtICProductSerieNo.BOSError = null;
            this.fld_txtICProductSerieNo.BOSFieldGroup = null;
            this.fld_txtICProductSerieNo.BOSFieldRelation = null;
            this.fld_txtICProductSerieNo.BOSPrivilege = null;
            this.fld_txtICProductSerieNo.BOSPropertyName = "Text";
            this.fld_txtICProductSerieNo.Location = new System.Drawing.Point(151, 42);
            this.fld_txtICProductSerieNo.MenuManager = this.screenToolbar;
            this.fld_txtICProductSerieNo.Name = "fld_txtICProductSerieNo";
            this.fld_txtICProductSerieNo.Screen = null;
            this.fld_txtICProductSerieNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductSerieNo.TabIndex = 1;
            this.fld_txtICProductSerieNo.Tag = "SC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.BOSComment = null;
            this.fld_lblLabel13.BOSDataMember = null;
            this.fld_lblLabel13.BOSDataSource = null;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = null;
            this.fld_lblLabel13.BOSFieldRelation = null;
            this.fld_lblLabel13.BOSPrivilege = null;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(46, 45);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel13.TabIndex = 341;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Mã lô";
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
            this.bosLabel1.Location = new System.Drawing.Point(46, 73);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 343;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_dteICInitializedInventoryStockToDate
            // 
            this.fld_dteICInitializedInventoryStockToDate.BOSComment = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSDataMember = "ICInitializedInventoryStockToDate";
            this.fld_dteICInitializedInventoryStockToDate.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_dteICInitializedInventoryStockToDate.BOSDescription = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSError = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSFieldGroup = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSFieldRelation = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSPrivilege = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSPropertyName = "EditValue";
            this.fld_dteICInitializedInventoryStockToDate.EditValue = null;
            this.fld_dteICInitializedInventoryStockToDate.Location = new System.Drawing.Point(151, 70);
            this.fld_dteICInitializedInventoryStockToDate.Name = "fld_dteICInitializedInventoryStockToDate";
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICInitializedInventoryStockToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICInitializedInventoryStockToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICInitializedInventoryStockToDate, true);
            this.fld_dteICInitializedInventoryStockToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICInitializedInventoryStockToDate.TabIndex = 344;
            this.fld_dteICInitializedInventoryStockToDate.Tag = "SC";
            // 
            // fld_dgcICInitializedInventoryStock
            // 
            this.fld_dgcICInitializedInventoryStock.AllowDrop = true;
            this.fld_dgcICInitializedInventoryStock.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICInitializedInventoryStock.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICInitializedInventoryStock.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_dgcICInitializedInventoryStock.BOSDescription = null;
            this.fld_dgcICInitializedInventoryStock.BOSError = null;
            this.fld_dgcICInitializedInventoryStock.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICInitializedInventoryStock.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICInitializedInventoryStock.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICInitializedInventoryStock.BOSPropertyName = null;
            this.fld_dgcICInitializedInventoryStock.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICInitializedInventoryStock.Location = new System.Drawing.Point(63, 143);
            this.fld_dgcICInitializedInventoryStock.MainView = this.fld_dgvICInitializedInventoryStock;
            this.fld_dgcICInitializedInventoryStock.Name = "fld_dgcICInitializedInventoryStock";
            this.fld_dgcICInitializedInventoryStock.Screen = null;
            this.fld_dgcICInitializedInventoryStock.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcICInitializedInventoryStock.TabIndex = 545;
            this.fld_dgcICInitializedInventoryStock.Tag = "SR";
            this.fld_dgcICInitializedInventoryStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICInitializedInventoryStock});
            // 
            // fld_dgvICInitializedInventoryStock
            // 
            this.fld_dgvICInitializedInventoryStock.GridControl = this.fld_dgcICInitializedInventoryStock;
            this.fld_dgvICInitializedInventoryStock.Name = "fld_dgvICInitializedInventoryStock";
            this.fld_dgvICInitializedInventoryStock.PaintStyleName = "Office2003";
            // 
            // SMIS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(613, 567);
            this.Controls.Add(this.fld_dgcICInitializedInventoryStock);
            this.Controls.Add(this.fld_dteICInitializedInventoryStockToDate);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICProductSerieNo);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_txtICProductNo);
            this.Name = "SMIS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICProductNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductSerieNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteICInitializedInventoryStockToDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcICInitializedInventoryStock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSerieNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInitializedInventoryStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICInitializedInventoryStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtICProductSerieNo;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteICInitializedInventoryStockToDate;
        private BOSSearchResultsGridControl fld_dgcICInitializedInventoryStock;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICInitializedInventoryStock;
	}
}
