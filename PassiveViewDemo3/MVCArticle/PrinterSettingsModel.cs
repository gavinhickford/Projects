using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing.Printing;

namespace PrintDialog
{
    public class PrinterSettingsModel: INotifyPropertyChanged
    {
        #region Member Variables

        private String _selectedPrinter;
        private Int32 _numberOfCopies;
        private event PropertyChangedEventHandler _propertyChanged;

        #endregion

        #region Properties

        public String SelectedPrinter
        {
            get { return _selectedPrinter; }
            set 
            {
                if(_selectedPrinter != value)
                {
                    _selectedPrinter = value;

                    // if there is a change... raise the event to notify the control
                    if(null != _propertyChanged)
                        _propertyChanged(this, new PropertyChangedEventArgs("SelectedPrinter"));
                }
            }
        }

        public Int32 NumberOfCopies
        {
            get { return _numberOfCopies; }
            set
            {
                if (_numberOfCopies != value)
                {
                    _numberOfCopies = value;

                    // if there is a change... raise the event to notify the control
                    if (null != _propertyChanged)
                        _propertyChanged(this, new PropertyChangedEventArgs("NumberOfCopies"));
                }
            }
        }

        public IList<string> Printers
        {
            get {
                List<string> printers = new List<string>();
                foreach(string p in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    printers.Add(p);
                }
                return  printers; 
            }
        }
 

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged
        {
            add{ _propertyChanged += value; }
            remove{ _propertyChanged -= value; }
        }

        #endregion
    }
}
