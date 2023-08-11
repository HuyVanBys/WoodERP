using System;
using System.Data;

namespace BOSLib
{
    #region STModuleToolbarButtonCaptionsInfo
    /// <summary>
    /// This object represents the properties and methods of a STModuleToolbarButtonCaptions.
    /// </summary>
    public class STModuleToolbarButtonCaptionsInfo : BusinessObject
    {

        protected int _sTModuleToolbarButtonCaptionID;
        protected int _sTModuleToolbarButtonID;
        protected int _sTLanguageID;
        protected string _sTModuleToolbarButtonCaptionName = String.Empty;
        protected string _sTModuleToolbarButtonDesc = String.Empty;

        public STModuleToolbarButtonCaptionsInfo()
        {
        }
        public STModuleToolbarButtonCaptionsInfo(DataRow row)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                var value = row[item.ColumnName];
                if (value != DBNull.Value)
                {
                    switch (item.ColumnName)
                    {
                        case "STModuleToolbarButtonCaptionID":
                            this.STModuleToolbarButtonCaptionID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarButtonID":
                            this.STModuleToolbarButtonID = Convert.ToInt32(value);
                            break;
                        case "STLanguageID":
                            this.STLanguageID = Convert.ToInt32(value);
                            break;
                        case "STModuleToolbarButtonCaptionName":
                            this.STModuleToolbarButtonCaptionName = Convert.ToString(value);
                            break;
                        case "STModuleToolbarButtonDesc":
                            this.STModuleToolbarButtonDesc = Convert.ToString(value);
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


        public STModuleToolbarButtonCaptionsInfo(int iSTModuleToolbarButtonID, int iSTLanguageID, string strSTModuleToolbarButtonCaptionName, string strSTModuleToolbarButtonDesc)
        {
            STModuleToolbarButtonID = iSTModuleToolbarButtonID;
            STLanguageID = iSTLanguageID;
            STModuleToolbarButtonCaptionName = strSTModuleToolbarButtonCaptionName;
            STModuleToolbarButtonDesc = strSTModuleToolbarButtonDesc;
        }

        #region Public Properties
        public int STModuleToolbarButtonCaptionID
        {
            get { return _sTModuleToolbarButtonCaptionID; }
            set
            {
                if (value != this._sTModuleToolbarButtonCaptionID)
                {
                    _sTModuleToolbarButtonCaptionID = value;
                    NotifyChanged("STModuleToolbarButtonCaptionID");
                }
            }
        }

        public int STModuleToolbarButtonID
        {
            get { return _sTModuleToolbarButtonID; }
            set
            {
                if (value != this._sTModuleToolbarButtonID)
                {
                    _sTModuleToolbarButtonID = value;
                    NotifyChanged("STModuleToolbarButtonID");
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

        public string STModuleToolbarButtonCaptionName
        {
            get { return _sTModuleToolbarButtonCaptionName; }
            set
            {
                if (value != this._sTModuleToolbarButtonCaptionName)
                {
                    _sTModuleToolbarButtonCaptionName = value;
                    NotifyChanged("STModuleToolbarButtonCaptionName");
                }
            }
        }

        public string STModuleToolbarButtonDesc
        {
            get { return _sTModuleToolbarButtonDesc; }
            set
            {
                if (value != this._sTModuleToolbarButtonDesc)
                {
                    _sTModuleToolbarButtonDesc = value;
                    NotifyChanged("STModuleToolbarButtonDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}
