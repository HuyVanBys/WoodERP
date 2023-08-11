using System;

namespace BOSERP.Modules.HRLabouringConfig
{
    public class HRLabouringConfigModule : BaseModuleERP
    {
        public HRLabouringConfigModule()
        {
            Name = "HRLabouringConfig";
            CurrentModuleEntity = new HRLabouringConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        public override int ActionSave()
        {
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)CurrentModuleEntity;
            HRLabouringConfigsInfo obj = (HRLabouringConfigsInfo)entity.MainObject;

            return base.ActionSave();
        }
        /// <summary>
        /// Add employee to the current overtime list
        /// </summary>
        public void ChangeLabouringConfigDate(DateTime date)
        {
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)CurrentModuleEntity;
            HRLabouringConfigsInfo obj = (HRLabouringConfigsInfo)entity.MainObject;
            obj.HRLabouringConfigDate = date;
            //entity.UpdateMainObjectBindingSource();

        }
        public override void ActionEdit()
        {
            base.ActionEdit();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        /// <summary>
        /// Remove the selected employee from the current overtime list
        /// </summary>
        public void RemoveLabouringConfigItemList()
        {
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)CurrentModuleEntity;
            entity.HRLabouringConfigItemList.RemoveSelectedRowObjectFromList();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            //((BOSTextBox)this.Controls["fld_txtHRLabouringConfigFromDate"]).Text = "00:00";
            //((BOSTextBox)this.Controls["fld_txtHRLabouringConfigToDate"]).Text = "00:00";
        }
        public override void ActionDuplicate()
        {
            base.ActionDuplicate();
            HRLabouringConfigEntities entity = (HRLabouringConfigEntities)CurrentModuleEntity;
            HRLabouringConfigsInfo obj = (HRLabouringConfigsInfo)entity.MainObject;
            obj.HRLabouringConfigDate = DateTime.Now;
        }
    }
}
