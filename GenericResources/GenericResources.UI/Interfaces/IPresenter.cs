using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericResources.UI.Interfaces
{
    public interface IPresenter
    {
        void Initialize();
        object UI { get; }
    }
}
