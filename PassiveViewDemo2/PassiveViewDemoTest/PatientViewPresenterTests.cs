using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassiveViewDemo2.Presenters;
using Moq;
using PassiveViewDemo2.Views;
using PassiveViewDemo2.Model;

namespace PassiveViewDemoTest
{
    [TestClass]
    public class PatientViewPresenterTests
    {
        [TestMethod]
        public void LoadPatient_returns_correct_patient()
        {
            // Arrange
            Mock<IPatientView> mockView = new Mock<IPatientView>();
            PatientViewPresenter presenter = new PatientViewPresenter(mockView.Object);

            mockView.Setup(p => p.PatientIdInput).Returns("1");
                
            // Act
            presenter.LoadPatient();
            
            // Assert
            Assert.AreEqual(mockView.Object.PatientName, "Will Smith");
        }
    }
}
