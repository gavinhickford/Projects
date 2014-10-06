using GenericResources.Common.Enums;
using GenericResources.Common.Interfaces;
using GenericResources.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenericResources.UI.Views
{
    public partial class ManagerView : UserControl, IManagerView
    {
        #region private fields

        private ResourceType _resourceType;

        #endregion

        #region constructor

        public ManagerView()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        public event EventHandler<EventArgs> ResourceTypeChanged;

        public virtual void OnResourceTypeChanged(object sender, EventArgs e)
        {
            if (null != ResourceTypeChanged)
            {
                ResourceTypeChanged(sender, e);
            }
        }

        #endregion

        #region Properties

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

        #endregion

        #region Public methods

        public void Attach(IManagerViewPresenterCallbacks callback)
        {
            ResourceTypeChanged += (sender, e) => callback.OnResourceTypeChanged();
            this.treeView1.AfterSelect += (sender, e) => callback.OnAfterSelect();
        }

        public void DisplayFolders(List<IFolder> folders)
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

        // TODO - pass in a list of folder itesm to be displayed
        public void DisplaySelectedFolderItems()
        {
            MessageBox.Show("folder selected");
        }

        #endregion

        #region Private methods

        private static void AddChildNodes(IFolder folder, TreeNode node)
        {
            foreach (IFolder childFolder in folder.ChildFolders)
            {
                TreeNode childnode = node.Nodes.Add(childFolder.Name);
                childnode.ImageIndex = 0;
            }
        }

        private TreeNode AddNode(IFolder folder, TreeNode parentNode)
        {
            TreeNode node = null;
            if (parentNode != null)
            {
                node = parentNode.Nodes.Add(folder.Name);
                node.ImageIndex = 0;
            }
            else
            {
                node = treeView1.Nodes.Add(folder.Name);
                node.ImageIndex = 0;
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

        #endregion
    }
}
