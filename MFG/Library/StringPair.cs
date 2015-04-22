using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class StringPair : object
    {
        private string name = "";
        private string value = "";

        public StringPair(string nameString, string valueString)
        {
            name = nameString;
            value = valueString;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
