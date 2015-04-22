using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library;

namespace CTFeatureCreator
{
    public partial class CTFeatureForm : FeatureFormBase
    {
        private string[] customColumns;

        private string contentType;

        public string ContentType
        {
            get { return contentType; }
            set 
            { 
                contentType = value; 
                string featureName=XmlHelper.GetAttributeValue(contentType, "Name");
                txtTitle.Text = featureName + "Columns";
                txtTitle2.Text = featureName;
                txtDescription.Text = "Column definitons for " + featureName;
                txtDescription2.Text = XmlHelper.GetAttributeValue(contentType, "Description");
            }
        }

        public string[] CustomColumns
        {
            get { return customColumns; }
            set { customColumns = value; }
        }


        public CTFeatureForm()
        {
            InitializeComponent();
        }

        private void btnOpenFolderBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFeatures_Click(object sender, EventArgs e)
        {
            if (customColumns == null || customColumns.Length==0 || contentType==null)
            {
                MessageBox.Show("Please select a content type on the previous screen");
                return;
            }

            try
            {
                if (chkColumnsFeature.Checked)
                {
                    XmlHelper.CreateCustomColumnsFromDbFeature(txtTitle.Text, txtDescription.Text, txtVersion.Text, txtScope.Text,
                        contentType, customColumns, txtPath.Text + "\\" + txtTitle.Text, true);
                }

                XmlHelper.CreateCustomContentTypeFromDbFeature(txtTitle2.Text, txtDescription2.Text, txtVersion2.Text, txtSite2.Text, contentType, txtPath.Text + "\\" + txtTitle2.Text, true);

                lblFeaturesCreated.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CTFeatureForm_Load(object sender, EventArgs e)
        {
            ApplicationSettings settings = new ApplicationSettings();
            txtPath.Text = settings.FeatureDestionationPath;
        }


    }
}