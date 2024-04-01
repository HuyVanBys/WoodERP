using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProduct.UI
{
	/// <summary>
    /// Summary description for DMBP101
	/// </summary>
    partial class DMBP101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBP101));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_tabProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeSumGoM3 = new DevExpress.XtraEditors.TextEdit();
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_radPropertiesOrProcess = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_btnUpdateWood = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMBatchProductProductionNormItems = new BOSERP.Modules.BatchProduct.ProductionNormItemsTreeListControl();
            this.fld_tabHardware = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdateHardware = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMProductionNormItemsHardware = new BOSERP.Modules.BatchProduct.ProductionNormItemsHardwareTreeListControl();
            this.fld_tabPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePaint = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMProductionNormItemsPaint = new BOSERP.Modules.BatchProduct.ProductionNormItemsPaintTreeListControl();
            this.fld_tabPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePackaging = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMProductionNormItemsPackaging = new BOSERP.Modules.BatchProduct.ProductionNormItemsPackagingTreeListControl();
            this.fld_tbGeneralMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlMMProductionNormItemsGeneralMaterial = new BOSERP.Modules.BatchProduct.ProductionNormItemsGeneralMaterialTreeListControl();
            this.fld_btnGeneralMaterial = new BOSComponent.BOSButton(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSumGoM3.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPropertiesOrProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMBatchProductProductionNormItems)).BeginInit();
            this.fld_tabHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).BeginInit();
            this.fld_tabPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).BeginInit();
            this.fld_tabPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPackaging)).BeginInit();
            this.fld_tbGeneralMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsGeneralMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_tabProductionNorm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 635);
            this.panel1.TabIndex = 6;
            // 
            // fld_tabProductionNorm
            // 
            this.fld_tabProductionNorm.BOSComment = null;
            this.fld_tabProductionNorm.BOSDataMember = null;
            this.fld_tabProductionNorm.BOSDataSource = null;
            this.fld_tabProductionNorm.BOSDescription = null;
            this.fld_tabProductionNorm.BOSError = null;
            this.fld_tabProductionNorm.BOSFieldGroup = null;
            this.fld_tabProductionNorm.BOSFieldRelation = null;
            this.fld_tabProductionNorm.BOSPrivilege = null;
            this.fld_tabProductionNorm.BOSPropertyName = null;
            this.fld_tabProductionNorm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.Screen = null;
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabSemiProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabProductionNorm, true);
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(1154, 635);
            this.fld_tabProductionNorm.TabIndex = 3;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSemiProduct,
            this.fld_tabHardware,
            this.fld_tabPaint,
            this.fld_tabPackaging,
            this.fld_tbGeneralMaterial});
            this.fld_tabProductionNorm.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabProductionNorm_SelectedPageChanged);
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_lkeSumGoM3);
            this.fld_tabSemiProduct.Controls.Add(this.bosLabel18);
            this.fld_tabSemiProduct.Controls.Add(this.bosLine1);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnUpdateWood);
            this.fld_tabSemiProduct.Controls.Add(this.fld_trlMMBatchProductProductionNormItems);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabSemiProduct, true);
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(1152, 610);
            this.fld_tabSemiProduct.Text = "ĐM Bán thành phẩm";
            // 
            // fld_lkeSumGoM3
            // 
            this.fld_lkeSumGoM3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeSumGoM3.Location = new System.Drawing.Point(1018, 15);
            this.fld_lkeSumGoM3.MenuManager = this.screenToolbar;
            this.fld_lkeSumGoM3.Name = "fld_lkeSumGoM3";
            this.fld_lkeSumGoM3.Properties.DisplayFormat.FormatString = "n6";
            this.fld_lkeSumGoM3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeSumGoM3.Properties.EditFormat.FormatString = "n6";
            this.fld_lkeSumGoM3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeSumGoM3.Properties.ReadOnly = true;
            this.fld_lkeSumGoM3.Size = new System.Drawing.Size(109, 20);
            this.fld_lkeSumGoM3.TabIndex = 114;
            // 
            // bosLabel18
            // 
            this.bosLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(955, 19);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(57, 13);
            this.bosLabel18.TabIndex = 113;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Gỗ (M3)  :";
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
            this.bosLine1.Controls.Add(this.fld_radPropertiesOrProcess);
            this.bosLine1.Location = new System.Drawing.Point(139, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(221, 44);
            this.bosLine1.TabIndex = 111;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Xem";
            // 
            // fld_radPropertiesOrProcess
            // 
            this.fld_radPropertiesOrProcess.BOSComment = null;
            this.fld_radPropertiesOrProcess.BOSDataMember = null;
            this.fld_radPropertiesOrProcess.BOSDataSource = null;
            this.fld_radPropertiesOrProcess.BOSDescription = null;
            this.fld_radPropertiesOrProcess.BOSError = null;
            this.fld_radPropertiesOrProcess.BOSFieldGroup = null;
            this.fld_radPropertiesOrProcess.BOSFieldRelation = null;
            this.fld_radPropertiesOrProcess.BOSPrivilege = null;
            this.fld_radPropertiesOrProcess.BOSPropertyName = null;
            this.fld_radPropertiesOrProcess.Location = new System.Drawing.Point(37, 11);
            this.fld_radPropertiesOrProcess.MenuManager = this.screenToolbar;
            this.fld_radPropertiesOrProcess.Name = "fld_radPropertiesOrProcess";
            this.fld_radPropertiesOrProcess.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_radPropertiesOrProcess.Properties.Appearance.Options.UseBackColor = true;
            this.fld_radPropertiesOrProcess.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nguyên liệu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "QTSX")});
            this.fld_radPropertiesOrProcess.Screen = null;
            this.fld_radPropertiesOrProcess.Size = new System.Drawing.Size(178, 27);
            this.fld_radPropertiesOrProcess.TabIndex = 110;
            // 
            // fld_btnUpdateWood
            // 
            this.fld_btnUpdateWood.BOSComment = null;
            this.fld_btnUpdateWood.BOSDataMember = null;
            this.fld_btnUpdateWood.BOSDataSource = null;
            this.fld_btnUpdateWood.BOSDescription = null;
            this.fld_btnUpdateWood.BOSError = null;
            this.fld_btnUpdateWood.BOSFieldGroup = null;
            this.fld_btnUpdateWood.BOSFieldRelation = null;
            this.fld_btnUpdateWood.BOSPrivilege = null;
            this.fld_btnUpdateWood.BOSPropertyName = null;
            this.fld_btnUpdateWood.Location = new System.Drawing.Point(10, 12);
            this.fld_btnUpdateWood.Name = "fld_btnUpdateWood";
            this.fld_btnUpdateWood.Screen = null;
            this.fld_btnUpdateWood.Size = new System.Drawing.Size(123, 27);
            this.fld_btnUpdateWood.TabIndex = 94;
            this.fld_btnUpdateWood.Text = "Cập nhật";
            this.fld_btnUpdateWood.Click += new System.EventHandler(this.fld_btnUpdateWood_Click);
            // 
            // fld_trlMMBatchProductProductionNormItems
            // 
            this.fld_trlMMBatchProductProductionNormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMBatchProductProductionNormItems.BOSComment = "";
            this.fld_trlMMBatchProductProductionNormItems.BOSDataMember = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMBatchProductProductionNormItems.BOSDescription = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSDisplayOption = true;
            this.fld_trlMMBatchProductProductionNormItems.BOSDisplayRoot = false;
            this.fld_trlMMBatchProductProductionNormItems.BOSError = "";
            this.fld_trlMMBatchProductProductionNormItems.BOSFieldGroup = "";
            this.fld_trlMMBatchProductProductionNormItems.BOSFieldRelation = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSPrivilege = "";
            this.fld_trlMMBatchProductProductionNormItems.BOSPropertyName = null;
            this.fld_trlMMBatchProductProductionNormItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMBatchProductProductionNormItems.Location = new System.Drawing.Point(3, 47);
            this.fld_trlMMBatchProductProductionNormItems.Name = "fld_trlMMBatchProductProductionNormItems";
            this.fld_trlMMBatchProductProductionNormItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMBatchProductProductionNormItems.Screen = null;
            this.fld_trlMMBatchProductProductionNormItems.Size = new System.Drawing.Size(1149, 560);
            this.fld_trlMMBatchProductProductionNormItems.TabIndex = 93;
            this.fld_trlMMBatchProductProductionNormItems.Tag = "DC";
            this.fld_trlMMBatchProductProductionNormItems.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMBatchProductProductionNormItems_NodeCellStyle);
            this.fld_trlMMBatchProductProductionNormItems.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMBatchProductProductionNormItems_CustomDrawNodeCell);
            this.fld_trlMMBatchProductProductionNormItems.DoubleClick += new System.EventHandler(this.fld_trlMMBatchProductProductionNormItems_DoubleClick);
            // 
            // fld_tabHardware
            // 
            this.fld_tabHardware.Controls.Add(this.fld_btnUpdateHardware);
            this.fld_tabHardware.Controls.Add(this.fld_trlMMProductionNormItemsHardware);
            this.fld_tabHardware.Name = "fld_tabHardware";
            this.ScreenHelper.SetShowHelp(this.fld_tabHardware, true);
            this.fld_tabHardware.Size = new System.Drawing.Size(1152, 610);
            this.fld_tabHardware.Text = "ĐM Hardware";
            // 
            // fld_btnUpdateHardware
            // 
            this.fld_btnUpdateHardware.BOSComment = null;
            this.fld_btnUpdateHardware.BOSDataMember = null;
            this.fld_btnUpdateHardware.BOSDataSource = null;
            this.fld_btnUpdateHardware.BOSDescription = null;
            this.fld_btnUpdateHardware.BOSError = null;
            this.fld_btnUpdateHardware.BOSFieldGroup = null;
            this.fld_btnUpdateHardware.BOSFieldRelation = null;
            this.fld_btnUpdateHardware.BOSPrivilege = null;
            this.fld_btnUpdateHardware.BOSPropertyName = null;
            this.fld_btnUpdateHardware.Location = new System.Drawing.Point(10, 3);
            this.fld_btnUpdateHardware.Name = "fld_btnUpdateHardware";
            this.fld_btnUpdateHardware.Screen = null;
            this.fld_btnUpdateHardware.Size = new System.Drawing.Size(123, 27);
            this.fld_btnUpdateHardware.TabIndex = 95;
            this.fld_btnUpdateHardware.Text = "Cập nhật";
            this.fld_btnUpdateHardware.Click += new System.EventHandler(this.fld_btnUpdateHardware_Click);
            // 
            // fld_trlMMProductionNormItemsHardware
            // 
            this.fld_trlMMProductionNormItemsHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsHardware.BOSComment = "";
            this.fld_trlMMProductionNormItemsHardware.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMProductionNormItemsHardware.BOSDescription = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsHardware.BOSError = "";
            this.fld_trlMMProductionNormItemsHardware.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsHardware.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsHardware.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsHardware.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsHardware.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsHardware.Location = new System.Drawing.Point(3, 36);
            this.fld_trlMMProductionNormItemsHardware.Name = "fld_trlMMProductionNormItemsHardware";
            this.fld_trlMMProductionNormItemsHardware.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsHardware.Screen = null;
            this.fld_trlMMProductionNormItemsHardware.Size = new System.Drawing.Size(1144, 571);
            this.fld_trlMMProductionNormItemsHardware.TabIndex = 94;
            this.fld_trlMMProductionNormItemsHardware.Tag = "DC";
            this.fld_trlMMProductionNormItemsHardware.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMProductionNormItemsHardware_NodeCellStyle);
            this.fld_trlMMProductionNormItemsHardware.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMProductionNormItemsHardware_CustomDrawNodeCell);
            this.fld_trlMMProductionNormItemsHardware.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsHardware_CellValueChanged);
            // 
            // fld_tabPaint
            // 
            this.fld_tabPaint.Controls.Add(this.fld_btnUpdatePaint);
            this.fld_tabPaint.Controls.Add(this.fld_trlMMProductionNormItemsPaint);
            this.fld_tabPaint.Name = "fld_tabPaint";
            this.fld_tabPaint.Size = new System.Drawing.Size(1152, 610);
            this.fld_tabPaint.Text = "ĐM Sơn";
            // 
            // fld_btnUpdatePaint
            // 
            this.fld_btnUpdatePaint.BOSComment = null;
            this.fld_btnUpdatePaint.BOSDataMember = null;
            this.fld_btnUpdatePaint.BOSDataSource = null;
            this.fld_btnUpdatePaint.BOSDescription = null;
            this.fld_btnUpdatePaint.BOSError = null;
            this.fld_btnUpdatePaint.BOSFieldGroup = null;
            this.fld_btnUpdatePaint.BOSFieldRelation = null;
            this.fld_btnUpdatePaint.BOSPrivilege = null;
            this.fld_btnUpdatePaint.BOSPropertyName = null;
            this.fld_btnUpdatePaint.Location = new System.Drawing.Point(10, 3);
            this.fld_btnUpdatePaint.Name = "fld_btnUpdatePaint";
            this.fld_btnUpdatePaint.Screen = null;
            this.fld_btnUpdatePaint.Size = new System.Drawing.Size(123, 27);
            this.fld_btnUpdatePaint.TabIndex = 97;
            this.fld_btnUpdatePaint.Text = "Cập nhật";
            this.fld_btnUpdatePaint.Click += new System.EventHandler(this.fld_btnUpdatePaint_Click);
            // 
            // fld_trlMMProductionNormItemsPaint
            // 
            this.fld_trlMMProductionNormItemsPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsPaint.BOSComment = "";
            this.fld_trlMMProductionNormItemsPaint.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMProductionNormItemsPaint.BOSDescription = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsPaint.BOSError = "";
            this.fld_trlMMProductionNormItemsPaint.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsPaint.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsPaint.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsPaint.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsPaint.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsPaint.Location = new System.Drawing.Point(3, 36);
            this.fld_trlMMProductionNormItemsPaint.Name = "fld_trlMMProductionNormItemsPaint";
            this.fld_trlMMProductionNormItemsPaint.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsPaint.Screen = null;
            this.fld_trlMMProductionNormItemsPaint.Size = new System.Drawing.Size(1144, 571);
            this.fld_trlMMProductionNormItemsPaint.TabIndex = 94;
            this.fld_trlMMProductionNormItemsPaint.Tag = "DC";
            this.fld_trlMMProductionNormItemsPaint.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMProductionNormItemsPaint_NodeCellStyle);
            this.fld_trlMMProductionNormItemsPaint.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMProductionNormItemsPaint_CustomDrawNodeCell);
            this.fld_trlMMProductionNormItemsPaint.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsPaint_CellValueChanged);
            // 
            // fld_tabPackaging
            // 
            this.fld_tabPackaging.Controls.Add(this.fld_btnUpdatePackaging);
            this.fld_tabPackaging.Controls.Add(this.fld_trlMMProductionNormItemsPackaging);
            this.fld_tabPackaging.Name = "fld_tabPackaging";
            this.fld_tabPackaging.Size = new System.Drawing.Size(1138, 603);
            this.fld_tabPackaging.Text = "ĐM Phụ liệu đóng gói";
            // 
            // fld_btnUpdatePackaging
            // 
            this.fld_btnUpdatePackaging.BOSComment = null;
            this.fld_btnUpdatePackaging.BOSDataMember = null;
            this.fld_btnUpdatePackaging.BOSDataSource = null;
            this.fld_btnUpdatePackaging.BOSDescription = null;
            this.fld_btnUpdatePackaging.BOSError = null;
            this.fld_btnUpdatePackaging.BOSFieldGroup = null;
            this.fld_btnUpdatePackaging.BOSFieldRelation = null;
            this.fld_btnUpdatePackaging.BOSPrivilege = null;
            this.fld_btnUpdatePackaging.BOSPropertyName = null;
            this.fld_btnUpdatePackaging.Location = new System.Drawing.Point(10, 3);
            this.fld_btnUpdatePackaging.Name = "fld_btnUpdatePackaging";
            this.fld_btnUpdatePackaging.Screen = null;
            this.fld_btnUpdatePackaging.Size = new System.Drawing.Size(123, 27);
            this.fld_btnUpdatePackaging.TabIndex = 96;
            this.fld_btnUpdatePackaging.Text = "Cập nhật";
            this.fld_btnUpdatePackaging.Click += new System.EventHandler(this.fld_btnUpdatePackaging_Click);
            // 
            // fld_trlMMProductionNormItemsPackaging
            // 
            this.fld_trlMMProductionNormItemsPackaging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsPackaging.BOSComment = "";
            this.fld_trlMMProductionNormItemsPackaging.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMProductionNormItemsPackaging.BOSDescription = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsPackaging.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsPackaging.BOSError = "";
            this.fld_trlMMProductionNormItemsPackaging.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsPackaging.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsPackaging.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsPackaging.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsPackaging.Location = new System.Drawing.Point(5, 41);
            this.fld_trlMMProductionNormItemsPackaging.Name = "fld_trlMMProductionNormItemsPackaging";
            this.fld_trlMMProductionNormItemsPackaging.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsPackaging.Screen = null;
            this.fld_trlMMProductionNormItemsPackaging.Size = new System.Drawing.Size(1130, 564);
            this.fld_trlMMProductionNormItemsPackaging.TabIndex = 94;
            this.fld_trlMMProductionNormItemsPackaging.Tag = "DC";
            this.fld_trlMMProductionNormItemsPackaging.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMProductionNormItemsPackaging_NodeCellStyle);
            this.fld_trlMMProductionNormItemsPackaging.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMProductionNormItemsPackaging_CustomDrawNodeCell);
            this.fld_trlMMProductionNormItemsPackaging.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsPackaging_CellValueChanged);
            // 
            // fld_tbGeneralMaterial
            // 
            this.fld_tbGeneralMaterial.Controls.Add(this.fld_trlMMProductionNormItemsGeneralMaterial);
            this.fld_tbGeneralMaterial.Controls.Add(this.fld_btnGeneralMaterial);
            this.fld_tbGeneralMaterial.Name = "fld_tbGeneralMaterial";
            this.fld_tbGeneralMaterial.Size = new System.Drawing.Size(1138, 603);
            this.fld_tbGeneralMaterial.Text = "Vật tư khác";
            // 
            // fld_trlMMProductionNormItemsGeneralMaterial
            // 
            this.fld_trlMMProductionNormItemsGeneralMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSComment = "";
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSDescription = null;
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSError = "";
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSFieldGroup = "";
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSPrivilege = "";
            this.fld_trlMMProductionNormItemsGeneralMaterial.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsGeneralMaterial.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsGeneralMaterial.Location = new System.Drawing.Point(1, 38);
            this.fld_trlMMProductionNormItemsGeneralMaterial.Name = "fld_trlMMProductionNormItemsGeneralMaterial";
            this.fld_trlMMProductionNormItemsGeneralMaterial.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsGeneralMaterial.Screen = null;
            this.fld_trlMMProductionNormItemsGeneralMaterial.Size = new System.Drawing.Size(1137, 564);
            this.fld_trlMMProductionNormItemsGeneralMaterial.TabIndex = 97;
            this.fld_trlMMProductionNormItemsGeneralMaterial.Tag = "DC";
            // 
            // fld_btnGeneralMaterial
            // 
            this.fld_btnGeneralMaterial.BOSComment = null;
            this.fld_btnGeneralMaterial.BOSDataMember = null;
            this.fld_btnGeneralMaterial.BOSDataSource = null;
            this.fld_btnGeneralMaterial.BOSDescription = null;
            this.fld_btnGeneralMaterial.BOSError = null;
            this.fld_btnGeneralMaterial.BOSFieldGroup = null;
            this.fld_btnGeneralMaterial.BOSFieldRelation = null;
            this.fld_btnGeneralMaterial.BOSPrivilege = null;
            this.fld_btnGeneralMaterial.BOSPropertyName = null;
            this.fld_btnGeneralMaterial.Location = new System.Drawing.Point(10, 5);
            this.fld_btnGeneralMaterial.Name = "fld_btnGeneralMaterial";
            this.fld_btnGeneralMaterial.Screen = null;
            this.fld_btnGeneralMaterial.Size = new System.Drawing.Size(123, 27);
            this.fld_btnGeneralMaterial.TabIndex = 96;
            this.fld_btnGeneralMaterial.Text = "Cập nhật";
            this.fld_btnGeneralMaterial.Click += new System.EventHandler(this.fld_btnGeneralMaterial_Click);
            // 
            // DMBP101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1154, 635);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBP101.IconOptions.Icon")));
            this.Name = "DMBP101";
            this.Text = "Thông tin NVL";
            this.Load += new System.EventHandler(this.DMBP101_Load);
            this.Click += new System.EventHandler(this.DMBP101_Click);
            this.Enter += new System.EventHandler(this.DMBP101_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DMBP101_MouseClick);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabSemiProduct.ResumeLayout(false);
            this.fld_tabSemiProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSumGoM3.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_radPropertiesOrProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMBatchProductProductionNormItems)).EndInit();
            this.fld_tabHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).EndInit();
            this.fld_tabPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).EndInit();
            this.fld_tabPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPackaging)).EndInit();
            this.fld_tbGeneralMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsGeneralMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSComponent.BOSTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private BOSComponent.BOSButton fld_btnUpdateWood;
        private ProductionNormItemsTreeListControl fld_trlMMBatchProductProductionNormItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabHardware;
        private BOSComponent.BOSButton fld_btnUpdateHardware;
        private ProductionNormItemsHardwareTreeListControl fld_trlMMProductionNormItemsHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaint;
        private BOSComponent.BOSButton fld_btnUpdatePaint;
        private ProductionNormItemsPaintTreeListControl fld_trlMMProductionNormItemsPaint;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackaging;
        private BOSComponent.BOSButton fld_btnUpdatePackaging;
        private ProductionNormItemsPackagingTreeListControl fld_trlMMProductionNormItemsPackaging;
        private DevExpress.XtraTab.XtraTabPage fld_tbGeneralMaterial;
        private BOSComponent.BOSButton fld_btnGeneralMaterial;
        private ProductionNormItemsGeneralMaterialTreeListControl fld_trlMMProductionNormItemsGeneralMaterial;
        private BOSComponent.BOSRadioGroup fld_radPropertiesOrProcess;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel18;
        private DevExpress.XtraEditors.TextEdit fld_lkeSumGoM3;
    }
}
