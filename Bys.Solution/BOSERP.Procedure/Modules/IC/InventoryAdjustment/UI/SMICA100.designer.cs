using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryAdjustment.UI
{
	/// <summary>
	/// Summary description for SMICA100
	/// </summary>
	partial class SMICA100
	{
		private BOSComponent.BOSTextBox fld_txtICAdjustmentNo;
		private BOSComponent.BOSLabel fld_lblICAdjustmentEmployeeId;
		private BOSComponent.BOSLabel fld_lblICAdjustmentDateFrom;
        private BOSComponent.BOSLabel fld_lblICAdjustmentDateTo;
		private BOSComponent.BOSLabel fld_lblICAdjustmentNo;
		private BOSComponent.BOSGridControl fld_dgcICAdjustment;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICAdjustment;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICAdjustmentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToICAdjustmentDate;


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
            this.fld_txtICAdjustmentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblICAdjustmentEmployeeId = new BOSComponent.BOSLabel(this.components);
            this.fld_lblICAdjustmentDateFrom = new BOSComponent.BOSLabel(this.components);
            this.fld_lblICAdjustmentDateTo = new BOSComponent.BOSLabel(this.components);
            this.fld_lblICAdjustmentNo = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICAdjustment = new BOSComponent.BOSGridControl(this.components);
            this.fld_dgvICAdjustment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromICAdjustmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICAdjustmentDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICAdjustmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICAdjustmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICAdjustmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICAdjustmentDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtICAdjustmentNo
            // 
            this.fld_txtICAdjustmentNo.BOSComment = "";
            this.fld_txtICAdjustmentNo.BOSDataMember = "ICAdjustmentNo";
            this.fld_txtICAdjustmentNo.BOSDataSource = "ICAdjustments";
            this.fld_txtICAdjustmentNo.BOSDescription = null;
            this.fld_txtICAdjustmentNo.BOSError = null;
            this.fld_txtICAdjustmentNo.BOSFieldGroup = "";
            this.fld_txtICAdjustmentNo.BOSFieldRelation = "";
            this.fld_txtICAdjustmentNo.BOSPrivilege = "";
            this.fld_txtICAdjustmentNo.BOSPropertyName = null;
            this.fld_txtICAdjustmentNo.EditValue = "";
            this.fld_txtICAdjustmentNo.Location = new System.Drawing.Point(149, 30);
            this.fld_txtICAdjustmentNo.Name = "fld_txtICAdjustmentNo";
            this.fld_txtICAdjustmentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAdjustmentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAdjustmentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAdjustmentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAdjustmentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAdjustmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAdjustmentNo.Screen = null;
            this.fld_txtICAdjustmentNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICAdjustmentNo.TabIndex = 4;
            this.fld_txtICAdjustmentNo.Tag = "SC";
            // 
            // fld_lblICAdjustmentEmployeeId
            // 
            this.fld_lblICAdjustmentEmployeeId.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentEmployeeId.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentEmployeeId.Appearance.Options.UseBackColor = true;
            this.fld_lblICAdjustmentEmployeeId.Appearance.Options.UseForeColor = true;
            this.fld_lblICAdjustmentEmployeeId.BOSComment = "";
            this.fld_lblICAdjustmentEmployeeId.BOSDataMember = "";
            this.fld_lblICAdjustmentEmployeeId.BOSDataSource = "";
            this.fld_lblICAdjustmentEmployeeId.BOSDescription = null;
            this.fld_lblICAdjustmentEmployeeId.BOSError = null;
            this.fld_lblICAdjustmentEmployeeId.BOSFieldGroup = "";
            this.fld_lblICAdjustmentEmployeeId.BOSFieldRelation = "";
            this.fld_lblICAdjustmentEmployeeId.BOSPrivilege = "";
            this.fld_lblICAdjustmentEmployeeId.BOSPropertyName = null;
            this.fld_lblICAdjustmentEmployeeId.Location = new System.Drawing.Point(33, 63);
            this.fld_lblICAdjustmentEmployeeId.Name = "fld_lblICAdjustmentEmployeeId";
            this.fld_lblICAdjustmentEmployeeId.Screen = null;
            this.fld_lblICAdjustmentEmployeeId.Size = new System.Drawing.Size(48, 13);
            this.fld_lblICAdjustmentEmployeeId.TabIndex = 13;
            this.fld_lblICAdjustmentEmployeeId.Tag = "";
            this.fld_lblICAdjustmentEmployeeId.Text = "Nhân viên";
            // 
            // fld_lblICAdjustmentDateFrom
            // 
            this.fld_lblICAdjustmentDateFrom.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentDateFrom.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentDateFrom.Appearance.Options.UseBackColor = true;
            this.fld_lblICAdjustmentDateFrom.Appearance.Options.UseForeColor = true;
            this.fld_lblICAdjustmentDateFrom.BOSComment = "";
            this.fld_lblICAdjustmentDateFrom.BOSDataMember = "";
            this.fld_lblICAdjustmentDateFrom.BOSDataSource = "";
            this.fld_lblICAdjustmentDateFrom.BOSDescription = null;
            this.fld_lblICAdjustmentDateFrom.BOSError = null;
            this.fld_lblICAdjustmentDateFrom.BOSFieldGroup = "";
            this.fld_lblICAdjustmentDateFrom.BOSFieldRelation = "";
            this.fld_lblICAdjustmentDateFrom.BOSPrivilege = "";
            this.fld_lblICAdjustmentDateFrom.BOSPropertyName = null;
            this.fld_lblICAdjustmentDateFrom.Location = new System.Drawing.Point(33, 93);
            this.fld_lblICAdjustmentDateFrom.Name = "fld_lblICAdjustmentDateFrom";
            this.fld_lblICAdjustmentDateFrom.Screen = null;
            this.fld_lblICAdjustmentDateFrom.Size = new System.Drawing.Size(58, 13);
            this.fld_lblICAdjustmentDateFrom.TabIndex = 14;
            this.fld_lblICAdjustmentDateFrom.Tag = "";
            this.fld_lblICAdjustmentDateFrom.Text = "Ngày tạo từ";
            // 
            // fld_lblICAdjustmentDateTo
            // 
            this.fld_lblICAdjustmentDateTo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentDateTo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentDateTo.Appearance.Options.UseBackColor = true;
            this.fld_lblICAdjustmentDateTo.Appearance.Options.UseForeColor = true;
            this.fld_lblICAdjustmentDateTo.BOSComment = "";
            this.fld_lblICAdjustmentDateTo.BOSDataMember = "";
            this.fld_lblICAdjustmentDateTo.BOSDataSource = "";
            this.fld_lblICAdjustmentDateTo.BOSDescription = null;
            this.fld_lblICAdjustmentDateTo.BOSError = null;
            this.fld_lblICAdjustmentDateTo.BOSFieldGroup = "";
            this.fld_lblICAdjustmentDateTo.BOSFieldRelation = "";
            this.fld_lblICAdjustmentDateTo.BOSPrivilege = "";
            this.fld_lblICAdjustmentDateTo.BOSPropertyName = null;
            this.fld_lblICAdjustmentDateTo.Location = new System.Drawing.Point(323, 93);
            this.fld_lblICAdjustmentDateTo.Name = "fld_lblICAdjustmentDateTo";
            this.fld_lblICAdjustmentDateTo.Screen = null;
            this.fld_lblICAdjustmentDateTo.Size = new System.Drawing.Size(20, 13);
            this.fld_lblICAdjustmentDateTo.TabIndex = 15;
            this.fld_lblICAdjustmentDateTo.Tag = "";
            this.fld_lblICAdjustmentDateTo.Text = "Đến";
            // 
            // fld_lblICAdjustmentNo
            // 
            this.fld_lblICAdjustmentNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblICAdjustmentNo.Appearance.Options.UseBackColor = true;
            this.fld_lblICAdjustmentNo.Appearance.Options.UseForeColor = true;
            this.fld_lblICAdjustmentNo.BOSComment = "";
            this.fld_lblICAdjustmentNo.BOSDataMember = "";
            this.fld_lblICAdjustmentNo.BOSDataSource = "";
            this.fld_lblICAdjustmentNo.BOSDescription = null;
            this.fld_lblICAdjustmentNo.BOSError = null;
            this.fld_lblICAdjustmentNo.BOSFieldGroup = "";
            this.fld_lblICAdjustmentNo.BOSFieldRelation = "";
            this.fld_lblICAdjustmentNo.BOSPrivilege = "";
            this.fld_lblICAdjustmentNo.BOSPropertyName = null;
            this.fld_lblICAdjustmentNo.Location = new System.Drawing.Point(33, 33);
            this.fld_lblICAdjustmentNo.Name = "fld_lblICAdjustmentNo";
            this.fld_lblICAdjustmentNo.Screen = null;
            this.fld_lblICAdjustmentNo.Size = new System.Drawing.Size(14, 13);
            this.fld_lblICAdjustmentNo.TabIndex = 22;
            this.fld_lblICAdjustmentNo.Tag = "";
            this.fld_lblICAdjustmentNo.Text = "Mã";
            // 
            // fld_dgcICAdjustment
            // 
            this.fld_dgcICAdjustment.AllowDrop = true;
            this.fld_dgcICAdjustment.BOSComment = "";
            this.fld_dgcICAdjustment.BOSDataMember = "";
            this.fld_dgcICAdjustment.BOSDataSource = "ICAdjustments";
            this.fld_dgcICAdjustment.BOSDescription = null;
            this.fld_dgcICAdjustment.BOSError = null;
            this.fld_dgcICAdjustment.BOSFieldGroup = "";
            this.fld_dgcICAdjustment.BOSFieldRelation = "";
            this.fld_dgcICAdjustment.BOSGridType = null;
            this.fld_dgcICAdjustment.BOSPrivilege = "";
            this.fld_dgcICAdjustment.BOSPropertyName = null;
            this.fld_dgcICAdjustment.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICAdjustment.Location = new System.Drawing.Point(25, 145);
            this.fld_dgcICAdjustment.MainView = this.fld_dgvICAdjustment;
            this.fld_dgcICAdjustment.Name = "fld_dgcICAdjustment";
            this.fld_dgcICAdjustment.Screen = null;
            this.fld_dgcICAdjustment.Size = new System.Drawing.Size(700, 400);
            this.fld_dgcICAdjustment.TabIndex = 10;
            this.fld_dgcICAdjustment.Tag = "SR";
            this.fld_dgcICAdjustment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICAdjustment});
            // 
            // fld_dgvICAdjustment
            // 
            this.fld_dgvICAdjustment.GridControl = this.fld_dgcICAdjustment;
            this.fld_dgvICAdjustment.Name = "fld_dgvICAdjustment";
            this.fld_dgvICAdjustment.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICAdjustments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(149, 60);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 23;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_dteSearchFromICAdjustmentDate
            // 
            this.fld_dteSearchFromICAdjustmentDate.BOSComment = "";
            this.fld_dteSearchFromICAdjustmentDate.BOSDataMember = "ICAdjustmentDate";
            this.fld_dteSearchFromICAdjustmentDate.BOSDataSource = "ICAdjustments";
            this.fld_dteSearchFromICAdjustmentDate.BOSDescription = null;
            this.fld_dteSearchFromICAdjustmentDate.BOSError = null;
            this.fld_dteSearchFromICAdjustmentDate.BOSFieldGroup = "";
            this.fld_dteSearchFromICAdjustmentDate.BOSFieldRelation = "";
            this.fld_dteSearchFromICAdjustmentDate.BOSPrivilege = "";
            this.fld_dteSearchFromICAdjustmentDate.BOSPropertyName = null;
            this.fld_dteSearchFromICAdjustmentDate.EditValue = null;
            this.fld_dteSearchFromICAdjustmentDate.Location = new System.Drawing.Point(149, 90);
            this.fld_dteSearchFromICAdjustmentDate.Name = "fld_dteSearchFromICAdjustmentDate";
            this.fld_dteSearchFromICAdjustmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICAdjustmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICAdjustmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICAdjustmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICAdjustmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICAdjustmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICAdjustmentDate.Screen = null;
            this.fld_dteSearchFromICAdjustmentDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromICAdjustmentDate.TabIndex = 16;
            this.fld_dteSearchFromICAdjustmentDate.Tag = "SC";
            // 
            // fld_dteSearchToICAdjustmentDate
            // 
            this.fld_dteSearchToICAdjustmentDate.BOSComment = "";
            this.fld_dteSearchToICAdjustmentDate.BOSDataMember = "ICAdjustmentDate";
            this.fld_dteSearchToICAdjustmentDate.BOSDataSource = "ICAdjustments";
            this.fld_dteSearchToICAdjustmentDate.BOSDescription = null;
            this.fld_dteSearchToICAdjustmentDate.BOSError = null;
            this.fld_dteSearchToICAdjustmentDate.BOSFieldGroup = "";
            this.fld_dteSearchToICAdjustmentDate.BOSFieldRelation = "";
            this.fld_dteSearchToICAdjustmentDate.BOSPrivilege = "";
            this.fld_dteSearchToICAdjustmentDate.BOSPropertyName = null;
            this.fld_dteSearchToICAdjustmentDate.EditValue = null;
            this.fld_dteSearchToICAdjustmentDate.Location = new System.Drawing.Point(362, 90);
            this.fld_dteSearchToICAdjustmentDate.Name = "fld_dteSearchToICAdjustmentDate";
            this.fld_dteSearchToICAdjustmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICAdjustmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICAdjustmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICAdjustmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICAdjustmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICAdjustmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICAdjustmentDate.Screen = null;
            this.fld_dteSearchToICAdjustmentDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToICAdjustmentDate.TabIndex = 17;
            this.fld_dteSearchToICAdjustmentDate.Tag = "SC";
            // 
            // SMICA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtICAdjustmentNo);
            this.Controls.Add(this.fld_lblICAdjustmentEmployeeId);
            this.Controls.Add(this.fld_lblICAdjustmentDateFrom);
            this.Controls.Add(this.fld_lblICAdjustmentDateTo);
            this.Controls.Add(this.fld_lblICAdjustmentNo);
            this.Controls.Add(this.fld_dgcICAdjustment);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_dteSearchFromICAdjustmentDate);
            this.Controls.Add(this.fld_dteSearchToICAdjustmentDate);
            this.Name = "SMICA100";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAdjustmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICAdjustmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICAdjustmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICAdjustmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICAdjustmentDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
