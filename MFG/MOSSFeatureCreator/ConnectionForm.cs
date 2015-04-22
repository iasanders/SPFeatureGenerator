using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CTFeatureCreator
{
    public partial class ConnectionForm : Library.FeatureFormBase
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings appSettings = new ApplicationSettings();
                txtConnectionString.Text = appSettings.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings appSettings = new ApplicationSettings();
                appSettings.ConnectionString = txtConnectionString.Text;
                appSettings.Save();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(txtConnectionString.Text);
                connection.Open();
                lblConnection.Text = "Connection OK";
                lblConnection.ForeColor = Color.Lime;
                lblConnection.Visible = true;
            }
            catch
            {
                lblConnection.Text = "Connection failed";
                lblConnection.ForeColor = Color.Red;
                lblConnection.Visible = true;
            }
        }
    }
}

