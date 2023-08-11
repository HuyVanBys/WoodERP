namespace BOSERP.Modules.Report
{
    partial class RP176
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP176));
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_pnlMonth = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromMonth = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pnlYear = new BOSComponent.BOSPanel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromYear = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pnlDate = new BOSComponent.BOSPanel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRLabouringConfigDateType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP176LabourProductivity = new BOSERP.Modules.Report.RP176GridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.fld_pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMonth.Properties)).BeginInit();
            this.fld_pnlYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromYear.Properties)).BeginInit();
            this.fld_pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorkShopID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP176LabourProductivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_btnExportExcel
            // 
            resources.ApplyResources(this.fld_btnExportExcel, "fld_btnExportExcel");
            this.fld_btnExportExcel.BOSComment = null;
            this.fld_btnExportExcel.BOSDataMember = null;
            this.fld_btnExportExcel.BOSDataSource = null;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = null;
            this.fld_btnExportExcel.BOSFieldRelation = null;
            this.fld_btnExportExcel.BOSPrivilege = null;
            this.fld_btnExportExcel.BOSPropertyName = null;
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportExcel, ((bool)(resources.GetObject("fld_btnExportExcel.ShowHelp"))));
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // fld_btnClose
            // 
            resources.ApplyResources(this.fld_btnClose, "fld_btnClose");
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, ((bool)(resources.GetObject("fld_btnClose.ShowHelp"))));
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_pnlMonth);
            this.bosPanel1.Controls.Add(this.fld_pnlYear);
            this.bosPanel1.Controls.Add(this.fld_pnlDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRLabouringConfigDateType);
            this.bosPanel1.Controls.Add(this.fld_lkeMMWorkShopID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.panelControl2);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // fld_pnlMonth
            // 
            this.fld_pnlMonth.BOSComment = null;
            this.fld_pnlMonth.BOSDataMember = null;
            this.fld_pnlMonth.BOSDataSource = null;
            this.fld_pnlMonth.BOSDescription = null;
            this.fld_pnlMonth.BOSError = null;
            this.fld_pnlMonth.BOSFieldGroup = null;
            this.fld_pnlMonth.BOSFieldRelation = null;
            this.fld_pnlMonth.BOSPrivilege = null;
            this.fld_pnlMonth.BOSPropertyName = null;
            this.fld_pnlMonth.Controls.Add(this.bosLabel2);
            this.fld_pnlMonth.Controls.Add(this.fld_dteSearchFromMonth);
            resources.ApplyResources(this.fld_pnlMonth, "fld_pnlMonth");
            this.fld_pnlMonth.Name = "fld_pnlMonth";
            this.fld_pnlMonth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pnlMonth, ((bool)(resources.GetObject("fld_pnlMonth.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // fld_dteSearchFromMonth
            // 
            this.fld_dteSearchFromMonth.BOSComment = null;
            this.fld_dteSearchFromMonth.BOSDataMember = null;
            this.fld_dteSearchFromMonth.BOSDataSource = null;
            this.fld_dteSearchFromMonth.BOSDescription = null;
            this.fld_dteSearchFromMonth.BOSError = null;
            this.fld_dteSearchFromMonth.BOSFieldGroup = null;
            this.fld_dteSearchFromMonth.BOSFieldRelation = null;
            this.fld_dteSearchFromMonth.BOSPrivilege = null;
            this.fld_dteSearchFromMonth.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dteSearchFromMonth, "fld_dteSearchFromMonth");
            this.fld_dteSearchFromMonth.Name = "fld_dteSearchFromMonth";
            this.fld_dteSearchFromMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromMonth.Properties.Buttons"))))});
            this.fld_dteSearchFromMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchFromMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteSearchFromMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromMonth.Properties.Mask.EditMask = resources.GetString("fld_dteSearchFromMonth.Properties.Mask.EditMask");
            this.fld_dteSearchFromMonth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromMonth, ((bool)(resources.GetObject("fld_dteSearchFromMonth.ShowHelp"))));
            this.fld_dteSearchFromMonth.Tag = "DC";
            // 
            // fld_pnlYear
            // 
            this.fld_pnlYear.BOSComment = null;
            this.fld_pnlYear.BOSDataMember = null;
            this.fld_pnlYear.BOSDataSource = null;
            this.fld_pnlYear.BOSDescription = null;
            this.fld_pnlYear.BOSError = null;
            this.fld_pnlYear.BOSFieldGroup = null;
            this.fld_pnlYear.BOSFieldRelation = null;
            this.fld_pnlYear.BOSPrivilege = null;
            this.fld_pnlYear.BOSPropertyName = null;
            this.fld_pnlYear.Controls.Add(this.bosLabel4);
            this.fld_pnlYear.Controls.Add(this.fld_dteSearchFromYear);
            resources.ApplyResources(this.fld_pnlYear, "fld_pnlYear");
            this.fld_pnlYear.Name = "fld_pnlYear";
            this.fld_pnlYear.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pnlYear, ((bool)(resources.GetObject("fld_pnlYear.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            // 
            // fld_dteSearchFromYear
            // 
            this.fld_dteSearchFromYear.BOSComment = null;
            this.fld_dteSearchFromYear.BOSDataMember = null;
            this.fld_dteSearchFromYear.BOSDataSource = null;
            this.fld_dteSearchFromYear.BOSDescription = null;
            this.fld_dteSearchFromYear.BOSError = null;
            this.fld_dteSearchFromYear.BOSFieldGroup = null;
            this.fld_dteSearchFromYear.BOSFieldRelation = null;
            this.fld_dteSearchFromYear.BOSPrivilege = null;
            this.fld_dteSearchFromYear.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dteSearchFromYear, "fld_dteSearchFromYear");
            this.fld_dteSearchFromYear.Name = "fld_dteSearchFromYear";
            this.fld_dteSearchFromYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromYear.Properties.Buttons"))))});
            this.fld_dteSearchFromYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromYear.Properties.DisplayFormat.FormatString = "yyyy";
            this.fld_dteSearchFromYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromYear.Properties.EditFormat.FormatString = "yyyy";
            this.fld_dteSearchFromYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteSearchFromYear.Properties.Mask.EditMask = resources.GetString("fld_dteSearchFromYear.Properties.Mask.EditMask");
            this.fld_dteSearchFromYear.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromYear, ((bool)(resources.GetObject("fld_dteSearchFromYear.ShowHelp"))));
            this.fld_dteSearchFromYear.Tag = "DC";
            // 
            // fld_pnlDate
            // 
            this.fld_pnlDate.BOSComment = null;
            this.fld_pnlDate.BOSDataMember = null;
            this.fld_pnlDate.BOSDataSource = null;
            this.fld_pnlDate.BOSDescription = null;
            this.fld_pnlDate.BOSError = null;
            this.fld_pnlDate.BOSFieldGroup = null;
            this.fld_pnlDate.BOSFieldRelation = null;
            this.fld_pnlDate.BOSPrivilege = null;
            this.fld_pnlDate.BOSPropertyName = null;
            this.fld_pnlDate.Controls.Add(this.fld_dteSearchToDate);
            this.fld_pnlDate.Controls.Add(this.bosLabel10);
            this.fld_pnlDate.Controls.Add(this.bosLabel9);
            this.fld_pnlDate.Controls.Add(this.fld_dteSearchFromDate);
            resources.ApplyResources(this.fld_pnlDate, "fld_pnlDate");
            this.fld_pnlDate.Name = "fld_pnlDate";
            this.fld_pnlDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pnlDate, ((bool)(resources.GetObject("fld_pnlDate.ShowHelp"))));
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = null;
            this.fld_dteSearchToDate.BOSDataSource = null;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dteSearchToDate, "fld_dteSearchToDate");
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchToDate.Properties.Buttons"))))});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, ((bool)(resources.GetObject("fld_dteSearchToDate.ShowHelp"))));
            this.fld_dteSearchToDate.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel9, "bosLabel9");
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, ((bool)(resources.GetObject("bosLabel9.ShowHelp"))));
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = null;
            this.fld_dteSearchFromDate.BOSDataSource = null;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dteSearchFromDate, "fld_dteSearchFromDate");
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromDate.Properties.Buttons"))))});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromDate, ((bool)(resources.GetObject("fld_dteSearchFromDate.ShowHelp"))));
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_lkeHRLabouringConfigDateType
            // 
            this.fld_lkeHRLabouringConfigDateType.BOSAllowAddNew = false;
            this.fld_lkeHRLabouringConfigDateType.BOSAllowDummy = true;
            this.fld_lkeHRLabouringConfigDateType.BOSComment = "";
            this.fld_lkeHRLabouringConfigDateType.BOSDataMember = "HRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.BOSDataSource = "HRLabouringConfigs";
            this.fld_lkeHRLabouringConfigDateType.BOSDescription = null;
            this.fld_lkeHRLabouringConfigDateType.BOSError = null;
            this.fld_lkeHRLabouringConfigDateType.BOSFieldGroup = "";
            this.fld_lkeHRLabouringConfigDateType.BOSFieldParent = "";
            this.fld_lkeHRLabouringConfigDateType.BOSFieldRelation = "";
            this.fld_lkeHRLabouringConfigDateType.BOSPrivilege = "";
            this.fld_lkeHRLabouringConfigDateType.BOSPropertyName = "EditValue";
            this.fld_lkeHRLabouringConfigDateType.BOSSelectType = "";
            this.fld_lkeHRLabouringConfigDateType.BOSSelectTypeValue = "";
            this.fld_lkeHRLabouringConfigDateType.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeHRLabouringConfigDateType, "fld_lkeHRLabouringConfigDateType");
            this.fld_lkeHRLabouringConfigDateType.Name = "fld_lkeHRLabouringConfigDateType";
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRLabouringConfigDateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHRLabouringConfigDateType.Properties.Buttons"))))});
            this.fld_lkeHRLabouringConfigDateType.Properties.ColumnName = null;
            this.fld_lkeHRLabouringConfigDateType.Properties.NullText = resources.GetString("fld_lkeHRLabouringConfigDateType.Properties.NullText");
            this.fld_lkeHRLabouringConfigDateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRLabouringConfigDateType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRLabouringConfigDateType, ((bool)(resources.GetObject("fld_lkeHRLabouringConfigDateType.ShowHelp"))));
            this.fld_lkeHRLabouringConfigDateType.Tag = "DC";
            this.fld_lkeHRLabouringConfigDateType.EditValueChanged += new System.EventHandler(this.fld_lkeHRLabouringConfigDateType_EditValueChanged);
            // 
            // fld_lkeMMWorkShopID
            // 
            this.fld_lkeMMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeMMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeMMWorkShopID.BOSComment = "";
            this.fld_lkeMMWorkShopID.BOSDataMember = "MMWorkShopID";
            this.fld_lkeMMWorkShopID.BOSDataSource = "MMWorkShops";
            this.fld_lkeMMWorkShopID.BOSDescription = null;
            this.fld_lkeMMWorkShopID.BOSError = null;
            this.fld_lkeMMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeMMWorkShopID.BOSFieldParent = "";
            this.fld_lkeMMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeMMWorkShopID.BOSPrivilege = "";
            this.fld_lkeMMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeMMWorkShopID.BOSSelectType = "";
            this.fld_lkeMMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeMMWorkShopID.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeMMWorkShopID, "fld_lkeMMWorkShopID");
            this.fld_lkeMMWorkShopID.Name = "fld_lkeMMWorkShopID";
            this.fld_lkeMMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeMMWorkShopID.Properties.Buttons"))))});
            this.fld_lkeMMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeMMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeMMWorkShopID.Properties.Columns"), resources.GetString("fld_lkeMMWorkShopID.Properties.Columns1"))});
            this.fld_lkeMMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeMMWorkShopID.Properties.NullText = resources.GetString("fld_lkeMMWorkShopID.Properties.NullText");
            this.fld_lkeMMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeMMWorkShopID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMWorkShopID, ((bool)(resources.GetObject("fld_lkeMMWorkShopID.ShowHelp"))));
            this.fld_lkeMMWorkShopID.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel21, "bosLabel21");
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, ((bool)(resources.GetObject("bosLabel21.ShowHelp"))));
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnApply, "fld_btnApply");
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnApply, ((bool)(resources.GetObject("fld_btnApply.ShowHelp"))));
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // bosLine1
            // 
            resources.ApplyResources(this.bosLine1, "bosLine1");
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcRP176LabourProductivity);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_dgcRP176LabourProductivity
            // 
            this.fld_dgcRP176LabourProductivity.BOSComment = null;
            this.fld_dgcRP176LabourProductivity.BOSDataMember = null;
            this.fld_dgcRP176LabourProductivity.BOSDataSource = "";
            this.fld_dgcRP176LabourProductivity.BOSDescription = null;
            this.fld_dgcRP176LabourProductivity.BOSError = null;
            this.fld_dgcRP176LabourProductivity.BOSFieldGroup = null;
            this.fld_dgcRP176LabourProductivity.BOSFieldRelation = null;
            this.fld_dgcRP176LabourProductivity.BOSGridType = null;
            this.fld_dgcRP176LabourProductivity.BOSPrivilege = null;
            this.fld_dgcRP176LabourProductivity.BOSPropertyName = null;
            this.fld_dgcRP176LabourProductivity.CommodityType = "";
            resources.ApplyResources(this.fld_dgcRP176LabourProductivity, "fld_dgcRP176LabourProductivity");
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP176LabourProductivity.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP176LabourProductivity.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP176LabourProductivity.MenuManager = this.screenToolbar;
            this.fld_dgcRP176LabourProductivity.Name = "fld_dgcRP176LabourProductivity";
            this.fld_dgcRP176LabourProductivity.PrintReport = false;
            this.fld_dgcRP176LabourProductivity.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP176LabourProductivity, ((bool)(resources.GetObject("fld_dgcRP176LabourProductivity.ShowHelp"))));
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_btnClose);
            this.panelControl2.Controls.Add(this.fld_btnExportExcel);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, ((bool)(resources.GetObject("panelControl2.ShowHelp"))));
            // 
            // RP176
            // 
            this.AcceptButton = this.fld_btnExportExcel;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP176";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP176_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.fld_pnlMonth.ResumeLayout(false);
            this.fld_pnlMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMonth.Properties)).EndInit();
            this.fld_pnlYear.ResumeLayout(false);
            this.fld_pnlYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromYear.Properties)).EndInit();
            this.fld_pnlDate.ResumeLayout(false);
            this.fld_pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRLabouringConfigDateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWorkShopID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP176LabourProductivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSLine bosLine1;
        private RP176GridControl fld_dgcRP176LabourProductivity;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeHRLabouringConfigDateType;
        private BOSComponent.BOSLookupEdit fld_lkeMMWorkShopID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSPanel fld_pnlMonth;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteSearchFromMonth;
        private BOSComponent.BOSPanel fld_pnlYear;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteSearchFromYear;
        private BOSComponent.BOSPanel fld_pnlDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
    }
}
