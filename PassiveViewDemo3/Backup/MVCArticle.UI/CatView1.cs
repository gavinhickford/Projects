using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCArticle.UI
{
    public partial class CatView1 : UserControl, ICatView
    {
        #region Constructors

        public CatView1()
        {
            InitializeComponent();
            m_changeRequestedEvents = new ChangeRequestEvents(this);
        }

        #endregion

        #region Member Variables

        private ChangeRequestEvents m_changeRequestedEvents;

        #endregion

        #region Methods

        private void m_btnIncrementAge_Click(object sender, EventArgs e)
        {
            m_changeRequestedEvents.Fire<Int32>("Age", Int32.Parse(m_lblAge.Text) + 1);
        }

        #endregion

        #region ICatView Members

        public int CatAge
        {
            set
            {
                m_lblAge.Text = value.ToString();
            }
        }

        public string CatName
        {
            set { m_lblName.Text = value; }
        }

        public void RegisterChangRequestListener<T>(string propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler)
        {
            m_changeRequestedEvents.RegisterListener<T>(propertyName, handler);
        }

        public void UnRegisterChangRequestListener<T>(string propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler)
        {
            m_changeRequestedEvents.UnRegisterListener<T>(propertyName, handler);
        }

        #endregion
    }
}
