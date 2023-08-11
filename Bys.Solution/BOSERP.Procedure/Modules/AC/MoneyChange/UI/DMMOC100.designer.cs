using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MoneyChange.UI
{
    /// <summary>
    /// Summary description for DMMOC100
    /// </summary>
    partial class DMMOC100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACMoneyChangeItems = new BOSERP.Modules.MoneyChange.ACMoneyChangeItemsGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACMoneyChangeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteACMoneyChangeDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteACBankTransactionEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACMoneyChangeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACMoneyChangeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACMoneyChangeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACMoneyChangeDesc.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_txtACMoneyChangeNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteACMoneyChangeDate);
            this.bosPanel1.Controls.Add(this.fld_pteACBankTransactionEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_medACMoneyChangeDesc);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(766, 514);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcACMoneyChangeItems);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(5, 130);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(750, 384);
            this.fld_grcGroupControl2.TabIndex = 3;
            this.fld_grcGroupControl2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl2.Text = "Thông tin chi tiết";
            // 
            // fld_dgcACMoneyChangeItems
            // 
            this.fld_dgcACMoneyChangeItems.AllowDrop = true;
            this.fld_dgcACMoneyChangeItems.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.BOSDataSource = "ACMoneyChangeItems";
            this.fld_dgcACMoneyChangeItems.BOSDescription = null;
            this.fld_dgcACMoneyChangeItems.BOSError = null;
            this.fld_dgcACMoneyChangeItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.BOSGridType = null;
            this.fld_dgcACMoneyChangeItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcACMoneyChangeItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACMoneyChangeItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACMoneyChangeItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACMoneyChangeItems.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcACMoneyChangeItems.Name = "fld_dgcACMoneyChangeItems";
            this.fld_dgcACMoneyChangeItems.PrintReport = false;
            this.fld_dgcACMoneyChangeItems.Screen = null;
            this.fld_dgcACMoneyChangeItems.Size = new System.Drawing.Size(746, 360);
            this.fld_dgcACMoneyChangeItems.TabIndex = 0;
            this.fld_dgcACMoneyChangeItems.Tag = "DC";
            this.fld_dgcACMoneyChangeItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactionItems});
            // 
            // fld_dgvACBankTransactionItems
            // 
            this.fld_dgvACBankTransactionItems.GridControl = this.fld_dgcACMoneyChangeItems;
            this.fld_dgvACBankTransactionItems.Name = "fld_dgvACBankTransactionItems";
            this.fld_dgvACBankTransactionItems.PaintStyleName = "Office2003";
            // 
            // fld_txtACMoneyChangeNo
            // 
            this.fld_txtACMoneyChangeNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACMoneyChangeNo.BOSDataMember = "ACMoneyChangeNo";
            this.fld_txtACMoneyChangeNo.BOSDataSource = "ACMoneyChanges";
            this.fld_txtACMoneyChangeNo.BOSDescription = null;
            this.fld_txtACMoneyChangeNo.BOSError = null;
            this.fld_txtACMoneyChangeNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACMoneyChangeNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACMoneyChangeNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACMoneyChangeNo.BOSPropertyName = "Text";
            this.fld_txtACMoneyChangeNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtACMoneyChangeNo.Location = new System.Drawing.Point(202, 12);
            this.fld_txtACMoneyChangeNo.Name = "fld_txtACMoneyChangeNo";
            this.fld_txtACMoneyChangeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACMoneyChangeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACMoneyChangeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACMoneyChangeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACMoneyChangeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACMoneyChangeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACMoneyChangeNo.Screen = null;
            this.fld_txtACMoneyChangeNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACMoneyChangeNo.TabIndex = 0;
            this.fld_txtACMoneyChangeNo.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 104);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_dteACMoneyChangeDate
            // 
            this.fld_dteACMoneyChangeDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACMoneyChangeDate.BOSDataMember = "ACMoneyChangeDate";
            this.fld_dteACMoneyChangeDate.BOSDataSource = "ACMoneyChanges";
            this.fld_dteACMoneyChangeDate.BOSDescription = null;
            this.fld_dteACMoneyChangeDate.BOSError = null;
            this.fld_dteACMoneyChangeDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACMoneyChangeDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACMoneyChangeDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteACMoneyChangeDate.BOSPropertyName = "EditValue";
            this.fld_dteACMoneyChangeDate.EditValue = null;
            this.fld_dteACMoneyChangeDate.Location = new System.Drawing.Point(486, 12);
            this.fld_dteACMoneyChangeDate.Name = "fld_dteACMoneyChangeDate";
            this.fld_dteACMoneyChangeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACMoneyChangeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACMoneyChangeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACMoneyChangeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACMoneyChangeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACMoneyChangeDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACMoneyChangeDate.Screen = null;
            this.fld_dteACMoneyChangeDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACMoneyChangeDate.TabIndex = 1;
            this.fld_dteACMoneyChangeDate.Tag = "DC";
            // 
            // fld_pteACBankTransactionEmployeePicture
            // 
            this.fld_pteACBankTransactionEmployeePicture.BOSComment = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSDataMember = "ACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.BOSDataSource = "ACBankTransactions";
            this.fld_pteACBankTransactionEmployeePicture.BOSDescription = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSError = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPrivilege = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACBankTransactionEmployeePicture.FileName = null;
            this.fld_pteACBankTransactionEmployeePicture.FilePath = null;
            this.fld_pteACBankTransactionEmployeePicture.Location = new System.Drawing.Point(3, 6);
            this.fld_pteACBankTransactionEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACBankTransactionEmployeePicture.Name = "fld_pteACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACBankTransactionEmployeePicture.Screen = null;
            this.fld_pteACBankTransactionEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACBankTransactionEmployeePicture.TabIndex = 0;
            this.fld_pteACBankTransactionEmployeePicture.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.Location = new System.Drawing.Point(127, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 0;
            this.fld_lblLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.Location = new System.Drawing.Point(398, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 2;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.Location = new System.Drawing.Point(127, 41);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_medACMoneyChangeDesc
            // 
            this.fld_medACMoneyChangeDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medACMoneyChangeDesc.BOSDataMember = "ACMoneyChangeDesc";
            this.fld_medACMoneyChangeDesc.BOSDataSource = "ACMoneyChangeDesc";
            this.fld_medACMoneyChangeDesc.BOSDescription = null;
            this.fld_medACMoneyChangeDesc.BOSError = null;
            this.fld_medACMoneyChangeDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medACMoneyChangeDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medACMoneyChangeDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medACMoneyChangeDesc.BOSPropertyName = "Text";
            this.fld_medACMoneyChangeDesc.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medACMoneyChangeDesc.Location = new System.Drawing.Point(202, 38);
            this.fld_medACMoneyChangeDesc.Name = "fld_medACMoneyChangeDesc";
            this.fld_medACMoneyChangeDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACMoneyChangeDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACMoneyChangeDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACMoneyChangeDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACMoneyChangeDesc.Screen = null;
            this.fld_medACMoneyChangeDesc.Size = new System.Drawing.Size(434, 35);
            this.fld_medACMoneyChangeDesc.TabIndex = 2;
            this.fld_medACMoneyChangeDesc.Tag = "DC";
            // 
            // DMMOC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(766, 514);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMMOC100";
            this.Text = "Thông tin chung";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACMoneyChangeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACMoneyChangeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACMoneyChangeDesc.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteACBankTransactionEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSERP.Modules.MoneyChange.ACMoneyChangeItemsGridControl fld_dgcACMoneyChangeItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private BOSComponent.BOSTextBox fld_txtACMoneyChangeNo;
        private BOSComponent.BOSDateEdit fld_dteACMoneyChangeDate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSMemoEdit fld_medACMoneyChangeDesc;
    }
}
