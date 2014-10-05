using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.DataStores
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
    }
}
