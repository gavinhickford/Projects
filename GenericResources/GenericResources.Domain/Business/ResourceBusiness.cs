using GenericResources.Data.Factories;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GenericResources.Common.Enums;

namespace GenericResources.Domain.Business
{
    public class ResourceBusiness : IResourceBusiness 
    {
        public List<IFolder> GetFolders(ResourceType resourceType)
        {
            return new DataStoreFactory()
                .CreateDataStore(resourceType)
                .GetFolders();
        }
    }
}
