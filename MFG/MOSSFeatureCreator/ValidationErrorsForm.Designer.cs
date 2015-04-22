namespace CTFeatureCreator
{
    partial class ValidationErrorsForm
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
            this.grvValidationErrors = new System.Windows.Forms.DataGridView();
            this.ValidationErrorSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvValidationErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grvValidationErrors
            // 
            this.grvValidationErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvValidationErrors.Location = new System.Drawing.Point(12, 12);
            this.grvValidationErrors.Name = "grvValidationErrors";
            this.grvValidationErrors.Size = new System.Drawing.Size(825, 314);
            this.grvValidationErrors.TabIndex = 0;
            // 
            // ValidationErrorSource
            // 
            this.ValidationErrorSource.DataSource = typeof(Library.MFGValidationError);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(782, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 24);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ValidationErrorsForm
            // 
            this.ClientSize = new System.Drawing.Size(849, 365);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grvValidationErrors);
            this.Name = "ValidationErrorsForm";
            this.Text = "Validation Errors";
            ((System.ComponentModel.ISupportInitialize)(this.grvValidationErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvValidationErrors;
        private System.Windows.Forms.BindingSource ValidationErrorSource;
        private System.Windows.Forms.Button btnOK;
    }
}
