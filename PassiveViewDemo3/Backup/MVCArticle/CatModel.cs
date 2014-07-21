using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MVCArticle
{
    public class CatModel: INotifyPropertyChanged
    {
        #region Member Variables

        private String m_name;
        private Int32 m_age;
        private event PropertyChangedEventHandler m_propertyChanged;

        #endregion

        #region Properties

        public String Name
        {
            get { return m_name; }
            set 
            {
                if(m_name != value)
                {
                    m_name = value;

                    // if there is a change... raise the event to notify the control
                    if(null != m_propertyChanged)
                        m_propertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public Int32 Age
        {
            get { return m_age; }
            set
            {
                if (m_age != value)
                {
                    m_age = value;

                    // if there is a change... raise the event to notify the control
                    if (null != m_propertyChanged)
                        m_propertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }
 

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged
        {
            add{ m_propertyChanged += value; }
            remove{ m_propertyChanged -= value; }
        }

        #endregion
    }
}
