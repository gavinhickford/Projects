using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCArticle
{
    public abstract class MvcControlBase<TModel, TView> : IDisposable
    {
        #region Member Variables

        protected TView m_view;
        protected TModel m_model;

        #endregion

        #region Abstract Methods

        protected abstract void WireEvents();
        protected abstract void UnwireEvents();
        protected abstract void SetViewState();

        #endregion

        #region Methods

        public virtual void Initialize(TModel model, TView view)
        {
            if (m_model != null || m_view != null)
                UnwireEvents();

            m_model = model;
            m_view = view;

            SetViewState();
            WireEvents();
        }

        #endregion

        #region Properties

        public TModel Model { get { return m_model; } }
        public TView View { get { return m_view; } }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            UnwireEvents();
        }

        #endregion
    }
}
