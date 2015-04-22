namespace CTFeatureCreator
{
    partial class CTFeatureForm
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
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.lblScope = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSite2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVersion2 = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblContentType = new System.Windows.Forms.Label();
            this.lblFeaturesCreated = new System.Windows.Forms.Label();
            this.chkColumnsFeature = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColumnPath
            // 
            this.lblColumnPath.AutoSize = true;
            this.lblColumnPath.Location = new System.Drawing.Point(45, 288);
            this.lblColumnPath.Name = "lblColumnPath";
            this.lblColumnPath.Size = new System.Drawing.Size(127, 13);
            this.lblColumnPath.TabIndex = 9;
            this.lblColumnPath.Text = "Path to create features to";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(45, 304);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(213, 20);
            this.txtPath.TabIndex = 8;
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(264, 304);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(26, 24);
            this.btnOpenFolderBrowser.TabIndex = 10;
            this.btnOpenFolderBrowser.Text = "...";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // btnCreateFeatures
            // 
            this.btnCreateFeatures.Location = new System.Drawing.Point(45, 365);
            this.btnCreateFeatures.Name = "btnCreateFeatures";
            this.btnCreateFeatures.Size = new System.Drawing.Size(117, 24);
            this.btnCreateFeatures.TabIndex = 11;
            this.btnCreateFeatures.Text = "Create Features";
            this.btnCreateFeatures.UseVisualStyleBackColor = true;
            this.btnCreateFeatures.Click += new System.EventHandler(this.btnCreateFeatures_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(11, 187);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 0;
            this.txtVersion.Text = "1.0.0.0";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(11, 174);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // txtScope
            // 
            this.txtScope.Location = new System.Drawing.Point(11, 140);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(100, 20);
            this.txtScope.TabIndex = 2;
            this.txtScope.Text = "Site";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(11, 124);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(38, 13);
            this.lblScope.TabIndex = 3;
            this.lblScope.Text = "Scope";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 72);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 40);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Decription";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(11, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(213, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblScope);
            this.groupBox1.Controls.Add(this.txtScope);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 234);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTitle2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDescription2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSite2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVersion2);
            this.groupBox2.Location = new System.Drawing.Point(313, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 234);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // txtTitle2
            // 
            this.txtTitle2.Location = new System.Drawing.Point(11, 23);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(213, 20);
            this.txtTitle2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decription";
            // 
            // txtDescription2
            // 
            this.txtDescription2.Location = new System.Drawing.Point(11, 72);
            this.txtDescription2.Multiline = true;
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.Size = new System.Drawing.Size(210, 40);
            this.txtDescription2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Scope";
            // 
            // txtSite2
            // 
            this.txtSite2.Location = new System.Drawing.Point(11, 140);
            this.txtSite2.Name = "txtSite2";
            this.txtSite2.Size = new System.Drawing.Size(100, 20);
            this.txtSite2.TabIndex = 2;
            this.txtSite2.Text = "Site";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version";
            // 
            // txtVersion2
            // 
            this.txtVersion2.Location = new System.Drawing.Point(11, 187);
            this.txtVersion2.Name = "txtVersion2";
            this.txtVersion2.Size = new System.Drawing.Size(100, 20);
            this.txtVersion2.TabIndex = 0;
            this.txtVersion2.Text = "1.0.0.0";
            // 
            // lblColumns
            // 
            this.lblColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(42, 46);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(124, 16);
            this.lblColumns.TabIndex = 14;
            this.lblColumns.Text = "Columns Feature";
            // 
            // lblContentType
            // 
            this.lblContentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContentType.AutoSize = true;
            this.lblContentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentType.Location = new System.Drawing.Point(310, 46);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(157, 16);
            this.lblContentType.TabIndex = 15;
            this.lblContentType.Text = "Content Type Feature";
            // 
            // lblFeaturesCreated
            // 
            this.lblFeaturesCreated.AutoSize = true;
            this.lblFeaturesCreated.ForeColor = System.Drawing.Color.Red;
            this.lblFeaturesCreated.Location = new System.Drawing.Point(181, 371);
            this.lblFeaturesCreated.Name = "lblFeaturesCreated";
            this.lblFeaturesCreated.Size = new System.Drawing.Size(88, 13);
            this.lblFeaturesCreated.TabIndex = 16;
            this.lblFeaturesCreated.Text = "Features Created";
            this.lblFeaturesCreated.Visible = false;
            // 
            // chkColumnsFeature
            // 
            this.chkColumnsFeature.AutoSize = true;
            this.chkColumnsFeature.Checked = true;
            this.chkColumnsFeature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColumnsFeature.Location = new System.Drawing.Point(45, 342);
            this.chkColumnsFeature.Name = "chkColumnsFeature";
            this.chkColumnsFeature.Size = new System.Drawing.Size(139, 17);
            this.chkColumnsFeature.TabIndex = 17;
            this.chkColumnsFeature.Text = "Create Columns Feature";
            this.chkColumnsFeature.UseVisualStyleBackColor = true;
            // 
            // CTFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 433);
            this.Controls.Add(this.chkColumnsFeature);
            this.Controls.Add(this.lblFeaturesCreated);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreateFeatures);
            this.Controls.Add(this.btnOpenFolderBrowser);
            this.Controls.Add(this.lblColumnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CTFeatureForm";
            this.Text = "Content Type Feature Creation";
            this.Load += new System.EventHandler(this.CTFeatureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblColumnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.Button btnCreateFeatures;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSite2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVersion2;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label lblFeaturesCreated;
        private System.Windows.Forms.CheckBox chkColumnsFeature;
    }
}