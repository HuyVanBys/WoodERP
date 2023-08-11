using System.Windows.Forms;

namespace BOSLib
{
    public interface IBOSScreen
    {
        void InitializeScreen();
        void InitializeControls();
        Control InitializeControl(STFieldsInfo objSTFieldInfo, int iLanguageID);
        bool IsDataMainScreen();
        bool IsSearchMainScreen();
        bool IsSearchResultsScreen();
        bool IsDataSubScreen();
    }
}
