﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Interfaces
{
    public interface IResourceService 
    {
        List<IFolder> GetFolders(Enums.ResourceType resourceType);
        List<IResource> GetResources(Enums.ResourceType resourceType, int folderId);
    }
}
