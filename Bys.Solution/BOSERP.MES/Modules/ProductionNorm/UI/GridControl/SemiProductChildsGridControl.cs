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
using System.ComponentModel;
using System.Drawing;
using BOSCommon;
using DevExpress.Utils;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class SemiProductChildsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductListChild;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridColumn column = new GridColumn();
            column.Caption = "STT";
            column.FieldName = "ICProductOrderID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Insert(0, column);

            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "ICProductItemQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(9, column);



            column = new GridColumn();
            column.Caption = "Đặc tính";
            column.FieldName = "FK_ICProductAttributeSemiProductSpecialityID";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 11;
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
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeLookupEdit_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;


            column = new GridColumn();
            column.Caption = "Thuộc cụm";
            column.FieldName = "ICProductParentID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(10, column);
            RepositoryItemLookUpEdit repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit2.DisplayMember = "ICProductNo";
            repositoryItemLookUpEdit2.ValueMember = "ICProductID";
            repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit2.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit2.NullText = string.Empty;
            repositoryItemLookUpEdit2.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã cụm"));
            repositoryItemLookUpEdit2.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên cụm"));
            List<ICProductsInfo> objProductList = new List<ICProductsInfo>();
            //ICProductsInfo objProductDumy = new ICProductsInfo();
            //objProductList.Add(objProductDumy);
            foreach (ICProductsInfo objProductsInfo in entity.SemiProductListParent)
            {
                objProductList.Add((ICProductsInfo)objProductsInfo.Clone());
            }
            repositoryItemLookUpEdit2.DataSource = objProductList;
            repositoryItemLookUpEdit2.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit2;

            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName == "ICProductNo")
                {
                    col.Caption = ProductionNormLocalizeResources.ProductNoDetailCaption;
                    column.OptionsColumn.AllowEdit = true;
                }
                if (col.FieldName == "ICProductName")
                {
                    col.Caption = ProductionNormLocalizeResources.ProductNameDetailCaption;
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "FK_ICProductGroupID")
                {
                    column.Caption = ProductionNormLocalizeResources.ProductDetailNameCaption;
                    column.OptionsColumn.AllowEdit = true;
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
        void repositoryItemAttributeLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {

            //    ICDepartmentAttributesController objDepartmentAttributesController = new ICDepartmentAttributesController();
            //    ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
            //    List<ICDepartmentAttributesInfo> departmentAttributeList = new List<ICDepartmentAttributesInfo>();
            //    ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            //    List<ICDepartmentAttributeValuesInfo> departmentAttributeValueList = new List<ICDepartmentAttributeValuesInfo>();
            //    DataSet ds1 = new DataSet();
            //    DataSet ds = objDepartmentAttributesController.GetAllAttributesByDepartmentID(item.FK_ICDepartmentID);
            //    if (ds != null)
            //    {
            //        departmentAttributeList = (List<ICDepartmentAttributesInfo>)objDepartmentAttributesController.GetListFromDataSet(ds);
            //        if (departmentAttributeList != null)
            //        {
            //            foreach (ICDepartmentAttributesInfo itemList in departmentAttributeList)
            //            {
            //                DataSet dsItem = objDepartmentAttributeValuesController.GetAllDataByForeignColumn("FK_ICDepartmentAttributeID", itemList.ICDepartmentAttributeID);
            //                ds1.Merge(dsItem);
            //            }
            //        }
            //    }

            //    if (ds1 != null && ds1.Tables.Count > 0)
            //    {
            //        //Init the  grid DataSource
            //        departmentAttributeValueList = (List<ICDepartmentAttributeValuesInfo>)objDepartmentAttributeValuesController.GetListFromDataSet(ds1);
            //        if (departmentAttributeValueList != null)
            //        {
            //            departmentAttributeValueList.Insert(0, objDepartmentAttributeValuesInfo);
            //            lookUpEdit.Properties.DataSource = departmentAttributeValueList;
            //            lookUpEdit.Properties.DisplayMember = "ICDepartmentAttributeValueValue";
            //            lookUpEdit.Properties.ValueMember = "ICDepartmentAttributeValueID";
            //        }

            //    }

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
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.Visible = false;
            }
            if (gridView.Columns["ICProductNo"] != null)
            {
                gridView.Columns["ICProductNo"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICProductNo"].Visible = true;
                gridView.Columns["ICProductNo"].VisibleIndex = 0;
                gridView.Columns["ICProductNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            if (gridView.Columns["ICProductOrderID"] != null)
            {
                gridView.Columns["ICProductOrderID"].Visible = true;
                gridView.Columns["ICProductOrderID"].VisibleIndex = 1;
            }
            if (gridView.Columns["ICProductName"] != null)
            {
                gridView.Columns["ICProductName"].Visible = true;
                gridView.Columns["ICProductName"].VisibleIndex = 2;
                gridView.Columns["ICProductName"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].Visible = true;
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].VisibleIndex = 3;
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].OptionsColumn.AllowEdit = true;

                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemAttributeLookupEdit3_QueryPopUp);
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].ColumnEdit = repositoryItemLookUpEdit;

            }

            if (gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"].Visible = true;
                gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"].VisibleIndex = 4;
                gridView.Columns["FK_ICProductAttributeSemiProductSpecialityID"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductAttributeKey"] != null)
            {
                gridView.Columns["ICProductAttributeKey"].Visible = true;
                gridView.Columns["ICProductAttributeKey"].VisibleIndex = 4;
                gridView.Columns["ICProductAttributeKey"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductItemQty"] != null)
            {
                gridView.Columns["ICProductItemQty"].Visible = true;
                gridView.Columns["ICProductItemQty"].VisibleIndex = 5;
                gridView.Columns["ICProductItemQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductHeight"] != null)
            {
                gridView.Columns["ICProductHeight"].Visible = true;
                gridView.Columns["ICProductHeight"].VisibleIndex = 6;
                gridView.Columns["ICProductHeight"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["ICProductHeight"].DisplayFormat.FormatType = FormatType.Numeric;
                //gridView.Columns["ICProductHeight"].DisplayFormat.FormatString = "{0:n2}";
            }
            if (gridView.Columns["ICProductWidth"] != null)
            {
                gridView.Columns["ICProductWidth"].Visible = true;
                gridView.Columns["ICProductWidth"].VisibleIndex = 7;
                gridView.Columns["ICProductWidth"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["ICProductWidth"].DisplayFormat.FormatType = FormatType.Numeric;
                //gridView.Columns["ICProductWidth"].DisplayFormat.FormatString = "{0:n2}";
            }
            if (gridView.Columns["ICProductLength"] != null)
            {
                gridView.Columns["ICProductLength"].Visible = true;
                gridView.Columns["ICProductLength"].VisibleIndex = 8;
                gridView.Columns["ICProductLength"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["ICProductLength"].DisplayFormat.FormatType = FormatType.Numeric;
                //gridView.Columns["ICProductLength"].DisplayFormat.FormatString = "{0:n2}";
            }
            if (gridView.Columns["ICProductJoinery"] != null)
            {
                gridView.Columns["ICProductJoinery"].Visible = true;
                gridView.Columns["ICProductJoinery"].VisibleIndex = 9;
                gridView.Columns["ICProductJoinery"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICProductGroupID"] != null)
            {
                gridView.Columns["FK_ICProductGroupID"].Caption = ProductionNormLocalizeResources.ProductDetailNameCaption;
                gridView.Columns["FK_ICProductGroupID"].Visible = true;
                gridView.Columns["FK_ICProductGroupID"].VisibleIndex = 10;
                gridView.Columns["FK_ICProductGroupID"].OptionsColumn.AllowEdit = true;



            }
            if (gridView.Columns["ICProductParentID"] != null)
            {
                gridView.Columns["ICProductParentID"].Visible = true;
                gridView.Columns["ICProductParentID"].VisibleIndex = 11;
                gridView.Columns["ICProductParentID"].OptionsColumn.AllowEdit = false;


            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }
        void repositoryItemAttributeLookupEdit3_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {

                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                List<ICProductAttributesInfo> objProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());

                lookUpEdit.Properties.DataSource = objProductAttributesList;
                lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
                lookUpEdit.Properties.ValueMember = "ICProductAttributeID";



            }
        }
        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool value = (bool)view.GetRowCellValue(e.RowHandle, "HasComponent");
                if (value != null && (value == true))
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
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
            if (e.Column.FieldName == "ICProductParentID")
            {
                if (e.Value != null && e.Value != string.Empty)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductNo.ToString();
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null && e.Value != string.Empty)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductAttributesInfo != null)
                    {
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue.ToString();
                    }
                }
            }
            
        }



        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo item = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);

            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                List<ICProductsInfo> objProductList = new List<ICProductsInfo>();
                //ICProductsInfo objProductDumy = new ICProductsInfo();
                //objProductList.Add(objProductDumy);
                foreach (ICProductsInfo objProductsInfo in entity.SemiProductListParent)
                {
                    objProductList.Add((ICProductsInfo)objProductsInfo.Clone());
                }

                lookUpEdit.Properties.DataSource = objProductList;
                lookUpEdit.Properties.DisplayMember = "ICProductNo";
                lookUpEdit.Properties.ValueMember = "ICProductID";

            }
        }
    }
}
