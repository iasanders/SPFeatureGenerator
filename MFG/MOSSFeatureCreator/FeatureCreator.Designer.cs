namespace CTFeatureCreator
{
    partial class FeatureCreator
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentTypeFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listInstanceFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTAndColumnsFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(992, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Visible = false;
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem1,
            this.contentTypeFeatureToolStripMenuItem,
            this.listFeatureToolStripMenuItem,
            this.listInstanceFeatureToolStripMenuItem,
            this.cTAndColumnsFromDatabaseToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // featureToolStripMenuItem1
            // 
            this.featureToolStripMenuItem1.Name = "featureToolStripMenuItem1";
            this.featureToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.featureToolStripMenuItem1.Text = "Columns Feature";
            this.featureToolStripMenuItem1.Click += new System.EventHandler(this.featureToolStripMenuItem1_Click);
            // 
            // contentTypeFeatureToolStripMenuItem
            // 
            this.contentTypeFeatureToolStripMenuItem.Name = "contentTypeFeatureToolStripMenuItem";
            this.contentTypeFeatureToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.contentTypeFeatureToolStripMenuItem.Text = "Content Type Feature";
            this.contentTypeFeatureToolStripMenuItem.Click += new System.EventHandler(this.contentTypeFeatureToolStripMenuItem_Click);
            // 
            // listFeatureToolStripMenuItem
            // 
            this.listFeatureToolStripMenuItem.Name = "listFeatureToolStripMenuItem";
            this.listFeatureToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listFeatureToolStripMenuItem.Text = "ListTemplate Feature";
            this.listFeatureToolStripMenuItem.Click += new System.EventHandler(this.listFeatureToolStripMenuItem_Click);
            // 
            // listInstanceFeatureToolStripMenuItem
            // 
            this.listInstanceFeatureToolStripMenuItem.Name = "listInstanceFeatureToolStripMenuItem";
            this.listInstanceFeatureToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listInstanceFeatureToolStripMenuItem.Text = "ListInstance Feature";
            this.listInstanceFeatureToolStripMenuItem.Click += new System.EventHandler(this.listInstanceFeatureToolStripMenuItem_Click);
            // 
            // cTAndColumnsFromDatabaseToolStripMenuItem
            // 
            this.cTAndColumnsFromDatabaseToolStripMenuItem.Name = "cTAndColumnsFromDatabaseToolStripMenuItem";
            this.cTAndColumnsFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.cTAndColumnsFromDatabaseToolStripMenuItem.Text = "CT and Columns from Database";
            this.cTAndColumnsFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.cTAndColumnsFromDatabaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem1.Text = "Build";
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.siteToolStripMenuItem.Text = "Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem2.Text = "Data";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.ToolTipText = "Set up a connection to the content database";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FeatureCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 773);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FeatureCreator";
            this.Text = "Feature Generator";
            this.Load += new System.EventHandler(this.FeatureCreator_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentTypeFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listInstanceFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTAndColumnsFromDatabaseToolStripMenuItem;
    }
}