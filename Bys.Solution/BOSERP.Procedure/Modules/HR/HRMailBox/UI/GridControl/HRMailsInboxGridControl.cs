using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.HRMailBox
{
    public partial class HRMailsInboxGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRMailBoxEntities entity = (HRMailBoxEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRMailsList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            RepositoryItemPictureEdit repositoryItemPictureEdit100 = new RepositoryItemPictureEdit();

            GridColumn column = new GridColumn();
            column.Caption = MailBoxLocalizedResources.Priority;
            column.FieldName = "MailPriority";
            column.ColumnEdit = repositoryItemPictureEdit100;
            column.OptionsColumn.AllowEdit = false;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            column.Visible = true;
            column.Width = 30;
            gridView.Columns.Add(column);



        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowClick += new RowClickEventHandler(GridView_RowClick);
            gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gridView_CustomUnboundColumnData);
            return gridView;
        }

        void gridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.ListSourceRowIndex >= 0)
            {
                HRMailsInfo objMailsInfo = (HRMailsInfo)currentView.GetRow(e.ListSourceRowIndex);
                string mailPriority = objMailsInfo.HRMailPriority.ToString();

                Hashtable images = new Hashtable();
                string fileName = String.Empty;

                if (e.Column.FieldName == "MailPriority" && e.IsGetData)
                {
                    GridView view = sender as GridView;
                    string pathImageRedFlag = Application.StartupPath.ToString();
                    pathImageRedFlag = string.Format("{0}\\img\\{1}", pathImageRedFlag, "redflag.png");

                    string pathImageGreenFlag = Application.StartupPath.ToString();
                    pathImageGreenFlag = string.Format("{0}\\img\\{1}", pathImageGreenFlag, "greenflag.png");

                    string pathImageYellowFlag = Application.StartupPath.ToString();
                    pathImageYellowFlag = string.Format("{0}\\img\\{1}", pathImageYellowFlag, "yellowflag.png");

                    Image img = null;

                    if (mailPriority == MailPriority.Normal.ToString())
                    {
                        img = Image.FromFile(pathImageYellowFlag);
                        images.Add(fileName, img);
                    }
                    if (mailPriority == MailPriority.High.ToString())
                    {
                        img = Image.FromFile(pathImageRedFlag);
                        images.Add(fileName, img);
                    }
                    if (mailPriority == MailPriority.Low.ToString())
                    {
                        img = Image.FromFile(pathImageGreenFlag);
                        images.Add(fileName, img);
                    }
                    e.Value = images[fileName];

                }
            }

        }


        protected void GridView_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HRMailsInfo objMailsInfo = (HRMailsInfo)gridView.GetRow(e.RowHandle);
                int mailID = objMailsInfo.HRMailID;
                ((HRMailBoxModule)Screen.Module).LoadInboxContentMail(mailID);
            }
        }

    }



}
