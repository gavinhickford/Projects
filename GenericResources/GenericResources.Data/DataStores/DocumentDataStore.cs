using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
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

        public List<IResource> GetResources(int folderId)
        {
            IResource docTemplate1 = new DocumentTemplate { Name = "Doc template 1", Description = "Doc template 1 description" };
            IResource docTemplate2 = new DocumentTemplate { Name = "Doc template 2", Description = "Doc template 2 description" };
            
            // Just return a List of simple concepts for now
            return new List<IResource> { docTemplate1, docTemplate2 };
        }
    }
}
