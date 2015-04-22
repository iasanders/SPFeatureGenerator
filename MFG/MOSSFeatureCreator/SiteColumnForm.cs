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
    public partial class SiteColumnForm : Library.FeatureFormBase
    {
        private VirtualField virtualField;


        public VirtualField VirtualField
        {
            get { return virtualField; }
            set { virtualField = value; }
        }


        public SiteColumnForm()
        {
            InitializeComponent();
        }


        public void ShowDialogButtons(bool show)
        {
            this.btnCancel.Visible = show;
            this.btnOK.Visible = show;
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
                if (virtualField.VirtualFeature==null)
                    SetFeatureByThisScreen();

                FeatureForm featureForm = new FeatureForm();
                featureForm.Feature = virtualField.VirtualFeature;
                if (featureForm.ShowDialog() == DialogResult.OK)
                {
                    virtualField.VirtualFeature = featureForm.Feature;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFeatures_Click(object sender, EventArgs e)
        {
            if (virtualField == null)
            {
                MessageBox.Show("Please select a Field on the previous screen");
                return;
            }

            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                string formsFromPath = settings.FormsFromPath;

                LoadVirtualField();
                if (virtualField.VirtualFeature == null)//only set feature properties in this screen if they have not been set in the feature screen
                    SetFeatureByThisScreen();
                XmlHelper.CreateColumnFeature(virtualField, virtualField.VirtualFeature, txtPath.Text + "\\" + virtualField.VirtualFeature.Title);
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

        private void SiteColumnForm_Load(object sender, EventArgs e)
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
                txtMaxLength.Text = virtualField.MaxLength.HasValue ? virtualField.MaxLength.ToString() : "";
                txtID.Text = virtualField.Id.ToString("B"); ;
                txtGroup.Text = virtualField.Group;
                txtSource.Text = virtualField.SourceID;
                txtStaticName.Text = virtualField.StaticName;
                txtDisplayName.Text = virtualField.DisplayName;
                txtName.Text = virtualField.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void LoadVirtualField()
        {
            try
            {
                if (txtMaxLength.Text != String.Empty)
                    virtualField.MaxLength = Int32.Parse(txtMaxLength.Text);
                virtualField.Id = new Guid(txtID.Text);
                virtualField.Group = txtGroup.Text;
                virtualField.SourceID = txtSource.Text;
                virtualField.StaticName = txtStaticName.Text;
                virtualField.Name = txtName.Text;
                virtualField.DisplayName = txtDisplayName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetFeatureByThisScreen()
        {
            virtualField.VirtualFeature = new VirtualFeature();
            virtualField.VirtualFeature.Scope = FeatureScope.Site;
            virtualField.VirtualFeature.Version = "1.0.0.0";
            virtualField.VirtualFeature.Title = txtStaticName.Text;
            virtualField.VirtualFeature.Description = txtStaticName.Text;
            virtualField.VirtualFeature.Id = new Guid(txtID.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                LoadVirtualField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}

