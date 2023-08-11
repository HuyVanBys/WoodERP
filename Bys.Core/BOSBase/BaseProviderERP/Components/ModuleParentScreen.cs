using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.ViewInfo;
using Localization;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class ModuleParentScreen : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initial visibility of the inventory container
        /// </summary>
        private DockVisibility InitialInventoryContainerVisibility;

        #region Controls variables

        private System.ComponentModel.IContainer components;

        private DevExpress.XtraBars.BarManager fld_brmToolbarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarButtonItem fld_barmnbContents;
        public DevExpress.XtraBars.BarButtonItem fld_barmnbSystemInfo;
        public DevExpress.XtraBars.BarButtonItem fld_barmnbLicenses;
        public DevExpress.XtraBars.BarButtonItem fld_barmnbAbout;
        private DevExpress.XtraBars.BarButtonItem fld_barmnuOpenCompany;
        private DevExpress.XtraBars.BarButtonItem fld_barmnuCloseCompany;
        private DevExpress.XtraBars.BarButtonItem fld_barmnuLogOff;
        private DevExpress.XtraBars.BarButtonItem fld_barmnuExit;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Docking.DockManager dockManager;

        public DevExpress.XtraBars.Docking.ControlContainer dockPanelSearchResults_Container;
        private DevExpress.XtraBars.BarButtonItem fld_mnubarbtnSectionExplorer;
        private DevExpress.XtraBars.BarButtonItem fld_mnubarbtnSearchExplorer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.PopupMenu popupMenuToolbar;
        public DevExpress.XtraBars.Bar BarMenu;
        private DevExpress.XtraBars.BarSubItem barSubItemMenuFile;
        private DevExpress.XtraBars.BarSubItem barSubItemMenuUtility;
        private DevExpress.XtraBars.BarSubItem barSubMenuItemInfo;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubMenuItemExtra;
        private DevExpress.XtraBars.BarSubItem barSubMenuItemStyle;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleOffice2003;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleFlat;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleStyle3D;
        private DevExpress.XtraBars.BarSubItem barSubItemStyleSkin;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinCaramel;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinTheAsphaltWorld;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinMoneyTwins;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem fld_barbtnProductInventoryInformation;
        private DevExpress.XtraBars.BarButtonItem fld_barbtnProductSerieInventoryInformation;
        private DevExpress.XtraBars.BarButtonItem fld_barbtnSummaryInformation;
        private DevExpress.XtraBars.BarButtonItem fld_barbtnSection;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinLilian;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkiniMaginary;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinBlack;
        private DevExpress.XtraBars.BarCheckItem fld_barCheckStyleSkinBlue;
        public DevExpress.XtraBars.BarCheckItem fld_barckeSearchOption;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraEditors.LabelControl fld_lblTemplateProgressText;
        public DevExpress.XtraBars.BarCheckItem fld_barckeSearchResults;
        private DevExpress.XtraTab.XtraTabControl fld_tabScreenContainer;
        private DevExpress.XtraEditors.DropDownButton fld_drdbtnCreateCriteria;
        private DevExpress.XtraEditors.PanelControl fld_pnlSearchResults;
        public DevExpress.XtraBars.Docking.DockPanel dockSearchResultsPanel;
        private DevExpress.XtraBars.PopupControlContainer fld_popCriteriaName;
        private ADCriterasGridControl fld_dgcADCriterias;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelInventory;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSLabel BOSLabel4;
        private BOSLabel BOSLabel2;
        private BOSLabel BOSLabel5;
        private BOSLabel BOSLabel9;
        private BOSLine fld_pnlInventory;
        private BOSButton fld_btnExpandObjectList;
        private DockPanel fld_pnlLeftPanelContainer;
        private BOSComponent.BOSHyperLinkEdit fld_lnkICInventoryStockQuantity;
        private BOSLabel bosLabel11;
        private BOSLabel bosLabel1;
        private BOSLabel BOSLabel3;
        private BOSComponent.BOSHyperLinkEdit fld_lnkICInventoryStockSaleOrderQuantity;
        private BOSComponent.BOSHyperLinkEdit fld_lnkICInventoryStockPurchaseOrderQuantity;
        private BOSComponent.BOSHyperLinkEdit fld_lnkICInventoryStockTransitOutQuantity;
        private BOSComponent.BOSHyperLinkEdit fld_lnkICInventoryStockTransitInQuantity;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;

        #endregion

        #region Constructor
        public ModuleParentScreen()
        {
            //
            // Required for Windows Form Designer support
            //			            			
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //                               
            ToolbarManager.LargeImages = BOSApp.ToolbarImageList;
            ToolbarManager.Images = BOSApp.ToolbarImageList;
            string ScreenMaximize = String.Empty;
            //this.WindowState = A1CompanyConfigUtility.ScreenState;
            IsObjectListExpanded = false;
        }
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleParentScreen));
            this.fld_brmToolbarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.barSubItemMenuFile = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.fld_barckeSearchOption = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barckeSearchResults = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItemMenuUtility = new DevExpress.XtraBars.BarSubItem();
            this.barSubMenuItemExtra = new DevExpress.XtraBars.BarSubItem();
            this.barSubMenuItemInfo = new DevExpress.XtraBars.BarSubItem();
            this.barSubMenuItemStyle = new DevExpress.XtraBars.BarSubItem();
            this.fld_barCheckStyleOffice2003 = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleFlat = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleStyle3D = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItemStyleSkin = new DevExpress.XtraBars.BarSubItem();
            this.fld_barCheckStyleSkinCaramel = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkinMoneyTwins = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkinLilian = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkinTheAsphaltWorld = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkiniMaginary = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkinBlack = new DevExpress.XtraBars.BarCheckItem();
            this.fld_barCheckStyleSkinBlue = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.fld_barmnbContents = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnbSystemInfo = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnbLicenses = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnbAbout = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnuOpenCompany = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnuCloseCompany = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnuLogOff = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barmnuExit = new DevExpress.XtraBars.BarButtonItem();
            this.fld_mnubarbtnSectionExplorer = new DevExpress.XtraBars.BarButtonItem();
            this.fld_mnubarbtnSearchExplorer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.fld_barbtnProductInventoryInformation = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barbtnProductSerieInventoryInformation = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barbtnSummaryInformation = new DevExpress.XtraBars.BarButtonItem();
            this.fld_barbtnSection = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.fld_pnlLeftPanelContainer = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockSearchResultsPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanelSearchResults_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.fld_btnExpandObjectList = new BOSComponent.BOSButton(this.components);
            this.fld_pnlSearchResults = new DevExpress.XtraEditors.PanelControl();
            this.fld_drdbtnCreateCriteria = new DevExpress.XtraEditors.DropDownButton();
            this.dockPanelInventory = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_pnlInventory = new BOSComponent.BOSLine(this.components);
            this.fld_lnkICInventoryStockTransitInQuantity = new BOSComponent.BOSHyperLinkEdit(this.components);
            this.fld_lnkICInventoryStockTransitOutQuantity = new BOSComponent.BOSHyperLinkEdit(this.components);
            this.fld_lnkICInventoryStockPurchaseOrderQuantity = new BOSComponent.BOSHyperLinkEdit(this.components);
            this.fld_lnkICInventoryStockSaleOrderQuantity = new BOSComponent.BOSHyperLinkEdit(this.components);
            this.fld_lnkICInventoryStockQuantity = new BOSComponent.BOSHyperLinkEdit(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel9 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.popupMenuToolbar = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.fld_lblTemplateProgressText = new DevExpress.XtraEditors.LabelControl();
            this.fld_tabScreenContainer = new DevExpress.XtraTab.XtraTabControl();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.fld_popCriteriaName = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.fld_dgcADCriterias = new BOSERP.ADCriterasGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_brmToolbarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.fld_pnlLeftPanelContainer.SuspendLayout();
            this.dockSearchResultsPanel.SuspendLayout();
            this.dockPanelSearchResults_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnlSearchResults)).BeginInit();
            this.dockPanelInventory.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.fld_pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockTransitInQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockTransitOutQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockPurchaseOrderQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockSaleOrderQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuToolbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_popCriteriaName)).BeginInit();
            this.fld_popCriteriaName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADCriterias)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_brmToolbarManager
            // 
            this.fld_brmToolbarManager.AllowCustomization = false;
            this.fld_brmToolbarManager.AllowQuickCustomization = false;
            this.fld_brmToolbarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenu});
            this.fld_brmToolbarManager.Controller = this.barAndDockingController1;
            this.fld_brmToolbarManager.DockControls.Add(this.barDockControlTop);
            this.fld_brmToolbarManager.DockControls.Add(this.barDockControlBottom);
            this.fld_brmToolbarManager.DockControls.Add(this.barDockControlLeft);
            this.fld_brmToolbarManager.DockControls.Add(this.barDockControlRight);
            this.fld_brmToolbarManager.Form = this;
            this.fld_brmToolbarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.fld_barmnbContents,
            this.fld_barmnbSystemInfo,
            this.fld_barmnbLicenses,
            this.fld_barmnbAbout,
            this.fld_barmnuOpenCompany,
            this.fld_barmnuCloseCompany,
            this.fld_barmnuLogOff,
            this.fld_barmnuExit,
            this.fld_mnubarbtnSectionExplorer,
            this.fld_mnubarbtnSearchExplorer,
            this.barButtonItem1,
            this.barSubItem1,
            this.barSubItemMenuFile,
            this.barSubItemMenuUtility,
            this.barSubMenuItemInfo,
            this.barSubMenuItemExtra,
            this.barSubMenuItemStyle,
            this.fld_barCheckStyleOffice2003,
            this.fld_barCheckStyleFlat,
            this.barCheckItem1,
            this.fld_barCheckStyleStyle3D,
            this.barSubItemStyleSkin,
            this.fld_barCheckStyleSkinCaramel,
            this.fld_barCheckStyleSkinTheAsphaltWorld,
            this.fld_barCheckStyleSkinMoneyTwins,
            this.barSubItem2,
            this.barSubItem3,
            this.fld_barbtnProductInventoryInformation,
            this.fld_barbtnProductSerieInventoryInformation,
            this.fld_barbtnSummaryInformation,
            this.fld_barbtnSection,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barStaticItem1,
            this.fld_barCheckStyleSkinLilian,
            this.fld_barCheckStyleSkinBlack,
            this.fld_barCheckStyleSkinBlue,
            this.fld_barCheckStyleSkiniMaginary,
            this.fld_barckeSearchOption,
            this.barButtonItem4,
            this.barStaticItem3,
            this.barStaticItem4,
            this.fld_barckeSearchResults});
            this.fld_brmToolbarManager.MainMenu = this.BarMenu;
            this.fld_brmToolbarManager.MaxItemId = 142;
            this.fld_brmToolbarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemTextEdit2});
            // 
            // BarMenu
            // 
            this.BarMenu.BarName = "Menu";
            this.BarMenu.DockCol = 0;
            this.BarMenu.DockRow = 0;
            this.BarMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemMenuFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemMenuUtility),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubMenuItemExtra),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubMenuItemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubMenuItemStyle),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.BarMenu.OptionsBar.MultiLine = true;
            this.BarMenu.OptionsBar.UseWholeRow = true;
            this.BarMenu.Text = "Menu";
            // 
            // barSubItemMenuFile
            // 
            this.barSubItemMenuFile.Caption = "File";
            this.barSubItemMenuFile.Id = 76;
            this.barSubItemMenuFile.Name = "barSubItemMenuFile";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "View";
            this.barSubItem3.Id = 106;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barckeSearchOption),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barckeSearchResults)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // fld_barckeSearchOption
            // 
            this.fld_barckeSearchOption.Caption = "Search Option";
            this.fld_barckeSearchOption.Id = 134;
            this.fld_barckeSearchOption.Name = "fld_barckeSearchOption";
            // 
            // fld_barckeSearchResults
            // 
            this.fld_barckeSearchResults.Caption = "Search Results";
            this.fld_barckeSearchResults.Id = 140;
            this.fld_barckeSearchResults.Name = "fld_barckeSearchResults";
            // 
            // barSubItemMenuUtility
            // 
            this.barSubItemMenuUtility.Caption = "Utility";
            this.barSubItemMenuUtility.Id = 77;
            this.barSubItemMenuUtility.Name = "barSubItemMenuUtility";
            // 
            // barSubMenuItemExtra
            // 
            this.barSubMenuItemExtra.Caption = "Extra";
            this.barSubMenuItemExtra.Id = 80;
            this.barSubMenuItemExtra.Name = "barSubMenuItemExtra";
            // 
            // barSubMenuItemInfo
            // 
            this.barSubMenuItemInfo.Caption = "Info";
            this.barSubMenuItemInfo.Id = 79;
            this.barSubMenuItemInfo.Name = "barSubMenuItemInfo";
            // 
            // barSubMenuItemStyle
            // 
            this.barSubMenuItemStyle.Caption = "Style";
            this.barSubMenuItemStyle.Id = 81;
            this.barSubMenuItemStyle.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleOffice2003),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleFlat),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleStyle3D),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemStyleSkin)});
            this.barSubMenuItemStyle.Name = "barSubMenuItemStyle";
            // 
            // fld_barCheckStyleOffice2003
            // 
            this.fld_barCheckStyleOffice2003.Caption = "Office 2003";
            this.fld_barCheckStyleOffice2003.GroupIndex = 1;
            this.fld_barCheckStyleOffice2003.Id = 87;
            this.fld_barCheckStyleOffice2003.Name = "fld_barCheckStyleOffice2003";
            this.fld_barCheckStyleOffice2003.Tag = "Office2003";
            this.fld_barCheckStyleOffice2003.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemBarCheckStyle_ItemClick);
            // 
            // fld_barCheckStyleFlat
            // 
            this.fld_barCheckStyleFlat.Caption = "Flat";
            this.fld_barCheckStyleFlat.GroupIndex = 1;
            this.fld_barCheckStyleFlat.Id = 88;
            this.fld_barCheckStyleFlat.Name = "fld_barCheckStyleFlat";
            this.fld_barCheckStyleFlat.Tag = "Flat";
            this.fld_barCheckStyleFlat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemBarCheckStyle_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Ultra Flat";
            this.barCheckItem1.GroupIndex = 1;
            this.barCheckItem1.Id = 89;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.Tag = "UltraFlat";
            this.barCheckItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemBarCheckStyle_ItemClick);
            // 
            // fld_barCheckStyleStyle3D
            // 
            this.fld_barCheckStyleStyle3D.Caption = "Style 3D";
            this.fld_barCheckStyleStyle3D.GroupIndex = 1;
            this.fld_barCheckStyleStyle3D.Id = 90;
            this.fld_barCheckStyleStyle3D.Name = "fld_barCheckStyleStyle3D";
            this.fld_barCheckStyleStyle3D.Tag = "Style3D";
            this.fld_barCheckStyleStyle3D.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemBarCheckStyle_ItemClick);
            // 
            // barSubItemStyleSkin
            // 
            this.barSubItemStyleSkin.Caption = "Skin";
            this.barSubItemStyleSkin.Id = 94;
            this.barSubItemStyleSkin.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinCaramel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinMoneyTwins),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinLilian),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinTheAsphaltWorld),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkiniMaginary),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinBlack),
            new DevExpress.XtraBars.LinkPersistInfo(this.fld_barCheckStyleSkinBlue)});
            this.barSubItemStyleSkin.Name = "barSubItemStyleSkin";
            // 
            // fld_barCheckStyleSkinCaramel
            // 
            this.fld_barCheckStyleSkinCaramel.Caption = "Caramel";
            this.fld_barCheckStyleSkinCaramel.GroupIndex = 1;
            this.fld_barCheckStyleSkinCaramel.Id = 95;
            this.fld_barCheckStyleSkinCaramel.Name = "fld_barCheckStyleSkinCaramel";
            this.fld_barCheckStyleSkinCaramel.Tag = "Caramel";
            this.fld_barCheckStyleSkinCaramel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkinMoneyTwins
            // 
            this.fld_barCheckStyleSkinMoneyTwins.Caption = "Money Twins";
            this.fld_barCheckStyleSkinMoneyTwins.GroupIndex = 1;
            this.fld_barCheckStyleSkinMoneyTwins.Id = 101;
            this.fld_barCheckStyleSkinMoneyTwins.Name = "fld_barCheckStyleSkinMoneyTwins";
            this.fld_barCheckStyleSkinMoneyTwins.Tag = "Money Twins";
            this.fld_barCheckStyleSkinMoneyTwins.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkinLilian
            // 
            this.fld_barCheckStyleSkinLilian.Caption = "Lilian";
            this.fld_barCheckStyleSkinLilian.GroupIndex = 1;
            this.fld_barCheckStyleSkinLilian.Id = 127;
            this.fld_barCheckStyleSkinLilian.Name = "fld_barCheckStyleSkinLilian";
            this.fld_barCheckStyleSkinLilian.Tag = "Lilian";
            this.fld_barCheckStyleSkinLilian.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkinTheAsphaltWorld
            // 
            this.fld_barCheckStyleSkinTheAsphaltWorld.Caption = "The Asphalt World";
            this.fld_barCheckStyleSkinTheAsphaltWorld.GroupIndex = 1;
            this.fld_barCheckStyleSkinTheAsphaltWorld.Id = 96;
            this.fld_barCheckStyleSkinTheAsphaltWorld.Name = "fld_barCheckStyleSkinTheAsphaltWorld";
            this.fld_barCheckStyleSkinTheAsphaltWorld.Tag = "The Asphalt World";
            this.fld_barCheckStyleSkinTheAsphaltWorld.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkiniMaginary
            // 
            this.fld_barCheckStyleSkiniMaginary.Caption = "iMaginary";
            this.fld_barCheckStyleSkiniMaginary.GroupIndex = 1;
            this.fld_barCheckStyleSkiniMaginary.Id = 132;
            this.fld_barCheckStyleSkiniMaginary.Name = "fld_barCheckStyleSkiniMaginary";
            this.fld_barCheckStyleSkiniMaginary.Tag = "iMaginary";
            this.fld_barCheckStyleSkiniMaginary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkinBlack
            // 
            this.fld_barCheckStyleSkinBlack.Caption = "Black";
            this.fld_barCheckStyleSkinBlack.GroupIndex = 1;
            this.fld_barCheckStyleSkinBlack.Id = 130;
            this.fld_barCheckStyleSkinBlack.Name = "fld_barCheckStyleSkinBlack";
            this.fld_barCheckStyleSkinBlack.Tag = "Black";
            this.fld_barCheckStyleSkinBlack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // fld_barCheckStyleSkinBlue
            // 
            this.fld_barCheckStyleSkinBlue.Caption = "Blue";
            this.fld_barCheckStyleSkinBlue.GroupIndex = 1;
            this.fld_barCheckStyleSkinBlue.Id = 131;
            this.fld_barCheckStyleSkinBlue.Name = "fld_barCheckStyleSkinBlue";
            this.fld_barCheckStyleSkinBlue.Tag = "Blue";
            this.fld_barCheckStyleSkinBlue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemCheckStyleSkin_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Help";
            this.barSubItem2.Id = 102;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.fld_brmToolbarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1166, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Manager = this.fld_brmToolbarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1166, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.fld_brmToolbarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1166, 22);
            this.barDockControlRight.Manager = this.fld_brmToolbarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
            // 
            // fld_barmnbContents
            // 
            this.fld_barmnbContents.Caption = "&Contents";
            this.fld_barmnbContents.Id = 30;
            this.fld_barmnbContents.Name = "fld_barmnbContents";
            // 
            // fld_barmnbSystemInfo
            // 
            this.fld_barmnbSystemInfo.Caption = "&System Info...";
            this.fld_barmnbSystemInfo.Id = 31;
            this.fld_barmnbSystemInfo.Name = "fld_barmnbSystemInfo";
            // 
            // fld_barmnbLicenses
            // 
            this.fld_barmnbLicenses.Caption = "&Licences";
            this.fld_barmnbLicenses.Id = 32;
            this.fld_barmnbLicenses.Name = "fld_barmnbLicenses";
            // 
            // fld_barmnbAbout
            // 
            this.fld_barmnbAbout.Caption = "&About BOS";
            this.fld_barmnbAbout.Id = 33;
            this.fld_barmnbAbout.Name = "fld_barmnbAbout";
            // 
            // fld_barmnuOpenCompany
            // 
            this.fld_barmnuOpenCompany.Caption = "&Open Company";
            this.fld_barmnuOpenCompany.Id = 60;
            this.fld_barmnuOpenCompany.Name = "fld_barmnuOpenCompany";
            // 
            // fld_barmnuCloseCompany
            // 
            this.fld_barmnuCloseCompany.Caption = "&Close Company";
            this.fld_barmnuCloseCompany.Id = 61;
            this.fld_barmnuCloseCompany.Name = "fld_barmnuCloseCompany";
            // 
            // fld_barmnuLogOff
            // 
            this.fld_barmnuLogOff.Caption = "&Log Off";
            this.fld_barmnuLogOff.Id = 62;
            this.fld_barmnuLogOff.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.fld_barmnuLogOff.Name = "fld_barmnuLogOff";
            // 
            // fld_barmnuExit
            // 
            this.fld_barmnuExit.Caption = "&Exit";
            this.fld_barmnuExit.Id = 63;
            this.fld_barmnuExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.fld_barmnuExit.Name = "fld_barmnuExit";
            // 
            // fld_mnubarbtnSectionExplorer
            // 
            this.fld_mnubarbtnSectionExplorer.Caption = "Section Explorer";
            this.fld_mnubarbtnSectionExplorer.Id = 66;
            this.fld_mnubarbtnSectionExplorer.Name = "fld_mnubarbtnSectionExplorer";
            // 
            // fld_mnubarbtnSearchExplorer
            // 
            this.fld_mnubarbtnSearchExplorer.Caption = "Search Explorer";
            this.fld_mnubarbtnSearchExplorer.Id = 67;
            this.fld_mnubarbtnSearchExplorer.Name = "fld_mnubarbtnSearchExplorer";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Test New";
            this.barButtonItem1.Id = 70;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File";
            this.barSubItem1.Id = 75;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // fld_barbtnProductInventoryInformation
            // 
            this.fld_barbtnProductInventoryInformation.Caption = "Stock Information";
            this.fld_barbtnProductInventoryInformation.Id = 107;
            this.fld_barbtnProductInventoryInformation.Name = "fld_barbtnProductInventoryInformation";
            this.fld_barbtnProductInventoryInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // fld_barbtnProductSerieInventoryInformation
            // 
            this.fld_barbtnProductSerieInventoryInformation.Caption = "Serie Information";
            this.fld_barbtnProductSerieInventoryInformation.Id = 108;
            this.fld_barbtnProductSerieInventoryInformation.Name = "fld_barbtnProductSerieInventoryInformation";
            this.fld_barbtnProductSerieInventoryInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // fld_barbtnSummaryInformation
            // 
            this.fld_barbtnSummaryInformation.Caption = "Search Results";
            this.fld_barbtnSummaryInformation.Id = 109;
            this.fld_barbtnSummaryInformation.Name = "fld_barbtnSummaryInformation";
            this.fld_barbtnSummaryInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // fld_barbtnSection
            // 
            this.fld_barbtnSection.Caption = "Section";
            this.fld_barbtnSection.Id = 110;
            this.fld_barbtnSection.Name = "fld_barbtnSection";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Test";
            this.barButtonItem2.Id = 111;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Test1";
            this.barButtonItem3.Id = 112;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem1.Id = 113;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.Size = new System.Drawing.Size(32, 0);
            this.barStaticItem1.Width = 32;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 135;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.barStaticItem3.Id = 137;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.Size = new System.Drawing.Size(300, 0);
            this.barStaticItem3.Width = 300;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.barStaticItem4.Id = 138;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.Size = new System.Drawing.Size(300, 0);
            this.barStaticItem4.Width = 300;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // dockManager
            // 
            this.dockManager.Controller = this.barAndDockingController1;
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.fld_pnlLeftPanelContainer});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.TableLayoutPanel",
            "System.Windows.Forms.StatusBar"});
            // 
            // fld_pnlLeftPanelContainer
            // 
            this.fld_pnlLeftPanelContainer.ActiveChild = this.dockSearchResultsPanel;
            this.fld_pnlLeftPanelContainer.Controls.Add(this.dockPanelInventory);
            this.fld_pnlLeftPanelContainer.Controls.Add(this.dockSearchResultsPanel);
            this.fld_pnlLeftPanelContainer.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.fld_pnlLeftPanelContainer.FloatSize = new System.Drawing.Size(200, 613);
            this.fld_pnlLeftPanelContainer.FloatVertical = true;
            this.fld_pnlLeftPanelContainer.ID = new System.Guid("29b9935e-68c5-45ff-8f44-1376fb57c40b");
            this.fld_pnlLeftPanelContainer.Location = new System.Drawing.Point(0, 22);
            this.fld_pnlLeftPanelContainer.Name = "fld_pnlLeftPanelContainer";
            this.fld_pnlLeftPanelContainer.OriginalSize = new System.Drawing.Size(279, 511);
            this.fld_pnlLeftPanelContainer.Size = new System.Drawing.Size(279, 563);
            this.fld_pnlLeftPanelContainer.Tabbed = true;
            this.fld_pnlLeftPanelContainer.Text = "panelContainer1";
            // 
            // dockSearchResultsPanel
            // 
            this.dockSearchResultsPanel.Controls.Add(this.dockPanelSearchResults_Container);
            this.dockSearchResultsPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockSearchResultsPanel.FloatSize = new System.Drawing.Size(200, 613);
            this.dockSearchResultsPanel.FloatVertical = true;
            this.dockSearchResultsPanel.ID = new System.Guid("59031682-0182-43c1-9b04-b47fb12839ec");
            this.dockSearchResultsPanel.Location = new System.Drawing.Point(4, 23);
            this.dockSearchResultsPanel.Name = "dockSearchResultsPanel";
            this.dockSearchResultsPanel.Options.ShowCloseButton = false;
            this.dockSearchResultsPanel.OriginalSize = new System.Drawing.Size(273, 511);
            this.dockSearchResultsPanel.Size = new System.Drawing.Size(270, 509);
            this.dockSearchResultsPanel.Text = "Danh sách đối tượng";
            // 
            // dockPanelSearchResults_Container
            // 
            this.dockPanelSearchResults_Container.Controls.Add(this.fld_btnExpandObjectList);
            this.dockPanelSearchResults_Container.Controls.Add(this.fld_pnlSearchResults);
            this.dockPanelSearchResults_Container.Controls.Add(this.fld_drdbtnCreateCriteria);
            this.dockPanelSearchResults_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanelSearchResults_Container.Name = "dockPanelSearchResults_Container";
            this.dockPanelSearchResults_Container.Size = new System.Drawing.Size(270, 509);
            this.dockPanelSearchResults_Container.TabIndex = 0;
            // 
            // fld_btnExpandObjectList
            // 
            this.fld_btnExpandObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExpandObjectList.BOSComment = null;
            this.fld_btnExpandObjectList.BOSDataMember = null;
            this.fld_btnExpandObjectList.BOSDataSource = null;
            this.fld_btnExpandObjectList.BOSDescription = null;
            this.fld_btnExpandObjectList.BOSError = null;
            this.fld_btnExpandObjectList.BOSFieldGroup = null;
            this.fld_btnExpandObjectList.BOSFieldRelation = null;
            this.fld_btnExpandObjectList.BOSPrivilege = null;
            this.fld_btnExpandObjectList.BOSPropertyName = null;
            this.fld_btnExpandObjectList.Location = new System.Drawing.Point(218, 0);
            this.fld_btnExpandObjectList.Name = "fld_btnExpandObjectList";
            this.fld_btnExpandObjectList.Screen = null;
            this.fld_btnExpandObjectList.Size = new System.Drawing.Size(51, 23);
            this.fld_btnExpandObjectList.TabIndex = 2;
            this.fld_btnExpandObjectList.Text = ">>";
            this.fld_btnExpandObjectList.Click += new System.EventHandler(this.fld_btnExpandObjectList_Click);
            // 
            // fld_pnlSearchResults
            // 
            this.fld_pnlSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlSearchResults.Location = new System.Drawing.Point(0, 23);
            this.fld_pnlSearchResults.Name = "fld_pnlSearchResults";
            this.fld_pnlSearchResults.Size = new System.Drawing.Size(270, 486);
            this.fld_pnlSearchResults.TabIndex = 1;
            // 
            // fld_drdbtnCreateCriteria
            // 
            this.fld_drdbtnCreateCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_drdbtnCreateCriteria.Location = new System.Drawing.Point(0, 0);
            this.fld_drdbtnCreateCriteria.MenuManager = this.fld_brmToolbarManager;
            this.fld_drdbtnCreateCriteria.Name = "fld_drdbtnCreateCriteria";
            this.fld_drdbtnCreateCriteria.Size = new System.Drawing.Size(216, 23);
            this.fld_drdbtnCreateCriteria.TabIndex = 0;
            this.fld_drdbtnCreateCriteria.Text = "Tìm kiếm nâng cao";
            this.fld_drdbtnCreateCriteria.Click += new System.EventHandler(this.fld_drdbtnCreateCriteria_Click);
            // 
            // dockPanelInventory
            // 
            this.dockPanelInventory.Controls.Add(this.dockPanel1_Container);
            this.dockPanelInventory.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanelInventory.FloatVertical = true;
            this.dockPanelInventory.ID = new System.Guid("5b2a94c6-4109-40f8-a926-805582968889");
            this.dockPanelInventory.Location = new System.Drawing.Point(4, 23);
            this.dockPanelInventory.Name = "dockPanelInventory";
            this.dockPanelInventory.Options.ShowCloseButton = false;
            this.dockPanelInventory.OriginalSize = new System.Drawing.Size(273, 511);
            this.dockPanelInventory.Size = new System.Drawing.Size(270, 509);
            this.dockPanelInventory.Text = "Thông tin giao dịch đi kèm";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.panelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(270, 509);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_pnlInventory);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(270, 509);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_pnlInventory
            // 
            this.fld_pnlInventory.BOSComment = null;
            this.fld_pnlInventory.BOSDataMember = null;
            this.fld_pnlInventory.BOSDataSource = null;
            this.fld_pnlInventory.BOSDescription = null;
            this.fld_pnlInventory.BOSError = null;
            this.fld_pnlInventory.BOSFieldGroup = null;
            this.fld_pnlInventory.BOSFieldRelation = null;
            this.fld_pnlInventory.BOSPrivilege = null;
            this.fld_pnlInventory.BOSPropertyName = null;
            this.fld_pnlInventory.Controls.Add(this.fld_lnkICInventoryStockTransitInQuantity);
            this.fld_pnlInventory.Controls.Add(this.fld_lnkICInventoryStockTransitOutQuantity);
            this.fld_pnlInventory.Controls.Add(this.fld_lnkICInventoryStockPurchaseOrderQuantity);
            this.fld_pnlInventory.Controls.Add(this.fld_lnkICInventoryStockSaleOrderQuantity);
            this.fld_pnlInventory.Controls.Add(this.fld_lnkICInventoryStockQuantity);
            this.fld_pnlInventory.Controls.Add(this.BOSLabel4);
            this.fld_pnlInventory.Controls.Add(this.BOSLabel5);
            this.fld_pnlInventory.Controls.Add(this.BOSLabel9);
            this.fld_pnlInventory.Controls.Add(this.BOSLabel2);
            this.fld_pnlInventory.Controls.Add(this.bosLabel11);
            this.fld_pnlInventory.Controls.Add(this.bosLabel1);
            this.fld_pnlInventory.Controls.Add(this.BOSLabel3);
            this.fld_pnlInventory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_pnlInventory.Location = new System.Drawing.Point(5, 6);
            this.fld_pnlInventory.Name = "fld_pnlInventory";
            this.fld_pnlInventory.Screen = null;
            this.fld_pnlInventory.Size = new System.Drawing.Size(213, 228);
            this.fld_pnlInventory.TabIndex = 0;
            this.fld_pnlInventory.TabStop = false;
            this.fld_pnlInventory.Text = "Tồn kho";
            // 
            // fld_lnkICInventoryStockTransitInQuantity
            // 
            this.fld_lnkICInventoryStockTransitInQuantity.BOSComment = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSDataMember = "ICInventoryStockTransitInQuantity";
            this.fld_lnkICInventoryStockTransitInQuantity.BOSDataSource = "ICProducts";
            this.fld_lnkICInventoryStockTransitInQuantity.BOSDescription = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSError = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSFieldGroup = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSFieldRelation = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSPrivilege = null;
            this.fld_lnkICInventoryStockTransitInQuantity.BOSPropertyName = null;
            this.fld_lnkICInventoryStockTransitInQuantity.EditValue = "0";
            this.fld_lnkICInventoryStockTransitInQuantity.Location = new System.Drawing.Point(144, 168);
            this.fld_lnkICInventoryStockTransitInQuantity.Name = "fld_lnkICInventoryStockTransitInQuantity";
            this.fld_lnkICInventoryStockTransitInQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkICInventoryStockTransitInQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkICInventoryStockTransitInQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkICInventoryStockTransitInQuantity.Screen = null;
            this.fld_lnkICInventoryStockTransitInQuantity.Size = new System.Drawing.Size(63, 18);
            this.fld_lnkICInventoryStockTransitInQuantity.TabIndex = 1;
            this.fld_lnkICInventoryStockTransitInQuantity.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkICInventoryStockTransitInQuantity_OpenLink);
            // 
            // fld_lnkICInventoryStockTransitOutQuantity
            // 
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSComment = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSDataMember = "ICInventoryStockTransitOutQuantity";
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSDataSource = "ICProducts";
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSDescription = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSError = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSFieldGroup = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSFieldRelation = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSPrivilege = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.BOSPropertyName = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.EditValue = "0";
            this.fld_lnkICInventoryStockTransitOutQuantity.Location = new System.Drawing.Point(144, 139);
            this.fld_lnkICInventoryStockTransitOutQuantity.Name = "fld_lnkICInventoryStockTransitOutQuantity";
            this.fld_lnkICInventoryStockTransitOutQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkICInventoryStockTransitOutQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkICInventoryStockTransitOutQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkICInventoryStockTransitOutQuantity.Screen = null;
            this.fld_lnkICInventoryStockTransitOutQuantity.Size = new System.Drawing.Size(63, 18);
            this.fld_lnkICInventoryStockTransitOutQuantity.TabIndex = 1;
            this.fld_lnkICInventoryStockTransitOutQuantity.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkICInventoryStockTransitOutQuantity_OpenLink);
            // 
            // fld_lnkICInventoryStockPurchaseOrderQuantity
            // 
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSComment = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSDataMember = "ICInventoryStockPurchaseOrderQuantity";
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSDataSource = "ICProducts";
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSDescription = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSError = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSFieldGroup = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSFieldRelation = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSPrivilege = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.BOSPropertyName = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.EditValue = "0";
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Location = new System.Drawing.Point(144, 109);
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Name = "fld_lnkICInventoryStockPurchaseOrderQuantity";
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Screen = null;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.Size = new System.Drawing.Size(63, 18);
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.TabIndex = 1;
            this.fld_lnkICInventoryStockPurchaseOrderQuantity.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkICInventoryStockPurchaseOrderQuantity_OpenLink);
            // 
            // fld_lnkICInventoryStockSaleOrderQuantity
            // 
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSComment = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSDataMember = "ICInventoryStockSaleOrderQuantity";
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSDataSource = "ICProducts";
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSDescription = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSError = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSFieldGroup = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSFieldRelation = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSPrivilege = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.BOSPropertyName = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.EditValue = "0";
            this.fld_lnkICInventoryStockSaleOrderQuantity.Location = new System.Drawing.Point(144, 48);
            this.fld_lnkICInventoryStockSaleOrderQuantity.Name = "fld_lnkICInventoryStockSaleOrderQuantity";
            this.fld_lnkICInventoryStockSaleOrderQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkICInventoryStockSaleOrderQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkICInventoryStockSaleOrderQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkICInventoryStockSaleOrderQuantity.Screen = null;
            this.fld_lnkICInventoryStockSaleOrderQuantity.Size = new System.Drawing.Size(63, 18);
            this.fld_lnkICInventoryStockSaleOrderQuantity.TabIndex = 1;
            this.fld_lnkICInventoryStockSaleOrderQuantity.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkICInventoryStockSaleOrderQuantity_OpenLink);
            // 
            // fld_lnkICInventoryStockQuantity
            // 
            this.fld_lnkICInventoryStockQuantity.BOSComment = null;
            this.fld_lnkICInventoryStockQuantity.BOSDataMember = "ICInventoryStockQuantity";
            this.fld_lnkICInventoryStockQuantity.BOSDataSource = "ICProducts";
            this.fld_lnkICInventoryStockQuantity.BOSDescription = null;
            this.fld_lnkICInventoryStockQuantity.BOSError = null;
            this.fld_lnkICInventoryStockQuantity.BOSFieldGroup = null;
            this.fld_lnkICInventoryStockQuantity.BOSFieldRelation = null;
            this.fld_lnkICInventoryStockQuantity.BOSPrivilege = null;
            this.fld_lnkICInventoryStockQuantity.BOSPropertyName = null;
            this.fld_lnkICInventoryStockQuantity.EditValue = "0";
            this.fld_lnkICInventoryStockQuantity.Location = new System.Drawing.Point(144, 17);
            this.fld_lnkICInventoryStockQuantity.MenuManager = this.fld_brmToolbarManager;
            this.fld_lnkICInventoryStockQuantity.Name = "fld_lnkICInventoryStockQuantity";
            this.fld_lnkICInventoryStockQuantity.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkICInventoryStockQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkICInventoryStockQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkICInventoryStockQuantity.Screen = null;
            this.fld_lnkICInventoryStockQuantity.Size = new System.Drawing.Size(63, 18);
            this.fld_lnkICInventoryStockQuantity.TabIndex = 1;
            this.fld_lnkICInventoryStockQuantity.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkICInventoryStockQuantity_OpenLink);
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(16, 20);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(79, 13);
            this.BOSLabel4.TabIndex = 0;
            this.BOSLabel4.Text = "Số lượng hiện có";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel5.Appearance.Options.UseFont = true;
            this.BOSLabel5.BOSComment = null;
            this.BOSLabel5.BOSDataMember = null;
            this.BOSLabel5.BOSDataSource = null;
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = null;
            this.BOSLabel5.BOSFieldRelation = null;
            this.BOSLabel5.BOSPrivilege = null;
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(16, 81);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(111, 13);
            this.BOSLabel5.TabIndex = 0;
            this.BOSLabel5.Text = "Số lượng có thể bán";
            // 
            // BOSLabel9
            // 
            this.BOSLabel9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel9.Appearance.Options.UseFont = true;
            this.BOSLabel9.BOSComment = null;
            this.BOSLabel9.BOSDataMember = "ICInventoryStockAvailableQuantity";
            this.BOSLabel9.BOSDataSource = "ICProducts";
            this.BOSLabel9.BOSDescription = null;
            this.BOSLabel9.BOSError = null;
            this.BOSLabel9.BOSFieldGroup = null;
            this.BOSLabel9.BOSFieldRelation = null;
            this.BOSLabel9.BOSPrivilege = null;
            this.BOSLabel9.BOSPropertyName = null;
            this.BOSLabel9.Location = new System.Drawing.Point(144, 81);
            this.BOSLabel9.Name = "BOSLabel9";
            this.BOSLabel9.Screen = null;
            this.BOSLabel9.Size = new System.Drawing.Size(7, 13);
            this.BOSLabel9.TabIndex = 0;
            this.BOSLabel9.Text = "0";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(16, 50);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(88, 13);
            this.BOSLabel2.TabIndex = 0;
            this.BOSLabel2.Text = "Số lượng nợ khách";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(16, 170);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(84, 13);
            this.bosLabel11.TabIndex = 0;
            this.bosLabel11.Text = "Số lượng hàng về";
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
            this.bosLabel1.Location = new System.Drawing.Point(16, 141);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(80, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Số lượng hàng đi";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(16, 111);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(84, 13);
            this.BOSLabel3.TabIndex = 0;
            this.BOSLabel3.Text = "Số lượng đặt mua";
            // 
            // popupMenuToolbar
            // 
            this.popupMenuToolbar.Manager = this.fld_brmToolbarManager;
            this.popupMenuToolbar.Name = "popupMenuToolbar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 2";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 2";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 2";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 2";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Custom 2";
            // 
            // bar5
            // 
            this.bar5.BarName = "Custom 2";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Custom 2";
            // 
            // bar6
            // 
            this.bar6.BarName = "Custom 2";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Custom 2";
            // 
            // bar7
            // 
            this.bar7.BarName = "Custom 2";
            this.bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Custom 2";
            // 
            // bar8
            // 
            this.bar8.BarName = "Custom 2";
            this.bar8.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar8.OptionsBar.AllowQuickCustomization = false;
            this.bar8.OptionsBar.DrawDragBorder = false;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Custom 2";
            // 
            // bar9
            // 
            this.bar9.BarName = "Custom 2";
            this.bar9.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar9.OptionsBar.AllowQuickCustomization = false;
            this.bar9.OptionsBar.DrawDragBorder = false;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Custom 2";
            // 
            // fld_lblTemplateProgressText
            // 
            this.fld_lblTemplateProgressText.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.fld_lblTemplateProgressText.Appearance.Options.UseBackColor = true;
            this.fld_lblTemplateProgressText.Location = new System.Drawing.Point(374, 698);
            this.fld_lblTemplateProgressText.Name = "fld_lblTemplateProgressText";
            this.fld_lblTemplateProgressText.Size = new System.Drawing.Size(0, 13);
            this.fld_lblTemplateProgressText.TabIndex = 19;
            this.fld_lblTemplateProgressText.Visible = false;
            // 
            // fld_tabScreenContainer
            // 
            this.fld_tabScreenContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabScreenContainer.Location = new System.Drawing.Point(279, 22);
            this.fld_tabScreenContainer.Name = "fld_tabScreenContainer";
            this.fld_tabScreenContainer.Size = new System.Drawing.Size(887, 563);
            this.fld_tabScreenContainer.TabIndex = 28;
            this.fld_tabScreenContainer.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabScreenContainer_SelectedPageChanged);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Location = new System.Drawing.Point(232, 433);
            this.popupControlContainer1.Manager = this.fld_brmToolbarManager;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(537, 176);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            // 
            // fld_popCriteriaName
            // 
            this.fld_popCriteriaName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_popCriteriaName.Controls.Add(this.fld_dgcADCriterias);
            this.fld_popCriteriaName.Location = new System.Drawing.Point(6, 240);
            this.fld_popCriteriaName.Name = "fld_popCriteriaName";
            this.fld_popCriteriaName.ShowCloseButton = true;
            this.fld_popCriteriaName.Size = new System.Drawing.Size(400, 150);
            this.fld_popCriteriaName.TabIndex = 0;
            this.fld_popCriteriaName.Visible = false;
            // 
            // fld_dgcADCriterias
            // 
            this.fld_dgcADCriterias.BOSComment = null;
            this.fld_dgcADCriterias.BOSDataMember = null;
            this.fld_dgcADCriterias.BOSDataSource = "ADCriterias";
            this.fld_dgcADCriterias.BOSDescription = null;
            this.fld_dgcADCriterias.BOSError = null;
            this.fld_dgcADCriterias.BOSFieldGroup = null;
            this.fld_dgcADCriterias.BOSFieldRelation = null;
            this.fld_dgcADCriterias.BOSGridType = null;
            this.fld_dgcADCriterias.BOSPrivilege = null;
            this.fld_dgcADCriterias.BOSPropertyName = null;
            this.fld_dgcADCriterias.CommodityType = "";
            this.fld_dgcADCriterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcADCriterias.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcADCriterias.MenuManager = this.fld_brmToolbarManager;
            this.fld_dgcADCriterias.Name = "fld_dgcADCriterias";
            this.fld_dgcADCriterias.PrintReport = false;
            this.fld_dgcADCriterias.Screen = null;
            this.fld_dgcADCriterias.Size = new System.Drawing.Size(400, 150);
            this.fld_dgcADCriterias.TabIndex = 0;
            this.fld_dgcADCriterias.Tag = "DC";
            // 
            // ModuleParentScreen
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(1166, 585);
            this.Controls.Add(this.fld_tabScreenContainer);
            this.Controls.Add(this.fld_lblTemplateProgressText);
            this.Controls.Add(this.fld_pnlLeftPanelContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModuleParentScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BOS ERP";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ModuleParentScreen_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModuleParentScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModuleParentScreen_FormClosed);
            this.Load += new System.EventHandler(this.ModuleParentScreen_Load);
            this.SizeChanged += new System.EventHandler(this.ModuleParentScreen_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModuleParentScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModuleParentScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.fld_brmToolbarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.fld_pnlLeftPanelContainer.ResumeLayout(false);
            this.dockSearchResultsPanel.ResumeLayout(false);
            this.dockPanelSearchResults_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnlSearchResults)).EndInit();
            this.dockPanelInventory.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.fld_pnlInventory.ResumeLayout(false);
            this.fld_pnlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockTransitInQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockTransitOutQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockPurchaseOrderQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockSaleOrderQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkICInventoryStockQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuToolbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_popCriteriaName)).EndInit();
            this.fld_popCriteriaName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADCriterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the module that the screen belongs to
        /// </summary>
        public BaseModuleERP Module { get; set; }

        public DevExpress.XtraBars.BarManager ToolbarManager
        {
            get
            {
                return fld_brmToolbarManager;
            }

            set
            {
                fld_brmToolbarManager = value;
            }
        }

        public DevExpress.XtraEditors.LabelControl TemplateProgressText
        {
            get
            {
                return fld_lblTemplateProgressText;
            }
            set
            {
                fld_lblTemplateProgressText = value;
            }
        }

        /// <summary>
        /// Gets the left panel container
        /// </summary>
        public DockPanel LeftPanelContainer
        {
            get
            {
                return fld_pnlLeftPanelContainer;
            }
        }

        public DevExpress.XtraTab.XtraTabControl ScreenContainer
        {
            get
            {
                return fld_tabScreenContainer;
            }
            set
            {
                fld_tabScreenContainer = value;
            }
        }

        public DevExpress.XtraBars.Docking.DockPanel SearchContainer
        {
            get { return dockSearchResultsPanel; }
        }

        public DevExpress.XtraEditors.PanelControl SearchResultsContainer
        {
            get { return fld_pnlSearchResults; }
            set { fld_pnlSearchResults = value; }
        }

        public DevExpress.XtraEditors.DropDownButton ButtonCreateCriteria
        {
            get { return fld_drdbtnCreateCriteria; }
            set { fld_drdbtnCreateCriteria = value; }
        }

        public DevExpress.XtraBars.PopupControlContainer ModuleUserCriteriaContainer
        {
            get { return fld_popCriteriaName; }
            set { fld_popCriteriaName = value; }
        }

        public ADCriterasGridControl GridModuleUserCriteria
        {
            get { return fld_dgcADCriterias; }
            set { fld_dgcADCriterias = value; }
        }

        public DockPanel InventoryContainer
        {
            get { return dockPanelInventory; }
        }

        public BOSLine InventoryPanel
        {
            get { return fld_pnlInventory; }
        }

        /// <summary>
        /// Gets or sets a value indicates whether the object list is expanded
        /// </summary>
        public bool IsObjectListExpanded { get; set; }
        #endregion

        #region "Init Toolbar Group"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strToolbarGroup"></param>
        /// <returns></returns>
        /// 
        public virtual DevExpress.XtraBars.BarItem[] InitToolbarButtonsForToolbar(String strToolbarGroup, ref List<DevExpress.XtraBars.BarItem> arrToolbarHasParent)
        {
            Dictionary<int, int> lstParentToolbar = new Dictionary<int, int>();
            DevExpress.XtraBars.BarItem[] btnToolbar = new DevExpress.XtraBars.BarItem[0];
            try
            {
                if ((Module.ModuleID > 0) && (BOSApp.CurrentUserGroupInfo.ADUserGroupID > 0))
                {
                    List<STToolbarsInfo> listToolbars = BOSApp.ListToolbar.Where(t => t.STModuleID == Module.ModuleID
                                                                                        && t.STUserGroupID == 1
                                                                                        && t.STToolbarGroup == strToolbarGroup).ToList();
                    if (listToolbars != null && listToolbars.Count > 0)
                    {
                        if (listToolbars.Count > 0)
                        {
                            Array.Resize(ref btnToolbar, (int)listToolbars.Count);
                            for (int i = 0; i < listToolbars.Count; i++)
                            {
                                STToolbarsInfo objSTToolbarsInfo = listToolbars[i];

                                //Check toolbar has child or not
                                List<STToolbarsInfo> listParent = BOSApp.ListToolbar.Where(t => t.STToolbarParentID == objSTToolbarsInfo.STToolbarID).ToList();
                                //DataSet ds = objSTToolbarsController.GetAllObjectsByObjectParentID(objSTToolbarsInfo.STToolbarID);
                                if (listParent == null || listParent.Count == 0)
                                {
                                    btnToolbar[i] = new DevExpress.XtraBars.BarButtonItem();
                                    //(btnToolbar[i] as DevExpress.XtraBars.BarButtonItem).ButtonStyle = GetButtonStyle(objSTToolbarsInfo.STToolbarStyle);
                                }
                                else
                                {
                                    btnToolbar[i] = new DevExpress.XtraBars.BarSubItem();
                                    lstParentToolbar.Add(objSTToolbarsInfo.STToolbarID, i);
                                }

                                btnToolbar[i].Name = objSTToolbarsInfo.STToolbarName;
                                btnToolbar[i].Tag = objSTToolbarsInfo.STToolbarTag;

                                btnToolbar[i].Caption = objSTToolbarsInfo.STToolbarCaption;
                                btnToolbar[i].Description = objSTToolbarsInfo.STToolbarDesc;

                                if (btnToolbar[i].Tag.ToString() == BaseToolbar.ToolbarButtonError)
                                    btnToolbar[i].Enabled = false;

                                //Visble/enable control base on permission
                                STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();

                                STFieldPermissionsInfo objFieldPermissionsInfo = BOSApp.LstFieldPermission.Where(f => f.STModuleName == Module.Name
                                                                                                                    && f.STToolbarName == objSTToolbarsInfo.STToolbarName
                                                                                                                    && f.FK_ADUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID).FirstOrDefault();


                                if (objFieldPermissionsInfo != null && objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                                {
                                    btnToolbar[i].Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                                }
                            }
                            //Add child toolbar to parent toolbar
                            for (int i = 0; i < listToolbars.Count; i++)
                            {
                                STToolbarsInfo objSTToolbarsInfo = listToolbars[i];
                                if (objSTToolbarsInfo.STToolbarParentID > 0)
                                {
                                    int pos = lstParentToolbar[objSTToolbarsInfo.STToolbarParentID];
                                    (btnToolbar[pos] as DevExpress.XtraBars.BarSubItem).AddItem(btnToolbar[i]);
                                    //Set groupindex = 1 for any barbutton has parent
                                    arrToolbarHasParent.Add(btnToolbar[i]);
                                }

                            }
                        }
                    }
                }
                return btnToolbar;
            }
            catch (Exception ex)
            {
                return btnToolbar;
            }

        }
        /// <summary type="Toolbar">
        /// Init hot key for toolbar button
        /// </summary>
        /// <functiontype>Toolbar Function</functiontype>
        /// <param name="barButton"></param>
        private void InitHotKeyForToolbarButton(DevExpress.XtraBars.BarItem barButton)
        {
            switch (barButton.Tag.ToString())
            {
                case "New":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F4);
                        break;
                    }
                case "Edit":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F5);
                        break;
                    }
                case "Delete":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F6);
                        break;
                    }
                case "Cancel":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F7);
                        break;
                    }
                case "Save":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F8);
                        break;
                    }
                case "Complete":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F9);
                        break;
                    }
                case "Print":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.P);
                        break;
                    }
                case "TakePayment":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F11);
                        break;
                    }
                case "Approve":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F9);
                        break;
                    }
                case "Duplicate":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F10);
                        break;
                    }
                case "EntryTimeSheet":
                    {
                        barButton.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F11);
                        break;
                    }
            }
        }

        /// <summary type="Toolbar">
        /// Get Button Style
        /// </summary>
        /// <param name="strStyleName">Style Name</param>
        /// <functiontype>Toolbar Function</functiontype>
        /// <returns></returns>
        public DevExpress.XtraBars.BarButtonStyle GetButtonStyle(String strStyleName)
        {
            if (strStyleName == "Check")
                return DevExpress.XtraBars.BarButtonStyle.Check;
            else if (strStyleName == "Default")
                return DevExpress.XtraBars.BarButtonStyle.Default;
            else if (strStyleName == "DropDown")
                return DevExpress.XtraBars.BarButtonStyle.DropDown;
            else return DevExpress.XtraBars.BarButtonStyle.Default;
        }

        public void SetEnableOfToolbarButton(String strToolbarGroup, String strButtonTag, bool isEnable)
        {
            DevExpress.XtraBars.BarItem barbtn = GetToolbarButton(strButtonTag);
            if (barbtn != null)
                barbtn.Enabled = isEnable;
        }


        public void SetEnableOfToolbarButton(String strButtonTag, bool isEnable)
        {
            DevExpress.XtraBars.BarItem barbtn = GetToolbarButton(strButtonTag);
            if (barbtn != null)
                barbtn.Enabled = isEnable;
        }


        public void SetVisibleOfToolbarGroup(String strToolbarGroup, bool isVisible)
        {
            if (ToolbarManager.Bars[strToolbarGroup] != null)
                ToolbarManager.Bars[strToolbarGroup].Visible = isVisible;
        }

        /// <summary>
        /// Set caption for a toolbar button
        /// </summary>
        /// <param name="toolbarTag">Tag is used to get the toolbar button</param>
        /// <param name="caption">Caption needs to be set</param>
        public void SetCaptionOfToolbarButton(string toolbarTag, string caption)
        {
            DevExpress.XtraBars.BarItem barbtn = GetToolbarButton(toolbarTag);
            if (barbtn != null)
            {
                barbtn.Caption = caption;
            }
        }
        #endregion

        #region "Invalidate Toolbar Action"

        /// <summary type="InvalidateToolbar">
        /// Init Status of all buttons in toolbar Action at first time module is loaded
        /// </summary>     
        public virtual void InitStatusForToolbarAction()
        {
            try
            {
                List<STToolbarsInfo> toolbarList = BOSApp.ListToolbar.Where(t => t.STModuleID == Module.ModuleID
                                                                                    && t.STUserGroupID == 1
                                                                                    && t.STToolbarGroup == BaseToolbar.ToolbarAction).ToList();

                if (toolbarList != null && toolbarList.Count == 1)
                {
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                }
                else
                {
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("InitToolbarAction:" + e.Message);
            }
        }

        /// <summary type="InvalidateToolbar">
        /// Invalidate status of all buttons in toolbar Action after Action New is processed
        /// </summary>        
        public virtual void InvalidateToolbarAfterActionNew()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
                this.dockSearchResultsPanel.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionNew:" + e.Message);
            }

        }

        public virtual void InvalidateToolbarAfterActionDuplicate()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
                this.dockSearchResultsPanel.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionNew:" + e.Message);
            }

        }


        /// <summary type="InvalidateToolbar">
        /// Invalidate status of all buttons in toolbar action after Action Edit is processed
        /// </summary>    
        /// 
        public virtual void InvalidateToolbarAfterActionEdit()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
                this.dockSearchResultsPanel.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionEdit:" + e.Message);
            }

        }


        public virtual void InvalidateToolbarAfterActionEditTemplate()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                this.dockSearchResultsPanel.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionEdit:" + e.Message);
            }
        }



        /// <summary type="InvalidateToolbar">
        /// Invalidate status of all button in toolbar action after action Cancel is processed
        /// </summary> 
        /// 
        public virtual void InvalidateToolbarAfterActionCancel()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, true);
                this.dockSearchResultsPanel.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionCancel:" + e.Message);
            }
        }


        /// <summary type="InvalidateToolbar">
        /// Invalidate status of all button in toolbar Action after action Save is processed
        /// </summary> 
        public virtual void InvalidateToolbarAfterActionSave()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPost, true);
                this.dockSearchResultsPanel.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionSave:" + e.Message);
            }
        }

        /// <summary type="InvalidateToolbar">
        /// Invalidate status of toolbar buttons after complete action is processed
        /// </summary> 
        public virtual void InvalidateToolbarAfterActionComplete()
        {
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            this.dockSearchResultsPanel.Enabled = true;
        }

        /// <summary>
        /// Invalidate status of toolbar buttons after transfer action is processed
        /// </summary>
        public virtual void InvalidateToolbarAfterActionTransfer()
        {
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
        }

        /// <summary type="InvalidateToolbar">
        /// Invalidate status of all buttons in toolbar Action after action Delete is processed
        /// </summary> 
        /// 
        public virtual void InvalidateToolbarAfterActionDelete()
        {
            try
            {
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonNew, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancel, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDuplicate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEditTemplate, true);
                SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCopy, true);
                this.dockSearchResultsPanel.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("InvalidateToolbarAfterActionDelete:" + e.Message);
            }
        }


        #endregion

        #region "Generate Toolbar"
        #region "Get Module Toollbar Button"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strToolbarGroup"></param>
        /// <param name="strToolbarTag"></param>
        /// <returns></returns>
        /// 
        public DevExpress.XtraBars.BarButtonItem GetToolbarButton(String strToolbarGroup, String strToolbarTag)
        {
            DevExpress.XtraBars.BarButtonItem barbtn = new DevExpress.XtraBars.BarButtonItem();
            STToolbarsController objSTToolbarsController = new STToolbarsController();
            STToolbarsInfo objSTToolbarsInfo = objSTToolbarsController.GetSTToolbarsBySTModuleIDAndSTUserGroupIDAndSTToolbarGroupAndSTToolbarTag(
                                                                        Module.ModuleID, BOSApp.CurrentUserGroupInfo.ADUserGroupID, strToolbarGroup, strToolbarTag);
            if (objSTToolbarsInfo != null)
            {
                if (!String.IsNullOrEmpty(objSTToolbarsInfo.STToolbarName))
                {
                    barbtn = (DevExpress.XtraBars.BarButtonItem)ToolbarManager.Items[objSTToolbarsInfo.STToolbarName];
                    return barbtn;
                }

            }

            return null;
        }

        public DevExpress.XtraBars.BarItem GetToolbarButton(String strToolbarTag)
        {
            String strToolbarName = "fld_barbtn" + strToolbarTag;
            if (ToolbarManager.Items[strToolbarName] != null)
                return (DevExpress.XtraBars.BarItem)ToolbarManager.Items[strToolbarName];
            else
                return null;
        }

        #endregion

        #region Init Menu
        public void InitMenu()
        {

        }

        private void InitBarSubMenus()
        {
            //if (BOSApp.CurrentLang.Equals("ge") || BOSApp.CurrentLang.Equals("default"))
            //{
            //    barSubItemMenuFile.Caption = "&Daten";
            //    barSubItemMenuUtility.Caption = "&Werkzeug";
            //    barSubMenuItemExtra.Caption = "&Extra";
            //    barSubMenuItemInfo.Caption = "&Info";
            //}
        }

        private void AddMenuItemButton(String strToolbarGroup, DevExpress.XtraBars.BarItem btnButton)
        {

            if (strToolbarGroup.Equals(BaseToolbar.ToolbarAction))
                barSubItemMenuFile.AddItem(btnButton);
            else if (strToolbarGroup.Equals(BaseToolbar.ToolbarUtility))
                barSubItemMenuUtility.AddItem(btnButton);
            else if (strToolbarGroup.Equals(BaseToolbar.ToolbarExtra))
                barSubMenuItemExtra.AddItem(btnButton);
            else if (strToolbarGroup.Equals(BaseToolbar.ToolbarInfo))
                barSubMenuItemInfo.AddItem(btnButton);
        }
        #endregion

        #region "Init Module Toolbar"
        /// <summary type="InitalizeToolbar">
        /// Initialize toolbar for specific module
        /// </summary>        
        public void InitDisplayToolbar()
        {
            InitDisplayToolbarGroup(BaseToolbar.ToolbarInfo);
            InitDisplayToolbarGroup(BaseToolbar.ToolbarUtility);
            InitDisplayToolbarGroup(BaseToolbar.ToolbarExtra);
            InitDisplayToolbarGroup(BaseToolbar.ToolbarAction);

            if (!Module.DisplayModus.Equals(BaseModule.cstModusNormal))
            {
                if (ToolbarManager.Bars[BaseToolbar.ToolbarAction] != null)
                {
                    ToolbarManager.Bars[BaseToolbar.ToolbarAction].Visible = false;
                }
            }
            ToolbarManager.AllowCustomization = false;
            ToolbarManager.AllowMoveBarOnToolbar = false;
            ToolbarManager.AllowShowToolbarsPopup = true;
        }

        public void InitDisplayToolbarGroup(String strToolbarGroup)
        {
            STToolbarsController objSTToolbarsController = new STToolbarsController();

            List<STToolbarsInfo> toolbarList = BOSApp.ListToolbar.Where(t => t.STModuleID == Module.ModuleID
                                                                                    && t.STUserGroupID == 1
                                                                                    && t.STToolbarGroup == strToolbarGroup).ToList();
            //DataSet dsToolbars = objSTToolbarsController.GetSTToolbarsBySTModuleIDAndSTUserGroupIDAndSTToolbarGroup(Module.ModuleID, 1, strToolbarGroup);
            if (toolbarList != null)
            {
                if (toolbarList.Count > 0)
                {
                    if (popupMenuToolbar.ItemLinks.Count > 0)
                    {
                        popupMenuToolbar.ItemLinks[popupMenuToolbar.ItemLinks.Count - 1].BeginGroup = true;
                    }

                    DevExpress.XtraBars.Bar fld_toolbarGroup = new DevExpress.XtraBars.Bar(ToolbarManager);
                    fld_toolbarGroup.BarName = strToolbarGroup;
                    SetPropertiesOfToolbarGroup(ref fld_toolbarGroup, strToolbarGroup);
                    fld_toolbarGroup.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
                    fld_toolbarGroup.Text = strToolbarGroup;

                    List<DevExpress.XtraBars.BarItem> arrToolbarItemHasParent = new List<DevExpress.XtraBars.BarItem>();
                    DevExpress.XtraBars.BarItem[] btnButtons = InitToolbarButtonsForToolbar(strToolbarGroup, ref arrToolbarItemHasParent);

                    foreach (DevExpress.XtraBars.BarItem btnButton in btnButtons)
                    {
                        if (BOSApp.ToolbarImageList.Images.IndexOfKey(btnButton.Tag.ToString()) >= 0)
                        {
                            btnButton.LargeImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey(btnButton.Tag.ToString());
                            btnButton.ImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey(btnButton.Tag.ToString());

                        }
                        else
                        {
                            btnButton.LargeImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey("BOS");
                            btnButton.ImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey("BOS");
                        }

                        btnButton.Hint = strToolbarGroup;
                        btnButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(ToolbarButton_ItemClick);

                        DevExpress.XtraBars.BarItem barButton = new DevExpress.XtraBars.BarButtonItem();
                        barButton = btnButton;
                        //Add caption to right side barbutton Item
                        barButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                        InitHotKeyForToolbarButton(barButton);
                        barButton.Id = ToolbarManager.GetNewItemId();
                        ToolbarManager.Items.Add(barButton);

                        //Not add toolbar into fld_toolbarGroup if it has parent
                        if (arrToolbarItemHasParent.IndexOf(btnButton) < 0)
                            fld_toolbarGroup.AddItem(barButton);

                        if ((strToolbarGroup.Equals(BaseToolbar.ToolbarAction) || (strToolbarGroup.Equals(BaseToolbar.ToolbarUtility))))
                        {
                            popupMenuToolbar.AddItem(barButton);
                        }
                        AddMenuItemButton(strToolbarGroup, btnButton);
                    }

                    if (strToolbarGroup.Equals(BaseToolbar.ToolbarAction))
                    {
                        InitStatusForToolbarAction();
                    }
                }
            }
        }

        private void SetPropertiesOfToolbarGroup(ref DevExpress.XtraBars.Bar fld_toolbarGroup, String strToolbarGroup)
        {
            switch (strToolbarGroup)
            {
                case BaseToolbar.ToolbarAction:
                    {
                        fld_toolbarGroup.DockCol = 0;
                        fld_toolbarGroup.DockRow = 0;
                        break;
                    }
                case BaseToolbar.ToolbarUtility:
                    {
                        fld_toolbarGroup.DockCol = 1;
                        fld_toolbarGroup.DockRow = 0;
                        break;
                    }
                case BaseToolbar.ToolbarInfo:
                    {
                        fld_toolbarGroup.DockCol = 2;
                        fld_toolbarGroup.DockRow = 0;
                        break;
                    }
                case BaseToolbar.ToolbarExtra:
                    {
                        fld_toolbarGroup.DockCol = 3;
                        fld_toolbarGroup.DockRow = 0;
                        break;
                    }


            }
        }

        /// <summary type="InitalizeToolbar">
        /// Delegate function process event ItemClick of toolbar button
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arguments</param>
        /// <BOSparam name="SearchResultsControlName" type="String"></BOSparam>
        public void ToolbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                STToolbarsController objSTToolbarsController = new STToolbarsController();
                STToolbarFunctionsController objSTToolbarFunctionsController = new STToolbarFunctionsController();
                DevExpress.XtraBars.BarItem btn = sender as DevExpress.XtraBars.BarItem;
                String strToolbarTag = e.Item.Tag.ToString();
                String strToolbarGroup = e.Item.Hint;
                Module.ToolbarActionName = strToolbarTag;
                STToolbarsInfo objSTToolbarsInfo = BOSApp.ListToolbar.Where(t => t.STModuleID == Module.ModuleID && t.STUserGroupID == 1 && t.STToolbarGroup == strToolbarGroup
                && t.STToolbarTag == strToolbarTag).FirstOrDefault();
                List<STToolbarFunctionsInfo> listToolbarFunction = BOSApp.ListToolbarFunc.Where(f => f.STToolbarID == objSTToolbarsInfo.STToolbarID).ToList();
                if (listToolbarFunction.Count() > 0)
                {
                    foreach (STToolbarFunctionsInfo objSTToolbarFunctionsInfo in listToolbarFunction)
                    {
                        MethodInfo method = Module.GetMethodInfoByMethodFullNameAndMethodClass(objSTToolbarFunctionsInfo.STToolbarFunctionName,
                                                                                        objSTToolbarFunctionsInfo.STToolbarFunctionFullName,
                                                                                        objSTToolbarFunctionsInfo.STToolbarFunctionClass);
                        //Invoke method                                
                        method.Invoke(Module, Module.GetMethodParameterValues(method.GetParameters(), sender, "ItemClick"));

                    }
                }
                else
                {
                    if (!(e.Item is BarSubItem))
                    {
                        switch (strToolbarTag)
                        {
                            case BaseToolbar.ToolbarButtonNew:
                                {
                                    Module.ActionNew();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonEdit:
                                {
                                    Module.ActionEdit();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonEditTemplate:
                                {
                                    Module.ActionEditTemplate();
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonDuplicate:
                                {
                                    Module.ActionDuplicate();
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonCancel:
                                {
                                    /*Do some action */
                                    Module.ActionCancel();
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonSave:
                                {
                                    /*Do some action*/
                                    MethodInfo method = this.GetType().GetMethod("ToolbarButton_ItemClick", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[2] { typeof(object), typeof(DevExpress.XtraBars.ItemClickEventArgs) }, null);
                                    String strSearchResultsControlName = Module.GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
                                    Module.ResetFocus();
                                    Module.ActionSave();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonComplete:
                                {
                                    Module.ActionComplete();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonDelete:
                                {
                                    Module.ActionDelete();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonPrint:
                                {
                                    Module.ActionPrint();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonExport:
                                {
                                    Module.ActionExport();
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonImport:
                                {
                                    Module.ActionImport();
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonError:
                                {
                                    Module.ActionShowError();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonUserAudit:
                                {
                                    Module.ActionUserAudit();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonInformation:
                                {
                                    break;
                                }

                            case BaseToolbar.ToolbarButtonPrevious:
                                {
                                    MethodInfo method = this.GetType().GetMethod("ToolbarButton_ItemClick", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[2] { typeof(object), typeof(DevExpress.XtraBars.ItemClickEventArgs) }, null);
                                    String strSearchResultsControlName = Module.GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
                                    Module.ActionGoPrevious();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonNext:
                                {
                                    MethodInfo method = this.GetType().GetMethod("ToolbarButton_ItemClick", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, new Type[2] { typeof(object), typeof(DevExpress.XtraBars.ItemClickEventArgs) }, null);
                                    String strSearchResultsControlName = Module.GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
                                    Module.ActionGoNext();
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonTransfer:
                                {
                                    Module.ActionTransfer(string.Empty);
                                    break;
                                }
                            case BaseToolbar.ToolbarButtonCancelComplete:
                                {
                                    Module.ActionCancelComplete();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        if (e.Link == null && e.Item.Links.Count > 1)
                        {
                            BarSelectionInfo info = e.Item.Manager.InternalGetService(typeof(BarSelectionInfo)) as BarSelectionInfo;
                            if (info != null)
                            {
                                info.PressLink(e.Item.Links[1]);
                            }
                        }
                    }
                }
                //dsSTToolbarFunctions.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}{1}", ex.InnerException, ex.Message), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BarButtonCloseModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void BarButtonCloseApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BOSApp.MainScreen.Close();
        }

        #endregion

        #endregion

        #region Utility functions
        /// <summary>
        /// Show Module with module Name
        /// </summary>
        /// <param name="strModuleName">Module Name</param>
        public BaseModuleERP ShowModule(String strModuleName)
        {
            BaseModuleERP currModule = null;
            //Show module in case of the module will be show is different from Current module
            if (!Module.Name.Equals(strModuleName))
            {
                //If current Module is in modus edit or new,warning message to finish task for current module before go to another module
                Cursor.Current = Cursors.WaitCursor;

                //If module will be show is in Opened Module List, get this module and show
                if (BOSApp.IsOpenedModule(strModuleName))
                {
                    currModule = ((BaseModuleERP)BOSApp.OpenModules[strModuleName]);
                    currModule.ParentScreen.Activate();
                }
                //if module is not in Opened Module List, create new instance and show
                else
                {
                    currModule = BaseModuleFactory.GetModule(strModuleName);
                    if (currModule != null)
                    {
                        //Change ordinary of these two rows
                        BOSApp.AddOpenModuleToOpenModulesToolStrip(strModuleName);
                        currModule.Show();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            return currModule;
        }

        /// <summary>
        /// Populate ToolStrip Button for open module
        /// </summary>
        /// <param name="strModuleName">Name of Module will be populated to toolstrip button</param>
        /// <returns></returns>
        private ToolStripButton PopulateOpenModulesToolStripButton(String strModuleName)
        {
            STModuleDescriptionsInfo objSTModuleDescriptionsInfo = BOSApp.ModuleDescriptionList.Where(d => d.STModuleName == Module.Name && d.GELanguageName == BOSApp.CurrentLang).FirstOrDefault();
            String strModuleDesc = string.Empty;
            if (objSTModuleDescriptionsInfo != null)
                strModuleDesc = objSTModuleDescriptionsInfo.STModuleDescriptionDescription;
            else
                strModuleDesc = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(strModuleName, BOSApp.CurrentLang);
            if (String.IsNullOrEmpty(strModuleDesc))
                strModuleDesc = strModuleName;

            ToolStripButton tsbtnOpenModules = new ToolStripButton(strModuleDesc, BOSApp.SectionImageList.Images[strModuleName], OpenModulesToolStrip_Click, strModuleName);
            tsbtnOpenModules.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsbtnOpenModules.CheckOnClick = true;
            return tsbtnOpenModules;
        }



        /// <summary>
        /// Set toolstripbutton of Open Module to checked
        /// </summary>
        /// <param name="tsbtnModule"></param>
        private void CheckOpenModuleToolStripButton(ToolStripButton tsbtnModule)
        {
            tsbtnModule.Checked = true;
            foreach (ToolStripButton tsbtnOpenedModule in BOSApp.MainScreen.OpenModulesToolStrip.Items)
            {
                if (tsbtnOpenedModule.Name != tsbtnModule.Name)
                    tsbtnOpenedModule.Checked = false;
            }
        }
        private void CheckOpenModulesToolStripButton(String strModuleName)
        {
            foreach (ToolStripButton tsbtnOpenedModule in BOSApp.MainScreen.OpenModulesToolStrip.Items)
            {
                if (tsbtnOpenedModule.Name != strModuleName)
                    tsbtnOpenedModule.Checked = false;
                else
                    tsbtnOpenedModule.Checked = true;
            }
        }

        /// <summary>
        /// Delegate function for event click of Toolstrip Button Open Module
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arugment</param>
        private void OpenModulesToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbtnModule = (ToolStripButton)sender;
            CheckOpenModuleToolStripButton(tsbtnModule);
            ShowModule(tsbtnModule.Name);
            //SetActiveGroupByModule(tsbtnModule.Name);
            //SetActiveModuleByModuleName( tsbtnModule.Name );

        }


        /// <summary>
        /// Add open module to Open Modules Tool Strip
        /// </summary>
        /// <param name="strModuleName">Name of module will be added</param>
        public void AddOpenModuleToOpenModulesToolStrip(String strModuleName)
        {
            ToolStripButton tsbtnModule = PopulateOpenModulesToolStripButton(strModuleName);
            BOSApp.MainScreen.OpenModulesToolStrip.Items.Add(tsbtnModule);
            CheckOpenModuleToolStripButton(tsbtnModule);
        }

        /// <summary>
        /// Check the module is opened before or not
        /// </summary>
        /// <param name="strModuleName">Name of module is checked</param>
        /// <returns>true if is opened before, otherwise return false</returns>
        public bool IsOpenedModule(String strModuleName)
        {
            return BOSApp.OpenModules[strModuleName] != null;
        }

        /// <summary>
        /// Add new or update module into Opened Module list
        /// </summary>
        /// <param name="module">module will be added new or updated</param>
        public void UpdateOpenedModule(BaseModuleERP module)
        {
            if (!IsOpenedModule(module.Name))
            {
                if (!module.Name.Equals(BaseModuleERP.cstHomeModule))
                    BOSApp.OpenModules.Add(module.Name, module);
            }
            else
                BOSApp.OpenModules[module.Name] = module;
        }

        /// <summary>
        /// Remove module from Opened Module list
        /// </summary>
        /// <param name="module">Module will be removed</param>
        public void RemoveOpenedModule(BaseModuleERP module)
        {
            if (IsOpenedModule(module.Name))
                BOSApp.OpenModules.Remove(module.Name);
        }

        /// <summary>
        /// Remove module from Opened module list
        /// </summary>
        /// <param name="strModuleName">Module name will be removed</param>
        public void RemoveOpenedModule(String strModuleName)
        {
            if (IsOpenedModule(strModuleName))
                BOSApp.OpenModules.Remove(strModuleName);
        }

        #endregion

        public String GetParentScreenTextByLanguage(String strLanguageName)
        {
            STModuleDescriptionsController objSTModuleDescriptionsController = new STModuleDescriptionsController();
            STModuleDescriptionsInfo objSTModuleDescriptionsInfo = BOSApp.ModuleDescriptionList.Where(d => d.STModuleName == Module.Name && d.GELanguageName == strLanguageName).FirstOrDefault();
            String strParentScreenText = string.Empty;
            if (objSTModuleDescriptionsInfo != null)
                strParentScreenText = objSTModuleDescriptionsInfo.STModuleDescriptionDescription;
            else
                strParentScreenText = objSTModuleDescriptionsController.GetDescriptionByModuleNameAndLanguageName(Module.Name, strLanguageName);
            if (String.IsNullOrEmpty(strParentScreenText))
                strParentScreenText = Module.Name;
            return strParentScreenText;
        }

        private void SetScreenStyle()
        {
            ADUsersInfo objADUsersInfo = (ADUsersInfo)new ADUsersController().GetObjectByName(BOSApp.CurrentUser);
            if (!String.IsNullOrEmpty(objADUsersInfo.ADUserStyle))
            {
                if (objADUsersInfo.ADUserStyle == "XP")
                {

                    this.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.Office2003, true, true, objADUsersInfo.ADUserStyleSkin);
                    this.ToolbarManager.GetController().PaintStyleName = "WindowsXP";
                    this.ToolbarManager.GetController().ResetStyleDefaults();
                }
                else
                {
                    this.LookAndFeel.SetStyle((DevExpress.LookAndFeel.LookAndFeelStyle)Enum.Parse(typeof(DevExpress.LookAndFeel.LookAndFeelStyle), objADUsersInfo.ADUserStyle), false, false, objADUsersInfo.ADUserStyleSkin);
                    this.ToolbarManager.GetController().PaintStyleName = objADUsersInfo.ADUserStyle;

                    this.ToolbarManager.GetController().ResetStyleDefaults();
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(objADUsersInfo.ADUserStyleSkin);
                }
            }
            else
            {
                this.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.Office2003, false, false, objADUsersInfo.ADUserStyleSkin);
                this.ToolbarManager.GetController().PaintStyleName = "Office2003";
                this.ToolbarManager.GetController().ResetStyleDefaults();
            }

        }

        private void ModuleParentScreen_Activated(object sender, EventArgs e)
        {
            if (BOSApp.OpenModules.ContainsKey(BOSApp.CurrentModule))
                ((BaseModuleERP)BOSApp.OpenModules[BOSApp.CurrentModule]).ParentScreen.WindowState = FormWindowState.Minimized;

            base.Activate();
            //this.SuspendLayout();

            //Focus active group and item in Section 
            //SetActiveModuleByModuleName(module.Name);

            //SetActiveGroupByModule(module.Name);

            //Init Open Modules on OpenModulesToolStrip
            CheckOpenModulesToolStripButton(Module.Name);

            //this.ResumeLayout(false);
            this.WindowState = FormWindowState.Maximized;

            //Set Current Module
            BOSApp.CurrentModule = Module.Name;

            if (Module.DisplayModus.Equals(BaseModule.cstModusNormal))
            {
                if (Module.Toolbar.IsNullOrNoneAction())
                {
                    Module.SaveUserAudit(BaseModule.cstUserAuditNothing);
                }
                else
                {
                    if (Module.Toolbar.ModusAction == BaseToolbar.ModusNew)
                        Module.SaveUserAudit(BaseModule.cstUserAuditNew);
                    else
                        Module.SaveUserAudit(BaseModule.cstUserAuditEdit);
                }
            }
            //Show current module in tooltrip
            BOSApp.MainScreen.moduleItem.Caption = Module.Name;
            CheckKeyBoard(null);

            //Invoke destination action if exists
            if (!String.IsNullOrEmpty(Module.DestinationAction))
            {
                String methodFullName = Module.DestinationAction;
                String methodName = Module.DestinationAction.Substring(0, methodFullName.IndexOf("("));
                MethodInfo method = Module.GetMethodInfoByMethodFullNameAndMethodClass(methodName, methodFullName, String.Format("BOSERP.Modules.{0}.{1}Module", Module.Name, Module.Name));
                Module.DestinationAction = String.Empty;
                if (method != null)
                    method.Invoke(Module, null);
            }
        }

        public void ShowSearchResultsPanel()
        {
            if (IsExistsGridSearchResult())
            {
                dockSearchResultsPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                dockSearchResultsPanel.HideImmediately();
                fld_barckeSearchResults.Checked = true;
            }
            else
            {
                dockSearchResultsPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                fld_barckeSearchResults.Checked = false;
            }
        }

        public bool IsExistsGridSearchResult()
        {
            foreach (Control ctrl in SearchResultsContainer.Controls)
                if (ctrl.Tag != null && ctrl.Tag.ToString() == BOSScreen.SearchResultControl)
                    return true;
            return false;
        }

        public void CheckKeyBoard(KeyEventArgs e)
        {
            Keyboard kb = new Keyboard();

            if (e == null)
            {
                BOSApp.MainScreen.numItem.Enabled = kb.NumLock;
                BOSApp.MainScreen.capItem.Enabled = kb.CapsLock;
                BOSApp.MainScreen.scrollItem.Enabled = kb.ScrollLock;
                return;
            }
            if (e.KeyCode == Keys.NumLock)
            {
                BOSApp.MainScreen.numItem.Enabled = kb.NumLock;
                return;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                BOSApp.MainScreen.capItem.Enabled = kb.CapsLock;
                return;
            }
            if (e.KeyCode == Keys.Scroll)
            {
                BOSApp.MainScreen.scrollItem.Enabled = kb.ScrollLock;
                return;
            }

        }

        private void ModuleParentScreen_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumLock || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Scroll)
            {
                CheckKeyBoard(e);
            }
        }

        private void ModuleParentScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Module.Close();
        }

        private void ModuleParentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show(BaseLocalizedResources.ConfirmSaveBeforeExitMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int objectID = Module.ActionSave();
                    if (objectID == 0)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ItemBarCheckStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLookAndFeelStyle = e.Item.Tag.ToString();
            BOSApp.SetApplicationStyle(strLookAndFeelStyle, String.Empty);
            BOSApp.SaveUserStyle(strLookAndFeelStyle, String.Empty);
        }

        private void ItemCheckStyleSkin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLookAndFeelStyleSkin = e.Item.Tag.ToString();
            BOSApp.SetApplicationStyle("Skin", strLookAndFeelStyleSkin);
            BOSApp.SaveUserStyle("Skin", strLookAndFeelStyleSkin);
        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (dockInventoryPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden)
            //{
            //    dockInventoryPanel.Show();
            //}
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (dockSerieInventoryPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden)
            //    dockSerieInventoryPanel.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dockSearchResultsPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden)
                dockSearchResultsPanel.Show();
        }

        private void ModuleParentScreen_Load(object sender, EventArgs e)
        {

        }

        public void ModuleParentScreen_Init()
        {
            this.Text = GetParentScreenTextByLanguage(BOSApp.CurrentLang);
            BOSApp.MainScreen.moduleItem.Caption = BOSApp.CurrentModule;

            InitBarSubMenus();
            InitDisplayToolbar();

            //Init close module button 
            DevExpress.XtraBars.BarButtonItem barbtnCloseModule = new DevExpress.XtraBars.BarButtonItem();
            barbtnCloseModule.Name = "fld_barbtnCloseModule";
            barbtnCloseModule.Caption = "Close Module";
            barbtnCloseModule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(BarButtonCloseModule_ItemClick);
            barbtnCloseModule.Id = ToolbarManager.GetNewItemId();
            ToolbarManager.Items.Add(barbtnCloseModule);
            barSubItemMenuFile.AddItem(barbtnCloseModule);
            barSubItemMenuFile.ItemLinks[barSubItemMenuFile.ItemLinks.Count - 1].BeginGroup = true;

            //Add close application button
            DevExpress.XtraBars.BarButtonItem barbtnCloseApp = new DevExpress.XtraBars.BarButtonItem();
            barbtnCloseApp.Name = "fld_barbtnCloseApp";
            barbtnCloseApp.Caption = "Exit POS";
            barbtnCloseApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(BarButtonCloseApp_ItemClick);
            barbtnCloseApp.Id = ToolbarManager.GetNewItemId();
            ToolbarManager.Items.Add(barbtnCloseApp);
            barSubItemMenuFile.AddItem(barbtnCloseApp);
        }

        private void fld_drdbtnCreateCriteria_Click(object sender, EventArgs e)
        {
            ((BaseModuleERP)Module).SearchScreen.StartPosition = FormStartPosition.CenterParent;
            ((BaseModuleERP)Module).ResetSearch();
            ((BaseModuleERP)Module).SearchScreen.ShowDialog();
        }

        private void fld_btnExpandObjectList_Click(object sender, EventArgs e)
        {
            if (!IsObjectListExpanded)
            {
                ExpandObjectList();
            }
            else
            {
                CollapseObjectList();
            }
        }

        /// <summary>
        /// Expand the object list
        /// </summary>
        public void ExpandObjectList()
        {
            InitialInventoryContainerVisibility = InventoryContainer.Visibility;
            InventoryContainer.Visibility = DockVisibility.Hidden;
            SearchContainer.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            SearchContainer.Size = new Size(Width - 15, SearchContainer.Height);
            fld_btnExpandObjectList.Text = BaseLocalizedResources.Collapsed;
            IsObjectListExpanded = true;
        }

        /// <summary>
        /// Collapse the object list
        /// </summary>
        public void CollapseObjectList()
        {
            SearchContainer.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            SearchContainer.Size = new Size(279, SearchContainer.Height);
            if (InitialInventoryContainerVisibility != DockVisibility.Hidden)
            {
                InventoryContainer.Visibility = DockVisibility.Visible;
            }
            fld_btnExpandObjectList.Text = BaseLocalizedResources.Expanded;
            IsObjectListExpanded = false;
        }

        private void ModuleParentScreen_SizeChanged(object sender, EventArgs e)
        {
            //Resize object list if it's expanded
            if (IsObjectListExpanded)
            {
                SearchContainer.Size = new Size(Width - 15, SearchContainer.Height);
            }
        }

        private void fld_tabScreenContainer_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            Module.ActivateScreen(e.Page.Name);
        }

        private void fld_lnkICInventoryStockQuantity_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            Control ctrl = (Control)sender;
            int productID = Convert.ToInt32(ctrl.Tag);
            if (productID > 0)
            {
                Module.ShowInventoryDetails(productID, InventoryType.OnHand.ToString());
            }
        }

        private void fld_lnkICInventoryStockSaleOrderQuantity_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            Control ctrl = (Control)sender;
            int productID = Convert.ToInt32(ctrl.Tag);
            if (productID > 0)
            {
                Module.ShowInventoryDetails(productID, InventoryType.SaleOrder.ToString());
            }
        }

        private void fld_lnkICInventoryStockPurchaseOrderQuantity_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            Control ctrl = (Control)sender;
            int productID = Convert.ToInt32(ctrl.Tag);
            if (productID > 0)
            {
                Module.ShowInventoryDetails(productID, InventoryType.PurchaseOrder.ToString());
            }
        }

        private void fld_lnkICInventoryStockTransitOutQuantity_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            Control ctrl = (Control)sender;
            int productID = Convert.ToInt32(ctrl.Tag);
            if (productID > 0)
            {
                Module.ShowInventoryDetails(productID, InventoryType.TransitOut.ToString());
            }
        }

        private void fld_lnkICInventoryStockTransitInQuantity_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            Control ctrl = (Control)sender;
            int productID = Convert.ToInt32(ctrl.Tag);
            if (productID > 0)
            {
                Module.ShowInventoryDetails(productID, InventoryType.TransitIn.ToString());
            }
        }

        private void ModuleParentScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Space)
            {
                ((BaseModuleERP)Module).FocusItemLookUp();
            }
        }
    }
}
