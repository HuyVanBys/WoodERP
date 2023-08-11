using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIEvaluation.UI
{
	/// <summary>
	/// Summary description for DMKPIE100
	/// </summary>
	partial class DMKPIE100
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
            this.fld_txtHRKPIEvaluationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRKPIEvaluationEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteHRKPIEvaluationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRKPIEvaluationItemTargets = new BOSERP.Modules.KPIEvaluation.HRKPIEvaluationItemTargetsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeKPIEvaluationItems = new BOSERP.Modules.KPIEvaluation.HREmployeeKPIEvaluationItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRKPIEvaluationItems = new BOSERP.Modules.KPIEvaluation.HRKPIEvaluateItemsGridControl();
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeHRKPIEvaluationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRKPIEvaluationStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRKPIEvaluationFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRKPIRegistrationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRKPIEvaluationTotalAmountBonus = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRKPIEvaluationTotalAmount = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIEvaluationEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluationItemTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeKPIEvaluationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRKPIEvaluationStatus.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRKPIRegistrationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationTotalAmountBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationTotalAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRKPIEvaluationNo
            // 
            this.fld_txtHRKPIEvaluationNo.BOSComment = null;
            this.fld_txtHRKPIEvaluationNo.BOSDataMember = "HRKPIEvaluationNo";
            this.fld_txtHRKPIEvaluationNo.BOSDataSource = "HRKPIEvaluations";
            this.fld_txtHRKPIEvaluationNo.BOSDescription = null;
            this.fld_txtHRKPIEvaluationNo.BOSError = null;
            this.fld_txtHRKPIEvaluationNo.BOSFieldGroup = null;
            this.fld_txtHRKPIEvaluationNo.BOSFieldRelation = null;
            this.fld_txtHRKPIEvaluationNo.BOSPrivilege = null;
            this.fld_txtHRKPIEvaluationNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIEvaluationNo.Location = new System.Drawing.Point(239, 12);
            this.fld_txtHRKPIEvaluationNo.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIEvaluationNo.Name = "fld_txtHRKPIEvaluationNo";
            this.fld_txtHRKPIEvaluationNo.Screen = null;
            this.fld_txtHRKPIEvaluationNo.Size = new System.Drawing.Size(179, 20);
            this.fld_txtHRKPIEvaluationNo.TabIndex = 0;
            this.fld_txtHRKPIEvaluationNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(133, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(58, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã đánh giá";
            // 
            // fld_pteHRKPIEvaluationEmployeePicture
            // 
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSComment = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSDataMember = "HRKPIEvaluationEmployeePicture";
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSDataSource = "HRKPIEvaluations";
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSDescription = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSError = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRKPIEvaluationEmployeePicture.FileName = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.FilePath = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteHRKPIEvaluationEmployeePicture.Name = "fld_pteHRKPIEvaluationEmployeePicture";
            this.fld_pteHRKPIEvaluationEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRKPIEvaluationEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRKPIEvaluationEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRKPIEvaluationEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRKPIEvaluationEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRKPIEvaluationEmployeePicture.Screen = null;
            this.fld_pteHRKPIEvaluationEmployeePicture.Size = new System.Drawing.Size(100, 80);
            this.fld_pteHRKPIEvaluationEmployeePicture.TabIndex = 76;
            this.fld_pteHRKPIEvaluationEmployeePicture.Tag = "DC";
            // 
            // fld_dteHRKPIEvaluationDate
            // 
            this.fld_dteHRKPIEvaluationDate.BOSComment = null;
            this.fld_dteHRKPIEvaluationDate.BOSDataMember = "HRKPIEvaluationDate";
            this.fld_dteHRKPIEvaluationDate.BOSDataSource = "HRKPIEvaluations";
            this.fld_dteHRKPIEvaluationDate.BOSDescription = null;
            this.fld_dteHRKPIEvaluationDate.BOSError = null;
            this.fld_dteHRKPIEvaluationDate.BOSFieldGroup = null;
            this.fld_dteHRKPIEvaluationDate.BOSFieldRelation = null;
            this.fld_dteHRKPIEvaluationDate.BOSPrivilege = null;
            this.fld_dteHRKPIEvaluationDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIEvaluationDate.EditValue = null;
            this.fld_dteHRKPIEvaluationDate.Location = new System.Drawing.Point(614, 11);
            this.fld_dteHRKPIEvaluationDate.Name = "fld_dteHRKPIEvaluationDate";
            this.fld_dteHRKPIEvaluationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRKPIEvaluationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIEvaluationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIEvaluationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIEvaluationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIEvaluationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIEvaluationDate.Screen = null;
            this.fld_dteHRKPIEvaluationDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIEvaluationDate.TabIndex = 1;
            this.fld_dteHRKPIEvaluationDate.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(507, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày đánh giá";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 90);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 8;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(11, 22);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Text = "Từ ngày";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(891, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(102, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Tổng tiền thưởng KPI";
            this.bosLabel3.Visible = false;
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
            this.bosPanel1.Controls.Add(this.splitContainer1);
            this.bosPanel1.Controls.Add(this.fld_lkeHRKPIEvaluationStatus);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRKPIRegistrationID);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIEvaluationTotalAmountBonus);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIEvaluationTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_pteHRKPIEvaluationEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteHRKPIEvaluationDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRKPIEvaluationNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1220, 721);
            this.bosPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 117);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainer1.Panel1.Controls.Add(this.bosGroupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fld_grcGroupControl3);
            this.splitContainer1.Size = new System.Drawing.Size(1213, 596);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 111;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl2.Appearance.Options.UseBackColor = true;
            this.bosGroupControl2.Appearance.Options.UseForeColor = true;
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcHRKPIEvaluationItemTargets);
            this.bosGroupControl2.Location = new System.Drawing.Point(0, 395);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(448, 197);
            this.bosGroupControl2.TabIndex = 113;
            this.bosGroupControl2.Text = "Tổng hợp kết quả";
            // 
            // fld_dgcHRKPIEvaluationItemTargets
            // 
            this.fld_dgcHRKPIEvaluationItemTargets.AllowDrop = true;
            this.fld_dgcHRKPIEvaluationItemTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIEvaluationItemTargets.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSDataSource = "HRKPIEvaluationItemTargets";
            this.fld_dgcHRKPIEvaluationItemTargets.BOSDescription = null;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSError = null;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSGridType = null;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItemTargets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIEvaluationItemTargets.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRKPIEvaluationItemTargets.MainView = this.gridView3;
            this.fld_dgcHRKPIEvaluationItemTargets.Name = "fld_dgcHRKPIEvaluationItemTargets";
            this.fld_dgcHRKPIEvaluationItemTargets.PrintReport = false;
            this.fld_dgcHRKPIEvaluationItemTargets.Screen = null;
            this.fld_dgcHRKPIEvaluationItemTargets.Size = new System.Drawing.Size(438, 172);
            this.fld_dgcHRKPIEvaluationItemTargets.TabIndex = 12;
            this.fld_dgcHRKPIEvaluationItemTargets.Tag = "DC";
            this.fld_dgcHRKPIEvaluationItemTargets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcHRKPIEvaluationItemTargets;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcHREmployeeKPIEvaluationItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(453, 386);
            this.bosGroupControl1.TabIndex = 112;
            this.bosGroupControl1.Text = "Danh sách nhân viên";
            // 
            // fld_dgcHREmployeeKPIEvaluationItems
            // 
            this.fld_dgcHREmployeeKPIEvaluationItems.AllowDrop = true;
            this.fld_dgcHREmployeeKPIEvaluationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSDataSource = "HREmployeeKPIEvaluationItems";
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSDescription = null;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSError = null;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSGridType = null;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeKPIEvaluationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeKPIEvaluationItems.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHREmployeeKPIEvaluationItems.MainView = this.gridView2;
            this.fld_dgcHREmployeeKPIEvaluationItems.Name = "fld_dgcHREmployeeKPIEvaluationItems";
            this.fld_dgcHREmployeeKPIEvaluationItems.PrintReport = false;
            this.fld_dgcHREmployeeKPIEvaluationItems.Screen = null;
            this.fld_dgcHREmployeeKPIEvaluationItems.Size = new System.Drawing.Size(443, 356);
            this.fld_dgcHREmployeeKPIEvaluationItems.TabIndex = 12;
            this.fld_dgcHREmployeeKPIEvaluationItems.Tag = "DC";
            this.fld_dgcHREmployeeKPIEvaluationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHREmployeeKPIEvaluationItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = null;
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = null;
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = null;
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRKPIEvaluationItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(739, 589);
            this.fld_grcGroupControl3.TabIndex = 7;
            this.fld_grcGroupControl3.Text = "Danh sách KPI";
            // 
            // fld_dgcHRKPIEvaluationItems
            // 
            this.fld_dgcHRKPIEvaluationItems.AllowDrop = true;
            this.fld_dgcHRKPIEvaluationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIEvaluationItems.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.BOSDataSource = "HRKPIEvaluationItems";
            this.fld_dgcHRKPIEvaluationItems.BOSDescription = null;
            this.fld_dgcHRKPIEvaluationItems.BOSError = null;
            this.fld_dgcHRKPIEvaluationItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.BOSGridType = null;
            this.fld_dgcHRKPIEvaluationItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHRKPIEvaluationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIEvaluationItems.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRKPIEvaluationItems.MainView = this.fld_dgvHRKPIFormItems;
            this.fld_dgcHRKPIEvaluationItems.Name = "fld_dgcHRKPIEvaluationItems";
            this.fld_dgcHRKPIEvaluationItems.PrintReport = false;
            this.fld_dgcHRKPIEvaluationItems.Screen = null;
            this.fld_dgcHRKPIEvaluationItems.Size = new System.Drawing.Size(732, 559);
            this.fld_dgcHRKPIEvaluationItems.TabIndex = 12;
            this.fld_dgcHRKPIEvaluationItems.Tag = "DC";
            this.fld_dgcHRKPIEvaluationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRKPIFormItems});
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.GridControl = this.fld_dgcHRKPIEvaluationItems;
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeHRKPIEvaluationStatus
            // 
            this.fld_lkeHRKPIEvaluationStatus.BOSAllowAddNew = false;
            this.fld_lkeHRKPIEvaluationStatus.BOSAllowDummy = true;
            this.fld_lkeHRKPIEvaluationStatus.BOSComment = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSDataMember = "HRKPIEvaluationStatus";
            this.fld_lkeHRKPIEvaluationStatus.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeHRKPIEvaluationStatus.BOSDescription = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSError = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSFieldGroup = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSFieldParent = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSFieldRelation = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSPrivilege = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRKPIEvaluationStatus.BOSSelectType = null;
            this.fld_lkeHRKPIEvaluationStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRKPIEvaluationStatus.CurrentDisplayText = null;
            this.fld_lkeHRKPIEvaluationStatus.Location = new System.Drawing.Point(239, 64);
            this.fld_lkeHRKPIEvaluationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRKPIEvaluationStatus.Name = "fld_lkeHRKPIEvaluationStatus";
            this.fld_lkeHRKPIEvaluationStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeHRKPIEvaluationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRKPIEvaluationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRKPIEvaluationStatus.Properties.ColumnName = null;
            this.fld_lkeHRKPIEvaluationStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRKPIEvaluationStatus.Properties.ReadOnly = true;
            this.fld_lkeHRKPIEvaluationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRKPIEvaluationStatus.Screen = null;
            this.fld_lkeHRKPIEvaluationStatus.Size = new System.Drawing.Size(179, 20);
            this.fld_lkeHRKPIEvaluationStatus.TabIndex = 5;
            this.fld_lkeHRKPIEvaluationStatus.Tag = "DC";
            this.fld_lkeHRKPIEvaluationStatus.EditValueChanged += new System.EventHandler(this.fld_lkeHRKPIEvaluationStatus_EditValueChanged);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(133, 67);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 110;
            this.bosLabel1.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bosLabel4);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_dteHRKPIEvaluationStartDate);
            this.groupBox1.Controls.Add(this.fld_dteHRKPIEvaluationFinishedDate);
            this.groupBox1.Location = new System.Drawing.Point(507, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian áp dụng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(11, 48);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteHRKPIEvaluationStartDate
            // 
            this.fld_dteHRKPIEvaluationStartDate.BOSComment = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSDataMember = "HRKPIEvaluationStartDate";
            this.fld_dteHRKPIEvaluationStartDate.BOSDataSource = "HRKPIEvaluations";
            this.fld_dteHRKPIEvaluationStartDate.BOSDescription = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSError = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSFieldGroup = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSFieldRelation = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSPrivilege = null;
            this.fld_dteHRKPIEvaluationStartDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIEvaluationStartDate.EditValue = null;
            this.fld_dteHRKPIEvaluationStartDate.Location = new System.Drawing.Point(107, 20);
            this.fld_dteHRKPIEvaluationStartDate.Name = "fld_dteHRKPIEvaluationStartDate";
            this.fld_dteHRKPIEvaluationStartDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteHRKPIEvaluationStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRKPIEvaluationStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIEvaluationStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIEvaluationStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIEvaluationStartDate.Properties.ReadOnly = true;
            this.fld_dteHRKPIEvaluationStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIEvaluationStartDate.Screen = null;
            this.fld_dteHRKPIEvaluationStartDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIEvaluationStartDate.TabIndex = 0;
            this.fld_dteHRKPIEvaluationStartDate.Tag = "DC";
            // 
            // fld_dteHRKPIEvaluationFinishedDate
            // 
            this.fld_dteHRKPIEvaluationFinishedDate.BOSComment = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSDataMember = "HRKPIEvaluationFinishedDate";
            this.fld_dteHRKPIEvaluationFinishedDate.BOSDataSource = "HRKPIEvaluations";
            this.fld_dteHRKPIEvaluationFinishedDate.BOSDescription = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSError = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSFieldGroup = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSFieldRelation = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSPrivilege = null;
            this.fld_dteHRKPIEvaluationFinishedDate.BOSPropertyName = "EditValue";
            this.fld_dteHRKPIEvaluationFinishedDate.EditValue = null;
            this.fld_dteHRKPIEvaluationFinishedDate.Location = new System.Drawing.Point(107, 46);
            this.fld_dteHRKPIEvaluationFinishedDate.Name = "fld_dteHRKPIEvaluationFinishedDate";
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.ReadOnly = true;
            this.fld_dteHRKPIEvaluationFinishedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRKPIEvaluationFinishedDate.Screen = null;
            this.fld_dteHRKPIEvaluationFinishedDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRKPIEvaluationFinishedDate.TabIndex = 1;
            this.fld_dteHRKPIEvaluationFinishedDate.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.Location = new System.Drawing.Point(133, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(56, 13);
            this.bosLabel6.TabIndex = 108;
            this.bosLabel6.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel6.Text = "Mã áp dụng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel5.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(891, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(64, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Text = "Tổng tiền KPI";
            this.bosLabel5.Visible = false;
            // 
            // fld_lkeFK_HRKPIRegistrationID
            // 
            this.fld_lkeFK_HRKPIRegistrationID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRKPIRegistrationID.BOSAllowDummy = true;
            this.fld_lkeFK_HRKPIRegistrationID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSDataMember = "FK_HRKPIRegistrationID";
            this.fld_lkeFK_HRKPIRegistrationID.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeFK_HRKPIRegistrationID.BOSDescription = null;
            this.fld_lkeFK_HRKPIRegistrationID.BOSError = null;
            this.fld_lkeFK_HRKPIRegistrationID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRKPIRegistrationID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.CurrentDisplayText = null;
            this.fld_lkeFK_HRKPIRegistrationID.Location = new System.Drawing.Point(239, 38);
            this.fld_lkeFK_HRKPIRegistrationID.Name = "fld_lkeFK_HRKPIRegistrationID";
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRKPIRegistrationID.Properties.ColumnName = null;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRKPIRegistrationNo", "Mã đăng ký")});
            this.fld_lkeFK_HRKPIRegistrationID.Properties.DisplayMember = "HRKPIRegistrationNo";
            this.fld_lkeFK_HRKPIRegistrationID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.ReadOnly = true;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRKPIRegistrationID.Properties.ValueMember = "HRKPIRegistrationID";
            this.fld_lkeFK_HRKPIRegistrationID.Screen = null;
            this.fld_lkeFK_HRKPIRegistrationID.Size = new System.Drawing.Size(179, 20);
            this.fld_lkeFK_HRKPIRegistrationID.TabIndex = 2;
            this.fld_lkeFK_HRKPIRegistrationID.Tag = "DC";
            // 
            // fld_txtHRKPIEvaluationTotalAmountBonus
            // 
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSComment = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSDataMember = "HRKPIEvaluationTotalAmountBonus";
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSDataSource = "HRKPIEvaluations";
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSDescription = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSError = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSFieldGroup = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSFieldRelation = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSPrivilege = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Location = new System.Drawing.Point(1000, 38);
            this.fld_txtHRKPIEvaluationTotalAmountBonus.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Name = "fld_txtHRKPIEvaluationTotalAmountBonus";
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Properties.ReadOnly = true;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Screen = null;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Size = new System.Drawing.Size(179, 20);
            this.fld_txtHRKPIEvaluationTotalAmountBonus.TabIndex = 4;
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Tag = "DC";
            this.fld_txtHRKPIEvaluationTotalAmountBonus.Visible = false;
            // 
            // fld_txtHRKPIEvaluationTotalAmount
            // 
            this.fld_txtHRKPIEvaluationTotalAmount.BOSComment = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSDataMember = "HRKPIEvaluationTotalAmount";
            this.fld_txtHRKPIEvaluationTotalAmount.BOSDataSource = "HRKPIEvaluations";
            this.fld_txtHRKPIEvaluationTotalAmount.BOSDescription = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSError = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSFieldGroup = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSFieldRelation = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSPrivilege = null;
            this.fld_txtHRKPIEvaluationTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIEvaluationTotalAmount.Location = new System.Drawing.Point(1000, 11);
            this.fld_txtHRKPIEvaluationTotalAmount.MenuManager = this.screenToolbar;
            this.fld_txtHRKPIEvaluationTotalAmount.Name = "fld_txtHRKPIEvaluationTotalAmount";
            this.fld_txtHRKPIEvaluationTotalAmount.Properties.ReadOnly = true;
            this.fld_txtHRKPIEvaluationTotalAmount.Screen = null;
            this.fld_txtHRKPIEvaluationTotalAmount.Size = new System.Drawing.Size(179, 20);
            this.fld_txtHRKPIEvaluationTotalAmount.TabIndex = 9;
            this.fld_txtHRKPIEvaluationTotalAmount.Tag = "DC";
            this.fld_txtHRKPIEvaluationTotalAmount.Visible = false;
            // 
            // DMKPIE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1220, 721);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMKPIE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRKPIEvaluationEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluationItemTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeKPIEvaluationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRKPIEvaluationStatus.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRKPIEvaluationFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRKPIRegistrationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationTotalAmountBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationTotalAmount.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRKPIEvaluationNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteHRKPIEvaluationEmployeePicture;
        private BOSComponent.BOSDateEdit fld_dteHRKPIEvaluationDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteHRKPIEvaluationFinishedDate;
        private BOSComponent.BOSDateEdit fld_dteHRKPIEvaluationStartDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIEvaluationTotalAmountBonus;
        private BOSComponent.BOSTextBox fld_txtHRKPIEvaluationTotalAmount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRKPIRegistrationID;
        private GroupBox groupBox1;
        private BOSComponent.BOSLookupEdit fld_lkeHRKPIEvaluationStatus;
        private BOSComponent.BOSLabel bosLabel1;
        private SplitContainer splitContainer1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private HREmployeeKPIEvaluationItemsGridControl fld_dgcHREmployeeKPIEvaluationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private HRKPIEvaluateItemsGridControl fld_dgcHRKPIEvaluationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private HRKPIEvaluationItemTargetsGridControl fld_dgcHRKPIEvaluationItemTargets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}
