using System;
using System.Data;

namespace BOSLib
{
    #region STFieldTextsInfo
    /// <summary>
    /// This object represents the properties and methods of a STFieldTexts.
    /// </summary>
    public class STFieldTextsInfo : BusinessObject
    {

        protected int _sTFieldTextID;
        protected int _sTFieldID;
        protected int _sTLanguageID;
        protected string _sTFieldTextText = String.Empty;
        protected string _sTFieldTextHint = String.Empty;

        public STFieldTextsInfo()
        {
        }
        public STFieldTextsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STFieldTextID":
                            this.STFieldTextID = Convert.ToInt32(value);
                            break;
                        case "STFieldID":
                            this.STFieldID = Convert.ToInt32(value);
                            break;
                        case "STLanguageID":
                            this.STLanguageID = Convert.ToInt32(value);
                            break;
                        case "STFieldTextText":
                            this.STFieldTextText = Convert.ToString(value);
                            break;
                        case "STFieldTextHint":
                            this.STFieldTextHint = Convert.ToString(value);
                            break;
                        case "AllowPropertyChangedEvent":
                            this.AllowPropertyChangedEvent = Convert.ToBoolean(value);
                            break;
                        case "Position":
                            this.Position = Convert.ToInt32(value);
                            break;
                        case "RelatedPosition":
                            this.RelatedPosition = Convert.ToInt32(value);
                            break;
                        case "Selected":
                            this.Selected = Convert.ToBoolean(value);
                            break;
                        case "TheNumberOfChild":
                            this.TheNumberOfChild = Convert.ToInt32(value);
                            break;
                        default:
                            break;
                    }

                }

            }
        }


        public STFieldTextsInfo(int iSTFieldID, int iSTLanguageID, string strSTFieldTextText, string strSTFieldTextHint)
        {
            STFieldID = iSTFieldID;
            STLanguageID = iSTLanguageID;
            STFieldTextText = strSTFieldTextText;
            STFieldTextHint = strSTFieldTextHint;
        }

        #region Public Properties
        public int STFieldTextID
        {
            get { return _sTFieldTextID; }
            set
            {
                if (value != this._sTFieldTextID)
                {
                    _sTFieldTextID = value;
                    NotifyChanged("STFieldTextID");
                }
            }
        }

        public int STFieldID
        {
            get { return _sTFieldID; }
            set
            {
                if (value != this._sTFieldID)
                {
                    _sTFieldID = value;
                    NotifyChanged("STFieldID");
                }
            }
        }

        public int STLanguageID
        {
            get { return _sTLanguageID; }
            set
            {
                if (value != this._sTLanguageID)
                {
                    _sTLanguageID = value;
                    NotifyChanged("STLanguageID");
                }
            }
        }

        public string STFieldTextText
        {
            get { return _sTFieldTextText; }
            set
            {
                if (value != this._sTFieldTextText)
                {
                    _sTFieldTextText = value;
                    NotifyChanged("STFieldTextText");
                }
            }
        }

        public string STFieldTextHint
        {
            get { return _sTFieldTextHint; }
            set
            {
                if (value != this._sTFieldTextHint)
                {
                    _sTFieldTextHint = value;
                    NotifyChanged("STFieldTextHint");
                }
            }
        }
        #endregion
    }
    #endregion
}
