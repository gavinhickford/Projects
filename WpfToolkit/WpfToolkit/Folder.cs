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
        private ObservableCollection<Folder> _folders;

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }

        public ObservableCollection<Folder> Folders
        {
            get { return _folders; }
            set { Set(() => Folders, ref _folders, value); }
        }
    }
}
