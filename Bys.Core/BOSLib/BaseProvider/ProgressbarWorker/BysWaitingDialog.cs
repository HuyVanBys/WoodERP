using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace BOSLib
{
    public class BysWaitingDialog
    {
        private guiWaitingDialog GuiWaitingDialog { get; set; }
        public String Caption { get; set; } = "Vui lòng đợi";
        public String Description { get; set; } = "Loading Data. Please waiting...";

        public bool IsShow = false;

        public void ShowDialog()
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(guiWaitingDialog), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription(Caption);
                SplashScreenManager.Default.SetWaitFormCaption(Description);
                IsShow = true;
            }
            catch (Exception)
            {

            }
        }

        public void HideDialog()
        {
            try
            {
                SplashScreenManager.CloseForm(false);
                IsShow = false;
            }
            catch (Exception)
            {

            }
        }

        public void Start(String strCaption, String strTitle)
        {
            Caption = strCaption;
            Description = strTitle;
            Show();
        }

        public void Start(String strTitle)
        {
            Caption = "";
            Description = strTitle;
            Show();
        }

        public void Show()
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(guiWaitingDialog), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption(Caption);
                SplashScreenManager.Default.SetWaitFormDescription(Description);
            }
            catch (Exception e) { }

            IsShow = true;
        }

        public void SetDescription(String strDescription)
        {
            if (IsShow)
            {
                SplashScreenManager.Default.SetWaitFormDescription(strDescription);
            }
        }

        public void SetTitle(String strCaption)
        {
            if (IsShow)
            {
                SplashScreenManager.Default.SetWaitFormCaption(strCaption);
            }
        }

        public void Close()
        {
            HideDialog();
        }

        public bool IsWaiting()
        {
            if (SplashScreenManager.Default == null)
                return false;

            return SplashScreenManager.Default.IsSplashFormVisible;
        }
    }
}
