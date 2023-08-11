using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRoll.UI
{
	/// <summary>
	/// Summary description for SMHRPR100
	/// </summary>
	partial class SMHRPR100
	{
		private BOSSearchResultsGridControl fld_dgcHRPayRoll;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRPayRoll;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSTextBox fld_txtHRPayRollNo;
		private BOSComponent.BOSTextBox fld_txtHRPayRollName;
        private BOSComponent.BOSDateEdit fld_dteHRPayRollDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRPayRollType;


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
            this.fld_dgcHRPayRoll = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRPayRoll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRPayRollNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRPayRollName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRPayRollDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRPayRollType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRPayRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRPayRoll
            // 
            this.fld_dgcHRPayRoll.AllowDrop = true;
            this.fld_dgcHRPayRoll.BOSComment = "";
            this.fld_dgcHRPayRoll.BOSDataMember = "";
            this.fld_dgcHRPayRoll.BOSDataSource = "HRPayRolls";
            this.fld_dgcHRPayRoll.BOSDescription = null;
            this.fld_dgcHRPayRoll.BOSError = null;
            this.fld_dgcHRPayRoll.BOSFieldGroup = "";
            this.fld_dgcHRPayRoll.BOSFieldRelation = "";
            this.fld_dgcHRPayRoll.BOSPrivilege = "";
            this.fld_dgcHRPayRoll.BOSPropertyName = "";
            this.fld_dgcHRPayRoll.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRPayRoll.Location = new System.Drawing.Point(20, 168);
            this.fld_dgcHRPayRoll.MainView = this.fld_dgvHRPayRoll;
            this.fld_dgcHRPayRoll.Name = "fld_dgcHRPayRoll";
            this.fld_dgcHRPayRoll.Screen = null;
            this.fld_dgcHRPayRoll.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRPayRoll.TabIndex = 4;
            this.fld_dgcHRPayRoll.Tag = "SR";
            this.fld_dgcHRPayRoll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRPayRoll});
            // 
            // fld_dgvHRPayRoll
            // 
            this.fld_dgvHRPayRoll.GridControl = this.fld_dgcHRPayRoll;
            this.fld_dgvHRPayRoll.Name = "fld_dgvHRPayRoll";
            this.fld_dgvHRPayRoll.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel
            // 
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
            this.fld_lblLabel.Location = new System.Drawing.Point(60, 19);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã bảng lương";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(60, 43);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel1.TabIndex = 6;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên bảng lương";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(60, 67);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel2.TabIndex = 7;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Tháng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(60, 91);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Loại bảng lương";
            // 
            // fld_txtHRPayRollNo
            // 
            this.fld_txtHRPayRollNo.BOSComment = "";
            this.fld_txtHRPayRollNo.BOSDataMember = "HRPayRollNo";
            this.fld_txtHRPayRollNo.BOSDataSource = "HRPayRolls";
            this.fld_txtHRPayRollNo.BOSDescription = null;
            this.fld_txtHRPayRollNo.BOSError = null;
            this.fld_txtHRPayRollNo.BOSFieldGroup = "";
            this.fld_txtHRPayRollNo.BOSFieldRelation = "";
            this.fld_txtHRPayRollNo.BOSPrivilege = "";
            this.fld_txtHRPayRollNo.BOSPropertyName = "Text";
            this.fld_txtHRPayRollNo.EditValue = "";
            this.fld_txtHRPayRollNo.Location = new System.Drawing.Point(182, 16);
            this.fld_txtHRPayRollNo.Name = "fld_txtHRPayRollNo";
            this.fld_txtHRPayRollNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollNo.Screen = null;
            this.fld_txtHRPayRollNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRPayRollNo.TabIndex = 10;
            this.fld_txtHRPayRollNo.Tag = "SC";
            // 
            // fld_txtHRPayRollName
            // 
            this.fld_txtHRPayRollName.BOSComment = "";
            this.fld_txtHRPayRollName.BOSDataMember = "HRPayRollName";
            this.fld_txtHRPayRollName.BOSDataSource = "HRPayRolls";
            this.fld_txtHRPayRollName.BOSDescription = null;
            this.fld_txtHRPayRollName.BOSError = null;
            this.fld_txtHRPayRollName.BOSFieldGroup = "";
            this.fld_txtHRPayRollName.BOSFieldRelation = "";
            this.fld_txtHRPayRollName.BOSPrivilege = "";
            this.fld_txtHRPayRollName.BOSPropertyName = "Text";
            this.fld_txtHRPayRollName.EditValue = "";
            this.fld_txtHRPayRollName.Location = new System.Drawing.Point(182, 40);
            this.fld_txtHRPayRollName.Name = "fld_txtHRPayRollName";
            this.fld_txtHRPayRollName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollName.Screen = null;
            this.fld_txtHRPayRollName.Size = new System.Drawing.Size(335, 20);
            this.fld_txtHRPayRollName.TabIndex = 11;
            this.fld_txtHRPayRollName.Tag = "SC";
            // 
            // fld_dteHRPayRollDate
            // 
            this.fld_dteHRPayRollDate.BOSComment = "";
            this.fld_dteHRPayRollDate.BOSDataMember = "HRPayRollDate";
            this.fld_dteHRPayRollDate.BOSDataSource = "HRPayRolls";
            this.fld_dteHRPayRollDate.BOSDescription = null;
            this.fld_dteHRPayRollDate.BOSError = null;
            this.fld_dteHRPayRollDate.BOSFieldGroup = "";
            this.fld_dteHRPayRollDate.BOSFieldRelation = "";
            this.fld_dteHRPayRollDate.BOSPrivilege = "";
            this.fld_dteHRPayRollDate.BOSPropertyName = "EditValue";
            this.fld_dteHRPayRollDate.EditValue = null;
            this.fld_dteHRPayRollDate.Location = new System.Drawing.Point(182, 64);
            this.fld_dteHRPayRollDate.Name = "fld_dteHRPayRollDate";
            this.fld_dteHRPayRollDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRPayRollDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRPayRollDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRPayRollDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRPayRollDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRPayRollDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRPayRollDate.Screen = null;
            this.fld_dteHRPayRollDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRPayRollDate.TabIndex = 12;
            this.fld_dteHRPayRollDate.Tag = "SC";
            // 
            // fld_lkeHRPayRollType
            // 
            this.fld_lkeHRPayRollType.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollType.BOSAllowDummy = true;
            this.fld_lkeHRPayRollType.BOSComment = "";
            this.fld_lkeHRPayRollType.BOSDataMember = "HRPayRollType";
            this.fld_lkeHRPayRollType.BOSDataSource = "HRPayRolls";
            this.fld_lkeHRPayRollType.BOSDescription = null;
            this.fld_lkeHRPayRollType.BOSError = null;
            this.fld_lkeHRPayRollType.BOSFieldGroup = "";
            this.fld_lkeHRPayRollType.BOSFieldParent = "";
            this.fld_lkeHRPayRollType.BOSFieldRelation = "";
            this.fld_lkeHRPayRollType.BOSPrivilege = "";
            this.fld_lkeHRPayRollType.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollType.BOSSelectType = "";
            this.fld_lkeHRPayRollType.BOSSelectTypeValue = "";
            this.fld_lkeHRPayRollType.CurrentDisplayText = null;
            this.fld_lkeHRPayRollType.Location = new System.Drawing.Point(182, 88);
            this.fld_lkeHRPayRollType.Name = "fld_lkeHRPayRollType";
            this.fld_lkeHRPayRollType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRPayRollType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRPayRollType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRPayRollType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRPayRollType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollType.Properties.NullText = "";
            this.fld_lkeHRPayRollType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRPayRollType.Screen = null;
            this.fld_lkeHRPayRollType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollType.TabIndex = 15;
            this.fld_lkeHRPayRollType.Tag = "SC";
            // 
            // SMHRPR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRPayRoll);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtHRPayRollNo);
            this.Controls.Add(this.fld_txtHRPayRollName);
            this.Controls.Add(this.fld_dteHRPayRollDate);
            this.Controls.Add(this.fld_lkeHRPayRollType);
            this.Name = "SMHRPR100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeHRPayRollType, 0);
            this.Controls.SetChildIndex(this.fld_dteHRPayRollDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRPayRollName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRPayRollNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRPayRoll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRPayRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
