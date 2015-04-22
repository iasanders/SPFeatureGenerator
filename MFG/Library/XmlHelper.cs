using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.SharePoint;
using System.Net;
using System.Windows.Forms;
using System.Xml.Schema;


namespace Library
{
    public static class XmlHelper
    {

        private static string ALLITEMSFORM = "AllItems.aspx";
        private static string DISPFORM = "DispForm.aspx";
        private static string NEWITEMFORM = "NewForm.aspx";
        private static string EDITITEMFORM = "EditForm.aspx";
        private static List<MFGValidationError> validationErrors = new List<MFGValidationError>();
        private static string xsdPath;
        private static string currentXmlFile = "";

        public static string XsdPath
        {
            get { return XmlHelper.xsdPath; }
            set { XmlHelper.xsdPath = value; }
        }


        public static List<MFGValidationError> ValidationErrors
        {
            get { return XmlHelper.validationErrors; }
            set { XmlHelper.validationErrors = value; }
        }

        /// <summary>
        /// Returns the name of an element
        /// </summary>
        /// <param name="xmlElementString">The element as a string</param>
        /// <returns>Returns the name of an element</returns>
        public static string GetElementName(string xmlElementString)
        {
            XPathNodeIterator it = GetRootNodeIteratorFromString(xmlElementString);
            string retVal = it.Current.Name;
            return retVal;
        }

        /// <summary>
        /// Return the value of an attribute
        /// </summary>
        /// <param name="xmlElementString">An xml element as a string</param>
        /// <param name="attributeName">The name of the attribute</param>
        /// <returns>The value of the specified attribute</returns>
        public static string GetAttributeValue(string xmlElementString, string attributeName)
        {
            XPathNodeIterator it=GetRootNodeIteratorFromString(xmlElementString);
            return it.Current.GetAttribute(attributeName,"");
        }

        //Gets an XPathNodeIterator pointing to the root node of an xml element
        public static XPathNodeIterator GetRootNodeIteratorFromString(string xmlElementString)
        {
            StringReader sr=new StringReader(xmlElementString);
            XPathDocument xd = new XPathDocument(sr);
            XPathNavigator xn = xd.CreateNavigator();
            XPathNodeIterator it = xn.SelectChildren(XPathNodeType.Element);
            it.MoveNext();
            return it;
        }

        public static void CreateMultipleColumnsFeature(VirtualField[] virtualFields, VirtualFeature virtualFeature, string path)
        {
            Directory.CreateDirectory(path);

            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");

            StringBuilder sb=new StringBuilder();
            foreach (VirtualField virtualField in virtualFields)
            {
                sb.Append(CreateFieldNode(xmldoc, virtualField));

            }

            xmlelem.InnerXml = sb.ToString();
            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");

            ValidateXml(path + "\\elements.xml");

            CreateFeatureFile(virtualFeature, true, path);
        }


        public static void CreateColumnFeature(VirtualField virtualField, VirtualFeature virtualFeature, string path)
        {
            Directory.CreateDirectory(path);

            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");
            xmlelem.InnerXml = CreateFieldNode(xmldoc, virtualField);
            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");

            ValidateXml(path + "\\elements.xml");
            CreateFeatureFile(virtualFeature, true, path);
        }

        private static string CreateFieldNode(XmlDocument xmlDocument, VirtualField virtualField)
        {
            XmlElement dummyNode = xmlDocument.CreateElement("dummy");
            dummyNode.InnerXml=virtualField.OriginalField.SchemaXml;
            XmlElement fieldNode = (XmlElement)dummyNode.LastChild;
            fieldNode.SetAttribute("xmlns", "http://schemas.microsoft.com/sharepoint/");
            if (virtualField.Name != String.Empty)
                fieldNode.SetAttribute("Name", virtualField.Name);
            else if((virtualField.StaticName != String.Empty))
                fieldNode.SetAttribute("Name", virtualField.StaticName);
            else
                throw new ApplicationException("No Name or StaticName for VirtualField: "+virtualField.OriginalField.SchemaXml);

            if (virtualField.DisplayName != String.Empty)
                fieldNode.SetAttribute("DisplayName", virtualField.DisplayName);
            if (virtualField.StaticName != String.Empty)
                fieldNode.SetAttribute("StaticName", virtualField.StaticName);
            if (virtualField.Group != String.Empty)
                fieldNode.SetAttribute("Group", virtualField.Group);
            fieldNode.SetAttribute("ID", virtualField.Id.ToString("B"));
            if (virtualField.MaxLength.HasValue)
                fieldNode.SetAttribute("MaxLength", virtualField.MaxLength.ToString());
            if (virtualField.SourceID != String.Empty)
                fieldNode.SetAttribute("SourceID", virtualField.SourceID);

            //remove illegal attributes
            fieldNode.RemoveAttribute("WebId");
            fieldNode.RemoveAttribute("Version");
            fieldNode.RemoveAttribute("UserSelectionMode");
            fieldNode.RemoveAttribute("UserSelectionScope");

            string xml=CleanFeatureXml(dummyNode.InnerXml);
            return xml;

        }



