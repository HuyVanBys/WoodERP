namespace BOSERP.Modules.WoodPlan.UI
{
    partial class PrintWoodPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintWoodPlan));
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnUpdateWood = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMBatchProductProductionNormItems = new BOSERP.Modules.WoodPlan.ProductionNormItemsTreeListControl();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMBatchProductProductionNormItems)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_btnUpdateWood);
            this.bosPanel1.Controls.Add(this.fld_trlMMBatchProductProductionNormItems);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(1099, 582);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_btnUpdateWood
            // 
            this.fld_btnUpdateWood.BOSComment = null;
            this.fld_btnUpdateWood.BOSDataMember = null;
            this.fld_btnUpdateWood.BOSDataSource = null;
            this.fld_btnUpdateWood.BOSDescription = null;
            this.fld_btnUpdateWood.BOSError = null;
            this.fld_btnUpdateWood.BOSFieldGroup = null;
            this.fld_btnUpdateWood.BOSFieldRelation = null;
            this.fld_btnUpdateWood.BOSPrivilege = null;
            this.fld_btnUpdateWood.BOSPropertyName = null;
            this.fld_btnUpdateWood.Location = new System.Drawing.Point(12, 5);
            this.fld_btnUpdateWood.Name = "fld_btnUpdateWood";
            this.fld_btnUpdateWood.Screen = null;
            this.fld_btnUpdateWood.Size = new System.Drawing.Size(131, 31);
            this.fld_btnUpdateWood.TabIndex = 97;
            this.fld_btnUpdateWood.Text = "Export to excel";
            this.fld_btnUpdateWood.Click += new System.EventHandler(this.fld_btnUpdateWood_Click);
            // 
            // fld_trlMMBatchProductProductionNormItems
            // 
            this.fld_trlMMBatchProductProductionNormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMBatchProductProductionNormItems.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMBatchProductProductionNormItems.BOSDataMember = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMBatchProductProductionNormItems.BOSDescription = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSDisplayOption = true;
            this.fld_trlMMBatchProductProductionNormItems.BOSDisplayRoot = false;
            this.fld_trlMMBatchProductProductionNormItems.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMBatchProductProductionNormItems.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMBatchProductProductionNormItems.BOSFieldRelation = null;
            this.fld_trlMMBatchProductProductionNormItems.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMBatchProductProductionNormItems.BOSPropertyName = null;
            this.fld_trlMMBatchProductProductionNormItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMBatchProductProductionNormItems.Location = new System.Drawing.Point(3, 42);
            this.fld_trlMMBatchProductProductionNormItems.Name = "fld_trlMMBatchProductProductionNormItems";
            this.fld_trlMMBatchProductProductionNormItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMBatchProductProductionNormItems.Screen = null;
            this.fld_trlMMBatchProductProductionNormItems.Size = new System.Drawing.Size(1096, 540);
            this.fld_trlMMBatchProductProductionNormItems.TabIndex = 96;
            this.fld_trlMMBatchProductProductionNormItems.Tag = "DC";
            this.fld_trlMMBatchProductProductionNormItems.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMBatchProductProductionNormItems_NodeCellStyle);
            // 
            // PrintWoodPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 582);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintWoodPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chi tiết gỗ";
            this.Load += new System.EventHandler(this.PrintWoodPlan_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMBatchProductProductionNormItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSButton fld_btnUpdateWood;
        private BOSERP.Modules.WoodPlan.ProductionNormItemsTreeListControl fld_trlMMBatchProductProductionNormItems;
    }
}