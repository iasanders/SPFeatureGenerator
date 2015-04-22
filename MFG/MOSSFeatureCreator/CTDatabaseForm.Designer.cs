namespace CTFeatureCreator
{
    partial class CTDatabaseForm
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
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.lblSiteColumns = new System.Windows.Forms.Label();
            this.lblContentTypes = new System.Windows.Forms.Label();
            this.lstContentTypes = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstColumns
            // 
            this.lstColumns.Enabled = false;
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.HorizontalScrollbar = true;
            this.lstColumns.Location = new System.Drawing.Point(24, 250);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(479, 173);
            this.lstColumns.TabIndex = 3;
            // 
            // lblSiteColumns
            // 
            this.lblSiteColumns.AutoSize = true;
            this.lblSiteColumns.Location = new System.Drawing.Point(24, 234);
            this.lblSiteColumns.Name = "lblSiteColumns";
            this.lblSiteColumns.Size = new System.Drawing.Size(68, 13);
            this.lblSiteColumns.TabIndex = 4;
            this.lblSiteColumns.Text = "Site Columns";
            // 
            // lblContentTypes
            // 
            this.lblContentTypes.AutoSize = true;
            this.lblContentTypes.Location = new System.Drawing.Point(24, 12);
            this.lblContentTypes.Name = "lblContentTypes";
            this.lblContentTypes.Size = new System.Drawing.Size(76, 13);
            this.lblContentTypes.TabIndex = 6;
            this.lblContentTypes.Text = "Content Types";
            // 
            // lstContentTypes
            // 
            this.lstContentTypes.FormattingEnabled = true;
            this.lstContentTypes.HorizontalScrollbar = true;
            this.lstContentTypes.Location = new System.Drawing.Point(24, 31);
            this.lstContentTypes.Name = "lstContentTypes";
            this.lstContentTypes.Size = new System.Drawing.Size(479, 173);
            this.lstContentTypes.TabIndex = 5;
            this.lstContentTypes.SelectedIndexChanged += new System.EventHandler(this.lstContentTypes_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(444, 439);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CTDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 469);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblContentTypes);
            this.Controls.Add(this.lstContentTypes);
            this.Controls.Add(this.lblSiteColumns);
            this.Controls.Add(this.lstColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CTDatabaseForm";
            this.Text = "Content Type Feature Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstColumns;
        private System.Windows.Forms.Label lblSiteColumns;
        private System.Windows.Forms.Label lblContentTypes;
        private System.Windows.Forms.ListBox lstContentTypes;
        private System.Windows.Forms.Button btnNext;
    }
}

