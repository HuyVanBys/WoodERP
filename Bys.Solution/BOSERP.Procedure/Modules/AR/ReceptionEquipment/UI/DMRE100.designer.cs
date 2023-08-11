using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReceptionEquipment.UI
{
    partial class DMRE100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteARReceptionEmployeePicture;


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
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARReceptionEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteARReceptionDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARReceptionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARReceptionDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ACEquipmentStateID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARReceptionType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDriverEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARReceptionExpediencyQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRReturnEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARReceptionStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARReceptionItemsGridControl = new BOSERP.Modules.ReceptionEquipment.ARReceptionItemsGridControl();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARReceptionName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARReceptionEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceptionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceptionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARReceptionDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEquipmentStateID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceptionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDriverEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionExpediencyQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRReturnEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceptionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceptionItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionName.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARReceptions";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
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
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteARReceptionEmployeePicture
            // 
            this.fld_pteARReceptionEmployeePicture.BOSComment = "";
            this.fld_pteARReceptionEmployeePicture.BOSDataMember = "ARReceptionEmployeePicture";
            this.fld_pteARReceptionEmployeePicture.BOSDataSource = "ARReceptions";
            this.fld_pteARReceptionEmployeePicture.BOSDescription = null;
            this.fld_pteARReceptionEmployeePicture.BOSError = "";
            this.fld_pteARReceptionEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARReceptionEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARReceptionEmployeePicture.BOSPrivilege = "";
            this.fld_pteARReceptionEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARReceptionEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARReceptionEmployeePicture.FileName = null;
            this.fld_pteARReceptionEmployeePicture.FilePath = null;
            this.fld_pteARReceptionEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARReceptionEmployeePicture.Name = "fld_pteARReceptionEmployeePicture";
            this.fld_pteARReceptionEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARReceptionEmployeePicture.Screen = null;
            this.fld_pteARReceptionEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARReceptionEmployeePicture.TabIndex = 0;
            this.fld_pteARReceptionEmployeePicture.Tag = "DC";
            // 
            // fld_dteARReceptionDate
            // 
            this.fld_dteARReceptionDate.BOSComment = null;
            this.fld_dteARReceptionDate.BOSDataMember = "ARReceptionDate";
            this.fld_dteARReceptionDate.BOSDataSource = "ARReceptions";
            this.fld_dteARReceptionDate.BOSDescription = null;
            this.fld_dteARReceptionDate.BOSError = null;
            this.fld_dteARReceptionDate.BOSFieldGroup = null;
            this.fld_dteARReceptionDate.BOSFieldRelation = null;
            this.fld_dteARReceptionDate.BOSPrivilege = null;
            this.fld_dteARReceptionDate.BOSPropertyName = "EditValue";
            this.fld_dteARReceptionDate.EditValue = null;
            this.fld_dteARReceptionDate.Location = new System.Drawing.Point(218, 64);
            this.fld_dteARReceptionDate.MenuManager = this.screenToolbar;
            this.fld_dteARReceptionDate.Name = "fld_dteARReceptionDate";
            this.fld_dteARReceptionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARReceptionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARReceptionDate.Screen = null;
            this.fld_dteARReceptionDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteARReceptionDate.TabIndex = 3;
            this.fld_dteARReceptionDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(136, 67);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
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
            this.bosLabel2.Location = new System.Drawing.Point(136, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtARReceptionNo
            // 
            this.fld_txtARReceptionNo.BOSComment = null;
            this.fld_txtARReceptionNo.BOSDataMember = "ARReceptionNo";
            this.fld_txtARReceptionNo.BOSDataSource = "ARReceptions";
            this.fld_txtARReceptionNo.BOSDescription = null;
            this.fld_txtARReceptionNo.BOSError = null;
            this.fld_txtARReceptionNo.BOSFieldGroup = null;
            this.fld_txtARReceptionNo.BOSFieldRelation = null;
            this.fld_txtARReceptionNo.BOSPrivilege = null;
            this.fld_txtARReceptionNo.BOSPropertyName = "EditValue";
            this.fld_txtARReceptionNo.Location = new System.Drawing.Point(218, 12);
            this.fld_txtARReceptionNo.MenuManager = this.screenToolbar;
            this.fld_txtARReceptionNo.Name = "fld_txtARReceptionNo";
            this.fld_txtARReceptionNo.Screen = null;
            this.fld_txtARReceptionNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARReceptionNo.TabIndex = 0;
            this.fld_txtARReceptionNo.Tag = "DC";
            // 
            // fld_medARReceptionDesc
            // 
            this.fld_medARReceptionDesc.BOSComment = null;
            this.fld_medARReceptionDesc.BOSDataMember = "ARReceptionDesc";
            this.fld_medARReceptionDesc.BOSDataSource = "ARReceptions";
            this.fld_medARReceptionDesc.BOSDescription = null;
            this.fld_medARReceptionDesc.BOSError = null;
            this.fld_medARReceptionDesc.BOSFieldGroup = null;
            this.fld_medARReceptionDesc.BOSFieldRelation = null;
            this.fld_medARReceptionDesc.BOSPrivilege = null;
            this.fld_medARReceptionDesc.BOSPropertyName = "EditValue";
            this.fld_medARReceptionDesc.Location = new System.Drawing.Point(218, 142);
            this.fld_medARReceptionDesc.MenuManager = this.screenToolbar;
            this.fld_medARReceptionDesc.Name = "fld_medARReceptionDesc";
            this.fld_medARReceptionDesc.Screen = null;
            this.fld_medARReceptionDesc.Size = new System.Drawing.Size(464, 33);
            this.fld_medARReceptionDesc.TabIndex = 8;
            this.fld_medARReceptionDesc.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACEquipmentStateID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeARReceptionType);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDriverEmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtARReceptionExpediencyQty);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRReturnEmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeARReceptionStatus);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtARReceptionName);
            this.bosPanel1.Controls.Add(this.fld_medARReceptionDesc);
            this.bosPanel1.Controls.Add(this.fld_pteARReceptionEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARReceptionNo);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteARReceptionDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(714, 523);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ACEquipmentStateID
            // 
            this.fld_lkeFK_ACEquipmentStateID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEquipmentStateID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEquipmentStateID.BOSComment = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSDataMember = "FK_ACEquipmentStateID";
            this.fld_lkeFK_ACEquipmentStateID.BOSDataSource = "ARReceptions";
            this.fld_lkeFK_ACEquipmentStateID.BOSDescription = null;
            this.fld_lkeFK_ACEquipmentStateID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_ACEquipmentStateID.BOSFieldGroup = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSFieldParent = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSFieldRelation = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSPrivilege = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEquipmentStateID.BOSSelectType = "";
            this.fld_lkeFK_ACEquipmentStateID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACEquipmentStateID.CurrentDisplayText = "";
            this.fld_lkeFK_ACEquipmentStateID.Location = new System.Drawing.Point(511, 90);
            this.fld_lkeFK_ACEquipmentStateID.Name = "fld_lkeFK_ACEquipmentStateID";
            this.fld_lkeFK_ACEquipmentStateID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACEquipmentStateID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACEquipmentStateID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACEquipmentStateID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACEquipmentStateID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEquipmentStateID.Properties.ColumnName = null;
            this.fld_lkeFK_ACEquipmentStateID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEquipmentStateName", "Tình trạng")});
            this.fld_lkeFK_ACEquipmentStateID.Properties.DisplayMember = "ACEquipmentStateName";
            this.fld_lkeFK_ACEquipmentStateID.Properties.NullText = "";
            this.fld_lkeFK_ACEquipmentStateID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACEquipmentStateID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACEquipmentStateID.Properties.ValueMember = "ACEquipmentStateID";
            this.fld_lkeFK_ACEquipmentStateID.Screen = null;
            this.fld_lkeFK_ACEquipmentStateID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ACEquipmentStateID.TabIndex = 429;
            this.fld_lkeFK_ACEquipmentStateID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(417, 93);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(80, 13);
            this.bosLabel7.TabIndex = 428;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Tình trạng CCDC";
            // 
            // fld_lkeARReceptionType
            // 
            this.fld_lkeARReceptionType.BOSAllowAddNew = false;
            this.fld_lkeARReceptionType.BOSAllowDummy = false;
            this.fld_lkeARReceptionType.BOSComment = null;
            this.fld_lkeARReceptionType.BOSDataMember = "ARReceptionType";
            this.fld_lkeARReceptionType.BOSDataSource = "ARReceptions";
            this.fld_lkeARReceptionType.BOSDescription = null;
            this.fld_lkeARReceptionType.BOSError = null;
            this.fld_lkeARReceptionType.BOSFieldGroup = null;
            this.fld_lkeARReceptionType.BOSFieldParent = null;
            this.fld_lkeARReceptionType.BOSFieldRelation = null;
            this.fld_lkeARReceptionType.BOSPrivilege = null;
            this.fld_lkeARReceptionType.BOSPropertyName = "EditValue";
            this.fld_lkeARReceptionType.BOSSelectType = null;
            this.fld_lkeARReceptionType.BOSSelectTypeValue = null;
            this.fld_lkeARReceptionType.CurrentDisplayText = null;
            this.fld_lkeARReceptionType.Location = new System.Drawing.Point(218, 90);
            this.fld_lkeARReceptionType.MenuManager = this.screenToolbar;
            this.fld_lkeARReceptionType.Name = "fld_lkeARReceptionType";
            this.fld_lkeARReceptionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARReceptionType.Properties.ColumnName = null;
            this.fld_lkeARReceptionType.Properties.ReadOnly = true;
            this.fld_lkeARReceptionType.Screen = null;
            this.fld_lkeARReceptionType.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARReceptionType.TabIndex = 5;
            this.fld_lkeARReceptionType.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(136, 93);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel7.TabIndex = 426;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Loại";
            // 
            // fld_lkeFK_HRDriverEmployeeID
            // 
            this.fld_lkeFK_HRDriverEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDriverEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDriverEmployeeID.BOSComment = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSDataMember = "FK_HRDriverEmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.BOSDataSource = "ARReceptions";
            this.fld_lkeFK_HRDriverEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRDriverEmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDriverEmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HRDriverEmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRDriverEmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HRDriverEmployeeID.Location = new System.Drawing.Point(511, 116);
            this.fld_lkeFK_HRDriverEmployeeID.Name = "fld_lkeFK_HRDriverEmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDriverEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRDriverEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRDriverEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRDriverEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDriverEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRDriverEmployeeID.Screen = null;
            this.fld_lkeFK_HRDriverEmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRDriverEmployeeID.TabIndex = 7;
            this.fld_lkeFK_HRDriverEmployeeID.Tag = "DC";
            // 
            // fld_txtARReceptionExpediencyQty
            // 
            this.fld_txtARReceptionExpediencyQty.BOSComment = null;
            this.fld_txtARReceptionExpediencyQty.BOSDataMember = "ARReceptionExpediencyQty";
            this.fld_txtARReceptionExpediencyQty.BOSDataSource = "ARReceptions";
            this.fld_txtARReceptionExpediencyQty.BOSDescription = null;
            this.fld_txtARReceptionExpediencyQty.BOSError = null;
            this.fld_txtARReceptionExpediencyQty.BOSFieldGroup = null;
            this.fld_txtARReceptionExpediencyQty.BOSFieldRelation = null;
            this.fld_txtARReceptionExpediencyQty.BOSPrivilege = null;
            this.fld_txtARReceptionExpediencyQty.BOSPropertyName = "EditValue";
            this.fld_txtARReceptionExpediencyQty.Location = new System.Drawing.Point(218, 116);
            this.fld_txtARReceptionExpediencyQty.MenuManager = this.screenToolbar;
            this.fld_txtARReceptionExpediencyQty.Name = "fld_txtARReceptionExpediencyQty";
            this.fld_txtARReceptionExpediencyQty.Screen = null;
            this.fld_txtARReceptionExpediencyQty.Size = new System.Drawing.Size(171, 20);
            this.fld_txtARReceptionExpediencyQty.TabIndex = 6;
            this.fld_txtARReceptionExpediencyQty.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(417, 119);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 424;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tài xế";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(136, 123);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(73, 13);
            this.bosLabel5.TabIndex = 423;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Số phương tiện";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
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
            this.bosLabel4.Location = new System.Drawing.Point(417, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 422;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Người trả";
            // 
            // fld_lkeFK_HRReturnEmployeeID
            // 
            this.fld_lkeFK_HRReturnEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRReturnEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRReturnEmployeeID.BOSComment = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSDataMember = "FK_HRReturnEmployeeID";
            this.fld_lkeFK_HRReturnEmployeeID.BOSDataSource = "ARReceptions";
            this.fld_lkeFK_HRReturnEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRReturnEmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HRReturnEmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRReturnEmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HRReturnEmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRReturnEmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HRReturnEmployeeID.Location = new System.Drawing.Point(511, 12);
            this.fld_lkeFK_HRReturnEmployeeID.Name = "fld_lkeFK_HRReturnEmployeeID";
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRReturnEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRReturnEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRReturnEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRReturnEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRReturnEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRReturnEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRReturnEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRReturnEmployeeID.Screen = null;
            this.fld_lkeFK_HRReturnEmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRReturnEmployeeID.TabIndex = 1;
            this.fld_lkeFK_HRReturnEmployeeID.Tag = "DC";
            // 
            // fld_lkeARReceptionStatus
            // 
            this.fld_lkeARReceptionStatus.BOSAllowAddNew = false;
            this.fld_lkeARReceptionStatus.BOSAllowDummy = false;
            this.fld_lkeARReceptionStatus.BOSComment = null;
            this.fld_lkeARReceptionStatus.BOSDataMember = "ARReceptionStatus";
            this.fld_lkeARReceptionStatus.BOSDataSource = "ARReceptions";
            this.fld_lkeARReceptionStatus.BOSDescription = null;
            this.fld_lkeARReceptionStatus.BOSError = null;
            this.fld_lkeARReceptionStatus.BOSFieldGroup = null;
            this.fld_lkeARReceptionStatus.BOSFieldParent = null;
            this.fld_lkeARReceptionStatus.BOSFieldRelation = null;
            this.fld_lkeARReceptionStatus.BOSPrivilege = null;
            this.fld_lkeARReceptionStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARReceptionStatus.BOSSelectType = null;
            this.fld_lkeARReceptionStatus.BOSSelectTypeValue = null;
            this.fld_lkeARReceptionStatus.CurrentDisplayText = null;
            this.fld_lkeARReceptionStatus.Location = new System.Drawing.Point(511, 64);
            this.fld_lkeARReceptionStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARReceptionStatus.Name = "fld_lkeARReceptionStatus";
            this.fld_lkeARReceptionStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARReceptionStatus.Properties.ColumnName = null;
            this.fld_lkeARReceptionStatus.Properties.ReadOnly = true;
            this.fld_lkeARReceptionStatus.Screen = null;
            this.fld_lkeARReceptionStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeARReceptionStatus.TabIndex = 4;
            this.fld_lkeARReceptionStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 183);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(698, 328);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARReceptionItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(692, 300);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcARReceptionItemsGridControl
            // 
            this.fld_dgcARReceptionItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARReceptionItemsGridControl.BOSComment = null;
            this.fld_dgcARReceptionItemsGridControl.BOSDataMember = null;
            this.fld_dgcARReceptionItemsGridControl.BOSDataSource = "ARReceptionItems";
            this.fld_dgcARReceptionItemsGridControl.BOSDescription = null;
            this.fld_dgcARReceptionItemsGridControl.BOSError = null;
            this.fld_dgcARReceptionItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARReceptionItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARReceptionItemsGridControl.BOSGridType = null;
            this.fld_dgcARReceptionItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARReceptionItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARReceptionItemsGridControl.CommodityType = "";
            this.fld_dgcARReceptionItemsGridControl.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcARReceptionItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARReceptionItemsGridControl.Name = "fld_dgcARReceptionItemsGridControl";
            this.fld_dgcARReceptionItemsGridControl.PrintReport = false;
            this.fld_dgcARReceptionItemsGridControl.Screen = null;
            this.fld_dgcARReceptionItemsGridControl.Size = new System.Drawing.Size(683, 294);
            this.fld_dgcARReceptionItemsGridControl.TabIndex = 0;
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(136, 41);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 417;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtARReceptionName
            // 
            this.fld_txtARReceptionName.BOSComment = "";
            this.fld_txtARReceptionName.BOSDataMember = "ARReceptionName";
            this.fld_txtARReceptionName.BOSDataSource = "ARReceptions";
            this.fld_txtARReceptionName.BOSDescription = null;
            this.fld_txtARReceptionName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtARReceptionName.BOSFieldGroup = "";
            this.fld_txtARReceptionName.BOSFieldRelation = "";
            this.fld_txtARReceptionName.BOSPrivilege = "";
            this.fld_txtARReceptionName.BOSPropertyName = "Text";
            this.fld_txtARReceptionName.Location = new System.Drawing.Point(218, 38);
            this.fld_txtARReceptionName.Name = "fld_txtARReceptionName";
            this.fld_txtARReceptionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceptionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceptionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceptionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceptionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceptionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceptionName.Screen = null;
            this.fld_txtARReceptionName.Size = new System.Drawing.Size(464, 20);
            this.fld_txtARReceptionName.TabIndex = 2;
            this.fld_txtARReceptionName.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(136, 145);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(27, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Mô tả";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel3.Location = new System.Drawing.Point(417, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
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
            // DMRE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(714, 523);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARReceptionEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceptionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARReceptionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARReceptionDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEquipmentStateID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceptionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDriverEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionExpediencyQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRReturnEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceptionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceptionItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceptionName.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARReceptionDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARReceptionNo;
        private BOSComponent.BOSMemoEdit fld_medARReceptionDesc;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARReceptionName;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARReceptionItemsGridControl fld_dgcARReceptionItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeARReceptionStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRReturnEmployeeID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARReceptionExpediencyQty;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDriverEmployeeID;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeARReceptionType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEquipmentStateID;
    }
}
