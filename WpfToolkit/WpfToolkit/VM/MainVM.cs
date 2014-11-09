using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
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
        }

        public FolderTreeVM ChildVM 
        {
            get { return _childVM; }
            set { Set(() => ChildVM, ref _childVM, value); }
        }
    }
}
