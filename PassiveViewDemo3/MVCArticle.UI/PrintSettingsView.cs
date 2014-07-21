using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintDialog.UI
{
    public partial class PrintSettingsView : UserControl, IPrinterSettingsView
    {
        #region Constructors

        public PrintSettingsView()
        {
            InitializeComponent();
            _changeRequestedEvents = new ChangeRequestEvents(this);
          }

        #endregion

        #region Member Variables

        private ChangeRequestEvents _changeRequestedEvents;

        #endregion

        #region Methods

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _changeRequestedEvents.Fire<String>("SelectedPrinter", SelectedPrinterTextBox.Text);
        }

        #endregion

        #region IPrinterSettingsView Members


        public int NumberOfCopies
        {
            set { m_lblAge.Text = value.ToString(); }
        }

        public string SelectedPrinter
        {
            set { SelectedPrinterTextBox.Text = value; }
        }


        public void RegisterChangRequestListener<T>(string propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler)
        {
            _changeRequestedEvents.RegisterListener<T>(propertyName, handler);
        }

        public void UnRegisterChangRequestListener<T>(string propertyName, EventHandler<PropertyChangeRequestEventArgs<T>> handler)
        {
            _changeRequestedEvents.UnRegisterListener<T>(propertyName, handler);
        }

        #endregion
    }
}
