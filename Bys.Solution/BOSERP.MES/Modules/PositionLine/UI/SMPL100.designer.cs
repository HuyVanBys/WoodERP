using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PositionLine.UI
{
    /// <summary>
    /// Summary description for SMPL100
    /// </summary>
    partial class SMPL100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMPL100));
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMPositions = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(37, 35);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel12.TabIndex = 18;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Mã xưởng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMPositionNo";
            this.bosTextBox1.BOSDataSource = "MMPositions";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "Mã kho không thể rỗng";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(127, 31);
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
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMPositionName";
            this.bosTextBox2.BOSDataSource = "MMPositions";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(127, 57);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 1;
            this.bosTextBox2.Tag = "SC";
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(37, 61);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel14.TabIndex = 20;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Tên xưởng";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "MMPositionSymbol";
            this.bosTextBox3.BOSDataSource = "MMPositions";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = "";
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(127, 83);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 21;
            this.bosTextBox3.Tag = "SC";
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
            this.bosLabel1.Location = new System.Drawing.Point(37, 87);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 22;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Ký hiệu";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "MMPositionLevel";
            this.bosTextBox4.BOSDataSource = "MMPositions";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = "";
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Location = new System.Drawing.Point(127, 109);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 23;
            this.bosTextBox4.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(37, 113);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(26, 13);
            this.bosLabel2.TabIndex = 24;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Level";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = "";
            this.bosTextBox5.BOSDataMember = "MMPositionGELocationName";
            this.bosTextBox5.BOSDataSource = "MMPositions";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = "";
            this.bosTextBox5.BOSFieldGroup = "";
            this.bosTextBox5.BOSFieldRelation = "";
            this.bosTextBox5.BOSPrivilege = "";
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Location = new System.Drawing.Point(127, 135);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 25;
            this.bosTextBox5.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(37, 139);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(22, 13);
            this.bosLabel3.TabIndex = 26;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Vị trí";
            // 
            // fld_dgcMMPositions
            // 
            this.fld_dgcMMPositions.AllowDrop = true;
            this.fld_dgcMMPositions.BOSComment = "";
            this.fld_dgcMMPositions.BOSDataMember = null;
            this.fld_dgcMMPositions.BOSDataSource = "MMPositions";
            this.fld_dgcMMPositions.BOSDescription = null;
            this.fld_dgcMMPositions.BOSError = "";
            this.fld_dgcMMPositions.BOSFieldGroup = "";
            this.fld_dgcMMPositions.BOSFieldRelation = null;
            this.fld_dgcMMPositions.BOSGridType = null;
            this.fld_dgcMMPositions.BOSPrivilege = "";
            this.fld_dgcMMPositions.BOSPropertyName = null;
            this.fld_dgcMMPositions.CommodityType = "";
            this.fld_dgcMMPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMPositions.Location = new System.Drawing.Point(12, 174);
            this.fld_dgcMMPositions.Name = "fld_dgcMMPositions";
            this.fld_dgcMMPositions.PrintReport = false;
            this.fld_dgcMMPositions.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMPositions, true);
            this.fld_dgcMMPositions.Size = new System.Drawing.Size(922, 410);
            this.fld_dgcMMPositions.TabIndex = 136;
            this.fld_dgcMMPositions.Tag = "SR";
            this.fld_dgcMMPositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMPositions;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // SMPL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(946, 596);
            this.Controls.Add(this.fld_dgcMMPositions);
            this.Controls.Add(this.bosTextBox5);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosTextBox4);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosTextBox3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.bosTextBox2);
            this.Controls.Add(this.fld_lblLabel14);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMPL100.IconOptions.Icon")));
            this.Name = "SMPL100";
            this.Text = "Danh sách xưởng";
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.bosTextBox2, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosTextBox3, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosTextBox4, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosTextBox5, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMPositions, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSSearchResultsGridControl fld_dgcMMPositions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
    }
}
