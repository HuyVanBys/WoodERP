using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSCommon;
using BOSComponent;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using BOSLib;
using DevExpress.XtraGrid.Columns;

using System.IO;
using System.Net;
using System.Configuration;
using System.Reflection;
using DevExpress.XtraEditors.Controls;

namespace BOSERP.Modules.ProductionNorm.UI
{
    public partial class guiChoosePictureProduct : BOSERPScreen
    {
        public string ObjectType = string.Empty;

        public guiChoosePictureProduct()
        {
            InitializeComponent();  
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChoosePictureProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            entity.SemiProductList.GridControl = fld_dgcPictureProduct;
            iCProductsInfoBindingSource.DataSource = entity.SemiProductList;
            if (ObjectType == ProductType.IngredientPackaging.ToString())
            {
                ((ProductionNormModule)Module).InitPackagingList(true);
            }
            else
            {
                ((ProductionNormModule)Module).InitSemiProductList(true);
            }
            
        }
        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).BrowseFile();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).DeleteFile();
        }

        public void SetPictureProduct(string filename)
        {
            if (filename == string.Empty)
            {
                pictureBox2.Image = null;
                return;
            }
            BOSProgressBar.Start("Loading image...");
            try
            {
                //byte[] data = BOSApp.DownloadDataFileFTP(filename, "Products");
                //if (data != null)
                //{
                //    MemoryStream stream = new MemoryStream(data);
                //    Image img2 = Image.FromStream(stream);
                //    stream.Close();
                //    pictureBox2.Image = img2;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải hình ảnh: " + ex.Message.ToString());
                BOSProgressBar.Close();
            }
            BOSProgressBar.Close();
        }
        

        public string CreatePathFile(string fileName, string subFolder)
        {
            string localPath = string.Empty;
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();
                string temp_location = System.IO.Path.GetTempPath();

                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(temp_location);
                if (!System.IO.Directory.Exists(temp_location))
                {
                    System.IO.Directory.CreateDirectory(temp_location);
                }

                WebClient request = new WebClient();
                request.Credentials = new NetworkCredential(ftp_username.Normalize(), ftp_password.Normalize()); 
                string pathFile = "ftp://";
                if (String.IsNullOrEmpty(ftp_homedir))
                {
                    if (String.IsNullOrEmpty(subFolder))
                    {
                        pathFile += ftp_host;
                    }
                    else
                    {
                        pathFile += ftp_host + "/" + subFolder;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(subFolder))
                    {
                        subFolder = ftp_homedir;
                    }
                    else
                    {
                        subFolder = ftp_homedir + "/" + subFolder;
                    }
                    pathFile += ftp_host + "/" + subFolder+ "/" + fileName;
                }
                localPath = pathFile;
            }
            catch (Exception ep)
            {
                MessageBox.Show("Không thể lưu hình ảnh:" + ep.Message.ToString());
            }
            return localPath;
        }

        private void fld_btnSetDefualt_Click(object sender, EventArgs e)
        {
            if (fld_cbxFileExtension.Text != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn cập nhật tên file cho tất cả các chi tiết?"
                    , MESLocalizedResources.MessageBoxDefaultCaption
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string extension = fld_cbxFileExtension.Text;
                    ((ProductionNormModule)Module).DefualtFileName(extension);
                }
            }
        }
       
    }
}
