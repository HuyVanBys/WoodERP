using AutoMapper;
using BOSLib.Entities;
using System;
using System.Collections.Generic;

namespace BOSLib
{
    public class BysGateway
    {
        public static string ProjectCode { get; set; }

        public static string MutexInstanceName { get; set; }

        public static List<string> LibraryModule { get; set; }

        public static ADUsersInfo CurrentUsersInfo { get; set; }

        public static string UserDataDirectoryPath { get; set; }

        public static List<BysTable> Tables { get; set; }

        public static List<BysTableColumn> TableColumns { get; set; }

        public static List<BysTableColumn> DefinedTypeColumns { get; set; }

        public static List<BysTableConstraint> TableConstraints { get; set; }

        public static DateTime LocalLoginDate { get; set; }

        public static DateTime ServerLoginDate { get; set; }

        public static DateTime CurrentServerDate => ServerLoginDate + (DateTime.Now - LocalLoginDate);

        public static IMapper Mapper { get; set; }

        public static string CurrentVersion { get; set; }

        public static string EnvironmentVersion { get; set; }
		
		public static string CredentialPrefixKey => string.Format("{0}//{1}", "BYSERP", ProjectCode);

        static BysGateway()
        {
            LibraryModule = new List<string>()
            {
                 "BOSERP.exe"
                , "BOSLib.dll"
                , "BOSComponent.dll"
                , "BOSBase.dll"
                , "BOSEntity.dll"
            };
            UserDataDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\BYSERP\";
            Z.Dapper.Plus.DapperPlusManager.AddLicense("156;700-BYS", "1241848-4920C4D-77493D2-07ED77B-1B8D");
        }
    }
}
