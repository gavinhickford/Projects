using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCArticle
{
    public class CatControl: MvcControlBase<CatModel, ICatView>
    {
        public CatControl(CatModel model, ICatView view)
        {
            Initialize(model, view);
        }

        protected override void WireEvents()
        {
            Model.PropertyChanged += Model_PropertyChanged;
            View.RegisterChangRequestListener<String>("Name", View_OnNameChangeRequest);
            View.RegisterChangRequestListener<Int32>("Age", View_OnAgeChangeRequest);
        }

        protected override void UnwireEvents()
        {
            Model.PropertyChanged -= Model_PropertyChanged;
            View.UnRegisterChangRequestListener<String>("Name", View_OnNameChangeRequest);
            View.UnRegisterChangRequestListener<Int32>("Age", View_OnAgeChangeRequest);
        }

        private void View_OnNameChangeRequest(Object sender, PropertyChangeRequestEventArgs<String> args)
        {
            Model.Name = args.RequestedValue;
        }

        private void View_OnAgeChangeRequest(Object sender, PropertyChangeRequestEventArgs<Int32> args)
        {
            Model.Age = args.RequestedValue;
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Name":
                    View.CatName = Model.Name;
                    break;
                case "Age":
                    View.CatAge = Model.Age;
                    break;
                default:
                    throw new ArgumentException("Property not handled: " + e.PropertyName);
            }
        }

        protected override void SetViewState()
        {
            View.CatAge = Model.Age;
            View.CatName = Model.Name;
        }
    }
}
