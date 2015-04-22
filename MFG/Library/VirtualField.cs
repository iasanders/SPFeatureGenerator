using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SharePoint;

/*

<Field
  ID="Text"
  Group="Text"
  MaxLength="Text"
  SourceID="Text"
  StaticName="Text"
/>

 Attributes 
Attribute  Description  
ID 
 Required Text. Specifies the GUID of the field.
 
Group 
 Optional Text. Specified the site column group to which this site column belongs. 
 
MaxLength 
 Optional Integer. Specifies the maximum number of characters allowed in a field value. Edit forms are adjusted to enforce this value, which is validated on the client. If the user attempts to enter more than the number of characters set by MaxLength, an error message appears.
 
SourceID 
 Optional Text. Contains the namespace that defines the field, such as http://schemas.microsoft.com/sharepoint/v3, or the GUID of the list in which the custom field was created.
 
StaticName 
 Optional Text. Contains the internal name of the field.
 
But other fields are:
Type (Required!)
Name
DisplayName
* 
 * */


namespace Library
{
    public class VirtualField : VirtualElement
    {

        SPField originalField;

        public SPField OriginalField
        {
            get { return originalField; }
        }

        int? maxLength;

        public int? MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; }
        }

        string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        string sourceID;

        public string SourceID
        {
            get { return sourceID; }
            set { sourceID = value; }
        }
        string staticName;

        public string StaticName
        {
            get { return staticName; }
            set { staticName = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }




        public VirtualField(SPField field)
        {
            originalField = field;

            //maxLength
            group = field.Group;
            id = field.Id;
            sourceID = field.SourceId;
            staticName = field.StaticName;
            name = field.Title;
        }

        public override string ToString()
        {
            return StaticName;
        }

        public override object GetKey()
        {
            return id;
        }
    }


}
