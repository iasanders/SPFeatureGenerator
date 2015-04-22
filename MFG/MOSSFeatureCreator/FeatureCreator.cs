using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Library;
using System.Collections.Specialized;
using System.Collections.ObjectModel;



namespace CTFeatureCreator
{
    public partial class FeatureCreator : Form
    {

        private int formCount = 0;

        public FeatureCreator()
        {
            InitializeComponent();
        }

        private void contentTypeFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SelectionForm lsf = new SelectionForm();
                lsf.FeatureType = FeatureType.ContentType;
                ActivateFeatureForm(lsf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ActivateFeatureForm(FeatureFormBase featureForm)
        {
            try
            {
                formCount++;
                featureForm.FormID = "Form" + formCount;
                featureForm.MdiParent = this;
                featureForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm cf = new ConnectionForm();
            ActivateFeatureForm(cf);
        }

        private void listFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SelectionForm lsf = new SelectionForm();
                lsf.FeatureType = FeatureType.ListTemplate;
                ActivateFeatureForm(lsf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AboutForm af = new AboutForm();
                ActivateFeatureForm(af);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralSelectionForm gsf = new GeneralSelectionForm();
                ActivateFeatureForm(gsf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listInstanceFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SelectionForm lsf = new SelectionForm();
                lsf.FeatureType = FeatureType.ListInstance;
                ActivateFeatureForm(lsf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void featureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SelectionForm lsf = new SelectionForm();
                lsf.FeatureType = FeatureType.SiteColumn;
                ActivateFeatureForm(lsf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cTAndColumnsFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CTDatabaseForm dbf = new CTDatabaseForm();
                ActivateFeatureForm(dbf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FeatureCreator_Load(object sender, EventArgs e)
        {
            ApplicationSettings appSettings = new ApplicationSettings();
            string xsdPath = appSettings.XsdPath;
            XmlHelper.XsdPath = xsdPath;
        }


    }
}