using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
    /// Summary description for DMPM100
	/// </summary>
    partial class DMPM100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPM100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtARCustomerContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddCustomers = new BOSComponent.BOSButton(this.components);
            this.accObjectLookupEdit1 = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_ptePMProjectEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtPMProjectActualTotalDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectEstimatedTotalDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkePMProjectPriority = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMProjectActualEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMProjectActualStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMProjectEstimatedEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMProjectEstimatedStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRProjectOwnerEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkePMProjectStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePMProjectDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medPMProjectInfo = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeARProspectCustomerBusiness = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARProspectCustomerName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProspectCustomerCompany = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProspectCustomerTel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARProspectCustomerEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARProspectCustomerContactAddress = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnEditLocation = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteLocation = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddLocation = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProjectLocationsGridControl = new BOSERP.Modules.Project.ProjectLocationsGridControl();
            this.fld_bedPMProjectLocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_GEStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_FK_GEDistrictID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectLocationAddress = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePMProjectEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectActualTotalDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectEstimatedTotalDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMProjectPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMProjectStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMProjectInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProspectCustomerBusiness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerContactAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectLocationsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedPMProjectLocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_FK_GEDistrictID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectLocationAddress.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.splitContainerControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(989, 741);
            this.bosPanel1.TabIndex = 29;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bosGroupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(989, 741);
            this.splitContainerControl1.SplitterPosition = 489;
            this.splitContainerControl1.TabIndex = 451;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.bosLabel21);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactPhone);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactEmail1);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactAddressLine1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 398);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(983, 90);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Text = "Thông tin khách hàng";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bosLabel14.Appearance.Options.UseBackColor = true;
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
            this.bosLabel14.Location = new System.Drawing.Point(612, 34);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(6, 13);
            this.bosLabel14.TabIndex = 136;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "*";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
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
            this.bosLabel21.Location = new System.Drawing.Point(638, 34);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(62, 13);
            this.bosLabel21.TabIndex = 135;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Số điện thoại";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "PMProjects";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(125, 31);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(481, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 0;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_txtARCustomerContactPhone
            // 
            this.fld_txtARCustomerContactPhone.BOSComment = "";
            this.fld_txtARCustomerContactPhone.BOSDataMember = "ARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone.BOSDataSource = "PMProjects";
            this.fld_txtARCustomerContactPhone.BOSDescription = null;
            this.fld_txtARCustomerContactPhone.BOSError = "";
            this.fld_txtARCustomerContactPhone.BOSFieldGroup = "";
            this.fld_txtARCustomerContactPhone.BOSFieldRelation = "";
            this.fld_txtARCustomerContactPhone.BOSPrivilege = "";
            this.fld_txtARCustomerContactPhone.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactPhone.Location = new System.Drawing.Point(706, 31);
            this.fld_txtARCustomerContactPhone.Name = "fld_txtARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactPhone.Screen = null;
            this.fld_txtARCustomerContactPhone.Size = new System.Drawing.Size(180, 20);
            this.fld_txtARCustomerContactPhone.TabIndex = 1;
            this.fld_txtARCustomerContactPhone.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
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
            this.bosLabel17.Location = new System.Drawing.Point(15, 34);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(79, 13);
            this.bosLabel17.TabIndex = 126;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Tên khách hàng";
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
            this.bosLabel19.Location = new System.Drawing.Point(638, 60);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(58, 13);
            this.bosLabel19.TabIndex = 6;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Email liên hệ";
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
            this.bosLabel20.Location = new System.Drawing.Point(15, 60);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(32, 13);
            this.bosLabel20.TabIndex = 7;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Địa chỉ";
            // 
            // fld_txtARCustomerContactEmail1
            // 
            this.fld_txtARCustomerContactEmail1.BOSComment = "";
            this.fld_txtARCustomerContactEmail1.BOSDataMember = "ARCustomerContactEmail1";
            this.fld_txtARCustomerContactEmail1.BOSDataSource = "PMProjects";
            this.fld_txtARCustomerContactEmail1.BOSDescription = null;
            this.fld_txtARCustomerContactEmail1.BOSError = "";
            this.fld_txtARCustomerContactEmail1.BOSFieldGroup = "";
            this.fld_txtARCustomerContactEmail1.BOSFieldRelation = "";
            this.fld_txtARCustomerContactEmail1.BOSPrivilege = "";
            this.fld_txtARCustomerContactEmail1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactEmail1.Location = new System.Drawing.Point(706, 57);
            this.fld_txtARCustomerContactEmail1.Name = "fld_txtARCustomerContactEmail1";
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactEmail1.Screen = null;
            this.fld_txtARCustomerContactEmail1.Size = new System.Drawing.Size(180, 20);
            this.fld_txtARCustomerContactEmail1.TabIndex = 3;
            this.fld_txtARCustomerContactEmail1.Tag = "DC";
            // 
            // fld_txtARCustomerContactAddressLine1
            // 
            this.fld_txtARCustomerContactAddressLine1.BOSComment = "";
            this.fld_txtARCustomerContactAddressLine1.BOSDataMember = "ARCustomerContactAddressLine1";
            this.fld_txtARCustomerContactAddressLine1.BOSDataSource = "PMProjects";
            this.fld_txtARCustomerContactAddressLine1.BOSDescription = null;
            this.fld_txtARCustomerContactAddressLine1.BOSError = "Tên dự án không thể rỗng";
            this.fld_txtARCustomerContactAddressLine1.BOSFieldGroup = "";
            this.fld_txtARCustomerContactAddressLine1.BOSFieldRelation = "";
            this.fld_txtARCustomerContactAddressLine1.BOSPrivilege = "";
            this.fld_txtARCustomerContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactAddressLine1.Location = new System.Drawing.Point(125, 57);
            this.fld_txtARCustomerContactAddressLine1.Name = "fld_txtARCustomerContactAddressLine1";
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactAddressLine1.Screen = null;
            this.fld_txtARCustomerContactAddressLine1.Size = new System.Drawing.Size(496, 20);
            this.fld_txtARCustomerContactAddressLine1.TabIndex = 2;
            this.fld_txtARCustomerContactAddressLine1.Tag = "DC";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_btnAddCustomers);
            this.fld_grcGroupControl.Controls.Add(this.accObjectLookupEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_ptePMProjectEmployeePicture);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectActualTotalDays);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectEstimatedTotalDays);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkePMProjectPriority);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel16);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel15);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMProjectActualEndDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMProjectActualStartDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMProjectEstimatedEndDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMProjectEstimatedStartDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRProjectOwnerEmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkePMProjectStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dtePMProjectDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medPMProjectInfo);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(983, 268);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin dự án";
            // 
            // fld_btnAddCustomers
            // 
            this.fld_btnAddCustomers.BOSComment = null;
            this.fld_btnAddCustomers.BOSDataMember = null;
            this.fld_btnAddCustomers.BOSDataSource = null;
            this.fld_btnAddCustomers.BOSDescription = null;
            this.fld_btnAddCustomers.BOSError = null;
            this.fld_btnAddCustomers.BOSFieldGroup = null;
            this.fld_btnAddCustomers.BOSFieldRelation = null;
            this.fld_btnAddCustomers.BOSPrivilege = null;
            this.fld_btnAddCustomers.BOSPropertyName = null;
            this.fld_btnAddCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnAddCustomers.ImageOptions.Image")));
            this.fld_btnAddCustomers.Location = new System.Drawing.Point(629, 133);
            this.fld_btnAddCustomers.Name = "fld_btnAddCustomers";
            this.fld_btnAddCustomers.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnAddCustomers, true);
            this.fld_btnAddCustomers.Size = new System.Drawing.Size(30, 24);
            this.fld_btnAddCustomers.TabIndex = 144;
            this.fld_btnAddCustomers.Click += new System.EventHandler(this.fld_btnAddCustomers_Click);
            // 
            // accObjectLookupEdit1
            // 
            this.accObjectLookupEdit1.BOSAllowAddNew = false;
            this.accObjectLookupEdit1.BOSAllowDummy = true;
            this.accObjectLookupEdit1.BOSComment = "";
            this.accObjectLookupEdit1.BOSDataMember = "ACAssObjectAccessKey";
            this.accObjectLookupEdit1.BOSDataSource = "PMProjects";
            this.accObjectLookupEdit1.BOSDescription = null;
            this.accObjectLookupEdit1.BOSError = null;
            this.accObjectLookupEdit1.BOSFieldGroup = "";
            this.accObjectLookupEdit1.BOSFieldParent = "";
            this.accObjectLookupEdit1.BOSFieldRelation = "";
            this.accObjectLookupEdit1.BOSModuleType = null;
            this.accObjectLookupEdit1.BOSPrivilege = "";
            this.accObjectLookupEdit1.BOSPropertyName = "EditValue";
            this.accObjectLookupEdit1.BOSSelectType = "";
            this.accObjectLookupEdit1.BOSSelectTypeValue = "";
            this.accObjectLookupEdit1.CurrentDisplayText = null;
            this.accObjectLookupEdit1.LastedUpdate = new System.DateTime(((long)(0)));
            this.accObjectLookupEdit1.Location = new System.Drawing.Point(250, 135);
            this.accObjectLookupEdit1.Name = "accObjectLookupEdit1";
            this.accObjectLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accObjectLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.accObjectLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accObjectLookupEdit1.Properties.ColumnName = null;
            this.accObjectLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.accObjectLookupEdit1.Properties.DisplayMember = "ACObjectName";
            this.accObjectLookupEdit1.Properties.NullText = "";
            this.accObjectLookupEdit1.Properties.PopupWidth = 40;
            this.accObjectLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accObjectLookupEdit1.Properties.ValueMember = "ACObjectID";
            this.accObjectLookupEdit1.Screen = null;
            this.accObjectLookupEdit1.Size = new System.Drawing.Size(373, 20);
            this.accObjectLookupEdit1.TabIndex = 12;
            this.accObjectLookupEdit1.Tag = "DC";
            // 
            // fld_ptePMProjectEmployeePicture
            // 
            this.fld_ptePMProjectEmployeePicture.BOSComment = null;
            this.fld_ptePMProjectEmployeePicture.BOSDataMember = "PMProjectEmployeePicture";
            this.fld_ptePMProjectEmployeePicture.BOSDataSource = "PMProjects";
            this.fld_ptePMProjectEmployeePicture.BOSDescription = null;
            this.fld_ptePMProjectEmployeePicture.BOSError = null;
            this.fld_ptePMProjectEmployeePicture.BOSFieldGroup = null;
            this.fld_ptePMProjectEmployeePicture.BOSFieldRelation = null;
            this.fld_ptePMProjectEmployeePicture.BOSPrivilege = null;
            this.fld_ptePMProjectEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_ptePMProjectEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_ptePMProjectEmployeePicture.FileName = null;
            this.fld_ptePMProjectEmployeePicture.FilePath = null;
            this.fld_ptePMProjectEmployeePicture.Location = new System.Drawing.Point(5, 27);
            this.fld_ptePMProjectEmployeePicture.Name = "fld_ptePMProjectEmployeePicture";
            this.fld_ptePMProjectEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ptePMProjectEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ptePMProjectEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ptePMProjectEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ptePMProjectEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_ptePMProjectEmployeePicture.Screen = null;
            this.fld_ptePMProjectEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_ptePMProjectEmployeePicture.TabIndex = 0;
            this.fld_ptePMProjectEmployeePicture.Tag = "DC";
            // 
            // fld_txtPMProjectActualTotalDays
            // 
            this.fld_txtPMProjectActualTotalDays.BOSComment = "";
            this.fld_txtPMProjectActualTotalDays.BOSDataMember = "PMProjectActualTotalDays";
            this.fld_txtPMProjectActualTotalDays.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectActualTotalDays.BOSDescription = null;
            this.fld_txtPMProjectActualTotalDays.BOSError = null;
            this.fld_txtPMProjectActualTotalDays.BOSFieldGroup = "";
            this.fld_txtPMProjectActualTotalDays.BOSFieldRelation = "";
            this.fld_txtPMProjectActualTotalDays.BOSPrivilege = "";
            this.fld_txtPMProjectActualTotalDays.BOSPropertyName = "EditValue";
            this.fld_txtPMProjectActualTotalDays.EditValue = "0.00";
            this.fld_txtPMProjectActualTotalDays.Location = new System.Drawing.Point(509, 187);
            this.fld_txtPMProjectActualTotalDays.Name = "fld_txtPMProjectActualTotalDays";
            this.fld_txtPMProjectActualTotalDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectActualTotalDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectActualTotalDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectActualTotalDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectActualTotalDays.Properties.Mask.EditMask = "n";
            this.fld_txtPMProjectActualTotalDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtPMProjectActualTotalDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectActualTotalDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectActualTotalDays.Screen = null;
            this.fld_txtPMProjectActualTotalDays.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPMProjectActualTotalDays.TabIndex = 16;
            this.fld_txtPMProjectActualTotalDays.Tag = "DC";
            // 
            // fld_txtPMProjectEstimatedTotalDays
            // 
            this.fld_txtPMProjectEstimatedTotalDays.BOSComment = "";
            this.fld_txtPMProjectEstimatedTotalDays.BOSDataMember = "PMProjectEstimatedTotalDays";
            this.fld_txtPMProjectEstimatedTotalDays.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectEstimatedTotalDays.BOSDescription = null;
            this.fld_txtPMProjectEstimatedTotalDays.BOSError = null;
            this.fld_txtPMProjectEstimatedTotalDays.BOSFieldGroup = "";
            this.fld_txtPMProjectEstimatedTotalDays.BOSFieldRelation = "";
            this.fld_txtPMProjectEstimatedTotalDays.BOSPrivilege = "";
            this.fld_txtPMProjectEstimatedTotalDays.BOSPropertyName = "EditValue";
            this.fld_txtPMProjectEstimatedTotalDays.EditValue = "0.00";
            this.fld_txtPMProjectEstimatedTotalDays.Location = new System.Drawing.Point(250, 187);
            this.fld_txtPMProjectEstimatedTotalDays.Name = "fld_txtPMProjectEstimatedTotalDays";
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Mask.EditMask = "n";
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtPMProjectEstimatedTotalDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectEstimatedTotalDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectEstimatedTotalDays.Screen = null;
            this.fld_txtPMProjectEstimatedTotalDays.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPMProjectEstimatedTotalDays.TabIndex = 14;
            this.fld_txtPMProjectEstimatedTotalDays.Tag = "DC";
            // 
            // fld_lkePMProjectPriority
            // 
            this.fld_lkePMProjectPriority.BOSAllowAddNew = false;
            this.fld_lkePMProjectPriority.BOSAllowDummy = true;
            this.fld_lkePMProjectPriority.BOSComment = "";
            this.fld_lkePMProjectPriority.BOSDataMember = "PMProjectPriority";
            this.fld_lkePMProjectPriority.BOSDataSource = "PMProjects";
            this.fld_lkePMProjectPriority.BOSDescription = null;
            this.fld_lkePMProjectPriority.BOSError = null;
            this.fld_lkePMProjectPriority.BOSFieldGroup = "";
            this.fld_lkePMProjectPriority.BOSFieldParent = "";
            this.fld_lkePMProjectPriority.BOSFieldRelation = "";
            this.fld_lkePMProjectPriority.BOSPrivilege = "";
            this.fld_lkePMProjectPriority.BOSPropertyName = "EditValue";
            this.fld_lkePMProjectPriority.BOSSelectType = "";
            this.fld_lkePMProjectPriority.BOSSelectTypeValue = "";
            this.fld_lkePMProjectPriority.CurrentDisplayText = null;
            this.fld_lkePMProjectPriority.Location = new System.Drawing.Point(734, 57);
            this.fld_lkePMProjectPriority.Name = "fld_lkePMProjectPriority";
            this.fld_lkePMProjectPriority.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkePMProjectPriority.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePMProjectPriority.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePMProjectPriority.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePMProjectPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePMProjectPriority.Properties.ColumnName = null;
            this.fld_lkePMProjectPriority.Properties.NullText = "";
            this.fld_lkePMProjectPriority.Properties.PopupWidth = 40;
            this.fld_lkePMProjectPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePMProjectPriority.Screen = null;
            this.fld_lkePMProjectPriority.Size = new System.Drawing.Size(180, 20);
            this.fld_lkePMProjectPriority.TabIndex = 6;
            this.fld_lkePMProjectPriority.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
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
            this.bosLabel18.Location = new System.Drawing.Point(680, 60);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(34, 13);
            this.bosLabel18.TabIndex = 143;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Ưu tiên";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
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
            this.bosLabel16.Location = new System.Drawing.Point(411, 190);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(92, 13);
            this.bosLabel16.TabIndex = 141;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Tổng TG TT (ngày)";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseFont = true;
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
            this.bosLabel15.Location = new System.Drawing.Point(127, 190);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(93, 13);
            this.bosLabel15.TabIndex = 140;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Tổng TG KH (ngày)";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
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
            this.bosLabel7.Location = new System.Drawing.Point(411, 112);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(84, 13);
            this.bosLabel7.TabIndex = 139;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Ngày kết thúc TT";
            // 
            // fld_dtePMProjectActualEndDate
            // 
            this.fld_dtePMProjectActualEndDate.BOSComment = "";
            this.fld_dtePMProjectActualEndDate.BOSDataMember = "PMProjectActualEndDate";
            this.fld_dtePMProjectActualEndDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectActualEndDate.BOSDescription = null;
            this.fld_dtePMProjectActualEndDate.BOSError = null;
            this.fld_dtePMProjectActualEndDate.BOSFieldGroup = "";
            this.fld_dtePMProjectActualEndDate.BOSFieldRelation = "";
            this.fld_dtePMProjectActualEndDate.BOSPrivilege = "";
            this.fld_dtePMProjectActualEndDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectActualEndDate.EditValue = null;
            this.fld_dtePMProjectActualEndDate.Location = new System.Drawing.Point(508, 109);
            this.fld_dtePMProjectActualEndDate.Name = "fld_dtePMProjectActualEndDate";
            this.fld_dtePMProjectActualEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectActualEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectActualEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectActualEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectActualEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectActualEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectActualEndDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectActualEndDate, true);
            this.fld_dtePMProjectActualEndDate.Size = new System.Drawing.Size(151, 20);
            this.fld_dtePMProjectActualEndDate.TabIndex = 11;
            this.fld_dtePMProjectActualEndDate.Tag = "DC";
            this.fld_dtePMProjectActualEndDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dtePMProjectActualEndDate_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
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
            this.bosLabel8.Location = new System.Drawing.Point(413, 86);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(82, 13);
            this.bosLabel8.TabIndex = 137;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Ngày bắt đầu TT";
            // 
            // fld_dtePMProjectActualStartDate
            // 
            this.fld_dtePMProjectActualStartDate.BOSComment = "";
            this.fld_dtePMProjectActualStartDate.BOSDataMember = "PMProjectActualStartDate";
            this.fld_dtePMProjectActualStartDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectActualStartDate.BOSDescription = null;
            this.fld_dtePMProjectActualStartDate.BOSError = null;
            this.fld_dtePMProjectActualStartDate.BOSFieldGroup = "";
            this.fld_dtePMProjectActualStartDate.BOSFieldRelation = "";
            this.fld_dtePMProjectActualStartDate.BOSPrivilege = "";
            this.fld_dtePMProjectActualStartDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectActualStartDate.EditValue = null;
            this.fld_dtePMProjectActualStartDate.Location = new System.Drawing.Point(509, 83);
            this.fld_dtePMProjectActualStartDate.Name = "fld_dtePMProjectActualStartDate";
            this.fld_dtePMProjectActualStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectActualStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectActualStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectActualStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectActualStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectActualStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectActualStartDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectActualStartDate, true);
            this.fld_dtePMProjectActualStartDate.Size = new System.Drawing.Size(151, 20);
            this.fld_dtePMProjectActualStartDate.TabIndex = 8;
            this.fld_dtePMProjectActualStartDate.Tag = "DC";
            this.fld_dtePMProjectActualStartDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dtePMProjectActualStartDate_CloseUp);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
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
            this.bosLabel6.Location = new System.Drawing.Point(411, 164);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(20, 13);
            this.bosLabel6.TabIndex = 135;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Đến";
            // 
            // fld_dtePMProjectEstimatedEndDate
            // 
            this.fld_dtePMProjectEstimatedEndDate.BOSComment = "";
            this.fld_dtePMProjectEstimatedEndDate.BOSDataMember = "PMProjectEstimatedEndDate";
            this.fld_dtePMProjectEstimatedEndDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectEstimatedEndDate.BOSDescription = null;
            this.fld_dtePMProjectEstimatedEndDate.BOSError = null;
            this.fld_dtePMProjectEstimatedEndDate.BOSFieldGroup = "";
            this.fld_dtePMProjectEstimatedEndDate.BOSFieldRelation = "";
            this.fld_dtePMProjectEstimatedEndDate.BOSPrivilege = "";
            this.fld_dtePMProjectEstimatedEndDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectEstimatedEndDate.EditValue = null;
            this.fld_dtePMProjectEstimatedEndDate.Location = new System.Drawing.Point(509, 161);
            this.fld_dtePMProjectEstimatedEndDate.Name = "fld_dtePMProjectEstimatedEndDate";
            this.fld_dtePMProjectEstimatedEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectEstimatedEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectEstimatedEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectEstimatedEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectEstimatedEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectEstimatedEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectEstimatedEndDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectEstimatedEndDate, true);
            this.fld_dtePMProjectEstimatedEndDate.Size = new System.Drawing.Size(151, 20);
            this.fld_dtePMProjectEstimatedEndDate.TabIndex = 15;
            this.fld_dtePMProjectEstimatedEndDate.Tag = "DC";
            this.fld_dtePMProjectEstimatedEndDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dtePMProjectEstimatedEndDate_CloseUp);
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
            this.bosLabel4.Location = new System.Drawing.Point(127, 164);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(117, 13);
            this.bosLabel4.TabIndex = 133;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tiến độ dự án dự kiến từ";
            // 
            // fld_dtePMProjectEstimatedStartDate
            // 
            this.fld_dtePMProjectEstimatedStartDate.BOSComment = "";
            this.fld_dtePMProjectEstimatedStartDate.BOSDataMember = "PMProjectEstimatedStartDate";
            this.fld_dtePMProjectEstimatedStartDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectEstimatedStartDate.BOSDescription = null;
            this.fld_dtePMProjectEstimatedStartDate.BOSError = null;
            this.fld_dtePMProjectEstimatedStartDate.BOSFieldGroup = "";
            this.fld_dtePMProjectEstimatedStartDate.BOSFieldRelation = "";
            this.fld_dtePMProjectEstimatedStartDate.BOSPrivilege = "";
            this.fld_dtePMProjectEstimatedStartDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectEstimatedStartDate.EditValue = null;
            this.fld_dtePMProjectEstimatedStartDate.Location = new System.Drawing.Point(250, 161);
            this.fld_dtePMProjectEstimatedStartDate.Name = "fld_dtePMProjectEstimatedStartDate";
            this.fld_dtePMProjectEstimatedStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectEstimatedStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectEstimatedStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectEstimatedStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectEstimatedStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectEstimatedStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectEstimatedStartDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectEstimatedStartDate, true);
            this.fld_dtePMProjectEstimatedStartDate.Size = new System.Drawing.Size(151, 20);
            this.fld_dtePMProjectEstimatedStartDate.TabIndex = 13;
            this.fld_dtePMProjectEstimatedStartDate.Tag = "DC";
            this.fld_dtePMProjectEstimatedStartDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dtePMProjectEstimatedStartDate_CloseUp);
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
            this.bosLabel2.Location = new System.Drawing.Point(127, 138);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(73, 13);
            this.bosLabel2.TabIndex = 131;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Người giới thiệu";
            // 
            // fld_lkeFK_HRProjectOwnerEmployeeID
            // 
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSComment = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSDataMember = "FK_HRProjectOwnerEmployeeID";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSDataSource = "PMProjects";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSError = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Location = new System.Drawing.Point(249, 109);
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Name = "fld_lkeFK_HRProjectOwnerEmployeeID";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRProjectOwnerEmployeeID, true);
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_HRProjectOwnerEmployeeID.TabIndex = 10;
            this.fld_lkeFK_HRProjectOwnerEmployeeID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(127, 112);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(66, 13);
            this.bosLabel1.TabIndex = 128;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Quản lý dự án";
            // 
            // fld_lkePMProjectStatus
            // 
            this.fld_lkePMProjectStatus.BOSAllowAddNew = false;
            this.fld_lkePMProjectStatus.BOSAllowDummy = false;
            this.fld_lkePMProjectStatus.BOSComment = "";
            this.fld_lkePMProjectStatus.BOSDataMember = "PMProjectStatus";
            this.fld_lkePMProjectStatus.BOSDataSource = "PMProjects";
            this.fld_lkePMProjectStatus.BOSDescription = null;
            this.fld_lkePMProjectStatus.BOSError = null;
            this.fld_lkePMProjectStatus.BOSFieldGroup = "";
            this.fld_lkePMProjectStatus.BOSFieldParent = "";
            this.fld_lkePMProjectStatus.BOSFieldRelation = "";
            this.fld_lkePMProjectStatus.BOSPrivilege = "";
            this.fld_lkePMProjectStatus.BOSPropertyName = "EditValue";
            this.fld_lkePMProjectStatus.BOSSelectType = "";
            this.fld_lkePMProjectStatus.BOSSelectTypeValue = "";
            this.fld_lkePMProjectStatus.CurrentDisplayText = null;
            this.fld_lkePMProjectStatus.Location = new System.Drawing.Point(734, 31);
            this.fld_lkePMProjectStatus.Name = "fld_lkePMProjectStatus";
            this.fld_lkePMProjectStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkePMProjectStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePMProjectStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePMProjectStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePMProjectStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePMProjectStatus.Properties.ColumnName = null;
            this.fld_lkePMProjectStatus.Properties.NullText = "";
            this.fld_lkePMProjectStatus.Properties.ReadOnly = true;
            this.fld_lkePMProjectStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePMProjectStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkePMProjectStatus, true);
            this.fld_lkePMProjectStatus.Size = new System.Drawing.Size(180, 20);
            this.fld_lkePMProjectStatus.TabIndex = 4;
            this.fld_lkePMProjectStatus.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(680, 34);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 127;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = "";
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "PMProjects";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(508, 31);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", "Tên Loại dự án", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 3;
            this.fld_lkeFK_PMProjectTypeID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(413, 34);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(50, 13);
            this.bosLabel3.TabIndex = 126;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại dự án";
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
            this.bosLabel5.Location = new System.Drawing.Point(127, 86);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(43, 13);
            this.bosLabel5.TabIndex = 124;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngày tạo";
            // 
            // fld_dtePMProjectDate
            // 
            this.fld_dtePMProjectDate.BOSComment = "";
            this.fld_dtePMProjectDate.BOSDataMember = "PMProjectDate";
            this.fld_dtePMProjectDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectDate.BOSDescription = null;
            this.fld_dtePMProjectDate.BOSError = null;
            this.fld_dtePMProjectDate.BOSFieldGroup = "";
            this.fld_dtePMProjectDate.BOSFieldRelation = "";
            this.fld_dtePMProjectDate.BOSPrivilege = "";
            this.fld_dtePMProjectDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectDate.EditValue = null;
            this.fld_dtePMProjectDate.Location = new System.Drawing.Point(249, 83);
            this.fld_dtePMProjectDate.Name = "fld_dtePMProjectDate";
            this.fld_dtePMProjectDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectDate, true);
            this.fld_dtePMProjectDate.Size = new System.Drawing.Size(151, 20);
            this.fld_dtePMProjectDate.TabIndex = 7;
            this.fld_dtePMProjectDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "PMProjects";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(6, 131);
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
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(99, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(127, 34);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(45, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã dự án";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(127, 60);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên dự án";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(127, 215);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_txtPMProjectNo1
            // 
            this.fld_txtPMProjectNo1.BOSComment = "";
            this.fld_txtPMProjectNo1.BOSDataMember = "PMProjectNo";
            this.fld_txtPMProjectNo1.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectNo1.BOSDescription = null;
            this.fld_txtPMProjectNo1.BOSError = "Mã dự án không thể rỗng.";
            this.fld_txtPMProjectNo1.BOSFieldGroup = "";
            this.fld_txtPMProjectNo1.BOSFieldRelation = "";
            this.fld_txtPMProjectNo1.BOSPrivilege = "";
            this.fld_txtPMProjectNo1.BOSPropertyName = "Text";
            this.fld_txtPMProjectNo1.Location = new System.Drawing.Point(250, 31);
            this.fld_txtPMProjectNo1.Name = "fld_txtPMProjectNo1";
            this.fld_txtPMProjectNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectNo1.Screen = null;
            this.fld_txtPMProjectNo1.Size = new System.Drawing.Size(151, 20);
            this.fld_txtPMProjectNo1.TabIndex = 2;
            this.fld_txtPMProjectNo1.Tag = "DC";
            // 
            // fld_txtPMProjectName1
            // 
            this.fld_txtPMProjectName1.BOSComment = "";
            this.fld_txtPMProjectName1.BOSDataMember = "PMProjectName";
            this.fld_txtPMProjectName1.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectName1.BOSDescription = null;
            this.fld_txtPMProjectName1.BOSError = "Tên dự án không thể rỗng";
            this.fld_txtPMProjectName1.BOSFieldGroup = "";
            this.fld_txtPMProjectName1.BOSFieldRelation = "";
            this.fld_txtPMProjectName1.BOSPrivilege = "";
            this.fld_txtPMProjectName1.BOSPropertyName = "Text";
            this.fld_txtPMProjectName1.Location = new System.Drawing.Point(250, 57);
            this.fld_txtPMProjectName1.Name = "fld_txtPMProjectName1";
            this.fld_txtPMProjectName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectName1.Screen = null;
            this.fld_txtPMProjectName1.Size = new System.Drawing.Size(409, 20);
            this.fld_txtPMProjectName1.TabIndex = 5;
            this.fld_txtPMProjectName1.Tag = "DC";
            // 
            // fld_medPMProjectInfo
            // 
            this.fld_medPMProjectInfo.BOSComment = "";
            this.fld_medPMProjectInfo.BOSDataMember = "PMProjectInfo";
            this.fld_medPMProjectInfo.BOSDataSource = "PMProjects";
            this.fld_medPMProjectInfo.BOSDescription = null;
            this.fld_medPMProjectInfo.BOSError = "";
            this.fld_medPMProjectInfo.BOSFieldGroup = "";
            this.fld_medPMProjectInfo.BOSFieldRelation = "";
            this.fld_medPMProjectInfo.BOSPrivilege = "";
            this.fld_medPMProjectInfo.BOSPropertyName = "Text";
            this.fld_medPMProjectInfo.Location = new System.Drawing.Point(250, 213);
            this.fld_medPMProjectInfo.Name = "fld_medPMProjectInfo";
            this.fld_medPMProjectInfo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medPMProjectInfo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medPMProjectInfo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medPMProjectInfo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medPMProjectInfo.Screen = null;
            this.fld_medPMProjectInfo.Size = new System.Drawing.Size(409, 46);
            this.fld_medPMProjectInfo.TabIndex = 17;
            this.fld_medPMProjectInfo.Tag = "DC";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl3.Appearance.Options.UseBackColor = true;
            this.bosGroupControl3.BOSComment = "";
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = "";
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = "";
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_lkeARProspectCustomerBusiness);
            this.bosGroupControl3.Controls.Add(this.fld_txtARProspectCustomerName);
            this.bosGroupControl3.Controls.Add(this.bosLabel27);
            this.bosGroupControl3.Controls.Add(this.fld_txtARProspectCustomerCompany);
            this.bosGroupControl3.Controls.Add(this.bosLabel22);
            this.bosGroupControl3.Controls.Add(this.fld_txtARProspectCustomerTel);
            this.bosGroupControl3.Controls.Add(this.bosLabel23);
            this.bosGroupControl3.Controls.Add(this.bosLabel24);
            this.bosGroupControl3.Controls.Add(this.bosLabel25);
            this.bosGroupControl3.Controls.Add(this.bosLabel26);
            this.bosGroupControl3.Controls.Add(this.fld_txtARProspectCustomerEmail);
            this.bosGroupControl3.Controls.Add(this.fld_txtARProspectCustomerContactAddress);
            this.bosGroupControl3.Location = new System.Drawing.Point(3, 274);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(983, 118);
            this.bosGroupControl3.TabIndex = 144;
            this.bosGroupControl3.Text = "Thông tin khách hàng tiềm năng";
            // 
            // fld_lkeARProspectCustomerBusiness
            // 
            this.fld_lkeARProspectCustomerBusiness.BOSAllowAddNew = false;
            this.fld_lkeARProspectCustomerBusiness.BOSAllowDummy = false;
            this.fld_lkeARProspectCustomerBusiness.BOSComment = "";
            this.fld_lkeARProspectCustomerBusiness.BOSDataMember = "ARProspectCustomerBusiness";
            this.fld_lkeARProspectCustomerBusiness.BOSDataSource = "PMProjects";
            this.fld_lkeARProspectCustomerBusiness.BOSDescription = null;
            this.fld_lkeARProspectCustomerBusiness.BOSError = null;
            this.fld_lkeARProspectCustomerBusiness.BOSFieldGroup = "";
            this.fld_lkeARProspectCustomerBusiness.BOSFieldParent = "";
            this.fld_lkeARProspectCustomerBusiness.BOSFieldRelation = "";
            this.fld_lkeARProspectCustomerBusiness.BOSPrivilege = "";
            this.fld_lkeARProspectCustomerBusiness.BOSPropertyName = "EditValue";
            this.fld_lkeARProspectCustomerBusiness.BOSSelectType = "";
            this.fld_lkeARProspectCustomerBusiness.BOSSelectTypeValue = "";
            this.fld_lkeARProspectCustomerBusiness.CurrentDisplayText = null;
            this.fld_lkeARProspectCustomerBusiness.Location = new System.Drawing.Point(706, 83);
            this.fld_lkeARProspectCustomerBusiness.Name = "fld_lkeARProspectCustomerBusiness";
            this.fld_lkeARProspectCustomerBusiness.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARProspectCustomerBusiness.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARProspectCustomerBusiness.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProspectCustomerBusiness.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARProspectCustomerBusiness.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProspectCustomerBusiness.Properties.ColumnName = null;
            this.fld_lkeARProspectCustomerBusiness.Properties.NullText = "";
            this.fld_lkeARProspectCustomerBusiness.Properties.ReadOnly = true;
            this.fld_lkeARProspectCustomerBusiness.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProspectCustomerBusiness.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARProspectCustomerBusiness, true);
            this.fld_lkeARProspectCustomerBusiness.Size = new System.Drawing.Size(180, 20);
            this.fld_lkeARProspectCustomerBusiness.TabIndex = 5;
            this.fld_lkeARProspectCustomerBusiness.Tag = "DC";
            // 
            // fld_txtARProspectCustomerName
            // 
            this.fld_txtARProspectCustomerName.BOSComment = "";
            this.fld_txtARProspectCustomerName.BOSDataMember = "ARProspectCustomerName";
            this.fld_txtARProspectCustomerName.BOSDataSource = "PMProjects";
            this.fld_txtARProspectCustomerName.BOSDescription = null;
            this.fld_txtARProspectCustomerName.BOSError = "";
            this.fld_txtARProspectCustomerName.BOSFieldGroup = "";
            this.fld_txtARProspectCustomerName.BOSFieldRelation = "";
            this.fld_txtARProspectCustomerName.BOSPrivilege = "";
            this.fld_txtARProspectCustomerName.BOSPropertyName = "Text";
            this.fld_txtARProspectCustomerName.Location = new System.Drawing.Point(125, 31);
            this.fld_txtARProspectCustomerName.Name = "fld_txtARProspectCustomerName";
            this.fld_txtARProspectCustomerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProspectCustomerName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProspectCustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProspectCustomerName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProspectCustomerName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProspectCustomerName.Properties.ReadOnly = true;
            this.fld_txtARProspectCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProspectCustomerName.Screen = null;
            this.fld_txtARProspectCustomerName.Size = new System.Drawing.Size(496, 20);
            this.fld_txtARProspectCustomerName.TabIndex = 0;
            this.fld_txtARProspectCustomerName.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(638, 86);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(48, 13);
            this.bosLabel27.TabIndex = 137;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Nghiệp vụ";
            // 
            // fld_txtARProspectCustomerCompany
            // 
            this.fld_txtARProspectCustomerCompany.BOSComment = "";
            this.fld_txtARProspectCustomerCompany.BOSDataMember = "ARProspectCustomerCompany";
            this.fld_txtARProspectCustomerCompany.BOSDataSource = "PMProjects";
            this.fld_txtARProspectCustomerCompany.BOSDescription = null;
            this.fld_txtARProspectCustomerCompany.BOSError = "";
            this.fld_txtARProspectCustomerCompany.BOSFieldGroup = "";
            this.fld_txtARProspectCustomerCompany.BOSFieldRelation = "";
            this.fld_txtARProspectCustomerCompany.BOSPrivilege = "";
            this.fld_txtARProspectCustomerCompany.BOSPropertyName = "Text";
            this.fld_txtARProspectCustomerCompany.Location = new System.Drawing.Point(125, 83);
            this.fld_txtARProspectCustomerCompany.Name = "fld_txtARProspectCustomerCompany";
            this.fld_txtARProspectCustomerCompany.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProspectCustomerCompany.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProspectCustomerCompany.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProspectCustomerCompany.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProspectCustomerCompany.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProspectCustomerCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProspectCustomerCompany.Screen = null;
            this.fld_txtARProspectCustomerCompany.Size = new System.Drawing.Size(496, 20);
            this.fld_txtARProspectCustomerCompany.TabIndex = 4;
            this.fld_txtARProspectCustomerCompany.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(638, 34);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(62, 13);
            this.bosLabel22.TabIndex = 135;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Số điện thoại";
            // 
            // fld_txtARProspectCustomerTel
            // 
            this.fld_txtARProspectCustomerTel.BOSComment = "";
            this.fld_txtARProspectCustomerTel.BOSDataMember = "ARProspectCustomerTel";
            this.fld_txtARProspectCustomerTel.BOSDataSource = "PMProjects";
            this.fld_txtARProspectCustomerTel.BOSDescription = null;
            this.fld_txtARProspectCustomerTel.BOSError = "";
            this.fld_txtARProspectCustomerTel.BOSFieldGroup = "";
            this.fld_txtARProspectCustomerTel.BOSFieldRelation = "";
            this.fld_txtARProspectCustomerTel.BOSPrivilege = "";
            this.fld_txtARProspectCustomerTel.BOSPropertyName = "Text";
            this.fld_txtARProspectCustomerTel.Location = new System.Drawing.Point(706, 31);
            this.fld_txtARProspectCustomerTel.Name = "fld_txtARProspectCustomerTel";
            this.fld_txtARProspectCustomerTel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProspectCustomerTel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProspectCustomerTel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProspectCustomerTel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProspectCustomerTel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProspectCustomerTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProspectCustomerTel.Screen = null;
            this.fld_txtARProspectCustomerTel.Size = new System.Drawing.Size(180, 20);
            this.fld_txtARProspectCustomerTel.TabIndex = 1;
            this.fld_txtARProspectCustomerTel.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
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
            this.bosLabel23.Location = new System.Drawing.Point(15, 86);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(38, 13);
            this.bosLabel23.TabIndex = 132;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Công ty";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseFont = true;
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
            this.bosLabel24.Location = new System.Drawing.Point(15, 34);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(79, 13);
            this.bosLabel24.TabIndex = 126;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Tên khách hàng";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(638, 60);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(58, 13);
            this.bosLabel25.TabIndex = 6;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Email liên hệ";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = "";
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = "";
            this.bosLabel26.BOSFieldRelation = "";
            this.bosLabel26.BOSPrivilege = "";
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(15, 60);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(32, 13);
            this.bosLabel26.TabIndex = 7;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Địa chỉ";
            // 
            // fld_txtARProspectCustomerEmail
            // 
            this.fld_txtARProspectCustomerEmail.BOSComment = "";
            this.fld_txtARProspectCustomerEmail.BOSDataMember = "ARProspectCustomerEmail";
            this.fld_txtARProspectCustomerEmail.BOSDataSource = "PMProjects";
            this.fld_txtARProspectCustomerEmail.BOSDescription = null;
            this.fld_txtARProspectCustomerEmail.BOSError = "";
            this.fld_txtARProspectCustomerEmail.BOSFieldGroup = "";
            this.fld_txtARProspectCustomerEmail.BOSFieldRelation = "";
            this.fld_txtARProspectCustomerEmail.BOSPrivilege = "";
            this.fld_txtARProspectCustomerEmail.BOSPropertyName = "Text";
            this.fld_txtARProspectCustomerEmail.Location = new System.Drawing.Point(706, 57);
            this.fld_txtARProspectCustomerEmail.Name = "fld_txtARProspectCustomerEmail";
            this.fld_txtARProspectCustomerEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProspectCustomerEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProspectCustomerEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProspectCustomerEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProspectCustomerEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProspectCustomerEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProspectCustomerEmail.Screen = null;
            this.fld_txtARProspectCustomerEmail.Size = new System.Drawing.Size(180, 20);
            this.fld_txtARProspectCustomerEmail.TabIndex = 3;
            this.fld_txtARProspectCustomerEmail.Tag = "DC";
            // 
            // fld_txtARProspectCustomerContactAddress
            // 
            this.fld_txtARProspectCustomerContactAddress.BOSComment = "";
            this.fld_txtARProspectCustomerContactAddress.BOSDataMember = "ARProspectCustomerContactAddress";
            this.fld_txtARProspectCustomerContactAddress.BOSDataSource = "PMProjects";
            this.fld_txtARProspectCustomerContactAddress.BOSDescription = null;
            this.fld_txtARProspectCustomerContactAddress.BOSError = "";
            this.fld_txtARProspectCustomerContactAddress.BOSFieldGroup = "";
            this.fld_txtARProspectCustomerContactAddress.BOSFieldRelation = "";
            this.fld_txtARProspectCustomerContactAddress.BOSPrivilege = "";
            this.fld_txtARProspectCustomerContactAddress.BOSPropertyName = "Text";
            this.fld_txtARProspectCustomerContactAddress.Location = new System.Drawing.Point(125, 57);
            this.fld_txtARProspectCustomerContactAddress.Name = "fld_txtARProspectCustomerContactAddress";
            this.fld_txtARProspectCustomerContactAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProspectCustomerContactAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProspectCustomerContactAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProspectCustomerContactAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProspectCustomerContactAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProspectCustomerContactAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProspectCustomerContactAddress.Screen = null;
            this.fld_txtARProspectCustomerContactAddress.Size = new System.Drawing.Size(496, 20);
            this.fld_txtARProspectCustomerContactAddress.TabIndex = 2;
            this.fld_txtARProspectCustomerContactAddress.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl2.Appearance.Options.UseBackColor = true;
            this.bosGroupControl2.BOSComment = "";
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = "";
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = "";
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_btnEditLocation);
            this.bosGroupControl2.Controls.Add(this.fld_btnDeleteLocation);
            this.bosGroupControl2.Controls.Add(this.fld_btnAddLocation);
            this.bosGroupControl2.Controls.Add(this.fld_dgcProjectLocationsGridControl);
            this.bosGroupControl2.Controls.Add(this.fld_bedPMProjectLocationName);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_GEStateProvinceID);
            this.bosGroupControl2.Controls.Add(this.bosLabel13);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_FK_GEDistrictID);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.bosLabel10);
            this.bosGroupControl2.Controls.Add(this.bosLabel12);
            this.bosGroupControl2.Controls.Add(this.fld_txtPMProjectLocationAddress);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, -1);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(983, 244);
            this.bosGroupControl2.TabIndex = 2;
            this.bosGroupControl2.Text = "Thông tin địa chỉ dự án";
            // 
            // fld_btnEditLocation
            // 
            this.fld_btnEditLocation.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEditLocation.Appearance.Options.UseForeColor = true;
            this.fld_btnEditLocation.BOSComment = "";
            this.fld_btnEditLocation.BOSDataMember = null;
            this.fld_btnEditLocation.BOSDataSource = null;
            this.fld_btnEditLocation.BOSDescription = null;
            this.fld_btnEditLocation.BOSError = null;
            this.fld_btnEditLocation.BOSFieldGroup = "";
            this.fld_btnEditLocation.BOSFieldRelation = "";
            this.fld_btnEditLocation.BOSPrivilege = "";
            this.fld_btnEditLocation.BOSPropertyName = null;
            this.fld_btnEditLocation.Location = new System.Drawing.Point(779, 55);
            this.fld_btnEditLocation.Name = "fld_btnEditLocation";
            this.fld_btnEditLocation.Screen = null;
            this.fld_btnEditLocation.Size = new System.Drawing.Size(75, 26);
            this.fld_btnEditLocation.TabIndex = 5;
            this.fld_btnEditLocation.Tag = "";
            this.fld_btnEditLocation.Text = "Sửa";
            this.fld_btnEditLocation.Click += new System.EventHandler(this.fld_btnEditLocation_Click);
            // 
            // fld_btnDeleteLocation
            // 
            this.fld_btnDeleteLocation.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeleteLocation.Appearance.Options.UseForeColor = true;
            this.fld_btnDeleteLocation.BOSComment = "";
            this.fld_btnDeleteLocation.BOSDataMember = null;
            this.fld_btnDeleteLocation.BOSDataSource = null;
            this.fld_btnDeleteLocation.BOSDescription = null;
            this.fld_btnDeleteLocation.BOSError = null;
            this.fld_btnDeleteLocation.BOSFieldGroup = "";
            this.fld_btnDeleteLocation.BOSFieldRelation = "";
            this.fld_btnDeleteLocation.BOSPrivilege = "DeleteCategory";
            this.fld_btnDeleteLocation.BOSPropertyName = null;
            this.fld_btnDeleteLocation.Location = new System.Drawing.Point(861, 54);
            this.fld_btnDeleteLocation.Name = "fld_btnDeleteLocation";
            this.fld_btnDeleteLocation.Screen = null;
            this.fld_btnDeleteLocation.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteLocation.TabIndex = 6;
            this.fld_btnDeleteLocation.Tag = "";
            this.fld_btnDeleteLocation.Text = "Xóa";
            this.fld_btnDeleteLocation.Click += new System.EventHandler(this.fld_btnDeleteLocation_Click);
            // 
            // fld_btnAddLocation
            // 
            this.fld_btnAddLocation.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddLocation.Appearance.Options.UseForeColor = true;
            this.fld_btnAddLocation.BOSComment = "";
            this.fld_btnAddLocation.BOSDataMember = null;
            this.fld_btnAddLocation.BOSDataSource = null;
            this.fld_btnAddLocation.BOSDescription = null;
            this.fld_btnAddLocation.BOSError = null;
            this.fld_btnAddLocation.BOSFieldGroup = "";
            this.fld_btnAddLocation.BOSFieldRelation = "";
            this.fld_btnAddLocation.BOSPrivilege = "";
            this.fld_btnAddLocation.BOSPropertyName = null;
            this.fld_btnAddLocation.Location = new System.Drawing.Point(698, 56);
            this.fld_btnAddLocation.Name = "fld_btnAddLocation";
            this.fld_btnAddLocation.Screen = null;
            this.fld_btnAddLocation.Size = new System.Drawing.Size(75, 25);
            this.fld_btnAddLocation.TabIndex = 4;
            this.fld_btnAddLocation.Tag = "";
            this.fld_btnAddLocation.Text = "Thêm";
            this.fld_btnAddLocation.Click += new System.EventHandler(this.fld_btnAddLocation_Click);
            // 
            // fld_dgcProjectLocationsGridControl
            // 
            this.fld_dgcProjectLocationsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProjectLocationsGridControl.BOSComment = null;
            this.fld_dgcProjectLocationsGridControl.BOSDataMember = null;
            this.fld_dgcProjectLocationsGridControl.BOSDataSource = "PMProjectLocations";
            this.fld_dgcProjectLocationsGridControl.BOSDescription = null;
            this.fld_dgcProjectLocationsGridControl.BOSError = null;
            this.fld_dgcProjectLocationsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectLocationsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectLocationsGridControl.BOSGridType = null;
            this.fld_dgcProjectLocationsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectLocationsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectLocationsGridControl.CommodityType = "";
            this.fld_dgcProjectLocationsGridControl.Location = new System.Drawing.Point(15, 87);
            this.fld_dgcProjectLocationsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectLocationsGridControl.Name = "fld_dgcProjectLocationsGridControl";
            this.fld_dgcProjectLocationsGridControl.PrintReport = false;
            this.fld_dgcProjectLocationsGridControl.Screen = null;
            this.fld_dgcProjectLocationsGridControl.Size = new System.Drawing.Size(968, 148);
            this.fld_dgcProjectLocationsGridControl.TabIndex = 5;
            // 
            // fld_bedPMProjectLocationName
            // 
            this.fld_bedPMProjectLocationName.BOSComment = null;
            this.fld_bedPMProjectLocationName.BOSDataMember = "PMProjectLocationName";
            this.fld_bedPMProjectLocationName.BOSDataSource = "PMProjectLocations";
            this.fld_bedPMProjectLocationName.BOSDescription = null;
            this.fld_bedPMProjectLocationName.BOSError = null;
            this.fld_bedPMProjectLocationName.BOSFieldGroup = null;
            this.fld_bedPMProjectLocationName.BOSFieldRelation = null;
            this.fld_bedPMProjectLocationName.BOSPrivilege = null;
            this.fld_bedPMProjectLocationName.BOSPropertyName = "Text";
            this.fld_bedPMProjectLocationName.Location = new System.Drawing.Point(698, 28);
            this.fld_bedPMProjectLocationName.MenuManager = this.screenToolbar;
            this.fld_bedPMProjectLocationName.Name = "fld_bedPMProjectLocationName";
            this.fld_bedPMProjectLocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedPMProjectLocationName.Properties.ReadOnly = true;
            this.fld_bedPMProjectLocationName.Screen = null;
            this.fld_bedPMProjectLocationName.Size = new System.Drawing.Size(260, 20);
            this.fld_bedPMProjectLocationName.TabIndex = 1;
            this.fld_bedPMProjectLocationName.Tag = "DC";
            this.fld_bedPMProjectLocationName.Click += new System.EventHandler(this.fld_bedGELocationName_Click);
            // 
            // fld_lkeFK_GEStateProvinceID
            // 
            this.fld_lkeFK_GEStateProvinceID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEStateProvinceID.BOSAllowDummy = true;
            this.fld_lkeFK_GEStateProvinceID.BOSComment = "";
            this.fld_lkeFK_GEStateProvinceID.BOSDataMember = "FK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.BOSDataSource = "PMProjectLocations";
            this.fld_lkeFK_GEStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GEStateProvinceID.BOSError = null;
            this.fld_lkeFK_GEStateProvinceID.BOSFieldGroup = "";
            this.fld_lkeFK_GEStateProvinceID.BOSFieldParent = "";
            this.fld_lkeFK_GEStateProvinceID.BOSFieldRelation = "";
            this.fld_lkeFK_GEStateProvinceID.BOSPrivilege = "";
            this.fld_lkeFK_GEStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEStateProvinceID.BOSSelectType = "";
            this.fld_lkeFK_GEStateProvinceID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEStateProvinceID.CurrentDisplayText = null;
            this.fld_lkeFK_GEStateProvinceID.Location = new System.Drawing.Point(125, 54);
            this.fld_lkeFK_GEStateProvinceID.Name = "fld_lkeFK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GEStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", "Tỉnh (Thành phố)", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEStateProvinceID.Properties.NullText = "";
            this.fld_lkeFK_GEStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Screen = null;
            this.fld_lkeFK_GEStateProvinceID.Size = new System.Drawing.Size(241, 20);
            this.fld_lkeFK_GEStateProvinceID.TabIndex = 2;
            this.fld_lkeFK_GEStateProvinceID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(14, 57);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(78, 13);
            this.bosLabel13.TabIndex = 130;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Tỉnh (thành phố)";
            // 
            // fld_lkeFK_FK_GEDistrictID
            // 
            this.fld_lkeFK_FK_GEDistrictID.BOSAllowAddNew = false;
            this.fld_lkeFK_FK_GEDistrictID.BOSAllowDummy = true;
            this.fld_lkeFK_FK_GEDistrictID.BOSComment = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSDataMember = "FK_GEDistrictID";
            this.fld_lkeFK_FK_GEDistrictID.BOSDataSource = "PMProjectLocations";
            this.fld_lkeFK_FK_GEDistrictID.BOSDescription = null;
            this.fld_lkeFK_FK_GEDistrictID.BOSError = null;
            this.fld_lkeFK_FK_GEDistrictID.BOSFieldGroup = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSFieldParent = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSFieldRelation = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSPrivilege = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_FK_GEDistrictID.BOSSelectType = "";
            this.fld_lkeFK_FK_GEDistrictID.BOSSelectTypeValue = "";
            this.fld_lkeFK_FK_GEDistrictID.CurrentDisplayText = null;
            this.fld_lkeFK_FK_GEDistrictID.Location = new System.Drawing.Point(470, 54);
            this.fld_lkeFK_FK_GEDistrictID.Name = "fld_lkeFK_FK_GEDistrictID";
            this.fld_lkeFK_FK_GEDistrictID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_FK_GEDistrictID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_FK_GEDistrictID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_FK_GEDistrictID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_FK_GEDistrictID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_FK_GEDistrictID.Properties.ColumnName = null;
            this.fld_lkeFK_FK_GEDistrictID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEDistrictName", "Quận (Huyện)", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_FK_GEDistrictID.Properties.DisplayMember = "GEDistrictName";
            this.fld_lkeFK_FK_GEDistrictID.Properties.NullText = "";
            this.fld_lkeFK_FK_GEDistrictID.Properties.PopupWidth = 40;
            this.fld_lkeFK_FK_GEDistrictID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_FK_GEDistrictID.Properties.ValueMember = "GEDistrictID";
            this.fld_lkeFK_FK_GEDistrictID.Screen = null;
            this.fld_lkeFK_FK_GEDistrictID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_FK_GEDistrictID.TabIndex = 3;
            this.fld_lkeFK_FK_GEDistrictID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(372, 57);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(64, 13);
            this.bosLabel9.TabIndex = 128;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Quận (huyện)";
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
            this.bosLabel10.Location = new System.Drawing.Point(15, 25);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(63, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Địa chỉ dự án";
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
            this.bosLabel12.Location = new System.Drawing.Point(638, 31);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(21, 13);
            this.bosLabel12.TabIndex = 7;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Vị trí";
            // 
            // fld_txtPMProjectLocationAddress
            // 
            this.fld_txtPMProjectLocationAddress.BOSComment = "";
            this.fld_txtPMProjectLocationAddress.BOSDataMember = "PMProjectLocationAddress";
            this.fld_txtPMProjectLocationAddress.BOSDataSource = "PMProjectLocations";
            this.fld_txtPMProjectLocationAddress.BOSDescription = null;
            this.fld_txtPMProjectLocationAddress.BOSError = "";
            this.fld_txtPMProjectLocationAddress.BOSFieldGroup = "";
            this.fld_txtPMProjectLocationAddress.BOSFieldRelation = "";
            this.fld_txtPMProjectLocationAddress.BOSPrivilege = "";
            this.fld_txtPMProjectLocationAddress.BOSPropertyName = "Text";
            this.fld_txtPMProjectLocationAddress.Location = new System.Drawing.Point(125, 28);
            this.fld_txtPMProjectLocationAddress.Name = "fld_txtPMProjectLocationAddress";
            this.fld_txtPMProjectLocationAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectLocationAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectLocationAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectLocationAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectLocationAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectLocationAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectLocationAddress.Screen = null;
            this.fld_txtPMProjectLocationAddress.Size = new System.Drawing.Size(496, 20);
            this.fld_txtPMProjectLocationAddress.TabIndex = 0;
            this.fld_txtPMProjectLocationAddress.Tag = "DC";
            // 
            // DMPM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(989, 741);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPM100";
            this.ShowIcon = false;
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptePMProjectEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectActualTotalDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectEstimatedTotalDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMProjectPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectActualStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectEstimatedStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProjectOwnerEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePMProjectStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMProjectInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProspectCustomerBusiness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProspectCustomerContactAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectLocationsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedPMProjectLocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_FK_GEDistrictID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectLocationAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactPhone;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactEmail1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactAddressLine1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSTextBox fld_txtPMProjectActualTotalDays;
        private BOSComponent.BOSTextBox fld_txtPMProjectEstimatedTotalDays;
        private BOSComponent.BOSLookupEdit fld_lkePMProjectPriority;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dtePMProjectActualEndDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSDateEdit fld_dtePMProjectActualStartDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dtePMProjectEstimatedEndDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dtePMProjectEstimatedStartDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRProjectOwnerEmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkePMProjectStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dtePMProjectDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtPMProjectNo1;
        private BOSComponent.BOSTextBox fld_txtPMProjectName1;
        private BOSComponent.BOSMemoEdit fld_medPMProjectInfo;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private BOSComponent.BOSLookupEdit fld_lkeARProspectCustomerBusiness;
        private BOSComponent.BOSTextBox fld_txtARProspectCustomerName;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSTextBox fld_txtARProspectCustomerCompany;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtARProspectCustomerTel;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtARProspectCustomerEmail;
        private BOSComponent.BOSTextBox fld_txtARProspectCustomerContactAddress;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton fld_btnEditLocation;
        private BOSComponent.BOSButton fld_btnDeleteLocation;
        private BOSComponent.BOSButton fld_btnAddLocation;
        private ProjectLocationsGridControl fld_dgcProjectLocationsGridControl;
        private BOSComponent.BOSButtonEdit fld_bedPMProjectLocationName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEStateProvinceID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_FK_GEDistrictID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtPMProjectLocationAddress;
        private BOSComponent.BOSPictureEdit fld_ptePMProjectEmployeePicture;
        private AccObjectLookupEdit accObjectLookupEdit1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSButton fld_btnAddCustomers;
    }
}
