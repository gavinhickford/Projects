using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfToolkit.Main;

namespace WpfToolkit.VM
{
    public class MainVM : ViewModelBase
    {
        private FolderTreeVM _childVM;
        private IFolderService _folderService;

        public MainVM(IFolderService folderService)
        {
            _folderService = folderService;
            var folders = _folderService.GetFolders();
            ChildVM = new FolderTreeVM();
            ChildVM.Title = "My org title";
            ChildVM.Folders = Resolve(folders);
        }

        public FolderTreeVM ChildVM 
        {
            get { return _childVM; }
            set { Set(() => ChildVM, ref _childVM, value); }
        }

        private ObservableCollection<Folder> Resolve(List<Folder> folders)
        {
            foreach (Folder folder in folders)
            {
                folder.Folders = new ObservableCollection<Folder>(folders.Where(child => child.ParentId == folder.Id));
            }

            ObservableCollection<Folder> resolvedFolders = new ObservableCollection<Folder>(folders.Where(item => item.ParentId == -1));

            return resolvedFolders;
        }
    }
}
