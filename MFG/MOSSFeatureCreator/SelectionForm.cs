using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library;
using Microsoft.SharePoint;


namespace CTFeatureCreator
{

    
    public partial class SelectionForm : FeatureFormBase
    {

        private ListTemplateForm listFeatureForm;
        private SiteColumnForm siteColumnForm;
        private ContentTypeForm contentTypeForm;
        private ListInstanceForm listInstanceForm;


        private SPSite site;
        private SPWeb web;
        private FeatureType featureType;

        public FeatureType FeatureType
        {
            get { return featureType; }
            set { featureType = value; }
        }


        public SelectionForm()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstItems.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item");
                    return;
                }



                switch (featureType)
                {
                    case FeatureType.ListTemplate:
                        ShowListTemplateForm();
                        break;
                    case FeatureType.ListInstance: ;
                        ShowListInstanceForm();
                        break;
                    case FeatureType.ContentType: ;
                        ShowContentTypeForm();
                        break;
                    case FeatureType.SiteColumn: ;
                        ShowSiteColumnForm();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowListTemplateForm()
        {
                listFeatureForm=new ListTemplateForm();
                listFeatureForm.VirtualList=(VirtualListTemplate)lstItems.SelectedItem;
                listFeatureForm.Show();
        }


        private void ShowListInstanceForm()
        {
            listInstanceForm = new ListInstanceForm();
            listInstanceForm.VirtualListInstance = (VirtualListInstance)lstItems.SelectedItem;
            listInstanceForm.Show();
        }


        private void ShowContentTypeForm()
        {
            contentTypeForm = new ContentTypeForm();
            contentTypeForm.VirtualContentType = (VirtualContentType)lstItems.SelectedItem;
            contentTypeForm.Show();
        }

        private void ShowSiteColumnForm()
        {
            siteColumnForm = new SiteColumnForm();
            siteColumnForm.VirtualField = (VirtualField)lstItems.SelectedItem;
            siteColumnForm.Show();
        }


        private void lstLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void txtSiteUrl_Leave(object sender, EventArgs e)
        {
            try
            {
                LoadSites();
                ApplicationSettings appSettings = new ApplicationSettings();
                appSettings.SiteUrl = txtSiteUrl.Text;
                appSettings.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSites()
        {
            try
            {
                site = new SPSite(txtSiteUrl.Text);

                foreach (SPWeb web in site.AllWebs)
                {
                    cboWebs.Items.Add(web);
                }

                cboWebs.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void cboWebs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                web = (SPWeb)cboWebs.SelectedItem;
                lstItems.Items.Clear();
                lstItems.BeginUpdate();
                switch (featureType)
                {
                    case FeatureType.ListTemplate:
                        foreach (SPList list in web.Lists)
                        {
                            lstItems.Items.Add(new VirtualListTemplate(list));
                        }
                        break;
                    case FeatureType.ListInstance: ;
                        foreach (SPList list in web.Lists)
                        {
                            lstItems.Items.Add(new VirtualListInstance(list));
                        }
                        break;
                    case FeatureType.ContentType: ;
                        foreach (SPContentType ct in web.ContentTypes)
                        {
                            lstItems.Items.Add(new VirtualContentType(ct));
                        }
                        break;
                    case FeatureType.SiteColumn: ;
                        foreach (SPField field in web.Fields)
                        {
                            lstItems.Items.Add(new VirtualField(field));
                        }
                        break;
                }

                lstItems.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ListSelectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings appSettings = new ApplicationSettings();
                txtSiteUrl.Text = appSettings.SiteUrl;

                if (!txtSiteUrl.Text.Equals(appSettings.NotDefined))
                    LoadSites();

                lstItems.Text = featureType.ToString();
                this.Text = featureType.ToString() + " Form";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}