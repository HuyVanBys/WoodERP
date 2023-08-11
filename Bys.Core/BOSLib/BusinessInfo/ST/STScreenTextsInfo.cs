using System;
using System.Data;

namespace BOSLib
{
    #region STScreenTextsInfo
    /// <summary>
    /// This object represents the properties and methods of a STScreenTexts.
    /// </summary>
    public class STScreenTextsInfo : BusinessObject
    {

        protected int _sTScreenTextID;
        protected int _sTScreenID;
        protected int _sTLanguageID;
        protected string _sTScreenTextDesc = DefaultString;

        public STScreenTextsInfo()
        {
        }
        public STScreenTextsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STScreenTextID":
                            this.STScreenTextID = Convert.ToInt32(value);
                            break;
                        case "STScreenID":
                            this.STScreenID = Convert.ToInt32(value);
                            break;
                        case "STLanguageID":
                            this.STLanguageID = Convert.ToInt32(value);
                            break;
                        case "STScreenTextDesc":
                            this.STScreenTextDesc = Convert.ToString(value);
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


        public STScreenTextsInfo(int iSTScreenID, int iSTLanguageID, string strSTScreenTextDesc)
        {
            STScreenID = iSTScreenID;
            STLanguageID = iSTLanguageID;
            STScreenTextDesc = strSTScreenTextDesc;
        }

        #region Public Properties
        public int STScreenTextID
        {
            get { return _sTScreenTextID; }
            set
            {
                if (value != this._sTScreenTextID)
                {
                    _sTScreenTextID = value;
                    NotifyChanged("STScreenTextID");
                }
            }
        }

        public int STScreenID
        {
            get { return _sTScreenID; }
            set
            {
                if (value != this._sTScreenID)
                {
                    _sTScreenID = value;
                    NotifyChanged("STScreenID");
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

        public string STScreenTextDesc
        {
            get { return _sTScreenTextDesc; }
            set
            {
                if (value != this._sTScreenTextDesc)
                {
                    _sTScreenTextDesc = value;
                    NotifyChanged("STScreenTextDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}
