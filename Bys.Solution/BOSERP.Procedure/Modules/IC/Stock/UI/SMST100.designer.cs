using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Stock.UI
{
	/// <summary>
	/// Summary description for SMST100
	/// </summary>
	partial class SMST100
	{
		private BOSComponent.BOSTextBox fld_txtICStockName1;
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtICStockNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private BOSComponent.BOSLabel fld_lblLabel2;


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
            this.fld_txtICStockName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlICStocks = new BOSERP.Modules.Stock.ICStocksTreeListControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtICStockName1
            // 
            this.fld_txtICStockName1.BOSComment = "";
            this.fld_txtICStockName1.BOSDataMember = "ICStockName";
            this.fld_txtICStockName1.BOSDataSource = "ICStocks";
            this.fld_txtICStockName1.BOSDescription = null;
            this.fld_txtICStockName1.BOSError = "";
            this.fld_txtICStockName1.BOSFieldGroup = "";
            this.fld_txtICStockName1.BOSFieldRelation = "";
            this.fld_txtICStockName1.BOSPrivilege = "";
            this.fld_txtICStockName1.BOSPropertyName = "Text";
            this.fld_txtICStockName1.Location = new System.Drawing.Point(114, 35);
            this.fld_txtICStockName1.Name = "fld_txtICStockName1";
            this.fld_txtICStockName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockName1.Screen = null;
            this.fld_txtICStockName1.Size = new System.Drawing.Size(159, 20);
            this.fld_txtICStockName1.TabIndex = 1;
            this.fld_txtICStockName1.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseFont = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(36, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel.TabIndex = 11;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã kho";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(36, 38);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel1.TabIndex = 12;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên kho";
            // 
            // fld_txtICStockNo
            // 
            this.fld_txtICStockNo.BOSComment = "";
            this.fld_txtICStockNo.BOSDataMember = "ICStockNo";
            this.fld_txtICStockNo.BOSDataSource = "ICStocks";
            this.fld_txtICStockNo.BOSDescription = null;
            this.fld_txtICStockNo.BOSError = "";
            this.fld_txtICStockNo.BOSFieldGroup = "";
            this.fld_txtICStockNo.BOSFieldRelation = "";
            this.fld_txtICStockNo.BOSPrivilege = "";
            this.fld_txtICStockNo.BOSPropertyName = "Text";
            this.fld_txtICStockNo.Location = new System.Drawing.Point(114, 9);
            this.fld_txtICStockNo.Name = "fld_txtICStockNo";
            this.fld_txtICStockNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockNo.Screen = null;
            this.fld_txtICStockNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtICStockNo.TabIndex = 0;
            this.fld_txtICStockNo.Tag = "SC";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = "";
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "ICStocks";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = "";
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = "";
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(114, 61);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(159, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 2;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseFont = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(36, 64);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 14;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Chi nhánh";
            // 
            // fld_trlICStocks
            // 
            this.fld_trlICStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlICStocks.BOSComment = null;
            this.fld_trlICStocks.BOSDataMember = null;
            this.fld_trlICStocks.BOSDataSource = "ICStocks";
            this.fld_trlICStocks.BOSDescription = null;
            this.fld_trlICStocks.BOSDisplayOption = false;
            this.fld_trlICStocks.BOSDisplayRoot = false;
            this.fld_trlICStocks.BOSError = null;
            this.fld_trlICStocks.BOSFieldGroup = null;
            this.fld_trlICStocks.BOSFieldRelation = null;
            this.fld_trlICStocks.BOSPrivilege = null;
            this.fld_trlICStocks.BOSPropertyName = null;
            this.fld_trlICStocks.Location = new System.Drawing.Point(1, 107);
            this.fld_trlICStocks.Name = "fld_trlICStocks";
            this.fld_trlICStocks.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlICStocks.Screen = this;
            this.fld_trlICStocks.Size = new System.Drawing.Size(779, 451);
            this.fld_trlICStocks.TabIndex = 3;
            this.fld_trlICStocks.Tag = "SR";
            // 
            // SMST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.fld_trlICStocks);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtICStockName1);
            this.Controls.Add(this.fld_txtICStockNo);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Name = "SMST100";
            this.Text = "Danh sách kho";
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtICStockNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICStockName1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_trlICStocks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private ICStocksTreeListControl fld_trlICStocks;
	}
}
