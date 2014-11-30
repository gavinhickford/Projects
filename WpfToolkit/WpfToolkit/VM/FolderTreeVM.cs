using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
        private string _title;
        private ObservableCollection<Folder> _folders;

        public FolderTreeVM()
        {
            SelectedFolderChanged = new RelayCommand<Folder>(f => SelectedFolder = f);
        }

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

        public RelayCommand<Folder> SelectedFolderChanged { get; private set; }

        public Folder SelectedFolder { get; private set; }
    }
}