        public static void CreateContentTypeFeature(VirtualContentType virtualContenttype, VirtualFeature virtualFeature, string path, bool createDependentColumnsfeature)
        {
            Directory.CreateDirectory(path);

            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");

            xmlelem.InnerXml = virtualContenttype.OriginalContentType.SchemaXml;

            XmlElement ctNode = (XmlElement)xmlelem.LastChild;
            ctNode.SetAttribute("xmlns", "http://schemas.microsoft.com/sharepoint/");
            if (virtualContenttype.Name != String.Empty)
                ctNode.SetAttribute("Name", virtualContenttype.Name);

            if (virtualContenttype.Description != String.Empty)
                ctNode.SetAttribute("Description", virtualContenttype.Description);
            if (virtualContenttype.Hidden.HasValue)
                ctNode.SetAttribute("Hidden", virtualContenttype.Hidden.ToString());
            if (virtualContenttype.Group != String.Empty)
                ctNode.SetAttribute("Group", virtualContenttype.Group);
            ctNode.SetAttribute("ID", virtualContenttype.Id);
            if(virtualContenttype.HasCustomFeature)
                ctNode.SetAttribute("FeatureID", virtualContenttype.FeatureID.ToString("B"));
            if (virtualContenttype.ReadOnly.HasValue)
                ctNode.SetAttribute("ReadOnly", virtualContenttype.ReadOnly.ToString());
            if (virtualContenttype.ResourceFolder != String.Empty)
                ctNode.SetAttribute("ResourceFolder", virtualContenttype.ResourceFolder);
            if (virtualContenttype.Sealed.HasValue)
                ctNode.SetAttribute("Sealed", virtualContenttype.Sealed.ToString());

            ReplaceFieldWithFieldRef(xmldoc, xmlelem, virtualContenttype);


            xmlelem.InnerXml = CleanFeatureXml(xmlelem.InnerXml);

            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");
            ValidateXml(path + "\\elements.xml");

            CreateFeatureFile(virtualFeature, true, path);
        }

        private static void ReplaceFieldWithFieldRef(XmlDocument xmlDoc, XmlElement xmlElem, VirtualContentType virtualContentType)
        {
            string fieldsXml = virtualContentType.OriginalContentType.Fields.SchemaXml;
            string fieldLinkXml = virtualContentType.OriginalContentType.FieldLinks[0].SchemaXml;

            XmlElement fieldRefsElement = xmlDoc.CreateElement("FieldRefs");
            string innerXml = "";
            foreach(SPFieldLink fieldLink in virtualContentType.OriginalContentType.FieldLinks)
            {
                innerXml += fieldLink.SchemaXml;
            }
            fieldRefsElement.InnerXml = innerXml;

            XmlNode fieldsElement = xmlElem.SelectSingleNode("//Fields");
            XPathNavigator nav = fieldsElement.CreateNavigator();
            nav.DeleteSelf();

            XmlNode ctElement = xmlElem.SelectSingleNode("//ContentType");
            ctElement.AppendChild(fieldRefsElement);
            
        }


        public static void CreateCustomColumnsFromDbFeature(string title, string description, string version,
            string scope, SPContentType contentType, string connectionString, string directoryPath, bool createDirectory)
        {
            string contentTypeDefinition = DataAccess.GetContentTypeDefinition(connectionString, contentType.Id);
            List<string> fieldDefinitions = DataAccess.GetFieldDefinitions(connectionString);

            CreateCustomColumnsFromDbFeature(title, description, version, scope, contentTypeDefinition, fieldDefinitions.ToArray(), directoryPath, createDirectory);    
        }

