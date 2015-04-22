using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using Library;


namespace CTFeatureCreator
{
    public partial class ValidationErrorsForm : Library.FeatureFormBase
    {
        private List<MFGValidationError> validationErrors = new List<MFGValidationError>();

        public List<MFGValidationError> ValidationErrors
        {
            get { return validationErrors; }
            set 
            { 
                validationErrors = value;
                ValidationErrorSource.DataSource=validationErrors;
                grvValidationErrors.DataSource = ValidationErrorSource;
                grvValidationErrors.Refresh();
            }
        }

        public ValidationErrorsForm()
        {
            InitializeComponent();

        }




    }
}

