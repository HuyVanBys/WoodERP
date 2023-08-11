using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;

using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using BOSCommon;
using System;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class SemiProductParentsGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductListParent;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {

            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column.Caption = "Số lượng";
            column.FieldName = "ICProductItemQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(9, column);
            column.VisibleIndex = 9;

            column = new GridColumn();
            column.Caption = "Loại cụm";
            column.FieldName = "ICProductSemiGroupType";
            column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(10, column);
            column.VisibleIndex = 10;
            RepositoryItemLookUpEdit repositorySemiGroupItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositorySemiGroupItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
            repositorySemiGroupItemLookUpEdit.ValueMember = "ICProductAttributeID";
            repositorySemiGroupItemLookUpEdit.NullText = string.Empty;
            repositorySemiGroupItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeAbbreviation", "Mã cụm"));
            repositorySemiGroupItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại cụm"));
            repositorySemiGroupItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositorySemiGroupTyprItemLookUpEdit_CloseUp);
            repositorySemiGroupItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositorySemiGroupTypeItemLookUpEdit_QueryPopUp);
            column.ColumnEdit = repositorySemiGroupItemLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Cập nhật";
            column.FieldName = "ICProductUpdateGroup";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemButtonEdit rpItemComponent = new RepositoryItemButtonEdit();
            rpItemComponent.NullText = string.Empty;
            rpItemComponent.ReadOnly = false;

            rpItemComponent.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            rpItemComponent.Buttons[0].Caption = "Cập nhật";
            rpItemComponent.Buttons[0].Visible = true;
           
            //rpItemComponent.TextEditStyle =
            //    DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            column.ColumnEdit = rpItemComponent;
            rpItemComponent.ButtonClick += new ButtonPressedEventHandler(rpItemComponentUpdate_ButtonClick);
            rpItemComponent.BorderStyle = BorderStyles.Style3D;
         
            gridView.Columns.Add(column);
            column.Visible = true;
            column.VisibleIndex = 12;

            column = new GridColumn();
            column.Caption = "Đặc tính";
            column.FieldName = "FK_ICProductAttributeSemiProductSpecialityID";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Insert(4, column);
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
            repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
            // repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
            repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemLookUpEdit_CloseUp);
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;

            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName == "ICProductNo")
                    col.Caption = ProductionNormLocalizeResources.ProductNoGroupCaption;
                if (col.FieldName == "ICProductName")
                    col.Caption = ProductionNormLocalizeResources.ProductNameGroupCaption;
                if (col.FieldName == "FK_ICProductGroupID")
                    col.Visible = false;

            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {

                //ICDepartmentAttributesController objDepartmentAttributesController = new ICDepartmentAttributesController();
                //ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
                //List<ICDepartmentAttributesInfo> departmentAttributeList = new List<ICDepartmentAttributesInfo>();
                //ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
                //List<ICDepartmentAttributeValuesInfo> departmentAttributeValueList = new List<ICDepartmentAttributeValuesInfo>();
                //DataSet ds1 = new DataSet();
                //DataSet ds = objDepartmentAttributesController.GetAllAttributesByDepartmentID(item.FK_ICDepartmentID);
                //if (ds != null)
                //{
                //    departmentAttributeList = (List<ICDepartmentAttributesInfo>)objDepartmentAttributesController.GetListFromDataSet(ds);
                //    if (departmentAttributeList != null)
                //    {
                //        foreach (ICDepartmentAttributesInfo itemList in departmentAttributeList)
                //        {
                //            DataSet dsItem = objDepartmentAttributeValuesController.GetAllDataByForeignColumn("FK_ICDepartmentAttributeID", itemList.ICDepartmentAttributeID);
                //            ds1.Merge(dsItem);
                //        }
                //    }
                //}

                //if (ds1 != null && ds1.Tables.Count > 0)
                //{
                //    //Init the  grid DataSource
                //    departmentAttributeValueList = (List<ICDepartmentAttributeValuesInfo>)objDepartmentAttributeValuesController.GetListFromDataSet(ds1);
                //    if (departmentAttributeValueList != null)
                //    {
                //        departmentAttributeValueList.Insert(0, objDepartmentAttributeValuesInfo);
                //        lookUpEdit.Properties.DataSource = departmentAttributeValueList;
                //        lookUpEdit.Properties.DisplayMember = "ICDepartmentAttributeValueValue";
                //        lookUpEdit.Properties.ValueMember = "ICDepartmentAttributeValueID";
                //    }

                //}

                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                List<ICProductAttributesInfo> productAttributes = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Speciality.ToString());
                if (productAttributes != null)
                {
                    lookUpEdit.Properties.DataSource = productAttributes;
                    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                }
            }
        }

        void repositorySemiGroupTypeItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                List<ICProductAttributesInfo> productAttributes = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeGroupSemiTypeColumnName.ToString());
                if (productAttributes != null)
                {
                    lookUpEdit.Properties.DataSource = productAttributes;
                    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
                }
            }
        }

        void repositoryItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                item.ICProductAttributeKey = e.Value.ToString();
            }
        }
        void repositorySemiGroupTyprItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
        }
        private void rpItemComponentUpdate_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsInfo objProductToAddsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objProductsInfo != null)
            {
                ((ProductionNormModule)Screen.Module).SaveSemiProductGroup(gridView.FocusedRowHandle);
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //foreach (GridColumn column in gridView.Columns)
            //{
            //    column.Visible = false;
            //}

            if (gridView.Columns["ICProductOrderID"] != null)
            {
                gridView.Columns["ICProductOrderID"].Visible = true;
                gridView.Columns["ICProductOrderID"].VisibleIndex = 1;
            }
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 2;
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductName"] != null)
            {
                gridView.Columns["ICProductName"].Visible = true;
                gridView.Columns["ICProductName"].VisibleIndex = 3;
                gridView.Columns["ICProductName"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["FK_ICProductGroupID"] != null)
            {
                gridView.Columns["FK_ICProductGroupID"].Caption = ProductionNormLocalizeResources.ProductDetailNameCaption;
                gridView.Columns["FK_ICProductGroupID"].Visible = true;
                gridView.Columns["FK_ICProductGroupID"].VisibleIndex = 11;
            }
            if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].Visible = true;
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].VisibleIndex = 4;
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ICProductItemQty"] != null)
            {
                gridView.Columns["ICProductItemQty"].Visible = true;
                gridView.Columns["ICProductItemQty"].VisibleIndex = 6;
                gridView.Columns["ICProductItemQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ICProductUpdateGroup"] != null)
            {
                gridView.Columns["ICProductUpdateGroup"].Visible = true;
                gridView.Columns["ICProductUpdateGroup"].VisibleIndex = 7;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ICProductAttributeKey")
            {
                if (e.Value != null && e.Value != string.Empty)
                {
                    ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
                    ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();

                    string displayText = string.Empty;
                    string[] attributeIDs = e.Value.ToString().Split('_');
                    foreach (string attributeIDStr in attributeIDs)
                    {
                        int attributeID = 0;
                        if (int.TryParse(attributeIDStr.Trim(), out attributeID))
                        {
                            objDepartmentAttributeValuesInfo = (ICDepartmentAttributeValuesInfo)objDepartmentAttributeValuesController.GetObjectByID(attributeID);
                            if (objDepartmentAttributeValuesInfo != null)
                            {
                                if (!string.IsNullOrEmpty(displayText))
                                {
                                    displayText += "; ";
                                }
                                displayText += objDepartmentAttributeValuesInfo.ICDepartmentAttributeValueValue.ToString();
                            }
                        }
                    }

                    e.DisplayText = displayText;

                }
            }
            if (e.Column.FieldName == "ICProductSemiGroupType")
            {
                if (e.Value != null && e.Value != string.Empty)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID (int.Parse(e.Value.ToString()));
                    if(objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                }
            }
        }
    }
}
