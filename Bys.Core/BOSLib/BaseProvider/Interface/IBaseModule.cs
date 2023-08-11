using System;

namespace BOSLib
{
    public interface IBaseModule
    {
        int ModuleID { get; }
        String Name { get; set; }
        String Code { get; set; }

        void InitializeScreens();
        BOSScreen InitializeScreen(String strScreenName, String strScreenNumber);
        void Show();
        void ShowScreen(BOSScreen scr, bool isChild);
        void Close();
        BOSScreen GetDataMainScreen();
        BOSScreen GetSearchMainScreen();
        BOSScreen GetDataSubScreen();
        BOSScreen GetSearchResultScreen();
        bool RefreshData();
        void ReInitializeFieldFormat(int CurrencyID);
    }
}
