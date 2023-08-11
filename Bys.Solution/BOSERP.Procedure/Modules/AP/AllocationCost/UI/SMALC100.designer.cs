using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AllocationCost.UI
{
	/// <summary>
	/// Summary description for SMALC100
	/// </summary>
	partial class SMALC100
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
            this.fld_dgcAPAllocationCosts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ACObjectIDsearch = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPAllocationCostRegisDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtAPAllocationCostNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchIDSearch = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectIDsearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostRegisDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostRegisDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPAllocationCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchIDSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPAllocationCosts
            // 
            this.fld_dgcAPAllocationCosts.AllowDrop = true;
            this.fld_dgcAPAllocationCosts.BOSComment = string.Empty;
            this.fld_dgcAPAllocationCosts.BOSDataMember = string.Empty;
            this.fld_dgcAPAllocationCosts.BOSDataSource = "APAllocationCosts";
            this.fld_dgcAPAllocationCosts.BOSDescription = null;
            this.fld_dgcAPAllocationCosts.BOSError = null;
            this.fld_dgcAPAllocationCosts.BOSFieldGroup = string.Empty;
            this.fld_dgcAPAllocationCosts.BOSFieldRelation = string.Empty;
            this.fld_dgcAPAllocationCosts.BOSPrivilege = string.Empty;
            this.fld_dgcAPAllocationCosts.BOSPropertyName = string.Empty;
            this.fld_dgcAPAllocationCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPAllocationCosts.Location = new System.Drawing.Point(29, 115);
            this.fld_dgcAPAllocationCosts.MainView = this.fld_dgvAPPurchaseOrder;
            this.fld_dgcAPAllocationCosts.Name = "fld_dgcAPAllocationCosts";
            this.fld_dgcAPAllocationCosts.Screen = null;
            this.fld_dgcAPAllocationCosts.Size = new System.Drawing.Size(400, 236);
            this.fld_dgcAPAllocationCosts.TabIndex = 6;
            this.fld_dgcAPAllocationCosts.Tag = "SR";
            this.fld_dgcAPAllocationCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrder});
            // 
            // fld_dgvAPPurchaseOrder
            // 
            this.fld_dgvAPPurchaseOrder.GridControl = this.fld_dgcAPAllocationCosts;
            this.fld_dgvAPPurchaseOrder.Name = "fld_dgvAPPurchaseOrder";
            this.fld_dgvAPPurchaseOrder.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ACObjectIDsearch
            // 
            this.fld_lkeFK_ACObjectIDsearch.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectIDsearch.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectIDsearch.BOSComment = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectIDsearch.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_ACObjectIDsearch.BOSDescription = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSError = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectIDsearch.BOSSelectType = null;
            this.fld_lkeFK_ACObjectIDsearch.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectIDsearch.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectIDsearch.Location = new System.Drawing.Point(144, 35);
            this.fld_lkeFK_ACObjectIDsearch.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectIDsearch.Name = "fld_lkeFK_ACObjectIDsearch";
            this.fld_lkeFK_ACObjectIDsearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectIDsearch.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectIDsearch.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectIDsearch.Screen = null;
            this.fld_lkeFK_ACObjectIDsearch.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_ACObjectIDsearch.TabIndex = 2;
            this.fld_lkeFK_ACObjectIDsearch.Tag = "SC";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = string.Empty;
            this.bosLabel35.BOSDataSource = string.Empty;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = string.Empty;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(29, 38);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(48, 13);
            this.bosLabel35.TabIndex = 34;
            this.bosLabel35.Tag = "SI";
            this.bosLabel35.Text = "Đối tượng";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = string.Empty;
            this.bosLabel27.BOSDataMember = string.Empty;
            this.bosLabel27.BOSDataSource = string.Empty;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = string.Empty;
            this.bosLabel27.BOSFieldRelation = string.Empty;
            this.bosLabel27.BOSPrivilege = string.Empty;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(29, 92);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(40, 13);
            this.bosLabel27.TabIndex = 30;
            this.bosLabel27.Tag = "SI";
            this.bosLabel27.Text = "Từ ngày";
            // 
            // fld_dteAPAllocationCostRegisDate
            // 
            this.fld_dteAPAllocationCostRegisDate.BOSComment = string.Empty;
            this.fld_dteAPAllocationCostRegisDate.BOSDataMember = "APAllocationCostSearchFromDate";
            this.fld_dteAPAllocationCostRegisDate.BOSDataSource = "APAllocationCosts";
            this.fld_dteAPAllocationCostRegisDate.BOSDescription = null;
            this.fld_dteAPAllocationCostRegisDate.BOSError = null;
            this.fld_dteAPAllocationCostRegisDate.BOSFieldGroup = string.Empty;
            this.fld_dteAPAllocationCostRegisDate.BOSFieldRelation = string.Empty;
            this.fld_dteAPAllocationCostRegisDate.BOSPrivilege = string.Empty;
            this.fld_dteAPAllocationCostRegisDate.BOSPropertyName = "EditValue";
            this.fld_dteAPAllocationCostRegisDate.EditValue = null;
            this.fld_dteAPAllocationCostRegisDate.Location = new System.Drawing.Point(144, 89);
            this.fld_dteAPAllocationCostRegisDate.Name = "fld_dteAPAllocationCostRegisDate";
            this.fld_dteAPAllocationCostRegisDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPAllocationCostRegisDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPAllocationCostRegisDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPAllocationCostRegisDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPAllocationCostRegisDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPAllocationCostRegisDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPAllocationCostRegisDate.Screen = null;
            this.fld_dteAPAllocationCostRegisDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPAllocationCostRegisDate.TabIndex = 4;
            this.fld_dteAPAllocationCostRegisDate.Tag = "SC";
            // 
            // fld_txtAPAllocationCostNo
            // 
            this.fld_txtAPAllocationCostNo.BOSComment = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSDataMember = "APAllocationCostNo";
            this.fld_txtAPAllocationCostNo.BOSDataSource = "APAllocationCosts";
            this.fld_txtAPAllocationCostNo.BOSDescription = null;
            this.fld_txtAPAllocationCostNo.BOSError = null;
            this.fld_txtAPAllocationCostNo.BOSFieldGroup = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSFieldRelation = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSPrivilege = string.Empty;
            this.fld_txtAPAllocationCostNo.BOSPropertyName = "Text";
            this.fld_txtAPAllocationCostNo.EditValue = string.Empty;
            this.fld_txtAPAllocationCostNo.Location = new System.Drawing.Point(144, 9);
            this.fld_txtAPAllocationCostNo.Name = "fld_txtAPAllocationCostNo";
            this.fld_txtAPAllocationCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPAllocationCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPAllocationCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPAllocationCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPAllocationCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPAllocationCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPAllocationCostNo.Screen = null;
            this.fld_txtAPAllocationCostNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPAllocationCostNo.TabIndex = 0;
            this.fld_txtAPAllocationCostNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = string.Empty;
            this.bosLabel1.Location = new System.Drawing.Point(29, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 26;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(318, 92);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 44;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Đến ngày";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = string.Empty;
            this.bosDateEdit1.BOSDataMember = "APAllocationCostSearchToDate";
            this.bosDateEdit1.BOSDataSource = "APAllocationCosts";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = string.Empty;
            this.bosDateEdit1.BOSFieldRelation = string.Empty;
            this.bosDateEdit1.BOSPrivilege = string.Empty;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(433, 89);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(133, 20);
            this.bosDateEdit1.TabIndex = 5;
            this.bosDateEdit1.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = string.Empty;
            this.bosLabel5.BOSDataSource = string.Empty;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = string.Empty;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(29, 66);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 46;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchIDSearch
            // 
            this.fld_lkeFK_BRBranchIDSearch.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchIDSearch.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchIDSearch.BOSComment = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchIDSearch.BOSDataSource = "APAllocationCosts";
            this.fld_lkeFK_BRBranchIDSearch.BOSDescription = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSError = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchIDSearch.BOSSelectType = null;
            this.fld_lkeFK_BRBranchIDSearch.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchIDSearch.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchIDSearch.Location = new System.Drawing.Point(144, 63);
            this.fld_lkeFK_BRBranchIDSearch.Name = "fld_lkeFK_BRBranchIDSearch";
            this.fld_lkeFK_BRBranchIDSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchIDSearch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Name")});
            this.fld_lkeFK_BRBranchIDSearch.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchIDSearch.Properties.NullText = string.Empty;
            this.fld_lkeFK_BRBranchIDSearch.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchIDSearch.Screen = null;
            this.fld_lkeFK_BRBranchIDSearch.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_BRBranchIDSearch.TabIndex = 3;
            this.fld_lkeFK_BRBranchIDSearch.Tag = "SC";
            // 
            // SMALC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(599, 378);
            this.Controls.Add(this.fld_lkeFK_BRBranchIDSearch);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.fld_lkeFK_ACObjectIDsearch);
            this.Controls.Add(this.bosLabel35);
            this.Controls.Add(this.bosLabel27);
            this.Controls.Add(this.fld_dteAPAllocationCostRegisDate);
            this.Controls.Add(this.fld_txtAPAllocationCostNo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dgcAPAllocationCosts);
            this.Name = "SMALC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPAllocationCosts, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPAllocationCostNo, 0);
            this.Controls.SetChildIndex(this.fld_dteAPAllocationCostRegisDate, 0);
            this.Controls.SetChildIndex(this.bosLabel27, 0);
            this.Controls.SetChildIndex(this.bosLabel35, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectIDsearch, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchIDSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPAllocationCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectIDsearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostRegisDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPAllocationCostRegisDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPAllocationCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchIDSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcAPAllocationCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrder;
        private IContainer components;
        private AccObjectLookupEdit fld_lkeFK_ACObjectIDsearch;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSDateEdit fld_dteAPAllocationCostRegisDate;
        private BOSComponent.BOSTextBox fld_txtAPAllocationCostNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchIDSearch;
	}
}
