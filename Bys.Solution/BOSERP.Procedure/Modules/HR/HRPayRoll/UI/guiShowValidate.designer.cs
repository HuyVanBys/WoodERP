using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRoll
{
	/// <summary>
	/// Summary description for DSPL101
	/// </summary>
	partial class guiShowValidate
    {
        private BOSComponent.BOSButton fld_btnOk;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowValidate));
            this.fld_btnOk = new BOSComponent.BOSButton(this.components);
            this.fld_lblName = new BOSComponent.BOSLabel(this.components);
            this.fld_btnValidated = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeePayRollValidates = new BOSERP.Modules.HRPayRoll.HREmployeePayRollValidatesGridControl();
            this.fld_dgvHREmployeePayRolls = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollValidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOk
            // 
            this.fld_btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnOk.Appearance.Options.UseForeColor = true;
            this.fld_btnOk.BOSComment = string.Empty;
            this.fld_btnOk.BOSDataMember = string.Empty;
            this.fld_btnOk.BOSDataSource = string.Empty;
            this.fld_btnOk.BOSDescription = null;
            this.fld_btnOk.BOSError = null;
            this.fld_btnOk.BOSFieldGroup = string.Empty;
            this.fld_btnOk.BOSFieldRelation = string.Empty;
            this.fld_btnOk.BOSPrivilege = string.Empty;
            this.fld_btnOk.BOSPropertyName = null;
            this.fld_btnOk.Location = new System.Drawing.Point(554, 313);
            this.fld_btnOk.Name = "fld_btnOk";
            this.fld_btnOk.Screen = null;
            this.fld_btnOk.Size = new System.Drawing.Size(85, 27);
            this.fld_btnOk.TabIndex = 10;
            this.fld_btnOk.Tag = string.Empty;
            this.fld_btnOk.Text = "Đóng";
            this.fld_btnOk.Click += new System.EventHandler(this.fld_btnOk_Click);
            // 
            // fld_lblName
            // 
            this.fld_lblName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblName.Appearance.Options.UseBackColor = true;
            this.fld_lblName.Appearance.Options.UseFont = true;
            this.fld_lblName.Appearance.Options.UseForeColor = true;
            this.fld_lblName.BOSComment = string.Empty;
            this.fld_lblName.BOSDataMember = string.Empty;
            this.fld_lblName.BOSDataSource = string.Empty;
            this.fld_lblName.BOSDescription = null;
            this.fld_lblName.BOSError = null;
            this.fld_lblName.BOSFieldGroup = string.Empty;
            this.fld_lblName.BOSFieldRelation = string.Empty;
            this.fld_lblName.BOSPrivilege = string.Empty;
            this.fld_lblName.BOSPropertyName = null;
            this.fld_lblName.Location = new System.Drawing.Point(12, 12);
            this.fld_lblName.Name = "fld_lblName";
            this.fld_lblName.Screen = null;
            this.fld_lblName.Size = new System.Drawing.Size(83, 19);
            this.fld_lblName.TabIndex = 4;
            this.fld_lblName.Tag = string.Empty;
            this.fld_lblName.Text = "Danh sách";
            // 
            // fld_btnValidated
            // 
            this.fld_btnValidated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnValidated.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnValidated.Appearance.Options.UseForeColor = true;
            this.fld_btnValidated.BOSComment = string.Empty;
            this.fld_btnValidated.BOSDataMember = string.Empty;
            this.fld_btnValidated.BOSDataSource = string.Empty;
            this.fld_btnValidated.BOSDescription = null;
            this.fld_btnValidated.BOSError = null;
            this.fld_btnValidated.BOSFieldGroup = string.Empty;
            this.fld_btnValidated.BOSFieldRelation = string.Empty;
            this.fld_btnValidated.BOSPrivilege = string.Empty;
            this.fld_btnValidated.BOSPropertyName = null;
            this.fld_btnValidated.Location = new System.Drawing.Point(645, 313);
            this.fld_btnValidated.Name = "fld_btnValidated";
            this.fld_btnValidated.Screen = null;
            this.fld_btnValidated.Size = new System.Drawing.Size(85, 27);
            this.fld_btnValidated.TabIndex = 11;
            this.fld_btnValidated.Tag = string.Empty;
            this.fld_btnValidated.Text = "Kiểm tra xong";
            this.fld_btnValidated.Click += new System.EventHandler(this.fld_btnValidated_Click);
            // 
            // fld_dgcHREmployeePayRollValidates
            // 
            this.fld_dgcHREmployeePayRollValidates.AllowDrop = true;
            this.fld_dgcHREmployeePayRollValidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePayRollValidates.BOSComment = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.BOSDataMember = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.BOSDataSource = "HREmployeePayRolls";
            this.fld_dgcHREmployeePayRollValidates.BOSDescription = null;
            this.fld_dgcHREmployeePayRollValidates.BOSError = null;
            this.fld_dgcHREmployeePayRollValidates.BOSFieldGroup = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.BOSFieldRelation = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.BOSGridType = null;
            this.fld_dgcHREmployeePayRollValidates.BOSPrivilege = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.BOSPropertyName = string.Empty;
            this.fld_dgcHREmployeePayRollValidates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePayRollValidates.Location = new System.Drawing.Point(2, 37);
            this.fld_dgcHREmployeePayRollValidates.MainView = this.fld_dgvHREmployeePayRolls;
            this.fld_dgcHREmployeePayRollValidates.Name = "fld_dgcHREmployeePayRollValidates";
            this.fld_dgcHREmployeePayRollValidates.PrintReport = false;
            this.fld_dgcHREmployeePayRollValidates.Screen = null;
            this.fld_dgcHREmployeePayRollValidates.Size = new System.Drawing.Size(737, 270);
            this.fld_dgcHREmployeePayRollValidates.TabIndex = 12;
            this.fld_dgcHREmployeePayRollValidates.Tag = "DC";
            this.fld_dgcHREmployeePayRollValidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeePayRolls});
            // 
            // fld_dgvHREmployeePayRolls
            // 
            this.fld_dgvHREmployeePayRolls.GridControl = this.fld_dgcHREmployeePayRollValidates;
            this.fld_dgvHREmployeePayRolls.Name = "fld_dgvHREmployeePayRolls";
            this.fld_dgvHREmployeePayRolls.PaintStyleName = "Office2003";
            // 
            // guiShowValidate
            // 
            this.AcceptButton = this.fld_btnOk;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(742, 352);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcHREmployeePayRollValidates);
            this.Controls.Add(this.fld_btnValidated);
            this.Controls.Add(this.fld_btnOk);
            this.Controls.Add(this.fld_lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiShowValidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.guiShowValidate_Load);
            this.Controls.SetChildIndex(this.fld_lblName, 0);
            this.Controls.SetChildIndex(this.fld_btnOk, 0);
            this.Controls.SetChildIndex(this.fld_btnValidated, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployeePayRollValidates, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollValidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblName;
        private BOSComponent.BOSButton fld_btnValidated;
        private HREmployeePayRollValidatesGridControl fld_dgcHREmployeePayRollValidates;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePayRolls;
	}
}
