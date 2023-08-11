using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Data;
using BOSLib;
using Localization;

namespace BOSERP.Modules.Promotion
{
    public class ICPromotionItemsGridControl : BOSComponent.BOSGridControl 
    {
        public override void InitGridControlDataSource()
        {
            PromotionEntities entity = (PromotionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICPromotionItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PromotionLocalizedResources.ICPromotionItemRegularePrice;
            column.FieldName = "ICPromotionItemRegularePrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PromotionLocalizedResources.ICPromotionItemDiscountPrice;
            column.FieldName = "ICPromotionItemDiscountPrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PromotionModule)Screen.Module).DeleteSelectedPromotionItem();
            }
        }
    }
}
