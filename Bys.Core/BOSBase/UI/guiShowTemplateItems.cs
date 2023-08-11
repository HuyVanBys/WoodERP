using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils.Extensions;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiShowTemplateItems : BOSERPScreen
    {
        public int PMTemplateID { get; set; }

        public int PMTemplateItemID { get; set; }

        public string PMTemplateItemProductName { get; set; }

        public BOSTreeList TreeList { get; set; }

        public bool IsAllowEditTemplate { get; set; }
        public guiShowTemplateItems()
        {
            InitializeComponent();
        }

        public guiShowTemplateItems(int templateID)
        {
            InitializeComponent();
            PMTemplateID = templateID;
        }

        private void guiTemplateItems_Load(object sender, EventArgs e)
        {
            fld_trlTemplateItems.Screen = this;
            fld_trlTemplateItems.InitializeControl();
            fld_trlTemplateItems.BOSDisplayRoot = false;
            fld_trlTemplateItems.BOSDisplayOption = true;
            fld_trlTemplateItems.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(fld_trlTemplateItems_CellValueChanging);

            //Init tree list columns
            String tableName = BOSUtil.GetTableNameFromBusinessObjectType(typeof(PMTemplateItemsInfo));
            fld_trlTemplateItems.InitTreeListColumns(tableName);
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn column in fld_trlTemplateItems.Columns)
            {
                column.Visible = false;
            }
            fld_trlTemplateItems.Columns["PMTemplateItemProductName"].Visible = true;
            fld_trlTemplateItems.Columns["PMTemplateItemProductName"].VisibleIndex = 0;
            fld_trlTemplateItems.Columns["Selected"].Visible = true;
            fld_trlTemplateItems.Columns["Selected"].VisibleIndex = 1;

            TreeList = new BOSTreeList();
            TreeList.InitBOSList(null, TableName.PMTemplatesTableName,
                                       TableName.PMTemplateItemsTableName,
                                       BOSTreeList.cstRelationForeign);
            TreeList.TreeListControl = fld_trlTemplateItems;
            fld_trlTemplateItems.DataSource = TreeList;

            PMTemplatesController objTemplatesController = new PMTemplatesController();
            List<PMTemplatesInfo> templatesList = objTemplatesController.GetAllTemplates();
            templatesList.Insert(0, new PMTemplatesInfo());

            fld_lkeTemplates.Properties.DataSource = templatesList;
            fld_lkeTemplates.Enabled = IsAllowEditTemplate;
            fld_lkeTemplates.Properties.ReadOnly = !IsAllowEditTemplate;

            if (PMTemplateID > 0)
                fld_lkeTemplates.EditValue = PMTemplateID;
            else
                fld_lkeTemplates.ItemIndex = 0;

            CheckPreviousTemplateItemGroup();
            fld_trlTemplateItems.BestFitColumns();
            fld_trlTemplateItems.ExpandAll();
        }

        public void CheckPreviousTemplateItemGroup()
        {
            PMTemplateItemsInfo objTemplateItemsInfo = (PMTemplateItemsInfo)TreeList.GetObjectByPropertyNameAndValue("PMTemplateItemID", PMTemplateItemID);
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
                PMTemplateItemsInfo currentObject = (PMTemplateItemsInfo)TreeList.CurrentObject;
                if (currentObject != null && !currentObject.Selected)
                {
                    TreeList.SetValueToList("Selected", false);
                    currentObject.Selected = true;
                    PMTemplateItemID = currentObject.PMTemplateItemID;
                    PMTemplateItemProductName = currentObject.PMTemplateItemProductName;
                    fld_trlTemplateItems.RefreshDataSource();
                }
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

        private void Fld_lkePMTemplateItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int templateItemID = Convert.ToInt32(e.Value);
                PMTemplateItemsController objTemplateItemsController = new PMTemplateItemsController();
                PMTemplateItemsInfo objTemplateItemsInfo = (PMTemplateItemsInfo)objTemplateItemsController.GetObjectByID(templateItemID);
                if (objTemplateItemsInfo != null)
                {
                    if (objTemplateItemsInfo.FK_PMTemplateID != PMTemplateID)
                    {
                        PMTemplateID = objTemplateItemsInfo.FK_PMTemplateID;
                        fld_lkeTemplates.EditValue = objTemplateItemsInfo.FK_PMTemplateID;
                    }

                    TreeList.SetValueToList("Selected", false);
                    objTemplateItemsInfo = (PMTemplateItemsInfo)TreeList.GetObjectByPropertyNameAndValue("PMTemplateItemID", templateItemID);
                    if (objTemplateItemsInfo != null)
                    {
                        objTemplateItemsInfo.Selected = true;
                        PMTemplateItemID = objTemplateItemsInfo.PMTemplateItemID;
                        PMTemplateItemProductName = objTemplateItemsInfo.PMTemplateItemProductName;
                    }
                    fld_trlTemplateItems.RefreshDataSource();
                }
            }
        }

        private void Fld_lkeTemplates_EditValueChanged(object sender, EventArgs e)
        {
            int templateID = Convert.ToInt32(fld_lkeTemplates.EditValue);
            if (templateID > 0)
            {
                PMTemplateID = templateID;
                TreeList.InvalidateTreeList(PMTemplateID);
                TreeList.Remove(p =>
                    (p as PMTemplateItemsInfo).PMTemplateItemParentID != 0 &&
                    (p as PMTemplateItemsInfo).SubList == null);
                TreeList.TreeListControl.RefreshDataSource();
            }
        }
    }
}