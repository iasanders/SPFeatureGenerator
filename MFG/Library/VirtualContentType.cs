using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SharePoint;
using System.Collections.Generic;

/*

<ContentType
  BaseType="Text"
  ID="Text"
  Name="Text"
  Group="Text"
  DocumentTemplate="Text"
  ResourceFolder="Text"
  ReadOnly="TRUE" | "FALSE"
  Hidden="TRUE" | "FALSE"
  Description="Text"
  Sealed="TRUE" | "FALSE"
  V2ListTemplateName="Text"
  Version="Integer"
  FeatureId="Text">
</ContentTypes>

 * 
 * Attributes 
Attribute  Description  
BaseType 
 Reserved for internal use. 
 
ID 
 Required Text. Specifies the content type ID of the content type.
 
Name 
 Required Text. Specifies the content type name.
 
Group 
 Optional Text. Specifies the content type group to which the content type is assigned. Content type groups are user-defined groups that help you organize your columns into logical categories.
 
DocumentTemplate 
 Obsolete.
 
ResourceFolder 
 Obsolete.
 
ReadOnly 
 Optional Boolean. TRUE to define the content type as read-only.

If you do not include this attribute, Windows SharePoint Services treats the content type as if this attributes was set to FALSE.
 
Hidden 
 Optional Boolean. TRUE to define the content type as hidden. If you define a content type as hidden, Windows SharePoint Services does not display that content type on the New button in list views.

If you do not include this attribute, Windows SharePoint Services treats the content type as if this attributes was set to FALSE.
 
Description 
 Optional Text. Provides a description for the content type, to display in the Windows SharePoint Services user interface.
 
Sealed 
 Optional Boolean. TRUE to define the content type as sealed. You must have site collection administrator rights to unseal and edit a content type defined as sealed.

If you do not include this attribute, Windows SharePoint Services treats the content type as if this attributes was set to FALSE.
 
V2ListTemplateName 
 Optional Text. Specifies the Windows SharePoint Services 2.0 list template type to which this content type maps. For example, the Document content type maps to the Document Library list template.
 
Version 
 Reserved for future use.
 
FeatureId 
 Optional Text. Provides the ID of the feature in which the content type is packaged.
 

 Child Elements 
FieldRefs Element (ContentType) 
 
Folder Element (ContentType) 
 
Forms Element (ContentType) 
 
XmlDocuments Element (ContentType) 
 
DocumentTemplate Element (ContentType) 




 * 
 * 
 * 
 * 
 */


namespace Library
{
    public class VirtualContentType : VirtualElement
    {
        private SPContentType originalContentType;
        private List<VirtualField> fields=new List<VirtualField>();

        //TODO: add support for:
        //Folder Element (ContentType) 
        //Forms Element (ContentType) 
        //XmlDocuments Element (ContentType) 
        //DocumentTemplate Element (ContentType) 

        public List<VirtualField> Fields
        {
            get { return fields; }
            set { fields = value; }
        }


        public SPContentType OriginalContentType
        {
            get { return originalContentType; }
        }


        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        string group;
        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        bool? hidden;

        public bool? Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }


        private bool? readOnly;

        public bool? ReadOnly
        {
          get { return readOnly; }
          set { readOnly = value; }
        }

        private bool? sealedField;

        public bool? Sealed
        {
            get { return sealedField; }
            set { sealedField = value; }
        }



        private string resourceFolder;

        public string ResourceFolder
        {
            get { return resourceFolder; }
            set { resourceFolder = value; }
        }

        
        public VirtualContentType(SPContentType contentType)
        {
            originalContentType = contentType;

            description = contentType.Description;
            group = contentType.Group;
            id = contentType.Id.ToString();
            name = contentType.Name;
            hidden = contentType.Hidden;
            //this.featureID
            this.readOnly = contentType.ReadOnly;
            this.sealedField = contentType.Sealed;
            this.resourceFolder=contentType.ResourceFolder.Name;
            
            foreach(SPField field in contentType.Fields)
                fields.Add(new VirtualField(field));


        }

        public override string ToString()
        {
            return Name;
        }

        public override object GetKey()
        {
            return id;
        }



    }
}
