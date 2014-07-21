using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintDialog
{
    public class PrinterSettingsPresenter: PresenterBase<PrinterSettingsModel, IPrinterSettingsView>
    {
        public PrinterSettingsPresenter(PrinterSettingsModel model, IPrinterSettingsView view)
        {
            Initialize(model, view);
        }

        protected override void WireEvents()
        {
            Model.PropertyChanged += Model_PropertyChanged;
            View.RegisterChangRequestListener<String>("SelectedPrinter", View_OnSelectedPrinterChangeRequest);
            View.RegisterChangRequestListener<Int32>("NumberOfCopies", View_OnNumberOfCopiesChangeRequest);
        }

        protected override void UnwireEvents()
        {
            Model.PropertyChanged -= Model_PropertyChanged;
            View.UnRegisterChangRequestListener<String>("SelectedPrinter", View_OnSelectedPrinterChangeRequest);
            View.UnRegisterChangRequestListener<Int32>("NumberOfCopies", View_OnNumberOfCopiesChangeRequest);
        }

        private void View_OnSelectedPrinterChangeRequest(Object sender, PropertyChangeRequestEventArgs<String> args)
        {
            Model.SelectedPrinter = args.RequestedValue;
        }

        private void View_OnNumberOfCopiesChangeRequest(Object sender, PropertyChangeRequestEventArgs<Int32> args)
        {
            Model.NumberOfCopies = args.RequestedValue;
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SelectedPrinter":
                    View.SelectedPrinter = Model.SelectedPrinter;
                    break;
                case "NumberOfCopies":
                    View.NumberOfCopies = Model.NumberOfCopies;
                    break;
                default:
                    throw new ArgumentException("Property not handled: " + e.PropertyName);
            }
        }

        protected override void SetViewState()
        {
            View.NumberOfCopies = Model.NumberOfCopies;
            View.SelectedPrinter = Model.SelectedPrinter;
        }
    }
}
