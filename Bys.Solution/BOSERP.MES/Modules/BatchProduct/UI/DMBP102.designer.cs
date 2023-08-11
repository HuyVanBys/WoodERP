using System.ComponentModel;
using System.Windows.Forms;
using BOSComponent;

namespace BOSERP.Modules.BatchProduct.UI
{
    /// <summary>
    /// Summary description for DMBP102
    /// </summary>
    partial class DMBP102
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fld_btnUnApproved = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProducts = new BOSComponent.BOSButton(this.components);
            this.fld_btnCloseOutSourcing = new BOSComponent.BOSButton(this.components);
            this.fld_btnSaveOutSourcings = new BOSComponent.BOSButton(this.components);
            this.fld_btnApproved = new BOSComponent.BOSButton(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_lkeBatchProductItemOutSourcingResourceType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnUpdateResourceType = new BOSComponent.BOSButton(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnUpdateDate = new BOSComponent.BOSButton(this.components);
            this.fld_dteOutSourcingDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_dgcMMBatchProductItemOutSourcings = new BOSERP.Modules.BatchProduct.MMBatchProductItemOutsourcingsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductItemOutSourcingResourceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOutSourcingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOutSourcingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItemOutSourcings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.fld_dgcMMBatchProductItemOutSourcings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 692);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fld_btnUnApproved);
            this.groupBox3.Controls.Add(this.fld_btnAddProducts);
            this.groupBox3.Controls.Add(this.fld_btnCloseOutSourcing);
            this.groupBox3.Controls.Add(this.fld_btnSaveOutSourcings);
            this.groupBox3.Controls.Add(this.fld_btnApproved);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 43);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // fld_btnUnApproved
            // 
            this.fld_btnUnApproved.BOSComment = null;
            this.fld_btnUnApproved.BOSDataMember = null;
            this.fld_btnUnApproved.BOSDataSource = null;
            this.fld_btnUnApproved.BOSDescription = null;
            this.fld_btnUnApproved.BOSError = null;
            this.fld_btnUnApproved.BOSFieldGroup = null;
            this.fld_btnUnApproved.BOSFieldRelation = null;
            this.fld_btnUnApproved.BOSPrivilege = null;
            this.fld_btnUnApproved.BOSPropertyName = null;
            this.fld_btnUnApproved.Location = new System.Drawing.Point(333, 14);
            this.fld_btnUnApproved.Name = "fld_btnUnApproved";
            this.fld_btnUnApproved.Screen = null;
            this.fld_btnUnApproved.Size = new System.Drawing.Size(103, 23);
            this.fld_btnUnApproved.TabIndex = 3;
            this.fld_btnUnApproved.Text = "Hủy kế hoạch";
            this.fld_btnUnApproved.Click += new System.EventHandler(this.fld_btnUnApproved_Click);
            // 
            // fld_btnAddProducts
            // 
            this.fld_btnAddProducts.BOSComment = null;
            this.fld_btnAddProducts.BOSDataMember = null;
            this.fld_btnAddProducts.BOSDataSource = null;
            this.fld_btnAddProducts.BOSDescription = null;
            this.fld_btnAddProducts.BOSError = null;
            this.fld_btnAddProducts.BOSFieldGroup = null;
            this.fld_btnAddProducts.BOSFieldRelation = null;
            this.fld_btnAddProducts.BOSPrivilege = null;
            this.fld_btnAddProducts.BOSPropertyName = null;
            this.fld_btnAddProducts.Location = new System.Drawing.Point(6, 14);
            this.fld_btnAddProducts.Name = "fld_btnAddProducts";
            this.fld_btnAddProducts.Screen = null;
            this.fld_btnAddProducts.Size = new System.Drawing.Size(103, 23);
            this.fld_btnAddProducts.TabIndex = 0;
            this.fld_btnAddProducts.Text = "Thêm TP/BTP";
            this.fld_btnAddProducts.Click += new System.EventHandler(this.fld_btnAddProducts_Click);
            // 
            // fld_btnCloseOutSourcing
            // 
            this.fld_btnCloseOutSourcing.BOSComment = null;
            this.fld_btnCloseOutSourcing.BOSDataMember = null;
            this.fld_btnCloseOutSourcing.BOSDataSource = null;
            this.fld_btnCloseOutSourcing.BOSDescription = null;
            this.fld_btnCloseOutSourcing.BOSError = null;
            this.fld_btnCloseOutSourcing.BOSFieldGroup = null;
            this.fld_btnCloseOutSourcing.BOSFieldRelation = null;
            this.fld_btnCloseOutSourcing.BOSPrivilege = null;
            this.fld_btnCloseOutSourcing.BOSPropertyName = null;
            this.fld_btnCloseOutSourcing.Location = new System.Drawing.Point(442, 14);
            this.fld_btnCloseOutSourcing.Name = "fld_btnCloseOutSourcing";
            this.fld_btnCloseOutSourcing.Screen = null;
            this.fld_btnCloseOutSourcing.Size = new System.Drawing.Size(103, 23);
            this.fld_btnCloseOutSourcing.TabIndex = 4;
            this.fld_btnCloseOutSourcing.Text = "Đóng kế hoạch";
            this.fld_btnCloseOutSourcing.Click += new System.EventHandler(this.fld_btnCloseOutSourcing_Click);
            // 
            // fld_btnSaveOutSourcings
            // 
            this.fld_btnSaveOutSourcings.BOSComment = null;
            this.fld_btnSaveOutSourcings.BOSDataMember = null;
            this.fld_btnSaveOutSourcings.BOSDataSource = null;
            this.fld_btnSaveOutSourcings.BOSDescription = null;
            this.fld_btnSaveOutSourcings.BOSError = null;
            this.fld_btnSaveOutSourcings.BOSFieldGroup = null;
            this.fld_btnSaveOutSourcings.BOSFieldRelation = null;
            this.fld_btnSaveOutSourcings.BOSPrivilege = null;
            this.fld_btnSaveOutSourcings.BOSPropertyName = null;
            this.fld_btnSaveOutSourcings.Location = new System.Drawing.Point(115, 14);
            this.fld_btnSaveOutSourcings.Name = "fld_btnSaveOutSourcings";
            this.fld_btnSaveOutSourcings.Screen = null;
            this.fld_btnSaveOutSourcings.Size = new System.Drawing.Size(103, 23);
            this.fld_btnSaveOutSourcings.TabIndex = 1;
            this.fld_btnSaveOutSourcings.Text = "Lưu kế hoạch";
            this.fld_btnSaveOutSourcings.Click += new System.EventHandler(this.fld_btnSaveOutSourcings_Click);
            // 
            // fld_btnApproved
            // 
            this.fld_btnApproved.BOSComment = null;
            this.fld_btnApproved.BOSDataMember = null;
            this.fld_btnApproved.BOSDataSource = null;
            this.fld_btnApproved.BOSDescription = null;
            this.fld_btnApproved.BOSError = null;
            this.fld_btnApproved.BOSFieldGroup = null;
            this.fld_btnApproved.BOSFieldRelation = null;
            this.fld_btnApproved.BOSPrivilege = null;
            this.fld_btnApproved.BOSPropertyName = null;
            this.fld_btnApproved.Location = new System.Drawing.Point(224, 14);
            this.fld_btnApproved.Name = "fld_btnApproved";
            this.fld_btnApproved.Screen = null;
            this.fld_btnApproved.Size = new System.Drawing.Size(103, 23);
            this.fld_btnApproved.TabIndex = 2;
            this.fld_btnApproved.Text = "Duyệt kế hoạch";
            this.fld_btnApproved.Click += new System.EventHandler(this.fld_btnApproved_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_lkeBatchProductItemOutSourcingResourceType);
            this.groupBox1.Controls.Add(this.fld_btnUpdateResourceType);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.fld_btnUpdateDate);
            this.groupBox1.Controls.Add(this.fld_dteOutSourcingDate);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(568, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 43);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cập nhật";
            // 
            // fld_lkeBatchProductItemOutSourcingResourceType
            // 
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSAllowAddNew = false;
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSAllowDummy = false;
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSComment = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSDataMember = "MMBatchProductItemOutSourcingResourceType";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSDataSource = "MMBatchProductItemOutSourcings";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSDescription = null;
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSError = null;
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSFieldGroup = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSFieldParent = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSFieldRelation = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSPrivilege = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSPropertyName = "EditValue";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSSelectType = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.BOSSelectTypeValue = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.CurrentDisplayText = null;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Location = new System.Drawing.Point(327, 15);
            this.fld_lkeBatchProductItemOutSourcingResourceType.Name = "fld_lkeBatchProductItemOutSourcingResourceType";
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.ColumnName = null;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.NullText = "";
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.PopupWidth = 40;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Screen = null;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeBatchProductItemOutSourcingResourceType.TabIndex = 105;
            this.fld_lkeBatchProductItemOutSourcingResourceType.Tag = "DC";
            // 
            // fld_btnUpdateResourceType
            // 
            this.fld_btnUpdateResourceType.BOSComment = null;
            this.fld_btnUpdateResourceType.BOSDataMember = null;
            this.fld_btnUpdateResourceType.BOSDataSource = null;
            this.fld_btnUpdateResourceType.BOSDescription = null;
            this.fld_btnUpdateResourceType.BOSError = null;
            this.fld_btnUpdateResourceType.BOSFieldGroup = null;
            this.fld_btnUpdateResourceType.BOSFieldRelation = null;
            this.fld_btnUpdateResourceType.BOSPrivilege = null;
            this.fld_btnUpdateResourceType.BOSPropertyName = null;
            this.fld_btnUpdateResourceType.Location = new System.Drawing.Point(433, 16);
            this.fld_btnUpdateResourceType.Name = "fld_btnUpdateResourceType";
            this.fld_btnUpdateResourceType.Screen = null;
            this.fld_btnUpdateResourceType.Size = new System.Drawing.Size(84, 20);
            this.fld_btnUpdateResourceType.TabIndex = 103;
            this.fld_btnUpdateResourceType.Text = "Cập nhật";
            this.fld_btnUpdateResourceType.Click += new System.EventHandler(this.fld_btnUpdateResourceType_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(286, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Nguồn";
            // 
            // fld_btnUpdateDate
            // 
            this.fld_btnUpdateDate.BOSComment = null;
            this.fld_btnUpdateDate.BOSDataMember = null;
            this.fld_btnUpdateDate.BOSDataSource = null;
            this.fld_btnUpdateDate.BOSDescription = null;
            this.fld_btnUpdateDate.BOSError = null;
            this.fld_btnUpdateDate.BOSFieldGroup = null;
            this.fld_btnUpdateDate.BOSFieldRelation = null;
            this.fld_btnUpdateDate.BOSPrivilege = null;
            this.fld_btnUpdateDate.BOSPropertyName = null;
            this.fld_btnUpdateDate.Location = new System.Drawing.Point(190, 15);
            this.fld_btnUpdateDate.Name = "fld_btnUpdateDate";
            this.fld_btnUpdateDate.Screen = null;
            this.fld_btnUpdateDate.Size = new System.Drawing.Size(84, 20);
            this.fld_btnUpdateDate.TabIndex = 101;
            this.fld_btnUpdateDate.Text = "Cập nhật";
            this.fld_btnUpdateDate.Click += new System.EventHandler(this.fld_btnUpdateDate_Click);
            // 
            // fld_dteOutSourcingDate
            // 
            this.fld_dteOutSourcingDate.EditValue = null;
            this.fld_dteOutSourcingDate.Location = new System.Drawing.Point(81, 15);
            this.fld_dteOutSourcingDate.MenuManager = this.screenToolbar;
            this.fld_dteOutSourcingDate.Name = "fld_dteOutSourcingDate";
            this.fld_dteOutSourcingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteOutSourcingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteOutSourcingDate.Size = new System.Drawing.Size(100, 20);
            this.fld_dteOutSourcingDate.TabIndex = 99;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "Thời gian cần";
            // 
            // fld_dgcMMBatchProductItemOutSourcings
            // 
            this.fld_dgcMMBatchProductItemOutSourcings.AllowDrop = true;
            this.fld_dgcMMBatchProductItemOutSourcings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBatchProductItemOutSourcings.BOSComment = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSDataMember = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSDataSource = "MMBatchProductItemOutSourcings";
            this.fld_dgcMMBatchProductItemOutSourcings.BOSDescription = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSError = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSFieldGroup = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSFieldRelation = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSGridType = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSPrivilege = null;
            this.fld_dgcMMBatchProductItemOutSourcings.BOSPropertyName = null;
            this.fld_dgcMMBatchProductItemOutSourcings.CommodityType = "";
            this.fld_dgcMMBatchProductItemOutSourcings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMBatchProductItemOutSourcings.Location = new System.Drawing.Point(12, 61);
            this.fld_dgcMMBatchProductItemOutSourcings.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMBatchProductItemOutSourcings.Name = "fld_dgcMMBatchProductItemOutSourcings";
            this.fld_dgcMMBatchProductItemOutSourcings.PrintReport = false;
            this.fld_dgcMMBatchProductItemOutSourcings.Screen = null;
            this.fld_dgcMMBatchProductItemOutSourcings.Size = new System.Drawing.Size(1146, 619);
            this.fld_dgcMMBatchProductItemOutSourcings.TabIndex = 97;
            this.fld_dgcMMBatchProductItemOutSourcings.Tag = "DC";
            this.fld_dgcMMBatchProductItemOutSourcings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMBatchProductItemOutSourcings;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // DMBP102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1170, 692);
            this.Controls.Add(this.panel1);
            this.Name = "DMBP102";
            this.Text = "Kế hoạch gia công";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductItemOutSourcingResourceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOutSourcingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteOutSourcingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItemOutSourcings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSButton fld_btnAddProducts;
        private MMBatchProductItemOutsourcingsGridControl fld_dgcMMBatchProductItemOutSourcings;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private GroupBox groupBox1;
        private BOSButton fld_btnUpdateDate;
        private DevExpress.XtraEditors.DateEdit fld_dteOutSourcingDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private BOSButton fld_btnApproved;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private BOSButton fld_btnUpdateResourceType;
        private BOSLookupEdit fld_lkeBatchProductItemOutSourcingResourceType;
        private BOSButton fld_btnSaveOutSourcings;
        private BOSButton fld_btnCloseOutSourcing;
        private BOSButton fld_btnUnApproved;
    }
}
