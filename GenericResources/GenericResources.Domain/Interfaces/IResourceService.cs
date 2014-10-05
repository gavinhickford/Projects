using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Interfaces
{
    public interface IResourceService 
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
    }
}
