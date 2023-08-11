using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Data;
using BOSLib;
using BOSCommon;
using Localization;
using DevExpress.Utils;

namespace BOSERP.MES.Modules.BatchProposal
{
    public class MMProposalItemsLumberGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchProposalEntities entity = (BatchProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProposalItemLumberList;
            this.DataSource = bds;
        }
        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);
        //    DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
        //    column = new DevExpress.XtraGrid.Columns.GridColumn();
        //    column.Caption = BatchProposalLocalizeResources.MMProposalItemHeight;
        //    column.FieldName = "MMProposalItemHeight";
        //    gridView.Columns.Add(column);
        //}
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProposalItemIsNewProduct" || column.FieldName == "MMProposalItemIsJoinComponent" ||
                    column.FieldName == "MMProposalItemProductBarcode" || column.FieldName == "MMProposalItemProductHDLR" ||
                    column.FieldName == "MMProposalItemProductHDSD" || column.FieldName == "MMProposalItemProductLabel" ||
                    column.FieldName == "MMProposalItemLabelCorlor" || column.FieldName == "MMProposalItemProductWarranty" ||
                    column.FieldName == "MMProposalItemProductCard" || column.FieldName == "MMProposalItemProductFSCCard")
                {
                    column.Visible = false;
                }
                if (column.FieldName == "MMProposalItemProductDesc" || column.FieldName == "MMProposalItemProductNo" ||
                    column.FieldName == "MMProposalItemProductName")
                {
                    column.OptionsColumn.AllowEdit = false;
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
                    RepositoryItemLookUpEdit repPriority = new RepositoryItemLookUpEdit();
                    repPriority.DisplayMember = "ICProductAttributeValue";
                    repPriority.ValueMember = "ICProductAttributeID";
                    repPriority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repPriority.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repPriority.NullText = string.Empty;
                    repPriority.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại gỗ"));
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
                if (column.FieldName == "MMProposalItemProductAttributeColer")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchProposalModule)Screen.Module).RemoveBatchLumberItemList();
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
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProposalItemPackagingRequimentType",e.Value.ToString());
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
        }

        public void LoadGridViewForRoundWood(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["MMProposalItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductMinWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductMaxWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductMinHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductMaxHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["MMProposalItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.Caption = BatchProposalLocalizeResources.MMProposalItemQty;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    //column.VisibleIndex = 9;
                }
                else
                {
                    column.Visible = false;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            gridView.BestFitColumns();
        }
    }
}