        public static void CreateCustomContentTypeFromDbFeature(string title, string description, string version,
            string scope, SPContentType contentType, string directoryPath, bool createDirectory, string connectionString)
        {
            string contentTypeDefinition = DataAccess.GetContentTypeDefinition(connectionString, contentType.Id);

            CreateCustomContentTypeFromDbFeature(title, description, version, scope, contentTypeDefinition, directoryPath, createDirectory);
        }

        /// <summary>
        /// Creates the feature.xml and elements.xml files for a group of custom columns
        /// </summary>
        /// <param name="title">The name of the feature</param>
        /// <param name="description">The description of the feature</param>
        /// <param name="version">The version of the features</param>
        /// <param name="scope">The scope of the feature</param>
        /// <param name="contentType">The content Type</param>
        /// <param name="columns">An array of colums</param>
        /// <param name="directoryPath">The path to the directory to create the files in</param>
        /// <param name="createDirectory">Whether to create a new directory</param>
        public static void CreateCustomColumnsFromDbFeature(string title, string description, string version, 
            string scope, string contentType, string[] columns, string directoryPath, bool createDirectory)
        {

            if (createDirectory)
            {
                Directory.CreateDirectory(directoryPath);
            }

            VirtualFeature virtualFeature = new VirtualFeature();
            virtualFeature.Scope = (FeatureScope)Enum.Parse(typeof(FeatureScope),scope);
            virtualFeature.Version = version;
            virtualFeature.Description = description;
            virtualFeature.Title = title;
            CreateFeatureFile(virtualFeature, true, directoryPath);
            CreateColumnElementsFile(contentType, columns, directoryPath);
        }




        /// <summary>
        /// Creates the feature.xml and elements.xml files for a content type
        /// </summary>
        /// <param name="title">The name of the feature</param>
        /// <param name="description">The description of the feature</param>
        /// <param name="version">The version of the features</param>
        /// <param name="scope">The scope of the feature</param>
        /// <param name="contentType">The content Type</param>
        /// <param name="directoryPath">The path to the directory to create the files in</param>
        /// <param name="createDirectory">Whether to create a new directory</param>
        public static void CreateCustomContentTypeFromDbFeature(string title, string description, string version,
            string scope, string contentType, string directoryPath, bool createDirectory)
        {
            if (createDirectory)
            {
                Directory.CreateDirectory(directoryPath);
            }

            VirtualFeature virtualFeature = new VirtualFeature();
            virtualFeature.Scope = (FeatureScope)Enum.Parse(typeof(FeatureScope), scope);
            virtualFeature.Version = version;
            virtualFeature.Description = description;
            virtualFeature.Title = title;
            CreateFeatureFile(virtualFeature, true, directoryPath);
            CreateContentTypeElementsFile(contentType, directoryPath);
        }

        //creates an elements.xml file for the selected group of columns
        private static void CreateColumnElementsFile(string contentType, string[] columns, string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");
            string fieldsXml=GetRelevantFields(contentType, columns);
            xmlelem.InnerXml = fieldsXml;
           
            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");
            ValidateXml(path + "\\elements.xml");
        }

        //returns the columns that are relevant for the content type
        private static string GetRelevantFields(string contentType, string[] columns)
        {
            string retVal = "";
            XPathNodeIterator it = GetRootNodeIteratorFromString(contentType);
            XPathNodeIterator it2 = it.Current.SelectDescendants("FieldRef","",false);
            while (it2.MoveNext())
            {
                string id=it2.Current.GetAttribute("ID", "");
                for (int i = 0; i < columns.Length; i++)
                {
                    if (columns[i].Contains(id))
                    {
                        string fieldString = columns[i].Insert(6, " xmlns = \"http://schemas.microsoft.com/sharepoint/\"");
                        retVal += fieldString;
                    }
                }
            }
            return retVal;
        }

        //creates an elements.xml file for the selected content type
        private static void CreateContentTypeElementsFile(string contentType, string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");
            xmlelem.InnerXml = CleanFeatureXml(contentType);
            XmlElement ctElement = (XmlElement)xmlelem.FirstChild;
            ctElement.SetAttribute("xmlns", "http://schemas.microsoft.com/sharepoint/");
            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");
            ValidateXml(path + "\\elements.xml");
        }

        //removes all empty attributes en removes xmldocuments node
        private static string CleanFeatureXml(string xmlString)
        {
            string retVal = Regex.Replace(xmlString, "\\s\\S*=\"\"", "");
            retVal = Regex.Replace(retVal, "<XmlDocuments>[\\s\\S]*</XmlDocuments>", "");

            return retVal;
        }


