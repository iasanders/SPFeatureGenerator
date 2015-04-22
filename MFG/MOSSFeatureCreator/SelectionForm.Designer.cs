namespace CTFeatureCreator
{
    partial class SelectionForm
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
            this.components = new System.ComponentModel.Container();
            this.lbItems = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSiteUrl = new System.Windows.Forms.Label();
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.cboWebs = new System.Windows.Forms.ComboBox();
            this.ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.Location = new System.Drawing.Point(382, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(32, 13);
            this.lbItems.TabIndex = 6;
            this.lbItems.Text = "Items";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.HorizontalScrollbar = true;
            this.lstItems.Location = new System.Drawing.Point(385, 28);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(293, 160);
            this.lstItems.TabIndex = 5;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstLists_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(619, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSiteUrl
            // 
            this.lblSiteUrl.AutoSize = true;
            this.lblSiteUrl.Location = new System.Drawing.Point(9, 12);
            this.lblSiteUrl.Name = "lblSiteUrl";
            this.lblSiteUrl.Size = new System.Drawing.Size(87, 13);
            this.lblSiteUrl.TabIndex = 10;
            this.lblSiteUrl.Text = "SiteCollection Url";
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.Location = new System.Drawing.Point(12, 28);
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(339, 20);
            this.txtSiteUrl.TabIndex = 11;
            this.txtSiteUrl.Leave += new System.EventHandler(this.txtSiteUrl_Leave);
            // 
            // cboWebs
            // 
            this.cboWebs.FormattingEnabled = true;
            this.cboWebs.Location = new System.Drawing.Point(12, 83);
            this.cboWebs.Name = "cboWebs";
            this.cboWebs.Size = new System.Drawing.Size(198, 21);
            this.cboWebs.TabIndex = 12;
            this.cboWebs.SelectedIndexChanged += new System.EventHandler(this.cboWebs_SelectedIndexChanged);
            // 
            // ListBindingSource
            // 
            this.ListBindingSource.DataSource = typeof(Microsoft.SharePoint.SPList);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(9, 67);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 13;
            this.lblSite.Text = "Site";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 239);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cboWebs);
            this.Controls.Add(this.txtSiteUrl);
            this.Controls.Add(this.lblSiteUrl);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lstItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectionForm";
            this.Text = "Feature Selection";
            this.Load += new System.EventHandler(this.ListSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSiteUrl;
        private System.Windows.Forms.TextBox txtSiteUrl;
        private System.Windows.Forms.ComboBox cboWebs;
        private System.Windows.Forms.BindingSource ListBindingSource;
        private System.Windows.Forms.Label lblSite;
    }
}

