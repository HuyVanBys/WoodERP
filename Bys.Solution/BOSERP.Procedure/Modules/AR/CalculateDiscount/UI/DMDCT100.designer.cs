using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CalculateDiscount.UI
{
    /// <summary>
    /// Summary description for DMARCV100
    /// </summary>
    partial class DMDCT100
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
            this.fld_txtARDiscountProgramNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvARCalculateDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabcCalDiscount = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel40 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel39 = new BOSComponent.BOSLabel(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARDiscountPrograms = new BOSERP.Modules.CalculateDiscount.ARDiscountProgramsGridControl();
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDiscountProgramBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARDiscountProgramName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_dteARDiscountProgramEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabCalculateDiscounts = new DevExpress.XtraTab.XtraTabPage();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARCalculateDiscountItems = new BOSERP.Modules.CalculateDiscount.ARCalculateDiscountItemsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_groupDiscountProgram = new DevExpress.XtraEditors.GroupControl();
            this.fld_lkeFK_ARDiscountProgramID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerDistributionChannelID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey2 = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCalculateDiscountType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCalculateDiscountStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnReLoadSales = new BOSComponent.BOSButton(this.components);
            this.fld_btnApprove = new BOSComponent.BOSButton(this.components);
            this.fld_lblBRPOSDate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_dteARCalculateDiscountDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnLoadSalesTarget = new BOSComponent.BOSButton(this.components);
            this.fld_medARCalculateDiscountDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCalculateDiscountName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCalculateDiscountNo = new BOSComponent.BOSTextBox(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCalculateDiscount)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabcCalDiscount)).BeginInit();
            this.fld_tabcCalDiscount.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties)).BeginInit();
            this.fld_tabCalculateDiscounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCalculateDiscountItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_groupDiscountProgram)).BeginInit();
            this.fld_groupDiscountProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDiscountProgramID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCalculateDiscountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCalculateDiscountStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCalculateDiscountDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCalculateDiscountDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCalculateDiscountDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCalculateDiscountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCalculateDiscountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARDiscountProgramNo
            // 
            this.fld_txtARDiscountProgramNo.BOSComment = null;
            this.fld_txtARDiscountProgramNo.BOSDataMember = "ARDiscountProgramNo";
            this.fld_txtARDiscountProgramNo.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramNo.BOSDescription = null;
            this.fld_txtARDiscountProgramNo.BOSError = null;
            this.fld_txtARDiscountProgramNo.BOSFieldGroup = null;
            this.fld_txtARDiscountProgramNo.BOSFieldRelation = null;
            this.fld_txtARDiscountProgramNo.BOSPrivilege = null;
            this.fld_txtARDiscountProgramNo.BOSPropertyName = "EditValue";
            this.fld_txtARDiscountProgramNo.Location = new System.Drawing.Point(111, 14);
            this.fld_txtARDiscountProgramNo.MenuManager = this.screenToolbar;
            this.fld_txtARDiscountProgramNo.Name = "fld_txtARDiscountProgramNo";
            this.fld_txtARDiscountProgramNo.Screen = null;
            this.fld_txtARDiscountProgramNo.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARDiscountProgramNo.TabIndex = 0;
            this.fld_txtARDiscountProgramNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(20, 17);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(78, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chương trình";
            // 
            // fld_dgvARCalculateDiscount
            // 
            this.fld_dgvARCalculateDiscount.Name = "fld_dgvARCalculateDiscount";
            this.fld_dgvARCalculateDiscount.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_tabcCalDiscount);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1159, 776);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_tabcCalDiscount
            // 
            this.fld_tabcCalDiscount.BOSComment = null;
            this.fld_tabcCalDiscount.BOSDataMember = null;
            this.fld_tabcCalDiscount.BOSDataSource = null;
            this.fld_tabcCalDiscount.BOSDescription = null;
            this.fld_tabcCalDiscount.BOSError = null;
            this.fld_tabcCalDiscount.BOSFieldGroup = null;
            this.fld_tabcCalDiscount.BOSFieldRelation = null;
            this.fld_tabcCalDiscount.BOSPrivilege = null;
            this.fld_tabcCalDiscount.BOSPropertyName = null;
            this.fld_tabcCalDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabcCalDiscount.Location = new System.Drawing.Point(0, 0);
            this.fld_tabcCalDiscount.Name = "fld_tabcCalDiscount";
            this.fld_tabcCalDiscount.Screen = null;
            this.fld_tabcCalDiscount.SelectedTabPage = this.xtraTabPage1;
            this.fld_tabcCalDiscount.Size = new System.Drawing.Size(1159, 776);
            this.fld_tabcCalDiscount.TabIndex = 123;
            this.fld_tabcCalDiscount.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.fld_tabCalculateDiscounts});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPanel2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1153, 748);
            this.xtraTabPage1.Text = "Danh sách chương trình";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoScroll = true;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLine5);
            this.bosPanel2.Controls.Add(this.bosGroupControl1);
            this.bosPanel2.Controls.Add(this.fld_txtARDiscountProgramNo);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.fld_btnSearch);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_dteARDiscountProgramBeginDate);
            this.bosPanel2.Controls.Add(this.fld_txtARDiscountProgramName);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel2.Controls.Add(this.fld_dteARDiscountProgramEndDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel5);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1153, 748);
            this.bosPanel2.TabIndex = 0;
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLabel41);
            this.bosLine5.Controls.Add(this.bosLabel40);
            this.bosLine5.Controls.Add(this.bosLabel39);
            this.bosLine5.Controls.Add(this.button4);
            this.bosLine5.Controls.Add(this.button2);
            this.bosLine5.Controls.Add(this.button5);
            this.bosLine5.Location = new System.Drawing.Point(596, 5);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(274, 89);
            this.bosLine5.TabIndex = 124;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Chú thích";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel41.Appearance.Options.UseFont = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(59, 63);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(45, 12);
            this.bosLabel41.TabIndex = 31;
            this.bosLabel41.Text = "Đã duyệt";
            // 
            // bosLabel40
            // 
            this.bosLabel40.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel40.Appearance.Options.UseFont = true;
            this.bosLabel40.BOSComment = null;
            this.bosLabel40.BOSDataMember = null;
            this.bosLabel40.BOSDataSource = null;
            this.bosLabel40.BOSDescription = null;
            this.bosLabel40.BOSError = null;
            this.bosLabel40.BOSFieldGroup = null;
            this.bosLabel40.BOSFieldRelation = null;
            this.bosLabel40.BOSPrivilege = null;
            this.bosLabel40.BOSPropertyName = null;
            this.bosLabel40.Location = new System.Drawing.Point(59, 42);
            this.bosLabel40.Name = "bosLabel40";
            this.bosLabel40.Screen = null;
            this.bosLabel40.Size = new System.Drawing.Size(179, 12);
            this.bosLabel40.TabIndex = 30;
            this.bosLabel40.Text = "Đã tạo chiết khấu kỳ và chưa Duyệt";
            // 
            // bosLabel39
            // 
            this.bosLabel39.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.bosLabel39.Appearance.Options.UseFont = true;
            this.bosLabel39.BOSComment = null;
            this.bosLabel39.BOSDataMember = null;
            this.bosLabel39.BOSDataSource = null;
            this.bosLabel39.BOSDescription = null;
            this.bosLabel39.BOSError = null;
            this.bosLabel39.BOSFieldGroup = null;
            this.bosLabel39.BOSFieldRelation = null;
            this.bosLabel39.BOSPrivilege = null;
            this.bosLabel39.BOSPropertyName = null;
            this.bosLabel39.Location = new System.Drawing.Point(59, 22);
            this.bosLabel39.Name = "bosLabel39";
            this.bosLabel39.Screen = null;
            this.bosLabel39.Size = new System.Drawing.Size(120, 12);
            this.bosLabel39.TabIndex = 29;
            this.bosLabel39.Text = "Chưa tạo Chiếu khấu kỳ";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button4.Location = new System.Drawing.Point(10, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 15);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button2.Location = new System.Drawing.Point(10, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 15);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button5.Location = new System.Drawing.Point(10, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 15);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcARDiscountPrograms);
            this.bosGroupControl1.Location = new System.Drawing.Point(7, 106);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1139, 639);
            this.bosGroupControl1.TabIndex = 123;
            this.bosGroupControl1.Text = "Doanh sách chương trình chiết khấu";
            // 
            // fld_dgcARDiscountPrograms
            // 
            this.fld_dgcARDiscountPrograms.BOSComment = null;
            this.fld_dgcARDiscountPrograms.BOSDataMember = null;
            this.fld_dgcARDiscountPrograms.BOSDataSource = "ARDiscountPrograms";
            this.fld_dgcARDiscountPrograms.BOSDescription = null;
            this.fld_dgcARDiscountPrograms.BOSError = null;
            this.fld_dgcARDiscountPrograms.BOSFieldGroup = null;
            this.fld_dgcARDiscountPrograms.BOSFieldRelation = null;
            this.fld_dgcARDiscountPrograms.BOSGridType = null;
            this.fld_dgcARDiscountPrograms.BOSPrivilege = null;
            this.fld_dgcARDiscountPrograms.BOSPropertyName = null;
            this.fld_dgcARDiscountPrograms.CommodityType = "";
            this.fld_dgcARDiscountPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARDiscountPrograms.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcARDiscountPrograms.MenuManager = this.screenToolbar;
            this.fld_dgcARDiscountPrograms.Name = "fld_dgcARDiscountPrograms";
            this.fld_dgcARDiscountPrograms.PrintReport = false;
            this.fld_dgcARDiscountPrograms.Screen = null;
            this.fld_dgcARDiscountPrograms.Size = new System.Drawing.Size(1135, 617);
            this.fld_dgcARDiscountPrograms.TabIndex = 1;
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(394, 68);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(110, 21);
            this.fld_btnSearch.TabIndex = 7;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.Fld_btnSearch_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(20, 45);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 109;
            this.bosLabel2.Text = "Từ ngày";
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
            this.bosLabel6.Location = new System.Drawing.Point(20, 45);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 109;
            this.bosLabel6.Text = "Từ ngày";
            // 
            // fld_dteARDiscountProgramBeginDate
            // 
            this.fld_dteARDiscountProgramBeginDate.BOSComment = null;
            this.fld_dteARDiscountProgramBeginDate.BOSDataMember = "ARDiscountProgramBeginDate";
            this.fld_dteARDiscountProgramBeginDate.BOSDataSource = "ARDiscountPrograms";
            this.fld_dteARDiscountProgramBeginDate.BOSDescription = null;
            this.fld_dteARDiscountProgramBeginDate.BOSError = null;
            this.fld_dteARDiscountProgramBeginDate.BOSFieldGroup = null;
            this.fld_dteARDiscountProgramBeginDate.BOSFieldRelation = null;
            this.fld_dteARDiscountProgramBeginDate.BOSPrivilege = null;
            this.fld_dteARDiscountProgramBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteARDiscountProgramBeginDate.EditValue = null;
            this.fld_dteARDiscountProgramBeginDate.Location = new System.Drawing.Point(111, 42);
            this.fld_dteARDiscountProgramBeginDate.Name = "fld_dteARDiscountProgramBeginDate";
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDiscountProgramBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDiscountProgramBeginDate.Screen = null;
            this.fld_dteARDiscountProgramBeginDate.Size = new System.Drawing.Size(177, 20);
            this.fld_dteARDiscountProgramBeginDate.TabIndex = 4;
            this.fld_dteARDiscountProgramBeginDate.Tag = "DC";
            // 
            // fld_txtARDiscountProgramName
            // 
            this.fld_txtARDiscountProgramName.BOSComment = "";
            this.fld_txtARDiscountProgramName.BOSDataMember = "ARDiscountProgramName";
            this.fld_txtARDiscountProgramName.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramName.BOSDescription = null;
            this.fld_txtARDiscountProgramName.BOSError = "";
            this.fld_txtARDiscountProgramName.BOSFieldGroup = "";
            this.fld_txtARDiscountProgramName.BOSFieldRelation = "";
            this.fld_txtARDiscountProgramName.BOSPrivilege = "";
            this.fld_txtARDiscountProgramName.BOSPropertyName = "Text";
            this.fld_txtARDiscountProgramName.Location = new System.Drawing.Point(394, 14);
            this.fld_txtARDiscountProgramName.Name = "fld_txtARDiscountProgramName";
            this.fld_txtARDiscountProgramName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDiscountProgramName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDiscountProgramName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDiscountProgramName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDiscountProgramName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDiscountProgramName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDiscountProgramName.Screen = null;
            this.fld_txtARDiscountProgramName.Size = new System.Drawing.Size(177, 20);
            this.fld_txtARDiscountProgramName.TabIndex = 1;
            this.fld_txtARDiscountProgramName.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(304, 45);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(47, 13);
            this.bosLabel8.TabIndex = 111;
            this.bosLabel8.Text = "Đến ngày";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARDiscountPrograms";
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
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(111, 68);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(177, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 3;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // fld_dteARDiscountProgramEndDate
            // 
            this.fld_dteARDiscountProgramEndDate.BOSComment = null;
            this.fld_dteARDiscountProgramEndDate.BOSDataMember = "ARDiscountProgramEndDate";
            this.fld_dteARDiscountProgramEndDate.BOSDataSource = "ARDiscountPrograms";
            this.fld_dteARDiscountProgramEndDate.BOSDescription = null;
            this.fld_dteARDiscountProgramEndDate.BOSError = null;
            this.fld_dteARDiscountProgramEndDate.BOSFieldGroup = null;
            this.fld_dteARDiscountProgramEndDate.BOSFieldRelation = null;
            this.fld_dteARDiscountProgramEndDate.BOSPrivilege = null;
            this.fld_dteARDiscountProgramEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARDiscountProgramEndDate.EditValue = null;
            this.fld_dteARDiscountProgramEndDate.Location = new System.Drawing.Point(394, 42);
            this.fld_dteARDiscountProgramEndDate.Name = "fld_dteARDiscountProgramEndDate";
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDiscountProgramEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDiscountProgramEndDate.Screen = null;
            this.fld_dteARDiscountProgramEndDate.Size = new System.Drawing.Size(177, 20);
            this.fld_dteARDiscountProgramEndDate.TabIndex = 5;
            this.fld_dteARDiscountProgramEndDate.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(20, 72);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 106;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(304, 17);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(82, 13);
            this.bosLabel3.TabIndex = 120;
            this.bosLabel3.Text = "Tên chương trình";
            // 
            // fld_tabCalculateDiscounts
            // 
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosTabControl1);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_groupDiscountProgram);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_lkeARCalculateDiscountType);
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosLabel9);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_lkeARCalculateDiscountStatus);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_lblLabel2);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_btnReLoadSales);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_btnApprove);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_lblBRPOSDate);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_btnSave);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_dteARCalculateDiscountDate);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_btnLoadSalesTarget);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_medARCalculateDiscountDesc);
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosLabel13);
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosLabel4);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_txtARCalculateDiscountName);
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosLabel1);
            this.fld_tabCalculateDiscounts.Controls.Add(this.bosLabel5);
            this.fld_tabCalculateDiscounts.Controls.Add(this.fld_txtARCalculateDiscountNo);
            this.fld_tabCalculateDiscounts.Name = "fld_tabCalculateDiscounts";
            this.fld_tabCalculateDiscounts.PageVisible = false;
            this.fld_tabCalculateDiscounts.Size = new System.Drawing.Size(1147, 741);
            this.fld_tabCalculateDiscounts.Text = "Danh sách đối tượng đạt doanh số";
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
            this.bosTabControl1.Location = new System.Drawing.Point(5, 150);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1130, 579);
            this.bosTabControl1.TabIndex = 164;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARCalculateDiscountItems);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1124, 551);
            this.xtraTabPage2.Text = "Doanh sách doanh số theo đối tượng";
            // 
            // fld_dgcARCalculateDiscountItems
            // 
            this.fld_dgcARCalculateDiscountItems.BOSComment = null;
            this.fld_dgcARCalculateDiscountItems.BOSDataMember = null;
            this.fld_dgcARCalculateDiscountItems.BOSDataSource = "ARCalculateDiscountItems";
            this.fld_dgcARCalculateDiscountItems.BOSDescription = null;
            this.fld_dgcARCalculateDiscountItems.BOSError = null;
            this.fld_dgcARCalculateDiscountItems.BOSFieldGroup = null;
            this.fld_dgcARCalculateDiscountItems.BOSFieldRelation = null;
            this.fld_dgcARCalculateDiscountItems.BOSGridType = null;
            this.fld_dgcARCalculateDiscountItems.BOSPrivilege = null;
            this.fld_dgcARCalculateDiscountItems.BOSPropertyName = null;
            this.fld_dgcARCalculateDiscountItems.CommodityType = "";
            this.fld_dgcARCalculateDiscountItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARCalculateDiscountItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARCalculateDiscountItems.MenuManager = this.screenToolbar;
            this.fld_dgcARCalculateDiscountItems.Name = "fld_dgcARCalculateDiscountItems";
            this.fld_dgcARCalculateDiscountItems.PrintReport = false;
            this.fld_dgcARCalculateDiscountItems.Screen = null;
            this.fld_dgcARCalculateDiscountItems.Size = new System.Drawing.Size(1124, 551);
            this.fld_dgcARCalculateDiscountItems.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1124, 551);
            this.xtraTabPage3.Text = "Hoạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1124, 551);
            this.fld_dgcACDocumentEntrys.TabIndex = 2;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
            // 
            // fld_groupDiscountProgram
            // 
            this.fld_groupDiscountProgram.Controls.Add(this.fld_lkeFK_ARDiscountProgramID);
            this.fld_groupDiscountProgram.Controls.Add(this.bosLabel12);
            this.fld_groupDiscountProgram.Controls.Add(this.fld_lkeFK_ARCustomerDistributionChannelID2);
            this.fld_groupDiscountProgram.Controls.Add(this.bosLabel10);
            this.fld_groupDiscountProgram.Controls.Add(this.fld_lkeACObjectAccessKey2);
            this.fld_groupDiscountProgram.Controls.Add(this.bosLabel11);
            this.fld_groupDiscountProgram.Location = new System.Drawing.Point(526, 13);
            this.fld_groupDiscountProgram.Name = "fld_groupDiscountProgram";
            this.fld_groupDiscountProgram.Size = new System.Drawing.Size(266, 118);
            this.fld_groupDiscountProgram.TabIndex = 163;
            this.fld_groupDiscountProgram.Text = "Thông tin chương trình chiết khấu";
            // 
            // fld_lkeFK_ARDiscountProgramID
            // 
            this.fld_lkeFK_ARDiscountProgramID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARDiscountProgramID.BOSAllowDummy = true;
            this.fld_lkeFK_ARDiscountProgramID.BOSComment = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSDataMember = "FK_ARDiscountProgramID";
            this.fld_lkeFK_ARDiscountProgramID.BOSDataSource = "ARCalculateDiscounts";
            this.fld_lkeFK_ARDiscountProgramID.BOSDescription = null;
            this.fld_lkeFK_ARDiscountProgramID.BOSError = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSFieldGroup = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSFieldParent = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSFieldRelation = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSPrivilege = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARDiscountProgramID.BOSSelectType = "";
            this.fld_lkeFK_ARDiscountProgramID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARDiscountProgramID.CurrentDisplayText = "";
            this.fld_lkeFK_ARDiscountProgramID.Enabled = false;
            this.fld_lkeFK_ARDiscountProgramID.Location = new System.Drawing.Point(97, 26);
            this.fld_lkeFK_ARDiscountProgramID.Name = "fld_lkeFK_ARDiscountProgramID";
            this.fld_lkeFK_ARDiscountProgramID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.fld_lkeFK_ARDiscountProgramID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARDiscountProgramID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARDiscountProgramID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARDiscountProgramID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARDiscountProgramID.Properties.ColumnName = null;
            this.fld_lkeFK_ARDiscountProgramID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDiscountProgramName", "Tên chương trình")});
            this.fld_lkeFK_ARDiscountProgramID.Properties.DisplayMember = "ARDiscountProgramName";
            this.fld_lkeFK_ARDiscountProgramID.Properties.NullText = "";
            this.fld_lkeFK_ARDiscountProgramID.Properties.ReadOnly = true;
            this.fld_lkeFK_ARDiscountProgramID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARDiscountProgramID.Properties.ValueMember = "ARDiscountProgramID";
            this.fld_lkeFK_ARDiscountProgramID.Screen = null;
            this.fld_lkeFK_ARDiscountProgramID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARDiscountProgramID.TabIndex = 0;
            this.fld_lkeFK_ARDiscountProgramID.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(15, 29);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(26, 13);
            this.bosLabel12.TabIndex = 161;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "CTCK";
            // 
            // fld_lkeFK_ARCustomerDistributionChannelID2
            // 
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSComment = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSDataMember = "FK_ARCustomerDistributionChannelID";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSDataSource = "ARCalculateDiscounts";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSDescription = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSError = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Enabled = false;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Location = new System.Drawing.Point(97, 52);
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Name = "fld_lkeFK_ARCustomerDistributionChannelID2";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerDistributionChannelName", "Kệnh phân phối")});
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.DisplayMember = "ARCustomerDistributionChannelName";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.ReadOnly = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties.ValueMember = "ARCustomerDistributionChannelID";
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Screen = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerDistributionChannelID2.TabIndex = 1;
            this.fld_lkeFK_ARCustomerDistributionChannelID2.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel10.Location = new System.Drawing.Point(15, 55);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(74, 13);
            this.bosLabel10.TabIndex = 158;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Kênh phân phối";
            // 
            // fld_lkeACObjectAccessKey2
            // 
            this.fld_lkeACObjectAccessKey2.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey2.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey2.BOSComment = "";
            this.fld_lkeACObjectAccessKey2.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey2.BOSDataSource = "ARCalculateDiscounts";
            this.fld_lkeACObjectAccessKey2.BOSDescription = null;
            this.fld_lkeACObjectAccessKey2.BOSError = null;
            this.fld_lkeACObjectAccessKey2.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey2.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey2.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey2.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey2.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey2.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey2.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey2.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey2.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey2.Enabled = false;
            this.fld_lkeACObjectAccessKey2.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey2.Location = new System.Drawing.Point(97, 78);
            this.fld_lkeACObjectAccessKey2.Name = "fld_lkeACObjectAccessKey2";
            this.fld_lkeACObjectAccessKey2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.fld_lkeACObjectAccessKey2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey2.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeACObjectAccessKey2.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey2.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey2.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey2.Properties.ReadOnly = true;
            this.fld_lkeACObjectAccessKey2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey2.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey2.Screen = null;
            this.fld_lkeACObjectAccessKey2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey2.TabIndex = 2;
            this.fld_lkeACObjectAccessKey2.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(15, 81);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 160;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Đối tượng";
            // 
            // fld_lkeARCalculateDiscountType
            // 
            this.fld_lkeARCalculateDiscountType.BOSAllowAddNew = false;
            this.fld_lkeARCalculateDiscountType.BOSAllowDummy = false;
            this.fld_lkeARCalculateDiscountType.BOSComment = null;
            this.fld_lkeARCalculateDiscountType.BOSDataMember = "ARCalculateDiscountType";
            this.fld_lkeARCalculateDiscountType.BOSDataSource = "ARCalculateDiscounts";
            this.fld_lkeARCalculateDiscountType.BOSDescription = null;
            this.fld_lkeARCalculateDiscountType.BOSError = null;
            this.fld_lkeARCalculateDiscountType.BOSFieldGroup = null;
            this.fld_lkeARCalculateDiscountType.BOSFieldParent = null;
            this.fld_lkeARCalculateDiscountType.BOSFieldRelation = null;
            this.fld_lkeARCalculateDiscountType.BOSPrivilege = null;
            this.fld_lkeARCalculateDiscountType.BOSPropertyName = "EditValue";
            this.fld_lkeARCalculateDiscountType.BOSSelectType = null;
            this.fld_lkeARCalculateDiscountType.BOSSelectTypeValue = null;
            this.fld_lkeARCalculateDiscountType.CurrentDisplayText = null;
            this.fld_lkeARCalculateDiscountType.Location = new System.Drawing.Point(100, 36);
            this.fld_lkeARCalculateDiscountType.MenuManager = this.screenToolbar;
            this.fld_lkeARCalculateDiscountType.Name = "fld_lkeARCalculateDiscountType";
            this.fld_lkeARCalculateDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCalculateDiscountType.Properties.ColumnName = null;
            this.fld_lkeARCalculateDiscountType.Properties.NullText = "";
            this.fld_lkeARCalculateDiscountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCalculateDiscountType.Screen = null;
            this.fld_lkeARCalculateDiscountType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCalculateDiscountType.TabIndex = 2;
            this.fld_lkeARCalculateDiscountType.Tag = "DC";
            this.fld_lkeARCalculateDiscountType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARCalculateDiscountType_CloseUp);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
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
            this.bosLabel9.Location = new System.Drawing.Point(17, 39);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(59, 13);
            this.bosLabel9.TabIndex = 162;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Doanh số kỳ";
            // 
            // fld_lkeARCalculateDiscountStatus
            // 
            this.fld_lkeARCalculateDiscountStatus.BOSAllowAddNew = false;
            this.fld_lkeARCalculateDiscountStatus.BOSAllowDummy = false;
            this.fld_lkeARCalculateDiscountStatus.BOSComment = null;
            this.fld_lkeARCalculateDiscountStatus.BOSDataMember = "ARCalculateDiscountStatus";
            this.fld_lkeARCalculateDiscountStatus.BOSDataSource = "ARCalculateDiscounts";
            this.fld_lkeARCalculateDiscountStatus.BOSDescription = null;
            this.fld_lkeARCalculateDiscountStatus.BOSError = null;
            this.fld_lkeARCalculateDiscountStatus.BOSFieldGroup = null;
            this.fld_lkeARCalculateDiscountStatus.BOSFieldParent = null;
            this.fld_lkeARCalculateDiscountStatus.BOSFieldRelation = null;
            this.fld_lkeARCalculateDiscountStatus.BOSPrivilege = null;
            this.fld_lkeARCalculateDiscountStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARCalculateDiscountStatus.BOSSelectType = null;
            this.fld_lkeARCalculateDiscountStatus.BOSSelectTypeValue = null;
            this.fld_lkeARCalculateDiscountStatus.CurrentDisplayText = null;
            this.fld_lkeARCalculateDiscountStatus.Location = new System.Drawing.Point(361, 10);
            this.fld_lkeARCalculateDiscountStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARCalculateDiscountStatus.Name = "fld_lkeARCalculateDiscountStatus";
            this.fld_lkeARCalculateDiscountStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCalculateDiscountStatus.Properties.ColumnName = null;
            this.fld_lkeARCalculateDiscountStatus.Properties.NullText = "";
            this.fld_lkeARCalculateDiscountStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCalculateDiscountStatus.Screen = null;
            this.fld_lkeARCalculateDiscountStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCalculateDiscountStatus.TabIndex = 1;
            this.fld_lkeARCalculateDiscountStatus.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(270, 13);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel2.TabIndex = 156;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Tình trạng";
            // 
            // fld_btnReLoadSales
            // 
            this.fld_btnReLoadSales.BOSComment = null;
            this.fld_btnReLoadSales.BOSDataMember = null;
            this.fld_btnReLoadSales.BOSDataSource = null;
            this.fld_btnReLoadSales.BOSDescription = null;
            this.fld_btnReLoadSales.BOSError = null;
            this.fld_btnReLoadSales.BOSFieldGroup = null;
            this.fld_btnReLoadSales.BOSFieldRelation = null;
            this.fld_btnReLoadSales.BOSPrivilege = null;
            this.fld_btnReLoadSales.BOSPropertyName = null;
            this.fld_btnReLoadSales.Enabled = false;
            this.fld_btnReLoadSales.Location = new System.Drawing.Point(809, 44);
            this.fld_btnReLoadSales.Name = "fld_btnReLoadSales";
            this.fld_btnReLoadSales.Screen = null;
            this.fld_btnReLoadSales.Size = new System.Drawing.Size(101, 25);
            this.fld_btnReLoadSales.TabIndex = 7;
            this.fld_btnReLoadSales.Text = "Cập nhật";
            this.fld_btnReLoadSales.Click += new System.EventHandler(this.fld_btnReLoadSales_Click);
            // 
            // fld_btnApprove
            // 
            this.fld_btnApprove.BOSComment = null;
            this.fld_btnApprove.BOSDataMember = null;
            this.fld_btnApprove.BOSDataSource = null;
            this.fld_btnApprove.BOSDescription = null;
            this.fld_btnApprove.BOSError = null;
            this.fld_btnApprove.BOSFieldGroup = null;
            this.fld_btnApprove.BOSFieldRelation = null;
            this.fld_btnApprove.BOSPrivilege = null;
            this.fld_btnApprove.BOSPropertyName = null;
            this.fld_btnApprove.Enabled = false;
            this.fld_btnApprove.Location = new System.Drawing.Point(809, 106);
            this.fld_btnApprove.Name = "fld_btnApprove";
            this.fld_btnApprove.Screen = null;
            this.fld_btnApprove.Size = new System.Drawing.Size(101, 25);
            this.fld_btnApprove.TabIndex = 9;
            this.fld_btnApprove.Text = "Duyệt";
            this.fld_btnApprove.Click += new System.EventHandler(this.Fld_btnApprove_Click);
            // 
            // fld_lblBRPOSDate
            // 
            this.fld_lblBRPOSDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblBRPOSDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_lblBRPOSDate.Appearance.Options.UseBackColor = true;
            this.fld_lblBRPOSDate.Appearance.Options.UseForeColor = true;
            this.fld_lblBRPOSDate.BOSComment = "";
            this.fld_lblBRPOSDate.BOSDataMember = "";
            this.fld_lblBRPOSDate.BOSDataSource = "";
            this.fld_lblBRPOSDate.BOSDescription = null;
            this.fld_lblBRPOSDate.BOSError = null;
            this.fld_lblBRPOSDate.BOSFieldGroup = "";
            this.fld_lblBRPOSDate.BOSFieldRelation = "";
            this.fld_lblBRPOSDate.BOSPrivilege = "";
            this.fld_lblBRPOSDate.BOSPropertyName = null;
            this.fld_lblBRPOSDate.Location = new System.Drawing.Point(270, 39);
            this.fld_lblBRPOSDate.Name = "fld_lblBRPOSDate";
            this.fld_lblBRPOSDate.Screen = null;
            this.fld_lblBRPOSDate.Size = new System.Drawing.Size(72, 13);
            this.fld_lblBRPOSDate.TabIndex = 126;
            this.fld_lblBRPOSDate.Tag = "";
            this.fld_lblBRPOSDate.Text = "Ngày chứng từ";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Enabled = false;
            this.fld_btnSave.Location = new System.Drawing.Point(809, 75);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(101, 25);
            this.fld_btnSave.TabIndex = 8;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.Fld_btnSave_Click);
            // 
            // fld_dteARCalculateDiscountDate
            // 
            this.fld_dteARCalculateDiscountDate.BOSComment = null;
            this.fld_dteARCalculateDiscountDate.BOSDataMember = "ARCalculateDiscountDate";
            this.fld_dteARCalculateDiscountDate.BOSDataSource = "ARCalculateDiscounts";
            this.fld_dteARCalculateDiscountDate.BOSDescription = null;
            this.fld_dteARCalculateDiscountDate.BOSError = null;
            this.fld_dteARCalculateDiscountDate.BOSFieldGroup = null;
            this.fld_dteARCalculateDiscountDate.BOSFieldRelation = null;
            this.fld_dteARCalculateDiscountDate.BOSPrivilege = null;
            this.fld_dteARCalculateDiscountDate.BOSPropertyName = "EditValue";
            this.fld_dteARCalculateDiscountDate.EditValue = null;
            this.fld_dteARCalculateDiscountDate.Location = new System.Drawing.Point(361, 36);
            this.fld_dteARCalculateDiscountDate.MenuManager = this.screenToolbar;
            this.fld_dteARCalculateDiscountDate.Name = "fld_dteARCalculateDiscountDate";
            this.fld_dteARCalculateDiscountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCalculateDiscountDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCalculateDiscountDate.Screen = null;
            this.fld_dteARCalculateDiscountDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARCalculateDiscountDate.TabIndex = 3;
            this.fld_dteARCalculateDiscountDate.Tag = "DC";
            // 
            // fld_btnLoadSalesTarget
            // 
            this.fld_btnLoadSalesTarget.BOSComment = null;
            this.fld_btnLoadSalesTarget.BOSDataMember = null;
            this.fld_btnLoadSalesTarget.BOSDataSource = null;
            this.fld_btnLoadSalesTarget.BOSDescription = null;
            this.fld_btnLoadSalesTarget.BOSError = null;
            this.fld_btnLoadSalesTarget.BOSFieldGroup = null;
            this.fld_btnLoadSalesTarget.BOSFieldRelation = null;
            this.fld_btnLoadSalesTarget.BOSPrivilege = null;
            this.fld_btnLoadSalesTarget.BOSPropertyName = null;
            this.fld_btnLoadSalesTarget.Enabled = false;
            this.fld_btnLoadSalesTarget.Location = new System.Drawing.Point(809, 13);
            this.fld_btnLoadSalesTarget.Name = "fld_btnLoadSalesTarget";
            this.fld_btnLoadSalesTarget.Screen = null;
            this.fld_btnLoadSalesTarget.Size = new System.Drawing.Size(101, 25);
            this.fld_btnLoadSalesTarget.TabIndex = 6;
            this.fld_btnLoadSalesTarget.Text = "Load doanh số";
            this.fld_btnLoadSalesTarget.Click += new System.EventHandler(this.Fld_btnLoadSalesTarget_Click);
            // 
            // fld_medARCalculateDiscountDesc
            // 
            this.fld_medARCalculateDiscountDesc.BOSComment = "";
            this.fld_medARCalculateDiscountDesc.BOSDataMember = "ARCalculateDiscountDesc";
            this.fld_medARCalculateDiscountDesc.BOSDataSource = "ARCalculateDiscounts";
            this.fld_medARCalculateDiscountDesc.BOSDescription = null;
            this.fld_medARCalculateDiscountDesc.BOSError = "";
            this.fld_medARCalculateDiscountDesc.BOSFieldGroup = "";
            this.fld_medARCalculateDiscountDesc.BOSFieldRelation = "";
            this.fld_medARCalculateDiscountDesc.BOSPrivilege = "";
            this.fld_medARCalculateDiscountDesc.BOSPropertyName = "Text";
            this.fld_medARCalculateDiscountDesc.Location = new System.Drawing.Point(100, 88);
            this.fld_medARCalculateDiscountDesc.Name = "fld_medARCalculateDiscountDesc";
            this.fld_medARCalculateDiscountDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCalculateDiscountDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCalculateDiscountDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCalculateDiscountDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCalculateDiscountDesc.Screen = null;
            this.fld_medARCalculateDiscountDesc.Size = new System.Drawing.Size(411, 41);
            this.fld_medARCalculateDiscountDesc.TabIndex = 5;
            this.fld_medARCalculateDiscountDesc.Tag = "DC";
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
            this.bosLabel13.Location = new System.Drawing.Point(17, 87);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(27, 13);
            this.bosLabel13.TabIndex = 123;
            this.bosLabel13.Text = "Mô tả";
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
            this.bosLabel4.Location = new System.Drawing.Point(17, 89);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(27, 13);
            this.bosLabel4.TabIndex = 123;
            this.bosLabel4.Text = "Mô tả";
            // 
            // fld_txtARCalculateDiscountName
            // 
            this.fld_txtARCalculateDiscountName.BOSComment = "";
            this.fld_txtARCalculateDiscountName.BOSDataMember = "ARCalculateDiscountName";
            this.fld_txtARCalculateDiscountName.BOSDataSource = "ARCalculateDiscounts";
            this.fld_txtARCalculateDiscountName.BOSDescription = null;
            this.fld_txtARCalculateDiscountName.BOSError = "";
            this.fld_txtARCalculateDiscountName.BOSFieldGroup = "";
            this.fld_txtARCalculateDiscountName.BOSFieldRelation = "";
            this.fld_txtARCalculateDiscountName.BOSPrivilege = "";
            this.fld_txtARCalculateDiscountName.BOSPropertyName = "Text";
            this.fld_txtARCalculateDiscountName.Location = new System.Drawing.Point(100, 62);
            this.fld_txtARCalculateDiscountName.Name = "fld_txtARCalculateDiscountName";
            this.fld_txtARCalculateDiscountName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCalculateDiscountName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCalculateDiscountName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCalculateDiscountName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCalculateDiscountName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCalculateDiscountName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCalculateDiscountName.Screen = null;
            this.fld_txtARCalculateDiscountName.Size = new System.Drawing.Size(411, 20);
            this.fld_txtARCalculateDiscountName.TabIndex = 4;
            this.fld_txtARCalculateDiscountName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(17, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 95;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel5.Location = new System.Drawing.Point(17, 65);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(65, 13);
            this.bosLabel5.TabIndex = 122;
            this.bosLabel5.Text = "Tên chứng từ";
            // 
            // fld_txtARCalculateDiscountNo
            // 
            this.fld_txtARCalculateDiscountNo.BOSComment = null;
            this.fld_txtARCalculateDiscountNo.BOSDataMember = "ARCalculateDiscountNo";
            this.fld_txtARCalculateDiscountNo.BOSDataSource = "ARCalculateDiscounts";
            this.fld_txtARCalculateDiscountNo.BOSDescription = null;
            this.fld_txtARCalculateDiscountNo.BOSError = null;
            this.fld_txtARCalculateDiscountNo.BOSFieldGroup = null;
            this.fld_txtARCalculateDiscountNo.BOSFieldRelation = null;
            this.fld_txtARCalculateDiscountNo.BOSPrivilege = null;
            this.fld_txtARCalculateDiscountNo.BOSPropertyName = "EditValue";
            this.fld_txtARCalculateDiscountNo.Location = new System.Drawing.Point(100, 10);
            this.fld_txtARCalculateDiscountNo.MenuManager = this.screenToolbar;
            this.fld_txtARCalculateDiscountNo.Name = "fld_txtARCalculateDiscountNo";
            this.fld_txtARCalculateDiscountNo.Screen = null;
            this.fld_txtARCalculateDiscountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCalculateDiscountNo.TabIndex = 0;
            this.fld_txtARCalculateDiscountNo.Tag = "DC";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMDCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1159, 776);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDCT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCalculateDiscount)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabcCalDiscount)).EndInit();
            this.fld_tabcCalDiscount.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties)).EndInit();
            this.fld_tabCalculateDiscounts.ResumeLayout(false);
            this.fld_tabCalculateDiscounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCalculateDiscountItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_groupDiscountProgram)).EndInit();
            this.fld_groupDiscountProgram.ResumeLayout(false);
            this.fld_groupDiscountProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDiscountProgramID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerDistributionChannelID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCalculateDiscountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCalculateDiscountStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCalculateDiscountDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCalculateDiscountDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCalculateDiscountDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCalculateDiscountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCalculateDiscountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private BOSComponent.BOSTextBox fld_txtARDiscountProgramNo;
        private BOSComponent.BOSLabel bosLabel7;
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCalculateDiscount;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSDateEdit fld_dteARDiscountProgramBeginDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteARDiscountProgramEndDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtARDiscountProgramName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSTabControl fld_tabcCalDiscount;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel2;
        private ARDiscountProgramsGridControl fld_dgcARDiscountPrograms;
        private DevExpress.XtraTab.XtraTabPage fld_tabCalculateDiscounts;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSLabel bosLabel40;
        private BOSComponent.BOSLabel bosLabel39;
        private Button button4;
        private Button button2;
        private Button button5;
        private BOSComponent.BOSButton fld_btnApprove;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnLoadSalesTarget;
        private BOSComponent.BOSButton fld_btnReLoadSales;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCalculateDiscountNo;
        private BOSComponent.BOSTextBox fld_txtARCalculateDiscountName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSMemoEdit fld_medARCalculateDiscountDesc;
        private BOSComponent.BOSLabel fld_lblBRPOSDate;
        private BOSComponent.BOSDateEdit fld_dteARCalculateDiscountDate;
        private BOSComponent.BOSLookupEdit fld_lkeARCalculateDiscountStatus;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerDistributionChannelID2;
        private BOSComponent.BOSLabel bosLabel10;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey2;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeARCalculateDiscountType;
        private BOSComponent.BOSLabel bosLabel9;
        private DevExpress.XtraEditors.GroupControl fld_groupDiscountProgram;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARDiscountProgramID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ARCalculateDiscountItemsGridControl fld_dgcARCalculateDiscountItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
    }
}
