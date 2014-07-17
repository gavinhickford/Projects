using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo
{
    /// <summary>
    /// A simple generic interface with one method used by the presenter to attach itself. 
    /// The TCallbacks type parameter is the type of the callbacks interface that the presenter implements. 
    /// </summary>
    /// <typeparam name="TCallbacks"></typeparam>
    public interface IView<TCallbacks>
    {
        void Attach(TCallbacks presenter);
    }
}
