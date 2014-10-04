using GenericResources.Entities;
using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
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
