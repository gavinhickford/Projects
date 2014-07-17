using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveViewDemo
{
    public partial class PrintDialogView : UserControl, IPrintDialogView
    {

        public PrintDialogView()
        {
            InitializeComponent();

            PrintDialogPresenter presenter = new PrintDialogPresenter(this);
            this.Attach(presenter);
        }

        public void Attach(IPrintDialogPresenterCallbacks callback)
        {
            SaveButton.Click += (sender, e) => callback.OnSave();
            TextBox.TextChanged += (sender, e) => callback.OnMyTextChanged();

        }
    
        public string MyText
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public string SaveButtonText
        {
            get { return SaveButton.Text; }
            set { SaveButton.Text = value; }
        }

        public bool SaveButtonEnabled
        {
            get { return SaveButton.Enabled; }
            set { SaveButton.Enabled = value; }
        }

    }
}
