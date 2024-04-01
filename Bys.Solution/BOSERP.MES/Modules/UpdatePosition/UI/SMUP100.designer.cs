using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.UpdatePosition.UI
{
    /// <summary>
    /// Summary description for SMPL100
    /// </summary>
    partial class SMUP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMUP100));
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMUpdatePositions = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteMMUpdatePositionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMUpdatePositionStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMUpdatePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
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
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(37, 23);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel12.TabIndex = 18;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Mã chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMUpdatePositionNo";
            this.bosTextBox1.BOSDataSource = "MMUpdatePositions";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "Mã kho không thể rỗng";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(127, 19);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 0;
            this.bosTextBox1.Tag = "SC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(37, 49);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel14.TabIndex = 20;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Từ ngày";
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
            this.bosLabel1.Location = new System.Drawing.Point(37, 101);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(19, 13);
            this.bosLabel1.TabIndex = 22;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Kho";
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
            this.bosLabel2.Location = new System.Drawing.Point(37, 127);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 24;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tình trạng";
            // 
            // fld_dgcMMUpdatePositions
            // 
            this.fld_dgcMMUpdatePositions.AllowDrop = true;
            this.fld_dgcMMUpdatePositions.BOSComment = "";
            this.fld_dgcMMUpdatePositions.BOSDataMember = null;
            this.fld_dgcMMUpdatePositions.BOSDataSource = "MMUpdatePositions";
            this.fld_dgcMMUpdatePositions.BOSDescription = null;
            this.fld_dgcMMUpdatePositions.BOSError = "";
            this.fld_dgcMMUpdatePositions.BOSFieldGroup = "";
            this.fld_dgcMMUpdatePositions.BOSFieldRelation = null;
            this.fld_dgcMMUpdatePositions.BOSGridType = null;
            this.fld_dgcMMUpdatePositions.BOSPrivilege = "";
            this.fld_dgcMMUpdatePositions.BOSPropertyName = null;
            this.fld_dgcMMUpdatePositions.CommodityType = "";
            this.fld_dgcMMUpdatePositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMUpdatePositions.Location = new System.Drawing.Point(12, 149);
            this.fld_dgcMMUpdatePositions.Name = "fld_dgcMMUpdatePositions";
            this.fld_dgcMMUpdatePositions.PrintReport = false;
            this.fld_dgcMMUpdatePositions.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMUpdatePositions, true);
            this.fld_dgcMMUpdatePositions.Size = new System.Drawing.Size(922, 442);
            this.fld_dgcMMUpdatePositions.TabIndex = 137;
            this.fld_dgcMMUpdatePositions.Tag = "SR";
            this.fld_dgcMMUpdatePositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMUpdatePositions;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // fld_dteMMUpdatePositionDate
            // 
            this.fld_dteMMUpdatePositionDate.BOSComment = null;
            this.fld_dteMMUpdatePositionDate.BOSDataMember = "MMUpdatePositionDateFrom";
            this.fld_dteMMUpdatePositionDate.BOSDataSource = "MMUpdatePositions";
            this.fld_dteMMUpdatePositionDate.BOSDescription = null;
            this.fld_dteMMUpdatePositionDate.BOSError = null;
            this.fld_dteMMUpdatePositionDate.BOSFieldGroup = null;
            this.fld_dteMMUpdatePositionDate.BOSFieldRelation = null;
            this.fld_dteMMUpdatePositionDate.BOSPrivilege = null;
            this.fld_dteMMUpdatePositionDate.BOSPropertyName = "EditValue";
            this.fld_dteMMUpdatePositionDate.EditValue = null;
            this.fld_dteMMUpdatePositionDate.Location = new System.Drawing.Point(127, 45);
            this.fld_dteMMUpdatePositionDate.MenuManager = this.screenToolbar;
            this.fld_dteMMUpdatePositionDate.Name = "fld_dteMMUpdatePositionDate";
            this.fld_dteMMUpdatePositionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMUpdatePositionDate.Screen = null;
            this.fld_dteMMUpdatePositionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMUpdatePositionDate.TabIndex = 138;
            this.fld_dteMMUpdatePositionDate.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "MMUpdatePositions";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = null;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(127, 97);
            this.fld_lkeFK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 139;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            // 
            // fld_lkeMMUpdatePositionStatus
            // 
            this.fld_lkeMMUpdatePositionStatus.BOSAllowAddNew = false;
            this.fld_lkeMMUpdatePositionStatus.BOSAllowDummy = false;
            this.fld_lkeMMUpdatePositionStatus.BOSComment = null;
            this.fld_lkeMMUpdatePositionStatus.BOSDataMember = "MMUpdatePositionStatus";
            this.fld_lkeMMUpdatePositionStatus.BOSDataSource = "MMUpdatePositions";
            this.fld_lkeMMUpdatePositionStatus.BOSDescription = null;
            this.fld_lkeMMUpdatePositionStatus.BOSError = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldGroup = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldParent = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldRelation = null;
            this.fld_lkeMMUpdatePositionStatus.BOSPrivilege = null;
            this.fld_lkeMMUpdatePositionStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMUpdatePositionStatus.BOSSelectType = null;
            this.fld_lkeMMUpdatePositionStatus.BOSSelectTypeValue = null;
            this.fld_lkeMMUpdatePositionStatus.CurrentDisplayText = null;
            this.fld_lkeMMUpdatePositionStatus.Location = new System.Drawing.Point(127, 123);
            this.fld_lkeMMUpdatePositionStatus.MenuManager = this.screenToolbar;
            this.fld_lkeMMUpdatePositionStatus.Name = "fld_lkeMMUpdatePositionStatus";
            this.fld_lkeMMUpdatePositionStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMUpdatePositionStatus.Properties.ColumnName = null;
            this.fld_lkeMMUpdatePositionStatus.Properties.NullText = "";
            this.fld_lkeMMUpdatePositionStatus.Screen = null;
            this.fld_lkeMMUpdatePositionStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMUpdatePositionStatus.TabIndex = 140;
            this.fld_lkeMMUpdatePositionStatus.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "MMUpdatePositionDateTo";
            this.bosDateEdit1.BOSDataSource = "MMUpdatePositions";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(127, 71);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 142;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(37, 75);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(46, 13);
            this.bosLabel3.TabIndex = 141;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Đến ngày";
            // 
            // SMUP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeMMUpdatePositionStatus);
            this.Controls.Add(this.fld_lkeFK_ICStockID);
            this.Controls.Add(this.fld_dteMMUpdatePositionDate);
            this.Controls.Add(this.fld_dgcMMUpdatePositions);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_lblLabel14);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMUP100.IconOptions.Icon")));
            this.Name = "SMUP100";
            this.Text = "Danh sách xưởng";
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMUpdatePositions, 0);
            this.Controls.SetChildIndex(this.fld_dteMMUpdatePositionDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICStockID, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMUpdatePositionStatus, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMUpdatePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSSearchResultsGridControl fld_dgcMMUpdatePositions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSDateEdit fld_dteMMUpdatePositionDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLookupEdit fld_lkeMMUpdatePositionStatus;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel3;
    }
}
