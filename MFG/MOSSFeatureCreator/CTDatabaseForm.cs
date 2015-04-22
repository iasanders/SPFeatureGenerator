using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library;
using System.Collections.Generic;


namespace CTFeatureCreator
{



    public partial class CTDatabaseForm : FeatureFormBase
    {
        private string connectionString;
        private CTFeatureForm featureForm;

        public CTDatabaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings appSettings = new ApplicationSettings();
                connectionString = appSettings.ConnectionString;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

 


        private void LoadData()
        {
            try
            {

                List<string> definitions = DataAccess.GetFieldAndContentTypeDefinitions(connectionString);
                foreach (string definition in definitions)
                {
                    string nodeType = XmlHelper.GetElementName(definition);
                    if (nodeType.Equals("Field"))
                    {
                        string fieldName = XmlHelper.GetAttributeValue(definition, "DisplayName");
                        string id = XmlHelper.GetAttributeValue(definition, "ID");
                        lstColumns.Items.Add(new StringPair(fieldName + "    " + id, definition));
                    }
                    else
                    {
                        string fieldName = XmlHelper.GetAttributeValue(definition, "Name");
                        string id = XmlHelper.GetAttributeValue(definition, "ID");
                        lstContentTypes.Items.Add(new StringPair(fieldName + "    (" + id + ")", definition));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please specify a valid connection string by going to the data menu, then specifying 'connection'.\r\n\r\n" + ex.Message, "Connection Error");
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstContentTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a content type");
                return;
            }

            try
            {
                featureForm = new CTFeatureForm();
                featureForm.ContentType = ((StringPair)lstContentTypes.SelectedItem).Value;
                string[] columns = new string[lstColumns.Items.Count];

                for (int i = 0; i < lstColumns.Items.Count; i++)
                    columns[i] = ((StringPair)lstColumns.Items[i]).Value;

                featureForm.CustomColumns = columns;

                featureForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstContentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

    }
}