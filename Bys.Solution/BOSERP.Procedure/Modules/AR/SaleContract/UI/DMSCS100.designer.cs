using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleContract.UI
{
	/// <summary>
    /// Summary description for DMPCS100
	/// </summary>
    partial class DMSCS100
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
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSOItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrders = new BOSERP.Modules.SaleContract.ARSaleOrderGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleContractSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleContractAnswerableAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleContractDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleContractDiscountAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleContractAnswerablePercent = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleContractGuaranteeAmount = new BOSComponent.BOSTextBox(this.components);
            this.ftd_txtARSaleContractGuaranteePercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaDiscountType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductCriteriaNane = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductCriteriaNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICProductCriteriaType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductCriteriaEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductCriteriaStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleContractParrentiD = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductCriteriaDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteMMProductionNormProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.fld_tabSOItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractAnswerableAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractAnswerablePercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractGuaranteeAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftd_txtARSaleContractGuaranteePercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaDiscountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCriteriaStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleContractParrentiD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl5);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1120, 610);
            this.bosPanel1.TabIndex = 335;
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.bosTabControl1);
            this.fld_grcGroupControl5.Controls.Add(this.bosGroupControl1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_grcGroupControl1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_pteMMProductionNormProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(1120, 610);
            this.fld_grcGroupControl5.TabIndex = 1;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = "";
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 296);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.fld_tabSOItems;
            this.bosTabControl1.Size = new System.Drawing.Size(1117, 309);
            this.bosTabControl1.TabIndex = 592;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSOItems});
            // 
            // fld_tabSOItems
            // 
            this.fld_tabSOItems.Controls.Add(this.fld_dgcARSaleOrders);
            this.fld_tabSOItems.Name = "fld_tabSOItems";
            this.fld_tabSOItems.Size = new System.Drawing.Size(1111, 281);
            this.fld_tabSOItems.Text = "Danh sách đơn bán hàng";
            // 
            // fld_dgcARSaleOrders
            // 
            this.fld_dgcARSaleOrders.AllowDrop = true;
            this.fld_dgcARSaleOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrders.BOSComment = "";
            this.fld_dgcARSaleOrders.BOSDataMember = null;
            this.fld_dgcARSaleOrders.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrders.BOSDescription = null;
            this.fld_dgcARSaleOrders.BOSError = "";
            this.fld_dgcARSaleOrders.BOSFieldGroup = "";
            this.fld_dgcARSaleOrders.BOSFieldRelation = null;
            this.fld_dgcARSaleOrders.BOSGridType = null;
            this.fld_dgcARSaleOrders.BOSPrivilege = "";
            this.fld_dgcARSaleOrders.BOSPropertyName = null;
            this.fld_dgcARSaleOrders.CommodityType = "";
            this.fld_dgcARSaleOrders.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrders.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcARSaleOrders.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcARSaleOrders.Name = "fld_dgcARSaleOrders";
            this.fld_dgcARSaleOrders.PrintReport = false;
            this.fld_dgcARSaleOrders.Screen = null;
            this.fld_dgcARSaleOrders.Size = new System.Drawing.Size(1102, 275);
            this.fld_dgcARSaleOrders.TabIndex = 21;
            this.fld_dgcARSaleOrders.Tag = "DC";
            this.fld_dgcARSaleOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcARSaleOrders;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractSubTotalAmount);
            this.bosGroupControl1.Controls.Add(this.bosTextBox8);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractAnswerableAmount);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractDiscountPercent);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractDiscountAmount);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractAnswerablePercent);
            this.bosGroupControl1.Controls.Add(this.bosTextBox3);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_txtARSaleContractGuaranteeAmount);
            this.bosGroupControl1.Controls.Add(this.ftd_txtARSaleContractGuaranteePercent);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Location = new System.Drawing.Point(753, 25);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(331, 265);
            this.bosGroupControl1.TabIndex = 591;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Giá trị";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "FK_GECurrencyID";
            this.bosLookupEdit2.BOSDataSource = "ARSaleContracts";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = "";
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(146, 25);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.bosLookupEdit2.Properties.DisplayMember = "GECurrencyName";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "GECurrencyID";
            this.bosLookupEdit2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit2, true);
            this.bosLookupEdit2.Size = new System.Drawing.Size(166, 20);
            this.bosLookupEdit2.TabIndex = 0;
            this.bosLookupEdit2.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(9, 28);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(52, 13);
            this.bosLabel11.TabIndex = 564;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Loại tiền tệ";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(287, 238);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(25, 13);
            this.bosLabel20.TabIndex = 581;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Ngày";
            // 
            // fld_txtARSaleContractSubTotalAmount
            // 
            this.fld_txtARSaleContractSubTotalAmount.BOSComment = "";
            this.fld_txtARSaleContractSubTotalAmount.BOSDataMember = "ARSaleContractSubTotalAmount";
            this.fld_txtARSaleContractSubTotalAmount.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractSubTotalAmount.BOSDescription = null;
            this.fld_txtARSaleContractSubTotalAmount.BOSError = null;
            this.fld_txtARSaleContractSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARSaleContractSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARSaleContractSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARSaleContractSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleContractSubTotalAmount.Location = new System.Drawing.Point(146, 51);
            this.fld_txtARSaleContractSubTotalAmount.Name = "fld_txtARSaleContractSubTotalAmount";
            this.fld_txtARSaleContractSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractSubTotalAmount.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractSubTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractSubTotalAmount.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractSubTotalAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractSubTotalAmount, false);
            this.fld_txtARSaleContractSubTotalAmount.Size = new System.Drawing.Size(166, 20);
            this.fld_txtARSaleContractSubTotalAmount.TabIndex = 1;
            this.fld_txtARSaleContractSubTotalAmount.Tag = "DC";
            this.fld_txtARSaleContractSubTotalAmount.Validated += new System.EventHandler(this.fld_txtARSaleContractSubTotalAmount_Validated);
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = "";
            this.bosTextBox8.BOSDataMember = "ARSaleContractAnswerablePeriod";
            this.bosTextBox8.BOSDataSource = "ARSaleContracts";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = "";
            this.bosTextBox8.BOSFieldRelation = "";
            this.bosTextBox8.BOSPrivilege = "";
            this.bosTextBox8.BOSPropertyName = "Text";
            this.bosTextBox8.Location = new System.Drawing.Point(146, 235);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox8.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox8.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox8.Properties.DisplayFormat.FormatString = "n3";
            this.bosTextBox8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox8.Properties.Mask.EditMask = null;
            this.bosTextBox8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox8, false);
            this.bosTextBox8.Size = new System.Drawing.Size(135, 20);
            this.bosTextBox8.TabIndex = 9;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(11, 238);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(85, 13);
            this.bosLabel19.TabIndex = 579;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Thời hạn bảo lãnh";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(9, 54);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(76, 13);
            this.bosLabel7.TabIndex = 154;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Giá trị hợp đồng";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(9, 80);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(24, 13);
            this.bosLabel12.TabIndex = 565;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Thuế";
            // 
            // fld_txtARSaleContractAnswerableAmount
            // 
            this.fld_txtARSaleContractAnswerableAmount.BOSComment = "";
            this.fld_txtARSaleContractAnswerableAmount.BOSDataMember = "ARSaleContractAnswerableAmount";
            this.fld_txtARSaleContractAnswerableAmount.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractAnswerableAmount.BOSDescription = null;
            this.fld_txtARSaleContractAnswerableAmount.BOSError = null;
            this.fld_txtARSaleContractAnswerableAmount.BOSFieldGroup = "";
            this.fld_txtARSaleContractAnswerableAmount.BOSFieldRelation = "";
            this.fld_txtARSaleContractAnswerableAmount.BOSPrivilege = "";
            this.fld_txtARSaleContractAnswerableAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleContractAnswerableAmount.Location = new System.Drawing.Point(146, 209);
            this.fld_txtARSaleContractAnswerableAmount.Name = "fld_txtARSaleContractAnswerableAmount";
            this.fld_txtARSaleContractAnswerableAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractAnswerableAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractAnswerableAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractAnswerableAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractAnswerableAmount.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractAnswerableAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractAnswerableAmount.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractAnswerableAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractAnswerableAmount, false);
            this.fld_txtARSaleContractAnswerableAmount.Size = new System.Drawing.Size(166, 20);
            this.fld_txtARSaleContractAnswerableAmount.TabIndex = 8;
            this.fld_txtARSaleContractAnswerableAmount.Tag = "DC";
            this.fld_txtARSaleContractAnswerableAmount.Validated += new System.EventHandler(this.fld_txtARSaleContractAnswerableAmount_Validated);
            // 
            // fld_txtARSaleContractDiscountPercent
            // 
            this.fld_txtARSaleContractDiscountPercent.BOSComment = "";
            this.fld_txtARSaleContractDiscountPercent.BOSDataMember = "ARSaleContractDiscountPercent";
            this.fld_txtARSaleContractDiscountPercent.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractDiscountPercent.BOSDescription = null;
            this.fld_txtARSaleContractDiscountPercent.BOSError = null;
            this.fld_txtARSaleContractDiscountPercent.BOSFieldGroup = "";
            this.fld_txtARSaleContractDiscountPercent.BOSFieldRelation = "";
            this.fld_txtARSaleContractDiscountPercent.BOSPrivilege = "";
            this.fld_txtARSaleContractDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtARSaleContractDiscountPercent.Location = new System.Drawing.Point(146, 77);
            this.fld_txtARSaleContractDiscountPercent.Name = "fld_txtARSaleContractDiscountPercent";
            this.fld_txtARSaleContractDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractDiscountPercent.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractDiscountPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractDiscountPercent.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractDiscountPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractDiscountPercent, false);
            this.fld_txtARSaleContractDiscountPercent.Size = new System.Drawing.Size(47, 20);
            this.fld_txtARSaleContractDiscountPercent.TabIndex = 2;
            this.fld_txtARSaleContractDiscountPercent.Tag = "DC";
            this.fld_txtARSaleContractDiscountPercent.Validated += new System.EventHandler(this.fld_txtARSaleContractDiscountPercent_Validated);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(9, 212);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(120, 13);
            this.bosLabel18.TabIndex = 577;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Giá trị bảo lãnh hợp đồng";
            // 
            // fld_txtARSaleContractDiscountAmount
            // 
            this.fld_txtARSaleContractDiscountAmount.BOSComment = "";
            this.fld_txtARSaleContractDiscountAmount.BOSDataMember = "ARSaleContractDiscountAmount";
            this.fld_txtARSaleContractDiscountAmount.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractDiscountAmount.BOSDescription = null;
            this.fld_txtARSaleContractDiscountAmount.BOSError = null;
            this.fld_txtARSaleContractDiscountAmount.BOSFieldGroup = "";
            this.fld_txtARSaleContractDiscountAmount.BOSFieldRelation = "";
            this.fld_txtARSaleContractDiscountAmount.BOSPrivilege = "";
            this.fld_txtARSaleContractDiscountAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleContractDiscountAmount.Location = new System.Drawing.Point(199, 77);
            this.fld_txtARSaleContractDiscountAmount.Name = "fld_txtARSaleContractDiscountAmount";
            this.fld_txtARSaleContractDiscountAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractDiscountAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractDiscountAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractDiscountAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractDiscountAmount.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractDiscountAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractDiscountAmount.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractDiscountAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractDiscountAmount, false);
            this.fld_txtARSaleContractDiscountAmount.Size = new System.Drawing.Size(113, 20);
            this.fld_txtARSaleContractDiscountAmount.TabIndex = 3;
            this.fld_txtARSaleContractDiscountAmount.Tag = "DC";
            this.fld_txtARSaleContractDiscountAmount.Validated += new System.EventHandler(this.fld_txtARSaleContractDiscountAmount_Validated);
            // 
            // fld_txtARSaleContractAnswerablePercent
            // 
            this.fld_txtARSaleContractAnswerablePercent.BOSComment = "";
            this.fld_txtARSaleContractAnswerablePercent.BOSDataMember = "ARSaleContractAnswerablePercent";
            this.fld_txtARSaleContractAnswerablePercent.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractAnswerablePercent.BOSDescription = null;
            this.fld_txtARSaleContractAnswerablePercent.BOSError = null;
            this.fld_txtARSaleContractAnswerablePercent.BOSFieldGroup = "";
            this.fld_txtARSaleContractAnswerablePercent.BOSFieldRelation = "";
            this.fld_txtARSaleContractAnswerablePercent.BOSPrivilege = "";
            this.fld_txtARSaleContractAnswerablePercent.BOSPropertyName = "Text";
            this.fld_txtARSaleContractAnswerablePercent.Location = new System.Drawing.Point(146, 183);
            this.fld_txtARSaleContractAnswerablePercent.Name = "fld_txtARSaleContractAnswerablePercent";
            this.fld_txtARSaleContractAnswerablePercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractAnswerablePercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractAnswerablePercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractAnswerablePercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractAnswerablePercent.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractAnswerablePercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractAnswerablePercent.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractAnswerablePercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractAnswerablePercent, false);
            this.fld_txtARSaleContractAnswerablePercent.Size = new System.Drawing.Size(166, 20);
            this.fld_txtARSaleContractAnswerablePercent.TabIndex = 7;
            this.fld_txtARSaleContractAnswerablePercent.Tag = "DC";
            this.fld_txtARSaleContractAnswerablePercent.Validated += new System.EventHandler(this.fld_txtARSaleContractAnswerablePercent_Validated);
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "ARSaleContractTotalAmount";
            this.bosTextBox3.BOSDataSource = "ARSaleContracts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(146, 103);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.DisplayFormat.FormatString = "n3";
            this.bosTextBox3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bosTextBox3.Properties.Mask.EditMask = null;
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, false);
            this.bosTextBox3.Size = new System.Drawing.Size(166, 20);
            this.bosTextBox3.TabIndex = 4;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(9, 186);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 575;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Tỷ lệ bảo lãnh";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(9, 106);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(119, 13);
            this.bosLabel14.TabIndex = 569;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tổng giá trị hợp đồng";
            // 
            // fld_txtARSaleContractGuaranteeAmount
            // 
            this.fld_txtARSaleContractGuaranteeAmount.BOSComment = "";
            this.fld_txtARSaleContractGuaranteeAmount.BOSDataMember = "ARSaleContractGuaranteeAmount";
            this.fld_txtARSaleContractGuaranteeAmount.BOSDataSource = "ARSaleContracts";
            this.fld_txtARSaleContractGuaranteeAmount.BOSDescription = null;
            this.fld_txtARSaleContractGuaranteeAmount.BOSError = null;
            this.fld_txtARSaleContractGuaranteeAmount.BOSFieldGroup = "";
            this.fld_txtARSaleContractGuaranteeAmount.BOSFieldRelation = "";
            this.fld_txtARSaleContractGuaranteeAmount.BOSPrivilege = "";
            this.fld_txtARSaleContractGuaranteeAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleContractGuaranteeAmount.Location = new System.Drawing.Point(146, 157);
            this.fld_txtARSaleContractGuaranteeAmount.Name = "fld_txtARSaleContractGuaranteeAmount";
            this.fld_txtARSaleContractGuaranteeAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleContractGuaranteeAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleContractGuaranteeAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleContractGuaranteeAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleContractGuaranteeAmount.Properties.DisplayFormat.FormatString = "n3";
            this.fld_txtARSaleContractGuaranteeAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtARSaleContractGuaranteeAmount.Properties.Mask.EditMask = null;
            this.fld_txtARSaleContractGuaranteeAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARSaleContractGuaranteeAmount, false);
            this.fld_txtARSaleContractGuaranteeAmount.Size = new System.Drawing.Size(166, 20);
            this.fld_txtARSaleContractGuaranteeAmount.TabIndex = 6;
            this.fld_txtARSaleContractGuaranteeAmount.Tag = "DC";
            this.fld_txtARSaleContractGuaranteeAmount.Validated += new System.EventHandler(this.fld_txtARSaleContractGuaranteeAmount_Validated);
            // 
            // ftd_txtARSaleContractGuaranteePercent
            // 
            this.ftd_txtARSaleContractGuaranteePercent.BOSComment = "";
            this.ftd_txtARSaleContractGuaranteePercent.BOSDataMember = "ARSaleContractGuaranteePercent";
            this.ftd_txtARSaleContractGuaranteePercent.BOSDataSource = "ARSaleContracts";
            this.ftd_txtARSaleContractGuaranteePercent.BOSDescription = null;
            this.ftd_txtARSaleContractGuaranteePercent.BOSError = null;
            this.ftd_txtARSaleContractGuaranteePercent.BOSFieldGroup = "";
            this.ftd_txtARSaleContractGuaranteePercent.BOSFieldRelation = "";
            this.ftd_txtARSaleContractGuaranteePercent.BOSPrivilege = "";
            this.ftd_txtARSaleContractGuaranteePercent.BOSPropertyName = "Text";
            this.ftd_txtARSaleContractGuaranteePercent.Location = new System.Drawing.Point(146, 131);
            this.ftd_txtARSaleContractGuaranteePercent.Name = "ftd_txtARSaleContractGuaranteePercent";
            this.ftd_txtARSaleContractGuaranteePercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ftd_txtARSaleContractGuaranteePercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ftd_txtARSaleContractGuaranteePercent.Properties.Appearance.Options.UseBackColor = true;
            this.ftd_txtARSaleContractGuaranteePercent.Properties.Appearance.Options.UseForeColor = true;
            this.ftd_txtARSaleContractGuaranteePercent.Properties.DisplayFormat.FormatString = "n3";
            this.ftd_txtARSaleContractGuaranteePercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ftd_txtARSaleContractGuaranteePercent.Properties.Mask.EditMask = null;
            this.ftd_txtARSaleContractGuaranteePercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.ftd_txtARSaleContractGuaranteePercent, false);
            this.ftd_txtARSaleContractGuaranteePercent.Size = new System.Drawing.Size(166, 20);
            this.ftd_txtARSaleContractGuaranteePercent.TabIndex = 5;
            this.ftd_txtARSaleContractGuaranteePercent.Tag = "DC";
            this.ftd_txtARSaleContractGuaranteePercent.Validated += new System.EventHandler(this.ftd_txtARSaleContractGuaranteePercent_Validated);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(9, 160);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(107, 13);
            this.bosLabel16.TabIndex = 573;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Giá trị giữ lại bảo hành";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(9, 134);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(71, 13);
            this.bosLabel15.TabIndex = 571;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Tỷ lệ bảo hành";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel24);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteICProductCriteriaDiscountType);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel23);
            this.fld_grcGroupControl1.Controls.Add(this.bosLookupEdit4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductCriteriaNane);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductCriteriaNo);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteICProductCriteriaType);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteICProductCriteriaStartDate);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dteICProductCriteriaEndDate);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.bosDateEdit1);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeICProductCriteriaStatus);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeARSaleContractParrentiD);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductCriteriaDiscountPercent);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(136, 25);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(611, 265);
            this.fld_grcGroupControl1.TabIndex = 590;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Thông tin hợp đồng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(14, 80);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(69, 13);
            this.bosLabel4.TabIndex = 152;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại hợp đồng";
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = "";
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARSaleContractNotedContent";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARSaleContracts";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = "";
            this.fld_medARSaleOrderDesc.BOSFieldRelation = "";
            this.fld_medARSaleOrderDesc.BOSPrivilege = "";
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.EditValue = "";
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(119, 209);
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARSaleOrderDesc, true);
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(473, 46);
            this.fld_medARSaleOrderDesc.TabIndex = 7;
            this.fld_medARSaleOrderDesc.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(14, 215);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(89, 13);
            this.bosLabel24.TabIndex = 589;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Nội dung cần lưu ý";
            // 
            // fld_dteICProductCriteriaDiscountType
            // 
            this.fld_dteICProductCriteriaDiscountType.BOSAllowAddNew = false;
            this.fld_dteICProductCriteriaDiscountType.BOSAllowDummy = false;
            this.fld_dteICProductCriteriaDiscountType.BOSComment = "";
            this.fld_dteICProductCriteriaDiscountType.BOSDataMember = "ARSaleContractType";
            this.fld_dteICProductCriteriaDiscountType.BOSDataSource = "ARSaleContracts";
            this.fld_dteICProductCriteriaDiscountType.BOSDescription = null;
            this.fld_dteICProductCriteriaDiscountType.BOSError = "";
            this.fld_dteICProductCriteriaDiscountType.BOSFieldGroup = "";
            this.fld_dteICProductCriteriaDiscountType.BOSFieldParent = "";
            this.fld_dteICProductCriteriaDiscountType.BOSFieldRelation = "";
            this.fld_dteICProductCriteriaDiscountType.BOSPrivilege = "";
            this.fld_dteICProductCriteriaDiscountType.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaDiscountType.BOSSelectType = "";
            this.fld_dteICProductCriteriaDiscountType.BOSSelectTypeValue = "";
            this.fld_dteICProductCriteriaDiscountType.CurrentDisplayText = null;
            this.fld_dteICProductCriteriaDiscountType.Location = new System.Drawing.Point(119, 77);
            this.fld_dteICProductCriteriaDiscountType.Name = "fld_dteICProductCriteriaDiscountType";
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaDiscountType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaDiscountType.Properties.ColumnName = null;
            this.fld_dteICProductCriteriaDiscountType.Properties.DisplayMember = "HREmployeeName";
            this.fld_dteICProductCriteriaDiscountType.Properties.NullText = "";
            this.fld_dteICProductCriteriaDiscountType.Properties.PopupWidth = 40;
            this.fld_dteICProductCriteriaDiscountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dteICProductCriteriaDiscountType.Properties.ValueMember = "HREmployeeID";
            this.fld_dteICProductCriteriaDiscountType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaDiscountType, true);
            this.fld_dteICProductCriteriaDiscountType.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaDiscountType.TabIndex = 2;
            this.fld_dteICProductCriteriaDiscountType.Tag = "DC";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(14, 186);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel3.TabIndex = 142;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên hợp đồng";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(321, 160);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(36, 13);
            this.bosLabel23.TabIndex = 587;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Báo giá";
            // 
            // fld_txtICProductCriteriaNane
            // 
            this.fld_txtICProductCriteriaNane.BOSComment = "";
            this.fld_txtICProductCriteriaNane.BOSDataMember = "ARSaleContractName";
            this.fld_txtICProductCriteriaNane.BOSDataSource = "ARSaleContracts";
            this.fld_txtICProductCriteriaNane.BOSDescription = null;
            this.fld_txtICProductCriteriaNane.BOSError = "";
            this.fld_txtICProductCriteriaNane.BOSFieldGroup = "";
            this.fld_txtICProductCriteriaNane.BOSFieldRelation = "";
            this.fld_txtICProductCriteriaNane.BOSPrivilege = "";
            this.fld_txtICProductCriteriaNane.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaNane.Location = new System.Drawing.Point(119, 183);
            this.fld_txtICProductCriteriaNane.Name = "fld_txtICProductCriteriaNane";
            this.fld_txtICProductCriteriaNane.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaNane.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaNane.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaNane.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaNane.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaNane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaNane.Screen = null;
            this.fld_txtICProductCriteriaNane.Size = new System.Drawing.Size(473, 20);
            this.fld_txtICProductCriteriaNane.TabIndex = 1;
            this.fld_txtICProductCriteriaNane.Tag = "DC";
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = false;
            this.bosLookupEdit4.BOSComment = "";
            this.bosLookupEdit4.BOSDataMember = "FK_ARProposalID";
            this.bosLookupEdit4.BOSDataSource = "ARSaleContracts";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = "";
            this.bosLookupEdit4.BOSFieldGroup = "";
            this.bosLookupEdit4.BOSFieldParent = "";
            this.bosLookupEdit4.BOSFieldRelation = "";
            this.bosLookupEdit4.BOSPrivilege = "";
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = "";
            this.bosLookupEdit4.BOSSelectTypeValue = "";
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(426, 157);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARProposalNo", "Mã báo giá"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARProposalName", "Tên báo giá")});
            this.bosLookupEdit4.Properties.DisplayMember = "ARProposalNo";
            this.bosLookupEdit4.Properties.NullText = "";
            this.bosLookupEdit4.Properties.PopupWidth = 40;
            this.bosLookupEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit4.Properties.ValueMember = "ARProposalID";
            this.bosLookupEdit4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit4, true);
            this.bosLookupEdit4.Size = new System.Drawing.Size(166, 20);
            this.bosLookupEdit4.TabIndex = 13;
            this.bosLookupEdit4.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(14, 28);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel2.TabIndex = 140;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã hợp đồng";
            // 
            // fld_txtICProductCriteriaNo
            // 
            this.fld_txtICProductCriteriaNo.BOSComment = "";
            this.fld_txtICProductCriteriaNo.BOSDataMember = "ARSaleContractNo";
            this.fld_txtICProductCriteriaNo.BOSDataSource = "ARSaleContracts";
            this.fld_txtICProductCriteriaNo.BOSDescription = null;
            this.fld_txtICProductCriteriaNo.BOSError = "";
            this.fld_txtICProductCriteriaNo.BOSFieldGroup = "";
            this.fld_txtICProductCriteriaNo.BOSFieldRelation = "";
            this.fld_txtICProductCriteriaNo.BOSPrivilege = "";
            this.fld_txtICProductCriteriaNo.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaNo.Location = new System.Drawing.Point(119, 25);
            this.fld_txtICProductCriteriaNo.Name = "fld_txtICProductCriteriaNo";
            this.fld_txtICProductCriteriaNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductCriteriaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaNo.Screen = null;
            this.fld_txtICProductCriteriaNo.Size = new System.Drawing.Size(166, 20);
            this.fld_txtICProductCriteriaNo.TabIndex = 0;
            this.fld_txtICProductCriteriaNo.Tag = "DC";
            // 
            // fld_dteICProductCriteriaType
            // 
            this.fld_dteICProductCriteriaType.BOSAllowAddNew = false;
            this.fld_dteICProductCriteriaType.BOSAllowDummy = false;
            this.fld_dteICProductCriteriaType.BOSComment = "";
            this.fld_dteICProductCriteriaType.BOSDataMember = "FK_ARSaleContractGroupID";
            this.fld_dteICProductCriteriaType.BOSDataSource = "ARSaleContracts";
            this.fld_dteICProductCriteriaType.BOSDescription = null;
            this.fld_dteICProductCriteriaType.BOSError = "";
            this.fld_dteICProductCriteriaType.BOSFieldGroup = "";
            this.fld_dteICProductCriteriaType.BOSFieldParent = "";
            this.fld_dteICProductCriteriaType.BOSFieldRelation = "";
            this.fld_dteICProductCriteriaType.BOSPrivilege = "";
            this.fld_dteICProductCriteriaType.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaType.BOSSelectType = "";
            this.fld_dteICProductCriteriaType.BOSSelectTypeValue = "";
            this.fld_dteICProductCriteriaType.CurrentDisplayText = null;
            this.fld_dteICProductCriteriaType.Location = new System.Drawing.Point(426, 77);
            this.fld_dteICProductCriteriaType.Name = "fld_dteICProductCriteriaType";
            this.fld_dteICProductCriteriaType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaType.Properties.ColumnName = null;
            this.fld_dteICProductCriteriaType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractGroupName", "Tên nhóm")});
            this.fld_dteICProductCriteriaType.Properties.DisplayMember = "ARSaleContractGroupName";
            this.fld_dteICProductCriteriaType.Properties.NullText = "";
            this.fld_dteICProductCriteriaType.Properties.PopupWidth = 40;
            this.fld_dteICProductCriteriaType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dteICProductCriteriaType.Properties.ValueMember = "ARSaleContractGroupID";
            this.fld_dteICProductCriteriaType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaType, true);
            this.fld_dteICProductCriteriaType.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaType.TabIndex = 9;
            this.fld_dteICProductCriteriaType.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseFont = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(321, 106);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(45, 13);
            this.bosLabel21.TabIndex = 583;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Mã dự án";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(321, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(77, 13);
            this.bosLabel2.TabIndex = 146;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Nhóm hợp đồng";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = "";
            this.bosLookupEdit3.BOSDataMember = "FK_PMProjectID";
            this.bosLookupEdit3.BOSDataSource = "ARSaleContracts";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = "";
            this.bosLookupEdit3.BOSFieldGroup = "";
            this.bosLookupEdit3.BOSFieldParent = "";
            this.bosLookupEdit3.BOSFieldRelation = "";
            this.bosLookupEdit3.BOSPrivilege = "";
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = "";
            this.bosLookupEdit3.BOSSelectTypeValue = "";
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(426, 103);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.bosLookupEdit3.Properties.DisplayMember = "PMProjectNo";
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.PopupWidth = 40;
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Properties.ValueMember = "PMProjectID";
            this.bosLookupEdit3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit3, true);
            this.bosLookupEdit3.Size = new System.Drawing.Size(166, 20);
            this.bosLookupEdit3.TabIndex = 10;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(119, 138);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(0, 13);
            this.bosLabel8.TabIndex = 156;
            this.bosLabel8.Tag = "";
            // 
            // fld_dteICProductCriteriaStartDate
            // 
            this.fld_dteICProductCriteriaStartDate.BOSComment = "";
            this.fld_dteICProductCriteriaStartDate.BOSDataMember = "ARSaleContractDate";
            this.fld_dteICProductCriteriaStartDate.BOSDataSource = "ARSaleContracts";
            this.fld_dteICProductCriteriaStartDate.BOSDescription = null;
            this.fld_dteICProductCriteriaStartDate.BOSError = null;
            this.fld_dteICProductCriteriaStartDate.BOSFieldGroup = "";
            this.fld_dteICProductCriteriaStartDate.BOSFieldRelation = "";
            this.fld_dteICProductCriteriaStartDate.BOSPrivilege = "";
            this.fld_dteICProductCriteriaStartDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaStartDate.EditValue = null;
            this.fld_dteICProductCriteriaStartDate.Location = new System.Drawing.Point(426, 25);
            this.fld_dteICProductCriteriaStartDate.Name = "fld_dteICProductCriteriaStartDate";
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductCriteriaStartDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaStartDate, true);
            this.fld_dteICProductCriteriaStartDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaStartDate.TabIndex = 8;
            this.fld_dteICProductCriteriaStartDate.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
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
            this.bosLabel5.Location = new System.Drawing.Point(321, 28);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(74, 13);
            this.bosLabel5.TabIndex = 142;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngày hợp đồng";
            // 
            // fld_dteICProductCriteriaEndDate
            // 
            this.fld_dteICProductCriteriaEndDate.BOSComment = "";
            this.fld_dteICProductCriteriaEndDate.BOSDataMember = "ARSaleContractValidDate";
            this.fld_dteICProductCriteriaEndDate.BOSDataSource = "ARSaleContracts";
            this.fld_dteICProductCriteriaEndDate.BOSDescription = null;
            this.fld_dteICProductCriteriaEndDate.BOSError = null;
            this.fld_dteICProductCriteriaEndDate.BOSFieldGroup = "";
            this.fld_dteICProductCriteriaEndDate.BOSFieldRelation = "";
            this.fld_dteICProductCriteriaEndDate.BOSPrivilege = "";
            this.fld_dteICProductCriteriaEndDate.BOSPropertyName = "EditValue";
            this.fld_dteICProductCriteriaEndDate.EditValue = null;
            this.fld_dteICProductCriteriaEndDate.Location = new System.Drawing.Point(119, 131);
            this.fld_dteICProductCriteriaEndDate.Name = "fld_dteICProductCriteriaEndDate";
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductCriteriaEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductCriteriaEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductCriteriaEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductCriteriaEndDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductCriteriaEndDate, true);
            this.fld_dteICProductCriteriaEndDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteICProductCriteriaEndDate.TabIndex = 4;
            this.fld_dteICProductCriteriaEndDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
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
            this.bosLabel1.Location = new System.Drawing.Point(14, 134);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(77, 13);
            this.bosLabel1.TabIndex = 143;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Hiệu lực từ ngày";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = "";
            this.bosDateEdit1.BOSDataMember = "ARSaleContractInvalidDate";
            this.bosDateEdit1.BOSDataSource = "ARSaleContracts";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = "";
            this.bosDateEdit1.BOSFieldRelation = "";
            this.bosDateEdit1.BOSPrivilege = "";
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(426, 131);
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
            this.ScreenHelper.SetShowHelp(this.bosDateEdit1, true);
            this.bosDateEdit1.Size = new System.Drawing.Size(166, 20);
            this.bosDateEdit1.TabIndex = 11;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
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
            this.bosLabel10.Location = new System.Drawing.Point(321, 134);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(87, 13);
            this.bosLabel10.TabIndex = 162;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Hiệu lực đến ngày";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARSaleContracts";
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
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(119, 157);
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
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 5;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            this.fld_lkeACObjectAccessKey.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACObjectAccessKey_CloseUp);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(14, 160);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 562;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeICProductCriteriaStatus
            // 
            this.fld_lkeICProductCriteriaStatus.BOSAllowAddNew = false;
            this.fld_lkeICProductCriteriaStatus.BOSAllowDummy = false;
            this.fld_lkeICProductCriteriaStatus.BOSComment = "";
            this.fld_lkeICProductCriteriaStatus.BOSDataMember = "ARSaleContractStatus";
            this.fld_lkeICProductCriteriaStatus.BOSDataSource = "ARSaleContracts";
            this.fld_lkeICProductCriteriaStatus.BOSDescription = null;
            this.fld_lkeICProductCriteriaStatus.BOSError = null;
            this.fld_lkeICProductCriteriaStatus.BOSFieldGroup = "";
            this.fld_lkeICProductCriteriaStatus.BOSFieldParent = "";
            this.fld_lkeICProductCriteriaStatus.BOSFieldRelation = "";
            this.fld_lkeICProductCriteriaStatus.BOSPrivilege = "";
            this.fld_lkeICProductCriteriaStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICProductCriteriaStatus.BOSSelectType = "";
            this.fld_lkeICProductCriteriaStatus.BOSSelectTypeValue = "";
            this.fld_lkeICProductCriteriaStatus.CurrentDisplayText = null;
            this.fld_lkeICProductCriteriaStatus.Location = new System.Drawing.Point(426, 51);
            this.fld_lkeICProductCriteriaStatus.Name = "fld_lkeICProductCriteriaStatus";
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductCriteriaStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductCriteriaStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductCriteriaStatus.Properties.ColumnName = null;
            this.fld_lkeICProductCriteriaStatus.Properties.NullText = "";
            this.fld_lkeICProductCriteriaStatus.Properties.ReadOnly = true;
            this.fld_lkeICProductCriteriaStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductCriteriaStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductCriteriaStatus, true);
            this.fld_lkeICProductCriteriaStatus.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeICProductCriteriaStatus.TabIndex = 6;
            this.fld_lkeICProductCriteriaStatus.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
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
            this.bosLabel3.Location = new System.Drawing.Point(321, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 148;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Trạng thái";
            // 
            // fld_lkeARSaleContractParrentiD
            // 
            this.fld_lkeARSaleContractParrentiD.BOSAllowAddNew = false;
            this.fld_lkeARSaleContractParrentiD.BOSAllowDummy = false;
            this.fld_lkeARSaleContractParrentiD.BOSComment = "";
            this.fld_lkeARSaleContractParrentiD.BOSDataMember = "ARSaleContractParentID";
            this.fld_lkeARSaleContractParrentiD.BOSDataSource = "ARSaleContracts";
            this.fld_lkeARSaleContractParrentiD.BOSDescription = null;
            this.fld_lkeARSaleContractParrentiD.BOSError = "";
            this.fld_lkeARSaleContractParrentiD.BOSFieldGroup = "";
            this.fld_lkeARSaleContractParrentiD.BOSFieldParent = "";
            this.fld_lkeARSaleContractParrentiD.BOSFieldRelation = "";
            this.fld_lkeARSaleContractParrentiD.BOSPrivilege = "";
            this.fld_lkeARSaleContractParrentiD.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleContractParrentiD.BOSSelectType = "";
            this.fld_lkeARSaleContractParrentiD.BOSSelectTypeValue = "";
            this.fld_lkeARSaleContractParrentiD.CurrentDisplayText = null;
            this.fld_lkeARSaleContractParrentiD.Location = new System.Drawing.Point(119, 103);
            this.fld_lkeARSaleContractParrentiD.Name = "fld_lkeARSaleContractParrentiD";
            this.fld_lkeARSaleContractParrentiD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleContractParrentiD.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleContractParrentiD.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleContractParrentiD.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleContractParrentiD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleContractParrentiD.Properties.ColumnName = null;
            this.fld_lkeARSaleContractParrentiD.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleContractName", "Tên hợp đồng")});
            this.fld_lkeARSaleContractParrentiD.Properties.DisplayMember = "ARSaleContractName";
            this.fld_lkeARSaleContractParrentiD.Properties.NullText = "";
            this.fld_lkeARSaleContractParrentiD.Properties.PopupWidth = 40;
            this.fld_lkeARSaleContractParrentiD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleContractParrentiD.Properties.ValueMember = "ARSaleContractID";
            this.fld_lkeARSaleContractParrentiD.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleContractParrentiD, true);
            this.fld_lkeARSaleContractParrentiD.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeARSaleContractParrentiD.TabIndex = 3;
            this.fld_lkeARSaleContractParrentiD.Tag = "DC";
            this.fld_lkeARSaleContractParrentiD.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeARSaleContractParrentiD_QueryPopUp);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(14, 106);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(69, 13);
            this.bosLabel9.TabIndex = 161;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Hợp đồng gốc";
            // 
            // fld_txtICProductCriteriaDiscountPercent
            // 
            this.fld_txtICProductCriteriaDiscountPercent.BOSComment = "";
            this.fld_txtICProductCriteriaDiscountPercent.BOSDataMember = "ARSaleContractKHNos";
            this.fld_txtICProductCriteriaDiscountPercent.BOSDataSource = "ARSaleContracts";
            this.fld_txtICProductCriteriaDiscountPercent.BOSDescription = null;
            this.fld_txtICProductCriteriaDiscountPercent.BOSError = null;
            this.fld_txtICProductCriteriaDiscountPercent.BOSFieldGroup = "";
            this.fld_txtICProductCriteriaDiscountPercent.BOSFieldRelation = "";
            this.fld_txtICProductCriteriaDiscountPercent.BOSPrivilege = "";
            this.fld_txtICProductCriteriaDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaDiscountPercent.Location = new System.Drawing.Point(119, 51);
            this.fld_txtICProductCriteriaDiscountPercent.Name = "fld_txtICProductCriteriaDiscountPercent";
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.EditFormat.FormatString = "n2";
            this.fld_txtICProductCriteriaDiscountPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtICProductCriteriaDiscountPercent.Properties.Mask.EditMask = null;
            this.fld_txtICProductCriteriaDiscountPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCriteriaDiscountPercent, false);
            this.fld_txtICProductCriteriaDiscountPercent.Size = new System.Drawing.Size(166, 20);
            this.fld_txtICProductCriteriaDiscountPercent.TabIndex = 12;
            this.fld_txtICProductCriteriaDiscountPercent.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(14, 54);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(76, 13);
            this.bosLabel6.TabIndex = 152;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Số hợp đồng KH";
            // 
            // fld_pteMMProductionNormProductPicture
            // 
            this.fld_pteMMProductionNormProductPicture.BOSComment = "";
            this.fld_pteMMProductionNormProductPicture.BOSDataMember = "MMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormProductPicture.BOSDescription = null;
            this.fld_pteMMProductionNormProductPicture.BOSError = null;
            this.fld_pteMMProductionNormProductPicture.BOSFieldGroup = "";
            this.fld_pteMMProductionNormProductPicture.BOSFieldRelation = "";
            this.fld_pteMMProductionNormProductPicture.BOSPrivilege = "";
            this.fld_pteMMProductionNormProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteMMProductionNormProductPicture.EditValue = "";
            this.fld_pteMMProductionNormProductPicture.FileName = null;
            this.fld_pteMMProductionNormProductPicture.FilePath = null;
            this.fld_pteMMProductionNormProductPicture.Location = new System.Drawing.Point(9, 25);
            this.fld_pteMMProductionNormProductPicture.Name = "fld_pteMMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteMMProductionNormProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteMMProductionNormProductPicture, true);
            this.fld_pteMMProductionNormProductPicture.Size = new System.Drawing.Size(120, 112);
            this.fld_pteMMProductionNormProductPicture.TabIndex = 136;
            this.fld_pteMMProductionNormProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARSaleContracts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(10, 143);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 4;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseFont = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(363, 414);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 334;
            this.fld_lblLabel11.Tag = "";
            // 
            // DMSCS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1120, 610);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "DMSCS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.fld_tabSOItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractAnswerableAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractAnswerablePercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleContractGuaranteeAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftd_txtARSaleContractGuaranteePercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaDiscountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductCriteriaEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCriteriaStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleContractParrentiD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleContractParrentiD;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaDiscountPercent;
        private BOSComponent.BOSTextBox fld_txtARSaleContractSubTotalAmount;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductCriteriaStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_dteICProductCriteriaType;
        private BOSComponent.BOSDateEdit fld_dteICProductCriteriaEndDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteICProductCriteriaStartDate;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSTextBox fld_txtARSaleContractDiscountAmount;
        private BOSComponent.BOSTextBox fld_txtARSaleContractDiscountPercent;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox ftd_txtARSaleContractGuaranteePercent;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtARSaleContractGuaranteeAmount;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtARSaleContractAnswerableAmount;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtARSaleContractAnswerablePercent;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_dteICProductCriteriaDiscountType;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaNane;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage fld_tabSOItems;
        private SaleContract.ARSaleOrderGridControl fld_dgcARSaleOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;
    }
}
