using GenericResources.Domain.Business;
using GenericResources.Common.Entities;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GenericResources.Common.Enums;

namespace GenericResources.Domain.Services
{
    public class ResourceService : IResourceService 
    {
        IResourceBusiness _resourceBusiness;

        public ResourceService()
        {
            _resourceBusiness = new ResourceBusiness();
        }

        public List<IFolder> GetFolders(ResourceType resourceType)
        {
            return _resourceBusiness.GetFolders(resourceType);
        }
    }
}
