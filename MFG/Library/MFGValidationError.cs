using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;


namespace Library
{
    public class MFGValidationError
    {
        private string message="";

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string filePath="";

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private int lineNumber = 0;

        public int LineNumber
        {
            get { return lineNumber; }
            set { lineNumber = value; }
        }
        private int linePostion = 0;

        public int LinePostion
        {
            get { return linePostion; }
            set { linePostion = value; }
        }
        private XmlSchemaException schemaException;

        public XmlSchemaException SchemaException
        {
            get { return schemaException; }
            set { schemaException = value; }
        }
        private string additionalInformation = "";

        public string AdditionalInformation
        {
            get { return additionalInformation; }
            set { additionalInformation = value; }
        }
        
        public MFGValidationError(ValidationEventArgs e, string xmlFilePath)
        {
            filePath = xmlFilePath;
            message = e.Message;
            schemaException = e.Exception;
            lineNumber = e.Exception.LineNumber;
            linePostion = e.Exception.LinePosition;
            additionalInformation = e.Exception.Message;

        }

    }
}
