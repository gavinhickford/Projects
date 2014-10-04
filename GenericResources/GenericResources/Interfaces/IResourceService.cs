using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Interfaces
{
    public interface IResourceService 
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
    }
}
