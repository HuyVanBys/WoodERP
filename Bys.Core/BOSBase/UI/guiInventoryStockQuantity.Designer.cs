namespace BOSERP
{
    partial class guiInventoryStockQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiInventoryStockQuantity));
            this.fld_dgcInventoryStocks = new BOSERP.InventoryStockQuantityGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblOnHandQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSOQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblAvailableQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPOQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTransitInQty = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblWoodPlanQty = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTransitOutQty = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPurchasePlanQty = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcInventoryStocks
            // 
            resources.ApplyResources(this.fld_dgcInventoryStocks, "fld_dgcInventoryStocks");
            this.fld_dgcInventoryStocks.BOSComment = null;
            this.fld_dgcInventoryStocks.BOSDataMember = null;
            this.fld_dgcInventoryStocks.BOSDataSource = "ICInventoryStocks";
            this.fld_dgcInventoryStocks.BOSDescription = null;
            this.fld_dgcInventoryStocks.BOSError = null;
            this.fld_dgcInventoryStocks.BOSFieldGroup = null;
            this.fld_dgcInventoryStocks.BOSFieldRelation = null;
            this.fld_dgcInventoryStocks.BOSGridType = null;
            this.fld_dgcInventoryStocks.BOSPrivilege = null;
            this.fld_dgcInventoryStocks.BOSPropertyName = null;
            this.fld_dgcInventoryStocks.CommodityType = global::Localization.BaseLocalizedResources.string1;
            this.fld_dgcInventoryStocks.MainView = this.gridView1;
            this.fld_dgcInventoryStocks.Name = "fld_dgcInventoryStocks";
            this.fld_dgcInventoryStocks.PrintReport = false;
            this.fld_dgcInventoryStocks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcInventoryStocks, ((bool)(resources.GetObject("fld_dgcInventoryStocks.ShowHelp"))));
            this.fld_dgcInventoryStocks.Tag = "DC";
            this.fld_dgcInventoryStocks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcInventoryStocks;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnClose
            // 
            resources.ApplyResources(this.fld_btnClose, "fld_btnClose");
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, ((bool)(resources.GetObject("fld_btnClose.ShowHelp"))));
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            // 
            // fld_lblOnHandQty
            // 
            this.fld_lblOnHandQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblOnHandQty.Appearance.Options.UseFont = true;
            this.fld_lblOnHandQty.BOSComment = null;
            this.fld_lblOnHandQty.BOSDataMember = null;
            this.fld_lblOnHandQty.BOSDataSource = null;
            this.fld_lblOnHandQty.BOSDescription = null;
            this.fld_lblOnHandQty.BOSError = null;
            this.fld_lblOnHandQty.BOSFieldGroup = null;
            this.fld_lblOnHandQty.BOSFieldRelation = null;
            this.fld_lblOnHandQty.BOSPrivilege = null;
            this.fld_lblOnHandQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblOnHandQty, "fld_lblOnHandQty");
            this.fld_lblOnHandQty.Name = "fld_lblOnHandQty";
            this.fld_lblOnHandQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblOnHandQty, ((bool)(resources.GetObject("fld_lblOnHandQty.ShowHelp"))));
            // 
            // fld_lblSOQty
            // 
            this.fld_lblSOQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblSOQty.Appearance.Options.UseFont = true;
            this.fld_lblSOQty.BOSComment = null;
            this.fld_lblSOQty.BOSDataMember = null;
            this.fld_lblSOQty.BOSDataSource = null;
            this.fld_lblSOQty.BOSDescription = null;
            this.fld_lblSOQty.BOSError = null;
            this.fld_lblSOQty.BOSFieldGroup = null;
            this.fld_lblSOQty.BOSFieldRelation = null;
            this.fld_lblSOQty.BOSPrivilege = null;
            this.fld_lblSOQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblSOQty, "fld_lblSOQty");
            this.fld_lblSOQty.Name = "fld_lblSOQty";
            this.fld_lblSOQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblSOQty, ((bool)(resources.GetObject("fld_lblSOQty.ShowHelp"))));
            // 
            // fld_lblAvailableQty
            // 
            this.fld_lblAvailableQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblAvailableQty.Appearance.Options.UseFont = true;
            this.fld_lblAvailableQty.BOSComment = null;
            this.fld_lblAvailableQty.BOSDataMember = null;
            this.fld_lblAvailableQty.BOSDataSource = null;
            this.fld_lblAvailableQty.BOSDescription = null;
            this.fld_lblAvailableQty.BOSError = null;
            this.fld_lblAvailableQty.BOSFieldGroup = null;
            this.fld_lblAvailableQty.BOSFieldRelation = null;
            this.fld_lblAvailableQty.BOSPrivilege = null;
            this.fld_lblAvailableQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblAvailableQty, "fld_lblAvailableQty");
            this.fld_lblAvailableQty.Name = "fld_lblAvailableQty";
            this.fld_lblAvailableQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblAvailableQty, ((bool)(resources.GetObject("fld_lblAvailableQty.ShowHelp"))));
            // 
            // fld_lblPOQty
            // 
            this.fld_lblPOQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblPOQty.Appearance.Options.UseFont = true;
            this.fld_lblPOQty.BOSComment = null;
            this.fld_lblPOQty.BOSDataMember = null;
            this.fld_lblPOQty.BOSDataSource = null;
            this.fld_lblPOQty.BOSDescription = null;
            this.fld_lblPOQty.BOSError = null;
            this.fld_lblPOQty.BOSFieldGroup = null;
            this.fld_lblPOQty.BOSFieldRelation = null;
            this.fld_lblPOQty.BOSPrivilege = null;
            this.fld_lblPOQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblPOQty, "fld_lblPOQty");
            this.fld_lblPOQty.Name = "fld_lblPOQty";
            this.fld_lblPOQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblPOQty, ((bool)(resources.GetObject("fld_lblPOQty.ShowHelp"))));
            // 
            // fld_lblTransitInQty
            // 
            this.fld_lblTransitInQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblTransitInQty.Appearance.Options.UseFont = true;
            this.fld_lblTransitInQty.BOSComment = null;
            this.fld_lblTransitInQty.BOSDataMember = null;
            this.fld_lblTransitInQty.BOSDataSource = null;
            this.fld_lblTransitInQty.BOSDescription = null;
            this.fld_lblTransitInQty.BOSError = null;
            this.fld_lblTransitInQty.BOSFieldGroup = null;
            this.fld_lblTransitInQty.BOSFieldRelation = null;
            this.fld_lblTransitInQty.BOSPrivilege = null;
            this.fld_lblTransitInQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblTransitInQty, "fld_lblTransitInQty");
            this.fld_lblTransitInQty.Name = "fld_lblTransitInQty";
            this.fld_lblTransitInQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblTransitInQty, ((bool)(resources.GetObject("fld_lblTransitInQty.ShowHelp"))));
            // 
            // bosPanel1
            // 
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblPurchasePlanQty);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblWoodPlanQty);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblOnHandQty);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblSOQty);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblAvailableQty);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblPOQty);
            this.bosPanel1.Controls.Add(this.fld_lblTransitOutQty);
            this.bosPanel1.Controls.Add(this.fld_lblTransitInQty);
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel7, "bosLabel7");
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, ((bool)(resources.GetObject("bosLabel7.ShowHelp"))));
            // 
            // fld_lblWoodPlanQty
            // 
            this.fld_lblWoodPlanQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblWoodPlanQty.Appearance.Options.UseFont = true;
            this.fld_lblWoodPlanQty.BOSComment = null;
            this.fld_lblWoodPlanQty.BOSDataMember = null;
            this.fld_lblWoodPlanQty.BOSDataSource = null;
            this.fld_lblWoodPlanQty.BOSDescription = null;
            this.fld_lblWoodPlanQty.BOSError = null;
            this.fld_lblWoodPlanQty.BOSFieldGroup = null;
            this.fld_lblWoodPlanQty.BOSFieldRelation = null;
            this.fld_lblWoodPlanQty.BOSPrivilege = null;
            this.fld_lblWoodPlanQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblWoodPlanQty, "fld_lblWoodPlanQty");
            this.fld_lblWoodPlanQty.Name = "fld_lblWoodPlanQty";
            this.fld_lblWoodPlanQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblWoodPlanQty, ((bool)(resources.GetObject("fld_lblWoodPlanQty.ShowHelp"))));
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            // 
            // fld_lblTransitOutQty
            // 
            this.fld_lblTransitOutQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblTransitOutQty.Appearance.Options.UseFont = true;
            this.fld_lblTransitOutQty.BOSComment = null;
            this.fld_lblTransitOutQty.BOSDataMember = null;
            this.fld_lblTransitOutQty.BOSDataSource = null;
            this.fld_lblTransitOutQty.BOSDescription = null;
            this.fld_lblTransitOutQty.BOSError = null;
            this.fld_lblTransitOutQty.BOSFieldGroup = null;
            this.fld_lblTransitOutQty.BOSFieldRelation = null;
            this.fld_lblTransitOutQty.BOSPrivilege = null;
            this.fld_lblTransitOutQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblTransitOutQty, "fld_lblTransitOutQty");
            this.fld_lblTransitOutQty.Name = "fld_lblTransitOutQty";
            this.fld_lblTransitOutQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblTransitOutQty, ((bool)(resources.GetObject("fld_lblTransitOutQty.ShowHelp"))));
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, ((bool)(resources.GetObject("bosLabel8.ShowHelp"))));
            // 
            // fld_lblPurchasePlanQty
            // 
            this.fld_lblPurchasePlanQty.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblPurchasePlanQty.Appearance.Options.UseFont = true;
            this.fld_lblPurchasePlanQty.BOSComment = null;
            this.fld_lblPurchasePlanQty.BOSDataMember = null;
            this.fld_lblPurchasePlanQty.BOSDataSource = null;
            this.fld_lblPurchasePlanQty.BOSDescription = null;
            this.fld_lblPurchasePlanQty.BOSError = null;
            this.fld_lblPurchasePlanQty.BOSFieldGroup = null;
            this.fld_lblPurchasePlanQty.BOSFieldRelation = null;
            this.fld_lblPurchasePlanQty.BOSPrivilege = null;
            this.fld_lblPurchasePlanQty.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblPurchasePlanQty, "fld_lblPurchasePlanQty");
            this.fld_lblPurchasePlanQty.Name = "fld_lblPurchasePlanQty";
            this.fld_lblPurchasePlanQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblPurchasePlanQty, ((bool)(resources.GetObject("fld_lblPurchasePlanQty.ShowHelp"))));
            // 
            // guiInventoryStockQuantity
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_dgcInventoryStocks);
            this.Name = "guiInventoryStockQuantity";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Load += new System.EventHandler(this.guiInventoryStockQuantity_Load);
            this.Controls.SetChildIndex(this.fld_dgcInventoryStocks, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private InventoryStockQuantityGridControl fld_dgcInventoryStocks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblOnHandQty;
        private BOSComponent.BOSLabel fld_lblSOQty;
        private BOSComponent.BOSLabel fld_lblAvailableQty;
        private BOSComponent.BOSLabel fld_lblPOQty;
        private BOSComponent.BOSLabel fld_lblTransitInQty;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblTransitOutQty;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel fld_lblWoodPlanQty;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel fld_lblPurchasePlanQty;
    }
}