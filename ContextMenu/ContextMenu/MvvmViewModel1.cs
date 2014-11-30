using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows;

namespace ContextMenu
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MvvmViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MvvmViewModel1 class.
        /// </summary>
        public MvvmViewModel1()
        {
            ContextMenuOpeningCommand = new RelayCommand(
              ExecuteMyCommand);
        }

        public RelayCommand ContextMenuOpeningCommand
        {
            get;
            private set;
        }
  
        private void ExecuteMyCommand() 
        {
            IsVisible = Visibility.Collapsed; 
        }

        private Visibility _isVisible;

        public Visibility IsVisible
        {
            get { return _isVisible; }
            set { Set(() => IsVisible, ref _isVisible, value); }
        }
    }
}