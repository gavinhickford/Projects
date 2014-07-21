using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintDialog
{
    public class PropertyChangeRequestEventArgs<T>:EventArgs
    {
        public PropertyChangeRequestEventArgs(T pRequestedValue)
        {
            RequestedValue = pRequestedValue;
        }

        public T RequestedValue { get; set; }
    }
}
