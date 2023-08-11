using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleWork.UI
{
    /// <summary>
    /// Summary description for DMSW100
    /// </summary>
    partial class DMSW100
    {
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSDateEdit fld_dteAREstimateDate;
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
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAREstimateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteARDeliveryPlanEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDeliveryPlanBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDeliveryPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDeliveryPlanType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcPMSaleWorksItemsGridControl = new BOSERP.Modules.SaleWork.ARSaleWorkItemsGridControl();
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_medARDeliveryPlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlansMachineDeviceGridControl)).BeginInit();
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMSaleWorksItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDeliveryPlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "PMSaleWorks";
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
            this.fld_lblLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(128, 38);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(44, 13);
            this.fld_lblLabel10.TabIndex = 7;
            this.fld_lblLabel10.Text = "Kế hoạch";
            // 
            // fld_dteAREstimateDate
            // 
            this.fld_dteAREstimateDate.BOSComment = null;
            this.fld_dteAREstimateDate.BOSDataMember = "PMSaleWorkDate";
            this.fld_dteAREstimateDate.BOSDataSource = "PMSaleWorks";
            this.fld_dteAREstimateDate.BOSDescription = null;
            this.fld_dteAREstimateDate.BOSError = null;
            this.fld_dteAREstimateDate.BOSFieldGroup = null;
            this.fld_dteAREstimateDate.BOSFieldRelation = null;
            this.fld_dteAREstimateDate.BOSPrivilege = null;
            this.fld_dteAREstimateDate.BOSPropertyName = "EditValue";
            this.fld_dteAREstimateDate.EditValue = null;
            this.fld_dteAREstimateDate.Location = new System.Drawing.Point(517, 9);
            this.fld_dteAREstimateDate.Name = "fld_dteAREstimateDate";
            this.fld_dteAREstimateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAREstimateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAREstimateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAREstimateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAREstimateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAREstimateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAREstimateDate.Screen = null;
            this.fld_dteAREstimateDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAREstimateDate.TabIndex = 1;
            this.fld_dteAREstimateDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(407, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Text = "Ngày kế hoạch";
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
            this.bosLabel7.Size = new System.Drawing.Size(60, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "Mã kế hoạch";
            // 
            // fld_txtARDeliveryPlanNo
            // 
            this.fld_txtARDeliveryPlanNo.BOSComment = null;
            this.fld_txtARDeliveryPlanNo.BOSDataMember = "PMSaleWorkNo";
            this.fld_txtARDeliveryPlanNo.BOSDataSource = "PMSaleWorks";
            this.fld_txtARDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARDeliveryPlanNo.BOSError = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanNo.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanNo.Location = new System.Drawing.Point(222, 9);
            this.fld_txtARDeliveryPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtARDeliveryPlanNo.Name = "fld_txtARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.Screen = null;
            this.fld_txtARDeliveryPlanNo.Size = new System.Drawing.Size(168, 20);
            this.fld_txtARDeliveryPlanNo.TabIndex = 0;
            this.fld_txtARDeliveryPlanNo.Tag = "DC";
            // 
            // fld_txtARDeliveryPlanName
            // 
            this.fld_txtARDeliveryPlanName.BOSComment = null;
            this.fld_txtARDeliveryPlanName.BOSDataMember = "PMSaleWorkName";
            this.fld_txtARDeliveryPlanName.BOSDataSource = "PMSaleWorks";
            this.fld_txtARDeliveryPlanName.BOSDescription = null;
            this.fld_txtARDeliveryPlanName.BOSError = null;
            this.fld_txtARDeliveryPlanName.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanName.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanName.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanName.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanName.Location = new System.Drawing.Point(222, 35);
            this.fld_txtARDeliveryPlanName.Name = "fld_txtARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Mask.EditMask = "n";
            this.fld_txtARDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDeliveryPlanName.Screen = null;
            this.fld_txtARDeliveryPlanName.Size = new System.Drawing.Size(445, 20);
            this.fld_txtARDeliveryPlanName.TabIndex = 2;
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
            this.bosPanel1.Controls.Add(this.fld_dteARDeliveryPlanEndDate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteARDeliveryPlanBeginDate);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeARDeliveryPlanStatus);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeARDeliveryPlanType);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dgcARDeliveryPlansMachineDeviceGridControl);
            this.bosPanel1.Controls.Add(this.fld_medARDeliveryPlanDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARDeliveryPlanNo);
            this.bosPanel1.Controls.Add(this.fld_txtARDeliveryPlanName);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_dteAREstimateDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1002, 491);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_dteARDeliveryPlanEndDate
            // 
            this.fld_dteARDeliveryPlanEndDate.BOSComment = null;
            this.fld_dteARDeliveryPlanEndDate.BOSDataMember = "PMSaleWorkEndDate";
            this.fld_dteARDeliveryPlanEndDate.BOSDataSource = "PMSaleWorks";
            this.fld_dteARDeliveryPlanEndDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanEndDate.BOSError = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanEndDate.EditValue = null;
            this.fld_dteARDeliveryPlanEndDate.Location = new System.Drawing.Point(517, 87);
            this.fld_dteARDeliveryPlanEndDate.Name = "fld_dteARDeliveryPlanEndDate";
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanEndDate.Screen = null;
            this.fld_dteARDeliveryPlanEndDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARDeliveryPlanEndDate.TabIndex = 6;
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
            this.bosLabel4.Location = new System.Drawing.Point(407, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 133;
            this.bosLabel4.Text = "Đến ngày";
            // 
            // fld_dteARDeliveryPlanBeginDate
            // 
            this.fld_dteARDeliveryPlanBeginDate.BOSComment = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSDataMember = "PMSaleWorkBeginDate";
            this.fld_dteARDeliveryPlanBeginDate.BOSDataSource = "PMSaleWorks";
            this.fld_dteARDeliveryPlanBeginDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSError = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanBeginDate.EditValue = null;
            this.fld_dteARDeliveryPlanBeginDate.Location = new System.Drawing.Point(222, 87);
            this.fld_dteARDeliveryPlanBeginDate.Name = "fld_dteARDeliveryPlanBeginDate";
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanBeginDate.Screen = null;
            this.fld_dteARDeliveryPlanBeginDate.Size = new System.Drawing.Size(168, 20);
            this.fld_dteARDeliveryPlanBeginDate.TabIndex = 5;
            this.fld_dteARDeliveryPlanBeginDate.Tag = "DC";
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
            this.fld_lkeARDeliveryPlanStatus.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSDataMember = "PMSaleWorkStatus";
            this.fld_lkeARDeliveryPlanStatus.BOSDataSource = "PMSaleWorks";
            this.fld_lkeARDeliveryPlanStatus.BOSDescription = null;
            this.fld_lkeARDeliveryPlanStatus.BOSError = null;
            this.fld_lkeARDeliveryPlanStatus.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanStatus.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanStatus.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanStatus.Location = new System.Drawing.Point(517, 61);
            this.fld_lkeARDeliveryPlanStatus.Name = "fld_lkeARDeliveryPlanStatus";
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanStatus.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
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
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(407, 64);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 129;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_lkeARDeliveryPlanType
            // 
            this.fld_lkeARDeliveryPlanType.BOSAllowAddNew = false;
            this.fld_lkeARDeliveryPlanType.BOSAllowDummy = true;
            this.fld_lkeARDeliveryPlanType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSDataMember = "PMSaleWorkType";
            this.fld_lkeARDeliveryPlanType.BOSDataSource = "PMSaleWorks";
            this.fld_lkeARDeliveryPlanType.BOSDescription = null;
            this.fld_lkeARDeliveryPlanType.BOSError = null;
            this.fld_lkeARDeliveryPlanType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanType.Location = new System.Drawing.Point(222, 61);
            this.fld_lkeARDeliveryPlanType.Name = "fld_lkeARDeliveryPlanType";
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARDeliveryPlanType.Properties.PopupWidth = 40;
            this.fld_lkeARDeliveryPlanType.Properties.ReadOnly = true;
            this.fld_lkeARDeliveryPlanType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDeliveryPlanType.Screen = null;
            this.fld_lkeARDeliveryPlanType.Size = new System.Drawing.Size(168, 20);
            this.fld_lkeARDeliveryPlanType.TabIndex = 3;
            this.fld_lkeARDeliveryPlanType.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(128, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 80;
            this.bosLabel1.Text = "Loại kế hoạch";
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
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Location = new System.Drawing.Point(3, 161);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Name = "fld_dgcARDeliveryPlansMachineDeviceGridControl";
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Screen = null;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.SelectedTabPage = this.xtraTabPage1;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.Size = new System.Drawing.Size(996, 327);
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.TabIndex = 8;
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcPMSaleWorksItemsGridControl);
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(989, 298);
            this.xtraTabPage1.Text = "Danh sách công việc";
            // 
            // fld_dgcPMSaleWorksItemsGridControl
            // 
            this.fld_dgcPMSaleWorksItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMSaleWorksItemsGridControl.BOSComment = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSDataMember = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSDataSource = "PMSaleWorkItems";
            this.fld_dgcPMSaleWorksItemsGridControl.BOSDescription = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSError = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSGridType = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSPrivilege = null;
            this.fld_dgcPMSaleWorksItemsGridControl.BOSPropertyName = null;
            this.fld_dgcPMSaleWorksItemsGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcPMSaleWorksItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMSaleWorksItemsGridControl.Name = "fld_dgcPMSaleWorksItemsGridControl";
            this.fld_dgcPMSaleWorksItemsGridControl.PrintReport = false;
            this.fld_dgcPMSaleWorksItemsGridControl.Screen = null;
            this.fld_dgcPMSaleWorksItemsGridControl.Size = new System.Drawing.Size(981, 258);
            this.fld_dgcPMSaleWorksItemsGridControl.TabIndex = 31;
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProduct.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProduct.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(119, 27);
            this.fld_btnAddProduct.TabIndex = 0;
            this.fld_btnAddProduct.Tag = "AddProduct";
            this.fld_btnAddProduct.Text = "Thêm công việc";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // fld_medARDeliveryPlanDesc
            // 
            this.fld_medARDeliveryPlanDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medARDeliveryPlanDesc.BOSDataMember = "PMSaleWorkDesc";
            this.fld_medARDeliveryPlanDesc.BOSDataSource = "PMSaleWorks";
            this.fld_medARDeliveryPlanDesc.BOSDescription = null;
            this.fld_medARDeliveryPlanDesc.BOSError = null;
            this.fld_medARDeliveryPlanDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medARDeliveryPlanDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medARDeliveryPlanDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medARDeliveryPlanDesc.BOSPropertyName = "EditValue";
            this.fld_medARDeliveryPlanDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medARDeliveryPlanDesc.Location = new System.Drawing.Point(222, 113);
            this.fld_medARDeliveryPlanDesc.Name = "fld_medARDeliveryPlanDesc";
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARDeliveryPlanDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARDeliveryPlanDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARDeliveryPlanDesc, true);
            this.fld_medARDeliveryPlanDesc.Size = new System.Drawing.Size(445, 42);
            this.fld_medARDeliveryPlanDesc.TabIndex = 7;
            this.fld_medARDeliveryPlanDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(128, 119);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // bosButton2
            // 
            this.bosButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton2.Appearance.Options.UseForeColor = true;
            this.bosButton2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(5, 3);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(119, 27);
            this.bosButton2.TabIndex = 30;
            this.bosButton2.Tag = "AddProduct";
            this.bosButton2.Text = "Thêm sản phẩm";
            // 
            // bosButton3
            // 
            this.bosButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton3.Appearance.Options.UseForeColor = true;
            this.bosButton3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton3.BOSDataMember = null;
            this.bosButton3.BOSDataSource = null;
            this.bosButton3.BOSDescription = null;
            this.bosButton3.BOSError = null;
            this.bosButton3.BOSFieldGroup = null;
            this.bosButton3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosButton3.BOSPrivilege = null;
            this.bosButton3.BOSPropertyName = null;
            this.bosButton3.Location = new System.Drawing.Point(5, 3);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(119, 27);
            this.bosButton3.TabIndex = 30;
            this.bosButton3.Tag = "AddProduct";
            this.bosButton3.Text = "Thêm sản phẩm";
            // 
            // DMSW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1002, 491);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSW100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlansMachineDeviceGridControl)).EndInit();
            this.fld_dgcARDeliveryPlansMachineDeviceGridControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMSaleWorksItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDeliveryPlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanEndDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanBeginDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTabControl fld_dgcARDeliveryPlansMachineDeviceGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARSaleWorkItemsGridControl fld_dgcPMSaleWorksItemsGridControl;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton3;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanType;
    }
}
