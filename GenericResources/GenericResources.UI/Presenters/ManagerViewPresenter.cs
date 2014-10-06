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
        #region Private fields

        private readonly IManagerView _managerView;
        private IResourceService _resourceService;

        #endregion

        #region Constructor

        public ManagerViewPresenter(IManagerView managerView, IResourceService service)
        {
            _managerView = managerView;
            _resourceService = service;
            Initialize();
        }

        #endregion

        #region Properties 

        public object UI
        {
            get { return _managerView; }
        }

        #endregion

        #region Public methods

        public void Initialize()
        {
            _managerView.Attach(this);
            _managerView.HeaderText = GetHeaderText();
            _managerView.DisplayFolders(GetFolders());
        }

        public void OnResourceTypeChanged()
        {
            _managerView.HeaderText = GetHeaderText();
            _managerView.DisplayFolders(GetFolders());
        }

        public void OnAfterSelect()
        {
            _managerView.DisplaySelectedFolderItems();
        }

        #endregion

        #region Private methods

        private string GetHeaderText()
        {
            return this._managerView.ResourceType.ToString();
        }
        
        private List<IFolder> GetFolders()
        {
            return _resourceService.GetFolders(_managerView.ResourceType);
        }

        #endregion
    }
}

