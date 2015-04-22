namespace CTFeatureCreator
{
    partial class FeatureForm
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
            this.btnNewGuid = new System.Windows.Forms.Button();
            this.lblFeatureID = new System.Windows.Forms.Label();
            this.txtFeatureID = new System.Windows.Forms.TextBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblScope = new System.Windows.Forms.Label();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtSolutionID = new System.Windows.Forms.TextBox();
            this.lblSolutionID = new System.Windows.Forms.Label();
            this.chkActivateOnDefault = new System.Windows.Forms.CheckBox();
            this.lblImgeUrl = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReceiverClass = new System.Windows.Forms.Label();
            this.chkAutoActivateInCentralAdmin = new System.Windows.Forms.CheckBox();
            this.chkRequireResources = new System.Windows.Forms.CheckBox();
            this.txtReceiverClass = new System.Windows.Forms.TextBox();
            this.chkAllwaysForceInstall = new System.Windows.Forms.CheckBox();
            this.lblImageUrlAltText = new System.Windows.Forms.Label();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.txtImageUrlAltText = new System.Windows.Forms.TextBox();
            this.lblDefaultResourceFile = new System.Windows.Forms.Label();
            this.txtDefaultResourceFile = new System.Windows.Forms.TextBox();
            this.lblReceiverAssembly = new System.Windows.Forms.Label();
            this.txtReceiverAssembly = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewGuid);
            this.groupBox1.Controls.Add(this.lblFeatureID);
            this.groupBox1.Controls.Add(this.txtFeatureID);
            this.groupBox1.Controls.Add(this.lblCreator);
            this.groupBox1.Controls.Add(this.txtCreator);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lblScope);
            this.groupBox1.Controls.Add(this.txtScope);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.txtSolutionID);
            this.groupBox1.Controls.Add(this.lblSolutionID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 394);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnNewGuid
            // 
            this.btnNewGuid.Location = new System.Drawing.Point(237, 233);
            this.btnNewGuid.Name = "btnNewGuid";
            this.btnNewGuid.Size = new System.Drawing.Size(38, 23);
            this.btnNewGuid.TabIndex = 10;
            this.btnNewGuid.Text = "New";
            this.btnNewGuid.UseVisualStyleBackColor = true;
            this.btnNewGuid.Click += new System.EventHandler(this.btnNewGuid_Click);
            // 
            // lblFeatureID
            // 
            this.lblFeatureID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFeatureID.AutoSize = true;
            this.lblFeatureID.Location = new System.Drawing.Point(6, 215);
            this.lblFeatureID.Name = "lblFeatureID";
            this.lblFeatureID.Size = new System.Drawing.Size(54, 13);
            this.lblFeatureID.TabIndex = 9;
            this.lblFeatureID.Text = "FeatureID";
            // 
            // txtFeatureID
            // 
            this.txtFeatureID.Location = new System.Drawing.Point(6, 235);
            this.txtFeatureID.Name = "txtFeatureID";
            this.txtFeatureID.Size = new System.Drawing.Size(225, 20);
            this.txtFeatureID.TabIndex = 8;
            // 
            // lblCreator
            // 
            this.lblCreator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(6, 262);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(41, 13);
            this.lblCreator.TabIndex = 5;
            this.lblCreator.Text = "Creator";
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(6, 282);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(269, 20);
            this.txtCreator.TabIndex = 4;
            this.txtCreator.TextChanged += new System.EventHandler(this.txtCreator_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(269, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Decription";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 74);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 40);
            this.txtDescription.TabIndex = 4;
            // 
            // lblScope
            // 
            this.lblScope.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(6, 121);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(38, 13);
            this.lblScope.TabIndex = 3;
            this.lblScope.Text = "Scope";
            // 
            // txtScope
            // 
            this.txtScope.Location = new System.Drawing.Point(6, 141);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(100, 20);
            this.txtScope.TabIndex = 2;
            this.txtScope.Text = "Site";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(6, 168);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(6, 188);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 0;
            this.txtVersion.Text = "1.0.0.0";
            // 
            // txtSolutionID
            // 
            this.txtSolutionID.Location = new System.Drawing.Point(6, 329);
            this.txtSolutionID.Name = "txtSolutionID";
            this.txtSolutionID.Size = new System.Drawing.Size(269, 20);
            this.txtSolutionID.TabIndex = 6;
            // 
            // lblSolutionID
            // 
            this.lblSolutionID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSolutionID.AutoSize = true;
            this.lblSolutionID.Location = new System.Drawing.Point(6, 309);
            this.lblSolutionID.Name = "lblSolutionID";
            this.lblSolutionID.Size = new System.Drawing.Size(56, 13);
            this.lblSolutionID.TabIndex = 7;
            this.lblSolutionID.Text = "SolutionID";
            // 
            // chkActivateOnDefault
            // 
            this.chkActivateOnDefault.AutoSize = true;
            this.chkActivateOnDefault.Checked = true;
            this.chkActivateOnDefault.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkActivateOnDefault.Location = new System.Drawing.Point(6, 270);
            this.chkActivateOnDefault.Name = "chkActivateOnDefault";
            this.chkActivateOnDefault.Size = new System.Drawing.Size(113, 17);
            this.chkActivateOnDefault.TabIndex = 11;
            this.chkActivateOnDefault.Text = "ActivateOnDefault";
            this.chkActivateOnDefault.ThreeState = true;
            this.chkActivateOnDefault.UseVisualStyleBackColor = true;
            // 
            // lblImgeUrl
            // 
            this.lblImgeUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImgeUrl.AutoSize = true;
            this.lblImgeUrl.Location = new System.Drawing.Point(6, 154);
            this.lblImgeUrl.Name = "lblImgeUrl";
            this.lblImgeUrl.Size = new System.Drawing.Size(61, 13);
            this.lblImgeUrl.TabIndex = 7;
            this.lblImgeUrl.Text = "Image URL";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(6, 175);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(269, 20);
            this.txtImageUrl.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReceiverClass);
            this.groupBox2.Controls.Add(this.lblImgeUrl);
            this.groupBox2.Controls.Add(this.chkAutoActivateInCentralAdmin);
            this.groupBox2.Controls.Add(this.chkRequireResources);
            this.groupBox2.Controls.Add(this.txtReceiverClass);
            this.groupBox2.Controls.Add(this.chkAllwaysForceInstall);
            this.groupBox2.Controls.Add(this.txtImageUrl);
            this.groupBox2.Controls.Add(this.chkActivateOnDefault);
            this.groupBox2.Controls.Add(this.lblImageUrlAltText);
            this.groupBox2.Controls.Add(this.chkHidden);
            this.groupBox2.Controls.Add(this.txtImageUrlAltText);
            this.groupBox2.Controls.Add(this.lblDefaultResourceFile);
            this.groupBox2.Controls.Add(this.txtDefaultResourceFile);
            this.groupBox2.Controls.Add(this.lblReceiverAssembly);
            this.groupBox2.Controls.Add(this.txtReceiverAssembly);
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 394);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lblReceiverClass
            // 
            this.lblReceiverClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiverClass.AutoSize = true;
            this.lblReceiverClass.Location = new System.Drawing.Point(6, 56);
            this.lblReceiverClass.Name = "lblReceiverClass";
            this.lblReceiverClass.Size = new System.Drawing.Size(75, 13);
            this.lblReceiverClass.TabIndex = 17;
            this.lblReceiverClass.Text = "ReceiverClass";
            // 
            // chkAutoActivateInCentralAdmin
            // 
            this.chkAutoActivateInCentralAdmin.AutoSize = true;
            this.chkAutoActivateInCentralAdmin.Location = new System.Drawing.Point(6, 316);
            this.chkAutoActivateInCentralAdmin.Name = "chkAutoActivateInCentralAdmin";
            this.chkAutoActivateInCentralAdmin.Size = new System.Drawing.Size(158, 17);
            this.chkAutoActivateInCentralAdmin.TabIndex = 13;
            this.chkAutoActivateInCentralAdmin.Text = "AutoActivateInCentralAdmin";
            this.chkAutoActivateInCentralAdmin.ThreeState = true;
            this.chkAutoActivateInCentralAdmin.UseVisualStyleBackColor = true;
            // 
            // chkRequireResources
            // 
            this.chkRequireResources.AutoSize = true;
            this.chkRequireResources.Location = new System.Drawing.Point(6, 362);
            this.chkRequireResources.Name = "chkRequireResources";
            this.chkRequireResources.Size = new System.Drawing.Size(114, 17);
            this.chkRequireResources.TabIndex = 15;
            this.chkRequireResources.Text = "RequireResources";
            this.chkRequireResources.ThreeState = true;
            this.chkRequireResources.UseVisualStyleBackColor = true;
            // 
            // txtReceiverClass
            // 
            this.txtReceiverClass.Location = new System.Drawing.Point(6, 77);
            this.txtReceiverClass.Name = "txtReceiverClass";
            this.txtReceiverClass.Size = new System.Drawing.Size(269, 20);
            this.txtReceiverClass.TabIndex = 16;
            // 
            // chkAllwaysForceInstall
            // 
            this.chkAllwaysForceInstall.AutoSize = true;
            this.chkAllwaysForceInstall.Location = new System.Drawing.Point(6, 293);
            this.chkAllwaysForceInstall.Name = "chkAllwaysForceInstall";
            this.chkAllwaysForceInstall.Size = new System.Drawing.Size(115, 17);
            this.chkAllwaysForceInstall.TabIndex = 11;
            this.chkAllwaysForceInstall.Text = "AllwaysForceInstall";
            this.chkAllwaysForceInstall.ThreeState = true;
            this.chkAllwaysForceInstall.UseVisualStyleBackColor = true;
            // 
            // lblImageUrlAltText
            // 
            this.lblImageUrlAltText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImageUrlAltText.AutoSize = true;
            this.lblImageUrlAltText.Location = new System.Drawing.Point(6, 203);
            this.lblImageUrlAltText.Name = "lblImageUrlAltText";
            this.lblImageUrlAltText.Size = new System.Drawing.Size(82, 13);
            this.lblImageUrlAltText.TabIndex = 7;
            this.lblImageUrlAltText.Text = "ImageUrlAltText";
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(6, 339);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 12;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.ThreeState = true;
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // txtImageUrlAltText
            // 
            this.txtImageUrlAltText.Location = new System.Drawing.Point(6, 224);
            this.txtImageUrlAltText.Name = "txtImageUrlAltText";
            this.txtImageUrlAltText.Size = new System.Drawing.Size(269, 20);
            this.txtImageUrlAltText.TabIndex = 6;
            // 
            // lblDefaultResourceFile
            // 
            this.lblDefaultResourceFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDefaultResourceFile.AutoSize = true;
            this.lblDefaultResourceFile.Location = new System.Drawing.Point(6, 7);
            this.lblDefaultResourceFile.Name = "lblDefaultResourceFile";
            this.lblDefaultResourceFile.Size = new System.Drawing.Size(103, 13);
            this.lblDefaultResourceFile.TabIndex = 9;
            this.lblDefaultResourceFile.Text = "DefaultResourceFile";
            // 
            // txtDefaultResourceFile
            // 
            this.txtDefaultResourceFile.Location = new System.Drawing.Point(6, 28);
            this.txtDefaultResourceFile.Name = "txtDefaultResourceFile";
            this.txtDefaultResourceFile.Size = new System.Drawing.Size(269, 20);
            this.txtDefaultResourceFile.TabIndex = 8;
            // 
            // lblReceiverAssembly
            // 
            this.lblReceiverAssembly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReceiverAssembly.AutoSize = true;
            this.lblReceiverAssembly.Location = new System.Drawing.Point(6, 105);
            this.lblReceiverAssembly.Name = "lblReceiverAssembly";
            this.lblReceiverAssembly.Size = new System.Drawing.Size(94, 13);
            this.lblReceiverAssembly.TabIndex = 5;
            this.lblReceiverAssembly.Text = "ReceiverAssembly";
            // 
            // txtReceiverAssembly
            // 
            this.txtReceiverAssembly.Location = new System.Drawing.Point(6, 126);
            this.txtReceiverAssembly.Name = "txtReceiverAssembly";
            this.txtReceiverAssembly.Size = new System.Drawing.Size(269, 20);
            this.txtReceiverAssembly.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(555, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 24);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(494, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 24);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 449);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FeatureForm";
            this.Text = "Feature Definition Form";
            this.Load += new System.EventHandler(this.FeatureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActivateOnDefault;
        private System.Windows.Forms.Button btnNewGuid;
        private System.Windows.Forms.Label lblImgeUrl;
        private System.Windows.Forms.Label lblFeatureID;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.TextBox txtFeatureID;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAllwaysForceInstall;
        private System.Windows.Forms.Label lblImageUrlAltText;
        private System.Windows.Forms.Label lblDefaultResourceFile;
        private System.Windows.Forms.TextBox txtImageUrlAltText;
        private System.Windows.Forms.TextBox txtDefaultResourceFile;
        private System.Windows.Forms.Label lblReceiverAssembly;
        private System.Windows.Forms.TextBox txtReceiverAssembly;
        private System.Windows.Forms.Label lblSolutionID;
        private System.Windows.Forms.TextBox txtSolutionID;
        private System.Windows.Forms.CheckBox chkRequireResources;
        private System.Windows.Forms.CheckBox chkAutoActivateInCentralAdmin;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Label lblReceiverClass;
        private System.Windows.Forms.TextBox txtReceiverClass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}