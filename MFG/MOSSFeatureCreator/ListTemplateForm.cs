using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library;
using Microsoft.SharePoint;

namespace CTFeatureCreator
{
    public partial class ListTemplateForm : FeatureFormBase
    {
        private VirtualListTemplate virtualListTemplate;
        private bool hasFeatureChanged = false;



        public VirtualListTemplate VirtualList
        {
            get { return virtualListTemplate; }
            set 
            {
                virtualListTemplate = value;
                LoadForm();
            }
        }

        private void LoadForm()
        {
            try
            {
                txtTitle.Text = virtualListTemplate.Name;
                txtDescription.Text = virtualListTemplate.Description;
                txtTemplateID.Text = "" + (int)virtualListTemplate.ListBaseType;
                txtDisplayName.Text = virtualListTemplate.Description;
                txtSecurityBits.Text = virtualListTemplate.SecurityBits;
                txtType.Text = virtualListTemplate.Type.ToString();
                ApplicationSettings settings = new ApplicationSettings();
                txtPath.Text = settings.FeatureDestionationPath;

                chkAllowDeletion.CheckState = ToCheckState(virtualListTemplate.AllowDeletion);
                chkAllowEveryoneViewItems.CheckState = ToCheckState(virtualListTemplate.AllowEveryOneViewItems); ;
                chkDisallowContentTypes.CheckState = ToCheckState(virtualListTemplate.DisallowContentTypes);
                chkDisallowContentTypes.CheckState = ToCheckState(virtualListTemplate.DisallowContentTypes);
                chkFolderCreation.CheckState = ToCheckState(virtualListTemplate.FolderCreation);
                chkHidden.CheckState = ToCheckState(virtualListTemplate.Hidden);
                chkEnableModeration.CheckState = ToCheckState(virtualListTemplate.EnableModeration);
                chkNoCrawl.CheckState = ToCheckState(virtualListTemplate.NoCrawl);
                chkVersioningEnabled.CheckState = ToCheckState(virtualListTemplate.VersioningEnabled);
                chkOnQuickLaunch.CheckState = ToCheckState(virtualListTemplate.OnQuickLaunch);


                foreach (SPField field in virtualListTemplate.OriginalList.Fields)
                {
                    if (!field.Hidden)
                        lstFieldRefs.Items.Add(field);
                }

                foreach (SPContentType contentType in virtualListTemplate.OriginalList.ContentTypes)
                    lstContentTypes.Items.Add(contentType.Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public ListTemplateForm()
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
                    ApplicationSettings settings = new ApplicationSettings();
                    settings.FeatureDestionationPath = txtPath.Text;
                    settings.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFeatures_Click(object sender, EventArgs e)
        {

            if (virtualListTemplate==null)
            {
                MessageBox.Show("Please select a content type on the previous screen");
                return;
            }

            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                string formsFromPath = settings.FormsFromPath;

                LoadVirtualListTemplate();
                if(!hasFeatureChanged)//only set feature properties in this screen if they have not been set in the feature screen
                    SetFeatureByThisScreen();
                XmlHelper.CreateListFeature(virtualListTemplate, virtualListTemplate.VirtualFeature, txtPath.Text + "\\" + virtualListTemplate.VirtualFeature.Title, true, false, chkLoadForms.Checked, formsFromPath, false);

                lblFeaturesCreated.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadVirtualListTemplate()
        {
            virtualListTemplate.AllowDeletion=ToNullableBool(chkAllowDeletion.CheckState);
            virtualListTemplate.AllowEveryOneViewItems = ToNullableBool(chkAllowEveryoneViewItems.CheckState);
            virtualListTemplate.DisallowContentTypes = ToNullableBool(chkDisallowContentTypes.CheckState);
            virtualListTemplate.EnableModeration = ToNullableBool(chkEnableModeration.CheckState);
            virtualListTemplate.FolderCreation = ToNullableBool(chkFolderCreation.CheckState);
            virtualListTemplate.Hidden = ToNullableBool(chkHidden.CheckState);
            virtualListTemplate.NoCrawl = ToNullableBool(chkNoCrawl.CheckState);
            virtualListTemplate.OnQuickLaunch = ToNullableBool(chkOnQuickLaunch.CheckState);
            virtualListTemplate.VersioningEnabled = ToNullableBool(chkVersioningEnabled.CheckState);

             virtualListTemplate.Name=txtTitle.Text;
             virtualListTemplate.Description=txtDescription.Text;
             virtualListTemplate.ListBaseType=(SPBaseType)Enum.Parse(typeof(SPBaseType),txtTemplateID.Text);
             virtualListTemplate.Description=txtDisplayName.Text;
             virtualListTemplate.SecurityBits=txtSecurityBits.Text;
             virtualListTemplate.Type=Int32.Parse(txtType.Text);

            virtualListTemplate.SetupPathForms = txtSetupPathForms.Text;
            virtualListTemplate.SetupPathViews = txtSetupPath.Text;
            virtualListTemplate.WebpartZoneID = txtWebpartZoneID.Text;
            virtualListTemplate.Url = txtUrl.Text;

        }

        private void ListFeatureForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetDefaults();

                ApplicationSettings settings = new ApplicationSettings();
                txtPath.Text = settings.FeatureDestionationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetFeatureByThisScreen()
        {
            virtualListTemplate.VirtualFeature = new VirtualFeature();
            virtualListTemplate.VirtualFeature.Scope = FeatureScope.Site;
            virtualListTemplate.VirtualFeature.Version = "1.0.0.0";
            virtualListTemplate.VirtualFeature.Title = txtTitle.Text;
            virtualListTemplate.VirtualFeature.Description = txtDescription.Text;
            virtualListTemplate.VirtualFeature.Id = virtualListTemplate.Id;
        }

        private void chkOverrideDefaults_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetEditStatus(chkOverrideDefaults.Checked);
                if (!chkOverrideDefaults.Checked)
                    SetDefaults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetEditStatus(bool enabled)
        {
            txtSetupPath.Enabled = enabled;
            txtSetupPathForms.Enabled = enabled;
            txtWebpartZoneID.Enabled = enabled;
            txtUrl.Enabled = enabled;
        }

        private void SetDefaults()
        {
            txtSetupPath.Text = "";
            txtSetupPathForms.Text = "";
            txtWebpartZoneID.Text = "Main";
            txtUrl.Text = "";
        }

        private void txtPath_Leave(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                settings.FeatureDestionationPath = txtPath.Text;
                settings.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListFeatureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                settings.FeatureDestionationPath = txtPath.Text;
                settings.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpecifyFeature_Click(object sender, EventArgs e)
        {
            try
            {
                if (virtualListTemplate.VirtualFeature==null)
                    SetFeatureByThisScreen();

                FeatureForm featureForm = new FeatureForm();
                featureForm.Feature = virtualListTemplate.VirtualFeature;
                if (featureForm.ShowDialog() == DialogResult.OK)
                {
                    virtualListTemplate.VirtualFeature = featureForm.Feature;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LoadVirtualListTemplate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowDialogButtons(bool show)
        {
            this.btnCancel.Visible = show;
            this.btnOK.Visible = show;
        }

    }
}