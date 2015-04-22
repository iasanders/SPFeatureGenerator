using System;
using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.SharePoint;
using System.Collections.Generic;

namespace Library
{
    public class VirtualSite
    {
        private const string DEFAULTWEB = "defaultweb";

        private Hashtable originalElements = new Hashtable();
        private Dictionary<Guid,Guid> guidMapping=new Dictionary<Guid,Guid>();
        private Dictionary<int, VirtualListTemplate> listTemplates = new Dictionary<int, VirtualListTemplate>();
        private Dictionary<int, VirtualListInstance> listInstances = new Dictionary<int, VirtualListInstance>();
        private Dictionary<string, VirtualContentType> contentTypes = new Dictionary<string, VirtualContentType>();
        private Dictionary<Guid, VirtualField> fields = new Dictionary<Guid, VirtualField>();
        private Dictionary<Guid, VirtualFeature> features = new Dictionary<Guid, VirtualFeature>();


        public Dictionary<Guid, VirtualFeature> Features
        {
            get { return features; }
            set { features = value; }
        }


        public Dictionary<int, VirtualListTemplate> ListTemplates
        {
            get { return listTemplates; }
            set { listTemplates = value; }
        }



        public Dictionary<int, VirtualListInstance> ListInstances
        {
            get { return listInstances; }
            set { listInstances = value; }
        }


        public Dictionary<string, VirtualContentType> ContentTypes
        {
            get { return contentTypes; }
            set { contentTypes = value; }
        }


        public Dictionary<Guid, VirtualField> Fields
        {
            get { return fields; }
            set { fields = value; }
        }
        
        





        public VirtualSite()
        {

        }


        public void RemoveElementFromFeature(object elementKey, VirtualFeature feature)
        {
            feature.Elements.Remove(elementKey);
            if (feature.Elements.Count == 0)
                features.Remove(feature.Id);

        }


        public VirtualElement GetVirtualElement(object key)
        {
            Type keyType = key.GetType();
            if (keyType == typeof(string))
                return contentTypes[(string)key];
            else if (keyType == typeof(int))
            {
                VirtualElement element = listTemplates[(int)key];
                if (element != null)
                    return element;
                else
                    return listInstances[(int)key];
            }
            else if (keyType == typeof(Guid))
            {
                return fields[(Guid)key];
            }
            else
                return null;


        }


        /// <summary>
        /// Copies the specified field from a real world site into the default web of this VirtualSite
        /// </summary>
        /// <param name="originalField">The Field to copy</param>
        public void CopyField(VirtualField field)
        {

            fields.Add(field.Id, field);
            AddFeature(field);
        }

        private void AddFeature(VirtualElement functionality)
        {
            if (functionality.HasCustomFeature)
                features[functionality.FeatureID] = functionality.VirtualFeature;

        }

        /// <summary>
        /// Copies the specified ContentType from a real world site into the default web of this VirtualSite
        /// </summary>
        /// <param name="originalContentType">The ContentType to copy</param>
        public void CopyContentType(VirtualContentType originalContentType)
        {
            contentTypes.Add(originalContentType.Id, originalContentType);
            AddFeature(originalContentType);
        }



        public void CopyListInstance(VirtualListInstance virtualListInstance)
        {
            TryAddVirtualListInstance(virtualListInstance);
            AddFeature(virtualListInstance);
        }


        private void TryAddVirtualListInstance(VirtualListInstance listInstance)
        {
            if (!listInstances.ContainsKey(listInstance.ID))
            {
                listInstances.Add(listInstance.ID, listInstance);
                return;
            }

            int counter = 1;
            while (listInstances.ContainsKey(counter))
                counter++;

            listInstance.ID = counter;
            listInstances.Add(listInstance.ID, listInstance);
        }




        public void CopyListTemplate(VirtualListTemplate virtualListTemplate)
        {
            TryAddVirtualListTemplate(virtualListTemplate);
            AddFeature(virtualListTemplate);
        }


