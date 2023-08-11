using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DepartmentRoomGroupTeam.UI
{
	/// <summary>
	/// Summary description for SMDRGT100
	/// </summary>
	partial class SMDRGT100
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
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDepartmentRoomGroupName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRDepartmentRoomGroupTeams = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRDepartmentRoomGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDepartmentRoomGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HRDepartmentID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartmentRoomGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(22, 72);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(39, 13);
            this.bosLabel10.TabIndex = 92;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Bộ phận";
            // 
            // fld_txtHRDepartmentRoomGroupName
            // 
            this.fld_txtHRDepartmentRoomGroupName.BOSComment = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSDataMember = "HRDepartmentRoomGroupName";
            this.fld_txtHRDepartmentRoomGroupName.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_txtHRDepartmentRoomGroupName.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldGroup = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldRelation = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSPrivilege = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupName.Location = new System.Drawing.Point(110, 40);
            this.fld_txtHRDepartmentRoomGroupName.MenuManager = this.screenToolbar;
            this.fld_txtHRDepartmentRoomGroupName.Name = "fld_txtHRDepartmentRoomGroupName";
            this.fld_txtHRDepartmentRoomGroupName.Screen = null;
            this.fld_txtHRDepartmentRoomGroupName.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHRDepartmentRoomGroupName.TabIndex = 91;
            this.fld_txtHRDepartmentRoomGroupName.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(22, 43);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(65, 13);
            this.bosLabel8.TabIndex = 90;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Tên chứng từ";
            // 
            // fld_dgcHRDepartmentRoomGroupTeams
            // 
            this.fld_dgcHRDepartmentRoomGroupTeams.AllowDrop = true;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSDescription = null;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSError = null;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSGridType = null;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.BOSPropertyName = "Search Result";
            this.fld_dgcHRDepartmentRoomGroupTeams.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeams.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRDepartmentRoomGroupTeams.Location = new System.Drawing.Point(32, 186);
            this.fld_dgcHRDepartmentRoomGroupTeams.MainView = this.fld_dgvHRDepartmentRoomGroups;
            this.fld_dgcHRDepartmentRoomGroupTeams.Name = "fld_dgcHRDepartmentRoomGroupTeams";
            this.fld_dgcHRDepartmentRoomGroupTeams.PrintReport = false;
            this.fld_dgcHRDepartmentRoomGroupTeams.Screen = null;
            this.fld_dgcHRDepartmentRoomGroupTeams.Size = new System.Drawing.Size(400, 218);
            this.fld_dgcHRDepartmentRoomGroupTeams.TabIndex = 88;
            this.fld_dgcHRDepartmentRoomGroupTeams.Tag = "SR";
            this.fld_dgcHRDepartmentRoomGroupTeams.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRDepartmentRoomGroups});
            // 
            // fld_dgvHRDepartmentRoomGroups
            // 
            this.fld_dgvHRDepartmentRoomGroups.GridControl = this.fld_dgcHRDepartmentRoomGroupTeams;
            this.fld_dgvHRDepartmentRoomGroups.Name = "fld_dgvHRDepartmentRoomGroups";
            this.fld_dgvHRDepartmentRoomGroups.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.Location = new System.Drawing.Point(22, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 85;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel5.Location = new System.Drawing.Point(22, 100);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel5.TabIndex = 86;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Phòng ban";
            // 
            // fld_txtHRDepartmentRoomGroupNo
            // 
            this.fld_txtHRDepartmentRoomGroupNo.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataMember = "HRDepartmentRoomGroupNo";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupNo.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.Location = new System.Drawing.Point(110, 9);
            this.fld_txtHRDepartmentRoomGroupNo.Name = "fld_txtHRDepartmentRoomGroupNo";
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDepartmentRoomGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDepartmentRoomGroupNo.Screen = null;
            this.fld_txtHRDepartmentRoomGroupNo.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHRDepartmentRoomGroupNo.TabIndex = 87;
            this.fld_txtHRDepartmentRoomGroupNo.Tag = "SC";
            // 
            // fld_lkeFK_HRDepartmentID1
            // 
            this.fld_lkeFK_HRDepartmentID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID1.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID1.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID1.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID1.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_lkeFK_HRDepartmentID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDepartmentID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID1.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID1.Location = new System.Drawing.Point(110, 69);
            this.fld_lkeFK_HRDepartmentID1.Name = "fld_lkeFK_HRDepartmentID1";
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID1.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentID1.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID1.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDepartmentID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID1.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID1, true);
            this.fld_lkeFK_HRDepartmentID1.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeFK_HRDepartmentID1.TabIndex = 104;
            this.fld_lkeFK_HRDepartmentID1.Tag = "SC";
            // 
            // fld_lkeFK_HRDepartmentRoomID1
            // 
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataSource = "HRDepartmentRoomGroups";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Location = new System.Drawing.Point(110, 97);
            this.fld_lkeFK_HRDepartmentRoomID1.Name = "fld_lkeFK_HRDepartmentRoomID1";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID1, true);
            this.fld_lkeFK_HRDepartmentRoomID1.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeFK_HRDepartmentRoomID1.TabIndex = 105;
            this.fld_lkeFK_HRDepartmentRoomID1.Tag = "SC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_HRDepartmentRoomGroupID";
            this.bosLookupEdit1.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(110, 123);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupName", "Tổ")});
            this.bosLookupEdit1.Properties.DisplayMember = "HRDepartmentRoomGroupName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "HRDepartmentRoomGroupID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(195, 20);
            this.bosLookupEdit1.TabIndex = 107;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(22, 126);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(12, 13);
            this.bosLabel3.TabIndex = 106;
            this.bosLabel3.Tag = "DC";
            this.bosLabel3.Text = "Tổ";
            // 
            // SMDRGT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID1);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentID1);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_txtHRDepartmentRoomGroupName);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_dgcHRDepartmentRoomGroupTeams);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtHRDepartmentRoomGroupNo);
            this.Name = "SMDRGT100";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.SMDRGT100_Load);
            this.Controls.SetChildIndex(this.fld_txtHRDepartmentRoomGroupNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRDepartmentRoomGroupTeams, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_txtHRDepartmentRoomGroupName, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentRoomID1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartmentRoomGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupName;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSSearchResultsGridControl fld_dgcHRDepartmentRoomGroupTeams;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRDepartmentRoomGroups;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupNo;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID1;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
