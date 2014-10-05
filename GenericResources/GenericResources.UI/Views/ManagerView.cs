using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GenericResources.Domain.Enums;
using GenericResources.Domain.Entities;
using GenericResources.Domain.Interfaces;
using GenericResources.Domain.Services;
using GenericResources.UI.Interfaces;
using GenericResources.UI.Presenters;

namespace GenericResources.UI.Views
{
    public partial class ManagerView : UserControl, IManagerView
    {
        private IManagerViewPresenter _presenter;
        public ManagerView()
        {
            InitializeComponent();
            _presenter = new ManagerViewPresenter(this);
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

        public void Initialize(List<IFolder> folders) 
        {
            treeView1.Nodes.Clear();
            foreach (IFolder folder in folders)
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
    }
}
