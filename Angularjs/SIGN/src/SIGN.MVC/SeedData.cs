using Microsoft.AspNetCore.Identity;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.MVC
{
    public class SeedData
    {
        private ISIGNRepository _repository;
        private UserManager<SIGNUser> _userManager;
        private Guideline _guideline110;
        private Guideline _guideline119;
        private Guideline _guideline143;
        private Guideline _guideline153;
        private Assessment _initialAssessment110;
        private Assessment _initialPatientAssessment110;
        private Assessment _initialPaediatricAssessment110;
        private Step _step1;
        private Step _step2;
        private Step _step3;
        private Step _step4;
        private Step _step5;
        private Step _step6;
        private Step _step7;
        private Step _step8;
        private StepAction _action2;
        private StepAction _action3;
        private StepAction _action4;
        private StepAction _action5;
        private StepAction _action6;
        private StepAction _action7;
        private StepAction _action8;
        private Decision _decision1;
        private Decision _decision2;
        private Decision _decision3;
        private Decision _decision4;
        private Decision _decision5;
        private Decision _decision6;
        private Decision _decision7;
        private Decision _decision8;
        private Decision _decision11;
        private Decision _decision12;
        private Decision _decision13;
        private Decision _decision14;
        private Decision _decision10;
        private Decision _decision9;

        public SeedData(ISIGNRepository repository, UserManager<SIGNUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task EnsureSeedData()
        {
            if (await _userManager.FindByEmailAsync("gjhickford@sign.com") == null)
            {
                var user = new SIGNUser
                {
                    UserName = "GavinHickford",
                    Email = "gjhickford@sign.com"
                };

                var result = await _userManager.CreateAsync(user, "Pa$$word1");
            }


            if (!_repository.GetGuidelines().Any())
            {
                SetUpGuidelines();
                SetUpAssessments();
                SetUpSteps();
                SetUpActions();
                SetUpDecisions();
                LinkData();

                _repository.AddDecision(_decision1);
                _repository.AddDecision(_decision2);
                _repository.AddDecision(_decision3);
                _repository.AddDecision(_decision4);
                _repository.AddDecision(_decision5);
                _repository.AddDecision(_decision6);
                _repository.AddDecision(_decision7);
                _repository.AddDecision(_decision8);
                _repository.AddDecision(_decision9);
                _repository.AddDecision(_decision10);
                _repository.AddDecision(_decision11);
                _repository.AddDecision(_decision12);
                _repository.AddDecision(_decision13);
                _repository.AddDecision(_decision14);

                _repository.SaveGuideline(_guideline110);
                _repository.SaveGuideline(_guideline119);
                _repository.SaveGuideline(_guideline143);
                _repository.SaveGuideline(_guideline153);
                await _repository.SaveChangesAsync();
            }
        }

        private void SetUpDecisions()
        {
            // TODO - don't need these linked to an assessment
            _decision1 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step1,
                Action = _action3
            };

            _decision2 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step1,
                Action = _action2
            };

            _decision3 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step2,
                Action = _action3
            };

            _decision4 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step2,
                Action = _action5
            };

            _decision5 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step3,
                Action = _action3
            };

            _decision6 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step3,
                Action = _action5
            };

            _decision7 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step5,
                Action = _action3
            };

            _decision8 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step5,
                Action = _action6
            };

            _decision9 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step6,
                Action = _action3
            };

            _decision10 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step6,
                Action = _action7
            };

            _decision11 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step7,
                Action = _action3
            };

            _decision12 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step7,
                Action = _action8
            };

            _decision13 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = true,
                Step = _step8,
                Action = _action4
            };

            _decision14 = new Decision
            {
                Assessment = _initialAssessment110,
                Condition = false,
                Step = _step8,
                Action = _action3
            };
        }

        private void SetUpActions()
        {
            _action2 = new StepAction
            {
                NextStep = _step2
            };

            _action3 = new StepAction
            {
                NextStep = _step3
            };

            _action4 = new StepAction
            {
                NextStep = _step4
            };

            _action5 = new StepAction
            {
                NextStep = _step5
            };

            _action6 = new StepAction
            {
                NextStep = _step6
            };

            _action7 = new StepAction
            {
                NextStep = _step7
            };

            _action8 = new StepAction
            {
                NextStep = _step8
            };
        }

        private void LinkData()
        {
            //_initialAssessment110.Decisions = new Collection<Decision> { _decision1, _decision2, _decision3, _decision4 };
            _initialAssessment110.FirstStep = _step1;
            _initialPaediatricAssessment110.FirstStep = _step1;
            _initialPatientAssessment110.FirstStep = _step1;

            _guideline110.Assessments.Add(_initialAssessment110);
            _guideline110.Assessments.Add(_initialPatientAssessment110);
            _guideline110.Assessments.Add(_initialPaediatricAssessment110);
        }

        private void SetUpSteps()
        {
            _step1 = new Step
            {
                Text = "Is the patient unconsciousness, or show lack of full consciousness(e.g. problems keeping eyes open)",
                Type = StepType.Question
            };

            _step2 = new Step
            {
                Text = "Does the patient show any focal (i.e. restricted to a particular part of the body or a particular activity) neurological deficit since the injury",
                Type = StepType.Question
            };

            _step3 = new Step
            {
                Text = "Refer patient to the emergency ambulance services (999) for emergency transport to the emergency department",
                Type = StepType.Recommendation
            };

            _step4 = new Step
            {
                Text = "Assessment Complete",
                Type = StepType.Complete
            };

            _step5 = new Step
            {
                Text = "Is there any suspicion of a skull fracture or penetrating head injury?",
                Type = StepType.Question
            };

            _step6 = new Step
            {
                Text = "Has there been any seizure (convulsion or fit) since the injury?",
                Type = StepType.Question
            };

            _step7 = new Step
            {
                Text = "Was this a high energy head injury?",
                Type = StepType.Question
            };

            _step8 = new Step
            {
                Text = "Can the injured person reach hospital safely without emergency transport?",
                Type = StepType.Question
            };
        }

        private void SetUpAssessments()
        {
            _initialAssessment110 = new Assessment
            {
                Name = "Initial Telephone Assessment",
                Type = AssessmentType.Telephone,
                Description = "Telephone advice services should assess any patient who has sustained a head injury to determine whether the patient should be referred to the emergency ambulance services(999) for emergency transport to the emergency department"
            };

            _initialPatientAssessment110 = new Assessment
            {
                Name = "Initial Patient Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of patient using Glasgow coma scale"
            };

            _initialPaediatricAssessment110 = new Assessment
            {
                Name = "Initial Paediatric Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of paediatric patients"
            };
        }

        private void SetUpGuidelines()
        {
            _guideline110 = new Guideline
            {
                Name = "Early management of patients with a head injury",
                Number = 110,
                DatePublished = new DateTime(2009, 5, 1),
                Author = "GavinHickford",
                Status = GuidelineStatus.GreaterThanSevenYears
            };
            _guideline119 = new Guideline
            {
                Name = "Management of patients with stroke: identification and management of dysphagia",
                Number = 119,
                DatePublished = new DateTime(2010, 6, 1),
                Author = "GavinHickford",
                Status = GuidelineStatus.CurrentThreeToSevenYears
            };
            _guideline143 = new Guideline
            {
                Name = "Diagnosis and management of epilepsy in adults",
                Number = 143,
                DatePublished = new DateTime(2015, 5, 1),
                Author = "JohnSmith",
                Status = GuidelineStatus.CurrentThreeToSevenYears
            };
            _guideline153 = new Guideline
            {
                Name = "British guideline on the management of asthma",
                Number = 153,
                DatePublished = new DateTime(2016, 9, 1),
                Author = "JohnSmith",
                Status = GuidelineStatus.CurrentLessThanThreeYears
            };
        }
    }
}
