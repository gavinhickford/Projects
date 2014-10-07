using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GenericResources.Common.Interfaces;
using System.Collections.Generic;
using GenericResources.Common.Entities;
using GenericResources.Domain.Business;
using GenericResources.Data.Factories;
using GenericResources.Common.Enums;

namespace GenericResources.Tests.Domain.Business
{
    [TestClass]
    public class ResourceBusinessTest
    {
        [TestMethod]
        public void ResourceBusiness_GetFolders_GetsSingleFolder()
        {
            List<IFolder> expected = new List<IFolder>{ new Folder{ Name = "Test Folder" }};
            var mockDataStore = new Mock<IResourceDataStore>();
            mockDataStore.Setup(d => d.GetFolders()).Returns(expected);

            var mockFactory = new Mock<IDataStoreFactory>();
            mockFactory.Setup(f => f.CreateDataStore(ResourceType.Concept)).Returns(mockDataStore.Object); 

            IResourceBusiness business = new ResourceBusiness(mockFactory.Object);
            List<IFolder> actual = business.GetFolders(ResourceType.Concept);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].Name, actual[0].Name);
        }
    }
}
