using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library;

namespace CTFeatureCreator
{
    public partial class ListInstanceForm : Library.FeatureFormBase
    {
        private VirtualListInstance virtualListInstance;



        public VirtualListInstance VirtualListInstance
        {
            get { return virtualListInstance; }
            set { virtualListInstance = value; }
        }


        public ListInstanceForm()
        {
            InitializeComponent();
        }
    }
}

