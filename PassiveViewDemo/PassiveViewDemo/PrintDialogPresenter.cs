using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo
{
    public class PrintDialogPresenter : IPrintDialogPresenter, IPrintDialogPresenterCallbacks
    {
        private IPrintDialogView _view;

        public PrintDialogPresenter(IPrintDialogView view)
        {
            _view = view;
            Initialize();
        }

        public object View
        {
            get { return _view; }
        }

        public void Initialize()
        {
            _view.Attach(this);
            _view.SaveButtonText = "Save";
            _view.SaveButtonEnabled = false;
        }

        public void OnSave()
        {
            // Save _view.MyText
        }
 
        public void OnMyTextChanged()
        {
            _view.SaveButtonEnabled = !string.IsNullOrEmpty(_view.MyText);
        }
    }
}
