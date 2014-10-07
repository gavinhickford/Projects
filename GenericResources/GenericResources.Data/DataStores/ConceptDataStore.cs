using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Data.DataStores
{
    public class ConceptDataStore : IResourceDataStore
    {
        public List<IFolder> GetFolders()
        {
            IFolder folder1 = new Folder { Name = "Concept Folder1" };
            IFolder childFolder1 = new Folder { Name = "Child Concept 1" };
            IFolder childFolder2 = new Folder { Name = "Child Concept 2" };
            IFolder childFolder3 = new Folder { Name = "Child Concept 3" };
            folder1.ChildFolders = new List<IFolder> { childFolder1, childFolder2, childFolder3 };
            
            IFolder folder2 = new Folder { Name = "Concept Folder2" };
            IFolder childFolder4 = new Folder { Name = "Child Concept 4" };
            IFolder childFolder5 = new Folder { Name = "Child Concept 5" };
            folder2.ChildFolders = new List<IFolder> { childFolder4, childFolder5};
            
            return new List<IFolder>{ folder1, folder2 };
        }

        public List<IResource> GetResources(int folderId)
        {
            IResource concept1 = new Concept { Name = "Concept 1", Description = "Concept 1 description" };
            IResource concept2 = new Concept { Name = "Concept 2", Description = "Concept 2 description" };
            IResource concept3 = new Concept { Name = "Concept 3", Description = "Concept 3 description" };

            // Just return a List of simple concepts for now
            return new List<IResource> { concept1, concept2, concept3 };
        }
    }
}
