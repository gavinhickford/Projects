using GenericResources.Common.Enums;
using GenericResources.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericResources.UI.Interfaces
{
    public interface IManagerView : IView<IManagerViewPresenterCallbacks>
    {
        ResourceType ResourceType { get; set; }
        event EventHandler<EventArgs> ResourceTypeChanged;
        string HeaderText { get; set; }
        void DisplayFolders(List<IFolder> folders);
        void DisplaySelectedFolderItems();
    }
}
