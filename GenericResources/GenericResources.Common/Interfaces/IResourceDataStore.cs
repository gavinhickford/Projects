using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Interfaces
{
    public interface IResourceDataStore
    {
        List<IFolder> GetFolders();
    }
}
