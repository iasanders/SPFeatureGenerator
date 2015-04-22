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
    public partial class FeatureForm:FeatureFormBase
    {
        public FeatureForm()
        {
            InitializeComponent();
        }

        private VirtualFeature virtualFeature = new VirtualFeature();

        public VirtualFeature Feature
        {
            get 
            {
                 virtualFeature.Title=txtTitle.Text;
                 virtualFeature.Description=txtDescription.Text;
                 virtualFeature.Scope=(FeatureScope) Enum.Parse(typeof(FeatureScope),txtScope.Text);
                 virtualFeature.Version=txtVersion.Text;
                 virtualFeature.Id = new Guid(txtFeatureID.Text);
                 virtualFeature.Creator=txtCreator.Text;
                 virtualFeature.SolutionId=txtSolutionID.Text;
                 virtualFeature.ReceiverClass=txtReceiverClass.Text;
                 virtualFeature.ReceiverAssembly=txtReceiverAssembly.Text;
                 virtualFeature.ImageUrlAltText=txtImageUrlAltText.Text;
                 virtualFeature.ImageUrl=txtImageUrl.Text;


                 virtualFeature.ActivateOnDefault = ToNullableBool(chkActivateOnDefault.CheckState);
                 virtualFeature.AlwaysForceInstall = ToNullableBool(chkAllwaysForceInstall.CheckState);
                 virtualFeature.AutoActivateInCentralAdmin = ToNullableBool(chkAutoActivateInCentralAdmin.CheckState);
                 virtualFeature.Hidden = ToNullableBool(chkHidden.CheckState);
                 virtualFeature.RequireResources = ToNullableBool(chkRequireResources.CheckState); 
         
                return virtualFeature; 
            }
            set 
            { 
                virtualFeature = value;
                LoadForm();
            }
        }

        private void LoadForm()
        {
            try
            {
                txtTitle.Text = virtualFeature.Title;
                txtDescription.Text = virtualFeature.Description;
                txtScope.Text = virtualFeature.Scope.ToString();
                txtVersion.Text = virtualFeature.Version;
                txtFeatureID.Text = virtualFeature.Id != null ? virtualFeature.Id.ToString() : Guid.NewGuid().ToString("B");
                txtCreator.Text = virtualFeature.Creator;
                txtSolutionID.Text = virtualFeature.SolutionId;
                txtReceiverClass.Text = virtualFeature.ReceiverClass;
                txtReceiverAssembly.Text = virtualFeature.ReceiverAssembly;
                txtImageUrlAltText.Text = virtualFeature.ImageUrlAltText;
                txtImageUrl.Text = virtualFeature.ImageUrl;

                chkActivateOnDefault.CheckState = ToCheckState(virtualFeature.ActivateOnDefault);
                chkAllwaysForceInstall.CheckState = ToCheckState(virtualFeature.AlwaysForceInstall);
                chkAutoActivateInCentralAdmin.CheckState = ToCheckState(virtualFeature.AutoActivateInCentralAdmin);
                chkHidden.CheckState = ToCheckState(virtualFeature.Hidden);
                chkRequireResources.CheckState = ToCheckState(virtualFeature.RequireResources);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void txtCreator_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewGuid_Click(object sender, EventArgs e)
        {
            try
            {
                txtFeatureID.Text = Guid.NewGuid().ToString("B");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FeatureForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }


    }
}