using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ContainerLoader.UI
{
	/// <summary>
	/// Summary description for DMCL100
	/// </summary>
	partial class DMCL100
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
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_meARContainerLoaderReference = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProductList = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnChooseFromPlan = new BOSComponent.BOSButton(this.components);
            this.fld_pteARContainerLoaderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcARContainerLoaderItems = new BOSERP.Modules.ContainerLoader.ARContainerLoaderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeARContainerLoaderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEContainerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARContainerLoaderContNo = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARContainerLoaderDelivery = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARContainerLoaderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtARContainerLoaderNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lbPono = new BOSComponent.BOSLabel(this.components);
            this.bosLabel60 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_meARContainerLoaderReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARContainerLoaderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARContainerLoaderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARContainerLoaderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEContainerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARContainerLoaderContNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARContainerLoaderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTextBox4);
            this.bosPanel1.Controls.Add(this.bosLabel60);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.fld_lbPono);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_meARContainerLoaderReference);
            this.bosPanel1.Controls.Add(this.fld_tabProductionNorm);
            this.bosPanel1.Controls.Add(this.fld_lkeARContainerLoaderStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEContainerID);
            this.bosPanel1.Controls.Add(this.fld_txtARContainerLoaderContNo);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.fld_dteARContainerLoaderDelivery);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteARContainerLoaderDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARContainerLoaderNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1162, 636);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ARContainerLoaderTrainRunDate";
            this.bosDateEdit1.BOSDataSource = "ARContainerLoaders";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(775, 35);
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
            this.bosDateEdit1.TabIndex = 23;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(679, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(70, 13);
            this.bosLabel6.TabIndex = 22;
            this.bosLabel6.Text = "Ngày tàu chạy";
            // 
            // fld_meARContainerLoaderReference
            // 
            this.fld_meARContainerLoaderReference.BOSComment = "";
            this.fld_meARContainerLoaderReference.BOSDataMember = "ARContainerLoaderReference";
            this.fld_meARContainerLoaderReference.BOSDataSource = "ARContainerLoaders";
            this.fld_meARContainerLoaderReference.BOSDescription = null;
            this.fld_meARContainerLoaderReference.BOSError = null;
            this.fld_meARContainerLoaderReference.BOSFieldGroup = "";
            this.fld_meARContainerLoaderReference.BOSFieldRelation = "";
            this.fld_meARContainerLoaderReference.BOSPrivilege = "";
            this.fld_meARContainerLoaderReference.BOSPropertyName = "EditValue";
            this.fld_meARContainerLoaderReference.EditValue = "";
            this.fld_meARContainerLoaderReference.Location = new System.Drawing.Point(775, 89);
            this.fld_meARContainerLoaderReference.Name = "fld_meARContainerLoaderReference";
            this.fld_meARContainerLoaderReference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_meARContainerLoaderReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_meARContainerLoaderReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_meARContainerLoaderReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_meARContainerLoaderReference.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_meARContainerLoaderReference, true);
            this.fld_meARContainerLoaderReference.Size = new System.Drawing.Size(151, 44);
            this.fld_meARContainerLoaderReference.TabIndex = 18;
            this.fld_meARContainerLoaderReference.Tag = "DC";
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
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(3, 139);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.Screen = null;
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabProductList;
            this.ScreenHelper.SetShowHelp(this.fld_tabProductionNorm, true);
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(1156, 494);
            this.fld_tabProductionNorm.TabIndex = 0;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductList});
            // 
            // fld_tabProductList
            // 
            this.fld_tabProductList.Controls.Add(this.fld_btnChooseFromPlan);
            this.fld_tabProductList.Controls.Add(this.fld_pteARContainerLoaderItemProductPicture);
            this.fld_tabProductList.Controls.Add(this.fld_dgcARContainerLoaderItems);
            this.fld_tabProductList.Name = "fld_tabProductList";
            this.ScreenHelper.SetShowHelp(this.fld_tabProductList, true);
            this.fld_tabProductList.Size = new System.Drawing.Size(1150, 466);
            this.fld_tabProductList.Text = "Danh sách sản phẩm";
            // 
            // fld_btnChooseFromPlan
            // 
            this.fld_btnChooseFromPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChooseFromPlan.BOSComment = null;
            this.fld_btnChooseFromPlan.BOSDataMember = null;
            this.fld_btnChooseFromPlan.BOSDataSource = null;
            this.fld_btnChooseFromPlan.BOSDescription = null;
            this.fld_btnChooseFromPlan.BOSError = null;
            this.fld_btnChooseFromPlan.BOSFieldGroup = null;
            this.fld_btnChooseFromPlan.BOSFieldRelation = null;
            this.fld_btnChooseFromPlan.BOSPrivilege = null;
            this.fld_btnChooseFromPlan.BOSPropertyName = null;
            this.fld_btnChooseFromPlan.Location = new System.Drawing.Point(1012, 3);
            this.fld_btnChooseFromPlan.Name = "fld_btnChooseFromPlan";
            this.fld_btnChooseFromPlan.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChooseFromPlan, true);
            this.fld_btnChooseFromPlan.Size = new System.Drawing.Size(134, 27);
            this.fld_btnChooseFromPlan.TabIndex = 22;
            this.fld_btnChooseFromPlan.Text = "Thêm từ KHGH";
            this.fld_btnChooseFromPlan.Click += new System.EventHandler(this.fld_btnChooseFromPlan_Click);
            // 
            // fld_pteARContainerLoaderItemProductPicture
            // 
            this.fld_pteARContainerLoaderItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARContainerLoaderItemProductPicture.BOSComment = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSDataMember = "ARContainerLoaderItemProductPicture";
            this.fld_pteARContainerLoaderItemProductPicture.BOSDataSource = "ARContainerLoaderItems";
            this.fld_pteARContainerLoaderItemProductPicture.BOSDescription = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSError = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSPrivilege = null;
            this.fld_pteARContainerLoaderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARContainerLoaderItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARContainerLoaderItemProductPicture.FileName = null;
            this.fld_pteARContainerLoaderItemProductPicture.FilePath = null;
            this.fld_pteARContainerLoaderItemProductPicture.Location = new System.Drawing.Point(1011, 44);
            this.fld_pteARContainerLoaderItemProductPicture.Name = "fld_pteARContainerLoaderItemProductPicture";
            this.fld_pteARContainerLoaderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARContainerLoaderItemProductPicture.Screen = null;
            this.fld_pteARContainerLoaderItemProductPicture.Size = new System.Drawing.Size(135, 130);
            this.fld_pteARContainerLoaderItemProductPicture.TabIndex = 3;
            this.fld_pteARContainerLoaderItemProductPicture.Tag = "DC";
            // 
            // fld_dgcARContainerLoaderItems
            // 
            this.fld_dgcARContainerLoaderItems.AllowDrop = true;
            this.fld_dgcARContainerLoaderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARContainerLoaderItems.BOSComment = null;
            this.fld_dgcARContainerLoaderItems.BOSDataMember = null;
            this.fld_dgcARContainerLoaderItems.BOSDataSource = "ARContainerLoaderItems";
            this.fld_dgcARContainerLoaderItems.BOSDescription = null;
            this.fld_dgcARContainerLoaderItems.BOSError = null;
            this.fld_dgcARContainerLoaderItems.BOSFieldGroup = null;
            this.fld_dgcARContainerLoaderItems.BOSFieldRelation = null;
            this.fld_dgcARContainerLoaderItems.BOSGridType = null;
            this.fld_dgcARContainerLoaderItems.BOSPrivilege = null;
            this.fld_dgcARContainerLoaderItems.BOSPropertyName = null;
            this.fld_dgcARContainerLoaderItems.CommodityType = "";
            this.fld_dgcARContainerLoaderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARContainerLoaderItems.Location = new System.Drawing.Point(2, 0);
            this.fld_dgcARContainerLoaderItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARContainerLoaderItems.Name = "fld_dgcARContainerLoaderItems";
            this.fld_dgcARContainerLoaderItems.PrintReport = false;
            this.fld_dgcARContainerLoaderItems.Screen = null;
            this.fld_dgcARContainerLoaderItems.Size = new System.Drawing.Size(1004, 462);
            this.fld_dgcARContainerLoaderItems.TabIndex = 1;
            this.fld_dgcARContainerLoaderItems.Tag = "DC";
            this.fld_dgcARContainerLoaderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARContainerLoaderItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_lkeARContainerLoaderStatus
            // 
            this.fld_lkeARContainerLoaderStatus.BOSAllowAddNew = false;
            this.fld_lkeARContainerLoaderStatus.BOSAllowDummy = false;
            this.fld_lkeARContainerLoaderStatus.BOSComment = null;
            this.fld_lkeARContainerLoaderStatus.BOSDataMember = "ARContainerLoaderStatus";
            this.fld_lkeARContainerLoaderStatus.BOSDataSource = "ARContainerLoaders";
            this.fld_lkeARContainerLoaderStatus.BOSDescription = null;
            this.fld_lkeARContainerLoaderStatus.BOSError = null;
            this.fld_lkeARContainerLoaderStatus.BOSFieldGroup = null;
            this.fld_lkeARContainerLoaderStatus.BOSFieldParent = null;
            this.fld_lkeARContainerLoaderStatus.BOSFieldRelation = null;
            this.fld_lkeARContainerLoaderStatus.BOSPrivilege = null;
            this.fld_lkeARContainerLoaderStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARContainerLoaderStatus.BOSSelectType = null;
            this.fld_lkeARContainerLoaderStatus.BOSSelectTypeValue = null;
            this.fld_lkeARContainerLoaderStatus.CurrentDisplayText = null;
            this.fld_lkeARContainerLoaderStatus.Location = new System.Drawing.Point(775, 61);
            this.fld_lkeARContainerLoaderStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARContainerLoaderStatus.Name = "fld_lkeARContainerLoaderStatus";
            this.fld_lkeARContainerLoaderStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARContainerLoaderStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARContainerLoaderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARContainerLoaderStatus.Properties.ColumnName = null;
            this.fld_lkeARContainerLoaderStatus.Properties.NullText = "";
            this.fld_lkeARContainerLoaderStatus.Properties.ReadOnly = true;
            this.fld_lkeARContainerLoaderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARContainerLoaderStatus.Screen = null;
            this.fld_lkeARContainerLoaderStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARContainerLoaderStatus.TabIndex = 12;
            this.fld_lkeARContainerLoaderStatus.Tag = "DC";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(679, 64);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 11;
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ARContainerLoaderName";
            this.bosTextBox1.BOSDataSource = "ARContainerLoaders";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(210, 35);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(116, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(116, 64);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(23, 13);
            this.bosLabel27.TabIndex = 13;
            this.bosLabel27.Text = "Cont";
            // 
            // fld_lkeFK_GEContainerID
            // 
            this.fld_lkeFK_GEContainerID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEContainerID.BOSAllowDummy = false;
            this.fld_lkeFK_GEContainerID.BOSComment = null;
            this.fld_lkeFK_GEContainerID.BOSDataMember = "FK_GEContainerID";
            this.fld_lkeFK_GEContainerID.BOSDataSource = "ARContainerLoaders";
            this.fld_lkeFK_GEContainerID.BOSDescription = null;
            this.fld_lkeFK_GEContainerID.BOSError = null;
            this.fld_lkeFK_GEContainerID.BOSFieldGroup = null;
            this.fld_lkeFK_GEContainerID.BOSFieldParent = null;
            this.fld_lkeFK_GEContainerID.BOSFieldRelation = null;
            this.fld_lkeFK_GEContainerID.BOSPrivilege = null;
            this.fld_lkeFK_GEContainerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEContainerID.BOSSelectType = "";
            this.fld_lkeFK_GEContainerID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEContainerID.CurrentDisplayText = null;
            this.fld_lkeFK_GEContainerID.Location = new System.Drawing.Point(210, 61);
            this.fld_lkeFK_GEContainerID.Name = "fld_lkeFK_GEContainerID";
            this.fld_lkeFK_GEContainerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEContainerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEContainerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEContainerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEContainerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEContainerID.Properties.ColumnName = null;
            this.fld_lkeFK_GEContainerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEContainerNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEContainerName", "Tên")});
            this.fld_lkeFK_GEContainerID.Properties.DisplayMember = "GEContainerName";
            this.fld_lkeFK_GEContainerID.Properties.NullText = "";
            this.fld_lkeFK_GEContainerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEContainerID.Properties.ValueMember = "GEContainerID";
            this.fld_lkeFK_GEContainerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEContainerID, true);
            this.fld_lkeFK_GEContainerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEContainerID.TabIndex = 14;
            this.fld_lkeFK_GEContainerID.Tag = "DC";
            // 
            // fld_txtARContainerLoaderContNo
            // 
            this.fld_txtARContainerLoaderContNo.BOSComment = null;
            this.fld_txtARContainerLoaderContNo.BOSDataMember = "ARContainerLoaderContNo";
            this.fld_txtARContainerLoaderContNo.BOSDataSource = "ARContainerLoaders";
            this.fld_txtARContainerLoaderContNo.BOSDescription = null;
            this.fld_txtARContainerLoaderContNo.BOSError = null;
            this.fld_txtARContainerLoaderContNo.BOSFieldGroup = null;
            this.fld_txtARContainerLoaderContNo.BOSFieldRelation = null;
            this.fld_txtARContainerLoaderContNo.BOSPrivilege = null;
            this.fld_txtARContainerLoaderContNo.BOSPropertyName = "EditValue";
            this.fld_txtARContainerLoaderContNo.Location = new System.Drawing.Point(496, 35);
            this.fld_txtARContainerLoaderContNo.Name = "fld_txtARContainerLoaderContNo";
            this.fld_txtARContainerLoaderContNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARContainerLoaderContNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARContainerLoaderContNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARContainerLoaderContNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARContainerLoaderContNo.Properties.Mask.EditMask = "n";
            this.fld_txtARContainerLoaderContNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARContainerLoaderContNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARContainerLoaderContNo.Screen = null;
            this.fld_txtARContainerLoaderContNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARContainerLoaderContNo.TabIndex = 16;
            this.fld_txtARContainerLoaderContNo.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ARContainerLoaderSealNo";
            this.bosTextBox3.BOSDataSource = "ARContainerLoaders";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(496, 61);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.EditMask = "n";
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 16;
            this.bosTextBox3.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(399, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Text = "Cont.No";
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
            this.bosLabel23.Location = new System.Drawing.Point(679, 92);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(68, 13);
            this.bosLabel23.TabIndex = 17;
            this.bosLabel23.Text = "Đơn bán hàng";
            // 
            // fld_dteARContainerLoaderDelivery
            // 
            this.fld_dteARContainerLoaderDelivery.BOSComment = null;
            this.fld_dteARContainerLoaderDelivery.BOSDataMember = "ARContainerLoaderDelivery";
            this.fld_dteARContainerLoaderDelivery.BOSDataSource = "ARContainerLoaders";
            this.fld_dteARContainerLoaderDelivery.BOSDescription = null;
            this.fld_dteARContainerLoaderDelivery.BOSError = null;
            this.fld_dteARContainerLoaderDelivery.BOSFieldGroup = null;
            this.fld_dteARContainerLoaderDelivery.BOSFieldRelation = null;
            this.fld_dteARContainerLoaderDelivery.BOSPrivilege = null;
            this.fld_dteARContainerLoaderDelivery.BOSPropertyName = "EditValue";
            this.fld_dteARContainerLoaderDelivery.EditValue = null;
            this.fld_dteARContainerLoaderDelivery.Location = new System.Drawing.Point(775, 9);
            this.fld_dteARContainerLoaderDelivery.Name = "fld_dteARContainerLoaderDelivery";
            this.fld_dteARContainerLoaderDelivery.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARContainerLoaderDelivery.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARContainerLoaderDelivery.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARContainerLoaderDelivery.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARContainerLoaderDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARContainerLoaderDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARContainerLoaderDelivery.Screen = null;
            this.fld_dteARContainerLoaderDelivery.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARContainerLoaderDelivery.TabIndex = 6;
            this.fld_dteARContainerLoaderDelivery.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(399, 64);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(34, 13);
            this.bosLabel5.TabIndex = 15;
            this.bosLabel5.Text = "Số seal";
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
            this.bosLabel4.Location = new System.Drawing.Point(679, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 5;
            this.bosLabel4.Text = "Ngày giao";
            // 
            // fld_dteARContainerLoaderDate
            // 
            this.fld_dteARContainerLoaderDate.BOSComment = null;
            this.fld_dteARContainerLoaderDate.BOSDataMember = "ARContainerLoaderDate";
            this.fld_dteARContainerLoaderDate.BOSDataSource = "ARContainerLoaders";
            this.fld_dteARContainerLoaderDate.BOSDescription = null;
            this.fld_dteARContainerLoaderDate.BOSError = null;
            this.fld_dteARContainerLoaderDate.BOSFieldGroup = null;
            this.fld_dteARContainerLoaderDate.BOSFieldRelation = null;
            this.fld_dteARContainerLoaderDate.BOSPrivilege = null;
            this.fld_dteARContainerLoaderDate.BOSPropertyName = "EditValue";
            this.fld_dteARContainerLoaderDate.EditValue = null;
            this.fld_dteARContainerLoaderDate.Location = new System.Drawing.Point(496, 9);
            this.fld_dteARContainerLoaderDate.Name = "fld_dteARContainerLoaderDate";
            this.fld_dteARContainerLoaderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARContainerLoaderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARContainerLoaderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARContainerLoaderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARContainerLoaderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARContainerLoaderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARContainerLoaderDate.Screen = null;
            this.fld_dteARContainerLoaderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARContainerLoaderDate.TabIndex = 4;
            this.fld_dteARContainerLoaderDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(399, 12);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 3;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = "";
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARContainerLoaderDesc";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARContainerLoaders";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = "";
            this.fld_medARSaleOrderDesc.BOSFieldRelation = "";
            this.fld_medARSaleOrderDesc.BOSPrivilege = "";
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.EditValue = "";
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(210, 87);
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARSaleOrderDesc, true);
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(436, 42);
            this.fld_medARSaleOrderDesc.TabIndex = 20;
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
            this.bosLabel3.Location = new System.Drawing.Point(116, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 19;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_pteARSaleOrderEmployeePicture
            // 
            this.fld_pteARSaleOrderEmployeePicture.BOSComment = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSDataMember = "ARContainerLoaderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataSource = "ARContainerLoaders";
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
            // fld_txtARContainerLoaderNo
            // 
            this.fld_txtARContainerLoaderNo.BOSComment = null;
            this.fld_txtARContainerLoaderNo.BOSDataMember = "ARContainerLoaderNo";
            this.fld_txtARContainerLoaderNo.BOSDataSource = "ARContainerLoaders";
            this.fld_txtARContainerLoaderNo.BOSDescription = null;
            this.fld_txtARContainerLoaderNo.BOSError = null;
            this.fld_txtARContainerLoaderNo.BOSFieldGroup = null;
            this.fld_txtARContainerLoaderNo.BOSFieldRelation = null;
            this.fld_txtARContainerLoaderNo.BOSPrivilege = null;
            this.fld_txtARContainerLoaderNo.BOSPropertyName = "EditValue";
            this.fld_txtARContainerLoaderNo.Location = new System.Drawing.Point(210, 9);
            this.fld_txtARContainerLoaderNo.MenuManager = this.screenToolbar;
            this.fld_txtARContainerLoaderNo.Name = "fld_txtARContainerLoaderNo";
            this.fld_txtARContainerLoaderNo.Screen = null;
            this.fld_txtARContainerLoaderNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARContainerLoaderNo.TabIndex = 2;
            this.fld_txtARContainerLoaderNo.Tag = "DC";
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
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARContainerLoaders";
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 21;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ARContainerLoaderPONo";
            this.bosTextBox2.BOSDataSource = "ARContainerLoaders";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(1004, 9);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 734;
            this.bosTextBox2.Tag = "DC";
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
            this.fld_lbPono.Location = new System.Drawing.Point(947, 12);
            this.fld_lbPono.Name = "fld_lbPono";
            this.fld_lbPono.Screen = null;
            this.fld_lbPono.Size = new System.Drawing.Size(46, 13);
            this.fld_lbPono.TabIndex = 735;
            this.fld_lbPono.Text = "Số PO.No";
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
            this.bosLabel60.Location = new System.Drawing.Point(947, 38);
            this.bosLabel60.Name = "bosLabel60";
            this.bosLabel60.Screen = null;
            this.bosLabel60.Size = new System.Drawing.Size(48, 13);
            this.bosLabel60.TabIndex = 737;
            this.bosLabel60.Tag = "";
            this.bosLabel60.Text = "Đối tượng";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ARContainerLoaderObjectName";
            this.bosTextBox4.BOSDataSource = "ARContainerLoaders";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.Location = new System.Drawing.Point(1004, 35);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.ReadOnly = true;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 738;
            this.bosTextBox4.Tag = "DC";
            // 
            // DMCL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1162, 636);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCL100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_meARContainerLoaderReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARContainerLoaderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARContainerLoaderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARContainerLoaderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEContainerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARContainerLoaderContNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARContainerLoaderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSERP.Modules.ContainerLoader.ARContainerLoaderItemsGridControl fld_dgcARContainerLoaderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtARContainerLoaderNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARContainerLoaderDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEContainerID;
        private BOSComponent.BOSLookupEdit fld_lkeARContainerLoaderStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSPictureEdit fld_pteARContainerLoaderItemProductPicture;
        private BOSComponent.BOSDateEdit fld_dteARContainerLoaderDelivery;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSMemoEdit fld_meARContainerLoaderReference;
        private BOSComponent.BOSButton fld_btnChooseFromPlan;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtARContainerLoaderContNo;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel fld_lbPono;
        private BOSComponent.BOSLabel bosLabel60;
        private BOSComponent.BOSTextBox bosTextBox4;
    }
}
