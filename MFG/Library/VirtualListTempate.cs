using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SharePoint;

/*Definition from MSDN
<ListTemplate
    AllowDeletion = "TRUE" | "FALSE"
    AllowEveryoneViewItems = "TRUE" | "FALSE"
    AlwaysIncludeContent = "TRUE" | "FALSE"
  BaseType = "0" | "1" | "2" |"3" | "4"
    CacheSchema = "TRUE" | "FALSE"
  Catalog = "TRUE" | "FALSE"
    Category = "Libraries" | "Communications" | "Tracking" | 
    "Custom Lists"
  Default = "TRUE" | "FALSE"
  Description = "Text"
    DisableAttachments = "TRUE" | "FALSE"
    DisallowContentTypes = "TRUE" | "FALSE"
  DisplayName = "Text"
    DocumentTemplate = "Integer"
  DontSaveInTemplate = "TRUE" | "FALSE"
    EditPage = "Text"
    EnableModeration = "TRUE" | "FALSE"
  FeatureId = "Text"
    FolderCreation = "TRUE" | "FALSE"
  Hidden = "TRUE" | "FALSE"
  HiddenList = "TRUE" | "FALSE"
  Image = "URL"
  MustSaveRootFiles = "TRUE" | "FALSE"
  Name = "Text"
    NewPage = "Text"
    NoCrawl = "TRUE" | "FALSE"
  OnQuickLaunch = "TRUE" | "FALSE"
  Path = "Text"
  RootWebOnly = "TRUE" | "FALSE"
  SecurityBits = "Text"
  Sequence = "Integer"
    SetupPath = "Text"
    SyncType = "Text"
  Type = "Integer"
  Unique = "TRUE" | "FALSE"
    UseRootFolderForNavigation = "TRUE" | "FALSE"
    VersioningEnabled = "TRUE" | "FALSE">
</ListTemplate>

 Attributes 
Attribute  Description  
AllowDeletion 
 Optional Boolean. TRUE to specify that lists created through the template cannot be deleted; otherwise, FALSE.
 
AllowEveryoneViewItems 
 Optional Boolean. TRUE to allow any user to view items in the library. The AllowEveryoneViewItems attribute is used, for example, in the Master Page gallery to give all users access to master pages.
 
AlwaysIncludeContent 
 Optional Boolean. TRUE to specify that list content be included by default when lists created through the template are saved as list templates in the user interface; otherwise, FALSE.
 
BaseType 
 Required Integer. Specifies the base type, or default schema, for lists created from the definition.
 
CacheSchema 
 Optional Boolean. TRUE to enable schema caching of the list when provisioning a site. The CacheSchema attribute is used, for example, in the global Onet.xml file to enable caching of the user list for the current site collection.
 
Catalog 
 Optional Boolean. TRUE to specify that the list definition is for a site gallery, a list gallery, or a Web Part gallery.
 
Category 
 Optional Text. Specifies the category with which to associate lists created through the list definition. Possible values include the following:

Libraries 

Communications 

Tracking 

Custom Lists 
 
Default 
 Optional Boolean. TRUE to specify that new SharePoint sites will include this list.
 
Description 
 Optional Text. Provides a description of the list definition.
 
DisableAttachments 
 Optional Boolean. TRUE to specify that users can attach files to items in lists created through the template; otherwise, FALSE.
 
DisallowContentTypes 
 Optional Boolean. TRUE to specify that content types can be managed on lists created through the template; otherwise, FALSE.
 
DisplayName 
 Required Text. Specifies the display name of the list definition.
 
DocumentTemplate 
 Optional Integer. Currently unused. This is valid only in a ListTemplate element whose BaseType is set to 1 (document libraries). For future compatibility, this should either be blank or correspond to the Type attribute of a DocumentTemplate element in the DocumentTemplates enumeration. [Same as previous version, but deprecated.]
 
DontSaveInTemplate 
 Optional Boolean. TRUE to exclude the content of the list when the list is saved as a custom list template or when the site to which the list belongs is saved as a custom site template through the user interface.
 
EditPage 
 Optional Text. Specifies the name of a custom application page (/_layouts) to use as the page for editing list properties for lists created through the list template.
 
EnableModeration 
 Optional Boolean. TRUE to specify that content approval is enabled by default in lists created through the template; otherwise, FALSE.
 
FeatureId 
 Optional Text. Specifies the GUID that identifies the Feature with which the template is associated.
 
FolderCreation 
 Optional Boolean. TRUE to enable folder creation within the list and to specify that the New Folder command appears on the New menu in list views; otherwise, FALSE.
 
Hidden 
 Optional Boolean. TRUE to specify that the list definition is not available on the Create page for creating lists.
 
HiddenList 
 Optional Boolean. TRUE to specify that a list created from the list definition is hidden.
 
Image 
 Optional URL. Specifies a URL to an icon used to represent a list.
 
MultipleMtgDataList 
 Optional Boolean. If MultipleMtgDataList="TRUE" is specified, the list within a Meeting Workspace site contains data for multiple meeting instances within the site.
 
MustSaveRootFiles 
 Optional Boolean. TRUE to save the pages contained within a special document library that is used internally for a Meeting Workspace site when the list template is saved without content. This attribute is not intended for public use.
 
Name 
 Required Text. Specifies the internal name of the list definition. No spaces or special characters can be used. This name is also used to find the folder that contains the Schema.xml file that defines the schema in use.
 
NewPage 
 Optional Text. Specifies the name of a custom page to use as the page for creating a new list through the list template.
 
NoCrawl 
 Optional Boolean. TRUE to specify that the list not be visible in search results; otherwise, FALSE.
 
OnQuickLaunch 
 Optional Boolean. TRUE to display lists created from the list definition on the Quick Launch bar.
 
Path 
 Optional Text. Specifies the name of the site definition that contains the list definition; for example, STS. This path is assumed to be relative to the 15\TEMPLATE directory. The path can be directed at a Features schema; for example, Features\Announcements. [Same as previous version, but deprecated.]
 
RootWebOnly 
 Optional Boolean. TRUE to specify that the list created from the definition exists only in the root Web site of a site collection. [Same as previous version, but deprecated.]
 
SecurityBits 
 Optional Text. Defines the item-level permissions in the list for users with sufficient permission to read or edit list items. The SecurityBits attribute contains a 2-digit string. The first digit in the string controls the read access; the second digit in the string controls the edit access. For read access, the following are valid digits:

1   Users can read all items.

2   Users can read only their own items.

For edit access, the following are valid digits:

1   Users can edit all items.

2   Users can edit only their own items.

4   Users cannot edit items.

Note:  
Users with the ManageLists permission can read and edit all items, regardless of value of the SecurityBits attribute.
 

This attribute does not apply to document libraries.
 
Sequence 
 Optional Integer. Specifies the ordering priority to use for the list template on the Create page. If Sequence is not set, the template appears last in arbitrary order with any other templates that also lack a Sequence value. Two templates that specify the same sequence are sorted together in an arbitrary order.
 
SetupPath 
 Optional Text. Specifies the path to a folder in the Windows SharePoint Services setup directory (Local_Drive:\\Program Files\Common Files\Microsoft Shared\web server extensions\15\TEMPLATE) that contains a file to include in the template.
 
SyncType 
 Optional Boolean. TRUE to override the default client list type associated with a Windows SharePoint Services base template.
 
Type 
 Optional Integer. Provides a unique identifier for the template. This identifier must be unique within the feature, but need not be unique across all feature definitions or site definitions. The following table lists values for the default list template types. 

Value  Description  
100 
 Generic list
 
101 
 Document library
 
102 
 Survey
 
103 
 Links list
 
104 
 Announcements list
 
105 
 Contacts list
 
106 
 Events list
 
107 
 Tasks list
 
108 
 Discussion board
 
109 
 Picture library
 
110 
 Data sources
 
111 
 Site template gallery
 
112 
 User Information list
 
113 
 Web Part gallery
 
114 
 List template gallery
 
115 
 XML Form library
 
116 
 Master pages gallery
 
117 
 No-Code Workflows
 
118 
 Custom Workflow Process
 
119 
 Wiki Page library
 
120 
 Custom grid for a list
 
130 
 Data Connection library
 
140 
 Workflow History
 
150 
 Gantt Tasks list
 
200 
 Meeting Series list
 
201 
 Meeting Agenda list
 
202 
 Meeting Attendees list
 
204 
 Meeting Decisions list
 
207 
 Meeting Objectives list
 
210 
 Meeting text box
 
211 
 Meeting Things To Bring list
 
212 
 Meeting Workspace Pages list
 
300 
 Portal Sites list
 
301 
 Blog Posts list
 
302 
 Blog Comments list
 
303 
 Blog Categories list
 
1100 
 Issue tracking
 
1200 
 Administrator tasks list
 
2002 
 Personal document library
 
2003 
 Private document library
 

This attribute corresponds to the Type attribute of the List element.
 
Unique 
 Optional Boolean. TRUE to specify that the list definition or list template can be used to create a list only during site creation and cannot be used to create a list through the object model or user interface after the site template or definition is applied. Setting this attribute to TRUE has the effect of making the list hidden so that it does not appear as an option on the Create page or on the Documents and Lists page.
 
UseRootFolderForNavigation 
 Optional Boolean. TRUE to specify that a link to the list that is displayed in Quick Launch points to the root folder so that users go to a custom welcome page, instead of to the default list view page.

Note:  
If a custom welcome URL is not set for the list, rendering a link to the root folder is functionally equivalent to linking to the default list view.
 
 
VersioningEnabled 
 Optional Boolean. TRUE to specify that versioning is enabled by default in lists created through the template; otherwise, FALSE.
 

 Child Elements 
None
 

 * 
 * */



