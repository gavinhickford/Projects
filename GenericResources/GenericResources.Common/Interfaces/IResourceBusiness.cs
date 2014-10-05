using GenericResources.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Interfaces
{
    public interface IResourceBusiness
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
    }
}
