using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SharePoint;

/*
From MSDN, definition
<ListInstance
  Description = "Text"
  FeatureId = "Text"
  Id = Integer
  OnQuickLaunch = "TRUE" | "FALSE"
  QuickLaunchUrl = "Text"
  RootWebOnly = "TRUE" | "FALSE"
  TemplateType = Integer
  Title = "Text"
  Url = "Text"
</ListInstance>

 Attributes 
Attribute  Description  
Description 
 Optional Text. Contains a description of the list.
 
FeatureId 
 Required Text. Specifies the GUID of the Feature. If you do not specify a Feature GUID, Windows SharePoint Services uses the ID of the default Feature, in other words, the one containing the ListInstance element. If the list template for the list instance is contained within a different Feature, you must specify the ID of that Feature through the FeatureId attribute. 
 
Id 
 Required Integer. Specifies a unique identifier for the list instance. The integer must be unique across the Feature definition.
 
OnQuickLaunch 
 Optional Boolean. TRUE to display lists created from the list definition on the Quick Launch bar.
 
QuickLaunchUrl 
 Optional Text. Specifies the URL of the view page to open for the list through Quick Launch navigation.
 
RootWebOnly 
 Optional Boolean. TRUE to specify that the list created from the definition exists only in the root Web site of a site collection.
 
TemplateType 
 Required Integer. Returns the integer identifier of the list template to use.
 
Title 
 Required Text. Title of the list in the schema.
 
Url 
 Required Text. Returns the site-relative URL at which to place the list.
 

 Child Elements 
Data 
 

 
 * */



namespace Library
{
    public class VirtualListInstance : VirtualElement
    {

        private SPList originalList;

        //TODO: <Data><Rows><Row><Field> support

        public SPList OriginalList
        {
            get { return originalList; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private Guid featureId;

        public Guid FeatureId
        {
            get { return featureId; }
            set { featureId = value; }
        }



        private int iD = 0;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private bool? onQuickLaunch;

        public bool? OnQuickLaunch
        {
            get { return onQuickLaunch; }
            set { onQuickLaunch = value; }
        }

        private string quickLaunchUrl;

        public string QuickLaunchUrl
        {
            get { return quickLaunchUrl; }
            set { quickLaunchUrl = value; }
        }

        private bool? rootWebOnly;

        public bool? RootWebOnly
        {
            get { return rootWebOnly; }
            set { rootWebOnly = value; }
        }

        private int templateType;

        public int TemplateType
        {
            get { return templateType; }
            set { templateType = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }


        public VirtualListInstance(SPList list)
        {
            originalList = list;
            this.description = list.Description;
            this.featureId=list.TemplateFeatureId;
            this.iD = 1;
            this.onQuickLaunch = list.OnQuickLaunch;
            this.quickLaunchUrl = list.DefaultViewUrl;
            //this.rootWebOnly
            this.templateType = (int)list.BaseTemplate;
            this.title = list.Title;
        }

        public override string ToString()
        {
            return Title;
        }

        public override object GetKey()
        {
            return iD;
        }
    }


}
