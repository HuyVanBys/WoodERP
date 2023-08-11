using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationEmployee.UI
{
	/// <summary>
	/// Summary description for DMHREE101
	/// </summary>
	partial class DMHREE101
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREvaluationDetails = new BOSERP.Modules.HREvaluationEmployee.HREvaluationDetailsGridControl();
            this.fld_dgvHREvaluationDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluationDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lblLabel14);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(723, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = "";
            this.fld_lblLabel14.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel14.TabIndex = 9;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Nhân viên";
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
            this.fld_grcGroupControl3.BOSComment = "";
            this.fld_grcGroupControl3.BOSDataMember = "";
            this.fld_grcGroupControl3.BOSDataSource = "";
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "";
            this.fld_grcGroupControl3.BOSFieldRelation = "";
            this.fld_grcGroupControl3.BOSPrivilege = "";
            this.fld_grcGroupControl3.BOSPropertyName = "";
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHREvaluationDetails);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 35);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(715, 530);
            this.fld_grcGroupControl3.TabIndex = 10;
            this.fld_grcGroupControl3.Tag = "";
            this.fld_grcGroupControl3.Text = "Các tiêu chí đánh giá";
            // 
            // fld_dgcHREvaluationDetails
            // 
            this.fld_dgcHREvaluationDetails.AllowDrop = true;
            this.fld_dgcHREvaluationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREvaluationDetails.BOSComment = "";
            this.fld_dgcHREvaluationDetails.BOSDataMember = "";
            this.fld_dgcHREvaluationDetails.BOSDataSource = "HREvaluationDetails";
            this.fld_dgcHREvaluationDetails.BOSDescription = null;
            this.fld_dgcHREvaluationDetails.BOSError = null;
            this.fld_dgcHREvaluationDetails.BOSFieldGroup = "";
            this.fld_dgcHREvaluationDetails.BOSFieldRelation = "";
            this.fld_dgcHREvaluationDetails.BOSGridType = null;
            this.fld_dgcHREvaluationDetails.BOSPrivilege = "";
            this.fld_dgcHREvaluationDetails.BOSPropertyName = "";
            this.fld_dgcHREvaluationDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREvaluationDetails.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREvaluationDetails.MainView = this.fld_dgvHREvaluationDetails;
            this.fld_dgcHREvaluationDetails.Name = "fld_dgcHREvaluationDetails";
            this.fld_dgcHREvaluationDetails.Screen = null;
            this.fld_dgcHREvaluationDetails.Size = new System.Drawing.Size(711, 503);
            this.fld_dgcHREvaluationDetails.TabIndex = 7;
            this.fld_dgcHREvaluationDetails.Tag = "DC";
            this.fld_dgcHREvaluationDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREvaluationDetails});
            // 
            // fld_dgvHREvaluationDetails
            // 
            this.fld_dgvHREvaluationDetails.GridControl = this.fld_dgcHREvaluationDetails;
            this.fld_dgvHREvaluationDetails.Name = "fld_dgvHREvaluationDetails";
            this.fld_dgvHREvaluationDetails.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID2
            // 
            this.fld_lkeFK_HREmployeeID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID2.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID2.BOSComment = "";
            this.fld_lkeFK_HREmployeeID2.BOSDataMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID2.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HREmployeeID2.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID2.BOSError = null;
            this.fld_lkeFK_HREmployeeID2.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID2.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID2.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID2.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID2.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID2.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID2.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID2.Location = new System.Drawing.Point(76, 9);
            this.fld_lkeFK_HREmployeeID2.Name = "fld_lkeFK_HREmployeeID2";
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID2.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID2.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID2.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID2.Screen = null;
            this.fld_lkeFK_HREmployeeID2.Size = new System.Drawing.Size(251, 20);
            this.fld_lkeFK_HREmployeeID2.TabIndex = 11;
            this.fld_lkeFK_HREmployeeID2.Tag = "DC";
            this.fld_lkeFK_HREmployeeID2.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID2_Validated);
            // 
            // DMHREE101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(723, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHREE101";
            this.Text = "Chi tiết đánh giá";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluationDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID2;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private HREvaluationDetailsGridControl fld_dgcHREvaluationDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREvaluationDetails;
	}
}
