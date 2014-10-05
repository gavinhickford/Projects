using GenericResources.Domain.Enums;
using GenericResources.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericResources.UI.Interfaces
{
    public interface IManagerView
    {
        ResourceType ResourceType { get; set; }
        void Initialize(List<IFolder> folders);
        event EventHandler<EventArgs> ResourceTypeChanged;
    }
}
