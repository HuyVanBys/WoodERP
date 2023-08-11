using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProposal
{
    public class MMProposalItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchProposalEntities entity = (BatchProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProposalItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProposalItemProductDesc" || column.FieldName == "MMProposalItemProductNo"
                     || column.FieldName == "MMProposalItemProductName")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "MMProposalItemTotalAmount"
                    || column.FieldName == "MMProposalItemProductUnitPrice")
                {
                    FormatNumbericColumn(column, true, "n2");
                }

                if (column.FieldName == "MMProposalItemProductQty")
                {
                    FormatNumbericColumn(column, true, "n3");
                }

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
                    column.OptionsColumn.AllowEdit = false;
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
                    column.OptionsColumn.AllowEdit = false;
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
                if (column.FieldName == "MMProposalItemProductAttributeHTType")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "MMProposalItemWoodTypeText")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "MMProposalItemProductHeight")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "MMProposalItemProductWidth")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "MMProposalItemProductLength")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.CellValueChanging += new CellValueChangedEventHandler(gridView_CellValueChanging);
            return gridView;
        }

        void gridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            BatchProposalEntities entity = (BatchProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            if (entity.ProposalItemList.CurrentIndex >= 0)
            {

                MMProposalItemsInfo item = (MMProposalItemsInfo)entity.ProposalItemList[entity.ProposalItemList.CurrentIndex];
                if (e.Column.FieldName == "MMProposalItemIsNewProduct" || e.Column.FieldName == "MMProposalItemIsJoinComponent"
                    || e.Column.FieldName == "MMProposalItemProductBarcode" || e.Column.FieldName == "MMProposalItemProductHDLR"
                    || e.Column.FieldName == "MMProposalItemProductHDSD" || e.Column.FieldName == "MMProposalItemProductLabel"
                    || e.Column.FieldName == "MMProposalItemLabelCorlor" || e.Column.FieldName == "MMProposalItemProductWarranty"
                    || e.Column.FieldName == "MMProposalItemProductCard" || e.Column.FieldName == "MMProposalItemProductFSCCard")
                {
                    bool value = false;

                    if (e.Value != null)
                        value = (bool)e.Value;
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if (item != null)
                    {
                        dbUtil.SetPropertyValue(item, e.Column.FieldName, value);
                    }
                    //gridView.FocusedRowHandle.
                    entity.ModuleObjects[TableName.MMProposalItemsTableName] = entity.ProposalItemList[entity.ProposalItemList.CurrentIndex];
                    entity.UpdateModuleObjectsBindingSource();
                    //InitGridControlDataSource();
                    ((BatchProposalModule)Screen.Module).ConfirmChangeItem(e.Column.FieldName, value);
                }
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            BatchProposalEntities entity = (BatchProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ProposalItemList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.MMProposalItemsTableName] = (MMProposalItemsInfo)entity.ProposalItemList[entity.ProposalItemList.CurrentIndex];

                if (e.Column.FieldName == "MMProposalItemProductQty")
                {
                    ((BatchProposalModule)Screen.Module).ChangeItemTotalAmount();
                }
            }
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
        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);
        //}

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchProposalModule)Screen.Module).RemoveBatchItemList();
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

            //if (e.Column.FieldName == "MMProposalItemWoodTypeText")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = ((BatchProposalModule)Screen.Module).GetAttributeText(e.Value.ToString());
            //    }
            //}
        }


        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
