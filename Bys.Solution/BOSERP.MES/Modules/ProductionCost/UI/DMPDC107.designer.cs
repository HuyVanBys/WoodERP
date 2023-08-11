using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC107
	/// </summary>
	partial class DMPDC107
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_btnUpdatePriceDG = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesSC = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompleteSCsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompletesGridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesTC = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompleteTCsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesLR = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompleteLRsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesSon = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompleteSonsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientIncompletesDG = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientIncompleteDGsGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnUpdatePriceDG)).BeginInit();
            this.fld_btnUpdatePriceDG.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesPhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_btnUpdatePriceDG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 567);
            this.panel1.TabIndex = 29;
            // 
            // fld_btnUpdatePriceDG
            // 
            this.fld_btnUpdatePriceDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdatePriceDG.BOSComment = null;
            this.fld_btnUpdatePriceDG.BOSDataMember = null;
            this.fld_btnUpdatePriceDG.BOSDataSource = null;
            this.fld_btnUpdatePriceDG.BOSDescription = null;
            this.fld_btnUpdatePriceDG.BOSError = null;
            this.fld_btnUpdatePriceDG.BOSFieldGroup = null;
            this.fld_btnUpdatePriceDG.BOSFieldRelation = null;
            this.fld_btnUpdatePriceDG.BOSPrivilege = null;
            this.fld_btnUpdatePriceDG.BOSPropertyName = null;
            this.fld_btnUpdatePriceDG.Location = new System.Drawing.Point(3, 3);
            this.fld_btnUpdatePriceDG.Name = "fld_btnUpdatePriceDG";
            this.fld_btnUpdatePriceDG.Screen = null;
            this.fld_btnUpdatePriceDG.SelectedTabPage = this.xtraTabPage2;
            this.fld_btnUpdatePriceDG.Size = new System.Drawing.Size(856, 561);
            this.fld_btnUpdatePriceDG.TabIndex = 30;
            this.fld_btnUpdatePriceDG.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage5,
            this.xtraTabPage4,
            this.xtraTabPage6});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesSC);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage2.Text = "Công đoạn sơ chế";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesSC
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesSC.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSDataSource = "MMProductionCostIngredientCostDDSCs";
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesSC.MainView = this.gridView1;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Name = "fld_dgcMMProductionCostIngredientIncompletesSC";
            this.fld_dgcMMProductionCostIngredientIncompletesSC.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesSC.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientIncompletesSC.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesSC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesSC;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesPhoi);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage1.Text = "Công đoạn phôi";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesPhoi
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSDataSource = "MMProductionCostIngredientCostDDs";
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.MainView = this.gridView6;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Name = "fld_dgcMMProductionCostIngredientIncompletesPhoi";
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.TabIndex = 372;
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesPhoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesPhoi;
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesTC);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage3.Text = "Công đoạn tinh chế";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesTC
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesTC.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSDataSource = "MMProductionCostIngredientCostDDTCs";
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesTC.MainView = this.gridView2;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Name = "fld_dgcMMProductionCostIngredientIncompletesTC";
            this.fld_dgcMMProductionCostIngredientIncompletesTC.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesTC.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientIncompletesTC.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesTC;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesLR);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage5.Text = "Công đoạn lắp ráp";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesLR
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesLR.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSDataSource = "MMProductionCostIngredientCostDDLRs";
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesLR.MainView = this.gridView4;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Name = "fld_dgcMMProductionCostIngredientIncompletesLR";
            this.fld_dgcMMProductionCostIngredientIncompletesLR.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesLR.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientIncompletesLR.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesLR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesLR;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesSon);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage4.Text = "Công đoạn sơn";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesSon
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesSon.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSDataSource = "MMProductionCostIngredientCostDDSons";
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesSon.MainView = this.gridView3;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Name = "fld_dgcMMProductionCostIngredientIncompletesSon";
            this.fld_dgcMMProductionCostIngredientIncompletesSon.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesSon.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientIncompletesSon.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesSon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesSon;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.fld_dgcMMProductionCostIngredientIncompletesDG);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage6.Text = "Công đoạn đóng gói";
            // 
            // fld_dgcMMProductionCostIngredientIncompletesDG
            // 
            this.fld_dgcMMProductionCostIngredientIncompletesDG.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSDataSource = "MMProductionCostIngredientCostDDDGs";
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSError = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMProductionCostIngredientIncompletesDG.MainView = this.gridView5;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Name = "fld_dgcMMProductionCostIngredientIncompletesDG";
            this.fld_dgcMMProductionCostIngredientIncompletesDG.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Screen = null;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Size = new System.Drawing.Size(838, 526);
            this.fld_dgcMMProductionCostIngredientIncompletesDG.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientIncompletesDG.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientIncompletesDG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcMMProductionCostIngredientIncompletesDG;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // DMPDC107
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.panel1);
            this.Name = "DMPDC107";
            this.Text = "Chi phí NVL dở dang";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnUpdatePriceDG)).EndInit();
            this.fld_btnUpdatePriceDG.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesPhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientIncompletesDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private Panel panel1;
        private IContainer components;
        private BOSComponent.BOSTabControl fld_btnUpdatePriceDG;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private MMProductionCostIngredientIncompleteSCsGridControl fld_dgcMMProductionCostIngredientIncompletesSC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private MMProductionCostIngredientIncompleteTCsGridControl fld_dgcMMProductionCostIngredientIncompletesTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private MMProductionCostIngredientIncompleteLRsGridControl fld_dgcMMProductionCostIngredientIncompletesLR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private MMProductionCostIngredientIncompleteSonsGridControl fld_dgcMMProductionCostIngredientIncompletesSon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private MMProductionCostIngredientIncompleteDGsGridControl fld_dgcMMProductionCostIngredientIncompletesDG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private MMProductionCostIngredientIncompletesGridControl fld_dgcMMProductionCostIngredientIncompletesPhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;

    }
}
