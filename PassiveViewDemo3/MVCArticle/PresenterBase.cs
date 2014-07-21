using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintDialog
{
    public abstract class PresenterBase<TModel, TView> : IDisposable
    {
        #region Member Variables

        protected TView _view;
        protected TModel _model;

        #endregion

        #region Abstract Methods

        protected abstract void WireEvents();
        protected abstract void UnwireEvents();
        protected abstract void SetViewState();

        #endregion

        #region Methods

        public virtual void Initialize(TModel model, TView view)
        {
            if (_model != null || _view != null)
                UnwireEvents();

            _model = model;
            _view = view;

            SetViewState();
            WireEvents();
        }

        #endregion

        #region Properties

        public TModel Model { get { return _model; } }
        public TView View { get { return _view; } }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            UnwireEvents();
        }

        #endregion
    }
}