namespace Library
{



    public class VirtualListTemplate : VirtualElement
    {

        SPList originalList;

        public SPList OriginalList
        {
            get { return originalList; }
        }



        int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
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
        Guid id;

        public Guid Id
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



        bool? allowDeletion;

        public bool? AllowDeletion
        {
            get { return allowDeletion; }
            set { allowDeletion = value; }
        }

        bool? allowEveryOneViewItems;

        public bool? AllowEveryOneViewItems
        {
            get { return allowEveryOneViewItems; }
            set { allowEveryOneViewItems = value; }
        }

        bool? alwaysIncludeContent;

        public bool? AlwaysIncludeContent
        {
            get { return alwaysIncludeContent; }
            set { alwaysIncludeContent = value; }
        }

        SPBaseType listBaseType;

        public SPBaseType ListBaseType
        {
            get { return listBaseType; }
            set { listBaseType = value; }
        }

        bool? cacheSchema;

        public bool? CacheSchema
        {
            get { return cacheSchema; }
            set { cacheSchema = value; }
        }

        bool? catalog;

        public bool? Catalog
        {
            get { return catalog; }
            set { catalog = value; }
        }

        ListTemplateCategoryType category;

        public ListTemplateCategoryType Category
        {
            get { return category; }
            set { category = value; }
        }

