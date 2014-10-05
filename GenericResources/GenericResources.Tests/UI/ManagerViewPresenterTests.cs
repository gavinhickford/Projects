using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GenericResources.UI.Interfaces;
using GenericResources.Common.Interfaces;
using GenericResources.UI.Presenters;
using GenericResources.Common.Enums;
using GenericResources.Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GenericResources.Tests.UI
{
    [TestClass]
    public class ManagerViewPresenterTests
    {
        [TestMethod]
        public void Initialize_ConceptsView_SetsHeaderText()
        {
            // Arrange
            var mockView = new Mock<IManagerView>();
            mockView.Setup(v => v.ResourceType).Returns(ResourceType.Concept);
            
            var mockService = new Mock<IResourceService>();
            List<IFolder> fakeFolders = new List<IFolder>{new Folder{Name = "Folder"}} ;
            mockService.Setup(s => s.GetFolders(ResourceType.Concept)).Returns(fakeFolders);

            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object, 
                (IResourceService)mockService.Object);

            string expectedHeader = "Concept";

            // Act
            presenter.Initialize();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            mockView.VerifySet(v => v.Folders = fakeFolders);
        }

        [TestMethod]
        public void Initialize_ProtocolsView_SetsHeaderText()
        {
            // Arrange
            var mockView = new Mock<IManagerView>();
            mockView.Setup(v => v.ResourceType).Returns(ResourceType.Protocol);

            var mockService = new Mock<IResourceService>();
            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            mockService.Setup(s => s.GetFolders(ResourceType.Protocol)).Returns(fakeFolders);

            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            string expectedHeader = "Protocol";

            // Act
            presenter.Initialize();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            mockView.VerifySet(v => v.Folders = fakeFolders);
        }
    }
}
