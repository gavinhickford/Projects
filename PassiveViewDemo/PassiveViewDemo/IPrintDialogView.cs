using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo
{
    /// <summary>
    /// This is the interface specific to one view and it contains properties for all 
    /// input fields such as text boxes, check boxes, drop downs etc., labels and 
    /// state properties of the controls.
    /// </summary>
    public interface IPrintDialogView : IView<IPrintDialogPresenterCallbacks> 
    {
        string MyText { get; set; }
        string SaveButtonText { get; set; }
        bool SaveButtonEnabled { get; set; }
    }
}
