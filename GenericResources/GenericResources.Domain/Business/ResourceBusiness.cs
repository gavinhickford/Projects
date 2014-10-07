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
        private IDataStoreFactory _dataStoreFactory;

        public ResourceBusiness(IDataStoreFactory dataStoreFactory)
        {
            _dataStoreFactory = dataStoreFactory;
        }

        public List<IFolder> GetFolders(ResourceType resourceType)
        {
            return _dataStoreFactory
                .CreateDataStore(resourceType)
                .GetFolders();
        }

        public List<IResource> GetResources(ResourceType resourceType, int folderId)
        {
            return _dataStoreFactory
               .CreateDataStore(resourceType)
               .GetResources(folderId);
        }
   
    }
}
