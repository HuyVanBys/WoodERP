using BOSComponent;
namespace BOSERP.Modules.CarcassBOM.UI
{
    partial class guiInputApproveDescription
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
            this.bosPanel1 = new BOSComponent.BOSPanel();
            this.fld_ckeSelectAll = new BOSComponent.BOSCheckEdit();
            this.fld_lkeMMProductionNormApproveLogUpdateType = new BOSComponent.BOSLookupEdit();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl();
            this.fld_dgcBatchProductApprove = new BOSComponent.BOSGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel();
            this.bosLabel7 = new BOSComponent.BOSLabel();
            this.fld_medDesc = new BOSComponent.BOSMemoEdit();
            this.fld_btnChoose = new BOSComponent.BOSButton();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormApproveLogUpdateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductApprove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medDesc.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_ckeSelectAll);
            this.bosPanel1.Controls.Add(this.fld_lkeMMProductionNormApproveLogUpdateType);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_medDesc);
            this.bosPanel1.Controls.Add(this.fld_btnChoose);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1070, 314);
            this.bosPanel1.TabIndex = 403;
            // 
            // fld_ckeSelectAll
            // 
            this.fld_ckeSelectAll.BOSComment = null;
            this.fld_ckeSelectAll.BOSDataMember = null;
            this.fld_ckeSelectAll.BOSDataSource = null;
            this.fld_ckeSelectAll.BOSDescription = null;
            this.fld_ckeSelectAll.BOSError = null;
            this.fld_ckeSelectAll.BOSFieldGroup = null;
            this.fld_ckeSelectAll.BOSFieldRelation = null;
            this.fld_ckeSelectAll.BOSPrivilege = null;
            this.fld_ckeSelectAll.BOSPropertyName = null;
            this.fld_ckeSelectAll.Location = new System.Drawing.Point(412, 274);
            this.fld_ckeSelectAll.MenuManager = this.screenToolbar;
            this.fld_ckeSelectAll.Name = "fld_ckeSelectAll";
            this.fld_ckeSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_ckeSelectAll.Screen = null;
            this.fld_ckeSelectAll.Size = new System.Drawing.Size(90, 19);
            this.fld_ckeSelectAll.TabIndex = 411;
            this.fld_ckeSelectAll.CheckedChanged += new System.EventHandler(this.fld_ckeSelectAll_CheckedChanged);
            // 
            // fld_lkeMMProductionNormApproveLogUpdateType
            // 
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSComment = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSDataMember = "MMProductionNormApproveLogUpdateType";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSDataSource = "MMProductionNormApproveLogs";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSDescription = null;
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSError = null;
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSFieldGroup = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSFieldParent = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSFieldRelation = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSPrivilege = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSSelectType = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.BOSSelectTypeValue = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Location = new System.Drawing.Point(53, 12);
            this.fld_lkeMMProductionNormApproveLogUpdateType.Name = "fld_lkeMMProductionNormApproveLogUpdateType";
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.ColumnName = null;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.NullText = "";
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Screen = null;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Size = new System.Drawing.Size(355, 20);
            this.fld_lkeMMProductionNormApproveLogUpdateType.TabIndex = 410;
            this.fld_lkeMMProductionNormApproveLogUpdateType.Tag = "DC";
            this.fld_lkeMMProductionNormApproveLogUpdateType.EditValueChanged += new System.EventHandler(this.fld_lkeMMProductionNormApproveLogUpdateType_EditValueChanged);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcBatchProductApprove);
            this.bosGroupControl1.Location = new System.Drawing.Point(414, 12);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(647, 260);
            this.bosGroupControl1.TabIndex = 409;
            this.bosGroupControl1.Text = "Danh sách Lệnh sản xuất";
            // 
            // fld_dgcBatchProductApprove
            // 
            this.fld_dgcBatchProductApprove.BOSComment = null;
            this.fld_dgcBatchProductApprove.BOSDataMember = null;
            this.fld_dgcBatchProductApprove.BOSDataSource = "MMBatchProducts";
            this.fld_dgcBatchProductApprove.BOSDescription = null;
            this.fld_dgcBatchProductApprove.BOSError = null;
            this.fld_dgcBatchProductApprove.BOSFieldGroup = null;
            this.fld_dgcBatchProductApprove.BOSFieldRelation = null;
            this.fld_dgcBatchProductApprove.BOSGridType = null;
            this.fld_dgcBatchProductApprove.BOSPrivilege = null;
            this.fld_dgcBatchProductApprove.BOSPropertyName = null;
            this.fld_dgcBatchProductApprove.CommodityType = "";
            this.fld_dgcBatchProductApprove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcBatchProductApprove.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcBatchProductApprove.MenuManager = this.screenToolbar;
            this.fld_dgcBatchProductApprove.Name = "fld_dgcBatchProductApprove";
            this.fld_dgcBatchProductApprove.PrintReport = false;
            this.fld_dgcBatchProductApprove.Screen = null;
            this.fld_dgcBatchProductApprove.Size = new System.Drawing.Size(643, 238);
            this.fld_dgcBatchProductApprove.TabIndex = 403;
            this.fld_dgcBatchProductApprove.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(16, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(27, 13);
            this.bosLabel1.TabIndex = 408;
            this.bosLabel1.Text = "Mô tả";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(16, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(19, 13);
            this.bosLabel7.TabIndex = 406;
            this.bosLabel7.Text = "Loại";
            // 
            // fld_medDesc
            // 
            this.fld_medDesc.BOSComment = null;
            this.fld_medDesc.BOSDataMember = null;
            this.fld_medDesc.BOSDataSource = null;
            this.fld_medDesc.BOSDescription = null;
            this.fld_medDesc.BOSError = null;
            this.fld_medDesc.BOSFieldGroup = null;
            this.fld_medDesc.BOSFieldRelation = null;
            this.fld_medDesc.BOSPrivilege = null;
            this.fld_medDesc.BOSPropertyName = null;
            this.fld_medDesc.Location = new System.Drawing.Point(53, 38);
            this.fld_medDesc.MenuManager = this.screenToolbar;
            this.fld_medDesc.Name = "fld_medDesc";
            this.fld_medDesc.Screen = null;
            this.fld_medDesc.Size = new System.Drawing.Size(355, 234);
            this.fld_medDesc.TabIndex = 405;
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(990, 283);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 404;
            this.fld_btnChoose.Text = "Duyệt";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // guiInputApproveDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 314);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiInputApproveDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thông tin duyệt";
            this.Load += new System.EventHandler(this.guiInputApproveDescription_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormApproveLogUpdateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBatchProductApprove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSMemoEdit fld_medDesc;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSGridControl fld_dgcBatchProductApprove;
        private BOSLookupEdit fld_lkeMMProductionNormApproveLogUpdateType;
        private BOSCheckEdit fld_ckeSelectAll;
    }
}