using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
{
    public class MMAllocationPlanItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMAllocationPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            if (e.Column.FieldName == "MMPriority")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.Priority, e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            else if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    }
                    else
                        e.DisplayText = string.Empty;
                }
            }
            else if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            {
                if (e.Value != null)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    }
                    else
                        e.DisplayText = string.Empty;
                }
            }

            else if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = new ICProductsInfo();
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(value);
                        if (objProductsInfo != null)
                            e.DisplayText = objProductsInfo.ICProductNo;
                    }
                    else
                        e.DisplayText = string.Empty;
                }
            }
            else if (e.Column.FieldName == "FK_MMAllocationPlanID")
            {
                if (e.Value != null)
                {
                    MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
                    MMAllocationPlansInfo objAllocationPlansInfo = new MMAllocationPlansInfo();
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objAllocationPlansInfo = (MMAllocationPlansInfo)objAllocationPlansController.GetObjectByID(value);
                        if (objAllocationPlansInfo != null)
                            e.DisplayText = objAllocationPlansInfo.MMAllocationPlanNo;
                    }
                    else
                        e.DisplayText = string.Empty;
                }
            }
        }
    }
}
