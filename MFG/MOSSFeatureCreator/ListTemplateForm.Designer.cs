namespace CTFeatureCreator
{
    partial class ListTemplateForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblColumnPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.btnCreateFeatures = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNoCrawl = new System.Windows.Forms.CheckBox();
            this.chkOnQuickLaunch = new System.Windows.Forms.CheckBox();
            this.chkEnableModeration = new System.Windows.Forms.CheckBox();
            this.chkVersioningEnabled = new System.Windows.Forms.CheckBox();
            this.chkDisallowContentTypes = new System.Windows.Forms.CheckBox();
            this.chkFolderCreation = new System.Windows.Forms.CheckBox();
            this.chkAllowEveryoneViewItems = new System.Windows.Forms.CheckBox();
            this.chkAllowDeletion = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblSecurityBits = new System.Windows.Forms.Label();
            this.txtSecurityBits = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblTemplateID = new System.Windows.Forms.Label();
            this.txtTemplateID = new System.Windows.Forms.TextBox();
            this.lblFeaturesCreated = new System.Windows.Forms.Label();
            this.lblContentTypes = new System.Windows.Forms.Label();
            this.lstContentTypes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFieldRefs = new System.Windows.Forms.ListBox();
            this.lblFeature = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpSchemaInner = new System.Windows.Forms.GroupBox();
            this.lblSetupPathForms = new System.Windows.Forms.Label();
            this.txtSetupPathForms = new System.Windows.Forms.TextBox();
            this.lblSetupPath = new System.Windows.Forms.Label();
            this.txtSetupPath = new System.Windows.Forms.TextBox();
            this.lblWebpartZoneID = new System.Windows.Forms.Label();
            this.txtWebpartZoneID = new System.Windows.Forms.TextBox();
            this.lblListUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.chkOverrideDefaults = new System.Windows.Forms.CheckBox();
            this.lblSchema = new System.Windows.Forms.Label();
            this.btnSpecifyFeature = new System.Windows.Forms.Button();
            this.grpForms = new System.Windows.Forms.GroupBox();
            this.chkLoadForms = new System.Windows.Forms.CheckBox();
            this.lblForms = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpSchemaInner.SuspendLayout();
            this.grpForms.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 72);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 40);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Decription";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(269, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNoCrawl);
            this.groupBox1.Controls.Add(this.chkOnQuickLaunch);
            this.groupBox1.Controls.Add(this.chkEnableModeration);
            this.groupBox1.Controls.Add(this.chkVersioningEnabled);
            this.groupBox1.Controls.Add(this.chkDisallowContentTypes);
            this.groupBox1.Controls.Add(this.chkFolderCreation);
            this.groupBox1.Controls.Add(this.chkAllowEveryoneViewItems);
            this.groupBox1.Controls.Add(this.chkAllowDeletion);
            this.groupBox1.Controls.Add(this.chkHidden);
            this.groupBox1.Controls.Add(this.lblDisplayName);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.lblSecurityBits);
            this.groupBox1.Controls.Add(this.txtSecurityBits);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.lblTemplateID);
            this.groupBox1.Controls.Add(this.txtTemplateID);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 573);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // chkNoCrawl
            // 
            this.chkNoCrawl.AutoSize = true;
            this.chkNoCrawl.Checked = true;
            this.chkNoCrawl.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkNoCrawl.Location = new System.Drawing.Point(6, 499);
            this.chkNoCrawl.Name = "chkNoCrawl";
            this.chkNoCrawl.Size = new System.Drawing.Size(66, 17);
            this.chkNoCrawl.TabIndex = 23;
            this.chkNoCrawl.Text = "NoCrawl";
            this.chkNoCrawl.ThreeState = true;
            this.chkNoCrawl.UseVisualStyleBackColor = true;
            // 
            // chkOnQuickLaunch
            // 
            this.chkOnQuickLaunch.AutoSize = true;
            this.chkOnQuickLaunch.Checked = true;
            this.chkOnQuickLaunch.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkOnQuickLaunch.Location = new System.Drawing.Point(6, 545);
            this.chkOnQuickLaunch.Name = "chkOnQuickLaunch";
            this.chkOnQuickLaunch.Size = new System.Drawing.Size(104, 17);
            this.chkOnQuickLaunch.TabIndex = 24;
            this.chkOnQuickLaunch.Text = "OnQuickLaunch";
            this.chkOnQuickLaunch.ThreeState = true;
            this.chkOnQuickLaunch.UseVisualStyleBackColor = true;
            // 
            // chkEnableModeration
            // 
            this.chkEnableModeration.AutoSize = true;
            this.chkEnableModeration.Checked = true;
            this.chkEnableModeration.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEnableModeration.Location = new System.Drawing.Point(6, 476);
            this.chkEnableModeration.Name = "chkEnableModeration";
            this.chkEnableModeration.Size = new System.Drawing.Size(112, 17);
            this.chkEnableModeration.TabIndex = 21;
            this.chkEnableModeration.Text = "EnableModeration";
            this.chkEnableModeration.ThreeState = true;
            this.chkEnableModeration.UseVisualStyleBackColor = true;
            // 
            // chkVersioningEnabled
            // 
            this.chkVersioningEnabled.AutoSize = true;
            this.chkVersioningEnabled.Checked = true;
            this.chkVersioningEnabled.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkVersioningEnabled.Location = new System.Drawing.Point(6, 522);
            this.chkVersioningEnabled.Name = "chkVersioningEnabled";
            this.chkVersioningEnabled.Size = new System.Drawing.Size(114, 17);
            this.chkVersioningEnabled.TabIndex = 22;
            this.chkVersioningEnabled.Text = "VersioningEnabled";
            this.chkVersioningEnabled.ThreeState = true;
            this.chkVersioningEnabled.UseVisualStyleBackColor = true;
            // 
            // chkDisallowContentTypes
            // 
            this.chkDisallowContentTypes.AutoSize = true;
            this.chkDisallowContentTypes.Checked = true;
            this.chkDisallowContentTypes.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkDisallowContentTypes.Location = new System.Drawing.Point(6, 407);
            this.chkDisallowContentTypes.Name = "chkDisallowContentTypes";
            this.chkDisallowContentTypes.Size = new System.Drawing.Size(131, 17);
            this.chkDisallowContentTypes.TabIndex = 19;
            this.chkDisallowContentTypes.Text = "DisallowContentTypes";
            this.chkDisallowContentTypes.ThreeState = true;
            this.chkDisallowContentTypes.UseVisualStyleBackColor = true;
            // 
            // chkFolderCreation
            // 
            this.chkFolderCreation.AutoSize = true;
            this.chkFolderCreation.Checked = true;
            this.chkFolderCreation.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFolderCreation.Location = new System.Drawing.Point(6, 453);
            this.chkFolderCreation.Name = "chkFolderCreation";
            this.chkFolderCreation.Size = new System.Drawing.Size(94, 17);
            this.chkFolderCreation.TabIndex = 20;
            this.chkFolderCreation.Text = "FolderCreation";
            this.chkFolderCreation.ThreeState = true;
            this.chkFolderCreation.UseVisualStyleBackColor = true;
            // 
            // chkAllowEveryoneViewItems
            // 
            this.chkAllowEveryoneViewItems.AutoSize = true;
            this.chkAllowEveryoneViewItems.Checked = true;
            this.chkAllowEveryoneViewItems.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAllowEveryoneViewItems.Location = new System.Drawing.Point(6, 384);
            this.chkAllowEveryoneViewItems.Name = "chkAllowEveryoneViewItems";
            this.chkAllowEveryoneViewItems.Size = new System.Drawing.Size(144, 17);
            this.chkAllowEveryoneViewItems.TabIndex = 16;
            this.chkAllowEveryoneViewItems.Text = "AllowEveryoneViewItems";
            this.chkAllowEveryoneViewItems.ThreeState = true;
            this.chkAllowEveryoneViewItems.UseVisualStyleBackColor = true;
            // 
            // chkAllowDeletion
            // 
            this.chkAllowDeletion.AutoSize = true;
            this.chkAllowDeletion.Checked = true;
            this.chkAllowDeletion.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAllowDeletion.Location = new System.Drawing.Point(6, 361);
            this.chkAllowDeletion.Name = "chkAllowDeletion";
            this.chkAllowDeletion.Size = new System.Drawing.Size(90, 17);
            this.chkAllowDeletion.TabIndex = 17;
            this.chkAllowDeletion.Text = "AllowDeletion";
            this.chkAllowDeletion.ThreeState = true;
            this.chkAllowDeletion.UseVisualStyleBackColor = true;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Checked = true;
            this.chkHidden.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkHidden.Location = new System.Drawing.Point(6, 430);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 18;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.ThreeState = true;
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(3, 259);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(69, 13);
            this.lblDisplayName.TabIndex = 13;
            this.lblDisplayName.Text = "DisplayName";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(3, 275);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(269, 20);
            this.txtDisplayName.TabIndex = 12;
            // 
            // lblSecurityBits
            // 
            this.lblSecurityBits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecurityBits.AutoSize = true;
            this.lblSecurityBits.Location = new System.Drawing.Point(1, 217);
            this.lblSecurityBits.Name = "lblSecurityBits";
            this.lblSecurityBits.Size = new System.Drawing.Size(62, 13);
            this.lblSecurityBits.TabIndex = 11;
            this.lblSecurityBits.Text = "SecurityBits";
            // 
            // txtSecurityBits
            // 
            this.txtSecurityBits.Location = new System.Drawing.Point(1, 233);
            this.txtSecurityBits.Name = "txtSecurityBits";
            this.txtSecurityBits.Size = new System.Drawing.Size(269, 20);
            this.txtSecurityBits.TabIndex = 10;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 176);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(3, 192);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(269, 20);
            this.txtType.TabIndex = 8;
            // 
            // lblTemplateID
            // 
            this.lblTemplateID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTemplateID.AutoSize = true;
            this.lblTemplateID.Location = new System.Drawing.Point(3, 124);
            this.lblTemplateID.Name = "lblTemplateID";
            this.lblTemplateID.Size = new System.Drawing.Size(55, 13);
            this.lblTemplateID.TabIndex = 5;
            this.lblTemplateID.Text = "BaseType";
            // 
            // txtTemplateID
            // 
            this.txtTemplateID.Location = new System.Drawing.Point(3, 140);
            this.txtTemplateID.Name = "txtTemplateID";
            this.txtTemplateID.Size = new System.Drawing.Size(269, 20);
            this.txtTemplateID.TabIndex = 4;
            // 
            // lblFeaturesCreated
            // 
            this.lblFeaturesCreated.AutoSize = true;
            this.lblFeaturesCreated.ForeColor = System.Drawing.Color.Red;
            this.lblFeaturesCreated.Location = new System.Drawing.Point(13, 111);
            this.lblFeaturesCreated.Name = "lblFeaturesCreated";
            this.lblFeaturesCreated.Size = new System.Drawing.Size(88, 13);
            this.lblFeaturesCreated.TabIndex = 16;
            this.lblFeaturesCreated.Text = "Features Created";
            this.lblFeaturesCreated.Visible = false;
            // 
            // lblContentTypes
            // 
            this.lblContentTypes.AutoSize = true;
            this.lblContentTypes.Location = new System.Drawing.Point(621, 190);
            this.lblContentTypes.Name = "lblContentTypes";
            this.lblContentTypes.Size = new System.Drawing.Size(76, 13);
            this.lblContentTypes.TabIndex = 22;
            this.lblContentTypes.Text = "Content Types";
            // 
            // lstContentTypes
            // 
            this.lstContentTypes.Enabled = false;
            this.lstContentTypes.FormattingEnabled = true;
            this.lstContentTypes.HorizontalScrollbar = true;
            this.lstContentTypes.Location = new System.Drawing.Point(624, 206);
            this.lstContentTypes.Name = "lstContentTypes";
            this.lstContentTypes.Size = new System.Drawing.Size(275, 121);
            this.lstContentTypes.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Field Refs";
            // 
            // lstFieldRefs
            // 
            this.lstFieldRefs.Enabled = false;
            this.lstFieldRefs.FormattingEnabled = true;
            this.lstFieldRefs.HorizontalScrollbar = true;
            this.lstFieldRefs.Location = new System.Drawing.Point(624, 43);
            this.lstFieldRefs.Name = "lstFieldRefs";
            this.lstFieldRefs.Size = new System.Drawing.Size(275, 121);
            this.lstFieldRefs.TabIndex = 23;
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature.Location = new System.Drawing.Point(10, 9);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(51, 13);
            this.lblFeature.TabIndex = 27;
            this.lblFeature.Text = "General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpSchemaInner);
            this.groupBox2.Controls.Add(this.chkOverrideDefaults);
            this.groupBox2.Location = new System.Drawing.Point(321, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 355);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // grpSchemaInner
            // 
            this.grpSchemaInner.Controls.Add(this.lblSetupPathForms);
            this.grpSchemaInner.Controls.Add(this.txtSetupPathForms);
            this.grpSchemaInner.Controls.Add(this.lblSetupPath);
            this.grpSchemaInner.Controls.Add(this.txtSetupPath);
            this.grpSchemaInner.Controls.Add(this.lblWebpartZoneID);
            this.grpSchemaInner.Controls.Add(this.txtWebpartZoneID);
            this.grpSchemaInner.Controls.Add(this.lblListUrl);
            this.grpSchemaInner.Controls.Add(this.txtUrl);
            this.grpSchemaInner.Location = new System.Drawing.Point(7, 7);
            this.grpSchemaInner.Name = "grpSchemaInner";
            this.grpSchemaInner.Size = new System.Drawing.Size(268, 288);
            this.grpSchemaInner.TabIndex = 31;
            this.grpSchemaInner.TabStop = false;
            // 
            // lblSetupPathForms
            // 
            this.lblSetupPathForms.AutoSize = true;
            this.lblSetupPathForms.Location = new System.Drawing.Point(1, 226);
            this.lblSetupPathForms.Name = "lblSetupPathForms";
            this.lblSetupPathForms.Size = new System.Drawing.Size(99, 13);
            this.lblSetupPathForms.TabIndex = 17;
            this.lblSetupPathForms.Text = "SetupPath in Forms";
            // 
            // txtSetupPathForms
            // 
            this.txtSetupPathForms.Enabled = false;
            this.txtSetupPathForms.Location = new System.Drawing.Point(3, 242);
            this.txtSetupPathForms.Name = "txtSetupPathForms";
            this.txtSetupPathForms.Size = new System.Drawing.Size(259, 20);
            this.txtSetupPathForms.TabIndex = 16;
            // 
            // lblSetupPath
            // 
            this.lblSetupPath.AutoSize = true;
            this.lblSetupPath.Location = new System.Drawing.Point(4, 101);
            this.lblSetupPath.Name = "lblSetupPath";
            this.lblSetupPath.Size = new System.Drawing.Size(99, 13);
            this.lblSetupPath.TabIndex = 15;
            this.lblSetupPath.Text = "SetupPath in Views";
            // 
            // txtSetupPath
            // 
            this.txtSetupPath.Enabled = false;
            this.txtSetupPath.Location = new System.Drawing.Point(6, 117);
            this.txtSetupPath.Name = "txtSetupPath";
            this.txtSetupPath.Size = new System.Drawing.Size(256, 20);
            this.txtSetupPath.TabIndex = 14;
            // 
            // lblWebpartZoneID
            // 
            this.lblWebpartZoneID.AutoSize = true;
            this.lblWebpartZoneID.Location = new System.Drawing.Point(4, 150);
            this.lblWebpartZoneID.Name = "lblWebpartZoneID";
            this.lblWebpartZoneID.Size = new System.Drawing.Size(126, 13);
            this.lblWebpartZoneID.TabIndex = 13;
            this.lblWebpartZoneID.Text = "WebpartZoneID in Views";
            // 
            // txtWebpartZoneID
            // 
            this.txtWebpartZoneID.Enabled = false;
            this.txtWebpartZoneID.Location = new System.Drawing.Point(6, 166);
            this.txtWebpartZoneID.Name = "txtWebpartZoneID";
            this.txtWebpartZoneID.Size = new System.Drawing.Size(256, 20);
            this.txtWebpartZoneID.TabIndex = 12;
            // 
            // lblListUrl
            // 
            this.lblListUrl.AutoSize = true;
            this.lblListUrl.Location = new System.Drawing.Point(4, 17);
            this.lblListUrl.Name = "lblListUrl";
            this.lblListUrl.Size = new System.Drawing.Size(37, 13);
            this.lblListUrl.TabIndex = 11;
            this.lblListUrl.Text = "List url";
            // 
            // txtUrl
            // 
            this.txtUrl.Enabled = false;
            this.txtUrl.Location = new System.Drawing.Point(6, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(256, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // chkOverrideDefaults
            // 
            this.chkOverrideDefaults.AutoSize = true;
            this.chkOverrideDefaults.Location = new System.Drawing.Point(10, 307);
            this.chkOverrideDefaults.Name = "chkOverrideDefaults";
            this.chkOverrideDefaults.Size = new System.Drawing.Size(106, 17);
            this.chkOverrideDefaults.TabIndex = 10;
            this.chkOverrideDefaults.Text = "Override defaults";
            this.chkOverrideDefaults.UseVisualStyleBackColor = true;
            this.chkOverrideDefaults.CheckedChanged += new System.EventHandler(this.chkOverrideDefaults_CheckedChanged);
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchema.Location = new System.Drawing.Point(322, 10);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(52, 13);
            this.lblSchema.TabIndex = 29;
            this.lblSchema.Text = "Schema";
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
            // grpForms
            // 
            this.grpForms.Controls.Add(this.chkLoadForms);
            this.grpForms.Location = new System.Drawing.Point(321, 407);
            this.grpForms.Name = "grpForms";
            this.grpForms.Size = new System.Drawing.Size(281, 185);
            this.grpForms.TabIndex = 31;
            this.grpForms.TabStop = false;
            // 
            // chkLoadForms
            // 
            this.chkLoadForms.AutoSize = true;
            this.chkLoadForms.Location = new System.Drawing.Point(14, 25);
            this.chkLoadForms.Name = "chkLoadForms";
            this.chkLoadForms.Size = new System.Drawing.Size(125, 17);
            this.chkLoadForms.TabIndex = 33;
            this.chkLoadForms.Text = "Load Forms from Site";
            this.chkLoadForms.UseVisualStyleBackColor = true;
            // 
            // lblForms
            // 
            this.lblForms.AutoSize = true;
            this.lblForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForms.Location = new System.Drawing.Point(322, 393);
            this.lblForms.Name = "lblForms";
            this.lblForms.Size = new System.Drawing.Size(40, 13);
            this.lblForms.TabIndex = 32;
            this.lblForms.Text = "Forms";
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblColumnPath);
            this.grpAction.Controls.Add(this.txtPath);
            this.grpAction.Controls.Add(this.btnOpenFolderBrowser);
            this.grpAction.Controls.Add(this.btnSpecifyFeature);
            this.grpAction.Controls.Add(this.btnCreateFeatures);
            this.grpAction.Controls.Add(this.lblFeaturesCreated);
            this.grpAction.Location = new System.Drawing.Point(624, 338);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(279, 151);
            this.grpAction.TabIndex = 33;
            this.grpAction.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Location = new System.Drawing.Point(624, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 93);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(147, 59);
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
            this.btnOK.Location = new System.Drawing.Point(208, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 24);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ListTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.lblForms);
            this.Controls.Add(this.grpForms);
            this.Controls.Add(this.lblSchema);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFeature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFieldRefs);
            this.Controls.Add(this.lblContentTypes);
            this.Controls.Add(this.lstContentTypes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListTemplateForm";
            this.Text = "ListTemplate Definition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFeatureForm_FormClosing);
            this.Load += new System.EventHandler(this.ListFeatureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSchemaInner.ResumeLayout(false);
            this.grpSchemaInner.PerformLayout();
            this.grpForms.ResumeLayout(false);
            this.grpForms.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblColumnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.Button btnCreateFeatures;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFeaturesCreated;
        private System.Windows.Forms.Label lblTemplateID;
        private System.Windows.Forms.TextBox txtTemplateID;
        private System.Windows.Forms.Label lblContentTypes;
        private System.Windows.Forms.ListBox lstContentTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFieldRefs;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.GroupBox grpSchemaInner;
        private System.Windows.Forms.Label lblSetupPathForms;
        private System.Windows.Forms.TextBox txtSetupPathForms;
        private System.Windows.Forms.Label lblSetupPath;
        private System.Windows.Forms.TextBox txtSetupPath;
        private System.Windows.Forms.Label lblWebpartZoneID;
        private System.Windows.Forms.TextBox txtWebpartZoneID;
        private System.Windows.Forms.Label lblListUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.CheckBox chkOverrideDefaults;
        private System.Windows.Forms.Button btnSpecifyFeature;
        private System.Windows.Forms.GroupBox grpForms;
        private System.Windows.Forms.CheckBox chkLoadForms;
        private System.Windows.Forms.Label lblForms;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblSecurityBits;
        private System.Windows.Forms.TextBox txtSecurityBits;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.CheckBox chkDisallowContentTypes;
        private System.Windows.Forms.CheckBox chkFolderCreation;
        private System.Windows.Forms.CheckBox chkAllowEveryoneViewItems;
        private System.Windows.Forms.CheckBox chkAllowDeletion;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkNoCrawl;
        private System.Windows.Forms.CheckBox chkOnQuickLaunch;
        private System.Windows.Forms.CheckBox chkEnableModeration;
        private System.Windows.Forms.CheckBox chkVersioningEnabled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}