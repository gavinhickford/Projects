using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
{
    public class LibraryItemDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder = new Folder { Name = "Main LibraryItem" };
            IFolder parentFolder = new Folder { Name = "Parent LibraryItem" };
            IFolder childFolder1 = new Folder { Name = "Child LibraryItem 1" };
            IFolder childFolder2 = new Folder { Name = "Child LibraryItem 2" };
            IFolder childFolder3 = new Folder { Name = "Child LibraryItem 3" };
            folder.ParentFolder = parentFolder;
            folder.ChildFolders = new List<IFolder> { childFolder1, childFolder2, childFolder3 };
            return new List<IFolder> { folder };
        }

        public List<IResource> GetResources(int folderId)
        {
            IResource libraryItem1 = new LibraryItem { Name = "Library item 1", Description = "Library item 1 description" };
            IResource libraryItem2 = new LibraryItem { Name = "Library item 2", Description = "Library item 2 description" };
            IResource libraryItem3 = new LibraryItem { Name = "Library item 3", Description = "Library item 3 description" };
            IResource libraryItem4 = new LibraryItem { Name = "Library item 4", Description = "Library item 4 description" };

            // Just return a List of simple concepts for now
            return new List<IResource> { libraryItem1, libraryItem2, libraryItem3, libraryItem4 };
        }
    }
}
