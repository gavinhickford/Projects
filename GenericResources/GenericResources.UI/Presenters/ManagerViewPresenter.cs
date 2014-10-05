using GenericResources.Common.Interfaces;
using GenericResources.Domain.Services;
using GenericResources.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenericResources.UI.Presenters
{
    public class ManagerViewPresenter : IManagerViewPresenter, IManagerViewPresenterCallbacks
    {
        private readonly IManagerView _managerView;
        IResourceService _resourceService;

        public ManagerViewPresenter(IManagerView managerView, IResourceService service)
        {
            _managerView = managerView;
            _resourceService = service;
            Initialize();
        }

        public object UI
        {
            get { return _managerView; }
        }

        public void Initialize()
        {
            _managerView.Attach(this);
            _managerView.HeaderText = GetHeaderText();
            _managerView.Folders = GetFolders();
        }

        private string GetHeaderText()
        {
            return this._managerView.ResourceType.ToString();
        }

        public void OnResourceTypeChanged()
        {
            _managerView.Folders = GetFolders();
            _managerView.HeaderText = GetHeaderText();
            _managerView.Display();
        }

        private List<IFolder> GetFolders()
        {
            return _resourceService.GetFolders(_managerView.ResourceType);
        }
    }
}

