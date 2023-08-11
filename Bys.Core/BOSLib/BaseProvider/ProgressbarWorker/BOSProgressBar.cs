using System;
using System.Threading;
using System.Windows.Forms;

namespace BOSLib
{
    public enum ProgressStatus { InProgress = 1, Complete = 2 };

    public class ProgressEventArgs : EventArgs
    {
        private ProgressStatus _status;

        public ProgressStatus Status
        {
            get
            {
                return _status;
            }
        }

        public ProgressEventArgs(ProgressStatus status)
        {
            _status = status;
        }
    }

    public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);

    public class BOSProgressBar
    {
        private static Thread BOSProgressThread;
        private static BysWaitingDialog _waitingDialog = null;
        public static string BOSText = "";

        public static void Start(string startString)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_waitingDialog == null)
                _waitingDialog = new BysWaitingDialog();

            _waitingDialog.Start("Vui lòng đợi", startString + "...");
            Application.DoEvents();
        }

        public static void Start()
        {
            _waitingDialog.Start("Vui lòng đợi", "");
        }

        public static void SetDescription(string strText)
        {
            if (_waitingDialog != null)
                _waitingDialog.SetDescription(strText + "...");
        }

        public static void Close()
        {
            Cursor.Current = Cursors.Default;
            try
            {
                if (_waitingDialog != null)
                    _waitingDialog.Close();
            }
            catch (Exception e) { }
            Cursor.Current = Cursors.Default;
        }
    }
}
