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
    public partial class CatView2 : UserControl, ICatView
    {
        #region Constructors

        public CatView2()
        {
            InitializeComponent();
            m_changeRequestedEvents = new ChangeRequestEvents(this);
        }

        #endregion

        #region Member Variables

        private ChangeRequestEvents m_changeRequestedEvents;

        #endregion

        #region Methods

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_changeRequestedEvents.Fire<String>("Name", m_txtName.Text);
        }

        #endregion

        #region ICatView Members


        public int CatAge
        {
            set { m_lblAge.Text = value.ToString(); }
        }

        public string CatName
        {
            set { m_txtName.Text = value; }
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
