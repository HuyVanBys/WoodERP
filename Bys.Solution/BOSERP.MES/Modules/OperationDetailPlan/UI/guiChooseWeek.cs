using BOSComponent;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiChooseWeek : BOSERPScreen
    {
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public string PlanWeek { get; set; }
        public guiChooseWeek()
        {
            InitializeComponent();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseWeek_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            if (PlanWeek != string.Empty)
            {
                BOSGridView view = fld_dgcChooseWeekGridControls.MainView as BOSGridView;
                MMOperationDetailPlansInfo item = entity.ListWeek.Where(o => o.MMOperationDetailPlanWeek == PlanWeek).FirstOrDefault();
                if (item != null)
                {
                    int index = entity.ListWeek.IndexOf(item);

                    view.FocusedRowHandle = index;
                    view.TopRowIndex = index;
                }

            }
        }
        public void ChooseWeek(MMOperationDetailPlansInfo chooseItem)
        {
            Fromdate = chooseItem.MMOperationDetailPlanFromDate;
            Todate = chooseItem.MMOperationDetailPlanToDate;
            PlanWeek = chooseItem.MMOperationDetailPlanWeek;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
