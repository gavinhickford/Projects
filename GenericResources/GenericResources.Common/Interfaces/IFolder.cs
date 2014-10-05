using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Common.Interfaces
{
    public interface IFolder
    {
        string Name { get; set; }
        IFolder ParentFolder { get; set; }
        List<IFolder> ChildFolders { get; set; }
    }
}
