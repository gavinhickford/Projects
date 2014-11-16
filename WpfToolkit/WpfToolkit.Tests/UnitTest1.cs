using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WpfToolkit;
using WpfToolkit.VM;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace WpfToolkit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MainVM_Creates_ChildTreeview_withSingleNode()
        {
            var expectedFolders = new List<Folder> 
            { 
                new Folder { Name = "TestFolder", Id = 1, ParentId = -1 } 
            };
            var mockService = new Mock<IFolderService>();
            mockService.Setup(f => f.GetFolders()).Returns(expectedFolders);
            MainVM mainVM= new MainVM(mockService.Object, "test");
            Assert.AreEqual(mainVM.ChildVM.Folders.Count, expectedFolders.Count);
        }

        [TestMethod]
        public void MainVM_Creates_ChildTreeview_withHierarchicalNode()
        {
            var expectedFolders = new List<Folder> 
            { 
                new Folder { Name = "TestFolder", Id = 1, ParentId = -1 },
                new Folder { Name = "ChildFolder", Id = 2, ParentId = 1 },
            };
            var mockService = new Mock<IFolderService>();
            mockService.Setup(f => f.GetFolders()).Returns(expectedFolders);
            MainVM mainVM = new MainVM(mockService.Object, "test");
            Assert.AreEqual(mainVM.ChildVM.Folders.Count, 1);
        }
    }
}
