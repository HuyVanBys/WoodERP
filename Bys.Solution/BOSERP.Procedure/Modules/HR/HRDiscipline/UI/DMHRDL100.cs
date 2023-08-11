using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HRDiscipline.UI
{
    /// <summary>
    /// Summary description for DMHRDL100
    /// </summary>
    public partial class DMHRDL100 : BOSERPScreen
    {

        public DMHRDL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }


        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((HRDisciplineModule)Module).AddEmployee();

        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRDisciplineModule)Module).RemoveSelectedItemFromDisciplinesList();
        }

        private void fld_lkeHRDisciplineType_Validated(object sender, EventArgs e)
        {

        }

        private void fld_dteHRDisciplineFromDate_Validated(object sender, EventArgs e)
        {

        }

        private void fld_txtHRDisciplineValue_Validated(object sender, EventArgs e)
        {

        }

        private void fld_txtHRDisciplineValue_TextChanged(object sender, EventArgs e)
        {
            //       double result = 0;
            //  fld_txtHRDisciplineValue.Text = Double.TryParse(fld_txtHRDisciplineValue.Text, out result);
        }

        private void fld_txtHRDisciplineValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            //double isNumber = 0;
            //e.Handled = !double.TryParse(e.KeyChar.ToString(), out isNumber);
            if (char.IsLetter(e.KeyChar) ||
         char.IsSymbol(e.KeyChar) ||
         char.IsWhiteSpace(e.KeyChar) ||
         char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void fld_txtHRDisciplineNumber_Validated(object sender, EventArgs e)
        {
            if (fld_txtHRDisciplineNumber.EditValue != fld_txtHRDisciplineNumber.OldEditValue)
                ((HRDisciplineModule)Module).ChangeDisciplineNumber();
        }
        private void fld_txtHRDisciplineValue_Validated_1(object sender, EventArgs e)
        {
            if (fld_txtHRDisciplineValue.EditValue != fld_txtHRDisciplineValue.OldEditValue)
                ((HRDisciplineModule)Module).ChangeDisciplineValue();
        }
    }
}
