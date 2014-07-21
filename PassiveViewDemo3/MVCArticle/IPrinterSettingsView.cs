using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintDialog
{
    public interface IPrinterSettingsView
    {
        String SelectedPrinter { set; }
        Int32 NumberOfCopies { set; }

        void RegisterChangRequestListener<T>(String propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler);
        void UnRegisterChangRequestListener<T>(String propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler);
    }
}
