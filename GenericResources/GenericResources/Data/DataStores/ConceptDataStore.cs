using GenericResources.Entities;
using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
{
    public class ConceptDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main Concept" };
            IFolder parentFolder = new Folder { Name = "Parent Concept" };
            IFolder childFolder = new Folder { Name = "Child Concept" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder };
            return new List<IFolder>{ folder };
        }
    }
}
