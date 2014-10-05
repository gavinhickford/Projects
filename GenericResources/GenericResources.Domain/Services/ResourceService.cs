using GenericResources.Domain.Business;
using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Services
{
    public class ResourceService : IResourceService 
    {
        IResourceBusiness _resourceBusiness;

        public ResourceService()
        {
            _resourceBusiness = new ResourceBusiness();
        }

        public List<IFolder> GetFolders(Enums.ResourceType resourceType)
        {
            return _resourceBusiness.GetFolders(resourceType);
        }
    }
}
