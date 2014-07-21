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
    public partial class PrintPreviewView : UserControl, IPrinterSettingsView
    {
        #region Constructors

        public PrintPreviewView()
        {
            InitializeComponent();
            _changeRequestedEvents = new ChangeRequestEvents(this);

            
        }

        #endregion

        #region Member Variables

        private ChangeRequestEvents _changeRequestedEvents;

        #endregion

        #region Methods

        private void IncrementNumberOfCopiesButton_Click(object sender, EventArgs e)
        {
            _changeRequestedEvents.Fire<Int32>("NumberOfCopies", Int32.Parse(NoOfCopiesLabel.Text) + 1);
        }

        #endregion

        #region IPrinterSettingsView Members

        public int NumberOfCopies
        {
            set
            {
                NoOfCopiesLabel.Text = value.ToString();
            }
        }

        public string SelectedPrinter
        {
            set { SelectedPrinterLabel.Text = value; }
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
