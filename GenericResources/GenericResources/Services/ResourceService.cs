using GenericResources.Entities;
using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Services
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
