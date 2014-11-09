using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolkit.VM
{
    public class FolderTreeVM : ViewModelBase
    {
        private string _title = "...........";
        private ObservableCollection<Folder> _folders = new ObservableCollection<Folder>
        {
            new Folder
            {
                Name = "EMIS",
                Folders = new ObservableCollection<Folder>
                {
                    new Folder{Name = "Qof1"},
                    new Folder{Name = "Qof2"}
                }
            },
            new Folder
            {
                Name = "My Org",
                Folders = new ObservableCollection<Folder>
                {
                    new Folder{Name = "Org Folder1"},
                    new Folder
                    {
                        Name = "Org Folder2",
                        Folders = new ObservableCollection<Folder>
                        {
                            new Folder{Name = "Child1"},
                            new Folder{Name = "Child2"}
                        }   
                    }
                }
            },
            new Folder
            {
                Name = "Shared Org",
                Folders = new ObservableCollection<Folder>
                {
                    new Folder{Name = "Shared Folder1"},
                    new Folder
                    {
                        Name = "Shared Folder2",
                        Folders = new ObservableCollection<Folder>
                        {
                            new Folder{Name = "SharedChild1"},
                            new Folder{Name = "SharedChild2"}
                        }   
                    }
                }
            }
        };
   
        public string Title
        {
            get { return _title; }
            set { Set(() => Title, ref _title, value); }
        }

        public ObservableCollection<Folder> Folders
        {
            get { return _folders; }
            set { Set(() => Folders, ref _folders, value); }
        }
    }
}
