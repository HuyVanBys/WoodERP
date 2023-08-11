using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DeliveryPlan.UI
{
    /// <summary>
    /// Summary description for DMDP100
    /// </summary>
    partial class DMDP100
    {
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanDate;
        private BOSComponent.BOSLabel fld_lblLabel26;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMDP100));
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDeliveryPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_recARDeliveryPlanComment = new BOSComponent.BOSRichEditControl(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel60 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lbPono = new BOSComponent.BOSLabel(this.components);
            this.bosLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeDeliveryPlanProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDeliveryPlanEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDeliveryPlanBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDeliveryPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARDeliveryPlanItemsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanItemsGridControl();
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAttributionSaleOrderTruckFrom = new BOSComponent.BOSButton(this.components);
            this.fld_btnAttributionItemTruck = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanTrucksGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanTrucksGridControl();
            this.fld_btnAddTruck = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARDeliveryPlanTruckPointsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanTruckPointsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddWork = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanWorksGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanWorksGridControl();
            this.fld_btnDistributionEmployee = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcPMTasksGridControl = new BOSERP.Modules.DeliveryPlan.PMTaskSumarysGridControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddAsset = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanWorkAssetsGridControl();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanWorkMaterialsGridControl();
            this.fld_medARDeliveryPlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.arDeliveryPlanItemsGridControl1 = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanItemsGridControl();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.arDeliveryPlanItemsGridControl2 = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanItemsGridControl();
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.BOSLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeDeliveryPlanProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlansMachineDeviceGridControl)).BeginInit();
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanItemsGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTrucksGridControl)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckPointsGridControl)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorksGridControl)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorkAssetsGridControl)).BeginInit();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorkMaterialsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDeliveryPlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arDeliveryPlanItemsGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arDeliveryPlanItemsGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pteARSaleOrderEmployeePicture
            // 
            this.fld_pteARSaleOrderEmployeePicture.BOSComment = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSDataMember = "ARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataSource = "ARSaleOrders";
            this.fld_pteARSaleOrderEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSError = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARSaleOrderEmployeePicture.FileName = null;
            this.fld_pteARSaleOrderEmployeePicture.FilePath = null;
            this.fld_pteARSaleOrderEmployeePicture.Location = new System.Drawing.Point(3, 4);
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
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARDeliveryPlans";
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 106);
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
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(128, 38);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel10.TabIndex = 7;
            this.fld_lblLabel10.Text = "Tên chứng từ";
            // 
            // fld_dteARDeliveryPlanDate
            // 
            this.fld_dteARDeliveryPlanDate.BOSComment = null;
            this.fld_dteARDeliveryPlanDate.BOSDataMember = "ARDeliveryPlanDate";
            this.fld_dteARDeliveryPlanDate.BOSDataSource = "ARDeliveryPlans";
            this.fld_dteARDeliveryPlanDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanDate.BOSError = null;
            this.fld_dteARDeliveryPlanDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanDate.EditValue = null;
            this.fld_dteARDeliveryPlanDate.Location = new System.Drawing.Point(468, 9);
            this.fld_dteARDeliveryPlanDate.Name = "fld_dteARDeliveryPlanDate";
            this.fld_dteARDeliveryPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanDate.Screen = null;
            this.fld_dteARDeliveryPlanDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARDeliveryPlanDate.TabIndex = 3;
            this.fld_dteARDeliveryPlanDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(390, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
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
            this.bosLabel7.Location = new System.Drawing.Point(128, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_txtARDeliveryPlanNo
            // 
            this.fld_txtARDeliveryPlanNo.BOSComment = null;
            this.fld_txtARDeliveryPlanNo.BOSDataMember = "ARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARDeliveryPlanNo.BOSError = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanNo.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanNo.Location = new System.Drawing.Point(205, 9);
            this.fld_txtARDeliveryPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtARDeliveryPlanNo.Name = "fld_txtARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.Screen = null;
            this.fld_txtARDeliveryPlanNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARDeliveryPlanNo.TabIndex = 2;
            this.fld_txtARDeliveryPlanNo.Tag = "DC";
            // 
            // fld_txtARDeliveryPlanName
            // 
            this.fld_txtARDeliveryPlanName.BOSComment = null;
            this.fld_txtARDeliveryPlanName.BOSDataMember = "ARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanName.BOSDescription = null;
            this.fld_txtARDeliveryPlanName.BOSError = null;
            this.fld_txtARDeliveryPlanName.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanName.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanName.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanName.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanName.Location = new System.Drawing.Point(205, 35);
            this.fld_txtARDeliveryPlanName.Name = "fld_txtARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDeliveryPlanName.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtARDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDeliveryPlanName.Screen = null;
            this.fld_txtARDeliveryPlanName.Size = new System.Drawing.Size(413, 20);
            this.fld_txtARDeliveryPlanName.TabIndex = 5;
            this.fld_txtARDeliveryPlanName.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosTextBox6);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosTextBox5);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.BOSLine2);
            this.bosPanel1.Controls.Add(this.bosTextBox4);
            this.bosPanel1.Controls.Add(this.bosLabel60);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.fld_lbPono);
            this.bosPanel1.Controls.Add(this.bosLabel62);
            this.bosPanel1.Controls.Add(this.fld_lkeDeliveryPlanProductType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel38);
            this.bosPanel1.Controls.Add(this.fld_dteARDeliveryPlanEndDate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteARDeliveryPlanBeginDate);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeARDeliveryPlanStatus);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_dgcARDeliveryPlansMachineDeviceGridControl);
            this.bosPanel1.Controls.Add(this.fld_medARDeliveryPlanDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARDeliveryPlanNo);
            this.bosPanel1.Controls.Add(this.fld_txtARDeliveryPlanName);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_dteARDeliveryPlanDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1237, 781);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARSaleOrderName";
            this.bosTextBox1.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(759, 165);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 841;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(654, 168);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(94, 13);
            this.bosLabel1.TabIndex = 840;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã đơn hàng nội bộ";
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
            this.BOSLine2.Controls.Add(this.fld_recARDeliveryPlanComment);
            this.BOSLine2.Location = new System.Drawing.Point(4, 581);
            this.BOSLine2.Name = "BOSLine2";
            this.BOSLine2.Screen = null;
            this.BOSLine2.Size = new System.Drawing.Size(614, 188);
            this.BOSLine2.TabIndex = 839;
            this.BOSLine2.TabStop = false;
            this.BOSLine2.Text = "Ghi chú";
            // 
            // fld_recARDeliveryPlanComment
            // 
            this.fld_recARDeliveryPlanComment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.fld_recARDeliveryPlanComment.BOSComment = null;
            this.fld_recARDeliveryPlanComment.BOSDataMember = null;
            this.fld_recARDeliveryPlanComment.BOSDataSource = null;
            this.fld_recARDeliveryPlanComment.BOSDescription = null;
            this.fld_recARDeliveryPlanComment.BOSError = null;
            this.fld_recARDeliveryPlanComment.BOSFieldGroup = null;
            this.fld_recARDeliveryPlanComment.BOSFieldRelation = null;
            this.fld_recARDeliveryPlanComment.BOSPrivilege = null;
            this.fld_recARDeliveryPlanComment.BOSPropertyName = null;
            this.fld_recARDeliveryPlanComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_recARDeliveryPlanComment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.fld_recARDeliveryPlanComment.Location = new System.Drawing.Point(3, 17);
            this.fld_recARDeliveryPlanComment.MenuManager = this.screenToolbar;
            this.fld_recARDeliveryPlanComment.Name = "fld_recARDeliveryPlanComment";
            this.fld_recARDeliveryPlanComment.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARDeliveryPlanComment.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.fld_recARDeliveryPlanComment.Screen = null;
            this.fld_recARDeliveryPlanComment.Size = new System.Drawing.Size(608, 168);
            this.fld_recARDeliveryPlanComment.TabIndex = 1;
            this.fld_recARDeliveryPlanComment.Tag = "DC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARDeliveryPlanProject";
            this.bosTextBox4.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(759, 61);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 838;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel60
            // 
            this.bosLabel60.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel60.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel60.Appearance.Options.UseBackColor = true;
            this.bosLabel60.Appearance.Options.UseForeColor = true;
            this.bosLabel60.BOSComment = "";
            this.bosLabel60.BOSDataMember = "";
            this.bosLabel60.BOSDataSource = "";
            this.bosLabel60.BOSDescription = null;
            this.bosLabel60.BOSError = null;
            this.bosLabel60.BOSFieldGroup = "";
            this.bosLabel60.BOSFieldRelation = "";
            this.bosLabel60.BOSPrivilege = "";
            this.bosLabel60.BOSPropertyName = "";
            this.bosLabel60.Location = new System.Drawing.Point(128, 64);
            this.bosLabel60.Name = "bosLabel60";
            this.bosLabel60.Screen = null;
            this.bosLabel60.Size = new System.Drawing.Size(48, 13);
            this.bosLabel60.TabIndex = 751;
            this.bosLabel60.Tag = "";
            this.bosLabel60.Text = "Đối tượng";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARDeliveryPlans";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(205, 61);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.ReadOnly = true;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(413, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 7;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ARDeliveryPlanPONo";
            this.bosTextBox3.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(759, 35);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.ReadOnly = true;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 6;
            this.bosTextBox3.Tag = "DC";
            // 
            // fld_lbPono
            // 
            this.fld_lbPono.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPono.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPono.Appearance.Options.UseBackColor = true;
            this.fld_lbPono.Appearance.Options.UseForeColor = true;
            this.fld_lbPono.BOSComment = null;
            this.fld_lbPono.BOSDataMember = null;
            this.fld_lbPono.BOSDataSource = null;
            this.fld_lbPono.BOSDescription = null;
            this.fld_lbPono.BOSError = null;
            this.fld_lbPono.BOSFieldGroup = null;
            this.fld_lbPono.BOSFieldRelation = null;
            this.fld_lbPono.BOSPrivilege = null;
            this.fld_lbPono.BOSPropertyName = null;
            this.fld_lbPono.Location = new System.Drawing.Point(654, 38);
            this.fld_lbPono.Name = "fld_lbPono";
            this.fld_lbPono.Screen = null;
            this.fld_lbPono.Size = new System.Drawing.Size(46, 13);
            this.fld_lbPono.TabIndex = 749;
            this.fld_lbPono.Text = "Số PO.No";
            // 
            // bosLabel62
            // 
            this.bosLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel62.Appearance.Options.UseBackColor = true;
            this.bosLabel62.Appearance.Options.UseForeColor = true;
            this.bosLabel62.BOSComment = null;
            this.bosLabel62.BOSDataMember = null;
            this.bosLabel62.BOSDataSource = null;
            this.bosLabel62.BOSDescription = null;
            this.bosLabel62.BOSError = null;
            this.bosLabel62.BOSFieldGroup = null;
            this.bosLabel62.BOSFieldRelation = null;
            this.bosLabel62.BOSPrivilege = null;
            this.bosLabel62.BOSPropertyName = null;
            this.bosLabel62.Location = new System.Drawing.Point(654, 142);
            this.bosLabel62.Name = "bosLabel62";
            this.bosLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel62, true);
            this.bosLabel62.Size = new System.Drawing.Size(67, 13);
            this.bosLabel62.TabIndex = 747;
            this.bosLabel62.Text = "Loại hàng hóa";
            // 
            // fld_lkeDeliveryPlanProductType
            // 
            this.fld_lkeDeliveryPlanProductType.BOSAllowAddNew = false;
            this.fld_lkeDeliveryPlanProductType.BOSAllowDummy = false;
            this.fld_lkeDeliveryPlanProductType.BOSComment = null;
            this.fld_lkeDeliveryPlanProductType.BOSDataMember = "ARDeliveryPlanProductType";
            this.fld_lkeDeliveryPlanProductType.BOSDataSource = "ARDeliveryPlans";
            this.fld_lkeDeliveryPlanProductType.BOSDescription = null;
            this.fld_lkeDeliveryPlanProductType.BOSError = null;
            this.fld_lkeDeliveryPlanProductType.BOSFieldGroup = null;
            this.fld_lkeDeliveryPlanProductType.BOSFieldParent = null;
            this.fld_lkeDeliveryPlanProductType.BOSFieldRelation = null;
            this.fld_lkeDeliveryPlanProductType.BOSPrivilege = null;
            this.fld_lkeDeliveryPlanProductType.BOSPropertyName = "EditValue";
            this.fld_lkeDeliveryPlanProductType.BOSSelectType = "";
            this.fld_lkeDeliveryPlanProductType.BOSSelectTypeValue = "";
            this.fld_lkeDeliveryPlanProductType.CurrentDisplayText = null;
            this.fld_lkeDeliveryPlanProductType.Location = new System.Drawing.Point(759, 139);
            this.fld_lkeDeliveryPlanProductType.Name = "fld_lkeDeliveryPlanProductType";
            this.fld_lkeDeliveryPlanProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeDeliveryPlanProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeDeliveryPlanProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeDeliveryPlanProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeDeliveryPlanProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeDeliveryPlanProductType.Properties.ColumnName = null;
            this.fld_lkeDeliveryPlanProductType.Properties.NullText = "";
            this.fld_lkeDeliveryPlanProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeDeliveryPlanProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeDeliveryPlanProductType, true);
            this.fld_lkeDeliveryPlanProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeDeliveryPlanProductType.TabIndex = 14;
            this.fld_lkeDeliveryPlanProductType.Tag = "DC";
            this.fld_lkeDeliveryPlanProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeDeliveryPlanProductType_CloseUp);
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ARDeliveryPlans";
            this.fld_lkeFK_ICStockID1.BOSDescription = null;
            this.fld_lkeFK_ICStockID1.BOSError = "";
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(759, 113);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 13;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ICStockID1_CloseUp);
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = "";
            this.fld_Lablel3.BOSDataSource = "";
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = "";
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(654, 116);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 745;
            this.fld_Lablel3.Text = "Kho";
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
            this.fld_lbWoodType.Location = new System.Drawing.Point(654, 90);
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
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ARDeliveryPlans";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(759, 87);
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ReadOnly = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 11;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.Options.UseBackColor = true;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = "";
            this.bosLabel38.BOSDataMember = "";
            this.bosLabel38.BOSDataSource = "";
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = "";
            this.bosLabel38.BOSFieldRelation = "";
            this.bosLabel38.BOSPrivilege = "";
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.Location = new System.Drawing.Point(654, 64);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(45, 13);
            this.bosLabel38.TabIndex = 713;
            this.bosLabel38.Tag = "";
            this.bosLabel38.Text = "Mã dự án";
            // 
            // fld_dteARDeliveryPlanEndDate
            // 
            this.fld_dteARDeliveryPlanEndDate.BOSComment = null;
            this.fld_dteARDeliveryPlanEndDate.BOSDataMember = "ARDeliveryPlanEndDate";
            this.fld_dteARDeliveryPlanEndDate.BOSDataSource = "ARDeliveryPlans";
            this.fld_dteARDeliveryPlanEndDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanEndDate.BOSError = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanEndDate.EditValue = null;
            this.fld_dteARDeliveryPlanEndDate.Location = new System.Drawing.Point(468, 87);
            this.fld_dteARDeliveryPlanEndDate.Name = "fld_dteARDeliveryPlanEndDate";
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanEndDate.Screen = null;
            this.fld_dteARDeliveryPlanEndDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARDeliveryPlanEndDate.TabIndex = 10;
            this.fld_dteARDeliveryPlanEndDate.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(390, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 133;
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteARDeliveryPlanBeginDate
            // 
            this.fld_dteARDeliveryPlanBeginDate.BOSComment = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSDataMember = "ARDeliveryPlanBeginDate";
            this.fld_dteARDeliveryPlanBeginDate.BOSDataSource = "ARDeliveryPlans";
            this.fld_dteARDeliveryPlanBeginDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSError = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanBeginDate.EditValue = null;
            this.fld_dteARDeliveryPlanBeginDate.Location = new System.Drawing.Point(205, 87);
            this.fld_dteARDeliveryPlanBeginDate.Name = "fld_dteARDeliveryPlanBeginDate";
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanBeginDate.Screen = null;
            this.fld_dteARDeliveryPlanBeginDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARDeliveryPlanBeginDate.TabIndex = 9;
            this.fld_dteARDeliveryPlanBeginDate.Tag = "DC";
            this.fld_dteARDeliveryPlanBeginDate.Validated += new System.EventHandler(this.fld_dteARDeliveryPlanBeginDate_Validated);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(128, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 131;
            this.bosLabel2.Text = "Từ ngày";
            // 
            // fld_lkeARDeliveryPlanStatus
            // 
            this.fld_lkeARDeliveryPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeARDeliveryPlanStatus.BOSAllowDummy = false;
            this.fld_lkeARDeliveryPlanStatus.BOSComment = "";
            this.fld_lkeARDeliveryPlanStatus.BOSDataMember = "ARDeliveryPlanStatus";
            this.fld_lkeARDeliveryPlanStatus.BOSDataSource = "ARDeliveryPlans";
            this.fld_lkeARDeliveryPlanStatus.BOSDescription = null;
            this.fld_lkeARDeliveryPlanStatus.BOSError = null;
            this.fld_lkeARDeliveryPlanStatus.BOSFieldGroup = "";
            this.fld_lkeARDeliveryPlanStatus.BOSFieldParent = "";
            this.fld_lkeARDeliveryPlanStatus.BOSFieldRelation = "";
            this.fld_lkeARDeliveryPlanStatus.BOSPrivilege = "";
            this.fld_lkeARDeliveryPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanStatus.BOSSelectType = "";
            this.fld_lkeARDeliveryPlanStatus.BOSSelectTypeValue = "";
            this.fld_lkeARDeliveryPlanStatus.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanStatus.Location = new System.Drawing.Point(759, 9);
            this.fld_lkeARDeliveryPlanStatus.Name = "fld_lkeARDeliveryPlanStatus";
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanStatus.Properties.ColumnName = null;
            this.fld_lkeARDeliveryPlanStatus.Properties.NullText = "";
            this.fld_lkeARDeliveryPlanStatus.Properties.ReadOnly = true;
            this.fld_lkeARDeliveryPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDeliveryPlanStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARDeliveryPlanStatus, true);
            this.fld_lkeARDeliveryPlanStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARDeliveryPlanStatus.TabIndex = 4;
            this.fld_lkeARDeliveryPlanStatus.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(654, 12);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 129;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_dgcARDeliveryPlansMachineDeviceGridControl
            // 
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Location = new System.Drawing.Point(3, 191);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Name = "fld_dgcARDeliveryPlansMachineDeviceGridControl";
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Screen = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.SelectedTabPage = this.xtraTabPage1;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Size = new System.Drawing.Size(1222, 384);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.TabIndex = 15;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4,
            this.xtraTabPage3,
            this.xtraTabPage5,
            this.xtraTabPage6,
            this.xtraTabPage7});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARDeliveryPlanItemsGridControl);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1220, 359);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcARDeliveryPlanItemsGridControl
            // 
            this.fld_dgcARDeliveryPlanItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSDataSource = "ARDeliveryPlanItems";
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanItemsGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcARDeliveryPlanItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanItemsGridControl.Name = "fld_dgcARDeliveryPlanItemsGridControl";
            this.fld_dgcARDeliveryPlanItemsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanItemsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanItemsGridControl.Size = new System.Drawing.Size(1212, 319);
            this.fld_dgcARDeliveryPlanItemsGridControl.TabIndex = 31;
            this.fld_dgcARDeliveryPlanItemsGridControl.Tag = "";
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = "";
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = "";
            this.fld_btnAddProduct.BOSFieldRelation = "";
            this.fld_btnAddProduct.BOSPrivilege = "";
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(119, 27);
            this.fld_btnAddProduct.TabIndex = 30;
            this.fld_btnAddProduct.Tag = "AddProduct";
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnAttributionSaleOrderTruckFrom);
            this.xtraTabPage2.Controls.Add(this.fld_btnAttributionItemTruck);
            this.xtraTabPage2.Controls.Add(this.fld_dgcARDeliveryPlanTrucksGridControl);
            this.xtraTabPage2.Controls.Add(this.fld_btnAddTruck);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage2.Text = "Danh sách xe";
            // 
            // fld_btnAttributionSaleOrderTruckFrom
            // 
            this.fld_btnAttributionSaleOrderTruckFrom.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAttributionSaleOrderTruckFrom.Appearance.Options.UseForeColor = true;
            this.fld_btnAttributionSaleOrderTruckFrom.BOSComment = "";
            this.fld_btnAttributionSaleOrderTruckFrom.BOSDataMember = null;
            this.fld_btnAttributionSaleOrderTruckFrom.BOSDataSource = null;
            this.fld_btnAttributionSaleOrderTruckFrom.BOSDescription = null;
            this.fld_btnAttributionSaleOrderTruckFrom.BOSError = null;
            this.fld_btnAttributionSaleOrderTruckFrom.BOSFieldGroup = "";
            this.fld_btnAttributionSaleOrderTruckFrom.BOSFieldRelation = "";
            this.fld_btnAttributionSaleOrderTruckFrom.BOSPrivilege = "";
            this.fld_btnAttributionSaleOrderTruckFrom.BOSPropertyName = null;
            this.fld_btnAttributionSaleOrderTruckFrom.Location = new System.Drawing.Point(129, 3);
            this.fld_btnAttributionSaleOrderTruckFrom.Name = "fld_btnAttributionSaleOrderTruckFrom";
            this.fld_btnAttributionSaleOrderTruckFrom.Screen = null;
            this.fld_btnAttributionSaleOrderTruckFrom.Size = new System.Drawing.Size(125, 27);
            this.fld_btnAttributionSaleOrderTruckFrom.TabIndex = 34;
            this.fld_btnAttributionSaleOrderTruckFrom.Tag = "AttributionTruck";
            this.fld_btnAttributionSaleOrderTruckFrom.Text = "Phân bổ theo đơn hàng";
            this.fld_btnAttributionSaleOrderTruckFrom.Click += new System.EventHandler(this.fld_btnAttributionSaleOrderTruck_Click);
            // 
            // fld_btnAttributionItemTruck
            // 
            this.fld_btnAttributionItemTruck.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAttributionItemTruck.Appearance.Options.UseForeColor = true;
            this.fld_btnAttributionItemTruck.BOSComment = "";
            this.fld_btnAttributionItemTruck.BOSDataMember = null;
            this.fld_btnAttributionItemTruck.BOSDataSource = null;
            this.fld_btnAttributionItemTruck.BOSDescription = null;
            this.fld_btnAttributionItemTruck.BOSError = null;
            this.fld_btnAttributionItemTruck.BOSFieldGroup = "";
            this.fld_btnAttributionItemTruck.BOSFieldRelation = "";
            this.fld_btnAttributionItemTruck.BOSPrivilege = "";
            this.fld_btnAttributionItemTruck.BOSPropertyName = null;
            this.fld_btnAttributionItemTruck.Location = new System.Drawing.Point(260, 3);
            this.fld_btnAttributionItemTruck.Name = "fld_btnAttributionItemTruck";
            this.fld_btnAttributionItemTruck.Screen = null;
            this.fld_btnAttributionItemTruck.Size = new System.Drawing.Size(139, 27);
            this.fld_btnAttributionItemTruck.TabIndex = 33;
            this.fld_btnAttributionItemTruck.Tag = "AttributionTruck";
            this.fld_btnAttributionItemTruck.Text = "Phân bổ sản phẩm vào xe";
            this.fld_btnAttributionItemTruck.Click += new System.EventHandler(this.fld_btnAttributionItemTruck_Click);
            // 
            // fld_dgcARDeliveryPlanTrucksGridControl
            // 
            this.fld_dgcARDeliveryPlanTrucksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSDataSource = "ARDeliveryPlanTrucks";
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanTrucksGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcARDeliveryPlanTrucksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanTrucksGridControl.Name = "fld_dgcARDeliveryPlanTrucksGridControl";
            this.fld_dgcARDeliveryPlanTrucksGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanTrucksGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanTrucksGridControl.Size = new System.Drawing.Size(949, 312);
            this.fld_dgcARDeliveryPlanTrucksGridControl.TabIndex = 32;
            // 
            // fld_btnAddTruck
            // 
            this.fld_btnAddTruck.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddTruck.Appearance.Options.UseForeColor = true;
            this.fld_btnAddTruck.BOSComment = "";
            this.fld_btnAddTruck.BOSDataMember = null;
            this.fld_btnAddTruck.BOSDataSource = null;
            this.fld_btnAddTruck.BOSDescription = null;
            this.fld_btnAddTruck.BOSError = null;
            this.fld_btnAddTruck.BOSFieldGroup = "";
            this.fld_btnAddTruck.BOSFieldRelation = "";
            this.fld_btnAddTruck.BOSPrivilege = "";
            this.fld_btnAddTruck.BOSPropertyName = null;
            this.fld_btnAddTruck.Location = new System.Drawing.Point(4, 3);
            this.fld_btnAddTruck.Name = "fld_btnAddTruck";
            this.fld_btnAddTruck.Screen = null;
            this.fld_btnAddTruck.Size = new System.Drawing.Size(119, 27);
            this.fld_btnAddTruck.TabIndex = 31;
            this.fld_btnAddTruck.Tag = "AddTruck";
            this.fld_btnAddTruck.Text = "Thêm xe";
            this.fld_btnAddTruck.Click += new System.EventHandler(this.fld_btnDistributionTruck_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcARDeliveryPlanTruckPointsGridControl);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage4.Text = "Danh sách điểm giao hàng";
            // 
            // fld_dgcARDeliveryPlanTruckPointsGridControl
            // 
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDataSource = "ARDeliveryPlanTruckPoints";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Name = "fld_dgcARDeliveryPlanTruckPointsGridControl";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Size = new System.Drawing.Size(949, 329);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.TabIndex = 33;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_btnAddWork);
            this.xtraTabPage3.Controls.Add(this.fld_dgcARDeliveryPlanWorksGridControl);
            this.xtraTabPage3.Controls.Add(this.fld_btnDistributionEmployee);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage3.Text = "Danh sách công việc";
            // 
            // fld_btnAddWork
            // 
            this.fld_btnAddWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddWork.BOSComment = "";
            this.fld_btnAddWork.BOSDataMember = null;
            this.fld_btnAddWork.BOSDataSource = null;
            this.fld_btnAddWork.BOSDescription = null;
            this.fld_btnAddWork.BOSError = null;
            this.fld_btnAddWork.BOSFieldGroup = "";
            this.fld_btnAddWork.BOSFieldRelation = "";
            this.fld_btnAddWork.BOSPrivilege = "";
            this.fld_btnAddWork.BOSPropertyName = null;
            this.fld_btnAddWork.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAddWork.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddWork.Name = "fld_btnAddWork";
            this.fld_btnAddWork.Screen = null;
            this.fld_btnAddWork.Size = new System.Drawing.Size(112, 27);
            this.fld_btnAddWork.TabIndex = 34;
            this.fld_btnAddWork.Tag = "";
            this.fld_btnAddWork.Text = "Thêm công việc";
            this.fld_btnAddWork.Click += new System.EventHandler(this.fld_btnAddWork_Click);
            // 
            // fld_dgcARDeliveryPlanWorksGridControl
            // 
            this.fld_dgcARDeliveryPlanWorksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSDataSource = "ARDeliveryPlanWorks";
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanWorksGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcARDeliveryPlanWorksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanWorksGridControl.Name = "fld_dgcARDeliveryPlanWorksGridControl";
            this.fld_dgcARDeliveryPlanWorksGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanWorksGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanWorksGridControl.Size = new System.Drawing.Size(949, 312);
            this.fld_dgcARDeliveryPlanWorksGridControl.TabIndex = 33;
            // 
            // fld_btnDistributionEmployee
            // 
            this.fld_btnDistributionEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDistributionEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnDistributionEmployee.BOSComment = "";
            this.fld_btnDistributionEmployee.BOSDataMember = null;
            this.fld_btnDistributionEmployee.BOSDataSource = null;
            this.fld_btnDistributionEmployee.BOSDescription = null;
            this.fld_btnDistributionEmployee.BOSError = null;
            this.fld_btnDistributionEmployee.BOSFieldGroup = "";
            this.fld_btnDistributionEmployee.BOSFieldRelation = "";
            this.fld_btnDistributionEmployee.BOSPrivilege = "";
            this.fld_btnDistributionEmployee.BOSPropertyName = null;
            this.fld_btnDistributionEmployee.Location = new System.Drawing.Point(123, 3);
            this.fld_btnDistributionEmployee.Name = "fld_btnDistributionEmployee";
            this.fld_btnDistributionEmployee.Screen = null;
            this.fld_btnDistributionEmployee.Size = new System.Drawing.Size(157, 27);
            this.fld_btnDistributionEmployee.TabIndex = 32;
            this.fld_btnDistributionEmployee.Tag = "DistributionEmployee";
            this.fld_btnDistributionEmployee.Text = "Phân bổ nhân viên lắp đặt";
            this.fld_btnDistributionEmployee.Click += new System.EventHandler(this.fld_btnDistributionEmployee_Click);
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_dgcPMTasksGridControl);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage5.Text = "Danh sách Task";
            // 
            // fld_dgcPMTasksGridControl
            // 
            this.fld_dgcPMTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMTasksGridControl.BOSComment = null;
            this.fld_dgcPMTasksGridControl.BOSDataMember = null;
            this.fld_dgcPMTasksGridControl.BOSDataSource = "PMTasks";
            this.fld_dgcPMTasksGridControl.BOSDescription = null;
            this.fld_dgcPMTasksGridControl.BOSError = null;
            this.fld_dgcPMTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcPMTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcPMTasksGridControl.BOSGridType = null;
            this.fld_dgcPMTasksGridControl.BOSPrivilege = null;
            this.fld_dgcPMTasksGridControl.BOSPropertyName = null;
            this.fld_dgcPMTasksGridControl.CommodityType = "";
            this.fld_dgcPMTasksGridControl.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcPMTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMTasksGridControl.Name = "fld_dgcPMTasksGridControl";
            this.fld_dgcPMTasksGridControl.PrintReport = false;
            this.fld_dgcPMTasksGridControl.Screen = null;
            this.fld_dgcPMTasksGridControl.Size = new System.Drawing.Size(949, 329);
            this.fld_dgcPMTasksGridControl.TabIndex = 34;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.fld_btnAddAsset);
            this.xtraTabPage6.Controls.Add(this.fld_dgcARDeliveryPlanWorkAssetsGridControl);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage6.Text = "Danh sách MMTB";
            // 
            // fld_btnAddAsset
            // 
            this.fld_btnAddAsset.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddAsset.Appearance.Options.UseForeColor = true;
            this.fld_btnAddAsset.BOSComment = "";
            this.fld_btnAddAsset.BOSDataMember = null;
            this.fld_btnAddAsset.BOSDataSource = null;
            this.fld_btnAddAsset.BOSDescription = null;
            this.fld_btnAddAsset.BOSError = null;
            this.fld_btnAddAsset.BOSFieldGroup = "";
            this.fld_btnAddAsset.BOSFieldRelation = "";
            this.fld_btnAddAsset.BOSPrivilege = "";
            this.fld_btnAddAsset.BOSPropertyName = null;
            this.fld_btnAddAsset.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddAsset.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddAsset.Name = "fld_btnAddAsset";
            this.fld_btnAddAsset.Screen = null;
            this.fld_btnAddAsset.Size = new System.Drawing.Size(144, 27);
            this.fld_btnAddAsset.TabIndex = 14;
            this.fld_btnAddAsset.Tag = "";
            this.fld_btnAddAsset.Text = "Thêm máy móc thiết bị";
            this.fld_btnAddAsset.Click += new System.EventHandler(this.fld_btnAddAsset_Click);
            // 
            // fld_dgcARDeliveryPlanWorkAssetsGridControl
            // 
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSDataSource = "ARDeliveryPlanWorks";
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.Location = new System.Drawing.Point(4, 36);
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.Name = "fld_dgcARDeliveryPlanWorkAssetsGridControl";
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.Size = new System.Drawing.Size(950, 319);
            this.fld_dgcARDeliveryPlanWorkAssetsGridControl.TabIndex = 0;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.fld_btnAddMaterial);
            this.xtraTabPage7.Controls.Add(this.fld_dgcARDeliveryPlanWorkMaterialsGridControl);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(957, 352);
            this.xtraTabPage7.Text = "Danh sách vật tư";
            // 
            // fld_btnAddMaterial
            // 
            this.fld_btnAddMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnAddMaterial.BOSComment = "";
            this.fld_btnAddMaterial.BOSDataMember = null;
            this.fld_btnAddMaterial.BOSDataSource = null;
            this.fld_btnAddMaterial.BOSDescription = null;
            this.fld_btnAddMaterial.BOSError = null;
            this.fld_btnAddMaterial.BOSFieldGroup = "";
            this.fld_btnAddMaterial.BOSFieldRelation = "";
            this.fld_btnAddMaterial.BOSPrivilege = "";
            this.fld_btnAddMaterial.BOSPropertyName = null;
            this.fld_btnAddMaterial.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnAddMaterial.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddMaterial.Name = "fld_btnAddMaterial";
            this.fld_btnAddMaterial.Screen = null;
            this.fld_btnAddMaterial.Size = new System.Drawing.Size(113, 27);
            this.fld_btnAddMaterial.TabIndex = 13;
            this.fld_btnAddMaterial.Tag = "";
            this.fld_btnAddMaterial.Text = "Thêm vật tư";
            this.fld_btnAddMaterial.Click += new System.EventHandler(this.fld_btnAddMaterial_Click);
            // 
            // fld_dgcARDeliveryPlanWorkMaterialsGridControl
            // 
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSDataSource = "ARDeliveryPlanWorks";
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.CommodityType = "";
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.Location = new System.Drawing.Point(6, 36);
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.Name = "fld_dgcARDeliveryPlanWorkMaterialsGridControl";
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.Size = new System.Drawing.Size(951, 316);
            this.fld_dgcARDeliveryPlanWorkMaterialsGridControl.TabIndex = 1;
            // 
            // fld_medARDeliveryPlanDesc
            // 
            this.fld_medARDeliveryPlanDesc.BOSComment = "";
            this.fld_medARDeliveryPlanDesc.BOSDataMember = "ARDeliveryPlanDesc";
            this.fld_medARDeliveryPlanDesc.BOSDataSource = "ARDeliveryPlans";
            this.fld_medARDeliveryPlanDesc.BOSDescription = null;
            this.fld_medARDeliveryPlanDesc.BOSError = null;
            this.fld_medARDeliveryPlanDesc.BOSFieldGroup = "";
            this.fld_medARDeliveryPlanDesc.BOSFieldRelation = "";
            this.fld_medARDeliveryPlanDesc.BOSPrivilege = "";
            this.fld_medARDeliveryPlanDesc.BOSPropertyName = "EditValue";
            this.fld_medARDeliveryPlanDesc.EditValue = "";
            this.fld_medARDeliveryPlanDesc.Location = new System.Drawing.Point(205, 113);
            this.fld_medARDeliveryPlanDesc.Name = "fld_medARDeliveryPlanDesc";
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARDeliveryPlanDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARDeliveryPlanDesc, true);
            this.fld_medARDeliveryPlanDesc.Size = new System.Drawing.Size(413, 68);
            this.fld_medARDeliveryPlanDesc.TabIndex = 12;
            this.fld_medARDeliveryPlanDesc.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(128, 116);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // arDeliveryPlanItemsGridControl1
            // 
            this.arDeliveryPlanItemsGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arDeliveryPlanItemsGridControl1.BOSComment = null;
            this.arDeliveryPlanItemsGridControl1.BOSDataMember = null;
            this.arDeliveryPlanItemsGridControl1.BOSDataSource = "ARDeliveryPlanItems";
            this.arDeliveryPlanItemsGridControl1.BOSDescription = null;
            this.arDeliveryPlanItemsGridControl1.BOSError = null;
            this.arDeliveryPlanItemsGridControl1.BOSFieldGroup = null;
            this.arDeliveryPlanItemsGridControl1.BOSFieldRelation = null;
            this.arDeliveryPlanItemsGridControl1.BOSGridType = null;
            this.arDeliveryPlanItemsGridControl1.BOSPrivilege = null;
            this.arDeliveryPlanItemsGridControl1.BOSPropertyName = null;
            this.arDeliveryPlanItemsGridControl1.CommodityType = "";
            this.arDeliveryPlanItemsGridControl1.Location = new System.Drawing.Point(5, 36);
            this.arDeliveryPlanItemsGridControl1.MenuManager = this.screenToolbar;
            this.arDeliveryPlanItemsGridControl1.Name = "arDeliveryPlanItemsGridControl1";
            this.arDeliveryPlanItemsGridControl1.PrintReport = false;
            this.arDeliveryPlanItemsGridControl1.Screen = null;
            this.arDeliveryPlanItemsGridControl1.Size = new System.Drawing.Size(969, 304);
            this.arDeliveryPlanItemsGridControl1.TabIndex = 31;
            // 
            // bosButton2
            // 
            this.bosButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton2.Appearance.Options.UseForeColor = true;
            this.bosButton2.BOSComment = "";
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = "";
            this.bosButton2.BOSFieldRelation = "";
            this.bosButton2.BOSPrivilege = "";
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(5, 3);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(119, 27);
            this.bosButton2.TabIndex = 30;
            this.bosButton2.Tag = "AddProduct";
            this.bosButton2.Text = "Thêm sản phẩm";
            // 
            // arDeliveryPlanItemsGridControl2
            // 
            this.arDeliveryPlanItemsGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arDeliveryPlanItemsGridControl2.BOSComment = null;
            this.arDeliveryPlanItemsGridControl2.BOSDataMember = null;
            this.arDeliveryPlanItemsGridControl2.BOSDataSource = "ARDeliveryPlanItems";
            this.arDeliveryPlanItemsGridControl2.BOSDescription = null;
            this.arDeliveryPlanItemsGridControl2.BOSError = null;
            this.arDeliveryPlanItemsGridControl2.BOSFieldGroup = null;
            this.arDeliveryPlanItemsGridControl2.BOSFieldRelation = null;
            this.arDeliveryPlanItemsGridControl2.BOSGridType = null;
            this.arDeliveryPlanItemsGridControl2.BOSPrivilege = null;
            this.arDeliveryPlanItemsGridControl2.BOSPropertyName = null;
            this.arDeliveryPlanItemsGridControl2.CommodityType = "";
            this.arDeliveryPlanItemsGridControl2.Location = new System.Drawing.Point(5, 36);
            this.arDeliveryPlanItemsGridControl2.MenuManager = this.screenToolbar;
            this.arDeliveryPlanItemsGridControl2.Name = "arDeliveryPlanItemsGridControl2";
            this.arDeliveryPlanItemsGridControl2.PrintReport = false;
            this.arDeliveryPlanItemsGridControl2.Screen = null;
            this.arDeliveryPlanItemsGridControl2.Size = new System.Drawing.Size(969, 304);
            this.arDeliveryPlanItemsGridControl2.TabIndex = 31;
            // 
            // bosButton3
            // 
            this.bosButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton3.Appearance.Options.UseForeColor = true;
            this.bosButton3.BOSComment = "";
            this.bosButton3.BOSDataMember = null;
            this.bosButton3.BOSDataSource = null;
            this.bosButton3.BOSDescription = null;
            this.bosButton3.BOSError = null;
            this.bosButton3.BOSFieldGroup = "";
            this.bosButton3.BOSFieldRelation = "";
            this.bosButton3.BOSPrivilege = "";
            this.bosButton3.BOSPropertyName = null;
            this.bosButton3.Location = new System.Drawing.Point(5, 3);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(119, 27);
            this.bosButton3.TabIndex = 30;
            this.bosButton3.Tag = "AddProduct";
            this.bosButton3.Text = "Thêm sản phẩm";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARDeliveryPlanContainersNumber";
            this.bosTextBox2.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(1057, 9);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 843;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(952, 12);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(60, 13);
            this.bosLabel5.TabIndex = 842;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Số container";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARDeliveryPlanSeal";
            this.bosTextBox5.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            this.bosTextBox5.Location = new System.Drawing.Point(1057, 35);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 845;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(952, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(34, 13);
            this.bosLabel6.TabIndex = 844;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Số seal";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARDeliveryPlanInternalSeal";
            this.bosTextBox6.BOSDataSource = "ARDeliveryPlans";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            this.bosTextBox6.Location = new System.Drawing.Point(1057, 61);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox6.TabIndex = 847;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(952, 64);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 846;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Số seal nội bộ";
            // 
            // DMDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1237, 781);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMDP100.IconOptions.Icon")));
            this.Name = "DMDP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.BOSLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeDeliveryPlanProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlansMachineDeviceGridControl)).EndInit();
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanItemsGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTrucksGridControl)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckPointsGridControl)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorksGridControl)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorkAssetsGridControl)).EndInit();
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanWorkMaterialsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDeliveryPlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arDeliveryPlanItemsGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arDeliveryPlanItemsGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanNo;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanName;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSMemoEdit fld_medARDeliveryPlanDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanEndDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanBeginDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTabControl fld_dgcARDeliveryPlansMachineDeviceGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARDeliveryPlanItemsGridControl fld_dgcARDeliveryPlanItemsGridControl;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnAttributionItemTruck;
        private ARDeliveryPlanTrucksGridControl fld_dgcARDeliveryPlanTrucksGridControl;
        private BOSComponent.BOSButton fld_btnAddTruck;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private ARDeliveryPlanTruckPointsGridControl fld_dgcARDeliveryPlanTruckPointsGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ARDeliveryPlanWorksGridControl fld_dgcARDeliveryPlanWorksGridControl;
        private BOSComponent.BOSButton fld_btnDistributionEmployee;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private PMTaskSumarysGridControl fld_dgcPMTasksGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private ARDeliveryPlanItemsGridControl arDeliveryPlanItemsGridControl1;
        private BOSComponent.BOSButton bosButton2;
        private ARDeliveryPlanItemsGridControl arDeliveryPlanItemsGridControl2;
        private BOSComponent.BOSButton bosButton3;
        private ARDeliveryPlanWorkAssetsGridControl fld_dgcARDeliveryPlanWorkAssetsGridControl;
        private BOSComponent.BOSButton fld_btnAddWork;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private ARDeliveryPlanWorkMaterialsGridControl fld_dgcARDeliveryPlanWorkMaterialsGridControl;
        private BOSComponent.BOSButton fld_btnAddMaterial;
        private BOSComponent.BOSButton fld_btnAddAsset;
        private BOSComponent.BOSButton fld_btnAttributionSaleOrderTruckFrom;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel62;
        private BOSComponent.BOSLookupEdit fld_lkeDeliveryPlanProductType;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel fld_lbPono;
        private BOSComponent.BOSLabel bosLabel60;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLine BOSLine2;
        private BOSComponent.BOSRichEditControl fld_recARDeliveryPlanComment;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel5;
    }
}
