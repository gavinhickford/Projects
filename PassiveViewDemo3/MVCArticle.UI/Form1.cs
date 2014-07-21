using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintDialog.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrinterSettingsModel model = new PrinterSettingsModel() 
            { 
                NumberOfCopies = 10, 
                SelectedPrinter = "Printer 1" 
            };

            new PrinterSettingsPresenter(model, PrintPreviewView); // wire up cat view 1
            new PrinterSettingsPresenter(model, PrinterSettingsView); // wire up cat view 2
        }
    }
}