        bool? defaultValue;

        public bool? DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        string direction;

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        bool? disallowContentTypes;

        public bool? DisallowContentTypes
        {
            get { return disallowContentTypes; }
            set { disallowContentTypes = value; }
        }

        bool? disableAttachments;

        public bool? DisableAttachments
        {
            get { return disableAttachments; }
            set { disableAttachments = value; }
        }

        string  documentTemplate;

        public string  DocumentTemplate
        {
            get { return documentTemplate; }
            set { documentTemplate = value; }
        }

        bool? dontSaveInTemplate;

        public bool? DontSaveInTemplate
        {
            get { return dontSaveInTemplate; }
            set { dontSaveInTemplate = value; }
        }

        string editPage;

        public string EditPage
        {
            get { return editPage; }
            set { editPage = value; }
        }

        bool? enableModeration;

        public bool? EnableModeration
        {
            get { return enableModeration; }
            set { enableModeration = value; }
        }


        bool? folderCreation;

        public bool? FolderCreation
        {
            get { return folderCreation; }
            set { folderCreation = value; }
        }

        bool? hidden;

        public bool? Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }

        bool? hiddenList;

        public bool? HiddenList
        {
            get { return hiddenList; }
            set { hiddenList = value; }
        }

        string image;//URL

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        /* not intended for public use
        bool? mustSaveRootFiles;

        public bool? MustSaveRootFiles
        {
            get { return mustSaveRootFiles; }
            set { mustSaveRootFiles = value; }
        }
         */

