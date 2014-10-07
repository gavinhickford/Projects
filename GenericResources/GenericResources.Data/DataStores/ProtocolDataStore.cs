using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
{
    public class ProtocolDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder1 = new Folder { Name = "Main Protocol 1" };
         //   IFolder parentFolder = new Folder { Name = "Parent Protocol" };
            IFolder childFolder1 = new Folder { Name = "Child Protocol1" };
            IFolder childFolder2 = new Folder { Name = "Child Protocol2" };
         //   folder.ParentFolder = parentFolder;
            folder1.ChildFolders = new List<IFolder> { childFolder1, childFolder2 };

            IFolder folder2 = new Folder { Name = "Main Protocol 2" };
            //   IFolder parentFolder = new Folder { Name = "Parent Protocol" };
            IFolder childFolder3 = new Folder { Name = "Child Protocol3" };
            IFolder childFolder4 = new Folder { Name = "Child Protocol4" };
            IFolder childFolder5 = new Folder { Name = "Child Protocol5" };

            folder1.ChildFolders = new List<IFolder> { childFolder3, childFolder4, childFolder5 };

            return new List<IFolder> { folder1, folder2 };
        }

        public List<IResource> GetResources(int folderId)
        {
            IResource protocol1 = new Protocol { Name = "Protocol1", Description = "Protocol1 description" };
            IResource protocol2 = new Protocol { Name = "Protocol2", Description = "Protocol2 description" };

            // Just return a List of simple protocols for now
            return new List<IResource> { protocol1, protocol2 };
        }
    }
}
