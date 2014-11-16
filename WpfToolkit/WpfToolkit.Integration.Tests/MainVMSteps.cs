using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using WpfToolkit.VM;

namespace WpfToolkit.Integration.Tests
{
    [Binding]
    public class MainVMSteps
    {
        [Given(@"I am logged to the organisation named '(.*)'")]
        public void GivenIAmLoggedToTheOrganisationNamed(string organisationName)
        {
            ScenarioContext.Current["OrganisationName"] = organisationName;
        }

        [Given(@"the organisation has these concept folders")]
        public void GivenTheOrganisationHasTheseConceptFolders(Table table)
        {
            var folders = new List<Folder>(); 
            
            foreach (var row in table.Rows)
            {
                int id = int.Parse(row["Id"]);
                int parentId = int.Parse(row["ParentId"]);

                folders.Add(new Folder { 
                    Name = row["Name"],
                    Id = id,
                    ParentId = parentId 
                });
            }

            var mockService = new Mock<IFolderService>();
            mockService.Setup(f => f.GetFolders()).Returns(folders);
            ScenarioContext.Current["FolderService"] = mockService.Object;
        }

        [When(@"I open the resource manager")]
        public void WhenIOpenTheResourceManager()
        {
            MainVM mainVM = new MainVM(
                (IFolderService)ScenarioContext.Current["FolderService"],
                (string)ScenarioContext.Current["OrganisationName"]
            );
            ScenarioContext.Current["MainVM"] = mainVM;
        }

        [Then(@"I should see a root folder named '(.*)'")]
        public void ThenIShouldSeeARootFolderNamed(string folderName)
        {
            MainVM mainVM = (MainVM)ScenarioContext.Current["MainVM"];
            string expectedOrganisationName = (string)ScenarioContext.Current["OrganisationName"];

            Assert.AreEqual(expectedOrganisationName, mainVM.ChildVM.Folders[0].Name);
        }
    }
}
