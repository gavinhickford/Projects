using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.DataStores
{
    public class LibraryItemDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main LibraryItem" };
            IFolder parentFolder = new Folder { Name = "Parent LibraryItem" };
            IFolder childFolder = new Folder { Name = "Child LibraryItem" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder };
            return new List<IFolder> { folder };
        }
    }
}
