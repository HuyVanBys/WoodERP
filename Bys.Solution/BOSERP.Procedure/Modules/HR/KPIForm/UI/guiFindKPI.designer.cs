namespace BOSERP.Modules.KPIForm
{
    partial class guiFindKPI
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
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcHRKPIs = new BOSERP.Modules.KPIForm.HRKPIsGridControl();
            this.fld_dgvHRKPIFormItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).BeginInit();
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
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = string.Empty;
            this.bosLabel6.BOSDataMember = string.Empty;
            this.bosLabel6.BOSDataSource = string.Empty;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = string.Empty;
            this.bosLabel6.BOSFieldRelation = string.Empty;
            this.bosLabel6.BOSPrivilege = string.Empty;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(15, 12);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(115, 13);
            this.bosLabel6.TabIndex = 138;
            this.bosLabel6.Tag = string.Empty;
            this.bosLabel6.Text = "Tiêu chí của phòng ban";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Location = new System.Drawing.Point(372, 6);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(67, 23);
            this.fld_btnFind.TabIndex = 7;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = string.Empty;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(149, 9);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = string.Empty;
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(197, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = string.Empty;
            this.fld_chkSelectedAll.BOSDataSource = string.Empty;
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
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgcHRKPIs
            // 
            this.fld_dgcHRKPIs.AllowDrop = true;
            this.fld_dgcHRKPIs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRKPIs.BOSComment = string.Empty;
            this.fld_dgcHRKPIs.BOSDataMember = string.Empty;
            this.fld_dgcHRKPIs.BOSDataSource = "HRKPIs";
            this.fld_dgcHRKPIs.BOSDescription = null;
            this.fld_dgcHRKPIs.BOSError = null;
            this.fld_dgcHRKPIs.BOSFieldGroup = string.Empty;
            this.fld_dgcHRKPIs.BOSFieldRelation = string.Empty;
            this.fld_dgcHRKPIs.BOSGridType = null;
            this.fld_dgcHRKPIs.BOSPrivilege = string.Empty;
            this.fld_dgcHRKPIs.BOSPropertyName = string.Empty;
            this.fld_dgcHRKPIs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIs.Location = new System.Drawing.Point(4, 35);
            this.fld_dgcHRKPIs.MainView = this.fld_dgvHRKPIFormItems;
            this.fld_dgcHRKPIs.Name = "fld_dgcHRKPIs";
            this.fld_dgcHRKPIs.PrintReport = false;
            this.fld_dgcHRKPIs.Screen = null;
            this.fld_dgcHRKPIs.Size = new System.Drawing.Size(890, 501);
            this.fld_dgcHRKPIs.TabIndex = 143;
            this.fld_dgcHRKPIs.Tag = "DC";
            this.fld_dgcHRKPIs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRKPIFormItems});
            // 
            // fld_dgvHRKPIFormItems
            // 
            this.fld_dgvHRKPIFormItems.GridControl = this.fld_dgcHRKPIs;
            this.fld_dgvHRKPIFormItems.Name = "fld_dgvHRKPIFormItems";
            this.fld_dgvHRKPIFormItems.PaintStyleName = "Office2003";
            // 
            // guiFindKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcHRKPIs);
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiFindKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiFindKPI_Load_1);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRKPIs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRKPIFormItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
        private HRKPIFormItemsGridControl fld_dgcKPIFormItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HRKPIsGridControl fld_dgcHRKPIs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRKPIFormItems;
    }
}