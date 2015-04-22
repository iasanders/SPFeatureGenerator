using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library;
using Microsoft.SharePoint;


namespace CTFeatureCreator
{
    public enum NodeType { SiteColumn, ContentType, ListTemplate, ListInstance, SiteColumnCollection, ContentTypeCollection, 
    ListTemplateCollection, ListInstanceCollection, Feature, FeatureCollection, Web, Property, 
        Elements, ElementFiles, ActivationDependencies, Undetermined}



    public partial class GeneralSelectionForm : FeatureFormBase
    {
        #region Variables

        private VirtualSite virtualSite=new VirtualSite();
        private SPSite site;
        private ContextMenu treeContextMenu=new ContextMenu();
        private bool showFeaturesAsMainNode = true;
        private bool showFeaturesAsFunctionalityProperties = true;
        private TreeNode featuresNode;
        private TreeNode draggedNode;

        #endregion

        #region Initialization

        public GeneralSelectionForm()
        {
            InitializeComponent();
        }


        private void GeneralSelectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                trvOriginalSite.AllowDrop = true;
                trvVirtualSite.AllowDrop = true;
                this.AllowDrop = true;


                ApplicationSettings appSettings = new ApplicationSettings();
                string ImagePath = appSettings.ImagePath;

                ImageList il = new ImageList();
                il.Images.Add(Image.FromFile(ImagePath + "\\web.gif"));
                il.Images.Add(Image.FromFile(ImagePath + "\\SiteColumn.gif"));
                il.Images.Add(Image.FromFile(ImagePath + "\\ContentType.gif"));
                il.Images.Add(Image.FromFile(ImagePath + "\\ListTemplate.GIF"));
                il.Images.Add(Image.FromFile(ImagePath + "\\ListInstance.GIF"));
                il.Images.Add(Image.FromFile(ImagePath + "\\SiteColumns.gif"));
                il.Images.Add(Image.FromFile(ImagePath + "\\ContentTypes.gif"));
                il.Images.Add(Image.FromFile(ImagePath + "\\Lists.GIF"));
                il.Images.Add(Image.FromFile(ImagePath + "\\OrphanListInstances.GIF"));
                il.Images.Add(Image.FromFile(ImagePath + "\\Property.GIF"));

                trvVirtualSite.ImageList = il;
                trvOriginalSite.ImageList = il;


                appSettings = new ApplicationSettings();
                txtSiteUrl.Text = appSettings.SiteUrl;
                txtPath.Text = appSettings.FeatureDestionationPath;

                if (!txtSiteUrl.Text.Equals(appSettings.NotDefined))
                    LoadSites();

