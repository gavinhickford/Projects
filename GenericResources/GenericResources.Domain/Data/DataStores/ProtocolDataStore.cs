using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.DataStores
{
    public class ProtocolDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main Protocol" };
            IFolder parentFolder = new Folder { Name = "Parent Protocol" };
            IFolder childFolder = new Folder { Name = "Child Protocol" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder };
            return new List<IFolder> { folder };
        }
    }
}
