namespace CTFeatureCreator
{
    partial class SiteColumnForm
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
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblColumnPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.btnSpecifyFeature = new System.Windows.Forms.Button();
            this.btnCreateFeatures = new System.Windows.Forms.Button();
            this.lblFeaturesCreated = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMaxLength = new System.Windows.Forms.Label();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbStaticName = new System.Windows.Forms.Label();
            this.txtStaticName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblColumnPath);
            this.grpAction.Controls.Add(this.txtPath);
            this.grpAction.Controls.Add(this.btnOpenFolderBrowser);
            this.grpAction.Controls.Add(this.btnSpecifyFeature);
            this.grpAction.Controls.Add(this.btnCreateFeatures);
            this.grpAction.Controls.Add(this.lblFeaturesCreated);
            this.grpAction.Location = new System.Drawing.Point(267, 22);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(272, 183);
            this.grpAction.TabIndex = 37;
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
            this.lblFeaturesCreated.Location = new System.Drawing.Point(13, 114);
            this.lblFeaturesCreated.Name = "lblFeaturesCreated";
            this.lblFeaturesCreated.Size = new System.Drawing.Size(88, 13);
            this.lblFeaturesCreated.TabIndex = 16;
            this.lblFeaturesCreated.Text = "Features Created";
            this.lblFeaturesCreated.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDisplayName);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblMaxLength);
            this.groupBox1.Controls.Add(this.txtMaxLength);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbStaticName);
            this.groupBox1.Controls.Add(this.txtStaticName);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 337);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(6, 58);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(69, 13);
            this.lblDisplayName.TabIndex = 23;
            this.lblDisplayName.Text = "DisplayName";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(6, 74);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(213, 20);
            this.txtDisplayName.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 20;
            // 
            // lblMaxLength
            // 
            this.lblMaxLength.AutoSize = true;
            this.lblMaxLength.Location = new System.Drawing.Point(6, 293);
            this.lblMaxLength.Name = "lblMaxLength";
            this.lblMaxLength.Size = new System.Drawing.Size(60, 13);
            this.lblMaxLength.TabIndex = 19;
            this.lblMaxLength.Text = "MaxLength";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(6, 307);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(213, 20);
            this.txtMaxLength.TabIndex = 18;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(6, 195);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 17;
            this.lblGroup.Text = "Group";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(6, 211);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(213, 20);
            this.txtGroup.TabIndex = 16;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 244);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 15;
            this.lblSource.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(6, 259);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(213, 20);
            this.txtSource.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 163);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(213, 20);
            this.txtID.TabIndex = 12;
            // 
            // lbStaticName
            // 
            this.lbStaticName.AutoSize = true;
            this.lbStaticName.Location = new System.Drawing.Point(6, 108);
            this.lbStaticName.Name = "lbStaticName";
            this.lbStaticName.Size = new System.Drawing.Size(62, 13);
            this.lbStaticName.TabIndex = 11;
            this.lbStaticName.Text = "StaticName";
            // 
            // txtStaticName
            // 
            this.txtStaticName.Location = new System.Drawing.Point(6, 124);
            this.txtStaticName.Name = "txtStaticName";
            this.txtStaticName.Size = new System.Drawing.Size(213, 20);
            this.txtStaticName.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Location = new System.Drawing.Point(267, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 142);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(140, 108);
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
            this.btnOK.Location = new System.Drawing.Point(201, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 24);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SiteColumnForm
            // 
            this.ClientSize = new System.Drawing.Size(561, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SiteColumnForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Site Column Definition";
            this.Load += new System.EventHandler(this.SiteColumnForm_Load);
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblColumnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.Button btnSpecifyFeature;
        private System.Windows.Forms.Button btnCreateFeatures;
        private System.Windows.Forms.Label lblFeaturesCreated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxLength;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbStaticName;
        private System.Windows.Forms.TextBox txtStaticName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
