using GenericResources.Domain.Factories;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Business
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
