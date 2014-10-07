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
        public void Initialize_ConceptsView_InitialisesView()
        {
            // Arrange
            var type = ResourceType.Concept;
            string expectedHeader = "Concept";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
                                    
            // Act
            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
            
            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called once 
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Once);
        }

        [TestMethod]
        public void Initialize_ProtocolsView_InitialisesView()
        {
            // Arrange
            var type = ResourceType.Protocol;
            string expectedHeader = "Protocol";
            var mockView = GenerateMockView(type);
                        
            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            // Act
            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
            
            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called once 
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Once);
        }

        [TestMethod]
        public void Initialize_DocumentTemplateView_InitialisesView()
        {
            // Arrange
            var type = ResourceType.DocumentTemplate;
            string expectedHeader = "DocumentTemplate";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            // Act
            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
            
            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called once 
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Once);
        }

        [TestMethod]
        public void Initialize_LibraryItemView_InitialisesView()
        {
            // Arrange
            var type = ResourceType.LibraryItem;
            string expectedHeader = "LibraryItem";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            // Act
            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
            
            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called once 
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Once);
        }

        [TestMethod]
        public void Initialize_TemplateView_InitialisesView()
        {
            // Arrange
            var type = ResourceType.Template;
            string expectedHeader = "Template";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            // Act
            IManagerViewPresenter presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
            
            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called once 
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Once);
        }

        [TestMethod]
        public void ResourceChanged_ConceptsView_SetsHeaderText()
        {
            // Arrange
            var type = ResourceType.Concept;
            string expectedHeader = "Concept";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
            
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);
                    
            // Act
            presenter.OnResourceTypeChanged();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called twice - once for initialisation and once for type changed event
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Exactly(2));
        }

        [TestMethod]
        public void ResourceChanged_ProtocolsView_SetsHeaderText()
        {
            // Arrange
            var type = ResourceType.Protocol;
            string expectedHeader = "Protocol";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnResourceTypeChanged();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called twice - once for initialisation and once for type changed event
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Exactly(2));
        }

        [TestMethod]
        public void ResourceChanged_TemplatesView_SetsHeaderText()
        {
            // Arrange
            var type = ResourceType.Template;
            string expectedHeader = "Template";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnResourceTypeChanged();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called twice - once for initialisation and once for type changed event
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Exactly(2));
        }

        [TestMethod]
        public void ResourceChanged_DocumentTemplatesView_SetsHeaderText()
        {
            // Arrange
            var type = ResourceType.DocumentTemplate;
            string expectedHeader = "DocumentTemplate";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnResourceTypeChanged();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called twice - once for initialisation and once for type changed event
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Exactly(2));
        }

        [TestMethod]
        public void ResourceChanged_LibraryItemsView_SetsHeaderText()
        {
            // Arrange
            var type = ResourceType.LibraryItem;
            string expectedHeader = "LibraryItem";
            var mockView = GenerateMockView(type);

            List<IFolder> fakeFolders = new List<IFolder> { new Folder { Name = "Folder" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetFolders(type)).Returns(fakeFolders);
        
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnResourceTypeChanged();

            // Assert
            mockView.VerifySet(v => v.HeaderText = expectedHeader);
            // expect display to be called twice - once for initialisation and once for type changed event
            mockView.Verify(v => v.DisplayFolders(fakeFolders), Times.Exactly(2));
        }

        [TestMethod]
        public void AfterSelect_View_DisplayFolderItemsCalled_Concepts()
        {
            // Arrange
            var type = ResourceType.Concept;
            var mockView = GenerateMockView(type);

            List<IResource> fakeResources = new List<IResource> { new Concept { Name = "Concept" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetResources(type, 1)).Returns(fakeResources);
        
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnAfterSelect();

            // Assert
            mockView.Verify(v => v.DisplaySelectedFolderItems(fakeResources), Times.Once);
        }

        [TestMethod]
        public void AfterSelect_View_DisplayFolderItemsCalled_Protocols()
        {
            // Arrange
            var type = ResourceType.Protocol;
            var mockView = GenerateMockView(type);

            List<IResource> fakeResources = new List<IResource> { new Protocol{ Name = "Protocol" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetResources(type, 1)).Returns(fakeResources);
       
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnAfterSelect();

            // Assert
            mockView.Verify(v => v.DisplaySelectedFolderItems(fakeResources), Times.Once);
        }

        [TestMethod]
        public void AfterSelect_View_DisplayFolderItemsCalled_Templates()
        {
            // Arrange
            var type = ResourceType.Template;
            var mockView = GenerateMockView(type);

            List<IResource> fakeResources = new List<IResource> { new Template { Name = "Template" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetResources(type, 1)).Returns(fakeResources);
       
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnAfterSelect();

            // Assert
            mockView.Verify(v => v.DisplaySelectedFolderItems(fakeResources), Times.Once);
        }

        [TestMethod]
        public void AfterSelect_View_DisplayFolderItemsCalled_DocumentTemplates()
        {
            // Arrange
            var type = ResourceType.DocumentTemplate;
            var mockView = GenerateMockView(type);

            List<IResource> fakeResources = new List<IResource> { new DocumentTemplate { Name = "Document Template" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetResources(type, 1)).Returns(fakeResources);
       
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnAfterSelect();

            // Assert
            mockView.Verify(v => v.DisplaySelectedFolderItems(fakeResources), Times.Once);
        }

        [TestMethod]
        public void AfterSelect_View_DisplayFolderItemsCalled_LibraryItems()
        {
            // Arrange
            var type = ResourceType.LibraryItem;
            var mockView = GenerateMockView(type);

            List<IResource> fakeResources = new List<IResource> { new LibraryItem { Name = "Library Item" } };
            var mockService = GenerateFakeService(type);
            mockService.Setup(s => s.GetResources(type, 1)).Returns(fakeResources);
       
            IManagerViewPresenterCallbacks presenter = new ManagerViewPresenter(
                (IManagerView)mockView.Object,
                (IResourceService)mockService.Object);

            // Act
            presenter.OnAfterSelect();

            // Assert
            mockView.Verify(v => v.DisplaySelectedFolderItems(fakeResources), Times.Once);
        }

        private static Mock<IManagerView> GenerateMockView(ResourceType type)
        {
            var mockView = new Mock<IManagerView>();
            mockView.Setup(v => v.ResourceType).Returns(type);
            return mockView;
        }

        private static Mock<IResourceService> GenerateFakeService(ResourceType type)
        {
            var mockService = new Mock<IResourceService>();
            return mockService;
        }

    }
}
