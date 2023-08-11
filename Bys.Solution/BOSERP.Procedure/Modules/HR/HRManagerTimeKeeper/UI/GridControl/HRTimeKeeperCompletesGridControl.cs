using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRTimeKeeperCompletesGridControl : BOSComponent.BOSGridControl
    {
        ContextMenu menu = new ContextMenu();
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        public override void InitializeControl()
        {
            base.InitializeControl();
            MenuItem item = new MenuItem();
            item.Text = "Nhân đôi dòng";
            item.Click += new EventHandler(item_Click);
            menu.MenuItems.Add(item);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            GridView view = (GridView)this.DefaultView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info != null && (info.HitTest == GridHitTest.RowCell || info.HitTest == GridHitTest.RowIndicator)
                && e.Button == MouseButtons.Right)
            {
                menu.Show(this, pt);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)this.DefaultView;
            int index = view.GetDataSourceRowIndex(view.FocusedRowHandle);
            if (index >= 0)
            {
                List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList = (List<HRTimeKeeperCompletesInfo>)this.DataSource;
                HRTimeKeeperCompletesInfo obj = (HRTimeKeeperCompletesInfo)timeKeeperCompleteList[index].Clone();
                timeKeeperCompleteList.Insert(index, obj);
                this.RefreshDataSource();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.EmployeeName;
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            column.Group();
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.ThName;
            column.FieldName = "ThName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.TypeInput;
            column.FieldName = "HRTimeKeeperCompleteInOutMode";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã nhân viên";
            column.FieldName = "EmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompleteTimeCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompleteDate"];
            if (column != null)
            {
                column.Group();
            }
            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompletesEmployeeCardNo"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["HRTimeKeeperCompleteDateCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompleteComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = new GridColumn();
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = new GridColumn();
            column = gridView.Columns["FK_HRLevelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = new GridColumn();
            column.Caption = "Xóa dữ liệu";
            column.FieldName = "DiscardItem";
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = PurchaseProposalLocalizedResources.Discard;
            rep.LinkColor = Color.Blue;
            rep.Click += new EventHandler(rep_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trùng giờ";
            column.FieldName = "SameDateTime";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Vắng tăng ca";
            column.FieldName = "OverTimeAbsence";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TC không đăng ký";
            column.FieldName = "NotInOverTime";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Vắng tăng ca";
            column.FieldName = "OverTimeAbsence";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            column = new GridColumn();
            column.Caption = "Giờ ĐK TC";
            column.FieldName = "RegisterOverTimeAbsence";
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = repositoryItemDateEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Bộ phận";
            column.FieldName = "HRDepartmentRoomName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổ";
            column.FieldName = "HRDepartmentRoomGroupItemName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm chấm công";
            column.FieldName = "HREmployeePayrollFormulaName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        void rep_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            HRTimeKeeperCompletesController objTimeKeepersController = new HRTimeKeeperCompletesController();
            if (gridView.FocusedRowHandle >= 0)
            {
                HRTimeKeeperCompletesInfo item = (HRTimeKeeperCompletesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                objTimeKeepersController.DeleteData(item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperCompleteDateCheck, item.HRTimeKeeperCompletesEmployeeCardNo);
                gridView.DeleteRow(gridView.FocusedRowHandle);
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    GridView view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                }
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";
            GridColumn column = gridView.Columns["HRTimeKeeperCompleteTimeCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }
            column = gridView.Columns["HRTimeKeeperCompleteInOutMode"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = repositoryItemDateEdit;
            }
            column = gridView.Columns["HRTimeKeeperCompleteDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = repositoryItemDateEdit;
            }
            gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(gridView_InvalidRowException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = (HRTimeKeeperCompletesInfo)gridView.GetRow(e.RowHandle);
                ((ManagerTimeKeeperModule)Screen.Module).AddBackupList(objTimeKeeperCompletesInfo);

                if (e.Column.FieldName == "HRTimeKeeperCompleteTimeCheck")
                {
                    //1.CheckSameTime
                    ((ManagerTimeKeeperModule)Screen.Module).CheckSameTime(objTimeKeeperCompletesInfo, (List<HRTimeKeeperCompletesInfo>)this.DataSource);
                    //2.CheckNotInOverTime
                    ((ManagerTimeKeeperModule)Screen.Module).CheckNotInOverTime(objTimeKeeperCompletesInfo, 60, true);
                    //2.CheckNotInOverTime
                    ((ManagerTimeKeeperModule)Screen.Module).CheckOverTimeAbsence(objTimeKeeperCompletesInfo, 60, true);
                }
                if (e.Column.FieldName == "HRTimeKeeperCompleteDate")
                {
                    ((ManagerTimeKeeperModule)Screen.Module).ChangeCompleteDate(objTimeKeeperCompletesInfo);
                }
            }
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle == gridView.FocusedRowHandle)
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }


                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = (HRTimeKeeperCompletesInfo)gridView.GetRow(e.RowHandle);
                if (objTimeKeeperCompletesInfo != null)
                {
                    bool isSameTime = ((ManagerTimeKeeperModule)Screen.Module).CheckSameTime(objTimeKeeperCompletesInfo, (List<HRTimeKeeperCompletesInfo>)this.DataSource);
                    if (isSameTime)
                    {
                        e.Appearance.BackColor2 = Color.Red;
                        e.Appearance.BackColor = Color.Red;

                    }
                    else
                    {
                        //objTimeKeeperCompletesInfo.SameDateTime = "True";


                    }
                    //if (objTimeKeeperCompletesInfo.NotInOverTime == "False")
                    //{
                    //    e.Appearance.BackColor2 = Color.Orange;
                    //    e.Appearance.BackColor = Color.Orange;
                    //}
                    if (objTimeKeeperCompletesInfo.OverTimeAbsence == "False")
                    {
                        e.Appearance.BackColor2 = Color.Green;
                        e.Appearance.BackColor = Color.Green;
                    }
                }

            }
        }


        void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
