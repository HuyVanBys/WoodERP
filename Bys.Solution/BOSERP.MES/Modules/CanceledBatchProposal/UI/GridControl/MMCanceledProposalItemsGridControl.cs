using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledBatchProposal
{
    public class MMCanceledProposalItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CanceledProposalItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProductAttributeTTMTID")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Tình trạng môi trường"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityTTMT_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "FK_ICProductAttributeHTTypeID")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Hoàn thiện"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityHTType_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "FK_ICProductAttributeWoodTypeID")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityWoodType_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "FK_ICProductAttributeColorID")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Màu sơn"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityColor_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "MMProposalItemPackagingRequimentType")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ADConfigText";
                    repPriority.ValueMember = "ADConfigKeyValue";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ADConfigText", "Tiêu chuẩn đóng gói"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityPackaging_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "FK_ICProductAttributeQualityID")
                {
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));
                    repPriority.QueryPopUp += new System.ComponentModel.CancelEventHandler(repPriorityQuality_QueryPopUp);
                    column.ColumnEdit = repPriority;
                }
                if (column.FieldName == "MMProposalItemProductAttributeColor")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            // gridView.CellValueChanging += new CellValueChangedEventHandler(gridView_CellValueChanging);
            return gridView;
        }

        public void repPriorityTTMT_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeTTMTColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repPriorityHTType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeHTTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repPriorityWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repPriorityColor_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeColorColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repPriorityPackaging_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProposalItemPackagingRequimentType");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            if (ConfigValuesList != null)
            {
                lookUpEdit.Properties.DataSource = ConfigValuesList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }
        public void repPriorityQuality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeQualityColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.CanceledProposalItemList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.MMCanceledProposalItemsTableName] = (MMCanceledProposalItemsInfo)entity.CanceledProposalItemList[entity.CanceledProposalItemList.CurrentIndex];
                MMCanceledProposalItemsInfo item = (MMCanceledProposalItemsInfo)entity.CanceledProposalItemList[entity.CanceledProposalItemList.CurrentIndex];
                if (gridView.FocusedColumn.FieldName == "MMCanceledProposalItemProductQty")
                {
                    if (!((CanceledBatchProposalModule)Screen.Module).IsValidCanceledQty(item, decimal.Parse(e.Value.ToString())))
                    {
                        MessageBox.Show(string.Format(CanceledProposalLocalizedResources.CanceledProposalQtyCannotBeGreaterThanProposalQty), MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        entity.CanceledProposalItemList[entity.CanceledProposalItemList.CurrentIndex].MMCanceledProposalItemProductQty = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
                (entity.Module as CanceledBatchProposalModule).ChangeItemFromCancelProposalItemList();
            }
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((CanceledBatchProposalModule)Screen.Module).RemoveCanceledProposalItemList();
            }
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            if (e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "MMProposalItemPackagingRequimentType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProposalItemPackagingRequimentType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductAttributeHTTypeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeColorID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductsInfo objProductsInfo = new ICProductsInfo();
                        ICProductsController objProductsController = new ICProductsController();
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(value);
                        if (objProductsInfo != null)
                        {
                            e.DisplayText = objProductsInfo.ICProductNo;
                        }
                    }
                }
            }
        }
    }
}
