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
        public MainVM()
        {
            ChildVM = new FolderTreeVM();
            ChildVM.Title = "My org title";
            ChildVM.Folders = GetFolders();
        }

        public FolderTreeVM ChildVM 
        {
            get { return _childVM; }
            set { Set(() => ChildVM, ref _childVM, value); }
        }

        private ObservableCollection<Folder> GetFolders()
        {
            var folders = new ObservableCollection<Folder> 
            {
                new Folder
                {
                    Id = 1,
                    Name = "EMIS",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 2,
                    Name = "My Org",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 3,
                    Name = "Org Folder1",
                    ParentId = 2
                },
                new Folder
                {
                    Id = 4,
                    Name = "Org Folder2",
                    ParentId = 2
                },
                new Folder
                {
                    Id = 5,
                    Name = "Child1",
                    ParentId = 4
                },
                new Folder
                {
                    Id = 6,
                    Name = "Child2",
                    ParentId = 4
                },
                new Folder
                {
                    Id = 7,
                    Name = "Shared Org",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 8,
                    Name = "Shared Folder1",
                    ParentId = 7
                },
                new Folder
                {
                    Id = 9,
                    Name = "Shared Folder2",
                    ParentId = 7
                },
                new Folder
                {
                    Id = 10,
                    Name = "SharedChild1",
                    ParentId = 9
                },
                new Folder
                {
                    Id = 11,
                    Name = "SharedChild2",
                    ParentId = 9
                }
            };
            var x = Resolve(folders.ToList()); 
            return x;
        }

        private ObservableCollection<Folder> Resolve(List<Folder> folders)
        {
            foreach (Folder folder in folders)
            {
                folder.Folders = new ObservableCollection<Folder>(folders.Where(child => child.ParentId == folder.Id));
            }
            
            ObservableCollection<Folder> resolvedFolders =new ObservableCollection<Folder>(folders.Where(item => item.ParentId == -1));

            return resolvedFolders; 
        }
    }
}
