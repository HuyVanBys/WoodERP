using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Package.UI
{
	/// <summary>
	/// Summary description for SMPK100
	/// </summary>
	partial class SMPK100
	{
		private BOSComponent.BOSTextBox fld_txtICPackagePackNo;
		private BOSComponent.BOSTextBox fld_txtICPackageNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSSearchResultsGridControl fld_dgcICPackage;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICPackage;


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
            this.fld_txtICPackagePackNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPackageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICPackage = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICPackage = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackagePackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtICPackagePackNo
            // 
            this.fld_txtICPackagePackNo.BOSComment = "";
            this.fld_txtICPackagePackNo.BOSDataMember = "ICPackagePackNo";
            this.fld_txtICPackagePackNo.BOSDataSource = "ICPackages";
            this.fld_txtICPackagePackNo.BOSDescription = null;
            this.fld_txtICPackagePackNo.BOSError = null;
            this.fld_txtICPackagePackNo.BOSFieldGroup = "";
            this.fld_txtICPackagePackNo.BOSFieldRelation = "";
            this.fld_txtICPackagePackNo.BOSPrivilege = "";
            this.fld_txtICPackagePackNo.BOSPropertyName = "Text";
            this.fld_txtICPackagePackNo.EditValue = "";
            this.fld_txtICPackagePackNo.Location = new System.Drawing.Point(96, 35);
            this.fld_txtICPackagePackNo.Name = "fld_txtICPackagePackNo";
            this.fld_txtICPackagePackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackagePackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackagePackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackagePackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackagePackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackagePackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackagePackNo.Screen = null;
            this.fld_txtICPackagePackNo.Size = new System.Drawing.Size(207, 20);
            this.fld_txtICPackagePackNo.TabIndex = 1;
            this.fld_txtICPackagePackNo.Tag = "SC";
            // 
            // fld_txtICPackageNo
            // 
            this.fld_txtICPackageNo.BOSComment = "";
            this.fld_txtICPackageNo.BOSDataMember = "ICPackageNo";
            this.fld_txtICPackageNo.BOSDataSource = "ICPackages";
            this.fld_txtICPackageNo.BOSDescription = null;
            this.fld_txtICPackageNo.BOSError = null;
            this.fld_txtICPackageNo.BOSFieldGroup = "";
            this.fld_txtICPackageNo.BOSFieldRelation = "";
            this.fld_txtICPackageNo.BOSPrivilege = "";
            this.fld_txtICPackageNo.BOSPropertyName = "Text";
            this.fld_txtICPackageNo.EditValue = "";
            this.fld_txtICPackageNo.Location = new System.Drawing.Point(96, 9);
            this.fld_txtICPackageNo.Name = "fld_txtICPackageNo";
            this.fld_txtICPackageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageNo.Screen = null;
            this.fld_txtICPackageNo.Size = new System.Drawing.Size(207, 20);
            this.fld_txtICPackageNo.TabIndex = 0;
            this.fld_txtICPackageNo.Tag = "SC";
            this.fld_txtICPackageNo.EditValueChanged += new System.EventHandler(this.fld_txtICPackageNo_EditValueChanged);
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = "";
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICPackages";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(96, 61);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierNo";
            this.fld_lkeFK_APSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(207, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 2;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel.Location = new System.Drawing.Point(12, 38);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel.TabIndex = 9;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã lô hàng";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel1.TabIndex = 10;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Mã kiện";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(12, 64);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel2.TabIndex = 11;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhà cung cấp";
            // 
            // fld_dgcICPackage
            // 
            this.fld_dgcICPackage.AllowDrop = true;
            this.fld_dgcICPackage.BOSComment = "";
            this.fld_dgcICPackage.BOSDataMember = "";
            this.fld_dgcICPackage.BOSDataSource = "ICPackages";
            this.fld_dgcICPackage.BOSDescription = null;
            this.fld_dgcICPackage.BOSError = null;
            this.fld_dgcICPackage.BOSFieldGroup = "";
            this.fld_dgcICPackage.BOSFieldRelation = "";
            this.fld_dgcICPackage.BOSPrivilege = "";
            this.fld_dgcICPackage.BOSPropertyName = "";
            this.fld_dgcICPackage.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICPackage.Location = new System.Drawing.Point(217, 235);
            this.fld_dgcICPackage.MainView = this.fld_dgvICPackage;
            this.fld_dgcICPackage.Name = "fld_dgcICPackage";
            this.fld_dgcICPackage.Screen = null;
            this.fld_dgcICPackage.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcICPackage.TabIndex = 12;
            this.fld_dgcICPackage.Tag = "SR";
            this.fld_dgcICPackage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICPackage});
            // 
            // fld_dgvICPackage
            // 
            this.fld_dgvICPackage.GridControl = this.fld_dgcICPackage;
            this.fld_dgvICPackage.Name = "fld_dgvICPackage";
            this.fld_dgvICPackage.PaintStyleName = "Office2003";
            // 
            // SMPK100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcICPackage);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtICPackagePackNo);
            this.Controls.Add(this.fld_txtICPackageNo);
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Name = "SMPK100";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackagePackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
