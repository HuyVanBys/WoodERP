using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Estimate.UI
{
    /// <summary>
    /// Summary description for DMEM100
    /// </summary>
    partial class DMEM100
    {
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSDateEdit fld_dteAREstimateDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtAREstimateDiscountPercent;
        private BOSComponent.BOSTextBox fld_txtAREstimateDiscountFix;
        private BOSComponent.BOSTextBox fld_txtAREstimateSubTotalAmount;
        private BOSComponent.BOSTextBox fld_txtAREstimateTotalAmount;


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
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAREstimateDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAREstimateDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAREstimateSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAREstimateTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAREstimateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAREstimateName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAREstimateTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAREstimateTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlAREstimateItems = new BOSERP.Modules.Estimate.EstimateItemsTreeListControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAREstimateItemMaterials = new BOSERP.Modules.Estimate.EstimateItemMaterialsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAREstimateItemCosts = new BOSERP.Modules.Estimate.EstimateItemCostsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_medAREstimateDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTaxAmount.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlAREstimateItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAREstimateItemMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAREstimateItemCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAREstimateDesc.Properties)).BeginInit();
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
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "AREstimates";
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
            this.fld_lblLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(116, 38);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel10.TabIndex = 7;
            this.fld_lblLabel10.Text = "Dự toán";
            // 
            // fld_dteAREstimateDate
            // 
            this.fld_dteAREstimateDate.BOSComment = null;
            this.fld_dteAREstimateDate.BOSDataMember = "AREstimateDate";
            this.fld_dteAREstimateDate.BOSDataSource = "AREstimates";
            this.fld_dteAREstimateDate.BOSDescription = null;
            this.fld_dteAREstimateDate.BOSError = null;
            this.fld_dteAREstimateDate.BOSFieldGroup = null;
            this.fld_dteAREstimateDate.BOSFieldRelation = null;
            this.fld_dteAREstimateDate.BOSPrivilege = null;
            this.fld_dteAREstimateDate.BOSPropertyName = "EditValue";
            this.fld_dteAREstimateDate.EditValue = null;
            this.fld_dteAREstimateDate.Location = new System.Drawing.Point(505, 9);
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
            this.fld_dteAREstimateDate.TabIndex = 7;
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(395, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel26.TabIndex = 18;
            this.fld_lblLabel26.Text = "Ngày dự toán";
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = null;
            this.fld_lblLabel44.BOSDataMember = null;
            this.fld_lblLabel44.BOSDataSource = null;
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = null;
            this.fld_lblLabel44.BOSFieldRelation = null;
            this.fld_lblLabel44.BOSPrivilege = null;
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(256, 524);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 46;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(439, 524);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel46.TabIndex = 48;
            this.fld_lblLabel46.Text = "% Chiết khấu";
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = null;
            this.fld_lblLabel47.BOSDataMember = null;
            this.fld_lblLabel47.BOSDataSource = null;
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = null;
            this.fld_lblLabel47.BOSFieldRelation = null;
            this.fld_lblLabel47.BOSPrivilege = null;
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(809, 524);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 49;
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtAREstimateDiscountPercent
            // 
            this.fld_txtAREstimateDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateDiscountPercent.BOSComment = null;
            this.fld_txtAREstimateDiscountPercent.BOSDataMember = "AREstimateDiscountPercent";
            this.fld_txtAREstimateDiscountPercent.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateDiscountPercent.BOSDescription = null;
            this.fld_txtAREstimateDiscountPercent.BOSError = null;
            this.fld_txtAREstimateDiscountPercent.BOSFieldGroup = null;
            this.fld_txtAREstimateDiscountPercent.BOSFieldRelation = null;
            this.fld_txtAREstimateDiscountPercent.BOSPrivilege = null;
            this.fld_txtAREstimateDiscountPercent.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateDiscountPercent.EditValue = "0.00";
            this.fld_txtAREstimateDiscountPercent.Location = new System.Drawing.Point(439, 543);
            this.fld_txtAREstimateDiscountPercent.Name = "fld_txtAREstimateDiscountPercent";
            this.fld_txtAREstimateDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAREstimateDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateDiscountPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateDiscountPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateDiscountPercent.Screen = null;
            this.fld_txtAREstimateDiscountPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtAREstimateDiscountPercent.TabIndex = 31;
            this.fld_txtAREstimateDiscountPercent.Tag = "DC";
            this.fld_txtAREstimateDiscountPercent.Validated += new System.EventHandler(this.fld_txtAREstimateDiscountPercent_Validated);
            // 
            // fld_txtAREstimateDiscountFix
            // 
            this.fld_txtAREstimateDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateDiscountFix.BOSComment = null;
            this.fld_txtAREstimateDiscountFix.BOSDataMember = "AREstimateDiscountFix";
            this.fld_txtAREstimateDiscountFix.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateDiscountFix.BOSDescription = null;
            this.fld_txtAREstimateDiscountFix.BOSError = null;
            this.fld_txtAREstimateDiscountFix.BOSFieldGroup = null;
            this.fld_txtAREstimateDiscountFix.BOSFieldRelation = null;
            this.fld_txtAREstimateDiscountFix.BOSPrivilege = null;
            this.fld_txtAREstimateDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateDiscountFix.EditValue = "0.00";
            this.fld_txtAREstimateDiscountFix.Location = new System.Drawing.Point(517, 543);
            this.fld_txtAREstimateDiscountFix.Name = "fld_txtAREstimateDiscountFix";
            this.fld_txtAREstimateDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAREstimateDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateDiscountFix.Screen = null;
            this.fld_txtAREstimateDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtAREstimateDiscountFix.TabIndex = 32;
            this.fld_txtAREstimateDiscountFix.Tag = "DC";
            this.fld_txtAREstimateDiscountFix.Validated += new System.EventHandler(this.fld_txtAREstimateDiscountFix_Validated);
            // 
            // fld_txtAREstimateSubTotalAmount
            // 
            this.fld_txtAREstimateSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateSubTotalAmount.BOSComment = null;
            this.fld_txtAREstimateSubTotalAmount.BOSDataMember = "AREstimateSubTotalAmount";
            this.fld_txtAREstimateSubTotalAmount.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateSubTotalAmount.BOSDescription = null;
            this.fld_txtAREstimateSubTotalAmount.BOSError = null;
            this.fld_txtAREstimateSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtAREstimateSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtAREstimateSubTotalAmount.BOSPrivilege = null;
            this.fld_txtAREstimateSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateSubTotalAmount.EditValue = "0.00";
            this.fld_txtAREstimateSubTotalAmount.Location = new System.Drawing.Point(256, 543);
            this.fld_txtAREstimateSubTotalAmount.Name = "fld_txtAREstimateSubTotalAmount";
            this.fld_txtAREstimateSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAREstimateSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtAREstimateSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateSubTotalAmount.Screen = null;
            this.fld_txtAREstimateSubTotalAmount.Size = new System.Drawing.Size(177, 20);
            this.fld_txtAREstimateSubTotalAmount.TabIndex = 30;
            this.fld_txtAREstimateSubTotalAmount.Tag = "DC";
            // 
            // fld_txtAREstimateTotalAmount
            // 
            this.fld_txtAREstimateTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateTotalAmount.BOSComment = null;
            this.fld_txtAREstimateTotalAmount.BOSDataMember = "AREstimateTotalAmount";
            this.fld_txtAREstimateTotalAmount.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateTotalAmount.BOSDescription = null;
            this.fld_txtAREstimateTotalAmount.BOSError = null;
            this.fld_txtAREstimateTotalAmount.BOSFieldGroup = null;
            this.fld_txtAREstimateTotalAmount.BOSFieldRelation = null;
            this.fld_txtAREstimateTotalAmount.BOSPrivilege = null;
            this.fld_txtAREstimateTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateTotalAmount.EditValue = "0.00";
            this.fld_txtAREstimateTotalAmount.Location = new System.Drawing.Point(809, 543);
            this.fld_txtAREstimateTotalAmount.Name = "fld_txtAREstimateTotalAmount";
            this.fld_txtAREstimateTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtAREstimateTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateTotalAmount.Properties.ReadOnly = true;
            this.fld_txtAREstimateTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateTotalAmount.Screen = null;
            this.fld_txtAREstimateTotalAmount.Size = new System.Drawing.Size(178, 20);
            this.fld_txtAREstimateTotalAmount.TabIndex = 35;
            this.fld_txtAREstimateTotalAmount.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(116, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(55, 13);
            this.bosLabel7.TabIndex = 68;
            this.bosLabel7.Text = "Mã dự toán";
            // 
            // fld_txtAREstimateNo
            // 
            this.fld_txtAREstimateNo.BOSComment = null;
            this.fld_txtAREstimateNo.BOSDataMember = "AREstimateNo";
            this.fld_txtAREstimateNo.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateNo.BOSDescription = null;
            this.fld_txtAREstimateNo.BOSError = null;
            this.fld_txtAREstimateNo.BOSFieldGroup = null;
            this.fld_txtAREstimateNo.BOSFieldRelation = null;
            this.fld_txtAREstimateNo.BOSPrivilege = null;
            this.fld_txtAREstimateNo.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateNo.Location = new System.Drawing.Point(210, 9);
            this.fld_txtAREstimateNo.MenuManager = this.screenToolbar;
            this.fld_txtAREstimateNo.Name = "fld_txtAREstimateNo";
            this.fld_txtAREstimateNo.Screen = null;
            this.fld_txtAREstimateNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAREstimateNo.TabIndex = 0;
            this.fld_txtAREstimateNo.Tag = "DC";
            // 
            // fld_txtAREstimateName
            // 
            this.fld_txtAREstimateName.BOSComment = null;
            this.fld_txtAREstimateName.BOSDataMember = "AREstimateName";
            this.fld_txtAREstimateName.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateName.BOSDescription = null;
            this.fld_txtAREstimateName.BOSError = null;
            this.fld_txtAREstimateName.BOSFieldGroup = null;
            this.fld_txtAREstimateName.BOSFieldRelation = null;
            this.fld_txtAREstimateName.BOSPrivilege = null;
            this.fld_txtAREstimateName.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateName.Location = new System.Drawing.Point(210, 35);
            this.fld_txtAREstimateName.Name = "fld_txtAREstimateName";
            this.fld_txtAREstimateName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAREstimateName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateName.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateName.Screen = null;
            this.fld_txtAREstimateName.Size = new System.Drawing.Size(445, 20);
            this.fld_txtAREstimateName.TabIndex = 8;
            this.fld_txtAREstimateName.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel9.Location = new System.Drawing.Point(623, 524);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(38, 13);
            this.bosLabel9.TabIndex = 48;
            this.bosLabel9.Text = "% Thuế";
            // 
            // fld_txtAREstimateTaxPercent
            // 
            this.fld_txtAREstimateTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateTaxPercent.BOSComment = null;
            this.fld_txtAREstimateTaxPercent.BOSDataMember = "AREstimateTaxPercent";
            this.fld_txtAREstimateTaxPercent.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateTaxPercent.BOSDescription = null;
            this.fld_txtAREstimateTaxPercent.BOSError = null;
            this.fld_txtAREstimateTaxPercent.BOSFieldGroup = null;
            this.fld_txtAREstimateTaxPercent.BOSFieldRelation = null;
            this.fld_txtAREstimateTaxPercent.BOSPrivilege = null;
            this.fld_txtAREstimateTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateTaxPercent.EditValue = "0.00";
            this.fld_txtAREstimateTaxPercent.Location = new System.Drawing.Point(623, 543);
            this.fld_txtAREstimateTaxPercent.Name = "fld_txtAREstimateTaxPercent";
            this.fld_txtAREstimateTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAREstimateTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateTaxPercent.Screen = null;
            this.fld_txtAREstimateTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtAREstimateTaxPercent.TabIndex = 33;
            this.fld_txtAREstimateTaxPercent.Tag = "DC";
            this.fld_txtAREstimateTaxPercent.Validated += new System.EventHandler(this.fld_txtAREstimateTaxPercent_Validated);
            // 
            // fld_txtAREstimateTaxAmount
            // 
            this.fld_txtAREstimateTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAREstimateTaxAmount.BOSComment = null;
            this.fld_txtAREstimateTaxAmount.BOSDataMember = "AREstimateTaxAmount";
            this.fld_txtAREstimateTaxAmount.BOSDataSource = "AREstimates";
            this.fld_txtAREstimateTaxAmount.BOSDescription = null;
            this.fld_txtAREstimateTaxAmount.BOSError = null;
            this.fld_txtAREstimateTaxAmount.BOSFieldGroup = null;
            this.fld_txtAREstimateTaxAmount.BOSFieldRelation = null;
            this.fld_txtAREstimateTaxAmount.BOSPrivilege = null;
            this.fld_txtAREstimateTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtAREstimateTaxAmount.EditValue = "0.00";
            this.fld_txtAREstimateTaxAmount.Location = new System.Drawing.Point(701, 543);
            this.fld_txtAREstimateTaxAmount.Name = "fld_txtAREstimateTaxAmount";
            this.fld_txtAREstimateTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAREstimateTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAREstimateTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAREstimateTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAREstimateTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtAREstimateTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAREstimateTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAREstimateTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAREstimateTaxAmount.Screen = null;
            this.fld_txtAREstimateTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtAREstimateTaxAmount.TabIndex = 34;
            this.fld_txtAREstimateTaxAmount.Tag = "DC";
            this.fld_txtAREstimateTaxAmount.Validated += new System.EventHandler(this.fld_txtAREstimateTaxAmount_Validated);
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
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_medAREstimateDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateNo);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateName);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateDiscountPercent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtAREstimateDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_dteAREstimateDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1002, 572);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel4
            // 
            this.bosLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel4.Location = new System.Drawing.Point(701, 524);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(24, 13);
            this.bosLabel4.TabIndex = 82;
            this.bosLabel4.Text = "Thuế";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosLabel2.Location = new System.Drawing.Point(517, 524);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 81;
            this.bosLabel2.Text = "Chiết khấu";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(116, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(29, 13);
            this.bosLabel1.TabIndex = 80;
            this.bosLabel1.Text = "Dự án";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = false;
            this.fld_lkeFK_PMProjectID.BOSComment = null;
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "AREstimates";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = null;
            this.fld_lkeFK_PMProjectID.BOSFieldParent = null;
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = null;
            this.fld_lkeFK_PMProjectID.BOSPrivilege = null;
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = null;
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(210, 61);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectName";
            this.fld_lkeFK_PMProjectID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(445, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 79;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(6, 146);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(984, 372);
            this.bosTabControl1.TabIndex = 26;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_trlAREstimateItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(977, 343);
            this.xtraTabPage1.Text = "Dự toán công việc";
            // 
            // fld_trlAREstimateItems
            // 
            this.fld_trlAREstimateItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlAREstimateItems.BOSComment = null;
            this.fld_trlAREstimateItems.BOSDataMember = null;
            this.fld_trlAREstimateItems.BOSDataSource = "AREstimateItems";
            this.fld_trlAREstimateItems.BOSDescription = null;
            this.fld_trlAREstimateItems.BOSDisplayOption = true;
            this.fld_trlAREstimateItems.BOSDisplayRoot = false;
            this.fld_trlAREstimateItems.BOSError = null;
            this.fld_trlAREstimateItems.BOSFieldGroup = null;
            this.fld_trlAREstimateItems.BOSFieldRelation = null;
            this.fld_trlAREstimateItems.BOSPrivilege = null;
            this.fld_trlAREstimateItems.BOSPropertyName = null;
            this.fld_trlAREstimateItems.Location = new System.Drawing.Point(4, 3);
            this.fld_trlAREstimateItems.Name = "fld_trlAREstimateItems";
            this.fld_trlAREstimateItems.Screen = null;
            this.fld_trlAREstimateItems.Size = new System.Drawing.Size(970, 337);
            this.fld_trlAREstimateItems.TabIndex = 10;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcAREstimateItemMaterials);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1160, 520);
            this.xtraTabPage2.Text = "Dự toán vật tư";
            // 
            // fld_dgcAREstimateItemMaterials
            // 
            this.fld_dgcAREstimateItemMaterials.AllowDrop = true;
            this.fld_dgcAREstimateItemMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAREstimateItemMaterials.BOSComment = null;
            this.fld_dgcAREstimateItemMaterials.BOSDataMember = null;
            this.fld_dgcAREstimateItemMaterials.BOSDataSource = "AREstimateItems";
            this.fld_dgcAREstimateItemMaterials.BOSDescription = null;
            this.fld_dgcAREstimateItemMaterials.BOSError = null;
            this.fld_dgcAREstimateItemMaterials.BOSFieldGroup = null;
            this.fld_dgcAREstimateItemMaterials.BOSFieldRelation = null;
            this.fld_dgcAREstimateItemMaterials.BOSGridType = null;
            this.fld_dgcAREstimateItemMaterials.BOSPrivilege = null;
            this.fld_dgcAREstimateItemMaterials.BOSPropertyName = null;
            this.fld_dgcAREstimateItemMaterials.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAREstimateItemMaterials.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcAREstimateItemMaterials.MainView = this.gridView2;
            this.fld_dgcAREstimateItemMaterials.Name = "fld_dgcAREstimateItemMaterials";
            this.fld_dgcAREstimateItemMaterials.PrintReport = false;
            this.fld_dgcAREstimateItemMaterials.Screen = null;
            this.fld_dgcAREstimateItemMaterials.Size = new System.Drawing.Size(1154, 514);
            this.fld_dgcAREstimateItemMaterials.TabIndex = 2;
            this.fld_dgcAREstimateItemMaterials.Tag = "DC";
            this.fld_dgcAREstimateItemMaterials.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcAREstimateItemMaterials;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcAREstimateItemCosts);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1160, 520);
            this.xtraTabPage3.Text = "Dự toán chi phí";
            // 
            // fld_dgcAREstimateItemCosts
            // 
            this.fld_dgcAREstimateItemCosts.AllowDrop = true;
            this.fld_dgcAREstimateItemCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAREstimateItemCosts.BOSComment = null;
            this.fld_dgcAREstimateItemCosts.BOSDataMember = null;
            this.fld_dgcAREstimateItemCosts.BOSDataSource = "AREstimateItems";
            this.fld_dgcAREstimateItemCosts.BOSDescription = null;
            this.fld_dgcAREstimateItemCosts.BOSError = null;
            this.fld_dgcAREstimateItemCosts.BOSFieldGroup = null;
            this.fld_dgcAREstimateItemCosts.BOSFieldRelation = null;
            this.fld_dgcAREstimateItemCosts.BOSGridType = null;
            this.fld_dgcAREstimateItemCosts.BOSPrivilege = null;
            this.fld_dgcAREstimateItemCosts.BOSPropertyName = null;
            this.fld_dgcAREstimateItemCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAREstimateItemCosts.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcAREstimateItemCosts.MainView = this.gridView3;
            this.fld_dgcAREstimateItemCosts.Name = "fld_dgcAREstimateItemCosts";
            this.fld_dgcAREstimateItemCosts.PrintReport = false;
            this.fld_dgcAREstimateItemCosts.Screen = null;
            this.fld_dgcAREstimateItemCosts.Size = new System.Drawing.Size(1154, 514);
            this.fld_dgcAREstimateItemCosts.TabIndex = 2;
            this.fld_dgcAREstimateItemCosts.Tag = "DC";
            this.fld_dgcAREstimateItemCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcAREstimateItemCosts;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // fld_medAREstimateDesc
            // 
            this.fld_medAREstimateDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medAREstimateDesc.BOSDataMember = "AREstimateDesc";
            this.fld_medAREstimateDesc.BOSDataSource = "AREstimates";
            this.fld_medAREstimateDesc.BOSDescription = null;
            this.fld_medAREstimateDesc.BOSError = null;
            this.fld_medAREstimateDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medAREstimateDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medAREstimateDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medAREstimateDesc.BOSPropertyName = "EditValue";
            this.fld_medAREstimateDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medAREstimateDesc.Location = new System.Drawing.Point(210, 87);
            this.fld_medAREstimateDesc.Name = "fld_medAREstimateDesc";
            this.fld_medAREstimateDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAREstimateDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAREstimateDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAREstimateDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAREstimateDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medAREstimateDesc, true);
            this.fld_medAREstimateDesc.Size = new System.Drawing.Size(445, 42);
            this.fld_medAREstimateDesc.TabIndex = 6;
            this.fld_medAREstimateDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(116, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 78;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // DMEM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1002, 572);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAREstimateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAREstimateTaxAmount.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlAREstimateItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAREstimateItemMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAREstimateItemCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAREstimateDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtAREstimateNo;
        private BOSComponent.BOSTextBox fld_txtAREstimateName;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtAREstimateTaxPercent;
        private BOSComponent.BOSTextBox fld_txtAREstimateTaxAmount;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSMemoEdit fld_medAREstimateDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private EstimateItemMaterialsGridControl fld_dgcAREstimateItemMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private EstimateItemCostsGridControl fld_dgcAREstimateItemCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSERP.Modules.Estimate.EstimateItemsTreeListControl fld_trlAREstimateItems;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
    }
}
