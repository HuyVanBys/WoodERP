using BOSComponent;
using BOSLib;
using CommonResources;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BOSERP
{
    public class BOSERPScreen : BOSScreen
    {
        #region Constants

        #endregion

        #region Variables
        protected STScreensInfo _screenInfo;
        protected int _sortOrder;

        /// <summary>
        /// A variable to store custom required fields of the screen
        /// </summary>
        protected SortedList<string, List<string>> CustomRequiredFields;
        #endregion

        #region Properties
        /// <summary>
        /// STScreensInfo of the screen
        /// </summary>
        public STScreensInfo ScreenInfo
        {
            get
            {
                return _screenInfo;
            }
            set
            {
                _screenInfo = value;
            }
        }

        /// <summary>
        /// The order of the screen in the screen list of a module
        /// </summary>
        public int SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }
        #endregion

        #region Constructor
        public BOSERPScreen()
            : base()
        {
            Fields = new SortedList<string, STFieldsInfo>();
            FieldPermissions = new SortedList<string, STFieldPermissionsInfo>();
            CustomRequiredFields = new SortedList<string, List<string>>();
        }
        #endregion

        #region Functions to Init Screen
        public override BOSScreen Recreate()
        {
            BOSERPScreen scr = BOSERPScreenFactory.GetScreen(this.ScreenNumber, this.Module.Name);
            scr.Name = this.Name;
            scr.ScreenNumber = this.ScreenNumber;
            scr.Module = this.Module;
            scr.InitializeScreen(_screenInfo);
            return scr;
        }

        public void InitializeScreen(STScreensInfo screen)
        {
            this.SuspendLayout();
            ScreenInfo = screen;
            if (ScreenInfo != null)
            {
                ScreenID = ScreenInfo.STScreenID;
                ScreenNumber = ScreenInfo.STScreenNumber;
                this.MouseUp += new MouseEventHandler(Screen_MouseUp);
                this.ForeColor = Color.FromArgb(ScreenInfo.STScreenForeColor);
                this.Font = new Font(ScreenInfo.STScreenFontName, (float)ScreenInfo.STScreenFontSize, (FontStyle)Enum.Parse(typeof(FontStyle), ScreenInfo.STScreenFontStyle));
                this.Tag = ScreenInfo.STScreenTag;
                this.Icon = Resources.BYSLogo;
                if (this.IsDataSubScreen())
                {
                    this.FormClosing += new FormClosingEventHandler(Screen_Closing);
                }
                if (ScreenInfo.STScreenTag == BaseModule.cstDataSubScreen)
                {
                    this.Location = new Point(ScreenInfo.STScreenLocationX, ScreenInfo.STScreenLocationY);
                    this.Size = new Size(ScreenInfo.STScreenSizeWidth, ScreenInfo.STScreenSizeHeight);
                }
                GetFields();
                GetFieldPermissions();

                InitializeControls(this.Controls);

                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        /// <summary>
        /// Get all fields of the screen
        /// </summary>
        public virtual void GetFields()
        {
            Fields.Clear();
            List<STFieldsInfo> fieldList = this.Module.LstField;
            if (fieldList != null)
                fieldList = fieldList.Where(f => f.STScreenID == ScreenID).ToList();
            foreach (STFieldsInfo objFieldsInfo in fieldList)
            {
                if (!Fields.ContainsKey(objFieldsInfo.STFieldName))
                {
                    Fields.Add(objFieldsInfo.STFieldName, objFieldsInfo);
                }
            }
        }

        /// <summary>
        /// Get permission list of all fields of the screen
        /// </summary>
        private void GetFieldPermissions()
        {
            FieldPermissions.Clear();
            List<STFieldPermissionsInfo> fieldPermissionList = this.Module.LstFieldPermission;
            if (fieldPermissionList != null)
                fieldPermissionList = fieldPermissionList.Where(fp => fp.STModuleName == Module.Name
                    && fp.FK_ADUserGroupID == BOSApp.CurrentUserGroupInfo.ADUserGroupID
                    && fp.STScreenName == Name).ToList();
            foreach (STFieldPermissionsInfo objFieldPermissionsInfo in fieldPermissionList)
            {
                if (!FieldPermissions.ContainsKey(objFieldPermissionsInfo.STFieldName))
                {
                    FieldPermissions.Add(objFieldPermissionsInfo.STFieldName, objFieldPermissionsInfo);
                }
            }
        }

        private void InitScreenLookAndFeel()
        {
            ADUsersInfo objADUsersInfo = (ADUsersInfo)new ADUsersController().GetObjectByName(BOSApp.CurrentUser);
            if (!String.IsNullOrEmpty(objADUsersInfo.ADUserStyle))
            {
                if (objADUsersInfo.ADUserStyle == "XP")
                {
                    this.LookAndFeel.SetStyle((DevExpress.LookAndFeel.LookAndFeelStyle)Enum.Parse(typeof(DevExpress.LookAndFeel.LookAndFeelStyle), "Office2003"), true, true, objADUsersInfo.ADUserStyleSkin);
                }
                else
                {
                    this.LookAndFeel.SetStyle((DevExpress.LookAndFeel.LookAndFeelStyle)Enum.Parse(typeof(DevExpress.LookAndFeel.LookAndFeelStyle), objADUsersInfo.ADUserStyle), false, false, objADUsersInfo.ADUserStyleSkin);
                }
                if (objADUsersInfo.ADUserStyle.Equals("Skin"))
                    this.LookAndFeel.SetSkinStyle(objADUsersInfo.ADUserStyleSkin);
            }
            else
            {
                this.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.Office2003, false, false, objADUsersInfo.ADUserStyleSkin);
            }
        }

        public virtual void InitializeControls(Control.ControlCollection controls)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                for (int i = 0; i < controls.Count; i++)
                {
                    Control ctrl = controls[i];
                    ctrl = InitializeControl(ctrl);

                    SetPermission(ctrl);

                    //Init field format
                    InitializeFieldFormat(ctrl);

                    String strDataSource = dbUtil.GetPropertyStringValue(ctrl, cstDataSourcePropertyName);
                    String strDataMember = dbUtil.GetPropertyStringValue(ctrl, cstDataMemberPropertyName);
                    ctrl.AccessibleName = String.Format("{0};{1}", strDataSource, strDataMember);

                    String strFieldGroup = dbUtil.GetPropertyStringValue(ctrl, cstFieldGroupPropertyName);
                    //Add field to module's control collection 
                    if (!Module.Contains(ctrl.Name))
                        this.Module.Controls.Add(ctrl.Name, ctrl);
                    else
                        this.Module.Controls[ctrl.Name] = ctrl;

                    //Add control to its corresponding group
                    if (!String.IsNullOrEmpty(strFieldGroup))
                    {
                        String[] groups = strFieldGroup.Split(new char[] { ';' });
                        for (int j = 0; j < groups.Length; j++)
                        {
                            String group = groups[j].Trim();
                            if (!String.IsNullOrEmpty(group))
                            {
                                BaseModuleERP module = (BaseModuleERP)Module;
                                if (!module.FieldGroupControls.ContainsKey(group))
                                    module.FieldGroupControls.Add(group, new BOSLib.ControlCollection());
                                if (!module.FieldGroupControls[group].Contains(ctrl.Name))
                                    module.FieldGroupControls[group].Add(ctrl.Name, ctrl);
                                else
                                    module.FieldGroupControls[group][ctrl.Name] = ctrl;
                                switch (group)
                                {
                                    case BOSERPScreen.cstFieldGroupNonCreatable:
                                    case BOSERPScreen.cstFieldGroupNonEditable:
                                    case BOSERPScreen.cstFieldGroupAction:
                                        ctrl.Enabled = false;
                                        break;
                                    case BOSERPScreen.cstFieldGroupNonAction:
                                        ctrl.Enabled = true;
                                        break;
                                }
                            }
                        }
                    }

                    //Add custom require fields
                    if (!string.IsNullOrEmpty(strDataSource))
                    {
                        if (!CustomRequiredFields.ContainsKey(strDataSource))
                        {
                            List<string> requiredFields = new List<string>();
                            Type objectType = BusinessObjectFactory.GetBusinessObjectType(strDataSource + "Info");
                            if (objectType != null)
                            {
                                PropertyInfo[] props = objectType.GetProperties();
                                foreach (PropertyInfo prop in props)
                                {
                                    //Find property binding to this column then get its required attribute
                                    RequiredAttribute requiredAttr = null;
                                    object[] attrs = prop.GetCustomAttributes(typeof(RequiredAttribute), true);
                                    if (attrs.Length > 0)
                                    {
                                        requiredAttr = (RequiredAttribute)attrs[0];
                                    }
                                    if (requiredAttr != null)
                                    {
                                        requiredFields.Add(prop.Name);
                                    }
                                }
                            }
                            CustomRequiredFields.Add(strDataSource, requiredFields);
                        }
                    }

                    if (ctrl.Controls.Count > 0)
                        InitializeControls(ctrl.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add custom controls to screen. These controls are added by user
        /// </summary>
        /// <param name="screens">Screen list of the module</param>
        public virtual void AddCustomControls(IList<BOSScreen> screens)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            List<STFieldsInfo> ListFields = this.Module.LstField;
            ListFields = ListFields.Where(f => f.STFieldGroup == BOSERPScreen.cstFieldGroupCustom && f.STScreenID == ScreenID).ToList();
            if (ListFields != null && ListFields.Count > 0)
            {
                foreach (STFieldsInfo objFieldsInfo in ListFields)
                {
                    Control ctrl = null;
                    if (objFieldsInfo.STFieldType == typeof(DevExpress.XtraTab.XtraTabPage).Name)
                        ctrl = new DevExpress.XtraTab.XtraTabPage();
                    else
                        ctrl = (Control)BaseClassFactory.GetClass(String.Format("{0}.{1}", "BOSComponent", objFieldsInfo.STFieldType));
                    if (ctrl != null)
                    {
                        BOSControlUtil.SetControlCommonProperties(ctrl, objFieldsInfo);
                        MethodInfo mi = ctrl.GetType().GetMethod("InitializeControl", new Type[] { typeof(STFieldsInfo) });
                        if (mi != null)
                            mi.Invoke(ctrl, new object[] { objFieldsInfo });
                        this.Controls.Add(ctrl);
                    }
                }
            }

            //Through customization, user may move controls from one screen to another
            //Add controls of other screens to the target one
            foreach (STFieldsInfo objFieldsInfo in Fields.Values)
            {
                if (!string.IsNullOrEmpty(objFieldsInfo.STFieldName) && objFieldsInfo.STScreenID == ScreenID)
                {
                    Control[] foundControls = Controls.Find(objFieldsInfo.STFieldName, true);
                    if (foundControls.Length == 0)
                    {
                        foreach (BOSScreen screen in screens)
                        {
                            if (screen.ScreenID != ScreenID)
                            {
                                foundControls = screen.Controls.Find(objFieldsInfo.STFieldName, true);
                                if (foundControls.Length > 0)
                                {
                                    Controls.Add(foundControls[0]);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add asterisk, search button... next to their owner
        /// </summary>
        public virtual void AddExtraControls(Control.ControlCollection controls)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (Control ctrl in controls)
            {
                if (ctrl.Visible && ctrl.Enabled)
                {
                    if (!(ctrl is BOSLabel))
                    {
                        //Create * label automatic for all labels which is not allow null
                        String dataSource = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataSourcePropertyName);
                        String dataMember = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                        if (!String.IsNullOrEmpty(dataSource) && !String.IsNullOrEmpty(dataMember))
                        {
                            bool isRequired = !dbUtil.ColumnIsAllowNull(dataSource, dataMember);
                            if (!isRequired)
                            {
                                if (CustomRequiredFields.ContainsKey(dataSource))
                                {
                                    string temp = CustomRequiredFields[dataSource].Where(propName => propName == dataMember).FirstOrDefault();
                                    if (!string.IsNullOrEmpty(temp))
                                    {
                                        isRequired = true;
                                    }
                                }
                            }
                            if (isRequired)
                            {
                                BOSLabel asterisk = new BOSLabel();
                                asterisk.Text = "*";
                                asterisk.Appearance.ForeColor = Color.Red;
                                asterisk.Location = new Point(ctrl.Location.X + ctrl.Width + 3, ctrl.Location.Y);
                                asterisk.Parent = ctrl.Parent;
                                asterisk.Anchor = AnchorStyles.None;
                                if ((ctrl.Anchor & AnchorStyles.Right) == AnchorStyles.Right)
                                {
                                    asterisk.Anchor = asterisk.Anchor | AnchorStyles.Right;
                                }
                                else
                                {
                                    asterisk.Anchor = asterisk.Anchor | AnchorStyles.Left;
                                }
                                if ((ctrl.Anchor & AnchorStyles.Bottom) == AnchorStyles.Bottom)
                                {
                                    asterisk.Anchor = asterisk.Anchor | AnchorStyles.Bottom;
                                }
                                else
                                {
                                    asterisk.Anchor = asterisk.Anchor | AnchorStyles.Top;
                                }
                            }
                        }
                    }

                    //Create search button next to lookup edit that refer to master data
                    //if (ctrl.GetType() == typeof(BOSLookupEdit))
                    //{
                    //    String dataSource = ((BOSLookupEdit)ctrl).BOSDataSource;
                    //    String dataMember = ((BOSLookupEdit)ctrl).BOSDataMember;
                    //    if (!String.IsNullOrEmpty(dataSource) && !String.IsNullOrEmpty(dataMember) && dbUtil.IsForeignKey(dataSource, dataMember))
                    //    {
                    //        String lookupTable = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(dataSource, dataMember);
                    //        BOSButton searchButton = new BOSButton();
                    //        searchButton.Size = new Size(25, 20);
                    //        searchButton.Location = new Point(ctrl.Location.X + ctrl.Width + 5, ctrl.Location.Y);
                    //        searchButton.Click += new EventHandler(SearchButton_Click);
                    //        searchButton.Tag = lookupTable;
                    //        searchButton.Name = "search_" + ctrl.Name;
                    //        searchButton.Image = BOSApp.ToolbarImageList.Images["View"];
                    //        searchButton.Parent = ctrl.Parent;
                    //        searchButton.Anchor = ctrl.Anchor;
                    //    }
                    //}
                }
                if (ctrl.Controls.Count > 0)
                    AddExtraControls(ctrl.Controls);
            }
        }

        /// <summary>
        /// Customize controls based on database
        /// </summary>
        /// <param name="controls">Control collection of screen</param>
        public void CustomizeControls(Control.ControlCollection controls)
        {
            STFieldsController objFieldsController = new STFieldsController();
            for (int i = 0; i < controls.Count; i++)
            {
                Control ctrl = controls[i];
                if (!String.IsNullOrEmpty(ctrl.Name))
                {
                    STFieldsInfo objFieldsInfo = null;
                    if (Fields.ContainsKey(ctrl.Name))
                    {
                        objFieldsInfo = Fields[ctrl.Name];
                    }
                    if (objFieldsInfo != null)
                    {
                        BOSDbUtil dbUtil = new BOSDbUtil();
                        //Set control's common properties
                        BOSControlUtil.SetControlCommonProperties(ctrl, objFieldsInfo);
                        //Set own properties of a specific control
                        System.Reflection.MethodInfo mi = ctrl.GetType().GetMethod("InitializeControl", new Type[] { typeof(STFieldsInfo) });
                        if (mi != null)
                            mi.Invoke(ctrl, new object[] { objFieldsInfo });

                        if (objFieldsInfo.STFieldParentID > 0)
                        {
                            STFieldsInfo objFieldsParentInfo = Fields.Values.Where(f => f.STFieldID == objFieldsInfo.STFieldParentID).FirstOrDefault();
                            if (objFieldsParentInfo != null)
                            {
                                Control[] arr = this.Controls.Find(objFieldsParentInfo.STFieldName, true);
                                if (arr.Length > 0)
                                {
                                    Control parentCtrl = arr[0];
                                    if (ctrl.Parent.Name != parentCtrl.Name)
                                        i--;
                                    if (parentCtrl.GetType() == typeof(BOSTabControl))
                                        (parentCtrl as BOSTabControl).TabPages.Add(ctrl as DevExpress.XtraTab.XtraTabPage);
                                    else
                                        ctrl.Parent = parentCtrl;
                                    ctrl.Location = new Point(objFieldsInfo.STFieldLocationX - objFieldsParentInfo.STFieldLocationX, objFieldsInfo.STFieldLocationY - objFieldsParentInfo.STFieldLocationY);
                                }
                            }
                        }
                        else
                        {
                            if (ctrl.Parent.Name != this.Name)
                                i--;
                            ctrl.Parent = this;
                        }
                    }
                }

                if (ctrl.Controls.Count > 0 && !(ctrl is UserControl))
                    CustomizeControls(ctrl.Controls);
            }
        }

        /// <summary>
        /// Event handler for search button of lookup edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SearchButton_Click(object sender, EventArgs e)
        {
            //String tableName = (sender as BOSButton).Tag.ToString();
            //String buttonName = (sender as BOSButton).Name;
            //String ownerControlName = buttonName.Substring(7, buttonName.Length - 7);            
            //guiFind findForm = new guiFind(tableName, String.Empty, this.Module.Controls[ownerControlName], this.Module);
            //findForm.ShowDialog();
        }

        /// <summary>
        /// Initialize specific control
        /// </summary>
        public virtual Control InitializeControl(Control ctrl)
        {
            if (ctrl is IBOSControl)
            {
                IBOSControl control = (IBOSControl)ctrl;
                control.Screen = this;
                control.InitializeControl();
            }
            return ctrl;
        }

        public void InitializeControlEvent(STFieldsInfo objSTFieldsInfo, Control ctrl)
        {
            try
            {
                STFieldEventsController objSTFieldEventsController = new STFieldEventsController();

                List<STFieldEventsInfo> dsFieldEvent = ((IBaseModuleERP)this.Module).GetSystemFieldEvents();
                dsFieldEvent = dsFieldEvent.Where(fe => fe.STFieldID == objSTFieldsInfo.STFieldID).ToList();
                if (dsFieldEvent != null && dsFieldEvent.Count > 0)
                {
                    foreach (STFieldEventsInfo objSTFieldEventsInfo in dsFieldEvent)
                    {

                        EventInfo ctrlEvent = ctrl.GetType().GetEvent(objSTFieldEventsInfo.STFieldEventName);
                        if (!ctrlEvent.Name.Equals("KeyUp"))
                        {
                            String strMethodName = objSTFieldEventsInfo.STFieldEventDelegateFunctionName;

                            MethodInfo ctrlMethod = this.Module.GetMethodInfoByMethodFullNameAndMethodClass(objSTFieldEventsInfo.STFieldEventDelegateFunctionName, objSTFieldEventsInfo.STFieldEventDelegateFunctionFullName, objSTFieldEventsInfo.STFieldEventDelegateFunctionClass);

                            Delegate ctrlEventDelegate = null;

                            ctrlEventDelegate = Delegate.CreateDelegate(ctrlEvent.EventHandlerType, this.Module, ctrlMethod);

                            ctrlEvent.AddEventHandler(ctrl, ctrlEventDelegate);

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this.GetType().Name + ".InitializeControlEvent:" + e.Message);
            }
        }

        public override void BindingDataControl(Control ctrl)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strDataSource = dbUtil.GetPropertyStringValue(ctrl, cstDataSourcePropertyName);
                String strDataMember = dbUtil.GetPropertyStringValue(ctrl, cstDataMemberPropertyName);
                String strPropertyName = dbUtil.GetPropertyStringValue(ctrl, "BOSPropertyName");
                ERPModuleEntities entity = ((BaseModuleERP)Module).CurrentModuleEntity;
                if (ctrl.Tag != null)
                {
                    if (ctrl.Tag.Equals(DataControl))
                    {
                        String strMainModuleTable = BOSUtil.GetTableNameFromBusinessObject(entity.MainObject);
                        if (strDataSource.Equals(strMainModuleTable))
                        {
                            if (((BaseModuleERP)Module).CurrentModuleEntity.MainObject != null)
                            {
                                ctrl.DataBindings.Add(
                                                new Binding(strPropertyName,
                                                entity.MainObjectBindingSource,
                                                strDataMember,
                                                true,
                                                DataSourceUpdateMode.OnPropertyChanged));
                            }
                        }
                        else
                            if (((BaseModuleERP)Module).CurrentModuleEntity.ModuleObjects[strDataSource] != null)
                        {
                            ctrl.DataBindings.Add(
                                            new Binding(strPropertyName,
                                            entity.ModuleObjectsBindingSource[strDataSource],
                                            strDataMember,
                                            true,
                                            DataSourceUpdateMode.OnPropertyChanged));
                        }
                    }
                    else if (ctrl.Tag.Equals(SearchControl))
                    {
                        if (entity.SearchObjectBindingSource != null)
                        {
                            ctrl.DataBindings.Add(
                                                    new Binding(strPropertyName,
                                                    entity.SearchObjectBindingSource,
                                                    strDataMember,
                                                    true,
                                                    DataSourceUpdateMode.OnPropertyChanged));
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion       

        /// <summary>
        /// Init display format of a specific control
        /// </summary>
        public virtual void InitializeFieldFormat(Control ctrl)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String tableName = dbUtil.GetPropertyStringValue(ctrl, cstDataSourcePropertyName);
            String columnName = dbUtil.GetPropertyStringValue(ctrl, cstDataMemberPropertyName);
            if (!String.IsNullOrEmpty(tableName) && !String.IsNullOrEmpty(columnName))
            {
               
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Module.GetColumnFormat(tableName, columnName, this.Module.ModuleID);
                if (objFieldFormatGroupsInfo != null)
                {
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupBackColor > 0)
                        ctrl.BackColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupBackColor);
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupForeColor > 0)
                        ctrl.ForeColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupForeColor);

                    String strDefaultFontName = "Tahoma";
                    float fDefaultFontSize = 8.25F;
                    if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFontName))
                        strDefaultFontName = objFieldFormatGroupsInfo.STFieldFormatGroupFontName;
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupFontSize > 0)
                        fDefaultFontSize = objFieldFormatGroupsInfo.STFieldFormatGroupFontSize;
                    ctrl.Font = new Font(strDefaultFontName, fDefaultFontSize);

                    if (BOSUtil.IsEditControl(ctrl))
                    {
                        DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                        if (objFieldFormatGroupsInfo.STFieldFormatGroupDecimalRound > 0)
                        {
                            txt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            txt.Properties.Mask.EditMask = objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit;
                            txt.Properties.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType);
                            txt.Properties.DisplayFormat.FormatString = objFieldFormatGroupsInfo.STFieldFormatGroupFormatString;
                            if (objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit.Contains("# ##0"))
                            {
                                txt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                                txt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;
                                txt.FormatEditValue += Txt_FormatEditValue;
                            }
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType))
                            {
                                txt.Properties.Mask.MaskType = BOSUtil.GetMaskTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType);
                                txt.Properties.Mask.EditMask = objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit;
                                txt.Properties.Mask.UseMaskAsDisplayFormat = true;
                            }
                            if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType))
                            {
                                txt.Properties.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType);
                                txt.Properties.DisplayFormat.FormatString = objFieldFormatGroupsInfo.STFieldFormatGroupFormatString;
                            }
                        }
                    }
                }
            }
        }

        private void Txt_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String tableName = dbUtil.GetPropertyStringValue(sender, cstDataSourcePropertyName);
            String columnName = dbUtil.GetPropertyStringValue(sender, cstDataMemberPropertyName);
            if (!String.IsNullOrEmpty(tableName) && !String.IsNullOrEmpty(columnName))
            {
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Module.GetColumnFormat(tableName, columnName, this.Module.ModuleID);

                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    decimal temp;
                    decimal.TryParse(e.Value.ToString(), out temp);
                    //NumberFormatInfo nfi = new CultureInfo("sv-SE", false).NumberFormat;
                    var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                    nfi.NumberGroupSeparator = " ";
                    nfi.NumberDecimalSeparator = ".";
                    e.Value = temp.ToString(objFieldFormatGroupsInfo != null ? objFieldFormatGroupsInfo.STFieldFormatGroupFormatString : "N2", nfi);
                    e.Handled = true;
                }
            }
        }

        #region Screen Event Handlers
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOSERPScreen));
            this.SuspendLayout();
            // 
            // BOSERPScreen
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(1136, 589);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "BOSERPScreen";
            this.ResumeLayout(false);

        }

        public void Screen_Activated(object sender, EventArgs e)
        {
            base.Activate();
            this.SuspendLayout();
            this.Module.ActiveScreen = (BOSScreen)sender;
            this.ResumeLayout(true);
        }

        private void Screen_Closing(object sender, FormClosingEventArgs e)
        {
            STScreensController objSTScreensController = new STScreensController();
            BOSERPScreen scr = (BOSERPScreen)sender;

            if (scr.ScreenInfo != null)
            {
                ScreenInfo.STScreenLocationX = this.Location.X;
                ScreenInfo.STScreenLocationY = this.Location.Y;
                ScreenInfo.STScreenSizeHeight = this.Size.Height;
                ScreenInfo.STScreenSizeWidth = this.Size.Width;
                objSTScreensController.UpdateObject(ScreenInfo);
            }
            scr.Dispose();
        }

        private void Screen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (Module as BaseModuleERP).ParentScreen.popupMenuToolbar.ShowPopup(Control.MousePosition);
            }
        }

        private void BOSERPScreen_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumLock || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Scroll)
            {

                BaseModuleERP temp = (BaseModuleERP)(this.Module);
                temp.ParentScreen.CheckKeyBoard(e);
            }
        }

        private void BOSERPScreen_Activated(object sender, EventArgs e)
        {
            BaseModuleERP temp = (BaseModuleERP)(this.Module);
            temp.ParentScreen.CheckKeyBoard(null);
        }

        public void Control_Enter(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.Yellow;
            if (ctrl is DevExpress.XtraEditors.TextEdit)
            {
                (ctrl as DevExpress.XtraEditors.TextEdit).SelectAll();
            }
        }

        public void Control_Leave(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                return;
            }
        }

        public virtual void Activate()
        {
            base.Activate();
        }
        #endregion                       

        #region Init Context Menu Item

        private void ContextMenuItemNew_Click(object sender, EventArgs e)
        {
            (Module as BaseModuleERP).ActionNew();
        }

        private void ContextMenuItemEdit_Click(object sender, EventArgs e)
        {
            (Module as BaseModuleERP).ActionEdit();
        }

        private void ContextMenuItemDelete_Click(object sender, EventArgs e)
        {
            (Module as BaseModuleERP).ActionDelete();
        }

        private void ContextMenuItemCancel_Click(object sender, EventArgs e)
        {
            (Module as BaseModuleERP).ActionCancel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <BOSParam name="SearchResultsControlName" type="String"></BOSParam>
        private void ContextMenuItemSave_Click(object sender, EventArgs e)
        {
            MethodInfo method = this.GetType().GetMethod("ContextMenuItemSave_Click", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[2] { typeof(object), typeof(EventArgs) }, null);
            String strSearchResultsControlName = (Module as BaseModuleERP).GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
            (Module as BaseModuleERP).ActionSave();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <BOSParam name="SearchResultsControlName" type="String"></BOSParam>
        private void ContextMenuItemPrevious_Click(object sender, EventArgs e)
        {
            MethodInfo method = this.GetType().GetMethod("ContextMenuItemPrevious_Click", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[2] { typeof(object), typeof(EventArgs) }, null);
            String strSearchResultsControlName = (Module as BaseModuleERP).GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
            (Module as BaseModuleERP).ActionGoPrevious();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <BOSParam name="SearchResultsControlName" type="String"></BOSParam>
        private void ContextMenuItemNext_Click(object sender, EventArgs e)
        {
            MethodInfo method = this.GetType().GetMethod("ContextMenuItemNext_Click", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[2] { typeof(object), typeof(EventArgs) }, null);
            String strSearchResultsControlName = (Module as BaseModuleERP).GetModuleFunctionParameterValue(method.ToString(), method.DeclaringType.ToString(), "SearchResultsControlName");
            (Module as BaseModuleERP).ActionGoNext();
        }


        private void RegisterContextMenuItemsEvent()
        {
            fld_mnuNew.Click += new EventHandler(ContextMenuItemNew_Click);
            fld_mnuEdit.Click += new EventHandler(ContextMenuItemEdit_Click);
            fld_mnuDelete.Click += new EventHandler(ContextMenuItemDelete_Click);
            fld_mnuCancel.Click += new EventHandler(ContextMenuItemCancel_Click);
            fld_mnuSave.Click += new EventHandler(ContextMenuItemSave_Click);
            fld_mnuPrevious.Click += new EventHandler(ContextMenuItemPrevious_Click);
            fld_mnuNext.Click += new EventHandler(ContextMenuItemNext_Click);
        }

        #endregion

        /// <summary>
        /// Add all controls of module screens to various sections of parent screen
        /// based on control's tag
        /// </summary>
        public virtual void AddControlsToParentScreen()
        {
            //If screen is data main one, add tab page to screen container
            if (IsDataMainScreen())
            {
                DevExpress.XtraTab.XtraTabPage tpScreen = new DevExpress.XtraTab.XtraTabPage();
                tpScreen.Text = this.Text;
                tpScreen.Name = this.ScreenNumber;
                tpScreen.AutoScroll = true;
                tpScreen.AutoScrollMinSize = new Size(Width, Height - 100);
                List<Control> itemGridControls = FindControls("ItemGridControl");
                if (itemGridControls.Count > 0)
                {
                    tpScreen.AutoScrollMinSize = new Size(Width, Height);
                }
                ((BaseModuleERP)Module).ParentScreen.ScreenContainer.TabPages.Add(tpScreen);
            }

            ModuleParentScreen parentScreen = ((BaseModuleERP)Module).ParentScreen;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control ctrl = this.Controls[i];

                bool flag = false;
                if (ctrl.Tag != null)
                {
                    switch (ctrl.Tag.ToString())
                    {
                        case BOSERPScreen.SearchResultControl:
                            Size controlSize = parentScreen.SearchResultsContainer.Size;
                            ctrl.Size = controlSize;
                            parentScreen.SearchResultsContainer.Controls.Add(ctrl);
                            parentScreen.SearchResultsContainer.Controls[ctrl.Name].Dock = DockStyle.Fill;
                            i--;
                            flag = true;
                            break;
                        case BOSERPScreen.SearchInfo:
                        case BOSERPScreen.SearchControl:
                            if (IsSearchMainScreen())
                            {
                                ((BaseModuleERP)Module).SearchScreen.CriteriaSection.Controls.Add(ctrl);
                                i--;
                                flag = true;
                            }
                            break;
                    }
                }
                if (flag == false)
                {
                    if (parentScreen.ScreenContainer.TabPages.Count > 0)
                    {
                        parentScreen.ScreenContainer.TabPages[parentScreen.ScreenContainer.TabPages.Count - 1].Controls.Add(ctrl);
                        i--;
                    }
                }
            }
        }

        /// <summary>
        /// Find controls by a given type
        /// </summary>
        /// <param name="controlType">Control type</param>
        /// <returns>Controls match the given type</returns>
        public List<Control> FindControls(string controlType)
        {
            List<Control> result = new List<Control>();
            FindControls(controlType, Controls, ref result);
            return result;
        }

        /// <summary>
        /// Find controls by a given type
        /// </summary>
        /// <param name="controlType">Control type</param>
        /// <param name="controls">Control collection to find</param>        
        /// <param name="result">A ref parameter contains matching controls</param>
        private void FindControls(string controlType, Control.ControlCollection controls, ref List<Control> result)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType().Name == controlType || ctrl.GetType().BaseType.Name == controlType)
                {
                    result.Add(ctrl);
                }
                if (ctrl.Controls.Count > 0)
                {
                    FindControls(controlType, ctrl.Controls, ref result);
                }
            }
        }

        #region Generate Search Query
        protected virtual String GenerateSearchQuery(String strTableName)
        {
            StringBuilder strSearchQueryBuilder = new StringBuilder();
            strSearchQueryBuilder.Append(GenerateSearchQueryHeader(strTableName));
            if (this.Tag.ToString().Equals("SS"))
            {
                strSearchQueryBuilder.Append("WHERE" + BOSUtil.NewLine);
                strSearchQueryBuilder.Append(GenerateConditionsForSearch(strTableName));
            }

            strSearchQueryBuilder.Append(BOSUtil.NewLine);

            return strSearchQueryBuilder.ToString();
        }

        protected virtual String
            GenerateSearchQueryHeader(String strTableName)
        {
            return ((BaseModuleERP)Module).GenerateSearchQueryHeader(strTableName);
        }

        protected virtual String GenerateConditionsForSearch(String strTableName, Control.ControlCollection ctrls)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            StringBuilder strConditionBuilder = new StringBuilder();

            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Tag != null)
                {
                    if (ctrl.Tag.ToString().Equals("SC"))
                    {
                        String strColumnName = (ctrl as DevExpress.XtraEditors.BaseEdit).Properties.AccessibleName;
                        if (String.IsNullOrEmpty(strColumnName))
                            strColumnName = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                        strConditionBuilder.Append(((BaseModuleERP)Module).GenerateConditionsForSearch(ctrl, strTableName, strColumnName));
                    }
                }
                if (ctrl.Controls.Count > 0)
                    strConditionBuilder.Append(GenerateConditionsForSearch(strTableName, ctrl.Controls));
            }
            return strConditionBuilder.ToString();
        }

        protected virtual String GenerateConditionsForSearch(String strTableName)
        {
            StringBuilder strConditionBuilder = new StringBuilder();
            strConditionBuilder.Append(GenerateConditionsForSearch(strTableName, Controls));
            strConditionBuilder.Append(BOSUtil.Tab + String.Format("([AAStatus]='Alive')") + BOSUtil.NewLine);
            return strConditionBuilder.ToString();
        }
        #endregion

        /// <summary>
        /// Display text basing on business object for all labels of the screen
        /// </summary>
        public virtual void DisplayLabelText(BusinessObject obj, Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                ((BaseModuleERP)Module).DisplayLabelText(obj, ctrl);
                if (ctrl.Controls.Count > 0)
                    DisplayLabelText(obj, ctrl.Controls);
            }
        }

        #region Permission
        /// <summary>
        /// Set permission for all controls of the screen
        /// </summary>
        public virtual void SetPermission()
        {
            SetPermission(this.Controls);
        }

        protected virtual void SetPermission(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                SetPermission(ctrl);
                if (ctrl.Controls.Count > 0)
                    SetPermission(ctrl.Controls);
            }
        }

        protected virtual void SetPermission(Control ctrl)
        {
            if (FieldPermissions.ContainsKey(ctrl.Name))
            {
                STFieldPermissionsInfo objFieldPermissionsInfo = FieldPermissions[ctrl.Name];
                if (objFieldPermissionsInfo != null)
                {
                    if (ctrl is XtraTabPage)
                    {
                        XtraTabPage tabPage = (XtraTabPage)ctrl;
                        if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                            tabPage.PageVisible = false;
                    }
                    else
                    {
                        if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                            ctrl.Visible = false;
                        else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Disabled))
                            ctrl.Enabled = false;
                        else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.HidedDisabled))
                            ctrl.Visible = false;
                        else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.None))
                        {
                            ctrl.Visible = true;
                            ctrl.Enabled = true;
                            if (ctrl is BaseEdit)
                            {
                                (ctrl as BaseEdit).Properties.ReadOnly = false;
                            }
                        }
                    }
                }
            }
        }
        #endregion                   
    }
}