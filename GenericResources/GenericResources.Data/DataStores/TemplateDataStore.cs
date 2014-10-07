using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
{
    public class TemplateDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main Template" };
            IFolder parentFolder = new Folder { Name = "Parent Template" };
            IFolder childFolder = new Folder { Name = "Child Template" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder };
            return new List<IFolder> { folder };
        }

        public List<IResource> GetResources(int folderId)
        {
            IResource template1 = new Template { Name = "Template1", Description = "Template1 description" };

            // Just return a List of simple templates for now
            return new List<IResource> { template1 };
        }
    }
}
