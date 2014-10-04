using GenericResources.Data.Factories;
using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources
{
    public class ResourceBusiness : IResourceBusiness 
    {
        public List<IFolder> GetFolders(Enums.ResourceType resourceType)
        {
            return new DataStoreFactory()
                .CreateDataStore(resourceType)
                .GetFolders();
        }
    }
}
