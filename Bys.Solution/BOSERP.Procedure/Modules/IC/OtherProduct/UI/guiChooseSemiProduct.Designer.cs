using DevExpress.XtraGrid;
using BOSComponent;
namespace BOSERP.Modules.OtherProduct
{
    partial class guiChooseSemiProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseSemiProduct));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_trlSemiItems = new DevExpress.XtraTreeList.TreeList();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlSemiItems)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(764, 634);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 0;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.Fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(873, 634);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 1;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.bosPanel1.Controls.Add(this.fld_trlSemiItems);
            this.bosPanel1.Controls.Add(this.fld_btnCancel);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(971, 670);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_trlSemiItems
            // 
            this.fld_trlSemiItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlSemiItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlSemiItems.KeyFieldName = "MMProductionNormItemID";
            this.fld_trlSemiItems.Location = new System.Drawing.Point(3, 61);
            this.fld_trlSemiItems.Name = "fld_trlSemiItems";
            this.fld_trlSemiItems.ParentFieldName = "MMProductionNormItemParentID";
            this.fld_trlSemiItems.Size = new System.Drawing.Size(962, 567);
            this.fld_trlSemiItems.TabIndex = 101;
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosLabel6);
            this.bosLine2.Controls.Add(this.fld_lkeMMProductionNormID);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(944, 52);
            this.bosLine2.TabIndex = 0;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thông tin tìm kiếm";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(18, 23);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(70, 13);
            this.bosLabel6.TabIndex = 11;
            this.bosLabel6.Text = "Bảng định mức";
            // 
            // fld_lkeMMProductionNormID
            // 
            this.fld_lkeMMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormID.BOSAllowDummy = true;
            this.fld_lkeMMProductionNormID.BOSComment = null;
            this.fld_lkeMMProductionNormID.BOSDataMember = "MMProductionNormID";
            this.fld_lkeMMProductionNormID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormID.BOSDescription = null;
            this.fld_lkeMMProductionNormID.BOSError = "";
            this.fld_lkeMMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeMMProductionNormID.BOSFieldParent = null;
            this.fld_lkeMMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeMMProductionNormID.BOSPrivilege = null;
            this.fld_lkeMMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormID.BOSSelectType = "";
            this.fld_lkeMMProductionNormID.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormID.Location = new System.Drawing.Point(107, 20);
            this.fld_lkeMMProductionNormID.Name = "fld_lkeMMProductionNormID";
            this.fld_lkeMMProductionNormID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormID.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Mã chứng từ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormProductDesc", "Mô tả SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormStatus", "Tình trạng")});
            this.fld_lkeMMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeMMProductionNormID.Properties.NullText = "";
            this.fld_lkeMMProductionNormID.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeMMProductionNormID.Screen = null;
            this.fld_lkeMMProductionNormID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeMMProductionNormID.TabIndex = 12;
            this.fld_lkeMMProductionNormID.Tag = "DC";
            this.fld_lkeMMProductionNormID.Validated += new System.EventHandler(this.Fld_lkeMMProductionNormID_Validated_1);
            // 
            // guiChooseSemiProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(971, 670);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseSemiProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm chưa hoạch định theo công đoạn";
            this.Load += new System.EventHandler(this.guiChooseSemiProduct_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlSemiItems)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSLabel bosLabel6;
        private BOSLookupEdit fld_lkeMMProductionNormID;
        private BOSLine bosLine2;
        private DevExpress.XtraTreeList.TreeList fld_trlSemiItems;
    }
}