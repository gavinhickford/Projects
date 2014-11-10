using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolkit
{
    public class Folder : ObservableObject
    {
        private string _name;
        private int _id;
        private int _parentId;
        private ObservableCollection<Folder> _folders;

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }

        public int Id
        {
            get { return _id; }
            set { Set(() => Id, ref _id, value); }
        }

        public int ParentId 
        {
            get { return _parentId; }
            set { Set(() => ParentId, ref _parentId, value); }
        }

        public ObservableCollection<Folder> Folders
        {
            get { return _folders; }
            set { Set(() => Folders, ref _folders, value); }
        }
    }
}
