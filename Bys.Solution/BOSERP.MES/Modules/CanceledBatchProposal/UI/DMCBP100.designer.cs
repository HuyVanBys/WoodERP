using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CanceledBatchProposal.UI
{
	/// <summary>
	/// Summary description for DMBP100
	/// </summary>
	partial class DMCBP100
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
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMCanceledProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMCanceledProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabWoodItems = new BOSComponent.BOSTabControl(this.components);
            this.xrTabOtherItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMCanceledProposalItemsGridControl = new BOSERP.Modules.CanceledBatchProposal.MMCanceledProposalItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARCustomerID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMCanceledProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMCanceledProposalBatchStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmpoyeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabWoodItems)).BeginInit();
            this.fld_tabWoodItems.SuspendLayout();
            this.xrTabOtherItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCanceledProposalItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMCanceledProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalBatchStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.Location = new System.Drawing.Point(284, 15);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, true);
            this.fld_lblLabel12.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel12.TabIndex = 341;
            this.fld_lblLabel12.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel12.Text = "Ngày chứng từ";
            // 
            // fld_dteMMCanceledProposalDate
            // 
            this.fld_dteMMCanceledProposalDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSDataMember = "MMCanceledProposalDate";
            this.fld_dteMMCanceledProposalDate.BOSDataSource = "MMCanceledProposals";
            this.fld_dteMMCanceledProposalDate.BOSDescription = null;
            this.fld_dteMMCanceledProposalDate.BOSError = null;
            this.fld_dteMMCanceledProposalDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteMMCanceledProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteMMCanceledProposalDate.EditValue = null;
            this.fld_dteMMCanceledProposalDate.Location = new System.Drawing.Point(365, 12);
            this.fld_dteMMCanceledProposalDate.Name = "fld_dteMMCanceledProposalDate";
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMCanceledProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMCanceledProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMCanceledProposalDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMCanceledProposalDate, true);
            this.fld_dteMMCanceledProposalDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteMMCanceledProposalDate.TabIndex = 1;
            this.fld_dteMMCanceledProposalDate.Tag = "DC";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.Location = new System.Drawing.Point(12, 15);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel15.TabIndex = 338;
            this.fld_lblLabel15.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel15.Text = "Mã chứng từ";
            // 
            // fld_txtMMCanceledProposalNo
            // 
            this.fld_txtMMCanceledProposalNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSDataMember = "MMCanceledProposalNo";
            this.fld_txtMMCanceledProposalNo.BOSDataSource = "MMCanceledProposals";
            this.fld_txtMMCanceledProposalNo.BOSDescription = null;
            this.fld_txtMMCanceledProposalNo.BOSError = null;
            this.fld_txtMMCanceledProposalNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.BOSPropertyName = "Text";
            this.fld_txtMMCanceledProposalNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMCanceledProposalNo.Location = new System.Drawing.Point(82, 12);
            this.fld_txtMMCanceledProposalNo.Name = "fld_txtMMCanceledProposalNo";
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMCanceledProposalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMCanceledProposalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMCanceledProposalNo.Properties.ReadOnly = true;
            this.fld_txtMMCanceledProposalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMCanceledProposalNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMCanceledProposalNo, true);
            this.fld_txtMMCanceledProposalNo.Size = new System.Drawing.Size(166, 20);
            this.fld_txtMMCanceledProposalNo.TabIndex = 0;
            this.fld_txtMMCanceledProposalNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_tabWoodItems);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID1);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medMMCanceledProposalDesc);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeMMCanceledProposalBatchStatus);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmpoyeeID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel15);
            this.bosPanel1.Controls.Add(this.fld_txtMMCanceledProposalNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteMMCanceledProposalDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "MMCanceledProposalPONo";
            this.bosTextBox1.BOSDataSource = "MMCanceledProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.Location = new System.Drawing.Point(365, 64);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(166, 20);
            this.bosTextBox1.TabIndex = 9;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.Location = new System.Drawing.Point(284, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(51, 13);
            this.bosLabel12.TabIndex = 559;
            this.bosLabel12.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.Text = " Số PO.No";
            // 
            // fld_tabWoodItems
            // 
            this.fld_tabWoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabWoodItems.BOSComment = null;
            this.fld_tabWoodItems.BOSDataMember = null;
            this.fld_tabWoodItems.BOSDataSource = null;
            this.fld_tabWoodItems.BOSDescription = null;
            this.fld_tabWoodItems.BOSError = null;
            this.fld_tabWoodItems.BOSFieldGroup = null;
            this.fld_tabWoodItems.BOSFieldRelation = null;
            this.fld_tabWoodItems.BOSPrivilege = null;
            this.fld_tabWoodItems.BOSPropertyName = null;
            this.fld_tabWoodItems.Location = new System.Drawing.Point(3, 134);
            this.fld_tabWoodItems.Name = "fld_tabWoodItems";
            this.fld_tabWoodItems.Screen = null;
            this.fld_tabWoodItems.SelectedTabPage = this.xrTabOtherItems;
            this.fld_tabWoodItems.Size = new System.Drawing.Size(878, 425);
            this.fld_tabWoodItems.TabIndex = 555;
            this.fld_tabWoodItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xrTabOtherItems});
            // 
            // xrTabOtherItems
            // 
            this.xrTabOtherItems.Controls.Add(this.fld_dgcMMCanceledProposalItemsGridControl);
            this.xrTabOtherItems.Name = "xrTabOtherItems";
            this.xrTabOtherItems.Size = new System.Drawing.Size(871, 396);
            this.xrTabOtherItems.Text = "Sản phẩm";
            // 
            // fld_dgcMMCanceledProposalItemsGridControl
            // 
            this.fld_dgcMMCanceledProposalItemsGridControl.AllowDrop = true;
            this.fld_dgcMMCanceledProposalItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSComment = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSDataMember = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSDataSource = "MMCanceledProposalItems";
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSDescription = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSError = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSGridType = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSPrivilege = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.BOSPropertyName = null;
            this.fld_dgcMMCanceledProposalItemsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMCanceledProposalItemsGridControl.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcMMCanceledProposalItemsGridControl.MainView = this.gridView2;
            this.fld_dgcMMCanceledProposalItemsGridControl.Name = "fld_dgcMMCanceledProposalItemsGridControl";
            this.fld_dgcMMCanceledProposalItemsGridControl.PrintReport = false;
            this.fld_dgcMMCanceledProposalItemsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMCanceledProposalItemsGridControl, true);
            this.fld_dgcMMCanceledProposalItemsGridControl.Size = new System.Drawing.Size(862, 389);
            this.fld_dgcMMCanceledProposalItemsGridControl.TabIndex = 30;
            this.fld_dgcMMCanceledProposalItemsGridControl.Tag = "DC";
            this.fld_dgcMMCanceledProposalItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMCanceledProposalItemsGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "Text";
            this.fld_lkeFK_ARSaleOrderID.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(82, 64);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.ReadOnly = true;
            this.fld_lkeFK_ARSaleOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARSaleOrderID, true);
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 6;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID1
            // 
            this.fld_lkeFK_ARCustomerID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID1.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID1.BOSComment = null;
            this.fld_lkeFK_ARCustomerID1.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeFK_ARCustomerID1.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID1.BOSError = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID1.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID1.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID1.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID1.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID1.Location = new System.Drawing.Point(365, 38);
            this.fld_lkeFK_ARCustomerID1.Name = "fld_lkeFK_ARCustomerID1";
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactAddressLine3", "Địa chỉ liên lạc")});
            this.fld_lkeFK_ARCustomerID1.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID1.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID1.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARCustomerID1, true);
            this.fld_lkeFK_ARCustomerID1.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_ARCustomerID1.TabIndex = 7;
            this.fld_lkeFK_ARCustomerID1.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDataMember = "ICProductNo";
            this.bosLabel9.BOSDataSource = "ICProducts";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.Location = new System.Drawing.Point(12, 67);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(27, 13);
            this.bosLabel9.TabIndex = 488;
            this.bosLabel9.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.Text = "PI No";
            // 
            // fld_medMMCanceledProposalDesc
            // 
            this.fld_medMMCanceledProposalDesc.BOSComment = null;
            this.fld_medMMCanceledProposalDesc.BOSDataMember = "MMCanceledProposalDesc";
            this.fld_medMMCanceledProposalDesc.BOSDataSource = "MMCanceledProposals";
            this.fld_medMMCanceledProposalDesc.BOSDescription = null;
            this.fld_medMMCanceledProposalDesc.BOSError = null;
            this.fld_medMMCanceledProposalDesc.BOSFieldGroup = null;
            this.fld_medMMCanceledProposalDesc.BOSFieldRelation = null;
            this.fld_medMMCanceledProposalDesc.BOSPrivilege = null;
            this.fld_medMMCanceledProposalDesc.BOSPropertyName = "Text";
            this.fld_medMMCanceledProposalDesc.Location = new System.Drawing.Point(82, 90);
            this.fld_medMMCanceledProposalDesc.Name = "fld_medMMCanceledProposalDesc";
            this.fld_medMMCanceledProposalDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMCanceledProposalDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMCanceledProposalDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMCanceledProposalDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMCanceledProposalDesc.Screen = null;
            this.fld_medMMCanceledProposalDesc.Size = new System.Drawing.Size(735, 38);
            this.fld_medMMCanceledProposalDesc.TabIndex = 12;
            this.fld_medMMCanceledProposalDesc.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(12, 93);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 486;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_lkeMMCanceledProposalBatchStatus
            // 
            this.fld_lkeMMCanceledProposalBatchStatus.BOSAllowAddNew = false;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSAllowDummy = false;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDataMember = "MMCanceledProposalBatchStatus";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSDescription = null;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSError = null;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMCanceledProposalBatchStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.CurrentDisplayText = null;
            this.fld_lkeMMCanceledProposalBatchStatus.Location = new System.Drawing.Point(651, 12);
            this.fld_lkeMMCanceledProposalBatchStatus.Name = "fld_lkeMMCanceledProposalBatchStatus";
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.ReadOnly = true;
            this.fld_lkeMMCanceledProposalBatchStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMCanceledProposalBatchStatus.Screen = null;
            this.fld_lkeMMCanceledProposalBatchStatus.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeMMCanceledProposalBatchStatus.TabIndex = 10;
            this.fld_lkeMMCanceledProposalBatchStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(570, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 347;
            this.bosLabel6.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.Text = "Trạng thái";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 41);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(47, 13);
            this.bosLabel8.TabIndex = 345;
            this.bosLabel8.Text = "Người tạo";
            // 
            // fld_lkeFK_HREmpoyeeID
            // 
            this.fld_lkeFK_HREmpoyeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmpoyeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmpoyeeID.BOSComment = null;
            this.fld_lkeFK_HREmpoyeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.BOSDataSource = "MMCanceledProposals";
            this.fld_lkeFK_HREmpoyeeID.BOSDescription = null;
            this.fld_lkeFK_HREmpoyeeID.BOSError = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmpoyeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmpoyeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmpoyeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmpoyeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmpoyeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmpoyeeID.Location = new System.Drawing.Point(82, 38);
            this.fld_lkeFK_HREmpoyeeID.Name = "fld_lkeFK_HREmpoyeeID";
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmpoyeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmpoyeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmpoyeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmpoyeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmpoyeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmpoyeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmpoyeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmpoyeeID, true);
            this.fld_lkeFK_HREmpoyeeID.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_HREmpoyeeID.TabIndex = 3;
            this.fld_lkeFK_HREmpoyeeID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(284, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(58, 13);
            this.bosLabel2.TabIndex = 339;
            this.bosLabel2.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Text = "Khách hàng";
            // 
            // DMCBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCBP100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCanceledProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCanceledProposalNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabWoodItems)).EndInit();
            this.fld_tabWoodItems.ResumeLayout(false);
            this.xrTabOtherItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCanceledProposalItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMCanceledProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCanceledProposalBatchStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmpoyeeID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSDateEdit fld_dteMMCanceledProposalDate;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSTextBox fld_txtMMCanceledProposalNo;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmpoyeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMCanceledProposalBatchStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medMMCanceledProposalDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID1;
        private BOSComponent.BOSTextBox fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSTabControl fld_tabWoodItems;
        private DevExpress.XtraTab.XtraTabPage xrTabOtherItems;
        private MMCanceledProposalItemsGridControl fld_dgcMMCanceledProposalItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel12;
	}
}
