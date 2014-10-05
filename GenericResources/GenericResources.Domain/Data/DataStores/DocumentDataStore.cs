using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.DataStores
{
    public class DocumentDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main Document" };
            IFolder parentFolder = new Folder { Name = "Parent Document" };
            IFolder childFolder = new Folder { Name = "Child Document" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder };
            return new List<IFolder> { folder };
        }
    }
}