        private void TryAddVirtualListTemplate(VirtualListTemplate listTemplate)
        {
            if(!listTemplates.ContainsKey(listTemplate.Type))
            {
                listTemplates.Add(listTemplate.Type, listTemplate);
                return;
            }

            int counter = 10000;
            while (listTemplates.ContainsKey(counter))
                counter++;

            listTemplate.Type = counter;
            listTemplates.Add(listTemplate.Type, listTemplate);
        }



        /// <summary>
        /// Returns all ListTemplates for the Virtual Site
        /// </summary>
        /// <returns>SPListTemplate[]</returns>
        public VirtualListTemplate[] GetAllListTemplates()
        {

            VirtualListTemplate[] retVal = new VirtualListTemplate[listTemplates.Count];
            int i = 0;
            foreach (VirtualListTemplate listTemplate in listTemplates.Values)
            {
                retVal[i] = listTemplate;
                i++;
            }

            return retVal;

        }


        /// <summary>
        /// Returns all List instances for the Virtual Site
        /// </summary>
        /// <returns>VirtualListInstance[]</returns>
        public VirtualListInstance[] GetAllLists()
        {
            VirtualListInstance[] retVal = new VirtualListInstance[listInstances.Count];
            int i = 0;
            foreach (VirtualListInstance list in listInstances.Values)
            {
                retVal[i] = list;
                i++;
            }

            return retVal;
        }




        /// <summary>
        /// Gets all the List instances for the specified ListTemplate
        /// </summary>
        /// <param name="listTemplateGuid">The Guid of the ListTemplate</param>
        /// <returns>SPList[]</returns>
        public VirtualListInstance[] GetListsForListTemplate(int listTemplateType)
        {
            if (!listTemplates.ContainsKey(listTemplateType))
                return null;
            
            ArrayList lists = new ArrayList();
            foreach (VirtualListInstance list in listInstances.Values)
            {
                if(list.TemplateType==listTemplateType)
                    lists.Add(list);
            }

            return (VirtualListInstance[])lists.ToArray(typeof(VirtualListInstance));
        }


        public VirtualListInstance[] GetOrphanListInstances()
        {
            ArrayList lists = new ArrayList();
            foreach (VirtualListInstance list in listInstances.Values)
            {
                if (!listTemplates.ContainsKey(list.TemplateType))
                    lists.Add(list);                   
            }

            return (VirtualListInstance[])lists.ToArray(typeof(VirtualListInstance));
        }


        /// <summary>
        /// Returns all Fields for the Virtual Site
        /// </summary>
        /// <returns>SPField[]</returns>
        public VirtualField[] GetAllFields()
        {
            VirtualField[] retVal = new VirtualField[fields.Count];
            int i = 0;
            foreach (VirtualField field in fields.Values)
            {
                retVal[i] = field;
                i++;
            }

            return retVal;
        }

        /// <summary>
        /// Returns all ContentTypes for the Virtual Site
        /// </summary>
        /// <returns>VirtualContentType[]</returns>
        public VirtualContentType[] GetAllContentTypes()
        {
            VirtualContentType[] retVal = new VirtualContentType[contentTypes.Count];
            int i = 0;
            foreach (VirtualContentType contentType in contentTypes.Values)
            {
                retVal[i] = contentType;
                i++;
            }

            return retVal;
        }




        private void StoreOriginalElement(Guid guid, object element)
        {
            originalElements.Add(guid, element);
        }

        private void AddGuidMapping(Guid originalGuid, Guid virtualGuid)
        {
            guidMapping.Add(originalGuid, virtualGuid);
        }

        //oldVirtualGuid must be supplied for sanity checking
        private void ChangeGuidMapping(Guid originalGuid, Guid oldVirtualGuid, Guid newVirtualGuid)
        {
            if(!guidMapping.ContainsKey(originalGuid))
                throw new ApplicationException("Original Guid not found: "+ originalGuid.ToString("B"));
            
            Guid mappingGuid=(Guid)guidMapping[originalGuid];
            if(!mappingGuid.Equals(oldVirtualGuid))
                throw new ApplicationException("Guid: " +originalGuid.ToString("B")+" does not map to Guid: "+oldVirtualGuid.ToString("B"));

            guidMapping[originalGuid]=newVirtualGuid;
        }



    }
}
