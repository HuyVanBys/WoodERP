namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiSearchMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiSearchMachine));
            this.fld_dgcMMDetailPlanMachineUnits = new BOSERP.Modules.OperationDetailPlan.ChooseMachineUnitGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanMachineUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMDetailPlanMachineUnits
            // 
            this.fld_dgcMMDetailPlanMachineUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDetailPlanMachineUnits.BOSComment = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSDataMember = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSDataSource = "MMDetailPlanMachineUnits";
            this.fld_dgcMMDetailPlanMachineUnits.BOSDescription = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSError = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSFieldGroup = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSFieldRelation = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSGridType = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSPrivilege = null;
            this.fld_dgcMMDetailPlanMachineUnits.BOSPropertyName = null;
            this.fld_dgcMMDetailPlanMachineUnits.CommodityType = "";
            this.fld_dgcMMDetailPlanMachineUnits.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcMMDetailPlanMachineUnits.MenuManager = this.screenToolbar;
            this.fld_dgcMMDetailPlanMachineUnits.Name = "fld_dgcMMDetailPlanMachineUnits";
            this.fld_dgcMMDetailPlanMachineUnits.PrintReport = false;
            this.fld_dgcMMDetailPlanMachineUnits.Screen = null;
            this.fld_dgcMMDetailPlanMachineUnits.Size = new System.Drawing.Size(879, 538);
            this.fld_dgcMMDetailPlanMachineUnits.TabIndex = 1;
            this.fld_dgcMMDetailPlanMachineUnits.Tag = "DC";
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
            this.fld_btnChoose.Location = new System.Drawing.Point(729, 547);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Đồng ý";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(11, 547);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 4;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(809, 547);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiSearchMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(885, 580);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcMMDetailPlanMachineUnits);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.fld_btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiSearchMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chọn máy móc";
            this.Load += new System.EventHandler(this.guiSearchMachine_Load);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMDetailPlanMachineUnits, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanMachineUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private ChooseMachineUnitGridControl fld_dgcMMDetailPlanMachineUnits;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}