                BuildOriginalSite(false);
                ShowVirtualSite();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSites()
        {
            try
            {
                
                site = new SPSite(txtSiteUrl.Text);

                foreach (SPWeb web in site.AllWebs)
                {
                    cboWebs.Items.Add(web);
                }

                cboWebs.SelectedItem = site.AllWebs[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region BuildOriginalSite




        private void BuildOriginalSite(bool expand)
        {

            trvOriginalSite.BeginUpdate();
            trvOriginalSite.Nodes.Clear();
            TreeNode siteNode = new TreeNode("Site");
            siteNode.Tag = site;
            trvOriginalSite.Nodes.Add(siteNode);
            
            if(expand)
                AddOriginalWebNodes(siteNode);

            trvOriginalSite.EndUpdate();
        }

        private void BuildOriginalSite()
        {
            BuildOriginalSite(true);
        }


        private void AddOriginalWebNodes(TreeNode siteNode)
        {
            int teller = 0;
            foreach (SPWeb web in site.AllWebs)
            {
                string nodeName = web.Name == string.Empty ? web.Title : web.Name;
                TreeNode webNode = new TreeNode(nodeName, 0, 0);
                webNode.Tag = web;
                siteNode.Nodes.Add(webNode);

                if (teller < 1)
                {
                    AddOriginalWebNode(webNode, web);
                }
                teller++;
            }


        }

        private void AddOriginalWebNode(TreeNode webNode, SPWeb web)
        {
            TreeNode fieldsNode = new TreeNode("Fields", 5, 5);
            webNode.Nodes.Add(fieldsNode);
            AddOriginalColumnNodes(fieldsNode, web);
            TreeNode contentTypesNode = new TreeNode("ContentTypes", 6, 6);
            webNode.Nodes.Add(contentTypesNode);
            AddOriginalContentTypesNodes(contentTypesNode, web);
            TreeNode listTemplatesNode = new TreeNode("ListTemplates", 7, 7);
            webNode.Nodes.Add(listTemplatesNode);
            AddOriginalListTemplatesNodes(listTemplatesNode, web);
            TreeNode listInstancesNode = new TreeNode("ListInstances", 7, 7);
            webNode.Nodes.Add(listInstancesNode);
            AddOriginalListInstancesNodes(listInstancesNode, web);
        }


        private void AddOriginalListTemplatesNodes(TreeNode listsTemplatesNode, SPWeb web)
        {
            foreach (SPListTemplate listTemplate in web.ListTemplates)
            {
                TreeNode listTemplateNode = new TreeNode(listTemplate.Name, 3, 3);
                listTemplateNode.Tag = listTemplate;
                listsTemplatesNode.Nodes.Add(listTemplateNode);
            }
        }

        private void AddOriginalListInstancesNodes(TreeNode listInstancesNode, SPWeb web)
        {

            foreach (SPList listInstance in web.Lists)
            {
                TreeNode listInstanceNode = new TreeNode(listInstance.Title, 4, 4);
                listInstanceNode.Tag = listInstance;
                listInstancesNode.Nodes.Add(listInstanceNode);
            }
        }

        private void AddOriginalContentTypesNodes(TreeNode contentTypesNode, SPWeb web)
        {

            foreach (SPContentType ct in web.ContentTypes)
            {
                TreeNode ctNode = new TreeNode(ct.Name, 6,6);
                ctNode.Tag = ct;
                contentTypesNode.Nodes.Add(ctNode);
            }
        }

        private void AddOriginalColumnNodes(TreeNode fieldsNode, SPWeb web)
        {
            foreach (SPField field in web.Fields)
            {
                TreeNode fieldNode = new TreeNode(field.Title, 5, 5);
                fieldNode.Tag = field;
                fieldsNode.Nodes.Add(fieldNode);
            }
        }

        #endregion

        #region BuildVirtualSite
        private void ShowVirtualSite()
        {
            trvVirtualSite.Nodes.Clear();

            TreeNode siteNode = new TreeNode("VirtualSite",0,0);
            siteNode.Tag="VirtualSite";
            this.trvVirtualSite.Nodes.Add(siteNode);
            AddFeatures(siteNode, virtualSite.Features.Values);
            AddFieldsNodes(siteNode, virtualSite.GetAllFields());
            AddContentTypesNodes(siteNode, virtualSite.GetAllContentTypes());
            AddListNodes(siteNode);
        }


        private void AddFeatures(TreeNode parentNode, IEnumerable<VirtualFeature> features)
        {
            featuresNode = new TreeNode("Features", 0, 0);
            featuresNode.Tag = "Features";
            parentNode.Nodes.Add(featuresNode);
        }

        private void DropElementOnFeatureNode(TreeNode featureNode, VirtualElement element)
        {
            VirtualFeature feature = (VirtualFeature)featureNode.Tag;
            
            //if associations other then this one exist, remove them
            if (element.VirtualFeature != null && element.VirtualFeature != feature)
            {
                virtualSite.RemoveElementFromFeature(element.GetKey(),element.VirtualFeature);
                element.VirtualFeature = null;
            }

            feature.Elements[element.GetKey()] = element;
            element.VirtualFeature = feature;

            //add element to featureNode under FeaturesCollection
            AddElementToElements(featureNode, element);
           
            //add feature to elementNode
            TreeNode oldFeatureNode = FindChildByTag(draggedNode, element.VirtualFeature);
            if (oldFeatureNode != null) 
                oldFeatureNode.Remove();

            AddFeatureNode(draggedNode, element.VirtualFeature,false);
        }

        private void AddElementToElements(TreeNode featureNode, VirtualElement element)
        {
            TreeNode elementsNode = FindChildByTag(featureNode, NodeType.Elements.ToString());
            if (elementsNode != null)
            {
                if (FindChildByName(elementsNode, element.ToString()) == null)
                    elementsNode.Nodes.Add(element.ToString(), element.ToString());
            }
        }

        private void ConnectToFeature( TreeNode elementNode, VirtualElement element)
        {
            if (!element.HasCustomFeature)
                return;

            VirtualFeature feature=element.VirtualFeature;
            virtualSite.Features[feature.Id] = feature;
            feature.Elements[element.GetKey()] = element;
            if (element.HasCustomFeature && showFeaturesAsMainNode)
                AddFeatureOrElementNode(featuresNode, element);
            if (element.HasCustomFeature && showFeaturesAsFunctionalityProperties)
                AddFeatureNode(elementNode, feature,false);

        }

        private void AddFeatureOrElementNode(TreeNode parentNode, VirtualElement element)
        {
            TreeNode featureNode = FindFeatureNode(parentNode, element.VirtualFeature);
            if (featureNode == null)//feature not yet present
                AddFeatureNode(parentNode, element.VirtualFeature,true);
            else
                AddElementToElements(featureNode, element);
        }

        private TreeNode FindChildByName(TreeNode parentNode, string name)
        {

            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Name.Equals(name))
                    return node;
            }
            return null;
        }


        private TreeNode FindChildByTag(TreeNode parentNode, object tag)
        {

            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Tag!=null && node.Tag.Equals(tag))
                    return node;
            }
            return null;
        }

