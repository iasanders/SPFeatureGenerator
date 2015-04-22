# SPFeatureGenerator
The SharePoint 2013 FeatureGgenerator, generates features from existing objects of a SharePoint 2013 site. This includes Site 
Columns, Content Types and ListTemplates (including schema.xml and forms). 

Introduction
This tool makes it easy to create SharePoint 2013 Features by using drag and drop point and click. It will create the objects like Site Columns, Lists and Content Types from the Sharepoint 2007 site you select in a treeview, which you can than add to your Virtual Site. A Virtual Site is made up of all the Features you generate. Press the create button, and all features will be created and validated against wss.xds. The following feature types are supported in this version: Site Columns (Feature.xml, Elements.xml)
Content Types (Feature.xml, Elements.xml), List Templates (Feature.xml, Elements.xml, Schema.xml, AllItems.aspx, DispForm.aspx, NewForm.aspx, EditForm.aspx)

Features can be selected by drag & drop
Site Column Features can be generated 'on their own' independant of the Content Type in which they are used
More properties for the features can be set from the MFG Gui
Feature properties are separated from properties that will be in the functional files (elements.xml, schema.xml and forms/views)
Features can be created by either selecting a objects directly, generating with default settings from the Virtual Site, or with edited properties from the Virtual Site.
Created Features are validated against wss.xsd (except for the schema.xml)

The tool vam be used in two ways: create a build tree will be cthen drag and drop teh bjects from left to right to create dependant features in an organized way, 
and the number of supported features will be expanded.

SharePoint Feature Generator 2.0.0
For More details, see info and help-file at the Release page

Reference:
The original version of this app was released in 2008, worked with SharePoint 2007 and can be found on Codeplex http://mossfeaturegenerator.codeplex.com/

