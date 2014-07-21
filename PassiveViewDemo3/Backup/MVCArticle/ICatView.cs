using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCArticle
{
    public interface ICatView
    {
        String CatName { set; }
        Int32 CatAge { set; }

        void RegisterChangRequestListener<T>(String propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler);
        void UnRegisterChangRequestListener<T>(String propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler);
    }
}
