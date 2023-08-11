using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaintProcesses.UI
{
	/// <summary>
	/// Summary description for SMPP100
	/// </summary>
	partial class SMPP100
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
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_txtMMPaintProcessesName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMPaintProcessesNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICProductAttributeColorID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMPaintProcessess = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeColorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "MMPaintProcessesProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "MMPaintProcessess";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(84, 89);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedFK_ICProductGroupID, true);
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(156, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 25;
            this.fld_bedFK_ICProductGroupID.Tag = "SC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_txtMMPaintProcessesName
            // 
            this.fld_txtMMPaintProcessesName.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesName.BOSDataMember = "MMPaintProcessesName";
            this.fld_txtMMPaintProcessesName.BOSDataSource = "MMPaintProcessess";
            this.fld_txtMMPaintProcessesName.BOSDescription = null;
            this.fld_txtMMPaintProcessesName.BOSError = null;
            this.fld_txtMMPaintProcessesName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesName.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesName.BOSPropertyName = "Text";
            this.fld_txtMMPaintProcessesName.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesName.Location = new System.Drawing.Point(84, 37);
            this.fld_txtMMPaintProcessesName.Name = "fld_txtMMPaintProcessesName";
            this.fld_txtMMPaintProcessesName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPaintProcessesName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPaintProcessesName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPaintProcessesName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPaintProcessesName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPaintProcessesName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPaintProcessesName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPaintProcessesName, true);
            this.fld_txtMMPaintProcessesName.Size = new System.Drawing.Size(157, 20);
            this.fld_txtMMPaintProcessesName.TabIndex = 23;
            this.fld_txtMMPaintProcessesName.Tag = "SC";
            // 
            // fld_txtMMPaintProcessesNo
            // 
            this.fld_txtMMPaintProcessesNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesNo.BOSDataMember = "MMPaintProcessesNo";
            this.fld_txtMMPaintProcessesNo.BOSDataSource = "MMPaintProcessess";
            this.fld_txtMMPaintProcessesNo.BOSDescription = null;
            this.fld_txtMMPaintProcessesNo.BOSError = null;
            this.fld_txtMMPaintProcessesNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesNo.BOSPropertyName = "Text";
            this.fld_txtMMPaintProcessesNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtMMPaintProcessesNo.Location = new System.Drawing.Point(84, 12);
            this.fld_txtMMPaintProcessesNo.Name = "fld_txtMMPaintProcessesNo";
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPaintProcessesNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPaintProcessesNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPaintProcessesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPaintProcessesNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPaintProcessesNo, true);
            this.fld_txtMMPaintProcessesNo.Size = new System.Drawing.Size(157, 20);
            this.fld_txtMMPaintProcessesNo.TabIndex = 19;
            this.fld_txtMMPaintProcessesNo.Tag = "SC";
            // 
            // fld_lkeFK_ICProductAttributeColorID
            // 
            this.fld_lkeFK_ICProductAttributeColorID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeColorID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeColorID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSDataMember = "FK_ICProductAttributeColorID";
            this.fld_lkeFK_ICProductAttributeColorID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeFK_ICProductAttributeColorID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeColorID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeColorID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeColorID.BOSSelectTypeValue = "COLOR";
            this.fld_lkeFK_ICProductAttributeColorID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeColorID.Enabled = false;
            this.fld_lkeFK_ICProductAttributeColorID.Location = new System.Drawing.Point(84, 63);
            this.fld_lkeFK_ICProductAttributeColorID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductAttributeColorID.Name = "fld_lkeFK_ICProductAttributeColorID";
            this.fld_lkeFK_ICProductAttributeColorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeColorID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên màu")});
            this.fld_lkeFK_ICProductAttributeColorID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeColorID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductAttributeColorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeColorID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeColorID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeColorID, true);
            this.fld_lkeFK_ICProductAttributeColorID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_ICProductAttributeColorID.TabIndex = 21;
            this.fld_lkeFK_ICProductAttributeColorID.Tag = "SC";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel28.Location = new System.Drawing.Point(10, 92);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
            this.fld_lblLabel28.Size = new System.Drawing.Size(34, 13);
            this.fld_lblLabel28.TabIndex = 24;
            this.fld_lblLabel28.Tag = "SI";
            this.fld_lblLabel28.Text = "Hệ sơn";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(10, 40);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(59, 13);
            this.bosLabel2.TabIndex = 22;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên qui trình";
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(10, 15);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel15.TabIndex = 18;
            this.fld_lblLabel15.Tag = "SI";
            this.fld_lblLabel15.Text = "Mã qui trình";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(10, 66);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(38, 13);
            this.bosLabel1.TabIndex = 20;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã màu";
            // 
            // fld_dgcMMPaintProcessess
            // 
            this.fld_dgcMMPaintProcessess.AllowDrop = true;
            this.fld_dgcMMPaintProcessess.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMPaintProcessess.BOSDataMember = null;
            this.fld_dgcMMPaintProcessess.BOSDataSource = "MMPaintProcessess";
            this.fld_dgcMMPaintProcessess.BOSDescription = null;
            this.fld_dgcMMPaintProcessess.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMPaintProcessess.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMPaintProcessess.BOSFieldRelation = null;
            this.fld_dgcMMPaintProcessess.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMPaintProcessess.BOSPropertyName = null;
            this.fld_dgcMMPaintProcessess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMPaintProcessess.Location = new System.Drawing.Point(12, 142);
            this.fld_dgcMMPaintProcessess.Name = "fld_dgcMMPaintProcessess";
            this.fld_dgcMMPaintProcessess.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMPaintProcessess, true);
            this.fld_dgcMMPaintProcessess.Size = new System.Drawing.Size(828, 413);
            this.fld_dgcMMPaintProcessess.TabIndex = 137;
            this.fld_dgcMMPaintProcessess.Tag = "SR";
            this.fld_dgcMMPaintProcessess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMPaintProcessess;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // SMPP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcMMPaintProcessess);
            this.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.Controls.Add(this.fld_txtMMPaintProcessesName);
            this.Controls.Add(this.fld_txtMMPaintProcessesNo);
            this.Controls.Add(this.fld_lkeFK_ICProductAttributeColorID);
            this.Controls.Add(this.fld_lblLabel28);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel15);
            this.Controls.Add(this.bosLabel1);
            this.Name = "SMPP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel15, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel28, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductAttributeColorID, 0);
            this.Controls.SetChildIndex(this.fld_txtMMPaintProcessesNo, 0);
            this.Controls.SetChildIndex(this.fld_txtMMPaintProcessesName, 0);
            this.Controls.SetChildIndex(this.fld_bedFK_ICProductGroupID, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMPaintProcessess, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPaintProcessesNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeColorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtMMPaintProcessesName;
        private BOSComponent.BOSTextBox fld_txtMMPaintProcessesNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeColorID;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMPaintProcessess;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
	}
}
