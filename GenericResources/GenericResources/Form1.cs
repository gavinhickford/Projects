using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericResources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConceptsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ConceptsRadioButton.Checked)
                managerView1.ResourceType = Enums.ResourceType.Concept;
        }

        private void ProtocolsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtocolsRadioButton.Checked)
                managerView1.ResourceType = Enums.ResourceType.Protocol;
        }

        private void TemplatesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TemplatesRadioButton.Checked)
                managerView1.ResourceType = Enums.ResourceType.Template;
        }

        private void DocumentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DocumentsRadioButton.Checked)
                managerView1.ResourceType = Enums.ResourceType.DocumentTemplate;
        }

        private void LibraryItemsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LibraryItemsRadioButton.Checked)
                managerView1.ResourceType = Enums.ResourceType.LibraryItem;
        }

        private void managerView1_ResourceTypeChanged(object sender, EventArgs e)
        {
            managerView1.Refresh();
        }
    }
}
