using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class MMProposalItemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<MMProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }


        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            foreach (GridColumn columnItem in gridView.Columns)
            {
                columnItem.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["FK_MMProposalID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
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


        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = true;
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
            repositoryItemTextEdit.DisplayFormat.FormatString = "{0:" + formatType + "}";
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
