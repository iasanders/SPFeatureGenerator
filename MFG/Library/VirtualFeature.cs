using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /*From MSDN, definition

    <Feature
      ActivateOnDefault = "TRUE" | "FALSE"
      AlwaysForceInstall = "TRUE" | "FALSE"
      AutoActivateInCentralAdmin = "TRUE" | "FALSE"
      Creator = "Text" 
      DefaultResourceFile =  "Text"
      Description = "Text" 
      Hidden = "TRUE" | "FALSE"
      Id = "Text"
      ImageUrl = "Text"
      ImageUrlAltText = "Text"
      ReceiverAssembly = "Text"
      ReceiverClass = "Text"
      RequireResources = "TRUE" | "FALSE"
      Scope = "Text"
      SolutionId = "Text"
      Title = "Text"
      Version = "Text" >
    </Feature>

     Attributes 
    Attribute  Description  
    ActivateOnDefault 
     Optional Boolean. TRUE if the Feature is activated by default during installation or when a Web application is created; FALSE if the Feature is not activated. This attribute equals TRUE by default. The ActivateOnDefault attribute does not apply to site collection (Site) or Web site (Web) scoped Features.

    In general, Farm-scoped Features become activated during installation, and when a new Web application is created, all installed Web application-scoped Features in it become activated.
 
    AlwaysForceInstall 
     Optional Boolean. TRUE if the Feature is installed by force during installation even if the Feature is already installed. For example, if set to TRUE, Feature installation callouts will always fire anytime a user tries to install the Feature (even if it is already installed) by using either the scanforfeatures or installfeature command-line operation. This attribute equals FALSE by default. The AlwaysForceInstall attribute affects Features of all scopes.
 
    AutoActivateInCentralAdmin 
     Optional Boolean. TRUE if the Feature is activated by default in the Administrative Web site, site collection, or Web application. This attribute equals FALSE by default. The AutoActivateInCentralAdmin attribute does not apply to Farm-scoped Features.
 
    Creator 
     Optional Text.
 
    DefaultResourceFile 
     Optional Text. Indicates a common resource file for retrieving Feature XML resources. If you specify a resource in the file, Windows SharePoint Services looks by default in \15\TEMPLATE\FEATURES\FeatureName\Resources\Resources.<Culture>.resx. However, if you want to provide a shared core resource file for all the Features in your application, you can specify an alternate file through which to access resources by using DefaultResourceFile. For example, if you set DefaultResourceFile="MyFile", Windows SharePoint Services looks in \15\Resources\MyFile.<Culture>.resx to retrieve localized resources for your Feature.
 
    Description 
     Optional String. Returns a longer representation of what the Feature does.
 
    Hidden 
     Optional Boolean. This attribute equals FALSE by default.
 
    Id 
     Required Text. Contains the globally unique identifier (GUID) for the Feature.
 
    ImageUrl 
     Optional Text. Contains the site-relative URL for an image to use to represent the feature in the user interface (UI).
 
    ImageUrlAltText 
     Optional Text. Contains the alternate text for the image that represents the feature. 
 
    ReceiverAssembly 
     Optional Text. If set along with ReceiverClass, specifies the strong name of the signed assembly located in the global assembly cache from which to load a receiver to handle Feature events.
 
    ReceiverClass 
     Optional Text. If set along with ReceiverAssembly, specifies the class that implements the Feature event processor.
 
    RequireResources 
     Optional Boolean. TRUE to specify that Windows SharePoint Services check whether resources exist for the Feature by verifying that the standard "sentinel" resource for the Feature is present for a particular culture. 

    The resource file is named according to the format <Feature Directory>\Resources\Resources.<Culture Name>.resx, where <Culture Name> is the name that identifies the culture. Windows SharePoint Services supports the same three formats for culture names that the .NET Framework supports:

    XX-XXX 

    XXX-XX 

    XX-XXXX-XX 

    Culture name examples:

    en-CA English – Canada 

    fr-FR French – France 

    ja-JP Japanese - Japan 

    quz-BO Quechua – Bolivia 

    uz-Latn-UZ Uzbek (Latin, Uzbekistan) 

    uz-Cyrl-UZ Uzbek (Cyrillic, Uzbekistan)

    The Internet Engineering Task Force (IETF) language tag format is ll(l)-Ssss-CC, where:

    ll(l) denotes the required two-letter language identifier (or three-letter if there is no ISO two-letter code for the language). 

    Ssss denotes an optional script identifier.

    CC denotes an optional region identifier.


    The RequireResources attribute allows you to constrict the visibility of certain Features depending on whether resources exist in a particular language for the Feature. 

    Note:  
    Windows SharePoint Services does not use the file specified by the DefaultResourceFile attribute, if there is one, as a backup file for verifying support of a particular language for a feature.
 

    If the file is not present for the language of a particular Web site or site collection, then two behaviors can occur:

    The Feature will be hidden from the user interface for activation of Features in the Web site or site collection if the corresponding resources for the language are not available.

    Keep in mind that the RequireResources attribute is enforced in the user interface only. A Feature without resources for a particular language can still be activated for a Web site through command line operations with stsadm.exe or through the object model.

    Windows SharePoint Services does not enforce RequireResources for Features that are part of a larger site definition. If you supply, for example, a Thai version of a site definition by putting a webtempThai.xml in \15\TEMPLATE\1054\XML, you must verify that each Feature contained in the folder has the appropriate resources.

    In general, Windows SharePoint Services ensures that user interface extension components of the Feature do not show up in Web sites that do not have resources, but there are exceptions. Even if you do a careful job of setting RequireResources and not deploying site definitions unless all Features have resources in them, Features can still show up in sites where resources are not available.

    As an example scenario, assume that you have a custom Feature with resources for two languages that provides custom toolbar buttons and site settings links, and that you have provisioned a new site collection with a root Web site in one of the languages. Then, after downloading and installing the language pack for a third language, you provision a new subsite in this third language under the original root Web site. If RequireResources is not set to TRUE, the custom Feature will attempt to fall back and use fallback resources (in other words, those defined as Resources\Resources.resx, with no culture.)  If there are no fallback resources, Windows SharePoint Services will render empty strings. However, if RequireResources is set to TRUE, user interface extension components of the Feature (for example, those defined through a CustomAction, ListTemplate, or FeatureSiteTemplateAssociation element) will not show up in subsites if no resources are available, so that the custom links and site settings will be automatically hidden.

    Setting this attribute only applies to activating Features through the user interface, and not through STSADM.EXE command-line operations or the object model.
 
    Scope 
     Required Text. Specifies the scope in which the Feature can be activated and contains one of the following values: Farm (farm), WebApplication (Web application), Site (site collection), Web (Web site). For information about scope, see Element Scope.
 
    SolutionId 
     Optional Text. Specifies the solution to which the Feature belongs.
 
    Title 
     Optional Text. Returns the title of the Feature. Limited to 255 characters.
 
    Version 
     Optional Text. Specifies a System.Version-compliant representation of the version of a Feature. This can be up to four numbers delimited by decimals that represent a version.
 

     Child Elements 
    ActivationDependencies, ElementManifests, Properties
 


     * */


    public class VirtualFeature
    {
        private List<Guid> activationDependencies = new List<Guid>();//contains the values of the FeatureId properties
        //of the ActivationDependency elements
        public List<Guid> ActivationDependencies
        {
            get { return activationDependencies; }
            set { activationDependencies = value; }
        }


        private Dictionary<object, VirtualElement> elements = new Dictionary<object, VirtualElement>();

        public Dictionary<object, VirtualElement> Elements
        {
            get { return elements; }
            set { elements = value; }
        }


        private List<string> elementFiles = new List<string>();//contains the values of the location attriute of the ElementFile elements

        public List<string> ElementFiles
        {
            get { return elementFiles; }
            set { elementFiles = value; }
        }

        private List<string> elementManifests = new List<string>();//contains the values of the location attriute of the ElementManifest elements

        public List<string> ElementManifests
        {
            get { return elementManifests; }
            set { elementManifests = value; }
        }

        private Dictionary<string, string> properties = new Dictionary<string, string>();//contains the key-value pairs of the Property elements

        public Dictionary<string, string> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        bool? activateOnDefault;

        public bool? ActivateOnDefault
        {
            get { return activateOnDefault; }
            set { activateOnDefault = value; }
        }

        bool? alwaysForceInstall;

        public bool? AlwaysForceInstall
        {
            get { return alwaysForceInstall; }
            set { alwaysForceInstall = value; }
        }

        bool? autoActivateInCentralAdmin;

        public bool? AutoActivateInCentralAdmin
        {
            get { return autoActivateInCentralAdmin; }
            set { autoActivateInCentralAdmin = value; }
        }

        string creator;

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        string defaultResourceFile;

        public string DefaultResourceFile
        {
            get { return defaultResourceFile; }
            set { defaultResourceFile = value; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        bool? hidden;

        public bool? Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }

        Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        string imageUrlAltText;

        public string ImageUrlAltText
        {
            get { return imageUrlAltText; }
            set { imageUrlAltText = value; }
        }

        string receiverAssembly;

        public string ReceiverAssembly
        {
            get { return receiverAssembly; }
            set { receiverAssembly = value; }
        }

        string receiverClass;

        public string ReceiverClass
        {
            get { return receiverClass; }
            set { receiverClass = value; }
        }

        bool? requireResources;

        public bool? RequireResources
        {
            get { return requireResources; }
            set { requireResources = value; }
        }

        FeatureScope scope;

        public FeatureScope Scope
        {
            get { return scope; }
            set { scope = value; }
        }

        string solutionId;

        public string SolutionId
        {
            get { return solutionId; }
            set { solutionId = value; }
        }

        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }




    }
}
