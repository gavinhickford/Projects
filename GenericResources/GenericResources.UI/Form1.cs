using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenericResources.Common.Enums;
using GenericResources.UI.Interfaces;
using GenericResources.UI.Presenters;
using GenericResources.Domain.Services;

namespace GenericResources.UI
{
    public partial class Form1 : Form
    {
        private IManagerViewPresenter _presenter;
        
        public Form1()
        {
            InitializeComponent();
            _presenter = new ManagerViewPresenter(this.managerView1, new ResourceService());
        }

        private void ConceptsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ConceptsRadioButton.Checked)
                managerView1.ResourceType = ResourceType.Concept;
        }

        private void ProtocolsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtocolsRadioButton.Checked)
                managerView1.ResourceType = ResourceType.Protocol;
        }

        private void TemplatesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TemplatesRadioButton.Checked)
                managerView1.ResourceType = ResourceType.Template;
        }

        private void DocumentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DocumentsRadioButton.Checked)
                managerView1.ResourceType = ResourceType.DocumentTemplate;
        }

        private void LibraryItemsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LibraryItemsRadioButton.Checked)
                managerView1.ResourceType = ResourceType.LibraryItem;
        }

    }
}
