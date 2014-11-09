using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolkit.VM
{
    public class FolderTreeVM : ViewModelBase
    {
        private string _title = "...........";

        public string Title
        {
            get { return _title; }
            set { Set(() => Title, ref _title, value); }
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
    }
}
