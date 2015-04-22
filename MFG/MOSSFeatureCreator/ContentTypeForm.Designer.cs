namespace CTFeatureCreator
{
    partial class ContentTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResourceFolder = new System.Windows.Forms.Label();
            this.txtResourceFolder = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblFeatureID = new System.Windows.Forms.Label();
            this.txtFeatureID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkSealed = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblColumnPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.btnSpecifyFeature = new System.Windows.Forms.Button();
            this.btnCreateFeatures = new System.Windows.Forms.Button();
            this.lblFeaturesCreated = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResourceFolder);
            this.groupBox1.Controls.Add(this.txtResourceFolder);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.lblFeatureID);
            this.groupBox1.Controls.Add(this.txtFeatureID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblResourceFolder
            // 
            this.lblResourceFolder.AutoSize = true;
            this.lblResourceFolder.Location = new System.Drawing.Point(6, 290);
            this.lblResourceFolder.Name = "lblResourceFolder";
            this.lblResourceFolder.Size = new System.Drawing.Size(82, 13);
            this.lblResourceFolder.TabIndex = 19;
            this.lblResourceFolder.Text = "ResourceFolder";
            // 
            // txtResourceFolder
            // 
            this.txtResourceFolder.Location = new System.Drawing.Point(6, 306);
            this.txtResourceFolder.Name = "txtResourceFolder";
            this.txtResourceFolder.Size = new System.Drawing.Size(213, 20);
            this.txtResourceFolder.TabIndex = 18;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(6, 237);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 17;
            this.lblGroup.Text = "Group";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(6, 255);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(213, 20);
            this.txtGroup.TabIndex = 16;
            // 
            // lblFeatureID
            // 
            this.lblFeatureID.AutoSize = true;
            this.lblFeatureID.Location = new System.Drawing.Point(6, 186);
            this.lblFeatureID.Name = "lblFeatureID";
            this.lblFeatureID.Size = new System.Drawing.Size(54, 13);
            this.lblFeatureID.TabIndex = 15;
            this.lblFeatureID.Text = "FeatureID";
            // 
            // txtFeatureID
            // 
            this.txtFeatureID.Location = new System.Drawing.Point(6, 204);
            this.txtFeatureID.Name = "txtFeatureID";
            this.txtFeatureID.Size = new System.Drawing.Size(213, 20);
            this.txtFeatureID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 153);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(213, 20);
            this.txtID.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Decription";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 40);
            this.txtDescription.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkReadOnly);
            this.groupBox2.Controls.Add(this.chkSealed);
            this.groupBox2.Controls.Add(this.chkHidden);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 92);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Location = new System.Drawing.Point(6, 19);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(73, 17);
            this.chkReadOnly.TabIndex = 13;
            this.chkReadOnly.Text = "ReadOnly";
            this.chkReadOnly.ThreeState = true;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkSealed
            // 
            this.chkSealed.AutoSize = true;
            this.chkSealed.Location = new System.Drawing.Point(6, 65);
            this.chkSealed.Name = "chkSealed";
            this.chkSealed.Size = new System.Drawing.Size(59, 17);
            this.chkSealed.TabIndex = 15;
            this.chkSealed.Text = "Sealed";
            this.chkSealed.ThreeState = true;
            this.chkSealed.UseVisualStyleBackColor = true;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(6, 42);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 12;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.ThreeState = true;
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblColumnPath);
            this.grpAction.Controls.Add(this.txtPath);
            this.grpAction.Controls.Add(this.btnOpenFolderBrowser);
            this.grpAction.Controls.Add(this.btnSpecifyFeature);
            this.grpAction.Controls.Add(this.btnCreateFeatures);
            this.grpAction.Controls.Add(this.lblFeaturesCreated);
            this.grpAction.Location = new System.Drawing.Point(285, 110);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(272, 144);
            this.grpAction.TabIndex = 34;
            this.grpAction.TabStop = false;
            // 
            // lblColumnPath
            // 
            this.lblColumnPath.AutoSize = true;
            this.lblColumnPath.Location = new System.Drawing.Point(13, 26);
            this.lblColumnPath.Name = "lblColumnPath";
            this.lblColumnPath.Size = new System.Drawing.Size(127, 13);
            this.lblColumnPath.TabIndex = 9;
            this.lblColumnPath.Text = "Path to create features to";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 42);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(213, 20);
            this.txtPath.TabIndex = 8;
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(230, 42);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(26, 20);
            this.btnOpenFolderBrowser.TabIndex = 10;
            this.btnOpenFolderBrowser.Text = "...";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // btnSpecifyFeature
            // 
            this.btnSpecifyFeature.Location = new System.Drawing.Point(11, 70);
            this.btnSpecifyFeature.Name = "btnSpecifyFeature";
            this.btnSpecifyFeature.Size = new System.Drawing.Size(108, 24);
            this.btnSpecifyFeature.TabIndex = 30;
            this.btnSpecifyFeature.Text = "Specify Feature";
            this.btnSpecifyFeature.UseVisualStyleBackColor = true;
            this.btnSpecifyFeature.Click += new System.EventHandler(this.btnSpecifyFeature_Click);
            // 
            // btnCreateFeatures
            // 
            this.btnCreateFeatures.Location = new System.Drawing.Point(125, 70);
            this.btnCreateFeatures.Name = "btnCreateFeatures";
            this.btnCreateFeatures.Size = new System.Drawing.Size(99, 24);
            this.btnCreateFeatures.TabIndex = 11;
            this.btnCreateFeatures.Text = "Create Feature";
            this.btnCreateFeatures.UseVisualStyleBackColor = true;
            this.btnCreateFeatures.Click += new System.EventHandler(this.btnCreateFeatures_Click);
            // 
            // lblFeaturesCreated
            // 
            this.lblFeaturesCreated.AutoSize = true;
            this.lblFeaturesCreated.ForeColor = System.Drawing.Color.Red;
            this.lblFeaturesCreated.Location = new System.Drawing.Point(13, 107);
            this.lblFeaturesCreated.Name = "lblFeaturesCreated";
            this.lblFeaturesCreated.Size = new System.Drawing.Size(88, 13);
            this.lblFeaturesCreated.TabIndex = 16;
            this.lblFeaturesCreated.Text = "Features Created";
            this.lblFeaturesCreated.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Location = new System.Drawing.Point(285, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 93);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(140, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(201, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 24);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ContentTypeForm
            // 
            this.ClientSize = new System.Drawing.Size(582, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContentTypeForm";
            this.Text = "Content Type Definition";
            this.Load += new System.EventHandler(this.ContentTypeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblFeatureID;
        private System.Windows.Forms.TextBox txtFeatureID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkSealed;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Label lblResourceFolder;
        private System.Windows.Forms.TextBox txtResourceFolder;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblColumnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.Button btnSpecifyFeature;
        private System.Windows.Forms.Button btnCreateFeatures;
        private System.Windows.Forms.Label lblFeaturesCreated;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
