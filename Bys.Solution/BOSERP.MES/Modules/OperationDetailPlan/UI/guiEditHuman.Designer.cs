using DevExpress.XtraGrid;
using BOSComponent;
namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiEditHuman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiEditHuman));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_spcMachine = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcEditHumans = new BOSERP.Modules.OperationDetailPlan.EditHumansGridControl();
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.fld_trlHumanUnits = new BOSERP.Modules.OperationDetailPlan.ChooseHumanUnitTreeControl();
            this.fld_ckeViewByOperation = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).BeginInit();
            this.fld_spcMachine.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEditHumans)).BeginInit();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHumanUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeViewByOperation.Properties)).BeginInit();
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
            this.fld_btnOK.Location = new System.Drawing.Point(949, 619);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 7;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(1058, 619);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 8;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
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
            this.bosPanel1.Controls.Add(this.fld_spcMachine);
            this.bosPanel1.Controls.Add(this.fld_btnCancel);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1160, 652);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_spcMachine
            // 
            this.fld_spcMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_spcMachine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_spcMachine.Location = new System.Drawing.Point(3, 0);
            this.fld_spcMachine.Name = "fld_spcMachine";
            this.fld_spcMachine.Panel1.Controls.Add(this.bosLine4);
            this.fld_spcMachine.Panel1.Text = "Panel1";
            this.fld_spcMachine.Panel2.Controls.Add(this.bosLine7);
            this.fld_spcMachine.Panel2.Text = "Panel2";
            this.fld_spcMachine.Size = new System.Drawing.Size(1154, 613);
            this.fld_spcMachine.SplitterPosition = 757;
            this.fld_spcMachine.TabIndex = 410;
            this.fld_spcMachine.Text = "splitContainerControl2";
            // 
            // bosLine4
            // 
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_dgcEditHumans);
            this.bosLine4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(0, 0);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(757, 609);
            this.bosLine4.TabIndex = 0;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcEditHumans
            // 
            this.fld_dgcEditHumans.BOSComment = null;
            this.fld_dgcEditHumans.BOSDataMember = null;
            this.fld_dgcEditHumans.BOSDataSource = "MMOperationDetailPlanItemChilds";
            this.fld_dgcEditHumans.BOSDescription = null;
            this.fld_dgcEditHumans.BOSError = null;
            this.fld_dgcEditHumans.BOSFieldGroup = null;
            this.fld_dgcEditHumans.BOSFieldRelation = null;
            this.fld_dgcEditHumans.BOSGridType = null;
            this.fld_dgcEditHumans.BOSPrivilege = null;
            this.fld_dgcEditHumans.BOSPropertyName = null;
            this.fld_dgcEditHumans.CommodityType = "";
            this.fld_dgcEditHumans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcEditHumans.IsEdit = false;
            this.fld_dgcEditHumans.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcEditHumans.MenuManager = this.screenToolbar;
            this.fld_dgcEditHumans.Name = "fld_dgcEditHumans";
            this.fld_dgcEditHumans.PrintReport = false;
            this.fld_dgcEditHumans.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcEditHumans, true);
            this.fld_dgcEditHumans.Size = new System.Drawing.Size(751, 589);
            this.fld_dgcEditHumans.TabIndex = 0;
            // 
            // bosLine7
            // 
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.fld_trlHumanUnits);
            this.bosLine7.Controls.Add(this.fld_ckeViewByOperation);
            this.bosLine7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine7.Location = new System.Drawing.Point(0, 0);
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.bosLine7.Size = new System.Drawing.Size(388, 609);
            this.bosLine7.TabIndex = 1;
            this.bosLine7.TabStop = false;
            this.bosLine7.Text = "Danh sách nguồn lực";
            // 
            // fld_trlHumanUnits
            // 
            this.fld_trlHumanUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlHumanUnits.bindingListSource = null;
            this.fld_trlHumanUnits.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlHumanUnits.KeyFieldName = "HRDepartmentRoomGroupItemID";
            this.fld_trlHumanUnits.Location = new System.Drawing.Point(4, 41);
            this.fld_trlHumanUnits.Module = null;
            this.fld_trlHumanUnits.Name = "fld_trlHumanUnits";
            this.fld_trlHumanUnits.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            this.fld_trlHumanUnits.ResultList = null;
            this.fld_trlHumanUnits.RoomGroupItemDataList = null;
            this.fld_trlHumanUnits.Size = new System.Drawing.Size(386, 565);
            this.fld_trlHumanUnits.TabIndex = 102;
            // 
            // fld_ckeViewByOperation
            // 
            this.fld_ckeViewByOperation.BOSComment = null;
            this.fld_ckeViewByOperation.BOSDataMember = null;
            this.fld_ckeViewByOperation.BOSDataSource = null;
            this.fld_ckeViewByOperation.BOSDescription = null;
            this.fld_ckeViewByOperation.BOSError = null;
            this.fld_ckeViewByOperation.BOSFieldGroup = null;
            this.fld_ckeViewByOperation.BOSFieldRelation = null;
            this.fld_ckeViewByOperation.BOSPrivilege = null;
            this.fld_ckeViewByOperation.BOSPropertyName = null;
            this.fld_ckeViewByOperation.EditValue = true;
            this.fld_ckeViewByOperation.Location = new System.Drawing.Point(6, 16);
            this.fld_ckeViewByOperation.Name = "fld_ckeViewByOperation";
            this.fld_ckeViewByOperation.Properties.Caption = "Nhân công có sở trường theo công việc";
            this.fld_ckeViewByOperation.Screen = null;
            this.fld_ckeViewByOperation.Size = new System.Drawing.Size(214, 19);
            this.fld_ckeViewByOperation.TabIndex = 1;
            this.fld_ckeViewByOperation.CheckedChanged += new System.EventHandler(this.fld_ckeViewByOperation_CheckedChanged);
            // 
            // guiEditHuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(1160, 652);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiEditHuman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân bổ nhân công";
            this.Load += new System.EventHandler(this.guiEditHuman_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).EndInit();
            this.fld_spcMachine.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEditHumans)).EndInit();
            this.bosLine7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHumanUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeViewByOperation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSPanel bosPanel1;
        private EditHumansGridControl fld_dgcEditHumans;
        private DevExpress.XtraEditors.SplitContainerControl fld_spcMachine;
        private BOSLine bosLine7;
        private BOSCheckEdit fld_ckeViewByOperation;
        private BOSLine bosLine4;
        private ChooseHumanUnitTreeControl fld_trlHumanUnits;
    }
}