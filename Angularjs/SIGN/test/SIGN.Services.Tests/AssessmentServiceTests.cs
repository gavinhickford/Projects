using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using SIGN.Mocks;
using SIGN.Services.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SIGN.Services.Tests
{
    public class AssessmentServiceTests
    {
        private Step _currentStep;
        private Step _trueStep;
        private Step _falseStep;
        private StepAction _trueAction;
        private StepAction _falseAction;
        private Decision _trueDecision;
        private Decision _falseDecision;

        private void InitialiseSteps()
        {
            _currentStep = new Step { Id = 1, Text = "True should get action 2, False should get action 3" };
            _trueStep = new Step { Id = 2, Text = "True Step" };
            _falseStep = new Step { Id = 3, Text = "False Step" };
            _trueAction = new StepAction { Id = 2, NextStep = _trueStep };
            _falseAction = new StepAction { Id = 3, NextStep = _falseStep };
            _trueDecision = new Decision { Id = 1, Step = _currentStep, Condition = true, Action = _trueAction };
            _falseDecision = new Decision { Id = 1, Step = _currentStep, Condition = false, Action = _falseAction };
        }

        [Fact]
        public void GetAssessment_ReturnsAssessmentById()
        {
            //Arrange
            const int id = 1;
            Assessment expectedAssessment = TestDataProvider.CreateTestAssessment(id);

            ISIGNRepository mockRepository = new MockRepository(
                expectedAssessments: new List<Assessment> { expectedAssessment });

            IAssessmentService service = new AssessmentService(mockRepository);

            // Act
            Assessment actual = service.GetAssessment(id);

            // Assert
            Assert.Equal(expectedAssessment.Id, actual.Id);
        }

        [Fact]
        public void GetAssessment_NoAssessment_ReturnsNull()
        {
            //Arrange
            ISIGNRepository mockRepository = new MockRepository(
                expectedAssessments: new List<Assessment>());

            IAssessmentService service = new AssessmentService(mockRepository);

            // Act
            Assessment actual = service.GetAssessment(1);

            // Assert
            Assert.Null(actual);
        }

        [Fact]
        public async void AddAssessment_Success_ReturnsTrue()
        {
            ISIGNRepository mockRepository = new MockRepository(
                expectedAssessments: new List<Assessment>());

            IAssessmentService service = new AssessmentService(mockRepository);
            Assessment newAssessment = TestDataProvider.CreateTestAssessment(0);
            bool result = await service.AddAssessment(1, newAssessment);
            Assert.True(result);
        }

        [Fact]
        public void GetNextStep_ConditionTrue_ReturnsCorrectStep()
        {
            // Arrange
            InitialiseSteps();
            IEnumerable<Step> steps = new List<Step> { _currentStep, _trueStep, _falseStep };
            IEnumerable<StepAction> stepActions = new List<StepAction> { _trueAction, _falseAction };
            IEnumerable<Decision> decisions = new List<Decision> { _trueDecision, _falseDecision };
            ISIGNRepository mockRepository = new MockRepository(steps, stepActions, decisions);
            IAssessmentService service = new AssessmentService(mockRepository);

            // Act 
            Step actual = service.GetNextStep(_currentStep.Id, true);

            // Assert
            Assert.Equal(_trueStep, actual);
        }

        [Fact]
        public void GetNextStep_ConditionFalse_ReturnsCorrectStep()
        {
            // Arrange
            InitialiseSteps();
            IEnumerable<Step> steps = new List<Step> { _currentStep, _trueStep, _falseStep };
            IEnumerable<StepAction> stepActions = new List<StepAction> { _trueAction, _falseAction };
            IEnumerable<Decision> decisions = new List<Decision> { _trueDecision, _falseDecision };
            ISIGNRepository mockRepository = new MockRepository(steps, stepActions, decisions);
            IAssessmentService service = new AssessmentService(mockRepository);

            // Act 
            Step actual = service.GetNextStep(_currentStep.Id, false);

            // Assert
            Assert.Equal(_falseStep, actual);
        }

        [Fact]
        public void GetStep_ReturnsCorrectStep()
        {
            // Arrange
            InitialiseSteps();
            IEnumerable<Step> steps = new List<Step> { _currentStep, _trueStep, _falseStep };
            IEnumerable<StepAction> stepActions = new List<StepAction> { _trueAction, _falseAction };
            IEnumerable<Decision> decisions = new List<Decision> { _trueDecision, _falseDecision };
            ISIGNRepository mockRepository = new MockRepository(steps, stepActions, decisions);
            IAssessmentService service = new AssessmentService(mockRepository);

            // Act
            Step actual = service.GetStep(_currentStep.Id);

            // Assert
            Assert.Equal(_currentStep, actual);
        }
    }
}
