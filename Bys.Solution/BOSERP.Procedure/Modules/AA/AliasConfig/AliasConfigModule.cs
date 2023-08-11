using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.AliasConfig
{
    public class AliasConfigModule : BaseModuleERP
    {
        public const string TableNameTextBoxControlName = "fld_txtTableName";
        public const string FieldFormatsGridControlName = "fld_dgcSTFieldFormatsGridControls";

        public BOSTextBox TableNameTextBox;
        public STFieldFormatsGridControl FieldFormatsGridControl;
        public AliasConfigModule()
        {
            Name = "AliasConfig";
            CurrentModuleEntity = new AliasConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            TableNameTextBox = (BOSTextBox)Controls[AliasConfigModule.TableNameTextBoxControlName];
            FieldFormatsGridControl = (STFieldFormatsGridControl)Controls[FieldFormatsGridControlName];
            GetCurrencyInfo();
            GetDeparmentFormatInfo();
        }

        public void SaveItem()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            if (entity.ColumnAliasList.CurrentIndex < 0)
                return;

            AAColumnAliasInfo objColumnAliasInfo = entity.ColumnAliasList[entity.ColumnAliasList.CurrentIndex];

            if (String.IsNullOrEmpty(objColumnAliasInfo.AATableName.Trim())
                || String.IsNullOrEmpty(objColumnAliasInfo.AAColumnAliasName.Trim())
                || String.IsNullOrEmpty(objColumnAliasInfo.AAColumnAliasCaption.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AAColumnAliasController controller = new AAColumnAliasController();
            if (objColumnAliasInfo.Id > 0)
                controller.UpdateObject(objColumnAliasInfo);
            else
                controller.CreateObject(objColumnAliasInfo);

            MessageBox.Show("Lưu thành công !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteItem()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            if (entity.ColumnAliasList.CurrentIndex < 0)
                return;
            AAColumnAliasInfo objColumnAliasInfo = entity.ColumnAliasList[entity.ColumnAliasList.CurrentIndex];
            AAColumnAliasController controller = new AAColumnAliasController();
            controller.DeleteObject(objColumnAliasInfo.Id);

            entity.ColumnAliasList.RemoveSelectedRowObjectFromList();
            MessageBox.Show("Xóa thành công !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Search()
        {
            string tableName = TableNameTextBox.EditValue != null ? TableNameTextBox.EditValue.ToString().Trim() : string.Empty;
            if (String.IsNullOrEmpty(tableName))
                return;
            AAColumnAliasController controler = new AAColumnAliasController();
            DataSet dsResults = controler.GetAAColumnAliasByTableName(tableName);

            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.ColumnAliasList.Invalidate(dsResults);
            dsResults.Dispose();
        }
        public void GetCurrencyInfo()
        {
            GECurrenciesController controler = new GECurrenciesController();
            DataSet dsResults = controler.GetAllObjects();

            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            if (entity.CurrencyList.GridControl != null)
                entity.CurrencyList.Invalidate(dsResults);
            dsResults.Dispose();
        }
        public void GetDeparmentFormatInfo()
        {
            ICDepartmentFormatsController controler = new ICDepartmentFormatsController();
            DataSet dsResults = controler.GetAllObjects();

            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            if (entity.DepartmentFormatList.GridControl != null)
                entity.DepartmentFormatList.Invalidate(dsResults);
            dsResults.Dispose();
        }

        public void GetFormatTable(string tableName, string moduleName)
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            STFieldFormatsController objFieldFormatsController = new STFieldFormatsController();
            List<STFieldFormatsInfo> formatList = objFieldFormatsController.GetFieldFormatForConfig(moduleName, tableName);
            entity.FieldFormatList.SetDefaultListAndRefreshGridControl();
            entity.FieldFormatList.Invalidate(formatList);
            if (FieldFormatsGridControl != null)
            {
                FieldFormatsGridControl.CurrentTableFilter = tableName;
            }
        }

        public void DeleteFeildFormatItem()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.FieldFormatList.RemoveSelectedRowObjectFromList();
        }

        public void SaveSaveFieldFormat()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.FieldFormatList.SaveItemCDObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveAliasConfig()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.ColumnAliasList.SaveItemCDObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveCurrencyConfig()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.CurrencyList.SaveItemCDObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveDepartmentFormatConfig()
        {
            AliasConfigEntities entity = (AliasConfigEntities)CurrentModuleEntity;
            entity.DepartmentFormatList.SaveItemCDObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
