namespace CTFeatureCreator
{
    partial class GeneralSelectionForm
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
            this.trvVirtualSite = new System.Windows.Forms.TreeView();
            this.trvOriginalSite = new System.Windows.Forms.TreeView();
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.lblSiteUrl = new System.Windows.Forms.Label();
            this.btnGoSite = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.cboWebs = new System.Windows.Forms.ComboBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnSchemaValidationErrors = new System.Windows.Forms.Button();
            this.lblColumnPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.btnCreateAllFeatures = new System.Windows.Forms.Button();
            this.lblFeaturesCreated = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvVirtualSite
            // 
            this.trvVirtualSite.Location = new System.Drawing.Point(433, 141);
            this.trvVirtualSite.Name = "trvVirtualSite";
            this.trvVirtualSite.Size = new System.Drawing.Size(509, 396);
            this.trvVirtualSite.TabIndex = 0;
            this.trvVirtualSite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trvVirtualSite_MouseDoubleClick);
            this.trvVirtualSite.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvVirtualSite_DragDrop);
            this.trvVirtualSite.DragOver += new System.Windows.Forms.DragEventHandler(this.trvVirtualSite_DragOver);
            this.trvVirtualSite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trvVirtualSite_MouseUp);
            this.trvVirtualSite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvVirtualSite_MouseDown);
            // 
            // trvOriginalSite
            // 
            this.trvOriginalSite.Location = new System.Drawing.Point(12, 141);
            this.trvOriginalSite.Name = "trvOriginalSite";
            this.trvOriginalSite.Size = new System.Drawing.Size(402, 396);
            this.trvOriginalSite.TabIndex = 2;
            this.trvOriginalSite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvOriginalSite_MouseDown);
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.Location = new System.Drawing.Point(6, 32);
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(339, 20);
            this.txtSiteUrl.TabIndex = 13;
            // 
            // lblSiteUrl
            // 
            this.lblSiteUrl.AutoSize = true;
            this.lblSiteUrl.Location = new System.Drawing.Point(3, 16);
            this.lblSiteUrl.Name = "lblSiteUrl";
            this.lblSiteUrl.Size = new System.Drawing.Size(87, 13);
            this.lblSiteUrl.TabIndex = 12;
            this.lblSiteUrl.Text = "SiteCollection Url";
            // 
            // btnGoSite
            // 
            this.btnGoSite.Location = new System.Drawing.Point(351, 32);
            this.btnGoSite.Name = "btnGoSite";
            this.btnGoSite.Size = new System.Drawing.Size(36, 20);
            this.btnGoSite.TabIndex = 14;
            this.btnGoSite.Text = "Go";
            this.btnGoSite.UseVisualStyleBackColor = true;
            this.btnGoSite.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(6, 69);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 16;
            this.lblSite.Text = "Site";
            // 
            // cboWebs
            // 
            this.cboWebs.FormattingEnabled = true;
            this.cboWebs.Location = new System.Drawing.Point(6, 85);
            this.cboWebs.Name = "cboWebs";
            this.cboWebs.Size = new System.Drawing.Size(198, 21);
            this.cboWebs.TabIndex = 15;
            this.cboWebs.SelectedIndexChanged += new System.EventHandler(this.cboWebs_SelectedIndexChanged);
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnSchemaValidationErrors);
            this.grpAction.Controls.Add(this.lblColumnPath);
            this.grpAction.Controls.Add(this.txtPath);
            this.grpAction.Controls.Add(this.btnOpenFolderBrowser);
            this.grpAction.Controls.Add(this.btnCreateAllFeatures);
            this.grpAction.Controls.Add(this.lblFeaturesCreated);
            this.grpAction.Location = new System.Drawing.Point(433, 12);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(509, 92);
            this.grpAction.TabIndex = 34;
            this.grpAction.TabStop = false;
            // 
            // btnSchemaValidationErrors
            // 
            this.btnSchemaValidationErrors.Enabled = false;
            this.btnSchemaValidationErrors.Location = new System.Drawing.Point(340, 58);
            this.btnSchemaValidationErrors.Name = "btnSchemaValidationErrors";
            this.btnSchemaValidationErrors.Size = new System.Drawing.Size(163, 23);
            this.btnSchemaValidationErrors.TabIndex = 17;
            this.btnSchemaValidationErrors.Text = "Show Schema Validation Errors";
            this.btnSchemaValidationErrors.UseVisualStyleBackColor = true;
            this.btnSchemaValidationErrors.Click += new System.EventHandler(this.btnSchemaValidationErrors_Click);
            // 
            // lblColumnPath
            // 
            this.lblColumnPath.AutoSize = true;
            this.lblColumnPath.Location = new System.Drawing.Point(8, 19);
            this.lblColumnPath.Name = "lblColumnPath";
            this.lblColumnPath.Size = new System.Drawing.Size(127, 13);
            this.lblColumnPath.TabIndex = 9;
            this.lblColumnPath.Text = "Path to create features to";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 35);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(289, 20);
            this.txtPath.TabIndex = 8;
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(306, 34);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(26, 20);
            this.btnOpenFolderBrowser.TabIndex = 10;
            this.btnOpenFolderBrowser.Text = "...";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // btnCreateAllFeatures
            // 
            this.btnCreateAllFeatures.Enabled = false;
            this.btnCreateAllFeatures.Location = new System.Drawing.Point(340, 31);
            this.btnCreateAllFeatures.Name = "btnCreateAllFeatures";
            this.btnCreateAllFeatures.Size = new System.Drawing.Size(163, 24);
            this.btnCreateAllFeatures.TabIndex = 11;
            this.btnCreateAllFeatures.Text = "Create Features";
            this.btnCreateAllFeatures.UseVisualStyleBackColor = true;
            this.btnCreateAllFeatures.Click += new System.EventHandler(this.btnCreateFeatures);
            // 
            // lblFeaturesCreated
            // 
            this.lblFeaturesCreated.AutoSize = true;
            this.lblFeaturesCreated.ForeColor = System.Drawing.Color.Red;
            this.lblFeaturesCreated.Location = new System.Drawing.Point(8, 63);
            this.lblFeaturesCreated.Name = "lblFeaturesCreated";
            this.lblFeaturesCreated.Size = new System.Drawing.Size(88, 13);
            this.lblFeaturesCreated.TabIndex = 16;
            this.lblFeaturesCreated.Text = "Features Created";
            this.lblFeaturesCreated.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSiteUrl);
            this.groupBox1.Controls.Add(this.lblSiteUrl);
            this.groupBox1.Controls.Add(this.lblSite);
            this.groupBox1.Controls.Add(this.btnGoSite);
            this.groupBox1.Controls.Add(this.cboWebs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 117);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Rebuild from Virtual Site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneralSelectionForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.trvOriginalSite);
            this.Controls.Add(this.trvVirtualSite);
            this.Name = "GeneralSelectionForm";
            this.Text = "GeneralSelectionForm";
            this.Load += new System.EventHandler(this.GeneralSelectionForm_Load);
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvVirtualSite;
        private System.Windows.Forms.TreeView trvOriginalSite;
        private System.Windows.Forms.TextBox txtSiteUrl;
        private System.Windows.Forms.Label lblSiteUrl;
        private System.Windows.Forms.Button btnGoSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cboWebs;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblColumnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.Button btnCreateAllFeatures;
        private System.Windows.Forms.Label lblFeaturesCreated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSchemaValidationErrors;
    }
}