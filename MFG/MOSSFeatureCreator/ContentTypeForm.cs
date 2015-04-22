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
    public partial class ContentTypeForm : Library.FeatureFormBase
    {

        private VirtualContentType virtualContentType;

        public VirtualContentType VirtualContentType
        {
            get { return virtualContentType; }
            set { virtualContentType = value; }
        }

        public ContentTypeForm()
        {
            InitializeComponent();
        }

        private void ContentTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                txtPath.Text = settings.FeatureDestionationPath;
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadForm()
        {
            try
            {
                txtDescription.Text = virtualContentType.Description;

                //if (!virtualContentType.FeatureID.Equals(new Guid()))
                //    txtFeatureID.Text = virtualContentType.FeatureID.ToString("B"); ;
                txtGroup.Text = virtualContentType.Group;
                txtID.Text = virtualContentType.Id;
                txtResourceFolder.Text = virtualContentType.ResourceFolder;
                txtName.Text = virtualContentType.Name;

                chkHidden.CheckState = ToCheckState(virtualContentType.Hidden);
                chkReadOnly.CheckState = ToCheckState(virtualContentType.ReadOnly);
                chkSealed.CheckState = ToCheckState(virtualContentType.Sealed);

                ApplicationSettings settings = new ApplicationSettings();
                txtPath.Text=settings.FeatureDestionationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadVirtualContentType()
        {
            try
            {
                virtualContentType.Hidden = ToNullableBool(chkHidden.CheckState);
                virtualContentType.ReadOnly = ToNullableBool(chkReadOnly.CheckState);
                virtualContentType.Sealed = ToNullableBool(chkSealed.CheckState);

                virtualContentType.Name = txtName.Text;
                virtualContentType.Description = txtDescription.Text;
                //if (txtFeatureID.Text != String.Empty)
                //    virtualContentType.FeatureID = new Guid(txtFeatureID.Text);
                //virtualContentType.VirtualFeature = virtualFeature;
                virtualContentType.Group = txtGroup.Text;
                virtualContentType.Id = txtID.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void SetFeatureByThisScreen()
        {
            try
            {
                virtualContentType.VirtualFeature = new VirtualFeature();

                virtualContentType.VirtualFeature.Scope = FeatureScope.Site;
                virtualContentType.VirtualFeature.Version = "1.0.0.0";
                virtualContentType.VirtualFeature.Title = txtName.Text;
                virtualContentType.VirtualFeature.Description = txtDescription.Text;
                if (txtFeatureID.Text != String.Empty)
                    virtualContentType.VirtualFeature.Id = new Guid(txtFeatureID.Text);
                else
                    virtualContentType.VirtualFeature.Id = Guid.NewGuid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnSpecifyFeature_Click(object sender, EventArgs e)
        {
            try
            {

                if (virtualContentType.VirtualFeature==null)
                    SetFeatureByThisScreen();

                FeatureForm featureForm = new FeatureForm();
                featureForm.Feature = virtualContentType.VirtualFeature;
                if (featureForm.ShowDialog() == DialogResult.OK)
                {
                    virtualContentType.VirtualFeature = featureForm.Feature;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFeatures_Click(object sender, EventArgs e)
        {

            if (virtualContentType == null)
            {
                MessageBox.Show("Please select a content type on the previous screen");
                return;
            }

            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                string formsFromPath = settings.FormsFromPath;

                LoadVirtualContentType();
                if (virtualContentType.VirtualFeature == null)//only set feature properties in this screen if they have not been set in the feature screen
                    SetFeatureByThisScreen();
                XmlHelper.CreateContentTypeFeature(virtualContentType, virtualContentType.VirtualFeature, txtPath.Text + "\\" + virtualContentType.VirtualFeature.Title, false);
                lblFeaturesCreated.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LoadVirtualContentType();
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