        private static void CreateFeatureFile(VirtualFeature virtualFeature, bool newGuid, string path)
        {
            XmlDocument xmldoc = new XmlDocument();

            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Feature", "http://schemas.microsoft.com/sharepoint/");

            string featureID = newGuid ? Guid.NewGuid().ToString("B") : virtualFeature.Id.ToString("B");
            xmlelem.SetAttribute("Id", featureID);
            XmlElement elementManifestsNode = xmldoc.CreateElement("ElementManifests", "http://schemas.microsoft.com/sharepoint/");
            XmlElement manifestNode = xmldoc.CreateElement("ElementManifest", "http://schemas.microsoft.com/sharepoint/");

            manifestNode.SetAttribute("Location", "elements.xml");
            elementManifestsNode.AppendChild(manifestNode);

            xmlelem.AppendChild(elementManifestsNode);

            xmlelem.SetAttribute("Title", virtualFeature.Title);
            xmlelem.SetAttribute("Description", virtualFeature.Description);
            xmlelem.SetAttribute("Version", virtualFeature.Version);
            xmlelem.SetAttribute("Scope", virtualFeature.Scope.ToString());


            xmldoc.AppendChild(xmlelem);

            xmldoc.Save(path + "\\feature.xml");
            ValidateXml(path + "\\feature.xml");

            return;


        }



        public static void CreateListFeature(VirtualListTemplate virtualListTemplate, VirtualFeature virtualFeature, string directoryPath, bool createDirectory, bool CreateAndInstall, bool retrieveOriginalForms, string formsFromPath, bool newGuid)
        {

            if (createDirectory)
            {
                Directory.CreateDirectory(directoryPath);
            }
            Directory.CreateDirectory(directoryPath + "\\" + virtualListTemplate.Name);


            CreateFeatureFile(virtualFeature, newGuid,directoryPath);
            CreateListElementsFile(virtualListTemplate, directoryPath);
            CreateListSchemaFile(virtualListTemplate, directoryPath);
            CreateForms(virtualListTemplate, directoryPath + "\\" + virtualListTemplate.Name, retrieveOriginalForms, formsFromPath);

        }


        private static void CreateForms(VirtualListTemplate virtualListTemplate, string path, bool retrieveOriginalForms, string formsFromPath)
        {

            string baseUrl = virtualListTemplate.OriginalList.ParentWeb.Url;
            string fileName;

            foreach (SPForm form in virtualListTemplate.OriginalList.Forms)
            {
                string url = baseUrl + form.ServerRelativeUrl;
                fileName = GetFileName(url);
                if (retrieveOriginalForms)
                    RetrieveOriginalFile(url, path);
                else
                {
                    if (form.Type == PAGETYPE.PAGE_DISPLAYFORM)
                        File.Copy(formsFromPath + DISPFORM, path + "\\" + fileName);
                    else if (form.Type == PAGETYPE.PAGE_EDITFORM)
                        File.Copy(formsFromPath + EDITITEMFORM, path + "\\" + fileName);
                    else if (form.Type == PAGETYPE.PAGE_NEWFORM)
                        File.Copy(formsFromPath + NEWITEMFORM, path + "\\" + fileName);
                    else
                        MessageBox.Show("Could not copy " + fileName + " from " + formsFromPath + ". Try copying manually.");
                }
            }

            foreach (SPView view in virtualListTemplate.OriginalList.Views)
            {
                string viewUrl = baseUrl + view.ServerRelativeUrl;
                fileName = GetFileName(viewUrl);
                if (retrieveOriginalForms)
                    RetrieveOriginalFile(viewUrl, path);
                else
                {
                    if (fileName.Equals(ALLITEMSFORM) || fileName.Equals(DISPFORM) || fileName.Equals(NEWITEMFORM) || fileName.Equals(EDITITEMFORM))
                        File.Copy(formsFromPath + fileName, path + "\\" + fileName);
                    else
                        File.Copy(formsFromPath + ALLITEMSFORM, path + "\\" + fileName);
                }
            }
        }


        private static string GetFileName(string url)
        {
            string fileName = url;
            int lastFolderIndex = url.LastIndexOf('/');
            if (lastFolderIndex > 0)
            {
                fileName = url.Substring(lastFolderIndex + 1);
            }
            return fileName;
        }


        private static void RetrieveOriginalFile(string url, string path)
        {
            string fileName = GetFileName(url);
            
            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            client.DownloadFile(url, path+"\\"+fileName);

        }

