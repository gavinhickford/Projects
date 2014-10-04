using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Interfaces
{
    public interface IResourceDataStore
    {
        List<IFolder> GetFolders();
    }
}
