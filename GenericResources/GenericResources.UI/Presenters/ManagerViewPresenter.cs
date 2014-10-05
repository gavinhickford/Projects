using GenericResources.Domain.Interfaces;
using GenericResources.Domain.Services;
using GenericResources.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericResources.UI.Presenters
{
    public class ManagerViewPresenter : IManagerViewPresenter
    {
        private readonly IManagerView _managerView;
        IResourceService _resourceService;

        public ManagerViewPresenter(IManagerView managerView)
        {
            _managerView = managerView;
            _resourceService = new ResourceService();
            _managerView.ResourceTypeChanged += this.ResourceTypeChanged;

            _managerView.Initialize(_resourceService.GetFolders(_managerView.ResourceType));
        }

        private void ResourceTypeChanged(object sender, EventArgs e)
        {
            _managerView.Initialize(_resourceService.GetFolders(_managerView.ResourceType));
        }
    }
}