        private static void CreateListElementsFile(VirtualListTemplate virtualListTemplate, string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement xmlelem = xmldoc.CreateElement("Elements", "http://schemas.microsoft.com/sharepoint/");

            XmlElement listDefintionNode = xmldoc.CreateElement("ListTemplate", "http://schemas.microsoft.com/sharepoint/");

            listDefintionNode.SetAttribute("Name", virtualListTemplate.Name);
            listDefintionNode.SetAttribute("BaseType", ""+(int)virtualListTemplate.ListBaseType);
            listDefintionNode.SetAttribute("Type",virtualListTemplate.Type.ToString());
            listDefintionNode.SetAttribute("SecurityBits", "" + virtualListTemplate.SecurityBits);
            listDefintionNode.SetAttribute("DisplayName", virtualListTemplate.DisplayName);
            listDefintionNode.SetAttribute("Description", virtualListTemplate.Description);

            if(virtualListTemplate.AllowDeletion!=null)
                listDefintionNode.SetAttribute("AllowDeletion", virtualListTemplate.AllowDeletion.ToString());

            if (virtualListTemplate.AllowEveryOneViewItems != null)
                listDefintionNode.SetAttribute("AllowEveryoneViewItems", virtualListTemplate.AllowEveryOneViewItems.ToString());

            if (virtualListTemplate.DisallowContentTypes != null)
                listDefintionNode.SetAttribute("DisallowContentTypes", (virtualListTemplate.DisallowContentTypes).ToString());

            if (virtualListTemplate.DisableAttachments != null)
                listDefintionNode.SetAttribute("DisableAttachments", virtualListTemplate.DisableAttachments.ToString());

            if (virtualListTemplate.FolderCreation != null)
                listDefintionNode.SetAttribute("FolderCreation", virtualListTemplate.FolderCreation.ToString());

            if (virtualListTemplate.Hidden != null)
                listDefintionNode.SetAttribute("Hidden", virtualListTemplate.Hidden.ToString());

            if (virtualListTemplate.EnableModeration != null)
                listDefintionNode.SetAttribute("EnableModeration", virtualListTemplate.EnableModeration.ToString());

            if (virtualListTemplate.NoCrawl != null)
                listDefintionNode.SetAttribute("NoCrawl", virtualListTemplate.NoCrawl.ToString());

            if (virtualListTemplate.VersioningEnabled != null)
                listDefintionNode.SetAttribute("VersioningEnabled", virtualListTemplate.VersioningEnabled.ToString());

            if (virtualListTemplate.OnQuickLaunch != null)
                listDefintionNode.SetAttribute("OnQuickLaunch", virtualListTemplate.OnQuickLaunch.ToString());



            //note: whe're missing a few items, notably EditPage and NewPage

            xmlelem.AppendChild(listDefintionNode);
            xmldoc.AppendChild(xmlelem);
            xmldoc.Save(path + "\\elements.xml");
            ValidateXml(path + "\\elements.xml");
        }