        private TreeNode FindFeatureNode(TreeNode parentNode, VirtualFeature feature)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Tag != null && feature.Equals(node.Tag))
                    return node;
            }
            return null;
        }


        private void AddFeatureNode(TreeNode parentNode, VirtualFeature feature, bool childs)
        {
            TreeNode featureNode = new TreeNode(feature.Title, 0, 0);
            featureNode.Tag = feature;
            parentNode.Nodes.Add(featureNode);

            if(childs)
                AddFeaturePropertyNodes(featureNode, feature);
        }

        private void AddFeaturePropertyNodes(TreeNode featureNode, VirtualFeature feature)
        {
            TreeNode propertiesNode = new TreeNode("Properties");
            propertiesNode.Tag="Properties";
            featureNode.Nodes.Add(propertiesNode);
            propertiesNode.Nodes.Add("Id", "ID: " + feature.Id.ToString("B"));
            propertiesNode.Nodes.Add("Title", "Title: " + feature.Title);
            propertiesNode.Nodes.Add("Description", "Description: " + feature.Description);
            propertiesNode.Nodes.Add("ActivateOnDefault", "ActivateOnDefault: " + feature.ActivateOnDefault.ToString());
            propertiesNode.Nodes.Add("AlwaysForceInstall", "AlwaysForceInstall: " + feature.AlwaysForceInstall.ToString());
            propertiesNode.Nodes.Add("AutoActivateInCentralAdmin", "AutoActivateInCentralAdmin: " + feature.AutoActivateInCentralAdmin.ToString());
            propertiesNode.Nodes.Add("Creator", "Creator: " + feature.Creator);
            propertiesNode.Nodes.Add("DefaultResourceFile", "DefaultResourceFile: " + feature.DefaultResourceFile);
            propertiesNode.Nodes.Add("Hidden", "Hidden: " + feature.Hidden.ToString());
            propertiesNode.Nodes.Add("ImageUrl", "ImageUrl: " + feature.ImageUrl);
            propertiesNode.Nodes.Add("ImageUrlAltText", "ImageUrlAltText: " + feature.ImageUrlAltText);
            propertiesNode.Nodes.Add("ReceiverAssembly", "ReceiverAssembly: " + feature.ReceiverAssembly);
            propertiesNode.Nodes.Add("ReceiverClass", "ReceiverClass: " + feature.ReceiverClass);
            propertiesNode.Nodes.Add("RequireResources", "RequireResources: " + feature.RequireResources.ToString());
            propertiesNode.Nodes.Add("Scope", "Scope: " + feature.Scope);
            propertiesNode.Nodes.Add("SolutionId", "SolutionId: " + feature.SolutionId);
            propertiesNode.Nodes.Add("Version", "Version: " + feature.Version);

            TreeNode elementsNode = new TreeNode(NodeType.Elements.ToString());
            elementsNode.Tag = NodeType.Elements.ToString();
            featureNode.Nodes.Add(elementsNode);
            foreach(VirtualElement element in feature.Elements.Values)
            {
                elementsNode.Nodes.Add(element.ToString(), element.ToString());
            }


            TreeNode activationDependenciesNode = new TreeNode(NodeType.ActivationDependencies.ToString());
            activationDependenciesNode.Tag = NodeType.ActivationDependencies.ToString();
            featureNode.Nodes.Add(activationDependenciesNode);
            foreach (Guid guid in feature.ActivationDependencies)
            {
                activationDependenciesNode.Nodes.Add(guid.ToString("B"), guid.ToString("B"));
            }

            TreeNode elementFilesNode = new TreeNode(NodeType.ElementFiles.ToString());
            elementFilesNode.Tag = NodeType.ElementFiles.ToString();
            featureNode.Nodes.Add(elementFilesNode);
            foreach (string elementFileName in feature.ElementFiles)
            {
                elementFilesNode.Nodes.Add(elementFileName, elementFileName);
            }

            TreeNode customPropertiesNode = new TreeNode("Custom Properties");
            customPropertiesNode.Tag = "Custom Properties";
            featureNode.Nodes.Add(customPropertiesNode);
            foreach (string key in feature.Properties.Keys)
            {
                customPropertiesNode.Nodes.Add(key, key + ": " + feature.Properties[key]);
            }
        }



        private void AddFieldsNodes(TreeNode parentNode, IEnumerable<VirtualField> fields)
        {
            TreeNode fieldsNode=new TreeNode("Fields",5,5);
            fieldsNode.Tag=FeatureType.SiteColumn;
            parentNode.Nodes.Add(fieldsNode);

            foreach (VirtualField field in fields)
            {
                AddFieldNode(fieldsNode, field);
            }
        }

        private TreeNode AddFieldNode(TreeNode parentNode, VirtualField field)
        {
            TreeNode fieldNode = new TreeNode(field.StaticName, 1, 1);
            fieldNode.Tag = field.Id;
            parentNode.Nodes.Add(fieldNode);
            AddFieldPropertyNodes(fieldNode, field);
            ConnectToFeature(fieldNode, field);
            return fieldNode;
        }



        private void AddContentTypesNodes(TreeNode parentNode, IEnumerable<VirtualContentType> contentTypes)
        {
            TreeNode contentTypesNode = new TreeNode("ContentTypes",6,6);
            contentTypesNode.Tag = FeatureType.ContentType;
            parentNode.Nodes.Add(contentTypesNode);

            foreach (VirtualContentType contentType in contentTypes)
            {
                AddContentTypeNode(contentTypesNode, contentType);
            }
        }

        private TreeNode AddContentTypeNode(TreeNode parent, VirtualContentType contentType)
        {
                TreeNode contentTypeNode = new TreeNode(contentType.Name,2,2);
                contentTypeNode.Tag = contentType.Id;
                parent.Nodes.Add(contentTypeNode);
                AddContentTypePropertyNodes(contentTypeNode, contentType);
                ConnectToFeature(contentTypeNode, contentType);
                return contentTypeNode;
        }





        private void AddListNodes(TreeNode siteNode)
        {
            TreeNode listsNode = new TreeNode("Lists", 7, 7);
            listsNode.Tag = FeatureType.ListTemplate;
            siteNode.Nodes.Add(listsNode);

            foreach (VirtualListTemplate listTemplate in virtualSite.GetAllListTemplates())
            {
                AddListTemplateNode(listsNode, listTemplate);
            }

            AddOrphanListInstances(listsNode);
        }

        private TreeNode AddListTemplateNode(TreeNode parent, VirtualListTemplate listTemplate)
        {
               TreeNode listTemplateNode = new TreeNode(listTemplate.Name, 3, 3);
                listTemplateNode.Tag = listTemplate.Type;
                parent.Nodes.Add(listTemplateNode);
                AddListTemplatePropertyNodes(listTemplateNode, listTemplate);
                AddListInstanceNodes(listTemplateNode, virtualSite.GetListsForListTemplate((int)listTemplateNode.Tag));
                ConnectToFeature(listTemplateNode, listTemplate);
                return listTemplateNode;
        }



        private void AddListInstanceNodes(TreeNode listTemplateNode, VirtualListInstance[] lists)
        {
            foreach (VirtualListInstance list in lists)
            {
                AddListInstanceNode(listTemplateNode, list);
            }
        }

        private TreeNode AddListInstanceNode(TreeNode parentNode, VirtualListInstance virtualListInstance)
        {
            TreeNode listNode = new TreeNode(virtualListInstance.Title, 4, 4);
            listNode.Tag = virtualListInstance.ID;
            parentNode.Nodes.Add(listNode);
            AddListInstancePropertyNodes(listNode, virtualListInstance);
            ConnectToFeature(listNode, virtualListInstance);
            return listNode;
        }

        private void AddOrphanListInstances(TreeNode parentNode)
        {
            TreeNode orphanListsNode = new TreeNode("Orphan List Instances", 8, 8);
            orphanListsNode.Tag = FeatureType.ListInstance;
            parentNode.Nodes.Add(orphanListsNode);
            AddListInstanceNodes(orphanListsNode, virtualSite.GetOrphanListInstances());
        }


        private void AddFieldPropertyNodes(TreeNode fieldNode, VirtualField field)
        {
            fieldNode.Nodes.Add("Id", "Id: "+field.Id.ToString("B"), 9);
            fieldNode.Nodes.Add("Name","Name: "+ field.StaticName, 9);
            fieldNode.Nodes.Add("SourceId", "SourceId: " + field.SourceID, 9);
            fieldNode.Nodes.Add("StaticName", "StaticName: " + field.StaticName, 9);
            fieldNode.Nodes.Add("Group", "Group: " + field.Group, 9);
        }

        private void AddContentTypePropertyNodes(TreeNode contentTypeNode, VirtualContentType contentType)
        {
            contentTypeNode.Nodes.Add("Id", "Id: " + contentType.Id.ToString());
            contentTypeNode.Nodes.Add("Description", "Description: " + contentType.Description, 9);
            contentTypeNode.Nodes.Add("Name", "Name: " + contentType.Name, 9);
            contentTypeNode.Nodes.Add("Group", "Group: " + contentType.Group, 9);
            contentTypeNode.Nodes.Add("Hidden", "Hidden: " + contentType.Hidden.ToString(), 9);
            contentTypeNode.Nodes.Add("ReadOnly", "ReadOnly: " + contentType.ReadOnly.ToString(), 9);
            contentTypeNode.Nodes.Add("ResourceFolder", "ResourceFolder: " + contentType.ResourceFolder, 9);
            contentTypeNode.Nodes.Add("Sealed", "Sealed: " + contentType.Sealed.ToString(), 9);

            AddFieldsNodes(contentTypeNode, contentType.Fields);
        }

        private void AddListTemplatePropertyNodes(TreeNode listTemplateNode, VirtualListTemplate listTemplate)
        {
            listTemplateNode.Nodes.Add("Type", "Type: " + listTemplate.Type.ToString());
            listTemplateNode.Nodes.Add("Id", "Id: " + listTemplate.Id.ToString());
            listTemplateNode.Nodes.Add("Description", "Description: " + listTemplate.Description, 9);
            listTemplateNode.Nodes.Add("Name", "Name: " + listTemplate.Name, 9);
            listTemplateNode.Nodes.Add("BaseType", "BaseType: " + listTemplate.ListBaseType.ToString(), 9);
            listTemplateNode.Nodes.Add("DocumentTemplate", "DocumentTemplate: " + listTemplate.DocumentTemplate, 9);
            listTemplateNode.Nodes.Add("Hidden", "Hidden: " + listTemplate.Hidden.ToString(), 9);
            listTemplateNode.Nodes.Add("Unique", "Unique: " + listTemplate.Unique.ToString(), 9);
            listTemplateNode.Nodes.Add("EditPage", "EditPage: " + listTemplate.EditPage, 9);
            listTemplateNode.Nodes.Add("NewPage", "NewPage: " + listTemplate.NewPage, 9);
        }

        private void AddListInstancePropertyNodes(TreeNode listInstanceNode, VirtualListInstance list)
        {
            listInstanceNode.Nodes.Add("Id", "Id: " + list.ID.ToString());
            listInstanceNode.Nodes.Add("Description", "Description: " + list.Description, 9);
            listInstanceNode.Nodes.Add("Title", "Title: " + list.Title, 9);
            listInstanceNode.Nodes.Add("TemplateType", "TemplateType: " + list.TemplateType.ToString(), 9);
            listInstanceNode.Nodes.Add("FeatureId", "FeatureId: " + list.FeatureId.ToString("B"), 9);


        }

        #endregion

        #region DragDrop


        private void trvVirtualSite_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                TreeView tree = (TreeView)sender;
                Point pt = new Point(e.X, e.Y);
                pt = tree.PointToClient(pt);
                TreeNode node = tree.GetNodeAt(pt);
                object tag=((TreeNode)e.Data.GetData(typeof(TreeNode))).Tag;
                AddDroppedObject(node, tag);
                node.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add to VirtualSite AND add Node
        
        private void AddDroppedObject(TreeNode targetParent, object objectToDrop)
        {
            try
            {
                if (!ValidateDropTarget(targetParent, objectToDrop))
                {
                    MessageBox.Show("Can't drop");
                    return;
                }

                NodeType nodeType = GetNodeType(targetParent);
                switch (nodeType)
                {
                    case NodeType.SiteColumnCollection:
                        VirtualField vf = new VirtualField((SPField)objectToDrop);
                        virtualSite.CopyField(vf);
                        AddFieldNode(targetParent, vf);
                        break;
                    case NodeType.ContentTypeCollection:
                        VirtualContentType vct = new VirtualContentType((SPContentType)objectToDrop);
                        virtualSite.CopyContentType(vct);
                        AddContentTypeNode(targetParent, vct);
                        break;
                    case NodeType.ListTemplateCollection://drop list on ListTemplateCollection: add as VirtualListTempate
                        VirtualListTemplate vlt = new VirtualListTemplate((SPList)objectToDrop);
                        virtualSite.CopyListTemplate(vlt);
                        AddListTemplateNode(targetParent, vlt);
                        break;
                    case NodeType.ListInstanceCollection://drop list on ListInstanceCollection: add as VirtualListInstance (only orphan list instances)
                        VirtualListInstance vli = new VirtualListInstance((SPList)objectToDrop);
                        virtualSite.CopyListInstance(vli);
                        AddListInstanceNode(targetParent, vli);
                        break;
                    case NodeType.ListTemplate://drop list on ListTemplate: add as VirtualListInstance (as an item belonging to ListTemplate)
                        VirtualListInstance vl = new VirtualListInstance((SPList)objectToDrop);
                        virtualSite.CopyListInstance(vl);
                        AddListInstanceNode(targetParent, vl);
                        break;
                    case NodeType.Feature://drop VirtualElement on Feature
                        VirtualElement virtualElement = virtualSite.GetVirtualElement(objectToDrop);
                        DropElementOnFeatureNode(targetParent,virtualElement);
                        break;
                    default:
                        MessageBox.Show("Internal: Not supported yet, refer to AddDroppedObject method");
                        break;

                }
                btnCreateAllFeatures.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void trvVirtualSite_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                TreeView tree = (TreeView)sender;

                e.Effect = DragDropEffects.None;

                TreeNode originalNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (originalNode != null && originalNode.Tag != null)
                {
                    Point pt = new Point(e.X, e.Y);
                    pt = tree.PointToClient(pt);
                    TreeNode node = tree.GetNodeAt(pt);

                    if (node != null && ValidateDropTarget(node, originalNode.Tag))
                    {
                        e.Effect = DragDropEffects.All;
                        tree.SelectedNode = node;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateDropTarget(TreeNode targetNode, object objectToDrop)
        {
            return ValidateDropForOriginalElements(targetNode,objectToDrop) ||
                ValidateDropForVirtualElements(targetNode, objectToDrop);
        }

        private bool ValidateDropForOriginalElements(TreeNode targetNode, object objectToDrop)
        {
            NodeType nodeType = GetNodeType(targetNode);
            bool retVal = false;

            switch (nodeType)
            {
                case NodeType.ListTemplate://on ListTemplate Node, drop ListInstance of the right type
                    if (IsListType(objectToDrop))
                    {
                        SPList list = (SPList)objectToDrop;
                        if ((int)list.BaseTemplate == (int)targetNode.Tag)
                            retVal = true;
                    }
                    break;
                case NodeType.ContentTypeCollection://On ContentTypeCollectionNode drop ContentType
                    retVal = objectToDrop.GetType() == typeof(SPContentType);
                    break;
                case NodeType.SiteColumnCollection://on SiteColumnCollection Node, drop (subclass of) Field
                    retVal = objectToDrop.GetType().IsSubclassOf(typeof(SPField));
                    break;
                case NodeType.ListTemplateCollection://on ListTemplateCollection Node, drop ListInstance
                    retVal = IsListType(objectToDrop);
                    break;
                case NodeType.ListInstanceCollection://on ListInstanceCollection Node, drop ListInstance
                    retVal = IsListType(objectToDrop);
                    break;

            }
            return retVal;


        }

        private bool ValidateDropForVirtualElements(TreeNode targetNode, object objectToDrop)
        {
            NodeType nodeType = GetNodeType(targetNode);
            bool retVal = false;

            switch (nodeType)
            {
                case NodeType.Feature:
                    VirtualElement element = virtualSite.GetVirtualElement(objectToDrop);
                    retVal = element != null;
                    break;

                //case NodeType.ListTemplate://on ListTemplate Node, drop ListInstance of the right type
                //    if (IsListType(objectToDrop))
                //    {
                //        SPList list = (SPList)objectToDrop;
                //        if ((int)list.BaseTemplate == (int)targetNode.Tag)
                //            retVal = true;
                //    }
                //    break;
                //case NodeType.ContentTypeCollection://On ContentTypeCollectionNode drop ContentType
                //    retVal = objectToDrop.GetType() == typeof(SPContentType);
                //    break;
                //case NodeType.SiteColumnCollection://on SiteColumnCollection Node, drop (subclass of) Field
                //    retVal = objectToDrop.GetType().IsSubclassOf(typeof(SPField));
                //    break;
                //case NodeType.ListTemplateCollection://on ListTemplateCollection Node, drop ListInstance
                //    retVal = IsListType(objectToDrop);
                //    break;
                //case NodeType.ListInstanceCollection://on ListInstanceCollection Node, drop ListInstance
                //    retVal = IsListType(objectToDrop);
                //    break;

            }
            return retVal;




        }


        private void trvOriginalSite_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                TreeView tree = (TreeView)sender;
                TreeNode node = tree.GetNodeAt(e.X, e.Y);

                if (node == null || node.Tag == null)
                    return;

                //if a web node which hasn't been expanded
                if (node.Tag.GetType() == typeof(SPWeb) && node.Nodes.Count == 0)
                {
                    AddOriginalWebNode(node, (SPWeb)node.Tag);
                    return;
                }

                tree.SelectedNode = node;
                tree.DoDragDrop(node.Clone(), DragDropEffects.Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsListType(object obj)
        {
            return obj.GetType().IsSubclassOf(typeof(SPList)) || obj.GetType()==typeof(SPList);
        }



        private void ChangeField(TreeNode node, VirtualField virtualField)
        {
            SiteColumnForm scf = new SiteColumnForm();
            scf.VirtualField = virtualField;
            scf.ShowDialogButtons(true);
            if (scf.ShowDialog() == DialogResult.OK)
            {
                int index=node.Index;
                TreeNode parentNode=node.Parent;
                node.Remove();
                AddFieldNode(parentNode, virtualField);
            }
        }

        private void ChangeContentType(TreeNode node, VirtualContentType virtualContentType)
        {
            ContentTypeForm ctf = new ContentTypeForm();
            ctf.VirtualContentType = virtualContentType;
            ctf.ShowDialogButtons(true);
            if (ctf.ShowDialog() == DialogResult.OK)
            {
                virtualContentType = ctf.VirtualContentType;
                int index = node.Index;
                TreeNode parentNode = node.Parent;
                node.Remove();
                AddContentTypeNode(parentNode, virtualContentType);
            }
        }

        private void ChangeFeature(TreeNode node, VirtualFeature virtualFeature)
        {
            FeatureForm ff = new FeatureForm();
            ff.Feature = virtualFeature;
            if (ff.ShowDialog() == DialogResult.OK)
            {
                virtualFeature = ff.Feature;
                int index = node.Index;
                TreeNode parentNode = node.Parent;
                node.Remove();
                AddFeatureNode(parentNode, virtualFeature,false);
            }
        }

        private void ChangeListTemplate(TreeNode node, VirtualListTemplate virtualListTemplate)
        {
            ListTemplateForm ltf = new ListTemplateForm();
            ltf.VirtualList = virtualListTemplate;
            ltf.ShowDialogButtons(true);
            if (ltf.ShowDialog() == DialogResult.OK)
            {
                virtualListTemplate = ltf.VirtualList;
                int index = node.Index;
                TreeNode parentNode = node.Parent;
                node.Remove();
                AddListTemplateNode(parentNode, virtualListTemplate);
            }
        }

        private void trvVirtualSite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                TreeView tree = (TreeView)sender;
                Point pt = new Point(e.X, e.Y);
                TreeNode node = tree.GetNodeAt(pt);

                NodeType nodeType = GetNodeType(node);

                switch (nodeType)
                {
                    case NodeType.Undetermined:
                    case NodeType.Web:
                        return;
                        break;
                    case NodeType.SiteColumn:
                        VirtualField virtualField = virtualSite.Fields[(Guid)node.Tag];
                        ChangeField(node, virtualField);
                        break;
                    case NodeType.ContentType:
                        VirtualContentType virtualContentType = virtualSite.ContentTypes[(string)node.Tag];
                        ChangeContentType(node, virtualContentType);
                        break;
                    case NodeType.ListTemplate:
                        VirtualListTemplate virtualListTemplate = virtualSite.ListTemplates[(int)node.Tag];
                        ChangeListTemplate(node, virtualListTemplate);
                        break;
                    case NodeType.Feature:
                        VirtualFeature feature = (VirtualFeature)node.Tag;
                        ChangeFeature(node, feature);
                        break;
                    default:
                        MessageBox.Show("Not supported. Yet");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvVirtualSite_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    TreeView tree = (TreeView)sender;
                    TreeNode node = tree.GetNodeAt(e.X, e.Y);
                    tree.SelectedNode = node;
                    draggedNode = node;

                    if (node != null && node.Tag != null)
                    {
                        tree.DoDragDrop(node, DragDropEffects.Move);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void trvVirtualSite_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Point pt = new Point(e.X, e.Y);
                    TreeNode node = this.trvVirtualSite.GetNodeAt(pt);
                    trvVirtualSite.SelectedNode = node;

                    if (node == null)
                        return;

                    trvVirtualSite.SelectedNode = node;
                    pt = trvVirtualSite.PointToScreen(pt);
                    Point point = this.PointToClient(pt);

                    BuildContextMenu(node, point);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuildContextMenu(TreeNode node, Point point)
        {

            treeContextMenu.MenuItems.Clear();

            if (node.Parent == null || node.Parent.Tag == null)
                return;

            if(node.Parent.Tag.GetType()==typeof(FeatureType))
            {
                switch((FeatureType)node.Parent.Tag)
                {// it is expected that menus will be differentiated in some next release
                    case FeatureType.SiteColumn:
                        treeContextMenu.MenuItems.Add("Remove");
                        treeContextMenu.MenuItems[0].Click += new EventHandler(TreeContextMenuRemove_Click);
                        break;
                    case FeatureType.ContentType:
                        treeContextMenu.MenuItems.Add("Remove");
                        treeContextMenu.MenuItems[0].Click += new EventHandler(TreeContextMenuRemove_Click);
                        break;
                    case FeatureType.ListTemplate:
                        treeContextMenu.MenuItems.Add("Remove");
                        //treeContextMenu.MenuItems.Add("Remove with dependant lists");
                        treeContextMenu.MenuItems[0].Click += new EventHandler(TreeContextMenuRemove_Click);
                        break;
                    case FeatureType.ListInstance:
                        treeContextMenu.MenuItems.Add("Remove");
                        treeContextMenu.MenuItems[0].Click += new EventHandler(TreeContextMenuRemove_Click);
                        break;
                }
            }
    
            treeContextMenu.Show(this, point);

        }



        private void TreeContextMenuRemove_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = trvVirtualSite.SelectedNode;
                if (node.Parent == null || node.Parent.Tag == null)
                    return;

                if (node.Parent.Tag.GetType() == typeof(FeatureType))
                {
                    switch ((FeatureType)node.Parent.Tag)
                    {
                        case FeatureType.SiteColumn:
                            virtualSite.Fields.Remove((Guid)node.Tag);
                            node.Parent.Nodes.Remove(node);
                            break;
                        case FeatureType.ContentType:
                            virtualSite.ContentTypes.Remove((string)node.Tag);
                            node.Parent.Nodes.Remove(node);
                            break;
                        case FeatureType.ListTemplate:
                            virtualSite.ListTemplates.Remove((int)node.Tag);
                            node.Parent.Nodes.Remove(node);
                            break;
                        case FeatureType.ListInstance:
                            virtualSite.ListInstances.Remove((int)node.Tag);
                            node.Parent.Nodes.Remove(node);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #endregion

        #region ControlEvents

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string siteUrl = txtSiteUrl.Text;
                ApplicationSettings appSettings = new ApplicationSettings();
                appSettings.SiteUrl = txtSiteUrl.Text;
                appSettings.Save();

                site = new SPSite(siteUrl);

                BuildOriginalSite();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboWebs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SPWeb web = (SPWeb)cboWebs.SelectedItem;
                string nodeName = web.Name == string.Empty ? web.Title : web.Name;
                TreeNode webNode = new TreeNode(nodeName, 0, 0);
                webNode.Tag = web;

                TreeNode siteNode = trvOriginalSite.Nodes[0];
                siteNode.Nodes.Clear();
                siteNode.Nodes.Add(webNode);
                AddOriginalWebNode(webNode, web);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFeatures(object sender, EventArgs e)
        {
            try
            {
                lblFeaturesCreated.Visible = false;
                lblFeaturesCreated.Text = "";
                btnSchemaValidationErrors.Enabled = false;

                XmlHelper.ValidationErrors.Clear();

                VirtualFeature virtualFeature;
                //site columns

                if (virtualSite.GetAllFields().Length > 0)
                {
                    virtualFeature = GetFeature("Site Columns Feature Definition");
                    XmlHelper.CreateMultipleColumnsFeature(virtualSite.GetAllFields(), virtualFeature,
                        txtPath.Text + "\\" + virtualFeature.Title);
                    lblFeaturesCreated.Text = "Created: site columns";
                    lblFeaturesCreated.Visible = true;
                }

                //content types
                foreach (VirtualContentType vct in virtualSite.GetAllContentTypes())
                {
                    virtualFeature = new VirtualFeature();
                    virtualFeature.Title = vct.Name;
                    virtualFeature.Scope = FeatureScope.Site;
                    virtualFeature.Version = "1.0.0.0";
                    virtualFeature.Id = new Guid();
                    XmlHelper.CreateContentTypeFeature(vct, virtualFeature, txtPath.Text + "\\" + virtualFeature.Title, false);
                }
                lblFeaturesCreated.Text += ", content type(S)";

                //ListTemplates
                ApplicationSettings settings = new ApplicationSettings();
                string formsFromPath = settings.FormsFromPath;
                foreach (VirtualListTemplate vlt in virtualSite.GetAllListTemplates())
                {
                    virtualFeature = new VirtualFeature();
                    virtualFeature.Title = vlt.Name;
                    virtualFeature.Scope = FeatureScope.Site;
                    virtualFeature.Version = "1.0.0.0";
                    virtualFeature.Id = new Guid();

                    XmlHelper.CreateListFeature(vlt, virtualFeature, txtPath.Text + "\\" + virtualFeature.Title,
                        true, false, false, formsFromPath, true);
                }
                lblFeaturesCreated.Text += ", list templates";

                //TODO in next version: ListInstances

                if (XmlHelper.ValidationErrors.Count > 0)
                {
                    lblFeaturesCreated.Text = "There were Schema Validaton errors against wss.xsd.";
                    btnSchemaValidationErrors.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private VirtualFeature GetFeature(string caption)
        {
            VirtualFeature virtualFeature = new VirtualFeature();
            FeatureForm featureForm = new FeatureForm();
            featureForm.Text = caption;
            featureForm.Feature = virtualFeature;
            if (featureForm.ShowDialog() == DialogResult.OK)
            {
                virtualFeature = featureForm.Feature;
            }
            return virtualFeature;

        }



        private void btnOpenFolderBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath.Text = folderBrowserDialog.SelectedPath;
                    ApplicationSettings settings = new ApplicationSettings();
                    settings.FeatureDestionationPath = txtPath.Text;
                    settings.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPath_Leave(object sender, EventArgs e)
        {
            try
            {
                ApplicationSettings settings = new ApplicationSettings();
                settings.FeatureDestionationPath = txtPath.Text;
                settings.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ShowVirtualSite();
        }

        private void btnSchemaValidationErrors_Click(object sender, EventArgs e)
        {
            ValidationErrorsForm vef = new ValidationErrorsForm();
            vef.ValidationErrors = XmlHelper.ValidationErrors;
            vef.ShowDialog();
        }


        private NodeType GetNodeType(TreeNode node)
        {
            if (node.Parent == null)
                return NodeType.Web;
            else if (node.Tag == null)
                return NodeType.Undetermined;
            else if (node.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Tag == FeatureType.SiteColumn))
            {
                return NodeType.SiteColumnCollection;
            }
            else if (node.Tag.GetType() == typeof(FeatureType) &&
            ((FeatureType)node.Tag == FeatureType.ContentType))
            {
                return NodeType.ContentTypeCollection;
            }
            else if (node.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Tag == FeatureType.ListTemplate))
            {
                return NodeType.ListTemplateCollection;
            }
            else if (node.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Tag == FeatureType.ListInstance))
            {
                return NodeType.ListInstanceCollection;
            }
            else if (node.Parent.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Parent.Tag == FeatureType.SiteColumn))
            {
                return NodeType.SiteColumn;
            }
            else if (node.Parent.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Parent.Tag == FeatureType.ContentType))
            {
                return NodeType.ContentType;
            }
            else if (node.Parent.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Parent.Tag == FeatureType.ListTemplate))
            {
                return NodeType.ListTemplate;
            }
            else if (node.Parent.Tag.GetType() == typeof(FeatureType) &&
                ((FeatureType)node.Parent.Tag == FeatureType.ListInstance))
            {
                return NodeType.ListInstance;
            }
            else if (node.Tag.Equals("Features"))
                return NodeType.FeatureCollection;
            else if (node.Tag.GetType().Equals(typeof(VirtualFeature)) && GetNodeType(node.Parent)==NodeType.FeatureCollection)
                return NodeType.Feature;
            else
                return NodeType.Undetermined;

        }






    }
}