using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS107
	/// </summary>
    partial class DMCS107
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS107));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICImportAndExportReasons = new BOSERP.Modules.CompanyConstant.ICImportAndExportReasonGridControl();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtToNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFromNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcStockConfigRatesGridControl = new BOSERP.Modules.CompanyConstant.ICStockConfigRatesGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICPriceCalculationMethods = new BOSERP.Modules.CompanyConstant.ICPriceCalculationMethodsGridControl();
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICCalculatedPackageVolumnConfigs = new BOSERP.Modules.CompanyConstant.ICCalculatedPackageVolumnConfigGridControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICImportAndExportReasons)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtToNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFromNumber.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcStockConfigRatesGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPriceCalculationMethods)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCalculatedPackageVolumnConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(932, 770);
            this.bosPanel1.TabIndex = 334;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage5;
            this.bosTabControl1.Size = new System.Drawing.Size(932, 770);
            this.bosTabControl1.TabIndex = 68;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5,
            this.xtraTabPage2});
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.AutoScroll = true;
            this.xtraTabPage5.Controls.Add(this.bosLine1);
            this.xtraTabPage5.Controls.Add(this.bosLine2);
            this.xtraTabPage5.Controls.Add(this.bosLine3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(930, 745);
            this.xtraTabPage5.Text = "Cấu hình kho";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcICImportAndExportReasons);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 14);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(824, 232);
            this.bosLine1.TabIndex = 64;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Cấu hình lý do nhập xuất kho điều chỉnh";
            // 
            // fld_dgcICImportAndExportReasons
            // 
            this.fld_dgcICImportAndExportReasons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICImportAndExportReasons.BOSComment = null;
            this.fld_dgcICImportAndExportReasons.BOSDataMember = null;
            this.fld_dgcICImportAndExportReasons.BOSDataSource = "ICImportAndExportReasons";
            this.fld_dgcICImportAndExportReasons.BOSDescription = null;
            this.fld_dgcICImportAndExportReasons.BOSError = null;
            this.fld_dgcICImportAndExportReasons.BOSFieldGroup = null;
            this.fld_dgcICImportAndExportReasons.BOSFieldRelation = null;
            this.fld_dgcICImportAndExportReasons.BOSGridType = null;
            this.fld_dgcICImportAndExportReasons.BOSPrivilege = null;
            this.fld_dgcICImportAndExportReasons.BOSPropertyName = null;
            this.fld_dgcICImportAndExportReasons.CommodityType = "";
            this.fld_dgcICImportAndExportReasons.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcICImportAndExportReasons.MenuManager = this.screenToolbar;
            this.fld_dgcICImportAndExportReasons.Name = "fld_dgcICImportAndExportReasons";
            this.fld_dgcICImportAndExportReasons.PrintReport = false;
            this.fld_dgcICImportAndExportReasons.Screen = null;
            this.fld_dgcICImportAndExportReasons.Size = new System.Drawing.Size(817, 206);
            this.fld_dgcICImportAndExportReasons.TabIndex = 0;
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_btnPrint);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.fld_txtToNumber);
            this.bosLine2.Controls.Add(this.bosLabel5);
            this.bosLine2.Controls.Add(this.fld_txtFromNumber);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 575);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(824, 67);
            this.bosLine2.TabIndex = 65;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "In mã định danh";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(285, 20);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(94, 31);
            this.fld_btnPrint.TabIndex = 66;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(143, 28);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(34, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Đến số";
            // 
            // fld_txtToNumber
            // 
            this.fld_txtToNumber.BOSComment = null;
            this.fld_txtToNumber.BOSDataMember = null;
            this.fld_txtToNumber.BOSDataSource = null;
            this.fld_txtToNumber.BOSDescription = null;
            this.fld_txtToNumber.BOSError = null;
            this.fld_txtToNumber.BOSFieldGroup = null;
            this.fld_txtToNumber.BOSFieldRelation = null;
            this.fld_txtToNumber.BOSPrivilege = null;
            this.fld_txtToNumber.BOSPropertyName = null;
            this.fld_txtToNumber.Location = new System.Drawing.Point(183, 25);
            this.fld_txtToNumber.Name = "fld_txtToNumber";
            this.fld_txtToNumber.Properties.Mask.EditMask = "n0";
            this.fld_txtToNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtToNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtToNumber, true);
            this.fld_txtToNumber.Size = new System.Drawing.Size(96, 20);
            this.fld_txtToNumber.TabIndex = 6;
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
            this.bosLabel5.Location = new System.Drawing.Point(8, 28);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 5;
            this.bosLabel5.Text = "Từ số";
            // 
            // fld_txtFromNumber
            // 
            this.fld_txtFromNumber.BOSComment = null;
            this.fld_txtFromNumber.BOSDataMember = null;
            this.fld_txtFromNumber.BOSDataSource = null;
            this.fld_txtFromNumber.BOSDescription = null;
            this.fld_txtFromNumber.BOSError = null;
            this.fld_txtFromNumber.BOSFieldGroup = null;
            this.fld_txtFromNumber.BOSFieldRelation = null;
            this.fld_txtFromNumber.BOSPrivilege = null;
            this.fld_txtFromNumber.BOSPropertyName = null;
            this.fld_txtFromNumber.Location = new System.Drawing.Point(41, 25);
            this.fld_txtFromNumber.Name = "fld_txtFromNumber";
            this.fld_txtFromNumber.Properties.Mask.EditMask = "n0";
            this.fld_txtFromNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtFromNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtFromNumber, true);
            this.fld_txtFromNumber.Size = new System.Drawing.Size(96, 20);
            this.fld_txtFromNumber.TabIndex = 1;
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_dgcStockConfigRatesGridControl);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(5, 252);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(825, 317);
            this.bosLine3.TabIndex = 67;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Cấu hình tỷ lệ chênh lệch xuất kho";
            // 
            // fld_dgcStockConfigRatesGridControl
            // 
            this.fld_dgcStockConfigRatesGridControl.BOSComment = null;
            this.fld_dgcStockConfigRatesGridControl.BOSDataMember = null;
            this.fld_dgcStockConfigRatesGridControl.BOSDataSource = "ICStockConfigRates";
            this.fld_dgcStockConfigRatesGridControl.BOSDescription = null;
            this.fld_dgcStockConfigRatesGridControl.BOSError = null;
            this.fld_dgcStockConfigRatesGridControl.BOSFieldGroup = null;
            this.fld_dgcStockConfigRatesGridControl.BOSFieldRelation = null;
            this.fld_dgcStockConfigRatesGridControl.BOSGridType = null;
            this.fld_dgcStockConfigRatesGridControl.BOSPrivilege = null;
            this.fld_dgcStockConfigRatesGridControl.BOSPropertyName = null;
            this.fld_dgcStockConfigRatesGridControl.CommodityType = "";
            this.fld_dgcStockConfigRatesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcStockConfigRatesGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcStockConfigRatesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcStockConfigRatesGridControl.Name = "fld_dgcStockConfigRatesGridControl";
            this.fld_dgcStockConfigRatesGridControl.PrintReport = false;
            this.fld_dgcStockConfigRatesGridControl.Screen = null;
            this.fld_dgcStockConfigRatesGridControl.Size = new System.Drawing.Size(819, 297);
            this.fld_dgcStockConfigRatesGridControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.bosLine5);
            this.xtraTabPage2.Controls.Add(this.bosLine4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(916, 738);
            this.xtraTabPage2.Text = "Phương pháp tính giá / tự tính m3";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_dgcICPriceCalculationMethods);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(2, 14);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(825, 210);
            this.bosLine5.TabIndex = 66;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Cấu hình phương pháp tính giá xuất kho";
            // 
            // fld_dgcICPriceCalculationMethods
            // 
            this.fld_dgcICPriceCalculationMethods.BOSComment = null;
            this.fld_dgcICPriceCalculationMethods.BOSDataMember = null;
            this.fld_dgcICPriceCalculationMethods.BOSDataSource = "ICPriceCalculationMethods";
            this.fld_dgcICPriceCalculationMethods.BOSDescription = null;
            this.fld_dgcICPriceCalculationMethods.BOSError = null;
            this.fld_dgcICPriceCalculationMethods.BOSFieldGroup = null;
            this.fld_dgcICPriceCalculationMethods.BOSFieldRelation = null;
            this.fld_dgcICPriceCalculationMethods.BOSGridType = null;
            this.fld_dgcICPriceCalculationMethods.BOSPrivilege = null;
            this.fld_dgcICPriceCalculationMethods.BOSPropertyName = null;
            this.fld_dgcICPriceCalculationMethods.CommodityType = "";
            this.fld_dgcICPriceCalculationMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICPriceCalculationMethods.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICPriceCalculationMethods.MenuManager = this.screenToolbar;
            this.fld_dgcICPriceCalculationMethods.Name = "fld_dgcICPriceCalculationMethods";
            this.fld_dgcICPriceCalculationMethods.PrintReport = false;
            this.fld_dgcICPriceCalculationMethods.Screen = null;
            this.fld_dgcICPriceCalculationMethods.Size = new System.Drawing.Size(819, 190);
            this.fld_dgcICPriceCalculationMethods.TabIndex = 2;
            // 
            // bosLine4
            // 
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_dgcICCalculatedPackageVolumnConfigs);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(5, 230);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(819, 410);
            this.bosLine4.TabIndex = 65;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Cấu hình tự tính m3 khi nhập số thanh/ số tấm của gỗ";
            // 
            // fld_dgcICCalculatedPackageVolumnConfigs
            // 
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSComment = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSDataMember = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSDataSource = "ICCalculatedPackageVolumnConfigs";
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSDescription = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSError = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSFieldGroup = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSFieldRelation = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSGridType = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSPrivilege = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.BOSPropertyName = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.CommodityType = "";
            this.fld_dgcICCalculatedPackageVolumnConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICCalculatedPackageVolumnConfigs.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICCalculatedPackageVolumnConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcICCalculatedPackageVolumnConfigs.Name = "fld_dgcICCalculatedPackageVolumnConfigs";
            this.fld_dgcICCalculatedPackageVolumnConfigs.PrintReport = false;
            this.fld_dgcICCalculatedPackageVolumnConfigs.Screen = null;
            this.fld_dgcICCalculatedPackageVolumnConfigs.Size = new System.Drawing.Size(813, 390);
            this.fld_dgcICCalculatedPackageVolumnConfigs.TabIndex = 0;
            // 
            // DMCS107
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(932, 770);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS107.IconOptions.Icon")));
            this.Name = "DMCS107";
            this.Text = "Kho";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICImportAndExportReasons)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtToNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFromNumber.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcStockConfigRatesGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPriceCalculationMethods)).EndInit();
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCalculatedPackageVolumnConfigs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine1;
        private ICImportAndExportReasonGridControl fld_dgcICImportAndExportReasons;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSTextBox fld_txtFromNumber;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtToNumber;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLine bosLine3;
        private ICStockConfigRatesGridControl fld_dgcStockConfigRatesGridControl;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ICPriceCalculationMethodsGridControl fld_dgcICPriceCalculationMethods;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLine bosLine4;
        private ICCalculatedPackageVolumnConfigGridControl fld_dgcICCalculatedPackageVolumnConfigs;
    }
}