        private static void CreateListSchemaFile(VirtualListTemplate virtualListTemplate, string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            XmlElement listElem = xmldoc.CreateElement("List");
            listElem.SetAttribute("xmlns", "http://schemas.microsoft.com/sharepoint/");
            listElem.SetAttribute("Title", virtualListTemplate.Name);
            listElem.SetAttribute("FolderCreation", virtualListTemplate.FolderCreation.ToString());
            listElem.SetAttribute("Direction", virtualListTemplate.Direction);
            listElem.SetAttribute("Url", virtualListTemplate.Url);
            listElem.SetAttribute("BaseType", ""+(int)virtualListTemplate.ListBaseType);
            listElem.SetAttribute("Description", virtualListTemplate.Description);

            XmlElement metadataNode = xmldoc.CreateElement("MetaData");
            listElem.AppendChild(metadataNode);

            XmlElement contentTypesNode = xmldoc.CreateElement("ContentTypes");
            metadataNode.AppendChild(contentTypesNode);
            foreach (SPContentType ct in virtualListTemplate.OriginalList.ContentTypes)
            {
                XmlElement ctRef=xmldoc.CreateElement("ContentTypeRef");
                ctRef.SetAttribute("ID", ct.Id.ToString().Substring(0,6));
                contentTypesNode.AppendChild(ctRef);
            }


            XmlDocumentFragment fieldsFragment = xmldoc.CreateDocumentFragment();
            fieldsFragment.InnerXml = virtualListTemplate.OriginalList.Fields.SchemaXml;
            metadataNode.AppendChild(fieldsFragment);

            XmlDocumentFragment viewsFragment = xmldoc.CreateDocumentFragment();
            
            viewsFragment.InnerXml = virtualListTemplate.OriginalList.Views.SchemaXml;
            XmlNode viewsNode = viewsFragment.FirstChild;
            XmlNode viewNode = viewsNode.FirstChild;
            int i=1;
            do
            {
                if (viewNode.Attributes["Url"] != null)
                {
                    string allItemsPath = viewNode.Attributes["Url"].Value;
                    int lastFolderIndex = allItemsPath.LastIndexOf('/');
                    if (lastFolderIndex > 0)
                    {
                        allItemsPath=allItemsPath.Substring(lastFolderIndex+1);
                        viewNode.Attributes["Url"].Value = allItemsPath;
                    }
                }
                viewNode.Attributes["BaseViewID"].Value = "" + i;//or else all BaseViewID's will be equal to 1, selecting only the defaultview
                if (virtualListTemplate.SetupPathViews==null || virtualListTemplate.SetupPathViews.Equals(string.Empty))
                    viewNode.Attributes.RemoveNamedItem("SetupPath");
                else
                {
                    if(viewNode.Attributes["SetupPath"]==null)
                        viewNode.Attributes.Append(xmldoc.CreateAttribute("SetupPath"));
                    viewNode.Attributes["SetupPath"].Value = virtualListTemplate.SetupPathViews;
                }
                viewNode.Attributes.RemoveNamedItem("Name");
                viewNode.Attributes.Append(xmldoc.CreateAttribute("WebPartZoneID"));
                viewNode.Attributes["WebPartZoneID"].Value = virtualListTemplate.WebpartZoneID;
                viewNode = viewNode.NextSibling;
                i++;
            }
            while (viewNode != null);
            metadataNode.AppendChild(viewsFragment);

            XmlDocumentFragment formsFragment = xmldoc.CreateDocumentFragment();
            formsFragment.InnerXml = virtualListTemplate.OriginalList.Forms.SchemaXml;
            XmlNode formsNode = formsFragment.FirstChild;
            XmlNode formNode = formsNode.FirstChild;

            do
            {
                if (formNode.Attributes["Url"] != null)
                {
                    string allItemsPath = formNode.Attributes["Url"].Value;
                    int lastFolderIndex = allItemsPath.LastIndexOf('/');
                    if (lastFolderIndex > 0)
                    {
                        allItemsPath = allItemsPath.Substring(lastFolderIndex + 1);
                        formNode.Attributes["Url"].Value = allItemsPath;
                    }
                }

                if (virtualListTemplate.SetupPathForms==null || virtualListTemplate.SetupPathForms.Equals(string.Empty))
                    formNode.Attributes.RemoveNamedItem("SetupPath");
                else
                {
                    if (formNode.Attributes["SetupPath"] == null)
                        formNode.Attributes.Append(xmldoc.CreateAttribute("SetupPath"));
                    formNode.Attributes["SetupPath"].Value = virtualListTemplate.SetupPathForms;
                }


                formNode = formNode.NextSibling;
            }
            while (formNode != null);



            metadataNode.AppendChild(formsFragment);

            xmldoc.AppendChild(listElem);
            xmldoc.Save(path + "\\" + virtualListTemplate.Name+ "\\schema.xml");
            
        }
       

        public static void ValidateXml(string xmlPath)
        {
            currentXmlFile = xmlPath;

            XmlSchema xmlSchema = XmlSchema.Read(new XmlTextReader(xsdPath+"CoreDefinitions.xsd"), 
                new ValidationEventHandler(validatingReader_ValidationEventHandler));
            XmlSchema xmlSchema2 = XmlSchema.Read(new XmlTextReader(xsdPath + "wss.xsd"),
                new ValidationEventHandler(validatingReader_ValidationEventHandler));

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.Schemas.Add(xmlSchema);
            xmlReaderSettings.Schemas.Add(xmlSchema2);
            xmlReaderSettings.ValidationEventHandler += new ValidationEventHandler(validatingReader_ValidationEventHandler);
            using (XmlReader xmlReader = XmlReader.Create(new XmlTextReader(xmlPath), 
                    xmlReaderSettings))
            {
                while (xmlReader.Read()) ;
            }
        }

        static void validatingReader_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            validationErrors.Add(new MFGValidationError(e,currentXmlFile));
        }



    }
}