        string newPage;

        public string NewPage
        {
            get { return newPage; }
            set { newPage = value; }
        }

        bool? noCrawl;

        public bool? NoCrawl
        {
            get { return noCrawl; }
            set { noCrawl = value; }
        }

        bool? onQuickLaunch;

        public bool? OnQuickLaunch
        {
            get { return onQuickLaunch; }
            set { onQuickLaunch = value; }
        }

        string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        bool rootWebOnly;

        public bool RootWebOnly
        {
            get { return rootWebOnly; }
            set { rootWebOnly = value; }
        }

        string securityBits = "11";

        public string SecurityBits
        {
            get { return securityBits; }
            set { securityBits = value; }
        }

        int? sequence;

        public int? Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        string setupPath;

        public string SetupPath
        {
            get { return setupPath; }
            set { setupPath = value; }
        }

        string syncType;

        public string SyncType
        {
            get { return syncType; }
            set { syncType = value; }
        }

        int? typeVersion;

        public int? TypeVersion
        {
            get { return typeVersion; }
            set { typeVersion = value; }
        }

        bool? unique;

        public bool? Unique
        {
            get { return unique; }
            set { unique = value; }
        }

        bool? useRootFolderForNavigation;

        public bool? UseRootFolderForNavigation
        {
            get { return useRootFolderForNavigation; }
            set { useRootFolderForNavigation = value; }
        }

        bool? versioningEnabled;

        public bool? VersioningEnabled
        {
            get { return versioningEnabled; }
            set { versioningEnabled = value; }
        }


        string setupPathForms;

        public string SetupPathForms
        {
            get { return setupPathForms; }
            set { setupPathForms = value; }
        }

        string setupPathViews;

        public string SetupPathViews
        {
            get { return setupPathViews; }
            set { setupPathViews = value; }
        }

        string webpartZoneID;

        public string WebpartZoneID
        {
            get { return webpartZoneID; }
            set { webpartZoneID = value; }
        }

        string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }



        public VirtualListTemplate(SPList list)
        {
            originalList = list;
            this.allowDeletion = list.AllowDeletion;
            this.allowEveryOneViewItems = list.AllowEveryoneViewItems;
            //this.alwaysIncludeContent
            //this.cacheSchema
            //this.catalog
            //this.category
            //this.DefaultValue
            this.description = list.Description;
            direction = list.Direction;
            //this.disableAttachments=list
            this.disallowContentTypes = !list.AllowContentTypes;
            this.displayName = list.Title;
            this.documentTemplate = XmlHelper.GetAttributeValue(list.SchemaXml, "DocTemplateUrl");
            this.dontSaveInTemplate = list.ExcludeFromTemplate;
            this.webpartZoneID = "Main";
            //this.editPage
            this.enableModeration = list.EnableModeration;
            string guidString = XmlHelper.GetAttributeValue(list.SchemaXml, "FeatureId");
            if (guidString != string.Empty)
            {
                VirtualFeature feature = new VirtualFeature();
                feature.Id = new Guid();
                //this.featureID = new Guid();
            }
            this.folderCreation = list.EnableFolderCreation;
            //this.group
            this.hidden = list.Hidden;
            //this.hiddenList
            this.id = list.ID;
            this.image = list.ImageUrl;
            this.listBaseType = list.BaseType;
            //this.MustSaveRootFiles  not intended for public use
            this.name = list.Title;
            //this.newPage
            this.noCrawl = list.NoCrawl;
            this.onQuickLaunch = list.OnQuickLaunch;
            //this.path
            //this.rootWebOnly
            this.securityBits = list.ReadSecurity.ToString() + list.WriteSecurity.ToString();
            //this.sequence
            //this.setupPath
            //this.syncType;
            this.type = (int)list.BaseTemplate;
            this.versioningEnabled = list.EnableVersioning;

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
