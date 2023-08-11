using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerPaymentTimePayment.UI
{
	/// <summary>
	/// Summary description for SMARCP100
	/// </summary>
    partial class SMARCPTP100
	{
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private ARCustomerPaymentsGridControl fld_dgcARCustomerPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerPayment;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMARCPTP100));
            this.fld_txtARCustomerPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARCustomerPayment = new BOSERP.Modules.CustomerPaymentTimePayment.ARCustomerPaymentsGridControl();
            this.fld_dgvARCustomerPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScreenHelper
            // 
            resources.ApplyResources(this.ScreenHelper, "ScreenHelper");
            // 
            // fld_txtARCustomerPaymentNo
            // 
            resources.ApplyResources(this.fld_txtARCustomerPaymentNo, "fld_txtARCustomerPaymentNo");
            this.fld_txtARCustomerPaymentNo.BOSComment = "";
            this.fld_txtARCustomerPaymentNo.BOSDataMember = "ARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentNo.BOSDescription = null;
            this.fld_txtARCustomerPaymentNo.BOSError = null;
            this.fld_txtARCustomerPaymentNo.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentNo.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentNo.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentNo.BOSPropertyName = "Text";
            this.ScreenHelper.SetHelpKeyword(this.fld_txtARCustomerPaymentNo, resources.GetString("fld_txtARCustomerPaymentNo.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_txtARCustomerPaymentNo, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_txtARCustomerPaymentNo.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_txtARCustomerPaymentNo, resources.GetString("fld_txtARCustomerPaymentNo.HelpString"));
            this.fld_txtARCustomerPaymentNo.Name = "fld_txtARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtARCustomerPaymentNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtARCustomerPaymentNo.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_txtARCustomerPaymentNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentNo, ((bool)(resources.GetObject("fld_txtARCustomerPaymentNo.ShowHelp"))));
            this.fld_txtARCustomerPaymentNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            resources.ApplyResources(this.fld_lblLabel, "fld_lblLabel");
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.fld_lblLabel, resources.GetString("fld_lblLabel.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_lblLabel, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_lblLabel.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_lblLabel, resources.GetString("fld_lblLabel.HelpString"));
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel, ((bool)(resources.GetObject("fld_lblLabel.ShowHelp"))));
            this.fld_lblLabel.Tag = "SI";
            // 
            // fld_dgcARCustomerPayment
            // 
            resources.ApplyResources(this.fld_dgcARCustomerPayment, "fld_dgcARCustomerPayment");
            this.fld_dgcARCustomerPayment.AllowDrop = true;
            this.fld_dgcARCustomerPayment.BOSComment = "";
            this.fld_dgcARCustomerPayment.BOSDataMember = "";
            this.fld_dgcARCustomerPayment.BOSDataSource = "ARCustomerPayments";
            this.fld_dgcARCustomerPayment.BOSDescription = null;
            this.fld_dgcARCustomerPayment.BOSError = null;
            this.fld_dgcARCustomerPayment.BOSFieldGroup = "";
            this.fld_dgcARCustomerPayment.BOSFieldRelation = "";
            this.fld_dgcARCustomerPayment.BOSGridType = null;
            this.fld_dgcARCustomerPayment.BOSPrivilege = "";
            this.fld_dgcARCustomerPayment.BOSPropertyName = "";
            this.fld_dgcARCustomerPayment.CommodityType = "";
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.AccessibleDescription = resources.GetString("fld_dgcARCustomerPayment.EmbeddedNavigator.AccessibleDescription");
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.AccessibleName = resources.GetString("fld_dgcARCustomerPayment.EmbeddedNavigator.AccessibleName");
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.Anchor")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.BackgroundImage")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.ImeMode")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.MaximumSize")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.TextLocation")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTip = resources.GetString("fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTip");
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTipTitle = resources.GetString("fld_dgcARCustomerPayment.EmbeddedNavigator.ToolTipTitle");
            this.ScreenHelper.SetHelpKeyword(this.fld_dgcARCustomerPayment, resources.GetString("fld_dgcARCustomerPayment.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_dgcARCustomerPayment, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_dgcARCustomerPayment.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_dgcARCustomerPayment, resources.GetString("fld_dgcARCustomerPayment.HelpString"));
            this.fld_dgcARCustomerPayment.MainView = this.fld_dgvARCustomerPayment;
            this.fld_dgcARCustomerPayment.Name = "fld_dgcARCustomerPayment";
            this.fld_dgcARCustomerPayment.PrintReport = false;
            this.fld_dgcARCustomerPayment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcARCustomerPayment, ((bool)(resources.GetObject("fld_dgcARCustomerPayment.ShowHelp"))));
            this.fld_dgcARCustomerPayment.Tag = "SR";
            this.fld_dgcARCustomerPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerPayment});
            // 
            // fld_dgvARCustomerPayment
            // 
            resources.ApplyResources(this.fld_dgvARCustomerPayment, "fld_dgvARCustomerPayment");
            this.fld_dgvARCustomerPayment.GridControl = this.fld_dgcARCustomerPayment;
            this.fld_dgvARCustomerPayment.Name = "fld_dgvARCustomerPayment";
            this.fld_dgvARCustomerPayment.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel1, resources.GetString("bosLabel1.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel1.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel1, resources.GetString("bosLabel1.HelpString"));
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            this.bosLabel1.Tag = "SI";
            // 
            // fld_dteSearchFromARCustomerPaymentDate
            // 
            resources.ApplyResources(this.fld_dteSearchFromARCustomerPaymentDate, "fld_dteSearchFromARCustomerPaymentDate");
            this.fld_dteSearchFromARCustomerPaymentDate.BOSComment = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataMember = "CustomerPaymentDateFrom";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSError = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.ScreenHelper.SetHelpKeyword(this.fld_dteSearchFromARCustomerPaymentDate, resources.GetString("fld_dteSearchFromARCustomerPaymentDate.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_dteSearchFromARCustomerPaymentDate, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_dteSearchFromARCustomerPaymentDate.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_dteSearchFromARCustomerPaymentDate, resources.GetString("fld_dteSearchFromARCustomerPaymentDate.HelpString"));
            this.fld_dteSearchFromARCustomerPaymentDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromARCustomerPaymentDate.Name = "fld_dteSearchFromARCustomerPaymentDate";
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromARCustomerPaymentDate.Properties.Buttons"))))});
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.CalendarTimeProperties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_dteSearchFromARCustomerPaymentDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromARCustomerPaymentDate, ((bool)(resources.GetObject("fld_dteSearchFromARCustomerPaymentDate.ShowHelp"))));
            this.fld_dteSearchFromARCustomerPaymentDate.Tag = "SC";
            // 
            // fld_dteSearchToARCustomerPaymentDate
            // 
            resources.ApplyResources(this.fld_dteSearchToARCustomerPaymentDate, "fld_dteSearchToARCustomerPaymentDate");
            this.fld_dteSearchToARCustomerPaymentDate.BOSComment = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSDataMember = "CustomerPaymentDateTo";
            this.fld_dteSearchToARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchToARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSError = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.ScreenHelper.SetHelpKeyword(this.fld_dteSearchToARCustomerPaymentDate, resources.GetString("fld_dteSearchToARCustomerPaymentDate.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_dteSearchToARCustomerPaymentDate, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_dteSearchToARCustomerPaymentDate.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_dteSearchToARCustomerPaymentDate, resources.GetString("fld_dteSearchToARCustomerPaymentDate.HelpString"));
            this.fld_dteSearchToARCustomerPaymentDate.Name = "fld_dteSearchToARCustomerPaymentDate";
            this.fld_dteSearchToARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchToARCustomerPaymentDate.Properties.Buttons"))))});
            this.fld_dteSearchToARCustomerPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCustomerPaymentDate.Properties.CalendarTimeProperties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_dteSearchToARCustomerPaymentDate.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_dteSearchToARCustomerPaymentDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToARCustomerPaymentDate, ((bool)(resources.GetObject("fld_dteSearchToARCustomerPaymentDate.ShowHelp"))));
            this.fld_dteSearchToARCustomerPaymentDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel2, resources.GetString("bosLabel2.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel2.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel2, resources.GetString("bosLabel2.HelpString"));
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            this.bosLabel2.Tag = "SI";
            // 
            // bosLabel3
            // 
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
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
            this.bosLabel3.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel3, resources.GetString("bosLabel3.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel3, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel3.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel3, resources.GetString("bosLabel3.HelpString"));
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            this.bosLabel3.Tag = "SI";
            // 
            // bosLabel4
            // 
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel4, resources.GetString("bosLabel4.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel4, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel4.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel4, resources.GetString("bosLabel4.HelpString"));
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            this.bosLabel4.Tag = "SI";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            resources.ApplyResources(this.fld_lkeFK_HREmployeeID1, "fld_lkeFK_HREmployeeID1");
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARCustomerPayments";
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
            this.ScreenHelper.SetHelpKeyword(this.fld_lkeFK_HREmployeeID1, resources.GetString("fld_lkeFK_HREmployeeID1.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_lkeFK_HREmployeeID1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_lkeFK_HREmployeeID1.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_lkeFK_HREmployeeID1, resources.GetString("fld_lkeFK_HREmployeeID1.HelpString"));
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HREmployeeID1.Properties.Buttons"))))});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = resources.GetString("fld_lkeFK_HREmployeeID1.Properties.NullText");
            this.fld_lkeFK_HREmployeeID1.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID1, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID1.ShowHelp"))));
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel5
            // 
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel5.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel5, resources.GetString("bosLabel5.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel5, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel5.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel5, resources.GetString("bosLabel5.HelpString"));
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            this.bosLabel5.Tag = "SI";
            // 
            // fld_txtARInvoiceNo
            // 
            resources.ApplyResources(this.fld_txtARInvoiceNo, "fld_txtARInvoiceNo");
            this.fld_txtARInvoiceNo.BOSComment = "";
            this.fld_txtARInvoiceNo.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceNo.BOSFieldGroup = "";
            this.fld_txtARInvoiceNo.BOSFieldRelation = "";
            this.fld_txtARInvoiceNo.BOSPrivilege = "";
            this.fld_txtARInvoiceNo.BOSPropertyName = "Text";
            this.ScreenHelper.SetHelpKeyword(this.fld_txtARInvoiceNo, resources.GetString("fld_txtARInvoiceNo.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_txtARInvoiceNo, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_txtARInvoiceNo.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_txtARInvoiceNo, resources.GetString("fld_txtARInvoiceNo.HelpString"));
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtARInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtARInvoiceNo.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_txtARInvoiceNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARInvoiceNo, ((bool)(resources.GetObject("fld_txtARInvoiceNo.ShowHelp"))));
            this.fld_txtARInvoiceNo.Tag = "SC";
            // 
            // bosLabel6
            // 
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.BOSPropertyName = "";
            this.ScreenHelper.SetHelpKeyword(this.bosLabel6, resources.GetString("bosLabel6.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.bosLabel6, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("bosLabel6.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.bosLabel6, resources.GetString("bosLabel6.HelpString"));
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            this.bosLabel6.Tag = "SI";
            // 
            // fld_lkeFK_BRBranchID
            // 
            resources.ApplyResources(this.fld_lkeFK_BRBranchID, "fld_lkeFK_BRBranchID");
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.ScreenHelper.SetHelpKeyword(this.fld_lkeFK_BRBranchID, resources.GetString("fld_lkeFK_BRBranchID.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_lkeFK_BRBranchID, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_lkeFK_BRBranchID.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_lkeFK_BRBranchID, resources.GetString("fld_lkeFK_BRBranchID.HelpString"));
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_BRBranchID.Properties.Buttons"))))});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns2"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns3"))});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = resources.GetString("fld_lkeFK_BRBranchID.Properties.NullText");
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_BRBranchID, ((bool)(resources.GetObject("fld_lkeFK_BRBranchID.ShowHelp"))));
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            resources.ApplyResources(this.fld_lkeFK_ACObjectID, "fld_lkeFK_ACObjectID");
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCustomerPayments";
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
            this.ScreenHelper.SetHelpKeyword(this.fld_lkeFK_ACObjectID, resources.GetString("fld_lkeFK_ACObjectID.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this.fld_lkeFK_ACObjectID, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("fld_lkeFK_ACObjectID.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this.fld_lkeFK_ACObjectID, resources.GetString("fld_lkeFK_ACObjectID.HelpString"));
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Buttons"))))});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            //this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            //new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns3"))), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns4"), ((bool)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns8")))),
            //new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns9"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns10"))});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = resources.GetString("fld_lkeFK_ACObjectID.Properties.NullText");
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACObjectID, ((bool)(resources.GetObject("fld_lkeFK_ACObjectID.ShowHelp"))));
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // SMARCPTP100
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_dteSearchToARCustomerPaymentDate);
            this.Controls.Add(this.fld_dteSearchFromARCustomerPaymentDate);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcARCustomerPayment);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtARInvoiceNo);
            this.Controls.Add(this.fld_txtARCustomerPaymentNo);
            this.ScreenHelper.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.ScreenHelper.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.ScreenHelper.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMARCPTP100.IconOptions.Icon")));
            this.Name = "SMARCPTP100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_txtARCustomerPaymentNo, 0);
            this.Controls.SetChildIndex(this.fld_txtARInvoiceNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcARCustomerPayment, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCustomerPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARCustomerPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARCustomerPaymentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARCustomerPaymentDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}
