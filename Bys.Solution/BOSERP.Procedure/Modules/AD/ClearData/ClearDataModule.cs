using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOSERP.Modules.ClearData
{
    public class ClearDataModule : BaseModuleERP
    {
        #region Constant
        #endregion

        #region Private Variables
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ClearDataModule()
        {
            Name = "ClearData";
            CurrentModuleEntity = new ClearDataEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InvalidateModuleClearDataList();
        }
        #endregion
        public void InvalidateModuleClearDataList()
        {
            ClearDataEntities entity = (ClearDataEntities)CurrentModuleEntity;
            STModuleClearDatasController objModuleClearDatasController = new STModuleClearDatasController();
            DataSet dsModuleDatas = objModuleClearDatasController.GetAllObjects();
            entity.ClearDataList.Invalidate(dsModuleDatas);
        }
        public void DeleteItemFromModulePostingList()
        {
            ClearDataEntities entity = (ClearDataEntities)CurrentModuleEntity;
            if (entity.ClearDataList.CurrentIndex < 0)
                return;
            entity.ClearDataList.RemoveSelectedRowObjectFromList();
        }
        public void SaveSTModulePostingList()
        {
            ClearDataEntities entity = (ClearDataEntities)CurrentModuleEntity;
            entity.ClearDataList.EndCurrentEdit();
            entity.ClearDataList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ClearData(STModuleClearDatasInfo item)
        {
            if (string.IsNullOrWhiteSpace(item.STModuleClearDataFunction))
            {
                MessageBox.Show("Không thể thực hiện việc xoá dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            STModuleClearDatasController controller = new STModuleClearDatasController();
            try
            {
                if (controller.STModuleClearDataFunction(item.STModuleClearDataFunction))
                {
                    MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                throw new Exception("Xoá dữ liệu không thành công. Vui lòng thử lại hoặc kiểm tra lại cấu trúc");
            }
        }
    }
}
