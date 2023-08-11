using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.ProductionPlanning.UI
{
	/// <summary>
	/// Summary description for DMOSS100
	/// </summary>
	partial class DMOSS100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMOSS100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtARProductionPlanningSaleOrderName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.BOSLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_recARProductionPlanningDesc = new BOSComponent.BOSRichEditControl(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARProductionPlanningSaleType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeApprovedID = new BOSComponent.BOSLookupEdit(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_btnClosePlaning = new BOSComponent.BOSButton(this.components);
            this.fld_btnXemVatTu = new BOSComponent.BOSButton(this.components);
            this.fld_btnChosePi = new BOSComponent.BOSButton(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_tabProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProductList = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARProductionPlanningItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcARProductionPlanningItems = new BOSERP.Modules.ProductionPlanning.ARProductionPlanningItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeARProductionPlanningStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARProductionPlanningDelivery = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARProductionPlanningApprovedDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARProductionPlanningDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtARProductionPlanningNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningSaleOrderName.Properties)).BeginInit();
            this.BOSLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningSaleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProductionPlanningItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProductionPlanningItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningApprovedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningApprovedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_txtARProductionPlanningSaleOrderName);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.BOSLine2);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_lkeARProductionPlanningSaleType);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLookupEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeApprovedID);
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.fld_tabProductionNorm);
            this.bosPanel1.Controls.Add(this.fld_lkeARProductionPlanningStatus);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosTextBox4);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_dteARProductionPlanningDelivery);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteARProductionPlanningApprovedDate);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_dteARProductionPlanningDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARProductionPlanningNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1511, 858);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_txtARProductionPlanningSaleOrderName
            // 
            this.fld_txtARProductionPlanningSaleOrderName.BOSComment = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSDataMember = "ARProductionPlanningSaleOrderName";
            this.fld_txtARProductionPlanningSaleOrderName.BOSDataSource = "ARProductionPlannings";
            this.fld_txtARProductionPlanningSaleOrderName.BOSDescription = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSError = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSFieldGroup = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSFieldRelation = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSPrivilege = null;
            this.fld_txtARProductionPlanningSaleOrderName.BOSPropertyName = "EditValue";
            this.fld_txtARProductionPlanningSaleOrderName.Location = new System.Drawing.Point(987, 139);
            this.fld_txtARProductionPlanningSaleOrderName.Name = "fld_txtARProductionPlanningSaleOrderName";
            this.fld_txtARProductionPlanningSaleOrderName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProductionPlanningSaleOrderName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProductionPlanningSaleOrderName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProductionPlanningSaleOrderName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProductionPlanningSaleOrderName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProductionPlanningSaleOrderName.Screen = null;
            this.fld_txtARProductionPlanningSaleOrderName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARProductionPlanningSaleOrderName.TabIndex = 811;
            this.fld_txtARProductionPlanningSaleOrderName.Tag = "DC";
            this.fld_txtARProductionPlanningSaleOrderName.Validated += new System.EventHandler(this.fld_txtARProductionPlanningSaleOrderName_Validated);
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(886, 142);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(94, 13);
            this.bosLabel15.TabIndex = 810;
            this.bosLabel15.Text = "Mã đơn hàng nội bộ";
            // 
            // BOSLine2
            // 
            this.BOSLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BOSLine2.BOSComment = null;
            this.BOSLine2.BOSDataMember = null;
            this.BOSLine2.BOSDataSource = null;
            this.BOSLine2.BOSDescription = null;
            this.BOSLine2.BOSError = null;
            this.BOSLine2.BOSFieldGroup = null;
            this.BOSLine2.BOSFieldRelation = null;
            this.BOSLine2.BOSPrivilege = null;
            this.BOSLine2.BOSPropertyName = null;
            this.BOSLine2.Controls.Add(this.fld_recARProductionPlanningDesc);
            this.BOSLine2.Location = new System.Drawing.Point(4, 626);
            this.BOSLine2.Name = "BOSLine2";
            this.BOSLine2.Screen = null;
            this.BOSLine2.Size = new System.Drawing.Size(628, 220);
            this.BOSLine2.TabIndex = 809;
            this.BOSLine2.TabStop = false;
            this.BOSLine2.Text = "Ghi chú";
            // 
            // fld_recARProductionPlanningDesc
            // 
            this.fld_recARProductionPlanningDesc.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARProductionPlanningDesc.BOSComment = null;
            this.fld_recARProductionPlanningDesc.BOSDataMember = null;
            this.fld_recARProductionPlanningDesc.BOSDataSource = null;
            this.fld_recARProductionPlanningDesc.BOSDescription = null;
            this.fld_recARProductionPlanningDesc.BOSError = null;
            this.fld_recARProductionPlanningDesc.BOSFieldGroup = null;
            this.fld_recARProductionPlanningDesc.BOSFieldRelation = null;
            this.fld_recARProductionPlanningDesc.BOSPrivilege = null;
            this.fld_recARProductionPlanningDesc.BOSPropertyName = null;
            this.fld_recARProductionPlanningDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_recARProductionPlanningDesc.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARProductionPlanningDesc.Location = new System.Drawing.Point(3, 17);
            this.fld_recARProductionPlanningDesc.MenuManager = this.screenToolbar;
            this.fld_recARProductionPlanningDesc.Name = "fld_recARProductionPlanningDesc";
            this.fld_recARProductionPlanningDesc.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARProductionPlanningDesc.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARProductionPlanningDesc.Screen = null;
            this.fld_recARProductionPlanningDesc.Size = new System.Drawing.Size(622, 200);
            this.fld_recARProductionPlanningDesc.TabIndex = 1;
            this.fld_recARProductionPlanningDesc.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(886, 116);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(94, 13);
            this.bosLabel14.TabIndex = 808;
            this.bosLabel14.Text = "Hình thức bán hàng";
            // 
            // fld_lkeARProductionPlanningSaleType
            // 
            this.fld_lkeARProductionPlanningSaleType.BOSAllowAddNew = false;
            this.fld_lkeARProductionPlanningSaleType.BOSAllowDummy = true;
            this.fld_lkeARProductionPlanningSaleType.BOSComment = null;
            this.fld_lkeARProductionPlanningSaleType.BOSDataMember = "ARProductionPlanningSaleType";
            this.fld_lkeARProductionPlanningSaleType.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeARProductionPlanningSaleType.BOSDescription = null;
            this.fld_lkeARProductionPlanningSaleType.BOSError = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldGroup = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldParent = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldRelation = null;
            this.fld_lkeARProductionPlanningSaleType.BOSPrivilege = null;
            this.fld_lkeARProductionPlanningSaleType.BOSPropertyName = "EditValue";
            this.fld_lkeARProductionPlanningSaleType.BOSSelectType = null;
            this.fld_lkeARProductionPlanningSaleType.BOSSelectTypeValue = null;
            this.fld_lkeARProductionPlanningSaleType.CurrentDisplayText = null;
            this.fld_lkeARProductionPlanningSaleType.Location = new System.Drawing.Point(987, 113);
            this.fld_lkeARProductionPlanningSaleType.Name = "fld_lkeARProductionPlanningSaleType";
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARProductionPlanningSaleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProductionPlanningSaleType.Properties.ColumnName = null;
            this.fld_lkeARProductionPlanningSaleType.Properties.NullText = "";
            this.fld_lkeARProductionPlanningSaleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProductionPlanningSaleType.Screen = null;
            this.fld_lkeARProductionPlanningSaleType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARProductionPlanningSaleType.TabIndex = 807;
            this.fld_lkeARProductionPlanningSaleType.Tag = "DC";
            this.fld_lkeARProductionPlanningSaleType.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeARProductionPlanningSaleType_Closed);
            // 
            // fld_lbWoodType
            // 
            this.fld_lbWoodType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.Options.UseBackColor = true;
            this.fld_lbWoodType.Appearance.Options.UseForeColor = true;
            this.fld_lbWoodType.BOSComment = null;
            this.fld_lbWoodType.BOSDataMember = null;
            this.fld_lbWoodType.BOSDataSource = null;
            this.fld_lbWoodType.BOSDescription = null;
            this.fld_lbWoodType.BOSError = null;
            this.fld_lbWoodType.BOSFieldGroup = null;
            this.fld_lbWoodType.BOSFieldRelation = null;
            this.fld_lbWoodType.BOSPrivilege = null;
            this.fld_lbWoodType.BOSPropertyName = null;
            this.fld_lbWoodType.Location = new System.Drawing.Point(886, 90);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 743;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(987, 87);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 742;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "ARProductionPlanningType";
            this.bosLookupEdit2.BOSDataSource = "ARProductionPlannings";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(987, 61);
            this.bosLookupEdit2.MenuManager = this.screenToolbar;
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 33;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(886, 65);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(67, 13);
            this.bosLabel13.TabIndex = 32;
            this.bosLabel13.Text = "Loại đơn hàng";
            // 
            // fld_lkeFK_HREmployeeApprovedID
            // 
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeApprovedID.BOSComment = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataMember = "FK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSError = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeApprovedID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeApprovedID.Location = new System.Drawing.Point(713, 35);
            this.fld_lkeFK_HREmployeeApprovedID.Name = "fld_lkeFK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeApprovedID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ReadOnly = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeApprovedID.Screen = null;
            this.fld_lkeFK_HREmployeeApprovedID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeApprovedID.TabIndex = 12;
            this.fld_lkeFK_HREmployeeApprovedID.Tag = "DC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_btnClosePlaning);
            this.groupBox1.Controls.Add(this.fld_btnXemVatTu);
            this.groupBox1.Controls.Add(this.fld_btnChosePi);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1156, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 136);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // fld_btnClosePlaning
            // 
            this.fld_btnClosePlaning.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnClosePlaning.Appearance.Options.UseFont = true;
            this.fld_btnClosePlaning.BOSComment = null;
            this.fld_btnClosePlaning.BOSDataMember = null;
            this.fld_btnClosePlaning.BOSDataSource = null;
            this.fld_btnClosePlaning.BOSDescription = null;
            this.fld_btnClosePlaning.BOSError = null;
            this.fld_btnClosePlaning.BOSFieldGroup = null;
            this.fld_btnClosePlaning.BOSFieldRelation = null;
            this.fld_btnClosePlaning.BOSPrivilege = null;
            this.fld_btnClosePlaning.BOSPropertyName = null;
            this.fld_btnClosePlaning.Enabled = false;
            this.fld_btnClosePlaning.Location = new System.Drawing.Point(10, 82);
            this.fld_btnClosePlaning.Name = "fld_btnClosePlaning";
            this.fld_btnClosePlaning.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClosePlaning, true);
            this.fld_btnClosePlaning.Size = new System.Drawing.Size(119, 25);
            this.fld_btnClosePlaning.TabIndex = 2;
            this.fld_btnClosePlaning.Text = "Đóng kế hoạch";
            this.fld_btnClosePlaning.Click += new System.EventHandler(this.fld_btnClosePlaning_Click);
            // 
            // fld_btnXemVatTu
            // 
            this.fld_btnXemVatTu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnXemVatTu.Appearance.Options.UseFont = true;
            this.fld_btnXemVatTu.BOSComment = null;
            this.fld_btnXemVatTu.BOSDataMember = null;
            this.fld_btnXemVatTu.BOSDataSource = null;
            this.fld_btnXemVatTu.BOSDescription = null;
            this.fld_btnXemVatTu.BOSError = null;
            this.fld_btnXemVatTu.BOSFieldGroup = null;
            this.fld_btnXemVatTu.BOSFieldRelation = null;
            this.fld_btnXemVatTu.BOSPrivilege = null;
            this.fld_btnXemVatTu.BOSPropertyName = null;
            this.fld_btnXemVatTu.Location = new System.Drawing.Point(10, 51);
            this.fld_btnXemVatTu.Name = "fld_btnXemVatTu";
            this.fld_btnXemVatTu.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnXemVatTu, true);
            this.fld_btnXemVatTu.Size = new System.Drawing.Size(119, 25);
            this.fld_btnXemVatTu.TabIndex = 1;
            this.fld_btnXemVatTu.Text = "Xem vật tư đặc biệt";
            this.fld_btnXemVatTu.Click += new System.EventHandler(this.fld_btnXemVatTu_Click);
            // 
            // fld_btnChosePi
            // 
            this.fld_btnChosePi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fld_btnChosePi.BOSComment = null;
            this.fld_btnChosePi.BOSDataMember = null;
            this.fld_btnChosePi.BOSDataSource = null;
            this.fld_btnChosePi.BOSDescription = null;
            this.fld_btnChosePi.BOSError = null;
            this.fld_btnChosePi.BOSFieldGroup = null;
            this.fld_btnChosePi.BOSFieldRelation = null;
            this.fld_btnChosePi.BOSPrivilege = null;
            this.fld_btnChosePi.BOSPropertyName = null;
            this.fld_btnChosePi.Location = new System.Drawing.Point(10, 20);
            this.fld_btnChosePi.Name = "fld_btnChosePi";
            this.fld_btnChosePi.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChosePi, true);
            this.fld_btnChosePi.Size = new System.Drawing.Size(119, 25);
            this.fld_btnChosePi.TabIndex = 0;
            this.fld_btnChosePi.Text = "Chọn từ đơn hàng";
            this.fld_btnChosePi.Click += new System.EventHandler(this.fld_btnChosePi_Click);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ARProductionPlanningSources";
            this.bosLookupEdit1.BOSDataSource = "ARProductionPlannings";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(987, 35);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 24;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.bosLookupEdit1_Closed);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(886, 39);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(31, 13);
            this.bosLabel9.TabIndex = 23;
            this.bosLabel9.Text = "Nguồn";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(212, 61);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopNo", "Mã xưởng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 14;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ARProductionPlanningFromDate";
            this.bosDateEdit1.BOSDataSource = "ARProductionPlannings";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(470, 35);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 10;
            this.bosDateEdit1.Tag = "DC";
            this.bosDateEdit1.Validated += new System.EventHandler(this.bosDateEdit1_Validated);
            // 
            // fld_tabProductionNorm
            // 
            this.fld_tabProductionNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductionNorm.BOSComment = null;
            this.fld_tabProductionNorm.BOSDataMember = null;
            this.fld_tabProductionNorm.BOSDataSource = null;
            this.fld_tabProductionNorm.BOSDescription = null;
            this.fld_tabProductionNorm.BOSError = null;
            this.fld_tabProductionNorm.BOSFieldGroup = null;
            this.fld_tabProductionNorm.BOSFieldRelation = null;
            this.fld_tabProductionNorm.BOSPrivilege = null;
            this.fld_tabProductionNorm.BOSPropertyName = null;
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(3, 165);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.Screen = null;
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabProductList;
            this.ScreenHelper.SetShowHelp(this.fld_tabProductionNorm, true);
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(1505, 455);
            this.fld_tabProductionNorm.TabIndex = 31;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductList});
            // 
            // fld_tabProductList
            // 
            this.fld_tabProductList.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_tabProductList.Controls.Add(this.bosLabel10);
            this.fld_tabProductList.Controls.Add(this.fld_pteARProductionPlanningItemProductPicture);
            this.fld_tabProductList.Controls.Add(this.fld_dgcARProductionPlanningItems);
            this.fld_tabProductList.Name = "fld_tabProductList";
            this.ScreenHelper.SetShowHelp(this.fld_tabProductList, true);
            this.fld_tabProductList.Size = new System.Drawing.Size(1503, 430);
            this.fld_tabProductList.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARProductionPlanningItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 7);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, true);
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1308, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 30;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(10, 12);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(47, 13);
            this.bosLabel10.TabIndex = 31;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Sản phẩm";
            // 
            // fld_pteARProductionPlanningItemProductPicture
            // 
            this.fld_pteARProductionPlanningItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARProductionPlanningItemProductPicture.BOSComment = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSDataMember = "ARProductionPlanningItemProductPicture";
            this.fld_pteARProductionPlanningItemProductPicture.BOSDataSource = "ARProductionPlanningItems";
            this.fld_pteARProductionPlanningItemProductPicture.BOSDescription = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSError = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSPrivilege = null;
            this.fld_pteARProductionPlanningItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARProductionPlanningItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARProductionPlanningItemProductPicture.FileName = null;
            this.fld_pteARProductionPlanningItemProductPicture.FilePath = null;
            this.fld_pteARProductionPlanningItemProductPicture.Location = new System.Drawing.Point(1377, 6);
            this.fld_pteARProductionPlanningItemProductPicture.Name = "fld_pteARProductionPlanningItemProductPicture";
            this.fld_pteARProductionPlanningItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARProductionPlanningItemProductPicture.Screen = null;
            this.fld_pteARProductionPlanningItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteARProductionPlanningItemProductPicture.TabIndex = 1;
            this.fld_pteARProductionPlanningItemProductPicture.Tag = "DC";
            // 
            // fld_dgcARProductionPlanningItems
            // 
            this.fld_dgcARProductionPlanningItems.AllowDrop = true;
            this.fld_dgcARProductionPlanningItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARProductionPlanningItems.BOSComment = null;
            this.fld_dgcARProductionPlanningItems.BOSDataMember = null;
            this.fld_dgcARProductionPlanningItems.BOSDataSource = "ARProductionPlanningItems";
            this.fld_dgcARProductionPlanningItems.BOSDescription = null;
            this.fld_dgcARProductionPlanningItems.BOSError = null;
            this.fld_dgcARProductionPlanningItems.BOSFieldGroup = null;
            this.fld_dgcARProductionPlanningItems.BOSFieldRelation = null;
            this.fld_dgcARProductionPlanningItems.BOSGridType = null;
            this.fld_dgcARProductionPlanningItems.BOSPrivilege = null;
            this.fld_dgcARProductionPlanningItems.BOSPropertyName = null;
            this.fld_dgcARProductionPlanningItems.CommodityType = "";
            this.fld_dgcARProductionPlanningItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARProductionPlanningItems.Location = new System.Drawing.Point(7, 35);
            this.fld_dgcARProductionPlanningItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARProductionPlanningItems.Name = "fld_dgcARProductionPlanningItems";
            this.fld_dgcARProductionPlanningItems.PrintReport = false;
            this.fld_dgcARProductionPlanningItems.Screen = null;
            this.fld_dgcARProductionPlanningItems.Size = new System.Drawing.Size(1364, 391);
            this.fld_dgcARProductionPlanningItems.TabIndex = 0;
            this.fld_dgcARProductionPlanningItems.Tag = "DC";
            this.fld_dgcARProductionPlanningItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARProductionPlanningItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_lkeARProductionPlanningStatus
            // 
            this.fld_lkeARProductionPlanningStatus.BOSAllowAddNew = false;
            this.fld_lkeARProductionPlanningStatus.BOSAllowDummy = false;
            this.fld_lkeARProductionPlanningStatus.BOSComment = null;
            this.fld_lkeARProductionPlanningStatus.BOSDataMember = "ARProductionPlanningStatus";
            this.fld_lkeARProductionPlanningStatus.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeARProductionPlanningStatus.BOSDescription = null;
            this.fld_lkeARProductionPlanningStatus.BOSError = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldGroup = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldParent = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldRelation = null;
            this.fld_lkeARProductionPlanningStatus.BOSPrivilege = null;
            this.fld_lkeARProductionPlanningStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARProductionPlanningStatus.BOSSelectType = null;
            this.fld_lkeARProductionPlanningStatus.BOSSelectTypeValue = null;
            this.fld_lkeARProductionPlanningStatus.CurrentDisplayText = null;
            this.fld_lkeARProductionPlanningStatus.Enabled = false;
            this.fld_lkeARProductionPlanningStatus.Location = new System.Drawing.Point(987, 9);
            this.fld_lkeARProductionPlanningStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARProductionPlanningStatus.Name = "fld_lkeARProductionPlanningStatus";
            this.fld_lkeARProductionPlanningStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARProductionPlanningStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProductionPlanningStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProductionPlanningStatus.Properties.ColumnName = null;
            this.fld_lkeARProductionPlanningStatus.Properties.NullText = "";
            this.fld_lkeARProductionPlanningStatus.Properties.ReadOnly = true;
            this.fld_lkeARProductionPlanningStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProductionPlanningStatus.Screen = null;
            this.fld_lkeARProductionPlanningStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARProductionPlanningStatus.TabIndex = 20;
            this.fld_lkeARProductionPlanningStatus.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(886, 13);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(49, 13);
            this.bosLabel12.TabIndex = 19;
            this.bosLabel12.Text = "Tình trạng";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(639, 39);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel25.TabIndex = 11;
            this.fld_lblLabel25.Text = "Người duyệt";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARProductionPlanningName";
            this.bosTextBox1.BOSDataSource = "ARProductionPlannings";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(212, 35);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(118, 65);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(76, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Xưởng sản xuất";
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
            this.bosLabel1.Location = new System.Drawing.Point(118, 39);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARProductionPlanningTotalBlock";
            this.bosTextBox4.BOSDataSource = "ARProductionPlannings";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(713, 113);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.DisplayFormat.FormatString = "n2";
            this.bosTextBox4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox4.Properties.EditFormat.FormatString = "n2";
            this.bosTextBox4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox4.Properties.Mask.EditMask = "n2";
            this.bosTextBox4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 26;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARProductionPlanningContQty";
            this.bosTextBox2.BOSDataSource = "ARProductionPlannings";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Enabled = false;
            this.bosTextBox2.Location = new System.Drawing.Point(713, 87);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.DisplayFormat.FormatString = "n2";
            this.bosTextBox2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox2.Properties.EditFormat.FormatString = "n2";
            this.bosTextBox2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox2.Properties.Mask.EditMask = "n2";
            this.bosTextBox2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 22;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ARProductionPlanningCBM";
            this.bosTextBox3.BOSDataSource = "ARProductionPlannings";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(713, 61);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.DisplayFormat.FormatString = "n";
            this.bosTextBox3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox3.Properties.EditFormat.FormatString = "n";
            this.bosTextBox3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox3.Properties.Mask.EditMask = "n";
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 18;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(383, 38);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(40, 13);
            this.bosLabel23.TabIndex = 9;
            this.bosLabel23.Text = "Từ ngày";
            // 
            // fld_dteARProductionPlanningDelivery
            // 
            this.fld_dteARProductionPlanningDelivery.BOSComment = null;
            this.fld_dteARProductionPlanningDelivery.BOSDataMember = "ARProductionPlanningToDate";
            this.fld_dteARProductionPlanningDelivery.BOSDataSource = "ARProductionPlannings";
            this.fld_dteARProductionPlanningDelivery.BOSDescription = null;
            this.fld_dteARProductionPlanningDelivery.BOSError = null;
            this.fld_dteARProductionPlanningDelivery.BOSFieldGroup = null;
            this.fld_dteARProductionPlanningDelivery.BOSFieldRelation = null;
            this.fld_dteARProductionPlanningDelivery.BOSPrivilege = null;
            this.fld_dteARProductionPlanningDelivery.BOSPropertyName = "EditValue";
            this.fld_dteARProductionPlanningDelivery.EditValue = null;
            this.fld_dteARProductionPlanningDelivery.Location = new System.Drawing.Point(470, 61);
            this.fld_dteARProductionPlanningDelivery.Name = "fld_dteARProductionPlanningDelivery";
            this.fld_dteARProductionPlanningDelivery.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARProductionPlanningDelivery.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARProductionPlanningDelivery.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARProductionPlanningDelivery.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARProductionPlanningDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProductionPlanningDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProductionPlanningDelivery.Screen = null;
            this.fld_dteARProductionPlanningDelivery.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARProductionPlanningDelivery.TabIndex = 16;
            this.fld_dteARProductionPlanningDelivery.Tag = "DC";
            this.fld_dteARProductionPlanningDelivery.Validated += new System.EventHandler(this.fld_dteARProductionPlanningDelivery_Validated);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(639, 117);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(62, 13);
            this.bosLabel8.TabIndex = 25;
            this.bosLabel8.Text = "Tổng số cont";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(639, 90);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 21;
            this.bosLabel6.Text = "Tổng khối tinh";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(639, 66);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 17;
            this.bosLabel5.Text = "Tổng CBM";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(383, 65);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteARProductionPlanningApprovedDate
            // 
            this.fld_dteARProductionPlanningApprovedDate.BOSComment = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSDataMember = "ARProductionPlanningApprovedDate";
            this.fld_dteARProductionPlanningApprovedDate.BOSDataSource = "ARProductionPlannings";
            this.fld_dteARProductionPlanningApprovedDate.BOSDescription = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSError = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSFieldGroup = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSFieldRelation = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSPrivilege = null;
            this.fld_dteARProductionPlanningApprovedDate.BOSPropertyName = "EditValue";
            this.fld_dteARProductionPlanningApprovedDate.EditValue = null;
            this.fld_dteARProductionPlanningApprovedDate.Location = new System.Drawing.Point(713, 9);
            this.fld_dteARProductionPlanningApprovedDate.Name = "fld_dteARProductionPlanningApprovedDate";
            this.fld_dteARProductionPlanningApprovedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARProductionPlanningApprovedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARProductionPlanningApprovedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARProductionPlanningApprovedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARProductionPlanningApprovedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProductionPlanningApprovedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProductionPlanningApprovedDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.fld_dteARProductionPlanningApprovedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteARProductionPlanningApprovedDate.Properties.ReadOnly = true;
            this.fld_dteARProductionPlanningApprovedDate.Screen = null;
            this.fld_dteARProductionPlanningApprovedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARProductionPlanningApprovedDate.TabIndex = 6;
            this.fld_dteARProductionPlanningApprovedDate.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(639, 13);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(56, 13);
            this.bosLabel11.TabIndex = 5;
            this.bosLabel11.Text = "Ngày duyệt";
            // 
            // fld_dteARProductionPlanningDate
            // 
            this.fld_dteARProductionPlanningDate.BOSComment = null;
            this.fld_dteARProductionPlanningDate.BOSDataMember = "ARProductionPlanningDate";
            this.fld_dteARProductionPlanningDate.BOSDataSource = "ARProductionPlannings";
            this.fld_dteARProductionPlanningDate.BOSDescription = null;
            this.fld_dteARProductionPlanningDate.BOSError = null;
            this.fld_dteARProductionPlanningDate.BOSFieldGroup = null;
            this.fld_dteARProductionPlanningDate.BOSFieldRelation = null;
            this.fld_dteARProductionPlanningDate.BOSPrivilege = null;
            this.fld_dteARProductionPlanningDate.BOSPropertyName = "EditValue";
            this.fld_dteARProductionPlanningDate.EditValue = null;
            this.fld_dteARProductionPlanningDate.Location = new System.Drawing.Point(470, 9);
            this.fld_dteARProductionPlanningDate.Name = "fld_dteARProductionPlanningDate";
            this.fld_dteARProductionPlanningDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARProductionPlanningDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARProductionPlanningDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARProductionPlanningDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARProductionPlanningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARProductionPlanningDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARProductionPlanningDate.Screen = null;
            this.fld_dteARProductionPlanningDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARProductionPlanningDate.TabIndex = 4;
            this.fld_dteARProductionPlanningDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(383, 13);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 3;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = "";
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARProductionPlanningComment";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARProductionPlannings";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = "";
            this.fld_medARSaleOrderDesc.BOSFieldRelation = "";
            this.fld_medARSaleOrderDesc.BOSPrivilege = "";
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.EditValue = "";
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(212, 87);
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARSaleOrderDesc, true);
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(408, 69);
            this.fld_medARSaleOrderDesc.TabIndex = 28;
            this.fld_medARSaleOrderDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(118, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 27;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_pteARSaleOrderEmployeePicture
            // 
            this.fld_pteARSaleOrderEmployeePicture.BOSComment = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSDataMember = "ARProductionPlanningEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataSource = "ARProductionPlannings";
            this.fld_pteARSaleOrderEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSError = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleOrderEmployeePicture.FileName = null;
            this.fld_pteARSaleOrderEmployeePicture.FilePath = null;
            this.fld_pteARSaleOrderEmployeePicture.Location = new System.Drawing.Point(7, 9);
            this.fld_pteARSaleOrderEmployeePicture.Name = "fld_pteARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARSaleOrderEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARSaleOrderEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderEmployeePicture.Screen = null;
            this.fld_pteARSaleOrderEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARSaleOrderEmployeePicture.TabIndex = 0;
            this.fld_pteARSaleOrderEmployeePicture.Tag = "DC";
            // 
            // fld_txtARProductionPlanningNo
            // 
            this.fld_txtARProductionPlanningNo.BOSComment = null;
            this.fld_txtARProductionPlanningNo.BOSDataMember = "ARProductionPlanningNo";
            this.fld_txtARProductionPlanningNo.BOSDataSource = "ARProductionPlannings";
            this.fld_txtARProductionPlanningNo.BOSDescription = null;
            this.fld_txtARProductionPlanningNo.BOSError = null;
            this.fld_txtARProductionPlanningNo.BOSFieldGroup = null;
            this.fld_txtARProductionPlanningNo.BOSFieldRelation = null;
            this.fld_txtARProductionPlanningNo.BOSPrivilege = null;
            this.fld_txtARProductionPlanningNo.BOSPropertyName = "EditValue";
            this.fld_txtARProductionPlanningNo.Location = new System.Drawing.Point(212, 9);
            this.fld_txtARProductionPlanningNo.MenuManager = this.screenToolbar;
            this.fld_txtARProductionPlanningNo.Name = "fld_txtARProductionPlanningNo";
            this.fld_txtARProductionPlanningNo.Screen = null;
            this.fld_txtARProductionPlanningNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARProductionPlanningNo.TabIndex = 2;
            this.fld_txtARProductionPlanningNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(118, 13);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 1;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(7, 111);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 29;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMOSS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1511, 858);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMOSS100.IconOptions.Icon")));
            this.Name = "DMOSS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningSaleOrderName.Properties)).EndInit();
            this.BOSLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningSaleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabProductList.ResumeLayout(false);
            this.fld_tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARProductionPlanningItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProductionPlanningItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningApprovedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningApprovedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARProductionPlanningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnChosePi;
        private BOSERP.Modules.ProductionPlanning.ARProductionPlanningItemsGridControl fld_dgcARProductionPlanningItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtARProductionPlanningNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARProductionPlanningDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeARProductionPlanningStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSPictureEdit fld_pteARProductionPlanningItemProductPicture;
        private BOSComponent.BOSDateEdit fld_dteARProductionPlanningDelivery;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnXemVatTu;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel10;
        private GroupBox groupBox1;
        private BOSComponent.BOSButton fld_btnClosePlaning;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeApprovedID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSDateEdit fld_dteARProductionPlanningApprovedDate;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeARProductionPlanningSaleType;
        private BOSComponent.BOSLine BOSLine2;
        private BOSComponent.BOSRichEditControl fld_recARProductionPlanningDesc;
        private BOSTextBox fld_txtARProductionPlanningSaleOrderName;
        private BOSLabel bosLabel15;
    }
}
