using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACDocTypeEntrysGridControl : BOSGridControl
    {
        private GridHitInfo DownHitInfo = null;
        private string Credit = string.Empty;
        private string Debit = string.Empty;

        public override void InitGridControlDataSource()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACDocTypeEntryList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            #region repository
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.ValueMember = "ACAccountID";
            rep.DisplayMember = "ACAccountNo";
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
            rep.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
            DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData("ACAccounts");
            if (ds == null || (ds != null && ds.Tables.Count == 0))
            {
                ACAccountsController objAccountsController = new ACAccountsController();
                ds = objAccountsController.GetAllAccountSet();
            }
            rep.DataSource = ds.Tables[0];

            GridColumn columnRepository = gridView.Columns["ACDocTypeEntryAccountDefaultCredit"];
            if (columnRepository != null)
            {
                columnRepository.ColumnEdit = rep;
            }
            columnRepository = gridView.Columns["ACDocTypeEntryAccountDefaultDebit"];
            if (columnRepository != null)
            {
                columnRepository.ColumnEdit = rep;
            }

            RepositoryItemButtonEdit reposItemButtonEditCredit = new RepositoryItemButtonEdit();
            RepositoryItemButtonEdit reposItemButtonEditDebit = new RepositoryItemButtonEdit();
            columnRepository = gridView.Columns["ACDocTypeEntryAccountCredit"];
            if (columnRepository != null)
            {
                columnRepository.ColumnEdit = reposItemButtonEditCredit;
            }
            columnRepository = gridView.Columns["ACDocTypeEntryAccountDebit"];
            if (columnRepository != null)
            {
                columnRepository.ColumnEdit = reposItemButtonEditDebit;
            }
            #endregion

            gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            reposItemButtonEditCredit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ShowAccoutByCredit);
            reposItemButtonEditDebit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(ShowAccoutByDebit);

            return gridView;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            MouseMove += new MouseEventHandler(ACDocTypeEntrysGridControl_MouseMove);
            MouseDown += new MouseEventHandler(ACDocTypeEntrysGridControl_MouseDown);
            DragDrop += new DragEventHandler(ACDocTypeEntrysGridControl_DragDrop);
            DragOver += new DragEventHandler(ACDocTypeEntrysGridControl_DragOver);
        }

        #region Do drag drop
        private void ACDocTypeEntrysGridControl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            if (downHitInfo != null)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle)
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void ACDocTypeEntrysGridControl_DragDrop(object sender, DragEventArgs e)
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridControl gridControl = sender as GridControl;
            GridView gridView = gridControl.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = gridView.CalcHitInfo(gridControl.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = srcHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;

            if (sourceRow == targetRow) return;
            ACDocTypeEntrysInfo objDocTypeEntrysTempInfo = (ACDocTypeEntrysInfo)entity.ACDocTypeEntryList[sourceRow].Clone();
            entity.ACDocTypeEntryList.RemoveAt(sourceRow);
            entity.ACDocTypeEntryList.Insert(targetRow, objDocTypeEntrysTempInfo);
            InitGridControlDataSource();
        }

        private void ACDocTypeEntrysGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            DownHitInfo = null;
            GridHitInfo hitInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow)
                DownHitInfo = hitInfo;
        }

        private void ACDocTypeEntrysGridControl_MouseMove(object sender, MouseEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Button == MouseButtons.Left && DownHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(DownHitInfo.HitPoint.X - dragSize.Width / 2,
                    DownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    gridView.GridControl.DoDragDrop(DownHitInfo, DragDropEffects.All);
                    DownHitInfo = null;
                }
            }
        }
        #endregion

        /// <summary>
        /// Show account by doc type entry account type is debit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAccoutByDebit(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ACDocumentTypeModule)Screen.Module).ShowAccount(AccPostingType.Debit.ToString());
        }

        /// <summary>
        /// Show account by doc type entry account type is credit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAccoutByCredit(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((ACDocumentTypeModule)Screen.Module).ShowAccount(AccPostingType.Credit.ToString());
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ACDocumentTypeModule)Screen.Module).RemoveDocTypeEntryList();
            }
        }

        private void GridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ACEntryTypeDesc")
            {
                e.ErrorText = DocumentTypeLocalizedResources.EntryTypeNameRequiredMessage;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
            if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountCredit")
            {
                e.ErrorText = DocumentTypeLocalizedResources.InvalidAccountStringMessage;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
            if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDefaultCredit")
            {
                e.ErrorText = DocumentTypeLocalizedResources.DocTypeEntryAccountDefaultCreditMessage;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
            if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDebit")
            {
                e.ErrorText = DocumentTypeLocalizedResources.InvalidAccountStringMessage;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
            if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDefaultDebit")
            {
                e.ErrorText = DocumentTypeLocalizedResources.DocTypeEntryAccountDefaultDebitMessage;
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
        }

        private void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value != null)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedColumn.FieldName == "ACEntryTypeDesc")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.Valid = false;
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountCredit")
                {
                    string accountString = e.Value.ToString();
                    if (!string.IsNullOrEmpty(accountString))
                    {
                        accountString = ((ACDocumentTypeModule)Screen.Module).AdjustAccountString(accountString);
                        if (string.IsNullOrEmpty(accountString))
                        {
                            e.Valid = false;
                        }
                    }
                    e.Value = accountString;
                    Credit = accountString;
                }
                else if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDefaultCredit")
                {
                    //Set value for credit when user not click on doc type entry account credit
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                        ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
                        objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        Credit = objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit;
                    }
                    if (((ACDocumentTypeModule)Screen.Module).CheckExistDefaultCredit(Convert.ToInt32(e.Value), Credit))
                    {
                        e.Valid = false;
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDebit")
                {
                    string accountString = e.Value.ToString();
                    if (!string.IsNullOrEmpty(accountString))
                    {
                        accountString = ((ACDocumentTypeModule)Screen.Module).AdjustAccountString(accountString);
                        if (string.IsNullOrEmpty(accountString))
                        {
                            e.Valid = false;
                        }
                    }
                    e.Value = accountString;
                    Debit = accountString;
                }
                else if (gridView.FocusedColumn.FieldName == "ACDocTypeEntryAccountDefaultDebit")
                {
                    //Set value for debit when user not click on doc type entry account debit
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                        ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
                        objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        Debit = objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit;
                    }

                    if (((ACDocumentTypeModule)Screen.Module).CheckExistDefaultDebit(Convert.ToInt32(e.Value), Debit))
                    {
                        e.Valid = false;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = DocumentTypeLocalizedResources.DocTypeEntryAccountCredit;
            column.FieldName = "ACDocTypeEntryAccountCredit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = DocumentTypeLocalizedResources.DocTypeEntryAccountDefaultCredit;
            column.FieldName = "ACDocTypeEntryAccountDefaultCredit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = DocumentTypeLocalizedResources.DocTypeEntryAccountDebit;
            column.FieldName = "ACDocTypeEntryAccountDebit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = DocumentTypeLocalizedResources.DocTypeEntryAccountDefaultDebit;
            column.FieldName = "ACDocTypeEntryAccountDefaultDebit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = DocumentTypeLocalizedResources.EntryTypeDesc;
            column.FieldName = "ACEntryTypeDesc";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }


    }
}
