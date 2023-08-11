using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSERP.Modules.ProductionNorm.UI;
using BOSCommon;
using System.Windows.Forms;
using Localization;
using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using BOSComponent;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using BOSLib;
namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {
        public DataTable OperationDataTable;
        List<int> OperationIDList;
        public BandedGridView GenerateBandedGridView()
        {
            OperationIDList = new List<int>();

            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = true;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;
            OperationDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            generalBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(generalBand);

            //Mã chi tiết
            CreateBandedColumn("Mã chi tiết", "MMProductionNormItemNo", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemNo");
            OperationDataTable.Columns.Add("FK_MMProductionNormItemID");
            OperationDataTable.Columns.Add("FK_MMProductionNormID");

            //Loại gỗ
            CreateBandedColumn("Loại nguyên liệu", "MMProductionNormItemProductWoodType", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemProductWoodType");

            //Tên chi tiết
            CreateBandedColumn("Tên chi tiết", "MMProductionNormItemProductName", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("MMProductionNormItemProductName");
            OperationDataTable.Columns.Add("FK_ICProductID");

            //Mô tả
            CreateBandedColumn("Đặc tính", "FK_ICProductAttributeSpecialityID", true, false, generalBand, banded);
            OperationDataTable.Columns.Add("FK_ICProductAttributeSpecialityID");
            OperationDataTable.Columns.Add("MMProductionNormItemIsComponent");
            OperationDataTable.Columns.Add("IsError");
            //Routing ticket 
            CreateReposityBandedColumn("Chi tiết", "MMProductionNormItemRoutingTicket", true, false, generalBand, banded);
            #endregion

            #region Công đoạn
            MMOperationsController objOperationsController = new MMOperationsController();
            
            #region Comment
            List<MMOperationsInfo> operationList = objOperationsController.GetAllOperationsByParentID(0);
            if (operationList != null && operationList.Count > 0)
            {
                foreach (MMOperationsInfo objOperationsInfo in operationList)
                {
                    List<MMOperationsInfo> operationChildList = objOperationsController.GetAllOperationsByParentID(objOperationsInfo.MMOperationID);
                    if (operationChildList != null && operationChildList.Count > 0)
                    {
                        GridBand gridBand = new GridBand();
                        gridBand.Caption = objOperationsInfo.MMOperationName;
                        banded.Bands.Add(gridBand);
                        GenerateGridBandAndColumnByOperation(objOperationsInfo, objOperationsController, gridBand, banded);
                    }
                    else
                    {
                        GridBand otherBand = new GridBand();
                        otherBand.Caption = objOperationsInfo.MMOperationName;
                        banded.Bands.Add(otherBand);
                        GenerateGridBandAndColumnByOperation(objOperationsInfo, objOperationsController, otherBand, banded);
                        
                    }
                }
            }


            #endregion


            #endregion
            banded.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(banded_RowCellStyle);
            banded.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(bandedView_CellValueChanging);
            banded.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(banded_RowCellClick);
            return banded;
        }

        void banded_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionNormItemRoutingTicket")
            {
                ViewDetail_Click(sender);
            }
        }

        void banded_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            BandedGridView View = sender as BandedGridView;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMProductionNormItemNo")
                {
                    string itemNo = e.CellValue.ToString();
                    if (itemNo != string.Empty)
                    {
                        foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                        {
                            //Chi tiet roi hoac cum
                            if (itemNo == item.MMProductionNormItemNo)
                            {
                                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                                break;
                            }
                        }
                        DataRow drow = OperationDataTable.AsEnumerable().Where(p => p.Field<string>("MMProductionNormItemNo") == itemNo).FirstOrDefault();
                        if (drow != null &&  drow["IsError"] != null)
                        {
                            int error = 0;
                            if (int.TryParse(drow["IsError"].ToString(), out error))
                            {
                                if (error == 1)
                                {
                                    e.Appearance.BackColor = Color.Red;
                                    e.Appearance.BackColor2 = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SelectedAll(string selectedValue, string columnName)
        {
            if (OperationDataTable != null && OperationDataTable.Rows.Count != 0)
            {
                foreach (DataRow row in OperationDataTable.Rows)
                { 
                  row[columnName] = selectedValue;
                }
            }
        }

        void bandedView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemOperationsController objProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
            MMProductionNormItemOperationsInfo objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();

            objProductionNormsInfo.MMProductionNormOperationStatus = MMProductionNormStatus.Edit.ToString();
            EnableToolbar(ProductionNormConst.ChangestatusOperation);
            BandedGridView view = sender as BandedGridView;
            if (view == null) return;

            if (e.Column.Caption != null)
            {

                objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByName(e.Column.Caption);
                if (e.RowHandle == 0)
                {
                    if (objOperationsInfo.MMOperationID == Convert.ToInt32(e.Column.FieldName))
                    {
                        foreach (MMProductionNormItemsInfo itemProductionNorm in entity.ProductionNormItemList)
                        {
                            if (itemProductionNorm.SubList != null && itemProductionNorm.SubList.Count > 0)
                            {
                                foreach (MMProductionNormItemsInfo item in itemProductionNorm.SubList)
                                {
                                    //item.FK_MMOperationID = objOperationsInfo.MMOperationID;
                                    //Y && Name
                                    SelectedAll(e.Value.ToString(), e.Column.FieldName);

                                }
                            }
                        }
                    }
                    else
                    {

                    }

                }

            }
            entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemList.TreeListControl.ExpandAll();
        }


        public void GenerateGridBandAndColumnByOperation(MMOperationsInfo objOperationsInfo, MMOperationsController objOperationsController, GridBand gridBand, BandedGridView banded)
        {
            List<MMOperationsInfo> operationChildList = objOperationsController.GetAllOperationsByParentID(objOperationsInfo.MMOperationID);

            if (operationChildList != null && operationChildList.Count > 0)
            {
                foreach (MMOperationsInfo item in operationChildList)
                {
                    List<MMOperationsInfo> operationSubChildList = objOperationsController.GetAllOperationsByParentID(item.MMOperationID);
                    if (operationSubChildList != null && operationSubChildList.Count > 0)
                    {
                        GridBand gridBandChild = new GridBand();
                        gridBandChild.Caption = item.MMOperationName;
                        gridBand.Children.Add(gridBandChild);
                        GenerateGridBandAndColumnByOperation(item, objOperationsController, gridBandChild, banded);
                    }
                    else
                    {
                        CreateBandedColumnOperation(item.MMOperationName, item.MMOperationID.ToString(), true, true, gridBand, banded);
                        OperationDataTable.Columns.Add(item.MMOperationID.ToString());
                    }
                }
            }
            // Defualt add parent operation col to The End Band
            CreateBandedColumnOperation(objOperationsInfo.MMOperationName, objOperationsInfo.MMOperationID.ToString(), true, true, gridBand, banded);
            OperationDataTable.Columns.Add(objOperationsInfo.MMOperationID.ToString());
        }
        public void InitOperationDataRow(List<MMProductionNormItemOperationsInfo> operationList)
        {
            if (OperationDataTable == null)
            {
                OperationDataTable = new DataTable();
            }

            OperationDataTable.Rows.Clear();

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (objProductionNormsInfo.FK_ICProductID > 0)
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            //Add parent product
            if (objProductsInfo != null && objProductsInfo.ICProductID > 0)
            {
                //null row
                DataRow nullRow = OperationDataTable.NewRow();
                nullRow["MMProductionNormItemNo"] = null;
                nullRow["FK_MMProductionNormItemID"] = null;
                nullRow["FK_MMProductionNormID"] = null;
                nullRow["MMProductionNormItemProductName"] = null;
                nullRow["FK_ICProductID"] = null;
                ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeWoodTypeID);
                if (objProductAttributesInfo != null)
                    nullRow["MMProductionNormItemProductWoodType"] = null;

                nullRow["MMProductionNormItemIsComponent"] = null;

                OperationDataTable.Rows.Add(nullRow);
                //
                DataRow parentRow = OperationDataTable.NewRow();
                parentRow["MMProductionNormItemNo"] = objProductsInfo.ICProductNo;
                parentRow["FK_MMProductionNormItemID"] = 0;
                parentRow["FK_MMProductionNormID"] = objProductionNormsInfo.MMProductionNormID;
                parentRow["MMProductionNormItemProductName"] = objProductsInfo.ICProductName;
                parentRow["FK_ICProductID"] = objProductsInfo.ICProductID;
                if (objProductAttributesInfo != null)
                    parentRow["MMProductionNormItemProductWoodType"] = objProductAttributesInfo.ICProductAttributeValue;

                parentRow["MMProductionNormItemIsComponent"] = 0;
                parentRow["IsError"] = 0;
                OperationDataTable.Rows.Add(parentRow);
            }
            foreach (MMProductionNormItemsInfo productionNormItem in entity.ProductionNormItemList)
            {
                DataRow row = OperationDataTable.NewRow();

                row["MMProductionNormItemNo"] = productionNormItem.MMProductionNormItemNo;
                row["FK_MMProductionNormItemID"] = productionNormItem.MMProductionNormItemID;
                row["FK_MMProductionNormID"] = objProductionNormsInfo.MMProductionNormID;
                row["MMProductionNormItemProductName"] = productionNormItem.MMProductionNormItemProductName;
                row["FK_ICProductID"] = productionNormItem.FK_ICProductID;
                row["MMProductionNormItemProductWoodType"] = productionNormItem.MMProductionNormItemProductWoodType;
                row["MMProductionNormItemIsComponent"] = productionNormItem.MMProductionNormItemIsComponent;
                row["IsError"] = 0;
                MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(productionNormItem.MMProductionNormItemID);
                if (objProductionNormItemsInfo != null)
                {
                    ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
                    if (objAttributesInfo != null)
                    {
                        row["FK_ICProductAttributeSpecialityID"] = objAttributesInfo.ICProductAttributeValue;
                    }
                    row["MMProductionNormItemIsComponent"] = objProductionNormItemsInfo.MMProductionNormItemIsComponent;

                }
                OperationDataTable.Rows.Add(row);

                if (productionNormItem.SubList != null && productionNormItem.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo item in productionNormItem.SubList)
                    {
                        DataRow subRow = OperationDataTable.NewRow();

                        subRow["MMProductionNormItemNo"] = item.MMProductionNormItemNo;
                        subRow["FK_MMProductionNormItemID"] = item.MMProductionNormItemID;
                        subRow["FK_MMProductionNormID"] = objProductionNormsInfo.MMProductionNormID;
                        subRow["MMProductionNormItemProductName"] = item.MMProductionNormItemProductName;
                        subRow["FK_ICProductID"] = item.FK_ICProductID;
                        subRow["MMProductionNormItemProductWoodType"] = item.MMProductionNormItemProductWoodType;
                        subRow["MMProductionNormItemIsComponent"] = item.MMProductionNormItemIsComponent;
                        subRow["IsError"] = 0;
                        MMProductionNormItemsInfo objProductionNormSubItemsInfo = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(item.MMProductionNormItemID);
                        if (objProductionNormSubItemsInfo != null)
                        {
                            ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductionNormSubItemsInfo.FK_ICProductAttributeSpecialityID);
                            if (objAttributesInfo != null)
                            {
                                subRow["FK_ICProductAttributeSpecialityID"] = objAttributesInfo.ICProductAttributeValue;
                            }
                            subRow["MMProductionNormItemIsComponent"] = objProductionNormSubItemsInfo.MMProductionNormItemIsComponent;
                        }

                        OperationDataTable.Rows.Add(subRow);

                    }
                }
            }

            foreach (DataRow row in OperationDataTable.Rows)
            {
                foreach (int id in OperationIDList)
                {
                    if (row[id.ToString()] != null)
                    {
                        row[id.ToString()] = "N";
                    }
                }
                int productionNormItemID = 0;
                if (int.TryParse(row["FK_MMProductionNormItemID"].ToString(), out productionNormItemID))
                {
                    for (int i = 0; i < operationList.Count; i++)
                    {
                        if (operationList[i].FK_MMProductionNormItemID == productionNormItemID)
                        {
                            if (OperationDataTable.Columns.Contains(operationList[i].FK_MMOperationID.ToString()) && row[operationList[i].FK_MMOperationID.ToString()] != null)
                            {
                                row[operationList[i].FK_MMOperationID.ToString()] = "Y";
                            }
                            operationList.RemoveAt(i--);
                        }

                    }
                }
            }
        }

        public void CreateBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.Fixed = FixedStyle.Left;
            column.MinWidth = 75;
            banded.Columns.Add(column);
        }
        public void CreateReposityBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            
            column.OwnerBand = ownerBand;
            column.Fixed = FixedStyle.Left;
            RepositoryItemHyperLinkEdit ViewDetail = new RepositoryItemHyperLinkEdit();
            ViewDetail.NullText = ProductionNormLocalizeResources.ViewRouting;
            column.ColumnEdit = ViewDetail;
            column.OptionsColumn.AllowEdit = false;
            column.MinWidth = 75;
            banded.Columns.Add(column);
        }

        public void ViewDetail_Click(object sender)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemOperationsController objProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
            BandedGridView view = sender as BandedGridView;
            if (view.FocusedRowHandle > 0)
            {
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                if (row != null)
                {
                    
                    if (row["FK_MMProductionNormItemID"] != null)
                    {
                        int MMProductionNormItemID = 0;
                        if (int.TryParse(row["FK_MMProductionNormItemID"].ToString(), out MMProductionNormItemID))
                        {
                            // Chi tiết là DM sản phẩm
                            int productID = 0;
                            int.TryParse(row["FK_ICProductID"].ToString(), out productID);
                            MMProductionNormItemOperationsInfo objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
                            if (MMProductionNormItemID == 0 && productID > 0)
                            {
                                int productionNormID = 0;
                                int.TryParse(row["FK_MMProductionNormID"].ToString(), out productionNormID);

                                objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = 0;
                                objProductionNormItemOperationsInfo.FK_MMProductionNormID = productionNormID;
                            }
                            else
                            {
                                foreach (MMProductionNormItemsInfo itemProductionNorm in entity.ProductionNormItemList)
                                {
                                    if (itemProductionNorm.MMProductionNormItemID == MMProductionNormItemID)
                                    {
                                        objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = itemProductionNorm.MMProductionNormItemID;
                                        objProductionNormItemOperationsInfo.FK_ICProductAttributeSpecialityID = itemProductionNorm.FK_ICProductAttributeSpecialityID;
                                        objProductionNormItemOperationsInfo.FK_MMProductionNormID = itemProductionNorm.FK_MMProductionNormID;
                                        break;
                                    }
                                    if(itemProductionNorm.SubList != null)
                                    {
                                        foreach (MMProductionNormItemsInfo item in itemProductionNorm.SubList)
                                        {
                                            if (item.MMProductionNormItemID == MMProductionNormItemID)
                                            {
                                                objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = item.MMProductionNormItemID;
                                                objProductionNormItemOperationsInfo.FK_ICProductAttributeSpecialityID = item.FK_ICProductAttributeSpecialityID;
                                                objProductionNormItemOperationsInfo.FK_MMProductionNormID = item.FK_MMProductionNormID;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }


                            if (objProductionNormItemOperationsInfo != null && productID > 0)
                            {
                                if (Toolbar.IsNullOrNoneAction())
                                {
                                    List<MMProductionNormItemOperationsInfo> listOperation = objProductionNormItemOperationsController.GetOperationsByProductionNorm(
                                        objProductionNormItemOperationsInfo.FK_MMProductionNormID,
                                        objProductionNormItemOperationsInfo.FK_MMProductionNormItemID);
                                    guiProductionNormProcessInfos guiForm = new guiProductionNormProcessInfos(objProductionNormItemOperationsInfo, listOperation);
                                    guiForm.Text = "Quy trình sản xuất chi tiết";
                                    guiForm.Module = this;
                                    guiForm.ShowDialog();
                                    if (row["IsError"] != null)
                                    {
                                        row["IsError"] = guiForm.IsError;
                                    }
                                }
                                else
                                    MessageBox.Show(ProductionNormLocalizeResources.PleaseSaveOperationBeforeUpdateDetail, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
        }
        public void CreateBandedColumnOperation(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            if (ownerBand != null)
            {
                column.OwnerBand = ownerBand;
            }
            column.MinWidth = 100;
            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectnew = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            column.ColumnEdit = selectnew;
            selectnew.NullText = "";
            selectnew.ValueChecked = "Y";
            selectnew.ValueUnchecked = "N";
            selectnew.ValueGrayed = "-";
            banded.Columns.Add(column);
            
            int id = 0;
            if (int.TryParse(fieldName, out id))
            {
                OperationIDList.Add(id);
            }
        }

        public void EnableApproved(BOSButton button)
        {
            button.Enabled = false;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo productionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (productionNormsInfo != null)
            {
                if (productionNormsInfo.MMProductionNormOperationStatus == ProductionNormOperationStatus.New.ToString())
                {
                    button.Enabled = true;
                }
            }
        }

        public void SaveProductionNormOperationByProductWoodApproved()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo productionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributeItemsController objProductAttributeItemsController = new ICProductAttributeItemsController();
            MMProductionNormItemOperationsController objProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
            MMProductionNormItemOperationsInfo objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
            List<ICProductAttributeItemsInfo> productAttributeItemsInfoList = objProductAttributeItemsController.GetAllObjectList();
            List<MMProductionNormItemOperationsInfo> productionNormItemOperationsList = 
                objProductionNormItemOperationsController.GetProductionNormItemOperationsByProductionNormID(productionNormsInfo.MMProductionNormID);

            if (productionNormsInfo.MMProductionNormWoodStatus == ProductionNormOperationStatus.New.ToString())
            {
                MessageBox.Show("Sản phẩm chưa kiểm/duyệt BTP, không thể cập nhật công đoạn"
                                           , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productionNormsInfo.MMProductionNormOperationStatus != ProductionNormOperationStatus.Approved.ToString())
            {
                ///
                bool isCancel = false;

                DialogResult dlgResult = MessageBox.Show("Cập nhật cấu hình sẽ thay đổi công đoạn và chi tiết đang chọn:"
                                           + Environment.NewLine + "Yes: Thay đổi tất cả theo cấu hình"
                                           + Environment.NewLine + "No: Cập nhật dữ liệu mới từ cấu hình "
                                           + Environment.NewLine + "Cancel: không cập nhật và Thoát."
                                           , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Cancel)
                {
                    BOSProgressBar.Close();
                    return;
                }
                else if (dlgResult == DialogResult.No)
                {
                    isCancel = true;
                }
                else
                {
                    isCancel = false;
                }

                int percent = 0;
                #region Product Operation
                int prodAttribute = 0;
                List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
                if (productAttribute != null)
                {
                    foreach (ICProductAttributesInfo item in productAttribute)
                    {
                        if (item.FK_ICProductGroupID > 0)
                        {
                            prodAttribute = item.ICProductAttributeID;
                            break;
                        }
                    }
                }

                List<ICProductAttributeItemsInfo> prodAttributeList = productAttributeItemsInfoList.Where(x => x.FK_ICProductAttributeID == prodAttribute).ToList();
                List<MMProductionNormItemOperationsInfo> itemProdOperationList = productionNormItemOperationsList.Where(x => x.FK_MMProductionNormItemID == 0).ToList();
                //Insert Into
                foreach (ICProductAttributeItemsInfo itemProductAttribute in prodAttributeList)
                {
                    objProductionNormItemOperationsInfo = itemProdOperationList.Where(x => x.FK_MMOperationID == itemProductAttribute.FK_MMOperationID).FirstOrDefault();
                    if (objProductionNormItemOperationsInfo != null)
                    {
                        entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                        //Update OperationConfig Process 
                        UpdateOperationDetailProcessBy(objProductionNormItemOperationsInfo.FK_MMProductionNormItemID
                                                       , objProductionNormItemOperationsInfo.MMProductionNormItemOperationID
                                                       , prodAttribute
                                                       , objProductionNormItemOperationsInfo.FK_MMOperationID);
                    }
                    else
                    {
                        objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
                        objProductionNormItemOperationsInfo.FK_MMProductionNormID = productionNormsInfo.MMProductionNormID;
                        objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = 0;
                        objProductionNormItemOperationsInfo.FK_MMOperationID = itemProductAttribute.FK_MMOperationID;
                        objProductionNormItemOperationsInfo.FK_ICProductID = productionNormsInfo.FK_ICProductID;
                        entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                        int ProductionNormItemOperationID = objProductionNormItemOperationsController.CreateObject(objProductionNormItemOperationsInfo);
                        //Insert config process detail
                        if (ProductionNormItemOperationID > 0)
                        {
                            objProductionNormProcessInfosController.InsertOperationConfigProcess(0
                                                                                        , ProductionNormItemOperationID
                                                                                        , prodAttribute
                                                                                        , itemProductAttribute.FK_MMOperationID
                                                                                        , BOSApp.CurrentUsersInfo.ADUserName);
                        }
                    }
                }
                //Delete
                if (!isCancel && prodAttributeList != null)
                {
                    foreach (MMProductionNormItemOperationsInfo itemExit in itemProdOperationList)
                    {
                        ICProductAttributeItemsInfo check = prodAttributeList.Where(x => x.FK_MMOperationID == itemExit.FK_MMOperationID).FirstOrDefault();
                        //Config deteted
                        if (check == null)
                        {
                            itemExit.AAStatus = Status.Delete.ToString();
                            itemExit.AAUpdatedDate = DateTime.Now;
                            itemExit.AAUpdatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                            objProductionNormItemOperationsController.UpdateObject(itemExit);
                            DeleteOperationDetailProcess(itemExit.MMProductionNormItemOperationID);
                        }
                    }
                }
                #endregion

                foreach (MMProductionNormItemsInfo itemProductionNorm in entity.ProductionNormItemList)
                {
                    percent++;
                    double pct = (percent * 100) / entity.ProductionNormItemList.Count;
                    BOSProgressBar.Start("Đang cập nhật: " + Math.Round(pct) + " % ");

                    #region Component
                    List<ICProductAttributeItemsInfo> itemCopProductAttributeList = productAttributeItemsInfoList.Where(x => x.FK_ICProductAttributeID == itemProductionNorm.FK_ICProductAttributeSpecialityID).ToList();
                    List<MMProductionNormItemOperationsInfo> itemCopOperationList = productionNormItemOperationsList.Where(x => x.FK_MMProductionNormItemID == itemProductionNorm.MMProductionNormItemID).ToList();
                    //Insert Into
                    foreach (ICProductAttributeItemsInfo itemProductAttribute in itemCopProductAttributeList)
                    {
                        objProductionNormItemOperationsInfo = itemCopOperationList.Where(x => x.FK_MMOperationID == itemProductAttribute.FK_MMOperationID).FirstOrDefault();
                        if (objProductionNormItemOperationsInfo != null)
                        {
                            entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                            //Update OperationConfig Process 
                            UpdateOperationDetailProcessBy(objProductionNormItemOperationsInfo.FK_MMProductionNormItemID
                                                           , objProductionNormItemOperationsInfo.MMProductionNormItemOperationID
                                                           , itemProductionNorm.FK_ICProductAttributeSpecialityID
                                                           , objProductionNormItemOperationsInfo.FK_MMOperationID);
                        }
                        else
                        {
                            objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
                            objProductionNormItemOperationsInfo.FK_MMProductionNormID = productionNormsInfo.MMProductionNormID;
                            objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = itemProductionNorm.MMProductionNormItemID;
                            objProductionNormItemOperationsInfo.FK_MMOperationID = itemProductAttribute.FK_MMOperationID;
                            objProductionNormItemOperationsInfo.FK_ICProductID = itemProductionNorm.FK_ICProductID;
                            entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                            int ProductionNormItemOperationID = objProductionNormItemOperationsController.CreateObject(objProductionNormItemOperationsInfo);
                            //Insert config process detail
                            if (ProductionNormItemOperationID > 0)
                            {
                                objProductionNormProcessInfosController.InsertOperationConfigProcess(itemProductionNorm.MMProductionNormItemID
                                                                                            , ProductionNormItemOperationID
                                                                                            , itemProductionNorm.FK_ICProductAttributeSpecialityID
                                                                                            , itemProductAttribute.FK_MMOperationID
                                                                                            , BOSApp.CurrentUsersInfo.ADUserName);
                            }
                        }
                    }
                    //Delete
                    if (!isCancel && itemCopProductAttributeList != null)
                    {
                        foreach (MMProductionNormItemOperationsInfo itemExit in itemCopOperationList)
                        {
                            ICProductAttributeItemsInfo check = itemCopProductAttributeList.Where(x => x.FK_MMOperationID == itemExit.FK_MMOperationID).FirstOrDefault();
                            //Config deteted
                            if (check == null)
                            {
                                itemExit.AAStatus = Status.Delete.ToString();
                                itemExit.AAUpdatedDate = DateTime.Now;
                                itemExit.AAUpdatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                                objProductionNormItemOperationsController.UpdateObject(itemExit);
                                DeleteOperationDetailProcess(itemExit.MMProductionNormItemOperationID);
                            }
                        }
                    }
                    #endregion

                    #region Sub Item
                    foreach (MMProductionNormItemsInfo item in itemProductionNorm.SubList)
                    {
                        List<ICProductAttributeItemsInfo> itemProductAttributeList = productAttributeItemsInfoList.Where(x => x.FK_ICProductAttributeID == item.FK_ICProductAttributeSpecialityID).ToList();
                        List<MMProductionNormItemOperationsInfo> itemProductionNormItemOperationList = productionNormItemOperationsList.Where(x => x.FK_MMProductionNormItemID == item.MMProductionNormItemID).ToList();
                        //Insert Into
                        foreach (ICProductAttributeItemsInfo itemProductAttribute in itemProductAttributeList)
                        {

                            objProductionNormItemOperationsInfo = itemProductionNormItemOperationList.Where(x => x.FK_MMOperationID == itemProductAttribute.FK_MMOperationID).FirstOrDefault();


                            if (objProductionNormItemOperationsInfo != null)
                            {
                                entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                                //Update OperationConfig Process 
                                UpdateOperationDetailProcessBy(objProductionNormItemOperationsInfo.FK_MMProductionNormItemID
                                                               , objProductionNormItemOperationsInfo.MMProductionNormItemOperationID
                                                               , item.FK_ICProductAttributeSpecialityID
                                                               , objProductionNormItemOperationsInfo.FK_MMOperationID);
                            }
                            else
                            {
                                objProductionNormItemOperationsInfo = new MMProductionNormItemOperationsInfo();
                                objProductionNormItemOperationsInfo.FK_MMProductionNormID = productionNormsInfo.MMProductionNormID;
                                objProductionNormItemOperationsInfo.FK_MMProductionNormItemID = item.MMProductionNormItemID;
                                objProductionNormItemOperationsInfo.FK_MMOperationID = itemProductAttribute.FK_MMOperationID;
                                objProductionNormItemOperationsInfo.FK_ICProductID = item.FK_ICProductID;
                                entity.ProductionNormItemOperationList.Add(objProductionNormItemOperationsInfo);
                                int ProductionNormItemOperationID = objProductionNormItemOperationsController.CreateObject(objProductionNormItemOperationsInfo);
                                //Insert config process detail
                                if (ProductionNormItemOperationID > 0)
                                {
                                    objProductionNormProcessInfosController.InsertOperationConfigProcess(item.MMProductionNormItemID
                                                                                                , ProductionNormItemOperationID
                                                                                                , item.FK_ICProductAttributeSpecialityID
                                                                                                , itemProductAttribute.FK_MMOperationID
                                                                                                , BOSApp.CurrentUsersInfo.ADUserName);
                                }
                            }
                        }
                        //Delete
                        if (!isCancel && itemProductAttributeList != null)
                        {
                            foreach (MMProductionNormItemOperationsInfo itemExit in itemProductionNormItemOperationList)
                            {
                                ICProductAttributeItemsInfo check = itemProductAttributeList.Where(x => x.FK_MMOperationID == itemExit.FK_MMOperationID).FirstOrDefault();
                                //Config deteted
                                if (check == null)
                                {
                                    itemExit.AAStatus = Status.Delete.ToString();
                                    itemExit.AAUpdatedDate = DateTime.Now;
                                    itemExit.AAUpdatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                                    objProductionNormItemOperationsController.UpdateObject(itemExit);
                                    DeleteOperationDetailProcess(itemExit.MMProductionNormItemOperationID);
                                }
                            }
                        }

                    }
                    #endregion
                }
                BOSProgressBar.Start("Đang refresh dữ liệu...");
                InvalidateOperationBandedGrid();
                BOSProgressBar.Close();
            }
        }

        public void SaveProductionNormOperation()
        {
            if (ProductionNormItemOperationsGridControl != null)
            {
                MMProductionNormItemOperationsController ProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
                MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
                ProductionNormItemOperationsGridControl.MainView.CloseEditor();
                ProductionNormItemOperationsGridControl.MainView.UpdateCurrentRow();
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo productionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                if (productionNormsInfo != null &&  productionNormsInfo.MMProductionNormWoodStatus != ProductionNormOperationStatus.New.ToString())
                {
                    if (productionNormsInfo.MMProductionNormOperationStatus == MMProductionNormStatus.Edit.ToString())
                    {
                        entity.ProductionNormItemOperationList.Invalidate(productionNormsInfo.MMProductionNormID);
                        foreach (DataRow row in OperationDataTable.Rows)
                        {
                            int itemID = 0;
                            int productID = 0;
                            if (int.TryParse(row["FK_MMProductionNormItemID"].ToString(), out itemID) &&
                                int.TryParse(row["FK_ICProductID"].ToString(), out productID))
                            {
                                // check delete semiProduct
                                bool isDelete = true;
                                if (itemID > 0)
                                {
                                    foreach (MMProductionNormItemsInfo itemProductionNorm in entity.ProductionNormItemList)
                                    {
                                        if (itemProductionNorm.SubList != null && itemProductionNorm.SubList.Count > 0)
                                        {
                                            if (itemProductionNorm.SubList.Exists("MMProductionNormItemID", itemID))
                                            {
                                                isDelete = false;
                                                break;
                                            }
                                        }

                                        if (itemID == itemProductionNorm.MMProductionNormItemID)
                                        {
                                            isDelete = false;
                                            break;
                                        }

                                    }
                                }
                                else
                                    isDelete = false;
                                if (isDelete) continue;
                                foreach (int id in OperationIDList)
                                {
                                    bool isCheck = false;
                                    if (row[id.ToString()] != null)
                                    {
                                        if (row[id.ToString()].ToString() == "Y")
                                        {
                                            isCheck = true;
                                        }
                                    }
                                    bool isExist = false;
                                    for (int i = 0; i < entity.ProductionNormItemOperationList.Count; i++)
                                    {
                                        if (entity.ProductionNormItemOperationList[i].FK_MMProductionNormItemID == itemID
                                            && entity.ProductionNormItemOperationList[i].FK_ICProductID == productID
                                            && entity.ProductionNormItemOperationList[i].FK_MMOperationID == id)
                                        {
                                            if (!isCheck)
                                            {
                                                entity.ProductionNormItemOperationList[i].AAStatus = Status.Delete.ToString();
                                                entity.ProductionNormItemOperationList[i].AAUpdatedDate = DateTime.Now;
                                                entity.ProductionNormItemOperationList[i].AAUpdatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                                                ProductionNormItemOperationsController.UpdateObject(entity.ProductionNormItemOperationList[i]);
                                                DeleteOperationDetailProcess(entity.ProductionNormItemOperationList[i].MMProductionNormItemOperationID);
                                            }
                                            isExist = true;
                                            break;
                                        }
                                    }
                                    if (!isExist)
                                    {
                                        if (isCheck)
                                        {
                                           
                                            MMProductionNormItemOperationsInfo objOperationsInfo = new MMProductionNormItemOperationsInfo();
                                            objOperationsInfo.FK_MMProductionNormID = productionNormsInfo.MMProductionNormID;
                                            objOperationsInfo.FK_MMProductionNormItemID = itemID;
                                            objOperationsInfo.FK_MMOperationID = id;
                                            objOperationsInfo.FK_ICProductID = productID;
                                            entity.ProductionNormItemOperationList.Add(objOperationsInfo);
                                            int ProductionNormItemOperationID =  ProductionNormItemOperationsController.CreateObject(objOperationsInfo);

                                            if (ProductionNormItemOperationID > 0)
                                            {
                                                objProductionNormProcessInfosController.InsertItemOperationProcess(itemID
                                                                                                            , ProductionNormItemOperationID
                                                                                                            , id
                                                                                                            , BOSApp.CurrentUsersInfo.ADUserName);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void DeleteOperationDetailProcess(int ProductionNormItemOperationID)
        {
            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
            objProductionNormProcessInfosController.UpdateOperationProcess(ProductionNormItemOperationID, Status.Delete.ToString(), BOSApp.CurrentUsersInfo.ADUserName);
        }
        public bool CheckOperationExit()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo productionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemOperationsController objProductionNormItemOperationsController = new MMProductionNormItemOperationsController();
           
            List<MMProductionNormItemOperationsInfo> productionNormItemOperationsList = objProductionNormItemOperationsController.GetProductionNormItemOperationsByProductionNormID(productionNormsInfo.MMProductionNormID);
            bool result = true;
            string mess = string.Empty;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                List<MMProductionNormItemOperationsInfo> itemProductionNormItemOperationList = productionNormItemOperationsList.Where(x => x.FK_MMProductionNormItemID == item.MMProductionNormItemID).ToList();
                if (itemProductionNormItemOperationList == null || itemProductionNormItemOperationList.Count == 0)
                {
                    result = false;
                    mess += Environment.NewLine + item.MMProductionNormItemNo;
                }
            }
            if (mess != string.Empty)
            {
                MessageBox.Show("Các chi tiết chưa chọn công đoạn:" + mess
                                      , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        public bool CheckProcessPeriod()
        {
            bool result = true;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where( x => x.ICProductID == objProductionNormsInfo.FK_ICProductID).FirstOrDefault();

            List<MMProductionNormProcessInfosInfo> listProcess = objProductionNormProcessInfosController.GetProcessByProductionNorm(objProductionNormsInfo.MMProductionNormID);
            if (listProcess == null || listProcess.Count == 0)
            {
                result = false;
                MessageBox.Show("Các chi tiết chưa có thứ tự công đoạn sản xuất!"
                                     , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            else
            {
                List<MMProductionNormProcessInfosInfo> listZeroProcess = listProcess.Where(x => x.MMProductionNormProcessInfoPeriod == 0).ToList();

                if (listZeroProcess != null && listZeroProcess.Count > 0)
                {
                    List<string> item = new List<string>();
                    item = listZeroProcess.Select(x => x.MMProductionNormItemNo).Distinct().ToList();
                    if (item != null)
                    {
                        //item.ForEach(x => { if ((x == string.Empty || x == null) && objProductsInfo != null) x = objProductsInfo.ICProductNo; });
                        foreach (string value in item)
                        {
                            string check = value;
                            if (value == null || value == string.Empty)
                            {
                                if (objProductsInfo != null)
                                    check = objProductsInfo.ICProductNo;
                            }
                            DataRow drow = OperationDataTable.AsEnumerable().Where(p => p.Field<string>("MMProductionNormItemNo") == check).FirstOrDefault();
                            if (drow != null)
                                drow["IsError"] = 1;
                        }
                       
                        result = false;
                        MessageBox.Show("Tồn tại chi tiết có thứ tự sản xuất công đoạn bằng 0"
                                         , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return result;
                    }
                }

                List<string> itemNoDulicate = new List<string>();
                List<string> itemDulicate = new List<string>();
                itemDulicate = listProcess.Select(x => x.MMProductionNormItemNo).Distinct().ToList();
                //itemDulicate.ForEach(x => { if ((x == string.Empty || x == null) && objProductsInfo != null) x = objProductsInfo.ICProductNo; });
                foreach (string item in itemDulicate)
                {
                     List<MMProductionNormProcessInfosInfo> listProcessDuliacte = listProcess.Where(x => x.MMProductionNormItemNo == item).ToList();
                    if(listProcessDuliacte != null && listProcessDuliacte.Count > 0)
                    {
                        if (listProcessDuliacte.GroupBy(n => n.MMProductionNormProcessInfoPeriod).Any(c => c.Count() > 1))
                        {
                            itemNoDulicate.Add(item);
                            string check = item;
                            if (item == null || item == string.Empty)
                            {
                                if (objProductsInfo != null)
                                    check = objProductsInfo.ICProductNo;
                            }
                            DataRow drow = OperationDataTable.AsEnumerable().Where(p => p.Field<string>("MMProductionNormItemNo") == check).FirstOrDefault();
                            if (drow != null)
                                drow["IsError"] = 1;
                        }
                    }
                }
                if (itemNoDulicate != null && itemNoDulicate.Count > 0)
                {
                    result = false;
                    MessageBox.Show("Tồn tại chi tiết có thứ tự sản xuất công đoạn trùng."
                                     , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
            }

            return result;
        }
        public void UpdateOperationDetailProcessBy(int ProductionNormItemID, int ProductionNormItemOperationID, int ProductAttributeSpecialityID, int OperationID)
        {

            MMProductionNormProcessInfosController objProductionNormProcessInfosController = new MMProductionNormProcessInfosController();
            //Delete old process
            objProductionNormProcessInfosController.UpdateOperationProcess(ProductionNormItemOperationID, Status.Delete.ToString(), BOSApp.CurrentUsersInfo.ADUserName);
            objProductionNormProcessInfosController.InsertItemOperationSpecialityProcess(ProductionNormItemID
                                                                               , ProductionNormItemOperationID
                                                                               , OperationID
                                                                               , ProductAttributeSpecialityID
                                                                               , BOSApp.CurrentUsersInfo.ADUserName);
        }
        public void ApproveOperation()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo productionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            productionNormsInfo.MMProductionNormOperationStatus = ProductionNormOperationStatus.Approved.ToString();
            productionNormsInfo.MMProductionNormOperationApproveDate = DateTime.Now;
            productionNormsInfo.FK_HREmployeeOperationApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            entity.UpdateMainObject();
        }

    }
}
