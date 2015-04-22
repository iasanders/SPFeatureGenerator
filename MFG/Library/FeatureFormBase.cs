using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public class FeatureFormBase:Form
    {
        string formID;


        public string FormID
        {
            get { return formID; }
            set { formID = value; }
        }

        protected bool? ToNullableBool(CheckState checkState)
        {
            if (checkState == CheckState.Indeterminate)
                return null;
            else if (checkState == CheckState.Checked)
                return true;
            else
                return false;
        }


        protected CheckState ToCheckState(bool? nullableBool)
        {
            if (nullableBool == null)
                return CheckState.Indeterminate;
            else if (nullableBool == true)
                return CheckState.Checked;
            else
                return CheckState.Unchecked;
        }



    }
}
