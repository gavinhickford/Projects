using GenericResources.Common.Enums;
using GenericResources.Common.Interfaces;
//using GenericResources.Common.Interfaces;
using GenericResources.Domain.Services;
using GenericResources.UI.Interfaces;
using GenericResources.UI.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenericResources.UI.Views
{
    public partial class ManagerView : UserControl, IManagerView
    {
        public ManagerView()
        {
            InitializeComponent();
        }
        
        public event EventHandler<EventArgs> ResourceTypeChanged;

        private ResourceType _resourceType;

        public virtual void OnResourceTypeChanged(object sender, EventArgs e)
        {
            if (null != ResourceTypeChanged)
            {
                ResourceTypeChanged(sender, e);
            }
        }

        [Description("Header Text"), Category("Data")]
        public string HeaderText
        {
            get { return HeaderLabel.Text; }
            set { HeaderLabel.Text = value; }
        }
     
        [Description("Type of Resource"), Category("Data")]
        public ResourceType ResourceType
        {
            get { return _resourceType; }
            set 
            {
                _resourceType = value;
                OnResourceTypeChanged(this, new EventArgs());
            }
        }
        private List<IFolder> _folders;
        
        public List<IFolder> Folders
        {
            get { return _folders; }
            set { _folders = value; }
        }

        public void Display()
        {
            DisplayFolders();
        }

        private void DisplayFolders()
        {
            treeView1.Nodes.Clear();
            foreach (IFolder folder in Folders)
            {
                TreeNode parentNode = AddParentFolder(folder);
                TreeNode node = AddNode(folder, parentNode);
                AddChildNodes(folder, node);
            }
            treeView1.ExpandAll();
        }
                
        private static void AddChildNodes(IFolder folder, TreeNode node)
        {
            foreach (IFolder childFolder in folder.ChildFolders)
            {
                node.Nodes.Add(childFolder.Name);
            }
        }

        private TreeNode AddNode(IFolder folder, TreeNode parentNode)
        {
            TreeNode node = null;
            if (parentNode != null)
            {
                node = parentNode.Nodes.Add(folder.Name);
            }
            else
            {
                node = treeView1.Nodes.Add(folder.Name);
            }
            return node;
        }

        private TreeNode AddParentFolder(IFolder folder)
        {
            TreeNode parentNode = null;

            if (folder.ParentFolder != null)
            {
                parentNode = treeView1.Nodes.Add(folder.ParentFolder.Name);
            }
            return parentNode;
        }

        public void Attach(IManagerViewPresenterCallbacks callback)
        {
            ResourceTypeChanged += (sender, e) => callback.OnResourceTypeChanged();
        }
    }
}
