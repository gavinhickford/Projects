using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Domain.Interfaces
{
    public interface IResourceDataStore
    {
        List<IFolder> GetFolders();
    }
}
