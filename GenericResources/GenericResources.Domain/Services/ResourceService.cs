using GenericResources.Domain.Business;
using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GenericResources.Common.Enums;
using GenericResources.Data.Factories;

namespace GenericResources.Domain.Services
{
    public class ResourceService : IResourceService 
    {
        IResourceBusiness _resourceBusiness;

        public ResourceService()
        {
            // TODO - use dependency injection to set the datastorefactory
            _resourceBusiness = new ResourceBusiness(new DataStoreFactory());
        }
        
        public List<IFolder> GetFolders(ResourceType resourceType)
        {
            return _resourceBusiness.GetFolders(resourceType);
        }

        public List<IResource> GetResources(ResourceType resourceType, int folderId)
        {
            return _resourceBusiness.GetResources(resourceType, folderId);
        }
    
    }
}
