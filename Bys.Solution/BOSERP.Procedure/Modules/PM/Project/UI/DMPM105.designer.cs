using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
	/// Summary description for DMSO102
	/// </summary>
    partial class DMPM105
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
            this.fld_pnlMainScreen = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcARSaleContractsGridControl = new BOSERP.Modules.Project.ARSaleContractsGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pnlMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleContractsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pnlMainScreen
            // 
            this.fld_pnlMainScreen.BOSComment = null;
            this.fld_pnlMainScreen.BOSDataMember = null;
            this.fld_pnlMainScreen.BOSDataSource = null;
            this.fld_pnlMainScreen.BOSDescription = null;
            this.fld_pnlMainScreen.BOSError = null;
            this.fld_pnlMainScreen.BOSFieldGroup = null;
            this.fld_pnlMainScreen.BOSFieldRelation = null;
            this.fld_pnlMainScreen.BOSPrivilege = null;
            this.fld_pnlMainScreen.BOSPropertyName = null;
            this.fld_pnlMainScreen.Controls.Add(this.fld_dgcARSaleContractsGridControl);
            this.fld_pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainScreen.Name = "fld_pnlMainScreen";
            this.fld_pnlMainScreen.Screen = null;
            this.fld_pnlMainScreen.Size = new System.Drawing.Size(862, 567);
            this.fld_pnlMainScreen.TabIndex = 6;
            // 
            // fld_dgcARSaleContractsGridControl
            // 
            this.fld_dgcARSaleContractsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleContractsGridControl.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.BOSDataSource = "ARSaleContracts";
            this.fld_dgcARSaleContractsGridControl.BOSDescription = null;
            this.fld_dgcARSaleContractsGridControl.BOSError = null;
            this.fld_dgcARSaleContractsGridControl.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.BOSGridType = null;
            this.fld_dgcARSaleContractsGridControl.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcARSaleContractsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleContractsGridControl.Location = new System.Drawing.Point(3, 12);
            this.fld_dgcARSaleContractsGridControl.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcARSaleContractsGridControl.Name = "fld_dgcARSaleContractsGridControl";
            this.fld_dgcARSaleContractsGridControl.PrintReport = false;
            this.fld_dgcARSaleContractsGridControl.Screen = null;
            this.fld_dgcARSaleContractsGridControl.Size = new System.Drawing.Size(856, 543);
            this.fld_dgcARSaleContractsGridControl.TabIndex = 26;
            this.fld_dgcARSaleContractsGridControl.Tag = "DC";
            this.fld_dgcARSaleContractsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcARSaleContractsGridControl;
            this.fld_dgvARSaleForecastTemplates.Name = "fld_dgvARSaleForecastTemplates";
            // 
            // DMPM105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_pnlMainScreen);
            this.Name = "DMPM105";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_pnlMainScreen, 0);
            this.fld_pnlMainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleContractsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSPanel fld_pnlMainScreen;
        private BOSERP.Modules.Project.ARSaleContractsGridControl fld_dgcARSaleContractsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
	}
}
