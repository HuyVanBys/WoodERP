using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.RetailVAT
{
    public class ACRetailVATItemsGridControl : ItemGridControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
        }

        public override void InitGridControlDataSource()
        {
            RetailVATEntities entity = (RetailVATEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RetailVATItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.FieldName = "Package";
            //column.Caption = InvoiceLocalizedResources.Package;
            //RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            //rep.NullText = InvoiceLocalizedResources.ChoosePackage;
            //rep.Click += new EventHandler(RepositoryItemHyperLinkEdit_Click);
            //column.ColumnEdit = rep;
            //gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach(GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((RetailVATModule)Screen.Module).DeleteItemFromInvoiceItemsList();
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            RetailVATEntities entity = (RetailVATEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.RetailVATItemsList.CurrentIndex >= 0)
            {
                ((RetailVATModule)Screen.Module).InitProductPictureImage(entity.RetailVATItemsList[entity.RetailVATItemsList.CurrentIndex].FK_ICProductID);
            }
        }
    }
}
