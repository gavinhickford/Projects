using GenericResources.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Interfaces
{
    public interface IResourceBusiness
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
    }
}
