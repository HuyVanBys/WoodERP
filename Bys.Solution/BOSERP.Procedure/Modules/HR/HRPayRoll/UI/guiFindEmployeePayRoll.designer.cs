namespace BOSERP.Modules.HRPayRoll
{
    partial class guiFindEmployeePayRoll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcHREmployeePayRollsGridControl2 = new BOSERP.Modules.HRPayRoll.HREmployeePayRollsGridControl2();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollsGridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(802, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 10;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(713, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_chkSelectedAll.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_chkSelectedAll.BOSDescription = null;
            this.fld_chkSelectedAll.BOSError = null;
            this.fld_chkSelectedAll.BOSFieldGroup = null;
            this.fld_chkSelectedAll.BOSFieldRelation = null;
            this.fld_chkSelectedAll.BOSPrivilege = null;
            this.fld_chkSelectedAll.BOSPropertyName = "EditValue";
            this.fld_chkSelectedAll.Location = new System.Drawing.Point(12, 542);
            this.fld_chkSelectedAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectedAll.Name = "fld_chkSelectedAll";
            this.fld_chkSelectedAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectedAll.Screen = null;
            this.fld_chkSelectedAll.Size = new System.Drawing.Size(118, 19);
            this.fld_chkSelectedAll.TabIndex = 142;
            this.fld_chkSelectedAll.Tag = "DC";
            this.fld_chkSelectedAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectedAll_CheckedChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHREmployeePayRollsGridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgcHREmployeePayRollsGridControl2
            // 
            this.fld_dgcHREmployeePayRollsGridControl2.AllowDrop = true;
            this.fld_dgcHREmployeePayRollsGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePayRollsGridControl2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSDataSource = "HREmployeePayRolls";
            this.fld_dgcHREmployeePayRollsGridControl2.BOSDescription = null;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSError = null;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSGridType = null;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeePayRollsGridControl2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePayRollsGridControl2.Location = new System.Drawing.Point(4, 4);
            this.fld_dgcHREmployeePayRollsGridControl2.MainView = this.gridView1;
            this.fld_dgcHREmployeePayRollsGridControl2.Name = "fld_dgcHREmployeePayRollsGridControl2";
            this.fld_dgcHREmployeePayRollsGridControl2.PrintReport = false;
            this.fld_dgcHREmployeePayRollsGridControl2.Screen = null;
            this.fld_dgcHREmployeePayRollsGridControl2.Size = new System.Drawing.Size(890, 532);
            this.fld_dgcHREmployeePayRollsGridControl2.TabIndex = 143;
            this.fld_dgcHREmployeePayRollsGridControl2.Tag = "DC";
            this.fld_dgcHREmployeePayRollsGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // guiFindEmployeePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcHREmployeePayRollsGridControl2);
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiFindEmployeePayRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiFindEmployeePayRoll_Load_1);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployeePayRollsGridControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollsGridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
        private HREmployeePayRollsGridControl2 fld_dgcHREmployeePayRollsGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}