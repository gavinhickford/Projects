using GenericResources.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Interfaces
{
    public interface IResourceBusiness
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
    }
}
