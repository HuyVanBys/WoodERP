using System;

namespace BOSERP.Modules.Container.UI
{
    /// <summary>
    /// Summary description for DMPT100
    /// </summary>
    public partial class DMCC100 : BOSERPScreen
    {

        public DMCC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtGEContainerLenght_Validated(object sender, EventArgs e)
        {
            ((ContainerModule)Module).CalculationQuantity();
        }
        private void fld_txtGEContainerHeight_Validated(object sender, EventArgs e)
        {
            ((ContainerModule)Module).CalculationQuantity();
        }

        private void fld_txtGEContainerWidth_Validated_1(object sender, EventArgs e)
        {
            ((ContainerModule)Module).CalculationQuantity();
        }

    }
}
