using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.JobTicket.UI
{
	/// <summary>
	/// Summary description for DMJT100
	/// </summary>
	partial class DMJT100
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
            this.fld_lblStatusLate = new BOSComponent.BOSLabel(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblStatusAlittleReceipt = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMJobTicketItems = new BOSERP.Modules.JobTicket.MMJobTicketItemsGridControl();
            this.fld_btnStatusLate = new System.Windows.Forms.Button();
            this.fld_btnStatusAlittleReceipt = new System.Windows.Forms.Button();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnTUpdateEmployee = new BOSComponent.BOSButton(this.components);
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_chkStatusClosed = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusCanceled = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusNew = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkStatusApproved = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblSelectAll = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCloseTicket = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnApprove = new BOSComponent.BOSButton(this.components);
            this.fld_btnCapacityReceipt = new BOSComponent.BOSButton(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dteMMJobTicketFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMJobTicketToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnLoadDetailPlan = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtMMJobTicketName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMJobTicketNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteMMJobTicketDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMJobTicketDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvMMJobTicketItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMJobTicketItems)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusClosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusCanceled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusApproved.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketToDate.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMJobTicketDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMJobTicketItems)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lblStatusLate);
            this.bosPanel1.Controls.Add(this.fld_chkSelectAll);
            this.bosPanel1.Controls.Add(this.fld_lblStatusAlittleReceipt);
            this.bosPanel1.Controls.Add(this.fld_dgcMMJobTicketItems);
            this.bosPanel1.Controls.Add(this.fld_btnStatusLate);
            this.bosPanel1.Controls.Add(this.fld_btnStatusAlittleReceipt);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1035, 562);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lblStatusLate
            // 
            this.fld_lblStatusLate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_lblStatusLate.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.fld_lblStatusLate.Appearance.Options.UseFont = true;
            this.fld_lblStatusLate.BOSComment = null;
            this.fld_lblStatusLate.BOSDataMember = null;
            this.fld_lblStatusLate.BOSDataSource = null;
            this.fld_lblStatusLate.BOSDescription = null;
            this.fld_lblStatusLate.BOSError = null;
            this.fld_lblStatusLate.BOSFieldGroup = null;
            this.fld_lblStatusLate.BOSFieldRelation = null;
            this.fld_lblStatusLate.BOSPrivilege = null;
            this.fld_lblStatusLate.BOSPropertyName = null;
            this.fld_lblStatusLate.Location = new System.Drawing.Point(141, 541);
            this.fld_lblStatusLate.Name = "fld_lblStatusLate";
            this.fld_lblStatusLate.Screen = null;
            this.fld_lblStatusLate.Size = new System.Drawing.Size(55, 11);
            this.fld_lblStatusLate.TabIndex = 32;
            this.fld_lblStatusLate.Text = "Trễ tiến độ";
            // 
            // fld_chkSelectAll
            // 
            this.fld_chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectAll.BOSComment = null;
            this.fld_chkSelectAll.BOSDataMember = null;
            this.fld_chkSelectAll.BOSDataSource = null;
            this.fld_chkSelectAll.BOSDescription = null;
            this.fld_chkSelectAll.BOSError = null;
            this.fld_chkSelectAll.BOSFieldGroup = null;
            this.fld_chkSelectAll.BOSFieldRelation = null;
            this.fld_chkSelectAll.BOSPrivilege = null;
            this.fld_chkSelectAll.BOSPropertyName = null;
            this.fld_chkSelectAll.Location = new System.Drawing.Point(3, 536);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(86, 19);
            this.fld_chkSelectAll.TabIndex = 121;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // fld_lblStatusAlittleReceipt
            // 
            this.fld_lblStatusAlittleReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_lblStatusAlittleReceipt.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.fld_lblStatusAlittleReceipt.Appearance.Options.UseFont = true;
            this.fld_lblStatusAlittleReceipt.BOSComment = null;
            this.fld_lblStatusAlittleReceipt.BOSDataMember = null;
            this.fld_lblStatusAlittleReceipt.BOSDataSource = null;
            this.fld_lblStatusAlittleReceipt.BOSDescription = null;
            this.fld_lblStatusAlittleReceipt.BOSError = null;
            this.fld_lblStatusAlittleReceipt.BOSFieldGroup = null;
            this.fld_lblStatusAlittleReceipt.BOSFieldRelation = null;
            this.fld_lblStatusAlittleReceipt.BOSPrivilege = null;
            this.fld_lblStatusAlittleReceipt.BOSPropertyName = null;
            this.fld_lblStatusAlittleReceipt.Location = new System.Drawing.Point(237, 540);
            this.fld_lblStatusAlittleReceipt.Name = "fld_lblStatusAlittleReceipt";
            this.fld_lblStatusAlittleReceipt.Screen = null;
            this.fld_lblStatusAlittleReceipt.Size = new System.Drawing.Size(40, 11);
            this.fld_lblStatusAlittleReceipt.TabIndex = 31;
            this.fld_lblStatusAlittleReceipt.Text = "Đã nhập";
            // 
            // fld_dgcMMJobTicketItems
            // 
            this.fld_dgcMMJobTicketItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMJobTicketItems.BOSComment = null;
            this.fld_dgcMMJobTicketItems.BOSDataMember = null;
            this.fld_dgcMMJobTicketItems.BOSDataSource = "MMJobTicketItems";
            this.fld_dgcMMJobTicketItems.BOSDescription = null;
            this.fld_dgcMMJobTicketItems.BOSError = null;
            this.fld_dgcMMJobTicketItems.BOSFieldGroup = null;
            this.fld_dgcMMJobTicketItems.BOSFieldRelation = null;
            this.fld_dgcMMJobTicketItems.BOSGridType = null;
            this.fld_dgcMMJobTicketItems.BOSPrivilege = null;
            this.fld_dgcMMJobTicketItems.BOSPropertyName = null;
            this.fld_dgcMMJobTicketItems.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMJobTicketItems.Location = new System.Drawing.Point(0, 172);
            this.fld_dgcMMJobTicketItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMJobTicketItems.Name = "fld_dgcMMJobTicketItems";
            this.fld_dgcMMJobTicketItems.PrintReport = false;
            this.fld_dgcMMJobTicketItems.Screen = null;
            this.fld_dgcMMJobTicketItems.Size = new System.Drawing.Size(1035, 358);
            this.fld_dgcMMJobTicketItems.TabIndex = 120;
            // 
            // fld_btnStatusLate
            // 
            this.fld_btnStatusLate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnStatusLate.BackColor = System.Drawing.Color.Red;
            this.fld_btnStatusLate.Enabled = false;
            this.fld_btnStatusLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fld_btnStatusLate.Font = new System.Drawing.Font("Tahoma", 7F);
            this.fld_btnStatusLate.Location = new System.Drawing.Point(115, 538);
            this.fld_btnStatusLate.Name = "fld_btnStatusLate";
            this.fld_btnStatusLate.Size = new System.Drawing.Size(20, 15);
            this.fld_btnStatusLate.TabIndex = 28;
            this.fld_btnStatusLate.UseVisualStyleBackColor = false;
            // 
            // fld_btnStatusAlittleReceipt
            // 
            this.fld_btnStatusAlittleReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnStatusAlittleReceipt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.fld_btnStatusAlittleReceipt.Enabled = false;
            this.fld_btnStatusAlittleReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fld_btnStatusAlittleReceipt.Font = new System.Drawing.Font("Tahoma", 7F);
            this.fld_btnStatusAlittleReceipt.Location = new System.Drawing.Point(211, 538);
            this.fld_btnStatusAlittleReceipt.Name = "fld_btnStatusAlittleReceipt";
            this.fld_btnStatusAlittleReceipt.Size = new System.Drawing.Size(20, 15);
            this.fld_btnStatusAlittleReceipt.TabIndex = 27;
            this.fld_btnStatusAlittleReceipt.UseVisualStyleBackColor = false;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_btnTUpdateEmployee);
            this.bosPanel2.Controls.Add(this.bosLine6);
            this.bosPanel2.Controls.Add(this.bosLine3);
            this.bosPanel2.Controls.Add(this.bosLine2);
            this.bosPanel2.Controls.Add(this.fld_btnLoadDetailPlan);
            this.bosPanel2.Controls.Add(this.bosLine1);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1035, 169);
            this.bosPanel2.TabIndex = 119;
            // 
            // fld_btnTUpdateEmployee
            // 
            this.fld_btnTUpdateEmployee.Appearance.Options.UseTextOptions = true;
            this.fld_btnTUpdateEmployee.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fld_btnTUpdateEmployee.BOSComment = null;
            this.fld_btnTUpdateEmployee.BOSDataMember = null;
            this.fld_btnTUpdateEmployee.BOSDataSource = null;
            this.fld_btnTUpdateEmployee.BOSDescription = null;
            this.fld_btnTUpdateEmployee.BOSError = null;
            this.fld_btnTUpdateEmployee.BOSFieldGroup = null;
            this.fld_btnTUpdateEmployee.BOSFieldRelation = null;
            this.fld_btnTUpdateEmployee.BOSPrivilege = null;
            this.fld_btnTUpdateEmployee.BOSPropertyName = null;
            this.fld_btnTUpdateEmployee.Location = new System.Drawing.Point(954, 108);
            this.fld_btnTUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fld_btnTUpdateEmployee.Name = "fld_btnTUpdateEmployee";
            this.fld_btnTUpdateEmployee.Screen = null;
            this.fld_btnTUpdateEmployee.Size = new System.Drawing.Size(76, 42);
            this.fld_btnTUpdateEmployee.TabIndex = 123;
            this.fld_btnTUpdateEmployee.Text = "Cập nhật nhân công";
            this.fld_btnTUpdateEmployee.Click += new System.EventHandler(this.fld_btnTUpdateEmployee_Click);
            // 
            // bosLine6
            // 
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_chkStatusClosed);
            this.bosLine6.Controls.Add(this.fld_chkStatusCanceled);
            this.bosLine6.Controls.Add(this.fld_chkStatusNew);
            this.bosLine6.Controls.Add(this.fld_chkStatusApproved);
            this.bosLine6.Controls.Add(this.fld_lblSelectAll);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(99, 126);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(696, 39);
            this.bosLine6.TabIndex = 122;
            this.bosLine6.TabStop = false;
            // 
            // fld_chkStatusClosed
            // 
            this.fld_chkStatusClosed.BOSComment = null;
            this.fld_chkStatusClosed.BOSDataMember = null;
            this.fld_chkStatusClosed.BOSDataSource = null;
            this.fld_chkStatusClosed.BOSDescription = null;
            this.fld_chkStatusClosed.BOSError = null;
            this.fld_chkStatusClosed.BOSFieldGroup = null;
            this.fld_chkStatusClosed.BOSFieldRelation = null;
            this.fld_chkStatusClosed.BOSPrivilege = null;
            this.fld_chkStatusClosed.BOSPropertyName = null;
            this.fld_chkStatusClosed.Location = new System.Drawing.Point(192, 14);
            this.fld_chkStatusClosed.Name = "fld_chkStatusClosed";
            this.fld_chkStatusClosed.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fld_chkStatusClosed.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusClosed.Properties.Caption = "Đã đóng";
            this.fld_chkStatusClosed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusClosed.Screen = null;
            this.fld_chkStatusClosed.Size = new System.Drawing.Size(70, 19);
            this.fld_chkStatusClosed.TabIndex = 38;
            this.fld_chkStatusClosed.CheckedChanged += new System.EventHandler(this.fld_chkStatusClosed_CheckStateChanged);
            // 
            // fld_chkStatusCanceled
            // 
            this.fld_chkStatusCanceled.BOSComment = null;
            this.fld_chkStatusCanceled.BOSDataMember = null;
            this.fld_chkStatusCanceled.BOSDataSource = null;
            this.fld_chkStatusCanceled.BOSDescription = null;
            this.fld_chkStatusCanceled.BOSError = null;
            this.fld_chkStatusCanceled.BOSFieldGroup = null;
            this.fld_chkStatusCanceled.BOSFieldRelation = null;
            this.fld_chkStatusCanceled.BOSPrivilege = null;
            this.fld_chkStatusCanceled.BOSPropertyName = null;
            this.fld_chkStatusCanceled.Location = new System.Drawing.Point(280, 14);
            this.fld_chkStatusCanceled.Name = "fld_chkStatusCanceled";
            this.fld_chkStatusCanceled.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.fld_chkStatusCanceled.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusCanceled.Properties.Caption = "Đã hủy";
            this.fld_chkStatusCanceled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusCanceled.Screen = null;
            this.fld_chkStatusCanceled.Size = new System.Drawing.Size(70, 19);
            this.fld_chkStatusCanceled.TabIndex = 38;
            this.fld_chkStatusCanceled.CheckStateChanged += new System.EventHandler(this.fld_chkStatusCanceled_CheckStateChanged);
            // 
            // fld_chkStatusNew
            // 
            this.fld_chkStatusNew.BOSComment = null;
            this.fld_chkStatusNew.BOSDataMember = null;
            this.fld_chkStatusNew.BOSDataSource = null;
            this.fld_chkStatusNew.BOSDescription = null;
            this.fld_chkStatusNew.BOSError = null;
            this.fld_chkStatusNew.BOSFieldGroup = null;
            this.fld_chkStatusNew.BOSFieldRelation = null;
            this.fld_chkStatusNew.BOSPrivilege = null;
            this.fld_chkStatusNew.BOSPropertyName = null;
            this.fld_chkStatusNew.EditValue = true;
            this.fld_chkStatusNew.Location = new System.Drawing.Point(6, 14);
            this.fld_chkStatusNew.MenuManager = this.screenToolbar;
            this.fld_chkStatusNew.Name = "fld_chkStatusNew";
            this.fld_chkStatusNew.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_chkStatusNew.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusNew.Properties.Caption = "Tạo mới";
            this.fld_chkStatusNew.Screen = null;
            this.fld_chkStatusNew.Size = new System.Drawing.Size(76, 19);
            this.fld_chkStatusNew.TabIndex = 36;
            this.fld_chkStatusNew.CheckedChanged += new System.EventHandler(this.fld_chkStatusNew_CheckedChanged);
            // 
            // fld_chkStatusApproved
            // 
            this.fld_chkStatusApproved.BOSComment = null;
            this.fld_chkStatusApproved.BOSDataMember = null;
            this.fld_chkStatusApproved.BOSDataSource = null;
            this.fld_chkStatusApproved.BOSDescription = null;
            this.fld_chkStatusApproved.BOSError = null;
            this.fld_chkStatusApproved.BOSFieldGroup = null;
            this.fld_chkStatusApproved.BOSFieldRelation = null;
            this.fld_chkStatusApproved.BOSPrivilege = null;
            this.fld_chkStatusApproved.BOSPropertyName = null;
            this.fld_chkStatusApproved.EditValue = true;
            this.fld_chkStatusApproved.Location = new System.Drawing.Point(97, 14);
            this.fld_chkStatusApproved.MenuManager = this.screenToolbar;
            this.fld_chkStatusApproved.Name = "fld_chkStatusApproved";
            this.fld_chkStatusApproved.Properties.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fld_chkStatusApproved.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkStatusApproved.Properties.Caption = "Đã duyệt";
            this.fld_chkStatusApproved.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.fld_chkStatusApproved.Screen = null;
            this.fld_chkStatusApproved.Size = new System.Drawing.Size(76, 19);
            this.fld_chkStatusApproved.TabIndex = 37;
            this.fld_chkStatusApproved.CheckStateChanged += new System.EventHandler(this.fld_chkStatusApproved_CheckStateChanged);
            // 
            // fld_lblSelectAll
            // 
            this.fld_lblSelectAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.fld_lblSelectAll.Appearance.Options.UseFont = true;
            this.fld_lblSelectAll.BOSComment = null;
            this.fld_lblSelectAll.BOSDataMember = null;
            this.fld_lblSelectAll.BOSDataSource = null;
            this.fld_lblSelectAll.BOSDescription = null;
            this.fld_lblSelectAll.BOSError = null;
            this.fld_lblSelectAll.BOSFieldGroup = null;
            this.fld_lblSelectAll.BOSFieldRelation = null;
            this.fld_lblSelectAll.BOSPrivilege = null;
            this.fld_lblSelectAll.BOSPropertyName = null;
            this.fld_lblSelectAll.Location = new System.Drawing.Point(367, 17);
            this.fld_lblSelectAll.Name = "fld_lblSelectAll";
            this.fld_lblSelectAll.Screen = null;
            this.fld_lblSelectAll.Size = new System.Drawing.Size(64, 13);
            this.fld_lblSelectAll.TabIndex = 106;
            this.fld_lblSelectAll.Text = "Chọn tất cả";
            this.fld_lblSelectAll.Click += new System.EventHandler(this.fld_lblSelectAll_Click);
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_btnCloseTicket);
            this.bosLine3.Controls.Add(this.fld_btnCancel);
            this.bosLine3.Controls.Add(this.fld_btnApprove);
            this.bosLine3.Controls.Add(this.fld_btnCapacityReceipt);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(801, 4);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(147, 162);
            this.bosLine3.TabIndex = 120;
            this.bosLine3.TabStop = false;
            // 
            // fld_btnCloseTicket
            // 
            this.fld_btnCloseTicket.BOSComment = null;
            this.fld_btnCloseTicket.BOSDataMember = null;
            this.fld_btnCloseTicket.BOSDataSource = null;
            this.fld_btnCloseTicket.BOSDescription = null;
            this.fld_btnCloseTicket.BOSError = null;
            this.fld_btnCloseTicket.BOSFieldGroup = null;
            this.fld_btnCloseTicket.BOSFieldRelation = null;
            this.fld_btnCloseTicket.BOSPrivilege = null;
            this.fld_btnCloseTicket.BOSPropertyName = null;
            this.fld_btnCloseTicket.Location = new System.Drawing.Point(16, 86);
            this.fld_btnCloseTicket.Name = "fld_btnCloseTicket";
            this.fld_btnCloseTicket.Screen = null;
            this.fld_btnCloseTicket.Size = new System.Drawing.Size(114, 27);
            this.fld_btnCloseTicket.TabIndex = 118;
            this.fld_btnCloseTicket.Text = "Đóng (nhiều) thẻ";
            this.fld_btnCloseTicket.Click += new System.EventHandler(this.fld_btnCloseTicket_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(16, 53);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(114, 27);
            this.fld_btnCancel.TabIndex = 118;
            this.fld_btnCancel.Text = "Hủy (nhiều) thẻ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
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
            this.fld_btnApprove.Location = new System.Drawing.Point(16, 20);
            this.fld_btnApprove.Name = "fld_btnApprove";
            this.fld_btnApprove.Screen = null;
            this.fld_btnApprove.Size = new System.Drawing.Size(114, 27);
            this.fld_btnApprove.TabIndex = 118;
            this.fld_btnApprove.Text = "Duyệt (nhiều) thẻ";
            this.fld_btnApprove.Click += new System.EventHandler(this.fld_btnApprove_Click);
            // 
            // fld_btnCapacityReceipt
            // 
            this.fld_btnCapacityReceipt.BOSComment = null;
            this.fld_btnCapacityReceipt.BOSDataMember = null;
            this.fld_btnCapacityReceipt.BOSDataSource = null;
            this.fld_btnCapacityReceipt.BOSDescription = null;
            this.fld_btnCapacityReceipt.BOSError = null;
            this.fld_btnCapacityReceipt.BOSFieldGroup = null;
            this.fld_btnCapacityReceipt.BOSFieldRelation = null;
            this.fld_btnCapacityReceipt.BOSPrivilege = null;
            this.fld_btnCapacityReceipt.BOSPropertyName = null;
            this.fld_btnCapacityReceipt.Location = new System.Drawing.Point(16, 119);
            this.fld_btnCapacityReceipt.Name = "fld_btnCapacityReceipt";
            this.fld_btnCapacityReceipt.Screen = null;
            this.fld_btnCapacityReceipt.Size = new System.Drawing.Size(114, 27);
            this.fld_btnCapacityReceipt.TabIndex = 118;
            this.fld_btnCapacityReceipt.Text = "Nhập sản lượng";
            this.fld_btnCapacityReceipt.Click += new System.EventHandler(this.fld_btnCapacityReceipt_Click);
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosButton1);
            this.bosLine2.Controls.Add(this.fld_dteMMJobTicketFromDate);
            this.bosLine2.Controls.Add(this.bosLabel9);
            this.bosLine2.Controls.Add(this.fld_dteMMJobTicketToDate);
            this.bosLine2.Controls.Add(this.bosLabel6);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(504, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(291, 119);
            this.bosLine2.TabIndex = 119;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Cập nhật ngày giao việc";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(152, 74);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(133, 27);
            this.bosButton1.TabIndex = 118;
            this.bosButton1.Text = "Cập nhật";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dteMMJobTicketFromDate
            // 
            this.fld_dteMMJobTicketFromDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSDescription = null;
            this.fld_dteMMJobTicketFromDate.BOSError = null;
            this.fld_dteMMJobTicketFromDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketFromDate.EditValue = null;
            this.fld_dteMMJobTicketFromDate.Location = new System.Drawing.Point(94, 20);
            this.fld_dteMMJobTicketFromDate.Name = "fld_dteMMJobTicketFromDate";
            this.fld_dteMMJobTicketFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMJobTicketFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMJobTicketFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMJobTicketFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMJobTicketFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMJobTicketFromDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteMMJobTicketFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteMMJobTicketFromDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteMMJobTicketFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteMMJobTicketFromDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.fld_dteMMJobTicketFromDate.Properties.Mask.EditMask = "g";
            this.fld_dteMMJobTicketFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMJobTicketFromDate.Screen = null;
            this.fld_dteMMJobTicketFromDate.Size = new System.Drawing.Size(191, 20);
            this.fld_dteMMJobTicketFromDate.TabIndex = 92;
            this.fld_dteMMJobTicketFromDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(17, 23);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(61, 13);
            this.bosLabel9.TabIndex = 97;
            this.bosLabel9.Text = "Thực hiện từ";
            // 
            // fld_dteMMJobTicketToDate
            // 
            this.fld_dteMMJobTicketToDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSDescription = null;
            this.fld_dteMMJobTicketToDate.BOSError = null;
            this.fld_dteMMJobTicketToDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMJobTicketToDate.EditValue = null;
            this.fld_dteMMJobTicketToDate.Location = new System.Drawing.Point(94, 46);
            this.fld_dteMMJobTicketToDate.Name = "fld_dteMMJobTicketToDate";
            this.fld_dteMMJobTicketToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMJobTicketToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMJobTicketToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMJobTicketToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMJobTicketToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMJobTicketToDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteMMJobTicketToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteMMJobTicketToDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteMMJobTicketToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteMMJobTicketToDate.Properties.Mask.EditMask = "g";
            this.fld_dteMMJobTicketToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMJobTicketToDate.Screen = null;
            this.fld_dteMMJobTicketToDate.Size = new System.Drawing.Size(191, 20);
            this.fld_dteMMJobTicketToDate.TabIndex = 92;
            this.fld_dteMMJobTicketToDate.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(17, 49);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 114;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_btnLoadDetailPlan
            // 
            this.fld_btnLoadDetailPlan.BOSComment = null;
            this.fld_btnLoadDetailPlan.BOSDataMember = null;
            this.fld_btnLoadDetailPlan.BOSDataSource = null;
            this.fld_btnLoadDetailPlan.BOSDescription = null;
            this.fld_btnLoadDetailPlan.BOSError = null;
            this.fld_btnLoadDetailPlan.BOSFieldGroup = null;
            this.fld_btnLoadDetailPlan.BOSFieldRelation = null;
            this.fld_btnLoadDetailPlan.BOSPrivilege = null;
            this.fld_btnLoadDetailPlan.BOSPropertyName = null;
            this.fld_btnLoadDetailPlan.Location = new System.Drawing.Point(5, 132);
            this.fld_btnLoadDetailPlan.Name = "fld_btnLoadDetailPlan";
            this.fld_btnLoadDetailPlan.Screen = null;
            this.fld_btnLoadDetailPlan.Size = new System.Drawing.Size(90, 27);
            this.fld_btnLoadDetailPlan.TabIndex = 117;
            this.fld_btnLoadDetailPlan.Text = "Thêm thẻ";
            this.fld_btnLoadDetailPlan.Click += new System.EventHandler(this.fld_btnLoadDetailPlan_Click);
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
            this.bosLine1.Controls.Add(this.fld_txtMMJobTicketName);
            this.bosLine1.Controls.Add(this.fld_txtMMJobTicketNo);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosLine1.Controls.Add(this.fld_dteMMJobTicketDate);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.bosLabel5);
            this.bosLine1.Controls.Add(this.fld_medMMJobTicketDesc);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(495, 119);
            this.bosLine1.TabIndex = 115;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin chung";
            // 
            // fld_txtMMJobTicketName
            // 
            this.fld_txtMMJobTicketName.BOSComment = null;
            this.fld_txtMMJobTicketName.BOSDataMember = "MMJobTicketName";
            this.fld_txtMMJobTicketName.BOSDataSource = "MMJobTickets";
            this.fld_txtMMJobTicketName.BOSDescription = null;
            this.fld_txtMMJobTicketName.BOSError = null;
            this.fld_txtMMJobTicketName.BOSFieldGroup = null;
            this.fld_txtMMJobTicketName.BOSFieldRelation = null;
            this.fld_txtMMJobTicketName.BOSPrivilege = null;
            this.fld_txtMMJobTicketName.BOSPropertyName = "EditValue";
            this.fld_txtMMJobTicketName.Location = new System.Drawing.Point(348, 20);
            this.fld_txtMMJobTicketName.Name = "fld_txtMMJobTicketName";
            this.fld_txtMMJobTicketName.Screen = null;
            this.fld_txtMMJobTicketName.Size = new System.Drawing.Size(133, 20);
            this.fld_txtMMJobTicketName.TabIndex = 90;
            this.fld_txtMMJobTicketName.Tag = "DC";
            // 
            // fld_txtMMJobTicketNo
            // 
            this.fld_txtMMJobTicketNo.BOSComment = null;
            this.fld_txtMMJobTicketNo.BOSDataMember = "MMJobTicketNo";
            this.fld_txtMMJobTicketNo.BOSDataSource = "MMJobTickets";
            this.fld_txtMMJobTicketNo.BOSDescription = null;
            this.fld_txtMMJobTicketNo.BOSError = null;
            this.fld_txtMMJobTicketNo.BOSFieldGroup = null;
            this.fld_txtMMJobTicketNo.BOSFieldRelation = null;
            this.fld_txtMMJobTicketNo.BOSPrivilege = null;
            this.fld_txtMMJobTicketNo.BOSPropertyName = "EditValue";
            this.fld_txtMMJobTicketNo.Location = new System.Drawing.Point(94, 20);
            this.fld_txtMMJobTicketNo.MenuManager = this.screenToolbar;
            this.fld_txtMMJobTicketNo.Name = "fld_txtMMJobTicketNo";
            this.fld_txtMMJobTicketNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMJobTicketNo, true);
            this.fld_txtMMJobTicketNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtMMJobTicketNo.TabIndex = 90;
            this.fld_txtMMJobTicketNo.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(258, 23);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 98;
            this.bosLabel4.Text = "Tên chứng từ";
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
            this.bosLabel7.Location = new System.Drawing.Point(258, 49);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 99;
            this.bosLabel7.Text = "Ngày chứng từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(11, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 98;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMJobTickets";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(94, 46);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 91;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_dteMMJobTicketDate
            // 
            this.fld_dteMMJobTicketDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketDate.BOSDataMember = "MMJobTicketDate";
            this.fld_dteMMJobTicketDate.BOSDataSource = "MMJobTickets";
            this.fld_dteMMJobTicketDate.BOSDescription = null;
            this.fld_dteMMJobTicketDate.BOSError = null;
            this.fld_dteMMJobTicketDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMJobTicketDate.BOSPropertyName = "EditValue";
            this.fld_dteMMJobTicketDate.EditValue = null;
            this.fld_dteMMJobTicketDate.Location = new System.Drawing.Point(348, 46);
            this.fld_dteMMJobTicketDate.Name = "fld_dteMMJobTicketDate";
            this.fld_dteMMJobTicketDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMJobTicketDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMJobTicketDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMJobTicketDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMJobTicketDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMJobTicketDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMJobTicketDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMJobTicketDate, true);
            this.fld_dteMMJobTicketDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteMMJobTicketDate.TabIndex = 92;
            this.fld_dteMMJobTicketDate.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(11, 49);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(45, 13);
            this.bosLabel2.TabIndex = 100;
            this.bosLabel2.Text = "Người lập";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(11, 75);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 106;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_medMMJobTicketDesc
            // 
            this.fld_medMMJobTicketDesc.BOSComment = null;
            this.fld_medMMJobTicketDesc.BOSDataMember = "MMJobTicketDesc";
            this.fld_medMMJobTicketDesc.BOSDataSource = "MMJobTickets";
            this.fld_medMMJobTicketDesc.BOSDescription = null;
            this.fld_medMMJobTicketDesc.BOSError = null;
            this.fld_medMMJobTicketDesc.BOSFieldGroup = null;
            this.fld_medMMJobTicketDesc.BOSFieldRelation = null;
            this.fld_medMMJobTicketDesc.BOSPrivilege = null;
            this.fld_medMMJobTicketDesc.BOSPropertyName = "EditValue";
            this.fld_medMMJobTicketDesc.Location = new System.Drawing.Point(94, 72);
            this.fld_medMMJobTicketDesc.MenuManager = this.screenToolbar;
            this.fld_medMMJobTicketDesc.Name = "fld_medMMJobTicketDesc";
            this.fld_medMMJobTicketDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMJobTicketDesc, true);
            this.fld_medMMJobTicketDesc.Size = new System.Drawing.Size(387, 38);
            this.fld_medMMJobTicketDesc.TabIndex = 104;
            this.fld_medMMJobTicketDesc.Tag = "DC";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // fld_dgvMMJobTicketItems
            // 
            this.fld_dgvMMJobTicketItems.Name = "fld_dgvMMJobTicketItems";
            this.fld_dgvMMJobTicketItems.PaintStyleName = "Office2003";
            // 
            // DMJT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1035, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMJT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMJobTicketItems)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            this.bosLine6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusClosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusCanceled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkStatusApproved.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketToDate.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMJobTicketNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMJobTicketDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMJobTicketDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMJobTicketItems)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteMMJobTicketDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMJobTicketNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSMemoEdit fld_medMMJobTicketDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMJobTicketItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSButton fld_btnLoadDetailPlan;
        private MMJobTicketItemsGridControl fld_dgcMMJobTicketItems;
        private BOSComponent.BOSDateEdit fld_dteMMJobTicketToDate;
        private BOSComponent.BOSDateEdit fld_dteMMJobTicketFromDate;
        private BOSComponent.BOSTextBox fld_txtMMJobTicketName;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private BOSComponent.BOSLabel fld_lblStatusAlittleReceipt;
        private Button fld_btnStatusAlittleReceipt;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSButton fld_btnCloseTicket;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnApprove;
        private BOSComponent.BOSButton fld_btnCapacityReceipt;
        private BOSComponent.BOSLabel fld_lblStatusLate;
        private Button fld_btnStatusLate;
        private BOSComponent.BOSCheckEdit fld_chkStatusCanceled;
        private BOSComponent.BOSCheckEdit fld_chkStatusApproved;
        private BOSComponent.BOSCheckEdit fld_chkStatusNew;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSCheckEdit fld_chkStatusClosed;
        private BOSComponent.BOSLabel fld_lblSelectAll;
        private BOSComponent.BOSButton fld_btnTUpdateEmployee;
	}
}
