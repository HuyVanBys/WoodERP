using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public partial class guiShowTemplateItems : BOSERPScreen
    {
        public int ARProposalID { get; set; }

        public int ARProposalTemplateItemID { get; set; }

        public string ARProposalTemplateItemProductName { get; set; }

        public BOSTreeList TreeList { get; set; }

        public bool IsAllowEditTemplate { get; set; }

        public ARProposalTemplateItemsInfo CurentProposalTemplateItemsInfo { get; set; }

        public guiShowTemplateItems()
        {
            InitializeComponent();
        }

        public guiShowTemplateItems(int templateID)
        {
            InitializeComponent();
        }

        private void guiTemplateItems_Load(object sender, EventArgs e)
        {
            fld_trlTemplateItems.Screen = this;
            fld_trlTemplateItems.InitializeControl();
            fld_trlTemplateItems.BOSDisplayRoot = false;
            fld_trlTemplateItems.BOSDisplayOption = true;
            fld_trlTemplateItems.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(fld_trlTemplateItems_CellValueChanging);

            //Init tree list columns
            String tableName = BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARProposalTemplateItemsInfo));
            fld_trlTemplateItems.InitTreeListColumns(tableName);
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn column in fld_trlTemplateItems.Columns)
            {
                column.Visible = false;
            }
            fld_trlTemplateItems.Columns["ARProposalTemplateItemProductName"].Visible = true;
            fld_trlTemplateItems.Columns["ARProposalTemplateItemProductName"].VisibleIndex = 0;
            fld_trlTemplateItems.Columns["Selected"].Visible = true;
            fld_trlTemplateItems.Columns["Selected"].VisibleIndex = 1;

            TreeList = new BOSTreeList();
            TreeList.InitBOSList(null, TableName.ARProposalsTableName,
                                       TableName.ARProposalTemplateItemsTableName,
                                       BOSTreeList.cstRelationForeign);
            TreeList.TreeListControl = fld_trlTemplateItems;
            fld_trlTemplateItems.DataSource = TreeList;

            ARProposalTemplateItemsController objProposalTemplateItemsController = new ARProposalTemplateItemsController();
            List<ARProposalTemplateItemsInfo> proposalTemplateItemList = new List<ARProposalTemplateItemsInfo>();
            proposalTemplateItemList = objProposalTemplateItemsController.GetTemplateItemsByProposalID(ARProposalID);
            ((ProposalModule)this.Module).InvalidateTreeList(TreeList, proposalTemplateItemList, 0);
            ((ProposalModule)this.Module).RefreshTreeView(TreeList);

            CheckPreviousTemplateItemGroup();
            fld_trlTemplateItems.BestFitColumns();
            fld_trlTemplateItems.ExpandAll();
        }

        public void CheckPreviousTemplateItemGroup()
        {
            ARProposalTemplateItemsInfo objTemplateItemsInfo = (ARProposalTemplateItemsInfo)TreeList.GetObjectByPropertyNameAndValue("ARProposalTemplateItemID", ARProposalTemplateItemID);
            if (objTemplateItemsInfo != null)
            {
                objTemplateItemsInfo.Selected = true;
                fld_trlTemplateItems.DataSource = null;
                fld_trlTemplateItems.DataSource = TreeList;
            }
        }

        private void fld_trlTemplateItems_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selected")
            {
                ARProposalTemplateItemsInfo currentObject = (ARProposalTemplateItemsInfo)TreeList.CurrentObject;
                if (currentObject != null && !currentObject.Selected)
                {
                    TreeList.SetValueToList("Selected", false);
                    currentObject.Selected = true;
                    ARProposalTemplateItemID = currentObject.ARProposalTemplateItemID;
                    ARProposalTemplateItemProductName = currentObject.ARProposalTemplateItemProductName;
                    fld_trlTemplateItems.RefreshDataSource();
                }
                else
                {
                    TreeList.SetValueToList("Selected", false);
                    currentObject.Selected = false;
                    ARProposalTemplateItemID = 0;
                    ARProposalTemplateItemProductName = string.Empty;
                    fld_trlTemplateItems.RefreshDataSource();
                }
                CurentProposalTemplateItemsInfo = currentObject;

            }
        }

        private void Fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Fld_btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}